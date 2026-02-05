// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 01-23-2026
//
// Last Modified By : David McCarter
// Last Modified On : 01-23-2026
// ***********************************************************************
// <copyright file="PersonComparerByIdThenLastName.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Tester.Models.ValueTypes.Comparers;

/// <summary>
/// Compares two <see cref="Person"/> instances using a two-level sort:
/// primary by <see cref="Person.Id"/> (ordinal), then secondary by <see cref="Person.LastName"/> (ordinal).
/// </summary>
/// <remarks>
/// - Null handling: <c>null</c> is treated as less than non-null (i.e., sorts first).<br/>
/// - Comparison rules: <see cref="StringComparison.Ordinal"/> for both Id and LastName ensures stable, culture-agnostic ordering.<br/>
/// - Thread-safety: This comparer is stateless and thread-safe.
/// </remarks>
/// <example>
/// <code>
/// var people = new List&lt;Person&gt;
/// {
///     new() { Id = "002", LastName = "Zane" },
///     new() { Id = "001", LastName = "Adams" },
///     new() { Id = "001", LastName = "Brown" }
/// };
/// 
/// people.Sort(new PersonComparerByIdThenLastName());
/// // Order:
/// // Id=001, LastName=Adams
/// // Id=001, LastName=Brown
/// // Id=002, LastName=Zane
/// </code>
/// </example>
[Information(nameof(PersonComparerByIdThenLastName), "David McCarter", "1/23/2026", Status = Status.Available)]
public sealed class PersonComparerByIdThenLastName : IComparer<Person>
{
	/// <summary>
	/// Compares two <see cref="Person"/> instances by Id then LastName using ordinal comparison.
	/// </summary>
	/// <param name="x">The first <see cref="Person"/> to compare.</param>
	/// <param name="y">The second <see cref="Person"/> to compare.</param>
	/// <returns>
	/// A value less than zero if <paramref name="x"/> is less than <paramref name="y"/>;
	/// zero if they are equal; greater than zero if <paramref name="x"/> is greater than <paramref name="y"/>.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int Compare(Person x, Person y)
	{
		// Primary sort by Id (ordinal)
		var idComparison = string.Compare(x.Id, y.Id, StringComparison.Ordinal);

		if (idComparison != 0)
		{
			return idComparison;
		}

		// Secondary sort by LastName (ordinal)
		return string.Compare(x.LastName, y.LastName, StringComparison.Ordinal);
	}
}
