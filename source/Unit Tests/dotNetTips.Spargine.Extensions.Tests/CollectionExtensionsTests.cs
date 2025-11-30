// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="CollectionExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CollectionExtensionsTests
{

	private const int Count = 10;

	[TestMethod]
	public void AddIfNotExistsSingleItemTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		Person nullPerson = null;

		// TEST
		Assert.IsFalse(people.AddIfNotExists(nullPerson));

		var testPerson = RandomData.GeneratePerson<Person>();

		Assert.IsTrue(people.AddIfNotExists(testPerson));

		Assert.IsFalse(people.AddIfNotExists(testPerson));
	}
	[TestMethod]
	public void AddIfNotExistsWithComparerTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		Person nullPerson = null;
		var comparer = EqualityComparer<Person>.Default;

		// Null item
		Assert.IsFalse(people.AddIfNotExists(nullPerson, comparer));

		// Add new item
		var testPerson = RandomData.GeneratePerson<Person>();
		Assert.IsTrue(people.AddIfNotExists(testPerson, comparer));

		// Add duplicate
		Assert.IsFalse(people.AddIfNotExists(testPerson, comparer));
	}

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var person = RandomData.GeneratePerson<Person>();

		// TEST
		people.AddIf(person, people.Count == Count);

		Assert.IsTrue(people.Count == 11);
	}

	[TestMethod]
	public void AddRangeEnsureUniqueFalseTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var peopleToAdd = RandomData.GeneratePersonRefCollection(Count).ToList();

		// Add with ensureUnique = false (should add all, even duplicates)
		Assert.IsTrue(people.AddRange(peopleToAdd, ensureUnique: false));
		Assert.AreEqual(Count * 2, people.Count);
	}

	[TestMethod]
	public void AddRangeTest()
	{
		var people = RandomData.GeneratePersonRefCollection(500).ToList();
		var peopleToAdd = RandomData.GeneratePersonRefCollection(5000).ToList();

		people.AddRange(peopleToAdd);

		Assert.IsNotNull(people);

		Assert.IsTrue(people.Count == 5500);
	}

	[TestMethod]
	public void AsReadOnlySpanTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var collection = new Collection<Person>(people);

		// Null argument
		Assert.ThrowsExactly<ArgumentNullException>(() => CollectionExtensions.AsReadOnlySpan<Person>(null));

		// Valid
		var span = collection.AsReadOnlySpan();
		Assert.AreEqual(collection.Count, span.Length);
		Assert.IsTrue(span.SequenceEqual(collection.AsReadOnlySpan()));
	}

	[TestMethod]
	public void AsSpanTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var collection = new Collection<Person>(people);

		var span = collection.AsSpan();
		Assert.AreEqual(collection.Count, span.Length);
		Assert.IsTrue(span.SequenceEqual(collection.AsReadOnlySpan()));
	}


	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var emptyPeople = new List<Person>();

		Assert.IsFalse(people.IsEmpty());

		Assert.IsTrue(emptyPeople.IsEmpty());
	}

	[TestMethod]
	public void ToFrozenSetTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var collection = new Collection<Person>(people);

		var frozenSet = collection.ToFrozenSet();
		Assert.AreEqual(collection.Count, frozenSet.Count);
		foreach (var person in collection)
		{
			Assert.IsTrue(frozenSet.Contains(person));
		}
	}


	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		people.FastShuffle();
		var personFromCollection = people.First();
		var person = RandomData.GeneratePerson<Person>();
		var personRecords = RandomData.GeneratePersonRecordCollection(Count).ToList();
		var personRecord = RandomData.GeneratePerson<PersonRecord>();

		// TEST
		people.Upsert(person);

		Assert.IsTrue(people.Count == 11);

		personRecords.Upsert(personRecord);

		Assert.IsTrue(personRecords.Count == 11);
	}

	[TestMethod]
	public void UpsertWithIDataModelTest()
	{
		var models = new List<Person>();


		for (int i = 0; i < Count; i++)
		{
			models.Add(RandomData.GeneratePerson<Person>());
		}


		// Should have same count, but updated value for Id=5
		Assert.AreEqual(Count, models.Count);

		// Add new item
		var person = RandomData.GeneratePerson<Person>();
		models.Upsert(person);
		Assert.AreEqual(Count + 1, models.Count);
	}


}
