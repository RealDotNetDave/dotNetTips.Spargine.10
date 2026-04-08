// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : Copilot Agent
// Created          : 04-07-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="PersonComparerByIdThenLastNameValTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Models.Common;

[TestClass]
public class PersonComparerByIdThenLastNameValTests
{

	[TestMethod]
	public void Compare_DifferentIds_XGreaterThanY_ReturnsPositive()
	{
		var comparer = new PersonComparerByIdThenLastName();
		var person1 = new Person("test1@example.com", "BBBBBBBBBB") { LastName = "Adams" };
		var person2 = new Person("test2@example.com", "AAAAAAAAAA") { LastName = "Smith" };

		var result = comparer.Compare(person1, person2);

		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void Compare_DifferentIds_XLessThanY_ReturnsNegative()
	{
		var comparer = new PersonComparerByIdThenLastName();
		var person1 = new Person("test1@example.com", "AAAAAAAAAA") { LastName = "Smith" };
		var person2 = new Person("test2@example.com", "BBBBBBBBBB") { LastName = "Adams" };

		var result = comparer.Compare(person1, person2);

		Assert.IsLessThan(0, result);
	}

	[TestMethod]
	public void Compare_SameId_DifferentLastName_XGreaterThanY_ReturnsPositive()
	{
		var comparer = new PersonComparerByIdThenLastName();
		var person1 = new Person("test1@example.com", "1234567890") { LastName = "Smith" };
		var person2 = new Person("test2@example.com", "1234567890") { LastName = "Adams" };

		var result = comparer.Compare(person1, person2);

		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void Compare_SameId_DifferentLastName_XLessThanY_ReturnsNegative()
	{
		var comparer = new PersonComparerByIdThenLastName();
		var person1 = new Person("test1@example.com", "1234567890") { LastName = "Adams" };
		var person2 = new Person("test2@example.com", "1234567890") { LastName = "Smith" };

		var result = comparer.Compare(person1, person2);

		Assert.IsLessThan(0, result);
	}

	[TestMethod]
	public void Compare_SameId_SameLastName_ReturnsZero()
	{
		var comparer = new PersonComparerByIdThenLastName();
		var person1 = new Person("test1@example.com", "1234567890") { LastName = "Smith" };
		var person2 = new Person("test2@example.com", "1234567890") { LastName = "Smith" };

		var result = comparer.Compare(person1, person2);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Compare_SortsList_ByIdThenLastName()
	{
		var comparer = new PersonComparerByIdThenLastName();
		var people = new List<Person>
		{
			new("p3@example.com", "0000000002") { LastName = "Zane" },
			new("p1@example.com", "0000000001") { LastName = "Brown" },
			new("p2@example.com", "0000000001") { LastName = "Adams" },
		};

		people.Sort(comparer);

		Assert.AreEqual("Adams", people[0].LastName);
		Assert.AreEqual("Brown", people[1].LastName);
		Assert.AreEqual("Zane", people[2].LastName);
		Assert.AreEqual("0000000001", people[0].Id);
		Assert.AreEqual("0000000001", people[1].Id);
		Assert.AreEqual("0000000002", people[2].Id);
	}
}
