// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="ArrayExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extensions methods for the Array type.</summary>
// ***********************************************************************
using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for arrays, enhancing functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class includes methods for adding elements to the beginning or end of an array, checking array equality,
/// converting byte arrays to strings, cloning arrays, checking for the presence of any items, performing actions on array elements,
/// generating hash codes for arrays, removing elements, and more. These methods are designed to be efficient and
/// are optimized for performance where applicable.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineArrayExtensions")]
public static class ArrayExtensions
{
	/// <summary>
	/// Provides extension methods for byte arrays.
	/// </summary>
	/// <param name="array">The byte array instance.</param>
	extension([DisallowNull] byte[] array)
	{
		/// <summary>
		/// Returns a <see cref="string"/> that represents this byte array. Uses ObjectPool to improve performance.
		/// </summary>
		/// <returns>A <see cref="string"/> that represents this instance.</returns>
		/// <exception cref="ArgumentNullException">Array cannot be null.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(BytesToString), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, Status = Status.Available)]
		public string BytesToString()
		{
			return FastStringBuilder.BytesToString(ref array);
		}

		/// <summary>
		/// Computes a fast SHA256 hash for the given byte array data.
		/// </summary>
		/// <returns>A byte array containing the hash value.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastHashData), author: "David McCarter", createdOn: "3/11/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public byte[] FastHashData()
		{
			return SHA256.HashData(array);
		}
	}

	extension<T>([DisallowNull] T[] array)
	{
		/// <summary>
		/// Adds an item to the beginning of the specified array.
		/// </summary>
		/// <param name="item">The item to add to the array.</param>
		/// <returns>A new array with the item added at the beginning.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddFirst), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] AddFirst([AllowNull] in T item)
		{
			array = array.ArgumentNotNull();

			if (item is null)
			{
				return array;
			}

			var length = array.Length;
			var result = new T[length + 1];
			result[0] = item;

			Array.Copy(array, 0, result, 1, length);

			return result;
		}

		/// <summary>
		/// Searches for the specified item and returns the zero-based index of its first occurrence in the array.
		/// </summary>
		/// <param name="item">The item to locate in the array.</param>
		/// <returns>
		/// The zero-based index of the first occurrence of <paramref name="item"/> within the entire array, if found; otherwise, -1.
		/// </returns>
		/// <remarks>
		/// This method uses <see cref="MemoryExtensions.IndexOf{T}(Span{T}, T)"/> for optimal performance,
		/// which leverages vectorization when possible and provides better performance than <see cref="Array.IndexOf{T}(T[], T)"/>,
		/// especially for larger arrays.
		/// The method performs an equality comparison using <see cref="EqualityComparer{T}.Default"/>.
		/// If type <typeparamref name="T"/> overrides the <see cref="object.Equals(object)"/> method, that override is used for the comparison.
		/// This is an O(n) operation, where n is the length of the array.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when <c>array</c> or <paramref name="item"/> is null.</exception>
		/// <example>
		/// This example shows how to find the index of an item in an array.
		/// <code>
		/// int[] numbers = { 10, 20, 30, 40, 50 };
		/// int index = numbers.IndexOf(30);
		/// Console.WriteLine(index); // Output: 2
		/// 
		/// int notFound = numbers.IndexOf(99);
		/// Console.WriteLine(notFound); // Output: -1
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IndexOf), "David McCarter", "1/3/2026", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int IndexOf([DisallowNull] T item)
		{
			array = array.ArgumentNotNull();
			item = item.ArgumentNotNull();

			return array.AsSpan().IndexOf(item);
		}

