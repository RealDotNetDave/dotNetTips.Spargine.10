// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-16-2026
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

		// Temp tests
		BenchmarkHelper.RunBenchmarks(config, true,
			typeof(ObjectExtensionsBenchmark)
		);

		// Group 1: A–D - 7:45 hours, 786 benchmarks
		//BenchmarkHelper.RunBenchmarks(config, true,
		// typeof(ArrayExtensionsCollectionBenchmark),
		//	typeof(ArrayExtensionsMutatingCollectionBenchmark),
		//	typeof(AssemblyExtensionsBenchmark),
		//	typeof(CharacterExtensionsBenchmark),
		//	typeof(CollectionExtensionsCollectionBenchmark),
		//	typeof(CollectionExtensionsMutatingCollectionBenchmark),
		//	typeof(ConcurrentBagExtensionsCollectionBenchmark),
		//	typeof(DataReaderExtensionsBenchmark),
		//	typeof(DictionaryExtensionsCollectionBenchmark),
		//	typeof(DictionaryExtensionsMutatingCollectionBenchmark)
		//);

		// Group 2: E–I - 5 hours, 527 benchmarks
		BenchmarkHelper.RunBenchmarks(config, true,
		 typeof(EnumExtensionsBenchmark),
			typeof(EnumerableExtensionsCollectionBenchmark),
			typeof(EnumerableExtensionsConvertingCollectionBenchmark),
			typeof(EnumerableExtensionsCountCollectionBenchmark),
			typeof(EnumerableExtensionsDistinctCollectionBenchmark),
			typeof(EnumerableExtensionsMutatingCollectionBenchmark),
			typeof(ExceptionExtensionsBenchmark),
			typeof(HashSetExtensionsCollectionBenchmark),
			typeof(HashSetExtensionsMutatingCollectionBenchmark),
			typeof(ImmutableArrayExtensionsBenchmark)
		);

		// Group 3: L–T - 5 hours, 444 benchmarks
		//BenchmarkHelper.RunBenchmarks(config, true,
		//  typeof(LinqExtensionsBenchmark),
		//	typeof(ListExtensionsAddRemoveCollectionBenchmark),
		//	typeof(ListExtensionsCollectionBenchmark).
		//  typeof(NumericExtensionsBenchmark),
		//	typeof(ObjectExtensionsBenchmark),
		//	typeof(ObservableCollectionExtensionsCollectionBenchmark),
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
