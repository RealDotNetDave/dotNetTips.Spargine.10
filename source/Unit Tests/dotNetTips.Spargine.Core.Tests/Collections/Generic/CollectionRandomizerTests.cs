// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-12-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="CollectionRandomizerTests.cs" company="McCarter Consulting">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

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
	public void CurrentIndex_AlwaysReturnsMinusOne()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var randomizer = new CollectionRandomizer<int>(collection, false);

		// Act & Assert
		Assert.AreEqual(-1, randomizer.CurrentIndex, "CurrentIndex should always return -1 as per implementation.");
		randomizer.GetNext();
		Assert.AreEqual(-1, randomizer.CurrentIndex, "CurrentIndex should remain -1 after GetNext.");
		randomizer.Reset();
		Assert.AreEqual(-1, randomizer.CurrentIndex, "CurrentIndex should remain -1 after Reset.");
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
		Assert.IsTrue(retrievedItems.Count > collection.Count); // Ensure more items were retrieved than in the original collection
		Assert.IsTrue(retrievedItems.Distinct().Count() == collection.Count); // Ensure all original items were retrieved
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
			items.Add(randomizer.GetNext());

		// At this point, collection is exhausted, next PeekNext should reshuffle and return a valid item
		var peeked = randomizer.PeekNext();

		// Assert
		Assert.IsTrue(collection.Contains(peeked), "PeekNext should return a valid item after reshuffle when repeating.");
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
		Assert.IsTrue(collection.Contains(next), "After reset, GetNext should return a valid item from the collection.");
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

}
