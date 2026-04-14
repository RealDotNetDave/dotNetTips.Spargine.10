// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 04-14-2026
//
// Last Modified By : David McCarter
// Last Modified On : 04-14-2026
// ***********************************************************************
// <copyright file="TimeOnlyConverterTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using DotNetTips.Spargine.Tester.Data.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Data;

[ExcludeFromCodeCoverage]
[TestClass]
public class TimeOnlyConverterTests
{

	[TestMethod]
	public void DefaultConstructorUsesDefaultFormat()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var time = new TimeOnly(14, 30, 45, 123);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(time, options);

		// Assert
		Assert.AreEqual("\"14:30:45.123\"", json);
	}

	[TestMethod]
	public void CustomFormatConstructorUsesSpecifiedFormat()
	{
		// Arrange
		var converter = new TimeOnlyConverter("HH:mm:ss");
		var time = new TimeOnly(14, 30, 45);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(time, options);

		// Assert
		Assert.AreEqual("\"14:30:45\"", json);
	}

	[TestMethod]
	public void ReadValidTimeReturnsTimeOnly()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var result = JsonSerializer.Deserialize<TimeOnly>("\"14:30:45\"", options);

		// Assert
		Assert.AreEqual(new TimeOnly(14, 30, 45), result);
	}

	[TestMethod]
	public void ReadInvalidTimeThrowsJsonException()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act & Assert
		Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<TimeOnly>("\"not-a-time\"", options));
	}

	[TestMethod]
	public void ReadNullValueThrowsJsonException()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act & Assert
		Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<TimeOnly>("null", options));
	}

	[TestMethod]
	public void WriteValidTimeOnlyProducesExpectedJson()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var time = new TimeOnly(9, 5, 0, 0);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(time, options);

		// Assert
		Assert.AreEqual("\"09:05:00.000\"", json);
	}

	[TestMethod]
	public void WriteNullWriterThrowsArgumentNullException()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var time = new TimeOnly(14, 30, 45);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => converter.Write(null, time, new JsonSerializerOptions()));
	}

	[TestMethod]
	public void RoundTripSerializationWithDefaultFormat()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var original = new TimeOnly(23, 59, 59, 999);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var deserialized = JsonSerializer.Deserialize<TimeOnly>(json, options);

		// Assert
		Assert.AreEqual(original, deserialized);
	}

	[TestMethod]
	public void RoundTripSerializationMidnight()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var original = new TimeOnly(0, 0, 0);
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var deserialized = JsonSerializer.Deserialize<TimeOnly>(json, options);

		// Assert
		Assert.AreEqual(original, deserialized);
	}

	[TestMethod]
	public void RoundTripSerializationMinValue()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var original = TimeOnly.MinValue;
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var json = JsonSerializer.Serialize(original, options);
		var deserialized = JsonSerializer.Deserialize<TimeOnly>(json, options);

		// Assert
		Assert.AreEqual(original, deserialized);
	}

	[TestMethod]
	public void ReadTimeWithMillisecondsReturnsCorrectTime()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act
		var result = JsonSerializer.Deserialize<TimeOnly>("\"10:20:30.456\"", options);

		// Assert
		Assert.AreEqual(new TimeOnly(10, 20, 30, 456), result);
	}

	[TestMethod]
	public void ReadEmptyStringThrowsJsonException()
	{
		// Arrange
		var converter = new TimeOnlyConverter();
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);

		// Act & Assert
		Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<TimeOnly>("\"\"", options));
	}
}
