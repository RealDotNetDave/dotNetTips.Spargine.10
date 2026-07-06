// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-01-2023
//
// Last Modified By : David McCarter
// Last Modified On : 07-05-2026
// ***********************************************************************
// <copyright file="ConcurrentHashSet.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Represents a thread-safe, hash-based unique collection.</summary>
// ***********************************************************************
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// Represents a thread-safe collection of unique elements.
/// </summary>
/// <typeparam name="T">The type of elements in the hash set. See <see cref="ICollection{T}"/>.</typeparam>
/// <remarks>
/// This implementation provides atomic operations for adding, removing, and checking for elements, making it suitable for concurrent scenarios.
/// </remarks>
[DebuggerDisplay("Count = {Count}")]
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineConcurrentHashSet")]
public sealed class ConcurrentHashSet<T> : IReadOnlyCollection<T>, ICollection<T>
{
	/// <summary>
	/// The default capacity of the <see cref="ConcurrentHashSet{T}"/> when not specified.
	/// </summary>
	private const int DefaultCapacity = 31;

	/// <summary>
	/// The maximum number of locks that can be used for concurrency management in <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	private const int MaxLockNumber = 1024;

	/// <summary>
	/// The <see cref="IEqualityComparer{T}"/> instance that is used to determine equality of keys for the hash set.
	/// </summary>
	private readonly IEqualityComparer<T> _comparer;

	/// <summary>
	/// Indicates whether the array of locks used for concurrency control should dynamically grow with the collection.
	/// </summary>
	/// <remarks>
	/// When <c>true</c>, the internal lock array can grow to improve concurrency at the cost of increased memory usage.
	/// This is beneficial in scenarios where the <see cref="ConcurrentHashSet{T}"/> is expected to store a large number of items.
	/// </remarks>
	private readonly bool _growLockArray;

	/// <summary>
	/// The budget for resizing. Controls when to resize the <see cref="Tables"/> based on the number of elements and the current capacity.
	/// </summary>
	private int _budget;

