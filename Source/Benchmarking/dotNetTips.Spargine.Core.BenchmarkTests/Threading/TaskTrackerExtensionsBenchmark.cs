// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 10-03-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 10-03-2026
// ***********************************************************************
// <copyright file="TaskTrackerExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks the TaskTrackerExtensions registration helpers using a fresh tracker for each iteration.
// </summary>
// ***********************************************************************
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Threading;

namespace DotNetTips.Spargine.Core.BenchmarkTests.Threading;

/// <summary>
/// Measures <see cref="TaskTrackerExtensions"/> registration helpers.
/// </summary>
/// <remarks>
/// Each iteration measures one invocation against a new tracker so registrations never accumulate.
/// The class is unsealed because BenchmarkDotNet generates a derived workload runner.
/// </remarks>
[BenchmarkCategory(Categories.Threading)]
[InvocationCount(1, unrollFactor: 1)]
[MemoryDiagnoser]
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "BenchmarkDotNet iteration cleanup and the inherited global cleanup hook dispose the tracker.")]
public class TaskTrackerExtensionsBenchmark : Benchmark
{
	private static readonly Action<int> _action = static _ => { };

	private static readonly Func<int, Task> _asyncAction = static _ => Task.CompletedTask;

	private int[] _items;

	private TaskCompletionSource _pendingSource;

	private TaskTracker _tracker;

	/// <summary>
	/// Initializes a new instance of the <see cref="TaskTrackerExtensionsBenchmark"/> class.
	/// </summary>
	public TaskTrackerExtensionsBenchmark()
	{
		this._items = new int[10];
		this._pendingSource = new TaskCompletionSource();
		this._tracker = new TaskTracker();
	}

	/// <summary>
	/// Releases the tracker after the job.
	/// </summary>
	public override void Cleanup()
	{
		this.CleanupIteration();
		base.Cleanup();
	}

	/// <summary>
	/// Completes outstanding work before disposing the tracker.
	/// </summary>
	[IterationCleanup]
	public void CleanupIteration()
	{
		_ = this._pendingSource.TrySetResult();
		_ = this._tracker.WaitForCompletionAsync(TimeSpan.FromSeconds(5), CancellationToken.None).GetAwaiter().GetResult();
		this._tracker.Dispose();
	}

	/// <summary>
	/// Measures creating and registering a task for one item with a synchronous action.
	/// </summary>
	/// <returns>The registration key.</returns>
	[Benchmark(Description = nameof(RegisterItemWithTracker))]
	public Ulid RegisterItemWithTracker() => this._items[0].RegisterItemWithTracker(_action, this._tracker);

	/// <summary>
	/// Measures creating and registering a task for one item with an asynchronous function.
	/// </summary>
	/// <returns>The registration key.</returns>
	[Benchmark(Description = nameof(RegisterItemWithTrackerAsync))]
	public Ulid RegisterItemWithTrackerAsync() => this._items[0].RegisterItemWithTrackerAsync(_asyncAction, this._tracker);

	/// <summary>
	/// Measures creating and registering one task per item with a synchronous action.
	/// </summary>
	/// <returns>The registration keys.</returns>
	[Benchmark(Description = nameof(RegisterManyWithTracker))]
	public ReadOnlyCollection<Ulid> RegisterManyWithTracker() => new ReadOnlySpan<int>(this._items).RegisterManyWithTracker(_action, this._tracker);

	/// <summary>
	/// Measures creating and registering one task per item with an asynchronous function.
	/// </summary>
	/// <returns>The registration keys.</returns>
	[Benchmark(Description = nameof(RegisterManyWithTrackerAsync))]
	public ReadOnlyCollection<Ulid> RegisterManyWithTrackerAsync() => new ReadOnlySpan<int>(this._items).RegisterManyWithTrackerAsync(_asyncAction, this._tracker);

	/// <summary>
	/// Measures registering a pending task with a tracker.
	/// </summary>
	/// <returns>The registration key.</returns>
	[Benchmark(Description = nameof(RegisterWithTracker))]
	public Ulid RegisterWithTracker() => this._pendingSource.Task.RegisterWithTracker(this._tracker);

	/// <summary>
	/// Creates a fresh tracker and pending task outside the measured workload.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this.CleanupIteration();
		this._pendingSource = new TaskCompletionSource();
		this._tracker = new TaskTracker();
	}

	/// <summary>
	/// Initializes the Spargine base fixtures and the first tracker.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._items = new int[10];

		for (var itemIndex = 0; itemIndex < this._items.Length; itemIndex++)
		{
			this._items[itemIndex] = itemIndex;
		}

		this.Reset();
	}
}
