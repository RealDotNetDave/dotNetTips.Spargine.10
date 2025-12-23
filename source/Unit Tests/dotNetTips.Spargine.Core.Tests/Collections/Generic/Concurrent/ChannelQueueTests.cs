// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-26-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="ChannelQueueTests.cs" company="McCarter Consulting">
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

		queue.TryWriteOnce(1, key);

		Assert.IsTrue(queue.Acknowledge(key), "Acknowledge should remove the key and return true.");
		Assert.IsFalse(queue.Acknowledge(key), "Acknowledge should return false for a non-existent key.");
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
		Assert.IsTrue(channel.Count > 0, "Channel should allow adding many items, indicating it's unbounded.");
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
		Assert.IsTrue(channel.Count >= 0, "Count should be supported and non-negative for a bounded channel.");
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
		Assert.IsTrue(channel.Count >= 0, "Count should be supported and non-negative for an unbounded channel.");
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

		Assert.AreEqual(items.Count, readItems.Count, "ListenAsync should complete reading all items once the channel is locked.");
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
