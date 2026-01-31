// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2026
// ***********************************************************************
// <copyright file="CollectionExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the ICollection types.</summary>
// ***********************************************************************
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using Microsoft.VisualBasic;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ICollection{T}"/> and other collection types, enhancing functionality with additional utility methods.
/// These methods include conditional addition, unique addition, bulk addition, and conversion utilities, aimed at simplifying common collection operations.
/// </summary>
/// <remarks>
/// The extension methods in this class are designed to improve the usability and efficiency of collections in .NET.
/// They include features such as adding items conditionally, ensuring items are unique before adding them, and converting collections to different types.
/// These utilities can significantly reduce boilerplate code and improve performance in scenarios involving collection manipulation.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineCollectionExtensions")]
public static class CollectionExtensions
{

	/// <summary>
	/// Upserts (updates or inserts) the specified item into the <see cref="ICollection{T}"/>.
	/// If an item with the same ID already exists in the collection, it is replaced with the new item.
	/// Otherwise, the new item is added to the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <typeparam name="TKey">The type of the key used to identify items in the collection.</typeparam>
	/// <param name="collection">The collection where the item will be upserted.</param>
	/// <param name="item">The item to upsert into the collection. Must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="item"/> is null.</exception>
	/// <exception cref="ArgumentReadOnlyException">Thrown if <paramref name="collection"/> is read-only.</exception>
	/// <remarks>
	/// This method ensures that the collection will not contain duplicate items based on their ID.
	/// It is a convenient way to update an existing item or add a new item without having to manually check for its existence.
	/// </remarks>
	[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void Upsert<T, TKey>([DisallowNull] this ICollection<T> collection, [AllowNull] T item) where T : IDataModel<T, TKey> where TKey : notnull
	{
		if (item is null)
		{
			return;
		}

		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		// Find the existing item by ID and remove it if found
		var existingItem = collection.FirstOrDefault(p => Equals(p.Id, item.Id));

		if (existingItem != null)
		{
			_ = collection.Remove(existingItem);
		}

		collection.Add(item);
	}

	extension<T>([DisallowNull] ICollection<T> collection)
	{
		/// <summary>
		/// Adds item to the <see cref="ICollection{T}" /> if the condition is met.
		/// </summary>
		/// <param name="item">The item to add.</param>
		/// <param name="condition">If set to <c>true</c>, the item is added.</param>
		/// <remarks>
		/// If <paramref name="item"/> is <c>null</c>, the method returns without modifying the collection.
		/// The collection must not be <c>null</c> or read-only.
		/// </remarks>
		/// <example>
		/// This example shows how to use the <see cref="AddIf{T}"/> method to add an item to a collection only if a certain condition is true.
		/// <code>
		/// var myCollection = new List&lt;int&gt;();
		/// int newItem = 5;
		/// bool condition = true;
		/// myCollection.AddIf(newItem, condition);
		/// // newItem is added to myCollection because condition is true.
		/// </code>
		/// </example>
		[Information(nameof(AddIf), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public void AddIf([AllowNull] in T item, bool condition)
		{
			if (item is null)
			{
				return;
			}

			if (collection is T[])
			{
				ExceptionThrower.ThrowArgumentReadOnlyException("Arrays are fixed-size and do not support AddRange.", nameof(collection));
			}

			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

			if (condition)
			{
				collection.Add(item);
			}
		}

		/// <summary>
		/// Adds the item to the <see cref="ICollection{T}" /> if it does not exist.
		/// </summary>
		/// <param name="item">The item to add. If <c>null</c>, the method returns <c>false</c>.</param>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> implementation to use when comparing elements.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns><c>true</c> if the item was added to the collection; <c>false</c> if the item already exists or is <c>null</c>.</returns>
		/// <exception cref="ArgumentReadOnlyException">Thrown if the collection is read-only.</exception>
		/// <exception cref="ArgumentNullException">Thrown if the collection is <c>null</c>.</exception>
		/// <example>
		/// <code>
		/// // With custom comparer
		/// people.AddIfNotExists(person, new PersonComparer());
		/// 
		/// // With default comparer (null)
		/// numbers.AddIfNotExists(42, null);
		/// 
		/// // Case-insensitive string addition
		/// names.AddIfNotExists("Alice", StringComparer.OrdinalIgnoreCase);
		/// </code>
		/// </example>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
		public bool AddIfNotExists([AllowNull] in T item, [AllowNull] IEqualityComparer<T>? comparer = null)
		{
			if (item is null)
			{
				return false;
			}

			if (collection is T[])
			{
				ExceptionThrower.ThrowArgumentReadOnlyException("Arrays are fixed-size and do not support AddRange.", nameof(collection));
			}

			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

			var eq = comparer ?? EqualityComparer<T>.Default;

			if (collection.Contains(item, eq))
			{
				return false;
			}

			collection.Add(item);

			return true;
		}

		/// <summary>
		/// Adds the items to the <see cref="ICollection{T}" />.
		/// </summary>
		/// <param name="items">The items to add to the collection.</param>
		/// <param name="ensureUnique">if set to <c>true</c> [ensure unique].</param>
		/// <returns><c>true</c> if any items were added to the collection, <c>false</c> otherwise.</returns>
		/// <example>
		/// This example shows how to use the <see cref="AddRange{T}"/> method to add multiple items to a collection, ensuring each item is unique.
		/// <code>
		/// var myCollection = new List&lt;int&gt;();
		/// var newItems = new[] { 1, 2, 3, 4, 5 };
		/// bool ensureUnique = true;
		/// myCollection.AddRange(newItems, ensureUnique);
		/// // myCollection now contains the unique items from newItems.
		/// </code>
		/// </example>
		[Information(nameof(AddRange), "David McCarter", "11/7/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public bool AddRange([DisallowNull] IEnumerable<T> items, bool ensureUnique = true)
		{
			items = items.ArgumentNotNull();

			if (collection is T[])
			{
				ExceptionThrower.ThrowArgumentReadOnlyException("Arrays are fixed-size and do not support AddRange.", nameof(collection));
			}

			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

			if (!ensureUnique)
			{
				foreach (var item in items)
				{
					collection.Add(item);
				}
				return true;
			}

			var addedAny = false;
			var existingItems = new HashSet<T>(collection);

			foreach (var item in items)
			{
				if (existingItems.Add(item))
				{
					collection.Add(item);
					addedAny = true;
				}
			}

			return addedAny;
		}

		/// <summary>
		/// Converts an <see cref="ICollection{T}"/> to a <see cref="ReadOnlySpan{T}"/>.
		/// This method provides an efficient way to access a collection with the performance benefits of a <see cref="ReadOnlySpan{T}"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="ReadOnlySpan{T}"/> representing the same elements as the collection.
		/// </returns>
		/// <exception cref="ArgumentNullException">Thrown if the collection is <c>null</c>.</exception>
		/// <remarks>
		/// This method creates a new array from the collection and returns it as a <see cref="ReadOnlySpan{T}"/>.
		/// This is particularly useful for high-performance scenarios where the overhead of enumeration or random access 
		/// in a collection needs to be minimized. Note that this method allocates a new array, so the span is a snapshot 
		/// of the collection at the time of the call.
		/// </remarks>
		/// <example>
		/// <code>
		/// var myCollection = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// ReadOnlySpan&lt;int&gt; span = myCollection.AsReadOnlySpan();
		/// // span now contains the elements from myCollection
		/// foreach (var item in span)
		/// {
		///     Console.WriteLine(item);
		/// }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AsReadOnlySpan), "David McCarter", "6/3/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlySpan<T> AsReadOnlySpan()
		{
			if (collection is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(collection));
			}

			return new([.. collection]);
		}

		/// <summary>
		/// Converts a <see cref="Collection{T}" /> to <see cref="Span{T}" />.
		/// This method provides an efficient way to access a <see cref="Collection{T}" /> with the performance benefits of a <see cref="Span{T}" />.
		/// </summary>
		/// <returns>A span representing the same elements as the collection.</returns>
		/// <remarks>
		/// This method is particularly useful for high-performance scenarios where the overhead of enumeration or random access in a collection needs to be minimized.
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AsSpan), "David McCarter", "6/3/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Span<T> AsSpan()
		{
			return new([.. collection]);
		}

		/// <summary>
		/// Converts a <see cref="Collection{T}" /> to a <see cref="FrozenSet{T}" />.
		/// This method provides an efficient way to create an immutable set from a mutable collection.
		/// </summary>
		/// <returns>A <see cref="FrozenSet{T}" /> that contains elements from the input collection.</returns>
		/// <remarks>
		/// <see cref="FrozenSet{T}" /> is useful for scenarios where a set of items should not be modified after creation.
		/// This method is particularly useful for quickly converting existing collections to immutable sets.
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet()
		{
			return FrozenSet.ToFrozenSet(collection);
		}

		/// <summary>
		/// Upserts (updates or inserts) the specified item into the <see cref="ICollection{T}"/>.
		/// If an item equal to the specified item already exists in the collection, it is removed and replaced with the new item.
		/// Otherwise, the new item is added to the collection.
		/// </summary>
		/// <param name="item">The item to upsert into the collection. If <c>null</c>, the method returns without modifying the collection.</param>
		/// <exception cref="ArgumentNullException">Thrown if the collection is <c>null</c>.</exception>
		/// <exception cref="ArgumentReadOnlyException">Thrown if the collection is read-only.</exception>
		[Information(nameof(Upsert), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public void Upsert([AllowNull] in T item)
		{
			if (item is null)
			{
				return;
			}

			if (collection is T[])
			{
				ExceptionThrower.ThrowArgumentReadOnlyException("Arrays are fixed-size and do not support AddRange.", nameof(collection));
			}

			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

			_ = collection.Remove(item);

			collection.Add(item);
		}
	}
}
