// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-14-2026
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
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SortedDictionaryExtensionsTest
{

	private const int Count = 10;

	[TestMethod]
	public void IsEmpty_WithEmptyCollection_ReturnsTrue()
	{
		var collection = new SortedDictionary<string, Person>();

		var result = collection.IsEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_WithNonEmptyCollection_ReturnsFalse()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));

		var result = collection.IsEmpty();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_WithNullCollection_ReturnsTrue()
	{
		SortedDictionary<string, Person> collection = null;

		var result = collection.IsEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsNotEmpty_WithEmptyCollection_ReturnsFalse()
	{
		var collection = new SortedDictionary<string, Person>();

		var result = collection.IsNotEmpty();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmpty_WithNonEmptyCollection_ReturnsTrue()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));

		var result = collection.IsNotEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsNotEmpty_WithNullCollection_ReturnsFalse()
	{
		SortedDictionary<string, Person> collection = null;

		var result = collection.IsNotEmpty();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmptyWithCount_WithMatchingCount_ReturnsTrue()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));

		Assert.IsTrue(collection.IsNotEmpty(Count));
	}

	[TestMethod]
	public void IsNotEmptyWithCount_WithNonMatchingCount_ReturnsFalse()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));

		Assert.IsFalse(collection.IsNotEmpty(100));
	}

	[TestMethod]
	public void IsNotEmptyWithCount_WithNullCollection_ReturnsFalse()
	{
		SortedDictionary<string, Person> collection = null;

		Assert.IsFalse(collection.IsNotEmpty(Count));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithEmptyCollection_ReturnsFalse()
	{
		var collection = new SortedDictionary<string, Person>();

		Func<KeyValuePair<string, Person>, bool> predicate = p => p.Value.Email.IsNotNull();

		Assert.IsFalse(collection.IsNotEmpty(predicate));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithMatchingPredicate_ReturnsTrue()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));

		Func<KeyValuePair<string, Person>, bool> predicate = p => p.Value.Email.IsNotNull();

		Assert.IsTrue(collection.IsNotEmpty(predicate));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithNonMatchingPredicate_ReturnsFalse()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));

		Func<KeyValuePair<string, Person>, bool> predicate = p => p.Key == "NONEXISTENT_KEY_VALUE";

		Assert.IsFalse(collection.IsNotEmpty(predicate));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithNullCollection_ThrowsArgumentNullException()
	{
		SortedDictionary<string, Person> collection = null;

		Func<KeyValuePair<string, Person>, bool> predicate = p => p.Value.Email.IsNotNull();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.IsNotEmpty(predicate));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithNullPredicate_ThrowsArgumentNullException()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.IsNotEmpty(null));
	}

	[TestMethod]
	public void ToImmutable_WithKeyComparer_EmptyCollection_ReturnsEmptyDictionary()
	{
		// Arrange
		var collection = new SortedDictionary<string, int>();
		var reverseComparer = Comparer<string>.Create((x, y) => string.Compare(y, x, StringComparison.Ordinal));

		// Act
		var result = collection.ToImmutable(reverseComparer);

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(0, result);
	}

	[TestMethod]
	public void ToImmutable_WithKeyComparer_UsesCustomKeyComparer()
	{
		// Arrange
		var collection = new SortedDictionary<string, int>
		{
			["alpha"] = 1,
			["bravo"] = 2,
			["charlie"] = 3
		};
		var reverseComparer = Comparer<string>.Create((x, y) => string.Compare(y, x, StringComparison.Ordinal));

		// Act
		var result = collection.ToImmutable(reverseComparer);

		// Assert — reverse order: charlie, bravo, alpha
		Assert.IsNotNull(result);
		Assert.HasCount(3, result);
		Assert.AreEqual("charlie", result.Keys.First());
		Assert.AreEqual("alpha", result.Keys.Last());
	}

	[TestMethod]
	public void ToImmutable_WithNullCollection_ThrowsArgumentNullException()
	{
		SortedDictionary<string, Person> collection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.ToImmutable());
	}

	[TestMethod]
	public void ToImmutable_WithNullKeyComparer_UsesDefaultComparer()
	{
		// Arrange
		var collection = new SortedDictionary<string, int>
		{
			["charlie"] = 3,
			["alpha"] = 1,
			["bravo"] = 2
		};

		// Act
		var result = collection.ToImmutable(null);

		// Assert — default ascending order
		Assert.IsNotNull(result);
		Assert.HasCount(3, result);
		Assert.AreEqual("alpha", result.Keys.First());
		Assert.AreEqual("charlie", result.Keys.Last());
	}

	[TestMethod]
	public void ToImmutable_WithValidCollection_ReturnsImmutableSortedDictionary()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));

		var result = collection.ToImmutable();

		Assert.IsNotNull(result);
		Assert.AreEqual(Count, result.Count);
	}

	[TestMethod]
	public void Upsert_WithExistingKey_UpdatesValue()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));
		var existingEntry = collection.First();
		var newPerson = RandomData.GeneratePerson<Person>();

		var result = collection.Upsert(existingEntry.Key, newPerson);

		Assert.AreEqual(Count, collection.Count);
		Assert.AreEqual(newPerson, result);
		Assert.AreEqual(newPerson, collection[existingEntry.Key]);
	}

	[TestMethod]
	public void Upsert_WithNewKey_InsertsValue()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));
		var person = RandomData.GeneratePerson<Person>();

		var result = collection.Upsert(person.Id, person);

		Assert.AreEqual(Count + 1, collection.Count);
		Assert.AreEqual(person, result);
		Assert.IsTrue(collection.ContainsKey(person.Id));
	}

	[TestMethod]
	public void Upsert_WithNullCollection_ThrowsArgumentNullException()
	{
		SortedDictionary<string, Person> collection = null;
		var person = RandomData.GeneratePerson<Person>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.Upsert(person.Id, person));
	}

	[TestMethod]
	public void Upsert_WithNullKey_ThrowsArgumentNullException()
	{
		var collection = new SortedDictionary<string, Person>(RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id));
		var person = RandomData.GeneratePerson<Person>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.Upsert(null, person));
	}

}
