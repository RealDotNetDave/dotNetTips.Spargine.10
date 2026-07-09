// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="FastStringBuilderSpanBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Micro-benchmarks for the span-aware FastStringBuilder APIs added to improve zero-allocation scenarios.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;

namespace DotNetTips.Spargine.Core.BenchmarkTests;

[BenchmarkCategory(Categories.Strings)]
[MemoryDiagnoser]
public class FastStringBuilderSpanBenchmark : Benchmark
{
	private string[] _words = default!;

	public override void Setup()
	{
		base.Setup();

		// prepare a moderate-sized input representative of real workloads
		this._words = [.. RandomData.GenerateWords(16, 8, 12)];
	}

	[Benchmark(Description = nameof(FastStringBuilder.Combine) + "_Span")]
	public void Combine_Span()
	{
		var result = FastStringBuilder.Combine(false, this._words.AsReadOnlySpan());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.CombineWithSpace) + "_Span")]
	public void CombineWithSpace_Span()
	{
		var result = FastStringBuilder.CombineWithSpace(this._words.AsReadOnlySpan());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.Concat) + "_Span")]
	public void Concat_Span()
	{
		var result = FastStringBuilder.Concat(ControlChars.Comma, false, this._words.AsReadOnlySpan());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.PerformAction) + "_Span")]
	public void PerformAction_Span()
	{
		var result = FastStringBuilder.PerformAction(sb =>
		{
			for (var i = 0; i < this._words.Length; i++)
			{
				_ = sb.Append(this._words[i]);
				if (i < this._words.Length - 1)
				{
					_ = sb.Append(ControlChars.Space);
				}
			}
		});

		this.Consume(result);
	}
}
