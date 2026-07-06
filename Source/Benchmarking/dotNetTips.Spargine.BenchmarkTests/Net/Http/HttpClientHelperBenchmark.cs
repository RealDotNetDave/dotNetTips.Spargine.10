// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-05-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-05-2026
// ***********************************************************************
// <copyright file="HttpClientHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmark tests for HttpClientHelper.CreateOptimizedHttpClient.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Net.Http;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.Net.Http;

/// <summary>
/// Benchmark tests for <see cref="HttpClientHelper.CreateOptimizedHttpClient(HttpClientOptions?)"/>.
/// </summary>
[MemoryDiagnoser]
[TailCallDiagnoser]
[BenchmarkCategory(Categories.IO)]
public class HttpClientHelperBenchmark : Benchmark
{
	private readonly HttpClientOptions _customOptions = new()
	{
		Timeout = TimeSpan.FromMinutes(2),
		UserAgent = "BenchmarkClient/1.0",
	};

	/// <summary>
	/// Benchmark for <see cref="HttpClientHelper.CreateOptimizedHttpClient(HttpClientOptions?)"/> using custom options.
	/// </summary>
	[Benchmark(Description = "CreateOptimizedHttpClient(HttpClientOptions?)")]
	[BenchmarkCategory(Categories.IO)]
	public void CreateOptimizedHttpClientCustomOptions()
	{
		using var client = HttpClientHelper.CreateOptimizedHttpClient(this._customOptions);

		this.Consume(client.Timeout);
	}

	/// <summary>
	/// Benchmark for <see cref="HttpClientHelper.CreateOptimizedHttpClient(HttpClientOptions?)"/> using default options.
	/// </summary>
	[Benchmark(Description = "CreateOptimizedHttpClient()")]
	[BenchmarkCategory(Categories.IO)]
	public void CreateOptimizedHttpClientDefaultOptions()
	{
		using var client = HttpClientHelper.CreateOptimizedHttpClient();

		this.Consume(client.Timeout);
	}
}
