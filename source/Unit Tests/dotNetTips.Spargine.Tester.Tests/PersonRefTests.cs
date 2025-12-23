// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="PersonRefTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonRefTests
{

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
	public void Addresses_SetSameCollection_DoesNotChange()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var addresses = new Collection<Address> { new Address("149483736633") };
		person.Addresses = addresses;

		// Act
		person.Addresses = addresses;

		// Assert
		Assert.AreEqual(1, person.Addresses.Count);
	}

	[TestMethod]
	public void BornOn_SetFutureDate_Throws()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var future = DateTimeOffset.UtcNow.AddDays(1);

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.BornOn = future);
	}

	[TestMethod]
	public void BornOn_SetSameValue_DoesNotThrow()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var date = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);
		person.BornOn = date;

		// Act & Assert
		person.BornOn = date;
		Assert.AreEqual(date, person.BornOn);
	}

	[TestMethod]
	public void CellPhone_SetSameValue_DoesNotThrow()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var phone = "555-1234";
		person.CellPhone = phone;

		// Act & Assert
		person.CellPhone = phone;
		Assert.AreEqual(phone, person.CellPhone);
	}

	[TestMethod]
	public void CellPhone_SetTooLong_Throws()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var phone = new string('1', 51);

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.CellPhone = phone);
	}

	[TestMethod]
	public void City_ThrowsOnInvalidLength()
	{
		var address = Address.Create("1234567890");
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.City = new string('a', 101));
	}

	[TestMethod]
	public void ClonePeople()
	{
		// Arrange  
		var people = RandomData.GeneratePersonRefCollection(10);

		// Act  
		var clonedPeople = people.FastClone<Collection<Person>>();

		// Assert  
		Assert.IsNotNull(clonedPeople);
	}

	[TestMethod]
	public void CompareTo_DifferentId_ReturnsNonZero()
	{
		// Arrange
		var person1 = new Person("test1@example.com", "1229282723");
		var person2 = new Person("test2@example.com", "12292827234");
		// Act
		var result = person1.CompareTo(person2);

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
	public void CompareTo_OtherWithGreaterId_ReturnsNegative()
	{
		var person = new Person(email: "test@example.com", id: "1234567890");
		var other = new Person(email: "other@example.com", id: "1234567891");
		var result = person.CompareTo(other);
		Assert.IsTrue(result < 0);
	}

	[TestMethod]
	public void CompareTo_OtherWithLowerId_ReturnsPositive()
	{
		var person = new Person(email: "test@example.com", id: "1234567891");
		var other = new Person(email: "other@example.com", id: "1234567890");
		var result = person.CompareTo(other);
		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void CompareTo_OtherWithSameId_ReturnsZero()
	{
		var person = new Person(email: "test@example.com", id: "1234567890");
		var other = new Person(email: "other@example.com", id: "1234567890");
		var result = person.CompareTo(other);
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_SameId_ReturnsZero()
	{
		// Arrange
		var person1 = new Person("test1@example.com", "1229282723");
		var person2 = new Person("test2@example.com", "1229282723");

		// Act
		var result = person1.CompareTo(person2);

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
	public void Email_InitOnly_ThrowsOnNullOrEmptyOrInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => new Person(null!, "1234567890"));
		Assert.ThrowsExactly<ArgumentNullException>(() => new Person(string.Empty, "1234567890"));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Person(new string('a', 76), "1234567890"));
	}

	[TestMethod]
	public void Equals_Object_DifferentType_ReturnsFalse()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var notPerson = "not a person";

		// Act
		var result = person.Equals(notPerson);

		// Assert
		Assert.IsFalse(result);
	}


	[TestMethod]
	public void Equals_Object_SameReference_ReturnsTrue()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");

		// Act
		var result = person.Equals((object)person);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FirstName_SetSameValue_DoesNotThrow()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var name = "John";
		person.FirstName = name;

		// Act & Assert
		person.FirstName = name;
		Assert.AreEqual(name, person.FirstName);
	}

	[TestMethod]
	public void FirstName_SetTooLong_Throws()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var name = new string('a', 51);

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.FirstName = name);
	}

	[TestMethod]
	public void Id_InitOnly_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Address("short"));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Address(new string('a', 51)));
	}

	[TestMethod]
	public void Id_InitOnly_ThrowsOnInvalidLength_Person()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Person("email@email.com", "short"));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Person("email@email.com", new string('a', 51)));
	}

	[TestMethod]
	public void LastName_SetSameValue_DoesNotThrow()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var name = "Doe";
		person.LastName = name;

		// Act & Assert
		person.LastName = name;
		Assert.AreEqual(name, person.LastName);
	}

	[TestMethod]
	public void LastName_SetTooLong_Throws()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var name = new string('a', 51);

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.LastName = name);
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
		Assert.IsTrue((Address)null == (Address)null);
		Assert.IsFalse((Address)null != (Address)null);
	}

	[TestMethod]
	public void Operator_LessThan_LessThanOrEqual_GreaterThan_GreaterThanOrEqual()
	{
		var a1 = Address.Create("1234567890");
		var a2 = Address.Create("ABCDEFGHIJ");
		Assert.IsTrue(a1 < a2 || a2 < a1 || a1 == a2); // At least one comparison is true
		Assert.IsTrue(a1 <= a2 || a2 <= a1);
		Assert.IsTrue(a1 > a2 || a2 > a1 || a1 == a2);
		Assert.IsTrue(a1 >= a2 || a2 >= a1);
		Assert.IsFalse(a1 < null);
		Assert.IsTrue(a1 > null);
		Assert.IsTrue((Address)null < a1);
		Assert.IsFalse((Address)null > a1);
	}

	[TestMethod]
	public void OperatorEquals_BothNull_ReturnsTrue()
	{
		// Arrange
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
		Person person1 = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
		Person person2 = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

		// Act
#pragma warning disable CS8604 // Possible null reference argument.
		var result = person1 == person2;
#pragma warning restore CS8604 // Possible null reference argument.

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void OperatorEquals_SameReference_ReturnsTrue()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");

		// Act
#pragma warning disable CS1718 // Comparison made to same variable
		var result = person == person;
#pragma warning restore CS1718 // Comparison made to same variable

		// Assert
		Assert.IsTrue(result);
	}


	[TestMethod]
	public void Person_CompareTo_ValidPerson_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new Person("test1@example.com", "1229282723");
		var person2 = new Person("test1@example.com", "1229282723");
		var person3 = new Person("test2@example.com", "12292827234");

		// Act & Assert
		Assert.AreEqual(0, person1.CompareTo(person2));
		Assert.IsTrue(person1.CompareTo(person3) < 0);
		Assert.IsTrue(person3.CompareTo(person1) > 0);
	}

	[TestMethod]
	public void Person_ComparisonOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new Person("test1@example.com", "1229282723");
		var person2 = new Person("test1@example.com", "1229282723");
		var person3 = new Person("test2@example.com", "12292827234");

		// Act & Assert
		Assert.IsTrue(person1 <= person2);
		Assert.IsTrue(person1 >= person2);
		Assert.IsTrue(person1 < person3);
		Assert.IsTrue(person3 > person1);
	}

	[TestMethod]
	public void Person_Constructor_NullEmail_ThrowsArgumentNullException()
	{
		// Arrange
		var id = "1229282723";

		// Act

		Assert.ThrowsExactly<ArgumentNullException>(() => new Person(null, id));
	}

	[TestMethod]
	public void Person_Constructor_NullId_ThrowsArgumentNullException()
	{
		// Arrange
		var email = "test@example.com";

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => _ = new Person(email, null));
	}

	[TestMethod]
	public void Person_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var id = "1229282723";
		var email = "test@example.com";

		// Act
		var person = new Person(email, id);

		// Assert
		Assert.AreEqual(id, person.Id);
		Assert.AreEqual(email, person.Email);
	}

	[TestMethod]
	public void Person_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var email = "test@example.com";
		var id = "1229282723";

		// Act
		var person = new Person(email, id);

		// Assert
		Assert.IsNotNull(person);
		Assert.AreEqual(email, person.Email);
		Assert.AreEqual(id, person.Id);
	}

	[TestMethod]
	public void Person_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var person1 = new Person("test1@example.com", "1229282723");
		var person2 = new Person("test2@example.com", "12292827234");

		// Act
		var result = person1.Equals(person2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Person_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var person1 = new Person("test1@example.com", "1229282723");
		var person2 = new Person("test2@example.com", "12292827234");

		// Act
		var hashCode1 = person1.GetHashCode();
		var hashCode2 = person2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Person_GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var person1 = new Person("test@example.com", "1229282723");
		var person2 = new Person("test@example.com", "1229282723");

		// Act
		var hashCode1 = person1.GetHashCode();
		var hashCode2 = person2.GetHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Person_GetHashCode_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new Person("test1@example.com", "1229282723");
		var person2 = new Person("test1@example.com", "1229282723");
		var person3 = new Person("test2@example.com", "12292827234");

		// Act & Assert
		Assert.AreEqual(person1.GetHashCode(), person2.GetHashCode());
		Assert.AreNotEqual(person1.GetHashCode(), person3.GetHashCode());
	}

	[TestMethod]
	public void Person_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var person1 = new Person("test1@example.com", "1229282723");
		var person2 = new Person("test2@example.com", "12292827234");

		// Act
		var result = person1 != person2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Person_ToPerson_FromPersonRecord_ShouldReturnExpectedResults()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "1229282723")
		{
			FirstName = "John",
			LastName = "Doe",
			BornOn = new DateTimeOffset(new DateTime(1990, 1, 1)),
			CellPhone = "555-1234",
			Phone = "555-5678",
			Addresses = new Collection<AddressRecord> { new AddressRecord("1229282723") }
		};

		// Act
		var person = Person.ToPerson(personRecord);

		// Assert
		Assert.AreEqual(personRecord.Id, person.Id);
		Assert.AreEqual(personRecord.Email, person.Email);
		Assert.AreEqual(personRecord.FirstName, person.FirstName);
		Assert.AreEqual(personRecord.LastName, person.LastName);
		Assert.AreEqual(personRecord.BornOn, person.BornOn);
		Assert.AreEqual(personRecord.CellPhone, person.CellPhone);
		Assert.AreEqual(personRecord.Phone, person.Phone);
		Assert.AreEqual(personRecord.Addresses.Count, person.Addresses.Count);
	}

	[TestMethod]
	public void Person_ToPerson_FromValueTypesPerson_ShouldReturnExpectedResults()
	{
		// Arrange
		var valueTypesPerson = new Models.ValueTypes.Person("test@example.com", "149483736633")
		{
			FirstName = "John",
			LastName = "Doe",
			BornOn = new DateTimeOffset(new DateTime(1990, 1, 1)),
			CellPhone = "555-1234",
			Phone = "555-5678",
			Addresses = new Collection<Models.ValueTypes.Address> { new Models.ValueTypes.Address("149483736633") }
		};

		// Act
		var person = Person.ToPerson(valueTypesPerson);

		// Assert
		Assert.AreEqual(valueTypesPerson.Id, person.Id);
		Assert.AreEqual(valueTypesPerson.Email, person.Email);
		Assert.AreEqual(valueTypesPerson.FirstName, person.FirstName);
		Assert.AreEqual(valueTypesPerson.LastName, person.LastName);
		Assert.AreEqual(valueTypesPerson.BornOn, person.BornOn);
		Assert.AreEqual(valueTypesPerson.CellPhone, person.CellPhone);
		Assert.AreEqual(valueTypesPerson.Phone, person.Phone);
		Assert.AreEqual(valueTypesPerson.Addresses.Count, person.Addresses.Count);
	}


	[TestMethod]
	public void Person_ToString_ReturnsCorrectString()
	{
		// Arrange
		var person = new Person("test@example.com", "1229282723");
		person.BornOn = new DateTimeOffset(new DateTime(1990, 1, 1));
		person.FirstName = "John";
		person.LastName = "Doe";
		person.CellPhone = "555-1234";
		person.Phone = "555-5678";

		var expectedString = person.PropertiesToString(includeMemberName: false);

		// Act
		var result = person.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Person_ToString_ShouldReturnExpectedResults()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var expectedString = "Email:test@example.com, Id:149483736633";

		// Act
		var result = person.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Phone_SetSameValue_DoesNotThrow()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var phone = "555-5678";
		person.Phone = phone;

		// Act & Assert
		person.Phone = phone;
		Assert.AreEqual(phone, person.Phone);
	}

	[TestMethod]
	public void Phone_SetTooLong_Throws()
	{
		// Arrange
		var person = new Person("test@example.com", "149483736633");
		var phone = new string('1', 51);

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.Phone = phone);
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
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => address.State = new string('a', 66));
	}

	[TestMethod]
	public void ToString_ReturnsDebugString()
	{
		var address = Address.Create("1234567890", "A1", "City", "Country", "12345");
		var str = address.ToString();
		Assert.IsFalse(string.IsNullOrWhiteSpace(str));
		Assert.IsTrue(str.Contains("Address1"));
	}
}
