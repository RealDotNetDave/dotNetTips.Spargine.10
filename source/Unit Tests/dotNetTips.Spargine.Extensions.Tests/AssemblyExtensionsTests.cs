// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="AssemblyExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

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
	public void GetAllTypes_NullAssembly_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => ((Assembly)null).GetAllTypes());
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
