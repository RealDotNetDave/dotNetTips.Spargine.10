// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 03-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 05-07-2026
// ***********************************************************************
// <copyright file="FastSortedListCreateAddBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections;

[BenchmarkCategory(Categories.Collections)]
public class FastSortedListCreateAddBenchmark : LargeCollectionBenchmark
{
	private Person[] _peopleRefArrayToInsert = default!;
	private Dictionary<string, Person> _peopleRefDictionaryToInsert = default!;

	[Benchmark(Description = "Add: FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections)]
	public void Add_FastSortedList()
	{
		var people = new FastSortedList<Person>(this.Count);

		foreach (var person in this._peopleRefArrayToInsert)
		{
			people.Add(person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Add: with Comparer(LastName)  - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections)]
	public void Add_FastSortedList_Comparer()
	{
		var people = new FastSortedList<Person>(this.Count, new PersonComparerByLastName());

		foreach (var person in this._peopleRefArrayToInsert)
		{
			people.Add(person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Add: SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Add_SortedList()
	{
		var people = new SortedList<string, Person>(this.Count);

		foreach (var person in this._peopleRefDictionaryToInsert)
		{
			people.Add(person.Key, person.Value);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Add: with OrdinalStringComparer")]
	[BenchmarkCategory(Categories.Collections)]
	public void Add_SortedList_Comparer()
	{
		var people = new SortedList<string, Person>(this.Count, new OrdinalStringComparer());

		foreach (var person in this._peopleRefArrayToInsert)
		{
			people.Add(person.Id, person);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "Add: SortedList<ref> with Tuple")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Add_Tuple_SortedList()
	{
		var people = new SortedList<string, Person>(this.Count);

		foreach (var (key, value) in this._peopleRefDictionaryToInsert)
		{
			people.Add(key, value);
		}

		this.Consume(people);
	}

	[Benchmark(Description = "AddRange: FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddRange_FastSortedList()
	{
		var people = new FastSortedList<Person>(this.Count);

		people.AddRange(this._peopleRefArrayToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = "AddRange: with Comparer(LastName) - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddRange_FastSortedList_Comparer()
	{
		var people = new FastSortedList<Person>(this.Count, new PersonComparerByLastName());

		people.AddRange(this._peopleRefArrayToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = "AddRange: SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddRange_SortedList()
	{
		var people = new SortedList<string, Person>(this.Count);

		_ = people.AddRange(this._peopleRefDictionaryToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = "AddRange:  with OrdinalStringComparer - SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddRange_SortedList_Comparer()
	{
		var people = new SortedList<string, Person>(this.Count, new OrdinalStringComparer());

		_ = people.AddRange(this._peopleRefDictionaryToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = "New: add collection in constructor - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections)]
	public void Create_FastSortedList()
	{
		var people = new FastSortedList<Person>(this._peopleRefArrayToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = "New: add items in constructor + Comparer(LastName) - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections)]
	public void Create_FastSortedList_Comparer()
	{
		var people = new FastSortedList<Person>(this._peopleRefArrayToInsert, new PersonComparerByLastName());

		this.Consume(people);
	}

	[Benchmark(Description = "New: add collection in constructor - SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Create_SortedList()
	{
		var people = new SortedList<string, Person>(this._peopleRefDictionaryToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = "New: with OrdinalStringComparer - SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void Create_SortedList_Comparer()
	{
		var people = new SortedList<string, Person>(this._peopleRefDictionaryToInsert, new OrdinalStringComparer());

		this.Consume(people);
	}

	public override void Setup()
	{
		base.Setup();

		this.GenerateData();
	}

	private void GenerateData()
	{
		this._peopleRefArrayToInsert = this.GetPersonRefArray();
		this._peopleRefDictionaryToInsert = this.GetPersonRefDictionary();
	}
}
