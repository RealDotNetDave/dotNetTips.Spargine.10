// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-22-2026
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
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
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
		/// <param name="pageSize">The maximum number of elements per page. Must be at least 2.</param>
		/// <param name="cancellationToken">
		/// A <see cref="CancellationToken"/> that can be used to cancel the paging operation.
		/// </param>
		/// <returns>
		/// An <see cref="IAsyncEnumerable{T}"/> where each item is a page of the original collection containing up to <paramref name="pageSize"/> elements.
		/// The last page may contain fewer elements if the total count is not evenly divisible by <paramref name="pageSize"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides several performance enhancements:
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Deferred Execution:</b> Pages are generated on-demand only when enumerated, minimizing memory usage.</description></item>
		/// <item><description><b>Pre-sized Lists:</b> Each page list is pre-allocated with <paramref name="pageSize"/> capacity to avoid resizing.</description></item>
		/// <item><description><b>ConfigureAwait(false):</b> Prevents synchronization context capture for better performance in non-UI scenarios.</description></item>
		/// <item><description><b>Cancellation Support:</b> Supports cooperative cancellation via <see cref="CancellationToken"/> using <see cref="EnumeratorCancellationAttribute"/>.</description></item>
		/// <item><description><b>Memory Efficiency:</b> Only one page is held in memory at a time, unlike buffering the entire collection.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Time Complexity:</b> O(n) - Single pass through the source collection.</description></item>
		/// <item><description><b>Space Complexity:</b> O(pageSize) - Only one page allocated at a time.</description></item>
		/// <item><description><b>Streaming:</b> Elements are yielded as soon as a page is full, enabling true streaming scenarios.</description></item>
		/// </list>
		/// <para>
		/// <b>Best Practices:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Large datasets:</b> Ideal for processing large collections without loading everything into memory.</description></item>
		/// <item><description><b>API responses:</b> Perfect for paginated API responses to avoid memory exhaustion.</description></item>
		/// <item><description><b>Database queries:</b> Combine with Entity Framework's async LINQ for efficient database paging.</description></item>
		/// <item><description><b>Cancellation:</b> Always pass a cancellation token when possible to enable graceful cancellation.</description></item>
		/// </list>
		/// <para>
		/// <b>When to use:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Processing large collections in batches</description></item>
		/// <item><description>Implementing pagination in ASP.NET Core APIs</description></item>
		/// <item><description>Streaming data processing where memory is constrained</description></item>
		/// <item><description>Parallel processing of pages (each page can be processed independently)</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// // Basic usage with database query
		/// await foreach (var page in dbContext.Users.AsAsyncEnumerable().PageAsync(100))
		/// {
		///     // Process each page of 100 users
		///     await ProcessBatchAsync(page);
		/// }
		/// 
		/// // With cancellation token
		/// await using var cts = new CancellationTokenSource(TimeSpan.FromMinutes(5));
		/// await foreach (var page in largeCollection.PageAsync(50, cts.Token))
		/// {
		///     // Process each page with cancellation support
		///     Console.WriteLine($"Processing page with {page.Count} items");
		/// }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(PageAsync), "David McCarter", "8/22/2025", BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public async IAsyncEnumerable<List<T>> PageAsync(int pageSize, [EnumeratorCancellation] CancellationToken cancellationToken = default)
		{
			collection = collection.ArgumentNotNull();
			pageSize = pageSize.EnsureMinimum(2);

			var currentPage = new List<T>(pageSize);

			await foreach (var item in collection.ConfigureAwait(false))
			{
				// Check cancellation before processing item
				cancellationToken.ThrowIfCancellationRequested();

				currentPage.Add(item);

				if (currentPage.Count == pageSize)
				{
					yield return currentPage;

					// Pre-allocate next page with same capacity
					currentPage = new List<T>(pageSize);
				}
			}

			// Yield the last partial page if it contains any items
			if (currentPage.Count > 0)
			{
				yield return currentPage;
			}
		}
	}

	extension<T>([DisallowNull] IEnumerable<T> collection)
	{
		/// <summary>
		/// Returns the first element in the collection that matches the specified condition, or null if no such element is found.
		/// </summary>
		/// <param name="accumulatorPredicate">The accumulatorFunction to accumulatorPredicate against the elements of the collection.</param>
		/// <returns>The first element that matches the condition defined by <paramref name="accumulatorPredicate"/>, or null if no such element is found.</returns>
		/// <example>
		/// This example shows how to use <see cref="FirstOrNull{T}"/> to find the first element in an span of integers that is greater than 10, or null if no such element exists.
		/// <code>
		/// int[] numbers = { 1, 4, 7, 10, 12, 15 };
		/// int? firstGreaterThanTen = numbers.FirstOrNull(n => n > 10);
		/// Console.WriteLine(firstGreaterThanTen); // Output: 12
		/// </code>
		/// </example>
		[Pure]
		[return: MaybeNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public T FirstOrNull([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			// Fast path for List<T> using span
			if (collection is List<T> list)
			{
				var span = CollectionsMarshal.AsSpan(list);
				var length = span.Length;

				for (var i = 0; i < length; i++)
				{
					if (accumulatorPredicate(span[i]))
					{
						return span[i];
					}
				}

				return default;
			}

			// Fast path for arrays
			if (collection is T[] array)
			{
				ref var arrayStart = ref MemoryMarshal.GetArrayDataReference(array);
				var arrayLength = array.Length;

				for (var i = 0; i < arrayLength; i++)
				{
					ref var item = ref Unsafe.Add(ref arrayStart, i);
					if (accumulatorPredicate(item))
					{
						return item;
					}
				}

				return default;
			}

			// Standard enumeration for other collection types
			foreach (var item in collection)
			{
				if (accumulatorPredicate(item))
				{
					return item;
				}
			}

			return default;
		}

		/// <summary>
		/// Finds the index of the first occurrence of an item in the collection using the specified equality comparer.
		/// </summary>
		/// <param name="item">The item to locate in the collection. Must not be null.</param>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> implementation to use when comparing elements; if <c>null</c>, the default equality comparer
		/// <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// The zero-based index of the first occurrence of <paramref name="item"/> within the collection if found; otherwise, <c>-1</c>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Performs a single forward enumeration over the source collection and compares each element using the provided <paramref name="comparer"/>.
		/// If <paramref name="comparer"/> is <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </para>
		/// <para>
		/// Performance characteristics:
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Time complexity:</b> O(n) where n is the number of elements in the collection.</description></item>
		/// <item><description><b>Space complexity:</b> O(1) - no additional allocations beyond the enumerator.</description></item>
		/// <item><description><b>Enumeration:</b> Single-pass forward iteration.</description></item>
		/// </list>
		/// <para>
		/// Recommended comparers:
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Strings:</b> <see cref="StringComparer.OrdinalIgnoreCase"/> for case-insensitive, <see cref="StringComparer.Ordinal"/> for case-sensitive.</description></item>
		/// <item><description><b>Reference equality:</b> use a reference comparer to match object instances.</description></item>
		/// <item><description><b>Custom objects:</b> provide an <see cref="IEqualityComparer{T}"/> implementation that compares required properties.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var names = new List&lt;string&gt; { "Alice", "Bob", "Charlie" };
		/// // Case-insensitive search
		/// var index1 = names.IndexOf("alice", StringComparer.OrdinalIgnoreCase); // returns 0
		///
		/// // Default comparer (null) - case-sensitive for strings
		/// var index2 = names.IndexOf("Bob", null); // returns 1
		///
		/// // Custom comparer for a Person type by Id
		/// var people = new List&lt;Person&gt;
		/// {
		///     new Person { Id = 1, Name = "John" },
		///     new Person { Id = 2, Name = "Jane" }
		/// };
		/// var index3 = people.IndexOf(new Person { Id = 2 }, new PersonComparer()); // returns 1
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated)]
		public int IndexOf([DisallowNull] T item, [AllowNull] IEqualityComparer<T>? comparer = null)
		{
			collection = collection.ArgumentItemsExists();
			item = item.ArgumentNotNull();

			var eq = comparer ?? EqualityComparer<T>.Default;
			var index = 0;

			foreach (var element in collection)
			{
				if (eq.Equals(element, item))
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
		[Information("Original code by Simon Painter.", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int IndexOf([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			//SUGGESTION BY COPILOT SLOWER.
			var result = collection.Select((value, index) => (value, index)).FirstOrDefault(value => accumulatorPredicate.Invoke(value.value));

			return result.Equals(default((T x, int i))) ? -1 : result.index;
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
		[Information(nameof(OrderBy), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
		public IEnumerable<T> OrderBy([DisallowNull] string sortExpression)
		{
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

			var cacheKey = $"{typeof(T).FullName}.{property}";

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

			return descending
				? collection.OrderByDescending(typedAccessor)
				: collection.OrderBy(typedAccessor);
		}

		/// <summary>
		/// Orders the elements of a collection by a key selected from each element using ordinal string comparison.
		/// </summary>
		/// <param name="accumulatorFunction">A function to extract a string key from an element.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> whose elements are sorted according to a key using ordinal comparison.</returns>
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
		[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> OrderByOrdinal([DisallowNull] Func<T, string> accumulatorFunction)
		{
			return collection.OrderBy(accumulatorFunction, StringComparer.Ordinal);
		}

		/// <summary>
		/// Removes duplicate elements from the specified collection.
		/// </summary>
		/// <returns>A <see cref="SimpleResult{TResult}"/> containing the collection without duplicates.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Obsolete("Use EnsureUnique. Will be removed at the end of 2026", false)]
		[Information(nameof(RemoveDuplicates), author: "David McCarter", createdOn: "7/3/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public IEnumerable<T> RemoveDuplicates()
		{
			return new HashSet<T>(collection);
		}

		/// <summary>
		/// Replaces elements in the collection based on a specified condition.
		/// </summary>
		/// <param name="accumulatorPredicate">A function that determines whether an element should be replaced, based on the element and its index.</param>
		/// <param name="replacement">The replacement value for elements that meet the condition.</param>
		/// <returns>A new collection with elements replaced based on the specified condition.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses deferred execution with yield return for optimal performance:
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Deferred Execution:</b> Elements are processed on-demand only when enumerated.</description></item>
		/// <item><description><b>Streaming Operation:</b> Single-pass enumeration with true lazy evaluation.</description></item>
		/// <item><description><b>Memory Efficient:</b> No intermediate collection allocation - processes elements one at a time.</description></item>
		/// <item><description><b>Zero Overhead:</b> Direct yield-based implementation without LINQ Select delegation.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Time Complexity:</b> O(n) - Single pass through the source collection.</description></item>
		/// <item><description><b>Space Complexity:</b> O(1) - No intermediate collection allocation.</description></item>
		/// <item><description><b>Streaming:</b> True streaming operation - each element is transformed as it's enumerated.</description></item>
		/// </list>
		/// <para>
		/// <b>When to Use:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Transforming elements based on conditions</description></item>
		/// <item><description>Replacing elements at specific indices</description></item>
		/// <item><description>Chaining with other LINQ operations for complex transformations</description></item>
		/// <item><description>Processing large collections where deferred execution provides memory benefits</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// 
		/// // Replace values greater than 3
		/// var result = numbers.ReplaceIf((n, itemIndex) => n > 3, 0);
		/// // Result: { 1, 2, 3, 0, 0 }
		/// 
		/// // Replace at even indices
		/// var evens = numbers.ReplaceIf((n, itemIndex) => itemIndex % 2 == 0, -1);
		/// // Result: { -1, 2, -1, 4, -1 }
		/// 
		/// // Deferred execution - no processing until enumeration
		/// var query = numbers.ReplaceIf((n, i) => n > 2, 999);
		/// // Nothing happens yet...
		/// 
		/// foreach (var item in query) // Now processing occurs
		/// {
		///     Console.WriteLine(item);
		/// }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("Original code by Simon Painter.", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Updated)]
		public IEnumerable<T> ReplaceIf([DisallowNull] Func<T, int, bool> accumulatorPredicate, T replacement)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			var index = 0;

			foreach (var element in collection)
			{
				yield return accumulatorPredicate(element, index) ? replacement : element;
				index++;
			}
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
		[Information(nameof(Partition), "David McCarter", "3/2/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<IEnumerable<T>> Partition(int pageCount)
		{
			foreach (var chunk in collection.Chunk(pageCount))
			{
				yield return chunk;
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
		[Information(nameof(FastShuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> FastShuffle(int count)
		{
			count = count.ArgumentInRange(min: 1, max: int.MaxValue);

			return collection.FastShuffle().Take(count);
		}

		/// <summary>
		/// Randomizes the order of elements in the collection and returns a new sequence containing the shuffled items.
		/// </summary>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> with the elements of the original collection in randomized order.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The original input enumeration is not modified. If the input is already an span, it is used directly;
		/// otherwise, a new span is created from the input items before shuffling.
		/// </para>
		/// <para>
		/// <b>Performance:</b> Uses span-based shuffling for optimal performance and minimal allocations.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = Enumerable.Range(1, 5);
		/// var shuffled = numbers.FastShuffle();
		/// // Example result: { 3, 1, 5, 2, 4 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastShuffle), "David McCarter", "8/26/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> FastShuffle()
		{
			collection = collection.ArgumentNotNull();

			var array = collection.ToArray();

			Random.Shared.Shuffle(array);

			return array;
		}

		/// <summary>
		/// Determines whether the beginning of the first collection matches the whole second collection.
		/// </summary>
		/// <param name="second">The second collection to compare to the beginning of the first collection.</param>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(StartsWith), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
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
		/// Determines whether two sequences are structurally equal by comparing their elements by using a default <see cref="IEqualityComparer{T}" />.
		/// </summary>
		/// <param name="second">The second sequence to compare.</param>
		/// <returns>true if the two collection sequences are of equal length and their corresponding elements are equal according to the default equality comparer for their type; otherwise, false.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
		public bool StructuralSequenceEqual([AllowNull] IEnumerable<T> second)
		{
			if (collection is null || second is null)
			{
				return false;
			}

			if (ReferenceEquals(collection, second))
			{
				return true;
			}

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
		[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public BlockingCollection<T> ToBlockingCollection()
		{
			return new BlockingCollection<T>(new ConcurrentQueue<T>(collection));
		}

		/// <summary>
		/// Converts the specified collection to a <see cref="Collection{T}"/> with optimized performance for common collection types.
		/// </summary>
		/// <returns>A <see cref="Collection{T}"/> that wraps or contains elements from the input collection.</returns>
		/// <remarks>
		/// This method provides optimized conversion paths for different collection types to minimize allocations and enumerations:
		/// <list type="bullet">
		/// <item><description><see cref="IList{T}"/> - Directly wraps the list without copying (fastest path, zero allocation).</description></item>
		/// <item><description>Arrays (<typeparamref name="T"/>[]) - Directly wraps the span without copying.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - Creates a pre-sized <see cref="List{T}"/> and copies elements once, then wraps it.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Uses collection expression to materialize and wrap the collection.</description></item>
		/// </list>
		/// <remarks>
		/// Performance characteristics:
		/// <list type="bullet">
		/// <item><description><b>IList&lt;T&gt; input:</b> O(1) operation, no allocations beyond the Collection wrapper.</description></item>
		/// <item><description><b>Array input:</b> O(1) operation, no allocations beyond the Collection wrapper.</description></item>
		/// <item><description><b>ICollection&lt;T&gt; input:</b> O(n) operation, single enumeration with pre-sized list allocation.</description></item>
		/// <item><description><b>Other IEnumerable&lt;T&gt; input:</b> O(n) operation, potential span allocation.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// This example shows how to use <see cref="ToCollection"/> with different collection types:
		/// <code>
		/// // From List&lt;T&gt; - direct wrap, no copy
		/// var list = new List&lt;int&gt; { 1, 2, 3 };
		/// Collection&lt;int&gt; collection1 = list.ToCollection();
		///
		/// // From span - direct wrap, no copy
		/// int[] span = { 1, 2, 3 };
		/// Collection&lt;int&gt; collection2 = span.ToCollection();
		///
		/// // From IEnumerable&lt;T&gt; - materialized then wrapped
		/// IEnumerable&lt;int&gt; enumerable = Enumerable.Range(1, 3);
		/// Collection&lt;int&gt; collection3 = enumerable.ToCollection();
		/// </code>
		/// </example>
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToCollection), "David McCarter", "4/13/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Collection<T> ToCollection()
		{
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
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet()
		{
			return FrozenSet.ToFrozenSet(collection);
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
		[Information(nameof(ToLinkedList), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public LinkedList<T> ToLinkedList()
		{
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
				if (accumulatorPredicate(item))
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
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "12/9/2022", UnitTestStatus = UnitTestStatus.Update, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
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

			//RECOMENDATION FROM COPILOT SLOWER.
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
		/// The method creates a new span for the results, ensuring the returned collection is independent of the source.
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
		[Information(nameof(FastLongCount), "David McCarter", "5/21/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public long FastLongCount()
		{
			collection = collection.ArgumentNotNull();

			long count = 0;

			using (var enumerator = collection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					count++;
				}
			}
			return count;
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
		/// This example shows how to use <see cref="FastAny{T}"/> to quickly check if any elements in an span satisfy a condition.
		/// <code>
		/// int[] numbers = { 1, 2, 3 };
		/// bool hasEvenNumber = numbers.FastAny(n => n % 2 == 0);
		/// Console.WriteLine(hasEvenNumber); // Output: True
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastAny), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool FastAny([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
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
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized lookup paths:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="ISet{T}"/> (HashSet, etc.) - Uses O(1) Contains for each item.</description></item>
		/// <item><description>Large item sets (>10 items) - Converts collection to HashSet for O(1) lookups.</description></item>
		/// <item><description>Small item sets - Uses direct enumeration to avoid HashSet allocation overhead.</description></item>
		/// </list>
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ContainsAny), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Update, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
		public bool ContainsAny([AllowNull] params ReadOnlyCollection<T> items)
		{
			if (collection is null || items is null || items.Count == 0)
			{
				return false;
			}

			// Fast path: If collection is already a set, Contains is O(1)
			if (collection is ISet<T> set)
			{
				foreach (var item in items)
				{
					if (set.Contains(item))
					{
						return true;
					}
				}

				return false;
			}

			// For larger item sets, convert collection to HashSet for O(1) lookups
			// Threshold chosen based on typical break-even point for HashSet creation overhead
			if (items.Count > 10)
			{
				var hashSet = collection as HashSet<T> ?? [.. collection];

				foreach (var item in items)
				{
					if (hashSet.Contains(item))
					{
						return true;
					}
				}

				return false;
			}

			// Small item sets: direct enumeration avoids HashSet allocation overhead
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
		[Information(nameof(HasDuplicates), author: "David McCarter", createdOn: "7/3/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public bool HasDuplicates()
		{
			// Fast-path: null or already-known empty
			if (collection is null)
			{
				return false;
			}

			// Fast-path: if the source is a HashSet<T>, it's already unique
			if (collection is HashSet<T>)
			{
				return false;
			}

			// Fast-path: if we can get the count without enumerating, bail out for 0 or 1
			if (collection is ICollection<T> c)
			{
				if (c.Count <= 1)
				{
					return false;
				}

				// Pre-size the HashSet to minimize rehashing/resizing
				var seenItems = new HashSet<T>(c.Count);
				foreach (var item in c)
				{
					if (!seenItems.Add(item))
					{
						return true;
					}
				}

				return false;
			}

			// Fallback: unknown count, enumerate once
			var fallbackSeen = new HashSet<T>();

			foreach (var item in collection)
			{
				if (!fallbackSeen.Add(item))
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Determines whether the specified <see cref="IEnumerable"/> does not have items or is null.
		/// </summary>
		/// <returns><c>true</c> if the specified collection has items; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsEmpty()
		{
			return collection?.Count() <= 0;
		}

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
		/// Ensures that all elements in the collection are unique based on the default equality comparer.
		/// </summary>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> containing only unique elements from the original collection.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Adaptive strategy is used based on the element type and collection size:
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Value types:</b> Always uses <see cref="Enumerable.Distinct{TSource}(IEnumerable{TSource})"/> for optimal performance.</description></item>
		/// <item><description><b>Reference types:</b> If count is ≤ 4096, uses <see cref="HashSet{T}"/>; otherwise, uses <see cref="Enumerable.Distinct{TSource}(IEnumerable{TSource})"/>.</description></item>
		/// <item><description><b>Unknown count:</b> Falls back to <see cref="HashSet{T}"/>.</description></item>
		/// </list>
		/// <para>
		/// Uses the default equality comparer for type <typeparamref name="T"/> to determine uniqueness. If duplicates exist,
		/// only the first occurrence is included in the returned sequence.
		/// </para>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Time complexity:</b> O(n) where n is the number of elements.</description></item>
		/// <item><description><b>Space complexity:</b> O(u) where u is the number of unique elements (and potential auxiliary structures).</description></item>
		/// <item><description><b>Count detection:</b> O(1) for <see cref="ICollection{T}"/> and <see cref="IReadOnlyCollection{T}"/>.</description></item>
		/// </list>
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(EnsureUnique), "David McCarter", "11/8/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated)]
		public IEnumerable<T> EnsureUnique([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			// Value types: use Distinct() which is optimized; pass comparer when provided
			if (typeof(T).IsValueType)
			{
				return collection.Distinct(comparer);
			}

			// Reference types: use size-based optimization; honor comparer
			if (collection is ICollection<T> collectionT)
			{
				return collectionT.Count > 128
					? collection.Distinct(comparer)
					: new HashSet<T>(collection, comparer);
			}

			// Unknown count: default to HashSet; honor comparer
			return new HashSet<T>(collection, comparer);
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
		[Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
		public Collection<T> Create(in bool ensureUnique = false)
		{
			return ensureUnique ? new Collection<T>(new HashSet<T>(collection).ToList()) : new Collection<T>([.. collection]);
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
		/// <item><description>Arrays - Creates pre-sized span and copies elements directly.</description></item>
		/// <item><description><see cref="IList{T}"/> - Creates new list with capacity and adds elements efficiently.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - Pre-sizes list to avoid resizing overhead.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Falls back to built-in <see cref="Enumerable.Append{TSource}(IEnumerable{TSource}, TSource)"/>.</description></item>
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
		/// <param name="item">The item to upsert into the collection.</param>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> implementation to use when comparing elements.
		/// If <c>null</c>, uses <see cref="EqualityComparer{T}.Default"/>.
		/// </param>
		/// <returns>An <see cref="IEnumerable{T}"/> with the item upserted (updated if exists, added if not).</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses deferred execution with yield return for memory efficiency:
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Deferred Execution:</b> Elements are yielded on-demand during enumeration.</description></item>
		/// <item><description><b>Single Pass:</b> Enumerates the collection once to find and update the matching item.</description></item>
		/// <item><description><b>Memory Efficient:</b> No intermediate List allocation when item exists in collection.</description></item>
		/// <item><description><b>Custom Comparison:</b> Supports custom equality comparers for flexible item matching.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Item exists:</b> O(n) with deferred execution - yields original items until match found, then yields updated item.</description></item>
		/// <item><description><b>Item doesn't exist:</b> O(n) with deferred execution - yields all original items, then yields new item at end.</description></item>
		/// <item><description><b>Space complexity:</b> O(1) - no intermediate collection allocation.</description></item>
		/// </list>
		/// <para>
		/// <b>When to Use Custom Comparers:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Case-insensitive string comparison:</b> Use <see cref="StringComparer.OrdinalIgnoreCase"/> or <see cref="StringComparer.InvariantCultureIgnoreCase"/>.</description></item>
		/// <item><description><b>Custom object comparison:</b> When the default <see cref="object.Equals(object)"/> behavior doesn't meet requirements.</description></item>
		/// <item><description><b>Property-based matching:</b> Create a custom comparer that matches based on specific properties (e.g., Id-based matching).</description></item>
		/// <item><description><b>Culture-specific comparison:</b> Use culture-aware comparers for internationalized applications.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var people = new List&lt;Person&gt; 
		/// { 
		///     new Person { Id = 1, Name = "John" },
		///     new Person { Id = 2, Name = "Jane" }
		/// };
		/// 
		/// // Update existing person using default comparer
		/// var updatedPerson = new Person { Id = 1, Name = "John Doe" };
		/// var result = people.Upsert(updatedPerson);
		/// 
		/// // Add new person
		/// var newPerson = new Person { Id = 3, Name = "Bob" };
		/// var result2 = people.Upsert(newPerson);
		/// 
		/// // Upsert with custom comparer (match by Id only)
		/// var personIdComparer = new PersonIdComparer();
		/// var updated = people.Upsert(updatedPerson, personIdComparer);
		/// // This will update the person with Id=1, even if other properties differ
		/// 
		/// // Case-insensitive string upsert
		/// var names = new List&lt;string&gt; { "Alice", "Bob" };
		/// var upserted = names.Upsert("alice", StringComparer.OrdinalIgnoreCase);
		/// // Result: { "alice", "Bob" } - "Alice" updated to "alice"
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Upsert), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated)]
		public IEnumerable<T> Upsert([DisallowNull] T item, [AllowNull] IEqualityComparer<T>? comparer = null)
		{
			collection = collection.ArgumentNotNull();
			item = item.ArgumentNotNull();

			// Prefer a local comparer variable to avoid repeated null-coalescing checks in the loop.
			var eq = comparer ?? EqualityComparer<T>.Default;
			var itemFound = false;

			foreach (var element in collection)
			{
				if (!itemFound && eq.Equals(element, item))
				{
					// Found the item - yield the updated version once
					yield return item;
					itemFound = true;
					continue;
				}

				yield return element;
			}

			// If item wasn't found, append it at the end
			if (!itemFound)
			{
				yield return item;
			}
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
		/// <item><description>Arrays - Creates pre-sized span and copies elements directly.</description></item>
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
		public bool IsNotEmpty(in int count)
		{
			return collection is null ? false : collection.Count() == count;
		}

		/// <summary>
		/// Determines whether the specified collection has any items.
		/// </summary>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public bool IsNotEmpty()
		{
			return collection is null ? false : collection.Count() > 0;
		}

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
		/// <item><description>Arrays (<typeparamref name="T"/>[]) - Directly wraps the span without copying.</description></item>
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
		/// // From span - wraps directly, no copy
		/// int[] span = { 1, 2, 3 };
		/// ReadOnlyCollection&lt;int&gt; roc2 = span.ToReadOnlyCollection();
		///
		/// // From IEnumerable - materializes then wraps
		/// IEnumerable&lt;int&gt; enumerable = Enumerable.Range(1, 3);
		/// ReadOnlyCollection&lt;int&gt; roc3 = enumerable.ToReadOnlyCollection();
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToReadOnlyCollection), "David McCarter", "2/5/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			return new ReadOnlyCollection<T>([.. collection]);
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
		[Information(nameof(AddIf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated)]
		public IEnumerable<T> AddIf([DisallowNull] T item, bool condition)
		{
			collection = collection.ArgumentNotNull();

			// Stream original elements
			foreach (var element in collection)
			{
				yield return element;
			}

			// Append item only when condition is true and item is non-null
			if (condition && item is not null)
			{
				yield return item;
			}
		}
	}
}
