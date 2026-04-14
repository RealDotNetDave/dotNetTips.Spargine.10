// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 01-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-27-2026
// ***********************************************************************
// <copyright file="AssemblyExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Provides high-performance extension methods for <see cref="Assembly"/> supporting
// type discovery, interface extraction, and instance creation via reflection.
// </summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Reflection;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Assembly" /> to enhance functionality related to type discovery and instantiation.
/// </summary>
/// <remarks>
/// The <see cref="AssemblyExtensions"/> class contains methods that extend the functionality of the <see cref="Assembly" /> class,
/// making it easier to perform tasks such as getting all types, interfaces, or instances of a specific type within an assembly,
/// and filtering them based on various criteria. These methods are designed to simplify common reflection-based tasks.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineAssemblyExtensions")]
public static class AssemblyExtensions
{
	/// <summary>
	/// Provides extension methods for <see cref="Assembly"/> instances supporting type discovery and instantiation.
	/// </summary>
	/// <param name="assembly">The assembly instance to extend.</param>
	extension([DisallowNull] Assembly assembly)
	{
		/// <summary>
		/// Gets all interfaces defined in the specified assembly.
		/// </summary>
		/// <returns>A read-only collection of <see cref="Type" /> objects representing the interfaces defined in the specified assembly.</returns>
		/// <remarks>This method extracts all interfaces from the types defined in the specified assembly, ensuring no duplicates are returned.
		/// It validates that the provided assembly is not null before proceeding with the extraction.</remarks>
		/// <exception cref="ArgumentNullException">Thrown when <c>assembly</c> is null.</exception>
		[Pure]
		[return: NotNull]
		[RequiresUnreferencedCode("This method uses Assembly.GetTypes() and Type.GetInterfaces() which require runtime type discovery.")]
		[Information(nameof(GetAllInterfaces), "David McCarter", "1/7/2021", BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<Type> GetAllInterfaces()
		{
			assembly = assembly.ArgumentNotNull();

			var interfaces = new List<Type>();

			// USING SPAN CAUSES ISSUES.
			// FrozenSet is slower.
			// Recommendation from CoPilot is slower.
			var array = assembly.GetTypes();

			foreach (var arrayItem in array)
			{
				interfaces.AddRange(arrayItem.GetInterfaces());
			}

			return interfaces.Distinct().ToReadOnlyCollection();
		}

		/// <summary>
		/// Gets all non-abstract types in an <see cref="Assembly" />.
		/// </summary>
		/// <returns>A read-only collection of <see cref="Type" /> objects representing the non-abstract types defined in the specified assembly.</returns>
		/// <remarks>This method is useful for scenarios where you need to work with concrete types defined in an assembly,
		/// such as when creating instances or performing reflection-based processing.
		/// If a <see cref="ReflectionTypeLoadException"/> occurs, the method gracefully returns only the successfully loaded types.</remarks>
		/// <exception cref="ArgumentNullException">Thrown when <c>assembly</c> is null.</exception>
		[Pure]
		[return: NotNull]
		[RequiresUnreferencedCode("This method uses Assembly.GetTypes() which requires runtime type discovery.")]
		[Information(nameof(GetAllTypes), "David McCarter", "1/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<Type> GetAllTypes()
		{
			assembly = assembly.ArgumentNotNull();

			var types = assembly.GetTypes();
			var result = new List<Type>(types.Length);

			foreach (var type in types)
			{
				if (!type.IsAbstract)
				{
					result.Add(type);
				}
			}

			return result.ToReadOnlyCollection();
		}

		/// <summary>
		/// Gets all instances of a specified type <typeparamref name="T" /> within the assembly.
		/// </summary>
		/// <typeparam name="T">The type of instances to find. This type must be a class with a parameterless constructor.</typeparam>
		/// <returns>An enumerable of instances of the specified type <typeparamref name="T" />.</returns>
		/// <remarks>
		/// This method searches the assembly for non-abstract, non-generic types that are assignable to <typeparamref name="T" />
		/// and attempts to create an instance of each using <see cref="Activator.CreateInstance(Type)"/>.
		/// Types that lack a parameterless constructor are skipped and logged via <see cref="Trace.WriteLine(string?)"/>.
		/// If a <see cref="ReflectionTypeLoadException"/> occurs during type discovery, only the successfully loaded types are processed.
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when <c>assembly</c> is null.</exception>
		[Pure]
		[return: NotNull]
		[RequiresUnreferencedCode("This method uses Assembly.GetTypes() and Activator.CreateInstance() which require runtime type discovery.")]
		[Information(nameof(GetInstances), "David McCarter", "1/7/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<T> GetInstances<T>() where T : class
		{
			assembly = assembly.ArgumentNotNull();

			var types = assembly.GetTypes();
			var targetType = typeof(T);

			foreach (var type in types)
			{
				if (!type.IsInterface && !type.IsAbstract && !type.IsGenericType && targetType.IsAssignableFrom(type))
				{
					if (Activator.CreateInstance(type) is T instance)
					{
						yield return instance;
					}
				}
			}
		}

		/// <summary>
		/// Gets the types from the specified assembly that are assignable to the specified type and are not abstract.
		/// </summary>
		/// <param name="type">The type to match against assignable types in the assembly.</param>
		/// <returns>A read-only collection of types that are assignable to the specified type and are not abstract.</returns>
		/// <remarks>This method is useful for finding all concrete implementations or subclasses of a given type within an assembly.
		/// Original code from: oqtane.framework</remarks>
		/// <exception cref="ArgumentNullException">Thrown when <c>assembly</c> or <paramref name="type"/> is null.</exception>
		[Pure]
		[return: NotNull]
		[RequiresUnreferencedCode("This method uses Assembly.GetTypes() which requires runtime type discovery.")]
		[Information(nameof(GetTypes), "David McCarter", "1/7/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<Type> GetTypes([DisallowNull] Type type)
		{
			assembly = assembly.ArgumentNotNull();
			type = type.ArgumentNotNull();

			var types = assembly.GetTypes();
			var result = new List<Type>(types.Length);

			foreach (var t in types)
			{
				if (!t.IsAbstract && type.IsAssignableFrom(t))
				{
					result.Add(t);
				}
			}

			return result.ToReadOnlyCollection();

		}
	}
}
