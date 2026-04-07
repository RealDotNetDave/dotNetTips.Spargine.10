// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="NumericExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class NumericExtensionsTests : UnitTester
{

	private const string OutOfRange = "OUT OF RANGE";

	[TestMethod]
	public void Average_IntsWithRounding_ReturnsCorrectAverage()
	{
		// Arrange
		var a = 10;
		var b = 21; // This will test if the method correctly handles rounding.
		var expectedResult = 15; // Expected to round down from 15.5 to 15

		// Act
		var result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 10 and 21 should be 15, demonstrating rounding down.");
	}

	[TestMethod]
	public void Average_MixedDecimals_ReturnsCorrectAverage()
	{
		// Arrange
		var a = -10.5m;
		var b = 20.5m;
		var expectedResult = 5.0m;

		// Act
		var result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of -10.5 and 20.5 should be 5.0.");
	}

	[TestMethod]
	public void Average_MixedDoubles_ReturnsCorrectAverage()
	{
		// Arrange
		double a = -10.5;
		double b = 20.5;
		double expectedResult = 5.0;

		// Act
		double result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of -10.5 and 20.5 should be 5.0.");
	}

	[TestMethod]
	public void Average_MixedInts_ReturnsCorrectAverage()
	{
		// Arrange
		int a = -10;
		int b = 30;
		int expectedResult = 10;

		// Act
		int result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of -10 and 30 should be 10.");
	}

	[TestMethod]
	public void Average_MixedLongs_ReturnsCorrectAverage()
	{
		// Arrange
		long a = -10L;
		long b = 30L;
		long expectedResult = 10L;

		// Act
		long result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of -10 and 30 should be 10.");
	}

	[TestMethod]
	public void Average_NegativeDecimals_ReturnsCorrectAverage()
	{
		// Arrange
		decimal a = -10.5m;
		decimal b = -20.5m;
		decimal expectedResult = -15.5m;

		// Act
		decimal result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of -10.5 and -20.5 should be -15.5.");
	}

	[TestMethod]
	public void Average_NegativeDoubles_ReturnsCorrectAverage()
	{
		// Arrange
		double a = -10.5;
		double b = -20.5;
		double expectedResult = -15.5;

		// Act
		double result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of -10.5 and -20.5 should be -15.5.");
	}

	[TestMethod]
	public void Average_NegativeInts_ReturnsCorrectAverage()
	{
		// Arrange
		int a = -10;
		int b = -20;
		int expectedResult = -15;

		// Act
		int result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of -10 and -20 should be -15.");
	}

	[TestMethod]
	public void Average_NegativeLongs_ReturnsCorrectAverage()
	{
		// Arrange
		long a = -10L;
		long b = -20L;
		long expectedResult = -15L;

		// Act
		long result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of -10 and -20 should be -15.");
	}
	[TestMethod]
	public void Average_PositiveDecimals_ReturnsCorrectAverage()
	{
		// Arrange
		decimal a = 10.5m;
		decimal b = 20.5m;
		decimal expectedResult = 15.5m;

		// Act
		decimal result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 10.5 and 20.5 should be 15.5.");
	}
	[TestMethod]
	public void Average_PositiveDoubles_ReturnsCorrectAverage()
	{
		// Arrange
		double a = 10.5;
		double b = 20.5;
		double expectedResult = 15.5;

		// Act
		double result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 10.5 and 20.5 should be 15.5.");
	}
	[TestMethod]
	public void Average_PositiveInts_ReturnsCorrectAverage()
	{
		// Arrange
		int a = 10;
		int b = 20;
		int expectedResult = 15;

		// Act
		int result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 10 and 20 should be 15.");
	}
	[TestMethod]
	public void Average_PositiveLongs_ReturnsCorrectAverage()
	{
		// Arrange
		long a = 10L;
		long b = 20L;
		long expectedResult = 15L;

		// Act
		long result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 10 and 20 should be 15.");
	}

	[TestMethod]
	public void Average_ZeroDecimals_ReturnsZero()
	{
		// Arrange
		decimal a = 0m;
		decimal b = 0m;
		decimal expectedResult = 0m;

		// Act
		decimal result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 0 and 0 should be 0.");
	}

	[TestMethod]
	public void Average_ZeroDoubles_ReturnsZero()
	{
		// Arrange
		double a = 0.0;
		double b = 0.0;
		double expectedResult = 0.0;

		// Act
		double result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 0.0 and 0.0 should be 0.0.");
	}

	[TestMethod]
	public void Average_ZeroLongs_ReturnsZero()
	{
		// Arrange
		long a = 0L;
		long b = 0L;
		long expectedResult = 0L;

		// Act
		long result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 0 and 0 should be 0.");
	}

	[TestMethod]
	public void BytesToMegabytes_LargeNumberOfBytes_ReturnsCorrectMegabytes()
	{
		// Arrange
		long bytes = 1073741824; // 1 GB in bytes
		double expected = 1024; // 1 GB in megabytes

		// Act
		double result = bytes.BytesToMegabytes();

		// Assert
		Assert.AreEqual(expected, result, "Converting 1073741824 bytes should return 1024 megabytes.");
	}

	[TestMethod]
	public void BytesToMegabytes_NegativeBytes_ThrowsArgumentException()
	{
		// Arrange
		long bytes = -1024;

		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => bytes.BytesToMegabytes(), "Converting negative bytes should throw ArgumentException.");
	}

	[TestMethod]
	public void BytesToMegabytes_RegularBytes_ReturnsCorrectMegabytes()
	{
		// Arrange
		long bytes = 1048576; // 1 MB in bytes
		double expected = 1;

		// Act
		double result = bytes.BytesToMegabytes();

		// Assert
		Assert.AreEqual(expected, result, "Converting 1048576 bytes should return 1 megabyte.");
	}
	[TestMethod]
	public void BytesToMegabytes_ZeroBytes_ReturnsZero()
	{
		// Arrange
		long bytes = 0;
		double expected = 0;

		// Act
		double result = bytes.BytesToMegabytes();

		// Assert
		Assert.AreEqual(expected, result, "Converting zero bytes should return zero.");
	}

	[TestMethod]
	public void DecrementTest()
	{
		var testValue = 256234;

		var result = testValue.Decrement(lowerBound: 1, step: 5);

		Assert.AreEqual(5, testValue - result);
	}

	[TestMethod]
	public void DoubleToFormattedStringTest()
	{
		var testValue = double.MaxValue / 2;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.RoundTrip);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.General);
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Number);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		Assert.IsGreaterThan(5, result.Length);

		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Decimal));
		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.Hexadecimal));

	}

	[TestMethod]
	public void EnsureMinimumTest()
	{
		var testValue = 99;

		var result = testValue.EnsureMinimum(100);

		Assert.AreEqual(100, result);
	}


	[TestMethod]
	public void FormatSize_Exabytes_ReturnsEB()
	{
		// Act
		var result = NumericExtensions.FormatSize(1L * 1024 * 1024 * 1024 * 1024 * 1024 * 1024);

		// Assert
		Assert.AreEqual("1 EB", result);
	}

	[TestMethod]
	public void FormatSize_GreaterThanOrEqualTo1073741824_ReturnsGB()
	{
		// Act
		var result = NumericExtensions.FormatSize(5000000000);

		// Assert
		Assert.AreEqual("4.66 GB", result);
	}

	[TestMethod]
	public void FormatSize_LessThan1024_ReturnsBytes()
	{
		// Act
		var result = NumericExtensions.FormatSize(500);

		// Assert
		Assert.AreEqual("500 Bytes", result);
	}

	[TestMethod]
	public void FormatSize_LessThan1048576_ReturnsKB()
	{
		// Act
		var result = NumericExtensions.FormatSize(5000);

		// Assert
		Assert.AreEqual("4.88 KB", result);
	}

	[TestMethod]
	public void FormatSize_LessThan1073741824_ReturnsMB()
	{
		// Act
		var result = NumericExtensions.FormatSize(5000000);

		// Assert
		Assert.AreEqual("4.77 MB", result);
	}

	[TestMethod]
	public void FormatSize_Petabytes_ReturnsPB()
	{
		// Act
		var result = NumericExtensions.FormatSize(1L * 1024 * 1024 * 1024 * 1024 * 1024);

		// Assert
		Assert.AreEqual("1 PB", result);
	}

	[TestMethod]
	public void FormatSize_Terabytes_ReturnsTB()
	{
		// Act
		var result = NumericExtensions.FormatSize(1L * 1024 * 1024 * 1024 * 1024);

		// Assert
		Assert.AreEqual("1 TB", result);
	}

	[TestMethod]
	public void FormatSize_Zero_ReturnsZeroBytes()
	{
		// Act
		var result = NumericExtensions.FormatSize(0);

		// Assert
		Assert.AreEqual("0 Bytes", result);
	}

	[TestMethod]
	public void FormatSizeDoubleTest()
	{
		var testValue = 256234.98;

		var result = testValue.FormatSize();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FormatSizeLongTest()
	{
		long testValue = 256234;

		var result = testValue.FormatSize();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FormatTime()
	{
		// Act
		var result = NumericExtensions.FormatTime(100000000.11);

		// Assert
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void IncrementTest()
	{
		var testValue = 256234;

		var result = testValue.Increment(upperBound: 300000, step: 5);

		Assert.AreEqual(256239, result);
	}

	[TestMethod]
	public void IntToFormattedStringTest()
	{
		var testValue = int.MaxValue;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.General);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Number);
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		Assert.IsGreaterThan(5, result.Length);

		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));
	}

	[TestMethod]
	public void IsEvenDecimalTest()
	{
		decimal testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenDoubleTest()
	{
		double testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}



	[TestMethod]
	public void IsEvenFloatTest()
	{
		float testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenIntTest()
	{
		int testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenLongTest()
	{
		long testValue = 256234;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenSbyteTest()
	{
		sbyte testValue = 32;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsEvenShortTest()
	{
		short testValue = 266;

		Assert.IsTrue(testValue.IsEven());

		testValue++;

		Assert.IsFalse(testValue.IsEven());
	}

	[TestMethod]
	public void IsInRangeTest()
	{
		int testValue1 = 100;
		long testValue2 = 100;
		double testValue3 = 100;
		decimal testValue4 = 100;

		Assert.IsTrue(testValue1.IsInRange(50, 500));

		Assert.IsTrue(testValue2.IsInRange(50, 500));

		Assert.IsTrue(testValue3.IsInRange(50, 500));

		Assert.IsTrue(testValue4.IsInRange(50, 500));
	}

	[TestMethod]
	public void IsInRangeThrowsExceptionTest()
	{
		int testValue1 = 100;
		long testValue2 = 100;
		double testValue3 = 100;
		decimal testValue4 = 100;

		Assert.IsTrue(testValue1.IsInRangeThrowsException(50, 500));

		Assert.IsTrue(testValue2.IsInRangeThrowsException(50, 500));

		Assert.IsTrue(testValue3.IsInRangeThrowsException(50, 500));

		Assert.IsTrue(testValue4.IsInRangeThrowsException(50, 500));

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue1.IsInRangeThrowsException(200, 300));

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue2.IsInRangeThrowsException(200, 300));

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue3.IsInRangeThrowsException(200, 300));

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue4.IsInRangeThrowsException(200, 300));
	}

	[TestMethod]
	public void IsIntervalTest()
	{
		var testValue = 400;

		Assert.IsTrue(testValue.IsInterval(100));

		Assert.IsFalse(testValue.IsInterval(99));

		Assert.IsTrue(testValue.IsIntervalThrowsException(100, "test"));

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => testValue.IsIntervalThrowsException(99, "test"));
	}

	[TestMethod]
	public void IsNegativeDecimalTest()
	{
		decimal testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeDoubleTest()
	{
		double testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeFloatTest()
	{
		float testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeIntTest()
	{
		int testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeLongTest()
	{
		long testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeSbyteTest()
	{
		sbyte testValue = -1;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 20;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegativeShortTest()
	{
		short testValue = -100;

		Assert.IsTrue(testValue.IsNegative());

		testValue += 300;

		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void LongToFormattedStringTest()
	{
		var testValue = long.MaxValue / 2;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsGreaterThan(5, result.Length);

		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

	}

	[TestMethod]
	public void MillisecondsToStringIntTest()
	{
		int time = 99999999;
		var result = time.MillisecondsToString();

		Assert.AreEqual("27:46:39", result);
	}

	[TestMethod]
	public void MillisecondsToStringLongTest()
	{
		long time = 99999999;
		var result = time.MillisecondsToString();

		Assert.AreEqual("27:46:39", result);
	}

	[TestMethod]
	public void MillisecondsToStringTimeSpanTest()
	{
		var time = new TimeSpan(1, 12, 55, 33, 2200);
		var result = time.MillisecondsToString();

		Assert.AreEqual("36:55:35", result);
	}

	[TestMethod]
	public void RoundToPowerOf2Test()
	{
		var testValue = 256234;

		var result = testValue.RoundToPowerOf2();

		Assert.AreEqual(262144, result);

		//PrintResult(result, nameof(this.RoundToPowerOf2Test));
	}

	[TestMethod]
	public void ShortToFormattedStringTest()
	{
		var testValue = short.MaxValue;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsGreaterThan(3, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsGreaterThan(4, result.Length);

		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));
	}

	[TestMethod]
	public void ToPositiveValueDecimalTest()
	{
		decimal testValue = -100;

		Assert.IsGreaterThan(-1, testValue.ToPositiveValue());
	}

	[TestMethod]
	public void ToPositiveValueIntTest()
	{
		int testValue = -100;

		Assert.IsGreaterThan(-1, testValue.ToPositiveValue());
	}

	[TestMethod]
	public void ToPositiveValueLongTest()
	{
		long testValue = -100;

		Assert.IsGreaterThan(-1, testValue.ToPositiveValue());
	}

	[TestMethod]
	public void ToRomanNumeralTest()
	{
		var number = 1010;

		Assert.IsNotNull(number.ToRomanNumeral());
	}

	[TestMethod]
	public void ToStringOrEmptyTest()
	{
		var testValue = 1000;

		Assert.IsTrue(testValue.ToStringOrEmpty(lowerLimit: 0, upperLimit: 2000, defaultText: OutOfRange).HasValue());

		Assert.AreEqual(OutOfRange, testValue.ToStringOrEmpty(lowerLimit: 0, upperLimit: 200, defaultText: OutOfRange));
	}

	[TestMethod]
	public void ToWordsTest()
	{
		var testValue = 54928;

		Assert.IsTrue(testValue.ToWords().HasValue());

		Assert.AreEqual(49, testValue.ToWords().Length);
	}

	[TestMethod]
	public void UIntToFormattedStringTest()
	{
		var testValue = uint.MaxValue / 2;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsGreaterThan(5, result.Length);

		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

	}

	[TestMethod]
	public void ULongToFormattedStringTest()
	{
		var testValue = ulong.MaxValue / 2;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsGreaterThan(5, result.Length);

		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

	}

	[TestMethod]
	public void UShortToFormattedStringTest()
	{
		var testValue = ushort.MaxValue;

		var result = testValue.ToFormattedString(NumericFormat.Currency);
		//PrintResult(result, nameof(NumericFormat.Currency));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Decimal);
		//PrintResult(result, nameof(NumericFormat.Decimal));
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Exponential);
		//PrintResult(result, nameof(NumericFormat.Exponential));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.FixedPoint);
		//PrintResult(result, nameof(NumericFormat.FixedPoint));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.General);
		//PrintResult(result, nameof(NumericFormat.General));
		Assert.IsGreaterThan(4, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Hexadecimal);
		//PrintResult(result, nameof(NumericFormat.Hexadecimal));
		Assert.IsGreaterThan(3, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Number);
		//PrintResult(result, nameof(NumericFormat.Number));
		Assert.IsGreaterThan(5, result.Length);

		result = testValue.ToFormattedString(NumericFormat.Percent);
		//PrintResult(result, nameof(NumericFormat.Percent));
		Assert.IsGreaterThan(5, result.Length);

		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => testValue.ToFormattedString(NumericFormat.RoundTrip));

	}

	[TestMethod]
	public void Average_ZeroInts_ReturnsZero()
	{
		// Arrange
		int a = 0;
		int b = 0;
		int expectedResult = 0;

		// Act
		int result = NumericExtensions.Average(a, b);

		// Assert
		Assert.AreEqual(expectedResult, result, "The average of 0 and 0 should be 0.");
	}

	[TestMethod]
	public void Decrement_BelowLowerBound_ReturnsLowerBound()
	{
		// Arrange
		var testValue = 3;

		// Act
		var result = testValue.Decrement(lowerBound: 0, step: 5);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Decrement_DefaultParameters_Decrements()
	{
		// Arrange
		var testValue = 10;

		// Act
		var result = testValue.Decrement();

		// Assert
		Assert.AreEqual(9, result);
	}

	[TestMethod]
	public void EnsureMinimum_ValueAboveMinimum_ReturnsValue()
	{
		// Arrange
		var testValue = RandomData.GenerateInteger(200, 500);

		// Act
		var result = testValue.EnsureMinimum(100);

		// Assert
		Assert.AreEqual(testValue, result);
	}

	[TestMethod]
	public void FormatSize_NegativeValue_ReturnsInvalidSize()
	{
		// Act
		var result = NumericExtensions.FormatSize(-1L);

		// Assert
		Assert.AreEqual("Invalid size", result);
	}

	[TestMethod]
	public void FormatTime_Double_LessThan1000_ReturnsMilliseconds()
	{
		// Act
		var result = NumericExtensions.FormatTime(500.0);

		// Assert
		Assert.AreEqual("500 milliseconds", result);
	}

	[TestMethod]
	public void FormatTime_Double_ExactlyOneMillisecond_ReturnsSingular()
	{
		// Act
		var result = NumericExtensions.FormatTime(1.0);

		// Assert
		Assert.AreEqual("1 millisecond", result);
	}

	[TestMethod]
	public void FormatTime_Double_OnlySeconds_ReturnsSeconds()
	{
		// Act - 5000ms = 5 seconds
		var result = NumericExtensions.FormatTime(5000.0);

		// Assert
		Assert.AreEqual("5 seconds", result);
	}

	[TestMethod]
	public void FormatTime_Double_OneSecond_ReturnsSingular()
	{
		// Act - 1000ms = 1 second
		var result = NumericExtensions.FormatTime(1000.0);

		// Assert
		Assert.AreEqual("1 second", result);
	}

	[TestMethod]
	public void FormatTime_Double_MinutesAndSeconds_ReturnsMinutesSeconds()
	{
		// Act - 90000ms = 1 minute 30 seconds
		var result = NumericExtensions.FormatTime(90000.0);

		// Assert
		Assert.AreEqual("1 minute 30 seconds", result);
	}

	[TestMethod]
	public void FormatTime_Double_HoursMinutesSeconds_ReturnsFull()
	{
		// Act - 3661000ms = 1 hour 1 minute 1 second
		var result = NumericExtensions.FormatTime(3661000.0);

		// Assert
		Assert.AreEqual("1 hour 1 minute 1 second", result);
	}

	[TestMethod]
	public void FormatTime_Double_MultipleHours_ReturnsPlural()
	{
		// Act - 7320000ms = 2 hours 2 minutes
		var result = NumericExtensions.FormatTime(7320000.0);

		// Assert
		Assert.AreEqual("2 hours 2 minutes", result);
	}

	[TestMethod]
	public void FormatTime_Long_LessThan1000_ReturnsMilliseconds()
	{
		// Act
		var result = NumericExtensions.FormatTime(500L);

		// Assert
		Assert.AreEqual("500 milliseconds", result);
	}

	[TestMethod]
	public void FormatTime_Long_ExactlyOneMillisecond_ReturnsSingular()
	{
		// Act
		var result = NumericExtensions.FormatTime(1L);

		// Assert
		Assert.AreEqual("1 millisecond", result);
	}

	[TestMethod]
	public void FormatTime_Long_OnlySeconds_ReturnsSeconds()
	{
		// Act - 5000ms = 5 seconds
		var result = NumericExtensions.FormatTime(5000L);

		// Assert
		Assert.AreEqual("5 seconds", result);
	}

	[TestMethod]
	public void FormatTime_Long_OneSecond_ReturnsSingular()
	{
		// Act - 1000ms = 1 second
		var result = NumericExtensions.FormatTime(1000L);

		// Assert
		Assert.AreEqual("1 second", result);
	}

	[TestMethod]
	public void FormatTime_Long_MinutesAndSeconds_ReturnsMinutesSeconds()
	{
		// Act - 90000ms = 1 minute 30 seconds
		var result = NumericExtensions.FormatTime(90000L);

		// Assert
		Assert.AreEqual("1 minute 30 seconds", result);
	}

	[TestMethod]
	public void FormatTime_Long_HoursMinutesSeconds_ReturnsFull()
	{
		// Act - 3661000ms = 1 hour 1 minute 1 second
		var result = NumericExtensions.FormatTime(3661000L);

		// Assert
		Assert.AreEqual("1 hour 1 minute 1 second", result);
	}

	[TestMethod]
	public void FormatTime_Long_MultipleHours_ReturnsPlural()
	{
		// Act - 7320000ms = 2 hours 2 minutes
		var result = NumericExtensions.FormatTime(7320000L);

		// Assert
		Assert.AreEqual("2 hours 2 minutes", result);
	}

	[TestMethod]
	public void Increment_ExceedsUpperBound_ReturnsUpperBound()
	{
		// Arrange
		var testValue = 98;

		// Act
		var result = testValue.Increment(upperBound: 100, step: 5);

		// Assert
		Assert.AreEqual(100, result);
	}

	[TestMethod]
	public void Increment_DefaultParameters_Increments()
	{
		// Arrange
		var testValue = 10;

		// Act
		var result = testValue.Increment();

		// Assert
		Assert.AreEqual(11, result);
	}

	[TestMethod]
	public void IsInRange_Int_OutOfRange_ReturnsFalse()
	{
		// Arrange
		int testValue = 100;

		// Act & Assert
		Assert.IsFalse(testValue.IsInRange(200, 300));
	}

	[TestMethod]
	public void IsInRange_Long_OutOfRange_ReturnsFalse()
	{
		// Arrange
		long testValue = 100L;

		// Act & Assert
		Assert.IsFalse(testValue.IsInRange(200L, 300L));
	}

	[TestMethod]
	public void IsInRange_Double_OutOfRange_ReturnsFalse()
	{
		// Arrange
		double testValue = 100.0;

		// Act & Assert
		Assert.IsFalse(testValue.IsInRange(200.0, 300.0));
	}

	[TestMethod]
	public void IsInRange_Decimal_OutOfRange_ReturnsFalse()
	{
		// Arrange
		decimal testValue = 100m;

		// Act & Assert
		Assert.IsFalse(testValue.IsInRange(200m, 300m));
	}

	[TestMethod]
	public void IsNegative_Zero_Int_ReturnsFalse()
	{
		// Arrange
		int testValue = 0;

		// Act & Assert
		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegative_Zero_Double_ReturnsFalse()
	{
		// Arrange
		double testValue = 0.0;

		// Act & Assert
		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegative_Zero_Long_ReturnsFalse()
	{
		// Arrange
		long testValue = 0L;

		// Act & Assert
		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegative_Zero_Decimal_ReturnsFalse()
	{
		// Arrange
		decimal testValue = 0m;

		// Act & Assert
		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegative_Zero_Float_ReturnsFalse()
	{
		// Arrange
		float testValue = 0f;

		// Act & Assert
		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegative_Zero_Sbyte_ReturnsFalse()
	{
		// Arrange
		sbyte testValue = 0;

		// Act & Assert
		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void IsNegative_Zero_Short_ReturnsFalse()
	{
		// Arrange
		short testValue = 0;

		// Act & Assert
		Assert.IsFalse(testValue.IsNegative());
	}

	[TestMethod]
	public void MillisecondsToString_NegativeLong_ThrowsException()
	{
		// Arrange
		long time = -1;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => time.MillisecondsToString());
	}

	[TestMethod]
	public void MillisecondsToString_NegativeInt_ThrowsException()
	{
		// Arrange
		int time = -1;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => time.MillisecondsToString());
	}

	[TestMethod]
	public void RoundToPowerOf2_AlreadyPowerOf2_ReturnsSameValue()
	{
		// Arrange
		var testValue = 256;

		// Act
		var result = testValue.RoundToPowerOf2();

		// Assert
		Assert.AreEqual(256, result);
	}

	[TestMethod]
	public void RoundToPowerOf2_ValueOfOne_ReturnsTwo()
	{
		// Arrange
		var testValue = 1;

		// Act
		var result = testValue.RoundToPowerOf2();

		// Assert
		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public void ToPositiveValue_PositiveInt_ReturnsSame()
	{
		// Arrange
		var testValue = RandomData.GenerateInteger(1, 1000);

		// Act
		var result = testValue.ToPositiveValue();

		// Assert
		Assert.AreEqual(testValue, result);
	}

	[TestMethod]
	public void ToPositiveValue_PositiveLong_ReturnsSame()
	{
		// Arrange
		long testValue = 100L;

		// Act
		var result = testValue.ToPositiveValue();

		// Assert
		Assert.AreEqual(testValue, result);
	}

	[TestMethod]
	public void ToPositiveValue_PositiveDecimal_ReturnsSame()
	{
		// Arrange
		decimal testValue = 100m;

		// Act
		var result = testValue.ToPositiveValue();

		// Assert
		Assert.AreEqual(testValue, result);
	}

	[TestMethod]
	public void ToPositiveValue_ZeroInt_ReturnsZero()
	{
		// Arrange
		int testValue = 0;

		// Act
		var result = testValue.ToPositiveValue();

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void ToPositiveValue_ZeroLong_ReturnsZero()
	{
		// Arrange
		long testValue = 0L;

		// Act
		var result = testValue.ToPositiveValue();

		// Assert
		Assert.AreEqual(0L, result);
	}

	[TestMethod]
	public void ToPositiveValue_ZeroDecimal_ReturnsZero()
	{
		// Arrange
		decimal testValue = 0m;

		// Act
		var result = testValue.ToPositiveValue();

		// Assert
		Assert.AreEqual(0m, result);
	}

	[TestMethod]
	public void ToRomanNumeral_OutOfRange_Low_ThrowsException()
	{
		// Arrange
		var number = 0;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => number.ToRomanNumeral());
	}

	[TestMethod]
	public void ToRomanNumeral_OutOfRange_High_ThrowsException()
	{
		// Arrange
		var number = 4000;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => number.ToRomanNumeral());
	}

	[TestMethod]
	public void ToRomanNumeral_KnownValues_ReturnsCorrect()
	{
		Assert.AreEqual("I", 1.ToRomanNumeral());
		Assert.AreEqual("IV", 4.ToRomanNumeral());
		Assert.AreEqual("IX", 9.ToRomanNumeral());
		Assert.AreEqual("XLII", 42.ToRomanNumeral());
		Assert.AreEqual("MCMXCIX", 1999.ToRomanNumeral());
		Assert.AreEqual("MMMCMXCIX", 3999.ToRomanNumeral());
	}

	[TestMethod]
	public void ToStringOrEmpty_BelowLowerLimit_ReturnsDefaultText()
	{
		// Arrange
		var testValue = 50;

		// Act
		var result = testValue.ToStringOrEmpty(lowerLimit: 100, upperLimit: 9000, defaultText: OutOfRange);

		// Assert
		Assert.AreEqual(OutOfRange, result);
	}

	[TestMethod]
	public void ToStringOrEmpty_DefaultParameters_ReturnsValue()
	{
		// Arrange
		var testValue = 500;

		// Act
		var result = testValue.ToStringOrEmpty();

		// Assert
		Assert.AreEqual("500", result);
	}

	[TestMethod]
	public void ToWords_Zero_ReturnsZero()
	{
		// Act
		var result = 0.ToWords();

		// Assert
		Assert.AreEqual("Zero", result);
	}

	[TestMethod]
	public void ToWords_NegativeValue_ReturnsMinusPrefix()
	{
		// Act
		var result = (-5).ToWords();

		// Assert
		Assert.IsTrue(result.StartsWith("Minus", StringComparison.Ordinal));
	}

	[TestMethod]
	public void ToWords_ValueUnder20_ReturnsUnitWord()
	{
		// Act
		var result = 7.ToWords();

		// Assert
		Assert.AreEqual("Seven", result);
	}

	[TestMethod]
	public void ToWords_ValueWithTens_ReturnsCorrect()
	{
		// Act - 42 should have tens + units
		var result = 42.ToWords();

		// Assert
		Assert.IsTrue(result.HasValue());
		Assert.IsTrue(result.Contains('-'));
	}

	[TestMethod]
	public void ToWords_Millions_ReturnsCorrect()
	{
		// Act
		var result = 1000000.ToWords();

		// Assert
		Assert.IsTrue(result.Contains("Million"));
	}

	[TestMethod]
	public void ToWords_Hundred_ReturnsCorrect()
	{
		// Act
		var result = 100.ToWords();

		// Assert
		Assert.IsTrue(result.Contains("Hundred"));
	}

	[TestMethod]
	public void FormatSizeDouble_Zero_ReturnsZeroBytes()
	{
		// Act
		var result = 0.0.FormatSize();

		// Assert
		Assert.AreEqual("0 Bytes", result);
	}

	[TestMethod]
	public void FormatSizeDouble_KilobytesRange_ReturnsKB()
	{
		// Act
		var result = 5000.0.FormatSize();

		// Assert
		Assert.AreEqual("4.88 KB", result);
	}

	[TestMethod]
	public void FormatTime_Long_ZeroMilliseconds_ReturnsZeroMilliseconds()
	{
		// Act
		var result = NumericExtensions.FormatTime(0L);

		// Assert
		Assert.AreEqual("0 milliseconds", result);
	}

	[TestMethod]
	public void FormatTime_Double_ZeroMilliseconds_ReturnsZeroMilliseconds()
	{
		// Act
		var result = NumericExtensions.FormatTime(0.0);

		// Assert
		Assert.AreEqual("0 milliseconds", result);
	}

}
