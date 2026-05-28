// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : Copilot Agent
// Created          : 05-21-2026
//
// Last Modified By : David McCarter
// Last Modified On : 05-27-2026
// ***********************************************************************
// <copyright file="CollectionExtensionsHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Internal helpers for CollectionExtensions: ThrowIfArray, FindItemById, ResolveComparer,
// AddAllItemsToCollection, AddUniqueItemsToCollection, TryAddIfUnique,
// RemoveItemById, DispatchUpsert, UpsertIntoList.
// </summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Internal helper methods for <see cref="CollectionExtensions"/>.
/// </summary>
internal static class CollectionExtensionsHelper
{

	/// <summary>
	/// Adds all items in <paramref name="src"/> to <paramref name="col"/> without checking for duplicates.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="col">The target collection.</param>
	/// <param name="src">The source sequence to add.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool AddAllItemsToCollection<T>(ICollection<T> col, IEnumerable<T> src)
	{
		var added = false;

		foreach (var item in src)
		{
			col.Add(item);
			added = true;
		}
		return added;
	}

	/// <summary>
	/// Adds only items from <paramref name="src"/> that are not already present in <paramref name="col"/>.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="col">The target collection.</param>
	/// <param name="src">The source sequence.</param>
	/// <param name="comparer">The equality comparer to use; must not be <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if at least one item was added; otherwise <see langword="false"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool AddUniqueItemsToCollection<T>(ICollection<T> col, IEnumerable<T> src, IEqualityComparer<T> comparer)
	{
		if (col is HashSet<T> existingSet)
		{
			var added = false;
			foreach (var item in src)
			{
				if (existingSet.Add(item))
				{ added = true; }
			}
			return added;
		}

		var added2 = false;
		var seen = new HashSet<T>(col, comparer);   // only for non-HashSet collections

		foreach (var item in src)
		{
			if (seen.Add(item))
			{
				col.Add(item);
				added2 = true;
			}
		}
		return added2;
	}

	/// <summary>
	/// Dispatches an upsert operation to the appropriate fast path for <see cref="List{T}"/> and <see cref="HashSet{T}"/>,
	/// or falls back to a generic remove-then-add for other collection types.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="collection">The target collection.</param>
	/// <param name="item">The item to upsert.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void DispatchUpsert<T>(ICollection<T> collection, T item)
	{
		if (collection is List<T> list)
		{
			UpsertIntoList(list, item);
			return;
		}

		if (collection is HashSet<T> hashSet)
		{
			_ = hashSet.Remove(item);
			_ = hashSet.Add(item);
			return;
		}

		_ = collection.Remove(item);
		collection.Add(item);
	}

	/// <summary>
	/// Finds the first item in <paramref name="collection"/> whose <c>Id</c> equals that of <paramref name="item"/>.
	/// </summary>
	/// <typeparam name="T">The element type implementing <see cref="IDataModel{T,TKey}"/>.</typeparam>
	/// <typeparam name="TKey">The key type.</typeparam>
	/// <param name="collection">The collection to search.</param>
	/// <param name="item">The item whose <c>Id</c> is used as the search key.</param>
	/// <returns>The matching element, or <see langword="null"/> if none found.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static T? FindItemById<T, TKey>(ICollection<T> collection, T item)
	where T : IDataModel<T, TKey> where TKey : notnull
	{
		var comparer = EqualityComparer<TKey>.Default;
		foreach (var existing in collection)
		{
			if (comparer.Equals(existing.Id, item.Id))
			{
				return existing;
			}
		}
		return default;
	}

	/// <summary>
	/// Finds and removes the first item in <paramref name="collection"/> whose <c>Id</c> equals that of <paramref name="item"/>.
	/// </summary>
	/// <typeparam name="T">The element type implementing <see cref="IDataModel{T,TKey}"/>.</typeparam>
	/// <typeparam name="TKey">The key type.</typeparam>
	/// <param name="collection">The collection to search.</param>
	/// <param name="item">The item whose <c>Id</c> is used as the search key.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void RemoveItemById<T, TKey>(ICollection<T> collection, T item)
		where T : IDataModel<T, TKey> where TKey : notnull
	{
		var existingItem = FindItemById<T, TKey>(collection, item);

		if (existingItem != null)
		{
			_ = collection.Remove(existingItem);
		}
	}

	/// <summary>
	/// Returns <paramref name="comparer"/> if it is not <see langword="null"/>; otherwise returns <see cref="EqualityComparer{T}.Default"/>.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="comparer">The optional comparer to resolve.</param>
	/// <returns>A non-null equality comparer.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static IEqualityComparer<T> ResolveComparer<T>(IEqualityComparer<T>? comparer)
		=> comparer ?? EqualityComparer<T>.Default;
	/// <summary>
	/// Throws <see cref="ArgumentReadOnlyException"/> when <paramref name="collection"/> is a fixed-size array.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="collection">The collection to check.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void ThrowIfArray<T>(ICollection<T> collection)
	{
		if (collection is T[])
		{
			ExceptionThrower.ThrowArgumentReadOnlyException(Resources.ArraysAreFixedSize, nameof(collection));
		}
	}

	/// <summary>
	/// Attempts to add <paramref name="item"/> to <paramref name="collection"/> if not already present,
	/// using the fastest path for <see cref="HashSet{T}"/> or a comparer-based contains check.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="collection">The target collection.</param>
	/// <param name="item">The item to add.</param>
	/// <param name="comparer">The equality comparer to use; must not be <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if the item was added; <see langword="false"/> if it was already present.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool TryAddIfUnique<T>(ICollection<T> collection, T item, IEqualityComparer<T> comparer)
	{
		if (collection is HashSet<T> hashSet)
		{
			return hashSet.Add(item);
		}

		if (collection.Contains(item, comparer))
		{
			return false;
		}

		collection.Add(item);
		return true;
	}

	/// <summary>
	/// Upserts <paramref name="item"/> into <paramref name="list"/> using index-based replacement when found.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="list">The list to update.</param>
	/// <param name="item">The item to upsert.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void UpsertIntoList<T>(List<T> list, T item)
	{
		var idx = list.IndexOf(item);

		if (idx >= 0)
		{
			list[idx] = item;
		}
		else
		{
			list.Add(item);
		}
	}
}