	/// <summary>
	/// Represents the internal data structure of the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <remarks>
	/// This field holds the tables structure, which includes the buckets and locks used for managing concurrency.
	/// The <see cref="Tables"/> structure is marked as volatile to ensure that updates to its reference are immediately visible to all threads,
	/// providing a mechanism for safe publication.
	/// </remarks>
	private volatile Tables _tables;


	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class.
	/// </summary>
	[Information(nameof(ConcurrentHashSet<>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet()
		: this(DefaultConcurrencyLevel, DefaultCapacity, true, EqualityComparer<T>.Default)
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class that contains elements copied from the specified collection.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <exception cref="ArgumentNullException">Thrown if the <paramref name="collection"/> is null.</exception>
	[Information(nameof(ConcurrentHashSet<>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(in IEnumerable<T> collection)
		: this(collection, EqualityComparer<T>.Default)
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class using the specified comparer for the set.
	/// </summary>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items in the set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="comparer"/> is null.</exception>
	[Information(nameof(ConcurrentHashSet<>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(IEqualityComparer<T> comparer)
		: this(concurrencyLevel: DefaultConcurrencyLevel, capacity: DefaultCapacity, growLockArray: true, comparer: comparer)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class with the specified concurrency level and initial capacity.
	/// </summary>
	/// <param name="concurrencyLevel">The estimated number of threads that will update the <see cref="ConcurrentHashSet{T}"/> concurrently.</param>
	/// <param name="capacity">The initial number of elements that the <see cref="ConcurrentHashSet{T}"/> can contain.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="concurrencyLevel"/> or <paramref name="capacity"/> is less than 1.</exception>
	[Information(nameof(ConcurrentHashSet<>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(int concurrencyLevel, [ConstantExpected(Min = 0, Max = int.MaxValue)] int capacity)
		: this(concurrencyLevel, capacity, false, EqualityComparer<T>.Default)
	{ }

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class that contains elements copied from the specified collection and uses the specified comparer for element comparison.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items in the set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="comparer"/> is null.</exception>
	[Information(nameof(ConcurrentHashSet<>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(in IEnumerable<T> collection, IEqualityComparer<T> comparer)
		: this(comparer) => this.InitializeFromCollection(collection);

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class with the specified concurrency level, collection, and comparer.
	/// </summary>
	/// <param name="concurrencyLevel">The estimated number of threads that will update the <see cref="ConcurrentHashSet{T}"/> concurrently.</param>
	/// <param name="collection">The collection whose elements are copied to the new <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items in the set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="collection"/> or <paramref name="comparer"/> is null.</exception>
	[Information(nameof(ConcurrentHashSet<>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(in int concurrencyLevel, in IEnumerable<T> collection, IEqualityComparer<T> comparer)
		: this(concurrencyLevel, DefaultCapacity, false, comparer) => this.InitializeFromCollection(collection);

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class with the specified concurrency level, capacity, and comparer.
	/// </summary>
	/// <param name="concurrencyLevel">The estimated number of threads that will update the <see cref="ConcurrentHashSet{T}"/> concurrently.</param>
	/// <param name="capacity">The initial number of elements that the <see cref="ConcurrentHashSet{T}"/> can contain.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items in the set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="comparer"/> is null.</exception>
	[Information(nameof(ConcurrentHashSet<>), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ConcurrentHashSet(in int concurrencyLevel, int capacity, IEqualityComparer<T> comparer)
		: this(concurrencyLevel, capacity, false, comparer)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConcurrentHashSet{T}"/> class with the specified concurrency level, initial capacity, option to allow lock array growth, and comparer.
	/// </summary>
	/// <param name="concurrencyLevel">The estimated number of threads that will update the <see cref="ConcurrentHashSet{T}"/> concurrently.</param>
	/// <param name="capacity">The initial number of elements that the <see cref="ConcurrentHashSet{T}"/> can contain.</param>
	/// <param name="growLockArray">Whether the lock array can grow with the collection, improving concurrency at the cost of increased memory usage.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing items for equality.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="concurrencyLevel"/> or <paramref name="capacity"/> is less than 1.</exception>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="comparer"/> is null.</exception>
	private ConcurrentHashSet(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<T> comparer)
	{
		comparer = comparer.ArgumentNotNull();

		concurrencyLevel = Math.Max(concurrencyLevel, 1);
		capacity = Math.Max(capacity, 0);

		// The capacity should be at least as large as the concurrency level. Otherwise, we would have locks that don't guard
		// any buckets.
		if (capacity < concurrencyLevel)
		{
			capacity = concurrencyLevel;
		}

		var locks = CreateLockObjects(concurrencyLevel);
		var countPerLock = new int[locks.Length];
		var buckets = new Node[capacity];

		this._tables = new Tables(buckets, locks, countPerLock);
		this._growLockArray = growLockArray;
		this._budget = buckets.Length / locks.Length;
		this._comparer = comparer;
	}

	/// <summary>
	/// Gets the default concurrency level, which is the number of processors on the current machine.
	/// </summary>
	/// <value>The default concurrency level, based on the number of processors.</value>
	[Pure]
	public static int DefaultConcurrencyLevel
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return Environment.ProcessorCount;
		}
	}


	/// <summary>
	/// Gets the number of elements contained in the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <value>The number of elements contained in the <see cref="ConcurrentHashSet{T}"/>.</value>
	[Pure]
	[Information(nameof(Count), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int Count
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			var count = 0;
			var acquiredLocks = 0;

			try
			{
				this.AcquireAllLocks(ref acquiredLocks);

				// Use direct loop instead of LINQ Aggregate for better performance
				var countPerLock = this._tables._countPerLock;
				var length = countPerLock.Length;

				for (var i = 0; i < length; i++)
				{
					count += countPerLock[i];
				}
			}
			finally
			{
				this.ReleaseLocks(0, acquiredLocks);
			}

			return count;
		}
	}

	/// <summary>
	/// Gets a value indicating whether the <see cref="ConcurrentHashSet{T}"/> is empty.
	/// </summary>
	/// <value><c>true</c> if the <see cref="ConcurrentHashSet{T}"/> is empty; otherwise, <c>false</c>.</value>
	[Pure]
	[DefaultValue(true)]
	[Information(nameof(IsEmpty), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			var acquiredLocks = 0;

			try
			{
				this.AcquireAllLocks(ref acquiredLocks);

				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
				{
					if (this._tables._countPerLock[counter] != 0)
					{
						return false;
					}
				}
			}
			finally
			{
				this.ReleaseLocks(0, acquiredLocks);
			}

			return true;
		}
	}

	/// <summary>
	/// Gets a value indicating whether the <see cref="ConcurrentHashSet{T}"/> is read-only.
	/// </summary>
	/// <value>
	/// Always returns <c>false</c>, as <see cref="ConcurrentHashSet{T}"/> is not a read-only collection.
	/// </value>
	[Pure]
	public bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <returns>An <see cref="IEnumerator"/> that can be used to iterate through the collection.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Returns an enumerator that iterates through a collection.
	/// </summary>
	/// <returns>An <see cref="IEnumerator"></see> object that can be used to iterate through the collection.</returns>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Adds an item to the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to add to the set. The value cannot be null.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void Add(T item)
	{
		item = item.ArgumentNotNull();

		_ = this.AddInternal(item, this._comparer.GetHashCode(item), false);
	}

	/// <summary>
	/// Adds multiple items to the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="items">The collection of items to add. Cannot be null.</param>
	/// <returns>The number of items successfully added (excluding duplicates).</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddRange), author: "David McCarter", createdOn: "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public int AddRange(IEnumerable<T> items)
	{
		items = items.ArgumentNotNull();

		var addedCount = 0;

		foreach (var item in items)
		{
			if (this.TryAddNonNull(item))
			{
				addedCount++;
			}
		}

		return addedCount;
	}

	/// <summary>
	/// Removes all items from the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <remarks>
	/// This method acquires all locks to ensure thread safety during the clear operation.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clear), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void Clear()
	{
		var locksAcquired = 0;

		try
		{
			this.AcquireAllLocks(ref locksAcquired);

			// Cache current tables reference for better performance
			var tables = this._tables;
			var locks = tables._locks;
			var lockCount = locks.Length;

			// Clear counts efficiently using Array.Clear
			Array.Clear(tables._countPerLock, 0, tables._countPerLock.Length);

			// Clear all bucket references to null for GC
			var buckets = tables._buckets;
			Array.Clear(buckets, 0, buckets.Length);

			// Reset budget
			this._budget = Math.Max(1, buckets.Length / lockCount);
		}
		finally
		{
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Determines whether the <see cref="ConcurrentHashSet{T}"/> contains a specific value.
	/// </summary>
	/// <param name="item">The object to locate in the <see cref="ConcurrentHashSet{T}"/>. Cannot be null.</param>
	/// <returns><c>true</c> if <paramref name="item"/> is found in the <see cref="ConcurrentHashSet{T}"/>; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[DefaultValue(false)]
	[Information(nameof(Contains), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public bool Contains(T item)
	{
		if (item is null)
		{
			return false;
		}

		var comparer = this._comparer;
		var hashCode = comparer.GetHashCode(item);
		var tables = this._tables;
		var buckets = tables._buckets;
		var bucketNo = GetBucket(hashCode, buckets.Length);

		for (var current = Volatile.Read(ref buckets[bucketNo]); current is not null; current = current._next)
		{
			if (hashCode == current._hashCode && comparer.Equals(current._item, item))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Copies the elements of the <see cref="ConcurrentHashSet{T}"/> to an array, starting at a particular array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from <see cref="ConcurrentHashSet{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="arrayIndex"/> is less than 0.</exception>
	/// <exception cref="ArgumentException">Thrown if the number of elements in the source <see cref="ConcurrentHashSet{T}"/> is greater than the available space from <paramref name="arrayIndex"/> to the end of the destination <paramref name="array"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CopyTo), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void CopyTo([DisallowNull] T[] array, int arrayIndex)
	{
		array = array.ArgumentItemsExists(nameof(array));

		var locksAcquired = 0;

		try
		{
			this.AcquireAllLocks(ref locksAcquired);

			var count = this.ComputeCountUnderLock();

			// "count" itself or "count + arrayIndex" can overflow
			if (array.Length - count < arrayIndex || count < 0)
			{
				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
			}

			this.CopyToItems(array, arrayIndex);
		}
		finally
		{
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Returns an enumerator that iterates through the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <returns>An <see cref="IEnumerator{T}"/> for the <see cref="ConcurrentHashSet{T}"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetEnumerator), author: "David McCarter", createdOn: "7/28/2021", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public IEnumerator<T> GetEnumerator()
	{
		var buckets = this._tables._buckets;

		foreach (var bucket in buckets)
		{
			var current = Volatile.Read(in bucket);

			while (current is not null)
			{
				yield return current._item;
				current = current._next;
			}
		}
	}

	/// <summary>
	/// Removes the specified item from the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to remove.</param>
	/// <returns><c>true</c> if the item was successfully removed; otherwise, <c>false</c>. This method also returns <c>false</c> if the item was not found in the original <see cref="ConcurrentHashSet{T}"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Remove), author: "David McCarter", createdOn: "7/28/2021", OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool Remove(T item)
	{
		return item is null ? false : this.TryRemove(item);
	}

	/// <summary>
	/// Copies the elements of the <see cref="ConcurrentHashSet{T}"/> to a new array.
	/// </summary>
	/// <returns>An array containing a snapshot of elements copied from the <see cref="ConcurrentHashSet{T}"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToArray), author: "David McCarter", createdOn: "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public T[] ToArray()
	{
		var locksAcquired = 0;

		try
		{
			this.AcquireAllLocks(ref locksAcquired);

			var count = this.ComputeCountUnderLock();

			if (count == 0)
			{
				return [];
			}

			var array = new T[count];
			this.CopyToItems(array, 0);

			return array;
		}
		finally
		{
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Attempts to add the specified item to the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to add to the set. The value cannot be null.</param>
	/// <returns><c>true</c> if the item was added successfully; <c>false</c> if the item already exists in the set.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[DefaultValue(false)]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryAdd), author: "David McCarter", createdOn: "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public bool TryAdd(T item)
	{
		item = item.ArgumentNotNull();

		return this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);
	}

	/// <summary>
	/// Attempts to retrieve an item from the <see cref="ConcurrentHashSet{T}"/> that equals the specified value.
	/// </summary>
	/// <param name="equalValue">The value to search for.</param>
	/// <param name="actualValue">When this method returns, contains the actual value from the set, if found; otherwise, the default value for the type.</param>
	/// <returns><c>true</c> if an equal value was found in the set; otherwise, <c>false</c>.</returns>
	[DefaultValue(false)]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryPeek), author: "David McCarter", createdOn: "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryPeek(T equalValue, [MaybeNullWhen(false)] out T actualValue)
	{
		if (equalValue is null)
		{
			actualValue = default;
			return false;
		}

		var hashCode = this._comparer.GetHashCode(equalValue);
		var tables = this._tables;
		var bucketNo = GetBucket(hashCode, tables._buckets.Length);

		return this.TryFindInBucket(Volatile.Read(ref tables._buckets[bucketNo]), equalValue, hashCode, out actualValue);
	}

	/// <summary>
	/// Attempts to remove the specified item from the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to remove.</param>
	/// <returns><c>true</c> if the item was successfully removed; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	/// <remarks>
	/// This method is thread-safe and may be used concurrently with other operations on the <see cref="ConcurrentHashSet{T}"/>.
	/// </remarks>
	[DefaultValue(false)]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryRemove), author: "David McCarter", createdOn: "7/28/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryRemove(T item)
	{
		if (item is null)
		{
			return false;
		}

		var comparer = this._comparer;
		var hashCode = comparer.GetHashCode(item);

		while (true)
		{
			var tables = this._tables;
			var buckets = tables._buckets;
			var locks = tables._locks;

			GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, buckets.Length, locks.Length);

			lock (locks[lockNo])
			{
				if (tables != this._tables)
				{
					continue;
				}

				ref var slot = ref buckets[bucketNo];
				var current = slot;

				while (current is not null)
				{
					if (hashCode == current._hashCode && comparer.Equals(current._item, item))
					{
						Volatile.Write(ref slot, current._next);
						tables._countPerLock[lockNo]--;
						return true;
					}

					slot = ref current._next;
					current = current._next;
				}
			}

			return false;
		}
	}

	/// <summary>
	/// Initializes newly added slots in a lock array (from <paramref name="startIndex"/> to end) with fresh lock objects.
	/// </summary>
	/// <param name="locks">The lock array to populate.</param>
	/// <param name="startIndex">The first index that needs initialization.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddNewLocks), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void AddNewLocks(object[] locks, long startIndex)
	{
		for (var i = startIndex; i < locks.Length; i++)
		{
			locks[i] = new object();
		}
	}

	/// <summary>
	/// Computes the approximate total element count by summing the per-lock counters.
	/// </summary>
	/// <param name="tables">The tables snapshot to count.</param>
	/// <returns>The approximate total element count.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ComputeApproxCount), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static long ComputeApproxCount(Tables tables)
	{
		long approxCount = 0;

		for (var tableCount = 0; tableCount < tables._countPerLock.LongLength; tableCount++)
		{
			approxCount += tables._countPerLock[tableCount];
		}

		return approxCount;
	}

	/// <summary>
	/// Computes the new resize budget. Returns <see cref="int.MaxValue"/> when the table has been maximized
	/// to prevent further resize calls; otherwise returns <c>max(1, bucketCount / lockCount)</c>.
	/// </summary>
	/// <param name="maximizeTableSize"><c>true</c> if the table was grown to its maximum size.</param>
	/// <param name="bucketCount">The number of buckets in the new table.</param>
	/// <param name="lockCount">The number of locks in the new table.</param>
	/// <returns>The new budget value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ComputeBudget), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static int ComputeBudget(bool maximizeTableSize, int bucketCount, int lockCount) =>
		maximizeTableSize ? int.MaxValue : Math.Max(1, bucketCount / lockCount);

	/// <summary>
	/// Computes the new bucket-array length for a grow operation.
	/// </summary>
	/// <param name="tables">The current tables snapshot.</param>
	/// <returns>A tuple of (newLength, maximizeTableSize).</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ComputeNewLength), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static (int newLength, bool maximizeTableSize) ComputeNewLength(Tables tables)
	{
		const int MaxArrayLength = 0X7FEFFFFF;

		if (!TryComputeDoublePlusOne(tables._buckets.Length, MaxArrayLength, out var newLength))
		{
			return (MaxArrayLength, true);
		}

		return (newLength, false);
	}

	/// <summary>
	/// Creates an initialized lock-objects array of the specified length.
	/// </summary>
	/// <param name="count">The number of locks to create.</param>
	/// <returns>An array of <paramref name="count"/> freshly created lock objects.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(CreateLockObjects), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static object[] CreateLockObjects(int count)
	{
		var locks = new object[count];

		for (var lockCount = 0; lockCount < count; lockCount++)
		{
			locks[lockCount] = new object();
		}

		return locks;
	}

	/// <summary>
	/// Starting from <paramref name="candidate"/>, finds the first odd integer not divisible by 3, 5, or 7.
	/// </summary>
	/// <param name="candidate">The starting odd integer.</param>
	/// <returns>The first valid candidate &gt;= <paramref name="candidate"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(FindNextValidLength), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static int FindNextValidLength(int candidate)
	{
		while (IsDivisibleBy3Or5Or7(candidate))
		{
			candidate += 2;
		}

		Debug.Assert(candidate % 2 != 0);
		return candidate;
	}

	/// <summary>
	/// Calculates the bucket index for the specified hash code.
	/// </summary>
	/// <param name="hashCode">The hash code of the item.</param>
	/// <param name="bucketCount">The total number of buckets in the <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <returns>The index of the bucket.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int GetBucket(in int hashCode, in int bucketCount)
	{
		//SUGGESTION FROM COPILOT BROKE THE CODE
		var bucketNo = (hashCode & 0x7fffffff) % bucketCount;
		Debug.Assert(bucketNo >= 0 && bucketNo < bucketCount);
		return bucketNo;
	}

	/// <summary>
	/// Calculates the bucket and lock numbers for a given hash code.
	/// </summary>
	/// <param name="hashCode">The hash code of the item.</param>
	/// <param name="bucketNo">The calculated bucket number.</param>
	/// <param name="lockNo">The calculated lock number.</param>
	/// <param name="bucketCount">The total number of buckets in the <see cref="ConcurrentHashSet{T}"/>.</param>
	/// <param name="lockCount">The total number of locks in the <see cref="ConcurrentHashSet{T}"/>.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void GetBucketAndLockNo(in int hashCode, out int bucketNo, out int lockNo, in int bucketCount, in int lockCount)
	{
		bucketNo = (hashCode & 0x7fffffff) % bucketCount;
		lockNo = bucketNo % lockCount;
	}

	/// <summary>
	/// Returns <c>true</c> when <paramref name="n"/> is divisible by 3, 5, or 7.
	/// </summary>
	/// <param name="n">The value to test.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(IsDivisibleBy3Or5Or7), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static bool IsDivisibleBy3Or5Or7(int n) => n % 3 == 0 || n % 5 == 0 || n % 7 == 0;

	/// <summary>
	/// Rehashes all elements from the current tables into the new buckets and count arrays.
	/// </summary>
	/// <param name="tables">The current tables snapshot to rehash from.</param>
	/// <param name="newBuckets">The new bucket array.</param>
	/// <param name="newCountPerLock">The new per-lock count array.</param>
	/// <param name="newLocks">The new lock array used to determine lock assignment.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RehashBuckets), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void RehashBuckets(Tables tables, Node[] newBuckets, int[] newCountPerLock, object[] newLocks)
	{
		for (var bucketCount = 0; bucketCount < tables._buckets.LongLength; bucketCount++)
		{
			var current = tables._buckets[bucketCount];

			while (current is not null)
			{
				var next = current._next;
				GetBucketAndLockNo(current._hashCode, out var newBucketNo, out var newLockNo, newBuckets.Length, newLocks.Length);

				newBuckets[newBucketNo] = new Node(current._item, current._hashCode, newBuckets[newBucketNo]);

				checked
				{
					newCountPerLock[newLockNo]++;
				}

				current = next;
			}
		}
	}

	/// <summary>
	/// Attempts to compute (currentLength * 2 + 1) rounded up to the next length not divisible by 3, 5, or 7.
	/// Returns <c>false</c> if the result would exceed <paramref name="maxLength"/> or overflow.
	/// </summary>
	/// <param name="currentLength">The current bucket-array length.</param>
	/// <param name="maxLength">The maximum allowed length.</param>
	/// <param name="newLength">The computed new length on success; <paramref name="maxLength"/> on overflow.</param>
	/// <returns><c>true</c> if a valid new length was computed; <c>false</c> if the table should be maximized.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(TryComputeDoublePlusOne), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static bool TryComputeDoublePlusOne(int currentLength, int maxLength, out int newLength)
	{
		try
		{
			checked
			{
				newLength = FindNextValidLength((currentLength * 2) + 1);
				return newLength <= maxLength;
			}
		}
		catch (OverflowException)
		{
			newLength = maxLength;
			return false;
		}
	}

	/// <summary>
	/// Acquires all locks for the <see cref="ConcurrentHashSet{T}"/>, used to ensure thread safety during operations that need to access all elements.
	/// </summary>
	/// <param name="locksAcquired">The number of locks successfully acquired.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void AcquireAllLocks(ref int locksAcquired)
	{
		// First, acquire lock 0
		this.AcquireLocks(0, 1, ref locksAcquired);

		// Now that we have lock 0, the _locks array will not change (i.e., grow),
		// and so we can safely read _locks.Length.
		this.AcquireLocks(1, this._tables._locks.Length, ref locksAcquired);

		Debug.Assert(locksAcquired == this._tables._locks.Length);
	}

	/// <summary>
	/// Acquires locks for a range of buckets, used to ensure thread safety during operations that need to access a subset of elements.
	/// </summary>
	/// <param name="fromInclusive">The inclusive start index of the bucket range for which locks are to be acquired.</param>
	/// <param name="toExclusive">The exclusive end index of the bucket range for which locks are to be acquired.</param>
	/// <param name="locksAcquired">The number of locks successfully acquired by this method. This parameter is passed by reference.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void AcquireLocks(in int fromInclusive, in int toExclusive, ref int locksAcquired)
	{
		Debug.Assert(fromInclusive <= toExclusive);
		var locks = this._tables._locks;

		for (var inclusiveCount = fromInclusive; inclusiveCount < toExclusive; inclusiveCount++)
		{
			var lockTaken = false;

			try
			{
				Monitor.Enter(locks[inclusiveCount], ref lockTaken);
			}
			finally
			{
				if (lockTaken)
				{
					locksAcquired++;
				}
			}
		}
	}

	/// <summary>
	/// Attempts to add an item to the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <param name="item">The item to add. Cannot be null.</param>
	/// <param name="hashCode">The hash code of the item.</param>
	/// <param name="acquireLock">Indicates whether to lock the table during the add operation.</param>
	/// <returns><c>true</c> if the item was added successfully; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool AddInternal(T item, int hashCode, bool acquireLock)
	{
		item = item.ArgumentNotNull();
		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
	}

	/// <summary>
	/// Inserts <paramref name="item"/> under the appropriate lock, retrying when the table is concurrently resized.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool AddInternalLocked(T item, int hashCode)
	{
		while (true)
		{
			var tables = this._tables;

			GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, tables._buckets.Length, tables._locks.Length);

			bool added;
			bool resizeDesired;

			lock (tables._locks[lockNo])
			{
				if (tables != this._tables)
				{
					continue;
				}

				(added, resizeDesired) = this.AddToLockedBucket(tables, item, hashCode, bucketNo, lockNo);
			}

			// Grow outside the lock to prevent deadlocks.
			if (resizeDesired)
			{
				this.GrowTable(tables);
			}

			return added;
		}
	}

	/// <summary>
	/// Inserts <paramref name="item"/> without acquiring a lock (single-threaded initialization path only).
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool AddInternalUnlocked(T item, int hashCode)
	{
		var tables = this._tables;

		GetBucketAndLockNo(hashCode, out var bucketNo, out var lockNo, tables._buckets.Length, tables._locks.Length);

		if (this.TryFindInBucket(tables._buckets[bucketNo], item, hashCode, out _))
		{
			return false;
		}

		Volatile.Write(ref tables._buckets[bucketNo], new Node(item, hashCode, tables._buckets[bucketNo]));
		checked
		{
			tables._countPerLock[lockNo]++;
		}

		return true;
	}

	/// <summary>
	/// Performs the actual insertion into a bucket that is already protected by the caller's lock.
	/// </summary>
	/// <param name="tables">The current tables snapshot.</param>
	/// <param name="item">The item to add.</param>
	/// <param name="hashCode">The pre-computed hash code.</param>
	/// <param name="bucketNo">The bucket index.</param>
	/// <param name="lockNo">The lock index.</param>
	/// <returns>
	/// A tuple of (added, resizeDesired): <c>added</c> is <c>false</c> when the item was already present;
	/// <c>resizeDesired</c> is <c>true</c> when the per-lock count exceeded the budget.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private (bool added, bool resizeDesired) AddToLockedBucket(Tables tables, T item, int hashCode, int bucketNo, int lockNo)
	{
		if (this.TryFindInBucket(tables._buckets[bucketNo], item, hashCode, out _))
		{
			return (false, false);
		}

		Volatile.Write(ref tables._buckets[bucketNo], new Node(item, hashCode, tables._buckets[bucketNo]));
		checked
		{
			tables._countPerLock[lockNo]++;
		}

		return (true, tables._countPerLock[lockNo] > this._budget);
	}

	/// <summary>
	/// Computes the approximate total element count using per-lock counts. Caller must hold all locks.
	/// </summary>
	/// <returns>The computed element count. May be negative if overflow occurred.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(ComputeCountUnderLock), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private int ComputeCountUnderLock()
	{
		var count = 0;

		for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
		{
			count += this._tables._countPerLock[lockCount];
		}

		return count;
	}

	/// <summary>
	/// Copies the elements of the <see cref="ConcurrentHashSet{T}"/> to an array, starting at a specified array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from <see cref="ConcurrentHashSet{T}"/>. The array must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array"/> at which copying begins.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="array"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is less than 0.</exception>
	/// <exception cref="ArgumentException">Thrown if the number of elements in the source <see cref="ConcurrentHashSet{T}"/> is greater than the available space from <paramref name="index"/> to the end of the destination <paramref name="array"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void CopyToItems([DisallowNull] T[] array, int index)
	{
		array = array.ArgumentNotNull();
		index = index.ArgumentInRange(0);

		var buckets = this._tables._buckets;

		for (var bucketCount = 0; bucketCount < buckets.LongLength; bucketCount++)
		{
			for (var current = buckets[bucketCount]; current is not null; current = current._next)
			{
				array[index] = current._item;
				index++; // this should never flow, CopyToItems is only called when there's no overflow risk
			}
		}
	}

	/// <summary>
	/// Creates an expanded lock array for the grow operation, doubling locks when permitted.
	/// </summary>
	/// <param name="tables">The current tables snapshot.</param>
	/// <returns>The new lock array (may be the same reference if no expansion occurred).</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CreateExpandedLocks), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private object[] CreateExpandedLocks(Tables tables)
	{
		if (!this._growLockArray || tables._locks.LongLength >= MaxLockNumber)
		{
			return tables._locks;
		}

		var newLocks = new object[tables._locks.LongLength * 2];
		Array.Copy(tables._locks, 0, newLocks, 0, tables._locks.Length);
		AddNewLocks(newLocks, tables._locks.LongLength);

		return newLocks;
	}

	/// <summary>
	/// Grows the table by doubling its size and rehashing all the elements.
	/// </summary>
	/// <param name="tables">The current table to grow.</param>
	/// <exception cref="ArgumentNullException">Thrown when the tables parameter is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void GrowTable(Tables tables)
	{
		var locksAcquired = 0;

		try
		{
			// The thread that first obtains _locks[0] will be the one doing the resize operation
			this.AcquireLocks(fromInclusive: 0, toExclusive: 1, locksAcquired: ref locksAcquired);

			// Make sure nobody resized the table while we were waiting for lock 0:
			if (tables != this._tables)
			{
				// We assume that since the table reference is different, it was already resized (or the budget
				// was adjusted). If we ever decide to do table shrinking, or replace the table for other reasons,
				// we will have to revisit this logic.
				return;
			}

			// If the bucket array is too empty, double the budget instead of resizing the table
			if (this.ShouldIncreaseBudgetOnly(tables))
			{
				return;
			}

			// Compute the new table size and acquire remaining locks
			var (newLength, maximizeTableSize) = ComputeNewLength(tables);

			// Now acquire all other locks for the table
			this.AcquireLocks(1, tables._locks.Length, ref locksAcquired);

			var newLocks = this.CreateExpandedLocks(tables);
			var newBuckets = new Node[newLength];
			var newCountPerLock = new int[newLocks.Length];

			RehashBuckets(tables, newBuckets, newCountPerLock, newLocks);

			// Adjust the budget; if the table was maximized, prevent future resize calls
			this._budget = ComputeBudget(maximizeTableSize, newBuckets.Length, newLocks.Length);

			// Replace tables with the new versions
			this._tables = new Tables(newBuckets, newLocks, newCountPerLock);
		}
		finally
		{
			// Release all locks that we took earlier
			this.ReleaseLocks(0, locksAcquired);
		}
	}

	/// <summary>
	/// Initializes the ConcurrentHashSet from the provided collection.
	/// </summary>
	/// <param name="collection">The collection to initialize from.</param>
	/// <exception cref="ArgumentNullException">Thrown when the collection is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void InitializeFromCollection(in IEnumerable<T> collection)
	{
		foreach (var item in collection.ArgumentNotNull())
		{
			_ = this.AddInternal(item, this._comparer.GetHashCode(item), false);
		}

		if (this._budget == 0)
		{
			this._budget = this._tables._buckets.Length / this._tables._locks.Length;
		}
	}

	/// <summary>
	/// Returns <c>true</c> when <paramref name="node"/>'s hash code and item match the given search key.
	/// </summary>
	/// <param name="node">The node to test.</param>
	/// <param name="item">The search item.</param>
	/// <param name="hashCode">The pre-computed hash code of <paramref name="item"/>.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(NodeMatches), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private bool NodeMatches(Node node, T item, int hashCode) =>
		hashCode == node._hashCode && this._comparer.Equals(node._item, item);

	/// <summary>
	/// Releases the locks for a range of buckets.
	/// </summary>
	/// <param name="fromInclusive">The inclusive start index of the bucket range for which locks are to be released.</param>
	/// <param name="toExclusive">The exclusive end index of the bucket range for which locks are to be released.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ReleaseLocks(in int fromInclusive, in int toExclusive)
	{
		for (var inclusiveCount = fromInclusive; inclusiveCount < toExclusive; inclusiveCount++)
		{
			Monitor.Exit(this._tables._locks[inclusiveCount]);
		}
	}

	/// <summary>
	/// Searches the linked list at the given bucket position and removes the node that matches <paramref name="item"/>.
	/// Uses a ref-slot pointer to eliminate the need for a separate "previous node" variable and the
	/// branch that distinguishes head removal from mid-chain removal.
	/// </summary>
	/// <param name="tables">The current tables snapshot (caller must hold <c>tables._locks[lockNo]</c>).</param>
	/// <param name="item">The item to remove.</param>
	/// <param name="hashCode">The pre-computed hash code of <paramref name="item"/>.</param>
	/// <param name="bucketNo">The index of the target bucket.</param>
	/// <param name="lockNo">The index of the lock guarding the bucket.</param>
	/// <returns><c>true</c> if the node was found and removed; otherwise <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RemoveNodeFromBucket), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private bool RemoveNodeFromBucket(Tables tables, T item, int hashCode, int bucketNo, int lockNo)
	{
		ref var slot = ref tables._buckets[bucketNo];
		var current = slot;

		while (current is not null)
		{
			if (this.NodeMatches(current, item, hashCode))
			{
				Volatile.Write(ref slot, current._next);
				tables._countPerLock[lockNo]--;
				return true;
			}

			slot = ref current._next;
			current = current._next;
		}

		return false;
	}

	/// <summary>
	/// Computes the approximate total size of the table and doubles the budget if the table is underutilized.
	/// </summary>
	/// <param name="tables">The current tables snapshot.</param>
	/// <returns><c>true</c> if the budget was increased instead of resizing; <c>false</c> if a resize is needed.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ShouldIncreaseBudgetOnly), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private bool ShouldIncreaseBudgetOnly(Tables tables)
	{
		if (ComputeApproxCount(tables) < tables._buckets.LongLength / 4)
		{
			// Double budget using long arithmetic to avoid overflow; cap at int.MaxValue
			this._budget = (int)Math.Min((long)this._budget * 2, int.MaxValue);
			return true;
		}

		return false;
	}

	/// <summary>
	/// Adds <paramref name="item"/> to the set only when it is non-null. Used by <see cref="AddRange"/>.
	/// </summary>
	/// <param name="item">The candidate item.</param>
	/// <returns><c>true</c> if the item was added; <c>false</c> if it was null or already present.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryAddNonNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private bool TryAddNonNull(T item) =>
		item is not null && this.AddInternal(item, this._comparer.GetHashCode(item), acquireLock: true);

	/// <summary>
	/// Searches a bucket linked-list for an item matching the given hash code and equality.
	/// </summary>
	/// <param name="start">The first node in the bucket chain, or <c>null</c> if the bucket is empty.</param>
	/// <param name="item">The item to search for.</param>
	/// <param name="hashCode">The pre-computed hash code of <paramref name="item"/>.</param>
	/// <param name="foundItem">When this method returns <c>true</c>, contains the matching item stored in the set.</param>
	/// <returns><c>true</c> if a matching node was found; otherwise <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(TryFindInBucket), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private bool TryFindInBucket(Node? start, T item, int hashCode, [MaybeNullWhen(false)] out T foundItem)
	{
		for (var current = start; current is not null; current = current._next)
		{
			if (this.NodeMatches(current, item, hashCode))
			{
				foundItem = current._item;
				return true;
			}
		}

		foundItem = default;
		return false;
	}

	/// <summary>
	/// Represents a node in the concurrent hash set.
	/// </summary>
	private sealed class Node
	{

		/// <summary>
		/// The Hash Code...
		/// </summary>
		internal readonly int _hashCode;

		/// <summary>
		/// The item...
		/// </summary>
		internal readonly T _item;

		/// <summary>
		/// The next...
		/// </summary>
		internal volatile Node? _next;

		/// <summary>
		/// Initializes a new instance of the <see cref="Node"/> class.
		/// </summary>
		/// <param name="item">The item to store in the node. Cannot be null.</param>
		/// <param name="hashCode">The hash code of the item.</param>
		/// <param name="next">The next node in the chain. Can be null if the node is the last in the chain.</param>
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Node(T item, int hashCode, Node? next)
		{
			this._item = item;
			this._hashCode = hashCode;
			this._next = next;
		}

	}

	/// <summary>
	/// Represents the table structure used internally by the <see cref="ConcurrentHashSet{T}"/>.
	/// </summary>
	/// <remarks>
	/// This class holds the buckets, locks, and count per lock used to manage the concurrent hash set.
	/// </remarks>
	private sealed class Tables
	{

		/// <summary>
		/// An array of buckets, each containing a linked list of <see cref="Node"/> instances.
		/// </summary>
		internal readonly Node[] _buckets;

		/// <summary>
		/// An array of objects used as locks for synchronizing access to buckets.
		/// </summary>
		internal readonly object[] _locks;

		/// <summary>
		/// An array that keeps track of the count of elements in each corresponding bucket in <see cref="_buckets"/>.
		/// </summary>
		internal volatile int[] _countPerLock;

		/// <summary>
		/// Initializes a new instance of the <see cref="Tables"/> class.
		/// </summary>
		/// <param name="buckets">The array of buckets to store the elements of the <see cref="ConcurrentHashSet{T}"/>.</param>
		/// <param name="locks">The array of objects used as locks for synchronizing access to buckets.</param>
		/// <param name="countPerLock">The array that keeps track of the count of elements in each corresponding bucket.</param>
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Tables(Node[] buckets, object[] locks, int[] countPerLock)
		{
			this._buckets = buckets.ArgumentNotNull();
			this._locks = locks.ArgumentNotNull();
			this._countPerLock = countPerLock.ArgumentNotNull();
		}

	}

}
