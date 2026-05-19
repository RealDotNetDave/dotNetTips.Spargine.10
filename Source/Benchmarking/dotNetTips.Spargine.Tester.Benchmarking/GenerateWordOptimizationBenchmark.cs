using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Engines;
using DotNetTips.Spargine.Benchmarking;
using Microsoft.VSDiagnostics;

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

[BenchmarkCategory(Categories.Strings)]
[CPUUsageDiagnoser]
[MemoryDiagnoser]
[SimpleJob(launchCount: 1, warmupCount: 1, iterationCount: 5)]
[TailCallDiagnoser]
public class GenerateWordOptimizationBenchmark : Benchmark
{
	private readonly Consumer _consumer = new();

	[Params(10, 100)]
	public int Length { get; set; }

	[Benchmark(Baseline = true, Description = nameof(RandomData.GenerateWord) + ": MIN AND MAX CHAR (baseline)")]
	public void GenerateWordMinMaxChar()
	{
		var result = RandomData.GenerateWord(this.Length, 'a', 'z');
		this._consumer.Consume(result);
	}
}
