// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : Copilot Agent
// Created          : 04-27-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-27-2026
// ***********************************************************************
// <copyright file="IsoDateTimeOffsetConverterTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for IsoDateTimeOffsetConverter covering Read/Write, default
// and custom formats, DateTimeStyles, Culture, CanConvert, and the Singleton
// instance.
// </summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.Json;
using DotNetTips.Spargine.Tester.Data.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests.Data;

[ExcludeFromCodeCoverage]
[TestClass]
public class IsoDateTimeOffsetConverterTests
{

	[TestMethod]
	public void CanConvert_DateTimeOffsetType_ReturnsTrue()
	{
		var converter = new IsoDateTimeOffsetConverter();

		Assert.IsTrue(converter.CanConvert(typeof(DateTimeOffset)));
	}

	[TestMethod]
	public void CanConvert_OtherType_ReturnsFalse()
	{
		var converter = new IsoDateTimeOffsetConverter();

		Assert.IsFalse(converter.CanConvert(typeof(DateTime)));
		Assert.IsFalse(converter.CanConvert(typeof(string)));
	}

	[TestMethod]
	public void Culture_DefaultValue_IsCurrentCulture()
	{
		var converter = new IsoDateTimeOffsetConverter();

		Assert.AreEqual(CultureInfo.CurrentCulture, converter.Culture);
	}

	[TestMethod]
	public void Culture_SetValue_ReturnsAssignedCulture()
	{
		var converter = new IsoDateTimeOffsetConverter
		{
			Culture = CultureInfo.InvariantCulture
		};

		Assert.AreEqual(CultureInfo.InvariantCulture, converter.Culture);
	}

	[TestMethod]
	public void DateTimeFormat_DefaultValue_IsEmptyString()
	{
		var converter = new IsoDateTimeOffsetConverter();

		Assert.AreEqual(string.Empty, converter.DateTimeFormat);
	}

	[TestMethod]
	public void DateTimeFormat_SetEmptyString_ResetsToEmptyString()
	{
		var converter = new IsoDateTimeOffsetConverter { DateTimeFormat = "yyyy-MM-dd" };
		converter.DateTimeFormat = string.Empty;

		Assert.AreEqual(string.Empty, converter.DateTimeFormat);
	}

	[TestMethod]
	public void DateTimeFormat_SetNullValue_ResetsToEmptyString()
	{
		var converter = new IsoDateTimeOffsetConverter { DateTimeFormat = "yyyy-MM-dd" };
		converter.DateTimeFormat = null;

		Assert.AreEqual(string.Empty, converter.DateTimeFormat);
	}

	[TestMethod]
	public void DateTimeFormat_SetValue_ReturnsAssignedFormat()
	{
		var converter = new IsoDateTimeOffsetConverter { DateTimeFormat = "yyyy-MM-dd" };

		Assert.AreEqual("yyyy-MM-dd", converter.DateTimeFormat);
	}

	[TestMethod]
	public void DateTimeStyles_DefaultValue_IsRoundtripKind()
	{
		var converter = new IsoDateTimeOffsetConverter();

		Assert.AreEqual(DateTimeStyles.RoundtripKind, converter.DateTimeStyles);
	}

	[TestMethod]
	public void DateTimeStyles_SetValue_ReturnsAssignedValue()
	{
		var converter = new IsoDateTimeOffsetConverter
		{
			DateTimeStyles = DateTimeStyles.AssumeUniversal
		};

		Assert.AreEqual(DateTimeStyles.AssumeUniversal, converter.DateTimeStyles);
	}

	[TestMethod]
	public void Read_CustomFormat_ParsesWithSpecifiedFormat()
	{
		var converter = new IsoDateTimeOffsetConverter
		{
			DateTimeFormat = "yyyy-MM-dd",
			DateTimeStyles = DateTimeStyles.None,
			Culture = CultureInfo.InvariantCulture
		};
		var options = CreateOptions(converter);

		var result = JsonSerializer.Deserialize<DateTimeOffset>("\"2025-06-15\"", options);

		Assert.AreEqual(2025, result.Year);
		Assert.AreEqual(6, result.Month);
		Assert.AreEqual(15, result.Day);
	}

