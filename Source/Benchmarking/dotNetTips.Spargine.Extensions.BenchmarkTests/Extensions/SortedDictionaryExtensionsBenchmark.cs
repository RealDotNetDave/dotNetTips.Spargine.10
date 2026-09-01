// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="SortedDictionaryExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class SortedDictionaryExtensionsBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class SortedDictionaryExtensionsBenchmark : LargeCollectionBenchmark
{
	private ReadOnlyCollection<Person> _peopleUpsertNew = default!;
	private SortedDictionary<string, Person> _personRefSortedDictionary = default!;

	[Benchmark(Description = nameof(SortedDictionaryExtensions.IsEmpty))]
	public void IsEmpty()
	{
		this.Consume(this._personRefSortedDictionary.IsEmpty());
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.IsNotEmpty))]
	public void IsNotEmpty()
	{
		this.Consume(this._personRefSortedDictionary.IsNotEmpty());
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.IsNotEmpty) + ": With Count")]
	public void IsNotEmptyWithCount()
	{
		this.Consume(this._personRefSortedDictionary.IsNotEmpty(this.Count));
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.IsNotEmpty) + ": With Predicate")]
	public void IsNotEmptyWithPredicate()
	{
		this.Consume(this._personRefSortedDictionary.IsNotEmpty(p => p.Value.BornOn!.Value.Date.Month > 0));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefSortedDictionary = this.GetPersonRefDictionary().ToSorted();
		this._peopleUpsertNew = RandomData.GeneratePersonRefCollection(10);
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.ToImmutable))]
	public void ToImmutable()
	{
		this.Consume(this._personRefSortedDictionary.ToImmutable());
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.Upsert))]
	public void Upsert()
	{
		var collection = this._personRefSortedDictionary.FastBinaryClone<SortedDictionary<string, Person>>();

		// Add existing
		collection.Upsert(this.PersonRefLookupLast);

		// Add new
		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(collection.Upsert(person.Id, person));
		}
	}
}
