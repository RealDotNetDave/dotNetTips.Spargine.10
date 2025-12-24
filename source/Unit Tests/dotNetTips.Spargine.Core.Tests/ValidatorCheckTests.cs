// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 04-13-2022
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2025
// ***********************************************************************
// <copyright file="ValidatorCheckTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ValidatorCheckTests
{
	[TestMethod]
	public void ArgumentIsInRangeDateTimeTest()
	{
		var lowerValue = new DateTime(2021, 3, 3);
		var outOfRangeLower = new DateTime(1900, 3, 3);
		var outOfRangeUpper = new DateTime(1991, 3, 3);
		var testValue = new DateTime(2022, 3, 20);
		var upperValue = new DateTime(2025, 3, 3);

		Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

		Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLower, outOfRangeUpper));

		// Test Exception throwing.
		_ = Assert.ThrowsExactly<InvalidValueException<DateTime>>(
			() => testValue.CheckIsInRange(outOfRangeLower, outOfRangeUpper, true));
	}


	[TestMethod]
	public void CheckIsDefinedEnumTest()
	{
		var value = BenchmarkStatus.Completed;

		// Good test
		Assert.IsTrue(value.CheckIsDefined());

		// Test Exception throwing.
		_ = Assert.ThrowsExactly<InvalidValueException<Enum>>(() => ((BenchmarkStatus)100).CheckIsDefined(true));
	}

	[TestMethod]
	public void CheckIsInRangeDateOnlyTest()
	{
		var lowerValue = new DateOnly(2021, 3, 3);
		var upperValue = new DateOnly(2025, 3, 3);
		var testValue = new DateOnly(2022, 3, 20);
		var outOfRangeLowerValue = new DateOnly(1900, 3, 3);
		var outOfRangeUpperValue = new DateOnly(1991, 3, 3);

		Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

		Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

		// Test Exception
		_ = Assert.ThrowsExactly<InvalidValueException<DateOnly>>(
			() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
	}

	[TestMethod]
	public void CheckIsInRangeDateTimeOffsetTest()
	{
		var lowerValue = new DateTimeOffset(new DateTime(2021, 3, 3));
		var upperValue = new DateTimeOffset(new DateTime(2025, 3, 3));
		var testValue = new DateTimeOffset(new DateTime(2022, 3, 20));
		var outOfRangeLowerValue = new DateTimeOffset(new DateTime(1900, 3, 3));
		var outOfRangeUpperValue = new DateTimeOffset(new DateTime(1991, 3, 3));

		Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

		Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

		// Test Exception
		_ = Assert.ThrowsExactly<InvalidValueException<DateTimeOffset>>(
			() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
	}

	[TestMethod]
	public void CheckIsInRangeDecimalTest()
	{
		var testValue = 10000m;

		Assert.IsTrue(testValue.CheckIsInRange(0, decimal.MaxValue));

		Assert.IsFalse(testValue.CheckIsInRange(0, 100));

		// Test Exception
		_ = Assert.ThrowsExactly<InvalidValueException<decimal>>(() => testValue.CheckIsInRange(0, 100, true));
	}

	[TestMethod]
	public void CheckIsInRangeDoubleTest()
	{
		double testValue = 1000;

		Assert.IsTrue(testValue.CheckIsInRange(0, double.MaxValue));

		Assert.IsFalse(testValue.CheckIsInRange(0, 100));

		// Test Exception
		_ = Assert.ThrowsExactly<InvalidValueException<double>>(() => testValue.CheckIsInRange(0, 100, true));
	}

	[TestMethod]
	public void CheckIsInRangeIntTest()
	{
		var testValue = 1000;

		Assert.IsTrue(testValue.CheckIsInRange(0, int.MaxValue));

		Assert.IsFalse(testValue.CheckIsInRange(0, 100));

		// Test Exception
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue.CheckIsInRange(0, 100, true));
	}

	[TestMethod]
	public void CheckIsInRangeLongTest()
	{
		long testValue = 1000;

		Assert.IsTrue(testValue.CheckIsInRange(0, long.MaxValue));

		Assert.IsFalse(testValue.CheckIsInRange(0, 100));

		// Test Exception
		_ = Assert.ThrowsExactly<InvalidValueException<long>>(() => testValue.CheckIsInRange(0, 100, true));
	}

	[TestMethod]
	public void CheckIsInRangeTimeOnlyTest()
	{
		var lowerValue = new TimeOnly(1, 3, 3);
		var upperValue = new TimeOnly(10, 3, 3);
		var testValue = new TimeOnly(5, 3, 20);
		var outOfRangeLowerValue = new TimeOnly(1, 3, 3);
		var outOfRangeUpperValue = new TimeOnly(2, 3, 3);

		Assert.IsTrue(testValue.CheckIsInRange(lowerValue, upperValue));

		Assert.IsFalse(testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue));

		// Test Exception
		_ = Assert.ThrowsExactly<InvalidValueException<TimeOnly>>(
			() => testValue.CheckIsInRange(outOfRangeLowerValue, outOfRangeUpperValue, true));
	}

	[TestMethod]
	public void CheckIsNotEmptyReadOnlySpanTest01()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray().AsReadOnlySpan();
		var emptyPeople = ReadOnlySpan<Person>.Empty;

		Assert.IsTrue(people.CheckIsNotEmpty());

		Assert.IsFalse(emptyPeople.CheckIsNotEmpty());

		// Test Exception
		//_ = Assert.ThrowsException < InvalidValueException<ReadOnlySpan<Person>>(() => emptyPeople.CheckIsNotEmpty(true));
	}

	[TestMethod]
	public void CheckIsNotNullObjectTest()
	{
		var testPerson = RandomData.GeneratePerson<Person>();
		Person invalidValue = null;

		Assert.IsTrue(testPerson.CheckIsNotNull());

		Assert.IsFalse(invalidValue.CheckIsNotNull());

		// Test Exception
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => invalidValue.CheckIsNotNull(true));
	}

	[TestMethod]
	public void CheckIsNotNullOrEmptyGuidTest()
	{
		var value = Guid.NewGuid();

		Assert.IsTrue(value.CheckIsNotEmpty());

		Assert.IsFalse(Guid.Empty.CheckIsNotEmpty());

		// Test Exception
		_ = Assert.ThrowsExactly<InvalidOperationException>(() => Guid.Empty.CheckIsNotEmpty(true));
	}

	[TestMethod]
	public void CheckItemsExistsIEnumerableTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).AsEnumerable();
		IEnumerable<Person> nullPeople = null;

		Assert.IsTrue(people.CheckItemsExists());

		Assert.IsFalse(nullPeople.CheckItemsExists());
	}

	[TestMethod]
	public void ConditionCheckTest()
	{
		var personProper = RandomData.GeneratePerson<Person>();

		Assert.IsTrue(personProper.CheckIsCondition(personProper.Id.IsNotEmpty(), errorMessage: "Should be true."));
		Assert.IsFalse(personProper.CheckIsCondition(personProper.Id.IsEmpty(), errorMessage: "Should be false."));

		Person nullPerson = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => nullPerson.CheckIsCondition(personProper.Id.IsNotEmpty(), true));
	}

	[TestMethod]
	public void ExistsCheckDirectoryInfoTest()
	{
		var directoryName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		var directoryInfo = new DirectoryInfo(directoryName);

		try
		{
			_ = directoryInfo.CheckExists(true);
		}
		catch
		{
			Assert.Fail();
		}

		DirectoryInfo nullDirectoryInfo = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullDirectoryInfo.CheckExists(true));

		_ = Assert.ThrowsExactly<DirectoryNotFoundException>(
			() => new DirectoryInfo("fakefile").CheckExists(throwException: true));
	}

	[TestMethod]
	public void ExistsCheckFileInfoTest()
	{
		var fileName = RandomData.GenerateRandomFileName();

		_ = RandomData.GenerateFile(fileName, 500);

		var fileInfo = new FileInfo(fileName);

		try
		{
			_ = fileInfo.CheckExists(true);
		}
		catch
		{
			Assert.Fail();
		}

		FileInfo nullFileInfo = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullFileInfo.CheckExists(true));

		_ = Assert.ThrowsExactly<FileNotFoundException>(() => new FileInfo("fakefile").CheckExists(true));
	}

	[TestMethod]
	public void IsNotNullCheckTest()
	{
		try
		{
			var personProper = RandomData.GeneratePerson<Person>();
			_ = personProper.CheckIsNotNull(throwException: true);
		}
		catch
		{
			Assert.Fail();
		}
	}
}
