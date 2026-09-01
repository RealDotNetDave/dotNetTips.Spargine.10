// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-28-2026
// ***********************************************************************
// <copyright file="LoggingHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Logging;

[ExcludeFromCodeCoverage]
[TestClass]
public class LoggingHelperTests
{

	private readonly ILogger _logger = new NullLogger<LoggingHelperTests>();

	[TestMethod]
	public void LogAppDomainEvents_NullLogger_ThrowsArgumentNullException()
	{
		// Arrange
		ILogger logger = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => LoggingHelper.LogAppDomainEvents(logger));
	}

	[TestMethod]
	public void LogAppDomainEvents_WithValidLogger_DoesNotThrow()
	{
		var logger = new MockLogger();

		LoggingHelper.LogAppDomainEvents(logger);
	}

	[TestMethod]
	public void LogAppDomainFirstChanceException_NullLogger_ThrowsArgumentNullException()
	{
		// Arrange
		ILogger logger = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => LoggingHelper.LogAppDomainFirstChanceException(logger));
	}

	[TestMethod]
	public void LogAppDomainFirstChanceException_WithValidLogger_DoesNotThrow()
	{
		var logger = new MockLogger();

		LoggingHelper.LogAppDomainFirstChanceException(logger);
	}

	[TestMethod]
	public void LogAppDomainUnhandledException_NullLogger_ThrowsArgumentNullException()
	{
		// Arrange
		ILogger logger = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => LoggingHelper.LogAppDomainUnhandledException(logger));
	}

	[TestMethod]
	public void LogAppDomainUnhandledException_WithValidLogger_DoesNotThrow()
	{
		var logger = new MockLogger();

		LoggingHelper.LogAppDomainUnhandledException(logger);
	}

	[TestMethod]
	public void LogApplicationInformation_NullLogger_ThrowsArgumentNullException()
	{
		// Arrange
		ILogger logger = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => LoggingHelper.LogApplicationInformation(logger));
	}

	[TestMethod]
	public void LogApplicationInformation_WhenLogLevelDisabled_DoesNotLog()
	{
		// Arrange - NullLogger returns false for IsEnabled
		var logger = new NullLogger<LoggingHelperTests>();

		// Act - Should return early without logging
		LoggingHelper.LogApplicationInformation(logger);

		// Assert - No exception thrown, method exits early
	}

	[TestMethod]
	public void LogApplicationInformation_WithEnabledLogger_LogsAppInfo()
	{
		// Arrange
		var logger = new MockLogger();

		// Act
		LoggingHelper.LogApplicationInformation(logger);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Count > 0, "Should log application information.");

		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains("AppInfo:")), "Messages should contain AppInfo prefix.");
	}

	[TestMethod]
	public void LogApplicationInformation_WithEnabledLogger_LogsAtInformationLevel()
	{
		// Arrange
		var logger = new MockLogger();

		// Act
		LoggingHelper.LogApplicationInformation(logger);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.All(l => l == LogLevel.Information), "All messages should be logged at Information level.");
	}

	[TestMethod]
	public void LogApplicationInformationTest()
	{
		LoggingHelper.LogApplicationInformation(this._logger);
	}

	[TestMethod]
	public void LogComputerInformation_NullLogger_ThrowsArgumentNullException()
	{
		// Arrange
		ILogger logger = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => LoggingHelper.LogComputerInformation(logger));
	}

	[TestMethod]
	public void LogComputerInformation_WithEnabledLogger_LogsComputerInfo()
	{
		// Arrange
		var logger = new MockLogger();

		// Act
		LoggingHelper.LogComputerInformation(logger);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Count > 0, "Should log computer information.");

		Assert.IsTrue(logger.LoggedLevels.All(l => l == LogLevel.Information), "All messages should be logged at Information level.");
	}

	[TestMethod]
	public void LogComputerInformation_WithEnabledLogger_LogsComputerInfoPrefix()
	{
		var logger = new MockLogger();

		LoggingHelper.LogComputerInformation(logger);

		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains("ComputerInfo:")), "Messages should contain ComputerInfo prefix.");
	}

	[TestMethod]
	public void LogComputerInformationTest()
	{
		LoggingHelper.LogComputerInformation(this._logger);
	}

	[TestMethod]
	public void RetrieveAllExceptionMessages_DeeplyNestedExceptions_ReturnsAllMessages()
	{
		var innermost = new DivideByZeroException("Innermost error");
		var inner = new ArithmeticException("Inner error", innermost);
		var outer = new InvalidOperationException("Outer error", inner);

		var result = LoggingHelper.RetrieveAllExceptionMessages(outer);

		Assert.AreEqual(3, result.Count);
		Assert.AreEqual("Outer error", result[0]);
		Assert.AreEqual("Inner error", result[1]);
		Assert.AreEqual("Innermost error", result[2]);
	}

	[TestMethod]
	public void RetrieveAllExceptionMessages_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => LoggingHelper.RetrieveAllExceptionMessages(exception));
	}

	[TestMethod]
	public void RetrieveAllExceptionMessages_ReturnsReadOnlyCollection()
	{
		var exception = new InvalidOperationException("Test error");

		var result = LoggingHelper.RetrieveAllExceptionMessages(exception);

		Assert.IsInstanceOfType<ReadOnlyCollection<string>>(result);
	}

	[TestMethod]
	public void RetrieveAllExceptionMessages_SingleException_ReturnsSingleMessage()
	{
		// Arrange
		var testException = new InvalidOperationException("Single error message");

		// Act
		var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.AreEqual("Single error message", result[0]);
	}

	[TestMethod]
	public void RetrieveAllExceptionMessagesTest()
	{
		var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

		var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void RetrieveAllExceptions_DeeplyNestedExceptions_ReturnsAllExceptions()
	{
		var innermost = new DivideByZeroException("Innermost error");
		var inner = new ArithmeticException("Inner error", innermost);
		var outer = new InvalidOperationException("Outer error", inner);

		var result = LoggingHelper.RetrieveAllExceptions(outer);

		Assert.AreEqual(3, result.Count);
		Assert.IsInstanceOfType<InvalidOperationException>(result[0]);
		Assert.IsInstanceOfType<ArithmeticException>(result[1]);
		Assert.IsInstanceOfType<DivideByZeroException>(result[2]);
	}

	[TestMethod]
	public void RetrieveAllExceptions_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => LoggingHelper.RetrieveAllExceptions(exception));
	}

	[TestMethod]
	public void RetrieveAllExceptions_ReturnsReadOnlyCollection()
	{
		var exception = new InvalidOperationException("Test error");

		var result = LoggingHelper.RetrieveAllExceptions(exception);

		Assert.IsInstanceOfType<ReadOnlyCollection<Exception>>(result);
	}

	[TestMethod]
	public void RetrieveAllExceptions_SingleException_ReturnsSingleException()
	{
		// Arrange
		var testException = new InvalidOperationException("Single error");

		// Act
		var result = LoggingHelper.RetrieveAllExceptions(testException);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.IsInstanceOfType<InvalidOperationException>(result[0]);
	}

	[TestMethod]
	public void RetrieveAllExceptionsTest()
	{
		var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

		var result = LoggingHelper.RetrieveAllExceptions(testException);

		Assert.AreEqual(2, result.Count);
	}

}
