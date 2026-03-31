// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-06-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2026
// ***********************************************************************
// <copyright file="ConcurrentHashSetTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

[ExcludeFromCodeCoverage]
[TestClass]
public class ConcurrentHashSetTests
{

	[TestMethod]
	public void Add_MultipleUniqueItems_IncreasesCountCorrectly()
	{
		var hashSet = new ConcurrentHashSet<int>();
		for (int i = 0; i < 10; i++)
		{
			hashSet.Add(i);
		}

		Assert.AreEqual(10, hashSet.Count, "Count should reflect the number of unique items added.");
	}

	[TestMethod]
	public void Add_NullItem_ThrowsArgumentNullException()
	{
		var hashSet = new ConcurrentHashSet<string>();
		Assert.ThrowsExactly<ArgumentNullException>(() => hashSet.Add(null));
	}

	[TestMethod]
	public void AddRange_ConcurrentAccess_HandlesThreadSafely()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		var tasks = new List<Task>();
		int itemsPerTask = 100;

		// Act
		for (int taskId = 0; taskId < 10; taskId++)
		{
			var localTaskId = taskId;
			tasks.Add(Task.Run(() =>
			{
				var items = Enumerable.Range(localTaskId * itemsPerTask, itemsPerTask);
				set.AddRange(items);
			}));
		}
		Task.WaitAll(tasks.ToArray());

