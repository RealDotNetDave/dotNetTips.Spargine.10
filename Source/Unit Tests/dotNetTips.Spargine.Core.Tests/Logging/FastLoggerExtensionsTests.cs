// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="FastLoggerExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
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
public class FastLoggerExtensionsTests
{
	private ILogger _logger;

	[TestMethod]
	public void LogCriticalMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Critical error occurred.";
		var exception = new Exception("Critical exception");

		// Act
		this._logger.LogCriticalMessage(message, exception);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogCriticalMessage_WithMockLogger_LogsAtCriticalLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Critical error occurred.";
		var exception = new Exception("Critical exception");

		// Act
		logger.LogCriticalMessage(message, exception);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Critical), "Should log at Critical level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(message)), "Should contain the message.");
	}

	[TestMethod]
	public void LogCriticalMessage_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Critical error occurred.";
		var exception = new Exception("Critical exception");
		var customMethodName = "CustomCriticalMethod";

		// Act
		logger.LogCriticalMessage(message, exception, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	[TestMethod]
	public void LogDebugMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Debugging information.";

		// Act
		this._logger.LogDebugMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogDebugMessage_WithMockLogger_LogsAtDebugLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Debugging information.";

		// Act
		logger.LogDebugMessage(message);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Debug), "Should log at Debug level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(message)), "Should contain the message.");
	}

	[TestMethod]
	public void LogDebugMessage_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Debugging information.";
		var customMethodName = "CustomDebugMethod";

		// Act
		logger.LogDebugMessage(message, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	[TestMethod]
	public void LogErrorMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "An error occurred.";

		// Act
		this._logger.LogErrorMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogErrorMessage_WithMockLogger_LogsAtErrorLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "An error occurred.";

		// Act
		logger.LogErrorMessage(message);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Error), "Should log at Error level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(message)), "Should contain the message.");
	}

	[TestMethod]
	public void LogErrorMessage_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "An error occurred.";
		var customMethodName = "CustomErrorMethod";

		// Act
		logger.LogErrorMessage(message, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	[TestMethod]
	public void LogExceptionMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Exception occurred.";
		var exception = new Exception("Exception details");

		// Act
		this._logger.LogExceptionMessage(message: message, exception: exception);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogExceptionMessage_WithMockLogger_LogsAtErrorLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Exception occurred.";
		var exception = new Exception("Exception details");

		// Act
		logger.LogExceptionMessage(message, exception);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Error), "Should log at Error level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(message)), "Should contain the message.");
	}

	[TestMethod]
	public void LogExceptionMessage_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Exception occurred.";
		var exception = new Exception("Exception details");
		var customMethodName = "CustomExceptionMethod";

		// Act
		logger.LogExceptionMessage(message, exception, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	[TestMethod]
	public void LogInformationMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Information message.";

		// Act
		this._logger.LogInformationMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogInformationMessage_WithMockLogger_LogsAtInformationLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Information message.";

		// Act
		logger.LogInformationMessage(message);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Information), "Should log at Information level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(message)), "Should contain the message.");
	}

	[TestMethod]
	public void LogInformationMessage_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Information message.";
		var customMethodName = "CustomInformationMethod";

		// Act
		logger.LogInformationMessage(message, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	[TestMethod]
	public void LogStoredProcedureError_ValidParameters_LogsMessage()
	{
		// Arrange
		var storedProcedure = "sp_GetData";
		var exception = new Exception("Stored procedure exception");

		// Act
		this._logger.LogStoredProcedureError(storedProcedure, exception);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogStoredProcedureError_WithMockLogger_LogsAtErrorLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var storedProcedure = "sp_GetData";
		var exception = new Exception("Stored procedure exception");

		// Act
		logger.LogStoredProcedureError(storedProcedure, exception);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Error), "Should log at Error level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(storedProcedure)), "Should contain the stored procedure name.");
	}

	[TestMethod]
	public void LogStoredProcedureError_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var storedProcedure = "sp_GetData";
		var exception = new Exception("Stored procedure exception");
		var customMethodName = "CustomStoredProcMethod";

		// Act
		logger.LogStoredProcedureError(storedProcedure, exception, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	[TestMethod]
	public void LogStoredProcedureNoRecordsFound_ValidParameters_LogsMessage()
	{
		// Arrange
		var storedProcedure = "sp_GetData";

		// Act
		this._logger.LogStoredProcedureNoRecordsFound(storedProcedure);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogStoredProcedureNoRecordsFound_WithMockLogger_LogsAtErrorLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var storedProcedure = "sp_GetData";

		// Act
		logger.LogStoredProcedureNoRecordsFound(storedProcedure);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Error), "Should log at Error level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(storedProcedure)), "Should contain the stored procedure name.");
	}

	[TestMethod]
	public void LogStoredProcedureNoRecordsFound_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var storedProcedure = "sp_GetData";
		var customMethodName = "CustomNoRecordsMethod";

		// Act
		logger.LogStoredProcedureNoRecordsFound(storedProcedure, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	[TestMethod]
	public void LogTraceMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Trace message.";

		// Act
		this._logger.LogTraceMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogTraceMessage_WithMockLogger_LogsAtTraceLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Trace message.";

		// Act
		logger.LogTraceMessage(message);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Trace), "Should log at Trace level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(message)), "Should contain the message.");
	}

	[TestMethod]
	public void LogTraceMessage_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Trace message.";
		var customMethodName = "CustomTraceMethod";

		// Act
		logger.LogTraceMessage(message, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	[TestMethod]
	public void LogWarningMessage_ValidParameters_LogsMessage()
	{
		// Arrange
		var message = "Warning message.";

		// Act
		this._logger.LogWarningMessage(message);

		// Assert
		// No exception means the test passes
	}

	[TestMethod]
	public void LogWarningMessage_WithMockLogger_LogsAtWarningLevel()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Warning message.";

		// Act
		logger.LogWarningMessage(message);

		// Assert
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Warning), "Should log at Warning level.");
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(message)), "Should contain the message.");
	}

	[TestMethod]
	public void LogWarningMessage_WithCustomMethodName_IncludesMethodNameInMessage()
	{
		// Arrange
		var logger = new MockLogger();
		var message = "Warning message.";
		var customMethodName = "CustomWarningMethod";

		// Act
		logger.LogWarningMessage(message, customMethodName);

		// Assert
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains(customMethodName)), "Should contain the custom method name.");
	}

	public FastLoggerExtensionsTests()
	{
		this._logger = new NullLogger<FastLoggerExtensionsTests>();
	}
}
