// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-29-2025
// ***********************************************************************
// <copyright file="StringBuilderExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
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
public class StringBuilderExtensionsTests
{

	[TestMethod]
	public void AppendBytesNullTest()
	{
		var sb = new StringBuilder();

		sb.AppendBytes(null);

		Assert.IsTrue(sb.Length == 0);
	}

	[TestMethod]
	public void AppendBytesTest()
	{
		var sb = new StringBuilder();
		var byteArray = RandomData.GenerateByteArray(256);
		sb.AppendBytes(byteArray);

		Assert.IsTrue(sb.Length > 50);
	}

	[TestMethod]
	public void AppendKeyValueTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).ToDictionary(p => p.Id);

		var sb = new StringBuilder();

		foreach (var person in people)
		{
			sb.AppendKeyValue(person.Key, person.Value.Email);
			sb.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true);
			sb.AppendKeyValue(person.Key, person.Value.Email, includeComma: true);
			sb.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true, includeComma: true);
		}

		Assert.IsTrue(sb.ToString().Length > 50 * 4);

		var pool = new StringBuilder();

		foreach (var person in people)
		{
			pool.AppendKeyValue(person.Key, person.Value.Email);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeComma: true);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true, includeComma: true);
		}

		Assert.IsTrue(pool.ToString().Length > 50 * 4);
	}

	[TestMethod]
	public void AppendValues01()
	{
		var sb = new StringBuilder();
		var values = RandomData.GenerateWords(count: 5, minLength: 5, maxLength: 7);

		sb.AppendValues(ControlChars.CommaSpace, values);

		Assert.IsTrue(sb.Length > 10);

		var pool = new StringBuilder();

		pool.AppendValues(", ", values);

		Assert.IsTrue(pool.Length > 10);
	}

	[TestMethod]
	public void AppendValues02()
	{
		var sb = new StringBuilder();

		sb.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

		Assert.IsTrue(sb.Length > 10);

		var pool = new StringBuilder();

		pool.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

		Assert.IsTrue(pool.Length > 10);
	}


	[TestMethod]
	public void AppendValuesWithParamTest()
	{
		var sb = new StringBuilder();
		var values = RandomData.GeneratePersonRefCollection(count: 5);
		string separator = ", ";
		string format = "{0} - {1}";

		sb.AppendValues(separator, values, format, (person, fmt) =>
		{
			_ = sb.AppendFormat(fmt, person.FirstName, person.LastName);
		});

		Assert.IsTrue(sb.Length > 0, "StringBuilder should contain formatted values.");

		var pool = new StringBuilder();

		pool.AppendValues(separator, values, format, (person, fmt) =>
		{
			_ = pool.AppendFormat(fmt, person.FirstName, person.LastName);
		});

		Assert.IsTrue(pool.Length > 0, "StringBuilder should contain formatted values in the pool instance.");
	}

	[TestMethod]
	public void AppendValuesWithTwoParamsEmptyValuesTest()
	{
		var sb = new StringBuilder();
		var values = new List<Person>(); // Empty collection
		string separator = ", ";

		sb.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Person person, string param1, string param2) =>
		{
			// This block should not execute because the collection is empty
			Assert.Fail("The action should not be executed for an empty collection.");
		});

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty for an empty input collection.");
		var pool = new StringBuilder();

		pool.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Person person, string param1, string param2) =>
		{
			// This block should not execute because the collection is empty
			Assert.Fail("The action should not be executed for an empty collection.");
		});

		Assert.AreEqual(0, pool.Length, "StringBuilder should remain empty for an empty input collection in the pool instance.");
	}

	[TestMethod]
	public void AppendValuesWithTwoParamsTest()
	{
		var sb = new StringBuilder();
		var values = RandomData.GeneratePersonRefCollection(count: 5);
		string separator = ", ";
		string format = "{0} - {1} lives at {2}";

		sb.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Person person, string param1, string param2) =>
		{
			_ = builder.AppendFormat(format, person.FirstName, person.LastName, person.Addresses, param1, param2);
		});

		Assert.IsTrue(sb.Length > 0, "StringBuilder should contain formatted values.");
		var pool = new StringBuilder();

		pool.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Person person, string param1, string param2) =>
		{
			_ = builder.AppendFormat(format, person.FirstName, person.LastName, person.Addresses, param1, param2);
		});

		Assert.IsTrue(pool.Length > 0, "StringBuilder should contain formatted values in the pool instance.");
	}

	[TestMethod]
	public void ClearSetCapacityNegativeCapacityTest()
	{
		var sb = new StringBuilder("Initial content");
		int newCapacity = -1;

		// Ensure the StringBuilder has initial content
		Assert.IsTrue(sb.Length > 0, "StringBuilder should have initial content.");

		// Call ClearSetCapacity
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => sb.ClearSetCapacity(newCapacity));

		// Verify the StringBuilder is cleared
		Assert.AreEqual(0, sb.Length, "StringBuilder should be cleared.");

		// Verify the capacity is set correctly
		Assert.IsTrue(sb.Capacity >= 0, "StringBuilder capacity should be non-negative.");
	}
	[TestMethod]
	public void ClearSetCapacityTest()
	{
		var sb = new StringBuilder("Initial content");
		int newCapacity = 100;

		// Ensure the StringBuilder has initial content
		Assert.IsTrue(sb.Length > 0, "StringBuilder should have initial content.");

		// Call ClearSetCapacity
		sb.ClearSetCapacity(newCapacity);

		// Verify the StringBuilder is cleared
		Assert.AreEqual(0, sb.Length, "StringBuilder should be cleared.");

		// Verify the capacity is set correctly
		Assert.AreEqual(newCapacity, sb.Capacity, "StringBuilder capacity should be set to the new value.");
	}

	[TestMethod]
	public void ClearSetCapacityZeroCapacityTest()
	{
		var sb = new StringBuilder("Initial content");

		// Ensure the StringBuilder has initial content
		Assert.IsTrue(sb.Length > 0, "StringBuilder should have initial content.");

		// Call ClearSetCapacity
		_ = sb.ClearSetCapacity(0);

		// Verify the StringBuilder is cleared
		Assert.AreEqual(0, sb.Length, "StringBuilder should be cleared.");

		// Verify the capacity is set correctly
		Assert.AreEqual(16, sb.Capacity, "StringBuilder capacity should be set to zero.");
	}

	[TestMethod]
	public void SetCapacityAfterAppendOperationsTest()
	{
		var sb = new StringBuilder();

		// Perform multiple append operations
		for (int i = 0; i < 10; i++)
		{
			sb.Append(RandomData.GenerateWord(10));
		}

		var contentBeforeCapacity = sb.ToString();
		var lengthBeforeCapacity = sb.Length;

		// Set larger capacity
		sb.SetCapacity(500);

		// Verify content and length are preserved
		Assert.AreEqual(contentBeforeCapacity, sb.ToString(), "Content should be preserved after SetCapacity.");
		Assert.AreEqual(lengthBeforeCapacity, sb.Length, "Length should be preserved after SetCapacity.");
		Assert.IsTrue(sb.Capacity >= 500, "Capacity should be at least 500.");
	}

	[TestMethod]
	public void SetCapacityComparisonWithClearSetCapacityTest()
	{
		var sb1 = new StringBuilder("Test Content");
		var sb2 = new StringBuilder("Test Content");

		// Use SetCapacity (preserves content)
		sb1.SetCapacity(100);
		Assert.AreEqual("Test Content", sb1.ToString(), "SetCapacity should preserve content.");
		Assert.IsTrue(sb1.Capacity >= 100, "Capacity should be set correctly.");

		// Use ClearSetCapacity (clears content)
		sb2.ClearSetCapacity(100);
		Assert.AreEqual(string.Empty, sb2.ToString(), "ClearSetCapacity should clear content.");
		Assert.AreEqual(100, sb2.Capacity, "Capacity should be set correctly.");
	}

	[TestMethod]
	public void SetCapacityMethodChainingTest()
	{
		var sb = new StringBuilder();
		var testString = "Test chaining";

		// Test method chaining: SetCapacity -> Append -> SetCapacity
		var result = sb.SetCapacity(100)
			.Append(testString)
			.SetCapacity(200);

		Assert.AreSame(sb, result, "Method chaining should return the same StringBuilder instance.");
		Assert.AreEqual(testString, sb.ToString(), "Content should match after chained operations.");
		Assert.IsTrue(sb.Capacity >= 200, "Final capacity should be at least 200.");
	}

	[TestMethod]
	public void SetCapacityMultipleCallsTest()
	{
		var sb = new StringBuilder("Initial");

		// Call SetCapacity multiple times with increasing capacities
		sb.SetCapacity(50);
		Assert.IsTrue(sb.Capacity >= 50, "First capacity should be at least 50.");

		sb.SetCapacity(100);
		Assert.IsTrue(sb.Capacity >= 100, "Second capacity should be at least 100.");

		sb.SetCapacity(200);
		Assert.IsTrue(sb.Capacity >= 200, "Third capacity should be at least 200.");

		// Content should be preserved through all calls
		Assert.AreEqual("Initial", sb.ToString(), "Content should be preserved after multiple SetCapacity calls.");
	}

	[TestMethod]
	public void SetCapacityNegativeCapacityTest()
	{
		var sb = new StringBuilder("Test");

		// Attempt to set negative capacity should throw ArgumentOutOfRangeException
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => sb.SetCapacity(-1));
	}

	[TestMethod]
	public void SetCapacityNullStringBuilderTest()
	{
		StringBuilder sb = null;

		// Attempt to call SetCapacity on null StringBuilder should throw ArgumentNullException
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.SetCapacity(100));
	}

	[TestMethod]
	public void SetCapacityPreservesContentTest()
	{
		var sb = new StringBuilder();
		var testString = RandomData.GenerateWord(50);
		sb.Append(testString);

		var originalContent = sb.ToString();
		var newCapacity = 200;

		// Call SetCapacity
		sb.SetCapacity(newCapacity);

		// Verify content is preserved
		Assert.AreEqual(originalContent, sb.ToString(), "StringBuilder content should be preserved after SetCapacity.");
		Assert.AreEqual(testString.Length, sb.Length, "StringBuilder length should remain unchanged.");
	}

	[TestMethod]
	public void SetCapacityTest()
	{
		var sb = new StringBuilder("Hello World");
		var originalLength = sb.Length;
		var newCapacity = 100;

		// Call SetCapacity
		var result = sb.SetCapacity(newCapacity);

		// Verify the content is preserved
		Assert.AreEqual(originalLength, sb.Length, "StringBuilder length should remain unchanged.");
		Assert.AreEqual("Hello World", sb.ToString(), "StringBuilder content should be preserved.");

		// Verify the capacity is set correctly
		Assert.IsTrue(sb.Capacity >= newCapacity, "StringBuilder capacity should be at least the requested capacity.");

		// Verify method chaining works
		Assert.AreSame(sb, result, "SetCapacity should return the same StringBuilder instance for chaining.");
	}

	[TestMethod]
	public void SetCapacityWithEmptyStringBuilderTest()
	{
		var sb = new StringBuilder();
		var newCapacity = 50;

		// Call SetCapacity on empty StringBuilder
		sb.SetCapacity(newCapacity);

		// Verify the capacity is set correctly
		Assert.IsTrue(sb.Capacity >= newCapacity, "StringBuilder capacity should be at least the requested capacity.");
		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty.");
	}

	[TestMethod]
	public void SetCapacityWithMaxCapacityTest()
	{
		var sb = new StringBuilder(capacity: 10, maxCapacity: 50);
		sb.Append("Hello");

		// Set capacity within max capacity
		sb.SetCapacity(40);
		Assert.IsTrue(sb.Capacity >= 40 && sb.Capacity <= 50, "Capacity should be within max capacity limits.");

		// Attempt to exceed max capacity should throw ArgumentOutOfRangeException
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => sb.SetCapacity(100));
	}

	[TestMethod]
	public void SetCapacityZeroCapacityTest()
	{
		var sb = new StringBuilder();

		// Call SetCapacity with zero
		sb.SetCapacity(0);

		// Verify the StringBuilder remains valid
		Assert.AreEqual(0, sb.Length, "StringBuilder length should be zero.");
		Assert.IsTrue(sb.Capacity >= 0, "StringBuilder capacity should be non-negative.");
	}

}
