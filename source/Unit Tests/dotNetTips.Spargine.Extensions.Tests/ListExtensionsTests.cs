// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-22-2025
// ***********************************************************************
// <copyright file="ListExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ListExtensionsTests
{

	private const int Count = 256;

	private async IAsyncEnumerable<T> GetAsyncEnumerable<T>(IEnumerable<T> items)
	{
		foreach (var item in items)
		{
			yield return item;
			await Task.Yield();
		}
	}

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
		Assert.AreEqual(6, list.Count, "List should contain 6 items.");
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
		Assert.AreEqual(6, list.Count, "List should contain 6 items.");
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
		Assert.AreEqual(10001, list.Count, "List should contain 10001 items.");
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
		Assert.AreEqual(4, list.Count, "List should have 4 items.");
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
		Assert.AreEqual(1, list.Count, "List should contain exactly 1 item.");
		Assert.AreEqual(itemToAdd, list[0], "The first (and only) item should be the added item.");
	}

	[TestMethod]
	public void AddFirstWithNullItemTest()
	{
		// Arrange
		var list = new List<string> { "item1", "item2", "item3" };
		string nullItem = null;
		var originalCount = list.Count;

		// Act
		list.AddFirst(nullItem);

		// Assert
		Assert.AreEqual(originalCount, list.Count, "List count should remain unchanged when adding null.");
		Assert.IsFalse(list.Contains(null), "List should not contain null after attempting to add null.");
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
		Assert.AreEqual(1, list.Count, "List should contain exactly 1 person.");
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
		Assert.AreEqual(5, list.Count, "List should contain 5 items after adding one.");
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
		Assert.AreEqual(4, list.Count, "List should contain 4 decimal values.");
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
		Assert.AreEqual(6, list.Count, "List should contain 6 items.");
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
		Assert.AreEqual(10001, list.Count, "List should contain 10001 items.");
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
		Assert.AreEqual(4, list.Count, "List should have 4 items.");
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
		Assert.AreEqual(1, list.Count, "List should contain exactly 1 item.");
		Assert.AreEqual(itemToAdd, list[0], "The first (and only) item should be the added item.");
	}

	[TestMethod]
	public void AddLastWithNullItemTest()
	{
		// Arrange
		var list = new List<string> { "item1", "item2", "item3" };
		string nullItem = null;
		var originalCount = list.Count;

		// Act
		list.AddLast(nullItem);

		// Assert
		Assert.AreEqual(originalCount, list.Count, "List count should remain unchanged when adding null.");
		Assert.IsFalse(list.Contains(null), "List should not contain null after attempting to add null.");
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
		Assert.AreEqual(1, list.Count, "List should contain exactly 1 person.");
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
		Assert.AreEqual(6, list.Count, "List should contain 6 items after adding one.");
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
		Assert.AreEqual(4, list.Count, "List should contain 4 decimal values.");
		Assert.AreEqual(valueToAdd, list[3], "Last value should be the added decimal.");
	}

	[TestMethod]
	public void AddRangeIfNotExistsLargeComparerTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();
		var itemsToAdd = RandomData.GeneratePersonRefCollection(10).ToList();

		list.AddRangeIfNotExists(itemsToAdd, new PersonEmailEqualityComparer());

		Assert.AreEqual(1010, list.Count);
	}

	[TestMethod]
	public void AddRangeIfNotExistsLargeTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();
		var itemsToAdd = RandomData.GeneratePersonRefCollection(10).ToList();

		list.AddRangeIfNotExists(itemsToAdd);

		Assert.AreEqual(1010, list.Count);
	}

	[TestMethod]
	public void AddRangeIfNotExistsTest()
	{
		var list = new List<int> { 1, 2, 3 };
		var itemsToAdd = new List<int> { 3, 4, 5 };

		list.AddRangeIfNotExists(itemsToAdd);

		Assert.AreEqual(5, list.Count);
		Assert.IsTrue(list.Contains(1));
		Assert.IsTrue(list.Contains(2));
		Assert.IsTrue(list.Contains(3));
		Assert.IsTrue(list.Contains(4));
		Assert.IsTrue(list.Contains(5));
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
		Assert.AreEqual(0, collection.Count, "Expected the collection count to be zero after clearing all nulls.");
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
		Assert.AreEqual(0, collection.Count, "Expected the collection count to remain zero.");
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
		Assert.AreEqual(3, collection.Count, "Expected the collection count to remain unchanged.");
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
		Assert.AreEqual(3, collection.Count, "Expected the collection count to be reduced by the number of nulls.");
		Assert.IsFalse(collection.Contains(null), "Expected the collection to no longer contain nulls.");
	}

	[TestMethod]
	public void GenerateHashCodeForRecord()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count).ToList();

		var result = people.GenerateHashCode();

		Assert.IsFalse(result == 0, "Hash code should be greater than zero for a non-empty list of records.");
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
	public void IsEqualToNullFirstListTest()
	{
		// Arrange
		List<int> list1 = null;
		var list2 = new List<int>();

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEqualToNullSecondListTest()
	{
		// Arrange
		var list1 = new List<int>();
		List<int> list2 = null;

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEqualToWithBothEmptyListsTest()
	{
		// Arrange
		var list1 = new List<int>();
		var list2 = new List<int>();

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsTrue(result, "Two empty lists should be considered equal.");
	}

	[TestMethod]
	public void IsEqualToWithDifferentListsTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 5, 4, 3, 2, 1 };

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsFalse(result, "Lists with different elements should not be considered equal.");
	}

	[TestMethod]
	public void IsEqualToWithEqualListsTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsTrue(result, "Lists with identical elements should be considered equal.");
	}


	[TestMethod]
	public void IsEqualToWithOneEmptyListTest()
	{
		// Arrange
		var list1 = new List<int> { 1, 2, 3, 4, 5 };
		var list2 = new List<int>();

		// Act
		var result = list1.IsEqualTo(list2);

		// Assert
		Assert.IsFalse(result, "A non-empty list and an empty list should not be considered equal.");
	}

	[TestMethod]
	public void IsNotEmptyCountTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();

		var result = list.IsNotEmpty(1000);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsNotEmptyPredicateTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();

		var result = list.IsNotEmpty(p => p.Addresses.Count > 1);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsNotEmptyTest()
	{
		var list = RandomData.GeneratePersonRefCollection(1000).ToList();

		var result = list.IsNotEmpty();

		Assert.IsTrue(result);
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
	public void PagingTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		const int PageCount = 10;
		var peopleCount = 0;
		var loopedCount = 0;

		foreach (var peoplePage in people.Page(PageCount))
		{
			loopedCount++;
			peopleCount += peoplePage.Count();
		}

		Assert.IsTrue(peopleCount == Count);

		Assert.IsTrue(loopedCount == 26);
	}

	[TestMethod]
	public void PerformActionTest()
	{
		var words = RandomData.GenerateWords(10, 10, Count).ToList();
		var sb = new StringBuilder();

		words.PerformAction((word) => _ = sb.Append($"WORD:{word}|"));

		Assert.IsTrue(sb.Length > Count);
	}

	[TestMethod]
	public void PickRandomTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToDictionary(p => p.Id);

		var result = people.PickRandom();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void RemoveFirstNullTest()
	{
		var list = RandomData.GeneratePersonRefCollection(10).ToList();

		var result = list.RemoveFirst(null);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void RemoveFirstTest()
	{
		var list = new List<int> { 1, 2, 3, 2, 4 };

		var result = list.RemoveFirst(2);

		Assert.IsTrue(result);
		Assert.AreEqual(4, list.Count);
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
		Assert.AreEqual(4, list.Count);
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

		Assert.IsTrue(people.Count == shuffledPeople.Count());
	}

	[TestMethod]
	public void ShuffleTest()
	{
		var list = new List<int> { 1, 2, 3, 4, 5 };
		var originalList = new List<int>(list);

		list = list.FastShuffle();

		Assert.AreEqual(5, list.Count);
		Assert.IsTrue(list.Contains(1));
		Assert.IsTrue(list.Contains(2));
		Assert.IsTrue(list.Contains(3));
		Assert.IsTrue(list.Contains(4));
		Assert.IsTrue(list.Contains(5));
		CollectionAssert.AreNotEqual(originalList, list);
	}

	[TestMethod]
	public void SplitTest()
	{
		var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		var result = list.Split(3);

		Assert.AreEqual(3, result.Count);
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

		Assert.IsTrue(result.Count == Count);
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
		Assert.AreEqual(0, result.Count, "Resulting collection should be empty.");
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
		Assert.AreEqual(list.Count, result.Count, "Resulting collection should have the same count as the source list.");
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

		Assert.IsTrue(result.Count == Count);

		Assert.IsTrue(result.IsAddingCompleted);
	}

	[TestMethod]
	public void ToDistinctBlockingCollectionWithNullListTest()
	{
		List<int> list = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.ToDistinctBlockingCollection());
	}

	[TestMethod]
	public void ToDistinctConcurrentBagTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.ToDistinctConcurrentBag();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.Count == Count);
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
		Assert.AreEqual(list.Count, result.Count, "Resulting list should have the same count as the source list.");
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
		Assert.AreEqual(0, result.Count, "Resulting list should be empty.");
	}

	[TestMethod]
	public void ToFastSortedList_WithNullComparer_ShouldThrowArgumentNullException()
	{
		var list = new List<int> { 1, 2, 3 };
		IComparer<int> comparer = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.ToFastSortedList(comparer));
	}

	[TestMethod]
	public void ToFastSortedList_WithNullList_ShouldThrowArgumentNullException()
	{
		List<int> list = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.ToFastSortedList());
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
		Assert.AreEqual(list.Count, result.Count, "Resulting list should have the same count as the source list.");
	}

	[TestMethod]
	public void ToFastSortedListTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.ToFastSortedList();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.Count == Count);
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
		Assert.AreEqual(list.Distinct().Count(), result.Count, "Resulting FrozenSet should contain distinct elements only.");
		foreach (var item in list.Distinct())
		{
			Assert.IsTrue(result.Contains(item), $"Item {item} should be present in the resulting FrozenSet.");
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
		Assert.AreEqual(0, result.Count, "Resulting FrozenSet should be empty.");
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
		Assert.AreEqual(list.Count, result.Count, "Resulting FrozenSet should have the same count as the source list.");
		foreach (var item in list)
		{
			Assert.IsTrue(result.Contains(item), $"Item {item} should be present in the resulting FrozenSet.");
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

		Assert.IsTrue(result.Length == Count);
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
		Assert.AreEqual(list.Count, result.Count, "Result should have the same count.");

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
		Assert.AreEqual(expectedCount, result.Count, "Result should have the same count as the original list.");
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
		Assert.AreEqual(0, result.Count, "Result should be empty.");
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
		Assert.AreEqual(expectedCount, result.Count, "Result should contain all elements from the original list.");
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
		Assert.AreEqual(1, result.Count, "Result should contain exactly one element.");
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
		Assert.AreEqual(5, result.Count);
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
		Assert.AreEqual(list.Count, result.Count, "Result should have the same count as the original list.");
		CollectionAssert.AreEqual(list, result, "Result should contain the same values as the original list.");
		Assert.AreNotSame(list, result, "Result should be a different list instance.");
	}

	[TestMethod]
	public void ToObservableListTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		var result = people.ToObservableList();

		Assert.IsNotNull(result);

		Assert.IsTrue(result.Count == Count);
	}

	[TestMethod]
	public void ToReadOnlyCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToReadOnlyCollection();

		Assert.IsTrue(people.Count == Count);
	}

	[TestMethod]
	public void ToReadOnlyListWithEmptyListTest()
	{
		// Arrange
		var list = new List<int>();

		// Act
		var readOnlyList = list.ToReadOnlyList();

		// Assert
		Assert.IsNotNull(readOnlyList, "Result should not be null.");
		Assert.AreEqual(0, readOnlyList.Count, "Resulting IReadOnlyList should be empty.");
	}

	[TestMethod]
	public void ToReadOnlyListWithNonEmptyListTest()
	{
		// Arrange
		var list = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var readOnlyList = list.ToReadOnlyList();

		// Assert
		Assert.IsNotNull(readOnlyList, "Result should not be null.");
		Assert.AreEqual(list.Count, readOnlyList.Count, "Resulting IReadOnlyList should have the same count as the source list.");
		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list[i], readOnlyList[i], $"Item at index {i} should be equal in both list and resulting IReadOnlyList.");
		}
	}


	[TestMethod]
	public void ToReadOnlyListWithNullListTest()
	{
		List<int> list = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.ToReadOnlyList());
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
		Assert.AreEqual(0, readOnlyObservableCollection.Count, "Resulting ReadOnlyObservableCollection should be empty.");
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
		Assert.AreEqual(list.Count, readOnlyObservableCollection.Count, "Resulting ReadOnlyObservableCollection should have the same count as the source list.");
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

}

