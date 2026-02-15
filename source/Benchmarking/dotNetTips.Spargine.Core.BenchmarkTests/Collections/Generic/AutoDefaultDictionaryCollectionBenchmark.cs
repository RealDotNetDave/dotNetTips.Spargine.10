// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-15-2026
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2026
// ***********************************************************************
// <copyright file="AutoDefaultDictionaryCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic;


public class AutoDefaultDictionaryCollectionBenchmark : LargeCollectionBenchmark
{
	private ReadOnlyCollection<Person> _peopleUpsertNew;
	private AutoDefaultDictionary<string, Person> _personRefAutoDefaultDictionary;

	[Benchmark(Description = "AddOrUpdate")]
	public void AddOrUpdate()
	{
		var collection = this._personRefAutoDefaultDictionary.FastBinaryClone<AutoDefaultDictionary<string, Person>>();

		this.Consume(collection.AddOrUpdate(this.PersonRef01.Id, this.PersonRef01, (key, existingValue) => this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(collection.AddOrUpdate(person.Id, person, (key, existingValue) => person));
		}
	}

	[Benchmark(Description = "ContainsValue")]
	public void ContainsValue()
	{
		var result = this._personRefAutoDefaultDictionary.ContainsValue(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = "ContainsValue: Comparer")]
	public void ContainsValueComparer()
	{
		var result = this._personRefAutoDefaultDictionary.ContainsValue(this.PersonRef01, new PersonEqualityComparer());

		this.Consume(result);
	}

	[Benchmark(Description = "GetOrAdd")]
	public void GetOrAdd()
	{
		var collection = this._personRefAutoDefaultDictionary.FastBinaryClone<AutoDefaultDictionary<string, Person>>();

		this.Consume(collection.GetOrAdd(this.PersonRef01.Id, this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(collection.GetOrAdd(person.Id, person));
		}
	}

	[Benchmark(Description = "GetOrAdd: Func")]
	public void GetOrAddFunc()
	{
		var collection = this._personRefAutoDefaultDictionary.FastBinaryClone<AutoDefaultDictionary<string, Person>>();

		this.Consume(collection.GetOrAdd(this.PersonRef01.Id, _ => this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(collection.GetOrAdd(person.Id, _ => person));
		}
	}

	[Benchmark(Description = "GetValueOrDefault")]
	public void GetValueOrDefault()
	{
		var result = this._personRefAutoDefaultDictionary.GetValueOrDefault(this.PersonRef01.Id);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefAutoDefaultDictionary = new AutoDefaultDictionary<string, Person>(this.GetPersonRefDictionary(), this.PersonRef01);

		this._peopleUpsertNew = RandomData.GeneratePersonRefCollection(10);
	}

	[Benchmark(Description = "ToImmutableDictionary")]
	public void ToImmutableDictionary()
	{
		var result = this._personRefAutoDefaultDictionary.ToImmutableDictionary();

		this.Consume(result);
	}

	[Benchmark(Description = "GetOrAdd: TryAdd")]
	public void TryAdd()
	{
		var collection = this._personRefAutoDefaultDictionary.FastBinaryClone<AutoDefaultDictionary<string, Person>>();

		this.Consume(collection.TryAdd(this.PersonRef01.Id, this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(collection.TryAdd(person.Id, person));
		}
	}

	[Benchmark(Description = "GetOrAdd: TryUpdate")]
	public void TryUpdate()
	{
		var collection = this._personRefAutoDefaultDictionary.FastBinaryClone<AutoDefaultDictionary<string, Person>>();

		this.Consume(collection.TryUpdate(this.PersonRef01.Id, this.PersonRef01, this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(collection.TryUpdate(person.Id, person, person));
		}
	}
}
