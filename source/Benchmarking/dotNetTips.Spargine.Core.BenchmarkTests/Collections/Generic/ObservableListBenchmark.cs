// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-26-2026
//
// Last Modified By : David McCarter
// Last Modified On : 02-26-2026
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
	private Person[] _personRefItemsToInsert;
	private ObservableList<Person> _personRefObservableList;

	[Benchmark(Description = nameof(ObservableList<>.Add))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void Add()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.Add(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(ObservableList<>.AddRange))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void AddRange()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.AddRange(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.Clear))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void Clear()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.Clear();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.Contains))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void Contains()
	{
		this.Consume(this._personRefObservableList.Contains(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(ObservableList<>.CopyTo))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void CopyTo()
	{
		var array = new Person[this._personRefObservableList.Count];
		this._personRefObservableList.CopyTo(array);

		this.Consume(array);
	}

	[Benchmark(Description = nameof(ObservableList<>.CopyTo) + " with index")]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void CopyToWithIndex()
	{
		var array = new Person[this._personRefObservableList.Count];
		this._personRefObservableList.CopyTo(array, 0);

		this.Consume(array);
	}

	[Benchmark(Description = nameof(ObservableList<>.CopyTo) + " with index and count")]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void CopyToWithIndexAndCount()
	{
		var array = new Person[this._personRefObservableList.Count];
		this._personRefObservableList.CopyTo(array, 0, this.HalfCount);

		this.Consume(array);
	}

	[Benchmark(Description = nameof(ObservableList<>.ExceptWith))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void ExceptWith()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.ExceptWith(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.FindAll))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void FindAll()
	{
		this.Consume(this._personRefObservableList.FindAll(p => p.Addresses.Count > 0));
	}

	[Benchmark(Description = nameof(ObservableList<>.FirstOrDefault))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void FirstOrDefault()
	{
		this.Consume(this._personRefObservableList.FirstOrDefault());
	}

	[Benchmark(Description = nameof(ObservableList<>.IntersectWith))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void IntersectWith()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.IntersectWith(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.IsProperSubsetOf))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void IsProperSubsetOf()
	{
		this.Consume(this._personRefObservableList.IsProperSubsetOf(this._personRefItemsToInsert));
	}


	[Benchmark(Description = nameof(ObservableList<>.IsProperSupersetOf))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void IsProperSupersetOf()
	{
		this.Consume(this._personRefObservableList.IsProperSupersetOf(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.IsSubsetOf))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void IsSubsetOf()
	{
		this.Consume(this._personRefObservableList.IsSubsetOf(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.IsSupersetOf))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void IsSupersetOf()
	{
		this.Consume(this._personRefObservableList.IsSupersetOf(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.LastOrDefault))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void LastOrDefault()
	{
		this.Consume(this._personRefObservableList.LastOrDefault());
	}

	[Benchmark(Description = nameof(ObservableList<>.Overlaps))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void Overlaps()
	{
		this.Consume(this._personRefObservableList.Overlaps(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.Remove))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void Remove()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.Remove(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(ObservableList<>.RemoveRange))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void RemoveRange()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.RemoveRange(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.RemoveWhere))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void RemoveWhere()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.RemoveWhere(p => p.Addresses.Count > 0));
	}

	[Benchmark(Description = nameof(ObservableList<>.Reset))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void Reset()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.Reset(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.SetEquals))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void SetEquals()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		this.Consume(people.SetEquals(this._personRefItemsToInsert));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefObservableList = new ObservableList<Person>(this.GetPersonRefArray());
		this._personRefItemsToInsert = this.GetPersonRefCollectionToInsert();
	}

	[Benchmark(Description = nameof(ObservableList<>.SymmetricExceptWith))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void SymmetricExceptWith()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.SymmetricExceptWith(this._personRefItemsToInsert);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ObservableList<>.ToArray))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void ToArray()
	{
		this.Consume(this._personRefObservableList.ToArray());
	}

	[Benchmark(Description = nameof(ObservableList<>.ToList))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void ToList()
	{
		this.Consume(this._personRefObservableList.ToList());
	}

	[Benchmark(Description = nameof(ObservableList<>.TryGetValue))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void TryGetValue()
	{
		this.Consume(this._personRefObservableList.TryGetValue(this.PersonRefLookupLast, out var person));
		this.Consume(person);
	}

	[Benchmark(Description = nameof(ObservableList<>.UnionWith))]
	[BenchmarkCategory(Categories.GenericCollections, Categories.New)]
	public void UnionWith()
	{
		var people = new ObservableList<Person>(this.GetPersonRefArray());

		people.UnionWith(this._personRefItemsToInsert);

		this.Consume(people);
	}

}
