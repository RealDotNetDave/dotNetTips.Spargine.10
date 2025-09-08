// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-01-2025
// ***********************************************************************
// <copyright file="PersonValTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonValTests
{

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void BornOn_SetFutureDate_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var futureDate = DateTimeOffset.UtcNow.AddDays(1);
		var person = new Person("test@example.com", "1229282723");

		// Act
		person.BornOn = futureDate;
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
	public void Id_InitOnly_ThrowsOnInvalidLength()
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Person("email@email.com", "short"));
		Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Person("email@email.com", new string('a', 51)));
	}

	[TestMethod]
	public void Operator_Explicit_From_PersonRecord_Works()
	{
		var record = new Models.RefTypes.PersonRecord("email@email.com", "1234567890");
		var valueType = (Person)record;
		Assert.AreEqual(record.Id, valueType.Id);
		Assert.AreEqual(record.Email, valueType.Email);
	}

	[TestMethod]
	public void Operator_Explicit_From_RefTypePerson_Works()
	{
		var refType = Models.RefTypes.Person.Create("1234567890", "email@email.com", "First", "Last", DateTimeOffset.UtcNow);
		var valueType = (Person)refType;
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
	[ExpectedException(typeof(ArgumentNullException))]
	public void Person_Constructor_NullEmail_ThrowsArgumentNullException()
	{
		// Arrange
		var id = "1229282723";

		// Act
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		_ = new Person(null, id);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentOutOfRangeException))]
	public void Person_Constructor_NullId_ThrowsArgumentNullException()
	{
		// Arrange
		var email = "test@example.com";

		// Act
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		_ = new Person(email, null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
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
	public void ToString_ReturnsDebugString()
	{
		var person = Person.Create("1234567890", "email@email.com", "First", "Last", DateTimeOffset.UtcNow);
		var str = person.ToString();
		Assert.IsFalse(string.IsNullOrWhiteSpace(str));
		Assert.IsTrue(str.Contains("Email"));
	}

}
