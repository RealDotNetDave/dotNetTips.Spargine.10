// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 08-29-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="UlidBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

[MemoryDiagnoser]
public class UlidBenchmark : Benchmark
{

	[Benchmark(Description = nameof(Ulid.GetTimeStamp))]
	public void GetTimeStamp()
	{
		// Arrange
		var ulid = Ulid.NewUlid();

		// Act
		var result = ulid.GetTimeStamp();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(Ulid.NewUlid))]
	public void NewUlid()
	{
		var result = Ulid.NewUlid;

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();
	}

	[Benchmark(Description = nameof(Ulid.GetHashCode))]
	public void UlidGetHashCode()
	{
		var result = Ulid.NewUlid;

		this.Consume(result.GetHashCode());
	}
}
