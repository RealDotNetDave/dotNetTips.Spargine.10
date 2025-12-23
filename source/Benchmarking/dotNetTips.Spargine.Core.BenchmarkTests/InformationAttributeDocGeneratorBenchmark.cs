// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-02-2025
//
// Last Modified By : David McCarter
// Last Modified On : 11-10-2025
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
