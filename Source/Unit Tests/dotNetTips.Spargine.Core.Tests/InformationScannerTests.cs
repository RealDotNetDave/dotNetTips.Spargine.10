// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="InformationScannerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class InformationScannerTests
{
	[TestMethod]
	public void GetInformationMetadata_FastStringBuilderAssembly_ReturnsTypeAndMemberEntries()
	{
		// Arrange
		var assembly = typeof(FastStringBuilder).Assembly;

		// Act
		var items = InformationScanner.GetInformationMetadata(assembly).ToArray();

		// Assert - at least one type-level entry for FastStringBuilder
		Assert.IsTrue(items.Any(i => i.TypeName != null && i.TypeName.EndsWith("FastStringBuilder")), "Expected at least one InformationMetadata entry for FastStringBuilder type.");

		// Assert - ensure a member entry exists for Format method
		Assert.IsTrue(items.Any(i => i.TypeName != null && i.TypeName.EndsWith("FastStringBuilder") && i.MemberName == "Format" && i.MemberKind == "Method"), "Expected a member-level InformationMetadata entry for FastStringBuilder.Format method.");
	}
}
