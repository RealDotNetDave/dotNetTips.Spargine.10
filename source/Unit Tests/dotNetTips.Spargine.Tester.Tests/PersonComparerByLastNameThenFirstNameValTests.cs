// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : Copilot Agent
// Created          : 04-07-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="PersonComparerByLastNameThenFirstNameValTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[TestClass]
public class PersonComparerByLastNameThenFirstNameValTests
{

	[TestMethod]
	public void Compare_DifferentLastNames_XLessThanY_ReturnsNegative()
	{
		var comparer = new PersonComparerByLastNameThenFirstName();
		var person1 = new Person("test1@example.com", "0000000001") { LastName = "Adams", FirstName = "John" };
		var person2 = new Person("test2@example.com", "0000000002") { LastName = "Smith", FirstName = "John" };

		var result = comparer.Compare(person1, person2);

		Assert.IsLessThan(0, result);
	}

	[TestMethod]
	public void Compare_DifferentLastNames_XGreaterThanY_ReturnsPositive()
	{
		var comparer = new PersonComparerByLastNameThenFirstName();
		var person1 = new Person("test1@example.com", "0000000001") { LastName = "Smith", FirstName = "John" };
		var person2 = new Person("test2@example.com", "0000000002") { LastName = "Adams", FirstName = "John" };

		var result = comparer.Compare(person1, person2);

		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void Compare_SameLastName_DifferentFirstName_XLessThanY_ReturnsNegative()
	{
		var comparer = new PersonComparerByLastNameThenFirstName();
		var person1 = new Person("test1@example.com", "0000000001") { LastName = "Smith", FirstName = "Alice" };
		var person2 = new Person("test2@example.com", "0000000002") { LastName = "Smith", FirstName = "Bob" };

		var result = comparer.Compare(person1, person2);

		Assert.IsLessThan(0, result);
	}

	[TestMethod]
	public void Compare_SameLastName_DifferentFirstName_XGreaterThanY_ReturnsPositive()
	{
		var comparer = new PersonComparerByLastNameThenFirstName();
		var person1 = new Person("test1@example.com", "0000000001") { LastName = "Smith", FirstName = "Bob" };
		var person2 = new Person("test2@example.com", "0000000002") { LastName = "Smith", FirstName = "Alice" };

		var result = comparer.Compare(person1, person2);

		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void Compare_SameLastName_SameFirstName_ReturnsZero()
	{
		var comparer = new PersonComparerByLastNameThenFirstName();
		var person1 = new Person("test1@example.com", "0000000001") { LastName = "Smith", FirstName = "John" };
		var person2 = new Person("test2@example.com", "0000000002") { LastName = "Smith", FirstName = "John" };

		var result = comparer.Compare(person1, person2);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Compare_SortsList_ByLastNameThenFirstName()
	{
		var comparer = new PersonComparerByLastNameThenFirstName();
		var people = new List<Person>
		{
			new("p1@example.com", "0000000001") { LastName = "Zane", FirstName = "Alice" },
			new("p2@example.com", "0000000002") { LastName = "Adams", FirstName = "Bob" },
			new("p3@example.com", "0000000003") { LastName = "Adams", FirstName = "Alice" },
		};

		people.Sort(comparer);

		Assert.AreEqual("Adams", people[0].LastName);
		Assert.AreEqual("Alice", people[0].FirstName);
		Assert.AreEqual("Adams", people[1].LastName);
		Assert.AreEqual("Bob", people[1].FirstName);
		Assert.AreEqual("Zane", people[2].LastName);
		Assert.AreEqual("Alice", people[2].FirstName);
	}
}
