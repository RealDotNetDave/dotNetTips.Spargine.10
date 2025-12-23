// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 06-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2025
// ***********************************************************************
// <copyright file="CharacterExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="char"/> to determine ASCII character types.
/// </summary>
[Information(Status = Status.New)]
public static class CharacterExtensions
{
	/// <summary>
	/// Extension methods for <see cref="char"/> to determine ASCII character types.
	/// </summary>
	/// <param name="character">The character to evaluate.</param>
	extension(char character)
	{
		/// <summary>
		/// Determines whether the specified character is an ASCII digit.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the character is an ASCII digit; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// This method checks if the character is a digit using <see cref="char.IsDigit(char)"/>.
		/// </remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsAsciiDigit), author: "David McCarter", createdOn: "6/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsAsciiDigit()
		{
			return char.IsDigit(character);
		}

		/// <summary>
		/// Determines whether the specified character is an ASCII letter.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the character is an ASCII letter; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// This method checks if the character is a letter using <see cref="char.IsLetter(char)"/>.
		/// </remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsAsciiLetter), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsAsciiLetter()
		{
			return char.IsLetter(character);
		}

		/// <summary>
		/// Determines whether the specified character is an ASCII letter or digit.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the character is an ASCII letter or digit; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// This method checks if the character is a letter or digit using <see cref="char.IsLetterOrDigit(char)"/>.
		/// </remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsAsciiLetterOrDigit), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsAsciiLetterOrDigit()
		{
			return char.IsLetterOrDigit(character);
		}

		/// <summary>
		/// Determines whether the specified character is an ASCII whitespace character.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the character is an ASCII whitespace character; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// This method checks if the character is a whitespace character using <see cref="char.IsWhiteSpace(char)"/>.
		/// </remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsAsciiWhitespace), author: "David McCarter", createdOn: "6/10/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsAsciiWhitespace()
		{
			return char.IsWhiteSpace(character);
		}

	}
}
