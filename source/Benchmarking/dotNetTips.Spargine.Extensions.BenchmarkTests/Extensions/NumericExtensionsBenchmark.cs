// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 09-02-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
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

	private const int ClampMaximum = 100;
	private const int ClampMinimum = 0;
	private const int ClampValueAboveRange = 150;
	private const int ClampValueBelowRange = -25;
	private const int ClampValueWithinRange = 42;

	private const string InvalidNumericText = "invalid";
	private const string ValidDecimalText = "12345.678";
	private const string ValidDoubleText = "12345.678";
	private const string ValidIntText = "12345";
	private readonly double _testDoubleMilliseconds = 18620000d; // ~5 hours 10 minutes 20 seconds
	private readonly long _testLongMilliseconds = 18620000L;     // ~5 hours 10 minutes 20 seconds
	private readonly double _testSubSecondMilliseconds = 500d;   // less than 1000 ms
	private readonly int _testValue = 54928;

	[Benchmark(Description = nameof(NumericExtensions.Clamp) + ": Above Maximum")]
	public void ClampAboveMaximum()
	{
		var result = ClampValueAboveRange.Clamp(ClampMinimum, ClampMaximum);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(NumericExtensions.Clamp) + ": Below Minimum")]
	public void ClampBelowMinimum()
	{
		var result = ClampValueBelowRange.Clamp(ClampMinimum, ClampMaximum);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(NumericExtensions.Clamp) + ": In Range")]
	public void ClampWithinRange()
	{
		var result = ClampValueWithinRange.Clamp(ClampMinimum, ClampMaximum);
		this.Consume(result);
	}

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

	[Benchmark(Description = nameof(NumericExtensions.RoundToNearestMultiple))]
	public void RoundToNearestMultiple()
	{
		var result = 47.RoundToNearestMultiple(8);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(NumericExtensions.ToWords))]
	public void ToWords()
	{
		var result = this._testValue.ToWords();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(NumericExtensions.TryParseInvariant) + ": Decimal Invalid")]
	public void TryParseInvariantDecimalInvalid()
	{
		decimal value;
		var result = InvalidNumericText.AsSpan().TryParseInvariant(out value);
		this.Consume(result);
		this.Consume(value);
	}

	[Benchmark(Description = nameof(NumericExtensions.TryParseInvariant) + ": Decimal Valid")]
	public void TryParseInvariantDecimalValid()
	{
		decimal value;
		var result = ValidDecimalText.AsSpan().TryParseInvariant(out value);
		this.Consume(result);
		this.Consume(value);
	}

	[Benchmark(Description = nameof(NumericExtensions.TryParseInvariant) + ": Double Invalid")]
	public void TryParseInvariantDoubleInvalid()
	{
		double value;
		var result = InvalidNumericText.AsSpan().TryParseInvariant(out value);
		this.Consume(result);
		this.Consume(value);
	}

	[Benchmark(Description = nameof(NumericExtensions.TryParseInvariant) + ": Double Valid")]
	public void TryParseInvariantDoubleValid()
	{
		double value;
		var result = ValidDoubleText.AsSpan().TryParseInvariant(out value);
		this.Consume(result);
		this.Consume(value);
	}

	[Benchmark(Description = nameof(NumericExtensions.TryParseInvariant) + ": Int Invalid")]
	public void TryParseInvariantIntInvalid()
	{
		int value;
		var result = InvalidNumericText.AsSpan().TryParseInvariant(out value);
		this.Consume(result);
		this.Consume(value);
	}

	[Benchmark(Description = nameof(NumericExtensions.TryParseInvariant) + ": Int Valid")]
	public void TryParseInvariantIntValid()
	{
		int value;
		var result = ValidIntText.AsSpan().TryParseInvariant(out value);
		this.Consume(result);
		this.Consume(value);
	}
}
