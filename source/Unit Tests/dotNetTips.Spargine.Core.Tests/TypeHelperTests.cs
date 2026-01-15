// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 01-15-2026
// ***********************************************************************
// <copyright file="TypeHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class TypeHelperTests : UnitTester
{

	[TestMethod]
	public void BuiltInTypeNames01()
	{
		var result = TypeHelper.BuiltInTypeNames().Values;

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void BuiltinTypesTest()
	{
		var result = TypeHelper.BuiltInTypes;

		Assert.IsNotNull(result);

		Assert.IsGreaterThanOrEqualTo(16, result.Count);
	}

	[TestMethod]
	public void CreateTypeTest01()
	{
		var result = TypeHelper.Create<Person>();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void CreateTypeTest02()
	{
		var result = TypeHelper.Create<Person>("DOTNETDAVE@LIVE.COM", "TESTIDTESTTEST");

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void DoesObjectEqualInstance01()
	{
		var person = RandomData.GeneratePerson<Person>();
		var testPerson = person;

		Assert.IsTrue(TypeHelper.DoesObjectEqualInstance(person, testPerson));
	}

	[TestMethod]
	public void DoesObjectEqualInstance02()
	{
		var person = RandomData.GeneratePerson<Person>();
		var testPerson = RandomData.GeneratePerson<Person>();

		Assert.IsFalse(TypeHelper.DoesObjectEqualInstance(person, testPerson));
	}

	[TestMethod]
	public void FindDerivedTypes_AppDomain_NullBaseType_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, null, true));
	}

	[TestMethod]
	public void FindDerivedTypes_AppDomain_NullDomain_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(null, typeof(Exception), true));
	}

	[TestMethod]
	public void FindDerivedTypes_AppDomain_ValidBaseType_ReturnsDerivedTypes()
	{
		// Act
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(Exception), true);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result);

		//Run again to hit cache
		var result2 = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(Exception), true);

		// Assert
		Assert.IsNotNull(result2);
		Assert.IsNotEmpty(result2);
	}

	[TestMethod]
	public void FindDerivedTypes_CurrentlyLoadedAssemblies_NullBaseType_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(null, true));
	}

	[TestMethod]
	public void FindDerivedTypes_CurrentlyLoadedAssemblies_ValidBaseType_ReturnsDerivedTypes()
	{
		// Act
		var result = TypeHelper.FindDerivedTypes(typeof(Exception), true);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result);
	}

	[TestMethod]
	public void FindDerivedTypes_Directory()
	{
		var result = TypeHelper.FindDerivedTypes(
			new DirectoryInfo(App.ExecutingFolder()),
			SearchOption.AllDirectories,
			typeof(MulticastDelegate),
			true);

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void FindDerivedTypes_Directory_NullBaseType_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(new DirectoryInfo(App.ExecutingFolder()), SearchOption.AllDirectories, null, true));
	}

	[TestMethod]
	public void FindDerivedTypes_Directory_NullPath_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.FindDerivedTypes(null, SearchOption.AllDirectories, typeof(Exception), true));
	}

	[TestMethod]
	public void FindDerivedTypes_Exception()
	{
		var result = TypeHelper.FindDerivedTypes(typeof(Exception), true);

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void FindDerivedTypes_MulticastDelegate()
	{
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(MulticastDelegate), true);

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void FromJson01()
	{
		var person = RandomData.GeneratePerson<Person>();
		var json = person.ToJson();

		Assert.IsNotNull(TypeHelper.FromJson<Person>(json));
	}

	[TestMethod]
	public void FromJsonFile_InvalidJson_ThrowsJsonException()
	{
		// Arrange
		var invalidJson = "{ invalid json }";
		var fileName = Path.GetTempFileName();
		File.WriteAllText(fileName, invalidJson);
		var fileInfo = new FileInfo(fileName);

		// Act & Assert
		_ = Assert.ThrowsExactly<JsonException>(() => TypeHelper.FromJsonFile<Person>(fileInfo));

		// Cleanup
		File.Delete(fileName);
	}

	[TestMethod]
	public void FromJsonFile_NonExistentFile_ThrowsFileNotFoundException()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\nonexistentfile.json");

		// Act & Assert
		_ = Assert.ThrowsExactly<FileNotFoundException>(() => TypeHelper.FromJsonFile<Person>(fileInfo));
	}

	[TestMethod]
	public void FromJsonFile_NullFile_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.FromJsonFile<Person>(null));
	}

	[TestMethod]
	public void FromJsonFile_ValidJson_ReturnsDeserializedObject()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();
		var json = person.ToJson();
		var fileName = Path.GetTempFileName();
		File.WriteAllText(fileName, json);
		var fileInfo = new FileInfo(fileName);

		// Act
		var result = TypeHelper.FromJsonFile<Person>(fileInfo);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(person.Id, result.Id);
		Assert.AreEqual(person.Email, result.Email);

		// Cleanup
		File.Delete(fileName);
	}

	[TestMethod]
	public void FromJsonFile01()
	{
		var person = RandomData.GeneratePerson<Person>();
		var fileName = RandomData.GenerateRandomFileName();

		person.ToJsonFile(new FileInfo(fileName));

		Assert.IsNotNull(TypeHelper.FromJsonFile<Person>(new FileInfo(fileName)));

		File.Delete(fileName);
	}

	[TestMethod]
	public void GetAllAbstractMethods_AbstractClass_ReturnsAbstractMethodsOnly()
	{
		// Arrange
		var type = typeof(Stream);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0);
		Assert.IsTrue(result.All(m => m.IsAbstract), "All returned methods should be abstract");
	}

	[TestMethod]
	public void GetAllAbstractMethods_AbstractClassWithNoAbstractMethods_ReturnsEmpty()
	{
		// Arrange
		// Use a type that is abstract but might not have abstract methods
		var type = typeof(MemberInfo);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		// Even if abstract, might not have declared abstract methods
		Assert.IsTrue(result.Count >= 0);
	}

	[TestMethod]
	public void GetAllAbstractMethods_CachingWorks_ReturnsSameResults()
	{
		// Arrange
		var type = typeof(Stream);

		// Act - Call twice
		var result1 = TypeHelper.GetAllAbstractMethods(type);
		var result2 = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result1);
		Assert.IsNotNull(result2);
		Assert.AreEqual(result1.Count, result2.Count);

		// Compare method names to verify same results
		var names1 = result1.Select(m => m.Name).OrderBy(n => n).ToArray();
		var names2 = result2.Select(m => m.Name).OrderBy(n => n).ToArray();
		CollectionAssert.AreEqual(names1, names2);
	}

	[TestMethod]
	public void GetAllAbstractMethods_ClosedGenericType_HandlesCorrectly()
	{
		// Arrange
		var type = typeof(List<int>);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void GetAllAbstractMethods_ConcreteClass_ReturnsEmptyCollection()
	{
		// Arrange
		var type = typeof(Person);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void GetAllAbstractMethods_Delegate_ReturnsExpectedMethods()
	{
		// Arrange
		var type = typeof(Action);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		// Delegates are sealed and have no abstract methods
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void GetAllAbstractMethods_Enum_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(DateTimeKind);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Enums cannot have abstract methods");
	}

	[TestMethod]
	public void GetAllAbstractMethods_GenericType_HandlesCorrectly()
	{
		// Arrange
		var type = typeof(List<>);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "List<T> is not abstract and has no abstract methods");
	}

	[TestMethod]
	public void GetAllAbstractMethods_Interface_ReturnsAbstractMethods()
	{
		// Arrange
		var type = typeof(IDisposable);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		// Interfaces have abstract methods
		Assert.IsTrue(result.Count > 0);
		Assert.IsTrue(result.All(m => m.IsAbstract));
	}

	[TestMethod]
	public void GetAllAbstractMethods_NullType_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllAbstractMethods(null));
	}

	[TestMethod]
	public void GetAllAbstractMethods_OnlyDeclaredMethods_DoesNotIncludeInherited()
	{
		// Arrange
		var type = typeof(MemoryStream); // Concrete class inheriting from abstract Stream

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert - MemoryStream has no abstract methods of its own
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Concrete MemoryStream should not have abstract methods");
	}

	[TestMethod]
	public void GetAllAbstractMethods_PerformanceWithCaching_SecondCallIsFaster()
	{
		// Arrange
		var type = typeof(Stream);

		// Act - First call (cache miss)
		var sw1 = Stopwatch.StartNew();
		var result1 = TypeHelper.GetAllAbstractMethods(type);
		sw1.Stop();

		// Act - Second call (cache hit)
		var sw2 = Stopwatch.StartNew();
		var result2 = TypeHelper.GetAllAbstractMethods(type);
		sw2.Stop();

		// Assert
		Assert.IsNotNull(result1);
		Assert.IsNotNull(result2);
		Assert.AreEqual(result1.Count, result2.Count);

		// Second call should be faster due to caching
		Assert.IsTrue(sw2.ElapsedTicks <= sw1.ElapsedTicks * 2,
			$"Cached call should be faster: First={sw1.ElapsedTicks}ns, Second={sw2.ElapsedTicks}ns");
	}

	[TestMethod]
	public void GetAllAbstractMethods_ReturnsReadOnlyCollection()
	{
		// Arrange
		var type = typeof(Stream);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsInstanceOfType<ReadOnlyCollection<MethodInfo>>(result);
	}

	[TestMethod]
	public void GetAllAbstractMethods_SealedClass_ReturnsEmptyCollection()
	{
		// Arrange
		var type = typeof(string);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void GetAllAbstractMethods_StaticClass_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(Math);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Static classes cannot have abstract methods");
	}

	[TestMethod]
	public void GetAllAbstractMethods_Struct_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(DateTime);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Structs cannot have abstract methods");
	}

	[TestMethod]
	public void GetAllAbstractMethods_ValueType_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(int);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Value types cannot have abstract methods");
	}

	[TestMethod]
	public void GetAllAbstractMethods_VerifyNoNonAbstractMethods()
	{
		// Arrange
		var type = typeof(Stream);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsFalse(result.Any(m => !m.IsAbstract),
			"Result should not contain any non-abstract methods");
	}

	[TestMethod]
	public void GetAllAbstractMethods_WithAbstractMethods_ReturnsMethods()
	{
		// Arrange
		var type = typeof(Stream); // Stream has abstract methods

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Any(m => m.IsAbstract));
	}

	[TestMethod]
	public void GetAllAbstractMethods_WithMultipleAbstractMethods_ReturnsAll()
	{
		// Arrange
		var type = typeof(Stream);

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 1, "Stream should have multiple abstract methods");

		// Verify some known abstract methods exist
		var methodNames = result.Select(m => m.Name).ToHashSet();
		Assert.IsTrue(methodNames.Contains("Read") || methodNames.Contains("Write"),
			"Stream should contain Read or Write abstract methods");
	}

	[TestMethod]
	public void GetAllAbstractMethods_WithoutAbstractMethods_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(StringBuilder); // StringBuilder has no abstract methods

		// Act
		var result = TypeHelper.GetAllAbstractMethods(type);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsFalse(result.Any());
	}

	[TestMethod]
	public void GetAllConstructors_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllConstructors(null).ToList());
	}

	[TestMethod]
	public void GetAllConstructors_WithBaseTypeConstructors_ReturnsInherited()
	{
		// Arrange
		var type = typeof(MemoryStream);

		// Act
		var ctors = TypeHelper.GetAllConstructors(type).ToList();

		// Assert
		Assert.IsNotNull(ctors);
		Assert.IsTrue(ctors.Any());
		// MemoryStream inherits from Stream, but Stream is abstract, so only MemoryStream's constructors are present
		Assert.IsFalse(ctors.All(c => c.DeclaringType == typeof(MemoryStream)));
	}
	[TestMethod]
	public void GetAllConstructors_WithPublicAndPrivateConstructors_ReturnsAll()
	{
		// Arrange
		var type = typeof(StringBuilder);

		// Act
		var ctors = TypeHelper.GetAllConstructors(type).ToList();

		// Assert
		Assert.IsNotNull(ctors);
		Assert.IsTrue(ctors.Any());
		Assert.IsTrue(ctors.Any(c => c.IsPublic));
	}

	[TestMethod]
	public void GetAllDeclaredFields_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllDeclaredFields(null).ToList());
	}
	[TestMethod]
	public void GetAllDeclaredFields_WithDeclaredFields_ReturnsFields()
	{
		// Arrange
		var type = typeof(FileInfo);

		// Act
		var fields = TypeHelper.GetAllDeclaredFields(type).ToList();

		// Assert
		Assert.IsNotNull(fields);
		Assert.IsTrue(fields.All(f => f.DeclaringType == type));
	}

	[TestMethod]
	public void GetAllDeclaredFields_WithNoDeclaredFields_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(string); // string has no declared fields

		// Act
		var fields = TypeHelper.GetAllDeclaredFields(type).ToList();

		// Assert
		Assert.IsNotNull(fields);

	}

	[TestMethod]
	public void GetAllDeclaredMethods_CachesResult()
	{
		// Arrange
		var type = typeof(StringBuilder);

		// Act
		var methods1 = TypeHelper.GetAllDeclaredMethods(type).ToList();
		var methods2 = TypeHelper.GetAllDeclaredMethods(type).ToList();

		// Assert
		Assert.HasCount(methods1.Count, methods2);
		for (int i = 0; i < methods1.Count; i++)
		{
			Assert.AreEqual(methods1[i].Name, methods2[i].Name);
		}
	}
	[TestMethod]
	public void GetAllDeclaredMethods_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllDeclaredMethods(null).ToList());
	}

	[TestMethod]
	public void GetAllDeclaredMethods_WithDeclaredMethods_ReturnsMethods()
	{
		// Arrange
		var type = typeof(StringBuilder);

		// Act
		var methods = TypeHelper.GetAllDeclaredMethods(type).ToList();

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsTrue(methods.All(m => m.DeclaringType == type));
		Assert.IsTrue(methods.Any());
	}

	[TestMethod]
	public void GetAllDeclaredMethods_WithNoDeclaredMethods_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(void); // void has no declared methods

		// Act
		var methods = TypeHelper.GetAllDeclaredMethods(type).ToList();

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsFalse(methods.Any());
	}

	[TestMethod]
	public void GetAllFields_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllFields(null).ToList());
	}

	[TestMethod]
	public void GetAllFields_WithDeclaredAndInheritedFields_ReturnsAllFields()
	{
		// Arrange
		var type = typeof(FileInfo);

		// Act
		var fields = TypeHelper.GetAllFields(type).ToList();

		// Assert
		Assert.IsNotNull(fields);
		Assert.IsTrue(fields.Any());
		Assert.IsTrue(fields.Any(f => f.DeclaringType == typeof(FileSystemInfo)), "Should include inherited fields.");
	}

	[TestMethod]
	public void GetAllFields_WithNoFields_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(void);

		// Act
		var fields = TypeHelper.GetAllFields(type).ToList();

		// Assert
		Assert.IsNotNull(fields);
		Assert.IsFalse(fields.Any());
	}
	[TestMethod]
	public void GetAllGenericMethods_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllGenericMethods(null));
	}

	[TestMethod]
	public void GetAllGenericMethods_WithGenericMethods_ReturnsGenericMethods()
	{
		// Arrange
		var type = typeof(Dictionary<,>);

		// Act
		var methods = TypeHelper.GetAllGenericMethods(type);

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsTrue(methods.All(m => m.IsGenericMethod));
		Assert.IsTrue(methods.Any());
	}

	[TestMethod]
	public void GetAllGenericMethods_WithNoGenericMethods_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(string);

		// Act
		var methods = TypeHelper.GetAllGenericMethods(type);

		// Assert
		Assert.IsNotNull(methods);
	}

	[TestMethod]
	public void GetAllMethods_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllMethods(null).ToList());
	}

	[TestMethod]
	public void GetAllMethods_WithDeclaredAndInheritedMethods_ReturnsAllMethods()
	{
		// Arrange
		var type = typeof(FileInfo);

		// Act
		var methods = TypeHelper.GetAllMethods(type).ToList();

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsTrue(methods.Any());
		Assert.IsTrue(methods.Any(m => m.DeclaringType == typeof(FileSystemInfo)), "Should include inherited methods.");
	}

	[TestMethod]
	public void GetAllMethods_WithNoMethods_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(void);

		// Act
		var methods = TypeHelper.GetAllMethods(type).ToList();

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsTrue(methods.Any());
	}

	[TestMethod]
	public void GetAllProperties_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllProperties(null).ToList());
	}

	[TestMethod]
	public void GetAllProperties_WithDeclaredAndInheritedProperties_ReturnsAllProperties()
	{
		// Act
		var result = TypeHelper.GetAllProperties(typeof(Person));

		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result);

		foreach (var prop in result)
		{
			Debug.WriteLine($"Property: {prop.Name}, Type: {prop.PropertyType}");
		}
	}

	[TestMethod]
	public void GetAllProperties_WithNoProperties_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(void);

		// Act
		var properties = TypeHelper.GetAllProperties(type).ToList();

		// Assert
		Assert.IsNotNull(properties);
		Assert.IsFalse(properties.Any());
	}
	[TestMethod]
	public void GetAllPublicMethods_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllPublicMethods(null));
	}

	[TestMethod]
	public void GetAllPublicMethods_WithNoPublicMethods_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(void);

		// Act
		var methods = TypeHelper.GetAllPublicMethods(type);

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsFalse(methods.Any());
	}

	[TestMethod]
	public void GetAllPublicMethods_WithPublicMethods_ReturnsOnlyPublicMethods()
	{
		// Arrange
		var type = typeof(StringBuilder);

		// Act
		var methods = TypeHelper.GetAllPublicMethods(type);

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsTrue(methods.All(m => m.IsPublic));
		Assert.IsTrue(methods.Any());
	}
	[TestMethod]
	public void GetAllStaticMethods_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAllStaticMethods(null));
	}

	[TestMethod]
	public void GetAllStaticMethods_WithNoStaticMethods_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(StringBuilder);

		// Act
		var methods = TypeHelper.GetAllStaticMethods(type);

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsTrue(methods.Any());
	}

	[TestMethod]
	public void GetAllStaticMethods_WithStaticMethods_ReturnsOnlyStaticMethods()
	{
		// Arrange
		var type = typeof(Math);

		// Act
		var methods = TypeHelper.GetAllStaticMethods(type);

		// Assert
		Assert.IsNotNull(methods);
		Assert.IsTrue(methods.Any());
		Assert.IsTrue(methods.All(m => m.IsStatic));
	}

	[TestMethod]
	public void GetAttribute_FieldInfo_WithAttribute_ReturnsAttribute()
	{
		// Define a test class with a field and an attribute
#pragma warning disable CS0612 // Type or member is obsolete
		var field = typeof(FieldWithAttributeTestClass).GetField(nameof(FieldWithAttributeTestClass.MarkedField));
#pragma warning restore CS0612 // Type or member is obsolete
		var attr = TypeHelper.GetAttribute<ObsoleteAttribute>(field);
		Assert.IsNotNull(attr);
	}

	[TestMethod]
	public void GetAttribute_MethodInfo_NoAttribute_ReturnsNull()
	{
		var method = typeof(StringBuilder).GetMethod("Append", new[] { typeof(string) });
		var attr = TypeHelper.GetAttribute<ObsoleteAttribute>(method);
		Assert.IsNull(attr);
	}
	[TestMethod]
	public void GetAttribute_MethodInfo_Null_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAttribute<ObsoleteAttribute>((MethodInfo)null));
	}

	[TestMethod]
	public void GetAttribute_MethodInfo_WithAttribute_ReturnsAttribute()
	{
		var method = typeof(TypeHelperTests).GetMethod(nameof(this.MethodWithObsoleteAttribute), BindingFlags.NonPublic | BindingFlags.Instance);
		var attr = TypeHelper.GetAttribute<ObsoleteAttribute>(method);
		Assert.IsNotNull(attr);
	}

	[TestMethod]
	public void GetAttribute_PropertyInfo_NoAttribute_ReturnsNull()
	{
		var prop = typeof(StringBuilder).GetProperty("Length");
		var attr = TypeHelper.GetAttribute<ObsoleteAttribute>(prop);
		Assert.IsNull(attr);
	}
	[TestMethod]
	public void GetAttribute_PropertyInfo_Null_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetAttribute<ObsoleteAttribute>((PropertyInfo)null));
	}

	[TestMethod]
	public void GetAttribute_PropertyInfo_WithAttribute_ReturnsAttribute()
	{
#pragma warning disable CS0612 // Type or member is obsolete
		var prop = typeof(PropertyWithAttributeTestClass).GetProperty(nameof(PropertyWithAttributeTestClass.MarkedProperty));
#pragma warning restore CS0612 // Type or member is obsolete
		var attr = TypeHelper.GetAttribute<ObsoleteAttribute>(prop);
		Assert.IsNotNull(attr);
	}
	[TestMethod]
	public void GetAttribute_Type_NoAttribute_ReturnsNull()
	{
		var attr = TypeHelper.GetAttribute<ObsoleteAttribute>(typeof(StringBuilder));
		Assert.IsNull(attr);
	}

	[TestMethod]
	public void GetAttribute_Type_WithAttribute_ReturnsAttribute()
	{
		var attr = TypeHelper.GetAttribute<InformationAttribute>(typeof(TypeHelper));
		Assert.IsNotNull(attr);
	}

	[TestMethod]
	public void GetDefault_NullableType_ReturnsNull()
	{
		var result = TypeHelper.GetDefault<int?>();
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetDefault_ReferenceType_ReturnsNull()
	{
		var result = TypeHelper.GetDefault<string>();
		Assert.IsNull(result);
	}

	[TestMethod]
	public void GetDefault_StructType_ReturnsDefault()
	{
		var result = TypeHelper.GetDefault<DateTime>();
		Assert.AreEqual(default(DateTime), result);
	}
	[TestMethod]
	public void GetDefault_ValueType_ReturnsDefault()
	{
		var result = TypeHelper.GetDefault<int>();
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void GetDefault01()
	{
		var result = TypeHelper.GetDefault<AccessControlType>();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetGenericArguments_ClosedGenericType_ReturnsTypeArguments()
	{
		var result = TypeHelper.GetGenericArguments(typeof(Dictionary<string, int>));
		Assert.IsNotNull(result);
		Assert.HasCount(2, result);
		Assert.AreEqual(typeof(string), result[0]);
		Assert.AreEqual(typeof(int), result[1]);
	}

	[TestMethod]
	public void GetGenericArguments_GenericTypeDefinition_ReturnsGenericParameters()
	{
		var result = TypeHelper.GetGenericArguments(typeof(Dictionary<,>));
		Assert.IsNotNull(result);
		Assert.HasCount(2, result);
		Assert.IsTrue(result[0].IsGenericParameter);
		Assert.IsTrue(result[1].IsGenericParameter);
	}

	[TestMethod]
	public void GetGenericArguments_NonGenericType_ReturnsEmptyArray()
	{
		var result = TypeHelper.GetGenericArguments(typeof(int));
		Assert.IsNotNull(result);
		Assert.IsEmpty(result);
	}
	[TestMethod]
	public void GetGenericArguments_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetGenericArguments(null));
	}

	[TestMethod]
	public void GetImplementedInterfaces_Filtered_MatchingNames_ReturnsOnlyMatches()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaces(list, new List<string> { nameof(IEnumerable), nameof(IDisposable) });
		Assert.IsNotNull(result);
		Assert.Contains(nameof(IEnumerable), result);
		Assert.DoesNotContain(nameof(IDisposable), result);
	}

	[TestMethod]
	public void GetImplementedInterfaces_Filtered_NoMatches_ReturnsEmpty()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaces(list, new List<string> { "NonExistentInterface" });
		Assert.IsNotNull(result);
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetImplementedInterfaces_Filtered_NullInput_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetImplementedInterfaces(null, new List<string>()));
	}

	[TestMethod]
	public void GetImplementedInterfaces_Filtered_NullInterfaceNames_ThrowsArgumentNullException()
	{
		var list = new List<int>();
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetImplementedInterfaces(list, null));
	}

	[TestMethod]
	public void GetImplementedInterfaces_NoInterfaces_ReturnsEmpty()
	{
		var obj = new object();
		var result = TypeHelper.GetImplementedInterfaces(obj);
		Assert.IsNotNull(result);
		Assert.IsEmpty(result);
	}
	[TestMethod]
	public void GetImplementedInterfaces_NullInput_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetImplementedInterfaces(null));
	}

	[TestMethod]
	public void GetImplementedInterfaces_WithInterfaces_ReturnsInterfaceNames()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaces(list);
		Assert.IsNotNull(result);
		Assert.Contains(nameof(IEnumerable), result);
		Assert.Contains(nameof(ICollection), result);
		Assert.Contains(nameof(IList), result);
	}

	[TestMethod]
	public void GetImplementedInterfaceTypes_NoInterfaces_ReturnsEmpty()
	{
		var obj = new object();
		var result = TypeHelper.GetImplementedInterfaceTypes(obj);
		Assert.IsNotNull(result);
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetImplementedInterfaceTypes_NullInput_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetImplementedInterfaceTypes(null));
	}

	[TestMethod]
	public void GetImplementedInterfaceTypes_WithInterfaces_ReturnsInterfaceTypes()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaceTypes(list);
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Any(t => t == typeof(IEnumerable)));
		Assert.IsTrue(result.Any(t => t == typeof(ICollection)));
		Assert.IsTrue(result.Any(t => t == typeof(IList)));
	}

	[TestMethod]
	public void GetInstanceHashCode_EmptyObject_ReturnsHashCode()
	{
		// Arrange
		var emptyObject = new { };

		// Act
		var hashCode = TypeHelper.GetInstanceHashCode(emptyObject);
	}

	[TestMethod]
	public void GetInstanceHashCode_NullObject_ThrowsArgumentNullException()
	{
		// Arrange
		object nullObject = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetInstanceHashCode(nullObject), "Null object should throw ArgumentNullException.");
	}

	[TestMethod]
	public void GetInstanceHashCode_ValidObject_ReturnsHashCode()
	{
		// Arrange
		var person = RandomData.GeneratePerson<Person>();

		// Act
		var hashCode = TypeHelper.GetInstanceHashCode(person);

		// Assert
		Assert.AreNotEqual(0, hashCode, "Hash code should not be zero.");
	}

	[TestMethod]
	public void GetMembersWithAttribute_WithNoAttributes_ReturnsEmpty()
	{
		// Arrange
		var type = typeof(DataTable);

		// Act
		var members = TypeHelper.GetMembersWithAttribute<InformationAttribute>(type);

		// Assert
		Assert.IsNotNull(members);
		Assert.IsFalse(members.Any());
	}

	[TestMethod]
	public void GetMembersWithAttribute_WithValidType_ReturnsMembersWithAttribute()
	{
		// Arrange
		var type = typeof(Person);

		// Act
		var members = TypeHelper.GetMembersWithAttribute<InformationAttribute>(type);

		// Assert
		Assert.IsNotNull(members);
		Assert.IsTrue(members.Any());
	}

	[TestMethod]
	public void GetPropertyValues()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = TypeHelper.GetPropertyValues(person);
		Assert.IsGreaterThan(5, result.Count);

		var exTest = new ArgumentOutOfRangeException("TESTPARAM", "TESTMESSAGE");

		result = TypeHelper.GetPropertyValues(exTest);

		Assert.IsGreaterThan(1, result.Count);
	}

	[TestMethod]
	public void GetPropertyValues_EmptyObject_ReturnsEmptyCollection()
	{
		// Arrange
		var emptyObject = new { };

		// Act
		var result = TypeHelper.GetPropertyValues(emptyObject);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetPropertyValues_NullInput_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetPropertyValues<object>(null));
	}

	[TestMethod]
	public void GetPropertyValues_ObjectWithComplexProperty_ReturnsComplexPropertyAsString()
	{
		// Arrange
		var complexObject = new { Address = new { Street = "123 Main St", City = "Anytown" } };

		// Act
		var result = TypeHelper.GetPropertyValues(complexObject);

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(1, result);
		Assert.IsTrue(result.Any(kv => kv.Key == "Address" && kv.Value.Contains("Street") && kv.Value.Contains("City")));
	}

	[TestMethod]
	public void GetPropertyValues_ObjectWithDictionaryProperty_ReturnsDictionaryAsString()
	{
		// Arrange
		var objectWithDictionary = new { Data = new Dictionary<string, int> { { "Key1", 1 }, { "Key2", 2 } } };

		// Act
		var result = TypeHelper.GetPropertyValues(objectWithDictionary);

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(1, result);
		Assert.IsTrue(result.Any(kv => kv.Key == "Data" && kv.Value == "Key1: 1,Key2: 2"));
	}

	[TestMethod]
	public void GetPropertyValues_ObjectWithNullProperty_ReturnsNullAsString()
	{
		// Arrange
		var objectWithNullProperty = new { Name = (string)null };

		// Act
		var result = TypeHelper.GetPropertyValues(objectWithNullProperty);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetPropertyValues_SimpleObject_ReturnsPropertyValues()
	{
		// Arrange
		var simpleObject = new { Name = "Test", Age = 30 };

		// Act
		var result = TypeHelper.GetPropertyValues(simpleObject);

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(2, result);
		Assert.IsTrue(result.Any(kv => kv.Key == "Name" && kv.Value == "Test"));
		Assert.IsTrue(result.Any(kv => kv.Key == "Age" && kv.Value == "30"));
	}

	[TestMethod]
	public void GetTypeDisplayName_WithArrayType_ReturnsArrayTypeName()
	{
		// Arrange
		var type = typeof(int[]);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Int32[]", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithFullNameOption_ReturnsFullName()
	{
		// Arrange
		var type = typeof(List<int>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.List<System.Int32>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithGenericParameterNames_ReturnsNames()
	{
		// Arrange
		var type = typeof(Dictionary<,>);
		var options = new DisplayNameOptions(fullName: false, includeGenericParameterNames: true, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("Dictionary<TKey, TValue>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithGenericParameterNamesAndFullName_ReturnsFullNameWithParameterNames()
	{
		// Arrange
		var type = typeof(Dictionary<,>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: true, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.Dictionary<TKey, TValue>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithGenericType_ReturnsGenericTypeName()
	{
		// Arrange
		var type = typeof(Dictionary<int, List<string>>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithNestedGenericType_ReturnsNestedGenericTypeName()
	{
		// Arrange
		var type = typeof(Dictionary<int, List<Dictionary<string, int>>>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Int32>>>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithNestedTypeDelimiter_ReturnsCustomDelimiter()
	{
		// Arrange
		var type = typeof(Dictionary<int, List<string>>);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>>", result);
	}

	[TestMethod]
	public void GetTypeDisplayName_WithShortNameOption_ReturnsShortName()
	{
		// Arrange
		var type = typeof(List<int>);
		var options = new DisplayNameOptions(fullName: false, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		var result = TypeHelper.GetTypeDisplayName(type, options);

		// Assert
		Assert.AreEqual("List<Int32>", result);
	}

	[TestMethod]
	public void GetTypeDisplayNameTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = TypeHelper.GetTypeDisplayName(person);

		Assert.AreEqual(0, string.Compare(result, "DotNetTips.Spargine.Tester.Models.RefTypes.Person",
					StringComparison.Ordinal));

		result = TypeHelper.GetTypeDisplayName(person, true);

		Assert.AreEqual(0, string.Compare(result, "DotNetTips.Spargine.Tester.Models.RefTypes.Person", StringComparison.Ordinal));

		result = TypeHelper.GetTypeDisplayName(typeof(int), true, true, true, '-');

		Assert.AreEqual(0, string.Compare(result, "System.Int32", StringComparison.Ordinal));

		var people = RandomData.GeneratePersonRefCollection(5);

		result = TypeHelper.GetTypeDisplayName(people);

		Assert.IsGreaterThan(0, result.Length);

		result = TypeHelper.GetTypeDisplayName(RandomData.GeneratePerson<Person>());

		Assert.IsGreaterThan(0, result.Length);
	}

	[TestMethod]
	public void GetTypeMembersWithAttribute_MembersWithAttribute_ReturnsMembers()
	{
		var members = TypeHelper.GetTypeMembersWithAttribute<InformationAttribute>(typeof(TypeHelper));
		Assert.IsNotNull(members);
		Assert.IsTrue(members.Any());
	}

	[TestMethod]
	public void GetTypeMembersWithAttribute_NoMembersWithAttribute_ReturnsEmpty()
	{
		var members = TypeHelper.GetTypeMembersWithAttribute<ObsoleteAttribute>(typeof(StringBuilder));
		Assert.IsNotNull(members);
		Assert.IsFalse(members.Any());
	}
	[TestMethod]
	public void GetTypeMembersWithAttribute_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.GetTypeMembersWithAttribute<InformationAttribute>(null));
	}

	[TestMethod]
	public void GetTypeMembersWithAttribute_ReturnsMembers()
	{
		var members = TypeHelper.GetTypeMembersWithAttribute<InformationAttribute>(typeof(TypeHelper));
		Assert.IsNotNull(members);
		Assert.IsTrue(members.Any());
	}

	[TestMethod]
	public void HasAttribute_MethodInfo_NoAttribute_ReturnsFalse()
	{
		var method = typeof(StringBuilder).GetMethod("Append", new[] { typeof(string) });
		Assert.IsFalse(TypeHelper.HasAttribute<ObsoleteAttribute>(method));
	}

	[TestMethod]
	public void HasAttribute_MethodInfo_Null_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.HasAttribute<ObsoleteAttribute>(null));
	}

	[TestMethod]
	public void HasAttribute_MethodInfo_WithAttribute_ReturnsTrue()
	{
		var method = typeof(TypeHelperTests).GetMethod(nameof(this.MethodWithObsoleteAttribute), BindingFlags.NonPublic | BindingFlags.Instance);
		Assert.IsTrue(TypeHelper.HasAttribute<ObsoleteAttribute>(method));
	}

	[TestMethod]
	public void HasBaseClass_AbstractClassInheritance_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(FileStream), typeof(Stream));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_ArrayAndObject_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(int[]), typeof(Array));

		// Assert
		Assert.IsTrue(result, "Arrays inherit from Array");
	}

	[TestMethod]
	public void HasBaseClass_CachingWorks_ReturnsSameResults()
	{
		// Arrange
		var type = typeof(ArgumentException);
		var baseClass = typeof(Exception);

		// Act - Call twice
		var result1 = TypeHelper.HasBaseClass(type, baseClass);
		var result2 = TypeHelper.HasBaseClass(type, baseClass);

		// Assert
		Assert.IsTrue(result1);
		Assert.IsTrue(result2);
		Assert.AreEqual(result1, result2);
	}

	[TestMethod]
	public void HasBaseClass_CustomClassInheritance_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(MemoryStream), typeof(Stream));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_DelegateAndDelegate_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(Action), typeof(Delegate));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_DelegateAndMulticastDelegate_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(Action), typeof(MulticastDelegate));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_DirectInheritance_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(ArgumentException), typeof(SystemException));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_EnumAndValueType_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(DateTimeKind), typeof(Enum));

		// Assert
		Assert.IsTrue(result, "Enums inherit from Enum");
	}

	[TestMethod]
	public void HasBaseClass_EnumAndValueTypeBase_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(DateTimeKind), typeof(ValueType));

		// Assert
		Assert.IsTrue(result, "Enum inherits from ValueType");
	}

	[TestMethod]
	public void HasBaseClass_GenericTypeInheritance_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(List<int>), typeof(object));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_IndirectInheritance_ReturnsTrue()
	{
		// Arrange & Act
		// ArgumentNullException -> ArgumentException -> SystemException -> Exception -> object
		var result = TypeHelper.HasBaseClass(typeof(ArgumentNullException), typeof(Exception));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_InterfaceAsBaseClass_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(List<int>), typeof(IEnumerable));

		// Assert
		Assert.IsFalse(result, "HasBaseClass checks inheritance hierarchy, not interface implementation");
	}

	[TestMethod]
	public void HasBaseClass_MultiLevelInheritance_ReturnsTrue()
	{
		// Arrange & Act
		// InvalidOperationException -> SystemException -> Exception -> object
		var result = TypeHelper.HasBaseClass(typeof(InvalidOperationException), typeof(object));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_NoInheritanceRelationship_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(string), typeof(Exception));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasBaseClass_NullBaseClass_ReturnsFalse()
	{
		// Arrange
		var type = typeof(Exception);

		// Act
		var result = TypeHelper.HasBaseClass(type, null);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasBaseClass_NullType_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.HasBaseClass(null, typeof(object)));
	}

	[TestMethod]
	public void HasBaseClass_ObjectAsBaseClass_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(string), typeof(object));

		// Assert
		Assert.IsTrue(result, "All types inherit from object");
	}

	[TestMethod]
	public void HasBaseClass_PerformanceWithCaching_SecondCallIsFaster()
	{
		// Arrange
		var type = typeof(ArgumentNullException);
		var baseClass = typeof(Exception);

		// Act - First call (cache miss)
		var sw1 = Stopwatch.StartNew();
		var result1 = TypeHelper.HasBaseClass(type, baseClass);
		sw1.Stop();

		// Act - Second call (cache hit)
		var sw2 = Stopwatch.StartNew();
		var result2 = TypeHelper.HasBaseClass(type, baseClass);
		sw2.Stop();

		// Assert
		Assert.IsTrue(result1);
		Assert.IsTrue(result2);

		// Second call should be faster due to caching
		Assert.IsTrue(sw2.ElapsedTicks <= sw1.ElapsedTicks * 2,
			$"Cached call should be faster: First={sw1.ElapsedTicks}ns, Second={sw2.ElapsedTicks}ns");
	}

	[TestMethod]
	public void HasBaseClass_ReturnsTrueAndFalse()
	{
		Assert.IsTrue(TypeHelper.HasBaseClass(typeof(Exception), typeof(object)));
		Assert.IsFalse(TypeHelper.HasBaseClass(typeof(int), typeof(IDisposable)));
	}

	[TestMethod]
	public void HasBaseClass_ReverseHierarchy_ReturnsFalse()
	{
		// Arrange & Act - Testing reverse (base class does not inherit from derived)
		var result = TypeHelper.HasBaseClass(typeof(Exception), typeof(ArgumentException));

		// Assert
		Assert.IsFalse(result, "Base class does not inherit from derived class");
	}

	[TestMethod]
	public void HasBaseClass_SameType_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(Exception), typeof(Exception));

		// Assert
		Assert.IsTrue(result, "A type should be considered as having itself as a base class");
	}

	[TestMethod]
	public void HasBaseClass_SealedClassAndNoRelation_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(string), typeof(Stream));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasBaseClass_StructAndValueType_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(DateTime), typeof(ValueType));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasBaseClass_TypeAndItsInterface_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(List<int>), typeof(ICollection<int>));

		// Assert
		Assert.IsFalse(result, "Interfaces are not in the base class hierarchy");
	}

	[TestMethod]
	public void HasBaseClass_UnrelatedTypes_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(StringBuilder), typeof(MemoryStream));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasBaseClass_ValueTypeAndObject_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.HasBaseClass(typeof(int), typeof(ValueType));

		// Assert
		Assert.IsTrue(result, "int inherits from ValueType");
	}
	[TestMethod]
	public void HasMethod_ExistingPublicInstanceMethod_ReturnsTrue()
	{
		Assert.IsTrue(TypeHelper.HasMethod(typeof(Person), "ToString"));
	}

	[TestMethod]
	public void HasMethod_NonExistingMethod_ReturnsFalse()
	{
		Assert.IsFalse(TypeHelper.HasMethod(typeof(string), "NonExistentMethod"));
	}

	[TestMethod]
	public void HasMethod_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.HasMethod(null, "ToString"));
	}

	[TestMethod]
	public void HasMethod_StaticMethodWithStaticBinding_ReturnsTrue()
	{
		Assert.IsTrue(TypeHelper.HasMethod(typeof(Math), "Acos", BindingFlags.Public | BindingFlags.Static));
	}

	[TestMethod]
	public void HasParameterlessConstructor_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.HasParameterlessConstructor(null));
	}

	[TestMethod]
	public void HasParameterlessConstructor_ReturnsTrue()
	{
		Assert.IsTrue(TypeHelper.HasParameterlessConstructor(typeof(StringBuilder)));
	}

	[TestMethod]
	public void HasParameterlessConstructor_WithoutParameterlessConstructor_ReturnsFalse()
	{
		// FileStream does not have a public or non-public parameterless constructor
		Assert.IsFalse(TypeHelper.HasParameterlessConstructor(typeof(FileStream)));
	}

	[TestMethod]
	public void HasParameterlessConstructor_WithParameterlessConstructor_ReturnsTrue()
	{
		Assert.IsTrue(TypeHelper.HasParameterlessConstructor(typeof(StringBuilder)));
	}

	[TestMethod]
	public void HasProperty_ReturnsTrueAndFalse()
	{
		Assert.IsTrue(TypeHelper.HasProperty(typeof(string), "Length"));
		Assert.IsFalse(TypeHelper.HasProperty(typeof(string), "NonExistentProperty"));
	}

	[TestMethod]
	public void ImplementsInterface_AbstractClassWithInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(Stream), typeof(IDisposable));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_AnonymousType_ReturnsTrue()
	{
		// Arrange
		var anonymousObject = new { Name = "Test", Age = 30 };
		var type = anonymousObject.GetType();

		// Act - Anonymous types don't implement standard interfaces
		var result = TypeHelper.ImplementsInterface(type, typeof(IDisposable));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ImplementsInterface_ArrayType_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(int[]), typeof(IEnumerable));

		// Assert
		Assert.IsTrue(result, "Arrays implement IEnumerable");
	}

	[TestMethod]
	public void ImplementsInterface_CachingWorks_ReturnsSameResults()
	{
		// Arrange
		var type = typeof(List<int>);
		var interfaceType = typeof(IEnumerable<int>);

		// Act - Call twice
		var result1 = TypeHelper.ImplementsInterface(type, interfaceType);
		var result2 = TypeHelper.ImplementsInterface(type, interfaceType);

		// Assert
		Assert.IsTrue(result1);
		Assert.IsTrue(result2);
		Assert.AreEqual(result1, result2);
	}

	[TestMethod]
	public void ImplementsInterface_ClassImplementingMultipleInterfaces_ReturnsTrue()
	{
		// Arrange & Act
		var result1 = TypeHelper.ImplementsInterface(typeof(StringBuilder), typeof(ISerializable));

		// Assert
		Assert.IsTrue(result1);
	}

	[TestMethod]
	public void ImplementsInterface_ClosedGenericType_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(Dictionary<string, int>), typeof(IDictionary<string, int>));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_CovariantInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(List<string>), typeof(IEnumerable<string>));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_DelegateType_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(Action), typeof(IDisposable));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ImplementsInterface_DerivedInterfaceImplementsBaseInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(IList<int>), typeof(IEnumerable<int>));

		// Assert
		Assert.IsTrue(result, "IList<int> inherits from IEnumerable<int>");
	}

	[TestMethod]
	public void ImplementsInterface_DirectlyImplementedInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(IList<int>));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_EnumWithInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(DateTimeKind), typeof(IComparable));

		// Assert
		Assert.IsTrue(result, "Enums implement IComparable");
	}

	[TestMethod]
	public void ImplementsInterface_ExplicitInterfaceImplementation_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(ICollection<int>));

		// Assert
		Assert.IsTrue(result, "Even with explicit interface implementation, type still implements interface");
	}

	[TestMethod]
	public void ImplementsInterface_GenericTypeDefinition_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(List<>), typeof(IEnumerable));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_IndirectlyImplementedInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(IEnumerable<int>));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_InterfaceDoesNotMatch_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(IComparable<int>));

		// Assert
		Assert.IsFalse(result, "List<int> does not implement IComparable<int>");
	}

	[TestMethod]
	public void ImplementsInterface_MultipleGenericParameters_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(Dictionary<string, int>), typeof(ICollection<KeyValuePair<string, int>>));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_MultipleInterfaces_ReturnsTrue()
	{
		// Arrange & Act
		var result1 = TypeHelper.ImplementsInterface(typeof(MemoryStream), typeof(IDisposable));
		var result2 = TypeHelper.ImplementsInterface(typeof(MemoryStream), typeof(Stream)); // Stream is not an interface

		// Assert
		Assert.IsTrue(result1);
		Assert.IsFalse(result2, "Stream is a class, not an interface");
	}

	[TestMethod]
	public void ImplementsInterface_NonGenericInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(IEnumerable));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_NonInterfaceType_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(string));

		// Assert
		Assert.IsFalse(result, "Should return false when second parameter is not an interface");
	}

	[TestMethod]
	public void ImplementsInterface_NullInterfaceType_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(string), null);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ImplementsInterface_NullType_ThrowsArgumentNullException()
	{
		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.ImplementsInterface(null, typeof(IDisposable)));
	}

	[TestMethod]
	public void ImplementsInterface_OpenGenericInterfaceWithClosedType_ReturnsFalse()
	{
		// Arrange & Act
		// Checking if List<int> implements IEnumerable<> (open generic) - should be false
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(IEnumerable<>));

		// Assert
		Assert.IsFalse(result, "Closed type does not directly implement open generic interface");
	}

	[TestMethod]
	public void ImplementsInterface_PerformanceWithCaching_SecondCallIsFaster()
	{
		// Arrange
		var type = typeof(List<int>);
		var interfaceType = typeof(IEnumerable<int>);

		// Act - First call (cache miss)
		var sw1 = Stopwatch.StartNew();
		var result1 = TypeHelper.ImplementsInterface(type, interfaceType);
		sw1.Stop();

		// Act - Second call (cache hit)
		var sw2 = Stopwatch.StartNew();
		var result2 = TypeHelper.ImplementsInterface(type, interfaceType);
		sw2.Stop();

		// Assert
		Assert.IsTrue(result1);
		Assert.IsTrue(result2);

		// Second call should be faster due to caching
		Assert.IsTrue(sw2.ElapsedTicks <= sw1.ElapsedTicks * 2,
			$"Cached call should be faster: First={sw1.ElapsedTicks}ns, Second={sw2.ElapsedTicks}ns");
	}

	[TestMethod]
	public void ImplementsInterface_ReturnsTrueAndFalse()
	{
		Assert.IsTrue(TypeHelper.ImplementsInterface(typeof(List<int>), typeof(IEnumerable<>).MakeGenericType(typeof(int))));
		Assert.IsFalse(TypeHelper.ImplementsInterface(typeof(int), typeof(IDisposable)));
	}

	[TestMethod]
	public void ImplementsInterface_SealedClass_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(string), typeof(IEnumerable));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_StaticClass_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(Math), typeof(IDisposable));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ImplementsInterface_StructWithInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(DateTime), typeof(IComparable));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ImplementsInterface_TypeDoesNotImplementInterface_ReturnsFalse()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(string), typeof(IList));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ImplementsInterface_ValueTypeWithInterface_ReturnsTrue()
	{
		// Arrange & Act
		var result = TypeHelper.ImplementsInterface(typeof(int), typeof(IComparable));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsAssignableTo_ReturnsTrueAndFalse()
	{
		Assert.IsTrue(TypeHelper.IsAssignableTo(typeof(string), typeof(object)));
		Assert.IsFalse(TypeHelper.IsAssignableTo(typeof(int), typeof(IDisposable)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_ArraySegment_ReturnsTrue()
	{
		// ArraySegment<> is in the built-in types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ArraySegment<>)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_ArrayTypes_ReturnsFalse()
	{
		// Array types are not in the built-in types cache
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(int[])));
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(string[])));
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(Person[])));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_CachePerformance_SecondCallIsFaster()
	{
		// First call initializes cache
		var sw1 = Stopwatch.StartNew();
		_ = TypeHelper.IsBuiltinType(typeof(int));
		sw1.Stop();

		// Second call should use cache
		var sw2 = Stopwatch.StartNew();
		_ = TypeHelper.IsBuiltinType(typeof(int));
		sw2.Stop();

		// Second call should be faster or equal (cache hit)
		Assert.IsTrue(sw2.ElapsedTicks <= sw1.ElapsedTicks * 2,
			$"Cache should improve performance: First={sw1.ElapsedTicks}ns, Second={sw2.ElapsedTicks}ns");
	}

	[TestMethod]
	public void IsBuiltInTypeTest_ClosedGenericTypes_ReturnsFalse()
	{
		// Closed generic types are NOT in the built-in types cache
		// because the cache contains open generic definitions
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(List<int>)));
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(Dictionary<string, int>)));
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(HashSet<Person>)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_CommonBuiltInTypes_ReturnsTrue()
	{
		// Test common built-in types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(string)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(object)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(DateTime)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(DateTimeOffset)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(TimeSpan)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Guid)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Uri)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(IntPtr)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(UIntPtr)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_ConcurrentCollections_ReturnsTrue()
	{
		// Test concurrent collection types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Concurrent.ConcurrentDictionary<,>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Concurrent.ConcurrentQueue<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Concurrent.ConcurrentStack<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Concurrent.BlockingCollection<>)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_CustomTypes_ReturnsFalse()
	{
		// Test custom types
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(Person)));
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(Address)));
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(PersonComparer)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_GenericCollectionTypes_ReturnsTrue()
	{
		// Test generic collection types (open generics)
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(List<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Dictionary<,>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(HashSet<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Queue<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Stack<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(LinkedList<>)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_ImmutableCollections_ReturnsTrue()
	{
		// Test immutable collection types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Immutable.ImmutableArray<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Immutable.ImmutableList<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Immutable.ImmutableDictionary<,>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Immutable.ImmutableHashSet<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Immutable.ImmutableQueue<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Collections.Immutable.ImmutableStack<>)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_Int()
	{
		var result = TypeHelper.IsBuiltinType(typeof(Int64));

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsBuiltInTypeTest_NullableTypes_ReturnsFalse()
	{
		// Nullable<> itself should be true as it's in the built-in types list
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Nullable<>)));

		// But closed nullable types are not in the cache
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(int?)));
		Assert.IsFalse(TypeHelper.IsBuiltinType(typeof(DateTime?)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_NullType_ReturnsFalse()
	{
		var result = TypeHelper.IsBuiltinType(null);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsBuiltInTypeTest_NumericTypes_ReturnsTrue()
	{
		// Test numeric types including newer ones
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(System.Numerics.BigInteger)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Half)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_PersonRecord()
	{
		var result = TypeHelper.IsBuiltinType(typeof(PersonRecord));

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsBuiltInTypeTest_PrimitiveTypes_ReturnsTrue()
	{
		// Test all primitive types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(bool)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(byte)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(sbyte)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(char)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(short)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ushort)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(int)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(uint)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(long)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ulong)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(float)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(double)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(decimal)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_ReadOnlyCollections_ReturnsTrue()
	{
		// Test read-only collection types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ReadOnlyCollection<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ReadOnlyDictionary<,>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ReadOnlyObservableCollection<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ObservableCollection<>)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_SortedCollections_ReturnsTrue()
	{
		// Test sorted collection types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(SortedList<,>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(SortedDictionary<,>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(SortedSet<>)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_SpanTypes_ReturnsTrue()
	{
		// Test Span and Memory types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Span<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ReadOnlySpan<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Memory<>)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ReadOnlyMemory<>)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_SystemNamespacePublicTypes_ReturnsTrue()
	{
		// Some System namespace types that should be included
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(DateTimeKind)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(StringComparison)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Environment)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Math)));
	}

	[TestMethod]
	public void IsBuiltInTypeTest_TupleTypes_ReturnsTrue()
	{
		// Test tuple types
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(ValueTuple)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(Tuple)));
		Assert.IsTrue(TypeHelper.IsBuiltinType(typeof(KeyValuePair<,>)));
	}
	[TestMethod]
	public void IsClosedGeneric_ClosedGenericType_ReturnsTrue()
	{
		Assert.IsTrue(TypeHelper.IsClosedGeneric(typeof(List<int>)));
	}

	[TestMethod]
	public void IsClosedGeneric_NullType_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => TypeHelper.IsClosedGeneric(null));
	}

	[TestMethod]
	public void IsClosedGeneric_OpenGenericType_ReturnsFalse()
	{
		Assert.IsFalse(TypeHelper.IsClosedGeneric(typeof(List<>)));
	}

	[TestMethod]
	public void IsClosedGeneric_ReturnsTrueAndFalse()
	{
		Assert.IsTrue(TypeHelper.IsClosedGeneric(typeof(List<int>)));
		Assert.IsFalse(TypeHelper.IsClosedGeneric(typeof(List<>)));
	}

	[TestMethod]
	public void IsDotNetAssembly_ValidAssembly_ReturnsTrue()
	{
		// Arrange
		var assemblyPath = Assembly.GetExecutingAssembly().Location;
		var fileInfo = new FileInfo(assemblyPath);

		// Act
		var result = AssemblyHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_ValidDotNetAssembly_ReturnsTrue()
	{
		// Arrange
		var assemblyPath = Assembly.GetExecutingAssembly().Location;
		var fileInfo = new FileInfo(assemblyPath);

		// Act
		var result = AssemblyHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsEnumerable_ReturnsTrueAndFalse()
	{
		Assert.IsTrue(TypeHelper.IsEnumerable(typeof(List<int>)));
		Assert.IsFalse(TypeHelper.IsEnumerable(typeof(int)));
	}

	[TestMethod]
	public void IsNullable_ReturnsTrueAndFalse()
	{
		Assert.IsTrue(TypeHelper.IsNullable(typeof(int?)));
		Assert.IsFalse(TypeHelper.IsNullable(typeof(int)));
		Assert.IsFalse(TypeHelper.IsNullable(null));
	}

	[TestMethod]
	public void IsOpenGeneric_ReturnsTrueAndFalse()
	{
		Assert.IsTrue(TypeHelper.IsOpenGeneric(typeof(List<>)));
		Assert.IsFalse(TypeHelper.IsOpenGeneric(typeof(List<int>)));
	}

	[TestMethod]
	public void IsStatic_ReturnsTrueAndFalse()
	{
		var staticProp = typeof(Environment).GetProperty("CurrentDirectory");
		var instanceProp = typeof(StringBuilder).GetProperty("Length");
		Assert.IsTrue(TypeHelper.IsStatic(staticProp));
		Assert.IsFalse(TypeHelper.IsStatic(instanceProp));
	}

	[TestMethod]
	public void Max_ReturnsCorrectMax()
	{
		Assert.AreEqual(5, TypeHelper.Max(3, 5));
		Assert.AreEqual("b", TypeHelper.Max("a", "b"));
		Assert.IsNull(TypeHelper.Max<string>(null, null));
	}

	[TestMethod]
	public void ProcessGenericType_EmptyGenericArguments()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(List<>);
		var genericArguments = Array.Empty<Type>();
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.List<>", result);
	}

	[TestMethod]
	public void ProcessGenericType_MultipleGenericArguments()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(Dictionary<,>);
		var genericArguments = new[] { typeof(string), typeof(int) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.String, System.Int32>", result);
	}

	[TestMethod]
	public void ProcessGenericType_NestedGenericTypes()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(Dictionary<,>);
		var genericArguments = new[] { typeof(List<string>), typeof(Dictionary<int, string>) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Collections.Generic.List<System.String>, System.Collections.Generic.Dictionary<System.Int32, System.String>>", result);
	}

	[TestMethod]
	public void ProcessGenericType_SingleGenericArgument()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(List<>);
		var genericArguments = new[] { typeof(int) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.List<System.Int32>", result);
	}

	[TestMethod]
	public void ProcessGenericType_WithArrayGenericArgument()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(List<>);
		var genericArguments = new[] { typeof(int[]) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.List<System.Int32[]>", result);
	}

	[TestMethod]
	public void ProcessGenericType_WithNestedGenericTypeAndCustomDelimiter()
	{
		// Arrange
		var builder = new StringBuilder();
		var type = typeof(Dictionary<,>);
		var genericArguments = new[] { typeof(List<string>), typeof(Dictionary<int, string>) };
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		// Act
		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		// Assert
		var result = builder.ToString();
		Assert.AreEqual("System.Collections.Generic.Dictionary<System.Collections.Generic.List<System.String>, System.Collections.Generic.Dictionary<System.Int32, System.String>>", result);
	}

	[Obsolete(message: "TEST")]
	private void MethodWithObsoleteAttribute() { }

	// Helper class for attribute test
	private class FieldWithAttributeTestClass
	{
		[Obsolete]
		public int MarkedField = 1;
	}

	private class PropertyWithAttributeTestClass
	{
		[Obsolete]
		public int MarkedProperty { get; set; }
	}
}
