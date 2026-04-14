// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-26-2026
// ***********************************************************************
// <copyright file="DistinctBlockingCollection.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// A custom thread-safe collection type designed for multi-threading
// tasks, ensuring uniqueness for all items in the collection.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Properties;
using DotNetTips.Spargine.Core.Serialization;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// Represents a thread-safe collection that does not allow duplicate items.
/// </summary>
/// <typeparam name="T">The type of elements contained in the collection.</typeparam>
/// <remarks>
/// This collection extends <see cref="BlockingCollection{T}"/> to ensure that all operations are thread-safe.
/// It also implements <see cref="ICloneable{T}"/> and <see cref="ICollection{T}"/>, providing additional functionality
/// while ensuring that duplicate items are not added to the collection.
/// This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
/// to remove from memory.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineDistinctBlockingCollection")]
public sealed class DistinctBlockingCollection<T> : BlockingCollection<T>, ICloneable<DistinctBlockingCollection<T>>, ICollection<T>
{

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctBlockingCollection{T}" /> class.
	/// </summary>
	[Information("DistinctBlockingCollection", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public DistinctBlockingCollection()
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctBlockingCollection{T}" /> class.
	/// </summary>
	/// <param name="boundedCapacity">The bounded size of the collection.</param>
	[Information("DistinctBlockingCollection", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public DistinctBlockingCollection(in int boundedCapacity) : base(boundedCapacity)
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctBlockingCollection{T}" /> class.
	/// </summary>
	/// <param name="collection">The collection.</param>
	[Information("DistinctBlockingCollection", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public DistinctBlockingCollection(in IEnumerable<T> collection)
	{
		if (collection?.FastLongCount() > 0)
		{
			foreach (var item in collection.Where(p => p is not null))
			{
				if (!this.TryAdd(item))
				{
					ExceptionThrower.ThrowArgumentInvalidException(Resources.ThereWasAnIssueAddingAnItemInTheCollection, nameof(collection));
				}
			}
		}
	}

	/// <summary>
	/// Gets a value indicating whether the collection is read-only.
	/// </summary>
	/// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>. This property returns <c>true</c> if <see cref="BlockingCollection{T}.IsAddingCompleted"/> is <c>true</c>, indicating that no more items can be added to the collection.</value>
	[Pure]
	[Information(nameof(IsReadOnly), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool IsReadOnly => this.IsAddingCompleted;

	/// <summary>
	/// Adds the specified item to the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the operation to complete.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown if the item already exists in the collection.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public new void Add([DisallowNull] T item, CancellationToken cancellationToken = default)
	{
		item = item.ArgumentNotNull();

		if (this.IsNotInCollection(item))
		{
			base.Add(item, cancellationToken);
		}
	}
	/// <summary>
	/// Adds multiple items to the <see cref="DistinctBlockingCollection{T}"/>, skipping duplicates.
	/// </summary>
	/// <param name="items">The collection of items to add. Cannot be null.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the operation to complete.</param>
	/// <returns>The number of unique items successfully added.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddRange), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int AddRange(IEnumerable<T> items, CancellationToken cancellationToken = default)
	{
		items = items.ArgumentNotNull();

		var addedCount = 0;

		foreach (var item in items.Where(p => p is not null))
		{
			if (this.IsNotInCollection(item))
			{
				base.Add(item, cancellationToken);
				addedCount++;
			}
		}

		return addedCount;
	}

	/// <summary>
	/// Removes all items from the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clear), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void Clear()
	{
		while (this.TryTake(out _))
		{
			// Intentionally left blank to continuously try and take items until the collection is empty.
		}
	}

	/// <summary>
	/// Clones this instance of <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <returns>A shallow copy of the current <see cref="DistinctBlockingCollection{T}"/>.</returns>
	/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
	/// to remove from memory.</remarks>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Clone uses JSON serialization with reflection; cannot annotate ICloneable<T>.Clone interface.")]
	[Information("Clone", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public DistinctBlockingCollection<T> Clone() => JsonSerialization.Deserialize<DistinctBlockingCollection<T>>(JsonSerialization.Serialize(this));

	/// <summary>
	/// Removes the first occurrence of a specific object from the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <param name="item">The object to remove from the <see cref="DistinctBlockingCollection{T}"/>. The value cannot be null.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> was successfully removed from the <see cref="DistinctBlockingCollection{T}"/>; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original collection.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Contains), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool Contains(T item)
	{
		//SUGGESTION FROM COPILOT BREAKS THIS METHOD
		if (item is null)
		{
			return false;
		}

		foreach (var element in this)
		{
			if (EqualityComparer<T>.Default.Equals(element, item))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Determines whether the <see cref="DistinctBlockingCollection{T}"/> contains any of the specified items.
	/// </summary>
	/// <param name="items">The items to check for. Cannot be null.</param>
	/// <returns><c>true</c> if any of the items are found; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="items"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ContainsAny), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool ContainsAny(IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		return items.Where(p => p is not null).Any(this.Contains);
	}

	/// <summary>
	/// Removes the first occurrence of a specific object from the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <param name="item">The object to remove from the <see cref="DistinctBlockingCollection{T}"/>. The value cannot be null.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> was successfully removed from the <see cref="DistinctBlockingCollection{T}"/>; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original collection.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Remove), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool Remove(T item)
	{
		return this.TryTake(out item!);
	}

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> could be added; otherwise, <see langword="false" />. If the item is a duplicate, and the underlying collection does not accept duplicate items, then <see langword="false" /> is returned.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryAdd), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public new bool TryAdd(T item)
	{
		return item is null || !this.IsNotInCollection(item) ? false : base.TryAdd(item);
	}

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />
	/// within the specified time period.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="Timeout.Infinite"/> (-1) to wait indefinitely.</param>
	/// <returns><see langword="true" /> if the <paramref name="item" /> could be added to the collection within the specified time; otherwise, <see langword="false" />. If the item is a duplicate, and the underlying collection does not accept duplicate items, then <see langword="false" /> is returned.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryAdd), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public new bool TryAdd([AllowNull] T item, [ConstantExpected(Min = 1, Max = int.MaxValue)] int millisecondsTimeout)
	{
		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout);
	}

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <param name="timeout">A <see cref="TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
	/// <returns><see langword="true" /> if the <paramref name="item" /> could be added to the collection within the specified time span; otherwise, <see langword="false" />. If the item is a duplicate, and the underlying collection does not accept duplicate items, then <see langword="false" /> is returned.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryAdd), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public new bool TryAdd(T item, TimeSpan timeout)
	{
		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, timeout);
	}

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />
	/// within the specified time period, while observing a cancellation token.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value cannot be null.</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="Timeout.Infinite" /> (-1) to wait
	/// indefinitely.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the operation to complete.</param>
	/// <returns>true if the <paramref name="item" /> could be added to the collection within the specified time; otherwise,
	/// false. If the item is a duplicate, and the underlying collection does not accept duplicate items, then false is returned.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryAdd), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public new bool TryAdd(T item, [ConstantExpected(Min = 1, Max = int.MaxValue)] int millisecondsTimeout, CancellationToken cancellationToken = default)
	{
		return item is null ? false : this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout, cancellationToken);
	}

	/// <summary>
	/// Attempts to add multiple items to the <see cref="DistinctBlockingCollection{T}"/> without blocking, skipping duplicates.
	/// </summary>
	/// <param name="items">The collection of items to add. Cannot be null.</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait for each add operation, or <see cref="Timeout.Infinite"/> (-1) to wait indefinitely.</param>
	/// <param name="cancellationToken">A cancellation token to observe.</param>
	/// <returns>The number of unique items successfully added within the timeout period.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryAddRange), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int TryAddRange(IEnumerable<T> items, [ConstantExpected(Min = 1, Max = int.MaxValue)] int millisecondsTimeout = 0, CancellationToken cancellationToken = default)
	{
		items = items.ArgumentNotNull();

		var addedCount = 0;

		foreach (var item in items.Where(p => p is not null))
		{
			if (this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout, cancellationToken))
			{
				addedCount++;
			}
		}

		return addedCount;
	}

	/// <summary>
	/// Determines whether the specified item is not already in the <see cref="DistinctBlockingCollection{T}"/>.
	/// </summary>
	/// <param name="item">The item to check.</param>
	/// <returns><c>true</c> if the item is null or not contained in the <see cref="DistinctBlockingCollection{T}"/>; otherwise, <c>false</c>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNotInCollection), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	private bool IsNotInCollection([NotNullWhen(false)] T item)
	{
		return this.Contains(item) is false;
	}
}
