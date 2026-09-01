// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-12-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="PasswordGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
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

	// Must match the combined character pool (Uppercase + Lowercase + Digits + SpecialChars) in PasswordGenerator.
	private const string ValidCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=<>?";

	[TestMethod]
	public void GeneratePassword_ContainsRequiredCharacters()
	{
		// Arrange
		var length = 12;

		// Act
		var password = PasswordGenerator.GeneratePassword(length);

		// Assert
		Assert.IsTrue(password.Any(char.IsUpper), "Password should contain at least one uppercase letter.");
		Assert.IsTrue(password.Any(char.IsLower), "Password should contain at least one lowercase letter.");
		Assert.IsTrue(password.Any(char.IsDigit), "Password should contain at least one digit.");
		Assert.IsTrue(password.Any(ch => "!@#$%^&*()_-+=<>?".Contains(ch)), "Password should contain at least one special character.");
	}

	[TestMethod]
	public void GeneratePassword_DefaultLength_ReturnsPasswordOfLength8()
	{
		// Act
		var password = PasswordGenerator.GeneratePassword();

		// Assert
		Assert.IsNotNull(password);
		Assert.AreEqual(8, password.Length, "Default password length should be 8.");
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
	public void GeneratePassword_LargeLength_ReturnsCorrectLength()
	{
		// Arrange
		int length = 256;

		// Act
		var password = PasswordGenerator.GeneratePassword(length);

		// Assert
		Assert.IsNotNull(password);
		Assert.AreEqual(length, password.Length, "Password should match the requested large length.");
	}

	[TestMethod]
	public void GeneratePassword_MinimumLength_ReturnsPasswordOfLength8()
	{
		// Arrange
		int length = 8;

		// Act
		var password = PasswordGenerator.GeneratePassword(length);

		// Assert
		Assert.IsNotNull(password);
		Assert.AreEqual(8, password.Length, "Password should be exactly 8 characters at the minimum boundary.");
		Assert.IsTrue(password.Any(char.IsUpper), "Password should contain at least one uppercase letter.");
		Assert.IsTrue(password.Any(char.IsLower), "Password should contain at least one lowercase letter.");
		Assert.IsTrue(password.Any(char.IsDigit), "Password should contain at least one digit.");
		Assert.IsTrue(password.Any(ch => "!@#$%^&*()_-+=<>?".Contains(ch)), "Password should contain at least one special character.");
	}

	[TestMethod]
	public void GeneratePassword_MultipleCalls_ReturnsDifferentPasswords()
	{
		// Act
		var passwords = new HashSet<string>();

		for (var i = 0; i < 50; i++)
		{
			passwords.Add(PasswordGenerator.GeneratePassword(16));
		}

		// Assert
		Assert.IsTrue(passwords.Count >= 48, "50 calls with length 16 should produce at least 48 unique passwords.");
	}

	[TestMethod]
	public void GeneratePassword_NegativeLength_ThrowsException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => PasswordGenerator.GeneratePassword(-1));
	}

	[TestMethod]
	public void GeneratePassword_OnlyContainsValidCharacters()
	{
		// Act
		var password = PasswordGenerator.GeneratePassword(64);

		// Assert
		foreach (var ch in password)
		{
			Assert.IsTrue(ValidCharacters.Contains(ch), $"Character '{ch}' is not in the valid character pool.");
		}
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

	[TestMethod]
	public void GeneratePassword_ZeroLength_ThrowsException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => PasswordGenerator.GeneratePassword(0));
	}
}
