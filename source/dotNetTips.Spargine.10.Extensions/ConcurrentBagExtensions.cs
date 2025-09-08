// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 02-24-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2025
// ***********************************************************************
// <copyright file="ConcurrentBagExtensions.cs" company="David McCarter - dotNetTips.com">
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
		/// Adds a range of items to the <see cref="ConcurrentBag{T}"/>.
		/// </summary>
		/// <param name="items">The items to add to the bag. Must not be null.</param>
		[Information(nameof(AddRange), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public void AddRange([DisallowNull] IEnumerable<T> items)
		{
			if (items.DoesNotHaveItems())
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
		[Information(nameof(RemoveRange), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ConcurrentBag<T> RemoveRange([DisallowNull] IEnumerable<T> items)
		{
			bag = bag.ArgumentNotNull();
			items = items.ArgumentNotNull();

			var tempBag = new ConcurrentBag<T>();

			_ = Parallel.ForEach(bag, item =>
			{
				if (!items.Contains(item))
				{
					tempBag.Add(item);
				}
			});

			return tempBag;
		}

		/// <summary>
		/// Converts the <see cref="ConcurrentBag{T}"/> to a <see cref="List{T}"/>.
		/// </summary>
		/// <returns>A <see cref="List{T}"/> containing the elements of the bag.</returns>
		[Pure]
		[return: NotNull]
		[Information(nameof(ToList), "David McCarter", "2/24/2025", OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public List<T> ToList()
		{
			bag = bag.ArgumentNotNull();

			return [.. bag];
		}
	}
}
