// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-26-2025
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for the Object type.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides a collection of extension methods for objects, enhancing functionality with additional utility methods for common tasks.
/// </summary>
/// <remarks>
/// This class includes methods for deep cloning objects, computing SHA256 hashes, disposing object fields, converting objects to and from JSON,
/// checking for properties, initializing fields, checking for nullability, converting properties to dictionaries or strings, and more.
/// These methods are designed to extend the capabilities of all objects and simplify common operations related to serialization,
/// reflection, and memory management.
/// </remarks>
[Information(Documentation = "https://bit.ly/SpargineObjectExtensions", Status = Status.UpdateDocumentation)]
public static class ObjectExtensions
{
	/// <summary>
	/// The string builder pool for efficient string building operations.
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// Processes the <see cref="IEnumerable" /> to dispose items if they implement <see cref="IDisposable" />.
	/// </summary>
	/// <typeparam name="T">The type of the items in the collection, constrained to <see cref="IDisposable" />.</typeparam>
	/// <param name="items">The collection of items to dispose.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="items"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ProcessCollectionToDispose), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void ProcessCollectionToDispose<T>([AllowNull] IEnumerable<T> items) where T : IDisposable
	{
		if (items!.IsNotEmpty())
		{
			foreach (var item in items!)
			{
				item?.Dispose();
			}
		}
	}

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

	// Fix for CS0246: The type or namespace name 'T' could not be found
	// The issue is that 'T' is not defined in the context of the `DisposeFields` method.
	// To fix this, we need to remove the generic type 'T' and use a non-generic approach.

