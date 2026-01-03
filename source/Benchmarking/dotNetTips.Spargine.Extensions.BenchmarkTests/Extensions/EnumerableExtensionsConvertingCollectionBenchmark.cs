// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 12-14-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsConvertingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsConvertingCollectionBenchmark : LargeCollectionBenchmark
{
	private Person[] _personRefArray;
	private Collection<Person> _personRefCollection;
	private IEnumerable<Person> _personRefEnumerable;
	private ImmutableArray<Person> _personRefImmutableArray;
	private List<Person> _personRefList;

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefList = this.GetPersonRefArray().ToList();
		this._personRefArray = this.GetPersonRefArray().ToArray();
		this._personRefCollection = this.GetPersonRefArray().ToCollection();
		this._personRefImmutableArray = this.GetPersonRefArray().ToImmutableArray();
	}


	[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
	public void ToBlockingCollection()
	{
		var result = this._personRefEnumerable.ToBlockingCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToCollection) + ": Array")]
	public void ToCollectionArray()
	{
		var result = this._personRefArray.ToCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToCollection) + ": Enumerable")]
	public void ToCollectionEnumerable()
	{
		var result = this._personRefEnumerable.ToCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToCollection) + ": ImmutableArray")]
	public void ToCollectionImmutableArray()
	{
		var result = this._personRefImmutableArray.ToCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToCollection) + ": List")]
	public void ToCollectionList()
	{
		var result = this._personRefList.ToCollection();

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

	[Benchmark(Description = nameof(EnumerableExtensions.ToImmutableList))]
	public void ToImmutable()
	{
		var result = this._personRefEnumerable.AsEnumerable().ToImmutableList();

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

	[Benchmark(Description = nameof(EnumerableExtensions.ToReadOnlyCollection) + ": Array")]
	public void ToReadOnlyCollectionArray()
	{
		var result = this._personRefArray.ToReadOnlyCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToReadOnlyCollection) + ": Collection")]
	public void ToReadOnlyCollectionCollection()
	{
		var result = this._personRefCollection.ToReadOnlyCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToReadOnlyCollection) + ": Enumerable")]
	public void ToReadOnlyCollectionEnumerable()
	{
		var result = this._personRefEnumerable.ToReadOnlyCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToReadOnlyCollection) + ": List")]
	public void ToReadOnlyCollectionList()
	{
		var result = this._personRefList.ToReadOnlyCollection();

		this.Consume(result);
	}

}
