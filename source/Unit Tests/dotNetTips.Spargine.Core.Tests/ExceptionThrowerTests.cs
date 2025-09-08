// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 07-21-2025
// ***********************************************************************
// <copyright file="ExceptionThrowerTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.Json;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ExceptionThrowerTests
{

	[TestMethod]
	public void CreateFileNotFoundException_WithFileName_SetsFileNameAndDefaultMessage()
	{
		// Arrange
		var fileName = "missing.txt";

		// Act
		var ex = ExceptionThrower.CreateFileNotFoundException(fileName);

		// Assert
		Assert.IsNotNull(ex);
		Assert.AreEqual(fileName, ex.FileName);
		Assert.IsFalse(string.IsNullOrWhiteSpace(ex.Message));
	}

	[TestMethod]
	public void CreateFileNotFoundException_WithMessageAndFileName_SetsProperties()
	{
		// Arrange
		var fileName = "missing.txt";
		var message = "Custom not found message.";

		// Act
		var ex = ExceptionThrower.CreateFileNotFoundException(message, fileName);

		// Assert
		Assert.IsNotNull(ex);
		Assert.AreEqual(fileName, ex.FileName);
		Assert.AreEqual(message, ex.Message);
	}
	[TestMethod]
	public void CreateFileNotFoundException_WithMessageFileNameAndInnerException_SetsAllProperties()
	{
		// Arrange
		var fileName = "missing.txt";
		var message = "Custom not found message.";
		var inner = new InvalidOperationException("Inner");

		// Act
		var ex = ExceptionThrower.CreateFileNotFoundException(message, fileName, inner);

		// Assert
		Assert.IsNotNull(ex);
		Assert.AreEqual(fileName, ex.FileName);
		Assert.AreEqual(message, ex.Message);
		Assert.AreEqual(inner, ex.InnerException);
	}

	[TestMethod]
	public void CreateFileNotFoundException_WithNullMessage_UsesDefaultMessage()
	{
		// Arrange
		var fileName = "missing.txt";
		var inner = new InvalidOperationException("Inner");

		// Act
		var ex = ExceptionThrower.CreateFileNotFoundException(null, fileName, inner);

		// Assert
		Assert.IsNotNull(ex);
		Assert.AreEqual(fileName, ex.FileName);
		Assert.IsFalse(string.IsNullOrWhiteSpace(ex.Message));
		Assert.AreEqual(inner, ex.InnerException);
	}

	[TestMethod]
	public void CreateFileNotFoundException_WithNullMessageAndInnerException_UsesDefaultMessage()
	{
		// Arrange
		var fileName = "missing.txt";
		var inner = new InvalidOperationException("Inner");

		// Act
		var ex = ExceptionThrower.CreateFileNotFoundException(null, fileName, inner);

		// Assert
		Assert.IsNotNull(ex);
		Assert.AreEqual(fileName, ex.FileName);
		Assert.IsFalse(string.IsNullOrWhiteSpace(ex.Message));
		Assert.AreEqual(inner, ex.InnerException);
	}

	[TestMethod]
	public void DefaultIfNull_NonNullValue_ReturnsOriginalValue()
	{
		// Arrange
		string value = "original";
		string defaultValue = "default";

		// Act
		var result = value.DefaultIfNull(defaultValue);

		// Assert
		Assert.AreEqual(value, result);
	}
	[TestMethod]
	public void DefaultIfNull_NullValue_ReturnsDefaultValue()
	{
		// Arrange
		string value = null;
		string defaultValue = "default";

		// Act
		var result = value.DefaultIfNull(defaultValue);

		// Assert
		Assert.AreEqual(defaultValue, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void ThrowArgumentException_WithInnerException_ThrowsArgumentException()
	{
		// Act
		ExceptionThrower.ThrowArgumentException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void ThrowArgumentException_WithMessage_ThrowsArgumentException()
	{
		// Act
		ExceptionThrower.ThrowArgumentException("Test message", "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ThrowArgumentInvalidException_WithInnerException_ThrowsArgumentInvalidException()
	{
		// Act
		ExceptionThrower.ThrowArgumentInvalidException("Test message", "paramName", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ThrowArgumentInvalidException_WithMessage_ThrowsArgumentInvalidException()
	{
		// Act
		ExceptionThrower.ThrowArgumentInvalidException("Test message", "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ThrowArgumentInvalidException_WithNullMessage_ThrowsArgumentInvalidException()
	{
		ExceptionThrower.ThrowArgumentInvalidException(null, "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ThrowArgumentInvalidException_WithNullMessageAndInnerException_ThrowsArgumentInvalidException()
	{
		ExceptionThrower.ThrowArgumentInvalidException(null, "paramName", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ThrowArgumentNullException_WithInnerException_ThrowsArgumentNullException()
	{
		// Act
		ExceptionThrower.ThrowArgumentNullException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ThrowArgumentNullException_WithMessage_ThrowsArgumentNullException()
	{
		// Act
		ExceptionThrower.ThrowArgumentNullException("Test message", "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ThrowArgumentNullException_WithNullMessage_ThrowsArgumentNullException()
	{
		ExceptionThrower.ThrowArgumentNullException(null, "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ThrowArgumentNullException_WithParamName_ThrowsArgumentNullException()
	{
		// Act
		ExceptionThrower.ThrowArgumentNullException("paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void ThrowArgumentOutOfRangeException_WithInnerException_ThrowsArgumentOutOfRangeException()
	{
		// Act
		ExceptionThrower.ThrowArgumentOutOfRangeException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void ThrowArgumentOutOfRangeException_WithMessage_ThrowsArgumentOutOfRangeException()
	{
		// Act
		ExceptionThrower.ThrowArgumentOutOfRangeException("Test message", "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void ThrowArgumentOutOfRangeException_WithNullMessage_ThrowsArgumentOutOfRangeException()
	{
		ExceptionThrower.ThrowArgumentOutOfRangeException(null, "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void ThrowArgumentOutOfRangeException_WithParamName_ThrowsArgumentOutOfRangeException()
	{
		// Act
		ExceptionThrower.ThrowArgumentOutOfRangeException("paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentReadOnlyException))]
	public void ThrowArgumentReadOnlyException_WithMessage_ThrowsArgumentReadOnlyException()
	{
		// Act
		ExceptionThrower.ThrowArgumentReadOnlyException("Test message", "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentReadOnlyException))]
	public void ThrowArgumentReadOnlyException_WithNullMessage_ThrowsArgumentReadOnlyException()
	{
		ExceptionThrower.ThrowArgumentReadOnlyException(null, "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ThrowDirectoryNotFoundException_WithInnerException_ThrowsArgumentInvalidException()
	{
		ExceptionThrower.ThrowDirectoryNotFoundException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(DirectoryNotFoundException))]
	public void ThrowDirectoryNotFoundException_WithMessage_ThrowsDirectoryNotFoundException()
	{
		// Act
		ExceptionThrower.ThrowDirectoryNotFoundException("Test message", new DirectoryInfo("nonexistent"));
	}

	[TestMethod]
	[ExpectedException(typeof(DirectoryNotFoundException))]
	public void ThrowDirectoryNotFoundException_WithNullMessage_ThrowsDirectoryNotFoundException()
	{
		ExceptionThrower.ThrowDirectoryNotFoundException(null, new DirectoryInfo("nonexistent"));
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void ThrowFileNotFoundException_WithInnerException_ThrowsFileNotFoundException()
	{
		// Act
		ExceptionThrower.ThrowFileNotFoundException("Test message", "nonexistent.txt", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void ThrowFileNotFoundException_WithMessage_ThrowsFileNotFoundException()
	{
		// Act
		ExceptionThrower.ThrowFileNotFoundException("Test message", "nonexistent.txt");
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void ThrowFileNotFoundException_WithNullInnerException_ThrowsFileNotFoundException()
	{
		// Act
		ExceptionThrower.ThrowFileNotFoundException("Test message", (Exception)null);
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void ThrowFileNotFoundException_WithNullMessage_ThrowsFileNotFoundException()
	{
		// Act
		ExceptionThrower.ThrowFileNotFoundException(null, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(FileNotFoundException))]
	public void ThrowFileNotFoundException_WithNullMessageAndInnerException_ThrowsFileNotFoundException()
	{
		// Act
		ExceptionThrower.ThrowFileNotFoundException(null, (Exception)null);
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidCastException))]
	public void ThrowInvalidCastException_WithInnerException_ThrowsInvalidCastException()
	{
		// Act
		ExceptionThrower.ThrowInvalidCastException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidCastException))]
	public void ThrowInvalidCastException_WithMessage_ThrowsInvalidCastException()
	{
		// Act
		ExceptionThrower.ThrowInvalidCastException("Test message", "paramName");
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidEnumTypeException))]
	public void ThrowInvalidEnumTypeException_WithMessage_ThrowsInvalidEnumTypeException()
	{
		// Act
		ExceptionThrower.ThrowInvalidEnumTypeException("Test message");
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidEnumTypeException))]
	public void ThrowInvalidEnumTypeException_WithNullMessage_ThrowsInvalidEnumTypeException()
	{
		ExceptionThrower.ThrowInvalidEnumTypeException(null);
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidCastException))]
	public void ThrowInvalidEnumTypeException_WithNullMessageAndInnerException_ThrowsInvalidCastException()
	{
		ExceptionThrower.ThrowInvalidEnumTypeException(null, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidOperationException))]
	public void ThrowInvalidOperationException_WithInnerException_ThrowsInvalidOperationException()
	{
		// Act
		ExceptionThrower.ThrowInvalidOperationException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidOperationException))]
	public void ThrowInvalidOperationException_WithMessage_ThrowsInvalidOperationException()
	{
		// Act
		ExceptionThrower.ThrowInvalidOperationException("Test message");
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidOperationException))]
	public void ThrowInvalidOperationException_WithNullMessage_ThrowsInvalidOperationException()
	{
		ExceptionThrower.ThrowInvalidOperationException(null);
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidOperationException))]
	public void ThrowInvalidOperationException_WithNullMessageAndInnerException_ThrowsInvalidOperationException()
	{
		ExceptionThrower.ThrowInvalidOperationException(null, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidValueException<int>))]
	public void ThrowInvalidValueException_WithInnerException_ThrowsInvalidValueException()
	{
		// Act
		ExceptionThrower.ThrowInvalidValueException("Test message", 42, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidValueException<int>))]
	public void ThrowInvalidValueException_WithMessage_ThrowsInvalidValueException()
	{
		// Act
		ExceptionThrower.ThrowInvalidValueException("Test message", 42);
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidValueException<int>))]
	public void ThrowInvalidValueException_WithNullMessage_ThrowsInvalidValueException()
	{
		ExceptionThrower.ThrowInvalidValueException<int>(null, 42);
	}

	[TestMethod]
	[ExpectedException(typeof(InvalidValueException<int>))]
	public void ThrowInvalidValueException_WithNullMessageAndInnerException_ThrowsInvalidValueException()
	{
		ExceptionThrower.ThrowInvalidValueException<int>(null, 42, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(IOException))]
	public void ThrowIOException_WithInnerException_ThrowsIOException()
	{
		// Act
		ExceptionThrower.ThrowIOException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(IOException))]
	public void ThrowIOException_WithMessage_ThrowsIOException()
	{
		// Act
		ExceptionThrower.ThrowIOException("Test message");
	}

	[TestMethod]
	[ExpectedException(typeof(IOException))]
	public void ThrowIOException_WithNullInnerException_ThrowsIOException()
	{
		// Act
		ExceptionThrower.ThrowIOException("Test message", null);
	}

	[TestMethod]
	[ExpectedException(typeof(IOException))]
	public void ThrowIOException_WithNullMessage_ThrowsIOException()
	{
		// Act
		ExceptionThrower.ThrowIOException(null, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(IOException))]
	public void ThrowIOException_WithNullMessage_ThrowsIOException2()
	{
		ExceptionThrower.ThrowIOException(null);
	}

	[TestMethod]
	[ExpectedException(typeof(IOException))]
	public void ThrowIOException_WithNullMessageAndInnerException_ThrowsIOException()
	{
		// Act
		ExceptionThrower.ThrowIOException(null, null);
	}

	[TestMethod]
	[ExpectedException(typeof(JsonException))]
	public void ThrowJsonException_WithInnerException_ThrowsJsonException()
	{
		// Act
		ExceptionThrower.ThrowJsonException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(JsonException))]
	public void ThrowJsonException_WithMessage_ThrowsJsonException()
	{
		// Act
		ExceptionThrower.ThrowJsonException("Test message");
	}

	[TestMethod]
	[ExpectedException(typeof(JsonException))]
	public void ThrowJsonException_WithNullMessage_ThrowsJsonException()
	{
		ExceptionThrower.ThrowJsonException(null);
	}

	[TestMethod]
	[ExpectedException(typeof(JsonException))]
	public void ThrowJsonException_WithNullMessageAndInnerException_ThrowsJsonException()
	{
		ExceptionThrower.ThrowJsonException(null, new Exception("Inner exception"));
	}


	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithInnerException_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithInnerExceptionAndUserMessage_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithMessage_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException("Test message");
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithMessageAndInnerExceptionAndNullUserMessage_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithMessageAndMessageIdAndNullInnerException_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException("Test message", "messageId", null);
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithMessageAndNullMessageIdAndInnerException_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException("Test message", null, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithMessageId_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException("Test message", "messageId");
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithMessageIdAndInnerException_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException("Test message", "messageId", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithNullMessage_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException(null, "messageId");
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithNullMessageAndInnerExceptionAndNullUserMessage_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException(null, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithNullMessageAndInnerExceptionAndUserMessage_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException(null, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithNullMessageAndMessageId_ThrowsMessageNotQueuedException2()
	{
		ExceptionThrower.ThrowMessageNotQueuedException(null, "messageId");
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithNullMessageAndMessageIdAndInnerException_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException(null, "messageId", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithNullMessageAndMessageIdAndNullInnerException_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException(null, "messageId", null);
	}


	[TestMethod]
	[ExpectedException(typeof(MessageNotQueuedException))]
	public void ThrowMessageNotQueuedException_WithNullMessageAndNullMessageIdAndInnerException_ThrowsMessageNotQueuedException()
	{
		// Act
		ExceptionThrower.ThrowMessageNotQueuedException(null, null, new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(NetworkConnectionException))]
	public void ThrowNetworkConnectionException_WithInnerException_ThrowsNetworkConnectionException()
	{
		// Act
		ExceptionThrower.ThrowNetworkConnectionException("Test message", new Exception("Inner exception"));
	}

	[TestMethod]
	[ExpectedException(typeof(NetworkConnectionException))]
	public void ThrowNetworkConnectionException_WithMessage_ThrowsNetworkConnectionException()
	{
		// Act
		ExceptionThrower.ThrowNetworkConnectionException("Test message");
	}

	[TestMethod]
	[ExpectedException(typeof(NetworkConnectionException))]
	public void ThrowNetworkConnectionException_WithMessageAndNetworkInterface_ThrowsNetworkConnectionException()
	{
		// Arrange
		var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();

		// Act
		ExceptionThrower.ThrowNetworkConnectionException("Test message", networkInterface);
	}

	[TestMethod]
	[ExpectedException(typeof(NetworkConnectionException))]
	public void ThrowNetworkConnectionException_WithNullMessage_ThrowsNetworkConnectionException2()
	{
		ExceptionThrower.ThrowNetworkConnectionException(null);
	}

	[TestMethod]
	[ExpectedException(typeof(NetworkConnectionException))]
	public void ThrowNetworkConnectionException_WithNullMessageAndNetworkInterface_ThrowsNetworkConnectionException()
	{
		// Arrange
		var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();

		// Act
		ExceptionThrower.ThrowNetworkConnectionException(null, networkInterface);
	}
}
