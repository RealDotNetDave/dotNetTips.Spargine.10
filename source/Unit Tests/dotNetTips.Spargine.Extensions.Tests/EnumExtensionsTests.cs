// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
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
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumExtensionsTests
{

	private enum TestEnum
	{
		[EnumMember(Value = "Custom Description")]
		WithDescription = 0,
		WithoutDescription = 1
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
	public void ParseTest_True()
	{
		var result = "Canceled".Parse<TaskStatus>();

		Assert.IsNotNull(result);

		Assert.AreEqual(0, string.Compare(result.ToString(), "Canceled", StringComparison.Ordinal));
	}

}
