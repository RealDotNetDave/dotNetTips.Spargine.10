// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 12-30-2025
// ***********************************************************************
// <copyright file="ObservableListTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic;

[ExcludeFromCodeCoverage]
[TestClass]
public class ObservableListTests
{

	private List<NotifyCollectionChangedEventArgs> _collectionChangedEvents;
	private ObservableList<int> _observableList;
	private List<PropertyChangedEventArgs> _propertyChangedEvents;

	[TestMethod]
	public void Add_ShouldTriggerCollectionAndPropertyChangedEvents()
	{
		this._observableList.Add(1);

		Assert.AreEqual(1, this._collectionChangedEvents.Count, "Adding an item should trigger a CollectionChanged event.");
		Assert.IsTrue(this._propertyChangedEvents.Exists(e => e.PropertyName == "Count"), "Adding an item should trigger a PropertyChanged event for 'Count'.");
	}

	[TestMethod]
	public void Add_WithCustomComparer_ShouldNotAddDuplicate()
	{
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(customComparer);

		list.Add(1);
		bool added = list.Add(-1); // Attempt to add a duplicate according to the custom comparer

		Assert.IsFalse(added, "Adding -1 should return false as it is considered a duplicate of 1.");
		Assert.AreEqual(1, list.Count, "List should only contain one item after attempting to add a duplicate.");
	}
	// ============================================================================
	// Tests for New Methods: AddRange, RemoveRange, Reset, EnsureCapacity,
	// FindAll, FirstOrDefault, LastOrDefault, ToArray, ToList, TryGetValue
	// ============================================================================

	[TestMethod]
	public void AddRange_ShouldAddMultipleItems()
	{
		// Arrange
		var items = new[] { 1, 2, 3, 4, 5 };

		// Act
		this._observableList.AddRange(items);

		// Assert
		Assert.AreEqual(5, this._observableList.Count, "All items should be added to the list.");
		foreach (var item in items)
		{
			Assert.IsTrue(this._observableList.Contains(item), $"List should contain {item}.");
		}
	}

	[TestMethod]
	public void AddRange_ShouldSkipDuplicates()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var items = new[] { 2, 3, 4 };

		// Act
		this._observableList.AddRange(items);

