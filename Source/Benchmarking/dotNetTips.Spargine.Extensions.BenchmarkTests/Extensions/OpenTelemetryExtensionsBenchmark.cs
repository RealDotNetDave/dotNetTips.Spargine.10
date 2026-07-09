// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="OpenTelemetryExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for OpenTelemetryExtensions methods.</summary>
// ***********************************************************************

using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="OpenTelemetryExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.Logging)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class OpenTelemetryExtensionsBenchmark : Benchmark
{
	private readonly InvalidOperationException _exception = new("benchmark failure");
	private readonly KeyValuePair<string, object?>[] _tags =
	[
		new("service.name", "Spargine"),
		new("operation.id", 42),
		new(string.Empty, "ignored"),
		new("null.value", null)
	];

	[Benchmark(Description = nameof(OpenTelemetryExtensions.AddTagsIfPresent))]
	public void AddTagsIfPresent()
	{
		using var activity = new Activity("AddTagsIfPresent");
		_ = activity.Start();
		var result = activity.AddTagsIfPresent(this._tags);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(OpenTelemetryExtensions.SetStatusIfError))]
	public void SetStatusIfError()
	{
		using var activity = new Activity("SetStatusIfError");
		_ = activity.Start();
		var result = activity.SetStatusIfError(this._exception);
		this.Consume(result);
	}
}
