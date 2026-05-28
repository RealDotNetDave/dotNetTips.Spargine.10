// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 05-14-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="AssemblyExtensionsHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
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

	/// <summary>
	/// Determines whether a type should be skipped during instance discovery.
	/// A type is skipped when it is abstract, an interface, a generic type definition,
	/// or not assignable to <paramref name="targetType"/>.
	/// </summary>
	/// <param name="type">The candidate type to evaluate.</param>
	/// <param name="targetType">The target type that the candidate must be assignable to.</param>
	/// <returns><c>true</c> if the type should be skipped; otherwise <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool ShouldSkipType(Type type, Type targetType) =>
		type.IsAbstract || type.IsInterface || type.IsGenericTypeDefinition || !targetType.IsAssignableFrom(type);

	/// <summary>
	/// Attempts to create an instance of <paramref name="type"/> as <typeparamref name="T"/>.
	/// Returns <c>false</c> when the type has no parameterless constructor or instantiation fails.
	/// </summary>
	/// <typeparam name="T">The target type to cast the created instance to.</typeparam>
	/// <param name="type">The concrete type to instantiate.</param>
	/// <param name="instance">
	/// When this method returns <c>true</c>, contains the created instance; otherwise <c>null</c>.
	/// </param>
	/// <returns><c>true</c> if an instance was successfully created; otherwise <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("Creates an instance via Activator.CreateInstance(Type), which requires the parameterless constructor of the target type to be preserved by the trimmer.")]
	internal static bool TryCreateInstance<T>([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] Type type, [NotNullWhen(true)] out T? instance) where T : class
	{
		if (type.GetConstructor(Type.EmptyTypes) is null)
		{
			instance = null;
			return false;
		}

		try
		{
			instance = Activator.CreateInstance(type) as T;
			return instance is not null;
		}
		catch (MissingMethodException)
		{
			instance = null;
			return false;
		}
		catch (MemberAccessException)
		{
			instance = null;
			return false;
		}
		catch (TargetInvocationException)
		{
			instance = null;
			return false;
		}
	}
}
