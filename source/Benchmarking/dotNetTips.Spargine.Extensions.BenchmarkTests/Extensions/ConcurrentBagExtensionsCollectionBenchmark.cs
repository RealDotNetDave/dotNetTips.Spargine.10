// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 03-15-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="ConcurrentBagExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[ThreadingDiagnoser]
public class ConcurrentBagExtensionsCollectionBenchmark : LargeCollectionBenchmark
{
	private ConcurrentBag<Person> _peopleRefConcurrentBag = default!;
	private IEnumerable<Person> _peopleRefEnumerable = default!;

	[Benchmark(Description = nameof(ConcurrentBagExtensions.AddRange))]
	public void AddRange()
	{
		var bag = new ConcurrentBag<Person>();

		bag.AddRange(this._peopleRefEnumerable);

		this.Consume(bag);
	}

	[Benchmark(Description = nameof(ConcurrentBagExtensions.RemoveRange))]
	public void RemoveRange()
	{
		var bag = new ConcurrentBag<Person>(this._peopleRefEnumerable);

		bag = bag.RemoveRange(this._peopleRefEnumerable);

		this.Consume(bag);
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._peopleRefConcurrentBag = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(ConcurrentBagExtensions.ToList))]
	public void ToList()
	{
		var list = this._peopleRefConcurrentBag.ToList();

		this.Consume(list);
	}
}
