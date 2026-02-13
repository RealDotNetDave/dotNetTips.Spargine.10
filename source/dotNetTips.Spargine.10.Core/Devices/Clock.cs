// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2026
// ***********************************************************************
// <copyright file="Clock.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Time Utility Class for common tasks related to clocks and time.
// It includes functionalities to retrieve the current time and tick
// count, along with a method to determine the number of days in the
// current month (DaysInCurrentMonth).
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Devices;

/// <summary>
/// Provides utility methods for common tasks related to clocks and time, such as retrieving the current time, tick count, and the number of days in the current month.
/// </summary>
/// <remarks>
/// Some of this code is from the Microsoft.VisualBasic.dll.
/// </remarks>
[ExcludeFromCodeCoverage(Justification = "Not needed due to just using the <see cref=\"DateTime\"/> type.")]
[Information(nameof(Clock), "David McCarter", "11/11/2020", Status = Status.Available, Documentation = "ADD URL")]
public static class Clock
{

	/// <summary>
	/// Gets the current day of the week (local time).
	/// </summary>
	/// <value>The current day of the week.</value>
	[Pure]
	[Information(nameof(CurrentDayOfWeek), "David McCarter", "2/13/2026", Status = Status.New)]
	public static DayOfWeek CurrentDayOfWeek
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => LocalTime.DayOfWeek;
	}

	/// <summary>
	/// Gets the current day of the year (local time), from 1 to 366.
	/// </summary>
	/// <value>The current day of the year.</value>
	[Pure]
	[Information(nameof(CurrentDayOfYear), "David McCarter", "2/13/2026", Status = Status.New)]
	public static int CurrentDayOfYear
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => LocalTime.DayOfYear;
	}

	/// <summary>
	/// Gets the current quarter of the year (local time), from 1 to 4.
	/// </summary>
	/// <value>The current quarter.</value>
	[Pure]
	[Information(nameof(CurrentQuarter), "David McCarter", "2/13/2026", Status = Status.New)]
	public static int CurrentQuarter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => ((LocalTime.Month - 1) / 3) + 1;
	}

	/// <summary>
	/// Gets the current day of the week (UTC).
	/// </summary>
	/// <value>The current UTC day of the week.</value>
	[Pure]
	[Information(nameof(CurrentUtcDayOfWeek), "David McCarter", "2/13/2026", Status = Status.New)]
	public static DayOfWeek CurrentUtcDayOfWeek
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => UtcTime.DayOfWeek;
	}

	/// <summary>
	/// Gets the current quarter of the year (UTC), from 1 to 4.
	/// </summary>
	/// <value>The current UTC quarter.</value>
	[Pure]
	[Information(nameof(CurrentUtcQuarter), "David McCarter", "2/13/2026", Status = Status.New)]
	public static int CurrentUtcQuarter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => ((UtcTime.Month - 1) / 3) + 1;
	}

	/// <summary>
	/// Gets the days in the current month (local time) by utilizing <see cref="DateTime.DaysInMonth(int, int)"/>.
	/// </summary>
	/// <value>The number of days in the current month.</value>
	[Pure]
	[Information(nameof(DaysInCurrentMonth), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int DaysInCurrentMonth
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
		}
	}

	/// <summary>
	/// Gets the days in the current UTC month by utilizing <see cref="DateTime.DaysInMonth(int, int)"/>.
	/// </summary>
	/// <value>The number of days in the current UTC month.</value>
	[Pure]
	[Information(nameof(DaysInCurrentUtcMonth), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int DaysInCurrentUtcMonth
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month);
		}
	}

	/// <summary>
	/// Gets the number of days remaining in the current month (local time).
	/// </summary>
	/// <value>The number of days remaining in the current month.</value>
	[Pure]
	[Information(nameof(DaysRemainingInMonth), "David McCarter", "2/13/2026", Status = Status.New)]
	public static int DaysRemainingInMonth
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => DaysInCurrentMonth - LocalTime.Day;
	}

	/// <summary>
	/// Gets the number of days remaining in the current year (local time).
	/// </summary>
	/// <value>The number of days remaining in the current year.</value>
	[Pure]
	[Information(nameof(DaysRemainingInYear), "David McCarter", "2/13/2026", Status = Status.New)]
	public static int DaysRemainingInYear
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => (new DateTime(LocalTime.Year, 12, 31) - LocalTime.Date).Days;
	}

	/// <summary>
	/// Gets the first day of the current month (local time).
	/// </summary>
	/// <value>The first day of the current month at midnight.</value>
	[Pure]
	[Information(nameof(FirstDayOfCurrentMonth), "David McCarter", "2/13/2026", Status = Status.New)]
	public static DateTimeOffset FirstDayOfCurrentMonth
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(LocalTime.Year, LocalTime.Month, 1, 0, 0, 0, LocalTime.Offset);
	}

	/// <summary>
	/// Gets a value indicating whether the current UTC year is a leap year.
	/// </summary>
	/// <value><c>true</c> if the current UTC year is a leap year; otherwise, <c>false</c>.</value>
	[Pure]
	[Information(nameof(IsCurrentUtcYearLeapYear), "David McCarter", "2/13/2026", Status = Status.New)]
	public static bool IsCurrentUtcYearLeapYear
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => DateTime.IsLeapYear(UtcTime.Year);
	}

	/// <summary>
	/// Gets a value indicating whether the current local year is a leap year.
	/// </summary>
	/// <value><c>true</c> if the current local year is a leap year; otherwise, <c>false</c>.</value>
	[Pure]
	[Information(nameof(IsCurrentYearLeapYear), "David McCarter", "2/13/2026", Status = Status.New)]
	public static bool IsCurrentYearLeapYear
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => DateTime.IsLeapYear(LocalTime.Year);
	}

	/// <summary>
	/// Gets a value indicating whether today is a weekday (Monday through Friday) in local time.
	/// </summary>
	/// <value><c>true</c> if today is a weekday; otherwise, <c>false</c>.</value>
	[Pure]
	[Information(nameof(IsWeekday), "David McCarter", "2/13/2026", Status = Status.New)]
	public static bool IsWeekday
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => !IsWeekend;
	}

	/// <summary>
	/// Gets a value indicating whether today is a weekend (Saturday or Sunday) in local time.
	/// </summary>
	/// <value><c>true</c> if today is a weekend; otherwise, <c>false</c>.</value>
	[Pure]
	[Information(nameof(IsWeekend), "David McCarter", "2/13/2026", Status = Status.New)]
	public static bool IsWeekend
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => CurrentDayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
	}

	/// <summary>
	/// Gets the last day of the current month (local time).
	/// </summary>
	/// <value>The last day of the current month at midnight.</value>
	[Pure]
	[Information(nameof(LastDayOfCurrentMonth), "David McCarter", "2/13/2026", Status = Status.New)]
	public static DateTimeOffset LastDayOfCurrentMonth
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(LocalTime.Year, LocalTime.Month, DaysInCurrentMonth, 0, 0, 0, LocalTime.Offset);
	}

	/// <summary>
	/// Gets the local time by converting <see cref="DateTimeOffset.Now"/> to local time.
	/// </summary>
	/// <value>The local time.</value>
	[Pure]
	[Information(nameof(LocalTime), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static DateTimeOffset LocalTime
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return DateTimeOffset.Now;
		}
	}

	/// <summary>
	/// Gets the local time zone's current UTC offset.
	/// </summary>
	/// <value>The current UTC offset for the local time zone.</value>
	[Pure]
	[Information(nameof(LocalUtcOffset), "David McCarter", "2/13/2026", Status = Status.New)]
	public static TimeSpan LocalUtcOffset
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => TimeZoneInfo.Local.GetUtcOffset(LocalTime);
	}

	/// <summary>
	/// Gets the current tick count by utilizing <see cref="Environment.TickCount"/>.
	/// </summary>
	/// <value>The tick count since the system started.</value>
	[Pure]
	[Information(nameof(TickCount), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static int TickCount
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return Environment.TickCount;
		}
	}

	/// <summary>
	/// Gets the current tick count as a 64-bit integer by utilizing <see cref="Environment.TickCount64"/>.
	/// </summary>
	/// <value>The tick count since the system started as a 64-bit integer.</value>
	[Pure]
	[Information(nameof(TickCount64), "David McCarter", "11/14/2024", Status = Status.Available)]
	public static long TickCount64
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return Environment.TickCount64;
		}
	}

	/// <summary>
	/// Gets midnight (start of day) for today in local time.
	/// </summary>
	/// <value>Today's date at midnight.</value>
	[Pure]
	[Information(nameof(Today), "David McCarter", "2/13/2026", Status = Status.New)]
	public static DateTimeOffset Today
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => LocalTime.Date;
	}

	/// <summary>
	/// Gets the Unix timestamp (seconds since January 1, 1970 UTC).
	/// </summary>
	/// <value>The Unix timestamp.</value>
	[Pure]
	[Information(nameof(UnixTimestamp), "David McCarter", "2/13/2026", Status = Status.New)]
	public static long UnixTimestamp
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	/// <summary>
	/// Gets the Unix timestamp in milliseconds (milliseconds since January 1, 1970 UTC).
	/// </summary>
	/// <value>The Unix timestamp in milliseconds.</value>
	[Pure]
	[Information(nameof(UnixTimestampMilliseconds), "David McCarter", "2/13/2026", Status = Status.New)]
	public static long UnixTimestampMilliseconds
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
	}

	/// <summary>
	/// Gets the UTC time as a <see cref="DateTimeOffset"/>.
	/// </summary>
	/// <value>The UTC time with zero offset.</value>
	[Pure]
	[Information(nameof(UtcTime), "David McCarter", "11/11/2020", Status = Status.Available)]
	public static DateTimeOffset UtcTime
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => DateTimeOffset.UtcNow;
	}

	/// <summary>
	/// Gets the number of days in the specified month of the specified year.
	/// </summary>
	/// <param name="year">The year.</param>
	/// <param name="month">The month (1 through 12).</param>
	/// <returns>The number of days in the specified month.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DaysInMonth), "David McCarter", "2/13/2026", Status = Status.New)]
	public static int DaysInMonth(in int year, in int month)
	{
		return DateTime.DaysInMonth(year, month);
	}

	/// <summary>
	/// Determines whether the specified year is a leap year.
	/// </summary>
	/// <param name="year">The year to check.</param>
	/// <returns><c>true</c> if the specified year is a leap year; otherwise, <c>false</c>.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsLeapYear), "David McCarter", "11/14/2024", Status = Status.Available)]
	public static bool IsLeapYear(in int year)
	{
		return DateTime.IsLeapYear(year);
	}
}
