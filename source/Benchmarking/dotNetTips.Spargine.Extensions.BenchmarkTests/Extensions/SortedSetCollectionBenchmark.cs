// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-14-2024
// ***********************************************************************
// <copyright file="SortedSetCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
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
/// Class SortedSetCollectionBenchmark. Implements the <see cref="LargeCollectionBenchmark"/>
/// </summary>
/// <seealso cref="LargeCollectionBenchmark"/>
[BenchmarkCategory(Categories.Collections)]
public class SortedSetCollectionBenchmark : LargeCollectionBenchmark
{

	private SortedSet<Person> _personRefSortedSet;

	[Benchmark(Description = nameof(SortedSetExtensions.IsEmpty))]
	public void DoesNotHaveItems()
	{
		var people = this._personRefSortedSet;

		this.Consume(people.IsEmpty());
	}

	[Benchmark(Description = nameof(SortedSetExtensions.IsNotEmpty))]
	public void HasItems()
	{
		this.Consume(this._personRefSortedSet.IsNotEmpty());
	}

	[Benchmark(Description = nameof(SortedSetExtensions.IsNotEmpty) + ": With Predicate")]
	public void HasItemsWithPredicate()
	{
		this.Consume(this._personRefSortedSet.IsNotEmpty(p => p.LastName.IsNotEmpty()));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefSortedSet = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(SortedSetExtensions.ToImmutableSortedSet))]
	public void ToImmutableSortedSet()
	{
		var people = this._personRefSortedSet;

		this.Consume(people.ToImmutableSortedSet());
	}

}
