// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-12-2026
// ***********************************************************************
// <copyright file="TypeHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Provides valuable methods for type management, encompassing tasks
// such as loading derived types, creating new types, discovering derived
// types, converting JSON to objects, transforming JSON files into
// objects, generating instance hash codes, and listing built-in types.
// These functionalities empower developers to handle types effectively
// in diverse scenarios.
// </summary>
// ***********************************************************************

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core.Cache;
using Microsoft.Extensions.ObjectPool;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides a collection of utility methods for type inspection and manipulation, including functionality
/// for creating instances, comparing objects, finding derived types, and working with JSON and assembly data.
/// </summary>
/// <remarks>
/// This class includes methods for various operations such as creating instances of types, checking if an object
/// equals an instance, finding derived types within assemblies, directories, or the current AppDomain, and
/// converting objects to and from JSON. It also provides methods to get default values, hash codes, property values,
/// and display names for types, as well as determining if a type is a built-in .NET type or if an assembly is a .NET assembly.
/// </remarks>
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineTypeHelper")]
public static class TypeHelper
{
	/// <summary>
	/// The time out minutes
	/// </summary>
	private const int TimeOutMinutes = 5;

	/// <summary>
	/// Shared in-memory cache instance used for caching reflection results such as declared methods and abstract methods.
	/// </summary>
	private static readonly InMemoryCache _commonCache = InMemoryCache.Instance;

	/// <summary>
	/// Static common built-in types used for the <see cref="BuiltInTypeNames"/> cache initialization.
	/// </summary>
	private static readonly Type[] _commonTypes =
	[
		typeof(string), typeof(object), typeof(DateTime), typeof(DateTimeOffset),
		typeof(TimeSpan), typeof(Guid), typeof(Uri), typeof(BigInteger), typeof(Half),
		typeof(IntPtr), typeof(UIntPtr), typeof(DateTimeKind), typeof(Nullable<>),
		typeof(ValueTuple), typeof(Tuple), typeof(Span<>), typeof(ReadOnlySpan<>),
		typeof(Memory<>), typeof(ReadOnlyMemory<>), typeof(ArraySegment<>),
		typeof(KeyValuePair<,>), typeof(List<>), typeof(Dictionary<,>), typeof(HashSet<>),
		typeof(Queue<>), typeof(Stack<>), typeof(LinkedList<>), typeof(SortedList<,>),
		typeof(SortedDictionary<,>), typeof(SortedSet<>), typeof(ConcurrentDictionary<,>),
		typeof(ConcurrentQueue<>), typeof(ConcurrentStack<>), typeof(BlockingCollection<>),
		typeof(ObservableCollection<>), typeof(ReadOnlyCollection<>), typeof(ReadOnlyDictionary<,>),
		typeof(ReadOnlyObservableCollection<>), typeof(ImmutableArray<>), typeof(ImmutableList<>),
		typeof(ImmutableDictionary<,>), typeof(ImmutableHashSet<>), typeof(ImmutableQueue<>),
		typeof(ImmutableStack<>), typeof(ImmutableSortedDictionary<,>), typeof(ImmutableSortedSet<>)
	];

	/// <summary>
	/// Fast cache for <see cref="ImplementsInterface"/> results, keyed by (type, interfaceType) pair.
	/// Uses <see cref="ConcurrentDictionary{TKey,TValue}"/> rather than <see cref="InMemoryCache"/> because
	/// the underlying computation is a single <c>GetInterfaces()</c> array scan, and <c>MemoryCache</c> overhead
	/// (string key allocation — ~250 chars for generic types — locking, expiry tracking, boxing) far exceeds it.
	/// </summary>
	private static readonly ConcurrentDictionary<(Type, Type), bool> _implementsInterfaceCache = new();

	/// <summary>
	/// Static primitive types used for the <see cref="BuiltInTypeNames"/> cache initialization.
	/// </summary>
	private static readonly Type[] _primitiveTypes =
	[
		typeof(bool), typeof(byte), typeof(char), typeof(decimal), typeof(double),
		typeof(float), typeof(int), typeof(long), typeof(sbyte), typeof(short),
		typeof(uint), typeof(ulong), typeof(ushort)
	];

	/// <summary>
	/// Provides a pool of reusable <see cref="StringBuilder"/> instances to reduce allocations and improve performance.
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// A read-only collection of built-in .NET types. This collection is used internally to check if a type is a built-in .NET type.
	/// </summary>
	private static HashSet<Type>? _builtInTypes;

	/// <summary>
	/// A static field to cache the built-in .NET types.
	/// </summary>
	private static Dictionary<Type, string>? _cachedBuiltInTypes;

