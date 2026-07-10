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
// Thread-safe cache for parsed <see cref="CompositeFormat"/> instances used by
// resource and formatting helpers.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Text;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a thread-safe cache of pre-parsed <see cref="CompositeFormat"/> instances.
/// Parsing a composite format string is an allocating operation; caching the result ensures
/// each unique format string is parsed exactly once across the lifetime of the process.
/// </summary>
[Information("ResourceFormatCache", "Copilot Agent", "07-09-2026", Status = Status.New)]
internal static class ResourceFormatCache
{
	private static readonly ConcurrentDictionary<string, CompositeFormat> _cache = new(StringComparer.Ordinal);

	/// <summary>
	/// Returns the cached <see cref="CompositeFormat"/> for the given <paramref name="format"/> string,
	/// parsing and caching it on first use.
	/// </summary>
	/// <param name="format">The composite format string to look up or parse. Must not be <see langword="null"/> or empty.</param>
	/// <returns>A <see cref="CompositeFormat"/> instance parsed from <paramref name="format"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="format"/> is <see langword="null"/> or empty.</exception>
	[Information(nameof(GetOrAdd), "Copilot Agent", "07-09-2026", UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	internal static CompositeFormat GetOrAdd([DisallowNull] string format)
	{
		format = format.ArgumentNotNullOrEmpty();

		return _cache.GetOrAdd(format, static value => CompositeFormat.Parse(value));
	}
}
