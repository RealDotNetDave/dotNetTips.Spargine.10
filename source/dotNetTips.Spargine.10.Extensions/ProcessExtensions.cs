// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="ProcessExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for Process.</summary>
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
/// Provides extension methods for the <see cref="Process"/> class to manipulate process priorities and execute processes with specific configurations.
/// </summary>
/// <remarks>
/// These extension methods include setting process priority, running processes with custom arguments and handling their output, and more.
/// They are designed to simplify common tasks related to process management in .NET applications.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class ProcessExtensions
{

	/// <summary>
	/// Ensures the high priority.
	/// Validates that <paramref name="process" /> is not null.
	/// </summary>
	/// <param name="process">The process.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="ArgumentNullException">process</exception>
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
	/// Ensures the low priority.
	/// Validates that <paramref name="process" /> is not null.
	/// </summary>
	/// <param name="process">The process.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="ArgumentNullException">process</exception>
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
	/// Runs the process and ignore output.
	/// Validates that <paramref name="fileName" /> and <paramref name="arguments" /> is not null.
	/// </summary>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="arguments">The arguments.</param>
	/// <param name="timeout">The timeout.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentException">fileName</exception>
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
	/// Runs the process and read output.
	/// Validates that <paramref name="fileName" /> and <paramref name="arguments" /> is not null.
	/// </summary>
	/// <param name="fileName">Name of the file.</param>
	/// <param name="arguments">The arguments.</param>
	/// <param name="timeout">The timeout.</param>
	/// <returns>System.ValueTuple&lt;System.Int32, System.String&gt;.</returns>
	/// <exception cref="ArgumentException">fileName</exception>
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
	/// Tries the set priority.
	/// </summary>
	/// <param name="process">The process.</param>
	/// <param name="priority">The priority.</param>
	/// <param name="logger">The logger.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">process or logger error</exception>
	/// <exception cref="ArgumentOutOfRangeException">priority</exception>
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
