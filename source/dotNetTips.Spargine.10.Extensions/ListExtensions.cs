// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 12-02-2025
// ***********************************************************************
// <copyright file="ListExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides extension methods for List{T} to enhance functionality.</summary>
// ***********************************************************************

using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Extensions.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="List{T}"/> to enhance its functionality.
/// </summary>
/// <remarks>
/// This class includes methods for adding elements to the beginning or end of a list, checking for nulls,
/// converting lists to various collection types, performing actions on list elements, and more. These methods
/// are designed to extend the capabilities of <see cref="List{T}"/> and simplify common operations.
/// </remarks>
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineListExtentions")]
public static class ListExtensions
{
	/// <summary>
	/// Provides extension methods for <see cref="List{T}"/> to enhance its functionality.
	/// </summary>
	/// <typeparam name="T">The type of elements in the list.</typeparam>
	/// <param name="list">The list instance to extend.</param>
	extension<T>([DisallowNull] List<T> list)
	{
		/// <summary>
		/// Adds an item to the beginning of the collection.
		/// </summary>
		/// <param name="item">The item to add to the beginning of the list.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AddFirst([DisallowNull] T item)
		{
			if (item is null)
			{
				return;
			}

			list = list.ArgumentNotNull();

			list.Insert(0, item);
		}

		/// <summary>
		/// Adds an item to the end of the collection.
		/// </summary>
		/// <param name="item">The item to add to the end of the list.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AddLast([DisallowNull] T item)
		{
			if (item is null)
			{
				return;
			}

			list = list.ArgumentNotNull();

			list.Add(item);
		}

		/// <summary>
		/// Adds a range of items to the list if they do not already exist in the list.
		/// </summary>
		/// <param name="items">The items to add if not already present.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddRangeIfNotExists), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.None, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AddRangeIfNotExists([DisallowNull] IEnumerable<T> items)
		{
			list = list.ArgumentNotNull();
			items = items.ArgumentNotNull();

			foreach (var item in items)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
		}

		/// <summary>
		/// Creates a <see cref="ReadOnlySpan{T}"/> from the <see cref="List{T}"/>. Utilizing spans can improve performance when iterating over the collection.
		/// </summary>
		/// <returns>A <see cref="ReadOnlySpan{T}"/> over the list.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AsReadOnlySpan), "David McCarter", "5/30/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlySpan<T> AsReadOnlySpan()
		{
			return CollectionsMarshal.AsSpan(list.ArgumentNotNull());
		}

		/// <summary>
		/// Creates a new <see cref="Span{T}" /> using CollectionsMarshal over an input <see cref="List{T}" /> instance. Utilizing spans can improve performance when iterating over the collection.
		/// </summary>
		/// <returns>A <see cref="Span{T}"/> over the list.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AsSpan), "David McCarter", "8/3/2022", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Span<T> AsSpan()
		{
			return CollectionsMarshal.AsSpan(list.ArgumentNotNull());
		}

