// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="RandomDataBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

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
