// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-05-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="ExceptionExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.ServiceModel.Security;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Tests.Logging;
using DotNetTips.Spargine.Extensions;
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

	[TestMethod]
	public void ClearIsLogged_ShouldResetIsLoggedState()
	{
		// Arrange
		var exception = new Exception("Test exception");
		exception.SetIsLogged();

		// Act
		exception.ClearIsLogged();

		// Assert
		Assert.IsFalse(exception.IsLogged());
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
	public void GetAllMessagesTest()
	{
		var innerEx = new SecurityException("Message from SecurityException", new DataMisalignedException("Cannot access service!"));

		var ex = new SecurityAccessDeniedException("Message from SecurityAccessDeniedException", innerEx);

		var messages = ex.GetAllMessages();

		Assert.IsTrue(messages.IsNotEmpty());
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
	public void SetIsLogged_ShouldSetIsLoggedToTrue()
	{
		// Arrange
		var exception = new Exception("Test exception");

		// Act
		exception.SetIsLogged();

		// Assert
		Assert.IsTrue(exception.IsLogged());
	}

	public ExceptionExtensionsTests()
	{
		this._logger = new NullLogger<FastLoggerExtensionsTests>();
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
