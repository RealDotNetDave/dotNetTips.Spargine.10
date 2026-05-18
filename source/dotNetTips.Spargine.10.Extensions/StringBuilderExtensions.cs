// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-18-2026
// ***********************************************************************
// <copyright file="StringBuilderExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>StringBuilder Extensions.</summary>
// ***********************************************************************
using System.Buffers;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="StringBuilder"/> to enhance and simplify its functionality.
/// </summary>
/// <remarks>
/// This class includes methods for appending key-value pairs, bytes, and collections with various formatting options.
/// </remarks>
[Information(nameof(StringBuilderExtensions), "David McCarter", "5/26/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineStringBuilderExtensions")]
public static class StringBuilderExtensions
{

	/// <summary>
	/// The special characters
	/// </summary>
	private static readonly SearchValues<char> _specialCharacters = SearchValues.Create(['"', '\\']);

	/// <summary>
	/// Scans <paramref name="value"/> for special characters (double-quotes and backslashes)
	/// and appends the content to <paramref name="sb"/>, inserting a backslash escape before
	/// each occurrence.
	/// </summary>
	/// <param name="sb">The target <see cref="StringBuilder"/>.</param>
	/// <param name="value">The string to scan and append.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
#pragma warning disable IDE0051 // Remove unused private members - called from C# 14 extension block methods
	private static void AppendEscapedValue(StringBuilder sb, string value)
#pragma warning restore IDE0051
	{
		var lastSpecialIndex = 0;

		while (true)
		{
			var specialIndex = value.AsSpan(lastSpecialIndex).IndexOfAny(_specialCharacters);

			if (specialIndex >= 0)
			{
				_ = sb.Append(value, lastSpecialIndex, specialIndex)
					  .Append(ControlChars.Backslash)
					  .Append(value[lastSpecialIndex + specialIndex]);
				lastSpecialIndex += specialIndex + 1;
			}
			else
			{
				_ = sb.Append(value, lastSpecialIndex, value.Length - lastSpecialIndex);
				break;
			}
		}
	}

	/// <summary>
	/// Core loop that iterates <paramref name="values"/>, invokes <paramref name="action"/> for
	/// each element, appends <paramref name="separator"/> after each, then trims the trailing separator.
	/// </summary>
	/// <typeparam name="T">Element type.</typeparam>
	/// <param name="sb">The target <see cref="StringBuilder"/>.</param>
	/// <param name="values">The sequence of values to append.</param>
	/// <param name="separator">The separator to append between values.</param>
	/// <param name="action">The action to invoke for each value.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
#pragma warning disable IDE0051 // Remove unused private members - called from C# 14 extension block methods
	private static void AppendSeparatedValues<T>(StringBuilder sb, IEnumerable<T> values, string separator, Action<T> action)
#pragma warning restore IDE0051
	{
		var appended = false;

		foreach (var value in values)
		{
			action(value);
			_ = sb.Append(separator);
			appended = true;
		}

		if (appended)
		{
			sb.Length -= separator.Length;
		}
	}

	/// <summary>
	/// Core loop that iterates <paramref name="values"/>, invokes <paramref name="action"/> for
	/// each element together with <paramref name="param1"/> and <paramref name="param2"/>, appends
	/// <paramref name="separator"/> after each, then trims the trailing separator.
	/// </summary>
	/// <typeparam name="T">Element type.</typeparam>
	/// <typeparam name="TParam1">Type of the first additional parameter.</typeparam>
	/// <typeparam name="TParam2">Type of the second additional parameter.</typeparam>
	/// <param name="sb">The target <see cref="StringBuilder"/>.</param>
	/// <param name="values">The sequence of values to append.</param>
	/// <param name="separator">The separator to append between values.</param>
	/// <param name="param1">The first additional parameter passed to <paramref name="action"/>.</param>
	/// <param name="param2">The second additional parameter passed to <paramref name="action"/>.</param>
	/// <param name="action">The action to invoke for each value and the additional parameters.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
#pragma warning disable IDE0051 // Remove unused private members - called from C# 14 extension block methods
	private static void AppendSeparatedValues<T, TParam1, TParam2>(StringBuilder sb, IEnumerable<T> values, string separator, TParam1 param1, TParam2 param2, Action<StringBuilder, T, TParam1, TParam2> action)
#pragma warning restore IDE0051
	{
		var appended = false;

		foreach (var value in values)
		{
			action(sb, value, param1, param2);
			_ = sb.Append(separator);
			appended = true;
		}

		if (appended)
		{
			sb.Length -= separator.Length;
		}
	}

