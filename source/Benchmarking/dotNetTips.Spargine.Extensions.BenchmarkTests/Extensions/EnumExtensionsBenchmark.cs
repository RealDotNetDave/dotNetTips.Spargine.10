// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="EnumExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class EnumExtensionsBenchmark : Benchmark
{

	private readonly StringComparison _testEnum = StringComparison.OrdinalIgnoreCase;

	[Benchmark(Description = nameof(EnumExtensions.GetDescription))]
	public void GetDescription()
	{
		var result = this._testEnum.GetDescription();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumExtensions.GetItems))]
	public void GetItems()
	{
		var result = this._testEnum.GetItems();

		this.Consume(result);
	}

}
