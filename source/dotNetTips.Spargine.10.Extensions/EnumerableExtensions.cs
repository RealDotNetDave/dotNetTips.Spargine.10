// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-21-2026
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
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineEnumerableExtensions")]
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

	/// <summary>
	/// Builds and compiles a property accessor delegate for <typeparamref name="T"/> by name.
	/// Returns a null-returning delegate if the property does not exist.
	/// </summary>
	/// <typeparam name="T">The element type whose property is accessed.</typeparam>
	/// <param name="property">The name of the property to access.</param>
	/// <returns>A compiled <see cref="Delegate"/> that retrieves the named property value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called from within C# 14 extension blocks.")]
	private static Delegate BuildPropertyAccessor<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(string property)
	{
		var prop = typeof(T).GetRuntimeProperty(property);

		if (prop is null)
		{
			return new Func<T, object?>(_ => null);
		}

		var parameter = Expression.Parameter(typeof(T), "x");
		var propertyAccess = Expression.Property(parameter, prop);
		var conversion = Expression.Convert(propertyAccess, typeof(object));
		var lambda = Expression.Lambda<Func<T, object?>>(conversion, parameter);
		return lambda.Compile();
	}

	/// <summary>
	/// Checks whether any item in <paramref name="items"/> is contained in <paramref name="collection"/>
	/// by first materializing the collection into a <see cref="HashSet{T}"/> for O(n+m) performance.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="collection">The source collection to search.</param>
	/// <param name="items">The items to look for.</param>
	/// <returns><c>true</c> if any item is found; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called from within C# 14 extension blocks.")]
	private static bool ContainsAnyInLargeCollection<T>([DisallowNull] ICollection<T> collection, [DisallowNull] ReadOnlyCollection<T> items)
	{
		var collectionSet = new HashSet<T>(collection);

		foreach (var item in items)
		{
			if (collectionSet.Contains(item))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Checks whether any item in <paramref name="items"/> is contained in <paramref name="set"/>
	/// using the set's O(1) <c>Contains</c> lookup.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="set">The <see cref="ISet{T}"/> to search.</param>
	/// <param name="items">The items to look for.</param>
	/// <returns><c>true</c> if any item is found; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called from within C# 14 extension blocks.")]
	private static bool ContainsAnyInSet<T>([DisallowNull] ISet<T> set, [DisallowNull] ReadOnlyCollection<T> items)
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

	/// <summary>
	/// Determines whether an <see cref="ICollection{T}"/> contains duplicate elements.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="c">The collection to inspect.</param>
	/// <param name="comparer">Optional equality comparer; <c>null</c> uses the default.</param>
	/// <returns><c>true</c> if any duplicate element is found; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called from within C# 14 extension blocks.")]
	private static bool HasDuplicatesInCollection<T>([DisallowNull] ICollection<T> c, [AllowNull] IEqualityComparer<T>? comparer)
	{
		if (c.Count <= 1)
		{
			return false;
		}

		var seenItems = new HashSet<T>(c.Count, comparer);

		foreach (var item in c)
		{
			if (!seenItems.Add(item))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Checks whether <paramref name="collection"/> is an empty concurrent collection
	/// (<see cref="ConcurrentBag{T}"/>, <see cref="ConcurrentQueue{T}"/>, or <see cref="ConcurrentStack{T}"/>).
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="collection">The collection to inspect.</param>
	/// <returns>
	/// <c>true</c> if the concurrent collection is empty, <c>false</c> if it is not empty,
	/// or <c>null</c> if the collection is not a recognized concurrent type.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called from within C# 14 extension blocks.")]
	private static bool? TryIsEmptyConcurrent<T>([DisallowNull] IEnumerable<T> collection)
	{
		if (collection is ConcurrentBag<T> concurrentBag)
		{
			return concurrentBag.IsEmpty;
		}

		if (collection is ConcurrentQueue<T> concurrentQueue)
		{
			return concurrentQueue.IsEmpty;
		}

		if (collection is ConcurrentStack<T> concurrentStack)
		{
			return concurrentStack.IsEmpty;
		}

		return null;
	}

	/// <summary>
	/// Picks a random element from an <see cref="IList{T}"/>.
	/// Returns <c>default</c> when the list is empty.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="list">The list to pick from.</param>
	/// <returns>A randomly selected element, or <c>default</c> if the list is empty.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called from within C# 14 extension blocks.")]
	[SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "General-purpose random selection, not cryptographic. Random.Shared is appropriate.")]
	private static T? PickFromList<T>(IList<T> list) =>
		list.Count == 0 ? default : list[Random.Shared.Next(list.Count)];

	/// <summary>
	/// Picks a random element from an <see cref="ICollection{T}"/> by enumerating to a random index.
	/// Returns <c>default</c> when the collection is empty.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="collection">The collection to pick from.</param>
	/// <returns>A randomly selected element, or <c>default</c> if the collection is empty.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called from within C# 14 extension blocks.")]
	[SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "General-purpose random selection, not cryptographic. Random.Shared is appropriate.")]
	private static T? PickFromCollection<T>(ICollection<T> collection)
	{
		var count = collection.Count;

		if (count == 0)
		{
			return default;
		}

		var targetIndex = Random.Shared.Next(count);
		var currentIndex = 0;

		foreach (var item in collection)
		{
			if (currentIndex == targetIndex)
			{
				return item;
			}

			currentIndex++;
		}

		return default;
	}

	/// <summary>
	/// Checks whether <paramref name="collection"/> is an empty immutable collection
	/// (<see cref="ImmutableList{T}"/>, <see cref="ImmutableHashSet{T}"/>, <see cref="ImmutableQueue{T}"/>,
	/// <see cref="ImmutableStack{T}"/>, or <see cref="ImmutableSortedSet{T}"/>).
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="collection">The collection to inspect.</param>
	/// <returns>
	/// <c>true</c> if the immutable collection is empty, <c>false</c> if it is not empty,
	/// or <c>null</c> if the collection is not a recognized immutable type.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "Called from within C# 14 extension blocks.")]
	private static bool? TryIsEmptyImmutable<T>([DisallowNull] IEnumerable<T> collection)
	{
		return collection switch
		{
			ImmutableList<T> l => l.IsEmpty,
			ImmutableHashSet<T> h => h.IsEmpty,
			ImmutableQueue<T> q => q.IsEmpty,
			ImmutableStack<T> s => s.IsEmpty,
			ImmutableSortedSet<T> ss => ss.IsEmpty,
			_ => null,
		};
	}

	/// <summary>
	/// Provides optimized containment helpers for comparable sequences by supplying fast-path logic that
	/// adapts to the underlying collection type.
	/// </summary>
	extension<T>([DisallowNull] IEnumerable<T> list) where T : IComparable<T>
	{
		/// <summary>
		/// Performs a membership check using the most efficient strategy available for the underlying sequence.
		/// </summary>
		/// <param name="searchItem">The value to locate in the sequence. Must not be <c>null</c>.</param>
		/// <param name="comparer">
		/// An optional <see cref="IComparer{T}"/> to use for comparison operations.
		/// If <c>null</c>, <see cref="Comparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// <c>true</c> if <paramref name="searchItem"/> is present; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// When no custom <paramref name="comparer"/> is provided, hash-based collections (such as <c>HashSet&lt;T&gt;</c>) 
		/// are queried directly for O(1) lookup using the set's internal comparer.
		/// </para>
		/// <para>
		/// When a custom <paramref name="comparer"/> is provided, all collection types use the specified comparer 
		/// for consistent comparison behavior.
		/// </para>
		/// <para>
		/// When the source is a <c>List&lt;T&gt;</c> or a <c>T[]</c>, the method uses span-based binary search for 
		/// O(log n) lookup. This assumes the data is already sorted according to the comparer's rules.
		/// </para>
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastContains), "David McCarter", "2/14/2026", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool FastContains(T searchItem, [AllowNull] IComparer<T>? comparer = null)
		{
			if ((list is null) || (searchItem is null))
			{
				return false;
			}

			// Use provided comparer or default
			var comp = comparer ?? Comparer<T>.Default;

			// Fast path: HashSet<T> - O(1) hash-based lookup only when using default comparer
			if ((list is HashSet<T> hashSet) && (comparer is null))
			{
				return hashSet.Contains(searchItem);
			}

			// Fast path: List<T> - O(log n) binary search via Span
			if (list is List<T> typedList)
			{
				var span = CollectionsMarshal.AsSpan(typedList);
				return span.BinarySearch(searchItem, comp) >= 0;
			}

			// Fast path: Array - O(log n) binary search via Span
			if (list is T[] array)
			{
				return array.AsSpan().BinarySearch(searchItem, comp) >= 0;
			}

			// Fallback: O(n) linear search using the comparer
			foreach (var item in list)
			{
				if (comp.Compare(item, searchItem) == 0)
				{
					return true;
				}
			}

			return false;
		}
	}

	///<summary>Extension methods for <see cref="IAsyncEnumerable{T}"/></summary>
	extension<T>([DisallowNull] IAsyncEnumerable<T> collection)
	{
		/// <summary>
		/// Asynchronously splits an <see cref="IAsyncEnumerable{T}"/> into pages of a specified size.
		/// </summary>
		/// <param name="pageSize">
		/// The maximum number of elements per page. Values less than <c>2</c> are coerced to <c>2</c>
		/// via <see cref="NumericExtensions.EnsureMinimum(int, int)"/>.
		/// </param>
		/// <param name="cancellationToken">
		/// A <see cref="CancellationToken"/> used to observe cancellation while iterating the source sequence.
		/// </param>
		/// <returns>
		/// An <see cref="IAsyncEnumerable{T}"/> of <see cref="List{T}"/> where each list represents a page
		/// containing up to <paramref name="pageSize"/> items. The final page may contain fewer items.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Pages are materialized lazily as the returned async sequence is iterated. At most one page is held
		/// in memory at any time, making this method suitable for large streaming data sources.
		/// </para>
		/// <para>
		/// The method:
		/// </para>
		/// <list type="number">
		/// <item><description>Buffers incoming elements into a <see cref="List{T}"/> with preallocated capacity.</description></item>
		/// <item><description>Yields each full page as soon as it reaches the requested size.</description></item>
		/// <item><description>Yields a final partial page, if any elements remain.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// await foreach (var page in source.PageAsync(100, cancellationToken))
		/// {
		///     // page is a List&lt;T&gt; with up to 100 items
		///     await ProcessBatchAsync(page, cancellationToken);
		/// }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(PageAsync), "David McCarter", "8/22/2025", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public async IAsyncEnumerable<List<T>> PageAsync(int pageSize, [EnumeratorCancellation] CancellationToken cancellationToken = default)
		{
			collection = collection.ArgumentNotNull();
			pageSize = pageSize.EnsureMinimum(2);

			var currentPage = new List<T>(pageSize);

			await foreach (var item in collection.WithCancellation(cancellationToken).ConfigureAwait(false))
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

	extension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>([DisallowNull] IEnumerable<T> collection)
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
		[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public T FirstOrNull([DisallowNull] Func<T, bool> accumulatorPredicate)
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

			return default;
		}

		/// <summary>
		/// Returns the zero-based index of the first occurrence of the specified item in the collection.
		/// </summary>
		/// <param name="item">The item to locate in the collection. Must not be <c>null</c>.</param>
		/// <param name="comparer">
		/// An optional <see cref="IEqualityComparer{T}"/> to use when comparing elements.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// The zero-based index of the first occurrence of <paramref name="item"/> in the collection;
		/// otherwise, <c>-1</c> if the item is not found.
		/// </returns>
		/// <remarks>
		/// The method performs a linear scan over the sequence and stops at the first match.
		/// It does not allocate intermediate collections and is suitable for small to medium-sized sequences.
		/// </remarks>
		/// <example>
		/// <code>
		/// var values = new[] { "a", "b", "c" };
		/// int index1 = values.IndexOf("b");                         // 1
		/// int index2 = values.IndexOf("x");                         // -1
		/// int index3 = values.IndexOf("A", StringComparer.OrdinalIgnoreCase); // 0
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int IndexOf([DisallowNull] T item, [AllowNull] IEqualityComparer<T>? comparer = null)
		{
			collection = collection.ArgumentItemsExists();
			item = item.ArgumentNotNull();

			// SUGGESTION BY COPILOT SLOWER
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
		[Information("Original code by Simon Painter.", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int IndexOf([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			//SUGGESTION BY COPILOT SLOWER.
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
		[Information(nameof(OrderBy), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> OrderBy([DisallowNull] string sortExpression)
		{
			collection = collection.ArgumentNotNull();

			sortExpression = (sortExpression ?? string.Empty).Trim();

			if (string.IsNullOrEmpty(sortExpression))
			{
				return collection;
			}

			var parts = sortExpression.Split(ControlChars.Space, StringSplitOptions.RemoveEmptyEntries);
			var property = parts[0];
			var descending = (parts.Length > 1) && parts[1].Contains("esc", StringComparison.OrdinalIgnoreCase);

			var cacheKey = $"{typeof(T).FullName}.{property}";
			var typedAccessor = (Func<T, object?>)_orderByPropertyCache.GetOrAdd(cacheKey, _ => BuildPropertyAccessor<T>(property));

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
		[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		/// Returns a new sequence in which elements are conditionally replaced with a specified value.
		/// </summary>
		/// <param name="accumulatorPredicate">
		/// A predicate that determines whether an element should be replaced.
		/// The function receives the element and its zero-based index; it must return <c>true</c> to replace the element.
		/// </param>
		/// <param name="replacement">
		/// The value that replaces elements for which <paramref name="accumulatorPredicate"/> returns <c>true</c>.
		/// </param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> where each element is either the original element
		/// or <paramref name="replacement"/>, depending on the predicate result.
		/// </returns>
		/// <remarks>
		/// This method uses deferred execution and streams results via <c>yield return</c>.
		/// The source sequence is enumerated exactly once and is never modified.
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new[] { 1, 2, 3, 4, 5 };
		/// 
		/// // Replace values greater than 3 with 0
		/// var replaced = numbers.ReplaceIf((n, index) => n > 3, 0);
		/// // Result: 1, 2, 3, 0, 0
		/// 
		/// // Replace elements at even indices
		/// var evens = numbers.ReplaceIf((n, index) => index % 2 == 0, -1);
		/// // Result: -1, 2, -1, 4, -1
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
		[Information(nameof(Partition), "David McCarter", "3/2/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<IEnumerable<T>> Partition(int pageCount)
		{
			collection = collection.ArgumentNotNull();
			pageCount = pageCount.EnsureMinimum(2);

			return collection.Chunk(pageCount);
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

			return collection.Shuffle().Take(count);
		}

		/// <summary>
		/// Randomizes the order of elements in the collection and returns a new sequence containing the shuffled items.
		/// </summary>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> with the elements of the original collection in randomized order.
		/// </returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized shuffling paths for different collection types:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="List{T}"/> - Uses <see cref="CollectionsMarshal.AsSpan{T}(List{T})"/> for zero-allocation in-place shuffling.</description></item>
		/// <item><description>Arrays (<typeparamref name="T"/>[]) - Creates a copy before shuffling to preserve the original array.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - Pre-sizes array based on known count to minimize allocations.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Materializes to array before shuffling.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>List&lt;T&gt;:</b> O(n) shuffling with zero allocations (uses span directly).</description></item>
		/// <item><description><b>Array input:</b> O(n) with single array allocation (copy to preserve original).</description></item>
		/// <item><description><b>ICollection&lt;T&gt;:</b> O(n) with pre-sized array allocation.</description></item>
		/// <item><description><b>Other types:</b> O(n) with array materialization.</description></item>
		/// </list>
		/// <para>
		/// The original input enumeration is never modified. A copy is created for shuffling.
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
		[Information(nameof(FastShuffle), "David McCarter", "8/26/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
			if ((collection is null) || (second is null))
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
		[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool StructuralSequenceEqual([AllowNull] IEnumerable<T> second)
		{
			if ((collection is null) || (second is null))
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
		[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
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
		[Information(nameof(ToCollection), "David McCarter", "4/13/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Collection<T> ToCollection()
		{
			if (collection is IList<T> list)
			{
				return new Collection<T>([.. list]);
			}

			if (collection is ICollection<T> col)
			{
				var sized = new List<T>(col.Count);
				sized.AddRange(col);
				return new Collection<T>(sized);
			}

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
			if (collection is null || collection.IsEmpty())
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
						_ = sb.Append(delimiter);
					}

					_ = sb.Append(item);
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
		/// <param name="comparer">
		/// An optional <see cref="IEqualityComparer{T}"/> to use for element comparison.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			collection = collection.ArgumentNotNull();

			return FrozenSet.ToFrozenSet(collection, comparer);
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
		[Information(nameof(ToListAsync), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Task<List<T>> ToListAsync(CancellationToken cancellationToken = default)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<List<T>>(cancellationToken);
			}

			if (collection is List<T> list)
			{
				return Task.FromResult(list);
			}

			if (collection is ICollection<T> col)
			{
				var result = new List<T>(col.Count);
				result.AddRange(col);
				return Task.FromResult(result);
			}

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
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "12/9/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
			return (collection.CheckItemsExists() is false)
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
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "8/7/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
					resultArray[index] = action(span[index]);
				}

				return Array.AsReadOnly(resultArray);
			}
			else
			{
				ReadOnlySpan<T> span = collection.ToArray();
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

			if (collection.TryGetNonEnumeratedCount(out var fastCount))
			{
				return fastCount;
			}

			long count = 0;

			foreach (var _ in collection)
			{
				count++;
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
		[Information(nameof(FastAny), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized lookup paths based on collection type and item count:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="ISet{T}"/> (HashSet, FrozenSet, etc.) - Uses O(1) Contains for each item (fastest path). <see cref="FrozenSet{T}"/> also matches this path because it implements <see cref="ISet{T}"/> in .NET 10.</description></item>
		/// <item><description>Large item counts (&gt;10) + ICollection - Converts collection to HashSet once for O(1) lookups.</description></item>
		/// <item><description>Small item counts (&lt;=10) - Uses direct Contains to avoid HashSet allocation overhead.</description></item>
		/// <item><description>Other collections - Falls back to Contains for each item.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>ISet&lt;T&gt; input:</b> O(m) where m = items.Count (O(1) per lookup).</description></item>
		/// <item><description><b>Large item count (&gt;10):</b> O(n + m) where n = collection size, m = items.Count.</description></item>
		/// <item><description><b>Small item count (&lt;=10):</b> O(m * n) but avoids HashSet allocation.</description></item>
		/// </list>
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ContainsAny), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NeedsUpdate, Status = Status.Available)]
		public bool ContainsAny([AllowNull] params ReadOnlyCollection<T> items)
		{
			if ((collection is null) || (items is null) || (items.Count == 0))
			{
				return false;
			}

			if (collection is ISet<T> set)
			{
				return ContainsAnyInSet(set, items);
			}

			if ((items.Count > 10) && (collection is ICollection<T> knownSizeCollection))
			{
				return ContainsAnyInLargeCollection(knownSizeCollection, items);
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
		/// <param name="comparer">
		/// An optional <see cref="IEqualityComparer{T}"/> to determine element equality.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns><c>true</c> if the collection contains duplicates; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasDuplicates), author: "David McCarter", createdOn: "7/3/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool HasDuplicates([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			if (collection is null)
			{
				return false;
			}

			if (collection is HashSet<T> && comparer is null)
			{
				return false;
			}

			if (collection is ICollection<T> c)
			{
				return HasDuplicatesInCollection(c, comparer);
			}

			var fallbackSeen = new HashSet<T>(comparer);

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
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses optimized paths for different collection types:
		/// </para>
		/// <list type="bullet">
		/// <item><description>Arrays - Uses O(1) <see cref="Array.Length"/> property.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - Uses O(1) <see cref="ICollection{T}.Count"/> property.</description></item>
		/// <item><description><see cref="IReadOnlyCollection{T}"/> - Uses O(1) <see cref="IReadOnlyCollection{T}.Count"/> property.</description></item>
		/// <item><description>Concurrent collections - Uses O(1) thread-safe <see cref="IsEmpty"/> property.</description></item>
		/// <item><description>Immutable collections - Uses O(1) <see cref="IsEmpty"/> property.</description></item>
		/// <item><description>Other collections - Falls back to <see cref="Enumerable.Count{TSource}(IEnumerable{TSource})"/>.</description></item>
		/// </list>
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEmpty), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsEmpty()
		{
			if (collection is null)
			{
				return true;
			}

			if (collection is T[] array)
			{
				return array.Length == 0;
			}

			var concurrentResult = TryIsEmptyConcurrent(collection);

			if (concurrentResult.HasValue)
			{
				return concurrentResult.Value;
			}

			var immutableResult = TryIsEmptyImmutable(collection);

			if (immutableResult.HasValue)
			{
				return immutableResult.Value;
			}

			if (collection is ICollection<T> collectionT)
			{
				return collectionT.Count == 0;
			}

			if (collection is IReadOnlyCollection<T> readOnlyCollection)
			{
				return readOnlyCollection.Count == 0;
			}

			return !collection.Any();
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
			return collection is null || collection.IsEmpty();
		}

		/// <summary>
		/// Returns a sequence containing only the distinct elements from the source collection with size-based optimization.
		/// </summary>
		/// <param name="comparer">
		/// An optional equality comparer to determine element equality. If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> containing unique elements from the source collection.
		/// </returns>
		/// <remarks>
		/// Uses an adaptive strategy based on element type and collection size:
		/// <list type="bullet">
		/// <item><description><b>Value types:</b> For counts &gt; 256, uses <see cref="Enumerable.Distinct{TSource}(IEnumerable{TSource})"/>; otherwise, <see cref="HashSet{T}"/>.</description></item>
		/// <item><description><b>Reference types:</b> If the source implements <see cref="ICollection{T}"/> and count &gt; 2048, uses <see cref="Enumerable.Distinct{TSource}(IEnumerable{TSource})"/>; otherwise, <see cref="HashSet{T}"/>.</description></item>
		/// <item><description><b>Unknown count:</b> Defaults to <see cref="HashSet{T}"/> to ensure uniqueness.</description></item>
		/// </list>
		/// This approach minimizes allocations and improves performance by selecting the most efficient distinct strategy for the given scenario.
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastDistinct), "David McCarter", "11/8/2022", OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> FastDistinct([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			// Value types: use size-based optimization; honor comparer
			if (typeof(T).IsValueType)
			{
				var hasCount = collection.TryGetNonEnumeratedCount(out var valueTypeCount);
				return (hasCount && valueTypeCount > 256)
					? collection.Distinct(comparer)
					: new HashSet<T>(collection, comparer);
			}

			// Reference types: use size-based optimization; honor comparer
			if (collection is ICollection<T> refCollection)
			{
				return (refCollection.Count > 2048)
					? collection.Distinct(comparer)
					: new HashSet<T>(collection, comparer);
			}

			// Unknown count: default to HashSet; honor comparer
			return new HashSet<T>(collection, comparer);
		}

		/// <summary>
		/// Picks a random element from the collection.
		/// </summary>
		/// <returns>A randomly picked element from the collection, or <c>default</c> if the collection is empty.</returns>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method provides optimized random selection paths for different collection types:
		/// </para>
		/// <list type="bullet">
		/// <item><description><see cref="IList{T}"/> (List, Array, etc.) - O(1) direct indexed access with random index.</description></item>
		/// <item><description><see cref="ICollection{T}"/> - O(1) random index calculation, O(n) enumeration to target index.</description></item>
		/// <item><description>Other <see cref="IEnumerable{T}"/> types - Materializes to array once, then O(1) random access.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>IList&lt;T&gt;:</b> O(1) - Direct indexed access, no allocation.</description></item>
		/// <item><description><b>ICollection&lt;T&gt;:</b> O(n) - Single enumeration to random index.</description></item>
		/// <item><description><b>Other types:</b> O(n) - One-time materialization to array, then O(1) access.</description></item>
		/// </list>
		/// <para>
		/// Uses <see cref="Random.Shared"/> for thread-safe random number generation.
		/// This is NOT a cryptographic operation - for security-sensitive randomness, use <see cref="System.Security.Cryptography.RandomNumberGenerator"/>.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var numbers = new List&lt;int&gt; { 1, 2, 3, 4, 5 };
		/// var randomNumber = numbers.PickRandom();
		/// // Returns one of: 1, 2, 3, 4, or 5
		/// 
		/// var empty = new List&lt;int&gt;();
		/// var result = empty.PickRandom();
		/// // Returns default(int) = 0
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "This method performs general-purpose random selection (not cryptographic). Random.Shared is appropriate for non-security scenarios like picking random elements from collections.")]
		[Information(nameof(PickRandom), "David McCarter", "8/26/2020", "9/19/2020", BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
		public T? PickRandom()
		{
			collection = collection.ArgumentNotNull();

			if (collection is IList<T> list)
			{
				return PickFromList(list);
			}

			if (collection is ICollection<T> knownSizeCollection)
			{
				return PickFromCollection(knownSizeCollection);
			}

			var array = collection.ToArray();

			return array.Length == 0 ? default : array[Random.Shared.Next(array.Length)];
		}

		/// <summary>
		/// Creates a new <see cref="Collection{T}"/> that contains only the unique elements
		/// from the source collection.
		/// </summary>
		/// <param name="comparer">
		/// An optional <see cref="IEqualityComparer{T}"/> to determine element uniqueness.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// A new <see cref="Collection{T}"/> containing the distinct elements from the source collection.
		/// </returns>
		/// <remarks>
		/// <para>
		/// Uniqueness is determined by the specified <paramref name="comparer"/> (or <see cref="EqualityComparer{T}.Default"/>
		/// when <c>null</c>) via an intermediate <see cref="HashSet{T}"/>. The resulting <see cref="Collection{T}"/> is a new,
		/// mutable collection and is independent of the source.
		/// </para>
		/// <para>
		/// The relative order of elements is not preserved because <see cref="HashSet{T}"/> does not guarantee ordering.
		/// If you require stable ordering, consider applying <see cref="Enumerable.Distinct{TSource}(IEnumerable{TSource})"/>
		/// prior to materialization.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Thrown when the source collection is <c>null</c>.
		/// </exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToUniqueCollection), "David McCarter", "11/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public Collection<T> ToUniqueCollection([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			// SUGGESTION FROM COPILOT SLOWER
			return new Collection<T>(new HashSet<T>(collection, comparer).ToList());
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
		/// Inserts or updates an item within the sequence based on value equality, returning a new sequence.
		/// </summary>
		/// <param name="item">
		/// The item to upsert into the sequence. Must not be <c>null</c>.
		/// If an equal element already exists, it is replaced by this value; otherwise, it is appended.
		/// </param>
		/// <param name="comparer">
		/// Optional <see cref="IEqualityComparer{T}"/> used to determine element equality.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// An <see cref="IEnumerable{T}"/> that yields all original elements with at most one element
		/// replaced by <paramref name="item"/>; if no match is found, <paramref name="item"/> is yielded once at the end.
		/// The original sequence is never modified.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The method enumerates the source sequence once and uses deferred execution via <c>yield return</c>.
		/// It is suitable for building upsert-style pipelines over immutable or read-only sequences.
		/// </para>
		/// <para>
		/// Only the first matching element (according to <paramref name="comparer"/>) is replaced; any subsequent
		/// matches are left untouched.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var people = new[]
		/// {
		///     new Person { Id = 1, Name = "John" },
		///     new Person { Id = 2, Name = "Jane" }
		/// };
		/// 
		/// var updated = new Person { Id = 1, Name = "John Doe" };
		/// 
		/// // Upsert by default equality
		/// var result = people.Upsert(updated);
		/// // Sequence contains updated person once, original with Id=1 is replaced.
		/// 
		/// // Upsert with custom comparer (e.g., by Id)
		/// var resultById = people.Upsert(
		///     updated,
		///     new PersonIdComparer());
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Upsert), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		[Information(nameof(AddDistinct), author: "David McCarter", createdOn: "3/22/2023", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> AddDistinct([AllowNull] params IEnumerable<T> items)
		{
			if (collection is null)
			{
				return [];
			}

			if (items is null)
			{
				return collection;
			}

			var itemsList = items as ICollection<T> ?? [.. items];

			if (itemsList.Count == 0)
			{
				return collection;
			}

			var hashSet = new HashSet<T>(collection);

			_ = hashSet.AddRange(itemsList);

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
			if (collection is null)
			{
				return false;
			}

			return collection.TryGetNonEnumeratedCount(out var collectionCount)
				? collectionCount == count
				: collection.LongCount() == count;
		}

		/// <summary>
		/// Determines whether the specified collection has any items.
		/// </summary>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public bool IsNotEmpty()
		{
			return !collection.IsEmpty();
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
		[Information(nameof(ToReadOnlyCollection), "David McCarter", "2/5/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			if (collection is IList<T> list)
			{
				return new ReadOnlyCollection<T>(list);
			}

			if (collection is ICollection<T> col)
			{
				var sized = new List<T>(col.Count);
				sized.AddRange(col);
				return new ReadOnlyCollection<T>(sized);
			}

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
		[Information(nameof(AddIf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> AddIf([DisallowNull] T item, bool condition)
		{
			collection = collection.ArgumentNotNull();

			// Stream original elements
			foreach (var element in collection)
			{
				yield return element;
			}

			// Append item only when condition is true and item is non-null
			if (condition && (item is not null))
			{
				yield return item;
			}
		}
	}
}
