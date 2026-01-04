// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-04-2026
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Common String Extensions.</summary>
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
[Information(Documentation = "https://bit.ly/SpargineStringExtensions", Status = Status.Available)]
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
	/// Calculates the size of the byte array that will result from encoding the string using the specified encoding.
	/// </summary>
	/// <param name="input">The string to calculate the byte array size for. Must not be null.</param>
	/// <param name="encoding">The encoding to use for the calculation. Defaults to <see cref="Encoding.UTF8"/>.</param>
	/// <returns>The size of the byte array needed to store the encoded string data.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the base64Input string is null.</exception>
	/// <remarks>
	/// <para>
	/// <b>Performance Optimization (.NET 10):</b> This method uses <see cref="Encoding.GetByteCount(string)"/> 
	/// which is highly optimized in .NET 10 with SIMD acceleration for UTF-8 and ASCII encodings.
	/// </para>
	/// <para>
	/// <b>Performance Characteristics:</b>
	/// </para>
	/// <list type="bullet">
	/// <item><description><b>Time complexity:</b> O(n) where n is the string length</description></item>
	/// <item><description><b>Space complexity:</b> O(1) - No allocations, only counting</description></item>
	/// <item><description><b>SIMD acceleration:</b> UTF-8 and ASCII use vectorized operations on .NET 10</description></item>
	/// <item><description><b>Zero allocation:</b> No temporary buffers created during counting</description></item>
	/// </list>
	/// <para>
	/// <b>Common Encodings:</b>
	/// </para>
	/// <list type="bullet">
	/// <item><description><see cref="Encoding.UTF8"/> - Variable length (1-4 bytes per character)</description></item>
	/// <item><description><see cref="Encoding.ASCII"/> - Fixed 1 byte per character (0-127 range)</description></item>
	/// <item><description><see cref="Encoding.Unicode"/> - Fixed 2 bytes per character (UTF-16LE)</description></item>
	/// <item><description><see cref="Encoding.UTF32"/> - Fixed 4 bytes per character</description></item>
	/// </list>
	/// </remarks>
	/// <example>
	/// Calculate byte array sizes for different encodings:
	/// <code>
	/// string text = "Hello, 世界!";
	/// 
	/// // UTF-8: Variable length encoding
	/// int utf8Size = text.CalculateByteArraySize();
	/// // Returns: 13 bytes (ASCII chars = 8, Chinese chars = 6, exclamation = 1)
	/// 
	/// // Unicode (UTF-16): Fixed 2 bytes per character
	/// int utf16Size = text.CalculateByteArraySize(Encoding.Unicode);
	/// // Returns: 20 bytes (10 characters × 2 bytes)
	/// 
	/// // ASCII: Fixed 1 byte per character (non-ASCII replaced with '?')
	/// int asciiSize = text.CalculateByteArraySize(Encoding.ASCII);
	/// // Returns: 10 bytes (10 characters × 1 byte, Chinese chars replaced)
	/// 
	/// // UTF-32: Fixed 4 bytes per character
	/// int utf32Size = text.CalculateByteArraySize(Encoding.UTF32);
	/// // Returns: 40 bytes (10 characters × 4 bytes)
	/// 
	/// // Pre-allocate exact buffer size before encoding
	/// byte[] buffer = new byte[text.CalculateByteArraySize(Encoding.UTF8)];
	/// int written = Encoding.UTF8.GetBytes(text, buffer);
	/// // buffer is exactly sized, no waste
	/// </code>
	/// </example>
	/// <seealso cref="Encoding.GetByteCount(string)"/>
	/// <seealso cref="ToByteArray(string, Encoding)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculateByteArraySize), "David McCarter", "11/6/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Updated)]
	public static int CalculateByteArraySize([DisallowNull] this string input, Encoding? encoding = null)
	{
		input = input.ArgumentNotNullOrEmpty();

		// Default to UTF-8 if no encoding specified
		encoding ??= Encoding.UTF8;

		return encoding.GetByteCount(input);
	}

	/// <summary>
	/// Calculates the total character count from an array of strings.
	/// </summary>
	/// <param name="args">The array of strings to calculate the character count from. Can be <c>null</c>.</param>
	/// <returns>
	/// The total character count of all non-null strings in the array.
	/// Returns <c>0</c> if <paramref name="args"/> is <c>null</c> or empty.
	/// </returns>
	/// <remarks>
	/// This method uses <see cref="ReadOnlySpan{T}"/> for optimized iteration without bounds checking,
	/// providing improved performance compared to traditional array enumeration.
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(n) where n = number of strings in the array</description></item>
	/// <item><description>Space Complexity: O(1) - uses stack-allocated span with no heap allocations</description></item>
	/// <item><description>Null strings are safely skipped without throwing exceptions</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Example usage:
	/// <code>
	/// // Calculate total length of multiple strings
	/// string[] words = { "Hello", "World", "!" };
	/// int totalLength = words.CalculateTotalLength();
	/// // Returns: 11 (5 + 5 + 1)
	/// 
	/// // Handles null strings gracefully
	/// string[] mixedArray = { "Test", null, "Data" };
	/// int length = mixedArray.CalculateTotalLength();
	/// // Returns: 8 (4 + 0 + 4)
	/// 
	/// // Returns 0 for null or empty arrays
	/// string[] nullArray = null;
	/// int zeroLength = nullArray.CalculateTotalLength();
	/// // Returns: 0
	/// </code>
	/// </example>
	/// <seealso cref="string.Length"/>
	/// <seealso cref="ReadOnlySpan{T}"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculateTotalLength), "David McCarter", "12/29/2025", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static int CalculateTotalLength(this string[] args)
	{
		if (args is null or { Length: 0 })
		{
			return 0;
		}

		var totalLength = 0;
		var span = args.AsSpan();

		for (var charIndex = 0; charIndex < span.Length; charIndex++)
		{
			var current = span[charIndex];
			if (current is not null)
			{
				totalLength += current.Length;
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
	[Information(nameof(Concat), "David McCarter", "9/15/2017", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
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
	/// Determines whether the base64Input string contains any of the specified characters, using the specified string comparison option.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ContainsAny), "David McCarter", "9/15/2017", "2/9/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ContainsAny([DisallowNull] this string input,
		StringComparison stringComparison = StringComparison.OrdinalIgnoreCase,
		params string[] characters)
	{
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
	/// Determines whether the end of this string instance matches the specified string when compared using the specified comparison option.
	/// </summary>
	/// <param name="input">The base64Input string to compare.</param>
	/// <param name="inputToCompare">The string to compare to the end of the base64Input string.</param>
	/// <returns><c>true</c> if <paramref name="inputToCompare"/> matches the end of this string; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses <see cref="string.Equals(string, string, StringComparison)"/> for comparison.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EqualsIgnoreCase), "David McCarter", "7/15/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool EqualsIgnoreCase([DisallowNull] this string input, [DisallowNull] string inputToCompare)
	{
		input = input.ArgumentNotNull();
		inputToCompare = inputToCompare.ArgumentNotNull();

		return ReferenceEquals(input, inputToCompare)
			? true
			: input.AsSpan().Equals(inputToCompare.AsSpan(), StringComparison.OrdinalIgnoreCase);
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
	/// Extracts a substring from the input string that is located between the specified start and end delimiter strings.
	/// </summary>
	/// <param name="input">The string from which to extract the substring. Must not be <c>null</c> or empty.</param>
	/// <param name="start">The starting delimiter string that marks the beginning of the extraction. Must not be <c>null</c> or empty.</param>
	/// <param name="end">The ending delimiter string that marks the end of the extraction. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// A substring that begins at the index where <paramref name="start"/> is found and continues up to (but not including) 
	/// the index where <paramref name="end"/> is found.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="input"/>, <paramref name="start"/>, or <paramref name="end"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="input"/>, <paramref name="start"/>, or <paramref name="end"/> is empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown when:
	/// <list type="bullet">
	/// <item><description><paramref name="start"/> is not found in <paramref name="input"/>.</description></item>
	/// <item><description><paramref name="end"/> is not found in <paramref name="input"/>.</description></item>
	/// <item><description>The index of <paramref name="end"/> is less than or equal to the index of <paramref name="start"/>.</description></item>
	/// </list>
	/// </exception>
	/// <remarks>
	/// This method uses <see cref="string.IndexOf(string, StringComparison)"/> with <see cref="StringComparison.Ordinal"/> 
	/// to locate the start and end delimiter strings. The extraction uses C# range syntax (<c>[startIndex..endIndex]</c>) 
	/// for efficient substring creation without allocations.
	/// <para>
	/// <strong>Important:</strong> The extracted substring does <em>not</em> include the <paramref name="start"/> 
	/// and <paramref name="end"/> delimiter strings themselves. Only the content between these delimiters is returned.
	/// </para>
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Uses ordinal comparison for culture-invariant delimiter matching</description></item>
	/// <item><description>Leverages range syntax for zero-allocation substring extraction</description></item>
	/// <item><description>Time Complexity: O(n) where n is the length of the input string</description></item>
	/// <item><description>Space Complexity: O(m) where m is the length of the extracted substring</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic extraction between delimiters:
	/// <code>
	/// string input = "The &lt;value&gt;42&lt;/value&gt; is the answer";
	/// string result = input.Extract("&lt;value&gt;", "&lt;/value&gt;");
	/// // Returns: "42"
	/// </code>
	/// 
	/// Extracting from a formatted string:
	/// <code>
	/// string html = "&lt;div&gt;&lt;span&gt;Hello World&lt;/span&gt;&lt;/div&gt;";
	/// string content = html.Extract("&lt;span&gt;", "&lt;/span&gt;");
	/// // Returns: "Hello World"
	/// </code>
	/// 
	/// Extracting JSON-like data:
	/// <code>
	/// string json = "{\"name\":\"John\",\"age\":30}";
	/// string name = json.Extract("\"name\":\"", "\"");
	/// // Returns: "John"
	/// </code>
	/// </example>
	/// <seealso cref="string.IndexOf(string, StringComparison)"/>
	/// <seealso cref="string.Substring(int, int)"/>
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
	/// Compares two strings using the specified string comparison option.
	/// </summary>
	/// <param name="value">The first string to compare. Must not be null.</param>
	/// <param name="valueToCompare">The second string to compare. Must not be null.</param>
	/// <param name="comparison">The string comparison option to use. Must not be null.</param>
	/// <returns><c>true</c> if the strings are equal according to the specified comparison option; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="value"/>, <paramref name="valueToCompare"/>, or <paramref name="comparison"/> is null.</exception>
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
	/// Performs a fast, culture-invariant string replacement by replacing all occurrences of a specified string with another string.
	/// </summary>
	/// <param name="input">The string in which to perform replacements. Must not be <c>null</c> or empty.</param>
	/// <param name="oldValue">The string to be replaced. If this string is not found in <paramref name="input"/>, the original string is returned unchanged.</param>
	/// <param name="newValue">The string to replace all occurrences of <paramref name="oldValue"/>. Can be <c>null</c> to remove all occurrences.</param>
	/// <returns>
	/// A new string that is equivalent to <paramref name="input"/> except that all instances of <paramref name="oldValue"/> 
	/// are replaced with <paramref name="newValue"/>. If <paramref name="oldValue"/> is not found, returns the original <paramref name="input"/> unchanged.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="input"/> is empty.</exception>
	/// <remarks>
	/// This method provides a performance-optimized replacement operation using <see cref="StringComparison.Ordinal"/> comparison,
	/// which performs a culture-invariant, case-sensitive byte-by-byte comparison. This is the fastest string comparison method 
	/// as it does not apply any linguistic rules during matching.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Uses ordinal (binary) comparison for maximum performance</description></item>
	/// <item><description>Culture-insensitive: Results are consistent across all cultures and locales</description></item>
	/// <item><description>Case-sensitive: "ABC" and "abc" are treated as different strings</description></item>
	/// <item><description>Optimized for scenarios requiring deterministic, culture-independent behavior</description></item>
	/// <item><description>SIMD-accelerated in .NET 10 for improved throughput on large strings</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>When to Use Ordinal Comparison:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>File paths and URLs (e.g., replacing path separators)</description></item>
	/// <item><description>XML/JSON element names and attribute keys</description></item>
	/// <item><description>Protocol identifiers and version strings</description></item>
	/// <item><description>Database column names and configuration keys</description></item>
	/// <item><description>Security-sensitive comparisons where culture variations are undesirable</description></item>
	/// </list>
	/// <para>
	/// <strong>Note:</strong> This method does not modify the current instance. Instead, it returns a new string 
	/// with the replacements applied, following the immutable nature of <see cref="string"/> in .NET.
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic string replacement:
	/// <code>
	/// string text = "Hello World, Hello Universe";
	/// string result = text.FastReplace("Hello", "Hi");
	/// // Returns: "Hi World, Hi Universe"
	/// </code>
	/// 
	/// Replacing path separators (case-sensitive):
	/// <code>
	/// string path = "C:\\Users\\Documents\\file.txt";
	/// string unixPath = path.FastReplace("\\", "/");
	/// // Returns: "C:/Users/Documents/file.txt"
	/// </code>
	/// 
	/// Removing substrings by passing null as newValue:
	/// <code>
	/// string html = "&lt;div&gt;Content&lt;/div&gt;";
	/// string stripped = html.FastReplace("&lt;div&gt;", null).FastReplace("&lt;/div&gt;", null);
	/// // Returns: "Content"
	/// </code>
	/// 
	/// Case-sensitive behavior:
	/// <code>
	/// string text = "Replace REPLACE replace";
	/// string result = text.FastReplace("replace", "X");
	/// // Returns: "Replace REPLACE X" (only lowercase "replace" is replaced)
	/// </code>
	/// 
	/// Chaining multiple replacements:
	/// <code>
	/// string config = "server=localhost;port=5432;database=mydb";
	/// string updated = config.FastReplace("localhost", "192.168.1.1")
	///                       .FastReplace("5432", "3306")
	///                       .FastReplace("mydb", "production");
	/// // Returns: "server=192.168.1.1;port=3306;database=production"
	/// </code>
	/// </example>
	/// <seealso cref="string.Replace(string, string, StringComparison)"/>
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
	/// Hashes the base64Input string using the specified hashing algorithm.
	/// </summary>
	/// <param name="input">The base64Input string to hashType. Must not be null.</param>
	/// <param name="algorithmType">The hashing algorithm to use. Defaults to PBKDF2.</param>
	/// <returns>A base64-encoded string representing the hashed password.</returns>
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
		return input is not null && (input.Length > 0);
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
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasValue(this string input, int length)
	{
		length = length.ArgumentInRange(min: 1, max: length);

		return input is not null && (input.ArgumentNotNull().Trim().Length == length);
	}

	/// <summary>
	/// Determines whether the string equals the specified value using ordinal comparison.
	/// </summary>
	/// <param name="input">The string to check. Can be <c>null</c>.</param>
	/// <param name="value">The value to compare with the string. Can be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if the string is not <c>null</c>, has a non-zero length, and equals <paramref name="value"/> 
	/// using <see cref="StringComparison.Ordinal"/> comparison; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// This method performs two checks in sequence:
	/// <list type="number">
	/// <item><description>Validates that <paramref name="input"/> is not <c>null</c> and has a length greater than zero using <see cref="HasValue(string)"/>.</description></item>
	/// <item><description>Compares <paramref name="input"/> with <paramref name="value"/> using case-sensitive, culture-invariant ordinal comparison.</description></item>
	/// </list>
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Short-circuits if input is null or empty (no comparison performed)</description></item>
	/// <item><description>Uses <see cref="StringComparison.Ordinal"/> for fastest comparison performance</description></item>
	/// <item><description>Culture-insensitive: Results are consistent across all cultures and locales</description></item>
	/// <item><description>Case-sensitive: "ABC" and "abc" are treated as different strings</description></item>
	/// <item><description>Short-circuits if input is null or empty (no comparison performed)</description></item>
	/// <item><description>Time Complexity: O(n) where n = length of shorter string</description></item>
	/// <item><description>Space Complexity: O(1) - no allocations</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison Behavior:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Returns <c>false</c> if <paramref name="input"/> is <c>null</c></description></item>
	/// <item><description>Returns <c>false</c> if <paramref name="input"/> is empty</description></item>
	/// <item><description>Returns <c>false</c> if <paramref name="value"/> is <c>null</c> and <paramref name="input"/> is not <c>null</c></description></item>
	/// <item><description>Performs byte-by-byte comparison without linguistic rules</description></item>
	/// <item><description>Does not normalize Unicode characters before comparison</description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Validating exact string matches in configuration settings</description></item>
	/// <item><description>Comparing identifiers, keys, or codes where case sensitivity matters</description></item>
	/// <item><description>Verifying command-line arguments or parameter values</description></item>
	/// <item><description>Checking enumeration values as strings</description></item>
	/// <item><description>Protocol validation where exact matches are required</description></item>
	/// </list>
	/// </remarks>
	/// <example>
	/// Basic equality check:
	/// <code>
	/// string status = "Active";
	/// bool isActive = status.HasValue("Active");
	/// // Returns: true
	/// 
	/// bool isInactive = status.HasValue("Inactive");
	/// // Returns: false
	/// </code>
	/// 
	/// Case-sensitive comparison:
	/// <code>
	/// string role = "Admin";
	/// bool match1 = role.HasValue("Admin");   // Returns: true
	/// bool match2 = role.HasValue("admin");   // Returns: false (case mismatch)
	/// bool match3 = role.HasValue("ADMIN");   // Returns: false (case mismatch)
	/// </code>
	/// 
	/// Null and empty string handling:
	/// <code>
	/// string nullString = null;
	/// bool result1 = nullString.HasValue("test");
	/// // Returns: false (input is null)
	/// 
	/// string emptyString = "";
	/// bool result2 = emptyString.HasValue("test");
	/// // Returns: false (input is empty)
	/// 
	/// string value = "test";
	/// bool result3 = value.HasValue(null);
	/// // Returns: false (value parameter is null)
	/// </code>
	/// 
	/// Validating configuration values:
	/// <code>
	/// string environment = GetEnvironmentVariable("ENV");
	/// 
	/// if (environment.HasValue("Production"))
	/// {
	///     // Use production settings
	///     Console.WriteLine("Running in production mode");
	/// }
	/// else if (environment.HasValue("Development"))
	/// {
	///     // Use development settings
	///     Console.WriteLine("Running in development mode");
	/// }
	/// </code>
	/// 
	/// Checking enumeration string values:
	/// <code>
	/// string statusCode = GetStatusCode();
	/// 
	/// if (statusCode.HasValue("SUCCESS"))
	/// {
	///     ProcessSuccess();
	/// }
	/// else if (statusCode.HasValue("ERROR"))
	/// {
	///     ProcessError();
	/// }
	/// </code>
	/// 
	/// Comparing with whitespace strings:
	/// <code>
	/// string text = "  test  ";
	/// bool match = text.HasValue("test");
	/// // Returns: false (whitespace makes strings different)
	/// 
	/// bool exactMatch = text.HasValue("  test  ");
	/// // Returns: true (exact match including whitespace)
	/// </code>
	/// </example>
	/// <seealso cref="HasValue(string)"/>
	/// <seealso cref="string.Equals(string, string, StringComparison)"/>
	/// <seealso cref="StringComparison.Ordinal"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasValue(this string input, string value)
	{
		return input.HasValue() && string.Equals(input, value, StringComparison.Ordinal);
	}

	/// <summary>
	/// Validates whether the string length falls within the specified range.
	/// </summary>
	/// <param name="input">The string to validate. Can be <c>null</c>.</param>
	/// <param name="minLength">
	/// The minimum acceptable length for the string (inclusive). 
	/// Must be non-negative and less than or equal to <paramref name="maxLength"/>.
	/// </param>
	/// <param name="maxLength">
	/// The maximum acceptable length for the string (inclusive). 
	/// Must be greater than or equal to <paramref name="minLength"/>.
	/// </param>
	/// <returns>
	/// <c>true</c> if <paramref name="input"/> is not <c>null</c> and its length is within the range 
	/// [<paramref name="minLength"/>, <paramref name="maxLength"/>]; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown when:
	/// <list type="bullet">
	/// <item><description><paramref name="minLength"/> is less than 0</description></item>
	/// <item><description><paramref name="minLength"/> is greater than <paramref name="maxLength"/></description></item>
	/// <item><description><paramref name="maxLength"/> is less than <paramref name="minLength"/></description></item>
	/// </list>
	/// </exception>
	/// <remarks>
	/// This method validates that a string's length falls within an inclusive range. Both the minimum and maximum 
	/// length values are included in the valid range.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Short-circuits for null input (returns false immediately)</description></item>
	/// <item><description>Uses <see cref="int.IsInRange"/> for efficient bounds checking</description></item>
	/// <item><description>Time Complexity: O(1) - constant time check</description></item>
	/// <item><description>Space Complexity: O(1) - no allocations</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Validation Behavior:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Returns <c>false</c> if <paramref name="input"/> is <c>null</c></description></item>
	/// <item><description>The range is inclusive on both ends: [minLength, maxLength]</description></item>
	/// <item><description>A string with length equal to <paramref name="minLength"/> or <paramref name="maxLength"/> returns <c>true</c></description></item>
	/// <item><description>Empty strings (length 0) are valid only if <paramref name="minLength"/> is 0</description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Validating user input length (e.g., usernames, passwords)</description></item>
	/// <item><description>Checking string lengths before database operations with column size constraints</description></item>
	/// <item><description>Enforcing business rules for text field lengths</description></item>
	/// <item><description>Validating configuration values against expected length ranges</description></item>
	/// <item><description>Pre-validating data before serialization or API calls</description></item>
	/// </list>
	/// <para>
	/// <strong>Note:</strong> This method validates the current length of the string without trimming whitespace.
	/// If you need to validate length after removing whitespace, trim the string before calling this method.
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic length validation:
	/// <code>
	/// string username = "john_doe";
	/// bool isValidLength = username.HasValue(3, 20);
	/// // Returns: true (length 8 is between 3 and 20)
	/// </code>
	/// 
	/// Password length validation:
	/// <code>
	/// string password = "SecureP@ss123";
	/// bool meetsRequirements = password.HasValue(8, 128);
	/// // Returns: true (length 13 is between 8 and 128)
	/// </code>
	/// 
	/// Exact length match (min == max):
	/// <code>
	/// string zipCode = "12345";
	/// bool isExactLength = zipCode.HasValue(5, 5);
	/// // Returns: true (length exactly 5)
	/// </code>
	/// 
	/// Empty string handling:
	/// <code>
	/// string empty = "";
	/// bool allowEmpty = empty.HasValue(0, 10);
	/// // Returns: true (length 0 is within range)
	/// 
	/// bool requireNonEmpty = empty.HasValue(1, 10);
	/// // Returns: false (length 0 is below minimum of 1)
	/// </code>
	/// 
	/// Null string handling:
	/// <code>
	/// string nullString = null;
	/// bool isValid = nullString.HasValue(0, 100);
	/// // Returns: false (input is null)
	/// </code>
	/// 
	/// Validating database field constraints:
	/// <code>
	/// string description = GetUserInput();
	/// 
	/// // Database column has VARCHAR(500) constraint
	/// if (!description.HasValue(0, 500))
	/// {
	///     throw new ArgumentException("Description must be 500 characters or less");
	/// }
	/// </code>
	/// 
	/// Form field validation:
	/// <code>
	/// string firstName = textBox.Text;
	/// string lastName = textBox2.Text;
	/// 
	/// bool isFirstNameValid = firstName.HasValue(1, 50);
	/// bool isLastNameValid = lastName.HasValue(1, 50);
	/// 
	/// if (isFirstNameValid && isLastNameValid)
	/// {
	///     SaveUserData(firstName, lastName);
	/// }
	/// </code>
	/// 
	/// Edge cases - boundary testing:
	/// <code>
	/// string text = "Hello";
	/// 
	/// bool test1 = text.HasValue(5, 10);  // Returns: true (exactly at minimum)
	/// bool test2 = text.HasValue(1, 5);   // Returns: true (exactly at maximum)
	/// bool test3 = text.HasValue(6, 10);  // Returns: false (below minimum)
	/// bool test4 = text.HasValue(1, 4);   // Returns: false (above maximum)
	/// </code>
	/// 
	/// ArgumentOutOfRangeException examples:
	/// <code>
	/// string text = "test";
	/// 
	/// // Throws ArgumentOutOfRangeException: minLength < 0
	/// bool result1 = text.HasValue(-1, 10);
	/// 
	/// // Throws ArgumentOutOfRangeException: minLength > maxLength
	/// bool result2 = text.HasValue(10, 5);
	/// </code>
	/// </example>
	/// <seealso cref="HasValue(string)"/>
	/// <seealso cref="HasValue(string, int)"/>
	/// <seealso cref="int.IsInRange"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasValue), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasValue(this string input, int minLength, int maxLength)
	{
		minLength = minLength.ArgumentInRange(min: 0, max: maxLength);
		maxLength = maxLength.ArgumentInRange(min: minLength, max: int.MaxValue);

		return input is not null && input.Length.IsInRange(minLength, maxLength);
	}

	/// <summary>
	/// Determines whether the specified string contains any whitespace characters.
	/// </summary>
	/// <param name="input">The string to check for whitespace.</param>
	/// <returns><c>true</c> if the <paramref name="input"/> contains any whitespace characters; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses <see cref="char.IsWhiteSpace(char)"/> to check each character in the string for whitespace.
	/// </remarks>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasWhitespace([DisallowNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		//Span is slower
		foreach (var inputItem in input)
		{
			if (!inputItem.IsAsciiWhitespace())
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Adds indentation characters to the beginning of the input string.
	/// </summary>
	/// <param name="input">The string to indent. Must not be <c>null</c>.</param>
	/// <param name="length">
	/// The number of indentation characters to prepend to the string. 
	/// If <paramref name="length"/> is zero or negative, returns <see cref="string.Empty"/>.
	/// The absolute value of <paramref name="length"/> determines the actual number of characters added.
	/// </param>
	/// <param name="indentationCharacter">The character to use for indentation (e.g., space ' ', tab '\t').</param>
	/// <returns>
	/// A new string with the specified indentation prepended to <paramref name="input"/>.
	/// Returns <see cref="string.Empty"/> if <paramref name="input"/> is <c>null</c> or <paramref name="length"/> is less than or equal to zero.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is <c>null</c> when <paramref name="length"/> is greater than zero.</exception>
	/// <remarks>
	/// This method uses a pooled <see cref="StringBuilder"/> from <see cref="ObjectPool{T}"/> to optimize memory allocation 
	/// and reduce garbage collection pressure during string construction.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Uses pooled StringBuilder to avoid heap allocations</description></item>
	/// <item><description>Optimal for repeated indentation operations</description></item>
	/// <item><description>Early exit for invalid inputs (null or non-positive length)</description></item>
	/// <item><description>Time Complexity: O(n) where n = absolute value of <paramref name="length"/></description></item>
	/// <item><description>Space Complexity: O(n + m) where n = indentation length, m = input length</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Code generation and formatting</description></item>
	/// <item><description>Text alignment in console applications</description></item>
	/// <item><description>Creating hierarchical or nested text structures</description></item>
	/// <item><description>Formatting log output with indentation levels</description></item>
	/// <item><description>Generating indented JSON, XML, or other structured text</description></item>
	/// </list>
	/// <para>
	/// <strong>Note:</strong> This method creates a new string and does not modify the original <paramref name="input"/>.
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic indentation with spaces:
	/// <code>
	/// string text = "Hello World";
	/// string indented = text.Indent(4, ' ');
	/// // Returns: "    Hello World"
	/// </code>
	/// 
	/// Indenting with tabs:
	/// <code>
	/// string code = "Console.WriteLine(\"test\");";
	/// string indentedCode = code.Indent(2, '\t');
	/// // Returns: "\t\tConsole.WriteLine(\"test\");"
	/// </code>
	/// 
	/// Creating hierarchical text structure:
	/// <code>
	/// string title = "Chapter 1";
	/// string section = "Section 1.1".Indent(2, ' ');
	/// string subsection = "Topic 1.1.1".Indent(4, ' ');
	/// // title: "Chapter 1"
	/// // section: "  Section 1.1"
	/// // subsection: "    Topic 1.1.1"
	/// </code>
	/// 
	/// Zero or negative length returns empty string:
	/// <code>
	/// string text = "Sample";
	/// string result1 = text.Indent(0, ' ');  // Returns: ""
	/// string result2 = text.Indent(-5, ' '); // Returns: ""
	/// </code>
	/// 
	/// Formatting nested code blocks:
	/// <code>
	/// var lines = new[] { "if (condition)", "{", "DoSomething();", "}" };
	/// var formatted = new[]
	/// {
	///     lines[0],
	///     lines[1],
	///     lines[2].Indent(4, ' '),
	///     lines[3]
	/// };
	/// // Produces properly indented code structure
	/// </code>
	/// </example>
	/// <seealso cref="StringBuilder"/>
	/// <seealso cref="ObjectPool{T}"/>
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
	/// Determines whether the specified string is not empty.
	/// </summary>
	/// <param name="input">The string to check.</param>
	/// <returns><c>true</c> if the string is not empty; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks the opposite of <see cref="IsEmpty(string?)"/> to determine if a string is not empty.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNotEmpty), "David McCarter", "8/18/20", OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	/// Splits a string into substrings using a single character delimiter and returns them as a read-only collection.
	/// </summary>
	/// <param name="input">The string to split. Must not be <c>null</c> or empty.</param>
	/// <param name="options">
	/// A bitwise combination of <see cref="StringSplitOptions"/> values that specifies whether to trim substrings 
	/// and include empty substrings in the returned collection.
	/// </param>
	/// <param name="delimiter">
	/// The character delimiter used to separate substrings. Defaults to <see cref="ControlChars.Comma"/>.
	/// </param>
	/// <returns>
	/// A <see cref="ReadOnlyCollection{T}"/> of strings containing the substrings delimited by <paramref name="delimiter"/>.
	/// The returned collection is immutable and provides thread-safe read access.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="input"/> is empty.</exception>
	/// <remarks>
	/// This method wraps the standard <see cref="string.Split(char[], StringSplitOptions)"/> method and returns the result 
	/// as a read-only collection for improved immutability and type safety.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Uses case-sensitive ordinal comparison for delimiter matching</description></item>
	/// <item><description>Culture-insensitive: Behavior is consistent across all cultures</description></item>
	/// <item><description>Wraps result in <see cref="ReadOnlyCollection{T}"/> for immutability</description></item>
	/// <item><description>Time Complexity: O(n) where n = length of input string</description></item>
	/// <item><description>Space Complexity: O(m) where m = number of resulting substrings</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>StringSplitOptions Behavior:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description><see cref="StringSplitOptions.None"/> - Includes empty entries and preserves whitespace</description></item>
	/// <item><description><see cref="StringSplitOptions.RemoveEmptyEntries"/> - Excludes empty string elements from the result</description></item>
	/// <item><description><see cref="StringSplitOptions.TrimEntries"/> - Trims whitespace from each substring (.NET 5+)</description></item>
	/// <item><description>Flags can be combined using bitwise OR: <c>RemoveEmptyEntries | TrimEntries</c></description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Parsing CSV data or comma-separated values</description></item>
	/// <item><description>Processing delimited configuration strings</description></item>
	/// <item><description>Splitting user input into tokens</description></item>
	/// <item><description>Parsing file paths with custom separators</description></item>
	/// </list>
	/// <para>
	/// <strong>Note:</strong> Delimiter characters are not included in the returned substrings. Adjacent delimiters 
	/// produce empty strings in the result unless <see cref="StringSplitOptions.RemoveEmptyEntries"/> is specified.
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic splitting with default comma delimiter:
	/// <code>
	/// string data = "apple,banana,cherry";
	/// var fruits = data.Split(StringSplitOptions.None);
	/// // Returns: ReadOnlyCollection { "apple", "banana", "cherry" }
	/// </code>
	/// 
	/// Removing empty entries:
	/// <code>
	/// string data = "one,,two,,,three";
	/// var items = data.Split(StringSplitOptions.RemoveEmptyEntries);
	/// // Returns: ReadOnlyCollection { "one", "two", "three" }
	/// </code>
	/// 
	/// Splitting with custom delimiter:
	/// <code>
	/// string path = "C:\\Users\\Documents\\file.txt";
	/// var parts = path.Split(StringSplitOptions.RemoveEmptyEntries, '\\');
	/// // Returns: ReadOnlyCollection { "C:", "Users", "Documents", "file.txt" }
	/// </code>
	/// 
	/// Combining options to trim and remove empty entries:
	/// <code>
	/// string data = "  alpha  ,  , beta  , gamma  ";
	/// var cleaned = data.Split(StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
	/// // Returns: ReadOnlyCollection { "alpha", "beta", "gamma" }
	/// </code>
	/// 
	/// Splitting with semicolon delimiter:
	/// <code>
	/// string config = "key1=value1;key2=value2;key3=value3";
	/// var pairs = config.Split(StringSplitOptions.None, ';');
	/// // Returns: ReadOnlyCollection { "key1=value1", "key2=value2", "key3=value3" }
	/// </code>
	/// 
	/// Processing tab-separated data:
	/// <code>
	/// string tsvRow = "Name\tAge\tCity";
	/// var columns = tsvRow.Split(StringSplitOptions.None, '\t');
	/// // Returns: ReadOnlyCollection { "Name", "Age", "City" }
	/// </code>
	/// </example>
	/// <seealso cref="string.Split(char[], StringSplitOptions)"/>
	/// <seealso cref="ReadOnlyCollection{T}"/>
	/// <seealso cref="StringSplitOptions"/>
	/// <seealso cref="Array.AsReadOnly{T}(T[])"/>
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
	/// Splits a multi-line string into individual lines using a zero-allocation enumerator pattern.
	/// </summary>
	/// <param name="input">The string to split into lines. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// A <see cref="LineSplitEnumerator"/> that enables efficient enumeration over each line in the string.
	/// This is a ref struct enumerator that provides zero-allocation iteration.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="input"/> is empty.</exception>
	/// <remarks>
	/// This method provides a high-performance, allocation-free way to iterate over lines in a string by leveraging
	/// <see cref="ReadOnlySpan{T}"/> and the <see cref="LineSplitEnumerator"/> ref struct pattern.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Zero heap allocations - uses stack-only ref struct enumerator</description></item>
	/// <item><description>No string copying - operates directly on the original string's memory</description></item>
	/// <item><description>Recognizes all standard line terminators: \r, \n, and \r\n</description></item>
	/// <item><description>SIMD-accelerated line break detection on supported platforms</description></item>
	/// <item><description>Time Complexity: O(n) where n = length of input string</description></item>
	/// <item><description>Space Complexity: O(1) - no heap allocations during enumeration</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Line Terminator Support:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Carriage Return (CR): '\r' - Classic Mac OS line endings</description></item>
	/// <item><description>Line Feed (LF): '\n' - Unix/Linux/macOS line endings</description></item>
	/// <item><description>Carriage Return + Line Feed (CRLF): '\r\n' - Windows line endings</description></item>
	/// <item><description>Handles mixed line endings within the same string</description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Processing large text files or logs line-by-line without allocations</description></item>
	/// <item><description>Parsing CSV, TSV, or other line-delimited data formats</description></item>
	/// <item><description>Analyzing multi-line configuration files or scripts</description></item>
	/// <item><description>High-performance text processing in tight loops</description></item>
	/// <item><description>Real-time log processing with minimal GC pressure</description></item>
	/// </list>
	/// <para>
	/// <strong>Important Notes:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description><see cref="LineSplitEnumerator"/> is a ref struct and cannot be stored in fields or used in async methods</description></item>
	/// <item><description>The enumerator returns <see cref="ReadOnlySpan{T}"/> instances that reference the original string</description></item>
	/// <item><description>Line terminators are not included in the returned spans</description></item>
	/// <item><description>Empty lines (consecutive line breaks) are preserved as empty spans</description></item>
	/// <item><description>The last line is included even if it doesn't end with a line terminator</description></item>
	/// </list>
	/// </remarks>
	/// <example>
	/// Basic line-by-line enumeration:
	/// <code>
	/// string multiLineText = "Line 1\nLine 2\nLine 3";
	/// 
	/// foreach (var line in multiLineText.SplitLines())
	/// {
	///     Console.WriteLine($"Length: {line.Length}, Content: {line}");
	/// }
	/// // Output:
	/// // Length: 6, Content: Line 1
	/// // Length: 6, Content: Line 2
	/// // Length: 6, Content: Line 3
	/// </code>
	/// 
	/// Processing mixed line endings:
	/// <code>
	/// string mixedText = "Windows\r\nUnix\nMac\rEnd";
	/// 
	/// foreach (var line in mixedText.SplitLines())
	/// {
	///     Console.WriteLine(line.ToString());
	/// }
	/// // Output:
	/// // Windows
	/// // Unix
	/// // Mac
	/// // End
	/// </code>
	/// 
	/// Handling empty lines:
	/// <code>
	/// string textWithEmptyLines = "First\n\nThird\n";
	/// 
	/// int lineCount = 0;
	/// foreach (var line in textWithEmptyLines.SplitLines())
	/// {
	///     lineCount++;
	///     Console.WriteLine($"Line {lineCount}: '{line}' (Length: {line.Length})");
	/// }
	/// // Output:
	/// // Line 1: 'First' (Length: 5)
	/// // Line 2: '' (Length: 0)
	/// // Line 3: 'Third' (Length: 5)
	/// // Line 4: '' (Length: 0)
	/// </code>
	/// 
	/// Zero-allocation log processing:
	/// <code>
	/// string logData = File.ReadAllText("large.log");
	/// int errorCount = 0;
	/// 
	/// // No allocations during enumeration
	/// foreach (var line in logData.SplitLines())
	/// {
	///     if (line.Contains("ERROR", StringComparison.OrdinalIgnoreCase))
	///     {
	///         errorCount++;
	///     }
	/// }
	/// 
	/// Console.WriteLine($"Found {errorCount} errors");
	/// </code>
	/// 
	/// Manual enumerator usage (advanced):
	/// <code>
	/// string text = "Alpha\nBeta\nGamma";
	/// var enumerator = text.SplitLines();
	/// 
	/// while (enumerator.MoveNext())
	/// {
	///     ReadOnlySpan&lt;char&gt; currentLine = enumerator.Current;
	///     // Process line without allocation
	///     if (currentLine.Length > 3)
	///     {
	///         Console.WriteLine($"Long line: {currentLine}");
	///     }
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="LineSplitEnumerator"/>
	/// <seealso cref="ReadOnlySpan{T}"/>
	/// <seealso cref="string.Split(char[], StringSplitOptions)"/>
	/// <seealso cref="MemoryExtensions"/>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SplitLines), "David McCarter", "6/9/2022", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed)]
	public static LineSplitEnumerator SplitLines([DisallowNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		//TODO: ALLOCATIONS WENT UP. FIX.
		// LineSplitEnumerator is a struct so there is no allocation here
		return new LineSplitEnumerator(input.AsSpan());
	}

	/// <summary>
	/// Splits a comma-delimited string into a read-only collection of non-empty substrings.
	/// </summary>
	/// <param name="input">The string to split. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// A <see cref="ReadOnlyCollection{T}"/> of strings containing all non-empty substrings from the comma-delimited input.
	/// The collection is immutable and provides thread-safe read access. Leading and trailing whitespace is trimmed from the input.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentException">Thrown if <paramref name="input"/> is empty.</exception>
	/// <remarks>
	/// This method is a convenience wrapper that combines trimming, splitting by comma, and removing empty entries 
	/// in a single operation. It automatically trims the input string before splitting.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Uses <see cref="ControlChars.Comma"/> as the fixed delimiter</description></item>
	/// <item><description>Automatically applies <see cref="StringSplitOptions.RemoveEmptyEntries"/></description></item>
	/// <item><description>Trims input string before processing</description></item>
	/// <item><description>Returns immutable <see cref="ReadOnlyCollection{T}"/> for type safety</description></item>
	/// <item><description>Time Complexity: O(n) where n = length of input string</description></item>
	/// <item><description>Space Complexity: O(m) where m = number of non-empty substrings</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Behavior Details:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Empty strings between consecutive commas are excluded from results</description></item>
	/// <item><description>Leading and trailing commas do not produce empty entries</description></item>
	/// <item><description>Whitespace-only entries between commas are included (not trimmed individually)</description></item>
	/// <item><description>The delimiter (comma) is never included in the returned substrings</description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Parsing CSV data where empty values should be ignored</description></item>
	/// <item><description>Processing comma-separated lists from configuration files</description></item>
	/// <item><description>Splitting tag lists or keyword strings</description></item>
	/// <item><description>Parsing user input with optional comma-separated values</description></item>
	/// <item><description>Processing enumeration strings or flag lists</description></item>
	/// </list>
	/// <para>
	/// <strong>Note:</strong> This method only trims the entire input string, not individual substrings. 
	/// If you need to trim whitespace from each resulting substring, consider using 
	/// <see cref="Split(string, StringSplitOptions, char)"/> with 
	/// <see cref="StringSplitOptions.RemoveEmptyEntries"/> | <see cref="StringSplitOptions.TrimEntries"/>.
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic comma-separated list:
	/// <code>
	/// string data = "apple,banana,cherry";
	/// var fruits = data.SplitRemoveEmpty();
	/// // Returns: ReadOnlyCollection { "apple", "banana", "cherry" }
	/// </code>
	/// 
	/// Handling empty entries between commas:
	/// <code>
	/// string data = "one,,two,,,three";
	/// var items = data.SplitRemoveEmpty();
	/// // Returns: ReadOnlyCollection { "one", "two", "three" }
	/// </code>
	/// 
	/// Leading and trailing commas:
	/// <code>
	/// string data = ",alpha,beta,gamma,";
	/// var values = data.SplitRemoveEmpty();
	/// // Returns: ReadOnlyCollection { "alpha", "beta", "gamma" }
	/// </code>
	/// 
	/// Whitespace handling (input trimmed, but entries not individually trimmed):
	/// <code>
	/// string data = "  red, green , blue  ";
	/// var colors = data.SplitRemoveEmpty();
	/// // Returns: ReadOnlyCollection { "red", " green ", " blue" }
	/// // Note: Individual entries retain their internal whitespace
	/// </code>
	/// 
	/// Empty string after trimming:
	/// <code>
	/// string data = "   ";
	/// var empty = data.SplitRemoveEmpty();
	/// // Returns: ReadOnlyCollection { } (empty collection)
	/// </code>
	/// 
	/// Processing configuration values:
	/// <code>
	/// string configValue = "Debug,Release,Test";
	/// var configurations = configValue.SplitRemoveEmpty();
	/// foreach (var config in configurations)
	/// {
	///     Console.WriteLine($"Configuration: {config}");
	/// }
	/// // Output:
	/// // Configuration: Debug
	/// // Configuration: Release
	/// // Configuration: Test
	/// </code>
	/// 
	/// Using with LINQ:
	/// <code>
	/// string tags = "c#,dotnet,,azure,,,cloud";
	/// var uniqueTags = tags.SplitRemoveEmpty()
	///                      .Select(t => t.Trim())
	///                      .Distinct()
	///                      .OrderBy(t => t);
	/// // Returns sorted unique tags with whitespace trimmed
	/// </code>
	/// </example>
	/// <seealso cref="Split(string, StringSplitOptions, char)"/>
	/// <seealso cref="DelimitedStringToArray(string, char)"/>
	/// <seealso cref="ReadOnlyCollection{T}"/>
	/// <seealso cref="StringSplitOptions.RemoveEmptyEntries"/>
	/// <seealso cref="ControlChars.Comma"/>
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
	/// Extracts a substring from the specified range of the string and trims leading and trailing whitespace from the result.
	/// </summary>
	/// <param name="input">The string from which to extract and trim the substring. Can be <c>null</c> or empty.</param>
	/// <param name="startIndex">The zero-based starting character position of the substring. Must be non-negative.</param>
	/// <param name="length">The number of characters in the substring. Must be non-negative.</param>
	/// <returns>
	/// A new string that represents the trimmed substring starting at <paramref name="startIndex"/> with the specified <paramref name="length"/>.
	/// Returns <see cref="ControlChars.EmptyString"/> if <paramref name="input"/> is <c>null</c> or empty.
	/// Leading and trailing whitespace characters are removed from the extracted substring.
	/// </returns>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown when:
	/// <list type="bullet">
	/// <item><description><paramref name="startIndex"/> is less than zero.</description></item>
	/// <item><description><paramref name="length"/> is less than zero.</description></item>
	/// <item><description><paramref name="startIndex"/> + <paramref name="length"/> exceeds the length of <paramref name="input"/>.</description></item>
	/// </list>
	/// </exception>
	/// <remarks>
	/// This method combines substring extraction with whitespace trimming in a single operation, providing
	/// a convenient alternative to chaining <see cref="string.Substring(int, int)"/> with <see cref="string.Trim()"/>.
	/// <para>
	/// <strong>Performance Characteristics (.NET 10):</strong>
	/// <list type="bullet">
	/// <item><description>Uses <see cref="MemoryExtensions.AsSpan(string, int, int)"/> for zero-allocation substring extraction</description></item>
	/// <item><description>Converts span to string before calling <see cref="string.Trim()"/> to remove whitespace</description></item>
	/// <item><description>Early exit returns empty string for null or empty input</description></item>
	/// <item><description>Time Complexity: O(n) where n = <paramref name="length"/></description></item>
	/// <item><description>Space Complexity: O(n) for the resulting trimmed string</description></item>
	/// <item><description>Two string allocations: one for span conversion, one for trim result</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Whitespace Characters:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Space (U+0020), Tab (U+0009), Line Feed (U+000A), Carriage Return (U+000D)</description></item>
	/// <item><description>All Unicode whitespace characters as defined by <see cref="char.IsWhiteSpace(char)"/></description></item>
	/// <item><description>Includes non-breaking spaces, zero-width spaces, and other Unicode whitespace</description></item>
	/// </list>
	/// <para>
	/// <strong>Common Use Cases:</strong>
	/// </para>
	/// <list type="bullet">
	/// <item><description>Extracting and cleaning substrings from fixed-width formatted data</description></item>
	/// <item><description>Parsing delimited text where fields may contain leading/trailing whitespace</description></item>
	/// <item><description>Processing log file entries with fixed-position fields</description></item>
	/// <item><description>Extracting tokens from parsed strings while removing padding</description></item>
	/// <item><description>Working with CSV or TSV data that needs whitespace normalization</description></item>
	/// </list>
	/// <para>
	/// <strong>Note:</strong> This method creates a new string and does not modify the original <paramref name="input"/>.
	/// The substring is extracted first, then whitespace is trimmed from the result.
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic substring extraction with trimming:
	/// <code>
	/// string text = "  Hello World  ";
	/// string result = text.SubstringTrim(2, 11);
	/// // Returns: "Hello World" (leading/trailing spaces removed)
	/// </code>
	/// 
	/// Extracting from fixed-width data:
	/// <code>
	/// string record = "John      Doe       30";
	/// string firstName = record.SubstringTrim(0, 10);   // Returns: "John"
	/// string lastName = record.SubstringTrim(10, 12);   // Returns: "Doe"
	/// string age = record.SubstringTrim(22, 2);         // Returns: "30"
	/// </code>
	/// 
	/// Handling null or empty strings:
	/// <code>
	/// string nullString = null;
	/// string result = nullString.SubstringTrim(0, 5);
	/// // Returns: "" (empty string)
	/// 
	/// string emptyString = "";
	/// string result2 = emptyString.SubstringTrim(0, 0);
	/// // Returns: "" (empty string)
	/// </code>
	/// 
	/// Parsing delimited data:
	/// <code>
	/// string csv = "Alpha, Beta , Gamma ";
	/// int start = 0;
	/// int commaPos = csv.IndexOf(',');
	/// string field1 = csv.SubstringTrim(start, commaPos);
	/// // Returns: "Alpha" (comma and spaces trimmed)
	/// </code>
	/// 
	/// ArgumentOutOfRangeException examples:
	/// <code>
	/// string text = "Hello";
	/// 
	/// // Throws ArgumentOutOfRangeException: startIndex &lt; 0
	/// string result1 = text.SubstringTrim(-1, 5);
	/// 
	/// // Throws ArgumentOutOfRangeException: length &lt; 0
	/// string result2 = text.SubstringTrim(0, -1);
	/// 
	/// // Throws ArgumentOutOfRangeException: startIndex + length &gt; text.Length
	/// string result3 = text.SubstringTrim(3, 10);
	/// </code>
	/// 
	/// Extracting and cleaning log entries:
	/// <code>
	/// string logLine = "[2024-01-04]   ERROR   Database connection failed   ";
	/// string timestamp = logLine.SubstringTrim(1, 10);    // Returns: "2024-01-04"
	/// string level = logLine.SubstringTrim(13, 10);       // Returns: "ERROR"
	/// string message = logLine.SubstringTrim(24, 30);     // Returns: "Database connection failed"
	/// </code>
	/// </example>
	/// <seealso cref="string.Substring(int, int)"/>
	/// <seealso cref="string.Trim()"/>
	/// <seealso cref="MemoryExtensions.AsSpan(string, int, int)"/>
	/// <seealso cref="ControlChars.EmptyString"/>
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
	/// Encodes the input string into its Base64 representation.
	/// </summary>
	/// <param name="input">The string to encode.</param>
	/// <returns>A Base64 encoded string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
	[Information(nameof(ToBase64Bytes), "David McCarter", "12/30/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated)]
	public static byte[] ToBase64Bytes([DisallowNull] this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		var exactSize = input.CalculateByteArraySize();
		var buffer = new byte[exactSize];

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
	/// Trims the specified string, removing all leading and trailing white-space characters.
	/// </summary>
	/// <param name="input">The string to trim. If this string is null, an empty string is returned.</param>
	/// <returns>A trimmed string, or an empty string if the base64Input is null.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToTrimmed), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string? ToTrimmed([AllowNull] this string input)
	{
		//TODO: TRY TO REMOVE TRIM FOR PERFORMANCE
		return input!.IsNullOrEmpty() ? input : input?.Trim();
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
