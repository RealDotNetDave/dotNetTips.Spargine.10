// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 01-11-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-06-2026
// ***********************************************************************
// <copyright file="HttpClientHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Utility methods for HttpClient.</summary>
// ***********************************************************************
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Net.Http;

/// <summary>
/// Provides utility methods for working with HttpClient, including getting HTTP responses and streams with a default timeout.
/// </summary>
/// <remarks>
/// This class encapsulates functionality for making HTTP requests and handling responses. It simplifies the process of using <see cref="HttpClient"/>
/// by providing methods that abstract away some of the complexities involved in setting up requests and processing responses. The class is designed
/// to be used statically, with a shared instance of <see cref="HttpClient"/> that is configured with a default timeout value. This approach helps to
/// avoid the common pitfalls associated with managing the lifecycle of <see cref="HttpClient"/> instances.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineHttpClientExtensions")]
public static class HttpClientHelper
{

	/// <summary>
	/// The cached default options used when <see cref="CreateOptimizedHttpClient(HttpClientOptions?)"/> is invoked without explicit configuration.
	/// </summary>
	private static readonly HttpClientOptions _defaultHttpClientOptions = new();

	/// <summary>
	/// The cached accept-encoding header value for deflate.
	/// </summary>
	private static readonly StringWithQualityHeaderValue _deflateEncoding = new("deflate");

	/// <summary>
	/// The cached accept-encoding header value for gzip.
	/// </summary>
	private static readonly StringWithQualityHeaderValue _gzipEncoding = new("gzip");

	/// <summary>
	/// The format string used to indicate that a resource was not found.
	/// </summary>
	private static readonly CompositeFormat _resourceWasNotFound = CompositeFormat.Parse(Resources.ResourceWasNotFound);

	/// <summary>
	/// The HttpClient instance used for making HTTP requests. Configured with a 20-second timeout.
	/// </summary>
	private static readonly HttpClient Client = new()
	{
		Timeout = TimeSpan.FromSeconds(value: 20),
	};

	/// <summary>
	/// Creates a new, performance-optimized <see cref="HttpClient"/> instance configured with the specified options.
	/// </summary>
	/// <param name="options">
	/// The configuration options. When <c>null</c>, a default <see cref="HttpClientOptions"/> instance is used.
	/// </param>
	/// <returns>A fully configured <see cref="HttpClient"/> instance backed by a <see cref="SocketsHttpHandler"/>.</returns>
	[Information(nameof(CreateOptimizedHttpClient), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static HttpClient CreateOptimizedHttpClient(HttpClientOptions? options = null)
	{
		options ??= _defaultHttpClientOptions;

		// CA2000: HttpClient(handler, disposeHandler: true) takes ownership and will dispose the handler on disposal.
#pragma warning disable CA2000
		var handler = new SocketsHttpHandler()
		{
			MaxConnectionsPerServer = options.MaxConnectionsPerServer,
			KeepAlivePingPolicy = options.KeepAlivePingPolicy,
			KeepAlivePingTimeout = options.KeepAlivePingTimeout,
			PooledConnectionLifetime = options.PooledConnectionLifetime,
			PooledConnectionIdleTimeout = options.PooledConnectionIdleTimeout,
			UseCookies = options.UseCookies,
			UseProxy = options.UseProxy,
			AllowAutoRedirect = options.AllowAutoRedirect,
			MaxAutomaticRedirections = options.MaxAutomaticRedirections,
		};
#pragma warning restore CA2000

		// IDISP014: This is a factory method; the caller is responsible for disposing the returned HttpClient.
#pragma warning disable IDISP014
		var client = new HttpClient(handler, disposeHandler: true)
		{
			Timeout = options.Timeout,
		};
#pragma warning restore IDISP014

		_ = client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", options.UserAgent);
		client.DefaultRequestHeaders.AcceptEncoding.Add(_gzipEncoding);
		client.DefaultRequestHeaders.AcceptEncoding.Add(_deflateEncoding);

		return client;
	}

	/// <summary>
	/// Asynchronously gets an HTTP response for the specified URL using a cancellation token.
	/// </summary>
	/// <param name="url">The URL to get the response from.</param>
	/// <param name="cancellationToken">The cancellation token to cancel the request.</param>
	/// <returns>A task that represents the asynchronous operation and contains the HTTP response.</returns>
	/// <exception cref="ArgumentInvalidException">Thrown when the URL is null or empty.</exception>
	/// <example>
	/// Here is how you can use the GetHttpResponseAsync method with a cancellation token:
	/// <code>
	/// Uri url = new Uri("https://example.com");
	/// using var cancellationTokenSource = new CancellationTokenSource();
	/// HttpResponseMessage response = await HttpClientHelper.GetHttpResponseAsync(url, cancellationTokenSource);
	/// Console.WriteLine(response.StatusCode);
	/// </code></example>
	/// <remarks>Original code by: Máňa Píchová.</remarks>
	[Obsolete("Use HttpClient.GetAsync()")]
	[DefaultValue(null)]
	[Information(nameof(GetHttpResponseAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<HttpResponseMessage> GetHttpResponseAsync([DisallowNull] Uri url, CancellationToken cancellationToken = default)
	{
		url = url.ArgumentNotNull<Uri>();

		try
		{
			var response = await Client.GetAsync(url, cancellationToken: cancellationToken).ConfigureAwait(false);

			return response;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			// If the token has been canceled, it is not a timeout.
			// Handle cancellation.
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasBeenCanceled, ex);
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			// Handle timeout.
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasTimedOut, ex);
		}

		return null;
	}

	/// <summary>
	/// Asynchronously retrieves a stream from the specified URL.
	/// </summary>
	/// <param name="url">The URL to retrieve the stream from.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation and contains the stream from the specified URL.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="url"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled or times out.</exception>
	/// <example>
	/// Here is how you can use the GetStreamAsync method:
	/// <code>
	/// Uri url = new Uri("https://example.com");
	/// Stream stream = await HttpClientHelper.GetStreamAsync(url);
	/// // Use the stream
	/// </code>
	/// </example>
	[Obsolete("Use GetStreamAsync() in HttpClientExtensions.")]
	[DefaultValue(null)]
	[Information(nameof(GetHttpResponseAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<Stream> GetStreamAsync([DisallowNull] Uri url, CancellationToken cancellationToken = default)
	{
		url = url.ArgumentNotNull<Uri>();

		try
		{
			// Use progressive retry for HTTP GET stream.
			Stream? resultStream = null;
			_ = await ExecutionHelper.ProgressiveRetryAsync(
				async () => resultStream = await Client.GetStreamAsync(url, cancellationToken).ConfigureAwait(false),
				retryCount: 3,
				retryWaitMilliseconds: 100,
				logger: null,
				cancellationToken: cancellationToken
			).ConfigureAwait(false);

			return resultStream!;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			// If the token has been canceled, it is not a timeout.
			// Handle cancellation.
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasBeenCanceled, ex);
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			// Handle timeout.
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasTimedOut, ex);
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			// Handle 404
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
		}
		catch (HttpRequestException ex)
		{
			// Handle 404
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
		}

		return null;
	}

}
