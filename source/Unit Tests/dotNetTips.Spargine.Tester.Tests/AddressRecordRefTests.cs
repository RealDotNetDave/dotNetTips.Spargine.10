// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="AddressRecordRefTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AddressRecordRefTests
{

	[TestMethod]
	public void Address1_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new AddressRecord("1234567890") { Address1 = new string('a', 101) });
	}

	[TestMethod]
	public void Address2_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new AddressRecord("1234567890") { Address2 = new string('a', 101) });
	}

	[TestMethod]
	public void AddressRecord_Constructor_NullId_ThrowsArgumentNullException()
	{
		// Arrange
		var address1 = "123 Main St";
		var address2 = "Apt 4B";
		var city = "Anytown";
		var state = "CA";
		var countyProvince = "AnyCounty";
		var country = "USA";
		var postalCode = "12345";
		var phone = "555-1234";

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new AddressRecord(null, address1, address2, city, state, countyProvince, country, postalCode, phone));
	}

	[TestMethod]
	public void AddressRecord_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var id = "1229282723";
		var address1 = "123 Main St";
		var address2 = "Apt 4B";
		var city = "Anytown";
		var state = "CA";
		var countyProvince = "AnyCounty";
		var country = "USA";
		var postalCode = "12345";
		var phone = "555-1234";

		// Act
		var addressRecord = new AddressRecord(id, address1, address2, city, state, countyProvince, country, postalCode, phone);

		// Assert
		Assert.IsNotNull(addressRecord);
		Assert.AreEqual(id, addressRecord.Id);
		Assert.AreEqual(address1, addressRecord.Address1);
		Assert.AreEqual(address2, addressRecord.Address2);
		Assert.AreEqual(city, addressRecord.City);
		Assert.AreEqual(state, addressRecord.State);
		Assert.AreEqual(countyProvince, addressRecord.CountyProvince);
		Assert.AreEqual(country, addressRecord.Country);
		Assert.AreEqual(postalCode, addressRecord.PostalCode);
		Assert.AreEqual(phone, addressRecord.Phone);
	}

	[TestMethod]
	public void AddressRecord_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("12292827234", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = addressRecord1.Equals(addressRecord2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AddressRecord_Equals_SameValues_ReturnsTrue()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var result = addressRecord1.Equals(addressRecord2);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void AddressRecord_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("12292827234", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var hashCode1 = addressRecord1.GetHashCode();
		var hashCode2 = addressRecord2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void AddressRecord_GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var hashCode1 = addressRecord1.GetHashCode();
		var hashCode2 = addressRecord2.GetHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void AddressRecord_OperatorEquals_SameValues_ReturnsTrue()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var result = addressRecord1 == addressRecord2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void AddressRecord_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var addressRecord1 = new AddressRecord("12279282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");
		var addressRecord2 = new AddressRecord("1229282723", "124 Main St", "Apt 5B", "Othertown", "NY", "OtherCounty", "CAN", "54321", "555-4321");

		// Act
		var result = addressRecord1 != addressRecord2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void AddressRecord_Properties_SetAndGetValues()
	{
		// Arrange
		var addressRecord = new AddressRecord("1229282723");
		var address1 = "123 Main St";
		var address2 = "Apt 4B";
		var city = "Anytown";
		var state = "CA";
		var countyProvince = "AnyCounty";
		var country = "USA";
		var postalCode = "12345";
		var phone = "555-1234";

		// Act
		addressRecord = addressRecord with
		{
			Address1 = address1,
			Address2 = address2,
			City = city,
			State = state,
			CountyProvince = countyProvince,
			Country = country,
			PostalCode = postalCode,
			Phone = phone
		};

		// Assert
		Assert.AreEqual(address1, addressRecord.Address1);
		Assert.AreEqual(address2, addressRecord.Address2);
		Assert.AreEqual(city, addressRecord.City);
		Assert.AreEqual(state, addressRecord.State);
		Assert.AreEqual(countyProvince, addressRecord.CountyProvince);
		Assert.AreEqual(country, addressRecord.Country);
		Assert.AreEqual(postalCode, addressRecord.PostalCode);
		Assert.AreEqual(phone, addressRecord.Phone);
	}

	[TestMethod]
	public void AddressRecord_ToAddress_ConvertsFromAddress()
	{
		// Arrange
		var address = RandomData.GenerateAddress<Address>();

		// Act
		var addressRecord = AddressRecord.ToAddress(address);

		// Assert
		Assert.IsNotNull(addressRecord);
		Assert.AreEqual(address.Id, addressRecord.Id);
		Assert.AreEqual(address.Address1, addressRecord.Address1);
		Assert.AreEqual(address.Address2, addressRecord.Address2);
		Assert.AreEqual(address.City, addressRecord.City);
		Assert.AreEqual(address.State, addressRecord.State);
		Assert.AreEqual(address.CountyProvince, addressRecord.CountyProvince);
		Assert.AreEqual(address.Country, addressRecord.Country);
		Assert.AreEqual(address.PostalCode, addressRecord.PostalCode);
		Assert.AreEqual(address.Phone, addressRecord.Phone);
	}

	[TestMethod]
	public void AddressRecord_ToAddress_ConvertsFromValueTypesAddress()
	{
		// Arrange
		var address = RandomData.GenerateAddress<Models.ValueTypes.Address>();

		// Act
		var addressRecord = AddressRecord.ToAddress(address);

		// Assert
		Assert.IsNotNull(addressRecord);
		Assert.AreEqual(address.Id, addressRecord.Id);
		Assert.AreEqual(address.Address1, addressRecord.Address1);
		Assert.AreEqual(address.Address2, addressRecord.Address2);
		Assert.AreEqual(address.City, addressRecord.City);
		Assert.AreEqual(address.State, addressRecord.State);
		Assert.AreEqual(address.CountyProvince, addressRecord.CountyProvince);
		Assert.AreEqual(address.Country, addressRecord.Country);
		Assert.AreEqual(address.PostalCode, addressRecord.PostalCode);
		Assert.AreEqual(address.Phone, addressRecord.Phone);
	}

	[TestMethod]
	public void City_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new AddressRecord("1234567890") { City = new string('a', 101) });
	}

	[TestMethod]
	public void Clone()
	{
		// Arrange
		var address = RandomData.GenerateAddress<AddressRecord>();

		// Act
		var clonedAddresses = address.FastClone<AddressRecord>();

		// Assert
		Assert.IsNotNull(clonedAddresses);
	}

	[TestMethod]
	public void CompareTo_Object_ThrowsOnInvalidType()
	{
		var record = AddressRecord.Create("1234567890");
		Assert.ThrowsExactly<ArgumentException>(() => ((IComparable)record).CompareTo("not an address record"));
	}

	[TestMethod]
	public void Country_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new AddressRecord("1234567890") { Country = new string('a', 56) });
	}

	[TestMethod]
	public void CountyProvince_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new AddressRecord("1234567890") { CountyProvince = new string('a', 61) });
	}

	[TestMethod]
	public void Id_InitOnly_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new AddressRecord("short"));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new AddressRecord(new string('a', 51)));
	}

	[TestMethod]
	public void Operator_Explicit_From_Address_Works()
	{
		var address = Address.Create("1234567890", "A1", "City", "Country", "12345");
		var record = (AddressRecord)address;
		Assert.AreEqual(address.Id, record.Id);
		Assert.AreEqual(address.Address1, record.Address1);
	}

	[TestMethod]
	public void Phone_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new AddressRecord("1234567890") { Phone = new string('a', 51) });
	}

	[TestMethod]
	public void PostalCode_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new AddressRecord("1234567890") { PostalCode = new string('a', 26) });
	}

	[TestMethod]
	public void State_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new AddressRecord("1234567890") { State = new string('a', 100) });
	}

	[TestMethod]
	public void ToString_ReturnsDebugString()
	{
		var record = AddressRecord.Create("1234567890", "A1", "City", "Country", "12345");
		var str = record.ToString();
		Assert.IsFalse(string.IsNullOrWhiteSpace(str));
		Assert.IsTrue(str.Contains("Address1"));
	}
	[TestMethod]
	public void ToString_Test()
	{
		// Arrange
		var addressRecord = new AddressRecord("1229282723", "123 Main St", "Apt 4B", "Anytown", "CA", "AnyCounty", "USA", "12345", "555-1234");

		// Act
		var result = addressRecord.ToString();

		// Assert
		Assert.IsNotNull(result);
	}

}
