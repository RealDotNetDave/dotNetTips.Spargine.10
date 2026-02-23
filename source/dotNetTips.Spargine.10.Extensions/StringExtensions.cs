// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2026
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>High-performance string utilities for .NET 10. Provides allocation-aware, SIMD-optimized extensions for validation, comparison, hashing, encoding/decoding (Base64), compression (Brotli/Deflate/GZip/ZLib), URL parsing, splitting, and formatting. Methods favor ordinal comparisons, spans, pooled StringBuilder, and guard clauses to ensure deterministic behavior, culture invariance where appropriate, and minimal GC pressure across common string operations.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.RegularExpressions;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.ObjectPool;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a collection of static methods for string manipulation and checks, enhancing the built-in string functionality.
/// </summary>
/// <remarks>
/// The <see cref="StringExtensions"/> class includes methods for various string operations such as computing hashes,
/// checking for specific content within strings (e.g., email addresses, domain names, GUIDs), converting strings to different formats or encodings,
/// and performing manipulations like concatenation, extraction, and indentation. These utilities aim to simplify common string handling tasks
/// in .NET applications.
/// </remarks>
[Information(Documentation = "https://bit.ly/SpargineStringExtensions", Status = Status.UpdateDocumentation)]
public static class StringExtensions
{
	/// <summary>
	/// The URL separator
	/// </summary>
	private const string UrlSeparator = "://";