	/// <summary>
	/// Sets the separator.
	/// </summary>
	/// <param name="separator">The separator.</param>
	/// <returns>System.String.</returns>
	private static string SetSeparator(string separator)
	{
		if (separator.HasValue() is false)
		{
			separator = ControlChars.DefaultSeparator;
		}

		return separator;
	}

	/// <summary>
	/// Provides extension methods for <see cref="StringBuilder"/> instances.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> instance to extend.</param>
	extension([DisallowNull] StringBuilder sb)
	{
		/// <summary>
		/// Appends the bytes to the <see cref="StringBuilder"/> in hexadecimal format, prefixed with '0x' and enclosed in single quotes.
		/// </summary>
		/// <param name="bytes">The byte array to append. If <c>null</c>, the method returns without modifying the <see cref="StringBuilder"/>.</param>
		/// <remarks>
		/// Each byte is formatted as a two-digit uppercase hexadecimal value. The resulting string is wrapped in single quotes and prefixed with '0x'.
		/// </remarks>
		/// <example>
		/// <code>
		/// var sb = new StringBuilder();
		/// var byteArray = RandomData.GenerateByteArray(5);
		/// sb.AppendBytes(byteArray);
		/// // Output: '0xA1B2C3D4E5'
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AppendBytes), author: "David McCarter", createdOn: "5/26/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
		public void AppendBytes(byte[] bytes)
		{
			if (bytes is null)
			{
				return;
			}

			sb = sb.ArgumentNotNull().Append("'0x");

			Span<char> hex = stackalloc char[2];

			foreach (var byteItem in bytes)
			{
				_ = byteItem.TryFormat(hex, out _, "X2", CultureInfo.InvariantCulture);
				_ = sb.Append(hex);
			}

			_ = sb.Append('\'');
		}

