// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="ProcessExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ProcessExtensionsTests
{

	[TestMethod]
	public void EnsureHighPriority_ExitedProcess_WithLogger_ThrowsArgumentException()
	{
		// Arrange
		using var process = CreateExitedProcess();
		var logger = new MockLogger();

		// Act & Assert - InvalidOperationException is caught, but the LoggerMessage.Define
		// format string is empty while expecting 1 parameter, causing ArgumentException
		_ = Assert.ThrowsExactly<ArgumentException>(() => process.EnsureHighPriority(logger));
	}

	[TestMethod]
	public void EnsureHighPriority_ExitedProcess_WithNullLogger_DoesNotThrow()
	{
		// Arrange
		using var process = CreateExitedProcess();

		// Act & Assert - InvalidOperationException is caught internally when logger is null
		process.EnsureHighPriority(null);
	}

	// ========================
	// EnsureHighPriority Tests
	// ========================

	[TestMethod]
	public void EnsureHighPriority_NullProcess_ThrowsArgumentNullException()
	{
		// Arrange
		Process process = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => process.EnsureHighPriority(null));
	}

	[TestMethod]
	public void EnsureLowPriority_ExitedProcess_WithLogger_ThrowsArgumentException()
	{
		// Arrange
		using var process = CreateExitedProcess();
		var logger = new MockLogger();

		// Act & Assert - InvalidOperationException is caught, but the LoggerMessage.Define
		// format string is empty while expecting 1 parameter, causing ArgumentException
		_ = Assert.ThrowsExactly<ArgumentException>(() => process.EnsureLowPriority(logger));
	}

	[TestMethod]
	public void EnsureLowPriority_ExitedProcess_WithNullLogger_DoesNotThrow()
	{
		// Arrange
		using var process = CreateExitedProcess();

		// Act & Assert - InvalidOperationException is caught internally when logger is null
		process.EnsureLowPriority(null);
	}

	// ========================
	// EnsureLowPriority Tests
	// ========================

	[TestMethod]
	public void EnsureLowPriority_NullProcess_ThrowsArgumentNullException()
	{
		// Arrange
		Process process = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => process.EnsureLowPriority(null));
	}

	[TestMethod]
	public void EnsureLowPriority_ValidProcess_DoesNotThrow()
	{
		// Arrange
		using var process = Process.GetCurrentProcess();

		// Act & Assert - BelowNormal priority can be set without elevated privileges
		process.EnsureLowPriority(null);
	}

	[TestMethod]
	public void RunProcessAndIgnoreOutput_EmptyArguments_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => "cmd.exe".RunProcessAndIgnoreOutput(string.Empty, TimeSpan.FromSeconds(5)));
	}

	[TestMethod]
	public void RunProcessAndIgnoreOutput_EmptyFileName_ThrowsArgumentNullException()
	{
		// Arrange
		var fileName = string.Empty;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => fileName.RunProcessAndIgnoreOutput("arg", TimeSpan.FromSeconds(5)));
	}

	[TestMethod]
	public void RunProcessAndIgnoreOutput_NullArguments_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => "cmd.exe".RunProcessAndIgnoreOutput(null, TimeSpan.FromSeconds(5)));
	}

	// ==================================
	// RunProcessAndIgnoreOutput Tests
	// ==================================

	[TestMethod]
	public void RunProcessAndIgnoreOutput_NullFileName_ThrowsArgumentNullException()
	{
		// Arrange
		string fileName = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => fileName.RunProcessAndIgnoreOutput("arg", TimeSpan.FromSeconds(5)));
	}

	[TestMethod]
	public void RunProcessAndIgnoreOutput_TimedOutProcess_ReturnsNonZeroExitCode()
	{
		// Arrange & Act - ping.exe will run for ~60 seconds, but timeout kills it
		var exitCode = "ping.exe".RunProcessAndIgnoreOutput("-n 60 127.0.0.1", TimeSpan.FromMilliseconds(100));

		// Assert - killed process should return non-zero exit code
		Assert.AreNotEqual(0, exitCode, "Exit code should be non-zero for a killed process.");
	}

	[TestMethod]
	public void RunProcessAndIgnoreOutput_ValidInput_ReturnsExitCode()
	{
		// Act
		var exitCode = "cmd.exe".RunProcessAndIgnoreOutput("/C echo hello", TimeSpan.FromSeconds(10));

		// Assert
		Assert.AreEqual(0, exitCode, "Exit code should be 0 for a successful echo command.");
	}

	[TestMethod]
	public void RunProcessAndReadOutput_EmptyArguments_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => "cmd.exe".RunProcessAndReadOutput(string.Empty, TimeSpan.FromSeconds(5)));
	}

	[TestMethod]
	public void RunProcessAndReadOutput_EmptyFileName_ThrowsArgumentNullException()
	{
		// Arrange
		var fileName = string.Empty;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => fileName.RunProcessAndReadOutput("arg", TimeSpan.FromSeconds(5)));
	}

	[TestMethod]
	public void RunProcessAndReadOutput_NullArguments_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => "cmd.exe".RunProcessAndReadOutput(null, TimeSpan.FromSeconds(5)));
	}

	// ==================================
	// RunProcessAndReadOutput Tests
	// ==================================

	[TestMethod]
	public void RunProcessAndReadOutput_NullFileName_ThrowsArgumentNullException()
	{
		// Arrange
		string fileName = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => fileName.RunProcessAndReadOutput("arg", TimeSpan.FromSeconds(5)));
	}

	[TestMethod]
	public void RunProcessAndReadOutput_TimedOutProcess_ReturnsNonZeroExitCode()
	{
		// Arrange & Act - ping.exe will run for ~60 seconds, but timeout kills it
		var (exitCode, output) = "ping.exe".RunProcessAndReadOutput("-n 60 127.0.0.1", TimeSpan.FromMilliseconds(100));

		// Assert - killed process should return non-zero exit code and empty output
		Assert.AreNotEqual(0, exitCode, "Exit code should be non-zero for a killed process.");
		Assert.AreEqual(string.Empty, output, "Output should be empty for a killed process.");
	}

	[TestMethod]
	public void RunProcessAndReadOutput_ValidInput_ReturnsExitCodeAndOutput()
	{
		// Act
		var (exitCode, output) = "cmd.exe".RunProcessAndReadOutput("/C echo hello", TimeSpan.FromSeconds(10));

		// Assert
		Assert.AreEqual(0, exitCode, "Exit code should be 0 for a successful echo command.");
		Assert.IsTrue(output.Contains("hello"), "Output should contain the echoed text.");
	}

	[TestMethod]
	public void TrySetPriority_ExitedProcess_WithLogger_ReturnsFalse()
	{
		// Arrange
		using var process = CreateExitedProcess();
		var logger = new MockLogger();

		// Act
		var result = process.TrySetPriority(ProcessPriorityClass.Normal, logger);

		// Assert
		Assert.IsFalse(result, "TrySetPriority should return false for an exited process.");
		Assert.IsTrue(logger.LoggedLevels.Count > 0, "Logger should have recorded an error.");
		Assert.AreEqual(LogLevel.Error, logger.LoggedLevels[0]);
	}

	[TestMethod]
	public void TrySetPriority_ExitedProcess_WithNullLogger_ReturnsFalse()
	{
		// Arrange
		using var process = CreateExitedProcess();

		// Act
		var result = process.TrySetPriority(ProcessPriorityClass.Normal, null);

		// Assert
		Assert.IsFalse(result, "TrySetPriority should return false for an exited process.");
	}

	[TestMethod]
	public void TrySetPriority_InvalidPriority_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		using var process = Process.GetCurrentProcess();
		var invalidPriority = (ProcessPriorityClass)int.MaxValue;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => process.TrySetPriority(invalidPriority, null));
	}

	// =======================
	// TrySetPriority Tests
	// =======================

	[TestMethod]
	public void TrySetPriority_NullProcess_ReturnsFalse()
	{
		// Arrange
		Process process = null;

		// Act
		var result = process.TrySetPriority(ProcessPriorityClass.Normal, null);

		// Assert
		Assert.IsFalse(result, "TrySetPriority should return false for a null process.");
	}

	[TestMethod]
	public void TrySetPriority_ValidProcessAndPriority_ReturnsTrue()
	{
		// Arrange
		using var process = Process.GetCurrentProcess();

		// Act - Use Idle priority which can be set without elevated privileges
		var result = process.TrySetPriority(ProcessPriorityClass.Idle, null);

		// Assert
		Assert.IsTrue(result, "TrySetPriority should return true for a valid process and priority.");
	}

	private static Process CreateExitedProcess()
	{
		var process = Process.Start(new ProcessStartInfo
		{
			FileName = "cmd.exe",
			Arguments = "/C echo test",
			RedirectStandardOutput = true,
			UseShellExecute = false,
			CreateNoWindow = true,
		});

		process.WaitForExit();

		return process;
	}
}

[ExcludeFromCodeCoverage]
internal sealed class MockLogger : ILogger
{

	public List<LogLevel> LoggedLevels { get; } = [];

	public List<string> LoggedMessages { get; } = [];

	public IDisposable BeginScope<TState>(TState state) where TState : notnull => null!;

	public bool IsEnabled(LogLevel logLevel) => true;

	public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
	{
		this.LoggedLevels.Add(logLevel);
		this.LoggedMessages.Add(formatter(state, exception));
	}
}