	/// <summary>
	/// Gets a read-only collection of built-in .NET types.
	/// </summary>
	[Information(nameof(BuiltInTypes), author: "David McCarter", createdOn: "11/6/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> BuiltInTypes
	{
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[return: NotNull]
		get
		{
			if (_builtInTypes == null)
			{
				ComputeBuiltInTypes();
			}

			if (_builtInTypes == null)
			{
				return ReadOnlyCollection<Type>.Empty;
			}

			return field ??= new ReadOnlyCollection<Type>([.. _builtInTypes]);
		}
	}

	/// <summary>
	/// Dynamically lists all built-in .NET types.
	/// </summary>
	/// <returns>A dictionary of built-in .NET types and their string representations.</returns>
	/// <remarks>
	/// This method gathers a comprehensive list of built-in .NET types, including primitive types,
	/// common types, and types from the System namespace. The results are cached to improve performance
	/// on subsequent calls.
	/// </remarks>
	/// <example>
	/// <code>
	/// var builtInTypes = TypeHelper.BuiltInTypeNames();
	/// foreach (var type in builtInTypes)
	/// {
	///     Console.WriteLine($"{type.Key}: {type.Value}");
	/// }
	/// </code>
	/// </example>
	[return: NotNull]
	[Information(nameof(BuiltInTypeNames), author: "David McCarter", createdOn: "11/6/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Dictionary<Type, string> BuiltInTypeNames()
	{
		if (_cachedBuiltInTypes is not null)
		{
			return _cachedBuiltInTypes;
		}

		var builtInTypes = new Dictionary<Type, string>(_primitiveTypes.Length + _commonTypes.Length);
		var options = new DisplayNameOptions(fullName: false, includeGenericParameterNames: true, includeGenericParameters: true);

		foreach (var type in _primitiveTypes.AsSpan())
		{
			builtInTypes[type] = GetTypeDisplayName(type, options);
		}

		foreach (var type in _commonTypes.AsSpan())
		{
			builtInTypes[type] = GetTypeDisplayName(type, options);
		}

		_cachedBuiltInTypes = builtInTypes;

		return builtInTypes;
	}

	/// <summary>
	/// Creates an instance of the specified type <typeparamref name="T"/>.
	/// This method requires the type <typeparamref name="T"/> to have a parameterless constructor.
	/// </summary>
	/// <typeparam name="T">The type of object to create.</typeparam>
	/// <returns>An instance of the specified type.</returns>
	/// <remarks>
	/// This method uses reflection to create an instance of 
	/// <typeparamref name="T"/>. It requires <typeparamref name="T"/> 
	/// to have a parameterless constructor. 
	/// Original code by: Jeremy Clark
	/// </remarks>
	[return: NotNull]
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static T Create<T>() where T : class, new()
	{
		return new();
	}

	/// <summary>
	/// Creates an instance of the specified type <typeparamref name="T"/> using the provided parameters.
	/// </summary>
	/// <typeparam name="T">The type of the instance to create. Must be a reference type.</typeparam>
	/// <param name="paramArray">The parameters to pass to the constructor of the type <typeparamref name="T"/>.</param>
	/// <returns>An instance of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="paramArray"/> is null.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static T Create<T>([DisallowNull] params object[] paramArray)
		where T : class
	{
		paramArray = paramArray.ArgumentNotNull();

		var instance = Activator.CreateInstance(typeof(T), args: paramArray) as T;

		return instance ?? throw new InvalidOperationException($"Unable to create an instance of type {typeof(T).FullName}.");
	}

	/// <summary>
	/// Determines whether the specified object is the same instance as the provided instance.
	/// </summary>
	/// <param name="value">The object to compare. Must not be null.</param>
	/// <param name="instance">The instance to compare against. Must not be null.</param>
	/// <returns><c>true</c> if the specified object is the same instance as the provided instance; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="value"/> or <paramref name="instance"/> is null.</exception>
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool DoesObjectEqualInstance(in object value, in object instance)
	{
		return ReferenceEquals(value, instance);
	}

	/// <summary>
	/// Finds all types derived from a specified base type within the currently loaded assemblies.
	/// </summary>
	/// <param name="baseType">The base type to find derived types of.</param>
	/// <param name="classOnly">If true, only class types are considered; otherwise, interfaces are also considered.</param>
	/// <returns>A read-only collection of types that are derived from the specified base type.</returns>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> FindDerivedTypes([DisallowNull] Type baseType, bool classOnly)
	{
		baseType = baseType.ArgumentNotNull();

		var path = AppContext.BaseDirectory;

		return FindDerivedTypes(new DirectoryInfo(path), SearchOption.TopDirectoryOnly, baseType, classOnly);
	}

	/// <summary>
	/// Finds all types derived from a specified base type within the specified <see cref="AppDomain"/>.
	/// </summary>
	/// <param name="currentDomain">The <see cref="AppDomain"/> to search for derived types in.</param>
	/// <param name="baseType">The base type to find derived types of.</param>
	/// <param name="classOnly">If true, only class types are considered; otherwise, interfaces are also considered.</param>
	/// <returns>A read-only collection of types that are derived from the specified base type.</returns>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> FindDerivedTypes([DisallowNull] AppDomain currentDomain, [DisallowNull] Type baseType, bool classOnly)
	{
		currentDomain = currentDomain.ArgumentNotNull();
		baseType = baseType.ArgumentNotNull();

		var cacheKey = string.Create(null, stackalloc char[128], $"{nameof(FindDerivedTypes)}.{currentDomain.FriendlyName}.{baseType.MetadataToken}.{(classOnly ? '1' : '0')}");


		if (_commonCache.TryGetValue<Type[]>(cacheKey, out var cachedTypes))
		{
			return Array.AsReadOnly(cachedTypes!);
		}

		var assemblyCollection = currentDomain.GetAssemblies();

		List<Type> types = new(capacity: 16);

		foreach (var assembly in assemblyCollection)
		{
			try
			{
				types.AddRange(LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly));
			}
			catch (ReflectionTypeLoadException reflectionEx)
			{
				Trace.WriteLine(reflectionEx.GetAllMessages());
			}
		}

		var result = types.ToArray();

		_commonCache.AddCacheItem(cacheKey, result, TimeSpan.FromMinutes(TimeOutMinutes));

		return Array.AsReadOnly(result);
	}

	/// <summary>
	/// Finds all types derived from a specified base type within the assemblies located in the specified directory.
	/// </summary>
	/// <param name="path">The directory containing the assemblies to search.</param>
	/// <param name="fileSearchType">Specifies whether to search all directories or only the top directory.</param>
	/// <param name="baseType">The base type to find derived types of.</param>
	/// <param name="classOnly">If true, only class types are considered; otherwise, interfaces are also considered.</param>
	/// <returns>A read-only collection of types that are derived from the specified base type.</returns>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> FindDerivedTypes([DisallowNull] DirectoryInfo path, SearchOption fileSearchType, [DisallowNull] Type baseType, bool classOnly)
	{
		fileSearchType = fileSearchType.ArgumentDefined();
		baseType = baseType.ArgumentNotNull();

		var files = path.ArgumentExists().EnumerateFiles("*.dll", fileSearchType).ToImmutableArray();
		var foundTypes = new List<Type>(files.Length);

		for (var fileIndex = 0; fileIndex < files.Length; fileIndex++)
		{
			TryAddDerivedTypesFromFile(files[fileIndex].FullName, baseType, classOnly, foundTypes);
		}

		return foundTypes.AsReadOnly();
	}

	/// <summary>
	/// Deserializes a JSON string into an instance of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <returns>An instance of <typeparamref name="T"/> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="json"/> is null or empty.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or the deserialization fails.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(FromJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T FromJson<T>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] string json) where T : class
	{
		return JsonSerializer.Deserialize<T>(json)!;
	}

	/// <summary>
	/// Deserializes a JSON string into an instance of type <typeparamref name="T"/> using the provided <see cref="JsonTypeInfo{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the object to deserialize to. Must be a reference type.</typeparam>
	/// <param name="json">The JSON string to deserialize. Must not be <c>null</c> or empty.</param>
	/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> used for source-generated or metadata-based deserialization. Must not be <c>null</c>.</param>
	/// <returns>An instance of <typeparamref name="T"/> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="json"/> is <c>null</c> or empty, or if <paramref name="typeInfo"/> is <c>null</c>.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or deserialization returns <c>null</c>.</exception>
	[return: NotNull]
	[Information(nameof(FromJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static T FromJson<T>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] string json, [DisallowNull] JsonTypeInfo<T> typeInfo)
	where T : class
	{
		json = json.ArgumentNotNullOrEmpty();
		typeInfo = typeInfo.ArgumentNotNull();

		return JsonSerializer.Deserialize(json, typeInfo)
			?? throw new JsonException($"Failed to deserialize JSON to {typeof(T)}.");
	}

	/// <summary>
	/// Deserializes a JSON file into an instance of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the object to deserialize to.</typeparam>
	/// <param name="file">The <see cref="FileInfo"/> representing the file to deserialize from.</param>
	/// <returns>An instance of <typeparamref name="T"/> deserialized from the JSON file.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> is null.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or the deserialization fails.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(FromJsonFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T FromJsonFile<T>([DisallowNull] FileInfo file)
		where T : class
	{
		file = file.ArgumentNotNull();

		if (file.Exists is false)
		{
			throw ExceptionThrower.CreateFileNotFoundException(file.FullName);
		}

		var json = File.ReadAllText(file.FullName, Encoding.UTF8);

		return JsonSerializer.Deserialize<T>(json)!;
	}

	/// <summary>
	/// Returns all abstract methods defined on the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for abstract methods. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IReadOnlyCollection{MethodInfo}"/> containing all abstract methods declared on the specified type.
	/// </returns>
	/// <remarks>
	/// Results are cached for performance. Only methods declared as <c>abstract</c> on the given type are included.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAllAbstractMethods), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<MethodInfo> GetAllAbstractMethods([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		// SUGGESTION FROM COPILOT SLOWER
		var cacheKey = $"{type.FullName}.{nameof(GetAllAbstractMethods)}";

		if (_commonCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
		{
			return Array.AsReadOnly(cachedMethods!);
		}

		var methods = type.GetTypeInfo().DeclaredMethods.Where(m => m.IsAbstract).ToArray();

		_commonCache.AddCacheItem(cacheKey, methods, TimeSpan.FromMinutes(TimeOutMinutes));

		return Array.AsReadOnly(methods);
	}

	/// <summary>
	/// Gets all constructors of the specified type, including inherited constructors.
	/// </summary>
	/// <param name="type">The type to inspect for constructors. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IEnumerable{ConstructorInfo}"/> containing all constructors declared on the specified type and its base types.
	/// </returns>
	/// <remarks>
	/// Results are cached for performance. Only constructors declared on the given type and its base types are included.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAllConstructors), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<ConstructorInfo> GetAllConstructors([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var cacheKey = $"{type.FullName}.{nameof(GetAllConstructors)}";

		if (_commonCache.TryGetValue<ConstructorInfo[]>(cacheKey, out var cachedConstructors))
		{
			foreach (var ctor in cachedConstructors!)
			{
				yield return ctor;
			}

			yield break;
		}

		var typeInfo = type.GetTypeInfo();
		var constructors = new List<ConstructorInfo>();

		while (typeInfo is not null)
		{
			constructors.AddRange(typeInfo.DeclaredConstructors);
			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}

		_commonCache.AddCacheItem(cacheKey, constructors.ToArray(), TimeSpan.FromMinutes(TimeOutMinutes));

		foreach (var ctor in constructors)
		{
			yield return ctor;
		}
	}

	/// <summary>
	/// Gets all declared fields of the specified type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for declared fields. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IEnumerable{FieldInfo}"/> containing all fields declared on the specified type.
	/// </returns>
	/// <remarks>
	/// Results are cached for performance. Only fields declared on the given type (not inherited) are included.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("Enumerates declared fields of a type via reflection (BindingFlags.DeclaredOnly).")]
	[Information(nameof(GetAllDeclaredFields), author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<FieldInfo> GetAllDeclaredFields([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var cacheKey = string.Create(null, stackalloc char[128], $"{type.FullName}.{nameof(GetAllDeclaredFields)}");

		if (_commonCache.TryGetValue<FieldInfo[]>(cacheKey, out var cachedFields))
		{
			return cachedFields!;
		}

		var fields = type.GetFields(
			BindingFlags.Instance |
			BindingFlags.Static |
			BindingFlags.Public |
			BindingFlags.NonPublic |
			BindingFlags.DeclaredOnly);

		_commonCache.AddCacheItem(cacheKey, fields, TimeSpan.FromMinutes(TimeOutMinutes));

		return fields;
	}

	/// <summary>
	/// Gets all declared methods of the specified type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for declared methods. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IEnumerable{MethodInfo}"/> containing all methods declared on the specified type.
	/// </returns>
	/// <remarks>
	/// Results are cached for performance. Only methods declared on the given type (not inherited) are included.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information("Original Code .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<MethodInfo> GetAllDeclaredMethods([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var cacheKey = $"{type.FullName}.{nameof(GetAllDeclaredMethods)}";

		if (_commonCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
		{
			foreach (var method in cachedMethods!)
			{
				yield return method;
			}

			yield break;
		}

		var methods = type.GetMethods(
			BindingFlags.Instance |
			BindingFlags.Static |
			BindingFlags.Public |
			BindingFlags.NonPublic |
			BindingFlags.DeclaredOnly);

		_commonCache.AddCacheItem(cacheKey, methods, TimeSpan.FromMinutes(TimeOutMinutes));

		foreach (var method in methods)
		{
			yield return method;
		}
	}

	/// <summary>
	/// Gets all fields of the specified type, including inherited fields.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for fields. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IEnumerable{FieldInfo}"/> containing all fields declared on the specified type and its base types.
	/// </returns>
	/// <remarks>
	/// This method enumerates all fields declared on the specified type and its base types, including private, protected, and public fields.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAllFields), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<FieldInfo> GetAllFields([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var cacheKey = $"{type.FullName}.{nameof(GetAllFields)}";

		if (_commonCache.TryGetValue<FieldInfo[]>(cacheKey, out var cachedFields))
		{
			foreach (var field in cachedFields!)
			{
				yield return field;
			}

			yield break;
		}

		var typeInfo = type.GetTypeInfo();
		var capacity = 0;
		var countInfo = typeInfo;

		while (countInfo is not null)
		{
			capacity += countInfo.DeclaredFields.Count();
			countInfo = countInfo.BaseType?.GetTypeInfo();
		}

		var fields = new List<FieldInfo>(capacity);

		while (typeInfo is not null)
		{
			fields.AddRange(typeInfo.DeclaredFields);
			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}

		_commonCache.AddCacheItem(cacheKey, fields.ToArray(), TimeSpan.FromMinutes(TimeOutMinutes));

		foreach (var field in fields)
		{
			yield return field;
		}
	}

	/// <summary>
	/// Gets all generic methods of the specified type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for generic methods. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IReadOnlyCollection{MethodInfo}"/> containing all generic methods declared on the specified type.
	/// </returns>
	/// <remarks>
	/// Only methods declared as generic on the given type are included. The returned collection is read-only.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAllGenericMethods), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<MethodInfo> GetAllGenericMethods([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		// SUGGESTION FROM COPILOT SLOWER
		var cacheKey = $"{type.FullName}.{nameof(GetAllGenericMethods)}";

		if (_commonCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
		{
			return Array.AsReadOnly(cachedMethods!);
		}

		var methods = type.GetTypeInfo().DeclaredMethods.Where(m => m.IsGenericMethod).ToArray();

		_commonCache.AddCacheItem(cacheKey, methods, TimeSpan.FromMinutes(TimeOutMinutes));

		return Array.AsReadOnly(methods);
	}

	/// <summary>
	/// Gets all methods of the specified type, including inherited methods.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for methods. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IEnumerable{MethodInfo}"/> containing all methods declared on the specified type and its base types.
	/// </returns>
	/// <remarks>
	/// This method enumerates all methods declared on the specified type and its base types, including private, protected, and public methods.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAllMethods), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<MethodInfo> GetAllMethods([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var cacheKey = $"{type.FullName}.{nameof(GetAllMethods)}";

		if (_commonCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
		{
			foreach (var method in cachedMethods!)
			{
				yield return method;
			}

			yield break;
		}

		var typeInfo = type.GetTypeInfo();
		var capacity = 0;
		var countInfo = typeInfo;

		while (countInfo is not null)
		{
			capacity += countInfo.DeclaredMethods.Count();
			countInfo = countInfo.BaseType?.GetTypeInfo();
		}

		var methods = new List<MethodInfo>(capacity);

		while (typeInfo is not null)
		{
			methods.AddRange(typeInfo.DeclaredMethods);
			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}

		_commonCache.AddCacheItem(cacheKey, methods.ToArray(), TimeSpan.FromMinutes(TimeOutMinutes));

		foreach (var method in methods)
		{
			yield return method;
		}
	}

	/// <summary>
	/// Gets all properties of the specified type, including inherited properties.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for properties. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IEnumerable{PropertyInfo}"/> containing all properties declared on the specified type and its base types.
	/// </returns>
	/// <remarks>
	/// This method enumerates all properties declared on the specified type and its base types, including private, protected, and public properties.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAllProperties), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<PropertyInfo> GetAllProperties([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var cacheKey = $"{type.FullName}.{nameof(GetAllProperties)}";

		if (_commonCache.TryGetValue<PropertyInfo[]>(cacheKey, out var cachedProperties))
		{
			foreach (var property in cachedProperties!)
			{
				yield return property;
			}

			yield break;
		}

		var typeInfo = type.GetTypeInfo();
		var capacity = 0;
		var countInfo = typeInfo;

		while (countInfo is not null)
		{
			capacity += countInfo.DeclaredProperties.Count();
			countInfo = countInfo.BaseType?.GetTypeInfo();
		}

		var properties = new List<PropertyInfo>(capacity);

		while (typeInfo is not null)
		{
			properties.AddRange(typeInfo.DeclaredProperties);
			typeInfo = typeInfo.BaseType?.GetTypeInfo();
		}

		_commonCache.AddCacheItem(cacheKey, properties.ToArray(), TimeSpan.FromMinutes(TimeOutMinutes));

		foreach (var property in properties)
		{
			yield return property;
		}
	}

	/// <summary>
	/// Gets all public methods of the specified type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for public methods. Must not be <c>null</c>.</param>
	/// <returns>
	/// A <see cref="ReadOnlyCollection{MethodInfo}"/> containing all public methods declared on the specified type and its base types.
	/// </returns>
	/// <remarks>
	/// This method returns all public methods, including inherited ones, for the specified type.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAllPublicMethods), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<MethodInfo> GetAllPublicMethods([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var cacheKey = $"{type.FullName}.{nameof(GetAllPublicMethods)}";

		if (_commonCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
		{
			return Array.AsReadOnly(cachedMethods!);
		}

		var methods = type.GetTypeInfo().DeclaredMethods.Where(m => m.IsPublic).ToArray();

		_commonCache.AddCacheItem(cacheKey, methods, TimeSpan.FromMinutes(TimeOutMinutes));

		return Array.AsReadOnly(methods);
	}

	/// <summary>
	/// Gets all static methods of the specified type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect for static methods. Must not be <c>null</c>.</param>
	/// <returns>
	/// An <see cref="IReadOnlyCollection{MethodInfo}"/> containing all static methods declared on the specified type.
	/// </returns>
	/// <remarks>
	/// Only methods declared as static on the given type are included. The returned collection is read-only.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetAllStaticMethods), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<MethodInfo> GetAllStaticMethods([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		var cacheKey = $"{type.FullName}.{nameof(GetAllStaticMethods)}";

		if (_commonCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
		{
			return Array.AsReadOnly(cachedMethods!);
		}

		var methods = type.GetTypeInfo().DeclaredMethods.Where(m => m.IsStatic).ToArray();

		_commonCache.AddCacheItem(cacheKey, methods, TimeSpan.FromMinutes(TimeOutMinutes));

		return Array.AsReadOnly(methods);
	}

	/// <summary>
	/// Gets a custom attribute of the specified type from the given field.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to retrieve. Must inherit from <see cref="Attribute"/>.</typeparam>
	/// <param name="fieldInfo">The <see cref="FieldInfo"/> to inspect for the attribute. Can be <c>null</c>.</param>
	/// <returns>
	/// An instance of <typeparamref name="TAttribute"/> if the attribute is found on the specified field; otherwise, <c>null</c>.
	/// </returns>
	/// <remarks>
	/// This method returns the first custom attribute of type <typeparamref name="TAttribute"/> that is applied to the specified field,
	/// or <c>null</c> if no such attribute is found.
	/// </remarks>
	[return: MaybeNull]
	[Information(nameof(GetAttribute), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TAttribute GetAttribute<TAttribute>([DisallowNull] FieldInfo fieldInfo) where TAttribute : Attribute
	{
		fieldInfo = fieldInfo.ArgumentNotNull();

		var cacheKey = string.Create(null, stackalloc char[512], $"{fieldInfo.DeclaringType?.FullName}.{fieldInfo.Name}.{nameof(GetAttribute)}.FieldInfo.{typeof(TAttribute).FullName}");

		if (_commonCache.TryGetValue<TAttribute>(cacheKey, out var cachedAttribute))
		{
			return cachedAttribute;
		}

		var attribute = fieldInfo.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;

		if (attribute is not null)
		{

			_commonCache.AddCacheItem(cacheKey, attribute, TimeSpan.FromMinutes(TimeOutMinutes));

			return attribute;
		}
		else
		{
			return null;
		}
	}

	/// <summary>
	/// Gets a custom attribute of the specified type from the given type.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to retrieve. Must inherit from <see cref="Attribute"/>.</typeparam>
	/// <param name="type">The <see cref="Type"/> to inspect for the attribute. Must not be <c>null</c>.</param>
	/// <returns>
	/// An instance of <typeparamref name="TAttribute"/> if the attribute is found on the specified type; otherwise, <c>null</c>.
	/// </returns>
	/// <remarks>
	/// This method returns the first custom attribute of type <typeparamref name="TAttribute"/> that is applied to the specified type,
	/// or <c>null</c> if no such attribute is found.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="type"/> is <c>null</c>.</exception>
	[return: MaybeNull]
	[Information(nameof(GetAttribute), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TAttribute GetAttribute<TAttribute>([DisallowNull] Type type) where TAttribute : Attribute
	{
		type = type.ArgumentNotNull();

		var cacheKey = string.Create(null, stackalloc char[512], $"{type.FullName}.{nameof(GetAttribute)}.Type.{typeof(TAttribute).FullName}");

		if (_commonCache.TryGetValue<TAttribute>(cacheKey, out var cachedAttribute))
		{
			return cachedAttribute;
		}

		var attribute = type.GetTypeInfo().GetCustomAttributes(typeof(TAttribute), false).OfType<TAttribute>().FirstOrDefault();

		if (attribute is not null)
		{

			_commonCache.AddCacheItem(cacheKey, attribute, TimeSpan.FromMinutes(TimeOutMinutes));

			return attribute;
		}
		else
		{
			return null;
		}
	}

	/// <summary>
	/// Gets a custom attribute of the specified type from the given method.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to retrieve. Must inherit from <see cref="Attribute"/>.</typeparam>
	/// <param name="methodInfo">The <see cref="MethodInfo"/> to inspect for the attribute. Must not be <c>null</c>.</param>
	/// <returns>
	/// An instance of <typeparamref name="TAttribute"/> if the attribute is found on the specified method; otherwise, <c>null</c>.
	/// </returns>
	/// <remarks>
	/// This method returns the first custom attribute of type <typeparamref name="TAttribute"/> that is applied to the specified method,
	/// or <c>null</c> if no such attribute is found.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="methodInfo"/> is <c>null</c>.</exception>
	[return: MaybeNull]
	[Information(nameof(GetAttribute), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TAttribute? GetAttribute<TAttribute>([DisallowNull] MethodInfo methodInfo) where TAttribute : Attribute
	{
		methodInfo = methodInfo.ArgumentNotNull();

		var cacheKey = string.Create(null, stackalloc char[512], $"{methodInfo.DeclaringType?.FullName}.{methodInfo.Name}.{nameof(GetAttribute)}.MethodInfo.{typeof(TAttribute).FullName}");

		if (_commonCache.TryGetValue<TAttribute>(cacheKey, out var cachedAttribute))
		{
			return cachedAttribute;
		}

		var attribute = methodInfo.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;


		if (attribute is not null)
		{

			_commonCache.AddCacheItem(cacheKey, attribute, TimeSpan.FromMinutes(TimeOutMinutes));

			return attribute;
		}
		else
		{
			return null;
		}
	}

	/// <summary>
	/// Gets a custom attribute of the specified type from the given property.
	/// </summary>
	/// <typeparam name="TAttribute">
	/// The type of the attribute to retrieve. Must inherit from <see cref="Attribute"/>.
	/// </typeparam>
	/// <param name="propertyInfo">
	/// The <see cref="PropertyInfo"/> to inspect for the attribute. Must not be <c>null</c>.
	/// </param>
	/// <returns>
	/// An instance of <typeparamref name="TAttribute"/> if the attribute is found on the specified property; otherwise, <c>null</c>.
	/// </returns>
	/// <remarks>
	/// Results are cached for performance using an in-memory cache keyed on the declaring type, property name,
	/// and attribute type. This method returns the first custom attribute instance of type <typeparamref name="TAttribute"/>
	/// applied to the property. Inherited attributes are not considered unless they are directly applied to the property.
	/// </remarks>
	/// <example>
	/// Example: Retrieving a JSON serialization attribute from a property.
	/// <code>
	/// using System.Text.Json.Serialization;
	///
	/// public class Product
	/// {
	///     [JsonPropertyName("product_name")]
	///     public string Name { get; set; }
	/// }
	///
	/// var prop = typeof(Product).GetProperty(nameof(Product.Name));
	/// var attr = TypeHelper.GetAttribute&lt;JsonPropertyNameAttribute&gt;(prop!);
	/// Console.WriteLine(attr?.Name); // Output: product_name
	/// </code>
	/// </example>
	/// <seealso cref="GetAttribute{TAttribute}(Type)"/>
	/// <seealso cref="GetAttribute{TAttribute}(MethodInfo)"/>
	/// <seealso cref="GetAttribute{TAttribute}(FieldInfo)"/>
	[return: MaybeNull]
	[Information(nameof(GetAttribute), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TAttribute? GetAttribute<TAttribute>([DisallowNull] PropertyInfo propertyInfo) where TAttribute : Attribute
	{
		propertyInfo = propertyInfo.ArgumentNotNull();

		var cacheKey = string.Create(null, stackalloc char[512], $"{propertyInfo.DeclaringType?.FullName}.{propertyInfo.Name}.{nameof(GetAttribute)}.PropertyInfo.{typeof(TAttribute).FullName}");

		if (_commonCache.TryGetValue<TAttribute>(cacheKey, out var cachedAttribute))
		{
			return cachedAttribute;
		}

		var attribute = propertyInfo.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault() as TAttribute;

		if (attribute is not null)
		{

			_commonCache.AddCacheItem(cacheKey, attribute, TimeSpan.FromMinutes(TimeOutMinutes));

			return attribute;
		}
		else
		{
			return null;
		}
	}

	/// <summary>
	/// Gets the default value for the specified type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type for which to get the default value.</typeparam>
	/// <returns>The default value for type <typeparamref name="T"/>.</returns>
	[Information(UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T GetDefault<T>()
	{
		return default!;
	}

	/// <summary>
	/// Gets the generic type arguments of the specified <see cref="Type"/>.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to retrieve generic arguments from. Must not be <c>null</c>.</param>
	/// <returns>
	/// An array of <see cref="Type"/> objects representing the generic type arguments of the specified type.
	/// If the type is not a generic type, an empty array is returned.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(GetGenericArguments), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static Type[] GetGenericArguments([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		return type.GetGenericArguments();
	}

	/// <summary>
	/// Gets the names of all interfaces implemented by the specified object's type.
	/// </summary>
	/// <param name="input">The object whose implemented interfaces are to be retrieved. Must not be <c>null</c>.</param>
	/// <returns>
	/// A read-only collection of strings containing the names of all interfaces implemented by the object's type.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="input"/> is <c>null</c>.
	/// </exception>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> GetImplementedInterfaces([DisallowNull] object input)
	{
		input = input.ArgumentNotNull();

#pragma warning disable IL2070 // input.GetType() returns Type without DynamicallyAccessedMembers — method marked RequiresUnreferencedCode
		var interfaces = input.GetType().GetInterfaces();
#pragma warning restore IL2070

		var names = new string[interfaces.Length];

		for (var interfaceIndex = 0; interfaceIndex < interfaces.Length; interfaceIndex++)
		{
			names[interfaceIndex] = interfaces[interfaceIndex].Name;
		}

		return Array.AsReadOnly(names);
	}

	/// <summary>
	/// Gets the names of the implemented interfaces of the specified object, filtered by the provided interface names.
	/// </summary>
	/// <param name="input">The object whose implemented interfaces are to be checked. Must not be <c>null</c>.</param>
	/// <param name="interfaceNames">A collection of interface names to filter the implemented interfaces. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// A read-only collection of strings containing the names of the interfaces implemented by the object's type that match the provided <paramref name="interfaceNames"/>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="input"/> or <paramref name="interfaceNames"/> is <c>null</c>.
	/// </exception>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> GetImplementedInterfaces([DisallowNull] object input, params IReadOnlyCollection<string> interfaceNames)
	{
		input = input.ArgumentNotNull();
		interfaceNames = interfaceNames.ArgumentItemsExists();

#pragma warning disable IL2070 // input.GetType() returns Type without DynamicallyAccessedMembers — method marked RequiresUnreferencedCode
		var interfaces = input.GetType().GetInterfaces().Select(p => p.Name);
#pragma warning restore IL2070

		var foundInterfaces = interfaces.Intersect(interfaceNames).ToArray();

		return Array.AsReadOnly(foundInterfaces);
	}

	/// <summary>
	/// Gets all interfaces implemented by the specified object's type.
	/// </summary>
	/// <param name="input">The object whose implemented interfaces are to be retrieved. Must not be <c>null</c>.</param>
	/// <returns>
	/// A read-only collection of <see cref="Type"/> objects representing all interfaces implemented by the object's type.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="input"/> is <c>null</c>.
	/// </exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetImplementedInterfaceTypes), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<Type> GetImplementedInterfaceTypes([DisallowNull] object input)
	{
		input = input.ArgumentNotNull();

#pragma warning disable IL2070 // input.GetType() returns Type without DynamicallyAccessedMembers — method marked RequiresUnreferencedCode
		return Array.AsReadOnly(input.GetType().GetInterfaces());
#pragma warning restore IL2070
	}

	/// <summary>
	/// Computes the hash code for the specified instance.
	/// </summary>
	/// <param name="instance">The instance to compute the hash code for.</param>
	/// <returns>The computed hash code.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="instance"/> is null.</exception>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static int GetInstanceHashCode([DisallowNull] object instance)
	{
		instance = instance.ArgumentNotNull();

		var type = instance.GetType();
		var cacheKey = string.Create(null, stackalloc char[256], $"{type.FullName}.{nameof(GetInstanceHashCode)}");

		// Cache the PropertyInfo array to avoid repeated reflection
		if (!_commonCache.TryGetValue<PropertyInfo[]>(cacheKey, out var properties))
		{
			properties = [.. type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.CanRead)];

			_commonCache.AddCacheItem(cacheKey, properties, TimeSpan.FromMinutes(TimeOutMinutes));
		}

		var hash = new HashCode();

		foreach (var property in properties!)
		{
			var value = property.GetValue(instance);

			if (value != null)
			{
				hash.Add(value);
			}
		}

		return hash.ToHashCode();
	}

	/// <summary>
	/// Retrieves all members of the specified type that have the specified attribute.
	/// </summary>
	/// <typeparam name="TAttribute">The type of the attribute to search for.</typeparam>
	/// <param name="type">The type to search for members with the specified attribute.</param>
	/// <returns>An enumerable collection of members that have the specified attribute.</returns>
	/// <exception cref="ArgumentNullException">Thrown when the type is null.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetMembersWithAttribute), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<MemberInfo> GetMembersWithAttribute<TAttribute>([DisallowNull] Type type) where TAttribute : Attribute
	{
		type = type.ArgumentNotNull();

		var cacheKey = $"{nameof(GetMembersWithAttribute)}.{type.FullName}";

		if (_commonCache.TryGetValue<MemberInfo[]>(cacheKey, out var cachedMembers))
		{
			foreach (var member in cachedMembers!)
			{
				yield return member;
			}

			yield break;
		}

		var membersWithAttribute = CollectMembersWithAttribute<TAttribute>(type);

		_commonCache.AddCacheItem(cacheKey, membersWithAttribute, TimeSpan.FromMinutes(TimeOutMinutes));

		foreach (var member in membersWithAttribute)
		{
			yield return member;
		}
	}

	/// <summary>
	/// Gets the property values of the specified object.
	/// </summary>
	/// <typeparam name="T">The type of the object to get property values from.</typeparam>
	/// <param name="input">The object instance to extract property values from.</param>
	/// <returns>A read-only collection of key-value pairs where each key is a property name and each value is the property's value as a string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	/// <example>Output:
	/// [Address1, `fqrZjAqTNANUNIyJWFyNjCQx]
	/// [Address2, bSUnkmaIIMutgJtAKYZANpSHM]
	/// [Age, 23360.00:00:00.0086580]
	/// [BornOn, 1/23/1957 2:45:24 PM -08:00]
	/// [CellPhone, 704-375-5873]
	/// [City, fDbZYFMANE\MLxD]
	/// [Country, RbPjkyMasw`gnWR]
	/// [Email, thmiduaodph@djpumhmaheckkmrmwkkpxs.gov]
	/// [FirstName, ugdv\bhaHgSY^Ui]
	/// [HomePhone, 147-205-1085]
	/// [Id, f1bcbdbdf18a4adaa89e46383b235008]
	/// [LastName, H^hkKhwWggIrUCYbbxiFEJGJM]
	/// [PostalCode, 86560656].
	/// </example>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetPropertyValues), author: "David McCarter", createdOn: "11/03/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<KeyValuePair<string, string>> GetPropertyValues<T>(in T input)
	{
		_ = input.ArgumentNotNull();

		var type = input!.GetType();

		var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
			.Where(p => p.CanRead)
			.OrderBy(p => p.Name)
			.ToArray();

		var returnValue = new Dictionary<string, string>(properties.Length);

		foreach (var propertyInfo in properties.AsSpan())
		{
			if (TryFormatPropertyValue(propertyInfo.GetValue(input), out var formatted))
			{
				returnValue[propertyInfo.Name] = formatted!;
			}
		}

		return returnValue.ToReadOnlyCollection();
	}

	/// <summary>
	/// Gets the display name of the type of the specified object, even if it's a generic type.
	/// </summary>
	/// <param name="item">The object to get the type display name for.</param>
	/// <param name="fullName">If true, the full name of the type is returned; otherwise, the short name is returned.</param>
	/// <returns>The display name of the type of the specified object.</returns>
	[Information(nameof(GetTypeDisplayName), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string? GetTypeDisplayName(in object item, bool fullName = true)
	{
		return item is null ? null : GetTypeDisplayName(item.GetType(), fullName);
	}

	/// <summary>
	/// Gets the display name of the specified type using the provided display options.
	/// </summary>
	/// <param name="type">The type to get the display name for.</param>
	/// <param name="options">The display options to use for formatting the display name.</param>
	/// <returns>The display name of the type.</returns>
	[return: NotNull]
	[Information(UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GetTypeDisplayName([DisallowNull] Type type, in DisplayNameOptions options)
	{
		type = type.ArgumentNotNull();

		var sb = _stringBuilderPool.Get();

		try
		{
			ProcessType(sb, type, options);

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Gets the display name of the specified type.
	/// </summary>
	/// <param name="type">The type to get the display name for.</param>
	/// <param name="fullName">If true, returns the full name of the type; otherwise, returns the short name.</param>
	/// <param name="includeGenericParameterNames">If true, includes the names of generic parameters in the display name.</param>
	/// <param name="includeGenericParameters">If true, includes generic parameters in the display name.</param>
	/// <param name="nestedTypeDelimiter">The delimiter to use for nested types.</param>
	/// <returns>The display name of the type.</returns>
	[return: NotNull]
	[Information(nameof(GetTypeDisplayName), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string GetTypeDisplayName(Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = ControlChars.Dot)
	{
		type = type.ArgumentNotNull();

		// Create a cache key that uniquely identifies the combination of type and display options
		var cacheKey = string.Create(null, stackalloc char[512], $"{type.AssemblyQualifiedName}.{nameof(GetTypeDisplayName)}.{fullName}.{includeGenericParameterNames}.{includeGenericParameters}.{(int)nestedTypeDelimiter}");

		if (_commonCache.TryGetValue<string>(cacheKey, out var cachedDisplayName))
		{
			return cachedDisplayName!;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			ProcessType(sb, type, new DisplayNameOptions(fullName, includeGenericParameterNames, includeGenericParameters, nestedTypeDelimiter));

			var displayName = sb.ToString();

			_commonCache.AddCacheItem(cacheKey, displayName, TimeSpan.FromMinutes(TimeOutMinutes));

			return displayName;
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Retrieves all members of the specified type that have the attribute <typeparamref name="TAttribute"/> applied.
	/// </summary>
	/// <typeparam name="TAttribute">
	/// The attribute type to search for. Must derive from <see cref="Attribute"/>.
	/// </typeparam>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <returns>
	/// A <see cref="ReadOnlyCollection{T}"/> of <see cref="MemberInfo"/> containing the type itself
	/// and any of its members (properties, methods, fields, events) that are decorated with
	/// <typeparamref name="TAttribute"/>.
	/// Returns an empty collection if no matching members are found.
	/// </returns>
	/// <remarks>
	/// This is a convenience wrapper over <see cref="GetMembersWithAttribute{TAttribute}(Type)"/>,
	/// materializing the results into a read-only collection for easier consumption and caching
	/// by callers that need indexable results.
	/// </remarks>
	/// <example>
	/// <code>
	/// [AttributeUsage(AttributeTargets.All)]
	/// public sealed class MyAttribute : Attribute { }
	/// 
	/// [MyAttribute]
	/// public class Sample
	/// {
	///     [MyAttribute]
	///     public string Name { get; set; }
	/// }
	/// 
	/// var members = TypeHelper.GetTypeMembersWithAttribute&lt;MyAttribute&gt;(typeof(Sample));
	/// // members contains: typeof(Sample) and PropertyInfo for Name.
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="type"/> is <c>null</c>.</exception>
	[return: NotNull]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(GetTypeMembersWithAttribute), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<MemberInfo> GetTypeMembersWithAttribute<TAttribute>([DisallowNull] Type type)
		where TAttribute : Attribute
	{
		type = type.ArgumentNotNull();

		// SUGGESTION FROM COPILOT SLOWER
		return GetMembersWithAttribute<TAttribute>(type).ToArray().AsReadOnly();
	}

	/// <summary>
	/// Determines whether the specified method has an attribute of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the attribute to check for. Must inherit from <see cref="Attribute"/>.</typeparam>
	/// <param name="methodInfo">The <see cref="MethodInfo"/> to inspect for the attribute. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if the specified method has an attribute of type <typeparamref name="T"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="methodInfo"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(HasAttribute), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool HasAttribute<T>([DisallowNull] MethodInfo methodInfo) where T : Attribute
	{
		return GetAttribute<T>(methodInfo) is not null;
	}

	/// <summary>
	/// Determines whether the specified type has the specified base class.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to check. Must not be <c>null</c>.</param>
	/// <param name="baseClass">The base class <see cref="Type"/> to check for. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="type"/> has <paramref name="baseClass"/> in its inheritance hierarchy; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> or <paramref name="baseClass"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(HasBaseClass), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasBaseClass(Type type, Type baseClass)
	{
		type = type.ArgumentNotNull();

		// SUGGESTION FROM COPILOT SLOWER
		if (baseClass is null)
		{
			return false;
		}

		// Calculate the result if not cached
		var result = false;
		var currentType = type;

		while (currentType is not null)
		{
			if (currentType == baseClass)
			{
				result = true;
				break;
			}

			currentType = currentType.BaseType;
		}

		return result;
	}

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> has a method with the given name and binding flags.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <param name="methodName">The name of the method to look for. Must not be <c>null</c> or empty.</param>
	/// <param name="bindingFlags">The <see cref="BindingFlags"/> to use when searching for the method. Defaults to <see cref="BindingFlags.Public"/> | <see cref="BindingFlags.Instance"/>.</param>
	/// <returns>
	/// <c>true</c> if a method with the specified name and binding flags exists on the type; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> is <c>null</c>.
	/// </exception>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(HasMethod), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasMethod([DisallowNull] Type type, string methodName, BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance)
	{
		type = type.ArgumentNotNull();

		return type.GetMethod(methodName, bindingFlags) != null;
	}

	/// <summary>
	/// Determines whether the specified type has a parameterless constructor.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if the type has a public or non-public parameterless constructor; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> is <c>null</c>.
	/// </exception>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(HasParameterlessConstructor), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasParameterlessConstructor([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null) is not null;
	}

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> has a property with the given name.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <param name="propertyName">The name of the property to look for. Must not be <c>null</c> or empty.</param>
	/// <returns>
	/// <c>true</c> if a property with the specified name exists on the type; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> is <c>null</c>.
	/// </exception>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(HasProperty), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasProperty([DisallowNull] Type type, [DisallowNull] string propertyName)
	{
		type = type.ArgumentNotNull();

		return type.GetProperty(propertyName) != null;
	}

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> implements the specified interface type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <param name="interfaceType">The interface <see cref="Type"/> to check for. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="type"/> implements <paramref name="interfaceType"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> or <paramref name="interfaceType"/> is <c>null</c>.
	/// </exception>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(ImplementsInterface), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool ImplementsInterface([DisallowNull] Type type, [DisallowNull] Type interfaceType)
	{
		if (interfaceType == null || interfaceType.IsInterface == false)
		{
			return false;
		}

		type = type.ArgumentNotNull();

		return _implementsInterfaceCache.GetOrAdd((type, interfaceType), static key =>
		{
			var (t, iface) = key;

			return t.GetInterfaces().Any(i => i == iface);
		});
	}

	/// <summary>
	/// Determines whether the current <see cref="Type"/> can be assigned to the specified target type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to check. Must not be <c>null</c>.</param>
	/// <param name="targetType">The target <see cref="Type"/> to check assignability to. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="type"/> can be assigned to <paramref name="targetType"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> or <paramref name="targetType"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(IsAssignableTo), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsAssignableTo([DisallowNull] Type type, [DisallowNull] Type targetType)
	{
		type = type.ArgumentNotNull();
		targetType = targetType.ArgumentNotNull();

		return targetType.IsAssignableFrom(type);
	}

	/// <summary>
	/// Determines whether the specified type is a built-in .NET type.
	/// </summary>
	/// <param name="type">The type to check.</param>
	/// <returns><c>true</c> if the type is a built-in .NET type; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// A type is considered built-in if it appears in the cached primitive/common-type dictionary,
	/// or if it is any public type (class, struct, interface, enum, or delegate) defined in the
	/// core .NET runtime assembly (<c>System.Private.CoreLib</c>) whose namespace is <c>"System"</c>
	/// or begins with <c>"System."</c>.
	/// The dictionary lookup is O(1); the assembly/namespace fallback is only reached when the type
	/// is not in the dictionary. The cache is lazily initialized on first access.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsBuiltinType), author: "David McCarter", createdOn: "11/6/2023", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsBuiltinType(in Type type)
	{
		if (type is null)
		{
			return false;
		}

		if (_cachedBuiltInTypes is null)
		{
			_ = BuiltInTypeNames();
		}

		if (_cachedBuiltInTypes!.ContainsKey(type))
		{
			return true;
		}

		var ns = type.Namespace;

		return ns is not null
			&& (ns == "System" || ns.StartsWith("System.", StringComparison.Ordinal))
			&& type.Assembly == typeof(object).Assembly;
	}

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> is a closed generic type.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if the type is a closed generic type; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(IsClosedGeneric), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool IsClosedGeneric([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		return type.IsGenericType && !type.IsGenericTypeDefinition;
	}

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> implements the <see cref="IEnumerable"/> interface,
	/// is an array, or implements the <see cref="ICollection"/> interface.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if the type is an array, implements <see cref="IEnumerable"/>, or implements <see cref="ICollection"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(IsEnumerable), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static bool IsEnumerable([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		return type.IsArray || typeof(IEnumerable).IsAssignableFrom(type);
	}

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> is a nullable type.
	/// </summary>
	[Information(nameof(IsNullable), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool IsNullable([AllowNull] Type? type)
	{
		return type != null && Nullable.GetUnderlyingType(type) is not null;
	}

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> is an open generic type definition.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if the type is an open generic type definition; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(IsOpenGeneric), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool IsOpenGeneric([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		return type.IsGenericTypeDefinition;
	}

	/// <summary>
	/// Determines whether the specified <see cref="PropertyInfo"/> represents a static property.
	/// </summary>
	/// <param name="property">The <see cref="PropertyInfo"/> to inspect. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if the property is static; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="property"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(IsStatic), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool IsStatic([DisallowNull] PropertyInfo property)
	{
		property = property.ArgumentNotNull();

		return (property.GetMethod ?? property.SetMethod!).IsStatic;
	}

	/// <summary>
	/// Returns the maximum of two comparable objects.
	/// </summary>
	/// <typeparam name="T">The type of the objects to compare. Must implement <see cref="IComparable"/>.</typeparam>
	/// <param name="obj1">The first object to compare. Can be <c>null</c>.</param>
	/// <param name="obj2">The second object to compare. Can be <c>null</c>.</param>
	/// <returns>
	/// <paramref name="obj1"/> if it is greater than or equal to <paramref name="obj2"/>; otherwise, <paramref name="obj2"/>.
	/// If both are <c>null</c>, returns <c>null</c>.
	/// </returns>
	[Information(nameof(Max), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T? Max<T>([AllowNull] T? obj1, [AllowNull] T? obj2) where T : IComparable
	{
		return obj1?.CompareTo(obj2) >= 0 ? obj1 : obj2;
	}

	/// <summary>
	/// Returns the smaller of two comparable values.
	/// </summary>
	/// <typeparam name="T">
	/// The type of the values to compare. Must implement <see cref="IComparable"/>.
	/// </typeparam>
	/// <param name="obj1">The first value to compare. May be <c>null</c>.</param>
	/// <param name="obj2">The second value to compare. May be <c>null</c>.</param>
	/// <returns>
	/// <para>
	/// The minimum of <paramref name="obj1"/> and <paramref name="obj2"/> according to <see cref="IComparable.CompareTo(object?)"/>.
	/// </para>
	/// <para>
	/// If <paramref name="obj1"/> is <c>null</c>, this implementation returns <paramref name="obj2"/>.
	/// If both are <c>null</c>, returns <c>null</c>.
	/// </para>
	/// </returns>
	/// <remarks>
	/// This method is the counterpart to <see cref="Max{T}(T,T)"/> and relies on the runtime
	/// implementation of <see cref="IComparable"/> for ordering semantics.
	/// No special handling is performed for <c>null</c> beyond the null-conditional check on <paramref name="obj1"/>.
	/// </remarks>
	/// <example>
	/// <code>
	/// int? minInt = TypeHelper.Min(5, 10);        // 5
	/// string? minStr = TypeHelper.Min("b", "a");  // "a" (lexicographical)
	/// 
	/// // With nulls
	/// int? result1 = TypeHelper.Min(null, 3);     // 3
	/// int? result2 = TypeHelper.Min(3, null);     // null (by current semantics)
	/// int? result3 = TypeHelper.Min(null, null);  // null
	/// </code>
	/// </example>
	[Information(nameof(Min), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static T? Min<T>([AllowNull] T? obj1, [AllowNull] T? obj2) where T : IComparable
	{
		return obj1?.CompareTo(obj2) < 0 ? obj1 : obj2;
	}

	/// <summary>
	/// Processes a generic type to construct its display name, including handling of generic arguments.
	/// </summary>
	/// <param name="builder">The <see cref="StringBuilder"/> used to build the display name.</param>
	/// <param name="type">The generic type to process.</param>
	/// <param name="genericArguments">The array of generic arguments for the type.</param>
	/// <param name="length">The number of generic arguments to consider.</param>
	/// <param name="options">Display name options to customize the output.</param>
	[Information(nameof(ProcessGenericType), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void ProcessGenericType([DisallowNull] StringBuilder builder, [DisallowNull] Type type, [DisallowNull] Type[] genericArguments, int length, DisplayNameOptions options)
	{
		builder = builder.ArgumentNotNull();
		type = type.ArgumentNotNull();
		genericArguments = genericArguments.ArgumentNotNull();

		var offset = type.IsNested ? type.DeclaringType!.GetGenericArguments().Length : 0;

		AppendFullNamePrefix(builder, type, genericArguments, offset, options);

		var genericPartIndex = type.Name.IndexOf('`', StringComparison.Ordinal);

		if (genericPartIndex <= 0)
		{
			_ = builder.Append(type.Name);
			return;
		}

		_ = builder.Append(type.Name.AsSpan(0, genericPartIndex));

		if (options.IncludeGenericParameters)
		{
			AppendGenericArguments(builder, genericArguments, offset, length, options);
		}
	}

	/// <summary>
	/// Appends the full-name prefix (namespace or parent type) for a generic type to the builder.
	/// </summary>
	private static void AppendFullNamePrefix(StringBuilder builder, Type type, Type[] genericArguments, int offset, DisplayNameOptions options)
	{
		if (!options.FullName)
		{
			return;
		}

		if (type.IsNested)
		{
			ProcessGenericType(builder, type.DeclaringType!, genericArguments, offset, options);
			_ = builder.Append(options.NestedTypeDelimiter);
		}
		else if (!string.IsNullOrEmpty(type.Namespace))
		{
			_ = builder.Append(type.Namespace);
			_ = builder.Append(ControlChars.Dot);
		}
	}

	/// <summary>
	/// Appends the generic argument list (angle brackets and type names) to the builder.
	/// </summary>
	private static void AppendGenericArguments(StringBuilder builder, Type[] genericArguments, int offset, int length, DisplayNameOptions options)
	{
		_ = builder.Append(ControlChars.StartAngleBracket);

		var lastIndex = length - 1;

		for (var typeCount = offset; typeCount < length; typeCount++)
		{
			ProcessType(builder, genericArguments[typeCount], options);

			if (typeCount != lastIndex)
			{
				_ = builder.Append(ControlChars.Comma);

				if (options.IncludeGenericParameterNames || !genericArguments[typeCount + 1].IsGenericParameter)
				{
					_ = builder.Append(ControlChars.Space);
				}
			}
		}

		_ = builder.Append(ControlChars.EndAngleBracket);
	}

	/// <summary>
	/// Appends the simple (non-generic, non-array) type name to the builder, applying nested-type delimiter substitution when needed.
	/// </summary>
	private static void AppendSimpleTypeName(StringBuilder builder, Type type, DisplayNameOptions options)
	{
		var name = options.FullName && type.FullName is not null ? type.FullName : type.Name;
		_ = builder.Append(name);

		if (options.NestedTypeDelimiter != ControlChars.Plus)
		{
			_ = builder.Replace(ControlChars.Plus, options.NestedTypeDelimiter, builder.Length - name.Length, name.Length);
		}
	}

	/// <summary>
	/// Collects all members of the specified type decorated with <typeparamref name="TAttribute"/>.
	/// </summary>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	private static MemberInfo[] CollectMembersWithAttribute<TAttribute>(Type type) where TAttribute : Attribute
	{
		var bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
		var allMembers = type.GetMembers(bindingFlags);
		var result = new List<MemberInfo>(allMembers.Length + 1);

		if (Attribute.IsDefined(type, typeof(TAttribute), true))
		{
			result.Add(type);
		}

		foreach (var member in allMembers.AsSpan())
		{
			if (Attribute.IsDefined(member, typeof(TAttribute), true))
			{
				result.Add(member);
			}
		}

		return result.ToArray();
	}

	/// <summary>
	/// Computes and initializes the list of built-in .NET types that are considered primitive for the purposes of this utility class.
	/// This method populates the <see cref="_builtInTypes"/> collection with types that are commonly used and recognized as fundamental types within .NET applications.
	/// </summary>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	private static void ComputeBuiltInTypes()
	{
		// Use a HashSet to store the built-in types for faster lookups
		var builtInTypes = new HashSet<Type>();

		// Get all the assemblies loaded in the current app domain
		var assemblies = AppDomain.CurrentDomain.GetAssemblies();

		// Loop through each assembly
		foreach (var assembly in assemblies)
		{
			// Get the types defined in the assembly
			Type[] types;
			try
			{
				types = assembly.GetTypes();
			}
			catch (ReflectionTypeLoadException ex)
			{
				types = [.. ex.Types.Where(t => t != null)!];
			}

			// Loop through each type
			foreach (var type in types)
			{
				// Check if the type is a built-in type
				if (IsBuiltinType(type))
				{
					// Add the type to the HashSet
					_ = builtInTypes.Add(type);
				}
			}
		}

		// Convert the HashSet to a read-only collection
		_builtInTypes = builtInTypes;
	}

	/// <summary>
	/// Determines whether the specified <see cref="TypeInfo"/> is derived from or implements <paramref name="baseType"/>.
	/// </summary>
	private static bool IsDerivedType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] TypeInfo type, Type baseType)
	{
		return baseType.IsInterface
			? type.ImplementedInterfaces.Contains(baseType)
			: type.IsSubclassOf(baseType);
	}

	/// <summary>
	/// Loads types derived from a specified base type from a collection of TypeInfo objects.
	/// </summary>
	/// <param name="types">The collection of TypeInfo objects to search through.</param>
	/// <param name="baseType">The base type to find derived types of.</param>
	/// <param name="classOnly">If true, only class types are considered; otherwise, interfaces are also considered.</param>
	/// <returns>An enumerable collection of types that are derived from the specified base type.</returns>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	private static IEnumerable<Type> LoadDerivedTypes(IEnumerable<TypeInfo> types, Type baseType, bool classOnly)
	{
		foreach (var type in types)
		{
			if (classOnly && !type.IsClass)
			{
				continue;
			}

			if (IsDerivedType(type, baseType))
			{
				yield return type.AsType();
			}
		}
	}

	/// <summary>
	/// Processes a given type to construct its display name, handling generic types and applying specified display options.
	/// </summary>
	/// <param name="builder">The <see cref="StringBuilder"/> instance used to build the display name.</param>
	/// <param name="type">The type to process for display.</param>
	/// <param name="options">Options that specify how the display name should be formatted.</param>
	[Information(OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	private static void ProcessType(in StringBuilder builder, in Type type, in DisplayNameOptions options)
	{
		if (type.IsGenericType)
		{
			var genericArguments = type.GetGenericArguments();
			ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);
		}
		else if (type.IsArray)
		{
			ProcessType(builder, type.GetElementType()!, options);
			_ = builder.Append("[]");
		}
		else if (type.IsGenericParameter)
		{
			if (options.IncludeGenericParameterNames)
			{
				_ = builder.Append(type.Name);
			}
		}
		else
		{
			AppendSimpleTypeName(builder, type, options);
		}
	}

	/// <summary>
	/// Attempts to load a .NET assembly from the specified file and add any derived types to the list.
	/// Silently traces and skips on format, load, or type errors.
	/// </summary>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	private static void TryAddDerivedTypesFromFile(string fileName, Type baseType, bool classOnly, List<Type> foundTypes)
	{
		try
		{
			if (!AssemblyHelper.IsDotNetAssembly(new FileInfo(fileName)))
			{
				return;
			}

			var assembly = Assembly.LoadFrom(fileName);
			var exportedTypes = assembly.ExportedTypes.Where(p => p.BaseType is not null).ToImmutableArray();

			if (!exportedTypes.IsEmpty && exportedTypes.Any(p => string.Equals(p.BaseType?.FullName, baseType.FullName, StringComparison.Ordinal)))
			{
				foundTypes.AddRange(LoadDerivedTypes(assembly.DefinedTypes, baseType, classOnly));
			}
		}
		catch (Exception ex) when (ex is BadImageFormatException or FileLoadException or FileNotFoundException or TypeLoadException)
		{
			Trace.WriteLine(ex.GetAllMessages());
		}
	}


	/// <summary>
	/// Attempts to format a property value as a string.
	/// Returns <c>false</c> (and <paramref name="formatted"/> = <c>null</c>) when the value is null or an empty dictionary.
	/// </summary>
	private static bool TryFormatPropertyValue(object? value, out string? formatted)
	{
		if (value is null)
		{
			formatted = null;
			return false;
		}

		if (value is IDictionary dictionary)
		{
			if (dictionary.Count == 0)
			{
				formatted = null;
				return false;
			}

			formatted = dictionary.ToDelimitedString();
			return true;
		}

		formatted = value is string s ? s : value.ToString();
		return true;
	}
}
