// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="DateTimeExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>
// Extension methods for <see cref="System.DateTime"/>, <see cref="System.DateTimeOffset"/>,
// <see cref="System.DateOnly"/>, <see cref="System.TimeSpan"/>, and <see cref="int"/> providing
// date/time arithmetic and formatting utilities. Includes Unix epoch conversions
// (<c>FromMilliEpochTime</c>, <c>ToMilliEpochTime</c>), day-of-week navigation
// (<c>GetLastDayOfWeek</c>, <c>GetNextDayOfWeek</c>), ISO 8601 week helpers
// (<c>GetWeekOfTheYear</c>, <c>GetWeeksInTheYear</c>, <c>GetYear</c>, <c>GetYearStart</c>,
// <c>GetYearEnd</c>), range checks (<c>IsInRange</c>, <c>IsInRangeThrowsException</c>,
// <c>Intersects</c>), time-until helpers (<c>TimeUntilNextHour</c>, <c>TimeUntilNextMinute</c>),
// formatting (<c>ToFormattedString</c>, <c>ToFriendlyDateString</c>), and UTC conversion
// (<c>LocalTimeFromUtc</c>).
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="DateTime"/>, <see cref="DateTimeOffset"/>, <see cref="DateOnly"/>,
/// <see cref="TimeSpan"/>, and <see cref="int"/> types, enhancing date and time handling with additional utility methods.
/// </summary>
/// <remarks>
/// Includes Unix epoch conversions, ISO 8601 week and year helpers, day-of-week navigation,
/// date-range intersection and validation checks, time-until-next-boundary helpers,
/// friendly and formatted string output, and UTC offset conversion.
/// These methods are designed to simplify common date and time operations, making code more readable and efficient.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineDateTimeExtensions")]
public static class DateTimeExtensions
{

	/// <summary>
	/// Clamps a <see cref="DateTime"/> to the inclusive range defined by <paramref name="minimum"/> and <paramref name="maximum"/>.
	/// </summary>
	/// <param name="value">The value to clamp.</param>
	/// <param name="minimum">The inclusive lower bound.</param>
	/// <param name="maximum">The inclusive upper bound.</param>
	/// <returns>The clamped <see cref="DateTime"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="minimum"/> is greater than <paramref name="maximum"/>.</exception>
	[Pure]
	[Information(nameof(Clamp), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static DateTime Clamp(this in DateTime value, in DateTime minimum, in DateTime maximum)
	{
		if (minimum > maximum)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(minimum));
		}

		if (value < minimum)
		{
			return minimum;
		}

		return value > maximum ? maximum : value;
	}

