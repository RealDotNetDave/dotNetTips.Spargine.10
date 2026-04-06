// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
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

		Assert.AreEqual(0, sb.Length);
	}

	[TestMethod]
	public void AppendBytesTest()
	{
		var sb = new StringBuilder();
		var byteArray = RandomData.GenerateByteArray(256);
		sb.AppendBytes(byteArray);

		Assert.IsGreaterThan(50, sb.Length);
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

		Assert.IsGreaterThan(50 * 4, sb.ToString().Length);

		var pool = new StringBuilder();

		foreach (var person in people)
		{
			pool.AppendKeyValue(person.Key, person.Value.Email);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeComma: true);
			pool.AppendKeyValue(person.Key, person.Value.Email, includeQuotes: true, includeComma: true);
		}

		Assert.IsGreaterThan(50 * 4, pool.ToString().Length);
	}

	[TestMethod]
	public void AppendValues01()
	{
		var sb = new StringBuilder();
		var values = RandomData.GenerateWords(count: 5, minLength: 5, maxLength: 7);

		sb.AppendValues(ControlChars.CommaSpace, values);

		Assert.IsGreaterThan(10, sb.Length);

		var pool = new StringBuilder();

		pool.AppendValues(", ", values);

		Assert.IsGreaterThan(10, pool.Length);
	}

	[TestMethod]
	public void AppendValues02()
	{
		var sb = new StringBuilder();

		sb.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

		Assert.IsGreaterThan(10, sb.Length);

		var pool = new StringBuilder();

		pool.AppendValues(", ", RandomData.GenerateWord(100), RandomData.GenerateWord(100));

		Assert.IsGreaterThan(10, pool.Length);
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

		Assert.IsGreaterThan(0, sb.Length, "StringBuilder should contain formatted values.");

		var pool = new StringBuilder();

		pool.AppendValues(separator, values, format, (person, fmt) =>
		{
			_ = pool.AppendFormat(fmt, person.FirstName, person.LastName);
		});

		Assert.IsGreaterThan(0, pool.Length, "StringBuilder should contain formatted values in the pool instance.");
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

		Assert.IsGreaterThan(0, sb.Length, "StringBuilder should contain formatted values.");
		var pool = new StringBuilder();

		pool.AppendValues(separator, values, "ExtraParam1", "ExtraParam2", (StringBuilder builder, Person person, string param1, string param2) =>
		{
			_ = builder.AppendFormat(format, person.FirstName, person.LastName, person.Addresses, param1, param2);
		});

		Assert.IsGreaterThan(0, pool.Length, "StringBuilder should contain formatted values in the pool instance.");
	}

	[TestMethod]
	public void ClearSetCapacityNegativeCapacityTest()
	{
		var sb = new StringBuilder("Initial content");
		int newCapacity = -1;

		// Ensure the StringBuilder has initial content
		Assert.IsGreaterThan(0, sb.Length, "StringBuilder should have initial content.");

		// Call ClearSetCapacity
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => sb.ClearSetCapacity(newCapacity));

		// Verify the StringBuilder is cleared
		Assert.AreEqual(0, sb.Length, "StringBuilder should be cleared.");

		// Verify the capacity is set correctly
		Assert.IsGreaterThanOrEqualTo(0, sb.Capacity, "StringBuilder capacity should be non-negative.");
	}
	[TestMethod]
	public void ClearSetCapacityTest()
	{
		var sb = new StringBuilder("Initial content");
		int newCapacity = 100;

		// Ensure the StringBuilder has initial content
		Assert.IsGreaterThan(0, sb.Length, "StringBuilder should have initial content.");

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
		Assert.IsGreaterThan(0, sb.Length, "StringBuilder should have initial content.");

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
		Assert.IsGreaterThanOrEqualTo(500, sb.Capacity, "Capacity should be at least 500.");
	}

	[TestMethod]
	public void SetCapacityComparisonWithClearSetCapacityTest()
	{
		var sb1 = new StringBuilder("Test Content");
		var sb2 = new StringBuilder("Test Content");

		// Use SetCapacity (preserves content)
		sb1.SetCapacity(100);
		Assert.AreEqual("Test Content", sb1.ToString(), "SetCapacity should preserve content.");
		Assert.IsGreaterThanOrEqualTo(100, sb1.Capacity, "Capacity should be set correctly.");

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
		Assert.IsGreaterThanOrEqualTo(200, sb.Capacity, "Final capacity should be at least 200.");
	}

	[TestMethod]
	public void SetCapacityMultipleCallsTest()
	{
		var sb = new StringBuilder("Initial");

		// Call SetCapacity multiple times with increasing capacities
		sb.SetCapacity(50);
		Assert.IsGreaterThanOrEqualTo(50, sb.Capacity, "First capacity should be at least 50.");

		sb.SetCapacity(100);
		Assert.IsGreaterThanOrEqualTo(100, sb.Capacity, "Second capacity should be at least 100.");

		sb.SetCapacity(200);
		Assert.IsGreaterThanOrEqualTo(200, sb.Capacity, "Third capacity should be at least 200.");

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
		Assert.IsGreaterThanOrEqualTo(newCapacity, sb.Capacity, "StringBuilder capacity should be at least the requested capacity.");

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
		Assert.IsGreaterThanOrEqualTo(newCapacity, sb.Capacity, "StringBuilder capacity should be at least the requested capacity.");
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
		Assert.IsGreaterThanOrEqualTo(0, sb.Capacity, "StringBuilder capacity should be non-negative.");
	}

	[TestMethod]
	public void AppendBytesEmptyArrayTest()
	{
		var sb = new StringBuilder();

		sb.AppendBytes([]);

		Assert.AreEqual("'0x'", sb.ToString());
	}

	[TestMethod]
	public void AppendKeyValueNullValueTest()
	{
		var sb = new StringBuilder();

		sb.AppendKeyValue("TestKey", null);

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty when value is null.");
	}

	[TestMethod]
	public void AppendKeyValueNullKeyTest()
	{
		var sb = new StringBuilder();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.AppendKeyValue(null, "TestValue"));
	}

	[TestMethod]
	public void AppendKeyValueNoQuotesNoCommaTest()
	{
		var sb = new StringBuilder();
		var key = "Name";
		var value = RandomData.GenerateWord(10);

		sb.AppendKeyValue(key, value, includeQuotes: false, includeComma: false);

		var result = sb.ToString();

		Assert.AreEqual($"{key}={value}", result, "Should format as key=value without quotes or comma.");
	}

	[TestMethod]
	public void AppendKeyValueWithQuotesNoCommaTest()
	{
		var sb = new StringBuilder();
		var key = "Name";
		var value = RandomData.GenerateWord(10);

		sb.AppendKeyValue(key, value, includeQuotes: true, includeComma: false);

		var result = sb.ToString();

		Assert.AreEqual($"{key}=\"{value}\"", result, "Should format as key=\"value\" without comma.");
	}

	[TestMethod]
	public void AppendKeyValueNoQuotesWithCommaTest()
	{
		var sb = new StringBuilder();
		var key = "Name";
		var value = RandomData.GenerateWord(10);

		sb.AppendKeyValue(key, value, includeQuotes: false, includeComma: true);

		var result = sb.ToString();

		Assert.AreEqual($"{key}={value}{ControlChars.DefaultSeparator}", result, "Should format as key=value with comma separator.");
	}

	[TestMethod]
	public void AppendKeyValueWithQuoteInValueTest()
	{
		var sb = new StringBuilder();
		var key = "Path";
		var value = "hello\"world";

		sb.AppendKeyValue(key, value, includeQuotes: true, includeComma: false);

		var result = sb.ToString();

		Assert.IsTrue(result.Contains("\\\""), "Double quote in value should be escaped with backslash.");
		Assert.AreEqual("Path=\"hello\\\"world\"", result);
	}

	[TestMethod]
	public void AppendKeyValueWithBackslashInValueTest()
	{
		var sb = new StringBuilder();
		var key = "Path";
		var value = "C:\\path";

		sb.AppendKeyValue(key, value, includeQuotes: true, includeComma: false);

		var result = sb.ToString();

		Assert.IsTrue(result.Contains("\\\\"), "Backslash in value should be escaped with backslash.");
		Assert.AreEqual("Path=\"C:\\\\path\"", result);
	}

	[TestMethod]
	public void AppendValuesNullValuesStringTest()
	{
		var sb = new StringBuilder();
		IEnumerable<string> nullValues = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.AppendValues(ControlChars.CommaSpace, nullValues));
	}

	[TestMethod]
	public void AppendValuesEmptyCollectionStringTest()
	{
		var sb = new StringBuilder();
		var emptyValues = Enumerable.Empty<string>();

		sb.AppendValues(", ", emptyValues);

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty for an empty collection.");
	}

	[TestMethod]
	public void AppendValuesWithEmptySeparatorTest()
	{
		var sb = new StringBuilder();
		var values = RandomData.GenerateWords(count: 3, minLength: 5, maxLength: 7);

		sb.AppendValues(string.Empty, values);

		Assert.IsGreaterThan(0, sb.Length);
		Assert.IsTrue(sb.ToString().Contains(ControlChars.DefaultSeparator), "Should use default separator when empty separator is provided.");
	}

	[TestMethod]
	public void AppendValuesGenericWithJoinActionTest()
	{
		var sb = new StringBuilder();
		var people = RandomData.GeneratePersonRefCollection(count: 5);

		sb.AppendValues(", ", people, (person) => sb.Append(person.FirstName));

		Assert.IsGreaterThan(0, sb.Length, "StringBuilder should contain appended values.");
	}

	[TestMethod]
	public void AppendValuesGenericNullValuesTest()
	{
		var sb = new StringBuilder();
		IEnumerable<string> nullValues = null;

		sb.AppendValues(", ", nullValues, (value) => sb.Append(value));

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty when values is null.");
	}

	[TestMethod]
	public void AppendValuesGenericNullJoinActionTest()
	{
		var sb = new StringBuilder();
		var values = RandomData.GenerateWords(count: 3, minLength: 5, maxLength: 7);
		Action<string> nullAction = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.AppendValues(", ", values, nullAction));
	}

	[TestMethod]
	public void AppendValuesGenericEmptyCollectionTest()
	{
		var sb = new StringBuilder();
		var emptyValues = new List<string>();

		sb.AppendValues(", ", emptyValues, (value) => sb.Append(value));

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty for an empty collection.");
	}

	[TestMethod]
	public void AppendValuesWithParamNullValuesTest()
	{
		var sb = new StringBuilder();
		IEnumerable<Person> nullValues = null;

		sb.AppendValues(", ", nullValues, "format", (person, fmt) =>
		{
			_ = sb.Append(person.FirstName);
		});

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty when values is null.");
	}

	[TestMethod]
	public void AppendValuesWithParamNullParamTest()
	{
		var sb = new StringBuilder();
		var people = RandomData.GeneratePersonRefCollection(count: 3);
		string nullParam = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.AppendValues(", ", people, nullParam, (person, fmt) =>
		{
			_ = sb.Append(person.FirstName);
		}));
	}

	[TestMethod]
	public void AppendValuesWithParamNullJoinActionTest()
	{
		var sb = new StringBuilder();
		var people = RandomData.GeneratePersonRefCollection(count: 3);
		Action<Person, string> nullAction = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.AppendValues(", ", people, "format", nullAction));
	}

	[TestMethod]
	public void AppendValuesWithParamEmptyCollectionTest()
	{
		var sb = new StringBuilder();
		var emptyPeople = new List<Person>();

		sb.AppendValues(", ", emptyPeople, "format", (person, fmt) =>
		{
			_ = sb.Append(person.FirstName);
		});

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty for an empty collection.");
	}

	[TestMethod]
	public void AppendValuesWithTwoParamsNullValuesTest()
	{
		var sb = new StringBuilder();
		IEnumerable<Person> nullValues = null;

		sb.AppendValues(", ", nullValues, "param1", "param2", (StringBuilder builder, Person person, string p1, string p2) =>
		{
			_ = builder.Append(person.FirstName);
		});

		Assert.AreEqual(0, sb.Length, "StringBuilder should remain empty when values is null.");
	}

	[TestMethod]
	public void AppendValuesWithTwoParamsNullParam1Test()
	{
		var sb = new StringBuilder();
		var people = RandomData.GeneratePersonRefCollection(count: 3);
		string nullParam1 = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.AppendValues(", ", people, nullParam1, "param2", (StringBuilder builder, Person person, string p1, string p2) =>
		{
			_ = builder.Append(person.FirstName);
		}));
	}

	[TestMethod]
	public void AppendValuesWithTwoParamsNullParam2Test()
	{
		var sb = new StringBuilder();
		var people = RandomData.GeneratePersonRefCollection(count: 3);
		string nullParam2 = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.AppendValues(", ", people, "param1", nullParam2, (StringBuilder builder, Person person, string p1, string p2) =>
		{
			_ = builder.Append(person.FirstName);
		}));
	}

	[TestMethod]
	public void AppendValuesWithTwoParamsNullJoinActionTest()
	{
		var sb = new StringBuilder();
		var people = RandomData.GeneratePersonRefCollection(count: 3);
		Action<StringBuilder, Person, string, string> nullAction = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.AppendValues(", ", people, "param1", "param2", nullAction));
	}

	[TestMethod]
	public void ClearSetCapacityNullStringBuilderTest()
	{
		StringBuilder sb = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => sb.ClearSetCapacity(100));
	}

	[TestMethod]
	public void ClearSetCapacityMethodChainingTest()
	{
		var sb = new StringBuilder("Hello World");

		var result = sb.ClearSetCapacity(100);

		Assert.AreSame(sb, result, "ClearSetCapacity should return the same StringBuilder instance for chaining.");
		Assert.AreEqual(0, sb.Length, "StringBuilder should be cleared.");
		Assert.AreEqual(100, sb.Capacity, "Capacity should be set to 100.");
	}

}
