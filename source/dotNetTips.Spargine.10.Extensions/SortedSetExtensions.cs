// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-25-2026
// ***********************************************************************
// <copyright file="SortedSetExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods designed for SortedSet.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="SortedSet{T}"/>.
/// </summary>
/// <remarks>
/// This class contains extension methods for <see cref="SortedSet{T}"/> that enhance its functionality by providing methods to check for items,
/// determine if any items match a specified condition, and convert the set to an immutable sorted set. These methods aim to simplify common
/// operations performed on sorted sets and improve code readability and maintainability.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class SortedSetExtensions
{
	/// <summary>
	/// Provides extension methods for a <see cref="SortedSet{T}"/> instance.
	/// </summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	/// <param name="collection">The sorted set to extend.</param>
	extension<T>([AllowNull] SortedSet<T> collection)
	{

		/// <summary>
		/// Determines whether the specified <see cref="SortedSet{T}"/> contains any elements.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the set is not <c>null</c> and contains at least one element; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses the <see cref="SortedSet{T}.Count"/> property
		/// which is O(1) as SortedSet maintains its count internally.
		/// </para>
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty()
		{
			return collection is not null && collection.Count > 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="SortedSet{T}"/> contains any elements that match the specified predicate.
		/// </summary>
		/// <param name="actionPredicate">A function to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if the set is not <c>null</c> and any elements match the predicate; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses LINQ's <c>Any</c> with a predicate,
		/// which short-circuits on the first matching element, providing optimal performance.
		/// </para>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Best case:</b> O(1) - First element matches the predicate</description></item>
		/// <item><description><b>Average case:</b> O(n/2) - Match found halfway through</description></item>
		/// <item><description><b>Worst case:</b> O(n) - No elements match or last element matches</description></item>
		/// <item><description><b>Short-circuit behavior:</b> Stops immediately when first match is found</description></item>
		/// </list>
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
		/// Converts the specified <see cref="SortedSet{T}"/> to an <see cref="ImmutableSortedSet{T}"/>.
		/// </summary>
		/// <returns>
		/// An <see cref="ImmutableSortedSet{T}"/> containing the elements of the original set.
		/// </returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses <see cref="ImmutableSortedSet.CreateRange{T}(IEnumerable{T})"/>
		/// which efficiently creates an immutable sorted set from the existing sorted collection.
		/// </para>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Time complexity:</b> O(n) - Must copy all elements to the immutable structure</description></item>
		/// <item><description><b>Space complexity:</b> O(n) - Creates a new immutable collection</description></item>
		/// <item><description><b>Optimization:</b> Leverages the sorted nature of the input for efficient tree construction</description></item>
		/// </list>
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToImmutableSortedSet), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableSortedSet<T> ToImmutableSortedSet()
		{
			//TODO: OVERLOAD AND OBSOLETE. CHANGE TO TOIMMUTABLE()
			collection = collection.ArgumentNotNull();

			return ImmutableSortedSet.CreateRange(collection);
		}
	}
}
