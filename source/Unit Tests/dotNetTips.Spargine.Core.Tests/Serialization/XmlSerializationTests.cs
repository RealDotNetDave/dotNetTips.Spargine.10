// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="XmlSerializationTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Unit tests for XmlSerialization covering all code paths.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Xml;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Serialization;

[ExcludeFromCodeCoverage]
[TestClass]
public class XmlSerializationTests
{
	private const int Count = 100;

	/// <summary>
	/// Tests that Serialize and Deserialize work correctly with a collection of Person objects.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestCollection()
	{
		var people = RandomData.GeneratePersonRefCollection(Count).ToList();

		//Serialize
		var xml = XmlSerialization.Serialize(people);

		var fileName = Path.Combine(App.ExecutingFolder(), "PersonCollectionRef.xml");

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<List<Person>>(xml);

		Assert.IsNotNull(serializedPerson);

		File.Delete(fileName);
	}

	/// <summary>
	/// Tests that Serialize and Deserialize work correctly with a PersonRecord.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPersonRecord()
	{
		var person = RandomData.GeneratePerson<PersonRecord>();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var fileName = Path.Combine(App.ExecutingFolder(), "PersonRecord.xml");

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<PersonRecord>(xml);

		Assert.IsNotNull(serializedPerson);

		//File.Delete(fileName);
	}

	/// <summary>
	/// Tests that Serialize and Deserialize work correctly with a reference type Person.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPersonRef()
	{
		var person = RandomData.GeneratePerson<Person>();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var fileName = Path.Combine(App.ExecutingFolder(), "PersonRef.xml");

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<Person>(xml);

		Assert.IsNotNull(serializedPerson);

		File.Delete(fileName);
	}

	/// <summary>
	/// Tests that Serialize and Deserialize work correctly with a value type Person.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeTestPersonVal()
	{
		var person = RandomData.GeneratePerson<Tester.Models.ValueTypes.Person>();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var fileName = Path.Combine(App.ExecutingFolder(), "PersonVal.xml");

		//For debugging
		File.WriteAllText(fileName, xml);

		Assert.IsTrue(string.IsNullOrEmpty(xml) is false);

		//Deserialize
		var serializedPerson = XmlSerialization.Deserialize<Tester.Models.ValueTypes.Person>(
			xml);

		Assert.IsNotNull(serializedPerson);

		File.Delete(fileName);
	}

	/// <summary>
	/// Tests that SerializeToFile and DeserializeFromFile work correctly round-tripping a Person.
	/// </summary>
	[TestMethod]
	public void SerializeDeserializeToFileTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var fileName = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xml");

