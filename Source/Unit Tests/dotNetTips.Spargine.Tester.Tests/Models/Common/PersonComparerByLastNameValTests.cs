// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 04-07-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="PersonComparerByLastNameValTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Models.Common;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonComparerByLastNameValTests
{

	[TestMethod]
	public void Compare_ReturnsNegative_WhenXLastNameIsLessThanY()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890") { LastName = "Adams" };
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ") { LastName = "Smith" };

		Assert.IsLessThan(0, comparer.Compare(p1, p2));
	}

	[TestMethod]
	public void Compare_ReturnsNegative_WhenXLastNameIsNull_AndYIsNot()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890");
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ") { LastName = "Smith" };

		Assert.IsLessThan(0, comparer.Compare(p1, p2));
	}

	[TestMethod]
	public void Compare_ReturnsPositive_WhenXLastNameIsGreaterThanY()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890") { LastName = "Zimmerman" };
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ") { LastName = "Adams" };

		Assert.IsGreaterThan(0, comparer.Compare(p1, p2));
	}

	[TestMethod]
	public void Compare_ReturnsPositive_WhenYLastNameIsNull_AndXIsNot()
	{
		var comparer = new PersonComparerByLastName();
		var p1 = new Person("test1@example.com", "1234567890") { LastName = "Smith" };
		var p2 = new Person("test2@example.com", "ABCDEFGHIJ");

		Assert.IsGreaterThan(0, comparer.Compare(p1, p2));
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
}
