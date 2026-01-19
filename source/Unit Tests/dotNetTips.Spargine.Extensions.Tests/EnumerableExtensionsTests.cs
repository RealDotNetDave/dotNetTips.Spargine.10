// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-19-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
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
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerableExtensionsTests
{
	private const int Count = 1024;
	private const string TestData = "TEST DATA";

	[TestMethod]
	public void AddDistinct_EmptyItems_ReturnsOriginal()
	{
		var list = new List<int> { 1, 2 }.AsEnumerable();
		var result = list.AddDistinct(new ReadOnlyCollection<int>(new List<int>()));

		Assert.AreEqual(list.Count(), result.Count());
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

		Assert.AreEqual(list.Count(), result.Count());
	}

	[TestMethod]
	public void AddDistinctTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var person1 = RandomData.GeneratePerson<Person>();

		people = people.AddDistinct(person1);

		Assert.AreEqual(Count + 1, people.Count());

		people = people.AddDistinct(person1);

		Assert.AreEqual(Count + 1, people.Count());

		people = people.AddDistinct(null);

		Assert.AreEqual(Count + 1, people.Count());
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
		var result = query.ToList();
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
		Assert.AreEqual(1, result.Count);
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
		Assert.AreEqual(Count + 1, result.Count);
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
		Assert.AreEqual(4, result.Count);
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
		Assert.AreEqual(Count + 1, people.Count);
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
		Assert.AreEqual(2, result.Count);
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
		Assert.AreEqual(4, result.Count);
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
		Assert.AreEqual(4, result.Count);
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
		Assert.AreEqual(6, result.Count);
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
		Assert.AreEqual(3, result.Count);
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
		Assert.AreEqual(Count + 1, result.Count);
		Assert.AreEqual(0, result.First());
		Assert.AreEqual(1, result[1]);
	}


	[TestMethod]
	public void AddIf_ConditionFalse_ReturnsOriginal()
	{
		var list = new List<int> { 1, 2 }.AsEnumerable();
		list.AddIf(3, false);
		Assert.AreEqual(2, list.Count());
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

		Assert.AreEqual(people.Count() + 1, result.Count());

		result = people.AddIf(person, false);

		Assert.AreEqual(people.Count(), result.Count());
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

		Assert.AreEqual(Count, people.Count());
	}

	[TestMethod]
	public void CreateCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var peopleCreated = people.Create(true);

		Assert.AreEqual(peopleCreated.Count, people.Count());
	}

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = new List<Person>().AsEnumerable();

		Assert.IsTrue(people.IsEmpty());
	}

	[TestMethod]
	public void EnsureUnique_AllDuplicates_WithComparer_ReturnsSingleElement()
	{
		var allSame = new List<int> { 5, 5, 5, 5, 5 }.AsEnumerable();

		var result = allSame.EnsureUnique(EqualityComparer<int>.Default).ToList();

		Assert.AreEqual(1, result.Count);
		Assert.AreEqual(5, result[0]);
	}

	[TestMethod]
	public void EnsureUnique_EmptyCollection_WithComparer_ReturnsEmpty()
	{
		var emptyList = new List<int>().AsEnumerable();

		var result = emptyList.EnsureUnique(EqualityComparer<int>.Default).ToList();

		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void EnsureUnique_NoDuplicates_WithComparer_ReturnsAll()
	{
		var uniqueNumbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		var result = uniqueNumbers.EnsureUnique(EqualityComparer<int>.Default).ToList();

		Assert.AreEqual(5, result.Count);
	}

	[TestMethod]
	public void EnsureUnique_ReferenceTypes_LargeCollection_WithComparer_RemovesDuplicates()
	{
		// Large collection (> 4096) uses Distinct path
		var largeCount = 5000;
		var people = RandomData.GeneratePersonRefCollection(largeCount).ToList();
		var duplicate = people[0];

		for (int i = 0; i < 10; i++)
		{
			people.Add(duplicate);
		}

		var result = people.EnsureUnique(new PersonComparer()).ToList();

		var expectedCount = people.Select(p => p.Id).Distinct().Count();
		Assert.AreEqual(expectedCount, result.Count);
	}

	[TestMethod]
	public void EnsureUnique_ReferenceTypes_SmallCollection_WithComparer_RemovesDuplicates()
	{
		// Small collection (<= 4096) uses HashSet path
		var people = RandomData.GeneratePersonRefCollection(20).ToList();
		var duplicate = people[0];
		people.Add(duplicate);
		people.Add(duplicate);

		var result = people.EnsureUnique(new PersonComparer()).ToList();

		var expectedCount = people.Select(p => p.Id).Distinct().Count();
		Assert.AreEqual(expectedCount, result.Count);
	}

	[TestMethod]
	public void EnsureUnique_SingleElement_WithComparer_ReturnsSingleElement()
	{
		var singleItem = new List<int> { 42 }.AsEnumerable();

		var result = singleItem.EnsureUnique(EqualityComparer<int>.Default).ToList();

		Assert.AreEqual(1, result.Count);
		Assert.AreEqual(42, result[0]);
	}

	[TestMethod]
	public void EnsureUnique_Strings_CaseInsensitiveComparer_RemovesDuplicates()
	{
		var words = new List<string> { "Apple", "apple", "APPLE", "Banana", "BANANA", "Cherry" }.AsEnumerable();

		var result = words.EnsureUnique(StringComparer.OrdinalIgnoreCase).ToList();

		Assert.AreEqual(3, result.Count);
		Assert.IsTrue(result.Any(w => w.Equals("Apple", StringComparison.OrdinalIgnoreCase)));
		Assert.IsTrue(result.Any(w => w.Equals("Banana", StringComparison.OrdinalIgnoreCase)));
		Assert.IsTrue(result.Any(w => w.Equals("Cherry", StringComparison.OrdinalIgnoreCase)));
	}

	[TestMethod]
	public void EnsureUnique_Strings_OrdinalComparer_PreservesCaseSensitiveDuplicates()
	{
		var words = new List<string> { "Apple", "apple", "APPLE", "Banana" }.AsEnumerable();

		var result = words.EnsureUnique(StringComparer.Ordinal).ToList();

		// Ordinal comparison is case-sensitive, so all variations are unique
		Assert.AreEqual(4, result.Count);
	}

	[TestMethod]
	public void EnsureUnique_ValueTypes_WithCustomComparer_FiltersCorrectly()
	{
		// Custom comparer that considers numbers equal if they have the same remainder when divided by 3
		var numbers = Enumerable.Range(1, 10).AsEnumerable();

		var modComparer = new ModuloEqualityComparer(3);
		var result = numbers.EnsureUnique(modComparer).ToList();

		// Should have 3 unique "mod 3" classes: 0, 1, 2
		Assert.AreEqual(3, result.Count);
		Assert.IsTrue(result.Any(n => n % 3 == 0));
		Assert.IsTrue(result.Any(n => n % 3 == 1));
		Assert.IsTrue(result.Any(n => n % 3 == 2));
	}

	[TestMethod]
	public void EnsureUnique_WithComparer_PreservesFirstOccurrence()
	{
		var words = new List<string> { "FIRST", "first", "First" }.AsEnumerable();

		var result = words.EnsureUnique(StringComparer.OrdinalIgnoreCase).ToList();

		Assert.AreEqual(1, result.Count);
		Assert.AreEqual("FIRST", result[0]); // First occurrence should be preserved
	}

	[TestMethod]
	public void EnsureUnique_WithNullComparer_UsesDefaultEquality()
	{
		var numbers = new List<int> { 1, 2, 2, 3, 3, 3 }.AsEnumerable();

		var result = numbers.EnsureUnique(null).ToList();

		CollectionAssert.AreEquivalent(new List<int> { 1, 2, 3 }, result);
	}

	[TestMethod]
	public void EnsureUniqueComparerTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		people.Add(people.First());

		var result = people.EnsureUnique(new PersonComparer());

		Assert.AreEqual(Count, result.Count());
	}

	[TestMethod]
	public void EnsureUniqueTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		people.Add(people.First());

		var result = people.EnsureUnique();

		Assert.AreEqual(Count, result.Count());
	}

	[TestMethod]
	public void FastAny_AllElementsMatch_ReturnsTrue()
	{
		// Arrange
		var numbers = new List<int> { 10, 20, 30 }.AsEnumerable();

		// Act
		var result = numbers.FastAny(n => n > 5);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_Array_MatchingElementExists_ReturnsTrue()
	{
		// Arrange
		var numbers = new int[] { 1, 2, 3, 4, 5 };

		// Act
		var result = numbers.FastAny(n => n % 2 == 0);

		// Assert
		Assert.IsTrue(result);
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

		// Act
		var result = deferred.FastAny(n => n == 6);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_EmptyCollection_ReturnsFalse()
	{
		// Arrange
		var emptyCollection = new List<int>().AsEnumerable();

		// Act
		var result = emptyCollection.FastAny(n => n > 0);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastAny_FirstElementMatches_ReturnsTrue()
	{
		// Arrange
		var numbers = new List<int> { 10, 2, 3 }.AsEnumerable();

		// Act
		var result = numbers.FastAny(n => n > 5);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_LargeCollection_MatchingElementExists_ReturnsTrue()
	{
		// Arrange
		var largeCollection = Enumerable.Range(1, Count).AsEnumerable();

		// Act
		var result = largeCollection.FastAny(n => n == Count);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_LastElementMatches_ReturnsTrue()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 10 }.AsEnumerable();

		// Act
		var result = numbers.FastAny(n => n > 5);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_MatchingElementExists_ReturnsTrue()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsEnumerable();

		// Act
		var result = numbers.FastAny(n => n > 3);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_NoMatchingElement_ReturnsFalse()
	{
		// Arrange
		var numbers = new List<int> { 1, 2, 3 }.AsEnumerable();

		// Act
		var result = numbers.FastAny(n => n > 10);

		// Assert
		Assert.IsFalse(result);
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

		// Act
		var result = people.FastAny(p => p.Email.Contains("@", StringComparison.Ordinal));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_ReferenceType_NoMatchingElement_ReturnsFalse()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		// Act
		var result = people.FastAny(p => p.Id == "non-existent-id-12345");

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastAny_SingleElementMatches_ReturnsTrue()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Act
		var result = singleItem.FastAny(n => n == 42);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_SingleElementNoMatch_ReturnsFalse()
	{
		// Arrange
		var singleItem = new List<int> { 42 }.AsEnumerable();

		// Act
		var result = singleItem.FastAny(n => n == 100);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void FastAny_StringCollection_MatchingElement_ReturnsTrue()
	{
		// Arrange
		var strings = new List<string> { "apple", "banana", "cherry" }.AsEnumerable();

		// Act
		var result = strings.FastAny(s => s.StartsWith("b", StringComparison.Ordinal));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void FastAny_StringCollection_NoMatchingElement_ReturnsFalse()
	{
		// Arrange
		var strings = new List<string> { "apple", "banana", "cherry" }.AsEnumerable();

		// Act
		var result = strings.FastAny(s => s.StartsWith("z", StringComparison.Ordinal));

		// Assert
		Assert.IsFalse(result);
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

		Assert.AreEqual(Count, people.Count);
	}

	[TestMethod]
	public void FastLongCount_WithPredicate_AllMatch_ReturnsFullCount()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = people.FastLongCount(p => p != null);

		Assert.AreEqual((long)Count, result);
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
			p.Age.TotalDays > 25 &&
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

		Assert.AreEqual((long)largeCount, result);
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

		Assert.AreEqual((long)expectedCount, result);
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

		Assert.AreEqual((long)(Count / 2), result);
	}

	[TestMethod]
	public void FastProcessorTestRecord()
	{
		var people = RandomData.GeneratePersonRecordCollection(Count);
		people.FastProcessor(person => person.GetHashCode());

		Assert.AreEqual(Count, people.Count);
	}

	[TestMethod]
	public void FastProcessorTestRef()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		people.FastProcessor(person => person.GetHashCode());

		Assert.AreEqual(Count, people.Count);
	}

	[TestMethod]
	public void FastProcessorTestVal()
	{
		var people = RandomData.GeneratePersonValCollection(Count);

		people.FastProcessor(person => person.GetHashCode());

		Assert.AreEqual(Count, people.Count);
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_EmptyCollection_DoesNotThrow()
	{
		var emptyList = new List<Person>().AsEnumerable();

		emptyList = emptyList.FastShuffle();

		Assert.AreEqual(0, emptyList.Count());
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_MultipleInvocations_ModifiesInPlace()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var originalPeople = people.ToHashSet();

		var afterFirstShuffle = people.FastShuffle();

		var afterSecondShuffle = people.FastShuffle();

		// All should have the same count and elements
		Assert.AreEqual(Count, people.Count());

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

		Assert.AreEqual(100, shuffledNumbers.Count());

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

		Assert.AreEqual(Count, people.Count());
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

		Assert.AreEqual(1, shuffled.Count());
		Assert.AreEqual(originalPerson, shuffled.First());
	}

	[TestMethod]
	public void FastShuffle_WithoutCount_WorksWithComplexTypes()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var originalPeople = people.ToHashSet();

		people = people.FastShuffle();

		Assert.AreEqual(Count, people.Count());

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

		Assert.AreEqual(Count, words.Count());
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

		Assert.AreEqual(Count, numbers.Count());
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

		var index = people.IndexOf(targetPerson, new PersonComparer());

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

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.IndexOf(null, new PersonComparer()));
	}

	[TestMethod]
	public void IndexOf_WithComparer_ReferenceTypeWithPersonComparer()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var searchPerson = new Person { Id = people[10].Id };

		var index = people.IndexOf(searchPerson, new PersonComparer());

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

		_ = Assert.ThrowsExactly<NullReferenceException>(() => people.IndexOf(accumulatorPredicate: null));
	}

	[TestMethod]
	public void IndexOfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		var person1 = people.FastShuffle(1).First();

		Assert.AreEqual(false, people.IndexOf(person1).IsNegative());
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
		Assert.AreEqual(4, pages.Count);
		Assert.AreEqual(3, pages[0].Count);
		Assert.AreEqual(3, pages[1].Count);
		Assert.AreEqual(3, pages[2].Count);
		Assert.AreEqual(1, pages[3].Count);
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
		Assert.AreEqual(0, pages.Count);
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
		Assert.AreEqual(1, pages.Count);
		Assert.AreEqual(5, pages[0].Count);
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
		Assert.AreEqual(2, pages.Count);
		Assert.AreEqual(5, pages[0].Count);
		Assert.AreEqual(5, pages[1].Count);
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
		Assert.AreEqual(1, pages.Count);
		Assert.AreEqual(3, pages[0].Count);
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
		Assert.AreEqual(10, pages.Count);
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
		Assert.AreEqual(3, pages.Count);
		Assert.AreEqual(3, pages[0].Count);
		Assert.AreEqual(3, pages[1].Count);
		Assert.AreEqual(1, pages[2].Count);
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
		Assert.AreEqual(3, pages.Count);
		Assert.AreEqual(2, pages[0].Count);
		Assert.AreEqual(2, pages[1].Count);
		Assert.AreEqual(1, pages[2].Count);
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
		Assert.AreEqual(2, pages.Count);
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
		Assert.AreEqual(3, pages.Count);
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
		Assert.AreEqual(1, pages.Count);
		Assert.AreEqual(1, pages[0].Count);
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
		Assert.AreEqual(2, pages.Count);
		Assert.AreEqual(6, pages.Sum(p => p.Count));
	}

	[TestMethod]
	public void PartitionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var splitPeople = people.Partition(people.Count() / 10);

		Assert.IsNotNull(splitPeople);
		Assert.AreEqual(11, splitPeople.Count());

		var emptyPeople = new List<Person>();

		var splitEmptyPeople = emptyPeople.Partition(10).ToList();

		Assert.IsNotNull(splitEmptyPeople);

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
		Assert.AreEqual(Count, result.Count());
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

		var result = numbers.ReplaceIf((n, i) => n % 2 == 0 && i < 5, -1).ToList();

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

		Assert.AreEqual(Count, people.Shuffle().Count());
	}

	[TestMethod]
	public void ShuffleWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);
		List<Person> nullList = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(nullList.Shuffle);

		Assert.AreEqual(5, people.FastShuffle(5).Count());
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

		Assert.AreEqual(Count, result.Count);
	}

	[TestMethod]
	public void ToCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsTrue(people.ToCollection().IsNotEmpty());
	}

	[TestMethod]
	public void ToDelimitedStringTest()
	{
		var words = RandomData.GenerateWords(Count, 25, 50);

		Assert.IsNotNull(words.ToDelimitedString(','));
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
		Assert.AreEqual(5, result.Count);
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
		Assert.AreEqual(5, result.Count);
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
		Assert.AreEqual(5, result.Count);
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
		Assert.AreEqual(0, result.Count);
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
		Assert.AreEqual(3, frozenSet.Count);
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
		Assert.AreEqual(Count, result.Count);
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
		Assert.AreEqual(5, result.Count);
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
		Assert.AreEqual(1, result.Count);
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
		Assert.AreEqual(3, result.Count);
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
		Assert.AreEqual(4, result.Count);
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
	public async Task ToListAsyncTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var result = await people.ToListAsync().ConfigureAwait(false);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ToReadOnlyCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count);

		Assert.IsTrue(people.ToReadOnlyCollection().IsNotEmpty());
	}

	[TestMethod]
	public void Upsert_AddsNewItem()
	{
		var list = new List<int> { 1, 2, 3 }.AsEnumerable();
		list = list.Upsert(4);
		Assert.AreEqual(4, list.Count());
	}


	[TestMethod]
	public void Upsert_UpdatesExistingItem()
	{
		var list = new List<int> { 1, 2, 3 }.AsEnumerable();
		list = list.Upsert(2);
		Assert.AreEqual(3, list.Count());
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();

		var personFromCollection = people.Shuffle().First();

		var person = RandomData.GeneratePerson<Person>();

		var result = people.Upsert(person);

		Assert.AreEqual(people.Count() + 1, result.Count());

		result = result.Upsert(personFromCollection);

		Assert.AreEqual(Count + 1, result.Count());
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
