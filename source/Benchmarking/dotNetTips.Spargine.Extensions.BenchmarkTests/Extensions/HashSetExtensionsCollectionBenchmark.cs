// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 06-10-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-22-2024
// ***********************************************************************
// <copyright file="HashSetExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class HashSetExtensionsCollectionBenchmark : LargeCollectionBenchmark
{

	private HashSet<Person> _peopleRefToAdd;
	private HashSet<Person> _personRefHashSet;
	private Person _personRefToAdd;

	[Benchmark(Description = nameof(HashSetExtensions.AddIf))]
	public void AddIf()
	{
		var collection = this._personRefHashSet;

		collection.AddIf(this._personRefToAdd, true);

		this.Consume(collection);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefHashSet = [.. this.GetPersonRefArray()];
		this._peopleRefToAdd = [.. this._personRefHashSet.Take(this.Count / 2)];
		this._personRefToAdd = this._personRefHashSet.Last();

	}

	[Benchmark(Description = nameof(HashSetExtensions.ToConcurrentHashSet))]
	public void ToConcurrentHashSet()
	{
		var result = this._personRefHashSet.ToConcurrentHashSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(HashSetExtensions.ToImmutableHashSet))]
	public void ToImmutableHashSet()
	{
		var result = this._personRefHashSet.ToImmutableHashSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(HashSetExtensions.Upsert))]
	public void Upsert()
	{
		var collection = this._personRefHashSet;

		collection.Upsert(this._personRefToAdd);

		this.Consume(collection);
	}

}
