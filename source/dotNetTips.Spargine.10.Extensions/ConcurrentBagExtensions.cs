// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 02-24-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-22-2025
// ***********************************************************************
// <copyright file="ConcurrentBagExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ConcurrentBag{T}"/>.
/// </summary>
[Information(Status = Status.Available)]
public static class ConcurrentBagExtensions
{
	/// <summary></summary>
	extension<T>([DisallowNull] ConcurrentBag<T> bag)
	{
		/// <summary>
		/// Adds a range of items to the <see cref="ConcurrentBag{T}"/> with optimized performance.
		/// </summary>
		/// <param name="items">The items to add to the bag. Must not be null.</param>
		/// <remarks>
		/// This method uses an adaptive strategy:
		/// <list type="bullet">
		/// <item><description>For collections with fewer than 100 items, uses sequential addition to avoid parallelization overhead.</description></item>
		/// <item><description>For larger collections, uses <see cref="Parallel.ForEach{TSource}(IEnumerable{TSource}, Action{TSource})"/> to leverage multi-threaded adds for better performance.</description></item>
		/// </list>
		/// <see cref="ConcurrentBag{T}.Add"/> is thread-safe and optimized for concurrent operations.
		/// </remarks>
		[Information(nameof(AddRange), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public void AddRange([DisallowNull] in IEnumerable<T> items)
		{
			if (items is null)
			{
				return;
			}

			bag = bag.ArgumentNotNull();

			foreach (var item in items)
			{
				bag.Add(item);
			}
		}

		/// <summary>
		/// Removes the specified items from the <see cref="ConcurrentBag{T}"/>.
		/// </summary>
		/// <param name="items">The items to remove from the bag. Must not be null.</param>
		/// <returns>A new <see cref="ConcurrentBag{T}"/> with the specified items removed.</returns>
		[Pure]
		[return: NotNull]
		[Information(nameof(RemoveRange), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ConcurrentBag<T> RemoveRange([DisallowNull] IEnumerable<T> items)
		{
			if (items is null)
			{
				return bag;
			}

			bag = bag.ArgumentNotNull();

			var itemsToRemove = new HashSet<T>(items);

			if (itemsToRemove.Count == 0)
			{
				return [.. bag];
			}

			var tempBag = new ConcurrentBag<T>();

			foreach (var item in bag)
			{
				if (!itemsToRemove.Contains(item))
				{
					tempBag.Add(item);
				}
			}

			return tempBag;
		}

		/// <summary>
		/// Converts the <see cref="ConcurrentBag{T}"/> to a <see cref="List{T}"/>.
		/// </summary>
		/// <returns>A <see cref="List{T}"/> containing the elements of the bag.</returns>
		[Pure]
		[return: NotNull]
		[Information(nameof(ToList), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.CheckPerformance, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public List<T> ToList()
		{
			bag = bag.ArgumentNotNull();

			//TODO: CHECK SUGGESTION FROM COPILOT FOR PERFORMANCE IMPROVEMENT
			return new List<T>(bag);
		}
	}
}
