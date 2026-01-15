// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-13-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
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
	public void IndexOf_WithComparer_ThrowsArgumentNullException_WhenComparerIsNull()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).AsEnumerable();
		var person = RandomData.GeneratePerson<Person>();
		IEqualityComparer<Person> nullComparer = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.IndexOf(person, nullComparer));
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
}
