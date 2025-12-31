// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="DictionaryExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
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

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class DictionaryExtensionsCollectionBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class DictionaryExtensionsCollectionBenchmark : LargeCollectionBenchmark
{
	private KeyValuePair<string, Person> _personRef;

	private Dictionary<string, Person> _personRefDictionary;
	private Dictionary<string, Person> _personRefDictionaryToInsert;

	[Benchmark(Description = nameof(DictionaryExtensions.AddRange))]
	public void AddRange()
	{
		var people = this._personRefDictionary;

		var result = people.AddRange(this._personRefDictionaryToInsert);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Dictionary")]
	[BenchmarkCategory(Categories.Collections)]
	public void GetOrAddDictionary02()
	{
		var people = this._personRefDictionary;

		var result = people.GetOrAdd(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.IsNotEmpty) + ": With Predicate")]
	public void HasItemsWithPredicateTest()
	{
		var people = this._personRefDictionary;

		// Explicitly specify the extension method to resolve ambiguity
		var result = DictionaryExtensions.IsNotEmpty(people, p => p.Value.BornOn.Value.Date.Month > 0);

		this.Consume(result);
	}
	public override void Setup()
	{
		base.Setup();

		this._personRefDictionary = this.GetPersonRefDictionary();
		this._personRefDictionaryToInsert = this.GetPersonRefCollectionToInsert().ToDictionary(p => p.Id);
		this._personRef = this._personRefDictionary.Last();
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToConcurrentDictionary))]
	public void ToConcurrentDictionary()
	{
		var people = this._personRefDictionary.ToConcurrentDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToDelimitedString))]
	public void ToDelimitedString()
	{
		var people = this._personRefDictionary;

		var result = people.ToDelimitedString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToFrozenDictionary))]
	public void ToFrozenDictionary()
	{
		var people = this._personRefDictionary.ToFrozenDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToImmutableDictionary))]
	public void ToImmutableDictionary()
	{
		var people = this._personRefDictionary.ToImmutableDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToLookupWithDefault))]
	[BenchmarkCategory(Categories.New)]
	public void ToLookupWithDefault()
	{
		var people = this._personRefDictionary;

		var result = people.ToLookupWithDefault(this._personRef.Value)("INVALID");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToReadOnlyCollection))]
	public void ToReadOnlyCollection()
	{
		var people = this._personRefDictionary.ToReadOnlyCollection();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToReadOnlyDictionary))]
	public void ToReadOnlyDictionary()
	{
		var people = this._personRefDictionary.ToReadOnlyDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToSortedDictionary) + ": Comparer")]
	public void ToSortedDictionaryComparerTest()
	{
		var people = this._personRefDictionary.ToSortedDictionary(new OrdinalStringComparer());

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToSortedDictionary))]
	public void ToSortedDictionaryTest()
	{
		var people = this._personRefDictionary.ToSortedDictionary();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.TryGetValue))]
	[BenchmarkCategory(Categories.New)]
	public void TryGetValue()
	{
		var people = this._personRefDictionary;

		// Test the extension method with a factory function
		var result = people.TryGetValue(this._personRef.Key, key => this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
	public void UpsertDictionary01()
	{
		var people = this._personRefDictionary;
		var person = people.Last();

		people.Upsert(person.Key, person.Value);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ": New Person")]
	public void UpsertDictionary02()
	{
		var people = this._personRefDictionary;

		people.Upsert(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(people);
	}

}
