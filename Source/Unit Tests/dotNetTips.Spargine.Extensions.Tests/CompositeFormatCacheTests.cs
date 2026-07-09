// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="CompositeFormatCacheTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class CompositeFormatCacheTests
{
	[TestMethod]
	public void GetOrAdd_CachesParsedCompositeFormat()
	{
		// Arrange
		var format = "Value: {0:N2}";

		// Locate the internal CompositeFormatCache type via loaded assemblies
		var cacheType = AppDomain.CurrentDomain.GetAssemblies()
			.SelectMany(a => a.GetTypesSafe())
			.FirstOrDefault(t => string.Equals(t.FullName, "DotNetTips.Spargine.Extensions.CompositeFormatCache", StringComparison.Ordinal));

		Assert.IsNotNull(cacheType, "CompositeFormatCache type should be present in loaded assemblies.");

		var method = cacheType.GetMethod("GetOrAdd", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
		Assert.IsNotNull(method, "GetOrAdd method should be found on CompositeFormatCache.");

		// Act
		var first = method.Invoke(null, new object[] { format });
		var second = method.Invoke(null, new object[] { format });

		// Assert
		Assert.IsNotNull(first);
		Assert.IsNotNull(second);
		// Ensure cached instances are the same reference for identical format strings.
		Assert.IsTrue(ReferenceEquals(first, second), "Cached instances should be the same reference for identical format strings.");
	}
}

internal static class ReflectionHelpers
{
	public static IEnumerable<Type> GetTypesSafe(this Assembly assembly)
	{
		try
		{
			return assembly.GetTypes();
		}
		catch (ReflectionTypeLoadException ex)
		{
			return ex.Types.Where(t => t != null)!;
		}
	}
}
