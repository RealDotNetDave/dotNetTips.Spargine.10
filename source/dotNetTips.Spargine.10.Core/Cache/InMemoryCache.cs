// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-13-2024
//
// Last Modified By : David McCarter
// Last Modified On : 01-01-2026
// ***********************************************************************
// <copyright file="InMemoryCache.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// MemoryCache with a default duration of 20 minutes for storing objects
// in memory.
// </summary>
// ***********************************************************************

using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Primitives;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Cache;

/// <summary>
/// Provides a simple in-memory cache with a default expiration time. This class cannot be inherited.
/// </summary>
/// <remarks>
/// <para>This cache is built on top of <see cref="MemoryCache"/> and provides a simplified interface for adding, retrieving, and managing cached items with default and custom expiration times.</para>
/// <para>The default expiration time for cached items is 20 minutes.</para>
/// <para><strong>Thread Safety:</strong> This class is thread-safe. All operations can be safely called from multiple threads concurrently. The underlying <see cref="MemoryCache"/> is thread-safe, and all statistics tracking uses atomic operations.</para>
/// <para><strong>Performance Monitoring:</strong> The cache tracks hit and miss statistics that can be accessed via <see cref="GetCacheStatistics"/> to monitor cache effectiveness.</para>
/// <para><strong>Advanced Features:</strong></para>
/// <list type="bullet">
/// <item><description>Sliding expiration support for frequently accessed items</description></item>
/// <item><description>Priority-based eviction control</description></item>
/// <item><description>Size-aware caching with limits</description></item>
/// <item><description>Change token support for dependency-based invalidation</description></item>
/// <item><description>Linked cache dependencies for grouped invalidation</description></item>
/// <item><description>Post-eviction callbacks for cleanup operations</description></item>
/// <item><description>Single-flight pattern to prevent cache stampede</description></item>
/// </list>
/// </remarks>
/// <example>
/// Basic cache usage:
/// <code>
/// var cache = InMemoryCache.Instance;
/// var myObject = new MyObject();
/// cache.AddCacheItem("myKey", myObject);
///
/// // Retrieve the cached item
/// var cachedObject = cache.GetCacheItem&lt;MyObject&gt;("myKey");
/// </code>
/// 
/// Using sliding expiration for frequently accessed data:
/// <code>
/// cache.AddCacheItemWithSlidingExpiration("sessionKey", sessionData, TimeSpan.FromMinutes(5));
/// </code>
/// 
/// Monitoring cache performance:
/// <code>
/// var stats = cache.GetCacheStatistics();
/// Console.WriteLine($"Hit Ratio: {stats.HitRatio:P2}");
/// Console.WriteLine($"Total Items: {stats.TotalItems}");
/// Console.WriteLine($"Cache Hits: {stats.CacheHits}, Misses: {stats.CacheMisses}");
/// </code>
/// 
/// Using cache dependencies for grouped invalidation:
/// <code>
/// var dependency = cache.CreateCacheDependency("user-data-dependency");
/// cache.AddCacheItemWithDependency("user:1", userData1, TimeSpan.FromHours(1), dependency);
/// cache.AddCacheItemWithDependency("user:2", userData2, TimeSpan.FromHours(1), dependency);
/// 
/// // Later, invalidate all dependent items at once
/// cache.InvalidateDependentCacheItems("user-data-dependency");
/// </code>
/// 
/// Using GetOrCreateAsync to prevent cache stampede:
/// <code>
/// // Multiple concurrent calls will only execute the factory once
/// var data = await cache.GetOrCreateAsync(
///     "expensive-data",
///     async ct => await LoadExpensiveDataAsync(ct),
///     TimeSpan.FromMinutes(30));
/// </code>
/// </example>
/// <seealso cref="AddCacheItem{T}(string, T)"/>
/// <seealso cref="GetCacheItem{T}(string)"/>
/// <seealso cref="GetOrCreateAsync{T}(string, Func{CancellationToken, Task{T}}, TimeSpan?, CancellationToken)"/>
/// <seealso cref="GetCacheStatistics"/>
/// <seealso cref="CacheStatistics"/>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineInMemoryCache")]
public sealed class InMemoryCache
{
	//TODO: UPDATE ARTICLE ON DOTNETTIPS.COM

