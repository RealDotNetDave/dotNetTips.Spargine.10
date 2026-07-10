// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="ResourceFormatCacheTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for ResourceFormatCache.
// </summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ResourceFormatCacheTests
{

	[TestMethod]
	public void GetOrAdd_Null_ThrowsArgumentNullException()
	{
		var method = GetMethod();
		var ex = Assert.ThrowsExactly<TargetInvocationException>(() => method.Invoke(null, new object?[] { null }));

		Assert.IsInstanceOfType(ex.InnerException, typeof(ArgumentNullException));
	}

	[TestMethod]
	public void GetOrAdd_SameValueReturnsCachedInstance()
	{
		var method = GetMethod();
		var firstFormat = new string("Value: {0:N2}".ToCharArray());
		var secondFormat = new string("Value: {0:N2}".ToCharArray());

		var first = method.Invoke(null, new object[] { firstFormat });
		var second = method.Invoke(null, new object[] { secondFormat });

		Assert.IsNotNull(first);
		Assert.IsNotNull(second);
		Assert.AreSame(first, second);
		Assert.IsInstanceOfType(first, typeof(CompositeFormat));
	}

	[TestMethod]
	public void GetOrAddString_Empty_ThrowsArgumentException()
	{
		var method = GetMethod();
		var ex = Assert.ThrowsExactly<TargetInvocationException>(() => method.Invoke(null, new object[] { string.Empty }));

		Assert.IsInstanceOfType(ex.InnerException, typeof(ArgumentException));
	}

	private static MethodInfo GetMethod()
	{
		var cacheType = AppDomain.CurrentDomain.GetAssemblies()
			.SelectMany(a => a.GetTypesSafe())
			.FirstOrDefault(t => string.Equals(t.FullName, "DotNetTips.Spargine.Core.ResourceFormatCache", StringComparison.Ordinal));

		Assert.IsNotNull(cacheType, "ResourceFormatCache type should be present in loaded assemblies.");

		var method = cacheType.GetMethod("GetOrAdd", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
		Assert.IsNotNull(method, "GetOrAdd method should be found on ResourceFormatCache.");

		return method;
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
