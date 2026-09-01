// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-25-2019
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="TaskExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for Task that support fire-and-forget patterns with optional exception handling.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Task"/> that support fire-and-forget patterns
/// with optional exception handling.
/// </summary>
/// <remarks>
/// The <see cref="TaskExtensions"/> class includes methods for running tasks in the background
/// without awaiting completion. Exceptions can be observed via a callback or silently captured
/// to prevent unobserved task exceptions.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class TaskExtensions
{

	/// <summary>
	/// Executes the specified <see cref="Task"/> as a fire-and-forget operation without awaiting completion.
	/// If the task throws an exception, it is captured to prevent unobserved task exceptions.
	/// Validates that <paramref name="task"/> is not null.
	/// </summary>
	/// <param name="task">The <see cref="Task"/> to execute. Cannot be null.</param>
	/// <example>
	/// // Example of calling a fire-and-forget task
	/// PerformLongRunningWorkAsync().FireAndForget();
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void FireAndForget([DisallowNull] this Task task)
	{
		_ = task.ArgumentNotNull().ContinueWith(tsk => tsk.Exception, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
	}

	/// <summary>
	/// Executes the specified <see cref="Task"/> as a fire-and-forget operation, invoking
	/// <paramref name="action"/> with the exception if the task faults.
	/// Validates that <paramref name="task"/> and <paramref name="action"/> are not null.
	/// </summary>
	/// <param name="task">The <see cref="Task"/> to execute. Cannot be null.</param>
	/// <param name="action">The <see cref="Action{T}"/> to invoke if an exception occurs. Cannot be null.</param>
	/// <example>
	/// Action&lt;Exception&gt; exAction = (Exception ex) =&gt; Debug.WriteLine(ex.Message);
	/// SomeType.FireAsync("Test Message").FireAndForget(exAction);
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void FireAndForget([DisallowNull] this Task task, [DisallowNull] Action<Exception> action)
	{
		task = task.ArgumentNotNull();
		action = action.ArgumentNotNull();

		_ = task.ContinueWith(
			tsk => action(tsk.Exception!),
			CancellationToken.None,
			TaskContinuationOptions.OnlyOnFaulted,
			TaskScheduler.Default);
	}

	/// <summary>
	/// Observes the task and suppresses cancellation exceptions while allowing other exceptions to propagate.
	/// </summary>
	/// <param name="task">The task to observe.</param>
	/// <returns>A task that completes when the source task completes or is canceled.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="task"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IgnoreCancellation), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static async Task IgnoreCancellation([DisallowNull] this Task task)
	{
		task = task.ArgumentNotNull();

		try
		{
			await task.ConfigureAwait(false);
		}
		catch (OperationCanceledException)
		{
		}
	}

	/// <summary>
	/// Returns the innermost single exception when the source is an <see cref="AggregateException"/>; otherwise returns the original exception.
	/// </summary>
	/// <param name="exception">The exception to unwrap.</param>
	/// <returns>The unwrapped exception when possible; otherwise the original exception.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="exception"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(UnwrapAggregate), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static Exception UnwrapAggregate([DisallowNull] this Exception exception)
	{
		exception = exception.ArgumentNotNull();

		if (exception is not AggregateException aggregateException)
		{
			return exception;
		}

		var flattenedException = aggregateException.Flatten();

		return flattenedException.InnerExceptions.Count == 1 && flattenedException.InnerException is not null
			? flattenedException.InnerException
			: flattenedException;
	}

	/// <summary>
	/// Awaits completion of the task within the specified timeout.
	/// </summary>
	/// <param name="task">The task to wait for.</param>
	/// <param name="timeout">The timeout interval.</param>
	/// <param name="cancellationToken">A cancellation token used to cancel the wait.</param>
	/// <returns>A task that completes when the source task completes within the timeout.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="task"/> is null.</exception>
	/// <exception cref="TimeoutException">Thrown when the task does not complete within <paramref name="timeout"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(WithTimeoutAsync), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static Task WithTimeoutAsync([DisallowNull] this Task task, TimeSpan timeout, CancellationToken cancellationToken = default)
	{
		task = task.ArgumentNotNull();

		return task.WaitAsync(timeout, cancellationToken);
	}

	/// <summary>
	/// Awaits completion of the task result within the specified timeout.
	/// </summary>
	/// <typeparam name="T">The result type.</typeparam>
	/// <param name="task">The task to wait for.</param>
	/// <param name="timeout">The timeout interval.</param>
	/// <param name="cancellationToken">A cancellation token used to cancel the wait.</param>
	/// <returns>A task that returns the source result when completed within the timeout.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="task"/> is null.</exception>
	/// <exception cref="TimeoutException">Thrown when the task does not complete within <paramref name="timeout"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(WithTimeoutAsync), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static Task<T> WithTimeoutAsync<T>([DisallowNull] this Task<T> task, TimeSpan timeout, CancellationToken cancellationToken = default)
	{
		task = task.ArgumentNotNull();

		return task.WaitAsync(timeout, cancellationToken);
	}

}

