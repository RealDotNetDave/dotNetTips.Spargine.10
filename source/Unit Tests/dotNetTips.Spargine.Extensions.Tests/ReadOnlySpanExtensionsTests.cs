// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 07-11-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="ReadOnlySpanExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ReadOnlySpanExtensionsTests
{
	[TestMethod]
	public void BytesToStringTest()
	{
		var bytes = RandomData.GenerateByteArray(100);

		var readOnlySpan = new ReadOnlySpan<byte>(bytes);
		var result = readOnlySpan.BytesToString();

		Assert.IsGreaterThan(100, result.Length);
	}

	public int[] CreateArray()
	{
		int[] array = new int[100];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 1;
		}
		return array;
	}

	[TestMethod]
	public void PickRandom_EmptySpan_ThrowsArgumentException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
		{
			ReadOnlySpan<int> emptySpan = new ReadOnlySpan<int>();
			emptySpan.PickRandom();
		});
	}

	[TestMethod]
	public void PickRandom_MultipleCalls_ReturnsDifferentElements()
	{
		ReadOnlySpan<int> span = new ReadOnlySpan<int>(this.CreateArray());
		var result1 = span.PickRandom();
		var result2 = span.PickRandom();

		// Note: This test might occasionally fail due to the random nature of the method, but it's unlikely.
		Assert.AreNotEqual(result1, result2);
	}

	[TestMethod]
	public void PickRandom_NonEmptySpan_ReturnsElementFromSpan()
	{
		ReadOnlySpan<int> span = new ReadOnlySpan<int>(this.CreateArray());
		var result = span.PickRandom();
		Assert.IsTrue(span.Contains(result));
	}

}
