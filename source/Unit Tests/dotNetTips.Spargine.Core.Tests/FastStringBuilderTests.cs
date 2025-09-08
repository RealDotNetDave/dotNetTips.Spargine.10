// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-03-2023
//
// Last Modified By : David McCarter
// Last Modified On : 03-10-2025
// ***********************************************************************
// <copyright file="FastStringBuilderTests.cs" company="McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

/// <summary>
/// Defines test class FastStringBuilderTests.
/// </summary>
[ExcludeFromCodeCoverage]
[TestClass]
public class FastStringBuilderTests
{

	private const int WordCount = 256;
	private const int WordMaxLength = 10;
	private const int WordMinLength = 5;

	[TestMethod]
	public void AppendFormatTest()
	{
		var result = FastStringBuilder.Format("Hello, {0}!", "world");
		Assert.AreEqual("Hello, world!", result);

		result = FastStringBuilder.Format("Number: {0}, String: {1}", "123", "test");
		Assert.AreEqual("Number: 123, String: test", result);

		result = FastStringBuilder.Format("Empty: {0}", null);
		Assert.AreEqual(string.Empty, result);

		result = FastStringBuilder.Format(null, "test");
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void BytesToString_ByteArrayTest()
	{
		var bytes = new byte[] { 0xA, 0xB, 0xC, 0xD };
		var result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual("0A0B0C0D", result);

		bytes = Array.Empty<byte>();
		result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void BytesToString_ReadOnlySpanTest()
	{
		var bytes = new byte[] { 0x1, 0x2, 0x3, 0x4, 0x5 };
		var result = FastStringBuilder.BytesToString(bytes.AsReadOnlySpan());
		Assert.AreEqual("0102030405", result);

		result = FastStringBuilder.BytesToString(ReadOnlySpan<byte>.Empty);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void CombineTest()
	{
		var words = RandomData.GenerateWords(5, 3, 8).ToReadOnlyCollection();
		var result = FastStringBuilder.Combine(false, words);
		Assert.AreEqual(string.Concat(words), result);

		result = FastStringBuilder.Combine(true, words);
		var expected = string.Join(Environment.NewLine, words) + Environment.NewLine;

		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void CombineWithSpaceTest()
	{
		var words = RandomData.GenerateWords(3, 2, 5).ToReadOnlyCollection();
		var result = FastStringBuilder.CombineWithSpace(words);
		var expected = string.Join(" ", words);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void Concat_CharDelimiterTest()
	{
		var words = RandomData.GenerateWords(4, 2, 6).ToArray();
		var result = FastStringBuilder.Concat('|', false, words);
		var expected = string.Join("|", words);
		Assert.AreEqual(expected, result);

		result = FastStringBuilder.Concat('|', true, words);
		expected = string.Join(Environment.NewLine, words);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void Concat_StringDelimiterTest()
	{
		var words = RandomData.GenerateWords(4, 2, 6).ToReadOnlyCollection();
		var result = FastStringBuilder.Concat("::", false, words);
		var expected = string.Join("::", words);
		Assert.AreEqual(expected, result);

		result = FastStringBuilder.Concat("::", true, words);
		expected = string.Join(Environment.NewLine, words);
		Assert.AreEqual(expected, result);

		result = FastStringBuilder.Concat(null, false, words);
		expected = string.Join(", ", words);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void ConcatToStringCharTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		var result = FastStringBuilder.Concat(delimiter: ControlChars.Plus, addLineFeed: false, args: strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.Concat(null) == ControlChars.EmptyString);
	}

	[TestMethod]
	public void ConcatToStringTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToReadOnlyCollection();

		var result = FastStringBuilder.Concat(ControlChars.CommaSpace.ToString(), false, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		result = FastStringBuilder.Concat(ControlChars.CommaSpace.ToString(), true, strings);

		Assert.IsTrue(string.IsNullOrEmpty(result) == false);

		Assert.IsTrue(FastStringBuilder.Concat(null) == ControlChars.EmptyString);
	}

	[TestMethod]
	public void Join_CharDelimiterTest()
	{
		var words = RandomData.GenerateWords(3, 2, 5);
		var result = FastStringBuilder.Join(words, ';');
		var expected = string.Join(";", words);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void Join_StringDelimiterTest()
	{
		var words = RandomData.GenerateWords(3, 2, 5);
		var result = FastStringBuilder.Join(words, " | ");
		var expected = string.Join(" | ", words);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void PerformAction_NullActionTest()
	{
		var result = FastStringBuilder.PerformAction(null);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void PerformActionTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToArray();

		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			foreach (var word in strings)
			{
				_ = sb.Append($"WORD:{word}|");
			}
		};

		var result = FastStringBuilder.PerformAction(action);

		Assert.IsNotNull(result);
	}

	/// <summary>
	/// Defines the test method RemoveStringTest.
	/// </summary>
	[TestMethod]
	public void RemoveStringTest()
	{
		var result = FastStringBuilder.Remove("Hello, world!", "world");
		Assert.AreEqual("Hello, !", result);

		result = FastStringBuilder.Remove("This is a test. This is only a test.", "test");
		Assert.AreEqual("This is a . This is only a .", result);

		result = FastStringBuilder.Remove("No occurrences here.", "notfound");
		Assert.AreEqual("No occurrences here.", result);

		result = FastStringBuilder.Remove(null, "test");
		Assert.AreEqual(ControlChars.EmptyString, result);

		result = FastStringBuilder.Remove("This is a test.", null);
		Assert.AreEqual("This is a test.", result);

		result = FastStringBuilder.Remove("This is a test.", string.Empty);
		Assert.AreEqual("This is a test.", result);

		result = FastStringBuilder.Remove(string.Empty, "test");
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void ToDelimitedString_DictionaryTest()
	{
		var dict = new Dictionary<string, string>
		{
			{ "A", "1" },
			{ "B", "2" },
			{ "C", "3" }
		};
		var result = FastStringBuilder.ToDelimitedString(dict, ';');
		var expected = "A:1;B:2;C:3";
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToDelimitedString_EmptyDictionaryThrows()
	{
		var dict = new Dictionary<string, string>();
		FastStringBuilder.ToDelimitedString(dict, ',');
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void ToDelimitedString_NullDictionaryThrows()
	{
		Dictionary<string, string> dict = null;
		FastStringBuilder.ToDelimitedString(dict, ',');
	}
}
