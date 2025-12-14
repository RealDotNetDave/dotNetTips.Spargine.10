// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 12-14-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-14-2025
// ***********************************************************************
// <copyright file="EnumerableExtensionsCountCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsCountCollectionBenchmark : LargeCollectionBenchmark
{
	private IEnumerable<Person> _personRefEnumerable;
	private List<Person> _personRefList;

	private static int CountWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate) => list.Count(predicate);

	[Benchmark(Description = nameof(EnumerableExtensions.CountAsync))]
	public async Task CountCountAsync()
	{
		var result = await this._personRefEnumerable.CountAsync(CancellationToken.None).ConfigureAwait(false);

		this.Consume(result);
	}

	[Benchmark(Description = "IEnumerable.Count(): With Predicate")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void CountCountWithPredicate()
	{
		var result = CountWithPredicate(this._personRefEnumerable, p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = "Enumerable.Count()")]
	public void CountEnumerableExtensionsCount()
	{
		var result = this._personRefEnumerable.Count();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastLongCount) + ": IList ")]
	public void CountFastCountIList()
	{
		var result = this._personRefList.FastCount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastLongCount) + ": With Predicate")]
	public void CountFastCountWithPredicate()
	{
		var result = this._personRefEnumerable.FastLongCount(p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastLongCount))]
	public void CountingFastCount()
	{
		var result = this._personRefEnumerable.FastLongCount();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefList = [.. this.GetPersonRefArray()];
	}


}
