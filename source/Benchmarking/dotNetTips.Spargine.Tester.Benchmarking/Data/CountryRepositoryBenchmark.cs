// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-11-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-01-2025
// ***********************************************************************
// <copyright file="CountryRepositoryBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Data;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.BenchmarkTests.Data;

public class CountryRepositoryBenchmark : Benchmark
{
	[Benchmark(Description = nameof(CountryRepository.GetCountries))]
	[BenchmarkCategory(Categories.New)]
	public void GetCountries()
	{
		var result = CountryRepository.GetCountries();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryRepository.GetCountry))]
	[BenchmarkCategory(Categories.New)]
	public void GetCountry()
	{
		var result = CountryRepository.GetCountry("US");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryRepository.GetCountry) + ": By CountryName")]
	[BenchmarkCategory(Categories.New)]
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
