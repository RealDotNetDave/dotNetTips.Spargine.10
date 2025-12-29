// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-08-2025
// ***********************************************************************
// <copyright file="ArrayExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ArrayExtensionsTests
{

	[TestMethod]
	public void AddFirstNullTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.AddFirst(null);

		Assert.IsTrue(result.FastLongCount() == 10);
	}

	/// <summary>
	/// Defines the test method AddFirstTest.
	/// </summary>
	[TestMethod]
	public void AddFirstTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		var result = people.AddFirst(person);

		Assert.IsTrue(result.FastLongCount() == 11);
	}

	[TestMethod]
	public void AddIfNullTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.AddIf(null, people.Length == 10);

		Assert.IsTrue(result.FastLongCount() == 10);
	}

	/// <summary>
	/// Defines the test method AddIfTest.
	/// </summary>
	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		var result = people.AddIf(person, people.Length == 10);

		Assert.IsTrue(result.FastLongCount() == 11);
	}

	/// <summary>
	/// Defines the test method AddLastTest.
	/// </summary>
	[TestMethod]
	public void AddLastTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		var result = people.AddLast(person);

		Assert.IsTrue(result.Length == 11);
		Assert.IsTrue(result.Last() == person);

		Assert.IsTrue(result.AddLast(null).Length == 11);
	}

	[TestMethod]
	public void AreEqual_BothNullArrays_ReturnsFalse()
	{
		// Arrange
		int[] array1 = null;
		int[] array2 = null;

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AreEqual_DifferentArrays_ReturnsFalse()
	{
		// Arrange
		var array1 = new[] { 1, 2, 3, 4, 5 };
		var array2 = new[] { 1, 2, 3, 4, 6 };

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AreEqual_DifferentLengths_ReturnsFalse()
	{
		// Arrange
		var array1 = new[] { 1, 2, 3, 4, 5 };
		var array2 = new[] { 1, 2, 3, 4 };

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AreEqual_NullArray_ReturnsFalse()
	{
		// Arrange
		int[] array1 = null;
		var array2 = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void AreEqual_SameArrays_ReturnsTrue()
	{
		// Arrange
		var array1 = new[] { 1, 2, 3, 4, 5 };
		var array2 = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array1.AreEqual(array2);

		// Assert
		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method AreEqualTest.
	/// </summary>
	[TestMethod]
	public void AreEqualTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection(10).ToArray();
		var people2 = people1;
		var people3 = RandomData.GeneratePersonRefCollection(10).ToArray();

		Assert.IsFalse(people1.AreEqual(people3));

		Assert.IsTrue(people1.AreEqual(people2));

		Assert.IsFalse(people1.AreEqual(arrayToCheck: null));
	}


	[TestMethod]
	public void AsReadOnlySpanTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.AsReadOnlySpan();

		Assert.IsTrue(result.Length == 10);
	}

	[TestMethod]
	public void AsReadOnlyTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.AsReadOnly();

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == 10);
	}

	[TestMethod]
	public void BytesToString_EmptyByteArray_ReturnsEmptyString()
	{
		// Arrange
		var byteArray = new byte[0];

		// Act
		var result = byteArray.BytesToString();

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void BytesToString_ValidByteArray_ReturnsHexString()
	{
		// Arrange
		var byteArray = new byte[] { 0x0F, 0xA0, 0xB1, 0xC2 };

		// Act
		var result = byteArray.BytesToString();

		// Assert
		Assert.AreEqual("0FA0B1C2", result);
	}

	/// <summary>
	/// Defines the test method BytesToStringTest.
	/// </summary>
	[TestMethod]
	public void BytesToStringTest()
	{
		var bytes = RandomData.GenerateByteArray(100);

		var result = bytes.BytesToString();

		Assert.IsTrue(result.Length > 100);
	}

	/// <summary>
	/// Defines the test method CloneTest.
	/// </summary>
	[TestMethod]
	public void CloneFastCloneTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.FastClone();

		Assert.IsTrue(people.AreEqual(result));
	}

	/// <summary>
	/// Defines the test method ContainsAnyTest.
	/// </summary>
	[TestMethod]
	public void ContainsAnyTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		Assert.IsFalse(people.ContainsAny(new[] { person }));

		Assert.IsTrue(people.ContainsAny(new[] { people.Last() }));
	}

	/// <summary>
	/// Defines the test method DoesNotHasItemsTest.
	/// </summary>
	[TestMethod]
	public void DoesNotHasItemsTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection(10).ToArray();
		Person[] nullPeople = null;

		Assert.IsFalse(people1.IsEmpty());

		Assert.IsTrue(nullPeople.IsEmpty());
	}

	[TestMethod]
	public void FastHashData_ValidData_ReturnsHash()
	{
		// Arrange
		var data = Encoding.UTF8.GetBytes("Test data");

		// Act
		var result = data.FastHashData();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Length > 0);
	}

	[TestMethod]
	public void FastLongCount_ReturnsCorrectLength()
	{
		var arr = new[] { 1, 2, 3, 4, 5 };
		Assert.AreEqual(5, arr.FastLongCount());
	}

	/// <summary>
	/// Defines the test method FastProcessorTest.
	/// </summary>
	[TestMethod]
	public void FastProcessorTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10000).ToArray();

		people.FastProcessor((Person person) => person.LastName = "TEST NAME");
	}

	[TestMethod]
	public void FastSelectItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.FastSelectItems(0, 2);

		Assert.IsTrue(result.Length == 2);
	}

	[TestMethod]
	public void GenerateHashCode_ReturnsConsistentValue()
	{
		var arr1 = new[] { "a", "b", "c" };
		var arr2 = new[] { "a", "b", "c" };
		var arr3 = new[] { "a", "b", "d" };

		var hash1 = arr1.GenerateHashCode();
		var hash2 = arr2.GenerateHashCode();
		var hash3 = arr3.GenerateHashCode();

		Assert.AreEqual(hash1, hash2);
		Assert.AreNotEqual(hash1, hash3);
	}

	[TestMethod]
	public void HasItems_WithCount_ReturnsExpected()
	{
		var arr = new[] { 1, 2, 3 };
		Assert.IsTrue(arr.IsNotEmpty(3));
		Assert.IsFalse(arr.IsNotEmpty(2));
	}

	[TestMethod]
	public void HasItems_WithFunc_ReturnsExpected()
	{
		var arr = new[] { 1, 2, 3, 4 };
		Assert.IsTrue(arr.IsNotEmpty(x => x > 2));
		Assert.IsFalse(arr.IsNotEmpty(x => x > 10));
	}

	[TestMethod]
	public void HasItems_WithNullArray_ReturnsFalse()
	{
		int[] arr = null;
		Assert.IsFalse(arr.IsNotEmpty());
	}

	/// <summary>
	/// Defines the test method HasItemsTest.
	/// </summary>
	[TestMethod]
	public void HasItemsTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection(10).ToArray();
		Person[] nullPeople = null;

		Assert.IsTrue(people1.IsNotEmpty());

		Assert.IsFalse(nullPeople.IsNotEmpty());
	}

	/// <summary>
	/// Defines the test method HasItemsTestWithCount.
	/// </summary>
	[TestMethod]
	public void HasItemsTestWithCount()
	{
		var people1 = RandomData.GeneratePersonRefCollection(10).ToArray();
		Person[] nullPeople = null;

		Assert.IsTrue(people1.IsNotEmpty(10));

		Assert.IsFalse(people1.IsNotEmpty(100));

		Assert.IsFalse(nullPeople.IsNotEmpty(10));

	}

	/// <summary>
	/// Defines the test method HasItemsTestWithFunction.
	/// </summary>
	[TestMethod]
	public void HasItemsTestWithFunction()
	{
		var collection = RandomData.GeneratePersonRefCollection(10).ToArray();
		Person[] nullCollection = null;

		Func<Person, bool> selector = (person) => person.Email.IsNotNull();

		Assert.IsTrue(collection.IsNotEmpty(selector));

		Assert.IsFalse(nullCollection.IsNotEmpty(selector));

		Assert.IsFalse(nullCollection.IsNotEmpty(null));
	}

	[TestMethod]
	public void PerformAction_ActionWithMultipleAppends_ReturnsConcatenatedString()
	{
		// Arrange
		Action<StringBuilder> action = sb =>
		{
			sb.Append("First part. ");
			sb.Append("Second part. ");
			sb.Append("Third part.");
		};

		// Act
		var result = FastStringBuilder.PerformAction(action);

		// Assert
		Assert.AreEqual("First part. Second part. Third part.", result);
	}

	[TestMethod]
	public void PerformAction_EmptyAction_ReturnsEmptyString()
	{
		// Arrange
		Action<StringBuilder> action = sb => { };

		// Act
		var result = FastStringBuilder.PerformAction(action);

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void PerformAction_NullAction_ReturnsEmptyString()
	{
		// Arrange
		Action<StringBuilder> action = null;

		// Act
		var result = FastStringBuilder.PerformAction(action);

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void PerformAction_NullOrEmptyArray_DoesNothing()
	{
		// Arrange
		int[] arr = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => arr.PerformAction(x => Assert.Fail("Should not be called")));
	}

	[TestMethod]
	public void PerformAction_ValidAction_ReturnsExpectedString()
	{
		// Arrange
		Action<StringBuilder> action = sb =>
		{
			sb.Append("Hello, ");
			sb.Append("world!");
		};

		// Act
		var result = FastStringBuilder.PerformAction(action);

		// Assert
		Assert.AreEqual("Hello, world!", result);
	}

	/// <summary>
	/// Defines the test method PerformActionTest_Ref.
	/// </summary>
	[TestMethod]
	public void PerformActionTest_Ref()
	{
		var people = RandomData.GeneratePersonRefCollection(10000).ToArray();
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append($"{person.ToString()}|"));

		Assert.IsTrue(sb.Length > 1000);
	}

	/// <summary>
	/// Defines the test method PerformActionTest_Val.
	/// </summary>
	[TestMethod]
	public void PerformActionTest_Val()
	{
		var people = RandomData.GeneratePersonValCollection(10000).ToArray();
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append($"{person.ToString()}|"));

		Assert.IsTrue(sb.Length > 100);
	}

	[TestMethod]
	public void RemoveFirst_NullArray_ThrowsArgumentNullException()
	{
		// Arrange
		int[] array = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => array.RemoveFirst());
	}

	[TestMethod]
	public void RemoveFirst_SingleElementArray_ReturnsEmptyArray()
	{
		// Arrange
		var array = new[] { 1 };

		// Act
		var result = array.RemoveFirst();

		// Assert
		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	public void RemoveFirst_ValidArray_RemovesFirstElement()
	{
		// Arrange
		var array = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array.RemoveFirst();

		// Assert
		Assert.AreEqual(4, result.Length);
		CollectionAssert.AreEqual(new[] { 2, 3, 4, 5 }, result);
	}


	[TestMethod]
	public void RemoveLast_EmptyArray_ThrowsArgumentNullException()
	{
		// Arrange
		var array = new int[0];

		// Act
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => array.RemoveLast());
	}

	[TestMethod]
	public void RemoveLast_NullArray_ThrowsArgumentNullException()
	{
		// Arrange
		int[] array = null;

		// Act
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => array.RemoveLast());
	}

	[TestMethod]
	public void RemoveLast_SingleElementArray_ReturnsEmptyArray()
	{
		// Arrange
		var array = new[] { 1 };

		// Act
		var result = array.RemoveLast();

		// Assert
		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	public void RemoveLast_ValidArray_RemovesLastElement()
	{
		// Arrange
		var array = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array.RemoveLast();

		// Assert
		Assert.AreEqual(4, result.Length);
		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, result);
	}

	/// <summary>
	/// Defines the test method RemoveLastTest.
	/// </summary>
	[TestMethod]
	public void RemoveLastTest()
	{
		var people = RandomData.GeneratePersonRefCollection(100).ToArray();

		var result = people.RemoveLast();

		Assert.IsTrue(result.FastLongCount() == 99);
	}

	[TestMethod]
	public void ToDistinct_RemovesDuplicates()
	{
		var arr = new[] { 1, 2, 2, 3, 3, 3 };
		var result = arr.ToDistinct();
		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, result);
	}

	/// <summary>
	/// Defines the test method ToDistinctTest.
	/// </summary>
	[TestMethod]
	public void ToDistinctTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		words = words.AddLast(words.First());

		Assert.IsTrue(words.ToDistinct().Length == 10);
	}

	[TestMethod]
	public void ToFrozenSet_ReturnsFrozenSet()
	{
		var arr = new[] { 1, 2, 3 };
		var frozen = arr.ToFrozenSet();
		Assert.IsTrue(frozen.Contains(2));
		Assert.AreEqual(3, frozen.Count);
	}

	[TestMethod]
	public void ToFrozenSetTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.ToFrozenSet();

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count == 10);
	}

	[TestMethod]
	public void Upsert_EmptyArrayOrItem_ReturnsOriginal()
	{
		var arr2 = new int[0];
		var result = arr2.Upsert(0);

		Assert.AreEqual(1, result.Length);
	}

	[TestMethod]
	public void Upsert_ExistingItem_UpdatesArray()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var existingPerson = people.First();
		existingPerson.Phone = "1234567890"; // Modify a property to check for update

		// Act
		var result = people.Upsert(existingPerson);

		// Assert
		Assert.AreEqual(people.Length, result.Length, "The length of the array should remain unchanged when upserting an existing item.");

		Assert.AreEqual("1234567890", result.First().Phone, "The existing item should be updated in the array.");
	}

	[TestMethod]
	public void Upsert_ExistingItemById_UpdatesArray()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var existingPerson = people.First();
		existingPerson.Phone = "1234567890"; // Modify a property to check for update

		// Act
		var result = people.Upsert(existingPerson);

		// Assert
		Assert.AreEqual(people.Length, result.Length, "The length of the array should remain unchanged when upserting an existing item.");
		Assert.AreEqual("1234567890", result.First(p => p.Id == existingPerson.Id).Phone, "The existing item should be updated in the array.");
	}

	[TestMethod]
	public void Upsert_NewItem_AddsToArray()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		var result = people.Upsert(newPerson);

		// Assert
		Assert.AreEqual(people.Length + 1, result.Length, "The length of the array should increase by one when upserting a new item.");
		Assert.IsTrue(result.Contains(newPerson), "The new item should be present in the array after upserting.");
	}

	/// <summary>
	/// Defines the test method UpsertTest01.
	/// </summary>
	[TestMethod]
	public void UpsertTest01()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var personFromCollection = people.Shuffle().First();
		_ = personFromCollection.Phone = "1234567890";
		var person = RandomData.GeneratePerson<Person>();

		var result = people.Upsert(personFromCollection);

		Assert.IsTrue(result.FastLongCount() == 10);

		result = people.Upsert(person);

		Assert.IsTrue(result.FastLongCount() == 11);

		result = people.Upsert(personFromCollection);

		Assert.IsTrue(result.FastLongCount() == 10);

		result = people.Upsert(null);

		Assert.IsTrue(result.FastLongCount() == 10);
	}
}
