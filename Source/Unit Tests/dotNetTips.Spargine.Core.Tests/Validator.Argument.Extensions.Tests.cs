// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="Validator.Argument.Extensions.Tests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for Validator.Argument.Extensions helper methods.
// </summary>
// ***********************************************************************
using System;
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
	[TestMethod]
	public void EnsureInRange_Double_InRange_ReturnsValue()
	{
		var result = 2.5d.EnsureInRange(2.0d, 3.0d);

		Assert.AreEqual(2.5d, result);
	}

	[TestMethod]
	public void EnsureInRange_Double_OutOfRange_ThrowsInvalidValueException()
	{
		_ = Assert.ThrowsExactly<InvalidValueException<double>>(() => 1.5d.EnsureInRange(2.0d, 3.0d));
	}

	[TestMethod]
	public void EnsureInRange_Int_InRange_ReturnsValue()
	{
		var result = 15.EnsureInRange(10, 20);

		Assert.AreEqual(15, result);
	}

	[TestMethod]
	public void EnsureInRange_Int_OutOfRange_ThrowsArgumentOutOfRangeException()
	{
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => 5.EnsureInRange(10, 20));
	}

	[TestMethod]
	public void EnsureInRange_Long_InRange_ReturnsValue()
	{
		var result = ((long)15).EnsureInRange(10L, 20L);

		Assert.AreEqual(15L, result);
	}

	[TestMethod]
	public void EnsureInRange_Long_OutOfRange_ThrowsInvalidValueException()
	{
		_ = Assert.ThrowsExactly<InvalidValueException<long>>(() => ((long)5).EnsureInRange(10L, 20L));
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
}
