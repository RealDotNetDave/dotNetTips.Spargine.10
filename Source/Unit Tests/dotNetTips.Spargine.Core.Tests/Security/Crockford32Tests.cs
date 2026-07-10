// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="Crockford32Tests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Security;

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]
[TestClass]
public class Crockford32Tests
{

	[TestMethod]
	public void Decode_InvalidCharacter_ThrowsFormatException()
	{
		Assert.ThrowsExactly<FormatException>(() => Crockford32.Decode("ABC!"));
	}
	[TestMethod]
	public void Decode_ValidEncodedValue_ReturnsOriginalBytes()
	{
		var expected = new byte[] { 1, 2, 3, 4, 5, 6 };
		var encoded = Crockford32.Encode(expected);

		var result = Crockford32.Decode(encoded);

		CollectionAssert.AreEqual(expected, result);
	}

	[TestMethod]
	public void Encode_EmptyInput_ReturnsEmptyString()
	{
		var result = Crockford32.Encode([]);

		Assert.AreEqual(string.Empty, result);
	}
}
