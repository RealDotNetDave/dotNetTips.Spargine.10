// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 06-01-2018
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="HttpRequestExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for HttpRequest.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="HttpRequest"/> to enhance its functionality.
/// These methods include retrieving the raw body as a byte array or string, and trying to get the body directly into a specified type.
/// </summary>
/// <remarks>
/// The extension methods in this class aim to simplify the process of working with the request body of <see cref="HttpRequest"/>.
/// They provide convenient ways to access the raw body for various purposes such as logging, validation, or further processing.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class HttpRequestExtensions
{
	/// <summary>
	/// The "Bearer " prefix used to identify Bearer tokens in the Authorization header.
	/// </summary>
	private const string BearerPrefix = "Bearer ";

	/// <summary>
	/// Adds a unique request identifier to the HTTP headers.
	/// </summary>
	/// <param name="headers">The HTTP headers to which the request identifier will be added.</param>
	/// <returns>The generated unique request identifier.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(AddRequestId), author: "David McCarter", createdOn: "3/18/2024", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string AddRequestId([DisallowNull] this HttpRequestHeaders headers)
	{
		headers = headers.ArgumentNotNull();

		var id = Ulid.NewUlid().ToString();

		headers.Add("X-Request-UUID", id);

		return id;
	}

	/// <summary>
	/// Builds the absolute <see cref="Uri"/> from the request's scheme, host, path base, path, and query string.
	/// Validates that <paramref name="request"/> is not null.
	/// </summary>
	/// <param name="request">The <see cref="HttpRequest"/> from which to build the absolute URI.</param>
	/// <returns>The fully qualified absolute <see cref="Uri"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetAbsoluteUri), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static Uri GetAbsoluteUri([DisallowNull] this HttpRequest request)
	{
		request = request.ArgumentNotNull();

		return new Uri(string.Concat(
			request.Scheme,
			"://",
			request.Host.Value,
			request.PathBase.Value,
			request.Path.Value,
			request.QueryString.Value));
	}

	/// <summary>
	/// Extracts the Bearer token from the Authorization header of the request.
	/// Returns <see langword="null"/> if the Authorization header is missing or does not use the Bearer scheme.
	/// Validates that <paramref name="request"/> is not null.
	/// </summary>
	/// <param name="request">The <see cref="HttpRequest"/> from which to extract the Bearer token.</param>
	/// <returns>The Bearer token as a <see cref="string"/>, or <see langword="null"/> if not present.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetBearerToken), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string? GetBearerToken([DisallowNull] this HttpRequest request)
	{
		var authorization = request.ArgumentNotNull().Headers.Authorization;

		if (authorization == StringValues.Empty)
		{
			return null;
		}

		var headerValue = authorization.ToString();

		return headerValue.StartsWith(BearerPrefix, StringComparison.OrdinalIgnoreCase)
			? headerValue[BearerPrefix.Length..].Trim()
			: null;
	}

	/// <summary>
	/// Retrieves the value of a specific request header by name.
	/// Returns <see langword="null"/> if the header is not present.
	/// Validates that <paramref name="request"/> and <paramref name="headerName"/> are not null or empty.
	/// </summary>
	/// <param name="request">The <see cref="HttpRequest"/> from which to read the header.</param>
	/// <param name="headerName">The name of the header to retrieve.</param>
	/// <returns>The header value as a <see cref="string"/>, or <see langword="null"/> if not found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="headerName"/> is null or whitespace.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetHeaderValue), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string? GetHeaderValue([DisallowNull] this HttpRequest request, [DisallowNull] string headerName)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(headerName);

		var values = request.ArgumentNotNull().Headers[headerName];

		return values != StringValues.Empty ? values.ToString() : null;
	}

	/// <summary>
	/// Retrieves the raw body as a byte array from the <see cref="HttpRequest" /> body stream.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <param name="request">The request.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>Task&lt;System.Byte[]&gt;.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Pure]
	[Information(nameof(GetRawBodyBytesAsync), "David McCarter", "11/07/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static async Task<byte[]> GetRawBodyBytesAsync([DisallowNull] this HttpRequest request, CancellationToken cancellationToken = default)
	{
		request = request.ArgumentNotNull();

		using (var ms = new MemoryStream(2048))
		{
			await request.Body.CopyToAsync(ms, cancellationToken).ConfigureAwait(false);

			return ms.ToArray();
		}
	}

	/// <summary>
	/// Retrieve the raw body as a string from the <see cref="HttpRequest" /> body stream.
	/// Validates that <paramref name="request" /> and <paramref name="encoding" /> is not null.
	/// </summary>
	/// <param name="request">Request instance to apply to.</param>
	/// <param name="encoding">Optional - Encoding, defaults to UTF8.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>Task&lt;System.String&gt;.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> or <paramref name="encoding"/> is null.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Pure]
	[Information(nameof(GetRawBodyStringAsync), "David McCarter", "11/07/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static async Task<string> GetRawBodyStringAsync([DisallowNull] this HttpRequest request, [DisallowNull] Encoding encoding, CancellationToken cancellationToken = default)
	{
		request = request.ArgumentNotNull();
		encoding = encoding.ArgumentNotNull();

		using (var reader = new StreamReader(request.Body, encoding))
		{
			return await reader.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Determines whether the request has a JSON content type (application/json).
	/// Validates that <paramref name="request"/> is not null.
	/// </summary>
	/// <param name="request">The <see cref="HttpRequest"/> to check.</param>
	/// <returns><see langword="true"/> if the content type starts with "application/json"; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasJsonContentType), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool HasJsonContentType([DisallowNull] this HttpRequest request)
	{
		var contentType = request.ArgumentNotNull().ContentType;

		return contentType is not null &&
			contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Determines whether the request content type matches the specified value using an ordinal case-insensitive comparison.
	/// Validates that <paramref name="request"/> and <paramref name="contentType"/> are not null or empty.
	/// </summary>
	/// <param name="request">The <see cref="HttpRequest"/> to check.</param>
	/// <param name="contentType">The content type to compare against (e.g., "text/plain").</param>
	/// <returns><see langword="true"/> if the request content type starts with <paramref name="contentType"/>; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="contentType"/> is null or whitespace.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsContentType), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool IsContentType([DisallowNull] this HttpRequest request, [DisallowNull] string contentType)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(contentType);

		var requestContentType = request.ArgumentNotNull().ContentType;

		return requestContentType is not null &&
			requestContentType.StartsWith(contentType, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Tries the get <see cref="HttpRequest" /> body.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="request">The HTTPRequest object.</param>
	/// <param name="value">The return value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">request</exception>
	/// <remarks>Original code by Jerry Nixon</remarks>
	[Pure]
	[Information(nameof(TryGetBody), "David McCarter", "11/07/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool TryGetBody<T>([DisallowNull] this HttpRequest request, out T? value)
	{
		request = request.ArgumentNotNull();

		if (!request.TryGetBody(out var bytes))
		{
			value = default;
			return false;
		}

		try
		{
			value = JsonSerializer.Deserialize<T>(BitConverter.ToString(bytes));

			return true;
		}
		catch (ArgumentNullException)
		{
			value = default;
			return false;
		}
	}

	/// <summary>
	/// Tries the get <see cref="HttpRequest" /> body.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <param name="request">The HTTPRequest object.</param>
	/// <param name="value">The return value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">request</exception>
	/// <exception cref="ArgumentException">HttpRequest has no body.</exception>
	/// <remarks>Original code by Jerry Nixon</remarks>
	[Pure]
	[Information(nameof(TryGetBody), "David McCarter", "11/07/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool TryGetBody([DisallowNull] this HttpRequest request, out byte[] value)
	{
		request = request.ArgumentNotNull();

		if ((request.Body?.Length ?? 0) == 0)
		{
			ExceptionThrower.ThrowArgumentException(Resources.HttpRequestHasNoBody, nameof(request.Body));
		}

		value = GetBytes(request);

		return value.IsNotEmpty();

		static byte[] GetBytes(HttpRequest request)
		{
			byte[] bytes;

			using (var ms = new MemoryStream())
			{
				request.Body.CopyTo(ms);
				bytes = ms.ToArray();
			}

			return bytes;
		}
	}

}