	[TestMethod]
	public void Read_EmptyString_ThrowsJsonException()
	{
		var converter = new IsoDateTimeOffsetConverter();
		var options = CreateOptions(converter);

		_ = Assert.ThrowsExactly<JsonException>(() =>
			JsonSerializer.Deserialize<DateTimeOffset>("\"\"", options));
	}

	[TestMethod]
	public void Read_InvalidDateString_ThrowsJsonException()
	{
		var converter = new IsoDateTimeOffsetConverter();
		var options = CreateOptions(converter);

		_ = Assert.ThrowsExactly<JsonException>(() =>
			JsonSerializer.Deserialize<DateTimeOffset>("\"not-a-date\"", options));
	}

	[TestMethod]
	public void Read_ValidIsoString_ReturnsCorrectDateTimeOffset()
	{
		var converter = new IsoDateTimeOffsetConverter();
		var expected = new DateTimeOffset(2025, 6, 15, 10, 30, 0, TimeSpan.Zero);
		var json = $"\"{expected:O}\"";
		var options = CreateOptions(converter);

		var result = JsonSerializer.Deserialize<DateTimeOffset>(json, options);

		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void RoundTrip_DefaultFormat_PreservesValue()
	{
		var converter = new IsoDateTimeOffsetConverter();
		var original = new DateTimeOffset(2025, 11, 28, 14, 45, 30, TimeSpan.FromHours(-5));
		var options = CreateOptions(converter);

		var json = JsonSerializer.Serialize(original, options);
		var deserialized = JsonSerializer.Deserialize<DateTimeOffset>(json, options);

		Assert.AreEqual(original, deserialized);
	}

	[TestMethod]
	public void RoundTrip_InvariantCulture_PreservesValue()
	{
		var converter = new IsoDateTimeOffsetConverter { Culture = CultureInfo.InvariantCulture };
		var original = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero);
		var options = CreateOptions(converter);

		var json = JsonSerializer.Serialize(original, options);
		var deserialized = JsonSerializer.Deserialize<DateTimeOffset>(json, options);

		Assert.AreEqual(original, deserialized);
	}

	[TestMethod]
	public void Singleton_IsNotNull()
	{
		Assert.IsNotNull(IsoDateTimeOffsetConverter.Singleton);
	}

	[TestMethod]
	public void Singleton_IsSameInstanceOnMultipleCalls()
	{
		var first = IsoDateTimeOffsetConverter.Singleton;
		var second = IsoDateTimeOffsetConverter.Singleton;

		Assert.AreSame(first, second);
	}

	[TestMethod]
	public void Write_AdjustToUniversalStyle_WritesUtcTime()
	{
		var offset = TimeSpan.FromHours(5);
		var value = new DateTimeOffset(2025, 6, 15, 15, 0, 0, offset); // 10:00 UTC
		var converter = new IsoDateTimeOffsetConverter
		{
			DateTimeStyles = DateTimeStyles.AdjustToUniversal,
			DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ssZ"
		};
		var options = CreateOptions(converter);

		var json = JsonSerializer.Serialize(value, options);

		Assert.IsTrue(json.Contains("10:00:00"), $"Expected UTC hour 10 in: {json}");
	}

	[TestMethod]
	public void Write_CustomFormat_UsesSpecifiedFormat()
	{
		var converter = new IsoDateTimeOffsetConverter { DateTimeFormat = "yyyy-MM-dd" };
		var value = new DateTimeOffset(2025, 6, 15, 10, 30, 0, TimeSpan.Zero);
		var options = CreateOptions(converter);

		var json = JsonSerializer.Serialize(value, options);

		Assert.AreEqual("\"2025-06-15\"", json);
	}

	[TestMethod]
	public void Write_DefaultFormat_ProducesIsoString()
	{
		var converter = new IsoDateTimeOffsetConverter();
		var value = new DateTimeOffset(2025, 6, 15, 10, 30, 0, TimeSpan.Zero);
		var options = CreateOptions(converter);

		var json = JsonSerializer.Serialize(value, options);

		// Must produce a quoted ISO string containing the date portion
		Assert.IsTrue(json.Contains("2025-06-15"), $"Unexpected JSON: {json}");
	}
	private static JsonSerializerOptions CreateOptions(IsoDateTimeOffsetConverter converter)
	{
		var options = new JsonSerializerOptions();
		options.Converters.Add(converter);
		return options;
	}
}
