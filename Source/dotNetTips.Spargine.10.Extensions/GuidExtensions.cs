// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-30-2018
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="GuidExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="System.Guid"/> providing conversion utilities.
// Currently exposes <c>ToDigits</c>, which converts a <see cref="System.Guid"/> to its
// 32-character hexadecimal string representation without dashes.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Guid"/> type.
/// Currently exposes <c>ToDigits</c>, which returns the 32-character hexadecimal string
/// representation of a <see cref="Guid"/> without dashes, or an empty string when the value
/// is <see cref="Guid.Empty"/>.
/// </summary>
[Information(Status = Status.Available)]
public static class GuidExtensions
{

	/// <summary>
	/// Converts the specified <see cref="Guid"/> to a string representation without dashes.
	/// </summary>
	/// <param name="input">The <see cref="Guid"/> to convert.</param>
	/// <returns>A string representation of the <see cref="Guid"/> without dashes if the <paramref name="input"/> is not empty; otherwise, an empty string.</returns>
	[return: NotNull]
	[Information(nameof(ToDigits), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string ToDigits([DisallowNull] this Guid input)
	{
		return input.CheckIsNotEmpty() ? input.ToString("N", CultureInfo.InvariantCulture) : string.Empty;
	}

}
