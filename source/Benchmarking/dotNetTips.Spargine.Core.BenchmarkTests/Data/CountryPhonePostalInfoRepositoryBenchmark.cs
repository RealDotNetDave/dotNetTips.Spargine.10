// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-11-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="CountryPhonePostalInfoRepositoryBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Data;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Data;

[MemoryDiagnoser]
public class CountryPhonePostalInfoRepositoryBenchmark : Benchmark
{

	[Benchmark(Description = nameof(CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo))]
	public void GetCountryPhonePostalInfo()
	{
		var result = CountryPhonePostalInfoRepository.GetCountryPhonePostalInfo();
		this.Consume(result);
	}
	[Benchmark(Description = nameof(CountryPhonePostalInfoRepository.ValidatePhoneNumber) + ": US")]
	public void ValidatePhoneNumber()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePhoneNumber("United States", "1-555-666-7777", true);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(CountryPhonePostalInfoRepository.ValidatePostalCode) + ": US-Full")]
	public void ValidatePostalCode()
	{
		var result = CountryPhonePostalInfoRepository.ValidatePostalCode("United States", "92130-1234");
		this.Consume(result);
	}
}