		// Assert
		Assert.AreEqual(1000, set.Count, "All unique items should be added across concurrent tasks.");
	}

	[TestMethod]
	public void AddRange_EmptyCollection_ReturnsZero()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		var emptyCollection = Array.Empty<int>();

		// Act
		var result = set.AddRange(emptyCollection);

		// Assert
		Assert.AreEqual(0, result, "AddRange should return 0 for empty collection.");
		Assert.AreEqual(0, set.Count, "Set should remain empty.");
	}

	[TestMethod]
	public void AddRange_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => set.AddRange(null));
	}

	[TestMethod]
	public void AddRange_WithDuplicates_OnlyAddsUniqueItems()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };
		var itemsToAdd = new[] { 3, 4, 5, 1 };

		// Act
		var result = set.AddRange(itemsToAdd);

		// Assert
		Assert.AreEqual(2, result, "AddRange should return count of newly added unique items only.");
		Assert.AreEqual(5, set.Count, "Set should contain 5 unique items total.");
	}

	[TestMethod]
	public void AddRange_WithNullItems_SkipsNulls()
	{
		// Arrange
		var set = new ConcurrentHashSet<string>();
		var itemsToAdd = new[] { "one", null, "two", null, "three" };

		// Act
		var result = set.AddRange(itemsToAdd);

		// Assert
		Assert.AreEqual(3, result, "AddRange should skip null items and return count of non-null items added.");
		Assert.AreEqual(3, set.Count, "Set should contain only non-null items.");
	}
	[TestMethod]
	public void AddRange_WithUniqueItems_AddsAllItems()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		var itemsToAdd = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = set.AddRange(itemsToAdd);

		// Assert
		Assert.AreEqual(5, result, "AddRange should return the count of items added.");
		Assert.AreEqual(5, set.Count, "Set should contain all unique items.");
		Assert.IsTrue(set.Contains(1) && set.Contains(5), "Set should contain all items from the range.");
	}

	[TestMethod]
	public void Clear_AlreadyEmptySet_RemainsEmpty()
	{
		var hashSet = new ConcurrentHashSet<int>();
		hashSet.Clear(); // Calling Clear on an already empty set

		Assert.AreEqual(0, hashSet.Count, "HashSet should remain empty after calling Clear.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should return true for an already empty set after calling Clear.");
	}


	[TestMethod]
	public void Clear_NonEmptySet_BecomesEmpty()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.Clear();

		Assert.AreEqual(0, hashSet.Count, "HashSet should be empty after calling Clear.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should return true after clearing the set.");
	}


	[TestMethod]
	public void Constructor_WithCollectionAndComparer_InitializesCorrectlyAndUsesComparer()
	{
		var initialCollection = new List<string> { "apple", "Apple", "banana", "Banana" };
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(initialCollection, comparer);

		// Verify the count reflects that duplicates (based on the comparer) were not added
		Assert.AreEqual(2, hashSet.Count, "The count of the ConcurrentHashSet should reflect unique items based on the comparer.");

		// Verify that the hashSet contains items from the initial collection, considering the comparer
		Assert.IsTrue(hashSet.Contains("apple"), "The ConcurrentHashSet should contain 'apple'.");
		Assert.IsTrue(hashSet.Contains("banana"), "The ConcurrentHashSet should contain 'banana'.");

		// Verify that the hashSet considers different casing as equal, due to the comparer
		Assert.IsTrue(hashSet.Contains("Apple"), "The ConcurrentHashSet should consider 'Apple' as existing due to the comparer.");
		Assert.IsTrue(hashSet.Contains("Banana"), "The ConcurrentHashSet should consider 'Banana' as existing due to the comparer.");
	}

	[TestMethod]
	public void Constructor_WithComparer_UsesComparerCorrectly()
	{
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(comparer);

		hashSet.Add("test");
		Assert.IsTrue(hashSet.Contains("TEST"), "The hash set should use the provided comparer for case-insensitive comparison.");
	}

	[TestMethod]
	public void Constructor_WithConcurrencyLevelAndCapacity_InitializesCorrectly()
	{
		int concurrencyLevel = 4; // Example concurrency level
		int capacity = 100; // Example initial capacity
		var hashSet = new ConcurrentHashSet<int>(concurrencyLevel, capacity);

		// Verify the hashSet is empty upon initialization
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a newly initialized ConcurrentHashSet.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should be true for a newly initialized ConcurrentHashSet.");

		// Verify that the hashSet can have items added after being initialized with the specified concurrency level and capacity
		for (int i = 0; i < capacity; i++)
		{
			hashSet.Add(i);
		}
		Assert.AreEqual(capacity, hashSet.Count, $"Count should reflect the number of items added, expected {capacity}.");

		// Further validation to ensure the specified concurrency level and capacity do not cause unexpected behavior could be performed here
		// Note: Direct validation of concurrencyLevel's effect might not be straightforward without internal access or specific concurrent scenarios
	}


	[TestMethod]
	public void Constructor_WithConcurrencyLevelCapacityAndComparer_InitializesCorrectly()
	{
		int concurrencyLevel = 4; // Example concurrency level
		int capacity = 100; // Example initial capacity
		var comparer = StringComparer.OrdinalIgnoreCase; // Example custom comparer
		var hashSet = new ConcurrentHashSet<string>(concurrencyLevel, capacity, comparer);

		// Verify the hashSet is empty upon initialization
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a newly initialized ConcurrentHashSet.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should be true for a newly initialized ConcurrentHashSet.");

		// Add items to test the custom comparer's effect
		hashSet.Add("test");
		hashSet.Add("TEST");
		// Due to the custom comparer, adding "TEST" should not increase the count
		Assert.AreEqual(1, hashSet.Count, "Count should reflect unique items based on the custom comparer.");

		// Verify that the hashSet can have items added after being initialized with the specified concurrency level, capacity, and comparer
		for (int i = 1; i < capacity; i++)
		{
			hashSet.Add("test" + i);
		}
		// Verify the count reflects the added items plus the initial "test" item, respecting the custom comparer
		Assert.AreEqual(capacity, hashSet.Count, $"Count should reflect the number of unique items added, expected {capacity}.");

		// Further validation to ensure the specified concurrency level and capacity do not cause unexpected behavior could be performed here
		// Note: Direct validation of concurrencyLevel's effect might not be straightforward without internal access or specific concurrent scenarios
	}


	[TestMethod]
	public void Constructor_WithConcurrencyLevelCollectionAndComparer_InitializesCorrectly()
	{
		var concurrencyLevel = 2;
		var initialCollection = new List<string> { "apple", "Apple", "banana", "Banana" };
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(concurrencyLevel, initialCollection, comparer);

		// Verify the count reflects that duplicates (based on the comparer) were not added
		Assert.AreEqual(2, hashSet.Count, "The count of the ConcurrentHashSet should reflect unique items based on the comparer.");

		// Verify that the hashSet contains items from the initial collection, considering the comparer
		Assert.IsTrue(hashSet.Contains("apple"), "The ConcurrentHashSet should contain 'apple'.");
		Assert.IsTrue(hashSet.Contains("banana"), "The ConcurrentHashSet should contain 'banana'.");

		// Verify that the hashSet considers different casing as equal, due to the comparer
		Assert.IsTrue(hashSet.Contains("Apple"), "The ConcurrentHashSet should consider 'Apple' as existing due to the comparer.");
		Assert.IsTrue(hashSet.Contains("Banana"), "The ConcurrentHashSet should consider 'Banana' as existing due to the comparer.");

		// Additional checks could be performed to ensure the concurrency level is respected, though this may require a more complex setup
	}

	[TestMethod]
	public void Contains_ExistingItem_ReturnsTrue()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		bool result = hashSet.Contains(2);

		Assert.IsTrue(result, "Contains should return true for an item that exists in the set.");
	}


	[TestMethod]
	public void Contains_NonExistingItem_ReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		bool result = hashSet.Contains(4);

		Assert.IsFalse(result, "Contains should return false for an item that does not exist in the set.");
	}

	[TestMethod]
	public void Contains_NullItem_ReturnsCorrectResult()
	{
		var hashSet = new ConcurrentHashSet<string> { "a", "b", "c" };
		bool result = hashSet.Contains(null);

		// Adjust the assertion based on whether your implementation allows nulls or not.
		// If nulls are allowed and expected to be found, use Assert.IsTrue(result);
		// If nulls are not allowed or expected not to be found, use Assert.IsFalse(result);
		Assert.IsFalse(result, "Contains should return the correct result for a null item, depending on whether nulls are allowed.");
	}

	[TestMethod]
	public void Contains_WithComparer_FindsCorrectly()
	{
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(comparer);

		hashSet.Add("test");
		bool containsResult = hashSet.Contains("TEST");

		Assert.IsTrue(containsResult, "Should find item with case-insensitive key.");
	}

	[TestMethod]
	public void CopyTo_ArrayIndexCorrect_CopiesExpectedElements()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "one", "two", "three" };
		string[] array = new string[5]; // Larger than set, with offset

		// Act
		set.CopyTo(array, 2);

		// Assert
		Assert.IsNull(array[0]);
		Assert.IsNull(array[1]);
		CollectionAssert.Contains(array, "one");
		CollectionAssert.Contains(array, "two");
		CollectionAssert.Contains(array, "three");
	}

	[TestMethod]
	public void CopyTo_NegativeArrayIndex_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "one", "two", "three" };
		string[] array = new string[3];

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => set.CopyTo(array, -1));
	}

	[TestMethod]
	public void CopyTo_NullArray_ThrowsArgumentNullException()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => set.CopyTo(null, 0));
	}

	[TestMethod]
	public void CopyTo_WithInsufficientArraySpace_ThrowsArgumentException()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };
		var array = new int[2];

		// Act & Assert
		Assert.ThrowsExactly<ArgumentInvalidException>(() => set.CopyTo(array, 0));
	}

	[TestMethod]
	public void CopyTo_WithNegativeArrayIndex_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };
		var array = new int[5];

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => set.CopyTo(array, -1));
	}

	[TestMethod]
	public void CopyTo_WithNullArray_ThrowsArgumentNullException()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => set.CopyTo(null, 0));
	}

	[TestMethod]
	public void CopyTo_WithValidArray_CopiesElementsCorrectly()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };
		var array = new int[5];

		// Act
		set.CopyTo(array, 1);

		// Assert
		Assert.AreEqual(0, array[0]);
		Assert.AreEqual(1, array[1]);
		Assert.AreEqual(2, array[2]);
		Assert.AreEqual(3, array[3]);
		Assert.AreEqual(0, array[4]);
	}


	[TestMethod]
	public void Count_AfterAddingDuplicateItem_RemainsUnchanged()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.Add(2); // Attempt to add a duplicate item

		Assert.AreEqual(3, hashSet.Count, "Count should remain unchanged after attempting to add a duplicate item.");
	}

	[TestMethod]
	public void Count_AfterAddingUniqueItems_IncreasesCorrectly()
	{
		var hashSet = new ConcurrentHashSet<int>();
		hashSet.Add(1);
		hashSet.Add(2);
		hashSet.Add(3);

		Assert.AreEqual(3, hashSet.Count, "Count should be 3 after adding three unique items.");
	}

	[TestMethod]
	public void Count_AfterRemovingItems_DecreasesCorrectly()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.TryRemove(2);
		hashSet.TryRemove(3);

		Assert.AreEqual(1, hashSet.Count, "Count should be 1 after removing two items.");
	}

	[TestMethod]
	public void Count_ForNewOrClearedSet_IsZero()
	{
		var hashSet = new ConcurrentHashSet<int>();
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a new set.");

		hashSet.Add(1);
		hashSet.Clear();
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a cleared set.");
	}

	[TestMethod]
	public void DefaultConcurrencyLevel_EqualsProcessorCount()
	{
		var expectedConcurrencyLevel = Environment.ProcessorCount;
		var actualConcurrencyLevel = ConcurrentHashSet<int>.DefaultConcurrencyLevel;

		Assert.AreEqual(expectedConcurrencyLevel, actualConcurrencyLevel, "DefaultConcurrencyLevel should equal the number of processors available to the current process.");
	}

	[TestMethod]
	public void GetEnumerator_ExplicitInterfaceImplementation_EnumeratesAllItems()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		var items = new List<int>();

		// Explicitly cast to IEnumerable<T> to use the explicit interface implementation
		var enumerable = hashSet;
		foreach (var item in enumerable)
		{
			items.Add(item);
		}

		Assert.HasCount(3, items, "The enumerator should iterate over all items.");
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, items, "The enumerated items should match the items in the set.");
	}

	[TestMethod]
	public void Integration_AddRange_ToArray_TryPeek_WorkTogether()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		var itemsToAdd = Enumerable.Range(1, 100).ToArray();

		// Act
		var addedCount = set.AddRange(itemsToAdd);
		var arraySnapshot = set.ToArray();
		var peekResult = set.TryPeek(50, out var actualValue);

		// Assert
		Assert.AreEqual(100, addedCount, "AddRange should add all items.");
		Assert.HasCount(100, arraySnapshot, "ToArray should return all items.");
		Assert.IsTrue(peekResult, "TryPeek should find the item.");
		Assert.AreEqual(50, actualValue, "Peeked value should match.");
	}

	[TestMethod]
	public void Integration_TryAdd_Multiple_ThenToArray_VerifiesUniqueness()
	{
		// Arrange
		var set = new ConcurrentHashSet<string>(StringComparer.OrdinalIgnoreCase);

		// Act
		var result1 = set.TryAdd("Test");
		var result2 = set.TryAdd("TEST");
		var result3 = set.TryAdd("test");
		var result4 = set.TryAdd("different");
		var array = set.ToArray();

		// Assert
		Assert.IsTrue(result1, "First TryAdd should succeed.");
		Assert.IsFalse(result2, "Second TryAdd should fail (duplicate).");
		Assert.IsFalse(result3, "Third TryAdd should fail (duplicate).");
		Assert.IsTrue(result4, "Fourth TryAdd should succeed (unique).");
		Assert.HasCount(2, array, "Array should contain only 2 unique items.");
	}

	[TestMethod]
	public void Intialize_With_Collection()
	{
		var people = RandomData.GeneratePersonRefCollection(10);
		var hashSet = new ConcurrentHashSet<Person>(people);

		Assert.IsNotNull(hashSet, "HashSet should be initialized with the provided collection.");

		Assert.AreEqual(10, hashSet.Count, "HashSet count should match the number of unique items in the initial collection.");
	}

	[TestMethod]
	public void IsEmpty_AfterAddingItems_ReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		Assert.IsFalse(hashSet.IsEmpty, "IsEmpty should return false for a set that contains items.");
	}

	[TestMethod]
	public void IsEmpty_AfterClearingSet_ReturnsTrue()
	{
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.Clear();
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should return true for a set that has been cleared.");
	}

	[TestMethod]
	public void IsEmpty_AfterRemovingAllItems_ReturnsTrue()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "one", "two", "three" };

		// Act
		set.Remove("one");
		set.Remove("two");
		set.Remove("three");

		// Assert
		Assert.IsTrue(set.IsEmpty);
	}

	[TestMethod]
	public void IsEmpty_NewSet_ReturnsTrue()
	{
		var hashSet = new ConcurrentHashSet<int>();
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should return true for a new set.");
	}


	[TestMethod]
	public void IsReadOnly_AlwaysReturnsFalse()
	{
		var hashSet = new ConcurrentHashSet<int>();
		Assert.IsFalse(hashSet.IsReadOnly, "IsReadOnly should always return false for ConcurrentHashSet.");
	}

	[TestMethod]
	public void Remove_Concurrent_Removals_ShouldDecreaseCountCorrectly()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		int itemsToAdd = 1000;
		for (int i = 0; i < itemsToAdd; i++)
		{
			set.Add(i);
		}
		var tasks = new List<Task>();

		// Act
		for (int i = 0; i < itemsToAdd; i++)
		{
			var localI = i;
			tasks.Add(Task.Run(() => set.Remove(localI)));
		}
		Task.WaitAll(tasks.ToArray());

		// Assert
		Assert.AreEqual(0, set.Count);
	}


	[TestMethod]
	public void Remove_ExistingItem_ReturnsTrueAndRemovesItem()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "one", "two", "three" };

		// Act
		bool result = set.Remove("two");

		// Assert
		Assert.IsTrue(result, "Expected Remove to return true for existing item.");
		Assert.IsFalse(set.Contains("two"), "Expected item to be removed from the set.");
	}

	[TestMethod]
	public void Remove_NonExistingItem_ReturnsFalse()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "one", "two", "three" };

		// Act
		bool result = set.Remove("four");

		// Assert
		Assert.IsFalse(result, "Expected Remove to return false for non-existing item.");
	}

	[TestMethod]
	public void Remove_NullItem()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "one", "two", "three" };

		// Act
		Assert.IsFalse(set.Remove(null));
	}

	[TestMethod]
	public void ToArray_CreatesSnapshot_NotAffectedBySubsequentChanges()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act
		var array1 = set.ToArray();
		set.Add(4);
		set.Add(5);
		var array2 = set.ToArray();

		// Assert
		Assert.HasCount(3, array1, "First array should have original count.");
		Assert.HasCount(5, array2, "Second array should reflect changes.");
	}


	[TestMethod]
	public void ToArray_EmptySet_ReturnsEmptyArray()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();

		// Act
		var result = set.ToArray();

		// Assert
		Assert.IsNotNull(result, "ToArray should not return null.");
		Assert.IsEmpty(result, "Array should be empty for empty set.");
	}

	[TestMethod]
	public void ToArray_WithComparer_PreservesItems()
	{
		// Arrange
		var comparer = StringComparer.OrdinalIgnoreCase;
		var set = new ConcurrentHashSet<string>(comparer) { "test", "TEST2", "test3" };

		// Act
		var result = set.ToArray();

		// Assert
		Assert.HasCount(3, result, "Array should contain all unique items based on comparer.");
	}

	[TestMethod]
	public void ToArray_WithItems_ReturnsArrayWithAllItems()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = set.ToArray();

		// Assert
		Assert.HasCount(5, result, "Array should contain all items from set.");
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5 }, result, "Array should contain the same items as the set.");
	}

	[TestMethod]
	public void TryAdd_ConcurrentAccess_EnsuresUniqueness()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		var tasks = new List<Task<bool>>();
		int itemToAdd = 42;
		int numberOfAttempts = 100;

		// Act
		for (int i = 0; i < numberOfAttempts; i++)
		{
			tasks.Add(Task.Run(() => set.TryAdd(itemToAdd)));
		}
		Task.WaitAll(tasks.ToArray());

		var successfulAdds = tasks.Count(t => t.Result);

		// Assert
		Assert.AreEqual(1, successfulAdds, "Only one thread should successfully add the item.");
		Assert.AreEqual(1, set.Count, "Set should contain only one instance of the item.");
	}

	[TestMethod]
	public void TryAdd_ExistingItem_ReturnsFalseAndDoesNotAdd()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act
		var result = set.TryAdd(2);

		// Assert
		Assert.IsFalse(result, "TryAdd should return false for existing item.");
		Assert.AreEqual(3, set.Count, "Count should remain unchanged.");
	}

	[TestMethod]
	public void TryAdd_NewItem_ReturnsTrueAndAddsItem()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act
		var result = set.TryAdd(4);

		// Assert
		Assert.IsTrue(result, "TryAdd should return true for new item.");
		Assert.IsTrue(set.Contains(4), "Set should contain the newly added item.");
		Assert.AreEqual(4, set.Count, "Count should be increased.");
	}

	[TestMethod]
	public void TryAdd_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var set = new ConcurrentHashSet<string>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => set.TryAdd(null));
	}

	[TestMethod]
	public void TryAdd_WithComparer_UsesComparerCorrectly()
	{
		// Arrange
		var comparer = StringComparer.OrdinalIgnoreCase;
		var set = new ConcurrentHashSet<string>(comparer);
		set.TryAdd("test");

		// Act
		var result = set.TryAdd("TEST");

		// Assert
		Assert.IsFalse(result, "TryAdd should return false for duplicate based on comparer.");
		Assert.AreEqual(1, set.Count, "Count should remain 1.");
	}

	[TestMethod]
	public void TryPeek_ConcurrentAccess_ThreadSafe()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		for (int i = 0; i < 1000; i++)
		{
			set.Add(i);
		}

		var tasks = new List<Task>();
		int peeksPerTask = 100;

		// Act
		for (int taskId = 0; taskId < 10; taskId++)
		{
			tasks.Add(Task.Run(() =>
			{
				for (int i = 0; i < peeksPerTask; i++)
				{
					var itemToFind = Random.Shared.Next(0, 1000);
					var found = set.TryPeek(itemToFind, out var value);
					if (found)
					{
						Assert.AreEqual(itemToFind, value, "Peeked value should match the search key.");
					}
				}
			}));
		}
		Task.WaitAll(tasks.ToArray());

		// Assert - No exceptions should occur during concurrent access
		Assert.AreEqual(1000, set.Count, "Set should maintain all items after concurrent peeks.");
	}

	[TestMethod]
	public void TryPeek_EmptySet_ReturnsFalse()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();

		// Act
		var result = set.TryPeek(42, out var actualValue);

		// Assert
		Assert.IsFalse(result, "TryPeek should return false for empty set.");
		Assert.AreEqual(0, actualValue, "ActualValue should be default for value type.");
	}

	// ==================== Tests for TryPeek Method ====================

	[TestMethod]
	public void TryPeek_ExistingItem_ReturnsTrueAndActualValue()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "apple", "banana", "cherry" };

		// Act
		var result = set.TryPeek("banana", out var actualValue);

		// Assert
		Assert.IsTrue(result, "TryPeek should return true for existing item.");
		Assert.AreEqual("banana", actualValue, "ActualValue should match the item in the set.");
	}

	[TestMethod]
	public void TryPeek_NonExistingItem_ReturnsFalseAndDefaultValue()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "apple", "banana" };

		// Act
		var result = set.TryPeek("grape", out var actualValue);

		// Assert
		Assert.IsFalse(result, "TryPeek should return false for non-existing item.");
		Assert.IsNull(actualValue, "ActualValue should be default (null) for reference type.");
	}

	[TestMethod]
	public void TryPeek_NullItem_ReturnsFalseAndDefaultValue()
	{
		// Arrange
		var set = new ConcurrentHashSet<string> { "apple", "banana" };

		// Act
		var result = set.TryPeek(null, out var actualValue);

		// Assert
		Assert.IsFalse(result, "TryPeek should return false for null item.");
		Assert.IsNull(actualValue, "ActualValue should be default (null).");
	}

	[TestMethod]
	public void TryPeek_ReturnsCanonicalInstance_ForReferenceTypes()
	{
		// Arrange
		var person1 = RandomData.GeneratePerson<Person>();
		var person2 = person1.FastBinaryClone<Person>();
		var set = new ConcurrentHashSet<Person> { person1 };

		// Act
		var result = set.TryPeek(person2, out var actualValue);

		// Assert
		Assert.IsTrue(result, "TryPeek should find equal person.");
		Assert.AreSame(person1, actualValue, "TryPeek should return the canonical instance from the set.");
	}

	[TestMethod]
	public void TryPeek_WithComparer_FindsItemCorrectly()
	{
		// Arrange
		var comparer = StringComparer.OrdinalIgnoreCase;
		var set = new ConcurrentHashSet<string>(comparer) { "test", "example" };

		// Act
		var result = set.TryPeek("TEST", out var actualValue);

		// Assert
		Assert.IsTrue(result, "TryPeek should find item using comparer.");
		Assert.AreEqual("test", actualValue, "ActualValue should be the canonical value stored in set.");
	}

	[TestMethod]
	public void TryRemove_AfterClear_ReturnsFalse()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };
		hashSet.Clear();

		// Act
		var result = hashSet.TryRemove(1);

		// Assert
		Assert.IsFalse(result, "TryRemove should return false after Clear.");
	}

	[TestMethod]
	public void TryRemove_AllItems_SetBecomesEmpty()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act
		var result1 = hashSet.TryRemove(1);
		var result2 = hashSet.TryRemove(2);
		var result3 = hashSet.TryRemove(3);

		// Assert
		Assert.IsTrue(result1 && result2 && result3, "All removals should return true.");
		Assert.AreEqual(0, hashSet.Count, "Count should be 0.");
		Assert.IsTrue(hashSet.IsEmpty, "Set should be empty.");
	}

	[TestMethod]
	public void TryRemove_Concurrent_SameItem_MultipleThreads()
	{
		var set = new ConcurrentHashSet<int> { 1 };
		int numberOfRemovalAttempts = 100;
		var tasks = new List<Task<bool>>();
		int successfulRemovals = 0;

		for (int i = 0; i < numberOfRemovalAttempts; i++)
		{
			tasks.Add(Task.Run(() => set.TryRemove(1)));
		}

		Task.WaitAll(tasks.ToArray());

		foreach (var task in tasks)
		{
			if (task.Result)
			{
				successfulRemovals++;
			}
		}

		Assert.AreEqual(1, successfulRemovals, "Only one thread should successfully remove the item.");
		Assert.IsTrue(set.IsEmpty, "Set should be empty after successful removal.");
	}

	[TestMethod]
	public void TryRemove_ConcurrentAccess_HandlesThreadSafely()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int>();
		for (int i = 0; i < 1000; i++)
		{
			hashSet.Add(i);
		}

		var tasks = new List<Task<int>>();

		// Act - Multiple threads try to remove different items
		for (int taskId = 0; taskId < 10; taskId++)
		{
			var localTaskId = taskId;
			tasks.Add(Task.Run(() =>
			{
				var removedCount = 0;
				for (int i = localTaskId * 100; i < (localTaskId + 1) * 100; i++)
				{
					if (hashSet.TryRemove(i))
					{
						removedCount++;
					}
				}
				return removedCount;
			}));
		}

		Task.WaitAll(tasks.ToArray());
		var totalRemoved = tasks.Sum(t => t.Result);

		// Assert
		Assert.AreEqual(1000, totalRemoved, "All items should be removed exactly once.");
		Assert.AreEqual(0, hashSet.Count, "Set should be empty after removing all items.");
	}

	[TestMethod]
	public void TryRemove_ConcurrentAddAndRemove_HandlesThreadSafely()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int>();
		var addTask = Task.Run(() =>
		{
			for (int i = 0; i < 500; i++)
			{
				hashSet.Add(i);
			}
		});

		var removeTask = Task.Run(() =>
		{
			var removed = 0;
			for (int i = 0; i < 500; i++)
			{
				if (hashSet.TryRemove(i))
				{
					removed++;
				}
			}
			return removed;
		});

		// Act
		Task.WaitAll(addTask, removeTask);

		// Assert - No exceptions should be thrown, demonstrating thread safety
		Assert.IsTrue(hashSet.Count >= 0, "Count should be non-negative.");
	}

	[TestMethod]
	public void TryRemove_EmptySet_ReturnsFalse()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int>();

		// Act
		var result = hashSet.TryRemove(1);

		// Assert
		Assert.IsFalse(result, "TryRemove should return false for empty set.");
		Assert.AreEqual(0, hashSet.Count, "Count should remain 0.");
	}

	[TestMethod]
	public void TryRemove_ExistingItem_ReturnsTrueAndRemovesItem()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = hashSet.TryRemove(3);

		// Assert
		Assert.IsTrue(result, "TryRemove should return true for existing item.");
		Assert.AreEqual(4, hashSet.Count, "Count should decrease by 1.");
		Assert.IsFalse(hashSet.Contains(3), "Item should no longer be in the set.");
	}

	[TestMethod]
	public void TryRemove_LargeSet_RemovesItemCorrectly()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int>();
		for (int i = 0; i < 10000; i++)
		{
			hashSet.Add(i);
		}

		// Act
		var result = hashSet.TryRemove(5000);

		// Assert
		Assert.IsTrue(result, "TryRemove should return true for existing item in large set.");
		Assert.AreEqual(9999, hashSet.Count, "Count should decrease by 1.");
		Assert.IsFalse(hashSet.Contains(5000), "Item should no longer be in the set.");
	}

	[TestMethod]
	public void TryRemove_NonExistingItem_ReturnsFalse()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act
		var result = hashSet.TryRemove(999);

		// Assert
		Assert.IsFalse(result, "TryRemove should return false for non-existing item.");
		Assert.AreEqual(3, hashSet.Count, "Count should remain unchanged.");
	}

	[TestMethod]
	public void TryRemove_NullItem()
	{
		// Arrange
		var set = new ConcurrentHashSet<string>();

		// Act & Assert
		Assert.IsFalse(set.TryRemove(null));
	}

	[TestMethod]
	public void TryRemove_NullItem_ReturnsFalse()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<string> { "one", "two", "three" };

		// Act
		var result = hashSet.TryRemove(null);

		// Assert
		Assert.IsFalse(result, "TryRemove should return false for null item.");
		Assert.AreEqual(3, hashSet.Count, "Count should remain unchanged.");
	}

	[TestMethod]
	public void TryRemove_SameItemTwice_SecondRemovalReturnsFalse()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act
		var firstResult = hashSet.TryRemove(2);
		var secondResult = hashSet.TryRemove(2);

		// Assert
		Assert.IsTrue(firstResult, "First removal should return true.");
		Assert.IsFalse(secondResult, "Second removal should return false.");
		Assert.AreEqual(2, hashSet.Count, "Count should be 2 after removing one item.");
	}

	[TestMethod]
	public void TryRemove_SingleItem_SetsBecomesEmpty()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int> { 42 };

		// Act
		var result = hashSet.TryRemove(42);

		// Assert
		Assert.IsTrue(result, "TryRemove should return true.");
		Assert.IsTrue(hashSet.IsEmpty, "Set should be empty.");
		Assert.AreEqual(0, hashSet.Count, "Count should be 0.");
	}


	[TestMethod]
	public void TryRemove_WithComparer_RemovesCorrectly()
	{
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(comparer);

		hashSet.Add("test");
		bool removeResult = hashSet.TryRemove("TEST");

		Assert.IsTrue(removeResult, "Should be able to remove item with case-insensitive key.");
		Assert.IsTrue(hashSet.IsEmpty, "Hash set should be empty after removal.");
	}

	[TestMethod]
	public void TryRemove_WithCustomComparer_RemovesCorrectly()
	{
		// Arrange
		var comparer = StringComparer.OrdinalIgnoreCase;
		var hashSet = new ConcurrentHashSet<string>(comparer) { "Test", "HELLO", "World" };

		// Act - Try to remove with different case
		var result = hashSet.TryRemove("hello");

		// Assert
		Assert.IsTrue(result, "TryRemove should find and remove item with case-insensitive comparer.");
		Assert.AreEqual(2, hashSet.Count, "Count should be 2.");
		Assert.IsFalse(hashSet.Contains("HELLO"), "Original item should be removed.");
	}

	[TestMethod]
	public void TryRemove_WithReferenceType_RemovesCorrectly()
	{
		// Arrange
		var person1 = RandomData.GeneratePerson<Person>();
		var person2 = RandomData.GeneratePerson<Person>();
		var hashSet = new ConcurrentHashSet<Person> { person1, person2 };

		// Act
		var result = hashSet.TryRemove(person1);

		// Assert
		Assert.IsTrue(result, "TryRemove should return true for existing person.");
		Assert.AreEqual(1, hashSet.Count, "Count should be 1.");
		Assert.IsFalse(hashSet.Contains(person1), "Person1 should no longer be in the set.");
		Assert.IsTrue(hashSet.Contains(person2), "Person2 should still be in the set.");
	}

	// ==================== Constructor Null Argument Validation Tests ====================

	[TestMethod]
	public void Constructor_Default_InitializesCorrectly()
	{
		// Arrange & Act
		var hashSet = new ConcurrentHashSet<int>();

		// Assert
		Assert.AreEqual(0, hashSet.Count, "Count should be 0 for a default-constructed ConcurrentHashSet.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should be true for a default-constructed ConcurrentHashSet.");
		Assert.IsFalse(hashSet.IsReadOnly, "IsReadOnly should be false.");
	}

	[TestMethod]
	public void Constructor_WithNullCollection_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => new ConcurrentHashSet<int>((IEnumerable<int>)null));
	}

	[TestMethod]
	public void Constructor_WithNullComparer_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => new ConcurrentHashSet<int>((IEqualityComparer<int>)null));
	}

	[TestMethod]
	public void Constructor_WithCollectionAndNullComparer_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => new ConcurrentHashSet<int>(collection, null));
	}

	[TestMethod]
	public void Constructor_WithNullCollectionAndComparer_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => new ConcurrentHashSet<int>(null, EqualityComparer<int>.Default));
	}

	[TestMethod]
	public void Constructor_WithConcurrencyLevelAndNullCollection_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => new ConcurrentHashSet<int>(2, null, EqualityComparer<int>.Default));
	}

	[TestMethod]
	public void Constructor_WithConcurrencyLevelCollectionAndNullComparer_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => new ConcurrentHashSet<int>(2, collection, null));
	}

	[TestMethod]
	public void Constructor_WithConcurrencyLevelCapacityAndNullComparer_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => new ConcurrentHashSet<int>(2, 10, null));
	}

	// ==================== Explicit Interface Implementation Tests ====================

	[TestMethod]
	public void IEnumerable_NonGeneric_GetEnumerator_EnumeratesAllItems()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act - Use non-generic IEnumerable interface
		IEnumerable enumerable = hashSet;
		var items = new List<int>();
		var enumerator = enumerable.GetEnumerator();
		while (enumerator.MoveNext())
		{
			items.Add((int)enumerator.Current);
		}

		// Assert
		Assert.HasCount(3, items, "Non-generic enumerator should iterate over all items.");
		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, items, "Enumerated items should match set contents.");
	}

	[TestMethod]
	public void IEnumerable_Generic_GetEnumerator_EnumeratesAllItems()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<string> { "a", "b", "c" };

		// Act - Cast to IEnumerable<T> to use explicit interface
		IEnumerable<string> enumerable = hashSet;
		var items = new List<string>();
		using (var enumerator = enumerable.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				items.Add(enumerator.Current);
			}
		}

		// Assert
		Assert.HasCount(3, items, "Generic enumerator should iterate over all items.");
		CollectionAssert.AreEquivalent(new List<string> { "a", "b", "c" }, items, "Enumerated items should match set contents.");
	}

	[TestMethod]
	public void GetEnumerator_EmptySet_ReturnsEmptyEnumeration()
	{
		// Arrange
		var hashSet = new ConcurrentHashSet<int>();

		// Act
		var items = new List<int>();
		foreach (var item in hashSet)
		{
			items.Add(item);
		}

		// Assert
		Assert.IsEmpty(items, "Enumerating an empty set should return no items.");
	}

	// ==================== CopyTo Edge Case Tests ====================

	[TestMethod]
	public void CopyTo_EmptySet_CopiesNothing()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		var array = new int[3];

		// Act
		set.CopyTo(array, 0);

		// Assert
		Assert.AreEqual(0, array[0], "Array should remain unchanged.");
		Assert.AreEqual(0, array[1], "Array should remain unchanged.");
		Assert.AreEqual(0, array[2], "Array should remain unchanged.");
	}

	[TestMethod]
	public void CopyTo_ArrayTooSmallWithOffset_ThrowsException()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };
		var array = new int[4];

		// Act & Assert - 3 items starting at index 2 would overflow array of size 4
		Assert.ThrowsExactly<ArgumentInvalidException>(() => set.CopyTo(array, 2));
	}

	// ==================== AddRange Additional Edge Case Tests ====================

	[TestMethod]
	public void AddRange_AllDuplicates_ReturnsZero()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };
		var itemsToAdd = new[] { 1, 2, 3 };

		// Act
		var result = set.AddRange(itemsToAdd);

		// Assert
		Assert.AreEqual(0, result, "AddRange should return 0 when all items are duplicates.");
		Assert.AreEqual(3, set.Count, "Count should remain unchanged.");
	}

	[TestMethod]
	public void AddRange_LargeCollection_AddsAllItems()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		var itemsToAdd = Enumerable.Range(0, 1000).ToArray();

		// Act
		var result = set.AddRange(itemsToAdd);

		// Assert
		Assert.AreEqual(1000, result, "AddRange should add all unique items.");
		Assert.AreEqual(1000, set.Count, "Set count should match.");
	}

	// ==================== Table Growth / Resize Tests ====================

	[TestMethod]
	public void Add_ManyItems_TriggersTableGrowth()
	{
		// Arrange - Default constructor sets growLockArray = true
		var hashSet = new ConcurrentHashSet<int>();

		// Act - Add enough items to trigger GrowTable (default capacity is 31)
		for (int i = 0; i < 500; i++)
		{
			hashSet.Add(i);
		}

		// Assert - All items should still be present after table growth
		Assert.AreEqual(500, hashSet.Count, "All items should be present after table growth.");
		for (int i = 0; i < 500; i++)
		{
			Assert.IsTrue(hashSet.Contains(i), $"Item {i} should be in the set after table growth.");
		}
	}

	[TestMethod]
	public void Add_ManyItems_WithFixedLockArray_TriggersTableGrowth()
	{
		// Arrange - Using concurrencyLevel+capacity constructor sets growLockArray = false
		var hashSet = new ConcurrentHashSet<int>(2, 4);

		// Act - Add enough items to trigger GrowTable without lock array growth
		for (int i = 0; i < 500; i++)
		{
			hashSet.Add(i);
		}

		// Assert
		Assert.AreEqual(500, hashSet.Count, "All items should be present after table growth with fixed lock array.");
		for (int i = 0; i < 500; i++)
		{
			Assert.IsTrue(hashSet.Contains(i), $"Item {i} should be in the set.");
		}
	}

	// ==================== ToArray Concurrent Tests ====================

	[TestMethod]
	public void ToArray_ConcurrentAccess_ThreadSafe()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();
		for (int i = 0; i < 100; i++)
		{
			set.Add(i);
		}

		var tasks = new List<Task<int[]>>();

		// Act - Multiple threads call ToArray concurrently
		for (int taskId = 0; taskId < 10; taskId++)
		{
			tasks.Add(Task.Run(() => set.ToArray()));
		}
		Task.WaitAll(tasks.ToArray());

		// Assert - All snapshots should have the same items
		foreach (var task in tasks)
		{
			Assert.HasCount(100, task.Result, "Each ToArray snapshot should contain all 100 items.");
		}
	}

	// ==================== Contains Edge Case Tests ====================

	[TestMethod]
	public void Contains_AfterRemoval_ReturnsFalse()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };
		set.TryRemove(2);

		// Act & Assert
		Assert.IsFalse(set.Contains(2), "Contains should return false for a removed item.");
		Assert.IsTrue(set.Contains(1), "Contains should return true for remaining items.");
		Assert.IsTrue(set.Contains(3), "Contains should return true for remaining items.");
	}

	[TestMethod]
	public void Contains_EmptySet_ReturnsFalse()
	{
		// Arrange
		var set = new ConcurrentHashSet<int>();

		// Act & Assert
		Assert.IsFalse(set.Contains(42), "Contains should return false for empty set.");
	}

	// ==================== Clear Edge Case Tests ====================

	[TestMethod]
	public void Clear_ThenAddItems_WorksCorrectly()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };
		set.Clear();

		// Act
		set.Add(10);
		set.Add(20);

		// Assert
		Assert.AreEqual(2, set.Count, "Count should be 2 after adding items to a cleared set.");
		Assert.IsTrue(set.Contains(10), "Set should contain newly added item.");
		Assert.IsTrue(set.Contains(20), "Set should contain newly added item.");
		Assert.IsFalse(set.Contains(1), "Set should not contain items from before Clear.");
	}

	// ==================== ICollection<T> Interface Tests ====================

	[TestMethod]
	public void ICollection_Add_WorksViaInterface()
	{
		// Arrange
		ICollection<int> collection = new ConcurrentHashSet<int>();

		// Act
		collection.Add(1);
		collection.Add(2);
		collection.Add(3);

		// Assert
		Assert.AreEqual(3, collection.Count, "ICollection.Add should add items.");
		Assert.IsTrue(collection.Contains(1), "Collection should contain added item.");
	}

	[TestMethod]
	public void ICollection_Remove_WorksViaInterface()
	{
		// Arrange
		ICollection<int> collection = new ConcurrentHashSet<int>();
		collection.Add(1);
		collection.Add(2);
		collection.Add(3);

		// Act
		var result = collection.Remove(2);

		// Assert
		Assert.IsTrue(result, "ICollection.Remove should return true for existing item.");
		Assert.AreEqual(2, collection.Count, "Count should decrease.");
		Assert.IsFalse(collection.Contains(2), "Removed item should not be in collection.");
	}

	[TestMethod]
	public void ICollection_Clear_WorksViaInterface()
	{
		// Arrange
		ICollection<int> collection = new ConcurrentHashSet<int>();
		collection.Add(1);
		collection.Add(2);

		// Act
		collection.Clear();

		// Assert
		Assert.AreEqual(0, collection.Count, "Collection should be empty after Clear.");
	}

	// ==================== IReadOnlyCollection<T> Interface Tests ====================

	[TestMethod]
	public void IReadOnlyCollection_Count_WorksViaInterface()
	{
		// Arrange
		IReadOnlyCollection<int> readOnlyCollection = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Assert
		Assert.AreEqual(3, readOnlyCollection.Count, "IReadOnlyCollection.Count should return correct count.");
	}

	[TestMethod]
	public void IReadOnlyCollection_GetEnumerator_WorksViaInterface()
	{
		// Arrange
		IReadOnlyCollection<int> readOnlyCollection = new ConcurrentHashSet<int> { 10, 20, 30 };
		var items = new List<int>();

		// Act
		foreach (var item in readOnlyCollection)
		{
			items.Add(item);
		}

		// Assert
		Assert.HasCount(3, items, "Should enumerate all items via IReadOnlyCollection.");
		CollectionAssert.AreEquivalent(new List<int> { 10, 20, 30 }, items);
	}

	// ==================== TryPeek with Value Types ====================

	[TestMethod]
	public void TryPeek_ValueType_ReturnsCorrectDefault()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3 };

		// Act
		var result = set.TryPeek(99, out var actualValue);

		// Assert
		Assert.IsFalse(result, "TryPeek should return false for non-existing value type.");
		Assert.AreEqual(0, actualValue, "ActualValue should be default(int) = 0.");
	}

	// ==================== Constructor with Collection Tests ====================

	[TestMethod]
	public void Constructor_WithEmptyCollection_InitializesEmpty()
	{
		// Arrange
		var emptyCollection = Array.Empty<int>();

		// Act
		var hashSet = new ConcurrentHashSet<int>(emptyCollection);

		// Assert
		Assert.AreEqual(0, hashSet.Count, "Should be empty when initialized with empty collection.");
		Assert.IsTrue(hashSet.IsEmpty, "IsEmpty should be true.");
	}

	[TestMethod]
	public void Constructor_WithDuplicateCollection_RemovesDuplicates()
	{
		// Arrange
		var collectionWithDuplicates = new List<int> { 1, 2, 2, 3, 3, 3 };

		// Act
		var hashSet = new ConcurrentHashSet<int>(collectionWithDuplicates);

		// Assert
		Assert.AreEqual(3, hashSet.Count, "Should only contain unique items from the collection.");
	}

	// ==================== LINQ Integration Tests ====================

	[TestMethod]
	public void LinqOperations_WorkWithConcurrentHashSet()
	{
		// Arrange
		var set = new ConcurrentHashSet<int> { 1, 2, 3, 4, 5 };

		// Act
		var evenItems = set.Where(x => x % 2 == 0).ToList();
		var sum = set.Sum();
		var any = set.Any(x => x > 3);

		// Assert
		Assert.HasCount(2, evenItems, "LINQ Where should filter correctly.");
		Assert.AreEqual(15, sum, "LINQ Sum should compute correctly.");
		Assert.IsTrue(any, "LINQ Any should return true for matching predicate.");
	}

}
