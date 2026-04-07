// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 01-23-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="PersonComparerByLastName.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************


using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers;

/// <summary>
/// Provides a comparison for <see cref="Person"/> objects based on their last names.
/// </summary>
[Information(Status = Status.Available)]
public sealed class PersonComparerByLastName : IComparer<Person>
{
	/// <summary>
	/// Compares two <see cref="Person"/> objects and returns a value indicating whether one is less than, equal to, or greater than the other.
	/// </summary>
	/// <param name="x">The first <see cref="Person"/> to compare.</param>
	/// <param name="y">The second <see cref="Person"/> to compare.</param>
	/// <returns>
	/// A signed integer that indicates the relative values of <paramref name="x"/> and <paramref name="y"/>:
	/// <list type="bullet">
	/// <item>
	/// <description>Less than zero: <paramref name="x"/> is less than <paramref name="y"/>.</description>
	/// </item>
	/// <item>
	/// <description>Zero: <paramref name="x"/> equals <paramref name="y"/>.</description>
	/// </item>
	/// <item>
	/// <description>Greater than zero: <paramref name="x"/> is greater than <paramref name="y"/>.</description>
	/// </item>
	/// </list>
	/// </returns>
	[Information(nameof(Compare), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public int Compare(Person x, Person y) => string.Compare(x.LastName, y.LastName, StringComparison.Ordinal);
}
