// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmarks for CollectionExtensions covering AsSpan, AsReadOnlySpan, and ToFrozenSet
// across reference, value, and record collection types.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class CollectionExtensionsCollectionBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class CollectionExtensionsCollectionBenchmark : LargeCollectionBenchmark
{
	private Collection<PersonRecord> _peopleRecordCollection = default!;
	private Collection<Person> _peopleRefCollection = default!;
	private Collection<Spargine.Tester.Models.ValueTypes.Person> _peopleValCollection = default!;

	[Benchmark(Description = nameof(CollectionExtensions.AsReadOnlySpan) + ": Record")]
	[BenchmarkCategory(Categories.Span, Categories.RecordType)]
	public void AsReadOnlySpanRecord()
	{
		var result = this._peopleRecordCollection.AsReadOnlySpan();

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsReadOnlySpan) + ": Reference")]
	[BenchmarkCategory(Categories.Span, Categories.ReferenceType)]
	public void AsReadOnlySpanRef()
	{
		var result = this._peopleRefCollection.AsReadOnlySpan();

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsReadOnlySpan) + ": Value")]
	[BenchmarkCategory(Categories.Span, Categories.ValueType)]
	public void AsReadOnlySpanVal()
	{
		var result = this._peopleValCollection.AsReadOnlySpan();

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsSpan) + ": Record")]
	[BenchmarkCategory(Categories.Span, Categories.RecordType)]
	public void AsSpanRecord()
	{
		var result = this._peopleRecordCollection.AsSpan();

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsSpan) + ": Reference")]
	[BenchmarkCategory(Categories.Span, Categories.ReferenceType)]
	public void AsSpanRef()
	{
		var result = this._peopleRefCollection.AsSpan();

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AsSpan) + ": Value")]
	[BenchmarkCategory(Categories.Span, Categories.ValueType)]
	public void AsSpanVal()
	{
		var result = this._peopleValCollection.AsSpan();

		this.Consume(result.Length);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._peopleRefCollection = this.GetPersonRefArray().ToCollection();
		this._peopleValCollection = this.GetPersonValArray().ToCollection();
		this._peopleRecordCollection = this.GetPersonRecordArray().ToCollection();
	}

	[Benchmark(Description = nameof(CollectionExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._peopleRefCollection.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.TryGetFirst))]
	public void TryGetFirst()
	{
		var result = this._peopleRefCollection.TryGetFirst(out var first);

		this.Consume(result);
		this.Consume(first);
	}
}
