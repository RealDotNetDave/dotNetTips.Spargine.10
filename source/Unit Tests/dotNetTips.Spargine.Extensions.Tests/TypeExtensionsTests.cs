// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="TypeExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Cache;
using DotNetTips.Spargine.Core.Logging;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class TypeExtensionsTests
{

	[TestMethod]
	public void GetAbstractMethodsTest()
	{
		var result = typeof(AbstractTestType).GetAllAbstractMethods();

		Assert.AreEqual(1, result.Count);

		result = typeof(DataTable).GetAllAbstractMethods();

		Assert.IsEmpty(result);
	}

	[TestMethod]
	public void GetAllConstructorsTest()
	{
		var result = typeof(Person).GetAllConstructors();

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Any());
	}

	[TestMethod]
	public void GetAllDeclaredFieldsTest()
	{
		var result = typeof(Person).GetAllDeclaredFields();

		Assert.IsGreaterThan(0, result.Count());
	}

	[TestMethod]
	public void GetAllDeclaredMethodsTest()
	{
		var result = typeof(Person).GetAllDeclaredMethods();

		Assert.IsGreaterThan(0, result.Count());
	}

	[TestMethod]
	public void GetAllFieldsTest()
	{
		var result1 = typeof(TestType).GetAllFields();

		Assert.AreEqual(1, result1.Count());

		var result2 = typeof(Person).GetAllFields();

		Assert.IsGreaterThanOrEqualTo(8, result2.Count());
	}

	[TestMethod]
	public void GetAllMethodsTest()
	{
		var result = typeof(TestType).GetAllMethods();

		Assert.AreEqual(13, result.Count());

		result = typeof(Person).GetAllMethods();

		Assert.IsGreaterThanOrEqualTo(40, result.Count());
	}

	[TestMethod]
	public void GetAllPropertiesTest()
	{
		var result = typeof(Person).GetAllProperties();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result);

		foreach (var prop in result)
		{
			Debug.WriteLine($"Property: {prop.Name}, Type: {prop.PropertyType}");
		}
	}

	[TestMethod]
	public void GetAttributeFieldTest()
	{
		Assert.IsNotNull(typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<DebuggerBrowsableAttribute>());

		Assert.IsNull(typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<XmlIgnoreAttribute>());
	}

	[TestMethod]
	public void GetAttributeMethodTest()
	{
		var method = typeof(TestType).GetAllMethods().FirstOrDefault(p => string.Compare(p.Name, "get_UserName", StringComparison.Ordinal) == 0);

		var result1 = method.GetAttribute<CompilerGeneratedAttribute>();

		Assert.IsNotNull(result1);

		var result2 = method.GetAttribute<XmlIgnoreAttribute>();

		Assert.IsNull(result2);
	}

	[TestMethod]
	public void GetAttributePropertyTest()
	{
		var property = typeof(TestType).GetAllProperties().FirstOrDefault();

		var result1 = property.GetAttribute<DebuggerBrowsableAttribute>();

		Assert.IsNotNull(result1);

		var result2 = property.GetAttribute<XmlAnyAttributeAttribute>();

		Assert.IsNull(result2);
	}

	[TestMethod]
	public void GetAttributeTypeTest()
	{
		var result1 = typeof(TestType).GetAttribute<XmlRootAttribute>();

		Assert.IsNotNull(result1);

		var result2 = typeof(TestType).GetAttribute<XmlIgnoreAttribute>();

		Assert.IsNull(result2);
	}

	[TestMethod]
	public void GetGenericArgumentsTest()
	{
		var result1 = typeof(List<string>).GetGenericArguments();

		Assert.IsNotNull(result1);
		Assert.AreEqual(1, result1.Length);
		Assert.AreEqual(typeof(string), result1[0]);

		var result2 = typeof(string).GetGenericArguments();

		Assert.IsNotNull(result2);
		Assert.AreEqual(0, result2.Length);
	}

	[TestMethod]
	public void GetGenericMethodsTest()
	{
		var result = typeof(TestType).GetAllGenericMethods();

		Assert.AreEqual(1, result.Count);
	}

	[TestMethod]
	public void GetImplementedInterfacesTest()
	{
		var table = new DataTable();

		var result = table.GetImplementedInterfaces("IComponent");

		Assert.AreEqual(1, result.Count);

		result = table.GetImplementedInterfaces("IFakeInterface");

		Assert.IsEmpty(result);

		result = table.GetImplementedInterfaces("IComponent", "IDisposable");

		Assert.AreEqual(2, result.Count);

	}

	[TestMethod]
	public void GetPublicMethodsTest()
	{
		var result = typeof(Person).GetAllPublicMethods();

		Assert.IsGreaterThanOrEqualTo(30, result.Count);
	}

	[TestMethod]
	public void GetStaticMethodsTest()
	{
		var result = typeof(TestType).GetAllStaticMethods();

		Assert.AreEqual(1, result.Count);
	}

	[TestMethod]
	public void GetTypeMembersWithGivenAttributeTest()
	{
		var members = typeof(LoggingHelper).GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
		var memAttrib = members.Where(member => member.GetCustomAttribute<InformationAttribute>() != null);


		var result1 = typeof(LoggingHelper).GetTypeMembersWithAttribute<InformationAttribute>();

		Assert.IsNotEmpty(result1);

		var result2 = typeof(TestType).GetTypeMembersWithAttribute<XmlAnyAttributeAttribute>();

		Assert.IsEmpty(result2);
	}

	[TestMethod]
	public void HasAttributeTest()
	{
		var method = typeof(TestType).GetAllMethods().FirstOrDefault(p => string.Compare(p.Name, "get_UserName", StringComparison.Ordinal) == 0);

		var result1 = method.HasAttribute<CompilerGeneratedAttribute>();

		Assert.IsTrue(result1);

		var result2 = method.HasAttribute<XmlIgnoreAttribute>();

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void HasBaseClassTest()
	{
		var result1 = typeof(DataTable).HasBaseClass(typeof(MarshalByValueComponent));

		Assert.IsTrue(result1);

		var result2 = typeof(DataTable).HasBaseClass(typeof(ValueType));

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void HasMethodTest()
	{
		var result1 = typeof(TestType).HasMethod("Invoke");

		Assert.IsTrue(result1);

		var result2 = typeof(TestType).HasMethod("NonExistentMethod");

		Assert.IsFalse(result2);

		var result3 = typeof(TestType).HasMethod("GetName", BindingFlags.Public | BindingFlags.Static);

		Assert.IsTrue(result3);
	}

	[TestMethod]
	public void HasParameterlessConstructorTest()
	{
		var result1 = typeof(Person).HasParameterlessConstructor();

		Assert.IsTrue(result1);

		var result2 = typeof(Uri).HasParameterlessConstructor();

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void HasPropertyTest()
	{
		var result1 = typeof(TestType).HasProperty("UserName");

		Assert.IsTrue(result1);

		var result2 = typeof(TestType).HasProperty("NonExistentProperty");

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void ImplementsInterfaceTest()
	{
		var result1 = typeof(List<string>).ImplementsInterface(typeof(IEnumerable));

		Assert.IsTrue(result1);

		var result2 = typeof(TestType).ImplementsInterface(typeof(IDisposable));

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void IsAssignableToTest()
	{
		var result1 = typeof(string).IsAssignableTo(typeof(object));

		Assert.IsTrue(result1);

		var result2 = typeof(object).IsAssignableTo(typeof(string));

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void IsClosedGenericTest()
	{
		var result1 = typeof(List<string>).IsClosedGeneric();

		Assert.IsTrue(result1);

		var result2 = typeof(string).IsClosedGeneric();

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void IsEnumerableTest()
	{
		var result1 = typeof(BitArray).IsEnumerable();

		Assert.IsTrue(result1);

		var result2 = typeof(DataTable).IsEnumerable();

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void IsNullableTest()
	{
		var result1 = typeof(Foo).GetProperty("Bar").PropertyType.IsNullable();

		Assert.IsTrue(result1);

		var result2 = typeof(Person).GetProperty("FirstName").PropertyType.IsNullable();

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void IsNumericTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).AsEnumerable();
		var person = RandomData.GeneratePerson<Person>();

		Assert.IsTrue(people.GetType().IsEnumerable());
		Assert.IsFalse(person.GetType().IsEnumerable());
	}

	[TestMethod]
	public void IsOpenGenericTest()
	{
		var result1 = typeof(List<>).IsOpenGeneric();

		Assert.IsTrue(result1);

		var result2 = typeof(List<string>).IsOpenGeneric();

		Assert.IsFalse(result2);
	}

	[TestMethod]
	public void IsStaticTest()
	{
		var result1 = typeof(InMemoryCache).GetProperty("Instance").IsStatic();
		Assert.IsTrue(result1);

		var result2 = typeof(Person).GetProperty("FirstName").IsStatic();
		Assert.IsFalse(result2);
	}

}
