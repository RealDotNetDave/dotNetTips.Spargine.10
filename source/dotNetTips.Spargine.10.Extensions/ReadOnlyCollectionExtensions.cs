// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-16-2026
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
		/// Generates a hash code that represents the contents of the current read-only collection.
		/// </summary>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> used to obtain hash codes for individual items.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// An <see cref="int"/> hash code that reflects the sequence and values of the non-<c>null</c> items
		/// in the collection.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The method combines the hash codes of all non-<c>null</c> items using a rolling XOR-based algorithm.
		/// Two collections with the same items in the same order and using the same comparer will produce
		/// the same hash code, although collisions are still possible.
		/// </para>
		/// <para>
		/// The collection must not be <c>null</c>; otherwise, an <see cref="ArgumentNullException"/> is thrown.
		/// </para>
		/// </remarks>
		[Pure]
		[Information(nameof(GenerateHashCode), author: "David McCarter", createdOn: "1/8/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int GenerateHashCode([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			collection = collection.ArgumentNotNull();

			var eq = comparer ?? EqualityComparer<T>.Default;
			var hash = 6551;

			foreach (var item in collection)
			{
				if (item is not null)
				{
					hash ^= (hash << 5) ^ eq.GetHashCode(item);
				}
			}

			return hash;
		}

		/// <summary>
		/// Attempts to get the element at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index of the element to retrieve.</param>
		/// <param name="value">When this method returns, contains the element at the specified index, or the default value if the index is out of range.</param>
		/// <returns>
		/// <c>true</c> if the element was successfully retrieved; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(TryGetValue), author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public bool TryGetValue(int index, out T? value)
		{
			if (collection is null || index < 0 || index >= collection.Count)
			{
				value = default;
				return false;
			}

			value = collection.ElementAt(index);
			return true;
		}

		/// <summary>
		/// Gets the element at the specified index, or the default value if the index is out of range.
		/// </summary>
		/// <param name="index">The zero-based index of the element to retrieve.</param>
		/// <param name="defaultValue">The default value to return if the index is out of range.</param>
		/// <returns>
		/// The element at the specified index, or <paramref name="defaultValue"/> if the index is out of range.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetValueOrDefault), author: "David McCarter", createdOn: "2/16/2026", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public T? GetValueOrDefault(int index, T? defaultValue = default)
		{
			if (collection is null || index < 0 || index >= collection.Count)
			{
				return defaultValue;
			}

			return collection.ElementAt(index);
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
