// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-15-2025
// ***********************************************************************
// <copyright file="JsonSerializationTests.cs" company="McCarter Consulting">
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
using DotNetTips.Spargine.Tester.Models.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Serialization;

[ExcludeFromCodeCoverage]
[TestClass]
public class JsonSerializationTests
{
	private const int _collectionCount = 100;

	[TestMethod]
	public void Deserialize_InvalidJson_ThrowsInvalidOperationException()
	{
		var invalidJson = "{ invalid json }";
		Assert.ThrowsException<JsonException>(() => JsonSerialization.Deserialize<Person>(invalidJson));
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
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.Deserialize<Person>(json, (JsonTypeInfo<Person>)null));
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
	public void Deserialize_WithTypeInfo_ReturnsObject()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = JsonSerialization.Serialize(person);
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		var result = JsonSerialization.Deserialize<Person>(json, typeInfo);
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void DeserializeFromFile_FileDoesNotExist_ThrowsFileNotFoundException()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".json"));
		Assert.ThrowsException<FileNotFoundException>(() => JsonSerialization.DeserializeFromFile<Person>(file));
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
	public void JsonEqual_NullActual_ThrowsArgumentNullException()
	{
		// Arrange
		var expected = "{\"Name\":\"Test\",\"Value\":1}";

		// Act and Assert
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.JsonEqual(null, expected));
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
	public void LoadCollectionFromJson_CountLessThanOne_ThrowsArgumentOutOfRangeException()
	{
		var people = RandomData.GeneratePersonRefCollection(2);
		var json = JsonSerialization.Serialize(people);
		Assert.ThrowsException<ArgumentOutOfRangeException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json, 0));
	}

	[TestMethod]
	public void LoadCollectionFromJson_WithTypeInfo_CountLessThanOne_ThrowsArgumentOutOfRangeException()
	{
		var people = RandomData.GeneratePersonRefCollection(2);
		var json = JsonSerialization.Serialize(people);
		var info = PersonRefJsonSerializerContext.Default.Person;
		Assert.ThrowsException<ArgumentOutOfRangeException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json, 0, info));
	}

	[TestMethod]
	public void LoadCollectionFromJson_WithTypeInfo_NullInfo_ThrowsArgumentNullException()
	{
		var people = RandomData.GeneratePersonRefCollection(2);
		var json = JsonSerialization.Serialize(people);
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.LoadCollectionFromJson<Person>(json, 2, null));
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
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.Serialize(null));
	}

	[TestMethod]
	public void Serialize_WithOptions_NullObject_ThrowsArgumentNullException()
	{
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.Serialize(null, null));
	}

	[TestMethod]
	public void Serialize_WithTypeInfo_NullObject_ThrowsArgumentNullException()
	{
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.Serialize<Person>(null, typeInfo));
	}

	[TestMethod]
	public void Serialize_WithTypeInfo_NullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.Serialize(person, null));
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

		_ = Assert.ThrowsException<FileNotFoundException>(
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
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.SerializeToFile(person, null));
	}

	[TestMethod]
	public void SerializeToFile_NullObject_ThrowsArgumentNullException()
	{
		var file = new FileInfo(Path.GetTempFileName());
		Assert.ThrowsException<ArgumentNullException>(() => JsonSerialization.SerializeToFile(null, file));
	}
}
