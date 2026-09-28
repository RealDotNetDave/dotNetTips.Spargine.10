// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 09-24-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-24-2026
// ***********************************************************************
// <copyright file="TaskTracker.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Lightweight, thread-safe tracker for fire-and-forget Tasks. Observes task completion,
// supports ULID-based registrations, and forwards exceptions to an optional callback.
// </summary>
// ***********************************************************************
using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Threading;

/// <summary>
/// Default implementation of <see cref="ITaskTracker"/>.
/// Tracks task registrations by key and supports task or key-based unregister operations.
/// </summary>
[Information(nameof(TaskTracker), Status = Status.NeedsDocumentation)]
public sealed class TaskTracker : ITaskTracker
{
	private const int DefaultTimeoutSeconds = 30;
	private readonly ConcurrentDictionary<Ulid, Task> _tasksByKey = new();
	private bool _disposed;

	/// <inheritdoc />
	[Information(nameof(HasPendingTasks), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public bool HasPendingTasks => !this._tasksByKey.IsEmpty;

	/// <inheritdoc />
	[Information(nameof(Dispose), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public void Dispose()
	{
		if (this._disposed)
		{
			return;
		}

		this._disposed = true;
		this._tasksByKey.Clear();
	}

	/// <inheritdoc />
	[Information(nameof(GetPendingCount), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public int GetPendingCount() => this._tasksByKey.Count;

	/// <inheritdoc />
	[SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Callback exceptions must not escape the task continuation.")]
	[Information(nameof(Register), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public Ulid Register([DisallowNull] Task task, Action<Exception>? onException = null)
	{
		task = task.ArgumentNotNull();
		ObjectDisposedException.ThrowIf(this._disposed, this);

		foreach (var taskPair in this._tasksByKey)
		{
			if (ReferenceEquals(taskPair.Value, task))
			{
				return taskPair.Key;
			}
		}

		while (true)
		{
			var key = Ulid.NewUlid();

			if (!this._tasksByKey.TryAdd(key, task))
			{
				continue;
			}

			_ = task.ContinueWith(t =>
			{
				_ = this._tasksByKey.TryRemove(key, out _);

				if (t.IsFaulted && t.Exception is not null)
				{
					try
					{
						onException?.Invoke(t.Exception);
					}
					catch (Exception)
					{
					}
				}
			}, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);

			return key;
		}
	}

	/// <inheritdoc />
	[Information(nameof(Unregister), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public void Unregister([DisallowNull] Task task)
	{
		task = task.ArgumentNotNull();

		foreach (var taskPair in this._tasksByKey)
		{
			if (ReferenceEquals(taskPair.Value, task))
			{
				_ = this._tasksByKey.TryRemove(taskPair.Key, out _);
				break;
			}
		}
	}

	/// <inheritdoc />
	[Information(nameof(Unregister), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public bool Unregister(Ulid key) => this._tasksByKey.TryRemove(key, out _);

	/// <inheritdoc />
	[SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exceptions are forwarded at registration time; swallow here to avoid rethrow during wait.")]
	[Information(nameof(WaitForCompletionAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public async Task<bool> WaitForCompletionAsync(TimeSpan? timeout = null, CancellationToken cancellationToken = default)
	{
		if (this._disposed)
		{
			return true;
		}

		var tasks = this._tasksByKey.Values.ToArray();

		if (tasks.Length == 0)
		{
			return true;
		}

		var whenAll = Task.WhenAll(tasks);
		var effectiveTimeout = timeout ?? TimeSpan.FromSeconds(DefaultTimeoutSeconds);
		var delayTask = Task.Delay(effectiveTimeout, cancellationToken);
		var completed = await Task.WhenAny(whenAll, delayTask).ConfigureAwait(false);

		if (completed == whenAll)
		{
			try
			{
				await whenAll.ConfigureAwait(false);
			}
			catch (Exception)
			{
			}

			return true;
		}

		return false;
	}
}

