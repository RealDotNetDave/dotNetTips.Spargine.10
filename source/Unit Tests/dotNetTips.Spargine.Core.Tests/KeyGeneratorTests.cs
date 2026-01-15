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
		Assert.StartsWith("A$+B#+C%+", key, "Key should start with joined items and separator.");
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
	public void GenerateCustomKey_WithNullItems_ShouldThrowArgumentException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => KeyGenerator.GenerateCustomKey('-', true, null));
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
