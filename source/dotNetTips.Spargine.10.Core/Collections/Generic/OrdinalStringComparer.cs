// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-14-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-17-2025
// ***********************************************************************
// <copyright file="OrdinalStringComparer.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)


namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// Provides a comparison for <see cref="string"/> objects using ordinal comparison.
/// </summary>
[Information(Status = Status.Available)]
public class OrdinalStringComparer : IComparer<string>
{
	/// <summary>
	/// Compares two <see cref="string"/> objects using ordinal comparison.
	/// </summary>
	/// <param name="x">The first string to compare.</param>
	/// <param name="y">The second string to compare.</param>
	/// <returns>
	/// A signed integer that indicates the relative values of <paramref name="x"/> and <paramref name="y"/>:
	/// <list type="bullet">
	/// <item><description>Less than zero: <paramref name="x"/> is less than <paramref name="y"/>.</description></item>
	/// <item><description>Zero: <paramref name="x"/> equals <paramref name="y"/>.</description></item>
	/// <item><description>Greater than zero: <paramref name="x"/> is greater than <paramref name="y"/>.</description></item>
	/// </list>
	/// </returns>
	public int Compare(string? x, string? y) => string.Compare(x, y, StringComparison.Ordinal);
}
