// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="DataTableExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="System.Data.DataTable"/> and <see cref="object"/> providing
// data-validation utilities. Includes <c>HasRows</c>, which checks whether a <see cref="System.Data.DataTable"/>
// contains any rows, and <c>IsDBNull</c>, which determines whether a value is equivalent to
// <see cref="System.DBNull"/>.
// </summary>
// ***********************************************************************
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="DataTable"/> and <see cref="object"/> to simplify
/// common data-validation tasks when working with ADO.NET.
/// </summary>
/// <remarks>
/// Includes <c>HasRows</c> for safely checking whether a <see cref="DataTable"/> is non-null and
/// contains at least one row, and <c>IsDBNull</c> for testing whether an <see cref="object"/> value
/// is equivalent to <see cref="DBNull.Value"/>. Both methods are null-safe and designed to reduce
/// boilerplate in database-access code.
/// </remarks>
[Information(Status = Status.Available)]
public static class DataTableExtensions
{

	/// <summary>
	/// Determines whether the specified <see cref="DataTable" /> contains any rows.
	/// </summary>
	/// <param name="table">The <see cref="DataTable"/> to check. A <c>null</c> value is handled safely.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="table"/> is not null and contains at least one row; otherwise, <c>false</c>.
	/// </returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(HasRows), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool HasRows([AllowNull] this DataTable table)
	{
		return (table is not null) && (table.Rows is not null) && (table.Rows.Count > 0);
	}

	/// <summary>
	/// Determines whether the specified value is equivalent to <see cref="DBNull"/>.
	/// </summary>
	/// <param name="value">The value to test. Must not be null.</param>
	/// <returns>
	/// <c>true</c> if <paramref name="value"/> equals <see cref="DBNull.Value"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(IsDBNull), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsDBNull([DisallowNull] this object value)
	{
		return Convert.IsDBNull(value);
	}

}
