// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-10-2026
// ***********************************************************************
// <copyright file="ObjectExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for the Object type.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using MessagePack;
using Microsoft.Extensions.ObjectPool;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineObjectExtensions")]
public static class ObjectExtensions
{
#pragma warning disable IDE0051
	private const string Item = "Item";
#pragma warning restore IDE0051
#pragma warning disable IDE0052 // Remove unread private members - false positive: used in extension block (PropertiesToDictionary, FieldsToDictionary)
#pragma warning disable IL2026 // BuiltInTypeNames uses reflection — suppressed for static field initializer
	private static readonly IReadOnlyDictionary<Type, string> _builtInTypeNames = TypeHelper.BuiltInTypeNames();
#pragma warning restore IL2026
#pragma warning restore IDE0052
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
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(DisposeFields), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void DisposeFields([AllowNull] this IDisposable obj)
	{
		if (obj is null)
		{
			return;
		}

		// DON'T USE ASSPAN() HERE
#pragma warning disable IL2070 // obj.GetType() returns Type without DynamicallyAccessedMembers, but method already marked RequiresUnreferencedCode
		foreach (var field in obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
#pragma warning restore IL2070
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
	[Information(nameof(ToLazy), author: "David McCarter", createdOn: "9/8/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Lazy<T> ToLazy<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>([DisallowNull] this T value)
	{
		value = value.ArgumentNotNull();

		return new Lazy<T>(() => value);
	}

	/// <summary>
	/// Ensures a non-null string representation of an object. If the object is null, it returns an empty string.
	/// This is handy when working with string formatting or constructing output that must avoid null values.
	/// </summary>
	/// <param name="obj">The <see cref="IDisposable" /> object to dispose.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(TryDispose), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
	public static void TryDispose(this IDisposable obj)
	{
		TryDispose(obj.ArgumentNotNull(), false);
	}

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
				var task = asyncDisposable.DisposeAsync();
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
		/// Serializes the object to a JSON file.
		/// </summary>
		/// <param name="file">The file to write the JSON to.</param>
		/// <exception cref="JsonException">Thrown if an error occurs during serialization.</exception>
		/// <exception cref="IOException">Thrown if an error occurs while writing the file.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(ToJsonFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public void ToJsonFile([DisallowNull] FileInfo file)
		{
			file = file.ArgumentNotNull();
			obj = obj.ArgumentNotNull();

			using var stream = File.Create(file.FullName);
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
		[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
		public string PropertiesToString([AllowNull] string header = ControlChars.EmptyString, [ConstantExpected] char keyValueSeparator = ControlChars.Colon, [DisallowNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = false)
		{
			obj = obj.ArgumentNotNull();
			sequenceSeparator = sequenceSeparator.ArgumentNotNull();

			var typeName = obj.GetType().Name;

			// Adjust type name for lists and member name inclusion
			if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
			{
				typeName = Item;
			}
			else if (includeMemberName is false)
			{
				typeName = string.Empty;
			}

			var properties = obj.PropertiesToDictionary(memberName: typeName, ignoreNulls: ignoreNulls);

			// Remove empty values
			if (ignoreNulls)
			{
				properties = new ReadOnlyDictionary<string, string>(
					properties.Where(p => !string.IsNullOrEmpty(p.Value))
						.ToDictionary(pair => pair.Key, pair => pair.Value)
				);
			}

			// Build the result string
			var result = properties.Aggregate(header, (acc, pair) => FastStringBuilder.Format("{0}{1}{2}{3}{4}", acc!, sequenceSeparator, pair.Key, keyValueSeparator.ToString(), pair.Value));

			return result!.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result[sequenceSeparator.Length..] : result;
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
		[Information(nameof(PropertiesToString), author: "David McCarter", createdOn: "12/18/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available, OptimizationStatus = OptimizationStatus.None)]
		public string PropertiesToString([DisallowNull] Func<PropertyInfo, bool> propertySelector, [AllowNull] string header = ControlChars.EmptyString, [ConstantExpected] char keyValueSeparator = ControlChars.Colon, [DisallowNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = false)
		{
			obj = obj.ArgumentNotNull();
			propertySelector = propertySelector.ArgumentNotNull();
			sequenceSeparator = sequenceSeparator.ArgumentNotNull();

			var typeName = obj.GetType().Name;

			// Adjust type name for lists and member name inclusion
			if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
			{
				typeName = Item;
			}
			else if (includeMemberName is false)
			{
				typeName = string.Empty;
			}

			// Get all properties
#pragma warning disable IL2070 // obj.GetType() returns Type without DynamicallyAccessedMembers, but method already marked RequiresUnreferencedCode
			var allProperties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
#pragma warning restore IL2070

			// Filter properties using the selector
			var selectedProperties = allProperties.Where(propertySelector);

			// Build dictionary from selected properties only
			var properties = new Dictionary<string, string>();

			foreach (var property in selectedProperties)
			{
				try
				{
					var value = property.GetValue(obj);
					var propertyName = string.IsNullOrEmpty(typeName) ? property.Name : $"{typeName}.{property.Name}";

					if (value is null)
					{
						if (!ignoreNulls)
						{
							properties[propertyName] = string.Empty;
						}
					}
					else
					{
						properties[propertyName] = value.ToString() ?? string.Empty;
					}
				}
				catch (Exception ex)
				{
					// Handle properties that throw exceptions during value retrieval
					if (!ignoreNulls)
					{
						var propertyName = string.IsNullOrEmpty(typeName) ? property.Name : $"{typeName}.{property.Name}";
						properties[propertyName] = $"[Error: {ex.GetType().Name}]";
					}
				}
			}

			// Remove empty values if ignoreNulls is true
			if (ignoreNulls)
			{
				properties = new Dictionary<string, string>(properties.Where(p => !string.IsNullOrEmpty(p.Value))
.ToDictionary(pair => pair.Key, pair => pair.Value)
);
			}

			var result = properties.Aggregate(header, (acc, pair) => FastStringBuilder.Format("{0}{1}{2}{3}{4}", acc!, sequenceSeparator, pair.Key, keyValueSeparator.ToString(), pair.Value));

			return result!.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result[sequenceSeparator.Length..] : result;
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
		[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public ReadOnlyDictionary<string, string> PropertiesToDictionary([DisallowNull] string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
		{
			memberName = memberName.ArgumentNotNull();

			// Return just member name if obj is null and ignoreNulls is false
			if (memberName.HasValue() && obj is null && ignoreNulls is false)
			{
				return new ReadOnlyDictionary<string, string>(new Dictionary<string, string> { { memberName, string.Empty } });
			}

			var objectType = obj.ArgumentNotNull().GetType();

			var result = new Dictionary<string, string>();

			// If the type is a built-in type.
			if (_builtInTypeNames.ContainsKey(objectType))
			{
				result = new Dictionary<string, string> { { memberName, obj!.ToString()! } };
				return result.AsReadOnly();
			}

			// If the type implements the IEnumerable interface.
			if (objectType.IsEnumerable())
			{
				var itemCount = 0;

				// Loop through the collection using the enumerator strategy and collect all items in the result bag
				// Note: if the collection is empty it will not return anything about its existence,
				// because the method is supposed to catch value items not the list itself
				foreach (var item in (IEnumerable)obj!)
				{
					try
					{
						var itemId = itemCount++;

						var itemInnerMember = FastStringBuilder.Format($"{{0}}[{{1}}]", memberName, itemId.ToString(CultureInfo.CurrentCulture));

						result = result.Concat(item.PropertiesToDictionary(itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
					}
					catch (Exception ex)
					{
						Trace.WriteLine(ex.Message);
					}
				}

				return result.AsReadOnly();
			}

			// Otherwise go deeper in the object tree.
			// And foreach object public property collect each value
			var propertyCollection = objectType.GetProperties().AsSpan();

			var newMemberName = string.Empty;

			if (memberName.Length > 0)
			{
				newMemberName = $"{memberName}{ControlChars.Dot}";
			}

			var propertyCount = propertyCollection.Length;

			// Loop through all properties
			for (var propertyIndex = 0; propertyIndex < propertyCount; propertyIndex++)
			{
				var property = propertyCollection[propertyIndex];
				var ignoreAttribute = property.GetAttribute<JsonIgnoreAttribute>();

				if (ignoreAttribute == null)
				{
					try
					{
						var innerObject = property.GetValue(obj, null);

						if (ignoreNulls && innerObject is null)
						{
							continue;
						}

						var innerMember = FastStringBuilder.Format("{0}{1}", newMemberName, property.Name);

						result = result.Concat(innerObject!.PropertiesToDictionary(innerMember, ignoreNulls)).ToDictionary(e => e.Key, e => e.Value);
					}
					catch (Exception ex)
					{
						Trace.WriteLine(ex.Message);
					}
				}
			}

			return result.AsReadOnly();
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
		[Information(nameof(FieldsToDictionary), author: "David McCarter", createdOn: "08/22/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, OptimizationStatus = OptimizationStatus.Completed)]
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

			// Handle IEnumerable types
			if (objectType.IsEnumerable())
			{
				var itemCount = 0;

				foreach (var item in (IEnumerable)obj)
				{
					var itemId = itemCount++;
					var itemInnerMember = $"{memberName}[{itemId.ToString(CultureInfo.CurrentCulture)}]";

					foreach (var kvp in item.FieldsToDictionary(itemInnerMember, ignoreEmptyValues))
					{
						if (ignoreEmptyValues && string.IsNullOrEmpty(kvp.Value))
						{
							continue;
						}

						result[kvp.Key] = kvp.Value;
					}
				}

				return result.AsReadOnly();
			}

			// Otherwise, process fields
			var fieldCollection = objectType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			var newMemberName = memberName.Length > 0 ? $"{memberName}{ControlChars.Dot}" : string.Empty;

			// DON'T USE SPAN HERE
			foreach (var field in fieldCollection)
			{
				// Skip compiler-generated fields (e.g., backing fields for auto-properties)
				if (field.IsDefined(typeof(CompilerGeneratedAttribute), false))
				{
					continue;
				}

				var innerObject = field.GetValue(obj);

				if (ignoreEmptyValues && innerObject is null)
				{
					continue;
				}

				// Handle built-in types directly
				if (innerObject is not null)
				{
					var innerMember = $"{newMemberName}{field.Name}";

					foreach (var kvp in innerObject.FieldsToDictionary(innerMember, ignoreEmptyValues))
					{
						if (ignoreEmptyValues && string.IsNullOrEmpty(kvp.Value))
						{
							continue;
						}

						result[kvp.Key] = kvp.Value;
					}
				}
			}

			return result.AsReadOnly();
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
		[Information(nameof(FieldsToString), author: "David McCarter", createdOn: "08/22/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available, OptimizationStatus = OptimizationStatus.None)]
		public string FieldsToString([AllowNull] string header = ControlChars.EmptyString, [ConstantExpected] char keyValueSeparator = ControlChars.Colon, [DisallowNull] string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
		{
			obj = obj.ArgumentNotNull();
			sequenceSeparator = sequenceSeparator.ArgumentNotNull();

			var typeName = obj.GetType().Name;

			if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
			{
				typeName = Item;
			}
			else if (includeMemberName is false)
			{
				typeName = string.Empty;
			}

			var fields = obj.FieldsToDictionary(memberName: typeName, ignoreEmptyValues: ignoreNulls);

			// Remove empty values
			if (ignoreNulls)
			{
				fields = new ReadOnlyDictionary<string, string>(
					fields.Where(f => !string.IsNullOrEmpty(f.Value))
						.ToDictionary(static pair => pair.Key, static pair => pair.Value)
				);
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
		[Information(nameof(InitializeFields), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
		public void InitializeFields()
		{
			obj = obj.ArgumentNotNull();

#pragma warning disable IL2070 // obj.GetType() returns Type without DynamicallyAccessedMembers, but method already marked RequiresUnreferencedCode
			var fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
#pragma warning restore IL2070

			// DON'T USE ASSPAN() HERE
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
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(HasProperty), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public bool HasProperty([DisallowNull] string propertyName)
		{
			propertyName = propertyName.ArgumentNotNullOrEmpty();

#pragma warning disable IL2070 // obj.GetType() returns Type without DynamicallyAccessedMembers — method marked RequiresUnreferencedCode
			return obj?.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic) != null;
#pragma warning restore IL2070
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
		/// Creates a deep clone using binary MessagePack serialization (fastest, requires MessagePack attributes).
		/// Use this when cloning performance is critical and types are annotated with MessagePack attributes.
		/// </summary>
		/// <typeparam name="T">The type of the object.</typeparam>
		/// <returns>A deep clone of the object.</returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(FastBinaryClone), OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
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
		[Information(nameof(FastBinaryClone), OptimizationStatus = OptimizationStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public T FastBinaryClone<T>([AllowNull] MessagePackSerializerOptions options = null)
		{
			obj = obj.ArgumentNotNull();

			return MessagePackSerializer.Deserialize<T>(
				MessagePackSerializer.Serialize(obj, options), options);
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

			// ToUniqueCollection a SHA256
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
		[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
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
		[Information(nameof(GetImplementedInterfaceTypes), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
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
		[Information(nameof(GetImplementedInterfaces), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
		public ReadOnlyCollection<string> GetImplementedInterfaces(params ReadOnlyCollection<string> interfaceNames)
		{
			return TypeHelper.GetImplementedInterfaces(obj, interfaceNames);
		}
	}

}
