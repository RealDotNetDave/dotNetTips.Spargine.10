// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 09-24-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-24-2026
// ***********************************************************************
// <copyright file="TaskTrackerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Unit tests for TaskTracker behavior: registration, exception forwarding, waiting, and facade.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Threading;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Threading;

[TestClass]
[ExcludeFromCodeCoverage]
public sealed class TaskTrackerTests
{

	[TestMethod]
	public void Dispose_PendingTask_ClearsTrackedTasks()
	{
		var tracker = new TaskTracker();
		var taskCompletionSource = new TaskCompletionSource<int>();
		var task = taskCompletionSource.Task;
		var registrationKey = tracker.Register(task);
		Assert.AreNotEqual(default(Ulid), registrationKey);

		tracker.Dispose();

		Assert.AreEqual(0, tracker.GetPendingCount());
		Assert.IsFalse(tracker.HasPendingTasks);
		taskCompletionSource.SetResult(1);
		tracker.Dispose();
	}

	[TestMethod]
	public async Task ExceptionCallbackInvoked_ForFaultedTask()
	{
		using ITaskTracker tracker = new TaskTracker();

		var task = Task.Run(async () =>
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("boom");
		});

		var invoked = new TaskCompletionSource<Exception>();

		var registrationKey = tracker.Register(task, ex => invoked.TrySetResult(ex));
		Assert.AreNotEqual(default(Ulid), registrationKey);

		// wait for the callback to be invoked
		var completed = await Task.WhenAny(invoked.Task, Task.Delay(1000)).ConfigureAwait(false);

