// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 10-08-2025
//
// Last Modified By : David McCarter
// Last Modified On : 10-08-2025
// ***********************************************************************
// <copyright file="CollectionLoopingBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Class CollectionLoopingBenchmark.
/// Implements the <see cref="SmallCollectionBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionBenchmark" />
[Information(Status = Status.New)]
public class CollectionLoopingBenchmark : SmallCollectionBenchmark
{
	private Person[] _personRefArray;
	private List<Person> _personRefList;

	[Benchmark(Description = "for(): Array(Ref)")]
	public void ForArrayRef()
	{
		var collection = this._personRefArray;

		for (var index = 0; index < collection.Length; index++)
		{
			this.Consume(collection[index]);
		}
	}

	[Benchmark(Description = "foreach(): Array(Ref)")]
	public void ForEachArrayRef()
	{
		var collection = this._personRefArray;

		foreach (var person in collection)
		{
			this.Consume(person);
		}
	}

	[Benchmark(Description = "foreach(): List<ref>")]
	public void ForEachListRef()
	{
		var collection = this._personRefList;

		foreach (var person in collection)
		{
			this.Consume(person);
		}
	}

	[Benchmark(Description = "for(): List<ref>")]
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
