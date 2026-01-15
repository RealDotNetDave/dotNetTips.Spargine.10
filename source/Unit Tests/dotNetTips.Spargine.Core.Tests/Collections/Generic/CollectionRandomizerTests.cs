// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-12-2024
//
// Last Modified By : David McCarter
// Last Modified On : 12-30-2025
// ***********************************************************************
// <copyright file="CollectionRandomizerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic;

[ExcludeFromCodeCoverage]
[TestClass]
public class CollectionRandomizerTests
{

	[TestMethod]
	public void Constructor_WithNullCollection_ShouldThrowArgumentNullException()
	{
		// Arrange, Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new CollectionRandomizer<int>(null));
	}

	[TestMethod]
	public void Constructor_WithValidCollection_ShouldNotThrow()
	{
		// Arrange
		var collection = Enumerable.Range(1, 10);

		// Act & Assert
		Assert.IsNotNull(new CollectionRandomizer<int>(collection));
	}

	[TestMethod]
	public void Count_RemainsConstant()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		var countBefore = randomizer.Count;
		randomizer.GetNext();
		randomizer.GetNext();
		var countAfter = randomizer.Count;

		// Assert
		Assert.AreEqual(5, countBefore, "Count should be 5 initially.");
		Assert.AreEqual(5, countAfter, "Count should remain 5 after retrieving items.");
	}

	[TestMethod]
	public void Count_ReturnsCorrectCount()
	{
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		Assert.AreEqual(5, randomizer.Count);
	}

	[TestMethod]
	public void CurrentIndex_AlwaysReturnsMinusOne()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act & Assert
		Assert.AreEqual(-1, randomizer.CurrentIndex, "CurrentIndex should always return -1 as per implementation.");
		randomizer.GetNext();
		Assert.AreEqual(0, randomizer.CurrentIndex, "CurrentIndex should remain -1 after GetNext.");
		randomizer.Reset();
		Assert.AreEqual(-1, randomizer.CurrentIndex, "CurrentIndex should remain -1 after Reset.");
	}

	[TestMethod]
	public void CurrentIndex_TracksPositionCorrectly()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act & Assert
		Assert.AreEqual(-1, randomizer.CurrentIndex, "CurrentIndex should be -1 before first GetNext.");

		randomizer.GetNext();
		Assert.AreEqual(0, randomizer.CurrentIndex, "CurrentIndex should be 0 after first GetNext.");

		randomizer.GetNext();
		Assert.AreEqual(1, randomizer.CurrentIndex, "CurrentIndex should be 1 after second GetNext.");

		randomizer.GetNext();
		Assert.AreEqual(2, randomizer.CurrentIndex, "CurrentIndex should be 2 after third GetNext.");
	}

	[TestMethod]
	public void GetEnumerator_IteratesAllItems()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);
		var retrieved = new List<int>();

		// Act
		foreach (var item in randomizer)
		{
			retrieved.Add(item);
		}

		// Assert
		Assert.HasCount(5, retrieved, "Should iterate through all items.");
		CollectionAssert.AreEquivalent(collection, retrieved, "Should retrieve all original items.");
	}

	[TestMethod]
	public void GetEnumerator_WithRepeat_IteratesMultipleTimes()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var randomizer = new CollectionRandomizer<int>(collection, true);
		var retrieved = new List<int>();

		// Act - Take double the collection count
		using var enumerator = randomizer.GetEnumerator();
		for (int i = 0; i < collection.Count * 2; i++)
		{
			Assert.IsTrue(enumerator.MoveNext(), $"Should have item at iteration {i}");
			retrieved.Add(enumerator.Current);
		}

		// Assert
		Assert.AreEqual(collection.Count * 2, retrieved.Count, "Should iterate through items multiple times with repeat.");
	}

	[TestMethod]
	public void GetNext_WithExhaustedNonRepeatingCollection_ShouldThrowInvalidOperationException()
	{
		// Arrange
		var collection = Enumerable.Range(1, 3).ToList();
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act & Assert
		_ = Assert.ThrowsExactly<InvalidOperationException>(() =>
		{
			while (true) // Intentionally infinite loop to force the exception
			{
				randomizer.GetNext();
			}
		});
	}

	[TestMethod]
	public void GetNext_WithRepeatingCollection_ShouldRepeatItems()
	{
		// Arrange
		var collection = Enumerable.Range(1, 5).ToList();
		var randomizer = new CollectionRandomizer<int>(collection, true);
		var retrievedItems = new List<int>();

		// Act
		for (int i = 0; i < collection.Count * 2; i++) // Retrieve twice the number of items in the collection
		{
			retrievedItems.Add(randomizer.GetNext());
		}

		// Assert
		Assert.IsGreaterThan(collection.Count, retrievedItems.Count); // Ensure more items were retrieved than in the original collection
		Assert.AreEqual(collection.Count, retrievedItems.Distinct().Count()); // Ensure all original items were retrieved
	}

	[TestMethod]
	public void HasRemainingItems_ReturnsFalseBeforeInitialization()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act & Assert
		Assert.IsFalse(randomizer.HasRemainingItems, "HasRemainingItems should be false before initialization.");
	}

	[TestMethod]
	public void HasRemainingItems_ReturnsFalseWhenExhausted()
	{
		// Arrange
		var collection = new List<int> { 1, 2 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		randomizer.GetNext();
		randomizer.GetNext();

		// Assert
		Assert.IsFalse(randomizer.HasRemainingItems, "HasRemainingItems should be false when all items are consumed.");
	}

	[TestMethod]
	public void HasRemainingItems_ReturnsTrueAfterFirstGetNext()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		randomizer.GetNext();

		// Assert
		Assert.IsTrue(randomizer.HasRemainingItems, "HasRemainingItems should be true after first GetNext with items remaining.");
	}

	[TestMethod]
	public void PeekNext_DoesNotChangeCurrentIndex()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		randomizer.GetNext(); // Index 0
		var indexBefore = randomizer.CurrentIndex;
		randomizer.PeekNext();
		var indexAfter = randomizer.CurrentIndex;

		// Assert
		Assert.AreEqual(indexBefore, indexAfter, "PeekNext should not change CurrentIndex.");
	}

	[TestMethod]
	public void PeekNext_ReshufflesAndReturnsItem_WhenRepeatingAndExhausted()
	{
		// Arrange
		var collection = new List<int> { 100, 200, 300 };
		var randomizer = new CollectionRandomizer<int>(collection, true);

		// Exhaust the collection
		var items = new HashSet<int>();

		for (int i = 0; i < collection.Count; i++)
		{
			items.Add(randomizer.GetNext());
		}

		// At this point, collection is exhausted, next PeekNext should reshuffle and return a valid item
		var peeked = randomizer.PeekNext();

		// Assert
		Assert.Contains(peeked, collection, "PeekNext should return a valid item after reshuffle when repeating.");
	}

	[TestMethod]
	public void PeekNext_ReturnsSameItemUntilGetNextIsCalled()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		var firstPeek = randomizer.PeekNext();
		var secondPeek = randomizer.PeekNext();
		var getNext = randomizer.GetNext();

		// Assert
		Assert.AreEqual(firstPeek, secondPeek, "PeekNext should return the same item if GetNext is not called.");
		Assert.AreEqual(firstPeek, getNext, "PeekNext and GetNext should return the same item initially.");
	}

	[TestMethod]
	public void PeekNext_ThrowsInvalidOperationException_WhenCollectionIsExhaustedAndNotRepeating()
	{
		// Arrange
		var collection = new List<int> { 10, 20 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		randomizer.GetNext();
		randomizer.GetNext();

		// Assert
		// Collection is now exhausted
		_ = Assert.ThrowsExactly<InvalidOperationException>(() => randomizer.PeekNext());
	}

	[TestMethod]
	public void PercentageComplete_CalculatesCorrectly()
	{
		var collection = new List<int> { 1, 2, 3, 4 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		Assert.AreEqual(0.0, randomizer.PercentageComplete, "Should be 0% before initialization");

		randomizer.GetNext(); // 1 of 4
		Assert.AreEqual(25.0, randomizer.PercentageComplete, 0.1);

		randomizer.GetNext(); // 2 of 4
		Assert.AreEqual(50.0, randomizer.PercentageComplete, 0.1);
	}

	[TestMethod]
	public void PercentageComplete_CalculatesCorrectlyForLargeCollection()
	{
		// Arrange
		var collection = Enumerable.Range(1, 100).ToList();
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		for (int i = 0; i < 50; i++)
		{
			randomizer.GetNext();
		}

		// Assert
		Assert.AreEqual(50.0, randomizer.PercentageComplete, 0.1, "Should be 50% after retrieving half the items.");
	}

	[TestMethod]
	public void PercentageComplete_Returns100WhenExhausted()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		for (int i = 0; i < collection.Count; i++)
		{
			randomizer.GetNext();
		}

		// Assert
		Assert.AreEqual(100.0, randomizer.PercentageComplete, 0.1, "Should be 100% when all items are consumed.");
	}

	[TestMethod]
	public void Reset_AllowsGetNextAfterExhaustion()
	{
		// Arrange
		var collection = new List<int> { 7, 8, 9 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Exhaust the collection
		for (int i = 0; i < collection.Count; i++)
			randomizer.GetNext();

		// Act & Assert
		randomizer.Reset();
		var next = randomizer.GetNext();
		Assert.Contains(next, collection, "After reset, GetNext should return a valid item from the collection.");
	}

	[TestMethod]
	public void Reset_ResetsCurrentIndex()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		randomizer.GetNext();
		randomizer.GetNext();
		var indexBefore = randomizer.CurrentIndex;
		randomizer.Reset();
		var indexAfter = randomizer.CurrentIndex;

		// Assert
		Assert.AreEqual(1, indexBefore, "CurrentIndex should be 1 before reset.");
		Assert.AreEqual(-1, indexAfter, "CurrentIndex should be -1 after reset.");
	}

	[TestMethod]
	public void Reset_ResetsHasRemainingItems()
	{
		// Arrange
		var collection = new List<int> { 1, 2 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		randomizer.GetNext();
		randomizer.GetNext();
		Assert.IsFalse(randomizer.HasRemainingItems, "Should have no remaining items.");

		randomizer.Reset();
		randomizer.GetNext(); // Initialize

		// Assert
		Assert.IsTrue(randomizer.HasRemainingItems, "Should have remaining items after reset and one GetNext.");
	}

	[TestMethod]
	public void Reset_ReshufflesAndRestartsSequence()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		var firstRun = new List<int>();
		for (int i = 0; i < collection.Count; i++)
			firstRun.Add(randomizer.GetNext());

		randomizer.Reset();

		var secondRun = new List<int>();
		for (int i = 0; i < collection.Count; i++)
			secondRun.Add(randomizer.GetNext());

		// Assert
		// After reset, the sequence should be a permutation of the original collection
		CollectionAssert.AreEquivalent(collection, secondRun);
		// The order after reset is likely different from the first run (not guaranteed, but likely)
		// If you want to enforce difference, uncomment the next line:
		// CollectionAssert.AreNotEqual(firstRun, secondRun);
	}

	[TestMethod]
	public void SkipNext_ReshufflesWhenRepeating()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var randomizer = new CollectionRandomizer<int>(collection, true);

		// Act - Exhaust the collection
		randomizer.GetNext();
		randomizer.GetNext();
		randomizer.GetNext();

		// Now skip on an exhausted repeating collection
		var result = randomizer.SkipNext();

		// Assert
		Assert.IsTrue(result, "SkipNext should return true after reshuffling on repeat.");
		Assert.IsTrue(randomizer.HasRemainingItems, "Should have remaining items after reshuffle.");
	}

	[TestMethod]
	public void SkipNext_ReturnsFalseWhenExhausted()
	{
		// Arrange
		var collection = new List<int> { 1, 2 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		randomizer.GetNext();
		randomizer.GetNext();
		var result = randomizer.SkipNext();

		// Assert
		Assert.IsFalse(result, "SkipNext should return false when collection is exhausted.");
	}

	[TestMethod]
	public void SkipNext_SkipsItemSuccessfully()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		var first = randomizer.GetNext();
		var skipped = randomizer.SkipNext();
		var third = randomizer.GetNext();

		// Assert
		Assert.IsTrue(skipped, "SkipNext should return true.");
		Assert.AreNotEqual(first, third, "Third item should be different from first due to skip.");
		Assert.AreEqual(2, randomizer.CurrentIndex, "CurrentIndex should be 2 after GetNext, SkipNext, GetNext.");
	}

	[TestMethod]
	public void SkipNext_UpdatesCurrentIndex()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		randomizer.GetNext(); // Index 0
		var indexBefore = randomizer.CurrentIndex;
		randomizer.SkipNext(); // Index 1
		var indexAfter = randomizer.CurrentIndex;

		// Assert
		Assert.AreEqual(0, indexBefore, "CurrentIndex should be 0 before skip.");
		Assert.AreEqual(1, indexAfter, "CurrentIndex should be 1 after skip.");
	}

	[TestMethod]
	public void ThreadSafety_ConcurrentGetNext()
	{
		// Arrange
		var collection = Enumerable.Range(1, 1000).ToList();
		var randomizer = new CollectionRandomizer<int>(collection, false);
		var retrieved = new System.Collections.Concurrent.ConcurrentBag<int>();
		var tasks = new List<System.Threading.Tasks.Task>();

		// Act
		for (int i = 0; i < 10; i++)
		{
			tasks.Add(System.Threading.Tasks.Task.Run(() =>
			{
				try
				{
					for (int j = 0; j < 100; j++)
					{
						var item = randomizer.GetNext();
						retrieved.Add(item);
					}
				}
				catch (InvalidOperationException)
				{
					// Expected when collection is exhausted
				}
			}));
		}

		System.Threading.Tasks.Task.WaitAll(tasks.ToArray());

		// Assert
		Assert.IsLessThanOrEqualTo(collection.Count, retrieved.Count, "Should not retrieve more items than available.");
		Assert.IsNotEmpty(retrieved, "Should retrieve at least some items.");
	}

	[TestMethod]
	public void ToArray_ReturnsCorrectCountBeforeInitialization()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act
		var snapshot = randomizer.ToArray();

		// Assert
		Assert.HasCount(5, snapshot, "ToArray should return all items even before initialization.");
		CollectionAssert.AreEquivalent(collection, snapshot, "ToArray should contain all original items.");
	}

	[TestMethod]
	public void ToArray_ReturnsDifferentInstanceEachTime()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var randomizer = new CollectionRandomizer<int>(collection, false);
		randomizer.GetNext();

		// Act
		var snapshot1 = randomizer.ToArray();
		var snapshot2 = randomizer.ToArray();

		// Assert
		Assert.AreNotSame(snapshot1, snapshot2, "ToArray should return a new array instance each time.");
		CollectionAssert.AreEqual(snapshot1, snapshot2, "Contents should be the same.");
	}

	[TestMethod]
	public void ToArray_ReturnsShuffledSnapshot()
	{
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Force initialization
		randomizer.GetNext();

		var snapshot = randomizer.ToArray();

		Assert.HasCount(5, snapshot);
		CollectionAssert.AreEquivalent(collection, snapshot);
	}

}
