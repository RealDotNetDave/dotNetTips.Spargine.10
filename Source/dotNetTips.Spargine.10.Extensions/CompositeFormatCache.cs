// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="CompositeFormatCache.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Caches parsed <see cref="CompositeFormat"/> instances for reuse.</summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides cached access to parsed <see cref="CompositeFormat"/> instances.
/// </summary>
[Information(Status = Status.Available)]
internal static class CompositeFormatCache
{
	private static readonly ConcurrentDictionary<string, CompositeFormat> _cache = new(StringComparer.Ordinal);

	/// <summary>
	/// Gets a cached <see cref="CompositeFormat"/> for the supplied <paramref name="format"/>.
	/// </summary>
	/// <param name="format">The composite format string to parse and cache.</param>
	/// <returns>The cached <see cref="CompositeFormat"/> instance.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="format"/> is <see langword="null"/>.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="format"/> is empty or whitespace.</exception>
	[Information(nameof(GetOrAdd), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	internal static CompositeFormat GetOrAdd([DisallowNull] string format)
	{
		format = format.ArgumentNotNullOrEmpty();

		return _cache.GetOrAdd(format, static value => CompositeFormat.Parse(value));
	}
}
