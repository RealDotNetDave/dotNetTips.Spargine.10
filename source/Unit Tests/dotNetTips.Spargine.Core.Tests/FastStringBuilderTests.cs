// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-03-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2026
// ***********************************************************************
// <copyright file="FastStringBuilderTests.cs" company="dotNetTips.com - McCarter Consulting">
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

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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
	public void BytesToString_ByteArray_AllBytesTest()
	{
		// Test complete range 0x00 to 0xFF
		var bytes = new byte[] {
		0x00, 0x01, 0x10, 0x11, 0x20, 0x2F,
		0x30, 0x3F, 0x40, 0x4F, 0x50, 0x5F,
		0x60, 0x6F, 0x70, 0x7F, 0x80, 0x8F,
		0x90, 0x9F, 0xA0, 0xAF, 0xB0, 0xBF,
		0xC0, 0xCF, 0xD0, 0xDF, 0xE0, 0xEF,
		0xF0, 0xFF
	};

		var result = FastStringBuilder.BytesToString(ref bytes);

		Assert.IsNotNull(result);
		Assert.AreEqual(bytes.Length * 2, result.Length);
		Assert.Contains("00", result);
		Assert.Contains("FF", result);
	}

	[TestMethod]
	public void BytesToString_ByteArray_LargeArrayTest()
	{
		var bytes = new byte[256];
		for (var i = 0; i < 256; i++)
		{
			bytes[i] = (byte)i;
		}

		var result = FastStringBuilder.BytesToString(ref bytes);

		Assert.IsNotNull(result);
		Assert.AreEqual(512, result.Length); // 256 bytes * 2 chars each
		Assert.StartsWith("00", result);
		Assert.EndsWith("FF", result);
	}

	[TestMethod]
	public void BytesToString_ByteArray_MaximumValuesTest()
	{
		var bytes = new byte[] { 0xFF, 0xFF, 0xFF };
		var result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual("FFFFFF", result);
	}

	[TestMethod]
	public void BytesToString_ByteArray_MixedValuesTest()
	{
		var bytes = new byte[] { 0x00, 0x0F, 0xF0, 0xFF, 0x12, 0x34, 0x56, 0x78 };
		var result = FastStringBuilder.BytesToString(ref bytes);

		Assert.AreEqual("000FF0FF12345678", result);
	}

	[TestMethod]
	public void BytesToString_ByteArray_NullArrayTest()
	{
		byte[] bytes = null;

		Assert.ThrowsExactly<ArgumentNullException>(() =>
		{
			_ = FastStringBuilder.BytesToString(ref bytes);
		});
	}

	[TestMethod]
	public void BytesToString_ByteArray_PaddingTest()
	{
		// Verify single-digit hex values are padded with leading zero
		var bytes = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x09 };
		var result = FastStringBuilder.BytesToString(ref bytes);

		Assert.AreEqual("010203040509", result);
		Assert.AreEqual(12, result.Length); // 6 bytes * 2 chars each
	}

	[TestMethod]
	public void BytesToString_ByteArray_SingleByteTest()
	{
		var bytes = new byte[] { 0xA5 };
		var result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual("A5", result);
	}

	[TestMethod]
	public void BytesToString_ByteArray_UppercaseHexTest()
	{
		var bytes = new byte[] { 0xAB, 0xCD, 0xEF };
		var result = FastStringBuilder.BytesToString(ref bytes);

		Assert.AreEqual("ABCDEF", result);
		Assert.IsFalse(result.Contains("ab"));
		Assert.IsFalse(result.Contains("cd"));
		Assert.IsFalse(result.Contains("ef"));
	}

	[TestMethod]
	public void BytesToString_ByteArray_ZeroValuesTest()
	{
		var bytes = new byte[] { 0x00, 0x00, 0x00 };
		var result = FastStringBuilder.BytesToString(ref bytes);
		Assert.AreEqual("000000", result);
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
	public void Combine_AllNullStringsTest()
	{
		var words = new string[] { null, null, null };
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());

		Assert.IsNotNull(result);
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void Combine_EmptyArrayTest()
	{
		var result = FastStringBuilder.Combine(false, ReadOnlySpan<string>.Empty);
		Assert.AreEqual(ControlChars.EmptyString, result);

		result = FastStringBuilder.Combine(true, ReadOnlySpan<string>.Empty);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void Combine_LargeArrayTest()
	{
		var words = RandomData.GenerateWords(1000, 5, 15).ToArray();
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());

		Assert.IsNotNull(result);
		Assert.Contains(words[0], result);
		Assert.Contains(words[999], result);
	}

	[TestMethod]
	public void Combine_LineFeedBehaviorTest()
	{
		var words = new[] { "Line1", "Line2", "Line3" };
		var result = FastStringBuilder.Combine(true, words.AsReadOnlySpan());

		var lines = result.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
		Assert.AreEqual(3, lines.Length);
		Assert.AreEqual("Line1", lines[0]);
		Assert.AreEqual("Line2", lines[1]);
		Assert.AreEqual("Line3", lines[2]);
	}

	[TestMethod]
	public void Combine_ParamsArraySyntaxTest()
	{
		var result = FastStringBuilder.Combine(false, "One", "Two", "Three");
		Assert.AreEqual("OneTwoThree", result);

		result = FastStringBuilder.Combine(true, "One", "Two", "Three");
		var expected = "One" + Environment.NewLine + "Two" + Environment.NewLine + "Three" + Environment.NewLine;
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void Combine_SingleStringTest()
	{
		var words = new[] { "Hello" };
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());
		Assert.AreEqual("Hello", result);

		result = FastStringBuilder.Combine(true, words.AsReadOnlySpan());
		Assert.AreEqual("Hello" + Environment.NewLine, result);
	}

	[TestMethod]
	public void Combine_UnicodeStringsTest()
	{
		var words = new[] { "Hello", "世界", "🌍", "Привет" };
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());

		Assert.Contains("Hello", result);
		Assert.Contains("世界", result);
		Assert.Contains("🌍", result);
		Assert.Contains("Привет", result);
	}

	[TestMethod]
	public void Combine_VeryLongStringsTest()
	{
		var longString = new string('A', 10000);
		var words = new[] { longString, longString, longString };
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());

		Assert.AreEqual(30000, result.Length);
	}

	[TestMethod]
	public void Combine_WithEmptyStringsTest()
	{
		var words = new[] { "Hello", string.Empty, "World", string.Empty, "!" };
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());

		Assert.AreEqual("HelloWorld!", result);

		result = FastStringBuilder.Combine(true, words.AsReadOnlySpan());
		Assert.Contains("Hello", result);
		Assert.Contains("World", result);
		Assert.Contains(Environment.NewLine, result);
	}

	[TestMethod]
	public void Combine_WithNullStringsTest()
	{
		var words = new[] { "Hello", null, "World", null, "!" };
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());

		Assert.IsNotNull(result);
		Assert.Contains("Hello", result);
		Assert.Contains("World", result);
		Assert.Contains("!", result);
	}

	[TestMethod]
	public void Combine_WithSpecialCharactersTest()
	{
		var words = new[] { "Hello\t", "World\r\n", "Test\n", "Special!" };
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());

		Assert.Contains("Hello\t", result);
		Assert.Contains("World\r\n", result);
		Assert.Contains("Test\n", result);
		Assert.Contains("Special!", result);
	}

	[TestMethod]
	public void Combine_WithWhitespaceStringsTest()
	{
		var words = new[] { "  ", "\t", "\n", "Text", "   " };
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());

		Assert.Contains("Text", result);
		Assert.Contains("  ", result);
		Assert.Contains("\t", result);
	}

	[TestMethod]
	public void CombineTest()
	{
		var words = RandomData.GenerateWords(5, 3, 8).ToReadOnlyCollection();
		var result = FastStringBuilder.Combine(false, words.AsReadOnlySpan());
		Assert.AreEqual(string.Concat(words), result);

		result = FastStringBuilder.Combine(true, words.AsReadOnlySpan());
		var expected = string.Join(Environment.NewLine, words) + Environment.NewLine;

		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void CombineWithSpace_AllNullStringsTest()
	{
		var words = new string[] { null, null, null, null };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		// Should have 3 spaces between 4 null strings
		Assert.AreEqual("   ", result);
	}

	[TestMethod]
	public void CombineWithSpace_EmptyArrayTest()
	{
		var result = FastStringBuilder.CombineWithSpace(ReadOnlySpan<string>.Empty);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void CombineWithSpace_FirstStringNullTest()
	{
		var words = new string[] { null, "World", "!" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.Contains("World", result);
		Assert.Contains("!", result);
		Assert.StartsWith(" ", result); // First character should be space
	}

	[TestMethod]
	public void CombineWithSpace_LargeArrayTest()
	{
		var words = RandomData.GenerateWords(500, 5, 10).ToArray();
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.IsNotNull(result);
		Assert.Contains(words[0], result);
		Assert.Contains(words[499], result);
		Assert.Contains(" ", result);
	}

	[TestMethod]
	public void CombineWithSpace_LastStringNullTest()
	{
		var words = new[] { "Hello", "World", null };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.Contains("Hello", result);
		Assert.Contains("World", result);
		Assert.EndsWith(" ", result); // Last character should be space
	}

	[TestMethod]
	public void CombineWithSpace_MixedNullAndEmptyTest()
	{
		var words = new[] { "Start", null, string.Empty, "Middle", null, string.Empty, "End" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.Contains("Start", result);
		Assert.Contains("Middle", result);
		Assert.Contains("End", result);
	}

	[TestMethod]
	public void CombineWithSpace_MultipleStringsTest()
	{
		var words = new[] { "Hello", "World", "Test" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());
		Assert.AreEqual("Hello World Test", result);
	}

	[TestMethod]
	public void CombineWithSpace_NumberStringsTest()
	{
		var words = new[] { "1", "2", "3", "4", "5" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.AreEqual("1 2 3 4 5", result);
	}

	[TestMethod]
	public void CombineWithSpace_ParamsArraySyntaxTest()
	{
		var result = FastStringBuilder.CombineWithSpace("One", "Two", "Three", "Four");
		Assert.AreEqual("One Two Three Four", result);
	}

	[TestMethod]
	public void CombineWithSpace_SingleNonNullStringTest()
	{
		var words = new[] { "Hello" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());
		Assert.AreEqual("Hello", result);
	}

	[TestMethod]
	public void CombineWithSpace_SingleNullStringTest()
	{
		var words = new string[] { null };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void CombineWithSpace_SpecialCharactersTest()
	{
		var words = new[] { "Hello!", "@#$%", "Test&Value", "(parentheses)" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.AreEqual("Hello! @#$% Test&Value (parentheses)", result);
	}

	[TestMethod]
	public void CombineWithSpace_TwoStringsTest()
	{
		var words = new[] { "Hello", "World" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());
		Assert.AreEqual("Hello World", result);
	}

	[TestMethod]
	public void CombineWithSpace_UnicodeStringsTest()
	{
		var words = new[] { "Hello", "世界", "🌍", "Привет", "مرحبا" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.Contains("Hello", result);
		Assert.Contains("世界", result);
		Assert.Contains("🌍", result);
		Assert.Contains("Привет", result);
		Assert.Contains("مرحبا", result);
		Assert.AreEqual("Hello 世界 🌍 Привет مرحبا", result);
	}

	[TestMethod]
	public void CombineWithSpace_VeryLongStringsTest()
	{
		var longString1 = new string('A', 5000);
		var longString2 = new string('B', 5000);
		var longString3 = new string('C', 5000);
		var words = new[] { longString1, longString2, longString3 };

		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.AreEqual(15002, result.Length); // 15000 chars + 2 spaces
		Assert.StartsWith(longString1, result);
		Assert.EndsWith(longString3, result);
	}

	[TestMethod]
	public void CombineWithSpace_WithEmptyStringsTest()
	{
		var words = new[] { "Hello", string.Empty, "World", string.Empty, "!" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.AreEqual("Hello  World  !", result);
	}

	[TestMethod]
	public void CombineWithSpace_WithNullStringsTest()
	{
		var words = new[] { "Hello", null, "World", null, "!" };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		// Based on the code logic, nulls are skipped but spaces are still added
		Assert.Contains("Hello", result);
		Assert.Contains("World", result);
		Assert.Contains("!", result);
		Assert.Contains(" ", result);
	}

	[TestMethod]
	public void CombineWithSpace_WithWhitespaceStringsTest()
	{
		var words = new[] { "  ", "\t", "Text", "\n", "   " };
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());

		Assert.Contains("Text", result);
		Assert.Contains("  ", result);
		Assert.Contains("\t", result);
	}

	[TestMethod]
	public void CombineWithSpaceTest()
	{
		var words = RandomData.GenerateWords(3, 2, 5).ToReadOnlyCollection();
		var result = FastStringBuilder.CombineWithSpace(words.AsReadOnlySpan());
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

		Assert.AreEqual(false, string.IsNullOrEmpty(result));

		Assert.AreEqual(ControlChars.EmptyString, FastStringBuilder.Concat(null));
	}

	[TestMethod]
	public void ConcatToStringTest()
	{
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).ToReadOnlyCollection();

		var result = FastStringBuilder.Concat(ControlChars.CommaSpace.ToString(), false, strings);

		Assert.AreEqual(false, string.IsNullOrEmpty(result));

		result = FastStringBuilder.Concat(ControlChars.CommaSpace.ToString(), true, strings);

		Assert.AreEqual(false, string.IsNullOrEmpty(result));

		Assert.AreEqual(ControlChars.EmptyString, FastStringBuilder.Concat(null));
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
	public void PerformAction_WithCapacity_EmptyActionTest()
	{
		Action<StringBuilder> action = (StringBuilder sb) => { };

		var result = FastStringBuilder.PerformAction(100, action);

		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void PerformAction_WithCapacity_ExactCapacityTest()
	{
		var words = new[] { "Hello", "World", "Test" };
		var expectedLength = string.Join("|", words).Length;
		var capacity = expectedLength;

		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			for (var i = 0; i < words.Length; i++)
			{
				_ = sb.Append(words[i]);
				if (i < words.Length - 1)
				{
					_ = sb.Append("|");
				}
			}
		};

		var result = FastStringBuilder.PerformAction(capacity, action);

		Assert.AreEqual("Hello|World|Test", result);
		Assert.AreEqual(expectedLength, result.Length);
	}

	[TestMethod]
	public void PerformAction_WithCapacity_LargeDataTest()
	{
		var capacity = 5000;
		var itemCount = 100;

		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			for (var i = 0; i < itemCount; i++)
			{
				_ = sb.Append($"Item{i}:");
			}
		};

		var result = FastStringBuilder.PerformAction(capacity, action);

		Assert.IsNotNull(result);
		Assert.Contains("Item0:", result);
		Assert.Contains($"Item{itemCount - 1}:", result);
	}

	[TestMethod]
	public void PerformAction_WithCapacity_MaxValueCapacityTest()
	{
		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			_ = sb.Append("Maximum");
		};

		var result = FastStringBuilder.PerformAction(int.MaxValue - 100, action);

		Assert.AreEqual("Maximum", result);
	}

	[TestMethod]
	public void PerformAction_WithCapacity_MultipleAppendsTest()
	{
		var capacity = 200;
		var strings = RandomData.GenerateWords(WordCount, WordMinLength, WordMaxLength).Take(20).ToArray();

		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			foreach (var word in strings)
			{
				_ = sb.Append($"WORD:{word}|");
			}
		};

		var result = FastStringBuilder.PerformAction(capacity, action);

		Assert.IsNotNull(result);
		Assert.StartsWith("WORD:", result);
		Assert.Contains("|", result);
		Assert.AreEqual(strings.Length, result.Count(c => c == '|'));
	}

	[TestMethod]
	public void PerformAction_WithCapacity_NegativeCapacityTest()
	{
		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			_ = sb.Append("Test");
		};

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
		{
			_ = FastStringBuilder.PerformAction(-1, action);
		});
	}

	[TestMethod]
	public void PerformAction_WithCapacity_NullActionTest()
	{
		var result = FastStringBuilder.PerformAction(100, null);

		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void PerformAction_WithCapacity_SmallCapacityGrowthTest()
	{
		var capacity = 10;
		var longText = "This is a much longer text that exceeds the initial capacity";

		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			_ = sb.Append(longText);
		};

		var result = FastStringBuilder.PerformAction(capacity, action);

		Assert.AreEqual(longText, result);
	}

	[TestMethod]
	public void PerformAction_WithCapacity_ValidActionTest()
	{
		var capacity = 500;
		var words = RandomData.GenerateWords(10, 5, 10).ToArray();

		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			foreach (var word in words)
			{
				_ = sb.Append($"{word}|");
			}
		};

		var result = FastStringBuilder.PerformAction(capacity, action);

		Assert.IsNotNull(result);
		Assert.IsGreaterThan(0, result.Length);
		Assert.Contains("|", result);
	}

	[TestMethod]
	public void PerformAction_WithCapacity_ZeroCapacityTest()
	{
		Action<StringBuilder> action = (StringBuilder sb) =>
		{
			_ = sb.Append("Test");
		};

		var result = FastStringBuilder.PerformAction(0, action);

		Assert.AreEqual("Test", result);
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
	public void ToDelimitedString_BooleanValuesTest()
	{
		var dict = new Dictionary<string, bool>
	{
		{ "IsActive", true },
		{ "IsDeleted", false },
		{ "IsVerified", true }
	};
		var result = FastStringBuilder.ToDelimitedString(dict, '|');
		Assert.Contains("IsActive:True", result);
		Assert.Contains("IsDeleted:False", result);
		Assert.Contains("IsVerified:True", result);
	}

	[TestMethod]
	public void ToDelimitedString_DefaultDelimiterTest()
	{
		var dict = new Dictionary<string, int>
	{
		{ "A", 1 },
		{ "B", 2 },
		{ "C", 3 }
	};
		var result = FastStringBuilder.ToDelimitedString(dict);
		Assert.Contains("A:1", result);
		Assert.Contains("B:2", result);
		Assert.Contains("C:3", result);
		Assert.Contains(",", result);
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
	public void ToDelimitedString_DoubleValuesTest()
	{
		var dict = new Dictionary<string, double>
	{
		{ "Pi", 3.14159 },
		{ "E", 2.71828 },
		{ "Golden", 1.61803 }
	};
		var result = FastStringBuilder.ToDelimitedString(dict, ';');
		Assert.Contains("Pi:", result);
		Assert.Contains("E:", result);
		Assert.Contains("Golden:", result);
	}

	[TestMethod]
	public void ToDelimitedString_EmptyDictionaryTest()
	{
		var dict = new Dictionary<string, int>();
		var result = FastStringBuilder.ToDelimitedString(dict);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void ToDelimitedString_EmptyStringValuesTest()
	{
		var dict = new Dictionary<string, string>
	{
		{ "Key1", string.Empty },
		{ "Key2", "Value2" },
		{ "Key3", string.Empty }
	};
		var result = FastStringBuilder.ToDelimitedString(dict, '|');
		Assert.Contains("Key1:", result);
		Assert.Contains("Key2:Value2", result);
		Assert.Contains("Key3:", result);
	}

	[TestMethod]
	public void ToDelimitedString_IntegerKeysTest()
	{
		var dict = new Dictionary<int, string>
	{
		{ 1, "One" },
		{ 2, "Two" },
		{ 3, "Three" }
	};
		var result = FastStringBuilder.ToDelimitedString(dict, '|');
		Assert.Contains("1:One", result);
		Assert.Contains("2:Two", result);
		Assert.Contains("3:Three", result);
		Assert.Contains("|", result);
	}

	[TestMethod]
	public void ToDelimitedString_LargeDictionaryTest()
	{
		var dict = new Dictionary<int, string>();
		for (var i = 0; i < 1000; i++)
		{
			dict.Add(i, $"Value{i}");
		}

		var result = FastStringBuilder.ToDelimitedString(dict);
		Assert.IsNotNull(result);
		Assert.Contains("0:Value0", result);
		Assert.Contains("999:Value999", result);
		Assert.IsGreaterThan(0, result.Length);
	}

	[TestMethod]
	public void ToDelimitedString_MixedValueTypesTest()
	{
		var dict = new Dictionary<string, object>
	{
		{ "String", "Value" },
		{ "Integer", 42 },
		{ "Double", 3.14 },
		{ "Boolean", true }
	};
		var result = FastStringBuilder.ToDelimitedString(dict, ';');
		Assert.Contains("String:Value", result);
		Assert.Contains("Integer:42", result);
		Assert.Contains("Double:3.14", result);
		Assert.Contains("Boolean:True", result);
	}

	[TestMethod]
	public void ToDelimitedString_NullableValuesTest()
	{
		var dict = new Dictionary<string, int?>
	{
		{ "A", 1 },
		{ "B", null },
		{ "C", 3 }
	};
		var result = FastStringBuilder.ToDelimitedString(dict, ',');
		Assert.Contains("A:1", result);
		Assert.Contains("B:", result);
		Assert.Contains("C:3", result);
	}

	[TestMethod]
	public void ToDelimitedString_NullDictionaryTest()
	{
		Dictionary<string, string> dict = null;
		var result = FastStringBuilder.ToDelimitedString(dict);
		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void ToDelimitedString_SingleEntryTest()
	{
		var dict = new Dictionary<string, int>
	{
		{ "Key1", 100 }
	};
		var result = FastStringBuilder.ToDelimitedString(dict);
		Assert.AreEqual("Key1:100", result);
	}

	[TestMethod]
	public void ToDelimitedString_SpecialCharactersTest()
	{
		var dict = new Dictionary<string, string>
	{
		{ "Key@1", "Value#1" },
		{ "Key$2", "Value%2" },
		{ "Key&3", "Value*3" }
	};
		var result = FastStringBuilder.ToDelimitedString(dict, '|');
		Assert.Contains("Key@1:Value#1", result);
		Assert.Contains("Key$2:Value%2", result);
		Assert.Contains("Key&3:Value*3", result);
	}

	[TestMethod]
	public void ToDelimitedString_WhitespaceValuesTest()
	{
		var dict = new Dictionary<string, string>
	{
		{ "Key1", "  " },
		{ "Key2", "\t" },
		{ "Key3", "\n" }
	};
		var result = FastStringBuilder.ToDelimitedString(dict, ',');
		Assert.Contains("Key1:  ", result);
		Assert.Contains("Key2:\t", result);
		Assert.Contains("Key3:\n", result);
	}

}
