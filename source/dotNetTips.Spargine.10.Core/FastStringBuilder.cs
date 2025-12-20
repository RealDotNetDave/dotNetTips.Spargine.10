// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 12-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 12-19-2025
// ***********************************************************************
// <copyright file="FastStringBuilder.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Enhances performance when using a StringBuilder by employing an
// ObjectPool.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides methods to efficiently build strings using a pooled StringBuilder to reduce memory allocations.
/// </summary>
/// <remarks>
/// This class leverages an ObjectPool of StringBuilder instances to minimize the overhead of creating and disposing StringBuilder objects,
/// which can lead to significant performance improvements in scenarios where string manipulation is frequent.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineFastStringBuilder")]
public static class FastStringBuilder
{

	/// <summary>
	/// The ObjectPool of StringBuilder instances.
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Estimates the total string length needed for combining multiple strings with single-character separators.
	/// </summary>
	/// <param name="args">A read-only span of strings to measure.</param>
	/// <returns>
	/// The estimated capacity in characters, calculated as the sum of all string lengths plus (n-1) separator characters.
	/// </returns>
	/// <remarks>
	/// This method efficiently calculates the required StringBuilder capacity to avoid internal buffer reallocations.
	/// The calculation includes:
	/// <list type="bullet">
	/// <item><description>Sum of all individual string lengths (handling null strings as zero length)</description></item>
	/// <item><description>Space for (n-1) separator characters between strings</description></item>
	/// </list>
	/// The method uses a simple loop for optimal performance on small to medium-sized collections.
	/// For very large collections (10,000+ strings), the JIT compiler can optimize this pattern efficiently.
	/// </remarks>
	/// <example>
	/// This example shows how the estimation works:
	/// <code>
	/// ReadOnlySpan&lt;string&gt; words = ["Hello", "World", "!"];
	/// // "Hello" (5) + "World" (5) + "!" (1) = 11 chars
	/// // Plus 2 spaces between 3 words = 13 total
	/// int capacity = EstimateParamsStringLength(words); // Returns 13
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int EstimateParamsStringLength(ReadOnlySpan<string> args)
	{
		var length = args.Length;

		// Early exit for empty span
		if (length == 0)
		{
			return 0;
		}

		var estimatedCapacity = 0;

		// Use foreach for ReadOnlySpan - JIT optimizes with bounds check elimination
		foreach (var arg in args)
		{
			// Handle null strings as zero length to avoid NullReferenceException
			estimatedCapacity += arg?.Length ?? 0;
		}

		// Add separator characters: (n-1) separators for n strings
		estimatedCapacity += length - 1;

		return estimatedCapacity;
	}

	/// <summary>
	/// Converts an array of bytes into a hexadecimal string representation, making it easy to inspect raw byte data in string form.
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// </summary>
	/// <param name="bytes">The byte array to convert.</param>
	/// <returns>A hexadecimal string representation of the byte array, prefixed with '0x'.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToString), author: "David McCarter", createdOn: "3/7/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string BytesToString([DisallowNull] ref readonly byte[] bytes)
	{
		if (bytes is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(bytes));
		}

		var sb = _stringBuilderPool.Get().ClearSetCapacity((bytes.Length * 2) + 3);


