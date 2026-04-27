// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 12-14-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-25-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsConvertingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsConvertingCollectionBenchmark : LargeCollectionBenchmark
{
	private IAsyncEnumerable<Person> _personRefAsyncEnumerable = default!;
	private IEnumerable<Person> _personRefEnumerable = default!;


	[Benchmark(Description = nameof(EnumerableExtensions.PageAsync))]
	public async Task PageAsync()
	{
		await foreach (var page in this._personRefAsyncEnumerable.PageAsync(this.HalfCount).ConfigureAwait(false))
		{
			await this.ConsumeAsync(page).ConfigureAwait(false);
		}
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().Select(x => x);
		this._personRefAsyncEnumerable = ToAsyncEnumerable(this.GetPersonRefArray());
	}


	[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
	public void ToBlockingCollection()
	{
		var result = this._personRefEnumerable.ToBlockingCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToCollection))]
	public void ToCollection()
	{
		var result = this._personRefEnumerable.ToCollection();

		this.Consume(result);
	}


	[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
	public void ToDelimitedString()
	{
		var result = this._personRefEnumerable.ToDelimitedString(',');

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._personRefEnumerable.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToImmutableArray))]
	public void ToImmutableArray()
	{
		var result = this._personRefEnumerable.AsEnumerable().ToImmutableArray();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
	public void ToLinkedList()
	{
		var result = this._personRefEnumerable.ToLinkedList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToListAsync))]
	public async Task ToListAsync()
	{
		var people = this._personRefEnumerable;

		var result = await people.ToListAsync().ConfigureAwait(false);

		await this.ConsumeAsync(result).ConfigureAwait(false);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToReadOnlyCollection))]
	public void ToReadOnlyCollection()
	{
		var result = this._personRefEnumerable.ToReadOnlyCollection();

		this.Consume(result);
	}

	private static async IAsyncEnumerable<T> ToAsyncEnumerable<T>(
		IEnumerable<T> source,
		[EnumeratorCancellation] CancellationToken cancellationToken = default)
	{
		foreach (var item in source)
		{
			cancellationToken.ThrowIfCancellationRequested();
			yield return item;
		}
	}

}
