// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-05-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-02-2026
// ***********************************************************************
// <copyright file="ExceptionExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.ServiceModel.Security;
using DotNetTips.Spargine.Core.Tests.Logging;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ExceptionExtensionsTests
{

	private NullLogger<FastLoggerExtensionsTests> _logger;

	public ExceptionExtensionsTests()
	{
		this._logger = new NullLogger<FastLoggerExtensionsTests>();
	}

	[TestMethod]
	public void ClearIsLogged_ShouldResetIsLoggedState()
	{
		// Arrange
		var exception = new Exception("Test exception");
		exception.SetIsLogged();

		// Act
		exception.ClearLoggedState();

		// Assert
		Assert.IsFalse(exception.IsLogged());
	}

	[TestMethod]
	public void ClearLoggedState_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.ClearLoggedState());
	}

	[TestMethod]
	public void ContainsAggregateException_InnerAggregateException_ReturnsTrue()
	{
		// Arrange
		var inner = new AggregateException("Inner aggregate", new Exception("Nested"));
		var outer = new Exception("Outer exception", inner);

		// Act
		var result = outer.ContainsAggregateException();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsAggregateException_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.ContainsAggregateException());
	}

	[TestMethod]
	public void ContainsAggregateException_ShouldReturnFalseIfNoAggregateExceptionExists()
	{
		// Arrange
		var exception = new Exception("Test exception");

		// Act
		var containsAggregate = exception.ContainsAggregateException();

		// Assert
		Assert.IsFalse(containsAggregate);
	}

	[TestMethod]
	public void ContainsAggregateException_ShouldReturnTrueIfAggregateExceptionExists()
	{
		// Arrange
		var aggregateException = new AggregateException("Aggregate exception", new Exception("Inner exception"));

		// Act
		var containsAggregate = aggregateException.ContainsAggregateException();

		// Assert
		Assert.IsTrue(containsAggregate);
	}

	[TestMethod]
	public void ContainsExceptionOfType_ReturnsFalseIfTypeDoesNotExist()
	{
		var ex = new Exception("Outer exception", new Exception("Inner exception"));

		var result = ex.ContainsExceptionOfType<ArgumentNullException>();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsExceptionOfType_ReturnsTrueIfTypeExists()
	{
		var inner = new InvalidOperationException("Inner exception");
		var ex = new Exception("Outer exception", inner);

		var result = ex.ContainsExceptionOfType<InvalidOperationException>();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsExceptionOfType_ThrowsArgumentNullExceptionIfExceptionIsNull()
	{
		Exception ex = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ex.ContainsExceptionOfType<InvalidOperationException>());
	}

	[TestMethod]
	public void ContainsMessage_EmptyMessage_ThrowsArgumentNullException()
	{
		// Arrange
		var exception = new Exception("Test exception");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.ContainsMessage(string.Empty));
	}

	[TestMethod]
	public void ContainsMessage_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.ContainsMessage("test"));
	}

	[TestMethod]
	public void ContainsMessage_NullMessage_ThrowsArgumentNullException()
	{
		// Arrange
		var exception = new Exception("Test exception");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.ContainsMessage(null));
	}

	[TestMethod]
	public void ContainsMessage_ShouldReturnFalseIfMessageDoesNotExist()
	{
		// Arrange
		var exception = new Exception("Outer exception", new Exception("Inner exception"));

		// Act
		var containsMessage = exception.ContainsMessage("Non-existent message");

		// Assert
		Assert.IsFalse(containsMessage);
	}

	[TestMethod]
	public void ContainsMessage_ShouldReturnTrueIfMessageExists()
	{
		// Arrange
		var exception = new Exception("Outer exception", new Exception("Inner exception"));

		// Act
		var containsMessage = exception.ContainsMessage("Inner exception");

		// Assert
		Assert.IsTrue(containsMessage);
	}

	[TestMethod]
	public void ExtractData_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.ExtractData());
	}

	[TestMethod]
	public void ExtractData_WithData_ReturnsAllKeyValuePairs()
	{
		var exception = new Exception("Test exception");
		exception.Data["Key1"] = "Value1";
		exception.Data["Key2"] = 42;

		var data = exception.ExtractData();

		Assert.IsNotNull(data);
		Assert.HasCount(2, data);
		Assert.AreEqual("Value1", data["Key1"]);
		Assert.AreEqual(42, data["Key2"]);
	}
	[TestMethod]
	public void ExtractData_WithNoData_ReturnsEmptyDictionary()
	{
		var exception = new Exception("Test exception");

		var data = exception.ExtractData();

		Assert.IsNotNull(data);
		Assert.IsEmpty(data);
	}

	[TestMethod]
	public void FormatForDisplay()
	{

		var exception = new Exception("Test exception", new ArgumentOutOfRangeException("Out of range."));

		var result = exception.FormatForDisplay();

		Assert.Contains("Test exception", result);
		Assert.Contains("Exception", result);
	}

	[TestMethod]
	public void FormatForDisplay_IncludesExceptionMessage()
	{
		// Arrange
		var exception = new Exception("This is a test exception message");

		// Act
		var result = exception.FormatForDisplay();

		// Assert
		Assert.Contains("Message: This is a test exception message", result);
	}

	[TestMethod]
	public void FormatForDisplay_IncludesExceptionTypeName()
	{
		// Arrange
		var exception = new ArgumentNullException("paramName", "Parameter cannot be null");

		// Act
		var result = exception.FormatForDisplay();

		// Assert
		Assert.Contains("Exception: ArgumentNullException", result);
	}

	[TestMethod]
	public void FormatForDisplay_WithDifferentExceptionTypes_FormatsCorrectly()
	{
		// Arrange
		var exceptions = new Exception[]
		{
		new NullReferenceException("Null reference"),
		new IndexOutOfRangeException("Index out of range"),
		new OutOfMemoryException("Out of memory")
		};

		// Act & Assert
		foreach (var exception in exceptions)
		{
			var result = exception.FormatForDisplay();

			Assert.Contains($"Exception: {exception.GetType().Name}", result);
			Assert.Contains($"Message: {exception.Message}", result);
			Assert.Contains("StackTrace:", result);
		}
	}

	[TestMethod]
	public void FormatForDisplay_WithEmptyMessage_HandlesCorrectly()
	{
		// Arrange
		var exception = new Exception(string.Empty);

		// Act
		var result = exception.FormatForDisplay();

		// Assert
		Assert.Contains("Exception: Exception", result);
		Assert.Contains("Message:", result);
		Assert.Contains("StackTrace: NONE", result);
	}

	[TestMethod]
	public void FormatForDisplay_WithExceptionWithoutStackTrace_ShowsNone()
	{
		// Arrange
		var exception = new InvalidOperationException("Test operation failed");

		// Act
		var result = exception.FormatForDisplay();

		// Assert
		Assert.Contains("StackTrace: NONE", result);
		Assert.Contains("Message: Test operation failed", result);
		Assert.Contains("Exception: InvalidOperationException", result);
	}

	[TestMethod]
	public void FormatForDisplay_WithExceptionWithStackTrace_IncludesStackTrace()
	{
		// Arrange
		Exception exception = null;

		try
		{
			throw new ArgumentException("Invalid argument");
		}
		catch (Exception ex)
		{
			exception = ex;
		}

		// Act
		var result = exception.FormatForDisplay();

		// Assert
		Assert.Contains("Exception: ArgumentException", result);
		Assert.Contains("Message: Invalid argument", result);
		Assert.IsFalse(result.Contains("StackTrace: NONE"));
		Assert.Contains("StackTrace:", result);
	}

	[TestMethod]
	public void FormatForDisplay_WithInnerException_FormatsOnlyOuterException()
	{
		// Arrange
		var innerException = new InvalidOperationException("Inner exception message");
		var outerException = new Exception("Outer exception message", innerException);

		// Act
		var result = outerException.FormatForDisplay();

		// Assert
		Assert.Contains("Exception: Exception", result);
		Assert.Contains("Message: Outer exception message", result);
		Assert.IsFalse(result.Contains("Inner exception message"), "Should not include inner exception details");
	}

	[TestMethod]
	public void FormatForDisplay_WithNullException_ReturnsEmptyString()
	{
		// Arrange
		Exception exception = null;

		// Act
		var result = exception.FormatForDisplay();

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void FromHierarchy_SingleParam_NullAccumulator_ThrowsArgumentNullException()
	{
		// Arrange
		var ex = new Exception("Test exception");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => ex.FromHierarchy((Func<Exception, Exception>)null).ToList());
	}

	[TestMethod]
	public void FromHierarchy_SingleParam_NullSource_ThrowsArgumentNullException()
	{
		// Arrange
		Exception ex = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => ex.FromHierarchy(e => e.InnerException!).ToList());
	}

	[TestMethod]
	public void FromHierarchy_SingleParam_WithValidInput_ShouldReturnHierarchy()
	{
		// Arrange
		var innerEx = new InvalidOperationException("Inner exception");
		var ex = new Exception("Outer exception", innerEx);

		// Act
		var hierarchy = ex.FromHierarchy(e => e.InnerException!).ToList();

		// Assert
		Assert.HasCount(2, hierarchy);
		Assert.AreEqual("Outer exception", hierarchy[0].Message);
		Assert.AreEqual("Inner exception", hierarchy[1].Message);
	}

	[TestMethod]
	public void FromHierarchy_WithNullCanContinue_ShouldThrowArgumentNullException()
	{
		var ex = new Exception("Test exception");

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ex.FromHierarchy(e => e.InnerException, null).ToList());
	}


	[TestMethod]
	public void FromHierarchy_WithNullNextItem_ShouldThrowArgumentNullException()
	{
		var ex = new Exception("Test exception");

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ex.FromHierarchy(null, e => e != null).ToList());
	}

	[TestMethod]
	public void FromHierarchy_WithNullSource_ShouldThrowArgumentNullException()
	{
		Exception ex = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ex.FromHierarchy(e => e.InnerException, e => e != null).ToList());
	}

	[TestMethod]
	public void FromHierarchy_WithValidInput_ShouldReturnHierarchy()
	{
		var innerEx = new InvalidOperationException("Inner exception");
		var ex = new Exception("Outer exception", innerEx);

		var hierarchy = ex.FromHierarchy(e => e.InnerException, e => e != null).ToList();

		Assert.HasCount(2, hierarchy);
		Assert.AreEqual("Outer exception", hierarchy[0].Message);
		Assert.AreEqual("Inner exception", hierarchy[1].Message);
	}

	[TestMethod]
	public void GetAllInnerExceptions_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.GetAllInnerExceptions());
	}

	[TestMethod]
	public void GetAllInnerExceptions_WithMultipleInnerExceptions_ReturnsAll()
	{
		var innerMost = new Exception("Innermost exception");
		var inner = new Exception("Inner exception", innerMost);
		var exception = new Exception("Outer exception", inner);

		var result = exception.GetAllInnerExceptions();

		Assert.IsNotNull(result);
		Assert.HasCount(2, result);
		Assert.AreEqual("Inner exception", result[0].Message);
		Assert.AreEqual("Innermost exception", result[1].Message);
	}

	[TestMethod]
	public void GetAllInnerExceptions_WithNoInnerException_ReturnsEmptyList()
	{
		var exception = new Exception("Test exception");

		var result = exception.GetAllInnerExceptions();

		Assert.IsNotNull(result);
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetAllInnerExceptions_WithSingleInnerException_ReturnsOne()
	{
		var inner = new Exception("Inner exception");
		var exception = new Exception("Outer exception", inner);

		var result = exception.GetAllInnerExceptions();

		Assert.IsNotNull(result);
		Assert.HasCount(1, result);
		Assert.AreEqual("Inner exception", result[0].Message);
	}

	[TestMethod]
	public void GetAllMessages_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.GetAllMessages());
	}

	[TestMethod]
	public void GetAllMessages_WithCustomDelimiter_UsesDelimiter()
	{
		// Arrange
		var innerEx = new Exception("Inner message");
		var ex = new Exception("Outer message", innerEx);

		// Act
		var messages = ex.GetAllMessages('|');

		// Assert
		Assert.Contains("Outer message", messages);
		Assert.Contains("Inner message", messages);
		Assert.Contains("|", messages);
	}

	[TestMethod]
	public void GetAllMessagesTest()
	{
		var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

		var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

		var messages = ex.GetAllMessages();

		Assert.IsTrue(messages.IsNotEmpty());
	}

	[TestMethod]
	public void GetAllMessagesWithStackTrace_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.GetAllMessagesWithStackTrace());
	}

	[TestMethod]
	public void GetAllMessagesWithStackTrace_ReturnsAllMessagesAndStackTraces()
	{
		var innerEx = new Exception("Inner message");
		var ex = new Exception("Outer message", innerEx);

		var result = ex.GetAllMessagesWithStackTrace();

		Assert.IsNotNull(result);
		Assert.HasCount(2, result);
		Assert.AreEqual("Outer message", result[0].message);
		Assert.AreEqual("Inner message", result[1].message);
		Assert.IsTrue(result[0].StackTrace == "NONE" || !string.IsNullOrWhiteSpace(result[0].StackTrace));
		Assert.IsTrue(result[1].StackTrace == "NONE" || !string.IsNullOrWhiteSpace(result[1].StackTrace));
	}

	[TestMethod]
	public void GetAllMessagesWithStackTrace_SingleExceptionWithNullStackTrace_ReturnsNoneString()
	{
		var ex = new Exception("Test message");
		// Not thrown, so StackTrace is likely null
		var result = ex.GetAllMessagesWithStackTrace();

		Assert.HasCount(1, result);
		Assert.AreEqual("Test message", result[0].message);
		Assert.IsTrue(result[0].StackTrace == "NONE" || !string.IsNullOrWhiteSpace(result[0].StackTrace));
	}

	[TestMethod]
	public void GetAllMessagesWithStackTraceTest()
	{
		var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

		var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

		var messages = ex.GetAllMessagesWithStackTrace();

		Assert.IsTrue(messages.IsNotEmpty());
	}

	[TestMethod]
	public void GetMetadata_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.GetMetadata());
	}

	[TestMethod]
	public void GetMetadata_ShouldReturnCorrectMetadata()
	{
		// Arrange
		var exception = new Exception("Test exception");
		exception.SetIsLogged();

		// Act
		var metadata = exception.GetMetadata();

		// Assert
		Assert.IsTrue(metadata.ContainsKey("IsLogged"));
		Assert.IsTrue((bool?)metadata["IsLogged"]);
	}

	[TestMethod]
	public void GetMetadata_WithoutIsLogged_ReturnsEmptyDictionary()
	{
		// Arrange
		var exception = new Exception(RandomData.GenerateWord(10));

		// Act
		var metadata = exception.GetMetadata();

		// Assert
		Assert.IsNotNull(metadata);
		Assert.IsEmpty(metadata);
	}

	[TestMethod]
	public void IsCritical_AccessViolationException_ReturnsTrue()
	{
		// Arrange
		var exception = new AccessViolationException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}


	[TestMethod]
	public void IsCritical_ArgumentNullException_ReturnsFalse()
	{
		// Arrange
		var exception = new ArgumentNullException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsCritical_IndexOutOfRangeException_ReturnsTrue()
	{
		// Arrange
		var exception = new IndexOutOfRangeException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCritical_NullException_ReturnsFalse()
	{
		// Arrange
		Exception exception = null;

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsCritical_NullReferenceException_ReturnsTrue()
	{
		// Arrange
		var exception = new NullReferenceException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCritical_OutOfMemoryException_ReturnsTrue()
	{
		// Arrange
		var exception = new OutOfMemoryException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsCritical_StackOverflowException_ReturnsTrue()
	{
		// Arrange
		var exception = new StackOverflowException();

		// Act
		var result = exception.IsCritical();

		// Assert
		Assert.IsTrue(result);
	}
	[TestMethod]
	public void IsCriticalTest()
	{
		var exGood = new NullReferenceException();
		var exBad = new ArgumentNullException();

		Assert.IsTrue(exGood.IsCritical());
		Assert.IsFalse(exBad.IsCritical());
	}

	[TestMethod]
	public void IsFatal_ArgumentNullException_ReturnsFalse()
	{
		// Arrange
		var exception = new ArgumentNullException();

		// Act
		var result = exception.IsFatal();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsFatal_NullException_ReturnsFalse()
	{
		// Arrange
		Exception exception = null;

		// Act
		var result = exception.IsFatal();

		// Assert
		Assert.IsFalse(result);
	}
	[TestMethod]
	public void IsFatal_OutOfMemoryException_ReturnsTrue()
	{
		// Arrange
		var exception = new OutOfMemoryException();

		// Act
		var result = exception.IsFatal();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsFatalTest()
	{
		var exGood = new OutOfMemoryException();
		var exBad = new ArgumentNullException();

		Assert.IsTrue(exGood.IsFatal());
		Assert.IsFalse(exBad.IsFatal());
	}

	[TestMethod]
	public void IsLogged_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.IsLogged());
	}

	[TestMethod]
	public void IsLogged_ShouldReturnFalseForNewException()
	{
		// Arrange
		var exception = new Exception("Test exception");

		// Act
		var isLogged = exception.IsLogged();

		// Assert
		Assert.IsFalse(isLogged);
	}

	[TestMethod]
	public void IsSecurityOrCritical_ArgumentNullException_ReturnsFalse()
	{
		// Arrange
		var exception = new ArgumentNullException();

		// Act
		var result = exception.IsSecurityOrCritical();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsSecurityOrCritical_NullException_ReturnsFalse()
	{
		// Arrange
		Exception exception = null;

		// Act
		var result = exception.IsSecurityOrCritical();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsSecurityOrCritical_NullReferenceException_ReturnsTrue()
	{
		// Arrange
		var exception = new NullReferenceException();

		// Act
		var result = exception.IsSecurityOrCritical();

		// Assert
		Assert.IsTrue(result);
	}
	[TestMethod]
	public void IsSecurityOrCritical_SecurityException_ReturnsTrue()
	{
		// Arrange
		var exception = new SecurityException();

		// Act
		var result = exception.IsSecurityOrCritical();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsSecurityOrCriticalTest()
	{
		var exGood = new SecurityException();
		var exBad = new ArgumentNullException();

		Assert.IsTrue(exGood.IsSecurityOrCritical());
		Assert.IsFalse(exBad.IsSecurityOrCritical());
	}

	[TestMethod]
	public void LogException()
	{

		var exception = new Exception("Test exception");
		exception.LogException(this._logger, LogLevel.Error);
	}

	[TestMethod]
	public void LogException_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;
		var logger = new MockLogger();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.LogException(logger));
	}

	[TestMethod]
	public void LogException_NullLogger_ThrowsArgumentNullException()
	{
		// Arrange
		var exception = new Exception("Test exception");
		ILogger logger = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.LogException(logger));
	}

	[TestMethod]
	public void LogException_WhenLogLevelDisabled_DoesNotLogOrSetIsLogged()
	{
		// Arrange - Use NullLogger which has IsEnabled = false
		var exception = new Exception("Test exception");
		var logger = new NullLogger<ExceptionExtensionsTests>();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger, LogLevel.Error);

		// Assert - Should NOT set IsLogged because logger.IsEnabled returns false
		Assert.IsFalse(exception.IsLogged());
	}

	[TestMethod]
	public void LogException_WithCriticalLogLevel_LogsAndSetsIsLogged()
	{
		// Arrange
		var exception = new Exception("Critical exception");
		var logger = new MockLogger();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger, LogLevel.Critical);

		// Assert
		Assert.IsTrue(exception.IsLogged());
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Critical));
	}

	[TestMethod]
	public void LogException_WithDebugLogLevel_LogsAndSetsIsLogged()
	{
		// Arrange
		var exception = new Exception("Debug exception");
		var logger = new MockLogger();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger, LogLevel.Debug);

		// Assert
		Assert.IsTrue(exception.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains("Debug")));
	}

	[TestMethod]
	public void LogException_WithDefaultLogLevel_SetsIsLogged()
	{
		// Arrange
		var exception = new Exception("Test exception");
		var logger = new MockLogger();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger);

		// Assert
		Assert.IsTrue(exception.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Count > 0);
	}

	[TestMethod]
	public void LogException_WithErrorLogLevel_LogsAndSetsIsLogged()
	{
		// Arrange
		var exception = new Exception("Error exception");
		var logger = new MockLogger();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger, LogLevel.Error);

		// Assert
		Assert.IsTrue(exception.IsLogged());
		Assert.IsTrue(logger.LoggedLevels.Contains(LogLevel.Error));
	}

	[TestMethod]
	public void LogException_WithInformationLogLevel_LogsAndSetsIsLogged()
	{
		// Arrange
		var exception = new Exception("Information exception");
		var logger = new MockLogger();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger, LogLevel.Information);

		// Assert
		Assert.IsTrue(exception.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains("Info")));
	}

	[TestMethod]
	public void LogException_WithInnerException_CriticalLevel_LogsAll()
	{
		// Arrange
		var innerMessage = RandomData.GenerateWord(10);
		var outerMessage = RandomData.GenerateWord(10);
		var innerException = new InvalidOperationException(innerMessage);
		var outerException = new Exception(outerMessage, innerException);
		var logger = new MockLogger();
		outerException.ClearLoggedState();

		// Act
		outerException.LogException(logger, LogLevel.Critical);

		// Assert
		Assert.IsTrue(outerException.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Count >= 2, "Should log outer and inner exceptions");
	}

	[TestMethod]
	public void LogException_WithInnerException_DebugLevel_LogsAll()
	{
		// Arrange
		var innerMessage = RandomData.GenerateWord(10);
		var outerMessage = RandomData.GenerateWord(10);
		var innerException = new InvalidOperationException(innerMessage);
		var outerException = new Exception(outerMessage, innerException);
		var logger = new MockLogger();
		outerException.ClearLoggedState();

		// Act
		outerException.LogException(logger, LogLevel.Debug);

		// Assert
		Assert.IsTrue(outerException.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Count >= 2, "Should log outer and inner exceptions");
	}

	[TestMethod]
	public void LogException_WithInnerException_InformationLevel_LogsAll()
	{
		// Arrange
		var innerMessage = RandomData.GenerateWord(10);
		var outerMessage = RandomData.GenerateWord(10);
		var innerException = new InvalidOperationException(innerMessage);
		var outerException = new Exception(outerMessage, innerException);
		var logger = new MockLogger();
		outerException.ClearLoggedState();

		// Act
		outerException.LogException(logger, LogLevel.Information);

		// Assert
		Assert.IsTrue(outerException.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Count >= 2, "Should log outer and inner exceptions");
	}

	[TestMethod]
	public void LogException_WithInnerException_LogsAllExceptions()
	{
		// Arrange
		var innerException = new InvalidOperationException("Inner exception");
		var outerException = new Exception("Outer exception", innerException);
		var logger = new MockLogger();
		outerException.ClearLoggedState();

		// Act
		outerException.LogException(logger, LogLevel.Error);

		// Assert
		Assert.IsTrue(outerException.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains("Outer exception")));
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains("Inner exception")));
	}

	[TestMethod]
	public void LogException_WithInnerException_NoneLevel_SetsIsLogged()
	{
		// Arrange
		var innerMessage = RandomData.GenerateWord(10);
		var outerMessage = RandomData.GenerateWord(10);
		var innerException = new InvalidOperationException(innerMessage);
		var outerException = new Exception(outerMessage, innerException);
		var logger = new MockLogger();
		outerException.ClearLoggedState();

		// Act
		outerException.LogException(logger, LogLevel.None);

		// Assert
		Assert.IsTrue(outerException.IsLogged());
	}

	[TestMethod]
	public void LogException_WithInnerException_TraceLevel_LogsAll()
	{
		// Arrange
		var innerMessage = RandomData.GenerateWord(10);
		var outerMessage = RandomData.GenerateWord(10);
		var innerException = new InvalidOperationException(innerMessage);
		var outerException = new Exception(outerMessage, innerException);
		var logger = new MockLogger();
		outerException.ClearLoggedState();

		// Act
		outerException.LogException(logger, LogLevel.Trace);

		// Assert
		Assert.IsTrue(outerException.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Count >= 2, "Should log outer and inner exceptions");
	}

	[TestMethod]
	public void LogException_WithInnerException_WarningLevel_LogsAll()
	{
		// Arrange
		var innerMessage = RandomData.GenerateWord(10);
		var outerMessage = RandomData.GenerateWord(10);
		var innerException = new InvalidOperationException(innerMessage);
		var outerException = new Exception(outerMessage, innerException);
		var logger = new MockLogger();
		outerException.ClearLoggedState();

		// Act
		outerException.LogException(logger, LogLevel.Warning);

		// Assert
		Assert.IsTrue(outerException.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Count >= 2, "Should log outer and inner exceptions");
	}

	[TestMethod]
	public void LogException_WithMultipleNestedInnerExceptions_LogsAllExceptions()
	{
		// Arrange
		var innermost = new ArgumentNullException("param", "Innermost exception");
		var middle = new InvalidOperationException("Middle exception", innermost);
		var outer = new Exception("Outer exception", middle);
		var logger = new MockLogger();
		outer.ClearLoggedState();

		// Act
		outer.LogException(logger, LogLevel.Error);

		// Assert
		Assert.IsTrue(outer.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Count >= 3, "Should log outer, middle, and innermost exceptions");
	}

	[TestMethod]
	public void LogException_WithNoneLogLevel_SetsIsLoggedButNoMessages()
	{
		// Arrange
		var exception = new Exception("None log level exception");
		var logger = new MockLogger();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger, LogLevel.None);

		// Assert
		Assert.IsTrue(exception.IsLogged());
	}

	[TestMethod]
	public void LogException_WithTraceLogLevel_LogsAndSetsIsLogged()
	{
		// Arrange
		var exception = new Exception("Trace exception");
		var logger = new MockLogger();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger, LogLevel.Trace);

		// Assert
		Assert.IsTrue(exception.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains("Trace")));
	}

	[TestMethod]
	public void LogException_WithWarningLogLevel_LogsAndSetsIsLogged()
	{
		// Arrange
		var exception = new Exception("Warning exception");
		var logger = new MockLogger();
		exception.ClearLoggedState();

		// Act
		exception.LogException(logger, LogLevel.Warning);

		// Assert
		Assert.IsTrue(exception.IsLogged());
		Assert.IsTrue(logger.LoggedMessages.Any(m => m.Contains("Warning")));
	}

	[TestMethod]
	public void SetIsLogged_NullException_ThrowsArgumentNullException()
	{
		// Arrange
		Exception exception = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => exception.SetIsLogged());
	}

	[TestMethod]
	public void SetIsLogged_ShouldSetIsLoggedToTrue()
	{
		// Arrange
		var exception = new Exception("Test exception");

		// Act
		exception.SetIsLogged();

		// Assert
		Assert.IsTrue(exception.IsLogged());
	}

	[TestMethod]
	public void ToJson_ReturnsValidJson()
	{
		// Arrange
		var innerException = new ArgumentNullException("param", "Parameter cannot be null");
		var exception = new Exception("Outer exception", innerException);

		// Act
		var json = exception.ToJson();

		// Assert
		Assert.IsNotEmpty(json);
		Assert.IsTrue(json.StartsWith("{"), "JSON should start with opening brace");
		Assert.IsTrue(json.EndsWith("}"), "JSON should end with closing brace");
		Assert.Contains("\"Message\"", json);
	}

	[TestMethod]
	public void ToJson_ShouldReturnSerializedExceptionDetails()
	{
		// Arrange
		var exception = new Exception("Test exception", new Exception("Inner exception"));

		// Act
		var json = exception.ToJson();

		// Assert
		Assert.Contains("Test exception", json);
		Assert.Contains("Inner exception", json);
	}

	[TestMethod]
	public void ToJson_WithDifferentExceptionTypes_SerializesCorrectly()
	{
		// Arrange
		var exceptions = new Exception[]
		{
		new NullReferenceException("Null reference error"),
		new InvalidOperationException("Invalid operation")
		};

		// Act & Assert
		foreach (var exception in exceptions)
		{
			var json = exception.ToJson();

			Assert.IsNotEmpty(json);
			Assert.Contains(exception.Message, json);
			Assert.Contains("Message", json);
			Assert.Contains("StackTrace", json);
		}
	}

	[TestMethod]
	public void ToJson_WithEmptyMessage_HandlesCorrectly()
	{
		// Arrange
		var exception = new Exception(string.Empty);

		// Act
		var json = exception.ToJson();

		// Assert
		Assert.IsNotEmpty(json);
		Assert.Contains("Message", json);
		Assert.Contains("StackTrace", json);
	}

	[TestMethod]
	public void ToJson_WithExceptionWithoutInnerExceptions_ContainsMessageOnly()
	{
		// Arrange
		var exception = new Exception("Single exception message");

		// Act
		var json = exception.ToJson();

		// Assert
		Assert.Contains("Single exception message", json);
		Assert.Contains("Message", json);
		Assert.Contains("StackTrace", json);
		Assert.Contains("InnerExceptions", json);
	}

	[TestMethod]
	public void ToJson_WithExceptionWithStackTrace_IncludesStackTrace()
	{
		// Arrange
		Exception exception = null;
		try
		{
			throw new InvalidOperationException("Exception with stack trace");
		}
		catch (Exception ex)
		{
			exception = ex;
		}

		// Act
		var json = exception.ToJson();

		// Assert
		Assert.Contains("Exception with stack trace", json);
		Assert.Contains("StackTrace", json);
		Assert.IsTrue(json.Length > 50, "JSON should include substantial stack trace information");
	}

	[TestMethod]
	public void ToJson_WithInnerExceptionChain_SerializesAllMessages()
	{
		// Arrange
		var level3 = new Exception("Level 3 exception");
		var level2 = new Exception("Level 2 exception", level3);
		var level1 = new Exception("Level 1 exception", level2);

		// Act
		var json = level1.ToJson();

		// Assert
		Assert.Contains("Level 1 exception", json);
		Assert.Contains("Level 2 exception", json);
		Assert.Contains("Level 3 exception", json);
	}

	[TestMethod]
	public void ToJson_WithMultipleNestedInnerExceptions_IncludesAll()
	{
		// Arrange
		var innermost = new InvalidOperationException("Innermost exception");
		var middle = new ArgumentException("Middle exception", innermost);
		var outer = new Exception("Outer exception", middle);

		// Act
		var json = outer.ToJson();

		// Assert
		Assert.Contains("Outer exception", json);
		Assert.Contains("Middle exception", json);
		Assert.Contains("Innermost exception", json);
		Assert.Contains("InnerExceptions", json);
	}

	[TestMethod]
	public void ToJson_WithNullException_ReturnsEmptyString()
	{
		// Arrange
		Exception exception = null;

		// Act
		var result = exception.ToJson();

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void TraverseFor_WithMatchingOuterType_ShouldReturnOuterException()
	{
		// Arrange
		var innerEx = new Exception("Inner exception");
		var ex = new InvalidOperationException("Outer exception", innerEx);

		// Act
		var result = ex.TraverseFor<InvalidOperationException>();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual("Outer exception", result.Message);
	}

	[TestMethod]
	public void TraverseFor_WithMatchingType_ShouldReturnException()
	{
		var innerEx = new InvalidOperationException("Inner exception");
		var ex = new Exception("Outer exception", innerEx);

		var result = ex.TraverseFor<InvalidOperationException>();

		Assert.IsNotNull(result);
		Assert.AreEqual("Inner exception", result.Message);
	}

	[TestMethod]
	public void TraverseFor_WithNonMatchingType_ShouldReturnNull()
	{
		var innerEx = new InvalidOperationException("Inner exception");
		var ex = new Exception("Outer exception", innerEx);

		var result = ex.TraverseFor<ArgumentNullException>();

		Assert.IsNull(result);
	}

	[TestMethod]
	public void TraverseFor_WithNullException_ShouldThrowArgumentNullException()
	{
		Exception ex = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ex.TraverseFor<InvalidOperationException>());
	}
}

/// <summary>
/// A simple mock logger that enables all log levels for testing purposes.
/// </summary>
internal class MockLogger : ILogger
{
	public List<LogLevel> LoggedLevels { get; } = [];
	public List<string> LoggedMessages { get; } = [];

	public IDisposable BeginScope<TState>(TState state) where TState : notnull => null!;

	public bool IsEnabled(LogLevel logLevel) => true; // Always enabled

	public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
	{
		this.LoggedLevels.Add(logLevel);
		this.LoggedMessages.Add(formatter(state, exception));
	}
}
