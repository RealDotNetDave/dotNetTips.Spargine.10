// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-30-2025
// ***********************************************************************
// <copyright file="AddressValTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AddressValTests
{

	[TestMethod]
	public void Address_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var id = "1282726223";

		// Act
		var address = new Address(id);

		// Assert
		Assert.AreEqual(id, address.Id);
	}

	[TestMethod]
	public void Address_EqualityOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var address1 = new Address("1229282723");
		var address2 = new Address("1229282723");
		var address3 = new Address("4229282723");

		// Act & Assert
		Assert.IsTrue(address1 == address2);
		Assert.IsFalse(address1 == address3);
		Assert.IsFalse(address1 != address2);
		Assert.IsTrue(address1 != address3);
	}

	[TestMethod]
	public void Address_Equals_ShouldReturnExpectedResults()
	{
		// Arrange
		var address1 = new Address("1229282723");
		var address2 = new Address("1229282723");
		var address3 = new Address("12292827234");

		// Act & Assert
		Assert.IsTrue(address1.Equals(address2));
		Assert.IsFalse(address1.Equals(address3));
		Assert.IsFalse(address1.Equals(null));
	}

	[TestMethod]
	public void Address_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		// Act
		var hashCode1 = address1.GetHashCode();
		var hashCode2 = address2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Address_GetHashCode_ShouldReturnExpectedResults()
	{
		// Arrange
		var address1 = new Address("1229282723");
		var address2 = new Address("1229282723");
		var address3 = new Address("12292827234");

		// Act & Assert
		Assert.AreEqual(address1.GetHashCode(), address2.GetHashCode());
		Assert.AreNotEqual(address1.GetHashCode(), address3.GetHashCode());
	}

	[TestMethod]
	public void Address_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		// Act
		var result = address1 != address2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Address_Properties_SetAndGetValues()
	{
		// Arrange
		var address = new Address("1229282723");
		var address1 = "123 Main St";
		var address2 = "Apt 4B";
		var city = "Anytown";
		var state = "CA";
		var countyProvince = "AnyCounty";
		var country = "USA";
		var postalCode = "12345";
		var phone = "555-1234";

		// Act
		address.Address1 = address1;
		address.Address2 = address2;
		address.City = city;
		address.State = state;
		address.CountyProvince = countyProvince;
		address.Country = country;
		address.PostalCode = postalCode;
		address.Phone = phone;

		// Assert
		Assert.AreEqual(address1, address.Address1);
		Assert.AreEqual(address2, address.Address2);
		Assert.AreEqual(city, address.City);
		Assert.AreEqual(state, address.State);
		Assert.AreEqual(countyProvince, address.CountyProvince);
		Assert.AreEqual(country, address.Country);
		Assert.AreEqual(postalCode, address.PostalCode);
		Assert.AreEqual(phone, address.Phone);
	}

	[TestMethod]
	public void Address_ToAddress_FromAddressRecord_ShouldReturnExpectedResults()
	{
		// Arrange
		var addressRecord = new Models.RefTypes.AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var address = Address.ToAddress(addressRecord);

		// Assert
		Assert.AreEqual(addressRecord.Id, address.Id);
		Assert.AreEqual(addressRecord.Address1, address.Address1);
		Assert.AreEqual(addressRecord.Address2, address.Address2);
		Assert.AreEqual(addressRecord.City, address.City);
		Assert.AreEqual(addressRecord.State, address.State);
		Assert.AreEqual(addressRecord.CountyProvince, address.CountyProvince);
		Assert.AreEqual(addressRecord.Country, address.Country);
		Assert.AreEqual(addressRecord.PostalCode, address.PostalCode);
		Assert.AreEqual(addressRecord.Phone, address.Phone);
	}

	[TestMethod]
	public void Address_ToString_ReturnsCorrectString()
	{
		var address = RandomData.GenerateAddress<Address>();

		var expectedString = address.PropertiesToString();

		// Act
		var result = address.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Address_ToString_ShouldReturnExpectedResults()
	{
		// Arrange
		var address = new Address("1229282723");
		var expectedString = "Id:1229282723";

		// Act
		var result = address.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Address1_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.Address1 = new string('a', 101));
	}

	[TestMethod]
	public void Address2_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.Address2 = new string('a', 101));
	}

	[TestMethod]
	public void City_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.City = new string('a', 101));
	}

	[TestMethod]
	public void CompareTo_DifferentId_ReturnsNonZero()
	{
		// Arrange
		var address1 = new Address("1229282723");
		var address2 = new Address("12292827234");

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_Object_ThrowsOnInvalidType()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentException>(() => ((IComparable)address).CompareTo("not an address"));
	}

	[TestMethod]
	public void CompareTo_SameId_ReturnsZero()
	{
		// Arrange
		var address1 = new Address("1229282723");
		var address2 = new Address("1229282723");

		// Act
		var result = address1.CompareTo(address2);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Country_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.Country = new string('a', 56));
	}

	[TestMethod]
	public void CountyProvince_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.CountyProvince = new string('a', 61));
	}

	[TestMethod]
	public void Id_InitOnly_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Address("short"));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Address(new string('a', 51)));
	}
	[TestMethod]
	public void Operator_Equality_And_Inequality()
	{
		var a1 = Address.Create("1234567890");
		var a2 = Address.Create("1234567890");
		var a3 = Address.Create("ABCDEFGHIJ");
		Assert.IsTrue(a1 == a2);
		Assert.IsFalse(a1 != a2);
		Assert.IsFalse(a1 == a3);
		Assert.IsTrue(a1 != a3);
	}

	[TestMethod]
	public void Operator_Explicit_From_AddressRecord_Works()
	{
		var record = new Models.RefTypes.AddressRecord("1234567890");
		var valueType = (Address)record;
		Assert.AreEqual(record.Id, valueType.Id);
	}

	[TestMethod]
	public void Operator_Explicit_From_RefTypeAddress_Works()
	{
		var refType = Models.RefTypes.Address.Create("1234567890", "A1", "City", "Country", "12345");
		var valueType = (Address)refType;
		Assert.AreEqual(refType.Id, valueType.Id);
		Assert.AreEqual(refType.Address1, valueType.Address1);
	}

	[TestMethod]
	public void Operator_LessThan_LessThanOrEqual_GreaterThan_GreaterThanOrEqual()
	{
		var a1 = Address.Create("1234567890");
		var a2 = Address.Create("ABCDEFGHIJ");
		Assert.IsTrue(a1 < a2 || a2 < a1 || a1 == a2);
		Assert.IsTrue(a1 <= a2 || a2 <= a1);
		Assert.IsTrue(a1 > a2 || a2 > a1 || a1 == a2);
		Assert.IsTrue(a1 >= a2 || a2 >= a1);
	}

	[TestMethod]
	public void Phone_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.Phone = new string('a', 51));
	}

	[TestMethod]
	public void PostalCode_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.PostalCode = new string('a', 26));
	}

	[TestMethod]
	public void State_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.State = new string('a', 100));
	}

	[TestMethod]
	public void ToString_ReturnsDebugString()
	{
		var address = Address.Create("1234567890", "A1", "City", "Country", "12345");
		var str = address.ToString();
		Assert.IsFalse(string.IsNullOrWhiteSpace(str));
		Assert.Contains("Address1", str);
	}
}
