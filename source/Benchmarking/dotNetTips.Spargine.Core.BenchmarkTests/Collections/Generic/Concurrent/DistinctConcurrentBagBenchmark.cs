// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-26-2026
//
// Last Modified By : David McCarter
// Last Modified On : 04-17-2026
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

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.Add))]
	[BenchmarkCategory(Categories.Async)]
	public void Add()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		people.Add(this.PersonRef01);
		people.Add(this.PersonRef02);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.AddRange))]
	[BenchmarkCategory(Categories.Async)]
	public void AddRange()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		this.Consume(people.AddRange(this._peopleRefToInsert));
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.Clear))]
	[BenchmarkCategory(Categories.Async)]
	public void Clear()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		people.Clear();

		this.Consume(people);
	}

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

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.Remove))]
	[BenchmarkCategory(Categories.Async)]
	public void Remove()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		this.Consume(people.Remove(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.RemoveRange))]
	[BenchmarkCategory(Categories.Async)]
	public void RemoveRange()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		this.Consume(people.RemoveRange(this._peopleRefToInsert));
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

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.TryAdd))]
	[BenchmarkCategory(Categories.Async)]
	public void TryAdd()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		this.Consume(people.TryAdd(this.PersonRef01));
		this.Consume(people.TryAdd(this.PersonRef02));

	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.TryGetValue))]
	[BenchmarkCategory(Categories.Async)]
	public void TryGetValue()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		this.Consume(people.TryGetValue(this.PersonRef01, out var person));

		this.Consume(person);
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.TryPeek))]
	[BenchmarkCategory(Categories.Async)]
	public void TryPeek()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		this.Consume(people.TryPeek(this.PersonRefLookupLast, out var person));

		this.Consume(person);

	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.TryTake))]
	[BenchmarkCategory(Categories.Async)]
	public void TryTake()
	{
		var people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());

		this.Consume(people.TryTake(out var person));

		this.Consume(person);
	}
}
