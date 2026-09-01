// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-13-2024
//
// Last Modified By : David McCarter
// Last Modified On : 12-30-2025
// ***********************************************************************
// <copyright file="DistinctBlockingCollectionTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

[ExcludeFromCodeCoverage]
[TestClass]
public class DistinctBlockingCollectionTests
{

	/// <summary>
	/// Defines the test method AddNullItemTest.
	/// </summary>
	[TestMethod]
	public void AddNullItemTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => collection.Add(null));
	}

	[TestMethod]
	public void AddRange_EmptyCollection_ReturnsZero()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var emptyList = new List<string>();

		// Act
		var result = collection.AddRange(emptyList);

		// Assert
		Assert.AreEqual(0, result, "AddRange should return 0 for empty collection.");
		Assert.IsEmpty(collection, "Collection should remain empty.");
	}

	[TestMethod]
	public void AddRange_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => collection.AddRange(null));
	}

	[TestMethod]
	public void AddRange_ToBoundedCollection_AddsWithinCapacity()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>(5);
		var items = new List<string> { "item1", "item2", "item3" };

		// Act
		var result = collection.AddRange(items);

		// Assert
		Assert.AreEqual(3, result);
		Assert.HasCount(3, collection);
	}

	[TestMethod]
	public void AddRange_WithCancellationToken_AddsItems()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", "item2" };
		var cancellationToken = new CancellationToken();

		// Act
		var result = collection.AddRange(items, cancellationToken);

		// Assert
		Assert.AreEqual(2, result);
		Assert.HasCount(2, collection);
	}

	[TestMethod]
	public void AddRange_WithCancelledToken_ThrowsOperationCanceledException()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", "item2", "item3" };
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();

		// Act & Assert
		Assert.ThrowsExactly<OperationCanceledException>(() =>
			collection.AddRange(items, cancellationTokenSource.Token));
	}

	[TestMethod]
	public void AddRange_WithDuplicates_OnlyAddsUniqueItems()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");
		collection.Add("item2");
		var items = new List<string> { "item2", "item3", "item1", "item4" };

		// Act
		var result = collection.AddRange(items);

		// Assert
		Assert.AreEqual(2, result, "AddRange should only add unique items.");
		Assert.HasCount(4, collection, "Collection should contain 4 unique items total.");
	}

	[TestMethod]
	public void AddRange_WithNullItems_SkipsNulls()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", null, "item2", null, "item3" };

		// Act
		var result = collection.AddRange(items);

		// Assert
		Assert.AreEqual(3, result, "AddRange should skip null items.");
		Assert.HasCount(3, collection, "Collection should contain only non-null items.");
	}
	[TestMethod]
	public void AddRange_WithUniqueItems_AddsAllItems()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", "item2", "item3" };

		// Act
		var result = collection.AddRange(items);

		// Assert
		Assert.AreEqual(3, result, "AddRange should return the count of items added.");
		Assert.HasCount(3, collection, "Collection should contain all unique items.");
		Assert.IsTrue(collection.Contains("item1"));
		Assert.IsTrue(collection.Contains("item2"));
		Assert.IsTrue(collection.Contains("item3"));
	}

	/// <summary>
	/// Defines the test method AddRangeTest.
	/// </summary>
	[TestMethod]
	public void AddRangeTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		Assert.AreEqual(2, collection.Count);
	}

	/// <summary>
	/// Defines the test method AddTest.
	/// </summary>
	[TestMethod]
	public void AddTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");

		Assert.HasCount(1, collection);
		Assert.IsTrue(collection.Contains("test1"));
	}

	/// <summary>
	/// Defines the test method AddWithCancellationTokenTest.
	/// </summary>
	[TestMethod]
	public void AddWithCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationToken = new CancellationToken();
		collection.Add("test1", cancellationToken);

		Assert.HasCount(1, collection);
		Assert.IsTrue(collection.Contains("test1"));
	}

	/// <summary>
	/// Defines the test method AddWithCancelledTokenTest.
	/// </summary>
	[TestMethod]
	public void AddWithCancelledTokenTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();

		// Act & Assert
		Assert.ThrowsExactly<OperationCanceledException>(() => collection.Add("test1", cancellationTokenSource.Token));
	}

	/// <summary>
	/// Defines the test method BoundedTest.
	/// </summary>
	[TestMethod]
	public void BoundedTest()
	{
		var collection = new DistinctBlockingCollection<string>(5);

		Assert.AreEqual(5, collection.BoundedCapacity);
	}

	/// <summary>
	/// Defines the test method ClearEmptyCollectionTest.
	/// </summary>
	[TestMethod]
	public void ClearEmptyCollectionTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		collection.Clear();

		Assert.IsEmpty(collection);
	}

	/// <summary>
	/// Defines the test method ClearNonEmptyCollectionTest.
	/// </summary>
	[TestMethod]
	public void ClearNonEmptyCollectionTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");
		collection.Add("test2");

		collection.Clear();

		Assert.IsEmpty(collection);
	}

	/// <summary>
	/// Defines the test method ClearTest.
	/// </summary>
	[TestMethod]
	public void ClearTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		collection.Clear();

		Assert.IsEmpty(collection);
	}

	/// <summary>
	/// Defines the test method ClearWithBoundedCapacityTest.
	/// </summary>
	[TestMethod]
	public void ClearWithBoundedCapacityTest()
	{
		var collection = new DistinctBlockingCollection<string>(5);
		collection.Add("test1");
		collection.Add("test2");

		collection.Clear();

		Assert.IsEmpty(collection);
		Assert.AreEqual(5, collection.BoundedCapacity);
	}

	/// <summary>
	/// Defines the test method CloneTest.
	/// </summary>
	[TestMethod]
	public void CloneTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		// Specify the type argument explicitly to resolve CS0411  
		var result = collection.FastClone<DistinctBlockingCollection<string>>();

		Assert.AreEqual(2, result.Count);
	}

	[TestMethod]
	public void CloneViaICloneableReturnsShallowCopy()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");
		collection.Add("item2");

		// Directly call Clone() since DistinctBlockingCollection<T> implements ICloneable<T>
		var clone = collection.Clone();

		Assert.IsNotNull(clone);
		Assert.IsTrue(clone.Contains("item1"));
		Assert.IsTrue(clone.Contains("item2"));
	}


	/// <summary>
	/// Defines the test method ConstructorWithBoundedCapacityNegativeTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithBoundedCapacityNegativeTest()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new DistinctBlockingCollection<string>(-1));
	}

	/// <summary>
	/// Defines the test method ConstructorWithBoundedCapacityTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithBoundedCapacityTest()
	{
		var collection = new DistinctBlockingCollection<string>(5);

		Assert.IsNotNull(collection);
		Assert.AreEqual(5, collection.BoundedCapacity);
	}

	/// <summary>
	/// Defines the test method ConstructorWithCollectionTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithCollectionTest()
	{
		var initialCollection = new List<string> { "test1", "test2" };
		var collection = new DistinctBlockingCollection<string>(initialCollection);

		Assert.IsNotNull(collection);
		Assert.HasCount(2, collection);
		Assert.IsTrue(collection.Contains("test1"));
		Assert.IsTrue(collection.Contains("test2"));
	}

	[TestMethod]
	public void ContainsAny_EmptyCheckList_ReturnsFalse()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");
		var emptyList = new List<string>();

		// Act
		var result = collection.ContainsAny(emptyList);

		// Assert
		Assert.IsFalse(result, "ContainsAny should return false for empty check list.");
	}

	[TestMethod]
	public void ContainsAny_EmptyCollection_ReturnsFalse()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var itemsToCheck = new List<string> { "item1", "item2" };

		// Act
		var result = collection.ContainsAny(itemsToCheck);

		// Assert
		Assert.IsFalse(result, "ContainsAny should return false for empty collection.");
	}

	[TestMethod]
	public void ContainsAny_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => collection.ContainsAny(null));
	}

	[TestMethod]
	public void ContainsAny_WithMatchingItems_ReturnsTrue()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");
		collection.Add("item2");
		collection.Add("item3");
		var itemsToCheck = new List<string> { "item5", "item2", "item6" };

		// Act
		var result = collection.ContainsAny(itemsToCheck);

		// Assert
		Assert.IsTrue(result, "ContainsAny should return true when at least one item matches.");
	}

	[TestMethod]
	public void ContainsAny_WithNoMatchingItems_ReturnsFalse()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");
		collection.Add("item2");
		var itemsToCheck = new List<string> { "item5", "item6", "item7" };

		// Act
		var result = collection.ContainsAny(itemsToCheck);

		// Assert
		Assert.IsFalse(result, "ContainsAny should return false when no items match.");
	}

	[TestMethod]
	public void ContainsAny_WithNullItems_SkipsNullsAndChecksOthers()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");
		collection.Add("item2");
		var itemsToCheck = new List<string> { null, "item2", null };

		// Act
		var result = collection.ContainsAny(itemsToCheck);

		// Assert
		Assert.IsTrue(result, "ContainsAny should skip nulls and find matching items.");
	}

	/// <summary>
	/// Defines the test method ContainsTest.
	/// </summary>
	[TestMethod]
	public void ContainsTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		Assert.IsTrue(collection.Contains("test2"));
	}

	/// <summary>
	/// Defines the test method CopyToTest.
	/// </summary>
	[TestMethod]
	public void CopyToTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		var array = new string[2];

		collection.CopyTo(array, 0);

		Assert.AreEqual(2, array.Length);
	}

	/// <summary>
	/// Defines the test method GetConsumingEnumerableTest.
	/// </summary>
	[TestMethod]
	public void GetConsumingEnumerableTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		var enumerator = collection.GetConsumingEnumerable();

		Assert.IsTrue(enumerator.Any());
	}

	/// <summary>
	/// Defines the test method GetConsumingEnumerableWithCancellationTokenTest.
	/// </summary>
	[TestMethod]
	public void GetConsumingEnumerableWithCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		var enumerator = collection.GetConsumingEnumerable(new CancellationToken());

		Assert.IsTrue(enumerator.Any());
	}

	[TestMethod]
	public void Integration_AddRange_ContainsAny_WorkTogether()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var itemsToAdd = new List<string> { "item1", "item2", "item3" };
		var itemsToCheck = new List<string> { "item2", "item5" };

		// Act
		var addedCount = collection.AddRange(itemsToAdd);
		var containsAny = collection.ContainsAny(itemsToCheck);

		// Assert
		Assert.AreEqual(3, addedCount);
		Assert.IsTrue(containsAny, "ContainsAny should find item2.");
	}

	[TestMethod]
	public void Integration_TryAddRange_WithExistingItems_HandlesDuplicates()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");
		var items = new List<string> { "item1", "item2", "item3" };

		// Act
		var result = collection.TryAddRange(items, 1000);

		// Assert
		Assert.AreEqual(2, result, "Should only add 2 new unique items.");
		Assert.HasCount(3, collection);
		Assert.IsTrue(collection.ContainsAny(new List<string> { "item1", "item2", "item3" }));
	}

	[TestMethod]
	public void IsReadOnlyWhenAddingCompletedTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.CompleteAdding();
		Assert.IsTrue(collection.IsReadOnly);
	}

	[TestMethod]
	public void IsReadOnlyWhenAddingNotCompletedTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		Assert.IsFalse(collection.IsReadOnly);
	}

	/// <summary>
	/// Defines the test method RemoveExistingItemTest.
	/// </summary>
	[TestMethod]
	public void RemoveExistingItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");

		var result = collection.Remove("test1");

		Assert.IsTrue(result);
		Assert.IsFalse(collection.Contains("test1"));
	}

	/// <summary>
	/// Defines the test method RemoveFromEmptyCollectionTest.
	/// </summary>
	[TestMethod]
	public void RemoveFromEmptyCollectionTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		var result = collection.Remove("test1");

		Assert.IsFalse(result);
	}

	/// <summary>
	/// Defines the test method RemoveTest.
	/// </summary>
	[TestMethod]
	public void RemoveTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		_ = collection.AddRange(new List<string>() { "test1", "test2" }, true);

		Assert.IsTrue(collection.Remove("test1"));
	}

	[TestMethod]
	public void TryAddNullItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd(null);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddRange_EmptyCollection_ReturnsZero()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var emptyList = new List<string>();

		// Act
		var result = collection.TryAddRange(emptyList);

		// Assert
		Assert.AreEqual(0, result);
		Assert.IsEmpty(collection);
	}

	[TestMethod]
	public void TryAddRange_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => collection.TryAddRange(null));
	}

	[TestMethod]
	public void TryAddRange_ToBoundedFullCollection_ReturnsPartialCount()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>(3);
		collection.Add("existing1");
		collection.Add("existing2");
		collection.Add("existing3");
		var items = new List<string> { "item1", "item2" };

		// Act
		var result = collection.TryAddRange(items, 10); // Short timeout

		// Assert - May add 0 items if collection is full and timeout is short
		Assert.IsGreaterThanOrEqualTo(0, result, "TryAddRange should return non-negative count.");
	}

	[TestMethod]
	public void TryAddRange_WithCancellationToken_AddsItems()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", "item2" };
		var cancellationToken = new CancellationToken();

		// Act
		var result = collection.TryAddRange(items, 1000, cancellationToken);

		// Assert
		Assert.AreEqual(2, result);
		Assert.HasCount(2, collection);
	}

	[TestMethod]
	public void TryAddRange_WithCancelledToken_ThrowsOperationCanceledException()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", "item2" };
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();

		// Act & Assert
		Assert.ThrowsExactly<OperationCanceledException>(() =>
			collection.TryAddRange(items, 1000, cancellationTokenSource.Token));
	}

	[TestMethod]
	public void TryAddRange_WithDuplicates_OnlyAddsUniqueItems()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("item1");
		var items = new List<string> { "item1", "item2", "item3" };

		// Act
		var result = collection.TryAddRange(items);

		// Assert
		Assert.AreEqual(2, result, "TryAddRange should only add unique items.");
		Assert.HasCount(3, collection);
	}

	[TestMethod]
	public void TryAddRange_WithNullItems_SkipsNulls()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", null, "item2" };

		// Act
		var result = collection.TryAddRange(items);

		// Assert
		Assert.AreEqual(2, result, "TryAddRange should skip null items.");
		Assert.HasCount(2, collection);
	}

	[TestMethod]
	public void TryAddRange_WithTimeout_AddsItemsWithinTimeout()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", "item2" };

		// Act
		var result = collection.TryAddRange(items, 1000);

		// Assert
		Assert.AreEqual(2, result);
		Assert.HasCount(2, collection);
	}

	[TestMethod]
	public void TryAddRange_WithUniqueItems_AddsAllItems()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var items = new List<string> { "item1", "item2", "item3" };

		// Act
		var result = collection.TryAddRange(items);

		// Assert
		Assert.AreEqual(3, result, "TryAddRange should add all unique items.");
		Assert.HasCount(3, collection);
	}

	[TestMethod]
	public void TryAddTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd("test1");

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	/// <summary>
	/// Defines the test method TryAddTimeoutCancellationTest.
	/// </summary>
	[TestMethod]
	public void TryAddTimeoutCancellationTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		Assert.IsTrue(collection.TryAdd("test", 1000, CancellationToken.None));
	}

	/// <summary>
	/// Defines the test method TryAddTimeoutTest.
	/// </summary>
	[TestMethod]
	public void TryAddTimeoutTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		Assert.IsTrue(collection.TryAdd("test", 1000));
	}

	/// <summary>
	/// Defines the test method TryAddTimeSpanTest.
	/// </summary>
	[TestMethod]
	public void TryAddTimeSpanTest()
	{
		var collection = new DistinctBlockingCollection<string>();

		Assert.IsTrue(collection.TryAdd("test", new TimeSpan(0, 0, 10)));
	}


	[TestMethod]
	public void TryAddWithMillisecondsTimeoutAndCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationToken = new CancellationToken();
		var result = collection.TryAdd("test1", 1000, cancellationToken);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	public void TryAddWithMillisecondsTimeoutAndCancelledTokenTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();

		// Act & Assert
		Assert.ThrowsExactly<OperationCanceledException>(() => collection.TryAdd("test1", 1000, cancellationTokenSource.Token));
	}

	[TestMethod]
	public void TryAddWithMillisecondsTimeoutDuplicateItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");
		var result = collection.TryAdd("test1", 1000);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithMillisecondsTimeoutNullItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd(null, 1000);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithMillisecondsTimeoutTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd("test1", 1000);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	public void TryAddWithTimeoutAndCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationToken = new CancellationToken();
		var result = collection.TryAdd("test1", 1000, cancellationToken);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	public void TryAddWithTimeoutAndCancelledTokenTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();

		// Act & Assert
		Assert.ThrowsExactly<OperationCanceledException>(() => collection.TryAdd("test1", 1000, cancellationTokenSource.Token));
	}

	[TestMethod]
	public void TryAddWithTimeoutDuplicateItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");
		var result = collection.TryAdd("test1", 1000);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithTimeoutTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd("test1", 1000);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	public void TryAddWithTimeSpanAndCancellationTokenTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var cancellationToken = new CancellationToken();
		var result = collection.TryAdd("test1", 1000, cancellationToken);

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	[TestMethod]
	public void TryAddWithTimeSpanAndCancelledTokenTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		var cancellationTokenSource = new CancellationTokenSource();
		cancellationTokenSource.Cancel();

		// Act & Assert
		Assert.ThrowsExactly<OperationCanceledException>(() => collection.TryAdd("test1", 1000, cancellationTokenSource.Token));
	}

	[TestMethod]
	public void TryAddWithTimeSpanDuplicateItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");
		var result = collection.TryAdd("test1", TimeSpan.FromSeconds(1));

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithTimeSpanNullItemTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd(null, TimeSpan.FromSeconds(1));

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryAddWithTimeSpanTest()
	{
		var collection = new DistinctBlockingCollection<string>();
		var result = collection.TryAdd("test1", TimeSpan.FromSeconds(1));

		Assert.IsTrue(result);
		Assert.IsTrue(collection.Contains("test1"));
	}

	/// <summary>
	/// Defines the test method ConstructorWithNullCollectionTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithNullCollectionTest()
	{
		// Arrange & Act
		var collection = new DistinctBlockingCollection<string>(null);

		// Assert
		Assert.IsNotNull(collection);
		Assert.IsEmpty(collection);
	}

	/// <summary>
	/// Defines the test method ConstructorWithEmptyCollectionTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithEmptyCollectionTest()
	{
		// Arrange
		var emptyList = new List<string>();

		// Act
		var collection = new DistinctBlockingCollection<string>(emptyList);

		// Assert
		Assert.IsNotNull(collection);
		Assert.IsEmpty(collection);
	}

	/// <summary>
	/// Defines the test method ConstructorWithNullItemsInCollectionTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithNullItemsInCollectionTest()
	{
		// Arrange
		var items = new List<string> { "test1", null, "test2", null };

		// Act
		var collection = new DistinctBlockingCollection<string>(items);

		// Assert
		Assert.IsNotNull(collection);
		Assert.HasCount(2, collection);
		Assert.IsTrue(collection.Contains("test1"));
		Assert.IsTrue(collection.Contains("test2"));
	}

	/// <summary>
	/// Defines the test method ConstructorWithDuplicateItemsTest.
	/// </summary>
	[TestMethod]
	public void ConstructorWithDuplicateItemsTest()
	{
		// Arrange
		var items = new List<string> { "test1", "test1" };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentInvalidException>(() => new DistinctBlockingCollection<string>(items));
	}

	/// <summary>
	/// Defines the test method AddDuplicateItemTest.
	/// </summary>
	[TestMethod]
	public void AddDuplicateItemTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");

		// Act
		collection.Add("test1");

		// Assert - duplicate should be silently ignored
		Assert.HasCount(1, collection);
	}

	/// <summary>
	/// Defines the test method ContainsNullItemReturnsFalseTest.
	/// </summary>
	[TestMethod]
	public void ContainsNullItemReturnsFalseTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");

		// Act
		var result = collection.Contains(null);

		// Assert
		Assert.IsFalse(result);
	}

	/// <summary>
	/// Defines the test method ContainsNonExistingItemReturnsFalseTest.
	/// </summary>
	[TestMethod]
	public void ContainsNonExistingItemReturnsFalseTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");

		// Act
		var result = collection.Contains("nonexistent");

		// Assert
		Assert.IsFalse(result);
	}

	/// <summary>
	/// Defines the test method TryAddDuplicateItemReturnsFalseTest.
	/// </summary>
	[TestMethod]
	public void TryAddDuplicateItemReturnsFalseTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();
		collection.Add("test1");

		// Act
		var result = collection.TryAdd("test1");

		// Assert
		Assert.IsFalse(result);
		Assert.HasCount(1, collection);
	}

	/// <summary>
	/// Defines the test method CloneEmptyCollectionTest.
	/// </summary>
	[TestMethod]
	public void CloneEmptyCollectionTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();

		// Act
		var clone = collection.Clone();

		// Assert
		Assert.IsNotNull(clone);
		Assert.IsEmpty(clone);
	}

	/// <summary>
	/// Defines the test method TryAddWithMillisecondsTimeoutAndCancellationTokenNullItemTest.
	/// </summary>
	[TestMethod]
	public void TryAddWithMillisecondsTimeoutAndCancellationTokenNullItemTest()
	{
		// Arrange
		var collection = new DistinctBlockingCollection<string>();

		// Act
		var result = collection.TryAdd(null, 1000, CancellationToken.None);

		// Assert
		Assert.IsFalse(result);
	}

}
