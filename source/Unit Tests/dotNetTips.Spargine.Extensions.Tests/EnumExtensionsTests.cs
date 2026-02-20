// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2026
// ***********************************************************************
// <copyright file="EnumExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumExtensionsTests
{

	private enum TestDisplayEnum
	{
		[System.ComponentModel.DataAnnotations.Display(Name = "First Option")]
		FirstOption = 1,
		SecondOption = 2
	}

	private enum TestEnum
	{
		[EnumMember(Value = "Custom Description")]
		WithDescription = 0,
		WithoutDescription = 1
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

	[TestMethod]
	public void FlagCount_WithFlagsEnum_ReturnsCorrectCount()
	{
		var value = TestFlagsEnum.Read | TestFlagsEnum.Write;
		var count = value.FlagCount;

		Assert.AreEqual(2, count);
	}

	[TestMethod]
	public void FlagCount_WithNonFlagsEnum_ReturnsOne()
	{
		var value = TestEnum.WithDescription;
		var count = value.FlagCount;

		Assert.AreEqual(1, count);
	}

	[TestMethod]
	public void FlagCount_WithSingleFlag_ReturnsOne()
	{
		var value = TestFlagsEnum.Read;
		var count = value.FlagCount;

		Assert.AreEqual(1, count);
	}

	[TestMethod]
	public void GetAttribute_WithAttribute_ReturnsAttribute()
	{
		var value = TestEnum.WithDescription;
		var attribute = value.GetAttribute<EnumMemberAttribute>();

		Assert.IsNotNull(attribute);
		Assert.AreEqual("Custom Description", attribute.Value);
	}

	[TestMethod]
	public void GetAttribute_WithoutAttribute_ReturnsNull()
	{
		var value = TestEnum.WithoutDescription;
		var attribute = value.GetAttribute<EnumMemberAttribute>();

		Assert.IsNull(attribute);
	}

	[TestMethod]
	public void GetDescription_WithEnumMemberAttribute_ReturnsAttributeValue()
	{
		var value = TestEnum.WithDescription;
		var desc = value.GetDescription();

		Assert.AreEqual("Custom Description", desc);
	}

	[TestMethod]
	public void GetDescription_WithoutEnumMemberAttribute_ReturnsName()
	{
		var value = TestEnum.WithoutDescription;
		var desc = value.GetDescription();

		Assert.AreEqual("WithoutDescription", desc);
	}

	[TestMethod]
	public void GetDescriptionTest()
	{
		var enumValue = TaskStatus.Canceled;

		var result = enumValue.GetDescription();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void GetDisplayName_WithDisplayAttribute_ReturnsDisplayName()
	{
		var value = TestDisplayEnum.FirstOption;
		var displayName = value.GetDisplayName();

		Assert.AreEqual("First Option", displayName);
	}

	[TestMethod]
	public void GetDisplayName_WithoutDisplayAttribute_ReturnsEnumName()
	{
		var value = TestDisplayEnum.SecondOption;
		var displayName = value.GetDisplayName();

		Assert.AreEqual("SecondOption", displayName);
	}

	[TestMethod]
	public void GetItems_ReturnsAllEnumValues()
	{
		var items = TestEnum.WithDescription.GetItems();

		Assert.HasCount(2, items);
		Assert.IsTrue(items.Any(i => i.Description == "WithDescription" && i.Value == 0));
		Assert.IsTrue(items.Any(i => i.Description == "WithoutDescription" && i.Value == 1));
	}

	[TestMethod]
	public void GetItemsTest()
	{
		var result = TaskStatus.Canceled.GetItems();

		Assert.IsNotEmpty(result);
	}

	[TestMethod]
	public void GetSetFlags_WithAllFlags_ReturnsAllIndividualFlags()
	{
		var value = TestFlagsEnum.All;
		var flags = value.GetSetFlags();

		Assert.HasCount(4, flags);
	}

	[TestMethod]
	public void GetSetFlags_WithFlagsEnum_ReturnsIndividualFlags()
	{
		var value = TestFlagsEnum.Read | TestFlagsEnum.Write;
		var flags = value.GetSetFlags();

		Assert.HasCount(2, flags);
		Assert.IsTrue(flags.Contains(TestFlagsEnum.Read));
		Assert.IsTrue(flags.Contains(TestFlagsEnum.Write));
	}

	[TestMethod]
	public void GetSetFlags_WithNonFlagsEnum_ThrowsArgumentException()
	{
		var value = TestEnum.WithDescription;

		Assert.ThrowsExactly<ArgumentException>(() => value.GetSetFlags());
	}

	[TestMethod]
	public void Next_AtEndOfEnum_ReturnsFirstValue()
	{
		var value = TestEnum.WithoutDescription;
		var next = value.Next();

		Assert.AreEqual(TestEnum.WithDescription, next);
	}

	[TestMethod]
	public void Next_ReturnsNextEnumValue()
	{
		var value = TestEnum.WithDescription;
		var next = value.Next();

		Assert.AreEqual(TestEnum.WithoutDescription, next);
	}

	[TestMethod]
	public void ParseTest_True()
	{
		var result = "Canceled".Parse<TaskStatus>();

		Assert.IsNotNull(result);

		Assert.AreEqual(0, string.Compare(result.ToString(), "Canceled", StringComparison.Ordinal));
	}

	[TestMethod]
	public void Previous_AtStartOfEnum_ReturnsLastValue()
	{
		var value = TestEnum.WithDescription;
		var previous = value.Previous();

		Assert.AreEqual(TestEnum.WithoutDescription, previous);
	}

	[TestMethod]
	public void Previous_ReturnsPreviousEnumValue()
	{
		var value = TestEnum.WithoutDescription;
		var previous = value.Previous();

		Assert.AreEqual(TestEnum.WithDescription, previous);
	}

	[TestMethod]
	public void ToInt32_ReturnsCorrectIntegerValue()
	{
		var value = TestEnum.WithDescription;
		var intValue = value.ToInt32();

		Assert.AreEqual(0, intValue);

		var value2 = TestEnum.WithoutDescription;
		var intValue2 = value2.ToInt32();

		Assert.AreEqual(1, intValue2);
	}

	[TestMethod]
	public void ToInt64_ReturnsCorrectLongValue()
	{
		var value = TestEnum.WithDescription;
		var longValue = value.ToInt64();

		Assert.AreEqual(0L, longValue);

		var value2 = TestEnum.WithoutDescription;
		var longValue2 = value2.ToInt64();

		Assert.AreEqual(1L, longValue2);
	}

}
