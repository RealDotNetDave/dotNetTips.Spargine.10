// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 10-03-2026
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Core benchmark runner with an optional TaskTracker threading selection.
// Benchmark Runtime: 11:00
// Benchmark count: 1,540 benchmarks.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent;
using Perfolizer.Horology;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Class Program.
/// </summary>
internal sealed class Program
{
	/// <summary>
	/// Runs all Core benchmarks or selects the TaskTracker threading benchmarks.
	/// </summary>
	/// <param name="args">Pass <c>--task-tracker</c> to run only TaskTracker benchmarks.</param>
	private static void Main()
	{

		var config = DefaultConfig.Instance
			.AddJob(Job.Default.WithRuntime(CoreRuntime.Latest))
			.WithSummaryStyle(SummaryStyle.Default.WithTimeUnit(TimeUnit.Nanosecond)).WithOption(ConfigOptions.DisableOptimizationsValidator, true);

		// Run All Tests
		//BenchmarkHelper.RunAllBenchmarks(config);

		// Run Selected Tests
		BenchmarkHelper.RunBenchmarks(config, true, typeof(ConcurrentHashSetMutatingCollectionBenchmark),
			typeof(DistinctConcurrentBagMutatingBenchmark));

	}
}
