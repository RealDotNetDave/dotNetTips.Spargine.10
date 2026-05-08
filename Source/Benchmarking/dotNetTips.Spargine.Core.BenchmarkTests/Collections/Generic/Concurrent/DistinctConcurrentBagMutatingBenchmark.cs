// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="DistinctConcurrentBagMutatingBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmark tests for DistinctConcurrentBag methods that mutate the collection,
// including Add, AddRange, Clear, Remove, RemoveRange, TryAdd, TryGetValue, TryPeek,
// and TryTake. Uses [IterationSetup] to reset the working collection before each iteration.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent;

/// <summary>
/// Class DistinctConcurrentBagMutatingBenchmark.
/// Benchmark tests for <see cref="DistinctConcurrentBag{T}"/> methods that mutate the collection.
/// A fresh instance is created before each iteration via <see cref="Reset"/>, eliminating the
/// per-benchmark <c>new DistinctConcurrentBag&lt;&gt;</c> allocations from the original class.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Async)]
[ThreadingDiagnoser]
public class DistinctConcurrentBagMutatingBenchmark : LargeCollectionBenchmark
{
	private DistinctConcurrentBag<Person> _people = default!;
	private Person[] _peopleRefToInsert = default!;

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.Add))]
	[BenchmarkCategory(Categories.Async)]
	public void Add()
	{
		this._people.Add(this.PersonRef01);
		this._people.Add(this.PersonRef02);

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.AddRange))]
	[BenchmarkCategory(Categories.Async)]
	public void AddRange()
	{
		this.Consume(this._people.AddRange(this._peopleRefToInsert));
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.Clear))]
	[BenchmarkCategory(Categories.Async)]
	public void Clear()
	{
		this._people.Clear();

		this.Consume(this._people);
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.Remove))]
	[BenchmarkCategory(Categories.Async)]
	public void Remove()
	{
		this.Consume(this._people.Remove(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.RemoveRange))]
	[BenchmarkCategory(Categories.Async)]
	public void RemoveRange()
	{
		this.Consume(this._people.RemoveRange(this._peopleRefToInsert));
	}

	/// <summary>
	/// Resets the working collection before each benchmark iteration so that mutations
	/// from the previous invocation do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this._people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());
	}

	/// <summary>
	/// Initializes the insert collection. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._peopleRefToInsert = this.GetPersonRefCollectionToInsert();
		this._people = new DistinctConcurrentBag<Person>(this.GetPersonRefArray());
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.TryAdd))]
	[BenchmarkCategory(Categories.Async)]
	public void TryAdd()
	{
		this.Consume(this._people.TryAdd(this.PersonRef01));
		this.Consume(this._people.TryAdd(this.PersonRef02));
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.TryGetValue))]
	[BenchmarkCategory(Categories.Async)]
	public void TryGetValue()
	{
		this.Consume(this._people.TryGetValue(this.PersonRef01, out var person));

		this.Consume(person);
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.TryPeek))]
	[BenchmarkCategory(Categories.Async)]
	public void TryPeek()
	{
		this.Consume(this._people.TryPeek(this.PersonRefLookupLast, out var person));

		this.Consume(person);
	}

	[Benchmark(Description = nameof(DistinctConcurrentBag<>.TryTake))]
	[BenchmarkCategory(Categories.Async)]
	public void TryTake()
	{
		this.Consume(this._people.TryTake(out var person));

		this.Consume(person);
	}
}
