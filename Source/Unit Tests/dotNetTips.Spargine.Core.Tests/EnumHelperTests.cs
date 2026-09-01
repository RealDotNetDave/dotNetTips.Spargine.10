// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-02-2026
// ***********************************************************************
// <copyright file="EnumHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumHelperTests
{

	private enum TestBothAttributesEnum
	{
		[System.ComponentModel.Description("Description Wins")]
		[EnumMember(Value = "EnumMember Loses")]
		Value1,

		[EnumMember(Value = "Only EnumMember")]
		Value2
	}

	private enum TestDescriptionEnum
	{
		[System.ComponentModel.Description("First Item Description")]
		Value1,

		[System.ComponentModel.Description("Second Item Description")]
		Value2,

		Value3
	}

	[Flags]
	private enum TestFlagsEnum
	{
		None = 0,
		Read = 1,
		Write = 2,
		Execute = 4,
		All = Read | Write | Execute
	}

	private enum TestPlainEnum
	{
		ValueOne,
		ValueTwo,
		Value_With_Underscores
	}

	private enum TestXmlAndDescriptionEnum
	{
		[XmlEnum("XML Takes Priority")]
		[System.ComponentModel.Description("Description Ignored")]
		Value1,

		[System.ComponentModel.Description("Only Description Here")]
		Value2
	}

	private enum TestXmlEnumEnum
	{
		[XmlEnum("XML First")]
		Value1,

		[XmlEnum("XML Second")]
		Value2,

		Value3
	}

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
	public void FlagCount_ReturnsCountForFlagsEnum()
	{
		var value = TestFlagsEnum.Read | TestFlagsEnum.Write | TestFlagsEnum.Execute;

		var result = EnumHelper.FlagCount(value);

		Assert.AreEqual(3, result);
	}

	[TestMethod]
	public void FlagCount_ReturnsOneForNonFlagsEnum()
	{
		var result = EnumHelper.FlagCount(TestPlainEnum.ValueOne);

		Assert.AreEqual(1, result);
	}

	[TestMethod]
	public void GetDescription_CachesResult()
	{
		// Arrange & Act
		var first = EnumHelper.GetDescription(TestPlainEnum.ValueOne);
		var second = EnumHelper.GetDescription(TestPlainEnum.ValueOne);

		// Assert - same reference from cache
		Assert.AreSame(first, second);
	}

	[TestMethod]
	public void GetDescription_PrefersDescription_OverEnumMember()
	{
		// Arrange - TestBothAttributesEnum.Value1 has both [Description] and [EnumMember]
		// GetDescription should prefer DescriptionAttribute

		// Act & Assert
		Assert.AreEqual("Description Wins", EnumHelper.GetDescription(TestBothAttributesEnum.Value1));
		Assert.AreEqual("Only EnumMember", EnumHelper.GetDescription(TestBothAttributesEnum.Value2));
	}

	[TestMethod]
	public void GetDescription_ReturnsDescriptionAttribute_WhenPresent()
	{
		// Act & Assert
		Assert.AreEqual("First Item Description", EnumHelper.GetDescription(TestDescriptionEnum.Value1));
		Assert.AreEqual("Second Item Description", EnumHelper.GetDescription(TestDescriptionEnum.Value2));
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
	public void GetDescription_ReturnsEnumName_WhenNoAttributesPresent()
	{
		// Act & Assert - enum values with no attributes fall back to the name
		Assert.AreEqual("ValueOne", EnumHelper.GetDescription(TestPlainEnum.ValueOne));
		Assert.AreEqual("ValueTwo", EnumHelper.GetDescription(TestPlainEnum.ValueTwo));
	}

	[TestMethod]
	public void GetDescription_ThrowsOnNull()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => EnumHelper.GetDescription(null!));
	}

	[TestMethod]
	public void GetItems_HandlesUnderscoreNames_WhenFixNamesTrue()
	{
		// Act
		var values = EnumHelper.GetItems<TestPlainEnum>(fixNames: true);

		// Assert - underscores should be replaced with spaces and camelCase adjusted
		Assert.HasCount(3, values);
		Assert.IsTrue(values.Any(v => v.Name == "Value One" && v.Value == 0));
		Assert.IsTrue(values.Any(v => v.Name == "Value Two" && v.Value == 1));
		Assert.IsTrue(values.Any(v => v.Name == "Value With Underscores" && v.Value == 2));
	}

	[TestMethod]
	public void GetItems_ReturnsSameInstance_FromCache()
	{
		// Act - call twice with same parameters
		var first = EnumHelper.GetItems<TestPlainEnum>(fixNames: false);
		var second = EnumHelper.GetItems<TestPlainEnum>(fixNames: false);

		// Assert - should return same reference from cache
		Assert.AreSame(first, second);
	}

	[TestMethod]
	public void GetItems_UsesDescriptionAttribute_WhenPresent()
	{
		// Act
		var values = EnumHelper.GetItems<TestDescriptionEnum>();

		// Assert
		Assert.HasCount(3, values);
		Assert.IsTrue(values.Any(v => v.Name == "First Item Description" && v.Value == 0));
		Assert.IsTrue(values.Any(v => v.Name == "Second Item Description" && v.Value == 1));
	}

	[TestMethod]
	public void GetItems_UsesXmlEnumAttribute_WhenPresent()
	{
		// Act
		var values = EnumHelper.GetItems<TestXmlEnumEnum>();

		// Assert
		Assert.HasCount(3, values);
		Assert.IsTrue(values.Any(v => v.Name == "XML First" && v.Value == 0));
		Assert.IsTrue(values.Any(v => v.Name == "XML Second" && v.Value == 1));
	}

	[TestMethod]
	public void GetItems_XmlEnumAttribute_TakesPrecedence_OverDescription()
	{
		// Act
		var values = EnumHelper.GetItems<TestXmlAndDescriptionEnum>();

		// Assert - XmlEnumAttribute should take precedence over DescriptionAttribute
		Assert.HasCount(2, values);
		Assert.IsTrue(values.Any(v => v.Name == "XML Takes Priority" && v.Value == 0));
		Assert.IsTrue(values.Any(v => v.Name == "Only Description Here" && v.Value == 1));
	}

	[TestMethod]
	public void GetSetFlags_ReturnsIndividualFlags()
	{
		var value = TestFlagsEnum.Read | TestFlagsEnum.Write;
		var flags = EnumHelper.GetSetFlags(value);

		Assert.HasCount(2, flags);
		Assert.Contains(TestFlagsEnum.Read, flags);
		Assert.Contains(TestFlagsEnum.Write, flags);
	}

	[TestMethod]
	public void GetSetFlags_WithNonFlagsEnum_ThrowsArgumentException()
	{
		Assert.ThrowsExactly<ArgumentException>(() => EnumHelper.GetSetFlags(TestPlainEnum.ValueOne));
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
	public void TryParse_ReturnsFalse_ForInvalidName()
	{
		// Act & Assert
		Assert.IsFalse(EnumHelper.TryParse<Status>("NonExistentValue", out var result));
		Assert.AreEqual(default(Status), result);
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
