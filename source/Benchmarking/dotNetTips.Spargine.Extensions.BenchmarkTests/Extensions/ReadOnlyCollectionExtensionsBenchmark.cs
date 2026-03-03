// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2026
// ***********************************************************************
// <copyright file="ReadOnlyCollectionExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ReadOnlyCollectionExtensionsBenchmark : LargeCollectionBenchmark
{
	private ReadOnlyCollection<Person> _personRefReadOnlyCollection;

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

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.IsNotEmpty))]
	public void IsNotEmpty()
	{
		this.Consume(this._personRefReadOnlyCollection.IsNotEmpty(x => x != null));
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
