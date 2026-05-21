// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-04-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="HttpContextExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="Microsoft.AspNetCore.Http.HttpContext"/> providing request
// inspection utilities. Includes <c>GetAbsoluteUri</c>, <c>GetBearerToken</c>,
// <c>GetRemoteIPAddress</c>, <c>GetRequestHeaderValue</c>, <c>GetUserClaim</c>,
// and <c>IsAuthenticated</c>.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using DotNetTips.Spargine.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="HttpContext"/> that simplify common request
/// inspection tasks including URI construction, authentication, header access, and claim retrieval.
/// </summary>
/// <remarks>
/// Available utilities: <c>GetAbsoluteUri</c> builds the fully qualified request URI;
/// <c>GetBearerToken</c> extracts the Bearer token from the Authorization header;
/// <c>GetRemoteIPAddress</c> returns the client's remote IP address;
/// <c>GetRequestHeaderValue</c> retrieves a named request header;
/// <c>GetUserClaim</c> looks up a claim value from the authenticated user;
/// and <c>IsAuthenticated</c> checks whether the current user is authenticated.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class HttpContextExtensions
{

	/// <summary>
	/// Extracts the absolute URI of the current request, including scheme, host, path base, path, and query string.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <param name="context">The <see cref="HttpContext"/> from which to build the absolute URI.</param>
	/// <returns>The fully qualified absolute <see cref="Uri"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="context"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetAbsoluteUri), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Uri GetAbsoluteUri([DisallowNull] this HttpContext context)
	{
		var request = context.ArgumentNotNull().Request;

		return new Uri(string.Concat(
			request.Scheme,
			"://",
			request.Host.Value,
			request.PathBase.Value,
			request.Path.Value,
			request.QueryString.Value));
	}

	/// <summary>
	/// Extracts the Bearer token from the Authorization header of the current request.
	/// Returns <see langword="null"/> if the Authorization header is missing or does not use the Bearer scheme.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <param name="context">The <see cref="HttpContext"/> from which to extract the Bearer token.</param>
	/// <returns>The Bearer token as a <see cref="string"/>, or <see langword="null"/> if not present.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="context"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetBearerToken), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string? GetBearerToken([DisallowNull] this HttpContext context)
	{
		var authorization = context.ArgumentNotNull().Request.Headers.Authorization;

		if (authorization == StringValues.Empty)
		{
			return null;
		}

		var headerValue = authorization.ToString();

		return headerValue.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase)
			? headerValue["Bearer ".Length..].Trim()
			: null;
	}

	/// <summary>
	/// Gets the remote IP address of the connected client.
	/// Validates that <paramref name="context" /> is not null.
	/// </summary>
	/// <param name="context">The <see cref="HttpContext"/> from which to read the remote IP address.</param>
	/// <returns>The remote IP address as a <see cref="string"/>, or an empty string if the address is unavailable.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="context"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[Information("Original code from: https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20", "David McCarter", "9/04/2017", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetRemoteIPAddress([DisallowNull] this HttpContext context)
	{
		return context.ArgumentNotNull().Connection.RemoteIpAddress?.ToString() ?? string.Empty;
	}

	/// <summary>
	/// Retrieves the value of a specific request header by name.
	/// Returns <see langword="null"/> if the header is not present.
	/// Validates that <paramref name="context"/> and <paramref name="headerName"/> are not null or empty.
	/// </summary>
	/// <param name="context">The <see cref="HttpContext"/> from which to read the header.</param>
	/// <param name="headerName">The name of the header to retrieve.</param>
	/// <returns>The header value as a <see cref="string"/>, or <see langword="null"/> if not found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="context"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="headerName"/> is null or whitespace.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetRequestHeaderValue), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string? GetRequestHeaderValue([DisallowNull] this HttpContext context, [DisallowNull] string headerName)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(headerName);

		var values = context.ArgumentNotNull().Request.Headers[headerName];

		return values != StringValues.Empty ? values.ToString() : null;
	}

	/// <summary>
	/// Gets the value of a specific <see cref="Claim"/> from the authenticated user's claims.
	/// Returns <see langword="null"/> if the claim type is not found.
	/// Validates that <paramref name="context"/> and <paramref name="claimType"/> are not null or empty.
	/// </summary>
	/// <param name="context">The <see cref="HttpContext"/> from which to read user claims.</param>
	/// <param name="claimType">The claim type to look up (e.g., <see cref="ClaimTypes.NameIdentifier"/>).</param>
	/// <returns>The claim value as a <see cref="string"/>, or <see langword="null"/> if not found.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="context"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="claimType"/> is null or whitespace.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetUserClaim), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string? GetUserClaim([DisallowNull] this HttpContext context, [DisallowNull] string claimType)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(claimType);

		return context.ArgumentNotNull().User?.FindFirst(claimType)?.Value;
	}

	/// <summary>
	/// Determines whether the current user is authenticated.
	/// Validates that <paramref name="context"/> is not null.
	/// </summary>
	/// <param name="context">The <see cref="HttpContext"/> to check for authentication status.</param>
	/// <returns><see langword="true"/> if the user's identity is authenticated; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="context"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsAuthenticated), "David McCarter", "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsAuthenticated([DisallowNull] this HttpContext context)
	{
		return context.ArgumentNotNull().User?.Identity?.IsAuthenticated ?? false;
	}

}
