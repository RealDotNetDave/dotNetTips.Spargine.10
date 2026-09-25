// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 09-24-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-25-2026
// ***********************************************************************
// <copyright file="TaskTrackerExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension helpers to easily register Tasks with an <see cref="ITaskTracker"/>.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Threading;

/// <summary>
/// Extension methods for registering and fire-and-forget tracking of <see cref="Task"/> instances.
/// </summary>
[Information(nameof(TaskTrackerExtensions), Status = Status.Available)]
public static class TaskTrackerExtensions
{

	/// <summary>
	/// Registers the task and executes it in a fire-and-forget manner. Exceptions are forwarded to the provided callback if supplied.
	/// </summary>
	/// <param name="task">The task to execute fire-and-forget.</param>
	/// <param name="tracker">Optional tracker to register the task with. If null, <see cref="TaskTrackerFacade.Instance"/> is used.</param>
	/// <param name="onException">Optional exception callback.</param>
	/// <returns>The <see cref="Ulid"/> registration key assigned to the task.</returns>
	[Information(nameof(FireAndForgetAndTrack), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static Ulid FireAndForgetAndTrack([DisallowNull] this Task task, ITaskTracker? tracker = null, Action<Exception>? onException = null)
	{
		task = task.ArgumentNotNull();

		var taskTracker = tracker ?? TaskTrackerFacade.Instance;
		var key = taskTracker.Register(task, onException);

		// Ensure exceptions are observed to avoid unobserved task exceptions.
		_ = task.ContinueWith(t => t.Exception, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted | TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);

		return key;
	}
	/// <summary>
	/// Creates and registers a single task for the provided item using a synchronous action.
	/// </summary>
	/// <typeparam name="T">The item type.</typeparam>
	/// <param name="item">The item to process.</param>
	/// <param name="action">The action to execute for the item.</param>
	/// <param name="tracker">Optional tracker to use. If null, <see cref="TaskTrackerFacade.Instance"/> is used.</param>
	/// <param name="onException">Optional exception callback invoked when the registered task faults.</param>
	/// <returns>The registration key for the created task.</returns>
	[Information(nameof(RegisterItemWithTracker), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static Ulid RegisterItemWithTracker<T>(this T item, Action<T> action, ITaskTracker? tracker = null, Action<Exception>? onException = null)
	{
		action = action.ArgumentNotNull();

		var taskTracker = tracker ?? TaskTrackerFacade.Instance;
		var task = Task.Run(() => action(item));

		return taskTracker.Register(task, onException);
	}

	/// <summary>
	/// Creates and registers a single task for the provided item using an asynchronous function.
	/// </summary>
	/// <typeparam name="T">The item type.</typeparam>
	/// <param name="item">The item to process.</param>
	/// <param name="action">The asynchronous function to execute for the item.</param>
	/// <param name="tracker">Optional tracker to use. If null, <see cref="TaskTrackerFacade.Instance"/> is used.</param>
	/// <param name="onException">Optional exception callback invoked when the registered task faults.</param>
	/// <returns>The registration key for the created task.</returns>
	[Information(nameof(RegisterItemWithTrackerAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static Ulid RegisterItemWithTrackerAsync<T>(this T item, Func<T, Task> action, ITaskTracker? tracker = null, Action<Exception>? onException = null)
	{
		action = action.ArgumentNotNull();

		var taskTracker = tracker ?? TaskTrackerFacade.Instance;
		var task = Task.Run(() => action(item));

		return taskTracker.Register(task, onException);
	}

	/// <summary>
	/// Creates and registers one task per item in the provided span using a synchronous action.
	/// </summary>
	/// <typeparam name="T">The item type in the source span.</typeparam>
	/// <param name="items">The source items to process.</param>
	/// <param name="action">The action to execute for each item.</param>
	/// <param name="tracker">Optional tracker to use. If null, <see cref="TaskTrackerFacade.Instance"/> is used.</param>
	/// <param name="onException">Optional exception callback invoked when a registered task faults.</param>
	/// <returns>A read-only collection of registration keys for the created tasks.</returns>
	[Information(nameof(RegisterManyWithTracker), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static ReadOnlyCollection<Ulid> RegisterManyWithTracker<T>(this ReadOnlySpan<T> items, Action<T> action, ITaskTracker? tracker = null, Action<Exception>? onException = null)
	{
		action = action.ArgumentNotNull();

		var taskTracker = tracker ?? TaskTrackerFacade.Instance;
		var keys = new List<Ulid>(items.Length);

		for (var itemIndex = 0; itemIndex < items.Length; itemIndex++)
		{
			var item = items[itemIndex];
			var task = Task.Run(() => action(item));
			keys.Add(taskTracker.Register(task, onException));
		}

		return keys.AsReadOnly();
	}

	/// <summary>
	/// Creates and registers one task per item in the provided span using an asynchronous function.
	/// </summary>
	/// <typeparam name="T">The item type in the source span.</typeparam>
	/// <param name="items">The source items to process.</param>
	/// <param name="action">The asynchronous function to execute for each item.</param>
	/// <param name="tracker">Optional tracker to use. If null, <see cref="TaskTrackerFacade.Instance"/> is used.</param>
	/// <param name="onException">Optional exception callback invoked when a registered task faults.</param>
	/// <returns>A read-only collection of registration keys for the created tasks.</returns>
	[Information(nameof(RegisterManyWithTrackerAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static ReadOnlyCollection<Ulid> RegisterManyWithTrackerAsync<T>(this ReadOnlySpan<T> items, Func<T, Task> action, ITaskTracker? tracker = null, Action<Exception>? onException = null)
	{
		action = action.ArgumentNotNull();

		var taskTracker = tracker ?? TaskTrackerFacade.Instance;
		var keys = new List<Ulid>(items.Length);

		for (var itemIndex = 0; itemIndex < items.Length; itemIndex++)
		{
			var item = items[itemIndex];
			var task = Task.Run(() => action(item));
			keys.Add(taskTracker.Register(task, onException));
		}

		return keys.AsReadOnly();
	}

	/// <summary>
	/// Registers the task with the supplied tracker so it will be observed and tracked until completion.
	/// </summary>
	/// <param name="task">The task to register.</param>
	/// <param name="tracker">Optional tracker to use. If null, <see cref="TaskTrackerFacade.Instance"/> is used.</param>
	/// <param name="onException">Optional exception callback invoked when the task faults.</param>
	/// <returns>The <see cref="Ulid"/> registration key assigned to the task.</returns>
	[Information(nameof(RegisterWithTracker), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static Ulid RegisterWithTracker([DisallowNull] this Task task, ITaskTracker? tracker = null, Action<Exception>? onException = null)
	{
		task = task.ArgumentNotNull();
		var taskTracker = tracker ?? TaskTrackerFacade.Instance;

		return taskTracker.Register(task, onException);
	}
}
