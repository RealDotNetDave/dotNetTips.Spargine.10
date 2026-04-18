// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class CollectionExtensionsCollectionBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class CollectionExtensionsCollectionBenchmark : LargeCollectionBenchmark
{

	private Person _existingPerson = default!;
	private Collection<Person> _peopleRefCollection = default!;
	private List<Person> _peopleRefList = default!;
	private Person _personToInsert = default!;

	[Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ": Existing Item")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfNotExistsExistingItem()
	{
		var person = this._existingPerson;

		var result = this._peopleRefList.AddIfNotExists(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ": New Item")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfNotExistsNewItem()
	{
		var person = this._personToInsert;

		var result = this._peopleRefList.AddIfNotExists(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": List")]
	public void AddRangeList()
	{
		var people = this._peopleRefList;

		var result = people.AddRange(this.GetPersonRefCollectionToInsert(), true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsReadOnlySpan))]
	public void AsReadOnlySpan()
	{
		var result = this._peopleRefCollection.AsReadOnlySpan();

		this.Consume(result.ToArray());
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsSpan))]
	public void AsSpan()
	{
		var result = this._peopleRefCollection.AsSpan();

		this.Consume(result.ToArray());
	}

	[IterationSetup(Targets = new[] { nameof(AddRangeList), nameof(AddIfNotExistsNewItem), nameof(AddIfNotExistsExistingItem), nameof(UpsertExistingItem), nameof(UpsertNewItem) })]
	public void IterationSetupRef()
	{
		this._peopleRefList = this.GetPersonRefArray().ToList();
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		var people = this.GetPersonRefArray();
		this._peopleRefCollection = people.ToCollection();
		this._peopleRefList = [.. people];
		this._existingPerson = people[0];
		this._personToInsert = this.GetPersonRefCollectionToInsert()[0];
	}

	[Benchmark(Description = nameof(CollectionExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._peopleRefCollection.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.Upsert) + ": Existing Item")]
	[BenchmarkCategory(Categories.Collections)]
	public void UpsertExistingItem()
	{
		var person = this._existingPerson;

		this._peopleRefList.Upsert(person);

		this.Consume(this._peopleRefList.Count);
	}

	[Benchmark(Description = nameof(CollectionExtensions.Upsert) + ": New Item")]
	[BenchmarkCategory(Categories.Collections)]
	public void UpsertNewItem()
	{
		var person = this._personToInsert;

		this._peopleRefList.Upsert(person);

		this.Consume(this._peopleRefList.Count);
	}

}
