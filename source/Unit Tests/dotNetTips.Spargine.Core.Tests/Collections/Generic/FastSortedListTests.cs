// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 04-03-2026
// ***********************************************************************
// <copyright file="FastSortedListTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using DotNetTips.Spargine.Core.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic;

[ExcludeFromCodeCoverage]
[TestClass]
public class FastSortedListTests
{

	[TestMethod]
	public void Add_Items_ShouldKeepUnsortedUntilSorted()
	{
		var list = new FastSortedList<int>(5);

		// Add items out of order
		list.Add(5);
		list.Add(1);
		list.Add(3);

		// Accessing the private _sorted field to verify it's set to false after adding items
		var sortedField = typeof(FastSortedList<int>).GetField("_sorted", BindingFlags.NonPublic | BindingFlags.Instance);
		var isSorted = (bool)sortedField.GetValue(list);

		Assert.IsFalse(isSorted, "List should be marked as unsorted after adding items.");

		// Trigger sorting
		_ = list.ToArray();

		// Verify the list is now marked as sorted
		isSorted = (bool)sortedField.GetValue(list);
		Assert.IsTrue(isSorted, "List should be marked as sorted after sorting operation.");
	}

	[TestMethod]
	public void Add_Items_ShouldNotExceedCapacityUntilNecessary()
	{
		int capacity = 2;
		var list = new FastSortedList<int>(capacity);

		// Add items within initial capacity
		list.Add(1);
		list.Add(2);

		// Verify the list has not exceeded the initial capacity
		Assert.AreEqual(capacity, list.Capacity, "List capacity should not increase until necessary.");

		// Add another item to force an increase in capacity
		list.Add(3);

		// Verify the list capacity has increased
		Assert.IsGreaterThan(capacity, list.Capacity, "List capacity should increase when adding more items than its initial capacity.");
	}

