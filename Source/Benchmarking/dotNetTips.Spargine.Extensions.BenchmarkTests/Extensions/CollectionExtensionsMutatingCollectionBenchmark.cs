// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="CollectionExtensionsMutatingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmarks for CollectionExtensions methods that mutate collections.</summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class CollectionExtensionsMutatingCollectionBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class CollectionExtensionsMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private Person _existingPerson = default!;
	private Collection<Person> _peopleRefCollection = default!;
	private HashSet<Person> _peopleRefHashSet = default!;
	private List<Person> _peopleRefList = default!;
	private Person _personToInsert = default!;

	[Benchmark(Description = nameof(CollectionExtensions.AddIf) + ": Condition False")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfConditionFalse()
	{
		this._peopleRefList.AddIf(this._personToInsert, false);

		this.Consume(this._peopleRefList);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddIf) + ": Condition True")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfConditionTrue()
	{
		this._peopleRefList.AddIf(this._personToInsert, true);

		this.Consume(this._peopleRefList);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ": Existing Item")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfNotExistsExistingItem()
	{
		var person = this._existingPerson;

		var result = this._peopleRefList.AddIfNotExists(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ": Existing Item - Collection")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfNotExistsExistingItemCollection()
	{
		var person = this._existingPerson;

		var result = this._peopleRefCollection.AddIfNotExists(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ": Existing Item - HashSet")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfNotExistsExistingItemHashSet()
	{
		var person = this._existingPerson;

		var result = this._peopleRefHashSet.AddIfNotExists(person);

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

	[Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ": New Item - Collection")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfNotExistsNewItemCollection()
	{
		var person = this._personToInsert;

		var result = this._peopleRefCollection.AddIfNotExists(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddIfNotExists) + ": New Item - HashSet")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddIfNotExistsNewItemHashSet()
	{
		var person = this._personToInsert;

		var result = this._peopleRefHashSet.AddIfNotExists(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": Collection")]
	public void AddRangeCollection()
	{
		var result = this._peopleRefCollection.AddRange(this.GetPersonRefCollectionToInsert(), true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": Collection - Non-Unique")]
	public void AddRangeCollectionNonUnique()
	{
		var result = this._peopleRefCollection.AddRange(this.GetPersonRefCollectionToInsert(), false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": HashSet")]
	public void AddRangeHashSet()
	{
		var result = this._peopleRefHashSet.AddRange(this.GetPersonRefCollectionToInsert(), true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": HashSet - Non-Unique")]
	public void AddRangeHashSetNonUnique()
	{
		var result = this._peopleRefHashSet.AddRange(this.GetPersonRefCollectionToInsert(), false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": List")]
	public void AddRangeList()
	{
		var result = this._peopleRefList.AddRange(this.GetPersonRefCollectionToInsert(), true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": List - Non-Unique")]
	public void AddRangeListNonUnique()
	{
		var result = this._peopleRefList.AddRange(this.GetPersonRefCollectionToInsert(), false);

		this.Consume(result);
	}

	[IterationSetup]
	public void Reset()
	{
		var people = this.GetPersonRefArray();
		this._peopleRefList = [.. people];
		this._peopleRefCollection = new Collection<Person>([.. people]);
		this._peopleRefHashSet = [.. people];
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		var people = this.GetPersonRefArray();
		this._existingPerson = people[0];
		this._personToInsert = this.GetPersonRefCollectionToInsert()[0];
	}

	[Benchmark(Description = nameof(CollectionExtensions.Upsert) + ": Existing Item")]
	[BenchmarkCategory(Categories.Collections)]
	public void UpsertExistingItem()
	{
		var person = this._existingPerson;

		this._peopleRefList.Upsert(person);

		this.Consume(this._peopleRefList);
	}

	[Benchmark(Description = nameof(CollectionExtensions.Upsert) + ": Existing Item - Collection")]
	[BenchmarkCategory(Categories.Collections)]
	public void UpsertExistingItemCollection()
	{
		var person = this._existingPerson;

		this._peopleRefCollection.Upsert(person);

		this.Consume(this._peopleRefCollection);
	}

	[Benchmark(Description = nameof(CollectionExtensions.Upsert) + ": Existing Item - HashSet")]
	[BenchmarkCategory(Categories.Collections)]
	public void UpsertExistingItemHashSet()
	{
		var person = this._existingPerson;

		this._peopleRefHashSet.Upsert(person);

		this.Consume(this._peopleRefHashSet);
	}

	[Benchmark(Description = nameof(CollectionExtensions.Upsert) + ": New Item")]
	[BenchmarkCategory(Categories.Collections)]
	public void UpsertNewItem()
	{
		var person = this._personToInsert;

		this._peopleRefList.Upsert(person);

		this.Consume(this._peopleRefList);
	}

	[Benchmark(Description = nameof(CollectionExtensions.Upsert) + ": New Item - Collection")]
	[BenchmarkCategory(Categories.Collections)]
	public void UpsertNewItemCollection()
	{
		var person = this._personToInsert;

		this._peopleRefCollection.Upsert(person);

		this.Consume(this._peopleRefCollection);
	}

	[Benchmark(Description = nameof(CollectionExtensions.Upsert) + ": New Item - HashSet")]
	[BenchmarkCategory(Categories.Collections)]
	public void UpsertNewItemHashSet()
	{
		var person = this._personToInsert;

		this._peopleRefHashSet.Upsert(person);

		this.Consume(this._peopleRefHashSet);
	}
}
