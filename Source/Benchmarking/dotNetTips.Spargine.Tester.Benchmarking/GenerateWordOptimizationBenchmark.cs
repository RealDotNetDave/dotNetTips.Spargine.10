// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 04-21-2026
//
// Last Modified By : David McCarter
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="GenerateWordOptimizationBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Engines;
using DotNetTips.Spargine.Benchmarking;
using Microsoft.VSDiagnostics;

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

[BenchmarkCategory(Categories.Strings)]
[CPUUsageDiagnoser]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class GenerateWordOptimizationBenchmark : Benchmark
{
	private readonly Consumer _consumer = new();

	[Params(10, 100)]
	public int Length { get; set; }

	[Benchmark(Baseline = true, Description = nameof(RandomData.GenerateWord) + ": MIN AND MAX CHAR (baseline)")]
	public void GenerateWordMinMaxChar()
	{
		var result = RandomData.GenerateWord(this.Length, 'a', 'z');
		this._consumer.Consume(result);
	}
}
