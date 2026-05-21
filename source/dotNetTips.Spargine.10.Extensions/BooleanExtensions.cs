// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="BooleanExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for the <see cref="bool"/> type. Includes <c>ToLowerCase</c>, which converts
// a boolean value to its lowercase string representation ("true" or "false") using resource strings,
// useful for display output and serialization scenarios.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="bool"/> type, enhancing its usability and integration within applications.
/// </summary>
/// <remarks>
/// This class includes <c>ToLowerCase</c> for converting boolean values to their lowercase string representations
/// ("true" or "false"), which is useful for generating user-friendly display strings or for serialization purposes.
/// Resource strings are used to ensure the output is consistent and localizable.
/// </remarks>
[Information(nameof(BooleanExtensions), Status = Status.Available)]
public static class BooleanExtensions
{

	/// <summary>
	/// Converts to <see cref="bool" /> value to lowercase.
	/// </summary>
	/// <param name="value">if set to <c>true</c> [value].</param>
	/// <returns>A <see cref="string"/> containing "true" or "false" in lowercase.</returns>
	[Pure]
	[return: NotNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available, Documentation = "ADD URL")]
	public static string ToLowerCase(this bool value)
	{
		return value ? Resources.TrueLowerCase : Resources.FalseLowerCase;
	}

}
