// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 05-14-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-20-2026
// ***********************************************************************
// <copyright file="AssemblyExtensionsHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Internal helper providing assembly type-loading, type-filtering, and instance-creation
// utilities for <see cref="AssemblyExtensions"/>.
// </summary>
// ***********************************************************************

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Internal helper providing assembly type-loading, type-filtering, and instance-creation utilities
/// for <see cref="AssemblyExtensions"/>.
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
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
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

	/// <summary>
	/// Determines whether the specified <paramref name="type"/> should be skipped during instance discovery
	/// for a target type <paramref name="targetType"/>.
	/// </summary>
	/// <param name="type">The candidate type to evaluate.</param>
	/// <param name="targetType">The target type that the candidate must be assignable to.</param>
	/// <returns>
	/// <see langword="true"/> if the type is an interface, abstract, generic, or not assignable to
	/// <paramref name="targetType"/>; otherwise, <see langword="false"/>.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool ShouldSkipType(Type type, Type targetType) =>
		type.IsInterface || type.IsAbstract || type.IsGenericType || !targetType.IsAssignableFrom(type);

	/// <summary>
	/// Attempts to create an instance of <paramref name="type"/> and cast it to <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The target reference type.</typeparam>
	/// <param name="type">The concrete type to instantiate.</param>
	/// <param name="instance">
	/// When this method returns <see langword="true"/>, contains the created instance cast to
	/// <typeparamref name="T"/>; otherwise, <see langword="null"/>.
	/// </param>
	/// <returns>
	/// <see langword="true"/> if the instance was successfully created and cast to <typeparamref name="T"/>;
	/// <see langword="false"/> if a <see cref="MissingMethodException"/> is thrown (no parameterless constructor)
	/// or if the created object cannot be cast to <typeparamref name="T"/>.
	/// </returns>
	[RequiresUnreferencedCode("Uses Activator.CreateInstance which requires constructor metadata to be preserved.")]
	internal static bool TryCreateInstance<T>([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] Type type, [NotNullWhen(true)] out T? instance) where T : class
	{
		try
		{
			instance = Activator.CreateInstance(type) as T;
			return instance is not null;
		}
		catch (MissingMethodException ex)
		{
			Trace.WriteLine(ex.Message);
			instance = null;
			return false;
		}
	}
}
