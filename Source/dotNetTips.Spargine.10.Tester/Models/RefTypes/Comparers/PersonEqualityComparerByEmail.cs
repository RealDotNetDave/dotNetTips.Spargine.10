// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 06-13-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="PersonEqualityComparerByEmail.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides an IEqualityComparer&lt;Person&gt; implementation that
// determines equality and hash codes for Person instances by Email.
// </summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;

/// <summary>
/// Provides equality comparison for <see cref="Person"/> objects based on their email addresses.
/// </summary>
[Information(Status = Status.Available)]
public sealed class PersonEqualityComparerByEmail : IEqualityComparer<Person>
{
	/// <summary>
	/// Determines whether the specified <see cref="Person"/> objects are equal based on their email addresses.
	/// </summary>
	/// <param name="x">The first <see cref="Person"/> to compare.</param>
	/// <param name="y">The second <see cref="Person"/> to compare.</param>
	/// <returns><c>true</c> if the specified <see cref="Person"/> objects are equal; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool Equals(Person? x, Person? y)
	{
		return x is null && y is null
					? true
					: x is null || y is null
						? false
						: string.Equals(x.Email, y.Email, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Returns a hash code for the specified <see cref="Person"/> based on their email address.
	/// </summary>
	/// <param name="obj">The <see cref="Person"/> for which a hash code is to be returned.</param>
	/// <returns>A hash code for the specified <see cref="Person"/>.</returns>
	public int GetHashCode(Person obj) => obj?.Email?.GetHashCode(StringComparison.OrdinalIgnoreCase) ?? 0;
}
