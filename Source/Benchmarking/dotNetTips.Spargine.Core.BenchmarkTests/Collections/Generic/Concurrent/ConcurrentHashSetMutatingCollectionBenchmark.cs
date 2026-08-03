// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="ConcurrentHashSetMutatingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark tests for ConcurrentHashSet methods that mutate the collection,
// including Clear, Remove, and TryRemove.
// Uses [IterationSetup] to reset the collection before each iteration.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent;

/// <summary>
/// Class ConcurrentHashSetMutatingCollectionBenchmark.
/// Benchmark tests for <see cref="ConcurrentHashSet{T}"/> methods that mutate the collection.
/// The set is restored before each iteration via <see cref="Reset"/>.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Async)]
[MemoryDiagnoser]
[ThreadingDiagnoser]
public class ConcurrentHashSetMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private ReadOnlyCollection<Person> _newPeople = default!;
	private ConcurrentHashSet<Person> _personRefConcurrentHashSet = default!;

	[Benchmark(Description = nameof(ConcurrentHashSet<Person>.AddRange))]
	[BenchmarkCategory(Categories.Async)]
	public void AddRange()
	{
		this.Consume(this._personRefConcurrentHashSet.AddRange(this._newPeople));
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person>.Clear))]
	[BenchmarkCategory(Categories.Async)]
	public void Clear()
	{
		this._personRefConcurrentHashSet.Clear();

		this.Consume(this._personRefConcurrentHashSet);
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person>.Remove))]
	[BenchmarkCategory(Categories.Async)]
	public void Remove()
	{
		this.Consume(this._personRefConcurrentHashSet.Remove(this.PersonRef01));
	}

	/// <summary>
	/// Resets the hash set before each benchmark iteration so that mutations from the
	/// previous invocation do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this._personRefConcurrentHashSet = [.. this.GetPersonRefArray()];
	}

	/// <summary>
	/// Initializes the collection. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefConcurrentHashSet = [.. this.GetPersonRefArray()];
		this._newPeople = RandomData.GeneratePersonRefCollection(10);
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person>.TryAdd))]
	[BenchmarkCategory(Categories.Async)]
	public void TryAdd()
	{
		foreach (var person in this._newPeople)
		{
			this.Consume(this._personRefConcurrentHashSet.TryAdd(person));
		}
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<Person>.TryRemove))]
	[BenchmarkCategory(Categories.Async)]
	public void TryRemove()
	{
		this.Consume(this._personRefConcurrentHashSet.TryRemove(this.PersonRef01));
	}
}
