// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 10-21-2025
// ***********************************************************************
// <copyright file="TypeExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods for general types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Type"/> to enhance and simplify its usage.
/// </summary>
[Information(Documentation = "https://bit.ly/SpargineTypeExtension", Status = Status.UpdateDocumentation)]
public static class TypeExtensions
{

	/// <summary>
	/// Gets a custom attribute of the specified type from the given method.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="methodInfo">The method to inspect.</param>
	/// <returns>The custom attribute of type <typeparamref name="TAttribute"/> if found; otherwise, null.</returns>
	[return: MaybeNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetAttribute), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public static TAttribute GetAttribute<TAttribute>([DisallowNull] this MethodInfo methodInfo) where TAttribute : Attribute
	{
		return TypeHelper.GetAttribute<TAttribute>(methodInfo);
	}

	/// <summary>
	/// Gets a custom attribute of the specified type from the given property.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="propertyInfo">The property to inspect.</param>
	/// <returns>The custom attribute of type <typeparamref name="TAttribute"/> if found; otherwise, null.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the propertyInfo is null.</exception>
	[return: MaybeNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public static TAttribute GetAttribute<TAttribute>([DisallowNull] this PropertyInfo propertyInfo) where TAttribute : Attribute
	{
		return TypeHelper.GetAttribute<TAttribute>(propertyInfo);
	}

	/// <summary>
	/// Gets a custom attribute of the specified type from the given field.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="fieldInfo">The field to inspect.</param>
	/// <returns>
	/// The custom attribute of type <typeparamref name="TAttribute"/> if found; otherwise, <c>null</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="fieldInfo"/> is <c>null</c>.
	/// </exception>
	[return: MaybeNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public static TAttribute GetAttribute<TAttribute>([DisallowNull] this FieldInfo fieldInfo) where TAttribute : Attribute
	{
		return TypeHelper.GetAttribute<TAttribute>(fieldInfo);
	}

	/// <summary>
	/// Determines whether the specified method has an attribute of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the attribute to search for.</typeparam>
	/// <param name="methodInfo">The method to inspect.</param>
	/// <returns><c>true</c> if the method has the attribute; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the methodInfo is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public static bool HasAttribute<T>([DisallowNull] this MethodInfo methodInfo) where T : Attribute
	{
		return TypeHelper.HasAttribute<T>(methodInfo);
	}

	/// <summary>
	/// Determines whether the specified <see cref="PropertyInfo"/> represents a static property.
	/// </summary>
	/// <param name="property">The <see cref="PropertyInfo"/> to examine. This parameter cannot be null.</param>
	/// <returns><c>true</c> if the <paramref name="property"/> is static; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="property"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/31/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public static bool IsStatic([DisallowNull] this PropertyInfo property)
	{
		return TypeHelper.IsStatic(property);
	}

	/// <summary>
	/// Provides extension methods for <see cref="Type"/> instances.
	/// </summary>
	/// <param name="type">The type instance to extend.</param>
	extension([DisallowNull] Type type)
	{

		/// <summary>
		/// Gets all abstract methods of the specified type.
		/// </summary>
		/// <returns>A read-only collection of abstract methods.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllAbstractMethods), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public ReadOnlyCollection<MethodInfo> GetAllAbstractMethods()
		{
			return TypeHelper.GetAllAbstractMethods(type);
		}

		/// <summary>
		/// Gets all constructors of the specified type, including inherited constructors.
		/// </summary>
		/// <returns>An enumerable collection of constructors.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllConstructors), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public IEnumerable<ConstructorInfo> GetAllConstructors()
		{
			return TypeHelper.GetAllConstructors(type);
		}

		/// <summary>
		/// Gets all declared fields of the specified type.
		/// </summary>
		/// <returns>An enumerable collection of declared fields.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllDeclaredFields), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public IEnumerable<FieldInfo> GetAllDeclaredFields()
		{
			return TypeHelper.GetAllDeclaredFields(type);
		}

		/// <summary>
		/// Gets all declared methods of the specified type.
		/// </summary>
		/// <returns>An enumerable collection of declared methods.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllDeclaredMethods), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public IEnumerable<MethodInfo> GetAllDeclaredMethods()
		{
			return TypeHelper.GetAllDeclaredMethods(type);
		}

		/// <summary>
		/// Gets all fields of the specified type, including inherited fields.
		/// </summary>
		/// <returns>An enumerable collection of fields.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllFields), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public IEnumerable<FieldInfo> GetAllFields()
		{
			return TypeHelper.GetAllFields(type);
		}

		/// <summary>
		/// Gets all generic methods of the specified type.
		/// </summary>
		/// <returns>A read-only collection of generic methods.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllGenericMethods), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public ReadOnlyCollection<MethodInfo> GetAllGenericMethods()
		{
			return TypeHelper.GetAllGenericMethods(type);
		}

		/// <summary>
		/// Gets all methods of the specified type, including inherited methods.
		/// </summary>
		/// <returns>An enumerable collection of methods.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllMethods), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public IEnumerable<MethodInfo> GetAllMethods()
		{
			return TypeHelper.GetAllMethods(type);
		}

		/// <summary>
		/// Gets all properties of the specified type, including inherited properties.
		/// </summary>
		/// <returns>An enumerable collection of properties.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllProperties), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public IEnumerable<PropertyInfo> GetAllProperties()
		{
			return TypeHelper.GetAllProperties(type);
		}

		/// <summary>
		/// Gets all public methods of the specified type.
		/// </summary>
		/// <returns>A read-only collection of public methods.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllPublicMethods), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public ReadOnlyCollection<MethodInfo> GetAllPublicMethods()
		{
			return TypeHelper.GetAllPublicMethods(type);
		}

		/// <summary>
		/// Gets all static methods of the specified type.
		/// </summary>
		/// <returns>A read-only collection of static methods.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAllStaticMethods), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public ReadOnlyCollection<MethodInfo> GetAllStaticMethods()
		{
			return TypeHelper.GetAllStaticMethods(type);
		}

		/// <summary>
		/// Gets a custom attribute of the specified type from the given type.
		/// </summary>
		/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
		/// <returns>The custom attribute of type <typeparamref name="TAttribute"/> if found; otherwise, null.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[return: MaybeNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetAttribute), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public TAttribute GetAttribute<TAttribute>() where TAttribute : Attribute
		{
			return TypeHelper.GetAttribute<TAttribute>(type);
		}

		/// <summary>
		/// Gets the generic type arguments of the specified <see cref="Type"/>.
		/// </summary>
		/// <returns>An array of <see cref="Type"/> objects representing the generic type arguments.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetGenericArguments), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public Type[] GetGenericArguments()
		{
			return TypeHelper.GetGenericArguments(type);
		}

		/// <summary>
		/// Gets all members of the specified type that have the specified attribute.
		/// </summary>
		/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
		/// <returns>A read-only collection of <see cref="MemberInfo"/> objects that have the specified attribute.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetTypeMembersWithAttribute), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public ReadOnlyCollection<MemberInfo> GetTypeMembersWithAttribute<TAttribute>()
			where TAttribute : Attribute
		{
			return TypeHelper.GetTypeMembersWithAttribute<TAttribute>(type);
		}

		/// <summary>
		/// Determines whether the specified type has the specified base class.
		/// </summary>
		/// <param name="baseClass">The base class to check for.</param>
		/// <returns><c>true</c> if the type has the specified base class; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type or baseClass is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasBaseClass), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public bool HasBaseClass([DisallowNull] Type baseClass)
		{
			return TypeHelper.HasBaseClass(type, baseClass);
		}

		/// <summary>
		/// Determines whether the specified <see cref="Type"/> has a method with the given name and binding flags.
		/// </summary>
		/// <param name="methodName">The name of the method to check for.</param>
		/// <param name="bindingFlags">The binding flags to use when searching for the method. Defaults to public instance methods.</param>
		/// <returns><c>true</c> if the method exists; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasMethod), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public bool HasMethod([DisallowNull] string methodName, BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance)
		{
			return TypeHelper.HasMethod(type, methodName, bindingFlags);
		}

		/// <summary>
		/// Determines whether the specified type has a parameterless constructor.
		/// </summary>
		/// <returns><c>true</c> if the type has a parameterless constructor; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasParameterlessConstructor), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public bool HasParameterlessConstructor()
		{
			return TypeHelper.HasParameterlessConstructor(type);
		}

		/// <summary>
		/// Determines whether the specified <see cref="Type"/> has a property with the given name.
		/// </summary>
		/// <param name="propertyName">The name of the property to check for.</param>
		/// <returns><c>true</c> if the property exists; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasProperty), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public bool HasProperty([DisallowNull] string propertyName)
		{
			return TypeHelper.HasProperty(type, propertyName);
		}

		/// <summary>
		/// Determines whether the specified <see cref="Type"/> implements the specified interface type.
		/// </summary>
		/// <param name="interfaceType">The interface type to check for.</param>
		/// <returns><c>true</c> if the type implements the interface; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ImplementsInterface), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public bool ImplementsInterface([DisallowNull] Type interfaceType)
		{
			return TypeHelper.ImplementsInterface(type, interfaceType);
		}

		/// <summary>
		/// Determines whether the current <see cref="Type"/> can be assigned to the specified target type.
		/// </summary>
		/// <param name="targetType">The target type to check assignment compatibility with.</param>
		/// <returns><c>true</c> if the current type can be assigned to the target type; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsAssignableTo), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public bool IsAssignableTo([DisallowNull] Type targetType)
		{
			return TypeHelper.IsAssignableTo(type, targetType);
		}

		/// <summary>
		/// Determines whether the specified <see cref="Type"/> is a closed generic type.
		/// </summary>
		/// <returns><c>true</c> if the type is a closed generic; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsClosedGeneric), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public bool IsClosedGeneric()
		{
			return TypeHelper.IsClosedGeneric(type);
		}

		/// <summary>
		/// Determines whether the specified <see cref="Type"/> implements the <see cref="IEnumerable"/> interface.
		/// </summary>
		/// <returns><c>true</c> if the type implements <see cref="IEnumerable"/>; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEnumerable), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public bool IsEnumerable()
		{
			return TypeHelper.IsEnumerable(type);
		}

		/// <summary>
		/// Determines whether the specified <see cref="Type"/> is a nullable type.
		/// </summary>
		/// <returns><c>true</c> if the type is nullable; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNullable), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public bool IsNullable()
		{
			return TypeHelper.IsNullable(type);
		}

		/// <summary>
		/// Determines whether the specified <see cref="Type"/> is an open generic type definition.
		/// </summary>
		/// <returns><c>true</c> if the type is an open generic; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsOpenGeneric), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public bool IsOpenGeneric()
		{
			return TypeHelper.IsOpenGeneric(type);
		}

	}

}