	/// <summary>
	/// Converts a <see cref="long" /> value representing the time in milliseconds since
	/// the Unix epoch (January 1, 1970, 00:00:00 UTC) back into a <see cref="DateTime" /> object.
	/// </summary>
	/// <param name="epochTime">The Epoch time.</param>
	/// <returns>DateTime.</returns>
	[Pure]
	[Information(nameof(FromMilliEpochTime), "David McCarter", "3/24/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DateTime FromMilliEpochTime(this in long epochTime)
	{
		var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		return epoch.AddMilliseconds(epochTime);
	}

	/// <summary>
	/// Calculates and returns the last occurrence of a specified day of the week before
	/// or on the given <see cref="DateTimeOffset" /> input.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="dayOfWeek">The day of week.</param>
	/// <returns>DateTimeOffset.</returns>
	[Pure]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTimeOffset GetLastDayOfWeek(this in DateTimeOffset input, DayOfWeek dayOfWeek = DayOfWeek.Sunday)
	{
		return input.AddDays((input.DayOfWeek > dayOfWeek
									? input.DayOfWeek - dayOfWeek
									: 7 - (int)dayOfWeek + (int)input.DayOfWeek) * -1);
	}

	/// <summary>
	/// Returns the next occurrence of a specified day of the week after
	/// the given <see cref="DateTimeOffset" /> input.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="dayOfWeek">The day of week.</param>
	/// <returns>DateTimeOffset.</returns>
	[Pure]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTimeOffset GetNextDayOfWeek(this in DateTimeOffset input, DayOfWeek dayOfWeek)
	{
		var daysToAdd = input.DayOfWeek < dayOfWeek
			 ? dayOfWeek - input.DayOfWeek
			 : 7 - (int)input.DayOfWeek + (int)dayOfWeek;

		return input.AddDays(daysToAdd);
	}

	/// <summary>
	/// Returns the ISO 8601 week number of the year for the specified <see cref="DateOnly"/>.
	/// </summary>
	/// <param name="input">The <see cref="DateOnly"/> to get the week number for.</param>
	/// <returns>The ISO 8601 week number of the year.</returns>
	[Pure]
	[Information(nameof(GetWeekOfTheYear), author: "David McCarter", createdOn: "5/13/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int GetWeekOfTheYear(this in DateOnly input)
	{
		return ISOWeek.GetWeekOfYear(input);
	}

	/// <summary>
	/// Returns the ISO 8601 week number of the year for the specified <see cref="DateTime"/>.
	/// </summary>
	/// <param name="input">The <see cref="DateTime"/> to get the week number for.</param>
	/// <returns>The ISO 8601 week number of the year.</returns>
	[Pure]
	[Information(nameof(GetWeekOfTheYear), author: "David McCarter", createdOn: "5/13/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int GetWeekOfTheYear(this in DateTime input)
	{
		return ISOWeek.GetWeekOfYear(input);
	}

	/// <summary>
	/// Returns the ISO 8601 number of weeks in the specified year.
	/// </summary>
	/// <param name="input">The year to get the number of weeks for.</param>
	/// <returns>The number of weeks in the specified year according to ISO 8601.</returns>
	[Pure]
	[Information(nameof(GetWeeksInTheYear), author: "David McCarter", createdOn: "5/13/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int GetWeeksInTheYear(this in int input)
	{
		return ISOWeek.GetWeeksInYear(input);
	}

	/// <summary>
	/// Returns the ISO 8601 week-based year for the specified <see cref="DateTime"/>.
	/// </summary>
	/// <param name="input">The <see cref="DateTime"/> to get the ISO 8601 year for.</param>
	/// <returns>The ISO 8601 week-based year that contains the specified <see cref="DateTime"/>.</returns>
	[Pure]
	[Information(nameof(GetYear), author: "David McCarter", createdOn: "5/13/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int GetYear(this in DateTime input)
	{
		return ISOWeek.GetYear(input);
	}

	/// <summary>
	/// Returns the ISO 8601 week-based year for the specified <see cref="DateOnly"/>.
	/// </summary>
	/// <param name="input">The <see cref="DateOnly"/> to get the ISO 8601 year for.</param>
	/// <returns>The ISO 8601 week-based year that contains the specified <see cref="DateOnly"/>.</returns>
	[Pure]
	[Information(nameof(GetYear), author: "David McCarter", createdOn: "5/13/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int GetYear(this in DateOnly input)
	{
		return ISOWeek.GetYear(input);
	}

	/// <summary>
	/// Returns the last day of the ISO 8601 week-based year for the specified year.
	/// </summary>
	/// <param name="input">The year to get the last day for.</param>
	/// <returns>
	/// A <see cref="DateTime"/> representing the last day of the ISO 8601 week-based year.
	/// </returns>
	[Pure]
	[Information(nameof(GetYearEnd), author: "David McCarter", createdOn: "5/13/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTime GetYearEnd(this in int input)
	{
		return ISOWeek.GetYearEnd(input);
	}

	/// <summary>
	/// Returns the first day of the ISO 8601 week-based year for the specified year.
	/// </summary>
	/// <param name="input">The year to get the first day for.</param>
	/// <returns>
	/// A <see cref="DateTime"/> representing the first day of the ISO 8601 week-based year.
	/// </returns>
	[Pure]
	[Information(nameof(GetYearStart), author: "David McCarter", createdOn: "5/13/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTime GetYearStart(this in int input)
	{
		return ISOWeek.GetYearStart(input);
	}

	/// <summary>
	/// Determines whether the date range defined by <paramref name="startDate"/> and <paramref name="endDate"/>
	/// intersects with the range defined by <paramref name="intersectingStartDate"/> and <paramref name="intersectingEndDate"/>.
	/// </summary>
	/// <param name="startDate">The start of the primary date range.</param>
	/// <param name="endDate">The end of the primary date range.</param>
	/// <param name="intersectingStartDate">The start of the range to test for intersection.</param>
	/// <param name="intersectingEndDate">The end of the range to test for intersection.</param>
	/// <returns><c>true</c> if the two date ranges overlap; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(Intersects), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool Intersects(this in DateTime startDate, in DateTime endDate, in DateTime intersectingStartDate, in DateTime intersectingEndDate)
	{
		return intersectingEndDate >= startDate && intersectingStartDate <= endDate;
	}

	/// <summary>
	/// Determines whether the date range defined by <paramref name="startDate"/> and <paramref name="endDate"/>
	/// intersects with the range defined by <paramref name="intersectingStartDate"/> and <paramref name="intersectingEndDate"/>.
	/// </summary>
	/// <param name="startDate">The start of the primary date range.</param>
	/// <param name="endDate">The end of the primary date range.</param>
	/// <param name="intersectingStartDate">The start of the range to test for intersection.</param>
	/// <param name="intersectingEndDate">The end of the range to test for intersection.</param>
	/// <returns><c>true</c> if the two date ranges overlap; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool Intersects(this in DateTimeOffset startDate, in DateTimeOffset endDate, in DateTimeOffset intersectingStartDate, in DateTimeOffset intersectingEndDate)
	{
		return intersectingEndDate >= startDate && intersectingStartDate <= endDate;
	}

	/// <summary>
	/// Determines whether value is in range of the specified beginning time and end time.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning date.</param>
	/// <param name="endTime">The end date.</param>
	/// <returns><c>true</c> if [is in range] [the specified beginning date]; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsInRange), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRange(this in DateTime value, in DateTime beginningTime, in DateTime endTime)
	{
		return value >= beginningTime && value <= endTime;
	}

	/// <summary>
	/// Determines whether value is in range of the specified beginning time and end time.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <returns><c>true</c> if [is in range] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsInRange), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRange(this in TimeSpan value, in TimeSpan beginningTime, in TimeSpan endTime)
	{
		return value >= beginningTime && value <= endTime;
	}

	/// <summary>
	/// Determines whether value is in range of the specified beginning time and end time.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <returns><c>true</c> if [is in range] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsInRange), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRange(this in DateTimeOffset value, in DateTimeOffset beginningTime, in DateTimeOffset endTime)
	{
		return value >= beginningTime && value <= endTime;
	}

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRangeThrowsException(this in DateTime value, in DateTime beginningTime, in DateTime endTime, string paramName)
	{
		if (value.IsInRange(beginningTime, endTime) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
		}

		return true;
	}

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if
	/// invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRangeThrowsException(this in TimeSpan value, in TimeSpan beginningTime, in TimeSpan endTime, string paramName)
	{
		if (value.IsInRange(beginningTime, endTime) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
		}

		return true;
	}

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified beginning time]. Throws Exception if
	/// invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="beginningTime">The beginning time.</param>
	/// <param name="endTime">The end time.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns><c>true</c> if [is in range throws exception] [the specified beginning time]; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsInRangeThrowsException(this in DateTimeOffset value, in DateTimeOffset beginningTime, in DateTimeOffset endTime, string paramName = ControlChars.EmptyString)
	{
		if (value.IsInRange(beginningTime, endTime) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
		}

		return true;
	}

	/// <summary>
	/// Given a date, it returns the local <see cref="DateTime" /> based on a timezone.
	/// </summary>
	/// <param name="date">Date to process</param>
	/// <param name="timezoneFromUtc">Hours of the timezone from UTC</param>
	/// <returns>Future date</returns>
	[Pure]
	[Information(nameof(LocalTimeFromUtc), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTime LocalTimeFromUtc(this in DateTime date, int timezoneFromUtc)
	{
		return date.ToUniversalTime().AddHours(timezoneFromUtc);
	}

	/// <summary>
	/// Determines the maximum of the two <see cref="DateTime" />s.
	/// </summary>
	/// <param name="date">The date.</param>
	/// <param name="compareTo">The date to compare.</param>
	/// <returns>DateTime.</returns>
	[Pure]
	[Information(nameof(Max), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTime Max(this in DateTime date, in DateTime compareTo)
	{
		return date > compareTo ? date : compareTo;
	}

	/// <summary>
	/// Determines the maximum of the two <see cref="DateTimeOffset" />s.
	/// </summary>
	/// <param name="date">The date.</param>
	/// <param name="compareTo">The date to compare.</param>
	/// <returns>DateTimeOffset.</returns>
	[Pure]
	[Information(nameof(Max), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static DateTimeOffset Max(this in DateTimeOffset date, in DateTimeOffset compareTo)
	{
		return date > compareTo ? date : compareTo;
	}

	/// <summary>
	/// Rounds a <see cref="DateTime"/> to the nearest multiple of <paramref name="multiple"/>.
	/// </summary>
	/// <param name="value">The value to round.</param>
	/// <param name="multiple">The rounding multiple. Must be greater than <see cref="TimeSpan.Zero"/>.</param>
	/// <returns>The rounded <see cref="DateTime"/>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="multiple"/> is less than or equal to <see cref="TimeSpan.Zero"/>.</exception>
	[Pure]
	[Information(nameof(RoundToNearestMultiple), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static DateTime RoundToNearestMultiple(this in DateTime value, in TimeSpan multiple)
	{
		if (multiple <= TimeSpan.Zero)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(multiple));
		}

		var ticks = value.Ticks;
		var multipleTicks = multiple.Ticks;
		var roundedTicks = (long)(Math.Round((double)ticks / multipleTicks, MidpointRounding.AwayFromZero) * multipleTicks);

		return new DateTime(roundedTicks, value.Kind);
	}

	/// <summary>
	/// Determines how long until the next hour starts.
	/// </summary>
	/// <param name="dateTime">The DateTime to check.</param>
	/// <returns>A TimeSpan representing the time until the next hour starts.</returns>
	[Pure]
	[Information(nameof(TimeUntilNextHour), author: "GitHub Copilot", createdOn: "03/03/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TimeSpan TimeUntilNextHour(this in DateTime dateTime)
	{
		var nextHour = dateTime.AddHours(1).AddMinutes(-dateTime.Minute).AddSeconds(-dateTime.Second).AddMilliseconds(-dateTime.Millisecond);

		return nextHour - dateTime;
	}

	/// <summary>
	/// Determines how long until the next hour starts.
	/// </summary>
	/// <param name="dateTime">The DateTimeOffset to check.</param>
	/// <returns>A TimeSpan representing the time until the next hour starts.</returns>
	[Pure]
	[Information(nameof(TimeUntilNextHour), author: "GitHub Copilot", createdOn: "03/03/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TimeSpan TimeUntilNextHour(this in DateTimeOffset dateTime)
	{
		var nextHour = dateTime.AddHours(1).AddMinutes(-dateTime.Minute).AddSeconds(-dateTime.Second).AddMilliseconds(-dateTime.Millisecond);

		return nextHour - dateTime;
	}

	/// <summary>
	/// Determines how long until the next minute starts.
	/// </summary>
	/// <param name="dateTime">The DateTime to check.</param>
	/// <returns>A TimeSpan representing the time until the next minute starts.</returns>
	[Pure]
	[Information(nameof(TimeUntilNextMinute), author: "GitHub Copilot", createdOn: "03/03/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TimeSpan TimeUntilNextMinute(this in DateTime dateTime)
	{
		var nextMinute = dateTime.AddMinutes(1).AddSeconds(-dateTime.Second).AddMilliseconds(-dateTime.Millisecond);

		return nextMinute - dateTime;
	}

	/// <summary>
	/// Determines how long until the next minute starts.
	/// </summary>
	/// <param name="dateTime">The DateTimeOffset to check.</param>
	/// <returns>A TimeSpan representing the time until the next minute starts.</returns>
	[Pure]
	[Information(nameof(TimeUntilNextMinute), author: "GitHub Copilot", createdOn: "03/03/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TimeSpan TimeUntilNextMinute(this in DateTimeOffset dateTime)
	{
		var nextMinute = dateTime.AddMinutes(1).AddSeconds(-dateTime.Second).AddMilliseconds(-dateTime.Millisecond);

		return nextMinute - dateTime;
	}

	/// <summary>
	/// Converts <see cref="DateTime" /> to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>A <see cref="string"/> containing the <see cref="DateTime"/> formatted according to <paramref name="format"/>.</returns>
	/// <example>
	/// FullDateLongTime: Thursday, January 7, 2021 3:36:39 PM
	/// FullDateShortTime: Thursday, January 7, 2021 3:36 PM
	/// FullDateTime: Thursday, January 7, 2021 3:36 PM
	/// GeneralDateLongTime: 1/7/2021 3:36:39 PM
	/// GeneralDateShortTime: 1/7/2021 3:36 PM
	/// Jan01Comma2020: Jan 07, 2021
	/// Janurary01Comma2020: January 07, 2021
	/// LongDate: Thursday, January 7, 2021
	/// LongTime: 3:36:39 PM
	/// MonthDay: January 7
	/// MonthYear: January 2021
	/// RFC1123: Thu, 07 Jan 2021 15:36:39 GMT
	/// RoundTripDateTime: 2021-01-07T15:36:39.4416894-08:00
	/// ShortDate: 1/7/2021
	/// ShortTime: 3:36 PM
	/// SortableDateTime: 2021-01-07T15:36:39
	/// UniversalFullDateTime: Thursday, January 7, 2021 11:36:39 PM.
	/// </example>
	[Pure]
	[return: NotNull]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToFormattedString(this in DateTime input, [NotNull] DateTimeFormat format)
	{
		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts <see cref="DateTime" /> to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>A <see cref="string"/> containing the <see cref="DateTimeOffset"/> formatted according to <paramref name="format"/>.</returns>
	/// <example>
	/// FullDateLongTime: Thursday, January 7, 2021 3:36:39 PM
	/// FullDateShortTime: Thursday, January 7, 2021 3:36 PM
	/// FullDateTime: Thursday, January 7, 2021 3:36 PM
	/// GeneralDateLongTime: 1/7/2021 3:36:39 PM
	/// GeneralDateShortTime: 1/7/2021 3:36 PM
	/// Jan01Comma2020: Jan 07, 2021
	/// Janurary01Comma2020: January 07, 2021
	/// LongDate: Thursday, January 7, 2021
	/// LongTime: 3:36:39 PM
	/// MonthDay: January 7
	/// MonthYear: January 2021
	/// RFC1123: Thu, 07 Jan 2021 15:36:39 GMT
	/// RoundTripDateTime: 2021-01-07T15:36:39.4416894-08:00
	/// ShortDate: 1/7/2021
	/// ShortTime: 3:36 PM
	/// SortableDateTime: 2021-01-07T15:36:39
	/// UniversalFullDateTime: Thursday, January 7, 2021 11:36:39 PM.
	/// </example>
	[Pure]
	[return: NotNull]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToFormattedString(this DateTimeOffset input, [NotNull] DateTimeFormat format)
	{
		return input.ToString(format.ArgumentNotNull().DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Creates a friendly date string.
	/// </summary>
	/// <param name="input">The date.</param>
	/// <returns>System.String.</returns>
	/// <example>
	/// Output: TodayMidnight @ 10:27:43 am
	/// </example>
	[Pure]
	[return: NotNull]
	[Information(nameof(ToFriendlyDateString), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToFriendlyDateString(this in DateTime input)
	{
		return FormatFriendlyDateString(input);
	}

	/// <summary>
	/// Converts to friendly date string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>System.String.</returns>
	/// <example>
	/// Output: TodayMidnight @ 10:27:43 am
	/// </example>
	[Pure]
	[return: NotNull]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToFriendlyDateString(this in DateTimeOffset input)
	{
		string formattedDate;

		if (input.Date == DateTime.Today)
		{
			formattedDate = nameof(DateTime.Today);
		}
		else
		{
			var condition = input.Date > DateTime.Today.AddDays(-6)
				? input.ToString("dddd", CultureInfo.CurrentCulture)
				: input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern,
												  CultureInfo.CurrentCulture);

			formattedDate = input.Date == DateTime.Today.AddDays(-1)
				? Resources.Yesterday
				: condition;
		}

		formattedDate += $" @ {input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern, CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture)}";

		return formattedDate;
	}

	/// <summary>
	/// Converts convert a <see cref="DateTime" /> object into a long representing the time in milliseconds
	/// since the Unix epoch (January 1, 1970, 00:00:00 UTC).
	/// </summary>
	/// <param name="date">The date.</param>
	/// <returns>System.Int64.</returns>
	/// <remarks>In computing, an epoch is a date and time from which a computer measures system time.
	/// For instance, Unix and POSIX measure time as the number of seconds that have passed
	/// since 1 January 1970 00:00:00 UT, a point in time known as the Unix epoch.</remarks>
	[Pure]
	[Information(nameof(ToMilliEpochTime), "David McCarter", "3/24/2017", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static long ToMilliEpochTime(this in DateTime date)
	{
		var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		return Convert.ToInt64((date - epoch).TotalMilliseconds);
	}

	/// <summary>
	/// Attempts to parse a <see cref="DateTime"/> from a <see cref="ReadOnlySpan{T}"/> using invariant culture.
	/// </summary>
	/// <param name="input">The input span to parse.</param>
	/// <param name="value">When this method returns, contains the parsed value if successful; otherwise default.</param>
	/// <returns><c>true</c> if parsing succeeded; otherwise <c>false</c>.</returns>
	[Information(nameof(TryParseInvariant), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static bool TryParseInvariant(this ReadOnlySpan<char> input, out DateTime value)
	{
		return DateTime.TryParse(input, CultureInfo.InvariantCulture, DateTimeStyles.None, out value);
	}

	/// <summary>
	/// Formats the specified <see cref="DateTime"/> as a friendly date string, such as "TodayMidnight @ 10:27:43 am" or "Yesterday @ 10:27:43 am".
	/// </summary>
	/// <param name="input">The <see cref="DateTime"/> to format.</param>
	/// <returns>A friendly date string representation of the input date.</returns>
	[Pure]
	[return: NotNull]
	private static string FormatFriendlyDateString(DateTime input)
	{
		string formattedDate;

		if (input.Date == DateTime.Today)
		{
			formattedDate = nameof(DateTime.Today);
		}
		else
		{
			var condition = input.Date > DateTime.Today.AddDays(-6)
				? input.ToString("dddd", CultureInfo.CurrentCulture)
				: input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern,
												  CultureInfo.CurrentCulture);

			formattedDate = input.Date == DateTime.Today.AddDays(-1)
				? Resources.Yesterday
				: condition;
		}

		formattedDate += $" @ {input.ToString(CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern, CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture)}";

		return formattedDate;
	}

}
