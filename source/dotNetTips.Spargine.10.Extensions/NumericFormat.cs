// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 12-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-15-2026
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
/// Class NumericFormat.
/// Implements the <see cref="Enumeration" />
/// </summary>
/// <seealso cref="Enumeration" />
[Information(nameof(NumericFormat), Status = Status.UpdateDocumentation)]
public sealed class NumericFormat : Enumeration
{

	/// <summary>
	/// Binary format (.NET 8+). Example: 1111111111111111111111111111111
	/// </summary>
	public static readonly NumericFormat Binary = new(11, "B");

	/// <summary>
	/// Custom format. Example: $2,147,483,647.00
	/// </summary>
	public static readonly NumericFormat Currency = new(0, "C");

	/// <summary>
	/// Currency without decimals. Example: $2,147,483,647
	/// </summary>
	public static readonly NumericFormat CurrencyWholeNumber = new(12, "C0");

	/// <summary>
	/// Custom format. Example: 21474836.47
	/// </summary>
	public static readonly NumericFormat Decimal = new(1, "D");

	/// <summary>
	/// Custom format. Example: 2.147484E+009
	/// </summary>
	public static readonly NumericFormat Exponential = new(2, "E");

	/// <summary>
	/// Custom format. Example: 2147483647.00
	/// </summary>
	public static readonly NumericFormat FixedPoint = new(3, "F");

	/// <summary>
	/// Custom format with four decimal places. Example: 2,147,483,647.0000
	/// </summary>
	public static readonly NumericFormat FourDecimalPlaces = new(15, "N4");

	/// <summary>
	/// Custom format. Example: 2147483647
	/// </summary>
	public static readonly NumericFormat General = new(4, "G");

	/// <summary>
	/// Custom format. Example: 7FFFFFFF
	/// </summary>
	public static readonly NumericFormat Hexadecimal = new(5, "X");

	/// <summary>
	/// Lowercase hexadecimal format. Example: 7fffffff
	/// </summary>
	public static readonly NumericFormat HexadecimalLower = new(16, "x");

	/// <summary>
	/// Custom format. Example: 2,147,483,647.00
	/// </summary>
	public static readonly NumericFormat Number = new(6, "N");

	/// <summary>
	/// Custom format with one decimal place. Example: 2,147,483,647.0
	/// </summary>
	public static readonly NumericFormat OneDecimalPlace = new(14, "N1");

	/// <summary>
	/// Custom format. Example: 214,748,364,700.00%
	/// </summary>
	public static readonly NumericFormat Percent = new(7, "P");

	/// <summary>
	/// Percent without decimals. Example: 214,748,364,700%
	/// </summary>
	public static readonly NumericFormat PercentWholeNumber = new(13, "P0");

	/// <summary>
	/// Custom format. Example:  8.988465674311579E+307
	/// </summary>
	public static readonly NumericFormat RoundTrip = new(8, "R");

	/// <summary>
	/// Custom format. Example: 2,147,483,647.00
	/// </summary>
	public static readonly NumericFormat TwoDecimalPlaces = new(10, "N2");

	/// <summary>
	/// Custom format. Example: 2,147,483,647
	/// </summary>
	public static readonly NumericFormat WholeNumber = new(9, "N0");

	/// <summary>  
	/// Initializes a new instance of the <see cref="NumericFormat"/> class.  
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
