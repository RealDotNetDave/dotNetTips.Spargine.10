// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-16-2023
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="SimpleResultTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SimpleResultTests
{

	[TestMethod]
	public void AddException_AddsError()
	{
		// Arrange
		var result = new SimpleResult<int>(42);
		var ex = new ArgumentNullException("param");

		// Act
		result.AddException(ex);

		// Assert
		Assert.IsTrue(result.HasErrors);
		Assert.AreEqual(ResultStatus.PartialSuccess, result.Status);
		Assert.AreEqual(1, result.Errors().Count);
	}

	[TestMethod]
	public void Bind_FailedResult_PropagatesErrors()
	{
		// Arrange
		var ex = new Exception("fail");
		var result = new SimpleResult<int>(ex);

		// Act
		var bound = result.Bind(i => new SimpleResult<string>(i.ToString()));

		// Assert
		Assert.IsTrue(bound.HasErrors);
		Assert.AreEqual(ResultStatus.Failed, bound.Status);
		Assert.AreEqual(1, bound.Errors().Count);
	}

	[TestMethod]
	public void Bind_SuccessfulResult_BindsValue()
	{
		// Arrange
		var result = new SimpleResult<int>(5);

		// Act
		var bound = result.Bind(i => new SimpleResult<string>((i * 2).ToString()));

		// Assert
		Assert.IsTrue(bound.IsSuccess);
		Assert.AreEqual("10", bound.Value);
	}

	[TestMethod]
	public void Constructor_WithException_SetsError()
	{
		// Arrange
		var ex = new InvalidOperationException("fail");

		// Act
		var result = new SimpleResult<string>(ex);

		// Assert
		Assert.IsTrue(result.HasErrors);
		Assert.IsFalse(result.IsSuccess);
		Assert.AreEqual(ResultStatus.Failed, result.Status);
		Assert.AreEqual(1, result.Errors().Count);
		Assert.IsTrue(result.GetErrorMessages().Contains("fail"));
	}

	[TestMethod]
	public void Constructor_WithValue_SetsValueAndSuccess()
	{
		// Arrange
		var value = "test";

		// Act
		var result = new SimpleResult<string>(value);

		// Assert
		Assert.AreEqual(value, result.Value);
		Assert.IsTrue(result.IsSuccess);
		Assert.IsFalse(result.HasErrors);
		Assert.AreEqual(ResultStatus.Succeeded, result.Status);
	}

	[TestMethod]
	public void Deconstruct_ReturnsValueAndErrors()
	{
		// Arrange
		var result = new SimpleResult<int>(123);

		// Act
		result.Deconstruct(out var value, out var errors);

		// Assert
		Assert.AreEqual(123, value);
		Assert.IsNotNull(errors);
		Assert.AreEqual(0, errors.Count);
	}

	[TestMethod]
	public void DefaultConstructor_SetsDefaultValue()
	{
		// Act
		var result = new SimpleResult<string>();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(default(string), result.Value);
		Assert.IsFalse(result.HasErrors);
		Assert.AreEqual(ResultStatus.Failed, result.Status);
	}

	[TestMethod]
	public void ErrorMessagesTest()
	{
		var ex = new ArgumentException("Invalue value for the parameter.");

		var result = SimpleResult.FromException<string>(ex);

		var errors = result.GetErrorMessages();

		Assert.IsTrue(errors.Any());
	}

	[TestMethod]
	public void Errors_ReturnsReadOnlyCollection()
	{
		// Arrange
		var ex = new Exception("fail");
		var result = new SimpleResult<int>(ex);

		// Act
		var errors = result.Errors();

		// Assert
		Assert.IsInstanceOfType(errors, typeof(ReadOnlyCollection<Exception>));
		Assert.AreEqual(1, errors.Count);
	}
	[TestMethod]
	public void FromExceptionTest()
	{
		var ex = new ArgumentException("Argument Exception");

		var result = SimpleResult.FromException<string>(ex);

		Assert.IsTrue(result.Status == ResultStatus.Failed);
	}

	[TestMethod]
	public void FromResult_NullSimpleResult_ThrowsArgumentNullException()
	{
		// Arrange
		SimpleResult<int> simpleResult = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => SimpleResult<int>.FromResult(simpleResult));
	}

	[TestMethod]
	public void FromResult_ReturnsValue()
	{
		// Arrange
		var result = new SimpleResult<string>("abc");

		// Act
		var value = SimpleResult<string>.FromResult(result);

		// Assert
		Assert.AreEqual("abc", value);
	}

	[TestMethod]
	public void FromResult_ValidSimpleResult_ReturnsValue()
	{
		// Arrange
		var expectedValue = 42;
		var simpleResult = new SimpleResult<int>(expectedValue);

		// Act
		var result = SimpleResult<int>.FromResult(simpleResult);

		// Assert
		Assert.AreEqual(expectedValue, result);
	}

	[TestMethod]
	public void FromValueTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = SimpleResult.FromValue(person);

		Assert.IsTrue(result.Status == ResultStatus.Succeeded);
	}

	[TestMethod]
	public void GetErrorMessages_ReturnsAllMessages()
	{
		// Arrange
		var result = new SimpleResult<int>(new Exception("err1"));
		result.AddException(new Exception("err2"));

		// Act
		var msg = result.GetErrorMessages();

		// Assert
		Assert.IsTrue(msg.Contains("err1"));
		Assert.IsTrue(msg.Contains("err2"));
	}

	[TestMethod]
	public void HasErrors_TrueIfExceptionAdded()
	{
		// Arrange
		var result = new SimpleResult<int>();
		result.AddException(new Exception("fail"));

		// Assert
		Assert.IsTrue(result.HasErrors);
	}

	[TestMethod]
	public void IsFailure_TrueIfNoValueOrOnlyErrors()
	{
		// Arrange
		var result = new SimpleResult<int>(new Exception("fail"));

		// Assert
		Assert.IsTrue(result.IsFailure);
	}

	[TestMethod]
	public void IsSuccess_TrueIfNoErrorsAndValueSet()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Assert
		Assert.IsTrue(result.IsSuccess);
	}

	[TestMethod]
	public void Map_FailedResult_PropagatesErrors()
	{
		// Arrange
		var ex = new Exception("fail");
		var result = new SimpleResult<int>(ex);

		// Act
		var mapped = result.Map(i => i.ToString());

		// Assert
		Assert.IsTrue(mapped.HasErrors);
		Assert.AreEqual(ResultStatus.Failed, mapped.Status);
	}

	[TestMethod]
	public void Map_SuccessfulResult_MapsValue()
	{
		// Arrange
		var result = new SimpleResult<int>(7);

		// Act
		var mapped = result.Map(i => (i * 3).ToString());

		// Assert
		Assert.IsTrue(mapped.IsSuccess);
		Assert.AreEqual("21", mapped.Value);
	}

	[TestMethod]
	public void Or_ReturnsDefaultIfHasErrors()
	{
		// Arrange
		var result = new SimpleResult<string>(new InvalidOperationException("Error"));

		// Act
		var value = result.Or("Default");

		// Assert
		Assert.AreEqual("Default", value);
	}
	[TestMethod]
	public void Or_ReturnsValueIfNoErrors()
	{
		// Arrange
		var expected = "Success";
		var result = new SimpleResult<string>(expected);

		// Act
		var value = result.Or("Default");

		// Assert
		Assert.AreEqual(expected, value);
	}

	[TestMethod]
	public void Or_ReturnsValueOrDefault()
	{
		// Arrange
		var result1 = new SimpleResult<int>(5);
		var result2 = new SimpleResult<int>(new Exception("fail"));

		// Act & Assert
		Assert.AreEqual(5, result1.Or(99));
		Assert.AreEqual(99, result2.Or(99));
	}

	[TestMethod]
	public void OrDefault_ReturnsValue()
	{
		// Arrange
		var expected = "Success";
		var result = new SimpleResult<string>(expected);

		// Act
		var value = result.OrDefault();

		// Assert
		Assert.AreEqual(expected, value);
	}


	[TestMethod]
	public void SetValue_SetsValue()
	{
		// Arrange
		var result = new SimpleResult<int>();

		// Act
		result.SetValue(42);

		// Assert
		Assert.AreEqual(42, result.Value);
		Assert.IsTrue(result.IsSuccess || result.Status == ResultStatus.PartialSuccess);
	}

	[TestMethod]
	public void SetValue_SetsValueAndValueSet()
	{
		// Arrange
		var result = new SimpleResult<string>();
		var expected = "SetValue";

		// Act
		result.SetValue(expected);

		// Assert
		Assert.AreEqual(expected, result.Value);
		Assert.IsTrue(result.TryGet(out var actual));
		Assert.AreEqual(expected, actual);
	}

	[TestMethod]
	public void SimpleResult_AddException_ShouldAddToExceptions()
	{
		// Arrange
		var result = new SimpleResult<int>();
		var exception = new InvalidOperationException("Test exception");

		// Act
		result.AddException(exception);

		// Assert
		Assert.AreEqual(1, result.Errors().Count);
		Assert.AreEqual(exception.Message, result.Errors()[0].Message);
	}


	[TestMethod]
	public void SimpleResult_ConstructorWithException_ShouldAddException()
	{
		// Arrange
		var exception = new InvalidOperationException("Test exception");

		// Act
		var result = new SimpleResult<string>(exception);

		// Assert
		Assert.AreEqual(ResultStatus.Failed, result.Status);
		Assert.AreEqual(1, result.Errors().Count);
		Assert.AreEqual(exception.Message, result.Errors()[0].Message);
	}

	[TestMethod]
	public void SimpleResult_ConstructorWithValue_ShouldSetValue()
	{
		// Arrange
		var value = 42;

		// Act
		var result = new SimpleResult<int>(value);

		// Assert
		Assert.AreEqual(value, result.Value);
		Assert.AreEqual(ResultStatus.Succeeded, result.Status);
	}

	[TestMethod]
	public void SimpleResult_GetErrorMessages_ShouldReturnAllMessages()
	{
		// Arrange
		var result = new SimpleResult<int>();
		var exception1 = new InvalidOperationException("Test exception 1");
		var exception2 = new InvalidOperationException("Test exception 2");
		result.AddException(exception1);
		result.AddException(exception2);

		// Act
		var errorMessages = result.GetErrorMessages();

		// Assert
		Assert.IsTrue(errorMessages.Contains(exception1.Message));
		Assert.IsTrue(errorMessages.Contains(exception2.Message));
	}

	[TestMethod]
	public void SimpleResult_Or_ShouldReturnDefaultValueIfFailed()
	{
		// Arrange
		var result = new SimpleResult<int>(new InvalidOperationException("Test exception"));
		var defaultValue = 100;

		// Act
		var value = result.Or(defaultValue);

		// Assert
		Assert.AreEqual(defaultValue, value);
	}

	[TestMethod]
	public void SimpleResult_OrDefault_ShouldReturnDefaultValue()
	{
		// Arrange
		var result = new SimpleResult<int>();

		// Act
		var value = result.OrDefault();

		// Assert
		Assert.AreEqual(default(int), value);
	}

	[TestMethod]
	public void SimpleResult_SetValue_ShouldUpdateValue()
	{
		// Arrange
		var result = new SimpleResult<int>();
		var newValue = 42;

		// Act
		result.SetValue(newValue);

		// Assert
		Assert.AreEqual(newValue, result.Value);
	}

	[TestMethod]
	public void SimpleResult_Status_ShouldReturnPartialSuccessIfValueAndExceptionPresent()
	{
		// Arrange
		var value = 42;
		var result = new SimpleResult<int>(value);
		var exception = new InvalidOperationException("Test exception");
		result.AddException(exception);

		// Act
		var status = result.Status;

		// Assert
		Assert.AreEqual(ResultStatus.PartialSuccess, status);
	}

	[TestMethod]
	public void SimpleResult_ToString_ShouldReturnErrorMessages()
	{
		// Arrange
		var exception = new InvalidOperationException("Test exception");
		var result = new SimpleResult<int>(exception);

		// Act
		var resultString = result.ToString();

		// Assert
		Assert.IsTrue(resultString.Contains(exception.Message));
	}

	[TestMethod]
	public void SimpleResult_ToString_ShouldReturnValueString()
	{
		// Arrange
		var value = 42;
		var result = new SimpleResult<int>(value);

		// Act
		var resultString = result.ToString();

		// Assert
		Assert.AreEqual(value.ToString(), resultString);
	}

	[TestMethod]
	public void Status_PartialSuccessIfValueSetAndErrors()
	{
		// Arrange
		var result = new SimpleResult<int>(42);
		result.AddException(new Exception("fail"));

		// Assert
		Assert.AreEqual(ResultStatus.PartialSuccess, result.Status);
	}

	[TestMethod]
	public void ToString_ReturnsErrorMessagesIfHasErrors()
	{
		// Arrange
		var error = new InvalidOperationException("Error");
		var result = new SimpleResult<string>(error);

		// Act
		var str = result.ToString();

		// Assert
		Assert.IsTrue(str.Contains("Error"));
	}

	[TestMethod]
	public void ToString_ReturnsValueIfNoErrors()
	{
		// Arrange
		var expected = "Success";
		var result = new SimpleResult<string>(expected);

		// Act
		var str = result.ToString();

		// Assert
		Assert.AreEqual(expected, str);
	}

	[TestMethod]
	public void ToString_ReturnsValueOrErrorMessages()
	{
		// Arrange
		var result1 = new SimpleResult<int>(123);
		var result2 = new SimpleResult<int>(new Exception("fail"));

		// Act
		var str1 = result1.ToString();
		var str2 = result2.ToString();

		// Assert
		Assert.AreEqual("123", str1);
		Assert.IsTrue(str2.Contains("fail"));
	}

	[TestMethod]
	public void TryGet_ReturnsFalseIfValueNotSet()
	{
		// Arrange
		var result = new SimpleResult<string>();

		// Act
		var success = result.TryGet(out var value);

		// Assert
		Assert.IsFalse(success);
		Assert.AreEqual(default, value);
	}

	[TestMethod]
	public void TryGet_ReturnsTrueIfValueSet()
	{
		// Arrange
		var expected = "Success";
		var result = new SimpleResult<string>(expected);

		// Act
		var success = result.TryGet(out var value);

		// Assert
		Assert.IsTrue(success);
		Assert.AreEqual(expected, value);
	}
}
