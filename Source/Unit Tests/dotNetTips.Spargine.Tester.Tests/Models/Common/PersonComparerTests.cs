// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 03-31-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="PersonComparerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Models.Common;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonComparerTests
{

	[TestMethod]
	public void Equals_BothNull_ReturnsTrue()
	{
		var comparer = new PersonEqualityComparer();

		Assert.IsTrue(comparer.Equals(null, null));
	}

	[TestMethod]
	public void Equals_DifferentId_ReturnsFalse()
	{
		var person1 = RandomData.GeneratePerson<Person>();
		var person2 = RandomData.GeneratePerson<Person>();
		var comparer = new PersonEqualityComparer();

		Assert.IsFalse(comparer.Equals(person1, person2));
	}

	[TestMethod]
	public void Equals_FirstNull_ReturnsFalse()
	{
		var person = RandomData.GeneratePerson<Person>();
		var comparer = new PersonEqualityComparer();

		Assert.IsFalse(comparer.Equals(null, person));
	}

	[TestMethod]
	public void Equals_SameId_ReturnsTrue()
	{
		var person1 = new Person("test1@example.com", "1234567890");
		var person2 = new Person("test2@example.com", "1234567890");
		var comparer = new PersonEqualityComparer();

		Assert.IsTrue(comparer.Equals(person1, person2));
	}

	[TestMethod]
	public void Equals_SameReference_ReturnsTrue()
	{
		var person = RandomData.GeneratePerson<Person>();
		var comparer = new PersonEqualityComparer();

		Assert.IsTrue(comparer.Equals(person, person));
	}

	[TestMethod]
	public void Equals_SecondNull_ReturnsFalse()
	{
		var person = RandomData.GeneratePerson<Person>();
		var comparer = new PersonEqualityComparer();

		Assert.IsFalse(comparer.Equals(person, null));
	}

	[TestMethod]
	public void GetHashCode_DifferentId_ReturnsDifferentHash()
	{
		var person1 = new Person("test1@example.com", "1234567890");
		var person2 = new Person("test2@example.com", "ABCDEFGHIJ");
		var comparer = new PersonEqualityComparer();

		Assert.AreNotEqual(comparer.GetHashCode(person1), comparer.GetHashCode(person2));
	}

	[TestMethod]
	public void GetHashCode_NullPerson_ReturnsZero()
	{
		var comparer = new PersonEqualityComparer();

		Assert.AreEqual(0, comparer.GetHashCode(null));
	}

	[TestMethod]
	public void GetHashCode_SameId_ReturnsSameHash()
	{
		var person1 = new Person("test1@example.com", "1234567890");
		var person2 = new Person("test2@example.com", "1234567890");
		var comparer = new PersonEqualityComparer();

		Assert.AreEqual(comparer.GetHashCode(person1), comparer.GetHashCode(person2));
	}

	[TestMethod]
	public void GetHashCode_ValidPerson_ReturnsNonZero()
	{
		var person = RandomData.GeneratePerson<Person>();
		var comparer = new PersonEqualityComparer();

		Assert.AreNotEqual(0, comparer.GetHashCode(person));
	}
}
