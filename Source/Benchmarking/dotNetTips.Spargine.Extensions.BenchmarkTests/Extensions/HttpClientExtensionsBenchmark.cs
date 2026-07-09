// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="HttpClientExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for HttpClientExtensions methods.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="HttpClientExtensions"/> methods marked for benchmarking.
/// </summary>
[SuppressMessage("Reliability", "CA1001:Types that own disposable fields should be disposable", Justification = "Disposed in Cleanup() via BenchmarkDotNet lifecycle.")]
[BenchmarkCategory(Categories.Network)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class HttpClientExtensionsBenchmark : Benchmark
{
	private static readonly Uri _jsonUri = new("https://example.test/api/resource");
	private static readonly JsonTypeInfo<SamplePayload> _payloadTypeInfo = (JsonTypeInfo<SamplePayload>)_typeInfoOptions.GetTypeInfo(typeof(SamplePayload));
	private static readonly JsonSerializerOptions _serializerOptions = new(JsonSerializerDefaults.Web);
	private static readonly Uri _streamUri = new("https://example.test/api/stream");
	private static readonly JsonSerializerOptions _typeInfoOptions = new() { TypeInfoResolver = new DefaultJsonTypeInfoResolver() };
	private HttpClient _httpClient = default!;
	private SamplePayload _requestPayload = default!;

	/// <summary>
	/// Cleans up benchmark resources.
	/// </summary>
	public override void Cleanup()
	{
		this._httpClient.Dispose();
		base.Cleanup();
	}

	[Benchmark(Description = nameof(HttpClientExtensions.DeleteAndDeserializeAsync))]
	public async Task DeleteAndDeserializeAsync()
	{
		var result = await HttpClientExtensions.DeleteAndDeserializeAsync<SamplePayload>(this._httpClient, _jsonUri, _serializerOptions).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.DownloadToStreamAsync))]
	public async Task DownloadToStreamAsync()
	{
		using var destination = new MemoryStream();
		await HttpClientExtensions.DownloadToStreamAsync(this._httpClient, _streamUri, destination).ConfigureAwait(false);
		this.Consume(destination.Length);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.GetAndDeserializeAsync))]
	public async Task GetAndDeserializeAsync()
	{
		var result = await HttpClientExtensions.GetAndDeserializeAsync<SamplePayload>(this._httpClient, _jsonUri, _serializerOptions).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.GetAndDeserializeFromStreamAsync) + ": JsonSerializerOptions")]
	public async Task GetAndDeserializeFromStreamAsyncOptions()
	{
		var result = await HttpClientExtensions.GetAndDeserializeFromStreamAsync<SamplePayload>(this._httpClient, _jsonUri, _serializerOptions).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.GetAndDeserializeFromStreamAsync) + ": JsonTypeInfo")]
	public async Task GetAndDeserializeFromStreamAsyncTypeInfo()
	{
		var result = await HttpClientExtensions.GetAndDeserializeFromStreamAsync(this._httpClient, _jsonUri, _payloadTypeInfo).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.GetStreamAsync))]
	public async Task GetStreamAsync()
	{
		using var stream = await HttpClientExtensions.GetStreamAsync(this._httpClient, _streamUri).ConfigureAwait(false);
		this.Consume(stream.Length);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.HeadersAsync))]
	public async Task HeadersAsync()
	{
		var headers = await HttpClientExtensions.HeadersAsync(this._httpClient, _jsonUri).ConfigureAwait(false);
		this.Consume(headers.ETag);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.PatchAndDeserializeAsync))]
	public async Task PatchAndDeserializeAsync()
	{
		var result = await HttpClientExtensions.PatchAndDeserializeAsync<SamplePayload, SamplePayload>(this._httpClient, _jsonUri, this._requestPayload, _serializerOptions).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.PostAndDeserializeAsync) + ": JsonSerializerOptions")]
	public async Task PostAndDeserializeAsyncOptions()
	{
		var result = await HttpClientExtensions.PostAndDeserializeAsync<SamplePayload, SamplePayload>(this._httpClient, _jsonUri, this._requestPayload, _serializerOptions).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.PostAndDeserializeAsync) + ": JsonTypeInfo")]
	public async Task PostAndDeserializeAsyncTypeInfo()
	{
		var result = await HttpClientExtensions.PostAndDeserializeAsync(this._httpClient, _jsonUri, this._requestPayload, _payloadTypeInfo, _payloadTypeInfo).ConfigureAwait(false);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.PostAndEnsureSuccessAsync) + ": JsonSerializerOptions")]
	public async Task PostAndEnsureSuccessAsyncOptions()
	{
		var statusCode = await HttpClientExtensions.PostAndEnsureSuccessAsync(this._httpClient, _jsonUri, this._requestPayload, _serializerOptions).ConfigureAwait(false);
		this.Consume(statusCode);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.PostAndEnsureSuccessAsync) + ": JsonTypeInfo")]
	public async Task PostAndEnsureSuccessAsyncTypeInfo()
	{
		var statusCode = await HttpClientExtensions.PostAndEnsureSuccessAsync(this._httpClient, _jsonUri, this._requestPayload, _payloadTypeInfo).ConfigureAwait(false);
		this.Consume(statusCode);
	}

	[Benchmark(Description = nameof(HttpClientExtensions.PutAndDeserializeAsync))]
	public async Task PutAndDeserializeAsync()
	{
		var result = await HttpClientExtensions.PutAndDeserializeAsync<SamplePayload, SamplePayload>(this._httpClient, _jsonUri, this._requestPayload, _serializerOptions).ConfigureAwait(false);
		this.Consume(result);
	}

	/// <summary>
	/// Initializes benchmark dependencies.
	/// </summary>
	[SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Ownership of the handler is transferred to HttpClient and disposed when HttpClient is disposed in Cleanup().")]
	public override void Setup()
	{
		base.Setup();

		this._requestPayload = new SamplePayload(42, "benchmark");
		var handler = new StaticHttpMessageHandler(this._requestPayload);

		try
		{
			this._httpClient = new HttpClient(handler)
			{
				Timeout = TimeSpan.FromSeconds(30),
			};
		}
		catch
		{
			handler.Dispose();
			throw;
		}
	}

	private sealed record SamplePayload(int Id, string Name);

	private sealed class StaticHttpMessageHandler : HttpMessageHandler
	{
		private readonly byte[] _binaryPayload;
		private readonly byte[] _jsonPayload;

		public StaticHttpMessageHandler(SamplePayload payload)
		{
			this._jsonPayload = JsonSerializer.SerializeToUtf8Bytes(payload, _payloadTypeInfo);
			this._binaryPayload = Encoding.UTF8.GetBytes("stream-payload-for-benchmark");
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			var response = new HttpResponseMessage(HttpStatusCode.OK);
			response.Headers.ETag = new EntityTagHeaderValue("\"etag-1\"");

			if (request.Method == HttpMethod.Head)
			{
				response.Content = new ByteArrayContent([]);
				return Task.FromResult(response);
			}

			if (request.Method == HttpMethod.Post)
			{
				response.StatusCode = HttpStatusCode.Created;
			}

			if (request.Method == HttpMethod.Get && request.RequestUri?.AbsolutePath.Contains("stream", StringComparison.Ordinal) == true)
			{
				response.Content = new ByteArrayContent(this._binaryPayload);
				response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
				return Task.FromResult(response);
			}

			response.Content = new ByteArrayContent(this._jsonPayload);
			response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			return Task.FromResult(response);
		}
	}
}
