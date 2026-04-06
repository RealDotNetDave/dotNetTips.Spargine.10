// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-04-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="HttpContextExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for HttpContext.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using DotNetTips.Spargine.Core;
using Microsoft.AspNetCore.Http;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="HttpContext"/>, enhancing its functionality with additional utility methods.
/// These methods include getting the remote IP address of the client, which can be useful for logging, analytics, and security purposes.
/// </summary>
/// <remarks>
/// The extension methods in this class are designed to simplify common operations performed on <see cref="HttpContext"/> instances,
/// making it easier to retrieve information such as the client's IP address. This can be particularly useful in web applications
/// for tracking user activity or implementing security measures based on IP addresses.
/// </remarks>
[Information(Status = Status.Available)]
public static class HttpContextExtensions
{

	/// <summary>
	/// Gets the remote IP address.
	/// Validates that <paramref name="context" /> is not null.
	/// </summary>
	/// <param name="context">The context.</param>
	/// <returns>System.String.</returns>
	[Pure]
	[return: NotNull]
	[Information("Original code from: https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20", "David McCarter", "9/04/2017", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetRemoteIPAddress([DisallowNull] this HttpContext context)
	{
		return context.ArgumentNotNull().Connection.RemoteIpAddress.ToString();
	}

}
