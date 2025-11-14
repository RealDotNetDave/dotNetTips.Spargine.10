// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="InMemoryCacheTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Cache;

[ExcludeFromCodeCoverage]
[TestClass]
public class InMemoryCacheTests
{

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
		Assert.AreEqual(0, keys.Count);
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
		Assert.IsTrue(keys.Contains(key1));
		Assert.IsTrue(keys.Contains(key2));
		cache.Clear();
	}


	[TestMethod]
	public void GetAllKeys_ReturnsEmptyWhenCacheIsEmpty()
	{
		var cache = InMemoryCache.Instance;
		cache.Clear();
		var keys = cache.GetAllKeys().ToList();
		Assert.AreEqual(0, keys.Count);
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

}
