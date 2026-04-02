// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-02-2026
// ***********************************************************************
// <copyright file="EnumerationTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerationTests
{

	[TestMethod]
	public void AbsoluteDifference_NullFirstValue_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Enumeration.AbsoluteDifference(null, DateTimeFormat.MonthDay));
	}

	[TestMethod]
	public void AbsoluteDifference_NullSecondValue_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Enumeration.AbsoluteDifference(DateTimeFormat.MonthDay, null));
	}

	[TestMethod]
	public void AbsoluteDifference_ValidValues_ReturnsCorrectDifference()
	{
		var difference = Enumeration.AbsoluteDifference(DateTimeFormat.MonthDay, DateTimeFormat.MonthYear);
		Assert.AreEqual(Math.Abs(DateTimeFormat.MonthDay.Value - DateTimeFormat.MonthYear.Value), difference);
	}

	[TestMethod]
	public void AbsoluteDifferenceTest()
	{
		Assert.IsGreaterThan(0, DateTimeFormat.AbsoluteDifference(DateTimeFormat.MonthDay, DateTimeFormat.MonthYear));
	}

	[TestMethod]
	public void CompareTo_DifferentType_ThrowsArgumentException()
	{
		var numericFormat = NumericFormat.Currency;
		var differentType = new object();
		_ = Assert.ThrowsExactly<ArgumentException>(() => numericFormat.CompareTo(differentType));
	}

	[TestMethod]
	public void CompareTo_SameType_ReturnsCorrectComparison()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Decimal;
		var numericFormat3 = NumericFormat.Currency;

		Assert.IsLessThan(0, numericFormat1.CompareTo(numericFormat2));
		Assert.IsGreaterThan(0, numericFormat2.CompareTo(numericFormat1));
		Assert.AreEqual(0, numericFormat1.CompareTo(numericFormat3));
	}

	[TestMethod]
	public void DisplayNameTest()
	{
		Assert.IsNotNull(DateTimeFormat.MonthDay.DisplayName);
	}

	[TestMethod]
	public void Equals_DifferentType_ReturnsFalse()
	{
		var numericFormat = NumericFormat.Currency;
		var differentType = new object();
		Assert.IsFalse(numericFormat.Equals(differentType));
	}

	[TestMethod]
	public void Equals_NullObject_ReturnsFalse()
	{
		var numericFormat = NumericFormat.Currency;
		Assert.IsFalse(numericFormat.Equals(null));
	}

	[TestMethod]
	public void Equals_SameTypeDifferentValue_ReturnsFalse()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Decimal;
		Assert.IsFalse(numericFormat1.Equals(numericFormat2));
	}

	[TestMethod]
	public void Equals_SameTypeSameValue_ReturnsTrue()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Currency;
		Assert.IsTrue(numericFormat1.Equals(numericFormat2));
	}

	[TestMethod]
	public void EqualsTest()
	{
		var dateTimeFormat = DateTimeFormat.FullDateLongTime;

		Assert.IsTrue(dateTimeFormat.Equals(DateTimeFormat.FullDateLongTime));
	}

	[TestMethod]
	public void FromDisplayName_EmptyDisplayName_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Enumeration.FromDisplayName<NumericFormat>(string.Empty));
	}

	[TestMethod]
	public void FromDisplayName_NullDisplayName_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Enumeration.FromDisplayName<NumericFormat>(null));
	}

	[TestMethod]
	public void FromDisplayName_ValidDisplayName_ReturnsCorrectEnumeration()
	{
		var result = Enumeration.FromDisplayName<NumericFormat>("C");
		Assert.AreEqual(NumericFormat.Currency, result);
	}

	[TestMethod]
	public void FromValue_InvalidValue_ThrowsInvalidOperationException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Enumeration.FromValue<NumericFormat>(999));
	}

	[TestMethod]
	public void FromValue_ValidValue_ReturnsCorrectEnumeration()
	{
		var result = Enumeration.FromValue<NumericFormat>(1);
		Assert.AreEqual("D", result.DisplayName);
	}

	[TestMethod]
	public void GetAll_ReturnsAllEnumerationInstances()
	{
		var allNumericFormats = Enumeration.GetAll<NumericFormat>().ToList();
		Assert.HasCount(17, allNumericFormats);
		Assert.Contains(NumericFormat.Currency, allNumericFormats);
		Assert.Contains(NumericFormat.Decimal, allNumericFormats);
		Assert.Contains(NumericFormat.Percent, allNumericFormats);
	}


	[TestMethod]
	public void GetHashCode_DifferentValue_ReturnsDifferentHashCode()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Decimal;
		Assert.AreNotEqual(numericFormat1.GetHashCode(), numericFormat2.GetHashCode());
	}

	[TestMethod]
	public void GetHashCode_SameValue_ReturnsSameHashCode()
	{
		var numericFormat1 = NumericFormat.Currency;
		var numericFormat2 = NumericFormat.Currency;
		Assert.AreEqual(numericFormat1.GetHashCode(), numericFormat2.GetHashCode());
	}

	[TestMethod]
	public void GetHashCodeTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		Assert.IsTrue(person.GetHashCode().IsInRange(int.MinValue, int.MaxValue));
	}

	[TestMethod]
	public void ToStringTest()
	{
		var dateTimeFormat = DateTimeFormat.FullDateLongTime;

		Assert.IsTrue(string.IsNullOrEmpty(dateTimeFormat.ToString()) is false);
	}

	[TestMethod]
	public void TryFromDisplayName_InvalidDisplayName_ReturnsFalseAndNullResult()
	{
		var success = Enumeration.TryFromDisplayName<NumericFormat>("NotAFormat", out var result);
		Assert.IsFalse(success);
		Assert.IsNull(result);
	}

	[TestMethod]
	public void TryFromDisplayName_NullDisplayName_ReturnsFalseAndNullResult()
	{
		var success = Enumeration.TryFromDisplayName<NumericFormat>(null, out var result);
		Assert.IsFalse(success);
		Assert.IsNull(result);
	}

	[TestMethod]
	public void TryFromDisplayName_ValidDisplayName_ReturnsTrueAndCorrectResult()
	{
		var success = Enumeration.TryFromDisplayName<NumericFormat>("C", out var result);
		Assert.IsTrue(success);
		Assert.IsNotNull(result);
		Assert.AreEqual(NumericFormat.Currency, result);
	}

	[TestMethod]
	public void TryFromValue_InvalidValue_ReturnsFalseAndNullResult()
	{
		var success = Enumeration.TryFromValue<NumericFormat>(999, out var result);
		Assert.IsFalse(success);
		Assert.IsNull(result);
	}
	[TestMethod]
	public void TryFromValue_ValidValue_ReturnsTrueAndCorrectResult()
	{
		var success = Enumeration.TryFromValue<NumericFormat>(1, out var result);
		Assert.IsTrue(success);
		Assert.IsNotNull(result);
		Assert.AreEqual("D", result.DisplayName);
	}

	[TestMethod]
	public void ValueTest()
	{
		Assert.IsNotNull(DateTimeFormat.MonthDay.Value);
	}

	[TestMethod]
	public void CompareTo_Null_ReturnsPositive()
	{
		var result = NumericFormat.Currency.CompareTo(null);
		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void Equals_DifferentEnumerationType_SameValue_ReturnsFalse()
	{
		// DateTimeFormat.FullDateLongTime has value 0, NumericFormat.Currency has value 0
		Assert.IsFalse(DateTimeFormat.FullDateLongTime.Equals(NumericFormat.Currency));
	}

	[TestMethod]
	public void FromDisplayName_InvalidDisplayName_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Enumeration.FromDisplayName<NumericFormat>("NonExistentDisplayName"));
	}

	[TestMethod]
	public void ToString_ReturnsDisplayName()
	{
		var format = NumericFormat.Currency;
		Assert.AreEqual(format.DisplayName, format.ToString());
	}

	[TestMethod]
	public void TryFromDisplayName_EmptyDisplayName_ReturnsFalseAndNullResult()
	{
		var success = Enumeration.TryFromDisplayName<NumericFormat>(string.Empty, out var result);
		Assert.IsFalse(success);
		Assert.IsNull(result);
	}

	[TestMethod]
	public void TryFromDisplayName_WhitespaceDisplayName_ReturnsFalseAndNullResult()
	{
		var success = Enumeration.TryFromDisplayName<NumericFormat>("   ", out var result);
		Assert.IsFalse(success);
		Assert.IsNull(result);
	}

	[TestMethod]
	public void OperatorEqual_SameValue_ReturnsTrue()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Currency;
		Assert.IsTrue(left == right);
	}

	[TestMethod]
	public void OperatorEqual_DifferentValue_ReturnsFalse()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Decimal;
		Assert.IsFalse(left == right);
	}

	[TestMethod]
	public void OperatorEqual_BothNull_ReturnsTrue()
	{
		NumericFormat left = null;
		NumericFormat right = null;
		Assert.IsTrue(left == right);
	}

	[TestMethod]
	public void OperatorEqual_LeftNull_ReturnsFalse()
	{
		NumericFormat left = null;
		var right = NumericFormat.Currency;
		Assert.IsFalse(left == right);
	}

	[TestMethod]
	public void OperatorEqual_RightNull_ReturnsFalse()
	{
		var left = NumericFormat.Currency;
		NumericFormat right = null;
		Assert.IsFalse(left == right);
	}

	[TestMethod]
	public void OperatorNotEqual_DifferentValue_ReturnsTrue()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Decimal;
		Assert.IsTrue(left != right);
	}

	[TestMethod]
	public void OperatorNotEqual_SameValue_ReturnsFalse()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Currency;
		Assert.IsFalse(left != right);
	}

	[TestMethod]
	public void OperatorGreaterThan_LeftGreaterThanRight_ReturnsTrue()
	{
		var left = NumericFormat.Decimal;
		var right = NumericFormat.Currency;
		Assert.IsTrue(left > right);
	}

	[TestMethod]
	public void OperatorGreaterThan_LeftEqualToRight_ReturnsFalse()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Currency;
		Assert.IsFalse(left > right);
	}

	[TestMethod]
	public void OperatorGreaterThan_LeftNull_ReturnsFalse()
	{
		NumericFormat left = null;
		var right = NumericFormat.Currency;
		Assert.IsFalse(left > right);
	}

	[TestMethod]
	public void OperatorGreaterThanOrEqual_LeftGreaterThanRight_ReturnsTrue()
	{
		var left = NumericFormat.Decimal;
		var right = NumericFormat.Currency;
		Assert.IsTrue(left >= right);
	}

	[TestMethod]
	public void OperatorGreaterThanOrEqual_LeftEqualToRight_ReturnsTrue()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Currency;
		Assert.IsTrue(left >= right);
	}

	[TestMethod]
	public void OperatorGreaterThanOrEqual_LeftLessThanRight_ReturnsFalse()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Decimal;
		Assert.IsFalse(left >= right);
	}

	[TestMethod]
	public void OperatorGreaterThanOrEqual_BothNull_ReturnsTrue()
	{
		NumericFormat left = null;
		NumericFormat right = null;
		Assert.IsTrue(left >= right);
	}

	[TestMethod]
	public void OperatorGreaterThanOrEqual_LeftNull_RightNotNull_ReturnsFalse()
	{
		NumericFormat left = null;
		var right = NumericFormat.Currency;
		Assert.IsFalse(left >= right);
	}

	[TestMethod]
	public void OperatorLessThan_LeftLessThanRight_ReturnsTrue()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Decimal;
		Assert.IsTrue(left < right);
	}

	[TestMethod]
	public void OperatorLessThan_LeftEqualToRight_ReturnsFalse()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Currency;
		Assert.IsFalse(left < right);
	}

	[TestMethod]
	public void OperatorLessThan_LeftNull_RightNotNull_ReturnsTrue()
	{
		NumericFormat left = null;
		var right = NumericFormat.Currency;
		Assert.IsTrue(left < right);
	}

	[TestMethod]
	public void OperatorLessThan_BothNull_ReturnsFalse()
	{
		NumericFormat left = null;
		NumericFormat right = null;
		Assert.IsFalse(left < right);
	}

	[TestMethod]
	public void OperatorLessThanOrEqual_LeftLessThanRight_ReturnsTrue()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Decimal;
		Assert.IsTrue(left <= right);
	}

	[TestMethod]
	public void OperatorLessThanOrEqual_LeftEqualToRight_ReturnsTrue()
	{
		var left = NumericFormat.Currency;
		var right = NumericFormat.Currency;
		Assert.IsTrue(left <= right);
	}

	[TestMethod]
	public void OperatorLessThanOrEqual_LeftGreaterThanRight_ReturnsFalse()
	{
		var left = NumericFormat.Decimal;
		var right = NumericFormat.Currency;
		Assert.IsFalse(left <= right);
	}

	[TestMethod]
	public void OperatorLessThanOrEqual_LeftNull_ReturnsTrue()
	{
		NumericFormat left = null;
		var right = NumericFormat.Currency;
		Assert.IsTrue(left <= right);
	}

}
