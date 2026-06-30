// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : Copilot Agent
// Created          : 06-12-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 06-12-2026
// ***********************************************************************
// <copyright file="HttpClientOptions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Configuration options record for creating an optimized HttpClient via HttpClientHelper.CreateOptimizedHttpClient.
// </summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Net.Http;

/// <summary>
/// Holds configuration settings for creating a performance-optimized <see cref="HttpClient"/>
/// via <see cref="HttpClientHelper.CreateOptimizedHttpClient"/>.
/// All properties carry sensible defaults so the record can be used as-is or customized with <c>with</c> expressions.
/// </summary>
[Information("Holds configuration settings for creating a performance-optimized HttpClient.", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
public sealed record HttpClientOptions
{

	/// <summary>
	/// Gets a value indicating whether the handler automatically follows HTTP redirect responses. Default is <c>true</c>.
	/// </summary>
	public bool AllowAutoRedirect { get; init; } = true;

	/// <summary>
	/// Gets the policy that controls when keep-alive pings are sent.
	/// Default is <see cref="HttpKeepAlivePingPolicy.WithActiveRequests"/>.
	/// </summary>
	public HttpKeepAlivePingPolicy KeepAlivePingPolicy { get; init; } = HttpKeepAlivePingPolicy.WithActiveRequests;

	/// <summary>
	/// Gets the timeout for keep-alive pings. Default is <c>30 seconds</c>.
	/// </summary>
	public TimeSpan KeepAlivePingTimeout { get; init; } = TimeSpan.FromSeconds(30);

	/// <summary>
	/// Gets the maximum number of automatic redirections the handler follows. Default is <c>3</c>.
	/// </summary>
	public int MaxAutomaticRedirections { get; init; } = 3;
	/// <summary>
	/// Gets the maximum number of concurrent connections allowed per server. Default is <c>20</c>.
	/// </summary>
	public int MaxConnectionsPerServer { get; init; } = 20;

	/// <summary>
	/// Gets the maximum idle time before a pooled connection is closed. Default is <c>5 minutes</c>.
	/// </summary>
	public TimeSpan PooledConnectionIdleTimeout { get; init; } = TimeSpan.FromMinutes(5);

	/// <summary>
	/// Gets the maximum lifetime of a pooled connection. Default is <c>10 minutes</c>.
	/// </summary>
	public TimeSpan PooledConnectionLifetime { get; init; } = TimeSpan.FromMinutes(10);

	/// <summary>
	/// Gets the request timeout applied to the <see cref="HttpClient"/>. Default is <c>30 seconds</c>.
	/// </summary>
	public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(30);

	/// <summary>
	/// Gets a value indicating whether the handler uses cookies. Default is <c>false</c>.
	/// </summary>
	public bool UseCookies { get; init; }

	/// <summary>
	/// Gets a value indicating whether the handler routes requests through a proxy. Default is <c>false</c>.
	/// </summary>
	public bool UseProxy { get; init; }

	/// <summary>
	/// Gets the value sent in the <c>User-Agent</c> request header. Default is <c>"OptimizedHttpClient/1.0"</c>.
	/// </summary>
	public string UserAgent { get; init; } = "OptimizedHttpClient/1.0";
}
