// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2024
// ***********************************************************************
// <copyright file="ImmutableArrayExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class ImmutableArrayExtensionsBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class ImmutableArrayExtensionsBenchmark : LargeCollectionBenchmark
{

	private ImmutableArray<Person> _personRefImmutableArray;

	[Benchmark(Description = nameof(ImmutableArrayExtensions.IsNotEmpty))]
	public void HasItemsIsNotEmpty()
	{
		var result = this._personRefImmutableArray.IsNotEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ImmutableArrayExtensions.IsNotEmpty) + ": With Count")]
	public void HasItemsIsNotEmptyWithCount()
	{
		var result = this._personRefImmutableArray.IsNotEmpty(this.Count);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefImmutableArray = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(ImmutableArrayExtensions.FastShuffle))]
	public void Shuffle()
	{
		var result = this._personRefImmutableArray.FastShuffle();

		this.Consume(result);
	}

}
