// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : Copilot Agent
// Created          : 04-07-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="PersonEqualityComparerByEmailValTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Tester.Models.ValueTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[TestClass]
public class PersonEqualityComparerByEmailValTests
{

	[TestMethod]
	public void Equals_SameId_ReturnsTrue()
	{
		var comparer = new PersonEqualityComparerByEmail();
		var person1 = new Person("test1@example.com", "1234567890");
		var person2 = new Person("test2@example.com", "1234567890");

		var result = comparer.Equals(person1, person2);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Equals_DifferentId_ReturnsFalse()
	{
		var comparer = new PersonEqualityComparerByEmail();
		var person1 = new Person("test@example.com", "0000000001");
		var person2 = new Person("test@example.com", "0000000002");

		var result = comparer.Equals(person1, person2);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Equals_DefaultPersons_ReturnsTrue()
	{
		var comparer = new PersonEqualityComparerByEmail();
		var person1 = default(Person);
		var person2 = default(Person);

		var result = comparer.Equals(person1, person2);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Equals_SamePersonValues_ReturnsTrue()
	{
		var comparer = new PersonEqualityComparerByEmail();
		var person = RandomData.GeneratePerson<Person>();

		var result = comparer.Equals(person, person);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void GetHashCode_SameEmail_ReturnsSameHash()
	{
		var comparer = new PersonEqualityComparerByEmail();
		var person1 = new Person("test@example.com", "0000000001");
		var person2 = new Person("test@example.com", "0000000002");

		Assert.AreEqual(comparer.GetHashCode(person1), comparer.GetHashCode(person2));
	}

	[TestMethod]
	public void GetHashCode_SameEmailDifferentCase_ReturnsSameHash()
	{
		var comparer = new PersonEqualityComparerByEmail();
		var person1 = new Person("Test@Example.COM", "0000000001");
		var person2 = new Person("test@example.com", "0000000002");

		Assert.AreEqual(comparer.GetHashCode(person1), comparer.GetHashCode(person2));
	}

	[TestMethod]
	public void GetHashCode_DefaultPerson_ReturnsZero()
	{
		var comparer = new PersonEqualityComparerByEmail();
		var person = default(Person);

		var result = comparer.GetHashCode(person);

		Assert.AreEqual(0, result);
	}
}
