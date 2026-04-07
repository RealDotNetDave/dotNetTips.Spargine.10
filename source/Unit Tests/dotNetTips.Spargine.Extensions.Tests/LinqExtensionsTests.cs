// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
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
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class LinqExtensionsTests
{

	private const int Count = 256;

	[TestMethod]
	public void If_WithConditionFalse_ShouldNotApplyTransforms()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 }.AsQueryable();
		var condition = false;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.Where(x => x > 2),
				query => query.OrderByDescending(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(5, result);
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
		Assert.HasCount(5, result);
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
		Assert.HasCount(3, result);
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
		Assert.HasCount(3, result);
		Assert.AreEqual(5, result[0]);
		Assert.AreEqual(4, result[1]);
		Assert.AreEqual(3, result[2]);
	}

	[TestMethod]
	public void If_WithEmptyTransforms_ShouldThrowArgumentNullException()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 }.AsQueryable();
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = [];

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => data.If(condition, transforms));
	}

	[TestMethod]
	public void If_WithEmptyTransforms_ShouldThrowArgumentNullException_IEnumerable()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5 };
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = [];

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => data.If(condition, transforms));
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

	[TestMethod]
	public void If_WithPersonCollection_ShouldApplyTransforms()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsQueryable();
		bool condition = true;
		var halfCount = Count / 2;
		Func<IQueryable<Person>, IQueryable<Person>>[] transforms = {
				query => query.Take(halfCount)
			};

		// Act
		var result = people.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(halfCount, result);
	}

	[TestMethod]
	public void If_WithPersonCollection_ShouldApplyTransforms_IEnumerable()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count);
		bool condition = true;
		var halfCount = Count / 2;
		Func<IEnumerable<Person>, IEnumerable<Person>>[] transforms = {
				sequence => sequence.Take(halfCount)
			};

		// Act
		var result = people.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(halfCount, result);
	}

	[TestMethod]
	public void If_WithPersonCollection_ConditionFalse_ShouldReturnOriginal()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count).AsQueryable();
		bool condition = false;
		Func<IQueryable<Person>, IQueryable<Person>>[] transforms = {
				query => query.Take(1)
			};

		// Act
		var result = people.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void If_WithPersonCollection_ConditionFalse_ShouldReturnOriginal_IEnumerable()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(Count);
		bool condition = false;
		Func<IEnumerable<Person>, IEnumerable<Person>>[] transforms = {
				sequence => sequence.Take(1)
			};

		// Act
		var result = people.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(Count, result);
	}

	[TestMethod]
	public void If_WithSingleTransform_ShouldApplyTransform()
	{
		// Arrange
		var data = new[] { 5, 3, 1, 4, 2 }.AsQueryable();
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.OrderBy(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(5, result);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
		Assert.AreEqual(3, result[2]);
		Assert.AreEqual(4, result[3]);
		Assert.AreEqual(5, result[4]);
	}

	[TestMethod]
	public void If_WithSingleTransform_ShouldApplyTransform_IEnumerable()
	{
		// Arrange
		var data = new[] { 5, 3, 1, 4, 2 };
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = {
				sequence => sequence.OrderBy(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(5, result);
		Assert.AreEqual(1, result[0]);
		Assert.AreEqual(2, result[1]);
		Assert.AreEqual(3, result[2]);
		Assert.AreEqual(4, result[3]);
		Assert.AreEqual(5, result[4]);
	}

	[TestMethod]
	public void If_WithMultipleTransforms_ShouldApplyAllTransformsSequentially()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.AsQueryable();
		bool condition = true;
		Func<IQueryable<int>, IQueryable<int>>[] transforms = {
				query => query.Where(x => x > 3),
				query => query.Where(x => x < 8),
				query => query.OrderByDescending(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(4, result);
		Assert.AreEqual(7, result[0]);
		Assert.AreEqual(6, result[1]);
		Assert.AreEqual(5, result[2]);
		Assert.AreEqual(4, result[3]);
	}

	[TestMethod]
	public void If_WithMultipleTransforms_ShouldApplyAllTransformsSequentially_IEnumerable()
	{
		// Arrange
		var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		bool condition = true;
		Func<IEnumerable<int>, IEnumerable<int>>[] transforms = {
				sequence => sequence.Where(x => x > 3),
				sequence => sequence.Where(x => x < 8),
				sequence => sequence.OrderByDescending(x => x)
			};

		// Act
		var result = data.If(condition, transforms).ToList();

		// Assert
		Assert.HasCount(4, result);
		Assert.AreEqual(7, result[0]);
		Assert.AreEqual(6, result[1]);
		Assert.AreEqual(5, result[2]);
		Assert.AreEqual(4, result[3]);
	}
}

