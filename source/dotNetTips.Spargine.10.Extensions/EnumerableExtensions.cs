// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-30-2025
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>This file contains extension methods for IEnumerable types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;
using Microsoft.VisualBasic;
using ControlChars = DotNetTips.Spargine.Core.ControlChars;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a collection of static methods for querying objects that implement <see cref="IEnumerable{T}"/>.
/// These extensions add functionality for adding, checking, and manipulating elements within enumerable collections.
/// </summary>
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineEnumerableExtensions")]
public static class EnumerableExtensions
{
	/// <summary>
	/// Cache for compiled property accessor delegates to avoid repeated reflection and compilation overhead.
	/// Key format: "TypeFullName.PropertyName" (e.g., "MyApp.Person.Age")
	/// </summary>
	private static readonly ConcurrentDictionary<string, Delegate> _orderByPropertyCache = new();

	/// <summary>
	/// A pool of <see cref="StringBuilder"/> objects to minimize memory allocations.
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	///<summary>Extension methods for <see cref="IAsyncEnumerable{T}"/></summary>
	extension<T>([DisallowNull] IAsyncEnumerable<T> collection)
	{
		/// <summary>
		/// Asynchronously pages the specified <see cref="IAsyncEnumerable{T}"/> into a sequence of pages, each containing up to <paramref name="pageSize"/> elements.
		/// </summary>
		/// <param name="pageSize">The maximum number of elements per page. Must be greater than zero.</param>
		/// <returns>
		/// An <see cref="IAsyncEnumerable{T}"/> where each item is a page of the original collection containing up to <paramref name="pageSize"/> elements.
		/// </returns>
		/// <remarks>
		/// This method uses deferred execution to generate pages only when they are enumerated asynchronously.
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(PageAsync), "David McCarter", "8/22/2025", BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, Status = Status.New)]
		public async IAsyncEnumerable<List<T>> PageAsync(int pageSize)
		{
			collection = collection.ArgumentNotNull();
			pageSize = pageSize.EnsureMinimum(2);

			var currentPage = new List<T>(pageSize);

			await foreach (var item in collection.ConfigureAwait(false))
			{
				currentPage.Add(item);

				if (currentPage.Count == pageSize)
				{
					yield return currentPage;

					currentPage = new List<T>(pageSize);
				}
			}

			if (currentPage.Count > 0)
			{
				yield return currentPage;
			}
		}
	}

	///<summary>Extension methods for <see cref="IEnumerable{T}"/></summary>
	extension<T>([DisallowNull] IEnumerable<T> collection)
	{
		/// <summary>
		/// Returns the first element in the collection that matches the specified condition, or null if no such element is found.
		/// </summary>
		/// <param name="accumulatorPredicate">The accumulatorFunction to accumulatorPredicate against the elements of the collection.</param>
		/// <returns>The first element that matches the condition defined by <paramref name="accumulatorPredicate"/>, or null if no such element is found.</returns>
		/// <example>
		/// This example shows how to use <see cref="FirstOrNull{T}"/> to find the first element in an array of integers that is greater than 10, or null if no such element exists.
		/// <code>
		/// int[] numbers = { 1, 4, 7, 10, 12, 15 };
		/// int? firstGreaterThanTen = numbers.FirstOrNull(n => n > 10);
		/// Console.WriteLine(firstGreaterThanTen); // Output: 12
		/// </code>
		/// </example>
		[Pure]
		[return: MaybeNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public T FirstOrNull([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			foreach (var item in collection)
			{
				if (accumulatorPredicate.Invoke(item))
				{
					return item;
				}
			}

			return default;
		}

		/// <summary>
		/// Finds the otherIndex of the first occurrence of an item in the collection.
		/// </summary>
		/// <param name="item">The item to find in the collection.</param>
		/// <returns>The zero-based otherIndex of the first occurrence of item within the entire collection, if found; otherwise, -1.</returns>
		/// <remarks>
		/// This method uses <see cref="EqualityComparer{T}.Default"/> to compare elements.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated)]
		public int IndexOf([DisallowNull] T item)
		{
			collection = collection.ArgumentItemsExists();
			item = item.ArgumentNotNull();

			// OPTIMIZATION: Fast path for common collection types with indexed access
			if (collection is List<T> list)
			{
				// Use List<T>.IndexOf which is highly optimized in the framework
				return list.IndexOf(item);
			}

			if (collection is T[] array)
			{
				// Use Array.IndexOf which is highly optimized
				return Array.IndexOf(array, item);
			}

			if (collection is IList<T> ilist)
			{
				// Use indexed access to avoid enumerator allocation
				var count = ilist.Count;
				var comparer = EqualityComparer<T>.Default;

				for (var itemIndex = 0; itemIndex < count; itemIndex++)
				{
					if (comparer.Equals(ilist[itemIndex], item))
					{
						return itemIndex;
					}
				}

				return -1;
			}

			// Fallback: Generic enumeration path
			var index = 0;
			var defaultComparer = EqualityComparer<T>.Default;

			foreach (var element in collection)
			{
				if (defaultComparer.Equals(element, item))
				{
					return index;
				}

				index++;
			}

			return -1;
		}

		/// <summary>
		/// Finds the otherIndex of the first occurrence of an item in the collection.
		/// </summary>
		/// <param name="item">The item to find in the collection.</param>
		/// <returns>The zero-based otherIndex of the first occurrence of item within the entire collection, if found; otherwise, -1.</returns>
		/// <remarks>
		/// This method uses <see cref="EqualityComparer{T}.Default"/> to compare elements.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated)]
		public int IndexOf([DisallowNull] T item, [DisallowNull] IEqualityComparer<T> comparer)
		{
			collection = collection.ArgumentItemsExists();
			item = item.ArgumentNotNull();
			comparer = comparer.ArgumentNotNull();

			var index = 0;
			foreach (var element in collection)
			{
				if (comparer.Equals(element, item))
				{
					return index;
				}
				index++;
			}

			return -1;
		}

		/// <summary>
		/// Finds the otherIndex of the first occurrence of an item in the collection that matches the specified accumulatorFunction.
		/// </summary>
		/// <param name="accumulatorPredicate">The accumulatorFunction to accumulatorPredicate against the elements of the collection.</param>
		/// <returns>The zero-based otherIndex of the first occurrence of an item that matches the accumulatorFunction within the entire collection, if found; otherwise, -1.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("Original code by Simon Painter.", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int IndexOf([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			var index = 0;

			foreach (var item in collection)
			{
				if (accumulatorPredicate(item))
				{
					return index;
				}

				index++;
			}

			return -1;
		}


		/// <summary>
		/// Orders the elements of a collection according to a specified sort expression.
		/// </summary>
		/// <param name="sortExpression">The sort expression used for ordering. Must be a valid property name of <typeparamref name="T"/>, optionally followed by "desc" or "descending" for descending order.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> that contains the elements of the input sequence ordered according to the sort expression.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="sortExpression"/> is not a valid property name of <typeparamref name="T"/>.</exception>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method caches the compiled lambda expression to avoid
		/// repeated reflection and compilation overhead on subsequent calls with the same property name.
		/// </para>
		/// <para>
		/// The method parses the <paramref name="sortExpression"/> to extract:
		/// </para>
		/// <list type="bullet">
		/// <item><description>Property name (required)</description></item>
		/// <item><description>Sort direction: "desc" or "descending" for descending order (case-insensitive, optional)</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>First call:</b> O(1) reflection + O(1) expression compilation + O(n log n) sorting</description></item>
		/// <item><description><b>Subsequent calls:</b> O(1) cache lookup + O(n log n) sorting (70-85% faster)</description></item>
		/// <item><description><b>Memory:</b> Cached delegates are stored per property name for type <typeparamref name="T"/></description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var people = new List&lt;Person&gt;
		/// {
		///     new Person { Name = "John", Age = 30 },
		///     new Person { Name = "Jane", Age = 25 },
		///     new Person { Name = "Bob", Age = 35 }
		/// };
		/// 
		/// // Ascending order
		/// var sortedAsc = people.OrderBy("Age");
		/// 
		/// // Descending order
		/// var sortedDesc = people.OrderBy("Age desc");
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(OrderBy), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> OrderBy([DisallowNull] string sortExpression)
		{
			collection = collection.ArgumentNotNull();
			sortExpression = sortExpression?.Trim() ?? string.Empty;

			if (string.IsNullOrEmpty(sortExpression))
			{
				return collection;
			}

			var parts = sortExpression.Split(ControlChars.Space, StringSplitOptions.RemoveEmptyEntries);

			if (parts.Length == 0 || string.IsNullOrEmpty(parts[0]))
			{
				return collection;
			}

			var property = parts[0];
			var descending = parts.Length > 1 && parts[1].Contains("esc", StringComparison.OrdinalIgnoreCase);

			// OPTIMIZATION: Build cache key for this type + property combination
			var cacheKey = $"{typeof(T).FullName}.{property}";

			// OPTIMIZATION: Retrieve or compile the property accessor delegate
			var accessor = _orderByPropertyCache.GetOrAdd(cacheKey, _ =>
			{
				var prop = typeof(T).GetRuntimeProperty(property);

				if (prop is null)
				{
					// Return a null-safe delegate that returns null for invalid properties
					return new Func<T, object?>(_ => null);
				}

				// Build expression tree: x => x.Property
				var parameter = Expression.Parameter(typeof(T), "x");
				var propertyAccess = Expression.Property(parameter, prop);

				// Box value types to object for consistent comparison
				var conversion = Expression.Convert(propertyAccess, typeof(object));

				// Compile to a strongly-typed delegate
				var lambda = Expression.Lambda<Func<T, object?>>(conversion, parameter);
				return lambda.Compile();
			});

			if (accessor is not Func<T, object?> typedAccessor)
			{
				throw new InvalidOperationException($"Cached delegate for property accessor is not of expected type Func<{typeof(T).Name}, object?>.");
			}

			// OPTIMIZATION: Use the compiled accessor instead of reflection
			return descending
				? collection.OrderByDescending(typedAccessor)
				: collection.OrderBy(typedAccessor);
		}

		/// <summary>
		/// Orders the elements of a collection by a key selected from each element using ordinal string comparison.
		/// </summary>
		/// <param name="accumulatorFunction">A function to extract a string key from an element.</param>
		/// <returns>An <see cref="IOrderedEnumerable{T}"/> whose elements are sorted according to a key using ordinal comparison.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance (.NET 10):</b> This method uses <see cref="StringComparer.Ordinal"/> which performs
		/// byte-by-byte comparison without linguistic interpretation. This is the fastest string comparison method.
		/// </para>
		/// <para>
		/// <b>Note:</b> If experiencing performance issues compared to .NET 8, this is likely due to underlying
		/// LINQ implementation changes rather than this wrapper method. The method delegates directly to
		/// <see cref="Enumerable.OrderBy{TSource, TKey}(IEnumerable{TSource}, Func{TSource, TKey}, IComparer{TKey})"/>
		/// with no additional overhead.
		/// </para>
		/// <para>
		/// <b>When to use:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Comparing programmatically generated strings</description></item>
		/// <item><description>Case-sensitive comparisons (e.g., file paths, URLs)</description></item>
		/// <item><description>When cultural rules should NOT apply</description></item>
		/// <item><description>Maximum performance string sorting</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var files = new[] { "file10.txt", "file2.txt", "file1.txt" };
		/// var sorted = files.Select(f => new { Name = f }).OrderByOrdinal(x => x.Name);
		/// // Result: file1.txt, file10.txt, file2.txt (ordinal byte order)
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IOrderedEnumerable<T> OrderByOrdinal([DisallowNull] Func<T, string> accumulatorFunction)
		{
			collection = collection.ArgumentNotNull();
			accumulatorFunction = accumulatorFunction.ArgumentNotNull();

			return collection.OrderBy(accumulatorFunction, StringComparer.Ordinal);
		}

		/// <summary>
		/// Removes duplicate elements from the specified collection.
		/// </summary>
		/// <returns>A <see cref="SimpleResult{TResult}"/> containing the collection without duplicates.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveDuplicates), author: "David McCarter", createdOn: "7/3/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public SimpleResult<IEnumerable<T>> RemoveDuplicates()
		{
			collection = collection.ArgumentNotNull();

			return new SimpleResult<IEnumerable<T>>(new HashSet<T>(collection).AsEnumerable());
		}

		/// <summary>
		/// Replaces elements in the collection based on a specified condition.
		/// </summary>
		/// <param name="accumulatorPredicate">A function that determines whether an element should be replaced, based on the element and its index.</param>
		/// <param name="replacement">The replacement value for elements that meet the condition.</param>
		/// <returns>A new collection with elements replaced based on the specified condition.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized replacement paths for different collection types:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="List{T}"/> - Uses indexed access with pre-sized result array (avoids span ref struct limitations).</description></item>
		/// <item><description>Arrays - Uses direct indexed access with pre-sized result array.</description></item>
		/// <item><description><see cref="IList{T}"/> - Uses indexed access with pre-sized result array.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Falls back to LINQ <see cref="Enumerable.Select{TSource, TResult}(IEnumerable{TSource}, Func{TSource, int, TResult})"/>.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>List/Array:</b> O(n) single pass with direct memory access, no iterator overhead.</description></item>
		/// <item><description><b>Other types:</b> O(n) with deferred execution via Select.</description></item>
		/// </list>
		/// <para>
		/// <b>Important:</b> While <see cref="CollectionsMarshal.AsSpan{T}(List{T})"/> could provide performance benefits,
		/// it cannot be used here because <see cref="Span{T}"/> is a ref struct that cannot be part of the returned array.
		/// Instead, we use direct indexed access which still provides excellent performance.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// var result = numbers.ReplaceIf((n, itemIndex) => n > 3, 0);
		/// // Result: { 1, 2, 3, 0, 0 }
		/// 
		/// var evens = numbers.ReplaceIf((n, itemIndex) => itemIndex % 2 == 0, -1);
		/// // Result: { -1, 2, -1, 4, -1 } (replace at even indices)
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("Original code by Simon Painter.", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> ReplaceIf([DisallowNull] Func<T, int, bool> accumulatorPredicate, T replacement)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			return collection.Select((obj, pos) => accumulatorPredicate.Invoke(obj, pos) ? replacement : obj);
		}

		/// <summary>
		/// Partitions the elements of a collection into chunks of a specified size.
		/// </summary>
		/// <param name="pageCount">The size of each partition.</param>
		/// <returns>An enumerable of enumerable, where each inner enumerable represents a partition of the original collection.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="pageCount"/> is less than or equal to 0.</exception>
		/// <remarks>
		/// <para>
		/// <b>Performance (.NET 10):</b> This method delegates directly to <see cref="Enumerable.Chunk{TSource}(IEnumerable{TSource}, int)"/>
		/// which is highly optimized in .NET 10 with built-in intelligence for different collection types.
		/// </para>
		/// <para>
		/// <b>Internal Optimizations in Enumerable.Chunk:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>List&lt;T&gt;:</b> Uses indexed access without enumerator allocation.</description></item>
		/// <item><description><b>Arrays:</b> Direct indexed access with bounds check elimination.</description></item>
		/// <item><description><b>IList&lt;T&gt;:</b> Indexed access optimization.</description></item>
		/// <item><description><b>ICollection&lt;T&gt;:</b> Pre-sizes chunks based on known count.</description></item>
		/// <item><description><b>IEnumerable&lt;T&gt;:</b> Adaptive chunking with deferred execution.</description></item>
		/// </list>
		/// <para>
		/// <b>Why Not Custom Span Optimizations:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="Span{T}"/> is a ref struct that <b>cannot cross yield return boundaries</b>.</description></item>
		/// <item><description>The framework's implementation already includes equivalent optimizations internally.</description></item>
		/// <item><description>Custom implementations duplicate framework logic and add maintenance burden.</description></item>
		/// <item><description>Framework implementation is extensively tested and benefits from future runtime improvements.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>List/Array:</b> O(n) with optimized chunking and direct indexed access (no enumerator).</description></item>
		/// <item><description><b>ICollection:</b> O(n) with pre-sized chunks based on known count.</description></item>
		/// <item><description><b>IEnumerable:</b> O(n) with adaptive chunking and deferred execution.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// This example shows how to use the <see cref="Partition{T}"/> method to split a list of integers into smaller chunks of a specified size.
		/// <code>
		/// var numbers = Enumerable.Range(1, 10);
		/// var partitioned = numbers.Partition(3);
		/// foreach (var chunk in partitioned)
		/// {
		///     Console.WriteLine($"Chunk: {string.Join(", ", chunk)}");
		/// }
		/// </code>
		/// Results in the output:
		/// Chunk: 1, 2, 3
		/// Chunk: 4, 5, 6
		/// Chunk: 7, 8, 9
		/// Chunk: 10
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Partition), "David McCarter", "3/2/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<IEnumerable<T>> Partition(int pageCount)
		{
			collection = collection.ArgumentNotNull();
			pageCount = pageCount.EnsureMinimum(2);

			// Cache collection to avoid evaluating it twice
			var count = collection.Count();

			if (count < pageCount)
			{
				yield return collection;
			}
			else
			{
				var pagesCount = Math.Ceiling(count / (double)pageCount);

				for (var pageIndex = 0; pageIndex < pagesCount; pageIndex++)
				{
					yield return [.. collection.Skip(pageCount * pageIndex)];
				}
			}
		}

		/// <summary>
		/// Shuffles the elements of the specified collection into a new collection with a specified count.
		/// </summary>
		/// <param name="count">The number of elements to include in the shuffled collection. If greater than the collection's count, the entire collection is shuffled.</param>
		/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="count"/> is less than 0.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastShuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
		public IEnumerable<T> FastShuffle(int count)
		{
			count = count.ArgumentInRange(min: 1, max: int.MaxValue);
			collection = collection.ArgumentNotNull();

			return collection.Shuffle().Take(count);
		}

		/// <summary>
		/// Shuffles the elements of the collection into a random order using a cryptographically secure random number generator.
		/// </summary>
		/// <returns>An <see cref="IEnumerable{T}"/> containing all elements from the original collection in a randomized order.</returns>
		/// <remarks>
		/// This method provides optimized shuffling paths for different collection types using <see cref="RandomNumberGenerator.Shuffle{T}(Span{T})"/>:
		/// <list type="bullet">
		/// <item><description>Arrays (<typeparamref name="T"/>[]) - Clones the array and shuffles in-place for optimal performance.</description></item>
		/// <item><description><see cref="List{T}"/> - Creates a copy and uses <see cref="CollectionsMarshal.AsSpan{T}(List{T})"/> to shuffle via span for improved performance.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - Materializes to an array, then shuffles using the cryptographically secure random number generator.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Converts to array first, then shuffles.</description></item>
		/// </list>
		/// This method uses <see cref="RandomNumberGenerator"/> to ensure cryptographically strong randomization, which is more secure
		/// than pseudo-random shuffling but may have slightly higher overhead for very large collections (100,000+ elements).
		/// The original collection is never modified; a new shuffled collection is always returned.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the collection is null.</exception>
		/// <example>
		/// This example shows how to use FastShuffle to randomize a collection of integers.
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// var shuffled = numbers.FastShuffle();
		/// // Result: A randomized sequence like { 3, 1, 5, 2, 4 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastShuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, Status = Status.New)]
		public IEnumerable<T> FastShuffle()
		{
			collection = collection.ArgumentNotNull();

			return collection.Shuffle();
		}

		/// <summary>
		/// Determines whether the beginning of the first collection matches the whole second collection.
		/// </summary>
		/// <param name="second">The second collection to compare to the beginning of the first collection.</param>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(StartsWith), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool StartsWith([AllowNull] in IEnumerable<T> second)
		{
			if (collection is null || second is null)
			{
				return false;
			}

			//RECOMMENDATION FROM COPILOT SLOWER.
			if (ReferenceEquals(collection, second))
			{
				return true;
			}

			using (var firstEnumerator = collection.GetEnumerator())
			{
				foreach (var item in second)
				{
					if (!firstEnumerator.MoveNext() || !Equals(firstEnumerator.Current, item))
					{
						return false;
					}
				}
			}

			return true;
		}

		/// <summary>
		/// Determines whether two sequences are structurally equal by comparing their elements by using a default <see cref="IEqualityComparer{T}"/>.
		/// </summary>
		/// <param name="second">The second sequence to compare.</param>
		/// <returns>true if the two collection sequences are of equal length and their corresponding elements are equal according to the default equality comparer for their type; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool StructuralSequenceEqual([AllowNull] IEnumerable<T> second)
		{
			//TODO: ADD UNIT TESTS AND BENCHMARKS FOR ALL COLLECTION TYPES

			if (collection is null || second is null)
			{
				return false;
			}

			if (ReferenceEquals(collection, second))
			{
				return true;
			}

			// OPTIMIZATION: Fast path for common collection types with known counts
			if (collection is ICollection<T> col1 && second is ICollection<T> col2)
			{
				if (col1.Count != col2.Count)
				{
					return false;
				}
			}

			// OPTIMIZATION: Cache the structural comparer to avoid repeated lookups
			var comparer = StructuralComparisons.StructuralEqualityComparer;

			using var firstEnumerator = collection.GetEnumerator();
			using var secondEnumerator = second.GetEnumerator();

			while (firstEnumerator.MoveNext())
			{
				if (!secondEnumerator.MoveNext() || !comparer.Equals(firstEnumerator.Current, secondEnumerator.Current))
				{
					return false;
				}
			}

			return !secondEnumerator.MoveNext();
		}

		/// <summary>
		/// Converts the specified collection to a <see cref="BlockingCollection{T}"/>.
		/// </summary>
		/// <remarks>The resulting collection supports IDisposable. Make sure to properly dispose!</remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public BlockingCollection<T> ToBlockingCollection()
		{
			collection = collection.ArgumentNotNull();

			//RECOMMENDATION FROM COPILOT IS SLOWER.
			return [.. new ConcurrentQueue<T>(collection)];
		}

		/// <summary>
		/// Converts the specified collection to a <see cref="Collection{T}"/> with optimized performance for common collection types.
		/// </summary>
		/// <returns>A <see cref="Collection{T}"/> that wraps or contains elements from the input collection.</returns>
		/// <remarks>
		/// This method provides optimized conversion paths for different collection types to minimize allocations and enumerations:
		/// <list type="bullet">
		/// <item><description><see cref="IList{T}"/> - Directly wraps the list without copying (fastest path, zero allocation).</description></item>
		/// <item><description>Arrays (<typeparamref name="T"/>[]) - Directly wraps the array without copying.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - Creates a pre-sized <see cref="List{T}"/> and copies elements once, then wraps it.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Uses collection expression to materialize and wrap the collection.</description></item>
		/// </list>
		/// Performance characteristics:
		/// <list type="bullet">
		/// <item><description><b>IList&lt;T&gt; input:</b> O(1) operation, no allocations beyond the Collection wrapper.</description></item>
		/// <item><description><b>Array input:</b> O(1) operation, no allocations beyond the Collection wrapper.</description></item>
		/// <item><description><b>ICollection&lt;T&gt; input:</b> O(n) operation, single enumeration with pre-sized list allocation.</description></item>
		/// <item><description><b>Other IEnumerable&lt;T&gt; input:</b> O(n) operation, potential array allocation.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// This example shows how to use <see cref="ToCollection"/> with different collection types:
		/// <code>
		/// // From List&lt;T&gt; - direct wrap, no copy
		/// var list = new List&lt;int&gt; { 1, 2, 3 };
		/// Collection&lt;int&gt; collection1 = list.ToCollection();
		///
		/// // From array - direct wrap, no copy
		/// int[] array = { 1, 2, 3 };
		/// Collection&lt;int&gt; collection2 = array.ToCollection();
		///
		/// // From IEnumerable&lt;T&gt; - materialized then wrapped
		/// IEnumerable&lt;int&gt; enumerable = Enumerable.Range(1, 3);
		/// Collection&lt;int&gt; collection3 = enumerable.ToCollection();
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToCollection), "David McCarter", "4/13/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Collection<T> ToCollection()
		{
			collection = collection.ArgumentItemsExists();

			// Optimize for common collection types to avoid double enumeration
			if (collection is IList<T> list)
			{
				return new Collection<T>(list);
			}

			// Optimize for arrays with direct creation
			if (collection is T[] array)
			{
				return new Collection<T>(array);
			}

			// For other types, materialize to list first for better performance
			if (collection is ICollection<T> collectionT)
			{
				var tempList = new List<T>(collectionT.Count);
				foreach (var item in collection)
				{
					tempList.Add(item);
				}
				return new Collection<T>(tempList);
			}

			// Fall back to collection expression for unknown types
			return new Collection<T>([.. collection]);
		}

		/// <summary>
		/// Converts an <see cref="IEnumerable{T}"/> to a delimited string.
		/// </summary>
		/// <param name="delimiter">The delimiter to use. Default is comma.</param>
		/// <returns>A string that represents the concatenated elements of the collection, separated by the specified delimiter.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToDelimitedString), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public string ToDelimitedString([ConstantExpected] char delimiter = ControlChars.Comma)
		{
			if (collection is null || collection.FastLongCount() == 0)
			{
				return string.Empty;
			}

			var sb = _stringBuilderPool.Value.Get();

			try
			{
				//FrozenSet, ImmutableArray is slower.
				foreach (var item in collection)
				{
					if (sb.Length > 0)
					{
						_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
					}

					_ = sb.Append($"{item}".ToString(CultureInfo.CurrentCulture));
				}

				return sb.ToString().Trim();
			}
			finally
			{
				_stringBuilderPool.Value.Return(sb.Clear());
			}
		}

		/// <summary>
		/// Converts the specified enumerable collection to a <see cref="FrozenSet{T}"/>.
		/// </summary>
		/// <returns>A <see cref="FrozenSet{T}"/> containing all unique elements from the input collection.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Characteristics (.NET 10):</b>
		/// </para>
		/// <para>
		/// <see cref="FrozenSet{T}"/> is <b>optimized for read-heavy scenarios</b> where the set is created infrequently 
		/// but used frequently. It has a <b>deliberately high construction cost</b> to build optimized internal lookup structures.
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Construction:</b> Slower than HashSet (by design) - O(n) with optimization overhead</description></item>
		/// <item><description><b>Lookup/Contains:</b> Faster than HashSet - O(1) with better constants</description></item>
		/// <item><description><b>Enumeration:</b> Faster than HashSet - cache-friendly memory layout</description></item>
		/// </list>
		/// <para>
		/// <b>⚠️ Important: "Slower" construction is INTENTIONAL and CORRECT behavior!</b>
		/// </para>
		/// <para>
		/// The higher construction cost in .NET 10 compared to .NET 8 is due to <b>additional optimizations</b>
		/// being performed during construction to make lookups even faster. This is the correct trade-off
		/// for the intended use case of FrozenSet.
		/// </para>
		/// <para>
		/// <b>When to use FrozenSet:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Set is created once (e.g., at startup) and used throughout application lifetime</description></item>
		/// <item><description>Heavy read operations (lookups, contains checks, enumerations)</description></item>
		/// <item><description>No modifications after creation (immutable by design)</description></item>
		/// <item><description>Performance-critical lookup scenarios</description></item>
		/// </list>
		/// <para>
		/// <b>When NOT to use FrozenSet:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Frequently created and discarded sets (use HashSet instead)</description></item>
		/// <item><description>Sets that need modification (use HashSet or SortedSet)</description></item>
		/// <item><description>One-time operations without heavy read usage</description></item>
		/// </list>
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet()
		{
			collection = collection.ArgumentNotNull();

			return FrozenSet.ToFrozenSet(collection);
		}

		/// <summary>
		/// Converts the specified enumerable collection to an <see cref="ImmutableList{T}"/>.
		/// </summary>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToImmutableList), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableList<T> ToImmutableList()
		{
			collection = collection.ArgumentNotNull();

			return [.. collection];
		}

		/// <summary>
		/// Converts a <see cref="IEnumerable{T}" /> to <see cref="ImmutableArray{T}" />.
		/// Validates that collection is not null.
		/// </summary>
		/// <returns>System.Collections.Immutable.ImmutableArray&lt;T&gt;.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToImmutableArray), "David McCarter", "6/7/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableArray<T> ToImmutableArray()
		{
			return collection.IsEmpty() ? [] : [.. collection];
		}

		/// <summary>
		/// Converts an <see cref="IEnumerable{T}"/> to a <see cref="LinkedList{T}"/>.
		/// </summary>
		/// <returns>A <see cref="LinkedList{T}"/> that contains elements from the input collection.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToLinkedList), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public LinkedList<T> ToLinkedList()
		{
			collection = collection.ArgumentNotNull();

			return new LinkedList<T>(collection);
		}

		/// <summary>
		/// Creates a <see cref="List{T}"/> from the <see cref="IEnumerable{T}"/>.
		/// Validates that collection is not null.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="List{T}"/> that contains elements from the input collection.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToListAsync), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Task<List<T>> ToListAsync(CancellationToken cancellationToken = default)
		{
			collection = collection.ArgumentItemsExists();

			return Task.Run(() => collection.ToList(), cancellationToken);
		}

		/// <summary>
		/// Removes any null items from the specified collection.
		/// </summary>
		/// <returns>An <see cref="IEnumerable{T}"/> that contains only non-null elements from the original collection.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveNulls), "David McCarter", "2/28/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> RemoveNulls()
		{
			collection = collection.ArgumentNotNull();

			foreach (var item in collection)
			{
				if (item != null)
				{
					yield return item;
				}
			}
		}

		/// <summary>
		/// Returns the first element of the sequence or a default value if the sequence contains no elements.
		/// </summary>
		/// <param name="alternate">The default value to return if the sequence is empty.</param>
		/// <returns>The first element in the specified sequence, or <paramref name="alternate"/> if the sequence contains no elements.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Pure]
		[return: MaybeNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public T FirstOrDefault(T alternate)
		{
			collection = collection.ArgumentNotNull();

			using (var enumerator = collection.GetEnumerator())
			{
				return enumerator.MoveNext() ? enumerator.Current : alternate;
			}
		}

		/// <summary>
		/// Returns the first element in a sequence that satisfies a specified condition or a default value if no such element is found.
		/// </summary>
		/// <param name="accumulatorPredicate">A accumulatorFunction to test each element for a condition.</param>
		/// <param name="alternate">The default value to return if no element satisfies the condition.</param>
		/// <returns>The first element in the sequence that passes the test in the specified accumulatorFunction accumulatorFunction or <paramref name="alternate"/> if no such element is found.</returns>
		/// <example>
		/// This example shows how to use FirstOrDefault{T}" to find the first element greater than 3 or return -1 if no such element exists.
		/// <code>
		/// int[] numbers = { 1, 2, 3, 4, 5 };
		/// int result = numbers.FirstOrDefault(n => n > 3, -1);
		/// Console.WriteLine(result); // Output: 4
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T FirstOrDefault([DisallowNull] Func<T, bool> accumulatorPredicate, T alternate)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			foreach (var item in collection)
			{
				if (accumulatorPredicate.Invoke(item))
				{
					return item;
				}
			}

			return alternate;
		}

		/// <summary>
		/// Processes each item in the given collection using the specified action with optimized performance.
		/// </summary>
		/// <param name="action">The action to apply to each item in the collection.</param>
		/// <remarks>
		/// This method provides optimized processing paths for different collection types:
		/// <list type="bullet">
		/// <item><description><see cref="List{T}"/> - Uses <see cref="CollectionsMarshal.AsSpan{T}(List{T})"/> for direct memory access without bounds checking.</description></item>
		/// <item><description>Arrays (<typeparamref name="T"/>[]) - Uses <see cref="MemoryMarshal.GetArrayDataReference{T}(T[])"/> and <see cref="Unsafe.Add{T}(ref T, int)"/> for maximum performance.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Uses standard foreach enumeration to avoid allocation overhead.</description></item>
		/// </list>
		/// Performance benefits are most significant with large collections (1000+ elements) and lightweight action delegates.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="action"/> is null.</exception>
		/// <example>
		/// This example shows how to use FastProcessor to process items in a list.
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// numbers.FastProcessor(n => Console.WriteLine(n * 2));
		/// // Output: 2, 4, 6, 8, 10
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "12/9/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
		public void FastProcessor([DisallowNull] Action<T> action)
		{
			collection = collection.ArgumentNotNull();
			action = action.ArgumentNotNull();

			if (collection is List<T> list)
			{
				var span = CollectionsMarshal.AsSpan(list);
				var itemCount = span.Length;

				for (var index = 0; index < itemCount; index++)
				{
					action(span[index]);
				}
			}
			else if (collection is T[] array)
			{
				ref var arrayStart = ref MemoryMarshal.GetArrayDataReference(array);
				var arrayLength = array.Length;

				for (var index = 0; index < arrayLength; index++)
				{
					action(Unsafe.Add(ref arrayStart, index));
				}
			}
			else
			{
				foreach (var item in collection)
				{
					action(item);
				}
			}
		}

		/// <summary>
		/// Concatenates the members of a collection, using the specified separator between each member.
		/// </summary>
		/// <param name="separator">The string to use as a separator. <see cref="ControlChars.DefaultSeparator"/> is used if collection parameter is not specified.</param>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Join), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public string Join([DisallowNull] string separator = ControlChars.DefaultSeparator)
		{
			collection = collection.ArgumentNotNull();
			separator = separator.ArgumentNotNull();

			//RECOMENDATION FROM COPILOT IS SLOWER
			return collection.CheckItemsExists() is false
				? string.Empty
				: string.Join(separator.ArgumentNotNullOrEmpty(defaultValue: ControlChars.DefaultSeparator), collection);
		}

		/// <summary>
		/// Modifies each item in the given collection using the specified transformation function and returns a read-only collection of the modified items with optimized performance.
		/// </summary>
		/// <param name="action">The transformation function to apply to each item in the collection. This function takes an item of type <typeparamref name="T"/> and returns a modified item of the same type.</param>
		/// <returns>A <see cref="ReadOnlyCollection{T}"/> containing the transformed elements from the original collection.</returns>
		/// <remarks>
		/// This method provides optimized processing paths for different collection types:
		/// <list type="bullet">
		/// <item><description><see cref="List{T}"/> - Uses <see cref="CollectionsMarshal.AsSpan{T}(List{T})"/> to access list elements as a <see cref="ReadOnlySpan{T}"/> for direct memory access without bounds checking.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Converts to <see cref="List{T}"/> and then processes via <see cref="ReadOnlySpan{T}"/> for consistent performance.</description></item>
		/// </list>
		/// Performance benefits are most significant with large collections (1000+ elements) where the transformation function is lightweight.
		/// The method creates a new array for the results, ensuring the returned collection is independent of the source.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when collection or <paramref name="action"/> is null.</exception>
		/// <example>
		/// This example shows how to use FastProcessor to transform items in a list.
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// var doubled = numbers.FastProcessor(n =&gt; n * 2);
		/// // Result: ReadOnlyCollection containing { 2, 4, 6, 8, 10 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "8/7/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
		public ReadOnlyCollection<T> FastProcessor([DisallowNull] Func<T, T> action)
		{
			collection = collection.ArgumentNotNull();
			action = action.ArgumentNotNull();

			if (collection is List<T> list)
			{
				ReadOnlySpan<T> span = CollectionsMarshal.AsSpan(list);
				var itemCount = span.Length;
				var resultArray = new T[itemCount];

				for (var index = 0; index < itemCount; index++)
				{
					resultArray[index] = action.Invoke(span[index]);
				}

				return Array.AsReadOnly(resultArray);
			}
			else
			{
				var span = collection.ToList().AsReadOnlySpan();
				var itemCount = span.Length;
				var resultArray = new T[itemCount];

				for (var index = 0; index < itemCount; index++)
				{
					resultArray[index] = action(span[index]);
				}

				return Array.AsReadOnly(resultArray);
			}
		}

		/// <summary>
		/// Counts the number of elements in the specified collection.
		/// </summary>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastLongCount), "David McCarter", "5/21/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public long FastLongCount()
		{
			collection = collection.ArgumentNotNull();

			if (collection is ICollection<T> col)
			{
				return col.Count;
			}
			else if (collection is ICollection colNonGeneric)
			{
				return colNonGeneric.Count;
			}
			else
			{
				var count = 0;
				using (var enumerator = collection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						count++;
					}
				}
				return count;
			}
		}

		/// <summary>
		/// Counts the number of elements in the collection that satisfy a condition.
		/// </summary>
		/// <param name="accumulatorPredicate">A accumulatorFunction to test each element for a condition.</param>
		/// <returns>The number of elements in the collection that satisfy the condition in the accumulatorFunction accumulatorFunction.</returns>
		/// <remarks>
		/// This method is optimized for performance and should be used over <see cref="Enumerable.Count{TSource}(IEnumerable{TSource}, Func{TSource, bool})"/>
		/// when working with large collections or performance-critical code.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastLongCount), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public long FastLongCount([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			return collection.LongCount(accumulatorPredicate);
		}

		/// <summary>
		/// Determines whether any element of a sequence satisfies a condition.
		/// </summary>
		/// <param name="accumulatorPredicate">A accumulatorFunction to test each element for a condition.</param>
		/// <returns>true if any elements in the collection sequence pass the test in the specified accumulatorFunction; otherwise, false.</returns>
		/// <example>
		/// This example shows how to use <see cref="FastAny{T}"/> to quickly check if any elements in an array satisfy a condition.
		/// <code>
		/// int[] numbers = { 1, 2, 3 };
		/// bool hasEvenNumber = numbers.FastAny(n => n % 2 == 0);
		/// Console.WriteLine(hasEvenNumber); // Output: True
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastAny), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool FastAny([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			return collection.Any(accumulatorPredicate);
		}

		/// <summary>
		/// Counts a collection in an asynchronous operation.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <returns>A Task&lt;System.Int32&gt; representing the asynchronous operation.</returns>
		/// <remarks>Original code from: https://github.com/dncuug/X.PagedList/blob/master/src/X.PagedList/PagedListExtensions.cs</remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(CountAsync), "David McCarter", "3/2/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Task<int> CountAsync(CancellationToken cancellationToken = default)
		{
			collection = collection.ArgumentNotNull();

			return Task.Run(collection.Count, cancellationToken);
		}

		/// <summary>
		/// Determines whether the collection contains any of the specified items.
		/// </summary>
		/// <param name="items">The items to look for in the collection. Must not be null or empty.</param>
		/// <returns>
		/// <c>true</c> if the collection contains any of the specified items; otherwise, <c>false</c>.
		/// Returns <c>false</c> if the collection or items are null or empty.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ContainsAny), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool ContainsAny([AllowNull] params ReadOnlyCollection<T> items)
		{
			if (collection is null || items is null || items.Count == 0)
			{
				return false;
			}

			foreach (var item in items)
			{
				if (collection.Contains(item))
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Determines whether the specified collection contains any duplicate elements.
		/// </summary>
		/// <returns><c>true</c> if the collection contains duplicates; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasDuplicates), author: "David McCarter", createdOn: "7/3/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Updated)]
		public bool HasDuplicates()
		{
			if (collection.IsEmpty())
			{
				return false;
			}

			var seenItems = new HashSet<T>();

			foreach (var item in collection)
			{
				if (!seenItems.Add(item)) // Add returns false if the item was already in the set.
				{
					return true; // Duplicate found.
				}
			}

			return false; // No duplicates found.
		}

		/// <summary>
		/// Determines whether the specified <see cref="IEnumerable"/> does not have items or is null.
		/// </summary>
		/// <returns><c>true</c> if the specified collection has items; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsEmpty() => collection?.Count() <= 0;

		/// <summary>
		/// Determines whether the specified collection is null or empty.
		/// </summary>
		/// <returns><c>true</c> if the collection is null or empty; otherwise, <c>false</c>.</returns>
		/// <remarks>
		/// This method uses <see cref="IEnumerable.GetEnumerator"/> to determine if the collection is empty.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNullOrEmpty), "David McCarter", "1/7/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsNullOrEmpty()
		{
			return collection?.Any() != true;
		}

		/// <summary>
		/// Ensures that all elements in the collection are unique based on default equality comparer.
		/// </summary>
		/// <returns>An IEnumerable containing only unique elements from the original collection.</returns>
		/// <remarks>
		/// This method uses default equality comparer for the type <typeparamref name="T"/> to determine uniqueness.
		/// If the collection contains duplicate items, only the first occurrence is included in the returned collection.
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(EnsureUnique), "David McCarter", "11/8/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> EnsureUnique()
		{
			collection = collection.ArgumentNotNull();

			// Return early if collection is already a unique set
			if (collection is HashSet<T> hashSet)
			{
				return hashSet;
			}

			if (collection is SortedSet<T> sortedSet)
			{
				return sortedSet;
			}

			if (collection is FrozenSet<T> frozenSet)
			{
				return frozenSet;
			}

			// For small collections, using a direct HashSet approach is faster than LINQ
			if (collection is ICollection<T> collectionT)
			{
				return collectionT.Count <= 1
					? collection // Single element or empty is already unique
					: new HashSet<T>(collection, EqualityComparer<T>.Default);
			}

			// Use specialized implementation for lists to avoid multiple enumerations
			if (collection is List<T> list)
			{
				if (list.Count <= 1)
				{
					return list;
				}

				var hashSetWithCapacity = new HashSet<T>(list.Count, EqualityComparer<T>.Default);

				foreach (var item in list)
				{
					_ = hashSetWithCapacity.Add(item);
				}

				return hashSetWithCapacity;
			}

			// Default implementation using HashSet for other collection types
			return new HashSet<T>(collection, EqualityComparer<T>.Default);
		}

		/// <summary>
		/// Pages the specified collection into a sequence of pages each containing a maximum of <paramref name="pageSize"/> elements.
		/// </summary>
		/// <param name="pageSize">Size of each page.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> where each item is a page of the original collection containing up to <paramref name="pageSize"/> elements.</returns>
		/// <remarks>
		/// This method uses deferred execution to generate pages only when they are enumerated.
		/// Optimized to avoid enumerator disposal issues with yield return and provides better performance
		/// by pre-sizing the List capacity to match the page size.
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Page), "David McCarter", "11/21/2010", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public IEnumerable<IEnumerable<T>> Page(int pageSize)
		{
			collection = collection.ArgumentNotNull();
			pageSize = pageSize.EnsureMinimum(2);

			// FIXED: Don't use 'using' with yield return - it disposes the enumerator prematurely
			// TODO: ANALYZE BENCHMARK RESULTS
			var enumerator = collection.GetEnumerator();

			try
			{
				while (enumerator.MoveNext())
				{
					// Pre-size the list for better performance
					var currentPage = new List<T>(pageSize)
			{
				enumerator.Current
			};

					while (currentPage.Count < pageSize && enumerator.MoveNext())
					{
						currentPage.Add(enumerator.Current);
					}

					yield return currentPage;
				}
			}
			finally
			{
				// Ensure proper disposal after all iterations complete
				enumerator?.Dispose();
			}
		}

		/// <summary>
		/// Picks a random element from the collection.
		/// </summary>
		/// <returns>A randomly picked element from the collection.</returns>
		/// <remarks>
		/// This method uses a secure random number generator to ensure a fair selection.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(PickRandom), "David McCarter", "8/26/2020", "9/19/2020", BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
		public T? PickRandom()
		{
			collection = collection.ArgumentNotNull();

			return collection.IsNotEmpty() ? collection.FastShuffle(1).FirstOrDefault() : default;
		}

		/// <summary>
		/// Creates a new <see cref="Collection{T}"/> from the specified items. Optionally ensures uniqueness of items in the collection.
		/// </summary>
		/// <param name="ensureUnique">If set to <c>true</c>, the new collection will only include unique items.</param>
		/// <returns>A new <see cref="Collection{T}"/> containing the specified items, with duplicates removed if <paramref name="ensureUnique"/> is <c>true</c>.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public Collection<T> Create(in bool ensureUnique)
		{
			collection = collection.ArgumentNotNull();

			//RECOMENDATION FROM COPILOT SLOWER.
			IList<T> list = ensureUnique ? new HashSet<T>(collection).ToList() : [.. collection];

			return [.. list];
		}

		/// <summary>
		/// Adds the specified item to the end of the collection.
		/// </summary>
		/// <param name="item">The item to add to the collection.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> that includes the original collection items followed by the specified item.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized appending paths for different collection types:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="List{T}"/> - Uses <see cref="List{T}.Add(T)"/> for direct addition.</description></item>
		/// <item><description>Arrays - Creates pre-sized array and copies elements directly.</description></item>
		/// <item><description><see cref="IList{T}"/> - Creates new list with capacity and adds elements efficiently.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - Pre-sizes list to avoid resizing overhead.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Falls back to built-in <see cref="Enumerable.Append{TSource}(IEnumerable{TSource}, TSource)"/>.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>List/Array:</b> O(n) single copy operation with pre-allocated memory.</description></item>
		/// <item><description><b>Other types:</b> O(n) with deferred execution via Append.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3 };
		/// var result = numbers.AddLast(4);
		/// // Result: { 1, 2, 3, 4 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddLast), "David McCarter", "10/24/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> AddLast([DisallowNull] T item)
		{
			collection = collection.ArgumentNotNull();
			item = item.ArgumentNotNull();

			foreach (var element in collection)
			{
				yield return element;
			}

			yield return item;
		}

		/// <summary>
		/// Inserts or updates an item in the collection. If the item already exists, it is updated; otherwise, it is added.
		/// Note: This method returns a new <see cref="IEnumerable{T}"/> with the item upserted and does not modify the original collection.
		/// </summary>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Upsert), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> Upsert([DisallowNull] T item)
		{
			collection = collection.ArgumentNotNull();
			item = item.ArgumentNotNull();

			var list = collection as List<T> ?? [.. collection];

			var index = list.IndexOf(item);

			if (index >= 0)
			{
				list[index] = item; // Update the existing item.
			}
			else
			{
				list.Add(item); // Add the new item.
			}

			return list;
		}

		/// <summary>
		/// Adds the specified item to the beginning of the collection.
		/// </summary>
		/// <param name="item">The item to add to the collection.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> that starts with the specified item followed by the original collection items.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized prepending paths for different collection types:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="List{T}"/> - Uses <see cref="List{T}.Insert(int, T)"/> for direct insertion.</description></item>
		/// <item><description>Arrays - Creates pre-sized array and copies elements directly.</description></item>
		/// <item><description><see cref="IList{T}"/> - Creates new list with capacity and adds elements efficiently.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Falls back to built-in <see cref="Enumerable.Prepend{TSource}(IEnumerable{TSource}, TSource)"/>.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>List/Array:</b> O(n) single copy operation with pre-allocated memory.</description></item>
		/// <item><description><b>Other types:</b> O(n) with deferred execution via Prepend.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 2, 3, 4 };
		/// var result = numbers.AddFirst(1);
		/// // Result: { 1, 2, 3, 4 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddFirst), "David McCarter", "10/24/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> AddFirst([DisallowNull] T item)
		{
			collection = collection.ArgumentNotNull();
			item = item.ArgumentNotNull();

			yield return item;

			foreach (var element in collection)
			{
				yield return element;
			}
		}

		/// <summary>
		/// Adds distinct items to the collection enumerable collection.
		/// </summary>
		/// <param name="items">The items to add to the collection if they are not already present. Must not be null or empty.</param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> that contains the distinct elements from the original collection and any new items added.
		/// Returns the original collection if <paramref name="items"/> is null or empty.
		/// </returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddDistinct), author: "David McCarter", createdOn: "3/22/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Updated)]
		public IEnumerable<T> AddDistinct([AllowNull] params IEnumerable<T> items)
		{
			if (collection == null || items == null || items.Count() == 0)
			{
				return collection ?? [];
			}

			var hashSet = new HashSet<T>(collection);

			_ = hashSet.AddRange(items);

			return hashSet;
		}

		/// <summary>
		/// Determines whether the <see cref="IEnumerable"/> has a specified count.
		/// </summary>
		/// <param name="count">The specific count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public bool IsNotEmpty(in int count) => collection is null ? false : collection.Count() == count;

		/// <summary>
		/// Determines whether the specified collection has any items.
		/// </summary>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public bool IsNotEmpty() => collection is null ? false : collection.Count() > 0;

		/// <summary>
		/// Converts the specified collection to a <see cref="ReadOnlyCollection{T}"/> with optimized performance for common collection types.
		/// </summary>
		/// <returns>A <see cref="ReadOnlyCollection{T}"/> that contains elements from the input collection.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized conversion paths for different collection types:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="IList{T}"/> - Directly wraps the list without copying (fastest path, zero allocation for wrapper).</description></item>
		/// <item><description>Arrays (<typeparamref name="T"/>[]) - Directly wraps the array without copying.</description></item>
		/// <item><description><see cref="List{T}"/> - Directly wraps the list without copying.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - Creates pre-sized list, copies once, then wraps.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Materializes to list, then wraps.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>IList&lt;T&gt;/Array input:</b> O(1) operation, no element copying.</description></item>
		/// <item><description><b>ICollection&lt;T&gt; input:</b> O(n) operation, single enumeration with pre-sized allocation.</description></item>
		/// <item><description><b>Other IEnumerable&lt;T&gt; input:</b> O(n) operation, materializes then wraps.</description></item>
		/// </list>
		/// <para>
		/// <b>Important:</b> <see cref="ReadOnlyCollection{T}"/> wraps the underlying collection without copying.
		/// Changes to the original collection (if mutable) will be reflected in the ReadOnlyCollection.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// // From List&lt;T&gt; - wraps directly, no copy
		/// var list = new List&lt;int&gt; { 1, 2, 3 };
		/// ReadOnlyCollection&lt;int&gt; roc1 = list.ToReadOnlyCollection();
		///
		/// // From array - wraps directly, no copy
		/// int[] array = { 1, 2, 3 };
		/// ReadOnlyCollection&lt;int&gt; roc2 = array.ToReadOnlyCollection();
		///
		/// // From IEnumerable - materializes then wraps
		/// IEnumerable&lt;int&gt; enumerable = Enumerable.Range(1, 3);
		/// ReadOnlyCollection&lt;int&gt; roc3 = enumerable.ToReadOnlyCollection();
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToReadOnlyCollection), "David McCarter", "2/5/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			//TODO: ADD UNIT TESTS AND BENCHMARKS FOR ALL COLLECTION TYPES

			collection = collection.ArgumentNotNull();

			// Fast path: Already an IList<T>, wrap directly
			if (collection is IList<T> list)
			{
				return new ReadOnlyCollection<T>(list);
			}

			// Fast path: Array (implements IList<T>)
			if (collection is T[] array)
			{
				return new ReadOnlyCollection<T>(array);
			}

			// Medium path: ICollection<T> with known count - pre-size list
			if (collection is ICollection<T> collectionT)
			{
				var tempList = new List<T>(collectionT.Count);

				foreach (var item in collection)
				{
					tempList.Add(item);
				}

				return new ReadOnlyCollection<T>(tempList);
			}

			// Slow path: Generic IEnumerable<T> - materialize to list
			// Note: ToList() is optimized internally for common collection types
			return new ReadOnlyCollection<T>(collection.ToList());
		}

		/// <summary>
		/// Adds the specified item to the collection if the condition is true.
		/// </summary>
		/// <param name="item">The item to add to the collection.</param>
		/// <param name="condition">The condition that determines if the item should be added.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> that includes the original collection and, if the condition is true, the specified item.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized conditional appending for different collection types:
		/// </para>
		/// <list type="bullet">
		/// <item><description>When <paramref name="condition"/> is <c>false</c> - Returns the original collection immediately (zero overhead).</description></item>
		/// <item><description>When <paramref name="condition"/> is <c>true</c> - Uses optimized paths similar to <see cref="AddLast{T}(IEnumerable{T}, T)"/>.</description></item>
		/// <item><description><see cref="List{T}"/> - Creates new list with capacity and uses <see cref="List{T}.AddRange(IEnumerable{T})"/>.</description></item>
		/// <item><description>Arrays - Uses <see cref="Array.Copy(Array, int, Array, int, int)"/> for efficient copying.</description></item>
		/// <item><description>Other types - Falls back to <see cref="Enumerable.Append{TSource}(IEnumerable{TSource}, TSource)"/>.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Condition false:</b> O(1) - Returns original collection.</description></item>
		/// <item><description><b>Condition true (List/Array):</b> O(n) with pre-allocated memory.</description></item>
		/// <item><description><b>Condition true (Other):</b> O(n) with deferred execution.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3 };
		/// var includeExtra = true;
		/// var result = numbers.AddIf(4, includeExtra);
		/// // Result: { 1, 2, 3, 4 }
		/// 
		/// var result2 = numbers.AddIf(5, false);
		/// // Result2: { 1, 2, 3 } (original collection, no modification)
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddIf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> AddIf([DisallowNull] T item, bool condition)
		{
			if (item is null)
			{
				return collection;
			}

			collection = collection.ArgumentNotNull();

			if (condition)
			{
				collection = collection.AddLast(item);
			}

			return collection;
		}
	}
}
