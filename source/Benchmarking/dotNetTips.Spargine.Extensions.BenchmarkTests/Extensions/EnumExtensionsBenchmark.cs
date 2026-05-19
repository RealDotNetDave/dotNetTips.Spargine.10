// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="EnumExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for EnumExtensions methods.</summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Reflection)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class EnumExtensionsBenchmark : Benchmark
{

	private readonly StringComparison _testEnum = StringComparison.OrdinalIgnoreCase;

	[Benchmark(Description = nameof(EnumExtensions.GetDescription))]
	public void GetDescription()
	{
		var result = this._testEnum.GetDescription();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumExtensions.GetItems) + " (Enum)")]
	public void GetItems()
	{
		var result = this._testEnum.GetItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumExtensions.GetItems) + " (Generic)")]
	public void GetItemsGeneric()
	{
		var value = StringComparison.OrdinalIgnoreCase;
		var result = value.GetItems();

		this.Consume(result);
	}

}
