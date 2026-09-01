// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="ObservableCollectionExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
public class ObservableCollectionExtensionsTests
{

	private const int Count = 256;

	[TestMethod]
	public void IsNotEmpty_NullCollection_ReturnsFalse()
	{
		ObservableCollection<Person> collection = null;

		// Act & Assert
		Assert.IsFalse(collection.IsNotEmpty());
	}

	[TestMethod]
	public void IsNotEmpty_EmptyCollection_ReturnsFalse()
	{
		var collection = new ObservableCollection<Person>();

		// Act & Assert
		Assert.IsFalse(collection.IsNotEmpty());
	}

	[TestMethod]
	public void IsNotEmpty_NonEmptyCollection_ReturnsTrue()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var collection = new ObservableCollection<Person>(people);

		// Act & Assert
		Assert.IsTrue(collection.IsNotEmpty());
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_NullCollection_ReturnsFalse()
	{
		ObservableCollection<Person> collection = null;

		// Act & Assert
		Assert.IsFalse(collection.IsNotEmpty(p => p.Email is not null));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_NullPredicate_ReturnsFalse()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var collection = new ObservableCollection<Person>(people);

		// Act & Assert
		Assert.IsFalse(collection.IsNotEmpty(null));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_EmptyCollection_ReturnsFalse()
	{
		var collection = new ObservableCollection<Person>();

		// Act & Assert
		Assert.IsFalse(collection.IsNotEmpty(p => p.Email is not null));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_MatchingPredicate_ReturnsTrue()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var collection = new ObservableCollection<Person>(people);

		// Act & Assert
		Assert.IsTrue(collection.IsNotEmpty(p => p.Email is not null));
	}

	[TestMethod]
	public void IsNotEmptyWithPredicate_NonMatchingPredicate_ReturnsFalse()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var collection = new ObservableCollection<Person>(people);

		// Act & Assert - use a predicate that no person matches
		Assert.IsFalse(collection.IsNotEmpty(p => p.Id == "IMPOSSIBLE_ID_VALUE_THAT_DOES_NOT_EXIST"));
	}

	[TestMethod]
	public void IsNotEmptyWithCount_NullCollection_ReturnsFalse()
	{
		ObservableCollection<Person> collection = null;

		// Act & Assert
		Assert.IsFalse(collection.IsNotEmpty(Count));
	}

	[TestMethod]
	public void IsNotEmptyWithCount_MatchingCount_ReturnsTrue()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var collection = new ObservableCollection<Person>(people);

		// Act & Assert
		Assert.IsTrue(collection.IsNotEmpty(Count));
	}

	[TestMethod]
	public void IsNotEmptyWithCount_NonMatchingCount_ReturnsFalse()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var collection = new ObservableCollection<Person>(people);

		// Act & Assert
		Assert.IsFalse(collection.IsNotEmpty(Count + 1));
	}

	[TestMethod]
	public void IsNotEmptyWithCount_EmptyCollectionCountZero_ReturnsTrue()
	{
		var collection = new ObservableCollection<Person>();

		// Act & Assert
		Assert.IsTrue(collection.IsNotEmpty(0));
	}

	[TestMethod]
	public void IsNotEmptyWithCount_EmptyCollectionCountNonZero_ReturnsFalse()
	{
		var collection = new ObservableCollection<Person>();

		// Act & Assert
		Assert.IsFalse(collection.IsNotEmpty(Count));
	}

	[TestMethod]
	public void ToObservableCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		// Act & Assert
		Assert.IsTrue(people.ToObservableCollection().IsNotEmpty());
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		// Act & Assert
		Assert.IsTrue(people.ToReadOnlyObservableCollection().IsNotEmpty());
	}

}
