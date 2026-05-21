// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>
// Extension methods for all objects providing deep cloning (<c>FastClone</c>, <c>FastBinaryClone</c>),
// SHA-256 hashing (<c>ComputeSha256Hash</c>), JSON serialization/deserialization (<c>ToJson</c>,
// <c>FromJson</c>, <c>ToJsonFile</c>), property and field inspection (<c>PropertiesToDictionary</c>,
// <c>PropertiesToString</c>, <c>FieldsToDictionary</c>, <c>FieldsToString</c>), null checks
// (<c>IsNull</c>, <c>IsNotNull</c>, <c>StripNull</c>), disposal helpers (<c>TryDispose</c>,
// <c>DisposeFields</c>, <c>DisposeCollection</c>), and general utilities (<c>As</c>, <c>Max</c>,
// <c>Min</c>, <c>ToLazy</c>, <c>InitializeFields</c>, <c>HasProperty</c>).
// </summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using MessagePack;
using Microsoft.Extensions.ObjectPool;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for all objects, adding utility operations for cloning, hashing,
/// serialization, reflection-based inspection, and resource management.
/// </summary>
/// <remarks>
/// Methods are grouped by purpose: deep cloning via JSON or MessagePack (<c>FastClone</c>,
/// <c>FastBinaryClone</c>), SHA-256 hashing (<c>ComputeSha256Hash</c>), JSON serialization
/// (<c>ToJson</c>, <c>FromJson</c>, <c>ToJsonFile</c>), reflection-based property and field
/// inspection (<c>PropertiesToDictionary</c>, <c>PropertiesToString</c>, <c>FieldsToDictionary</c>,
/// <c>FieldsToString</c>), null and type checks (<c>IsNull</c>, <c>IsNotNull</c>, <c>IsString</c>,
/// <c>StripNull</c>), disposal (<c>TryDispose</c>, <c>DisposeFields</c>, <c>DisposeCollection</c>),
/// and general helpers (<c>As</c>, <c>Max</c>, <c>Min</c>, <c>ToLazy</c>, <c>InitializeFields</c>,
/// <c>HasProperty</c>).
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineObjectExtensions")]
public static class ObjectExtensions
{
#pragma warning disable IDE0051
	private const string Item = "Item";
#pragma warning restore IDE0051

	private static readonly ConcurrentDictionary<Type, FieldInfo[]> _allInstanceFieldsCache = new();
	private static readonly ConcurrentDictionary<Type, PropertyInfo[]> _allPropertiesCache = new();
	private static readonly FrozenDictionary<Type, string> _builtInTypeNames = TypeHelper.BuiltInTypeNames().ToFrozen();
	private static readonly ConcurrentDictionary<Type, Func<object>> _instanceFactoryCache = new();
	private static readonly ConcurrentDictionary<Type, PropertyInfo[]> _publicInstancePropertiesCache = new();
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Tries to dispose items in the <see cref="IEnumerable" /> if the type implements <see cref="IDisposable" />.
	/// </summary>
	/// <typeparam name="T">The type of the items in the collection.</typeparam>
	/// <param name="items">The collection of items to dispose.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DisposeCollection), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void DisposeCollection<T>([AllowNull] this IEnumerable<T> items) where T : IDisposable
	{
		ProcessCollectionToDispose(items);
	}

