// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-23-2025
// ***********************************************************************
// <copyright file="TypeHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// TypeHelper PerfTestRunner.
/// Implements the <see cref="Benchmarking.PerfTestRunner" />
/// </summary>
/// <seealso cref="Benchmarking.PerfTestRunner" />
public class TypeHelperBenchmark : Benchmark
{

	private readonly int _collectionCount = 50;
	private List<Person> _people;

	[Obsolete(message: "TEST")]
	private void MethodWithObsoleteAttribute() { }

	[Benchmark(Description = nameof(TypeHelper.BuiltInTypes))]
	[BenchmarkCategory(Categories.Reflection)]
	public void BuiltInTypes()
	{
		var result = TypeHelper.BuiltInTypes;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.Create))]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateNormal()
	{
		var result = TypeHelper.Create<Person>();

		this.Consume(result);
	}

	[Benchmark(Description = "Looping Collection: Normal StringBuilder")]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateStringBuilder()
	{
		var sb = new StringBuilder();

		foreach (var person in this._people)
		{
			_ = sb.AppendFormat(CultureInfo.InvariantCulture, "{0}={1}", person.Email, person.Id);
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(TypeHelper.Create) + ": With Parameters")]
	[BenchmarkCategory(Categories.Strings)]
	public void CreateWithParameters()
	{
		var result = TypeHelper.Create<Person>("TESTID", "DOTNETDAVE@LIVE.COM");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.DoesObjectEqualInstance))]
	[BenchmarkCategory(Categories.Strings)]
	public void DoesObjectEqualInstance()
	{
		var result = TypeHelper.DoesObjectEqualInstance(this.PersonRef01, this.PersonRef02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.FindDerivedTypes))]
	[BenchmarkCategory(Categories.Reflection)]
	public void FindDerivedTypes()
	{
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(MulticastDelegate), true);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllAbstractMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllAbstractMethods()
	{
		var result = TypeHelper.GetAllAbstractMethods(typeof(Benchmark));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllConstructors))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllConstructors()
	{
		var result = TypeHelper.GetAllConstructors(typeof(Benchmark));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllDeclaredFields))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllDeclaredFields()
	{
		var result = TypeHelper.GetAllDeclaredFields(typeof(Benchmark));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllDeclaredMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllDeclaredMethods()
	{
		var result = TypeHelper.GetAllDeclaredMethods(typeof(Benchmark));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllFields))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllFields()
	{
		var result = TypeHelper.GetAllFields(typeof(Benchmark));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetGenericArguments))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetGenericArguments()
	{
		var result = TypeHelper.GetGenericArguments(typeof(Dictionary<string, int>));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetImplementedInterfaces))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetImplementedInterfaces()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaces(list);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetImplementedInterfaces) + ": Interface Names")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetImplementedInterfacesInterfaceNames()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaces(list, new List<string> { nameof(IEnumerable), nameof(IDisposable) });

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetImplementedInterfaceTypes))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetImplementedInterfaceTypes()
	{
		var list = new List<int>();
		var result = TypeHelper.GetImplementedInterfaceTypes(list);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetTypeMembersWithAttribute))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetTypeMembersWithAttribute()
	{
		var result = TypeHelper.GetTypeMembersWithAttribute<InformationAttribute>(typeof(TypeHelper));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasBaseClass))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void HasBaseClass()
	{
		var result = TypeHelper.HasBaseClass(typeof(Exception), typeof(object));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasMethod))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void HasMethod()
	{
		var result = TypeHelper.HasMethod(typeof(Person), "ToString");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasParameterlessConstructor))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void HasParameterlessConstructor()
	{
		var result = TypeHelper.HasParameterlessConstructor(typeof(StringBuilder));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.HasProperty))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void HasProperty()
	{
		var result = TypeHelper.HasProperty(typeof(string), "Length");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.ImplementsInterface))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void ImplementsInterface()
	{
		var result = TypeHelper.ImplementsInterface(typeof(List<int>), typeof(IEnumerable<>).MakeGenericType(typeof(int)));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.IsAssignableTo))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void IsAssignableTo()
	{
		var result = TypeHelper.IsAssignableTo(typeof(string), typeof(object));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.IsClosedGeneric))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void IsClosedGeneric()
	{
		var result = TypeHelper.IsClosedGeneric(typeof(List<int>));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.IsEnumerable))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void IsEnumerable()
	{
		var result = TypeHelper.IsEnumerable(typeof(List<int>));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllGenericMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllGenericMethods()
	{
		var result = TypeHelper.GetAllGenericMethods(typeof(StringBuilder));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllMethods()
	{
		var result = TypeHelper.GetAllMethods(typeof(StringBuilder));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllProperties))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllProperties()
	{
		var result = TypeHelper.GetAllProperties(typeof(Person));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllPublicMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllPublicMethods()
	{
		var result = TypeHelper.GetAllPublicMethods(typeof(Person));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAllStaticMethods))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAllStaticMethods()
	{
		var result = TypeHelper.GetAllPublicMethods(typeof(TypeHelper));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetAttribute) + ": FieldInfo")]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetAttributeFieldInfo()
	{
#pragma warning disable CS0612 // Type or member is obsolete
		var field = typeof(FieldWithAttributeTestClass).GetField(nameof(FieldWithAttributeTestClass.MarkedField));
#pragma warning restore CS0612 // Type or member is obsolete
		var result = TypeHelper.GetAttribute<ObsoleteAttribute>(field);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetInstanceHashCode))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetInstanceHashCode()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = TypeHelper.GetInstanceHashCode(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetMembersWithAttribute))]
	[BenchmarkCategory(Categories.Strings)]
	public void GetMembersWithAttribute()
	{
		var type = typeof(Person);

		var result = TypeHelper.GetMembersWithAttribute<InformationAttribute>(type);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetPropertyValues))]
	[BenchmarkCategory(Categories.Reflection)]
	public void GetPropertyValues()
	{
		var person = RandomData.GeneratePerson<Person>();

		var result = TypeHelper.GetPropertyValues(person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.GetTypeDisplayName))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void GetTypeDisplayName()
	{
		var type = typeof(int[]);
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true);

		var result = TypeHelper.GetTypeDisplayName(type, options);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(TypeHelper.ProcessGenericType))]
	[BenchmarkCategory(Categories.Reflection, Categories.New)]
	public void ProcessGenericType()
	{
		var builder = new StringBuilder();
		var type = typeof(List<>);
		var genericArguments = Array.Empty<Type>();
		var options = new DisplayNameOptions(fullName: true, includeGenericParameterNames: false, includeGenericParameters: true, nestedTypeDelimiter: '.');

		TypeHelper.ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);

		this.Consume(builder.ToString());
	}

	public override void Setup()
	{
		base.Setup();

		var list = new Dictionary<string, string>(this._collectionCount);
		for (var i = 0; i < this._collectionCount; i++)
		{
			list.Add(RandomData.GenerateKey(), RandomData.GenerateKey());
		}

		this._people = [.. RandomData.GeneratePersonRefCollection(this._collectionCount)];
	}

	private sealed class FieldWithAttributeTestClass
	{
		[Obsolete]
		public int MarkedField;
	}

}