	/// <summary>
	/// Automatically disposes of all IDisposable fields within an object using reflection, simplifying memory management in classes that deal with unmanaged resources.
	/// This method is a must-use in any IDisposable implementation, ensuring resources are freed efficiently.
	/// </summary>
	/// <param name="obj">The object containing IDisposable fields to be disposed.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DisposeFields), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void DisposeFields([AllowNull] this IDisposable obj)
	{
		if (obj is null)
		{
			return;
		}

		foreach (var field in obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
		{
			if (field.FieldType.IsAssignableTo(typeof(IDisposable)) && field.GetValue(obj) is IDisposable disposableField)
			{
				disposableField.TryDispose();
			}
			else if (field.GetValue(obj) is IEnumerable<IDisposable> collection)
			{
				collection.DisposeCollection();
			}
			else if (field is IEnumerable<KeyValuePair<object, IDisposable>> keyValueCollection)
			{
				keyValueCollection.DisposeCollection<object, IDisposable>();
			}
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
	[Information(nameof(FromJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static TResult FromJson<TResult>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] this string json, JsonSerializerOptions? options = null)
	{
		json = json.ArgumentNotNullOrEmpty();

		return JsonSerialization.Deserialize<TResult>(json, options);
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
	[Information(nameof(FromJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
	public static TResult FromJson<TResult>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] this string json, JsonTypeInfo<TResult> typeInfo)
	{
		json = json.ArgumentNotNullOrEmpty();
		typeInfo = typeInfo.ArgumentNotNull();

		return JsonSerialization.Deserialize(json.ArgumentNotNullOrEmpty(), typeInfo);
	}

	/// <summary>
	/// Wraps the specified value in a <see cref="Lazy{T}"/> instance.
	/// </summary>
	/// <typeparam name="T">The type of the value to wrap.</typeparam>
	/// <param name="value">The value to wrap in a <see cref="Lazy{T}"/>.</param>
	/// <returns>
	/// A <see cref="Lazy{T}"/> instance that returns the specified value when evaluated.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToLazy), author: "David McCarter", createdOn: "9/8/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static Lazy<T> ToLazy<T>(this T value)
	{
		value = value.ArgumentNotNull();

		return new Lazy<T>(() => value, LazyThreadSafetyMode.PublicationOnly);
	}

	/// <summary>
	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// </summary>
	/// <param name="obj">The <see cref="IDisposable" /> object to dispose.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static void TryDispose(this IDisposable obj) => TryDispose(obj.ArgumentNotNull(), false);

	/// <summary>
	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// Optionally throws an exception if the disposal fails.
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
			if (obj is IAsyncDisposable asyncDisposable)
			{
				var result = asyncDisposable.DisposeAsync();
			}
			else
			{
				obj.Dispose();
			}
		}
		catch
		{
			if (throwException)
			{
				throw;
			}
		}
	}

	/// <summary>
	/// Provides extension methods for a specific object instance.
	/// </summary>
	/// <param name="obj">The object instance to extend.</param>
	extension([DisallowNull] object obj)
	{
		/// <summary>
		/// Returns the maximum of two comparable objects.
		/// </summary>
		/// <typeparam name="T">The type of the objects to compare. Must implement <see cref="IComparable"/>.</typeparam>
		/// <param name="obj2">The second object to compare. This parameter can be null.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Max), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public T? Max<T>([DisallowNull] T obj2) where T : IComparable
		{
			return obj is T comparableObj
				? TypeHelper.Max(comparableObj, obj2)
				: throw new InvalidOperationException($"The object is not of type {typeof(T).Name} which implements IComparable.");
		}

		/// <summary>
		/// Serializes the object to a JSON file.
		/// </summary>
		/// <param name="file">The file to write the JSON to.</param>
		/// <exception cref="JsonException">Thrown if an error occurs during serialization.</exception>
		/// <exception cref="IOException">Thrown if an error occurs while writing the file.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToJsonFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
		public void ToJsonFile([DisallowNull] FileInfo file)
		{
			file = file.ArgumentNotNull();

			var json = obj.ArgumentNotNull().ToJson();

			File.WriteAllText(file.FullName, json, Encoding.UTF8);
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
		[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public string PropertiesToString([AllowNull] string header = ControlChars.EmptyString, [ConstantExpected] char keyValueSeparator = ControlChars.Colon, [DisallowNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = false)
		{
			obj = obj.ArgumentNotNull();
			sequenceSeparator = sequenceSeparator.ArgumentNotNull();

			var typeName = obj.GetType().Name;

			if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
			{
				typeName = "Item";
			}
			else if (includeMemberName is false)
			{
				typeName = string.Empty;
			}

			var properties = obj.PropertiesToDictionary(memberName: typeName, ignoreNulls: ignoreNulls);

			// Remove empty values
			if (ignoreNulls)
			{
				properties = properties.Where(p => !string.IsNullOrEmpty(p.Value))
					.ToDictionary(pair => pair.Key, pair => pair.Value);
			}

			var result = properties.Aggregate(header, (acc, pair) => FastStringBuilder.Format("{0}{1}{2}{3}{4}", acc!, sequenceSeparator, pair.Key, keyValueSeparator.ToString(), pair.Value));

			return result!.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result[sequenceSeparator.Length..] : result;
		}

		/// <summary>
		/// Converts an object’s properties into a dictionary, with property names as keys and their values as dictionary values.
		/// </summary>
		/// <param name="memberName">The name of a specific member to convert. If empty, all properties are converted.</param>
		/// <param name="ignoreNulls">Specifies whether to ignore properties with null values.</param>
		/// <returns>A dictionary containing the names and string representations of the properties of the object.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public IReadOnlyDictionary<string, string> PropertiesToDictionary([DisallowNull] string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
		{
			memberName = memberName.ArgumentNotNull();
			var objectType = obj.ArgumentNotNull().GetType();

			var result = new Dictionary<string, string>();

			// Reserve a special treatment for specific types by design (like string -that's a list of chars and you don't want to iterate on its items)
			if (TypeHelper.BuiltInTypeNames().ContainsKey(objectType))
			{
				result.Add(memberName, obj.ToString()!);
				return result;
			}

			// If the type implements the IEnumerable interface.
			if (objectType.IsEnumerable())
			{
				var itemCount = 0;

				// Loop through the collection using the enumerator strategy and collect all items in the result bag
				// Note: if the collection is empty it will not return anything about its existence,
				// because the method is supposed to catch value items not the list itself
				foreach (var item in (IEnumerable)obj)
				{
					var itemId = itemCount++;

					var itemInnerMember = FastStringBuilder.Format($"{{0}}[{{1}}]", memberName, itemId.ToString(CultureInfo.CurrentCulture));

					result = result.Concat(item.PropertiesToDictionary(itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
				}

				return result;
			}

			// Otherwise go deeper in the object tree.
			// And foreach object public property collect each value
			var propertyCollection = objectType.GetProperties().AsReadOnlySpan();

			var newMemberName = string.Empty;

			if (memberName.Length > 0)
			{
				newMemberName = $"{memberName}{ControlChars.Dot}";
			}

			var propertyCount = propertyCollection.Length;

			for (var propertyIndex = 0; propertyIndex < propertyCount; propertyIndex++)
			{
				var property = propertyCollection[propertyIndex];
				var ignoreAttribute = property.GetAttribute<JsonIgnoreAttribute>();

				if (ignoreAttribute == null)
				{
					var innerObject = property.GetValue(obj, null);

					if (ignoreNulls && innerObject is null)
					{
						continue;
					}

					var innerMember = FastStringBuilder.Format("{0}{1}", newMemberName, property.Name);

					result = result.Concat(innerObject!.PropertiesToDictionary(innerMember)).ToDictionary(e => e.Key, e => e.Value);
				}
			}

			return result;
		}

		/// <summary>
		/// Converts an object's fields into a dictionary, with field names as keys and their values as dictionary values.
		/// This method uses reflection to extract field information, including both public and private instance fields.
		/// </summary>
		/// <param name="memberName">
		/// The name of a specific member to convert. If empty, all fields are converted.
		/// This parameter is used as a prefix for hierarchical field names in nested objects.
		/// </param>
		/// <param name="ignoreNulls">
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
		/// // With ignoreNulls = false
		/// var allFields = person.FieldsToDictionary(ignoreNulls: false);
		/// // Result includes null-valued fields
		/// </code>
		/// </example>
		/// <seealso cref="PropertiesToDictionary"/>
		/// <seealso cref="FieldsToString"/>
		/// <seealso cref="Type.GetFields(BindingFlags)"/>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FieldsToDictionary), author: "David McCarter", createdOn: "08/22/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New, OptimizationStatus = OptimizationStatus.Completed)]
		public IReadOnlyDictionary<string, string> FieldsToDictionary([DisallowNull] string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
		{
			memberName = memberName.ArgumentNotNull();
			var objectType = obj.ArgumentNotNull().GetType();

			var result = new Dictionary<string, string>();

			// Special treatment for built-in types
			if (TypeHelper.BuiltInTypeNames().ContainsKey(objectType))
			{
				result.Add(memberName, obj.ToString()!);
				return result;
			}

			// Handle IEnumerable types
			if (objectType.IsEnumerable())
			{
				var itemCount = 0;

				foreach (var item in (IEnumerable)obj)
				{
					var itemId = itemCount++;
					var itemInnerMember = $"{memberName}[{itemId.ToString(CultureInfo.CurrentCulture)}]";

					foreach (var kvp in item.FieldsToDictionary(itemInnerMember, ignoreNulls))
					{
						if (ignoreNulls && string.IsNullOrEmpty(kvp.Value))
						{
							continue;
						}

						result[kvp.Key] = kvp.Value;
					}
				}
				return result;
			}

			// Otherwise, process fields
			var fieldCollection = objectType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			var newMemberName = memberName.Length > 0 ? $"{memberName}{ControlChars.Dot}" : string.Empty;

			foreach (var field in fieldCollection)
			{
				// Skip compiler-generated fields (e.g., backing fields for auto-properties)
				if (field.IsDefined(typeof(CompilerGeneratedAttribute), false))
				{
					continue;
				}

				var innerObject = field.GetValue(obj);

				if (ignoreNulls && innerObject is null)
				{
					continue;
				}

				if (innerObject is not null)
				{
					var innerMember = $"{newMemberName}{field.Name}";

					foreach (var kvp in innerObject.FieldsToDictionary(innerMember, ignoreNulls))
					{
						if (ignoreNulls && string.IsNullOrEmpty(kvp.Value))
						{
							continue;
						}

						result[kvp.Key] = kvp.Value;
					}
				}
			}

			return result;
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
		[Information(nameof(FieldsToString), author: "David McCarter", createdOn: "08/22/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.New, OptimizationStatus = OptimizationStatus.None)]
		public string FieldsToString([AllowNull] string header = ControlChars.EmptyString, [ConstantExpected] char keyValueSeparator = ControlChars.Colon, [DisallowNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
		{
			obj = obj.ArgumentNotNull();
			sequenceSeparator = sequenceSeparator.ArgumentNotNull();

			var typeName = obj.GetType().Name;

			if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
			{
				typeName = "Item";
			}
			else if (includeMemberName is false)
			{
				typeName = string.Empty;
			}

			var fields = obj.FieldsToDictionary(memberName: typeName, ignoreNulls: ignoreNulls);

			// Remove empty values
			if (ignoreNulls)
			{
				fields = fields.Where(f => !string.IsNullOrEmpty(f.Value))
					.ToDictionary(static pair => pair.Key, static pair => pair.Value);
			}

			var result = fields.Aggregate(header, (acc, pair) => FastStringBuilder.Format("{0}{1}{2}{3}{4}", acc!, sequenceSeparator, pair.Key, keyValueSeparator.ToString(), pair.Value));

			return result!.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result[sequenceSeparator.Length..] : result;
		}

		/// <summary>
		/// Determines whether the specified object is null.
		/// </summary>
		/// <returns><c>true</c> if the object is null; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNull() => obj is null;

		/// <summary>
		/// Determines whether the specified object is not null.
		/// </summary>
		/// <returns><c>true</c> if the object is not null; otherwise, <c>false</c>.</returns>
		[Pure]
		[Information(nameof(IsNotNull), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool IsNotNull() => obj is not null;

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
		[Information(nameof(InitializeFields), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public void InitializeFields()
		{
			obj = obj.ArgumentNotNull();

			var fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

			foreach (var field in fields)
			{
				if (field.GetValue(obj) == null && !field.FieldType.IsValueType)
				{
					var defaultValue = Activator.CreateInstance(field.FieldType, true);
					field.SetValue(obj, defaultValue);
				}
			}
		}

		/// <summary>
		/// Determines whether an object contains a specific property.
		/// </summary>
		/// <param name="propertyName">The name of the property to check for.</param>
		/// <returns><c>true</c> if the property exists; otherwise, <c>false</c>.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasProperty), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool HasProperty([DisallowNull] string propertyName)
		{
			propertyName = propertyName.ArgumentNotNullOrEmpty();

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
		[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public string ToJson<T>([DisallowNull] JsonTypeInfo<T> typeInfo)
		{
			obj = obj.ArgumentNotNull();
			typeInfo = typeInfo.ArgumentNotNull();

			return JsonSerializer.Serialize(obj, typeInfo);
		}

		/// <summary>
		/// Serializes an object into its JSON string representation using the provided <see cref="JsonSerializerOptions"/>.
		/// </summary>
		/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization.</param>
		/// <returns>The JSON string representation of the object.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
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
		[Information(nameof(FastHashCode), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		[Information(nameof(FastClone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public T FastClone<T>([DisallowNull] JsonTypeInfo<T> typeInfo)
		{
			obj = obj.ArgumentNotNull();
			typeInfo = typeInfo.ArgumentNotNull();

			return JsonSerializer.Deserialize(JsonSerializer.Serialize(obj, typeInfo), typeInfo)!;

		}

		/// <summary>
		/// Creates a deep clone of an object by serializing it into JSON and deserializing it back using the provided <see cref="JsonSerializerOptions"/>.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization and deserialization.</param>
		/// <returns>A deep clone of the object.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastClone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.New)]
		public T FastClone<T>(JsonSerializerOptions? options = null)
		{
			obj = obj.ArgumentNotNull();

			return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(obj, options), options)!;
		}

		/// <summary>
		/// Creates a deep clone of an object by serializing it into JSON and deserializing it back.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>A deep clone of the object.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastClone), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Updated)]
		public T FastClone<T>()
		{
			obj = obj.ArgumentNotNull();

			return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(obj))!;

		}

		/// <summary>
		/// Creates a deep clone using binary MessagePack serialization (fastest, requires MessagePack attributes).
		/// Use this when cloning performance is critical and types are annotated with MessagePack attributes.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>A deep clone of the object.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastCloneBinary), Status = Status.New, OptimizationStatus = OptimizationStatus.Completed)]
		public T FastCloneBinary<T>()
		{
			obj = obj.ArgumentNotNull();

			// Requires: Install-Package MessagePack
			// Types must be annotated with [MessagePackObject] and [Key] attributes
			return MessagePack.MessagePackSerializer.Deserialize<T>(
				MessagePack.MessagePackSerializer.Serialize(obj))!;
		}

		/// <summary>
		/// Generates a SHA-256 hash of the object’s serialized JSON.
		/// </summary>
		/// <returns>The SHA-256 hash string of the object.</returns>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ComputeSha256Hash), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public string ComputeSha256Hash()
		{
			obj = obj.ArgumentNotNull();

			// Create a SHA256
			// ComputeHash - returns byte array
			var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(obj.ToJson())).AsSpan();

			// Convert byte array to a string
			var sb = _stringBuilderPool.Value.Get();

			try
			{
				foreach (var @byte in bytes)
				{
					_ = sb.AppendFormat(CultureInfo.InvariantCulture, "{0:x2}", @byte);
				}

				return sb.ToString();
			}
			finally
			{
				_stringBuilderPool.Value.Return(sb.Clear());
			}
		}

		/// <summary>
		/// Converts an object to a specified type.
		/// </summary>
		/// <typeparam name="T">The type to convert to.</typeparam>
		/// <returns>The object cast to the specified type.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(As), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public T As<T>() => (T)obj.ArgumentNotNull();

		/// <summary>
		/// Gets the names of all interfaces implemented by the specified object's type.
		/// </summary>
		/// <returns>A read-only collection of interface names.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
		public ReadOnlyCollection<string> GetImplementedInterfaces()
		{
			return TypeHelper.GetImplementedInterfaces(obj);
		}

		/// <summary>
		/// Gets all interfaces implemented by the specified object's type.
		/// </summary>
		/// <returns>A read-only collection of interface types.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(GetImplementedInterfaceTypes), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
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
		[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public ReadOnlyCollection<string> GetImplementedInterfaces(params ReadOnlyCollection<string> interfaceNames)
		{
			return TypeHelper.GetImplementedInterfaces(obj, interfaceNames);
		}
	}

}
