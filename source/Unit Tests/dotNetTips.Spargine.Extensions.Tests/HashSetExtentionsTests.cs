// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-26-2026
// ***********************************************************************
// <copyright file="HashSetExtentionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
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
public class HashSetExtentionsTests
{

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToHashSet();
		var person = RandomData.GeneratePerson<Person>();

		people.AddIf(person, true);

		Assert.HasCount(11, people);

		people.AddIf(person, false);

		Assert.HasCount(11, people);
	}

	[TestMethod]
	public void ToConcurrentHashSetTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToHashSet().ToConcurrent();

		Assert.HasCount(10, people);
	}

	[TestMethod]
	public void ToImmutableHashSet_DuplicateElements_ReturnsImmutableHashSetWithUniqueElements()
	{
		// Arrange
		var hashSet = new HashSet<int> { 1, 2, 2, 3, 4, 5 };

		// Act
		var result = hashSet.ToImmutable();

		// Assert
		Assert.HasCount(5, result);
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3, 4, 5 }, result.ToList());
	}

	[TestMethod]
	public void ToImmutableHashSet_EmptyHashSet_ReturnsEmptyImmutableHashSet()
	{
		// Arrange
		var hashSet = new HashSet<int>();

		// Act
		var result = hashSet.ToImmutable();

		// Assert
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void ToImmutableHashSet_NullHashSet_ThrowsArgumentNullException()
	{
		// Arrange
		HashSet<int> hashSet = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => hashSet.ToImmutable());
	}

	[TestMethod]
	public void ToImmutableHashSet_ValidHashSet_ReturnsImmutableHashSet()
	{
		// Arrange
		var hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = hashSet.ToImmutable();

		// Assert
		Assert.HasCount(hashSet.Count, result);
		CollectionAssert.AreEquivalent(hashSet.ToList(), result.ToList());
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToHashSet();
		var person = RandomData.GeneratePerson<Person>();
		var personFromCollection = people.Shuffle().First();

		people.Upsert(person);

		Assert.HasCount(11, people);

		people.Upsert(personFromCollection);

		Assert.HasCount(11, people);
	}
}
