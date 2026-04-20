// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-17-2026
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
[ThreadingDiagnoser]
public class ConcurrentHashSetCollectionBenchmark : LargeCollectionBenchmark
{
	private ConcurrentHashSet<Person> _personRefConcurrentHashSet = default!;

	[Benchmark(Description = "Clear")]
	[BenchmarkCategory(Categories.Async)]
	public void Clear()
	{
		var people = this._personRefConcurrentHashSet;

		people.Clear();

		this.Consume(people);
	}

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

	[Benchmark(Description = "Remove")]
	[BenchmarkCategory(Categories.Async)]
	public void Remove()
	{
		var people = this._personRefConcurrentHashSet;

		this.Consume(people.Remove(this.PersonRef01));
	}

	public override void Setup()
	{
		base.Setup();

		// ToUniqueCollection Hash Set
		this._personRefConcurrentHashSet = [.. this.GetPersonRefArray()];

	}

	[Benchmark(Description = "TryRemove")]
	[BenchmarkCategory(Categories.Async)]
	public void TryRemove()
	{
		var people = this._personRefConcurrentHashSet;

		var result = people.TryRemove(this.PersonRef01);

		this.Consume(result);
	}
}
