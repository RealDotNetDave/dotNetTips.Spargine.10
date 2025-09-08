// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-17-2025
// ***********************************************************************
// <copyright file="EnumHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumHelperTests
{
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
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetDescription_ThrowsOnNull()
	{
		EnumHelper.GetDescription(null!);
	}

	[TestMethod]
	public void GetItems_ReturnsAllEnumItems()
	{
		var items = EnumHelper.GetItems(Status.Available);
		Assert.AreEqual(8, items.Count);
		Assert.IsTrue(items.Contains(("NotSet", 0)));
		Assert.IsTrue(items.Contains(("New", 1)));
		Assert.IsTrue(items.Contains(("Available", 2)));
		Assert.IsTrue(items.Contains(("NotUsed", 3)));
		Assert.IsTrue(items.Contains(("Obsolete", 4)));
		Assert.IsTrue(items.Contains(("Updated", 5)));
		Assert.IsTrue(items.Contains(("NeedsDocumentation", 6)));
		Assert.IsTrue(items.Contains(("UpdateDocumentation", 7)));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetItems_ThrowsOnNull()
	{
		EnumHelper.GetItems(null!);
	}

	[TestMethod]
	public void GetValues_ReturnsAllEnumValues_WithDefaultNames()
	{
		var values = EnumHelper.GetValues<Status>();
		Assert.AreEqual(8, values.Count);
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
		var values = EnumHelper.GetValues<Status>(fixNames: false);
		Assert.AreEqual(8, values.Count);
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
	public void Parse_ParsesEnumName()
	{
		Assert.AreEqual(Status.Available, EnumHelper.Parse<Status>("Available"));
		Assert.AreEqual(Status.NotSet, EnumHelper.Parse<Status>("NotSet"));
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void Parse_ThrowsOnNullOrEmpty()
	{
		EnumHelper.Parse<Status>(null!);
	}
}