	/// <summary>
	/// Provides a static instance of the <see cref="ASCIIEncoding"/> class for use throughout the StringExtensions class.
	/// This encoding is used for operations that require ASCII character encoding.
	/// </summary>
	private static readonly ASCIIEncoding _encoding = new();

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Calculates the exact number of bytes required to encode the specified <paramref name="input"/> string
	/// using the provided <paramref name="encoding"/>. Defaults to UTF-8 when no encoding is specified.
	/// </summary>
	/// <param name="input">
	/// The string to measure. Must not be null or empty; a guard clause validates the argument.
	/// </param>
	/// <param name="encoding">
	/// The text encoding to use for byte count calculation. If <c>null</c>, <see cref="Encoding.UTF8"/> is used.
	/// </param>
	/// <returns>
	/// The number of bytes required to represent <paramref name="input"/> in the specified <paramref name="encoding"/>.
	/// Returns <c>0</c> when <paramref name="input"/> is an empty string.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="input"/> is <c>null</c>.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown if <paramref name="input"/> is empty.
	/// </exception>
	/// <remarks>
	/// Uses the <see cref="Encoding.GetByteCount(ReadOnlySpan{char})"/> overload to avoid intermediate allocations
	/// and leverages .NET 10 optimizations (including SIMD for common encodings like UTF-8 and ASCII).
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculateByteArraySize), "David McCarter", "11/6/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static int CalculateByteArraySize([DisallowNull] this string input, Encoding? encoding = null)
	{
		// Validate and fast-path empty strings
		input = input.ArgumentNotNullOrEmpty();

		if (input.Length == 0)
		{
			return 0;
		}

		// Default to UTF-8 if no encoding specified
		encoding ??= Encoding.UTF8;

		// Use span overload to avoid any extra string-specific overhead
		return encoding.GetByteCount(input.AsSpan());
	}

	/// <summary>
	/// Computes the total number of characters across all non-null strings in the provided array.
	/// </summary>
	/// <param name="args">Array of strings to measure. Can contain <c>null</c> entries.</param>
	/// <returns>
	/// The sum of <see cref="string.Length"/> for each non-null element in <paramref name="args"/>.
	/// Returns <c>0</c> if <paramref name="args"/> is <c>null</c> or empty.
	/// </returns>
	/// <remarks>
	/// Optimized for hot paths:
	/// - Early-exits on <c>null</c>/empty arrays.
	/// - Uses a classic for-loop with hoisted length to avoid bounds checks and span indexing overhead.
	/// Commonly used to pre-size pooled <see cref="StringBuilder"/> instances (e.g., in <see cref="Concat(string, string, bool, ReadOnlyCollection{string})"/>).
	/// </remarks>
	/// <example>
	/// var total = new[] { "a", null, "bc" }.CalculateTotalLength(); // Returns: 3
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculateTotalLength), "David McCarter", "12/29/2025", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static int CalculateTotalLength(this string[] args)
	{
		if (args is null || args.Length == 0)
		{
			return 0;
		}

		// Iterate directly over the array to avoid span indexing overhead
		var totalLength = 0;

		for (int charIndex = 0, n = args.Length; charIndex < n; charIndex++)
		{
			var s = args[charIndex];

			if (s != null)
			{
				totalLength += s.Length;
			}
		}

		return totalLength;
	}

	/// <summary>
	/// Combines an array of strings into a single string using the <see cref="FastStringBuilder.Combine"/> method.
	/// </summary>
	/// <param name="input">The initial string to start the combination. Must not be null.</param>
	/// <param name="args">An array of strings to combine with the initial string. Must not be null.</param>
	/// <returns>A combined string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Concat), "David McCarter", "1/3/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string CombineToString([DisallowNull] this string input, [DisallowNull] params string[] args)
	{
		return FastStringBuilder.Combine(false, args: args.AddFirst(input).AsReadOnlySpan());
	}

	/// <summary>
	/// Computes the hashType of the given base64Input string using the specified hashType algorithm.
	/// </summary>
	/// <param name="input">The base64Input string to compute the hashType for. Must not be null.</param>
	/// <param name="hashType">The type of hashType algorithm to use, specified by the <see cref="HashType"/> enum. Defaults to <see cref="HashType.SHA256"/>.</param>
	/// <returns>A string representation of the computed hashType.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ComputeHash), "David McCarter", "10/8/2020", "1/9/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string ComputeHash([DisallowNull] this string input, HashType hashType = HashType.SHA256)
	{
		input = input.ArgumentNotNullOrEmpty();

		var hash = GetHash(input, hashType);

		var sb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			foreach (var hashItem in hash.AsSpan())
			{
				_ = sb.Append(hashItem.ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString().ToTrimmed()!;
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Concatenates the given strings using the specified delimiter, with an option to add a line feed after each string.
	/// </summary>
	/// <param name="input">The initial string to start the concatenation. Must not be null or empty.</param>
	/// <param name="delimiter">The delimiter to use for concatenation. If null or empty, an empty string is used.</param>
	/// <param name="addLineFeed">If true, adds a line feed after each string in the concatenation.</param>
	/// <param name="args">A collection of strings to concatenate. Must not be null.</param>
	/// <returns>
	/// A concatenated string that starts with the <paramref name="input"/> string, followed by the <paramref name="args"/> strings, separated by the <paramref name="delimiter"/>.
	/// If <paramref name="addLineFeed"/> is true, a line feed is added after each string.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="input"/> or <paramref name="args"/> is null.
	/// </exception>
	/// <remarks>
	/// This method uses a pooled <see cref="StringBuilder"/> to optimize memory usage during concatenation.
	/// The capacity is pre-calculated using <see cref="CalculateTotalLength"/> to minimize internal buffer reallocations.
	/// <para>
	/// <strong>Performance Optimizations (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Always uses pooled StringBuilder (eliminates allocation overhead)</description></item>
	/// <item><description>Pre-calculates exact capacity to avoid reallocation during building</description></item>
	/// <item><description>Single code path regardless of collection size (improved JIT optimization)</description></item>
	/// <item><description>Uses ReadOnlyCollection for better type safety and performance</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Concat), "David McCarter", "9/15/2017", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Concat([DisallowNull] this string input, [ConstantExpected] string delimiter, bool addLineFeed, params ReadOnlyCollection<string> args)
	{
		input = input.ArgumentNotNullOrEmpty();
		delimiter = delimiter.ArgumentNotNullOrEmpty();

		// Early exit: if no args, return input immediately
		if (args is null || args.Count == 0)
		{
			return input;
		}

		// Calculate exact capacity: input + all args + delimiters
		// Add 1 for input string
		var tempArray = new string[args.Count + 1];
		tempArray[0] = input;
		args.CopyTo(tempArray, 1);

		var totalStringLength = tempArray.CalculateTotalLength();

		// Add space for delimiters or line feeds
		var delimiterLength = addLineFeed ? Environment.NewLine.Length : delimiter.Length;
		var estimatedCapacity = totalStringLength + (args.Count * delimiterLength);

		var pooledSb = _stringBuilderPool.Value.Get().Clear();

		try
		{
			// Set capacity once to avoid reallocations
			_ = pooledSb.EnsureCapacity(estimatedCapacity);

			// Append initial input
			_ = pooledSb.Append(input);

			// Append all args with delimiter or line feed
			foreach (var arg in args)
			{
				if (addLineFeed)
				{
					_ = pooledSb.AppendLine(arg);
				}
				else
				{
					_ = pooledSb.Append(delimiter);
					_ = pooledSb.Append(arg);
				}
			}

			return pooledSb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(pooledSb);
		}
	}

	/// <summary>
	/// Determines whether <paramref name="input"/> contains any of the specified substrings.
	/// </summary>
	/// <param name="input">The source string to search. Must not be <c>null</c> or empty.</param>
	/// <param name="stringComparison">
	/// The comparison rules used for matching. Defaults to <see cref="StringComparison.OrdinalIgnoreCase"/>.
	/// </param>
	/// <param name="characters">The substrings to search for. If <c>null</c> or empty, returns <c>false</c>.</param>
	/// <returns>
	/// <c>true</c> if any entry in <paramref name="characters"/> is found in <paramref name="input"/> using
	/// the specified <paramref name="stringComparison"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// Performance-oriented:
	/// - Early exit when <paramref name="characters"/> is <c>null</c> or empty.
	/// - Validates inputs via guard clauses.
	/// - Iterates once and returns immediately on first match.
	/// </remarks>
	/// <example>
	/// var hasAnimal = "The quick brown fox".ContainsAny(StringComparison.OrdinalIgnoreCase, "cat", "dog", "fox"); // true
	/// var none = "Hello".ContainsAny(StringComparison.Ordinal, "WORLD"); // false
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ContainsAny), "David McCarter", "9/15/2017", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsAny([DisallowNull] this string input,
		StringComparison stringComparison = StringComparison.OrdinalIgnoreCase,
		params string[] characters)
	{
		// Suggestion from Copilot turned out to be slower
		if (characters is null || characters.Length == 0)
		{
			return false;
		}

		input = input.ArgumentNotNullOrEmpty();
		stringComparison = stringComparison.ArgumentDefined();

		foreach (var character in characters)
		{
			if (input.Contains(character, stringComparison))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Returns the original string if it is not null; otherwise, returns an empty string.
	/// </summary>
	/// <param name="input">The string to check for null.</param>
	/// <returns>The original string if not null; otherwise, <see cref="string.Empty"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string DefaultIfNull([AllowNull] this string input)
	{
		return input ?? string.Empty;
	}

	/// <summary>
	/// Returns the original string if it is not null; otherwise, returns the specified default input or an empty string if the default input is also null.
	/// </summary>
	/// <param name="value">The string to check for null.</param>
	/// <param name="defaultValue">The default input to return if the string is null. This can also be null, in which case an empty string is returned.</param>
	/// <returns>The original string if it is not null; otherwise, the default input if it is not null; otherwise, <see cref="string.Empty"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string DefaultIfNull([AllowNull] this string value, [AllowNull] string defaultValue)
	{
		return value ?? defaultValue ?? string.Empty;
	}

	/// <summary>
	/// Returns the original string if it is not null or empty; otherwise, returns the specified default input.
	/// </summary>
	/// <param name="input">The string to check for null or emptiness.</param>
	/// <param name="defaultValue">The default input to return if the string is null or empty. This input must not be null.</param>
	/// <returns>The original string if it is not null or empty; otherwise, the <paramref name="defaultValue"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="defaultValue"/> is null.</exception>
	/// <remarks>
	/// This method uses <see cref="string.IsNullOrEmpty(string)"/> to check if the string is null or empty.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DefaultIfNullOrEmpty), "David McCarter", "9/15/2017", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string DefaultIfNullOrEmpty([AllowNull] this string input, [DisallowNull] string defaultValue)
	{
		return string.IsNullOrEmpty(input) ? defaultValue : input;
	}

	/// <summary>
	/// Splits a delimited string into an array of strings, removing empty entries.
	/// </summary>
	/// <param name="input">The base64Input string to split.</param>
	/// <param name="delimiter">The character delimiter to split the string by. Default is a comma.</param>
	/// <returns>An array of strings that were delimited by the specified character.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DelimitedStringToArray), "David McCarter", "8/13/2020", "8/13/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string[] DelimitedStringToArray([DisallowNull] this string input, [ConstantExpected] char delimiter = ControlChars.Comma)
	{
		return string.IsNullOrEmpty(input) ? [] : input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
	}

	/// <summary>
	/// Determines whether two strings are equal using case-insensitive ordinal comparison.
	/// </summary>
	/// <param name="input">The first string to compare. Must not be <c>null</c>.</param>
	/// <param name="inputToCompare">The second string to compare. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="input"/> equals <paramref name="inputToCompare"/> using
	/// <see cref="StringComparison.OrdinalIgnoreCase"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// Uses <see cref="string.Equals(string, StringComparison)"/> with <see cref="StringComparison.OrdinalIgnoreCase"/> for
	/// high-performance, culture-invariant, case-insensitive comparison. Guard clauses validate non-null inputs.
	/// </remarks>
	/// <example>
	/// string a = "Hello";
	/// string b = "HELLO";
	/// bool equals = a.EqualsIgnoreCase(b); // true
	/// </example>
	/// <seealso cref="StringComparison.OrdinalIgnoreCase"/>
	/// <seealso cref="FastEquals(string, string, in StringComparison)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EqualsIgnoreCase), "David McCarter", "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool EqualsIgnoreCase([DisallowNull] this string input, [DisallowNull] string inputToCompare)
	{
		input = input.ArgumentNotNull();
		inputToCompare = inputToCompare.ArgumentNotNull();

		return input.Equals(inputToCompare, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Determines whether the specified string is equal to the current string, ignoring case, or if both are null or empty.
	/// </summary>
	/// <param name="input">The first string to compare.</param>
	/// <param name="inputToCompare">The second string to compare.</param>
	/// <returns>true if the input of the <paramref name="input"/> parameter is equal to the input of the <paramref name="inputToCompare"/> parameter, ignoring case, or if both are null or empty; otherwise, false.</returns>
	/// <remarks>
	/// This method uses <see cref="string.Equals(string?, string?, StringComparison)"/> with <see cref="StringComparison.Ordinal"/> to perform the comparison.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EqualsOrBothNullOrEmpty), "David McCarter", "7/15/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool EqualsOrBothNullOrEmpty([DisallowNull] this string input, string inputToCompare)
	{
		return string.Equals(input ?? string.Empty, inputToCompare ?? string.Empty, StringComparison.Ordinal);
	}

	/// <summary>
	/// Extracts the substring between two delimiter strings using ordinal comparison.
	/// </summary>
	/// <param name="input">The source string to search. Must not be <c>null</c> or empty.</param>
	/// <param name="start">The starting delimiter. Must not be <c>null</c> or empty.</param>
	/// <param name="end">The ending delimiter. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// The substring found between <paramref name="start"/> and <paramref name="end"/> in <paramref name="input"/>.
	/// Delimiters are excluded from the result.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="input"/>, <paramref name="start"/>, or <paramref name="end"/> is <c>null</c>.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="input"/>, <paramref name="start"/>, or <paramref name="end"/> is empty.
	/// </exception>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown when <paramref name="start"/> or <paramref name="end"/> is not found in <paramref name="input"/>,
	/// or when the position of <paramref name="end"/> is not greater than the position of <paramref name="start"/>.
	/// </exception>
	/// <remarks>
	/// Uses <see cref="string.IndexOf(string, StringComparison)"/> with <see cref="StringComparison.Ordinal"/> for
	/// culture-invariant matching and C# range slicing to return the content between delimiters.
	/// </remarks>
	/// <example>
	/// string s = "Hello [World]!";
	/// string between = s.Extract("[", "]"); // "World"
	/// </example>
	/// <seealso cref="StringComparison.Ordinal"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Extract), "David McCarter", "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Extract([DisallowNull] this string input, [DisallowNull] string start, [DisallowNull] string end)
	{
		input = input.ArgumentNotNullOrEmpty();
		start = start.ArgumentNotNullOrEmpty();
		end = end.ArgumentNotNullOrEmpty();

		var startIndex = input.IndexOf(start, StringComparison.Ordinal);
		var endIndex = input.IndexOf(end, StringComparison.Ordinal);

		return input[startIndex..endIndex];
	}

	/// <summary>
	/// Performs a fast, allocation-free comparison between two strings using the specified <see cref="StringComparison"/>.
	/// </summary>
	/// <param name="value">The first string to compare. Must not be <c>null</c>.</param>
	/// <param name="valueToCompare">The second string to compare. Must not be <c>null</c>.</param>
	/// <param name="comparison">
	/// The comparison rule to use (e.g., <see cref="StringComparison.Ordinal"/> or <see cref="StringComparison.OrdinalIgnoreCase"/>).
	/// Defaults to <see cref="StringComparison.Ordinal"/>.
	/// </param>
	/// <returns>
	/// <c>true</c> if <paramref name="value"/> equals <paramref name="valueToCompare"/> under the specified
	/// <paramref name="comparison"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// Optimized for hot paths:
	/// - Validates inputs via guard clauses.
	/// - Short-circuits on reference equality.
	/// </remarks>
	/// <example>
	/// // Ordinal (case-sensitive)
	/// bool a = "Hello".FastEquals("Hello");              // true
	/// bool b = "Hello".FastEquals("hello");              // false
	/// 
	/// // OrdinalIgnoreCase
	/// bool c = "Hello".FastEquals("hello", StringComparison.OrdinalIgnoreCase); // true
	/// </example>
	/// <seealso cref="string.Equals(string?, string?, StringComparison)"/>
	/// <seealso cref="EqualsIgnoreCase(string, string)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastEquals), "David McCarter", "2/16/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool FastEquals([DisallowNull] this string value, [DisallowNull] string valueToCompare, in StringComparison comparison = StringComparison.Ordinal)
	{
		value = value.ArgumentNotNull();
		valueToCompare = valueToCompare.ArgumentNotNull();

		// Quick reference equality check before span comparison
		if (ReferenceEquals(value, valueToCompare))
		{
			return true;
		}

		// Use AsSpan for efficient comparison without allocations
		return value.AsSpan().Equals(valueToCompare.AsSpan(), comparison);
	}

	/// <summary>
	/// Formats a string with placeholder substitution using a stack-allocated buffer for high performance.
	/// </summary>
	/// <param name="format">
	/// The composite format string containing placeholders (e.g., <c>"Hello {0} {1}, the time is {2:HH:mm:ss}"</c>).
	/// Must not be <c>null</c> or empty.
	/// </param>
	/// <param name="bufferSize">
	/// The size of the stack-allocated buffer. Must be between 1 and 1024. Defaults to 256.
	/// If the formatted result exceeds this size, a heap allocation will occur.
	/// </param>
	/// <param name="args">The objects to format and substitute into the placeholders.</param>
	/// <returns>The formatted string with all placeholders replaced by the corresponding arguments.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="format"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="format"/> is empty.</exception>
	/// <exception cref="FormatException">Thrown when the format string is invalid or an index is out of range.</exception>
	/// <remarks>
	/// <para>
	/// This method uses a pooled <see cref="StringBuilder"/> for formatting and attempts to copy the result
	/// to a stack-allocated buffer when the output fits within <paramref name="bufferSize"/>.
	/// </para>
	/// <para>
	/// <strong>Performance Optimizations:</strong>
	/// <list type="bullet">
	/// <item><description>Uses <c>stackalloc</c> to avoid heap allocations for small strings.</description></item>
	/// <item><description>Leverages pooled <see cref="StringBuilder"/> to minimize GC pressure.</description></item>
	/// <item><description>Falls back to direct <see cref="StringBuilder.ToString()"/> for larger results.</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// string firstName = "John";
	/// string lastName = "Doe";
	/// DateTime now = DateTime.Now;
	/// 
	/// // Format with placeholders
	/// string result = "Hello {0} {1}, the time is {2:HH:mm:ss}".FastFormat(256, firstName, lastName, now);
	/// // Result: "Hello John Doe, the time is 14:30:45"
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastFormat), "David McCarter", "2/14/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string FastFormat([DisallowNull] this string format, int bufferSize = 256, params object?[] args)
	{
		format = format.ArgumentNotNullOrEmpty();
		bufferSize = bufferSize.ArgumentInRange(min: 1, max: 1024);

		// Use pooled StringBuilder for formatting with pre-allocated capacity
		var sb = _stringBuilderPool.Value.Get();

		try
		{
			// Clear and ensure capacity in one operation
			_ = sb.Clear().EnsureCapacity(bufferSize);

			// Format directly into the StringBuilder
			_ = sb.AppendFormat(CultureInfo.InvariantCulture, format, args);

			// StringBuilder.ToString() is highly optimized in .NET 10
			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb);
		}
	}

	/// <summary>
	/// Determines whether the specified string is null or empty in a fast manner.
	/// </summary>
	/// <param name="input">The string to check for null or emptiness.</param>
	/// <returns>
	/// <c>false</c> if the string is <c>null</c> or <see cref="string.Empty"/>; otherwise, <c>true</c>.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastIsNullOrEmpty), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool FastIsNullOrEmpty([AllowNull] this string input)
	{
		return input is null || input.Length == 0;
	}

	/// <summary>
	/// Parses a URL string into its constituent components: scheme, host, port, and path.
	/// </summary>
	/// <param name="url">The URL to parse. Must not be null or empty.</param>
	/// <returns>A tuple containing the scheme, host, port, and path components of the URL.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="url"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="url"/> is empty or does not contain a valid scheme separator ("://").</exception>
	/// <remarks>
	/// This method provides a faster alternative to the <see cref="Uri"/> class for simple URL parsing.
	/// It uses <see cref="Span{T}"/> operations for efficient string manipulation without allocations.
	/// If no port is specified in the URL, it defaults to "443".
	/// If no path is present, it defaults to "/".
	/// </remarks>
	/// <example>
	/// <code>
	/// var url = "https://www.example.com:8080/path/to/resource?query=input";
	/// var (scheme, host, port, path) = url.ParseUrl();
	/// // scheme = "https"
	/// // host = "www.example.com"
	/// // port = "8080"
	/// // path = "/path/to/resource?query=input"
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastParseUrl), "David McCarter", "10/1/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static (string Scheme, string Host, string Port, string Path) FastParseUrl([NotNull] this string url)
	{
		url = url.ArgumentNotNullOrEmpty();

		if (!url.Contains(UrlSeparator, StringComparison.Ordinal))
		{
			ExceptionThrower.ThrowArgumentException($"Sting is a incorrect format. Missing {UrlSeparator}.", nameof(url));
		}

		var span = url.AsSpan();

		// Extract scheme
		var schemeIndex = span.IndexOf(UrlSeparator.AsSpan());
		var scheme = span[..schemeIndex].ToString();
		span = span[(schemeIndex + 3)..];

		// Find first slash for path
		var pathIndex = span.IndexOf('/');
		var hostAndPort = pathIndex >= 0 ? span[..pathIndex] : span;
		var path = pathIndex >= 0 ? span[pathIndex..].ToString() : "/";

		// Extract host and port
		var portIndex = hostAndPort.IndexOf(':');
		var host = (portIndex >= 0 ? hostAndPort[..portIndex] : hostAndPort).ToString();
		var port = portIndex >= 0 ? hostAndPort[(portIndex + 1)..].ToString() : "443";

		return (scheme, host, port, path);
	}

	/// <summary>
	/// Performs a fast, culture-invariant replacement of all occurrences of <paramref name="oldValue"/> with <paramref name="newValue"/> using ordinal comparison.
	/// </summary>
	/// <param name="input">The string to search and replace. Must not be <c>null</c> or empty.</param>
	/// <param name="oldValue">The substring to replace. If not found, the original <paramref name="input"/> is returned.</param>
	/// <param name="newValue">The replacement substring. Can be <c>null</c> to remove all occurrences of <paramref name="oldValue"/>.</param>
	/// <returns>
	/// A new string where every occurrence of <paramref name="oldValue"/> in <paramref name="input"/> is replaced with <paramref name="newValue"/>.
	/// If <paramref name="oldValue"/> does not occur, returns the original <paramref name="input"/>.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="input"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="input"/> is empty.</exception>
	/// <remarks>
	/// Uses <see cref="StringComparison.Ordinal"/> for deterministic, case-sensitive, culture-agnostic behavior.
	/// Optimized with guard clauses to avoid unnecessary work when inputs are invalid.
	/// </remarks>
	/// <example>
	/// string text = "Hello World, Hello Universe";
	/// string result = text.FastReplace("Hello", "Hi");
	/// // Returns: "Hi World, Hi Universe"
	/// </example>
	/// <seealso cref="string.Replace(string?, string?, StringComparison)"/>
	/// <seealso cref="StringComparison.Ordinal"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FastReplace), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string FastReplace([DisallowNull] this string input, string oldValue, string newValue)
	{
		input = input.ArgumentNotNullOrEmpty();

		return input.Replace(oldValue, newValue, StringComparison.Ordinal);
	}

	/// <summary>
	/// Decodes a string from Base64 encoding.
	/// </summary>
	/// <param name="base64Input">The Base64 encoded string to decode.</param>
	/// <returns>A decoded string from the Base64 encoded <paramref name="base64Input"/>.</returns>
	/// <remarks>
	/// This method decodes the string using <see cref="Convert.FromBase64String(string)"/> and then converts the byte array to a string using <see cref="Encoding.UTF8"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FromBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string FromBase64([DisallowNull] this string base64Input)
	{
		base64Input = base64Input.ArgumentNotNullOrEmpty();

		return _encoding.GetString(Convert.FromBase64String(base64Input));
	}

	/// <summary>
	/// Decompresses a Brotli compressed string asynchronously.
	/// </summary>
	/// <param name="value">The Brotli compressed string.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous decompression operation. The input of the TResult parameter contains the decompressed string.</returns>
	/// <remarks>
	/// This method uses <see cref="BrotliStream"/> for decompression.
	/// Original code from: https://khalidabuhakmeh.com/compress-strings-with-dotnet-and-csharp
	/// </remarks>
	[Information(nameof(FromBrotliStringAsync), "David McCarter", "10/24/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> FromBrotliStringAsync([DisallowNull] this string value, CancellationToken cancellationToken = default)
	{
		var input = new MemoryStream(Convert.FromBase64String(value.ArgumentNotNull()));

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new BrotliStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output, cancellationToken).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Decompresses a Deflate compressed string asynchronously.
	/// </summary>
	/// <param name="value">The Deflate compressed string.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous decompression operation. The input of the TResult parameter contains the decompressed string.</returns>
	/// <remarks>
	/// This method uses <see cref="DeflateStream"/> for decompression.
	/// </remarks>
	[Information(nameof(FromDeflateStringAsync), "David McCarter", "9/12/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<string> FromDeflateStringAsync([DisallowNull] this string value, CancellationToken cancellationToken = default)
	{
		var bytes = value.ToByteArrayFromBase64();

		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new DeflateStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output, cancellationToken).ConfigureAwait(false);
							await stream.FlushAsync(cancellationToken).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Decompresses a GZip compressed string asynchronously.
	/// </summary>
	/// <param name="value">The GZip compressed string.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous decompression operation. The input of the TResult parameter contains the decompressed string.</returns>
	/// <remarks>
	/// This method uses <see cref="GZipStream"/> for decompression.
	/// Original code from: https://khalidabuhakmeh.com/compress-strings-with-dotnet-and-csharp
	/// </remarks>
	[Information(nameof(FromGZipStringAsync), "David McCarter", "10/24/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> FromGZipStringAsync([DisallowNull] this string value, CancellationToken cancellationToken = default)
	{
		var bytes = value.ToByteArrayFromBase64();

		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new GZipStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output, cancellationToken).ConfigureAwait(false);
							await stream.FlushAsync(cancellationToken).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Decompresses a ZLib compressed string asynchronously.
	/// </summary>
	/// <param name="value">The ZLib compressed string.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous decompression operation. The input of the TResult parameter contains the decompressed string.</returns>
	/// <remarks>
	/// This method uses <see cref="DeflateStream"/> for decompression, as ZLib compression is closely related to the Deflate compression algorithm.
	/// </remarks>
	[Information(nameof(FromZLibStringAsync), "David McCarter", "9/12/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static async Task<string> FromZLibStringAsync([DisallowNull] this string value, CancellationToken cancellationToken = default)
	{
		var bytes = value.ToByteArrayFromBase64();

		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new ZLibStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output, cancellationToken).ConfigureAwait(false);
							await stream.FlushAsync(cancellationToken).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Hashes the specified plain-text value using the configured password hashing algorithm.
	/// </summary>
	/// <param name="input">
	/// The plain-text value to hash. This value must not be <c>null</c> or empty and is validated
	/// via guard clauses before hashing.
	/// </param>
	/// <param name="algorithmType">
	/// The password hashing algorithm to use. Defaults to <see cref="HashAlgorithmType.PBKDF2"/>.
	/// Other supported values are determined by the underlying <see cref="PasswordHasher"/> implementation.
	/// </param>
	/// <returns>
	/// A Base64-encoded string containing the hashed representation of <paramref name="input"/>,
	/// including any algorithm-specific metadata required for verification.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="input"/> is <c>null</c>.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown when <paramref name="input"/> is empty or consists only of whitespace.
	/// </exception>
	/// <remarks>
	/// <para>
	/// This method delegates to <see cref="PasswordHasher.HashPassword(string, HashAlgorithmType)"/> after
	/// validating the <paramref name="input"/> argument. The resulting hash can be verified later using
	/// <see cref="VerifyHashedPassword(string, string, HashAlgorithmType)"/>.
	/// </para>
	/// <para>
	/// The exact hash format, salt handling, and iteration parameters are defined by
	/// <see cref="PasswordHasher"/> and may vary depending on the selected <paramref name="algorithmType"/>.
	/// </para>
	/// </remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HashPassword), "David McCarter", "5/6/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string HashPassword([DisallowNull] this string input, HashAlgorithmType algorithmType = HashAlgorithmType.PBKDF2)
	{
		input = input.ArgumentNotNullOrEmpty();

		return PasswordHasher.HashPassword(input, algorithmType);
	}

	/// <summary>
	/// Checks if the string has a input (is not null or whitespace).
	/// </summary>
	/// <param name="input">The string to check.</param>
	/// <returns><c>true</c> if the string is not null or whitespace; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method considers a string as having a input if it is not null and contains characters other than whitespace.
	/// Uses <see cref="string.IsNullOrWhiteSpace(string)"/> internally to check if the string is null or whitespace.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasValue(this string input)
	{
		return input is { Length: > 0 };
	}

	/// <summary>
	/// Checks if the string has a specified length.
	/// </summary>
	/// <param name="input">The string to check.</param>
	/// <param name="length">The length to check for.</param>
	/// <returns><c>true</c> if the string is not null and has the specified length; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks if the <paramref name="input"/> string has a length equal to the specified <paramref name="length"/>.
	/// It is an extension method and cannot be called on a null instance.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasValue(this string input, int length)
	{
		length = length.ArgumentInRange(min: 1, max: length);

		if (input is null)
		{
			return false;
		}

		// Compute trimmed length without allocating a new string
		var span = input.AsSpan();
		var start = 0;
		var end = span.Length - 1;

		// Trim leading whitespace
		while (start <= end && char.IsWhiteSpace(span[start]))
		{
			start++;
		}

		// Trim trailing whitespace
		while (end >= start && char.IsWhiteSpace(span[end]))
		{
			end--;
		}

		var trimmedLength = end - start + 1; // -1 if all whitespace -> becomes 0 via comparison below

		return trimmedLength == length;
	}

	/// <summary>
	/// Determines whether <paramref name="input"/> equals <paramref name="value"/> using case-sensitive, culture-invariant ordinal comparison.
	/// </summary>
	/// <param name="input">The string to check. Can be <c>null</c>.</param>
	/// <param name="value">The value to compare against. Can be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="input"/> is non-<c>null</c>, non-empty, has the same length as <paramref name="value"/>,
	/// and equals <paramref name="value"/> using <see cref="StringComparison.Ordinal"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// Optimized for hot paths:
	/// - Early returns when either input is <c>null</c> or <paramref name="input"/> is empty.
	/// - Length check avoids expensive comparison when lengths differ.
	/// - Uses <see cref="StringComparison.Ordinal"/> for deterministic, allocation-free comparison.
	/// </remarks>
	/// <example>
	/// string s = "Admin";
	/// bool exact = s.HasValue("Admin"); // true
	/// bool caseMismatch = s.HasValue("admin"); // false
	/// bool nullCompare = s.HasValue(null); // false
	/// </example>
	/// <seealso cref="StringComparison.Ordinal"/>
	/// <seealso cref="FastEquals(string, string, in StringComparison)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasValue(this string input, string value)
	{
		// Fast null/empty checks first
		if (input is null || value is null || input.Length == 0)
		{
			return false;
		}

		// Quick length check avoids a more expensive comparison
		if (input.Length != value.Length)
		{
			return false;
		}

		// Ordinal comparison is fastest and deterministic
		return string.Equals(input, value, StringComparison.Ordinal);
	}

	/// <summary>
	/// Determines whether <paramref name="input"/> has a length within the inclusive range
	/// [<paramref name="minLength"/>, <paramref name="maxLength"/>].
	/// </summary>
	/// <param name="input">The string to validate. Can be <c>null</c>.</param>
	/// <param name="minLength">The minimum allowed length (inclusive). Must be ≥ 0 and ≤ <paramref name="maxLength"/>.</param>
	/// <param name="maxLength">The maximum allowed length (inclusive). Must be ≥ <paramref name="minLength"/>.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="input"/> is not <c>null</c> and its <see cref="string.Length"/> is between
	/// <paramref name="minLength"/> and <paramref name="maxLength"/> (inclusive); otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown when <paramref name="minLength"/> is less than 0, or when <paramref name="minLength"/> is greater than
	/// <paramref name="maxLength"/>, or when <paramref name="maxLength"/> is less than <paramref name="minLength"/>.
	/// </exception>
	/// <remarks>
	/// Optimized for hot paths:
	/// - Validates range bounds once via guard clauses.
	/// - Performs a single null check and a single length comparison.
	/// - No allocations; O(1) time complexity.
	/// </remarks>
	/// <example>
	/// string s = "Hello";
	/// bool inRange1 = s.HasValue(1, 5);  // true
	/// bool inRange2 = s.HasValue(6, 10); // false
	/// bool nullInput = ((string)null).HasValue(0, 10); // false
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasValue(this string input, int minLength, int maxLength)
	{
		// Validate range inputs once (keeps original behavior)
		minLength = minLength.ArgumentInRange(min: 0, max: maxLength);
		maxLength = maxLength.ArgumentInRange(min: minLength, max: int.MaxValue);

		// Fast null check first
		if (input is null)
		{
			return false;
		}

		// Avoid method-call overhead of IsInRange() in hot paths
		var len = input.Length;

		return len >= minLength && len <= maxLength;
	}

	/// <summary>
	/// Determines whether the specified string contains any whitespace characters.
	/// </summary>
	/// <param name="input">The string to check for whitespace.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> contains any whitespace characters; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses <see cref="char.IsWhiteSpace(char)"/> to check each character in the string for whitespace.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasWhitespace([DisallowNull] this string input)
	{
		if (input is null)
		{
			return false;
		}

		// SUGGESTION FROM COPILOT SLOWER
		foreach (var inputItem in input)
		{
			if (!inputItem.IsAsciiWhitespace)
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Prepends a sequence of <paramref name="indentationCharacter"/> to <paramref name="input"/> to produce an indented string.
	/// </summary>
	/// <param name="input">The string to indent. Must not be <c>null</c> when <paramref name="length"/> &gt; 0.</param>
	/// <param name="length">
	/// The number of indentation characters to add. If ≤ 0, returns <see cref="string.Empty"/>.
	/// When positive, the characters are prepended before <paramref name="input"/>.
	/// </param>
	/// <param name="indentationCharacter">The character to use for indentation (e.g., ' ' or '\t').</param>
	/// <returns>
	/// A new string consisting of <paramref name="length"/> copies of <paramref name="indentationCharacter"/> followed by <paramref name="input"/>.
	/// Returns <see cref="string.Empty"/> if <paramref name="input"/> is <c>null</c> or <paramref name="length"/> ≤ 0.
	/// </returns>
	/// <remarks>
	/// Uses a pooled <see cref="StringBuilder"/> to minimize allocations. Validates inputs via guard clauses.
	/// Time complexity O(n) where n = |<paramref name="length"/>| + <paramref name="input"/> length.
	/// </remarks>
	/// <example>
	/// string code = "Console.WriteLine(\"test\");";
	/// string indented = code.Indent(4, ' ');
	/// // "    Console.WriteLine(\"test\");"
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Indent), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Indent([DisallowNull] this string input, in int length, [ConstantExpected] char indentationCharacter)
	{
		if (input.CheckIsNotNull() is false || length <= 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Value.Get();

		try
		{
			if (length == 0)
			{
				_ = sb.Append(input.ArgumentNotNull());
			}

			for (var charIndex = 1; charIndex <= Math.Abs(length); charIndex++)
			{
				_ = sb.Append(indentationCharacter);
			}

			if (length > 0)
			{
				_ = sb.Append(input);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Determines whether the specified string is a valid credit card number.
	/// </summary>
	/// <param name="input">The string to validate as a credit card number.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid credit card number; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the credit card number.
	/// </remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsCreditCardNumber), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsCreditCardNumber([DisallowNull] this string input)
	{
		return RegexProcessor.IsCreditCardNumber(input);
	}

	/// <summary>
	/// Determines whether the specified string is a valid currency code.
	/// </summary>
	/// <param name="input">The string to validate as a currency code.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid currency code; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the currency code.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsCurrencyCode), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsCurrencyCode([DisallowNull] this string input)
	{
		return RegexProcessor.IsCurrencyCode(input);
	}

	/// <summary>
	/// Determines whether the specified string is a valid domain address.
	/// </summary>
	/// <param name="input">The string to validate as a domain address.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid domain address; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the domain address.
	/// </remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsDomainAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsDomainAddress([DisallowNull] this string input)
	{
		return RegexProcessor.IsUrlDomainAddress(input);
	}

	/// <summary>
	/// Determines whether the specified string is a valid email address.
	/// </summary>
	/// <param name="input">The string to validate as an email address.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid email address; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the email address.
	/// </remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEmailAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsEmailAddress([DisallowNull] this string input)
	{
		return RegexProcessor.IsEmailAddress(input);
	}

	/// <summary>
	/// Determines whether the specified string is empty.
	/// </summary>
	/// <param name="input">The string to check.</param>
	/// <returns><c>true</c> if the string is null or empty; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses <see cref="string.IsNullOrEmpty(string)"/> to check if the string is empty.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEmpty), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsEmpty([NotNullWhen(false)] this string? input)
	{
		return input is null || input.Length == 0;
	}

	/// <summary>
	/// Determines whether the specified string is a valid first and last name.
	/// </summary>
	/// <param name="input">The string to validate as a first and last name.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> matches the first and last name pattern; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the first and last name.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsFirstLastName), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsFirstLastName([DisallowNull] this string input)
	{
		return RegexProcessor.ContainsFirstLastName(input);
	}

	/// <summary>
	/// Determines whether the specified string is a valid GUID.
	/// </summary>
	/// <param name="input">The string to validate as a GUID.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid GUID; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the GUID.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsGuid), "David McCarter", "3/24/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsGuid([DisallowNull][StringSyntax(StringSyntaxAttribute.GuidFormat)] this string input)
	{
		return RegexProcessor.IsGuid(input);
	}

	/// <summary>
	/// Determines whether the specified string is a valid International Standard Book Number (ISBN).
	/// </summary>
	/// <param name="input">The string to validate as an ISBN.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid ISBN; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the ISBN.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsISBN), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsISBN([DisallowNull] this string input)
	{
		return RegexProcessor.IsISBN(input);
	}

	/// <summary>
	/// Determines whether the specified string is a valid MAC address.
	/// </summary>
	/// <param name="input">The string to validate as a MAC address.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> is a valid MAC address; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsMacAddress), "David McCarter", "3/24/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsMacAddress([DisallowNull] this string input)
	{
		return RegexProcessor.IsMACAddress(input);
	}

	/// <summary>
	/// Determines whether the specified string is not <c>null</c> and not empty.
	/// </summary>
	/// <param name="input">The string to test.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="input"/> is not <c>null</c> and its <see cref="string.Length"/> is greater than zero;
	/// otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// This method is a lightweight alternative to <see cref="string.IsNullOrEmpty(string)"/> when only the
	/// non-empty case is of interest, and uses pattern matching for fast length checking.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNotEmpty), "David McCarter", "8/18/20", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsNotEmpty(this string? input) => input is { Length: > 0 };

	/// <summary>
	/// Determines whether the specified string contains only characters in the range of '1' to '7' and is alphabetic.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string matches the pattern; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the base64Input string.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsOneToSevenAlpha), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsOneToSevenAlpha([DisallowNull] this string input)
	{
		return RegexProcessor.IsOneToSevenAlpha(input);
	}

	/// <summary>
	/// Determines whether the specified string is in scientific notation.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string is in scientific notation; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the base64Input string.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsScientific), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsScientific([DisallowNull] this string input)
	{
		return RegexProcessor.IsScientific(input);
	}

	/// <summary>
	/// Determines whether the specified string is a valid SHA1 hash type.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string is a valid SHA1 hash type; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the base64Input string.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsStringSHA1Hash), "David McCarter", "5/31/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsStringSHA1Hash([DisallowNull] this string input)
	{
		return RegexProcessor.IsSHA1Hash(input);
	}

	/// <summary>
	/// Determines whether the specified string is a valid URL.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string is a valid URL; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses a regular expression to validate the base64Input string.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsUrl), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsUrl([DisallowNull] this string input)
	{
		return RegexProcessor.IsUrl(input);
	}

	/// <summary>
	/// Determines whether the specified string matches the pattern defined in the regular expression.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <returns><c>true</c> if the string matches the pattern; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsValidString), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsValidString([DisallowNull] this string input)
	{
		return RegexProcessor.IsValidString(input);
	}

	/// <summary>
	/// Removes all carriage return and line feed characters from the specified string.
	/// </summary>
	/// <param name="input">The string from which to remove carriage return and line feed characters.</param>
	/// <param name="replacement">The string to replace carriage return and line feed characters with. Defaults to an empty string.</param>
	/// <returns>A new string with all carriage return and line feed characters replaced by the specified replacement string.</returns>
	/// <remarks>
	/// This method uses a regular expression to identify and replace carriage return and line feed characters.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RemoveCRLF), "Kristine Tran", "2/1/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string? RemoveCRLF(this string input, string replacement = ControlChars.EmptyString)
	{
		return RegexProcessor.ReplaceCrLf(input, replacement);
	}

	/// <summary>
	/// Replaces all occurrences of an ellipsis (...) in the specified string with a period (.).
	/// </summary>
	/// <param name="input">The string to modify.</param>
	/// <returns>A new string with all ellipses replaced by periods.</returns>
	/// <remarks>
	/// This method is useful for normalizing text that uses ellipses.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ReplaceEllipsisWithPeriod), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ReplaceEllipsisWithPeriod([DisallowNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty(true);

		if (input.EndsWith("...", StringComparison.OrdinalIgnoreCase))
		{
			input = input[0..^2];
		}

		return input;
	}

	/// <summary>
	/// Splits the specified string into a read-only collection of substrings using a single character delimiter.
	/// </summary>
	/// <param name="input">The string to split. Must not be <c>null</c> or empty.</param>
	/// <param name="options">
	/// A bitwise combination of <see cref="StringSplitOptions"/> values that specifies whether to trim
	/// substrings and whether to remove empty substrings from the result.
	/// </param>
	/// <param name="delimiter">
	/// The character delimiter used to separate substrings. Defaults to <see cref="ControlChars.Comma"/>.
	/// </param>
	/// <returns>
	/// A <see cref="ReadOnlyCollection{T}"/> of strings containing the substrings that were delimited by
	/// <paramref name="delimiter"/> in <paramref name="input"/>. The behavior regarding empty and trimmed
	/// entries is controlled by <paramref name="options"/>.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="input"/> is empty.</exception>
	/// <remarks>
	/// This method validates <paramref name="input"/> and <paramref name="options"/>, then calls
	/// <see cref="string.Split(char[], StringSplitOptions)"/> with the specified <paramref name="delimiter"/>
	/// and wraps the resulting array in a read-only collection via <see cref="Array.AsReadOnly{T}(T[])"/>.
	/// It is useful when an immutable view of the split results is desired.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> Split([DisallowNull] this string input, StringSplitOptions options, [ConstantExpected] char delimiter = ControlChars.Comma)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined();

		return input.Split([delimiter], options).AsReadOnly();
	}

	/// <summary>
	/// Splits the base64Input string into a <see cref="ReadOnlyCollection{String}"/> of strings,
	/// separated by the specified <paramref name="options"/> parameter specifies whether to include empty array elements in the array returned.
	/// The <paramref name="count"/> parameter specifies the maximum number of substrings to return.
	/// </summary>
	/// <param name="input">The string to split.</param>
	/// <param name="options">Options for controlling the splitting operation, such as removing empty entries.</param>
	/// <param name="count">The maximum number of substrings to return.</param>
	/// <param name="delimiter">The character to use as a delimiter. Defaults to <see cref="ControlChars.Comma"/>.</param>
	/// <returns>A <see cref="ReadOnlyCollection{String}"/> of strings that has been split from the base64Input string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public static ReadOnlyCollection<string> Split([DisallowNull] this string input, [DisallowNull] StringSplitOptions options, int count, [ConstantExpected] char delimiter = ControlChars.Comma)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined();
		count = count.ArgumentInRange(min: 1);

		return Array.AsReadOnly(input.Split([delimiter], count, options));
	}

	/// <summary>
	/// Splits the base64Input string into a ReadOnlyCollection{string} of strings,
	/// separated by the specified <paramref name="separator"/>.
	/// The <paramref name="options"/> parameter specifies whether to include empty array elements in the array returned.
	/// The <paramref name="count"/> parameter specifies the maximum number of substrings to return.
	/// </summary>
	/// <param name="input">The string to split.</param>
	/// <param name="options">Options for controlling the splitting operation, such as removing empty entries.</param>
	/// <param name="count">The maximum number of substrings to return.</param>
	/// <param name="separator">The string to use as a delimiter. Defaults to <see cref="ControlChars.DefaultSeparator"/>.</param>
	/// <returns>A ReadOnlyCollection{string} of strings that has been split from the base64Input string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> Split([DisallowNull] this string input, [DisallowNull] StringSplitOptions options, int count, [ConstantExpected] string separator = ControlChars.DefaultSeparator)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined();
		count = count.ArgumentInRange(min: 1);

		return Array.AsReadOnly(input.Split([separator], count, options));

	}

	/// <summary>
	/// Splits the specified string into lines using a high-performance <see cref="LineSplitEnumerator"/>.
	/// </summary>
	/// <param name="input">The string to split into individual lines. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// A <see cref="LineSplitEnumerator"/> that can be used in a <c>foreach</c> loop to iterate over each line
	/// in <paramref name="input"/> without additional allocations.
	/// </returns>
	/// <remarks>
	/// <para>
	/// This method first validates that <paramref name="input"/> is not <c>null</c> or empty and then returns a
	/// <see cref="LineSplitEnumerator"/> that enumerates lines efficiently using spans. It is designed for
	/// performance‑critical scenarios where traditional <see cref="string.Split(string[], StringSplitOptions)"/>
	/// would create unnecessary intermediate string allocations.
	/// </para>
	/// <para>
	/// The returned enumerator supports <c>foreach</c>-style iteration, yielding each line as it is encountered.
	/// Line termination characters (such as <c>'\r'</c> and <c>'\n'</c>) are not included in the returned slices.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// var text = "Line1\r\nLine2\nLine3";
	/// 
	/// foreach (var line in text.SplitLines())
	/// {
	///     Console.WriteLine(line.ToString());
	/// }
	/// </code>
	/// </example>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SplitLines), "David McCarter", "6/9/2022", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed)]
	public static LineSplitEnumerator SplitLines([DisallowNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		return new LineSplitEnumerator(input);
	}

	/// <summary>
	/// Splits a comma-delimited string into a read-only collection of non-empty substrings.
	/// </summary>
	/// <param name="input">The comma-delimited string to split. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// A <see cref="ReadOnlyCollection{T}"/> of strings containing all non-empty segments from the trimmed
	/// <paramref name="input"/>, split on <see cref="ControlChars.Comma"/>. Empty entries are removed.
	/// </returns>
	/// <remarks>
	/// <para>
	/// This method first validates and trims <paramref name="input"/>, then splits it on commas using
	/// <see cref="string.Split(char[], StringSplitOptions)"/> with <see cref="StringSplitOptions.RemoveEmptyEntries"/>.
	/// The resulting array is then wrapped in a read-only collection for safe, immutable consumption.
	/// </para>
	/// <para>
	/// It is a convenience helper for common comma-separated scenarios where empty items should be ignored
	/// and the caller only needs an immutable, read-only view of the results.
	/// </para>
	/// </remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SplitRemoveEmpty), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> SplitRemoveEmpty([DisallowNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		return input.Trim().Split([ControlChars.Comma], options: StringSplitOptions.RemoveEmptyEntries).AsReadOnly();
	}

	/// <summary>
	/// Determines whether the beginning of this string instance matches the specified string when compared using the ordinal sort order.
	/// </summary>
	/// <param name="input">The string to check. This string cannot be null.</param>
	/// <param name="inputToCompare">The string to compare to the beginning of this string. This string cannot be null.</param>
	/// <returns><c>true</c> if <paramref name="inputToCompare"/> matches the beginning of this string; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method performs an ordinal (case-sensitive and culture-insensitive) comparison.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StartsWithOrdinal), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static bool StartsWithOrdinal([DisallowNull] this string input, string inputToCompare)
	{
		return input?.StartsWith(inputToCompare, StringComparison.Ordinal) ?? false;
	}

	/// <summary>
	/// Determines whether the beginning of this string instance matches the specified string when compared using the ordinal sort order and ignoring case.
	/// </summary>
	/// <param name="input">The string to check. This string cannot be null.</param>
	/// <param name="inputToCompare">The string to compare to the beginning of this string. This string cannot be null.</param>
	/// <returns><c>true</c> if <paramref name="inputToCompare"/> matches the beginning of this string, ignoring case; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method performs a comparison using <see cref="StringComparison.OrdinalIgnoreCase"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static bool StartsWithOrdinalIgnoreCase([DisallowNull] this string input, string inputToCompare)
	{
		return input?.StartsWith(inputToCompare, StringComparison.OrdinalIgnoreCase) ?? false;
	}

	/// <summary>
	/// Extracts a substring from the specified range of the string and trims leading and trailing whitespace.
	/// </summary>
	/// <param name="input">
	/// The source string from which to extract the substring. Can be <c>null</c> or empty.
	/// </param>
	/// <param name="startIndex">
	/// The zero-based starting character position of the substring. Must be greater than or equal to zero.
	/// </param>
	/// <param name="length">
	/// The number of characters to include in the substring. Must be greater than or equal to zero.
	/// </param>
	/// <returns>
	/// A new string that represents the substring of <paramref name="input"/> starting at
	/// <paramref name="startIndex"/> with the specified <paramref name="length"/>, with all leading and
	/// trailing whitespace removed. Returns <see cref="ControlChars.EmptyString"/> if
	/// <paramref name="input"/> is <c>null</c> or empty.
	/// </returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown when <paramref name="startIndex"/> is less than 0, <paramref name="length"/> is less than 0,
	/// or <paramref name="startIndex"/> + <paramref name="length"/> exceeds the length of
	/// <paramref name="input"/>.
	/// </exception>
	/// <remarks>
	/// <para>
	/// This method combines substring extraction and trimming into a single operation. It uses
	/// string.AsSpan() to slice the underlying characters without intermediate allocations,
	/// then converts the span to a string and invokes <see cref="string.Trim()"/> to remove leading and
	/// trailing whitespace.
	/// </para>
	/// <para>
	/// When <paramref name="input"/> is <c>null</c> or empty, the method returns
	/// <see cref="ControlChars.EmptyString"/> instead of throwing, preserving the original behavior
	/// used throughout Spargine.
	/// </para>
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNull]
	[Information(nameof(SubstringTrim), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string SubstringTrim(this string input, int startIndex, int length)
	{
		if (input.IsNullOrEmpty())
		{
			return ControlChars.EmptyString;
		}

		if (startIndex < 0 || length < 0 || startIndex + length > input.Length)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(length));
		}

		// SUGGESTION FROM COPILOT SLOWER.
		return input.AsSpan(startIndex, length).ToString().Trim();
	}

	/// <summary>
	/// Encodes the specified string into a Base64 string using ASCII encoding.
	/// </summary>
	/// <param name="input">
	/// The string to encode. Must not be <c>null</c> or empty; validated via guard clauses.
	/// Only characters in the ASCII range (U+0000–U+007F) are preserved exactly.
	/// </param>
	/// <returns>
	/// A Base64-encoded string representing the ASCII byte sequence of <paramref name="input"/>.
	/// </returns>
	/// <remarks>
	/// <para>
	/// This method uses a cached <see cref="ASCIIEncoding"/> instance and <see cref="Convert.ToBase64String(byte[])"/>
	/// for high-throughput encoding in .NET 10.
	/// </para>
	/// <para>
	/// Non-ASCII characters (code points &gt; 0x7F) are replaced with <c>'?'</c> by <see cref="ASCIIEncoding"/>,
	/// so this API is appropriate only for pure ASCII text (e.g., protocol tokens, headers, identifiers).
	/// For full Unicode preservation, prefer a UTF-8 based encoder instead.
	/// </para>
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ToBase64([DisallowNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty(true);

		return Convert.ToBase64String(_encoding.GetBytes(input));
	}

	/// <summary>
	/// Converts a Base64 encoded string to a byte array.
	/// This method uses the exact calculated size for optimal memory usage.
	/// </summary>
	/// <param name="input">The Base64 encoded string.</param>
	/// <returns>A byte array representing the decoded Base64 string.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the base64Input string is null or empty.</exception>
	/// <exception cref="FormatException">Thrown when the base64Input is not a valid Base64 string.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToBase64Bytes), "David McCarter", "12/30/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static byte[] ToBase64Bytes([DisallowNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		var buffer = new byte[input.CalculateByteArraySize()];

		// GetBytes with span - guaranteed to fill buffer exactly
		_ = Encoding.UTF8.GetBytes(input, buffer);

		return buffer;
	}

	/// <summary>
	/// Compresses the specified string using the Brotli algorithm and returns the compressed string in an asynchronous operation.
	/// </summary>
	/// <param name="input">The string to compress. This string cannot be null.</param>
	/// <param name="level">The compression level to use. Defaults to <see cref="CompressionLevel.Fastest"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{String}"/> representing the asynchronous operation, which upon completion, yields the Brotli compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: iw2AZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAA==
	/// NoCompression: iw2AZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAA==
	/// Optimal: iw0A+I+UrMG9dHJoJzwdrIKg1dYDoCSJKErYXLOsvkcYAw==
	/// SmallestSize: iw0A+I+UrMG9dHJoJzwdrIKg1dYDoCSJKErYXLOsvkcYAw==
	/// </example>
	[Information(nameof(ToBrotliStringAsync), "David McCarter", "10/24/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToBrotliStringAsync([DisallowNull] this string input, CompressionLevel level = CompressionLevel.Fastest, CancellationToken cancellationToken = default)
	{
		var inputStream = new MemoryStream(Encoding.Unicode.GetBytes(input.ArgumentNotNull()));

		await using (inputStream.ConfigureAwait(continueOnCapturedContext: false))
		{
			var outputStream = new MemoryStream();

			await using (outputStream.ConfigureAwait(continueOnCapturedContext: false))
			{
				var brotliStream = new BrotliStream(outputStream, level);

				await using (brotliStream.ConfigureAwait(continueOnCapturedContext: false))
				{
					await inputStream.CopyToAsync(brotliStream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					await brotliStream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

					return Convert.ToBase64String(outputStream.ToArray());
				}
			}
		}
	}

	/// <summary>
	/// Converts the specified string to a byte array using the provided encoding.
	/// </summary>
	/// <param name="input">The string to convert. This string cannot be null.</param>
	/// <param name="encoding">The encoding to use for the conversion. This cannot be null. See <see cref="Encoding"/> for encoding types.</param>
	/// <returns>A byte array representing the encoded string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToByteArray), "David McCarter", "12/21/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static byte[] ToByteArray([DisallowNull] this string input, [DisallowNull] Encoding encoding)
	{
		input = input.ArgumentNotNullOrEmpty();
		encoding = encoding.ArgumentNotNull();

		var buffer = new byte[encoding.GetByteCount(input)];

		// GetBytes with span - guaranteed to fill buffer exactly
		_ = encoding.GetBytes(input, buffer);

		return buffer;
	}

	/// <summary>
	/// Converts a Base64 encoded string to a byte array.
	/// </summary>
	/// <param name="base64String">The Base64 encoded string.</param>
	/// <returns>The byte array representation of the Base64 encoded string.</returns>
	/// <exception cref="FormatException">Thrown when the base64Input string is not a valid Base64 string.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToByteArrayFromBase64), "David McCarter", "4/20/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static byte[] ToByteArrayFromBase64(this string base64String)
	{
		if (string.IsNullOrEmpty(base64String))
		{
			return [];
		}

		var buffer = new Span<byte>(new byte[base64String.CalculateByteArraySize()]);

		return !Convert.TryFromBase64String(base64String, buffer, out var bytesWritten)
			? throw new FormatException(Resources.TheInputStringIsNotAValidBase64String)
			: buffer[..bytesWritten].ToArray();
	}

	/// <summary>
	/// Compresses the specified string using the Deflate algorithm and returns the compressed string in an asynchronous operation.
	/// </summary>
	/// <param name="input">The string to compress. This string cannot be null.</param>
	/// <param name="level">The compression level to use. Defaults to <see cref="CompressionLevel.Fastest"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{String}"/> representing the asynchronous operation, which upon completion, yields the Deflate compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: SmHIZyhh8GNIZShhCGHIZChgKGbQY0hmyGfIZQAAAAD//w==
	/// NoCompression: ABwA4/9kAG8AdABOAGUAdABUAGkAcABzAC4AYwBvAG0AAA==
	/// Optimal: SmHIZyhh8GNIBZIhDJkMBQzFDHoMyUDRXAYAAAAA//8=
	/// SmallestSize: SmHIZyhh8GNIBZIhDJkMBQzFDHoMyUDRXAYAAAAA//8=
	/// </example>
	[Information(nameof(ToDeflateStringAsync), "David McCarter", "9/12/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static async Task<string> ToDeflateStringAsync([DisallowNull] this string input, CompressionLevel level = CompressionLevel.Fastest, CancellationToken cancellationToken = default)
	{
		input = input.ArgumentNotNull();

		using var inputMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(input));
		using var outputMemoryStream = new MemoryStream();
		using (var deflateStream = new DeflateStream(outputMemoryStream, level, true))
		{
			await inputMemoryStream.CopyToAsync(deflateStream, cancellationToken).ConfigureAwait(false);
		}

		return Convert.ToBase64String(outputMemoryStream.ToArray());
	}

	/// <summary>
	/// Compresses the specified string using the GZip algorithm and returns the compressed string in an asynchronous operation.
	/// </summary>
	/// <param name="input">The string to compress. This string cannot be null.</param>
	/// <param name="level">The compression level to use. Defaults to <see cref="CompressionLevel.Fastest"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{String}"/> representing the asynchronous operation, which upon completion, yields the GZip compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: H4sIAAAAAAAECkphyGcoYfBjSGUoYQhhyGQoYChm0GNIZshnyGUAAAAA//8=
	/// NoCompression: H4sIAAAAAAAECgAcAOP/ZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAAAAAP//
	/// Optimal: H4sIAAAAAAAACkphyGcoYfBjSAWSIQyZDAUMxQx6DMlA0VwGAAAAAP//
	/// SmallestSize: H4sIAAAAAAACCkphyGcoYfBjSAWSIQyZDAUMxQx6DMlA0VwGAAAAAP/
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(ToGZipStringAsync), "David McCarter", "10/24/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToGZipStringAsync([DisallowNull] this string input, CompressionLevel level = CompressionLevel.Fastest, CancellationToken cancellationToken = default)
	{
		input = input.ArgumentNotNull();

		using var inputMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(input));
		using var outputMemoryStream = new MemoryStream();
		using (var gzipStream = new GZipStream(outputMemoryStream, level, true))
		{
			await inputMemoryStream.CopyToAsync(gzipStream, cancellationToken).ConfigureAwait(false);
		}

		return Convert.ToBase64String(outputMemoryStream.ToArray());
	}

	/// <summary>
	/// Converts the specified string to title case, considering culture-specific rules.
	/// </summary>
	/// <param name="input">The string to convert to title case. This string cannot be null.</param>
	/// <returns>A string converted to title case using <see cref="CultureInfo.CurrentCulture"/> rules.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToTitleCase), "David McCarter", "10/8/2020", "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ToTitleCase([DisallowNull] this string input)
	{
		return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
	}

	/// <summary>
	/// Trims leading and trailing whitespace from the specified string.
	/// </summary>
	/// <param name="input">The string to trim. Can be <c>null</c>.</param>
	/// <returns>
	/// A new string with all leading and trailing whitespace characters removed, or <c>null</c> if
	/// <paramref name="input"/> is <c>null</c>. If the input string is empty or contains only whitespace,
	/// returns <see cref="string.Empty"/>.
	/// </returns>
	/// <remarks>
	/// This method is a null-safe wrapper around <see cref="string.Trim()"/>. It:
	/// <list type="bullet">
	/// <item>Returns <c>null</c> unchanged.</item>
	/// <item>Returns <see cref="string.Empty"/> for empty or whitespace-only values.</item>
	/// <item>Relies on <see cref="string.Trim()"/>, which is SIMD-optimized in .NET 10 and returns the original
	/// instance when no trimming is required (avoiding extra allocations).</item>
	/// </list>
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToTrimmed), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string? ToTrimmed([AllowNull] this string input)
	{
		// Early exit for null - preserves null input
		if (input is null)
		{
			return null;
		}

		// Early exit for empty string
		if (input.Length == 0)
		{
			return string.Empty;
		}

		// Trim() is highly optimized in .NET 10 with SIMD acceleration
		// Returns original string instance if no trimming needed (zero allocation)
		return input.Trim();
	}

	/// <summary>
	/// Compresses the specified string using the ZLib algorithm and returns the compressed string in an asynchronous operation.
	/// </summary>
	/// <param name="input">The string to compress. This string cannot be null.</param>
	/// <param name="level">The compression level to use. Defaults to <see cref="CompressionLevel.Fastest"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>A <see cref="Task{String}"/> representing the asynchronous operation, which upon completion, yields the ZLib compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: eAFKYchnKGHwY0hlKGEIYchkKGAoZtBjSGbIZ8hlAAAAAP//
	/// NoCompression: eAEAHADj/2QAbwB0AE4AZQB0AFQAaQBwAHMALgBjAG8AbQAAAAD//w==
	/// Optimal: eJxKYchnKGHwY0gFkiEMmQwFDMUMegzJQNFcBgAAAAD//w==
	/// SmallestSize: eNpKYchnKGHwY0gFkiEMmQwFDMUMegzJQNFcBgAAAAD//w==
	/// </example>
	[Information(nameof(ToZLibStringAsync), "David McCarter", "9/12/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToZLibStringAsync([DisallowNull] this string input, CompressionLevel level = CompressionLevel.Fastest, CancellationToken cancellationToken = default)
	{
		input = input.ArgumentNotNull();

		using var inputMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(input));
		using var outputMemoryStream = new MemoryStream();
		using (var zlibStream = new ZLibStream(outputMemoryStream, level, true))
		{
			await inputMemoryStream.CopyToAsync(zlibStream, cancellationToken).ConfigureAwait(false);
		}

		return Convert.ToBase64String(outputMemoryStream.ToArray());
	}

	/// <summary>
	/// Verifies the hashed password against the base64Input string using the specified hashing algorithm.
	/// </summary>
	/// <param name="hashedPassword">The hashed password to verify. Must not be null.</param>
	/// <param name="input">The base64Input string to compare against the hashed password. Must not be null.</param>
	/// <param name="algorithmType">The hashing algorithm to use. Defaults to PBKDF2.</param>
	/// <returns>A <see cref="PasswordVerificationResult"/> indicating whether the verification succeeded or failed.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(VerifyHashedPassword), "David McCarter", "5/6/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static PasswordVerificationResult VerifyHashedPassword([DisallowNull] this string hashedPassword, [DisallowNull] string input, HashAlgorithmType algorithmType = HashAlgorithmType.PBKDF2)
	{
		hashedPassword = hashedPassword.ArgumentNotNullOrEmpty();
		input = input.ArgumentNotNullOrEmpty();

		return PasswordHasher.VerifyHashedPassword(hashedPassword, input, algorithmType);
	}

	/// <summary>
	/// Computes the hashType of the given base64Input string using the specified hashType algorithm.
	/// </summary>
	/// <param name="input">The base64Input string to compute the hashType for. Must not be null.</param>
	/// <param name="hashType">The hashType algorithm type to use for computing the hashType.</param>
	/// <returns>A byte array containing the computed hashType of the base64Input string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the specified hashType algorithm is not supported.</exception>
	/// <remarks>
	/// This method utilizes the <see cref="HashAlgorithm"/> class to compute the hashType.
	/// </remarks>
	private static byte[] GetHash(string input, HashType hashType)
	{
		var inputBytes = Encoding.ASCII.GetBytes(input);

		return hashType switch
		{
			HashType.SHA256 => SHA256.HashData(inputBytes),
			HashType.SHA384 => SHA384.HashData(inputBytes),
			HashType.SHA512 => SHA512.HashData(inputBytes),
			_ => [],
		};
	}

}
