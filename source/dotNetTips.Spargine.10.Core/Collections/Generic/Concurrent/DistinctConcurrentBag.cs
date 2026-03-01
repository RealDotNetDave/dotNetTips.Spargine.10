// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-26-2026
// ***********************************************************************
// <copyright file="DistinctConcurrentBag.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Inherits from ConcurrentBag<T> and ensures that all items in the bag
// are unique.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// Represents a thread-safe, unordered collection of objects that does not allow duplicate elements.
/// </summary>
/// <typeparam name="T">The type of the elements in the bag.</typeparam>
/// <remarks>
/// This collection wraps a <see cref="ConcurrentBag{T}"/>, ensuring that all elements are unique.
/// </remarks>
/// <seealso cref="ICollection{T}" />
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineDistinctConcurrentBag")]
public sealed class DistinctConcurrentBag<T> : ICollection<T>
{
	private readonly ConcurrentBag<T> _bag = [];
	private readonly ConcurrentHashSet<T> _uniqueItems = [];

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}"/> class.
	/// </summary>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public DistinctConcurrentBag()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}"/> class that contains elements copied from the specified collection.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new <see cref="DistinctConcurrentBag{T}"/>.</param>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public DistinctConcurrentBag([NotNull] in IEnumerable<T> collection)
	{
		foreach (var item in collection)
		{
			this.Add(item);
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}"/> class with a custom comparer.
	/// </summary>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> to use for comparing items.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public DistinctConcurrentBag([NotNull] IEqualityComparer<T> comparer)
	{
		this._uniqueItems = new ConcurrentHashSet<T>(comparer.ArgumentNotNull());
	}

	/// <summary>
	/// Gets the number of elements contained in the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int Count
	{
		get
		{
			return this._uniqueItems.Count;
		}
	}

	/// <summary>
	/// Gets a value indicating whether the <see cref="DistinctConcurrentBag{T}"/> is empty.
	/// </summary>
	/// <value><c>true</c> if the bag is empty; otherwise, <c>false</c>.</value>
	[Information(nameof(IsEmpty), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool IsEmpty => this._uniqueItems.IsEmpty;

	/// <summary>
	/// Gets a value indicating whether the <see cref="DistinctConcurrentBag{T}"/> is read-only.
	/// </summary>
	/// <value>Always <c>false</c> because the <see cref="DistinctConcurrentBag{T}"/> allows adding and removing items.</value>
	[Information(Status = Status.Available)]
	public bool IsReadOnly => false;

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	/// <summary>
	/// Adds an object to the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="item">The object to be added to the bag. The value cannot be a null reference for reference types.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void Add([NotNull] T item)
	{
		if (item is null)
		{
			throw new ArgumentNullException(nameof(item));
		}

		if (this._uniqueItems.TryAdd(item))
		{
			this._bag.Add(item);
		}
	}

	/// <summary>
	/// Adds multiple items to the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="items">The collection of items to add. Cannot be null.</param>
	/// <returns>The number of items successfully added (excluding duplicates).</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[Information(nameof(AddRange), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int AddRange([NotNull] IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		var addedCount = 0;

		foreach (var item in items)
		{
			if (item is not null && this._uniqueItems.AddIfNotExists(item))
			{
				this._bag.Add(item);
				addedCount++;
			}
		}

		return addedCount;
	}

	/// <summary>
	/// Removes all items from the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void Clear()
	{
		while (this._bag.TryTake(out _))
		{ }

		this._uniqueItems.Clear();
	}

	/// <summary>
	/// Determines whether the <see cref="DistinctConcurrentBag{T}"/> contains a specific value.
	/// </summary>
	/// <param name="item">The object to locate in the <see cref="DistinctConcurrentBag{T}"/>.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> is found in the <see cref="DistinctConcurrentBag{T}"/>; otherwise, <see langword="false" />.</returns>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed)]
	public bool Contains([NotNullWhen(true)] T item)
	{
		return item is null ? false : this._uniqueItems.Contains(item);
	}

	/// <summary>
	/// Determines whether the <see cref="DistinctConcurrentBag{T}"/> contains any of the specified values.
	/// </summary>
	/// <param name="items">The collection of items to check. Cannot be null.</param>
	/// <returns><c>true</c> if any item is found in the bag; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[Information(nameof(ContainsAny), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool ContainsAny([NotNull] IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		foreach (var item in items)
		{
			if (item is not null && this._uniqueItems.Contains(item))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Copies the elements of the <see cref="DistinctConcurrentBag{T}"/> to an array, starting at a particular array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from <see cref="DistinctConcurrentBag{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void CopyTo(T[] array, int arrayIndex)
	{
		this._uniqueItems.CopyTo(array, arrayIndex);
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <returns>An <see cref="IEnumerator{T}"/> for the <see cref="DistinctConcurrentBag{T}"/>.</returns>

	[Information(UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public IEnumerator<T> GetEnumerator()
	{
		return this._uniqueItems.GetEnumerator();
	}

	/// <summary>
	/// Removes the first occurrence of a specific object from the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="item">The object to remove from the <see cref="DistinctConcurrentBag{T}"/>.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> was successfully removed from the <see cref="DistinctConcurrentBag{T}"/>; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed)]
	public bool Remove([NotNull] T item)
	{
		item = item.ArgumentNotNull();

		if (this._uniqueItems.Remove(item))
		{
			// Remove from bag: reconstruct bag without the item
			var newItems = new List<T>(this._uniqueItems.Count);

			var removed = false;

			while (this._bag.TryTake(out var current))
			{
				if (!removed && EqualityComparer<T>.Default.Equals(current, item))
				{
					removed = true;
					continue;
				}

				newItems.Add(current);
			}

			foreach (var newItem in newItems)
			{
				this._bag.Add(newItem);
			}

			return true;
		}

		return false;
	}

	/// <summary>
	/// Removes multiple items from the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="items">The collection of items to remove. Cannot be null.</param>
	/// <returns>The number of items successfully removed.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[Information(nameof(RemoveRange), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int RemoveRange([NotNull] IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		var removedCount = 0;

		foreach (var item in items)
		{
			if (item is not null && this.Remove(item))
			{
				removedCount++;
			}
		}

		return removedCount;
	}

	/// <summary>
	/// Copies the elements of the <see cref="DistinctConcurrentBag{T}"/> to a new array.
	/// </summary>
	/// <returns>An array containing a snapshot of elements in the bag.</returns>
	[Information(nameof(ToArray), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public T[] ToArray()
	{
		return [.. this._uniqueItems];
	}

	/// <summary>
	/// Converts the <see cref="DistinctConcurrentBag{T}"/> to a <see cref="FrozenSet{T}"/> for optimal read performance.
	/// </summary>
	/// <returns>A <see cref="FrozenSet{T}"/> containing a snapshot of elements in the bag.</returns>
	[Information(nameof(ToFrozenSet), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public FrozenSet<T> ToFrozenSet()
	{
		return this._uniqueItems.ToArray().ToFrozenSet();
	}

	/// <summary>
	/// Converts the <see cref="DistinctConcurrentBag{T}"/> to a <see cref="List{T}"/>.
	/// </summary>
	/// <returns>A <see cref="List{T}"/> containing a snapshot of elements in the bag.</returns>
	[Information(nameof(ToList), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public List<T> ToList()
	{
		return [.. this._uniqueItems];
	}

	/// <summary>
	/// Tries the add.
	/// </summary>
	/// <param name="item">The item.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">item</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryAdd([NotNull] T item)
	{
		if (item is null)
		{
			throw new ArgumentNullException(nameof(item));
		}

		if (this._uniqueItems.AddIfNotExists(item))
		{
			this._bag.Add(item);

			return true;
		}

		return false;
	}

	/// <summary>
	/// Attempts to retrieve the canonical instance of an item from the <see cref="DistinctConcurrentBag{T}"/> that equals the specified value.
	/// </summary>
	/// <param name="equalValue">The value to search for.</param>
	/// <param name="actualValue">When this method returns, contains the actual value from the bag if found; otherwise, the default value.</param>
	/// <returns><c>true</c> if an equal value was found; otherwise, <c>false</c>.</returns>
	[Information(nameof(TryGetValue), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryGetValue(T equalValue, [NotNullWhen(true)] out T actualValue)
	{
		if (equalValue is null)
		{
			actualValue = default!;
			return false;
		}

		return this._uniqueItems.TryPeek(equalValue, out actualValue!);
	}

	/// <summary>
	/// Attempts to retrieve an item from the <see cref="DistinctConcurrentBag{T}"/> that equals the specified value.
	/// </summary>
	/// <param name="equalValue">The value to search for.</param>
	/// <param name="actualValue">When this method returns, contains the actual value from the bag if found; otherwise, the default value.</param>
	/// <returns><c>true</c> if an equal value was found; otherwise, <c>false</c>.</returns>
	[Information(nameof(TryPeek), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryPeek(T equalValue, [NotNullWhen(true)] out T actualValue)
	{
		if (equalValue is null)
		{
			actualValue = default!;

			return false;
		}

		return this._uniqueItems.TryPeek(equalValue, out actualValue!);
	}

	/// <summary>
	/// Attempts to remove and return an object from the <see cref="DistinctConcurrentBag{T}"/>.
	/// </summary>
	/// <param name="result">When this method returns, <paramref name="result"/> contains the object removed from the <see cref="DistinctConcurrentBag{T}"/> or the default value of <typeparamref name="T"/> if the bag is empty.</param>
	/// <returns><see langword="true"/> if an object was removed successfully; otherwise, <see langword="false"/>.</returns>
	[Information(Status = Status.Available, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed)]
	public bool TryTake([NotNullWhen(true)] out T result)
	{
		if (this._bag.TryTake(out result!))
		{
			return this._uniqueItems.Remove(result);
		}

		result = default!;

		return false;
	}

}
