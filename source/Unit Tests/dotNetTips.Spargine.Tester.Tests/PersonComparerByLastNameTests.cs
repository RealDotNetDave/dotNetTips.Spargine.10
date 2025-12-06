// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 06-13-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-30-2025
// ***********************************************************************
// <copyright file="PersonComparerByLastNameTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[TestClass]
public class PersonComparerByLastNameTests
{

	[TestMethod]
	public void Compare_ReturnsNegative_WhenFirstLastNameIsLess()
	{
		var person1 = new Person("id1xxxxxxx", "test1@xxxxexample.com") { LastName = "Anderson" };
		var person2 = new Person("id2xxxxxxx", "test2@xxxxexample.com") { LastName = "Smith" };
		var comparer = new PersonComparerByLastName();

		int result = comparer.Compare(person1, person2);

		Assert.IsTrue(result < 0);
	}

	[TestMethod]
	public void Compare_ReturnsNegative_WhenXLastNameIsLessThanY()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890") { LastName = "Adams" };
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ") { LastName = "Smith" };
		Assert.IsTrue(comparer.Compare(p1, p2) < 0);
	}

	[TestMethod]
	public void Compare_ReturnsNegative_WhenXLastNameIsNull_AndYIsNot()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890");
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ") { LastName = "Smith" };
		Assert.IsTrue(comparer.Compare(p1, p2) < 0);
	}

	[TestMethod]
	public void Compare_ReturnsPositive_WhenFirstLastNameIsGreater()
	{
		var person1 = new Person("id112345678", "test1@example.com") { LastName = "Zimmerman" };
		var person2 = new Person("id212345678", "test2@example.com") { LastName = "Smith" };
		var comparer = new PersonComparerByLastName();

		int result = comparer.Compare(person1, person2);

		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void Compare_ReturnsPositive_WhenXLastNameIsGreaterThanY()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890") { LastName = "Smith" };
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ") { LastName = "Adams" };
		Assert.IsTrue(comparer.Compare(p1, p2) > 0);
	}

	[TestMethod]
	public void Compare_ReturnsPositive_WhenYLastNameIsNull_AndXIsNot()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890") { LastName = "Smith" };
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ");
		Assert.IsTrue(comparer.Compare(p1, p2) > 0);
	}

	[TestMethod]
	public void Compare_ReturnsZero_WhenBothLastNamesAreNull()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890");
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ");
		Assert.AreEqual(0, comparer.Compare(p1, p2));
	}

	[TestMethod]
	public void Compare_ReturnsZero_WhenLastNamesAreEqual()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890") { LastName = "Smith" };
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ") { LastName = "Smith" };
		Assert.AreEqual(0, comparer.Compare(p1, p2));
	}

	[TestMethod]
	public void Compare_Works_WhenBothAreNull()
	{
		var comparer = new PersonComparerByLastName();
		Person p1 = null;
		Person p2 = null;
		Assert.AreEqual(0, comparer.Compare(p1, p2));
	}

	[TestMethod]
	public void Compare_Works_WhenXIsNull()
	{
		var comparer = new PersonComparerByLastName();
		Person p1 = null;
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ") { LastName = "Smith" };
		Assert.IsTrue(comparer.Compare(p1, p2) < 0);
	}

	[TestMethod]
	public void Compare_Works_WhenYIsNull()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890") { LastName = "Smith" };
		Person p2 = null;
		Assert.IsTrue(comparer.Compare(p1, p2) > 0);
	}
}
