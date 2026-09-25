// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 09-24-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-24-2026
// ***********************************************************************
// <copyright file="TaskTracker.Facade.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Static façade around a default singleton <see cref="TaskTracker"/> instance to simplify usage.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Threading;

/// <summary>
/// Static façade providing quick access to a default <see cref="ITaskTracker"/> instance.
/// Use <see cref="Instance"/> for dependency injection scenarios.
/// </summary>
[Information(nameof(TaskTrackerFacade), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
public static class TaskTrackerFacade
{
	private static readonly Lazy<ITaskTracker> _default = new(() => new TaskTracker());

	/// <inheritdoc cref="ITaskTracker.HasPendingTasks"/>
	[Information(nameof(HasPendingTasks), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static bool HasPendingTasks => Instance.HasPendingTasks;

	/// <summary>
	/// Gets the default shared <see cref="ITaskTracker"/> instance.
	/// </summary>
	[Information(nameof(Instance), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static ITaskTracker Instance => _default.Value;

	/// <inheritdoc cref="ITaskTracker.GetPendingCount"/>
	[Information(nameof(GetPendingCount), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static int GetPendingCount() => Instance.GetPendingCount();

	/// <inheritdoc cref="ITaskTracker.Register(Task, Action{Exception}?)"/>
	[Information(nameof(Register), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static Ulid Register([DisallowNull] Task task, Action<Exception>? onException = null) => Instance.Register(task, onException);

	/// <inheritdoc cref="ITaskTracker.Unregister(Task)"/>
	[Information(nameof(Unregister), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static void Unregister([DisallowNull] Task task) => Instance.Unregister(task);

	/// <inheritdoc cref="ITaskTracker.Unregister(Ulid)"/>
	[Information(nameof(Unregister), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static bool Unregister(Ulid key) => Instance.Unregister(key);

	/// <inheritdoc cref="ITaskTracker.WaitForCompletionAsync(TimeSpan?, CancellationToken)"/>
	[Information(nameof(WaitForCompletionAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static Task<bool> WaitForCompletionAsync(TimeSpan? timeout = null, CancellationToken cancellationToken = default) => Instance.WaitForCompletionAsync(timeout, cancellationToken);
}
