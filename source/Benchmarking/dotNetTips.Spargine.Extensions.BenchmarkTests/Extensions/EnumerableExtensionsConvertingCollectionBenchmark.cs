// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 12-14-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-14-2025
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
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsConvertingCollectionBenchmark : LargeCollectionBenchmark
{
	private IEnumerable<Person> _personRefEnumerable;

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
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

	[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable))]
	public void ToImmutable()
	{
		var result = this._personRefEnumerable.AsEnumerable().ToImmutable();

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
