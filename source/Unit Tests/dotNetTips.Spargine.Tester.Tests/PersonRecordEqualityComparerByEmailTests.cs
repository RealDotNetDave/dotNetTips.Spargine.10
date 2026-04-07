// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : Copilot Agent
// Created          : 04-07-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="PersonRecordEqualityComparerByEmailTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonRecordEqualityComparerByEmailTests
{

	[TestMethod]
	public void Equals_BothNull_ReturnsTrue()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();

		Assert.IsTrue(comparer.Equals(null, null));
	}

	[TestMethod]
	public void Equals_XNullYNotNull_ReturnsFalse()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person = RandomData.GeneratePerson<PersonRecord>();

		Assert.IsFalse(comparer.Equals(null, person));
	}

	[TestMethod]
	public void Equals_XNotNullYNull_ReturnsFalse()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person = RandomData.GeneratePerson<PersonRecord>();

		Assert.IsFalse(comparer.Equals(person, null));
	}

	[TestMethod]
	public void Equals_SameEmail_ReturnsTrue()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person1 = new PersonRecord("test@example.com", "1234567890");
		var person2 = new PersonRecord("test@example.com", "0987654321");

		Assert.IsTrue(comparer.Equals(person1, person2));
	}

	[TestMethod]
	public void Equals_SameEmailDifferentCase_ReturnsTrue()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person1 = new PersonRecord("Test@Example.COM", "1234567890");
		var person2 = new PersonRecord("test@example.com", "0987654321");

		Assert.IsTrue(comparer.Equals(person1, person2));
	}

	[TestMethod]
	public void Equals_DifferentEmail_ReturnsFalse()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person1 = new PersonRecord("person1@example.com", "1234567890");
		var person2 = new PersonRecord("person2@example.com", "0987654321");

		Assert.AreNotEqual(person1.Email, person2.Email);
		Assert.IsFalse(comparer.Equals(person1, person2));
	}

	[TestMethod]
	public void Equals_SameReference_ReturnsTrue()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person = RandomData.GeneratePerson<PersonRecord>();

		Assert.IsTrue(comparer.Equals(person, person));
	}

	[TestMethod]
	public void GetHashCode_ValidPerson_ReturnsEmailHashCodeIgnoringCase()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person = RandomData.GeneratePerson<PersonRecord>();

		Assert.AreEqual(person.Email.GetHashCode(StringComparison.OrdinalIgnoreCase), comparer.GetHashCode(person));
	}

	[TestMethod]
	public void GetHashCode_SameEmail_ReturnsSameHash()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person1 = new PersonRecord("test@example.com", "1234567890");
		var person2 = new PersonRecord("test@example.com", "0987654321");

		Assert.AreEqual(comparer.GetHashCode(person1), comparer.GetHashCode(person2));
	}

	[TestMethod]
	public void GetHashCode_SameEmailDifferentCase_ReturnsSameHash()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person1 = new PersonRecord("Test@Example.COM", "1234567890");
		var person2 = new PersonRecord("test@example.com", "0987654321");

		Assert.AreEqual(comparer.GetHashCode(person1), comparer.GetHashCode(person2));
	}

	[TestMethod]
	public void GetHashCode_DifferentEmail_ReturnsCaseInsensitiveEmailHash()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();
		var person1 = new PersonRecord("alice@example.com", "1234567890");
		var person2 = new PersonRecord("bob@example.com", "0987654321");

		Assert.AreEqual(StringComparer.OrdinalIgnoreCase.GetHashCode("alice@example.com"), comparer.GetHashCode(person1));
		Assert.AreEqual(StringComparer.OrdinalIgnoreCase.GetHashCode("bob@example.com"), comparer.GetHashCode(person2));
	}

	[TestMethod]
	public void GetHashCode_NullObj_ReturnsZero()
	{
		var comparer = new PersonRecordEqualityComparerByEmail();

		Assert.AreEqual(0, comparer.GetHashCode(null!));
	}
}
