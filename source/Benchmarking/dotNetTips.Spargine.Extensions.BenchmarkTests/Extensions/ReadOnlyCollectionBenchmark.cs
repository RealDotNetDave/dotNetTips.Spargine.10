// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-14-2024
// ***********************************************************************
// <copyright file="ReadOnlyCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
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
public class ReadOnlyCollectionBenchmark : LargeCollectionBenchmark
{

	private ReadOnlyCollection<Person> _personRefReadOnlyCollection;

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.IsEmpty))]
	public void DoesNotHaveItems()
	{
		this.Consume(this._personRefReadOnlyCollection.IsEmpty());
	}

	[Benchmark(Description = nameof(ReadOnlyCollectionExtensions.GenerateHashCode))]
	public void GenerateHashCode()
	{
		this.Consume(this._personRefReadOnlyCollection.GenerateHashCode());
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefReadOnlyCollection = this.GetPersonRefArray().ToReadOnlyCollection();
	}

}