		try
		{
			//Serialize
			XmlSerialization.SerializeToFile(person, new FileInfo(fileName));

			//Deserialize
			var result = XmlSerialization.DeserializeFromFile<Person>(new FileInfo(fileName));

			Assert.IsNotNull(result);
		}
		finally
		{
			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}
		}
	}

	/// <summary>
	/// Tests that DeserializeFromFile throws FileNotFoundException when file does not exist.
	/// </summary>
	[TestMethod]
	public void DeserializeFromFile_FileNotFound_ThrowsFileNotFoundException()
	{
		_ = Assert.ThrowsExactly<FileNotFoundException>(
			() => XmlSerialization.DeserializeFromFile<Person>(new FileInfo("NonExistentFile.xml")));
	}

	/// <summary>
	/// Tests that Deserialize throws ArgumentNullException when xml is null.
	/// </summary>
	[TestMethod]
	public void Deserialize_NullXml_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => XmlSerialization.Deserialize<Person>(null!));
	}

	/// <summary>
	/// Tests that Deserialize throws ArgumentNullException when xml is empty.
	/// </summary>
	[TestMethod]
	public void Deserialize_EmptyXml_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => XmlSerialization.Deserialize<Person>(string.Empty));
	}

	/// <summary>
	/// Tests that DeserializeFromFile throws ArgumentNullException when file is null.
	/// </summary>
	[TestMethod]
	public void DeserializeFromFile_NullFile_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => XmlSerialization.DeserializeFromFile<Person>(null!));
	}

	/// <summary>
	/// Tests that Serialize throws ArgumentNullException when object is null.
	/// </summary>
	[TestMethod]
	public void Serialize_NullObj_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => XmlSerialization.Serialize(null!));
	}

	/// <summary>
	/// Tests that SerializeToFile throws ArgumentNullException when object is null.
	/// </summary>
	[TestMethod]
	public void SerializeToFile_NullObj_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => XmlSerialization.SerializeToFile(null!, new FileInfo("test.xml")));
	}

	/// <summary>
	/// Tests that SerializeToFile throws ArgumentNullException when file is null.
	/// </summary>
	[TestMethod]
	public void SerializeToFile_NullFile_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => XmlSerialization.SerializeToFile(person, null!));
	}

	/// <summary>
	/// Tests that SerializeToFile overwrites an existing file.
	/// </summary>
	[TestMethod]
	public void SerializeToFile_ExistingFile_OverwritesFile()
	{
		var person = RandomData.GeneratePerson<Person>();
		var fileName = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xml");

		try
		{
			// Create the file first
			File.WriteAllText(fileName, "existing content");
			Assert.IsTrue(File.Exists(fileName));

			// Serialize should overwrite the file
			XmlSerialization.SerializeToFile(person, new FileInfo(fileName));

			Assert.IsTrue(File.Exists(fileName));

			var content = File.ReadAllText(fileName);
			Assert.IsTrue(content.Contains("<?xml"));
		}
		finally
		{
			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}
		}
	}

	/// <summary>
	/// Tests that SerializeToFile creates the directory if it does not exist.
	/// </summary>
	[TestMethod]
	public void SerializeToFile_DirectoryDoesNotExist_CreatesDirectory()
	{
		var person = RandomData.GeneratePerson<Person>();
		var dirPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		var fileName = Path.Combine(dirPath, "Person.xml");

		try
		{
			Assert.IsFalse(Directory.Exists(dirPath));

			XmlSerialization.SerializeToFile(person, new FileInfo(fileName));

			Assert.IsTrue(Directory.Exists(dirPath));
			Assert.IsTrue(File.Exists(fileName));

			// Verify the file can be deserialized
			var result = XmlSerialization.DeserializeFromFile<Person>(new FileInfo(fileName));
			Assert.IsNotNull(result);
		}
		finally
		{
			if (Directory.Exists(dirPath))
			{
				Directory.Delete(dirPath, recursive: true);
			}
		}
	}

	/// <summary>
	/// Tests that StringToXDocument works correctly with valid XML.
	/// </summary>
	[TestMethod]
	public void StringToXDocumentTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		//Serialize
		var xml = XmlSerialization.Serialize(person);

		var result = XmlSerialization.StringToXDocument(xml);

		Assert.IsNotNull(result);
	}

	/// <summary>
	/// Tests that StringToXDocument throws ArgumentNullException when input is null.
	/// </summary>
	[TestMethod]
	public void StringToXDocument_NullInput_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => XmlSerialization.StringToXDocument(null!));
	}

	/// <summary>
	/// Tests that StringToXDocument throws ArgumentNullException when input is empty.
	/// </summary>
	[TestMethod]
	public void StringToXDocument_EmptyInput_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(
			() => XmlSerialization.StringToXDocument(string.Empty));
	}

	/// <summary>
	/// Tests that StringToXDocument overload with null resolver returns a valid XDocument.
	/// </summary>
	[TestMethod]
	public void StringToXDocument_WithNullResolver_ReturnsXDocument()
	{
		var person = RandomData.GeneratePerson<Person>();
		var xml = XmlSerialization.Serialize(person);

		var result = XmlSerialization.StringToXDocument(xml, null);

		Assert.IsNotNull(result);
	}

	/// <summary>
	/// Tests that StringToXDocument overload with a custom XmlResolver returns a valid XDocument.
	/// </summary>
	[TestMethod]
	public void StringToXDocument_WithResolver_ReturnsXDocument()
	{
		var person = RandomData.GeneratePerson<Person>();
		var xml = XmlSerialization.Serialize(person);

		var result = XmlSerialization.StringToXDocument(xml, new XmlUrlResolver());

		Assert.IsNotNull(result);
	}
}
