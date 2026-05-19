// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-24-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="ExecutionHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

[MemoryDiagnoser]
[ThreadingDiagnoser]
public class ExecutionHelperBenchmark : Benchmark
{

	private static readonly Action _successAction = () => { _ = SimulateWork("test"); };

	private static readonly Action _failThenSucceedAction = CreateFailThenSucceedAction(2);

#pragma warning disable CA1849 // Intentional: benchmark measures retry overhead, not async I/O
	private static readonly Func<Task> _successFunc = static () => { _ = SimulateWork("test"); return Task.CompletedTask; };
#pragma warning restore CA1849

	private static readonly Func<Task> _failThenSucceedFunc = CreateFailThenSucceedFunc(2);

	[Benchmark(Description = nameof(ExecutionHelper.ProgressiveRetryAsync) + ": Success")]
	public async Task ProgressiveRetryAsyncSuccess()
	{
		var result = await ExecutionHelper.ProgressiveRetryAsync(_successFunc, retryCount: 3, retryWaitMilliseconds: 1).ConfigureAwait(false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ExecutionHelper.ProgressiveRetryAsync) + ": With Retries")]
	public async Task ProgressiveRetryAsyncWithRetries()
	{
		var result = await ExecutionHelper.ProgressiveRetryAsync(_failThenSucceedFunc, retryCount: 3, retryWaitMilliseconds: 1).ConfigureAwait(false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ExecutionHelper.ProgressiveRetry) + ": Success")]
	public void ProgressiveRetrySuccess()
	{
		var result = ExecutionHelper.ProgressiveRetry(_successAction, retryCount: 3, retryWaitMilliseconds: 1);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ExecutionHelper.ProgressiveRetry) + ": With Retries")]
	public void ProgressiveRetryWithRetries()
	{
		var result = ExecutionHelper.ProgressiveRetry(_failThenSucceedAction, retryCount: 3, retryWaitMilliseconds: 1);

		this.Consume(result);
	}

	private static Action CreateFailThenSucceedAction(int failCount)
	{
		var callCount = 0;

		return () =>
		{
			if (Interlocked.Increment(ref callCount) % (failCount + 1) != 0)
			{
				throw new InvalidOperationException("Simulated transient failure.");
			}
		};
	}

	private static Func<Task> CreateFailThenSucceedFunc(int failCount)
	{
		var callCount = 0;

		return () =>
		{
			if (Interlocked.Increment(ref callCount) % (failCount + 1) != 0)
			{
				throw new InvalidOperationException("Simulated transient failure.");
			}

			return Task.CompletedTask;
		};
	}
}
