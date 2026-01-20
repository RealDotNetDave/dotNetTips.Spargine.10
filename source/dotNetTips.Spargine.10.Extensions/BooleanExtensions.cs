// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2026
// ***********************************************************************
// <copyright file="BooleanExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions for the boolean type.</summary>
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
/// This class includes methods for converting boolean values to strings in various formats, such as lowercase,
/// which can be particularly useful for generating user-friendly display strings or for serialization purposes.
/// </remarks>
[Information(nameof(BooleanExtensions), Status = Status.Available)]
public static class BooleanExtensions
{

	/// <summary>
	/// Converts to <see cref="bool" /> value to lowercase.
	/// </summary>
	/// <param name="value">if set to <c>true</c> [value].</param>
	/// <returns>System.String.</returns>
	[Pure]
	[return: NotNull]
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available, BenchmarkStatus = BenchmarkStatus.NotRequired, Documentation = "ADD URL")]
	public static string ToLowerCase(this bool value)
	{
		return value ? Resources.TrueLowerCase : Resources.FalseLowerCase;
	}

}
