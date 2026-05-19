// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-02-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="InformationAttributeDocGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Reflection;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

[MemoryDiagnoser]
public class InformationAttributeDocGeneratorBenchmark : Benchmark
{
	[Benchmark(Description = nameof(InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly))]
	public void GenerateMarkdownDocumentForAssembly()
	{
		var assembly = Assembly.Load("DotNetTips.Spargine.10.Benchmarking");
		var result = InformationAttributeDocGenerator.GenerateMarkdownDocumentForAssembly(assembly);

		this.Consume(result);
	}
}
