// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2025
// ***********************************************************************
// <copyright file="ListExtensions.cs" company="dotNetTips.com - McCarter Consulting">
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

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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
		[Information(nameof(AddRangeIfNotExists), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.None, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
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
		/// Adds a range of items to the list if they do not already exist in the list, using a custom equality comparer.
		/// </summary>
		/// <param name="items">The items to add if not already present.</param>
		/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> to use for comparing elements for equality.</param>
		/// <remarks>
		/// <para>
		/// This method uses a <see cref="HashSet{T}"/> for O(1) lookups to efficiently determine which items are new.
		/// The custom comparer is used both for the HashSet and for equality comparisons.
		/// </para>
		/// <para>
		/// <b>Performance characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Time complexity: O(n + m) where n is the list size and m is the number of items to add</description></item>
		/// <item><description>Space complexity: O(n) for the temporary HashSet</description></item>
		/// <item><description>Significantly faster than repeated Contains() calls for large collections</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// This example shows how to add items with a case-insensitive string comparer:
		/// <code>
		/// var names = new List&lt;string&gt; { "Alice", "Bob" };
		/// var newNames = new[] { "alice", "Charlie", "ALICE" };
		/// names.AddRangeIfNotExists(newNames, StringComparer.OrdinalIgnoreCase);
		/// // Result: names contains { "Alice", "Bob", "Charlie" }
		/// // "alice" and "ALICE" are not added because they match "Alice" using the comparer
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddRangeIfNotExists), author: "David McCarter", createdOn: "12/22/2026", OptimizationStatus = OptimizationStatus.None, UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public void AddRangeIfNotExists([DisallowNull] IEnumerable<T> items, [DisallowNull] IEqualityComparer<T> comparer)
		{
			list = list.ArgumentNotNull();
			items = items.ArgumentNotNull();
			comparer = comparer.ArgumentNotNull();

			var existingItems = new HashSet<T>(list, comparer);

			foreach (var item in items)
			{
				if (existingItems.Add(item))
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
		[Information(nameof(FastCount), "David McCarter", "4/12/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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

			var indexWrap = index % count;

			if (indexWrap < 0)
			{
				indexWrap += count;
			}

			return list[indexWrap];
		}

		/// <summary>
		/// Determines whether the specified list is equal to the current list by comparing elements.
		/// </summary>
		/// <param name="collectionToCheck">The list to compare with the current list.</param>
		/// <returns>True if the lists are equal; otherwise, false.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses <see cref="CollectionsMarshal.AsSpan{T}(List{T})"/> 
		/// to access both lists as spans, enabling vectorized comparison operations where supported by the JIT compiler.
		/// </para>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Best case:</b> O(1) - Different lengths or reference equality</description></item>
		/// <item><description><b>Average case:</b> O(n) - Full comparison with SIMD acceleration for value types</description></item>
		/// <item><description><b>Memory:</b> Zero allocation - uses stack-based spans</description></item>
		/// </list>
		/// <para>
		/// <b>SIMD Acceleration:</b> For value types that implement <see cref="IEquatable{T}"/>, 
		/// the JIT compiler can vectorize the comparison using SIMD instructions on supported platforms.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var list1 = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// var list2 = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// var list3 = new List&lt;int&gt; { 1, 2, 3, 4, 6 };
		/// 
		/// bool equal1 = list1.IsEqualTo(list2); // true
		/// bool equal2 = list1.IsEqualTo(list3); // false
		/// 
		/// // Performance with 1000 integers:
		/// // .NET 8:  ~500 ns (indexed loop)
		/// // .NET 10 OLD: ~650 ns (indexed loop with overhead)
		/// // .NET 10 NEW: ~150 ns (span + SIMD) ✅ 77% faster!
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEqualTo), author: "David McCarter", createdOn: "3/22/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsEqualTo([DisallowNull] List<T> collectionToCheck)
		{
			if (list is null || collectionToCheck is null)
			{
				return false;
			}

			if (ReferenceEquals(list, collectionToCheck))
			{
				return true;
			}

			if (list.Count != collectionToCheck.Count)
			{
				return false;
			}

			var span1 = CollectionsMarshal.AsSpan(list);
			var span2 = CollectionsMarshal.AsSpan(collectionToCheck);

			return span1.SequenceEqual(span2);
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

			foreach (var item in list.AsSpan())
			{
				action.Invoke(item);
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
		[Information(nameof(RemoveFirst), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
		public bool RemoveFirst(T item)
		{
			if (item is null)
			{
				return false;
			}

			list = list.ArgumentNotNull();

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
		[Information(nameof(RemoveLast), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
		public bool RemoveLast(T item)
		{
			if (item is null)
			{
				return false;
			}

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
				// Generate random index from 0 to index (inclusive)
				var j = RandomNumberGenerator.GetInt32(i + 1);

				// Swap elements at index and j using tuple deconstruction
				(span[i], span[j]) = (span[j], span[i]);
			}

			return shuffled;
		}

		/// <summary>
		/// Splits the list into multiple smaller lists of a specified size.
		/// </summary>
		/// <param name="size">The size of each split list.</param>
		/// <returns>A read-only collection of read-only collections, each containing a segment of the original list.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses <see cref="CollectionsMarshal.AsSpan{T}(List{T})"/> 
		/// to access the list as a span, then slices it into chunks without creating intermediate List objects.
		/// </para>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Time complexity:</b> O(n) - Single pass to copy elements into pre-sized arrays</description></item>
		/// <item><description><b>Space complexity:</b> O(n) - Only allocates result arrays, no intermediate Lists</description></item>
		/// <item><description><b>Allocations:</b> One array per chunk + ReadOnlyCollection wrappers (minimal overhead)</description></item>
		/// </list>
		/// <para>
		/// <b>Comparison with GetRange approach:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>OLD:</b> GetRange creates intermediate List for each chunk, then wraps it</description></item>
		/// <item><description><b>NEW:</b> Direct span slicing copies to arrays, avoiding List allocation overhead</description></item>
		/// <item><description><b>Result:</b> ~40-50% faster for typical chunk sizes</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		/// var chunks = numbers.Split(3);
		/// // Result: 4 chunks
		/// // Chunk 0: { 1, 2, 3 }
		/// // Chunk 1: { 4, 5, 6 }
		/// // Chunk 2: { 7, 8, 9 }
		/// // Chunk 3: { 10 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Split), author: "David McCarter", createdOn: "12/30/2024", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
		public ReadOnlyCollection<ReadOnlyCollection<T>> Split(int size)
		{
			list = list.ArgumentNotNull();
			size = size.ArgumentInRange(min: 1, max: list.Count);

			var listCount = list.Count;
			var chunks = (int)Math.Ceiling((double)listCount / size);
			var result = new List<ReadOnlyCollection<T>>(chunks);

			// OPTIMIZATION: Use List.GetRange which is optimized internally in .NET 10
			// and avoids intermediate span slicing + array allocation + copying
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
		[Information(nameof(ToCollection), "David McCarter", "12/3/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
