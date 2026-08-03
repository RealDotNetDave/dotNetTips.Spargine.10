// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 08-03-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="ReadOnlyMemoryExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks for ReadOnlyMemoryExtensions methods.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class ReadOnlyMemoryExtensionsBenchmark : Benchmark
{
	private ReadOnlyMemory<byte> _memory;
	private ReadOnlyMemory<byte> _otherMemory;

	[Benchmark(Description = nameof(ReadOnlyMemoryExtensions.IsEqualTo))]
	public void IsEqualTo()
	{
		var result = this._memory.IsEqualTo(this._otherMemory);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ReadOnlyMemoryExtensions.IsNotEmpty))]
	public void IsNotEmpty()
	{
		var result = this._memory.IsNotEmpty();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		var data = this.GetByteArray(10);
		this._memory = data.AsMemory();
		this._otherMemory = data.AsMemory();
	}

	[Benchmark(Description = nameof(ReadOnlyMemoryExtensions.ToArrayIfNeeded))]
	public void ToArrayIfNeeded()
	{
		var result = this._memory.ToArrayIfNeeded();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ReadOnlyMemoryExtensions.TryGetArraySegment))]
	public void TryGetArraySegment()
	{
		var result = this._memory.TryGetArraySegment(out var segment);
		this.Consume(segment);
		this.Consume(result);
	}
}
