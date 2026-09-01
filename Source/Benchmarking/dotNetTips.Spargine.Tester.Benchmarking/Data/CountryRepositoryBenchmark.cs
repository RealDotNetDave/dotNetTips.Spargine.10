// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-11-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="CountryRepositoryBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Data;
using Microsoft.VSDiagnostics;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.BenchmarkTests.Data;

[BenchmarkCategory(Categories.RealWorld)]
[CPUUsageDiagnoser]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class CountryRepositoryBenchmark : Benchmark
{
	[Benchmark(Description = nameof(CountryRepository.GetCountries))]
	public void GetCountries()
	{
		var result = CountryRepository.GetCountries();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryRepository.GetCountry) + ": By CountryCode")]
	public void GetCountry()
	{
		var result = CountryRepository.GetCountry("US");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryRepository.GetCountry) + ": By CountryName")]
	public void GetCountryByCountryName()
	{
		var result = CountryRepository.GetCountry(CountryName.UnitedStates);
		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

	}
}
