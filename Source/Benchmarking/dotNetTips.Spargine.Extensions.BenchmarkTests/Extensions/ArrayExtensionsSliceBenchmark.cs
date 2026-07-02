// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-02-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-02-2026
// ***********************************************************************
// <copyright file="ArrayExtensionsSliceBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for ArrayExtensions FastSlice methods.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class ArrayExtensionsSliceBenchmark.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class ArrayExtensionsSliceBenchmark : SmallCollectionBenchmark
{
	private const int SliceLength = 10;
	private const int SliceStart = 5;
	private Person[] _personRefArray = default!;
	private Spargine.Tester.Models.ValueTypes.Person[] _personValArray = default!;

	[Benchmark(Description = nameof(ArrayExtensions.FastSliceToMemory) + ": Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void FastSliceToMemoryRef()
	{
		var result = this._personRefArray.FastSliceToMemory(SliceStart, SliceLength);

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSliceToMemory) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void FastSliceToMemoryVal()
	{
		var result = this._personValArray.FastSliceToMemory(SliceStart, SliceLength);

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSliceToReadOnlyMemory) + ": Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void FastSliceToReadOnlyMemoryRef()
	{
		var result = this._personRefArray.FastSliceToReadOnlyMemory(SliceStart, SliceLength);

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSliceToReadOnlyMemory) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void FastSliceToReadOnlyMemoryVal()
	{
		var result = this._personValArray.FastSliceToReadOnlyMemory(SliceStart, SliceLength);

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSliceToReadOnlySpan) + ": Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void FastSliceToReadOnlySpanRef()
	{
		var result = this._personRefArray.FastSliceToReadOnlySpan(SliceStart, SliceLength);

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSliceToReadOnlySpan) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void FastSliceToReadOnlySpanVal()
	{
		var result = this._personValArray.FastSliceToReadOnlySpan(SliceStart, SliceLength);

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSliceToSpan) + ": Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void FastSliceToSpanRef()
	{
		var result = this._personRefArray.FastSliceToSpan(SliceStart, SliceLength);

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSliceToSpan) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void FastSliceToSpanVal()
	{
		var result = this._personValArray.FastSliceToSpan(SliceStart, SliceLength);

		this.Consume(result.Length);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefArray = this.GetPersonRefArray();
		this._personValArray = this.GetPersonValArray();

		LogInfo($"PersonRefArray: {this._personRefArray.Length}");
		LogInfo($"PersonValArray: {this._personValArray.Length}");
	}
}
