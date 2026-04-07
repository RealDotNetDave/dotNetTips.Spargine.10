// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
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

	private const int Count = 10;

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToHashSet();
		var person = RandomData.GeneratePerson<Person>();

		people.AddIf(person, true);

		Assert.HasCount(Count + 1, people);

		people.AddIf(person, false);

		Assert.HasCount(Count + 1, people);
	}

	[TestMethod]
	public void AddIf_NullCollection_ThrowsArgumentNullException()
	{
		HashSet<Person> people = null;
		var person = RandomData.GeneratePerson<Person>();

		Assert.ThrowsExactly<ArgumentNullException>(() => people.AddIf(person, true));
	}

	[TestMethod]
	public void AddIf_NullItem_ThrowsArgumentNullException()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToHashSet();

		Assert.ThrowsExactly<ArgumentNullException>(() => people.AddIf(null, true));
	}

	[TestMethod]
	public void ToConcurrentTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToHashSet().ToConcurrent();

		Assert.HasCount(Count, people);
	}

	[TestMethod]
	public void ToConcurrent_NullCollection_ThrowsArgumentNullException()
	{
		HashSet<Person> people = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => people.ToConcurrent());
	}

	[TestMethod]
	public void ToConcurrent_EmptyHashSet_ReturnsEmptyConcurrentHashSet()
	{
		var hashSet = new HashSet<Person>();

		var result = hashSet.ToConcurrent();

		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void ToConcurrentHashSetTest()
	{
#pragma warning disable CS0618 // Type or member is obsolete
		var people = RandomData.GeneratePersonRefCollection(Count).ToHashSet().ToConcurrentHashSet();
#pragma warning restore CS0618 // Type or member is obsolete

		Assert.HasCount(Count, people);
	}

	[TestMethod]
	public void ToConcurrentHashSet_NullCollection_ThrowsArgumentNullException()
	{
		HashSet<Person> people = null;

#pragma warning disable CS0618 // Type or member is obsolete
		Assert.ThrowsExactly<ArgumentNullException>(() => people.ToConcurrentHashSet());
#pragma warning restore CS0618 // Type or member is obsolete
	}

	[TestMethod]
	public void ToImmutable_DuplicateElements_ReturnsImmutableHashSetWithUniqueElements()
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
	public void ToImmutable_EmptyHashSet_ReturnsEmptyImmutableHashSet()
	{
		// Arrange
		var hashSet = new HashSet<int>();

		// Act
		var result = hashSet.ToImmutable();

		// Assert
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void ToImmutable_NullHashSet_ThrowsArgumentNullException()
	{
		HashSet<int> hashSet = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => hashSet.ToImmutable());
	}

	[TestMethod]
	public void ToImmutable_ValidHashSet_ReturnsImmutableHashSet()
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
	public void ToImmutableHashSetTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToHashSet();

#pragma warning disable CS0618 // Type or member is obsolete
		var result = people.ToImmutableHashSet();
#pragma warning restore CS0618 // Type or member is obsolete

		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void ToImmutableHashSet_NullCollection_ThrowsArgumentNullException()
	{
		HashSet<Person> people = null;

#pragma warning disable CS0618 // Type or member is obsolete
		Assert.ThrowsExactly<ArgumentNullException>(() => people.ToImmutableHashSet());
#pragma warning restore CS0618 // Type or member is obsolete
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToHashSet();
		var person = RandomData.GeneratePerson<Person>();
		var personFromCollection = people.Shuffle().First();

		people.Upsert(person);

		Assert.HasCount(Count + 1, people);

		people.Upsert(personFromCollection);

		Assert.HasCount(Count + 1, people);
	}

	[TestMethod]
	public void Upsert_NullCollection_ThrowsArgumentNullException()
	{
		HashSet<Person> people = null;
		var person = RandomData.GeneratePerson<Person>();

		Assert.ThrowsExactly<ArgumentNullException>(() => people.Upsert(person));
	}

	[TestMethod]
	public void Upsert_NullItem_ThrowsArgumentNullException()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToHashSet();

		Assert.ThrowsExactly<ArgumentNullException>(() => people.Upsert(null));
	}
}