	/// <summary>
	/// Provides single-flight protection for concurrent cache population.
	/// Ensures that only one task populates a cache entry for a given key at a time,
	/// preventing duplicate work and reducing resource usage when multiple threads
	/// attempt to add the same item concurrently.
	/// </summary>
	private readonly ConcurrentDictionary<string, Lazy<Task<object?>>> _singleFlight = new();

	/// <summary>  
	/// The default timeout duration for cache items, in minutes.  
	/// </summary>  
	/// <remarks>  
	/// This value is used as the default expiration time for items added to the cache without a specified timeout.  
	/// See <see cref="AddCacheItem{T}(string, T)"/> and <see cref="CreateCache"/> for how this value is applied.  
	/// </remarks>  
	private readonly TimeSpan _timeoutInMinutes = TimeSpan.FromMinutes(20);

	/// <summary>
	/// Tracks cache hit statistics for performance monitoring.
	/// </summary>
	private long _cacheHits;

	/// <summary>
	/// Tracks cache miss statistics for performance monitoring.
	/// </summary>
	private long _cacheMisses;

	/// <summary>
	/// Initializes a new instance of the <see cref="InMemoryCache"/> class. The cache is created with default settings.
	/// </summary>
	private InMemoryCache() => this.Cache = CreateCache();

