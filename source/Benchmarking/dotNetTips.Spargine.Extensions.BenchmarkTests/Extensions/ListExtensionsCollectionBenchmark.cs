// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-07-2025
// ***********************************************************************
// <copyright file="ListExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ListExtensionsCollectionBenchmark : LargeCollectionBenchmark
{
	private List<PersonRecord> _peopleRecordList;
	private List<Person> _peopleRefList;
	private List<Person> _peopleRefSubSet;
	private List<Spargine.Tester.Models.ValueTypes.Person> _peopleValList;
	private readonly Person _person = RandomData.GeneratePerson<Person>();

	[Benchmark(Description = nameof(ListExtensions.AddFirst))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddFirst()
	{
		var people = this._peopleRefList;

		people.AddFirst(this._person);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddLast))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddLast()
	{
		var people = this._peopleRefList;

		people.AddLast(this._person);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddRangeIfNotExists))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRangeIfNotExists()
	{
		var people = this._peopleRefList;
		var peopleToAdd = this._peopleRefSubSet;

		people.AddRangeIfNotExists(peopleToAdd);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AsReadOnlySpan))]
	public void AsReadOnlySpan()
	{
		var people = this._peopleRefList;

		var collection = people.AsReadOnlySpan();

		this.Consume(collection.Length);
	}

	[Benchmark(Description = nameof(ListExtensions.AsSpan))]
	public void AsSpan()
	{
		var people = this._peopleRefList;

		var collection = people.AsSpan();

		this.Consume(collection.Length);
	}

	[Benchmark(Description = nameof(ListExtensions.ClearNulls))]
	public void ClearNulls()
	{
		var people = this._peopleRefList;
		people.Add(null);

		var result = people.ClearNulls();

		this.Consume(result);
	}

	[Benchmark(Description = "CopyTo()")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison, Categories.New)]
	public void CopyToList()
	{
		var result = new Person[this._peopleRefList.Count];
		this._peopleRefList.CopyTo(result);

		this.Consume(result);
	}

	[Benchmark(Description = "Count")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void Count_Count()
	{
		var result = this._peopleRefList.Count;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.FastCount))]
	[BenchmarkCategory(Categories.New)]
	public void Count_FastCount()
	{
		var result = this._peopleRefList.FastCount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IsEmpty))]
	[BenchmarkCategory(Categories.Collections)]
	public void DoesNotHaveItems()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsEmpty());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": record")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeRecord()
	{
		var people = this._peopleRecordList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": ref")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeRef()
	{
		var people = this._peopleRefList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": val")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeVal()
	{
		var people = this._peopleValList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.IsNotEmpty))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItems()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsNotEmpty());
	}

	[Benchmark(Description = nameof(ListExtensions.IsNotEmpty) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithCount()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsNotEmpty(5));
	}

	[Benchmark(Description = nameof(ListExtensions.IsNotEmpty) + ": With Predicate")]
	public void HasItemsWithPredicate()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsNotEmpty(p => p.BornOn.Value.Date.Month > 0));
	}

	[Benchmark(Description = "Index []")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void Index()
	{
		var result = this._peopleRefList[this.Count / 2];

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IndexAtLooped))]
	public void IndexAtLooped()
	{
		var result = this._peopleRefList.IndexAtLooped(this.Count / 2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IsEqualTo))]
	[BenchmarkCategory(Categories.Collections)]
	public void IsEqualTo()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsEqualTo(this._peopleRefList));
	}

	[IterationSetup]
	public void IterationSetup()
	{
		this._peopleRecordList = [.. this.GetPersonRecordArray()];
		this._peopleRefList = [.. this.GetPersonRefArray()];
		this._peopleValList = [.. this.GetPersonValArray()];
	}

	[Benchmark(Description = nameof(ListExtensions.PerformAction) + " :Ref")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void PerformAction_Ref()
	{
		var people = this._peopleRefList;
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append(CultureInfo.CurrentCulture, $"{person.ToString()}|"));

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveFirst))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveFirst()
	{
		var result = this._peopleRefList.RemoveFirst(this._peopleRefList.First());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveLast))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveLast()
	{
		var result = this._peopleRefList.RemoveLast(this._peopleRefList.Last());

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRecordList = [.. this.GetPersonRecordArray()];
		this._peopleRefList = [.. this.GetPersonRefArray()];
		this._peopleRefSubSet = [.. this.GetPersonRefArray().TakeLast(10)];
		this._peopleValList = [.. this.GetPersonValArray()];

	}

	[Benchmark(Description = nameof(ListExtensions.FastShuffle))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void ShuffleFastShuffle()
	{
		this.Consume(this._peopleRefList.FastShuffle());
	}

	[Benchmark(Description = "Shuffle")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void ShuffleShuffle()
	{
		var result = this._peopleRefList.Shuffle().Last();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.Split))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Split()
	{
		var result = this._peopleRefList.Split(this._peopleRefList.Count / 2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._peopleRefList.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToImmutableArray))]
	public void ToImmutableArray()
	{
		var result = this._peopleRefList.ToImmutableArray();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToObservableCollection))]
	public void ToObservableCollection()
	{
		var result = this._peopleRefList.ToObservableCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyList))]
	public void ToReadOnlyList()
	{
		var result = this._peopleRefList.ToReadOnlyList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyObservableCollection))]
	public void ToReadOnlyObservableCollection()
	{
		var result = this._peopleRefList.ToReadOnlyObservableCollection();

		this.Consume(result);
	}

}
