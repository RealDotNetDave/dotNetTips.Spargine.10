// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 08-04-2026
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2026
// ***********************************************************************
// <copyright file="ThreadPoolStatistics.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Represents a point-in-time snapshot of the managed thread pool statistics.</summary>
// ***********************************************************************
namespace DotNetTips.Spargine.Core.Threading;

/// <summary>
/// Represents a point-in-time snapshot of the managed thread pool statistics.
/// </summary>
/// <param name="ThreadCount">The number of thread pool threads that currently exist.</param>
/// <param name="PendingWorkItemCount">The number of work items that are currently queued to be processed.</param>
/// <param name="CompletedWorkItemCount">The number of work items that have been processed since the application started.</param>
/// <param name="MinWorkerThreads">The minimum number of worker threads the thread pool creates on demand.</param>
/// <param name="MaxWorkerThreads">The maximum number of worker threads in the thread pool.</param>
/// <param name="AvailableWorkerThreads">The number of additional worker threads that can be started.</param>
/// <param name="MinCompletionPortThreads">The minimum number of asynchronous I/O threads the thread pool creates on demand.</param>
/// <param name="MaxCompletionPortThreads">The maximum number of asynchronous I/O threads in the thread pool.</param>
/// <param name="AvailableCompletionPortThreads">The number of additional asynchronous I/O threads that can be started.</param>
[Information(description: nameof(ThreadPoolStatistics), Status = Status.NeedsDocumentation)]
public readonly record struct ThreadPoolStatistics(int ThreadCount, long PendingWorkItemCount, long CompletedWorkItemCount, int MinWorkerThreads, int MaxWorkerThreads, int AvailableWorkerThreads, int MinCompletionPortThreads, int MaxCompletionPortThreads, int AvailableCompletionPortThreads);
