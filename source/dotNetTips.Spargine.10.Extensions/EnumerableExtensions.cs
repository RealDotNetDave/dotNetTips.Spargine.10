// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-07-2025
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="McCarter Consulting">
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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;
using Microsoft.VisualBasic;
using ControlChars = DotNetTips.Spargine.Core.ControlChars;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a collection of static methods for querying objects that implement <see cref="IEnumerable{T}"/>.
/// These extensions add functionality for adding, checking, and manipulating elements within enumerable collections.
/// </summary>
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineEnumerableExtensions")]
public static class EnumerableExtensions
{
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
			pageSize = pageSize.EnsureMinimum(1);

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
		[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
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
		/// Finds the index of the first occurrence of an item in the collection.
		/// </summary>
		/// <param name="item">The item to find in the collection.</param>
		/// <returns>The zero-based index of the first occurrence of item within the entire collection, if found; otherwise, -1.</returns>
		/// <remarks>
		/// This method uses <see cref="EqualityComparer{T}.Default"/> to compare elements.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int IndexOf([DisallowNull] T item)
		{
			collection = collection.ArgumentItemsExists();
			item = item.ArgumentNotNull();

			var index = 0;
			var comparer = EqualityComparer<T>.Default;

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
		/// Finds the index of the first occurrence of an item in the collection that matches the specified accumulatorFunction.
		/// </summary>
		/// <param name="accumulatorPredicate">The accumulatorFunction to accumulatorPredicate against the elements of the collection.</param>
		/// <returns>The zero-based index of the first occurrence of an item that matches the accumulatorFunction within the entire collection, if found; otherwise, -1.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("Original code by Simon Painter.", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int IndexOf([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			var result = collection.Select((value, index) => (value, index)).FirstOrDefault(value => accumulatorPredicate.Invoke(value.value));

			return result.Equals(default((T x, int i))) ? -1 : result.index;
		}

		/// <summary>
		/// Finds the index of the first occurrence of an item in the collection using a specified comparer.
		/// </summary>
		/// <param name="item">The item to find in the collection.</param>
		/// <param name="comparer">The equality comparer to use for comparing items.</param>
		/// <returns>The zero-based index of the first occurrence of item within the entire collection, if found; otherwise, -1.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		/// Orders the elements of a collection according to a specified sort expression.
		/// </summary>
		/// <param name="sortExpression">The sort expression used for ordering. Must be a valid property name of <typeparamref name="T"/>.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> that contains the elements of the input sequence ordered according to the sort expression.</returns>
		/// <exception cref="ArgumentException">Thrown if <paramref name="sortExpression"/> is not a valid property name of <typeparamref name="T"/>.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(OrderBy), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> OrderBy([DisallowNull] string sortExpression)
		{
			collection = collection.ArgumentNotNull();

			sortExpression += string.Empty;

			var parts = sortExpression.Split(Convert.ToChar(" ", CultureInfo.InvariantCulture));
			var descending = false;
			var property = string.Empty;

			if (parts.LongLength > 0 && !string.IsNullOrEmpty(parts[0]))
			{
				property = parts[0];

				if (parts.LongLength > 1)
				{
					@descending = CultureInfo.InvariantCulture.TextInfo
						.ToLower(parts[1])
						.Contains("esc", StringComparison.OrdinalIgnoreCase);
				}

				var prop = typeof(T).GetRuntimeProperty(property);

				if (prop is not null && prop.CheckIsNotNull(throwException: true))
				{
					return @descending
						? collection.OrderByDescending(x => prop.GetValue(x, null))
						: collection.OrderBy(x => prop.GetValue(x, null));
				}
			}

			return collection;
		}

		/// <summary>
		/// Orders the elements of a collection by a key selected from each element.
		/// </summary>
		/// <param name="accumulatorFunction">A accumulatorFunction to extract a key from an element.</param>
		/// <returns>An <see cref="IOrderedEnumerable{T}"/> whose elements are sorted according to a key.</returns>
		/// <returns>IOrderedEnumerable&lt;T&gt;.</returns>
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
		/// Partitions the elements of a collection into chunks of a specified size.
		/// </summary>
		/// <param name="pageCount">The size of each partition.</param>
		/// <returns>An enumerable of enumerable, where each inner enumerable represents a partition of the original collection.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="pageCount"/> is less than or equal to 0.</exception>
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
			pageCount = pageCount.EnsureMinimum(1);

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
		/// <param name="accumulatorPredicate">A accumulatorFunction that determines whether an element should be replaced, based on the element and its index.</param>
		/// <param name="replacement">The replacement value for elements that meet the condition.</param>
		/// <returns>A new collection with elements replaced based on the specified condition.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("Original code by Simon Painter.", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.None, Status = Status.Available)]
		public IEnumerable<T> ReplaceIf([DisallowNull] Func<T, int, bool> accumulatorPredicate, T replacement)
		{
			collection = collection.ArgumentNotNull();
			accumulatorPredicate = accumulatorPredicate.ArgumentNotNull();

			return collection.Select((obj, pos) => accumulatorPredicate.Invoke(obj, pos) ? replacement : obj);
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
		/// Fasts the shuffle.
		/// </summary>
		/// <returns>System.Collections.Generic.IEnumerable&lt;T&gt;.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastShuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.NotRequired, Status = Status.New)]
		public IEnumerable<T> FastShuffle()
		{
			collection = collection.ArgumentNotNull();

			return collection.Shuffle();
		}

		/// <summary>
		/// Splits the specified collection into smaller collections of a specified size.
		/// </summary>
		/// <param name="size">The size of each smaller collection.</param>
		/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="size"/> is less than or equal to 0.</exception>
		/// <remarks>
		/// This method uses deferred execution and will only process elements as they are requested.
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Split), "David McCarter", "3/2/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public IEnumerable<IEnumerable<T>> Split(int size)
		{
			collection = collection.ArgumentNotNull();
			size = size.EnsureMinimum(1);

			var start = 0;
			var items = collection as T[] ?? [.. collection];

			while (start < items.Length)
			{
				var count = Math.Min(size, items.Length - start);

				yield return new ArraySegment<T>(items, start, count);

				start += count;
			}
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
			if (collection is null || second is null)
			{
				return false;
			}

			if (ReferenceEquals(collection, second))
			{
				return true;
			}

			//RECOMENDATION FROM COPILOT SLOWER.
			using (var firstEnumerator = collection.GetEnumerator())
			{
				using (var secondEnumerator = second.GetEnumerator())
				{
					while (firstEnumerator.MoveNext())
					{
						if (!secondEnumerator.MoveNext() ||
							!StructuralComparisons.StructuralEqualityComparer
								.Equals(firstEnumerator.Current, secondEnumerator.Current))
						{
							return false;
						}
					}

					return !secondEnumerator.MoveNext();
				}
			}
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
		/// Converts the specified collection to a <see cref="Collection{T}"/>.
		/// </summary>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToCollection), "David McCarter", "4/13/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public Collection<T> ToCollection()
		{
			collection = collection.ArgumentItemsExists();

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
		public string ToDelimitedString([ConstantExpected] in char delimiter = ControlChars.Comma)
		{
			if (collection is null || collection.FastCount() == 0)
			{
				return string.Empty;
			}

			var sb = _stringBuilderPool.Value.Get().Clear();

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
				_stringBuilderPool.Value.Return(sb);
			}
		}

		/// <summary>
		/// Converts the specified enumerable list to a <see cref="FrozenSet{T}"/>.
		/// </summary>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet() => FrozenSet.ToFrozenSet(collection);

		/// <summary>
		/// Converts the specified enumerable collection to an <see cref="ImmutableList{T}"/>.
		/// </summary>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableList<T> ToImmutable()
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
		[Information(nameof(ToImmutable), "David McCarter", "6/7/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableArray<T> ToImmutableArray()
		{
			return collection.DoesNotHaveItems() ? [] : [.. collection];
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
		/// Processes each item in the given collection using the specified action.
		/// </summary>
		/// <param name="action">The action to apply to each item in the collection.</param>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "12/9/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void FastProcessor([DisallowNull] Action<T> action)
		{
			collection = collection.ArgumentNotNull();
			action = action.ArgumentNotNull();

			if (collection is List<T> list)
			{
				var span = list.AsReadOnlySpan();
				var itemCount = span.Length;

				for (var index = 0; index < itemCount; index++)
				{
					action.Invoke(span[index]);
				}
			}
			else
			{
				var span = CollectionsMarshal.AsSpan(collection.ToList());
				var itemCount = span.Length;

				for (var index = 0; index < itemCount; index++)
				{
					action(span[index]);
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
		/// Modifies each item in the given collection using the specified accumulatorFunction and returns a read-only collection of the modified items.
		/// </summary>
		/// <param name="action">The accumulatorFunction to apply to each item in the collection.</param>
		/// <returns>A read-only collection of the modified items.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastModifyCollection), author: "David McCarter", createdOn: "8/7/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<T> FastModifyCollection([DisallowNull] Func<T, T> action)
		{
			collection = collection.ArgumentNotNull();
			action = action.ArgumentNotNull();

			if (collection is List<T> list)
			{
				var span = CollectionsMarshal.AsSpan(list);
				var processedCollection = new ReadOnlyCollectionBuilder<T>(span.Length);
				var itemCount = span.Length;

				for (var index = 0; index < itemCount; index++)
				{
					processedCollection.Add(action.Invoke(span[index]));
				}

				return processedCollection.AsReadOnly();
			}
			else
			{
				var span = CollectionsMarshal.AsSpan(collection.ToList());
				var processedCollection = new ReadOnlyCollectionBuilder<T>(span.Length);
				var itemCount = span.Length;

				for (var index = 0; index < itemCount; index++)
				{
					processedCollection.Add(action(span[index]));
				}

				return processedCollection.AsReadOnly();
			}
		}

		/// <summary>
		/// Counts the number of elements in the specified collection.
		/// </summary>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastCount), "David McCarter", "5/21/2022", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public long FastCount()
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
		[Information(nameof(FastCount), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public long FastCount([DisallowNull] Func<T, bool> accumulatorPredicate)
		{
			return collection.ArgumentNotNull().Count(accumulatorPredicate.ArgumentNotNull());
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

			//RECOMENDATION FROM COPILOT SLOWER.
			foreach (var item in collection)
			{
				if (accumulatorPredicate.Invoke(item) is false)
				{
					return false;
				}
			}

			return true;
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
		public bool ContainsAny([AllowNull] params IReadOnlyCollection<T>[] items)
		{
			if (collection is null || items is null || items.Length == 0)
			{
				return false;
			}

			foreach (var itemCollection in items)
			{
				if (itemCollection is not null && itemCollection.Count > 0 && collection.Any(itemCollection.Contains))
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
			if (collection.DoesNotHaveItems())
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
		[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool DoesNotHaveItems() => collection?.Count() <= 0;

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
			if (collection == null)
			{
				return true;
			}

			using (var enumerator = collection.GetEnumerator())
			{
				return !enumerator.MoveNext();
			}
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

			//RECOMENDATION FROM COPILOT SLOWER.
			return collection.Distinct();
		}

		/// <summary>
		/// Pages the specified collection into a sequence of pages each containing a maximum of <paramref name="pageSize"/> elements.
		/// </summary>
		/// <param name="pageSize">Size of each page.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> where each item is a page of the original collection containing up to <paramref name="pageSize"/> elements.</returns>
		/// <remarks>
		/// This method uses deferred execution to generate pages only when they are enumerated.
		/// </remarks>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Page), "David McCarter", "11/21/2010", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public IEnumerable<IEnumerable<T>> Page(int pageSize)
		{
			collection = collection.ArgumentNotNull();
			pageSize = pageSize.EnsureMinimum(1);

			using (var enumerator = collection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					var currentPage = new List<T>(pageSize);

					do
					{
						currentPage.Add(enumerator.Current);
					} while (currentPage.Count < pageSize && enumerator.MoveNext());

					yield return currentPage;
				}
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

			return collection.HasItems() ? collection.FastShuffle(1).FirstOrDefault() : default;
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
		[Information(nameof(Upsert), "David McCarter", "11/21/2020", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddFirst), "David McCarter", "10/24/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
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
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public bool HasItems(int count) => collection is null ? false : collection.Count() == count;

		/// <summary>
		/// Determines whether the specified collection has any items.
		/// </summary>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public bool HasItems() => collection is null ? false : collection.Count() > 0;

		/// <summary>
		/// Converts a <see cref="ConcurrentBag{T}"/> to a <see cref="ReadOnlyCollection{T}"/>.
		/// </summary>
		/// <returns>A <see cref="ReadOnlyCollection{T}"/> that contains elements from the input collection.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToReadOnlyCollection), "David McCarter", "2/5/2024", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			return new ReadOnlyCollection<T>([.. collection.ArgumentNotNull()]);
		}

		/// <summary>
		/// Adds the specified item to the collection if the condition is true.
		/// </summary>
		/// <param name="item">The item to add to the collection.</param>
		/// <param name="condition">The condition that determines if the item should be added.</param>
		/// <returns>An <see cref="IEnumerable{T}"/> that includes the original collection and, if the condition is true, the specified item.</returns>
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
