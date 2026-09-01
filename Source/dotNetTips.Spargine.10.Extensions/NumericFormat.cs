// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-20-2026
// ***********************************************************************
// <copyright file="NumericFormat.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Class that provides common formats for numbers.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides strongly-typed numeric format specifiers used when formatting numbers as strings.
/// Each value corresponds to a standard or custom .NET numeric format string.
/// Inherits from <see cref="Enumeration" /> to support enumeration-style access by value or name.
/// </summary>
/// <seealso cref="Enumeration" />
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineNumericExtensions")]
public sealed class NumericFormat : Enumeration
{

	/// <summary>
	/// Binary format specifier ("B"), available in .NET 8 and later.
	/// Formats an integer as a binary string. Example: <c>1111111111111111111111111111111</c>
	/// </summary>
	public static readonly NumericFormat Binary = new(11, "B");

	/// <summary>
	/// Currency format specifier.
	/// Example: <c>$2,147,483,647.00</c>
	/// </summary>
	public static readonly NumericFormat Currency = new(0, "C");

	/// <summary>
	/// Currency format specifier with no decimal places.
	/// Example: <c>$2,147,483,647</c>
	/// </summary>
	public static readonly NumericFormat CurrencyWholeNumber = new(12, "C0");

	/// <summary>
	/// Decimal format specifier.
	/// Example: <c>21474836.47</c>
	/// </summary>
	public static readonly NumericFormat Decimal = new(1, "D");

	/// <summary>
	/// Scientific (exponential).
	/// Example: <c>2.147484E+009</c>
	/// </summary>
	public static readonly NumericFormat Exponential = new(2, "E");

	/// <summary>
	/// Fixed-point format specifier.
	/// Example: <c>2147483647.00</c>
	/// </summary>
	public static readonly NumericFormat FixedPoint = new(3, "F");

	/// <summary>
	/// Number format specifier with four decimal places.
	/// Example: <c>2,147,483,647.0000</c>
	/// </summary>
	public static readonly NumericFormat FourDecimalPlaces = new(15, "N4");

	/// <summary>
	/// General format specifier.
	/// Example: <c>2147483647</c>
	/// </summary>
	public static readonly NumericFormat General = new(4, "G");

	/// <summary>
	/// Uppercase hexadecimal format specifier.
	/// Example: <c>7FFFFFFF</c>
	/// </summary>
	public static readonly NumericFormat Hexadecimal = new(5, "X");

	/// <summary>
	/// Lowercase hexadecimal format specifier.
	/// Example: <c>7fffffff</c>
	/// </summary>
	public static readonly NumericFormat HexadecimalLower = new(16, "x");

	/// <summary>
	/// Number format specifier ("N").
	/// Example: <c>2,147,483,647.00</c>
	/// </summary>
	public static readonly NumericFormat Number = new(6, "N");

	/// <summary>
	/// Number format specifier with one decimal place.
	/// Example: <c>2,147,483,647.0</c>
	/// </summary>
	public static readonly NumericFormat OneDecimalPlace = new(14, "N1");

	/// <summary>
	/// Percent format specifier.
	/// Example: <c>214,748,364,700.00%</c>
	/// </summary>
	public static readonly NumericFormat Percent = new(7, "P");

	/// <summary>
	/// Percent format specifier with no decimal places.
	/// Example: <c>214,748,364,700%</c>
	/// </summary>
	public static readonly NumericFormat PercentWholeNumber = new(13, "P0");

	/// <summary>
	/// Round-trip format specifier.
	/// Example: <c>8.988465674311579E+307</c>
	/// </summary>
	public static readonly NumericFormat RoundTrip = new(8, "R");

	/// <summary>
	/// Number format specifier with two decimal places.
	/// Example: <c>2,147,483,647.00</c>
	/// </summary>
	public static readonly NumericFormat TwoDecimalPlaces = new(10, "N2");

	/// <summary>
	/// Number format specifier with no decimal places.
	/// Example: <c>2,147,483,647</c>
	/// </summary>
	public static readonly NumericFormat WholeNumber = new(9, "N0");

	/// <summary>
	/// Initializes a new instance
	/// This parameterless constructor is required by the <see cref="Enumeration"/> base class and is not intended for direct use.
	/// </summary>
	[ExcludeFromCodeCoverage]
	private NumericFormat() { }

	/// <summary>
	/// Initializes a new instance of the <see cref="NumericFormat" /> class.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="displayName">The display name.</param>
	private NumericFormat(in int value, string displayName) : base(value, displayName) { }

}
