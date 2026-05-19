// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="ObservableCollectionExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class ObservableCollectionExtensionsCollectionBenchmark : LargeCollectionBenchmark
{

	private ObservableCollection<Person> _personRefObservableCollection = default!;

	[Benchmark(Description = nameof(ObservableCollectionExtensions.IsNotEmpty))]
	[BenchmarkCategory(Categories.Collections)]
	public void IsNotEmpty()
	{
		var result = this._personRefObservableCollection.IsNotEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObservableCollectionExtensions.IsNotEmpty) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void IsNotEmptyWithCount()
	{
		var result = this._personRefObservableCollection.IsNotEmpty(5);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObservableCollectionExtensions.IsNotEmpty) + ": With Predicate")]
	[BenchmarkCategory(Categories.Collections)]
	public void IsNotEmptyWithPredicate()
	{
		var result = this._personRefObservableCollection.IsNotEmpty(p => p.LastName.IsNotEmpty());

		this.Consume(result);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();
		this._personRefObservableCollection = new ObservableCollection<Person>(this.GetPersonRefArray());

	}

}
