// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="JsonSerializationOptionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Tests for JsonSerialization option helpers and DateOnly/TimeOnly converter support.
// </summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetTips.Spargine.Core.Serialization;

namespace DotNetTips.Spargine.Core.Tests.Serialization;

[ExcludeFromCodeCoverage]
[TestClass]
public class JsonSerializationOptionsTests
{
	private static JsonSerializerOptions ConverterOptions => JsonSerialization.CreateDefaultOptions(includeDateOnlyConverters: true);

	[TestMethod]
	public void CreateDefaultOptions_ReturnsReadOnlyConfiguredOptions()
	{
		var options = JsonSerialization.CreateDefaultOptions();

		Assert.IsNotNull(options);
		Assert.IsTrue(options.IsReadOnly);
		Assert.AreEqual(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString, options.NumberHandling);
	}

	[TestMethod]
	public void CreateDefaultOptions_WithDateAndTimeConverters_RoundTripsValues()
	{
		var model = new DateTimeModel
		{
			Date = new DateOnly(2026, 7, 9),
			Time = new TimeOnly(13, 14, 15, 123)
		};

		var json = JsonSerializer.Serialize(model, ConverterOptions);
		var result = JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions);

		Assert.IsNotNull(result);
		Assert.AreEqual(model.Date, result.Date);
		Assert.AreEqual(model.Time, result.Time);
		Assert.Contains("2026-07-09", json);
		Assert.Contains("13:14:15.123", json);
	}

	// DateOnlyJsonConverter tests

	[TestMethod]
	public void DateOnlyConverter_Read_ProducesCorrectValue()
	{
		var json = """{"Date":"2026-07-09","Time":"00:00:00.000"}""";

		var result = JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions);

		Assert.IsNotNull(result);
		Assert.AreEqual(new DateOnly(2026, 7, 9), result.Date);
	}

	[TestMethod]
	public void DateOnlyConverter_Read_ThrowsJsonException_WhenValueIsNull()
	{
		var json = """{"Date":null,"Time":"00:00:00.000"}""";

		Assert.ThrowsExactly<JsonException>(() =>
			JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions));
	}

	[TestMethod]
	public void DateOnlyConverter_Read_ThrowsOnInvalidFormat()
	{
		// "07/09/2026" is not ISO 8601 — ParseExact should reject it
		var json = """{"Date":"07/09/2026","Time":"00:00:00.000"}""";

		Assert.ThrowsExactly<JsonException>(() =>
			JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions));
	}

	[TestMethod]
	public void DateOnlyConverter_RoundTrip_MaxValue()
	{
		var model = new DateTimeModel { Date = DateOnly.MaxValue, Time = TimeOnly.MinValue };

		var json = JsonSerializer.Serialize(model, ConverterOptions);
		var result = JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions);

		Assert.IsNotNull(result);
		Assert.AreEqual(DateOnly.MaxValue, result.Date);
	}

	[TestMethod]
	public void DateOnlyConverter_RoundTrip_MinValue()
	{
		var model = new DateTimeModel { Date = DateOnly.MinValue, Time = TimeOnly.MinValue };

		var json = JsonSerializer.Serialize(model, ConverterOptions);
		var result = JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions);

		Assert.IsNotNull(result);
		Assert.AreEqual(DateOnly.MinValue, result.Date);
	}

	[TestMethod]
	public void DateOnlyConverter_Write_ProducesIso8601Format()
	{
		var model = new DateTimeModel { Date = new DateOnly(2000, 1, 1), Time = TimeOnly.MinValue };

		var json = JsonSerializer.Serialize(model, ConverterOptions);

		Assert.Contains("\"2000-01-01\"", json);
	}

	// TimeOnlyJsonConverter tests

	[TestMethod]
	public void TimeOnlyConverter_Read_ProducesCorrectValue()
	{
		var json = """{"Date":"2026-07-09","Time":"13:14:15.123"}""";

		var result = JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions);

		Assert.IsNotNull(result);
		Assert.AreEqual(new TimeOnly(13, 14, 15, 123), result.Time);
	}

	[TestMethod]
	public void TimeOnlyConverter_Read_ThrowsJsonException_WhenValueIsNull()
	{
		var json = """{"Date":"2026-07-09","Time":null}""";

		Assert.ThrowsExactly<JsonException>(() =>
			JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions));
	}

	[TestMethod]
	public void TimeOnlyConverter_Read_ThrowsOnInvalidFormat()
	{
		// Missing milliseconds — ParseExact with "HH:mm:ss.fff" should reject "13:14:15"
		var json = """{"Date":"2026-07-09","Time":"13:14:15"}""";

		Assert.ThrowsExactly<JsonException>(() =>
			JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions));
	}

	[TestMethod]
	public void TimeOnlyConverter_RoundTrip_MaxValue()
	{
		// TimeOnly.MaxValue has sub-millisecond precision (23:59:59.9999999) which the
		// "HH:mm:ss.fff" format cannot represent. Use the highest millisecond-precision value.
		var maxMillisecond = new TimeOnly(23, 59, 59, 999);
		var model = new DateTimeModel { Date = DateOnly.MinValue, Time = maxMillisecond };

		var json = JsonSerializer.Serialize(model, ConverterOptions);
		var result = JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions);

		Assert.IsNotNull(result);
		Assert.AreEqual(maxMillisecond, result.Time);
	}

	[TestMethod]
	public void TimeOnlyConverter_RoundTrip_MinValue()
	{
		var model = new DateTimeModel { Date = DateOnly.MinValue, Time = TimeOnly.MinValue };

		var json = JsonSerializer.Serialize(model, ConverterOptions);
		var result = JsonSerializer.Deserialize<DateTimeModel>(json, ConverterOptions);

		Assert.IsNotNull(result);
		Assert.AreEqual(TimeOnly.MinValue, result.Time);
	}

	[TestMethod]
	public void TimeOnlyConverter_Write_ProducesExpectedFormat()
	{
		var model = new DateTimeModel { Date = DateOnly.MinValue, Time = new TimeOnly(8, 5, 3, 7) };

		var json = JsonSerializer.Serialize(model, ConverterOptions);

		Assert.Contains("\"08:05:03.007\"", json);
	}

	private sealed class DateTimeModel
	{
		public DateOnly Date { get; set; }

		public TimeOnly Time { get; set; }
	}
}
