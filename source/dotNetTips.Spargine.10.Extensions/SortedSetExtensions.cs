// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-26-2025
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
		/// Determines whether the specified <see cref="SortedSet{T}"/> is <c>null</c> or contains no elements.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the set is <c>null</c> or empty; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[Information(nameof(IsEmpty), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsEmpty()
		{
			return collection is null ? true : collection.Count <= 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="SortedSet{T}"/> contains any elements.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the set is not <c>null</c> and contains at least one element; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsNotEmpty()
		{
			return collection is null ? false : collection.Count > 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="SortedSet{T}"/> contains any elements that match the specified predicate.
		/// </summary>
		/// <param name="actionPredicate">A function to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if the set is not <c>null</c> and any elements match the predicate; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsNotEmpty([AllowNull] Func<T, bool> actionPredicate)
		{
			return collection is null || actionPredicate is null ? false : collection.Any(actionPredicate);
		}

		/// <summary>
		/// Converts the specified <see cref="SortedSet{T}"/> to an <see cref="ImmutableSortedSet{T}"/>.
		/// </summary>
		/// <returns>
		/// An <see cref="ImmutableSortedSet{T}"/> containing the elements of the original set.
		/// </returns>
		[Pure]
		[Information(nameof(ToImmutableSortedSet), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableSortedSet<T> ToImmutableSortedSet()
		{
			return collection is null
				? ImmutableSortedSet<T>.Empty
				: ImmutableSortedSet.CreateRange(collection);

		}
	}
}