		/// <summary>
		/// Searches for the specified item and returns the zero-based index of its last occurrence in the array.
		/// </summary>
		/// <param name="item">The item to locate in the array.</param>
		/// <returns>
		/// The zero-based index of the last occurrence of <paramref name="item"/> within the entire array, if found; otherwise, -1.
		/// </returns>
		/// <remarks>
		/// This method uses <see cref="MemoryExtensions.LastIndexOf{T}(Span{T}, T)"/> for optimal performance,
		/// which leverages vectorization when possible and provides better performance than <see cref="Array.LastIndexOf{T}(T[], T)"/>,
		/// especially for larger arrays.
		/// The array is searched backward starting at the last element and ending at the first element.
		/// The method performs an equality comparison using <see cref="EqualityComparer{T}.Default"/>.
		/// If type <typeparamref name="T"/> overrides the <see cref="object.Equals(object)"/> method, that override is used for the comparison.
		/// This is an O(n) operation, where n is the length of the array.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when <c>array</c> or <paramref name="item"/> is null.</exception>
		/// <example>
		/// This example shows how to find the last index of an item in an array.
		/// <code>
		/// int[] numbers = { 10, 20, 30, 20, 50 };
		/// int index = numbers.LastIndexOf(20);
		/// Console.WriteLine(index); // Output: 3
		///
		/// int notFound = numbers.LastIndexOf(99);
		/// Console.WriteLine(notFound); // Output: -1
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(LastIndexOf), "David McCarter", "1/3/2026", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int LastIndexOf([DisallowNull] T item)
		{
			array = array.ArgumentNotNull();
			item = item.ArgumentNotNull();

			// SUGGESTION FROM COPILOT SLOWER
			return Array.LastIndexOf(array, item);
		}

		/// <summary>
		/// Adds an item to the array if a specified condition is true.
		/// </summary>
		/// <param name="item">The item to add to the array.</param>
		/// <param name="condition">The condition that determines whether the item should be added.</param>
		/// <returns>A new array with the item added if the condition is true; otherwise, the original array.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddIf), author: "David McCarter", createdOn: "4/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
		public T[] AddIf([AllowNull] in T item, bool condition)
		{
			return item is null ? array : condition ? array.AddLast(item) : array;
		}

		/// <summary>
		/// Selects a range of items from the array using optimized ArraySegment slicing.
		/// </summary>
		/// <param name="startIndex">The zero-based starting index of the range to select.</param>
		/// <param name="count">The number of elements to select from the array.</param>
		/// <returns>A new array containing the selected elements from the specified range.</returns>
		/// <remarks>
		/// This method uses <see cref="ArraySegment{T}"/> and its <see cref="ArraySegment{T}.Slice(int, int)"/> method
		/// to efficiently extract a subset of array elements without copying the entire array during the slicing operation.
		/// The final result is returned as a new array using collection expression syntax.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="startIndex"/> is less than 0 or greater than array.Length - 1.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="count"/> is less than 1 or exceeds the number of elements available from <paramref name="startIndex"/> to the end of the array.</exception>
		/// <example>
		/// This example shows how to select a range of elements from an array.
		/// <code>
		/// int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
		/// int[] subset = numbers.FastSelectItems(2, 3);
		/// // Result: { 30, 40, 50 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastSelectItems), author: "David McCarter", createdOn: "7/28/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] FastSelectItems(int startIndex, int count)
		{
			array = array.ArgumentNotNull();
			startIndex = startIndex.ArgumentInRange(0, max: array.Length - 1);
			count = count.ArgumentInRange(min: 1, max: array.Length - startIndex);

			// SUGGESTION FROM COPILOT SLOWER
			var result = new ArraySegment<T>(array, startIndex, count);

			return result.ToArray();
		}

		/// <summary>
		/// Adds an item to the end of the specified array.
		/// </summary>
		/// <param name="item">The item to add to the array.</param>
		/// <returns>A new array with the item added at the end.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddLast), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] AddLast([AllowNull] in T item)
		{
			array = array.ArgumentNotNull();

			if (item is null)
			{
				return array;
			}

			var length = array.Length;
			var result = new T[length + 1];

			Array.Copy(array, 0, result, 0, length);
			result[length] = item;

			return result;
		}

