// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
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
using System.Text;

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public sealed class CompositeFormatCacheTests
{
	[TestMethod]
	public void GetOrAdd_CachesParsedCompositeFormat()
	{
		const string format = "Value: {0:N2}";

		var first = InvokeGetOrAdd(format);
		var second = InvokeGetOrAdd(format);

		Assert.IsNotNull(first);
		Assert.IsNotNull(second);
		Assert.IsTrue(ReferenceEquals(first, second), "Cached instances should be the same reference for identical format strings.");
	}

	[TestMethod]
	public void GetOrAdd_EmptyFormat_ThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<TargetInvocationException>(() => InvokeGetOrAdd(string.Empty));

		Assert.IsInstanceOfType<ArgumentNullException>(exception.InnerException);
	}

	[TestMethod]
	public void GetOrAdd_NewFormat_ReturnsParsedCompositeFormat()
	{
		const string format = "Count: {0:D2}";

		var result = InvokeGetOrAdd(format);
		var formatted = string.Format(provider: null, format: result, 7);

		Assert.AreEqual("Count: 07", formatted);
	}

	[TestMethod]
	public void GetOrAdd_NullFormat_ThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<TargetInvocationException>(() => InvokeGetOrAdd(null));

		Assert.IsInstanceOfType<ArgumentNullException>(exception.InnerException);
	}

	private static MethodInfo GetGetOrAddMethod()
	{
		var cacheType = AppDomain.CurrentDomain.GetAssemblies()
			.SelectMany(static assembly => assembly.GetTypesSafe())
			.FirstOrDefault(static type => string.Equals(type.FullName, "DotNetTips.Spargine.Extensions.CompositeFormatCache", StringComparison.Ordinal));

		Assert.IsNotNull(cacheType, "CompositeFormatCache type should be present in loaded assemblies.");

		var method = cacheType.GetMethod("GetOrAdd", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);

		Assert.IsNotNull(method, "GetOrAdd method should be found on CompositeFormatCache.");

		return method;
	}

	private static CompositeFormat InvokeGetOrAdd(string? format)
	{
		var method = GetGetOrAddMethod();

		return (CompositeFormat)method.Invoke(null, [format]);
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
