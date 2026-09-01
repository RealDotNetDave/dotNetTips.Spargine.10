// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-05-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-05-2026
// ***********************************************************************
// <copyright file="DataReaderExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DataReaderExtensionsTests
{

	[TestMethod]
	public void ToCsv_AllDBNullRow_ReturnsRowWithOnlyDelimiters()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add(DBNull.Value, DBNull.Value, DBNull.Value);
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.AreEqual(",,", result[0]);
	}

	[TestMethod]
	public void ToCsv_CustomDelimiter_UsesSpecifiedDelimiter()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("Alice", 30, "Seattle");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: true, delimiter: '|');

		// Assert
		Assert.AreEqual(2, result.Count);
		Assert.AreEqual("Name|Age|City", result[0]);
		Assert.AreEqual("Alice|30|Seattle", result[1]);
	}

	[TestMethod]
	public void ToCsv_CustomDelimiterInStringValue_WrapsInQuotes()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("Alice|Bob", 30, "Seattle");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false, delimiter: '|');

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.IsTrue(result[0].StartsWith("\"Alice|Bob\"", StringComparison.Ordinal));
	}

	[TestMethod]
	public void ToCsv_DefaultDelimiter_UsesComma()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("Alice", 30, "Seattle");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.AreEqual("Alice,30,Seattle", result[0]);
	}

	[TestMethod]
	public void ToCsv_EmptyReaderWithHeader_ReturnsOnlyHeaderRow()
	{
		// Arrange
		using var table = CreateTestDataTable();
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: true);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Count);
		Assert.AreEqual("Name,Age,City", result[0]);
	}

	[TestMethod]
	public void ToCsv_EmptyReaderWithoutHeader_ReturnsEmptyCollection()
	{
		// Arrange
		using var table = CreateTestDataTable();
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count);
	}

	[TestMethod]
	public void ToCsv_MultipleRows_ReturnsAllRows()
	{
		// Arrange
		using var table = CreateTestDataTable();
		var word1 = RandomData.GenerateWord(8);
		var word2 = RandomData.GenerateWord(8);
		var word3 = RandomData.GenerateWord(8);
		table.Rows.Add(word1, 25, "CityA");
		table.Rows.Add(word2, 30, "CityB");
		table.Rows.Add(word3, 35, "CityC");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(3, result.Count);
	}

	[TestMethod]
	public void ToCsv_MultipleRowsWithHeader_ReturnsHeaderPlusRows()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("Alice", 25, "CityA");
		table.Rows.Add("Bob", 30, "CityB");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: true);

		// Assert
		Assert.AreEqual(3, result.Count);
		Assert.AreEqual("Name,Age,City", result[0]);
		Assert.AreEqual("Alice,25,CityA", result[1]);
		Assert.AreEqual("Bob,30,CityB", result[2]);
	}

	[TestMethod]
	public void ToCsv_NonStringField_AppendsValueDirectly()
	{
		// Arrange
		using var table = new DataTable();
		table.Columns.Add("Id", typeof(int));
		table.Columns.Add("Score", typeof(double));
		table.Rows.Add(1, 99.5);
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.AreEqual("1,99.5", result[0]);
	}

	[TestMethod]
	public void ToCsv_NullDataReader_ThrowsArgumentNullException()
	{
		// Arrange
		IDataReader dataReader = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => dataReader.ToCsv(true));
	}

	[TestMethod]
	public void ToCsv_ReturnsReadOnlyCollection()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("Test", 1, "City");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.IsInstanceOfType<ReadOnlyCollection<string>>(result);
	}

	[TestMethod]
	public void ToCsv_SingleColumn_NoTrailingDelimiter()
	{
		// Arrange
		using var table = new DataTable();
		table.Columns.Add("Name", typeof(string));
		table.Rows.Add("Alice");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: true);

		// Assert
		Assert.AreEqual(2, result.Count);
		Assert.AreEqual("Name", result[0]);
		Assert.AreEqual("Alice", result[1]);
	}

	[TestMethod]
	public void ToCsv_StringWithDelimiter_WrapsInQuotes()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("Smith, John", 35, "Miami");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.IsTrue(result[0].StartsWith("\"Smith, John\"", StringComparison.Ordinal));
	}

	[TestMethod]
	public void ToCsv_StringWithDoubleQuotes_EscapesQuotes()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("She said \"hello\"", 28, "Boston");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.IsTrue(result[0].StartsWith("She said \"\"hello\"\"", StringComparison.Ordinal));
	}

	[TestMethod]
	public void ToCsv_StringWithQuotesAndDelimiter_EscapesAndWraps()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("He said \"hi, there\"", 40, "Dallas");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(1, result.Count);
		// Double quotes escaped first, then delimiter causes wrapping
		Assert.IsTrue(result[0].StartsWith("\"He said \"\"hi, there\"\"\"", StringComparison.Ordinal));
	}

	[TestMethod]
	public void ToCsv_WithDBNullValues_SkipsNullFields()
	{
		// Arrange
		using var table = CreateTestDataTable();
		table.Rows.Add("Alice", DBNull.Value, "Denver");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.AreEqual("Alice,,Denver", result[0]);
	}

	[TestMethod]
	public void ToCsv_WithHeader_IncludesHeaderAsFirstRow()
	{
		// Arrange
		using var table = CreateTestDataTable();
		var word = RandomData.GenerateWord(10);
		table.Rows.Add(word, 30, "Seattle");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: true);

		// Assert
		Assert.AreEqual(2, result.Count);
		Assert.AreEqual("Name,Age,City", result[0]);
		Assert.IsTrue(result[1].Contains(word, StringComparison.Ordinal));
	}

	[TestMethod]
	public void ToCsv_WithoutHeader_ExcludesHeaderRow()
	{
		// Arrange
		using var table = CreateTestDataTable();
		var word = RandomData.GenerateWord(10);
		table.Rows.Add(word, 25, "Portland");
		using var reader = table.CreateDataReader();

		// Act
		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		// Assert
		Assert.AreEqual(1, result.Count);
		Assert.IsTrue(result[0].Contains(word, StringComparison.Ordinal));
	}

	private static DataTable CreateTestDataTable()
	{
		var table = new DataTable();
		table.Columns.Add("Name", typeof(string));
		table.Columns.Add("Age", typeof(int));
		table.Columns.Add("City", typeof(string));

		return table;
	}
}
