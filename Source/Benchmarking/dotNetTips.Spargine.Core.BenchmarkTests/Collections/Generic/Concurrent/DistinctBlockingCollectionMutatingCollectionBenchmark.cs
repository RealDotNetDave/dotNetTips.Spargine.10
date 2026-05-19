// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="DistinctBlockingCollectionMutatingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmark tests for DistinctBlockingCollection methods that mutate the collection,
// including Add, AddRange, Clear, Remove, TryAdd, TryAddRange, and TryAdd overloads.
// Uses [IterationSetup] to reset and [IterationCleanup] to dispose before/after each iteration.
// </summary>
// ***********************************************************************

using System;
using System.Threading;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent;

/// <summary>
/// Class DistinctBlockingCollectionMutatingCollectionBenchmark.
/// Benchmark tests for <see cref="DistinctBlockingCollection{T}"/> methods that mutate the
/// collection. A fresh instance is created before each iteration via <see cref="Reset"/> and
/// disposed after each iteration via <see cref="Cleanup"/>.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Async)]
[MemoryDiagnoser]
[ThreadingDiagnoser]
public class DistinctBlockingCollectionMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private DistinctBlockingCollection<Person> _people = default!;
	private Person[] _peopleRefToInsert = default!;

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Add))]
	[BenchmarkCategory(Categories.Async)]
	public void Add()
	{
		this._people.Add(this.PersonRef01);
		this._people.Add(this.PersonRef02);

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.AddRange))]
	[BenchmarkCategory(Categories.Async)]
	public void AddRange()
	{
		this.Consume(this._people.AddRange(this._peopleRefToInsert));
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Clear))]
	[BenchmarkCategory(Categories.Async)]
	public void Clear()
	{
		this._people.Clear();

		this.Consume(this._people);
	}

	/// <summary>
	/// Disposes the working collection after each benchmark iteration.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		this._people?.Dispose();
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Remove))]
	[BenchmarkCategory(Categories.Async)]
	public void Remove()
	{
		this.Consume(this._people.Remove(this.PersonRefLookupLast));
	}

	/// <summary>
	/// Creates a fresh working collection before each benchmark iteration so that mutations
	/// from the previous invocation do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this._people = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());
	}

	/// <summary>
	/// Initializes the insert collection. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._peopleRefToInsert = this.GetPersonRefCollectionToInsert();
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAdd))]
	[BenchmarkCategory(Categories.Async)]
	public void TryAdd()
	{
		this.Consume(this._people.TryAdd(this.PersonRef01));
		this.Consume(this._people.TryAdd(this.PersonRef02));

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAddRange))]
	[BenchmarkCategory(Categories.Async)]
	public void TryAddRange()
	{
		this.Consume(this._people.TryAddRange(this._peopleRefToInsert));
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAdd) + ": with Timeout")]
	[BenchmarkCategory(Categories.Async)]
	public void TryAddWithTimeout()
	{
		this.Consume(this._people.TryAdd(this.PersonRef01, 20));
		this.Consume(this._people.TryAdd(this.PersonRef02, 10));

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAdd) + ": with Timeout & CancellationToken")]
	[BenchmarkCategory(Categories.Async)]
	public void TryAddWithTimeoutAndCancellationToken()
	{
		this.Consume(this._people.TryAdd(this.PersonRef01, 20, CancellationToken.None));
		this.Consume(this._people.TryAdd(this.PersonRef02, 10, CancellationToken.None));

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.TryAdd) + ": with Timespan")]
	[BenchmarkCategory(Categories.Async)]
	public void TryAddWithTimespan()
	{
		this.Consume(this._people.TryAdd(this.PersonRef01, TimeSpan.FromMilliseconds(20)));
		this.Consume(this._people.TryAdd(this.PersonRef02, TimeSpan.FromMilliseconds(10)));

		this.Consume(this._people);
	}
}
