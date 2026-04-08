// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-29-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="AddressRefTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Models.RefTypes;

[ExcludeFromCodeCoverage]
[TestClass]
public class AddressRefTests
{

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
	public void Address1_SetValid_ReturnsValue()
	{
		var address = Address.Create("1234567890");

		address.Address1 = "123 Main St";

		Assert.AreEqual("123 Main St", address.Address1);
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
	public void Address2_SetValid_ReturnsValue()
	{
		var address = Address.Create("1234567890");

		address.Address2 = "Apt 4B";

		Assert.AreEqual("Apt 4B", address.Address2);
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
	public void City_SetValid_ReturnsValue()
	{
		var address = Address.Create("1234567890");

		address.City = "Anytown";

		Assert.AreEqual("Anytown", address.City);
	}

	[TestMethod]
	public void City_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.City = new string('a', 101));
	}

	[TestMethod]
	public void Clone()
	{
		var address = RandomData.GenerateAddress<Address>();

		var clonedAddresses = address.FastClone<Address>();

		Assert.IsNotNull(clonedAddresses);
	}

	[TestMethod]
	public void CompareTo_DifferentId_ReturnsNonZero()
	{
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		var result = address1.CompareTo(address2);

		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_NullAddress_ReturnsPositive()
	{
		var address = RandomData.GenerateAddress<Address>();

		var result = address.CompareTo(null);

		Assert.IsGreaterThan(0, result);
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
		var address = RandomData.GenerateAddress<Address>();

		Assert.ThrowsExactly<ArgumentException>(() => ((IComparable)address).CompareTo("not an address"));
	}

	[TestMethod]
	public void CompareTo_Object_ValidAddress_ReturnsExpected()
	{
		var address1 = Address.Create("1234567890");
		var address2 = Address.Create("1234567890");

		var result = ((IComparable)address1).CompareTo(address2);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_SameId_ReturnsZero()
	{
		var address1 = Address.Create("1234567890");
		var address2 = Address.Create("1234567890");

		var result = address1.CompareTo(address2);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Constructor_Id_SetsId()
	{
		var id = "1234567890";

		var address = new Address(id);

		Assert.AreEqual(id, address.Id);
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
	public void Country_SetValid_ReturnsValue()
	{
		var address = Address.Create("1234567890");

		address.Country = "USA";

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
	public void CountyProvince_SetValid_ReturnsValue()
	{
		var address = Address.Create("1234567890");

		address.CountyProvince = "AnyCounty";

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

		Assert.IsNotNull(address);
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
	public void Create_Id_CreatesAddress()
	{
		var address = Address.Create("1234567890");

		Assert.IsNotNull(address);
		Assert.AreEqual("1234567890", address.Id);
	}

	[TestMethod]
	public void Equals_DifferentId_ReturnsFalse()
	{
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		Assert.IsFalse(address1.Equals(address2));
	}

	[TestMethod]
	public void Equals_Null_ReturnsFalse()
	{
		var address = RandomData.GenerateAddress<Address>();

		Assert.IsFalse(address.Equals(null));
	}

	[TestMethod]
	public void Equals_Object_DifferentType_ReturnsFalse()
	{
		var address = RandomData.GenerateAddress<Address>();

		Assert.IsFalse(address.Equals("not an address"));
	}

	[TestMethod]
	public void Equals_Object_Null_ReturnsFalse()
	{
		var address = RandomData.GenerateAddress<Address>();

		Assert.IsFalse(address.Equals((object)null));
	}

	[TestMethod]
	public void Equals_Object_SameReference_ReturnsTrue()
	{
		var address = RandomData.GenerateAddress<Address>();

		Assert.IsTrue(address.Equals((object)address));
	}

	[TestMethod]
	public void Equals_SameId_ReturnsTrue()
	{
		var address1 = Address.Create("1234567890");
		var address2 = Address.Create("1234567890");

		Assert.IsTrue(address1.Equals(address2));
	}

	[TestMethod]
	public void Equals_SameReference_ReturnsTrue()
	{
		var address = RandomData.GenerateAddress<Address>();

		Assert.IsTrue(address.Equals(address));
	}

	[TestMethod]
	public void GetHashCode_DifferentId_ReturnsDifferent()
	{
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		Assert.AreNotEqual(address1.GetHashCode(), address2.GetHashCode());
	}

	[TestMethod]
	public void GetHashCode_SameId_ReturnsSame()
	{
		var address1 = Address.Create("1234567890");
		var address2 = Address.Create("1234567890");

		Assert.AreEqual(address1.GetHashCode(), address2.GetHashCode());
	}

	[TestMethod]
	public void Id_ThrowsOnTooLong()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Address(new string('a', 51)));
	}

	[TestMethod]
	public void Id_ThrowsOnTooShort()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Address("short"));
	}

	[TestMethod]
	public void ImplicitOperator_FromAddressRecord_ConvertsCorrectly()
	{
		var record = new AddressRecord("1234567890") { Address1 = "A1", City = "City", Country = "Country", PostalCode = "12345" };

		Address address = record;

		Assert.AreEqual(record.Id, address.Id);
		Assert.AreEqual(record.Address1, address.Address1);
		Assert.AreEqual(record.City, address.City);
	}

	[TestMethod]
	public void ImplicitOperator_FromValueTypeAddress_ConvertsCorrectly()
	{
		var valAddress = DotNetTips.Spargine.Tester.Models.ValueTypes.Address.Create("1234567890", "A1", "City", "Country", "12345");

		Address address = valAddress;

		Assert.AreEqual(valAddress.Id, address.Id);
		Assert.AreEqual(valAddress.Address1, address.Address1);
		Assert.AreEqual(valAddress.City, address.City);
	}

	[TestMethod]
	public void Operator_Equality_SameId_ReturnsTrue()
	{
		var address1 = Address.Create("1234567890");
		var address2 = Address.Create("1234567890");

		Assert.IsTrue(address1 == address2);
	}

	[TestMethod]
	public void Operator_GreaterThan_And_LessThan()
	{
		var a1 = Address.Create("1234567890");
		var a2 = Address.Create("ABCDEFGHIJ");

		Assert.IsTrue(a1 < a2 || a2 < a1 || a1 == a2);
		Assert.IsTrue(a1 > a2 || a2 > a1 || a1 == a2);
	}

	[TestMethod]
	public void Operator_GreaterThan_LeftNull_ReturnsFalse()
	{
		var address = Address.Create("1234567890");

		Assert.IsFalse(null > address);
	}

	[TestMethod]
	public void Operator_GreaterThan_RightNull_ReturnsTrue()
	{
		var address = Address.Create("1234567890");

		Assert.IsTrue(address > null);
	}

	[TestMethod]
	public void Operator_GreaterThanOrEqual_And_LessThanOrEqual()
	{
		var a1 = Address.Create("1234567890");
		var a2 = Address.Create("ABCDEFGHIJ");

		Assert.IsTrue(a1 <= a2 || a2 <= a1);
		Assert.IsTrue(a1 >= a2 || a2 >= a1);
	}

	[TestMethod]
	public void Operator_GreaterThanOrEqual_RightNull_ReturnsTrue()
	{
		var address = Address.Create("1234567890");

		Assert.IsTrue(address >= null);
	}

	[TestMethod]
	public void Operator_Inequality_DifferentId_ReturnsTrue()
	{
		var address1 = RandomData.GenerateAddress<Address>();
		var address2 = RandomData.GenerateAddress<Address>();

		Assert.IsTrue(address1 != address2);
	}

	[TestMethod]
	public void Operator_LessThan_LeftNull_ReturnsTrue()
	{
		var address = Address.Create("1234567890");

		Assert.IsTrue(null < address);
	}

	[TestMethod]
	public void Operator_LessThanOrEqual_LeftNull_ReturnsTrue()
	{
		var address = Address.Create("1234567890");

		Assert.IsTrue(null <= address);
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
	public void Phone_SetValid_ReturnsValue()
	{
		var address = Address.Create("1234567890");

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
	public void PostalCode_SetValid_ReturnsValue()
	{
		var address = Address.Create("1234567890");

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
	public void Properties_SetAndGet_AllValues()
	{
		var address = new Address("1234567890");

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
	public void State_SetValid_ReturnsValue()
	{
		var address = Address.Create("1234567890");

		address.State = "CA";

		Assert.AreEqual("CA", address.State);
	}

	[TestMethod]
	public void State_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.State = new string('a', 100));
	}

	[TestMethod]
	public void ToAddress_FromAddressRecord_ConvertsCorrectly()
	{
		var record = RandomData.GenerateAddress<AddressRecord>();

		var address = Address.ToAddress(record);

		Assert.IsNotNull(address);
		Assert.AreEqual(record.Id, address.Id);
		Assert.AreEqual(record.Address1, address.Address1);
		Assert.AreEqual(record.Address2, address.Address2);
		Assert.AreEqual(record.City, address.City);
		Assert.AreEqual(record.Country, address.Country);
		Assert.AreEqual(record.CountyProvince, address.CountyProvince);
		Assert.AreEqual(record.Phone, address.Phone);
		Assert.AreEqual(record.PostalCode, address.PostalCode);
		Assert.AreEqual(record.State, address.State);
	}

	[TestMethod]
	public void ToAddress_FromValueTypeAddress_ConvertsCorrectly()
	{
		var valAddress = RandomData.GenerateAddress<DotNetTips.Spargine.Tester.Models.ValueTypes.Address>();

		var address = Address.ToAddress(valAddress);

		Assert.IsNotNull(address);
		Assert.AreEqual(valAddress.Id, address.Id);
		Assert.AreEqual(valAddress.Address1, address.Address1);
		Assert.AreEqual(valAddress.Address2, address.Address2);
		Assert.AreEqual(valAddress.City, address.City);
		Assert.AreEqual(valAddress.Country, address.Country);
		Assert.AreEqual(valAddress.CountyProvince, address.CountyProvince);
		Assert.AreEqual(valAddress.Phone, address.Phone);
		Assert.AreEqual(valAddress.PostalCode, address.PostalCode);
		Assert.AreEqual(valAddress.State, address.State);
	}

	[TestMethod]
	public void ToString_ReturnsNonEmptyString()
	{
		var address = RandomData.GenerateAddress<Address>();

		var result = address.ToString();

		Assert.IsFalse(string.IsNullOrWhiteSpace(result));
		Assert.Contains("Address1", result);
	}
}
