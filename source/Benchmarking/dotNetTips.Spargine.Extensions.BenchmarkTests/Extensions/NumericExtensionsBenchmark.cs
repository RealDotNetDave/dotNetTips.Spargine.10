// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 09-02-2024
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="NumericExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for NumericExtensions methods including FormatTime and ToWords.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Math)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class NumericExtensionsBenchmark : Benchmark
{

	private readonly double _testDoubleMilliseconds = 18620000d; // ~5 hours 10 minutes 20 seconds
	private readonly long _testLongMilliseconds = 18620000L;     // ~5 hours 10 minutes 20 seconds
	private readonly double _testSubSecondMilliseconds = 500d;   // less than 1000 ms
	private readonly int _testValue = 54928;

	[Benchmark(Description = nameof(NumericExtensions.FormatTime) + "_Double_Hours")]
	public void FormatTimeDoubleHours()
	{
		var result = this._testDoubleMilliseconds.FormatTime();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(NumericExtensions.FormatTime) + "_Double_Milliseconds")]
	public void FormatTimeDoubleMilliseconds()
	{
		var result = this._testSubSecondMilliseconds.FormatTime();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(NumericExtensions.FormatTime) + "_Long_Hours")]
	public void FormatTimeLongHours()
	{
		var result = this._testLongMilliseconds.FormatTime();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(NumericExtensions.FormatTime) + "_Long_Milliseconds")]
	public void FormatTimeLongMilliseconds()
	{
		var result = ((long)500).FormatTime();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(NumericExtensions.ToWords))]
	public void ToWords()
	{
		var result = this._testValue.ToWords();

		this.Consume(result);
	}
}
