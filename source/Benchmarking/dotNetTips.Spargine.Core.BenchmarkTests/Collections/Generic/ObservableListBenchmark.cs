// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-26-2026
//
// Last Modified By : David McCarter
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="ObservableListBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic;

public class ObservableListBenchmark : LargeCollectionBenchmark
{
	// TODO: MOVE ADD/REMOVE METHODS TO SEPARATE BENCHMARK CLASS. USE [IterationSetup]

	private Person[] _personRefItemsToInsert = default!;
	private ObservableList<Person> _personRefObservableList = default!;

	[Benchmark(Description = nameof(ObservableList<>.Add))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Add()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.Add(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(ObservableList<>.AddRange))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void AddRange()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.AddRange(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.Clear))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Clear()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.Clear();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.Contains))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Contains()
	{
		this.Consume(this._personRefObservableList.Contains(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(ObservableList<>.CopyTo))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void CopyTo()
	{
		var array = new Person[this._personRefObservableList.Count];
		this._personRefObservableList.CopyTo(array);

		this.Consume(array);
	}

	[Benchmark(Description = nameof(ObservableList<>.CopyTo) + " with index")]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void CopyToWithIndex()
	{
		var array = new Person[this._personRefObservableList.Count];
		this._personRefObservableList.CopyTo(array, 0);

		this.Consume(array);
	}

	[Benchmark(Description = nameof(ObservableList<>.CopyTo) + " with index and count(half)")]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void CopyToWithIndexAndCount()
	{
		var array = new Person[this._personRefObservableList.Count];
		this._personRefObservableList.CopyTo(array, 0, this.HalfCount);

		this.Consume(array);
	}

	[Benchmark(Description = nameof(ObservableList<>.ExceptWith))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void ExceptWith()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.ExceptWith(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.FindAll))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void FindAll()
	{
		this.Consume(this._personRefObservableList.FindAll(p => p.Addresses.Count > 0));
	}

	[Benchmark(Description = nameof(ObservableList<>.FirstOrDefault))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void FirstOrDefault()
	{
		this.Consume(this._personRefObservableList.FirstOrDefault());
	}

	[Benchmark(Description = nameof(ObservableList<>.IntersectWith))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void IntersectWith()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.IntersectWith(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.IsProperSubsetOf))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void IsProperSubsetOf()
	{
		this.Consume(this._personRefObservableList.IsProperSubsetOf(this._personRefItemsToInsert));
	}


	[Benchmark(Description = nameof(ObservableList<>.IsProperSupersetOf))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void IsProperSupersetOf()
	{
		this.Consume(this._personRefObservableList.IsProperSupersetOf(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.IsSubsetOf))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void IsSubsetOf()
	{
		this.Consume(this._personRefObservableList.IsSubsetOf(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.IsSupersetOf))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void IsSupersetOf()
	{
		this.Consume(this._personRefObservableList.IsSupersetOf(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.LastOrDefault))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void LastOrDefault()
	{
		this.Consume(this._personRefObservableList.LastOrDefault());
	}

	[Benchmark(Description = nameof(ObservableList<>.Overlaps))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Overlaps()
	{
		this.Consume(this._personRefObservableList.Overlaps(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.Remove))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Remove()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.Remove(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(ObservableList<>.RemoveRange))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void RemoveRange()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.RemoveRange(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.RemoveWhere))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void RemoveWhere()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.RemoveWhere(p => p.Addresses.Count > 0));
	}

	[Benchmark(Description = nameof(ObservableList<>.Reset))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Reset()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.Reset(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.SetEquals))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void SetEquals()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.SetEquals(this._personRefItemsToInsert));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefObservableList = [.. this.GetPersonRefArray()];
		this._personRefItemsToInsert = this.GetPersonRefCollectionToInsert();
	}

	[Benchmark(Description = nameof(ObservableList<>.SymmetricExceptWith))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void SymmetricExceptWith()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.SymmetricExceptWith(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.ToArray))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void ToArray()
	{
		this.Consume(this._personRefObservableList.ToArray());
	}

	[Benchmark(Description = nameof(ObservableList<>.ToList))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void ToList()
	{
		this.Consume(this._personRefObservableList.ToList());
	}

	[Benchmark(Description = nameof(ObservableList<>.TryGetValue))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void TryGetValue()
	{
		this.Consume(this._personRefObservableList.TryGetValue(this.PersonRefLookupLast, out var person));
		this.Consume(person);
	}

	[Benchmark(Description = nameof(ObservableList<>.UnionWith))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void UnionWith()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.UnionWith(this._personRefItemsToInsert);

		this.Consume(people);
	}

}
