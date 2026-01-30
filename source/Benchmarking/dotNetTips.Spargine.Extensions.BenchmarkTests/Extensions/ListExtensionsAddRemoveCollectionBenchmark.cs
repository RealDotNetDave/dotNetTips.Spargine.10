// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-02-2026
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2026
// ***********************************************************************
// <copyright file="ListExtensionsAddRemoveCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ListExtensionsAddRemoveCollectionBenchmark : LargeCollectionBenchmark
{
	private List<PersonRecord> _peopleRecordList;
	private List<Person> _peopleRefList;
	private IEnumerable<Person> _peopleRefSubSet;
	private List<Spargine.Tester.Models.ValueTypes.Person> _peopleValList;

	[Benchmark(Description = nameof(ListExtensions.AddFirst))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddFirst()
	{
		var people = this._peopleRefList;

		people.AddFirst(base.PersonRef01);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddLast))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddLast()
	{
		var people = this._peopleRefList;

		people.AddLast(base.PersonRef01);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ListExtensions.AddRangeIfNotExists))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void AddRangeIfNotExists()
	{
		var people = this._peopleRefList;
		var peopleToAdd = this._peopleRefSubSet;

		people.AddRangeIfNotExists(peopleToAdd);

		this.Consume(people);
	}

	[IterationSetup]
	public void IterationSetup()
	{
		this._peopleRecordList = this.GetPersonRecordArray().ToList();
		this._peopleRefList = this.GetPersonRefArray().ToList();
		this._peopleValList = this.GetPersonValArray().ToList();
	}


	[Benchmark(Description = nameof(ListExtensions.RemoveFirst))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveFirst()
	{
		var result = this._peopleRefList.RemoveFirst(this._peopleRefList.First());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.RemoveLast))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveLast()
	{
		var result = this._peopleRefList.RemoveLast(this._peopleRefList.Last());

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this.LoadCollections();
	}

	private void LoadCollections()
	{
		this._peopleRecordList = this.GetPersonRecordArray().ToList();
		this._peopleRefList = this.GetPersonRefArray().ToList();
		this._peopleRefSubSet = this.GetPersonRefArray().TakeLast(this.Count / 10).ToList();
		this._peopleValList = this.GetPersonValArray().ToList();
	}
}
