// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-02-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="PasswordGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

[BenchmarkCategory(Categories.Encryption)]
[EventPipeProfiler(EventPipeProfile.CpuSampling)]
[MemoryDiagnoser]
public class PasswordGeneratorBenchmark : Benchmark
{
	[Benchmark(Description = nameof(PasswordGenerator.GeneratePassword))]
	[BenchmarkCategory(Categories.Encryption)]
	public void GeneratePassword()
	{
		var result = PasswordGenerator.GeneratePassword(12);

		this.Consume(result);
	}
}
