// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="DictionaryExtensionsMutatingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark tests for DictionaryExtensions methods that mutate the collection,
// including AddRange, GetOrAdd, and Upsert.
// Uses [IterationSetup] to reset the working dictionary before each iteration.
// </summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class DictionaryExtensionsMutatingCollectionBenchmark.
/// Benchmark tests for <see cref="DictionaryExtensions"/> methods that mutate the dictionary.
/// The working dictionary is restored before each iteration via <see cref="Reset"/>.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
[TailCallDiagnoser]
public class DictionaryExtensionsMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private Dictionary<string, Person> _personRefDictionary = default!;
	private Dictionary<string, Person> _personRefDictionaryToInsert = default!;

	[Benchmark(Description = nameof(DictionaryExtensions.AddRange))]
	public void AddRange()
	{
		var result = this._personRefDictionary.AddRange(this._personRefDictionaryToInsert);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd))]
	[BenchmarkCategory(Categories.Collections)]
	public void GetOrAdd()
	{
		var result = this._personRefDictionary.GetOrAdd(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(result);
	}

	/// <summary>
	/// Resets the working dictionary before each benchmark iteration so that mutations
	/// from the previous invocation do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this._personRefDictionary = this.GetPersonRefDictionary();
	}

	/// <summary>
	/// Initializes all fields. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefDictionary = this.GetPersonRefDictionary();
		this._personRefDictionaryToInsert = this.GetPersonRefCollectionToInsert().ToDictionary(p => p.Id);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
	public void Upsert()
	{
		this._personRefDictionary.Upsert(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(this._personRefDictionary);
	}
}
