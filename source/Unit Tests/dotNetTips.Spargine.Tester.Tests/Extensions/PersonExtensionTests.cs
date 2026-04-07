// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-29-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="AddressRefTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Extensions;

[ExcludeFromCodeCoverage]
[TestClass]
public class PersonExtensionTests : UnitTester
{

	[TestMethod]
	public void RecordAgeTest()
	{
		var person = RandomData.GeneratePerson<PersonRecord>();

		var age = person.Age;

		Assert.IsGreaterThan(0, age.TotalDays, "Age should be a non-negative value.");
	}

	[TestMethod]
	public void RecordAgeNullBornOnTest()
	{
		var person = RandomData.GeneratePerson<PersonRecord>() with { BornOn = null };

		var age = person.Age;

		Assert.AreEqual(TimeSpan.Zero, age);
	}

	[TestMethod]
	public void RecordFullNameTest()
	{
		var person = RandomData.GeneratePerson<PersonRecord>();

		var name = person.FullName;

		this.PrintToDebug($"Full Name: {name}");

		Assert.IsTrue(name.HasValue());
	}

	[TestMethod]
	public void RefAgeTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var age = person.Age;

		Assert.IsGreaterThan(0, age.TotalDays, "Age should be a non-negative value.");
	}

	[TestMethod]
	public void RefAgeNullBornOnTest()
	{
		var person = RandomData.GeneratePerson<Person>();
		person.BornOn = null;

		var age = person.Age;

		Assert.AreEqual(TimeSpan.Zero, age);
	}

	[TestMethod]
	public void RefFullNameTest()
	{
		var person = RandomData.GeneratePerson<Person>();

		var name = person.FullName;

		this.PrintToDebug($"Full Name: {name}");

		Assert.IsTrue(name.HasValue());
	}

	[TestMethod]
	public void ValAgeTest()
	{
		var person = RandomData.GeneratePerson<Models.ValueTypes.Person>();

		var age = person.Age;

		Assert.IsGreaterThan(0, age.TotalDays, "Age should be a non-negative value.");
	}

	[TestMethod]
	public void ValAgeNullBornOnTest()
	{
		var person = RandomData.GeneratePerson<Models.ValueTypes.Person>();
		person.BornOn = null;

		var age = person.Age;

		Assert.AreEqual(TimeSpan.Zero, age);
	}

	[TestMethod]
	public void ValFullNameTest()
	{
		var person = RandomData.GeneratePerson<Models.ValueTypes.Person>();

		var name = person.FullName;

		this.PrintToDebug($"Full Name: {name}");

		Assert.IsTrue(name.HasValue());
	}

}
