// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-26-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="DistinctConcurrentBagBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************


using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent;

[BenchmarkCategory(Categories.Async)]
[ThreadingDiagnoser]
public class DistinctConcurrentBagBenchmark : LargeCollectionBenchmark
{
	private DistinctConcurrentBag<Person> _peopleRefDistinctConcurrentBag = default!;
	private Person[] _peopleRefToInsert = default!;

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.Contains))]
	[BenchmarkCategory(Categories.Async)]
	public void Contains()
	{
		this.Consume(this._peopleRefDistinctConcurrentBag.Contains(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.ContainsAny))]
	[BenchmarkCategory(Categories.Async)]
	public void ContainsAny()
	{
		this.Consume(this._peopleRefDistinctConcurrentBag.ContainsAny(this._peopleRefToInsert));
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.CopyTo))]
	[BenchmarkCategory(Categories.Async)]
	public void CopyTo()
	{
		var people = new Person[this._peopleRefDistinctConcurrentBag.Count];

		this._peopleRefDistinctConcurrentBag.CopyTo(people, 0);

		this.Consume(people);
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRefToInsert = this.GetPersonRefCollectionToInsert();
		this._peopleRefDistinctConcurrentBag = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.ToArray))]
	[BenchmarkCategory(Categories.Async)]
	public void ToArray()
	{
		this.Consume(this._peopleRefDistinctConcurrentBag.ToArray());
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.ToFrozenSet))]
	[BenchmarkCategory(Categories.Async)]
	public void ToFrozenSet()
	{
		this.Consume(this._peopleRefDistinctConcurrentBag.ToFrozenSet());
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.ToList))]
	[BenchmarkCategory(Categories.Async)]
	public void ToList()
	{
		this.Consume(this._peopleRefDistinctConcurrentBag.ToList());
	}

}
