// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="Validator.Argument.Extensions.Tests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for Validator.Argument.Extensions helper methods.
// </summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ValidatorArgumentExtensionsTests
{

	[TestMethod]
	public void EnsureCountInRange_InRange_ReturnsSource()
	{
		var list = new List<int> { 1, 2 };

		var result = Validator.EnsureCountInRange(list, 1, 3);

		Assert.AreSame(list, result);
	}

	[TestMethod]
	public void EnsureCountInRange_Null_ThrowsArgumentNullException()
	{
		IEnumerable<int>? source = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.EnsureCountInRange(source, 1, 3));
	}

	[TestMethod]
	public void EnsureCountInRange_OutOfRange_ThrowsArgumentOutOfRangeException()
	{
		var list = new List<int> { 1 };

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => Validator.EnsureCountInRange(list, 2, 3));
	}

	[DataTestMethod]
	[DataRow(2.0d, 2.0d, 3.0d)]
	[DataRow(2.5d, 2.0d, 3.0d)]
	[DataRow(3.0d, 2.0d, 3.0d)]
	public void EnsureInRange_Double_InRange_ReturnsValue(double value, double minInclusive, double maxInclusive)
	{
		var result = value.EnsureInRange(minInclusive, maxInclusive);

		Assert.AreEqual(value, result);
	}

	[TestMethod]
	public void EnsureInRange_Double_OutOfRange_ThrowsInvalidValueException()
	{
		_ = Assert.ThrowsExactly<InvalidValueException<double>>(() => 1.5d.EnsureInRange(2.0d, 3.0d));
	}

	[DataTestMethod]
	[DataRow(10, 10, 20)]
	[DataRow(15, 10, 20)]
	[DataRow(20, 10, 20)]
	public void EnsureInRange_Int_InRange_ReturnsValue(int value, int minInclusive, int maxInclusive)
	{
		var result = value.EnsureInRange(minInclusive, maxInclusive);

		Assert.AreEqual(value, result);
	}

	[TestMethod]
	public void EnsureInRange_Int_OutOfRange_ThrowsArgumentOutOfRangeException()
	{
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => 5.EnsureInRange(10, 20));
	}

	[DataTestMethod]
	[DataRow(10L, 10L, 20L)]
	[DataRow(15L, 10L, 20L)]
	[DataRow(20L, 10L, 20L)]
	public void EnsureInRange_Long_InRange_ReturnsValue(long value, long minInclusive, long maxInclusive)
	{
		var result = value.EnsureInRange(minInclusive, maxInclusive);

		Assert.AreEqual(value, result);
	}

	[TestMethod]
	public void EnsureInRange_Long_OutOfRange_ThrowsInvalidValueException()
	{
		_ = Assert.ThrowsExactly<InvalidValueException<long>>(() => 5L.EnsureInRange(10L, 20L));
	}

	[TestMethod]
	public void EnsureNotEmpty_EnumerableOnlySourceWithItems_ReturnsSource()
	{
		IEnumerable<int> source = new EnumerableOnlySequence<int>(1, 2, 3);

		var result = Validator.EnsureNotEmpty(source);

		Assert.AreSame(source, result);
	}

	[TestMethod]
	public void EnsureNotEmpty_EnumerableOnlySourceWithoutItems_ThrowsInvalidValueException()
	{
		IEnumerable<int> source = new EnumerableOnlySequence<int>();

		_ = Assert.ThrowsExactly<InvalidValueException<IEnumerable<int>>>(() => Validator.EnsureNotEmpty(source));
	}

	[TestMethod]
	public void EnsureNotEmpty_ReadOnlyCollectionWithItems_ReturnsSource()
	{
		IEnumerable<int> source = new ReadOnlySequence<int>(1, 2, 3);

		var result = Validator.EnsureNotEmpty(source);

		Assert.AreSame(source, result);
	}

	[TestMethod]
	public void EnsureNotEmpty_ReadOnlyCollectionWithoutItems_ThrowsInvalidValueException()
	{
		IEnumerable<int> source = new ReadOnlySequence<int>();

		_ = Assert.ThrowsExactly<InvalidValueException<IEnumerable<int>>>(() => Validator.EnsureNotEmpty(source));
	}

	[TestMethod]
	public void EnsureNotEmpty_SourceHasItems_ReturnsSource()
	{
		var list = new List<int> { 1 };

		var result = Validator.EnsureNotEmpty(list);

		Assert.AreSame(list, result);
	}

	[TestMethod]
	public void EnsureNotEmpty_SourceIsEmpty_ThrowsInvalidValueException()
	{
		var empty = new List<int>();

		_ = Assert.ThrowsExactly<InvalidValueException<IEnumerable<int>>>(() => Validator.EnsureNotEmpty(empty));
	}

	[TestMethod]
	public void EnsureNotEmpty_SourceIsNull_ThrowsArgumentNullException()
	{
		IEnumerable<int>? source = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.EnsureNotEmpty(source));
	}

	[TestMethod]
	public void EnsureNotNullOrEmpty_InputIsEmpty_ThrowsArgumentException()
	{
		var input = string.Empty;

		_ = Assert.ThrowsExactly<ArgumentException>(() => Validator.EnsureNotNullOrEmpty(input));
	}

	[TestMethod]
	public void EnsureNotNullOrEmpty_InputIsNull_ThrowsArgumentNullException()
	{
		string? input = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.EnsureNotNullOrEmpty(input));
	}

	[TestMethod]
	public void EnsureNotNullOrEmpty_Valid_ReturnsInput()
	{
		var input = "value";

		var result = Validator.EnsureNotNullOrEmpty(input);

		Assert.AreEqual(input, result);
	}

	[TestMethod]
	public void EnsureNotNullOrWhiteSpace_InputIsNull_ThrowsArgumentNullException()
	{
		string? input = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => Validator.EnsureNotNullOrWhiteSpace(input));
	}

	[TestMethod]
	public void EnsureNotNullOrWhiteSpace_InputIsWhiteSpace_ThrowsArgumentInvalidException()
	{
		var input = "   ";

		_ = Assert.ThrowsExactly<ArgumentInvalidException>(() => Validator.EnsureNotNullOrWhiteSpace(input));
	}

	[TestMethod]
	public void EnsureNotNullOrWhiteSpace_Valid_ReturnsInput()
	{
		var input = "value";

		var result = Validator.EnsureNotNullOrWhiteSpace(input);

		Assert.AreEqual(input, result);
	}

	private sealed class EnumerableOnlySequence<T>(params T[] items) : IEnumerable<T>
	{

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

		public IEnumerator<T> GetEnumerator()
		{
			foreach (var item in items)
			{
				yield return item;
			}
		}
	}

	private sealed class ReadOnlySequence<T>(params T[] items) : IReadOnlyCollection<T>
	{
		public int Count => items.Length;

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

		public IEnumerator<T> GetEnumerator()
		{
			foreach (var item in items)
			{
				yield return item;
			}
		}
	}
}
