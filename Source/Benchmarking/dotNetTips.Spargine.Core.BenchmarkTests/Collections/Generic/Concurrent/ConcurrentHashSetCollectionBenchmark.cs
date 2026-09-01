// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="ConcurrentHashSetCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent;

[BenchmarkCategory(Categories.Async)]
[MemoryDiagnoser]
[ThreadingDiagnoser]
public class ConcurrentHashSetCollectionBenchmark : LargeCollectionBenchmark
{
	private ConcurrentHashSet<Person> _personRefConcurrentHashSet = default!;

	[Benchmark(Description = "Contains")]
	[BenchmarkCategory(Categories.Async)]
	public void Contains()
	{
		var people = this._personRefConcurrentHashSet;

		var result = people.Contains(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = "CopyTo")]
	[BenchmarkCategory(Categories.Async)]
	public void CopyTo()
	{
		var people = this._personRefConcurrentHashSet;
		var array = new Person[people.Count];

		people.CopyTo(array, 0);

		this.Consume(array);
	}

	[Benchmark(Description = "Count")]
	[BenchmarkCategory(Categories.Async)]
	public void CountPeople()
	{
		var people = this._personRefConcurrentHashSet;

		this.Consume(people.Count);
	}

	[Benchmark(Description = "IsEmpty")]
	[BenchmarkCategory(Categories.Async)]
	public void IsEmpty()
	{
		var people = this._personRefConcurrentHashSet;

		var result = people.IsEmpty;

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		// ToUniqueCollection Hash Set
		this._personRefConcurrentHashSet = [.. this.GetPersonRefArray()];

	}

	[Benchmark(Description = nameof(ConcurrentHashSet<>.ToArray))]
	[BenchmarkCategory(Categories.Async)]
	public void ToArray()
	{
		var people = this._personRefConcurrentHashSet;

		this.Consume(people.ToArray());
	}

	[Benchmark(Description = nameof(ConcurrentHashSet<>.TryPeek))]
	[BenchmarkCategory(Categories.Async)]
	public void TryPeek()
	{
		var people = this._personRefConcurrentHashSet;

		this.Consume(people.TryPeek(this.PersonRef01, out _));
	}

}
