// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-09-2026
// ***********************************************************************
// <copyright file="ObservableList.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Custom Observable Collection Class for `<T>`. Includes the following
// events: CollectionChanged, PropertyChanged, PropertyChanging.
// </summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// Represents an observable set that provides notifications when items get added, removed, or when the whole set is refreshed.
/// This collection implements the <see cref="ISet{T}"/> interface, ensuring element uniqueness with hash-based lookups.
/// Unlike traditional lists, this collection does not maintain insertion order or support index-based access.
/// </summary>
/// <remarks>
/// <para><strong>Historical Note:</strong> This class is named "ObservableList" for compatibility with EF Core's ObservableHashSet pattern,
/// but it implements set semantics (unique elements, no guaranteed order) rather than list semantics.</para>
/// <para>If you need ordered elements with notifications, consider using <see cref="ObservableCollection{T}"/> instead.</para>
/// <para>This implementation is based on EF Core's ObservableHashSet with enhanced functionality including batch operations.</para>
/// </remarks>
[Information(nameof(ObservableList<>), author: "David McCarter", createdOn: "7/31/2020", Status = Status.Available, Documentation = "https://bit.ly/SpargineObservableList")]
public class ObservableList<T> : ISet<T>, IReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged, INotifyPropertyChanging
{
	/// <summary>
	/// The underlying <see cref="HashSet{T}"/> used to store elements of the set.
	/// </summary>
	private HashSet<T> _set;

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}"/> class
	/// that is empty and uses the default equality comparer for the set type.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ObservableList() : this(EqualityComparer<T>.Default)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}"/> class
	/// that is empty and uses the specified equality comparer for the set type.
	/// </summary>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when
	/// comparing values in the set, or null to use the default <see cref="EqualityComparer{T}"/>
	/// implementation for the set type.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ObservableList(IEqualityComparer<T> comparer) => this._set = new HashSet<T>(comparer);

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}"/> class
	/// that uses the default <see cref="EqualityComparer{T}"/> for the set type, contains elements copied
	/// from the specified collection, and has sufficient capacity to accommodate the
	/// number of elements copied.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new set.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ObservableList(in IEnumerable<T> collection) : this(collection, EqualityComparer<T>.Default)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}"/> class
	/// that uses the specified equality comparer for the set type, contains elements
	/// copied from the specified collection, and has sufficient capacity to accommodate
	/// the number of elements copied.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new set.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when
	/// comparing values in the set, or null to use the default <see cref="IEqualityComparer{T}"/>
	/// implementation for the set type.</param>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ObservableList(in IEnumerable<T> collection, in IEqualityComparer<T> comparer)
	{
		this._set = new HashSet<T>(collection, comparer);

	}

	/// <summary>
	/// Occurs when the contents of the collection changes.
	/// </summary>
	/// <remarks>
	/// This event can indicate all changes to the collection including adding, removing, and replacing items.
	/// </remarks>
	/// <seealso cref="NotifyCollectionChangedEventArgs"/>
	public event NotifyCollectionChangedEventHandler? CollectionChanged;

	/// <summary>
	/// Occurs when a property value changes.
	/// </summary>
	/// <remarks>
	/// The event can indicate all changes to a property including updates to its value.
	/// </remarks>
	/// <seealso cref="PropertyChangedEventArgs"/>
	public event PropertyChangedEventHandler? PropertyChanged;

	/// <summary>
	/// Occurs when a property of this <see cref="ObservableList{T}"/> is changing.
	/// </summary>
	public event PropertyChangingEventHandler? PropertyChanging;

	/// <summary>
	/// Gets the <see cref="IEqualityComparer{T}"/> object that is used to determine equality for the values in the set.
	/// </summary>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual IEqualityComparer<T> Comparer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return this._set.Comparer;
		}
	}

	/// <summary>
	/// Gets the number of elements contained in the <see cref="ObservableList{T}"/>.
	/// </summary>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual int Count
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return this._set.Count;
		}
	}

	/// <summary>
	/// Gets a value indicating whether the <see cref="ObservableList{T}"/> is read-only.
	/// </summary>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ((ICollection<T>)this._set).IsReadOnly;
		}
	}

	/// <summary>
	/// Adds an item to the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <param name="item">The object to add to the collection.</param>
	void ICollection<T>.Add(T item) => this.Add(item);

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	/// <remarks>
	/// This method is a type-safe wrapper for the <see cref="IEnumerable.GetEnumerator"/> method.
	/// </remarks>
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	/// <remarks>
	/// This method is a type-safe wrapper for the <see cref="IEnumerable{T}.GetEnumerator"/> method.
	/// </remarks>
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Adds the specified element to the <see cref="ObservableList{T}"/> if the element already does not exist.
	/// </summary>
	/// <param name="item">The element to add to the set.</param>
	/// <returns><see langword="true"/> if the element is added to the <see cref="ObservableList{T}"/>; <see langword="false"/> if the element is already present.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual bool Add(T item)
	{
		if (item is null)
		{
			return false;
		}

		if (this._set.Contains(item))
		{
			return false;
		}

		this.OnCountPropertyChanging();

		_ = this._set.Add(item);

		this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);

		this.OnCountPropertyChanged();

		return true;
	}

	/// <summary>
	/// Adds a range of items to the collection with optimized notifications.
	/// </summary>
	/// <param name="items">The items to add.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	/// <remarks>
	/// This method provides better performance than calling <see cref="Add"/> repeatedly by raising
	/// a single <see cref="CollectionChanged"/> event after all items are added. Duplicate items 
	/// (items already in the set) are automatically skipped without raising errors.
	/// </remarks>
	/// <example>
	/// <code>
	/// var list = new ObservableList&lt;int&gt;();
	/// list.AddRange(new[] { 1, 2, 3, 4, 5 });
	/// </code>
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void AddRange([DisallowNull] IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		var addedItems = new List<T>();

		foreach (var item in items)
		{
			if (item is not null && this._set.Add(item))
			{
				addedItems.Add(item);
			}
		}

		if (addedItems.Count == 0)
		{
			return;
		}

		this.OnCountPropertyChanging();
		this.OnCollectionChanged(addedItems, ObservableHashSetSingletons.NoItems);
		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Removes all elements from the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <remarks>
	/// This method raises the <see cref="CollectionChanged"/> event with <see cref="NotifyCollectionChangedAction.Reset"/> action
	/// to indicate all items have been removed. It also raises the <see cref="PropertyChanging"/> and <see cref="PropertyChanged"/>
	/// events for the "Count" property before and after the collection is cleared, respectively.
	/// </remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void Clear()
	{
		if (this._set.FastLongCount() == 0)
		{
			return;
		}

		this.OnCountPropertyChanging();

		var removed = this.ToList();

		this._set.Clear();

		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Determines whether the <see cref="ObservableList{T}"/> contains the specified element.
	/// </summary>
	/// <param name="item">The element to locate in the <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="ObservableList{T}"/> contains the specified element; otherwise, <see langword="false"/>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual bool Contains([NotNullWhen(true)] T item)
	{
		return item is null ? false : this._set.Contains(item);
	}

	/// <summary>
	/// Copies the elements of the <see cref="ObservableList{T}"/> to an array.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the <see cref="ObservableList{T}"/>. The array must have zero-based indexing.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void CopyTo([DisallowNull] T[] array)
	{
		this._set.CopyTo(array.ArgumentNotNull());
	}

	/// <summary>
	/// Copies the elements of the <see cref="ObservableList{T}"/> to an array, starting at the specified array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the <see cref="ObservableList{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void CopyTo([DisallowNull] T[] array, int arrayIndex)
	{
		this._set.CopyTo(array.ArgumentNotNull(), arrayIndex);
	}

	/// <summary>
	/// Copies the specified number of elements of the <see cref="ObservableList{T}"/> to an array, starting at the specified array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the <see cref="ObservableList{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	/// <param name="count">The number of elements to copy to <paramref name="array"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void CopyTo([DisallowNull] T[] array, int arrayIndex, int count)
	{
		this._set.CopyTo(array.ArgumentNotNull(), arrayIndex, count);
	}

	/// <summary>
	/// Ensures that the underlying hash set can hold the specified number of elements without growing.
	/// </summary>
	/// <param name="capacity">The minimum capacity to ensure.</param>
	/// <returns>The current capacity of the collection.</returns>
	/// <remarks>
	/// This method can improve performance when adding many items by reducing the number of
	/// internal resize operations. Available in .NET 5.0 and later.
	/// </remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual int EnsureCapacity(int capacity)
	{
		capacity = capacity.ArgumentInRange(min: 0);
		return this._set.EnsureCapacity(capacity);
	}

	/// <summary>
	/// Removes all elements in the specified collection from the current set.
	/// </summary>
	/// <param name="other">The collection of items to remove from the current set. Elements in this collection that are not found in the current set are ignored.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	/// <remarks>
	/// This method determines what elements are in the specified collection but not in the current set. It then removes those elements from the current set.
	/// <para>
	/// This method uses the <see cref="HashSet{T}.ExceptWith"/> method of the underlying <see cref="HashSet{T}"/> to perform this operation.
	/// </para>
	/// </remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void ExceptWith([DisallowNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.ExceptWith(other);

		if (copy.FastLongCount() == this._set.FastLongCount())
		{
			return;
		}

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Finds all elements that match the specified predicate.
	/// </summary>
	/// <param name="match">The predicate to match.</param>
	/// <returns>A collection of matching elements.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="match"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[Information(BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual IEnumerable<T> FindAll([DisallowNull] Predicate<T> match)
	{
		match = match.ArgumentNotNull();

		return this._set.Where(item => match(item));
	}

	/// <summary>
	/// Returns the first element, or default(T) if the collection is empty.
	/// </summary>
	/// <returns>The first element, or default(T).</returns>
	[Pure]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual T? FirstOrDefault()
	{
		return this._set.Count > 0 ? this._set.First() : default;
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual HashSet<T>.Enumerator GetEnumerator()
	{
		return this._set.GetEnumerator();
	}

	/// <summary>
	/// Modifies the current <see cref="ObservableList{T}"/> to contain only elements that are also present in the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>. This collection must not be <see langword="null"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	/// <remarks>
	/// This operation performs an in-place intersection: after completion, the set contains only elements common to both
	/// the current set and <paramref name="other"/>. Internally, this method:
	/// <list type="number">
	/// <item><description>Copies the current set to a temporary <see cref="HashSet{T}"/> using the existing comparer.</description></item>
	/// <item><description>Calls <see cref="HashSet{T}.IntersectWith(IEnumerable{T})"/> on the copy.</description></item>
	/// <item><description>If the resulting set differs in count, replaces the backing set and raises notifications:</description>
	/// <list type="bullet">
	/// <item><description><see cref="INotifyPropertyChanging.PropertyChanging"/> for the <c>Count</c> property before mutation.</description></item>
	/// <item><description><see cref="INotifyCollectionChanged.CollectionChanged"/> with <see cref="NotifyCollectionChangedAction.Replace"/> to report removed items.</description></item>
	/// <item><description><see cref="INotifyPropertyChanged.PropertyChanged"/> for the <c>Count</c> property after mutation.</description></item>
	/// </list>
	/// </item>
	/// </list>
	/// Elements not present in <paramref name="other"/> are removed from the set. If the intersection does not change the
	/// size of the set (i.e., no items would be removed), no notifications are raised to avoid unnecessary churn.
	/// </remarks>
	/// <example>
	/// <code>
	/// var set = new ObservableList&lt;int&gt; { 1, 2, 3, 4 };
	/// set.IntersectWith(new[] { 3, 4, 5 });
	/// // Resulting set: { 3, 4 }
	/// </code>
	/// </example>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void IntersectWith([DisallowNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.IntersectWith(other);

		if (copy.FastLongCount() == this._set.FastLongCount())
		{
			return;
		}

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Determines whether the current <see cref="ObservableList{T}"/> is a proper subset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the current <see cref="ObservableList{T}"/> is a proper subset of <paramref name="other"/>; otherwise, <see langword="false"/>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool IsProperSubsetOf([NotNullWhen(true)] IEnumerable<T> other)
	{
		return this._set.IsProperSubsetOf(other.ArgumentNotNull());
	}

	/// <summary>
	/// Determines whether the <see cref="ObservableList{T}"/> is a proper superset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="ObservableList{T}"/> is a proper superset of <paramref name="other"/>; otherwise, <see langword="false"/>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool IsProperSupersetOf([NotNullWhen(true)] IEnumerable<T> other)
	{
		return this._set.IsProperSupersetOf(other.ArgumentNotNull());
	}

	/// <summary>
	/// Determines whether the <see cref="ObservableList{T}"/> is a subset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="ObservableList{T}"/> is a subset of <paramref name="other"/>; otherwise, <see langword="false"/>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool IsSubsetOf([NotNullWhen(true)] IEnumerable<T> other)
	{
		return this._set.IsSubsetOf(other.ArgumentNotNull());
	}

	/// <summary>
	/// Determines whether the <see cref="ObservableList{T}"/> is a superset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="ObservableList{T}"/> is a superset of <paramref name="other"/>; otherwise, <see langword="false"/>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool IsSupersetOf([NotNullWhen(true)] IEnumerable<T> other)
	{
		return this._set.IsSupersetOf(other.ArgumentNotNull());
	}

	/// <summary>
	/// Returns the last element, or default(T) if the collection is empty.
	/// </summary>
	/// <returns>The last element, or default(T).</returns>
	[Pure]
	[Information(Status = Status.Available, UnitTestStatus = UnitTestStatus.None)]
	public virtual T? LastOrDefault()
	{
		return this._set.Count > 0 ? this._set.Last() : default;
	}

	/// <summary>
	/// Determines whether the current <see cref="ObservableList{T}"/> overlaps with the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the current set and the specified collection share at least one common element; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool Overlaps([DisallowNull] IEnumerable<T> other)
	{
		return this._set.Overlaps(other.ArgumentNotNull());
	}

	/// <summary>
	/// Removes the specified item from the <see cref="ObservableList{T}"/>.
	/// </summary>
	/// <param name="item">The item to remove.</param>
	/// <returns><see langword="true"/> if item was successfully removed from the <see cref="ObservableList{T}"/>; otherwise, <see langword="false"/>. This method also returns <see langword="false"/> if item is not found in the original <see cref="ObservableList{T}"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is <see langword="null"/>.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual bool Remove(T item)
	{
		item = item.ArgumentNotNull();

		if (!this._set.Contains(item))
		{
			return false;
		}

		this.OnCountPropertyChanging();

		_ = this._set.Remove(item);

		this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);

		this.OnCountPropertyChanged();

		return true;
	}

	/// <summary>
	/// Removes a range of items from the collection with optimized notifications.
	/// </summary>
	/// <param name="items">The items to remove.</param>
	/// <returns>The number of items actually removed from the collection.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	/// <remarks>
	/// This method provides better performance than calling <see cref="Remove"/> repeatedly by raising
	/// a single <see cref="CollectionChanged"/> event after all items are removed. Items not found 
	/// in the collection are silently ignored.
	/// </remarks>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual int RemoveRange([DisallowNull] IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		var removedItems = new List<T>();

		foreach (var item in items)
		{
			if (this._set.Remove(item))
			{
				removedItems.Add(item);
			}
		}

		if (removedItems.Count == 0)
		{
			return 0;
		}

		this.OnCountPropertyChanging();
		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removedItems);
		this.OnCountPropertyChanged();

		return removedItems.Count;
	}

	/// <summary>
	/// Removes all elements that match the conditions defined by the specified predicate.
	/// </summary>
	/// <param name="match">The <see cref="Predicate{T}"/> delegate that defines the conditions of the elements to remove.</param>
	/// <returns>The number of elements removed from the <see cref="ObservableList{T}"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="match"/> is <see langword="null"/>.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual int RemoveWhere([DisallowNull] Predicate<T> match)
	{
		match = match.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		var removedCount = copy.RemoveWhere(match);

		if (removedCount == 0)
		{
			return 0;
		}

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

		this.OnCountPropertyChanged();

		return removedCount;
	}

	/// <summary>
	/// Replaces all elements with the elements from the specified collection, 
	/// raising a single Reset notification.
	/// </summary>
	/// <param name="items">The items to replace the collection with.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void Reset([DisallowNull] IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		var newSet = new HashSet<T>(items, this._set.Comparer);

		if (this._set.SetEquals(newSet))
		{
			return;
		}

		this.OnCountPropertyChanging();

		this._set = newSet;

		// Use Reset action for complete replacement
		this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Determines whether the current <see cref="ObservableList{T}"/> contains the same elements as the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>.</param>
	/// <returns><see langword="true"/> if the current <see cref="ObservableList{T}"/> set is equal to the specified collection; otherwise, <see langword="false"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool SetEquals([DisallowNull] IEnumerable<T> other)
	{
		return this._set.SetEquals(other.ArgumentNotNull());
	}

	/// <summary>
	/// Modifies the current <see cref="ObservableList{T}"/> to contain only elements that are present either in it or in the specified collection, but not both.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>. This collection must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void SymmetricExceptWith([DisallowNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.SymmetricExceptWith(other);

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();
		var added = copy.Where(i => !this._set.Contains(i)).ToList();

		if (removed.FastLongCount() == 0 && added.FastLongCount() == 0)
		{
			return;
		}

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(added, removed);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Converts the ObservableList to an array.
	/// </summary>
	/// <returns>An array containing all elements from the collection.</returns>
	[Pure]
	[return: NotNull]
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public virtual T[] ToArray()
	{
		return [.. this._set];
	}

	/// <summary>
	/// Converts the ObservableList to a List{T}.
	/// </summary>
	/// <returns>A List containing all elements from the collection.</returns>
	[Pure]
	[return: NotNull]
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public virtual List<T> ToList()
	{
		return [.. this._set];
	}

	/// <summary>
	/// Forces the <see cref="ObservableList{T}"/> to reduce its capacity to match its current count, minimizing memory overhead.
	/// </summary>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual void TrimExcess()
	{
		this._set.TrimExcess();
	}

	/// <summary>
	/// Searches the set for a given value and returns the equal value it finds, if any.
	/// </summary>
	/// <param name="equalValue">The value to search for.</param>
	/// <param name="actualValue">The value from the set that equals the search value, if found; otherwise the default value for T.</param>
	/// <returns>true if a value was found; otherwise false.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public virtual bool TryGetValue(T equalValue, [MaybeNullWhen(false)] out T actualValue)
	{
		return this._set.TryGetValue(equalValue, out actualValue);
	}

	/// <summary>
	/// Modifies the current <see cref="ObservableList{T}"/> to contain all elements that are present in the <see cref="ObservableList{T}"/> itself, the specified collection, or both.
	/// </summary>
	/// <param name="other">The collection to compare to the current <see cref="ObservableList{T}"/>. This collection must not be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="other"/> is <see langword="null"/>.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public virtual void UnionWith([DisallowNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.UnionWith(other);

		if (copy.FastLongCount() == this._set.FastLongCount())
		{
			return;
		}

		var added = copy.Where(i => !this._set.Contains(i)).ToList();

		this.OnCountPropertyChanging();

		this._set = copy;

		this.OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);

		this.OnCountPropertyChanged();
	}

	/// <summary>
	/// Raises the <see cref="CollectionChanged"/> event.
	/// </summary>
	/// <param name="e">The event data.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="e"/> is null.</exception>
	/// <remarks>
	/// This method is called to notify listeners that the collection has changed. The change details are encapsulated in the <paramref name="e"/> parameter.
	/// </remarks>
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
	{
		this.CollectionChanged?.Invoke(this, e);
	}

	/// <summary>
	/// Raises the <see cref="PropertyChanged"/> event.
	/// </summary>
	/// <param name="e">The property changed event data.</param>
	/// <remarks>
	/// This method is called to notify listeners that a property value has changed. The property that changed is specified in the <paramref name="e"/> parameter.
	/// </remarks>
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		this.PropertyChanged?.Invoke(this, e);
	}

	/// <summary>
	/// Raises the <see cref="PropertyChanging"/> event.
	/// </summary>
	/// <param name="e">The <see cref="PropertyChangingEventArgs"/> instance containing the event data.</param>
	/// <remarks>
	/// This method is called to notify listeners that a property of the <see cref="ObservableList{T}"/> is about to change.
	/// </remarks>
	protected virtual void OnPropertyChanging(PropertyChangingEventArgs e)
	{
		this.PropertyChanging?.Invoke(this, e);
	}

	/// <summary>
	/// Called when the collection changes.
	/// </summary>
	/// <param name="action">The action that caused the collection change.</param>
	/// <param name="item">The item involved in the change.</param>
	/// <remarks>
	/// This method raises the <see cref="CollectionChanged"/> event with the specified action and item.
	/// </remarks>
	private void OnCollectionChanged(NotifyCollectionChangedAction action, T item)
	{
		this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item));
	}

	/// <summary>
	/// Called when the collection changes, specifically when items are replaced.
	/// </summary>
	/// <param name="newItems">The new items that are replacing the old items in the collection.</param>
	/// <param name="oldItems">The old items that are being replaced by the new items in the collection.</param>
	/// <remarks>
	/// This method raises the <see cref="CollectionChanged"/> event with <see cref="NotifyCollectionChangedAction.Replace"/> action,
	/// providing the old items and new items involved in the change.
	/// </remarks>
	private void OnCollectionChanged(IList newItems, IList oldItems)
	{
		this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItems, oldItems));
	}

	/// <summary>
	/// Called when the "Count" property value has changed.
	/// </summary>
	/// <remarks>
	/// This method raises the <see cref="PropertyChanged"/> event indicating the "Count" property has changed.
	/// </remarks>
	private void OnCountPropertyChanged()
	{
		this.OnPropertyChanged(ObservableHashSetSingletons.CountPropertyChanged);
	}

	/// <summary>
	/// Called before the "Count" property value changes.
	/// </summary>
	/// <remarks>
	/// This method raises the <see cref="PropertyChanging"/> event indicating the "Count" property is changing.
	/// </remarks>
	private void OnCountPropertyChanging()
	{
		this.OnPropertyChanging(ObservableHashSetSingletons.CountPropertyChanging);
	}
}
