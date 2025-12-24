// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 06-13-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="PersonComparerByLastNameThenFirstName.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Provides a comparison for <see cref="Person"/> objects based on their last names and then first names.
/// </summary>
[Information(Status = Status.Available)]
public sealed class PersonComparerByLastNameThenFirstName : IComparer<Person>
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
	public int Compare(Person? x, Person? y)
	{
		var lastNameComparison = string.Compare(x?.LastName ?? string.Empty, y?.LastName ?? string.Empty, StringComparison.Ordinal);

		return lastNameComparison != 0
			? lastNameComparison
			: string.Compare(x?.FirstName ?? string.Empty, y?.FirstName ?? string.Empty, StringComparison.Ordinal);
	}
}