		Assert.AreEqual(invoked.Task, completed);
		Assert.IsInstanceOfType(invoked.Task.Result, typeof(AggregateException));
	}

	[TestMethod]
	public void Facade_ExposesDefaultInstanceAndPendingState()
	{
		var taskCompletionSource = new TaskCompletionSource<int>();
		var task = taskCompletionSource.Task;

		Assert.AreSame(TaskTrackerFacade.Instance, TaskTrackerFacade.Instance);
		var registrationKey = TaskTrackerFacade.Register(task);
		Assert.AreNotEqual(default(Ulid), registrationKey);
		Assert.IsTrue(TaskTrackerFacade.HasPendingTasks);
		Assert.IsTrue(TaskTrackerFacade.GetPendingCount() > 0);

		Assert.IsTrue(TaskTrackerFacade.Unregister(registrationKey));
		taskCompletionSource.SetResult(1);
		Assert.IsFalse(TaskTrackerFacade.HasPendingTasks);
	}

	[TestMethod]
	public async Task Facade_Register_Unregister_WaitBehaviors()
	{
		var tcs = new TaskCompletionSource<int>();
		var task = tcs.Task;

		var registrationKey = TaskTrackerFacade.Register(task);
		Assert.AreNotEqual(default(Ulid), registrationKey);
		Assert.IsTrue(TaskTrackerFacade.GetPendingCount() >= 1);

		Assert.IsTrue(TaskTrackerFacade.Unregister(registrationKey));
		// unregister may remove it immediately
		await Task.Delay(10).ConfigureAwait(false);

		// Register via facade and wait
		TaskTrackerFacade.Register(Task.Run(async () => { await Task.Delay(20).ConfigureAwait(false); }));
		var ok = await TaskTrackerFacade.WaitForCompletionAsync(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
		Assert.IsTrue(ok);
	}

	[TestMethod]
	public async Task FireAndForgetAndTrack_ForwardsExceptionToCallback()
	{
		using ITaskTracker tracker = new TaskTracker();

		var invoked = new TaskCompletionSource<Exception>();

		var task = Task.Run(async () =>
		{
			await Task.Delay(10).ConfigureAwait(false);
			throw new InvalidOperationException("boom2");
		});

		var registrationKey = task.FireAndForgetAndTrack(tracker, ex => invoked.TrySetResult(ex));
		Assert.AreNotEqual(default(Ulid), registrationKey);

		var completed = await Task.WhenAny(invoked.Task, Task.Delay(1000)).ConfigureAwait(false);

		Assert.AreEqual(invoked.Task, completed);
		Assert.IsInstanceOfType(invoked.Task.Result, typeof(AggregateException));
	}

	[TestMethod]
	public async Task RegisterCompletion_RemovesFromPending()
	{
		using ITaskTracker tracker = new TaskTracker();

		var tcs = new TaskCompletionSource<int>();
		var task = tcs.Task;

		var registrationKey = tracker.Register(task);
		Assert.AreNotEqual(default(Ulid), registrationKey);

		Assert.AreEqual(1, tracker.GetPendingCount());

		tcs.SetResult(42);

		// wait a short time for the continuation to run
		await Task.Delay(50).ConfigureAwait(false);

		Assert.AreEqual(0, tracker.GetPendingCount());
		Assert.IsFalse(tracker.HasPendingTasks);
	}

	[TestMethod]
	public async Task RegisterManyWithTracker_Action_RegistersAllAndCompletes()
	{
		using ITaskTracker tracker = new TaskTracker();
		var items = new[] { 1, 2, 3, 4, 5 };
		var processedCount = 0;

		var registrationKeys = TaskTrackerExtensions.RegisterManyWithTracker(items, item => Interlocked.Add(ref processedCount, item), tracker);

		Assert.AreEqual(items.Length, registrationKeys.Count);
		Assert.AreEqual(items.Length, registrationKeys.Distinct().Count());

		var completed = await tracker.WaitForCompletionAsync(TimeSpan.FromSeconds(1)).ConfigureAwait(false);

		Assert.IsTrue(completed);
		Assert.AreEqual(15, processedCount);
	}

	[TestMethod]
	public async Task RegisterManyWithTrackerAsync_SyncThrow_InvokesExceptionCallback()
	{
		using ITaskTracker tracker = new TaskTracker();
		var items = new[] { 1, 2, 3 };
		var callbackInvoked = new TaskCompletionSource<Exception>();

		var registrationKeys = TaskTrackerExtensions.RegisterManyWithTrackerAsync(
			items,
			item => item == 2 ? throw new InvalidOperationException("sync failure") : Task.CompletedTask,
			tracker,
			ex => callbackInvoked.TrySetResult(ex));

		Assert.AreEqual(items.Length, registrationKeys.Count);

		var callbackTask = await Task.WhenAny(callbackInvoked.Task, Task.Delay(1000)).ConfigureAwait(false);
		Assert.AreEqual(callbackInvoked.Task, callbackTask);
	}

	[TestMethod]
	public async Task RegisterWithTracker_RegistersAndRemovesOnCompletion()
	{
		using ITaskTracker tracker = new TaskTracker();

		var tcs = new TaskCompletionSource<int>();
		var task = tcs.Task;

		var registrationKey = task.RegisterWithTracker(tracker);
		Assert.AreNotEqual(default(Ulid), registrationKey);

		Assert.AreEqual(1, tracker.GetPendingCount());

		tcs.SetResult(1);

		await Task.Delay(50).ConfigureAwait(false);

		Assert.AreEqual(0, tracker.GetPendingCount());
	}

	[TestMethod]
	public void Unregister_Key_RemovesItFromTracker()
	{
		using ITaskTracker tracker = new TaskTracker();
		var taskCompletionSource = new TaskCompletionSource<int>();
		var task = taskCompletionSource.Task;
		var registrationKey = tracker.Register(task);

		Assert.IsTrue(tracker.Unregister(registrationKey));
		Assert.AreEqual(0, tracker.GetPendingCount());
		taskCompletionSource.SetResult(1);
	}

	[TestMethod]
	public void Unregister_PendingTask_RemovesItFromTracker()
	{
		using ITaskTracker tracker = new TaskTracker();
		var taskCompletionSource = new TaskCompletionSource<int>();
		var task = taskCompletionSource.Task;
		var registrationKey = tracker.Register(task);
		Assert.AreNotEqual(default(Ulid), registrationKey);

		tracker.Unregister(task);

		Assert.AreEqual(0, tracker.GetPendingCount());
		taskCompletionSource.SetResult(1);
	}

	[TestMethod]
	public async Task WaitForCompletionAsync_DefaultTimeout_ReturnsTrueWhenComplete()
	{
		using ITaskTracker tracker = new TaskTracker();

		var task = Task.Run(async () => { await Task.Delay(20).ConfigureAwait(false); });

		var registrationKey = tracker.Register(task);
		Assert.AreNotEqual(default(Ulid), registrationKey);

		var result = await tracker.WaitForCompletionAsync().ConfigureAwait(false);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public async Task WaitForCompletionAsync_TimesOut_ReturnsFalse()
	{
		using ITaskTracker tracker = new TaskTracker();

		var task = Task.Run(async () => { await Task.Delay(500).ConfigureAwait(false); });

		var registrationKey = tracker.Register(task);
		Assert.AreNotEqual(default(Ulid), registrationKey);

		var result = await tracker.WaitForCompletionAsync(TimeSpan.FromMilliseconds(20)).ConfigureAwait(false);

		Assert.IsFalse(result);
	}
}
