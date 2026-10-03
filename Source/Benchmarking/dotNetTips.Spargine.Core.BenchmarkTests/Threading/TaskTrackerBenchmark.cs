// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 10-03-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 10-03-2026
// ***********************************************************************
// <copyright file="TaskTrackerBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks TaskTracker registration, task and ULID removal, and completion waits
// with fresh pending tasks, single-invocation iteration lifecycles, and safe disposal.
// </summary>
// ***********************************************************************
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Threading;

namespace DotNetTips.Spargine.Core.BenchmarkTests.Threading;

/// <summary>
/// Measures <see cref="TaskTracker"/> operations without reusing mutated registrations.
/// </summary>
/// <remarks>
/// Each iteration measures one invocation with an unroll factor of one. Task sources use
/// synchronous continuations so completion is deterministic and cleanup releases tracker
/// continuations before disposal. The completion wait includes signaling the pending task,
/// but excludes task creation, registration, timers, sleeps, and thread-pool scheduling.
/// The class is unsealed because BenchmarkDotNet generates a derived workload runner.
/// </remarks>
[BenchmarkCategory(Categories.Threading)]
[InvocationCount(1, unrollFactor: 1)]
[MemoryDiagnoser]
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "BenchmarkDotNet iteration cleanup and the inherited global cleanup hook dispose both trackers after completing pending tasks.")]
public class TaskTrackerBenchmark : Benchmark
{
	/// <summary>
	/// Registration key for the pending task fixture.
	/// </summary>
	private Ulid _key;

	/// <summary>
	/// Fresh task source shared by the registration and pending-task fixtures.
	/// </summary>
	private TaskCompletionSource _pendingSource;

	/// <summary>
	/// Empty tracker used for new registrations and the empty completion wait.
	/// </summary>
	private TaskTracker _registrationTracker;

	/// <summary>
	/// Tracker containing one pending registration before each measured invocation.
	/// </summary>
	private TaskTracker _tracker;

	/// <summary>
	/// Initializes a new instance of the <see cref="TaskTrackerBenchmark"/> class.
	/// </summary>
	public TaskTrackerBenchmark()
	{
		this._pendingSource = new TaskCompletionSource();
		this._registrationTracker = new TaskTracker();
		this._tracker = new TaskTracker();
	}

	/// <summary>
	/// Completes any remaining pending task and releases both trackers after the job.
	/// </summary>
	public override void Cleanup()
	{
		this.CleanupIteration();
		base.Cleanup();
	}

	/// <summary>
	/// Completes the task source before disposing trackers to release retained continuations.
	/// </summary>
	[IterationCleanup]
	public void CleanupIteration()
	{
		_ = this._pendingSource.TrySetResult();
		this._registrationTracker.Dispose();
		this._tracker.Dispose();
	}

	/// <summary>
	/// Measures the explicitly labeled duplicate-registration path for a pending task.
	/// </summary>
	/// <returns>The existing registration key.</returns>
	[Benchmark(Description = "Register: duplicate pending task")]
	public Ulid RegisterDuplicatePending()
	{
		return this._tracker.Register(this._pendingSource.Task);
	}

	/// <summary>
	/// Measures registration of a fresh pending task without an exception callback.
	/// </summary>
	/// <returns>The new registration key.</returns>
	[Benchmark(Description = "Register: fresh pending task")]
	public Ulid RegisterPending()
	{
		return this._registrationTracker.Register(this._pendingSource.Task);
	}

	/// <summary>
	/// Measures registration of a fresh pending task with a cached exception callback.
	/// </summary>
	/// <returns>The new registration key.</returns>
	/// <remarks>The task succeeds during cleanup; exception forwarding is not measured.</remarks>
	[Benchmark(Description = "Register: fresh pending task with callback")]
	public Ulid RegisterPendingWithCallback()
	{
		return this._registrationTracker.Register(this._pendingSource.Task, static exception => GC.KeepAlive(exception));
	}

	/// <summary>
	/// Restores fresh pending task fixtures outside the measured workload.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this.CleanupIteration();
		this._pendingSource = new TaskCompletionSource();
		this._registrationTracker = new TaskTracker();
		this._tracker = new TaskTracker();
		this._key = this._tracker.Register(this._pendingSource.Task);
	}

	/// <summary>
	/// Initializes the Spargine base fixtures and initial pending task registration.
	/// </summary>
	public override void Setup()
	{
		base.Setup();
		this.Reset();
	}

	/// <summary>
	/// Measures successful removal of a pending task by its registration key.
	/// </summary>
	/// <returns><see langword="true"/> when the registration was removed.</returns>
	[Benchmark(Description = "Unregister(Ulid): existing pending task")]
	public bool UnregisterByKey()
	{
		return this._tracker.Unregister(this._key);
	}

	/// <summary>
	/// Measures removal of a registered pending task by task reference.
	/// </summary>
	[Benchmark(Description = "Unregister(Task): existing pending task")]
	public void UnregisterByTask()
	{
		this._tracker.Unregister(this._pendingSource.Task);
	}

	/// <summary>
	/// Measures completion waiting when no tasks are registered.
	/// </summary>
	/// <returns><see langword="true"/> when the empty tracker completes immediately.</returns>
	[Benchmark(Description = "WaitForCompletionAsync: empty tracker")]
	public async Task<bool> WaitEmptyAsync()
	{
		return await this._registrationTracker.WaitForCompletionAsync(Timeout.InfiniteTimeSpan, CancellationToken.None).ConfigureAwait(false);
	}

	/// <summary>
	/// Measures an active wait completed by explicitly signaling the registered pending task.
	/// </summary>
	/// <returns><see langword="true"/> when the registered task completes.</returns>
	/// <remarks>An infinite timeout avoids timer work; signaling is part of the measured workload.</remarks>
	[Benchmark(Description = "WaitForCompletionAsync: pending task signaled inline")]
	public async Task<bool> WaitForPendingCompletionAsync()
	{
		var completion = this._tracker.WaitForCompletionAsync(Timeout.InfiniteTimeSpan, CancellationToken.None);

		this._pendingSource.SetResult();

		return await completion.ConfigureAwait(false);
	}

	/// <summary>
	/// Measures an immediate timeout while the registered task remains pending.
	/// </summary>
	/// <returns><see langword="false"/> because the pending task has not completed.</returns>
	[Benchmark(Description = "WaitForCompletionAsync: pending task, zero timeout")]
	public async Task<bool> WaitPendingZeroTimeoutAsync()
	{
		return await this._tracker.WaitForCompletionAsync(TimeSpan.Zero, CancellationToken.None).ConfigureAwait(false);
	}

}
