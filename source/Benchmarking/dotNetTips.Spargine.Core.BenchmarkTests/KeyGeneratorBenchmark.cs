// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : david
// Created          : 10-03-2024
//
// Last Modified By : david
// Last Modified On : 10-03-2024
// ***********************************************************************
// <copyright file="KeyGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

public class KeyGeneratorBenchmark : Benchmark
{
	[Benchmark(Description = nameof(KeyGenerator.GenerateKey))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateKey()
	{
		var result = KeyGenerator.GenerateKey();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(KeyGenerator.GenerateKey) + ": With Prefix")]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateKeyPrefix()
	{
		var result = KeyGenerator.GenerateKey("TEST");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(KeyGenerator.GenerateSortableKey))]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateSortableKey()
	{
		var result = KeyGenerator.GenerateSortableKey();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(KeyGenerator.GenerateSortableKey) + ": With Prefix")]
	[BenchmarkCategory(Categories.Strings)]
	public void GenerateSortableKeyWithPrefix()
	{
		var result = KeyGenerator.GenerateSortableKey("TEST");

		this.Consume(result);
	}
}
