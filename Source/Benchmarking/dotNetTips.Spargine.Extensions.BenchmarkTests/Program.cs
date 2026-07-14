// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Divided into 3 groups to reduce single-run duration.</summary>
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
		//BenchmarkHelper.RunBenchmarks(config, true,
		//	typeof(ArrayExtensionsCollectionBenchmark),
		//	typeof(AssemblyExtensionsBenchmark)
		//);

		// Group 1: A–D - 8:30 hours, 882 benchmarks
		BenchmarkHelper.RunBenchmarks(config, true,
		 typeof(ArrayExtensionsCollectionBenchmark),
		 typeof(ArrayExtensionsSliceBenchmark),
			typeof(ArrayExtensionsMutatingCollectionBenchmark),
			typeof(AssemblyExtensionsBenchmark),
			typeof(CharacterExtensionsBenchmark),
			typeof(CollectionExtensionsCollectionBenchmark),
			typeof(CollectionExtensionsMutatingCollectionBenchmark),
			typeof(ConcurrentBagExtensionsCollectionBenchmark),
			typeof(DataContextExtensionsBenchmark),
			typeof(DataReaderExtensionsBenchmark),
			typeof(DataTableExtensionsBenchmark),
			typeof(DateTimeExtensionsBenchmark),
			typeof(DbContextExtensionsBenchmark),
			typeof(DictionaryExtensionsCollectionBenchmark),
			typeof(DictionaryExtensionsMutatingCollectionBenchmark),
			typeof(DirectoryInfoExtensionsBenchmark)
		);

		// Group 2: E–H - 10:05 hours, 926 benchmarks
		//BenchmarkHelper.RunBenchmarks(config, true,
		// typeof(EfCoreModelBuilderExtensionsBenchmark),
		// typeof(EnumExtensionsBenchmark),
		//	typeof(EnumerableExtensionsCollectionBenchmark),
		//	typeof(EnumerableExtensionsConvertingCollectionBenchmark),
		//	typeof(EnumerableExtensionsCountCollectionBenchmark),
		//	typeof(EnumerableExtensionsDistinctCollectionBenchmark),
		//	typeof(EnumerableExtensionsMutatingCollectionBenchmark),
		//	typeof(ExceptionExtensionsBenchmark),
		//	typeof(FileInfoExtensionsBenchmark),
		//	typeof(HashSetExtensionsCollectionBenchmark),
		//	typeof(HttpClientExtensionsBenchmark),
		//	typeof(HttpRequestExtensionsBenchmark),
		//	typeof(HashSetExtensionsMutatingCollectionBenchmark)
		//);

		// Group 3: L–T - 11 hours, 943 benchmarks
		//BenchmarkHelper.RunBenchmarks(config, saveResults: true,
		//  typeof(ImmutableArrayExtensionsBenchmark),
		//	typeof(LinqExtensionsBenchmark),
		//	typeof(ListExtensionsAddRemoveCollectionBenchmark),
		//	typeof(ListExtensionsCollectionBenchmark),
		//	typeof(MessagePackExtensionsBenchmark),
		//	typeof(NumericExtensionsBenchmark),
		//	typeof(ObjectExtensionsBenchmark),
		//	typeof(OpenTelemetryExtensionsBenchmark),
		//	typeof(ObservableCollectionExtensionsCollectionBenchmark),
		//	typeof(ReadOnlyCollectionExtensionsBenchmark),
		//	typeof(ReadOnlySpanExtensionsBenchmark),
		//	typeof(SortedDictionaryExtensionsBenchmark),
		//	typeof(SortedSetExtensionsBenchmark),
		//	typeof(StreamExtensionsBenchmark),
		//	typeof(StringBuilderExtensionsCounterBenchmark),
		//	typeof(StringExtensionsBenchmark),
		//	typeof(StringExtensionsCounterBenchmark),
		//	typeof(TaskExtensionsBenchmark),
		//	typeof(TypeExtensionsBenchmark)
		//);
	}
}
