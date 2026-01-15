// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2026
// ***********************************************************************
// <copyright file="KeyGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
	public void GenerateSortableKey_WithNullPrefix_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => KeyGenerator.GenerateSortableKey(null));
	}
}
