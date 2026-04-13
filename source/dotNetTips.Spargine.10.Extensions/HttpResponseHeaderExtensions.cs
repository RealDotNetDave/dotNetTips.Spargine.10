// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-13-2026
// ***********************************************************************
// <copyright file="HttpResponseHeaderExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for HttpResponseHeader.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for working with <see cref="HttpResponseHeader"/>, enhancing its functionality by allowing easy retrieval of header names.
/// </summary>
/// <remarks>
/// This class simplifies the process of converting <see cref="HttpResponseHeader"/> enumeration values to their corresponding string names.
/// It is particularly useful for logging, debugging, or any scenario where the string representation of an HTTP response header is needed.
/// </remarks>
[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.UpdateDocumentation)]
public static class HttpResponseHeaderExtensions
{

	/// <summary>
	/// The header names
	/// </summary>
	private static readonly string[] _headerNames = [
		"Cache-Control",
		"Connection",
		"Date",
		"Keep-Alive",
		"Pragma",
		"Trailer",
		"Transfer-Encoding",
		"Upgrade",
		"Via",
		"Warning",
		"Allow",
		"Content-Length",
		"Content-Type",
		"Content-Encoding",
		"Content-Language",
		"Content-Location",
		"Content-MD5",
		"Content-Range",
		"Expires",
		"Last-Modified",
		"Accept-Ranges",
		"Age",
		"ETag",
		"Location",
		"Proxy-Authenticate",
		"Retry-After",
		"Server",
		"Set-Cookie",
		"Vary",
		"WWW-Authenticate",
	];

	/// <summary>
	/// Adds a unique request identifier to the HTTP response headers.
	/// Uses a ULID (Universally Unique Lexicographically Sortable Identifier) as the value of the X-Request-UUID header.
	/// </summary>
	/// <param name="headers">The <see cref="HttpResponseHeaders"/> to which the request identifier will be added.</param>
	/// <returns>The generated unique request identifier.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(AddRequestId), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string AddRequestId([DisallowNull] this HttpResponseHeaders headers)
	{
		headers = headers.ArgumentNotNull();

		var id = Ulid.NewUlid().ToString();

		headers.Add("X-Request-UUID", id);

		return id;
	}

	/// <summary>
	/// Gets the ETag value from the response headers as a string.
	/// Returns <see langword="null"/> if no ETag header is present.
	/// Validates that <paramref name="headers"/> is not null.
	/// </summary>
	/// <param name="headers">The <see cref="HttpResponseHeaders"/> from which to read the ETag.</param>
	/// <returns>The ETag value as a <see cref="string"/>, or <see langword="null"/> if not present.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetETagValue), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string? GetETagValue([DisallowNull] this HttpResponseHeaders headers)
	{
		return headers.ArgumentNotNull().ETag?.Tag;
	}

	/// <summary>
	/// Gets the first value of a named header from the response headers.
	/// Returns <see langword="null"/> if the header is not present.
	/// Validates that <paramref name="headers"/> and <paramref name="headerName"/> are not null or empty.
	/// </summary>
	/// <param name="headers">The <see cref="HttpResponseHeaders"/> from which to read the header.</param>
	/// <param name="headerName">The name of the header to retrieve.</param>
	/// <returns>The first header value as a <see cref="string"/>, or <see langword="null"/> if not found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="headerName"/> is null or whitespace.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetHeaderValue), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string? GetHeaderValue([DisallowNull] this HttpResponseHeaders headers, [DisallowNull] string headerName)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(headerName);

		return headers.ArgumentNotNull().TryGetValues(headerName, out var values)
			? values.FirstOrDefault()
			: null;
	}

	/// <summary>
	/// Gets the <see cref="HttpRequestHeader" /> name.
	/// </summary>
	/// <param name="header">The header.</param>
	/// <returns>System.String.</returns>
	[Pure]
	[return: NotNull]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetName([DisallowNull] this HttpResponseHeader header)
	{
		header = header.ArgumentDefined();

		return _headerNames[(int)header];
	}

	/// <summary>
	/// Retrieves the request identifier from the HTTP headers.
	/// </summary>
	/// <param name="headers">The HTTP headers from which the request identifier will be retrieved.</param>
	/// <returns>The request identifier if found; otherwise, an empty string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetRequestId), author: "David McCarter", createdOn: "3/18/2024", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetRequestId([DisallowNull] this HttpResponseHeaders headers)
	{
		headers = headers.ArgumentNotNull();

		return headers.TryGetValues("X-Request-UUID", out var values) ? values.FirstOrDefault() ?? string.Empty : string.Empty;
	}

	/// <summary>
	/// Determines whether the response headers contain a header with the specified name.
	/// Validates that <paramref name="headers"/> and <paramref name="headerName"/> are not null or empty.
	/// </summary>
	/// <param name="headers">The <see cref="HttpResponseHeaders"/> to check.</param>
	/// <param name="headerName">The name of the header to look for.</param>
	/// <returns><see langword="true"/> if the header exists; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="headerName"/> is null or whitespace.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasHeader), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool HasHeader([DisallowNull] this HttpResponseHeaders headers, [DisallowNull] string headerName)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(headerName);

		return headers.ArgumentNotNull().Contains(headerName);
	}

	/// <summary>
	/// Attempts to compute the retry delay from the Retry-After response header.
	/// Handles both delta-seconds and HTTP-date formats.
	/// Returns <see langword="false"/> if the Retry-After header is not present.
	/// Validates that <paramref name="headers"/> is not null.
	/// </summary>
	/// <param name="headers">The <see cref="HttpResponseHeaders"/> from which to read the Retry-After header.</param>
	/// <param name="delay">When this method returns <see langword="true"/>, contains the delay duration. Otherwise, <see cref="TimeSpan.Zero"/>.</param>
	/// <returns><see langword="true"/> if the Retry-After header was found and parsed; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="headers"/> is null.</exception>
	[Pure]
	[Information(nameof(TryGetRetryAfterDelay), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool TryGetRetryAfterDelay([DisallowNull] this HttpResponseHeaders headers, out TimeSpan delay)
	{
		var retryAfter = headers.ArgumentNotNull().RetryAfter;

		if (retryAfter is null)
		{
			delay = TimeSpan.Zero;
			return false;
		}

		if (retryAfter.Delta.HasValue)
		{
			delay = retryAfter.Delta.Value;
			return true;
		}

		if (retryAfter.Date.HasValue)
		{
			var remaining = retryAfter.Date.Value - DateTimeOffset.UtcNow;
			delay = remaining > TimeSpan.Zero ? remaining : TimeSpan.Zero;
			return true;
		}

		delay = TimeSpan.Zero;
		return false;
	}

}
