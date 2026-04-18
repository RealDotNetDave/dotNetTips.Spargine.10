// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 12-14-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsConvertingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsConvertingCollectionBenchmark : LargeCollectionBenchmark
{
	private IEnumerable<Person> _personRefEnumerable = default!;

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().Select(x => x);
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

}
