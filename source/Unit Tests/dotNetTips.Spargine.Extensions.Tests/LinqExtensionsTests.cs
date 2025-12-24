// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="LinqExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class LinqExtensionsTests
{

	[TestMethod]
	public void If_WithConditionFalse_ShouldNotApplyTransforms()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 }.AsQueryable();
		bool condition = false;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.Where(x => x > 2),
				query => query.OrderByDescending(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.AreEqual(5, result.Count);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
		Assert.AreEqual(3, result[2]);
		Assert.AreEqual(4, result[3]);
		Assert.AreEqual(5, result[4]);
	}

	[TestMethod]
	public void If_WithConditionFalse_ShouldNotApplyTransforms_IEnumerable()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 };
		bool condition = false;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = {
		sequence => sequence.Where(x => x > 2),
		sequence => sequence.OrderByDescending(x => x)
	};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.AreEqual(5, result.Count);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
		Assert.AreEqual(3, result[2]);
		Assert.AreEqual(4, result[3]);
		Assert.AreEqual(5, result[4]);
	}
	[TestMethod]
	public void If_WithConditionTrue_ShouldApplyTransforms()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 }.AsQueryable();
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.Where(x => x > 2),
				query => query.OrderByDescending(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.AreEqual(3, result.Count);
		Assert.AreEqual(5, result[0]);
		Assert.AreEqual(4, result[1]);
		Assert.AreEqual(3, result[2]);
	}

	[TestMethod]
	public void If_WithConditionTrue_ShouldApplyTransforms_IEnumerable()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 };
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = {
		sequence => sequence.Where(x => x > 2),
		sequence => sequence.OrderByDescending(x => x)
	};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.AreEqual(3, result.Count);
		Assert.AreEqual(5, result[0]);
		Assert.AreEqual(4, result[1]);
		Assert.AreEqual(3, result[2]);
	}


	[TestMethod]
	public void If_WithNullInput_ShouldThrowArgumentNullException()
	{
		// Arrange
		IQueryable<int> data = null;
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.Where(x => x > 2),
				query => query.OrderByDescending(x => x)
			};

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => data.If(condition, transforms));
	}

	[TestMethod]
	public void If_WithNullInput_ShouldThrowArgumentNullException_IEnumerable()
	{
		// Arrange
		IEnumerable<int> data = null;
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = {
		sequence => sequence.Where(x => x > 2),
		sequence => sequence.OrderByDescending(x => x)
	};

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => data.If(condition, transforms));
	}

	[TestMethod]
	public void If_WithNullTransforms_ShouldThrowArgumentNullException()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 }.AsQueryable();
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => data.If(condition, transforms));
	}

	[TestMethod]
	public void If_WithNullTransforms_ShouldThrowArgumentNullException_IEnumerable()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 };
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => data.If(condition, transforms));
	}
}