		/// <summary>
		/// Removes all null elements from the <see cref="List{T}"/>.
		/// </summary>
		/// <returns>True if any nulls were removed; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ClearNulls), author: "David McCarter", createdOn: "8/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool ClearNulls()
		{
			return list is null ? false : list.RemoveAll(p => p is null) > 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="List{T}"/> does not contain any items.
		/// </summary>
		/// <returns>True if the list is null or empty; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEmpty), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsEmpty()
		{
			return list == null || list.Count == 0;
		}

		/// <summary>
		/// Counts the number of elements in the specified list.
		/// </summary>
		/// <returns>The number of elements in the list.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastCount), "David McCarter", "4/12/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int FastCount()
		{
			return Unsafe.As<List<T>>(list).Count;
		}

		/// <summary>
		/// Generates a hash code for the entire <see cref="List{T}"/> based on the hash codes of its elements.
		/// </summary>
		/// <returns>A hash code representing the contents of the list.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the list is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int GenerateHashCode()
		{
			list = list.ArgumentNotNull();

			// CODE SUGGESTED BY COPILOT FAILS WITH PERSONRECORD
			var hash = new HashCode();

			foreach (var item in list.AsReadOnlySpan())
			{
				hash.Add(item);
			}

			return hash.ToHashCode();
		}

		/// <summary>
		/// Determines whether the specified <see cref="List{T}"/> contains any items.
		/// </summary>
		/// <returns>True if the list has items; otherwise, false.</returns>
		[Pure]
		[Information(nameof(IsNotEmpty), "David McCarter", "8/27/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty()
		{
			return list?.Count > 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="List{T}" /> has items based on the Predicate.
		/// Returns false if <paramref name="action" /> or <paramref name="list" /> is null.
		/// </summary>
		/// <param name="action">The predicate to test each element.</param>
		/// <returns>True if any items match the predicate; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty([DisallowNull] Predicate<T> action)
		{
			return list.Exists(action);
		}

		/// <summary>
		/// Determines whether the <see cref="List{T}" /> has a specified count.
		/// Returns false if <paramref name="list" /> is null.
		/// </summary>
		/// <param name="count">The count to compare.</param>
		/// <returns>True if the list has the specified count; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "8/27/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty(int count)
		{
			return list is null ? false : list.Count == count;
		}

		/// <summary>
		/// Finds an index that avoids multiple enumerations.
		/// </summary>
		/// <param name="index">The index to access, supports wrapping.</param>
		/// <returns>The element at the wrapped index.</returns>
		/// <exception cref="ArgumentException">Thrown if the list is empty.</exception>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IndexAtLooped), author: "David McCarter", createdOn: "7/17/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T IndexAtLooped(int index)
		{
			list = list.ArgumentNotNull();

			var count = list.Count;

			if (count == 0)
			{
				ExceptionThrower.ThrowArgumentException(Resources.CollectionIsEmpty, nameof(list));
			}

			var indexWrap = index % count;

			if (indexWrap < 0)
			{
				indexWrap += count;
			}

			return list[indexWrap];
		}

		/// <summary>
		/// Determines whether the specified list to check is equal to the current list.
		/// </summary>
		/// <param name="collectionToCheck">The list to compare with the current list.</param>
		/// <returns>True if the lists are equal; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEqualTo), author: "David McCarter", createdOn: "3/22/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsEqualTo([DisallowNull] List<T> collectionToCheck)
		{
			if (list is null || collectionToCheck is null)
			{
				return false;
			}

			if (list.Count != collectionToCheck.Count)
			{
				return false;
			}

			var itemCount = list.Count;

			for (var index = 0; index < itemCount; index++)
			{
				if (!EqualityComparer<T>.Default.Equals(list[index], collectionToCheck[index]))
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Performs the action for the items in the <see cref="List{T}" />.
		/// </summary>
		/// <param name="action">The action to perform on each item.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(PerformAction), "David McCarter", "1/4/2023", Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed)]
		public void PerformAction([DisallowNull] Action<T> action)
		{
			list = list.ArgumentNotNull();
			action = action.ArgumentNotNull();

			if (list.Count == 0)
			{
				return;
			}

			// USING ASSPAN AND USING FOR SLOWED PERFORMANCE
			foreach (var item in list)
			{
				action.Invoke(item);
			}
		}

		/// <summary>
		/// Removes the first occurrence of a specific item from the list.
		/// </summary>
		/// <param name="item">The item to remove.</param>
		/// <returns>True if the item was removed; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveFirst), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.None, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool RemoveFirst(T item)
		{
			list = list.ArgumentNotNull();

			if (item is null)
			{
				return false;
			}

			var index = list.IndexOf(item);

			if (index >= 0)
			{
				list.RemoveAt(index);
				return true;
			}

			return false;
		}

		/// <summary>
		/// Removes the last occurrence of a specific item from the list.
		/// </summary>
		/// <param name="item">The item to remove.</param>
		/// <returns>True if the item was removed; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveLast), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.None, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool RemoveLast(T item)
		{
			list = list.ArgumentNotNull();

			if (item is null)
			{
				return false;
			}

			var index = list.LastIndexOf(item);

			if (index >= 0)
			{
				list.RemoveAt(index);
				return true;
			}

			return false;
		}

		/// <summary>
		/// Shuffles the elements of the list into a random order using a cryptographically secure random number generator.
		/// </summary>
		/// <returns>A new <see cref="List{T}"/> containing all elements from the original list in a randomly shuffled order.</returns>
		/// <remarks>
		/// This method implements the Fisher-Yates shuffle algorithm (also known as the Knuth shuffle).
		/// It creates a copy of the original list and performs an in-place shuffle on the copy using
		/// <see cref="RandomNumberGenerator"/> to ensure cryptographically secure randomization.
		/// <para>
		/// Performance characteristics:
		/// - Time complexity: O(n) where n is the number of elements
		/// - Space complexity: O(n) - creates a copy of the list
		/// - Significantly faster than LINQ-based approaches due to direct array access
		/// </para>
		/// </remarks>
		/// <example>
		/// This example shows how to use <see cref="FastShuffle"/> to randomly shuffle a list of integers.
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// var shuffled = numbers.FastShuffle();
		/// // Result: A new list with elements in random order, e.g., { 3, 1, 5, 2, 4 }
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastShuffle), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
		public List<T> FastShuffle()
		{
			list = list.ArgumentNotNull();

			var count = list.Count;

			// Handle edge cases
			if (count <= 1)
			{
				return [.. list];
			}

			// Create a copy of the list
			var shuffled = new List<T>(list);

			// Get direct span access to the new list's backing array
			var span = CollectionsMarshal.AsSpan(shuffled);

			// Fisher-Yates shuffle using cryptographically secure random
			for (var i = count - 1; i > 0; i--)
			{
				// Generate random index from 0 to i (inclusive)
				var j = RandomNumberGenerator.GetInt32(i + 1);

				// Swap elements at i and j using tuple deconstruction
				(span[i], span[j]) = (span[j], span[i]);
			}

			return shuffled;
		}

		/// <summary>
		/// Splits the list into multiple smaller lists of a specified size.
		/// </summary>
		/// <param name="size">The size of each split list.</param>
		/// <returns>A read-only collection of read-only collections, each containing a segment of the original list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Split), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.None, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Updated)]
		public ReadOnlyCollection<ReadOnlyCollection<T>> Split(int size)
		{
			list = list.ArgumentNotNull();
			size = size.ArgumentInRange(min: 1, max: list.Count, paramName: nameof(size));

			var chunks = (int)Math.Ceiling((double)list.Count / size);
			var result = new List<ReadOnlyCollection<T>>(chunks);

			for (var index = 0; index < list.Count; index += size)
			{
				result.Add(new ReadOnlyCollection<T>(list.GetRange(index, Math.Min(size, list.Count - index))));
			}

			return result.AsReadOnly();
		}

		/// <summary>
		/// Converts the list to a <see cref="Collection{T}"/>.
		/// </summary>
		/// <returns>A <see cref="Collection{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToCollection), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Collection<T> ToCollection()
		{
			return [.. list.ArgumentNotNull()];
		}

		/// <summary>
		/// Converts the list to a <see cref="DistinctBlockingCollection{T}"/>.
		/// </summary>
		/// <param name="completeAdding">Set to true if no more items will be added to this collection.</param>
		/// <returns>A <see cref="DistinctBlockingCollection{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToDistinctBlockingCollection), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public DistinctBlockingCollection<T> ToDistinctBlockingCollection(bool completeAdding = false)
		{
			var result = new DistinctBlockingCollection<T>(list.ArgumentItemsExists());

			if (completeAdding)
			{
				result.CompleteAdding();
			}

			return result;
		}

		/// <summary>
		/// Converts the list to a <see cref="DistinctConcurrentBag{T}"/>.
		/// </summary>
		/// <returns>A <see cref="DistinctConcurrentBag{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToDistinctConcurrentBag), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public DistinctConcurrentBag<T> ToDistinctConcurrentBag()
		{
			return [.. list.ArgumentNotNull()];
		}

		/// <summary>
		/// Converts the list to a <see cref="FastSortedList{T}"/>.
		/// </summary>
		/// <returns>A <see cref="FastSortedList{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFastSortedList), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FastSortedList<T> ToFastSortedList()
		{
			return [.. list.ArgumentNotNull()];
		}

		/// <summary>
		/// Converts the list to a <see cref="FastSortedList{T}"/> using the specified comparer.
		/// </summary>
		/// <param name="comparer">The comparer to use for sorting.</param>
		/// <returns>A <see cref="FastSortedList{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFastSortedList), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FastSortedList<T> ToFastSortedList([DisallowNull] IComparer<T> comparer)
		{
			return new(list.ArgumentNotNull(), comparer.ArgumentNotNull());
		}

		/// <summary>
		/// Converts the list to a <see cref="FrozenSet{T}"/>.
		/// </summary>
		/// <returns>A <see cref="FrozenSet{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet()
		{
			list = list.ArgumentNotNull();

			return FrozenSet.ToFrozenSet(list);
		}

		/// <summary>
		/// Converts the list to an <see cref="ImmutableArray{T}"/>.
		/// </summary>
		/// <returns>An <see cref="ImmutableArray{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToCollection), "David McCarter", "12/3/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableArray<T> ToImmutableArray()
		{
			list = list.ArgumentNotNull();

			return [.. list];
		}

		/// <summary>
		/// Converts the list to a <see cref="List{T}"/> asynchronously, supporting cancellation.
		/// </summary>
		/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
		/// <returns>A task representing the asynchronous operation, with a <see cref="List{T}"/> result.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToListAsync), "David McCarter", "12/3/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public async Task<List<T>> ToListAsync(CancellationToken cancellationToken = default)
		{
			list = list.ArgumentNotNull();

			var returnList = new List<T>();

			await Task.Yield();

			foreach (var element in list)
			{
				cancellationToken.ThrowIfCancellationRequested();
				returnList.Add(element);
			}

			return returnList;
		}

		/// <summary>
		/// Converts the list to an <see cref="ObservableCollection{T}"/>.
		/// </summary>
		/// <returns>An <see cref="ObservableCollection{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToObservableCollection), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ObservableCollection<T> ToObservableCollection()
		{
			return [.. list.ArgumentNotNull()];
		}

		/// <summary>
		/// Converts the list to an <see cref="ObservableList{T}"/>.
		/// </summary>
		/// <returns>An <see cref="ObservableList{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToObservableList), "David McCarter", "10/21/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ObservableList<T> ToObservableList()
		{
			return [.. list.ArgumentNotNull()];
		}

		/// <summary>
		/// Converts the list to an <see cref="IReadOnlyList{T}"/>.
		/// </summary>
		/// <returns>An <see cref="IReadOnlyList{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToReadOnlyList), "David McCarter", "4/10/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IReadOnlyList<T> ToReadOnlyList()
		{
			return list.ArgumentNotNull();
		}

		/// <summary>
		/// Converts the list to a <see cref="ReadOnlyObservableCollection{T}"/>.
		/// </summary>
		/// <returns>A <see cref="ReadOnlyObservableCollection{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToObservableCollection), "David McCarter", "11/26/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyObservableCollection<T> ToReadOnlyObservableCollection()
		{
			return new(list.ArgumentNotNull().ToObservableCollection());
		}

	}
}
