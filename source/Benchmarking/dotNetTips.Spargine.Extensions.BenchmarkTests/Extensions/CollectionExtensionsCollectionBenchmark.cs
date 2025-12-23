// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Collections.ObjectModel;
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

	private Collection<Person> _peopleRefCollection;
	private List<Person> _peopleRefList;

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": List")]
	public void AddRange01()
	{
		var people = this._peopleRefList;

		_ = people.AddRange(this.GetPersonRefCollectionToInsert(), true);

		this.Consume(people);
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

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		LogInfo($"Calling base.Setup(): {nameof(CollectionExtensionsCollectionBenchmark)}.");

		base.Setup();

		this._peopleRefCollection = this.GetPersonRefArray().ToCollection();
		this._peopleRefList = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(CollectionExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._peopleRefCollection.ToFrozenSet();

		this.Consume(result);
	}

}
