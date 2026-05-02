// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 12-27-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-02-2026
// ***********************************************************************
// <copyright file="FastStringBuilder.cs" company="dotNetTips.com - McCarter Consulting">
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

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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
	/// Converts an array of bytes into a hexadecimal string representation, making it easy to inspect raw byte data in string form.
	/// </summary>
	/// <param name="bytes">The byte array to convert.</param>
	/// <returns>An uppercase hexadecimal string representation of the byte array.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToString), author: "David McCarter", createdOn: "3/7/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string BytesToString([DisallowNull] ref readonly byte[] bytes)
	{
		if (bytes is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(bytes));
		}

		return bytes.Length == 0 ? ControlChars.EmptyString : Convert.ToHexString(bytes);
	}

	/// <summary>
	/// Converts a <see cref="ReadOnlySpan{T}"/> of bytes into a hexadecimal string representation, making it easy to inspect raw byte data in string form.
	/// </summary>
	/// <param name="bytes">The <see cref="ReadOnlySpan{T}"/> of bytes to convert.</param>
	/// <returns>An uppercase hexadecimal string representation of the bytes.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BytesToString), author: "David McCarter", createdOn: "2/18/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string BytesToString([AllowNull] in ReadOnlySpan<byte> bytes)
	{
		return bytes.IsEmpty ? ControlChars.EmptyString : Convert.ToHexString(bytes);
	}

	/// <summary>
	/// Combines strings into a single string, optionally appending a platform-specific line terminator after each item.
	/// </summary>
	/// <param name="addLineFeed">
	/// If <c>true</c>, appends <see cref="Environment.NewLine"/> after each string; otherwise, concatenates directly.
	/// </param>
	/// <param name="args">The strings to combine. Must not be <c>null</c>. Empty span returns <see cref="ControlChars.EmptyString"/>.</param>
	/// <returns>
	/// A combined string of all items in <paramref name="args"/>. Returns <see cref="ControlChars.EmptyString"/> if there are no items.
	/// </returns>
	/// <remarks>
	/// Uses a pooled <see cref="StringBuilder"/> and pre-estimates capacity to minimize reallocations.
	/// Accepts <see cref="ReadOnlySpan{T}"/> to avoid params array allocations.
	/// </remarks>
	/// <example>
	/// <code>
	/// // Concatenate without line feeds
	/// var result = FastStringBuilder.Combine(false, ["Hello", "World", "!"]);
	/// // "HelloWorld!"
	/// 
	/// // Concatenate with line feeds
	/// var lines = FastStringBuilder.Combine(true, ["Line1", "Line2"]);
	/// // Windows: "Line1\r\nLine2\r\n"  |  Unix: "Line1\nLine2\n"
	/// 
	/// // Empty input
	/// var empty = FastStringBuilder.Combine(false, ReadOnlySpan&lt;string&gt;.Empty);
	/// // ""
	/// </code>
	/// </example>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Combine), "David McCarter", "12/23/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string Combine(in bool addLineFeed = false, [DisallowNull] params ReadOnlySpan<string> args)
	{
		if (args.Length == 0)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().SetCapacity(EstimateParamsStringLength(args));

		try
		{
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
	[Information(nameof(CombineWithSpace), "David McCarter", "3/6/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string CombineWithSpace([DisallowNull] params ReadOnlySpan<string> args)
	{
		if (args.Length == 0)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().SetCapacity(EstimateParamsStringLength(args));

		try
		{
			_ = sb.Append(args[0]);

			for (var index = 1; index < args.Length; index++)
			{
				_ = sb.Append(ControlChars.Space).Append(args[index]);
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
	[Information(nameof(Concat), "David McCarter", "2/19/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Concat([ConstantExpected] char delimiter = ControlChars.Comma, in bool addLineFeed = false, [DisallowNull] params ReadOnlySpan<string> args)
	{
		if (args.IsEmpty)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			var itemCount = args.Length;

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
	[Information(nameof(Concat), "David McCarter", "2/19/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
		if (format.CheckIsNotNull() is false || args.CheckItemsExists() is false)
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().SetCapacity(args.CalculateStringCount());

		try
		{
			return sb.AppendFormat(CultureInfo.InvariantCulture, format, args).ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Joins a sequence of strings into a single string using a single-character delimiter.
	/// </summary>
	/// <param name="values">The strings to join. Must not be <c>null</c>.</param>
	/// <param name="delimiter">The delimiter character inserted between items. Defaults to <see cref="ControlChars.Comma"/>.</param>
	/// <returns>
	/// A single string containing all elements of <paramref name="values"/> separated by <paramref name="delimiter"/>.
	/// Returns <see cref="ControlChars.EmptyString"/> if <paramref name="values"/> is empty.
	/// </returns>
	/// <remarks>
	/// Uses a pooled <see cref="StringBuilder"/> and an explicit enumerator with a branchless append pattern:
	/// first element without a delimiter, remaining elements prefixed with the delimiter. Minimizes allocations and
	/// benefits value-type enumerators (arrays, lists).
	/// </remarks>
	/// <example>
	/// <code>
	/// var items = new[] { "A", "B", "C" };
	/// var joined = FastStringBuilder.Join(items, ';'); // "A;B;C"
	/// 
	/// var empty = Array.Empty&lt;string&gt;();
	/// var result = FastStringBuilder.Join(empty); // ""
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
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
	/// Joins an enumerable collection of strings into a single string using a multi-character string delimiter.
	/// </summary>
	/// <param name="values">The collection of strings to join. Must not be <c>null</c>.</param>
	/// <param name="delimiter">The string delimiter to insert between items. Defaults to <see cref="ControlChars.CommaSpace"/>.</param>
	/// <returns>
	/// A single string containing all elements of <paramref name="values"/> separated by <paramref name="delimiter"/>.
	/// Returns <see cref="ControlChars.EmptyString"/> if the collection is empty.
	/// </returns>
	/// <remarks>
	/// Uses a pooled <see cref="StringBuilder"/> and an explicit enumerator with a branchless append pattern:
	/// first element without a delimiter, remaining elements prefixed with the delimiter. Avoids LINQ allocations.
	/// </remarks>
	/// <example>
	/// <code>
	/// var items = new[] { "A", "B", "C" };
	/// var joined = FastStringBuilder.Join(items, " | "); // "A | B | C"
	/// 
	/// var empty = Array.Empty&lt;string&gt;();
	/// var result = FastStringBuilder.Join(empty); // ""
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="values"/> is <c>null</c>.</exception>
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
			action(sb);

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
	[Information(nameof(PerformAction), "David McCarter", "11/26/2025", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string PerformAction(in int capacity, [AllowNull] in Action<StringBuilder> action)
	{
		if (action is null)
		{
			return ControlChars.EmptyString;
		}

		_ = capacity.CheckIsInRange(0, int.MaxValue - 100, throwException: true);

		var sb = _stringBuilderPool.Get().SetCapacity(capacity);

		try
		{
			action(sb);
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
	/// Converts a dictionary to a delimited string of <c>key:value</c> pairs separated by <paramref name="delimiter"/>.
	/// </summary>
	/// <typeparam name="TKey">The key type (non-nullable).</typeparam>
	/// <typeparam name="TValue">The value type (nullable allowed).</typeparam>
	/// <param name="collection">The dictionary to serialize. Must not be <c>null</c>.</param>
	/// <param name="delimiter">The delimiter character between pairs. Defaults to <see cref="ControlChars.Comma"/>.</param>
	/// <returns>
	/// A single string containing each entry formatted as <c>key:value</c>, separated by <paramref name="delimiter"/>.
	/// Returns <see cref="ControlChars.EmptyString"/> when <paramref name="collection"/> is <c>null</c> or empty.
	/// </returns>
	/// <remarks>
	/// Uses a pooled <see cref="StringBuilder"/> with pre-sized capacity to reduce allocations. Capacity is estimated as
	/// <c>collection.Count * 22</c> for typical key/value sizes. Pairs are emitted in enumeration order.
	/// </remarks>
	/// <example>
	/// <code>
	/// var dict = new Dictionary&lt;string, int&gt;
	/// {
	///     ["Apple"] = 5,
	///     ["Banana"] = 3,
	///     ["Cherry"] = 8
	/// };
	/// 
	/// string csv = FastStringBuilder.ToDelimitedString(dict);        // "Apple:5,Banana:3,Cherry:8"
	/// string pipe = FastStringBuilder.ToDelimitedString(dict, '|');  // "Apple:5|Banana:3|Cherry:8"
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Not thrown; method returns empty string if <paramref name="collection"/> is <c>null</c>.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToDelimitedString), "David McCarter", "1/1/2021", Status = Status.Available, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
	public static string ToDelimitedString<TKey, TValue>([DisallowNull] Dictionary<TKey, TValue> collection, [ConstantExpected] char delimiter = ControlChars.Comma) where TKey : notnull
	{
		if ((collection is null) || (collection.Count == 0))
		{
			return ControlChars.EmptyString;
		}

		var sb = _stringBuilderPool.Get().SetCapacity(collection.Count * 22);

		try
		{
			var isFirst = true;

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

		foreach (var arg in args)
		{
			// Handle null strings as zero length to avoid NullReferenceException
			estimatedCapacity += arg?.Length ?? 0;
		}

		// Add separator characters: (n-1) separators for n strings
		estimatedCapacity += length - 1;

		return estimatedCapacity;
	}
}