	/// <summary>
	/// Gets the count of items currently stored in the cache.
	/// </summary>
	/// <value>The count of items in the cache.</value>
	/// <remarks>
	/// This property provides the total number of items currently stored in the cache. It accesses the <see cref="MemoryCache.Count"/> property of the underlying <see cref="MemoryCache"/> instance used by the <see cref="InMemoryCache"/>.
	/// </remarks>
	[Pure]
	[Information(nameof(Count), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public static int Count
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => Instance.Cache.Count;
	}

	/// <summary>
	/// Gets the singleton instance of <see cref="InMemoryCache"/>.
	/// </summary>
	/// <value>The singleton instance of the <see cref="InMemoryCache"/> class.</value>
	/// <remarks>
	/// This property provides a global access point to the single instance of the <see cref="InMemoryCache"/> class, ensuring that only one instance is used throughout the application.
	/// </remarks>

	[Information(nameof(Instance), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public static InMemoryCache Instance { get; } = new();

	/// <summary>
	/// Gets the <see cref="MemoryCache"/> instance used by the <see cref="InMemoryCache"/>.
	/// </summary>
	/// <value>The <see cref="MemoryCache"/> instance.</value>
	/// <remarks>
	/// This property exposes the underlying <see cref="MemoryCache"/> used by the <see cref="InMemoryCache"/> class to store cached items.
	/// </remarks>

	[Information(nameof(Cache), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestStatus = UnitTestStatus.Completed)]
	public MemoryCache Cache { get; }

	/// <summary>
	/// Creates the cache with a custom configuration including optional size limit.
	/// </summary>
	/// <param name="sizeLimit">Optional size limit for the cache in number of entries. If not specified, cache has no size limit.</param>
	/// <returns>A new instance of <see cref="MemoryCache"/> configured with specified options.</returns>
	/// <remarks>
	/// The cache is configured to compact by 50% when the size limit is exceeded. 
	/// When a size limit is set, you must specify the size of each cache entry using AddCacheItemWithSize.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CreateCacheWithLimit), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public static MemoryCache CreateCacheWithLimit(long? sizeLimit = null)
	{
		var options = new MemoryCacheOptions
		{
			CompactionPercentage = 0.5
		};

		if (sizeLimit.HasValue)
		{
			options.SizeLimit = sizeLimit.Value;
		}

		return new MemoryCache(options);
	}

	/// <summary>
	/// Adds an item to the cache with a timeout of 20 minutes.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddCacheItem), "David McCarter", "1/16/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void AddCacheItem<T>([DisallowNull] string key, [DisallowNull] T item)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(this._timeoutInMinutes));
	}

	/// <summary>
	/// Adds an item to the cache with a custom timeout.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="timeout">The custom timeout for the cache item.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key" /> is null or empty, or <paramref name="item" /> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItem), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void AddCacheItem<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan timeout)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
	}

	/// <summary>
	/// Adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key" /> is null or empty, or <paramref name="item" /> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddCacheItem), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void AddCacheItem<T>([DisallowNull] string key, [DisallowNull] T item, DateTimeOffset timeout)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout)
 );
	}

	/// <summary>
	/// Asynchronously adds an item to the cache with a timeout of 20 minutes.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public Task AddCacheItemAsync<T>([DisallowNull] string key, [DisallowNull] T item, CancellationToken cancellationToken = default)
	{
		return Task.Run(() => this.AddCacheItem(key, item), cancellationToken);
	}

	/// <summary>
	/// Asynchronously adds an item to the cache with a custom timeout.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="timeout">The custom timeout for the cache item.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public Task AddCacheItemAsync<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan timeout, CancellationToken cancellationToken = default)
	{
		return Task.Run(() => this.AddCacheItem(key, item, timeout), cancellationToken);
	}

	/// <summary>
	/// Asynchronously adds an item to the cache with a custom expiration time.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item. This key is used to retrieve the item later.</param>
	/// <param name="item">The item to add to the cache. This can be of any type.</param>
	/// <param name="timeout">The custom expiration time for the cache item.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[Information(nameof(AddCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public Task AddCacheItemAsync<T>([DisallowNull] string key, [DisallowNull] T item, DateTimeOffset timeout, CancellationToken cancellationToken = default)
	{
		return Task.Run(() => this.AddCacheItem(key, item, timeout), cancellationToken);
	}

	/// <summary>
	/// Adds multiple items to the cache at once with the default timeout.
	/// </summary>
	/// <typeparam name="T">The type of items to be added to the cache.</typeparam>
	/// <param name="items">Dictionary of key-value pairs to add to the cache.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddCacheItemBatch), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void AddCacheItemBatch<T>([DisallowNull] IDictionary<string, T> items)
	{
		items = items.ArgumentNotNull();

		foreach (var kvp in items)
		{
			this.AddCacheItem(kvp.Key, kvp.Value!);
		}
	}

	/// <summary>
	/// Adds an item to the cache with a post-eviction callback.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item.</param>
	/// <param name="item">The item to add to the cache.</param>
	/// <param name="timeout">The expiration timeout.</param>
	/// <param name="postEvictionCallback">Callback to execute when the item is evicted from cache.</param>
	/// <exception cref="ArgumentNullException">Thrown if required parameters are null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItemWithCallback), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void AddCacheItemWithCallback<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan timeout, [DisallowNull] PostEvictionDelegate postEvictionCallback)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();
		postEvictionCallback = postEvictionCallback.ArgumentNotNull();

		var options = new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout)
			.RegisterPostEvictionCallback(postEvictionCallback);

		_ = this.Cache.Set(key, item, options);
	}

	/// <summary>
	/// Adds an item to the cache with a change token for dependency-based invalidation.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item.</param>
	/// <param name="item">The item to add to the cache.</param>
	/// <param name="timeout">The expiration timeout.</param>
	/// <param name="changeToken">A change token that will trigger cache invalidation when signaled.</param>
	/// <exception cref="ArgumentNullException">Thrown if required parameters are null or empty.</exception>
	/// <remarks>
	/// Change tokens enable cache invalidation based on external dependencies like file changes or configuration updates.
	/// When the change token signals a change, the cache entry is automatically removed.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItemWithChangeToken), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void AddCacheItemWithChangeToken<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan timeout, [DisallowNull] IChangeToken changeToken)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();
		changeToken = changeToken.ArgumentNotNull();

		var options = new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout)
			.AddExpirationToken(changeToken);

		_ = this.Cache.Set(key, item, options);
	}

	/// <summary>
	/// Adds an item to the cache with both sliding and absolute expiration for optimal control.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item.</param>
	/// <param name="item">The item to add to the cache.</param>
	/// <param name="slidingExpiration">The sliding expiration time.</param>
	/// <param name="absoluteExpiration">The absolute expiration time.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItemWithCombinedExpiration), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void AddCacheItemWithCombinedExpiration<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan slidingExpiration, TimeSpan absoluteExpiration)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		var options = new MemoryCacheEntryOptions()
			.SetSlidingExpiration(slidingExpiration)
			.SetAbsoluteExpiration(absoluteExpiration);

		_ = this.Cache.Set(key, item, options);
	}

	/// <summary>
	/// Adds an item to the cache with a dependency on a CancellationTokenSource, allowing grouped invalidation.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item.</param>
	/// <param name="item">The item to add to the cache.</param>
	/// <param name="timeout">The expiration timeout.</param>
	/// <param name="dependencyTokenSource">The CancellationTokenSource that controls this cache entry's lifetime.</param>
	/// <exception cref="ArgumentNullException">Thrown if required parameters are null or empty.</exception>
	/// <remarks>
	/// Multiple cache entries can share the same CancellationTokenSource, allowing them to be invalidated together
	/// by cancelling the token source. Use CreateCacheDependency to create a managed dependency.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItemWithDependency), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void AddCacheItemWithDependency<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan timeout, [DisallowNull] CancellationTokenSource dependencyTokenSource)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();
		dependencyTokenSource = dependencyTokenSource.ArgumentNotNull();

		var options = new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout)
			.AddExpirationToken(new CancellationChangeToken(dependencyTokenSource.Token));

		_ = this.Cache.Set(key, item, options);
	}

	/// <summary>
	/// Adds an item to the cache with a specified priority level.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item.</param>
	/// <param name="item">The item to add to the cache.</param>
	/// <param name="timeout">The expiration timeout.</param>
	/// <param name="priority">The cache item priority (affects eviction behavior under memory pressure).</param>
	/// <exception cref="ArgumentNullException">Thrown if required parameters are null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItemWithPriority), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void AddCacheItemWithPriority<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan timeout, CacheItemPriority priority)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		var options = new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout)
			.SetPriority(priority);

		_ = this.Cache.Set(key, item, options);
	}

	/// <summary>
	/// Adds an item to the cache with a specified size for size-aware caching.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item.</param>
	/// <param name="item">The item to add to the cache.</param>
	/// <param name="timeout">The expiration timeout.</param>
	/// <param name="size">The size of the cache entry (used when MemoryCache has SizeLimit configured).</param>
	/// <exception cref="ArgumentNullException">Thrown if required parameters are null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItemWithSize), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void AddCacheItemWithSize<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan timeout, long size)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		var options = new MemoryCacheEntryOptions()
			.SetAbsoluteExpiration(timeout)
			.SetSize(size);

		_ = this.Cache.Set(key, item, options);
	}

	/// <summary>
	/// Adds an item to the cache with sliding expiration.
	/// </summary>
	/// <typeparam name="T">The type of the item to be added to the cache.</typeparam>
	/// <param name="key">The key associated with the cache item.</param>
	/// <param name="item">The item to add to the cache.</param>
	/// <param name="slidingExpiration">The sliding expiration time - item expires if not accessed within this timespan.</param>
	/// <exception cref="ArgumentNullException">Thrown if either <paramref name="key"/> is null or empty, or <paramref name="item"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(AddCacheItemWithSlidingExpiration), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void AddCacheItemWithSlidingExpiration<T>([DisallowNull] string key, [DisallowNull] T item, TimeSpan slidingExpiration)
	{
		key = key.ArgumentNotNullOrEmpty();
		item = item.ArgumentNotNull();

		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetSlidingExpiration(slidingExpiration));
	}

	/// <summary>
	/// Clears all items from the cache.
	/// </summary>
	/// <remarks>This method is intended to remove all items from the cache, effectively resetting it.
	/// Use with caution as this will remove all cached data.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Clear), "David McCarter", "6/12/2024", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void Clear() => this.Cache.Compact(1.0);

	/// <summary>
	/// Compacts the cache by the specified percentage.
	/// </summary>
	/// <param name="percentage">The percentage of cache entries to remove (0.0 to 1.0).</param>
	/// <remarks>
	/// This method removes the specified percentage of cache entries based on their priority and expiration.
	/// Use this to manually trigger cache compaction when memory pressure is detected.
	/// </remarks>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="percentage"/> is not between 0.0 and 1.0.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Compact), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void Compact(double percentage)
	{
		if (percentage is < 0.0 or > 1.0)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(Properties.Resources.PercentageMustBeBetween00And10, nameof(percentage));
		}

		this.Cache.Compact(percentage);
	}

	/// <summary>
	/// Determines whether the cache contains an item with the specified key.
	/// </summary>
	/// <param name="key">The key of the item to locate in the cache.</param>
	/// <returns><c>true</c> if the cache contains an item with the specified key; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ContainsKey), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool ContainsKey([DisallowNull] string key)
	{
		key = key.ArgumentNotNullOrEmpty();

		return this.Cache.TryGetValue(key, out _);
	}

	/// <summary>
	/// Creates a CancellationTokenSource that can be used to link multiple cache entries together for grouped invalidation.
	/// </summary>
	/// <param name="dependencyKey">The key to store the cancellation token source under for later retrieval.</param>
	/// <returns>A CancellationTokenSource that can be used with AddCacheItemWithDependency.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="dependencyKey"/> is null or empty.</exception>
	/// <remarks>
	/// This enables cache dependency management where multiple cache entries can be invalidated together by cancelling the token.
	/// Store the dependency key and later call InvalidateDependentCacheItems to remove all linked entries.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CreateCacheDependency), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public CancellationTokenSource CreateCacheDependency([DisallowNull] string dependencyKey)
	{
		dependencyKey = dependencyKey.ArgumentNotNullOrEmpty();

		var cts = new CancellationTokenSource();
		this.AddCacheItem(dependencyKey, cts);

		return cts;
	}

	/// <summary>
	/// Gets all keys currently stored in the cache.
	/// </summary>
	/// <returns>An enumerable collection of keys in the cache.</returns>
	/// <remarks>
	/// This method provides a way to retrieve all keys currently stored in the cache. It can be useful for debugging and monitoring purposes.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetAllKeys), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public IEnumerable<string> GetAllKeys()
	{
		return this.Cache.Keys.Select(p => p?.ToString() ?? string.Empty);
	}

	/// <summary>
	/// Gets the cache item associated with the specified key.
	/// </summary>
	/// <typeparam name="T">The type of the item stored in the cache.</typeparam>
	/// <param name="key">The key of the item to retrieve from the cache.</param>
	/// <returns>The item of type <typeparamref name="T"/> if found; otherwise, the default value of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	/// <remarks>
	/// Retrieves an item from the cache using the specified key. If the item is found, it is returned; otherwise, the default value for type <typeparamref name="T"/> is returned.
	/// This method utilizes the MemoryCache.TryGetValue method to attempt to retrieve the item.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(GetCacheItem), "David McCarter", "1/16/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public T GetCacheItem<T>([DisallowNull] string key)
	{
		key = key.ArgumentNotNullOrEmpty();

		var found = this.Cache.TryGetValue<T>(key, out var item);

		_ = found ? Interlocked.Increment(ref this._cacheHits) : Interlocked.Increment(ref this._cacheMisses);

		return item!;
	}

	/// <summary>
	/// Asynchronously gets the cache item associated with the specified key.
	/// </summary>
	/// <typeparam name="T">The type of the item stored in the cache.</typeparam>
	/// <param name="key">The key of the item to retrieve from the cache.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>A task that represents the asynchronous operation. The task result contains the item of type <typeparamref name="T"/> if found; otherwise, the default value of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	/// <remarks>
	/// Retrieves an item from the cache using the specified key asynchronously. If the item is found, it is returned; otherwise, the default value for type <typeparamref name="T"/> is returned.
	/// This method utilizes the MemoryCache.TryGetValue method to attempt to retrieve the item.
	/// </remarks>
	[Information(nameof(GetCacheItemAsync), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public Task<T> GetCacheItemAsync<T>([DisallowNull] string key, CancellationToken cancellationToken = default)
	{
		return Task.Run(() => this.GetCacheItem<T>(key), cancellationToken);
	}

	/// <summary>
	/// Gets multiple cache items at once.
	/// </summary>
	/// <typeparam name="T">The type of items stored in the cache.</typeparam>
	/// <param name="keys">Collection of keys to retrieve from the cache.</param>
	/// <returns>A dictionary containing the found cache items keyed by their cache key.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="keys"/> is null.</exception>
	/// <remarks>
	/// This method efficiently retrieves multiple cache items in a single operation.
	/// Only items that exist in the cache are included in the returned dictionary.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCacheItemBatch), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public IDictionary<string, T> GetCacheItemBatch<T>([DisallowNull] IEnumerable<string> keys)
	{
		keys = keys.ArgumentNotNull();

		var result = new Dictionary<string, T>();

		foreach (var key in keys)
		{
			if (this.TryGetValue<T>(key, out var value) && value is not null)
			{
				result[key] = value;
			}
		}

		return result;
	}

	/// <summary>
	/// Gets statistics about the current cache state.
	/// </summary>
	/// <returns>A CacheStatistics object containing current cache metrics.</returns>
	/// <remarks>
	/// This method provides insights into cache usage including total items, hit/miss ratios, and other metrics
	/// useful for monitoring and optimization. Use this for diagnostics and performance tuning.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetCacheStatistics), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public CacheStatistics GetCacheStatistics()
	{
		return new CacheStatistics
		{
			TotalItems = this.Cache.Count,
			CompactionPercentage = 0.5,
			CacheHits = Interlocked.Read(ref this._cacheHits),
			CacheMisses = Interlocked.Read(ref this._cacheMisses)
		};
	}

	/// <summary>
	/// Gets the cache item associated with the specified key, or creates and caches it asynchronously if it does not exist.
	/// Ensures that only one factory delegate executes per key at a time (single-flight), preventing duplicate work.
	/// </summary>
	/// <typeparam name="T">The type of the item to be retrieved or created.</typeparam>
	/// <param name="key">The key of the cache item. Must not be null or empty.</param>
	/// <param name="factory">A delegate that asynchronously produces the value to cache if the key is not present. Must not be null.</param>
	/// <param name="timeout">An optional relative expiration time for the cache entry. If not specified, the default cache timeout is used.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>
	/// A task that represents the asynchronous operation. The task result contains the cached or newly created item of type <typeparamref name="T"/>.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> or <paramref name="factory"/> is null or empty.</exception>
	/// <remarks>
	/// If multiple callers attempt to create the same cache entry concurrently, only one factory delegate will execute and the result will be shared.
	/// </remarks>
	[Information(nameof(GetOrCreateAsync), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public async Task<T> GetOrCreateAsync<T>([DisallowNull] string key, [DisallowNull] Func<CancellationToken, Task<T>> factory, TimeSpan? timeout = null, CancellationToken cancellationToken = default)
	{
		key = key.ArgumentNotNullOrEmpty();
		factory = factory.ArgumentNotNull();

		// Fast path: already cached
		if (this.Cache.TryGetValue<T>(key, out var item) && item is T cached)
		{
			return cached;
		}

		// Ensure only one factory runs per key even with concurrent callers
		var lazy = this._singleFlight.GetOrAdd(
			key,
			_ => new Lazy<Task<object?>>(
				async () => await factory(cancellationToken).ConfigureAwait(false),
				LazyThreadSafetyMode.ExecutionAndPublication));

		object? result;

		try
		{
			result = await lazy.Value.ConfigureAwait(false);
		}
		finally
		{
			// Always clear the single-flight slot (success or exception)
			_ = this._singleFlight.TryRemove(key, out _);
		}

		// Cache the successful result
		if (timeout.HasValue)
		{
			this.AddCacheItem(key, (T)result!, timeout.Value);
		}
		else
		{
			this.AddCacheItem(key, (T)result!);
		}

		return (T)result!;
	}

	/// <summary>
	/// Gets the cache item associated with the specified key, or creates and caches it asynchronously if it does not exist.
	/// Ensures that only one factory delegate executes per key at a time (single-flight), preventing duplicate work.
	/// </summary>
	/// <typeparam name="T">The type of the item to be retrieved or created.</typeparam>
	/// <param name="key">The key of the cache item. Must not be null or empty.</param>
	/// <param name="factory">A delegate that asynchronously produces the value to cache if the key is not present. Must not be null.</param>
	/// <param name="absoluteExpiration">The absolute expiration time for the cache entry.</param>
	/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
	/// <returns>
	/// A task that represents the asynchronous operation. The task result contains the cached or newly created item of type <typeparamref name="T"/>.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> or <paramref name="factory"/> is null or empty.</exception>
	/// <remarks>
	/// If multiple callers attempt to create the same cache entry concurrently, only one factory delegate will execute and the result will be shared.
	/// </remarks>
	[Information(nameof(GetOrCreateAsync), "David McCarter", "8/10/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public Task<T> GetOrCreateAsync<T>([DisallowNull] string key, [DisallowNull] Func<CancellationToken, Task<T>> factory, DateTimeOffset absoluteExpiration, CancellationToken cancellationToken = default)
	{
		// Convert to relative window and delegate to the main overload
		var ttl = absoluteExpiration - DateTimeOffset.UtcNow;

		return this.GetOrCreateAsync(key, factory, ttl, cancellationToken);
	}

	/// <summary>
	/// Invalidates all cache entries that depend on the specified dependency key.
	/// </summary>
	/// <param name="dependencyKey">The key of the dependency to invalidate.</param>
	/// <returns><c>true</c> if the dependency was found and cancelled; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="dependencyKey"/> is null or empty.</exception>
	/// <remarks>
	/// This method cancels the CancellationTokenSource associated with the dependency key,
	/// causing all cache entries linked to that dependency to be automatically removed.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(InvalidateDependentCacheItems), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public bool InvalidateDependentCacheItems([DisallowNull] string dependencyKey)
	{
		dependencyKey = dependencyKey.ArgumentNotNullOrEmpty();

		if (this.TryGetValue<CancellationTokenSource>(dependencyKey, out var cts) && cts is not null)
		{
			cts.Cancel();
			cts.Dispose();
			_ = this.RemoveCacheItem(dependencyKey);
			return true;
		}

		return false;
	}

	/// <summary>
	/// Peeks at a cache item without updating statistics or access time.
	/// </summary>
	/// <typeparam name="T">The type of the item stored in the cache.</typeparam>
	/// <param name="key">The key of the item to peek at.</param>
	/// <param name="value">When this method returns, contains the object from the cache if found; otherwise, the default value.</param>
	/// <returns><c>true</c> if the item exists in cache; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	/// <remarks>
	/// This method checks if an item exists in the cache without affecting hit/miss statistics
	/// or sliding expiration timers. Useful for diagnostics and monitoring.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(PeekCacheItem), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public bool PeekCacheItem<T>([DisallowNull] string key, out T? value)
	{
		key = key.ArgumentNotNullOrEmpty();

		if (this.Cache.TryGetValue(key, out var item) && item is T t)
		{
			value = t;
			return true;
		}

		value = default;
		return false;
	}

	/// <summary>
	/// Refreshes the expiration time of an existing cache item.
	/// </summary>
	/// <param name="key">The key of the cache item to refresh.</param>
	/// <param name="newTimeout">The new expiration timeout.</param>
	/// <returns><c>true</c> if the item was found and refreshed; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RefreshCacheItem), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public bool RefreshCacheItem([DisallowNull] string key, TimeSpan newTimeout)
	{
		key = key.ArgumentNotNullOrEmpty();

		if (this.Cache.TryGetValue(key, out var item))
		{
			_ = this.Cache.Set(key, item!, new MemoryCacheEntryOptions().SetAbsoluteExpiration(newTimeout));
			return true;
		}

		return false;
	}

	/// <summary>
	/// Removes the cache item associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the item to remove from the cache.</param>
	/// <returns><c>true</c> if the item is successfully removed; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RemoveCacheItem), "David McCarter", "1/20/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool RemoveCacheItem([DisallowNull] string key)
	{
		key = key.ArgumentNotNullOrEmpty();

		if (this.Cache.TryGetValue(key, out _))
		{
			this.Cache.Remove(key);
			return true;
		}

		return false;
	}

	/// <summary>
	/// Removes multiple items from the cache at once.
	/// </summary>
	/// <param name="keys">Collection of keys to remove from the cache.</param>
	/// <returns>The number of items successfully removed.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="keys"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RemoveCacheItemBatch), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public int RemoveCacheItemBatch([DisallowNull] IEnumerable<string> keys)
	{
		keys = keys.ArgumentNotNull();

		var removedCount = 0;

		foreach (var key in keys)
		{
			if (this.RemoveCacheItem(key))
			{
				removedCount++;
			}
		}

		return removedCount;
	}

	/// <summary>
	/// Resets the cache statistics counters to zero.
	/// </summary>
	/// <remarks>
	/// This method resets the hit and miss counters, useful for monitoring cache performance over specific time periods.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ResetStatistics), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public void ResetStatistics()
	{
		_ = Interlocked.Exchange(ref this._cacheHits, 0);
		_ = Interlocked.Exchange(ref this._cacheMisses, 0);
	}

	/// <summary>
	/// Attempts to get the cache item associated with the specified key.
	/// </summary>
	/// <typeparam name="T">The type of the item stored in the cache.</typeparam>
	/// <param name="key">The key of the item to retrieve from the cache.</param>
	/// <param name="value">
	/// When this method returns, contains the object from the cache associated with the specified key, 
	/// if the key is found; otherwise, the default value for the type of the value parameter.
	/// </param>
	/// <returns>
	/// <c>true</c> if the cache contains an item with the specified key; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="key"/> is null or empty.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Pure]
	[Information(nameof(TryGetValue), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public bool TryGetValue<T>([DisallowNull] string key, out T? value)
	{
		key = key.ArgumentNotNullOrEmpty();

		if (this.Cache.TryGetValue(key, out var item) && item is T t)
		{
			value = t;
			return true;
		}

		value = default;
		return false;
	}

	/// <summary>
	/// Creates the cache with a default configuration.
	/// </summary>
	/// <returns>A new instance of <see cref="MemoryCache"/> configured with a compaction percentage and a default expiration policy.</returns>
	/// <remarks>
	/// The cache is configured to compact by 50% when the size limit is exceeded. The default expiration time for each cache entry is set to 20 minutes.
	/// </remarks>
	private static MemoryCache CreateCache()
	{
		var options = new MemoryCacheOptions
		{
			CompactionPercentage = 0.5
		};


		return new MemoryCache(options);
	}
}