		try
		{
			//FrozenSet, ImmutableArray and Span is slower.
			foreach (var @byte in bytes)
			{
				_ = sb.Append(@byte.ToString("X2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Converts a ReadOnlySpan of bytes into a hexadecimal string representation, making it easy to inspect raw byte data in string form.
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// </summary>
	/// <param name="bytes">The ReadOnlySpan of bytes to convert.</param>
	/// <returns>A hexadecimal string representation of the byte array, prefixed with '0x'.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToString), author: "David McCarter", createdOn: "2/18/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string BytesToString([AllowNull] in ReadOnlySpan<byte> bytes)
	{
		if (bytes.IsEmpty)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get();

		// Set capacity to increase performance
		_ = sb.EnsureCapacity((bytes.Length * 2) + 2);

		try
		{
			foreach (var @byte in bytes)
			{
				_ = sb.Append(@byte.ToString("X2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Combines an array of strings into a single string, optionally adding a line feed after each element.
	/// </summary>
	/// <param name="addLineFeed">If set to <c>true</c>, appends <see cref="Environment.NewLine"/> after each string element.</param>
	/// <param name="args">The array of strings to combine. Must not be null.</param>
	/// <returns>
	/// A combined string with or without line feeds after each element based on the value of <paramref name="addLineFeed"/>.
	/// Returns an empty string if <paramref name="args"/> is empty.
	/// </returns>
	/// <remarks>
	/// This method uses a pooled <see cref="StringBuilder"/> for optimal performance and reduced allocations.
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(n) where n is the number of strings in the array</description></item>
	/// <item><description>Space Complexity: O(m) where m is the total length of all strings plus line terminators</description></item>
	/// <item><description>Allocations: 1 (final string only, StringBuilder is pooled)</description></item>
	/// <item><description>ReadOnlySpan parameter enables zero-copy params array handling</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Implementation Details:</strong>
	/// This method does NOT pre-calculate capacity because:
	/// <list type="number">
	/// <item><description>Calculating total length would require iterating all strings (O(n) overhead)</description></item>
	/// <item><description>When <paramref name="addLineFeed"/> is true, the line terminator length varies by platform (Windows: 2 chars, Unix: 1 char)</description></item>
	/// <item><description>StringBuilder's default capacity (16) and doubling growth strategy handle most common cases efficiently</description></item>
	/// <item><description>The conditional branch per element is more expensive than letting StringBuilder grow naturally for small collections</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Line Terminator Behavior:</strong>
	/// When <paramref name="addLineFeed"/> is <c>true</c>, the method uses <see cref="StringBuilder.AppendLine(string)"/> 
	/// which appends the platform-specific line terminator from <see cref="Environment.NewLine"/>:
	/// <list type="bullet">
	/// <item><description>Windows: CR+LF (\r\n)</description></item>
	/// <item><description>Unix/Linux/macOS: LF (\n)</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// This example demonstrates combining strings with and without line feeds:
	/// <code>
	/// // Simple concatenation without line feeds
	/// var parts = new[] { "Hello", "World", "!" };
	/// string result = FastStringBuilder.Combine(false, parts);
	/// // Output: "HelloWorld!"
	/// 
	/// // Combine with line feeds (creates multi-line string)
	/// var lines = new[] { "First line", "Second line", "Third line" };
	/// string multiLine = FastStringBuilder.Combine(true, lines);
	/// // Output on Windows:
	/// // "First line\r\n
	/// //  Second line\r\n
	/// //  Third line\r\n"
	/// 
	/// // Using params syntax
	/// string quick = FastStringBuilder.Combine(false, "One", "Two", "Three");
	/// // Output: "OneTwoThree"
	/// 
	/// // Empty array returns empty string
	/// string empty = FastStringBuilder.Combine(false);
	/// // Output: ""
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">This exception is not thrown by this overload since ReadOnlySpan cannot be null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Combine), "David McCarter", "12/23/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Updated)]
	public static string Combine(in bool addLineFeed = false, [DisallowNull] params ReadOnlySpan<string> args)
	{
		// Early exit for empty collection - avoids StringBuilder acquisition
		if (args.Length == 0)
		{
			return ControlChars.EmptyString;
		}

		var estimatedLength = EstimateParamsStringLength(args);

		var sb = _stringBuilderPool.Get().SetCapacity(estimatedLength);

		try
		{
			// Use foreach for ReadOnlySpan - JIT optimizes this to bounds-check-eliminated loop
			// Conditional per iteration is necessary due to different append methods
			foreach (var arg in args)
			{
				_ = addLineFeed ? sb.AppendLine(arg) : sb.Append(arg);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Combines an array of strings into a single string, adding a space between each word.
	/// </summary>
	/// <remarks>
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// It is particularly useful for scenarios where frequent string concatenation with spaces is required.
	/// </remarks>
	/// <param name="args">The array of strings to combine. Must not be null or empty.</param>
	/// <returns>
	/// A combined string with spaces between each word. Returns an empty string if <paramref name="args"/> is null or empty.
	/// </returns>
	/// <example>
	/// This example demonstrates how to use the <see cref="CombineWithSpace"/> method:
	/// <code>
	/// var result = FastStringBuilder.CombineWithSpace("Hello", "World", "!");
	/// Console.WriteLine(result);
	/// // Output: Hello World !
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="args"/> is null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CombineWithSpace), "David McCarter", "3/6/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Updated)]
	public static string CombineWithSpace([DisallowNull] params ReadOnlySpan<string> args)
	{
		if (args.Length == 0)
		{
			return ControlChars.EmptyString;
		}

		// Single string - no spaces needed
		if (args.Length == 1)
		{
			return args[0] ?? ControlChars.EmptyString;
		}

		var estimatedCapacity = EstimateParamsStringLength(args);
		var sb = _stringBuilderPool.Get().SetCapacity(estimatedCapacity);

		try
		{
			// Append first item directly without null coalescing to avoid allocation
			if (args[0] is not null)
			{
				_ = sb.Append(args[0]);
			}

			// Use single Append call with interpolated handler for better performance
			for (var index = 1; index < args.Length; index++)
			{
				if (args[index] is not null)
				{
					_ = sb.Append(ControlChars.Space);
					_ = sb.Append(args[index]);
				}
				else
				{
					_ = sb.Append(ControlChars.Space);
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Concatenates an array of strings using a specified delimiter, optionally adding a line feed after each element.
	/// </summary>
	/// <remarks>
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// It is particularly useful for scenarios where frequent string concatenation with delimiters is required.
	/// </remarks>
	/// <param name="delimiter">The character used to separate each string in the output. Defaults to a comma.</param>
	/// <param name="addLineFeed">If set to <c>true</c>, adds a line feed after each element instead of using the delimiter.</param>
	/// <param name="args">The array of strings to concatenate. Must not be null or empty.</param>
	/// <returns>
	/// A concatenated string with elements separated by <paramref name="delimiter"/> or line feeds based on <paramref name="addLineFeed"/>.
	/// Returns an empty string if <paramref name="args"/> is null or empty.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="args"/> is null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Concat), "David McCarter", "2/19/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
	public static string Concat([ConstantExpected] char delimiter = ControlChars.Comma, in bool addLineFeed = false, [DisallowNull] params string[] args)
	{
		args = args.ArgumentNotNull();

		var sb = _stringBuilderPool.Get();

		try
		{
			var itemCount = args.Count();

			for (var index = 0; index < itemCount; index++)
			{
				_ = sb.Append(args[index]);

				if (index < itemCount - 1)
				{
					_ = addLineFeed ? sb.AppendLine() : sb.Append(delimiter);
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Concatenates an array of strings using a specified delimiter, optionally adding a line feed after each element.
	/// </summary>
	/// <remarks>
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// It is particularly useful for scenarios where frequent string concatenation with delimiters is required.
	/// </remarks>
	/// <param name="delimiter">The character used to separate each string in the output. Defaults to a comma.</param>
	/// <param name="addLineFeed">If set to <c>true</c>, adds a line feed after each element instead of using the delimiter.</param>
	/// <param name="args">The array of strings to concatenate. Must not be null or empty.</param>
	/// <returns>
	/// A concatenated string with elements separated by <paramref name="delimiter"/> or line feeds based on <paramref name="addLineFeed"/>.
	/// Returns an empty string if <paramref name="args"/> is null or empty.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="args"/> is null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Concat), "David McCarter", "2/19/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
	public static string Concat(string delimiter = ControlChars.CommaSpace, in bool addLineFeed = false, [DisallowNull] params ReadOnlyCollection<string> args)
	{
		args = args.ArgumentNotNull();

		delimiter ??= ControlChars.CommaSpace;

		var sb = _stringBuilderPool.Get();

		try
		{
			var itemCount = args.Count;

			for (var index = 0; index < itemCount; index++)
			{
				_ = sb.Append(args[index]);

				if (index < itemCount - 1)
				{
					_ = addLineFeed ? sb.AppendLine() : sb.Append(delimiter);
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Formats a string using the specified format and arguments.
	/// </summary>
	/// <remarks>
	/// This method uses an object pool for <see cref="StringBuilder"/> to improve performance and reduce memory allocations.
	/// It is particularly useful for scenarios where frequent string formatting is required.
	/// </remarks>
	/// <param name="format">A composite format string. Must not be null or empty.</param>
	/// <param name="args">An array of objects to format. Must not be null or empty.</param>
	/// <returns>
	/// A formatted string based on the specified format and arguments. Returns an empty string if <paramref name="format"/> or <paramref name="args"/> is null or empty.
	/// </returns>
	/// <example>
	/// This example demonstrates how to use the <see cref="Format"/> method:
	/// <code>
	/// var result = FastStringBuilder.Format("Hello, {0}!", "World");
	/// Console.WriteLine(result);
	/// // Output: Hello, World!
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="format"/> or <paramref name="args"/> is null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Format), "David McCarter", "03/04/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string Format(string format, params string[] args)
	{
		if (args.CheckItemsExists() is false || format.CheckIsNotNull() is false)
		{
			return ControlChars.EmptyString;
		}

		// Pre-allocate capacity to minimize reallocations during formatting
		// Estimate: format string length + (average 10 chars per argument)
		var estimatedCapacity = format.Length + (args.Length * 10);
		var sb = _stringBuilderPool.Get().SetCapacity(estimatedCapacity);

		try
		{
			return sb.AppendFormat(CultureInfo.CurrentCulture, format, args).ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Joins an enumerable collection of strings into a single string with a specified character delimiter.
	/// </summary>
	/// <param name="values">The collection of strings to join. Cannot be null.</param>
	/// <param name="delimiter">The character delimiter to insert between each string. Defaults to comma.</param>
	/// <returns>
	/// A single string containing all values from the collection separated by the delimiter.
	/// Returns an empty string if the collection is empty.
	/// </returns>
	/// <remarks>
	/// This method uses a pooled <see cref="StringBuilder"/> for optimal performance and reduced allocations.
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(n) where n is the number of strings in the collection</description></item>
	/// <item><description>Space Complexity: O(m) where m is the total length of all strings plus delimiters</description></item>
	/// <item><description>Allocations: 1 (final string only, StringBuilder is pooled and enumerator may be struct-based)</description></item>
	/// <item><description>Branchless append pattern eliminates (n-1) conditional checks</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Implementation Details:</strong>
	/// The method uses an explicit enumerator pattern to avoid LINQ overhead and enable the compiler/JIT to optimize
	/// for value-type enumerators (e.g., List&lt;T&gt;.Enumerator, array enumerators) which eliminates boxing allocations.
	/// The first element is appended without a delimiter, then subsequent elements are prepended with the delimiter,
	/// creating a branchless loop that's CPU cache-friendly and branch-predictor optimized.
	/// </para>
	/// <para>
	/// <strong>Note:</strong> This method does NOT pre-calculate StringBuilder capacity because:
	/// <list type="number">
	/// <item><description>IEnumerable&lt;T&gt; doesn't provide count without enumeration</description></item>
	/// <item><description>Many IEnumerable implementations (LINQ queries, generators) can't provide count efficiently</description></item>
	/// <item><description>Double enumeration would negate performance benefits</description></item>
	/// <item><description>StringBuilder's default capacity (16) and growth strategy handle most common cases efficiently</description></item>
	/// </list>
	/// For collections with known counts (arrays, lists), consider using collection-specific overloads if available.
	/// </para>
	/// </remarks>
	/// <example>
	/// This example demonstrates joining strings with different delimiters:
	/// <code>
	/// // Join with default comma delimiter
	/// var fruits = new[] { "Apple", "Banana", "Cherry" };
	/// string result = FastStringBuilder.Join(fruits);
	/// // Output: "Apple,Banana,Cherry"
	/// 
	/// // Join with custom delimiter
	/// string pipeSeparated = FastStringBuilder.Join(fruits, '|');
	/// // Output: "Apple|Banana|Cherry"
	/// 
	/// // Join LINQ query (no double enumeration)
	/// var numbers = Enumerable.Range(1, 5).Select(n => n.ToString());
	/// string joined = FastStringBuilder.Join(numbers, '-');
	/// // Output: "1-2-3-4-5"
	/// 
	/// // Empty collection returns empty string
	/// var empty = Array.Empty&lt;string&gt;();
	/// string emptyResult = FastStringBuilder.Join(empty);
	/// // Output: ""
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Join), "David McCarter", "03/04/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string Join([DisallowNull] IEnumerable<string> values, [ConstantExpected] char delimiter = ControlChars.Comma)
	{
		values = values.ArgumentNotNull();

		var sb = _stringBuilderPool.Get();

		try
		{
			// Use explicit enumerator to enable value-type optimization for common collections
			// (List<T>.Enumerator, Array enumerator, etc. are value types - no boxing)
			using var enumerator = values.GetEnumerator();

			// Append first element without delimiter (branchless pattern start)
			if (enumerator.MoveNext())
			{
				_ = sb.Append(enumerator.Current);
			}

			// Append remaining elements with leading delimiter (branchless loop)
			// This pattern is more CPU-friendly than checking index on each iteration
			while (enumerator.MoveNext())
			{
				_ = sb.Append(delimiter).Append(enumerator.Current);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Joins an enumerable collection of strings into a single string with a specified string delimiter.
	/// </summary>
	/// <param name="values">The collection of strings to join. Cannot be null.</param>
	/// <param name="delimiter">The string delimiter to insert between each string. Defaults to comma-space (", ").</param>
	/// <returns>
	/// A single string containing all values from the collection separated by the delimiter.
	/// Returns an empty string if the collection is empty.
	/// </returns>
	/// <remarks>
	/// This method uses a pooled <see cref="StringBuilder"/> for optimal performance and reduced allocations.
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(n) where n is the number of strings in the collection</description></item>
	/// <item><description>Space Complexity: O(m) where m is the total length of all strings plus delimiters</description></item>
	/// <item><description>Allocations: 1 (final string only, StringBuilder is pooled and enumerator may be struct-based)</description></item>
	/// <item><description>Branchless append pattern eliminates (n-1) conditional checks</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Implementation Details:</strong>
	/// This overload accepts multi-character string delimiters, making it suitable for complex separators
	/// like ", " (comma-space), " | " (pipe with spaces), or custom separators like " :: ".
	/// The method uses an explicit enumerator pattern to avoid LINQ overhead and enable the compiler/JIT to optimize
	/// for value-type enumerators (e.g., List&lt;T&gt;.Enumerator, array enumerators) which eliminates boxing allocations.
	/// The first element is appended without a delimiter, then subsequent elements are prepended with the delimiter,
	/// creating a branchless loop that's CPU cache-friendly and branch-predictor optimized.
	/// </para>
	/// <para>
	/// <strong>Note:</strong> This method does NOT pre-calculate StringBuilder capacity because:
	/// <list type="number">
	/// <item><description>IEnumerable&lt;T&gt; doesn't provide count without enumeration</description></item>
	/// <item><description>Many IEnumerable implementations (LINQ queries, generators) can't provide count efficiently</description></item>
	/// <item><description>Double enumeration would negate performance benefits</description></item>
	/// <item><description>StringBuilder's default capacity (16) and growth strategy handle most common cases efficiently</description></item>
	/// </list>
	/// For collections with known counts and when using single-character delimiters, the char delimiter overload
	/// may offer slightly better performance due to reduced string allocations during append operations.
	/// </para>
	/// </remarks>
	/// <example>
	/// This example demonstrates joining strings with different string delimiters:
	/// <code>
	/// // Join with default comma-space delimiter
	/// var fruits = new[] { "Apple", "Banana", "Cherry" };
	/// string result = FastStringBuilder.Join(fruits);
	/// // Output: "Apple, Banana, Cherry"
	/// 
	/// // Join with custom multi-character delimiter
	/// string pipeSeparated = FastStringBuilder.Join(fruits, " | ");
	/// // Output: "Apple | Banana | Cherry"
	/// 
	/// // Join with arrow delimiter
	/// string arrows = FastStringBuilder.Join(fruits, " -> ");
	/// // Output: "Apple -> Banana -> Cherry"
	/// 
	/// // Join LINQ query (no double enumeration)
	/// var numbers = Enumerable.Range(1, 5).Select(n => $"Item{n}");
	/// string joined = FastStringBuilder.Join(numbers, " :: ");
	/// // Output: "Item1 :: Item2 :: Item3 :: Item4 :: Item5"
	/// 
	/// // Empty collection returns empty string
	/// var empty = Array.Empty&lt;string&gt;();
	/// string emptyResult = FastStringBuilder.Join(empty, ", ");
	/// // Output: ""
	/// 
	/// // Single element (no delimiter appended)
	/// var single = new[] { "OnlyOne" };
	/// string singleResult = FastStringBuilder.Join(single, ", ");
	/// // Output: "OnlyOne"
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Join), "David McCarter", "03/04/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string Join([DisallowNull] IEnumerable<string> values, [ConstantExpected] in string delimiter = ControlChars.CommaSpace)
	{
		values = values.ArgumentNotNull();

		var sb = _stringBuilderPool.Get();

		try
		{
			// Use explicit enumerator to enable value-type optimization for common collections
			// (List<T>.Enumerator, Array enumerator, etc. are value types - no boxing)
			using var enumerator = values.GetEnumerator();

			// Append first element without delimiter (branchless pattern start)
			if (enumerator.MoveNext())
			{
				_ = sb.Append(enumerator.Current);
			}

			// Append remaining elements with leading delimiter (branchless loop)
			// This pattern is more CPU-friendly than checking index on each iteration
			while (enumerator.MoveNext())
			{
				_ = sb.Append(delimiter).Append(enumerator.Current);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Performs the specified action on a <see cref="StringBuilder"/> instance obtained from an object pool.
	/// This approach improves performance by reducing memory allocations.
	/// </summary>
	/// <param name="action">The action to perform on the <see cref="StringBuilder"/>. Must not be null.</param>
	/// <returns>A string resulting from the action performed on the <see cref="StringBuilder"/>.</returns>
	/// <example>
	/// Here is an example of using PerformAction method:
	/// <code>
	/// var result = FastStringBuilder.PerformAction(sb => 
	/// {
	///     sb.Append("Hello, ");
	///     sb.Append("world!");
	/// });
	/// Console.WriteLine(result); // Output: Hello, world!
	/// </code>
	/// </example>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PerformAction), "David McCarter", "12/23/2022", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string PerformAction([AllowNull] in Action<StringBuilder> action)
	{
		if (action is null)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			action.Invoke(sb);

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}

	}

	/// <summary>
	/// Performs the specified action on a <see cref="StringBuilder"/> instance obtained from an object pool,
	/// with a pre-allocated capacity to minimize memory reallocations.
	/// This approach improves performance by reducing memory allocations.
	/// </summary>
	/// <param name="capacity">The initial capacity to set for the StringBuilder. Must be greater than or equal to zero.</param>
	/// <param name="action">The action to perform on the <see cref="StringBuilder"/>. Must not be null.</param>
	/// <returns>A string resulting from the action performed on the <see cref="StringBuilder"/>.</returns>
	/// <example>
	/// Here is an example of using PerformAction method with capacity:
	/// <code>
	/// // Building a string from an array of 100 strings, each 15 chars
	/// var result = FastStringBuilder.PerformAction(1500, sb => 
	/// {
	///     foreach (var word in words)
	///     {
	///         sb.Append(word);
	///     }
	/// });
	/// </code>
	/// </example>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PerformAction), "David McCarter", "11/26/2025", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.New)]
	public static string PerformAction(in int capacity, [AllowNull] in Action<StringBuilder> action)
	{
		//TODO: WORK ON PERF. SLOWER WHEN APPENDING WITH STRING BUILDER USING OBJECTPOOL.

		if (action is null)
		{
			return ControlChars.EmptyString;
		}

		_ = capacity.CheckIsInRange(0, int.MaxValue - 100, throwException: true);

		var sb = _stringBuilderPool.Get().SetCapacity(capacity);

		try
		{
			action.Invoke(sb);
			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Removes all occurrences of a specified string from the input string using a StringBuilder from an ObjectPool.
	/// </summary>
	/// <param name="input">The input string to remove the specified string from.</param>
	/// <param name="toRemove">The string to remove from the input string.</param>
	/// <returns>A new string with all occurrences of the specified string removed.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Remove), "David McCarter", "03/05/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string Remove([AllowNull] string input, [AllowNull] string toRemove)
	{
		if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(toRemove))
		{
			return input ?? ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			var startIndex = 0;
			int index;

			while ((index = input.IndexOf(toRemove, startIndex, StringComparison.Ordinal)) != -1)
			{
				_ = sb.Append(input, startIndex, index - startIndex);
				startIndex = index + toRemove.Length;
			}

			if (startIndex < input.Length)
			{
				_ = sb.Append(input, startIndex, input.Length - startIndex);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Converts a dictionary to a delimited string representation, efficiently serializing key-value pairs.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary. Must be non-nullable.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary. May be nullable.</typeparam>
	/// <param name="collection">The dictionary to convert. Cannot be null.</param>
	/// <param name="delimiter">The character delimiter to separate key-value pairs. Defaults to comma.</param>
	/// <returns>
	/// A delimited string where each key-value pair is formatted as "key:value" and separated by the specified delimiter.
	/// Returns an empty string if the dictionary is empty.
	/// </returns>
	/// <remarks>
	/// This method uses a pooled <see cref="StringBuilder"/> for optimal performance and reduced allocations.
	/// The capacity is pre-calculated to minimize internal buffer reallocations during string building.
	/// <para>
	/// <strong>Capacity Estimation:</strong> The method estimates 22 characters per key-value pair, which accounts for:
	/// <list type="bullet">
	/// <item><description>Average key length: ~8 characters</description></item>
	/// <item><description>Colon separator: 1 character</description></item>
	/// <item><description>Average value length: ~8 characters</description></item>
	/// <item><description>Delimiter: 1 character</description></item>
	/// <item><description>Buffer for ToString() overhead: ~4 characters</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Performance Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Time Complexity: O(n) where n is the number of dictionary entries</description></item>
	/// <item><description>Space Complexity: O(m) where m is the total string length of all keys and values</description></item>
	/// <item><description>Zero additional allocations after StringBuilder acquisition from pool</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// This example demonstrates converting a dictionary to a delimited string:
	/// <code>
	/// var dict = new Dictionary&lt;string, int&gt;
	/// {
	///     ["Apple"] = 5,
	///     ["Banana"] = 3,
	///     ["Cherry"] = 8
	/// };
	/// 
	/// string result = FastStringBuilder.ToDelimitedString(dict);
	/// // Output: "Apple:5,Banana:3,Cherry:8"
	/// 
	/// string pipeSeparated = FastStringBuilder.ToDelimitedString(dict, '|');
	/// // Output: "Apple:5|Banana:3|Cherry:8"
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="collection"/> is null.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToDelimitedString), "David McCarter", "1/1/2021", Status = Status.Updated, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
	public static string ToDelimitedString<TKey, TValue>([DisallowNull] Dictionary<TKey, TValue> collection, [ConstantExpected] char delimiter = ControlChars.Comma) where TKey : notnull
	{
		if ((collection is null) || (collection.Count == 0))
		{
			return ControlChars.EmptyString;
		}

		// Estimate: ~22 chars per entry (avg key + ':' + avg value + delimiter + ToString overhead)
		var sb = _stringBuilderPool.Get().SetCapacity(collection.Count * 22);

		try
		{
			var isFirst = true;

			// Use foreach with KeyValuePair<TKey, TValue> - no LINQ, no explicit enumerator disposal needed
			// Dictionary<TKey, TValue>.Enumerator is a value type, so foreach doesn't box
			foreach (var item in collection)
			{
				if (isFirst)
				{
					isFirst = false;
				}
				else
				{
					_ = sb.Append(delimiter);
				}

				_ = sb.Append(item.Key).Append(ControlChars.Colon).Append(item.Value);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}
}
