// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-20-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2024
// ***********************************************************************
// <copyright file="TestingBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Testing Benchmark for temporary tests.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
[BenchmarkCategory("Work in Progress")]
public class TestingBenchmark : TinyCollectionBenchmark
{

	//[Benchmark(Description = "FastClone Val")]
	//[BenchmarkCategory(Categories.New)]
	//public void Clone01()
	//{
	//	var result = _peopleVal.FastClone<Tester.Models.ValueTypes.Person[]>();

	//	this.Consume(result);
	//}

	//[Benchmark(Description = "FastClone Ref")]
	//[BenchmarkCategory(Categories.New)]
	//public void Clone02()
	//{
	//	var result = _peopleRef.FastClone<PersonProper[]>();

	//	this.Consume(result);
	//}

	public override void Setup()
	{

	}

}
