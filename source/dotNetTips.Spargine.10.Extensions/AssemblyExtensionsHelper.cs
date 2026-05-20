// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 05-14-2026
//
// Last Modified By : David McCarter
// Last Modified On : 05-14-2026
// ***********************************************************************
// <copyright file="AssemblyExtensionsHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Internal helper providing assembly type-loading utilities for <see cref="AssemblyExtensions"/>.
/// </summary>
internal static class AssemblyExtensionsHelper
{
	/// <summary>
	/// Attempts to retrieve all types defined in the specified assembly, gracefully handling partial load failures.
	/// </summary>
	/// <param name="assembly">The assembly from which to load types. Must not be <c>null</c>.</param>
	/// <returns>
	/// An array of <see cref="Type"/> objects defined in <paramref name="assembly"/>.
	/// If a <see cref="ReflectionTypeLoadException"/> occurs, returns only the types that were successfully loaded,
	/// filtering out any <c>null</c> entries.
	/// </returns>
	[RequiresUnreferencedCode("Uses Assembly.GetTypes() which requires runtime type discovery.")]
	internal static Type[] GetLoadableTypes(Assembly assembly)
	{
		assembly = assembly.ArgumentNotNull();

		try
		{
			return assembly.GetTypes();
		}
		catch (ReflectionTypeLoadException ex)
		{
			return [.. ex.Types
				.Where(static type => type is not null)
				.Cast<Type>()];
		}
	}
}
