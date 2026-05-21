// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : Copilot Agent
// Created          : 05-21-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="ListExtensionsHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Internal helpers for ListExtensions: AddUniqueItems, ComputeWrappedIndex,
// EitherIsNull, ReferenceOrCountMismatch.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Internal helper methods for <see cref="ListExtensions"/>.
/// </summary>
internal static class ListExtensionsHelper
{
	/// <summary>
	/// Iterates <paramref name="items"/> and appends each element to <paramref name="list"/> only if it
	/// is not already tracked by <paramref name="existingSet"/> (which is updated in-place).
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="list">The destination list.</param>
	/// <param name="items">The candidate items to add.</param>
	/// <param name="existingSet">A <see cref="HashSet{T}"/> pre-populated from the current list contents.</param>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="list"/>, <paramref name="items"/>, or <paramref name="existingSet"/> is <see langword="null"/>.
	/// </exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void AddUniqueItems<T>(List<T> list, IEnumerable<T> items, HashSet<T> existingSet)
	{
		list = list.ArgumentNotNull();
		items = items.ArgumentNotNull();
		existingSet = existingSet.ArgumentNotNull();

		foreach (var item in items)
		{
			if (existingSet.Add(item))
			{
				list.Add(item);
			}
		}
	}

	/// <summary>
	/// Computes the wrapped (looped) index for the given <paramref name="index"/> within a list of
	/// <paramref name="count"/> elements. Supports both positive out-of-range and negative indices.
	/// </summary>
	/// <param name="index">The raw index, which may be negative or exceed <paramref name="count"/>.</param>
	/// <param name="count">The number of elements in the list. Must be greater than zero.</param>
	/// <returns>A non-negative index in the range <c>[0, count)</c>.</returns>
	/// <remarks>Callers must ensure <paramref name="count"/> is greater than zero before invoking this helper.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int ComputeWrappedIndex(int index, int count)
	{
		if ((count & (count - 1)) == 0)
		{
			// Power-of-two fast path: bit-mask for wrapping
			var mask = count - 1;
			var wrap = index & mask;
			return index < 0 ? (count + (index % count)) & mask : wrap;
		}

		var indexWrap = index % count;
		return indexWrap + ((indexWrap >> 31) & count);
	}

	/// <summary>
	/// Returns <see langword="true"/> if either <paramref name="a"/> or <paramref name="b"/> is
	/// <see langword="null"/>.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="a">The first list.</param>
	/// <param name="b">The second list.</param>
	/// <returns>
	/// <see langword="true"/> if <paramref name="a"/> or <paramref name="b"/> is <see langword="null"/>;
	/// otherwise, <see langword="false"/>.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool EitherIsNull<T>([NotNullWhen(false)] List<T>? a, [NotNullWhen(false)] List<T>? b) => a is null || b is null;

	/// <summary>
	/// Checks whether two non-null lists are reference-equal or have differing counts.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="a">The first list.</param>
	/// <param name="b">The second list.</param>
	/// <param name="sameRef">
	/// Set to <see langword="true"/> when the lists are the same instance; otherwise <see langword="false"/>.
	/// </param>
	/// <returns>
	/// <see langword="true"/> when the caller should short-circuit (identical reference or unequal count);
	/// <see langword="false"/> when element-by-element comparison should proceed.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool ReferenceOrCountMismatch<T>(List<T> a, List<T> b, out bool sameRef)
	{
		sameRef = ReferenceEquals(a, b);
		if (sameRef)
		{
			return true;
		}

		if (a.Count != b.Count)
		{
			return true;
		}

		return false;
	}
}
