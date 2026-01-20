// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 06-13-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="PersonRecordEmailEqualityComparer.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Provides equality comparison for <see cref="PersonRecord"/> objects based on the email address.
/// </summary>
[Information(Status = Status.Available)]
public sealed class PersonRecordEmailEqualityComparer : IEqualityComparer<PersonRecord>
{
	/// <summary>
	/// Determines whether the specified <see cref="PersonRecord"/> objects are equal based on their email addresses.
	/// </summary>
	/// <param name="x">The first <see cref="PersonRecord"/> to compare.</param>
	/// <param name="y">The second <see cref="PersonRecord"/> to compare.</param>
	/// <returns><c>true</c> if the specified <see cref="PersonRecord"/> objects are equal; otherwise, <c>false</c>.</returns>
	[Information(nameof(Equals), UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public bool Equals(PersonRecord? x, PersonRecord? y) => x == null && y == null
			? true
			: x == null || y == null ? false : string.Equals(x.Email, y.Email, StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Returns a hash code for the specified <see cref="PersonRecord"/> based on their email address.
	/// </summary>
	/// <param name="obj">The <see cref="PersonRecord"/> for which a hash code is to be returned.</param>
	/// <returns>A hash code for the specified <see cref="PersonRecord"/>.</returns>
	public int GetHashCode(PersonRecord obj) => obj?.Email?.GetHashCode(StringComparison.OrdinalIgnoreCase) ?? 0;
}