	/// <summary>
	/// Automatically disposes of all IDisposable fields within an object using reflection, simplifying memory management in classes that deal with unmanaged resources.
	/// This method is a must-use in any IDisposable implementation, ensuring resources are freed efficiently.
	/// </summary>
	/// <param name="obj">The object containing IDisposable fields to be disposed.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("This method uses reflection to enumerate and dispose fields of an IDisposable object.")]
	[Information(nameof(DisposeFields), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void DisposeFields([AllowNull] this IDisposable obj)
	{
		if (obj is null)
		{
			return;
		}

		// DON'T USE ASSPAN() HERE
#pragma warning disable IL2070 // obj.GetType() returns Type without DynamicallyAccessedMembers, but method already marked RequiresUnreferencedCode
		var objectType = obj.GetType();
#pragma warning restore IL2070
		var fields = _allInstanceFieldsCache.GetOrAdd(objectType, static t => t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));

		foreach (var field in fields)
		{
			DisposeField(field, obj);
		}
	}

	/// <summary>
	/// Deserializes a JSON string back into an object.
	/// This method simplifies working with JSON data, reducing the overhead of manual deserialization.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <returns>An instance of <typeparamref name="TResult" /> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="json" /> is null or empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(FromJson), "David McCarter", "4/21/2022", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TResult FromJson<TResult>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] this string json)
	{
		return JsonSerialization.Deserialize<TResult>(json.ArgumentNotNullOrEmpty());
	}

	/// <summary>
	/// Deserializes a JSON string back into an object using the provided <see cref="JsonSerializerOptions"/>.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for deserialization. If null, the default options are used.</param>
	/// <returns>An instance of <typeparamref name="TResult" /> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="json" /> is null or empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(FromJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TResult FromJson<TResult>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] this string json, JsonSerializerOptions? options = null)
	{
		return JsonSerialization.Deserialize<TResult>(json.ArgumentNotNullOrEmpty(), options);
	}

	/// <summary>
	/// Deserializes a JSON string back into an object using the provided <see cref="JsonTypeInfo{TResult}"/>.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <param name="typeInfo">The <see cref="JsonTypeInfo{TResult}"/> to use for deserialization. If null, an <see cref="ArgumentNullException"/> is thrown.</param>
	/// <returns>An instance of <typeparamref name="TResult" /> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="json" /> is null or empty, or if <paramref name="typeInfo"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FromJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static TResult FromJson<TResult>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] this string json, JsonTypeInfo<TResult> typeInfo)
	{
		return JsonSerialization.Deserialize(json.ArgumentNotNullOrEmpty(), typeInfo.ArgumentNotNull());
	}

	/// <summary>
	/// Wraps the specified value in a <see cref="Lazy{T}"/> instance using a pre-initialized value.
	/// </summary>
	/// <typeparam name="T">The type of the value to wrap.</typeparam>
	/// <param name="value">The value to wrap in a <see cref="Lazy{T}"/>. Cannot be null.</param>
	/// <returns>
	/// A <see cref="Lazy{T}"/> instance containing the pre-initialized value.
	/// </returns>
	/// <remarks>
	/// <para>
	/// This method creates a <see cref="Lazy{T}"/> instance with a pre-initialized value,
	/// avoiding lazy initialization overhead. The value is validated immediately upon method invocation.
	/// </para>
	/// <para>
	/// The returned <see cref="Lazy{T}"/> instance is thread-safe by default and can be safely
	/// accessed from multiple threads concurrently without additional synchronization.
	/// </para>
	/// <para>
	/// Use this method when you want to wrap an already-computed value in a <see cref="Lazy{T}"/>
	/// wrapper for deferred access patterns or to maintain API consistency with lazy-initialized values.
	/// </para>
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
	/// <example>
	/// <code>
	/// var person = new Person { Name = "John", Age = 30 };
	/// Lazy&lt;Person&gt; lazyPerson = person.ToLazy();
	/// 
	/// // Value is already initialized - no lazy evaluation occurs
	/// var result = lazyPerson.Value; // Returns the original person instance
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[UnconditionalSuppressMessage("Trimming", "IL2091", Justification = "Lazy<T> is constructed with a factory delegate overload; the PublicParameterlessConstructor constraint on Lazy<T>'s type parameter is not exercised at runtime.")]
	[Information(nameof(ToLazy), author: "David McCarter", createdOn: "9/8/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Lazy<T> ToLazy<T>([DisallowNull] this T value)
	{
		value = value.ArgumentNotNull();

		return new Lazy<T>(() => value);
	}

	/// <summary>
	/// Attempts to dispose the specified <see cref="IDisposable"/> object, silently swallowing any exceptions.
	/// </summary>
	/// <param name="obj">The <see cref="IDisposable"/> object to dispose.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static void TryDispose(this IDisposable obj)
	{
		TryDispose(obj.ArgumentNotNull(), false);
	}

	/// <summary>
	/// Attempts to dispose the specified <see cref="IDisposable"/> object.
	/// Optionally re-throws any exception that occurs during disposal.
	/// </summary>
	/// <param name="obj">The <see cref="IDisposable" /> object to dispose.</param>
	/// <param name="throwException">Specifies whether to throw an exception if the disposal fails.</param>
	/// <exception cref="Exception">Thrown if <paramref name="throwException" /> is true and the disposal fails.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void TryDispose([AllowNull] this IDisposable obj, [DoesNotReturnIf(true)] bool throwException)
	{
		if (obj is null)
		{
			return;
		}

		try
		{
			DisposeObjectInternal(obj);
		}
		catch
		{
			if (throwException)
			{
				throw;
			}
		}
	}

	/// <summary>Adds an error placeholder entry when <paramref name="ignoreNulls"/> is <c>false</c>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddPropertyError), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void AddPropertyError(Dictionary<string, string> properties, PropertyInfo property, string typeName, bool ignoreNulls, string errorTypeName)
	{
		if (!ignoreNulls)
		{
			var propertyName = string.IsNullOrEmpty(typeName) ? property.Name : string.Concat(typeName, ControlChars.Dot.ToString(), property.Name);
			properties[propertyName] = string.Concat("[Error: ", errorTypeName, "]");
		}
	}

	/// <summary>Adds a single property value (or empty string for null) to <paramref name="properties"/>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AddSelectedPropertyValueCore), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void AddSelectedPropertyValueCore(Dictionary<string, string> properties, PropertyInfo property, object obj, string typeName, bool ignoreNulls)
	{
		if (!property.CanRead || property.GetIndexParameters().Length > 0)
		{
			return;
		}

		var value = property.GetValue(obj);
		var propertyName = BuildPropertyName(property.Name, typeName);
		SetPropertyValue(properties, propertyName, value, ignoreNulls);
	}

	/// <summary>Builds a fields dictionary for a complex (non-enumerable, non-built-in) object.</summary>
	[RequiresUnreferencedCode("Uses reflection to enumerate and read type fields.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BuildComplexTypeFieldsDictionary), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static ReadOnlyDictionary<string, string> BuildComplexTypeFieldsDictionary(string memberName, object obj, Type objectType, bool ignoreEmptyValues)
	{
		var result = new Dictionary<string, string>();
		var newMemberName = memberName.Length > 0 ? string.Concat(memberName, ControlChars.Dot.ToString()) : string.Empty;

		// DON'T USE SPAN HERE
		var fields = _allInstanceFieldsCache.GetOrAdd(objectType, static t => t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));

		for (var fieldIndex = 0; fieldIndex < fields.Length; fieldIndex++)
		{
			var field = fields[fieldIndex];

			if (!field.IsDefined(typeof(CompilerGeneratedAttribute), false))
			{
				TryMergeFieldToResult(result, field, obj, newMemberName, ignoreEmptyValues);
			}
		}

		return result.AsReadOnly();
	}

	/// <summary>Builds a properties dictionary for a complex (non-enumerable, non-built-in) object.</summary>
	[RequiresUnreferencedCode("Uses reflection to enumerate and read type properties.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BuildComplexTypePropertiesDictionary), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static ReadOnlyDictionary<string, string> BuildComplexTypePropertiesDictionary(string memberName, object obj, bool ignoreNulls)
	{
		var result = new Dictionary<string, string>();
		var newMemberName = memberName.Length > 0 ? string.Concat(memberName, ControlChars.Dot.ToString()) : string.Empty;

#pragma warning disable IL2070 // obj.GetType() returns Type without DynamicallyAccessedMembers; caller already marked RequiresUnreferencedCode
		var objectType = obj.GetType();
#pragma warning restore IL2070
		var properties = _allPropertiesCache.GetOrAdd(objectType, static t => t.GetProperties());

		for (var propIndex = 0; propIndex < properties.Length; propIndex++)
		{
			var property = properties[propIndex];

			if (property.GetAttribute<JsonIgnoreAttribute>() == null && property.GetIndexParameters().Length == 0 && property.CanRead)
			{
				TryMergePropertyToResult(result, property, obj, newMemberName, ignoreNulls);
			}
		}

		return result.AsReadOnly();
	}

	/// <summary>Builds a fields dictionary for an <see cref="IEnumerable"/> object using indexed keys.</summary>
	[RequiresUnreferencedCode("Recursively calls FieldsToDictionary which uses reflection.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BuildEnumerableFieldsDictionary), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static ReadOnlyDictionary<string, string> BuildEnumerableFieldsDictionary(string memberName, IEnumerable items, bool ignoreEmptyValues)
	{
		var result = new Dictionary<string, string>();
		var itemCount = 0;

		foreach (var item in items)
		{
			var itemInnerMember = string.Concat(memberName, "[", itemCount++.ToString(CultureInfo.CurrentCulture), "]");
			MergeFieldsDictionaryToResult(result, item.FieldsToDictionary(itemInnerMember, ignoreEmptyValues), ignoreEmptyValues);
		}

		return result.AsReadOnly();
	}

	/// <summary>Builds a properties dictionary for an <see cref="IEnumerable"/> object using indexed keys.</summary>
	[RequiresUnreferencedCode("Recursively calls PropertiesToDictionary which uses reflection.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BuildEnumerablePropertiesDictionary), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static ReadOnlyDictionary<string, string> BuildEnumerablePropertiesDictionary(string memberName, IEnumerable items)
	{
		var result = new Dictionary<string, string>();
		var itemCount = 0;

		foreach (var item in items)
		{
			var itemInnerMember = string.Concat(memberName, "[", itemCount++.ToString(CultureInfo.CurrentCulture), "]");
			TryMergeItemProperties(result, item, itemInnerMember);
		}

		return result.AsReadOnly();
	}

	/// <summary>Builds a key=value formatted string from a properties dictionary.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BuildKeyValueString), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static string BuildKeyValueString(IReadOnlyDictionary<string, string> properties, string? header, string sequenceSeparator, char keyValueSeparator)
	{
		var sb = _stringBuilderPool.Value.Get();

		try
		{
			if (header is { Length: > 0 })
			{
				_ = sb.Append(header);
			}

			var isFirst = true;

			foreach (var pair in properties)
			{
				if (!isFirst)
				{
					_ = sb.Append(sequenceSeparator);
				}

				isFirst = false;
				_ = sb.Append(pair.Key);
				_ = sb.Append(keyValueSeparator);
				_ = sb.Append(pair.Value);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb.Clear());
		}
	}

	/// <summary>Builds a dot-qualified property name from its simple name and an optional type prefix.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BuildPropertyName), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static string BuildPropertyName(string name, string typeName)
	{
		return string.IsNullOrEmpty(typeName) ? name : string.Concat(typeName, ControlChars.Dot.ToString(), name);
	}

	/// <summary>Builds a dictionary from the properties selected by <paramref name="propertySelector"/>.</summary>
	[RequiresUnreferencedCode("Uses reflection to enumerate type properties.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BuildSelectedPropertiesDictionary), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static Dictionary<string, string> BuildSelectedPropertiesDictionary(object obj, Func<PropertyInfo, bool> propertySelector, string typeName, bool ignoreNulls)
	{
#pragma warning disable IL2070 // obj.GetType() returns Type without DynamicallyAccessedMembers; caller already marked RequiresUnreferencedCode
		var objectType = obj.GetType();
#pragma warning restore IL2070
		var allProperties = _publicInstancePropertiesCache.GetOrAdd(objectType, static t => t.GetProperties(BindingFlags.Public | BindingFlags.Instance));

		var properties = new Dictionary<string, string>(allProperties.Length);

		for (var propIndex = 0; propIndex < allProperties.Length; propIndex++)
		{
			var property = allProperties[propIndex];

			if (propertySelector(property))
			{
				TryAddSelectedPropertyValue(properties, property, obj, typeName, ignoreNulls);
			}
		}

		return properties;
	}

	/// <summary>Disposes a single field of an object when its runtime value implements <see cref="IEnumerable{T}"/> of <see cref="IDisposable"/> or <see cref="IDisposable"/> directly.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DisposeField), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void DisposeField(FieldInfo field, IDisposable obj)
	{
		var fieldValue = field.GetValue(obj);

		if (fieldValue is IEnumerable<IDisposable> collection)
		{
			collection.DisposeCollection();
		}
		else if (fieldValue is IDisposable disposableField)
		{
			disposableField.TryDispose();
		}
	}

	/// <summary>Disposes an object, handling both <see cref="IAsyncDisposable"/> and <see cref="IDisposable"/>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DisposeObjectInternal), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void DisposeObjectInternal(IDisposable obj)
	{
		if (obj is IAsyncDisposable asyncDisposable)
		{
#pragma warning disable CA2012 // Use ValueTasks correctly – deliberately fire-and-forget
#pragma warning disable IDISP007 // Don't dispose injected – DisposeObjectInternal is specifically designed to dispose its argument
			_ = asyncDisposable.DisposeAsync();
#pragma warning restore IDISP007
#pragma warning restore CA2012
		}
		else
		{
#pragma warning disable IDISP007 // Don't dispose injected – DisposeObjectInternal is specifically designed to dispose its argument
			obj.Dispose();
#pragma warning restore IDISP007
		}
	}

	/// <summary>Returns a new <see cref="ReadOnlyDictionary{TKey,TValue}"/> with empty-value entries removed.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FilterEmptyProperties), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static ReadOnlyDictionary<string, string> FilterEmptyProperties(ReadOnlyDictionary<string, string> properties)
	{
		var filtered = new Dictionary<string, string>(properties.Count);

		foreach (var kvp in properties)
		{
			if (!string.IsNullOrEmpty(kvp.Value))
			{
				filtered[kvp.Key] = kvp.Value;
			}
		}

		return filtered.AsReadOnly();
	}

	/// <summary>Returns a new <see cref="Dictionary{TKey,TValue}"/> with empty-value entries removed.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FilterEmptyPropertiesDict), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static Dictionary<string, string> FilterEmptyPropertiesDict(Dictionary<string, string> properties)
	{
		var filtered = new Dictionary<string, string>(properties.Count);

		foreach (var kvp in properties)
		{
			if (!string.IsNullOrEmpty(kvp.Value))
			{
				filtered[kvp.Key] = kvp.Value;
			}
		}

		return filtered;
	}

	/// <summary>Merges source fields-dictionary entries into <paramref name="result"/>, filtering empty values when requested.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MergeFieldsDictionaryToResult), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void MergeFieldsDictionaryToResult(Dictionary<string, string> result, ReadOnlyDictionary<string, string> source, bool ignoreEmptyValues)
	{
		foreach (var kvp in source)
		{
			if (ShouldSkipEmptyEntry(kvp.Value, ignoreEmptyValues))
			{
				continue;
			}

			result[kvp.Key] = kvp.Value;
		}
	}

	/// <summary>Reads a property value and merges its nested entries into <paramref name="result"/>.</summary>
	[RequiresUnreferencedCode("Calls PropertiesToDictionary which uses reflection.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MergePropertyValueToResult), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void MergePropertyValueToResult(Dictionary<string, string> result, PropertyInfo property, object obj, string memberPrefix, bool ignoreNulls)
	{
		if (!property.CanRead || property.GetIndexParameters().Length > 0)
		{
			return;
		}

		var innerObject = property.GetValue(obj, null);

		if (ShouldSkipNullValue(innerObject, ignoreNulls))
		{
			return;
		}

		var innerMember = string.Concat(memberPrefix, property.Name);

		foreach (var kvp in innerObject!.PropertiesToDictionary(innerMember, ignoreNulls))
		{
			result[kvp.Key] = kvp.Value;
		}
	}


	/// <summary>
	/// Processes the <see cref="IEnumerable" /> to dispose items if they implement <see cref="IDisposable" />.
	/// </summary>
	/// <typeparam name="T">The type of the items in the collection, constrained to <see cref="IDisposable" />.</typeparam>
	/// <param name="items">The collection of items to dispose. If null, the method returns without doing anything.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ProcessCollectionToDispose), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void ProcessCollectionToDispose<T>([AllowNull] IEnumerable<T> items) where T : IDisposable
	{
		if (items is null)
		{
			return;
		}

		foreach (var item in items)
		{
			item?.Dispose();
		}
	}

	/// <summary>
	/// Resolves the correct <see cref="ReadOnlyDictionary{TKey,TValue}"/> representation of <paramref name="obj"/>
	/// based on whether it is a built-in type, an enumerable, or a complex object.
	/// </summary>
	[RequiresUnreferencedCode("Calls BuildComplexTypePropertiesDictionary which uses reflection.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ResolvePropertiesDictionary), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static ReadOnlyDictionary<string, string> ResolvePropertiesDictionary(string memberName, object obj, bool ignoreNulls, Type objectType)
	{
		return _builtInTypeNames.ContainsKey(objectType)
			? new ReadOnlyDictionary<string, string>(new Dictionary<string, string> { { memberName, obj.ToString()! } })
			: objectType.IsEnumerable()
				? BuildEnumerablePropertiesDictionary(memberName, (IEnumerable)obj)
				: BuildComplexTypePropertiesDictionary(memberName, obj, ignoreNulls);
	}

	/// <summary>Resolves the type-name prefix used by <c>PropertiesToString</c> and <c>FieldsToString</c>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ResolveStringTypeName), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static string ResolveStringTypeName(string typeName, bool includeMemberName)
	{
		if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
		{
			return Item;
		}

		return includeMemberName ? typeName : string.Empty;
	}

	/// <summary>Writes an empty string for a null property when <paramref name="ignoreNulls"/> is <c>false</c>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SetNullPropertyValue), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void SetNullPropertyValue(Dictionary<string, string> properties, string propertyName, bool ignoreNulls)
	{
		if (!ignoreNulls)
		{
			properties[propertyName] = string.Empty;
		}
	}

	/// <summary>Writes the string representation of <paramref name="value"/> into <paramref name="properties"/>, or an empty string when null and <paramref name="ignoreNulls"/> is <c>false</c>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SetPropertyValue), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void SetPropertyValue(Dictionary<string, string> properties, string propertyName, object? value, bool ignoreNulls)
	{
		if (value is null)
		{
			SetNullPropertyValue(properties, propertyName, ignoreNulls);
		}
		else
		{
			properties[propertyName] = value.ToString()!;
		}
	}

	/// <summary>Returns <c>true</c> when <c>PropertiesToDictionary</c> should return a null-placeholder entry.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ShouldReturnNullPlaceholder), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static bool ShouldReturnNullPlaceholder(string memberName, object? obj, bool ignoreNulls)
	{
		return memberName.HasValue() && obj is null && ignoreNulls is false;
	}

	/// <summary>Returns <c>true</c> when an empty-value entry should be skipped.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ShouldSkipEmptyEntry), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static bool ShouldSkipEmptyEntry(string value, bool ignoreEmptyValues)
	{
		return ignoreEmptyValues && string.IsNullOrEmpty(value);
	}

	/// <summary>Returns <c>true</c> when a null value should be skipped because <paramref name="ignoreNulls"/> is <c>true</c>.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ShouldSkipNullValue), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static bool ShouldSkipNullValue(object? value, bool ignoreNulls)
	{
		return ignoreNulls && value is null;
	}

	/// <summary>Tries to add a selected property's value to <paramref name="properties"/>, swallowing retrieval exceptions.</summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryAddSelectedPropertyValue), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void TryAddSelectedPropertyValue(Dictionary<string, string> properties, PropertyInfo property, object obj, string typeName, bool ignoreNulls)
	{
		try
		{
			AddSelectedPropertyValueCore(properties, property, obj, typeName, ignoreNulls);
		}
#pragma warning disable CA1031 // Intentionally broad: property reflection may throw unpredictably; value is best-effort
		catch (Exception ex)
#pragma warning restore CA1031
		{
			AddPropertyError(properties, property, typeName, ignoreNulls, ex.GetType().Name);
		}
	}

	/// <summary>Initializes a single field to its default value when it is null and not a value type.</summary>
	[RequiresUnreferencedCode("Uses Activator.CreateInstance to construct field default values.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryInitializeField), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void TryInitializeField(FieldInfo field, object obj)
	{
		if (field.GetValue(obj) == null && !field.FieldType.IsValueType)
		{
			var factory = _instanceFactoryCache.GetOrAdd(field.FieldType, static fieldType =>
			{
				// Prefer a public parameterless constructor compiled to a delegate (50-100x faster than Activator.CreateInstance).
				// Fall back to Activator.CreateInstance for types that have only non-public constructors
				// (e.g., singletons, internal types), matching the original behaviour of passing true for nonPublic.
				var constructor = fieldType.GetConstructor(BindingFlags.Public | BindingFlags.Instance, binder: null, types: Type.EmptyTypes, modifiers: null);
				if (constructor is not null)
				{
					var newExpr = Expression.New(constructor);
					return Expression.Lambda<Func<object>>(Expression.Convert(newExpr, typeof(object))).Compile();
				}

				// Non-public constructor fallback — still faster than uncached Activator.CreateInstance
				// because the delegate itself is compiled and cached.
#pragma warning disable IL2072 // RequiresUnreferencedCode propagated from caller
				return () => Activator.CreateInstance(fieldType, nonPublic: true)!;
#pragma warning restore IL2072
			});

			field.SetValue(obj, factory());
		}
	}

	/// <summary>Reads a field value and merges its nested entries into <paramref name="result"/>.</summary>
	[RequiresUnreferencedCode("Calls FieldsToDictionary which uses reflection.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryMergeFieldToResult), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void TryMergeFieldToResult(Dictionary<string, string> result, FieldInfo field, object obj, string memberPrefix, bool ignoreEmptyValues)
	{
		var innerObject = field.GetValue(obj);

		if (innerObject is null)
		{
			return;
		}

		var innerMember = string.Concat(memberPrefix, field.Name);
		MergeFieldsDictionaryToResult(result, innerObject.FieldsToDictionary(innerMember, ignoreEmptyValues), ignoreEmptyValues);
	}

	/// <summary>Tries to merge the properties of one enumerable item into <paramref name="result"/>, swallowing exceptions.</summary>
	[RequiresUnreferencedCode("Calls PropertiesToDictionary which uses reflection.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryMergeItemProperties), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void TryMergeItemProperties(Dictionary<string, string> result, object item, string itemMemberName)
	{
		try
		{
			foreach (var kvp in item.PropertiesToDictionary(itemMemberName))
			{
				result[kvp.Key] = kvp.Value;
			}
		}
#pragma warning disable CA1031 // Intentionally broad: item reflection may throw unpredictably; value is best-effort
		catch (Exception ex)
#pragma warning restore CA1031
		{
			Trace.WriteLine(ex.Message);
		}
	}

	/// <summary>Tries to merge one property's nested dictionary into <paramref name="result"/>, swallowing exceptions.</summary>
	[RequiresUnreferencedCode("Calls PropertiesToDictionary which uses reflection.")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryMergePropertyToResult), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void TryMergePropertyToResult(Dictionary<string, string> result, PropertyInfo property, object obj, string memberPrefix, bool ignoreNulls)
	{
		try
		{
			MergePropertyValueToResult(result, property, obj, memberPrefix, ignoreNulls);
		}
#pragma warning disable CA1031 // Intentionally broad: property reflection may throw unpredictably; value is best-effort
		catch (Exception ex)
#pragma warning restore CA1031
		{
			Trace.WriteLine(ex.Message);
		}
	}

	/// <summary>
	/// Provides extension methods for a specific object instance.
	/// </summary>
	/// <param name="obj">The object instance to extend.</param>
	extension([DisallowNull] object obj)
	{

		/// <summary>
		/// Serializes the object to a JSON file using a source-generated <see cref="JsonTypeInfo{T}"/>
		/// for trim-safe, AOT-compatible serialization. Uses optimized streaming I/O to avoid
		/// intermediate string allocations.
		/// </summary>
		/// <typeparam name="T">The type of the object to serialize. The object must be assignable to <typeparamref name="T"/>.</typeparam>
		/// <param name="file">The <see cref="FileInfo"/> representing the destination file. Must not be null.</param>
		/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> used for trim-safe JSON serialization.</param>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="typeInfo"/> is null.</exception>
		/// <exception cref="InvalidOperationException">Thrown if the object is not assignable to <typeparamref name="T"/>.</exception>
		/// <exception cref="JsonException">Thrown if an error occurs during serialization.</exception>
		/// <exception cref="IOException">Thrown if an error occurs while writing the file.</exception>
		/// <example>
		/// <code>
		/// var person = new Person { Name = "Alice", Age = 30 };
		/// var file = new FileInfo("person.json");
		/// person.ToJsonFile(file, MyJsonContext.Default.Person);
		/// </code>
		/// </example>
		[Information(nameof(ToJsonFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void ToJsonFile<T>([DisallowNull] FileInfo file, [DisallowNull] JsonTypeInfo<T> typeInfo)
		{
			file = file.ArgumentNotNull();
			typeInfo = typeInfo.ArgumentNotNull();

			if (obj is not T typedObject)
			{
				throw new InvalidOperationException($"The object is not of type {typeof(T).FullName}.");
			}

			file.Directory?.Create();

			using var stream = new FileStream(
				file.FullName,
				FileMode.Create,
				FileAccess.Write,
				FileShare.None,
				bufferSize: 81920,
				FileOptions.SequentialScan);

			JsonSerializer.Serialize(stream, typedObject, typeInfo);
		}

		/// <summary>
		/// Returns the maximum of two comparable objects.
		/// </summary>
		/// <typeparam name="T">The type of the objects to compare. Must implement <see cref="IComparable"/>.</typeparam>
		/// <param name="obj2">The second object to compare. This parameter can be null.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Max), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public T? Max<T>([DisallowNull] T obj2) where T : IComparable
		{
			return obj is T comparableObj
				? TypeHelper.Max(comparableObj, obj2)
				: throw new InvalidOperationException($"The object is not of type {typeof(T).Name} which implements IComparable.");
		}

		/// <summary>
		/// Returns the minimum of two comparable objects.
		/// </summary>
		/// <typeparam name="T">The type of the objects to compare. Must implement <see cref="IComparable"/>.</typeparam>
		/// <param name="obj2">The second object to compare. This parameter can be null.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Min), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public T? Min<T>([DisallowNull] T obj2) where T : IComparable
		{
			return obj is T comparableObj
				? TypeHelper.Min(comparableObj, obj2)
				: throw new InvalidOperationException($"The object is not of type {typeof(T).Name} which implements IComparable.");
		}

		/// <summary>
		/// Serializes the object to a JSON file with optimized I/O performance.
		/// </summary>
		/// <param name="file">The file to write the JSON to. Must not be null.</param>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="file"/> is null.</exception>
		/// <exception cref="JsonException">Thrown if an error occurs during serialization.</exception>
		/// <exception cref="IOException">Thrown if an error occurs while writing the file.</exception>
		/// <remarks>
		/// <para>
		/// <b>Performance Optimization (.NET 10):</b> This method uses optimized file I/O settings:
		/// </para>
		/// <list type="bullet">
		/// <item><description>Uses <see cref="FileStream"/> with 81920-byte buffer (80 KB) for efficient I/O.</description></item>
		/// <item><description>Sets <see cref="FileOptions.SequentialScan"/> for optimized sequential write access.</description></item>
		/// <item><description>Direct serialization to stream avoids intermediate string allocation.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Memory:</b> Streams directly to file without materializing JSON string in memory.</description></item>
		/// <item><description><b>I/O:</b> Uses large buffer (80 KB) to minimize system calls.</description></item>
		/// <item><description><b>Throughput:</b> Sequential scan optimization improves write performance.</description></item>
		/// </list>
		/// </remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(ToJsonFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void ToJsonFile([DisallowNull] FileInfo file)
		{
			file = file.ArgumentNotNull();
			obj = obj.ArgumentNotNull();

			// Use FileStream with optimized settings for better I/O performance
			// Buffer size: 81920 bytes (80 KB) - optimal for most scenarios
			// FileOptions.SequentialScan: Optimizes for sequential write access
			using var stream = new FileStream(
				file.FullName,
				FileMode.Create,
				FileAccess.Write,
				FileShare.None,
				bufferSize: 81920,
				FileOptions.SequentialScan);

			JsonSerializer.Serialize(stream, obj);
		}

		/// <summary>
		/// Converts an object’s properties into a string representation.
		/// </summary>
		/// <param name="header">An optional header to prepend to the string representation.</param>
		/// <param name="keyValueSeparator">The character used to separate property names from their values.</param>
		/// <param name="sequenceSeparator">The string used to separate properties in the string representation.</param>
		/// <param name="ignoreNulls">Specifies whether properties with null values should be ignored.</param>
		/// <param name="includeMemberName">Specifies whether the property name should be included in the string representation.</param>
		/// <returns>A string representation of the object's properties.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string PropertiesToString([AllowNull] string header = ControlChars.EmptyString, [ConstantExpected] char keyValueSeparator = ControlChars.Colon, [DisallowNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = false)
		{
			obj = obj.ArgumentNotNull();
			sequenceSeparator = sequenceSeparator.ArgumentNotNull();

			var typeName = ResolveStringTypeName(obj.GetType().Name, includeMemberName);
			var properties = obj.PropertiesToDictionary(memberName: typeName, ignoreNulls: ignoreNulls);

			if (ignoreNulls)
			{
				properties = FilterEmptyProperties(properties);
			}

			return BuildKeyValueString(properties, header, sequenceSeparator, keyValueSeparator);
		}

		/// <summary>
		/// Converts selected object properties into a string representation using a property selector function.
		/// </summary>
		/// <param name="propertySelector">A function that determines which properties to include in the output. Cannot be null.</param>
		/// <param name="header">An optional header to prepend to the string representation.</param>
		/// <param name="keyValueSeparator">The character used to separate property names from their values.</param>
		/// <param name="sequenceSeparator">The string used to separate properties in the string representation.</param>
		/// <param name="ignoreNulls">Specifies whether properties with null values should be ignored.</param>
		/// <param name="includeMemberName">Specifies whether the property name should be included in the string representation.</param>
		/// <returns>A string representation of the selected object properties.</returns>
		/// <remarks>
		/// <para>
		/// This overload provides fine-grained control over which properties are included in the output
		/// by using a predicate function that evaluates each <see cref="PropertyInfo"/> instance.
		/// </para>
		/// <para>
		/// <b>Common Use Cases:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Filter by property type: <c>p => p.PropertyType == typeof(string)</c></description></item>
		/// <item><description>Filter by property name: <c>p => p.Name.StartsWith("Id")</c></description></item>
		/// <item><description>Filter by custom attribute: <c>p => p.GetCustomAttribute&lt;JsonIgnoreAttribute&gt;() == null</c></description></item>
		/// <item><description>Include only readable properties: <c>p => p.CanRead</c></description></item>
		/// <item><description>Include only writable properties: <c>p => p.CanWrite</c></description></item>
		/// </list>
		/// <para>
		/// Unlike the standard PropertiesToString method which converts all properties,
		/// this overload allows selective property inclusion based on custom criteria.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">Thrown when <paramref name="propertySelector"/> or <paramref name="sequenceSeparator"/> is null.</exception>
		/// <example>
		/// <code>
		/// public class Person
		/// {
		///     public int Id { get; set; }
		///     public string Name { get; set; }
		///     public int Age { get; set; }
		///     [JsonIgnore]
		///     public string Secret { get; set; }
		/// }
		/// 
		/// var person = new Person { Id = 1, Name = "John", Age = 30, Secret = "hidden" };
		/// 
		/// // Include only string properties
		/// var stringProps = person.PropertiesToString(p => p.PropertyType == typeof(string));
		/// // Result: "Name:John"
		/// 
		/// // Include only Id property
		/// var idOnly = person.PropertiesToString(p => p.Name == "Id");
		/// // Result: "Id:1"
		/// 
		/// // Include all properties except those with JsonIgnore attribute
		/// var visible = person.PropertiesToString(p => p.GetCustomAttribute&lt;JsonIgnoreAttribute&gt;() == null);
		/// // Result: "Id:1, Name:John, Age:30"
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "12/18/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string PropertiesToString([DisallowNull] Func<PropertyInfo, bool> propertySelector, [AllowNull] string header = ControlChars.EmptyString, [ConstantExpected] char keyValueSeparator = ControlChars.Colon, [DisallowNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = false)
		{
			obj = obj.ArgumentNotNull();
			propertySelector = propertySelector.ArgumentNotNull();
			sequenceSeparator = sequenceSeparator.ArgumentNotNull();

			var typeName = ResolveStringTypeName(obj.GetType().Name, includeMemberName);
			var properties = BuildSelectedPropertiesDictionary(obj, propertySelector, typeName, ignoreNulls);

			if (ignoreNulls)
			{
				properties = FilterEmptyPropertiesDict(properties);
			}

			return BuildKeyValueString(properties, header, sequenceSeparator, keyValueSeparator);
		}

		/// <summary>
		/// Converts an object's properties into a dictionary where keys are hierarchical property names and values are their string representations.
		/// </summary>
		/// <param name="memberName">
		/// The root member name to prefix property paths with. If empty, property names are not prefixed.
		/// For nested objects and collections, hierarchical names use dot notation (e.g., "Order.Customer.Name") and array-style indexing (e.g., "Items[0].Name").
		/// </param>
		/// <param name="ignoreNulls">
		/// When <c>true</c>, properties with <c>null</c> values are excluded from the resulting dictionary.
		/// When <c>false</c>, <c>null</c> values are included as empty strings.
		/// </param>
		/// <returns>
		/// An <see cref="ReadOnlyDictionary{TKey, TValue}"/> containing property names (possibly hierarchical) mapped to their string values.
		/// Built-in types (e.g., <see cref="string"/>, <see cref="int"/>) are returned as a single entry with <paramref name="memberName"/> as the key.
		/// Collections implementing <see cref="IEnumerable"/> are flattened with indexed keys (e.g., "Items[0]", "Items[1]").
		/// </returns>
		/// <remarks>
		/// <para>
		/// Behavior by type:
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Built-in types:</b> Returns a single entry using <paramref name="memberName"/> with the object's <see cref="object.ToString"/> value.</description></item>
		/// <item><description><b>Collections (<see cref="IEnumerable"/>):</b> Each item is processed recursively using indexed keys.</description></item>
		/// <item><description><b>Complex types:</b> Public instance properties are enumerated and recursively flattened.</description></item>
		/// </list>
		/// <para>
		/// Properties decorated with <see cref="JsonIgnoreAttribute"/> are skipped.
		/// Exceptions thrown while reading property values are traced via <see cref="Trace.WriteLine(string)"/> and the property is skipped when <paramref name="ignoreNulls"/> is <c>true</c>.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Thrown when the target object is <c>null</c> and <paramref name="memberName"/> is evaluated during recursion.
		/// </exception>
		/// <example>
		/// <code>
		/// var order = new Order
		/// {
		///     Id = 123,
		///     Customer = new Customer { Name = "Alice" },
		///     Items = new List&lt;Item&gt;
		///     {
		///         new Item { Name = "Widget", Quantity = 2 },
		///         new Item { Name = "Gadget", Quantity = 1 }
		///     }
		/// };
		///
		/// var dict = order.PropertiesToDictionary("Order");
		/// // Example keys:
		/// // "Order.Id" -> "123"
		/// // "Order.Customer.Name" -> "Alice"
		/// // "Order.Items[0].Name" -> "Widget"
		/// // "Order.Items[0].Quantity" -> "2"
		/// // "Order.Items[1].Name" -> "Gadget"
		/// // "Order.Items[1].Quantity" -> "1"
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlyDictionary<string, string> PropertiesToDictionary([DisallowNull] string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
		{
			memberName = memberName.ArgumentNotNull();

			if (ShouldReturnNullPlaceholder(memberName, obj, ignoreNulls))
			{
				return new ReadOnlyDictionary<string, string>(new Dictionary<string, string> { { memberName, string.Empty } });
			}

			var typedObj = obj.ArgumentNotNull();
			return ResolvePropertiesDictionary(memberName, typedObj, ignoreNulls, typedObj.GetType());
		}

		/// <summary>
		/// Converts an object's fields into a dictionary, with field names as keys and their values as dictionary values.
		/// This method uses reflection to extract field information, including both public and private instance fields.
		/// </summary>
		/// <param name="memberName">
		/// The name of a specific member to convert. If empty, all fields are converted.
		/// This parameter is used as a prefix for hierarchical field names in nested objects.
		/// </param>
		/// <param name="ignoreEmptyValues">
		/// Specifies whether to ignore fields with null values.
		/// When <c>true</c>, null-valued fields are excluded from the resulting dictionary.
		/// When <c>false</c>, all fields are included regardless of their value.
		/// </param>
		/// <returns>
		/// A read-only dictionary containing the names and string representations of the fields of the object.
		/// For nested objects and collections, the field names are hierarchical using dot notation (e.g., "Parent.Child.Field").
		/// For collection items, the names include array-style indexing (e.g., "Items[0].Field").
		/// Built-in types are returned as their string representation without further processing.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This method processes fields differently based on the object type:
		/// </para>
		/// <list type="bullet">
		/// <item>
		/// <description>
		/// <b>Built-in types</b> (e.g., <see cref="string"/>, <see cref="int"/>, <see cref="DateTime"/>):
		/// The object's <see cref="object.ToString"/> value is returned directly.
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// <b>Collections</b> (<see cref="IEnumerable"/>): Each item in the collection is recursively processed,
		/// with field names indexed as "[0]", "[1]", etc.
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// <b>Complex objects</b>: All fields (public and private) are extracted using reflection,
		/// excluding compiler-generated fields (e.g., auto-property backing fields).
		/// Nested objects are recursively processed with hierarchical naming.
		/// </description>
		/// </item>
		/// </list>
		/// <para>
		/// <b>Performance Note:</b> This method uses reflection (<see cref="Type.GetFields(BindingFlags)"/>),
		/// which may have performance implications for frequently called code paths.
		/// Consider caching results for objects that don't change.
		/// </para>
		/// <para>
		/// <b>Compiler-Generated Fields:</b> Fields marked with <see cref="CompilerGeneratedAttribute"/>
		/// (such as backing fields for auto-implemented properties) are automatically skipped to avoid
		/// duplicate entries when used alongside <see cref="PropertiesToDictionary"/>.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// public class Person
		/// {
		///     private string _name = "John Doe";
		///     private int _age = 30;
		/// }
		/// 
		/// var person = new Person();
		/// var fieldDict = person.FieldsToDictionary();
		/// // Result: { "Person._name": "John Doe", "Person._age": "30" }
		/// 
		/// // With ignoreEmptyValues = false
		/// var allFields = person.FieldsToDictionary(ignoreEmptyValues: false);
		/// // Result includes null-valued fields
		/// </code>
		/// </example>
		/// <seealso cref="PropertiesToDictionary"/>
		/// <seealso cref="FieldsToString"/>
		/// <seealso cref="Type.GetFields(BindingFlags)"/>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(FieldsToDictionary), author: "David McCarter", createdOn: "08/22/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlyDictionary<string, string> FieldsToDictionary([DisallowNull] string memberName = ControlChars.EmptyString, bool ignoreEmptyValues = true)
		{
			memberName = memberName.ArgumentNotNull();
			var objectType = obj.ArgumentNotNull().GetType();
			var result = new Dictionary<string, string>();

			if (_builtInTypeNames.ContainsKey(objectType))
			{
				result.Add(memberName, obj.ToString()!);
				return result.AsReadOnly();
			}

			if (objectType.IsEnumerable())
			{
				return BuildEnumerableFieldsDictionary(memberName, (IEnumerable)obj, ignoreEmptyValues);
			}

			return BuildComplexTypeFieldsDictionary(memberName, obj, objectType, ignoreEmptyValues);
		}

		/// <summary>
		/// Converts an object’s fields into a string representation.
		/// </summary>
		/// <param name="header">An optional header to prepend to the string representation.</param>
		/// <param name="keyValueSeparator">The character used to separate field names from their values.</param>
		/// <param name="sequenceSeparator">The string used to separate fields in the string representation.</param>
		/// <param name="ignoreNulls">Specifies whether fields with null values should be ignored.</param>
		/// <param name="includeMemberName">Specifies whether the field name should be included in the string representation.</param>
		/// <returns>A string representation of the object's fields.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(FieldsToString), author: "David McCarter", createdOn: "08/22/2025", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string FieldsToString([AllowNull] string header = ControlChars.EmptyString, [ConstantExpected] char keyValueSeparator = ControlChars.Colon, [DisallowNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
		{
			obj = obj.ArgumentNotNull();
			sequenceSeparator = sequenceSeparator.ArgumentNotNull();

			var typeName = ResolveStringTypeName(obj.GetType().Name, includeMemberName);
			var fields = obj.FieldsToDictionary(memberName: typeName, ignoreEmptyValues: ignoreNulls);

			if (ignoreNulls)
			{
				fields = FilterEmptyProperties(fields);
			}

			return BuildKeyValueString(fields, header, sequenceSeparator, keyValueSeparator);
		}

		/// <summary>
		/// Determines whether the specified object is null.
		/// </summary>
		/// <returns><c>true</c> if the object is null; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNull()
		{
			return obj is null;
		}

		/// <summary>
		/// Determines whether the specified object is a string.
		/// </summary>
		/// <returns><c>true</c> if the object is a <see cref="string"/>; otherwise, <c>false</c>.</returns>
		/// <remarks>
		/// This method performs a type check using pattern matching to determine if the object is a string type.
		/// This is more efficient than using reflection or type comparison methods.
		/// Pattern matching with the <c>is</c> operator provides optimal performance for type checking.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsString), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
		public bool IsString()
		{
			return obj is string;
		}

		/// <summary>
		/// Determines whether the specified object is not null.
		/// </summary>
		/// <returns><c>true</c> if the object is not null; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotNull()
		{
			return obj is not null;
		}

		/// <summary>
		/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
		/// </summary>
		/// <returns>A non-null string representation of the object.</returns>
		[Pure]
		[return: NotNull]
		[Information(nameof(StripNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string StripNull()
		{
			return obj?.ToString() ?? string.Empty;
		}

		/// <summary>
		/// Automatically sets all null instance fields of an object to their default values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(InitializeFields), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void InitializeFields()
		{
			obj = obj.ArgumentNotNull();

#pragma warning disable IL2070 // obj.GetType() returns Type without DynamicallyAccessedMembers, but method already marked RequiresUnreferencedCode
			var objectType = obj.GetType();
#pragma warning restore IL2070
			var fields = _allInstanceFieldsCache.GetOrAdd(objectType, static t => t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance));

			// DON'T USE ASSPAN() HERE
			foreach (var field in fields)
			{
				TryInitializeField(field, obj);
			}
		}

		/// <summary>
		/// Determines whether an object contains a specific property.
		/// </summary>
		/// <param name="propertyName">The name of the property to check for.</param>
		/// <returns><c>true</c> if the property exists; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(HasProperty), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool HasProperty([DisallowNull] string propertyName)
		{
			propertyName = propertyName.ArgumentNotNullOrEmpty();

			// SUGGESTION FROM COPILOT SLOWER
			return obj?.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) != null;
		}

		/// <summary>
		/// Serializes an object into its JSON string representation using the provided <see cref="JsonTypeInfo{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> to use for serialization.</param>
		/// <returns>The JSON string representation of the object.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string ToJson<T>([DisallowNull] JsonTypeInfo<T> typeInfo)
		{
			obj = obj.ArgumentNotNull();
			typeInfo = typeInfo.ArgumentNotNull();

			if (obj is not T typedObject)
			{
				throw new InvalidOperationException($"The object is not of type {typeof(T).FullName}.");
			}

			return JsonSerializer.Serialize(typedObject, typeInfo);
		}

		/// <summary>
		/// Serializes an object into its JSON string representation using the provided <see cref="JsonSerializerOptions"/>.
		/// </summary>
		/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization.</param>
		/// <returns>The JSON string representation of the object.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string ToJson([AllowNull] in JsonSerializerOptions options = null)
		{
			obj = obj.ArgumentNotNull();

			return JsonSerializer.Serialize(obj, options);
		}

		/// <summary>
		/// Serializes an object into its JSON string representation.
		/// </summary>
		/// <returns>The JSON string representation of the object.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string ToJson()
		{
			return JsonSerializer.Serialize(obj.ArgumentNotNull());
		}

		/// <summary>
		/// Provides an optimized method to compute a hash code for an object.
		/// </summary>
		/// <returns>The hash code for the object.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastHashCode), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public int FastHashCode()
		{
			obj = obj.ArgumentNotNull();

			return RuntimeHelpers.GetHashCode(obj);
		}

		/// <summary>
		/// Creates a deep clone of an object by serializing it into JSON and deserializing it back using the provided <see cref="JsonTypeInfo{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> to use for serialization and deserialization.</param>
		/// <returns>A deep clone of the object.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastClone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T FastClone<T>([DisallowNull] JsonTypeInfo<T> typeInfo)
		{
			obj = obj.ArgumentNotNull();
			typeInfo = typeInfo.ArgumentNotNull();

			var json = JsonSerializer.Serialize(obj, typeInfo);
			return JsonSerializer.Deserialize(json, typeInfo)!;
		}

		/// <summary>
		/// Creates a deep clone of an object by serializing it into JSON and deserializing it back using the provided <see cref="JsonSerializerOptions"/>.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization and deserialization.</param>
		/// <returns>A deep clone of the object.</returns>
		[Pure]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastClone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T FastClone<T>(JsonSerializerOptions? options = null)
		{
			obj = obj.ArgumentNotNull();

			var json = JsonSerializer.Serialize(obj, options);
			return JsonSerializer.Deserialize<T>(json, options)!;

		}

		/// <summary>
		/// Creates a deep clone of an object by serializing it into JSON and deserializing it back.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>A deep clone of the object.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(FastClone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T FastClone<T>()
		{
			obj = obj.ArgumentNotNull();

			var json = JsonSerializer.Serialize(obj);
			return JsonSerializer.Deserialize<T>(json)!;
		}

		/// <summary>
		/// Creates a deep clone using binary MessagePack serialization.
		/// Use this when cloning performance is critical and types are annotated with MessagePack attributes.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>A deep clone of the object.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("MessagePack serialization may use runtime type discovery depending on resolver configuration.")]
		[Information(nameof(FastBinaryClone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T FastBinaryClone<T>()
		{
			obj = obj.ArgumentNotNull();

			return MessagePackSerializer.Deserialize<T>(
				MessagePackSerializer.Serialize(obj));
		}

		/// <summary>
		/// Creates a deep clone using binary MessagePack serialization with custom serializer options.
		/// Use this when you need to control serialization behavior such as resolvers, security settings, or compression.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="options">The <see cref="MessagePackSerializerOptions"/> to use for serialization and deserialization. If null, the default options are used.</param>
		/// <returns>A deep clone of the object.</returns>
		/// <remarks>
		/// <para>
		/// This overload allows customization of MessagePack serialization behavior through <see cref="MessagePackSerializerOptions"/>.
		/// Common customization scenarios include:
		/// </para>
		/// <list type="bullet">
		/// <item>
		/// <description>
		/// <b>Custom Resolvers:</b> Use <c>.WithResolver()</c> to specify custom type resolution for serialization.
		/// For example, <c>MessagePackSerializerOptions.Standard.WithResolver(MessagePack.Resolvers.StandardResolver.Instance)</c>
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// <b>Security Settings:</b> Use <c>.WithSecurity(MessagePack.MessagePackSecurity.UntrustedData)</c> when deserializing untrusted data
		/// to protect against deserialization attacks.
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// <b>Compression:</b> Enable LZ4 compression for smaller payload sizes using appropriate resolver settings.
		/// </description>
		/// </item>
		/// <item>
		/// <description>
		/// <b>Private Member Serialization:</b> Use <c>StandardResolverAllowPrivate.Options</c> to serialize non-public types and members.
		/// </description>
		/// </item>
		/// </list>
		/// <para>
		/// <b>Warning:</b> When providing custom options, ensure security settings are appropriate for your scenario.
		/// Refer to the MessagePack Security Notes at https://github.com/MessagePack-CSharp/MessagePack-CSharp for best practices.
		/// </para>
		/// </remarks>
		/// <example>
		/// <code>
		/// var person = new Person { Name = "John", Age = 30 };
		/// 
		/// // FastClone with custom security settings
		/// var options = MessagePackSerializerOptions.Standard
		///     .WithResolver(MessagePack.Resolvers.StandardResolver.Instance)
		///     .WithSecurity(MessagePack.MessagePackSecurity.UntrustedData);
		/// var clone = person.FastBinaryClone(options);
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("MessagePack serialization may use runtime type discovery depending on resolver configuration.")]
		[Information(nameof(FastBinaryClone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T FastBinaryClone<T>([AllowNull] MessagePackSerializerOptions options = null)
		{
			obj = obj.ArgumentNotNull();

			return MessagePackSerializer.Deserialize<T>(
				MessagePackSerializer.Serialize(obj, options), options);
		}

		/// <summary>
		/// Generates a SHA-256 hash of the object's serialized JSON using a source-generated <see cref="JsonTypeInfo{T}"/>
		/// for trim-safe, AOT-compatible serialization.
		/// </summary>
		/// <typeparam name="T">The type of the object to serialize. The object must be assignable to <typeparamref name="T"/>.</typeparam>
		/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> used for trim-safe JSON serialization.</param>
		/// <returns>A lowercase hexadecimal SHA-256 hash string of the object's JSON representation.</returns>
		/// <exception cref="ArgumentNullException">Thrown if the object or <paramref name="typeInfo"/> is null.</exception>
		/// <exception cref="InvalidOperationException">Thrown if the object is not assignable to <typeparamref name="T"/>.</exception>
		/// <example>
		/// <code>
		/// var person = new Person { Name = "Alice", Age = 30 };
		/// var hash = person.ComputeSha256Hash(MyJsonContext.Default.Person);
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ComputeSha256Hash), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string ComputeSha256Hash<T>([DisallowNull] JsonTypeInfo<T> typeInfo)
		{
			obj = obj.ArgumentNotNull();
			typeInfo = typeInfo.ArgumentNotNull();

			if (obj is not T typedObject)
			{
				throw new InvalidOperationException($"The object is not of type {typeof(T).FullName}.");
			}

			var utf8Bytes = JsonSerializer.SerializeToUtf8Bytes(typedObject, typeInfo);
			return Convert.ToHexStringLower(SHA256.HashData(utf8Bytes));
		}

		/// <summary>
		/// Generates a SHA-256 hash of the object’s serialized JSON.
		/// </summary>
		/// <returns>The SHA-256 hash string of the object.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(ComputeSha256Hash), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string ComputeSha256Hash()
		{
			obj = obj.ArgumentNotNull();

			var utf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
			return Convert.ToHexStringLower(SHA256.HashData(utf8Bytes));
		}

		/// <summary>
		/// Converts an object to a specified type.
		/// </summary>
		/// <typeparam name="T">The type to convert to.</typeparam>
		/// <returns>The object cast to the specified type.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(As), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T As<T>()
		{
			return (T)obj.ArgumentNotNull();
		}

		/// <summary>
		/// Gets the names of all interfaces implemented by the specified object's type.
		/// </summary>
		/// <returns>A read-only collection of interface names.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<string> GetImplementedInterfaces()
		{
			return TypeHelper.GetImplementedInterfaces(obj);
		}

		/// <summary>
		/// Gets all interfaces implemented by the specified object's type.
		/// </summary>
		/// <returns>A read-only collection of interface types.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(GetImplementedInterfaceTypes), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<Type> GetImplementedInterfaceTypes()
		{
			return TypeHelper.GetImplementedInterfaceTypes(obj);
		}

		/// <summary>
		/// Gets the names of the implemented interfaces of the specified object.
		/// </summary>
		/// <param name="interfaceNames">A collection of interface names to filter by.</param>
		/// <returns>A read-only collection of interface names.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<string> GetImplementedInterfaces(params ReadOnlyCollection<string> interfaceNames)
		{
			return TypeHelper.GetImplementedInterfaces(obj, interfaceNames);
		}
	}

}
