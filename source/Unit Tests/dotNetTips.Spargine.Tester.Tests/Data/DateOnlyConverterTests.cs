// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 04-14-2026
//
// Last Modified By : David McCarter
// Last Modified On : 04-14-2026
// ***********************************************************************
// <copyright file="DateOnlyConverterTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Tester.Data.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Data;

[ExcludeFromCodeCoverage]
[TestClass]
public class DateOnlyConverterTests
{

	[TestMethod]
	public void DefaultConstructorUsesDefaultFormat()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var date = new DateOnly(2025, 6, 15);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(date, options);

		// Assert
		Assert.AreEqual("\"2025-06-15\"", json);
	}

	[TestMethod]
	public void CustomFormatConstructorUsesSpecifiedFormat()
	{
		// Arrange
		var converter = new DateOnlyConverter("MM/dd/yyyy");
		var date = new DateOnly(2025, 6, 15);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(date, options);

		// Assert
		Assert.AreEqual("\"06/15/2025\"", json);
	}

	[TestMethod]
	public void ReadValidDateReturnsDateOnly()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var result = JsonSerializer.Deserialize<DateOnly>("\"2025-06-15\"", options);

		// Assert
		Assert.AreEqual(new DateOnly(2025, 6, 15), result);
	}

	[TestMethod]
	public void ReadInvalidDateThrowsJsonException()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act & Assert
		Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<DateOnly>("\"not-a-date\"", options));
	}

	[TestMethod]
	public void WriteValidDateOnlyProducesExpectedJson()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var date = new DateOnly(2023, 1, 1);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(date, options);

		// Assert
		Assert.AreEqual("\"2023-01-01\"", json);
	}

	[TestMethod]
	public void WriteNullWriterThrowsArgumentNullException()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var date = new DateOnly(2025, 6, 15);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => converter.Write(null, date, new JsonSerializerOptions()));
	}

	[TestMethod]
	public void RoundTripSerializationWithDefaultFormat()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var original = new DateOnly(2025, 12, 31);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var deserialized = JsonSerializer.Deserialize<DateOnly>(json, options);

		// Assert
		Assert.AreEqual(original, deserialized);
	}

	[TestMethod]
	public void RoundTripSerializationMinValue()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var original = DateOnly.MinValue;
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var deserialized = JsonSerializer.Deserialize<DateOnly>(json, options);

		// Assert
		Assert.AreEqual(original, deserialized);
	}

	[TestMethod]
	public void RoundTripSerializationMaxValue()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var original = DateOnly.MaxValue;
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var deserialized = JsonSerializer.Deserialize<DateOnly>(json, options);

		// Assert
		Assert.AreEqual(original, deserialized);
	}

	[TestMethod]
	public void ReadLeapYearDateReturnsCorrectDate()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var result = JsonSerializer.Deserialize<DateOnly>("\"2024-02-29\"", options);

		// Assert
		Assert.AreEqual(new DateOnly(2024, 2, 29), result);
	}

	[TestMethod]
	public void ReadEmptyStringThrowsJsonException()
	{
		// Arrange
		var converter = new DateOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act & Assert
		Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<DateOnly>("\"\"", options));
	}
}
