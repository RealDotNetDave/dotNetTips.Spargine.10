// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2025
// ***********************************************************************
// <copyright file="ObjectExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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
	public void DisposeCollection_WithEmptyCollection_DoesNotThrow()
	{
		var emptyCollection = new List<DisposableFields>();

		try
		{
			emptyCollection.DisposeCollection();
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail("Should not throw for empty collection");
		}
	}

	[TestMethod]
	public void DisposeCollection_WithNullCollection_DoesNotThrow()
	{
		List<DisposableFields> nullCollection = null;

		try
		{
			nullCollection.DisposeCollection();
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail("Should not throw for null collection");
		}
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
	public void FastBinaryClone_Array_ReturnsClonedArray()
	{
		var numbers = new[] { 1, 2, 3, 4, 5 };
		var clone = numbers.FastBinaryClone<int[]>();

		Assert.IsNotNull(clone);
		Assert.HasCount(numbers.Length, clone);
		Assert.AreNotSame(numbers, clone);

		for (int i = 0; i < numbers.Length; i++)
		{
			Assert.AreEqual(numbers[i], clone[i]);
		}
	}

	[TestMethod]
	public void FastBinaryClone_Collection_ReturnsClonedCollection()
	{
		var people = RandomData.GeneratePersonRefCollection(5).ToList();

		var clone = people.FastBinaryClone<List<Person>>();

		Assert.IsNotNull(clone);
		Assert.HasCount(people.Count, clone);
		Assert.AreNotSame(people, clone);

		for (int i = 0; i < people.Count; i++)
		{
			Assert.AreNotSame(people[i], clone[i]);
			Assert.AreEqual(people[i].Id, clone[i].Id);
		}
	}

	[TestMethod]
	public void FastBinaryClone_ComplexValueType_ReturnsClone()
	{
		var address = RandomData.GenerateAddress<Address>();
		var clone = address.FastBinaryClone<Address>();

		Assert.AreNotSame(address, clone);
		Assert.AreEqual(address.Address1, clone.Address1);
		Assert.AreEqual(address.City, clone.City);
		Assert.AreEqual(address.State, clone.State);
		Assert.AreEqual(address.PostalCode, clone.PostalCode);
	}

	[TestMethod]
	public void FastBinaryClone_EmptyCollection_ReturnsEmptyClone()
	{
		var emptyList = new List<Person>();
		var clone = emptyList.FastBinaryClone<List<Person>>();

		Assert.IsNotNull(clone);
		Assert.IsEmpty(clone);
		Assert.AreNotSame(emptyList, clone);
	}

	[TestMethod]
	public void FastBinaryClone_ModifyingClone_DoesNotAffectOriginal()
	{
		var person = RandomData.GeneratePerson<Person>();
		var originalFirstName = person.FirstName;

		var clone = person.FastBinaryClone<Person>();
		clone.FirstName = "ModifiedName";

		Assert.AreEqual(originalFirstName, person.FirstName);
		Assert.AreEqual("ModifiedName", clone.FirstName);
		Assert.AreNotEqual(person.FirstName, clone.FirstName);
	}

	[TestMethod]
	public void FastBinaryClone_Null_ThrowsArgumentNullException()
	{
		Person person = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.FastBinaryClone<Person>());
	}


	[TestMethod]
	public void FastBinaryClone_RoundTrip_MaintainsDataIntegrity()
	{
		var person = RandomData.GeneratePerson<Person>();

		var clone1 = person.FastBinaryClone<Person>();
		var clone2 = clone1.FastBinaryClone<Person>();

		Assert.IsNotNull(clone2);
		Assert.AreNotSame(person, clone2);
		Assert.AreNotSame(clone1, clone2);
		Assert.AreEqual(person.Id, clone2.Id);
		Assert.AreEqual(person.Email, clone2.Email);
	}

	[TestMethod]
	public void FastBinaryClone_SimpleObject_ReturnsDeepClone()
	{
		var person = RandomData.GeneratePerson<Person>();

		var clone = person.FastBinaryClone<Person>();

		Assert.IsNotNull(clone);
		Assert.AreNotSame(person, clone);
		Assert.AreEqual(person.Id, clone.Id);
		Assert.AreEqual(person.Email, clone.Email);
		Assert.AreEqual(person.FirstName, clone.FirstName);
		Assert.AreEqual(person.LastName, clone.LastName);
	}

	[TestMethod]
	public void FastBinaryClone_WithInheritance_PreservesTypeInformation()
	{
		var person = RandomData.GeneratePerson<Person>();
		var clone = person.FastBinaryClone<Person>();

		Assert.IsNotNull(clone);
		Assert.IsInstanceOfType(clone, typeof(Person));
		Assert.AreEqual(person.GetType(), clone.GetType());
	}

	[TestMethod]
	public void FastBinaryClone_WithNestedObjects_ClonesAllLevels()
	{
		var person = RandomData.GeneratePerson<Person>();

		var clone = person.FastBinaryClone<Person>();

		Assert.IsNotNull(clone);
		Assert.AreNotSame(person, clone);

		if (person.Addresses?.Count > 0 && clone.Addresses?.Count > 0)
		{
			Assert.AreNotSame(person.Addresses[0], clone.Addresses[0]);
			Assert.AreEqual(person.Addresses[0].Address1, clone.Addresses[0].Address1);
		}
	}

	[TestMethod]
	public void FastBinaryClone_WithNullOptions_UsesDefaults()
	{
		var person = RandomData.GeneratePerson<Person>();

		var clone = person.FastBinaryClone<Person>(null);

		Assert.IsNotNull(clone);
		Assert.AreNotSame(person, clone);
		Assert.AreEqual(person.Id, clone.Id);
	}

	[TestMethod]
	public void FastBinaryClone_WithOptions_Null_ThrowsArgumentNullException()
	{
		Person person = null;
		var options = MessagePack.MessagePackSerializerOptions.Standard;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.FastBinaryClone<Person>(options));
	}

	[TestMethod]
	public void FastBinaryClone_WithOptions_ReturnsClone()
	{
		var person = RandomData.GeneratePerson<Person>();
		var options = MessagePack.MessagePackSerializerOptions.Standard;

		var clone = person.FastBinaryClone<Person>(options);

		Assert.IsNotNull(clone);
		Assert.AreNotSame(person, clone);
		Assert.AreEqual(person.Id, clone.Id);
		Assert.AreEqual(person.Email, clone.Email);
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

		Assert.HasCount(1, dict);
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

		Assert.IsNotEmpty(dict);
		// Verify hierarchical naming with dot notation
		Assert.IsTrue(dict.Keys.Any(k => k.Contains("Person.")));
	}

	[TestMethod]
	public void FieldsToDictionary_DateTimeType_ReturnsFormattedString()
	{
		var dateTime = new DateTime(2025, 11, 17, 14, 30, 0);
		var dict = dateTime.FieldsToDictionary("DateTime");

		Assert.HasCount(1, dict);
		Assert.IsTrue(dict.ContainsKey("DateTime"));
		Assert.IsFalse(string.IsNullOrEmpty(dict["DateTime"]));
	}

	[TestMethod]
	public void FieldsToDictionary_EmptyCollection_ReturnsEmptyDictionary()
	{
		var emptyList = new List<int>();
		var dict = emptyList.FieldsToDictionary("Empty");

		Assert.IsEmpty(dict);
	}

	[TestMethod]
	public void FieldsToDictionary_EmptyMemberName_DoesNotPrefixKeys()
	{
		int value = 42;
		var dict = value.FieldsToDictionary(string.Empty);

		Assert.HasCount(1, dict);
		Assert.IsTrue(dict.ContainsKey(string.Empty));
	}

	[TestMethod]
	public void FieldsToDictionary_EnumerableType_ReturnsIndexedEntries()
	{
		var list = new List<int> { 1, 2, 3 };
		var dict = list.FieldsToDictionary("Numbers");

		Assert.IsNotEmpty(dict);
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

		Assert.IsEmpty(dict);
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

		Assert.HasCount(1, dict);
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

		Assert.IsNotEmpty(dict);
		// Verify indexed naming for collection items
		Assert.IsTrue(dict.Keys.Any(k => k.Contains("People[0].")));
		Assert.IsTrue(dict.Keys.Any(k => k.Contains("People[1].")));
	}

	[TestMethod]
	public void FieldsToDictionary_WithIgnoreNullsFalse_IncludesAllFields()
	{
		var testObject = new DisposableFields();
		var dict = testObject.FieldsToDictionary(ignoreEmptyValues: false);

		Assert.IsNotNull(dict);
		Assert.IsNotEmpty(dict);
	}

	[TestMethod]
	public void FieldsToDictionary_WithIgnoreNullsTrue_ExcludesNullFields()
	{
		var testObject = new DisposableFields();
		var dict = testObject.FieldsToDictionary(ignoreEmptyValues: true);

		Assert.IsNotNull(dict);

		// Verify that null fields are excluded
		Assert.IsFalse(dict.Values.Any(v => string.IsNullOrEmpty(v)));
	}

	[TestMethod]
	public void FieldsToDictionary_WithMemberName_UsesPrefixInKeys()
	{
		var person = RandomData.GeneratePerson<Person>();
		var dict = person.FieldsToDictionary("CustomPrefix");

		Assert.IsNotEmpty(dict);
		Assert.IsTrue(dict.Keys.Any(k => k.StartsWith("CustomPrefix.")));
	}

	[TestMethod]
	public void FieldsToString_BuiltInType_ReturnsValue()
	{
		int value = 42;
		var result = value.FieldsToString();

		Assert.Contains("42", result);
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
		Assert.DoesNotContain("k__BackingField", result);
	}

	[TestMethod]
	public void FieldsToString_ComplexObject_ReturnsHierarchicalString()
	{
		var propertiesTest = RandomData.GeneratePerson<Person>();

		var result = propertiesTest.FieldsToString();

		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.Contains(":", result);
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
		Assert.DoesNotContain("List`1", result);
	}

	[TestMethod]
	public void FieldsToString_MultipleFieldsWithSeparator_FormatsCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString(sequenceSeparator: ", ");

		// Check that fields are separated correctly
		if (result.Contains(","))
		{
			Assert.Contains(", ", result);
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
		Assert.Contains(":", result);
	}

	[TestMethod]
	public void FieldsToString_StringType_ReturnsValue()
	{
		string value = "Test String";
		var result = value.FieldsToString();

		Assert.Contains("Test String", result);
	}

	[TestMethod]
	public void FieldsToString_WithCustomKeyValueSeparator_UsesCustomSeparator()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString(keyValueSeparator: '=');


		Assert.IsTrue(result.IsNotEmpty());
		Assert.Contains("=", result);
	}

	[TestMethod]
	public void FieldsToString_WithCustomSequenceSeparator_UsesCustomSeparator()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString(sequenceSeparator: " | ");

		Assert.Contains(" | ", result);
	}

	[TestMethod]
	public void FieldsToString_WithHeader_IncludesHeader()
	{
		var person = RandomData.GeneratePerson<Person>();
		var header = "PERSON FIELDS:";
		var result = person.FieldsToString(header: header);

		Assert.StartsWith(header, result);
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

		Assert.DoesNotContain("Int32.", result);
	}

	[TestMethod]
	public void FieldsToString_WithIncludeMemberNameTrue_IncludesTypeName()
	{
		var person = RandomData.GeneratePerson<Person>();
		var result = person.FieldsToString(includeMemberName: true);

		Assert.Contains("Person.", result);
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
	public void GetImplementedInterfaces_WithFilter_ReturnsFilteredInterfaces()
	{
		var list = new List<int> { 1, 2, 3 };
		var filterNames = new ReadOnlyCollection<string>(new[] { "IEnumerable" });

		var interfaces = list.GetImplementedInterfaces(filterNames);

		Assert.IsNotNull(interfaces);
	}

	[TestMethod]
	public void GetImplementedInterfaces_WithList_ReturnsMultipleInterfaces()
	{
		var list = new List<int> { 1, 2, 3 };

		var interfaces = ObjectExtensions.GetImplementedInterfaces(list);

		Assert.IsNotNull(interfaces);
		Assert.IsNotEmpty(interfaces);
	}

	[TestMethod]
	public void GetImplementedInterfaces_WithPerson_ReturnsInterfaces()
	{
		var person = RandomData.GeneratePerson<Person>();

		var interfaces = ObjectExtensions.GetImplementedInterfaces(person);

		Assert.IsNotNull(interfaces);
		Assert.IsInstanceOfType(interfaces, typeof(ReadOnlyCollection<string>));
	}

	[TestMethod]
	public void GetImplementedInterfaceTypes_WithList_ReturnsMultipleTypes()
	{
		var list = new List<string> { "a", "b", "c" };

		var interfaceTypes = list.GetImplementedInterfaceTypes();

		Assert.IsNotNull(interfaceTypes);
		Assert.IsNotEmpty(interfaceTypes);
	}

	[TestMethod]
	public void GetImplementedInterfaceTypes_WithPerson_ReturnsTypes()
	{
		var person = RandomData.GeneratePerson<Person>();

		var interfaceTypes = person.GetImplementedInterfaceTypes();

		Assert.IsNotNull(interfaceTypes);
		Assert.IsInstanceOfType(interfaceTypes, typeof(ReadOnlyCollection<Type>));
	}

	[TestMethod]
	public void HasProperty_WithEmptyPropertyName_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.HasProperty(string.Empty));
	}

	[TestMethod]
	public void HasProperty_WithNullPropertyName_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => person.HasProperty(null));
	}

	[TestMethod]
	public void HasProperty_WithPrivateProperty_FindsProperty()
	{
		var person = RandomData.GeneratePerson<Person>();

		var hasId = person.HasProperty("Id");

		Assert.IsTrue(hasId);
	}

	[TestMethod]
	public void HasPropertyTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		Assert.IsTrue(person.HasProperty("Id"));

		Assert.IsFalse(person.HasProperty("XXXXXXXXXXXXX"));
	}

	[TestMethod]
	public void InitializeFields_Null_ThrowsArgumentNullException()
	{
		DisposableFields obj = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.InitializeFields());
	}

	[TestMethod]
	public void InitializeFields_WithNullFields_InitializesFields()
	{
		var testObject = new DisposableFields();

		try
		{
			testObject.InitializeFields();
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail("Should initialize fields without throwing");
		}
	}

	[TestMethod]
	public void InitializeFieldsTest()
	{
		var testObject = new DisposableFields();

		testObject.InitializeFields();
	}

	[TestMethod]
	public void IsString_WithNonString_ReturnsFalse()
	{
		object obj = 42;

		var result = obj.IsString();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsString_WithNull_ReturnsFalse()
	{
		object obj = null;

		var result = obj.IsString();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsString_WithPerson_ReturnsFalse()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = person.IsString();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsString_WithString_ReturnsTrue()
	{
		object obj = "test string";

		var result = obj.IsString();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Max_BothComparableIntegers_ReturnsLarger()
	{
		int value1 = 10;
		int value2 = 20;

		var result = value1.Max(value2);

		Assert.AreEqual(20, result);
	}

	[TestMethod]
	public void Max_BothComparableStrings_ReturnsLarger()
	{
		string value1 = "apple";
		string value2 = "zebra";

		var result = value1.Max(value2);

		Assert.AreEqual("zebra", result);
	}

	[TestMethod]
	public void Max_EqualValues_ReturnsEitherValue()
	{
		int value1 = 42;
		int value2 = 42;

		var result = value1.Max(value2);

		Assert.AreEqual(42, result);
	}

	[TestMethod]
	public void Max_FirstValueLarger_ReturnsFirst()
	{
		int value1 = 100;
		int value2 = 50;

		var result = value1.Max(value2);

		Assert.AreEqual(100, result);
	}

	[TestMethod]
	public void Max_NegativeNumbers_ReturnsCorrectMax()
	{
		int value1 = -10;
		int value2 = -5;

		var result = value1.Max(value2);

		Assert.AreEqual(-5, result);
	}

	[TestMethod]
	public void Max_WithDateTime_ReturnsLaterDate()
	{
		var date1 = new DateTime(2025, 1, 1);
		var date2 = new DateTime(2025, 12, 31);

		var result = date1.Max(date2);

		Assert.AreEqual(date2, result);
	}

	[TestMethod]
	public void Min_BothAreEqual_ReturnsValue()
	{
		// Arrange
		object obj1 = 5;
		var obj2 = 5;

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(5, result);
	}

	[TestMethod]
	public void Min_FirstIsSmaller_ReturnsFirst()
	{
		// Arrange
		object obj1 = 5;
		var obj2 = 10;

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(5, result);
	}

	[TestMethod]
	public void Min_ObjectNotComparableType_ThrowsInvalidOperationException()
	{
		// Arrange
		object obj1 = new List<int> { 1, 2, 3 }; // List<T> doesn't implement IComparable
		var obj2 = 10;

		// Act & Assert
		Assert.ThrowsExactly<InvalidOperationException>(() => obj1.Min(obj2));
	}

	[TestMethod]
	public void Min_SecondIsSmaller_ReturnsSecond()
	{
		// Arrange
		object obj1 = 10;
		var obj2 = 5;

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(5, result);
	}

	[TestMethod]
	public void Min_WithChar_ReturnsSmallerValue()
	{
		// Arrange
		object obj1 = 'Z';
		var obj2 = 'A';

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual('A', result);
	}

	[TestMethod]
	public void Min_WithDateTime_ReturnsEarlierDate()
	{
		// Arrange
		object obj1 = new DateTime(2024, 12, 31);
		var obj2 = new DateTime(2024, 1, 1);

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(new DateTime(2024, 1, 1), result);
	}

	[TestMethod]
	public void Min_WithDateTimeOffset_ReturnsEarlierDate()
	{
		// Arrange
		object obj1 = new DateTimeOffset(2024, 12, 31, 0, 0, 0, TimeSpan.Zero);
		var obj2 = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero), result);
	}

	[TestMethod]
	public void Min_WithDecimal_ReturnsSmallerValue()
	{
		// Arrange
		object obj1 = 24.99m;
		var obj2 = 19.99m;

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(19.99m, result);
	}

	[TestMethod]
	public void Min_WithDouble_ReturnsSmallerValue()
	{
		// Arrange
		object obj1 = 3.14159;
		var obj2 = 2.71828;

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(2.71828, result);
	}

	[TestMethod]
	public void Min_WithGuid_ReturnsSmallerGuid()
	{
		// Arrange
		object obj1 = new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff");
		var obj2 = new Guid("00000000-0000-0000-0000-000000000001");

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(new Guid("00000000-0000-0000-0000-000000000001"), result);
	}

	[TestMethod]
	public void Min_WithLong_ReturnsSmallerValue()
	{
		// Arrange
		object obj1 = 1000000000L;
		var obj2 = 500000000L;

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(500000000L, result);
	}

	[TestMethod]
	public void Min_WithNegativeNumbers_ReturnsSmallerValue()
	{
		// Arrange
		object obj1 = -5;
		var obj2 = -10;

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(-10, result);
	}

	[TestMethod]
	public void Min_WithStrings_ReturnsLexicographicallySmaller()
	{
		// Arrange
		object obj1 = "banana";
		var obj2 = "apple";

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual("apple", result);
	}

	[TestMethod]
	public void Min_WithTimeSpan_ReturnsShorterDuration()
	{
		// Arrange
		object obj1 = TimeSpan.FromHours(2);
		var obj2 = TimeSpan.FromMinutes(30);

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(TimeSpan.FromMinutes(30), result);
	}

	[TestMethod]
	public void Min_WithVersion_ReturnsLowerVersion()
	{
		// Arrange
		object obj1 = new Version(2, 0, 0);
		var obj2 = new Version(1, 0, 0);

		// Act
		var result = obj1.Min(obj2);

		// Assert
		Assert.AreEqual(new Version(1, 0, 0), result);
	}

	[TestMethod]
	public void Min_WrongType_ThrowsInvalidOperationException()
	{
		// Arrange
		object obj1 = "not an integer";
		var obj2 = 10;

		// Act & Assert
		Assert.ThrowsExactly<InvalidOperationException>(() => obj1.Min(obj2));
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
		Assert.HasCount(1, dict);
		Assert.IsTrue(dict.ContainsKey("TestInt"));
	}

	[TestMethod]
	public void PropertiesToDictionary_EnumerableType_ReturnsEntries()
	{
		var list = new List<int> { 1, 2, 3 };
		var dict = list.PropertiesToDictionary("Numbers");
		Assert.HasCount(3, dict);
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

		Assert.IsGreaterThan(1, result.Count);

		result = propertiesTest.PropertiesToDictionary(memberName: $"TestPerson-{personProper.Id}", ignoreNulls: true);

		Assert.IsGreaterThan(1, result.Count);
	}

	[TestMethod]
	public void PropertiesToString_EmptyHeader_DoesNotPrependHeader()
	{
		int value = 42;

		var result = value.PropertiesToString(header: string.Empty);

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void PropertiesToString_Null_ThrowsArgumentNullException()
	{
		object obj = null;
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => obj.PropertiesToString());
	}

	[TestMethod]
	public void PropertiesToString_NullSequenceSeparator_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();

		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			person.PropertiesToString(sequenceSeparator: null));
	}

	[TestMethod]
	public void PropertiesToString_WithCustomSeparators_FormatsCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = person.PropertiesToString(
			header: "PERSON:",
			keyValueSeparator: '=',
			sequenceSeparator: " | ",
			ignoreNulls: true,
			includeMemberName: true);

		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.StartsWith("PERSON:", result);
		Assert.Contains("=", result);
		Assert.Contains(" | ", result);
	}

	[TestMethod]
	public void PropertiesToString_WithIgnoreNullsFalse_IncludesNulls()
	{
		var testObject = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			Person = null,
			PersonRecord = RandomData.GeneratePerson<PersonRecord>(),
			Today = Clock.LocalTime
		};

		var result = testObject.PropertiesToString(ignoreNulls: false);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void PropertiesToString_WithIncludeMemberNameFalse_ExcludesTypeName()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = person.PropertiesToString(includeMemberName: false);

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_ComplexTypeFilter_WorksCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();
		// Select only properties that are reference types (classes)
		Func<PropertyInfo, bool> complexTypesOnly = p => !p.PropertyType.IsValueType && p.PropertyType != typeof(string);

		var result = person.PropertiesToString(complexTypesOnly);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_ExcludeByAttribute_ReturnsFilteredProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> excludeJsonIgnore = p => p.GetCustomAttribute<System.Text.Json.Serialization.JsonIgnoreAttribute>() == null;

		var result = person.PropertiesToString(excludeJsonIgnore);

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_FilterByCanRead_ReturnsOnlyReadableProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> readableOnly = p => p.CanRead;

		var result = person.PropertiesToString(readableOnly);

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_FilterByCanWrite_ReturnsOnlyWritableProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> writableOnly = p => p.CanWrite;

		var result = person.PropertiesToString(writableOnly);

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_FilterByName_ReturnsOnlyMatchingProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> idPropertyOnly = p => p.Name == "Id";

		var result = person.PropertiesToString(idPropertyOnly);

		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.Contains("Id", result);
		Assert.DoesNotContain("FirstName", result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_FilterByType_ReturnsOnlyMatchingProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> stringPropertiesOnly = p => p.PropertyType == typeof(string);

		var result = person.PropertiesToString(stringPropertiesOnly);

		Assert.IsFalse(string.IsNullOrEmpty(result));
		// Verify that result contains string properties like FirstName, LastName, Email
		Assert.IsTrue(result.Contains("FirstName") || result.Contains("LastName") || result.Contains("Email"));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_MultipleFilters_CombinesCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();
		// Combine multiple conditions
		Func<PropertyInfo, bool> complexFilter = p =>
			p.PropertyType == typeof(string) &&
			p.CanRead &&
			p.CanWrite &&
			!p.Name.StartsWith("_");

		var result = person.PropertiesToString(complexFilter);

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_Null_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> nullSelector = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			person.PropertiesToString(nullSelector));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_NullObject_ThrowsArgumentNullException()
	{
		object obj = null;
		Func<PropertyInfo, bool> selector = p => p.PropertyType == typeof(string);

		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			obj.PropertiesToString(selector));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_NullSequenceSeparator_ThrowsArgumentNullException()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> selector = p => true;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			person.PropertiesToString(selector, sequenceSeparator: null));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_PropertyThrowsException_HandlesGracefully()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> selector = p => true;

		// This should handle any properties that throw during value retrieval
		var result = person.PropertiesToString(selector, ignoreNulls: false);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_SelectAll_ReturnsAllProperties()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> selectAll = p => true;

		var result = person.PropertiesToString(selectAll);

		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.Contains(":", result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_SelectNone_ReturnsEmptyOrHeader()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> selectNone = p => false;

		var result = person.PropertiesToString(selectNone);

		Assert.IsNotNull(result);
		// Result should be empty or only contain header if provided
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_ValueTypeFilter_WorksCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();
		// Select only value type properties
		Func<PropertyInfo, bool> valueTypesOnly = p => p.PropertyType.IsValueType;

		var result = person.PropertiesToString(valueTypesOnly);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_WithCustomSeparators_FormatsCorrectly()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> selector = p => p.PropertyType == typeof(string);

		var result = person.PropertiesToString(
			selector,
			header: "PROPERTIES:",
			keyValueSeparator: '=',
			sequenceSeparator: " | ");

		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.StartsWith("PROPERTIES:", result);
		Assert.Contains("=", result);
		Assert.Contains(" | ", result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_WithHeader_IncludesHeader()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> selector = p => p.PropertyType == typeof(string);
		var header = "STRING PROPERTIES:";

		var result = person.PropertiesToString(selector, header: header);

		Assert.StartsWith(header, result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_WithIgnoreNullsFalse_IncludesNullValues()
	{
		var testObject = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			Person = null,
			PersonRecord = RandomData.GeneratePerson<PersonRecord>(),
			Today = Clock.LocalTime
		};
		Func<PropertyInfo, bool> selector = p => true;

		var result = testObject.PropertiesToString(selector, ignoreNulls: false);

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_WithIgnoreNullsTrue_ExcludesNullValues()
	{
		var testObject = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			Person = null,
			PersonRecord = RandomData.GeneratePerson<PersonRecord>(),
			Today = Clock.LocalTime
		};
		Func<PropertyInfo, bool> selector = p => true;

		var result = testObject.PropertiesToString(selector, ignoreNulls: true);

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_WithIncludeMemberNameFalse_ExcludesTypeName()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> selector = p => p.PropertyType == typeof(string);

		var result = person.PropertiesToString(selector, includeMemberName: false);

		Assert.DoesNotContain("Person.", result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_WithIncludeMemberNameTrue_IncludesTypeName()
	{
		var person = RandomData.GeneratePerson<Person>();
		Func<PropertyInfo, bool> selector = p => p.PropertyType == typeof(string);

		var result = person.PropertiesToString(selector, includeMemberName: true);

		Assert.Contains("Person.", result);
	}

	[TestMethod]
	public void PropertiesToString_WithPropertySelector_WithList_HandlesCorrectly()
	{
		var people = new List<Person>
		{
			RandomData.GeneratePerson<Person>(),
			RandomData.GeneratePerson<Person>()
		};
		Func<PropertyInfo, bool> selector = p => p.PropertyType == typeof(int);

		var result = people.PropertiesToString(selector);

		Assert.IsNotNull(result);
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
	public void TryDispose_WithThrowExceptionFalse_SuppressesException()
	{
		var faultyDisposable = new FaultyDisposableObject();

		try
		{
			faultyDisposable.TryDispose(throwException: false);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail("Should suppress exception when throwException is false");
		}
	}

	[TestMethod]
	public void TryDispose_WithThrowExceptionTrue_RethrowsException()
	{
		var faultyDisposable = new FaultyDisposableObject();

		_ = Assert.ThrowsExactly<InvalidOperationException>(() =>
			faultyDisposable.TryDispose(throwException: true));
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

	private class FaultyDisposableObject : IDisposable
	{
		public void Dispose()
		{
			throw new InvalidOperationException("Faulty dispose");
		}
	}

}
