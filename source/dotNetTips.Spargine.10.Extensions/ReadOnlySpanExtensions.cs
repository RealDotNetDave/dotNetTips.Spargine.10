// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="ReadOnlySpanExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <c>ReadOnlySpan{T}</c> providing byte-array-to-string conversion
// (<c>BytesToString</c>) and random element selection (<c>PickRandom</c>).
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <c>ReadOnlySpan{T}</c> covering byte-to-string conversion
/// and random element selection.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class ReadOnlySpanExtensions
{
	/// <summary>
	/// Converts a <c>ReadOnlySpan{byte}</c> to its hexadecimal string representation
	/// using a pooled <c>StringBuilder</c> for improved performance.
	/// </summary>
	/// <param name="array">The byte span to convert. Must not be empty.</param>
	/// <returns>A hexadecimal <c>string</c> representation of <paramref name="array"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="array"/> is empty.</exception>
	[Pure]
	[Information(nameof(BytesToString), "David McCarter", "6/24/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string BytesToString([DisallowNull] this ReadOnlySpan<byte> array)
	{
		return FastStringBuilder.BytesToString(array);
	}

	/// <summary>
	/// Picks a random item from the specified <c>ReadOnlySpan{T}</c>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the span.</typeparam>
	/// <param name="span">The span from which to pick a random item. Must not be empty.</param>
	/// <returns>A randomly selected item of type <typeparamref name="T"/> from <paramref name="span"/>.</returns>
	/// <exception cref="ArgumentException">Thrown when <paramref name="span"/> is empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNull]
	[Information(nameof(PickRandom), "David McCarter", "6/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static T PickRandom<T>([DisallowNull] this ReadOnlySpan<T> span)
	{
		span = span.ArgumentNotEmpty();

		return span[RandomNumberGenerator.GetInt32(0, span.Length)]!;
	}

}
