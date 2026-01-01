// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 11-06-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-01-2026
// ***********************************************************************
// <copyright file="CollectionRandomizer.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Designed to shuffle a collection either once or endlessly. Enables
// users to retrieve items using the GetNext() method.
// </summary>
// ***********************************************************************

using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Collections;

/// <summary>
/// Initializes a new instance of the <see cref="CollectionRandomizer{T}"/> class.
/// </summary>
/// <param name="collection">The collection to randomize. This collection must not be null.</param>
/// <param name="repeat">if set to <c>true</c>, the collection will repeat over and over, each time reshuffled. Be cautious of endless loops, which could crash your application.</param>
/// <remarks>
/// The <see cref="CollectionRandomizer{T}"/> is designed to shuffle a collection and allow retrieving items sequentially with the option to repeat and reshuffle.
/// </remarks>
[DebuggerDisplay("Count = {Count}, CurrentIndex = {CurrentIndex}, HasRemainingItems = {HasRemainingItems}")]
[Information(nameof(CollectionRandomizer<>), author: "David McCarter and Kristine Tran", createdOn: "8/26/2020", Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineCollectionRandomizer")]
public sealed class CollectionRandomizer<T>([DisallowNull] in IEnumerable<T> collection, bool repeat = false) : IEnumerable<T>
{

	/// <summary>
	/// The thread lock used to ensure thread safety when accessing the collection.
	/// </summary>
	private readonly Lock _threadLock = new();

	/// <summary>
	/// The collection to be randomized. This collection is converted to an <see cref="ImmutableArray{T}"/> to ensure thread-safety and immutability.
	/// </summary>
	private ImmutableArray<T> _collection = [.. collection];

	/// <summary>
	/// The current index in the randomized collection sequence.
	/// </summary>
	/// <remarks>
	/// The index is zero-based and indicates the position of the current item in the randomized collection.
	/// </remarks>
	private int _currentIndex = -1;

	/// <summary>
	/// Backing field for the <see cref="HasRemainingItems"/> property.
	/// Indicates whether there are remaining items to be retrieved from the collection.
	/// </summary>
	private bool _hasRemainingItems;

	/// <summary>
	/// Indicates whether the <see cref="CollectionRandomizer{T}"/> has been initialized. Initialization occurs upon the first call to <see cref="GetNext"/>. 
	/// If <c>true</c>, the collection has been shuffled and is ready for item retrieval.
	/// </summary>
	private bool _initialized;

	/// <summary>
	/// Gets the total count of items in the collection.
	/// </summary>
	[Information(nameof(Count), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public int Count
	{
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			lock (this._threadLock)
			{
				return this._collection.Length;
			}
		}
	}

	/// <summary>
	/// Gets the current index in the randomized collection sequence.
	/// </summary>
	/// <remarks>
	/// The index is zero-based and indicates the position of the current item in the randomized collection.
	/// Returns -1 if no items have been retrieved yet.
	/// </remarks>
	[Information(nameof(CurrentIndex), "David McCarter", "6/25/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public int CurrentIndex
	{
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			lock (this._threadLock)
			{
				return this._currentIndex;
			}
		}
	}

	/// <summary>
	/// Gets a value indicating whether this instance has remaining items to be retrieved by <see cref="GetNext"/>.
	/// </summary>
	/// <value>
	/// <c>true</c> if this instance has remaining items; otherwise, <c>false</c>. This value will be <c>false</c>
	/// until the first time <see cref="GetNext"/> is called and the collection is shuffled.
	/// </value>
	[Pure]
	[Information(nameof(HasRemainingItems), "David McCarter", "4/21/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool HasRemainingItems
	{
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			lock (this._threadLock)
			{
				return this._hasRemainingItems;
			}
		}

		private set => this._hasRemainingItems = value;
	}

	/// <summary>
	/// Gets the percentage of items already retrieved from the collection.
	/// </summary>
	/// <remarks>
	/// Returns 0.0 if the collection has not been initialized or is empty.
	/// Returns 100.0 when all items have been retrieved (and repeat is false).
	/// </remarks>
	[Information(nameof(PercentageComplete), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public double PercentageComplete
	{
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			lock (this._threadLock)
			{
				return !this._initialized || this._collection.Length == 0 ? 0.0 : (this._currentIndex + 1) / (double)this._collection.Length * 100.0;
			}
		}
	}

	/// <summary>
	/// Returns an enumerator that iterates through a collection.
	/// </summary>
	/// <returns>An <see cref="IEnumerator" /> object that can be used to iterate through the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Returns an enumerator that iterates through the randomized collection.
	/// </summary>
	/// <returns>An <see cref="IEnumerator{T}"/> that can be used to iterate through the collection.</returns>
	/// <remarks>
	/// When used with repeat mode enabled, this creates an infinite sequence. 
	/// Exercise caution with operations that materialize the entire sequence (like ToList() or ToArray()).
	/// </remarks>
	[Information(nameof(GetEnumerator), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public IEnumerator<T> GetEnumerator()
	{
		while (true)
		{
			lock (this._threadLock)
			{
				// Check if we should stop (exhausted and not repeating)
				if (this._initialized && this._currentIndex >= this._collection.Length - 1 && !repeat)
				{
					yield break;
				}
			}

			// GetNext will handle initialization and repeat logic
			yield return this.GetNext();
		}
	}

	/// <summary>
	/// Gets the next item in the collection. If the collection is set to repeat, it will reshuffle once all items have been retrieved.
	/// </summary>
	/// <returns>The next item of type <typeparamref name="T"/> from the collection.</returns>
	/// <exception cref="InvalidOperationException">Thrown if the collection is empty or all items have been retrieved and the collection is not set to repeat.</exception>
	/// <seealso cref="Init"/>
	[return: NotNull]
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetNext), "David McCarter", "4/21/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public T GetNext()
	{
		lock (this._threadLock)
		{
			if (!this._initialized || (this._currentIndex >= this._collection.Length - 1 && repeat))
			{
				this.Init();
			}
			else if (this._currentIndex >= this._collection.Length - 1)
			{
				ExceptionThrower.ThrowInvalidOperationException(Resources.NoMoreItemsToRetrieveAndTheCollectionIsNot);
			}

			this._currentIndex++;
			this.HasRemainingItems = this._currentIndex < this._collection.Length - 1;

			return this._collection[this._currentIndex]!;
		}
	}

	/// <summary>
	/// Returns the next item in the collection without advancing the index.
	/// If the collection is not initialized or exhausted (and <c>repeat</c> is true), it will be reshuffled.
	/// </summary>
	/// <returns>The next item of type <typeparamref name="T"/> in the collection.</returns>
	/// <exception cref="InvalidOperationException">Thrown if the collection is empty or all items have been retrieved and the collection is not set to repeat.</exception>
	[return: NotNull]
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PeekNext), "David McCarter", "6/25/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public T PeekNext()
	{
		lock (this._threadLock)
		{
			if (!this._initialized || (this._currentIndex >= this._collection.Length - 1 && repeat))
			{
				this.Init();
			}
			else if (this._currentIndex >= this._collection.Length - 1)
			{
				ExceptionThrower.ThrowInvalidOperationException(Resources.NoMoreItemsToRetrieveAndTheCollectionIsNot);
			}

			// Return the next item without advancing the index
			return this._collection[this._currentIndex + 1]!;
		}
	}

	/// <summary>
	/// Resets the <see cref="CollectionRandomizer{T}"/> to its initial state, reshuffling the collection and restarting the sequence.
	/// </summary>
	[DebuggerStepThrough]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Reset), "David McCarter", "6/25/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public void Reset()
	{
		lock (this._threadLock)
		{
			this._initialized = false;
			this.Init();
		}
	}

	/// <summary>
	/// Skips the next item in the collection without returning it.
	/// </summary>
	/// <returns><c>true</c> if an item was skipped; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// If the collection is set to repeat and is exhausted, it will be reshuffled before skipping.
	/// </remarks>
	[Information(nameof(SkipNext), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public bool SkipNext()
	{
		lock (this._threadLock)
		{
			if (!this._initialized || (this._currentIndex >= this._collection.Length - 1 && repeat))
			{
				this.Init();
			}
			else if (this._currentIndex >= this._collection.Length - 1)
			{
				return false;
			}

			this._currentIndex++;
			this.HasRemainingItems = this._currentIndex < this._collection.Length - 1;

			return true;
		}
	}

	/// <summary>
	/// Returns a snapshot of the current shuffled collection as an array.
	/// </summary>
	/// <returns>An array containing the shuffled items.</returns>
	/// <remarks>
	/// This returns a copy of the entire collection in its current shuffled state,
	/// not just the remaining items.
	/// </remarks>
	[return: NotNull]
	[Information(nameof(ToArray), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public T[] ToArray()
	{
		lock (this._threadLock)
		{
			return [.. this._collection];
		}
	}

	/// <summary>
	/// Initializes this instance of <see cref="CollectionRandomizer{T}"/>.
	/// </summary>
	/// <remarks>
	/// This method prepares the collection for item retrieval by shuffling it. If the <see cref="CollectionRandomizer{T}"/> is set to repeat,
	/// the collection will be reshuffled each time it is exhausted. This method is called automatically before the first item retrieval.
	/// </remarks>
	/// <exception cref="InvalidValueException{ImmutableArray}">Thrown if the underlying collection is null or empty.</exception>
	private void Init()
	{
		//Ignore if initialized unless repeat is true.
		if (!((!this._initialized || !this.HasRemainingItems) &&
			(!this._initialized || !this.HasRemainingItems || repeat)))
		{
			return;
		}

		//Validate Collection
		if (this._collection.Length is 0)
		{
			ExceptionThrower.ThrowInvalidValueException(Resources.UnderlyingCollectionIsNull, this._collection);
		}

		//Shuffle Collection
		this._collection = [.. this._collection.Shuffle()];

		//Reset index to start (-1 so GetNext() will increment to 0)
		this._currentIndex = -1;
		this.HasRemainingItems = this._collection.Length > 0;
		this._initialized = true;
	}
}
