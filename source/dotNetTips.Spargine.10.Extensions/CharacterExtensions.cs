// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 06-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 02-17-2026
// ***********************************************************************
// <copyright file="CharacterExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for System.Char providing high-performance ASCII character classification
// (digit, letter, uppercase, lowercase, hexadecimal, punctuation, control, whitespace, newline),
// fast case conversion (ToAsciiUpper, ToAsciiLower), and digit value extraction. All methods
// are aggressively inlined for optimal performance in character processing scenarios.
// </summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="char"/> to determine ASCII character types.
/// </summary>
[Information(Status = Status.New, Documentation = "ADD URL")]
public static class CharacterExtensions
{
	/// <summary>
	/// Extension methods for <see cref="char"/> to determine ASCII character types.
	/// </summary>
	/// <param name="character">The character to evaluate.</param>
	extension(char character)
	{
		/// <summary>
		/// Gets a value indicating whether the specified character is an ASCII digit.
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is an ASCII digit; otherwise, <c>false</c>.
		/// </value>
		/// <remarks>
		/// This property checks if the character is a digit using <see cref="char.IsDigit(char)"/>.
		/// </remarks>
		[Information("IsAsciiDigit", author: "David McCarter", createdOn: "6/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsAsciiDigit
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => char.IsDigit(character);
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is an ASCII letter.
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is an ASCII letter; otherwise, <c>false</c>.
		/// </value>
		/// <remarks>
		/// This property checks if the character is a letter using <see cref="char.IsLetter(char)"/>.
		/// </remarks>
		[Information("IsAsciiLetter", author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsAsciiLetter
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => char.IsLetter(character);
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is within the ASCII range (0-127).
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is ASCII (0-127); otherwise, <c>false</c>.
		/// </value>
		[Information("IsAscii", author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public bool IsAscii
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => character <= 127;
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is an ASCII uppercase letter (A-Z).
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is an ASCII uppercase letter; otherwise, <c>false</c>.
		/// </value>
		[Information("IsAsciiUpper", author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public bool IsAsciiUpper
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => character is >= 'A' and <= 'Z';
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is an ASCII lowercase letter (a-z).
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is an ASCII lowercase letter; otherwise, <c>false</c>.
		/// </value>
		[Information("IsAsciiLower", author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public bool IsAsciiLower
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => character is >= 'a' and <= 'z';
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is a valid hexadecimal digit (0-9, A-F, a-f).
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is a hexadecimal digit; otherwise, <c>false</c>.
		/// </value>
		[Information("IsHexDigit", author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public bool IsHexDigit
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => char.IsAsciiHexDigit(character);
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is a newline character (CR or LF).
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is a newline character; otherwise, <c>false</c>.
		/// </value>
		[Information("IsNewLine", author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public bool IsNewLine
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => character is '\r' or '\n';
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is an ASCII punctuation character.
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is an ASCII punctuation character; otherwise, <c>false</c>.
		/// </value>
		[Information("IsAsciiPunctuation", author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public bool IsAsciiPunctuation
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => char.IsPunctuation(character) && character <= 127;
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is an ASCII control character (0-31 or 127).
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is an ASCII control character; otherwise, <c>false</c>.
		/// </value>
		[Information("IsAsciiControl", author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public bool IsAsciiControl
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => char.IsControl(character) && character <= 127;
		}

		/// <summary>
		/// Gets the uppercase equivalent of the character using ASCII rules (fast path for A-Z range).
		/// </summary>
		/// <value>
		/// The uppercase equivalent of the character if it is a lowercase ASCII letter; otherwise, the original character.
		/// </value>
		[Information("ToAsciiUpper", author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public char ToAsciiUpper
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => character is >= 'a' and <= 'z' ? (char)(character - 32) : character;
		}

		/// <summary>
		/// Converts the character to lowercase using ASCII rules (fast path for a-z range).
		/// </summary>
		/// <returns>The lowercase equivalent of the character if it is an uppercase ASCII letter; otherwise, the original character.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToAsciiLower), author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public char ToAsciiLower()
		{
			return character is >= 'A' and <= 'Z' ? (char)(character + 32) : character;
		}

		/// <summary>
		/// Gets the numeric value of the character if it is a digit (0-9).
		/// </summary>
		/// <returns>The numeric value (0-9) if the character is a digit; otherwise, -1.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetDigitValue), author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public int GetDigitValue()
		{
			return character is >= '0' and <= '9' ? character - '0' : -1;
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is an ASCII letter or digit.
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is an ASCII letter or digit; otherwise, <c>false</c>.
		/// </value>
		/// <remarks>
		/// This property checks if the character is a letter or digit using <see cref="char.IsLetterOrDigit(char)"/>.
		/// </remarks>
		[Information("IsAsciiLetterOrDigit", author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsAsciiLetterOrDigit
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => char.IsLetterOrDigit(character);
		}

		/// <summary>
		/// Gets a value indicating whether the specified character is an ASCII whitespace character.
		/// </summary>
		/// <value>
		/// <c>true</c> if the character is an ASCII whitespace character; otherwise, <c>false</c>.
		/// </value>
		/// <remarks>
		/// This property checks if the character is a whitespace character using <see cref="char.IsWhiteSpace(char)"/>.
		/// </remarks>
		[Information("IsAsciiWhitespace", author: "David McCarter", createdOn: "6/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsAsciiWhitespace
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => char.IsWhiteSpace(character);
		}

	}
}
