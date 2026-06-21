// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="ReadOnlyCollectionExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class ReadOnlyCollectionExtensionsBenchmark : LargeCollectionBenchmark
{
	private ReadOnlyCollection<Person> _personRefReadOnlyCollection = default!;

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.GenerateHashCode))]
	public void GenerateHashCode()
	{
		this.Consume(this._personRefReadOnlyCollection.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.GetValueOrDefault))]
	public void GetValueOrDefault()
	{
		this.Consume(this._personRefReadOnlyCollection.GetValueOrDefault(this.HalfCount, this.PersonRef01));
	}

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.IsNotEmpty) + ": Found")]
	public void IsNotEmptyFound()
	{
		this.Consume(this._personRefReadOnlyCollection.IsNotEmpty(x => x.Id == this.PersonRef01.Id));
	}

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.IsNotEmpty) + ": NotFound")]
	public void IsNotEmptyNotFound()
	{
		this.Consume(this._personRefReadOnlyCollection.IsNotEmpty(_ => false));
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefReadOnlyCollection = this.GetPersonRefArray().ToReadOnlyCollection();
	}

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.TryGetValue))]
	public void TryGetValue()
	{
		this.Consume(this._personRefReadOnlyCollection.TryGetValue(this.HalfCount, out var value));
		this.Consume(value);
	}

}
