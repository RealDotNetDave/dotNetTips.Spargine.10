// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2025
// ***********************************************************************
// <copyright file="ThreadExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for Thread that support setting priority and timer-free wait mechanisms.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Devices;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Thread"/> that support setting priority
/// and timer-free wait mechanisms.
/// </summary>
/// <remarks>
/// The <see cref="ThreadExtensions"/> class includes methods for safely adjusting thread priority
/// and performing spin-wait loops without allocating a timer.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class ThreadExtensions
{

	/// <summary>
	/// Tries to set the priority of the specified <see cref="Thread"/>.
	/// Validates that <paramref name="thread"/> is not null.
	/// </summary>
	/// <param name="thread">The <see cref="Thread"/> whose priority is to be set. Cannot be null.</param>
	/// <param name="priority">The desired <see cref="ThreadPriority"/> for the thread. Defaults to <see cref="ThreadPriority.Normal"/>.</param>
	/// <returns><c>true</c> if the priority was successfully set; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="thread"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="priority"/> is not a defined <see cref="ThreadPriority"/> value.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool TrySetPriority([DisallowNull] this Thread thread, ThreadPriority priority = ThreadPriority.Normal)
	{
		thread.ArgumentNotNull().Priority = priority.ArgumentDefined();

		return true;
	}

	/// <summary>
	/// Waits for the specified interval without using a timer.
	/// Validates that <paramref name="thread"/> is not null.
	/// </summary>
	/// <param name="thread">The <see cref="Thread"/> to wait on. Cannot be null.</param>
	/// <param name="interval">The wait interval.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="thread"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(WaitUntil), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static void WaitUntil([DisallowNull] this Thread thread, TimeSpan interval)
	{
		WaitUntil(thread.ArgumentNotNull(), interval, 0);
	}

	/// <summary>
	/// Waits until the specified interval has elapsed or the spin-wait iterations are exhausted, whichever comes first.
	/// Validates that <paramref name="thread"/> is not null.
	/// </summary>
	/// <param name="thread">The <see cref="Thread"/> to monitor. Cannot be null.</param>
	/// <param name="interval">The maximum time to wait.</param>
	/// <param name="waitIterations">The number of spin-wait iterations to perform. Must be zero or greater.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="thread"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="waitIterations"/> is less than zero.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(WaitUntil), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static void WaitUntil([DisallowNull] this Thread thread, TimeSpan interval, int waitIterations)
	{
		thread = thread.ArgumentNotNull();
		waitIterations = waitIterations.ArgumentInRange(min: 0);

		var stopAt = Clock.LocalTime.Add(interval);

		while (thread.IsAlive && Clock.LocalTime < stopAt)
		{
			Thread.SpinWait(waitIterations);
		}
	}

}
