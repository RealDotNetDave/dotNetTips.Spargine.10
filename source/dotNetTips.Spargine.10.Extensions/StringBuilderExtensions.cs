// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-19-2025
// ***********************************************************************
// <copyright file="StringBuilderExtensions.cs" company="McCarter Consulting">
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
[Information(nameof(StringBuilderExtensions), "David McCarter", "5/26/2020", "7/29/2020", Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineStringBuilderExtensions")]
public static class StringBuilderExtensions
{

	/// <summary>
	/// The special characters
	/// </summary>
	private static readonly SearchValues<char> _specialCharacters = SearchValues.Create(['"', '\\']);

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
		[Information(nameof(AppendBytes), author: "David McCarter", createdOn: "5/26/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendBytes(byte[] bytes)
		{
			if (bytes is null)
			{
				return;
			}

			sb = sb.ArgumentNotNull().Append("'0x");

			//FrozenSet and Span is slower.
			foreach (var byteItem in bytes)
			{
				_ = sb.Append(byteItem.ToString("X2", CultureInfo.InvariantCulture));
			}

			_ = sb.Append('\'');
		}

		/// <summary>
		/// Appends the key-value pair to the <see cref="StringBuilder"/>.
		/// </summary>
		/// <param name="key">The key to append.</param>
		/// <param name="value">The value to append.</param>
		/// <param name="includeQuotes">If set to <c>true</c>, includes quotes around the value.</param>
		/// <param name="includeComma">If set to <c>true</c>, includes a comma after the key-value pair.</param>
		/// <exception cref="ArgumentNullException">Thrown if StringBuilder or <paramref name="key"/> is null.</exception>
		/// <exception cref="ArgumentException">Thrown if <paramref name="key"/> is empty.</exception>
		/// <example>
		/// <code>
		/// var sb = new StringBuilder();
		/// sb.AppendKeyValue("Name", "John", true, true);
		/// Console.WriteLine(sb.ToString()); // Output: Name="John",
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AppendValues), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
		public void AppendKeyValue([DisallowNull] string key, string value, bool includeQuotes = true, bool includeComma = true)
		{
			sb = sb.ArgumentNotNull();
			key = key.ArgumentNotNullOrEmpty();

			if (value is null)
			{
				return;
			}

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
						_ = sb.Append(value, lastSpecialIndex, specialIndex - lastSpecialIndex).Append(ControlChars.Backslash).Append(value[specialIndex]);
						lastSpecialIndex = specialIndex + 1;
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
		[Information(nameof(AppendValues), author: "David McCarter", createdOn: "7/1/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendValues([DisallowNull] string separator, [DisallowNull] IEnumerable<string> values)
		{
			sb = sb.ArgumentNotNull();
			values = values.ArgumentNotNull();
			separator ??= string.Empty;

			separator = SetSeparator(separator);

			sb.AppendValues(separator, values, (value) => sb.Append(value));
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
		[Information(nameof(AppendValues), "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendValues([DisallowNull] string separator, [DisallowNull] params ReadOnlyCollection<string> values)
		{
			sb = sb.ArgumentNotNull();
			values = values.ArgumentNotNull();
			separator ??= string.Empty;

			separator = SetSeparator(separator);

			sb.AppendValues(separator, values, (value) => sb.Append(value));
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
		[Information(nameof(AppendValues), "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendValues<T>([DisallowNull] string separator, IEnumerable<T> values, [DisallowNull] Action<T> joinAction)
		{
			sb = sb.ArgumentNotNull();
			joinAction = joinAction.ArgumentNotNull();
			separator ??= string.Empty;

			if (values is null)
			{
				return;
			}

			separator = SetSeparator(separator);

			var appended = false;

			//FrozenSet is slower.
			foreach (var value in values)
			{
				joinAction.Invoke(value);
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
		[Information(nameof(AppendValues), "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendValues<T, TParam>([DisallowNull] string separator, IEnumerable<T> values, [DisallowNull] TParam param, [DisallowNull] Action<T, TParam> joinAction)
		{
			sb = sb.ArgumentNotNull();
			joinAction = joinAction.ArgumentNotNull();
			param = param.ArgumentNotNull();
			separator ??= string.Empty;

			if (values is null)
			{
				return;
			}

			separator = SetSeparator(separator);

			var appended = false;

			//Frozenset is slower.
			foreach (var value in values)
			{
				joinAction.Invoke(value, param);
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
		[Information(nameof(AppendValues), "David McCarter", "5/26/2020", "7/29/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AppendValues<T, TParam1, TParam2>([DisallowNull] string separator, IEnumerable<T> values, [DisallowNull] TParam1 param1, [DisallowNull] TParam2 param2, [DisallowNull] Action<StringBuilder, T, TParam1, TParam2> joinAction)
		{
			sb = sb.ArgumentNotNull();
			param1 = param1.ArgumentNotNull();
			param2 = param2.ArgumentNotNull();
			joinAction = joinAction.ArgumentNotNull();
			separator ??= string.Empty;

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
		[Information(nameof(SetCapacity), author: "David McCarter", createdOn: "11/26/2025", UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
		public StringBuilder SetCapacity(in int capacity)
		{
			sb = sb.ArgumentNotNull();

			_ = sb.EnsureCapacity(capacity);
			return sb;
		}

	}
}
