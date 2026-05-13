// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-29-2018
//
// Last Modified By : David McCarter
// Last Modified On : 01-04-2026
// ***********************************************************************
// <copyright file="ColorExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions methods for the Color type.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Drawing;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Color"/> type, enhancing functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class includes methods for operations such as averaging the RGB values of a collection of colors. It is part of the DotNetTips.Spargine.Extensions
/// library, which provides a wide range of extension methods for .NET types, aiming to improve code readability and efficiency.
/// </remarks>
[Information(Status = Status.Available)]
public static class ColorExtensions
{

	/// <summary>
	/// Averages the specified colors in the collection.
	/// Validates that <paramref name="colors" /> is not null and has items.
	/// </summary>
	/// <param name="colors">The colors.</param>
	/// <returns>Color.</returns>
	/// <exception cref="ArgumentOutOfRangeException">colors - colors</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(Average), "David McCarter", "1/1/2015", UnitTestStatus = UnitTestStatus.None, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Color Average([DisallowNull] this IEnumerable<Color> colors)
	{
		colors = colors.ArgumentItemsExists();

		return Color.FromArgb(colors.Average(c => c.R).Round(), colors.Average(c => c.G).Round(), colors.Average(c => c.B).Round());
	}

}
