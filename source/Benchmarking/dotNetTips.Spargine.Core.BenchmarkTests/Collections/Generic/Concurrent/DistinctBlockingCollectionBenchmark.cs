// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-26-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="DistinctBlockingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
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
public class DistinctBlockingCollectionBenchmark : LargeCollectionBenchmark
{
	private DistinctBlockingCollection<Person> _peopleRefDistinctBlockingCollection = default!;
	private Person[] _peopleRefToInsert = default!;

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Clone))]
	[BenchmarkCategory(Categories.Async)]
	public void Clone()
	{
		using (var people = this._peopleRefDistinctBlockingCollection.Clone())
		{
			this.Consume(people);
		}
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.Contains))]
	[BenchmarkCategory(Categories.Async)]
	public void Contains()
	{
		this.Consume(this._peopleRefDistinctBlockingCollection.Contains(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(DistinctBlockingCollection<>.ContainsAny))]
	[BenchmarkCategory(Categories.Async)]
	public void ContainsAny()
	{
		this.Consume(this._peopleRefDistinctBlockingCollection.ContainsAny(this._peopleRefToInsert));
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRefToInsert = this.GetPersonRefCollectionToInsert();
		this._peopleRefDistinctBlockingCollection = new DistinctBlockingCollection<Person>(this.GetPersonRefArray());

	}

}
