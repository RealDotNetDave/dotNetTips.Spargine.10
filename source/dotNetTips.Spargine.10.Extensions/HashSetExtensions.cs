// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-14-2026
// ***********************************************************************
// <copyright file="HashSetExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for the HashSet type.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="HashSet{T}" /> to enhance its functionality.
/// These methods include adding items conditionally, converting to concurrent or immutable hash sets, and upserting items.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class HashSetExtensions
{
	/// <summary>
	/// Provides extension methods for <see cref="HashSet{T}" />.
	/// </summary>
	/// <typeparam name="T">The type of elements in the <see cref="HashSet{T}" />.</typeparam>
	/// <param name="collection">The <see cref="HashSet{T}" /> instance to extend.</param>
	extension<T>([DisallowNull] HashSet<T> collection)
	{
		/// <summary>
		/// Adds an item to the <see cref="HashSet{T}" /> if a specified condition is met.
		/// </summary>
		/// <param name="item">The item to add to the hash set.</param>
		/// <param name="condition">The condition that determines whether the item should be added.</param>
		[Pure]
		[Information(nameof(AddIf), "David McCarter", "5/2/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public void AddIf([DisallowNull] T item, bool condition)
		{
			if (!condition)
			{
				return;
			}

			_ = collection.ArgumentNotNull().Add(item.ArgumentNotNull());
		}

		/// <summary>
		/// Converts a <see cref="HashSet{T}" /> to a <see cref="ConcurrentHashSet{T}" />.
		/// This method ensures thread-safe operations on the hash set by creating a concurrent version of it.
		/// </summary>
		/// <returns>
		/// A new instance of <see cref="ConcurrentHashSet{T}" /> containing all elements from the original hash set.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Thrown if collection is null.
		/// </exception>
		[Pure]
		[return: NotNull]
		[Obsolete("Use ToConcurrent() instead. This method will be removed at the end of 2026.", false)]
		[Information(nameof(ToConcurrentHashSet), "David McCarter", "12/3/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ConcurrentHashSet<T> ToConcurrentHashSet()
		{
			return collection.ToConcurrent();
		}

		/// <summary>
		/// Converts a <see cref="HashSet{T}"/> to a <see cref="ConcurrentHashSet{T}"/> for thread-safe operations.
		/// </summary>
		/// <returns>
		/// A new <see cref="ConcurrentHashSet{T}"/> containing all elements from the source hash set.
		/// </returns>
		/// <exception cref="ArgumentNullException">Thrown if collection is null.</exception>
		[Pure]
		[return: NotNull]
		[Information(nameof(ToConcurrent), "David McCarter", "1/28/2026", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ConcurrentHashSet<T> ToConcurrent()
		{
			return [.. collection.ArgumentNotNull()];
		}

		/// <summary>
		/// Converts a <see cref="HashSet{T}" /> to an <see cref="ImmutableHashSet{T}" />.
		/// This method creates an immutable hash set containing all the elements of the original hash set,
		/// providing a snapshot that cannot be modified.
		/// </summary>
		/// <returns>
		/// An <see cref="ImmutableHashSet{T}" /> containing all elements from the original hash set.
		/// </returns>
		[Pure]
		[return: NotNull]
		[Obsolete("Use ToImmutable() instead. This method will be removed at the end of 2026.")]
		[Information(nameof(ToImmutableHashSet), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableHashSet<T> ToImmutableHashSet()
		{
			return [.. collection.ArgumentNotNull()];
		}

		/// <summary>
		/// Converts a <see cref="HashSet{T}"/> to an <see cref="ImmutableHashSet{T}"/>.
		/// </summary>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> implementation to use when comparing elements.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// An <see cref="ImmutableHashSet{T}"/> containing all elements from the source hash set.
		/// </returns>
		/// <exception cref="ArgumentNullException">Thrown if collection is null.</exception>
		[Pure]
		[return: NotNull]
		[Information(nameof(ToImmutable), "David McCarter", "1/28/2026", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableHashSet<T> ToImmutable([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			return comparer is null
				? [.. collection.ArgumentNotNull()]
				: ImmutableHashSet.CreateRange(comparer, collection.ArgumentNotNull());
		}

		/// <summary>
		/// Upserts (updates or inserts) an item into the <see cref="HashSet{T}" />.
		/// If the item already exists in the hash set, it is first removed and then added again to ensure the latest value is stored.
		/// </summary>
		/// <param name="item">The item to upsert into the hash set.</param>
		[Pure]
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public void Upsert([DisallowNull] T item)
		{
			collection = collection.ArgumentNotNull();
			item = item.ArgumentNotNull();

			if (collection.Contains(item))
			{
				_ = collection.Remove(item);
			}

			_ = collection.Add(item);
		}

	}
}
