// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 02-17-2026
//
// Last Modified By : David McCarter
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="CharacterExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CharacterExtensionsTests
{

	[TestMethod]
	public void GetDigitValue_Digit_ReturnsNumericValue()
	{
		Assert.AreEqual(0, '0'.GetDigitValue());
		Assert.AreEqual(5, '5'.GetDigitValue());
		Assert.AreEqual(9, '9'.GetDigitValue());
	}

	[TestMethod]
	public void GetDigitValue_NonDigit_ReturnsNegativeOne()
	{
		Assert.AreEqual(-1, 'a'.GetDigitValue());
		Assert.AreEqual(-1, '!'.GetDigitValue());
		Assert.AreEqual(-1, ' '.GetDigitValue());
	}

	[TestMethod]
	public void IsAsciiControl_ControlCharacter_ReturnsTrue()
	{
		Assert.IsTrue('\0'.IsAsciiControl);
		Assert.IsTrue('\t'.IsAsciiControl);
		Assert.IsTrue('\n'.IsAsciiControl);
	}

	[TestMethod]
	public void IsAsciiControl_NonControl_ReturnsFalse()
	{
		Assert.IsFalse('a'.IsAsciiControl);
		Assert.IsFalse(' '.IsAsciiControl);
		Assert.IsFalse('5'.IsAsciiControl);
	}

	[TestMethod]
	public void IsAsciiPunctuation_NonPunctuation_ReturnsFalse()
	{
		Assert.IsFalse('a'.IsAsciiPunctuation);
		Assert.IsFalse('5'.IsAsciiPunctuation);
		Assert.IsFalse(' '.IsAsciiPunctuation);
	}

	[TestMethod]
	public void IsAsciiPunctuation_Punctuation_ReturnsTrue()
	{
		Assert.IsTrue('.'.IsAsciiPunctuation);
		Assert.IsTrue(','.IsAsciiPunctuation);
		Assert.IsTrue('!'.IsAsciiPunctuation);
		Assert.IsTrue('?'.IsAsciiPunctuation);
	}

	[TestMethod]
	public void IsAsciiUpper_NonUppercase_ReturnsFalse()
	{
		Assert.IsFalse('a'.IsAsciiUpper);
		Assert.IsFalse('z'.IsAsciiUpper);
		Assert.IsFalse('5'.IsAsciiUpper);
	}

	[TestMethod]
	public void IsAsciiUpper_UppercaseLetter_ReturnsTrue()
	{
		Assert.IsTrue('A'.IsAsciiUpper);
		Assert.IsTrue('Z'.IsAsciiUpper);
		Assert.IsTrue('M'.IsAsciiUpper);
	}

	[TestMethod]
	public void IsAsciiWhitespace_NonWhitespace_ReturnsFalse()
	{
		Assert.IsFalse('a'.IsAsciiWhitespace);
		Assert.IsFalse('5'.IsAsciiWhitespace);
		Assert.IsFalse('!'.IsAsciiWhitespace);
	}

	[TestMethod]
	public void IsAsciiWhitespace_Whitespace_ReturnsTrue()
	{
		Assert.IsTrue(' '.IsAsciiWhitespace);
		Assert.IsTrue('\t'.IsAsciiWhitespace);
		Assert.IsTrue('\n'.IsAsciiWhitespace);
		Assert.IsTrue('\r'.IsAsciiWhitespace);
	}

	[TestMethod]
	public void IsHexDigit_InvalidHex_ReturnsFalse()
	{
		Assert.IsFalse('G'.IsHexDigit);
		Assert.IsFalse('g'.IsHexDigit);
		Assert.IsFalse('!'.IsHexDigit);
		Assert.IsFalse(' '.IsHexDigit);
	}

	[TestMethod]
	public void IsHexDigit_ValidHex_ReturnsTrue()
	{
		Assert.IsTrue('0'.IsHexDigit);
		Assert.IsTrue('9'.IsHexDigit);
		Assert.IsTrue('A'.IsHexDigit);
		Assert.IsTrue('F'.IsHexDigit);
		Assert.IsTrue('a'.IsHexDigit);
		Assert.IsTrue('f'.IsHexDigit);
	}

	[TestMethod]
	public void IsNewLine_NewLineCharacter_ReturnsTrue()
	{
		Assert.IsTrue('\r'.IsNewLine);
		Assert.IsTrue('\n'.IsNewLine);
	}

	[TestMethod]
	public void IsNewLine_NonNewLine_ReturnsFalse()
	{
		Assert.IsFalse(' '.IsNewLine);
		Assert.IsFalse('\t'.IsNewLine);
		Assert.IsFalse('a'.IsNewLine);
	}
	[TestMethod]
	public void IsUnicodeDigit_AsciiDigit_ReturnsTrue()
	{
		Assert.IsTrue('0'.IsUnicodeDigit);
		Assert.IsTrue('5'.IsUnicodeDigit);
		Assert.IsTrue('9'.IsUnicodeDigit);
	}

	[TestMethod]
	public void IsUnicodeDigit_NonDigit_ReturnsFalse()
	{
		Assert.IsFalse('a'.IsUnicodeDigit);
		Assert.IsFalse('Z'.IsUnicodeDigit);
		Assert.IsFalse('!'.IsUnicodeDigit);
		Assert.IsFalse(' '.IsUnicodeDigit);
	}

	[TestMethod]
	public void ToAsciiLower_NonUppercase_ReturnsSameCharacter()
	{
		Assert.AreEqual('a', 'a'.ToAsciiLower());
		Assert.AreEqual('5', '5'.ToAsciiLower());
		Assert.AreEqual('!', '!'.ToAsciiLower());
	}

	[TestMethod]
	public void ToAsciiLower_UppercaseLetter_ReturnsLowercase()
	{
		Assert.AreEqual('a', 'A'.ToAsciiLower());
		Assert.AreEqual('z', 'Z'.ToAsciiLower());
		Assert.AreEqual('m', 'M'.ToAsciiLower());
	}

	[TestMethod]
	public void ToAsciiUpper_LowercaseLetter_ReturnsUppercase()
	{
		Assert.AreEqual('A', 'a'.ToAsciiUpper());
		Assert.AreEqual('Z', 'z'.ToAsciiUpper());
		Assert.AreEqual('M', 'm'.ToAsciiUpper());
	}

	[TestMethod]
	public void ToAsciiUpper_NonLowercase_ReturnsSameCharacter()
	{
		Assert.AreEqual('A', 'A'.ToAsciiUpper());
		Assert.AreEqual('5', '5'.ToAsciiUpper());
		Assert.AreEqual('!', '!'.ToAsciiUpper());
	}

}
