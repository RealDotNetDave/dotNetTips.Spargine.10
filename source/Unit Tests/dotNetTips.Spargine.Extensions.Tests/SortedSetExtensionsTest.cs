// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="SortedSetExtensionsTest.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SortedSetExtensionsTest
{

	private const int Count = 10;

	[TestMethod]
	public void IsNotEmpty_WithEmptyCollection_ReturnsFalse()
	{
		var collection = new SortedSet<Person>();

		var result = collection.IsNotEmpty();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmpty_WithNonEmptyCollection_ReturnsTrue()
	{
		var collection = new SortedSet<Person>(RandomData.GeneratePersonRefCollection(Count));

		var result = collection.IsNotEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsNotEmpty_WithNullCollection_ReturnsFalse()
	{
		SortedSet<Person> collection = null;

		var result = collection.IsNotEmpty();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithEmptyCollection_ReturnsFalse()
	{
		var collection = new SortedSet<Person>();
		Func<Person, bool> predicate = p => p.Email.IsNotNull();

		var result = collection.IsNotEmpty(predicate);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithMatchingPredicate_ReturnsTrue()
	{
		var collection = new SortedSet<Person>(RandomData.GeneratePersonRefCollection(Count));
		Func<Person, bool> predicate = p => p.Email.IsNotNull();

		var result = collection.IsNotEmpty(predicate);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithNonMatchingPredicate_ReturnsFalse()
	{
		var collection = new SortedSet<Person>(RandomData.GeneratePersonRefCollection(Count));
		Func<Person, bool> predicate = p => p.Id == "NONEXISTENT_ID_VALUE";

		var result = collection.IsNotEmpty(predicate);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithNullCollection_ReturnsFalse()
	{
		SortedSet<Person> collection = null;
		Func<Person, bool> predicate = p => p.Email.IsNotNull();

		var result = collection.IsNotEmpty(predicate);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithNullCollectionAndNullPredicate_ReturnsFalse()
	{
		SortedSet<Person> collection = null;

		var result = collection.IsNotEmpty(null);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_WithNullPredicate_ThrowsArgumentNullException()
	{
		var collection = new SortedSet<Person>(RandomData.GeneratePersonRefCollection(Count));

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.IsNotEmpty(null));
	}

	[TestMethod]
	public void ToImmutable_WithEmptyCollection_ReturnsEmptyImmutableSortedSet()
	{
		var collection = new SortedSet<Person>();

		var result = collection.ToImmutable();

		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void ToImmutable_WithNullCollection_ThrowsArgumentNullException()
	{
		SortedSet<Person> collection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.ToImmutable());
	}

	[TestMethod]
	public void ToImmutable_WithValidCollection_ReturnsImmutableSortedSet()
	{
		var collection = new SortedSet<Person>(RandomData.GeneratePersonRefCollection(Count));

		var result = collection.ToImmutable();

		Assert.IsNotNull(result);
		Assert.AreEqual(Count, result.Count);
	}

	[TestMethod]
	public void ToImmutableSortedSet_WithNullCollection_ThrowsArgumentNullException()
	{
		SortedSet<Person> collection = null;

#pragma warning disable CS0618 // Type or member is obsolete
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.ToImmutableSortedSet());
#pragma warning restore CS0618 // Type or member is obsolete
	}

	[TestMethod]
	public void ToImmutableSortedSet_WithValidCollection_ReturnsImmutableSortedSet()
	{
		var collection = new SortedSet<Person>(RandomData.GeneratePersonRefCollection(Count));

#pragma warning disable CS0618 // Type or member is obsolete
		var result = collection.ToImmutableSortedSet();
#pragma warning restore CS0618 // Type or member is obsolete

		Assert.IsNotNull(result);
		Assert.AreEqual(Count, result.Count);
	}

}
