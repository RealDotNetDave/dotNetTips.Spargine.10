// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-14-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="ExceptionThrowerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
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

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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
	public void ThrowArgumentException_WithInnerException_ThrowsArgumentException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => ExceptionThrower.ThrowArgumentException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowArgumentException_WithMessage_ThrowsArgumentException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => ExceptionThrower.ThrowArgumentException("Test message", "paramName"));
	}

	[TestMethod]
	public void ThrowArgumentInvalidException_WithInnerException_ThrowsArgumentInvalidException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => ExceptionThrower.ThrowArgumentInvalidException("Test message", "paramName", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowArgumentInvalidException_WithMessage_ThrowsArgumentInvalidException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => ExceptionThrower.ThrowArgumentInvalidException("Test message", "paramName"));
	}

	[TestMethod]
	public void ThrowArgumentInvalidException_WithNullMessage_ThrowsArgumentInvalidException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => ExceptionThrower.ThrowArgumentInvalidException(null, "paramName"));
	}

	[TestMethod]
	public void ThrowArgumentInvalidException_WithNullMessageAndInnerException_ThrowsArgumentInvalidException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => ExceptionThrower.ThrowArgumentInvalidException(null, "paramName", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowArgumentNullException_WithInnerException_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ExceptionThrower.ThrowArgumentNullException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowArgumentNullException_WithMessage_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ExceptionThrower.ThrowArgumentNullException("Test message", "paramName"));
	}

	[TestMethod]
	public void ThrowArgumentNullException_WithNullMessage_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ExceptionThrower.ThrowArgumentNullException(null, "paramName"));
	}

	[TestMethod]
	public void ThrowArgumentNullException_WithParamName_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ExceptionThrower.ThrowArgumentNullException("paramName"));
	}

	[TestMethod]
	public void ThrowArgumentOutOfRangeException_WithInnerException_ThrowsArgumentOutOfRangeException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => ExceptionThrower.ThrowArgumentOutOfRangeException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowArgumentOutOfRangeException_WithMessage_ThrowsArgumentOutOfRangeException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => ExceptionThrower.ThrowArgumentOutOfRangeException("Test message", "paramName"));
	}

	[TestMethod]
	public void ThrowArgumentOutOfRangeException_WithNullMessage_ThrowsArgumentOutOfRangeException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => ExceptionThrower.ThrowArgumentOutOfRangeException(null, "paramName"));
	}

	[TestMethod]
	public void ThrowArgumentOutOfRangeException_WithParamName_ThrowsArgumentOutOfRangeException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => ExceptionThrower.ThrowArgumentOutOfRangeException("paramName"));
	}

	[TestMethod]
	public void ThrowArgumentReadOnlyException_WithMessage_ThrowsArgumentReadOnlyException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => ExceptionThrower.ThrowArgumentReadOnlyException("Test message", "paramName"));
	}

	[TestMethod]
	public void ThrowArgumentReadOnlyException_WithNullMessage_ThrowsArgumentReadOnlyException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => ExceptionThrower.ThrowArgumentReadOnlyException(null, "paramName"));
	}

	[TestMethod]
	public void ThrowDirectoryNotFoundException_WithInnerException_ThrowsArgumentInvalidException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => ExceptionThrower.ThrowDirectoryNotFoundException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowDirectoryNotFoundException_WithMessage_ThrowsDirectoryNotFoundException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<DirectoryNotFoundException>(() => ExceptionThrower.ThrowDirectoryNotFoundException("Test message", new DirectoryInfo("nonexistent")));
	}

	[TestMethod]
	public void ThrowDirectoryNotFoundException_WithNullMessage_ThrowsDirectoryNotFoundException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<DirectoryNotFoundException>(() => ExceptionThrower.ThrowDirectoryNotFoundException(null, new DirectoryInfo("nonexistent")));
	}

	[TestMethod]
	public void ThrowFileNotFoundException_WithInnerException_ThrowsFileNotFoundException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(() => ExceptionThrower.ThrowFileNotFoundException("Test message", "nonexistent.txt", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowFileNotFoundException_WithMessage_ThrowsFileNotFoundException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(() => ExceptionThrower.ThrowFileNotFoundException("Test message", "nonexistent.txt"));
	}

	[TestMethod]
	public void ThrowFileNotFoundException_WithNullInnerException_ThrowsFileNotFoundException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(() => ExceptionThrower.ThrowFileNotFoundException("Test message", (Exception)null));
	}

	[TestMethod]
	public void ThrowFileNotFoundException_WithNullMessage_ThrowsFileNotFoundException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(() => ExceptionThrower.ThrowFileNotFoundException(null, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowFileNotFoundException_WithNullMessageAndInnerException_ThrowsFileNotFoundException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(() => ExceptionThrower.ThrowFileNotFoundException(null, (Exception)null));
	}

	[TestMethod]
	public void ThrowInvalidCastException_WithInnerException_ThrowsInvalidCastException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidCastException>(() => ExceptionThrower.ThrowInvalidCastException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowInvalidCastException_WithMessage_ThrowsInvalidCastException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidCastException>(() => ExceptionThrower.ThrowInvalidCastException("Test message", "paramName"));
	}

	[TestMethod]
	public void ThrowInvalidEnumTypeException_WithMessage_ThrowsInvalidEnumTypeException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidEnumTypeException>(() => ExceptionThrower.ThrowInvalidEnumTypeException("Test message"));
	}

	[TestMethod]
	public void ThrowInvalidEnumTypeException_WithNullMessage_ThrowsInvalidEnumTypeException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidEnumTypeException>(() => ExceptionThrower.ThrowInvalidEnumTypeException(null));
	}

	[TestMethod]
	public void ThrowInvalidEnumTypeException_WithNullMessageAndInnerException_ThrowsInvalidCastException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidCastException>(() => ExceptionThrower.ThrowInvalidEnumTypeException(null, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowInvalidOperationException_WithInnerException_ThrowsInvalidOperationException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidOperationException>(() => ExceptionThrower.ThrowInvalidOperationException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowInvalidOperationException_WithMessage_ThrowsInvalidOperationException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidOperationException>(() => ExceptionThrower.ThrowInvalidOperationException("Test message"));
	}

	[TestMethod]
	public void ThrowInvalidOperationException_WithNullMessage_ThrowsInvalidOperationException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidOperationException>(() => ExceptionThrower.ThrowInvalidOperationException(null));
	}

	[TestMethod]
	public void ThrowInvalidOperationException_WithNullMessageAndInnerException_ThrowsInvalidOperationException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidOperationException>(() => ExceptionThrower.ThrowInvalidOperationException(null, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowInvalidValueException_WithInnerException_ThrowsInvalidValueException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<int>>(() => ExceptionThrower.ThrowInvalidValueException("Test message", 42, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowInvalidValueException_WithMessage_ThrowsInvalidValueException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<int>>(() => ExceptionThrower.ThrowInvalidValueException("Test message", 42));
	}

	[TestMethod]
	public void ThrowInvalidValueException_WithNullMessage_ThrowsInvalidValueException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<int>>(() => ExceptionThrower.ThrowInvalidValueException<int>(null, 42));
	}

	[TestMethod]
	public void ThrowInvalidValueException_WithNullMessageAndInnerException_ThrowsInvalidValueException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<int>>(() => ExceptionThrower.ThrowInvalidValueException<int>(null, 42, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowIOException_WithInnerException_ThrowsIOException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<IOException>(() => ExceptionThrower.ThrowIOException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowIOException_WithMessage_ThrowsIOException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<IOException>(() => ExceptionThrower.ThrowIOException("Test message"));
	}

	[TestMethod]
	public void ThrowIOException_WithNullInnerException_ThrowsIOException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<IOException>(() => ExceptionThrower.ThrowIOException("Test message", null));
	}

	[TestMethod]
	public void ThrowIOException_WithNullMessage_ThrowsIOException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<IOException>(() => ExceptionThrower.ThrowIOException(null, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowIOException_WithNullMessage_ThrowsIOException2()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<IOException>(() => ExceptionThrower.ThrowIOException(null));
	}

	[TestMethod]
	public void ThrowIOException_WithNullMessageAndInnerException_ThrowsIOException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<IOException>(() => ExceptionThrower.ThrowIOException(null, null));
	}

	[TestMethod]
	public void ThrowJsonException_WithInnerException_ThrowsJsonException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<JsonException>(() => ExceptionThrower.ThrowJsonException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowJsonException_WithMessage_ThrowsJsonException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<JsonException>(() => ExceptionThrower.ThrowJsonException("Test message"));
	}

	[TestMethod]
	public void ThrowJsonException_WithNullMessage_ThrowsJsonException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<JsonException>(() => ExceptionThrower.ThrowJsonException(null));
	}

	[TestMethod]
	public void ThrowJsonException_WithNullMessageAndInnerException_ThrowsJsonException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<JsonException>(() => ExceptionThrower.ThrowJsonException(null, new Exception("Inner exception")));
	}


	[TestMethod]
	public void ThrowMessageNotQueuedException_WithInnerException_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithInnerExceptionAndUserMessage_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithMessage_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException("Test message"));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithMessageAndInnerExceptionAndNullUserMessage_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithMessageAndMessageIdAndNullInnerException_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException("Test message", "messageId", null));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithMessageAndNullMessageIdAndInnerException_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException("Test message", null, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithMessageId_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException("Test message", "messageId"));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithMessageIdAndInnerException_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException("Test message", "messageId", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithNullMessage_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException(null, "messageId"));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithNullMessageAndInnerExceptionAndNullUserMessage_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException(null, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithNullMessageAndInnerExceptionAndUserMessage_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException(null, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithNullMessageAndMessageId_ThrowsMessageNotQueuedException2()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException(null, "messageId"));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithNullMessageAndMessageIdAndInnerException_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException(null, "messageId", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowMessageNotQueuedException_WithNullMessageAndMessageIdAndNullInnerException_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException(null, "messageId", null));
	}


	[TestMethod]
	public void ThrowMessageNotQueuedException_WithNullMessageAndNullMessageIdAndInnerException_ThrowsMessageNotQueuedException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<MessageNotQueuedException>(() => ExceptionThrower.ThrowMessageNotQueuedException(null, null, new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowNetworkConnectionException_WithInnerException_ThrowsNetworkConnectionException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<NetworkConnectionException>(() => ExceptionThrower.ThrowNetworkConnectionException("Test message", new Exception("Inner exception")));
	}

	[TestMethod]
	public void ThrowNetworkConnectionException_WithMessage_ThrowsNetworkConnectionException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<NetworkConnectionException>(() => ExceptionThrower.ThrowNetworkConnectionException("Test message"));
	}

	[TestMethod]
	public void ThrowNetworkConnectionException_WithMessageAndNetworkInterface_ThrowsNetworkConnectionException()
	{
		// Arrange
		var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();

		// Act & Assert
		_ = Assert.ThrowsExactly<NetworkConnectionException>(() => ExceptionThrower.ThrowNetworkConnectionException("Test message", networkInterface));
	}

	[TestMethod]
	public void ThrowNetworkConnectionException_WithNullMessage_ThrowsNetworkConnectionException2()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<NetworkConnectionException>(() => ExceptionThrower.ThrowNetworkConnectionException(null));
	}

	[TestMethod]
	public void ThrowNetworkConnectionException_WithNullMessageAndNetworkInterface_ThrowsNetworkConnectionException()
	{
		// Arrange
		var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();

		// Act & Assert
		_ = Assert.ThrowsExactly<NetworkConnectionException>(() => ExceptionThrower.ThrowNetworkConnectionException(null, networkInterface));
	}
}
