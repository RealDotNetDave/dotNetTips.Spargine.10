// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-10-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="NetworkHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks for NetworkHelper methods marked for benchmarking.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Network;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Network;

[MemoryDiagnoser]
public class NetworkHelperBenchmark : Benchmark
{
	private ReadOnlyCollection<string>? _names;

	[Benchmark(Description = nameof(NetworkHelper.GetActiveNetworkInterfaceNames))]
	public ReadOnlyCollection<string> GetActiveNetworkInterfaceNames()
	{
		return NetworkHelper.GetActiveNetworkInterfaceNames();
	}

	public override void Setup()
	{
		base.Setup();

		// Warm-up: capture current names
		this._names = NetworkHelper.GetActiveNetworkInterfaceNames();
	}
}
