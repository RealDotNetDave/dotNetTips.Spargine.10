// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-10-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="StopwatchScopeBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks for StopwatchScope start/dispose overhead.
// </summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Diagnostics;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Diagnostics;

[MemoryDiagnoser]
public class StopwatchScopeBenchmark : Benchmark
{
	private Action<TimeSpan>? _noopCallback;

	[Benchmark(Description = "StopwatchScope.Start + Dispose")]
	public void CreateAndDispose()
	{
		using var scope = StopwatchScope.Start(this._noopCallback);
		// do minimal work
		var elapsed = scope.Elapsed;
		this.Consume(elapsed);
	}

	public override void Setup()
	{
		base.Setup();

		this._noopCallback = _ => { };
	}
}
