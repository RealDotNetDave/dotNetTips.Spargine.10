// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="FastStringBuilderFormatTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Tests for the formatting helpers added to FastStringBuilder.
// </summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class FastStringBuilderFormatTests
{
	[TestMethod]
	public void FormatCurrentCulture_FormatsUsingCurrentCulture()
	{
		var originalCulture = CultureInfo.CurrentCulture;

		try
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");

			var result = FastStringBuilder.FormatCurrentCulture("{0:N1}", 1234.5);

			Assert.AreEqual("1 234,5", result);
		}
		finally
		{
			CultureInfo.CurrentCulture = originalCulture;
		}
	}

	[TestMethod]
	public void FormatInvariant_FormatsUsingInvariantCulture()
	{
		var result = FastStringBuilder.FormatInvariant("{0:N1}", 1234.5);

		Assert.AreEqual("1,234.5", result);
	}
}
