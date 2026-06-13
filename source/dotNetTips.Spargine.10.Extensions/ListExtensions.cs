// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 06-13-2026
// ***********************************************************************
// <copyright file="ListExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="System.Collections.Generic.List{T}"/> providing element insertion
// (<c>AddFirst</c>, <c>AddLast</c>, <c>AddRangeIfNotExists</c>), span views (<c>AsSpan</c>, <c>AsReadOnlySpan</c>),
// presence checks (<c>IsNotEmpty</c>, <c>ClearNulls</c>), conversions to frozen, immutable, observable,
// and read-only collection types, shuffling (<c>FastShuffle</c>), chunking (<c>Split</c>),
// and equality comparison (<c>IsEqualTo</c>).
// </summary>
// ***********************************************************************

using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.VisualBasic;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="List{T}"/> to enhance its functionality.
/// </summary>
/// <remarks>
/// Methods are grouped by purpose: element insertion (<c>AddFirst</c>, <c>AddLast</c>, <c>AddRangeIfNotExists</c>),
/// low-allocation iteration via <see cref="Span{T}"/> and <see cref="ReadOnlySpan{T}"/>, presence and equality
/// checks, bulk operations (<c>PerformAction</c>, <c>FastShuffle</c>, <c>Split</c>), and conversions to
/// <see cref="FrozenSet{T}"/>, <see cref="ImmutableArray{T}"/>,
/// observable, concurrent, and read-only collection types.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineListExtentions")]
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
		/// Inserts the specified <paramref name="item"/> at the beginning of the <see cref="List{T}"/>.
		/// </summary>
		/// <param name="item">The item to insert at index zero.</param>
		/// <remarks>
		/// <para>
		/// This operation has O(n) time complexity because all existing elements are shifted one position to the right.
		/// </para>
		/// <para>
		/// If the list needs to grow its internal capacity, an additional allocation and copy will occur.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Thrown when <paramref name="item"/> is <c>null</c>.
		/// </exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AddFirst([DisallowNull] T item)
		{
			item = item.ArgumentNotNull();
			list = list.ArgumentNotNull();

			// O(n) operation - shifts all elements right
			// This is the ONLY way to prepend to a List<T>
			list.Insert(0, item);
		}

		/// <summary>
		/// Appends the specified <paramref name="item"/> to the end of the <see cref="List{T}"/>.
		/// </summary>
		/// <param name="item">The item to append to the list. Must not be <c>null</c>.</param>
		/// <remarks>
		/// <para>
		/// This is a thin wrapper over <see cref="List{T}.Add(T)"/> and provides the same semantics and
		/// amortized O(1) performance characteristics for appending elements.
		/// </para>
		/// <para>
		/// If the underlying list needs to grow its internal buffer, this operation may trigger a resize,
		/// which involves allocating a larger array and copying existing elements.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var values = new List&lt;int&gt; { 1, 2, 3 };
		/// values.AddLast(4);
		/// // values == { 1, 2, 3, 4 }
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AddLast([DisallowNull] T item)
		{
			list = list.ArgumentNotNull();
			item = item.ArgumentNotNull();

			// O(1) amortized operation - appends to end
			// This is the optimal way to add to a List<T>
			list.Add(item);
		}

		/// <summary>
		/// Adds a range of items to the list only if they do not already exist in the list.
		/// </summary>
		/// <param name="items">
		/// The items to add if not already present in the target list. If <paramref name="items"/> is <c>null</c>,
		/// the method returns without modifying the list.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> used to determine item equality.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <remarks>
		/// <para>
		/// This method builds a <see cref="HashSet{T}"/> from the existing list contents using the specified comparer
		/// to provide O(1) average-time lookups when determining whether each candidate item is already present.
		/// Only items that are not in the set are appended to the list.
		/// </para>
		/// <para>
		/// <b>Performance characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Time complexity: O(n + m), where <c>n</c> is the current list size and <c>m</c> is the number of items to add.</description></item>
		/// <item><description>Space complexity: O(n) for the temporary <see cref="HashSet{T}"/>.</description></item>
		/// <item><description>Typically much faster than repeatedly calling <see cref="List{T}.Contains(T)"/> for large collections.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var list = new List&lt;int&gt; { 1, 2, 3 };
		/// var items = new[] { 2, 3, 4, 5 };
		///
		/// list.AddRangeIfNotExists(items);
		/// // list now contains: { 1, 2, 3, 4, 5 }
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddRangeIfNotExists), author: "David McCarter", createdOn: "12/22/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void AddRangeIfNotExists([DisallowNull] IEnumerable<T> items, [AllowNull] IEqualityComparer<T>? comparer = null)
		{
			if (items is null)
			{
				return;
			}

			list = list.ArgumentNotNull();

			var eq = comparer ?? EqualityComparer<T>.Default;
			var existingItems = new HashSet<T>(list, eq);

			ListExtensionsHelper.AddUniqueItems(list, items, existingItems);
		}

		/// <summary>
		/// Creates a <see cref="ReadOnlySpan{T}"/> from the <see cref="List{T}"/>. Utilizing spans can improve performance when iterating over the collection.
		/// </summary>
		/// <returns>A <see cref="ReadOnlySpan{T}"/> over the list.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AsReadOnlySpan), "David McCarter", "5/30/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlySpan<T> AsReadOnlySpan()
		{
			list = list.ArgumentNotNull();

			return CollectionsMarshal.AsSpan(list);
		}

		/// <summary>
		/// Creates a new <see cref="Span{T}" /> using CollectionsMarshal over an input <see cref="List{T}" /> instance. Utilizing spans can improve performance when iterating over the collection.
		/// </summary>
		/// <returns>A <see cref="Span{T}"/> over the list.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AsSpan), "David McCarter", "8/3/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public Span<T> AsSpan()
		{
			list = list.ArgumentNotNull();

			return CollectionsMarshal.AsSpan(list);
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
			return list is null ? false : list.RemoveAll(static p => p is null) > 0;
		}

		/// <summary>
		/// Counts the number of elements in the specified list.
		/// </summary>
		/// <returns>The number of elements in the list.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastCount), "David McCarter", "4/12/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int FastCount()
		{
			return list.Count;
		}

		/// <summary>
		/// Generates a hash code for the entire <see cref="List{T}"/> based on the hash codes of its elements.
		/// </summary>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> used to compute element hash codes.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>A hash code representing the contents of the list.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the list is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int GenerateHashCode([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			list = list.ArgumentNotNull();

			var hash = new HashCode();

			foreach (var item in list.AsReadOnlySpan())
			{
				hash.Add(item, comparer);
			}

			return hash.ToHashCode();
		}

		/// <summary>
		/// Determines whether the specified <see cref="List{T}"/> contains any items.
		/// </summary>
		/// <returns>True if the list has items; otherwise, false.</returns>
		[Pure]
		[Information(nameof(IsNotEmpty), "David McCarter", "8/27/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
		[Information(nameof(IsNotEmpty), "David McCarter", "8/27/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty(in int count)
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
		public T IndexAtLooped(in int index)
		{
			list = list.ArgumentNotNull();

			var count = list.Count;

			if (count == 0)
			{
				ExceptionThrower.ThrowArgumentException(Resources.CollectionIsEmpty, nameof(list));
			}

			return list[ListExtensionsHelper.ComputeWrappedIndex(index, count)];
		}

		/// <summary>
		/// Determines whether the current <see cref="List{T}"/> is equal to the specified list by comparing elements.
		/// </summary>
		/// <param name="collectionToCheck">
		/// The <see cref="List{T}"/> instance to compare with the current list.
		/// </param>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> used to compare elements.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// <c>true</c> if both lists contain the same number of elements and each corresponding element is equal;
		/// otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The comparison is performed in order and is based on the specified comparer, or the default equality
		/// comparison for type <typeparamref name="T"/> (that is, <see cref="EqualityComparer{T}.Default"/>) when
		/// no comparer is provided.
		/// </para>
		/// <para>
		/// If either the source list (<c>list</c>) or <paramref name="collectionToCheck"/> is <c>null</c>,
		/// the method returns <c>false</c>. If both references point to the same instance, the method returns <c>true</c>.
		/// </para>
		/// <para>
		/// For performance, this method uses <see cref="CollectionsMarshal.AsSpan{T}(List{T})"/> to obtain
		/// spans over the underlying list storage and then calls ReadOnlySpan{T}.SequenceEqual(ReadOnlySpan{T})
		/// to compare the contents without additional allocations.
		/// </para>
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEqualTo), author: "David McCarter", createdOn: "3/22/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsEqualTo([DisallowNull] List<T> collectionToCheck, [AllowNull] IEqualityComparer<T>? comparer = null)
		{
			if (collectionToCheck is null || list is null)
			{
				return false;
			}

			if (ListExtensionsHelper.ReferenceOrCountMismatch(list, collectionToCheck, out var sameRef))
			{
				return sameRef;
			}

			var span1 = CollectionsMarshal.AsSpan(list);
			var span2 = CollectionsMarshal.AsSpan(collectionToCheck);

			return span1.SequenceEqual(span2, comparer);
		}

		/// <summary>
		/// Performs the action for the items in the <see cref="List{T}" />.
		/// </summary>
		/// <param name="action">The action to perform on each item.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(PerformAction), "David McCarter", "1/4/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void PerformAction([DisallowNull] Action<T> action)
		{
			list = list.ArgumentNotNull();
			action = action.ArgumentNotNull();

			if (list.Count == 0)
			{
				return;
			}

			foreach (var item in list.AsSpan())
			{
				action(item);
			}
		}

		/// <summary>
		/// Removes the first occurrence of a specific item from the list.
		/// </summary>
		/// <param name="item">The item to remove.</param>
		/// <returns>True if the item was removed; otherwise, false.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method delegates directly to <see cref="List{T}.Remove(T)"/>
		/// which is optimized internally to perform both the search and removal in a single pass.
		/// </para>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Best case:</b> O(1) - Item is at the beginning of the list</description></item>
		/// <item><description><b>Average case:</b> O(n) - Single pass through the list</description></item>
		/// <item><description><b>Worst case:</b> O(n) - Item not found or at the end</description></item>
		/// <item><description><b>Memory shifting:</b> O(n - index) - Elements after removed item are shifted left</description></item>
		/// </list>
		/// <para>
		/// <b>Implementation Note:</b> This method uses <see cref="List{T}.Remove(T)"/> directly, which internally:
		/// </para>
		/// <list type="number">
		/// <item><description>Finds the index of the item using <see cref="EqualityComparer{T}.Default"/></description></item>
		/// <item><description>Shifts all subsequent elements one position to the left</description></item>
		/// <item><description>Decrements the list count</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 2, 4 };
		/// bool removed = numbers.RemoveFirst(2);  // true, list becomes { 1, 3, 2, 4 }
		/// bool removed2 = numbers.RemoveFirst(5); // false, item not found
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveFirst), author: "David McCarter", createdOn: "12/30/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool RemoveFirst(T item)
		{
			list = list.ArgumentNotNull();

			return list.Remove(item);
		}

		/// <summary>
		/// Removes the last occurrence of a specific item from the list.
		/// </summary>
		/// <param name="item">The item to remove.</param>
		/// <returns>True if the item was removed; otherwise, false.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses <see cref="List{T}.LastIndexOf(T)"/> 
		/// followed by <see cref="List{T}.RemoveAt(int)"/> for efficient removal of the last occurrence.
		/// </para>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Search:</b> O(n) - <see cref="List{T}.LastIndexOf(T)"/> scans backward from the end</description></item>
		/// <item><description><b>Removal:</b> O(n - index) - Elements after removed item are shifted left</description></item>
		/// <item><description><b>Best case:</b> O(1) - Item is at the end (no shifting needed)</description></item>
		/// <item><description><b>Worst case:</b> O(n) - Item is at the beginning (maximum shifting)</description></item>
		/// </list>
		/// <para>
		/// <b>Implementation Note:</b> Unlike <see cref="RemoveFirst"/>, there is no built-in 
		/// <c>RemoveLast()</c> method in <see cref="List{T}"/>, so this implementation uses:
		/// </para>
		/// <list type="number">
		/// <item><description><see cref="List{T}.LastIndexOf(T)"/> - Searches backward from the end using <see cref="EqualityComparer{T}.Default"/></description></item>
		/// <item><description><see cref="List{T}.RemoveAt(int)"/> - Removes at the found index if present</description></item>
		/// </list>
		/// <para>
		/// <b>Null Handling:</b> The method correctly handles null items. <see cref="List{T}.LastIndexOf(T)"/> 
		/// uses <see cref="EqualityComparer{T}.Default"/> which properly compares null values.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 2, 4 };
		/// bool removed = numbers.RemoveLast(2);  // true, list becomes { 1, 2, 3, 4 }
		/// bool removed2 = numbers.RemoveLast(5); // false, item not found
		/// 
		/// // Null handling example
		/// var items = new List&lt;string&gt; { "a", null, "b", null, "c" };
		/// bool removed3 = items.RemoveLast(null);  // true, removes last null, result: { "a", null, "b", "c" }
		/// 
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveLast), author: "David McCarter", createdOn: "12/30/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool RemoveLast(T item)
		{
			list = list.ArgumentNotNull();

			var index = list.LastIndexOf(item);

			if (index >= 0)
			{
				list.RemoveAt(index);
				return true;
			}

			return false;
		}

		/// <summary>
		/// Randomizes the order of elements in the current <see cref="List{T}"/> and returns a new shuffled list.
		/// </summary>
		/// <returns>
		/// A new <see cref="List{T}"/> containing the elements of the source list in randomized order.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The method shuffles the list in-place using a <see cref="Span{T}"/> view over the underlying
		/// storage for optimal performance, and then materializes the shuffled contents into a new list.
		/// The original <see cref="List{T}"/> is not preserved; its order is modified as part of the shuffle.
		/// </para>
		/// <para>
		/// <b>Performance characteristics (.NET 10):</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Time complexity:</b> O(n), where n is the number of elements.</description></item>
		/// <item><description><b>Space complexity:</b> O(n) for the returned list.</description></item>
		/// <item><description><b>Allocations:</b> One new list allocation for the result; the shuffle itself is allocation-free.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// var shuffled = numbers.FastShuffle();
		/// // Example result: { 3, 1, 5, 2, 4 }
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastShuffle), author: "David McCarter", createdOn: "12/30/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public List<T> FastShuffle()
		{
			list = list.ArgumentNotNull();

			return [.. list.Shuffle()];
		}

		/// <summary>
		/// Splits the current <see cref="List{T}"/> into multiple contiguous chunks of the specified size.
		/// </summary>
		/// <param name="size">
		/// The maximum number of elements in each chunk. Must be between 1 and the total number of items
		/// in the list; values outside this range cause an <see cref="ArgumentOutOfRangeException"/> to be thrown
		/// by the underlying validation helper.
		/// </param>
		/// <returns>
		/// A <see cref="ReadOnlyCollection{T}"/> of <see cref="ReadOnlyCollection{T}"/> instances,
		/// where each inner collection represents a contiguous segment of the original list.
		/// The final chunk may contain fewer than <paramref name="size"/> elements.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Internally, this method uses <see cref="List{T}.GetRange(int,int)"/> to create each chunk and
		/// wraps it with <see cref="List{T}.AsReadOnly"/>. The outer list of chunks is then wrapped as
		/// a read-only collection before being returned.
		/// </para>
		/// <para>
		/// <b>Performance characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Time complexity: O(n), where n is <c>list.Count</c>.</description></item>
		/// <item><description>Space complexity: O(n), due to per-chunk list allocations.</description></item>
		/// </list>
		/// <para>
		/// The original list is not modified; each chunk is a shallow copy of a contiguous range of elements.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5, 6, 7 };
		/// var chunks = numbers.Split(3);
		///
		/// // chunks[0] = { 1, 2, 3 }
		/// // chunks[1] = { 4, 5, 6 }
		/// // chunks[2] = { 7 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Split), author: "David McCarter", createdOn: "12/30/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<ReadOnlyCollection<T>> Split(int size)
		{
			list = list.ArgumentNotNull();
			size = size.ArgumentInRange(min: 1, max: list.Count);

			var listCount = list.Count;
			var chunks = (int)Math.Ceiling((double)listCount / size);
			var result = new List<ReadOnlyCollection<T>>(chunks);

			for (var index = 0; index < listCount; index += size)
			{
				var chunkSize = Math.Min(size, listCount - index);

				// GetRange creates a new List with internal optimizations and wraps it
				result.Add(list.GetRange(index, chunkSize).AsReadOnly());
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
		[Information(nameof(ToCollection), "David McCarter", "10/21/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public Collection<T> ToCollection()
		{
			return new Collection<T>(list);
		}

		/// <summary>
		/// Converts the list to a <see cref="DistinctBlockingCollection{T}"/>.
		/// </summary>
		/// <param name="completeAdding">Set to true if no more items will be added to this collection.</param>
		/// <returns>A <see cref="DistinctBlockingCollection{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToDistinctBlockingCollection), "David McCarter", "10/21/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public DistinctBlockingCollection<T> ToDistinctBlockingCollection(bool completeAdding = false)
		{
			list = list.ArgumentNotNull();

			var result = new DistinctBlockingCollection<T>(list);

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
		[Information(nameof(ToDistinctConcurrentBag), "David McCarter", "10/21/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public DistinctConcurrentBag<T> ToDistinctConcurrentBag()
		{
			list = list.ArgumentNotNull();

			return [.. list];
		}

		/// <summary>
		/// Converts the list to a <see cref="FastSortedList{T}"/>.
		/// </summary>
		/// <returns>A <see cref="FastSortedList{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFastSortedList), "David McCarter", "10/21/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public FastSortedList<T> ToFastSortedList()
		{
			list = list.ArgumentNotNull();

			return [.. list];
		}

		/// <summary>
		/// Converts the list to a <see cref="FastSortedList{T}"/> using the specified comparer.
		/// </summary>
		/// <param name="comparer">The comparer to use for sorting.</param>
		/// <returns>A <see cref="FastSortedList{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFastSortedList), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public FastSortedList<T> ToFastSortedList([DisallowNull] IComparer<T> comparer)
		{
			list = list.ArgumentNotNull();
			comparer = comparer.ArgumentNotNull();

			return new(list, comparer);
		}

		/// <summary>
		/// Converts the list to a <see cref="FrozenSet{T}"/>.
		/// </summary>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> used to determine element equality.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>A <see cref="FrozenSet{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			return FrozenSet.ToFrozenSet(list, comparer);
		}

		/// <summary>
		/// Converts the list to an <see cref="ImmutableArray{T}"/>.
		/// </summary>
		/// <returns>An <see cref="ImmutableArray{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToImmutableArray), "David McCarter", "12/3/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ImmutableArray<T> ToImmutableArray()
		{
			return ImmutableCollectionsMarshal.AsImmutableArray(list.ToArray());
		}

		/// <summary>
		/// Converts the list to a <see cref="List{T}"/> asynchronously, supporting cancellation.
		/// </summary>
		/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
		/// <returns>A task representing the asynchronous operation, with a <see cref="List{T}"/> result.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToListAsync), "David McCarter", "12/3/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public Task<List<T>> ToListAsync(CancellationToken cancellationToken = default)
		{
			list = list.ArgumentNotNull();

			cancellationToken.ThrowIfCancellationRequested();

			return Task.FromResult(new List<T>(list));
		}

		/// <summary>
		/// Converts the list to an <see cref="ObservableCollection{T}"/>.
		/// </summary>
		/// <returns>An <see cref="ObservableCollection{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToObservableCollection), "David McCarter", "11/21/2020", Status = Status.Available)]
		public ObservableCollection<T> ToObservableCollection()
		{
			return new(list);
		}

		/// <summary>
		/// Converts the list to an <see cref="ObservableList{T}"/>.
		/// </summary>
		/// <returns>An <see cref="ObservableList{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Obsolete("Use ToObservable() extension method instead. Method will be removed at the end of 2026.")]
		[Information(nameof(ToObservableList), "David McCarter", "10/21/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Obsolete)]
		public ObservableList<T> ToObservableList()
		{
			return list.ToObservable();
		}

		/// <summary>
		/// Converts the list to an <see cref="ObservableList{T}"/>.
		/// </summary>
		/// <returns>An <see cref="ObservableList{T}"/> containing the elements of the list.</returns>
		/// <exception cref="ArgumentNullException">Thrown if list is null.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToObservable), "David McCarter", "1/28/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ObservableList<T> ToObservable()
		{
			return [.. list];
		}

		/// <summary>
		/// Converts the list to an <see cref="IReadOnlyList{T}"/>.
		/// </summary>
		/// <returns>An <see cref="IReadOnlyList{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Obsolete("Use ToReadOnly() extension method instead. Method will be removed at the end of 2026.")]
		[Information(nameof(ToReadOnlyList), "David McCarter", "4/10/2022", Status = Status.Available)]
		public IReadOnlyList<T> ToReadOnlyList()
		{
			return list.ToReadOnly();
		}

		/// <summary>
		/// Converts the list to an <see cref="IReadOnlyList{T}"/>.
		/// </summary>
		/// <returns>An <see cref="IReadOnlyList{T}"/> containing the elements of the list.</returns>
		/// <exception cref="ArgumentNullException">Thrown if list is null.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToReadOnly), "David McCarter", "1/28/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public IReadOnlyList<T> ToReadOnly()
		{
			return list;
		}

		/// <summary>
		/// Converts the list to a <see cref="ReadOnlyObservableCollection{T}"/>.
		/// </summary>
		/// <returns>A <see cref="ReadOnlyObservableCollection{T}"/> containing the elements of the list.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToReadOnlyObservableCollection), "David McCarter", "11/26/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlyObservableCollection<T> ToReadOnlyObservableCollection()
		{
			return new(list.ToObservableCollection());
		}

	}
}
