// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="ReadOnlyMemoryExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ReadOnlyMemoryExtensionsTests
{

	[TestMethod]
	public void IsEqualTo_CustomComparer_ReturnsExpectedResult()
	{
		ReadOnlyMemory<string> memory1 = new[] { "Alpha", "Beta" };
		ReadOnlyMemory<string> memory2 = new[] { "ALPHA", "BETA" };

		Assert.IsTrue(memory1.IsEqualTo(memory2, StringComparer.OrdinalIgnoreCase));
		Assert.IsFalse(memory1.IsEqualTo(memory2));
	}

	[TestMethod]
	public void IsEqualTo_DifferentContent_ReturnsFalse()
	{
		ReadOnlyMemory<int> memory1 = new[] { 1, 2, 3 };
		ReadOnlyMemory<int> memory2 = new[] { 1, 2, 4 };

		Assert.IsFalse(memory1.IsEqualTo(memory2));
	}

	[TestMethod]
	public void IsEqualTo_DifferentLengths_ReturnsFalse()
	{
		ReadOnlyMemory<int> memory1 = new[] { 1, 2, 3 };
		ReadOnlyMemory<int> memory2 = new[] { 1, 2 };

		Assert.IsFalse(memory1.IsEqualTo(memory2));
	}

	[TestMethod]
	public void IsEqualTo_EqualSequences_ReturnsTrue()
	{
		ReadOnlyMemory<int> memory1 = new[] { 1, 2, 3 };
		ReadOnlyMemory<int> memory2 = new[] { 1, 2, 3 };

		Assert.IsTrue(memory1.IsEqualTo(memory2));
	}

	[TestMethod]
	public void IsEqualTo_SameUnderlyingMemory_ReturnsTrue()
	{
		var array = new[] { 1, 2, 3 };
		ReadOnlyMemory<int> memory1 = array;
		ReadOnlyMemory<int> memory2 = array;

		Assert.IsTrue(memory1.IsEqualTo(memory2));
	}

	[TestMethod]
	public void IsNotEmpty_EmptyMemory_ReturnsFalse()
	{
		ReadOnlyMemory<int> memory = ReadOnlyMemory<int>.Empty;

		Assert.IsFalse(memory.IsNotEmpty());
	}

	[TestMethod]
	public void IsNotEmpty_NonEmptyMemory_ReturnsTrue()
	{
		ReadOnlyMemory<int> memory = new int[] { 1, 2, 3 };

		Assert.IsTrue(memory.IsNotEmpty());
	}

	[TestMethod]
	public void ToArrayIfNeeded_EmptyMemory_ReturnsEmptyArray()
	{
		ReadOnlyMemory<int> memory = ReadOnlyMemory<int>.Empty;

		var result = memory.ToArrayIfNeeded();

		Assert.AreEqual(0, result.Length);
	}

	[TestMethod]
	public void ToArrayIfNeeded_FullArrayBackedMemory_ReturnsUnderlyingArrayInstance()
	{
		var array = RandomData.GenerateByteArray(10);
		ReadOnlyMemory<byte> memory = array;

		var result = memory.ToArrayIfNeeded();

		Assert.AreSame(array, result);
	}

	[TestMethod]
	public void ToArrayIfNeeded_SlicedMemory_ReturnsNewArrayCopyWithCorrectContent()
	{
		var array = RandomData.GenerateByteArray(10);
		ReadOnlyMemory<byte> memory = array.AsMemory(1, 3);

		var result = memory.ToArrayIfNeeded();

		Assert.AreNotSame(array, result);
		CollectionAssert.AreEqual(new[] { array[1], array[2], array[3] }, result);
	}

	[TestMethod]
	public void TryGetArraySegment_ArrayBackedMemory_ReturnsTrueWithCorrectSegment()
	{
		var array = RandomData.GenerateByteArray(10);
		ReadOnlyMemory<byte> memory = array;

		var result = memory.TryGetArraySegment(out var segment);

		Assert.IsTrue(result);
		Assert.AreSame(array, segment.Array);
		Assert.AreEqual(0, segment.Offset);
		Assert.AreEqual(array.Length, segment.Count);
	}

	[TestMethod]
	public void TryGetArraySegment_EmptyMemory_ReturnsExpectedResult()
	{
		ReadOnlyMemory<int> memory = ReadOnlyMemory<int>.Empty;

		var result = memory.TryGetArraySegment(out var segment);

		Assert.IsTrue(result);
		Assert.AreEqual(0, segment.Count);
	}

	[TestMethod]
	public void TryGetArraySegment_SlicedMemory_ReturnsTrueWithCorrectOffsetAndCount()
	{
		var array = RandomData.GenerateByteArray(10);
		ReadOnlyMemory<byte> memory = array.AsMemory(2, 5);

		var result = memory.TryGetArraySegment(out var segment);

		Assert.IsTrue(result);
		Assert.AreSame(array, segment.Array);
		Assert.AreEqual(2, segment.Offset);
		Assert.AreEqual(5, segment.Count);
	}

}
