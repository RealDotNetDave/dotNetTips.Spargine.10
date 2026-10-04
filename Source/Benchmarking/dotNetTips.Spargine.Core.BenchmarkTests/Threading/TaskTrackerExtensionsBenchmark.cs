// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 10-03-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 10-04-2026
// ***********************************************************************
// <copyright file="TaskTrackerExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks the TaskTrackerExtensions registration helpers using a single tracker for the whole run.
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
/// A single tracker is used for the whole run. Registered tasks complete immediately and are removed by the tracker,
/// and the pending task is registered by reference, so registrations never accumulate.
/// The class is unsealed because BenchmarkDotNet generates a derived workload runner.
/// </remarks>
[BenchmarkCategory(Categories.Threading)]
[MemoryDiagnoser]
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "The inherited global cleanup hook disposes the tracker.")]
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
		_ = this._pendingSource.TrySetResult();
		this._tracker.Dispose();
		base.Cleanup();
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
	public ReadOnlyCollection<Ulid> RegisterManyWithTracker()
	{
		return new ReadOnlySpan<int>(this._items).RegisterManyWithTracker(_action, this._tracker);
	}

	/// <summary>
	/// Measures creating and registering one task per item with an asynchronous function.
	/// </summary>
	/// <returns>The registration keys.</returns>
	[Benchmark(Description = nameof(RegisterManyWithTrackerAsync))]
	public ReadOnlyCollection<Ulid> RegisterManyWithTrackerAsync()
	{
		return new ReadOnlySpan<int>(this._items).RegisterManyWithTrackerAsync(_asyncAction, this._tracker);
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

		this._tracker.Dispose();
		this._pendingSource = new TaskCompletionSource();
		this._tracker = new TaskTracker();
	}
}
