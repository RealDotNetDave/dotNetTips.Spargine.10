// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2026
// ***********************************************************************
// <copyright file="SortedDictionaryExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class SortedDictionaryExtensionsBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class SortedDictionaryExtensionsBenchmark : LargeCollectionBenchmark
{

	private SortedDictionary<string, Person> _personRefSortedDictionary;

	[Benchmark(Description = nameof(SortedDictionaryExtensions.IsEmpty))]
	public void DoesNotHaveItems()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.IsEmpty());
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.IsNotEmpty))]
	public void HaveItems()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.IsNotEmpty());
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.IsNotEmpty) + ": With Count")]
	public void HaveItemsWithCount()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.IsNotEmpty(this.Count));
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.IsNotEmpty) + ": With Predicate")]
	public void HaveItemsWithPredicate()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.IsNotEmpty(p => p.Value.BornOn.Value.Date.Month > 0));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefSortedDictionary = this.GetPersonRefDictionary().ToSorted();
	}

	[Benchmark(Description = nameof(SortedDictionaryExtensions.ToImmutable))]
	public void ToImmutable()
	{
		var people = this._personRefSortedDictionary;

		this.Consume(people.ToImmutable());
	}

	//[Benchmark(Description = nameof(SortedDictionaryExtensions.Upsert))]
	//public void Upsert()
	//{
	//	var people = this._personRefSortedDictionary;

	//	people.Upsert(this.PersonRef01);

	//	this.Consume(people);
	//}

}
