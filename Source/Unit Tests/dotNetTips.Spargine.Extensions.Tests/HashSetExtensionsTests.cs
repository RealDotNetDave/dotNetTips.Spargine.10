// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 04-14-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-14-2026
// ***********************************************************************
// <copyright file="HashSetExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class HashSetExtensionsTests
{

	[TestMethod]
	public void ToImmutable_WithComparer_UsesCaseInsensitiveComparer()
	{
		// Arrange
		var collection = new HashSet<string>(["hello", "HELLO", "World"]);

		// Act
		var result = collection.ToImmutable(StringComparer.OrdinalIgnoreCase);

		// Assert — comparer applied to immutable set means lookups are case-insensitive
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Contains("HELLO"));
		Assert.IsTrue(result.Contains("world"));
		Assert.AreEqual(result.KeyComparer, StringComparer.OrdinalIgnoreCase);
	}

	[TestMethod]
	public void ToImmutable_WithNullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		HashSet<string> collection = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => collection.ToImmutable(StringComparer.OrdinalIgnoreCase));
	}

	[TestMethod]
	public void ToImmutable_WithNullComparer_UsesDefaultComparer()
	{
		// Arrange
		var collection = new HashSet<string>(["hello", "World"]);

		// Act
		var result = collection.ToImmutable(null);

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(2, result);
		Assert.IsTrue(result.Contains("hello"));
		Assert.IsTrue(result.Contains("World"));
	}

}
