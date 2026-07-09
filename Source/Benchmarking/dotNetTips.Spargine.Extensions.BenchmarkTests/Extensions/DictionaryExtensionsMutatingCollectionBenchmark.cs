// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
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
[MemoryDiagnoser]
[TailCallDiagnoser]
public class DictionaryExtensionsMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private const string MissingKey = "__missing__";

	private string _existingKey = string.Empty;
	private Dictionary<string, Person> _personRefDictionary = default!;
	private Dictionary<string, Person> _personRefDictionaryToInsert = default!;

	[Benchmark(Description = nameof(DictionaryExtensions.AddRange))]
	public void AddRange()
	{
		var result = this._personRefDictionary.AddRange(this._personRefDictionaryToInsert);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Value")]
	[BenchmarkCategory(Categories.Collections)]
	public void GetOrAdd()
	{
		var result = this._personRefDictionary.GetOrAdd(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Value Factory Existing Key")]
	public void GetOrAddValueFactoryExistingKey()
	{
		var result = this._personRefDictionary.GetOrAdd(this._existingKey, key => this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Value Factory Missing Key")]
	public void GetOrAddValueFactoryMissingKey()
	{
		var result = this._personRefDictionary.GetOrAdd(MissingKey, key => this.PersonRef01);

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
		this._existingKey = this._personRefDictionary.Last().Key;
	}

	/// <summary>
	/// Initializes all fields. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefDictionary = this.GetPersonRefDictionary();
		this._existingKey = this._personRefDictionary.Last().Key;
		this._personRefDictionaryToInsert = this.GetPersonRefCollectionToInsert().ToDictionary(p => p.Id);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.TryRemoveAndReturn) + ": Existing Key")]
	public void TryRemoveAndReturnExistingKey()
	{
		var removed = this._personRefDictionary.TryRemoveAndReturn(this._existingKey, out var removedValue);

		this.Consume(removed);
		this.Consume(removedValue);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.TryRemoveAndReturn) + ": Missing Key")]
	public void TryRemoveAndReturnMissingKey()
	{
		var removed = this._personRefDictionary.TryRemoveAndReturn(MissingKey, out var removedValue);

		this.Consume(removed);
		this.Consume(removedValue);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
	public void Upsert()
	{
		this._personRefDictionary.Upsert(this.PersonRef01.Id, this.PersonRef01);

		this.Consume(this._personRefDictionary);
	}
}
