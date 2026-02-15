// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : david
// Created          : 10-07-2024
//
// Last Modified By : david
// Last Modified On : 02-15-2026
// ***********************************************************************
// <copyright file="EnumerationBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

public class EnumerationBenchmark : Benchmark
{

	[Benchmark(Description = nameof(Enumeration.FromDisplayName))]
	public void FromDisplayName()
	{
		var result = Enumeration.FromDisplayName<NumericFormat>("C");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(Enumeration.FromValue))]
	public void FromName()
	{
		var result = Enumeration.FromValue<NumericFormat>(1);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(Enumeration.GetAll))]
	public void GetAll()
	{
		var result = Enumeration.GetAll<NumericFormat>();

		foreach (var item in result)
		{
			this.Consume(item);
		}
	}

	[Benchmark(Description = nameof(Enumeration.TryFromDisplayName))]
	public void TryFromDisplayName()
	{
		_ = Enumeration.TryFromDisplayName<NumericFormat>(NumericFormat.Decimal.DisplayName, out var result);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(Enumeration.TryFromValue))]
	public void TryFromValue()
	{
		_ = Enumeration.TryFromValue<NumericFormat>(1, out var result);

		this.Consume(result);
	}
}
