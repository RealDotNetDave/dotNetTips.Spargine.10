// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 05-13-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-13-2026
// ***********************************************************************
// <copyright file="InvalidValueExceptionTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for InvalidValueException&lt;TValue&gt; covering all constructors,
// the Value property, and the ToString override.
// </summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class InvalidValueExceptionTests
{
	[TestMethod]
	public void Constructor_Default_HasNonEmptyMessage()
	{
		// Act
		var ex = new InvalidValueException<int>();

		// Assert
		Assert.IsNotNull(ex);
		Assert.IsFalse(string.IsNullOrWhiteSpace(ex.Message));
	}

	[TestMethod]
	public void Constructor_Default_ValueIsDefault()
	{
		// Act
		var ex = new InvalidValueException<int>();

		// Assert
		Assert.AreEqual(default, ex.Value);
	}

	[TestMethod]
	public void Constructor_WithValue_StoresValue()
	{
		// Arrange
		var value = RandomData.GenerateInteger(1, 9999);

		// Act
		var ex = new InvalidValueException<int>(value);

		// Assert
		Assert.AreEqual(value, ex.Value);
	}

	[TestMethod]
	public void Constructor_WithNullReferenceValue_StoresNull()
	{
		// Act
		var ex = new InvalidValueException<string>(null);

		// Assert
		Assert.IsNull(ex.Value);
	}

	[TestMethod]
	public void Constructor_WithMessage_SetsMessage()
	{
		// Arrange
		var message = RandomData.GenerateWord(20);

		// Act
		var ex = new InvalidValueException<int>(message);

		// Assert
		Assert.AreEqual(message, ex.Message);
	}

	[TestMethod]
	public void Constructor_WithMessageAndValue_SetsMessageAndValue()
	{
		// Arrange
		var message = RandomData.GenerateWord(20);
		var value = RandomData.GenerateInteger(1, 9999);

		// Act
		var ex = new InvalidValueException<int>(message, value);

		// Assert
		Assert.AreEqual(message, ex.Message);
		Assert.AreEqual(value, ex.Value);
	}

	[TestMethod]
	public void Constructor_WithMessageAndInnerException_SetsMessageAndInnerException()
	{
		// Arrange
		var message = RandomData.GenerateWord(20);
		var inner = new InvalidOperationException(RandomData.GenerateWord(10));

		// Act
		var ex = new InvalidValueException<int>(message, inner);

		// Assert
		Assert.AreEqual(message, ex.Message);
		Assert.AreEqual(inner, ex.InnerException);
	}

	[TestMethod]
	public void Constructor_WithMessageAndInnerException_ValueIsDefault()
	{
		// Arrange
		var message = RandomData.GenerateWord(20);
		var inner = new InvalidOperationException(RandomData.GenerateWord(10));

		// Act
		var ex = new InvalidValueException<int>(message, inner);

		// Assert
		Assert.AreEqual(default, ex.Value);
	}

	[TestMethod]
	public void Constructor_WithMessageValueAndInnerException_SetsAllProperties()
	{
		// Arrange
		var message = RandomData.GenerateWord(20);
		var value = RandomData.GenerateInteger(1, 9999);
		var inner = new InvalidOperationException(RandomData.GenerateWord(10));

		// Act
		var ex = new InvalidValueException<int>(message, value, inner);

		// Assert
		Assert.AreEqual(message, ex.Message);
		Assert.AreEqual(value, ex.Value);
		Assert.AreEqual(inner, ex.InnerException);
	}

	[TestMethod]
	public void Constructor_WithMessageValueAndNullInnerException_SetsMessageAndValue()
	{
		// Arrange
		var message = RandomData.GenerateWord(20);
		var value = RandomData.GenerateInteger(1, 9999);

		// Act
		var ex = new InvalidValueException<int>(message, value, null);

		// Assert
		Assert.AreEqual(message, ex.Message);
		Assert.AreEqual(value, ex.Value);
		Assert.IsNull(ex.InnerException);
	}

	[TestMethod]
	public void ToString_WithValueAndInnerException_ContainsMessageValueAndInnerException()
	{
		// Arrange
		var message = RandomData.GenerateWord(20);
		var value = RandomData.GenerateInteger(1, 9999);
		var inner = new InvalidOperationException(RandomData.GenerateWord(10));
		var ex = new InvalidValueException<int>(message, value, inner);

		// Act
		var result = ex.ToString();

		// Assert
		Assert.IsNotNull(result);
		StringAssert.Contains(result, message);
		StringAssert.Contains(result, value.ToString());
		StringAssert.Contains(result, inner.ToString());
	}

	[TestMethod]
	public void ToString_WithNoValueAndNoInnerException_ContainsMessageAndEmptyFields()
	{
		// Arrange
		var message = RandomData.GenerateWord(20);
		var ex = new InvalidValueException<int>(message);

		// Act
		var result = ex.ToString();

		// Assert
		Assert.IsNotNull(result);
		StringAssert.Contains(result, message);
		StringAssert.Contains(result, "InnerException:");
		StringAssert.Contains(result, "Value:");
	}

	[TestMethod]
	public void ToString_WithNullReferenceValue_DoesNotThrow()
	{
		// Arrange
		var ex = new InvalidValueException<string>(null);

		// Act
		var result = ex.ToString();

		// Assert
		Assert.IsNotNull(result);
		StringAssert.Contains(result, "Value:");
	}

	[TestMethod]
	public void IsAssignableFrom_Exception_IsTrue()
	{
		// Act
		var ex = new InvalidValueException<int>();

		// Assert
		Assert.IsInstanceOfType<Exception>(ex);
	}
}
