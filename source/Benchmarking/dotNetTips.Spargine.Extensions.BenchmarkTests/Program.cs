// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-06-2026
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark Runtime: Over 24 hours
// Benchmark count: 2,379
// Divided into 3 groups to reduce single-run duration.
// </summary>
// ***********************************************************************
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
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
		// BenchmarkHelper.RunAllBenchmarks(config);

		// Group 1: A–E
		BenchmarkHelper.RunBenchmarks(config, true,
			typeof(ArrayExtensionsCollectionBenchmark),
			typeof(AssemblyExtensionsBenchmark),
			typeof(CharacterExtensionsBenchmark),
			typeof(CollectionExtensionsCollectionBenchmark),
			typeof(ConcurrentBagExtensionsCollectionBenchmark),
			typeof(DataReaderExtensionsBenchmark),
			typeof(DictionaryExtensionsCollectionBenchmark),
			typeof(EnumExtensionsBenchmark),
			typeof(EnumerableExtensionsCollectionBenchmark),
			typeof(EnumerableExtensionsConvertingCollectionBenchmark),
			typeof(EnumerableExtensionsCountCollectionBenchmark),
			typeof(EnumerableExtensionsDistinctCollectionBenchmark),
			typeof(ExceptionExtensionsBenchmark)
		);

		// Group 2: H–O
		BenchmarkHelper.RunBenchmarks(config, true,
			typeof(HashSetExtensionsCollectionBenchmark),
			typeof(ImmutableArrayExtensionsBenchmark),
			typeof(LinqExtensionsBenchmark),
			typeof(ListExtensionsAddRemoveCollectionBenchmark),
			typeof(ListExtensionsCollectionBenchmark),
			typeof(NumericExtensionsBenchmark),
			typeof(ObjectExtensionsBenchmark),
			typeof(ObservableCollectionExtensionsCollectionBenchmark)
		);

		// Group 3: R–T
		//BenchmarkHelper.RunBenchmarks(config, true,
		//	typeof(ReadOnlyCollectionExtensionsBenchmark),
		//	typeof(ReadOnlySpanExtensionsBenchmark),
		//	typeof(SortedDictionaryExtensionsBenchmark),
		//	typeof(SortedSetExtensionsBenchmark),
		//	typeof(StringBuilderExtensionsCounterBenchmark),
		//	typeof(StringExtensionsBenchmark),
		//	typeof(StringExtensionsCounterBenchmark),
		//	typeof(TypeExtensionsBenchmark)
		//);
	}
}