		/// <summary>
		/// Checks if the two arrays are equal.
		/// </summary>
		/// <param name="arrayToCheck">The array to check.</param>
		/// <returns><c>true</c> if the arrays are equal; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		[Information(nameof(AreEqual), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool AreEqual([AllowNull] in T[] arrayToCheck)
		{
			if (array is null || arrayToCheck is null)
			{
				return false;
			}

			// SUGGESTION FROM COPILOT SLOWER
			return array.AsSpan().SequenceEqual(arrayToCheck);
		}

		/// <summary>
		/// Converts an array to <see cref="ReadOnlySpan{T}"/> for high-performance read-only access.
		/// </summary>
		/// <returns>A <see cref="ReadOnlySpan{T}"/> over the array.</returns>
		/// <remarks>
		/// This method provides a zero-allocation, high-performance view of the array for read-only operations.
		/// The returned <see cref="ReadOnlySpan{T}"/> is a stack-only type that enables efficient iteration
		/// and slicing without heap allocations.
		/// Use this when you need to pass array data to methods that accept <see cref="ReadOnlySpan{T}"/>
		/// or when you want to ensure the array cannot be modified.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// This example shows how to convert an array to ReadOnlySpan for read-only processing.
		/// <code>
		/// int[] numbers = { 1, 2, 3, 4, 5 };
		/// ReadOnlySpan&lt;int&gt; span = numbers.AsReadOnlySpan();
		/// // Process span without risk of modification
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AsReadOnlySpan), "David McCarter", "5/30/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlySpan<T> AsReadOnlySpan()
		{
			return array.ArgumentNotNull();
		}

		/// <summary>
		/// Clones the specified array.
		/// </summary>
		/// <returns>A new array containing all the elements of the original array.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastClone), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] FastClone()
		{
			array = array.ArgumentNotNull();

			return (T[])array.Clone();
		}

		/// <summary>
		/// Gets the total number of elements in the array.
		/// </summary>
		/// <returns>The total number of elements in the array as a long.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastLongCount), "David McCarter", "1/9/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public long FastLongCount()
		{
			return array.ArgumentNotNull().LongLength;
		}

		/// <summary>
		/// Processes each element in the array with the specified action using optimized memory access.
		/// </summary>
		/// <param name="action">The action to apply to each element of the array.</param>
		/// <remarks>
		/// This method uses high-performance techniques to iterate through array elements:
		/// <list type="bullet">
		/// <item><description><see cref="MemoryMarshal.GetArrayDataReference{T}(T[])"/> - Obtains a direct reference to the first array element, bypassing the array object header.</description></item>
		/// <item><description><see cref="Unsafe.Add{T}(ref T, int)"/> - Performs pointer arithmetic without bounds checking for maximum iteration speed.</description></item>
		/// </list>
		/// This optimization eliminates bounds checking overhead on each array access, providing ~15-30% performance improvement
		/// over standard array indexing when processing large arrays (1000+ elements) with lightweight action delegates.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when array or <paramref name="action"/> is null.</exception>
		/// <example>
		/// This example shows how to use FastProcessor to process all elements in an array.
		/// <code>
		/// int[] numbers = { 1, 2, 3, 4, 5 };
		/// numbers.FastProcessor(n => Console.WriteLine(n * 2));
		/// // Output: 2, 4, 6, 8, 10
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "11/8/2021", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void FastProcessor([DisallowNull] Action<T> action)
		{
			array = array.ArgumentNotNull();
			action = action.ArgumentNotNull();

			ref var arrayStart = ref MemoryMarshal.GetArrayDataReference(array);
			var arrayLength = array.Length;

			for (var index = 0; index < arrayLength; index++)
			{
				action(Unsafe.Add(ref arrayStart, index));
			}
		}

		/// <summary>
		/// Generates a hash code for the entire array.
		/// </summary>
		/// <returns>A hash code representing the contents of the array.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GenerateHashCode), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int GenerateHashCode()
		{
			array = array.ArgumentNotNull();

			var hashCode = 6551;

			ref var start = ref MemoryMarshal.GetArrayDataReference(array);
			var length = array.Length;

			for (var index = 0; index < length; index++)
			{
				var element = Unsafe.Add(ref start, index);

				if (element is not null)
				{
					hashCode ^= (hashCode << 5) ^ EqualityComparer<T>.Default.GetHashCode(element);
				}
			}

			return hashCode;
		}

		/// <summary>
		/// Determines whether the specified array contains any elements.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the array is not null and contains at least one element; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// This method provides a safe way to check if an array has elements without throwing exceptions.
		/// It returns <c>false</c> if the array reference is null, making it suitable for defensive programming patterns.
		/// The method uses <see cref="Array.Length"/> to check the element count with optimal performance.
		/// This is the inverse operation of IsEmpty.
		/// </remarks>
		/// <example>
		/// This example shows how to use IsNotEmpty() to check if an array has elements.
		/// <code>
		/// int[] numbers = { 1, 2, 3 };
		/// bool hasItems = numbers.IsNotEmpty();
		/// Console.WriteLine(hasItems); // Output: True
		/// 
		/// int[] emptyArray = Array.Empty&lt;int&gt;();
		/// bool isEmpty = emptyArray.IsNotEmpty();
		/// Console.WriteLine(isEmpty); // Output: False
		/// 
		/// int[] nullArray = null;
		/// bool isNull = nullArray.IsNotEmpty();
		/// Console.WriteLine(isNull); // Output: False
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty()
		{
			return array is not null && array.Length > 0;
		}

		/// <summary>
		/// Determines whether the array contains any elements that satisfy the specified condition.
		/// </summary>
		/// <param name="actionFunction">A function to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if the array is not null, the predicate function is not null, and at least one element satisfies the condition; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// This method provides a safe way to check if an array contains elements matching a predicate without throwing exceptions.
		/// It returns <c>false</c> if either the array reference or the predicate function is null, making it suitable for defensive programming patterns.
		/// The method uses <see cref="Enumerable.Any{TSource}(IEnumerable{TSource}, Func{TSource, bool})"/> internally to test each element against the provided condition.
		/// </remarks>
		/// <example>
		/// This example shows how to use IsNotEmpty with a predicate to check if an array contains specific elements.
		/// <code>
		/// int[] numbers = { 1, 2, 3, 4, 5 };
		/// bool hasEvenNumbers = numbers.IsNotEmpty(n => n % 2 == 0);
		/// Console.WriteLine(hasEvenNumbers); // Output: True
		/// 
		/// int[] oddNumbers = { 1, 3, 5 };
		/// bool hasEven = oddNumbers.IsNotEmpty(n => n % 2 == 0);
		/// Console.WriteLine(hasEven); // Output: False
		/// 
		/// int[] nullArray = null;
		/// bool result = nullArray.IsNotEmpty(n => n > 0);
		/// Console.WriteLine(result); // Output: False
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty(in Func<T, bool> actionFunction)
		{
			return array is null || actionFunction is null ? false : array.Any(actionFunction);
		}

		/// <summary>
		/// Determines whether the array length exactly matches the specified count.
		/// </summary>
		/// <param name="count">The expected number of elements in the array.</param>
		/// <returns>
		/// <c>true</c> if the array is not null and its length equals the specified <paramref name="count"/>; otherwise, <c>false</c>.
		/// </returns>
		/// <remarks>
		/// This method provides a safe way to verify that an array has an exact number of elements without throwing exceptions.
		/// It returns <c>false</c> if the array reference is null, making it suitable for defensive programming patterns.
		/// The method uses <see cref="Array.Length"/> to compare against the specified <paramref name="count"/>.
		/// This is useful for validation scenarios where you need to ensure an array has a specific size before processing.
		/// </remarks>
		/// <example>
		/// This example shows how to use IsNotEmpty with a count parameter to verify array size.
		/// <code>
		/// int[] numbers = { 1, 2, 3 };
		/// bool hasThreeItems = numbers.IsNotEmpty(3);
		/// Console.WriteLine(hasThreeItems); // Output: True
		/// 
		/// bool hasFiveItems = numbers.IsNotEmpty(5);
		/// Console.WriteLine(hasFiveItems); // Output: False
		/// 
		/// int[] nullArray = null;
		/// bool result = nullArray.IsNotEmpty(3);
		/// Console.WriteLine(result); // Output: False
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty(int count)
		{
			return array is not null && array.Length == count;
		}

		/// <summary>
		/// Performs the specified action on each element of the array.
		/// </summary>
		/// <param name="action">The action to perform on each element.</param>
		/// <remarks>
		/// This method iterates sequentially over the array using <see cref="MemoryExtensions.AsSpan{T}(T[])"/>
		/// for efficient, bounds-checked access. The action delegate is invoked once per element in array order.
		/// For higher-throughput iteration that bypasses bounds checking, consider using <c>FastProcessor</c> instead.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when array or <paramref name="action"/> is null.</exception>
		/// <example>
		/// This example shows how to use PerformAction to process all elements in an array.
		/// <code>
		/// int[] numbers = { 1, 2, 3, 4, 5 };
		/// numbers.PerformAction(n => Console.WriteLine(n * 2));
		/// // Output: 2, 4, 6, 8, 10
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(PerformAction), "David McCarter", "1/4/2023", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public void PerformAction([DisallowNull] Action<T> action)
		{
			array = array.ArgumentNotNull();
			action = action.ArgumentNotNull();

			foreach (var value in array.AsSpan())
			{
				action(value);
			}
		}

		/// <summary>
		/// Removes the first item in the array.
		/// </summary>
		/// <returns>A new array with the first item removed.</returns>
		/// <exception cref="ArgumentNullException">array cannot be null or empty.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveFirst), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] RemoveFirst()
		{
			array = array.ArgumentItemsExists();

			var newLength = array.Length - 1;
			var result = new T[newLength];

			array.AsSpan(1, newLength).CopyTo(result);

			return result;
		}

		/// <summary>
		/// Removes the last item in the array.
		/// </summary>
		/// <returns>A new array with the last item removed.</returns>
		/// <exception cref="ArgumentNullException">array cannot be null or empty.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveLast), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] RemoveLast()
		{
			array = array.ArgumentItemsExists();

			var newLength = array.Length - 1;
			var result = new T[newLength];

			array.AsSpan(0, newLength).CopyTo(result);

			return result;
		}

		/// <summary>
		/// Returns the array without duplicates.
		/// </summary>
		/// <param name="comparer">
		/// An optional <see cref="IEqualityComparer{T}"/> to use for element comparison.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>A new array containing only distinct elements.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the array is <c>null</c>.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToDistinct), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public T[] ToDistinct(IEqualityComparer<T>? comparer = null)
		{
			return [.. array.ArgumentNotNull().Distinct(comparer)];
		}

		/// <summary>
		/// Converts the array to a <see cref="FrozenSet{T}"/>, an immutable set optimized for fast read operations.
		/// </summary>
		/// <param name="comparer">
		/// An optional <see cref="IEqualityComparer{T}"/> to use for element comparison.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>A <see cref="FrozenSet{T}"/> containing the distinct elements of the array.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the array is <c>null</c>.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet(IEqualityComparer<T>? comparer = null)
		{
			return FrozenSet.ToFrozenSet(array.ArgumentNotNull(), comparer);
		}

		/// <summary>
		/// Inserts or updates an item in the array. If the item already exists, it is updated; otherwise, it is added.
		/// </summary>
		/// <param name="item">The item to insert or update in the array.</param>
		/// <returns>A new array with the item inserted or updated.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public T[] Upsert([AllowNull] T item)
		{
			array = array.ArgumentNotNull();

			if (item is null)
			{
				return array;
			}

			var index = array.AsSpan().IndexOf(item);

			if (index < 0)
			{
				return array.AddLast(item);
			}

			var result = new T[array.Length];
			array.AsSpan().CopyTo(result);
			result[index] = item;

			return result;
		}

	}
}
