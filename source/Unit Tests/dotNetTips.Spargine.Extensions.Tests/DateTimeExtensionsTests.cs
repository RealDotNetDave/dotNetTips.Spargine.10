// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="DateTimeExtensionsTests.cs" company="McCarter Consulting">
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
		var now = Clock.LocalTime;

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

		Assert.IsTrue(result.TotalMinutes <= 60);
	}

	/// <summary>
	/// Defines the test method DateTimeOffsetTimeUntilNextMinuteTest.
	/// </summary>
	[TestMethod]
	public void DateTimeOffsetTimeUntilNextMinuteTest()
	{
		var now = DateTimeOffset.Now;

		var result = now.TimeUntilNextMinute();

		Assert.IsTrue(result.TotalSeconds <= 60);
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

		Assert.IsTrue(result.TotalMinutes <= 60);
	}

	/// <summary>
	/// Defines the test method DateTimeTimeUntilNextMinuteTest.
	/// </summary>
	[TestMethod]
	public void DateTimeTimeUntilNextMinuteTest()
	{
		var now = Clock.LocalTime;

		var result = now.TimeUntilNextMinute();

		Assert.IsTrue(result.TotalSeconds <= 60);
	}

	/// <summary>
	/// Defines the test method DateTimeToFormattedStringTest.
	/// </summary>
	[TestMethod]
	public void DateTimeToFormattedStringTest()
	{
		var now = Clock.LocalTime;

		var result = now.ToFormattedString(DateTimeFormat.FullDateLongTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateLongTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.FullDateShortTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateShortTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.FullDateTime);

		//PrintResult(result, nameof(DateTimeFormat.FullDateTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.GeneralDateLongTime);

		//PrintResult(result, nameof(DateTimeFormat.GeneralDateLongTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.GeneralDateShortTime);

		//PrintResult(result, nameof(DateTimeFormat.GeneralDateShortTime));

		Assert.IsTrue(result.Length > 5);


		Assert.IsTrue(result.Length > 5);

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.LongDate);

		//PrintResult(result, nameof(DateTimeFormat.LongDate));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.LongTime);

		//PrintResult(result, nameof(DateTimeFormat.LongTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.MonthDay);

		//PrintResult(result, nameof(DateTimeFormat.MonthDay));

		Assert.IsTrue(result.Length > 4);

		result = now.ToFormattedString(DateTimeFormat.RFC1123);

		//PrintResult(result, nameof(DateTimeFormat.RFC1123));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.RoundTripDateTime);

		//PrintResult(result, nameof(DateTimeFormat.RoundTripDateTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.ShortDate);

		//PrintResult(result, nameof(DateTimeFormat.ShortDate));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.ShortTime);

		//PrintResult(result, nameof(DateTimeFormat.ShortTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.SortableDateTime);

		//PrintResult(result, nameof(DateTimeFormat.SortableDateTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.UniversalFullDateTime);

		//PrintResult(result, nameof(DateTimeFormat.UniversalFullDateTime));

		Assert.IsTrue(result.Length > 5);

		result = now.ToFormattedString(DateTimeFormat.MonthYear);

		//PrintResult(result, nameof(DateTimeFormat.MonthYear));

		Assert.IsTrue(result.Length > 5);
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

		Assert.IsTrue(result.DayOfWeek == DayOfWeek.Sunday);
	}

	/// <summary>
	/// Defines the test method GetNextDayOfWeekTest.
	/// </summary>
	[TestMethod]
	public void GetNextDayOfWeekTest()
	{
		var dateTime = DateTimeOffset.Parse("1/1/2020");

		var result = dateTime.GetNextDayOfWeek(DayOfWeek.Tuesday);

		Assert.IsTrue(result.DayOfWeek == DayOfWeek.Tuesday);
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
				Assert.IsTrue(week > 0);
			}
		}
	}

	[TestMethod]
	public void GetWeekOfTheYear_DateOnly_Works()
	{
		var date = new DateOnly(2024, 1, 1);
		var week = DateTimeExtensions.GetWeekOfTheYear(date);
		Assert.IsTrue(week > 0);
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
				Assert.IsTrue(week > 0);
			}
		}
	}

	[TestMethod]
	public void GetWeekOfTheYear_DateTime_Works()
	{
		var date = new DateTime(2024, 1, 1);
		var week = DateTimeExtensions.GetWeekOfTheYear(date);
		Assert.IsTrue(week > 0);
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
		var now = Clock.LocalTime;

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
	public void ToFriendlyDateString_CoversTodayAndYesterday()
	{
		var today = DateTime.Today.AddHours(10);
		var yesterday = DateTime.Today.AddDays(-1).AddHours(10);
		var other = DateTime.Today.AddDays(-3).AddHours(10);

		var strToday = today.ToFriendlyDateString();
		Assert.IsTrue(strToday.Contains("Today"));

		var strYesterday = yesterday.ToFriendlyDateString();
		Assert.IsTrue(strYesterday.Contains("Yesterday"));

		var strOther = other.ToFriendlyDateString();
		Assert.IsFalse(string.IsNullOrEmpty(strOther));
	}

	[TestMethod]
	public void ToFriendlyDateString_DateTimeOffset_CoversTodayAndYesterday()
	{
		var today = DateTimeOffset.Now.Date.AddHours(10);
		var yesterday = DateTimeOffset.Now.Date.AddDays(-1).AddHours(10);
		var other = DateTimeOffset.Now.Date.AddDays(-3).AddHours(10);

		var strToday = today.ToFriendlyDateString();
		Assert.IsTrue(strToday.Contains("Today"));

		var strYesterday = yesterday.ToFriendlyDateString();
		Assert.IsTrue(strYesterday.Contains("Yesterday"));

		var strOther = other.ToFriendlyDateString();
		Assert.IsFalse(string.IsNullOrEmpty(strOther));
	}

	/// <summary>
	/// Defines the test method ToFromMilliEpochTimeTest.
	/// </summary>
	[TestMethod]
	public void ToFromMilliEpochTimeTest()
	{
		var currentTime = Clock.LocalTime;
		var epochTime = currentTime.ToMilliEpochTime();

		//PrintResult(epochTime, nameof(this.ToFromMilliEpochTimeTest));

		Assert.IsTrue(epochTime > 0);

		// Test reverse
		var convertedTime = epochTime.FromMilliEpochTime();

		Assert.IsTrue(convertedTime >= currentTime.Subtract(new TimeSpan(0, 5, 0)));

		//PrintResult(convertedTime, nameof(this.ToFromMilliEpochTimeTest));
	}

}