	[TestMethod]
	public void Add_NullItem_ShouldThrowArgumentNullException()
	{
		var list = new FastSortedList<string>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.Add(null), "Adding a null item should throw ArgumentNullException.");
	}

	[TestMethod]
	public void Add_ShouldMarkUnsorted()
	{
		var list = new FastSortedList<int>();
		list.Add(2);
		list.Add(1); // Adding out of order

		// Accessing the private _sorted field to verify it's set to false after adding an item
		var sortedField = typeof(FastSortedList<int>).GetField("_sorted", BindingFlags.NonPublic | BindingFlags.Instance);
		var isSorted = (bool)sortedField.GetValue(list);

		Assert.IsFalse(isSorted, "List should be marked as unsorted after adding an item.");
	}

	[TestMethod]
	public void AddRange_NullCollection_ShouldThrowArgumentNullException()
	{
		var list = new FastSortedList<int>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.AddRange(null), "Adding a null collection should throw ArgumentNullException.");
	}

	[TestMethod]
	public void AddRange_ShouldAddAllItemsAndSort()
	{
		var list = new FastSortedList<int>();
		list.AddRange(new[] { 5, 3, 1, 4, 2 });

		var array = list.ToArray();

		Assert.HasCount(5, list, "List should contain all added items.");
		Assert.IsTrue(array.SequenceEqual(new[] { 1, 2, 3, 4, 5 }), "Items should be sorted after retrieval.");
	}

	[TestMethod]
	public void AddRange_ShouldMarkUnsorted()
	{
		var list = new FastSortedList<int>();
		list.AddRange(new[] { 2, 1 }); // Adding out of order

		// Accessing the private _sorted field to verify it's set to false after adding items
		var sortedField = typeof(FastSortedList<int>).GetField("_sorted", BindingFlags.NonPublic | BindingFlags.Instance);
		var isSorted = (bool)sortedField.GetValue(list);

		Assert.IsFalse(isSorted, "List should be marked as unsorted after adding a range of items.");
	}

	[TestMethod]
	public void AsReadOnlySpan_EmptyList_ShouldReturnEmptySpan()
	{
		var list = new FastSortedList<int>();
		var span = list.AsReadOnlySpan();

		Assert.AreEqual(0, span.Length, "Span should be empty for an empty list.");
	}

	[TestMethod]
	public void AsReadOnlySpan_ShouldSort()
	{
		var list = new FastSortedList<int> { 5, 3, 4, 1, 2 };
		var span = list.AsReadOnlySpan();

		Assert.AreEqual(5, span.Length, "Span length should match list count.");
		Assert.IsTrue(span.SequenceEqual(new[] { 1, 2, 3, 4, 5 }), "AsReadOnlySpan should sort the list before returning the span.");
	}

	[TestMethod]
	public void AsReadOnlySpan_WithCustomComparer_ShouldSortDescending()
	{
		var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x)); // Descending
		var list = new FastSortedList<int>(comparer) { 1, 3, 2 };
		var span = list.AsReadOnlySpan();

		Assert.IsTrue(span.SequenceEqual(new[] { 3, 2, 1 }), "AsReadOnlySpan should sort using the custom comparer.");
	}

	[TestMethod]
	public void Clear_ShouldMarkUnsorted()
	{
		var list = new FastSortedList<int> { 1, 2, 3 };
		list.Clear();

		// Accessing the private _sorted field to verify it's set to false after clearing the list
		var sortedField = typeof(FastSortedList<int>).GetField("_sorted", BindingFlags.NonPublic | BindingFlags.Instance);
		var isSorted = (bool)sortedField.GetValue(list);

		Assert.IsFalse(isSorted, "List should be marked as unsorted after clearing.");
	}

	[TestMethod]
	public void Clear_ShouldRemoveAllItems()
	{
		var list = new FastSortedList<int> { 1, 2, 3 };
		list.Clear();

		Assert.IsEmpty(list, "List should be empty after clearing.");
	}

	[TestMethod]
	public void Constructor_Default_ShouldInitializeEmptyList()
	{
		var list = new FastSortedList<int>();

		Assert.IsEmpty(list, "Default constructor should create an empty list.");
	}

	[TestMethod]
	public void Constructor_WithCapacity_ShouldBeEmpty()
	{
		var list = new FastSortedList<int>(10);

		// Verify the list is initially empty
		Assert.IsEmpty(list, "Newly created list should be empty.");
	}

	[TestMethod]
	public void Constructor_WithCapacity_ShouldInitializeWithCorrectCapacity()
	{
		int capacity = 10;
		var list = new FastSortedList<int>(capacity);

		// Verify the list's capacity is set as expected
		Assert.AreEqual(capacity, list.Capacity, "List capacity should match the specified capacity.");
	}

	[TestMethod]
	public void Constructor_WithCapacityAndComparer_ShouldInitializeCorrectly()
	{
		int capacity = 5;
		var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x)); // Descending order
		var list = new FastSortedList<int>(capacity, comparer);

		Assert.AreEqual(capacity, list.Capacity, "List capacity should match the specified capacity.");
	}

	[TestMethod]
	public void Constructor_WithCollection_ShouldInitializeWithElements()
	{
		var collection = new List<int> { 5, 2, 4, 3, 1 };
		var list = new FastSortedList<int>(collection);

		Assert.HasCount(collection.Count, list, "List should contain all elements from the collection.");

		var expected = collection.OrderBy(x => x).ToArray();

		for (int i = 0; i < expected.Length; i++)
		{
			Assert.AreEqual(expected[i], list[i], $"Element at index {i} should match the sorted collection element.");
		}
	}

	[TestMethod]
	public void Constructor_WithCollection_ShouldSortOnFirstRetrieval()
	{
		var collection = new List<int> { 5, 3, 1, 4, 2 };
		var list = new FastSortedList<int>(collection);

		// Trigger sorting
		var array = list.ToArray();

		Assert.IsTrue(array.SequenceEqual(collection.OrderBy(x => x)), "List should be sorted on first retrieval.");
	}

	[TestMethod]
	public void Constructor_WithCollectionAndComparer_ShouldUseCustomComparer()
	{
		var collection = new List<int> { 1, 3, 2 };
		var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x)); // Descending order
		var list = new FastSortedList<int>(collection, comparer);

		var array = list.ToArray();

		Assert.IsTrue(array.SequenceEqual(new[] { 3, 2, 1 }), "List should be sorted using the custom comparer.");
	}

	[TestMethod]
	public void Constructor_WithComparer_ShouldUseCustomComparer()
	{
		var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x)); // Descending order
		var list = new FastSortedList<int>(comparer);

		list.Add(1);
		list.Add(3);
		list.Add(2);

		var array = list.ToArray();

		Assert.IsTrue(array.SequenceEqual(new[] { 3, 2, 1 }), "List should be sorted using the custom comparer.");
	}

	[TestMethod]
	public void GetEnumerator_ShouldSort()
	{
		var list = new FastSortedList<int> { 5, 3, 4, 1, 2 };
		var enumerator = list.GetEnumerator();

		var firstItem = enumerator.Current;
		enumerator.MoveNext(); // Move to the first item
		firstItem = enumerator.Current;

		Assert.AreEqual(1, firstItem, "GetEnumerator should sort the list before returning the enumerator.");
	}

	[TestMethod]
	public void Remove_ExistingItem_ShouldReturnTrueAndRemove()
	{
		var list = new FastSortedList<int> { 1, 2, 3 };
		var result = list.Remove(2);

		Assert.IsTrue(result, "Removing an existing item should return true.");
		Assert.HasCount(2, list, "List should have one fewer element after removal.");
	}

	[TestMethod]
	public void Remove_NonExistentItem_ShouldReturnFalse()
	{
		var list = new FastSortedList<int> { 1, 2, 3 };
		var result = list.Remove(99);

		Assert.IsFalse(result, "Removing a non-existent item should return false.");
	}

	[TestMethod]
	public void Remove_NullItem_ShouldThrowArgumentNullException()
	{
		var list = new FastSortedList<string> { "a", "b" };

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => list.Remove(null), "Removing a null item should throw ArgumentNullException.");
	}

	[TestMethod]
	public void Remove_ShouldMarkUnsorted()
	{
		var list = new FastSortedList<int> { 1, 2, 3 };
		list.Remove(2);

		// Accessing the private _sorted field to verify it's set to false after removing an item
		var sortedField = typeof(FastSortedList<int>).GetField("_sorted", BindingFlags.NonPublic | BindingFlags.Instance);
		var isSorted = (bool)sortedField.GetValue(list);

		Assert.IsFalse(isSorted, "List should be marked as unsorted after removing an item.");
	}

	[TestMethod]
	public void RemoveAt_ShouldMarkUnsorted()
	{
		var list = new FastSortedList<int> { 1, 2, 3 };
		list.RemoveAt(1);

		// Accessing the private _sorted field to verify it's set to false after removing an item by index
		var sortedField = typeof(FastSortedList<int>).GetField("_sorted", BindingFlags.NonPublic | BindingFlags.Instance);
		var isSorted = (bool)sortedField.GetValue(list);

		Assert.IsFalse(isSorted, "List should be marked as unsorted after removing an item by index.");
	}

	[TestMethod]
	public void ToArray_ShouldSort()
	{
		var list = new FastSortedList<int> { 3, 1, 2 };
		var array = list.ToArray();

		Assert.IsTrue(array.SequenceEqual(new[] { 1, 2, 3 }), "ToArray should sort the list before converting it to an array.");
	}

	[TestMethod]
	public void ToImmutableList_ShouldSort()
	{
		var list = new FastSortedList<int> { 3, 2, 1 };
		var immutableList = list.ToImmutableList();

		Assert.IsTrue(immutableList.SequenceEqual(new[] { 1, 2, 3 }), "ToImmutableList should sort the list before converting it to an immutable list.");
	}

	[TestMethod]
	public void ToList_ShouldSort()
	{
		var list = new FastSortedList<int> { 2, 3, 1 };
		var newList = list.ToList();

		Assert.IsTrue(newList.SequenceEqual(new[] { 1, 2, 3 }), "ToList should sort the list before creating a new list.");
	}

}
