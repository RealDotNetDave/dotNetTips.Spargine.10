// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-28-2026
// ***********************************************************************
// <copyright file="ArrayExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// High-performance extension methods for arrays, providing utilities for adding elements (AddFirst, AddLast,
// AddIf), removing elements (RemoveFirst, RemoveLast), searching (IndexOf, LastIndexOf), cloning (FastClone),
// hashing (GenerateHashCode), iterating (FastProcessor, PerformAction), converting (ToDistinct, ToFrozenSet,
// AsReadOnlySpan, FastSelectItems), checking presence (IsNotEmpty), inserting or updating (Upsert), and
// byte-array helpers (BytesToString, FastHashData).
// </summary>
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
	/// Provides extension methods for <see cref="byte"/> arrays.
	/// </summary>
	/// <param name="array">The byte array instance.</param>
	extension([DisallowNull] byte[] array)
	{
		/// <summary>
		/// Returns a <see cref="string"/> representation of this byte array using <see cref="FastStringBuilder"/> with a pooled <see cref="System.Text.StringBuilder"/> for improved performance.
		/// </summary>
		/// <returns>A <see cref="string"/> that represents the byte array.</returns>
		/// <remarks>
		/// Internally delegates to <see cref="FastStringBuilder"/>, which uses pooled
		/// <see cref="System.Text.StringBuilder"/> instances to avoid per-call heap allocations.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// byte[] data = { 65, 66, 67 };
		/// string result = data.BytesToString();
		/// Console.WriteLine(result); // Output: ABC
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(BytesToString), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
		public string BytesToString()
		{
			return FastStringBuilder.BytesToString(ref array);
		}

		/// <summary>
		/// Computes a SHA-256 hash of the byte array using <see cref="SHA256"/>.
		/// </summary>
		/// <returns>A new byte array containing the 32-byte SHA-256 hash.</returns>
		/// <remarks>
		/// Delegates directly to <see cref="SHA256.HashData(ReadOnlySpan{byte})"/>, which uses
		/// hardware acceleration when available. The returned array is always 32 bytes in length.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// byte[] data = System.Text.Encoding.UTF8.GetBytes("hello");
		/// byte[] hash = data.FastHashData();
		/// Console.WriteLine(hash.Length); // Output: 32
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastHashData), author: "David McCarter", createdOn: "3/11/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public byte[] FastHashData()
		{
			return SHA256.HashData(array.ArgumentNotNull());
		}
	}

	/// <summary>
	/// Provides extension methods for arrays of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the array.</typeparam>
	/// <param name="array">The array instance.</param>
	extension<T>([DisallowNull] T[] array)
	{
		/// <summary>
		/// Adds an item to the beginning of the specified array.
		/// </summary>
		/// <param name="item">The item to add to the array.</param>
		/// <returns>A new array with the item prepended. Returns the original array unchanged when <paramref name="item"/> is null.</returns>
		/// <remarks>
		/// Allocates a new array of length + 1, places <paramref name="item"/> at index 0, then copies
		/// the original elements using <see cref="MemoryExtensions.AsSpan{T}(T[])"/> for efficient bulk transfer.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 2, 3, 4 };
		/// int[] result = numbers.AddFirst(1);
		/// // result: { 1, 2, 3, 4 }
		/// </code>
		/// </example>
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

			// SUGGESTION FROM COPILOT SLOWER
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
		[Information(nameof(IndexOf), "David McCarter", "1/3/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
		/// Uses <see cref="Array.LastIndexOf{T}(T[], T)"/> which benchmarks faster than
		/// <see cref="MemoryExtensions.LastIndexOf{T}(Span{T}, T)"/> for reference-type arrays.
		/// The array is searched backward from the last element to the first.
		/// Equality is determined using <see cref="EqualityComparer{T}.Default"/>; if <typeparamref name="T"/>
		/// overrides <see cref="object.Equals(object)"/> that override is applied.
		/// This is an O(n) operation.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array or <paramref name="item"/> is null.</exception>
		/// <example>
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
		[Information(nameof(LastIndexOf), "David McCarter", "1/3/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int LastIndexOf([DisallowNull] T item)
		{
			array = array.ArgumentNotNull();
			item = item.ArgumentNotNull();

			// SUGGESTION FROM COPILOT SLOWER
			return Array.LastIndexOf(array, item);
		}

		/// <summary>
		/// Adds an item to the end of the array when <paramref name="condition"/> is <see langword="true"/>.
		/// </summary>
		/// <param name="item">The item to conditionally add to the array.</param>
		/// <param name="condition">When <see langword="true"/>, the item is appended; otherwise the original array is returned.</param>
		/// <returns>
		/// A new array with <paramref name="item"/> appended when <paramref name="condition"/> is <see langword="true"/>.
		/// Returns the original array unchanged when <paramref name="item"/> is null or <paramref name="condition"/> is <see langword="false"/>.
		/// </returns>
		/// <remarks>
		/// Internally delegates to <see cref="AddLast"/> when the condition is met, so the same
		/// span-based allocation strategy applies.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 3 };
		/// int[] result = numbers.AddIf(4, condition: true);
		/// // result: { 1, 2, 3, 4 }
		///
		/// int[] unchanged = numbers.AddIf(4, condition: false);
		/// // unchanged: { 1, 2, 3 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddIf), author: "David McCarter", createdOn: "4/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
		public T[] AddIf([AllowNull] in T item, bool condition)
		{
			return item is null ? array : condition ? array.AddLast(item) : array;
		}

		/// <summary>
		/// Returns a new array containing a contiguous range of elements from the source array.
		/// </summary>
		/// <param name="startIndex">The zero-based index of the first element to include.</param>
		/// <param name="count">The number of elements to include.</param>
		/// <returns>A new array containing the <paramref name="count"/> elements starting at <paramref name="startIndex"/>.</returns>
		/// <remarks>
		/// Uses <see cref="ArraySegment{T}"/> to create a zero-copy view of the source array before
		/// materializing the result. Both <paramref name="startIndex"/> and <paramref name="count"/> are
		/// validated with <see cref="Validator"/> before the slice is performed.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="startIndex"/> is less than 0 or greater than Length - 1.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="count"/> is less than 1 or exceeds the remaining elements from <paramref name="startIndex"/>.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
		/// int[] subset = numbers.FastSelectItems(2, 3);
		/// // subset: { 30, 40, 50 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastSelectItems), author: "David McCarter", createdOn: "7/28/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] FastSelectItems(int startIndex, int count)
		{
			array = array.ArgumentItemsExists();
			startIndex = startIndex.ArgumentInRange(0, max: array.Length - 1);
			count = count.ArgumentInRange(min: 1, max: array.Length - startIndex);

			// SUGGESTION FROM COPILOT SLOWER
			var result = new ArraySegment<T>(array, startIndex, count);

			return result.ToArray();
		}

		/// <summary>
		/// Adds an item to the end of the specified array.
		/// </summary>
		/// <param name="item">The item to append to the array.</param>
		/// <returns>A new array with <paramref name="item"/> appended. Returns the original array unchanged when <paramref name="item"/> is null.</returns>
		/// <remarks>
		/// Allocates a new array of length + 1, copies the original elements using
		/// <see cref="MemoryExtensions.AsSpan{T}(T[])"/>, then assigns <paramref name="item"/> to the last slot.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 3 };
		/// int[] result = numbers.AddLast(4);
		/// // result: { 1, 2, 3, 4 }
		/// </code>
		/// </example>
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

			// SUGGESTION FROM COPILOT SLOWER
			array.AsSpan().CopyTo(result);

			result[length] = item;

			return result;
		}

		/// <summary>
		/// Determines whether two arrays contain the same elements in the same order.
		/// </summary>
		/// <param name="arrayToCheck">The array to compare against the current array.</param>
		/// <returns><see langword="true"/> if both arrays have identical length and elements; otherwise <see langword="false"/>. Also returns <see langword="false"/> when either array is null.</returns>
		/// <remarks>
		/// Uses <see cref="MemoryExtensions.SequenceEqual{T}(Span{T}, ReadOnlySpan{T})"/> for element-wise
		/// comparison. <see cref="MethodImplOptions.NoInlining"/> and <see cref="MethodImplOptions.NoOptimization"/>
		/// are applied to prevent JIT inlining of this method at call sites.
		/// <para><b>⚠ This method is NOT suitable for timing-sensitive security comparisons</b> (e.g., HMAC
		/// validation, token equality). Use <see cref="CryptographicOperations.FixedTimeEquals"/> for
		/// <c>byte[]</c> inputs that require constant-time comparison.</para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the source array is null.</exception>
		/// <example>
		/// <code>
		/// int[] a = { 1, 2, 3 };
		/// int[] b = { 1, 2, 3 };
		/// bool equal = a.AreEqual(b);    // true
		///
		/// int[] c = { 1, 2, 99 };
		/// bool notEqual = a.AreEqual(c); // false
		/// </code>
		/// </example>
		[Pure]
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
		[Information(nameof(AsReadOnlySpan), "David McCarter", "5/30/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlySpan<T> AsReadOnlySpan()
		{
			return array.ArgumentNotNull();
		}

		/// <summary>
		/// Creates a shallow copy of the array.
		/// </summary>
		/// <returns>A new array containing all elements of the original array in the same order.</returns>
		/// <remarks>
		/// Allocates a new array of the same length, then copies all elements using
		/// <see cref="MemoryExtensions.AsSpan{T}(T[])"/> for efficient bulk transfer without boxing.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// int[] original = { 1, 2, 3 };
		/// int[] clone = original.FastClone();
		/// clone[0] = 99;
		/// Console.WriteLine(original[0]); // Output: 1 (original unchanged)
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastClone), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] FastClone()
		{
			array = array.ArgumentNotNull();

			// SUGGESTION FROM COPILOT SLOWER
			return (T[])array.Clone();

		}

		/// <summary>
		/// Returns the total number of elements in the array as a <see cref="long"/>.
		/// </summary>
		/// <returns>The total number of elements as a <see cref="long"/>.</returns>
		/// <remarks>
		/// Uses <see cref="Array.LongLength"/> which supports arrays larger than <see cref="int.MaxValue"/>
		/// elements on 64-bit platforms.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 3 };
		/// long count = numbers.FastLongCount();
		/// Console.WriteLine(count); // Output: 3
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastLongCount), "David McCarter", "1/9/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "11/8/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
		/// Computes a hash code that represents the contents of the entire array.
		/// </summary>
		/// <returns>An <see cref="int"/> hash code derived from all elements of the array.</returns>
		/// <remarks>
		/// Uses <see cref="HashCode"/> with <see cref="MemoryMarshal.GetArrayDataReference{T}(T[])"/> and
		/// <see cref="Unsafe.Add{T}(ref T, int)"/> to iterate without bounds-check overhead.
		/// Null elements contribute a zero hash.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 3 };
		/// int hash = numbers.GenerateHashCode();
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GenerateHashCode), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int GenerateHashCode()
		{
			array = array.ArgumentNotNull();

			// SUGGESTION FROM COPILOT SLOWER
			var hashSeed = 6551;

			ref var start = ref MemoryMarshal.GetArrayDataReference(array);
			var length = array.Length;

			for (var index = 0; index < length; index++)
			{
				var element = Unsafe.Add(ref start, index);

				if (element is not null)
				{
					hashSeed ^= (hashSeed << 5) ^ EqualityComparer<T>.Default.GetHashCode(element);
				}
			}

			return hashSeed;
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
		/// <param name="actionFunction">A predicate to test each element against a condition.</param>
		/// <returns>
		/// <see langword="true"/> if at least one element satisfies <paramref name="actionFunction"/>; otherwise <see langword="false"/>.
		/// Also returns <see langword="false"/> when the array or <paramref name="actionFunction"/> is null.
		/// </returns>
		/// <remarks>
		/// Iterates the array using <see cref="MemoryExtensions.AsSpan{T}(T[])"/> for allocation-free
		/// enumeration, short-circuiting on the first element that matches the predicate.
		/// Suitable for defensive programming patterns because it does not throw when either argument is null.
		/// </remarks>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 3, 4, 5 };
		/// bool hasEven = numbers.IsNotEmpty(n => n % 2 == 0);
		/// Console.WriteLine(hasEven); // Output: True
		///
		/// int[] odds = { 1, 3, 5 };
		/// bool noEven = odds.IsNotEmpty(n => n % 2 == 0);
		/// Console.WriteLine(noEven); // Output: False
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty(in Func<T, bool> actionFunction)
		{
			if (array is null || actionFunction is null)
			{
				return false;
			}

			var span = array.AsSpan();

			for (var index = 0; index < span.Length; index++)
			{
				if (actionFunction(span[index]))
				{
					return true;
				}
			}

			return false;
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
			return array is not null && count >= 0 && array.Length == count;
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
		[Information(nameof(PerformAction), "David McCarter", "1/4/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void PerformAction([DisallowNull] Action<T> action)
		{
			array = array.ArgumentNotNull();
			action = action.ArgumentNotNull();

			var span = array.AsSpan();

			for (var index = 0; index < span.Length; index++)
			{
				action(span[index]);
			}
		}

		/// <summary>
		/// Returns a new array with the first element removed.
		/// </summary>
		/// <returns>A new array containing all elements except the first.</returns>
		/// <remarks>
		/// Allocates a new array of length - 1 and copies elements starting from index 1 using
		/// <see cref="MemoryExtensions.AsSpan{T}(T[], int, int)"/> for efficient bulk transfer.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null or empty.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 3, 4 };
		/// int[] result = numbers.RemoveFirst();
		/// // result: { 2, 3, 4 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveFirst), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] RemoveFirst()
		{
			array = array.ArgumentItemsExists();

			var newLength = array.Length - 1;

			// Suggestion from skill dotnet-best-practices performance and security
			var result = GC.AllocateUninitializedArray<T>(newLength);


			array.AsSpan(1, newLength).CopyTo(result);

			return result;
		}

		/// <summary>
		/// Returns a new array with the last element removed.
		/// </summary>
		/// <returns>A new array containing all elements except the last.</returns>
		/// <remarks>
		/// Allocates a new array of length - 1 and copies elements from index 0 through length - 2 using
		/// <see cref="MemoryExtensions.AsSpan{T}(T[], int, int)"/> for efficient bulk transfer.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null or empty.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 3, 4 };
		/// int[] result = numbers.RemoveLast();
		/// // result: { 1, 2, 3 }
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveLast), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] RemoveLast()
		{
			array = array.ArgumentItemsExists();

			var newLength = array.Length - 1;

			// SUGGESTION FROM COPILOT SLOWER
			var result = new T[newLength];

			array.AsSpan(0, newLength).CopyTo(result);

			return result;
		}

		/// <summary>
		/// Returns a new array containing only the distinct elements of the source array.
		/// </summary>
		/// <param name="comparer">
		/// An optional <see cref="IEqualityComparer{T}"/> used for element comparison.
		/// When null, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>A new array with duplicate elements removed.</returns>
		/// <remarks>
		/// Internally uses a <see cref="HashSet{T}"/> pre-allocated to the source array's length to
		/// track seen elements. Elements are iterated via <see cref="MemoryExtensions.AsSpan{T}(T[])"/>
		/// to avoid enumerator allocation. Insertion order is not guaranteed.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 2, 3, 3, 4 };
		/// int[] distinct = numbers.ToDistinct();
		/// // distinct contains: { 1, 2, 3, 4 } (order may vary)
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToDistinct), "David McCarter", "11/21/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] ToDistinct(IEqualityComparer<T>? comparer = null)
		{
			array = array.ArgumentNotNull();

			var seen = new HashSet<T>(array.Length, comparer);

			var span = array.AsSpan();

			for (var index = 0; index < span.Length; index++)
			{
				_ = seen.Add(span[index]);
			}

			return [.. seen];
		}

		/// <summary>
		/// Converts the array to a <see cref="FrozenSet{T}"/>, an immutable read-optimized set.
		/// </summary>
		/// <param name="comparer">
		/// An optional <see cref="IEqualityComparer{T}"/> used for element comparison.
		/// When null, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>A <see cref="FrozenSet{T}"/> containing the distinct elements of the array.</returns>
		/// <remarks>
		/// <see cref="FrozenSet{T}"/> is optimized for scenarios where the set is built once and then
		/// queried many times. Lookups are typically faster than <see cref="HashSet{T}"/> due to
		/// internal layout optimizations applied at construction time.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// int[] numbers = { 1, 2, 2, 3 };
		/// FrozenSet&lt;int&gt; frozenSet = numbers.ToFrozenSet();
		/// Console.WriteLine(frozenSet.Contains(2)); // Output: True
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet(IEqualityComparer<T>? comparer = null)
		{
			return FrozenSet.ToFrozenSet(array.ArgumentNotNull(), comparer);
		}

		/// <summary>
		/// Inserts or replaces an item in the array.
		/// </summary>
		/// <param name="item">The item to insert or update. When null, the original array is returned unchanged.</param>
		/// <returns>A new array with <paramref name="item"/> updated in-place if it already exists, or appended if it does not.</returns>
		/// <remarks>
		/// Uses <see cref="MemoryExtensions.IndexOf{T}(Span{T}, T)"/> to locate an existing element.
		/// When found, the result array is a copy with the element at that index replaced by <paramref name="item"/>.
		/// When not found, delegates to <see cref="AddLast"/> to append <paramref name="item"/>.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when the array is null.</exception>
		/// <example>
		/// <code>
		/// string[] names = { "Alice", "Bob" };
		/// string[] updated = names.Upsert("Bob");  // replaces existing
		/// string[] added   = names.Upsert("Carol"); // appends new
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] Upsert([AllowNull] in T item)
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
