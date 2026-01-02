// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-02-2026
// ***********************************************************************
// <copyright file="KeyGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class KeyGeneratorTests
{

	[TestMethod]
	public void GenerateCustomKey_ItemsWithSpecialCharacters_ShouldWork()
	{
		// Arrange
		var items = new[] { "A$", "B#", "C%" };
		var separator = '+';

		// Act
		var key = KeyGenerator.GenerateCustomKey(separator, false, items);

		// Assert
		Assert.AreEqual("A$+B#+C%", key, "Key should join items with special characters.");
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
		Assert.IsTrue(keyWithTimestamp.StartsWith("Person_Ref_"), "Key with timestamp should start with joined items and separator.");

		Assert.IsTrue(keyWithoutTimestamp.StartsWith("Person_Ref_"), "Key with timestamp should start with joined items and separator.");
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
		Assert.AreEqual("A|B|C", key, "Key should use the provided separator.");
	}

	[TestMethod]
	public void GenerateCustomKey_WithNullItems_ShouldThrowArgumentException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => KeyGenerator.GenerateCustomKey('-', true, null));
	}

	[TestMethod]
	public void GenerateCustomKey_WithoutTimeStamp_ShouldReturnJoinedItemsOnly()
	{
		// Arrange
		var items = new[] { "User", "Admin" };
		var separator = '-';

		// Act
		var key = KeyGenerator.GenerateCustomKey(separator, false, items);

		// Assert
		Assert.AreEqual("User-Admin", key, "Key should be joined items only when addTimeStamp is false.");
	}

	[TestMethod]
	public void GenerateCustomKey_WithTimeStamp_ShouldReturnJoinedItemsWithUniqueKey()
	{
		// Arrange
		var items = new[] { "User", "Admin" };
		var separator = '_';

		// Act
		var key = KeyGenerator.GenerateCustomKey(separator, true, items);

		// Assert
		Assert.IsTrue(key.StartsWith("User_Admin"), "Key should start with joined items.");
		var parts = key.Split(separator);
		Assert.AreEqual(3, parts.Length, "Key should have three parts when addTimeStamp is true.");
		Assert.AreEqual("User", parts[0]);
		Assert.AreEqual("Admin", parts[1]);
		Assert.AreEqual(32, parts[2].Length, "Unique key part should be 32 characters.");
		Assert.IsTrue(Guid.TryParseExact(parts[2], "N", out var _), "Unique key part should be a valid GUID without dashes.");
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
	public void GenerateKey_WithPrefix_ShouldReturnValidPrefixedGuidString()
	{
		// Arrange
		var prefix = "Prefix";

		// Act
		var key = KeyGenerator.GenerateKey(prefix);

		// Assert
		Assert.IsTrue(key.StartsWith(prefix), "Generated key should start with the provided prefix.");
		var guidPart = key.Substring(prefix.Length);
		Assert.AreEqual(32, guidPart.Length, "The GUID part of the generated key should have a length of 32 characters (GUID without dashes).");

		var isValidGuid = Guid.TryParseExact(guidPart, "N", out var _);
		Assert.IsTrue(isValidGuid, "The GUID part of the generated key should be a valid GUID without dashes.");
	}
	[TestMethod]
	public void GenerateSortableKey_ShouldReturnValidGuidString()
	{
		// Act
		var key = KeyGenerator.GenerateSortableKey();

		// Assert
		Assert.IsFalse(string.IsNullOrWhiteSpace(key), "Generated sortable key should not be null or whitespace.");
		Assert.AreEqual(32, key.Length, "Generated sortable key should have a length of 32 characters (GUID without dashes).");

		var isValidGuid = Guid.TryParseExact(key, "N", out var parsedGuid);
		Assert.IsTrue(isValidGuid, "Generated sortable key should be a valid GUID without dashes.");
		Assert.IsNotNull(parsedGuid, "Parsed GUID should not be null.");
	}

	[TestMethod]
	public void GenerateSortableKey_WithNullPrefix_ShouldThrowArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => KeyGenerator.GenerateSortableKey(null));
	}

	[TestMethod]
	public void GenerateSortableKey_WithPrefix_ShouldReturnValidPrefixedGuidString()
	{
		// Arrange
		var prefix = "DataRecord";

		// Act
		var key = KeyGenerator.GenerateSortableKey(prefix);

		// Assert
		Assert.IsTrue(key.StartsWith(prefix), "Generated sortable key should start with the provided prefix.");
		var guidPart = key.Substring(prefix.Length);
		Assert.AreEqual(32, guidPart.Length, "The GUID part of the generated sortable key should have a length of 32 characters (GUID without dashes).");

		var isValidGuid = Guid.TryParseExact(guidPart, "N", out var _);
		Assert.IsTrue(isValidGuid, "The GUID part of the generated sortable key should be a valid GUID without dashes.");
	}

}
