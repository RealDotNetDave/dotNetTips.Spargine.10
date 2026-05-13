// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-13-2026
// ***********************************************************************
// <copyright file="JsonSerializationTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Serialization;

[ExcludeFromCodeCoverage]
[TestClass]
public class JsonSerializationTests
{
	private const int _collectionCount = 100;

	[TestMethod]
	public void Deserialize_ComplexObject_RoundTrip_PreservesAllProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = JsonSerialization.Serialize(person);

		var result = JsonSerialization.Deserialize<Person>(json);

		Assert.IsNotNull(result);
		Assert.AreEqual(person.Id, result.Id);
		Assert.AreEqual(person.FirstName, result.FirstName);
		Assert.AreEqual(person.LastName, result.LastName);
	}

	[TestMethod]
	public void Deserialize_EmptyJson_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Deserialize<Person>(string.Empty));
	}

	[TestMethod]
	public void Deserialize_InvalidJson_ThrowsInvalidOperationException()
	{
		var invalidJson = "{ invalid json }";
		_ = Assert.ThrowsExactly<JsonException>(() => JsonSerialization.Deserialize<Person>(invalidJson));
	}

	[TestMethod]
	public void Deserialize_NullJson_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Deserialize<Person>(null));
	}

	[TestMethod]
	public void Deserialize_NumberAsString_ReturnsCorrectValue()
	{
		// _options has AllowReadingFromString — numeric fields can be quoted strings
		var json = "{\"Age\":\"42\"}";

		var result = JsonSerialization.Deserialize<AgeModel>(json);

		Assert.IsNotNull(result);
		Assert.AreEqual(42, result.Age);
	}

	[TestMethod]
	public void Deserialize_ValidJson_ReturnsCorrectObject()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = JsonSerialization.Serialize(person);

		var result = JsonSerialization.Deserialize<Person>(json);

		Assert.IsNotNull(result);
		Assert.AreEqual(person.Email, result.Email);
	}

	[TestMethod]
	public void Deserialize_ValueType_ReturnsCorrectValue()
	{
		var json = "42";

		var result = JsonSerialization.Deserialize<int>(json);

		Assert.AreEqual(42, result);
	}

	[TestMethod]
	public void Deserialize_WhitespaceJson_ThrowsJsonException()
	{
		_ = Assert.ThrowsExactly<JsonException>(() => JsonSerialization.Deserialize<Person>("   "));
	}

	[TestMethod]
	public void Deserialize_WithNullOptions_UsesDefaultOptions()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = JsonSerialization.Serialize(person);

		// Explicitly specify the overload by casting null to JsonSerializerOptions
		var result = JsonSerialization.Deserialize<Person>(json, (JsonSerializerOptions)null);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void Deserialize_WithNullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = JsonSerialization.Serialize(person);

		// Explicitly specify the overload by casting null to JsonTypeInfo<Person>
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Deserialize<Person>(json, (JsonTypeInfo<Person>)null));
	}

	[TestMethod]
	public void Deserialize_WithOptions_CaseInsensitive_ReturnsCorrectObject()
	{
		var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
		var json = "{\"AGE\":99}";

		var result = JsonSerialization.Deserialize<AgeModel>(json, options);

		Assert.IsNotNull(result);
		Assert.AreEqual(99, result.Age);
	}

	[TestMethod]
	public void Deserialize_WithOptions_EmptyJson_ThrowsArgumentNullException()
	{
		var options = new JsonSerializerOptions();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Deserialize<Person>(string.Empty, options));
	}

	[TestMethod]
	public void Deserialize_WithOptions_InvalidJson_ThrowsJsonException()
	{
		var options = new JsonSerializerOptions();
		_ = Assert.ThrowsExactly<JsonException>(() => JsonSerialization.Deserialize<Person>("{ invalid json }", options));
	}

	[TestMethod]
	public void Deserialize_WithOptions_NullJson_ThrowsArgumentNullException()
	{
		var options = new JsonSerializerOptions();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Deserialize<Person>(null, options));
	}

	[TestMethod]
	public void Deserialize_WithOptions_OverridesDefaultOptions_NumberAsStringFails()
	{
		// Custom options WITHOUT AllowReadingFromString — quoted number should throw
		var options = new JsonSerializerOptions();
		var json = "{\"Age\":\"42\"}";

		_ = Assert.ThrowsExactly<JsonException>(() => JsonSerialization.Deserialize<AgeModel>(json, options));
	}

	[TestMethod]
	public void Deserialize_WithOptions_ReturnsObject()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = JsonSerialization.Serialize(person);
		var options = new JsonSerializerOptions();
		var result = JsonSerialization.Deserialize<Person>(json, options);
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void Deserialize_WithOptions_RoundTrip_PreservesAllProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		var options = new JsonSerializerOptions { WriteIndented = true };
		var json = JsonSerialization.Serialize(person, options);

		var result = JsonSerialization.Deserialize<Person>(json, options);

		Assert.IsNotNull(result);
		Assert.AreEqual(person.Id, result.Id);
		Assert.AreEqual(person.FirstName, result.FirstName);
		Assert.AreEqual(person.LastName, result.LastName);
	}

	[TestMethod]
	public void Deserialize_WithOptions_WhitespaceJson_ThrowsJsonException()
	{
		var options = new JsonSerializerOptions();
		_ = Assert.ThrowsExactly<JsonException>(() => JsonSerialization.Deserialize<Person>("   ", options));
	}

	[TestMethod]
	public void Deserialize_WithTypeInfo_EmptyJson_ThrowsArgumentNullException()
	{
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Deserialize<Person>(string.Empty, typeInfo));
	}

	[TestMethod]
	public void Deserialize_WithTypeInfo_InvalidJson_ThrowsJsonException()
	{
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		_ = Assert.ThrowsExactly<JsonException>(() => JsonSerialization.Deserialize<Person>("{ invalid json }", typeInfo));
	}

	[TestMethod]
	public void Deserialize_WithTypeInfo_NullJson_ThrowsArgumentNullException()
	{
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Deserialize<Person>(null, typeInfo));
	}

	[TestMethod]
	public void Deserialize_WithTypeInfo_ReturnsObject()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = JsonSerialization.Serialize(person);
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		var result = JsonSerialization.Deserialize<Person>(json, typeInfo);
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void Deserialize_WithTypeInfo_RoundTrip_PreservesAllProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		var json = JsonSerialization.Serialize(person, typeInfo);

		var result = JsonSerialization.Deserialize<Person>(json, typeInfo);

		Assert.IsNotNull(result);
		Assert.AreEqual(person.Id, result.Id);
		Assert.AreEqual(person.FirstName, result.FirstName);
		Assert.AreEqual(person.LastName, result.LastName);
	}

	[TestMethod]
	public void Deserialize_WithTypeInfo_WhitespaceJson_ThrowsJsonException()
	{
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		_ = Assert.ThrowsExactly<JsonException>(() => JsonSerialization.Deserialize<Person>("   ", typeInfo));
	}

	[TestMethod]
	public void DeserializeFromFile_FileDoesNotExist_ThrowsFileNotFoundException()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".json"));
		_ = Assert.ThrowsExactly<FileNotFoundException>(() => JsonSerialization.DeserializeFromFile<Person>(file));
	}

	[TestMethod]
	public void DeserializeFromFile_NullFile_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.DeserializeFromFile<Person>(null));
	}

	[TestMethod]
	public void JsonEqual_BooleanValues_ReturnsTrue()
	{
		var actual = "{\"flag\":true}";
		var expected = "{\"flag\":true}";

		Assert.IsTrue(JsonSerialization.JsonEqual(actual, expected));
	}

	[TestMethod]
	public void JsonEqual_DifferentArrayElements_ReturnsFalse()
	{
		var actual = "[1,2,3]";
		var expected = "[1,2,4]";

		Assert.IsFalse(JsonSerialization.JsonEqual(actual, expected));
	}

	[TestMethod]
	public void JsonEqual_DifferentArrayLengths_ReturnsFalse()
	{
		var actual = "[1,2,3]";
		var expected = "[1,2]";

		Assert.IsFalse(JsonSerialization.JsonEqual(actual, expected));
	}

	[TestMethod]
	public void JsonEqual_DifferentBooleanValues_ReturnsFalse()
	{
		var actual = "{\"flag\":true}";
		var expected = "{\"flag\":false}";

		Assert.IsFalse(JsonSerialization.JsonEqual(actual, expected));
	}

	[TestMethod]
	public void JsonEqual_DifferentInputs_ReturnsFalse()
	{
		// Arrange
		var actual = "{\"Name\":\"Test\",\"Value\":1}";
		var expected = "{\"Name\":\"Test\",\"Value\":2}";

		// Act
		var result = JsonSerialization.JsonEqual(actual, expected);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void JsonEqual_DifferentValueKinds_ReturnsFalse()
	{
		var actual = "{\"key\":\"1\"}";
		var expected = "{\"key\":1}";

		Assert.IsFalse(JsonSerialization.JsonEqual(actual, expected));
	}

	[TestMethod]
	public void JsonEqual_EmptyArrays_ReturnsTrue()
	{
		Assert.IsTrue(JsonSerialization.JsonEqual("[]", "[]"));
	}

	[TestMethod]
	public void JsonEqual_EmptyObjects_ReturnsTrue()
	{
		Assert.IsTrue(JsonSerialization.JsonEqual("{}", "{}"));
	}

	[TestMethod]
	public void JsonEqual_EqualArrays_ReturnsTrue()
	{
		var actual = "[1,2,3]";
		var expected = "[1,2,3]";

		Assert.IsTrue(JsonSerialization.JsonEqual(actual, expected));
	}

	[TestMethod]
	public void JsonEqual_EqualInputs_ReturnsTrue()
	{
		// Arrange
		var actual = "{\"Name\":\"Test\",\"Value\":1}";
		var expected = "{\"Name\":\"Test\",\"Value\":1}";

		// Act
		var result = JsonSerialization.JsonEqual(actual, expected);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void JsonEqual_NestedObjects_ReturnsTrue()
	{
		var actual = "{\"outer\":{\"inner\":\"value\"}}";
		var expected = "{\"outer\":{\"inner\":\"value\"}}";

		Assert.IsTrue(JsonSerialization.JsonEqual(actual, expected));
	}

	[TestMethod]
	public void JsonEqual_NullActual_ThrowsArgumentNullException()
	{
		// Arrange
		var expected = "{\"Name\":\"Test\",\"Value\":1}";

		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.JsonEqual(null, expected));
	}

	[TestMethod]
	public void JsonEqual_NullValues_ReturnsTrue()
	{
		var actual = "{\"key\":null}";
		var expected = "{\"key\":null}";

		Assert.IsTrue(JsonSerialization.JsonEqual(actual, expected));
	}

	[TestMethod]
	public void JsonEqual_StringValues_ReturnsCorrectResult()
	{
		var actual = "{\"key\":\"hello\"}";
		var expected = "{\"key\":\"hello\"}";

		Assert.IsTrue(JsonSerialization.JsonEqual(actual, expected));

		var different = "{\"key\":\"world\"}";

		Assert.IsFalse(JsonSerialization.JsonEqual(actual, different));
	}

	[TestMethod]
	public void LoadCollectionFromJson()
	{
		var people = RandomData.GeneratePersonRefCollection(_collectionCount);

		//Serialize
		var json = JsonSerialization.Serialize(people);

		//Deserialize
		var serializedPeople = JsonSerialization.LoadCollectionFromJson<Person>(json, _collectionCount);

		Assert.IsNotNull(serializedPeople);
	}

	[TestMethod]
	public void LoadCollectionFromJson_CountGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
	{
		var people = RandomData.GeneratePersonRefCollection(5);
		var json = JsonSerialization.Serialize(people);

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json, 10));
	}

	[TestMethod]
	public void LoadCollectionFromJson_CountLessThanOne_ThrowsArgumentOutOfRangeException()
	{
		var people = RandomData.GeneratePersonRefCollection(2);
		var json = JsonSerialization.Serialize(people);
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json, 0));
	}

	[TestMethod]
	public void LoadCollectionFromJson_EmptyJson_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json: string.Empty, count: 1));
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_CountGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(5);
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));

		try
		{
			JsonSerialization.SerializeToFile(people, file);

			// Act & Assert
			_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
				() => JsonSerialization.LoadCollectionFromJson<Person>(file, 10));
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_CountLessThanOne_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(2);
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));

		try
		{
			JsonSerialization.SerializeToFile(people, file);

			// Act & Assert
			_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
				() => JsonSerialization.LoadCollectionFromJson<Person>(file, 0));
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_FileDoesNotExist_ThrowsFileNotFoundException()
	{
		// Arrange
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));

		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(
			() => JsonSerialization.LoadCollectionFromJson<Person>(file, 5));
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_NullFile_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => JsonSerialization.LoadCollectionFromJson<Person>((FileInfo)null, 5));
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_ReturnsArray()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(_collectionCount);
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));

		try
		{
			JsonSerialization.SerializeToFile(people, file);

			// Act
			var result = JsonSerialization.LoadCollectionFromJson<Person>(file, _collectionCount);

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(_collectionCount, result.Length);
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_WithTypeInfo_CountGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(5);
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		try
		{
			JsonSerialization.SerializeToFile(people, file);

			// Act & Assert
			_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
				() => JsonSerialization.LoadCollectionFromJson<Person>(file, 10, typeInfo));
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_WithTypeInfo_CountLessThanOne_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(2);
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		try
		{
			JsonSerialization.SerializeToFile(people, file);

			// Act & Assert
			_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(
				() => JsonSerialization.LoadCollectionFromJson<Person>(file, 0, typeInfo));
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_WithTypeInfo_FileDoesNotExist_ThrowsFileNotFoundException()
	{
		// Arrange
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(
			() => JsonSerialization.LoadCollectionFromJson<Person>(file, 5, typeInfo));
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_WithTypeInfo_NullFile_ThrowsArgumentNullException()
	{
		// Arrange
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => JsonSerialization.LoadCollectionFromJson<Person>((FileInfo)null, 5, typeInfo));
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_WithTypeInfo_NullTypeInfo_ThrowsArgumentNullException()
	{
		// Arrange — file must exist so that ArgumentExists() passes and ArgumentNotNull() on typeInfo triggers
		var people = RandomData.GeneratePersonRefCollection(2);
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));

		try
		{
			JsonSerialization.SerializeToFile(people, file);

			// Act & Assert
			_ = Assert.ThrowsExactly<ArgumentNullException>(
				() => JsonSerialization.LoadCollectionFromJson<Person>(file, 2, (JsonTypeInfo<Person>)null));
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void LoadCollectionFromJson_FromFile_WithTypeInfo_ReturnsArray()
	{
		// Arrange
		var people = RandomData.GeneratePersonRefCollection(_collectionCount);
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		try
		{
			JsonSerialization.SerializeToFile(people, file);

			// Act
			var result = JsonSerialization.LoadCollectionFromJson<Person>(file, _collectionCount, typeInfo);

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(_collectionCount, result.Length);
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void LoadCollectionFromJson_NullJson_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json: null, count: 1));
	}

	[TestMethod]
	public void LoadCollectionFromJson_ReturnsCorrectCount()
	{
		var people = RandomData.GeneratePersonRefCollection(10);
		var json = JsonSerialization.Serialize(people);

		var result = JsonSerialization.LoadCollectionFromJson<Person>(json, 5);

		Assert.IsNotNull(result);
		Assert.AreEqual(5, result.Length);
	}

	[TestMethod]
	public void LoadCollectionFromJson_WithTypeInfo_CountGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
	{
		var people = RandomData.GeneratePersonRefCollection(5);
		var json = JsonSerialization.Serialize(people);
		var info = PersonRefJsonSerializerContext.Default.Person;

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json, 10, info));
	}

	[TestMethod]
	public void LoadCollectionFromJson_WithTypeInfo_CountLessThanOne_ThrowsArgumentOutOfRangeException()
	{
		var people = RandomData.GeneratePersonRefCollection(2);
		var json = JsonSerialization.Serialize(people);
		var info = PersonRefJsonSerializerContext.Default.Person;
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json, 0, info));
	}

	[TestMethod]
	public void LoadCollectionFromJson_WithTypeInfo_NullInfo_ThrowsArgumentNullException()
	{
		var people = RandomData.GeneratePersonRefCollection(2);
		var json = JsonSerialization.Serialize(people);
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json, 2, null));
	}

	[TestMethod]
	public void LoadCollectionFromJson_WithTypeInfo_NullJson_ThrowsArgumentNullException()
	{
		var info = PersonRefJsonSerializerContext.Default.Person;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json: null, count: 1, typeInfo: info));
	}

	[TestMethod]
	public void LoadCollectionFromJsonJsonInfoType()
	{
		var people = RandomData.GeneratePersonRefCollection(_collectionCount);

		//Serialize
		var json = JsonSerialization.Serialize(people);

		//Deserialize
		var serializedPeople = JsonSerialization.LoadCollectionFromJson<Person>(json, _collectionCount, PersonRefJsonSerializerContext.Default.Person);

		Assert.IsNotNull(serializedPeople);
	}

	[TestMethod]
	public void Serialize_NullObject_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Serialize(null));
	}

	[TestMethod]
	public void Serialize_WithNullOptions_ReturnsJson()
	{
		var person = RandomData.GeneratePerson<Person>();

		var json = JsonSerialization.Serialize(person, (JsonSerializerOptions)null);

		Assert.IsTrue(string.IsNullOrEmpty(json) is false);
	}

	[TestMethod]
	public void Serialize_WithOptions_NullObject_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Serialize(null, null));
	}

	[TestMethod]
	public void Serialize_WithOptions_ReturnsJson()
	{
		var person = RandomData.GeneratePerson<Person>();
		var options = new JsonSerializerOptions { WriteIndented = true };

		var json = JsonSerialization.Serialize(person, options);

		Assert.IsTrue(string.IsNullOrEmpty(json) is false);
	}

	[TestMethod]
	public void Serialize_WithTypeInfo_NullObject_ThrowsArgumentNullException()
	{
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Serialize<Person>(null, typeInfo));
	}

	[TestMethod]
	public void Serialize_WithTypeInfo_NullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.Serialize(person, null));
	}

	[TestMethod]
	public void Serialize_WithTypeInfo_ReturnsJson()
	{
		var person = RandomData.GeneratePerson<Person>();
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		var json = JsonSerialization.Serialize(person, typeInfo);

		Assert.IsTrue(string.IsNullOrEmpty(json) is false);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeTestPerson.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPerson()
	{
		var person = RandomData.GeneratePerson<Person>();

		//Serialize
		var json = JsonSerialization.Serialize(person);

		Assert.IsTrue(string.IsNullOrEmpty(json) is false);

		//Deserialize
		var serializedPerson = JsonSerialization.Deserialize<Person>(json);

		Assert.IsNotNull(serializedPerson);
	}

	[TestMethod]
	public void SerializeDeserializeTestPersonCollection()
	{
		var people = RandomData.GeneratePersonRefCollection(2);

		//Serialize
		var json = JsonSerialization.Serialize(people);

		people.ToJsonFile(new FileInfo("C:\\dotNetTips.com\\DebugOutput\\PersonCollection.json"));

		Assert.IsTrue(string.IsNullOrEmpty(json) is false);

		//Deserialize
		var serializedPeople = JsonSerialization.Deserialize<List<Person>>(json);

		Assert.IsNotNull(serializedPeople);
	}

	/// <summary>
	/// Defines the test method SerializeDeserializeTestPersonRecord.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPersonRecord()
	{
		var fileName = RandomData.GenerateRandomFileName();

		//For debugging
		var person = RandomData.GeneratePerson<PersonRecord>();
		JsonSerialization.SerializeToFile(person, new FileInfo(fileName));

		Assert.IsTrue(string.IsNullOrEmpty(File.ReadAllText(fileName)) is false);

		//Deserialize
		var serializedPerson = JsonSerialization.DeserializeFromFile<PersonRecord>(new FileInfo(fileName));

		Assert.IsNotNull(serializedPerson);
	}

	[TestMethod]
	public void SerializeDeserializeToFileTestPerson()
	{
		var person = RandomData.GeneratePerson<Person>();
		var fileName = RandomData.GenerateRandomFileName();

		try
		{
			//Serialize
			JsonSerialization.SerializeToFile(person, new FileInfo(fileName));

			//Deserialize
			_ = JsonSerialization.DeserializeFromFile<Person>(new FileInfo(fileName));
		}
		catch (Exception ex)
		{
			Assert.Fail(ex.Message);
		}

		_ = Assert.ThrowsExactly<FileNotFoundException>(
			() => JsonSerialization.DeserializeFromFile<Person>(new FileInfo($"{fileName}.bogus")));
	}

	[TestMethod]
	public void SerializeToFile_CreatesDirectoryIfNotExists()
	{
		var person = RandomData.GeneratePerson<Person>();
		var dir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		var file = new FileInfo(Path.Combine(dir, "person.json"));
		try
		{
			JsonSerialization.SerializeToFile(person, file);
			Assert.IsTrue(File.Exists(file.FullName));
		}
		finally
		{
			if (Directory.Exists(dir))
			{
				Directory.Delete(dir, true);
			}
		}
	}

	[TestMethod]
	public void SerializeToFile_NullFile_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.SerializeToFile(person, null));
	}

	[TestMethod]
	public void SerializeToFile_NullObject_ThrowsArgumentNullException()
	{
		var file = new FileInfo(Path.GetTempFileName());
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => JsonSerialization.SerializeToFile(null, file));
	}

	[TestMethod]
	public void SerializeToFile_WithOptions_WritesFile()
	{
		var person = RandomData.GeneratePerson<Person>();
		var options = new JsonSerializerOptions { WriteIndented = true };
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));

		try
		{
			JsonSerialization.SerializeToFile(person, file, options);

			Assert.IsTrue(File.Exists(file.FullName));
			Assert.IsTrue(new FileInfo(file.FullName).Length > 0);
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void SerializeToFile_WithTypeInfo_CreatesDirectoryIfNotExists()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		var dir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		var file = new FileInfo(Path.Combine(dir, "person.json"));
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		try
		{
			// Act
			JsonSerialization.SerializeToFile(person, file, typeInfo);

			// Assert
			Assert.IsTrue(File.Exists(file.FullName));
		}
		finally
		{
			if (Directory.Exists(dir))
			{
				Directory.Delete(dir, recursive: true);
			}
		}
	}

	[TestMethod]
	public void SerializeToFile_WithTypeInfo_NullFile_ThrowsArgumentNullException()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => JsonSerialization.SerializeToFile(person, null, typeInfo));
	}

	[TestMethod]
	public void SerializeToFile_WithTypeInfo_NullObject_ThrowsArgumentNullException()
	{
		// Arrange
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => JsonSerialization.SerializeToFile<Person>(null, file, typeInfo));
	}

	[TestMethod]
	public void SerializeToFile_WithTypeInfo_NullTypeInfo_ThrowsArgumentNullException()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => JsonSerialization.SerializeToFile<Person>(person, file, null));
	}

	[TestMethod]
	public void SerializeToFile_WithTypeInfo_RoundTrip_PreservesData()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		try
		{
			// Act
			JsonSerialization.SerializeToFile(person, file, typeInfo);
			var result = JsonSerialization.Deserialize<Person>(File.ReadAllText(file.FullName), typeInfo);

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(person.Id, result.Id);
			Assert.AreEqual(person.FirstName, result.FirstName);
			Assert.AreEqual(person.LastName, result.LastName);
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	[TestMethod]
	public void SerializeToFile_WithTypeInfo_WritesFile()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;

		try
		{
			// Act
			JsonSerialization.SerializeToFile(person, file, typeInfo);

			// Assert
			Assert.IsTrue(File.Exists(file.FullName));
			Assert.IsTrue(new FileInfo(file.FullName).Length > 0);
		}
		finally
		{
			if (file.Exists)
			{
				file.Delete();
			}
		}
	}

	private sealed class AgeModel
	{
		public int Age { get; set; }
	}
}
