// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-26-2025
// ***********************************************************************
// <copyright file="ObjectExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ObjectExtensionsTests : UnitTester
{
	[TestMethod]
	public void As_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		Assert.ThrowsException<ArgumentNullException>(() => obj.As<object>());
	}

	[TestMethod]
	public void AsTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		try
		{
			var castedPerson = person.As<Person>();

			Assert.IsNotNull(castedPerson);
			Assert.AreEqual(person, castedPerson);
		}
		catch (InvalidCastException ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void CloneTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		try
		{
			// Specify the type argument explicitly to resolve CS0411  
			var clonedPerson = person.FastClone<Person>();

			Assert.IsNotNull(clonedPerson);
			Assert.IsTrue(person.Equals(clonedPerson));
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}
	[TestMethod]
	public void ComputeSha256Hash_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		Assert.ThrowsException<ArgumentNullException>(() => obj.ComputeSha256Hash());
	}

	[TestMethod]
	public void ComputeSha256HashTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = person.ComputeSha256Hash();

		//PrintResult(result, nameof(this.ComputeSha256HashTest));

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void DisposeCollectionTest()
	{
		var disposableItems = new List<DisposableFields>
	{
		new DisposableFields(),
		new DisposableFields(),
		new DisposableFields()
	};

		try
		{
			disposableItems.DisposeCollection();
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void DisposeFieldsTest()
	{
		var disposableObj = new DisposableFields();
		DisposableFields nullTest = null;

		try
		{
			disposableObj.DisposeFields();
			nullTest.DisposeFields();
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void FastClone_Null_ThrowsArgumentNullException()
	{
		Person person = null;
		Assert.ThrowsException<ArgumentNullException>(() => person.FastClone<Person>());
		Assert.ThrowsException<ArgumentNullException>(() => person.FastClone<Person>((JsonSerializerOptions)null));
		Assert.ThrowsException<ArgumentNullException>(() => person.FastClone((JsonTypeInfo<Person>)null));
	}

	[TestMethod]
	public void FastClone_NullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		Assert.ThrowsException<ArgumentNullException>(() => person.FastClone((JsonTypeInfo<Person>)null));
	}

	[TestMethod]
	public void FastClone_WithOptions_ReturnsClone()
	{
		var person = RandomData.GeneratePerson<Person>();
		var options = new JsonSerializerOptions();
		var clone = person.FastClone<Person>(options);
		Assert.IsNotNull(clone);
		Assert.AreNotSame(person, clone);
	}

	[TestMethod]
	public void FastClone_WithTypeInfo_ReturnsClone()
	{
		var person = RandomData.GeneratePerson<Person>();
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		var clone = person.FastClone(typeInfo);
		Assert.IsNotNull(clone);
		Assert.AreNotSame(person, clone);
	}

	[TestMethod]
	public void FastGetHashCodeArrayTest()
	{
		int[] numbers = { 1, 2, 3, 4, 5 };

		var hashCode = numbers.GetHashCode();
		var fastHashCode = numbers.FastGetHashCode();

		Assert.AreEqual(hashCode, fastHashCode);
	}

	[TestMethod]
	public void FastGetHashCodePersonTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var hashCode = person.GetHashCode();
		var fastHashCode = person.FastGetHashCode();

		Assert.AreNotEqual(hashCode, fastHashCode);
	}

	[TestMethod]
	public void FromJson_Null_ThrowsArgumentNullException()
	{
		string json = null;
		Assert.ThrowsException<ArgumentNullException>(() => json.FromJson<Person>());
		Assert.ThrowsException<ArgumentNullException>(() => json.FromJson<Person>((JsonSerializerOptions)null));
		Assert.ThrowsException<ArgumentNullException>(() => json.FromJson((JsonTypeInfo<Person>)null));
	}

	[TestMethod]
	public void FromJson_NullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = person.ToJson();
		Assert.ThrowsException<ArgumentNullException>(() => json.FromJson((JsonTypeInfo<Person>)null));
	}

	[TestMethod]
	public void FromJson_WithOptions_ReturnsObject()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = person.ToJson();
		var options = new JsonSerializerOptions();
		var result = json.FromJson<Person>(options);
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FromJson_WithTypeInfo_ReturnsObject()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = person.ToJson();
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		var result = json.FromJson(typeInfo);
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FromJsonTest()
	{
		var person = RandomData.GeneratePerson<Person>().ToJson();

		Assert.IsNotNull(person.FromJson<Person>());
	}

	[TestMethod]
	public void HasPropertyTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		Assert.IsTrue(person.HasProperty("Id"));

		Assert.IsFalse(person.HasProperty("XXXXXXXXXXXXX"));
	}

	[TestMethod]
	public void InitializeFieldsTest()
	{
		var testObject = new DisposableFields();

		testObject.InitializeFields();
	}

	[TestMethod]
	public void NullObjectTest()
	{
		var person = RandomData.GeneratePerson<Person>();
		Person nullPerson = null;

		Assert.IsFalse(person.IsNull());
		Assert.IsTrue(nullPerson.IsNull());

		Assert.IsTrue(person.IsNotNull());
		Assert.IsFalse(nullPerson.IsNotNull());
	}

	[TestMethod]
	public void PropertiesToDictionary_BuiltInType_ReturnsSingleEntry()
	{
		int value = 42;
		var dict = value.PropertiesToDictionary("TestInt");
		Assert.AreEqual(1, dict.Count);
		Assert.IsTrue(dict.ContainsKey("TestInt"));
	}

	[TestMethod]
	public void PropertiesToDictionary_EnumerableType_ReturnsEntries()
	{
		var list = new List<int> { 1, 2, 3 };
		var dict = list.PropertiesToDictionary("Numbers");
		Assert.AreEqual(3, dict.Count);
		Assert.IsTrue(dict.Keys.Any(k => k.StartsWith("Numbers[0]")));
	}

	[TestMethod]
	public void PropertiesToDictionary_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		Assert.ThrowsException<ArgumentNullException>(() => obj.PropertiesToDictionary());
	}

	[TestMethod]
	public void PropertiesToDictionaryTest()
	{
		var personProper = RandomData.GeneratePerson<PersonRecord>();

		var propertiesTest = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			Person = RandomData.GeneratePerson<Person>(),
			PersonRecord = RandomData.GeneratePerson<PersonRecord>(),
			Today = Clock.LocalTime
		};

		var result = personProper.PropertiesToDictionary(memberName: $"Person-{personProper.Id}", ignoreNulls: true);

		Assert.IsTrue(result.FastCount() > 1);

		result = propertiesTest.PropertiesToDictionary(memberName: $"TestPerson-{personProper.Id}", ignoreNulls: true);

		Assert.IsTrue(result.FastCount() > 1);
	}

	[TestMethod]
	public void PropertiesToString_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		Assert.ThrowsException<ArgumentNullException>(() => obj.PropertiesToString());
	}

	[TestMethod]
	public void StripNullTest()
	{
		var person = RandomData.GeneratePerson<Person>();
		Person nullPerson = null;

		Assert.IsFalse(string.IsNullOrEmpty(person.StripNull()));
		Assert.IsTrue(string.IsNullOrEmpty(nullPerson.StripNull()));
	}

	[TestMethod]
	public void ToJson_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		Assert.ThrowsException<ArgumentNullException>(() => obj.ToJson());
		Assert.ThrowsException<ArgumentNullException>(() => obj.ToJson(null));
	}

	[TestMethod]
	public void ToJson_WithTypeInfo_NullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		Assert.ThrowsException<ArgumentNullException>(() => person.ToJson((JsonTypeInfo<Person>)null));
	}

	[TestMethod]
	public void ToJson_WithTypeInfo_ReturnsJson()
	{
		var person = RandomData.GeneratePerson<Person>();
		var typeInfo = PersonRefJsonSerializerContext.Default.Person;
		var json = person.ToJson(typeInfo);
		Assert.IsFalse(string.IsNullOrEmpty(json));
	}

	[TestMethod]
	public void ToJsonFile_NullFile_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		FileInfo file = null;
		Assert.ThrowsException<ArgumentNullException>(() => person.ToJsonFile(file));
	}

	[TestMethod]
	public void ToJsonFile_NullObject_ThrowsArgumentNullException()
	{
		object obj = null;
		var file = new FileInfo(Path.GetTempFileName());
		Assert.ThrowsException<ArgumentNullException>(() => obj.ToJsonFile(file));
	}

	[TestMethod]
	public void ToJsonFileTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var fileName = new FileInfo(RandomData.GenerateRandomFileName());

		try
		{
			person.ToJsonFile(fileName);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}

		File.Delete(fileName.FullName);
	}

	[TestMethod]
	public void ToJsonTest_01()
	{
		var person = RandomData.GeneratePerson<Person>();

		Assert.IsFalse(string.IsNullOrEmpty(person.ToJson()));
	}

	[TestMethod]
	public void ToJsonTest_02()
	{
		var person = RandomData.GeneratePerson<Person>();

		var json = person.ToJson(JsonSerializerOptions.Default);

		Assert.IsFalse(string.IsNullOrEmpty(json));
	}

	[TestMethod]
	public void TryDisposeTest()
	{
		var disposableObj = new DisposableFields();

		try
		{
			disposableObj.TryDispose();
			disposableObj.TryDispose(true);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}
}
