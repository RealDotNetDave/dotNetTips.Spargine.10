// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="ObservableListMutatingBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmark tests for ObservableList methods that mutate the collection,
// including Add, AddRange, Clear, ExceptWith, IntersectWith, Remove, RemoveRange,
// RemoveWhere, Reset, SymmetricExceptWith, and UnionWith.
// Uses [IterationSetup] to reset the working collection before each iteration.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic;

/// <summary>
/// Class ObservableListMutatingBenchmark.
/// Benchmark tests for <see cref="ObservableList{T}"/> methods that mutate the collection.
/// A fresh instance is created before each iteration via <see cref="ResetCollection"/>,
/// eliminating the per-benchmark <c>new ObservableList&lt;&gt;</c> allocations.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.GenericCollections)]
[MemoryDiagnoser]
[ThreadingDiagnoser]
public class ObservableListMutatingBenchmark : LargeCollectionBenchmark
{
	private ObservableList<Person> _people = default!;
	private Person[] _personRefItemsToInsert = default!;

	[Benchmark(Description = nameof(ObservableList<>.Add))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Add()
	{
		this.Consume(this._people.Add(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(ObservableList<>.AddRange))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void AddRange()
	{
		this._people.AddRange(this._personRefItemsToInsert);

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(ObservableList<>.Clear))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Clear()
	{
		this._people.Clear();

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(ObservableList<>.ExceptWith))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void ExceptWith()
	{
		this._people.ExceptWith(this._personRefItemsToInsert);

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(ObservableList<>.IntersectWith))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void IntersectWith()
	{
		this._people.IntersectWith(this._personRefItemsToInsert);

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(ObservableList<>.Remove))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void Remove()
	{
		this.Consume(this._people.Remove(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(ObservableList<>.RemoveRange))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void RemoveRange()
	{
		this.Consume(this._people.RemoveRange(this._personRefItemsToInsert));
	}

	[Benchmark(Description = nameof(ObservableList<>.RemoveWhere))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void RemoveWhere()
	{
		this.Consume(this._people.RemoveWhere(p => p.Addresses.Count > 0));
	}

	/// <summary>
	/// Resets the working collection before each benchmark iteration so that mutations
	/// from the previous invocation do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void ResetCollection()
	{
		this._people = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(ObservableList<>.Reset))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void ResetList()
	{
		this._people.Reset(this._personRefItemsToInsert);

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(ObservableList<>.SetEquals))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void SetEquals()
	{
		this.Consume(this._people.SetEquals(this._personRefItemsToInsert));
	}

	/// <summary>
	/// Initializes all fields. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._people = [.. this.GetPersonRefArray()];
		this._personRefItemsToInsert = this.GetPersonRefCollectionToInsert();
	}

	[Benchmark(Description = nameof(ObservableList<>.SymmetricExceptWith))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void SymmetricExceptWith()
	{
		this._people.SymmetricExceptWith(this._personRefItemsToInsert);

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(ObservableList<>.UnionWith))]
	[BenchmarkCategory(Categories.GenericCollections)]
	public void UnionWith()
	{
		this._people.UnionWith(this._personRefItemsToInsert);

		this.Consume(this._people);
	}
}
