// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 03-31-2026
//
// Last Modified By : David McCarter
// Last Modified On : 03-31-2026
// ***********************************************************************
// <copyright file="CacheStatisticsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Cache;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Cache;

[ExcludeFromCodeCoverage]
[TestClass]
public class CacheStatisticsTests
{

	[TestMethod]
	public void CacheStatistics_DefaultConstruction_HasDefaultValues()
	{
		// Arrange & Act
		var stats = new CacheStatistics();

		// Assert
		Assert.AreEqual(0, stats.CacheHits);
		Assert.AreEqual(0, stats.CacheMisses);
		Assert.AreEqual(0.0, stats.CompactionPercentage);
		Assert.AreEqual(0, stats.TotalItems);
	}

	[TestMethod]
	public void CacheStatistics_PropertyInitialization_SetsAllProperties()
	{
		// Arrange & Act
		var stats = new CacheStatistics
		{
			CacheHits = 100,
			CacheMisses = 50,
			CompactionPercentage = 0.5,
			TotalItems = 25
		};

		// Assert
		Assert.AreEqual(100, stats.CacheHits);
		Assert.AreEqual(50, stats.CacheMisses);
		Assert.AreEqual(0.5, stats.CompactionPercentage);
		Assert.AreEqual(25, stats.TotalItems);
	}

	[TestMethod]
	public void Equality_DifferentValues_AreNotEqual()
	{
		// Arrange
		var stats1 = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};
		var stats2 = new CacheStatistics
		{
			CacheHits = 20,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};

		// Act & Assert
		Assert.AreNotEqual(stats1, stats2);
	}

	[TestMethod]
	public void Equality_SameValues_AreEqual()
	{
		// Arrange
		var stats1 = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};
		var stats2 = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};

		// Act & Assert
		Assert.AreEqual(stats1, stats2);
	}

	[TestMethod]
	public void GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		// Arrange
		var stats1 = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};
		var stats2 = new CacheStatistics
		{
			CacheHits = 20,
			CacheMisses = 10,
			CompactionPercentage = 0.75,
			TotalItems = 30
		};

		// Act & Assert
		Assert.AreNotEqual(stats1.GetHashCode(), stats2.GetHashCode());
	}

	[TestMethod]
	public void GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var stats1 = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};
		var stats2 = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};

		// Act & Assert
		Assert.AreEqual(stats1.GetHashCode(), stats2.GetHashCode());
	}

	[TestMethod]
	public void HitRatio_CalculatesCorrectRatio()
	{
		// Arrange
		var stats = new CacheStatistics
		{
			CacheHits = 75,
			CacheMisses = 25
		};

		// Act
		var result = stats.HitRatio;

		// Assert
		Assert.AreEqual(0.75, result, 0.001);
	}

	[TestMethod]
	public void HitRatio_WhenEqualHitsAndMisses_ReturnsHalf()
	{
		// Arrange
		var stats = new CacheStatistics
		{
			CacheHits = 50,
			CacheMisses = 50
		};

		// Act
		var result = stats.HitRatio;

		// Assert
		Assert.AreEqual(0.5, result, 0.001);
	}

	[TestMethod]
	public void HitRatio_WhenNoRequests_ReturnsZero()
	{
		// Arrange
		var stats = new CacheStatistics
		{
			CacheHits = 0,
			CacheMisses = 0
		};

		// Act
		var result = stats.HitRatio;

		// Assert
		Assert.AreEqual(0.0, result);
	}

	[TestMethod]
	public void HitRatio_WhenOnlyHits_ReturnsOne()
	{
		// Arrange
		var stats = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 0
		};

		// Act
		var result = stats.HitRatio;

		// Assert
		Assert.AreEqual(1.0, result);
	}

	[TestMethod]
	public void HitRatio_WhenOnlyMisses_ReturnsZero()
	{
		// Arrange
		var stats = new CacheStatistics
		{
			CacheHits = 0,
			CacheMisses = 10
		};

		// Act
		var result = stats.HitRatio;

		// Assert
		Assert.AreEqual(0.0, result);
	}

	[TestMethod]
	public void ToString_ReturnsNonEmptyString()
	{
		// Arrange
		var stats = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};

		// Act
		var result = stats.ToString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Length > 0);
	}

	[TestMethod]
	public void WithExpression_CreatesModifiedCopy()
	{
		// Arrange
		var original = new CacheStatistics
		{
			CacheHits = 10,
			CacheMisses = 5,
			CompactionPercentage = 0.5,
			TotalItems = 15
		};

		// Act
		var modified = original with { CacheHits = 20 };

		// Assert
		Assert.AreEqual(20, modified.CacheHits);
		Assert.AreEqual(5, modified.CacheMisses);
		Assert.AreEqual(0.5, modified.CompactionPercentage);
		Assert.AreEqual(15, modified.TotalItems);
		Assert.AreNotEqual(original, modified);
	}
}
