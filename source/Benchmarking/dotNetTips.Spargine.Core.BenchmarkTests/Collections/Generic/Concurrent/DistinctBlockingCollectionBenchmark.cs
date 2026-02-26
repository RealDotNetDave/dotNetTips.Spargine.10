// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-26-2026
//
// Last Modified By : David McCarter
// Last Modified On : 02-26-2026
// ***********************************************************************
// <copyright file="DistinctBlockingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Threading;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent;

[BenchmarkCategory(Categories.Async)]
public class DistinctBlockingCollectionBenchmark : LargeCollectionBenchmark
{
	private DistinctBlockingCollection<Person> _peopleRefDistinctBlockingCollection;
	private Person[] _peopleRefToInsert;

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Add))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void Add()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		people.Add(this.PersonRef01);
		people.Add(this.PersonRef01);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.AddRange))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void AddRange()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		this.Consume(people.AddRange(this._peopleRefToInsert));
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Clear))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void Clear()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		people.Clear();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Clone))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void Clone()
	{
		using (var people = this._peopleRefDistinctBlockingCollection.Clone())
		{
			this.Consume(people);
		}
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Contains))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void Contains()
	{
		this.Consume(this._peopleRefDistinctBlockingCollection.Contains(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.ContainsAny))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void ContainsAny()
	{
		this.Consume(this._peopleRefDistinctBlockingCollection.ContainsAny(this._peopleRefToInsert));
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Remove))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void Remove()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		this.Consume(people.Remove(this.PersonRefLookupLast));
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRefToInsert = this.GetPersonRefCollectionToInsert();
		this._peopleRefDistinctBlockingCollection = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAdd))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void TryAdd()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		this.Consume(people.TryAdd(this.PersonRef01));
		this.Consume(people.TryAdd(this.PersonRef01));

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAddRange))]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void TryAddRange()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		this.Consume(people.TryAddRange(this._peopleRefToInsert));
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAdd) + ": with Timeout")]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void TryAddWithTimeout()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		this.Consume(people.TryAdd(this.PersonRef01, 10));
		this.Consume(people.TryAdd(this.PersonRef01, 10));

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAdd) + ": with Timeout & CancellationToken")]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void TryAddWithTimeoutAndCancellationToken()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		this.Consume(people.TryAdd(this.PersonRef01, 10, CancellationToken.None));
		this.Consume(people.TryAdd(this.PersonRef01, 10, CancellationToken.None));

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAdd) + ": with Timespan")]
	[BenchmarkCategory(Categories.Async, Categories.New)]
	public void TryAddWithTimespan()
	{
		using var people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

		this.Consume(people.TryAdd(this.PersonRef01, TimeSpan.FromMilliseconds(10)));
		this.Consume(people.TryAdd(this.PersonRef01, TimeSpan.FromMilliseconds(10)));

		this.Consume(people);
	}
}
