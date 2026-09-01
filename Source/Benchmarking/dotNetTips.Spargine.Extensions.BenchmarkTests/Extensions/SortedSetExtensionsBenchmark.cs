// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="SortedSetExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class SortedSetExtensionsBenchmark. Implements the <see cref="LargeCollectionBenchmark"/>
/// </summary>
/// <seealso cref="LargeCollectionBenchmark"/>
[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class SortedSetExtensionsBenchmark : LargeCollectionBenchmark
{
	private SortedSet<Person> _personRefSortedSet = default!;

	[Benchmark(Description = nameof(SortedSetExtensions.IsNotEmpty))]
	public void IsNotEmpty()
	{
		this.Consume(this._personRefSortedSet.IsNotEmpty());
	}

	[Benchmark(Description = nameof(SortedSetExtensions.IsNotEmpty) + ": With Predicate")]
	public void IsNotEmptyWithPredicate()
	{
		this.Consume(this._personRefSortedSet.IsNotEmpty(p => p.LastName.IsNotEmpty()));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefSortedSet = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(SortedSetExtensions.ToImmutable))]
	public void ToImmutableSortedSet()
	{
		var people = this._personRefSortedSet;

		this.Consume(people.ToImmutable());
	}

}
