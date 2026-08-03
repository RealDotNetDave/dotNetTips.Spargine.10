// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="FastStringBuilderFormatTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Tests for the formatting helpers added to FastStringBuilder.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public sealed class FastStringBuilderFormatTests
{
	[TestMethod]
	public void FormatCurrentCulture_ArgumentsAreNull_ReturnsEmptyString()
	{
#pragma warning disable CS8625
		var result = FastStringBuilder.FormatCurrentCulture("{0:N1}", null);
#pragma warning restore CS8625

		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void FormatCurrentCulture_FormatIsNull_ReturnsEmptyString()
	{
#pragma warning disable CS8625
		var result = FastStringBuilder.FormatCurrentCulture(null, 1234.5);
#pragma warning restore CS8625

		Assert.AreEqual(ControlChars.EmptyString, result);
	}

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
	public void FormatCurrentCulture_NoArguments_ReturnsEmptyString()
	{
		var result = FastStringBuilder.FormatCurrentCulture("{0:N1}");

		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void FormatInvariant_ArgumentsAreNull_ReturnsEmptyString()
	{
#pragma warning disable CS8625
		var result = FastStringBuilder.FormatInvariant("{0:N1}", null);
#pragma warning restore CS8625

		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void FormatInvariant_FormatIsNull_ReturnsEmptyString()
	{
#pragma warning disable CS8625
		var result = FastStringBuilder.FormatInvariant(null, 1234.5);
#pragma warning restore CS8625

		Assert.AreEqual(ControlChars.EmptyString, result);
	}

	[TestMethod]
	public void FormatInvariant_FormatsUsingInvariantCulture()
	{
		var result = FastStringBuilder.FormatInvariant("{0:N1}", 1234.5);

		Assert.AreEqual("1,234.5", result);
	}

	[TestMethod]
	public void FormatInvariant_NoArguments_ReturnsEmptyString()
	{
		var result = FastStringBuilder.FormatInvariant("{0:N1}");

		Assert.AreEqual(ControlChars.EmptyString, result);
	}
}
