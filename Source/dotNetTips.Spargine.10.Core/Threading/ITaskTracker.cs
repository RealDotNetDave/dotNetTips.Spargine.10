// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 09-24-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-24-2026
// ***********************************************************************
// <copyright file="ITaskTracker.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Interface for a lightweight fire-and-forget task tracker that allows registration,
// querying, and waiting for outstanding tasks, with optional exception forwarding.
// </summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Threading;

/// <summary>
/// Tracks fire-and-forget tasks so callers can query pending work and wait for completion.
/// Implementations observe task completions and may forward exceptions via a callback supplied at registration.
/// </summary>
[Information(nameof(ITaskTracker), Status = Status.NeedsDocumentation)]
public interface ITaskTracker : IDisposable
{

	/// <summary>
	/// Returns <c>true</c> when there are any pending tracked tasks.
	/// </summary>
	[Information(nameof(HasPendingTasks), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public bool HasPendingTasks { get; }

	/// <summary>
	/// Gets the current count of tracked, not-yet-completed tasks. This is a point-in-time snapshot.
	/// </summary>
	/// <returns>The number of pending tracked tasks.</returns>
	[Information(nameof(GetPendingCount), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public int GetPendingCount();

	/// <summary>
	/// Registers a task for tracking and returns a unique registration key.
	/// The tracker will remove the task when it completes.
	/// If <paramref name="onException"/> is provided it will be invoked when the task faults.
	/// </summary>
	/// <param name="task">The <see cref="Task"/> to track. Cannot be null.</param>
	/// <param name="onException">Optional callback to receive exceptions from a faulted task.</param>
	/// <returns>A unique <see cref="Ulid"/> key representing this registration.</returns>
	[Information(nameof(Register), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public Ulid Register([DisallowNull] Task task, Action<Exception>? onException = null);

	/// <summary>
	/// Unregisters a previously registered task. Safe to call if the task is not tracked.
	/// </summary>
	/// <param name="task">The <see cref="Task"/> to remove from tracking. Cannot be null.</param>
	[Information(nameof(Unregister), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public void Unregister([DisallowNull] Task task);

	/// <summary>
	/// Unregisters a previously registered task using its unique registration key.
	/// </summary>
	/// <param name="key">The registration key returned by <see cref="Register(Task, Action{Exception}?)"/>.</param>
	/// <returns><see langword="true"/> if a tracked task was removed; otherwise, <see langword="false"/>.</returns>
	[Information(nameof(Unregister), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public bool Unregister(Ulid key);

	/// <summary>
	/// Waits asynchronously for all currently tracked tasks to complete or the timeout to elapse.
	/// </summary>
	/// <param name="timeout">The timeout to wait for; if null the implementation default is used.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the wait.</param>
	/// <returns>True if all tracked tasks completed before the timeout; otherwise false.</returns>
	[Information(nameof(WaitForCompletionAsync), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public Task<bool> WaitForCompletionAsync(TimeSpan? timeout = null, CancellationToken cancellationToken = default);
}
