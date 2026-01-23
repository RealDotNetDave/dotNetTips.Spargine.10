// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 01-23-2026
//
// Last Modified By : David McCarter
// Last Modified On : 01-23-2026
// ***********************************************************************
// <copyright file="PersonEqualityComparer.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers;

/// <summary>
/// Class PersonEqualityComparer.
/// </summary>
public class PersonEqualityComparer : IEqualityComparer<Person>
{
	/// <summary>
	/// Determines whether the specified objects are equal.
	/// </summary>
	/// <param name="x">The first object of type to compare.</param>
	/// <param name="y">The second object of type to compare.</param>
	/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool Equals(Person x, Person y) => x.Equals(y);

	/// <summary>
	/// Returns a hash code for the specified object.
	/// </summary>
	/// <param name="obj">The object for which to get a hash code.</param>
	/// <returns>A hash code for the specified object.</returns>
	public int GetHashCode([DisallowNull] Person obj) => obj.Id?.GetHashCode(StringComparison.Ordinal) ?? 0;

}
