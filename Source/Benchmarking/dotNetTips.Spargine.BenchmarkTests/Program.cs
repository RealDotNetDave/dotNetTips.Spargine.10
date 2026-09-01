// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-11-2026
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>2 hours, 43 benchmarks</summary>
// ***********************************************************************
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.BenchmarkTests.IO;
using Perfolizer.Horology;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.BenchmarkTests;

/// <summary>
/// Class Program.
/// </summary>
public static class Program
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
		//BenchmarkHelper.RunAllBenchmarks(config);

		// Run Selected Tests
		BenchmarkHelper.RunBenchmarks(config, true,
			typeof(TempFileManagerDeleteAllFilesBenchmark),
			typeof(TempFileManagerDeleteFileBenchmark),
			typeof(TempFileManagerDeleteAllFilesBenchmark)
			);
	}
}
