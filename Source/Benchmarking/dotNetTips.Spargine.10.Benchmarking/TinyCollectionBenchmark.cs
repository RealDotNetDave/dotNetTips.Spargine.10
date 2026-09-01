// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 02-27-2024
//
// Last Modified By : David McCarter
// Last Modified On : 03-05-2025
// ***********************************************************************
// <copyright file="TinyCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmark base class for tiny collection sizes with parameterized
// counts of 2, 4, 8, 16, 32, 64, 128, and 256 elements, inheriting
// preloaded collection support from CollectionBenchmark.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking;


/// <summary>
/// Provides benchmark tests for very small collections, with count values ranging from 2 to 256.
/// This class is designed to measure the performance of operations on collections of varying small sizes,
/// helping to identify the most efficient data structures and algorithms for use cases involving small datasets.
/// </summary>
[Information(Documentation = "https://bit.ly/BenchmarkLikeDotNetDave", Status = Status.Available)]
public class TinyCollectionBenchmark : CollectionBenchmark
{

	/// <summary>
	/// Initializes a new instance of the <see cref="TinyCollectionBenchmark"/> class with a maximum count of 256.
	/// This constructor also logs the maximum count information using the <see cref="ConsoleLogger"/>.
	/// </summary>
	public TinyCollectionBenchmark() : base(256) => LogInfo($"Max Count={this.MaxCount}: {nameof(TinyCollectionBenchmark)}.");

	/// <summary>
	/// Gets or sets the collection count for the benchmark. This value determines the size of the collection to be used in the benchmark tests.
	/// Valid values are 2, 4, 8, 16, 32, 64, 128, and 256, allowing for a range of small collection sizes to be tested.
	/// </summary>
	/// <value>The collection count.</value>
	[Params(2, 4, 8, 16, 32, 64, 128, 256)]
	public int Count { get; set; }

	/// <summary>
	/// Performs setup operations specific to TinyCollectionBenchmark. This includes logging the current count before and after the base setup is called,
	/// and adjusting the MaxCount property to match the current Count. This method is called automatically by the BenchmarkDotNet framework before each benchmark run.
	/// </summary>
	public override void Setup()
	{
		LogInfo($"Count={this.Count}: {nameof(TinyCollectionBenchmark)}");

		// DO NOT CHANGE THESE LINES!
		this.MaxCount = this.Count;

		base.Setup();
	}

}
