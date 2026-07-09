// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="ResourceFormatCache.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Thread-safe cache for resource format strings. Returns cached format strings
// so callers (or CompositeFormat.Parse) can parse them once if needed.
// </summary>
// ***********************************************************************
using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Core;

[Information(Status = Status.New)]
internal static class ResourceFormatCache
{
	private static readonly ConcurrentDictionary<string, string> _cache = new(StringComparer.Ordinal);

	[Information(nameof(GetOrAddString), "Copilot Agent", "07-09-2026", UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	internal static string GetOrAddString([DisallowNull] string format)
	{
		format = format.ArgumentNotNullOrEmpty();

		return _cache.GetOrAdd(format, static value => value);
	}
}
