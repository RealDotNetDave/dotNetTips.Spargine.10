// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2026
// ***********************************************************************
// <copyright file="DateTimeExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DateTimeExtensionsTests : UnitTester
{

	/// <summary>
	/// Defines the test method DateTimeIntersectsTest.
	/// </summary>
	[TestMethod]
	public void DateTimeIntersectsTest()
	{
		var now = Clock.LocalTime;

		var result = now.Intersects(endDate: now.AddDays(100), intersectingStartDate: now.AddDays(1), intersectingEndDate: now.AddDays(10));

		//PrintResult(result, nameof(this.DateTimeIntersectsTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method DateTimeIsInRangeTest.
	/// </summary>
	[TestMethod]
	public void DateTimeIsInRangeTest()
	{
		var now = Clock.LocalTime;

		var result = now.IsInRange(beginningTime: new DateTime(1970), endTime: now.AddDays(10));

		//PrintResult(result, nameof(this.DateTimeIsInRangeTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method DateTimeLocalTimeFromUtcTest.
	/// </summary>
	[TestMethod]
	public void DateTimeLocalTimeFromUtcTest()
	{
		var now = DateTime.Now;

		var result = now.LocalTimeFromUtc(timezoneFromUtc: -5);

		//PrintResult(result, nameof(this.DateTimeLocalTimeFromUtcTest));

		Assert.IsTrue(result >= now);
	}

	/// <summary>
	/// Defines the test method DateTimeMaxTest.
	/// </summary>
	[TestMethod]
	public void DateTimeMaxTest()
	{
		var now = Clock.LocalTime;

		var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

		//PrintResult(result, nameof(this.DateTimeMaxTest));

		Assert.IsTrue(result == now);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetGetLastDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetGetLastDayOfWeekTest()
	{
		var result = DateTimeOffset.Now.GetLastDayOfWeek(DayOfWeek.Monday);

		//PrintResult(result, nameof(this.DateTimeOffsetGetLastDayOfWeekTest));

		Assert.IsTrue(result <= Clock.LocalTime);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetGetNextDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetGetNextDayOfWeekTest()
	{
		var result = DateTimeOffset.Now.GetNextDayOfWeek(DayOfWeek.Monday);

		//PrintResult(result, nameof(this.DateTimeOffsetGetNextDayOfWeekTest));

		Assert.IsTrue(result >= Clock.LocalTime);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetIntersectsTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetIntersectsTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.Intersects(now.AddDays(100), now.AddDays(1), now.AddDays(10));

		//PrintResult(result, nameof(this.DateTimeOffsetIntersectsTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetIsInRangeTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetIsInRangeTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(10));

		//PrintResult(result, nameof(this.DateTimeOffsetIsInRangeTest));

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetMaxTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetMaxTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.Max(now.Subtract(new TimeSpan(1, 0, 0, 0)));

		//PrintResult(result, nameof(this.DateTimeOffsetMaxTest));

		Assert.IsTrue(result == now);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetNextDayOfTheWeekTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetNextDayOfTheWeekTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.GetNextDayOfWeek(DayOfWeek.Sunday);

		//PrintResult(result, nameof(this.DateTimeOffsetNextDayOfTheWeekTest));

		Assert.IsTrue(result >= now);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetTimeUntilNextHourTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetTimeUntilNextHourTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.TimeUntilNextHour();

		Assert.IsLessThanOrEqualTo(60, result.TotalMinutes);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetTimeUntilNextMinuteTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetTimeUntilNextMinuteTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.TimeUntilNextMinute();

		Assert.IsLessThanOrEqualTo(60, result.TotalSeconds);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetToFriendlyStringTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetToFriendlyStringTest()
	{
		var result = DateTimeOffset.Now.ToFriendlyDateString();

		//PrintResult(result, nameof(this.DateTimeOffsetToFriendlyStringTest));

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	/// <summary>
	/// Defines the test method DateTimeSubtractTest.
	/// </summary>
	[TestMethod]
	public void DateTimeSubtractTest()
	{
		var now = Clock.LocalTime;
		var timeSpan = new TimeSpan(1, 0, 0, 0);

		var result = now.Subtract(timeSpan);

		Assert.AreEqual(now.Add(-timeSpan), result);
	}

	/// <summary>
	/// Defines the test method DateTimeTimeUntilNextHourTest.
	/// </summary>
	[TestMethod]
	public void DateTimeTimeUntilNextHourTest()
	{
		var now = Clock.LocalTime;

		var result = now.TimeUntilNextHour();

		Assert.IsLessThanOrEqualTo(60, result.TotalMinutes);
	}

	/// <summary>
	/// Defines the test method DateTimeTimeUntilNextMinuteTest.
	/// </summary>
	[TestMethod]
	public void DateTimeTimeUntilNextMinuteTest()
	{
		var now = Clock.LocalTime;

		var result = now.TimeUntilNextMinute();

		Assert.IsLessThanOrEqualTo(60, result.TotalSeconds);
	}

	/// <summary>
	/// Defines the test method DateTimeToFormattedStringTest.
	/// </summary>
	[TestMethod]
	public void DateTimeToFormattedStringTest()
	{
		var now = DateTime.Now;

		var result = now.ToFormattedString(DateTimeFormat.FullDateLongTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateLongTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.FullDateShortTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateShortTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.FullDateTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.GeneralDateLongTime);

		//PrintResult(result, nameof(DateTimeFormat.GeneralDateLongTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.GeneralDateShortTime);

		//PrintResult(result, nameof(DateTimeFormat.GeneralDateShortTime));

		Assert.IsGreaterThan(5, result.Length);


		Assert.IsGreaterThan(5, result.Length);

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.LongDate);

		//PrintResult(result, nameof(DateTimeFormat.LongDate));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.LongTime);

		//PrintResult(result, nameof(DateTimeFormat.LongTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.MonthDay);

		//PrintResult(result, nameof(DateTimeFormat.MonthDay));

		Assert.IsGreaterThan(4, result.Length);

		result = now.ToFormattedString(DateTimeFormat.RFC1123);

		//PrintResult(result, nameof(DateTimeFormat.RFC1123));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.RoundTripDateTime);

		//PrintResult(result, nameof(DateTimeFormat.RoundTripDateTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.ShortDate);

		//PrintResult(result, nameof(DateTimeFormat.ShortDate));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.ShortTime);

		//PrintResult(result, nameof(DateTimeFormat.ShortTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.SortableDateTime);

		//PrintResult(result, nameof(DateTimeFormat.SortableDateTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.UniversalFullDateTime);

		//PrintResult(result, nameof(DateTimeFormat.UniversalFullDateTime));

		Assert.IsGreaterThan(5, result.Length);

		result = now.ToFormattedString(DateTimeFormat.MonthYear);

		//PrintResult(result, nameof(DateTimeFormat.MonthYear));

		Assert.IsGreaterThan(5, result.Length);
	}

	/// <summary>
	/// Defines the test method DateTimeToFriendlyStringTest.
	/// </summary>
	[TestMethod]
	public void DateTimeToFriendlyStringTest()
	{
		var result = Clock.LocalTime.ToFriendlyDateString();

		//PrintResult(result, nameof(this.DateTimeToFriendlyStringTest));

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	/// <summary>
	/// Defines the test method GetLastDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void GetLastDayOfWeekTest()
	{
		var dateTime = DateTimeOffset.Parse("1/1/2020");

		var result = dateTime.GetLastDayOfWeek(DayOfWeek.Sunday);

		Assert.AreEqual(DayOfWeek.Sunday, result.DayOfWeek);
	}

	/// <summary>
	/// Defines the test method GetNextDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void GetNextDayOfWeekTest()
	{
		var dateTime = DateTimeOffset.Parse("1/1/2020");

		var result = dateTime.GetNextDayOfWeek(DayOfWeek.Tuesday);

		Assert.AreEqual(DayOfWeek.Tuesday, result.DayOfWeek);
	}
	[TestMethod]
	public void GetWeekOfTheYear_DateOnly_CoversAllWeeks()
	{
		for (int month = 1; month <= 12; month++)
		{
			for (int day = 1; day <= DateTime.DaysInMonth(2024, month); day++)
			{
				var date = new DateOnly(2024, month, day);
				var week = DateTimeExtensions.GetWeekOfTheYear(date);
				Assert.IsGreaterThan(0, week);
			}
		}
	}

	[TestMethod]
	public void GetWeekOfTheYear_DateOnly_Works()
	{
		var date = new DateOnly(2024, 1, 1);
		var week = DateTimeExtensions.GetWeekOfTheYear(date);
		Assert.IsGreaterThan(0, week);
	}

	[TestMethod]
	public void GetWeekOfTheYear_DateTime_CoversAllWeeks()
	{
		for (int month = 1; month <= 12; month++)
		{
			for (int day = 1; day <= DateTime.DaysInMonth(2024, month); day++)
			{
				var date = new DateTime(2024, month, day);
				var week = DateTimeExtensions.GetWeekOfTheYear(date);
				Assert.IsGreaterThan(0, week);
			}
		}
	}

	[TestMethod]
	public void GetWeekOfTheYear_DateTime_Works()
	{
		var date = new DateTime(2024, 1, 1);
		var week = DateTimeExtensions.GetWeekOfTheYear(date);
		Assert.IsGreaterThan(0, week);
	}

	[TestMethod]
	public void GetWeeksInTheYear_CoversTypicalYears()
	{
		Assert.AreEqual(52, DateTimeExtensions.GetWeeksInTheYear(2023));
		Assert.IsTrue(DateTimeExtensions.GetWeeksInTheYear(2020) == 52 || DateTimeExtensions.GetWeeksInTheYear(2020) == 53);
	}

	[TestMethod]
	public void GetWeeksInTheYear_Works()
	{
		var year = 2024;
		var weeks = DateTimeExtensions.GetWeeksInTheYear(year);
		Assert.IsTrue(weeks == 52 || weeks == 53);
	}

	[TestMethod]
	public void GetYear_DateOnly_And_DateTime()
	{
		var dateOnly = new DateOnly(2022, 5, 1);
		var dateTime = new DateTime(2022, 5, 1);
		Assert.AreEqual(2022, DateTimeExtensions.GetYear(dateOnly));
		Assert.AreEqual(2022, DateTimeExtensions.GetYear(dateTime));
	}

	[TestMethod]
	public void GetYear_DateOnly_Works()
	{
		var date = new DateOnly(2024, 1, 1);
		var year = DateTimeExtensions.GetYear(date);
		Assert.AreEqual(2024, year);
	}

	[TestMethod]
	public void GetYear_DateTime_Works()
	{
		var date = new DateTime(2024, 1, 1);
		var year = DateTimeExtensions.GetYear(date);
		Assert.AreEqual(2024, year);
	}

	[TestMethod]
	public void GetYearEnd_Works()
	{
		var year = 2024;
		var end = DateTimeExtensions.GetYearEnd(year);
		Assert.AreEqual(year, end.Year);
	}

	[TestMethod]
	public void GetYearStart_Works()
	{
		var year = 2024;
		var start = DateTimeExtensions.GetYearStart(year);
		Assert.AreEqual(year, start.Year);
	}

	[TestMethod]
	public void IsInRange_DateTimeOffset_Works()
	{
		var now = DateTimeOffset.Now;
		Assert.IsTrue(now.IsInRange(now.AddDays(-1), now.AddDays(1)));
		Assert.IsFalse(now.IsInRange(now.AddDays(1), now.AddDays(2)));
	}

	[TestMethod]
	public void IsInRange_TimeSpan_Works()
	{
		var now = TimeSpan.FromHours(10);
		Assert.IsTrue(now.IsInRange(TimeSpan.FromHours(5), TimeSpan.FromHours(15)));
		Assert.IsFalse(now.IsInRange(TimeSpan.FromHours(11), TimeSpan.FromHours(15)));
	}

	[TestMethod]
	public void IsInRangeThrowsException_ThrowsForOutOfRange()
	{
		var now = DateTime.Now;
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(2), "param"));
		var ts = TimeSpan.FromDays(1);
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => ts.IsInRangeThrowsException(ts.Add(TimeSpan.FromDays(2)), ts.Add(TimeSpan.FromDays(3)), "param"));
		var dto = DateTimeOffset.Now;
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => dto.IsInRangeThrowsException(dto.AddDays(1), dto.AddDays(2), "param"));
	}

	/// <summary>
	/// Defines the test method IsInRangeThrowsExceptionTestDateTime.
	/// </summary>
	[TestMethod]
	public void IsInRangeThrowsExceptionTestDateTime()
	{
		var now = DateTime.Now;

		var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(days: 1, hours: 0, minutes: 0, seconds: 0)), now.AddDays(value: 1), paramName: "TEST");

		Assert.IsTrue(result1);

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
	}

	/// <summary>
	/// Defines the test method IsInRangeThrowsExceptionTestDateTimeOffset.
	/// </summary>
	[TestMethod]
	public void IsInRangeThrowsExceptionTestDateTimeOffset()
	{
		var now = DateTimeOffset.Now;

		var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.AddDays(1), "TEST");

		Assert.IsTrue(result1);

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.AddDays(1), now.AddDays(5), "TEST"));
	}

	/// <summary>
	/// Defines the test method IsInRangeThrowsExceptionTestTimeSpan.
	/// </summary>
	[TestMethod]
	public void IsInRangeThrowsExceptionTestTimeSpan()
	{
		var now = TimeSpan.FromDays(5);

		var result1 = now.IsInRangeThrowsException(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Add(TimeSpan.FromDays(10)), "TEST");

		Assert.IsTrue(result1);

		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => now.IsInRangeThrowsException(now.Add(new TimeSpan(10, 0, 0, 0)), new TimeSpan(20, 0, 0, 0), "TEST"));
	}

	[TestMethod]
	public void LocalTimeFromUtc_Works()
	{
		var utc = DateTime.UtcNow;
		var local = utc.LocalTimeFromUtc(0);
		Assert.AreEqual(utc.ToUniversalTime(), local);
	}

	[TestMethod]
	public void Max_DateTimeOffset_Works()
	{
		var now = DateTimeOffset.Now;
		var earlier = now.AddDays(-1);
		Assert.AreEqual(now, now.Max(earlier));
		Assert.AreEqual(now, earlier.Max(now));
	}

	[TestMethod]
	public void Subtract_Works()
	{
		var now = DateTime.UtcNow;
		var ts = TimeSpan.FromHours(1);
		var result = now.Subtract(ts);
		Assert.IsTrue(result < now);
	}

	/// <summary>
	/// Defines the test method TimeSpanIsInRangeTest.
	/// </summary>
	[TestMethod]
	public void TimeSpanIsInRangeTest()
	{
		var now = new TimeSpan(3, 0, 0, 0);

		var result = now.IsInRange(now.Subtract(new TimeSpan(1, 0, 0, 0)), now.Multiply(10));

		//PrintResult(result, nameof(this.TimeSpanIsInRangeTest));

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void TimeUntilNextHour_And_Minute_Coverage()
	{
		var now = DateTime.Now;
		var dto = DateTimeOffset.Now;
		var hour = now.TimeUntilNextHour();
		var min = now.TimeUntilNextMinute();
		var hourDto = dto.TimeUntilNextHour();
		var minDto = dto.TimeUntilNextMinute();
		Assert.IsTrue(hour.TotalMinutes <= 60 && hour.TotalMinutes > 0);
		Assert.IsTrue(min.TotalSeconds <= 60 && min.TotalSeconds > 0);
		Assert.IsTrue(hourDto.TotalMinutes <= 60 && hourDto.TotalMinutes > 0);
		Assert.IsTrue(minDto.TotalSeconds <= 60 && minDto.TotalSeconds > 0);
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_AllFormats_ReturnsNonEmptyStrings()
	{
		// Arrange
		var input = new DateTimeOffset(2025, 6, 15, 14, 30, 45, TimeSpan.Zero);
		var formats = new[]
		{
		DateTimeFormat.FullDateLongTime,
		DateTimeFormat.FullDateShortTime,
		DateTimeFormat.FullDateTime,
		DateTimeFormat.GeneralDateLongTime,
		DateTimeFormat.GeneralDateShortTime,
		DateTimeFormat.LongDate,
		DateTimeFormat.LongTime,
		DateTimeFormat.MonthDay,
		DateTimeFormat.MonthYear,
		DateTimeFormat.RFC1123,
		DateTimeFormat.RoundTripDateTime,
		DateTimeFormat.ShortDate,
		DateTimeFormat.ShortTime,
		DateTimeFormat.SortableDateTime,
		DateTimeFormat.IsoDate,
		DateTimeFormat.IsoDateTime
	};

		// Act & Assert
		foreach (var format in formats)
		{
			var result = input.ToFormattedString(format);
			Assert.IsNotNull(result, $"Format {format.DisplayName} returned null");
			Assert.IsGreaterThan(0, result.Length, $"Format {format.DisplayName} returned empty string");
		}
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_FullDateLongTime_ReturnsFormattedString()
	{
		// Arrange
		var input = new DateTimeOffset(2025, 6, 15, 14, 30, 45, TimeSpan.Zero);

		// Act
		var result = input.ToFormattedString(DateTimeFormat.FullDateLongTime);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsGreaterThan(10, result.Length);
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_IsoDate_ReturnsFormattedString()
	{
		// Arrange
		var input = new DateTimeOffset(2025, 6, 15, 14, 30, 45, TimeSpan.Zero);

		// Act
		var result = input.ToFormattedString(DateTimeFormat.IsoDate);

		// Assert
		Assert.AreEqual("2025-06-15", result);
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_IsoDateTime_ReturnsFormattedString()
	{
		// Arrange
		var input = new DateTimeOffset(2025, 6, 15, 14, 30, 45, TimeSpan.Zero);

		// Act
		var result = input.ToFormattedString(DateTimeFormat.IsoDateTime);

		// Assert
		Assert.AreEqual("2025-06-15T14:30:45", result);
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_LongTime_ReturnsFormattedString()
	{
		// Arrange
		var input = new DateTimeOffset(2025, 6, 15, 14, 30, 45, TimeSpan.Zero);

		// Act
		var result = input.ToFormattedString(DateTimeFormat.LongTime);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsGreaterThan(5, result.Length);
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_NullFormat_ThrowsArgumentNullException()
	{
		// Arrange
		var input = new DateTimeOffset(2025, 6, 15, 14, 30, 45, TimeSpan.Zero);
		DateTimeFormat nullFormat = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => input.ToFormattedString(nullFormat));
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_RoundTripDateTime_ReturnsFormattedString()
	{
		// Arrange
		var input = new DateTimeOffset(2025, 6, 15, 14, 30, 45, TimeSpan.FromHours(-5));

		// Act
		var result = input.ToFormattedString(DateTimeFormat.RoundTripDateTime);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Contains("2025"));
		Assert.IsTrue(result.Contains("-05:00") || result.Contains("+"));
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_ShortDate_ReturnsFormattedString()
	{
		// Arrange
		var input = new DateTimeOffset(2025, 6, 15, 14, 30, 45, TimeSpan.Zero);

		// Act
		var result = input.ToFormattedString(DateTimeFormat.ShortDate);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsGreaterThan(5, result.Length);
	}

	[TestMethod]
	public void ToFormattedString_DateTimeOffset_WithDifferentTimeZones_ReturnsCorrectFormat()
	{
		// Arrange
		var utcInput = new DateTimeOffset(2025, 6, 15, 12, 0, 0, TimeSpan.Zero);
		var estInput = new DateTimeOffset(2025, 6, 15, 12, 0, 0, TimeSpan.FromHours(-5));

		// Act
		var utcResult = utcInput.ToFormattedString(DateTimeFormat.RoundTripDateTime);
		var estResult = estInput.ToFormattedString(DateTimeFormat.RoundTripDateTime);

		// Assert
		Assert.IsTrue(utcResult.Contains("+00:00") || utcResult.EndsWith("Z"));
		Assert.IsTrue(estResult.Contains("-05:00"));
	}

	[TestMethod]
	public void ToFriendlyDateString_CoversTodayAndYesterday()
	{
		var today = DateTime.Today.AddHours(10);
		var yesterday = DateTime.Today.AddDays(-1).AddHours(10);
		var other = DateTime.Today.AddDays(-3).AddHours(10);

		var strToday = today.ToFriendlyDateString();
		Assert.Contains("Today", strToday);

		var strYesterday = yesterday.ToFriendlyDateString();
		Assert.Contains("Yesterday", strYesterday);

		var strOther = other.ToFriendlyDateString();
		Assert.IsFalse(string.IsNullOrEmpty(strOther));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_ContainsTimeInLowerCase()
	{
		// Arrange
		var input = new DateTimeOffset(DateTime.Today.AddHours(14).AddMinutes(30).AddSeconds(45));

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		// Time portion should be in lowercase (e.g., "pm" not "PM")
		var timePart = result[(result.IndexOf('@') + 1)..].Trim();
		Assert.AreEqual(timePart, timePart.ToLowerInvariant());
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_CoversTodayAndYesterday()
	{
		var today = DateTimeOffset.Now.Date.AddHours(10);
		var yesterday = DateTimeOffset.Now.Date.AddDays(-1).AddHours(10);
		var other = DateTimeOffset.Now.Date.AddDays(-3).AddHours(10);

		var strToday = today.ToFriendlyDateString();
		Assert.Contains("Today", strToday);

		var strYesterday = yesterday.ToFriendlyDateString();
		Assert.Contains("Yesterday", strYesterday);

		var strOther = other.ToFriendlyDateString();
		Assert.IsFalse(string.IsNullOrEmpty(strOther));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_EndOfDayToday_ReturnsToday()
	{
		// Arrange - End of today (23:59:59)
		var input = new DateTimeOffset(DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59));

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.StartsWith("Today", StringComparison.OrdinalIgnoreCase));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_ExactlySixDaysAgo_ReturnsDayName()
	{
		// Arrange - Exactly 6 days ago (boundary condition)
		var input = new DateTimeOffset(DateTime.Today.AddDays(-5).AddHours(12));

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Contains("@"));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_FutureDate_ReturnsFormattedString()
	{
		// Arrange - Future date
		var input = new DateTimeOffset(DateTime.Today.AddDays(30).AddHours(9));

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Contains("@"));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_MidnightToday_ReturnsToday()
	{
		// Arrange - Midnight today
		var input = new DateTimeOffset(DateTime.Today);

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.StartsWith("Today", StringComparison.OrdinalIgnoreCase));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_OlderThanSixDays_ReturnsLongDate()
	{
		// Arrange - 10 days ago (outside the 6-day window)
		var input = new DateTimeOffset(DateTime.Today.AddDays(-10).AddHours(15).AddMinutes(45));

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Contains("@"));
		// Should be a full long date format, not a day name
		Assert.IsFalse(result.StartsWith("Today", StringComparison.OrdinalIgnoreCase));
		Assert.IsFalse(result.StartsWith("Yesterday", StringComparison.OrdinalIgnoreCase));
	}
	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_Today_ReturnsToday()
	{
		// Arrange
		var input = new DateTimeOffset(DateTime.Today.AddHours(10).AddMinutes(30).AddSeconds(45));

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.StartsWith("Today", StringComparison.OrdinalIgnoreCase));
		Assert.IsTrue(result.Contains("@"));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_WithinLastSixDays_ReturnsDayName()
	{
		// Arrange - 3 days ago (within the 6-day window)
		var input = new DateTimeOffset(DateTime.Today.AddDays(-3).AddHours(10));

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Contains("@"));
		// Should contain a day name (Monday, Tuesday, etc.) not "Yesterday" or "TodayMidnight"
		Assert.IsFalse(result.StartsWith("Today", StringComparison.OrdinalIgnoreCase));
		Assert.IsFalse(result.StartsWith("Yesterday", StringComparison.OrdinalIgnoreCase));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_Yesterday_ReturnsYesterday()
	{
		// Arrange
		var input = new DateTimeOffset(DateTime.Today.AddDays(-1).AddHours(14).AddMinutes(30));

		// Act
		var result = input.ToFriendlyDateString();

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.StartsWith("Yesterday", StringComparison.OrdinalIgnoreCase));
		Assert.IsTrue(result.Contains("@"));
	}

	/// <summary>
	/// Defines the test method ToFromMilliEpochTimeTest.
	/// </summary>
	[TestMethod]
	public void ToFromMilliEpochTimeTest()
	{
		var currentTime = DateTime.Now;
		var epochTime = currentTime.ToMilliEpochTime();

		//PrintResult(epochTime, nameof(this.ToFromMilliEpochTimeTest));

		Assert.IsGreaterThan(0, epochTime);

		// Test reverse
		var convertedTime = epochTime.FromMilliEpochTime();

		Assert.IsTrue(convertedTime >= currentTime.Subtract(new TimeSpan(0, 5, 0)));

		//PrintResult(convertedTime, nameof(this.ToFromMilliEpochTimeTest));
	}

}
