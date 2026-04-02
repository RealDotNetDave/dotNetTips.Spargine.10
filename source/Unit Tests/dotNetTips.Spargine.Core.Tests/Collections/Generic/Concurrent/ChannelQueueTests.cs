// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-26-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2026
// ***********************************************************************
// <copyright file="ChannelQueueTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Queues;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent;

[ExcludeFromCodeCoverage]
[TestClass]
public class ChannelQueueTests
{

	[TestMethod]
	public void Acknowledge_RemovesKey_ReturnsTrue()
	{
		var queue = new ChannelQueue<int>();
		var key = "idempotent-key";

		_ = queue.TryWriteOnce(1, key);

		Assert.IsTrue(queue.Acknowledge(key), "Acknowledge should remove the key and return true.");
		Assert.IsFalse(queue.Acknowledge(key), "Acknowledge should return false for a non-existent key.");
	}

	[TestMethod]
	public void CleanupExpiredKeys_AfterClear_DoesNotThrow()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		queue.TryWriteOnce("item", "key", TimeSpan.FromMilliseconds(1));

		queue.Clear();

		// Act & Assert - Should not throw after clear
		queue.CleanupExpiredKeys();
	}

	[TestMethod]
	public void CleanupExpiredKeys_CalledMultipleTimes_DoesNotThrow()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		queue.TryWriteOnce("item", "key", TimeSpan.FromMilliseconds(1));
		Thread.Sleep(10);

		// Act & Assert - Multiple calls should not throw
		queue.CleanupExpiredKeys();
		queue.CleanupExpiredKeys();
		queue.CleanupExpiredKeys();
	}

	[TestMethod]
	public void CleanupExpiredKeys_DoesNotRemoveNonExpiredKeys()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		var idempotencyKey = "non-expired-key";

		// Write with a long dedupe window
		queue.TryWriteOnce("item1", idempotencyKey, TimeSpan.FromMinutes(10));

		// Act
		queue.CleanupExpiredKeys();

		// Assert - Key should still exist, blocking new write with same key
		var result = queue.TryWriteOnce("item2", idempotencyKey, TimeSpan.FromMinutes(5));
		Assert.IsFalse(result, "Should not be able to write with the same key - it hasn't expired.");
	}
	[TestMethod]
	public void CleanupExpiredKeys_RemovesExpiredKeys()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		var idempotencyKey = "expired-key";

		// Write with a very short dedupe window
		queue.TryWriteOnce("item1", idempotencyKey, TimeSpan.FromMilliseconds(1));

		// Wait for the key to expire
		Thread.Sleep(50);

		// Act
		queue.CleanupExpiredKeys();

		// Assert - Key should be removed, allowing new write with same key
		var result = queue.TryWriteOnce("item2", idempotencyKey, TimeSpan.FromMinutes(5));
		Assert.IsTrue(result, "Should be able to write with the same key after cleanup.");
	}

	[TestMethod]
	public void CleanupExpiredKeys_RemovesMultipleExpiredKeys()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		var keys = new[] { "key1", "key2", "key3" };

		// Write with short dedupe window
		foreach (var key in keys)
		{
			queue.TryWriteOnce($"item-{key}", key, TimeSpan.FromMilliseconds(1));
		}

		// Wait for all keys to expire
		Thread.Sleep(50);

		// Act
		queue.CleanupExpiredKeys();

		// Assert - All keys should be removed
		foreach (var key in keys)
		{
			var result = queue.TryWriteOnce($"new-item-{key}", key, TimeSpan.FromMinutes(5));
			Assert.IsTrue(result, $"Should be able to write with key '{key}' after cleanup.");
		}
	}

	[TestMethod]
	public async Task CleanupExpiredKeys_ThreadSafe_ConcurrentAccess()
	{
		// Arrange
		var queue = new ChannelQueue<string>();

		// Add many keys with short expiry
		for (var i = 0; i < 100; i++)
		{
			queue.TryWriteOnce($"item{i}", $"key{i}", TimeSpan.FromMilliseconds(1));
		}

		Thread.Sleep(50);

		// Act - Call cleanup concurrently with writes
		var cleanupTask = Task.Run(() =>
		{
			for (var i = 0; i < 10; i++)
			{
				queue.CleanupExpiredKeys();
				Thread.Sleep(5);
			}
		});

		var writeTask = Task.Run(() =>
		{
			for (var i = 100; i < 200; i++)
			{
				queue.TryWriteOnce($"item{i}", $"key{i}", TimeSpan.FromMinutes(5));
			}
		});

		// Assert - No exceptions should be thrown
		await Task.WhenAll(cleanupTask, writeTask);
		Assert.IsTrue(queue.Count > 0);
	}

	[TestMethod]
	public void CleanupExpiredKeys_WithEmptyKeys_DoesNotThrow()
	{
		// Arrange
		var queue = new ChannelQueue<string>();

		// Act & Assert - Should not throw
		queue.CleanupExpiredKeys();

		// Verify queue still works
		Assert.IsTrue(queue.TryWrite("test"));
	}

	[TestMethod]
	public void CleanupExpiredKeys_WithMixedKeys_OnlyRemovesExpired()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		var expiredKey = "expired-key";
		var validKey = "valid-key";

		// Write with short dedupe window (will expire)
		_ = queue.TryWriteOnce("expired-item", expiredKey, TimeSpan.FromMilliseconds(1));

		// Write with long dedupe window (won't expire)
		_ = queue.TryWriteOnce("valid-item", validKey, TimeSpan.FromMinutes(10));

		// Wait for short key to expire
		Thread.Sleep(50);

		// Act
		queue.CleanupExpiredKeys();

		// Assert
		var expiredResult = queue.TryWriteOnce("new-expired-item", expiredKey, TimeSpan.FromMinutes(5));
		Assert.IsTrue(expiredResult, "Should be able to write with expired key after cleanup.");

		var validResult = queue.TryWriteOnce("new-valid-item", validKey, TimeSpan.FromMinutes(5));
		Assert.IsFalse(validResult, "Should not be able to write with non-expired key.");
	}

	[TestMethod]
	public void CleanupExpiredKeys_WithNullDedupeWindow_KeysRemainUntilAcknowledged()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		var idempotencyKey = "permanent-key";

		// Write without dedupe window (uses long.MaxValue)
		queue.TryWriteOnce("item1", idempotencyKey, dedupeWindow: null);

		// Act
		queue.CleanupExpiredKeys();

		// Assert - Key should still exist (long.MaxValue expiry)
		var result = queue.TryWriteOnce("item2", idempotencyKey);
		Assert.IsFalse(result, "Key without dedupe window should not be cleaned up.");
	}

	[TestMethod]
	public void Clear_RemovesAllItems()
	{
		var queue = new ChannelQueue<int>();
		queue.WriteAsync(1).Wait();
		queue.WriteAsync(2).Wait();
		queue.Clear();
		Assert.AreEqual(0, queue.Count, "Clear should remove all items from the channel.");
	}

	[TestMethod]
	public async Task Completion_CompletesAfterLock()
	{
		var queue = new ChannelQueue<int>();
		queue.Lock();
		await queue.Completion;
		Assert.IsTrue(queue.Completion.IsCompleted, "Completion should be completed after locking the channel.");
	}

	[TestMethod]
	public void Constructor_Default_IsUnbounded()
	{
		var channel = new ChannelQueue<int>();
		// Adding more items than a typical bounded capacity to test if it's unbounded
		for (int i = 0; i < 10000; i++)
		{
			channel.WriteAsync(i).Wait();
		}
		Assert.IsGreaterThan(0, channel.Count, "Channel should allow adding many items, indicating it's unbounded.");
	}

	[TestMethod]
	public void Constructor_NegativeCapacity_ThrowsArgumentOutOfRangeException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new ChannelQueue<int>(-1));
	}


	[TestMethod]
	public void Constructor_Timeout_SetsPropertiesCorrectly()
	{
		// Arrange
		int capacity = 10;
		TimeSpan timeout = TimeSpan.FromMinutes(1);

		// Act
		var channelQueue = new ChannelQueue<int>(capacity, timeout);

		// Assert
		Assert.AreEqual(timeout, channelQueue.GetType().GetField("_cancellationTimeout", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(channelQueue), "The cancellation timeout should be set correctly.");
	}

	[TestMethod]
	public async Task Constructor_WithBoundedChannelOptions_AllowsAsyncReadWrite()
	{
		// Arrange
		var options = new BoundedChannelOptions(10)
		{
			SingleReader = false,
			SingleWriter = false
		};
		var queue = new ChannelQueue<string>(options);
		var testItem = "test item";

		// Act
		await queue.WriteAsync(testItem);
		var result = await queue.ReadAsync();

		// Assert
		Assert.AreEqual(testItem, result);
		Assert.AreEqual(0, queue.Count);
	}

	[TestMethod]
	public void Constructor_WithBoundedChannelOptions_AndCustomCancellationTimeout_SetsTimeout()
	{
		// Arrange
		var options = new BoundedChannelOptions(10);
		var customTimeout = TimeSpan.FromSeconds(30);

		// Act
		var queue = new ChannelQueue<string>(options, customTimeout);

		// Assert - Queue should work normally
		Assert.IsNotNull(queue);
		Assert.IsTrue(queue.TryWrite("test"));
		Assert.AreEqual(1, queue.Count);
	}

	[TestMethod]
	public void Constructor_WithBoundedChannelOptions_AndNullCancellationTimeout_UsesDefaultTimeout()
	{
		// Arrange
		var options = new BoundedChannelOptions(10);

		// Act
		var queue = new ChannelQueue<string>(options, cancellationTimeout: null);

		// Assert - Queue should work normally with default 5 minute timeout
		Assert.IsNotNull(queue);
		Assert.IsTrue(queue.TryWrite("test"));
		Assert.AreEqual(1, queue.Count);
	}

	[TestMethod]
	public void Constructor_WithBoundedChannelOptions_CanLockAndComplete()
	{
		// Arrange
		var options = new BoundedChannelOptions(10);
		var queue = new ChannelQueue<string>(options);

		queue.TryWrite("item1");

		// Act
		var lockResult = queue.Lock();

		// Assert
		Assert.IsTrue(lockResult);
		Assert.IsFalse(queue.TryWrite("item2")); // Cannot write after lock
	}

	[TestMethod]
	public void Constructor_WithBoundedChannelOptions_ClearRemovesAllItems()
	{
		// Arrange
		var options = new BoundedChannelOptions(10);
		var queue = new ChannelQueue<string>(options);

		queue.TryWrite("item1");
		queue.TryWrite("item2");
		queue.TryWrite("item3");

		// Act
		queue.Clear();

		// Assert
		Assert.AreEqual(0, queue.Count);
		Assert.IsFalse(queue.TryRead(out _));
	}

	[TestMethod]
	public void Constructor_WithBoundedChannelOptions_CompletionTaskAvailable()
	{
		// Arrange
		var options = new BoundedChannelOptions(10);
		var queue = new ChannelQueue<string>(options);

		// Assert - Completion task should be available
		Assert.IsNotNull(queue.Completion);
		Assert.IsFalse(queue.Completion.IsCompleted);

		// Act
		queue.Lock();

		// Assert - After lock, completion should be triggered
		Assert.IsTrue(queue.IsCompleted);
	}

	[TestMethod]
	public void Constructor_WithBoundedChannelOptions_CreatesWorkingQueue()
	{
		// Arrange
		var options = new BoundedChannelOptions(10)
		{
			FullMode = BoundedChannelFullMode.Wait
		};

		// Act
		var queue = new ChannelQueue<string>(options);

		// Assert
		Assert.IsNotNull(queue);
		Assert.AreEqual(0, queue.Count);
		Assert.IsFalse(queue.IsCompleted);
	}

	[TestMethod]
	public void Constructor_WithBoundedChannelOptions_DropOldestMode_DropsOldestWhenFull()
	{
		// Arrange
		var capacity = 2;
		var options = new BoundedChannelOptions(capacity)
		{
			FullMode = BoundedChannelFullMode.DropOldest
		};
		var queue = new ChannelQueue<int>(options);

		// Act - Write more items than capacity
		queue.TryWrite(1);
		queue.TryWrite(2);
		queue.TryWrite(3); // Should drop 1

		// Assert
		Assert.AreEqual(capacity, queue.Count);
		Assert.IsTrue(queue.TryRead(out var first));
		Assert.AreEqual(2, first); // First item (1) was dropped
	}

	[TestMethod]
	public async Task Constructor_WithBoundedChannelOptions_ListenAsyncWorks()
	{
		// Arrange
		var options = new BoundedChannelOptions(10);
		var queue = new ChannelQueue<int>(options, TimeSpan.FromSeconds(5));
		var items = new List<int> { 1, 2, 3 };

		foreach (var item in items)
		{
			queue.TryWrite(item);
		}
		queue.Lock();

		// Act
		var receivedItems = new List<int>();
		await foreach (var item in queue.ListenAsync())
		{
			receivedItems.Add(item);
		}

		// Assert
		CollectionAssert.AreEqual(items, receivedItems);
	}

	[TestMethod]
	public void Constructor_WithCapacity_IsBounded()
	{
		int capacity = 5;
		var channel = new ChannelQueue<int>(capacity);
		for (int i = 0; i < capacity; i++)
		{
			channel.WriteAsync(i).Wait();
		}
		Assert.AreEqual(capacity, channel.Count, $"Channel should not allow adding more than {capacity} items.");
	}

	[TestMethod]
	public void Constructor_WithNegativeCapacity_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		int negativeCapacity = -1;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => new ChannelQueue<int>(negativeCapacity), "A negative capacity should throw an ArgumentOutOfRangeException.");
	}

	[TestMethod]
	public void Constructor_WithNullTimeout_SetsDefaultTimeout()
	{
		// Arrange
		int capacity = 10;
		TimeSpan defaultTimeout = TimeSpan.FromMinutes(5);

		// Act
		var channelQueue = new ChannelQueue<int>(capacity, null);

		// Assert
		Assert.AreEqual(defaultTimeout, channelQueue.GetType().GetField("_cancellationTimeout", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(channelQueue), "The default cancellation timeout should be set correctly.");
	}

	[TestMethod]
	public void Constructor_WithPositiveCapacity_DoesNotThrow()
	{
		// Arrange
		int positiveCapacity = 10;

		// Act & Assert
		var channelQueue = new ChannelQueue<int>(positiveCapacity);
		Assert.IsNotNull(channelQueue, "A positive capacity should not throw an exception.");
	}

	[TestMethod]
	public async Task Count_AfterAddingItems_CorrectCount()
	{
		var channel = new ChannelQueue<int>();
		await channel.WriteAsync(1);
		await channel.WriteAsync(2);
		Assert.AreEqual(2, channel.Count, "Count should reflect the number of items added.");
	}

	[TestMethod]
	public async Task Count_AfterReadingItems_Decreases()
	{
		var channel = new ChannelQueue<int>();
		await channel.WriteAsync(1);
		await channel.WriteAsync(2);
		_ = await channel.ReadAsync();
		Assert.AreEqual(1, channel.Count, "Count should decrease after reading an item.");
	}

	[TestMethod]
	public void Count_BoundedChannel_SupportsCount()
	{
		var channel = new ChannelQueue<int>(10);
		Assert.IsGreaterThanOrEqualTo(0, channel.Count, "Count should be supported and non-negative for a bounded channel.");
	}

	[TestMethod]
	public void Count_InitiallyZero()
	{
		var channel = new ChannelQueue<int>();
		Assert.AreEqual(0, channel.Count, "Count should be 0 for a new channel.");
	}

	[TestMethod]
	public void Count_UnboundedChannel_SupportsCount()
	{
		var channel = new ChannelQueue<int>();
		Assert.IsGreaterThanOrEqualTo(0, channel.Count, "Count should be supported and non-negative for an unbounded channel.");
	}

	[TestMethod]
	public void IsCompleted_ReturnsTrueAfterLock()
	{
		var queue = new ChannelQueue<int>();
		queue.Lock();
		Assert.IsTrue(queue.IsCompleted, "IsCompleted should be true after locking the channel.");
	}


	[TestMethod]
	public async Task ListenAsync_CompletesWhenChannelLocked()
	{
		var channel = new ChannelQueue<int>();
		var items = Enumerable.Range(1, 3).ToList();

		foreach (var item in items)
		{
			await channel.WriteAsync(item);
		}

		channel.Lock(); // Lock the channel to allow ListenAsync to complete.

		var readItems = new List<int>();
		await foreach (var item in channel.ListenAsync())
		{
			readItems.Add(item);
		}

		Assert.HasCount(items.Count, readItems, "ListenAsync should complete reading all items once the channel is locked.");
	}

	[TestMethod]
	public async Task ListenAsync_ReadsAllItems()
	{
		var channel = new ChannelQueue<int>();
		var items = Enumerable.Range(1, 5).ToList();

		foreach (var item in items)
		{
			await channel.WriteAsync(item);
		}

		channel.Lock(); // Ensure no more items can be added and ListenAsync can complete.

		var readItems = new List<int>();
		await foreach (var item in channel.ListenAsync())
		{
			readItems.Add(item);
		}

		CollectionAssert.AreEqual(items, readItems, "All items written to the channel should be read by ListenAsync.");
	}

	[TestMethod]
	public void Lock_AfterLockingChannelIsCompleted()
	{
		var channel = new ChannelQueue<int>();
		channel.Lock();

		var readerCompletion = channel.ListenAsync().GetAsyncEnumerator().MoveNextAsync();
		readerCompletion.AsTask().Wait(1000);

		Assert.IsTrue(readerCompletion.IsCompleted, "After locking, the channel should complete and no longer allow reads.");
	}

	[TestMethod]
	public void Lock_LocksChannelPreventingWrites()
	{
		var channel = new ChannelQueue<int>();
		Assert.IsTrue(channel.WriteAsync(1).Wait(1000), "Should be able to write to the channel initially.");

		var lockResult = channel.Lock();
		Assert.IsTrue(lockResult, "Lock should succeed on first call.");

		var writeTask = channel.WriteAsync(2);
		Assert.ThrowsExactly<AggregateException>(() => writeTask.Wait(1000), "Writing to a locked channel should throw an exception.");
	}

	[TestMethod]
	public void Lock_MultipleCallsReturnFalse()
	{
		var channel = new ChannelQueue<int>();
		Assert.IsTrue(channel.Lock(), "First call to Lock should succeed.");

		for (int i = 0; i < 5; i++)
		{
			Assert.IsFalse(channel.Lock(), $"Subsequent calls to Lock should return false. Failed at iteration {i}.");
		}
	}

	[TestMethod]
	public void Lock_PreventsFurtherAdditions()
	{
		var channel = new ChannelQueue<int>();
		channel.WriteAsync(1).Wait();
		channel.Lock();
		try
		{
			channel.WriteAsync(2).Wait();
		}
		catch (AggregateException ex) when (ex.InnerException is ChannelClosedException || ex.InnerException is InvalidOperationException)
		{
			// Expected exception
			return;
		}
		Assert.Fail("Expected a ChannelClosedException or InvalidOperationException to be thrown when writing to a locked channel.");
	}

	[TestMethod]
	public async Task ReadAsync_CancellationRequested_ThrowsOperationCanceledException()
	{
		// Arrange
		var channel = new ChannelQueue<int>();
		var cts = new CancellationTokenSource();

		// Simulate a scenario where cancellation is requested before the operation starts
		cts.Cancel();

		// Act & Assert
		try
		{
			await channel.ReadAsync(cts.Token);
			Assert.Fail("ReadAsync should throw a TaskCanceledException when cancellation is requested.");
		}
		catch (TaskCanceledException)
		{
			// Expected exception
		}
	}

	[TestMethod]
	public async Task ReadAsync_EmptyChannel_ThrowsChannelClosedException()
	{
		// Arrange
		var channel = new ChannelQueue<int>();
		channel.Lock(); // Ensure the channel is closed for writing and will not receive any items.

		// Act & Assert
		try
		{
			await channel.ReadAsync();
			Assert.Fail("Reading from an empty and locked channel should throw an InvalidOperationException.");
		}
		catch (InvalidOperationException)
		{
			// Expected exception
		}
	}


	[TestMethod]
	public async Task ReadAsync_WithItems_ReturnsCorrectItem()
	{
		var channel = new ChannelQueue<int>();
		await channel.WriteAsync(42);

		var result = await channel.ReadAsync();
		Assert.AreEqual(42, result, "ReadAsync should return the first item written to the channel.");
	}

	[TestMethod]
	public async Task ReadAsync_WithKeyResolver_RemovesKey()
	{
		var queue = new ChannelQueue<string>();
		var key = "k1";
		queue.TryWriteOnce("hello", key);
		var result = await queue.ReadAsync(s => key);
		Assert.AreEqual("hello", result, "ReadAsync with key resolver should return the correct item.");
		Assert.IsFalse(queue.Acknowledge(key), "Key should be removed after ReadAsync with key resolver.");
	}

	[TestMethod]
	public void TryPeek_AfterClear_ReturnsFalse()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		queue.TryWrite("item");
		queue.Clear();

		// Act
		var result = queue.TryPeek(out var item);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(item);
	}

	[TestMethod]
	public void TryPeek_AfterReadingAllItems_ReturnsFalse()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		queue.TryWrite("item");
		queue.TryRead(out _); // Remove the item

		// Act
		var result = queue.TryPeek(out var item);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(item);
	}

	[TestMethod]
	public void TryPeek_DoesNotAffectCount()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		queue.TryWrite("item1");
		queue.TryWrite("item2");
		var initialCount = queue.Count;

		// Act
		queue.TryPeek(out _);

		// Assert
		Assert.AreEqual(initialCount, queue.Count);
	}

	[TestMethod]
	public void TryPeek_EmptyQueue_ReturnsFalse()
	{
		// Arrange
		var queue = new ChannelQueue<string>();

		// Act
		var result = queue.TryPeek(out var item);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(item);
	}

	[TestMethod]
	public void TryPeek_ItemRemainsInQueue()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		queue.TryWrite("item1");

		// Act
		var peekResult = queue.TryPeek(out var peekedItem);

		// Assert - Item should still be readable
		Assert.IsTrue(peekResult);
		Assert.AreEqual(1, queue.Count);
		Assert.IsTrue(queue.TryRead(out var readItem));
		Assert.AreEqual(peekedItem, readItem);
	}

	[TestMethod]
	public void TryPeek_MultiplePeeks_SameItemAvailable()
	{
		// Arrange
		var queue = new ChannelQueue<int>();
		queue.TryWrite(42);

		// Act - Peek multiple times
		queue.TryPeek(out var item1);
		queue.TryPeek(out var item2);
		queue.TryPeek(out var item3);

		// Assert - Same item should be available each time
		Assert.AreEqual(42, item1);
		Assert.AreEqual(42, item2);
		Assert.AreEqual(42, item3);
		Assert.AreEqual(1, queue.Count);
	}

	[TestMethod]
	public void TryPeek_OnBoundedQueue_Works()
	{
		// Arrange
		var queue = new ChannelQueue<string>(capacity: 5);
		queue.TryWrite("bounded-item");

		// Act
		var result = queue.TryPeek(out var item);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual("bounded-item", item);
		Assert.AreEqual(1, queue.Count);
	}

	[TestMethod]
	public void TryPeek_OnLockedEmptyQueue_ReturnsFalse()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		queue.Lock();

		// Act
		var result = queue.TryPeek(out var _);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryPeek_WithComplexType_ReturnsCorrectItem()
	{
		// Arrange
		var queue = new ChannelQueue<Person>();
		var person = RandomData.GeneratePerson<Person>();
		queue.TryWrite(person);

		// Act
		var result = queue.TryPeek(out var peekedPerson);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(person.Id, peekedPerson.Id);
		Assert.AreEqual(person.Email, peekedPerson.Email);
	}

	[TestMethod]
	public void TryPeek_WithItem_ReturnsTrueAndItem()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		var expectedItem = "test-item";
		queue.TryWrite(expectedItem);

		// Act
		var result = queue.TryPeek(out var item);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(expectedItem, item);
	}

	[TestMethod]
	public void TryPeek_WithMultipleItems_ReturnsFirstItem()
	{
		// Arrange
		var queue = new ChannelQueue<string>();
		queue.TryWrite("first");
		queue.TryWrite("second");
		queue.TryWrite("third");

		// Act
		var result = queue.TryPeek(out var item);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual("first", item);
		Assert.AreEqual(3, queue.Count);
	}

	[TestMethod]
	public void TryPeek_WithValueType_ReturnsDefaultWhenEmpty()
	{
		// Arrange
		var queue = new ChannelQueue<int>();

		// Act
		var result = queue.TryPeek(out var item);

		// Assert
		Assert.IsFalse(result);
		Assert.AreEqual(default(int), item);
	}

	[TestMethod]
	public void TryRead_ReturnsFalseWhenEmpty()
	{
		var queue = new ChannelQueue<int>();
		Assert.IsFalse(queue.TryRead(out var _), "TryRead should return false when the channel is empty.");
	}

	[TestMethod]
	public void TryRead_ReturnsTrueWhenItemPresent()
	{
		var queue = new ChannelQueue<int>();
		queue.WriteAsync(42).Wait();
		Assert.IsTrue(queue.TryRead(out var value), "TryRead should return true when an item is present.");
		Assert.AreEqual(42, value, "TryRead should output the correct value.");
	}

	[TestMethod]
	public void TryWrite_BoundedQueue_ReturnsFalseWhenAtCapacity()
	{
		// Arrange - Create bounded queue with capacity 3
		var queue = new ChannelQueue<string>(capacity: 3);

		// Act - Try to write more items than capacity
		var result1 = queue.TryWrite("item1"); // true
		var result2 = queue.TryWrite("item2"); // true
		var result3 = queue.TryWrite("item3"); // true
		var result4 = queue.TryWrite("item4"); // false - at capacity

		// Assert
		Assert.IsTrue(result1);
		Assert.IsTrue(result2);
		Assert.IsTrue(result3);
		Assert.IsFalse(result4, "TryWrite should return false when bounded queue is at capacity");
		Assert.AreEqual(3, queue.Count);
	}

	[TestMethod]
	public void TryWrite_ReturnsTrueWhenPossible()
	{
		var queue = new ChannelQueue<int>();
		Assert.IsTrue(queue.TryWrite(99), "TryWrite should return true when the channel can accept the item.");
	}

	[TestMethod]
	public void TryWriteOnce_DuplicateKey_ReturnsFalse()
	{
		var queue = new ChannelQueue<int>();
		var key = "dup-key";
		Assert.IsTrue(queue.TryWriteOnce(1, key), "First TryWriteOnce should succeed.");
		Assert.IsFalse(queue.TryWriteOnce(2, key), "Second TryWriteOnce with same key should fail.");
	}

	[TestMethod]
	public void TryWriteOnce_ExpiredKey_AllowsRequeue()
	{
		var queue = new ChannelQueue<int>();
		var key = "expire-key";

		Assert.IsTrue(queue.TryWriteOnce(1, key, TimeSpan.FromMilliseconds(1)), "First TryWriteOnce should succeed.");

		Thread.Sleep(10);

		Assert.IsTrue(queue.TryWriteOnce(2, key, TimeSpan.FromMilliseconds(1)), "TryWriteOnce should succeed after key expires.");
	}

	[TestMethod]
	public async Task WriteAsync_AfterLock_ThrowsChannelClosedException()
	{
		// Arrange
		var channel = new ChannelQueue<int>();
		channel.Lock(); // Lock the channel to prevent further writes

		// Act & Assert
		try
		{
			await channel.WriteAsync(42);
			Assert.Fail("WriteAsync should throw an InvalidOperationException when attempting to write to a locked channel.");
		}
		catch (InvalidOperationException)
		{
			// Expected exception
		}
	}

	[TestMethod]
	public async Task WriteAsync_LockQueue_PreventsFurtherWrites()
	{
		// Arrange
		var channel = new ChannelQueue<int>();
		var items = Enumerable.Range(1, 5);

		await channel.WriteAsync(items, true);

		// Act & Assert
		try
		{
			await channel.WriteAsync(6);
			Assert.Fail("WriteAsync should throw an InvalidOperationException when attempting to write to a locked channel.");
		}
		catch (InvalidOperationException)
		{
			// Expected exception
		}
	}

	[TestMethod]
	public async Task WriteOnceAsync_DuplicateKey_ReturnsFalse()
	{
		var queue = new ChannelQueue<int>();
		var key = "async-key";
		Assert.IsTrue(await queue.WriteOnceAsync(1, key), "First WriteOnceAsync should succeed.");
		Assert.IsFalse(await queue.WriteOnceAsync(2, key), "Second WriteOnceAsync with same key should fail.");
	}

	[TestMethod]
	public async Task WriteOnceAsync_ExpiredKey_AllowsReenqueue()
	{
		var queue = new ChannelQueue<int>();
		var key = "async-expire-key";
		Assert.IsTrue(await queue.WriteOnceAsync(1, key, TimeSpan.FromMilliseconds(1)), "First WriteOnceAsync should succeed.");
		await Task.Delay(10);
		Assert.IsTrue(await queue.WriteOnceAsync(2, key, TimeSpan.FromMilliseconds(1)), "WriteOnceAsync should succeed after key expires.");
	}

}
