// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 07-11-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="ReadOnlySpanExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ReadOnlySpanExtensionsTests
{

	private const int Count = 256;

	[TestMethod]
	public void BytesToString_EmptySpan_ReturnsEmptyStringTest()
	{
		// Arrange
		ReadOnlySpan<byte> emptySpan = ReadOnlySpan<byte>.Empty;

		// Act
		var result = emptySpan.BytesToString();

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void BytesToString_NonEmptySpan_ReturnsHexStringTest()
	{
		// Arrange
		var bytes = RandomData.GenerateByteArray(Count);
		ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>(bytes);

		// Act
		var result = readOnlySpan.BytesToString();

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.AreEqual(Count * 2, result.Length);
	}

	[TestMethod]
	public void BytesToString_SingleByte_ReturnsCorrectHexStringTest()
	{
		// Arrange
		byte[] bytes = [0xAB];
		ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>(bytes);

		// Act
		var result = readOnlySpan.BytesToString();

		// Assert
		Assert.AreEqual("AB", result);
	}

	[TestMethod]
	public void PickRandom_EmptySpan_ThrowsArgumentNullExceptionTest()
	{
		// Arrange & Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
		{
			ReadOnlySpan<int> emptySpan = ReadOnlySpan<int>.Empty;
			emptySpan.PickRandom();
		});
	}

	[TestMethod]
	public void PickRandom_MultipleCalls_ReturnsDifferentElementsTest()
	{
		// Arrange
		var array = Enumerable.Range(1, Count).ToArray();
		ReadOnlySpan<int> span = new ReadOnlySpan<int>(array);

		// Act - pick multiple times to ensure randomness
		var results = new int[10];

		for (var i = 0; i < results.Length; i++)
		{
			results[i] = span.PickRandom();
		}

		// Assert - at least two distinct values should appear
		Assert.IsTrue(results.Distinct().Count() > 1);
	}

	[TestMethod]
	public void PickRandom_NonEmptySpan_ReturnsElementFromSpanTest()
	{
		// Arrange
		var array = Enumerable.Range(1, Count).ToArray();
		ReadOnlySpan<int> span = new ReadOnlySpan<int>(array);

		// Act
		var result = span.PickRandom();

		// Assert
		Assert.IsTrue(span.Contains(result));
	}

	[TestMethod]
	public void PickRandom_SingleElementSpan_ReturnsThatElementTest()
	{
		// Arrange
		var value = RandomData.GenerateInteger(1, 1000);
		int[] array = [value];
		ReadOnlySpan<int> span = new ReadOnlySpan<int>(array);

		// Act
		var result = span.PickRandom();

		// Assert
		Assert.AreEqual(value, result);
	}

}
