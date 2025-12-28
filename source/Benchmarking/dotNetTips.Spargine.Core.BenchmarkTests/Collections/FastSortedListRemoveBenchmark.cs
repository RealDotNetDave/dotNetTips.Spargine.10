// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-13-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="FastSortedListRemoveBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections;

[BenchmarkCategory(Categories.Collections)]
public class FastSortedListRemoveBenchmark : TinyCollectionBenchmark
{
	private Person _lastPersonRefFastSortedList;
	private KeyValuePair<string, Person> _lastPersonRefSortedList;
	private FastSortedList<Person> _personRefFastSortedList;
	private SortedList<string, Person> _personRefSortedList;

	private void GenerateData()
	{
		// FastSortedList
		this._personRefFastSortedList = [.. this.GetPersonRefArray()];
		this._lastPersonRefFastSortedList = this._personRefFastSortedList[^1];

		// SortedList
		this._personRefSortedList = new SortedList<string, Person>(this.GetPersonRefDictionary());
		this._lastPersonRefSortedList = this._personRefSortedList.Last();
	}

	[Benchmark(Description = "Remove: FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Remove_FastSortedList()
	{
		var people = new FastSortedList<Person>(this._personRefFastSortedList);

		_ = people.Remove(this._lastPersonRefFastSortedList);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "Remove: SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Remove_SortedList()
	{
		var people = new SortedList<string, Person>(this._personRefSortedList);

		_ = people.Remove(this._lastPersonRefSortedList.Value.Id);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "RemoveAt: FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveAt_FastSortedList()
	{
		var people = new FastSortedList<Person>(this._personRefFastSortedList);

		people.RemoveAt(people.Count - 1);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "RemoveAt: Comparer(LastName) - FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveAt_FastSortedList_Comparer()
	{
		var people = new FastSortedList<Person>(this._personRefFastSortedList, new PersonComparerByLastName());

		people.RemoveAt(people.Count - 1);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "RemoveAt: FastSortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void RemoveAt_SortedList()
	{
		var people = new FastSortedList<Person>(this._personRefFastSortedList);

		people.RemoveAt(people.Count - 1);

		this.Consume(people.Count);
	}

	[Benchmark(Description = "RemoveAt: With Comparer(LastName) - SortedList<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void RemoveAt_SortedList_Comparer()
	{
		var people = new SortedList<string, Person>(this._personRefSortedList, new OrdinalStringComparer());

		people.RemoveAt(people.Count - 1);

		this.Consume(people.Count);
	}

	public override void Setup()
	{
		base.Setup();

		this.GenerateData();
	}
}