		/// <summary>
		/// Appends a key-value pair to the <see cref="StringBuilder"/> in a formatted string representation.
		/// </summary>
		/// <param name="key">The key name to append. Must not be <c>null</c> or empty.</param>
		/// <param name="value">The value to append. If <c>null</c>, the method returns without modifying the <see cref="StringBuilder"/>.</param>
		/// <param name="includeQuotes">
		/// If set to <c>true</c>, wraps the value in double quotation marks and escapes any special characters (double quotes and backslashes) within the value.
		/// Default is <c>true</c>.
		/// </param>
		/// <param name="includeComma">
		/// If set to <c>true</c>, appends a comma separator after the key-value pair for chaining multiple pairs.
		/// Default is <c>true</c>.
		/// </param>
		/// <exception cref="ArgumentNullException">Thrown if the <see cref="StringBuilder"/> instance or <paramref name="key"/> is <c>null</c>.</exception>
		/// <exception cref="ArgumentException">Thrown if <paramref name="key"/> is empty.</exception>
		/// <remarks>
		/// This method formats the output as <c>key=value</c> or <c>key="value"</c> depending on the <paramref name="includeQuotes"/> parameter.
		/// When <paramref name="includeQuotes"/> is <c>true</c>, special characters within the value (specifically double quotes and backslashes) are automatically
		/// escaped with a backslash prefix to ensure proper string formatting. The method efficiently handles special character escaping using
		/// <see cref="SearchValues{T}"/> for optimal performance.
		/// If <paramref name="includeComma"/> is <c>true</c>, a comma is appended after the key-value pair, making it suitable for constructing
		/// comma-separated lists of key-value pairs.
		/// </remarks>
		/// <example>
		/// <code>
		/// var sb = new StringBuilder();
		/// sb.AppendKeyValue("Name", "John", true, true);
		/// Console.WriteLine(sb.ToString()); // Output: Name="John",
		/// 
		/// var sb2 = new StringBuilder();
		/// sb2.AppendKeyValue("Path", @"C:\Files\Data", true, false);
		/// Console.WriteLine(sb2.ToString()); // Output: Path="C:\\Files\\Data"
		/// 
		/// var sb3 = new StringBuilder();
		/// sb3.AppendKeyValue("Count", "42", false, false);
		/// Console.WriteLine(sb3.ToString()); // Output: Count=42
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AppendKeyValue), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendKeyValue([DisallowNull] string key, string value, bool includeQuotes = true, bool includeComma = true)
		{
			sb = sb.ArgumentNotNull();
			key = key.ArgumentNotNullOrEmpty();

			if (value is null)
			{
				return;
			}

			// SUGGESTIONS FROM COPILOT SLOWER
			_ = sb.Append(key).Append(ControlChars.Equal);

			if (includeQuotes)
			{
				_ = sb.Append(ControlChars.Quote);
				var lastSpecialIndex = 0;
				int specialIndex;

				while (true)
				{
					specialIndex = value.AsSpan(lastSpecialIndex).IndexOfAny(_specialCharacters);

					if (specialIndex >= 0)
					{
						var absoluteIndex = lastSpecialIndex + specialIndex;

						_ = sb.Append(value, lastSpecialIndex, specialIndex).Append(ControlChars.Backslash).Append(value[absoluteIndex]);

						lastSpecialIndex = absoluteIndex + 1;
					}
					else
					{
						_ = sb.Append(value, lastSpecialIndex, value.Length - lastSpecialIndex);
						break;
					}
				}
				_ = sb.Append(ControlChars.Quote);
			}
			else
			{
				_ = sb.Append(value);
			}

			if (includeComma)
			{
				_ = sb.Append(ControlChars.DefaultSeparator);
			}
		}

		/// <summary>
		/// Appends a collection of values to the <see cref="StringBuilder"/>, separated by the specified separator, using a custom join action.
		/// </summary>
		/// <param name="separator">The separator to use between values.</param>
		/// <param name="values">The collection of values to append.</param>
		/// <remarks>
		/// If <paramref name="values"/> is null, the method returns without modifying the <see cref="StringBuilder"/>.
		/// The separator is appended after each value, and removed after the last value.
		/// </remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AppendValues), author: "David McCarter", createdOn: "7/1/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
		public void AppendValues([DisallowNull] string separator, [DisallowNull] IEnumerable<string> values)
		{
			sb = sb.ArgumentNotNull();
			values = values.ArgumentNotNull();

			separator = SetSeparator(separator);

			var appended = false;

			foreach (var value in values)
			{
				_ = sb.Append(value);
				_ = sb.Append(separator);
				appended = true;
			}

			if (appended)
			{
				sb.Length -= separator.Length;
			}
		}

		/// <summary>
		/// Appends a collection of string values to the <see cref="StringBuilder"/>, separated by the specified <paramref name="separator"/>.
		/// </summary>
		/// <param name="separator">
		/// The separator to use between values. If <c>null</c> or empty, the method will use the default separator returned by <see cref="SetSeparator(string)"/>.
		/// </param>
		/// <param name="values">A <see cref="ReadOnlyCollection{T}"/> of string values to append. The collection must not be <c>null</c>.</param>
		/// <exception cref="ArgumentNullException">
		/// Thrown when the current <see cref="StringBuilder"/> instance or the <paramref name="values"/> parameter is <c>null</c>.
		/// Parameter validation is performed via extension preconditions.
		/// </exception>
		/// <remarks>
		/// This overload adapts the provided <paramref name="values"/> collection and forwards each value to the generic
		/// AppendValues overload using an action that appends the value to the builder.
		/// The <paramref name="separator"/> is normalized by <see cref="SetSeparator(string)"/> before joining.
		/// </remarks>
		/// <example>
		/// <code>
		/// var sb = new StringBuilder();
		/// var values = new System.Collections.ObjectModel.ReadOnlyCollection&lt;string&gt;(new[] { "a", "b", "c" });
		/// sb.AppendValues(",", values);
		/// // Resulting content: "a,b,c"
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AppendValues), "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
		public void AppendValues([DisallowNull] string separator, [DisallowNull] params ReadOnlyCollection<string> values)
		{
			sb = sb.ArgumentNotNull();
			values = values.ArgumentNotNull();

			separator = SetSeparator(separator);

			var appended = false;

			foreach (var value in values)
			{
				_ = sb.Append(value);
				_ = sb.Append(separator);
				appended = true;
			}

			if (appended)
			{
				sb.Length -= separator.Length;
			}
		}

		/// <summary>
		/// Appends a collection of values to the <see cref="StringBuilder"/>, separated by the specified separator, using a custom join action.
		/// </summary>
		/// <typeparam name="T">The type of the elements in <paramref name="values"/>.</typeparam>
		/// <param name="separator">The separator to use between values.</param>
		/// <param name="values">The collection of values to append.</param>
		/// <param name="joinAction">The action to perform for each value.</param>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/> or <paramref name="joinAction"/> is null.</exception>
		/// <example>
		/// <code>
		/// var sb = new StringBuilder();
		/// var values = new[] { "value1", "value2", "value3" };
		/// sb.AppendValues(",", values, value => sb.Append(value));
		/// Console.WriteLine(sb.ToString()); // Output: value1,value2,value3
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AppendValues), "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendValues<T>([DisallowNull] string separator, IEnumerable<T> values, [DisallowNull] Action<T> joinAction)
		{
			sb = sb.ArgumentNotNull();
			joinAction = joinAction.ArgumentNotNull();

			if (values is null)
			{
				return;
			}

			// SUGGESTIONS FROM COPILOT SLOWER
			separator = SetSeparator(separator);

			var appended = false;

			//FrozenSet is slower.
			foreach (var value in values)
			{
				joinAction(value);
				_ = sb.Append(separator);
				appended = true;
			}

			if (appended)
			{
				sb.Length -= separator.Length;
			}
		}

		/// <summary>
		/// Appends a collection of values to the <see cref="StringBuilder"/>, separated by the specified separator, using a custom join action that takes an additional parameter.
		/// </summary>
		/// <typeparam name="T">The type of the elements in <paramref name="values"/>.</typeparam>
		/// <typeparam name="TParam">The type of the additional parameter.</typeparam>
		/// <param name="separator">The separator to use between values.</param>
		/// <param name="values">The collection of values to append.</param>
		/// <param name="param">The additional parameter to pass to the join action.</param>
		/// <param name="joinAction">The action to perform for each value and the additional parameter.</param>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/>, <paramref name="param"/>, or <paramref name="joinAction"/> is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AppendValues), "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendValues<T, TParam>([DisallowNull] string separator, IEnumerable<T> values, [DisallowNull] TParam param, [DisallowNull] Action<T, TParam> joinAction)
		{
			sb = sb.ArgumentNotNull();
			joinAction = joinAction.ArgumentNotNull();
			param = param.ArgumentNotNull();

			if (values is null)
			{
				return;
			}

			// SUGGESTIONS FROM COPILOT SLOWER
			separator = SetSeparator(separator);

			var appended = false;

			//Frozenset is slower.
			foreach (var value in values)
			{
				joinAction(value, param);
				_ = sb.Append(separator);
				appended = true;
			}

			if (appended)
			{
				sb.Length -= separator.Length;
			}
		}

		/// <summary>
		/// Appends a collection of values to the <see cref="StringBuilder"/>, separated by the specified separator, using a custom join action that takes two additional parameters.
		/// </summary>
		/// <typeparam name="T">The type of the elements in <paramref name="values"/>.</typeparam>
		/// <typeparam name="TParam1">The type of the first additional parameter.</typeparam>
		/// <typeparam name="TParam2">The type of the second additional parameter.</typeparam>
		/// <param name="separator">The separator to use between values.</param>
		/// <param name="values">The collection of values to append.</param>
		/// <param name="param1">The first additional parameter to pass to the join action.</param>
		/// <param name="param2">The second additional parameter to pass to the join action.</param>
		/// <param name="joinAction">The action to perform for each value and the additional parameters.</param>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="sb"/>, <paramref name="param1"/>, <paramref name="param2"/>, or <paramref name="joinAction"/> is null.</exception>
		/// <example>
		/// <code>
		/// var sb = new StringBuilder();
		/// var values = new[] { "value1", "value2", "value3" };
		/// sb.AppendValues(",", values, "param1", "param2", (sb, value, param1, param2) => sb.Append(value).Append(param1).Append(param2));
		/// Console.WriteLine(sb.ToString()); // Output: value1param1param2,value2param1param2,value3param1param2
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AppendValues), "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendValues<T, TParam1, TParam2>([DisallowNull] string separator, IEnumerable<T> values, [DisallowNull] TParam1 param1, [DisallowNull] TParam2 param2, [DisallowNull] Action<StringBuilder, T, TParam1, TParam2> joinAction)
		{
			sb = sb.ArgumentNotNull();
			param1 = param1.ArgumentNotNull();
			param2 = param2.ArgumentNotNull();
			joinAction = joinAction.ArgumentNotNull();

			if (values is null)
			{
				return;
			}

			separator = SetSeparator(separator);

			var appended = false;

			//FrozenSet is slower.
			foreach (var value in values)
			{
				joinAction(sb, value, param1, param2);
				_ = sb.Append(separator);
				appended = true;
			}

			if (appended)
			{
				sb.Length -= separator.Length;
			}
		}

		/// <summary>
		/// Clears the <see cref="StringBuilder"/> and sets its capacity to the specified value.
		/// </summary>
		/// <param name="capacity">The new capacity to set for the <see cref="StringBuilder"/>. Must be greater than or equal to zero.</param>
		/// <returns>The same <see cref="StringBuilder"/> instance after clearing its content and setting the new capacity, allowing for method chaining.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the <see cref="StringBuilder"/> instance is <c>null</c>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="capacity"/> is less than zero or less than the current length after clearing.</exception>
		/// <remarks>
		/// This method first clears all content from the <see cref="StringBuilder"/>, then sets its capacity to the specified value.
		/// Setting the capacity can help optimize memory usage when you know the approximate size of the content you'll be building.
		/// The method returns the same <see cref="StringBuilder"/> instance, enabling fluent-style method chaining.
		/// </remarks>
		/// <example>
		/// <code>
		/// var sb = new StringBuilder("Initial content");
		/// sb.ClearSetCapacity(100);
		/// // StringBuilder is now empty with capacity set to 100
		/// sb.Append("New content");
		/// Console.WriteLine(sb.ToString()); // Output: "New content"
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ClearSetCapacity), author: "David McCarter", createdOn: "11/13/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
		public StringBuilder ClearSetCapacity(in int capacity)
		{
			sb = sb.ArgumentNotNull();

			_ = sb.Clear().EnsureCapacity(capacity);

			return sb;
		}

		/// <summary>
		/// Sets the capacity of the <see cref="StringBuilder"/> to the specified value.
		/// </summary>
		/// <param name="capacity">The new capacity to set for the <see cref="StringBuilder"/>. Must be greater than or equal to the current <see cref="StringBuilder.Length"/> and less than or equal to <see cref="StringBuilder.MaxCapacity"/>.</param>
		/// <returns>The same <see cref="StringBuilder"/> instance after setting the new capacity, allowing for method chaining.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the <see cref="StringBuilder"/> instance is <c>null</c>.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="capacity"/> is less than the current length or greater than the maximum capacity.</exception>
		/// <remarks>
		/// This method sets the <see cref="StringBuilder.Capacity"/> property directly without clearing the existing content.
		/// Unlike <see cref="ClearSetCapacity"/>, this method preserves the current string content in the <see cref="StringBuilder"/>.
		/// Setting the capacity can help optimize memory usage when you know the approximate size of additional content to be appended.
		/// The method returns the same <see cref="StringBuilder"/> instance, enabling fluent-style method chaining.
		/// For best performance, set the capacity before performing multiple append operations to minimize memory reallocations.
		/// </remarks>
		/// <example>
		/// <code>
		/// var sb = new StringBuilder("Hello");
		/// sb.SetCapacity(100).Append(" World");
		/// // StringBuilder now has "Hello World" with capacity set to 100
		/// Console.WriteLine(sb.ToString()); // Output: "Hello World"
		/// Console.WriteLine(sb.Capacity);   // Output: 100
		/// </code>
		/// </example>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(SetCapacity), author: "David McCarter", createdOn: "11/26/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
		public StringBuilder SetCapacity(in int capacity)
		{
			sb = sb.ArgumentNotNull();

			_ = sb.EnsureCapacity(capacity);

			return sb;
		}

	}
}
