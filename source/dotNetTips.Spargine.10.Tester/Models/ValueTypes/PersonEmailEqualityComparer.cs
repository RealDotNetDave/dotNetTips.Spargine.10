// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 01-23-2025
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2025
// ***********************************************************************
// <copyright file="PersonEmailEqualityComparer.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.ValueTypes;

/// <summary>
/// Provides equality comparison for <see cref="Person"/> objects based on their email addresses.
/// </summary>
[Information(Status = Status.Available)]
public sealed class PersonEmailEqualityComparer : IEqualityComparer<Person>
{
	/// <summary>
	/// Determines whether the specified objects are equal.
	/// </summary>
	/// <param name="x">The first object of type to compare.</param>
	/// <param name="y">The second object of type to compare.</param>
	/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	public bool Equals(Person x, Person y) =>
		x.Equals(y);

	/// <summary>
	/// Returns a hash code for the specified <see cref="Person"/> based on their email address.
	/// </summary>
	/// <param name="obj">The <see cref="Person"/> for which a hash code is to be returned.</param>
	/// <returns>A hash code for the specified <see cref="Person"/>.</returns>
	public int GetHashCode(Person obj) =>
		obj.Email is null
			? 0
			: obj.Email.GetHashCode(StringComparison.OrdinalIgnoreCase);

}
