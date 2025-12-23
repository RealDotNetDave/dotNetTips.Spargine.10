// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 01-02-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2025
// ***********************************************************************
// <copyright file="PasswordGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

[BenchmarkCategory(Categories.Encryption)]
public class PasswordGeneratorBenchmark : Benchmark
{
	[Benchmark(Description = nameof(PasswordGenerator.GeneratePassword))]
	[BenchmarkCategory(Categories.Encryption, Categories.New)]
	public void GeneratePassword()
	{
		var result = PasswordGenerator.GeneratePassword(12);

		this.Consume(result);
	}
}
