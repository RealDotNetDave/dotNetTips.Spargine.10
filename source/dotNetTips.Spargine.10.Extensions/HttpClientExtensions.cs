// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-05-2026
// ***********************************************************************
// <copyright file="HttpClientExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for HttpClient.</summary>
// ***********************************************************************
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods tailored for <see cref="HttpClient"/>, enhancing its functionality with additional utility methods.
/// These methods simplify common tasks such as deserializing JSON responses from HTTP GET requests.
/// </summary>
/// <remarks>
/// The extension methods within this class aim to reduce boilerplate code and improve readability when working with <see cref="HttpClient"/>.
/// For example, the <see cref="GetAndDeserializeAsync{T}"/> method streamlines the process of sending a GET request, checking the response status,
/// reading the response content as a string, and deserializing it into an instance of a type.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class HttpClientExtensions
{

	private static readonly CompositeFormat _destinationStreamIsNotWritable = CompositeFormat.Parse(Resources.DestinationStreamIsNotWritable);
	private static readonly CompositeFormat _resourceWasNotFound = CompositeFormat.Parse(Resources.ResourceWasNotFound);
	private static readonly CompositeFormat _theOperationHasBeenCanceled = CompositeFormat.Parse(Resources.TheOperationHasBeenCanceled);
	private static readonly CompositeFormat _theOperationHasTimedOut = CompositeFormat.Parse(Resources.TheOperationHasTimedOut);

	/// <summary>
	/// Sends a DELETE request to the specified URL and deserializes the JSON response into an instance of <typeparamref name="TResponse"/>.
	/// Uses stream-based deserialization to minimize memory allocations.
	/// </summary>
	/// <typeparam name="TResponse">The type to deserialize the JSON response into.</typeparam>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to send the DELETE request to.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for deserialization.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the deserialized object of type <typeparamref name="TResponse"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/>, <paramref name="url"/>, or <paramref name="options"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the DeleteAndDeserializeAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// var url = new Uri("https://example.com/api/items/1");
	/// var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
	/// var deletedItem = await httpClient.DeleteAndDeserializeAsync&lt;MyItem&gt;(url, options);
	/// </code>
	/// </example>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(DeleteAndDeserializeAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<TResponse> DeleteAndDeserializeAsync<TResponse>([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] JsonSerializerOptions options, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		options = options.ArgumentNotNull();

		try
		{
			using var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url);
			using var response = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
			_ = response.EnsureSuccessStatusCode();

#pragma warning disable IDISP001
			var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#pragma warning restore IDISP001
			return (await JsonSerializer.DeserializeAsync<TResponse>(stream, options, cancellationToken).ConfigureAwait(false))!;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasBeenCanceled), ex);
			return default!;
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasTimedOut), ex);
			return default!;
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return default!;
		}
		catch (HttpRequestException ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return default!;
		}
	}

	/// <summary>
	/// Sends a GET request to the specified URL and copies the response content directly to the provided destination <see cref="Stream"/>.
	/// Uses <see cref="HttpCompletionOption.ResponseHeadersRead"/> and stream-based copying to minimize memory usage,
	/// making this method suitable for downloading large files or binary payloads.
	/// </summary>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to download content from.</param>
	/// <param name="destination">The writable <see cref="Stream"/> to copy the response content into.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous download operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/>, <paramref name="url"/>, or <paramref name="destination"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="destination"/> is not writable.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the DownloadToStreamAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// var url = new Uri("https://example.com/files/report.pdf");
	/// using var fileStream = File.Create("report.pdf");
	/// await httpClient.DownloadToStreamAsync(url, fileStream);
	/// </code>
	/// </example>
	[Information(nameof(DownloadToStreamAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task DownloadToStreamAsync([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] Stream destination, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		destination = destination.ArgumentNotNull();

		if (!destination.CanWrite)
		{
			ExceptionThrower.ThrowArgumentException(string.Format(CultureInfo.CurrentCulture, _destinationStreamIsNotWritable), nameof(destination));
		}

		try
		{
			using var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
			_ = response.EnsureSuccessStatusCode();

#pragma warning disable IDISP001
			var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#pragma warning restore IDISP001
			await stream.CopyToAsync(destination, cancellationToken).ConfigureAwait(false);
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasBeenCanceled), ex);
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasTimedOut), ex);
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
		}
		catch (HttpRequestException ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
		}
	}

	/// <summary>
	/// Sends a GET request to the specified URL and deserializes the JSON response into an instance of the specified type.
	/// </summary>
	/// <typeparam name="T">The type to deserialize the JSON response into.</typeparam>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to send the GET request to.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for deserialization.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the deserialized object of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/>, <paramref name="url"/>, or <paramref name="options"/> is null.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Pure]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information("Original code from: https://ardalis.com/keep-tests-short-and-dry-with-extensions", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static async Task<T> GetAndDeserializeAsync<T>([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] JsonSerializerOptions options, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		options = options.ArgumentNotNull();

		using (var response = await client.GetAsync(url, cancellationToken).ConfigureAwait(false))
		{
			_ = response.EnsureSuccessStatusCode();

			var stringResponse = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

			return JsonSerializer.Deserialize<T>(stringResponse, options)!;
		}
	}

	/// <summary>
	/// Sends a GET request to the specified URL and deserializes the JSON response from a stream into an instance of the specified type.
	/// This method is more memory-efficient than <see cref="GetAndDeserializeAsync{T}"/> because it avoids allocating an intermediate string.
	/// </summary>
	/// <typeparam name="T">The type to deserialize the JSON response into.</typeparam>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to send the GET request to.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for deserialization.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the deserialized object of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/>, <paramref name="url"/>, or <paramref name="options"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the GetAndDeserializeFromStreamAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// var url = new Uri("https://example.com/api/items");
	/// var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
	/// var item = await httpClient.GetAndDeserializeFromStreamAsync&lt;MyItem&gt;(url, options);
	/// </code>
	/// </example>
	[Pure]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAndDeserializeFromStreamAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<T> GetAndDeserializeFromStreamAsync<T>([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] JsonSerializerOptions options, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		options = options.ArgumentNotNull();

		try
		{
			using var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
			_ = response.EnsureSuccessStatusCode();

#pragma warning disable IDISP001
			var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#pragma warning restore IDISP001
			return (await JsonSerializer.DeserializeAsync<T>(stream, options, cancellationToken).ConfigureAwait(false))!;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasBeenCanceled), ex);
			return default!;
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasTimedOut), ex);
			return default!;
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return default!;
		}
		catch (HttpRequestException ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return default!;
		}
	}
	/// <summary>
	/// Asynchronously retrieves a stream from the specified URL.
	/// </summary>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to retrieve the stream from.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation and contains the stream from the specified URL.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> or <paramref name="url"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the GetStreamAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// Uri url = new Uri("https://example.com");
	/// Stream stream = await httpClient.GetStreamAsync(url);
	/// // Use the stream
	/// </code>
	/// </example>
	[DefaultValue(null)]
	[Information(nameof(GetStreamAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<Stream> GetStreamAsync([DisallowNull] this HttpClient client, [DisallowNull] Uri url, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();

		try
		{
			// Response is intentionally not disposed on success; the returned stream reads from its content.
			// This mirrors the pattern used by .NET's own HttpClient.GetStreamAsync implementation.
#pragma warning disable IDISP001
			var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
#pragma warning restore IDISP001

			try
			{
				_ = response.EnsureSuccessStatusCode();
				return await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
			}
			catch
			{
				response.Dispose();
				throw;
			}
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasBeenCanceled), ex);
			return null;
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasTimedOut), ex);
			return null;
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return null;
		}
		catch (HttpRequestException ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return null;
		}
	}

	/// <summary>
	/// Sends a HEAD request to the specified URL and returns the response headers.
	/// HEAD requests are useful for checking resource existence, content length, ETag, cache headers,
	/// and other metadata without downloading the response body.
	/// </summary>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to send the HEAD request to.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="HttpResponseHeaders"/> from the response.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> or <paramref name="url"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the HeadersAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// var url = new Uri("https://example.com/api/items/1");
	/// var headers = await httpClient.HeadersAsync(url);
	/// var etag = headers.ETag;
	/// </code>
	/// </example>
	[Information(nameof(HeadersAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<HttpResponseHeaders> HeadersAsync([DisallowNull] this HttpClient client, [DisallowNull] Uri url, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();

		try
		{
			using var requestMessage = new HttpRequestMessage(HttpMethod.Head, url);
			using var response = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
			_ = response.EnsureSuccessStatusCode();

			return response.Headers;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasBeenCanceled), ex);
			return null;
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasTimedOut), ex);
			return null;
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return null;
		}
		catch (HttpRequestException ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return null;
		}
	}

	/// <summary>
	/// Sends a PATCH request with a JSON-serialized body to the specified URL and deserializes the JSON response into an instance of <typeparamref name="TResponse"/>.
	/// Uses stream-based deserialization to minimize memory allocations.
	/// </summary>
	/// <typeparam name="TRequest">The type of the request body to serialize as JSON.</typeparam>
	/// <typeparam name="TResponse">The type to deserialize the JSON response into.</typeparam>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to send the PATCH request to.</param>
	/// <param name="request">The request body to serialize as JSON.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization and deserialization.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the deserialized object of type <typeparamref name="TResponse"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/>, <paramref name="url"/>, <paramref name="request"/>, or <paramref name="options"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the PatchAndDeserializeAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// var url = new Uri("https://example.com/api/items/1");
	/// var patchData = new { Name = "Updated" };
	/// var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
	/// var result = await httpClient.PatchAndDeserializeAsync&lt;object, MyItem&gt;(url, patchData, options);
	/// </code>
	/// </example>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(PatchAndDeserializeAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<TResponse> PatchAndDeserializeAsync<TRequest, TResponse>([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] TRequest request, [DisallowNull] JsonSerializerOptions options, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		request = request.ArgumentNotNull();
		options = options.ArgumentNotNull();

		return await SendAndDeserializeAsync<TRequest, TResponse>(client, HttpMethod.Patch, url, request, options, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Sends a POST request with a JSON-serialized body to the specified URL and deserializes the JSON response into an instance of <typeparamref name="TResponse"/>.
	/// Uses stream-based deserialization to minimize memory allocations.
	/// </summary>
	/// <typeparam name="TRequest">The type of the request body to serialize as JSON.</typeparam>
	/// <typeparam name="TResponse">The type to deserialize the JSON response into.</typeparam>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to send the POST request to.</param>
	/// <param name="request">The request body to serialize as JSON.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization and deserialization.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the deserialized object of type <typeparamref name="TResponse"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/>, <paramref name="url"/>, <paramref name="request"/>, or <paramref name="options"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the PostAndDeserializeAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// var url = new Uri("https://example.com/api/items");
	/// var newItem = new { Name = "Test", Value = 42 };
	/// var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
	/// var createdItem = await httpClient.PostAndDeserializeAsync&lt;object, MyItem&gt;(url, newItem, options);
	/// </code>
	/// </example>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(PostAndDeserializeAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<TResponse> PostAndDeserializeAsync<TRequest, TResponse>([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] TRequest request, [DisallowNull] JsonSerializerOptions options, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		request = request.ArgumentNotNull();
		options = options.ArgumentNotNull();

		return await SendAndDeserializeAsync<TRequest, TResponse>(client, HttpMethod.Post, url, request, options, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Sends a POST request with a JSON-serialized body to the specified URL and ensures a successful response,
	/// returning the <see cref="HttpStatusCode"/>. No response body deserialization is performed, making this
	/// suitable for endpoints that return 201 Created or 204 No Content with no meaningful body.
	/// </summary>
	/// <typeparam name="TRequest">The type of the request body to serialize as JSON.</typeparam>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to send the POST request to.</param>
	/// <param name="request">The request body to serialize as JSON.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="HttpStatusCode"/> from the response.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/>, <paramref name="url"/>, <paramref name="request"/>, or <paramref name="options"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the PostAndEnsureSuccessAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// var url = new Uri("https://example.com/api/items");
	/// var newItem = new { Name = "Test", Value = 42 };
	/// var options = new JsonSerializerOptions();
	/// HttpStatusCode statusCode = await httpClient.PostAndEnsureSuccessAsync(url, newItem, options);
	/// </code>
	/// </example>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(PostAndEnsureSuccessAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<HttpStatusCode> PostAndEnsureSuccessAsync<TRequest>([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] TRequest request, [DisallowNull] JsonSerializerOptions options, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		request = request.ArgumentNotNull();
		options = options.ArgumentNotNull();

		try
		{
			var jsonBytes = JsonSerializer.SerializeToUtf8Bytes(request, options);
			using var content = new ByteArrayContent(jsonBytes);
			content.Headers.ContentType = new MediaTypeHeaderValue("application/json") { CharSet = "utf-8" };

			using var requestMessage = new HttpRequestMessage(HttpMethod.Post, url)
			{
				Content = content,
			};

			using var response = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
			_ = response.EnsureSuccessStatusCode();

			return response.StatusCode;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasBeenCanceled), ex);
			return default;
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasTimedOut), ex);
			return default;
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return default;
		}
		catch (HttpRequestException ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return default;
		}
	}

	/// <summary>
	/// Sends a PUT request with a JSON-serialized body to the specified URL and deserializes the JSON response into an instance of <typeparamref name="TResponse"/>.
	/// Uses stream-based deserialization to minimize memory allocations.
	/// </summary>
	/// <typeparam name="TRequest">The type of the request body to serialize as JSON.</typeparam>
	/// <typeparam name="TResponse">The type to deserialize the JSON response into.</typeparam>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="url">The URL to send the PUT request to.</param>
	/// <param name="request">The request body to serialize as JSON.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization and deserialization.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the deserialized object of type <typeparamref name="TResponse"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/>, <paramref name="url"/>, <paramref name="request"/>, or <paramref name="options"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	/// <example>
	/// Here is how you can use the PutAndDeserializeAsync method:
	/// <code>
	/// using var httpClient = new HttpClient();
	/// var url = new Uri("https://example.com/api/items/1");
	/// var updatedItem = new { Name = "Updated", Value = 99 };
	/// var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
	/// var result = await httpClient.PutAndDeserializeAsync&lt;object, MyItem&gt;(url, updatedItem, options);
	/// </code>
	/// </example>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(PutAndDeserializeAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<TResponse> PutAndDeserializeAsync<TRequest, TResponse>([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] TRequest request, [DisallowNull] JsonSerializerOptions options, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		request = request.ArgumentNotNull();
		options = options.ArgumentNotNull();

		return await SendAndDeserializeAsync<TRequest, TResponse>(client, HttpMethod.Put, url, request, options, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Sends an HTTP request with a JSON-serialized body and deserializes the JSON response into an instance of <typeparamref name="TResponse"/>.
	/// Uses stream-based deserialization to minimize memory allocations.
	/// </summary>
	/// <typeparam name="TRequest">The type of the request body to serialize as JSON.</typeparam>
	/// <typeparam name="TResponse">The type to deserialize the JSON response into.</typeparam>
	/// <param name="client">The <see cref="HttpClient"/> instance to send the request.</param>
	/// <param name="method">The HTTP method to use (e.g., POST, PUT, PATCH).</param>
	/// <param name="url">The URL to send the request to.</param>
	/// <param name="request">The request body to serialize as JSON.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization and deserialization.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the deserialized object of type <typeparamref name="TResponse"/>.</returns>
	/// <exception cref="InvalidOperationException">Thrown if the operation is canceled, times out, or encounters an HTTP error.</exception>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	private static async Task<TResponse> SendAndDeserializeAsync<TRequest, TResponse>(
		HttpClient client,
		HttpMethod method,
		Uri url,
		TRequest request,
		JsonSerializerOptions options,
		CancellationToken cancellationToken)
	{
		try
		{
			var jsonBytes = JsonSerializer.SerializeToUtf8Bytes(request, options);
			using var content = new ByteArrayContent(jsonBytes);
			content.Headers.ContentType = new MediaTypeHeaderValue("application/json") { CharSet = "utf-8" };

			using var requestMessage = new HttpRequestMessage(method, url)
			{
				Content = content,
			};

			using var response = await client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
			_ = response.EnsureSuccessStatusCode();

#pragma warning disable IDISP001
			var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#pragma warning restore IDISP001
			return (await JsonSerializer.DeserializeAsync<TResponse>(stream, options, cancellationToken).ConfigureAwait(false))!;
		}
		catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasBeenCanceled), ex);
			return default!;
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _theOperationHasTimedOut), ex);
			return default!;
		}
		catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return default!;
		}
		catch (HttpRequestException ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: string.Format(CultureInfo.CurrentCulture, _resourceWasNotFound, url), ex);
			return default!;
		}
	}
}
