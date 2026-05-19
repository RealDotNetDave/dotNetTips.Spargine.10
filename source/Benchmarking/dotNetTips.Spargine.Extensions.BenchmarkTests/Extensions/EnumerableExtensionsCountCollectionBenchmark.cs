// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 12-14-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
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
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[ThreadingDiagnoser]
public class EnumerableExtensionsCountCollectionBenchmark : LargeCollectionBenchmark
{
	private IEnumerable<Person> _personRefEnumerable = default!;
	private List<Person> _personRefList = default!;

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


	[Benchmark(Description = nameof(EnumerableExtensions.FastLongCount))]
	public void CountFastLongCount()
	{
		var result = this._personRefEnumerable.FastLongCount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastLongCount) + ": List")]
	public void CountFastLongCountList()
	{
		var result = this._personRefList.FastLongCount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastLongCount) + ": With Predicate")]
	public void CountFastLongCountWithPredicate()
	{
		var result = this._personRefEnumerable.FastLongCount(p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = "Enumerable.LongCount()")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void CountLongCount()
	{
		var result = this._personRefEnumerable.LongCount();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefList = [.. this.GetPersonRefArray()];
	}

	private static int CountWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate) => list.Count(predicate);


}
