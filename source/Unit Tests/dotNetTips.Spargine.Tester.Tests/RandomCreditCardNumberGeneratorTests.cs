// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 09-17-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="RandomCreditCardNumberGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class RandomCreditCardNumberGeneratorTests
{
	private static bool LuhnCheck(string creditCardNumber)
	{
		var sum = 0;
		var alternate = false;

		for (var i = creditCardNumber.Length - 1; i >= 0; i--)
		{
			var n = creditCardNumber[i] - '0';

			if (alternate)
			{
				n *= 2;

				if (n > 9)
				{
					n -= 9;
				}
			}

			sum += n;
			alternate = !alternate;
		}

		return sum % 10 == 0;
	}

	[TestMethod]
	public void GetCreditCardNumber_ReturnsNonNullResult()
	{
		// Act
		var creditCardNumber = RandomCreditCardNumberGenerator.GetCreditCardNumber();

		// Assert
		Assert.IsNotNull(creditCardNumber);
		Assert.IsNotEmpty(creditCardNumber);
	}

	[TestMethod]
	public void GetCreditCardNumber_ReturnsAllDigits()
	{
		// Act
		var creditCardNumber = RandomCreditCardNumberGenerator.GetCreditCardNumber();

		// Assert
		Assert.IsNotNull(creditCardNumber);
		Assert.IsNotEmpty(creditCardNumber);
		Assert.IsTrue(creditCardNumber.All(char.IsDigit));
	}

	[TestMethod]
	public void GetCreditCardNumber_ReturnsValidLength()
	{
		// Act
		var creditCardNumber = RandomCreditCardNumberGenerator.GetCreditCardNumber();

		// Assert
		Assert.IsNotNull(creditCardNumber);
		Assert.IsTrue(creditCardNumber.Length is 15 or 16);
	}

	[TestMethod]
	public void GetCreditCardNumber_PassesLuhnCheck()
	{
		// Act
		var creditCardNumber = RandomCreditCardNumberGenerator.GetCreditCardNumber();

		// Assert
		Assert.IsNotNull(creditCardNumber);
		Assert.IsTrue(LuhnCheck(creditCardNumber));
	}

	[TestMethod]
	public void GetCreditCardNumber_MultipleCallsReturnValidNumbers()
	{
		// Act & Assert
		for (var i = 0; i < 25; i++)
		{
			var creditCardNumber = RandomCreditCardNumberGenerator.GetCreditCardNumber();

			Assert.IsNotNull(creditCardNumber);
			Assert.IsTrue(creditCardNumber.Length is 15 or 16);
			Assert.IsTrue(creditCardNumber.All(char.IsDigit));
			Assert.IsTrue(LuhnCheck(creditCardNumber));
		}
	}

	[TestMethod]
	public void GetCreditCardNumbers_ReturnsCorrectCount()
	{
		// Arrange
		var count = 56;

		// Act
		var creditCardNumbers = RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);

		// Assert
		Assert.IsNotNull(creditCardNumbers);
		Assert.HasCount(count, creditCardNumbers);
	}

	[TestMethod]
	public void GetCreditCardNumbers_AllItemsPassLuhnCheck()
	{
		// Arrange
		var count = 50;

		// Act
		var creditCardNumbers = RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);

		// Assert
		foreach (var number in creditCardNumbers)
		{
			Assert.IsNotNull(number);
			Assert.IsNotEmpty(number);
			Assert.IsTrue(LuhnCheck(number));
		}
	}

	[TestMethod]
	public void GetCreditCardNumbers_AllItemsAreNonNullAndNonEmpty()
	{
		// Arrange
		var count = 50;

		// Act
		var creditCardNumbers = RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);

		// Assert
		foreach (var number in creditCardNumbers)
		{
			Assert.IsNotNull(number);
			Assert.IsNotEmpty(number);
		}
	}

	[TestMethod]
	public void GetCreditCardNumbers_AllItemsContainOnlyDigits()
	{
		// Arrange
		var count = 50;

		// Act
		var creditCardNumbers = RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);

		// Assert
		foreach (var number in creditCardNumbers)
		{
			Assert.IsTrue(number.All(char.IsDigit));
		}
	}

	[TestMethod]
	public void GetCreditCardNumbers_AllItemsHaveValidLength()
	{
		// Arrange
		var count = 50;

		// Act
		var creditCardNumbers = RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);

		// Assert
		foreach (var number in creditCardNumbers)
		{
			Assert.IsTrue(number.Length is 15 or 16);
		}
	}

	[TestMethod]
	public void GetCreditCardNumbers_WithCountOfOne_ReturnsSingleItem()
	{
		// Act
		var creditCardNumbers = RandomCreditCardNumberGenerator.GetCreditCardNumbers(1);

		// Assert
		Assert.IsNotNull(creditCardNumbers);
		Assert.HasCount(1, creditCardNumbers);
		Assert.IsTrue(LuhnCheck(creditCardNumbers[0]));
	}

	[TestMethod]
	public void GetCreditCardNumbers_WithZeroCount_ThrowsArgumentOutOfRangeException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => RandomCreditCardNumberGenerator.GetCreditCardNumbers(0));
	}

	[TestMethod]
	public void GetCreditCardNumbers_WithNegativeCount_ThrowsArgumentOutOfRangeException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => RandomCreditCardNumberGenerator.GetCreditCardNumbers(-1));
	}

	[TestMethod]
	public void GetCreditCardNumbers_ReturnsReadOnlyCollection()
	{
		// Arrange
		var count = 10;

		// Act
		var creditCardNumbers = RandomCreditCardNumberGenerator.GetCreditCardNumbers(count);

		// Assert
		Assert.IsNotNull(creditCardNumbers);
		Assert.IsInstanceOfType<System.Collections.ObjectModel.ReadOnlyCollection<string>>(creditCardNumbers);
	}
}
