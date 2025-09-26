// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 08-29-2024
//
// Last Modified By : David McCarter
// Last Modified On : 10-15-2024
// ***********************************************************************
// <copyright file="UlidBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

public class UlidBenchmark : Benchmark
{

	[Benchmark(Description = nameof(Ulid.NewUlid))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateUlid()
	{
		var result = Ulid.NewUlid;

		this.Consume(result);
	}


	public override void Setup()
	{
		base.Setup();
	}

	[Benchmark(Description = nameof(Ulid.GetHashCode))]
	[BenchmarkCategory(Categories.New)]
	public void UlidGetHashCode()
	{
		var result = Ulid.NewUlid;

		this.Consume(result.GetHashCode());
	}
}