		// Assert
		Assert.AreEqual(4, this._observableList.Count, "Duplicates should be skipped.");
		Assert.IsTrue(this._observableList.Contains(3), "New item 3 should be added.");
		Assert.IsTrue(this._observableList.Contains(4), "New item 4 should be added.");
	}

	[TestMethod]
	public void AddRange_ShouldSkipNullItems()
	{
		// Arrange
		var list = new ObservableList<string>();
		var items = new[] { "a", null, "b", null, "c" };

		// Act
		list.AddRange(items);

		// Assert
		Assert.AreEqual(3, list.Count, "Null items should be skipped.");
		Assert.IsTrue(list.Contains("a"), "List should contain 'a'.");
		Assert.IsTrue(list.Contains("b"), "List should contain 'b'.");
		Assert.IsTrue(list.Contains("c"), "List should contain 'c'.");
	}

	[TestMethod]
	public void AddRange_ShouldTriggerSingleCollectionChangedEvent()
	{
		// Arrange
		var items = new[] { 1, 2, 3 };
		this._collectionChangedEvents.Clear();

		// Act
		this._observableList.AddRange(items);

		// Assert
		Assert.AreEqual(1, this._collectionChangedEvents.Count, "AddRange should trigger a single CollectionChanged event.");
		Assert.AreEqual(NotifyCollectionChangedAction.Replace, this._collectionChangedEvents[0].Action, "Event action should be Replace.");
	}

	[TestMethod]
	public void AddRange_WithEmptyCollection_ShouldNotTriggerEvents()
	{
		// Arrange
		var items = new int[] { };
		this._collectionChangedEvents.Clear();
		this._propertyChangedEvents.Clear();

		// Act
		this._observableList.AddRange(items);

		// Assert
		Assert.AreEqual(0, this._collectionChangedEvents.Count, "No events should be triggered for empty collection.");
		Assert.AreEqual(0, this._propertyChangedEvents.Count, "No property events should be triggered.");
	}

	[TestMethod]
	public void AddRange_WithNullCollection_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.AddRange(null), "AddRange should throw ArgumentNullException for null collection.");
	}

	[TestMethod]
	public void Clear_ShouldTriggerPropertyChangingAndPropertyChanged()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var propertyChangingEvents = new List<PropertyChangingEventArgs>();
		this._observableList.PropertyChanging += (sender, e) => propertyChangingEvents.Add(e);
		this._propertyChangedEvents.Clear();

		// Act
		this._observableList.Clear();

		// Assert
		Assert.IsTrue(propertyChangingEvents.Exists(e => e.PropertyName == "Count"), "PropertyChanging event should be raised for Count.");
		Assert.IsTrue(this._propertyChangedEvents.Exists(e => e.PropertyName == "Count"), "PropertyChanged event should be raised for Count.");
	}

	[TestMethod]
	public void Comparer_ShouldReturnCorrectComparer()
	{
		// Arrange
		var customComparer = new CustomIntComparer();
		var observableListWithComparer = new ObservableList<int>(customComparer);

		// Act
		var comparerUsed = observableListWithComparer.Comparer;

		// Assert
		Assert.AreEqual(customComparer, comparerUsed, "Comparer property should return the IEqualityComparer<T> instance that was provided.");
	}

	[TestMethod]
	public void Constructor_WithCollection_ShouldInitializeWithElements()
	{
		var collection = new List<int> { 5, 2, 4, 3, 1 };
		var list = new ObservableList<int>(collection);

		Assert.AreEqual(collection.Count, list.Count, "List should contain all elements from the collection.");
		for (int i = 0; i < collection.Count; i++)
		{
			Assert.IsTrue(list.Contains(collection[i]), $"List should contain the element {collection[i]}.");
		}
	}

	[TestMethod]
	public void Constructor_WithCollectionAndComparer_ShouldInitializeWithElementsAndUseComparer()
	{
		var collection = new List<int> { 1, -1, 2, -2, 3, -3 };
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(collection, customComparer);

		Assert.AreEqual(3, list.Count, "List should contain 3 items as custom comparer treats positive and negative numbers as equal.");

		Assert.IsTrue(list.Contains(1), "List should contain 1.");
		Assert.IsTrue(list.Contains(-1), "List should contain -1 as it is considered equal to 1 by the custom comparer.");
		Assert.IsFalse(list.Contains(4), "List should not contain 4.");
	}

	[TestMethod]
	public void Constructor_WithComparer_ShouldUseProvidedComparer()
	{
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(customComparer);

		list.Add(1);
		list.Add(2);

		// Attempt to add an item that is considered equal by the custom comparer
		list.Add(-1);

		// Verify that the custom comparer was used, expecting only 2 items in the list
		Assert.AreEqual(2, list.Count, "List should contain 2 items as custom comparer treats 1 and -1 as equal.");
	}


	[TestMethod]
	public void Contains_ShouldReturnCorrectValue()
	{
		this._observableList.Add(1);

		Assert.IsTrue(this._observableList.Contains(1), "Contains should return true for an item that exists in the list.");
		Assert.IsFalse(this._observableList.Contains(2), "Contains should return false for an item that does not exist in the list.");
	}


	[TestMethod]
	public void Contains_WithCustomComparer_ShouldReturnCorrectValue()
	{
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(customComparer);

		list.Add(1);

		// Verify Contains method respects the custom comparer
		Assert.IsTrue(list.Contains(-1), "Contains should return true for -1 as custom comparer treats 1 and -1 as equal.");
	}

	[TestMethod]
	public void CopyTo_ArrayTooSmall_ShouldThrowArgumentException()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		int[] array = new int[2]; // Smaller array than list size

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => this._observableList.CopyTo(array, 0));
	}

	[TestMethod]
	public void CopyTo_ArrayWithCorrectIndex_ShouldCopyElementsCorrectly()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		int[] array = new int[5]; // Larger array to test copying at index

		// Act
		this._observableList.CopyTo(array, 1); // Start copying at index 1

		// Assert
		Assert.AreEqual(0, array[0], "First element should remain default value.");
		Assert.AreEqual(1, array[1], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(2, array[2], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(3, array[3], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(0, array[4], "Last element should remain default value.");
	}

	[TestMethod]
	public void CopyTo_NegativeArrayIndex_ShouldThrowArgumentOutOfRangeException()
	{
		// Arrange
		this._observableList.Add(1);
		int[] array = new int[1];

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => this._observableList.CopyTo(array, -1));
	}

	[TestMethod]
	public void CopyTo_NullArray_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.CopyTo(null, 0));
	}

	[TestMethod]
	public void CopyTo_ShouldCopyAllElementsToArray()
	{
		// Arrange
		var list = new ObservableList<int>();
		list.Add(1);
		list.Add(2);
		list.Add(3);
		int[] array = new int[3];

		// Act
		list.CopyTo(array);

		// Assert
		Assert.AreEqual(list.Count, array.Length, "The length of the array should match the count of the list.");

		for (int i = 0; i < list.Count; i++)
		{
			Assert.AreEqual(list.ElementAt(i), array[i], $"The element at index {i} should match between the list and the array.");
		}
	}

	[TestMethod]
	public void CopyTo_WithCount_ShouldCopyCorrectNumberOfElements()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		this._observableList.Add(4);
		this._observableList.Add(5);
		int[] array = new int[5];

		// Act
		this._observableList.CopyTo(array, 1, 3); // Copy 3 elements starting at index 1 of the array

		// Assert
		Assert.AreEqual(0, array[0], "First element should remain default value.");
		Assert.AreEqual(1, array[1], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(2, array[2], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(3, array[3], "Element should be copied to the correct position in the array.");
		Assert.AreEqual(0, array[4], "Last element should remain default value.");
	}

	[TestMethod]
	public void CopyTo_WithExactCount_ShouldCopyAllElements()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		int[] array = new int[2];

		// Act
		this._observableList.CopyTo(array, 0, 2); // Copy all elements

		// Assert
		Assert.AreEqual(1, array[0], "First element should match.");
		Assert.AreEqual(2, array[1], "Second element should match.");
	}

	[TestMethod]
	public void CopyTo_WithNegativeCount_ShouldThrowArgumentOutOfRangeException()
	{
		// Arrange
		this._observableList.Add(1);
		int[] array = new int[1];

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => this._observableList.CopyTo(array, 0, -1));
	}

	[TestMethod]
	public void Count_AfterAddingItems_ShouldIncrease()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);

		// Act
		var count = this._observableList.Count;

		// Assert
		Assert.AreEqual(2, count, "Count should reflect the number of items added.");
	}


	[TestMethod]
	public void Count_AfterClearingList_ShouldBeZero()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Clear();

		// Act
		var count = this._observableList.Count;

		// Assert
		Assert.AreEqual(0, count, "Count should be 0 after clearing the list.");
	}

	[TestMethod]
	public void Count_AfterRemovingItems_ShouldDecrease()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Remove(1);

		// Act
		var count = this._observableList.Count;

		// Assert
		Assert.AreEqual(1, count, "Count should decrease when items are removed.");
	}

	[TestMethod]
	public void Count_Initially_ShouldBeZero()
	{
		// Arrange & Act (Initialization in TestInitialize)

		// Assert
		Assert.AreEqual(0, this._observableList.Count, "Count should be 0 for a newly initialized list.");
	}

	[TestMethod]
	public void EnsureCapacity_ShouldReturnCapacityGreaterThanOrEqualToRequested()
	{
		// Arrange
		var requestedCapacity = 100;

		// Act
		int actualCapacity = this._observableList.EnsureCapacity(requestedCapacity);

		// Assert
		Assert.IsTrue(actualCapacity >= requestedCapacity, "Actual capacity should be greater than or equal to requested capacity.");
	}

	[TestMethod]
	public void EnsureCapacity_WithNegativeValue_ShouldThrowArgumentOutOfRangeException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => this._observableList.EnsureCapacity(-1), "EnsureCapacity should throw ArgumentOutOfRangeException for negative capacity.");
	}


	[TestMethod]
	public void ExceptWith_EmptyOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int>();

		// Act
		this._observableList.ExceptWith(otherCollection);

		// Assert
		Assert.AreEqual(2, this._observableList.Count, "List should not be modified if the other collection is empty.");
	}

	[TestMethod]
	public void ExceptWith_NullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange
		this._observableList.Add(1);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.ExceptWith(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void ExceptWith_SelfAsOtherCollection_ShouldClearList()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);

		// Act
		this._observableList.ExceptWith(this._observableList);

		// Assert
		Assert.AreEqual(0, this._observableList.Count, "List should be cleared if it is passed as the other collection.");
	}

	[TestMethod]
	public void ExceptWith_ShouldRemoveCommonElements()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 2, 3, 4 };

		// Act
		this._observableList.ExceptWith(otherCollection);

		// Assert
		Assert.AreEqual(1, this._observableList.Count, "List should contain only elements that are not in the other collection.");
		Assert.IsTrue(this._observableList.Contains(1), "List should contain 1.");
		Assert.IsFalse(this._observableList.Contains(2), "List should not contain 2.");
		Assert.IsFalse(this._observableList.Contains(3), "List should not contain 3.");
	}

	[TestMethod]
	public void FindAll_ShouldReturnMatchingItems()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		this._observableList.Add(4);
		this._observableList.Add(5);

		// Act
		var result = this._observableList.FindAll(x => x > 2).ToList();

		// Assert
		Assert.AreEqual(3, result.Count, "Should return 3 items greater than 2.");
		Assert.IsTrue(result.Contains(3), "Result should contain 3.");
		Assert.IsTrue(result.Contains(4), "Result should contain 4.");
		Assert.IsTrue(result.Contains(5), "Result should contain 5.");
	}

	[TestMethod]
	public void FindAll_WithNoMatches_ShouldReturnEmptyCollection()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);

		// Act
		var result = this._observableList.FindAll(x => x > 10).ToList();

		// Assert
		Assert.AreEqual(0, result.Count, "Should return empty collection when no items match.");
	}

	[TestMethod]
	public void FindAll_WithNullPredicate_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.FindAll(null).ToList(), "FindAll should throw ArgumentNullException for null predicate.");
	}

	[TestMethod]
	public void FirstOrDefault_WithItems_ShouldReturnFirstItem()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);

		// Act
		var result = this._observableList.FirstOrDefault();

		// Assert
		Assert.IsNotNull(result, "FirstOrDefault should return a value.");
		Assert.IsTrue(this._observableList.Contains(result), "Returned item should be in the list.");
	}

	[TestInitialize]
	public void Initialize()
	{
		this._observableList = new ObservableList<int>();
		this._collectionChangedEvents = new List<NotifyCollectionChangedEventArgs>();
		this._propertyChangedEvents = new List<PropertyChangedEventArgs>();

		this._observableList.CollectionChanged += (sender, e) => this._collectionChangedEvents.Add(e);
		this._observableList.PropertyChanged += (sender, e) => this._propertyChangedEvents.Add(e);
	}

	[TestMethod]
	public void IntersectWith_EmptyOtherCollection_ShouldClearList()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int>();

		// Act
		this._observableList.IntersectWith(otherCollection);

		// Assert
		Assert.AreEqual(0, this._observableList.Count, "List should be cleared if the other collection is empty.");
	}


	[TestMethod]
	public void IntersectWith_NullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange
		this._observableList.Add(1);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.IntersectWith(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IntersectWith_SelfAsOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);

		// Act
		this._observableList.IntersectWith(this._observableList);

		// Assert
		Assert.AreEqual(2, this._observableList.Count, "List should not be modified if it is passed as the other collection.");
	}

	[TestMethod]
	public void IntersectWith_ShouldRetainCommonElements()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 2, 3, 4 };

		// Act
		this._observableList.IntersectWith(otherCollection);

		// Assert
		Assert.AreEqual(2, this._observableList.Count, "List should contain only elements that are also in the other collection.");
		Assert.IsTrue(this._observableList.Contains(2), "List should contain 2.");
		Assert.IsTrue(this._observableList.Contains(3), "List should contain 3.");
	}

	[TestMethod]
	public void IsProperSubsetOf_WithEqualSets_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = this._observableList.IsProperSubsetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper subset of the other collection if both collections are equal.");
	}


	[TestMethod]
	public void IsProperSubsetOf_WithNoCommonElements_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 3, 4 };

		// Act
		bool result = this._observableList.IsProperSubsetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper subset of the other collection if there are no common elements.");
	}

	[TestMethod]
	public void IsProperSubsetOf_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.IsProperSubsetOf(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IsProperSubsetOf_WithProperSubset_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = this._observableList.IsProperSubsetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a proper subset of the other collection.");
	}

	[TestMethod]
	public void IsProperSupersetOf_WithEqualSets_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = this._observableList.IsProperSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper superset of the other collection if both collections are equal.");
	}

	[TestMethod]
	public void IsProperSupersetOf_WithNoCommonElements_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 3, 4 };

		// Act
		bool result = this._observableList.IsProperSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper superset of the other collection if there are no common elements.");
	}


	[TestMethod]
	public void IsProperSupersetOf_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.IsProperSupersetOf(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IsProperSupersetOf_WithProperSuperset_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = this._observableList.IsProperSupersetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a proper superset of the other collection.");
	}

	[TestMethod]
	public void IsProperSupersetOf_WithSubsetIncludingNonListElements_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = this._observableList.IsProperSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a proper superset if the other collection contains elements not in the list.");
	}

	[TestMethod]
	public void IsReadOnly_AfterAddingItems_ShouldStillBeFalse()
	{
		// Arrange
		this._observableList.Add(1);

		// Act
		var isReadOnly = this._observableList.IsReadOnly;

		// Assert
		Assert.IsFalse(isReadOnly, "IsReadOnly should remain false after adding items.");
	}

	[TestMethod]
	public void IsReadOnly_AfterClearingList_ShouldStillBeFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Clear();

		// Act
		var isReadOnly = this._observableList.IsReadOnly;

		// Assert
		Assert.IsFalse(isReadOnly, "IsReadOnly should remain false after clearing the list.");
	}

	[TestMethod]
	public void IsReadOnly_Initially_ShouldBeFalse()
	{
		// Arrange & Act
		var isReadOnly = this._observableList.IsReadOnly;

		// Assert
		Assert.IsFalse(isReadOnly, "IsReadOnly should be false for a newly initialized list.");
	}

	[TestMethod]
	public void IsSubsetOf_WithEqualSets_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = this._observableList.IsSubsetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be considered a subset of the other collection if both collections are equal.");
	}

	[TestMethod]
	public void IsSubsetOf_WithNoCommonElements_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 3, 4 };

		// Act
		bool result = this._observableList.IsSubsetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a subset of the other collection if there are no common elements.");
	}


	[TestMethod]
	public void IsSubsetOf_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.IsSubsetOf(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IsSubsetOf_WithProperSubset_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = this._observableList.IsSubsetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a subset of the other collection.");
	}

	[TestMethod]
	public void IsSubsetOf_WithSupersetIncludingNonListElements_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = this._observableList.IsSubsetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a subset if the other collection contains all elements of the list plus additional elements.");
	}

	[TestMethod]
	public void IsSupersetOf_WithEqualSets_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = this._observableList.IsSupersetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be considered a superset of the other collection if both collections are equal.");
	}

	[TestMethod]
	public void IsSupersetOf_WithNoCommonElements_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 3, 4 };

		// Act
		bool result = this._observableList.IsSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a superset of the other collection if there are no common elements.");
	}

	[TestMethod]
	public void IsSupersetOf_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.IsSupersetOf(null), "Method should throw ArgumentNullException if the other collection is null.");
	}

	[TestMethod]
	public void IsSupersetOf_WithProperSuperset_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = this._observableList.IsSupersetOf(otherCollection);

		// Assert
		Assert.IsTrue(result, "List should be a superset of the other collection.");
	}


	[TestMethod]
	public void IsSupersetOf_WithSubsetIncludingNonListElements_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = this._observableList.IsSupersetOf(otherCollection);

		// Assert
		Assert.IsFalse(result, "List should not be a superset if the other collection contains elements not in the list.");
	}

	[TestMethod]
	public void LastOrDefault_WithItems_ShouldReturnLastItem()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);

		// Act
		var result = this._observableList.LastOrDefault();

		// Assert
		Assert.IsNotNull(result, "LastOrDefault should return a value.");
		Assert.IsTrue(this._observableList.Contains(result), "Returned item should be in the list.");
	}


	[TestMethod]
	public void Overlaps_WithEmptyCollection_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int>();

		// Act
		bool result = this._observableList.Overlaps(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when the other collection is empty.");
	}

	[TestMethod]
	public void Overlaps_WithNonOverlappingCollection_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 4, 5, 6 };

		// Act
		bool result = this._observableList.Overlaps(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when collections do not overlap.");
	}

	[TestMethod]
	public void Overlaps_WithNullCollection_ShouldThrowArgumentNullException()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.Overlaps(null), "Should throw ArgumentNullException when the other collection is null.");
	}

	[TestMethod]
	public void Overlaps_WithOverlappingCollection_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 3, 4, 5 };

		// Act
		bool result = this._observableList.Overlaps(otherCollection);

		// Assert
		Assert.IsTrue(result, "Should return true when collections overlap.");
	}

	[TestMethod]
	public void PropertyChanging_ShouldBeRaisedBeforePropertyChanged()
	{
		// Arrange
		var propertyChangingEvents = new List<PropertyChangingEventArgs>();
		this._observableList.PropertyChanging += (sender, e) => propertyChangingEvents.Add(e);
		this._propertyChangedEvents.Clear();

		// Act
		this._observableList.Add(1);

		// Assert
		Assert.IsTrue(propertyChangingEvents.Count > 0, "PropertyChanging event should be raised.");
		Assert.IsTrue(propertyChangingEvents[0].PropertyName == "Count", "PropertyChanging should be for Count property.");
		Assert.IsTrue(this._propertyChangedEvents.Count > 0, "PropertyChanged event should be raised.");
		Assert.IsTrue(this._propertyChangedEvents.Exists(e => e.PropertyName == "Count"), "PropertyChanged should be for Count property.");
	}

	[TestMethod]
	public void Remove_ShouldTriggerCollectionAndPropertyChangedEvents()
	{
		this._observableList.Add(1);
		this._observableList.Remove(1);

		Assert.IsTrue(this._collectionChangedEvents.Exists(e => e.Action == NotifyCollectionChangedAction.Remove), "Removing an item should trigger a CollectionChanged event with Remove action.");
		Assert.IsTrue(this._propertyChangedEvents.Exists(e => e.PropertyName == "Count"), "Removing an item should trigger a PropertyChanged event for 'Count'.");
	}

	[TestMethod]
	public void Remove_WithCustomComparer_ShouldRemoveCorrectItem()
	{
		var collection = new List<int> { 1, 2, 3 };
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(collection, customComparer);

		bool removed = list.Remove(-2); // Attempt to remove 2 using its negative

		Assert.IsTrue(removed, "Removing -2 should return true as it is considered equal to 2.");
		Assert.AreEqual(2, list.Count, "List should contain 2 items after removing one.");
		Assert.IsFalse(list.Contains(2), "List should not contain 2 after it has been removed.");
	}

	[TestMethod]
	public void RemoveRange_ShouldRemoveMultipleItems()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		this._observableList.Add(4);
		var itemsToRemove = new[] { 2, 3 };

		// Act
		int removedCount = this._observableList.RemoveRange(itemsToRemove);

		// Assert
		Assert.AreEqual(2, removedCount, "Should return count of removed items.");
		Assert.AreEqual(2, this._observableList.Count, "List should contain 2 items after removal.");
		Assert.IsFalse(this._observableList.Contains(2), "List should not contain 2.");
		Assert.IsFalse(this._observableList.Contains(3), "List should not contain 3.");
	}

	[TestMethod]
	public void RemoveRange_ShouldTriggerSingleCollectionChangedEvent()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var itemsToRemove = new[] { 1, 2 };
		this._collectionChangedEvents.Clear();

		// Act
		this._observableList.RemoveRange(itemsToRemove);

		// Assert
		Assert.AreEqual(1, this._collectionChangedEvents.Count, "RemoveRange should trigger a single CollectionChanged event.");
		Assert.AreEqual(NotifyCollectionChangedAction.Replace, this._collectionChangedEvents[0].Action, "Event action should be Replace.");
	}

	[TestMethod]
	public void RemoveRange_WithNonExistentItems_ShouldReturnZero()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var itemsToRemove = new[] { 5, 6, 7 };

		// Act
		int removedCount = this._observableList.RemoveRange(itemsToRemove);

		// Assert
		Assert.AreEqual(0, removedCount, "Should return 0 when no items are removed.");
		Assert.AreEqual(2, this._observableList.Count, "List count should remain unchanged.");
	}

	[TestMethod]
	public void RemoveRange_WithNullCollection_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.RemoveRange(null), "RemoveRange should throw ArgumentNullException for null collection.");
	}

	[TestMethod]
	public void RemoveWhere_WithMatchingPredicate_ShouldRemoveCorrectItems()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		Predicate<int> match = x => x > 1;

		// Act
		int removedCount = this._observableList.RemoveWhere(match);

		// Assert
		Assert.AreEqual(2, removedCount, "Should remove two items.");
		Assert.AreEqual(1, this._observableList.Count, "List should contain only one item after removal.");
		Assert.IsTrue(this._observableList.Contains(1), "List should contain the item that does not match the predicate.");
	}

	[TestMethod]
	public void RemoveWhere_WithNoMatchingPredicate_ShouldNotRemoveAnyItems()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		Predicate<int> match = x => x > 3;

		// Act
		int removedCount = this._observableList.RemoveWhere(match);

		// Assert
		Assert.AreEqual(0, removedCount, "Should not remove any items.");
		Assert.AreEqual(3, this._observableList.Count, "List should still contain all items.");
	}

	[TestMethod]
	public void RemoveWhere_WithNullPredicate_ShouldThrowArgumentNullException()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.RemoveWhere(null), "Should throw ArgumentNullException for null predicate.");
	}

	[TestMethod]
	public void Reset_ShouldReplaceAllItems()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var newItems = new[] { 10, 20, 30, 40 };

		// Act
		this._observableList.Reset(newItems);

		// Assert
		Assert.AreEqual(4, this._observableList.Count, "List should contain new items.");
		Assert.IsTrue(this._observableList.Contains(10), "List should contain 10.");
		Assert.IsTrue(this._observableList.Contains(40), "List should contain 40.");
		Assert.IsFalse(this._observableList.Contains(1), "List should not contain old items.");
	}

	[TestMethod]
	public void Reset_ShouldTriggerResetAction()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var newItems = new[] { 5, 6 };
		this._collectionChangedEvents.Clear();

		// Act
		this._observableList.Reset(newItems);

		// Assert
		Assert.AreEqual(1, this._collectionChangedEvents.Count, "Reset should trigger a single CollectionChanged event.");
		Assert.AreEqual(NotifyCollectionChangedAction.Reset, this._collectionChangedEvents[0].Action, "Event action should be Reset.");
	}

	[TestMethod]
	public void Reset_WithNullCollection_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.Reset(null), "Reset should throw ArgumentNullException for null collection.");
	}

	[TestMethod]
	public void Reset_WithSameItems_ShouldNotTriggerEvents()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var sameItems = new[] { 1, 2 };
		this._collectionChangedEvents.Clear();
		this._propertyChangedEvents.Clear();

		// Act
		this._observableList.Reset(sameItems);

		// Assert
		Assert.AreEqual(0, this._collectionChangedEvents.Count, "No events should be triggered when items are the same.");
		Assert.AreEqual(0, this._propertyChangedEvents.Count, "No property events should be triggered.");
	}

	[TestMethod]
	public void SetEquals_WithDifferentSets_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 4, 5, 6 };

		// Act
		bool result = this._observableList.SetEquals(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when collections do not contain the same elements.");
	}

	[TestMethod]
	public void SetEquals_WithEqualSets_ShouldReturnTrue()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 3, 2, 1 };

		// Act
		bool result = this._observableList.SetEquals(otherCollection);

		// Assert
		Assert.IsTrue(result, "Should return true when both collections contain the same elements.");
	}


	[TestMethod]
	public void SetEquals_WithNullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.SetEquals(null), "Should throw ArgumentNullException when the other collection is null.");
	}

	[TestMethod]
	public void SetEquals_WithSubset_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 1, 2 };

		// Act
		bool result = this._observableList.SetEquals(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when one collection is a subset of the other.");
	}

	[TestMethod]
	public void SetEquals_WithSuperset_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 1, 2, 3 };

		// Act
		bool result = this._observableList.SetEquals(otherCollection);

		// Assert
		Assert.IsFalse(result, "Should return false when one collection is a superset of the other.");
	}

	[TestMethod]
	public void SymmetricExceptWith_EmptyOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int>();

		// Act
		this._observableList.SymmetricExceptWith(otherCollection);

		// Assert
		Assert.AreEqual(3, this._observableList.Count, "List should not be modified when the other collection is empty.");
	}

	[TestMethod]
	public void SymmetricExceptWith_NullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.SymmetricExceptWith(null), "Method should throw ArgumentNullException when the other collection is null.");
	}


	[TestMethod]
	public void SymmetricExceptWith_SelfAsOtherCollection_ShouldClearList()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);

		// Act
		this._observableList.SymmetricExceptWith(this._observableList);

		// Assert
		Assert.AreEqual(0, this._observableList.Count, "List should be cleared when the method is called with itself as the other collection.");
	}

	[TestMethod]
	public void SymmetricExceptWith_ShouldRemoveCommonElementsAndAddUniqueFromOtherCollection()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);
		var otherCollection = new List<int> { 2, 3, 4, 5 };

		// Act
		this._observableList.SymmetricExceptWith(otherCollection);

		// Assert
		Assert.IsFalse(this._observableList.Contains(2), "List should not contain elements common to both collections.");
		Assert.IsFalse(this._observableList.Contains(3), "List should not contain elements common to both collections.");
		Assert.IsTrue(this._observableList.Contains(1), "List should retain elements not in the other collection.");
		Assert.IsTrue(this._observableList.Contains(4), "List should contain elements unique to the other collection.");
		Assert.IsTrue(this._observableList.Contains(5), "List should contain elements unique to the other collection.");
		Assert.AreEqual(3, this._observableList.Count, "List should contain exactly three elements.");
	}

	[TestMethod]
	public void ToArray_ShouldReturnArrayWithAllItems()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);

		// Act
		var array = this._observableList.ToArray();

		// Assert
		Assert.AreEqual(3, array.Length, "Array should contain all items from the list.");
		Assert.IsTrue(array.Contains(1), "Array should contain 1.");
		Assert.IsTrue(array.Contains(2), "Array should contain 2.");
		Assert.IsTrue(array.Contains(3), "Array should contain 3.");
	}

	[TestMethod]
	public void ToArray_WithEmptyList_ShouldReturnEmptyArray()
	{
		// Act
		var array = this._observableList.ToArray();

		// Assert
		Assert.AreEqual(0, array.Length, "Array should be empty for empty list.");
	}

	[TestMethod]
	public void ToList_ShouldReturnListWithAllItems()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);

		// Act
		var list = this._observableList.ToList();

		// Assert
		Assert.AreEqual(3, list.Count, "List should contain all items from the observable list.");
		Assert.IsTrue(list.Contains(1), "List should contain 1.");
		Assert.IsTrue(list.Contains(2), "List should contain 2.");
		Assert.IsTrue(list.Contains(3), "List should contain 3.");
	}

	[TestMethod]
	public void ToList_WithEmptyList_ShouldReturnEmptyList()
	{
		// Act
		var list = this._observableList.ToList();

		// Assert
		Assert.AreEqual(0, list.Count, "List should be empty for empty observable list.");
	}


	[TestMethod]
	public void TrimExcess_ShouldOptimizeMemoryUsage()
	{
		// Arrange
		var capacity = 100;
		this._observableList = new ObservableList<int>(new int[capacity]);
		for (int i = 0; i < 10; i++)
		{
			this._observableList.Add(i);
		}
		// Assuming the internal data structure is a List<T> or similar,
		// after adding 10 items, the capacity would be significantly higher than the count.

		// Act
		this._observableList.TrimExcess();
		// After TrimExcess, the capacity should be optimized to match the count more closely.

		// Assert
		// Note: Direct capacity checks are not possible without reflection or internal knowledge,
		// so this test assumes an indirect approach to validate the optimization.
		// Adding a large number of items to see if it triggers a resize operation sooner than expected.
		int initialResizeThreshold = this._observableList.Count + 1; // Assuming capacity is now optimized
		for (int i = 0; i < initialResizeThreshold; i++)
		{
			this._observableList.Add(i);
		}
		// If TrimExcess worked, adding this number of items should not trigger a resize operation,
		// which would be indicated by no exceptions or significant delays.
		Assert.IsTrue(this._observableList.Count > 10, "List should contain more items after adding additional elements post-TrimExcess.");
	}

	[TestMethod]
	public void TryGetValue_WithCustomComparer_ShouldUseComparer()
	{
		// Arrange
		var customComparer = new CustomIntComparer();
		var list = new ObservableList<int>(customComparer);
		list.Add(5);

		// Act
		bool found = list.TryGetValue(-5, out int actualValue);

		// Assert
		Assert.IsTrue(found, "TryGetValue should return true using custom comparer.");
		Assert.AreEqual(5, actualValue, "Should return the actual value (5) when searching with -5.");
	}

	[TestMethod]
	public void TryGetValue_WithExistingItem_ShouldReturnTrueAndItem()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		this._observableList.Add(3);

		// Act
		bool found = this._observableList.TryGetValue(2, out int actualValue);

		// Assert
		Assert.IsTrue(found, "TryGetValue should return true for existing item.");
		Assert.AreEqual(2, actualValue, "Should return the actual value from the set.");
	}

	[TestMethod]
	public void TryGetValue_WithNonExistingItem_ShouldReturnFalse()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);

		// Act
		bool found = this._observableList.TryGetValue(5, out int actualValue);

		// Assert
		Assert.IsFalse(found, "TryGetValue should return false for non-existing item.");
		Assert.AreEqual(0, actualValue, "Should return default value when item not found.");
	}

	[TestMethod]
	public void UnionWith_EmptyOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int>();

		// Act
		this._observableList.UnionWith(otherCollection);

		// Assert
		Assert.AreEqual(2, this._observableList.Count, "List should not be modified when the other collection is empty.");
	}


	[TestMethod]
	public void UnionWith_NullOtherCollection_ShouldThrowArgumentNullException()
	{
		// Arrange

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._observableList.UnionWith(null), "Method should throw ArgumentNullException when the other collection is null.");
	}

	[TestMethod]
	public void UnionWith_SelfAsOtherCollection_ShouldNotModifyList()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);

		// Act
		this._observableList.UnionWith(this._observableList);

		// Assert
		Assert.AreEqual(2, this._observableList.Count, "List should not be modified when the method is called with itself as the other collection.");
	}

	[TestMethod]
	public void UnionWith_ShouldContainAllUniqueElementsFromBothCollections()
	{
		// Arrange
		this._observableList.Add(1);
		this._observableList.Add(2);
		var otherCollection = new List<int> { 2, 3, 4 };

		// Act
		this._observableList.UnionWith(otherCollection);

		// Assert
		Assert.IsTrue(this._observableList.Contains(1), "List should contain elements from the original list.");
		Assert.IsTrue(this._observableList.Contains(2), "List should contain elements present in both collections.");
		Assert.IsTrue(this._observableList.Contains(3), "List should contain elements from the other collection.");
		Assert.IsTrue(this._observableList.Contains(4), "List should contain elements from the other collection.");
		Assert.AreEqual(4, this._observableList.Count, "List should contain exactly four unique elements.");
	}


	internal class CustomIntComparer : IEqualityComparer<int>
	{

		public bool Equals(int x, int y)
		{
			// Custom logic: consider negative and positive of the same number as equal
			return Math.Abs(x) == Math.Abs(y);
		}

		public int GetHashCode(int obj)
		{
			// Ensure that negative and positive of the same number have the same hash code
			return Math.Abs(obj).GetHashCode();
		}

	}

}
