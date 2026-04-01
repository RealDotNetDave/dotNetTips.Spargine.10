// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="PersonRecordRefTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts;
using DotNetTips.Spargine.Tester.Tests.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonRecordRefTests
{
	private const int PeopleJsonCount = 10000;

	[TestMethod]
	public void Addresses_Init_DefensiveCopy()
	{
		var addresses = new Collection<AddressRecord> { new AddressRecord("1234567890") };
		var record = new PersonRecord("email@email.com", "1234567890") { Addresses = addresses };
		Assert.AreNotSame(addresses, record.Addresses);
		Assert.HasCount(addresses.Count, record.Addresses);
	}

	[TestMethod]
	public void BornOn_Init_ThrowsOnFutureDate()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new PersonRecord("email@email.com", "1234567890") { BornOn = DateTimeOffset.UtcNow.AddDays(1) });
	}

	[TestMethod]
	public void BornOn_SetFutureDate_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var futureDate = DateTimeOffset.UtcNow.AddDays(1);
		var person = new PersonRecord("test@example.com", "1229282723");

		// Act
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => person with { BornOn = futureDate });

	}

	[TestMethod]
	public void BornOn_SetPastDate_SetsCorrectly()
	{
		// Arrange
		var pastDate = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);
		var person = new PersonRecord("test@example.com", "1229282723");

		// Act
		person = person with { BornOn = pastDate };

		// Assert
		Assert.AreEqual(pastDate, person.BornOn);
	}

	[TestMethod]
	public void CellPhone_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new PersonRecord("email@email.com", "1234567890") { CellPhone = new string('a', 51) });
	}

	[TestMethod]
	public void CompareTo_Object_ThrowsOnInvalidType()
	{
		var record = new PersonRecord("email@email.com", "1234567890");
		Assert.ThrowsExactly<ArgumentException>(() => ((IComparable)record).CompareTo("not a person record"));
	}

	[TestMethod]
	public void CompareTo_OtherWithGreaterId_ReturnsNegative()
	{
		var person = new PersonRecord(email: "test@example.com", id: "1234567890");
		var other = new PersonRecord(email: "other@example.com", id: "1234567891");
		var result = person.CompareTo(other);
		Assert.IsLessThan(0, result);
	}

	[TestMethod]
	public void CompareTo_OtherWithLowerId_ReturnsPositive()
	{
		var person = new PersonRecord(email: "test@example.com", id: "1234567891");
		var other = new PersonRecord(email: "other@example.com", id: "1234567890");
		var result = person.CompareTo(other);
		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void CompareTo_OtherWithSameId_ReturnsZero()
	{
		var person = new PersonRecord(email: "test@example.com", id: "1234567890");
		var other = new PersonRecord(email: "other@example.com", id: "1234567890");
		var result = person.CompareTo(other);
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Email_InitOnly_ThrowsOnNullOrEmptyOrInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonRecord(null!, "1234567890"));
		Assert.ThrowsExactly<ArgumentNullException>(() => new PersonRecord(string.Empty, "1234567890"));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new PersonRecord(new string('a', 76), "1234567890"));
	}

	[TestMethod]
	public void FirstName_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new PersonRecord("email@email.com", "1234567890") { FirstName = new string('a', 51) });
	}

	[TestMethod]
	public void Id_InitOnly_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new PersonRecord("email@email.com", "short"));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new PersonRecord("email@email.com", new string('a', 51)));
	}

	[TestMethod]
	public void LastName_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new PersonRecord("email@email.com", "1234567890") { LastName = new string('a', 51) });
	}

	[TestMethod]
	public void LoadFromJson()
	{
		var people = JsonSerialization.LoadCollectionFromJson<PersonRecord>(Resources.PeopleJson, PeopleJsonCount, PersonRecordJsonSerializerContext.Default.Person);

		// Assert
		Assert.HasCount(PeopleJsonCount, people);
	}

	[TestMethod]
	public void LoadFromJsonClone()
	{
		// Arrange
		var people = JsonSerialization.LoadCollectionFromJson<PersonRecord>(Resources.PeopleJson, PeopleJsonCount, PersonRecordJsonSerializerContext.Default.Person);

		// Explicitly specify the type argument for FastClone to resolve CS0411
		var clonedPeople = people.FastClone<Collection<PersonRecord>>();

		// Assert
		Assert.IsNotNull(clonedPeople);
		Assert.HasCount(PeopleJsonCount, clonedPeople);
	}

	[TestMethod]
	public void Operator_LessThan_LessThanOrEqual_GreaterThan_GreaterThanOrEqual()
	{
		var p1 = new PersonRecord("email@email.com", "1234567890");
		var p2 = new PersonRecord("email@email.com", "ABCDEFGHIJ");
		Assert.IsTrue(p1 < p2 || p2 < p1 || p1 == p2);
		Assert.IsTrue(p1 <= p2 || p2 <= p1);
		Assert.IsTrue(p1 > p2 || p2 > p1 || p1 == p2);
		Assert.IsTrue(p1 >= p2 || p2 >= p1);
		Assert.IsFalse(p1 < null);
		Assert.IsTrue(p1 > null);
		Assert.IsTrue(null < p1);
		Assert.IsFalse(null > p1);
	}

	[TestMethod]
	public void PersonRecord_CompareTo_ValidPersonRecord_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new PersonRecord("test1@example.com", "1229282723");
		var person2 = new PersonRecord("test1@example.com", "1229282723");
		var person3 = new PersonRecord("test2@example.com", "12292827234");

		// Act & Assert
		Assert.AreEqual(0, person1.CompareTo(person2));
		Assert.IsLessThan(0, person1.CompareTo(person3));
		Assert.IsGreaterThan(0, person3.CompareTo(person1));
	}

	[TestMethod]
	public void PersonRecord_ComparisonOperators_ShouldReturnExpectedResults()
	{
		// Arrange
		var person1 = new PersonRecord("test1@example.com", "1229282723");
		var person2 = new PersonRecord("test1@example.com", "1229282723");
		var person3 = new PersonRecord("test2@example.com", "12292827234");

		// Act & Assert
		Assert.IsTrue(person1 <= person2);
		Assert.IsTrue(person1 >= person2);
		Assert.IsTrue(person1 < person3);
		Assert.IsTrue(person3 > person1);
	}

	[TestMethod]
	public void PersonRecord_Constructor_NullId_ThrowsArgumentNullException()
	{
		// Arrange
		var email = "test@example.com";

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new PersonRecord(email, null));
	}

	[TestMethod]
	public void PersonRecord_Constructor_ShouldInitializeProperties()
	{
		// Arrange
		var id = "1229282723";
		var email = "test@example.com";

		// Act
		var personRecord = new PersonRecord(email, id);

		// Assert
		Assert.AreEqual(id, personRecord.Id);
		Assert.AreEqual(email, personRecord.Email);
	}
	[TestMethod]
	public void PersonRecord_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		var email = "test@example.com";
		var id = "1229282723";

		// Act
		var personRecord = new PersonRecord(email, id);

		// Assert
		Assert.IsNotNull(personRecord);
		Assert.AreEqual(email, personRecord.Email);
		Assert.AreEqual(id, personRecord.Id);
	}

	[TestMethod]
	public void PersonRecord_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var personRecord1 = new PersonRecord("test1@example.com", "1229282723");
		var personRecord2 = new PersonRecord("test2@example.com", "12292827234");

		// Act
		var result = personRecord1.Equals(personRecord2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void PersonRecord_GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var personRecord1 = new PersonRecord("test1@example.com", "1229282723");
		var personRecord2 = new PersonRecord("test2@example.com", "12292827234");

		// Act
		var hashCode1 = personRecord1.GetHashCode();
		var hashCode2 = personRecord2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void PersonRecord_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var personRecord1 = new PersonRecord("test1@example.com", "1229282723");
		var personRecord2 = new PersonRecord("test2@example.com", "12292827234");

		// Act
		var result = personRecord1 != personRecord2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void PersonRecord_Properties_SetAndGetValues()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "1229282723");
		var firstName = "John";
		var lastName = "Doe";
		var bornOn = new DateTimeOffset(new DateTime(1990, 1, 1));
		var cellPhone = "555-1234";
		var phone = "555-5678";
		var addresses = new Collection<AddressRecord> { new AddressRecord("1229282723") };

		// Act
		personRecord = personRecord with
		{
			FirstName = firstName,
			LastName = lastName,
			BornOn = bornOn,
			CellPhone = cellPhone,
			Phone = phone,
			Addresses = addresses
		};

		// Assert
		Assert.AreEqual(firstName, personRecord.FirstName);
		Assert.AreEqual(lastName, personRecord.LastName);
		Assert.AreEqual(bornOn, personRecord.BornOn);
		Assert.AreEqual(cellPhone, personRecord.CellPhone);
		Assert.AreEqual(phone, personRecord.Phone);
	}

	[TestMethod]
	public void PersonRecord_ToPersonRecord_FromPerson_ShouldReturnExpectedResults()
	{
		// Arrange
		var person = new Person("test@example.com", "1229282723")
		{
			FirstName = "John",
			LastName = "Doe",
			BornOn = new DateTimeOffset(new DateTime(1990, 1, 1)),
			CellPhone = "555-1234",
			Phone = "555-5678",
			Addresses = new Collection<Address> { new Address("1229282723") }
		};

		// Act
		var personRecord = PersonRecord.ToPersonRecord(person);

		// Assert
		Assert.AreEqual(person.Id, personRecord.Id);
		Assert.AreEqual(person.Email, personRecord.Email);
		Assert.AreEqual(person.FirstName, personRecord.FirstName);
		Assert.AreEqual(person.LastName, personRecord.LastName);
		Assert.AreEqual(person.BornOn, personRecord.BornOn);
		Assert.AreEqual(person.CellPhone, personRecord.CellPhone);
		Assert.AreEqual(person.Phone, personRecord.Phone);
		Assert.HasCount(person.Addresses.Count, personRecord.Addresses);
	}

	[TestMethod]
	public void PersonRecord_ToString_ReturnsCorrectString()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "1229282723");
		var expectedString = personRecord.PropertiesToString();

		// Act
		var result = personRecord.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void PersonRecord_ToString_ShouldReturnExpectedResults()
	{
		// Arrange
		var personRecord = new PersonRecord("test@example.com", "1229282723");
		var expectedString = "Email:test@example.com, Id:1229282723";

		// Act
		var result = personRecord.ToString();

		// Assert
		Assert.AreEqual(expectedString, result);
	}

	[TestMethod]
	public void Phone_Init_ThrowsOnInvalidLength()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			new PersonRecord("email@email.com", "1234567890") { Phone = new string('a', 51) });
	}

	[TestMethod]
	public void ToPersonRecord_FromPerson_Works()
	{
		var person = new Person("email@email.com", "1234567890");
		var record = PersonRecord.ToPersonRecord(person);
		Assert.AreEqual(person.Id, record.Id);
		Assert.AreEqual(person.Email, record.Email);
	}

	[TestMethod]
	public void ToPersonRecord_FromValueType_Works()
	{
		var valueType = new DotNetTips.Spargine.Tester.Models.ValueTypes.Person("email@email.com", "1234567890");
		var record = PersonRecord.ToPersonRecord(valueType);
		Assert.AreEqual(valueType.Id, record.Id);
		Assert.AreEqual(valueType.Email, record.Email);
	}

	[TestMethod]
	public void ToString_ReturnsDebugString()
	{
		var record = new PersonRecord("email@email.com", "1234567890");
		var str = record.ToString();
		Assert.IsFalse(string.IsNullOrWhiteSpace(str));
		Assert.Contains("Email", str);
	}

	[TestMethod]
	public void ToString_Test()
	{
		// Arrange
		var personRecord = RandomData.GeneratePerson<PersonRecord>();

		var result = personRecord.ToString();

		Assert.IsNotNull(result);
	}
}
