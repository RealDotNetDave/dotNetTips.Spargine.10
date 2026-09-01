// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-31-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-14-2026
// ***********************************************************************
// <copyright file="ClockTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Devices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Devices;

[ExcludeFromCodeCoverage]
[TestClass]
public class ClockTests
{

	[TestMethod]
	public void CurrentDayOfWeek_MatchesLocalTimeDayOfWeek()
	{
		// Act
		var result = Clock.CurrentDayOfWeek;

		// Assert
		Assert.AreEqual(Clock.LocalTime.DayOfWeek, result);
	}

	[TestMethod]
	public void CurrentDayOfWeek_ReturnsValidDayOfWeek()
	{
		// Act
		var result = Clock.CurrentDayOfWeek;

		// Assert
		Assert.IsTrue(Enum.IsDefined(typeof(DayOfWeek), result));
	}

	[TestMethod]
	public void CurrentDayOfYear_MatchesLocalTimeDayOfYear()
	{
		// Act
		var result = Clock.CurrentDayOfYear;

		// Assert
		Assert.AreEqual(Clock.LocalTime.DayOfYear, result);
	}

	[TestMethod]
	public void CurrentDayOfYear_ReturnsValidRange()
	{
		// Act
		var result = Clock.CurrentDayOfYear;

		// Assert
		Assert.IsTrue(result >= 1 && result <= 366);
	}

	[TestMethod]
	public void CurrentQuarter_ReturnsCorrectQuarter()
	{
		// Arrange
		var localTime = Clock.LocalTime;
		var expectedQuarter = ((localTime.Month - 1) / 3) + 1;

		// Act
		var result = Clock.CurrentQuarter;

		// Assert
		Assert.AreEqual(expectedQuarter, result);
	}

	[TestMethod]
	public void CurrentQuarter_ReturnsValidRange()
	{
		// Act
		var result = Clock.CurrentQuarter;

		// Assert
		Assert.IsTrue(result >= 1 && result <= 4);
	}

	[TestMethod]
	public void CurrentUtcDayOfWeek_MatchesUtcTimeDayOfWeek()
	{
		// Act
		var result = Clock.CurrentUtcDayOfWeek;

		// Assert
		Assert.AreEqual(Clock.UtcTime.DayOfWeek, result);
	}

	[TestMethod]
	public void CurrentUtcDayOfWeek_ReturnsValidDayOfWeek()
	{
		// Act
		var result = Clock.CurrentUtcDayOfWeek;

		// Assert
		Assert.IsTrue(Enum.IsDefined(typeof(DayOfWeek), result));
	}

	[TestMethod]
	public void CurrentUtcQuarter_ReturnsCorrectQuarter()
	{
		// Arrange
		var utcTime = Clock.UtcTime;
		var expectedQuarter = ((utcTime.Month - 1) / 3) + 1;

		// Act
		var result = Clock.CurrentUtcQuarter;

		// Assert
		Assert.AreEqual(expectedQuarter, result);
	}

	[TestMethod]
	public void CurrentUtcQuarter_ReturnsValidRange()
	{
		// Act
		var result = Clock.CurrentUtcQuarter;

		// Assert
		Assert.IsTrue(result >= 1 && result <= 4);
	}

