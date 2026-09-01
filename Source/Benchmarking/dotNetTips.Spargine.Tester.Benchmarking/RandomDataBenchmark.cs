// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-14-2026
// ***********************************************************************
// <copyright file="RandomDataBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VSDiagnostics;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

[BenchmarkCategory(Categories.RealWorld)]
[CPUUsageDiagnoser]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class RandomDataBenchmark : Benchmark
{

	private readonly string _filePath = Path.Combine(
		Environment.GetFolderPath(
			Environment.SpecialFolder.ApplicationData,
			Environment.SpecialFolderOption.DoNotVerify),
		"BenchmarkTests");

	public override void Cleanup()
	{
		base.Cleanup();

		if (Directory.Exists(this._filePath))
		{
			Directory.Delete(this._filePath, true);
		}
	}


	[Benchmark(Description = nameof(RandomData.GenerateAddress) + ": Ref")]
	public void GenerateAddressRef()
	{
		var result = RandomData.GenerateAddress<Address>();

		this.Consume(result);
	}


	[Benchmark(Description = nameof(RandomData.GenerateCharacter))]
	public void GenerateCharacter()
	{
		var result = RandomData.GenerateCharacter();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCharacter) + ": Min and Max Char")]
	public void GenerateCharacterMinMax()
	{
		var result = RandomData.GenerateCharacter(char.MinValue, char.MaxValue);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCoordinate))]
	public void GenerateCoordinate()
	{
		var result = RandomData.GenerateCoordinate<Coordinate>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateDecimal))]
	public void GenerateDecimal()
	{
		var result = RandomData.GenerateDecimal(0, maxValue: 1000, decimalPlaces: 2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateDomainExtension))]
	public void GenerateDomainExtension()
	{
		var result = RandomData.GenerateDomainExtension();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateEmailAddress))]
	public void GenerateEmailAddress()
	{
		var result = RandomData.GenerateEmailAddress();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateFirstName))]
	public void GenerateFirstName()
	{
		var result = RandomData.GenerateFirstName();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateInteger))]
	public void GenerateInteger()
	{
		var result = RandomData.GenerateInteger();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateKey))]
	public void GenerateKey()
	{
		var result = RandomData.GenerateKey();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateLastName))]
	public void GenerateLastName()
	{
		var result = RandomData.GenerateLastName();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePerson) + ": Ref")]
	public void GeneratePersonRef()
	{
		var result = RandomData.GeneratePerson<Person>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePerson) + ": Val")]
	public void GeneratePersonVal()
	{
		var result = RandomData.GeneratePerson<Models.ValueTypes.Person>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePhoneNumber))]
	public void GeneratePhoneNumber()
	{
		var result = RandomData.GeneratePhoneNumber(CountryName.UnitedStates);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomFileName))]
	public void GenerateRandomFileName()
	{
		var fileName = RandomData.GenerateRandomFileName();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomFileName) + ": With Path")]
	public void GenerateRandomFileNameWithPath()
	{
		var fileName = RandomData.GenerateRandomFileName(this._filePath);

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomLocationData))]
	public void GenerateRandomLocationData()
	{
		var result = RandomData.GenerateRandomLocationData();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomPersonData))]
	public void GenerateRandomPersonData()
	{
		var result = RandomData.GenerateRandomPersonData();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRandomPersonName))]
	public void GenerateRandomPersonName()
	{
		var result = RandomData.GenerateRandomPersonName();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateRelativeUrl))]
	public void GenerateRelativeUrl()
	{
		var result = RandomData.GenerateRelativeUrl();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrl))]
	public void GenerateUrl()
	{
		var result = RandomData.GenerateUrl();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrlFragment))]
	public void GenerateUrlFragment()
	{
		var fileName = RandomData.GenerateUrlFragment();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrlHostName))]
	public void GenerateUrlHostName()
	{
		var fileName = RandomData.GenerateUrlHostName();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrlHostNameNoProtocol))]
	public void GenerateUrlHostNameNoProtocol()
	{
		var fileName = RandomData.GenerateUrlHostNameNoProtocol();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateUrlHostNameNoSubDomain))]
	public void GenerateUrlHostNameNoSubDomain()
	{
		var fileName = RandomData.GenerateUrlHostNameNoSubDomain();

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateBoolean))]
	public void GenerateBoolean()
	{
		var result = RandomData.GenerateBoolean();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCompanyName))]
	public void GenerateCompanyName()
	{
		var result = RandomData.GenerateCompanyName();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCurrencyAmount))]
	public void GenerateCurrencyAmount()
	{
		var result = RandomData.GenerateCurrencyAmount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateDateOnly))]
	public void GenerateDateOnly()
	{
		var result = RandomData.GenerateDateOnly();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateDateTimeOffset))]
	public void GenerateDateTimeOffset()
	{
		var result = RandomData.GenerateDateTimeOffset();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateEnum) + ": DayOfWeek")]
	public void GenerateEnum()
	{
		var result = RandomData.GenerateEnum<DayOfWeek>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateGuid))]
	public void GenerateGuid()
	{
		var result = RandomData.GenerateGuid();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateHashString))]
	public void GenerateHashString()
	{
		var result = RandomData.GenerateHashString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateIPv4Address))]
	public void GenerateIPv4Address()
	{
		var result = RandomData.GenerateIPv4Address();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateIPv6Address))]
	public void GenerateIPv6Address()
	{
		var result = RandomData.GenerateIPv6Address();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateJsonObject))]
	public void GenerateJsonObject()
	{
		var result = RandomData.GenerateJsonObject();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateParagraph))]
	public void GenerateParagraph()
	{
		var result = RandomData.GenerateParagraph();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateSentence))]
	public void GenerateSentence()
	{
		var result = RandomData.GenerateSentence();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateTimeOnly))]
	public void GenerateTimeOnly()
	{
		var result = RandomData.GenerateTimeOnly();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateTimeSpan))]
	public void GenerateTimeSpan()
	{
		var result = RandomData.GenerateTimeSpan();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(PersonExtensions.get_Age))]
	public void PersonGetAge()
	{
		var result = this.PersonRef01.Age;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(PersonExtensions.get_FullName))]
	public void PersonGetFullName()
	{
		var result = this.PersonRef01.FullName;
		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		_ = Directory.CreateDirectory(this._filePath);
	}

}
