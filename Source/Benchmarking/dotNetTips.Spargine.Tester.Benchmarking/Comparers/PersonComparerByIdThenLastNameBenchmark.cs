// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.BenchmarkTests
// Author           : Copilot Agent
// Created          : 10-14-2026
//
// Last Modified By : David McCarter
// Last Modified On : 10-15-2026
// ***********************************************************************
// <copyright file="PersonComparerByIdThenLastNameBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmarks sorting reference-type Person objects by Id then LastName with PersonComparerByIdThenLastName versus OrderBy/ThenBy without a comparer.</summary>
// ***********************************************************************

using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.BenchmarkTests.Comparers;

/// <summary>
/// Benchmarks <see cref="PersonComparerByIdThenLastName"/>.
/// </summary>
[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
public class PersonComparerByIdThenLastNameBenchmark : LargeCollectionBenchmark
{
	private readonly PersonComparerByIdThenLastName _comparer = new();
	private Person[] _people;

	[Benchmark(Description = "OrderBy(): Comparer: Ref: Id, LastName", Baseline = true)]
	public void OrderByWithComparer()
	{
		var result = this._people.OrderBy(person => person, this._comparer).ToArray();

		this.Consume(result);
	}

	[Benchmark(Description = "OrderBy(): No Comparer: Ref: Id, LastName")]
	public void OrderByWithoutComparer()
	{
		var result = this._people
			.OrderBy(person => person.Id, StringComparer.Ordinal)
			.ThenBy(person => person.LastName, StringComparer.Ordinal)
			.ToArray();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._people = this.GetPersonRefArray();

		Debug.Assert(this._people.OrderBy(person => person, this._comparer).SequenceEqual(this._people
			.OrderBy(person => person.Id, StringComparer.Ordinal)
			.ThenBy(person => person.LastName, StringComparer.Ordinal)));
	}
}
