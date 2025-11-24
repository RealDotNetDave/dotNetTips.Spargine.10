// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-11-2024
// ***********************************************************************
// <copyright file="SortedSetExtensionsTest.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SortedSetExtensionsTest
{

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var collection = new SortedSet<Tester.Models.RefTypes.Person>(RandomData.GeneratePersonRefCollection(100));
		SortedSet<Tester.Models.RefTypes.Person> nullCollection = null;

		Assert.IsFalse(collection.IsEmpty());

		Assert.IsTrue(nullCollection.IsEmpty());
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = new SortedSet<Tester.Models.RefTypes.Person>(RandomData.GeneratePersonRefCollection(100));
		SortedSet<Tester.Models.RefTypes.Person> nullCollection = null;

		Assert.IsTrue(collection.IsNotEmpty());

		Assert.IsFalse(nullCollection.IsNotEmpty());
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = new SortedSet<Tester.Models.RefTypes.Person>(RandomData.GeneratePersonRefCollection(100));
		ObservableCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.IsNotEmpty(100));

		Assert.IsFalse(collection.IsNotEmpty(5));

		Assert.IsFalse(nullCollection.IsNotEmpty());
	}

	[TestMethod]
	public void HasItemsWithFunctionTest()
	{
		var collection = new SortedSet<Tester.Models.RefTypes.Person>(RandomData.GeneratePersonRefCollection(100));
		ObservableCollection<Coordinate> nullCollection = null;

		Func<Tester.Models.RefTypes.Person, bool> selector = (person) => person.Email.IsNotNull();

		Assert.IsTrue(collection.IsNotEmpty(selector));

		Assert.IsFalse(nullCollection.IsNotEmpty());
	}
	[TestMethod]
	public void ToImmutableSortedSet()
	{
		var peopleSortedSet = new SortedSet<Tester.Models.RefTypes.Person>(RandomData.GeneratePersonRefCollection(100));

		var result = peopleSortedSet.ToImmutableSortedSet();

		Assert.IsNotNull(result);
	}

}
