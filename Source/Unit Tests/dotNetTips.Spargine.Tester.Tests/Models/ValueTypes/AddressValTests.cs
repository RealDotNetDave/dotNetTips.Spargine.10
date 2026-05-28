// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-08-2026
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

namespace DotNetTips.Spargine.Tester.Tests.Models.ValueTypes;

[ExcludeFromCodeCoverage]
[TestClass]
public class AddressValTests
{

	[TestMethod]
	public void Address_Constructor_ShouldInitializeProperties()
	{
		var id = "1282726223";

		var address = new Address(id);

		Assert.AreEqual(id, address.Id);
	}

	[TestMethod]
	public void Address_EqualityOperators_ShouldReturnExpectedResults()
	{
		var address1 = new Address("1229282723");
		var address2 = new Address("1229282723");
		var address3 = new Address("4229282723");

		Assert.IsTrue(address1 == address2);
		Assert.IsFalse(address1 == address3);
		Assert.IsFalse(address1 != address2);
		Assert.IsTrue(address1 != address3);
	}

	[TestMethod]
	public void Address_Equals_Object_DifferentType_ReturnsFalse()
	{
		var address = RandomData.GenerateAddress<Address>();

		Assert.IsFalse(address.Equals("not an address"));
	}

	[TestMethod]
	public void Address_Equals_Object_Null_ReturnsFalse()
	{
		var address = RandomData.GenerateAddress<Address>();

		Assert.IsFalse(address.Equals(null));
	}

	[TestMethod]
	public void Address_Equals_ShouldReturnExpectedResults()
	{
		var address1 = new Address("1229282723");
		var address2 = new Address("1229282723");
		var address3 = new Address("12292827234");

		Assert.IsTrue(address1.Equals(address2));
		Assert.IsFalse(address1.Equals(address3));
	}

	[TestMethod]
	public void Address_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		var hashCode1 = address1.GetHashCode();
		var hashCode2 = address2.GetHashCode();

		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Address_GetHashCode_ShouldReturnExpectedResults()
	{
		var address1 = new Address("1229282723");
		var address2 = new Address("1229282723");
		var address3 = new Address("12292827234");

		Assert.AreEqual(address1.GetHashCode(), address2.GetHashCode());
		Assert.AreNotEqual(address1.GetHashCode(), address3.GetHashCode());
	}

	[TestMethod]
	public void Address_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		var result = address1 != address2;

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Address_Properties_SetAndGetValues()
	{
		var address = new Address("1229282723");

		address.Address1 = "123 Main St";
		address.Address2 = "Apt 4B";
		address.City = "Anytown";
		address.State = "CA";
		address.CountyProvince = "AnyCounty";
		address.Country = "USA";
		address.PostalCode = "12345";
		address.Phone = "555-1234";

		Assert.AreEqual("123 Main St", address.Address1);
		Assert.AreEqual("Apt 4B", address.Address2);
		Assert.AreEqual("Anytown", address.City);
		Assert.AreEqual("CA", address.State);
		Assert.AreEqual("AnyCounty", address.CountyProvince);
		Assert.AreEqual("USA", address.Country);
		Assert.AreEqual("12345", address.PostalCode);
		Assert.AreEqual("555-1234", address.Phone);
	}

