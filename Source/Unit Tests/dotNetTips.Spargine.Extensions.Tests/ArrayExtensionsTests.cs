// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-02-2026
// ***********************************************************************
// <copyright file="ArrayExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ArrayExtensionsTests
{

	[TestMethod]
	public void AddFirst_NullArray_ThrowsArgumentNullException()
	{
		Person[] array = null;
		var person = RandomData.GeneratePerson<Person>();

		Assert.ThrowsExactly<ArgumentNullException>(() => array.AddFirst(person));
	}

	[TestMethod]
	public void AddFirstNullTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.AddFirst(null);

		Assert.AreEqual(10, result.Length);
	}

	[TestMethod]
	public void AddFirstTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		var result = people.AddFirst(person);

		Assert.AreEqual(11, result.Length);
	}

	[TestMethod]
	public void AddIf_ConditionFalse_ReturnsOriginalArray()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		var result = people.AddIf(person, false);

		Assert.AreSame(people, result);
		Assert.AreEqual(10, result.Length);
	}

	[TestMethod]
	public void AddIfNullTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.AddIf(null, people.Length == 10);

		Assert.AreEqual(10, result.Length);
	}

	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		var result = people.AddIf(person, people.Length == 10);

		Assert.AreEqual(11, result.Length);
	}

	[TestMethod]
	public void AddLast_NullArray_ThrowsArgumentNullException()
	{
		Person[] array = null;
		var person = RandomData.GeneratePerson<Person>();

		Assert.ThrowsExactly<ArgumentNullException>(() => array.AddLast(person));
	}

	[TestMethod]
	public void AddLastTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		var result = people.AddLast(person);

		Assert.AreEqual(11, result.Length);
		Assert.IsTrue(result.Last() == person);

		Assert.AreEqual(11, result.AddLast(null).Length);
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

	[TestMethod]
	public void AreEqual_SecondArrayNull_ReturnsFalse()
	{
		var array1 = new[] { 1, 2, 3 };
		int[] array2 = null;

		var result = array1.AreEqual(array2);

		Assert.IsFalse(result);
	}

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
	public void AsReadOnlySpan_NullArray_ThrowsArgumentNullException()
	{
		string[] array = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => array.AsReadOnlySpan());
	}

	[TestMethod]
	public void AsReadOnlySpanTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.AsReadOnlySpan();

		Assert.AreEqual(10, result.Length);
	}

	[TestMethod]
	public void AsReadOnlyTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.AsReadOnly();

		Assert.IsNotNull(result);
		Assert.AreEqual(10, result.Count);
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

	[TestMethod]
	public void BytesToStringTest()
	{
		var bytes = RandomData.GenerateByteArray(100);

		var result = bytes.BytesToString();

		Assert.IsGreaterThan(100, result.Length);
	}

	[TestMethod]
	public void CloneFastCloneTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.FastClone();

		Assert.IsTrue(people.AreEqual(result));
	}

	[TestMethod]
	public void ContainsAnyTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var person = RandomData.GeneratePerson<Person>();

		Assert.IsFalse(people.ContainsAny(new[] { person }));

		Assert.IsTrue(people.ContainsAny(new[] { people.Last() }));
	}

	[TestMethod]
	public void FastClone_NullArray_ThrowsArgumentNullException()
	{
		Person[] array = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => array.FastClone());
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
		Assert.IsNotEmpty(result);
	}

	[TestMethod]
	public void FastLongCount_NullArray_ThrowsArgumentNullException()
	{
		int[] array = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => array.FastLongCount());
	}

	[TestMethod]
	public void FastLongCount_ReturnsCorrectLength()
	{
		var arr = new[] { 1, 2, 3, 4, 5 };

		Assert.AreEqual(5L, arr.FastLongCount());
	}

	[TestMethod]
	public void FastProcessor_NullAction_ThrowsArgumentNullException()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		Assert.ThrowsExactly<ArgumentNullException>(() => people.FastProcessor((Action<Person>)null));
	}

	[TestMethod]
	public void FastProcessor_NullArray_ThrowsArgumentNullException()
	{
		Person[] array = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => array.FastProcessor(p => { }));
	}

	[TestMethod]
	public void FastProcessorTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10000).ToArray();

		people.FastProcessor((Person person) => person.LastName = "TEST NAME");

		Assert.IsTrue(people.All(p => p.LastName == "TEST NAME"));
	}

	[TestMethod]
	public void FastSelectItems_InvalidCount_ThrowsArgumentOutOfRangeException()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => people.FastSelectItems(0, 11));
	}

	[TestMethod]
	public void FastSelectItems_InvalidStartIndex_ThrowsArgumentOutOfRangeException()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => people.FastSelectItems(-1, 2));
	}

	[TestMethod]
	public void FastSelectItems_NullArray_ThrowsArgumentNullException()
	{
		Person[] array = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => array.FastSelectItems(0, 1));
	}

	[TestMethod]
	public void FastSelectItemsTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.FastSelectItems(0, 2);

		Assert.AreEqual(2, result.Length);
	}

	[TestMethod]
	public void FastSliceToMemory_InvalidRange_ThrowsArgumentOutOfRangeException()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => numbers.FastSliceToMemory(4, 2));
	}

	[TestMethod]
	public void FastSliceToMemory_ReturnsExpectedSlice()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		var result = numbers.FastSliceToMemory(1, 3);

		CollectionAssert.AreEqual(new[] { 20, 30, 40 }, result.ToArray());
	}

	[TestMethod]
	public void FastSliceToReadOnlyMemory_InvalidRange_ThrowsArgumentOutOfRangeException()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => numbers.FastSliceToReadOnlyMemory(4, 2));
	}

	[TestMethod]
	public void FastSliceToReadOnlyMemory_ReturnsExpectedSlice()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		var result = numbers.FastSliceToReadOnlyMemory(1, 3);

		CollectionAssert.AreEqual(new[] { 20, 30, 40 }, result.ToArray());
	}

	[TestMethod]
	public void FastSliceToReadOnlySpan_InvalidRange_ThrowsArgumentOutOfRangeException()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
		{
			_ = numbers.FastSliceToReadOnlySpan(4, 2);
		});
	}

	[TestMethod]
	public void FastSliceToReadOnlySpan_ReturnsExpectedSlice()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		var result = numbers.FastSliceToReadOnlySpan(1, 3);

		CollectionAssert.AreEqual(new[] { 20, 30, 40 }, result.ToArray());
	}

	[TestMethod]
	public void FastSliceToSpan_InvalidRange_ThrowsArgumentOutOfRangeException()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
		{
			_ = numbers.FastSliceToSpan(4, 2);
		});
	}

	[TestMethod]
	public void FastSliceToSpan_ReturnsExpectedSlice()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		var result = numbers.FastSliceToSpan(1, 3);

		CollectionAssert.AreEqual(new[] { 20, 30, 40 }, result.ToArray());
	}

	[TestMethod]
	public void GenerateHashCode_ArrayWithNullElements_ReturnsHashCode()
	{
		var arrayWithNullElements = new string[] { "a", null, "c" };
		var arrayWithoutNullElements = new string[] { "a", "c" };

		var hashCodeWithNullElements = arrayWithNullElements.GenerateHashCode();
		var hashCodeWithoutNullElements = arrayWithoutNullElements.GenerateHashCode();

		Assert.AreEqual(hashCodeWithoutNullElements, hashCodeWithNullElements);
	}

	[TestMethod]
	public void GenerateHashCode_NullArray_ThrowsArgumentNullException()
	{
		string[] array = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => array.GenerateHashCode());
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
	public void IndexOf_DuplicateItems_ReturnsFirstOccurrence()
	{
		// Arrange
		var numbers = new[] { 10, 20, 30, 20, 50 };

		// Act
		var result = numbers.IndexOf(20);

		// Assert
		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public void IndexOf_EmptyArray_ReturnsMinusOne()
	{
		// Arrange
		var array = new int[0];

		// Act
		var result = array.IndexOf(5);

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void IndexOf_FirstItem_ReturnsZero()
	{
		// Arrange
		var numbers = new[] { 10, 20, 30, 40, 50 };

		// Act
		var result = numbers.IndexOf(10);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void IndexOf_ItemExists_ReturnsCorrectIndex()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var targetPerson = people[5];

		// Act
		var result = people.IndexOf(targetPerson);

		// Assert
		Assert.AreEqual(5, result);
	}

	[TestMethod]
	public void IndexOf_ItemNotFound_ReturnsMinusOne()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var newPerson = RandomData.GeneratePerson<Person>();

		// Act
		var result = people.IndexOf(newPerson);

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void IndexOf_LargeArray_FindsItem()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(1000).ToArray();
		var targetPerson = people[750];

		// Act
		var result = people.IndexOf(targetPerson);

		// Assert
		Assert.AreEqual(750, result);
	}

	[TestMethod]
	public void IndexOf_LastItem_ReturnsLastIndex()
	{
		// Arrange
		var numbers = new[] { 10, 20, 30, 40, 50 };

		// Act
		var result = numbers.IndexOf(50);

		// Assert
		Assert.AreEqual(4, result);
	}

	[TestMethod]
	public void IndexOf_MiddleItem_ReturnsCorrectIndex()
	{
		// Arrange
		var numbers = new[] { 10, 20, 30, 40, 50 };

		// Act
		var result = numbers.IndexOf(30);

		// Assert
		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public void IndexOf_NullArray_ThrowsArgumentNullException()
	{
		// Arrange
		int[] array = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => array.IndexOf(5));
	}

	[TestMethod]
	public void IndexOf_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var array = new Person[] { RandomData.GeneratePerson<Person>() };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => array.IndexOf(null));
	}

	[TestMethod]
	public void IndexOf_SingleElementArray_Found()
	{
		// Arrange
		var array = new[] { 42 };

		// Act
		var result = array.IndexOf(42);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void IndexOf_SingleElementArray_NotFound()
	{
		// Arrange
		var array = new[] { 42 };

		// Act
		var result = array.IndexOf(99);

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void IndexOf_StringArray_FindsItem()
	{
		// Arrange
		var words = new[] { "apple", "banana", "cherry", "date" };

		// Act
		var result = words.IndexOf("cherry");

		// Assert
		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public void IndexOf_StringArray_ItemNotFound()
	{
		// Arrange
		var words = new[] { "apple", "banana", "cherry" };

		// Act
		var result = words.IndexOf("grape");

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void IndexOf_ValueTypeArray_FindsItem()
	{
		// Arrange
		var numbers = Enumerable.Range(1, 100).ToArray();

		// Act
		var result = numbers.IndexOf(50);

		// Assert
		Assert.AreEqual(49, result);
	}

	[TestMethod]
	public void IsNotEmpty_EmptyArray_ReturnsFalse()
	{
		var arr = Array.Empty<int>();

		Assert.IsFalse(arr.IsNotEmpty());
	}

	[TestMethod]
	public void IsNotEmpty_WithCount_ReturnsExpected()
	{
		var arr = new[] { 1, 2, 3 };

		Assert.IsTrue(arr.IsNotEmpty(3));
		Assert.IsFalse(arr.IsNotEmpty(2));
	}

	[TestMethod]
	public void IsNotEmpty_WithFunc_ReturnsExpected()
	{
		var arr = new[] { 1, 2, 3, 4 };

		Assert.IsTrue(arr.IsNotEmpty(x => x > 2));
		Assert.IsFalse(arr.IsNotEmpty(x => x > 10));
	}

	[TestMethod]
	public void IsNotEmpty_WithNullArray_ReturnsFalse()
	{
		int[] arr = null;

		Assert.IsFalse(arr.IsNotEmpty());
	}

	[TestMethod]
	public void IsNotEmpty_WithNullFunc_ReturnsFalse()
	{
		var arr = new[] { 1, 2, 3 };

		Assert.IsFalse(arr.IsNotEmpty(null as Func<int, bool>));
	}

	[TestMethod]
	public void IsNotEmptyTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection(10).ToArray();
		Person[] nullPeople = null;

		Assert.IsTrue(people1.IsNotEmpty());

		Assert.IsFalse(nullPeople.IsNotEmpty());
	}

	[TestMethod]
	public void IsNotEmptyTestWithCount()
	{
		var people1 = RandomData.GeneratePersonRefCollection(10).ToArray();
		Person[] nullPeople = null;

		Assert.IsTrue(people1.IsNotEmpty(10));

		Assert.IsFalse(people1.IsNotEmpty(100));

		Assert.IsFalse(nullPeople.IsNotEmpty(10));

	}

	[TestMethod]
	public void IsNotEmptyTestWithFunction()
	{
		var collection = RandomData.GeneratePersonRefCollection(10).ToArray();
		Person[] nullCollection = null;

		Func<Person, bool> selector = (person) => person.Email.IsNotNull();

		Assert.IsTrue(collection.IsNotEmpty(selector));

		Assert.IsFalse(nullCollection.IsNotEmpty(selector));

		Assert.IsFalse(nullCollection.IsNotEmpty(null));
	}

	[TestMethod]
	public void LastIndexOf_DuplicateItems_ReturnsLastOccurrence()
	{
		var numbers = new[] { 10, 20, 30, 20, 50 };

		var result = numbers.LastIndexOf(20);

		Assert.AreEqual(3, result);
	}

	[TestMethod]
	public void LastIndexOf_EmptyJaggedArray_ReturnsMinusOne()
	{
		// Arrange
		var array = new int[0][];
		var target = new[] { 1, 2 };

		// Act
		var result = array.LastIndexOf(target);

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void LastIndexOf_ItemNotFound_ReturnsMinusOne()
	{
		var numbers = new[] { 10, 20, 30, 40, 50 };

		var result = numbers.LastIndexOf(99);

		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void LastIndexOf_JaggedArray_FirstElement_ReturnsZero()
	{
		// Arrange
		var target = new[] { 10, 20 };
		var array = new int[][]
		{
		target,
		new[] { 1, 2 },
		new[] { 3, 4 }
		};

		// Act
		var result = array.LastIndexOf(target);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void LastIndexOf_JaggedArray_ItemExists_ReturnsLastIndex()
	{
		// Arrange
		var target = new[] { 10, 20 };
		var array = new int[][]
		{
		new[] { 1, 2 },
		target,
		new[] { 3, 4 },
		target,
		new[] { 5, 6 }
		};

		// Act
		var result = array.LastIndexOf(target);

		// Assert
		Assert.AreEqual(3, result);
	}

	[TestMethod]
	public void LastIndexOf_JaggedArray_ItemNotFound_ReturnsMinusOne()
	{
		// Arrange
		var array = new int[][]
		{
		new[] { 1, 2 },
		new[] { 3, 4 },
		new[] { 5, 6 }
		};
		var notInArray = new[] { 7, 8 };

		// Act
		var result = array.LastIndexOf(notInArray);

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void LastIndexOf_JaggedArray_LastElement_ReturnsLastIndex()
	{
		// Arrange
		var target = new[] { 10, 20 };
		var array = new int[][]
		{
		new[] { 1, 2 },
		new[] { 3, 4 },
		new[] { 5, 6 },
		target
		};

		// Act
		var result = array.LastIndexOf(target);

		// Assert
		Assert.AreEqual(3, result);
	}

	[TestMethod]
	public void LastIndexOf_JaggedArray_SingleOccurrence_ReturnsIndex()
	{
		// Arrange
		var target = new[] { 10, 20 };
		var array = new int[][]
		{
		new[] { 1, 2 },
		new[] { 3, 4 },
		target,
		new[] { 5, 6 }
		};

		// Act
		var result = array.LastIndexOf(target);

		// Assert
		Assert.AreEqual(2, result);
	}


	[TestMethod]
	public void LastIndexOf_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var array = new int[][] { new[] { 1, 2 }, new[] { 3, 4 } };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => array.LastIndexOf(null));
	}

	[TestMethod]
	public void LastIndexOf_SingleElementJaggedArray_Found()
	{
		// Arrange
		var target = new[] { 42 };
		var array = new int[][] { target };

		// Act
		var result = array.LastIndexOf(target);

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void LastIndexOf_SingleElementJaggedArray_NotFound()
	{
		// Arrange
		var array = new int[][] { new[] { 42 } };
		var target = new[] { 99 };

		// Act
		var result = array.LastIndexOf(target);

		// Assert
		Assert.AreEqual(-1, result);
	}

	[TestMethod]
	public void LastIndexOf_StringJaggedArray_ReturnsLastIndex()
	{
		// Arrange
		var target = new[] { "apple", "banana" };
		var array = new string[][]
		{
		new[] { "cat", "dog" },
		target,
		new[] { "fish", "bird" },
		target
		};

		// Act
		var result = array.LastIndexOf(target);

		// Assert
		Assert.AreEqual(3, result);
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
	public void PerformAction_NullActionOnArray_ThrowsArgumentNullException()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		Assert.ThrowsExactly<ArgumentNullException>(() => people.PerformAction(null));
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

	[TestMethod]
	public void PerformActionTest_Ref()
	{
		var people = RandomData.GeneratePersonRefCollection(10000).ToArray();
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append($"{person.ToString()}|"));

		Assert.IsGreaterThan(1000, sb.Length);
	}

	[TestMethod]
	public void PerformActionTest_Val()
	{
		var people = RandomData.GeneratePersonValCollection(10000).ToArray();
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append($"{person.ToString()}|"));

		Assert.IsGreaterThan(100, sb.Length);
	}

	[TestMethod]
	public void RemoveFirst_EmptyArray_ThrowsArgumentNullException()
	{
		var array = Array.Empty<int>();

		Assert.ThrowsExactly<ArgumentNullException>(() => array.RemoveFirst());
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
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void RemoveFirst_ValidArray_RemovesFirstElement()
	{
		// Arrange
		var array = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array.RemoveFirst();

		// Assert
		Assert.HasCount(4, result);
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
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void RemoveLast_ValidArray_RemovesLastElement()
	{
		// Arrange
		var array = new[] { 1, 2, 3, 4, 5 };

		// Act
		var result = array.RemoveLast();

		// Assert
		Assert.HasCount(4, result);
		CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, result);
	}

	[TestMethod]
	public void RemoveLastTest()
	{
		var people = RandomData.GeneratePersonRefCollection(100).ToArray();

		var result = people.RemoveLast();

		Assert.AreEqual(99, result.FastLongCount());
	}

	[TestMethod]
	public void ToDistinct_NullArray_ThrowsArgumentNullException()
	{
		string[] array = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => array.ToDistinct());
	}

	[TestMethod]
	public void ToDistinct_RemovesDuplicates()
	{
		var arr = new[] { 1, 2, 2, 3, 3, 3 };
		var result = arr.ToDistinct();

		CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, result);
	}

	[TestMethod]
	public void ToDistinct_WithComparer_RemovesDuplicates()
	{
		var arr = new[] { "hello", "HELLO", "world", "World" };
		var result = arr.ToDistinct(StringComparer.OrdinalIgnoreCase);

		Assert.AreEqual(2, result.Length);
	}

	[TestMethod]
	public void ToDistinctTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		words = words.AddLast(words.First());

		Assert.AreEqual(10, words.ToDistinct().Length);
	}

	[TestMethod]
	public void ToFrozenSet_NullArray_ThrowsArgumentNullException()
	{
		string[] array = null;

		Assert.ThrowsExactly<ArgumentNullException>(() => array.ToFrozenSet());
	}

	[TestMethod]
	public void ToFrozenSet_ReturnsFrozenSet()
	{
		var arr = new[] { 1, 2, 3 };
		var frozen = arr.ToFrozenSet();

		Assert.Contains(2, frozen);
		Assert.HasCount(3, frozen);
	}

	[TestMethod]
	public void ToFrozenSet_WithComparer_ReturnsCorrectSet()
	{
		var arr = new[] { "alpha", "ALPHA", "beta", "Beta" };
		var result = arr.ToFrozenSet(StringComparer.OrdinalIgnoreCase);

		Assert.HasCount(2, result);
		Assert.IsTrue(result.Contains("alpha"));
		Assert.IsTrue(result.Contains("beta"));
	}

	[TestMethod]
	public void ToFrozenSetTest()
	{
		var words = RandomData.GenerateWords(10, 10, 100).ToArray();

		var result = words.ToFrozenSet();

		Assert.IsNotNull(result);
		Assert.AreEqual(10, result.Count);
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
		Assert.HasCount(people.Length, result, "The length of the array should remain unchanged when upserting an existing item.");

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
		Assert.HasCount(people.Length, result, "The length of the array should remain unchanged when upserting an existing item.");
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
		Assert.HasCount(people.Length + 1, result, "The length of the array should increase by one when upserting a new item.");
		Assert.IsTrue(result.Contains(newPerson), "The new item should be present in the array after upserting.");
	}

	[TestMethod]
	public void Upsert_NullArray_ThrowsArgumentNullException()
	{
		Person[] array = null;
		var person = RandomData.GeneratePerson<Person>();

		Assert.ThrowsExactly<ArgumentNullException>(() => array.Upsert(person));
	}

	[TestMethod]
	public void Upsert_NullItem_ReturnsOriginalArray()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();

		var result = people.Upsert(null);

		Assert.AreSame(people, result, "Upsert should return the original array instance when the item is null.");
		Assert.HasCount(10, result);
	}

	[TestMethod]
	public void UpsertTest01()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToArray();
		var personFromCollection = people.Shuffle().First();
		_ = personFromCollection.Phone = "1234567890";
		var person = RandomData.GeneratePerson<Person>();

		var result = people.Upsert(personFromCollection);

		Assert.AreEqual(10, result.FastLongCount());

		result = people.Upsert(person);

		Assert.AreEqual(11, result.FastLongCount());

		result = people.Upsert(personFromCollection);

		Assert.AreEqual(10, result.FastLongCount());

		result = people.Upsert(null);

		Assert.AreEqual(10, result.FastLongCount());
	}
}
