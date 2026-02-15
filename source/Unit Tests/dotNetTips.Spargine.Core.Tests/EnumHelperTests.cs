// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2026
// ***********************************************************************
// <copyright file="EnumHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumHelperTests
{

	[TestMethod]
	public void EnumValue_Constructor_MaxIntValue_CreatesInstance()
	{
		// Arrange
		const int value = int.MaxValue;
		const string name = "MaxValue";

		// Act
		var enumValue = new EnumValue(value, name);

		// Assert
		Assert.AreEqual(value, enumValue.Value);
		Assert.AreEqual(name, enumValue.Name);
	}

	[TestMethod]
	public void EnumValue_Constructor_MinIntValue_CreatesInstance()
	{
		// Arrange
		const int value = int.MinValue;
		const string name = "MinValue";

		// Act
		var enumValue = new EnumValue(value, name);

		// Assert
		Assert.AreEqual(value, enumValue.Value);
		Assert.AreEqual(name, enumValue.Name);
	}

	[TestMethod]
	public void EnumValue_Constructor_NegativeValue_CreatesInstance()
	{
		// Arrange
		const int value = -1;
		const string name = "Invalid";

		// Act
		var enumValue = new EnumValue(value, name);

		// Assert
		Assert.AreEqual(value, enumValue.Value);
		Assert.AreEqual(name, enumValue.Name);
	}


	[TestMethod]
	public void EnumValue_Constructor_ValidParameters_CreatesInstance()
	{
		// Arrange
		const int value = 42;
		const string name = "TestEnum";

		// Act
		var enumValue = new EnumValue(value, name);

		// Assert
		Assert.IsNotNull(enumValue);
		Assert.AreEqual(value, enumValue.Value);
		Assert.AreEqual(name, enumValue.Name);
	}

	[TestMethod]
	public void EnumValue_Constructor_ZeroValue_CreatesInstance()
	{
		// Arrange
		const int value = 0;
		const string name = "None";

		// Act
		var enumValue = new EnumValue(value, name);

		// Assert
		Assert.AreEqual(value, enumValue.Value);
		Assert.AreEqual(name, enumValue.Name);
	}
	[TestMethod]
	public void GetDescription_ReturnsEnumMemberValue_IfPresent()
	{
		Assert.AreEqual("Not Set", EnumHelper.GetDescription(Status.NotSet));
		Assert.AreEqual("New", EnumHelper.GetDescription(Status.New));
		Assert.AreEqual("Available", EnumHelper.GetDescription(Status.Available));
		Assert.AreEqual("Not Used", EnumHelper.GetDescription(Status.NotUsed));
		Assert.AreEqual("Updated", EnumHelper.GetDescription(Status.Updated));
		Assert.AreEqual("Needs Documentation", EnumHelper.GetDescription(Status.NeedsDocumentation));
		Assert.AreEqual("Update Documentation", EnumHelper.GetDescription(Status.UpdateDocumentation));
	}

	[TestMethod]
	public void GetDescription_ThrowsOnNull()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => EnumHelper.GetDescription(null!));
	}

	[TestMethod]
	public void GetValues_ReturnsAllEnumValues_WithDefaultNames()
	{
		var values = EnumHelper.GetItems<Status>();

		//Call again to hit cache
		values = EnumHelper.GetItems<Status>();

		Assert.HasCount(8, values);
		Assert.IsTrue(values.Any(v => v.Name == "Not Set" && v.Value == 0));
		Assert.IsTrue(values.Any(v => v.Name == "New" && v.Value == 1));
		Assert.IsTrue(values.Any(v => v.Name == "Available" && v.Value == 2));
		Assert.IsTrue(values.Any(v => v.Name == "Not Used" && v.Value == 3));
		Assert.IsTrue(values.Any(v => v.Name == "Obsolete" && v.Value == 4));
		Assert.IsTrue(values.Any(v => v.Name == "Updated" && v.Value == 5));
		Assert.IsTrue(values.Any(v => v.Name == "Needs Documentation" && v.Value == 6));
		Assert.IsTrue(values.Any(v => v.Name == "Update Documentation" && v.Value == 7));
	}

	[TestMethod]
	public void GetValues_ReturnsAllEnumValues_WithoutFixNames()
	{
		var values = EnumHelper.GetItems<Status>(fixNames: false);
		Assert.HasCount(8, values);
		Assert.IsTrue(values.Any(v => v.Name == "NotSet" && v.Value == 0));
		Assert.IsTrue(values.Any(v => v.Name == "New" && v.Value == 1));
		Assert.IsTrue(values.Any(v => v.Name == "Available" && v.Value == 2));
		Assert.IsTrue(values.Any(v => v.Name == "NotUsed" && v.Value == 3));
		Assert.IsTrue(values.Any(v => v.Name == "Obsolete" && v.Value == 4));
		Assert.IsTrue(values.Any(v => v.Name == "Updated" && v.Value == 5));
		Assert.IsTrue(values.Any(v => v.Name == "NeedsDocumentation" && v.Value == 6));
		Assert.IsTrue(values.Any(v => v.Name == "UpdateDocumentation" && v.Value == 7));
	}

	[TestMethod]
	public void TryParse_ParsesEnumName()
	{
		Assert.IsTrue(EnumHelper.TryParse<Status>("Available", out var result1));
		Assert.AreEqual(Status.Available, result1);

		Assert.IsTrue(EnumHelper.TryParse<Status>("NotSet", out var result2));
		Assert.AreEqual(Status.NotSet, result2);
	}

	[TestMethod]
	public void TryParse_ReturnsFalse_OnNullOrEmpty()
	{
		// Test null
		Assert.IsFalse(EnumHelper.TryParse<Status>(null!, out var result1));
		Assert.AreEqual(default(Status), result1);

		// Test empty string
		Assert.IsFalse(EnumHelper.TryParse<Status>(string.Empty, out var result2));
		Assert.AreEqual(default(Status), result2);

		// Test whitespace
		Assert.IsFalse(EnumHelper.TryParse<Status>("   ", out var result3));
		Assert.AreEqual(default(Status), result3);
	}
}
