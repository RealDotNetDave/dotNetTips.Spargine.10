// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : david
// Created          : 10-03-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="InMemoryCacheBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Cache;

[MemoryDiagnoser]
[ThreadingDiagnoser]
public class InMemoryCacheBenchmark : LargeCollectionBenchmark
{
	private InMemoryCache _cache = default!;
	private string _cacheId = default!;
	private PersonRecord[] _personRecordArray = default!;
	private Person[] _personRefArray = default!;

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

	[Benchmark(Description = nameof(InMemoryCache.PeekCacheItem))]
	[BenchmarkCategory(Categories.Collections)]
	public void PeekCacheItem()
	{
		this.Consume(this._cache.PeekCacheItem<Person>(this._cacheId, out _));
	}

	public override void Setup()
	{
		base.Setup();
		this._personRefArray = this.GetPersonRefArray();
		this._personRecordArray = this.GetPersonRecordArray();
		this._cache = InMemoryCache.Instance;
		this._cache.AddCacheItem(this.PersonRef01.Id, this.PersonRef01);
		this._cacheId = this.PersonRef01.Id;

		foreach (var item in this._personRefArray)
		{
			this._cache.AddCacheItem(item.Email, item);
		}
	}

	[Benchmark(Description = nameof(InMemoryCache.TryGetValue))]
	[BenchmarkCategory(Categories.Collections)]
	public void TryGetValue()
	{
		this.Consume(this._cache.TryGetValue<Person>(this._cacheId, out _));
	}
}
