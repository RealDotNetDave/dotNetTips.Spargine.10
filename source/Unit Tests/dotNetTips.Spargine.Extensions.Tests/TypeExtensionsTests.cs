// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2025
// ***********************************************************************
// <copyright file="TypeExtensionsTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
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

	/// <summary>
	/// Defines the attribute method GetAbstractMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetAbstractMethodsTest()
	{
		var result = typeof(AbstractTestType).GetAllAbstractMethods();

		Assert.IsTrue(result.Count == 1);

		result = typeof(DataTable).GetAllAbstractMethods();

		Assert.IsTrue(result.Count == 0);
	}

	[TestMethod]
	public void GetAllDeclaredFieldsTest()
	{
		var result = typeof(Person).GetAllDeclaredFields();

		Assert.IsTrue(result.Count() > 0);
	}

	[TestMethod]
	public void GetAllDeclaredMethodsTest()
	{
		var result = typeof(Person).GetAllDeclaredMethods();

		Assert.IsTrue(result.Count() > 0);
	}

	/// <summary>
	/// Defines the attribute method GetAllFieldsTest.
	/// </summary>
	[TestMethod]
	public void GetAllFieldsTest()
	{
		var result1 = typeof(TestType).GetAllFields();

		Assert.IsTrue(result1.Count() == 1);

		var result2 = typeof(Person).GetAllFields();

		Assert.IsTrue(result2.Count() >= 8);
	}

	/// <summary>
	/// Defines the attribute method GetAllMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetAllMethodsTest()
	{
		var result = typeof(TestType).GetAllMethods();

		Assert.IsTrue(result.Count() == 13);

		result = typeof(Person).GetAllMethods();

		Assert.IsTrue(result.Count() >= 40);
	}

	/// <summary>
	/// Defines the attribute method GetAttributeFieldTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeFieldTest()
	{
		Assert.IsNotNull(typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<DebuggerBrowsableAttribute>());

		Assert.IsNull(typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<XmlIgnoreAttribute>());
	}

	/// <summary>
	/// Defines the attribute method GetAttributeMethodTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeMethodTest()
	{
		var method = typeof(TestType).GetAllMethods().FirstOrDefault(p => string.Compare(p.Name, "get_UserName", StringComparison.Ordinal) == 0);

		var result1 = method.GetAttribute<CompilerGeneratedAttribute>();

		Assert.IsNotNull(result1);

		var result2 = method.GetAttribute<XmlIgnoreAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the attribute method GetAttributePropertyTest.
	/// </summary>
	[TestMethod]
	public void GetAttributePropertyTest()
	{
		var property = typeof(TestType).GetAllProperties().FirstOrDefault();

		var result1 = property.GetAttribute<DebuggerBrowsableAttribute>();

		Assert.IsNotNull(result1);

		var result2 = property.GetAttribute<XmlAnyAttributeAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the attribute method GetAttributeTypeTest.
	/// </summary>
	[TestMethod]
	public void GetAttributeTypeTest()
	{
		var result1 = typeof(TestType).GetAttribute<XmlRootAttribute>();

		Assert.IsNotNull(result1);

		var result2 = typeof(TestType).GetAttribute<XmlIgnoreAttribute>();

		Assert.IsNull(result2);
	}

	/// <summary>
	/// Defines the attribute method GetGenericMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetGenericMethodsTest()
	{
		var result = typeof(TestType).GetAllGenericMethods();

		Assert.IsTrue(result.Count == 1);
	}

	[TestMethod]
	public void GetImplementedInterfacesTest()
	{
		var table = new DataTable();

		var result = table.GetImplementedInterfaces("IComponent");

		Assert.IsTrue(result.Count == 1);

		result = table.GetImplementedInterfaces("IFakeInterface");

		Assert.IsTrue(result.Count == 0);

		result = table.GetImplementedInterfaces("IComponent", "IDisposable");

		Assert.IsTrue(result.Count == 2);

	}

	/// <summary>
	/// Defines the attribute method GetPropertiesTest.
	/// </summary>
	[TestMethod]
	public void GetPropertiesTest()
	{
		var result = typeof(Person).GetAllProperties();

		Assert.IsTrue(result.Count() >= 8);
	}

	/// <summary>
	/// Defines the attribute method GetPublicMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetPublicMethodsTest()
	{
		var result = typeof(Person).GetAllPublicMethods();

		Assert.IsTrue(result.Count >= 30);
	}

	/// <summary>
	/// Defines the attribute method GetStaticMethodsTest.
	/// </summary>
	[TestMethod]
	public void GetStaticMethodsTest()
	{
		var result = typeof(TestType).GetAllStaticMethods();

		Assert.IsTrue(result.Count == 1);
	}

	/// <summary>
	/// Defines the attribute method GetTypeMembersWithGivenAttributeTest.
	/// </summary>
	[TestMethod]
	public void GetTypeMembersWithGivenAttributeTest()
	{
		var members = typeof(LoggingHelper).GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
		var memAttrib = members.Where(member => member.GetCustomAttribute<InformationAttribute>() != null);


		var result1 = typeof(LoggingHelper).GetTypeMembersWithAttribute<InformationAttribute>();

		Assert.IsTrue(result1.Count > 0);

		var result2 = typeof(TestType).GetTypeMembersWithAttribute<XmlAnyAttributeAttribute>();

		Assert.IsTrue(result2.Count == 0);
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
	public void HasParameterlessConstructorTest()
	{
		var result = typeof(Person).HasParameterlessConstructor();

		Assert.IsTrue(result);
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

	/// <summary>
	/// Defines the attribute method IsNumericTest.
	/// </summary>
	[TestMethod]
	public void IsNumericTest()
	{
		var people = RandomData.GeneratePersonRefCollection(10).AsEnumerable();
		var person = RandomData.GeneratePerson<Person>();

		Assert.IsTrue(people.GetType().IsEnumerable());
		Assert.IsFalse(person.GetType().IsEnumerable());
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
