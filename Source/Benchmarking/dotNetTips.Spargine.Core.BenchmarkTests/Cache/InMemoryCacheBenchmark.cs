// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : david
// Created          : 10-03-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="InMemoryCacheBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Primitives;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Cache;

[MemoryDiagnoser]
[ThreadingDiagnoser]
public class InMemoryCacheBenchmark : LargeCollectionBenchmark
{
	private static readonly PostEvictionDelegate _noopPostEvictionCallback = static (_, _, _, _) => { };

	private IDictionary<string, Person> _batchItems = new Dictionary<string, Person>();
	private string[] _batchKeys = [];
	private InMemoryCache _cache = InMemoryCache.Instance;
	private string _cacheId = string.Empty;
	private string _dependencyKey = string.Empty;
	private PersonRecord[] _personRecordArray = [];
	private Person[] _personRefArray = [];

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItem()
	{
		var cache = InMemoryCache.Instance;

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Email, item);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemAsync))]
	[BenchmarkCategory(Categories.Collections)]
	public async Task AddCacheItemAsync()
	{
		var cache = InMemoryCache.Instance;

		foreach (var item in this._personRefArray)
		{
			await cache.AddCacheItemAsync(item.Email, item).ConfigureAwait(false);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemAsync) + ": DateTimeOffset")]
	[BenchmarkCategory(Categories.Collections)]
	public async Task AddCacheItemAsyncDateTimeOffsetAsync()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRefArray)
		{
			await cache.AddCacheItemAsync(item.Email, item, futureDate).ConfigureAwait(false);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemAsync) + ": DataTimeOffset - IDataModel")]
	[BenchmarkCategory(Categories.Collections)]
	public async Task AddCacheItemAsyncDateTimeOffsetIDataModelAsync()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRefArray)
		{
			await cache.AddCacheItemAsync(item.Id, item, futureDate).ConfigureAwait(false);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemAsync) + ": DataTimeOffset - IDataRecord")]
	[BenchmarkCategory(Categories.Collections)]
	public async Task AddCacheItemAsyncDateTimeOffsetIDataRecordAsync()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRecordArray)
		{
			await cache.AddCacheItemAsync(item.Id, item, futureDate).ConfigureAwait(false);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemAsync) + ": IDataModel")]
	[BenchmarkCategory(Categories.Collections)]
	public async Task AddCacheItemAsyncIDataModelAsync()
	{
		var cache = InMemoryCache.Instance;

		foreach (var item in this._personRefArray)
		{
			await cache.AddCacheItemAsync(item.Id, item).ConfigureAwait(false);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemAsync) + ": IDataRecord")]
	[BenchmarkCategory(Categories.Collections)]
	public async Task AddCacheItemAsyncIDataRecordAsync()
	{
		var cache = InMemoryCache.Instance;

		foreach (var item in this._personRecordArray)
		{
			await cache.AddCacheItemAsync(item.Id, item).ConfigureAwait(false);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemAsync) + ": Timespan")]
	[BenchmarkCategory(Categories.Collections)]
	public async Task AddCacheItemAsyncTimeSpanAsync()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = TimeSpan.FromSeconds(5);

		foreach (var item in this._personRefArray)
		{
			await cache.AddCacheItemAsync(item.Email, item, futureDate).ConfigureAwait(false);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemAsync) + ": TimeSpan - IDataRecord")]
	[BenchmarkCategory(Categories.Collections)]
	public async Task AddCacheItemAsyncTimeSpanIDataRecordAsync()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = TimeSpan.FromSeconds(5);

		foreach (var item in this._personRecordArray)
		{
			await cache.AddCacheItemAsync(item.Id, item, futureDate).ConfigureAwait(false);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemBatch))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemBatch()
	{
		this._cache.AddCacheItemBatch(this._batchItems);

		this.Consume(this._cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": DateTimeOffset")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemDateTimeOffset()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Email, item, futureDate);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": DataTimeOffset - IDataModel")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemDateTimeOffsetIDataModel()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Id, item, futureDate);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": DataTimeOffset - IDataRecord")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemDateTimeOffsetIDataRecord()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRecordArray)
		{
			cache.AddCacheItem(item.Id, item, futureDate);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": IDataModel")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemIDataModel()
	{
		var cache = InMemoryCache.Instance;

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Id, item);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": IDataRecord")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemIDataRecord()
	{
		var cache = InMemoryCache.Instance;

		foreach (var item in this._personRecordArray)
		{
			cache.AddCacheItem(item.Id, item);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": Timespan")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemTimeSpan()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = TimeSpan.FromSeconds(5);

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Email, item, futureDate);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItem) + ": TimeSpan - IDataRecord")]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemTimeSpanIDataRecord()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = TimeSpan.FromSeconds(5);

		foreach (var item in this._personRecordArray)
		{
			cache.AddCacheItem(item.Id, item, futureDate);
		}

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemWithCallback))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemWithCallback()
	{
		var timeout = TimeSpan.FromMinutes(20);

		foreach (var item in this._personRefArray)
		{
			this._cache.AddCacheItemWithCallback(item.Email + "_callback", item, timeout, _noopPostEvictionCallback);
		}

		this.Consume(this._cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemWithChangeToken))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemWithChangeToken()
	{
		using var tokenSource = new CancellationTokenSource();
		var timeout = TimeSpan.FromMinutes(20);
		var changeToken = new CancellationChangeToken(tokenSource.Token);

		foreach (var item in this._personRefArray)
		{
			this._cache.AddCacheItemWithChangeToken(item.Email + "_token", item, timeout, changeToken);
		}

		this.Consume(this._cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemWithCombinedExpiration))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemWithCombinedExpiration()
	{
		var slidingExpiration = TimeSpan.FromMinutes(5);
		var absoluteExpiration = TimeSpan.FromMinutes(20);

		foreach (var item in this._personRefArray)
		{
			this._cache.AddCacheItemWithCombinedExpiration(item.Email + "_combined", item, slidingExpiration, absoluteExpiration);
		}

		this.Consume(this._cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemWithDependency))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemWithDependency()
	{
		using var dependencyTokenSource = new CancellationTokenSource();
		var timeout = TimeSpan.FromMinutes(20);

		foreach (var item in this._personRefArray)
		{
			this._cache.AddCacheItemWithDependency(item.Email + "_dependency", item, timeout, dependencyTokenSource);
		}

		this.Consume(this._cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemWithPriority))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemWithPriority()
	{
		var timeout = TimeSpan.FromMinutes(20);

		foreach (var item in this._personRefArray)
		{
			this._cache.AddCacheItemWithPriority(item.Email + "_priority", item, timeout, CacheItemPriority.High);
		}

		this.Consume(this._cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemWithSize))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemWithSize()
	{
		var timeout = TimeSpan.FromMinutes(20);

		foreach (var item in this._personRefArray)
		{
			this._cache.AddCacheItemWithSize(item.Email + "_size", item, timeout, 1);
		}

		this.Consume(this._cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.AddCacheItemWithSlidingExpiration))]
	[BenchmarkCategory(Categories.Collections)]
	public void AddCacheItemWithSlidingExpiration()
	{
		var slidingExpiration = TimeSpan.FromMinutes(20);

		foreach (var item in this._personRefArray)
		{
			this._cache.AddCacheItemWithSlidingExpiration(item.Email + "_sliding", item, slidingExpiration);
		}

		this.Consume(this._cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.Clear))]
	[BenchmarkCategory(Categories.Collections)]
	public void Clear()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Email, item, futureDate);
		}

		cache.Clear();

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.Compact))]
	[BenchmarkCategory(Categories.Collections)]
	public void Compact()
	{
		var cache = InMemoryCache.Instance;
		var futureDate = DateTimeOffset.Now.AddMinutes(30);

		foreach (var item in this._personRefArray)
		{
			cache.AddCacheItem(item.Email, item, futureDate);
		}

		cache.Compact(0.5);

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.CreateCacheDependency))]
	[BenchmarkCategory(Categories.Collections)]
	public void CreateCacheDependency()
	{
		var dependencyKey = this._dependencyKey + "_create";
		_ = this._cache.InvalidateDependentCacheItems(dependencyKey);

		using var dependency = this._cache.CreateCacheDependency(dependencyKey);

		this.Consume(dependency);

		_ = this._cache.InvalidateDependentCacheItems(dependencyKey);
	}

	[Benchmark(Description = nameof(InMemoryCache.CreateCacheWithLimit))]
	[BenchmarkCategory(Categories.Collections)]
	public void CreateCacheWithLimit()
	{
		using var cache = InMemoryCache.CreateCacheWithLimit(10_000);

		this.Consume(cache);
	}

	[Benchmark(Description = nameof(InMemoryCache.GetAllKeys))]
	[BenchmarkCategory(Categories.Collections)]
	public void GetAllKeys()
	{
		this.Consume(this._cache.GetAllKeys());
	}

	[Benchmark(Description = nameof(InMemoryCache.GetCacheItem))]
	[BenchmarkCategory(Categories.Collections)]
	public void GetCacheItem()
	{
		this.Consume(this._cache.GetCacheItem<Person>(this._cacheId));
	}

	[Benchmark(Description = nameof(InMemoryCache.GetCacheItemAsync))]
	[BenchmarkCategory(Categories.Collections)]
	public async Task GetCacheItemAsync()
	{
		this.Consume(await this._cache.GetCacheItemAsync<Person>(this._cacheId).ConfigureAwait(false));
	}

	[Benchmark(Description = nameof(InMemoryCache.GetCacheItemBatch))]
	[BenchmarkCategory(Categories.Collections)]
	public void GetCacheItemBatch()
	{
		var keys = new string[this._personRefArray.Length];

		for (var index = 0; index < this._personRefArray.Length; index++)
		{
			keys[index] = this._personRefArray[index].Email;
		}

		this.Consume(this._cache.GetCacheItemBatch<Person>(keys));
	}

	[Benchmark(Description = nameof(InMemoryCache.GetCacheStatistics))]
	[BenchmarkCategory(Categories.Collections)]
	public void GetCacheStatistics()
	{
		this.Consume(this._cache.GetCacheStatistics());
	}

	[Benchmark(Description = nameof(InMemoryCache.GetOrCreateAsync))]
	[BenchmarkCategory(Categories.Collections)]
	public async Task GetOrCreateAsync()
	{
		var key = this._cacheId + "_factory";

		_ = this._cache.RemoveCacheItem(key);

		this.Consume(await this._cache.GetOrCreateAsync(
			key,
			_ => Task.FromResult(this.PersonRef01),
			TimeSpan.FromMinutes(20)).ConfigureAwait(false));
	}

	[Benchmark(Description = nameof(InMemoryCache.GetOrCreateAsync) + ": DateTimeOffset")]
	[BenchmarkCategory(Categories.Collections)]
	public async Task GetOrCreateAsyncDateTimeOffsetAsync()
	{
		var key = this._cacheId + "_factory_absolute";

		_ = this._cache.RemoveCacheItem(key);

		this.Consume(await this._cache.GetOrCreateAsync(
			key,
			_ => Task.FromResult(this.PersonRef01),
			DateTimeOffset.UtcNow.AddMinutes(20)).ConfigureAwait(false));
	}

	[Benchmark(Description = nameof(InMemoryCache.InvalidateDependentCacheItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void InvalidateDependentCacheItems()
	{
		using var dependency = this._cache.CreateCacheDependency(this._dependencyKey);
		this._cache.AddCacheItemWithDependency(this._cacheId + "_dependent", this.PersonRef01, TimeSpan.FromMinutes(20), dependency);

		this.Consume(this._cache.InvalidateDependentCacheItems(this._dependencyKey));
	}

	[Benchmark(Description = nameof(InMemoryCache.PeekCacheItem))]
	[BenchmarkCategory(Categories.Collections)]
	public void PeekCacheItem()
	{
		this.Consume(this._cache.PeekCacheItem<Person>(this._cacheId, out _));
	}

	[Benchmark(Description = nameof(InMemoryCache.RefreshCacheItem))]
	[BenchmarkCategory(Categories.Collections)]
	public void RefreshCacheItem()
	{
		var key = this._cacheId + "_refresh";
		this._cache.AddCacheItem(key, this.PersonRef01, TimeSpan.FromMinutes(10));

		this.Consume(this._cache.RefreshCacheItem(key, TimeSpan.FromMinutes(20)));
	}

	[Benchmark(Description = nameof(InMemoryCache.RemoveCacheItemBatch))]
	[BenchmarkCategory(Categories.Collections)]
	public void RemoveCacheItemBatch()
	{
		this._cache.AddCacheItemBatch(this._batchItems);

		this.Consume(this._cache.RemoveCacheItemBatch(this._batchKeys));
	}

	[Benchmark(Description = nameof(InMemoryCache.ResetStatistics))]
	[BenchmarkCategory(Categories.Collections)]
	public void ResetStatistics()
	{
		_ = this._cache.TryGetValue<Person>(this._cacheId, out _);
		_ = this._cache.TryGetValue<Person>(this._cacheId + "_missing", out _);

		this._cache.ResetStatistics();
		this.Consume(this._cache.GetCacheStatistics());
	}

	public override void Setup()
	{
		base.Setup();
		this._personRefArray = this.GetPersonRefArray();
		this._personRecordArray = this.GetPersonRecordArray();
		this._cache = InMemoryCache.Instance;
		this._cacheId = this.PersonRef01.Id;
		this._dependencyKey = $"{this._cacheId}_dependency";
		this._batchItems = new Dictionary<string, Person>(this._personRefArray.Length);
		this._batchKeys = new string[this._personRefArray.Length];
		this._cache.AddCacheItem(this._cacheId, this.PersonRef01);

		for (var arrayIndex = 0; arrayIndex < this._personRefArray.Length; arrayIndex++)
		{
			var person = this._personRefArray[arrayIndex];
			this._cache.AddCacheItem(person.Email, person);

			var batchKey = person.Id + "_batch";
			this._batchKeys[arrayIndex] = batchKey;
			this._batchItems[batchKey] = person;
		}
	}

	[Benchmark(Description = nameof(InMemoryCache.TryGetValue))]
	[BenchmarkCategory(Categories.Collections)]
	public void TryGetValue()
	{
		this.Consume(this._cache.TryGetValue<Person>(this._cacheId, out _));
	}
}