	[TestMethod]
	public void DaysInCurrentMonth_MatchesDateTimeDaysInMonth()
	{
		// Arrange
		var now = DateTime.Now;
		var expected = DateTime.DaysInMonth(now.Year, now.Month);

		// Act
		var result = Clock.DaysInCurrentMonth;

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void DaysInCurrentMonth_ReturnsValidRange()
	{
		// Act
		var result = Clock.DaysInCurrentMonth;

		// Assert
		Assert.IsTrue(result >= 28 && result <= 31);
	}

	[TestMethod]
	public void DaysInCurrentUtcMonth_MatchesDateTimeDaysInMonth()
	{
		// Arrange
		var utcNow = DateTime.UtcNow;
		var expected = DateTime.DaysInMonth(utcNow.Year, utcNow.Month);

		// Act
		var result = Clock.DaysInCurrentUtcMonth;

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void DaysInCurrentUtcMonth_ReturnsValidRange()
	{
		// Act
		var result = Clock.DaysInCurrentUtcMonth;

		// Assert
		Assert.IsTrue(result >= 28 && result <= 31);
	}

	[TestMethod]
	public void DaysInMonth_April_Returns30()
	{
		// Arrange
		var year = 2026;
		var month = 4;

		// Act
		var result = Clock.DaysInMonth(year, month);

		// Assert
		Assert.AreEqual(30, result);
	}

	[TestMethod]
	public void DaysInMonth_December_Returns31()
	{
		// Arrange
		var year = 2026;
		var month = 12;

		// Act
		var result = Clock.DaysInMonth(year, month);

		// Assert
		Assert.AreEqual(31, result);
	}

	[TestMethod]
	public void DaysInMonth_January_Returns31()
	{
		// Arrange
		var year = 2026;
		var month = 1;

		// Act
		var result = Clock.DaysInMonth(year, month);

		// Assert
		Assert.AreEqual(31, result);
	}

	[TestMethod]
	public void DaysInMonth_June_Returns30()
	{
		// Arrange
		var year = 2026;
		var month = 6;

		// Act
		var result = Clock.DaysInMonth(year, month);

		// Assert
		Assert.AreEqual(30, result);
	}

	[TestMethod]
	public void DaysInMonth_NonLeapYearFebruary_Returns28()
	{
		// Arrange
		var year = 2023;
		var month = 2;

		// Act
		var result = Clock.DaysInMonth(year, month);

		// Assert
		Assert.AreEqual(28, result);
	}

	[TestMethod]
	public void DaysInMonth_ValidInput_ReturnsCorrectDays()
	{
		// Arrange
		var year = 2024;
		var month = 2;

		// Act
		var result = Clock.DaysInMonth(year, month);

		// Assert
		Assert.AreEqual(29, result); // 2024 is a leap year
	}

	[TestMethod]
	public void DaysRemainingInMonth_ReturnsCorrectValue()
	{
		// Arrange
		var expected = Clock.DaysInCurrentMonth - Clock.LocalTime.Day;

		// Act
		var result = Clock.DaysRemainingInMonth;

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void DaysRemainingInMonth_IsLessThanDaysInMonth()
	{
		// Act
		var result = Clock.DaysRemainingInMonth;

		// Assert
		Assert.IsTrue(result < Clock.DaysInCurrentMonth);
	}

	[TestMethod]
	public void DaysRemainingInMonth_ReturnsNonNegativeValue()
	{
		// Act
		var result = Clock.DaysRemainingInMonth;

		// Assert
		Assert.IsTrue(result >= 0);
	}

	[TestMethod]
	public void DaysRemainingInYear_ReturnsCorrectValue()
	{
		// Arrange
		var localTime = Clock.LocalTime;
		var expected = (new DateTime(localTime.Year, 12, 31) - localTime.Date).Days;

		// Act
		var result = Clock.DaysRemainingInYear;

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void DaysRemainingInYear_ReturnsNonNegativeValue()
	{
		// Act
		var result = Clock.DaysRemainingInYear;

		// Assert
		Assert.IsTrue(result >= 0);
	}

	[TestMethod]
	public void DaysRemainingInYear_ReturnsValidRange()
	{
		// Act
		var result = Clock.DaysRemainingInYear;

		// Assert
		Assert.IsTrue(result <= 366);
	}

	[TestMethod]
	public void FirstDayOfCurrentMonth_HasLocalTimeOffset()
	{
		// Act
		var result = Clock.FirstDayOfCurrentMonth;

		// Assert
		Assert.AreEqual(Clock.LocalTime.Offset, result.Offset);
	}

	[TestMethod]
	public void FirstDayOfCurrentMonth_ReturnsFirstDayAtMidnight()
	{
		// Act
		var result = Clock.FirstDayOfCurrentMonth;

		// Assert
		Assert.AreEqual(1, result.Day);
		Assert.AreEqual(0, result.Hour);
		Assert.AreEqual(0, result.Minute);
		Assert.AreEqual(0, result.Second);
		Assert.AreEqual(Clock.LocalTime.Month, result.Month);
		Assert.AreEqual(Clock.LocalTime.Year, result.Year);
	}

	[TestMethod]
	public void IsCurrentUtcYearLeapYear_ReturnsBoolean()
	{
		// Arrange
		var expected = DateTime.IsLeapYear(Clock.UtcTime.Year);

		// Act
		var result = Clock.IsCurrentUtcYearLeapYear;

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void IsCurrentYearLeapYear_ReturnsBoolean()
	{
		// Arrange
		var expected = DateTime.IsLeapYear(Clock.LocalTime.Year);

		// Act
		var result = Clock.IsCurrentYearLeapYear;

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void IsLeapYear_CenturyLeapYear_ReturnsTrue()
	{
		// Arrange
		var year = 2000;

		// Act
		var result = Clock.IsLeapYear(year);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsLeapYear_CenturyNonLeapYear_ReturnsFalse()
	{
		// Arrange
		var year = 1900;

		// Act
		var result = Clock.IsLeapYear(year);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsLeapYear_LeapYear_ReturnsTrue()
	{
		// Arrange
		var year = 2024;

		// Act
		var result = Clock.IsLeapYear(year);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsLeapYear_NonLeapYear_ReturnsFalse()
	{
		// Arrange
		var year = 2023;

		// Act
		var result = Clock.IsLeapYear(year);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsWeekday_InverseOfIsWeekend()
	{
		// Act
		var isWeekday = Clock.IsWeekday;
		var isWeekend = Clock.IsWeekend;

		// Assert
		Assert.AreNotEqual(isWeekday, isWeekend);
	}

	[TestMethod]
	public void IsWeekend_SaturdayOrSunday_ReturnsCorrectValue()
	{
		// Arrange
		var dayOfWeek = Clock.CurrentDayOfWeek;
		var expected = dayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

		// Act
		var result = Clock.IsWeekend;

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void LastDayOfCurrentMonth_HasLocalTimeOffset()
	{
		// Act
		var result = Clock.LastDayOfCurrentMonth;

		// Assert
		Assert.AreEqual(Clock.LocalTime.Offset, result.Offset);
	}

	[TestMethod]
	public void LastDayOfCurrentMonth_ReturnsLastDayAtMidnight()
	{
		// Act
		var result = Clock.LastDayOfCurrentMonth;

		// Assert
		Assert.AreEqual(Clock.DaysInCurrentMonth, result.Day);
		Assert.AreEqual(0, result.Hour);
		Assert.AreEqual(0, result.Minute);
		Assert.AreEqual(0, result.Second);
		Assert.AreEqual(Clock.LocalTime.Month, result.Month);
		Assert.AreEqual(Clock.LocalTime.Year, result.Year);
	}

	[TestMethod]
	public void LocalTime_ReturnsCurrentLocalTime()
	{
		// Arrange
		var before = DateTimeOffset.Now;

		// Act
		var result = Clock.LocalTime;

		// Assert
		var after = DateTimeOffset.Now;
		Assert.IsTrue(result >= before && result <= after);
	}

	[TestMethod]
	public void LocalUtcOffset_MatchesLocalTimeOffset()
	{
		// Arrange
		var expected = Clock.LocalTime.Offset;

		// Act
		var result = Clock.LocalUtcOffset;

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void LocalUtcOffset_ReturnsValidOffset()
	{
		// Act
		var result = Clock.LocalUtcOffset;

		// Assert
		Assert.IsTrue(result >= TimeSpan.FromHours(-12) && result <= TimeSpan.FromHours(14));
	}

	[TestMethod]
	public void StartOfToday_ReturnsCurrentDate()
	{
		// Arrange
		var localTime = Clock.LocalTime;

		// Act
		var result = Clock.StartOfToday;

		// Assert
		Assert.AreEqual(localTime.Year, result.Year);
		Assert.AreEqual(localTime.Month, result.Month);
		Assert.AreEqual(localTime.Day, result.Day);
	}

	[TestMethod]
	public void TickCount_Increments()
	{
		// Arrange
		var first = Clock.TickCount;
		System.Threading.Thread.Sleep(500);

		// Act
		var second = Clock.TickCount;

		// Assert
		Assert.IsTrue(second > first || second < 0); // Handles wrap-around
	}

	[TestMethod]
	public void TickCount_ReturnsPositiveValue()
	{
		// Act
		var result = Clock.TickCount;

		// Assert
		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void TickCount64_Increments()
	{
		// Arrange
		var first = Clock.TickCount64;
		System.Threading.Thread.Sleep(10);

		// Act
		var second = Clock.TickCount64;

		// Assert
		Assert.IsTrue(second > first);
	}

	[TestMethod]
	public void TickCount64_ReturnsPositiveValue()
	{
		// Act
		var result = Clock.TickCount64;

		// Assert
		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void TodayMidnight_ReturnsMidnight()
	{
		// Act
		var result = Clock.StartOfToday;

		// Assert
		Assert.AreEqual(0, result.Hour);
		Assert.AreEqual(0, result.Minute);
		Assert.AreEqual(0, result.Second);
		Assert.AreEqual(0, result.Millisecond);
	}

	[TestMethod]
	public void UnixTimestamp_ReturnsPositiveValue()
	{
		// Act
		var result = Clock.UnixTimestamp;

		// Assert
		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void UnixTimestamp_ReturnsReasonableValue()
	{
		// Arrange - Unix timestamp for Jan 1, 2020 and Jan 1, 2030
		var minTimestamp = 1577836800L; // 2020-01-01
		var maxTimestamp = 1893456000L; // 2030-01-01

		// Act
		var result = Clock.UnixTimestamp;

		// Assert
		Assert.IsTrue(result >= minTimestamp && result <= maxTimestamp);
	}

	[TestMethod]
	public void UnixTimestampMilliseconds_GreaterThanSeconds()
	{
		// Arrange
		var unixSeconds = Clock.UnixTimestamp;

		// Act
		var unixMilliseconds = Clock.UnixTimestampMilliseconds;

		// Assert
		Assert.IsTrue(unixMilliseconds >= unixSeconds * 1000);
		Assert.IsTrue(unixMilliseconds < (unixSeconds + 2) * 1000); // Within 2 seconds
	}

	[TestMethod]
	public void UnixTimestampMilliseconds_ReturnsPositiveValue()
	{
		// Act
		var result = Clock.UnixTimestampMilliseconds;

		// Assert
		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void UnixTimestampMilliseconds_ReturnsReasonableValue()
	{
		// Arrange - Unix timestamp in milliseconds for Jan 1, 2020 and Jan 1, 2030
		var minTimestamp = 1577836800000L; // 2020-01-01
		var maxTimestamp = 1893456000000L; // 2030-01-01

		// Act
		var result = Clock.UnixTimestampMilliseconds;

		// Assert
		Assert.IsTrue(result >= minTimestamp && result <= maxTimestamp);
	}

	[TestMethod]
	public void UtcTime_HasZeroOffset()
	{
		// Act
		var result = Clock.UtcTime;

		// Assert
		Assert.AreEqual(TimeSpan.Zero, result.Offset);
	}

	[TestMethod]
	public void UtcTime_ReturnsCurrentUtcTime()
	{
		// Arrange
		var before = DateTimeOffset.UtcNow;

		// Act
		var result = Clock.UtcTime;

		// Assert
		var after = DateTimeOffset.UtcNow;
		Assert.IsTrue(result >= before && result <= after);
		Assert.AreEqual(TimeSpan.Zero, result.Offset);
	}

}
