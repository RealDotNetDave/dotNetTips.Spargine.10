// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="SortedSetExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Extension methods for <c>SortedSet{T}</c> providing item-presence checks
// (<c>IsNotEmpty</c>) and immutable conversion (<c>ToImmutable</c>, <c>ToImmutableSortedSet</c>).
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
/// Provides extension methods for <c>SortedSet{T}</c> covering item-presence checks
/// and immutable conversion.
/// </summary>
/// <remarks>
/// Methods include checking whether any elements exist (<c>IsNotEmpty</c>), testing elements
/// against a predicate, and converting the set to an <c>ImmutableSortedSet{T}</c>
/// (<c>ToImmutable</c>, <c>ToImmutableSortedSet</c>).
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class SortedSetExtensions
{
	/// <summary>
	/// Extension methods for a <c>SortedSet{T}</c> instance.
	/// </summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	/// <param name="collection">The sorted set to extend.</param>
	extension<T>([AllowNull] SortedSet<T> collection)
	{

		/// <summary>
		/// Returns <c>true</c> if the set is not <c>null</c> and contains at least one element.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the set is not <c>null</c> and contains at least one element; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// Uses the <c>SortedSet{T}.Count</c> property which is O(1) as the count is maintained internally.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty()
		{
			return collection is not null && collection.Count > 0;
		}

		/// <summary>
		/// Returns <c>true</c> if the set is not <c>null</c> and any element matches
		/// <paramref name="actionPredicate"/>.
		/// </summary>
		/// <param name="actionPredicate">A function to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if the set is not <c>null</c> and any elements match the predicate; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// Uses LINQ <c>Any</c> with a predicate, which short-circuits on the first matching element.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty([DisallowNull] Func<T, bool> actionPredicate)
		{
			if (collection is null)
			{
				return false;
			}

			actionPredicate = actionPredicate.ArgumentNotNull();

			return collection.Any(actionPredicate);
		}

		/// <summary>
		/// Converts the set to an <c>ImmutableSortedSet{T}</c>.
		/// </summary>
		/// <returns>
		/// An <c>ImmutableSortedSet{T}</c> containing all elements from the source set,
		/// ordered by the same comparer as the original set.
		/// </returns>
		/// <remarks>
		/// This method is obsolete. Use <c>ToImmutable</c> instead.
		/// Subsequent modifications to the original set are not reflected in the result.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Obsolete("Use ToImmutable() method instead. This method will be removed at the end of 2026.")]
		[Information(nameof(ToImmutableSortedSet), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Obsolete)]
		public ImmutableSortedSet<T> ToImmutableSortedSet()
		{
			return collection.ToImmutable();
		}

		/// <summary>
		/// Converts the set to an <c>ImmutableSortedSet{T}</c>.
		/// </summary>
		/// <param name="comparer">
		/// An optional <c>IComparer{T}</c> for element ordering.
		/// If <c>null</c>, <c>Comparer{T}.Default</c> is used.
		/// </param>
		/// <returns>An <c>ImmutableSortedSet{T}</c> containing all elements from the source set.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the collection is <c>null</c>.</exception>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToImmutable), "David McCarter", "1/28/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ImmutableSortedSet<T> ToImmutable([AllowNull] IComparer<T>? comparer = null)
		{
			return comparer is null
				? [.. collection.ArgumentNotNull()]
				: ImmutableSortedSet.CreateRange(comparer, collection.ArgumentNotNull());
		}
	}
}
