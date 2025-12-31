// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-21-2025
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark Runtime: 16 hours
// Benchmark count: 1,703
// </summary>
// ***********************************************************************
using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using DotNetTips.Spargine.Benchmarking;
using Perfolizer.Horology;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class Program.
/// </summary>
internal sealed class Program
{
	private const string CompleteMessage = "COMPLETE!";
	private const string ErrorMessage = "ERROR!";

	/// <summary>
	/// Defines the entry point of the application.
	/// </summary>
	/// <param name="args">The arguments.</param>
	public static void Main()
	{
		try
		{
			var config = DefaultConfig.Instance
				.AddJob(Job.Default.WithRuntime(CoreRuntime.Latest))
				.WithSummaryStyle(SummaryStyle.Default.WithTimeUnit(TimeUnit.Nanosecond));

			//config = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true);

			Benchmark.RunAllBenchmarks(config);

			//Benchmark.RunBenchmarks(config,
			//	typeof(ArrayExtensionsCollectionBenchmark)
			//	);

			//var temp = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

			//_ = BenchmarkRunner.Run<ArrayExtensionsCollectionBenchmark>(config);
			//_ = BenchmarkRunner.Run<EnumerableExtensionsCollectionBenchmark>(config);
			//_ = BenchmarkRunner.Run<ListExtensionsCollectionBenchmark>(config);
			//_ = BenchmarkRunner.Run<SortedSetCollectionBenchmark>(config);
			//_ = BenchmarkRunner.Run<StringExtensionsBenchmark>(config);
			//_ = BenchmarkRunner.Run<StringExtensionsCounterBenchmark>(config);

			ConsoleLogger.Default.WriteLine(CompleteMessage);
			Benchmark.PlaySuccessBeep();
			_ = Console.ReadLine();
		}
		catch (Exception ex)
		{
			ConsoleLogger.Default.WriteLine(ErrorMessage);
			ConsoleLogger.Default.WriteLine(ex.Message);
			Benchmark.PlayErrorBeep();
			_ = Console.ReadLine();
		}
	}
}
