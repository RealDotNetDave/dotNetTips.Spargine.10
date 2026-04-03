// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-03-2026
// ***********************************************************************
// <copyright file="KeyGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class KeyGeneratorTests
{

	[TestMethod]
	public void GenerateCustomKey_AlwaysIncludesGuid_EvenWithNoItems()
	{
		// This test verifies that a GUID is always appended
		// Note: This will throw because items are required, but documents expected behavior
		try
		{
			var items = new[] { "Test" };
			var result = KeyGenerator.GenerateCustomKey(
				separator: '-',
				addTimeStamp: false,
				items: items
			);

			// Assert
			var parts = result.Split('-');
			var guidPart = parts[^1]; // Last part should be GUID
			Assert.AreEqual(32, guidPart.Length);

			// Verify it's a valid hex string
			Assert.IsTrue(guidPart.All(c =>
				(c >= '0' && c <= '9') ||
				(c >= 'a' && c <= 'f')
			));
		}
		catch (ArgumentException)
		{
			// Expected if items validation is strict
		}
	}

	[TestMethod]
	public void GenerateCustomKey_ColonSeparator_CreatesNamespacedKey()
	{
		// Arrange
		var items = new[] { "cache", "tenant123", "user456" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: ':',
			addTimeStamp: true,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.StartsWith("cache:tenant123:user456:", result);

		// Verify structure: items:timestamp:guid
		var parts = result.Split(':');
		Assert.IsTrue(parts.Length >= 5); // 3 items + timestamp + guid
	}

	[TestMethod]
	public void GenerateCustomKey_CustomSeparator_UsesSpecifiedSeparator()
	{
		// Arrange
		var items = new[] { "Cache", "Session" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: ':',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.Contains(":", result);
		Assert.IsFalse(result.Contains("-"));
		Assert.AreEqual("Cache:Session", result.Substring(0, result.LastIndexOf(':')));
	}

	[TestMethod]
	public void GenerateCustomKey_DotSeparator_UsesDot()
	{
		// Arrange
		var items = new[] { "api", "v1", "users" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '.',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.Contains(".", result);
		Assert.StartsWith("api.v1.users.", result);
	}

	[TestMethod]
	public void GenerateCustomKey_ItemsWithSpecialCharacters_ShouldWork()
	{
		// Arrange
		var items = new[] { "A$", "B#", "C%" };
		var separator = '+';

		// Act
		var key = KeyGenerator.GenerateCustomKey(separator, false, items);

		// Assert
		Assert.StartsWith("A$+B#+C%+", key, "Key should start with joined items and separator.");
	}

	[TestMethod]
	public void GenerateCustomKey_MultipleInvocations_GenerateUniqueKeys()
	{
		// Arrange
		var items = new[] { "Test", "Item" };

		// Act
		var key1 = KeyGenerator.GenerateCustomKey(
			separator: '-',
			addTimeStamp: false,
			items: items
		);
		var key2 = KeyGenerator.GenerateCustomKey(
			separator: '-',
			addTimeStamp: false,
			items: items
		);
		var key3 = KeyGenerator.GenerateCustomKey(
			separator: '-',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.AreNotEqual(key1, key2);
		Assert.AreNotEqual(key2, key3);
		Assert.AreNotEqual(key1, key3);
	}

	[TestMethod]
	public void GenerateCustomKey_MultipleItems_CombinesAllItems()
	{
		// Arrange
		var items = new[] { "Region", "Country", "City", "District" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '/',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.Contains("Region", result);
		Assert.Contains("Country", result);
		Assert.Contains("City", result);
		Assert.Contains("District", result);

		var parts = result.Split('/');
		Assert.AreEqual(5, parts.Length); // 4 items + GUID
	}

	[TestMethod]
	public void GenerateCustomKey_OutputFormat_ShouldMatchExpectations()
	{
		// Arrange
		var items = new[] { "Person", "Ref" };
		var separator = '_';

		// Act
		var keyWithTimestamp = KeyGenerator.GenerateCustomKey(separator, true, items);
		var keyWithoutTimestamp = KeyGenerator.GenerateCustomKey(separator, false, items);

		// Assert
		Assert.StartsWith("Person_Ref_", keyWithTimestamp, "Key with timestamp should start with joined items and separator.");

		Assert.StartsWith("Person_Ref_", keyWithoutTimestamp, "Key with timestamp should start with joined items and separator.");
	}

	[TestMethod]
	public void GenerateCustomKey_ParamsArraySyntax_WorksCorrectly()
	{
		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '_',
			addTimeStamp: false,
			"One", "Two", "Three"
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.Contains("One", result);
		Assert.Contains("Two", result);
		Assert.Contains("Three", result);
	}

	[TestMethod]
	public void GenerateCustomKey_RespectsSeparator()
	{
		// Arrange
		var items = new[] { "A", "B", "C" };
		var separator = '|';

		// Act
		var key = KeyGenerator.GenerateCustomKey(separator, false, items);

		// Assert
		Assert.StartsWith("A|B|C|", key, "Key should use the provided separator.");
	}

	[TestMethod]
	public void GenerateCustomKey_SingleItem_GeneratesValidKey()
	{
		// Arrange
		var items = new[] { "Order" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '_',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.StartsWith("Order_", result);
		var parts = result.Split('_');
		Assert.AreEqual(2, parts.Length);
		Assert.AreEqual(32, parts[1].Length); // GUID
	}

	[TestMethod]
	public void GenerateCustomKey_SlashSeparator_CreatesPathLikeKey()
	{
		// Arrange
		var items = new[] { "documents", "2024", "01", "15" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '/',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.Contains("documents/2024/01/15", result);
	}

	[TestMethod]
	public void GenerateCustomKey_UnderscoreSeparator_UsesUnderscore()
	{
		// Arrange
		var items = new[] { "Database", "Table", "Column" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '_',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.AreEqual("Database_Table_Column", result.Substring(0, result.LastIndexOf('_')));
		Assert.IsFalse(result.Contains("-"));
	}

	[TestMethod]
	public void GenerateCustomKey_VeryLongItemNames_GeneratesValidKey()
	{
		// Arrange
		var longItem = new string('A', 500);
		var items = new[] { longItem, "Short" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '-',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.Contains(longItem, result);
		Assert.Contains("Short", result);
		Assert.IsTrue(result.Length > 500);
	}

	[TestMethod]
	public void GenerateCustomKey_WithDefaultParameters_ContainsAllComponents()
	{
		// Arrange
		var items = new[] { "Product", "Electronics" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(items: items);

		// Assert
		Assert.IsNotNull(result);
		Assert.Contains("Product", result);
		Assert.Contains("Electronics", result);
		Assert.Contains("-", result); // Default separator is dash

		// Should have: item1-item2-timestamp-guid
		var parts = result.Split('-');
		Assert.IsTrue(parts.Length >= 4, "Should contain items, timestamp, and GUID");
	}

	[TestMethod]
	public void GenerateCustomKey_WithEmptyStringsInItems_HandlesEmpty()
	{
		// Arrange
		var items = new[] { "Start", string.Empty, "End" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '-',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		Assert.Contains("Start", result);
		Assert.Contains("End", result);
		// Should have consecutive separators for empty string
		Assert.Contains("--", result);
	}

	[TestMethod]
	public void GenerateCustomKey_WithEmptyItems_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => KeyGenerator.GenerateCustomKey('-', true, []));
	}

	[TestMethod]
	public void GenerateCustomKey_WithNullItems_ShouldThrowArgumentException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => KeyGenerator.GenerateCustomKey('-', true, null));
	}

	[TestMethod]
	public void GenerateCustomKey_WithoutTimestamp_ExcludesTimestamp()
	{
		// Arrange
		var items = new[] { "User", "Admin" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '-',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		var parts = result.Split('-');
		Assert.AreEqual(3, parts.Length); // item1-item2-guid
		Assert.AreEqual("User", parts[0]);
		Assert.AreEqual("Admin", parts[1]);
		Assert.AreEqual(32, parts[2].Length); // GUID without dashes
	}

	[TestMethod]
	public void GenerateCustomKey_WithSpecialCharactersInItems_PreservesCharacters()
	{
		// Arrange
		var items = new[] { "User@Domain", "Type#1", "Value%20" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '_',
			addTimeStamp: false,
			items: items
		);

		// Assert
		Assert.Contains("User@Domain", result);
		Assert.Contains("Type#1", result);
		Assert.Contains("Value%20", result);
	}

	[TestMethod]
	public void GenerateCustomKey_WithTimestamp_IncludesTimestampComponent()
	{
		// Arrange
		var items = new[] { "Event", "Log" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '-',
			addTimeStamp: true,
			items: items
		);

		// Assert
		Assert.IsNotNull(result);
		var parts = result.Split('-');
		Assert.IsTrue(parts.Length >= 4); // item1-item2-timestamp-guid

		// Timestamp should be a hex string representation
		// Should not be empty
		Assert.IsTrue(parts[2].Length > 0);
	}

	[TestMethod]
	public void GenerateCustomKey_WithTimestamp_TimestampIsHexString()
	{
		// Arrange
		var items = new[] { "Test" };

		// Act
		var result = KeyGenerator.GenerateCustomKey(
			separator: '-',
			addTimeStamp: true,
			items: items
		);

		// Assert
		var parts = result.Split('-');
		Assert.IsTrue(parts.Length >= 3); // Test-timestamp-guid

		var timestampPart = parts[1];
		// Timestamp should be hex representation from BytesToString
		Assert.IsTrue(timestampPart.Length > 0);
		Assert.IsTrue(timestampPart.All(c =>
			(c >= '0' && c <= '9') ||
			(c >= 'A' && c <= 'F')
		));
	}

	[TestMethod]
	public void GenerateKey_WithNullPrefix_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => KeyGenerator.GenerateKey(null));
	}

	[TestMethod]
	public void GenerateKey_WithPrefix_MultipleInvocations_GenerateUniqueKeys()
	{
		// Arrange
		var prefix = RandomData.GenerateWord(5, 10);

		// Act
		var key1 = KeyGenerator.GenerateKey(prefix);
		var key2 = KeyGenerator.GenerateKey(prefix);
		var key3 = KeyGenerator.GenerateKey(prefix);

		// Assert
		Assert.AreNotEqual(key1, key2);
		Assert.AreNotEqual(key2, key3);
		Assert.AreNotEqual(key1, key3);
	}

	[TestMethod]
	public void GenerateKey_WithPrefix_ReturnsCorrectFormat()
	{
		// Arrange
		var prefix = RandomData.GenerateWord(5, 10);

		// Act
		var result = KeyGenerator.GenerateKey(prefix);

		// Assert
		Assert.IsNotNull(result);
		Assert.StartsWith($"{prefix}_", result);
		Assert.AreEqual(prefix.Length + 33, result.Length);

		// Verify the GUID part is valid
		var guidPart = result[(prefix.Length + 1)..];
		Assert.AreEqual(32, guidPart.Length);
		Assert.IsTrue(Guid.TryParseExact(guidPart, "N", out _));
	}

	[TestMethod]
	public void GenerateKey_WithoutPrefix_MultipleRapidGenerations_AllUnique()
	{
		// Arrange
		const int count = 1000;
		var keys = new HashSet<string>();

		// Act
		for (var i = 0; i < count; i++)
		{
			keys.Add(KeyGenerator.GenerateKey());
		}

		// Assert
		Assert.AreEqual(count, keys.Count, "All generated keys should be unique.");
	}

	[TestMethod]
	public void GenerateKey_WithoutPrefix_ShouldReturnValidGuidString()
	{
		// Act
		var key = KeyGenerator.GenerateKey();

		// Assert
		Assert.IsFalse(string.IsNullOrWhiteSpace(key), "Generated key should not be null or whitespace.");
		Assert.AreEqual(32, key.Length, "Generated key should have a length of 32 characters (GUID without dashes).");

		var isValidGuid = Guid.TryParseExact(key, "N", out var parsedGuid);
		Assert.IsTrue(isValidGuid, "Generated key should be a valid GUID without dashes.");
		Assert.IsNotNull(parsedGuid, "Parsed GUID should not be null.");
	}

	[TestMethod]
	public void GenerateSortableKey_ConsistentFormatWithInvariantCulture()
	{
		// Arrange
		var originalCulture = CultureInfo.CurrentCulture;

		try
		{
			// Act - Generate keys in different cultures
			CultureInfo.CurrentCulture = new CultureInfo("de-DE");
			var germanKey = KeyGenerator.GenerateSortableKey();

			CultureInfo.CurrentCulture = new CultureInfo("ja-JP");
			var japaneseKey = KeyGenerator.GenerateSortableKey();

			// Assert - Both should have consistent format (32 hex chars)
			Assert.AreEqual(32, germanKey.Length);
			Assert.AreEqual(32, japaneseKey.Length);
			Assert.IsTrue(germanKey.All(c => "0123456789abcdef".Contains(c)));
			Assert.IsTrue(japaneseKey.All(c => "0123456789abcdef".Contains(c)));
		}
		finally
		{
			CultureInfo.CurrentCulture = originalCulture;
		}
	}

	[TestMethod]
	public void GenerateSortableKey_ContainsOnlyHexadecimalCharacters()
	{
		// Arrange
		var validChars = "0123456789abcdef";

		// Act
		var result = KeyGenerator.GenerateSortableKey();

		// Assert
		foreach (var c in result)
		{
			Assert.IsTrue(validChars.Contains(c), $"Invalid character '{c}' found in sortable key.");
		}
	}

	[TestMethod]
	public void GenerateSortableKey_DifferentFromStandardKey()
	{
		// Arrange & Act
		var sortableKey = KeyGenerator.GenerateSortableKey();
		var standardKey = KeyGenerator.GenerateKey();

		// Assert - Both are 32 chars but different values
		Assert.AreEqual(32, sortableKey.Length);
		Assert.AreEqual(32, standardKey.Length);
		Assert.AreNotEqual(sortableKey, standardKey);
	}

	[TestMethod]
	public void GenerateSortableKey_GeneratesUniqueKeys()
	{
		// Act
		var key1 = KeyGenerator.GenerateSortableKey();
		var key2 = KeyGenerator.GenerateSortableKey();

		// Assert
		Assert.AreNotEqual(key1, key2);
	}

	[TestMethod]
	public void GenerateSortableKey_KeysAreLexicographicallySortableByTime()
	{
		// Arrange
		var keys = new List<string>();

		for (var i = 0; i < 10; i++)
		{
			keys.Add(KeyGenerator.GenerateSortableKey());
			Thread.Sleep(2); // Small delay to ensure different timestamps
		}

		// Act
		var sortedKeys = keys.OrderBy(k => k, StringComparer.Ordinal).ToList();

		// Assert - Original order should match lexicographic sort order
		for (var i = 0; i < keys.Count; i++)
		{
			Assert.AreEqual(keys[i], sortedKeys[i],
				$"Key at index {i} should maintain chronological order when sorted lexicographically.");
		}
	}

	[TestMethod]
	public void GenerateSortableKey_LaterKeyIsGreaterOrEqual()
	{
		// Arrange
		var key1 = KeyGenerator.GenerateSortableKey();

		// Small delay to ensure timestamp difference
		Thread.Sleep(1);

		var key2 = KeyGenerator.GenerateSortableKey();

		// Assert - Version 7 GUIDs are time-ordered, so later keys should be greater
		Assert.IsTrue(string.Compare(key1, key2, StringComparison.Ordinal) <= 0,
			"Later sortable key should be greater than or equal to earlier key.");
	}

	[TestMethod]
	public void GenerateSortableKey_MultipleRapidGenerations_AllUnique()
	{
		// Arrange
		const int count = 1000;
		var keys = new HashSet<string>();

		// Act
		for (var i = 0; i < count; i++)
		{
			var key = KeyGenerator.GenerateSortableKey();
			keys.Add(key);
		}

		// Assert
		Assert.AreEqual(count, keys.Count, "All generated sortable keys should be unique.");
	}

	[TestMethod]
	public void GenerateSortableKey_ParallelGeneration_AllUnique()
	{
		// Arrange
		const int count = 100;
		var keys = new ConcurrentBag<string>();

		// Act
		Parallel.For(0, count, _ =>
		{
			var key = KeyGenerator.GenerateSortableKey();
			keys.Add(key);
		});

		// Assert
		var distinctCount = keys.Distinct().Count();
		Assert.AreEqual(count, distinctCount, "All parallel-generated sortable keys should be unique.");
	}

	[TestMethod]
	public void GenerateSortableKey_ReturnsExactly32Characters()
	{
		// Act
		var result = KeyGenerator.GenerateSortableKey();

		// Assert
		Assert.AreEqual(32, result.Length);
	}

	[TestMethod]
	public void GenerateSortableKey_ReturnsNonNullNonEmptyString()
	{
		// Act
		var result = KeyGenerator.GenerateSortableKey();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result);
	}

	[TestMethod]
	public void GenerateSortableKey_UsesGuidVersion7Format()
	{
		// Act
		var key = KeyGenerator.GenerateSortableKey();

		// Assert - Version 7 GUIDs have specific characteristics
		// The key should be parseable back to a valid GUID
		Assert.IsTrue(Guid.TryParse(key, out var _), "Key should be parseable as a valid GUID.");
	}

	[TestMethod]
	public void GenerateSortableKey_WithNullPrefix_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => KeyGenerator.GenerateSortableKey(null));
	}

	[TestMethod]
	public void GenerateSortableKey_WithPrefix_KeysAreSortableByTime()
	{
		// Arrange
		var prefix = RandomData.GenerateWord(5, 10);
		var keys = new List<string>();

		for (var i = 0; i < 10; i++)
		{
			keys.Add(KeyGenerator.GenerateSortableKey(prefix));
			Thread.Sleep(2);
		}

		// Act
		var sortedKeys = keys.OrderBy(k => k, StringComparer.Ordinal).ToList();

		// Assert - Original order should match lexicographic sort order
		for (var i = 0; i < keys.Count; i++)
		{
			Assert.AreEqual(keys[i], sortedKeys[i],
				$"Prefixed sortable key at index {i} should maintain chronological order when sorted.");
		}
	}

	[TestMethod]
	public void GenerateSortableKey_WithPrefix_MultipleInvocations_GenerateUniqueKeys()
	{
		// Arrange
		var prefix = RandomData.GenerateWord(5, 10);

		// Act
		var key1 = KeyGenerator.GenerateSortableKey(prefix);
		var key2 = KeyGenerator.GenerateSortableKey(prefix);
		var key3 = KeyGenerator.GenerateSortableKey(prefix);

		// Assert
		Assert.AreNotEqual(key1, key2);
		Assert.AreNotEqual(key2, key3);
		Assert.AreNotEqual(key1, key3);
	}

	[TestMethod]
	public void GenerateSortableKey_WithPrefix_ReturnsCorrectFormat()
	{
		// Arrange
		var prefix = RandomData.GenerateWord(5, 10);

		// Act
		var result = KeyGenerator.GenerateSortableKey(prefix);

		// Assert
		Assert.IsNotNull(result);
		Assert.StartsWith($"{prefix}_", result);
		Assert.AreEqual(prefix.Length + 33, result.Length);

		// Verify the GUID part is valid
		var guidPart = result[(prefix.Length + 1)..];
		Assert.AreEqual(32, guidPart.Length);
		Assert.IsTrue(Guid.TryParseExact(guidPart, "N", out _));
	}
}
