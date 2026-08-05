// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 08-04-2026
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2026
// ***********************************************************************
// <copyright file="ThreadPoolHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmarks for ThreadPoolHelper methods marked for benchmarking.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Threading;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Threading;

[MemoryDiagnoser]
[ThreadingDiagnoser]
public class ThreadPoolHelperBenchmark : Benchmark
{
	private static readonly Action<CancellationToken> ActionOperation = static _ => { };
	private static readonly Func<CancellationToken, Task<int>> AsyncOperation = static _ => Task.FromResult(42);
	private static readonly IReadOnlyCollection<Func<CancellationToken, int>> MultipleOperations = new Func<CancellationToken, int>[]
	{
		static _ => 1,
		static _ => 2,
		static _ => 3,
	};
	private static readonly IReadOnlyCollection<Func<CancellationToken, int>> ParallelOperations = new Func<CancellationToken, int>[]
	{
		static _ => 1,
		static _ => 2,
		static _ => 3,
		static _ => 4,
	};
	private static readonly IReadOnlyCollection<Func<CancellationToken, int>> RaceOperations = new Func<CancellationToken, int>[]
	{
		static _ => 1,
		static _ => 2,
		static _ => 3,
	};
	private static readonly Func<CancellationToken, int> SyncOperation = static _ => 42;

	[Benchmark(Description = nameof(ThreadPoolHelper.GetStatistics))]
	[BenchmarkCategory(Categories.Threading)]
	public ThreadPoolStatistics GetStatistics()
	{
		return ThreadPoolHelper.GetStatistics();
	}

	[Benchmark(Description = nameof(ThreadPoolHelper.RunAsync) + ": Action")]
	[BenchmarkCategory(Categories.Threading)]
	public async Task RunAsyncAction()
	{
		await ThreadPoolHelper.RunAsync(ActionOperation, 1_000).ConfigureAwait(false);
	}

	[Benchmark(Description = nameof(ThreadPoolHelper.RunAsync) + ": Bounded Parallelism")]
	[BenchmarkCategory(Categories.Threading)]
	public async Task<int[]> RunAsyncBoundedParallelism()
	{
		var result = await ThreadPoolHelper.RunAsync(ParallelOperations, 2, 1_000).ConfigureAwait(false);

		this.Consume(result);

		return result;
	}

	[Benchmark(Description = nameof(ThreadPoolHelper.RunAsync) + ": Func<TResult>")]
	[BenchmarkCategory(Categories.Threading)]
	public async Task<int> RunAsyncFunc()
	{
		var result = await ThreadPoolHelper.RunAsync(SyncOperation, 1_000).ConfigureAwait(false);

		this.Consume(result);

		return result;
	}

	[Benchmark(Description = nameof(ThreadPoolHelper.RunAsync) + ": Multiple Results")]
	[BenchmarkCategory(Categories.Threading)]
	public async Task<int[]> RunAsyncMultiple()
	{
		var result = await ThreadPoolHelper.RunAsync(MultipleOperations, 1_000).ConfigureAwait(false);

		this.Consume(result);

		return result;
	}

	[Benchmark(Description = nameof(ThreadPoolHelper.RunAsync) + ": Func<Task<TResult>>")]
	[BenchmarkCategory(Categories.Threading)]
	public async Task<int> RunAsyncTaskFunc()
	{
		var result = await ThreadPoolHelper.RunAsync(AsyncOperation, 1_000).ConfigureAwait(false);

		this.Consume(result);

		return result;
	}

	[Benchmark(Description = nameof(ThreadPoolHelper.RunWhenAnyAsync))]
	[BenchmarkCategory(Categories.Threading)]
	public async Task<int> RunWhenAnyAsync()
	{
		var result = await ThreadPoolHelper.RunWhenAnyAsync(RaceOperations, 1_000).ConfigureAwait(false);

		this.Consume(result);

		return result;
	}

	[Benchmark(Description = nameof(ThreadPoolHelper.TryRunAsync))]
	[BenchmarkCategory(Categories.Threading)]
	public async Task<SimpleResult<int>> TryRunAsync()
	{
		var result = await ThreadPoolHelper.TryRunAsync(SyncOperation, 1_000).ConfigureAwait(false);

		this.Consume(result);

		return result;
	}
}
