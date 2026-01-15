// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2024
// ***********************************************************************
// <copyright file="SortedDictionaryExtensionsTest.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SortedDictionaryExtensionsTest
{

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(10).ToDictionary(p => p.Id));
		SortedDictionary<string, Person> nullPeople = null;

		Assert.IsFalse(peopleSortedSet.IsEmpty());

		Assert.IsTrue(nullPeople.IsEmpty());
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(10).ToDictionary(p => p.Id));
		SortedDictionary<string, Person> nullPeople = null;

		Assert.IsTrue(peopleSortedSet.IsNotEmpty());

		Assert.IsFalse(nullPeople.IsNotEmpty());
	}

	/// <summary>
	/// Defines the test method HasItemsTestWithFunction.
	/// </summary>
	[TestMethod]
	public void HasItemsTestWithFunction()
	{
		var peopleSortedSet = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(10).ToDictionary(p => p.Id));

		Func<KeyValuePair<string, Person>, bool> selector = p => p.Value.Email.IsNotNull();

		Assert.IsTrue(peopleSortedSet.IsNotEmpty(selector));
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(10).ToDictionary(p => p.Id));
		SortedDictionary<string, Person> nullPeople = null;

		Assert.IsTrue(peopleSortedSet.IsNotEmpty(10));
		Assert.IsFalse(peopleSortedSet.IsNotEmpty(100));

		Assert.IsFalse(nullPeople.IsNotEmpty(10));
	}
	[TestMethod]
	public void ToImmutableTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(100).ToDictionary(p => p.Id));

		var result = peopleSortedSet.ToImmutable();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void UpsertTest()
	{
		var peopleSortedSet = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(10).ToDictionary(p => p.Id));
		var person = RandomData.GeneratePerson<Person>();

		var personFromCollection = peopleSortedSet.Shuffle().First();

		_ = peopleSortedSet.Upsert(person.Id, person);

		Assert.AreEqual(11, peopleSortedSet.Count);

		_ = peopleSortedSet.Upsert(personFromCollection.Key, personFromCollection.Value);

		Assert.AreEqual(11, peopleSortedSet.Count);

	}

}
