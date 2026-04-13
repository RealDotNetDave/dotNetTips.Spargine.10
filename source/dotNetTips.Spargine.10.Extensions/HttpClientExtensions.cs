// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-13-2026
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

	private static readonly CompositeFormat _resourceWasNotFound = CompositeFormat.Parse(Resources.ResourceWasNotFound);

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
	[Information("Original code from: https://ardalis.com/keep-tests-short-and-dry-with-extensions", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static async Task<T> GetAndDeserializeAsync<T>([DisallowNull] this HttpClient client, [DisallowNull] Uri url, [DisallowNull] JsonSerializerOptions options, CancellationToken cancellationToken = default)
	{
		client = client.ArgumentNotNull();
		url = url.ArgumentNotNull();
		options = options.ArgumentNotNull();

		using (var response = await client.GetAsync(new Uri(url.PathAndQuery), cancellationToken).ConfigureAwait(false))
		{
			_ = response.EnsureSuccessStatusCode();

			var stringResponse = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

			return JsonSerializer.Deserialize<T>(stringResponse, options)!;
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
	[Information(nameof(GetStreamAsync), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
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
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasBeenCanceled, ex);
			return null;
		}
		catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
		{
			ExceptionThrower.ThrowInvalidOperationException(message: Resources.TheOperationHasTimedOut, ex);
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
}
