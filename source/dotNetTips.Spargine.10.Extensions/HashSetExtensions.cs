// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-30-2025
// ***********************************************************************
// <copyright file="HashSetExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for the HashSet type.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

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
		[Information(nameof(AddIf), "David McCarter", "5/2/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public void AddIf([DisallowNull] T item, bool condition)
		{
			collection = collection.ArgumentNotNull();
			item = item.ArgumentNotNull();

			if (condition)
			{
				_ = collection.Add(item);
			}
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
		[Information(nameof(ToConcurrentHashSet), "David McCarter", "12/3/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public ConcurrentHashSet<T> ToConcurrentHashSet()
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
		[Information(nameof(ToImmutableHashSet), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableHashSet<T> ToImmutableHashSet()
		{
			return [.. collection.ArgumentNotNull()];
		}

		/// <summary>
		/// Upserts (updates or inserts) an item into the <see cref="HashSet{T}" />.
		/// If the item already exists in the hash set, it is first removed and then added again to ensure the latest value is stored.
		/// </summary>
		/// <param name="item">The item to upsert into the hash set.</param>
		[Pure]
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
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
