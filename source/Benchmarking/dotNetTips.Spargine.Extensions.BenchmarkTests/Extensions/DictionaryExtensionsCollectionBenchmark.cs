// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2026
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
		var result = this._personRefDictionary.AddRange(this._personRefDictionaryToInsert);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd))]
	[BenchmarkCategory(Categories.Collections)]
	public void GetOrAdd()
	{
		var result = this._personRefDictionary.GetOrAdd(this.PersonRef01.Id, this.PersonRef01);

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

	[IterationSetup(Targets = new[] { nameof(AddRange), nameof(Upsert), nameof(GetOrAdd) })]
	public void IterationSetupRef()
	{
		this._personRefDictionary = this.GetPersonRefDictionary();
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

	[Benchmark(Description = nameof(DictionaryExtensions.ToFrozen))]
	public void ToFrozen()
	{
		var people = this._personRefDictionary.ToFrozen();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToImmutable))]
	public void ToImmutable()
	{
		var people = this._personRefDictionary.ToImmutable();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToImmutableSorted))]
	public void ToImmutableSorted()
	{
		var people = this._personRefDictionary.ToImmutableSorted();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToLookupWithDefault))]
	[BenchmarkCategory(Categories.Collections)]
	public void ToLookupWithDefault()
	{
		var people = this._personRefDictionary;

		var result = people.ToLookupWithDefault(this._personRef.Value)("INVALID");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToReadOnly))]
	public void ToReadOnlyCollection()
	{
		var people = this._personRefDictionary.ToReadOnly();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToSorted) + ": Comparer")]
	public void ToSortedDictionaryComparerTest()
	{
		var people = this._personRefDictionary.ToSorted(new OrdinalStringComparer());

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToSorted))]
	public void ToSortedDictionaryTest()
	{
		var people = this._personRefDictionary.ToSorted();

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.TryGetValue))]
	[BenchmarkCategory(Categories.Collections)]
	public void TryGetValue()
	{
		var people = this._personRefDictionary;

		var result = people.TryGetValue(this._personRef.Key, key => this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
	public void Upsert()
	{
		this._personRefDictionary.Upsert(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(this._personRefDictionary);
	}
}
