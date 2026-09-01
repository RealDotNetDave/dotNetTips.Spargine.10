// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 07-12-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="MathExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class MathExtensionsTests
{

	[TestMethod]
	public void Add_NegativeNumbers_ReturnsSum()
	{
		// Arrange
		int input = -10;
		int add = -5;
		double expectedResult = -15;

		// Act
		double result = input.Add(add);

		// Assert
		Assert.AreEqual(expectedResult, result, "Adding two negative numbers should return their sum.");
	}

	[TestMethod]
	public void Add_TwoPositiveIntegers_ReturnsSum()
	{
		// Arrange
		int input = RandomData.GenerateInteger(1, 1000);
		int add = RandomData.GenerateInteger(1, 1000);
		double expectedResult = input + add;

		// Act
		double result = input.Add(add);

		// Assert
		Assert.AreEqual(expectedResult, result, "Adding two positive integers should return their sum.");
	}

	[TestMethod]
	public void Add_WithZero_ReturnsOriginalValue()
	{
		// Arrange
		int input = RandomData.GenerateInteger(1, 1000);
		double expectedResult = input;

		// Act
		double result = input.Add(0);

		// Assert
		Assert.AreEqual(expectedResult, result, "Adding zero should return the original value.");
	}

	[TestMethod]
	public void CalculatePercent_DoubleNegativeDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		double first = 200.0;
		double second = 100.0;

		// Expected percentage calculation: ((100 - 200) / 200) * 100 = -50%
		double expectedPercentage = -50.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a negative difference.");
	}

	[TestMethod]
	public void CalculatePercent_DoublePositiveDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		double first = 100.0;
		double second = 200.0;

		// Expected percentage calculation: ((200 - 100) / 100) * 100 = 100%
		double expectedPercentage = 100.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a positive difference.");
	}

	[TestMethod]
	public void CalculatePercent_DoubleSameValues_ReturnsZero()
	{
		// Arrange
		double first = 100.0;
		double second = 100.0;

		// Expected percentage calculation: ((100 - 100) / 100) * 100 = 0%
		double expectedPercentage = 0.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should be zero when both values are the same.");
	}

	[TestMethod]
	public void CalculatePercent_DoubleZeroFirstValue_ReturnsInfinity()
	{
		// Arrange
		double first = 0.0;
		double second = 100.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.IsTrue(double.IsPositiveInfinity(result), "Dividing by zero first value for doubles should return positive infinity.");
	}

	[TestMethod]
	public void CalculatePercent_IntegerNegativeDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		int first = 200;
		int second = 100;

		// Integer division truncates: (100 - 200) / 200 * 100 = -100 / 200 * 100 = 0 * 100 = 0
		double expectedPercentage = 0.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should reflect integer division behavior.");
	}

	[TestMethod]
	public void CalculatePercent_IntegerPositiveDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		int first = 100;
		int second = 200;

		// Expected percentage calculation: ((200 - 100) / 100) * 100 = 100%
		double expectedPercentage = 100.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a positive difference.");
	}

	[TestMethod]
	public void CalculatePercent_IntegerSameValues_ReturnsZero()
	{
		// Arrange
		int first = 100;
		int second = 100;

		// Expected percentage calculation: ((100 - 100) / 100) * 100 = 0%
		double expectedPercentage = 0.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should be zero when both values are the same.");
	}


	[TestMethod]
	public void CalculatePercent_IntegerZeroFirstValue_ThrowsDivideByZeroException()
	{
		// Arrange
		int first = 0;
		int second = 100;

		// Act & Assert
		Assert.ThrowsExactly<DivideByZeroException>(() => first.CalculatePercent(second));
	}

	[TestMethod]
	public void CalculatePercent_LongPositiveDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		long first = 100L;
		long second = 200L;

		// Expected percentage calculation: ((200 - 100) / 100) * 100 = 100%
		double expectedPercentage = 100.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a positive difference.");
	}

	[TestMethod]
	public void CalculatePercent_LongSameValues_ReturnsZero()
	{
		// Arrange
		long first = 100L;
		long second = 100L;

		// Expected percentage calculation: ((100 - 100) / 100) * 100 = 0%
		double expectedPercentage = 0.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should be zero when both values are the same.");
	}

	[TestMethod]
	public void CalculatePercent_LongNegativeDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		long first = 200L;
		long second = 100L;

		// Long integer division truncates: (100 - 200) / 200 * 100 = -100 / 200 * 100 = 0 * 100 = 0
		double expectedPercentage = 0.0;

		// Act
		double result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should reflect long integer division behavior.");
	}

	[TestMethod]
	public void CalculatePercent_LongZeroFirstValue_ThrowsDivideByZeroException()
	{
		// Arrange
		long first = 0L;
		long second = 100L;

		// Act & Assert
		Assert.ThrowsExactly<DivideByZeroException>(() => first.CalculatePercent(second));
	}


	[TestMethod]
	public void CalculatePercent_NegativeDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		var first = TimeSpan.FromMilliseconds(200);
		var second = TimeSpan.FromMilliseconds(100);

		// Expected percentage calculation: ((100 - 200) / 200) * 100 = -50%
		var expectedPercentage = -50.0;

		// Act
		var result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a negative difference.");
	}
	[TestMethod]
	public void CalculatePercent_PositiveDifference_ReturnsExpectedPercentage()
	{
		// Arrange
		var first = TimeSpan.FromMilliseconds(100);
		var second = TimeSpan.FromMilliseconds(200);

		// Expected percentage calculation: ((200 - 100) / 100) * 100 = 100%
		var expectedPercentage = 100.0;

		// Act
		var result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should match the expected value for a positive difference.");
	}

	[TestMethod]
	public void CalculatePercent_SameValues_ReturnsZero()
	{
		// Arrange
		var first = TimeSpan.FromMilliseconds(100);
		var second = TimeSpan.FromMilliseconds(100);

		// Expected percentage calculation: ((100 - 100) / 100) * 100 = 0%
		var expectedPercentage = 0.0;

		// Act
		var result = first.CalculatePercent(second);

		// Assert
		Assert.AreEqual(expectedPercentage, result, "The calculated percentage should be zero when both values are the same.");
	}

	[TestMethod]
	public void CalculatePercent_TimeSpanZeroFirstValue_ReturnsInfinity()
	{
		// Arrange
		var first = TimeSpan.Zero;
		var second = TimeSpan.FromMilliseconds(100);

		// Act
		var result = first.CalculatePercent(second);

		// Assert
		Assert.IsTrue(double.IsPositiveInfinity(result), "Dividing by zero first value for TimeSpan should return positive infinity.");
	}

	[TestMethod]
	public void IsPrime_GivenNegativeNumber_ReturnsFalse()
	{
		// Arrange
		int negativeNumber = -5;

		// Act
		bool result = negativeNumber.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for a negative number.");
	}

	[TestMethod]
	public void IsPrime_GivenNonPrimeNumber_ReturnsFalse()
	{
		// Arrange
		int nonPrimeNumber = 4;

		// Act
		bool result = nonPrimeNumber.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for a non-prime number.");
	}

	[TestMethod]
	public void IsPrime_GivenNumberDivisibleByCountInLoop_ReturnsFalse()
	{
		// Arrange - 25 is divisible by 5, which is the first count value in the loop
		int number = 25;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for 25, which is divisible by 5 in the loop.");
	}

	[TestMethod]
	public void IsPrime_GivenNumberDivisibleByCountPlusTwoInLoop_ReturnsFalse()
	{
		// Arrange - 49 is divisible by 7 (count + 2 where count = 5)
		int number = 49;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for 49, which is divisible by 7 in the loop.");
	}

	[TestMethod]
	public void IsPrime_GivenNumberDivisibleByThree_ReturnsFalse()
	{
		// Arrange - 9 is odd but divisible by 3
		int number = 9;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for 9, which is divisible by 3.");
	}

	[TestMethod]
	public void IsPrime_GivenEvenNumberGreaterThanThree_ReturnsFalse()
	{
		// Arrange - 6 is even and greater than 3
		int number = 6;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for 6, which is even and greater than 3.");
	}

	[TestMethod]
	public void IsPrime_GivenLargePrimePassingLoop_ReturnsTrue()
	{
		// Arrange - 29 is prime and requires the loop to verify
		int number = 29;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsTrue(result, "The method should return true for 29, a prime number that requires loop verification.");
	}

	[TestMethod]
	public void IsPrime_GivenOne_ReturnsFalse()
	{
		// Arrange
		int number = 1;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for one.");
	}

	[TestMethod]
	public void IsPrime_GivenPrimeNumber_ReturnsTrue()
	{
		// Arrange
		int primeNumber = 13;

		// Act
		bool result = primeNumber.IsPrime();

		// Assert
		Assert.IsTrue(result, "The method should return true for a prime number.");
	}

	[TestMethod]
	public void IsPrime_GivenThree_ReturnsTrue()
	{
		// Arrange
		int number = 3;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsTrue(result, "The method should return true for three, which is a prime number.");
	}

	[TestMethod]
	public void IsPrime_GivenTwo_ReturnsTrue()
	{
		// Arrange
		int number = 2;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsTrue(result, "The method should return true for two, which is a prime number.");
	}

	[TestMethod]
	public void IsPrime_GivenZero_ReturnsFalse()
	{
		// Arrange
		int number = 0;

		// Act
		bool result = number.IsPrime();

		// Assert
		Assert.IsFalse(result, "The method should return false for zero.");
	}

	[TestMethod]
	public void Round_DecimalValueLessThanHalfway_ReturnsRoundedDownInteger()
	{
		// Arrange
		decimal value = 3.4m;

		// Expected result is 3 because 3.4 rounds down to 3
		int expectedResult = 3;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding down when less than halfway.");
	}

	[TestMethod]
	public void Round_DecimalValueMoreThanHalfway_ReturnsRoundedUpInteger()
	{
		// Arrange
		decimal value = 6.6m;

		// Expected result is 7 because 6.6 rounds up to 7
		int expectedResult = 7;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding up when more than halfway.");
	}
	[TestMethod]
	public void Round_DecimalValueWithAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.5m;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 with AwayFromZero should result in 3.");
	}

	[TestMethod]
	public void Round_DecimalValueWithHighDigits_NoChange()
	{
		// Arrange
		decimal value = 2.555m;
		int digits = 10; // A high number of decimal places should not change the value before converting to int
		int expectedResult = 3; // 2.555 remains 2.555, which rounds to 3

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.555 to 10 decimal places should result in 3.");
	}

	[TestMethod]
	public void Round_DecimalValueWithOneDigit_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = 2.25m;
		int digits = 1;
		int expectedResult = 2;

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.25 to 1 decimal place should result in 2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithToEvenRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.5m;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = 2;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 with ToEven should result in 2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithToZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.8m;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = 2;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.8 with ToZero should result in 2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithTwoDigits_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = 2.25m;
		int digits = 2;
		int expectedResult = 2;

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.25 to 2 decimal places should result in 2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithZeroDigits_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.8m;
		int digits = 0;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.8 to 0 decimal places should result in 3.");
	}

	[TestMethod]
	public void Round_DecimalValueWithZeroDigitsAndAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = 2.5m;
		int digits = 0;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		decimal expectedResult = 3m;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 to 0 decimal places with AwayFromZero should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValue_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.5;

		// Expected result is 3 because 2.5 rounds up to 3
		int expectedResult = 3;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer.");
	}

	[TestMethod]
	public void Round_DoubleValueHalfway_ReturnsRoundedUpInteger()
	{
		// Arrange
		double value = 4.5;

		// Expected result is 5 because 4.5 rounds up to 5 according to the default rounding mechanism
		int expectedResult = 5;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding halfway cases away from zero.");
	}

	[TestMethod]
	public void Round_DoubleValueMoreThanHalfway_ReturnsRoundedUpInteger()
	{
		// Arrange
		double value = 6.6;

		// Expected result is 7 because 6.6 rounds up to 7
		int expectedResult = 7;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding up when more than halfway.");
	}

	[TestMethod]
	public void Round_DoubleValueWithAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.5;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = 3;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 with AwayFromZero should result in 3.");
	}
	[TestMethod]
	public void Round_DoubleValueWithDigits_ReturnsRoundedValue()
	{
		// Arrange
		double value = 2.555;
		int digits = 2;
		int expectedResult = 3; // Rounding 2.555 to 2 decimal places should round up to 2.56, then to 3 when converting to int

		// Act
		int result = value.Round(digits);

		// Assert
		Assert.AreEqual(expectedResult, result, $"Rounding {value} to {digits} decimal places should result in {expectedResult}.");
	}
	[TestMethod]
	public void Round_DoubleValueWithDigitsAndAwayFromZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = 2.55;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.55 to 1 decimal place with AwayFromZero should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValueWithDigitsAndToEvenRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = 2.55;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.55 to 1 decimal place with ToEven should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValueWithHighDigits_NoChange()
	{
		// Arrange
		double value = 2.555;
		int digits = 10; // A high number of decimal places should not change the value before converting to int
		int expectedResult = 3; // 2.555 remains 2.555, which rounds to 3

		// Act
		int result = value.Round(digits);

		// Assert
		Assert.AreEqual(expectedResult, result, $"Rounding {value} to {digits} decimal places should result in {expectedResult}.");
	}

	[TestMethod]
	public void Round_DoubleValueWithHighDigitsAndToEvenRounding_NoChange()
	{
		// Arrange
		double value = 2.555;
		int digits = 10; // A high number of decimal places should not change the value before converting to int
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = 3; // 2.555 remains 2.555, which rounds to 3

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.555 to 10 decimal places with ToEven should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValueWithToEvenRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.5;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = 2;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 with ToEven should result in 2.");
	}

	[TestMethod]
	public void Round_DoubleValueWithToZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.8;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = 2;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.8 with ToZero should result in 2.");
	}

	[TestMethod]
	public void Round_DoubleValueWithZeroDigits_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.8;
		int digits = 0; // Rounding to 0 decimal places is essentially rounding to the nearest whole number
		int expectedResult = 3;

		// Act
		int result = value.Round(digits);

		// Assert
		Assert.AreEqual(expectedResult, result, $"Rounding {value} to {digits} decimal places should result in {expectedResult}.");
	}

	[TestMethod]
	public void Round_DoubleValueWithZeroDigitsAndAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = 2.5;
		int digits = 0;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.5 to 0 decimal places with AwayFromZero should result in 3.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValue_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = -2.5m;

		// Expected result is -2 because -2.5 rounds up to -2
		int expectedResult = -2;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding negative halfway cases away from zero.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = -2.5m;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = -3;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.5 with AwayFromZero should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithDigits_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = -2.55m;
		int digits = 1;
		int expectedResult = -3;

		// Act
		int result = MathExtensions.Round(value, digits);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithDigitsAndAwayFromZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = -2.55m;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		decimal expectedResult = -3m;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place with AwayFromZero should result in -2.6.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithDigitsAndToEvenRounding_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = -2.55m;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToEven;
		decimal expectedResult = -3m;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place with ToEven should result in -2.6.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithToEvenRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = -2.5m;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = -2;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.5 with ToEven should result in -2.");
	}

	[TestMethod]
	public void Round_NegativeDecimalValueWithToZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		decimal value = -2.8m;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = -2;

		// Act
		int result = MathExtensions.Round(value, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.8 with ToZero should result in -2.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValue_ReturnsRoundedInteger()
	{
		// Arrange
		double value = -2.5;

		// Expected result is -2 because -2.5 rounds up to -2
		int expectedResult = -2;

		// Act
		int result = value.Round();

		// Assert
		Assert.AreEqual(expectedResult, result, "The rounded value should be the nearest integer, rounding negative halfway cases away from zero.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithAwayFromZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = -2.5;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = -3;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.5 with AwayFromZero should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithDigits_ReturnsRoundedValue()
	{
		// Arrange
		double value = -2.555;
		int digits = 2;
		int expectedResult = -3; // Rounding -2.555 to 2 decimal places should round up to -2.56, then to -3 when converting to int

		// Act
		int result = value.Round(digits);

		// Assert
		Assert.AreEqual(expectedResult, result, $"Rounding {value} to {digits} decimal places should result in {expectedResult}.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithDigitsAndAwayFromZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = -2.55;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.AwayFromZero;
		int expectedResult = -3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place with AwayFromZero should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithDigitsAndToEvenRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = -2.55;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = -3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.55 to 1 decimal place with ToEven should result in -3.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithToEvenRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = -2.5;
		MidpointRounding mode = MidpointRounding.ToEven;
		int expectedResult = -2;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.5 with ToEven should result in -2.");
	}

	[TestMethod]
	public void Round_NegativeDoubleValueWithToZeroRounding_ReturnsRoundedInteger()
	{
		// Arrange
		double value = -2.8;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = -2;

		// Act
		int result = value.Round(mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding -2.8 with ToZero should result in -2.");
	}

	[TestMethod]
	public void Round_DecimalValueWithDigitsAndToZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		decimal value = 2.85m;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.85 to 1 decimal place with ToZero should result in 3.");
	}

	[TestMethod]
	public void Round_DoubleValueWithDigitsAndToZeroRounding_ReturnsRoundedValue()
	{
		// Arrange
		double value = 2.85;
		int digits = 1;
		MidpointRounding mode = MidpointRounding.ToZero;
		int expectedResult = 3;

		// Act
		int result = MathExtensions.Round(value, digits, mode);

		// Assert
		Assert.AreEqual(expectedResult, result, "Rounding 2.85 to 1 decimal place with ToZero should result in 3.");
	}

	[TestMethod]
	public void Subtract_NegativeNumbers_ReturnsDifference()
	{
		// Arrange
		int input = -10;
		int subtract = -5;
		double expectedResult = -5;

		// Act
		double result = MathExtensions.Subtract(input, subtract);

		// Assert
		Assert.AreEqual(expectedResult, result, "Subtracting -5 from -10 should result in -5.");
	}

	[TestMethod]
	public void Subtract_ResultIsNegative_ReturnsNegativeDifference()
	{
		// Arrange
		int input = 5;
		int subtract = 10;
		double expectedResult = -5;

		// Act
		double result = MathExtensions.Subtract(input, subtract);

		// Assert
		Assert.AreEqual(expectedResult, result, "Subtracting 10 from 5 should result in -5.");
	}

	[TestMethod]
	public void Subtract_TwoIntegers_ReturnsDifference()
	{
		// Arrange
		int input = 10;
		int subtract = 5;
		double expectedResult = 5;

		// Act
		double result = MathExtensions.Subtract(input, subtract);

		// Assert
		Assert.AreEqual(expectedResult, result, "Subtracting 5 from 10 should result in 5.");
	}

	[TestMethod]
	public void Subtract_WithZero_ReturnsOriginalValue()
	{
		// Arrange
		int input = RandomData.GenerateInteger(1, 1000);
		double expectedResult = input;

		// Act
		double result = MathExtensions.Subtract(input, 0);

		// Assert
		Assert.AreEqual(expectedResult, result, "Subtracting zero should return the original value.");
	}

}
