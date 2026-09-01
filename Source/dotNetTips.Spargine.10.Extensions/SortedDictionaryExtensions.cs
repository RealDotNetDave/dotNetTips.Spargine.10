// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="SortedDictionaryExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Extension methods for <c>SortedDictionary{TKey, TValue}</c> providing empty/not-empty checks
// (<c>IsEmpty</c>, <c>IsNotEmpty</c>), immutable conversion (<c>ToImmutable</c>),
// and insert-or-update operations (<c>Upsert</c>).
// </summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <c>SortedDictionary{TKey, TValue}</c> covering empty checks,
/// immutable conversion, and insert-or-update operations.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class SortedDictionaryExtensions
{

	/// <summary>
	/// Returns <c>true</c> if <paramref name="collection"/> is <c>null</c> or contains no items.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <c>SortedDictionary{TKey, TValue}</c> to check.</param>
	/// <returns><c>true</c> if the dictionary is <c>null</c> or empty; otherwise, <c>false</c>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEmpty), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsEmpty<TKey, TValue>([DisallowNull] this SortedDictionary<TKey, TValue> collection) where TKey : notnull
	{
		return collection is null || collection.Count == 0;
	}

	/// <summary>
	/// Returns <c>true</c> if <paramref name="collection"/> is not <c>null</c> and contains at least one item.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <c>SortedDictionary{TKey, TValue}</c> to check.</param>
	/// <returns><c>true</c> if the dictionary is not <c>null</c> and has items; otherwise, <c>false</c>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsNotEmpty<TKey, TValue>([DisallowNull] this SortedDictionary<TKey, TValue> collection) where TKey : notnull
	{
		return collection is not null && collection.Count > 0;
	}

	/// <summary>
	/// Returns <c>true</c> if <paramref name="collection"/> is not <c>null</c> and any item matches
	/// <paramref name="actionPredicate"/>.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <c>SortedDictionary{TKey, TValue}</c> to check.</param>
	/// <param name="actionPredicate">A predicate to test each key/value pair for a condition.</param>
	/// <returns><c>true</c> if any item in <paramref name="collection"/> matches the predicate; otherwise, <c>false</c>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsNotEmpty<TKey, TValue>([DisallowNull] this SortedDictionary<TKey, TValue> collection, [DisallowNull] Func<KeyValuePair<TKey, TValue>, bool> actionPredicate) where TKey : notnull
	{
		collection = collection.ArgumentNotNull();
		actionPredicate = actionPredicate.ArgumentNotNull();

		return collection.Any(actionPredicate);
	}

	/// <summary>
	/// Returns <c>true</c> if <paramref name="collection"/> is not <c>null</c> and contains exactly
	/// <paramref name="count"/> items.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <c>SortedDictionary{TKey, TValue}</c> to check.</param>
	/// <param name="count">The exact number of items to verify against.</param>
	/// <returns><c>true</c> if the dictionary contains exactly <paramref name="count"/> items; otherwise, <c>false</c>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsNotEmpty<TKey, TValue>([DisallowNull] this SortedDictionary<TKey, TValue> collection, int count) where TKey : notnull
	{
		return collection is null ? false : collection.Count == count;
	}

	/// <summary>
	/// Converts <paramref name="collection"/> to an <c>ImmutableSortedDictionary{TKey, TValue}</c>.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <c>SortedDictionary{TKey, TValue}</c> to convert. Must not be <c>null</c>.</param>
	/// <param name="keyComparer">
	/// An optional <c>IComparer{TKey}</c> for key ordering.
	/// If <c>null</c>, <c>Comparer{TKey}.Default</c> is used.
	/// </param>
	/// <returns>An <c>ImmutableSortedDictionary{TKey, TValue}</c> containing all entries from <paramref name="collection"/>.</returns>
	[Pure]
	[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ImmutableSortedDictionary<TKey, TValue> ToImmutable<TKey, TValue>([DisallowNull] this SortedDictionary<TKey, TValue> collection, [AllowNull] IComparer<TKey>? keyComparer = null) where TKey : notnull
	{
		return keyComparer is null
			? ImmutableSortedDictionary.CreateRange(collection.ArgumentNotNull())
			: ImmutableSortedDictionary.CreateRange(keyComparer, EqualityComparer<TValue>.Default, collection.ArgumentNotNull());
	}

	/// <summary>
	/// Inserts or updates the entry with <paramref name="key"/> in <paramref name="collection"/>
	/// and returns the stored <paramref name="value"/>.
	/// </summary>
	/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
	/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
	/// <param name="collection">The <c>SortedDictionary{TKey, TValue}</c> to update. Must not be <c>null</c>.</param>
	/// <param name="key">The key to insert or update. Must not be <c>null</c>.</param>
	/// <param name="value">The value to associate with <paramref name="key"/>. Must not be <c>null</c>.</param>
	/// <returns>The <paramref name="value"/> that was stored.</returns>
	[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TValue Upsert<TKey, TValue>([DisallowNull] this SortedDictionary<TKey, TValue> collection, [DisallowNull] TKey key, [DisallowNull] TValue value) where TKey : notnull
	{
		collection.ArgumentNotNull()[key.ArgumentNotNull()] = value;

		return value;
	}

}
