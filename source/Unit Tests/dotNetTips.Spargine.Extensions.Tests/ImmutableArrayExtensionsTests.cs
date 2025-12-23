// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-28-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-28-2025
// ***********************************************************************
// <copyright file="ImmutableArrayExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ImmutableArrayExtensionsTests
{

	[TestMethod]
	public void HasItems_EmptyImmutableArray_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray<int>.Empty;

		// Act
		var result = array.IsNotEmpty();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItems_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		var result = array.IsNotEmpty();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasItems_WithCount_EmptyImmutableArray_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray<int>.Empty;

		// Act
		var result = array.IsNotEmpty(3);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItems_WithCount_InvalidCount_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		var result = array.IsNotEmpty(2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItems_WithCount_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		var result = array.IsNotEmpty(3);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasItems_WithPredicate_EmptyImmutableArray_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray<int>.Empty;

		// Act
		var result = array.IsNotEmpty(x => x > 1);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasItems_WithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		Assert.IsFalse(array.IsNotEmpty(null));
	}

	[TestMethod]
	public void HasItems_WithPredicate_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Act
		var result = array.IsNotEmpty(x => x > 1);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Shuffle_EmptyImmutableArray_ReturnsEmpty()
	{
		var array = ImmutableArray<int>.Empty;
		var shuffled = array.FastShuffle();
		Assert.IsTrue(shuffled.IsEmpty);
	}

	[TestMethod]
	public void Shuffle_MultipleElements_ReturnsSameCountAndElements()
	{
		var array = ImmutableArray.Create(1, 2, 3, 4, 5);
		var shuffled = array.FastShuffle();
		Assert.AreEqual(array.Length, shuffled.Length);
		CollectionAssert.AreEquivalent(array.ToArray(), shuffled.ToArray());
	}

	[TestMethod]
	public void Shuffle_SingleElement_ReturnsSameElement()
	{
		var array = ImmutableArray.Create(42);
		var shuffled = array.FastShuffle();
		Assert.AreEqual(1, shuffled.Length);
		Assert.AreEqual(42, shuffled[0]);
	}
}
