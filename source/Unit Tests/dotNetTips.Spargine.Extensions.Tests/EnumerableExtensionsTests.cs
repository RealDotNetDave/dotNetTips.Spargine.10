// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-14-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerableExtensionsTests
{
	private const int Count = 1024;

	[TestMethod]
	public void AddDistinct_EmptyItems_ReturnsOriginal()
	{
		var list = new List<int> { 1, 2 }.AsEnumerable();
		var result = list.AddDistinct(new ReadOnlyCollection<int>(new List<int>()));

		Assert.HasCount(list.Count(), result);
	}

	[TestMethod]
	public void AddDistinct_NullCollection_ReturnsEmpty()
	{
		IEnumerable<int> collection = null;
		var result = collection.AddDistinct(new ReadOnlyCollection<int>(new List<int> { 1, 2 }));

		Assert.IsFalse(result.Any());
	}

	[TestMethod]
	public void AddDistinct_NullItems_ReturnsOriginal()
	{
		var list = new List<int> { 1, 2 }.AsEnumerable();
		ReadOnlyCollection<int> items = null;
		var result = list.AddDistinct(items);

		Assert.HasCount(list.Count(), result);
	}

	[TestMethod]
	public void AddDistinctTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var person1 = RandomData.GeneratePerson<Person>();

		people = people.AddDistinct(person1);
		Assert.HasCount(Count + 1, people);

		people = people.AddDistinct(person1);
		Assert.HasCount(Count + 1, people);

		people = people.AddDistinct(null);
		Assert.HasCount(Count + 1, people);
	}

	[TestMethod]
	public void AddFirst_DeferredExecution_DoesNotEnumerateImmediately()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();
		var enumeratedCount = 0;
		var trackingNumbers = numbers.Select(n =>
		{
			enumeratedCount++;
			return n;
		});

		// Act - just create the query, don't enumerate
		var query = trackingNumbers.AddFirst(0);

		// Assert - should not have enumerated yet
		Assert.AreEqual(0, enumeratedCount);

		// Now enumerate
		_ = query.ToList();
		Assert.AreEqual(3, enumeratedCount); // Original 3 items enumerated
	}

	[TestMethod]
	public void AddFirst_DoesNotModifyOriginalCollection()
	{
		// Arrange
		var originalNumbers = new List<int> { 1, 2, 3 };
		var numbers = originalNumbers.AsEnumerable();

		// Act
		var result = numbers.AddFirst(0).ToList();

		// Assert
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, originalNumbers);
		CollectionAssert.AreEqual(new List<int> { 0, 1, 2, 3 }, result);
	}

	[TestMethod]
	public void AddFirst_EmptyCollection_AddsItemAsFirst()
	{
		// Arrange
		var emptyList = new List<int>().AsEnumerable();

		// Act
		var result = emptyList.AddFirst(42).ToList();

		// Assert
		Assert.HasCount(1, result);
		Assert.AreEqual(42, result.First());
	}

	[TestMethod]
	public void AddFirst_LargeCollection_PerformanceTest()
	{
		// Arrange
		var largeCollection = Enumerable.Range(1, Count).AsEnumerable();

		// Act
		var result = largeCollection.AddFirst(0).ToList();

		// Assert
		Assert.HasCount(Count + 1, result);
		Assert.AreEqual(0, result.First());
		Assert.AreEqual(Count, result.Last());
	}

	[TestMethod]
	public void AddFirst_MultipleInvocations_AddsMultipleItems()
	{
		// Arrange
		var numbers = new List<int> { 4, 5 }.AsEnumerable();

		// Act
		var result = numbers.AddFirst(3).AddFirst(2).AddFirst(1).ToList();

		// Assert
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, result);
	}

	[TestMethod]
	public void AddFirst_NonEmptyCollection_InsertsItemAtBeginning()
	{
		// Arrange
		var numbers = new List<int> { 2, 3, 4 }.AsEnumerable();

		// Act
		var result = numbers.AddFirst(1).ToList();

		// Assert
		Assert.HasCount(4, result);
		Assert.AreEqual(1, result.First());
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4 }, result);
	}

	[TestMethod]
	public void AddFirst_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Person> nullCollection = null;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.AddFirst(person).ToList());
	}

	[TestMethod]
	public void AddFirst_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.AddFirst(null).ToList());
	}

	[TestMethod]
	public void AddFirst_PreservesOriginalOrder()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable().ToList();
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		people.AddFirst(newPerson);

		// Assert
		Assert.HasCount(Count + 1, people);
		Assert.AreEqual(newPerson, people.First());
	}

	[TestMethod]
	public void AddFirst_SingleItemCollection_AddsToBeginning()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Act
		var result = singleItem.AddFirst(1).ToList();

		// Assert
		Assert.HasCount(2, result);
		Assert.AreEqual(1, result.First());
		Assert.AreEqual(42, result.Last());
	}

	[TestMethod]
	public void AddFirst_WithArray_AddsCorrectly()
	{
		// Arrange
		var array = new int[] { 2, 3, 4 };

		// Act
		var result = array.AddFirst(1).ToList();

		// Assert
		Assert.HasCount(4, result);
		Assert.AreEqual(1, result.First());
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4 }, result);
	}

	[TestMethod]
	public void AddFirst_WithIList_AddsCorrectly()
	{
		// Arrange
		IList<int> list = new List<int> { 2, 3, 4 };

		// Act
		var result = list.AddFirst(1).ToList();

		// Assert
		Assert.HasCount(4, result);
		Assert.AreEqual(1, result.First());
	}

	[TestMethod]
	public void AddFirst_WithReferenceTypes_AddsCorrectly()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(5).AsEnumerable();
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		var result = people.AddFirst(newPerson).ToList();

		// Assert
		Assert.HasCount(6, result);
		Assert.AreSame(newPerson, result.First());
	}

	[TestMethod]
	public void AddFirst_WithStrings_AddsCorrectly()
	{
		// Arrange
		var words = new List<string> { "banana", "cherry" }.AsEnumerable();

		// Act
		var result = words.AddFirst("apple").ToList();

		// Assert
		Assert.HasCount(3, result);
		Assert.AreEqual("apple", result.First());
		CollectionAssert.AreEqual(new List<string> { "apple", "banana", "cherry" }, result);
	}

	[TestMethod]
	public void AddFirst_WithValueTypes_AddsCorrectly()
	{
		// Arrange
		var numbers = Enumerable.Range(1, Count).AsEnumerable();

		// Act
		var result = numbers.AddFirst(0).ToList();

		// Assert
		Assert.HasCount(Count + 1, result);
		Assert.AreEqual(0, result.First());
		Assert.AreEqual(1, result[1]);
	}


	[TestMethod]
	public void AddIf_ConditionFalse_ReturnsOriginal()
	{
		var list = new List<int> { 1, 2 }.AsEnumerable();
		list.AddIf(3, false);
		Assert.HasCount(2, list);
	}

	[TestMethod]
	public void AddIf_ConditionTrue_AddsItem()
	{
		var list = new List<int> { 1, 2 }.AsEnumerable();

		list = list.AddIf(3, true);

		CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, list.ToList());
	}

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var person = RandomData.GeneratePerson<Person>();

		var result = people.AddIf(person, true);
		Assert.HasCount(Count + 1, result);

		result = people.AddIf(person, false);

		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void ContainsAny_AllItemsMatch_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var items = new ReadOnlyCollection<int>([1, 2, 3, 4, 5]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_ContainsFirstItem_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var items = new ReadOnlyCollection<int>([1, 10, 20]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_ContainsLastItem_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var items = new ReadOnlyCollection<int>([10, 20, 3]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_ContainsMultipleItems_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var items = new ReadOnlyCollection<int>([2, 3, 4]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_ContainsNoItems_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var items = new ReadOnlyCollection<int>([10, 20, 30]);

		// Assert
		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_ContainsOneItem_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var items = new ReadOnlyCollection<int>([10, 20, 3, 30]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_EmptyCollection_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int>();
		var items = new ReadOnlyCollection<int>([1, 2, 3]);

		// Assert
		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_EmptyItems_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };
		var items = new ReadOnlyCollection<int>([]);

		// Assert
		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_FrozenSetCollection_MatchExists_ReturnsTrue()
	{
		var collection = new HashSet<string> { "apple", "banana", "cherry" }.ToFrozenSet();
		var items = new ReadOnlyCollection<string>(["mango", "cherry"]);

		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_FrozenSetCollection_NoMatch_ReturnsFalse()
	{
		var collection = new HashSet<string> { "apple", "banana", "cherry" }.ToFrozenSet();
		var items = new ReadOnlyCollection<string>(["grape", "orange"]);

		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_HashSetCollection_MatchExists_ReturnsTrue()
	{
		var collection = new HashSet<string> { "apple", "banana", "cherry" };
		var items = new ReadOnlyCollection<string>(["grape", "banana"]);

		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_HashSetCollection_NoMatch_ReturnsFalse()
	{
		var collection = new HashSet<string> { "apple", "banana", "cherry" };
		var items = new ReadOnlyCollection<string>(["grape", "orange"]);

		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_LargeCollection_ContainsItem_ReturnsTrue()
	{
		// Arrange
		var collection = Enumerable.Range(1, 10000).ToList();
		var items = new ReadOnlyCollection<int>([9999, 20000, 30000]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_LargeCollection_NoMatch_ReturnsFalse()
	{
		// Arrange
		var collection = Enumerable.Range(1, 10000).ToList();
		var items = new ReadOnlyCollection<int>([20000, 30000, 40000]);

		// Assert
		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_LargeItemsListCollection_MatchExists_ReturnsTrue()
	{
		var collection = new List<int>(Enumerable.Range(1, 100)).AsEnumerable();
		var itemList = new List<int>(Enumerable.Range(91, 10)) { 50 };
		var items = new ReadOnlyCollection<int>(itemList);

		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_LargeItemsListCollection_NoMatch_ReturnsFalse()
	{
		var collection = new List<int>(Enumerable.Range(1, 50)).AsEnumerable();
		var itemList = new List<int>(Enumerable.Range(101, 11));
		var items = new ReadOnlyCollection<int>(itemList);

		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_NullCollection_ReturnsFalse()
	{
		// Arrange
		List<int> collection = null;
		var items = new ReadOnlyCollection<int>([1, 2, 3]);

		// Assert
		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_NullItems_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };

		// Assert
		Assert.IsFalse(collection.ContainsAny(null));
	}

	[TestMethod]
	public void ContainsAny_SingleItemMatch_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 42 };
		var items = new ReadOnlyCollection<int>([42]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_SingleItemNoMatch_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int> { 42 };
		var items = new ReadOnlyCollection<int>([99]);

		// Assert
		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_WithArray_ContainsItem_ReturnsTrue()
	{
		// Arrange
		var collection = new[] { 1, 2, 3, 4, 5 };
		var items = new ReadOnlyCollection<int>([10, 3, 20]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_WithHashSet_ContainsItem_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> collection = new HashSet<int> { 1, 2, 3, 4, 5 };
		var items = new ReadOnlyCollection<int>([10, 3, 20]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_WithReferenceType_DifferentInstance_ReturnsFalse()
	{
		// Arrange
		var collection = new List<Person>
	{
		RandomData.GeneratePerson<Person>(),
		RandomData.GeneratePerson<Person>()
	};
		var items = new ReadOnlyCollection<Person>([RandomData.GeneratePerson<Person>()]);

		// Assert
		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_WithReferenceType_SameInstance_ReturnsTrue()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		var collection = new List<Person> { person, RandomData.GeneratePerson<Person>() };
		var items = new ReadOnlyCollection<Person>([person]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_WithStrings_ContainsItem_ReturnsTrue()
	{
		// Arrange
		var collection = new List<string> { "apple", "banana", "cherry" };
		var items = new ReadOnlyCollection<string>(["grape", "banana", "orange"]);

		// Assert
		Assert.IsTrue(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAny_WithStrings_NoMatch_ReturnsFalse()
	{
		// Arrange
		var collection = new List<string> { "apple", "banana", "cherry" };
		var items = new ReadOnlyCollection<string>(["grape", "orange", "mango"]);

		// Assert
		Assert.IsFalse(collection.ContainsAny(items));
	}

	[TestMethod]
	public void ContainsAnyTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var people2 = RandomData.GeneratePersonRefCollection(Count / 2);

		Assert.IsFalse(people1.ContainsAny(people2));
	}

	[TestMethod]
	public async Task CountAsync()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var peopleCount = await people.CountAsync(CancellationToken.None);

		Assert.AreEqual(Count, peopleCount);
	}

	[TestMethod]
	public void CountTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		Assert.HasCount(Count, people);
	}

	[TestMethod]
	public void CreateCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var peopleCreated = people.ToUniqueCollection();

		Assert.HasCount(Count, peopleCreated);
	}

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = new List<Person>().AsEnumerable();

		Assert.IsTrue(people.IsEmpty());
	}

	[TestMethod]
	public void FastAny_AllElementsMatch_ReturnsTrue()
	{
		// Arrange
		var numbers = new List<int> { 10, 20, 30 }.AsEnumerable();

		// Assert
		Assert.IsTrue(numbers.FastAny(n => n > 5));
	}

	[TestMethod]
	public void FastAny_Array_MatchingElementExists_ReturnsTrue()
	{
		// Arrange
		var numbers = new int[] { 1, 2, 3, 4, 5 };

		// Assert
		Assert.IsTrue(numbers.FastAny(n => n % 2 == 0));
	}

	[TestMethod]
	public void FastAny_ComplexPredicate_ReturnsCorrectResult()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Act
		var result = people.FastAny(p =>
			p.Email.Contains("@", StringComparison.Ordinal) &&
			!string.IsNullOrEmpty(p.FirstName) &&
			!string.IsNullOrEmpty(p.LastName));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_DeferredEnumerable_MatchingElementExists_ReturnsTrue()
	{
		// Arrange
		var deferred = Enumerable.Range(1, 10).Where(x => x % 2 == 0);

		// Assert
		Assert.IsTrue(deferred.FastAny(n => n == 6));
	}

	[TestMethod]
	public void FastAny_EmptyCollection_ReturnsFalse()
	{
		// Arrange
		var emptyCollection = new List<int>().AsEnumerable();

		// Assert
		Assert.IsFalse(emptyCollection.FastAny(n => n > 0));
	}

	[TestMethod]
	public void FastAny_FirstElementMatches_ReturnsTrue()
	{
		// Arrange
		var numbers = new List<int> { 10, 2, 3 }.AsEnumerable();

		// Assert
		Assert.IsTrue(numbers.FastAny(n => n > 5));
	}

	[TestMethod]
	public void FastAny_LargeCollection_MatchingElementExists_ReturnsTrue()
	{
		// Arrange
		var largeCollection = Enumerable.Range(1, Count).AsEnumerable();

		// Assert
		Assert.IsTrue(largeCollection.FastAny(n => n == Count));
	}

	[TestMethod]
	public void FastAny_LastElementMatches_ReturnsTrue()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 10 }.AsEnumerable();

		// Assert
		Assert.IsTrue(numbers.FastAny(n => n > 5));
	}

	[TestMethod]
	public void FastAny_MatchingElementExists_ReturnsTrue()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		// Assert
		Assert.IsTrue(numbers.FastAny(n => n > 3));
	}

	[TestMethod]
	public void FastAny_NoMatchingElement_ReturnsFalse()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Assert
		Assert.IsFalse(numbers.FastAny(n => n > 10));
	}

	[TestMethod]
	public void FastAny_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.FastAny(n => n > 0));
	}

	[TestMethod]
	public void FastAny_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => numbers.FastAny(null));
	}

	[TestMethod]
	public void FastAny_ReferenceType_MatchingElementExists_ReturnsTrue()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Assert
		Assert.IsTrue(people.FastAny(p => p.Email.Contains("@", StringComparison.Ordinal)));
	}

	[TestMethod]
	public void FastAny_ReferenceType_NoMatchingElement_ReturnsFalse()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Assert
		Assert.IsFalse(people.FastAny(p => p.Id == "non-existent-id-12345"));
	}

	[TestMethod]
	public void FastAny_SingleElementMatches_ReturnsTrue()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Assert
		Assert.IsTrue(singleItem.FastAny(n => n == 42));
	}

	[TestMethod]
	public void FastAny_SingleElementNoMatch_ReturnsFalse()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();


		// Assert
		Assert.IsFalse(singleItem.FastAny(n => n == 100));
	}

	[TestMethod]
	public void FastAny_StringCollection_MatchingElement_ReturnsTrue()
	{
		// Arrange
		var strings = new List<string> { "apple", "banana", "cherry" }.AsEnumerable();

		// Assert
		Assert.IsTrue(strings.FastAny(s => s.StartsWith("b", StringComparison.Ordinal)));
	}

	[TestMethod]
	public void FastAny_StringCollection_NoMatchingElement_ReturnsFalse()
	{
		// Arrange
		var strings = new List<string> { "apple", "banana", "cherry" }.AsEnumerable();

		// Assert
		Assert.IsFalse(strings.FastAny(s => s.StartsWith("z", StringComparison.Ordinal)));
	}

	[TestMethod]
	public void FastContains_EmptyCollection_ReturnsFalse()
	{
		// Arrange
		var emptyList = new List<int>();

		// Act
		var result = emptyList.FastContains(5);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastContains_FallbackLinearSearch_ItemExists_ReturnsTrue()
	{
		// Arrange - LinkedList uses fallback linear search
		IEnumerable<int> linkedList = new LinkedList<int>([5, 3, 8, 1, 9]);

		// Act
		var result = linkedList.FastContains(8);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastContains_FallbackLinearSearch_ItemNotExists_ReturnsFalse()
	{
		// Arrange - LinkedList uses fallback linear search
		IEnumerable<int> linkedList = new LinkedList<int>([5, 3, 8, 1, 9]);

		// Act
		var result = linkedList.FastContains(99);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastContains_HashSet_ItemExists_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = hashSet.FastContains(3);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastContains_HashSet_ItemNotExists_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = hashSet.FastContains(99);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastContains_HashSetWithCustomComparer_UsesLinearSearch()
	{
		// Arrange - When custom comparer is provided, HashSet should NOT use its internal Contains
		IEnumerable<int> hashSet = new HashSet<int> { 10, 20, 30, 40, 50 };
		var moduloComparer = Comparer<int>.Create((x, y) => (x % 10).CompareTo(y % 10));

		// Act - 100 % 10 == 0, and 10 % 10 == 0, so should find a match
		var result = hashSet.FastContains(100, moduloComparer);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastContains_LargeCollection_ItemExists_ReturnsTrue()
	{
		// Arrange - Large sorted list
		var largeList = Enumerable.Range(1, 10000).ToList();

		// Act
		var result = largeList.FastContains(5000);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastContains_NullCollection_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;

		// Act
		var result = nullCollection.FastContains(5);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastContains_NullSearchItem_ReturnsFalse()
	{
		// Arrange
		var collection = new List<string> { "apple", "banana", "cherry" };

		// Act
		var result = collection.FastContains(null);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastContains_SingleItemCollection_ItemExists_ReturnsTrue()
	{
		// Arrange
		var singleItem = new List<int> { 42 };

		// Act
		var result = singleItem.FastContains(42);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastContains_SingleItemCollection_ItemNotExists_ReturnsFalse()
	{
		// Arrange
		var singleItem = new List<int> { 42 };

		// Act
		var result = singleItem.FastContains(99);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastContains_SortedArray_ItemExists_ReturnsTrue()
	{
		// Arrange - Array must be sorted for binary search
		var sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		// Act
		var result = sortedArray.FastContains(7);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastContains_SortedArray_ItemNotExists_ReturnsFalse()
	{
		// Arrange - Array must be sorted for binary search
		var sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		// Act
		var result = sortedArray.FastContains(99);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastContains_SortedList_ItemExists_ReturnsTrue()
	{
		// Arrange - List must be sorted for binary search
		var sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		// Act
		var result = sortedList.FastContains(5);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastContains_SortedList_ItemNotExists_ReturnsFalse()
	{
		// Arrange - List must be sorted for binary search
		var sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		// Act
		var result = sortedList.FastContains(99);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastContains_WithCustomComparer_UsesComparer()
	{
		// Arrange - Sorted list with custom comparer
		var sortedList = new List<int> { 1, 2, 3, 4, 5 };
		var reverseComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));
		sortedList.Sort(reverseComparer); // Sort descending: 5, 4, 3, 2, 1

		// Act
		var result = sortedList.FastContains(3, reverseComparer);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastContains_WithStrings_ItemExists_ReturnsTrue()
	{
		// Arrange - Sorted string list
		var sortedStrings = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

		// Act
		var result = sortedStrings.FastContains("cherry");

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastCountPredicateTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		// Test Params
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.FastLongCount(null));

		//Test Finding City names that contain 'A'.
		Assert.IsNotNull(people.Count(p => p.FirstName.Contains('A', StringComparison.CurrentCultureIgnoreCase)));
	}

	[TestMethod]
	public void FastCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		Assert.HasCount(Count, people);
	}

	[TestMethod]
	public void FastDistinct_AllDuplicates_WithComparer_ReturnsSingleElement()
	{
		var allSame = new List<int> { 5, 5, 5, 5, 5 }.AsEnumerable();

		var result = allSame.FastDistinct(EqualityComparer<int>.Default).ToList();

		Assert.HasCount(1, result);
		Assert.AreEqual(5, result[0]);
	}

	[TestMethod]
	public void FastDistinct_EmptyCollection_WithComparer_ReturnsEmpty()
	{
		var emptyList = new List<int>().AsEnumerable();

		var result = emptyList.FastDistinct(EqualityComparer<int>.Default).ToList();

		Assert.HasCount(0, result);
	}

	[TestMethod]
	public void FastDistinct_NoDuplicates_WithComparer_ReturnsAll()
	{
		var uniqueNumbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		var result = uniqueNumbers.FastDistinct(EqualityComparer<int>.Default).ToList();

		Assert.HasCount(5, result);
	}

	[TestMethod]
	public void FastDistinct_ReferenceType_LargeICollection_UseDistinctPath()
	{
		// Arrange - ICollection<T> with count > 2048 triggers Distinct (not HashSet) path
		var people = RandomData.GeneratePersonRefCollection(3000).ToList();
		var duplicate = people[0];
		people.Add(duplicate);

		// Act
		var result = ((IEnumerable<Person>)people).FastDistinct().ToList();

		// Assert - duplicate removed
		Assert.HasCount(3000, result);
	}

	[TestMethod]
	public void FastDistinct_ReferenceType_NonCollectionEnumerable_UsesHashSet()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		// Use LINQ Where to produce IEnumerable<T> that is NOT ICollection<T>
		IEnumerable<Person> nonCollectionEnumerable = people.Where(p => p is not null);

		var result = nonCollectionEnumerable.FastDistinct().ToList();

		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void FastDistinct_ReferenceTypes_LargeCollection_WithComparer_RemovesDuplicates()
	{
		// Large collection (> 4096) uses Distinct path
		var largeCount = 5000;
		var people = RandomData.GeneratePersonRefCollection(largeCount).ToList();
		var duplicate = people[0];

		for (int i = 0; i < 10; i++)
		{
			people.Add(duplicate);
		}

		var result = people.FastDistinct(new PersonEqualityComparer()).ToList();

		var expectedCount = people.Select(p => p.Id).Distinct().Count();

		Assert.HasCount(expectedCount, result);
	}

	[TestMethod]
	public void FastDistinct_ReferenceTypes_SmallCollection_WithComparer_RemovesDuplicates()
	{
		// Small collection (<= 4096) uses HashSet path
		var people = RandomData.GeneratePersonRefCollection(20).ToList();
		var duplicate = people[0];
		people.Add(duplicate);
		people.Add(duplicate);

		var result = people.FastDistinct(new PersonEqualityComparer()).ToList();

		var expectedCount = people.Select(p => p.Id).Distinct().Count();

		Assert.HasCount(expectedCount, result);
	}

	[TestMethod]
	public void FastDistinct_SingleElement_WithComparer_ReturnsSingleElement()
	{
		var singleItem = new List<int> { 42 }.AsEnumerable();

		var result = singleItem.FastDistinct(EqualityComparer<int>.Default).ToList();

		Assert.HasCount(1, result);
		Assert.AreEqual(42, result[0]);
	}

	[TestMethod]
	public void FastDistinct_Strings_CaseInsensitiveComparer_RemovesDuplicates()
	{
		var words = new List<string> { "Apple", "apple", "APPLE", "Banana", "BANANA", "Cherry" }.AsEnumerable();

		var result = words.FastDistinct(StringComparer.OrdinalIgnoreCase).ToList();

		Assert.HasCount(3, result);
		Assert.IsTrue(result.Any(w => w.Equals("Apple", StringComparison.OrdinalIgnoreCase)));
		Assert.IsTrue(result.Any(w => w.Equals("Banana", StringComparison.OrdinalIgnoreCase)));
		Assert.IsTrue(result.Any(w => w.Equals("Cherry", StringComparison.OrdinalIgnoreCase)));
	}

	[TestMethod]
	public void FastDistinct_Strings_OrdinalComparer_PreservesCaseSensitiveDuplicates()
	{
		var words = new List<string> { "Apple", "apple", "APPLE", "Banana" }.AsEnumerable();

		var result = words.FastDistinct(StringComparer.Ordinal).ToList();

		// Ordinal comparison is case-sensitive, so all variations are unique
		Assert.HasCount(4, result);
	}

	[TestMethod]
	public void FastDistinct_ValueType_LargeCount_UsesDistinct()
	{
		// Arrange - value type collection with count > 256; TryGetNonEnumeratedCount returns true for arrays
		var numbers = Enumerable.Range(1, 300).ToArray();
		IEnumerable<int> collection = numbers;

		// Act
		var result = collection.FastDistinct().ToList();

		// Assert - all unique, so count equals 300
		Assert.HasCount(300, result);
	}

	[TestMethod]
	public void FastDistinct_ValueTypes_WithCustomComparer_FiltersCorrectly()
	{
		// Custom comparer that considers numbers equal if they have the same remainder when divided by 3
		var numbers = Enumerable.Range(1, 10).AsEnumerable();

		var modComparer = new ModuloEqualityComparer(3);
		var result = numbers.FastDistinct(modComparer).ToList();

		// Should have 3 unique "mod 3" classes: 0, 1, 2
		Assert.HasCount(3, result);
		Assert.IsTrue(result.Any(n => n % 3 == 0));
		Assert.IsTrue(result.Any(n => n % 3 == 1));
		Assert.IsTrue(result.Any(n => n % 3 == 2));
	}

	[TestMethod]
	public void FastDistinct_WithComparer_PreservesFirstOccurrence()
	{
		var words = new List<string> { "FIRST", "first", "First" }.AsEnumerable();

		var result = words.FastDistinct(StringComparer.OrdinalIgnoreCase).ToList();

		Assert.HasCount(1, result);
		Assert.AreEqual("FIRST", result[0]); // First occurrence should be preserved
	}

	[TestMethod]
	public void FastDistinct_WithNullComparer_UsesDefaultEquality()
	{
		var numbers = new List<int> { 1, 2, 2, 3, 3, 3 }.AsEnumerable();

		var result = numbers.FastDistinct(null).ToList();

		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, result);
	}

	[TestMethod]
	public void FastDistinctComparerTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		people.Add(people.First());

		var result = people.FastDistinct(new PersonEqualityComparer());

		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void FastDistinctTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		people.Add(people.First());

		var result = people.FastDistinct();

		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_AllMatch_ReturnsFullCount()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.FastLongCount(p => p != null);

		Assert.AreEqual(Count, result);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_ComparedToStandardCount_ReturnsSameValue()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var standardCount = people.LongCount(p => p.Email.Contains("@", StringComparison.Ordinal));
		var fastCount = people.FastLongCount(p => p.Email.Contains("@", StringComparison.Ordinal));

		Assert.AreEqual(standardCount, fastCount);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_ComplexPredicate_ReturnsCorrectCount()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.FastLongCount(p =>
			(p.Age.TotalDays > 25) &&
			p.Email.Contains("@", StringComparison.Ordinal) &&
			!string.IsNullOrEmpty(p.LastName));

		Assert.IsTrue(result >= 0);
		Assert.IsTrue(result <= Count);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_EmptyCollection_ReturnsZero()
	{
		var emptyList = new List<Person>().AsEnumerable();

		var result = emptyList.FastLongCount(p => p.Age.TotalDays > 30);

		Assert.AreEqual(0L, result);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_LargeCollection_ReturnsLongValue()
	{
		var largeCount = 100000;
		var numbers = Enumerable.Range(1, largeCount).AsEnumerable();

		var result = numbers.FastLongCount(n => n > 0);

		Assert.AreEqual(largeCount, result);
		Assert.IsInstanceOfType<long>(result);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_MultiplePredicateCalls_ReturnsConsistentResults()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result1 = people.FastLongCount(p => p.Age.TotalDays > 30);
		var result2 = people.FastLongCount(p => p.Age.TotalDays > 30);

		Assert.AreEqual(result1, result2);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_NoMatches_ReturnsZero()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.FastLongCount(p => p.FirstName == "NonExistentName12345");

		Assert.AreEqual(0L, result);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_NullCollection_ThrowsArgumentNullException()
	{
		IEnumerable<Person> nullCollection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.FastLongCount(p => p.Age.TotalDays > 30));
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.FastLongCount(null));
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_SingleMatch_ReturnsOne()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable().ToList();
		var uniquePerson = RandomData.GeneratePerson<Person>();
		uniquePerson.FirstName = "UniqueTestName_XYZ123";
		people.Add(uniquePerson);

		var result = people.FastLongCount(p => p.FirstName == "UniqueTestName_XYZ123");

		Assert.AreEqual(1L, result);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_SomeMatch_ReturnsCorrectCount()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var expectedCount = people.Count(p => p.FirstName.Contains('a', StringComparison.OrdinalIgnoreCase));
		var result = people.FastLongCount(p => p.FirstName.Contains('a', StringComparison.OrdinalIgnoreCase));

		Assert.AreEqual(expectedCount, result);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_Strings_ReturnsCorrectCount()
	{
		var words = RandomData.GenerateWords(Count, 5, 10).AsEnumerable();

		var result = words.FastLongCount(w => w.Length > 7);

		Assert.IsTrue(result >= 0);
		Assert.IsTrue(result <= Count);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_ValueTypes_ReturnsCorrectCount()
	{
		var numbers = Enumerable.Range(1, Count).AsEnumerable();

		var result = numbers.FastLongCount(n => n % 2 == 0);

		Assert.AreEqual(Count / 2, result);
	}

	[TestMethod]
	public void FastProcessor_Action_CountsCorrectly_WithList()
	{
		// Arrange
		var collection = new List<int> { 10, 20, 30, 40, 50 };
		var itemIndex = 0;
		var expectedOrder = new[] { 10, 20, 30, 40, 50 };
		var orderCorrect = true;

		// Act
		collection.FastProcessor(item =>
		{
			if (item != expectedOrder[itemIndex])
			{
				orderCorrect = false;
			}
			itemIndex++;
		});

		// Assert
		Assert.IsTrue(orderCorrect, "Items should be processed in order");
		Assert.AreEqual(5, itemIndex);
	}

	[TestMethod]
	public void FastProcessor_Action_ModifiesExternalState_CorrectlyUpdatesState()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var results = new Dictionary<int, int>();

		// Act
		collection.FastProcessor(item => results[item] = item * item);

		// Assert
		Assert.HasCount(5, results);
		Assert.AreEqual(1, results[1]);
		Assert.AreEqual(4, results[2]);
		Assert.AreEqual(9, results[3]);
		Assert.AreEqual(16, results[4]);
		Assert.AreEqual(25, results[5]);
	}

	[TestMethod]
	public void FastProcessor_Action_NullAction_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3 };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => collection.FastProcessor((Action<int>)null));
	}

	[TestMethod]
	public void FastProcessor_Action_WithConcurrentBag_ProcessesAllItems()
	{
		// Arrange - ConcurrentBag uses the fallback foreach path
		IEnumerable<int> collection = new ConcurrentBag<int>([1, 2, 3, 4, 5]);
		var sum = 0;

		// Act
		collection.FastProcessor(item => Interlocked.Add(ref sum, item));

		// Assert
		Assert.AreEqual(15, sum);
	}

	[TestMethod]
	public void FastProcessor_Action_WithEmptyArray_DoesNothing()
	{
		// Arrange - hits the T[] branch with zero-length array
		var emptyArray = Array.Empty<int>();
		var processedCount = 0;

		// Act
		emptyArray.FastProcessor((Action<int>)(_ => processedCount++));

		// Assert
		Assert.AreEqual(0, processedCount);
	}

	[TestMethod]
	public void FastProcessor_Action_WithEmptyList_DoesNothing()
	{
		// Arrange
		var collection = new List<int>();
		var processedCount = 0;

		// Act
		collection.FastProcessor(_ => processedCount++);

		// Assert
		Assert.AreEqual(0, processedCount);
	}

	[TestMethod]
	public void FastProcessor_Action_WithEnumerableRange_ProcessesAllItems()
	{
		// Arrange - Enumerable.Range returns IEnumerable, not List or array
		var collection = Enumerable.Range(1, 5);
		var sum = 0;

		// Act
		collection.FastProcessor(item => sum += item);

		// Assert
		Assert.AreEqual(15, sum);
	}

	[TestMethod]
	public void FastProcessor_Action_WithHashSet_ProcessesAllItems()
	{
		// Arrange - HashSet is not List or array, uses fallback path
		IEnumerable<int> collection = new HashSet<int> { 1, 2, 3, 4, 5 };
		var sum = 0;

		// Act
		collection.FastProcessor(item => sum += item);

		// Assert
		Assert.AreEqual(15, sum);
	}

	[TestMethod]
	public void FastProcessor_Action_WithImmutableList_ProcessesAllItems()
	{
		// Arrange - ImmutableList uses the fallback foreach path
		IEnumerable<int> collection = ImmutableList.Create(1, 2, 3, 4, 5);
		var sum = 0;

		// Act
		collection.FastProcessor(item => sum += item);

		// Assert
		Assert.AreEqual(15, sum);
	}

	[TestMethod]
	public void FastProcessor_Action_WithLargeList_ProcessesAllItems()
	{
		// Arrange
		var collection = Enumerable.Range(1, 10000).ToList();
		var sum = 0L;

		// Act
		collection.FastProcessor(item => sum += item);

		// Assert
		Assert.AreEqual(50005000L, sum); // Sum of 1 to 10000
	}

	[TestMethod]
	public void FastProcessor_Action_WithLinkedList_ProcessesAllItems()
	{
		// Arrange - LinkedList uses the fallback foreach path
		IEnumerable<int> collection = new LinkedList<int>([1, 2, 3, 4, 5]);
		var processedItems = new List<int>();

		// Act
		collection.FastProcessor(item => processedItems.Add(item));

		// Assert
		Assert.HasCount(5, processedItems);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5 }, processedItems);
	}

	[TestMethod]
	public void FastProcessor_Action_WithList_ProcessesAllItems()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };
		var processedItems = new List<int>();

		// Act
		collection.FastProcessor(item => processedItems.Add(item * 2));

		// Assert
		Assert.HasCount(5, processedItems);
		CollectionAssert.AreEqual(new[] { 2, 4, 6, 8, 10 }, processedItems);
	}

	[TestMethod]
	public void FastProcessor_Action_WithQueue_ProcessesAllItems()
	{
		// Arrange - Queue uses the fallback foreach path
		IEnumerable<int> collection = new Queue<int>([1, 2, 3, 4, 5]);
		var processedItems = new List<int>();

		// Act
		collection.FastProcessor(item => processedItems.Add(item));

		// Assert
		Assert.HasCount(5, processedItems);
		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, processedItems);
	}

	[TestMethod]
	public void FastProcessor_Action_WithReferenceTypes_ProcessesAllItems()
	{
		// Arrange
		var collection = new List<Person>
	{
		RandomData.GeneratePerson<Person>(),
		RandomData.GeneratePerson<Person>(),
		RandomData.GeneratePerson<Person>()
	};
		var processedCount = 0;

		// Act
		collection.FastProcessor(_ => processedCount++);

		// Assert
		Assert.AreEqual(3, processedCount);
	}

	[TestMethod]
	public void FastProcessor_Action_WithSelectQuery_ProcessesAllItems()
	{
		// Arrange - LINQ Select returns IEnumerable, uses fallback path
		var source = new List<int> { 1, 2, 3 };
		var collection = source.Select(x => x * 10);
		var processedItems = new List<int>();

		// Act
		collection.FastProcessor(item => processedItems.Add(item));

		// Assert
		Assert.HasCount(3, processedItems);
		CollectionAssert.AreEqual(new[] { 10, 20, 30 }, processedItems);
	}

	[TestMethod]
	public void FastProcessor_Action_WithSingleItemList_ProcessesItem()
	{
		// Arrange
		var collection = new List<int> { 42 };
		var processedItems = new List<int>();

		// Act
		collection.FastProcessor(item => processedItems.Add(item));

		// Assert
		Assert.HasCount(1, processedItems);
		Assert.AreEqual(42, processedItems[0]);
	}

	[TestMethod]
	public void FastProcessor_Action_WithStack_ProcessesAllItems()
	{
		// Arrange - Stack uses the fallback foreach path
		IEnumerable<int> collection = new Stack<int>([1, 2, 3, 4, 5]);
		var processedItems = new List<int>();

		// Act
		collection.FastProcessor(item => processedItems.Add(item));

		// Assert
		Assert.HasCount(5, processedItems);
	}

	[TestMethod]
	public void FastProcessor_Action_WithStrings_ProcessesAllItems()
	{
		// Arrange
		var collection = new List<string> { "apple", "banana", "cherry" };
		var concatenated = string.Empty;

		// Act
		collection.FastProcessor(item => concatenated += item);

		// Assert
		Assert.AreEqual("applebananacherry", concatenated);
	}

	[TestMethod]
	public void FastProcessor_Action_WithWhereQuery_ProcessesFilteredItems()
	{
		// Arrange - LINQ Where returns IEnumerable, uses fallback path
		var source = new List<int> { 1, 2, 3, 4, 5 };
		var collection = source.Where(x => x % 2 == 0);
		var processedItems = new List<int>();

		// Act
		collection.FastProcessor(item => processedItems.Add(item));

		// Assert
		Assert.HasCount(2, processedItems);
		CollectionAssert.AreEqual(new[] { 2, 4 }, processedItems);
	}

	[TestMethod]
	public void FastProcessorAction_ActionModifiesExternalState_StateIsUpdated()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 };
		var counter = new { Count = 0 };
		var total = 0;

		// Act
		numbers.FastProcessor(n =>
		{
			total += n;
		});

		// Assert
		Assert.AreEqual(15, total);
	}


	[TestMethod]
	public void FastProcessorAction_EmptyList_DoesNotCallAction()
	{
		// Arrange
		var emptyList = new List<int>();
		var callCount = 0;

		// Act
		emptyList.FastProcessor(_ => callCount++);

		// Assert
		Assert.AreEqual(0, callCount);
	}

	[TestMethod]
	public void FastProcessorAction_LargeList_ProcessesAllElements()
	{
		// Arrange
		var numbers = Enumerable.Range(1, Count).ToList();
		var sum = 0;

		// Act
		numbers.FastProcessor(n => sum += n);

		// Assert
		var expectedSum = (Count * (Count + 1)) / 2;
		Assert.AreEqual(expectedSum, sum);
	}

	[TestMethod]
	public void FastProcessorAction_NullAction_ThrowsArgumentNullException()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();
		Action<int> nullAction = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => numbers.FastProcessor(nullAction));
	}

	[TestMethod]
	public void FastProcessorAction_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;
		Action<int> action = _ => { };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.FastProcessor(action));
	}

	[TestMethod]
	public void FastProcessorAction_PreservesOrder_Array()
	{
		// Arrange
		var numbers = new int[] { 5, 4, 3, 2, 1 };
		var processedItems = new List<int>();

		// Act
		numbers.FastProcessor(n => processedItems.Add(n));

		// Assert
		CollectionAssert.AreEqual(numbers, processedItems);
	}

	[TestMethod]
	public void FastProcessorAction_PreservesOrder_List()
	{
		// Arrange
		var numbers = new List<int> { 5, 4, 3, 2, 1 };
		var processedItems = new List<int>();

		// Act
		numbers.FastProcessor(n => processedItems.Add(n));

		// Assert
		CollectionAssert.AreEqual(numbers, processedItems);
	}

	[TestMethod]
	public void FastProcessorAction_SingleElement_ProcessesElement()
	{
		// Arrange
		var singleItem = new List<int> { 42 };
		var processedValue = 0;

		// Act
		singleItem.FastProcessor(n => processedValue = n);

		// Assert
		Assert.AreEqual(42, processedValue);
	}

	[TestMethod]
	public void FastProcessorAction_WithArray_ProcessesAllElements()
	{
		// Arrange
		var numbers = new int[] { 1, 2, 3, 4, 5 };
		var processedItems = new List<int>();

		// Act
		numbers.FastProcessor(n => processedItems.Add(n));

		// Assert
		Assert.HasCount(5, processedItems);
		CollectionAssert.AreEqual(numbers, processedItems);
	}

	[TestMethod]
	public void FastProcessorAction_WithEnumerable_ProcessesAllElements()
	{
		// Arrange
		var numbers = Enumerable.Range(1, 5);
		var processedItems = new List<int>();

		// Act
		numbers.FastProcessor(n => processedItems.Add(n));

		// Assert
		Assert.HasCount(5, processedItems);
		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, processedItems);
	}

	[TestMethod]
	public void FastProcessorAction_WithList_ProcessesAllElements()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 };
		var processedItems = new List<int>();

		// Act
		numbers.FastProcessor(n => processedItems.Add(n));

		// Assert
		Assert.HasCount(5, processedItems);
		CollectionAssert.AreEqual(numbers, processedItems);
	}

	[TestMethod]
	public void FastProcessorAction_WithReferenceType_ProcessesAllElements()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var processedIds = new List<string>();

		// Act
		people.FastProcessor(p => processedIds.Add(p.Id));

		// Assert
		Assert.HasCount(Count, processedIds);
	}

	[TestMethod]
	public void FastProcessorFunc_DoesNotModifyOriginalCollection()
	{
		// Arrange
		var originalNumbers = new List<int> { 1, 2, 3 };
		var originalCopy = originalNumbers.ToList();

		// Act
		var result = originalNumbers.FastProcessor(n => n * 100);

		// Assert
		CollectionAssert.AreEqual(originalCopy, originalNumbers);
		CollectionAssert.AreEqual(new[] { 100, 200, 300 }, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorFunc_EmptyList_ReturnsEmptyCollection()
	{
		// Arrange
		var emptyList = new List<int>();

		// Act
		var result = emptyList.FastProcessor(n => n * 2);

		// Assert
		Assert.HasCount(0, result);
	}

	[TestMethod]
	public void FastProcessorFunc_FromDeferredEnumerable_TransformsCorrectly()
	{
		// Arrange
		var deferred = Enumerable.Range(1, 5).Where(x => x % 2 == 1);

		// Act
		var result = deferred.FastProcessor(n => n * 2);

		// Assert
		Assert.HasCount(3, result);
		CollectionAssert.AreEqual(new[] { 2, 6, 10 }, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorFunc_IdentityFunction_ReturnsSameValues()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = numbers.FastProcessor(n => n);

		// Assert
		CollectionAssert.AreEqual(numbers, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorFunc_LargeList_TransformsAllElements()
	{
		// Arrange
		var numbers = Enumerable.Range(1, Count).ToList();

		// Act
		var result = numbers.FastProcessor(n => n * 2);

		// Assert
		Assert.HasCount(Count, result);
		Assert.AreEqual(2, result[0]);
		Assert.AreEqual(Count * 2, result[Count - 1]);
	}

	[TestMethod]
	public void FastProcessorFunc_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;
		Func<int, int> func = n => n * 2;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.FastProcessor(func));
	}

	[TestMethod]
	public void FastProcessorFunc_NullFunc_ThrowsArgumentNullException()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();
		Func<int, int> nullFunc = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => numbers.FastProcessor(nullFunc));
	}

	[TestMethod]
	public void FastProcessorFunc_PreservesOrder()
	{
		// Arrange
		var numbers = new List<int> { 5, 4, 3, 2, 1 };

		// Act
		var result = numbers.FastProcessor(n => n * 10);

		// Assert
		CollectionAssert.AreEqual(new[] { 50, 40, 30, 20, 10 }, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorFunc_ReturnsReadOnlyCollection()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 };

		// Act
		var result = numbers.FastProcessor(n => n + 1);

		// Assert
		Assert.IsInstanceOfType<ReadOnlyCollection<int>>(result);
	}

	[TestMethod]
	public void FastProcessorFunc_SingleElement_TransformsElement()
	{
		// Arrange
		var singleItem = new List<int> { 5 };

		// Act
		var result = singleItem.FastProcessor(n => n * 10);

		// Assert
		Assert.HasCount(1, result);
		Assert.AreEqual(50, result[0]);
	}

	[TestMethod]
	public void FastProcessorFunc_WithArray_TransformsAllElements()
	{
		// Arrange - T[] takes the else/ToArray path in FastProcessor(Func)
		var numbers = new int[] { 1, 2, 3, 4, 5 };

		// Act
		var result = ((IEnumerable<int>)numbers).FastProcessor(n => n * 2);

		// Assert
		Assert.HasCount(5, result);
		CollectionAssert.AreEqual(new[] { 2, 4, 6, 8, 10 }, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorFunc_WithComplexTransformation_TransformsCorrectly()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = numbers.FastProcessor(n => (n % 2 == 0) ? (n * 2) : (n * 3));

		// Assert
		CollectionAssert.AreEqual(new[] { 3, 4, 9, 8, 15 }, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorFunc_WithEnumerable_TransformsAllElements()
	{
		// Arrange
		var numbers = Enumerable.Range(1, 5);

		// Act
		var result = numbers.FastProcessor(n => n * 2);

		// Assert
		Assert.HasCount(5, result);
		CollectionAssert.AreEqual(new[] { 2, 4, 6, 8, 10 }, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorFunc_WithList_TransformsAllElements()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = numbers.FastProcessor(n => n * 2);

		// Assert
		Assert.HasCount(5, result);
		CollectionAssert.AreEqual(new[] { 2, 4, 6, 8, 10 }, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorFunc_WithStringTransformation_TransformsCorrectly()
	{
		// Arrange
		var strings = new List<string> { "hello", "world", "test" };

		// Act
		var result = strings.FastProcessor(s => s.ToUpperInvariant());

		// Assert
		Assert.HasCount(3, result);
		CollectionAssert.AreEqual(new[] { "HELLO", "WORLD", "TEST" }, result.ToArray());
	}

	[TestMethod]
	public void FastProcessorTestRecord()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count);
		people.FastProcessor(person => person.GetHashCode());

		Assert.HasCount(Count, people);
	}

	[TestMethod]
	public void FastProcessorTestRef()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		people.FastProcessor(person => person.GetHashCode());

		Assert.HasCount(Count, people);
	}

	[TestMethod]
	public void FastProcessorTestVal()
	{
		var people = RandomData.GeneratePersonValCollection(Count);

		people.FastProcessor(person => person.GetHashCode());

		Assert.HasCount(Count, people);
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_EmptyCollection_DoesNotThrow()
	{
		var emptyList = new List<Person>().AsEnumerable();

		emptyList = emptyList.FastShuffle();

		Assert.HasCount(0, emptyList);
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_MultipleInvocations_ModifiesInPlace()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var originalPeople = people.ToHashSet();

		var afterFirstShuffle = people.FastShuffle();

		var afterSecondShuffle = people.FastShuffle();

		// All should have the same count and elements
		Assert.HasCount(Count, people);

		foreach (var person in originalPeople)
		{
			Assert.IsTrue(people.Contains(person));
		}

		// Statistically, the orders should be different
		var sameOrderAfterBothShuffles = afterFirstShuffle.SequenceEqual(afterSecondShuffle);
		Assert.IsFalse(sameOrderAfterBothShuffles);
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_NullCollection_ThrowsArgumentNullException()
	{
		IEnumerable<Person> nullCollection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.FastShuffle());
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_PreservesAllElements()
	{
		var numbers = Enumerable.Range(1, 100).AsEnumerable();
		var originalNumbers = numbers.ToHashSet();

		var shuffledNumbers = numbers.FastShuffle();

		Assert.HasCount(100, shuffledNumbers);

		Assert.IsFalse(originalNumbers.SequenceEqual(shuffledNumbers));

		foreach (var num in originalNumbers)
		{
			Assert.IsTrue(shuffledNumbers.Contains(num));
		}
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_ProducesDifferentResults()
	{
		var people1 = RandomData.GeneratePersonRefCollection(Count).
			AsEnumerable();
		var people2 = people1.ToList();

		people1 = people1.FastShuffle();
		people2 = people2.FastShuffle();

		// Statistical test: two shuffles should produce different orders
		var identical = people1.SequenceEqual(people2);
		Assert.IsFalse(identical);
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_ShufflesCollection()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var originalOrder = people.ToList();

		people = people.FastShuffle();

		Assert.HasCount(Count, people);
		// Verify it's not the same order (statistically very unlikely with large Count)
		var sameOrder = people.SequenceEqual(originalOrder);
		Assert.IsFalse(sameOrder);
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_SingleElement_DoesNotThrow()
	{
		var singlePerson = new List<Person> { RandomData.GeneratePerson<Person>() }.AsEnumerable();

		var originalPerson = singlePerson.First();

		var shuffled = singlePerson.FastShuffle(); // Capture the result

		Assert.HasCount(1, shuffled);
		Assert.AreEqual(originalPerson, shuffled.First());
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_WithArray_PreservesAllElements()
	{
		// Arrange - T[] hits the else/ToArray path since it is not List<T>
		var numbers = Enumerable.Range(1, Count).ToArray();
		var original = new HashSet<int>(numbers);

		// Act
		var shuffled = ((IEnumerable<int>)numbers).FastShuffle().ToArray();

		// Assert
		Assert.HasCount(Count, shuffled);

		foreach (var n in original)
		{
			Assert.IsTrue(shuffled.Contains(n));
		}
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_WorksWithComplexTypes()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var originalPeople = people.ToHashSet();

		people = people.FastShuffle();

		Assert.HasCount(Count, people);

		foreach (var person in originalPeople)
		{
			Assert.IsTrue(people.Contains(person));
		}
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_WorksWithStrings()
	{
		var words = RandomData.GenerateWords(Count, 5, 10).AsEnumerable();
		var originalWords = words.ToHashSet();

		words = words.FastShuffle();

		Assert.HasCount(Count, words);

		foreach (var word in originalWords)
		{
			Assert.IsTrue(words.Contains(word));
		}
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_WorksWithValueTypes()
	{
		var numbers = Enumerable.Range(1, Count).AsEnumerable();

		numbers = numbers.FastShuffle();

		Assert.HasCount(Count, numbers);

		for (int i = 1; i <= Count; i++)
		{
			Assert.IsTrue(numbers.Contains(i));
		}
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_Array_ReturnsFirstElement()
	{
		// Arrange
		var numbers = new int[] { 5, 10, 15 };

		// Act
		var result = numbers.FirstOrDefault(-1);

		// Assert
		Assert.AreEqual(5, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_CollectionWithNullFirst_ReturnsNull()
	{
		// Arrange
		var strings = new List<string> { null, "second", "third" }.AsEnumerable();

		// Act
		var result = strings.FirstOrDefault("alternate");

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_DeferredEnumerable_ReturnsFirstElement()
	{
		// Arrange
		var deferred = Enumerable.Range(100, 10);

		// Act
		var result = deferred.FirstOrDefault(-1);

		// Assert
		Assert.AreEqual(100, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_EmptyCollection_ReturnsAlternate()
	{
		// Arrange
		var numbers = new List<int>().AsEnumerable();

		// Act
		var result = numbers.FirstOrDefault(42);

		// Assert
		Assert.AreEqual(42, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_EmptyStringCollection_ReturnsAlternate()
	{
		// Arrange
		var emptyStrings = new List<string>().AsEnumerable();

		// Act
		var result = emptyStrings.FirstOrDefault("alternate");

		// Assert
		Assert.AreEqual("alternate", result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_LargeCollection_ReturnsFirstElement()
	{
		// Arrange
		var largeCollection = Enumerable.Range(1, Count).AsEnumerable();

		// Act
		var result = largeCollection.FirstOrDefault(-1);

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_NonEmptyCollection_ReturnsFirstElement()
	{
		// Arrange
		var numbers = new List<int> { 10, 20, 30 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrDefault(-1);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.FirstOrDefault(-1));
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_ReferenceType_EmptyCollection_ReturnsAlternate()
	{
		// Arrange
		var emptyCollection = new List<Person>().AsEnumerable();
		var alternatePerson = RandomData.GeneratePerson<Person>();

		// Act
		var result = emptyCollection.FirstOrDefault(alternatePerson);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(alternatePerson.Id, result.Id);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_ReferenceType_EmptyCollection_ReturnsNullAlternate()
	{
		// Arrange
		var emptyCollection = new List<Person>().AsEnumerable();

		// Act
		var result = emptyCollection.FirstOrDefault(null);

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_ReferenceType_NonEmptyCollection_ReturnsFirstElement()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var alternatePerson = RandomData.GeneratePerson<Person>();

		// Act
		var result = people.FirstOrDefault(alternatePerson);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(people.First().Id, result.Id);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_SingleItemCollection_ReturnsItem()
	{
		// Arrange
		var singleItem = new List<int> { 99 }.AsEnumerable();

		// Act
		var result = singleItem.FirstOrDefault(-1);

		// Assert
		Assert.AreEqual(99, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithAlternate_StringCollection_ReturnsFirstString()
	{
		// Arrange
		var strings = new List<string> { "first", "second", "third" }.AsEnumerable();

		// Act
		var result = strings.FirstOrDefault("alternate");

		// Assert
		Assert.AreEqual("first", result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_Array_ReturnsCorrectResult()
	{
		// Arrange
		var numbers = new int[] { 1, 2, 3, 4, 5 };

		// Act
		var result = numbers.FirstOrDefault(n => n % 2 == 0, -1);

		// Assert
		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_ComplexPredicate_ReturnsCorrectMatch()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Act
		var result = people.FirstOrDefault(
			p => p.Email.Contains("@", StringComparison.Ordinal) && !string.IsNullOrEmpty(p.FirstName),
			null);

		// Assert - all generated people should have valid email and first name
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Email.Contains("@", StringComparison.Ordinal));
		Assert.IsFalse(string.IsNullOrEmpty(result.FirstName));
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_EmptyCollection_ReturnsAlternate()
	{
		// Arrange
		var numbers = new List<int>().AsEnumerable();

		// Act
		var result = numbers.FirstOrDefault(n => n > 0, 42);

		// Assert
		Assert.AreEqual(42, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_FirstElementMatches_ReturnsFirstElement()
	{
		// Arrange
		var numbers = new List<int> { 10, 2, 3 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrDefault(n => n > 5, -1);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_LastElementMatches_ReturnsLastElement()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 10 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrDefault(n => n > 5, -1);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_MatchFound_ReturnsMatchingItem()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrDefault(n => n > 3, -1);

		// Assert
		Assert.AreEqual(4, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_MultipleMatches_ReturnsFirstMatch()
	{
		// Arrange
		var numbers = new List<int> { 1, 10, 20, 30 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrDefault(n => n > 5, -1);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_NoMatch_ReturnsAlternate()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrDefault(n => n > 10, -1);

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.FirstOrDefault(n => n > 0, -1));
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => numbers.FirstOrDefault(null, -1));
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_ReferenceType_MatchFound_ReturnsMatchingItem()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var targetPerson = people.First();

		// Act
		var result = people.FirstOrDefault(p => p.Id == targetPerson.Id, null);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(targetPerson.Id, result.Id);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_ReferenceType_NoMatch_ReturnsAlternate()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var alternatePerson = RandomData.GeneratePerson<Person>();

		// Act
		var result = people.FirstOrDefault(p => p.Id == "non-existent-id-12345", alternatePerson);

		// Assert
		Assert.AreEqual(alternatePerson, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_ReferenceType_NoMatch_ReturnsNullAlternate()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Act
		var result = people.FirstOrDefault(p => p.Id == "non-existent-id-12345", null);

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_SingleItemCollection_MatchFound_ReturnsItem()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Act
		var result = singleItem.FirstOrDefault(n => n == 42, -1);

		// Assert
		Assert.AreEqual(42, result);
	}

	[TestMethod]
	public void FirstOrDefault_WithPredicate_SingleItemCollection_NoMatch_ReturnsAlternate()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Act
		var result = singleItem.FirstOrDefault(n => n == 100, -1);

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void FirstOrNull_Array_MatchingElementExists_ReturnsElement()
	{
		// Arrange
		var numbers = new int[] { 1, 2, 3, 4, 5 };

		// Act
		var result = numbers.FirstOrNull(n => n % 2 == 0);

		// Assert
		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public void FirstOrNull_ComplexPredicate_ReturnsCorrectMatch()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Act
		var result = people.FirstOrNull(p =>
			p.Email.Contains("@", StringComparison.Ordinal) &&
			!string.IsNullOrEmpty(p.FirstName));

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Email.Contains("@", StringComparison.Ordinal));
		Assert.IsFalse(string.IsNullOrEmpty(result.FirstName));
	}

	[TestMethod]
	public void FirstOrNull_DeferredEnumerable_MatchingElementExists_ReturnsElement()
	{
		// Arrange
		var deferred = Enumerable.Range(1, 10).Where(x => x % 2 == 0);

		// Act
		var result = deferred.FirstOrNull(n => n > 4);

		// Assert
		Assert.AreEqual(6, result);
	}

	[TestMethod]
	public void FirstOrNull_EmptyCollection_ReturnsDefault()
	{
		// Arrange
		var emptyCollection = new List<int>().AsEnumerable();

		// Act
		var result = emptyCollection.FirstOrNull(n => n > 0);

		// Assert
		Assert.AreEqual(default(int), result);
	}

	[TestMethod]
	public void FirstOrNull_FirstElementMatches_ReturnsFirstElement()
	{
		// Arrange
		var numbers = new List<int> { 10, 2, 3 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrNull(n => n > 5);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void FirstOrNull_LargeCollection_MatchingElementExists_ReturnsElement()
	{
		// Arrange
		var largeCollection = Enumerable.Range(1, Count).AsEnumerable();

		// Act
		var result = largeCollection.FirstOrNull(n => n == Count);

		// Assert
		Assert.AreEqual(Count, result);
	}

	[TestMethod]
	public void FirstOrNull_LastElementMatches_ReturnsLastElement()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 10 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrNull(n => n > 5);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void FirstOrNull_MatchingElementExists_ReturnsFirstMatch()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrNull(n => n > 3);

		// Assert
		Assert.AreEqual(4, result);
	}

	[TestMethod]
	public void FirstOrNull_MultipleMatches_ReturnsFirstMatch()
	{
		// Arrange
		var numbers = new List<int> { 1, 10, 20, 30 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrNull(n => n > 5);

		// Assert
		Assert.AreEqual(10, result);
	}

	[TestMethod]
	public void FirstOrNull_NoMatchingElement_ReturnsDefault()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Act
		var result = numbers.FirstOrNull(n => n > 10);

		// Assert
		Assert.AreEqual(default(int), result);
	}

	[TestMethod]
	public void FirstOrNull_NullableValueType_MatchExists_ReturnsValue()
	{
		// Arrange
		var nullableNumbers = new List<int?> { 1, null, 3, 4, 5 }.AsEnumerable();

		// Act
		var result = nullableNumbers.FirstOrNull(n => n > 3);

		// Assert
		Assert.AreEqual(4, result);
	}

	[TestMethod]
	public void FirstOrNull_NullableValueType_NoMatch_ReturnsDefault()
	{
		// Arrange
		var nullableNumbers = new List<int?> { 1, 2, 3 }.AsEnumerable();

		// Act
		var result = nullableNumbers.FirstOrNull(n => n > 10);

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void FirstOrNull_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.FirstOrNull(n => n > 0));
	}

	[TestMethod]
	public void FirstOrNull_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => numbers.FirstOrNull(null));
	}

	[TestMethod]
	public void FirstOrNull_ReferenceType_EmptyCollection_ReturnsNull()
	{
		// Arrange
		var emptyCollection = new List<Person>().AsEnumerable();

		// Act
		var result = emptyCollection.FirstOrNull(p => p != null);

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void FirstOrNull_ReferenceType_MatchingElementExists_ReturnsElement()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var targetPerson = people.First();

		// Act
		var result = people.FirstOrNull(p => p.Id == targetPerson.Id);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(targetPerson.Id, result.Id);
	}

	[TestMethod]
	public void FirstOrNull_ReferenceType_NoMatchingElement_ReturnsNull()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Act
		var result = people.FirstOrNull(p => p.Id == "non-existent-id-12345");

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void FirstOrNull_SingleElementMatches_ReturnsElement()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Act
		var result = singleItem.FirstOrNull(n => n == 42);

		// Assert
		Assert.AreEqual(42, result);
	}

	[TestMethod]
	public void FirstOrNull_SingleElementNoMatch_ReturnsDefault()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Act
		var result = singleItem.FirstOrNull(n => n == 100);

		// Assert
		Assert.AreEqual(default(int), result);
	}

	[TestMethod]
	public void FirstOrNull_StringCollection_MatchingElement_ReturnsElement()
	{
		// Arrange
		var strings = new List<string> { "apple", "banana", "cherry" }.AsEnumerable();

		// Act
		var result = strings.FirstOrNull(s => s.StartsWith("b", StringComparison.Ordinal));

		// Assert
		Assert.AreEqual("banana", result);
	}

	[TestMethod]
	public void FirstOrNull_StringCollection_NoMatchingElement_ReturnsNull()
	{
		// Arrange
		var strings = new List<string> { "apple", "banana", "cherry" }.AsEnumerable();

		// Act
		var result = strings.FirstOrNull(s => s.StartsWith("z", StringComparison.Ordinal));

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void FromDelimitedStringTest()
	{
		var testValue = ".net, c#, vb, f#";

		//Test
		Assert.IsTrue(testValue.ToDelimitedString(',').IsNotEmpty());
		Assert.IsTrue(testValue.ToDelimitedString().IsNotEmpty());
		Assert.IsTrue(string.Empty.ToDelimitedString().IsEmpty());
	}

	[TestMethod]
	public void HasDuplicates_AllSameValues_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 5, 5, 5, 5, 5 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_ArrayWithDuplicates_ReturnsTrue()
	{
		// Arrange
		var collection = new[] { 1, 2, 3, 3, 5 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_ArrayWithNoDuplicates_ReturnsFalse()
	{
		// Arrange
		var collection = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_DuplicateAtBeginning_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 1, 1, 2, 3, 4, 5 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_DuplicateAtEnd_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5, 1 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_EmptyArray_ReturnsFalse()
	{
		// Arrange
		var collection = Array.Empty<int>();

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_EmptyCollection_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int>();

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_HashSet_ReturnsFalse()
	{
		// Arrange - HashSet is always unique by definition
		var collection = new HashSet<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_IEnumerableNonCollection_NoDuplicates_ReturnsFalse()
	{
		// Arrange - Use Select to create an IEnumerable that is not ICollection
		IEnumerable<int> collection = Enumerable.Range(1, 10).Select(x => x);

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_IEnumerableNonCollection_WithDuplicates_ReturnsTrue()
	{
		// Arrange - Use generator to create IEnumerable with duplicates
		static IEnumerable<int> GenerateWithDuplicates()
		{
			yield return 1;
			yield return 2;
			yield return 3;
			yield return 2; // duplicate
			yield return 5;
		}

		// Act
		var result = GenerateWithDuplicates().HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_LargeCollectionNoDuplicates_ReturnsFalse()
	{
		// Arrange
		var collection = Enumerable.Range(1, 10000).ToList();

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_LargeCollectionWithDuplicates_ReturnsTrue()
	{
		// Arrange
		var collection = Enumerable.Range(1, 10000).ToList();
		collection.Add(5000); // Add a duplicate

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_ListWithDuplicates_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 2, 5 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_ListWithNoDuplicates_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int> { 1, 2, 3, 4, 5 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_NullableValueType_WithDuplicateNulls_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int?> { 1, null, 2, null, 3 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_NullCollection_ReturnsFalse()
	{
		// Arrange
		List<int> collection = null;

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_ReferenceTypeDifferentInstances_ReturnsFalse()
	{
		// Arrange
		var collection = new List<Person>
	{
		RandomData.GeneratePerson<Person>(),
		RandomData.GeneratePerson<Person>()
	};

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_ReferenceTypeSameInstance_ReturnsTrue()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		var collection = new List<Person> { person, person };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_SingleItemCollection_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int> { 42 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_StringsNoDuplicates_ReturnsFalse()
	{
		// Arrange
		var collection = new List<string> { "apple", "banana", "cherry" };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_StringsWithDuplicates_ReturnsTrue()
	{
		// Arrange
		var collection = new List<string> { "apple", "banana", "apple" };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_TwoDifferentItems_ReturnsFalse()
	{
		// Arrange
		var collection = new List<int> { 42, 43 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_TwoIdenticalItems_ReturnsTrue()
	{
		// Arrange
		var collection = new List<int> { 42, 42 };

		// Act
		var result = collection.HasDuplicates();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_WithCaseInsensitiveComparer_DuplicatesFound_ReturnsTrue()
	{
		// Arrange
		var collection = new List<string> { "apple", "Apple", "banana" };

		// Act
		var result = collection.HasDuplicates(StringComparer.OrdinalIgnoreCase);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_WithCaseInsensitiveComparer_NoDuplicates_ReturnsFalse()
	{
		// Arrange
		var collection = new List<string> { "apple", "banana", "cherry" };

		// Act
		var result = collection.HasDuplicates(StringComparer.OrdinalIgnoreCase);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicates_WithComparer_HashSetSource_StillChecksWithComparer()
	{
		// Arrange — HashSet uses default (case-sensitive) comparer, so "apple" and "Apple" are distinct.
		// But passing a case-insensitive comparer should detect them as duplicates.
		var collection = new HashSet<string> { "apple", "Apple", "banana" };

		// Act
		var result = collection.HasDuplicates(StringComparer.OrdinalIgnoreCase);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_WithComparer_IEnumerableNonCollection_ReturnsTrue()
	{
		// Arrange — deferred IEnumerable that is not ICollection
		static IEnumerable<string> Generate()
		{
			yield return "apple";
			yield return "APPLE";
			yield return "banana";
		}

		// Act
		var result = Generate().HasDuplicates(StringComparer.OrdinalIgnoreCase);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasDuplicates_WithNullComparer_BehavesSameAsDefault()
	{
		// Arrange
		var collection = new List<string> { "apple", "Apple", "banana" };

		// Act — null comparer should use default (case-sensitive), so no duplicates
		var result = collection.HasDuplicates(null);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasDuplicatesEmptyTest()
	{
		IEnumerable<string> strings = new List<string>();

		Assert.IsFalse(strings.HasDuplicates());
	}

	[TestMethod]
	public void HasDuplicatesTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		Assert.IsFalse(people.HasDuplicates());

		people = people.FastShuffle();

		var dups = people.Take(Count / 10).ToList();

		foreach (var person in dups)
		{
			people = people.AddLast(person);
		}

		var result = people.HasDuplicates();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		IEnumerable<Person> nullCollection = null;

		Assert.IsTrue(collection.IsNotEmpty(Count));

		Assert.IsFalse(collection.IsNotEmpty(100));

		Assert.IsFalse(nullCollection.IsNotEmpty(Count));
	}

	[TestMethod]
	public void IndexOf_WithComparer_CaseInsensitiveStringSearch()
	{
		var names = new List<string> { "Alice", "Bob", "Charlie" }.AsEnumerable();

		var index = names.IndexOf("alice", StringComparer.OrdinalIgnoreCase);

		Assert.AreEqual(0, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_CaseSensitiveStringSearch_NotFound()
	{
		var names = new List<string> { "Alice", "Bob", "Charlie" }.AsEnumerable();

		var index = names.IndexOf("alice", StringComparer.Ordinal);

		Assert.AreEqual(-1, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_DefaultComparerBehavior_MatchesNullComparer()
	{
		var numbers = new List<int> { 10, 20, 30, 40, 50 }.AsEnumerable();

		var indexWithNull = numbers.IndexOf(30, null);
		var indexWithDefault = numbers.IndexOf(30, EqualityComparer<int>.Default);

		Assert.AreEqual(indexWithNull, indexWithDefault);
	}

	[TestMethod]
	public void IndexOf_WithComparer_FindsFirstOccurrence()
	{
		var names = new List<string> { "Apple", "Banana", "apple", "Cherry" }.AsEnumerable();

		var index = names.IndexOf("apple", StringComparer.OrdinalIgnoreCase);

		Assert.AreEqual(0, index); // Should find "Apple" at index 0, not "apple" at index 2
	}

	[TestMethod]
	public void IndexOf_WithComparer_FindsItemWithCustomComparer()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var targetPerson = people[Count / 2];

		var index = people.IndexOf(targetPerson, new PersonEqualityComparer());

		Assert.AreEqual(Count / 2, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_FindsItemWithDefaultComparer()
	{
		var numbers = new List<int> { 10, 20, 30, 40, 50 }.AsEnumerable();

		var index = numbers.IndexOf(30, null);

		Assert.AreEqual(2, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_FirstElement_ReturnsZero()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		var index = numbers.IndexOf(1, EqualityComparer<int>.Default);

		Assert.AreEqual(0, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_ItemNotFound_ReturnsNegativeOne()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		var index = numbers.IndexOf(99, EqualityComparer<int>.Default);

		Assert.AreEqual(-1, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_LargeCollection_FindsItem()
	{
		var largeCount = 10000;
		var numbers = Enumerable.Range(1, largeCount).AsEnumerable();

		var index = numbers.IndexOf(5000, EqualityComparer<int>.Default);

		Assert.AreEqual(4999, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_LastElement_ReturnsCorrectIndex()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		var index = numbers.IndexOf(5, EqualityComparer<int>.Default);

		Assert.AreEqual(4, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_ModuloComparer_FindsEquivalentItem()
	{
		var numbers = new List<int> { 3, 6, 9, 12, 15 }.AsEnumerable();

		// Using modulo 3 comparer, searching for 18 should find 3 (both % 3 == 0)
		var index = numbers.IndexOf(18, new ModuloEqualityComparer(3));

		Assert.AreEqual(0, index); // 3 % 3 == 0, 18 % 3 == 0
	}

	[TestMethod]
	public void IndexOf_WithComparer_NullCollection_ThrowsArgumentNullException()
	{
		IEnumerable<int> nullCollection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.IndexOf(1, null));
	}

	[TestMethod]
	public void IndexOf_WithComparer_NullItem_ThrowsArgumentNullException()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.IndexOf(null, new PersonEqualityComparer()));
	}

	[TestMethod]
	public void IndexOf_WithComparer_ReferenceTypeWithPersonComparer()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var searchPerson = new Person { Id = people[10].Id };

		var index = people.IndexOf(searchPerson, new PersonEqualityComparer());

		Assert.AreEqual(10, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_SingleElementCollection_FindsItem()
	{
		var singleItem = new List<string> { "Test" }.AsEnumerable();

		var index = singleItem.IndexOf("test", StringComparer.OrdinalIgnoreCase);

		Assert.AreEqual(0, index);
	}

	[TestMethod]
	public void IndexOf_WithComparer_SingleElementCollection_NotFound()
	{
		var singleItem = new List<string> { "Test" }.AsEnumerable();

		var index = singleItem.IndexOf("Other", StringComparer.OrdinalIgnoreCase);

		Assert.AreEqual(-1, index);
	}

	[TestMethod]
	public void IndexOf_WithPredicate_FindsCorrectIndex()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var person = people.ElementAt(Count / 2);

		var index = people.IndexOf(p => p.Equals(person));

		Assert.AreEqual(Count / 2, index);
	}

	[TestMethod]
	public void IndexOf_WithPredicate_ReturnsNegativeOneWhenNotFound()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var index = people.IndexOf(p => p.FirstName == "NonExistentName");

		Assert.AreEqual(-1, index);
	}

	[TestMethod]
	public void IndexOf_WithPredicate_ThrowsArgumentNullException_WhenCollectionIsNull()
	{
		List<Person> nullCollection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.IndexOf(p => p.FirstName == "Test"));
	}

	[TestMethod]
	public void IndexOf_WithPredicate_ThrowsArgumentNullException_WhenPredicateIsNull()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.IndexOf(accumulatorPredicate: null));
	}

	[TestMethod]
	public void IndexOfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var person1 = people.FastShuffle(1).First();

		Assert.AreEqual(false, people.IndexOf(person1).IsNegative());
	}

	[TestMethod]
	public void IsEmpty_EmptyArray_ReturnsTrue()
	{
		// Arrange
		var emptyArray = Array.Empty<int>();

		// Act
		var result = emptyArray.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyConcurrentBag_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> concurrentBag = new ConcurrentBag<int>();

		// Act
		var result = concurrentBag.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyConcurrentQueue_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> concurrentQueue = new ConcurrentQueue<int>();

		// Act
		var result = concurrentQueue.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyConcurrentStack_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> concurrentStack = new ConcurrentStack<int>();

		// Act
		var result = concurrentStack.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyDeferredEnumerable_ReturnsTrue()
	{
		// Arrange - Use LINQ query that returns IEnumerable (fallback path)
		var deferred = Enumerable.Range(1, 10).Where(x => x > 100);

		// Act
		var result = deferred.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyFrozenSet_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> frozenSet = FrozenSet<int>.Empty;

		// Act
		var result = frozenSet.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyHashSet_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> hashSet = new HashSet<int>();

		// Act
		var result = hashSet.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyImmutableHashSet_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> immutableHashSet = ImmutableHashSet<int>.Empty;

		// Act
		var result = immutableHashSet.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyImmutableList_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> immutableList = ImmutableList<int>.Empty;

		// Act
		var result = immutableList.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyImmutableQueue_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> immutableQueue = ImmutableQueue<int>.Empty;

		// Act
		var result = immutableQueue.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyImmutableSortedSet_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> immutableSortedSet = ImmutableSortedSet<int>.Empty;

		// Act
		var result = immutableSortedSet.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyImmutableStack_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> immutableStack = ImmutableStack<int>.Empty;

		// Act
		var result = immutableStack.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyLinkedList_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> linkedList = new LinkedList<int>();

		// Act
		var result = linkedList.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyList_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> list = new List<int>();

		// Act
		var result = list.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyObservableCollection_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> observableCollection = new ObservableCollection<int>();

		// Act
		var result = observableCollection.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyQueue_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> queue = new Queue<int>();

		// Act
		var result = queue.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyReadOnlyCollection_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> readOnlyCollection = new ReadOnlyCollection<int>(new List<int>());

		// Act
		var result = readOnlyCollection.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_EmptyStack_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> stack = new Stack<int>();

		// Act
		var result = stack.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_LargeCollection_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> collection = Enumerable.Range(1, Count);

		// Act
		var result = collection.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyArray_ReturnsFalse()
	{
		// Arrange
		var array = new[] { 1, 2, 3 };

		// Act
		var result = array.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyConcurrentBag_ReturnsFalse()
	{
		// Arrange
		var concurrentBag = new ConcurrentBag<int>();
		concurrentBag.Add(1);

		// Act
		var result = concurrentBag.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyConcurrentQueue_ReturnsFalse()
	{
		// Arrange
		var concurrentQueue = new ConcurrentQueue<int>();
		concurrentQueue.Enqueue(1);

		// Act
		var result = concurrentQueue.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyConcurrentStack_ReturnsFalse()
	{
		// Arrange
		var concurrentStack = new ConcurrentStack<int>();
		concurrentStack.Push(1);

		// Act
		var result = concurrentStack.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyDeferredEnumerable_ReturnsFalse()
	{
		// Arrange - Use LINQ query that returns IEnumerable (fallback path)
		var deferred = Enumerable.Range(1, 10).Where(x => x > 5);

		// Act
		var result = deferred.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyFrozenSet_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> frozenSet = new HashSet<int> { 1, 2, 3 }.ToFrozenSet();

		// Act
		var result = frozenSet.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyHashSet_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> hashSet = new HashSet<int> { 1, 2, 3 };

		// Act
		var result = hashSet.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyImmutableHashSet_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> immutableHashSet = ImmutableHashSet.Create(1, 2, 3);

		// Act
		var result = immutableHashSet.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyImmutableList_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> immutableList = ImmutableList.Create(1, 2, 3);

		// Act
		var result = immutableList.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyImmutableQueue_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> immutableQueue = ImmutableQueue.Create(1, 2, 3);

		// Act
		var result = immutableQueue.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyImmutableSortedSet_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> immutableSortedSet = ImmutableSortedSet.Create(1, 2, 3);

		// Act
		var result = immutableSortedSet.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyImmutableStack_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> immutableStack = ImmutableStack.Create(1, 2, 3);

		// Act
		var result = immutableStack.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyLinkedList_ReturnsFalse()
	{
		// Arrange
		var linkedList = new LinkedList<int>();
		linkedList.AddLast(1);
		linkedList.AddLast(2);
		IEnumerable<int> collection = linkedList;

		// Act
		var result = collection.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyList_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> list = new List<int> { 1, 2, 3 };

		// Act
		var result = list.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyObservableCollection_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> observableCollection = new ObservableCollection<int> { 1, 2, 3 };

		// Act
		var result = observableCollection.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyQueue_ReturnsFalse()
	{
		// Arrange
		var queue = new Queue<int>();
		queue.Enqueue(1);
		IEnumerable<int> collection = queue;

		// Act
		var result = collection.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyReadOnlyCollection_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> readOnlyCollection = new ReadOnlyCollection<int>(new List<int> { 1, 2, 3 });

		// Act
		var result = readOnlyCollection.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_NonEmptyStack_ReturnsFalse()
	{
		// Arrange
		var stack = new Stack<int>();
		stack.Push(1);
		IEnumerable<int> collection = stack;

		// Act
		var result = collection.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	// Tests for IsEmpty() method - covers all optimized paths

	[TestMethod]
	public void IsEmpty_NullCollection_ReturnsTrue()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;

		// Act
		var result = nullCollection.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_ReferenceTypeCollection_EmptyList_ReturnsTrue()
	{
		// Arrange
		IEnumerable<Person> people = new List<Person>();

		// Act
		var result = people.IsEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEmpty_ReferenceTypeCollection_NonEmptyList_ReturnsFalse()
	{
		// Arrange
		IEnumerable<Person> people = RandomData.GeneratePersonRefCollection(5);

		// Act
		var result = people.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsEmpty_SingleElementCollection_ReturnsFalse()
	{
		// Arrange
		IEnumerable<int> collection = new List<int> { 42 };

		// Act
		var result = collection.IsEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsNotEmptyTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.IsNotEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsNullOrEmptyTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.IsNullOrEmpty();

		Assert.IsFalse(result);

		result = people.Take(0).IsNullOrEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void JoinTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.Join();

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void OrderBy_Ascending_ReturnsOrderedResults()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy("Email").ToList();

		Assert.IsTrue(result.IsNotEmpty());
		for (var i = 1; i < result.Count; i++)
		{
			Assert.IsTrue(string.Compare(result[i - 1].Email, result[i].Email, StringComparison.Ordinal) <= 0);
		}
	}

	[TestMethod]
	public void OrderBy_CacheHit_ReturnsSameResults()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result1 = people.OrderBy("Email").ToList();
		var result2 = people.OrderBy("Email").ToList();

		Assert.IsTrue(result1.SequenceEqual(result2));
	}

	[TestMethod]
	public void OrderBy_Descending_ReturnsDescendingResults()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy("Email descending").ToList();

		Assert.IsTrue(result.IsNotEmpty());
		for (var i = 1; i < result.Count; i++)
		{
			Assert.IsTrue(string.Compare(result[i - 1].Email, result[i].Email, StringComparison.Ordinal) >= 0);
		}
	}

	[TestMethod]
	public void OrderBy_EmptySortExpression_ReturnsOriginal()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy(string.Empty);

		Assert.IsTrue(result.IsNotEmpty());
		Assert.IsTrue(result.SequenceEqual(people));
	}

	[TestMethod]
	public void OrderBy_InvalidPropertyName_ReturnsCollectionOrderedByNull()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy("NonExistentProperty");

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void OrderBy_NullCollection_ThrowsArgumentNullException()
	{
		IEnumerable<Person> nullCollection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.OrderBy("Email").ToList());
	}

	[TestMethod]
	public void OrderBy_NullSortExpression_ReturnsOriginalCollection()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy(null);

		Assert.IsTrue(result.IsNotEmpty());
		Assert.IsTrue(result.SequenceEqual(people));
	}

	[TestMethod]
	public void OrderBy_SamePropertyCalledTwice_UsesCacheAndReturnsSortedResults()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result1 = people.OrderBy("Email").ToList();
		var result2 = people.OrderBy("Email").ToList();

		CollectionAssert.AreEqual(result1, result2);
	}

	[TestMethod]
	public void OrderBy_SingleElementCollection_ReturnsSingleElement()
	{
		var person = RandomData.GeneratePersonRefCollection(1).First();
		var people = new[] { person }.AsEnumerable();

		var result = people.OrderBy("Email").ToList();

		Assert.AreEqual(1, result.Count);
		Assert.AreSame(person, result[0]);
	}

	[TestMethod]
	public void OrderBy_ValidPropertyAscending_ReturnsSortedAscending()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy("Email").ToList();

		var expected = people.OrderBy(p => p.Email, StringComparer.Ordinal).ToList();
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void OrderBy_ValidPropertyDescendingWithDesc_ReturnsSortedDescending()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy("Email desc").ToList();

		var expected = people.OrderByDescending(p => p.Email, StringComparer.Ordinal).ToList();
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void OrderBy_ValidPropertyDescendingWithDescending_ReturnsSortedDescending()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy("Email descending").ToList();

		var expected = people.OrderByDescending(p => p.Email, StringComparer.Ordinal).ToList();
		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void OrderBy_WhitespaceOnlySortExpression_ReturnsOriginal()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy("   ");

		Assert.IsTrue(result.IsNotEmpty());
		Assert.IsTrue(result.SequenceEqual(people));
	}

	[TestMethod]
	public void OrderByOrdinalTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderByOrdinal(p => p.Email);

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void OrderByTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.OrderBy("Email desc");

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public async Task PageAsync_CancellationRequested_ThrowsOperationCanceledException()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(Enumerable.Range(1, 100));
		using var cts = new CancellationTokenSource();
		var pageSize = 5;

		// Act & Assert
		await Assert.ThrowsExactlyAsync<OperationCanceledException>(async () =>
		{
			var pageCount = 0;
			await foreach (var page in numbers.PageAsync(pageSize, cts.Token))
			{
				pageCount++;
				if (pageCount == 2)
				{
					cts.Cancel();
				}
			}
		});
	}

	[TestMethod]
	public async Task PageAsync_ComplexType_PagesCorrectly()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(10);
		var asyncPeople = ToAsyncEnumerable(people);
		var pageSize = 3;

		// Act
		var pages = new List<List<Person>>();
		await foreach (var page in asyncPeople.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(4, pages);
		Assert.HasCount(3, pages[0]);
		Assert.HasCount(3, pages[1]);
		Assert.HasCount(3, pages[2]);
		Assert.HasCount(1, pages[3]);
	}

	[TestMethod]
	public async Task PageAsync_EmptyCollection_ReturnsNoPages()
	{
		// Arrange
		var emptyCollection = ToAsyncEnumerable(Array.Empty<int>());
		var pageSize = 5;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in emptyCollection.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(0, pages);
	}

	[TestMethod]
	public async Task PageAsync_ExactlyPageSizeItems_ReturnsSingleFullPage()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(Enumerable.Range(1, 5));
		var pageSize = 5;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(1, pages);
		Assert.HasCount(5, pages[0]);
		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, pages[0]);
	}

	[TestMethod]
	public async Task PageAsync_ExactMultipleOfPageSize_ReturnsFullPages()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(Enumerable.Range(1, 10));
		var pageSize = 5;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(2, pages);
		Assert.HasCount(5, pages[0]);
		Assert.HasCount(5, pages[1]);
		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, pages[0]);
		CollectionAssert.AreEqual(new[] { 6, 7, 8, 9, 10 }, pages[1]);
	}

	[TestMethod]
	public async Task PageAsync_ItemsLessThanPageSize_ReturnsSinglePartialPage()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(new[] { 1, 2, 3 });
		var pageSize = 10;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(1, pages);
		Assert.HasCount(3, pages[0]);
		CollectionAssert.AreEqual(new[] { 1, 2, 3 }, pages[0]);
	}

	[TestMethod]
	public async Task PageAsync_LargeCollection_PagesCorrectly()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(Enumerable.Range(1, 1000));
		var pageSize = 100;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(10, pages);
		Assert.IsTrue(pages.All(p => p.Count == 100));
	}

	[TestMethod]
	public async Task PageAsync_NotExactMultiple_ReturnsPartialLastPage()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(Enumerable.Range(1, 7));
		var pageSize = 3;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(3, pages);
		Assert.HasCount(3, pages[0]);
		Assert.HasCount(3, pages[1]);
		Assert.HasCount(1, pages[2]);
		CollectionAssert.AreEqual(new[] { 1, 2, 3 }, pages[0]);
		CollectionAssert.AreEqual(new[] { 4, 5, 6 }, pages[1]);
		CollectionAssert.AreEqual(new[] { 7 }, pages[2]);
	}

	[TestMethod]
	public async Task PageAsync_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IAsyncEnumerable<int> nullCollection = null;

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await foreach (var page in nullCollection.PageAsync(5))
			{
				// Should not reach here
			}
		});
	}

	[TestMethod]
	public async Task PageAsync_PageSizeLessThanTwo_EnforcesMinimumTwo()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(Enumerable.Range(1, 5));
		var pageSize = 1; // Should be enforced to 2

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(3, pages);
		Assert.HasCount(2, pages[0]);
		Assert.HasCount(2, pages[1]);
		Assert.HasCount(1, pages[2]);
	}

	[TestMethod]
	public async Task PageAsync_PreAllocatesPageCapacity()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(Enumerable.Range(1, 10));
		var pageSize = 5;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			pages.Add(page);
			// Verify that each page has correct count
			Assert.IsTrue(page.Count <= pageSize);
		}

		// Assert
		Assert.HasCount(2, pages);
	}

	[TestMethod]
	public async Task PageAsync_PreserversElementOrder()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(new[] { 5, 3, 8, 1, 9, 2, 7, 4, 6 });
		var pageSize = 3;

		// Act
		var allItems = new List<int>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			allItems.AddRange(page);
		}

		// Assert
		CollectionAssert.AreEqual(new[] { 5, 3, 8, 1, 9, 2, 7, 4, 6 }, allItems);
	}

	[TestMethod]
	public async Task PageAsync_ReferenceType_PagesCorrectly()
	{
		// Arrange
		var strings = ToAsyncEnumerable(new[] { "a", "b", "c", "d", "e" });
		var pageSize = 2;

		// Act
		var pages = new List<List<string>>();
		await foreach (var page in strings.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(3, pages);
		CollectionAssert.AreEqual(new[] { "a", "b" }, pages[0]);
		CollectionAssert.AreEqual(new[] { "c", "d" }, pages[1]);
		CollectionAssert.AreEqual(new[] { "e" }, pages[2]);
	}

	[TestMethod]
	public async Task PageAsync_SingleItem_ReturnsSinglePageWithOneItem()
	{
		// Arrange
		var singleItem = ToAsyncEnumerable(new[] { 42 });
		var pageSize = 5;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in singleItem.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(1, pages);
		Assert.HasCount(1, pages[0]);
		Assert.AreEqual(42, pages[0][0]);
	}

	[TestMethod]
	public async Task PageAsync_WithDefaultCancellationToken_CompletesSuccessfully()
	{
		// Arrange
		var numbers = ToAsyncEnumerable(Enumerable.Range(1, 6));
		var pageSize = 3;

		// Act
		var pages = new List<List<int>>();
		await foreach (var page in numbers.PageAsync(pageSize))
		{
			pages.Add(page);
		}

		// Assert
		Assert.HasCount(2, pages);
		Assert.AreEqual(6, pages.Sum(p => p.Count));
	}

	[TestMethod]
	public void Partition_WithArray_PartitionsCorrectly()
	{
		// Arrange - T[] is IEnumerable<T>; Chunk handles arrays with index optimization
		var numbers = Enumerable.Range(1, 10).ToArray();

		// Act
		var result = ((IEnumerable<int>)numbers).Partition(3).ToList();

		// Assert - 10 / 3 = 3 full chunks + 1 partial
		Assert.HasCount(4, result);
		Assert.HasCount(3, result[0]);
		Assert.HasCount(1, result[3]);
	}

	[TestMethod]
	public void Partition_WithICollection_PartitionsCorrectly()
	{
		// Arrange - Queue<T> is ICollection<T> so Chunk uses pre-sized path
		var source = new Queue<int>(Enumerable.Range(1, 9));

		// Act
		var result = ((IEnumerable<int>)source).Partition(3).ToList();

		// Assert - 9 / 3 = exactly 3 full chunks
		Assert.HasCount(3, result);
		Assert.HasCount(3, result[0]);
		Assert.HasCount(3, result[2]);
	}

	[TestMethod]
	public void PartitionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var splitPeople = people.Partition(people.Count() / 10);

		Assert.IsNotNull(splitPeople);
		Assert.HasCount(11, splitPeople);

		var emptyPeople = new List<Person>();

		var splitEmptyPeople = emptyPeople.Partition(10).ToList();

		Assert.IsNotNull(splitEmptyPeople);

	}

	[TestMethod]
	public void PickRandom_EmptyEnumerable_ReturnsDefault()
	{
		var emptyEnumerable = Enumerable.Empty<Person>();

		var result = emptyEnumerable.PickRandom();

		Assert.IsNull(result);
	}

	[TestMethod]
	public void PickRandom_EmptyHashSet_ReturnsDefault()
	{
		// Arrange
		IEnumerable<Person> emptySet = new HashSet<Person>();

		// Act
		var result = emptySet.PickRandom();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void PickRandom_EmptyList_ReturnsDefault()
	{
		var emptyList = new List<Person>();

		var result = emptyList.PickRandom();

		Assert.IsNull(result);
	}

	[TestMethod]
	public void PickRandom_EmptyQueue_ReturnsDefault()
	{
		// Arrange
		IEnumerable<Person> emptyQueue = new Queue<Person>();

		// Act
		var result = emptyQueue.PickRandom();

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void PickRandom_NonEmptyArray_ReturnsElementFromCollection()
	{
		IEnumerable<Person> people = RandomData.GeneratePersonRefCollection(Count).ToArray();

		var result = people.PickRandom();

		Assert.IsNotNull(result);
		Assert.IsTrue(people.Contains(result));
	}

	[TestMethod]
	public void PickRandom_NonEmptyHashSet_ReturnsElementFromCollection()
	{
		// Arrange - HashSet<T> is ICollection<T> but not IList<T>, hits the ICollection path
		IEnumerable<Person> people = new HashSet<Person>(RandomData.GeneratePersonRefCollection(Count));

		// Act
		var result = people.PickRandom();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(people.Contains(result));
	}

	[TestMethod]
	public void PickRandom_NonEmptyList_ReturnsElementFromCollection()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		var result = people.PickRandom();

		Assert.IsNotNull(result);
		Assert.IsTrue(people.Contains(result));
	}

	[TestMethod]
	public void PickRandom_NonEmptyQueue_ReturnsElementFromCollection()
	{
		// Arrange - Queue<T> is ICollection<T> but not IList<T>, hits the ICollection path
		var source = RandomData.GeneratePersonRefCollection(Count);
		var queue = new Queue<Person>(source);
		IEnumerable<Person> people = queue;

		// Act
		var result = people.PickRandom();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(source.Contains(result));
	}

	[TestMethod]
	public void PickRandom_NullCollection_ThrowsArgumentNullException()
	{
		IEnumerable<Person> collection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => collection.PickRandom());
	}

	[TestMethod]
	public void PickRandomTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.PickRandom();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	[Obsolete]
	public void RemoveDuplicatesTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		var dups = people.Shuffle().Take(Count / 2).ToList();

		foreach (var person in dups)
		{
			_ = people.AddLast(person);
		}

		var result = people.RemoveDuplicates();
		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void RemoveNulls_AllNullItems()
	{
		var collection = new List<string> { null, null, null };
		var result = collection.RemoveNulls().ToList();

		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void RemoveNulls_EmptyCollection()
	{
		var collection = new List<string>();
		var result = collection.RemoveNulls().ToList();

		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void RemoveNulls_NoNullItems()
	{
		var collection = new List<string> { "apple", "banana", "cherry" };
		var result = collection.RemoveNulls().ToList();

		Assert.HasCount(3, result);
		CollectionAssert.AreEqual(new List<string> { "apple", "banana", "cherry" }, result);
	}

	[TestMethod]
	public void RemoveNulls_NullCollection_ThrowsArgumentNullException()
	{
		List<string> nullCollection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.RemoveNulls().ToList());
	}

	[TestMethod]
	public void RemoveNulls_RemovesNullItems()
	{
		var collection = new List<string> { "apple", null, "banana", null, "cherry" };
		var result = collection.RemoveNulls().ToList();

		Assert.HasCount(3, result);

		// Verify order preservation explicitly
		Assert.AreEqual("apple", result[0]);
		Assert.AreEqual("banana", result[1]);
		Assert.AreEqual("cherry", result[2]);
	}

	[TestMethod]
	public void ReplaceIf_AllItemsMatch_ReplacesAll()
	{
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => true, 99).ToList();

		CollectionAssert.AreEqual(new List<int> { 99, 99, 99 }, result);
	}

	[TestMethod]
	public void ReplaceIf_ComplexPredicate_ReplacesCorrectly()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => (n % 2 == 0) && (i < 5), -1).ToList();

		CollectionAssert.AreEqual(new List<int> { 1, -1, 3, -1, 5, 6, 7, 8, 9, 10 }, result);
	}

	[TestMethod]
	public void ReplaceIf_EmptyCollection_ReturnsEmpty()
	{
		var emptyList = new List<int>().AsEnumerable();

		var result = emptyList.ReplaceIf((item, index) => true, 99).ToList();

		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void ReplaceIf_LargeCollection_PerformanceTest()
	{
		var numbers = Enumerable.Range(1, Count).AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => n % 100 == 0, 0).ToList();

		Assert.HasCount(Count, result);
		Assert.AreEqual(0, result[99]); // 100th element (index 99) should be replaced
	}

	[TestMethod]
	public void ReplaceIf_NoMatchingItems_ReturnsOriginal()
	{
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => n > 10, 0).ToList();

		CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result);
	}

	[TestMethod]
	public void ReplaceIf_NullCollection_ThrowsArgumentNullException()
	{
		IEnumerable<int> nullCollection = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.ReplaceIf((item, index) => true, 0).ToList());
	}

	[TestMethod]
	public void ReplaceIf_NullPredicate_ThrowsArgumentNullException()
	{
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => numbers.ReplaceIf(null, 0).ToList());
	}

	[TestMethod]
	public void ReplaceIf_PreservesOriginalCollection()
	{
		var originalNumbers = new List<int> { 1, 2, 3, 4, 5 };
		var numbers = originalNumbers.AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => n > 3, 0).ToList();

		// Original collection should be unchanged
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, originalNumbers);
		// Result should have replacements
		CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 0, 0 }, result);
	}

	[TestMethod]
	public void ReplaceIf_ReplaceBasedOnIndex_ReplacesCorrectly()
	{
		var numbers = new List<int> { 10, 20, 30, 40, 50 }.AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => i % 2 == 0, -1).ToList();

		CollectionAssert.AreEqual(new List<int> { -1, 20, -1, 40, -1 }, result);
	}

	[TestMethod]
	public void ReplaceIf_ReplaceItemsGreaterThanThreshold_ReplacesCorrectly()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => n > 3, 0).ToList();

		CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 0, 0 }, result);
	}

	[TestMethod]
	public void ReplaceIf_SingleElement_DoesNotReplaceIfNoMatch()
	{
		var numbers = new List<int> { 42 }.AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => n != 42, 0).ToList();

		CollectionAssert.AreEqual(new List<int> { 42 }, result);
	}

	[TestMethod]
	public void ReplaceIf_SingleElement_ReplacesIfMatches()
	{
		var numbers = new List<int> { 42 }.AsEnumerable();

		var result = numbers.ReplaceIf((n, i) => n == 42, 0).ToList();

		CollectionAssert.AreEqual(new List<int> { 0 }, result);
	}

	[TestMethod]
	public void ReplaceIf_WithArray_ReplacesCorrectly()
	{
		var numbers = new int[] { 1, 2, 3, 4, 5 };

		var result = numbers.ReplaceIf((n, i) => n % 2 == 0, 0).ToList();

		CollectionAssert.AreEqual(new List<int> { 1, 0, 3, 0, 5 }, result);
	}

	[TestMethod]
	public void ReplaceIf_WithIList_ReplacesCorrectly()
	{
		IList<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

		var result = numbers.ReplaceIf((n, i) => n == 3, 99).ToList();

		CollectionAssert.AreEqual(new List<int> { 1, 2, 99, 4, 5 }, result);
	}

	[TestMethod]
	public void ReplaceIf_WithList_ReplacesCorrectly()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5 };

		var result = numbers.ReplaceIf((n, i) => n > 2, 0).ToList();

		CollectionAssert.AreEqual(new List<int> { 1, 2, 0, 0, 0 }, result);
	}

	[TestMethod]
	public void ReplaceIf_WithNullReplacement_ReplacesWithNull()
	{
		var words = new List<string> { "apple", "banana", "cherry" }.AsEnumerable();

		var result = words.ReplaceIf((s, i) => s == "banana", null).ToList();

		Assert.HasCount(3, result);
		Assert.IsNull(result[1]);
	}

	[TestMethod]
	public void ReplaceIf_WithReferenceTypes_ReplacesCorrectly()
	{
		var people = RandomData.GeneratePersonRefCollection(5).AsEnumerable();
		var replacementPerson = RandomData.GeneratePerson<Person>();

		var result = people.ReplaceIf((p, i) => i == 2, replacementPerson).ToList();

		Assert.HasCount(5, result);
		Assert.AreEqual(replacementPerson, result[2]);
	}

	[TestMethod]
	public void ReplaceIf_WithStrings_ReplacesCorrectly()
	{
		var words = new List<string> { "apple", "banana", "cherry", "date" }.AsEnumerable();

		var result = words.ReplaceIf((s, i) => s.Contains('a'), "REPLACED").ToList();

		CollectionAssert.AreEqual(new List<string> { "REPLACED", "REPLACED", "cherry", "REPLACED" }, result);
	}


	[TestMethod]
	public void ShuffleTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		List<Person> nullList = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(nullList.Shuffle);

		Assert.HasCount(Count, people.Shuffle());
	}

	[TestMethod]
	public void ShuffleWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		List<Person> nullList = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(nullList.Shuffle);

		Assert.HasCount(5, people.FastShuffle(5));
	}

	[TestMethod]
	public void StartsWith_BothEmpty_ReturnsTrue()
	{
		var first = Enumerable.Empty<int>();
		var second = Enumerable.Empty<int>();

		Assert.IsTrue(first.StartsWith(second));
	}

	[TestMethod]
	public void StartsWith_EmptySecond_ReturnsTrue()
	{
		var first = new List<int> { 1, 2, 3 }.AsEnumerable();
		var second = Enumerable.Empty<int>();

		Assert.IsTrue(first.StartsWith(second));
	}

	[TestMethod]
	public void StartsWith_FirstShorterThanSecond_ReturnsFalse()
	{
		var first = new List<int> { 1, 2 }.AsEnumerable();
		var second = new List<int> { 1, 2, 3 }.AsEnumerable();

		Assert.IsFalse(first.StartsWith(second));
	}

	[TestMethod]
	public void StartsWith_NonMatchingElements_ReturnsFalse()
	{
		var first = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();
		var second = new List<int> { 1, 2, 99 }.AsEnumerable();

		Assert.IsFalse(first.StartsWith(second));
	}

	[TestMethod]
	public void StartsWith_NullCollection_ReturnsFalse()
	{
		IEnumerable<int> nullCollection = null;
		var second = new List<int> { 1, 2, 3 }.AsEnumerable();

		Assert.IsFalse(nullCollection.StartsWith(second));
	}

	[TestMethod]
	public void StartsWith_NullSecond_ReturnsFalse()
	{
		var first = new List<int> { 1, 2, 3 }.AsEnumerable();

		Assert.IsFalse(first.StartsWith(null));
	}

	[TestMethod]
	public void StartsWith_SameReference_ReturnsTrue()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		Assert.IsTrue(people.StartsWith(people));
	}

	[TestMethod]
	public void StartsWithTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var people1 = people.Take(5);
		var people2 = people1;

		Assert.IsTrue(people.StartsWith(people.Take(5)));

		Assert.IsTrue(people1.StartsWith(people2));
	}

	[TestMethod]
	public void StructuralSequenceEqual_BothEmpty_ReturnsTrue()
	{
		var first = Enumerable.Empty<int>();
		var second = Enumerable.Empty<int>();

		Assert.IsTrue(first.StructuralSequenceEqual(second));
	}

	[TestMethod]
	public void StructuralSequenceEqual_DifferentElements_ReturnsFalse()
	{
		var first = new List<int> { 1, 2, 3 }.AsEnumerable();
		var second = new List<int> { 1, 2, 99 }.AsEnumerable();

		Assert.IsFalse(first.StructuralSequenceEqual(second));
	}

	[TestMethod]
	public void StructuralSequenceEqual_EqualSequences_ReturnsTrue()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();
		var copy = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		Assert.IsTrue(numbers.StructuralSequenceEqual(copy));
	}

	[TestMethod]
	public void StructuralSequenceEqual_FirstLongerThanSecond_ReturnsFalse()
	{
		var first = new List<int> { 1, 2, 3, 4 }.AsEnumerable();
		var second = new List<int> { 1, 2, 3 }.AsEnumerable();

		Assert.IsFalse(first.StructuralSequenceEqual(second));
	}

	[TestMethod]
	public void StructuralSequenceEqual_NullCollection_ReturnsFalse()
	{
		IEnumerable<int> nullCollection = null;
		var second = new List<int> { 1, 2, 3 }.AsEnumerable();

		Assert.IsFalse(nullCollection.StructuralSequenceEqual(second));
	}

	[TestMethod]
	public void StructuralSequenceEqual_NullSecond_ReturnsFalse()
	{
		var first = new List<int> { 1, 2, 3 }.AsEnumerable();

		Assert.IsFalse(first.StructuralSequenceEqual(null));
	}

	[TestMethod]
	public void StructuralSequenceEqual_SameReference_ReturnsTrue()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		Assert.IsTrue(people.StructuralSequenceEqual(people));
	}

	[TestMethod]
	public void StructuralSequenceEqual_SecondLongerThanFirst_ReturnsFalse()
	{
		var first = new List<int> { 1, 2, 3 }.AsEnumerable();
		var second = new List<int> { 1, 2, 3, 4 }.AsEnumerable();

		Assert.IsFalse(first.StructuralSequenceEqual(second));
	}

	[TestMethod]
	public void StructuralSequenceEqualTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection(Count);

		var people2 = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsFalse(people1.StructuralSequenceEqual(people2));
	}

	[TestMethod]
	public void ToBlockingTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.ToBlockingCollection();

		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void ToCollection_IsMutable_CanAddItem()
	{
		// Arrange
		var numbers = new int[] { 1, 2, 3 };

		// Act
		var result = ((IEnumerable<int>)numbers).ToCollection();
		result.Add(99);

		// Assert
		Assert.HasCount(4, result);
		Assert.IsTrue(result.Contains(99));
	}

	[TestMethod]
	public void ToCollection_IsMutable_CanModifyItem()
	{
		// Arrange
		var numbers = new int[] { 10, 20, 30 };

		// Act
		var result = ((IEnumerable<int>)numbers).ToCollection();
		result[0] = 99;

		// Assert
		Assert.AreEqual(99, result[0]);
	}

	[TestMethod]
	public void ToCollection_IsMutable_CanRemoveItem()
	{
		// Arrange
		var numbers = new int[] { 1, 2, 3 };

		// Act
		var result = ((IEnumerable<int>)numbers).ToCollection();
		var removed = result.Remove(2);

		// Assert
		Assert.IsTrue(removed);
		Assert.HasCount(2, result);
		Assert.IsFalse(result.Contains(2));
	}

	[TestMethod]
	public void ToCollection_WithArray_WrapsDirectly()
	{
		// Arrange - T[] is IList<T>, so it wraps without copying
		var numbers = new int[] { 1, 2, 3, 4, 5 };

		// Act
		var result = ((IEnumerable<int>)numbers).ToCollection();

		// Assert
		Assert.HasCount(5, result);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(5, result[4]);
	}

	[TestMethod]
	public void ToCollection_WithDeferredEnumerable_MaterializesAndWraps()
	{
		// Arrange - Where query is neither IList<T> nor ICollection<T>
		var numbers = Enumerable.Range(1, 5).Where(_ => true);

		// Act
		var result = numbers.ToCollection();

		// Assert
		Assert.HasCount(5, result);
	}

	[TestMethod]
	public void ToCollection_WithICollection_PreSizesAndCopies()
	{
		// Arrange - Queue<T> is ICollection<T> but not IList<T>
		var source = new Queue<int>(new[] { 10, 20, 30 });

		// Act
		var result = ((IEnumerable<int>)source).ToCollection();

		// Assert
		Assert.HasCount(3, result);
		Assert.IsTrue(result.Contains(20));
	}

	[TestMethod]
	public void ToCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsTrue(people.ToCollection().IsNotEmpty());
	}

	[TestMethod]
	public void ToFrozenSet_Array_ReturnsFrozenSet()
	{
		// Arrange
		var numbers = new int[] { 10, 20, 30, 40, 50 };

		// Act
		var result = numbers.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(5, result);
		Assert.IsTrue(result.Contains(30));
	}

	[TestMethod]
	public void ToFrozenSet_CollectionWithDuplicates_ReturnsUniqueElements()
	{
		// Arrange
		var numbersWithDuplicates = new List<int> { 1, 2, 2, 3, 3, 3, 4, 5, 5 }.AsEnumerable();

		// Act
		var result = numbersWithDuplicates.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(5, result);
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5 }, result.ToList());
	}

	[TestMethod]
	public void ToFrozenSet_ContainsLookup_PerformsCorrectly()
	{
		// Arrange
		var numbers = Enumerable.Range(1, 100).AsEnumerable();
		var frozenSet = numbers.ToFrozenSet();

		// Act & Assert - verify Contains works correctly
		Assert.IsTrue(frozenSet.Contains(1));
		Assert.IsTrue(frozenSet.Contains(50));
		Assert.IsTrue(frozenSet.Contains(100));
		Assert.IsFalse(frozenSet.Contains(0));
		Assert.IsFalse(frozenSet.Contains(101));
	}

	[TestMethod]
	public void ToFrozenSet_DeferredEnumerable_ReturnsFrozenSet()
	{
		// Arrange
		var deferred = Enumerable.Range(1, 10).Where(x => x % 2 == 0);

		// Act
		var result = deferred.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(5, result);
		Assert.IsTrue(result.Contains(2));
		Assert.IsTrue(result.Contains(10));
		Assert.IsFalse(result.Contains(1));
	}

	[TestMethod]
	public void ToFrozenSet_EmptyCollection_ReturnsEmptyFrozenSet()
	{
		// Arrange
		var emptyCollection = new List<int>().AsEnumerable();

		// Act
		var result = emptyCollection.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(0, result);
	}

	[TestMethod]
	public void ToFrozenSet_IsImmutable_CannotBeModified()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Act
		var frozenSet = numbers.ToFrozenSet();

		// Assert - FrozenSet is immutable, verify it's read-only
		Assert.IsInstanceOfType<FrozenSet<int>>(frozenSet);
		Assert.HasCount(3, frozenSet);
	}

	[TestMethod]
	public void ToFrozenSet_LargeCollection_ReturnsFrozenSet()
	{
		// Arrange
		var largeCollection = Enumerable.Range(1, Count).AsEnumerable();

		// Act
		var result = largeCollection.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(Count, result);
		Assert.IsTrue(result.Contains(1));
		Assert.IsTrue(result.Contains(Count));
	}

	[TestMethod]
	public void ToFrozenSet_NonEmptyCollection_ReturnsFrozenSetWithAllElements()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		// Act
		var result = numbers.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(5, result);
		Assert.IsTrue(result.Contains(1));
		Assert.IsTrue(result.Contains(5));
	}

	[TestMethod]
	public void ToFrozenSet_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<int> nullCollection = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullCollection.ToFrozenSet());
	}

	[TestMethod]
	public void ToFrozenSet_ReferenceType_ReturnsFrozenSetWithAllElements()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Act
		var result = people.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(Count, result.Count);
	}

	[TestMethod]
	public void ToFrozenSet_SingleItemCollection_ReturnsFrozenSetWithOneElement()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Act
		var result = singleItem.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(1, result);
		Assert.IsTrue(result.Contains(42));
	}

	[TestMethod]
	public void ToFrozenSet_StringCollection_ReturnsFrozenSet()
	{
		// Arrange
		var strings = new List<string> { "apple", "banana", "cherry" }.AsEnumerable();

		// Act
		var result = strings.ToFrozenSet();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(3, result);
		Assert.IsTrue(result.Contains("apple"));
		Assert.IsTrue(result.Contains("banana"));
		Assert.IsTrue(result.Contains("cherry"));
	}

	[TestMethod]
	public void ToFrozenSet_StringCollectionWithDuplicates_ReturnsUniqueStrings()
	{
		// Arrange
		var stringsWithDuplicates = new List<string> { "apple", "Apple", "APPLE", "banana" }.AsEnumerable();

		// Act
		var result = stringsWithDuplicates.ToFrozenSet();

		// Assert - default string comparison is case-sensitive
		Assert.IsNotNull(result);
		Assert.HasCount(4, result);
	}

	[TestMethod]
	public void ToFrozenSet_WithCaseInsensitiveComparer_CollapsesDuplicates()
	{
		// Arrange
		var strings = new List<string> { "apple", "Apple", "APPLE", "banana" }.AsEnumerable();

		// Act
		var result = strings.ToFrozenSet(StringComparer.OrdinalIgnoreCase);

		// Assert — case-insensitive: "apple"/"Apple"/"APPLE" collapse into one
		Assert.IsNotNull(result);
		Assert.HasCount(2, result);
		Assert.IsTrue(result.Contains("apple"));
		Assert.IsTrue(result.Contains("banana"));
	}

	[TestMethod]
	public void ToFrozenSet_WithComparer_LookupUsesSameComparer()
	{
		// Arrange
		var strings = new List<string> { "apple", "banana" }.AsEnumerable();

		// Act
		var result = strings.ToFrozenSet(StringComparer.OrdinalIgnoreCase);

		// Assert — lookup should be case-insensitive
		Assert.IsTrue(result.Contains("APPLE"));
		Assert.IsTrue(result.Contains("Banana"));
		Assert.IsFalse(result.Contains("cherry"));
	}

	[TestMethod]
	public void ToFrozenSet_WithNullComparer_BehavesSameAsDefault()
	{
		// Arrange
		var strings = new List<string> { "apple", "Apple", "banana" }.AsEnumerable();

		// Act
		var result = strings.ToFrozenSet(null);

		// Assert — null comparer uses default (case-sensitive), so all 3 are distinct
		Assert.IsNotNull(result);
		Assert.HasCount(3, result);
	}

	[TestMethod]
	public void ToFrozenTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsTrue(people.ToFrozenSet().IsNotEmpty());
	}

	[TestMethod]
	public void ToImmutableArrayTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		Assert.IsTrue(people.ToImmutableArray().IsNotEmpty());
	}

	[TestMethod]
	public void ToLinkedListTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsTrue(people.ToLinkedList().IsNotEmpty());
	}

	[TestMethod]
	public async Task ToListAsync_WithCancelledToken_ThrowsTaskCanceledException()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		await Assert.ThrowsExactlyAsync<TaskCanceledException>(
			() => people.ToListAsync(cts.Token)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task ToListAsync_WithICollection_ReturnsCorrectCount()
	{
		ICollection<string> col = new HashSet<string>(RandomData.GenerateWords(Count, 5, 10));

		var result = await col.ToListAsync().ConfigureAwait(false);

		Assert.IsNotNull(result);
		Assert.AreEqual(col.Count, result.Count);
	}

	[TestMethod]
	public async Task ToListAsync_WithList_ReturnsSameList()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		var result = await people.ToListAsync().ConfigureAwait(false);

		Assert.IsNotNull(result);
		Assert.AreEqual(people.Count, result.Count);
	}

	[TestMethod]
	public async Task ToListAsyncTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = await people.ToListAsync().ConfigureAwait(false);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ToReadOnlyCollection_WithArray_WrapsDirectly()
	{
		// Arrange - T[] is IList<T>, so it wraps without copying
		var numbers = new int[] { 1, 2, 3, 4, 5 };

		// Act
		var result = ((IEnumerable<int>)numbers).ToReadOnlyCollection();

		// Assert
		Assert.HasCount(5, result);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(5, result[4]);
	}

	[TestMethod]
	public void ToReadOnlyCollection_WithDeferredEnumerable_MaterializesAndWraps()
	{
		// Arrange - Where query is neither IList<T> nor ICollection<T>
		var numbers = Enumerable.Range(1, 5).Where(_ => true);

		// Act
		var result = numbers.ToReadOnlyCollection();

		// Assert
		Assert.HasCount(5, result);
	}

	[TestMethod]
	public void ToReadOnlyCollection_WithICollection_PreSizesAndCopies()
	{
		// Arrange - Queue<T> is ICollection<T> but not IList<T>
		var source = new Queue<int>(new[] { 10, 20, 30 });

		// Act
		var result = ((IEnumerable<int>)source).ToReadOnlyCollection();

		// Assert
		Assert.HasCount(3, result);
		Assert.IsTrue(result.Contains(20));
	}

	[TestMethod]
	public void ToReadOnlyCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsTrue(people.ToReadOnlyCollection().IsNotEmpty());
	}

	[TestMethod]
	public void ToUniqueCollection_EmptyCollection_ReturnsEmptyCollection()
	{
		// Arrange
		var collection = new List<int>().AsEnumerable();

		// Act
		var result = collection.ToUniqueCollection();

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(0, result);
	}

	[TestMethod]
	public void ToUniqueCollection_WithCaseInsensitiveComparer_CollapsesStrings()
	{
		// Arrange
		var collection = new List<string> { "apple", "Apple", "APPLE", "banana" }.AsEnumerable();

		// Act
		var result = collection.ToUniqueCollection(StringComparer.OrdinalIgnoreCase);

		// Assert — case-insensitive: "apple"/"Apple"/"APPLE" collapse into one
		Assert.IsNotNull(result);
		Assert.HasCount(2, result);
	}

	[TestMethod]
	public void ToUniqueCollection_WithNullComparer_BehavesSameAsDefault()
	{
		// Arrange
		var collection = new List<string> { "apple", "Apple", "banana" }.AsEnumerable();

		// Act
		var result = collection.ToUniqueCollection(null);

		// Assert — null comparer uses default (case-sensitive), all 3 are distinct
		Assert.IsNotNull(result);
		Assert.HasCount(3, result);
	}

	[TestMethod]
	public void Upsert_AddsNewItem()
	{
		var list = new List<int> { 1, 2, 3 }.AsEnumerable();
		list = list.Upsert(4);
		Assert.HasCount(4, list);
	}

	[TestMethod]
	public void Upsert_UpdatesExistingItem()
	{
		var list = new List<int> { 1, 2, 3 }.AsEnumerable();
		list = list.Upsert(2);
		Assert.HasCount(3, list);
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var personFromCollection = people.Shuffle().First();

		var person = RandomData.GeneratePerson<Person>();

		var result = people.Upsert(person);

		Assert.HasCount(people.Count() + 1, result);

		result = result.Upsert(personFromCollection);

		Assert.HasCount(Count + 1, result);
	}

	// Helper method to create IAsyncEnumerable for testing
	private static async IAsyncEnumerable<T> ToAsyncEnumerable<T>(IEnumerable<T> source, [EnumeratorCancellation] CancellationToken cancellationToken = default)
	{
		foreach (var item in source)
		{
			cancellationToken.ThrowIfCancellationRequested();
			await Task.Yield();
			yield return item;
		}
	}

	/// <summary>
	/// Helper comparer for testing modulo-based equality.
	/// </summary>
	private sealed class ModuloEqualityComparer : IEqualityComparer<int>
	{
		private readonly int _modulo;

		public ModuloEqualityComparer(int modulo) => this._modulo = modulo;

		public bool Equals(int x, int y) => x % this._modulo == y % this._modulo;

		public int GetHashCode(int obj) => obj % this._modulo;
	}
}
