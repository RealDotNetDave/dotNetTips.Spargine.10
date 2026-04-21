// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 11-12-2020
//
// Last Modified By : GitHub Copilot
// Last Modified On : 04-20-2026
// ***********************************************************************
// <copyright file="ChannelQueue.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// QueueManager class featuring the ListenAsync method for common queuing
// of items.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Queues;

/// <summary>
/// Thread-Safe queue using <see cref="Channel{T}"/>.
/// </summary>
/// <typeparam name="T">The type of items stored in the queue.</typeparam>
[Information("Queue using Channel<T>.", "David McCarter", "7/26/2021", Status = Status.Available, Documentation = "https://bit.ly/SpargineChannelQueue")]
public sealed class ChannelQueue<T>
{

	/// <summary>
	/// The timeout duration for the cancellation token.
	/// </summary>
	private readonly TimeSpan _cancellationTimeout;

	/// <summary>
	/// The channel used for storing items.
	/// </summary>
	private readonly Channel<T> _channel;

	/// <summary>
	/// The idempotency keys used to ensure that items are only processed once.
	/// </summary>
	private readonly ConcurrentDictionary<string, long> _idempotencyKeys = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class with an unbounded capacity and a default cancellation timeout of 5 minutes.
	/// </summary>
	/// <remarks>
	/// This constructor creates an unbounded channel for storing items of type <typeparamref name="T"/>.
	/// The default cancellation timeout is set to 5 minutes for graceful shutdowns.
	/// </remarks>
	[Information(nameof(ChannelQueue<>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue() : this(null) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class with an unbounded capacity and a default cancellation timeout of 5 minutes.
	/// </summary>
	/// <remarks>
	/// This constructor creates an unbounded channel for storing items of type <typeparamref name="T"/>.
	/// The default cancellation timeout is set to 5 minutes for graceful shutdowns.
	/// </remarks>
	[Information(nameof(ChannelQueue<>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue(TimeSpan? cancellationTimeout = null)
	: this(capacity: null, cancellationTimeout) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class with a bounded capacity.
	/// </summary>
	/// <param name="capacity">The maximum number of items the channel can hold before blocking writers.</param>
	/// <remarks>
	/// This constructor creates a bounded channel for storing items of type <typeparamref name="T"/>.
	/// The default cancellation timeout is set to 5 minutes for graceful shutdowns.
	/// </remarks>
	[Information(nameof(ChannelQueue<>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue(in int capacity)
	: this(capacity, null) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class with a specified capacity and optional cancellation timeout.
	/// </summary>
	/// <param name="capacity">The maximum number of items the channel can hold before blocking writers.</param>
	/// <param name="cancellationTimeout">
	/// The timeout for the cancellation token. If <c>null</c>, defaults to 5 minutes.
	/// </param>
	/// <remarks>
	/// This constructor creates a bounded channel for storing items of type <typeparamref name="T"/>.
	/// The cancellation timeout controls how long operations will wait before being canceled.
	/// </remarks>
	[Information(nameof(ChannelQueue<>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue(in int? capacity, TimeSpan? cancellationTimeout = null)
	{
		this._channel = capacity is null
			? Channel.CreateUnbounded<T>()
			: Channel.CreateBounded<T>(capacity.Value);

		this._cancellationTimeout = cancellationTimeout ?? TimeSpan.FromMinutes(5);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelQueue{T}"/> class.
	/// </summary>
	/// <param name="options">The options.</param>
	/// <param name="cancellationTimeout">The cancellation timeout.</param>
	[Information(nameof(ChannelQueue<>), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ChannelQueue(BoundedChannelOptions options, TimeSpan? cancellationTimeout = null)
	{
		this._channel = Channel.CreateBounded<T>(options);
		this._cancellationTimeout = cancellationTimeout ?? TimeSpan.FromMinutes(5);
	}

	/// <summary>
	/// Gets a task that completes when the channel is done.
	/// </summary>
	[Information(nameof(Completion), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public Task Completion => this._channel.Reader.Completion;

	/// <summary>
	/// Gets the count of items currently in the channel.
	/// </summary>
	/// <value>The count of items. Returns -1 if the channel does not support counting.</value>
	/// <remarks>
	/// Use this property to get the number of items that are currently queued in the <see cref="Channel{T}"/>.
	/// This property acquires a lock to ensure thread safety when accessing the count.
	/// </remarks>
	[Information(nameof(Count), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public int Count
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return this._channel.Reader.CanCount ? this._channel.Reader.Count : -1;
		}
	}

	/// <summary>
	/// Gets a value indicating whether the channel is completed.
	/// </summary>
	[Information(nameof(IsCompleted), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool IsCompleted => this._channel.Reader.Completion.IsCompleted;

	/// <summary>
	/// Acknowledges that the item associated with the specified <paramref name="idempotencyKey"/> has been processed,
	/// allowing future enqueues with the same key.
	/// </summary>
	/// <param name="idempotencyKey">
	/// The unique idempotency key associated with the item to acknowledge. Must not be null or empty.
	/// </param>
	/// <returns>
	/// <c>true</c> if the key was found and removed; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// Call this method after processing an item to remove its idempotency key from the internal tracking dictionary.
	/// This enables future enqueues with the same key to succeed.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Acknowledge), "David McCarter", "8/10/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool Acknowledge([DisallowNull] string idempotencyKey)
	{
		return this._idempotencyKeys.TryRemove(idempotencyKey, out _);
	}

	/// <summary>
	/// Cleanups the expired keys.
	/// </summary>
	[Information(nameof(CleanupExpiredKeys), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void CleanupExpiredKeys()
	{
		var now = UtcNowMs();

		foreach (var kvp in this._idempotencyKeys.ToArray())
		{
			if (kvp.Value <= now)
			{
				_ = this._idempotencyKeys.TryRemove(kvp.Key, out _);
			}
		}
	}

	/// <summary>
	/// Removes all items from the channel.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clear), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void Clear()
	{
		while (this._channel.Reader.TryRead(out _))
		{ }

		// Clear the idempotency keys as well
		this._idempotencyKeys.Clear();
	}

	/// <summary>
	/// Asynchronously listens for and yields all items from the channel until the channel is completed or the operation is canceled.
	/// </summary>
	/// <param name="cancellationToken">
	/// A <see cref="CancellationToken"/> that can be used to cancel the listening operation.
	/// </param>
	/// <returns>
	/// An <see cref="IAsyncEnumerable{T}"/> that yields each item as it is read from the channel.
	/// </returns>
	/// <remarks>
	/// The method links the provided cancellation token with an internal timeout to allow for graceful shutdowns.
	/// Call <see cref="Lock"/> to complete the channel and end the enumeration.
	/// If the channel is closed or the operation is canceled, the enumeration ends.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ListenAsync), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async IAsyncEnumerable<T> ListenAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
	{
		// Ensure the cancellation token is linked with any existing tokens with a reasonable timeout to allow for graceful shutdowns
		using (var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
		{
			linkedCts.CancelAfter(this._cancellationTimeout);

			IAsyncEnumerable<T> items;
			try
			{
				items = this._channel.Reader.ReadAllAsync(linkedCts.Token);
			}
			catch (OperationCanceledException)
			{
				yield break;
			}
			catch (ChannelClosedException ex)
			{
				throw new InvalidOperationException(Resources.AnErrorOccurredWhileReadingFromTheChannel, ex);
			}

			await foreach (var item in items.WithCancellation(linkedCts.Token))
			{
				yield return item;
			}
		}
	}

	/// <summary>
	/// Locks the Channel so more items cannot be added. This is not reversible.
	/// </summary>
	/// <returns><c>true</c> if the <see cref="ChannelWriter{T}"/> successfully marked the channel as complete; <c>false</c> otherwise.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Lock), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool Lock()
	{
		try
		{
			return this._channel.Writer.TryComplete();
		}
		catch (ChannelClosedException)
		{
			// Channel is already closed, so return false
			return false;

		}
	}

	/// <summary>
	/// Reads an item from the Channel as an asynchronous operation.
	/// </summary>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A task that represents the asynchronous read operation. The task result contains the read item of type <typeparamref name="T"/>.</returns>
	/// <exception cref="OperationCanceledException">Thrown when the operation is canceled.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ReadAsync), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async ValueTask<T> ReadAsync(CancellationToken cancellationToken = default)
	{
		try
		{
			return await this._channel.Reader.ReadAsync(cancellationToken).ConfigureAwait(false);
		}
		catch (OperationCanceledException)
		{
			throw;
		}
		catch (ChannelClosedException ex)
		{
			throw new InvalidOperationException(Resources.AnErrorOccurredWhileReadingFromTheChannel, ex);
		}
	}

	/// <summary>
	/// Reads an item from the channel and removes the associated idempotency key using the provided resolver.
	/// Use this overload when you can derive the idempotency key from the item itself.
	/// </summary>
	/// <param name="keyResolver">
	/// A function that resolves the idempotency key from the item. Must not be null.
	/// </param>
	/// <param name="cancellationToken">
	/// A cancellation token to observe while waiting for the task to complete.
	/// </param>
	/// <returns>
	/// A task that represents the asynchronous read operation. The task result contains the read item of type <typeparamref name="T"/>.
	/// </returns>
	/// <remarks>
	/// This method first reads an item from the channel, then removes the associated idempotency key using the provided <paramref name="keyResolver"/>.
	/// This enables future enqueues with the same key.
	/// </remarks>
	[Information(nameof(ReadAsync), "David McCarter", "8/10/2025",
		UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async ValueTask<T> ReadAsync([DisallowNull] Func<T, string> keyResolver, CancellationToken cancellationToken = default)
	{
		keyResolver = keyResolver.ArgumentNotNull();

		// Reuse the existing ReadAsync to get the item…
		var item = await this.ReadAsync(cancellationToken).ConfigureAwait(false); // existing method

		// …then clear the key so future enqueues are allowed.
		var key = keyResolver.Invoke(item).ArgumentNotNullOrEmpty();

		_ = this._idempotencyKeys.TryRemove(key, out _);

		return item;
	}

	/// <summary>
	/// Attempts to peek at an item from the channel without removing it.
	/// </summary>
	/// <param name="item">
	/// When this method returns, contains the item peeked from the channel if the operation was successful; otherwise, the default value for the type of the <typeparamref name="T"/> parameter.
	/// </param>
	/// <returns>
	/// <c>true</c> if an item was peeked from the channel; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// This method does not remove the item from the channel. If the channel is empty, it returns immediately with <c>false</c>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryPeek), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryPeek(out T item)
	{
		return this._channel.Reader.TryPeek(out item!);
	}

	/// <summary>
	/// Attempts to read an item from the channel without waiting.
	/// </summary>
	/// <param name="item">
	/// When this method returns, contains the item removed from the channel if the operation was successful; otherwise, the default value for the type of the <typeparamref name="T"/> parameter.
	/// </param>
	/// <returns>
	/// <c>true</c> if an item was read from the channel; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// This method does not block. If the channel is empty, it returns immediately with <c>false</c>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryRead), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool TryRead(out T item)
	{
		return this._channel.Reader.TryRead(out item!);
	}

	/// <summary>
	/// Attempts to write an item to the channel without waiting.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryWrite), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool TryWrite([DisallowNull] T item)
	{
		item = item.ArgumentNotNull();
		return this._channel.Writer.TryWrite(item);
	}

	/// <summary>
	/// Attempts to write <paramref name="item"/> to the channel only once per <paramref name="idempotencyKey"/>.
	/// Returns <c>false</c> if the key already exists (not yet acknowledged or not yet expired) or if the channel cannot accept the item now.
	/// </summary>
	/// <param name="item">
	/// The item to enqueue. Must not be null.
	/// </param>
	/// <param name="idempotencyKey">
	/// A stable, unique key for this logical enqueue. Must not be null or empty.
	/// </param>
	/// <param name="dedupeWindow">
	/// Optional time window to remember the key. If <c>null</c>, the key remains until acknowledged.
	/// </param>
	/// <returns>
	/// <c>true</c> if the item was written to the channel and the key was added; <c>false</c> if the key already exists or the channel is full.
	/// </returns>
	/// <remarks>
	/// <para>
	/// This method is non-blocking and does not wait for space in the channel. If the key is already present and not expired, or if the channel is full, the method returns <c>false</c>.
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong> While individual operations on <see cref="ConcurrentDictionary{TKey, TValue}"/> and <see cref="Channel{T}"/> are thread-safe,
	/// there is a small window between checking for expired keys and adding new ones where race conditions could occur.
	/// This is acceptable for idempotency scenarios where the goal is "at-most-once" delivery with best-effort expiration cleanup.
	/// </para>
	/// <para>
	/// <strong>Expired Key Handling:</strong> If a key has expired (expiry timestamp is less than current time), it is opportunistically removed before attempting the write.
	/// Due to the non-atomic nature of check-then-remove, it's possible for multiple threads to detect the same expired key,
	/// but only one will successfully remove it. This is harmless as ConcurrentDictionary.TryRemove"/> is idempotent.
	/// </para>
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryWriteOnce), "David McCarter", "8/10/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryWriteOnce([DisallowNull] T item, [DisallowNull] string idempotencyKey, TimeSpan? dedupeWindow = null)
	{
		item = item.ArgumentNotNull();
		idempotencyKey = idempotencyKey.ArgumentNotNullOrEmpty();

		// Single timestamp for both "now" check and expiry calculation,
		// eliminating the redundant DateTimeOffset.UtcNow call inside ToExpiryMs.
		var nowMs = UtcNowMs();
		var expiryTime = dedupeWindow is { } window
			? nowMs + (long)window.TotalMilliseconds
			: long.MaxValue;

		// Fast path: attempt TryAdd first (most common case is a new key)
		if (!this._idempotencyKeys.TryAdd(idempotencyKey, expiryTime))
		{
			// Key already exists — check if it's expired
			if (!this._idempotencyKeys.TryGetValue(idempotencyKey, out var existingExpiry) || existingExpiry >= nowMs)
			{
				return false; // Key is still valid (not expired) or was removed by another thread
			}

			// Expired key — remove and retry the add
			_ = this._idempotencyKeys.TryRemove(idempotencyKey, out _);

			if (!this._idempotencyKeys.TryAdd(idempotencyKey, expiryTime))
			{
				return false; // Another thread claimed the key first
			}
		}

		// We own the idempotency key — try to write to the channel
		if (this._channel.Writer.TryWrite(item))
		{
			return true;
		}

		// Channel write failed (likely full) — roll back the key to allow future attempts
		_ = this._idempotencyKeys.TryRemove(idempotencyKey, out _);

		return false;
	}

	/// <summary>
	/// Writes an item to the Channel as an asynchronous operation.
	/// </summary>
	/// <param name="item">The item to write.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation. See <see cref="CancellationToken"/>.</param>
	/// <returns>A Task representing the asynchronous operation. See <see cref="Task"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is null.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(WriteAsync), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async Task WriteAsync([DisallowNull] T item, CancellationToken cancellationToken = default)
	{
		item = item.ArgumentNotNull();

		try
		{
			await this._channel.Writer.WriteAsync(item, cancellationToken).ConfigureAwait(false);
		}
		catch (ChannelClosedException ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileWritingToTheChannel, ex);
		}
	}

	/// <summary>
	/// Write a collection to the Channel as an asynchronous operation.
	/// </summary>
	/// <param name="items">The items to write to the <see cref="Channel{T}"/>.</param>
	/// <param name="lockQueue">If set to <c>true</c>, locks the queue after writing the items, preventing any more items from being added.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation. See <see cref="CancellationToken"/>.</param>
	/// <returns>A Task representing the asynchronous operation. See <see cref="Task"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="items"/> is null.</exception>
	/// <remarks>
	/// This method allows for multiple items to be written to the channel at once. If <paramref name="lockQueue"/> is true,
	/// the queue will be locked after the items are written, which is useful for batch processing scenarios.
	/// Make sure to call .Dispose on Task
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(WriteAsync), "David McCarter", "7/26/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async Task WriteAsync([DisallowNull] IEnumerable<T> items, bool lockQueue = false, CancellationToken cancellationToken = default)
	{
		items = items.ArgumentNotNull();

		try
		{
			foreach (var item in items)
			{
				await this._channel.Writer.WriteAsync(item, cancellationToken).ConfigureAwait(false);
			}

			if (lockQueue)
			{
				_ = this.Lock();
			}
		}
		catch (ChannelClosedException ex)
		{
			// Log or handle the exception as needed
			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileWritingToTheChannel, ex);
		}
	}

	/// <summary>
	/// Attempts to write <paramref name="item"/> to the channel only once per <paramref name="idempotencyKey"/> asynchronously.
	/// Returns <c>false</c> if the key was already enqueued and not yet acknowledged (or not yet expired).
	/// </summary>
	/// <param name="item">
	/// The item to enqueue. Must not be null.
	/// </param>
	/// <param name="idempotencyKey">
	/// A stable, unique key for this logical enqueue. Must not be null or empty.
	/// </param>
	/// <param name="dedupeWindow">
	/// Optional time window to remember the key. If <c>null</c>, the key remains until acknowledged.
	/// </param>
	/// <param name="cancellationToken">
	/// A cancellation token to observe while waiting for the task to complete.
	/// </param>
	/// <returns>
	/// A task that represents the asynchronous operation. The task result is <c>true</c> if the item was written and the key was added; <c>false</c> if the key already exists or the channel is closed.
	/// </returns>
	/// <remarks>
	/// This method ensures that only the first enqueue for a given <paramref name="idempotencyKey"/> within the deduplication window is accepted.
	/// If the key is already present and not expired, or if the channel is closed, the method returns <c>false</c>.
	/// If the key has expired, it is removed and the write is retried.
	/// If the write fails due to a closed channel, the key is removed to allow future attempts.
	/// </remarks>
	[Information(nameof(WriteOnceAsync), "David McCarter", "8/10/2025",
		UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public async Task<bool> WriteOnceAsync([DisallowNull] T item, [DisallowNull] string idempotencyKey, TimeSpan? dedupeWindow = null, CancellationToken cancellationToken = default)
	{
		item = item.ArgumentNotNull();
		idempotencyKey = idempotencyKey.ArgumentNotNullOrEmpty();

		var now = UtcNowMs();

		// Opportunistically clear an expired record for this key.
		if (this._idempotencyKeys.TryGetValue(idempotencyKey, out var expiresAt) && expiresAt <= now)
		{
			_ = this._idempotencyKeys.TryRemove(idempotencyKey, out _);
		}

		// First writer wins.
		if (!this._idempotencyKeys.TryAdd(idempotencyKey, ToExpiryMs(dedupeWindow)))
		{
			return false; // duplicate -> ignore
		}

		try
		{
			await this._channel.Writer.WriteAsync(item, cancellationToken).ConfigureAwait(false);

			return true;
		}
		catch (ChannelClosedException ex)
		{
			// Roll back the key since the write failed.
			_ = this._idempotencyKeys.TryRemove(idempotencyKey, out _);

			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileWritingToTheChannel, ex);

			return false; // unreachable, kept for clarity
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static long ToExpiryMs(TimeSpan? window)
	{
		return window is null ? long.MaxValue : DateTimeOffset.UtcNow.Add(window.Value).ToUnixTimeMilliseconds();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static long UtcNowMs() => Clock.UnixTimestampMilliseconds;


}
