// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-19-2025
// ***********************************************************************
// <copyright file="HttpClientExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for HttpClient.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Text.Json;
using DotNetTips.Spargine.Core;

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
	[Information("Original code from: https://ardalis.com/keep-tests-short-and-dry-with-extensions", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
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

}
