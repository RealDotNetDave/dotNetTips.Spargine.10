// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 10-08-2025
//
// Last Modified By : David McCarter
// Last Modified On : 10-13-2025
// ***********************************************************************
// <copyright file="CollectionLoopingBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Class CollectionLoopingBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[Information(Status = Status.New)]
public class CollectionLoopingBenchmark : LargeCollectionBenchmark
{
	private Person[] _personRefArray;
	private List<Person> _personRefList;

	[Benchmark(Description = "for(): Array(Ref)")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ForArrayRef()
	{
		var collection = this._personRefArray;

		for (var index = 0; index < collection.Length; index++)
		{
			this.Consume(collection[index]);
		}
	}

	[Benchmark(Description = "foreach(): Array(Ref)")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ForEachArrayRef()
	{
		var collection = this._personRefArray;

		foreach (var person in collection)
		{
			this.Consume(person);
		}
	}

	[Benchmark(Description = "foreach(): List<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ReferenceType)]
	public void ForEachListRef()
	{
		var collection = this._personRefList;

		foreach (var person in collection)
		{
			this.Consume(person);
		}
	}

	[Benchmark(Description = "for(): List<ref>")]
	[BenchmarkCategory(Categories.Collections, Categories.ReferenceType)]
	public void ForListRef()
	{
		var collection = this._personRefList;

		for (var index = 0; index < collection.Count; index++)
		{
			this.Consume(collection[index]);
		}
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefList = [.. this.GetPersonRefArray()];
		this._personRefArray = this.GetPersonRefArray();
	}
}
