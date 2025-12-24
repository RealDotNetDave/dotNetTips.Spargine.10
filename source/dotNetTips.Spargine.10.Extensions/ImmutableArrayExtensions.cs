// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 12-22-2025
// ***********************************************************************
// <copyright file="ImmutableArrayExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the ImmutableArray.</summary>
// ***********************************************************************

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ImmutableArray{T}"/> to enhance usability and functionality.
/// These methods include checks for item presence, conditional actions, count comparisons, and item shuffling.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class ImmutableArrayExtensions
{
	/// <summary>
	/// Extension methods for <see cref="ImmutableArray{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the <see cref="ImmutableArray{T}"/>.</typeparam>
	/// <param name="collection">The <see cref="ImmutableArray{T}"/> to operate on.</param>
	extension<T>([DisallowNull] ImmutableArray<T> collection)
	{
		/// <summary>
		/// Checks if the <see cref="ImmutableArray{T}"/> contains any elements.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the array contains one or more elements; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty()
		{
			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length > 0;
		}

		/// <summary>
		/// Determines whether the <see cref="ImmutableArray{T}"/> contains any elements that match the condition defined by the specified predicate.
		/// </summary>
		/// <param name="actionPredicate">A function to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if one or more elements in the <see cref="ImmutableArray{T}"/> match the condition defined by the specified predicate; otherwise, <c>false</c>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Thrown if collection or <paramref name="actionPredicate"/> is null.
		/// </exception>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty([DisallowNull] Func<T, bool> actionPredicate)
		{
			return collection.ArgumentNotNull().IsEmpty || actionPredicate is null ? false : collection.Any(actionPredicate);
		}

		/// <summary>
		/// Determines whether the <see cref="ImmutableArray{T}"/> has exactly the specified number of items.
		/// </summary>
		/// <param name="count">The number of items to match.</param>
		/// <returns>
		/// <c>true</c> if the array contains exactly <paramref name="count"/> items; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "David McCarter", "11/21/2020", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsNotEmpty(in int count)
		{
			return collection.ArgumentNotNull().IsEmpty ? false : collection.Length == count;
		}

		/// <summary>
		/// Shuffles the elements of the specified <see cref="ImmutableArray{T}"/>.
		/// </summary>
		/// <returns>
		/// A new <see cref="ImmutableArray{T}"/> with elements in random order.
		/// </returns>
		/// <remarks>
		/// This method generates a sequence of random indices using <see cref="RandomNumberGenerator"/> to shuffle the array elements.
		/// If the array does not contain any items, it is returned unchanged.
		/// </remarks>
		[Pure]
		[Information(nameof(FastShuffle), "David McCarter", "8/27/2020", "1/21/2020", BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ImmutableArray<T> FastShuffle()
		{
			return collection.IsEmpty() ? collection : [.. collection.OrderBy(_ => RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue))];
		}
	}
}
