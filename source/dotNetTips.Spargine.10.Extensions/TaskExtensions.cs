// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-25-2019
//
// Last Modified By : David McCarter
// Last Modified On : 05-21-2026
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

}
