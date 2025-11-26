// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-24-2025
// ***********************************************************************
// <copyright file="ObservableCollectionExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for ObservableCollection.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ObservableCollection{T}"/>.
/// These methods include checks for item presence, item count, and actions on items within the collection.
/// </summary>
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
		/// Determines whether the specified collection is <c>null</c> or contains no items.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the collection is <c>null</c> or empty; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEmpty), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsEmpty()
		{
			return collection == null || collection.Count == 0;
		}

		/// <summary>
		/// Determines whether the specified collection contains any items.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the collection is not <c>null</c> and contains at least one item; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsNotEmpty()
		{
			return collection is null ? false : collection.Count > 0;
		}

		/// <summary>
		/// Determines whether the specified <paramref name="collection"/> contains any items that match the given <paramref name="actionPredicate"/>.
		/// </summary>
		/// <param name="actionPredicate">A function to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if the collection is not <c>null</c> and any items match the predicate; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsNotEmpty([DisallowNull] Func<T, bool> actionPredicate)
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
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsNotEmpty(int count)
		{
			return collection is null ? false : collection.FastLongCount() == count;
		}
	}
}
