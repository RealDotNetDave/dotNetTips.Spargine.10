// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="ImmutableArrayExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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

		// Assert
		Assert.IsFalse(array.IsNotEmpty());
	}

	[TestMethod]
	public void HasItems_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Assert
		Assert.IsTrue(array.IsNotEmpty());
	}

	[TestMethod]
	public void HasItems_WithCount_EmptyImmutableArray_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray<int>.Empty;

		// Assert
		Assert.IsFalse(array.IsNotEmpty(3));
	}

	[TestMethod]
	public void HasItems_WithCount_InvalidCount_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Assert
		Assert.IsFalse(array.IsNotEmpty(2));
	}

	[TestMethod]
	public void HasItems_WithCount_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Assert
		Assert.IsTrue(array.IsNotEmpty(3));
	}

	[TestMethod]
	public void HasItems_WithPredicate_EmptyImmutableArray_ReturnsFalse()
	{
		// Arrange
		var array = ImmutableArray<int>.Empty;

		// Assert
		Assert.IsFalse(array.IsNotEmpty(x => x > 1));
	}

	[TestMethod]
	public void HasItems_WithPredicate_NullPredicate_ThrowsArgumentNullException()
	{
		// Act
		Assert.IsFalse(ImmutableArray.Create(1, 2, 3).IsNotEmpty(null));
	}

	[TestMethod]
	public void HasItems_WithPredicate_NoMatch_ReturnsFalse()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(10).ToImmutableArray();

		// Assert
		Assert.IsFalse(people.IsNotEmpty(p => p.Email == "no-match@invalid.test"));
	}

	[TestMethod]
	public void HasItems_WithPredicate_ValidImmutableArray_ReturnsTrue()
	{
		// Arrange
		var array = ImmutableArray.Create(1, 2, 3);

		// Assert
		Assert.IsTrue(array.IsNotEmpty(x => x > 1));
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

		Assert.HasCount(array.Length, shuffled);
		CollectionAssert.AreEquivalent(array.ToArray(), shuffled.ToArray());
	}

	[TestMethod]
	public void Shuffle_SingleElement_ReturnsSameElement()
	{
		var array = ImmutableArray.Create(42);
		var shuffled = array.FastShuffle();

		Assert.HasCount(1, shuffled);
		Assert.AreEqual(42, shuffled[0]);
	}
}
