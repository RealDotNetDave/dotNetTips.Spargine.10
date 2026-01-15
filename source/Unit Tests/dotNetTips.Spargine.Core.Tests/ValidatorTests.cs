// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-29-2025
// ***********************************************************************
// <copyright file="ValidatorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public partial class ValidatorTests
{
	private const string BadEmail = "BAD@EMAIL";
	private const string GoodEmail = "fakeemail@google.com";

	[TestMethod]
	public void ArgumentCountInRange_CountAboveMax_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => Validator.ArgumentCountInRange(list, 1, 3));
	}

	[TestMethod]
	public void ArgumentCountInRange_CountBelowMin_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var list = new List<int> { 1 };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => Validator.ArgumentCountInRange(list, 2, 5));
	}

	[TestMethod]
	public void ArgumentCountInRange_EmptyCollection_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var list = new List<int>();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => list.ArgumentCountInRange(1, 5));
	}

	[TestMethod]
	public void ArgumentCountInRange_ExactMaxCount_ReturnsCollection()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = list.ArgumentCountInRange(1, 5);

		// Assert
		Assert.AreEqual(list, result);
	}

	[TestMethod]
	public void ArgumentCountInRange_ExactMinCount_ReturnsCollection()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };

		// Act
		var result = list.ArgumentCountInRange(3, 10);

		// Assert
		Assert.AreEqual(list, result);
	}

	[TestMethod]
	public void ArgumentCountInRange_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		List<int> list = null!;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.ArgumentCountInRange(list, 1, 3));
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
	public void ArgumentCountInRange_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5, 6 };
		var customMessage = "Collection count is outside the acceptable range";

		try
		{
			// Act
			_ = list.ArgumentCountInRange(1, 3, customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
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
	public void ArgumentCustom_GuidValidation_Failure()
	{
		// Arrange
		var input = Guid.Empty;
		Func<Guid, bool> predicate = g => g != Guid.Empty;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => input.ArgumentCustom(predicate));
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
	public void ArgumentCustom_InvalidPredicate_ThrowsArgumentInvalidException()
	{
		// Arrange
		var input = -5;
		Func<int, bool> predicate = x => x > 0;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => input.ArgumentCustom(predicate));
	}

	[TestMethod]
	public void ArgumentCustom_ListValidation_Failure()
	{
		// Arrange
		var input = new List<int> { 1, -2, 3, 4, 5 };
		Func<List<int>, bool> predicate = list => list.Count > 0 && list.All(x => x > 0);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => input.ArgumentCustom(predicate));
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
	public void ArgumentCustom_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		string input = null;
		Func<string, bool> predicate = s => s.Length > 0;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.ArgumentCustom(predicate));
	}

	[TestMethod]
	public void ArgumentCustom_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		var input = "test";
		Func<string, bool> predicate = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.ArgumentCustom(predicate));
	}

	[TestMethod]
	public void ArgumentCustom_PredicateWithMultipleConditions_Failure()
	{
		// Arrange
		var input = 23;
		Func<int, bool> predicate = x => x > 0 && x < 100 && x % 5 == 0;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => input.ArgumentCustom(predicate));
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
	public void ArgumentCustom_RangeValidation_Failure()
	{
		// Arrange
		var input = 150.5;
		Func<double, bool> predicate = x => x >= 0.0 && x <= 100.0;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => input.ArgumentCustom(predicate));
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
	public void ArgumentCustom_StringLengthValidation_Failure()
	{
		// Arrange
		var input = "Hi";
		Func<string, bool> predicate = s => s.Length >= 5 && s.Length <= 20;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => input.ArgumentCustom(predicate));
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
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentDefined_StatusEnum_InvalidValue_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var value = (Status)999;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => value.ArgumentDefined());
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
	public void ArgumentDefined_ValidEnumValue_ReturnsValue()
	{
		// Arrange
		var input = BenchmarkStatus.Completed;

		// Act
		var result = input.ArgumentDefined();

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentDefined_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = (Status)999;
		var customMessage = "Invalid status value provided";

		try
		{
			// Act
			_ = input.ArgumentDefined(customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
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
	public void ArgumentExists_DirectoryInfo_ExistingDirectory_ReturnsDirectory()
	{
		// Arrange
		var input = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.System));

		// Act
		var result = input.ArgumentExists();

		// Assert
		Assert.AreEqual(input.FullName, result.FullName);
	}

	[TestMethod]
	public void ArgumentExists_DirectoryInfo_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new DirectoryInfo("C:\\NonExistentDirectory123456789");
		var customMessage = "The specified directory does not exist";

		try
		{
			// Act
			_ = input.ArgumentExists(errorMessage: customMessage);
			Assert.Fail("Expected DirectoryNotFoundException was not thrown.");
		}
		catch (DirectoryNotFoundException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentExists_FileInfo_ExistingFile_ReturnsFile()
	{
		// Arrange
		var fileName = RandomData.GenerateRandomFileName();
		_ = RandomData.GenerateFile(fileName, 100);
		var input = new FileInfo(fileName);

		try
		{
			// Act
			var result = input.ArgumentExists();

			// Assert
			Assert.AreEqual(input.FullName, result.FullName);
		}
		finally
		{
			// Cleanup
			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}
		}
	}

	[TestMethod]
	public void ArgumentExists_FileInfo_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new FileInfo("C:\\NonExistentFile123456789.txt");
		var customMessage = "The specified file does not exist";

		try
		{
			// Act
			_ = input.ArgumentExists(errorMessage: customMessage);
			Assert.Fail("Expected FileNotFoundException was not thrown.");
		}
		catch (FileNotFoundException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullDirectoryInfo.ArgumentExists());

		var fakeDirectory = new DirectoryInfo("fakefile");
		_ = Assert.ThrowsExactly<System.IO.DirectoryNotFoundException>(() => Directory.Delete(fakeDirectory.FullName));
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullFileInfo.ArgumentExists());

		_ = Assert.ThrowsExactly<FileNotFoundException>(() => new FileInfo("fakefile").ArgumentExists());

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
	public void ArgumentInRange_Byte_BoundaryValues_MaxValue()
	{
		// Arrange
		byte input = byte.MaxValue;

		// Act
		var result = input.ArgumentInRange(byte.MinValue, byte.MaxValue);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentInRange_Byte_BoundaryValues_MinValue()
	{
		// Arrange
		byte input = byte.MinValue;

		// Act
		var result = input.ArgumentInRange(byte.MinValue, byte.MaxValue);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentInRange_Byte_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		byte input = 200;
		var customMessage = "Byte value must be between 0 and 100";

		try
		{
			// Act
			_ = input.ArgumentInRange(0, 100, customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRange_DateOnly_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new DateOnly(2025, 1, 1);
		var min = new DateOnly(2020, 1, 1);
		var max = new DateOnly(2022, 1, 1);
		var customMessage = "Date must be between 2020 and 2022";

		try
		{
			// Act
			_ = input.ArgumentInRange(min, max, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRange_DateTime_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new DateTime(2025, 1, 1);
		var min = new DateTime(2020, 1, 1);
		var max = new DateTime(2022, 1, 1);
		var customMessage = "Date must be between 2020 and 2022";

		try
		{
			// Act
			_ = input.ArgumentInRange(min, max, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRange_DateTimeOffset_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new DateTimeOffset(new DateTime(2025, 1, 1));
		var min = new DateTimeOffset(new DateTime(2020, 1, 1));
		var max = new DateTimeOffset(new DateTime(2022, 1, 1));
		var customMessage = "DateTimeOffset must be between 2020 and 2022";

		try
		{
			// Act
			_ = input.ArgumentInRange(min, max, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRange_Decimal_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		decimal input = 500.5m;
		var customMessage = "Value must be between 0 and 100";

		try
		{
			// Act
			_ = input.ArgumentInRange(0, 100, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRange_Double_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		double input = 500.5;
		var customMessage = "Value must be between 0 and 100";

		try
		{
			// Act
			_ = input.ArgumentInRange(0, 100, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRange_Int_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = 500;
		var customMessage = "Value must be between 0 and 100";

		try
		{
			// Act
			_ = input.ArgumentInRange(0, max: 100, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRange_Long_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		long input = 5000L;
		var customMessage = "Value must be between 0 and 1000";

		try
		{
			// Act
			_ = input.ArgumentInRange(0, 1000, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
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

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, max: 100));
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 100));
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
	public void ArgumentInRangeString_NoTrim_ReturnsUntrimmed()
	{
		// Arrange
		var testValue = "  Test  ";

		// Act
		var result = testValue.ArgumentInRange(0, 10, trim: false);

		// Assert
		Assert.AreEqual(testValue, result);
	}

	[TestMethod]
	public void ArgumentInRangeString_NullString_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		string testValue = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(1, 10));
	}

	[TestMethod]
	public void ArgumentInRangeString_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var testValue = "Test";
		var customMessage = "String length must be between 10 and 20 characters";

		try
		{
			// Act
			_ = testValue.ArgumentInRange(10, 20, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRangeString_WithDefaultValue_ReturnsDefaultValue()
	{
		// Arrange
		var testValue = "This is a very long string that exceeds the maximum length";
		var defaultValue = "Default";

		// Act
		var result = testValue.ArgumentInRange(0, 10, defaultValue: defaultValue);

		// Assert
		Assert.AreEqual(defaultValue, result);
	}

	[TestMethod]
	public void ArgumentInRangeString_WithTrim_ReturnsTrimmedString()
	{
		// Arrange
		var testValue = "  Test  ";

		// Act
		var result = testValue.ArgumentInRange(0, 10, trim: true);

		// Assert
		Assert.AreEqual("Test", result);
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue.ArgumentInRange(0, 2));
	}

	[TestMethod]
	public void ArgumentInRangeTimeOnly_ExactMaxTime_ReturnsValue()
	{
		// Arrange
		var lowerValue = new TimeOnly(9, 0, 0);
		var upperValue = new TimeOnly(17, 0, 0);
		var testValue = new TimeOnly(17, 0, 0);

		// Act
		var result = testValue.ArgumentInRange(lowerValue, upperValue);

		// Assert
		Assert.AreEqual(testValue, result);
	}

	[TestMethod]
	public void ArgumentInRangeTimeOnly_ExactMinTime_ReturnsValue()
	{
		// Arrange
		var lowerValue = new TimeOnly(9, 0, 0);
		var upperValue = new TimeOnly(17, 0, 0);
		var testValue = new TimeOnly(9, 0, 0);

		// Act
		var result = testValue.ArgumentInRange(lowerValue, upperValue);

		// Assert
		Assert.AreEqual(testValue, result);
	}

	[TestMethod]
	public void ArgumentInRangeTimeOnly_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var lowerValue = new TimeOnly(9, 0, 0);
		var upperValue = new TimeOnly(10, 0, 0);
		var testValue = new TimeOnly(15, 0, 0);
		var customMessage = "Time must be between 9 AM and 10 AM";

		try
		{
			// Act
			_ = testValue.ArgumentInRange(lowerValue, upperValue, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentInRangeTimeOnly_WithDefaultValue_ReturnsDefaultValue()
	{
		// Arrange
		var lowerValue = new TimeOnly(9, 0, 0);
		var upperValue = new TimeOnly(10, 0, 0);
		var testValue = new TimeOnly(15, 0, 0);
		var defaultValue = new TimeOnly(9, 30, 0);

		// Act
		var result = testValue.ArgumentInRange(lowerValue, upperValue, defaultValue);

		// Assert
		Assert.AreEqual(defaultValue, result);
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
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
			() => testValue.ArgumentInRange(outOfRangeLowerValue, outOfRangeUpperValue));
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
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(
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

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => ((BenchmarkStatus)100).ArgumentDefined());
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyCollection_EmptyCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IReadOnlyCollection<int> input = new List<int>().AsReadOnly();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.ArgumentItemsExists(input));
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyCollection_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		IReadOnlyCollection<int> input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.ArgumentItemsExists(input));
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
		var ex = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.ArgumentItemsExists(input, errorMessage));
		Assert.Contains(errorMessage, ex.Message);
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyCollection_WithParamName_ThrowsArgumentNullException()
	{
		// Arrange
		IReadOnlyCollection<int> input = new List<int>().AsReadOnly();
		var paramName = "input";

		// Act & Assert
		var ex = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.ArgumentItemsExists(input, paramName: paramName));
		Assert.Contains(paramName, ex.Message);
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyList_EmptyList_ThrowsArgumentNullException()
	{
		// Arrange
		IReadOnlyList<int> input = new List<int>().AsReadOnly();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.ArgumentItemsExists());
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyList_ValidList_ReturnsList()
	{
		// Arrange
		IReadOnlyList<int> input = new List<int> { 1, 2, 3 }.AsReadOnly();

		// Act
		var result = input.ArgumentItemsExists();

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentItemsExists_IReadOnlyList_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		IReadOnlyList<int> input = new List<int>().AsReadOnly();
		var customMessage = "The list must contain items";

		try
		{
			// Act
			_ = input.ArgumentItemsExists(customMessage);
			Assert.Fail("Expected ArgumentNullException was not thrown.");
		}
		catch (ArgumentNullException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentItemsExists_WithCount_ExactCount_ReturnsCollection()
	{
		// Arrange
		var input = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		// Act
		var result = input.ArgumentItemsExists(5);

		// Assert
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ArgumentItemsExists_WithCount_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new List<int> { 1, 2, 3 }.AsEnumerable();
		var customMessage = "Collection must have exactly 5 items";

		try
		{
			// Act
			_ = input.ArgumentItemsExists(5, customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentItemsExists_WithCount_WrongCount_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var input = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => input.ArgumentItemsExists(5));
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullPeople.ArgumentItemsExists(10));

		// Test invalid WordCount
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => people.ArgumentItemsExists(5));
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullPeople.ArgumentItemsExists());
	}

	[TestMethod]
	public void ArgumentMatched_EmptyString_ThrowsArgumentNullException()
	{
		// Arrange
		var input = string.Empty;
		var pattern = MyRegex();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.ArgumentMatched(pattern));
	}

	[TestMethod]
	public void ArgumentMatched_NoTrim_ReturnsUntrimmedString()
	{
		// Arrange
		var input = "  test  ";
		var pattern = new Regex(@"^\s+\w+\s+$");

		// Act
		var result = input.ArgumentMatched(pattern, trim: false);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentMatched_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = "invalid-email";
		var pattern = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
		var customMessage = "Invalid email format provided";

		try
		{
			// Act
			_ = input.ArgumentMatched(pattern, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentInvalidException was not thrown.");
		}
		catch (ArgumentInvalidException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentMatched_WithTrim_ReturnsTrimmedString()
	{
		// Arrange
		var input = "  test@example.com  ";
		var pattern = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");

		// Act
		var result = input.ArgumentMatched(pattern, trim: true);

		// Assert
		Assert.AreEqual("test@example.com", result);
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
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => BadEmail.ArgumentMatched(expression));

		// Test default value
		var result = BadEmail.ArgumentMatched(expression, defaultValue: defaultValue);

		Assert.AreEqual(result, defaultValue);

		// Test null match
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => GoodEmail.ArgumentMatched(null));
	}

	[TestMethod]
	public void ArgumentMeetsCondition_ComplexCondition_ReturnsInput()
	{
		// Arrange
		var input = 42;
		var condition = input > 0 && input < 100 && input % 2 == 0;

		// Act
		var result = input.ArgumentMeetsCondition(condition);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentMeetsCondition_NullInputWithConditionTrue_ThrowsArgumentInvalidException()
	{
		// Arrange
		Person input = null;
		var condition = true;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => input.ArgumentMeetsCondition(condition));
	}

	[TestMethod]
	public void ArgumentMeetsCondition_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = 5;
		var condition = false;
		var customMessage = "Value must meet the specified condition";

		try
		{
			// Act
			_ = input.ArgumentMeetsCondition(condition, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentInvalidException was not thrown.");
		}
		catch (ArgumentInvalidException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentNotEmpty_ReadOnlySpan_NonEmptySpan_ReturnsSpan()
	{
		// Arrange
		var array = new[] { 1, 2, 3 };
		var input = new ReadOnlySpan<int>(array);

		// Act
		var result = input.ArgumentNotEmpty();

		// Assert
		Assert.AreEqual(input.Length, result.Length);
	}

	[TestMethod]
	public void ArgumentNotEmpty_ReadOnlySpan_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new ReadOnlySpan<int>();
		var customMessage = "ReadOnlySpan cannot be empty";

		try
		{
			// Act
			_ = input.ArgumentNotEmpty(customMessage);
			Assert.Fail("Expected ArgumentNullException was not thrown.");
		}
		catch (ArgumentNullException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentNotEmpty_Span_NonEmptySpan_ReturnsSpan()
	{
		// Arrange
		var array = new[] { 1, 2, 3 };
		var input = new Span<int>(array);

		// Act
		var result = input.ArgumentNotEmpty();

		// Assert
		Assert.AreEqual(input.Length, result.Length);
	}

	[TestMethod]
	public void ArgumentNotEmpty_Span_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new Span<int>();
		var customMessage = "Span cannot be empty";

		try
		{
			// Act
			_ = input.ArgumentNotEmpty(customMessage);
			Assert.Fail("Expected ArgumentNullException was not thrown.");
		}
		catch (ArgumentNullException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
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
	public void ArgumentNotNull_Collection_WithDefaultValue_ReturnsDefaultValue()
	{
		// Arrange
		Collection<int> input = null;
		var defaultValue = new Collection<int> { 1, 2, 3 };

		// Act
		var result = input.ArgumentNotNull(defaultValue);

		// Assert
		Assert.AreEqual(defaultValue, result);
	}

	[TestMethod]
	public void ArgumentNotNull_GenericType_WithDefaultValue_ReturnsDefaultValue()
	{
		// Arrange
		Person input = null;
		var defaultValue = RandomData.GeneratePerson<Person>();

		// Act
		var result = input.ArgumentNotNull(defaultValue);

		// Assert
		Assert.AreEqual(defaultValue, result);
	}

	[TestMethod]
	public void ArgumentNotNull_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		Person input = null;
		var customMessage = "Person object cannot be null";

		try
		{
			// Act
			_ = input.ArgumentNotNull(errorMessage: customMessage);
			Assert.Fail("Expected ArgumentNullException was not thrown.");
		}
		catch (ArgumentNullException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullPerson.ArgumentNotNull());
	}

	[TestMethod]
	public void ArgumentNotNullOrEmpty_Guid_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = Guid.Empty;
		var customMessage = "GUID must have a value";

		try
		{
			// Act
			_ = input.ArgumentNotNullOrEmpty(errorMessage: customMessage);
			Assert.Fail("Expected ArgumentInvalidException was not thrown.");
		}
		catch (ArgumentInvalidException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentNotNullOrEmpty_String_NoTrim_ReturnsOriginalString()
	{
		// Arrange
		var input = "   Test   ";

		// Act
		var result = input.ArgumentNotNullOrEmpty(trim: false);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentNotNullOrEmpty_String_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = string.Empty;
		var customMessage = "String value is required";

		try
		{
			// Act
			_ = input.ArgumentNotNullOrEmpty(errorMessage: customMessage);
			Assert.Fail("Expected ArgumentNullException was not thrown.");
		}
		catch (ArgumentNullException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentNotNullOrEmpty_String_WithTrim_ReturnsTrimmedString()
	{
		// Arrange
		var input = "   Test   ";

		// Act
		var result = input.ArgumentNotNullOrEmpty(trim: true);

		// Assert
		Assert.AreEqual("Test", result);
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
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => Guid.Empty.ArgumentNotNullOrEmpty());
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

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => string.Empty.ArgumentNotNullOrEmpty());
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

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => string.Empty.ArgumentNotNullOrEmpty());
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullUri.ArgumentNotNull());
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

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ReadOnlySpan<Person>.Empty.ArgumentNotEmpty());
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

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Span<Person>.Empty.ArgumentNotEmpty());
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		ICollection<int> input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_ReadOnlyCollection_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		ICollection<int> input = new List<int>().AsReadOnly();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input));
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
	public void ArgumentNotReadOnly_ICollection_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		ICollection<int> input = new List<int>().AsReadOnly();
		var customMessage = "The collection cannot be read-only";

		try
		{
			// Act
			_ = input.ArgumentNotReadOnly(customMessage);
			Assert.Fail("Expected ArgumentReadOnlyException was not thrown.");
		}
		catch (ArgumentReadOnlyException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_WithErrorMessage_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		ICollection<int> input = new List<int>().AsReadOnly();
		var errorMessage = "Custom error message";

		// Act & Assert
		var ex = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input, errorMessage));
		Assert.Contains(errorMessage, ex.Message);
	}

	[TestMethod]
	public void ArgumentNotReadOnly_ICollection_WithParamName_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		ICollection<int> input = new List<int>().AsReadOnly();
		var paramName = "input";

		// Act & Assert
		var ex = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input, paramName: paramName));
		Assert.Contains(paramName, ex.Message);
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		IList<int> input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input));
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_ReadOnlyList_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		IList<int> input = new List<int>().AsReadOnly();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input));
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
	public void ArgumentNotReadOnly_IList_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		IList<int> input = new List<int>().AsReadOnly();
		var customMessage = "The list cannot be read-only";

		try
		{
			// Act
			_ = input.ArgumentNotReadOnly(customMessage);
			Assert.Fail("Expected ArgumentReadOnlyException was not thrown.");
		}
		catch (ArgumentReadOnlyException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_WithErrorMessage_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		IList<int> input = new List<int>().AsReadOnly();
		var errorMessage = "Custom error message";

		// Act & Assert
		var ex = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input, errorMessage));
		Assert.Contains(errorMessage, ex.Message);
	}

	[TestMethod]
	public void ArgumentNotReadOnly_IList_WithParamName_ThrowsArgumentReadOnlyException()
	{
		// Arrange
		IList<int> input = new List<int>().AsReadOnly();
		var paramName = "input";

		// Act & Assert
		var ex = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => Validator.ArgumentNotReadOnly(input, paramName: paramName));
		Assert.Contains(paramName, ex.Message);
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
	public void ArgumentTypeEquals_DifferentTypes_ThrowsArgumentInvalidException()
	{
		// Arrange
		var input = typeof(Person);
		var expectedType = typeof(Address);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => input.ArgumentTypeEquals(expectedType));
	}

	[TestMethod]
	public void ArgumentTypeEquals_NullExpectedType_ThrowsArgumentNullException()
	{
		// Arrange
		var input = typeof(Person);
		Type expectedType = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.ArgumentTypeEquals(expectedType));
	}

	[TestMethod]
	public void ArgumentTypeEquals_SameType_ReturnsType()
	{
		// Arrange
		var input = typeof(Person);
		var expectedType = typeof(Person);

		// Act
		var result = input.ArgumentTypeEquals(expectedType);

		// Assert
		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void ArgumentTypeEquals_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = typeof(string);
		var expectedType = typeof(int);
		var customMessage = "Type mismatch detected";

		try
		{
			// Act
			_ = input.ArgumentTypeEquals(expectedType, customMessage);
			Assert.Fail("Expected ArgumentInvalidException was not thrown.");
		}
		catch (ArgumentInvalidException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void CheckEquals_NullExpectedType_ThrowsArgumentNullException()
	{
		// Arrange
		var input = typeof(string);
		Type expectedType = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<Type>>(() => Validator.CheckTypeEquals(input, expectedType, true));
	}

	[TestMethod]
	public void CheckEquals_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		Type input = null;
		var expectedType = typeof(string);

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<Type>>(() => Validator.CheckTypeEquals(input, expectedType, true));
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
		var ex = Assert.ThrowsExactly<InvalidValueException<Type>>(() => Validator.CheckTypeEquals(input, expectedType, true, errorMessage));
		Assert.Contains(errorMessage, ex.Message);
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
		var ex = Assert.ThrowsExactly<InvalidValueException<Type>>(() => Validator.CheckTypeEquals(input, expectedType, true));
		Assert.Contains("Invalid type", ex.Message);
	}

	[TestMethod]
	public void CheckExists_DirectoryInfo_ExistingDirectory_ReturnsTrue()
	{
		// Arrange
		var input = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.System));

		// Act
		var result = input.CheckExists();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckExists_DirectoryInfo_NonExistingDirectory_ReturnsFalse()
	{
		// Arrange
		var input = new DirectoryInfo("C:\\NonExistentDirectory123456789");

		// Act
		var result = input.CheckExists();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckExists_DirectoryInfo_NonExistingDirectoryWithThrowException_ThrowsDirectoryNotFoundException()
	{
		// Arrange
		var input = new DirectoryInfo("C:\\NonExistentDirectory123456789");

		// Act & Assert
		_ = Assert.ThrowsExactly<DirectoryNotFoundException>(() => input.CheckExists(throwException: true));
	}

	[TestMethod]
	public void CheckExists_DirectoryInfo_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		DirectoryInfo input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.CheckExists());
	}

	[TestMethod]
	public void CheckExists_DirectoryInfo_WithCreateDirectory_CreatesAndReturnsTrue()
	{
		// Arrange
		var tempPath = Path.Combine(Path.GetTempPath(), $"TestDir_{Guid.NewGuid()}");
		var input = new DirectoryInfo(tempPath);

		try
		{
			// Act
			var result = input.CheckExists(createDirectory: true);

			// Assert
			Assert.IsTrue(result);
			Assert.IsTrue(Directory.Exists(tempPath));
		}
		finally
		{
			if (Directory.Exists(tempPath))
			{
				Directory.Delete(tempPath);
			}
		}
	}

	[TestMethod]
	public void CheckExists_DirectoryInfo_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new DirectoryInfo("C:\\NonExistentDirectory123456789");
		var customMessage = "The directory could not be found at the specified location";

		try
		{
			// Act
			_ = input.CheckExists(throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected DirectoryNotFoundException was not thrown.");
		}
		catch (DirectoryNotFoundException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void CheckExists_FileInfo_ExistingFile_ReturnsTrue()
	{
		// Arrange
		var fileName = RandomData.GenerateRandomFileName();
		_ = RandomData.GenerateFile(fileName, 100);
		var input = new FileInfo(fileName);

		try
		{
			// Act
			var result = input.CheckExists();

			// Assert
			Assert.IsTrue(result);
		}
		finally
		{
			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}
		}
	}

	[TestMethod]
	public void CheckExists_FileInfo_NonExistingFile_ReturnsFalse()
	{
		// Arrange
		var input = new FileInfo("C:\\NonExistentFile123456789.txt");

		// Act
		var result = input.CheckExists();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckExists_FileInfo_NonExistingFileWithThrowException_ThrowsFileNotFoundException()
	{
		// Arrange
		var input = new FileInfo("C:\\NonExistentFile123456789.txt");

		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(() => input.CheckExists(throwException: true));
	}

	[TestMethod]
	public void CheckExists_FileInfo_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		FileInfo input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.CheckExists());
	}

	[TestMethod]
	public void CheckExists_FileInfo_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new FileInfo("C:\\NonExistentFile123456789.txt");
		var customMessage = "The file could not be found at the specified location";

		try
		{
			// Act
			_ = input.CheckExists(throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected FileNotFoundException was not thrown.");
		}
		catch (FileNotFoundException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
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
		var ex = Assert.ThrowsExactly<InvalidValueException<object>>(() => Validator.CheckIsCondition(input, condition, true, errorMessage));
		Assert.Contains(errorMessage, ex.Message);
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.CheckIsCondition(input, condition));
	}

	[TestMethod]
	public void CheckIsCondition_WithDefaultErrorMessage_ThrowsException()
	{
		// Arrange
		var input = 5;
		var condition = false;

		// Act & Assert
		var ex = Assert.ThrowsExactly<InvalidValueException<object>>(() => Validator.CheckIsCondition(input, condition, true));
		Assert.Contains("Invalid value", ex.Message);
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
		var ex = Assert.ThrowsExactly<InvalidValueException<Enum>>(() => Validator.CheckIsDefined(input, true, errorMessage));
		Assert.Contains(errorMessage, ex.Message);
	}

	[TestMethod]
	public void CheckIsDefined_InvalidEnum_ReturnsFalse()
	{
		// Arrange
		var input = (BenchmarkStatus)999;

		// Act
		var result = input.CheckIsDefined();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsDefined_InvalidEnumWithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		var input = (BenchmarkStatus)999;

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<Enum>>(() => input.CheckIsDefined(throwException: true));
	}

	[TestMethod]
	public void CheckIsDefined_NullEnum_ReturnsFalse()
	{
		// Arrange
		Enum input = null;

		// Act
		var result = input.CheckIsDefined();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsDefined_NullEnumWithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		Enum input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<Enum>>(() => input.CheckIsDefined(throwException: true));
	}

	[TestMethod]
	public void CheckIsDefined_ValidEnum_ReturnsTrue()
	{
		// Arrange
		var input = BenchmarkStatus.Completed;

		// Act
		var result = input.CheckIsDefined();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsDefined_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = (BenchmarkStatus)999;
		var customMessage = "The enum value is not defined in BenchmarkStatus";

		try
		{
			// Act
			_ = input.CheckIsDefined(throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected InvalidValueException was not thrown.");
		}
		catch (InvalidValueException<Enum> ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void CheckIsDefined_WithDefaultErrorMessage_ThrowsException()
	{
		// Arrange
		var input = (TestEnum)999;

		// Act & Assert
		var ex = Assert.ThrowsExactly<InvalidValueException<Enum>>(() => Validator.CheckIsDefined(input, true));
		Assert.Contains("The value is not defined in the Enum.", ex.Message);
	}

	[TestMethod]
	public void CheckIsInRange_DateOnly_OutOfRange_ReturnsFalse()
	{
		// Arrange
		var input = new DateOnly(2025, 6, 15);
		var lower = new DateOnly(2023, 1, 1);
		var upper = new DateOnly(2023, 12, 31);

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsInRange_DateOnly_WithinRange_ReturnsTrue()
	{
		// Arrange
		var input = new DateOnly(2023, 6, 15);
		var lower = new DateOnly(2023, 1, 1);
		var upper = new DateOnly(2023, 12, 31);

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsInRange_DateOnly_WithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		var input = new DateOnly(2025, 6, 15);
		var lower = new DateOnly(2023, 1, 1);
		var upper = new DateOnly(2023, 12, 31);

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<DateOnly>>(() => input.CheckIsInRange(lower, upper, throwException: true));
	}

	[TestMethod]
	public void CheckIsInRange_DateTime_OutOfRange_ReturnsFalse()
	{
		// Arrange
		var input = new DateTime(2025, 6, 15);
		var lower = new DateTime(2023, 1, 1);
		var upper = new DateTime(2023, 12, 31);

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsInRange_DateTime_WithinRange_ReturnsTrue()
	{
		// Arrange
		var input = new DateTime(2023, 6, 15);
		var lower = new DateTime(2023, 1, 1);
		var upper = new DateTime(2023, 12, 31);

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsInRange_DateTime_WithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		var input = new DateTime(2025, 6, 15);
		var lower = new DateTime(2023, 1, 1);
		var upper = new DateTime(2023, 12, 31);

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<DateTime>>(() => input.CheckIsInRange(lower, upper, throwException: true));
	}

	[TestMethod]
	public void CheckIsInRange_DateTimeOffset_OutOfRange_ReturnsFalse()
	{
		// Arrange
		var input = new DateTimeOffset(new DateTime(2025, 6, 15));
		var lower = new DateTimeOffset(new DateTime(2023, 1, 1));
		var upper = new DateTimeOffset(new DateTime(2023, 12, 31));

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsInRange_DateTimeOffset_WithinRange_ReturnsTrue()
	{
		// Arrange
		var input = new DateTimeOffset(new DateTime(2023, 6, 15));
		var lower = new DateTimeOffset(new DateTime(2023, 1, 1));
		var upper = new DateTimeOffset(new DateTime(2023, 12, 31));

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsInRange_DateTimeOffset_WithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		var input = new DateTimeOffset(new DateTime(2025, 6, 15));
		var lower = new DateTimeOffset(new DateTime(2023, 1, 1));
		var upper = new DateTimeOffset(new DateTime(2023, 12, 31));

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<DateTimeOffset>>(() => input.CheckIsInRange(lower, upper, throwException: true));
	}

	[TestMethod]
	public void CheckIsInRange_Decimal_OutOfRange_ReturnsFalse()
	{
		// Arrange
		decimal input = 150.5m;
		decimal lower = 0.0m;
		decimal upper = 100.0m;

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsInRange_Decimal_WithinRange_ReturnsTrue()
	{
		// Arrange
		decimal input = 50.5m;
		decimal lower = 0.0m;
		decimal upper = 100.0m;

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsInRange_Decimal_WithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		decimal input = 150.5m;
		decimal lower = 0.0m;
		decimal upper = 100.0m;

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<decimal>>(() => input.CheckIsInRange(lower, upper, throwException: true));
	}

	[TestMethod]
	public void CheckIsInRange_Double_OutOfRange_ReturnsFalse()
	{
		// Arrange
		double input = 150.5;
		double lower = 0.0;
		double upper = 100.0;

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsInRange_Double_WithinRange_ReturnsTrue()
	{
		// Arrange
		double input = 50.5;
		double lower = 0.0;
		double upper = 100.0;

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsInRange_Double_WithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		double input = 150.5;
		double lower = 0.0;
		double upper = 100.0;

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<double>>(() => input.CheckIsInRange(lower, upper, throwException: true));
	}

	[TestMethod]
	public void CheckIsInRange_Int_OutOfRange_ReturnsFalse()
	{
		// Arrange
		var input = 150;
		var lower = 0;
		var upper = 100;

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsInRange_Int_OutOfRangeWithThrowException_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var input = 150;
		var lower = 0;
		var upper = 100;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => input.CheckIsInRange(lower, upper, throwException: true));
	}

	[TestMethod]
	public void CheckIsInRange_Int_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = 150;
		var lower = 0;
		var upper = 100;
		var customMessage = "Value must be between 0 and 100";

		try
		{
			// Act
			_ = input.CheckIsInRange(lower, upper, throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
		}
		catch (ArgumentOutOfRangeException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void CheckIsInRange_Int_WithinRange_ReturnsTrue()
	{
		// Arrange
		var input = 50;
		var lower = 0;
		var upper = 100;

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsInRange_Long_OutOfRange_ReturnsFalse()
	{
		// Arrange
		long input = 150L;
		long lower = 0L;
		long upper = 100L;

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsInRange_Long_WithinRange_ReturnsTrue()
	{
		// Arrange
		long input = 50L;
		long lower = 0L;
		long upper = 100L;

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsInRange_Long_WithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		long input = 150L;
		long lower = 0L;
		long upper = 100L;

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<long>>(() => input.CheckIsInRange(lower, upper, throwException: true));
	}

	[TestMethod]
	public void CheckIsInRange_TimeOnly_OutOfRange_ReturnsFalse()
	{
		// Arrange
		var input = new TimeOnly(20, 0, 0);
		var lower = new TimeOnly(9, 0, 0);
		var upper = new TimeOnly(17, 0, 0);

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsInRange_TimeOnly_WithinRange_ReturnsTrue()
	{
		// Arrange
		var input = new TimeOnly(12, 0, 0);
		var lower = new TimeOnly(9, 0, 0);
		var upper = new TimeOnly(17, 0, 0);

		// Act
		var result = input.CheckIsInRange(lower, upper);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsInRange_TimeOnly_WithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		var input = new TimeOnly(20, 0, 0);
		var lower = new TimeOnly(9, 0, 0);
		var upper = new TimeOnly(17, 0, 0);

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<TimeOnly>>(() => input.CheckIsInRange(lower, upper, throwException: true));
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
		var ex = Assert.ThrowsExactly<InvalidOperationException>(() => Validator.CheckIsNotEmpty(input, true, errorMessage));
		Assert.Contains(errorMessage, ex.Message);
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
		var input = new ReadOnlySpan<int>();

		// Act
		var result = input.CheckIsNotEmpty();

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
	public void CheckIsNotEmpty_ReadOnlySpan_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new ReadOnlySpan<int>();
		var customMessage = "The span must contain elements";

		try
		{
			// Act
			_ = input.CheckIsNotEmpty(throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected InvalidOperationException was not thrown.");
		}
		catch (InvalidOperationException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void CheckIsNotEmpty_ReadOnlySpan_WithItems_ReturnsTrue()
	{
		// Arrange
		var array = new[] { 1, 2, 3 };
		var input = new ReadOnlySpan<int>(array);

		// Act
		var result = input.CheckIsNotEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNull_NullObject_ReturnsFalse()
	{
		// Arrange
		Person input = null;

		// Act
		var result = input.CheckIsNotNull();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckIsNotNull_NullObjectWithThrowException_ThrowsArgumentNullException()
	{
		// Arrange
		Person input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.CheckIsNotNull(throwException: true));
	}

	[TestMethod]
	public void CheckIsNotNull_ValidObject_ReturnsTrue()
	{
		// Arrange
		var input = RandomData.GeneratePerson<Person>();

		// Act
		var result = input.CheckIsNotNull();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckIsNotNull_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		Person input = null;
		var customMessage = "The person object cannot be null";

		try
		{
			// Act
			_ = input.CheckIsNotNull(throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected ArgumentNullException was not thrown.");
		}
		catch (ArgumentNullException ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
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
	public void CheckIsNotNullOrEmpty_EmptyStringWithThrowException_ThrowsArgumentNullException()
	{
		// Arrange
		var input = string.Empty;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.CheckIsNotNullOrEmpty(throwException: true));
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
	public void CheckIsNotNullOrEmpty_NullStringWithThrowException_ThrowsArgumentNullException()
	{
		// Arrange
		string input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => input.CheckIsNotNullOrEmpty(throwException: true));
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
			Assert.Contains(customMessage, ex.Message);
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
	public void CheckItemsExists_Array_WithItems_ReturnsTrue()
	{
		// Arrange
		var input = new[] { 1, 2, 3 };

		// Act
		var result = input.CheckItemsExists();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckItemsExists_CollectionWithItems_ReturnsTrue()
	{
		// Arrange
		var input = new List<int> { 1, 2, 3 };

		// Act
		var result = input.CheckItemsExists();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckItemsExists_EmptyCollection_ReturnsFalse()
	{
		// Arrange
		var input = new List<int>();

		// Act
		var result = input.CheckItemsExists();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckItemsExists_EmptyCollectionWithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		var input = new List<int>();

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<IEnumerable<int>>>(() => input.CheckItemsExists(throwException: true));
	}

	[TestMethod]
	public void CheckItemsExists_NullCollection_ReturnsFalse()
	{
		// Arrange
		List<int> input = null;

		// Act
		var result = input.CheckItemsExists();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckItemsExists_NullCollectionWithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		List<int> input = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<IEnumerable<int>>>(() => input.CheckItemsExists(throwException: true));
	}

	[TestMethod]
	public void CheckItemsExists_ReadOnlyCollection_WithItems_ReturnsTrue()
	{
		// Arrange
		var input = new List<int> { 1, 2, 3 }.AsReadOnly();

		// Act
		var result = input.CheckItemsExists();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckItemsExists_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = new List<int>();
		var customMessage = "The collection must contain at least one item";

		try
		{
			// Act
			_ = input.CheckItemsExists(throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected InvalidValueException was not thrown.");
		}
		catch (InvalidValueException<IEnumerable<int>> ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
	}

	[TestMethod]
	public void CheckTypeEquals_DifferentTypes_ReturnsFalse()
	{
		// Arrange
		var input = typeof(Person);
		var expectedType = typeof(Address);

		// Act
		var result = input.CheckTypeEquals(expectedType);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void CheckTypeEquals_DifferentTypesWithThrowException_ThrowsInvalidValueException()
	{
		// Arrange
		var input = typeof(Person);
		var expectedType = typeof(Address);

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidValueException<Type>>(() => input.CheckTypeEquals(expectedType, throwException: true));
	}

	[TestMethod]
	public void CheckTypeEquals_SameTypes_ReturnsTrue()
	{
		// Arrange
		var input = typeof(Person);
		var expectedType = typeof(Person);

		// Act
		var result = input.CheckTypeEquals(expectedType);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void CheckTypeEquals_WithCustomErrorMessage_ThrowsWithCustomMessage()
	{
		// Arrange
		var input = typeof(Person);
		var expectedType = typeof(Address);
		var customMessage = "Type mismatch detected between types";

		try
		{
			// Act
			_ = input.CheckTypeEquals(expectedType, throwException: true, errorMessage: customMessage);
			Assert.Fail("Expected InvalidValueException was not thrown.");
		}
		catch (InvalidValueException<Type> ex)
		{
			// Assert
			Assert.Contains(customMessage, ex.Message);
		}
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
	public void TestNullCollectionWithErrorMessage()
	{
		// Arrange
		Collection<string> collection = null;
		var errorMessage = "Collection should not be null.";

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.ArgumentNotNull(collection, errorMessage, paramName: nameof(collection)));
	}

	public enum TestEnum
	{
		Value1,
		Value2
	}

	[GeneratedRegex(@"^\w+$")]
	private static partial Regex MyRegex();
}
