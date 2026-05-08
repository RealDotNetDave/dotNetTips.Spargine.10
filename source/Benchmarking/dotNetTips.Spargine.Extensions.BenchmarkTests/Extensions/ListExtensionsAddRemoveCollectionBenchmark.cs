// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-02-2026
//
// Last Modified By : David McCarter
// Last Modified On : 05-07-2026
// ***********************************************************************
// <copyright file="ListExtensionsAddRemoveCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ListExtensionsAddRemoveCollectionBenchmark : LargeCollectionBenchmark
{
	private List<PersonRecord> _peopleRecordList = default!;
	private List<Person> _peopleRefList = default!;
	private IEnumerable<Person> _peopleRefSubSet = default!;
	private List<Spargine.Tester.Models.ValueTypes.Person> _peopleValList = default!;

	[Benchmark(Description = nameof(ListExtensions.AddFirst))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddFirst()
	{
		var people = this._peopleRefList;

		people.AddFirst(this.PersonRef01);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddFirst) + ": Ref")]
	public void AddFirstRef()
	{
		var people = this._peopleRefList;
		var item = this._peopleRefSubSet.First();

		people.AddFirst(item);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddFirst) + ": Val")]
	public void AddFirstVal()
	{
		var people = this._peopleValList;
		var item = this._peopleValList[0];

		people.AddFirst(item);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddLast))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddLast()
	{
		var people = this._peopleRefList;

		people.AddLast(this.PersonRef01);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddLast) + ": Ref")]
	public void AddLastRef()
	{
		var people = this._peopleRefList;
		var item = this._peopleRefSubSet.First();

		people.AddLast(item);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddLast) + ": Val")]
	public void AddLastVal()
	{
		var people = this._peopleValList;
		var item = this._peopleValList[0];

		people.AddLast(item);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddRangeIfNotExists))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddRangeIfNotExists()
	{
		var people = this._peopleRefList;
		var peopleToAdd = this._peopleRefSubSet;

		people.AddRangeIfNotExists(peopleToAdd);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddRangeIfNotExists) + ": Ref")]
	public void AddRangeIfNotExistsRef()
	{
		var people = this._peopleRefList;

		people.AddRangeIfNotExists(this._peopleRefSubSet);

		this.Consume(people);
	}

	[IterationSetup]
	public void IterationSetup()
	{
		this._peopleRecordList = [.. this.GetPersonRecordArray()];
		this._peopleRefList = [.. this.GetPersonRefArray()];
		this._peopleValList = [.. this.GetPersonValArray()];
	}


	[Benchmark(Description = nameof(ListExtensions.RemoveFirst))]
	[BenchmarkCategory(Categories.Collections)]
	public void RemoveFirst()
	{
		var result = this._peopleRefList.RemoveFirst(this._peopleRefList.First());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveFirst) + ": Ref")]
	public void RemoveFirstRef()
	{
		var people = this._peopleRefList;
		var item = this._peopleRefSubSet.First();

		var result = people.RemoveFirst(item);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveFirst) + ": Val")]
	public void RemoveFirstVal()
	{
		var people = this._peopleValList;
		var item = this._peopleValList[0];

		var result = people.RemoveFirst(item);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveLast))]
	[BenchmarkCategory(Categories.Collections)]
	public void RemoveLast()
	{
		var result = this._peopleRefList.RemoveLast(this._peopleRefList.Last());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveLast) + ": Ref")]
	public void RemoveLastRef()
	{
		var people = this._peopleRefList;
		var item = this._peopleRefSubSet.First();

		var result = people.RemoveLast(item);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveLast) + ": Val")]
	public void RemoveLastVal()
	{
		var people = this._peopleValList;
		var item = this._peopleValList.First();
		var result = people.RemoveLast(item);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this.LoadCollections();
	}

	private void LoadCollections()
	{
		this._peopleRecordList = [.. this.GetPersonRecordArray()];
		this._peopleRefList = [.. this.GetPersonRefArray()];
		this._peopleRefSubSet = this.GetPersonRefArray().TakeLast(this.Count / 10).ToList();
		this._peopleValList = [.. this.GetPersonValArray()];
	}
}
