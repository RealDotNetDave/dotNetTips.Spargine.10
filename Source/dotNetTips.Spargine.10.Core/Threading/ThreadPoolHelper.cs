// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 08-04-2026
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2026
// ***********************************************************************
// <copyright file="ThreadPoolHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides helper methods for executing single, batch, bounded-concurrency, first-to-complete, and non-throwing operations on the managed thread pool, plus thread pool diagnostics.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Threading;

/// <summary>
/// Provides helper methods for executing work on the managed thread pool, including single and
/// batch operations, bounded-concurrency batches, first-to-complete execution, asynchronous and
/// void-returning operations, non-throwing execution via <see cref="SimpleResult{T}" />, and thread
/// pool diagnostics. All methods enforce a timeout and support cooperative cancellation.
/// </summary>

[Information(description: nameof(ThreadPoolHelper), Status = Status.New)]
public static class ThreadPoolHelper
{
	//TODO: WHEN WRITING DOCUMENTATION, UPDATE ARTICLE: .NET Threads: The Performance Trap Hiding in Your Code

	private const int MaximumTimeoutMilliseconds = 30_000;

	/// <summary>
	/// Gets a point-in-time snapshot of the managed thread pool statistics.
	/// </summary>
	/// <returns>A <see cref="ThreadPoolStatistics" /> value containing the current thread pool metrics.</returns>
	[Information(nameof(GetStatistics), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static ThreadPoolStatistics GetStatistics()
	{
		ThreadPool.GetMinThreads(out var minWorkerThreads, out var minCompletionPortThreads);
		ThreadPool.GetMaxThreads(out var maxWorkerThreads, out var maxCompletionPortThreads);
		ThreadPool.GetAvailableThreads(out var availableWorkerThreads, out var availableCompletionPortThreads);

		return new ThreadPoolStatistics(
			ThreadPool.ThreadCount,
			ThreadPool.PendingWorkItemCount,
			ThreadPool.CompletedWorkItemCount,
			minWorkerThreads,
			maxWorkerThreads,
			availableWorkerThreads,
			minCompletionPortThreads,
			maxCompletionPortThreads,
			availableCompletionPortThreads);
	}

	/// <summary>
	/// Queues an operation to the managed thread pool and waits for the result.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by the operation.</typeparam>
	/// <param name="operation">The operation to execute on the thread pool.</param>
	/// <param name="millisecondsTimeOut">The timeout, in milliseconds, to wait for the operation to complete. Valid values are from 1 to 30,000 inclusive.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation and contains the operation result.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operation" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeOut" /> is less than 1 or greater than 30,000.</exception>
	/// <exception cref="InvalidOperationException">Thrown when the operation cannot be queued to the thread pool.</exception>
	/// <exception cref="OperationCanceledException">Thrown when the <paramref name="cancellationToken" /> is canceled.</exception>
	[Information(nameof(RunAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static async Task<TResult> RunAsync<TResult>([DisallowNull] Func<CancellationToken, TResult> operation, int millisecondsTimeOut, CancellationToken cancellationToken = default)
	{
		operation = operation.ArgumentNotNull();
		millisecondsTimeOut = millisecondsTimeOut.ArgumentInRange(1, MaximumTimeoutMilliseconds);

		cancellationToken.ThrowIfCancellationRequested();

		var operationTask = RunOnThreadPoolAsync(operation, cancellationToken);

		return await operationTask.WaitAsync(TimeSpan.FromMilliseconds(millisecondsTimeOut), cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Queues multiple operations to the managed thread pool and waits for all results.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by each operation.</typeparam>
	/// <param name="operations">The operations to execute on the thread pool.</param>
	/// <param name="millisecondsTimeOut">The timeout, in milliseconds, to wait for the batch to complete. Valid values are from 1 to 30,000 inclusive.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation and contains the results in the same order as <paramref name="operations" />.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operations" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeOut" /> is less than 1 or greater than 30,000.</exception>
	/// <exception cref="InvalidOperationException">Thrown when any operation cannot be queued to the thread pool.</exception>
	/// <exception cref="OperationCanceledException">Thrown when the <paramref name="cancellationToken" /> is canceled.</exception>
	[Information(nameof(RunAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static async Task<TResult[]> RunAsync<TResult>([DisallowNull] IReadOnlyCollection<Func<CancellationToken, TResult>> operations, int millisecondsTimeOut, CancellationToken cancellationToken = default)
	{
		operations = operations.ArgumentNotNull();
		millisecondsTimeOut = millisecondsTimeOut.ArgumentInRange(1, MaximumTimeoutMilliseconds);

		cancellationToken.ThrowIfCancellationRequested();

		if (operations.Count == 0)
		{
			return Array.Empty<TResult>();
		}

		var operationArray = new Func<CancellationToken, TResult>[operations.Count];
		var operationIndex = 0;

		foreach (var operation in operations)
		{
			operationArray[operationIndex] = operation.ArgumentNotNull();
			operationIndex++;
		}

		var tasks = new Task<TResult>[operationArray.Length];

		for (var taskIndex = 0; taskIndex < operationArray.Length; taskIndex++)
		{
			tasks[taskIndex] = RunOnThreadPoolAsync(operationArray[taskIndex], cancellationToken);
		}

		return await Task.WhenAll(tasks).WaitAsync(TimeSpan.FromMilliseconds(millisecondsTimeOut), cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Queues an asynchronous operation to the managed thread pool and waits for the result.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by the operation.</typeparam>
	/// <param name="operation">The asynchronous operation to execute on the thread pool.</param>
	/// <param name="millisecondsTimeOut">The timeout, in milliseconds, to wait for the operation to complete. Valid values are from 1 to 30,000 inclusive.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation and contains the operation result.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operation" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeOut" /> is less than 1 or greater than 30,000.</exception>
	/// <exception cref="InvalidOperationException">Thrown when the operation cannot be queued to the thread pool.</exception>
	/// <exception cref="OperationCanceledException">Thrown when the <paramref name="cancellationToken" /> is canceled.</exception>
	[Information(nameof(RunAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static async Task<TResult> RunAsync<TResult>([DisallowNull] Func<CancellationToken, Task<TResult>> operation, int millisecondsTimeOut, CancellationToken cancellationToken = default)
	{
		operation = operation.ArgumentNotNull();
		millisecondsTimeOut = millisecondsTimeOut.ArgumentInRange(1, MaximumTimeoutMilliseconds);

		cancellationToken.ThrowIfCancellationRequested();

		var operationTask = RunOnThreadPoolAsync(operation, cancellationToken);

		return await operationTask.WaitAsync(TimeSpan.FromMilliseconds(millisecondsTimeOut), cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Queues an operation that returns no result to the managed thread pool and waits for it to complete.
	/// </summary>
	/// <param name="operation">The operation to execute on the thread pool.</param>
	/// <param name="millisecondsTimeOut">The timeout, in milliseconds, to wait for the operation to complete. Valid values are from 1 to 30,000 inclusive.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operation" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeOut" /> is less than 1 or greater than 30,000.</exception>
	/// <exception cref="InvalidOperationException">Thrown when the operation cannot be queued to the thread pool.</exception>
	/// <exception cref="OperationCanceledException">Thrown when the <paramref name="cancellationToken" /> is canceled.</exception>
	[Information(nameof(RunAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static async Task RunAsync([DisallowNull] Action<CancellationToken> operation, int millisecondsTimeOut, CancellationToken cancellationToken = default)
	{
		operation = operation.ArgumentNotNull();
		millisecondsTimeOut = millisecondsTimeOut.ArgumentInRange(1, MaximumTimeoutMilliseconds);

		cancellationToken.ThrowIfCancellationRequested();

		var operationTask = RunOnThreadPoolAsync(token =>
		{
			operation(token);
			return true;
		}, cancellationToken);

		_ = await operationTask.WaitAsync(TimeSpan.FromMilliseconds(millisecondsTimeOut), cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Queues multiple operations to the managed thread pool with a bounded degree of parallelism and waits for all results.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by each operation.</typeparam>
	/// <param name="operations">The operations to execute on the thread pool.</param>
	/// <param name="maxDegreeOfParallelism">The maximum number of operations to run concurrently. Valid values are from 1 to 1,024 inclusive.</param>
	/// <param name="millisecondsTimeOut">The timeout, in milliseconds, to wait for the batch to complete. Valid values are from 1 to 30,000 inclusive.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation and contains the results in the same order as <paramref name="operations" />.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operations" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="maxDegreeOfParallelism" /> or <paramref name="millisecondsTimeOut" /> is out of range.</exception>
	/// <exception cref="InvalidOperationException">Thrown when any operation cannot be queued to the thread pool.</exception>
	/// <exception cref="OperationCanceledException">Thrown when the <paramref name="cancellationToken" /> is canceled.</exception>
	[Information(nameof(RunAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static async Task<TResult[]> RunAsync<TResult>([DisallowNull] IReadOnlyCollection<Func<CancellationToken, TResult>> operations, int maxDegreeOfParallelism, int millisecondsTimeOut, CancellationToken cancellationToken = default)
	{
		operations = operations.ArgumentNotNull();
		maxDegreeOfParallelism = maxDegreeOfParallelism.ArgumentInRange(1, 1_024);
		millisecondsTimeOut = millisecondsTimeOut.ArgumentInRange(1, MaximumTimeoutMilliseconds);

		cancellationToken.ThrowIfCancellationRequested();

		if (operations.Count == 0)
		{
			return Array.Empty<TResult>();
		}

		var operationArray = new Func<CancellationToken, TResult>[operations.Count];
		var operationIndex = 0;

		foreach (var operation in operations)
		{
			operationArray[operationIndex] = operation.ArgumentNotNull();
			operationIndex++;
		}

		var results = new TResult[operationArray.Length];

		using var throttle = new SemaphoreSlim(maxDegreeOfParallelism, maxDegreeOfParallelism);

		var tasks = new Task[operationArray.Length];

		for (var taskIndex = 0; taskIndex < operationArray.Length; taskIndex++)
		{
			var capturedIndex = taskIndex;

			tasks[capturedIndex] = RunThrottledAsync(throttle, operationArray[capturedIndex], results, capturedIndex, cancellationToken);
		}

		await Task.WhenAll(tasks).WaitAsync(TimeSpan.FromMilliseconds(millisecondsTimeOut), cancellationToken).ConfigureAwait(false);

		return results;
	}

	/// <summary>
	/// Queues multiple operations to the managed thread pool and returns the result of the first operation to complete.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by each operation.</typeparam>
	/// <param name="operations">The operations to execute on the thread pool.</param>
	/// <param name="millisecondsTimeOut">The timeout, in milliseconds, to wait for the first operation to complete. Valid values are from 1 to 30,000 inclusive.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the asynchronous operation and contains the result of the first operation to complete.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operations" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeOut" /> is less than 1 or greater than 30,000, or when <paramref name="operations" /> is empty.</exception>
	/// <exception cref="InvalidOperationException">Thrown when any operation cannot be queued to the thread pool.</exception>
	/// <exception cref="OperationCanceledException">Thrown when the <paramref name="cancellationToken" /> is canceled.</exception>
	[Information(nameof(RunWhenAnyAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static async Task<TResult> RunWhenAnyAsync<TResult>([DisallowNull] IReadOnlyCollection<Func<CancellationToken, TResult>> operations, int millisecondsTimeOut, CancellationToken cancellationToken = default)
	{
		operations = operations.ArgumentNotNull();
		_ = operations.Count.ArgumentInRange(1, int.MaxValue);
		millisecondsTimeOut = millisecondsTimeOut.ArgumentInRange(1, MaximumTimeoutMilliseconds);

		cancellationToken.ThrowIfCancellationRequested();

		var tasks = new Task<TResult>[operations.Count];
		var taskIndex = 0;

		foreach (var operation in operations)
		{
			tasks[taskIndex] = RunOnThreadPoolAsync(operation.ArgumentNotNull(), cancellationToken);
			taskIndex++;
		}

		var completedTask = await Task.WhenAny(tasks).WaitAsync(TimeSpan.FromMilliseconds(millisecondsTimeOut), cancellationToken).ConfigureAwait(false);

		return await completedTask.ConfigureAwait(false);
	}

	/// <summary>
	/// Queues an operation to the managed thread pool and captures the outcome in a <see cref="SimpleResult{T}" /> without throwing on failure.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by the operation.</typeparam>
	/// <param name="operation">The operation to execute on the thread pool.</param>
	/// <param name="millisecondsTimeOut">The timeout, in milliseconds, to wait for the operation to complete. Valid values are from 1 to 30,000 inclusive.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that contains a <see cref="SimpleResult{T}" /> describing success (with the value) or failure (with the exception).</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operation" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeOut" /> is less than 1 or greater than 30,000.</exception>
	[Information(nameof(TryRunAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static async Task<SimpleResult<TResult>> TryRunAsync<TResult>([DisallowNull] Func<CancellationToken, TResult> operation, int millisecondsTimeOut, CancellationToken cancellationToken = default)
	{
		operation = operation.ArgumentNotNull();
		millisecondsTimeOut = millisecondsTimeOut.ArgumentInRange(1, MaximumTimeoutMilliseconds);

		try
		{
			var result = await RunAsync(operation, millisecondsTimeOut, cancellationToken).ConfigureAwait(false);

			return result is null
				? new SimpleResult<TResult>(new InvalidOperationException(Resources.ErrorInvalidOperation))
				: new SimpleResult<TResult>(result);
		}
#pragma warning disable CA1031 // Do not catch general exception types
		catch (Exception exception)
		{
			return new SimpleResult<TResult>(exception);
		}
#pragma warning restore CA1031 // Do not catch general exception types
	}

	/// <summary>
	/// Queues an operation to the managed thread pool and returns the task that completes when the operation finishes.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by the operation.</typeparam>
	/// <param name="operation">The operation to execute on the thread pool.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the queued operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operation" /> is <see langword="null" />.</exception>
	/// <exception cref="InvalidOperationException">Thrown when the operation cannot be queued to the thread pool.</exception>
	private static Task<TResult> RunOnThreadPoolAsync<TResult>(Func<CancellationToken, TResult> operation, CancellationToken cancellationToken)
	{
		operation = operation.ArgumentNotNull();

		var completionSource = new TaskCompletionSource<TResult>(
			TaskCreationOptions.RunContinuationsAsynchronously);

		var state = new ThreadPoolOperationState<TResult>(operation, completionSource, cancellationToken);

		if (!ThreadPool.QueueUserWorkItem(
			static operationState =>
			{
				try
				{
					operationState.CancellationToken.ThrowIfCancellationRequested();

					var result = operationState.Operation(
						operationState.CancellationToken);

					_ = operationState.CompletionSource.TrySetResult(result);
				}
				catch (OperationCanceledException exception)
				{
					_ = operationState.CompletionSource.TrySetCanceled(
						exception.CancellationToken);
				}
#pragma warning disable CA1031 // Do not catch general exception types
				catch (Exception exception)
				{
					_ = operationState.CompletionSource.TrySetException(exception);
				}
#pragma warning restore CA1031 // Do not catch general exception types
			},
			state,
			preferLocal: false))
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.TheOperationCouldNotBeQueuedToTheThreadPool);
		}

		return completionSource.Task;
	}

	/// <summary>
	/// Queues an asynchronous operation to the managed thread pool and returns a task that completes when the operation finishes.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by the operation.</typeparam>
	/// <param name="operation">The asynchronous operation to execute on the thread pool.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the queued asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="operation" /> is <see langword="null" />.</exception>
	/// <exception cref="InvalidOperationException">Thrown when the operation cannot be queued to the thread pool.</exception>
	private static Task<TResult> RunOnThreadPoolAsync<TResult>(Func<CancellationToken, Task<TResult>> operation, CancellationToken cancellationToken)
	{
		operation = operation.ArgumentNotNull();

		var completionSource = new TaskCompletionSource<TResult>(
			TaskCreationOptions.RunContinuationsAsynchronously);

		var state = new ThreadPoolAsyncOperationState<TResult>(operation, completionSource, cancellationToken);

		if (!ThreadPool.QueueUserWorkItem(
			static async operationState =>
			{
				try
				{
					operationState.CancellationToken.ThrowIfCancellationRequested();

					var result = await operationState.Operation(
						operationState.CancellationToken).ConfigureAwait(false);

					_ = operationState.CompletionSource.TrySetResult(result);
				}
				catch (OperationCanceledException exception)
				{
					_ = operationState.CompletionSource.TrySetCanceled(
						exception.CancellationToken);
				}
#pragma warning disable CA1031 // Do not catch general exception types
				catch (Exception exception)
				{
					_ = operationState.CompletionSource.TrySetException(exception);
				}
#pragma warning restore CA1031 // Do not catch general exception types
			},
			state,
			preferLocal: false))
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.TheOperationCouldNotBeQueuedToTheThreadPool);
		}

		return completionSource.Task;
	}

	/// <summary>
	/// Executes an operation on the thread pool while honoring the supplied concurrency throttle and stores the result at the given index.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by the operation.</typeparam>
	/// <param name="throttle">The semaphore that bounds the degree of parallelism.</param>
	/// <param name="operation">The operation to execute on the thread pool.</param>
	/// <param name="results">The array that receives the operation result.</param>
	/// <param name="index">The index in <paramref name="results" /> that receives the value.</param>
	/// <param name="cancellationToken">A token that monitors for cancellation requests.</param>
	/// <returns>A task that represents the throttled operation.</returns>
	private static async Task RunThrottledAsync<TResult>(SemaphoreSlim throttle, Func<CancellationToken, TResult> operation, TResult[] results, int index, CancellationToken cancellationToken)
	{
		await throttle.WaitAsync(cancellationToken).ConfigureAwait(false);

		try
		{
			results[index] = await RunOnThreadPoolAsync(operation, cancellationToken).ConfigureAwait(false);
		}
		finally
		{
			_ = throttle.Release();
		}
	}

	/// <summary>
	/// Holds the state required to execute an asynchronous operation on the managed thread pool.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by the operation.</typeparam>
	private readonly record struct ThreadPoolAsyncOperationState<TResult>(Func<CancellationToken, Task<TResult>> Operation, TaskCompletionSource<TResult> CompletionSource, CancellationToken CancellationToken);

	/// <summary>
	/// Holds the state required to execute an operation on the managed thread pool.
	/// </summary>
	/// <typeparam name="TResult">The type of result returned by the operation.</typeparam>
	private readonly record struct ThreadPoolOperationState<TResult>(Func<CancellationToken, TResult> Operation, TaskCompletionSource<TResult> CompletionSource, CancellationToken CancellationToken);
}
