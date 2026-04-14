// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 04-14-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-14-2026
// ***********************************************************************
// <copyright file="IDataModelTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Unit tests for the IDataModel interface default implementations.</summary>
// ***********************************************************************
#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class IDataModelTests
{

	/// <summary>
	/// Minimal implementation that relies entirely on the default interface methods.
	/// </summary>
	private sealed class TestModel : IDataModel<TestModel, string>
	{
		public string Id { get; init; } = string.Empty;

		int IComparable.CompareTo(object? obj)
		{
			return obj is TestModel other
				? ((IComparable<TestModel>)this).CompareTo(other)
				: 1;
		}
	}

	/// <summary>
	/// Minimal implementation using an int key to verify value-type key behavior.
	/// </summary>
	private sealed class IntKeyModel : IDataModel<IntKeyModel, int>
	{
		public int Id { get; init; }

		int IComparable.CompareTo(object? obj)
		{
			return obj is IntKeyModel other
				? ((IComparable<IntKeyModel>)this).CompareTo(other)
				: 1;
		}
	}

	// ────────────────────────────────────────────
	// IsTransient
	// ────────────────────────────────────────────

	[TestMethod]
	public void IsTransientReturnsFalseWhenStringIdIsEmptyString()
	{
		IDataModel<TestModel, string> model = new TestModel();

		// default(string) is null, not string.Empty, so IsTransient is false
		Assert.IsFalse(model.IsTransient);
	}

	[TestMethod]
	public void IsTransientReturnsFalseWhenIdIsSet()
	{
		IDataModel<TestModel, string> model = new TestModel { Id = "abc123" };

		Assert.IsFalse(model.IsTransient);
	}

	[TestMethod]
	public void IsTransientReturnsTrueWhenIntKeyIsDefault()
	{
		IDataModel<IntKeyModel, int> model = new IntKeyModel();

		Assert.IsTrue(model.IsTransient);
	}

	[TestMethod]
	public void IsTransientReturnsFalseWhenIntKeyIsSet()
	{
		IDataModel<IntKeyModel, int> model = new IntKeyModel { Id = 42 };

		Assert.IsFalse(model.IsTransient);
	}

	// ────────────────────────────────────────────
	// CompareTo (IComparable<TSelf>)
	// ────────────────────────────────────────────

	[TestMethod]
	public void CompareToNullReturnsPositive()
	{
		IComparable<TestModel> model = new TestModel { Id = "a" };

		Assert.IsTrue(model.CompareTo(null) > 0);
	}

	[TestMethod]
	public void CompareToSameIdReturnsZero()
	{
		IComparable<TestModel> model = new TestModel { Id = "abc" };
		var other = new TestModel { Id = "abc" };

		Assert.AreEqual(0, model.CompareTo(other));
	}

	[TestMethod]
	public void CompareToSmallerIdReturnsPositive()
	{
		IComparable<TestModel> model = new TestModel { Id = "b" };
		var other = new TestModel { Id = "a" };

		Assert.IsTrue(model.CompareTo(other) > 0);
	}

	[TestMethod]
	public void CompareToLargerIdReturnsNegative()
	{
		IComparable<TestModel> model = new TestModel { Id = "a" };
		var other = new TestModel { Id = "b" };

		Assert.IsTrue(model.CompareTo(other) < 0);
	}

	[TestMethod]
	public void CompareToIntKeyNullReturnsPositive()
	{
		IComparable<IntKeyModel> model = new IntKeyModel { Id = 1 };

		Assert.IsTrue(model.CompareTo(null) > 0);
	}

	[TestMethod]
	public void CompareToIntKeySameIdReturnsZero()
	{
		IComparable<IntKeyModel> model = new IntKeyModel { Id = 5 };
		var other = new IntKeyModel { Id = 5 };

		Assert.AreEqual(0, model.CompareTo(other));
	}

	[TestMethod]
	public void CompareToIntKeySmallerIdReturnsPositive()
	{
		IComparable<IntKeyModel> model = new IntKeyModel { Id = 10 };
		var other = new IntKeyModel { Id = 3 };

		Assert.IsTrue(model.CompareTo(other) > 0);
	}

	[TestMethod]
	public void CompareToIntKeyLargerIdReturnsNegative()
	{
		IComparable<IntKeyModel> model = new IntKeyModel { Id = 3 };
		var other = new IntKeyModel { Id = 10 };

		Assert.IsTrue(model.CompareTo(other) < 0);
	}

	// ────────────────────────────────────────────
	// Equals (IEquatable<TSelf>)
	// ────────────────────────────────────────────

	[TestMethod]
	public void EqualsNullReturnsFalse()
	{
		IEquatable<TestModel> model = new TestModel { Id = "abc" };

		Assert.IsFalse(model.Equals(null));
	}

	[TestMethod]
	public void EqualsSameIdReturnsTrue()
	{
		IEquatable<TestModel> model = new TestModel { Id = "abc" };
		var other = new TestModel { Id = "abc" };

		Assert.IsTrue(model.Equals(other));
	}

	[TestMethod]
	public void EqualsDifferentIdReturnsFalse()
	{
		IEquatable<TestModel> model = new TestModel { Id = "abc" };
		var other = new TestModel { Id = "xyz" };

		Assert.IsFalse(model.Equals(other));
	}

	[TestMethod]
	public void EqualsSameReferenceReturnsTrue()
	{
		var instance = new TestModel { Id = "abc" };
		IEquatable<TestModel> model = instance;

		Assert.IsTrue(model.Equals(instance));
	}

	[TestMethod]
	public void EqualsIntKeyNullReturnsFalse()
	{
		IEquatable<IntKeyModel> model = new IntKeyModel { Id = 7 };

		Assert.IsFalse(model.Equals(null));
	}

	[TestMethod]
	public void EqualsIntKeySameIdReturnsTrue()
	{
		IEquatable<IntKeyModel> model = new IntKeyModel { Id = 7 };
		var other = new IntKeyModel { Id = 7 };

		Assert.IsTrue(model.Equals(other));
	}

	[TestMethod]
	public void EqualsIntKeyDifferentIdReturnsFalse()
	{
		IEquatable<IntKeyModel> model = new IntKeyModel { Id = 7 };
		var other = new IntKeyModel { Id = 99 };

		Assert.IsFalse(model.Equals(other));
	}

	// ────────────────────────────────────────────
	// DebugDisplay
	// ────────────────────────────────────────────

	[TestMethod]
	public void DebugDisplayReturnsExpectedFormat()
	{
		IDataModel<TestModel, string> model = new TestModel { Id = "test-id" };

		Assert.AreEqual("TestModel(test-id)", model.DebugDisplay());
	}

	[TestMethod]
	public void DebugDisplayIntKeyReturnsExpectedFormat()
	{
		IDataModel<IntKeyModel, int> model = new IntKeyModel { Id = 42 };

		Assert.AreEqual("IntKeyModel(42)", model.DebugDisplay());
	}

	[TestMethod]
	public void DebugDisplayEmptyIdReturnsExpectedFormat()
	{
		IDataModel<TestModel, string> model = new TestModel();

		Assert.AreEqual("TestModel()", model.DebugDisplay());
	}

	[TestMethod]
	public void DebugDisplayDefaultIntKeyReturnsExpectedFormat()
	{
		IDataModel<IntKeyModel, int> model = new IntKeyModel();

		Assert.AreEqual("IntKeyModel(0)", model.DebugDisplay());
	}

}
