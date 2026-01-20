// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2026
// ***********************************************************************
// <copyright file="CollectionExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
public class CollectionExtensionsTests
{

	private const int Count = 10;

	[TestMethod]
	public void AddIfNotExistsSingleItemTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		Person nullPerson = null;

		// TEST
		Assert.IsFalse(people.AddIfNotExists(nullPerson));

		var testPerson = RandomData.GeneratePerson<Person>();

		Assert.IsTrue(people.AddIfNotExists(testPerson));

		Assert.IsFalse(people.AddIfNotExists(testPerson));
	}
	[TestMethod]
	public void AddIfNotExistsWithComparerTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		Person nullPerson = null;
		var comparer = EqualityComparer<Person>.Default;

		// Null item
		Assert.IsFalse(people.AddIfNotExists(nullPerson, comparer));

		// Add new item
		var testPerson = RandomData.GeneratePerson<Person>();
		Assert.IsTrue(people.AddIfNotExists(testPerson, comparer));

		// Add duplicate
		Assert.IsFalse(people.AddIfNotExists(testPerson, comparer));
	}

	[TestMethod]
	public void AddIfNullTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		Person nullPerson = null;

		// TEST
		people.AddIf(nullPerson, people.Count == Count);

		Assert.AreEqual(10, people.Count);
	}

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var person = RandomData.GeneratePerson<Person>();

		// TEST
		people.AddIf(person, people.Count == Count);

		Assert.AreEqual(11, people.Count);
	}

	[TestMethod]
	public void AddRangeEnsureUniqueFalseTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var peopleToAdd = RandomData.GeneratePersonRefCollection(Count).ToList();

		// Add with ensureUnique = false (should add all, even duplicates)
		Assert.IsTrue(people.AddRange(peopleToAdd, ensureUnique: false));
		Assert.HasCount(Count * 2, people);
	}

	[TestMethod]
	public void AddRangeTest()
	{
		var people = RandomData.GeneratePersonRefCollection(500).ToList();
		var peopleToAdd = RandomData.GeneratePersonRefCollection(5000).ToList();

		people.AddRange(peopleToAdd);

		Assert.IsNotNull(people);

		Assert.AreEqual(5500, people.Count);
	}

	[TestMethod]
	public void AsReadOnlySpanTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var collection = new Collection<Person>(people);

		// Null argument
		Assert.ThrowsExactly<ArgumentNullException>(() => CollectionExtensions.AsReadOnlySpan<Person>(null));

		// Valid
		var span = collection.AsReadOnlySpan();
		Assert.AreEqual(collection.Count, span.Length);
		Assert.IsTrue(span.SequenceEqual(collection.AsReadOnlySpan()));
	}

	[TestMethod]
	public void AsSpanTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var collection = new Collection<Person>(people);

		var span = collection.AsSpan();
		Assert.AreEqual(collection.Count, span.Length);
		Assert.IsTrue(span.SequenceEqual(collection.AsReadOnlySpan()));
	}


	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var emptyPeople = new List<Person>();

		Assert.IsFalse(people.IsEmpty());

		Assert.IsTrue(emptyPeople.IsEmpty());
	}

	[TestMethod]
	public void ToFrozenSetTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var collection = new Collection<Person>(people);

		var frozenSet = collection.ToFrozenSet();
		Assert.HasCount(collection.Count, frozenSet);
		foreach (var person in collection)
		{
			Assert.Contains(person, frozenSet);
		}
	}

	[TestMethod]
	public void UpsertNullTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		people = people.FastShuffle();
		var personFromCollection = people.First();
		Person nullPerson = null;

		// TEST
		people.Upsert(nullPerson);

		Assert.AreEqual(10, people.Count);
	}


	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		people = people.FastShuffle();
		var personFromCollection = people.First();
		var person = RandomData.GeneratePerson<Person>();
		var personRecords = RandomData.GeneratePersonRecordCollection(Count).ToList();
		var personRecord = RandomData.GeneratePerson<PersonRecord>();

		// TEST
		people.Upsert(person);

		Assert.AreEqual(11, people.Count);

		personRecords.Upsert(personRecord);

		Assert.AreEqual(11, personRecords.Count);
	}

	[TestMethod]
	public void UpsertWithDataModelKey_EmptyCollection_ShouldAddItem()
	{
		// Arrange
		var people = new List<Person>();
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		CollectionExtensions.Upsert<Person, string>(people, newPerson);

		// Assert
		Assert.HasCount(1, people);
		Assert.AreEqual(newPerson.Id, people.First().Id);
	}

	[TestMethod]
	public void UpsertWithDataModelKey_ExistingId_ShouldReplaceItem()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var existingPerson = people.First();
		var existingId = existingPerson.Id;

		// Create a new person with the same ID but different data
		var updatedPerson = new Person(email: "updated@test.com", id: existingId)
		{
			FirstName = "UpdatedFirstName",
			LastName = "UpdatedLastName",
			CellPhone = "9999999999"
		};

		// Act
		CollectionExtensions.Upsert<Person, string>(people, updatedPerson);

		// Assert
		Assert.HasCount(Count, people);
		var foundPerson = people.FirstOrDefault(p => p.Id.Equals(existingId));
		Assert.IsNotNull(foundPerson);
		Assert.AreEqual("updated@test.com", foundPerson.Email);
		Assert.AreEqual("UpdatedFirstName", foundPerson.FirstName);
	}

	[TestMethod]
	public void UpsertWithDataModelKey_LargeCollection_ShouldPerformCorrectly()
	{
		// Arrange
		var largeCount = 1000;
		var people = RandomData.GeneratePersonRefCollection(largeCount).ToList();
		var existingPerson = people[largeCount / 2];
		var existingId = existingPerson.Id;

		var updatedPerson = new Person(email: "large@test.com", id: existingId)
		{
			FirstName = "LargeTestUpdate"
		};

		// Act
		CollectionExtensions.Upsert<Person, string>(people, updatedPerson);

		// Assert
		Assert.HasCount(largeCount, people);
		var foundPerson = people.FirstOrDefault(p => p.Id.Equals(existingId));
		Assert.IsNotNull(foundPerson);
		Assert.AreEqual("large@test.com", foundPerson.Email);
	}

	[TestMethod]
	public void UpsertWithDataModelKey_MultipleUpsertsSameId_ShouldMaintainSingleItem()
	{
		// Arrange
		var people = new List<Person>();
		var person = RandomData.GeneratePerson<Person>();
		var personId = person.Id;

		// Act - Upsert the same item multiple times
		CollectionExtensions.Upsert<Person, string>(people, person);
		CollectionExtensions.Upsert<Person, string>(people, person);
		CollectionExtensions.Upsert<Person, string>(people, person);

		// Assert - Should only have one item
		Assert.HasCount(1, people);
		Assert.IsTrue(people.All(p => p.Id.Equals(personId)));
	}

	[TestMethod]
	public void UpsertWithDataModelKey_NewItem_ShouldAddToCollection()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		CollectionExtensions.Upsert<Person, string>(people, newPerson);

		// Assert
		Assert.HasCount(Count + 1, people);
		Assert.IsTrue(people.Any(p => p.Id.Equals(newPerson.Id)));
	}

	[TestMethod]
	public void UpsertWithDataModelKey_NullCollection_ShouldThrowArgumentNullException()
	{
		// Arrange
		ICollection<Person> nullCollection = null;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => CollectionExtensions.Upsert<Person, string>(nullCollection, person));
	}

	[TestMethod]
	public void UpsertWithDataModelKey_NullItem_ShouldNotModifyCollection()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		var originalCount = people.Count;
		Person nullPerson = null;

		// Act
		CollectionExtensions.Upsert<Person, string>(people, nullPerson);

		// Assert
		Assert.AreEqual(originalCount, people.Count);
	}

	[TestMethod]
	public void UpsertWithDataModelKey_ReadOnlyCollection_ShouldThrowArgumentReadOnlyException()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();
		ICollection<Person> readOnlyCollection = new ReadOnlyCollection<Person>(people);
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentReadOnlyException>(() => CollectionExtensions.Upsert<Person, string>(readOnlyCollection, newPerson));
	}

	[TestMethod]
	public void UpsertWithIDataModel_DuplicateIdWithDifferentData_ShouldUpdateExisting()
	{
		// Arrange
		var models = new List<Person>();
		for (int i = 0; i < Count; i++)
		{
			models.Add(RandomData.GeneratePerson<Person>());
		}
		var originalPerson = models.FastShuffle(1).First();
		var originalPhone = originalPerson.Phone;

		// Create person with same Id but different phone
		var updatedPerson = RandomData.GeneratePerson<Person>();
		updatedPerson.CellPhone = "5555555555";

		Assert.AreNotEqual(originalPhone, updatedPerson.Phone);

		// Act
		models.Upsert(updatedPerson);
		models.Upsert(updatedPerson);

		// Assert
		Assert.HasCount(Count + 1, models);
		var foundPerson = models.FirstOrDefault(p => p.Id.Equals(originalPerson.Id));
		Assert.IsNotNull(foundPerson);
	}

	[TestMethod]
	public void UpsertWithIDataModel_EmptyCollection_ShouldAddItem()
	{
		// Arrange
		var models = new List<Person>();
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		models.Upsert(newPerson);

		// Assert
		Assert.HasCount(1, models);
		Assert.AreEqual(newPerson.Id, models.First().Id);
	}

	[TestMethod]
	public void UpsertWithIDataModel_ExistingItem_ShouldReplaceWithoutIncreasingCount()
	{
		// Arrange
		var models = new List<Person>();

		for (int i = 0; i < Count; i++)
		{
			models.Add(RandomData.GeneratePerson<Person>());
		}
		var existingPerson = models.FastShuffle(1).First();

		// Create updated version with same Id but different data
		var updatedPerson = RandomData.GeneratePerson<Person>();
		updatedPerson.CellPhone = "5555555555";


		// Act
		models.Upsert(updatedPerson);
		models.Upsert(updatedPerson);

		// Assert
		Assert.HasCount(Count + 1, models);

		var foundPerson = models.FirstOrDefault(p => p.Id.Equals(updatedPerson.Id));

		Assert.IsNotNull(foundPerson);
		Assert.AreEqual(updatedPerson.Phone, foundPerson.Phone);
	}

	[TestMethod]
	public void UpsertWithIDataModel_LargeCollection_ShouldPerformCorrectly()
	{
		// Arrange
		var largeCount = 1000;
		var models = new List<Person>();
		for (int i = 0; i < largeCount; i++)
		{
			models.Add(RandomData.GeneratePerson<Person>());
		}
		var personToUpdate = models.FastShuffle(1).First();
		var updatedPerson = RandomData.GeneratePerson<Person>();
		updatedPerson.CellPhone = "5555555555";

		// Act
		models.Upsert(updatedPerson);
		models.Upsert(updatedPerson);

		// Assert
		Assert.HasCount(largeCount + 1, models);
		var found = models.FirstOrDefault(p => p.Id.Equals(personToUpdate.Id));
		Assert.IsNotNull(found);
		Assert.AreNotEqual(updatedPerson.Phone, found.Phone);
	}

	[TestMethod]
	public void UpsertWithIDataModel_MultipleUpserts_ShouldMaintainCorrectCount()
	{
		// Arrange
		var models = new List<Person>();
		var testPerson1 = RandomData.GeneratePerson<Person>();
		var testPerson2 = RandomData.GeneratePerson<Person>();

		// Act - Add first item
		models.Upsert(testPerson1);
		Assert.HasCount(1, models);

		// Act - Add second item
		models.Upsert(testPerson2);
		Assert.HasCount(2, models);

		// Act - Update first item
		var updatedPerson1 = RandomData.GeneratePerson<Person>();
		updatedPerson1.CellPhone = "5555555555";
		models.Upsert(updatedPerson1);

		// Assert
		Assert.HasCount(3, models);
		Assert.IsTrue(models.Any(p => p.Id.Equals(testPerson1.Id)));
		Assert.IsTrue(models.Any(p => p.Id.Equals(testPerson2.Id)));
	}

	[TestMethod]
	public void UpsertWithIDataModel_NewItem_ShouldAddToCollection()
	{
		// Arrange
		var models = new List<Person>();
		for (int i = 0; i < Count; i++)
		{
			models.Add(RandomData.GeneratePerson<Person>());
		}
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		models.Upsert(newPerson);

		// Assert
		Assert.HasCount(Count + 1, models);
		Assert.IsTrue(models.Any(p => p.Id.Equals(newPerson.Id)));
	}

	[TestMethod]
	public void UpsertWithIDataModel_NullItem_ShouldNotModifyCollection()
	{
		// Arrange
		var models = new List<Person>();
		for (int i = 0; i < Count; i++)
		{
			models.Add(RandomData.GeneratePerson<Person>());
		}

		Person nullPerson = null;

		// Act
		models.Upsert(nullPerson);

		// Assert
		Assert.HasCount(Count, models);
	}

	[TestMethod]
	public void UpsertWithIDataModel_ReadOnlyCollection_ShouldThrowArgumentReadOnlyException()
	{
		// Arrange
		var models = new List<Person>();
		for (int i = 0; i < Count; i++)
		{
			models.Add(RandomData.GeneratePerson<Person>());
		}
		var readOnlyCollection = new ReadOnlyCollection<Person>(models);
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentReadOnlyException>(() => readOnlyCollection.Upsert(newPerson));
	}

	[TestMethod]
	public void UpsertWithIDataModelTest()
	{
		var models = new List<Person>();


		for (int i = 0; i < Count; i++)
		{
			models.Add(RandomData.GeneratePerson<Person>());
		}


		// Should have same count, but updated value for Id=5
		Assert.HasCount(Count, models);

		// Add new item
		var person = RandomData.GeneratePerson<Person>();
		models.Upsert(person);
		Assert.HasCount(Count + 1, models);
	}


}
