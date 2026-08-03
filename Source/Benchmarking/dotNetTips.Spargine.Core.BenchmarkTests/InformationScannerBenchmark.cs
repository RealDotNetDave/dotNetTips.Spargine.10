// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 08-03-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="InformationScannerBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks for InformationScanner methods.
// </summary>
// ***********************************************************************

using System.Reflection;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

[MemoryDiagnoser]
public class InformationScannerBenchmark : Benchmark
{
	private Assembly _assembly = default!;

	[Benchmark(Description = nameof(InformationScanner.GetInformationMetadata))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetInformationMetadata()
	{
		var result = InformationScanner.GetInformationMetadata(this._assembly).ToList();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._assembly = typeof(App).Assembly;
	}
}
