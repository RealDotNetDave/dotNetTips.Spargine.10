// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-25-2019
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2025
// ***********************************************************************
// <copyright file="TaskExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for Task.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Task"/> to enhance asynchronous programming.
/// These methods include functionality for fire-and-forget tasks, allowing tasks to run in the background without awaiting their completion, and handling exceptions that occur within these tasks.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class TaskExtensions
{

	/// <summary>
	/// Executes the specified task without waiting for it to complete, effectively making it a fire-and-forget operation. This method is useful for tasks that are self-contained and do not need to be awaited or have their exceptions handled directly. Validates that <paramref name="task" /> is not null. If the task throws an exception, it will be caught and logged, preventing unobserved task exceptions.
	/// </summary>
	/// <param name="task">The <see cref="Task"/> to execute. This parameter cannot be null.</param>
	/// <example>
	/// // Example of calling a fire-and-forget task
	/// PerformLongRunningWorkAsync().FireAndForget();
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static void FireAndForget([DisallowNull] this Task task)
	{
		_ = task.ArgumentNotNull().ContinueWith(tsk => tsk.Exception, CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
	}

	/// <summary>
	/// Fires the task and forgets it. Validates that <paramref name="task" /> is not null and handles exceptions using the provided action.
	/// </summary>
	/// <param name="task">The <see cref="Task"/> to execute.</param>
	/// <param name="action">The action to execute if an exception occurs. The action receives the exception as a parameter.</param>
	/// <example>
	/// Action&lt;Exception&gt; exAction = (Exception ex) =&gt; Debug.WriteLine(ex.Message);
	/// SomeType.FireAsync("Test Message").FireAndForget(exAction);
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original code from: https://weblog.west-wind.com/posts/2021/Jul/07/Thoughts-on-AsyncAwait-Conversion-in-a-Desktop-App", "David McCarter", "7/13/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static void FireAndForget([DisallowNull] this Task task, [DisallowNull] Action<Exception> action)
	{
		_ = task.ArgumentNotNull().ContinueWith((tsk) => action?.Invoke(tsk.Exception!), CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
	}

}
