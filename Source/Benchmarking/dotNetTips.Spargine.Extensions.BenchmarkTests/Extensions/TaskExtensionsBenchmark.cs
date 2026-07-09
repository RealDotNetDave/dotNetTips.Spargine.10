// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="TaskExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for TaskExtensions methods.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="TaskExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.Async)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class TaskExtensionsBenchmark : Benchmark
{
	private static readonly TimeSpan _timeout = TimeSpan.FromSeconds(1);
	private readonly AggregateException _singleAggregateException = new(new InvalidOperationException("single"));
	private readonly Task<int> _valueTask = Task.FromResult(42);

	[Benchmark(Description = nameof(TaskExtensions.IgnoreCancellation))]
	public async Task IgnoreCancellation()
	{
		using var cancellationTokenSource = new CancellationTokenSource();
		await cancellationTokenSource.CancelAsync().ConfigureAwait(false);
		var canceledTask = Task.FromCanceled(cancellationTokenSource.Token);

		await canceledTask.IgnoreCancellation().ConfigureAwait(false);
	}

	[Benchmark(Description = nameof(TaskExtensions.UnwrapAggregate))]
	public void UnwrapAggregate()
	{
		var result = this._singleAggregateException.UnwrapAggregate();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(TaskExtensions.WithTimeoutAsync) + ": Task")]
	public async Task WithTimeoutAsyncTask()
	{
		await Task.CompletedTask.WithTimeoutAsync(_timeout).ConfigureAwait(false);
	}

	[Benchmark(Description = nameof(TaskExtensions.WithTimeoutAsync) + ": Task<T>")]
	public async Task WithTimeoutAsyncTaskOfT()
	{
		var result = await this._valueTask.WithTimeoutAsync(_timeout).ConfigureAwait(false);
		this.Consume(result);
	}
}
