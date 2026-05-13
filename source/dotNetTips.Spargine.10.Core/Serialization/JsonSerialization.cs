// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-12-2026
// ***********************************************************************
// <copyright file="JsonSerialization.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Serialization;

/// <summary>
/// Provides methods for serializing objects to JSON strings and deserializing JSON strings to objects.
/// Utilizes the System.Text.Json namespace for efficient processing. This class supports custom serialization
/// options and aims to simplify the use of JSON serialization in .NET applications.
/// </summary>
[Information(Documentation = "https://bit.ly/SpargineJsonSerialization", Status = Status.UpdateDocumentation)]
public static class JsonSerialization
{
	/// <summary>
	/// Specifies options for JSON serialization and deserialization.
	/// </summary>
	private static readonly JsonSerializerOptions _options = new()
	{
		NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
	};

	/// <summary>
	/// Converts a specified JSON string into its corresponding object representation using the provided <see cref="JsonSerializerOptions"/>.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for deserialization. If null, the default options are used.</param>
	/// <returns>An instance of <typeparamref name="TResult"/> deserialized from the JSON string.</returns>
	/// <exception cref="InvalidOperationException">Failed to deserialize the JSON string to {typeof(TResult)}.</exception>
	[Pure]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(Deserialize), OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TResult Deserialize<TResult>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] string json, JsonSerializerOptions? options = null)
	{
		json = json.ArgumentNotNullOrEmpty();

		options ??= _options;

		return JsonSerializer.Deserialize<TResult>(json, options) ??
				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
	}

	/// <summary>
	/// Converts a specified JSON string into its corresponding object representation using the provided <see cref="JsonTypeInfo"/>.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize to.</typeparam>
	/// <param name="json">The JSON string to deserialize.</param>
	/// <param name="typeInfo">The <see cref="JsonTypeInfo"/> to use for deserialization. If null, an <see cref="ArgumentNullException"/> is thrown.</param>
	/// <returns>An instance of <typeparamref name="TResult"/> deserialized from the JSON string.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="typeInfo"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Failed to deserialize the JSON string to {typeof(TResult)}.</exception>
	[Pure]
	[Information(nameof(Deserialize), OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TResult Deserialize<TResult>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] string json, [DisallowNull] JsonTypeInfo<TResult> typeInfo)
	{
		json = json.ArgumentNotNullOrEmpty();
		typeInfo = typeInfo.ArgumentNotNull();

		return JsonSerializer.Deserialize(json, typeInfo) ??
				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
	}

	/// <summary>
	/// Reads JSON content from a specified file and deserializes it into an object.
	/// </summary>
	/// <typeparam name="TResult">The type of the object to deserialize the JSON content into.</typeparam>
	/// <param name="file">The file containing the JSON content to deserialize.</param>
	/// <returns>An instance of <typeparamref name="TResult"/> deserialized from the JSON content in the file.</returns>
	/// <exception cref="FileNotFoundException">Thrown if the specified file does not exist.</exception>
	[Pure]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(DeserializeFromFile), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TResult DeserializeFromFile<TResult>([DisallowNull] FileInfo file) where TResult : class
	{
		file = file.ArgumentNotNull();

		return file.Exists is false
			? throw ExceptionThrower.CreateFileNotFoundException(Resources.FileNotFoundCannotDeserializeFromJSON, file.FullName)
			: Deserialize<TResult>(File.ReadAllText(file.FullName));
	}

	/// <summary>
	/// Compares two JSON strings for structural and value equality.
	/// </summary>
	/// <param name="actual">The actual JSON string to compare.</param>
	/// <param name="expected">The expected JSON string to compare against.</param>
	/// <returns><c>true</c> if both JSON strings are structurally and value-equal; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool JsonEqual([DisallowNull] string actual, [DisallowNull] string expected)
	{
		actual = actual.ArgumentNotNullOrEmpty();
		expected = expected.ArgumentNotNullOrEmpty();

		using (var expectedDom = JsonDocument.Parse(expected))
		{
			using (var actualDom = JsonDocument.Parse(actual))
			{
				return JsonEqual(expectedDom.RootElement, actualDom.RootElement);
			}
		}
	}

	/// <summary>
	/// Reads JSON content from a specified file and deserializes it into an object.
	/// </summary>
	/// <typeparam name="T">The type of objects to deserialize.</typeparam>
	/// <param name="json">The JSON string containing the collection.</param>
	/// <param name="count">The number of objects to deserialize from the JSON string.</param>
	/// <returns>An array of deserialized objects of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the count is less than 1.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the items in the json collection is less than count.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or cannot be deserialized to the specified type.</exception>
	[Pure]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(LoadCollectionFromJson), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T[] LoadCollectionFromJson<T>([DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] string json, int count)
	{
		json = json.ArgumentNotNullOrEmpty();
		count = count.ArgumentInRange(min: 1);

		var items = new T[count];

		using (var doc = JsonDocument.Parse(json))
		{
			var root = doc.RootElement;

			if (root.GetArrayLength() < count)
			{
				throw new ArgumentOutOfRangeException(nameof(count), $"The JSON array contains fewer than {count} elements.");
			}

			for (var itemCount = 0; itemCount < count; itemCount++)
			{
				var deserializedItem = root[itemCount].Deserialize<T>(_options) ?? throw new JsonException($"Failed to deserialize item at index {itemCount}.");

				items[itemCount] = deserializedItem;
			}
		}

		return items;
	}



	/// <summary>
	/// Reads JSON content from a specified file and deserializes it into an array of objects.
	/// </summary>
	/// <typeparam name="T">The type of objects to deserialize.</typeparam>
	/// <param name="file">The file containing the JSON array.</param>
	/// <param name="count">The number of objects to deserialize from the JSON array.</param>
	/// <returns>An array of deserialized objects of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the count is less than 1.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the items in the json collection is less than count.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or cannot be deserialized to the specified type.</exception>
	[Pure]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(LoadCollectionFromJson), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T[] LoadCollectionFromJson<T>([DisallowNull] FileInfo file, int count)
	{
		file = file.ArgumentExists();
		count = count.ArgumentInRange(min: 1);

		// Stream the file directly to avoid loading entire JSON string into memory
		using var stream = file.OpenRead();
		using var doc = JsonDocument.Parse(stream);

		var root = doc.RootElement;

		if (root.GetArrayLength() < count)
		{
			throw new ArgumentOutOfRangeException(nameof(count), $"The JSON array contains fewer than {count} elements.");
		}

		var items = new T[count];

		for (var itemCount = 0; itemCount < count; itemCount++)
		{
			var deserializedItem = root[itemCount].Deserialize<T>(_options) ?? throw new JsonException($"Failed to deserialize item at index {itemCount}.");

			items[itemCount] = deserializedItem;
		}

		return items;
	}

	/// <summary>
	/// Reads JSON content from a specified file and deserializes it into an object.
	/// </summary>
	/// <typeparam name="T">The type of objects to deserialize.</typeparam>
	/// <param name="json">The JSON string containing the collection.</param>
	/// <param name="count">The number of objects to deserialize from the JSON string.</param>
	/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> used for reflection-free deserialization. Cannot be <c>null</c>.</param>
	/// <returns>An array of deserialized objects of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if the count is less than 1.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or cannot be deserialized to the specified type.</exception>
	[Pure]
	[Information(nameof(LoadCollectionFromJson), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T[] LoadCollectionFromJson<T>(
		[DisallowNull][StringSyntax(StringSyntaxAttribute.Json)] string json,
		int count,
		[DisallowNull] JsonTypeInfo<T> typeInfo)
	{
		json = json.ArgumentNotNullOrEmpty();
		count = count.ArgumentInRange(min: 1);
		typeInfo = typeInfo.ArgumentNotNull();

		using var doc = JsonDocument.Parse(json);
		var root = doc.RootElement;

		if (root.GetArrayLength() < count)
		{
			throw new ArgumentOutOfRangeException(nameof(count), $"The JSON array contains fewer than {count} elements.");
		}

		var items = new T[count];

		for (var itemCount = 0; itemCount < count; itemCount++)
		{
			items[itemCount] = root[itemCount].Deserialize(typeInfo)
				?? throw new JsonException($"Failed to deserialize item at index {itemCount}.");
		}

		return items;
	}

	/// <summary>
	/// Reads JSON content from a specified file and deserializes it into an array of objects using a source-generated <see cref="JsonTypeInfo{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of objects to deserialize.</typeparam>
	/// <param name="file">The file containing the JSON array. The file must exist.</param>
	/// <param name="count">The number of objects to deserialize from the JSON array.</param>
	/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> used for reflection-free deserialization. Cannot be <c>null</c>.</param>
	/// <returns>An array of deserialized objects of type <typeparamref name="T"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="file"/> or <paramref name="typeInfo"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="count"/> is less than 1, or if the JSON array contains fewer elements than <paramref name="count"/>.</exception>
	/// <exception cref="JsonException">Thrown if the JSON is invalid or cannot be deserialized to the specified type.</exception>
	/// <remarks>
	/// This overload streams the file directly to avoid loading the entire JSON content into memory.
	/// Prefer this overload over the string-based overload when processing large JSON files.
	/// </remarks>
	[Pure]
	[Information(nameof(LoadCollectionFromJson), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static T[] LoadCollectionFromJson<T>([DisallowNull] FileInfo file, int count, [DisallowNull] JsonTypeInfo<T> typeInfo)
	{
		file = file.ArgumentExists();
		count = count.ArgumentInRange(min: 1);
		typeInfo = typeInfo.ArgumentNotNull();

		using var stream = file.OpenRead();
		using var doc = JsonDocument.Parse(stream);

		var root = doc.RootElement;

		if (root.GetArrayLength() < count)
		{
			throw new ArgumentOutOfRangeException(nameof(count), $"The JSON array contains fewer than {count} elements.");
		}

		var items = new T[count];

		for (var itemCount = 0; itemCount < count; itemCount++)
		{
			items[itemCount] = root[itemCount].Deserialize(typeInfo)
				?? throw new JsonException($"Failed to deserialize item at index {itemCount}.");

		}

		return items;
	}

	/// <summary>
	/// Serializes an object into its JSON string representation.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <returns>A JSON string representation of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input object is null.</exception>
	/// <remarks>This method uses the configured JsonSerializerOptions for serialization.
	/// It ensures that the serialized string is in a format that can be easily deserialized back into an object.</remarks>
	[Pure]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(Serialize), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string Serialize([DisallowNull] object obj)
	{
		obj = obj.ArgumentNotNull();

		return JsonSerializer.Serialize(obj, _options);
	}

	/// <summary>
	/// Serializes an object into its JSON string representation using the provided <see cref="JsonSerializerOptions"/>.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="options">The <see cref="JsonSerializerOptions"/> to use for serialization. If null, the default options are used.</param>
	/// <returns>A JSON string representation of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input object is null.</exception>
	[Pure]
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(Serialize), OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string Serialize([DisallowNull] object obj, JsonSerializerOptions? options = null)
	{
		obj = obj.ArgumentNotNull();

		return JsonSerializer.Serialize(obj, options ?? _options);
	}

	/// <summary>
	/// Serializes an object into its JSON string representation using the provided <see cref="JsonTypeInfo"/>.
	/// </summary>
	/// <typeparam name="T">The type of the object to serialize.</typeparam>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> to use for serialization. If null, an <see cref="ArgumentNullException"/> is thrown.</param>
	/// <returns>A JSON string representation of the object.</returns>
	/// <exception cref="ArgumentNullException">Thrown if the input object or <paramref name="typeInfo"/> is null.</exception>
	[Pure]
	[Information(nameof(Serialize), OptimizationStatus = OptimizationStatus.None, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string Serialize<T>([DisallowNull] T obj, [DisallowNull] JsonTypeInfo<T> typeInfo)
	{
		obj = obj.ArgumentNotNull();
		typeInfo = typeInfo.ArgumentNotNull();

		return JsonSerializer.Serialize(obj, typeInfo);
	}

	/// <summary>
	/// Serializes an object into its JSON string representation and saves it to a specified file using a source-generated <see cref="JsonTypeInfo{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the object to serialize.</typeparam>
	/// <param name="obj">The object to serialize. Cannot be <c>null</c>.</param>
	/// <param name="file">The <see cref="FileInfo"/> representing the file where the JSON content will be written. Cannot be <c>null</c>.</param>
	/// <param name="typeInfo">The <see cref="JsonTypeInfo{T}"/> used for reflection-free serialization. Cannot be <c>null</c>.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj"/>, <paramref name="file"/>, or <paramref name="typeInfo"/> is <c>null</c>.</exception>
	/// <remarks>
	/// This overload is the preferred approach for AOT and trimming-safe scenarios because it uses a
	/// source-generated <see cref="JsonTypeInfo{T}"/> instead of runtime reflection.
	/// All directories and subdirectories in the specified path are created if they do not already exist.
	/// </remarks>
	[Information(nameof(SerializeToFile), OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SerializeToFile<T>([DisallowNull] T obj, [DisallowNull] FileInfo file, [DisallowNull] JsonTypeInfo<T> typeInfo)
	{
		obj = obj.ArgumentNotNull();
		file = file.ArgumentNotNull();
		typeInfo = typeInfo.ArgumentNotNull();

		file.Directory?.Create();

		File.WriteAllText(file.FullName, Serialize(obj, typeInfo));
	}

	/// <summary>
	/// Serializes an object and saves it to a specified JSON file.
	/// </summary>
	/// <param name="obj">The object to serialize.</param>
	/// <param name="file">The <see cref="FileInfo"/> representing the file where the JSON content will be written.</param>
	/// <param name="options">Optional <see cref="JsonSerializerOptions"/> to use for serialization. If <c>null</c>, default options are used.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="obj"/> or <paramref name="file"/> is <c>null</c>.</exception>
	/// <remarks>
	/// This method ensures that all directories and subdirectories in the specified path are created unless they already exist before writing the JSON content.
	/// Utilizes the configured <see cref="JsonSerializerOptions"/> for serialization.
	/// </remarks>
	[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
	[Information(nameof(SerializeToFile), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void SerializeToFile([DisallowNull] object obj, [DisallowNull] FileInfo file, JsonSerializerOptions? options = null)
	{
		obj = obj.ArgumentNotNull();
		file = file.ArgumentNotNull();

		file.Directory?.Create();

		File.WriteAllText(file.FullName, Serialize(obj, options));
	}

	/// <summary>
	/// Compares two <see cref="JsonElement"/> instances for equality, considering their structure and data.
	/// </summary>
	/// <param name="expected">The expected <see cref="JsonElement"/> structure.</param>
	/// <param name="actual">The actual <see cref="JsonElement"/> structure to compare against the expected.</param>
	/// <returns><c>true</c> if both <see cref="JsonElement"/> instances are equal; otherwise, <c>false</c>.</returns>
	/// <exception cref="NotSupportedException">Thrown when encountering an undefined or unexpected JsonValueKind.</exception>
	/// <remarks>
	/// This method performs a deep comparison of the contents of two <see cref="JsonElement"/> instances,
	/// including objects, arrays, and primitive values. It is designed to handle complex JSON structures
	/// and can be used for testing and validation purposes.
	/// </remarks>
	private static bool JsonEqual(in JsonElement expected, in JsonElement actual)
	{
		var valueKind = expected.ValueKind;

		if (valueKind != actual.ValueKind)
		{
			return false;
		}

		switch (valueKind)
		{
			case JsonValueKind.Object:
				var propertyNames = new HashSet<string>();

				using (var expectedEnumerator = expected.EnumerateObject())
				{
					foreach (var property in expectedEnumerator)
					{
						_ = propertyNames.Add(property.Name);
					}
				}

				using (var actualEnumerator = actual.EnumerateObject())
				{
					foreach (var property in actualEnumerator)
					{
						_ = propertyNames.Add(property.Name);
					}
				}

				foreach (var name in propertyNames)
				{
					if (!JsonEqual(expected.GetProperty(name), actual.GetProperty(name)))
					{
						return false;
					}
				}

				return true;
			case JsonValueKind.Array:
				using (var expectedEnumerator = expected.EnumerateArray())
				{
					using (var actualEnumerator = actual.EnumerateArray())
					{
						while (expectedEnumerator.MoveNext())
						{
							if (!actualEnumerator.MoveNext())
							{
								return false;
							}

							if (!JsonEqual(expectedEnumerator.Current, actualEnumerator.Current))
							{
								return false;
							}
						}

						return !actualEnumerator.MoveNext();
					}
				}

			case JsonValueKind.String:
				return string.Equals(expected.GetString(), actual.GetString(), StringComparison.Ordinal);
			case JsonValueKind.Number:
			case JsonValueKind.True:
			case JsonValueKind.False:
			case JsonValueKind.Null:
				return string.Equals(expected.GetRawText(), actual.GetRawText(), StringComparison.Ordinal);
			case JsonValueKind.Undefined:
				throw new NotSupportedException($"Undefined JsonValueKind: {valueKind}.");
			default:
				throw new NotSupportedException($"Unexpected JsonValueKind: {valueKind}.");
		}
	}
}
