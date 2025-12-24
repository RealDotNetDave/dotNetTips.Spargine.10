// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-14-2025
// ***********************************************************************
// <copyright file="RegistryExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Helper methods to access the Windows Registration Database</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using Microsoft.Win32;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for working with the Windows Registry. These methods extend the <see cref="RegistryKey"/> class,
/// allowing for simplified access to registry keys and values with additional safety checks and platform compatibility considerations.
/// </summary>
/// <remarks>
/// The methods in this class are designed to be used on Windows platforms only. Attempts to use these methods on non-Windows platforms
/// will result in a <see cref="PlatformNotSupportedException"/>.
/// </remarks>
[SupportedOSPlatform("windows")]
[Information(Status = Status.NeedsDocumentation)]
public static class RegistryExtensions
{

	/// <summary>
	/// Gets the registry key sub key.
	/// </summary>
	/// <param name="key">The key.</param>
	/// <param name="name">The name.</param>
	/// <returns>RegistryKey.</returns>
	/// <exception cref="PlatformNotSupportedException"></exception>
	[Information(nameof(GetSubKey), author: "David McCarter", createdOn: "3/1/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static RegistryKey? GetSubKey([NotNull] this RegistryKey key, [NotNull] in string name)
	{
		key = key.ArgumentNotNull();
		_ = name.CheckIsNotNullOrEmpty(throwException: true);

		return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? key.OpenSubKey(name) : throw new PlatformNotSupportedException();
	}

	/// <summary>
	/// Gets the registry key value.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="key">The key.</param>
	/// <param name="name">The name.</param>
	/// <returns>T.</returns>
	/// <exception cref="PlatformNotSupportedException"></exception>
	[Information(nameof(GetValue), author: "David McCarter", createdOn: "3/1/2021", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T? GetValue<T>([NotNull] this RegistryKey key, string name)
	{
		key = key.ArgumentNotNull();
		_ = name.CheckIsNotNullOrEmpty(throwException: true);

		var returnValue = default(T);

		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			var keyValue = key.GetValue(name);

			if (keyValue is not null)
			{
				returnValue = (T)keyValue;
			}

			return returnValue;
		}
		else
		{
			throw new PlatformNotSupportedException();
		}
	}

}
