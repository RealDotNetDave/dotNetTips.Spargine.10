// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-28-2026
// ***********************************************************************
// <copyright file="InMemoryCacheTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Cache;

[ExcludeFromCodeCoverage]
[TestClass]
public class InMemoryCacheTests
{

	[TestMethod]
	public void AddCacheItem_AddsAndRetrievesItem()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var person = RandomData.GeneratePerson<Person>();

		// Act
		cache.AddCacheItem(key, person);
		var cached = cache.GetCacheItem<Person>(key);

		// Assert
		Assert.AreEqual(person, cached);
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItem_EmptyKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem(string.Empty, RandomData.GeneratePerson<Person>()));
	}

	[TestMethod]
	public void AddCacheItem_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem<string>("testKey", null));
	}

	[TestMethod]
	public void AddCacheItem_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem(null, RandomData.GeneratePerson<Person>()));
	}

	[TestMethod]
	public void AddCacheItem_WithCustomExpiration_AddsAndRetrievesItem()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "value";
		var expiration = DateTimeOffset.Now.AddMinutes(5);
		cache.AddCacheItem(key, value, expiration);

		var cached = cache.GetCacheItem<string>(key);
		Assert.AreEqual(value, cached);

		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItem_WithCustomExpirationDateTime_EmptyKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem(string.Empty, RandomData.GeneratePerson<Person>(), futureDate));
	}

	[TestMethod]
	public void AddCacheItem_WithCustomExpirationDateTime_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem<string>("testKey", null, futureDate));
	}

	[TestMethod]
	public void AddCacheItem_WithCustomExpirationDateTime_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem(null, RandomData.GeneratePerson<Person>(), futureDate));
	}

	[TestMethod]
	public void AddCacheItem_WithCustomTimeout_AddsAndRetrievesItem()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "value";
		cache.AddCacheItem(key, value, TimeSpan.FromMinutes(5));

		var cached = cache.GetCacheItem<string>(key);
		Assert.AreEqual(value, cached);

		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItem_WithCustomTimeout_EmptyKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem(string.Empty, RandomData.GeneratePerson<Person>(), TimeSpan.FromMinutes(30)));
	}

	[TestMethod]
	public void AddCacheItem_WithCustomTimeout_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem<string>("testKey", null, TimeSpan.FromMinutes(30)));
	}

	[TestMethod]
	public void AddCacheItem_WithCustomTimeout_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.AddCacheItem(null, RandomData.GeneratePerson<Person>(), TimeSpan.FromMinutes(30)));
	}

	[TestMethod]
	public async Task AddCacheItemAsync_AddsAndRetrievesItem()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "value";
		await cache.AddCacheItemAsync(key, value);

		var cached = await cache.GetCacheItemAsync<string>(key);
		Assert.AreEqual(value, cached);

		cache.Clear();
	}


	[TestMethod]
	public async Task AddCacheItemAsync_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.AddCacheItemAsync<string>("testKey", null));
	}

	[TestMethod]
	public async Task AddCacheItemAsync_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.AddCacheItemAsync(null, RandomData.GeneratePerson<Person>()));
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomExpiration_AddsAndRetrievesItem()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "value";
		var expiration = DateTimeOffset.Now.AddMinutes(5);
		await cache.AddCacheItemAsync(key, value, expiration);

		var cached = await cache.GetCacheItemAsync<string>(key);
		Assert.AreEqual(value, cached);

		cache.Clear();
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomExpirationDateTime_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.AddCacheItemAsync<string>("testKey", null, futureDate));
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomExpirationDateTime_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.AddCacheItemAsync(null, RandomData.GeneratePerson<Person>(), futureDate));
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomTimeout_AddsAndRetrievesItem()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "value";
		await cache.AddCacheItemAsync(key, value, TimeSpan.FromMinutes(5));

		var cached = await cache.GetCacheItemAsync<string>(key);
		Assert.AreEqual(value, cached);

		cache.Clear();
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomTimeout_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.AddCacheItemAsync<string>("testKey", null, TimeSpan.FromMinutes(30)));
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCustomTimeout_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.AddCacheItemAsync(null, RandomData.GeneratePerson<Person>(), TimeSpan.FromMinutes(30)));
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithDateTimeOffsetAndCancellationToken_AddsAndRetrievesItem()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "value";
		var expiration = DateTimeOffset.Now.AddMinutes(1);
		using var cts = new CancellationTokenSource();
		await cache.AddCacheItemAsync(key, value, expiration, cts.Token);

		var cached = await cache.GetCacheItemAsync<string>(key, cts.Token);
		Assert.AreEqual(value, cached);

		cache.Clear();
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithTimeoutAndCancellationToken_AddsAndRetrievesItem()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "value";
		using var cts = new CancellationTokenSource();
		await cache.AddCacheItemAsync(key, value, TimeSpan.FromMinutes(1), cts.Token);

		var cached = await cache.GetCacheItemAsync<string>(key, cts.Token);
		Assert.AreEqual(value, cached);

		cache.Clear();
	}

	[TestMethod]
	public async Task AddCacheItemAsync_WithCancelledToken_ThrowsTaskCanceledExceptionAndDoesNotAdd()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		await Assert.ThrowsExactlyAsync<TaskCanceledException>(() => cache.AddCacheItemAsync(key, "value", cts.Token));
		Assert.IsNull(cache.GetCacheItem<string>(key));

		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemBatch_AddsMultipleItems()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var people = RandomData.GeneratePersonRefCollection(3);
		var items = people.ToDictionary(p => p.Id, p => p);

		// Act
		cache.AddCacheItemBatch(items);

		// Assert
		foreach (var kvp in items)
		{
			var cached = cache.GetCacheItem<Person>(kvp.Key);
			Assert.AreEqual(kvp.Value, cached);
		}
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemBatch_EmptyDictionary_DoesNotThrow()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var items = new Dictionary<string, string>();

		// Act
		cache.AddCacheItemBatch(items);

		// Assert
		Assert.AreEqual(0, InMemoryCache.Count);
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemBatch_NullItems_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemBatch<Person>(null));
	}

	[TestMethod]
	public void AddCacheItemWithCallback_InvokesCallbackOnEviction()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var person = RandomData.GeneratePerson<Person>();
		var callbackInvoked = false;
		object evictedKey = null;
		using var callbackSignal = new ManualResetEventSlim(false);

		void Callback(object k, object v, EvictionReason reason, object state)
		{
			callbackInvoked = true;
			evictedKey = k;
			callbackSignal.Set();
		}

		// Act
		cache.AddCacheItemWithCallback(person.Id, person, TimeSpan.FromMilliseconds(50), Callback);

		// Wait for the item to expire
		Thread.Sleep(100);

		// Force eviction by trying to access the item or compacting
		_ = cache.GetCacheItem<Person>(person.Id); // This will trigger eviction check

		// Alternative: Force compaction to trigger eviction
		cache.Cache.Compact(0.0); // 0% compaction just triggers scan for expired items

		// Wait for the callback with timeout
		var signaled = callbackSignal.Wait(TimeSpan.FromSeconds(2));

		// Assert
		Assert.IsTrue(signaled, "Callback signal timeout - callback was not invoked within 2 seconds.");
		Assert.IsTrue(callbackInvoked, "Callback should have been invoked.");
		Assert.AreEqual(person.Id, evictedKey);
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemWithCallback_NullCallback_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithCallback(person.Id, person, TimeSpan.FromMinutes(1), null));
	}

	[TestMethod]
	public void AddCacheItemWithCallback_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		void Callback(object k, object v, EvictionReason reason, object state)
		{ }

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithCallback<Person>("key", null, TimeSpan.FromMinutes(1), Callback));
	}

	[TestMethod]
	public void AddCacheItemWithCallback_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();
		void Callback(object k, object v, EvictionReason reason, object state)
		{ }

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithCallback(null, person, TimeSpan.FromMinutes(1), Callback));
	}

	[TestMethod]
	public void AddCacheItemWithChangeToken_InvalidatesOnTokenSignal()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var person = RandomData.GeneratePerson<Person>();
		using var cts = new CancellationTokenSource();
		var changeToken = new Microsoft.Extensions.Primitives.CancellationChangeToken(cts.Token);

		// Act
		cache.AddCacheItemWithChangeToken(person.Id, person, TimeSpan.FromMinutes(10), changeToken);
		Assert.IsNotNull(cache.GetCacheItem<Person>(person.Id));

		cts.Cancel(); // Signal the token
		Thread.Sleep(50); // Give time for invalidation

		// Assert
		Assert.IsNull(cache.GetCacheItem<Person>(person.Id), "Item should be removed when change token is signaled.");
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemWithChangeToken_NullChangeToken_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithChangeToken(person.Id, person, TimeSpan.FromMinutes(1), null));
	}

	[TestMethod]
	public void AddCacheItemWithChangeToken_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		using var cts = new CancellationTokenSource();
		var changeToken = new Microsoft.Extensions.Primitives.CancellationChangeToken(cts.Token);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithChangeToken<Person>("key", null, TimeSpan.FromMinutes(1), changeToken));
	}

	[TestMethod]
	public void AddCacheItemWithChangeToken_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();
		using var cts = new CancellationTokenSource();
		var changeToken = new Microsoft.Extensions.Primitives.CancellationChangeToken(cts.Token);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithChangeToken(null, person, TimeSpan.FromMinutes(1), changeToken));
	}

	[TestMethod]
	public void AddCacheItemWithCombinedExpiration_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithCombinedExpiration<Person>("key", null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10)));
	}

	[TestMethod]
	public void AddCacheItemWithCombinedExpiration_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithCombinedExpiration(null, person, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10)));
	}

	[TestMethod]
	public void AddCacheItemWithCombinedExpiration_UsesBothExpirations()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var person = RandomData.GeneratePerson<Person>();

		// Act
		cache.AddCacheItemWithCombinedExpiration(person.Id, person, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10));

		// Assert - Item should exist immediately
		Assert.IsNotNull(cache.GetCacheItem<Person>(person.Id));
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemWithDependency_InvalidatesWhenDependencyCancelled()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var people = RandomData.GeneratePersonRefCollection(2).ToList();
		using var cts = new CancellationTokenSource();

		// Act
		cache.AddCacheItemWithDependency(people[0].Id, people[0], TimeSpan.FromMinutes(10), cts);
		cache.AddCacheItemWithDependency(people[1].Id, people[1], TimeSpan.FromMinutes(10), cts);

		Assert.IsNotNull(cache.GetCacheItem<Person>(people[0].Id));
		Assert.IsNotNull(cache.GetCacheItem<Person>(people[1].Id));

		cts.Cancel();
		Thread.Sleep(50);

		// Assert
		Assert.IsNull(cache.GetCacheItem<Person>(people[0].Id));
		Assert.IsNull(cache.GetCacheItem<Person>(people[1].Id));
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemWithDependency_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		using var cts = new CancellationTokenSource();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithDependency<Person>("key", null, TimeSpan.FromMinutes(1), cts));
	}

	[TestMethod]
	public void AddCacheItemWithDependency_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();
		using var cts = new CancellationTokenSource();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithDependency(null, person, TimeSpan.FromMinutes(1), cts));
	}

	[TestMethod]
	public void AddCacheItemWithDependency_NullTokenSource_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithDependency(person.Id, person, TimeSpan.FromMinutes(1), null));
	}

	[TestMethod]
	public void AddCacheItemWithPriority_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithPriority<Person>("key", null, TimeSpan.FromMinutes(1), CacheItemPriority.High));
	}

	[TestMethod]
	public void AddCacheItemWithPriority_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithPriority(null, person, TimeSpan.FromMinutes(1), CacheItemPriority.High));
	}

	[TestMethod]
	public void AddCacheItemWithPriority_SetsCorrectPriority()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var person = RandomData.GeneratePerson<Person>();

		// Act
		cache.AddCacheItemWithPriority(person.Id, person, TimeSpan.FromMinutes(10), CacheItemPriority.High);

		// Assert
		Assert.IsNotNull(cache.GetCacheItem<Person>(person.Id));
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemWithSize_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithSize<Person>("key", null, TimeSpan.FromMinutes(1), 100));
	}

	[TestMethod]
	public void AddCacheItemWithSize_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithSize(null, person, TimeSpan.FromMinutes(1), 100));
	}

	[TestMethod]
	public void AddCacheItemWithSize_SetsCorrectSize()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var person = RandomData.GeneratePerson<Person>();

		// Act
		cache.AddCacheItemWithSize(person.Id, person, TimeSpan.FromMinutes(10), 100);

		// Assert
		Assert.IsNotNull(cache.GetCacheItem<Person>(person.Id));
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemWithSlidingExpiration_ItemExpiresAfterInactivity()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var person = RandomData.GeneratePerson<Person>();

		// Act
		cache.AddCacheItemWithSlidingExpiration(person.Id, person, TimeSpan.FromMilliseconds(100));
		Thread.Sleep(150); // Wait for expiration

		// Assert
		Assert.IsNull(cache.GetCacheItem<Person>(person.Id), "Item should expire after sliding expiration period.");
		cache.Clear();
	}

	[TestMethod]
	public void AddCacheItemWithSlidingExpiration_NullItem_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithSlidingExpiration<Person>("key", null, TimeSpan.FromMinutes(1)));
	}

	[TestMethod]
	public void AddCacheItemWithSlidingExpiration_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.AddCacheItemWithSlidingExpiration(null, person, TimeSpan.FromMinutes(1)));
	}

	[TestMethod]
	public void CacheProperty_CanAddAndRetrieveItem()
	{
		var cacheInstance = InMemoryCache.Instance;
		var testKey = "testKey";
		var testValue = "testValue";

		cacheInstance.Cache.Set(testKey, testValue, DateTimeOffset.Now.AddMinutes(5));
		var result = cacheInstance.Cache.Get<string>(testKey);

		Assert.AreEqual(testValue, result, "Should be able to add and retrieve an item using the Cache property.");

		cacheInstance.Clear(); // Cleanup after test
	}

	[TestMethod]
	public void CacheProperty_CanClearItems()
	{
		var cacheInstance = InMemoryCache.Instance;
		var testKey = "testKey";
		var testValue = "testValue";

		_ = cacheInstance.Cache.Set(testKey, testValue, DateTimeOffset.Now.AddMinutes(5));
		cacheInstance.Clear(); // Clearing the cache

		var result = cacheInstance.Cache.Get<string>(testKey);
		Assert.IsNull(result, "Cache should be empty after calling Clear method.");
	}

	[TestMethod]
	public void CacheProperty_IsNotNull()
	{
		var cacheInstance = InMemoryCache.Instance;
		Assert.IsNotNull(cacheInstance.Cache, "Cache property should not be null.");
	}

	[TestMethod]
	public void Compact_InvalidPercentage_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => cache.Compact(1.5));
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => cache.Compact(-0.1));
	}

	[TestMethod]
	public void Compact_ValidPercentage_CompactsCache()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var people = RandomData.GeneratePersonRefCollection(5);
		foreach (var person in people)
		{
			cache.AddCacheItem(person.Id, person);
		}

		// Act
		cache.Compact(0.5);

		// Assert - Cache should still be operational
		Assert.IsNotNull(cache);
		cache.Clear();
	}

	[TestMethod]
	public void Compact_ZeroPercentage_DoesNotRemoveItems()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		cache.AddCacheItem("key1", "value1");
		cache.AddCacheItem("key2", "value2");

		// Act
		cache.Compact(0.0);

		// Assert - All items should remain
		Assert.AreEqual(2, InMemoryCache.Count);
		cache.Clear();
	}

	[TestMethod]
	public void Compact_FullPercentage_RemovesAllItems()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		cache.AddCacheItem("key1", "value1");
		cache.AddCacheItem("key2", "value2");

		// Act
		cache.Compact(1.0);

		// Assert - All items should be removed
		Assert.AreEqual(0, InMemoryCache.Count);
	}

	[TestMethod]
	public void ContainsKey_InvalidKey_ReturnsFalse()
	{
		var cache = InMemoryCache.Instance;
		var contains = cache.ContainsKey("invalidKey");

		Assert.IsFalse(contains, "Cache should not contain an item with an invalid key.");
	}

	[TestMethod]
	public void ContainsKey_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.ContainsKey(null));
	}

	[TestMethod]
	public void ContainsKey_ValidKey_ReturnsTrue()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();
		cache.AddCacheItem(person.Id, person);

		var contains = cache.ContainsKey(person.Id);

		Assert.IsTrue(contains, "Cache should contain the item with the specified key.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public void Count_DecreasesAfterClear()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear(); // Reset cache before test

		cache.AddCacheItem("testKey1", "testValue1");
		cache.AddCacheItem("testKey2", "testValue2");
		cache.Clear(); // Clear cache after adding items

		Assert.AreEqual(0, InMemoryCache.Count, "Cache count should be 0 after clearing the cache.");
	}

	[TestMethod]
	public void Count_IncreasesWithAddedItems()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear(); // Reset cache before test

		cache.AddCacheItem("testKey1", "testValue1");
		cache.AddCacheItem("testKey2", "testValue2");

		Assert.AreEqual(2, InMemoryCache.Count, "Cache count should increase as items are added.");
	}

	[TestMethod]
	public void Count_InitiallyZero()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear(); // Ensure cache is empty before test
		Assert.AreEqual(0, InMemoryCache.Count, "Cache count should be 0 initially.");
	}

	[TestMethod]
	public void Count_ReturnsCorrectValue()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		Assert.AreEqual(0, InMemoryCache.Count);
		cache.AddCacheItem("k1", "v1");
		Assert.AreEqual(1, InMemoryCache.Count);
		cache.AddCacheItem("k2", "v2");
		Assert.AreEqual(2, InMemoryCache.Count);
		cache.Clear();
		Assert.AreEqual(0, InMemoryCache.Count);
	}

	[TestMethod]
	public void CreateCacheDependency_CreatesAndStoresTokenSource()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var dependencyKey = Guid.NewGuid().ToString();

		// Act
		var cts = cache.CreateCacheDependency(dependencyKey);

		// Assert
		Assert.IsNotNull(cts);
		Assert.IsTrue(cache.ContainsKey(dependencyKey));
		cache.Clear();
	}

	[TestMethod]
	public void CreateCacheDependency_EmptyKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.CreateCacheDependency(string.Empty));
	}

	[TestMethod]
	public void CreateCacheDependency_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.CreateCacheDependency(null));
	}

	[TestMethod]
	public void CreateCacheWithLimit_NoLimit_CreatesCache()
	{
		// Arrange & Act
		using var cache = InMemoryCache.CreateCacheWithLimit();

		// Assert
		Assert.IsNotNull(cache);
	}

	[TestMethod]
	public void CreateCacheWithLimit_WithLimit_CreatesCacheWithSizeLimit()
	{
		// Arrange & Act
		using var cache = InMemoryCache.CreateCacheWithLimit(100);

		// Assert
		Assert.IsNotNull(cache);
	}

	[TestMethod]
	public void CreateInstanceTest()
	{
		var result = InMemoryCache.Instance;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetAllKeys_EmptyCache_ReturnsEmpty()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var keys = cache.GetAllKeys().ToList();
		Assert.IsEmpty(keys);
	}

	[TestMethod]
	public void GetAllKeys_ReturnsAllKeys()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key1 = Guid.NewGuid().ToString();
		var key2 = Guid.NewGuid().ToString();
		cache.AddCacheItem(key1, "v1");
		cache.AddCacheItem(key2, "v2");
		var keys = cache.GetAllKeys().ToList();
		Assert.Contains(key1, keys);
		Assert.Contains(key2, keys);
		cache.Clear();
	}


	[TestMethod]
	public void GetAllKeys_ReturnsEmptyWhenCacheIsEmpty()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var keys = cache.GetAllKeys().ToList();
		Assert.IsEmpty(keys);
	}

	[TestMethod]
	public void GetCacheItem_EmptyKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.GetCacheItem<Person>(string.Empty));
	}

	[TestMethod]
	public void GetCacheItem_ExistingKey_ReturnsItem()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var person = RandomData.GeneratePerson<Person>();
		cache.AddCacheItem(key, person);

		// Act
		var result = cache.GetCacheItem<Person>(key);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(person, result);
		cache.Clear();
	}

	[TestMethod]
	public void GetCacheItem_InvalidKey_ReturnsNull()
	{
		var cache = InMemoryCache.Instance;
		var result = cache.GetCacheItem<Person>("invalidKey");

		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetCacheItem_MissingKey_ReturnsNull()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var result = cache.GetCacheItem<string>("notfound");
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetCacheItem_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.GetCacheItem<Person>(null));
	}

	[TestMethod]
	public async Task GetCacheItemAsync_InvalidKey_ReturnsNull()
	{
		var cache = InMemoryCache.Instance;
		var result = await cache.GetCacheItemAsync<Person>("invalidKey");

		Assert.IsNull(result);
	}

	[TestMethod]
	public async Task GetCacheItemAsync_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.GetCacheItemAsync<Person>(null));
	}

	[TestMethod]
	public async Task GetCacheItemAsync_WithCancellationToken_ReturnsValue()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "value";
		cache.AddCacheItem(key, value);
		using var cts = new CancellationTokenSource();

		var cached = await cache.GetCacheItemAsync<string>(key, cts.Token);
		Assert.AreEqual(value, cached);

		cache.Clear();
	}

	[TestMethod]
	public async Task GetCacheItemAsync_WithCancelledToken_ThrowsTaskCanceledException()
	{
		var cache = InMemoryCache.Instance;
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		await Assert.ThrowsExactlyAsync<TaskCanceledException>(() => cache.GetCacheItemAsync<string>(Guid.NewGuid().ToString(), cts.Token));
	}

	[TestMethod]
	public void GetCacheItemBatch_EmptyKeys_ReturnsEmptyDictionary()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();

		// Act
		var result = cache.GetCacheItemBatch<Person>(Enumerable.Empty<string>());

		// Assert
		Assert.IsEmpty(result);
		cache.Clear();
	}

	[TestMethod]
	public void GetCacheItemBatch_NullKeys_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.GetCacheItemBatch<Person>(null));
	}

	[TestMethod]
	public void GetCacheItemBatch_ReturnsMultipleItems()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var people = RandomData.GeneratePersonRefCollection(3).ToList();
		foreach (var person in people)
		{
			cache.AddCacheItem(person.Id, person);
		}

		// Act
		var keys = people.Select(p => p.Id).Concat(new[] { Guid.NewGuid().ToString() });
		var result = cache.GetCacheItemBatch<Person>(keys);

		// Assert
		Assert.HasCount(3, result);
		foreach (var person in people)
		{
			Assert.IsTrue(result.ContainsKey(person.Id));
			Assert.AreEqual(person, result[person.Id]);
		}
		cache.Clear();
	}

	[TestMethod]
	public void GetCacheStatistics_ReturnsCorrectMetrics()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		cache.ResetStatistics();
		var person = RandomData.GeneratePerson<Person>();

		// Act
		cache.AddCacheItem(person.Id, person);
		_ = cache.GetCacheItem<Person>(person.Id); // Hit
		_ = cache.GetCacheItem<Person>(Guid.NewGuid().ToString()); // Miss

		var stats = cache.GetCacheStatistics();

		// Assert
		Assert.AreEqual(1, stats.TotalItems);
		Assert.AreEqual(1, stats.CacheHits);
		Assert.AreEqual(1, stats.CacheMisses);
		Assert.AreEqual(0.5, stats.HitRatio, 0.01);
		cache.Clear();
	}

	[TestMethod]
	public async Task GetOrCreateAsync_AbsoluteExpiration_StoresCorrectly()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var expiration = DateTimeOffset.UtcNow.AddMinutes(1);

		var value = await cache.GetOrCreateAsync(key, _ => Task.FromResult("abc"), expiration);

		Assert.AreEqual("abc", value);
		Assert.AreEqual("abc", cache.GetCacheItem<string>(key));
		cache.Clear();
	}

	[TestMethod]
	public async Task GetOrCreateAsync_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.GetOrCreateAsync<string>(null, _ => Task.FromResult("x")));
	}

	[TestMethod]
	public async Task GetOrCreateAsync_NullFactory_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.GetOrCreateAsync<string>(key, null));
		cache.Clear();
	}

	[TestMethod]
	public async Task GetOrCreateAsync_AbsoluteExpiration_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		var expiration = DateTimeOffset.UtcNow.AddMinutes(1);

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.GetOrCreateAsync<string>(null, _ => Task.FromResult("x"), expiration));
	}

	[TestMethod]
	public async Task GetOrCreateAsync_AbsoluteExpiration_NullFactory_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var expiration = DateTimeOffset.UtcNow.AddMinutes(1);

		// Act & Assert
		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() =>
			cache.GetOrCreateAsync<string>(key, null, expiration));
		cache.Clear();
	}

	[TestMethod]
	public async Task GetOrCreateAsync_FactoryThrows_ClearsSingleFlightSlot()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var callCount = 0;

		// Act - First call with factory that throws
		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(() =>
			cache.GetOrCreateAsync<string>(key, _ =>
			{
				callCount++;
				throw new InvalidOperationException("Factory failed");
			}));

		// Second call should invoke the factory again (single-flight slot was cleaned up)
		var result = await cache.GetOrCreateAsync(key, _ =>
		{
			callCount++;
			return Task.FromResult("success");
		});

		// Assert
		Assert.AreEqual("success", result);
		Assert.AreEqual(2, callCount, "Factory should be called twice - once for the failure and once for the retry.");
		cache.Clear();
	}

	[TestMethod]
	public async Task GetOrCreateAsync_SingleFlight_OnlyOneFactoryRuns()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		int factoryCallCount = 0;

		async Task<string> Factory(CancellationToken ct)
		{
			Interlocked.Increment(ref factoryCallCount);
			await Task.Delay(100, ct);
			return "value";
		}

		var tasks = Enumerable.Range(0, 5)
			.Select(_ => cache.GetOrCreateAsync(key, Factory))
			.ToArray();

		var results = await Task.WhenAll(tasks);

		Assert.IsTrue(results.All(r => r == "value"));
		Assert.AreEqual(1, factoryCallCount, "Factory should only be called once due to single-flight.");
		cache.Clear();
	}

	[TestMethod]
	public async Task GetOrCreateAsync_WithTimeoutAndCancellationToken_CachesValue()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var timeout = TimeSpan.FromMinutes(1);
		using var cts = new CancellationTokenSource();
		int callCount = 0;
		async Task<string> Factory(CancellationToken ct)
		{
			callCount++;
			await Task.Delay(10, ct);
			return "created";
		}

		var value = await cache.GetOrCreateAsync(key, Factory, timeout, cts.Token);

		//Get item again to hit cache
		value = await cache.GetOrCreateAsync(key, Factory, timeout, cts.Token);


		Assert.AreEqual("created", value);
		Assert.AreEqual("created", cache.GetCacheItem<string>(key));
		Assert.AreEqual(1, callCount);

		cache.Clear();
	}

	[TestMethod]
	public void Instance_AlwaysReturnsSameObject()
	{
		var instance1 = InMemoryCache.Instance;
		var instance2 = InMemoryCache.Instance;

		Assert.AreSame(instance1, instance2, "Multiple calls to InMemoryCache.Instance should return the same object instance.");
	}

	[TestMethod]
	public void InvalidateDependentCacheItems_EmptyKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.InvalidateDependentCacheItems(string.Empty));
	}

	[TestMethod]
	public void InvalidateDependentCacheItems_InvalidatesAllDependentItems()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var dependencyKey = Guid.NewGuid().ToString();
		var cts = cache.CreateCacheDependency(dependencyKey);
		var people = RandomData.GeneratePersonRefCollection(2).ToList();

		foreach (var person in people)
		{
			cache.AddCacheItemWithDependency(person.Id, person, TimeSpan.FromMinutes(10), cts);
		}

		// Act
		var result = cache.InvalidateDependentCacheItems(dependencyKey);
		Thread.Sleep(50);

		// Assert
		Assert.IsTrue(result);
		foreach (var person in people)
		{
			Assert.IsNull(cache.GetCacheItem<Person>(person.Id));
		}
		cache.Clear();
	}

	[TestMethod]
	public void InvalidateDependentCacheItems_InvalidKey_ReturnsFalse()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();

		// Act
		var result = cache.InvalidateDependentCacheItems(Guid.NewGuid().ToString());

		// Assert
		Assert.IsFalse(result);
		cache.Clear();
	}

	[TestMethod]
	public void InvalidateDependentCacheItems_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.InvalidateDependentCacheItems(null));
	}

	[TestMethod]
	public void PeekCacheItem_AfterItemRemoved_ReturnsFalse()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		cache.AddCacheItem(key, "test value");

		// Verify item exists
		var existsBefore = cache.PeekCacheItem<string>(key, out _);
		Assert.IsTrue(existsBefore);

		// Remove item
		cache.RemoveCacheItem(key);

		// Act
		var result = cache.PeekCacheItem<string>(key, out var value);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(value);

		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_DoesNotAffectStatistics()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		cache.ResetStatistics();
		var person = RandomData.GeneratePerson<Person>();
		cache.AddCacheItem(person.Id, person);

		// Act
		var found = cache.PeekCacheItem<Person>(person.Id, out var value);
		var stats = cache.GetCacheStatistics();

		// Assert
		Assert.IsTrue(found);
		Assert.AreEqual(person, value);
		Assert.AreEqual(0, stats.CacheHits, "Peek should not increment hit count.");
		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_DoesNotUpdateStatistics()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		cache.ResetStatistics();
		var key = Guid.NewGuid().ToString();
		cache.AddCacheItem(key, "test value");

		var statsBefore = cache.GetCacheStatistics();
		var hitsBefore = statsBefore.CacheHits;
		var missesBefore = statsBefore.CacheMisses;

		// Act
		_ = cache.PeekCacheItem<string>(key, out _);
		_ = cache.PeekCacheItem<string>("non-existent-key", out _);

		// Assert - Statistics should remain unchanged
		var statsAfter = cache.GetCacheStatistics();
		Assert.AreEqual(hitsBefore, statsAfter.CacheHits);
		Assert.AreEqual(missesBefore, statsAfter.CacheMisses);

		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_EmptyKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.PeekCacheItem<string>(string.Empty, out _));
	}

	[TestMethod]
	public void PeekCacheItem_ExistingItem_ReturnsTrueAndValue()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var expectedValue = "test value";
		cache.AddCacheItem(key, expectedValue);

		// Act
		var result = cache.PeekCacheItem<string>(key, out var value);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(expectedValue, value);

		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_MultipleCalls_ReturnsConsistentResults()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var expectedValue = "consistent value";
		cache.AddCacheItem(key, expectedValue);

		// Act & Assert - Multiple peeks should return same result
		for (var i = 0; i < 5; i++)
		{
			var result = cache.PeekCacheItem<string>(key, out var value);
			Assert.IsTrue(result);
			Assert.AreEqual(expectedValue, value);
		}

		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_NonExistingItem_ReturnsFalseAndDefault()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();

		// Act
		var result = cache.PeekCacheItem<string>(key, out var value);

		// Assert
		Assert.IsFalse(result);
		Assert.IsNull(value);

		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.PeekCacheItem<string>(null, out _));
	}

	[TestMethod]
	public void PeekCacheItem_TypeMismatch_ReturnsFalseAndDefault()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		cache.AddCacheItem(key, "string value");

		// Act - Try to retrieve as int when it's a string
		var result = cache.PeekCacheItem<int>(key, out var value);

		// Assert
		Assert.IsFalse(result);
		Assert.AreEqual(default(int), value);

		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_WithNullableValueType_ReturnsTrueAndValue()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		int? expectedValue = 100;
		cache.AddCacheItem(key, expectedValue);

		// Act
		var result = cache.PeekCacheItem<int?>(key, out var value);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(expectedValue, value);

		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_WithReferenceType_ReturnsTrueAndValue()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var expectedValue = RandomData.GeneratePerson<Person>();
		cache.AddCacheItem(key, expectedValue);

		// Act
		var result = cache.PeekCacheItem<Person>(key, out var value);

		// Assert
		Assert.IsTrue(result);
		Assert.IsNotNull(value);
		Assert.AreEqual(expectedValue.Id, value.Id);
		Assert.AreEqual(expectedValue.Email, value.Email);

		cache.Clear();
	}

	[TestMethod]
	public void PeekCacheItem_WithValueType_ReturnsTrueAndValue()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var expectedValue = 42;
		cache.AddCacheItem(key, expectedValue);

		// Act
		var result = cache.PeekCacheItem<int>(key, out var value);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(expectedValue, value);

		cache.Clear();
	}

	[TestMethod]
	public void RefreshCacheItem_EmptyKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.RefreshCacheItem(string.Empty, TimeSpan.FromMinutes(1)));
	}

	[TestMethod]
	public void RefreshCacheItem_InvalidKey_ReturnsFalse()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();

		// Act
		var result = cache.RefreshCacheItem(Guid.NewGuid().ToString(), TimeSpan.FromMinutes(1));

		// Assert
		Assert.IsFalse(result);
		cache.Clear();
	}

	[TestMethod]
	public void RefreshCacheItem_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.RefreshCacheItem(null, TimeSpan.FromMinutes(1)));
	}

	[TestMethod]
	public void RefreshCacheItem_UpdatesExpiration()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var person = RandomData.GeneratePerson<Person>();
		cache.AddCacheItem(person.Id, person, TimeSpan.FromMilliseconds(100));

		// Act
		var refreshed = cache.RefreshCacheItem(person.Id, TimeSpan.FromMinutes(10));

		// Assert
		Assert.IsTrue(refreshed);
		Thread.Sleep(150);
		Assert.IsNotNull(cache.GetCacheItem<Person>(person.Id), "Item should still exist after refresh.");
		cache.Clear();
	}

	[TestMethod]
	public void RemoveCacheItem_InvalidKey_ReturnsFalse()
	{
		var cache = InMemoryCache.Instance;
		var removed = cache.RemoveCacheItem("invalidKey");

		Assert.IsFalse(removed, "Removing an item with an invalid key should return false.");
	}

	[TestMethod]
	public void RemoveCacheItem_ItemNotFound_ReturnsFalse()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var removed = cache.RemoveCacheItem("notfound");
		Assert.IsFalse(removed);
	}

	[TestMethod]
	public void RemoveCacheItem_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.RemoveCacheItem(null));
	}

	[TestMethod]
	public void RemoveCacheItem_RemovesItem()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		cache.AddCacheItem(key, "value");
		var removed = cache.RemoveCacheItem(key);
		Assert.IsTrue(removed);
		Assert.IsNull(cache.GetCacheItem<string>(key));
	}

	[TestMethod]
	public void RemoveCacheItem_ValidKey_ItemRemoved()
	{
		var cache = InMemoryCache.Instance;
		var person = RandomData.GeneratePerson<Person>();
		cache.AddCacheItem(person.Id, person);

		var removed = cache.RemoveCacheItem(person.Id);

		Assert.IsTrue(removed, "Item should be removed from the cache.");
		var cachedPerson = cache.GetCacheItem<Person>(person.Id);
		Assert.IsNull(cachedPerson, "Cached item should be null after removal.");

		cache.Clear(); // Cleanup after test
	}

	[TestMethod]
	public void RemoveCacheItemBatch_EmptyKeys_ReturnsZero()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();

		// Act
		var removedCount = cache.RemoveCacheItemBatch(Enumerable.Empty<string>());

		// Assert
		Assert.AreEqual(0, removedCount);
		cache.Clear();
	}

	[TestMethod]
	public void RemoveCacheItemBatch_NullKeys_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			cache.RemoveCacheItemBatch(null));
	}

	[TestMethod]
	public void RemoveCacheItemBatch_RemovesMultipleItems()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var people = RandomData.GeneratePersonRefCollection(3).ToList();
		foreach (var person in people)
		{
			cache.AddCacheItem(person.Id, person);
		}

		// Act
		var keys = people.Take(2).Select(p => p.Id).Concat(new[] { Guid.NewGuid().ToString() });
		var removedCount = cache.RemoveCacheItemBatch(keys);

		// Assert
		Assert.AreEqual(2, removedCount);
		Assert.IsNull(cache.GetCacheItem<Person>(people[0].Id));
		Assert.IsNull(cache.GetCacheItem<Person>(people[1].Id));
		Assert.IsNotNull(cache.GetCacheItem<Person>(people[2].Id));
		cache.Clear();
	}

	[TestMethod]
	public void ResetStatistics_ResetsCounters()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		cache.ResetStatistics();
		var person = RandomData.GeneratePerson<Person>();
		cache.AddCacheItem(person.Id, person);
		_ = cache.GetCacheItem<Person>(person.Id); // Generate some stats
		_ = cache.GetCacheItem<Person>(Guid.NewGuid().ToString());

		// Act
		cache.ResetStatistics();
		var stats = cache.GetCacheStatistics();

		// Assert
		Assert.AreEqual(0, stats.CacheHits);
		Assert.AreEqual(0, stats.CacheMisses);
		cache.Clear();
	}

	[TestMethod]
	public void TryGetValue_MissingKey_ReturnsFalseAndDefault()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var found = cache.TryGetValue<string>("notfound", out var value);
		Assert.IsFalse(found);
		Assert.IsNull(value);
	}

	[TestMethod]
	public void TryGetValue_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var cache = InMemoryCache.Instance;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => cache.TryGetValue<string>(null, out _));
	}

	[TestMethod]
	public void TryGetValue_ReturnsFalseAndDefault_WhenKeyDoesNotExist()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();

		var result = cache.TryGetValue<string>(key, out var cachedValue);

		Assert.IsFalse(result, "TryGetValue should return false for a missing key.");
		Assert.IsNull(cachedValue, "TryGetValue should output default value for missing key.");
	}

	[TestMethod]
	public void TryGetValue_ReturnsTrueAndValue_WhenKeyExists()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		var value = "testValue";
		cache.AddCacheItem(key, value);

		var result = cache.TryGetValue<string>(key, out var cachedValue);

		Assert.IsTrue(result, "TryGetValue should return true for an existing key.");
		Assert.AreEqual(value, cachedValue, "TryGetValue should output the correct value.");

		cache.Clear();
	}

	[TestMethod]
	public void TryGetValue_TypeMismatch_ReturnsFalseAndDefault()
	{
		// Arrange
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		cache.AddCacheItem(key, "string value");

		// Act - Try to retrieve as int when it's a string
		var result = cache.TryGetValue<int>(key, out var value);

		// Assert
		Assert.IsFalse(result, "TryGetValue should return false for a type mismatch.");
		Assert.AreEqual(default(int), value, "TryGetValue should output default value for type mismatch.");
		cache.Clear();
	}

	[TestMethod]
	public async Task GetOrCreateAsync_FastPath_TypeMismatch_InvokesFactory()
	{
		// Arrange – put a string in the cache under a key, then request an int for the same key.
		// The fast-path check (TryGetValueCore) returns false because the cached object is not an int,
		// so the factory must be invoked and the new value cached.
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var key = Guid.NewGuid().ToString();
		cache.AddCacheItem(key, "existing string value");
		var factoryCalled = false;

		// Act
		var result = await cache.GetOrCreateAsync<int>(key, _ =>
		{
			factoryCalled = true;
			return Task.FromResult(42);
		});

		// Assert
		Assert.IsTrue(factoryCalled, "Factory should have been called because the cached type did not match.");
		Assert.AreEqual(42, result);
		cache.Clear();
	}

}
