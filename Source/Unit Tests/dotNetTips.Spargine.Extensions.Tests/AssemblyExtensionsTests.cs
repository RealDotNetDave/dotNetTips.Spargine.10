// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-20-2026
// ***********************************************************************
// <copyright file="AssemblyExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

/// <summary>
/// Marker interface used to exercise the <see cref="MissingMethodException"/> catch path
/// in <c>AssemblyExtensions.GetInstances&lt;T&gt;</c>.
/// </summary>
internal interface INoDefaultCtor { }

/// <summary>
/// A concrete, non-abstract, non-generic type that implements <see cref="INoDefaultCtor"/> but
/// intentionally omits a parameterless constructor so that <see cref="Activator.CreateInstance(Type)"/>
/// throws a <see cref="MissingMethodException"/>.
/// </summary>
internal sealed class NoDefaultCtorImpl : INoDefaultCtor
{
	internal NoDefaultCtorImpl(string value) { _ = value; }
}

[ExcludeFromCodeCoverage]
[TestClass]
public class AssemblyExtensionsTests
{

	[TestMethod]
	public void GetAllInterfaces_NullAssembly_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ((Assembly)null).GetAllInterfaces());
	}

	[TestMethod]
	public void GetAllInterfaces_ReturnsUniqueInterfaces()
	{
		var assembly = Assembly.GetExecutingAssembly();
		var interfaces = assembly.GetAllInterfaces();

		Assert.HasCount(interfaces.Distinct().Count(), interfaces);
	}

	[TestMethod]
	public void GetAllInterfaces_ValidAssembly_AllResultsAreInterfaces()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetAllInterfaces();

		Assert.IsNotEmpty(result);
		Assert.IsTrue(result.All(t => t.IsInterface));
	}

	[TestMethod]
	public void GetAllTypes_NullAssembly_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ((Assembly)null).GetAllTypes());
	}

	[TestMethod]
	public void GetAllTypes_ValidAssembly_ExcludesAbstractTypes()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetAllTypes();

		Assert.IsNotEmpty(result);
		Assert.IsTrue(result.All(t => !t.IsAbstract));
	}

	[TestMethod]
	public void GetAllTypesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetAllTypes();

		Assert.IsGreaterThanOrEqualTo(1, result.Count);
	}

	[TestMethod]
	public void GetInstances_NullAssembly_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ((Assembly)null).GetInstances<AssemblyExtensionsTests>().ToList());
	}

	[TestMethod]
	public void GetInstances_NoMatchingType_ReturnsEmpty()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetInstances<Stream>().ToList();

		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetInstances_ValidAssembly_ReturnsCorrectInstanceType()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetInstances<AssemblyExtensionsTests>().ToList();

		Assert.IsNotEmpty(result);
		Assert.IsTrue(result.All(i => i is AssemblyExtensionsTests));
	}

	[TestMethod]
	public void GetInstances_TypeWithNoParameterlessConstructor_SkipsType()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetInstances<INoDefaultCtor>().ToList();

		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetInstancesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsTests>();

		Assert.AreEqual(1, result.Count());
	}

	[TestMethod]
	public void GetInterfacesTest()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetAllInterfaces().ToList();

		Assert.IsNotEmpty(result);
	}

	[TestMethod]
	public void GetTypes_NullAssembly_ThrowsArgumentNullException()
	{
		// Arrange
		var type = typeof(AssemblyExtensionsTests);

		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ((Assembly)null).GetTypes(type));
	}

	[TestMethod]
	public void GetTypes_NullType_ThrowsArgumentNullException()
	{
		// Arrange
		var assembly = Assembly.GetExecutingAssembly();

		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => assembly.GetTypes(null));
	}

	[TestMethod]
	public void GetTypes_NoMatchingType_ReturnsEmptyCollection()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetTypes(typeof(Stream));

		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetTypes_ValidInputs_AllResultsAreNonAbstractAndAssignable()
	{
		var assembly = Assembly.GetExecutingAssembly();
		var targetType = typeof(AssemblyExtensionsTests);

		var result = assembly.GetTypes(targetType);

		Assert.IsNotEmpty(result);
		Assert.IsTrue(result.All(t => !t.IsAbstract && targetType.IsAssignableFrom(t)));
	}

	[TestMethod]
	public void GetTypes_ValidInputs_ReturnsTypes()
	{
		// Arrange
		var assembly = Assembly.GetExecutingAssembly();
		var type = typeof(AssemblyExtensionsTests);

		// Act
		var result = assembly.GetTypes(type);

		// Assert
		Assert.IsNotEmpty(result);
		Assert.Contains(type, result);
	}

	[TestMethod]
	public void GetTypesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetTypes();

		Assert.IsGreaterThan(0, result.FastLongCount());
	}

}
