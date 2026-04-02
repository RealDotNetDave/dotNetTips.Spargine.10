// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-02-2026
// ***********************************************************************
// <copyright file="ListExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************


//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ListExtensionsTests
{

	private const int Count = 256;

	[TestMethod]
	public void AddFirstAndAddLastCombinedTest()
	{
		// Arrange
		var list = new List<int> { 3, 4 };

		// Act
		list.AddFirst(2);
		list.AddFirst(1);
		list.AddLast(5);
		list.AddLast(6);

		// Assert
		Assert.HasCount(6, list, "List should contain 6 items.");
		Assert.AreEqual(1, list[0], "First item should be 1.");
		Assert.AreEqual(2, list[1], "Second item should be 2.");
		Assert.AreEqual(3, list[2], "Third item should be 3.");
		Assert.AreEqual(4, list[3], "Fourth item should be 4.");
		Assert.AreEqual(5, list[4], "Fifth item should be 5.");
		Assert.AreEqual(6, list[5], "Sixth item should be 6.");
	}

	[TestMethod]
	public void AddFirstMultipleItemsTest()
	{
		// Arrange
		var list = new List<int> { 4, 5, 6 };

		// Act
		list.AddFirst(3);
		list.AddFirst(2);
		list.AddFirst(1);

		// Assert
		Assert.HasCount(6, list, "List should contain 6 items.");
		Assert.AreEqual(1, list[0], "First item should be 1.");
		Assert.AreEqual(2, list[1], "Second item should be 2.");
		Assert.AreEqual(3, list[2], "Third item should be 3.");
		Assert.AreEqual(4, list[3], "Fourth item should be 4.");
	}

	[TestMethod]
	public void AddFirstPerformanceWithLargeListTest()
	{
		// Arrange
		var list = new List<int>(Enumerable.Range(2, 10000));
		var itemToAdd = 1;

		// Act
		list.AddFirst(itemToAdd);

		// Assert
		Assert.HasCount(10001, list, "List should contain 10001 items.");
		Assert.AreEqual(itemToAdd, list[0], "First item should be the added item.");
		Assert.AreEqual(2, list[1], "Second item should be 2.");
	}

	[TestMethod]
	public void AddFirstPreservesOrderTest()
	{
		// Arrange
		var list = new List<string> { "second", "third", "fourth" };
		var itemToAdd = "first";

		// Act
		list.AddFirst(itemToAdd);

		// Assert
		Assert.HasCount(4, list, "List should have 4 items.");
		Assert.AreEqual(itemToAdd, list[0], "First item should be the newly added item.");
		Assert.AreEqual("second", list[1], "Second item should remain in second position.");
		Assert.AreEqual("third", list[2], "Third item should remain in third position.");
		Assert.AreEqual("fourth", list[3], "Fourth item should remain in fourth position.");
	}

	[TestMethod]
	public void AddFirstToEmptyListTest()
	{
		// Arrange
		var list = new List<int>();
		var itemToAdd = 42;

		// Act
		list.AddFirst(itemToAdd);

		// Assert
		Assert.HasCount(1, list, "List should contain exactly 1 item.");
		Assert.AreEqual(itemToAdd, list[0], "The first (and only) item should be the added item.");
	}


	[TestMethod]
	public void AddFirstWithNullListShouldThrowTest()
	{
		// Arrange
		List<int> list = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => list.AddFirst(42),
			"Should throw ArgumentNullException when list is null.");
	}

	[TestMethod]
	public void AddFirstWithReferenceTypeTest()
	{
		// Arrange
		var list = new List<Person>();
		var personToAdd = RandomData.GeneratePersonRefCollection(1).First();

		// Act
		list.AddFirst(personToAdd);

		// Assert
		Assert.HasCount(1, list, "List should contain exactly 1 person.");
		Assert.AreSame(personToAdd, list[0], "The added person should be the same reference.");
	}

	[TestMethod]
	public void AddFirstWithValidItemTest()
	{
		// Arrange
		var list = new List<int> { 2, 3, 4, 5 };
		var itemToAdd = 1;

		// Act
		list.AddFirst(itemToAdd);

		// Assert
		Assert.HasCount(5, list, "List should contain 5 items after adding one.");
		Assert.AreEqual(itemToAdd, list[0], "The first item should be the added item.");
		Assert.AreEqual(2, list[1], "The second item should be 2.");
	}

	[TestMethod]
	public void AddFirstWithValueTypesTest()
	{
		// Arrange
		var list = new List<decimal> { 2.2m, 3.3m, 4.4m };
		var valueToAdd = 1.1m;

		// Act
		list.AddFirst(valueToAdd);

		// Assert
		Assert.HasCount(4, list, "List should contain 4 decimal values.");
		Assert.AreEqual(valueToAdd, list[0], "First value should be the added decimal.");
	}

	[TestMethod]
	public void AddLastMultipleItemsTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };

		// Act
		list.AddLast(4);
		list.AddLast(5);
		list.AddLast(6);

		// Assert
		Assert.HasCount(6, list, "List should contain 6 items.");
		Assert.AreEqual(4, list[3], "Fourth item should be 4.");
		Assert.AreEqual(5, list[4], "Fifth item should be 5.");
		Assert.AreEqual(6, list[5], "Sixth item should be 6.");
	}

	[TestMethod]
	public void AddLastPerformanceWithLargeListTest()
	{
		// Arrange
		var list = new List<int>(Enumerable.Range(1, 10000));
		var itemToAdd = 10001;

		// Act
		list.AddLast(itemToAdd);

		// Assert
		Assert.HasCount(10001, list, "List should contain 10001 items.");
		Assert.AreEqual(itemToAdd, list[10000], "Last item should be the added item.");
	}

	[TestMethod]
	public void AddLastPreservesOrderTest()
	{
		// Arrange
		var list = new List<string> { "first", "second", "third" };
		var itemToAdd = "last";

		// Act
		list.AddLast(itemToAdd);

		// Assert
		Assert.HasCount(4, list, "List should have 4 items.");
		Assert.AreEqual("first", list[0], "First item should remain unchanged.");
		Assert.AreEqual("second", list[1], "Second item should remain unchanged.");
		Assert.AreEqual("third", list[2], "Third item should remain unchanged.");
		Assert.AreEqual(itemToAdd, list[3], "Last item should be the newly added item.");
	}

	[TestMethod]
	public void AddLastToEmptyListTest()
	{
		// Arrange
		var list = new List<int>();
		var itemToAdd = 42;

		// Act
		list.AddLast(itemToAdd);

		// Assert
		Assert.HasCount(1, list, "List should contain exactly 1 item.");
		Assert.AreEqual(itemToAdd, list[0], "The first (and only) item should be the added item.");
	}

	[TestMethod]
	public void AddLastWithNullListShouldThrowTest()
	{
		// Arrange
		List<int> list = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => list.AddLast(42),
			"Should throw ArgumentNullException when list is null.");
	}

	[TestMethod]
	public void AddLastWithReferenceTypeTest()
	{
		// Arrange
		var list = new List<Person>();
		var personToAdd = RandomData.GeneratePersonRefCollection(1).First();

		// Act
		list.AddLast(personToAdd);

		// Assert
		Assert.HasCount(1, list, "List should contain exactly 1 person.");
		Assert.AreSame(personToAdd, list[0], "The added person should be the same reference.");
	}

	[TestMethod]
	public void AddLastWithValidItemTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var itemToAdd = 6;

		// Act
		list.AddLast(itemToAdd);

		// Assert
		Assert.HasCount(6, list, "List should contain 6 items after adding one.");
		Assert.AreEqual(itemToAdd, list[5], "The last item should be the added item.");
	}

	[TestMethod]
	public void AddLastWithValueTypesTest()
	{
		// Arrange
		var list = new List<decimal> { 1.1m, 2.2m, 3.3m };
		var valueToAdd = 4.4m;

		// Act
		list.AddLast(valueToAdd);

		// Assert
		Assert.HasCount(4, list, "List should contain 4 decimal values.");
		Assert.AreEqual(valueToAdd, list[3], "Last value should be the added decimal.");
	}

	[TestMethod]
	public void AddRangeIfNotExists_AddsOnlyNewItems()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new[] { 2, 3, 4, 5 };

		// Act
		list.AddRangeIfNotExists(itemsToAdd);

		// Assert
		Assert.HasCount(5, list);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5 }, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_AllItemsExist_DoesNotModifyList()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new[] { 1, 2, 3 };

		// Act
		list.AddRangeIfNotExists(itemsToAdd);

		// Assert
		Assert.HasCount(3, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_DuplicatesInItemsToAdd_AddsOnlyOnce()
	{
		// Arrange
		var list = new List<int> { 1, 2 };
		var itemsToAdd = new[] { 3, 3, 3, 4, 4 };

		// Act
		list.AddRangeIfNotExists(itemsToAdd);

		// Assert
		Assert.HasCount(4, list);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4 }, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_EmptyItemsCollection_DoesNotModifyList()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		var emptyItems = Array.Empty<int>();

		// Act
		list.AddRangeIfNotExists(emptyItems);

		// Assert
		Assert.HasCount(3, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_EmptyList_AddsAllItems()
	{
		// Arrange
		var list = new List<int>();
		var itemsToAdd = new[] { 1, 2, 3 };

		// Act
		list.AddRangeIfNotExists(itemsToAdd);

		// Assert
		Assert.HasCount(3, list);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_LargeCollection_PerformsEfficiently()
	{
		// Arrange
		var list = Enumerable.Range(1, 1000).ToList();
		var itemsToAdd = Enumerable.Range(500, 1000); // 500-1499, overlaps 500-1000

		// Act
		list.AddRangeIfNotExists(itemsToAdd);

		// Assert
		Assert.HasCount(1499, list);
		Assert.IsTrue(list.Contains(1));
		Assert.IsTrue(list.Contains(1499));
	}

	[TestMethod]
	public void AddRangeIfNotExists_NullItems_DoesNotModifyList()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		IEnumerable<int> nullItems = null;

		// Act
		list.AddRangeIfNotExists(nullItems);

		// Assert
		Assert.HasCount(3, list);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_NullList_ThrowsArgumentNullException()
	{
		// Arrange
		List<int> nullList = null;
		var itemsToAdd = new[] { 1, 2, 3 };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullList.AddRangeIfNotExists(itemsToAdd));
	}

	[TestMethod]
	public void AddRangeIfNotExists_PreservesOriginalOrder()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new[] { 4, 5 };

		// Act
		list.AddRangeIfNotExists(itemsToAdd);

		// Assert
		Assert.AreEqual(1, list[0]);
		Assert.AreEqual(2, list[1]);
		Assert.AreEqual(3, list[2]);
		Assert.AreEqual(4, list[3]);
		Assert.AreEqual(5, list[4]);
	}

	[TestMethod]
	public void AddRangeIfNotExists_ReferenceType_AddsOnlyNewItems()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(5).ToList();
		var existingPerson = people.First();
		var newPerson = RandomData.GeneratePerson<Person>();
		var itemsToAdd = new[] { existingPerson, newPerson };

		// Act
		people.AddRangeIfNotExists(itemsToAdd, new PersonEqualityComparer());

		// Assert
		Assert.HasCount(6, people);
	}

	[TestMethod]
	public void AddRangeIfNotExists_SingleItem_AddsIfNotExists()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new[] { 4 };

		// Act
		list.AddRangeIfNotExists(itemsToAdd);

		// Assert
		Assert.HasCount(4, list);
		Assert.IsTrue(list.Contains(4));
	}

	[TestMethod]
	public void AddRangeIfNotExists_SingleItemExists_DoesNotAdd()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new[] { 2 };

		// Act
		list.AddRangeIfNotExists(itemsToAdd);

		// Assert
		Assert.HasCount(3, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_StringsWithOrdinalComparer_IsCaseSensitive()
	{
		// Arrange
		var list = new List<string> { "Apple" };
		var itemsToAdd = new[] { "apple", "APPLE", "Banana" };

		// Act
		list.AddRangeIfNotExists(itemsToAdd, StringComparer.Ordinal);

		// Assert
		Assert.HasCount(4, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_StringsWithOrdinalIgnoreCaseComparer_IgnoresCase()
	{
		// Arrange
		var list = new List<string> { "Apple" };
		var itemsToAdd = new[] { "apple", "APPLE", "Banana" };

		// Act
		list.AddRangeIfNotExists(itemsToAdd, StringComparer.OrdinalIgnoreCase);

		// Assert
		Assert.HasCount(2, list);
		Assert.IsTrue(list.Contains("Apple"));
		Assert.IsTrue(list.Contains("Banana"));
	}

	[TestMethod]
	public void AddRangeIfNotExists_WithCustomComparer_UsesComparer()
	{
		// Arrange
		var list = new List<string> { "Alice", "Bob" };
		var itemsToAdd = new[] { "alice", "CHARLIE", "bob" };

		// Act
		list.AddRangeIfNotExists(itemsToAdd, StringComparer.OrdinalIgnoreCase);

		// Assert
		Assert.HasCount(3, list);
		Assert.IsTrue(list.Contains("Alice"));
		Assert.IsTrue(list.Contains("Bob"));
		Assert.IsTrue(list.Contains("CHARLIE"));
	}

	[TestMethod]
	public void AddRangeIfNotExists_WithDefaultComparer_IsCaseSensitive()
	{
		// Arrange
		var list = new List<string> { "Alice", "Bob" };
		var itemsToAdd = new[] { "alice", "ALICE", "bob" };

		// Act
		list.AddRangeIfNotExists(itemsToAdd, null);

		// Assert
		Assert.HasCount(5, list);
		Assert.IsTrue(list.Contains("Alice"));
		Assert.IsTrue(list.Contains("alice"));
		Assert.IsTrue(list.Contains("ALICE"));
	}

	[TestMethod]
	public void AddRangeIfNotExists_WithNullComparer_UsesDefaultComparer()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new[] { 3, 4, 5 };

		// Act
		list.AddRangeIfNotExists(itemsToAdd, null);

		// Assert
		Assert.HasCount(5, list);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5 }, list);
	}

	[TestMethod]
	public void AddRangeIfNotExists_WithPersonComparer_AddsOnlyUniquePeople()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(3).ToList();
		var originalCount = people.Count;
		var duplicatePerson = people.First();
		var newPerson = RandomData.GeneratePerson<Person>();
		var itemsToAdd = new[] { duplicatePerson, newPerson };

		// Act
		people.AddRangeIfNotExists(itemsToAdd, new PersonEqualityComparer());

		// Assert
		Assert.HasCount(originalCount + 1, people);
	}

	[TestMethod]
	public void AddRangeIfNotExistsLargeComparerTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();
		var itemsToAdd = RandomData.GeneratePersonRefCollection(10).ToList();

		list.AddRangeIfNotExists(itemsToAdd, new PersonEqualityComparerByEmail());

		Assert.HasCount(1010, list);
	}

	[TestMethod]
	public void AddRangeIfNotExistsLargeTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();
		var itemsToAdd = RandomData.GeneratePersonRefCollection(10).ToList();

		list.AddRangeIfNotExists(itemsToAdd);

		Assert.HasCount(1010, list);
	}

	[TestMethod]
	public void AddRangeIfNotExistsTest()
	{
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new List<int> { 3, 4, 5 };

		list.AddRangeIfNotExists(itemsToAdd);

		Assert.HasCount(5, list);
		Assert.Contains(1, list);
		Assert.Contains(2, list);
		Assert.Contains(3, list);
		Assert.Contains(4, list);
		Assert.Contains(5, list);
	}

	[TestMethod]
	public void AsReadOnlySpanTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var span = list.AsReadOnlySpan();

		// Assert
		Assert.AreEqual(list.Count, span.Length, "The length of the span should match the count of the list.");

		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], span[i], $"The element at index {i} should match between the list and the span.");
		}
	}


	[TestMethod]
	public void AsSpanTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.AsSpan();

		Assert.IsTrue(result.IsEmpty is false);
	}
	[TestMethod]
	public void ClearNullListTest()
	{
		var people = RandomData.GeneratePersonRefCollection(RandomData.GenerateInteger(10, Count)).ToList();

		people.Add(null);

		Assert.IsTrue(people.ClearNulls());

		Assert.IsFalse(people.ClearNulls());

		Assert.IsFalse(new List<Person>(10).ClearNulls());
	}

	[TestMethod]
	public void ClearNulls_WithAllNulls_ReturnsTrue()
	{
		// Arrange
		var collection = new List<string> { null, null, null };

		// Act
		var result = collection.ClearNulls();

		// Assert
		Assert.IsTrue(result, "Expected true when clearing nulls from a collection with all nulls.");
		Assert.IsEmpty(collection, "Expected the collection count to be zero after clearing all nulls.");
	}

	[TestMethod]
	public void ClearNulls_WithEmptyCollection_ReturnsFalse()
	{
		// Arrange
		var collection = new List<string>();

		// Act
		var result = collection.ClearNulls();

		// Assert
		Assert.IsFalse(result, "Expected false when clearing nulls from an empty collection.");
		Assert.IsEmpty(collection, "Expected the collection count to remain zero.");
	}

	[TestMethod]
	public void ClearNulls_WithNoNulls_ReturnsFalse()
	{
		// Arrange
		var collection = new List<string> { "item1", "item2", "item3" };

		// Act
		var result = collection.ClearNulls();

		// Assert
		Assert.IsFalse(result, "Expected false when clearing nulls from a collection with no nulls.");
		Assert.HasCount(3, collection, "Expected the collection count to remain unchanged.");
	}

	[TestMethod]
	public void ClearNulls_WithNullCollection_ReturnsFalse()
	{
		// Arrange
		List<string> nullCollection = null;

		// Act
		var result = nullCollection.ClearNulls();

		// Assert
		Assert.IsFalse(result, "Expected false when clearing nulls from a null collection.");
	}

	[TestMethod]
	public void ClearNulls_WithNulls_ReturnsTrue()
	{
		// Arrange
		var collection = new List<string> { "item1", null, "item2", null, "item3" };

		// Act
		var result = collection.ClearNulls();

		// Assert
		Assert.IsTrue(result, "Expected true when clearing nulls from a collection with nulls.");
		Assert.HasCount(3, collection, "Expected the collection count to be reduced by the number of nulls.");
		Assert.DoesNotContain((string s) => s is null, collection, "Expected the collection to no longer contain nulls.");
	}

	[TestMethod]
	public void FastShuffleTest()
	{
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var originalList = new List<int>(list);

		list = list.FastShuffle();

		Assert.HasCount(5, list);
		Assert.Contains(1, list);
		Assert.Contains(2, list);
		Assert.Contains(3, list);
		Assert.Contains(4, list);
		Assert.Contains(5, list);
		CollectionAssert.AreNotEqual(originalList, list);
	}

	[TestMethod]
	public void GenerateHashCodeForRecord()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count).ToList();

		var result = people.GenerateHashCode();

		Assert.AreNotEqual(0, result, "Hash code should be greater than zero for a non-empty list of records.");
	}

	[TestMethod]
	public void GenerateHashCodeWithDifferentListsTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 5, 4, 3, 2, 1 };

		// Act
		var hashCode1 = list1.GenerateHashCode();
		var hashCode2 = list2.GenerateHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2, "Hash codes should not be equal for lists with different contents.");
	}


	[TestMethod]
	public void GenerateHashCodeWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var hashCode = list.GenerateHashCode();

		// Assert
		Assert.AreNotEqual(0, hashCode, "Hash code should not be zero for an empty list.");
	}


	[TestMethod]
	public void GenerateHashCodeWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var hashCode1 = list.GenerateHashCode();
		var hashCode2 = list.GenerateHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2, "Hash codes should be equal for the same list contents.");
	}

	[TestMethod]
	public void GenerateHashCodeWithNullListTest()
	{
		// Arrange
		List<int> nullList = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => nullList.GenerateHashCode(), "Expected an ArgumentNullException for a null list.");
	}

	[TestMethod]
	public void IndexAtLooped_EightElements_PowerOfTwo_WrapsCorrectly()
	{
		// Arrange - power of two (8 elements)
		var list = Enumerable.Range(0, 8).ToList();

		// Act & Assert
		Assert.AreEqual(0, list.IndexAtLooped(0));
		Assert.AreEqual(0, list.IndexAtLooped(8));
		Assert.AreEqual(0, list.IndexAtLooped(16));
		Assert.AreEqual(3, list.IndexAtLooped(11)); // 11 & 7 = 3
		Assert.AreEqual(7, list.IndexAtLooped(-1));
		Assert.AreEqual(0, list.IndexAtLooped(-8));
	}

	[TestMethod]
	public void IndexAtLooped_EmptyList_ThrowsArgumentException()
	{
		// Arrange
		var emptyList = new List<int>();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentException>(() => emptyList.IndexAtLooped(0));
	}

	[TestMethod]
	public void IndexAtLooped_IndexEqualsCount_WrapsToFirstElement()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30, 40, 50 };

		// Act
		var result = list.IndexAtLooped(5);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void IndexAtLooped_IndexGreaterThanCount_WrapsCorrectly()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30 };

		// Act
		var result = list.IndexAtLooped(7); // 7 % 3 = 1

		// Assert
		Assert.AreEqual(20, result);
	}

	[TestMethod]
	public void IndexAtLooped_IndexZero_ReturnsFirstElement()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30 };

		// Act
		var result = list.IndexAtLooped(0);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void IndexAtLooped_LargePositiveIndex_WrapsCorrectly()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30, 40, 50 };

		// Act
		var result = list.IndexAtLooped(1000); // 1000 % 5 = 0

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void IndexAtLooped_LargePositiveIndexPlusOffset_WrapsCorrectly()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30, 40, 50 };

		// Act
		var result = list.IndexAtLooped(1003); // 1003 % 5 = 3

		// Assert
		Assert.AreEqual(40, result);
	}

	[TestMethod]
	public void IndexAtLooped_LastValidIndex_ReturnsLastElement()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30, 40, 50 };

		// Act
		var result = list.IndexAtLooped(4);

		// Assert
		Assert.AreEqual(50, result);
	}

	[TestMethod]
	public void IndexAtLooped_NegativeIndex_WrapsFromEnd()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30, 40, 50 };

		// Act
		var result = list.IndexAtLooped(-1);

		// Assert
		Assert.AreEqual(50, result);
	}

	[TestMethod]
	public void IndexAtLooped_NegativeIndexTwo_WrapsFromEnd()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30, 40, 50 };

		// Act
		var result = list.IndexAtLooped(-2);

		// Assert
		Assert.AreEqual(40, result);
	}

	[TestMethod]
	public void IndexAtLooped_NonPowerOfTwoCount_WrapsCorrectly()
	{
		// Arrange - non-power of two (5 elements)
		var list = new List<int> { 10, 20, 30, 40, 50 };

		// Act & Assert
		Assert.AreEqual(10, list.IndexAtLooped(0));
		Assert.AreEqual(10, list.IndexAtLooped(5));  // Wraps
		Assert.AreEqual(20, list.IndexAtLooped(6));  // Wraps
		Assert.AreEqual(10, list.IndexAtLooped(10)); // Wraps twice
		Assert.AreEqual(50, list.IndexAtLooped(-1)); // Negative wrap
		Assert.AreEqual(10, list.IndexAtLooped(-5)); // Negative wrap full cycle
	}

	[TestMethod]
	public void IndexAtLooped_NullList_ThrowsArgumentNullException()
	{
		// Arrange
		List<int> nullList = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullList.IndexAtLooped(0));
	}

	[TestMethod]
	public void IndexAtLooped_PowerOfTwoCount_WrapsCorrectly()
	{
		// Arrange - power of two (4 elements)
		var list = new List<int> { 10, 20, 30, 40 };

		// Act & Assert
		Assert.AreEqual(10, list.IndexAtLooped(0));
		Assert.AreEqual(20, list.IndexAtLooped(1));
		Assert.AreEqual(30, list.IndexAtLooped(2));
		Assert.AreEqual(40, list.IndexAtLooped(3));
		Assert.AreEqual(10, list.IndexAtLooped(4));  // Wraps
		Assert.AreEqual(30, list.IndexAtLooped(6));  // Wraps
		Assert.AreEqual(40, list.IndexAtLooped(-1)); // Negative wrap
		Assert.AreEqual(30, list.IndexAtLooped(-2)); // Negative wrap
	}

	[TestMethod]
	public void IndexAtLooped_ReferenceType_NegativeIndex_WrapsCorrectly()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(5).ToList();

		// Act
		var result = people.IndexAtLooped(-1);

		// Assert
		Assert.AreEqual(people[4].Id, result.Id);
	}

	[TestMethod]
	public void IndexAtLooped_ReferenceType_ReturnsCorrectElement()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(5).ToList();

		// Act
		var result = people.IndexAtLooped(2);

		// Assert
		Assert.AreEqual(people[2].Id, result.Id);
	}

	[TestMethod]
	public void IndexAtLooped_SingleElement_AlwaysReturnsSameElement()
	{
		// Arrange
		var list = new List<int> { 42 };

		// Act & Assert
		Assert.AreEqual(42, list.IndexAtLooped(0));
		Assert.AreEqual(42, list.IndexAtLooped(1));
		Assert.AreEqual(42, list.IndexAtLooped(100));
		Assert.AreEqual(42, list.IndexAtLooped(-1));
		Assert.AreEqual(42, list.IndexAtLooped(-100));
	}

	[TestMethod]
	public void IndexAtLooped_StringList_WrapsCorrectly()
	{
		// Arrange
		var strings = new List<string> { "a", "b", "c", "d" };

		// Act & Assert
		Assert.AreEqual("a", strings.IndexAtLooped(0));
		Assert.AreEqual("a", strings.IndexAtLooped(4));
		Assert.AreEqual("b", strings.IndexAtLooped(5));
		Assert.AreEqual("d", strings.IndexAtLooped(-1));
		Assert.AreEqual("c", strings.IndexAtLooped(-2));
	}

	[TestMethod]
	public void IndexAtLooped_ThreeElements_NonPowerOfTwo_WrapsCorrectly()
	{
		// Arrange - non-power of two (3 elements)
		var list = new List<int> { 10, 20, 30 };

		// Act & Assert
		Assert.AreEqual(10, list.IndexAtLooped(0));
		Assert.AreEqual(10, list.IndexAtLooped(3));
		Assert.AreEqual(20, list.IndexAtLooped(4));
		Assert.AreEqual(30, list.IndexAtLooped(-1));
		Assert.AreEqual(20, list.IndexAtLooped(-2));
		Assert.AreEqual(10, list.IndexAtLooped(-3));
	}

	[TestMethod]
	public void IndexAtLooped_TwoElements_WrapsCorrectly()
	{
		// Arrange - power of two (2 elements)
		var list = new List<int> { 100, 200 };

		// Act & Assert
		Assert.AreEqual(100, list.IndexAtLooped(0));
		Assert.AreEqual(200, list.IndexAtLooped(1));
		Assert.AreEqual(100, list.IndexAtLooped(2));
		Assert.AreEqual(200, list.IndexAtLooped(3));
		Assert.AreEqual(200, list.IndexAtLooped(-1));
		Assert.AreEqual(100, list.IndexAtLooped(-2));
	}

	[TestMethod]
	public void IndexAtLooped_ValidIndex_ReturnsCorrectElement()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30, 40, 50 };

		// Act
		var result = list.IndexAtLooped(2);

		// Assert
		Assert.AreEqual(30, result);
	}

	[TestMethod]
	public void IndexAtLoopedWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => list.IndexAtLooped(0), "Expected an ArgumentOutOfRangeException for an empty list.");
	}

	[TestMethod]
	public void IndexAtLoopedWithIndexGreaterThanListCountTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var expectedIndex5 = 1; // Looped back to the start
		var expectedIndex6 = 2; // Looped back to the start + 1

		// Act
		var resultIndex5 = list.IndexAtLooped(5);
		var resultIndex6 = list.IndexAtLooped(6);

		// Assert
		Assert.AreEqual(expectedIndex5, resultIndex5, "The item at index 5 (looped) should be 1.");
		Assert.AreEqual(expectedIndex6, resultIndex6, "The item at index 6 (looped) should be 2.");
	}

	[TestMethod]
	public void IndexAtLoopedWithNegativeIndexTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var expectedIndexMinus1 = 5; // Looped to the end
		var expectedIndexMinus2 = 4; // Looped to the end - 1

		// Act
		var resultIndexMinus1 = list.IndexAtLooped(-1);
		var resultIndexMinus2 = list.IndexAtLooped(-2);

		// Assert
		Assert.AreEqual(expectedIndexMinus1, resultIndexMinus1, "The item at index -1 (looped) should be 5.");
		Assert.AreEqual(expectedIndexMinus2, resultIndexMinus2, "The item at index -2 (looped) should be 4.");
	}

	[TestMethod]
	public void IndexAtLoopedWithValidIndexTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var expectedIndex0 = 1;
		var expectedIndex4 = 5;

		// Act
		var resultIndex0 = list.IndexAtLooped(0);
		var resultIndex4 = list.IndexAtLooped(4);

		// Assert
		Assert.AreEqual(expectedIndex0, resultIndex0, "The item at index 0 should be 1.");
		Assert.AreEqual(expectedIndex4, resultIndex4, "The item at index 4 should be 5.");
	}

	[TestMethod]
	public void IsEqualTo_BothListsNull_ReturnsFalse()
	{
		// Arrange
		List<int> list1 = null;
		List<int> list2 = null;

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_DecimalLists_Equal_ReturnsTrue()
	{
		// Arrange
		var list1 = new List<decimal> { 1.1m, 2.2m, 3.3m };
		var list2 = new List<decimal> { 1.1m, 2.2m, 3.3m };

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_DifferentCounts_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 1, 2, 3 };

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_DifferentOrder_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3 };
		var list2 = new List<int> { 3, 2, 1 };

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 1, 2, 3, 4, 6 };

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_DoubleLists_Equal_ReturnsTrue()
	{
		// Arrange
		var list1 = new List<double> { 1.1, 2.2, 3.3 };
		var list2 = new List<double> { 1.1, 2.2, 3.3 };

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_EmptyLists_ReturnsTrue()
	{
		// Arrange
		var list1 = new List<int>();
		var list2 = new List<int>();

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_EqualLists_ReturnsTrue()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 1, 2, 3, 4, 5 };

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_LargeLists_DifferentFirstElement_ReturnsFalse()
	{
		// Arrange
		var list1 = Enumerable.Range(1, 10000).ToList();
		var list2 = Enumerable.Range(1, 10000).ToList();
		list2[0] = 99999; // Change first element

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_LargeLists_DifferentLastElement_ReturnsFalse()
	{
		// Arrange
		var list1 = Enumerable.Range(1, 10000).ToList();
		var list2 = Enumerable.Range(1, 10000).ToList();
		list2[9999] = 99999; // Change last element

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_LargeLists_Equal_ReturnsTrue()
	{
		// Arrange
		var list1 = Enumerable.Range(1, 10000).ToList();
		var list2 = Enumerable.Range(1, 10000).ToList();

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_NullableValueType_DifferentNullPosition_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<int?> { 1, null, 3, 4, 5 };
		var list2 = new List<int?> { 1, 2, null, 4, 5 };

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_NullableValueType_Equal_ReturnsTrue()
	{
		// Arrange
		var list1 = new List<int?> { 1, null, 3, null, 5 };
		var list2 = new List<int?> { 1, null, 3, null, 5 };

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_NullComparisonList_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3 };
		List<int> nullList = null;

		// Assert
		Assert.IsFalse(list1.IsEqualTo(nullList));
	}

	[TestMethod]
	public void IsEqualTo_NullSourceList_ReturnsFalse()
	{
		// Arrange
		List<int> nullList = null;
		var list2 = new List<int> { 1, 2, 3 };

		// Assert
		Assert.IsFalse(nullList.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_OneEmptyOneNot_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<int>();
		var list2 = new List<int> { 1, 2, 3 };

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_ReferenceType_DifferentObjects_ReturnsFalse()
	{
		// Arrange
		var person1 = new Person { Id = "1234567890", FirstName = "John", LastName = "Doe" };
		var person2 = new Person { Id = "1234567891", FirstName = "John", LastName = "Doe" };
		var list1 = new List<Person> { person1 };
		var list2 = new List<Person> { person2 }; // Different reference

		// Assert - Default equality comparer uses reference equality for Person
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_ReferenceType_EqualObjects_ReturnsTrue()
	{
		// Arrange
		var person1 = new Person { Id = "1234567890", FirstName = "John", LastName = "Doe" };
		var list1 = new List<Person> { person1 };
		var list2 = new List<Person> { person1 }; // Same reference

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_SameDuplicatesDifferentCount_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 2, 3, 3, 3 };
		var list2 = new List<int> { 1, 2, 2, 3, 3 }; // One less 3

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_SameReference_ReturnsTrue()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Assert
		Assert.IsTrue(list.IsEqualTo(list));
	}

	[TestMethod]
	public void IsEqualTo_SingleElementDifferent_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<int> { 42 };
		var list2 = new List<int> { 99 };

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_SingleElementEqual_ReturnsTrue()
	{
		// Arrange
		var list1 = new List<int> { 42 };
		var list2 = new List<int> { 42 };

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_StringLists_DifferentCase_ReturnsFalse()
	{
		// Arrange
		var list1 = new List<string> { "Apple", "Banana", "Cherry" };
		var list2 = new List<string> { "apple", "banana", "cherry" };

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_StringLists_Equal_ReturnsTrue()
	{
		// Arrange
		var list1 = new List<string> { "apple", "banana", "cherry" };
		var list2 = new List<string> { "apple", "banana", "cherry" };

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualTo_WithDuplicates_Equal_ReturnsTrue()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 2, 3, 3, 3 };
		var list2 = new List<int> { 1, 2, 2, 3, 3, 3 };

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualToNullFirstListTest()
	{
		// Arrange
		List<int> list1 = null;
		var list2 = new List<int>();

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualToNullSecondListTest()
	{
		// Arrange
		var list1 = new List<int>();
		List<int> list2 = null;

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2));
	}

	[TestMethod]
	public void IsEqualToWithBothEmptyListsTest()
	{
		// Arrange
		var list1 = new List<int>();
		var list2 = new List<int>();

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2), "Two empty lists should be considered equal.");
	}

	[TestMethod]
	public void IsEqualToWithDifferentListsTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 5, 4, 3, 2, 1 };

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2), "Lists with different elements should not be considered equal.");
	}

	[TestMethod]
	public void IsEqualToWithEqualListsTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 1, 2, 3, 4, 5 };

		// Assert
		Assert.IsTrue(list1.IsEqualTo(list2), "Lists with identical elements should be considered equal.");
	}


	[TestMethod]
	public void IsEqualToWithOneEmptyListTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int>();

		// Assert
		Assert.IsFalse(list1.IsEqualTo(list2), "A non-empty list and an empty list should not be considered equal.");
	}

	[TestMethod]
	public void IsNotEmptyCountTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();

		Assert.IsTrue(list.IsNotEmpty(1000));
	}

	[TestMethod]
	public void IsNotEmptyPredicateTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();

		Assert.IsTrue(list.IsNotEmpty(p => p.Addresses.Count > 1));
	}

	[TestMethod]
	public void IsNotEmptyTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();

		Assert.IsTrue(list.IsNotEmpty());
	}


	[TestMethod]
	public void ListHashCodeTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		var result = people.GenerateHashCode();

		Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

		result = people.ToArray().GenerateHashCode();

		Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

		result = people.ToReadOnlyCollection().GenerateHashCode();

		Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));
	}

	[TestMethod]
	public void PerformAction_ComplexAction_ExecutesCorrectly()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		var results = new Dictionary<int, int>();

		// Act
		list.PerformAction(item => results[item] = item * item);

		// Assert
		Assert.HasCount(3, results);
		Assert.AreEqual(1, results[1]);
		Assert.AreEqual(4, results[2]);
		Assert.AreEqual(9, results[3]);
	}

	[TestMethod]
	public void PerformAction_DecimalList_CalculatesTotal()
	{
		// Arrange
		var list = new List<decimal> { 1.5m, 2.5m, 3.5m };
		var total = 0m;

		// Act
		list.PerformAction(item => total += item);

		// Assert
		Assert.AreEqual(7.5m, total);
	}

	[TestMethod]
	public void PerformAction_DoesNotModifyOriginalList()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var originalCount = list.Count;

		// Act
		list.PerformAction(item => { /* no-op */ });

		// Assert
		Assert.AreEqual(originalCount, list.Count);
		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, list);
	}

	[TestMethod]
	public void PerformAction_EmptyList_DoesNotExecuteAction()
	{
		// Arrange
		var list = new List<int>();
		var actionExecuted = false;

		// Act
		list.PerformAction(item => actionExecuted = true);

		// Assert
		Assert.IsFalse(actionExecuted);
	}

	[TestMethod]
	public void PerformAction_ExecutesActionOnEachItem()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var processedItems = new List<int>();

		// Act
		list.PerformAction(item => processedItems.Add(item));

		// Assert
		Assert.HasCount(5, processedItems);
		CollectionAssert.AreEqual(list, processedItems);
	}

	[TestMethod]
	public void PerformAction_LargeList_ExecutesOnAllItems()
	{
		// Arrange
		var list = Enumerable.Range(1, 10000).ToList();
		var executionCount = 0;

		// Act
		list.PerformAction(item => executionCount++);

		// Assert
		Assert.AreEqual(10000, executionCount);
	}

	[TestMethod]
	public void PerformAction_ModifiesExternalState()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var sum = 0;

		// Act
		list.PerformAction(item => sum += item);

		// Assert
		Assert.AreEqual(15, sum);
	}

	[TestMethod]
	public void PerformAction_NullableType_HandlesNullItems()
	{
		// Arrange
		var list = new List<string> { "a", null, "b", null, "c" };
		var nonNullCount = 0;
		var nullCount = 0;

		// Act
		list.PerformAction(item =>
		{
			if (item is null)
			{
				nullCount++;
			}
			else
			{
				nonNullCount++;
			}
		});

		// Assert
		Assert.AreEqual(3, nonNullCount);
		Assert.AreEqual(2, nullCount);
	}

	[TestMethod]
	public void PerformAction_NullAction_ThrowsArgumentNullException()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };
		Action<int> nullAction = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.PerformAction(nullAction));
	}

	[TestMethod]
	public void PerformAction_NullList_ThrowsArgumentNullException()
	{
		// Arrange
		List<int> nullList = null;
		Action<int> action = item => { };

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullList.PerformAction(action));
	}

	[TestMethod]
	public void PerformAction_PreservesOrder()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var processedOrder = new List<int>();

		// Act
		list.PerformAction(item => processedOrder.Add(item));

		// Assert
		CollectionAssert.AreEqual(list, processedOrder);
	}

	[TestMethod]
	public void PerformAction_ReferenceType_CanModifyProperties()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(5).ToList();
		var newLastName = "TestLastName";

		// Act
		people.PerformAction(person => person.LastName = newLastName);

		// Assert
		Assert.IsTrue(people.All(p => p.LastName == newLastName));
	}

	[TestMethod]
	public void PerformAction_SingleItem_ExecutesOnce()
	{
		// Arrange
		var list = new List<int> { 42 };
		var executionCount = 0;

		// Act
		list.PerformAction(item => executionCount++);

		// Assert
		Assert.AreEqual(1, executionCount);
	}

	[TestMethod]
	public void PerformAction_StringList_ExecutesActionOnEachString()
	{
		// Arrange
		var list = new List<string> { "apple", "banana", "cherry" };
		var concatenated = string.Empty;

		// Act
		list.PerformAction(item => concatenated += item);

		// Assert
		Assert.AreEqual("applebananacherry", concatenated);
	}

	[TestMethod]
	public void PerformAction_WithConditionalLogic_ExecutesCorrectly()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		var evenNumbers = new List<int>();

		// Act
		list.PerformAction(item =>
		{
			if (item % 2 == 0)
			{
				evenNumbers.Add(item);
			}
		});

		// Assert
		Assert.HasCount(5, evenNumbers);
		CollectionAssert.AreEquivalent(new[] { 2, 4, 6, 8, 10 }, evenNumbers);
	}

	[TestMethod]
	public void PerformAction_WithExternalCounter_TracksExecutions()
	{
		// Arrange
		var list = new List<int> { 10, 20, 30 };
		var counter = 0;
		var maxValue = 0;

		// Act
		list.PerformAction(item =>
		{
			counter++;
			if (item > maxValue)
			{
				maxValue = item;
			}
		});

		// Assert
		Assert.AreEqual(3, counter);
		Assert.AreEqual(30, maxValue);
	}

	[TestMethod]
	public void PerformAction_WithIndex_CanTrackPosition()
	{
		// Arrange
		var list = new List<string> { "a", "b", "c" };
		var index = 0;
		var indexedResults = new Dictionary<int, string>();

		// Act
		list.PerformAction(item =>
		{
			indexedResults[index] = item;
			index++;
		});

		// Assert
		Assert.AreEqual("a", indexedResults[0]);
		Assert.AreEqual("b", indexedResults[1]);
		Assert.AreEqual("c", indexedResults[2]);
	}

	[TestMethod]
	public void PerformActionTest()
	{
		var words = RandomData.GenerateWords(10, 10, Count).ToList();
		var sb = new StringBuilder();

		words.PerformAction((word) => _ = sb.Append($"WORD:{word}|"));

		Assert.IsGreaterThan(Count, sb.Length);
	}

	[TestMethod]
	public void PickRandomTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id);

		Assert.IsNotNull(people.PickRandom());
	}

	[TestMethod]
	public void RemoveFirstNullTest()
	{
		var list = RandomData.GeneratePersonRefCollection(10).ToList();

		Assert.IsFalse(list.RemoveFirst(null));
	}

	[TestMethod]
	public void RemoveFirstTest()
	{
		var list = new List<int> { 1, 2, 3, 2, 4 };

		var result = list.RemoveFirst(2);

		Assert.IsTrue(result);
		Assert.HasCount(4, list);
		Assert.AreEqual(1, list[0]);
		Assert.AreEqual(3, list[1]);
		Assert.AreEqual(2, list[2]);
		Assert.AreEqual(4, list[3]);
	}

	[TestMethod]
	public void RemoveLastTest()
	{
		var list = new List<int> { 1, 2, 3, 2, 4 };

		var result = list.RemoveLast(2);

		Assert.IsTrue(result);
		Assert.HasCount(4, list);
		Assert.AreEqual(1, list[0]);
		Assert.AreEqual(2, list[1]);
		Assert.AreEqual(3, list[2]);
		Assert.AreEqual(4, list[3]);
	}

	[TestMethod]
	public void ShuffleImmutableArrayTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToImmutableList();
		List<Person> nullList = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(nullList.Shuffle);

		var shuffledPeople = people.Shuffle();

		Assert.HasCount(shuffledPeople.Count(), people);
	}

	[TestMethod]
	public void SplitTest()
	{
		var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		var result = list.Split(3);

		Assert.HasCount(3, result);
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result[0]);
		CollectionAssert.AreEqual(new List<int> { 4, 5, 6 }, result[1]);
		CollectionAssert.AreEqual(new List<int> { 7, 8, 9 }, result[2]);
	}

	[TestMethod]
	public void ToCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		var result = people.ToCollection();

		Assert.IsNotNull(result);

		Assert.HasCount(Count, result);
	}


	[TestMethod]
	public void ToCollectionWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var result = list.ToCollection();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsInstanceOfType(result, typeof(Collection<int>), "Result should be of type Collection<int>.");
		Assert.IsEmpty(result, "Resulting collection should be empty.");
	}

	[TestMethod]
	public void ToCollectionWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = list.ToCollection();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsInstanceOfType(result, typeof(Collection<int>), "Result should be of type Collection<int>.");
		Assert.HasCount(list.Count, result, "Resulting collection should have the same count as the source list.");

		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], result[i], $"Item at index {i} should be equal in both list and resulting collection.");
		}
	}

	[TestMethod]
	public void ToCollectionWithNullListTest()
	{
		// Arrange
		List<int> list = null;

		// Act
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.ToCollection());
	}


	[TestMethod]
	public void ToDistinctBlockingCollectionCompleteAddingTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3 };

		// Act
		var result = list.ToDistinctBlockingCollection(completeAdding: true);

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsTrue(result.IsAddingCompleted, "Adding should be marked as completed.");
	}

	[TestMethod]
	public void ToDistinctBlockingCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.ToDistinctBlockingCollection(true);

		Assert.IsNotNull(result);

		Assert.HasCount(Count, result);

		Assert.IsTrue(result.IsAddingCompleted);
	}

	[TestMethod]
	public void ToDistinctConcurrentBagTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.ToDistinctConcurrentBag();

		Assert.IsNotNull(result);
		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void ToFastSortedList_WithCustomComparer_ShouldReturnSortedList()
	{
		// Arrange
		var list = new List<string> { "apple", "banana", "cherry" };
		var comparer = Comparer<string>.Create((x, y) => y.CompareTo(x)); // Reverse order

		// Act
		var result = list.ToFastSortedList(comparer);

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(list.Count, result, "Resulting list should have the same count as the source list.");
	}

	[TestMethod]
	public void ToFastSortedList_WithCustomComparer_ShouldUseThatComparer()
	{
		// Arrange
		var list = new List<int> { 5, 3, 1, 4, 2 };
		// Create a custom comparer for descending order
		var descendingComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));

		// Act
		var result = list.ToFastSortedList(descendingComparer);

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(5, result, "Result should have 5 elements.");
		Assert.AreEqual(5, result[0], "First element should be 5 (descending order).");
		Assert.AreEqual(4, result[1], "Second element should be 4.");
		Assert.AreEqual(3, result[2], "Third element should be 3.");
		Assert.AreEqual(2, result[3], "Fourth element should be 2.");
		Assert.AreEqual(1, result[4], "Fifth element should be 1.");
	}

	[TestMethod]
	public void ToFastSortedList_WithEmptyList_ShouldReturnEmptyList()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var result = list.ToFastSortedList();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsEmpty(result, "Resulting list should be empty.");
	}

	[TestMethod]
	public void ToFastSortedList_WithValidList_ShouldReturnSortedList()
	{
		// Arrange
		var list = new List<int> { 5, 3, 1, 4, 2 };

		// Act
		var result = list.ToFastSortedList();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(list.Count, result, "Resulting list should have the same count as the source list.");
	}

	[TestMethod]
	public void ToFastSortedListTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.ToFastSortedList();

		Assert.IsNotNull(result);
		Assert.HasCount(Count, result);
	}


	[TestMethod]
	public void ToFrozenSetWithDuplicatesTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

		// Act
		var result = list.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(list.Distinct().Count(), result, "Resulting FrozenSet should contain distinct elements only.");

		foreach (var item in list.Distinct())
		{
			Assert.Contains(item, result, $"Item {item} should be present in the resulting FrozenSet.");
		}
	}

	[TestMethod]
	public void ToFrozenSetWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var result = list.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsEmpty(result, "Resulting FrozenSet should be empty.");
	}

	[TestMethod]
	public void ToFrozenSetWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = list.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(list.Count, result, "Resulting FrozenSet should have the same count as the source list.");

		foreach (var item in list)
		{
			Assert.Contains(item, result, $"Item {item} should be present in the resulting FrozenSet.");
		}
	}


	[TestMethod]
	public void ToFrozenSetWithNullListTest()
	{
		// Arrange
		List<int> list = null;

		// Act
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.ToFrozenSet());
	}


	[TestMethod]
	public void ToImmutableArrayTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.ToImmutableArray();

		Assert.IsNotNull(result);

		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public async Task ToListAsync_MultipleCalls_ShouldReturnIndependentLists()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result1 = await list.ToListAsync();
		var result2 = await list.ToListAsync();

		// Assert
		Assert.AreNotSame(result1, result2, "Multiple calls should return different list instances.");
		CollectionAssert.AreEqual(result1, result2, "Both results should contain the same values.");
	}

	[TestMethod]
	public async Task ToListAsync_WithCancellation_ShouldThrowOperationCanceledException()
	{
		// Arrange
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();
		using var cts = new CancellationTokenSource();

		// Act
		cts.Cancel(); // Cancel immediately

		// Assert
		await Assert.ThrowsExactlyAsync<OperationCanceledException>(async () =>
		{
			await list.ToListAsync(cts.Token);
		}, "Should throw OperationCanceledException when token is already canceled.");
	}

	[TestMethod]
	public async Task ToListAsync_WithComplexObjects_ShouldPreserveReferences()
	{
		// Arrange
		var addresses = RandomData.GeneratePersonRefCollection(10).ToList();
		var list = addresses.ToList();

		// Act
		var result = await list.ToListAsync();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(list.Count, result, "Result should have the same count.");

		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreSame(list[i], result[i],
				$"Address at index {i} should maintain the same object reference.");
		}
	}

	[TestMethod]
	public async Task ToListAsync_WithDefaultCancellationToken_ShouldReturnCopiedList()
	{
		// Arrange
		var list = RandomData.GeneratePersonRefCollection(100).ToList();
		var expectedCount = list.Count;

		// Act
		var result = await list.ToListAsync();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(expectedCount, result, "Result should have the same count as the original list.");
		Assert.AreNotSame(list, result, "Result should be a new list instance, not the same reference.");

		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreSame(list[i], result[i], $"Item at index {i} should be the same reference.");
		}
	}

	[TestMethod]
	public async Task ToListAsync_WithEmptyList_ShouldReturnEmptyList()
	{
		// Arrange
		var list = new List<Person>();

		// Act
		var result = await list.ToListAsync();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.IsEmpty(result, "Result should be empty.");
	}

	[TestMethod]
	public async Task ToListAsync_WithLargeList_ShouldReturnAllElements()
	{
		// Arrange
		var list = RandomData.GeneratePersonRefCollection(5000).ToList();
		var expectedCount = list.Count;

		// Act
		var result = await list.ToListAsync(CancellationToken.None);

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(expectedCount, result, "Result should contain all elements from the original list.");
	}

	[TestMethod]
	public async Task ToListAsync_WithNullInput_ShouldThrowArgumentNullException()
	{
		// Arrange
		IAsyncEnumerable<int> data = null;
		var cancellationToken = CancellationToken.None;

		// Act
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await data.ToListAsync(cancellationToken);
		});
	}

	[TestMethod]
	public async Task ToListAsync_WithNullList_ShouldThrowArgumentNullException()
	{
		// Arrange
		List<Person> list = null;

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await list.ToListAsync();
		}, "Should throw ArgumentNullException when list is null.");
	}

	[TestMethod]
	public async Task ToListAsync_WithSingleElement_ShouldReturnListWithOneElement()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();
		var list = new List<Person> { person };

		// Act
		var result = await list.ToListAsync();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(1, result, "Result should contain exactly one element.");
		Assert.AreSame(person, result[0], "The element should be the same reference as the original.");
	}

	[TestMethod]
	public async Task ToListAsync_WithValidInput_ShouldReturnList()
	{
		// Arrange
		var data = this.GetAsyncEnumerable(new[] { 1, 2, 3, 4, 5 });
		var cancellationToken = CancellationToken.None;

		// Act
		var result = await data.ToListAsync(cancellationToken);

		// Assert
		Assert.HasCount(5, result);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
		Assert.AreEqual(3, result[2]);
		Assert.AreEqual(4, result[3]);
		Assert.AreEqual(5, result[4]);
	}

	[TestMethod]
	public async Task ToListAsync_WithValueTypes_ShouldCopyAllValues()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		// Act
		var result = await list.ToListAsync();

		// Assert
		Assert.IsNotNull(result, "Result should not be null.");
		Assert.HasCount(list.Count, result, "Result should have the same count as the original list.");
		CollectionAssert.AreEqual(list, result, "Result should contain the same values as the original list.");
		Assert.AreNotSame(list, result, "Result should be a different list instance.");
	}

	[TestMethod]
	public void ToObservableListTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.ToObservable();

		Assert.IsNotNull(result);
		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void ToReadOnlyCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToReadOnlyCollection();

		Assert.HasCount(Count, people);
	}

	[TestMethod]
	public void ToReadOnlyListWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var readOnlyList = list.ToReadOnly();

		// Assert
		Assert.IsNotNull(readOnlyList, "Result should not be null.");
		Assert.IsEmpty(readOnlyList, "Resulting IReadOnlyList should be empty.");
	}

	[TestMethod]
	public void ToReadOnlyListWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var readOnlyList = list.ToReadOnly();

		// Assert
		Assert.IsNotNull(readOnlyList, "Result should not be null.");
		Assert.HasCount(list.Count, readOnlyList, "Resulting IReadOnlyList should have the same count as the source list.");

		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], readOnlyList[i], $"Item at index {i} should be equal in both list and resulting IReadOnlyList.");
		}
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var readOnlyObservableCollection = list.ToReadOnlyObservableCollection();

		// Assert
		Assert.IsNotNull(readOnlyObservableCollection, "Result should not be null.");
		Assert.IsEmpty(readOnlyObservableCollection, "Resulting ReadOnlyObservableCollection should be empty.");
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var readOnlyObservableCollection = list.ToReadOnlyObservableCollection();

		// Assert
		Assert.IsNotNull(readOnlyObservableCollection, "Result should not be null.");
		Assert.HasCount(list.Count, readOnlyObservableCollection, "Resulting ReadOnlyObservableCollection should have the same count as the source list.");

		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], readOnlyObservableCollection[i], $"Item at index {i} should be equal in both list and resulting ReadOnlyObservableCollection.");
		}
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionWithNullListTest()
	{
		List<int> list = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.ToReadOnlyObservableCollection());
	}

	private async IAsyncEnumerable<T> GetAsyncEnumerable<T>(IEnumerable<T> items)
	{
		foreach (var item in items)
		{
			yield return item;
			await Task.Yield();
		}
	}

}

