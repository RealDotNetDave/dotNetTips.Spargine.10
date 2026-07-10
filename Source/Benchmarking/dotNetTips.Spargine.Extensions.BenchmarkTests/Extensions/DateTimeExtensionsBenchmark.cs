// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="DateTimeExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for DateTimeExtensions methods.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="DateTimeExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.ValueType)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class DateTimeExtensionsBenchmark : Benchmark
{
	private const string InvalidInvariantDateText = "not-a-date";
	private const string ValidInvariantDateText = "2026-07-09T13:45:30";

	private static readonly TimeSpan RoundingMultiple = TimeSpan.FromMinutes(15);
	private DateTime _clampMaximum;
	private DateTime _clampMinimum;
	private DateTime _clampValueAboveRange;
	private DateTime _clampValueBelowRange;
	private DateTime _clampValueWithinRange;
	private DateTimeOffset _offsetValue;
	private DateTime _roundValue;
	private DateTime _timeValue;

	[Benchmark(Description = nameof(DateTimeExtensions.Clamp) + ": value above maximum")]
	public void ClampAboveMaximum()
	{
		var result = this._clampValueAboveRange.Clamp(this._clampMinimum, this._clampMaximum);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.Clamp) + ": value below minimum")]
	public void ClampBelowMinimum()
	{
		var result = this._clampValueBelowRange.Clamp(this._clampMinimum, this._clampMaximum);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.Clamp) + ": value in range")]
	public void ClampWithinRange()
	{
		var result = this._clampValueWithinRange.Clamp(this._clampMinimum, this._clampMaximum);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.EndOfDay) + ": DateTime")]
	public void EndOfDayDateTime()
	{
		var result = this._timeValue.EndOfDay();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.EndOfDay) + ": DateTimeOffset")]
	public void EndOfDayDateTimeOffset()
	{
		var result = this._offsetValue.EndOfDay();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.RoundToNearestMultiple))]
	public void RoundToNearestMultiple()
	{
		var result = this._roundValue.RoundToNearestMultiple(RoundingMultiple);
		this.Consume(result);
	}

	/// <summary>
	/// Sets up benchmark values.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._clampMinimum = new DateTime(2026, 7, 1, 0, 0, 0, DateTimeKind.Utc);
		this._clampMaximum = new DateTime(2026, 7, 31, 23, 59, 59, DateTimeKind.Utc);
		this._clampValueWithinRange = new DateTime(2026, 7, 9, 13, 45, 30, DateTimeKind.Utc);
		this._clampValueBelowRange = new DateTime(2026, 6, 30, 23, 59, 59, DateTimeKind.Utc);
		this._clampValueAboveRange = new DateTime(2026, 8, 1, 0, 0, 0, DateTimeKind.Utc);
		this._roundValue = new DateTime(2026, 7, 9, 13, 44, 31, DateTimeKind.Utc);
		this._timeValue = new DateTime(2026, 7, 9, 13, 45, 30, DateTimeKind.Utc);
		this._offsetValue = new DateTimeOffset(2026, 7, 9, 13, 45, 30, TimeSpan.FromHours(-8));
	}

	[Benchmark(Description = nameof(DateTimeExtensions.StartOfDay) + ": DateTime")]
	public void StartOfDayDateTime()
	{
		var result = this._timeValue.StartOfDay();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.StartOfDay) + ": DateTimeOffset")]
	public void StartOfDayDateTimeOffset()
	{
		var result = this._offsetValue.StartOfDay();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.ToDateOnly))]
	public void ToDateOnly()
	{
		var result = this._timeValue.ToDateOnly();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.ToTimeOnly))]
	public void ToTimeOnly()
	{
		var result = this._timeValue.ToTimeOnly();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.TryParseInvariant) + ": invalid input")]
	public void TryParseInvariantInvalidInput()
	{
		DateTime parsedValue;
		var success = InvalidInvariantDateText.AsSpan().TryParseInvariant(out parsedValue);
		this.Consume(success);
		this.Consume(parsedValue);
	}

	[Benchmark(Description = nameof(DateTimeExtensions.TryParseInvariant) + ": valid input")]
	public void TryParseInvariantValidInput()
	{
		DateTime parsedValue;
		var success = ValidInvariantDateText.AsSpan().TryParseInvariant(out parsedValue);
		this.Consume(success);
		this.Consume(parsedValue);
	}
}
