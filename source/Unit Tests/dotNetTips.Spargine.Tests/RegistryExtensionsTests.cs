// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : Copilot Agent
// Created          : 04-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="RegistryExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Unit tests for RegistryExtensions.GetSubKey and RegistryExtensions.GetValue methods.</summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests;

[ExcludeFromCodeCoverage]
[SupportedOSPlatform("windows")]
[TestClass]
public class RegistryExtensionsTests
{

	// Well-known registry path available on all Windows installations.
	private const string WindowsNTCurrentVersionPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
	private const string ProductNameValue = "ProductName";

	[TestMethod]
	public void GetSubKey_ValidKeyAndName_ReturnsSubKey()
	{
		// Arrange
		using var baseKey = Registry.LocalMachine;

		// Act
		using var result = baseKey.GetSubKey(WindowsNTCurrentVersionPath);

		// Assert
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetSubKey_NonExistentSubKey_ReturnsNull()
	{
		// Arrange
		using var baseKey = Registry.LocalMachine;

		// Act
		using var result = baseKey.GetSubKey(@"SOFTWARE\NonExistentKey12345");

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetSubKey_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		RegistryKey key = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => key.GetSubKey("test"));
	}

	[TestMethod]
	public void GetSubKey_NullName_ThrowsArgumentNullException()
	{
		// Arrange
		using var baseKey = Registry.LocalMachine;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => baseKey.GetSubKey(null!));
	}

	[TestMethod]
	public void GetSubKey_EmptyName_ThrowsArgumentNullException()
	{
		// Arrange
		using var baseKey = Registry.LocalMachine;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => baseKey.GetSubKey(string.Empty));
	}

	[TestMethod]
	public void GetValue_ValidKeyAndName_ReturnsValue()
	{
		// Arrange
		using var key = Registry.LocalMachine.OpenSubKey(WindowsNTCurrentVersionPath);

		Assert.IsNotNull(key, "Could not open Windows NT CurrentVersion registry key.");

		// Act
		var result = key.GetValue<string>(ProductNameValue);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void GetValue_NonExistentValueName_ReturnsDefault()
	{
		// Arrange
		using var key = Registry.LocalMachine.OpenSubKey(WindowsNTCurrentVersionPath);

		Assert.IsNotNull(key, "Could not open Windows NT CurrentVersion registry key.");

		// Act
		var result = key.GetValue<string>("NonExistentValueName12345");

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetValue_IntegerValue_ReturnsCorrectType()
	{
		// Arrange
		using var key = Registry.LocalMachine.OpenSubKey(WindowsNTCurrentVersionPath);

		Assert.IsNotNull(key, "Could not open Windows NT CurrentVersion registry key.");

		// Act - InstallDate is a REG_DWORD (int) on all Windows installations
		var result = key.GetValue<int>("InstallDate");

		// Assert
		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void GetValue_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		RegistryKey key = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => key.GetValue<string>("test"));
	}

	[TestMethod]
	public void GetValue_NullName_ThrowsArgumentNullException()
	{
		// Arrange
		using var key = Registry.LocalMachine.OpenSubKey(WindowsNTCurrentVersionPath);

		Assert.IsNotNull(key, "Could not open Windows NT CurrentVersion registry key.");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => key.GetValue<string>(null!));
	}

	[TestMethod]
	public void GetValue_EmptyName_ThrowsArgumentNullException()
	{
		// Arrange
		using var key = Registry.LocalMachine.OpenSubKey(WindowsNTCurrentVersionPath);

		Assert.IsNotNull(key, "Could not open Windows NT CurrentVersion registry key.");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => key.GetValue<string>(string.Empty));
	}
}
