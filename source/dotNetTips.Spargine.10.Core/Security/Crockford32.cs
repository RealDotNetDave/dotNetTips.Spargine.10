// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-14-2026
//
// Last Modified By : David McCarter
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="Crockford32.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides encoding and decoding support for the Crockford Base32 encoding scheme.
// Crockford Base32 uses a 32-character alphabet (0-9, A-Z excluding I, L, O, U) to
// produce human-readable, case-insensitive, URL-safe encoded strings.
// </summary>
// ***********************************************************************

using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Provides encoding and decoding support for the Crockford Base32 encoding scheme.
/// Crockford Base32 uses a 32-character alphabet (digits 0–9 and letters A–Z, excluding I, L, O, and U)
/// to produce human-readable, case-insensitive, URL-safe encoded strings.
/// Ambiguous characters (I, L → 1; O → 0) are automatically normalized during decoding.
/// </summary>
[Information(nameof(Crockford32), Status = Status.New)]
public static class Crockford32
{
	private const string Alphabet = "0123456789ABCDEFGHJKMNPQRSTVWXYZ";
	private static readonly sbyte[] Map = BuildMap();

	/// <summary>
	/// Decodes a Crockford Base32 encoded string into the original byte array.
	/// </summary>
	/// <param name="text">The Crockford Base32 encoded string to decode. Hyphens and spaces are ignored. Ambiguous characters (I, L → 1; O → 0) are automatically substituted.</param>
	/// <returns>
	/// A <see cref="byte"/> array containing the decoded data, or an empty array if <paramref name="text"/> is <see langword="null"/>, empty, or whitespace.
	/// </returns>
	/// <exception cref="FormatException">Thrown when the input contains a character that is not valid in the Crockford Base32 alphabet.</exception>
	[Pure]
	[Information(nameof(Decode), "Copilot Agent", "07-09-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static byte[] Decode(string text)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return [];
		}

		Span<char> norm = stackalloc char[text.Length];
		var nc = NormalizeChars(text, norm);

		int buffer = 0, bitsLeft = 0;
		var bytes = new List<byte>((int)Math.Floor(nc * 5 / 8.0));

		for (var index = 0; index < nc; index++)
		{
			var c = norm[index];
			var v = c < 128 ? Map[c] : -1;

			if (v < 0)
			{
				throw new FormatException($"Invalid Base32 character '{c}'.");
			}

			buffer = (buffer << 5) | v;
			bitsLeft += 5;

			if (bitsLeft >= 8)
			{
				bytes.Add((byte)((buffer >> (bitsLeft - 8)) & 0xFF));
				bitsLeft -= 8;
			}
		}

		return [.. bytes];
	}

	/// <summary>
	/// Encodes a byte span into a Crockford Base32 string.
	/// </summary>
	/// <param name="data">The raw bytes to encode.</param>
	/// <returns>
	/// A Crockford Base32 encoded <see cref="string"/> representing the input bytes,
	/// or <see cref="string.Empty"/> if <paramref name="data"/> is empty.
	/// </returns>
	[Pure]
	[Information(nameof(Encode), "Copilot Agent", "07-09-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static string Encode(ReadOnlySpan<byte> data)
	{
		if (data.Length == 0)
		{
			return string.Empty;
		}

		var sb = new StringBuilder((int)Math.Ceiling(data.Length * 8 / 5.0));
		int buffer = 0, bitsLeft = 0;

		foreach (var byteIndex in data)
		{
			buffer = (buffer << 8) | byteIndex;
			bitsLeft += 8;

			while (bitsLeft >= 5)
			{
				var index = (buffer >> (bitsLeft - 5)) & 31;
				_ = sb.Append(Alphabet[index]);
				bitsLeft -= 5;
			}
		}

		if (bitsLeft > 0)
		{
			var index = (buffer << (5 - bitsLeft)) & 31;
			_ = sb.Append(Alphabet[index]);
		}

		return sb.ToString();
	}

	/// <summary>
	/// Builds the ASCII-to-value lookup table for the Crockford Base32 alphabet,
	/// including ambiguity aliases (I/L → 1, O → 0) and lowercase equivalents.
	/// </summary>
	/// <returns>A 128-element <see cref="sbyte"/> array where each index corresponds to an ASCII code point.
	/// Valid alphabet characters map to their 5-bit value (0–31); all other entries are -1.</returns>
	private static sbyte[] BuildMap()
	{
		var map = Enumerable.Repeat<sbyte>(-1, 128).ToArray();

		for (var @char = 0; @char < Alphabet.Length; @char++)
		{
			map[Alphabet[@char]] = (sbyte)@char;
		}

		// Ambiguity aliases
		map['I'] = map['1'] = map['L'] = map['1'];
		map['O'] = map['0'] = map['0'];

		// Lowercase support
		for (var @char = 'a'; @char <= 'z'; @char++)
		{
			var upchar = char.ToUpperInvariant(@char);

			if (upchar < 128 && map[upchar] >= 0)
			{
				map[@char] = map[upchar];
			}
		}

		return map;
	}

	/// <summary>
	/// Normalizes the characters in <paramref name="text"/> for decoding by removing separators,
	/// converting to uppercase, and replacing ambiguous characters (I/L → '1', O → '0').
	/// </summary>
	/// <param name="text">The raw input string to normalize.</param>
	/// <param name="norm">A caller-supplied span that receives the normalized characters. Must be at least as long as <paramref name="text"/>.</param>
	/// <returns>The number of significant characters written to <paramref name="norm"/>.</returns>
	private static int NormalizeChars(string text, Span<char> norm)
	{
		var number = 0;

		foreach (var ch in text)
		{
			if (ch is '-' or ' ')
			{
				continue;
			}

			var c = char.ToUpperInvariant(ch);

			if (c is 'I' or 'L')
			{
				c = '1';
			}
			else if (c == 'O')
			{
				c = '0';
			}

			norm[number++] = c;
		}

		return number;
	}
}

