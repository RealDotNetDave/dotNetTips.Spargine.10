// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-05-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-05-2026
// ***********************************************************************
// <copyright file="DataTableExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DataTableExtensionsTests
{

	[TestMethod]
	public void HasRows_EmptyTable_ReturnsFalse()
	{
		// Arrange
		using (var table = new DataTable())
		{
			table.Columns.Add("Name", typeof(string));

			// Act
			var result = table.HasRows();

			// Assert
			Assert.IsFalse(result);
		}
	}

	[TestMethod]
	public void HasRows_NullTable_ReturnsFalse()
	{
		// Arrange
		DataTable table = null;

		// Act
		var result = table.HasRows();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void HasRows_TableWithMultipleRows_ReturnsTrue()
	{
		// Arrange
		var table = new DataTable();
		table.Columns.Add("Name", typeof(string));
		table.Rows.Add(RandomData.GenerateWord(10));
		table.Rows.Add(RandomData.GenerateWord(10));
		table.Rows.Add(RandomData.GenerateWord(10));

		// Act
		var result = table.HasRows();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void HasRows_TableWithRows_ReturnsTrue()
	{
		// Arrange
		var table = new DataTable();
		table.Columns.Add("Name", typeof(string));
		table.Rows.Add(RandomData.GenerateWord(10));

		// Act
		var result = table.HasRows();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsDBNull_WithDBNullValue_ReturnsTrue()
	{
		// Arrange
		object value = DBNull.Value;

		// Act
		var result = value.IsDBNull();

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsDBNull_WithIntValue_ReturnsFalse()
	{
		// Arrange
		object value = 42;

		// Act
		var result = value.IsDBNull();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsDBNull_WithStringValue_ReturnsFalse()
	{
		// Arrange
		object value = RandomData.GenerateWord(10);

		// Act
		var result = value.IsDBNull();

		// Assert
		Assert.IsFalse(result);
	}

}
