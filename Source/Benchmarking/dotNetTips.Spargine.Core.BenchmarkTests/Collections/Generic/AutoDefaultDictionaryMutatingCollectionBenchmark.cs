// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="AutoDefaultDictionaryMutatingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmark tests for AutoDefaultDictionary methods that mutate the collection,
// including AddOrUpdate, GetOrAdd, TryAdd, and TryUpdate.
// Uses [IterationSetup] to reset the working dictionary before each iteration.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic;

/// <summary>
/// Class AutoDefaultDictionaryMutatingCollectionBenchmark.
/// Benchmark tests for <see cref="AutoDefaultDictionary{TKey,TValue}"/> methods that mutate
/// the collection. A fresh working dictionary is restored before each iteration via
/// <see cref="Reset"/>, eliminating the need for per-benchmark cloning.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class AutoDefaultDictionaryMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private ReadOnlyCollection<Person> _peopleUpsertNew = default!;
	private AutoDefaultDictionary<string, Person> _personRefAutoDefaultDictionary = default!;
	private AutoDefaultDictionary<string, Person> _workingDictionary = default!;

	[Benchmark(Description = "AddOrUpdate")]
	public void AddOrUpdate()
	{
		this.Consume(this._workingDictionary.AddOrUpdate(this.PersonRef01.Id, this.PersonRef01, (key, existingValue) => this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(this._workingDictionary.AddOrUpdate(person.Id, person, (key, existingValue) => person));
		}
	}

	[Benchmark(Description = "GetOrAdd")]
	public void GetOrAdd()
	{
		this.Consume(this._workingDictionary.GetOrAdd(this.PersonRef01.Id, this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(this._workingDictionary.GetOrAdd(person.Id, person));
		}
	}

	[Benchmark(Description = "GetOrAdd: Func")]
	public void GetOrAddFunc()
	{
		this.Consume(this._workingDictionary.GetOrAdd(this.PersonRef01.Id, _ => this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(this._workingDictionary.GetOrAdd(person.Id, _ => person));
		}
	}

	/// <summary>
	/// Resets the working dictionary before each benchmark iteration so that mutations
	/// from the previous invocation do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this._workingDictionary = this._personRefAutoDefaultDictionary.FastBinaryClone<AutoDefaultDictionary<string, Person>>();
	}

	/// <summary>
	/// Initializes the source dictionary and the upsert collection. Called once per benchmark job.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefAutoDefaultDictionary = new AutoDefaultDictionary<string, Person>(this.GetPersonRefDictionary(), this.PersonRef01);
		this._peopleUpsertNew = RandomData.GeneratePersonRefCollection(10);
	}

	[Benchmark(Description = "GetOrAdd: TryAdd")]
	public void TryAdd()
	{
		this.Consume(this._workingDictionary.TryAdd(this.PersonRef01.Id, this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(this._workingDictionary.TryAdd(person.Id, person));
		}
	}

	[Benchmark(Description = "GetOrAdd: TryUpdate")]
	public void TryUpdate()
	{
		this.Consume(this._workingDictionary.TryUpdate(this.PersonRef01.Id, this.PersonRef01, this.PersonRef01));

		foreach (var person in this._peopleUpsertNew)
		{
			this.Consume(this._workingDictionary.TryUpdate(person.Id, person, person));
		}
	}
}
