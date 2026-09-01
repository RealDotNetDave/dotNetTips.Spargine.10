// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="ObservableCollectionExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <c>ObservableCollection{T}</c> providing item-presence checks
// (<c>IsNotEmpty</c>) by count, predicate, or exact-count comparison.
// </summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <c>ObservableCollection{T}</c> covering item-presence
/// checks by count, predicate, and exact-count comparison.
/// </summary>
/// <remarks>
/// All methods short-circuit on a <c>null</c> collection and return <c>false</c> safely.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class ObservableCollectionExtensions
{
	/// <summary>
	/// Extension methods for <see cref="ObservableCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The observable collection instance.</param>
	extension<T>([AllowNull] ObservableCollection<T> collection)
	{

		/// <summary>
		/// Determines whether the specified collection contains any items.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the collection is not <c>null</c> and contains at least one item; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty()
		{
			return collection is null ? false : collection.Count > 0;
		}

		/// <summary>
		/// Determines whether the specified <paramref name="collection"/> contains any items that match the given <paramref name="actionPredicate"/>.
		/// </summary>
		/// <param name="actionPredicate">A function to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if the collection is not <c>null</c>, the predicate is not <c>null</c>, and any items match the predicate; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// Performance: Uses Any() for early-exit behavior (O(1) to O(n)) instead of Count() which enumerates the entire collection (O(n)).
		/// This optimization avoids unnecessary iterations when the first matching element is found.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty(Func<T, bool> actionPredicate)
		{
			return collection is null || actionPredicate is null ? false : collection.Any(actionPredicate);
		}

		/// <summary>
		/// Determines whether the specified <paramref name="collection"/> contains exactly the specified <paramref name="count"/> of items.
		/// </summary>
		/// <param name="count">The number of items to compare against.</param>
		/// <returns>
		/// <c>true</c> if the collection is not <c>null</c> and contains exactly <paramref name="count"/> items; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty(in int count)
		{
			return collection is null ? false : collection.FastLongCount() == count;
		}
	}
}
