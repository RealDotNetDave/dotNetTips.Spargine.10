// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="RandomDataBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests.Tester;

[BenchmarkCategory(Categories.ReferenceType)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class RandomDataBenchmark : Benchmark
{

	[Benchmark(Description = "Creating: " + nameof(Person))]
	public void CreatePerson01()
	{
		var person = RandomData.GeneratePerson<Person>();

		this.Consume(person);
	}

	[Benchmark(Description = "Creating: " + nameof(Person))]
	public void CreatePerson04()
	{
		var person = RandomData.GeneratePerson<Person>();

		this.Consume(person);
	}

	[Benchmark(Description = "Creating: " + nameof(PersonRecord))]
	public void CreatePerson05()
	{
		var person = RandomData.GeneratePerson<PersonRecord>();

		this.Consume(person);
	}

	[Benchmark(Description = nameof(RandomData.GenerateBoolean))]
	[BenchmarkCategory(Categories.ValueType)]
	public void GenerateBoolean()
	{
		var result = RandomData.GenerateBoolean();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCompanyName))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateCompanyName()
	{
		var result = RandomData.GenerateCompanyName();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCurrencyAmount))]
	[BenchmarkCategory(Categories.ValueType)]
	public void GenerateCurrencyAmount()
	{
		var result = RandomData.GenerateCurrencyAmount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateDateOnly))]
	[BenchmarkCategory(Categories.ValueType)]
	public void GenerateDateOnly()
	{
		var result = RandomData.GenerateDateOnly();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateDateTimeOffset))]
	[BenchmarkCategory(Categories.ValueType)]
	public void GenerateDateTimeOffset()
	{
		var result = RandomData.GenerateDateTimeOffset();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateEnum))]
	[BenchmarkCategory(Categories.ValueType)]
	public void GenerateEnum()
	{
		var result = RandomData.GenerateEnum<DayOfWeek>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateGuid))]
	[BenchmarkCategory(Categories.ValueType)]
	public void GenerateGuid()
	{
		var result = RandomData.GenerateGuid();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateHashString))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateHashString()
	{
		var result = RandomData.GenerateHashString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateIPv4Address))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateIPv4Address()
	{
		var result = RandomData.GenerateIPv4Address();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateIPv6Address))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateIPv6Address()
	{
		var result = RandomData.GenerateIPv6Address();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateJsonObject))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateJsonObject()
	{
		var result = RandomData.GenerateJsonObject();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateParagraph))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateParagraph()
	{
		var result = RandomData.GenerateParagraph();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateSentence))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateSentence()
	{
		var result = RandomData.GenerateSentence();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateTimeOnly))]
	[BenchmarkCategory(Categories.ValueType)]
	public void GenerateTimeOnly()
	{
		var result = RandomData.GenerateTimeOnly();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateTimeSpan))]
	[BenchmarkCategory(Categories.ValueType)]
	public void GenerateTimeSpan()
	{
		var result = RandomData.GenerateTimeSpan();

		this.Consume(result);
	}

	[Benchmark(Description = "PropertiesToString(): " + nameof(Person))]
	public void PropertiesToString01()
	{
		var person = RandomData.GeneratePerson<Person>();

		this.Consume(person.PropertiesToString());
	}

	[Benchmark(Description = "PropertiesToString(): " + nameof(PersonRecord))]
	public void PropertiesToString02()
	{
		var person = RandomData.GeneratePerson<PersonRecord>();

		this.Consume(person.PropertiesToString());
	}

}
