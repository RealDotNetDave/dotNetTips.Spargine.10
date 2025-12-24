// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
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

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests.Tester;

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
