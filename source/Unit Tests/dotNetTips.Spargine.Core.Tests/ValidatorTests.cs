// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-10-2025
// ***********************************************************************
// <copyright file="ValidatorTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ValidatorTests
{
	private const string BadEmail = "BAD@EMAIL";
	private const string GoodEmail = "fakeemail@google.com";

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void ArgumentCountInRange_CountAboveMax_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		Validator.ArgumentCountInRange(list, 1, 3);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void ArgumentCountInRange_CountBelowMin_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var list = new List<int> { 1 };

		// Act
		Validator.ArgumentCountInRange(list, 2, 5);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ArgumentCountInRange_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		List<int> list = null!;

		// Act
		Validator.ArgumentCountInRange(list, 1, 3);
	}

	[TestMethod]
	public void ArgumentCountInRange_ValidCount_ReturnsCollection()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };

		// Act
		var result = Validator.ArgumentCountInRange(list, 1, 3);

		// Assert
		Assert.AreEqual(list, result);
	}

	[TestMethod]
	public void ArgumentCustom_ChainedValidation_Success()
	{
		// Arrange
		var input = "test@example.com";
		Func<string, bool> predicate1 = s => !string.IsNullOrEmpty(s);
		Func<string, bool> predicate2 = s => s.Contains("@");

		// Act
		var result = input.ArgumentCustom(predicate1).ArgumentCustom(predicate2);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentCustom_ComplexObjectValidation_Success()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		Func<Person, bool> predicate = p => !string.IsNullOrEmpty(p.Email) && p.Email.Contains("@");

		// Act
		var result = person.ArgumentCustom(predicate);

		// Assert
		Assert.AreEqual(person, result);
	}

	[TestMethod]
	public void ArgumentCustom_DateTimeValidation_Success()
	{
		// Arrange
		var input = DateTime.Now.AddDays(1);
		Func<DateTime, bool> predicate = dt => dt > DateTime.Now;

		// Act
		var result = input.ArgumentCustom(predicate);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ArgumentCustom_GuidValidation_Failure()
	{
		// Arrange
		var input = Guid.Empty;
		Func<Guid, bool> predicate = g => g != Guid.Empty;

		// Act
		_ = input.ArgumentCustom(predicate);
	}

	[TestMethod]
	public void ArgumentCustom_GuidValidation_Success()
	{
		// Arrange
		var input = Guid.NewGuid();
		Func<Guid, bool> predicate = g => g != Guid.Empty;

		// Act
		var result = input.ArgumentCustom(predicate);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ArgumentCustom_InvalidPredicate_ThrowsArgumentInvalidException()
	{
		// Arrange
		var input = -5;
		Func<int, bool> predicate = x => x > 0;

		// Act
		_ = input.ArgumentCustom(predicate);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ArgumentCustom_ListValidation_Failure()
	{
		// Arrange
		var input = new List<int> { 1, -2, 3, 4, 5 };
		Func<List<int>, bool> predicate = list => list.Count > 0 && list.All(x => x > 0);

		// Act
		_ = input.ArgumentCustom(predicate);
	}

	[TestMethod]
	public void ArgumentCustom_ListValidation_Success()
	{
		// Arrange
		var input = new List<int> { 1, 2, 3, 4, 5 };
		Func<List<int>, bool> predicate = list => list.Count > 0 && list.All(x => x > 0);

		// Act
		var result = input.ArgumentCustom(predicate);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ArgumentCustom_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		string input = null;
		Func<string, bool> predicate = s => s.Length > 0;

		// Act
		_ = input.ArgumentCustom(predicate);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ArgumentCustom_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		var input = "test";
		Func<string, bool> predicate = null;

		// Act
		_ = input.ArgumentCustom(predicate);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ArgumentCustom_PredicateWithMultipleConditions_Failure()
	{
		// Arrange
		var input = 23;
		Func<int, bool> predicate = x => x > 0 && x < 100 && x % 5 == 0;

		// Act
		_ = input.ArgumentCustom(predicate);
	}

	[TestMethod]
	public void ArgumentCustom_PredicateWithMultipleConditions_Success()
	{
		// Arrange
		var input = 25;
		Func<int, bool> predicate = x => x > 0 && x < 100 && x % 5 == 0;

		// Act
		var result = input.ArgumentCustom(predicate);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ArgumentCustom_RangeValidation_Failure()
	{
		// Arrange
		var input = 150.5;
		Func<double, bool> predicate = x => x >= 0.0 && x <= 100.0;

		// Act
		_ = input.ArgumentCustom(predicate);
	}


	[TestMethod]
	public void ArgumentCustom_RangeValidation_Success()
	{
		// Arrange
		var input = 50.5;
		Func<double, bool> predicate = x => x >= 0.0 && x <= 100.0;

		// Act
		var result = input.ArgumentCustom(predicate);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentInvalidException))]
	public void ArgumentCustom_StringLengthValidation_Failure()
	{
		// Arrange
		var input = "Hi";
		Func<string, bool> predicate = s => s.Length >= 5 && s.Length <= 20;

		// Act
		_ = input.ArgumentCustom(predicate);
	}

	[TestMethod]
	public void ArgumentCustom_StringLengthValidation_Success()
	{
		// Arrange
		var input = "Hello World";
		Func<string, bool> predicate = s => s.Length >= 5 && s.Length <= 20;

		// Act
		var result = input.ArgumentCustom(predicate);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentCustom_ValidPredicate_ReturnsInput()
	{
		// Arrange
		var input = 42;
		Func<int, bool> predicate = x => x > 0;

		// Act
		var result = input.ArgumentCustom(predicate);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentCustom_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = 10;
		Func<int, bool> predicate = x => x > 100;
		var customMessage = "Value must be greater than 100";

		try
		{
			// Act
			_ = input.ArgumentCustom(predicate, customMessage);
			Assert.Fail("Expected ArgumentInvalidException was not thrown.");
		}
		catch (ArgumentInvalidException ex)
		{
			// Assert
			Assert.IsTrue(ex.Message.Contains(customMessage));
		}
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void ArgumentDefined_StatusEnum_InvalidValue_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var value = (Status)999;

		// Act
		_ = value.ArgumentDefined();
	}

	[TestMethod]
	public void ArgumentDefined_StatusEnum_ValidValue_ReturnsValue()
	{
		// Arrange
		var value = Status.Available;

		// Act
		var result = value.ArgumentDefined();

		// Assert
		Assert.AreEqual(value, result);
	}

	[TestMethod]
	public void ArgumentEqualsTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		//Good Test
		var result = person.GetType().ArgumentTypeEquals(typeof(Person));

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ArgumentExistsDirectoryInfoTest()
	{
		var directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

		try
		{
			var result = directoryInfo.ArgumentExists();

			Assert.IsNotNull(result);
		}
		catch
		{
			Assert.Fail();
		}

		//Test Exceptions
		DirectoryInfo nullDirectoryInfo = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullDirectoryInfo.ArgumentExists());

		var fakeDirectory = new DirectoryInfo("fakefile");
		_ = Assert.ThrowsException<DirectoryNotFoundException>(() => DirectoryHelper.DeleteDirectory(fakeDirectory));
	}

	[TestMethod]
	public void ArgumentExistsDirectoryInfoWithDefaultTest()
	{
		var directoryInfo = new DirectoryInfo("c:\temp\bogus");

		var defaultDirectoryInfo = new DirectoryInfo(
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

		try
		{
			var result = directoryInfo.ArgumentExists(defaultDirectoryInfo);

			Assert.AreEqual(result, defaultDirectoryInfo);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentExistsFileInfoTest()
	{
		var fileName = RandomData.GenerateRandomFileName();

		_ = RandomData.GenerateFile(fileName, 500);

		var tempFile = new FileInfo(fileName);

		try
		{
			_ = tempFile.ArgumentExists();
		}
		catch
		{
			Assert.Fail();
		}

		FileInfo nullFileInfo = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullFileInfo.ArgumentExists());

		_ = Assert.ThrowsException<FileNotFoundException>(() => new FileInfo("fakefile").ArgumentExists());

		tempFile.Delete();
	}

	[TestMethod]
	public void ArgumentExistsFileInfoWithDefaultTest()
	{
		var firstFileName = Path.Combine(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData,
				Environment.SpecialFolderOption.DoNotVerify),
			"tempfileinfotest.dat1");
		var firstTempFile = new FileInfo(firstFileName);

		var secondFileName = Path.Combine(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData,
				Environment.SpecialFolderOption.DoNotVerify),
			"tempfileinfotest.dat2");
		_ = RandomData.GenerateFile(secondFileName, 500);
		var secondTempFile = new FileInfo(secondFileName);

		try
		{
			var result = firstTempFile.ArgumentExists(secondTempFile);

			Assert.AreEqual(result, secondTempFile);
		}
		catch
		{
			Assert.Fail();
		}

		secondTempFile.Delete();
	}

	[TestMethod]
	public void ArgumentInRangeByteTest()
	{
		_ = byte.TryParse("0", out var lowerValue);
		_ = byte.TryParse("100", out var upperValue);
		_ = byte.TryParse("10", out var testValue);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);

			Assert.AreEqual(result, testValue);
		}
		catch
		{
			Assert.Fail();
		}

		//Test Exception
		_ = byte.TryParse("101", out var invalidValue);

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(
			() => invalidValue.ArgumentInRange(lowerValue, upperValue));
	}

	[TestMethod]
	public void ArgumentInRangeDateOnlyTest()
	{
		var lowerValue = new DateOnly(2021, 3, 3);
		var upperValue = new DateOnly(2025, 3, 3);
		var testValue = new DateOnly(2022, 3, 20);
		var outOfRangeLowerValue = new DateOnly(1900, 3, 3);
		var outOfRangeUpperValue = new DateOnly(1991, 3, 3);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(
			() => testValue.ArgumentInRange(outOfRangeLowerValue, outOfRangeUpperValue));
	}

	[TestMethod]
	public void ArgumentInRangeDateOnlyWithDefaultTest()
	{
		var lowerValue = new DateOnly(2000, 3, 3);
		var upperValue = new DateOnly(2001, 3, 3);
		var testValue = new DateOnly(2022, 3, 20);
		var defaultValue = new DateOnly(2022, 5, 5);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeDateTimeOffsetTest()
	{
		var lowerValue = new DateTimeOffset(new DateTime(2021, 3, 3));
		var upperValue = new DateTimeOffset(new DateTime(2025, 3, 3));
		var testValue = new DateTimeOffset(new DateTime(2022, 3, 20));
		var outOfRangeLowerValue = new DateTimeOffset(new DateTime(1900, 3, 3));
		var outOfRangeUpperValue = new DateTimeOffset(new DateTime(1991, 3, 3));

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(
			() => testValue.ArgumentInRange(outOfRangeLowerValue, outOfRangeUpperValue));
	}

	[TestMethod]
	public void ArgumentInRangeDateTimeOffsetWithDefaultTest()
	{
		var lowerValue = new DateTimeOffset(new DateTime(2000, 3, 3));
		var upperValue = new DateTimeOffset(new DateTime(2001, 3, 3));
		var testValue = new DateTimeOffset(new DateTime(2022, 3, 20));
		var defaultValue = new DateTimeOffset(new DateTime(2022, 5, 5));

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeDateTimeTest()
	{
		var lowerValue = new DateTime(2021, 3, 3);
		var upperValue = new DateTime(2025, 3, 3);
		var testValue = new DateTime(2022, 3, 20);
		var outOfRangeLower = new DateTime(1900, 3, 3);
		var outOfRangeUpper = new DateTime(1991, 3, 3);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(
			() => testValue.ArgumentInRange(outOfRangeLower, outOfRangeUpper));
	}

	[TestMethod]
	public void ArgumentInRangeDateTimeWithDefaultTest()
	{
		var lowerValue = new DateTime(2000, 3, 3);
		var upperValue = new DateTime(2001, 3, 3);
		var testValue = new DateTime(2022, 3, 20);
		var defaultValue = new DateTime(2022, 5, 5);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeDecimalTest()
	{
		var testValue = 10000m;

		try
		{
			var result = testValue.ArgumentInRange(0, decimal.MaxValue);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
	}

	[TestMethod]
	public void ArgumentInRangeDecimalWithDefaultTest()
	{
		var testValue = 10000m;
		var defaultValue = 10000m;

		try
		{
			var result = testValue.ArgumentInRange(0, 100, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeDoubleTest()
	{
		double testValue = 1000;

		try
		{
			var result = testValue.ArgumentInRange(0, double.MaxValue);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
	}

	[TestMethod]
	public void ArgumentInRangeDoubleWithDefaultTest()
	{
		double testValue = 1000;
		double defaultValue = 10000;

		try
		{
			var result = testValue.ArgumentInRange(0, 100, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeIntTest()
	{
		var testValue = 1000;

		try
		{
			var result = testValue.ArgumentInRange(0, max: int.MaxValue);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, max: 100));
	}

	[TestMethod]
	public void ArgumentInRangeIntWithDefaultTest()
	{
		var testValue = 1000;
		var defaultValue = 10000;

		try
		{
			var result = testValue.ArgumentInRange(0, max: 500, defaultValue: defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeLongTest()
	{
		long testValue = 1000;

		try
		{
			var result = testValue.ArgumentInRange(0, long.MaxValue);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
	}

	[TestMethod]
	public void ArgumentInRangeLongWithDefaultTest()
	{
		long testValue = 1000;
		long defaultValue = 10000;

		try
		{
			var result = testValue.ArgumentInRange(0, 100, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeStringTest()
	{
		var testValue = "dotNetTips.com";

		try
		{
			var result = testValue.ArgumentInRange(0, 50);

			Assert.AreEqual(testValue, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 2));
	}

	[TestMethod]
	public void ArgumentInRangeStringWithDefaultTest()
	{
		var testValue = "dotNetTips.com";
		var defaultValue = "Spargine";

		try
		{
			var result = testValue.ArgumentInRange(5, 10, defaultValue: defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentInRangeTimeOnlyTest()
	{
		var lowerValue = new TimeOnly(1, 3, 3);
		var upperValue = new TimeOnly(10, 3, 3);
		var testValue = new TimeOnly(5, 3, 20);
		var outOfRangeLowerValue = new TimeOnly(1, 3, 3);
		var outOfRangeUpperValue = new TimeOnly(2, 3, 3);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue);

			Assert.AreEqual(result, testValue);
		}
		catch
		{
			Assert.Fail();
		}

		// Test Exception
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(
			() => testValue.ArgumentInRange(outOfRangeLowerValue, outOfRangeUpperValue));
	}

	[TestMethod]
	public void ArgumentInRangeTimeOnlyWithDefaultTest()
	{
		var lowerValue = new TimeOnly(1, 3, 3);
		var upperValue = new TimeOnly(2, 3, 3);
		var testValue = new TimeOnly(5, 3, 20);
		var defaultValue = new TimeOnly(2, 3, 3);

		try
		{
			var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

			Assert.AreEqual(result, defaultValue);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentIsConditionTest()
	{
		var personProper = RandomData.GeneratePerson<Person>();

		try
		{
			var result = personProper.ArgumentMeetsCondition(
				personProper.Id.IsNotEmpty(),
				errorMessage: "Person is missing Id");

			Assert.IsNotNull(result);
		}
		catch
		{
			Assert.Fail();
		}

		//Test Exception
		_ = Assert.ThrowsException<ArgumentInvalidException>(
			() => personProper.ArgumentMeetsCondition(personProper.Id == "AA", errorMessage: "Person is missing Id"));
	}

	[TestMethod]
	public void ArgumentIsConditionWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10);

		try
		{
			var result = people.ArgumentMeetsCondition(people.Count == 10);

			Assert.IsNotNull(result);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentIsConditionWithDefaultTest()
	{
		try
		{
			var personProper1 = RandomData.GeneratePerson<Person>();
			var personProper2 = RandomData.GeneratePerson<Person>();

			var result = personProper1.ArgumentMeetsCondition(
				personProper1.Id == "AA",
				personProper2,
				errorMessage: "Person is missing Id");

			Assert.IsTrue(result == personProper2);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentIsDefinedEnumTest()
	{
		var value = BenchmarkStatus.Completed;

		try
		{
			var result = value.ArgumentDefined();

			Assert.AreEqual(value, result);
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => ((BenchmarkStatus)100).ArgumentDefined());
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyCollection_EmptyCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IReadOnlyCollection<int> input = new List<int>().AsReadOnly();

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => Validator.ArgumentItemsExists(input));
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyCollection_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		IReadOnlyCollection<int> input = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => Validator.ArgumentItemsExists(input));
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyCollection_ValidCollection_ReturnsInput()
	{
		// Arrange
		IReadOnlyCollection<int> input = new List<int> { 1, 2, 3 }.AsReadOnly();

		// Act
		var result = Validator.ArgumentItemsExists(input);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyCollection_WithErrorMessage_ThrowsArgumentNullException()
	{
		// Arrange
		IReadOnlyCollection<int> input = new List<int>().AsReadOnly();
		var errorMessage = "Custom error message";

		// Act & Assert
		var ex = Assert.ThrowsException<ArgumentNullException>(() => Validator.ArgumentItemsExists(input, errorMessage));
		Assert.IsTrue(ex.Message.Contains(errorMessage));
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyCollection_WithParamName_ThrowsArgumentNullException()
	{
		// Arrange
		IReadOnlyCollection<int> input = new List<int>().AsReadOnly();
		var paramName = "input";

		// Act & Assert
		var ex = Assert.ThrowsException<ArgumentNullException>(() => Validator.ArgumentItemsExists(input, paramName: paramName));
		Assert.IsTrue(ex.Message.Contains(paramName));
	}

	[TestMethod]
	public void ArgumentItemsExistsArrayTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection(10).ToArray();
			var result = people.ArgumentItemsExists(nameof(people));

			Assert.AreEqual(people, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null collection
		Person[] nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());
	}

	[TestMethod]
	public void ArgumentItemsExistsIEnumerableTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection(10).AsEnumerable();
			var result = people.ArgumentItemsExists();

			Assert.AreEqual(people, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null collection
		IEnumerable<Person> nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());
	}

	[TestMethod]
	public void ArgumentItemsExistsListTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection(10);
			var result = people.ArgumentItemsExists();

			Assert.AreEqual(people, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null collection
		List<Person> nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());
	}

	[TestMethod]
	public void ArgumentItemsExistsListWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).AsEnumerable();

		try
		{
			var result = people.ArgumentItemsExists(count: 10);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null
		IEnumerable<Person> nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists(10));

		// Test invalid WordCount
		_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => people.ArgumentItemsExists(5));
	}

	[TestMethod]
	public void ArgumentItemsExistsReadOnlyCollectionTest()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection(10).AsReadOnly();
			var result = people.ArgumentItemsExists();

			Assert.AreEqual(people, result);
		}
		catch
		{
			Assert.Fail();
		}

		// Test null collection
		ReadOnlyCollection<Person> nullPeople = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());
	}

	[TestMethod]
	public void ArgumentMatchedTest()
	{
		var expression = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
		var defaultValue = "DefaultValue";
		try
		{
			_ = GoodEmail.ArgumentMatched(expression);
		}
		catch
		{
			Assert.Fail();
		}

		// Test invalid match
		_ = Assert.ThrowsException<ArgumentInvalidException>(() => BadEmail.ArgumentMatched(expression));

		// Test default value
		var result = BadEmail.ArgumentMatched(expression, defaultValue: defaultValue);

		Assert.AreEqual(result, defaultValue);

		// Test null match
		_ = Assert.ThrowsException<ArgumentNullException>(() => GoodEmail.ArgumentMatched(null));
	}

	[TestMethod]
	public void ArgumentNotEmptyParamSpanTest01()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection(10).ToArray().AsSpan();

			_ = people.ArgumentNotEmpty();

			Assert.IsTrue(true);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentNotEmptyReadOnlySpanTest01()
	{
		try
		{
			var people = RandomData.GeneratePersonRefCollection(10).ToArray().AsReadOnlySpan();

			_ = people.ArgumentNotEmpty();
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentNotEmptyReadOnlySpanTest02()
	{
		try
		{
			var people = new ReadOnlySpan<Person>();

			_ = people.ArgumentNotEmpty();

			Assert.Fail();
		}
		catch
		{
			Assert.IsTrue(true);
		}
	}

	[TestMethod]
	public void ArgumentNotEmptySpanTest02()
	{
		try
		{
			var people = new Span<Person>();

			_ = people.ArgumentNotEmpty();

			Assert.Fail();
		}
		catch
		{
			Assert.IsTrue(true);
		}
	}

	[TestMethod]
	public void ArgumentNotNullObjectTest()
	{
		var testPerson = RandomData.GeneratePerson<Person>();
		try
		{
			_ = testPerson.ArgumentNotNull();
		}
		catch
		{
			Assert.Fail();
		}

		Person nullPerson = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullPerson.ArgumentNotNull());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyGuidTest()
	{
		var value = Guid.NewGuid();
		var defaultValue = Guid.NewGuid();

		try
		{
			_ = value.ArgumentNotNullOrEmpty();
		}
		catch
		{
			Assert.Fail();
		}

		// Test default value
		var result = Guid.Empty.ArgumentNotNullOrEmpty(defaultValue: defaultValue);

		Assert.AreEqual(result, defaultValue);

		// Test Bad value
		_ = Assert.ThrowsException<ArgumentInvalidException>(() => Guid.Empty.ArgumentNotNullOrEmpty());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyStringTest()
	{
		var testString = RandomData.GenerateWord(100);
		try
		{
			_ = testString.ArgumentNotNullOrEmpty();
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentNullException>(() => string.Empty.ArgumentNotNullOrEmpty());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyStringWithDefaultTest()
	{
		var testString = string.Empty;
		var defaultString = RandomData.GenerateWord(20);

		try
		{
			var result = testString.ArgumentNotNullOrEmpty(defaultValue: defaultString);

			Assert.AreEqual(result, defaultString);
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentNullException>(() => string.Empty.ArgumentNotNullOrEmpty());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyUriTest()
	{
		var uri = new Uri(@"http://dotNetTips.com");

		try
		{
			var result = uri.ArgumentNotNull();
		}
		catch
		{
			Assert.Fail();
		}

		// Test Null Uri
		Uri nullUri = null;
		_ = Assert.ThrowsException<ArgumentNullException>(() => nullUri.ArgumentNotNull());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmptyUriWithDefaultTest()
	{
		Uri uri = null;
		var defaultUri = new Uri(@"http://Spargine.com");

		try
		{
			var result = uri.ArgumentNotNull(defaultUri);

			Assert.AreEqual(result, defaultUri);
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ArgumentNotNullReadOnlySpanTest()
	{
		var testPeople =
			RandomData.GeneratePersonRefCollection(10).ToArray().AsReadOnlySpan();
		try
		{
			_ = testPeople.ArgumentNotEmpty();
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentNullException>(() => ReadOnlySpan<Person>.Empty.ArgumentNotEmpty());
	}

	[TestMethod]
	public void ArgumentNotNullSpanTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray().AsSpan();

		try
		{
			var result = people.ArgumentNotEmpty(nameof(people));
		}
		catch
		{
			Assert.Fail();
		}

		_ = Assert.ThrowsException<ArgumentNullException>(() => Span<Person>.Empty.ArgumentNotEmpty());
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		ICollection<int> input = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_ReadOnlyCollection_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		ICollection<int> input = new List<int>().AsReadOnly();

		// Act & Assert
		Assert.ThrowsException<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_ValidCollection_ReturnsInput()
	{
		// Arrange
		ICollection<int> input = new List<int> { 1, 2, 3 };

		// Act
		var result = Validator.ArgumentNotReadOnly(input);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_WithErrorMessage_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		ICollection<int> input = new List<int>().AsReadOnly();
		var errorMessage = "Custom error message";

		// Act & Assert
		var ex = Assert.ThrowsException<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input, errorMessage));
		Assert.IsTrue(ex.Message.Contains(errorMessage));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_WithParamName_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		ICollection<int> input = new List<int>().AsReadOnly();
		var paramName = "input";

		// Act & Assert
		var ex = Assert.ThrowsException<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input, paramName: paramName));
		Assert.IsTrue(ex.Message.Contains(paramName));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		IList<int> input = null;

		// Act & Assert
		Assert.ThrowsException<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_ReadOnlyList_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		IList<int> input = new List<int>().AsReadOnly();

		// Act & Assert
		Assert.ThrowsException<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_ValidList_ReturnsInput()
	{
		// Arrange
		IList<int> input = new List<int> { 1, 2, 3 };

		// Act
		var result = Validator.ArgumentNotReadOnly(input);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_WithErrorMessage_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		IList<int> input = new List<int>().AsReadOnly();
		var errorMessage = "Custom error message";

		// Act & Assert
		var ex = Assert.ThrowsException<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input, errorMessage));
		Assert.IsTrue(ex.Message.Contains(errorMessage));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_WithParamName_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		IList<int> input = new List<int>().AsReadOnly();
		var paramName = "input";

		// Act & Assert
		var ex = Assert.ThrowsException<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input, paramName: paramName));
		Assert.IsTrue(ex.Message.Contains(paramName));
	}

	[TestMethod]
	public void ArgumentNotReadOnlyListTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToList();

		try
		{
			var result = people.ArgumentNotReadOnly();
		}
		catch
		{
			Assert.Fail();
		}
	}

	[TestMethod]
	public void CheckEquals_NullExpectedType_ThrowsArgumentNullException()
	{
		// Arrange
		var input = typeof(string);
		Type expectedType = null;

		// Act & Assert
		Assert.ThrowsException<InvalidValueException<Type>>(() => Validator.CheckTypeEquals(input, expectedType, true));
	}

	[TestMethod]
	public void CheckEquals_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		Type input = null;
		var expectedType = typeof(string);

		// Act & Assert
		Assert.ThrowsException<InvalidValueException<Type>>(() => Validator.CheckTypeEquals(input, expectedType, true));
	}

	[TestMethod]
	public void CheckEquals_TypesDoNotMatch_ReturnsFalse()
	{
		// Arrange
		var input = typeof(string);
		var expectedType = typeof(int);

		// Act
		var result = Validator.CheckTypeEquals(input, expectedType);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckEquals_TypesDoNotMatch_ThrowsException()
	{
		// Arrange
		var input = typeof(string);
		var expectedType = typeof(int);
		var errorMessage = "Types do not match";

		// Act & Assert
		var ex = Assert.ThrowsException<InvalidValueException<Type>>(() => Validator.CheckTypeEquals(input, expectedType, true, errorMessage));
		Assert.IsTrue(ex.Message.Contains(errorMessage));
	}

	[TestMethod]
	public void CheckEquals_TypesMatch_DoesNotThrowException()
	{
		// Arrange
		var input = typeof(string);
		var expectedType = typeof(string);

		// Act & Assert
		Validator.CheckTypeEquals(input, expectedType, true);

		// No exception means the test passed.
	}

	[TestMethod]
	public void CheckEquals_TypesMatch_ReturnsTrue()
	{
		// Arrange
		var input = typeof(string);
		var expectedType = typeof(string);

		// Act
		var result = Validator.CheckTypeEquals(input, expectedType);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckEquals_WithDefaultErrorMessage_ThrowsException()
	{
		// Arrange
		var input = typeof(string);
		var expectedType = typeof(int);

		// Act & Assert
		var ex = Assert.ThrowsException<InvalidValueException<Type>>(() => Validator.CheckTypeEquals(input, expectedType, true));
		Assert.IsTrue(ex.Message.Contains("Invalid type"));
	}

	[TestMethod]
	public void CheckIsCondition_ConditionFalse_ReturnsFalse()
	{
		// Arrange
		var input = 5;
		var condition = false;

		// Act
		var result = Validator.CheckIsCondition(input, condition);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsCondition_ConditionFalse_ThrowsException()
	{
		// Arrange
		var input = 5;
		var condition = false;
		var errorMessage = "Condition not met";

		// Act & Assert
		var ex = Assert.ThrowsException<InvalidValueException<object>>(() => Validator.CheckIsCondition(input, condition, true, errorMessage));
		Assert.IsTrue(ex.Message.Contains(errorMessage));
	}

	[TestMethod]
	public void CheckIsCondition_ConditionTrue_DoesNotThrowException()
	{
		// Arrange
		var input = 5;
		var condition = true;

		// Act & Assert
		Validator.CheckIsCondition(input, condition, true);

		// No exception means the test passed.
	}

	[TestMethod]
	public void CheckIsCondition_ConditionTrue_ReturnsTrue()
	{
		// Arrange
		var input = 5;
		var condition = true;

		// Act
		var result = Validator.CheckIsCondition(input, condition);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsCondition_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		string input = null;
		var condition = true;

		// Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => Validator.CheckIsCondition(input, condition));
	}

	[TestMethod]
	public void CheckIsCondition_WithDefaultErrorMessage_ThrowsException()
	{
		// Arrange
		var input = 5;
		var condition = false;

		// Act & Assert
		var ex = Assert.ThrowsException<InvalidValueException<object>>(() => Validator.CheckIsCondition(input, condition, true));
		Assert.IsTrue(ex.Message.Contains("Invalid value"));
	}

	[TestMethod]
	public void CheckIsDefined_EnumValueDefined_DoesNotThrowException()
	{
		// Arrange
		var input = TestEnum.Value1;

		// Act & Assert
		Validator.CheckIsDefined(input, true);

		// No exception means the test passed.
	}

	[TestMethod]
	public void CheckIsDefined_EnumValueDefined_ReturnsTrue()
	{
		// Arrange
		var input = TestEnum.Value1;

		// Act
		var result = Validator.CheckIsDefined(input);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsDefined_EnumValueNotDefined_ReturnsFalse()
	{
		// Arrange
		var input = (TestEnum)999;

		// Act
		var result = Validator.CheckIsDefined(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsDefined_EnumValueNotDefined_ThrowsException()
	{
		// Arrange
		var input = (TestEnum)999;
		var errorMessage = "Enum value is not defined";

		// Act & Assert
		var ex = Assert.ThrowsException<InvalidValueException<Enum>>(() => Validator.CheckIsDefined(input, true, errorMessage));
		Assert.IsTrue(ex.Message.Contains(errorMessage));
	}

	[TestMethod]
	public void CheckIsDefined_WithDefaultErrorMessage_ThrowsException()
	{
		// Arrange
		var input = (TestEnum)999;

		// Act & Assert
		var ex = Assert.ThrowsException<InvalidValueException<Enum>>(() => Validator.CheckIsDefined(input, true));
		Assert.IsTrue(ex.Message.Contains("The value is not defined in the Enum."));
	}

	[TestMethod]
	public void CheckIsNotEmpty_Guid_Empty_ReturnsFalse()
	{
		// Arrange
		var input = Guid.Empty;

		// Act
		var result = Validator.CheckIsNotEmpty(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsNotEmpty_Guid_Empty_ThrowsException()
	{
		// Arrange
		var input = Guid.Empty;
		var errorMessage = "GUID is empty";

		// Act & Assert
		var ex = Assert.ThrowsException<InvalidOperationException>(() => Validator.CheckIsNotEmpty(input, true, errorMessage));
		Assert.IsTrue(ex.Message.Contains(errorMessage));
	}

	[TestMethod]
	public void CheckIsNotEmpty_Guid_NotEmpty_DoesNotThrowException()
	{
		// Arrange
		var input = Guid.NewGuid();

		// Act & Assert
		Validator.CheckIsNotEmpty(input, true);

		// No exception means the test passed.
	}

	[TestMethod]
	public void CheckIsNotEmpty_Guid_NotEmpty_ReturnsTrue()
	{
		// Arrange
		var input = Guid.NewGuid();

		// Act
		var result = Validator.CheckIsNotEmpty(input);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotEmpty_ReadOnlySpan_Empty_ReturnsFalse()
	{
		// Arrange
		var input = new ReadOnlySpan<int>(Array.Empty<int>());

		// Act
		var result = Validator.CheckIsNotEmpty(input);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsNotEmpty_ReadOnlySpan_NotEmpty_DoesNotThrowException()
	{
		// Arrange
		var input = new ReadOnlySpan<int>(new[] { 1, 2, 3 });

		// Act & Assert
		Validator.CheckIsNotEmpty(input, true);

		// No exception means the test passed.
	}

	[TestMethod]
	public void CheckIsNotEmpty_ReadOnlySpan_NotEmpty_ReturnsTrue()
	{
		// Arrange
		var input = new ReadOnlySpan<int>(new[] { 1, 2, 3 });

		// Act
		var result = Validator.CheckIsNotEmpty(input);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_ConsistentResults_MultipleCallsSameInput()
	{
		// Arrange
		var input = "Test String";

		// Act
		var result1 = input.CheckIsNotNullOrEmpty();
		var result2 = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.AreEqual(result1, result2);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_EmojiString_ReturnsTrue()
	{
		// Arrange
		var input = "😀😁😂";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_EmptyString_ReturnsFalse()
	{
		// Arrange
		var input = string.Empty;

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void CheckIsNotNullOrEmpty_EmptyStringWithThrowException_ThrowsArgumentNullException()
	{
		// Arrange
		var input = string.Empty;

		// Act
		_ = input.CheckIsNotNullOrEmpty(throwException: true);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_EmptyWithoutThrowException_DoesNotThrow()
	{
		// Arrange
		var input = string.Empty;

		// Act
		var result = input.CheckIsNotNullOrEmpty(throwException: false);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_LongString_ReturnsTrue()
	{
		// Arrange
		var input = new string('A', 1000);

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_MixedWhitespaceAndText_ReturnsTrue()
	{
		// Arrange
		var input = "  Hello  ";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_NullString_ReturnsFalse()
	{
		// Arrange
		string input = null;

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void CheckIsNotNullOrEmpty_NullStringWithThrowException_ThrowsArgumentNullException()
	{
		// Arrange
		string input = null;

		// Act
		_ = input.CheckIsNotNullOrEmpty(throwException: true);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_NullWithoutThrowException_DoesNotThrow()
	{
		// Arrange
		string input = null;

		// Act
		var result = input.CheckIsNotNullOrEmpty(throwException: false);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_NumericString_ReturnsTrue()
	{
		// Arrange
		var input = "12345";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_SingleCharacterString_ReturnsTrue()
	{
		// Arrange
		var input = "A";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_StringWithNewLine_ReturnsTrue()
	{
		// Arrange
		var input = "\n";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_StringWithSpecialCharacters_ReturnsTrue()
	{
		// Arrange
		var input = "!@#$%^&*()";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_StringWithTab_ReturnsTrue()
	{
		// Arrange
		var input = "\t";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_UnicodeString_ReturnsTrue()
	{
		// Arrange
		var input = "こんにちは";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}


	[TestMethod]
	public void CheckIsNotNullOrEmpty_ValidString_ReturnsTrue()
	{
		// Arrange
		var input = "Valid String";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_WhitespaceString_ReturnsTrue()
	{
		// Arrange
		var input = "   ";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result, "Whitespace-only string should return true as it's not empty");
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		string input = null;
		var customMessage = "Custom error: String cannot be null or empty";

		try
		{
			// Act
			_ = input.CheckIsNotNullOrEmpty(throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentNullException was not thrown.");
		}
		catch (ArgumentNullException ex)
		{
			// Assert
			Assert.IsTrue(ex.Message.Contains(customMessage));
		}
	}

	[TestMethod]
	public void CheckIsNotNullOrEmpty_ZeroString_ReturnsTrue()
	{
		// Arrange
		var input = "0";

		// Act
		var result = input.CheckIsNotNullOrEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void TestNotNullCollectionWithErrorMessage()
	{
		// Arrange
		var collection = new Collection<string> { "item1", "item2" };
		var errorMessage = "Collection should not be null.";

		// Act & Assert
		Validator.ArgumentNotNull(collection, errorMessage, paramName: nameof(collection));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void TestNullCollectionWithErrorMessage()
	{
		// Arrange
		Collection<string> collection = null;
		var errorMessage = "Collection should not be null.";

		// Act
		Validator.ArgumentNotNull(collection, errorMessage, paramName: nameof(collection));

		// Assert is handled by ExpectedException
	}

	public enum TestEnum
	{
		Value1,
		Value2
	}
}
