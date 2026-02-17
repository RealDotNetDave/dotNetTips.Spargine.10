// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2026
// ***********************************************************************
// <copyright file="DistinctConcurrentBagTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using Microsoft.VisualStudio.TestTools.UnitTesting;


//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

[ExcludeFromCodeCoverage]
[TestClass]
public class DistinctConcurrentBagTests
{

	[TestMethod]
	public void Add_AfterClear_AddsSuccessfully()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		bag.Clear();

		// Act
		bag.Add(10);
		bag.Add(20);

		// Assert
		Assert.AreEqual(2, bag.Count);
		Assert.IsTrue(bag.Contains(10));
		Assert.IsTrue(bag.Contains(20));
	}

	[TestMethod]
	public async Task Add_ConcurrentAccess_HandlesThreadSafely()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int>();
		const int taskCount = 10;
		const int itemsPerTask = 100;
		const int expectedTotal = taskCount * itemsPerTask;

		// Use a barrier to ensure all tasks start simultaneously
		using var startBarrier = new Barrier(taskCount);
		var tasks = new Task[taskCount];

		// Act - Multiple threads try to add unique items
		for (int taskId = 0; taskId < taskCount; taskId++)
		{
			var localTaskId = taskId;
			tasks[taskId] = Task.Run(() =>
			{
				startBarrier.SignalAndWait(); // Ensure all tasks start at the same time

				var start = localTaskId * itemsPerTask;
				var end = start + itemsPerTask;

				for (int i = start; i < end; i++)
				{
					bag.Add(i);
				}
			});
		}

		await Task.WhenAll(tasks);

		// Give a small delay for any internal cleanup
		await Task.Delay(100);

		// Assert - Check for missing items to help diagnose the issue
		var missingItems = new List<int>();

		for (int i = 0; i < expectedTotal; i++)
		{
			if (!bag.Contains(i))
			{
				missingItems.Add(i);
			}
		}

		if (missingItems.Count > 0)
		{
			Assert.Fail($"Expected {expectedTotal} items but got {bag.Count}. " +
				$"Missing {missingItems.Count} items: [{string.Join(", ", missingItems.Take(20))}" +
				$"{(missingItems.Count > 20 ? "..." : string.Empty)}]");
		}

		Assert.AreEqual(expectedTotal, bag.Count, "All unique items should be added across concurrent tasks.");
	}

	[TestMethod]
	public void Add_ConcurrentDuplicates_HandlesThreadSafely()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int>();
		var tasks = new List<Task>();

		// Act - Multiple threads try to add same items
		for (int taskId = 0; taskId < 10; taskId++)
		{
			tasks.Add(Task.Run(() =>
			{
				for (int i = 0; i < 100; i++)
				{
					bag.Add(i);
				}
			}));
		}

		Task.WaitAll(tasks.ToArray());

		// Assert - Only 100 unique items should exist
		Assert.AreEqual(100, bag.Count, "Only unique items should be in the bag.");
	}

	[TestMethod]
	public void Add_DuplicateItems_CountRemainsOne()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<string>();

		// Act
		bag.Add("test");
		bag.Add("test");
		bag.Add("test");

		// Assert
		Assert.AreEqual(1, bag.Count);
		Assert.IsTrue(bag.Contains("test"));
	}

	[TestMethod]
	public void Add_LargeNumberOfItems_HandlesCorrectly()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int>();

		// Act
		for (int i = 0; i < 10000; i++)
		{
			bag.Add(i);
		}

		// Assert
		Assert.AreEqual(10000, bag.Count);
	}

	[TestMethod]
	public void Add_MultipleUniqueItems_AddsAllItems()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int>();

		// Act
		bag.Add(1);
		bag.Add(2);
		bag.Add(3);
		bag.Add(4);
		bag.Add(5);

		// Assert
		Assert.AreEqual(5, bag.Count);
		Assert.IsTrue(bag.Contains(1));
		Assert.IsTrue(bag.Contains(2));
		Assert.IsTrue(bag.Contains(3));
		Assert.IsTrue(bag.Contains(4));
		Assert.IsTrue(bag.Contains(5));
	}
	[TestMethod]
	public void Add_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<string>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => bag.Add(null));
	}

	[TestMethod]
	public void Add_PreviouslyRemovedItem_AddsSuccessfully()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int>();
		bag.Add(5);
		bag.Remove(5);

		// Act
		bag.Add(5);

		// Assert
		Assert.AreEqual(1, bag.Count);
		Assert.IsTrue(bag.Contains(5));
	}

	[TestMethod]
	public void Add_ReferenceType_AddsCorrectly()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<List<int>>();
		var list1 = new List<int> { 1, 2, 3 };
		var list2 = new List<int> { 4, 5, 6 };

		// Act
		bag.Add(list1);
		bag.Add(list2);

		// Assert
		Assert.AreEqual(2, bag.Count);
		Assert.IsTrue(bag.Contains(list1));
		Assert.IsTrue(bag.Contains(list2));
	}

	[TestMethod]
	public void Add_SameReferenceMultipleTimes_OnlyAddsOnce()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<List<int>>();
		var list = new List<int> { 1, 2, 3 };

		// Act
		bag.Add(list);
		bag.Add(list);
		bag.Add(list);

		// Assert
		Assert.AreEqual(1, bag.Count);
	}

	[TestMethod]
	public void Add_ShouldAddUniqueItem()
	{
		var bag = new DistinctConcurrentBag<int>();
		bag.Add(1);
		Assert.IsTrue(bag.Contains(1));
	}

	[TestMethod]
	public void Add_ShouldIgnoreDuplicate()
	{
		var bag = new DistinctConcurrentBag<int>();
		bag.Add(1);
		bag.Add(1);
		Assert.AreEqual(1, bag.Count);
	}

	[TestMethod]
	public void Add_StringItems_MaintainsDistinctness()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<string>();

		// Act
		bag.Add("apple");
		bag.Add("banana");
		bag.Add("apple");
		bag.Add("cherry");
		bag.Add("banana");

		// Assert
		Assert.AreEqual(3, bag.Count);
		Assert.IsTrue(bag.Contains("apple"));
		Assert.IsTrue(bag.Contains("banana"));
		Assert.IsTrue(bag.Contains("cherry"));
	}

	[TestMethod]
	public void Add_ToEmptyBag_IncreasesCount()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int>();

		// Act
		bag.Add(42);

		// Assert
		Assert.AreEqual(1, bag.Count);
		Assert.IsFalse(bag.IsEmpty);
	}

	[TestMethod]
	public void Add_ValueType_AddsCorrectly()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<DateTime>();
		var date1 = new DateTime(2025, 1, 1);
		var date2 = new DateTime(2025, 6, 15);

		// Act
		bag.Add(date1);
		bag.Add(date2);
		bag.Add(date1); // Duplicate

		// Assert
		Assert.AreEqual(2, bag.Count);
	}

	[TestMethod]
	public void Add_WithCustomComparer_UsesComparer()
	{
		// Arrange
		var comparer = StringComparer.OrdinalIgnoreCase;
		var bag = new DistinctConcurrentBag<string>(comparer);

		// Act
		bag.Add("Test");
		bag.Add("TEST");
		bag.Add("test");

		// Assert - All should be treated as duplicates
		Assert.AreEqual(1, bag.Count);
	}

	[TestMethod]
	public void AddRange_WithDuplicates_ShouldAddOnlyUniqueItems()
	{
		var bag = new DistinctConcurrentBag<int>();
		var items = new[] { 1, 2, 2, 3, 3, 3 };

		var addedCount = bag.AddRange(items);

		Assert.AreEqual(3, addedCount);
		Assert.AreEqual(3, bag.Count);
	}

	[TestMethod]
	public void AddRange_WithEmptyCollection_ShouldReturnZero()
	{
		var bag = new DistinctConcurrentBag<int>();
		var items = Array.Empty<int>();

		var addedCount = bag.AddRange(items);

		Assert.AreEqual(0, addedCount);
		Assert.AreEqual(0, bag.Count);
	}

	[TestMethod]
	public void AddRange_WithExistingItems_ShouldSkipDuplicates()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var items = new[] { 3, 4, 5 };

		var addedCount = bag.AddRange(items);

		Assert.AreEqual(2, addedCount);
		Assert.AreEqual(5, bag.Count);
	}

	[TestMethod]
	public void AddRange_WithNullItems_ShouldThrowArgumentNullException()
	{
		var bag = new DistinctConcurrentBag<int>();

		Assert.ThrowsExactly<ArgumentNullException>(() => bag.AddRange(null));
	}

	[TestMethod]
	public void AddRange_WithNullItemsInCollection_ShouldSkipNulls()
	{
		var bag = new DistinctConcurrentBag<string>();
		var items = new[] { "a", null, "b", null, "c" };

		var addedCount = bag.AddRange(items);

		Assert.AreEqual(3, addedCount);
		Assert.AreEqual(3, bag.Count);
		Assert.IsTrue(bag.Contains("a"));
		Assert.IsTrue(bag.Contains("b"));
		Assert.IsTrue(bag.Contains("c"));
	}

	[TestMethod]
	public void AddRange_WithUniqueItems_ShouldAddAllItems()
	{
		var bag = new DistinctConcurrentBag<int>();
		var items = new[] { 1, 2, 3, 4, 5 };

		var addedCount = bag.AddRange(items);

		Assert.AreEqual(5, addedCount);
		Assert.AreEqual(5, bag.Count);
		Assert.IsTrue(items.All(item => bag.Contains(item)));
	}

	[TestMethod]
	public void Clear_MultipleCalls_ShouldRemainEmpty()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		bag.Clear();
		bag.Clear();
		bag.Clear();
		Assert.AreEqual(0, bag.Count);
	}

	[TestMethod]
	public void Clear_ShouldAllowAddingAfterClear()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		bag.Clear();
		bag.Add(10);
		Assert.AreEqual(1, bag.Count);
		Assert.IsTrue(bag.Contains(10));
	}

	[TestMethod]
	public void Clear_ShouldAllowDuplicateAddAfterClear()
	{
		var bag = new DistinctConcurrentBag<int> { 5 };
		bag.Clear();
		bag.Add(5); // Should be able to add the same item again after clear
		Assert.AreEqual(1, bag.Count);
		Assert.IsTrue(bag.Contains(5));
	}

	[TestMethod]
	public void Clear_ShouldClearEnumerator()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		bag.Clear();
		var items = bag.ToList();
		Assert.IsEmpty(items);
	}

	[TestMethod]
	public void Clear_ShouldClearLargeCollection()
	{
		var bag = new DistinctConcurrentBag<int>();
		for (int i = 0; i < 1000; i++)
		{
			bag.Add(i);
		}
		Assert.AreEqual(1000, bag.Count);
		bag.Clear();
		Assert.AreEqual(0, bag.Count);
		Assert.IsFalse(bag.Contains(500));
	}

	[TestMethod]
	public void Clear_ShouldHandleEmptyBag()
	{
		var bag = new DistinctConcurrentBag<int>();
		bag.Clear();
		Assert.AreEqual(0, bag.Count);
	}

	[TestMethod]
	public void Clear_ShouldRemoveAllItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		bag.Clear();
		Assert.AreEqual(0, bag.Count);
		Assert.IsFalse(bag.Contains(1));
		Assert.IsFalse(bag.Contains(2));
		Assert.IsFalse(bag.Contains(3));
	}

	[TestMethod]
	public void Clear_ShouldRemoveSingleItem()
	{
		var bag = new DistinctConcurrentBag<int> { 42 };
		Assert.AreEqual(1, bag.Count);
		bag.Clear();
		Assert.AreEqual(0, bag.Count);
		Assert.IsFalse(bag.Contains(42));
	}

	[TestMethod]
	public async Task ConcurrentAddAndRemove_ShouldHandleCorrectly()
	{
		var bag = new DistinctConcurrentBag<int>();
		var addTasks = new Task[5];
		var removeTasks = new Task[5];

		// Add items concurrently (first phase)
		for (int i = 0; i < 5; i++)
		{
			var localStart = i * 20; // Create local copy to avoid closure problem
			addTasks[i] = Task.Run(() =>
			{
				for (int j = localStart; j < localStart + 20; j++)
				{
					bag.Add(j);
				}
			});
		}

		// Wait for all adds to complete before starting removes
		await Task.WhenAll(addTasks);

		// Verify all 100 items were added
		Assert.AreEqual(100, bag.Count, "All 100 items should be added before removals start.");

		// Remove items concurrently (second phase)
		for (int i = 0; i < 5; i++)
		{
			var localStart = i * 20; // Create local copy to avoid closure problem
			removeTasks[i] = Task.Run(() =>
			{
				for (int j = localStart; j < localStart + 10; j++)
				{
					bag.Remove(j);
				}
			});
		}

		await Task.WhenAll(removeTasks);

		// 5 ranges × 20 items = 100 items added
		// 5 ranges × 10 items = 50 items removed (items 0-9, 20-29, 40-49, 60-69, 80-89)
		// Expected: 50 items remaining (items 10-19, 30-39, 50-59, 70-79, 90-99)
		Assert.AreEqual(50, bag.Count, "50 items should remain after removals.");

		// Verify the correct items remain
		for (int i = 0; i < 5; i++)
		{
			var rangeStart = i * 20;
			// Items 0-9 of each range should be removed
			for (int j = rangeStart; j < rangeStart + 10; j++)
			{
				Assert.IsFalse(bag.Contains(j), $"Item {j} should have been removed.");
			}
			// Items 10-19 of each range should remain
			for (int j = rangeStart + 10; j < rangeStart + 20; j++)
			{
				Assert.IsTrue(bag.Contains(j), $"Item {j} should still exist.");
			}
		}
	}

	[TestMethod]
	public void Constructor_ShouldInitializeEmptyBag()
	{
		var bag = new DistinctConcurrentBag<int>();
		Assert.AreEqual(0, bag.Count);
	}

	[TestMethod]
	public void Constructor_WithCollection_ShouldCopyItems()
	{
		var initialItems = new List<int> { 1, 2, 3 };
		var bag = new DistinctConcurrentBag<int>(initialItems);
		Assert.IsTrue(initialItems.All(item => bag.Contains(item)));
	}

	[TestMethod]
	public void Constructor_WithComparer_ShouldUseCustomComparer()
	{
		var comparer = StringComparer.OrdinalIgnoreCase;
		var bag = new DistinctConcurrentBag<string>(comparer);

		bag.Add("Hello");
		bag.Add("HELLO"); // Should be treated as duplicate with case-insensitive comparer

		Assert.AreEqual(1, bag.Count);
		Assert.IsTrue(bag.Contains("hello"));
	}

	[TestMethod]
	public void Constructor_WithNullComparer_ShouldThrowArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
		{
			return new DistinctConcurrentBag<string>((IEqualityComparer<string>)null);
		});
	}

	[TestMethod]
	public void Contains_ShouldReturnFalseForNonExistingItem()
	{
		var bag = new DistinctConcurrentBag<int> { 1 };
		Assert.IsFalse(bag.Contains(2));
	}

	[TestMethod]
	public void Contains_ShouldReturnTrueForExistingItem()
	{
		var bag = new DistinctConcurrentBag<int> { 1 };
		Assert.IsTrue(bag.Contains(1));
	}

	[TestMethod]
	public void CopyTo_EmptyBag_ShouldNotModifyArray()
	{
		var bag = new DistinctConcurrentBag<int>();
		var array = new int[5] { 99, 99, 99, 99, 99 };
		bag.CopyTo(array, 0);
		// Array should remain unchanged when copying from empty bag
		CollectionAssert.AreEqual(new[] { 99, 99, 99, 99, 99 }, array);
	}

	[TestMethod]
	public void CopyTo_ExactFit_ShouldCopySuccessfully()
	{
		var bag = new DistinctConcurrentBag<int> { 10, 20, 30, 40, 50 };
		var array = new int[5];
		bag.CopyTo(array, 0);

		CollectionAssert.AreEquivalent(new[] { 10, 20, 30, 40, 50 }, array);
	}

	[TestMethod]
	public void CopyTo_LargerArray_ShouldCopySuccessfully()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var array = new int[10];
		bag.CopyTo(array, 0);

		var copiedItems = array.Take(3).ToArray();
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, copiedItems);
	}

	[TestMethod]
	public void CopyTo_NegativeArrayIndex_ShouldThrowArgumentOutOfRangeException()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var array = new int[5];

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => bag.CopyTo(array, -1));
	}

	[TestMethod]
	public void CopyTo_NullArray_ShouldThrowArgumentNullException()
	{
		// Arrange
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => bag.CopyTo(null, 0));
	}

	[TestMethod]
	public void CopyTo_ShouldCopyAllItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var array = new int[3];
		bag.CopyTo(array, 0);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, array);
	}

	[TestMethod]
	public void CopyTo_SingleItem_ShouldCopySuccessfully()
	{
		var bag = new DistinctConcurrentBag<int> { 42 };
		var array = new int[1];
		bag.CopyTo(array, 0);

		Assert.AreEqual(42, array[0]);
	}

	[TestMethod]
	public void CopyTo_StringType_ShouldCopySuccessfully()
	{
		var bag = new DistinctConcurrentBag<string> { "apple", "banana", "cherry" };
		var array = new string[3];
		bag.CopyTo(array, 0);

		CollectionAssert.AreEquivalent(new[] { "apple", "banana", "cherry" }, array);
	}

	[TestMethod]
	public void CopyTo_WithOffset_ShouldCopyToCorrectPosition()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var array = new int[6];
		bag.CopyTo(array, 2);

		Assert.AreEqual(0, array[0]);
		Assert.AreEqual(0, array[1]);
		// Next 3 elements should contain bag items (order may vary)
		var copiedItems = new[] { array[2], array[3], array[4] };
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, copiedItems);
		Assert.AreEqual(0, array[5]);
	}

	[TestMethod]
	public void Enumeration_ShouldReturnAllUniqueItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var items = bag.ToList();
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, items);
	}

	[TestMethod]
	public void IsEmpty_AfterAddAndRemove_ShouldReturnTrue()
	{
		var bag = new DistinctConcurrentBag<int>();
		bag.Add(1);
		bag.Remove(1);

		Assert.IsTrue(bag.IsEmpty);
	}

	[TestMethod]
	public void IsEmpty_AfterClear_ShouldReturnTrue()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		bag.Clear();

		Assert.IsTrue(bag.IsEmpty);
	}

	#region IsEmpty Tests

	[TestMethod]
	public void IsEmpty_EmptyBag_ShouldReturnTrue()
	{
		var bag = new DistinctConcurrentBag<int>();

		Assert.IsTrue(bag.IsEmpty);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyBag_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<int> { 1 };

		Assert.IsFalse(bag.IsEmpty);
	}

	[TestMethod]
	public void IsReadOnly_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<int>();
		Assert.IsFalse(bag.IsReadOnly);
	}

	[TestMethod]
	public void Remove_ShouldRemoveItemAndUpdateCount()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		Assert.IsTrue(bag.Remove(2));
		Assert.AreEqual(2, bag.Count);
		Assert.IsFalse(bag.Contains(2));
	}

	[TestMethod]
	public void Remove_ShouldReturnFalseForNonExistingItem()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		Assert.IsFalse(bag.Remove(4));
		Assert.AreEqual(3, bag.Count);
	}

	[TestMethod]
	public void RemoveRange_WithEmptyCollection_ShouldReturnZero()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var itemsToRemove = Array.Empty<int>();

		var removedCount = bag.RemoveRange(itemsToRemove);

		Assert.AreEqual(0, removedCount);
		Assert.AreEqual(3, bag.Count);
	}

	[TestMethod]
	public void RemoveRange_WithExistingItems_ShouldRemoveAllItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3, 4, 5 };
		var itemsToRemove = new[] { 2, 4 };

		var removedCount = bag.RemoveRange(itemsToRemove);

		Assert.AreEqual(2, removedCount);
		Assert.AreEqual(3, bag.Count);
		Assert.IsFalse(bag.Contains(2));
		Assert.IsFalse(bag.Contains(4));
	}

	[TestMethod]
	public void RemoveRange_WithMixedExistingAndNonExisting_ShouldRemoveOnlyExisting()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3, 4, 5 };
		var itemsToRemove = new[] { 2, 10, 4, 20 };

		var removedCount = bag.RemoveRange(itemsToRemove);

		Assert.AreEqual(2, removedCount);
		Assert.AreEqual(3, bag.Count);
	}

	[TestMethod]
	public void RemoveRange_WithNonExistingItems_ShouldReturnZero()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var itemsToRemove = new[] { 10, 20 };

		var removedCount = bag.RemoveRange(itemsToRemove);

		Assert.AreEqual(0, removedCount);
		Assert.AreEqual(3, bag.Count);
	}

	[TestMethod]
	public void RemoveRange_WithNullItems_ShouldThrowArgumentNullException()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		Assert.ThrowsExactly<ArgumentNullException>(() => bag.RemoveRange(null));
	}

	[TestMethod]
	public void ToArray_EmptyBag_ShouldReturnEmptyArray()
	{
		var bag = new DistinctConcurrentBag<int>();

		var array = bag.ToArray();

		Assert.IsNotNull(array);
		Assert.IsEmpty(array);
	}

	[TestMethod]
	public void ToArray_ShouldNotAffectOriginalBag()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		var array = bag.ToArray();
		array[0] = 99;

		Assert.AreEqual(3, bag.Count);
		Assert.IsTrue(bag.Contains(1));
		Assert.IsFalse(bag.Contains(99));
	}

	[TestMethod]
	public void ToArray_WithItems_ShouldReturnArrayWithAllItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		var array = bag.ToArray();

		Assert.HasCount(3, array);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, array);
	}

	[TestMethod]
	public void ToList_EmptyBag_ShouldReturnEmptyList()
	{
		var bag = new DistinctConcurrentBag<int>();

		var list = bag.ToList();

		Assert.IsNotNull(list);
		Assert.IsEmpty(list);
	}

	[TestMethod]
	public void ToList_ShouldNotAffectOriginalBag()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		var list = bag.ToList();
		list.Add(99);

		Assert.AreEqual(3, bag.Count);
		Assert.IsFalse(bag.Contains(99));
	}

	[TestMethod]
	public void ToList_WithItems_ShouldReturnListWithAllItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		var list = bag.ToList();

		Assert.HasCount(3, list);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, list);
	}

	[TestMethod]
	public void TryAdd_ShouldAddUniqueItemAndReturnTrue()
	{
		var bag = new DistinctConcurrentBag<int>();
		Assert.IsTrue(bag.TryAdd(5));
		Assert.IsTrue(bag.Contains(5));
	}

	[TestMethod]
	public void TryAdd_ShouldReturnFalseForDuplicate()
	{
		var bag = new DistinctConcurrentBag<int>();
		Assert.IsTrue(bag.TryAdd(5));
		Assert.IsFalse(bag.TryAdd(5));
		Assert.AreEqual(1, bag.Count);
	}

	[TestMethod]
	public void TryTake_ShouldRemoveExistingItem()
	{
		var bag = new DistinctConcurrentBag<int> { 1 };
		bool success = bag.TryTake(out int result);
		Assert.IsTrue(success);
		Assert.AreEqual(1, result);
		Assert.IsFalse(bag.Contains(1));
	}

	[TestMethod]
	public void TryTake_ShouldReturnFalseWhenEmpty()
	{
		var bag = new DistinctConcurrentBag<int>();
		bool success = bag.TryTake(out int result);
		Assert.IsFalse(success);
		Assert.AreEqual(default(int), result);
	}

	#endregion

	#region ToFrozenSet Tests

	[TestMethod]
	public void ToFrozenSet_WithItems_ShouldReturnFrozenSetWithAllItems()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		var frozenSet = bag.ToFrozenSet();

		Assert.HasCount(3, frozenSet);
		Assert.Contains(1, frozenSet);
		Assert.Contains(2, frozenSet);
		Assert.Contains(3, frozenSet);
	}

	[TestMethod]
	public void ToFrozenSet_EmptyBag_ShouldReturnEmptyFrozenSet()
	{
		var bag = new DistinctConcurrentBag<int>();

		var frozenSet = bag.ToFrozenSet();

		Assert.IsNotNull(frozenSet);
		Assert.IsEmpty(frozenSet);
	}

	[TestMethod]
	public void ToFrozenSet_ShouldCreateImmutableSnapshot()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		var frozenSet = bag.ToFrozenSet();
		bag.Add(4);

		Assert.HasCount(3, frozenSet);
		Assert.DoesNotContain(4, frozenSet);
	}

	[TestMethod]
	public void TryGetValue_WithExistingItem_ShouldReturnTrueAndActualValue()
	{
		var bag = new DistinctConcurrentBag<string> { "apple", "banana", "cherry" };

		var result = bag.TryGetValue("banana", out var actualValue);

		Assert.IsTrue(result);
		Assert.AreEqual("banana", actualValue);
	}

	[TestMethod]
	public void TryGetValue_WithNonExistingItem_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<string> { "apple", "banana" };

		var result = bag.TryGetValue("cherry", out var actualValue);

		Assert.IsFalse(result);
		Assert.IsNull(actualValue);
	}

	[TestMethod]
	public void TryGetValue_WithNullItem_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<string> { "apple" };

		var result = bag.TryGetValue(null, out var actualValue);

		Assert.IsFalse(result);
		Assert.IsNull(actualValue);
	}

	[TestMethod]
	public void TryGetValue_EmptyBag_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<string>();

		var result = bag.TryGetValue("apple", out var actualValue);

		Assert.IsFalse(result);
		Assert.IsNull(actualValue);
	}

	[TestMethod]
	public void TryPeek_WithExistingItem_ShouldReturnTrueAndActualValue()
	{
		var bag = new DistinctConcurrentBag<int> { 10, 20, 30 };

		var result = bag.TryPeek(20, out var actualValue);

		Assert.IsTrue(result);
		Assert.AreEqual(20, actualValue);
		Assert.AreEqual(3, bag.Count); // Item should not be removed
	}

	[TestMethod]
	public void TryPeek_WithNonExistingItem_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<int> { 10, 20 };

		var result = bag.TryPeek(30, out var actualValue);

		Assert.IsFalse(result);
		Assert.AreEqual(default(int), actualValue);
	}

	[TestMethod]
	public void TryPeek_WithNullItem_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<string> { "test" };

		var result = bag.TryPeek(null, out var actualValue);

		Assert.IsFalse(result);
		Assert.IsNull(actualValue);
	}

	[TestMethod]
	public void ContainsAny_WithMatchingItems_ShouldReturnTrue()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3, 4, 5 };
		var itemsToCheck = new[] { 10, 20, 3, 30 };

		var result = bag.ContainsAny(itemsToCheck);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ContainsAny_WithNoMatchingItems_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var itemsToCheck = new[] { 10, 20, 30 };

		var result = bag.ContainsAny(itemsToCheck);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_WithNullItems_ShouldThrowArgumentNullException()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };

		Assert.ThrowsExactly<ArgumentNullException>(() => bag.ContainsAny(null));
	}

	[TestMethod]
	public void ContainsAny_WithEmptyCollection_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<int> { 1, 2, 3 };
		var itemsToCheck = Array.Empty<int>();

		var result = bag.ContainsAny(itemsToCheck);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_EmptyBag_ShouldReturnFalse()
	{
		var bag = new DistinctConcurrentBag<int>();
		var itemsToCheck = new[] { 1, 2, 3 };

		var result = bag.ContainsAny(itemsToCheck);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ContainsAny_WithNullItemsInCollection_ShouldSkipNulls()
	{
		var bag = new DistinctConcurrentBag<string> { "a", "b", "c" };
		var itemsToCheck = new[] { null, "x", "b" };

		var result = bag.ContainsAny(itemsToCheck);

		Assert.IsTrue(result);
	}

	#endregion


}