	[TestMethod]
	public void Address_ToAddress_FromAddressRecord_ShouldReturnExpectedResults()
	{
		var addressRecord = new DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		var address = Address.ToAddress(addressRecord);

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
	public void Address_ToAddress_FromRefTypeAddress_ShouldReturnExpectedResults()
	{
		var refAddress = RandomData.GenerateAddress<DotNetTips.Spargine.Tester.Models.RefTypes.Address>();

		var address = Address.ToAddress(refAddress);

		Assert.AreEqual(refAddress.Id, address.Id);
		Assert.AreEqual(refAddress.Address1, address.Address1);
		Assert.AreEqual(refAddress.Address2, address.Address2);
		Assert.AreEqual(refAddress.City, address.City);
		Assert.AreEqual(refAddress.State, address.State);
		Assert.AreEqual(refAddress.CountyProvince, address.CountyProvince);
		Assert.AreEqual(refAddress.Country, address.Country);
		Assert.AreEqual(refAddress.PostalCode, address.PostalCode);
		Assert.AreEqual(refAddress.Phone, address.Phone);
	}

	[TestMethod]
	public void Address_ToString_ReturnsCorrectString()
	{
		var address = RandomData.GenerateAddress<Address>();

		var expectedString = address.PropertiesToString();

		var result = address.ToString();

		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Address_ToString_ShouldReturnExpectedResults()
	{
		var address = new Address("1229282723");
		var expectedString = "Id:1229282723";

		var result = address.ToString();

		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Address1_SetNull_ConvertsToEmpty()
	{
		var address = RandomData.GenerateAddress<Address>();

		address.Address1 = null;

		Assert.AreEqual(string.Empty, address.Address1);
	}

	[TestMethod]
	public void Address1_SetSameValue_NoOp()
	{
		var address = Address.Create("1234567890");
		address.Address1 = "Test Street";

		address.Address1 = "test street";

		Assert.AreEqual("Test Street", address.Address1);
	}

	[TestMethod]
	public void Address1_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.Address1 = new string('a', 101));
	}

	[TestMethod]
	public void Address2_SetNull_ConvertsToEmpty()
	{
		var address = RandomData.GenerateAddress<Address>();

		address.Address2 = null;

		Assert.AreEqual(string.Empty, address.Address2);
	}

	[TestMethod]
	public void Address2_SetSameValue_NoOp()
	{
		var address = Address.Create("1234567890");
		address.Address2 = "Suite 100";

		address.Address2 = "suite 100";

		Assert.AreEqual("Suite 100", address.Address2);
	}

	[TestMethod]
	public void Address2_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.Address2 = new string('a', 101));
	}

	[TestMethod]
	public void City_SetNull_ConvertsToEmpty()
	{
		var address = RandomData.GenerateAddress<Address>();

		address.City = null;

		Assert.AreEqual(string.Empty, address.City);
	}

	[TestMethod]
	public void City_SetSameValue_NoOp()
	{
		var address = Address.Create("1234567890");
		address.City = "Anytown";

		address.City = "anytown";

		Assert.AreEqual("Anytown", address.City);
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
		var address1 = new Address("1229282723");
		var address2 = new Address("12292827234");

		var result = address1.CompareTo(address2);

		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_Object_NullReturnsPositive()
	{
		var address = RandomData.GenerateAddress<Address>();

		var result = ((IComparable)address).CompareTo(null);

		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void CompareTo_Object_ThrowsOnInvalidType()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentException>(() => ((IComparable)address).CompareTo("not an address"));
	}

	[TestMethod]
	public void CompareTo_Object_ValidAddress_ReturnsExpected()
	{
		var address1 = Address.Create("1234567890");
		object address2 = Address.Create("1234567890");

		var result = ((IComparable)address1).CompareTo(address2);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_SameId_ReturnsZero()
	{
		var address1 = new Address("1229282723");
		var address2 = new Address("1229282723");

		var result = address1.CompareTo(address2);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Country_SetNull_ConvertsToEmpty()
	{
		var address = RandomData.GenerateAddress<Address>();

		address.Country = null;

		Assert.AreEqual(string.Empty, address.Country);
	}

	[TestMethod]
	public void Country_SetSameValue_NoOp()
	{
		var address = Address.Create("1234567890");
		address.Country = "USA";

		address.Country = "usa";

		Assert.AreEqual("USA", address.Country);
	}

	[TestMethod]
	public void Country_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.Country = new string('a', 56));
	}

	[TestMethod]
	public void CountyProvince_SetNull_ConvertsToEmpty()
	{
		var address = RandomData.GenerateAddress<Address>();

		address.CountyProvince = null;

		Assert.AreEqual(string.Empty, address.CountyProvince);
	}

	[TestMethod]
	public void CountyProvince_SetSameValue_NoOp()
	{
		var address = Address.Create("1234567890");
		address.CountyProvince = "AnyCounty";

		address.CountyProvince = "anycounty";

		Assert.AreEqual("AnyCounty", address.CountyProvince);
	}

	[TestMethod]
	public void CountyProvince_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.CountyProvince = new string('a', 61));
	}

	[TestMethod]
	public void Create_AllParams_CreatesAddress()
	{
		var address = Address.Create("1234567890", "123 Main St", "Anytown", "USA", "12345", "Apt 4B", "AnyCounty", "CA", "555-1234");

		Assert.AreEqual("1234567890", address.Id);
		Assert.AreEqual("123 Main St", address.Address1);
		Assert.AreEqual("Apt 4B", address.Address2);
		Assert.AreEqual("Anytown", address.City);
		Assert.AreEqual("USA", address.Country);
		Assert.AreEqual("12345", address.PostalCode);
		Assert.AreEqual("AnyCounty", address.CountyProvince);
		Assert.AreEqual("CA", address.State);
		Assert.AreEqual("555-1234", address.Phone);
	}

	[TestMethod]
	public void Create_AllParams_OptionalDefaultsToEmpty()
	{
		var address = Address.Create("1234567890", "123 Main St", "Anytown", "USA", "12345");

		Assert.AreEqual(string.Empty, address.Address2);
		Assert.AreEqual(string.Empty, address.CountyProvince);
		Assert.AreEqual(string.Empty, address.State);
		Assert.AreEqual(string.Empty, address.Phone);
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
		var record = new DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord("1234567890");

		var valueType = (Address)record;

		Assert.AreEqual(record.Id, valueType.Id);
	}

	[TestMethod]
	public void Operator_Explicit_From_RefTypeAddress_Works()
	{
		var refType = DotNetTips.Spargine.Tester.Models.RefTypes.Address.Create("1234567890", "A1", "City", "Country", "12345");

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
	public void Phone_SetNull_ConvertsToEmpty()
	{
		var address = RandomData.GenerateAddress<Address>();

		address.Phone = null;

		Assert.AreEqual(string.Empty, address.Phone);
	}

	[TestMethod]
	public void Phone_SetSameValue_NoOp()
	{
		var address = Address.Create("1234567890");
		address.Phone = "555-1234";

		address.Phone = "555-1234";

		Assert.AreEqual("555-1234", address.Phone);
	}

	[TestMethod]
	public void Phone_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.Phone = new string('a', 51));
	}

	[TestMethod]
	public void PostalCode_SetNull_ConvertsToEmpty()
	{
		var address = RandomData.GenerateAddress<Address>();

		address.PostalCode = null;

		Assert.AreEqual(string.Empty, address.PostalCode);
	}

	[TestMethod]
	public void PostalCode_SetSameValue_NoOp()
	{
		var address = Address.Create("1234567890");
		address.PostalCode = "12345";

		address.PostalCode = "12345";

		Assert.AreEqual("12345", address.PostalCode);
	}

	[TestMethod]
	public void PostalCode_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.PostalCode = new string('a', 26));
	}

	[TestMethod]
	public void State_SetNull_ConvertsToEmpty()
	{
		var address = RandomData.GenerateAddress<Address>();

		address.State = null;

		Assert.AreEqual(string.Empty, address.State);
	}

	[TestMethod]
	public void State_SetSameValue_NoOp()
	{
		var address = Address.Create("1234567890");
		address.State = "California";

		address.State = "california";

		Assert.AreEqual("California", address.State);
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
