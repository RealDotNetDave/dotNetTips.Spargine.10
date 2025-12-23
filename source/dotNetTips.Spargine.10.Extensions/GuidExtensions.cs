// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-30-2018
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2025
// ***********************************************************************
// <copyright file="GuidExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for Guid.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Guid"/> type.
/// These methods include converting a Guid to a string representation without dashes and checking if a Guid is not empty.
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
