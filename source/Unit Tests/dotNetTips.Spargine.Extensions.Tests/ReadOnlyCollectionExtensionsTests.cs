// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 06-15-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="ReadOnlyCollectionExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ReadOnlyCollectionExtensionsTests
{

	private const int Count = 256;

	// ========================
	// GenerateHashCode Tests
	// ========================

	[TestMethod]
	public void GenerateHashCode_NullCollection_ThrowsArgumentNullException()
	{
		ReadOnlyCollection<Person> collection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.GenerateHashCode());
	}

	[TestMethod]
	public void GenerateHashCode_EmptyCollection_ReturnsBaseHash()
	{
		var collection = new ReadOnlyCollection<Person>(new List<Person>());

		var result = collection.GenerateHashCode();

		Assert.AreEqual(6551, result);
	}

	[TestMethod]
	public void GenerateHashCode_NonEmptyCollection_ReturnsNonBaseHash()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.GenerateHashCode();

		Assert.AreNotEqual(6551, result);
	}

	[TestMethod]
	public void GenerateHashCode_WithDefaultComparer_ReturnsHash()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.GenerateHashCode(null);

		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void GenerateHashCode_WithCustomComparer_ReturnsHash()
	{
		var list = new List<string> { "alpha", "beta", "gamma" };
		var collection = new ReadOnlyCollection<string>(list);

		var result = collection.GenerateHashCode(StringComparer.OrdinalIgnoreCase);

		Assert.AreNotEqual(0, result);
		Assert.AreNotEqual(6551, result);
	}

	[TestMethod]
	public void GenerateHashCode_SameItems_ReturnsSameHash()
	{
		var list = new List<string> { "one", "two", "three" };
		var collection1 = new ReadOnlyCollection<string>(list);
		var collection2 = new ReadOnlyCollection<string>(new List<string>(list));

		var hash1 = collection1.GenerateHashCode();
		var hash2 = collection2.GenerateHashCode();

		Assert.AreEqual(hash1, hash2);
	}

	[TestMethod]
	public void GenerateHashCode_DifferentItems_ReturnsDifferentHash()
	{
		var collection1 = new ReadOnlyCollection<string>(new List<string> { "one", "two" });
		var collection2 = new ReadOnlyCollection<string>(new List<string> { "three", "four" });

		var hash1 = collection1.GenerateHashCode();
		var hash2 = collection2.GenerateHashCode();

		Assert.AreNotEqual(hash1, hash2);
	}

	[TestMethod]
	public void GenerateHashCode_WithNullItems_SkipsNulls()
	{
		var collection = new ReadOnlyCollection<string>(new List<string> { "one", null, "three" });

		var result = collection.GenerateHashCode();

		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void GenerateHashCode_AllNullItems_ReturnsBaseHash()
	{
		var collection = new ReadOnlyCollection<string>(new List<string> { null, null, null });

		var result = collection.GenerateHashCode();

		Assert.AreEqual(6551, result);
	}

	// ========================
	// TryGetValue Tests
	// ========================

	[TestMethod]
	public void TryGetValue_ValidIndex_ReturnsTrueAndValue()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.TryGetValue(0, out var value);

		Assert.IsTrue(result);
		Assert.IsNotNull(value);
		Assert.AreEqual(collection.ElementAt(0), value);
	}

	[TestMethod]
	public void TryGetValue_LastIndex_ReturnsTrueAndLastElement()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.TryGetValue(collection.Count - 1, out var value);

		Assert.IsTrue(result);
		Assert.IsNotNull(value);
		Assert.AreEqual(collection.ElementAt(collection.Count - 1), value);
	}

	[TestMethod]
	public void TryGetValue_NegativeIndex_ReturnsFalseAndDefault()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.TryGetValue(-1, out var value);

		Assert.IsFalse(result);
		Assert.IsNull(value);
	}

	[TestMethod]
	public void TryGetValue_IndexEqualToCount_ReturnsFalseAndDefault()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.TryGetValue(collection.Count, out var value);

		Assert.IsFalse(result);
		Assert.IsNull(value);
	}

	[TestMethod]
	public void TryGetValue_IndexGreaterThanCount_ReturnsFalseAndDefault()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.TryGetValue(collection.Count + 100, out var value);

		Assert.IsFalse(result);
		Assert.IsNull(value);
	}

	[TestMethod]
	public void TryGetValue_EmptyCollection_ReturnsFalse()
	{
		var collection = new ReadOnlyCollection<Person>(new List<Person>());

		var result = collection.TryGetValue(0, out var value);

		Assert.IsFalse(result);
		Assert.IsNull(value);
	}

	// ========================
	// GetValueOrDefault Tests
	// ========================

	[TestMethod]
	public void GetValueOrDefault_ValidIndex_ReturnsElement()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.GetValueOrDefault(0);

		Assert.IsNotNull(result);
		Assert.AreEqual(collection.ElementAt(0), result);
	}

	[TestMethod]
	public void GetValueOrDefault_LastIndex_ReturnsLastElement()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.GetValueOrDefault(collection.Count - 1);

		Assert.IsNotNull(result);
		Assert.AreEqual(collection.ElementAt(collection.Count - 1), result);
	}

	[TestMethod]
	public void GetValueOrDefault_NegativeIndex_ReturnsDefault()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.GetValueOrDefault(-1);

		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValueOrDefault_IndexEqualToCount_ReturnsDefault()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.GetValueOrDefault(collection.Count);

		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValueOrDefault_IndexGreaterThanCount_ReturnsDefault()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		var result = collection.GetValueOrDefault(collection.Count + 100);

		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValueOrDefault_InvalidIndex_WithExplicitDefault_ReturnsExplicitDefault()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);
		var defaultPerson = RandomData.GeneratePerson<Person>();

		var result = collection.GetValueOrDefault(-1, defaultPerson);

		Assert.IsNotNull(result);
		Assert.AreEqual(defaultPerson, result);
	}

	[TestMethod]
	public void GetValueOrDefault_ValidIndex_WithExplicitDefault_ReturnsElement()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);
		var defaultPerson = RandomData.GeneratePerson<Person>();

		var result = collection.GetValueOrDefault(0, defaultPerson);

		Assert.IsNotNull(result);
		Assert.AreEqual(collection.ElementAt(0), result);
		Assert.AreNotEqual(defaultPerson, result);
	}

	[TestMethod]
	public void GetValueOrDefault_EmptyCollection_ReturnsDefault()
	{
		var collection = new ReadOnlyCollection<Person>(new List<Person>());

		var result = collection.GetValueOrDefault(0);

		Assert.IsNull(result);
	}

	// ========================
	// IsNotEmpty Tests
	// ========================

	[TestMethod]
	public void IsNotEmpty_NullPredicate_ThrowsArgumentNullException()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.IsNotEmpty(null));
	}

	[TestMethod]
	public void IsNotEmpty_EmptyCollection_ReturnsFalse()
	{
		var collection = new ReadOnlyCollection<Person>(new List<Person>());

		Assert.IsFalse(collection.IsNotEmpty(p => p.Email is not null));
	}

	[TestMethod]
	public void IsNotEmpty_NonEmptyCollection_MatchingPredicate_ReturnsTrue()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsTrue(collection.IsNotEmpty(p => p.Email is not null));
	}

	[TestMethod]
	public void IsNotEmpty_NonEmptyCollection_NonMatchingPredicate_ReturnsFalse()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsFalse(collection.IsNotEmpty(p => p.Id == "IMPOSSIBLE_ID_VALUE_THAT_DOES_NOT_EXIST"));
	}

}
