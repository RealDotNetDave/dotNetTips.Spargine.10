// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="PersonValTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Models.ValueTypes;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonValTests
{

	[TestMethod]
	public void Addresses_SetNewCollection_CopiesValues()
	{
		var person = RandomData.GeneratePerson<Person>();
		var addresses = new Collection<Address> { RandomData.GenerateAddress<Address>() };

		person.Addresses = addresses;

		Assert.HasCount(1, person.Addresses);
	}

	[TestMethod]
	public void Addresses_SetNull_ResetsToEmpty()
	{
		var person = RandomData.GeneratePerson<Person>();
		person.Addresses = new Collection<Address> { RandomData.GenerateAddress<Address>() };

		person.Addresses = null;

		Assert.HasCount(0, person.Addresses);
	}

	[TestMethod]
	public void Addresses_SetSameCollection_DoesNotChange()
	{
		var person = new Person("test@example.com", "1229282723");
		var addresses = new Collection<Address> { new Address("1229282723") };
		person.Addresses = addresses;

		person.Addresses = addresses;

		Assert.HasCount(1, person.Addresses);
	}

	[TestMethod]
	public void AddressesSerialization_ReturnsCopy()
	{
		var person = RandomData.GeneratePerson<Person>();
		var addresses = new Collection<Address> { RandomData.GenerateAddress<Address>() };
		person.Addresses = addresses;

		var serialization = person.AddressesSerialization;

		Assert.HasCount(1, serialization);
	}

	[TestMethod]
	public void BornOn_SetFutureDate_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var futureDate = DateTimeOffset.UtcNow.AddDays(1);
		var person = new Person("test@example.com", "1229282723");

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.BornOn = futureDate);
	}

	[TestMethod]
	public void BornOn_SetPastDate_SetsCorrectly()
	{
		// Arrange
		var pastDate = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);
		var person = new Person("test@example.com", "1229282723");

		// Act
		person.BornOn = pastDate;

		// Assert
		Assert.AreEqual(pastDate, person.BornOn);
	}

	[TestMethod]
	public void BornOn_SetSameValue_DoesNotChange()
	{
		var person = new Person("test@example.com", "1229282723");
		var date = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);
		person.BornOn = date;

		person.BornOn = date;

		Assert.AreEqual(date, person.BornOn);
	}

	[TestMethod]
	public void CellPhone_SetNull_ConvertsToEmpty()
	{
		var person = RandomData.GeneratePerson<Person>();

		person.CellPhone = null;

		Assert.AreEqual(string.Empty, person.CellPhone);
	}

	[TestMethod]
	public void CellPhone_SetSameValue_DoesNotThrow()
	{
		var person = new Person("test@example.com", "1229282723");
		person.CellPhone = "555-1234";

		person.CellPhone = "555-1234";

		Assert.AreEqual("555-1234", person.CellPhone);
	}

	[TestMethod]
	public void CellPhone_SetTooLong_Throws()
	{
		var person = new Person("test@example.com", "1229282723");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.CellPhone = new string('1', 51));
	}

	[TestMethod]
	public void CellPhone_SetValid_SetsCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();

		person.CellPhone = "555-9876";

		Assert.AreEqual("555-9876", person.CellPhone);
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
	public void CompareTo_Object_Null_ReturnsPositive()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = ((IComparable)person).CompareTo(null);

		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void CompareTo_Object_ThrowsOnInvalidType()
	{
		var person = RandomData.GeneratePerson<Person>();

		Assert.ThrowsExactly<ArgumentException>(() => ((IComparable)person).CompareTo("not a person"));
	}

	[TestMethod]
	public void CompareTo_Object_ValidPerson_ReturnsZero()
	{
		var person1 = new Person("test@example.com", "1234567890");
		var person2 = new Person("other@example.com", "1234567890");

		var result = ((IComparable)person1).CompareTo(person2);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void CompareTo_OtherWithGreaterId_ReturnsNegative()
	{
		var person = new Person(email: "test@example.com", id: "1234567890");
		var other = new Person(email: "other@example.com", id: "1234567891");
		var result = person.CompareTo(other);
		Assert.IsLessThan(0, result);
	}

	[TestMethod]
	public void CompareTo_OtherWithLowerId_ReturnsPositive()
	{
		var person = new Person(email: "test@example.com", id: "1234567891");
		var other = new Person(email: "other@example.com", id: "1234567890");
		var result = person.CompareTo(other);
		Assert.IsGreaterThan(0, result);
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
	public void Create_ValidParameters_ReturnsPersonWithAllProperties()
	{
		var id = "1234567890";
		var email = "test@example.com";
		var firstName = "John";
		var lastName = "Doe";
		var bornOn = new DateTimeOffset(1990, 1, 1, 0, 0, 0, TimeSpan.Zero);
		var addresses = new Collection<Address> { RandomData.GenerateAddress<Address>() };
		var cellPhone = "555-1234";
		var phone = "555-5678";

		var person = Person.Create(id, email, firstName, lastName, bornOn, addresses, cellPhone, phone);

		Assert.AreEqual(id, person.Id);
		Assert.AreEqual(email, person.Email);
		Assert.AreEqual(firstName, person.FirstName);
		Assert.AreEqual(lastName, person.LastName);
		Assert.AreEqual(bornOn, person.BornOn);
		Assert.HasCount(1, person.Addresses);
		Assert.AreEqual(cellPhone, person.CellPhone);
		Assert.AreEqual(phone, person.Phone);
	}

	[TestMethod]
	public void Create_WithNullOptionalParams_UsesDefaults()
	{
		var person = Person.Create("1234567890", "test@example.com", "John", "Doe", null);

		Assert.IsNull(person.BornOn);
		Assert.HasCount(0, person.Addresses);
		Assert.AreEqual(string.Empty, person.CellPhone);
		Assert.AreEqual(string.Empty, person.Phone);
	}

	[TestMethod]
	public void Email_InitOnly_ThrowsOnNullOrEmpty()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => new Person(null, "1229282723"));
	}

	[TestMethod]
	public void Email_TooShort_ThrowsArgumentOutOfRangeException()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Person("a@b.c", "1234567890"));
	}

	[TestMethod]
	public void Equals_Object_DifferentType_ReturnsFalse()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = person.Equals("not a person");

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Equals_Object_SamePerson_ReturnsTrue()
	{
		var person1 = new Person("test@example.com", "1234567890");
		var person2 = new Person("other@example.com", "1234567890");

		var result = person1.Equals((object)person2);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FirstName_SetNull_ConvertsToEmpty()
	{
		var person = RandomData.GeneratePerson<Person>();

		person.FirstName = null;

		Assert.AreEqual(string.Empty, person.FirstName);
	}

	[TestMethod]
	public void FirstName_SetSameValue_DoesNotThrow()
	{
		var person = new Person("test@example.com", "1229282723");
		person.FirstName = "John";

		person.FirstName = "John";

		Assert.AreEqual("John", person.FirstName);
	}

	[TestMethod]
	public void FirstName_SetTooLong_Throws()
	{
		var person = new Person("test@example.com", "1229282723");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.FirstName = new string('a', 51));
	}

	[TestMethod]
	public void FirstName_SetValid_SetsCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();

		person.FirstName = "Jane";

		Assert.AreEqual("Jane", person.FirstName);
	}

	[TestMethod]
	public void Id_InitOnly_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Person("email@email.com", "short"));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Person("email@email.com", new string('a', 51)));
	}

	[TestMethod]
	public void LastName_SetNull_ConvertsToEmpty()
	{
		var person = RandomData.GeneratePerson<Person>();

		person.LastName = null;

		Assert.AreEqual(string.Empty, person.LastName);
	}

	[TestMethod]
	public void LastName_SetSameValue_DoesNotThrow()
	{
		var person = new Person("test@example.com", "1229282723");
		person.LastName = "Doe";

		person.LastName = "Doe";

		Assert.AreEqual("Doe", person.LastName);
	}

	[TestMethod]
	public void LastName_SetTooLong_Throws()
	{
		var person = new Person("test@example.com", "1229282723");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.LastName = new string('a', 51));
	}

	[TestMethod]
	public void LastName_SetValid_SetsCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();

		person.LastName = "Smith";

		Assert.AreEqual("Smith", person.LastName);
	}

	[TestMethod]
	public void Operator_Explicit_From_PersonRecord_Works()
	{
		var record = new DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord("email@email.com", "1234567890");
		var valueType = (Person)record;
		Assert.AreEqual(record.Id, valueType.Id);
		Assert.AreEqual(record.Email, valueType.Email);
	}

	[TestMethod]
	public void Operator_Explicit_From_RefTypePerson_Works()
	{
		var refType = Person.Create("1234567890", "email@email.com", "First", "Last", DateTimeOffset.UtcNow);
		var valueType = refType;
		Assert.AreEqual(refType.Id, valueType.Id);
		Assert.AreEqual(refType.Email, valueType.Email);
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
		Assert.IsLessThan(0, person1.CompareTo(person3));
		Assert.IsGreaterThan(0, person3.CompareTo(person1));
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

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new Person(email, null));
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
	public void Person_Equals_SameId_ReturnsTrue()
	{
		var person1 = new Person("test@example.com", "1234567890");
		var person2 = new Person("other@example.com", "1234567890");

		var result = person1.Equals(person2);

		Assert.IsTrue(result);
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
	public void Person_ToPerson_FromPersonRecord_NoAddresses_ShouldReturnExpectedResults()
	{
		var record = RandomData.GeneratePerson<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>();
		record = record with { Addresses = new Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>() };

		var person = Person.ToPerson(record);

		Assert.AreEqual(record.Id, person.Id);
		Assert.HasCount(0, person.Addresses);
	}

	[TestMethod]
	public void Person_ToPerson_FromPersonRecord_ShouldReturnExpectedResults()
	{
		var record = new DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord("test@example.com", "1234567890")
		{
			FirstName = "John",
			LastName = "Doe",
			BornOn = new DateTimeOffset(1990, 1, 1, 0, 0, 0, TimeSpan.Zero),
			CellPhone = "555-1234",
			Phone = "555-5678",
			Addresses = new Collection<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord>
			{
				new DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord("1234567890")
			}
		};

		var person = Person.ToPerson(record);

		Assert.AreEqual(record.Id, person.Id);
		Assert.AreEqual(record.Email, person.Email);
		Assert.AreEqual(record.FirstName, person.FirstName);
		Assert.AreEqual(record.LastName, person.LastName);
		Assert.AreEqual(record.BornOn, person.BornOn);
		Assert.AreEqual(record.CellPhone, person.CellPhone);
		Assert.AreEqual(record.Phone, person.Phone);
		Assert.HasCount(record.Addresses.Count, person.Addresses);
	}

	[TestMethod]
	public void Person_ToPerson_FromRefTypePerson_NoAddresses_ShouldReturnExpectedResults()
	{
		var refPerson = RandomData.GeneratePerson<DotNetTips.Spargine.Tester.Models.RefTypes.Person>();
		refPerson.Addresses = new Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Address>();

		var person = Person.ToPerson(refPerson);

		Assert.AreEqual(refPerson.Id, person.Id);
		Assert.HasCount(0, person.Addresses);
	}

	[TestMethod]
	public void Person_ToPerson_FromRefTypePerson_ShouldReturnExpectedResults()
	{
		var refPerson = new DotNetTips.Spargine.Tester.Models.RefTypes.Person("test@example.com", "1234567890")
		{
			FirstName = "John",
			LastName = "Doe",
			BornOn = new DateTimeOffset(1990, 1, 1, 0, 0, 0, TimeSpan.Zero),
			CellPhone = "555-1234",
			Phone = "555-5678",
			Addresses = new Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
			{
				new Address("1234567890")
			}
		};

		var person = Person.ToPerson(refPerson);

		Assert.AreEqual(refPerson.Id, person.Id);
		Assert.AreEqual(refPerson.Email, person.Email);
		Assert.AreEqual(refPerson.FirstName, person.FirstName);
		Assert.AreEqual(refPerson.LastName, person.LastName);
		Assert.AreEqual(refPerson.BornOn, person.BornOn);
		Assert.AreEqual(refPerson.CellPhone, person.CellPhone);
		Assert.AreEqual(refPerson.Phone, person.Phone);
		Assert.HasCount(refPerson.Addresses.Count, person.Addresses);
	}

	[TestMethod]
	public void Person_ToString_ReturnsCorrectString()
	{
		// Arrange
		var person = new Person("test@example.com", "1229282723");
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
	public void Phone_SetNull_ConvertsToEmpty()
	{
		var person = RandomData.GeneratePerson<Person>();

		person.Phone = null;

		Assert.AreEqual(string.Empty, person.Phone);
	}

	[TestMethod]
	public void Phone_SetSameValue_DoesNotThrow()
	{
		var person = new Person("test@example.com", "1229282723");
		person.Phone = "555-5678";

		person.Phone = "555-5678";

		Assert.AreEqual("555-5678", person.Phone);
	}

	[TestMethod]
	public void Phone_SetTooLong_Throws()
	{
		var person = new Person("test@example.com", "1229282723");

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person.Phone = new string('1', 51));
	}

	[TestMethod]
	public void Phone_SetValid_SetsCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();

		person.Phone = "555-4321";

		Assert.AreEqual("555-4321", person.Phone);
	}

	[TestMethod]
	public void ToString_ReturnsDebugString()
	{
		var person = Person.Create("1234567890", "email@email.com", "First", "Last", DateTimeOffset.UtcNow);
		var str = person.ToString();
		Assert.IsFalse(string.IsNullOrWhiteSpace(str));
		Assert.Contains("Email", str);
	}

}
