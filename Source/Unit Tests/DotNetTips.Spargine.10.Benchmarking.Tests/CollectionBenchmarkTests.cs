// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking.Tests
// Author           : Copilot Agent
// Created          : 09-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-08-2026
// ***********************************************************************
// <copyright file="CollectionBenchmarkTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Verifies collection benchmark construction through the shared benchmark base.
// </summary>
// ***********************************************************************
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Benchmarking.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public sealed class CollectionBenchmarkTests
{
	[TestMethod]
	public void ConstructorNonpositiveCountUsesMinimumCount()
	{
		Assert.AreEqual(2, new TestCollectionBenchmark(0).MaxCount);
	}

	private sealed class TestCollectionBenchmark(int maxCount) : CollectionBenchmark(maxCount);
}
