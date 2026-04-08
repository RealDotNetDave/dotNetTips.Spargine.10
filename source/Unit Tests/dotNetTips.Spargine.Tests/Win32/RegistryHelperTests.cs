// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : Copilot Agent
// Created          : 04-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="RegistryHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>Unit tests for RegistryHelper methods.</summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.Win32;

[ExcludeFromCodeCoverage]
[SupportedOSPlatform("windows")]
[TestClass]
public class RegistryHelperTests
{

	[TestMethod]
	public void KeyCurrentUserOneDriveHasExpectedValue()
	{
		// Assert
		Assert.AreEqual(@"SOFTWARE\Microsoft\OneDrive", RegistryHelper.KeyCurrentUserOneDrive);
	}

	[TestMethod]
	public void GetRegistryKeyValidPathLocalMachineReturnsKey()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("Registry requires Windows.");
			return;
		}

		// Arrange
		const string keyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";

		// Act
		using var result = RegistryHelper.GetRegistryKey(keyPath, RegistryHive.LocalMachine);

		// Assert
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetRegistryKeyValidPathCurrentUserReturnsKey()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("Registry requires Windows.");
			return;
		}

		// Arrange
		const string keyPath = @"SOFTWARE\Microsoft";

		// Act
		using var result = RegistryHelper.GetRegistryKey(keyPath, RegistryHive.CurrentUser);

		// Assert
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetRegistryKeyNonExistentPathReturnsNull()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("Registry requires Windows.");
			return;
		}

		// Arrange
		const string keyPath = @"SOFTWARE\NonExistentKey12345\DoesNotExist";

		// Act
		using var result = RegistryHelper.GetRegistryKey(keyPath, RegistryHive.LocalMachine);

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetRegistryKeyNonExistentPathCurrentUserReturnsNull()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("Registry requires Windows.");
			return;
		}

		// Arrange
		const string keyPath = @"SOFTWARE\NonExistentKey12345\DoesNotExist";

		// Act
		using var result = RegistryHelper.GetRegistryKey(keyPath, RegistryHive.CurrentUser);

		// Assert
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetRegistryKeyReturnedKeyHasSubKeys()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("Registry requires Windows.");
			return;
		}

		// Arrange
		const string keyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";

		// Act
		using var result = RegistryHelper.GetRegistryKey(keyPath, RegistryHive.LocalMachine);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.SubKeyCount > 0);
	}

	[TestMethod]
	public void GetRegistryKeyReturnedKeyHasValueNames()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("Registry requires Windows.");
			return;
		}

		// Arrange
		const string keyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";

		// Act
		using var result = RegistryHelper.GetRegistryKey(keyPath, RegistryHive.LocalMachine);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.ValueCount > 0);
	}

	[TestMethod]
	public void GetRegistryKeyEmptyPathReturnsKey()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("Registry requires Windows.");
			return;
		}

		// Arrange - empty string opens the hive root
		const string keyPath = "";

		// Act
		using var result = RegistryHelper.GetRegistryKey(keyPath, RegistryHive.LocalMachine);

		// Assert - root key should be accessible
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetRegistryKeyNonWindowsThrowsPlatformNotSupportedException()
	{
		if (OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("This test validates non-Windows behavior.");
			return;
		}

		// Act & Assert
		Assert.ThrowsExactly<PlatformNotSupportedException>(
			() => RegistryHelper.GetRegistryKey(@"SOFTWARE\Microsoft", RegistryHive.LocalMachine));
	}

}
