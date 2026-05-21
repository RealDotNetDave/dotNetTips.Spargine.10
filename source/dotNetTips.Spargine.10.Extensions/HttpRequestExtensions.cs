// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 06-01-2018
//
// Last Modified By : David McCarter
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="HttpRequestExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>
// Extension methods for <see cref="Microsoft.AspNetCore.Http.HttpRequest"/> providing request
// inspection and body-reading utilities. Includes <c>AddRequestId</c>, <c>GetAbsoluteUri</c>,
// <c>GetBearerToken</c>, <c>GetHeaderValue</c>, <c>GetRawBodyBytesAsync</c>,
// <c>GetRawBodyStringAsync</c>, <c>HasJsonContentType</c>, <c>IsContentType</c>,
// and <c>TryGetBody</c> (with reflection-based and trim-safe overloads).
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="HttpRequest"/> that simplify request inspection,
/// header access, body reading, and JSON deserialization.
/// </summary>
/// <remarks>
/// Body-reading methods (<c>GetRawBodyBytesAsync</c>, <c>GetRawBodyStringAsync</c>) copy the
/// request body into a managed buffer. <c>TryGetBody</c> offers both a reflection-based overload
/// (annotated with <see cref="RequiresUnreferencedCodeAttribute"/>) and a trim-safe overload that
/// accepts <see cref="JsonTypeInfo{T}"/>.
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
	[Information(nameof(GetAbsoluteUri), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[Information(nameof(GetBearerToken), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[Information(nameof(GetHeaderValue), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	/// <param name="request">The <see cref="HttpRequest"/> whose body will be read.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{TResult}"/> whose result is the raw body as a <see cref="byte"/> array.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
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
	/// Retrieves the raw body as a string from the <see cref="HttpRequest" /> body stream.
	/// Validates that <paramref name="request" /> and <paramref name="encoding" /> are not null.
	/// </summary>
	/// <param name="request">The <see cref="HttpRequest"/> whose body will be read.</param>
	/// <param name="encoding">The character encoding to use when reading the body. Defaults to UTF-8 if not specified.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{TResult}"/> whose result is the raw body as a <see cref="string"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> or <paramref name="encoding"/> is null.</exception>
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
	[Information(nameof(HasJsonContentType), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	[Information(nameof(IsContentType), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsContentType([DisallowNull] this HttpRequest request, [DisallowNull] string contentType)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(contentType);

		var requestContentType = request.ArgumentNotNull().ContentType;

		return requestContentType is not null &&
			requestContentType.StartsWith(contentType, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Tries to deserialize the <see cref="HttpRequest" /> body into an instance of <typeparamref name="T"/>.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <typeparam name="T">The type to deserialize the request body into.</typeparam>
	/// <param name="request">The <see cref="HttpRequest"/> whose body will be deserialized.</param>
	/// <param name="value">When this method returns <see langword="true"/>, contains the deserialized value; otherwise, <c>default</c>.</param>
	/// <returns><see langword="true"/> if the body was successfully deserialized into a non-null instance of <typeparamref name="T"/>; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	/// <remarks>Original code by Jerry Nixon. For trim-safe deserialization, use the <see cref="JsonTypeInfo{T}"/> overload.</remarks>
	[Pure]
	[RequiresUnreferencedCode("JSON deserialization might require types that cannot be statically analyzed. Use the JsonTypeInfo<T> overload in trimmed apps.")]
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
			var json = Encoding.UTF8.GetString(bytes);

			value = JsonSerializer.Deserialize<T>(json);

			return value is not null;
		}
		catch (JsonException)
		{
			value = default;
			return false;
		}
	}

	/// <summary>
	/// Tries to read the raw body bytes from the <see cref="HttpRequest" />.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <param name="request">The <see cref="HttpRequest"/> whose body will be read.</param>
	/// <param name="value">When this method returns <see langword="true"/>, contains the raw body as a <see cref="byte"/> array; otherwise, an empty array.</param>
	/// <returns><see langword="true"/> if the body was successfully read and is non-empty; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if the <see cref="HttpRequest"/> body is empty.</exception>
	/// <remarks>Original code by Jerry Nixon.</remarks>
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

	/// <summary>
	/// Tries to deserialize the <see cref="HttpRequest"/> body into an instance of <typeparamref name="T"/>
	/// using a source-generated <see cref="JsonTypeInfo{T}"/> for trim-safe, AOT-compatible deserialization.
	/// Validates that <paramref name="request"/> and <paramref name="typeInfo"/> are not null.
	/// </summary>
	/// <typeparam name="T">The type to deserialize the request body into.</typeparam>
	/// <param name="request">The <see cref="HttpRequest"/> whose body will be deserialized.</param>
	/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> used for trim-safe deserialization.</param>
	/// <param name="value">
	/// When this method returns <see langword="true"/>, contains the deserialized value of type <typeparamref name="T"/>;
	/// otherwise, contains the default value for <typeparamref name="T"/>.
	/// </param>
	/// <returns>
	/// <see langword="true"/> if the body was successfully read and deserialized into a non-null instance of <typeparamref name="T"/>;
	/// otherwise, <see langword="false"/>.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> or <paramref name="typeInfo"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if the request body is empty.</exception>
	/// <example>
	/// Here is how you can use the trim-safe TryGetBody overload:
	/// <code>
	/// if (request.TryGetBody(MyJsonContext.Default.MyModel, out var model))
	/// {
	///     // use model
	/// }
	/// </code>
	/// </example>
	[Pure]
	[Information(nameof(TryGetBody), "David McCarter", "5/12/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool TryGetBody<T>([DisallowNull] this HttpRequest request, [DisallowNull] JsonTypeInfo<T> typeInfo, out T? value)
	{
		request = request.ArgumentNotNull();
		typeInfo = typeInfo.ArgumentNotNull();

		if (!request.TryGetBody(out var bytes))
		{
			value = default;
			return false;
		}

		try
		{
			var json = Encoding.UTF8.GetString(bytes);

			value = JsonSerializer.Deserialize(json, typeInfo);

			return value is not null;
		}
		catch (JsonException)
		{
			value = default;
			return false;
		}
	}

}
