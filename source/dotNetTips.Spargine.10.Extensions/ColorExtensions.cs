// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-29-2018
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="ColorExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="System.Drawing.Color"/> providing color arithmetic utilities.
// Includes <c>Average</c>, which computes the mean RGB color from a collection of
// <see cref="System.Drawing.Color"/> values.
// </summary>
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
/// This class includes <c>Average</c>, which computes a blended color by averaging the R, G, and B channel values
/// across a collection of <see cref="Color"/> instances. It is part of the DotNetTips.Spargine.Extensions library,
/// which provides a wide range of extension methods for .NET types, aiming to improve code readability and efficiency.
/// </remarks>
[Information(Status = Status.Available)]
public static class ColorExtensions
{

	/// <summary>
	/// Averages the specified colors in the collection by computing the mean R, G, and B channel values.
	/// </summary>
	/// <param name="colors">The collection of colors to average. Must not be null and must contain at least one element.</param>
	/// <returns>A <see cref="Color"/> whose R, G, and B components are the rounded averages of the input colors.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="colors"/> is null or contains no elements.</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(Average), "David McCarter", "1/1/2015", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static Color Average([DisallowNull] this IEnumerable<Color> colors)
	{
		colors = colors.ArgumentItemsExists();

		return Color.FromArgb(colors.Average(c => c.R).Round(), colors.Average(c => c.G).Round(), colors.Average(c => c.B).Round());
	}

}
