// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="RegistryHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Helper methods for working with the Windows Registry.</summary>
// ***********************************************************************
using System.Runtime.Versioning;
using Microsoft.Win32;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Win32;

/// <summary>
/// Provides helper methods for working with the Windows Registry.
/// </summary>
[SupportedOSPlatform("windows")]
public static class RegistryHelper
{

	/// <summary>
	/// The registry key path for the current user's OneDrive configuration.
	/// </summary>
	public const string KeyCurrentUserOneDrive = @"SOFTWARE\Microsoft\OneDrive";

	/// <summary>
	/// Gets a <see cref="RegistryKey"/> for the specified path under the given <see cref="RegistryHive"/>.
	/// </summary>
	/// <param name="keyPath">The registry key path to open.</param>
	/// <param name="hive">The registry hive to open the key from.</param>
	/// <returns>The opened <see cref="RegistryKey"/>, or <see langword="null"/> if the key does not exist.</returns>
	public static RegistryKey? GetRegistryKey(string keyPath, RegistryHive hive)
	{
		using var baseKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default);
		return baseKey.OpenSubKey(keyPath);
	}

}
