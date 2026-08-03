// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 08-03-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="ColorExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public sealed class ColorExtensionsTests
{
	[TestMethod]
	public void Average_EmptyColors_ThrowsArgumentNullException()
	{
		IEnumerable<Color> colors = [];

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => colors.Average());
	}

	[TestMethod]
	public void Average_NullColors_ThrowsArgumentNullException()
	{
		IEnumerable<Color> colors = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => colors.Average());
	}

	[TestMethod]
	public void Average_SingleColor_ReturnsSameColor()
	{
		IEnumerable<Color> colors = [Color.FromArgb(12, 34, 56)];

		var result = colors.Average();

		Assert.AreEqual(Color.FromArgb(12, 34, 56), result);
	}

	[TestMethod]
	public void Average_ValidColors_ReturnsAveragedColor()
	{
		IEnumerable<Color> colors = [
			Color.FromArgb(10, 20, 30),
			Color.FromArgb(20, 40, 60),
			Color.FromArgb(30, 60, 90)
		];

		var result = colors.Average();

		Assert.AreEqual(Color.FromArgb(20, 40, 60), result);
	}
}
