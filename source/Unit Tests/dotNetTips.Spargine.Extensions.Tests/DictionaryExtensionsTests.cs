// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2026
// ***********************************************************************
// <copyright file="DictionaryExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DictionaryExtensionsTests
{

	private const int CollectionCount = 256;


	/// <summary>
	/// Defines the test method AddIfNotExistDictionaryTest.
	/// </summary>
	[TestMethod]
	public void AddIfNotExistDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		var newPerson = RandomData.GeneratePerson<Person>();

		// Test parameters
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.AddIfNotExists(null, newPerson));

		// Test
		Assert.IsTrue(people.AddIfNotExists(newPerson.Id, newPerson));

		Assert.IsFalse(people.AddIfNotExists(newPerson.Id, newPerson));
	}

	[TestMethod]
	public void AddIfNotExists_WithExistingKey_DoesNotAddKeyValuePair()
	{
		// Arrange
		var dictionary = new Dictionary<string, int> { { "key1", 42 } };
		var key = "key1";
		var value = 99;

		// Act
		var result = dictionary.AddIfNotExists(key, value);

		// Assert
		Assert.IsFalse(result);
		Assert.AreEqual(42, dictionary[key]); // Ensure the original value is not overwritten
	}

	[TestMethod]
	public void AddIfNotExists_WithNewKey_AddsKeyValuePair()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>();
		var key = "key1";
		var value = 42;

		// Act
		var result = dictionary.AddIfNotExists(key, value);

		// Assert
		Assert.IsTrue(result);
		Assert.IsTrue(dictionary.ContainsKey(key));
		Assert.AreEqual(value, dictionary[key]);
	}

	[TestMethod]
	public void AddIfNotExists_WithNullDictionary_ThrowsArgumentNullException()
	{
		// Arrange
		Dictionary<string, int> dictionary = null;
		var key = "key1";
		var value = 42;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.AddIfNotExists(key, value));
	}

	[TestMethod]
	public void AddIfNotExists_WithNullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>();
		string key = null;
		var value = 42;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.AddIfNotExists(key, value));
	}

	[TestMethod]
	public void AddIfNotExists_WithNullValue_ReturnsFalse()
	{
		// Arrange
		var dictionary = new Dictionary<string, string>();
		var key = "key1";
		string value = null;

		// Act
		var result = dictionary.AddIfNotExists(key, value);

		// Assert
		Assert.IsFalse(result);
		Assert.IsFalse(dictionary.ContainsKey(key));
	}

	[TestMethod]
	public void AddRange_AddsOnlyUniqueKeys()
	{
		var dict = new Dictionary<string, int> { { "a", 1 } };
		var items = new[] { "a", "b" };
		Func<string, string> keyFunc = s => s;
		Func<string, int> valueFunc = s => s.Length;

		var result = dict.AddRange(items, keyFunc, valueFunc);

		Assert.IsTrue(result);
		Assert.HasCount(2, dict);
		Assert.AreEqual(1, dict["a"]);
		Assert.AreEqual(1, dict["b"]);
	}

	[TestMethod]
	public void AddRange_WithNullItems_ReturnsFalse()
	{
		var dict = new Dictionary<string, int>();
		IEnumerable<string> items = null;
		Func<string, string> keyFunc = s => s;
		Func<string, int> valueFunc = s => 1;

		var result = dict.AddRange(items, keyFunc, valueFunc);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AddRange_WithNullValueFunction_ReturnsFalse()
	{
		var dict = new Dictionary<string, int>();
		var items = new[] { "a", "b" };
		Func<string, string> keyFunc = s => s;
		Func<string, int> valueFunc = null;

		var result = dict.AddRange(items, keyFunc, valueFunc);

		Assert.IsFalse(result);
	}

	/// <summary>
	/// Defines the test method AddRangeDictionaryTest01.
	/// </summary>
	[TestMethod]
	public void AddRangeDictionaryTest01()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		var newPeople = RandomData.GeneratePersonRefCollection(2).ToDictionary(p => p.Id);

		var result = people.AddRange(newPeople, true);
		Assert.AreEqual(CollectionCount + 2, people.Count);

		result = people.AddRange(newPeople, true);
		Assert.AreEqual(CollectionCount + 2, people.Count);
	}

	[TestMethod]
	public void DisposeCollection_DisposesAllItems()
	{
		var d1 = new MockDisposable();
		var d2 = new MockDisposable();
		var list = new List<KeyValuePair<object, IDisposable>>
	{
		new KeyValuePair<object, IDisposable>("a", d1),
		new KeyValuePair<object, IDisposable>("b", d2)
	};

		list.DisposeCollection<object, IDisposable>();

		Assert.IsTrue(d1.IsDisposed);
		Assert.IsTrue(d2.IsDisposed);
	}


	/// <summary>
	/// Defines the test method DoesNotHaveItemsTest.
	/// </summary>
	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		Assert.IsFalse(people.IsEmpty());
	}

	/// <summary>
	/// Defines the test method AddRangeDictionaryTest02.
	/// </summary>
	[TestMethod]
	public void FastCountTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		Assert.AreEqual(CollectionCount, people1.Count);

	}

	[TestMethod]
	[TestCategory("Extensions")]
	public void GenerateHashCodeWithComparer_AllNullItems_ReturnsInitialHashValue()
	{
		// Arrange
		var items = new string[] { null, null, null };
		var collection = new System.Collections.ObjectModel.ReadOnlyCollection<string>(items);
		var comparer = EqualityComparer<string>.Default;

		// Act
		var hashCode = collection.GenerateHashCode(comparer);

		// Assert
		Assert.AreEqual(6551, hashCode, "Collection with all null items should return initial hash value");
	}

	[TestMethod]
	[TestCategory("Extensions")]
	public void GenerateHashCodeWithComparer_CollectionWithNullItems_SkipsNullItems()
	{
		// Arrange
		var items = new[] { "Apple", null, "Banana", null, "Cherry" };
		var collection = new System.Collections.ObjectModel.ReadOnlyCollection<string>(items);
		var comparer = EqualityComparer<string>.Default;

		// Act
		var hashCode = collection.GenerateHashCode(comparer);

		// Assert
		Assert.IsTrue(hashCode != 0);
		Assert.IsTrue(hashCode != 6551, "Should compute hash from non-null items");
	}

	[TestMethod]
	[TestCategory("Extensions")]
	public void GenerateHashCodeWithComparer_CustomComparer_ReturnsConsistentHashCode()
	{
		// Arrange
		var items = new[] { "apple", "BANANA", "Cherry" };
		var collection = new System.Collections.ObjectModel.ReadOnlyCollection<string>(items);
		var comparer = StringComparer.OrdinalIgnoreCase;

		// Act
		var hashCode1 = collection.GenerateHashCode(comparer);
		var hashCode2 = collection.GenerateHashCode(comparer);

		// Assert
		Assert.AreEqual(hashCode1, hashCode2, "Hash codes should be consistent for same collection and comparer");
	}

	[TestMethod]
	[TestCategory("Extensions")]
	public void GenerateHashCodeWithComparer_DifferentComparers_ProducesDifferentHashCodes()
	{
		// Arrange
		var items = new[] { "Apple", "apple" };
		var collection = new System.Collections.ObjectModel.ReadOnlyCollection<string>(items);
		var caseSensitiveComparer = StringComparer.Ordinal;
		var caseInsensitiveComparer = StringComparer.OrdinalIgnoreCase;

		// Act
		var hashCode1 = collection.GenerateHashCode(caseSensitiveComparer);
		var hashCode2 = collection.GenerateHashCode(caseInsensitiveComparer);

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2, "Different comparers should produce different hash codes");
	}

	[TestMethod]
	[TestCategory("Extensions")]
	public void GenerateHashCodeWithComparer_EmptyCollection_ReturnsInitialHashValue()
	{
		// Arrange
		var collection = new System.Collections.ObjectModel.ReadOnlyCollection<string>(Array.Empty<string>());
		var comparer = EqualityComparer<string>.Default;

		// Act
		var hashCode = collection.GenerateHashCode(comparer);

		// Assert
		Assert.AreEqual(6551, hashCode, "Empty collection should return initial hash value");
	}

	[TestMethod]
	[TestCategory("Extensions")]
	public void GenerateHashCodeWithComparer_IntegerCollection_ReturnsHashCode()
	{
		// Arrange
		var items = new[] { 1, 2, 3, 4, 5 };
		var collection = new System.Collections.ObjectModel.ReadOnlyCollection<int>(items);
		var comparer = EqualityComparer<int>.Default;

		// Act
		var hashCode = collection.GenerateHashCode(comparer);

		// Assert
		Assert.IsTrue(hashCode != 0);
		Assert.IsTrue(hashCode != 6551);
	}

	[TestMethod]
	[TestCategory("Extensions")]
	public void GenerateHashCodeWithComparer_ValidCollection_ReturnsHashCode()
	{
		// Arrange
		var items = new[] { "Apple", "Banana", "Cherry" };
		var collection = new System.Collections.ObjectModel.ReadOnlyCollection<string>(items);
		var comparer = EqualityComparer<string>.Default;

		// Act
		var hashCode = collection.GenerateHashCode(comparer);

		// Assert
		Assert.IsTrue(hashCode != 0);
	}

	/// <summary>
	/// Defines the test method GetOrAddTest.
	/// </summary>
	[TestMethod]
	public void GetOrAddTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		var newPerson = RandomData.GeneratePerson<Person>();

		// Test Parameters
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.GetOrAdd(null, newPerson));

		// TEST
		_ = people.GetOrAdd(newPerson.Id, newPerson);
		Assert.AreEqual(CollectionCount + 1, people.Count);

		_ = people.GetOrAdd(newPerson.Id, newPerson);
		Assert.AreEqual(CollectionCount + 1, people.Count);
	}

	/// <summary>
	/// Defines the test method HasItemsTest.
	/// </summary>
	[TestMethod]
	public void HasItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		Dictionary<string, Person> nullPeople = null;

		Assert.IsTrue(people.IsNotEmpty());

		Assert.IsFalse(nullPeople.IsNotEmpty());
	}

	/// <summary>
	/// Defines the test method HasItemsTestWithFunction.
	/// </summary>
	[TestMethod]
	public void HasItemsTestWithFunction()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		// Explicitly specify the extension method to resolve ambiguity  
		Func<KeyValuePair<string, Person>, bool> selector = p => p.Value.Email.IsNotNull();

		Assert.IsTrue(DictionaryExtensions.IsNotEmpty(people, selector));
	}

	/// <summary>
	/// Defines the test method HasItemsWithCountTest.
	/// </summary>
	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		Dictionary<string, Person> nullPeople = null;

		Assert.IsTrue(people.IsNotEmpty(CollectionCount));
		Assert.IsFalse(people.IsNotEmpty(100));

		Assert.IsFalse(nullPeople.IsNotEmpty(CollectionCount));
	}

	/// <summary>
	/// Defines the test method ToConcurrentDictionaryTest.
	/// </summary>
	[TestMethod]
	public void ToConcurrentDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToConcurrentDictionary();

		Assert.IsTrue(result.IsNotEmpty());
	}
	/// <summary>
	/// Defines the test method ToDelimitedDictionaryTest.
	/// </summary>
	[TestMethod]
	public void ToDelimitedDictionaryTest()
	{
		var words = RandomData.GenerateWords(CollectionCount, 25, 50);

		var dic = new Dictionary<string, string>(CollectionCount);

		foreach (var item in words)
		{
			dic.Add(item, item);
		}

		Assert.IsNotNull(dic.ToDelimitedString(','));
	}

	[TestMethod]
	public void ToFrozenDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToFrozenDictionary();

		Assert.IsTrue(result.IsNotEmpty());
		Assert.HasCount(people.Count, result);
		foreach (var kvp in people)
		{
			Assert.IsTrue(result.ContainsKey(kvp.Key));
			Assert.AreEqual(kvp.Value, result[kvp.Key]);
		}
	}


	[TestMethod]
	public void ToFrozenDictionaryWithEmptyDictionaryTest()
	{
		var emptyDictionary = new Dictionary<string, Person>();

		var result = emptyDictionary.ToFrozenDictionary();

		Assert.IsFalse(result.IsNotEmpty());
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void ToFrozenDictionaryWithNullDictionaryTest()
	{
		Dictionary<string, Person> nullDictionary = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullDictionary.ToFrozenDictionary());
	}

	[TestMethod]
	public void ToImmutableDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToImmutableDictionary();

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void ToImmutableSortedDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToImmutableSortedDictionary();

		Assert.IsTrue(result.IsNotEmpty());
		Assert.HasCount(people.Count, result);
		foreach (var kvp in people)
		{
			Assert.IsTrue(result.ContainsKey(kvp.Key));
			Assert.AreEqual(kvp.Value, result[kvp.Key]);
		}
	}

	[TestMethod]
	public void ToImmutableSortedDictionaryWithEmptyDictionaryTest()
	{
		var emptyDictionary = new Dictionary<string, Person>();

		var result = emptyDictionary.ToImmutableSortedDictionary();

		Assert.IsFalse(result.IsNotEmpty());
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void ToImmutableSortedDictionaryWithNullDictionaryTest()
	{
		Dictionary<string, Person> nullDictionary = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => nullDictionary.ToImmutableSortedDictionary());
	}

	[TestMethod]
	public void ToLookup_WithExistingKey_ReturnsValue()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		var lookup = dictionary.ToLookupWithDefault(0);

		// Act
		var result = lookup("key1");

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public void ToLookup_WithNonExistingKey_ReturnsDefaultValue()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		var lookup = dictionary.ToLookupWithDefault(0);

		// Act
		var result = lookup("key3");

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void ToLookup_WithNullDictionary_ThrowsArgumentNullException()
	{
		// Arrange
		Dictionary<string, int> dictionary = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.ToLookupWithDefault(0));
	}



	[TestMethod]
	public void ToReadOnlyCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToReadOnlyCollection();

		// Test
		Assert.IsNotNull(result);
		Assert.AreEqual(CollectionCount, result.Count);
	}

	[TestMethod]
	public void ToReadOnlyDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToReadOnlyDictionary();

		// Test
		Assert.IsNotNull(result);
		Assert.AreEqual(CollectionCount, result.Count);
	}

	[TestMethod]
	public void ToSortedDictionary_WithCustomComparer_ReturnsSortedDictionary()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "b", 2 },
		{ "a", 1 },
		{ "c", 3 }
	};
		var comparer = Comparer<string>.Create((x, y) => string.Compare(y, x, StringComparison.Ordinal));

		// Act
		var result = dictionary.ToSortedDictionary(comparer);

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(3, result);
		CollectionAssert.AreEqual(new[] { "c", "b", "a" }, result.Keys.ToArray());
	}

	[TestMethod]
	public void ToSortedDictionary_WithDefaultComparer_ReturnsSortedDictionary()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "b", 2 },
		{ "a", 1 },
		{ "c", 3 }
	};
		var comparer = Comparer<string>.Default;

		// Act
		var result = dictionary.ToSortedDictionary(comparer);

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(3, result);
		CollectionAssert.AreEqual(new[] { "a", "b", "c" }, result.Keys.ToArray());
	}

	[TestMethod]
	public void ToSortedDictionary_WithEmptyDictionary_ReturnsEmptySortedDictionary()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>();
		var comparer = Comparer<string>.Default;

		// Act
		var result = dictionary.ToSortedDictionary(comparer);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void ToSortedDictionary_WithNullComparer_ThrowsArgumentNullException()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "b", 2 },
		{ "a", 1 },
		{ "c", 3 }
	};
		IComparer<string> comparer = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.ToSortedDictionary(comparer));
	}

	[TestMethod]
	public void ToSortedDictionary_WithNullDictionary_ThrowsArgumentNullException()
	{
		// Arrange
		Dictionary<string, int> dictionary = null;
		var comparer = Comparer<string>.Default;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.ToSortedDictionary(comparer));
	}

	/// <summary>
	/// Defines the test method ToSortedDictionaryTest.
	/// </summary>
	[TestMethod]
	public void ToSortedDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);

		var result = people.ToSortedDictionary();

		Assert.IsTrue(result.IsNotEmpty());
	}


	[TestMethod]
	public void TryGetKey_WithExistingKey_ReturnsValue()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		Func<string, int> func = key => 0;

		// Act
		var result = dictionary.TryGetValue("key1", func);

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public void TryGetKey_WithNonExistingKey_AddsAndReturnsValue()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		Func<string, int> func = key => 3;

		// Act
		var result = dictionary.TryGetValue("key3", func);

		// Assert
		Assert.AreEqual(3, result);
		Assert.IsTrue(dictionary.ContainsKey("key3"));
		Assert.AreEqual(3, dictionary["key3"]);
	}

	[TestMethod]
	public void TryGetKey_WithNullDictionary_ThrowsArgumentNullException()
	{
		// Arrange
		Dictionary<string, int> dictionary = null;
		Func<string, int> func = key => 0;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.TryGetValue("key1", func));
	}

	[TestMethod]
	public void TryGetKey_WithNullFunc_ThrowsArgumentNullException()
	{
		// Arrange
		var dictionary = new Dictionary<string, int>
	{
		{ "key1", 1 },
		{ "key2", 2 }
	};
		Func<string, int> func = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => dictionary.TryGetValue("key3", func));
	}

	/// <summary>
	/// Defines the test method UpsertDictionaryTest.
	/// </summary>
	[TestMethod]
	public void UpsertDictionaryTest()
	{
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		var newPerson = RandomData.GeneratePerson<Person>();
		var personFromCollection = people.Shuffle().First();

		// Test Parameters
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => people.Upsert(null, newPerson));

		// Test
		people.Upsert(newPerson.Id, newPerson);
		Assert.AreEqual(CollectionCount + 1, people.Count);

		people.Upsert(personFromCollection.Value.Id, personFromCollection.Value);
		Assert.AreEqual(CollectionCount + 1, people.Count);

		people.Upsert(personFromCollection.Value.Id, null);
		Assert.AreEqual(CollectionCount + 1, people.Count);
	}

	[TestMethod]
	public void UpsertWithIDataModel_EmptyDictionary_AddsItem()
	{
		// Arrange
		var dictionary = new Dictionary<string, Person>();
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		dictionary.Upsert(newPerson);

		// Assert
		Assert.HasCount(1, dictionary);
		Assert.IsTrue(dictionary.ContainsKey(newPerson.Id));
	}

	[TestMethod]
	public void UpsertWithIDataModel_ExistingItem_UpdatesValue()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		var existingPerson = people.Values.First();
		var existingId = existingPerson.Id;

		// Create updated person with same ID
		var updatedPerson = new Person(email: "updated@test.com", id: existingId)
		{
			FirstName = "UpdatedFirstName",
			LastName = "UpdatedLastName",
			CellPhone = "9999999999"
		};

		// Act
		people.Upsert(updatedPerson);

		// Assert
		Assert.AreEqual(CollectionCount, people.Count);
		Assert.AreEqual("updated@test.com", people[existingId].Email);
		Assert.AreEqual("UpdatedFirstName", people[existingId].FirstName);
	}

	[TestMethod]
	public void UpsertWithIDataModel_LargeCollection_PerformsCorrectly()
	{
		// Arrange
		var largeCount = 1000;
		var people = RandomData.GeneratePersonRefCollection(largeCount).ToDictionary(p => p.Id);
		var existingPerson = people.Values.Skip(largeCount / 2).First();
		var existingId = existingPerson.Id;

		var updatedPerson = new Person(email: "large@test.com", id: existingId)
		{
			FirstName = "LargeTestUpdate"
		};

		// Act
		people.Upsert(updatedPerson);

		// Assert
		Assert.AreEqual(largeCount, people.Count);
		Assert.AreEqual("large@test.com", people[existingId].Email);
	}

	[TestMethod]
	public void UpsertWithIDataModel_MultipleUpserts_MaintainsCorrectCount()
	{
		// Arrange
		var dictionary = new Dictionary<string, Person>();
		var person1 = RandomData.GeneratePerson<Person>();
		var person2 = RandomData.GeneratePerson<Person>();

		// Act - Add first item
		dictionary.Upsert(person1);
		Assert.HasCount(1, dictionary);

		// Act - Add second item
		dictionary.Upsert(person2);
		Assert.HasCount(2, dictionary);

		// Act - Update first item (same ID)
		var updatedPerson1 = new Person(email: "updated@test.com", id: person1.Id);
		dictionary.Upsert(updatedPerson1);

		// Assert - Count should still be 2
		Assert.HasCount(2, dictionary);
		Assert.AreEqual("updated@test.com", dictionary[person1.Id].Email);
	}

	[TestMethod]
	public void UpsertWithIDataModel_NewItem_AddsToCollection()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		people.Upsert(newPerson);

		// Assert
		Assert.AreEqual(CollectionCount + 1, people.Count);
		Assert.IsTrue(people.ContainsKey(newPerson.Id));
		Assert.AreEqual(newPerson, people[newPerson.Id]);
	}

	[TestMethod]
	public void UpsertWithIDataModel_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IDictionary<string, Person> dictionary = null;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DictionaryExtensions.Upsert<string, Person>(dictionary, person));
	}

	[TestMethod]
	public void UpsertWithIDataModel_NullItem_DoesNotModifyCollection()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(CollectionCount).ToDictionary(p => p.Id);
		var originalCount = people.Count;
		Person nullPerson = null;

		// Act
		people.Upsert(nullPerson);

		// Assert
		Assert.AreEqual(originalCount, people.Count);
	}

	[TestMethod]
	public void UpsertWithIDataModel_UsesIdAsKey()
	{
		// Arrange
		var dictionary = new Dictionary<string, Person>();
		var person = RandomData.GeneratePerson<Person>();
		var expectedKey = person.Id;

		// Act
		dictionary.Upsert(person);

		// Assert - Verify the Id property is used as the dictionary key
		Assert.IsTrue(dictionary.ContainsKey(expectedKey));
		Assert.AreSame(person, dictionary[expectedKey]);
	}
}

[ExcludeFromCodeCoverage]
public class MockDisposable : IDisposable
{

	public bool IsDisposed { get; private set; }

	public void Dispose()
	{
		this.IsDisposed = true;
	}
}
