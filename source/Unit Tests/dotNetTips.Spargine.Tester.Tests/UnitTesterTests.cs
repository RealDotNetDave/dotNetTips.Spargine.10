// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-05-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-21-2025
// ***********************************************************************
// <copyright file="UnitTesterTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class UnitTesterTests
{


	[TestMethod]
	public void PropertiesToString_AllProperties_ReturnsAllProperties()
	{
		// Arrange
		var tester = new TestUnitTester();
		var sample = new Sample { Id = 1, Name = "Test" };

		// Act
		var result = tester.PropertiesToString(sample, p => true);

		// Assert
		Assert.IsTrue(result.Contains("Id: 1"));
		Assert.IsTrue(result.Contains("Name: Test"));
	}

	[TestMethod]
	public void PropertiesToString_NoProperties_ReturnsEmptyString()
	{
		// Arrange
		var tester = new TestUnitTester();
		var obj = new NoProperties();

		// Act
		var result = tester.PropertiesToString(obj, p => true);

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void PropertiesToString_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		var tester = new TestUnitTester();

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => tester.PropertiesToString<Sample>(null!, p => true));
	}

	[TestMethod]
	public void PropertiesToString_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		var tester = new TestUnitTester();
		var sample = new Sample();

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => tester.PropertiesToString(sample, null!));
	}

	[TestMethod]
	public void PropertiesToString_SelectNameProperty_ReturnsNameOnly()
	{
		// Arrange
		var tester = new TestUnitTester();
		var sample = new Sample { Id = 2, Name = "Sample" };

		// Act
		var result = tester.PropertiesToString(sample, p => p.Name == "Name");

		// Assert
		Assert.AreEqual("Name: Sample", result);
	}

	private class TestUnitTester : UnitTester
	{
		public TestUnitTester(string outputDirectory = null) : base(outputDirectory) { }

		public new string PropertiesToString<T>(T input, Func<PropertyInfo, bool> propertySelector) =>
			base.PropertiesToString(input, propertySelector);
	}

	private class Sample
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}

	private class NoProperties { }
}
