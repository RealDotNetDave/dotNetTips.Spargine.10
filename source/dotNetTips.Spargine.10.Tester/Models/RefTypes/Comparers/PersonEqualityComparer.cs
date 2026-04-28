// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 06-13-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-28-2026
// ***********************************************************************
// <copyright file="PersonEqualityComparer.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides an IEqualityComparer&lt;Person&gt; implementation that
// determines equality and hash codes for Person instances by Id.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;

/// <summary>
/// Class PersonEqualityComparer.
/// </summary>
public sealed class PersonEqualityComparer : IEqualityComparer<Person>
{
	/// <summary>
	/// Determines whether the specified objects are equal.
	/// </summary>
	/// <param name="x">The first object of type to compare.</param>
	/// <param name="y">The second object of type to compare.</param>
	/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	public bool Equals([AllowNull] Person x, [AllowNull] Person y) => ReferenceEquals(x, y) ? true : x is null || y is null ? false : string.Equals(x.Id, y.Id, StringComparison.Ordinal);

	/// <summary>
	/// Returns a hash code for the specified object.
	/// </summary>
	/// <param name="obj">The object for which to get a hash code.</param>
	/// <returns>A hash code for the specified object.</returns>
	public int GetHashCode([DisallowNull] Person obj) => obj?.Id?.GetHashCode(StringComparison.Ordinal) ?? 0;

}
