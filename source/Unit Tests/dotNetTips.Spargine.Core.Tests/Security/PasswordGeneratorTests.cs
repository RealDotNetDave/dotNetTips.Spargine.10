// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-12-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="PasswordGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]
[TestClass]
public class PasswordGeneratorTests
{

	[TestMethod]
	public void GeneratePassword_ContainsRequiredCharacters()
	{
		// Arrange
		int length = 12;

		// Act
		var password = PasswordGenerator.GeneratePassword(length);

		// Assert
		Assert.IsTrue(password.Any(char.IsUpper), "Password should contain at least one uppercase letter.");
		Assert.IsTrue(password.Any(char.IsLower), "Password should contain at least one lowercase letter.");
		Assert.IsTrue(password.Any(char.IsDigit), "Password should contain at least one digit.");
		Assert.IsTrue(password.Any(ch => "!@#$%^&*()_-+=<>?".Contains(ch)), "Password should contain at least one special character.");
	}

	[TestMethod]
	public void GeneratePassword_InvalidLength_ThrowsException()
	{
		// Arrange
		int length = 7;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => PasswordGenerator.GeneratePassword(length));
	}

	[TestMethod]
	public void GeneratePassword_ValidLength_ReturnsPassword()
	{
		// Arrange
		int length = 12;

		// Act
		var password = PasswordGenerator.GeneratePassword(length);

		// Assert
		Assert.IsNotNull(password);
		Assert.AreEqual(length, password.Length);
	}
}
