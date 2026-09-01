// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="ProcessExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <c>Process</c> providing priority management
// (<c>EnsureHighPriority</c>, <c>EnsureLowPriority</c>, <c>TrySetPriority</c>)
// and process execution helpers (<c>RunProcessAndIgnoreOutput</c>, <c>RunProcessAndReadOutput</c>).
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.Logging;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <c>Process</c> covering priority management and process execution.
/// </summary>
/// <remarks>
/// Includes methods for elevating or lowering process priority (<c>EnsureHighPriority</c>,
/// <c>EnsureLowPriority</c>, <c>TrySetPriority</c>) and for running an external process with
/// optional output capture (<c>RunProcessAndIgnoreOutput</c>, <c>RunProcessAndReadOutput</c>).
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class ProcessExtensions
{

	/// <summary>
	/// Sets the priority of <paramref name="process"/> to <c>High</c>.
	/// Logs an error via <paramref name="logger"/> if the priority cannot be applied.
	/// </summary>
	/// <param name="process">The process whose priority will be raised.</param>
	/// <param name="logger">Optional logger used to record any failure.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="process"/> is <c>null</c>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void EnsureHighPriority([DisallowNull] this Process process, [AllowNull] ILogger logger)
	{
		process = process.ArgumentNotNull();

		try
		{
			process.PriorityClass = ProcessPriorityClass.High;
		}
		catch (InvalidOperationException ex)
		{
			if (logger != null)
			{
				LoggerMessage.Define<string>(LogLevel.Error, 0, string.Empty).Invoke(logger, Resources.FailedToSetUpHighPriority, ex);
			}
		}
	}

	/// <summary>
	/// Sets the priority of <paramref name="process"/> to <c>BelowNormal</c>.
	/// Logs an error via <paramref name="logger"/> if the priority cannot be applied.
	/// </summary>
	/// <param name="process">The process whose priority will be lowered.</param>
	/// <param name="logger">Optional logger used to record any failure.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="process"/> is <c>null</c>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void EnsureLowPriority([DisallowNull] this Process process, [AllowNull] ILogger logger)
	{
		process = process.ArgumentNotNull();

		try
		{
			process.PriorityClass = ProcessPriorityClass.BelowNormal;
		}
		catch (InvalidOperationException ex)
		{
			if (logger != null)
			{
				LoggerMessage.Define<string>(LogLevel.Error, 0, string.Empty).Invoke(logger, Resources.FailedToSetUpLowPriority, ex);
			}
		}
	}

	/// <summary>
	/// Starts a process with the given <paramref name="fileName"/> and <paramref name="arguments"/>,
	/// waits up to <paramref name="timeout"/> for it to finish, and discards any output.
	/// </summary>
	/// <param name="fileName">The path to the executable.</param>
	/// <param name="arguments">The command-line arguments to pass to the process.</param>
	/// <param name="timeout">The maximum time to wait for the process to exit.</param>
	/// <returns>The exit code returned by the process.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="fileName"/> or <paramref name="arguments"/> is <c>null</c>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int RunProcessAndIgnoreOutput([DisallowNull] this string fileName, [DisallowNull] string arguments, in TimeSpan timeout)
	{
		fileName = fileName.ArgumentNotNullOrEmpty();
		arguments = arguments.ArgumentNotNullOrEmpty();

		var startInfo = new ProcessStartInfo
		{
			FileName = fileName,
			Arguments = arguments,
			RedirectStandardOutput = false,
			RedirectStandardError = false,
			UseShellExecute = false,
			CreateNoWindow = true
		};

		using var process = Process.Start(startInfo);

		if (!process!.WaitForExit((int)timeout.TotalMilliseconds))
		{
			process.Kill();
		}

		return process.ExitCode;
	}

	/// <summary>
	/// Starts a process with the given <paramref name="fileName"/> and <paramref name="arguments"/>,
	/// waits up to <paramref name="timeout"/> for it to finish, and captures its standard output.
	/// </summary>
	/// <param name="fileName">The path to the executable.</param>
	/// <param name="arguments">The command-line arguments to pass to the process.</param>
	/// <param name="timeout">The maximum time to wait for the process to exit.</param>
	/// <returns>
	/// A tuple of (<c>int exitCode</c>, <c>string output</c>).
	/// If the process exceeds <paramref name="timeout"/> it is killed and <c>output</c> is an empty string.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="fileName"/> or <paramref name="arguments"/> is <c>null</c>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static (int exitCode, string output) RunProcessAndReadOutput([DisallowNull] this string fileName, [DisallowNull] string arguments, in TimeSpan timeout)
	{
		fileName = fileName.ArgumentNotNullOrEmpty();
		arguments = arguments.ArgumentNotNullOrEmpty();

		var startInfo = new ProcessStartInfo
		{
			FileName = fileName,
			Arguments = arguments,
			RedirectStandardOutput = true,
			UseShellExecute = false
		};

		using var process = Process.Start(startInfo)!;

		if (process.WaitForExit((int)timeout.TotalMilliseconds))
		{
			return (process.ExitCode, process.StandardOutput.ReadToEnd());
		}
		else
		{
			process.Kill();
		}

		return (process.ExitCode, string.Empty);
	}

	/// <summary>
	/// Attempts to set the <paramref name="priority"/> of <paramref name="process"/>.
	/// Logs a failure message via <paramref name="logger"/> if the priority cannot be applied.
	/// </summary>
	/// <param name="process">The process whose priority will be changed.</param>
	/// <param name="priority">The desired <c>ProcessPriorityClass</c> value.</param>
	/// <param name="logger">Optional logger used to record any failure.</param>
	/// <returns><c>true</c> if the priority was set successfully; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="process"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="priority"/> is not a defined enum value.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool TrySetPriority([DisallowNull] this Process process, ProcessPriorityClass priority, [AllowNull] ILogger logger)
	{
		if (process is null)
		{
			return false;
		}

		priority = priority.ArgumentDefined();

		try
		{
			process.PriorityClass = priority;
			return true;
		}
		catch (InvalidOperationException ex)
		{
			if (logger != null)
			{
				LoggerMessage.Define<string, string>(LogLevel.Error, 0, formatString: "Failed to set up priority {Priority} for process {Process}. Make sure you have the right permissions.").Invoke(logger, nameof(priority), nameof(process), ex);
			}
		}

		return false;
	}

}
