// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 11-24-2025
// ***********************************************************************
// <copyright file="ReadOnlyCollectionExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for ReadOnlyCollection.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ReadOnlyCollection{T}"/>.
/// These methods include checks for item presence, generating hash codes, and performing actions on items within the collection.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class ReadOnlyCollectionExtensions
{
	/// <summary>
	/// Extension methods for <see cref="IReadOnlyCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to extend.</param>
	extension<T>([DisallowNull] IReadOnlyCollection<T> collection)
	{

		/// <summary>
		/// Determines whether the collection is null or contains no items.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the collection is <c>null</c> or empty; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[Information(nameof(IsEmpty), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsEmpty()
		{
			return collection is null ? true : collection.Count <= 0;
		}

		/// <summary>
		/// Generates a hash code for the <see cref="ReadOnlyCollection{T}"/>.
		/// </summary>
		/// <returns>
		/// A hash code for the collection, considering the hash codes of individual elements.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Thrown if collection is <c>null</c>.
		/// </exception>
		/// <remarks>
		/// This method computes the hash code by aggregating the hash codes of the elements in the collection.
		/// It ensures that the collection is not null before proceeding with the computation.
		/// </remarks>
		[Pure]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int GenerateHashCode()
		{
			collection = collection.ArgumentNotNull();

			//TODO: OVERLOAD TO USE EQUALITYCOMPARER
			var comparer = EqualityComparer<T>.Default;
			var hash = 6551;

			foreach (var item in collection)
			{
				if (item is not null)
				{
					hash ^= (hash << 5) ^ comparer.GetHashCode(item);
				}
			}

			return hash;
		}

		/// <summary>
		/// Determines whether the specified collection has any items that match the given predicate.
		/// </summary>
		/// <param name="actionPredicate">A predicate to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if the collection is not <c>null</c> and any elements match the predicate; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsNotEmpty([DisallowNull] Func<T, bool> actionPredicate)
		{
			return collection is null || actionPredicate is null ? false : collection.Any(actionPredicate);
		}

	}
}
