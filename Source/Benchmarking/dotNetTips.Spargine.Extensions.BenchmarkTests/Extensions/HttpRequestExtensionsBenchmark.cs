// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="HttpRequestExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for HttpRequestExtensions methods.</summary>
// ***********************************************************************

using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using Microsoft.AspNetCore.Http;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="HttpRequestExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.Network)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class HttpRequestExtensionsBenchmark : Benchmark
{
	private static readonly byte[] _requestJsonBytes = Encoding.UTF8.GetBytes("{\"id\":42,\"name\":\"benchmark\"}");
	private static readonly JsonTypeInfo<SampleRequestBody> _requestTypeInfo = (JsonTypeInfo<SampleRequestBody>)_typeInfoOptions.GetTypeInfo(typeof(SampleRequestBody));
	private static readonly JsonSerializerOptions _typeInfoOptions = new() { TypeInfoResolver = new DefaultJsonTypeInfoResolver() };
	private HttpRequest _request = default!;

	[Benchmark(Description = nameof(HttpRequestExtensions.GetRawBodyBytesAsync))]
	public async Task GetRawBodyBytesAsync()
	{
		var bytes = await this._request.GetRawBodyBytesAsync().ConfigureAwait(false);
		this.Consume(bytes.Length);
	}

	[Benchmark(Description = nameof(HttpRequestExtensions.GetRawBodyStringAsync))]
	public async Task GetRawBodyStringAsync()
	{
		var body = await this._request.GetRawBodyStringAsync(Encoding.UTF8).ConfigureAwait(false);
		this.Consume(body);
	}

	public override void Setup()
	{
		base.Setup();
		this._request = CreateRequest();
	}

	[IterationSetup(Target = nameof(GetRawBodyBytesAsync))]
	public void SetupGetRawBodyBytesAsync()
	{
		this._request = CreateRequest();
	}

	[IterationSetup(Target = nameof(GetRawBodyStringAsync))]
	public void SetupGetRawBodyStringAsync()
	{
		this._request = CreateRequest();
	}

	[IterationSetup(Target = nameof(TryGetBodyBytes))]
	public void SetupTryGetBodyBytes()
	{
		this._request = CreateRequest();
	}

	[IterationSetup(Target = nameof(TryGetBodyGeneric))]
	public void SetupTryGetBodyGeneric()
	{
		this._request = CreateRequest();
	}

	[IterationSetup(Target = nameof(TryGetBodyTypeInfo))]
	public void SetupTryGetBodyTypeInfo()
	{
		this._request = CreateRequest();
	}

	[Benchmark(Description = nameof(HttpRequestExtensions.TryGetBody) + ": bytes")]
	public void TryGetBodyBytes()
	{
		var success = this._request.TryGetBody(out var bodyBytes);
		this.Consume(success);
		this.Consume(bodyBytes.Length);
	}

	[Benchmark(Description = nameof(HttpRequestExtensions.TryGetBody) + ": generic")]
	public void TryGetBodyGeneric()
	{
		var success = this._request.TryGetBody<SampleRequestBody>(out var value);
		this.Consume(success);
		this.Consume(value);
	}

	[Benchmark(Description = nameof(HttpRequestExtensions.TryGetBody) + ": JsonTypeInfo")]
	public void TryGetBodyTypeInfo()
	{
		var success = this._request.TryGetBody(_requestTypeInfo, out SampleRequestBody? value);
		this.Consume(success);
		this.Consume(value);
	}

	private static HttpRequest CreateRequest()
	{
		var context = new DefaultHttpContext();
		context.Request.ContentType = "application/json";
		context.Request.Body = new MemoryStream(_requestJsonBytes, writable: false);
		context.Request.Body.Position = 0;

		return context.Request;
	}

	private sealed record SampleRequestBody(int Id, string Name);
}
