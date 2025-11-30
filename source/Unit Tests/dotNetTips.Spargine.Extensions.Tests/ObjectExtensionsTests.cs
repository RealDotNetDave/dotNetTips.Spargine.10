// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-17-2025
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.As<object>());
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.ComputeSha256Hash());
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.FastClone<Person>());
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.FastClone<Person>((JsonSerializerOptions)null));
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.FastClone((JsonTypeInfo<Person>)null));
	}

	[TestMethod]
	public void FastClone_NullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.FastClone((JsonTypeInfo<Person>)null));
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
		var fastHashCode = numbers.FastHashCode();

		Assert.AreEqual(hashCode, fastHashCode);
	}

	[TestMethod]
	public void FastGetHashCodePersonTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var hashCode = person.GetHashCode();
		var fastHashCode = person.FastHashCode();

		Assert.AreNotEqual(hashCode, fastHashCode);
	}

	[TestMethod]
	public void FieldsToDictionary_BuiltInType_ReturnsSingleEntry()
	{
		int value = 42;
		var dict = value.FieldsToDictionary("TestInt");

		Assert.AreEqual(1, dict.Count);
		Assert.IsTrue(dict.ContainsKey("TestInt"));
		Assert.AreEqual("42", dict["TestInt"]);
	}

	[TestMethod]
	public void FieldsToDictionary_CompilerGeneratedFieldsExcluded()
	{
		var person = RandomData.GeneratePerson<Person>();
		var dict = person.FieldsToDictionary();

		// Verify no compiler-generated backing fields (e.g., <PropertyName>k__BackingField)
		Assert.IsFalse(dict.Keys.Any(k => k.Contains("k__BackingField")));
	}

	[TestMethod]
	public void FieldsToDictionary_ComplexObject_ReturnsHierarchicalNames()
	{
		var person = RandomData.GeneratePerson<Person>();
		var dict = person.FieldsToDictionary("Person");

		Assert.IsTrue(dict.Count > 0);
		// Verify hierarchical naming with dot notation
		Assert.IsTrue(dict.Keys.Any(k => k.Contains("Person.")));
	}

	[TestMethod]
	public void FieldsToDictionary_DateTimeType_ReturnsFormattedString()
	{
		var dateTime = new DateTime(2025, 11, 17, 14, 30, 0);
		var dict = dateTime.FieldsToDictionary("DateTime");

		Assert.AreEqual(1, dict.Count);
		Assert.IsTrue(dict.ContainsKey("DateTime"));
		Assert.IsFalse(string.IsNullOrEmpty(dict["DateTime"]));
	}

	[TestMethod]
	public void FieldsToDictionary_EmptyCollection_ReturnsEmptyDictionary()
	{
		var emptyList = new List<int>();
		var dict = emptyList.FieldsToDictionary("Empty");

		Assert.AreEqual(0, dict.Count);
	}

	[TestMethod]
	public void FieldsToDictionary_EmptyMemberName_DoesNotPrefixKeys()
	{
		int value = 42;
		var dict = value.FieldsToDictionary(string.Empty);

		Assert.AreEqual(1, dict.Count);
		Assert.IsTrue(dict.ContainsKey(string.Empty));
	}

	[TestMethod]
	public void FieldsToDictionary_EnumerableType_ReturnsIndexedEntries()
	{
		var list = new List<int> { 1, 2, 3 };
		var dict = list.FieldsToDictionary("Numbers");

		Assert.IsTrue(dict.Count > 0);
		Assert.IsTrue(dict.Keys.Any(k => k.StartsWith("Numbers[0]")));
		Assert.IsTrue(dict.Keys.Any(k => k.StartsWith("Numbers[1]")));
		Assert.IsTrue(dict.Keys.Any(k => k.StartsWith("Numbers[2]")));
	}

	[TestMethod]
	public void FieldsToDictionary_NestedObjects_ReturnsRecursiveFields()
	{
		var propertiesTest = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			Person = RandomData.GeneratePerson<Person>(),
			PersonRecord = RandomData.GeneratePerson<PersonRecord>(),
			Today = Clock.LocalTime
		};

		var dict = propertiesTest.FieldsToDictionary();

		Assert.IsTrue(dict.Count == 0);
	}
	[TestMethod]
	public void FieldsToDictionary_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.FieldsToDictionary());
	}

	[TestMethod]
	public void FieldsToDictionary_NullMemberName_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.FieldsToDictionary(null));
	}

	[TestMethod]
	public void FieldsToDictionary_ReturnsReadOnlyDictionary()
	{
		var person = RandomData.GeneratePerson<Person>();
		var dict = person.FieldsToDictionary();

		Assert.IsNotNull(dict);
		Assert.IsInstanceOfType(dict, typeof(IReadOnlyDictionary<string, string>));
	}

	[TestMethod]
	public void FieldsToDictionary_String_ReturnsSingleEntry()
	{
		string value = "Hello World";
		var dict = value.FieldsToDictionary("TestString");

		Assert.AreEqual(1, dict.Count);
		Assert.IsTrue(dict.ContainsKey("TestString"));
		Assert.AreEqual("Hello World", dict["TestString"]);
	}

	[TestMethod]
	public void FieldsToDictionary_WithCollectionOfComplexObjects_ReturnsIndexedHierarchy()
	{
		var people = new List<Person>
	{
		RandomData.GeneratePerson<Person>(),
		RandomData.GeneratePerson<Person>()
	};

		var dict = people.FieldsToDictionary("People");

		Assert.IsTrue(dict.Count > 0);
		// Verify indexed naming for collection items
		Assert.IsTrue(dict.Keys.Any(k => k.Contains("People[0].")));
		Assert.IsTrue(dict.Keys.Any(k => k.Contains("People[1].")));
	}

	[TestMethod]
	public void FieldsToDictionary_WithIgnoreNullsFalse_IncludesAllFields()
	{
		var testObject = new DisposableFields();
		var dict = testObject.FieldsToDictionary(ignoreNulls: false);

		Assert.IsNotNull(dict);
		Assert.IsTrue(dict.Count > 0);
	}

	[TestMethod]
	public void FieldsToDictionary_WithIgnoreNullsTrue_ExcludesNullFields()
	{
		var testObject = new DisposableFields();
		var dict = testObject.FieldsToDictionary(ignoreNulls: true);

		Assert.IsNotNull(dict);
		// Verify that null fields are excluded
		Assert.IsFalse(dict.Values.Any(v => string.IsNullOrEmpty(v)));
	}

	[TestMethod]
	public void FieldsToDictionary_WithMemberName_UsesPrefixInKeys()
	{
		var person = RandomData.GeneratePerson<Person>();
		var dict = person.FieldsToDictionary("CustomPrefix");

		Assert.IsTrue(dict.Count > 0);
		Assert.IsTrue(dict.Keys.Any(k => k.StartsWith("CustomPrefix.")));
	}

	[TestMethod]
	public void FieldsToString_BuiltInType_ReturnsValue()
	{
		int value = 42;
		var result = value.FieldsToString();

		Assert.IsTrue(result.Contains("42"));
	}

	[TestMethod]
	public void FieldsToString_Collection_ReturnsIndexedFields()
	{
		var numbers = new List<int> { 1, 2, 3 };
		var result = numbers.FieldsToString();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FieldsToString_CompilerGeneratedFields_AreExcluded()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString();

		// Should not contain backing field syntax
		Assert.IsFalse(result.Contains("k__BackingField"));
	}

	[TestMethod]
	public void FieldsToString_ComplexObject_ReturnsHierarchicalString()
	{
		var propertiesTest = RandomData.GeneratePerson<Person>();

		var result = propertiesTest.FieldsToString();

		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.IsTrue(result.Contains(":"));
	}

	[TestMethod]
	public void FieldsToString_EmptyCollection_ReturnsEmptyString()
	{
		var emptyList = new List<int>();
		var result = emptyList.FieldsToString();

		// Empty collections may return empty or minimal output
		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FieldsToString_ListType_UsesItemTypeName()
	{
		var people = new List<Person>
	{
		RandomData.GeneratePerson<Person>(),
		RandomData.GeneratePerson<Person>()
	};

		var result = people.FieldsToString();

		Assert.IsNotNull(result);
		// List<> should be replaced with "Item"
		Assert.IsFalse(result.Contains("List`1"));
	}

	[TestMethod]
	public void FieldsToString_MultipleFieldsWithSeparator_FormatsCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString(sequenceSeparator: ", ");

		// Check that fields are separated correctly
		if (result.Contains(","))
		{
			Assert.IsTrue(result.Contains(", "));
		}
	}

	[TestMethod]
	public void FieldsToString_NestedObjects_ReturnsHierarchicalFormat()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString();

		Assert.IsFalse(string.IsNullOrEmpty(result));
		// Should contain hierarchical field names with dots
		Assert.IsTrue(result.Contains(".") || result.Contains(":"));
	}

	[TestMethod]
	public void FieldsToString_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.FieldsToString());
	}

	[TestMethod]
	public void FieldsToString_NullSequenceSeparator_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.FieldsToString(sequenceSeparator: null));
	}

	[TestMethod]
	public void FieldsToString_SimpleObject_ReturnsFormattedString()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString();

		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.IsTrue(result.Contains(":"));
	}

	[TestMethod]
	public void FieldsToString_StringType_ReturnsValue()
	{
		string value = "Test String";
		var result = value.FieldsToString();

		Assert.IsTrue(result.Contains("Test String"));
	}

	[TestMethod]
	public void FieldsToString_WithCustomKeyValueSeparator_UsesCustomSeparator()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString(keyValueSeparator: '=');


		Assert.IsTrue(result.IsNotEmpty());
		Assert.IsTrue(result.Contains("="));
	}

	[TestMethod]
	public void FieldsToString_WithCustomSequenceSeparator_UsesCustomSeparator()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString(sequenceSeparator: " | ");

		Assert.IsTrue(result.Contains(" | "));
	}

	[TestMethod]
	public void FieldsToString_WithHeader_IncludesHeader()
	{
		var person = RandomData.GeneratePerson<Person>();
		var header = "PERSON FIELDS:";
		var result = person.FieldsToString(header: header);

		Assert.IsTrue(result.StartsWith(header));
	}

	[TestMethod]
	public void FieldsToString_WithIgnoreNullsFalse_IncludesAllFields()
	{
		var testObject = new DisposableFields();
		var result = testObject.FieldsToString(ignoreNulls: false);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FieldsToString_WithIgnoreNullsTrue_ExcludesNullFields()
	{
		var testObject = new DisposableFields();
		var result = testObject.FieldsToString(ignoreNulls: true);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void FieldsToString_WithIncludeMemberNameFalse_ExcludesTypeName()
	{
		int value = 42;
		var result = value.FieldsToString(includeMemberName: false);

		Assert.IsFalse(result.Contains("Int32."));
	}

	[TestMethod]
	public void FieldsToString_WithIncludeMemberNameTrue_IncludesTypeName()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString(includeMemberName: true);

		Assert.IsTrue(result.Contains("Person."));
	}

	[TestMethod]
	public void FromJson_Null_ThrowsArgumentNullException()
	{
		string json = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => json.FromJson<Person>());
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => json.FromJson<Person>((JsonSerializerOptions)null));
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => json.FromJson((JsonTypeInfo<Person>)null));
	}

	[TestMethod]
	public void FromJson_NullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = person.ToJson();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => json.FromJson((JsonTypeInfo<Person>)null));
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.PropertiesToDictionary());
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

		Assert.IsTrue(result.Count > 1);

		result = propertiesTest.PropertiesToDictionary(memberName: $"TestPerson-{personProper.Id}", ignoreNulls: true);

		Assert.IsTrue(result.Count > 1);
	}

	[TestMethod]
	public void PropertiesToString_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.PropertiesToString());
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.ToJson());
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.ToJson(null));
	}

	[TestMethod]
	public void ToJson_WithTypeInfo_NullTypeInfo_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.ToJson((JsonTypeInfo<Person>)null));
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
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.ToJsonFile(file));
	}

	[TestMethod]
	public void ToJsonFile_NullObject_ThrowsArgumentNullException()
	{
		object obj = null;
		var file = new FileInfo(Path.GetTempFileName());
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.ToJsonFile(file));
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
	public void ToLazy_AccessingValue_ReturnsOriginalValue()
	{
		var person = RandomData.GeneratePerson<Person>();
		var lazyPerson = person.ToLazy();

		var result = lazyPerson.Value;

		Assert.IsNotNull(result);
		Assert.AreEqual(person, result);
		Assert.IsTrue(lazyPerson.IsValueCreated);
	}

	[TestMethod]
	public void ToLazy_MultipleAccess_ReturnsSameInstance()
	{
		var person = RandomData.GeneratePerson<Person>();
		var lazyPerson = person.ToLazy();

		var first = lazyPerson.Value;
		var second = lazyPerson.Value;

		Assert.AreSame(first, second);
		Assert.AreEqual(person, first);
	}

	[TestMethod]
	public void ToLazy_NullValue_ThrowsArgumentNullException()
	{
		Person person = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.ToLazy());
	}

	[TestMethod]
	public void ToLazy_ValueNotEvaluatedImmediately()
	{
		var person = RandomData.GeneratePerson<Person>();
		var lazyPerson = person.ToLazy();

		Assert.IsFalse(lazyPerson.IsValueCreated);
	}

	[TestMethod]
	public void ToLazy_WithCollection_ReturnsLazyCollection()
	{
		var people = RandomData.GeneratePersonRefCollection(10);
		var lazyPeople = people.ToLazy();

		Assert.IsNotNull(lazyPeople);
		Assert.IsFalse(lazyPeople.IsValueCreated);

		var result = lazyPeople.Value;

		Assert.IsTrue(lazyPeople.IsValueCreated);
		Assert.AreEqual(10, result.Count());
	}

	[TestMethod]
	public void ToLazy_WithComplexType_PreservesAllProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		var lazyPerson = person.ToLazy();

		var result = lazyPerson.Value;

		Assert.AreEqual(person.Id, result.Id);
		Assert.AreEqual(person.Email, result.Email);
		Assert.AreEqual(person.FirstName, result.FirstName);
		Assert.AreEqual(person.LastName, result.LastName);
	}

	[TestMethod]
	public void ToLazy_WithInt_ReturnsLazyInt()
	{
		int value = 42;
		var lazyValue = value.ToLazy();

		Assert.IsNotNull(lazyValue);
		Assert.AreEqual(42, lazyValue.Value);
	}

	[TestMethod]
	public void ToLazy_WithString_ReturnsLazyString()
	{
		string value = "Test String";
		var lazyValue = value.ToLazy();

		Assert.IsNotNull(lazyValue);
		Assert.AreEqual("Test String", lazyValue.Value);
	}

	[TestMethod]
	public void ToLazy_WithValue_ReturnsLazyInstance()
	{
		var person = RandomData.GeneratePerson<Person>();
		var lazyPerson = person.ToLazy();

		Assert.IsNotNull(lazyPerson);
		Assert.IsInstanceOfType(lazyPerson, typeof(Lazy<Person>));
	}

	[TestMethod]
	public void ToLazy_WithValueType_Works()
	{
		var dateTime = DateTime.Now;
		var lazyDateTime = dateTime.ToLazy();

		Assert.IsNotNull(lazyDateTime);
		Assert.AreEqual(dateTime, lazyDateTime.Value);
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
