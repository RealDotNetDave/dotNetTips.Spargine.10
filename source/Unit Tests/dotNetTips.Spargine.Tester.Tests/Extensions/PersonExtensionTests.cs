// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-29-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2025
// ***********************************************************************
// <copyright file="AddressRefTests.cs" company="DotNetTips.Spargine.Tester.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

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

		Assert.IsTrue(age.TotalDays > 0, "Age should be a non-negative value.");
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

		Assert.IsTrue(age.TotalDays > 0, "Age should be a non-negative value.");
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

		Assert.IsTrue(age.TotalDays > 0, "Age should be a non-negative value.");
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
