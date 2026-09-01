// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-16-2023
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-03-2026
// ***********************************************************************
// <copyright file="SimpleResultTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.Extensions.Logging.Abstractions;
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
		Assert.HasCount(1, result.Errors);
	}

	[TestMethod]
	public void AddException_WithLogger_LogsException()
	{
		// Arrange
		var logger = new NullLogger<SimpleResult<int>>();
		var value = RandomData.GenerateInteger(1, 100);
		var result = new SimpleResult<int>(value, logger);
		var exception = new InvalidOperationException(RandomData.GenerateWord(10));

		// Act
		result.AddException(exception);

		// Assert
		Assert.IsTrue(result.HasErrors);
		Assert.HasCount(1, result.Errors);
		Assert.AreEqual(ResultStatus.PartialSuccess, result.Status);
	}

	[TestMethod]
	public void AddException_WithNullException_ThrowsArgumentNullException()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			result.AddException(null));
	}

	[TestMethod]
	public void AddMessage_AddsMultipleMessages()
	{
		// Arrange
		var result = new SimpleResult<int>(42);
		var message1 = "First message";
		var message2 = "Second message";
		var message3 = "Third message";

		// Act
		result.AddMessage(message1);
		result.AddMessage(message2);
		result.AddMessage(message3);

		// Assert
		Assert.HasCount(3, result.Messages);
	}
	[TestMethod]
	public void AddMessage_AddsValidMessage()
	{
		// Arrange
		var result = new SimpleResult<int>(42);
		var message = "Operation completed successfully";

		// Act
		result.AddMessage(message);

		// Assert
		Assert.HasCount(1, result.Messages);
		Assert.AreEqual(message, result.Messages[0]);
	}

	[TestMethod]
	public void AddMessage_IgnoresEmptyMessage()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Act
		result.AddMessage(string.Empty);
		result.AddMessage("   ");

		// Assert
		Assert.IsEmpty(result.Messages);
	}

	[TestMethod]
	public void AddMessage_IgnoresNullMessage()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Act
		result.AddMessage(null);

		// Assert
		Assert.IsEmpty(result.Messages);
	}

	[TestMethod]
	public void Bind_ChainingMultipleTimes_WorksCorrectly()
	{
		// Arrange
		var result = new SimpleResult<int>(10);

		// Act
		var final = result
			.Bind(i => new SimpleResult<int>(i * 2))
			.Bind(i => new SimpleResult<int>(i + 5))
			.Bind(i => new SimpleResult<string>(i.ToString()));

		// Assert
		Assert.IsTrue(final.IsSuccess);
		Assert.AreEqual("25", final.Value);
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
		Assert.HasCount(1, bound.Errors);
	}

	[TestMethod]
	public void Bind_FailedResult_PropagatesMultipleErrors()
	{
		// Arrange
		var result = new SimpleResult<int>(new InvalidOperationException("error1"));
		result.AddException(new ArgumentException("error2"));
		result.AddException(new FormatException("error3"));

		// Act
		var bound = result.Bind(i => new SimpleResult<string>(i.ToString()));

		// Assert
		Assert.HasCount(3, bound.Errors);
		Assert.AreEqual(ResultStatus.Failed, bound.Status);
	}

	[TestMethod]
	public void Bind_PartialSuccessResult_PropagatesErrors()
	{
		// Arrange
		var value = RandomData.GenerateInteger(1, 100);
		var result = new SimpleResult<int>(value);
		result.AddException(new InvalidOperationException(RandomData.GenerateWord(10)));

		// Act
		var bound = result.Bind(i => new SimpleResult<string>(i.ToString()));

		// Assert
		Assert.IsTrue(bound.HasErrors);
		Assert.AreEqual(ResultStatus.Failed, bound.Status);
		Assert.HasCount(1, bound.Errors);
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
	public void Bind_WithNullBinder_ThrowsArgumentNullException()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			result.Bind<string>(null));
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
		Assert.HasCount(1, result.Errors);
		Assert.Contains("fail", result.GetErrorMessages());
	}

	[TestMethod]
	public void Constructor_WithExceptionAndLogger_StoresLogger()
	{
		// Arrange
		var logger = new NullLogger<SimpleResult<int>>();
		var exception = new InvalidOperationException("Test error");

		// Act
		var result = new SimpleResult<int>(exception, logger);

		// Assert
		Assert.IsTrue(result.HasErrors);
		Assert.HasCount(1, result.Errors);
	}

	[TestMethod]
	public void Constructor_WithLogger_StoresLogger()
	{
		// Arrange
		var logger = new NullLogger<SimpleResult<int>>();
		var value = 42;

		// Act
		var result = new SimpleResult<int>(value, logger);

		// Assert
		Assert.IsTrue(result.IsSuccess);
		Assert.AreEqual(value, result.Value);
	}

	[TestMethod]
	public void Constructor_WithNullException_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			new SimpleResult<string>((Exception)null));
	}

	[TestMethod]
	public void Constructor_WithNullValue_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			new SimpleResult<string>((string)null!));
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
		Assert.IsEmpty(errors);
	}

	[TestMethod]
	public void Deconstruct_WithErrors_ReturnsValueAndErrors()
	{
		// Arrange
		var result = new SimpleResult<int>(42);
		var exception = new InvalidOperationException("Error");
		result.AddException(exception);

		// Act
		result.Deconstruct(out var value, out var errors);

		// Assert
		Assert.AreEqual(42, value);
		Assert.HasCount(1, errors);
		Assert.AreEqual(exception.Message, errors[0].Message);
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
		var errors = result.Errors;

		// Assert
		Assert.IsInstanceOfType(errors, typeof(ReadOnlyCollection<Exception>));
		Assert.HasCount(1, errors);
	}
	[TestMethod]
	public void FromExceptionTest()
	{
		var ex = new ArgumentException("Argument Exception");

		var result = SimpleResult.FromException<string>(ex);

		Assert.AreEqual(ResultStatus.Failed, result.Status);
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

		Assert.AreEqual(ResultStatus.Succeeded, result.Status);
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
		Assert.Contains("err1", msg);
		Assert.Contains("err2", msg);
	}

	[TestMethod]
	public void GetErrorMessages_WithInnerException_IncludesInnerMessages()
	{
		// Arrange
		var innerEx = new InvalidOperationException("inner error");
		var outerEx = new ArgumentException("outer error", innerEx);
		var result = new SimpleResult<int>(outerEx);

		// Act
		var messages = result.GetErrorMessages();

		// Assert
		Assert.Contains("outer error", messages);
		Assert.Contains("inner error", messages);
	}

	[TestMethod]
	public void GetHashCode_ReturnsDifferentValuesForDifferentInstances()
	{
		// Arrange
		var result1 = new SimpleResult<int>(42);
		var result2 = new SimpleResult<int>(42);

		// Act
		var hash1 = result1.GetHashCode();
		var hash2 = result2.GetHashCode();

		// Assert
		// Note: Different instances should have different hash codes
		Assert.AreNotEqual(hash1, hash2);
	}

	[TestMethod]
	public void GetHashCode_ReturnsSameValueForSameInstance()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Act
		var hash1 = result.GetHashCode();
		var hash2 = result.GetHashCode();

		// Assert
		Assert.AreEqual(hash1, hash2);
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
	public void Map_ChainingMultipleTimes_WorksCorrectly()
	{
		// Arrange
		var result = new SimpleResult<int>(5);

		// Act
		var final = result
			.Map(i => i * 2)
			.Map(i => i + 3)
			.Map(i => i.ToString());

		// Assert
		Assert.IsTrue(final.IsSuccess);
		Assert.AreEqual("13", final.Value);
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
	public void Map_FailedResult_PropagatesMultipleErrors()
	{
		// Arrange
		var result = new SimpleResult<int>(new InvalidOperationException("error1"));
		result.AddException(new ArgumentException("error2"));
		result.AddException(new FormatException("error3"));

		// Act
		var mapped = result.Map(i => i.ToString());

		// Assert
		Assert.HasCount(3, mapped.Errors);
		Assert.AreEqual(ResultStatus.Failed, mapped.Status);
	}

	[TestMethod]
	public void Map_PartialSuccessResult_PropagatesErrors()
	{
		// Arrange
		var value = RandomData.GenerateInteger(1, 100);
		var result = new SimpleResult<int>(value);
		result.AddException(new InvalidOperationException(RandomData.GenerateWord(10)));

		// Act
		var mapped = result.Map(i => i.ToString());

		// Assert
		Assert.IsTrue(mapped.HasErrors);
		Assert.AreEqual(ResultStatus.Failed, mapped.Status);
		Assert.HasCount(1, mapped.Errors);
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
	public void Map_WithNullMapper_ThrowsArgumentNullException()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			result.Map<string>(null));
	}

	[TestMethod]
	public void Messages_EmptyWhenNoMessagesAdded()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Act
		var messages = result.Messages;

		// Assert
		Assert.IsNotNull(messages);
		Assert.IsEmpty(messages);
	}

	[TestMethod]
	public void Messages_ReturnsReadOnlyCollection()
	{
		// Arrange
		var result = new SimpleResult<int>(42);
		result.AddMessage("Test message");

		// Act
		var messages = result.Messages;

		// Assert
		Assert.IsInstanceOfType(messages, typeof(ReadOnlyCollection<string>));
		Assert.HasCount(1, messages);
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
	public void SetValue_WithNullValue_ThrowsArgumentNullException()
	{
		// Arrange
		var result = new SimpleResult<string>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			result.SetValue(null));
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
		Assert.HasCount(1, result.Errors);
		Assert.AreEqual(exception.Message, result.Errors[0].Message);
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
		Assert.HasCount(1, result.Errors);
		Assert.AreEqual(exception.Message, result.Errors[0].Message);
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
		Assert.Contains(exception1.Message, errorMessages);
		Assert.Contains(exception2.Message, errorMessages);
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
		Assert.Contains(exception.Message, resultString);
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
	public void Status_Failed_WhenNoValueSet()
	{
		// Arrange & Act
		var result = new SimpleResult<int>();

		// Assert
		Assert.AreEqual(ResultStatus.Failed, result.Status);
		Assert.IsFalse(result.IsSuccess);
		Assert.IsTrue(result.IsFailure);
	}

	[TestMethod]
	public void Status_PartialSuccess_WhenValueSetWithErrors()
	{
		// Arrange
		var result = new SimpleResult<int>(42);

		// Act
		result.AddException(new InvalidOperationException("Error"));

		// Assert
		Assert.AreEqual(ResultStatus.PartialSuccess, result.Status);
		Assert.IsFalse(result.IsSuccess);
		Assert.IsFalse(result.IsFailure);
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
	public void Status_Succeeded_WhenValueSetNoErrors()
	{
		// Arrange & Act
		var result = new SimpleResult<int>(42);

		// Assert
		Assert.AreEqual(ResultStatus.Succeeded, result.Status);
		Assert.IsTrue(result.IsSuccess);
		Assert.IsFalse(result.IsFailure);
	}

	[TestMethod]
	public void ThreadSafety_AddExceptionConcurrently_AllExceptionsAdded()
	{
		// Arrange
		var result = new SimpleResult<int>(42);
		var exceptions = Enumerable.Range(0, 100)
			.Select(i => new InvalidOperationException($"Error {i}"))
			.ToArray();

		// Act
		Parallel.ForEach(exceptions, ex => result.AddException(ex));

		// Assert
		Assert.HasCount(100, result.Errors);
		Assert.AreEqual(ResultStatus.PartialSuccess, result.Status);
	}

	[TestMethod]
	public void ThreadSafety_AddMessageConcurrently_AllMessagesAdded()
	{
		// Arrange
		var result = new SimpleResult<int>(42);
		var messages = Enumerable.Range(0, 100)
			.Select(i => $"Message {i}")
			.ToArray();

		// Act
		Parallel.ForEach(messages, msg => result.AddMessage(msg));

		// Assert
		Assert.HasCount(100, result.Messages);
	}

	[TestMethod]
	public void ToString_DefaultConstructor_NullValue_ReturnsEmptyString()
	{
		// Arrange
		var result = new SimpleResult<string>();

		// Act
		var str = result.ToString();

		// Assert
		Assert.AreEqual(string.Empty, str);
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
		Assert.Contains("Error", str);
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
		Assert.Contains("fail", str2);
	}

	[TestMethod]
	public void ToString_WithNullValue_ReturnsEmptyString()
	{
		// Arrange
		var result = new SimpleResult<string>();
		result.SetValue(string.Empty);

		// Act
		var str = result.ToString();

		// Assert
		Assert.AreEqual(string.Empty, str);
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

	[TestMethod]
	public void Value_ReturnsCorrectValue_AfterSetValue()
	{
		// Arrange
		var result = new SimpleResult<int>();

		// Act
		result.SetValue(99);

		// Assert
		Assert.AreEqual(99, result.Value);
		Assert.IsTrue(result.IsSuccess);
	}
}
