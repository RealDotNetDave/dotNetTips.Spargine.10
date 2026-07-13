// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="StopwatchScope.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Lightweight timing scope that measures elapsed time and optionally reports.
// </summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// Measures elapsed time for a scoped operation and optionally reports the result on dispose.
/// </summary>
[Information(nameof(StopwatchScope), Status = Status.NeedsDocumentation)]
public sealed class StopwatchScope : IDisposable
{
	private readonly Action<TimeSpan>? _onDispose;
	private readonly Stopwatch _stopwatch;

	/// <summary>
	/// Initializes a new instance of the <see cref="StopwatchScope"/> class and starts timing immediately.
	/// </summary>
	/// <param name="onDispose">An optional callback invoked with the elapsed time when the scope is disposed.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StopwatchScope), "Copilot Agent", "07-09-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public StopwatchScope([AllowNull] Action<TimeSpan>? onDispose = null)
	{
		this._stopwatch = Stopwatch.StartNew();
		this._onDispose = onDispose;
	}

	/// <summary>
	/// Gets the current elapsed time.
	/// </summary>
	public TimeSpan Elapsed => this._stopwatch.Elapsed;

	/// <summary>
	/// Creates and starts a new <see cref="StopwatchScope"/>.
	/// </summary>
	/// <param name="onDispose">An optional callback invoked with the elapsed time when the scope is disposed.</param>
	/// <returns>A started stopwatch scope.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Start), "Copilot Agent", "07-09-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static StopwatchScope Start([AllowNull] Action<TimeSpan>? onDispose = null) => new(onDispose);

	/// <summary>
	/// Stops timing and invokes the completion callback, if provided.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Dispose()
	{
		this._stopwatch.Stop();
		this._onDispose?.Invoke(this._stopwatch.Elapsed);
	}
}
