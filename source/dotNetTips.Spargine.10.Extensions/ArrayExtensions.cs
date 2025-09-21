// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-19-2025
// ***********************************************************************
// <copyright file="ArrayExtensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extensions methods for the Array type.</summary>
// ***********************************************************************
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
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
[Information(Documentation = "https://bit.ly/SpargineArrayExtensions", Status = Status.UpdateDocumentation)]
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
			return array.DoesNotHaveItems() ? [] : SHA256.HashData(array);
		}
	}

	/// <summary>
	/// Provides extension methods for arrays of any type.
	/// </summary>
	/// <typeparam name="T">The type of the array elements.</typeparam>
	/// <param name="array">The array instance.</param>
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
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] AddFirst([AllowNull] in T item)
		{
			if (item is null)
			{
				return array;
			}

			array = array.ArgumentNotNull();

			var result = new T[array.LongLength + 1];
			result[0] = item;

			Array.Copy(array, 0, result, 1, array.LongLength);

			return result;
		}

		/// <summary>
		/// Adds an item to the array if a specified condition is true.
		/// </summary>
		/// <param name="item">The item to add to the array.</param>
		/// <param name="condition">The condition that determines whether the item should be added.</param>
		/// <returns>A new array with the item added if the condition is true; otherwise, the original array.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the array or item is null.</exception>
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AddIf), author: "David McCarter", createdOn: "4/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
		public T[] AddIf([AllowNull] in T item, bool condition)
		{
			if (item is null)
			{
				return array;
			}

			array = array.ArgumentNotNull();

			return condition ? array.AddLast(item) : array;
		}

		/// <summary>
		/// Selects the items.
		/// </summary>
		/// <param name="startIndex">The start index.</param>
		/// <param name="count">The count.</param>
		/// <returns>T[].</returns>
		[Information(nameof(SelectItems), author: "David McCarter", createdOn: "7/28/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public T[] SelectItems(int startIndex, int count)
		{
			startIndex = startIndex.ArgumentInRange(0);
			count = count.ArgumentInRange(min: 1, max: array.Length);

			var people = new ArraySegment<T>(array, startIndex, count);

			return [.. people];
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
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] AddLast([AllowNull] in T item)
		{
			if (item is null)
			{
				return array;
			}

			array = array.ArgumentNotNull();

			var newArray = new T[array.LongLength + 1];
			Array.Copy(array, newArray, array.LongLength);
			newArray[array.LongLength] = item;

			return newArray;
		}

		/// <summary>
		/// Checks if the two arrays are equal.
		/// </summary>
		/// <param name="arrayToCheck">The array to check.</param>
		/// <returns><c>true</c> if the arrays are equal; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		[Information(nameof(AreEqual), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool AreEqual([AllowNull] in T[] arrayToCheck)
		{
			if (array is null || arrayToCheck is null)
			{
				return false;
			}
			else
			{
				return array.LongLength != arrayToCheck.LongLength ? false : array.AsSpan().SequenceEqual(arrayToCheck);
			}
		}

		/// <summary>
		/// Converts an array to <see cref="ReadOnlySpan{T}"/>.
		/// </summary>
		/// <returns>A <see cref="ReadOnlySpan{T}"/> over the array.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(AsReadOnlySpan), "David McCarter", "5/30/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlySpan<T> AsReadOnlySpan()
		{
			array = array.ArgumentNotNull();

			return new(array);
		}

		/// <summary>
		/// Clones the specified array.
		/// </summary>
		/// <returns>A new array containing all the elements of the original array.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Clone), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] Clone()
		{
			array = array.ArgumentNotNull();

			return (T[])array.Clone();
		}

		/// <summary>
		/// Determines whether the specified array does not contain any items.
		/// </summary>
		/// <returns><c>true</c> if the array is null or empty; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool DoesNotHaveItems()
		{
			return array == null || array.LongLength == 0;
		}

		/// <summary>
		/// Gets the total number of elements in the array.
		/// </summary>
		/// <returns>The total number of elements in the array as a long.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastCount), "David McCarter", "1/9/2023", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public long FastCount()
		{
			return array.ArgumentNotNull().LongLength;
		}



		/// <summary>
		/// Processes each element in the array with the specified action.
		/// </summary>
		/// <param name="action">The action to apply to each element of the array.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "11/8/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void FastProcessor([DisallowNull] Action<T> action)
		{
			array = array.ArgumentNotNull();
			action = action.ArgumentNotNull();

			//Span, ImmutableArray and FrozenSet is slower.
			foreach (var item in array)
			{
				action.Invoke(item);
			}
		}

		/// <summary>
		/// Generates a hash code for the entire array.
		/// </summary>
		/// <returns>A hash code representing the contents of the array.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int GenerateHashCode()
		{
			return array.ArgumentNotNull().Where(t => t is not null).Aggregate(6551, (accumulator, t) => accumulator ^= (accumulator << 5) ^ EqualityComparer<T>.Default.GetHashCode(t));
		}

		/// <summary>
		/// Determines whether the specified array has items.
		/// </summary>
		/// <returns><c>true</c> if the specified array has items; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool HasItems()
		{
			return array is null ? false : array.LongLength > 0;
		}

		/// <summary>
		/// Determines whether the specified values has items.
		/// </summary>
		/// <param name="actionFunction">The predicate to test each element.</param>
		/// <returns><c>true</c> if the specified values has items; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool HasItems(in Func<T, bool> actionFunction)
		{
			return array is null || actionFunction is null ? false : array.Any(actionFunction);
		}

		/// <summary>
		/// Determines whether the specified count has items.
		/// </summary>
		/// <param name="count">The count to compare.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool HasItems(int count)
		{
			return array is null ? false : array.LongLength == count;
		}

		/// <summary>
		/// Performs the specified action on each element of the array.
		/// </summary>
		/// <param name="action">The action to perform on each element.</param>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(PerformAction), "David McCarter", "1/4/2023", Status = Status.Available, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
		public void PerformAction([DisallowNull] Action<T> action)
		{
			array = array.ArgumentNotNull();
			action = action.ArgumentNotNull();

			foreach (var value in array)
			{
				action.Invoke(value);
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

			if (array.LongLength == 0)
			{
				return [];
			}

			var result = new T[array.LongLength - 1];
			Array.Copy(array, 1, result, 0, array.LongLength - 1);
			return result;
		}

		/// <summary>
		/// Removes the last item in the array.
		/// </summary>
		/// <returns>A new array with the last item removed.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(RemoveLast), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T[] RemoveLast()
		{
			array = array.ArgumentItemsExists();

			var result = new T[array.LongLength - 1];
			Array.Copy(array, result, array.LongLength - 1);
			return result;
		}

		/// <summary>
		/// Returns the array without duplicates.
		/// </summary>
		/// <returns>A new array containing only distinct elements.</returns>
		/// <exception cref="ArgumentNullException">array cannot be null.</exception>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToDistinct), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public T[] ToDistinct()
		{
			return [.. array.ArgumentNotNull().Distinct()];
		}

		/// <summary>
		/// Converts an array to <see cref="FrozenSet{T}"/> that could improve performance.
		/// </summary>
		/// <returns>A <see cref="FrozenSet{T}"/> containing the elements of the array.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToFrozenSet), "David McCarter", "6/3/2024", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public FrozenSet<T> ToFrozenSet()
		{
			return FrozenSet.ToFrozenSet(array);
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
		[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public T[] Upsert([AllowNull] T item)
		{
			array = array.ArgumentNotNull();

			if (item is null)
			{
				return array;
			}

			//Recommendation from CoPilot slower.
			if (array.Contains(item))
			{
				Array.Fill(array, item);

				return array;
			}
			else
			{
				return array.AddLast(item);
			}
		}
	}
}
