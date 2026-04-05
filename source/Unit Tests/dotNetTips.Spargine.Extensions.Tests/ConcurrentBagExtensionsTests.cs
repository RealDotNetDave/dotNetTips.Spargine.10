// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-05-2026
// ***********************************************************************
// <copyright file="ConcurrentBagExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ConcurrentBagExtensionsTests
{

	[TestMethod]
	public void AddRange_Array_AddsAllItems()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1 };
		var items = new int[] { 2, 3, 4 };

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(4, bag);
		CollectionAssert.Contains(bag.ToList(), 2);
		CollectionAssert.Contains(bag.ToList(), 3);
		CollectionAssert.Contains(bag.ToList(), 4);
	}

	[TestMethod]
	public void AddRange_DuplicateItems_AddsAllDuplicates()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2 };
		var items = new List<int> { 1, 2, 3 };

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(5, bag);
		var bagList = bag.ToList();
		Assert.HasCount(2, bagList.FindAll(x => x == 1));
		Assert.HasCount(2, bagList.FindAll(x => x == 2));
	}

	[TestMethod]
	public void AddRange_EmptyBag_AddsAllItems()
	{
		// Arrange
		var bag = new ConcurrentBag<int>();
		var items = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(5, bag);
		CollectionAssert.AreEquivalent(items, bag.ToList());
	}

	[TestMethod]
	public void AddRange_EmptyCollection_DoesNotModifyBag()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };
		var items = new List<int>();

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(3, bag);
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, bag.ToList());
	}

	[TestMethod]
	public void AddRange_ItemsWithNull_AddsNullValues()
	{
		// Arrange
		var bag = new ConcurrentBag<string> { "a" };
		var items = new List<string> { "b", null, "c" };

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(4, bag);
		CollectionAssert.Contains(bag.ToList(), null);
		CollectionAssert.Contains(bag.ToList(), "b");
		CollectionAssert.Contains(bag.ToList(), "c");
	}

	[TestMethod]
	public void AddRange_LargeCollection_AddsAllItems()
	{
		// Arrange
		var bag = new ConcurrentBag<int>();
		var items = new List<int>();
		for (var i = 0; i < 1000; i++)
		{
			items.Add(i);
		}

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(1000, bag);
		CollectionAssert.AreEquivalent(items, bag.ToList());
	}

	[TestMethod]
	public void AddRange_NullBag_ThrowsArgumentNullException()
	{
		// Arrange
		ConcurrentBag<int> bag = null;
		var items = new List<int> { 1, 2, 3 };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => bag.AddRange(items));
	}

	[TestMethod]
	public void AddRange_NullItems_DoesNotModifyBag()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };
		List<int> items = null;

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(3, bag);
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, bag.ToList());
	}

	[TestMethod]
	public void AddRange_ReferenceTypeItems_AddsAllItemsToBag()
	{
		// Arrange
		var bag = new ConcurrentBag<Person>();
		var people = RandomData.GeneratePersonRefCollection(3);
		var items = new List<Person>(people);

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(3, bag);
		foreach (var person in people)
		{
			CollectionAssert.Contains(bag.ToList(), person);
		}
	}

	[TestMethod]
	public void AddRange_SingleItem_AddsItemToBag()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2 };
		var items = new List<int> { 3 };

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(3, bag);
		CollectionAssert.Contains(bag, 3);
	}

	[TestMethod]
	public void AddRange_StringItems_AddsAllStringsToBag()
	{
		// Arrange
		var word1 = RandomData.GenerateWord(5);
		var word2 = RandomData.GenerateWord(5);
		var word3 = RandomData.GenerateWord(5);
		var bag = new ConcurrentBag<string> { RandomData.GenerateWord(5), RandomData.GenerateWord(5) };
		var items = new List<string> { word1, word2, word3 };

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(5, bag);
		CollectionAssert.Contains(bag.ToList(), word1);
		CollectionAssert.Contains(bag.ToList(), word2);
		CollectionAssert.Contains(bag.ToList(), word3);
	}
	[TestMethod]
	public void AddRange_ValidItems_AddsAllItemsToBag()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };
		var items = new List<int> { 4, 5, 6 };

		// Act
		bag.AddRange(items);

		// Assert
		Assert.HasCount(6, bag);
		CollectionAssert.Contains(bag, 4);
		CollectionAssert.Contains(bag, 5);
		CollectionAssert.Contains(bag, 6);
	}

	[TestMethod]
	public void RemoveRange_AllItemsRemoved_ReturnsEmptyBag()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };
		var items = new List<int> { 1, 2, 3 };

		// Act
		var result = bag.RemoveRange(items);

		// Assert
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void RemoveRange_ItemsNotInBag_ReturnsAllOriginalItems()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };
		var items = new List<int> { 10, 20, 30 };

		// Act
		var result = bag.RemoveRange(items);

		// Assert
		Assert.HasCount(3, result);
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, result.ToList());
	}

	[TestMethod]
	public void RemoveRange_NoItemsToRemove_ReturnsSameBag()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };
		var items = new List<int>();

		// Act
		var result = bag.RemoveRange(items);

		// Assert
		Assert.HasCount(3, result);
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, result.ToList());
	}

	[TestMethod]
	public void RemoveRange_Null_ReturnsSameBag()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };
		List<int> items = null;

		// Act
		var result = bag.RemoveRange(items);

		// Assert
		Assert.HasCount(3, result);
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, result.ToList());
	}

	[TestMethod]
	public void RemoveRange_NullBag_ThrowsArgumentNullException()
	{
		// Arrange
		ConcurrentBag<int> bag = null;
		var items = new List<int> { 1, 2, 3 };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => bag.RemoveRange(items));
	}

	[TestMethod]
	public void RemoveRange_ValidParameters_RemovesItems()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3, 4, 5 };
		var items = new List<int> { 2, 4 };

		// Act
		var result = bag.RemoveRange(items);

		// Assert
		Assert.HasCount(3, result);
		CollectionAssert.DoesNotContain(result, 2);
		CollectionAssert.DoesNotContain(result, 4);
	}

	[TestMethod]
	public void ToList_EmptyBag_ReturnsEmptyList()
	{
		// Arrange
		var bag = new ConcurrentBag<int>();

		// Act
		var result = bag.ToList();

		// Assert
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void ToList_NullBag_ThrowsArgumentNullException()
	{
		// Arrange
		ConcurrentBag<int> bag = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => bag.ToList());
	}

	[TestMethod]
	public void ToList_ValidBag_ReturnsList()
	{
		// Arrange
		var bag = new ConcurrentBag<int> { 1, 2, 3 };

		// Act
		var result = bag.ToList();

		// Assert
		Assert.HasCount(3, result);
		CollectionAssert.Contains(result, 1);
		CollectionAssert.Contains(result, 2);
		CollectionAssert.Contains(result, 3);
	}
}
