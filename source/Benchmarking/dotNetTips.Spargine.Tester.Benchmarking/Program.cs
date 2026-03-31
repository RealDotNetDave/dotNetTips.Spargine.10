// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-01-2026
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark Runtime: 
// Benchmark count: 126 benchmarks.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;
using DotNetTips.Spargine.Benchmarking;
using Perfolizer.Horology;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

/// <summary>.
/// Class Program.
/// </summary>
internal sealed class Program
{
	/// <summary>
	/// Defines the entry point of the application.
	/// </summary>
	public static void Main()
	{
		var config = DefaultConfig.Instance
			.AddJob(Job.Default.WithRuntime(CoreRuntime.Latest))
			.WithSummaryStyle(SummaryStyle.Default.WithTimeUnit(TimeUnit.Nanosecond));

		config = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true);

		// Run All Tests
		BenchmarkHelper.RunAllBenchmarks(config);

		// Run Selected Tests
		//BenchmarkHelper.RunBenchmarks(config,
		//	typeof(RandomDataBenchmark)
		//	);

	}
}
