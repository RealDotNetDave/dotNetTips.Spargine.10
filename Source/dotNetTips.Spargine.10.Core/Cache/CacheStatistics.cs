
// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 12-30-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2026
// ***********************************************************************
// <copyright file="CacheStatistics.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Cache;

/// <summary>
/// Represents cache statistics and metrics.
/// </summary>
[Information(nameof(CacheStatistics), "David McCarter", "12/30/2025", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
public record class CacheStatistics
{

	/// <summary>
	/// Gets or sets the total number of cache hits.
	/// </summary>
	public long CacheHits { get; init; }

	/// <summary>
	/// Gets or sets the total number of cache misses.
	/// </summary>
	public long CacheMisses { get; init; }

	/// <summary>
	/// Gets or sets the compaction percentage used when cache size limit is exceeded.
	/// </summary>
	public double CompactionPercentage { get; init; }

	/// <summary>
	/// Gets the cache hit ratio (hits / total requests).
	/// </summary>
	public double HitRatio
	{
		get
		{
			var total = this.CacheHits + this.CacheMisses;
			return total == 0 ? 0 : (double)this.CacheHits / total;
		}
	}
	/// <summary>
	/// Gets or sets the total number of items currently in the cache.
	/// </summary>
	public int TotalItems { get; init; }
}
