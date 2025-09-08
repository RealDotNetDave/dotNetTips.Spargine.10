// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-11-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-01-2025
// ***********************************************************************
// <copyright file="CountryPhonePostalInfoRepositoryBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Data;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Data;

public class CountryPhonePostalInfoRepositoryBenchmark : Benchmark
{

	[Benchmark(Description = nameof(CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo))]
	[BenchmarkCategory(Categories.New)]
	public void GetCountryPhonePostalInfo()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo();
		this.Consume(result);
	}
	[Benchmark(Description = nameof(CountryPhonePostalInfoRepository.ValidatePhoneNumber) + ": US")]
	[BenchmarkCategory(Categories.New)]
	public void ValidatePhoneNumber()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "1-555-666-7777", true);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryPhonePostalInfoRepository.ValidatePostalCode) + ": US-Full")]
	[BenchmarkCategory(Categories.New)]
	public void ValidatePostalCode()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("United States", "92130-1234");
		this.Consume(result);
	}
}
