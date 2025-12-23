// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 05-22-2025
// ***********************************************************************
// <copyright file="PasswordGenerator.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Class PasswordGenerator.
/// Provides functionality to generate random passwords with a mix of uppercase letters, lowercase letters, digits, and special characters.
/// </summary>
[Information(Status = Status.Available)]
public static class PasswordGenerator
{
	private const string Digits = "0123456789";
	private const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
	private const string SpecialChars = "!@#$%^&*()_-+=<>?";
	private const string Uppercase = "ABCDEFGHIJKLMNOPQRST" +
		"UVWXYZ";

	/// <summary>
	/// A shared instance of RandomNumberGenerator for reuse.
	/// </summary>
	private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Shuffles an array in place using Fisher-Yates algorithm.
	/// </summary>
	/// <param name="array">The array to shuffle.</param>
	private static void ShuffleArray(char[] array)
	{
		for (var index = array.Length - 1; index > 0; index--)
		{
			var j = RandomNumberGenerator.GetInt32(index + 1); // Use the class name to call the static method
			(array[index], array[j]) = (array[j], array[index]); // Swap elements
		}
	}

	/// <summary>
	/// Generates a random password with the specified length.
	/// The password will contain a mix of uppercase letters, lowercase letters, digits, and special characters.
	/// </summary>
	/// <param name="length">The length of the password to generate. Must be at least 8 characters.</param>
	/// <returns>A randomly generated password string.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the length is less than 8.</exception>
	/// <example>Password example: ik)-qm%OomiO</example>
	[Pure]
	[Information(nameof(GeneratePassword), "David McCarter", "11/12/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GeneratePassword(int length = 8)
	{
		length = length.ArgumentInRange(8, errorMessage: "Password length must be at least 8 characters.");

		var sb = _stringBuilderPool.Value.Get().ClearSetCapacity(length);

		try
		{
			// Ensure at least one character from each category
			var requiredCharacters = new[]
			{
				Uppercase[RandomNumberGenerator.GetInt32(Uppercase.Length)],
				Lowercase[RandomNumberGenerator.GetInt32(Lowercase.Length)],
				Digits[RandomNumberGenerator.GetInt32(Digits.Length)],
				SpecialChars[RandomNumberGenerator.GetInt32(SpecialChars.Length)]
			};

			// Add required characters to the StringBuilder
			foreach (var ch in requiredCharacters)
			{
				_ = sb.Append(ch);
			}

			// Fill the remaining characters randomly from the combined pool
			var characterPoolSpan = (Uppercase + Lowercase + Digits + SpecialChars).AsSpan();
			var randomNumber = new byte[4];

			for (var charIndex = requiredCharacters.Length; charIndex < length; charIndex++)
			{
				_rng.GetBytes(randomNumber);
				var index = BitConverter.ToUInt32(randomNumber, 0) % characterPoolSpan.Length;
				_ = sb.Append(characterPoolSpan[(int)index]);
			}

			// Shuffle the characters to randomize their positions
			var passwordArray = sb.ToString().ToCharArray();
			ShuffleArray(passwordArray);

			return new string(passwordArray);
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb.Clear());
		}
	}
}

