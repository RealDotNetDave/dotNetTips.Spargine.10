// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-14-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="PasswordHasherTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using DotNetTips.Spargine.Core.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Security;

[TestClass]
public class PasswordHasherTests
{

	[TestMethod]
	public void HashPassword_Argon2_ReturnsHashedPassword()
	{
		// Arrange
		var password = "TestPassword123";

		// Act
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.Argon2);

		// Assert
		Assert.IsNotNull(hashedPassword);
		Assert.AreNotEqual(password, hashedPassword);
	}

	[TestMethod]
	public void HashPassword_DefaultAlgorithm_UsesPBKDF2()
	{
		// Arrange
		var password = "TestPassword123";

		// Act
		var hashedPassword = PasswordHasher.HashPassword(password);

		// Assert
		Assert.IsNotNull(hashedPassword);
		Assert.AreNotEqual(password, hashedPassword);

		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.PBKDF2);

		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void HashPassword_NullPassword_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => PasswordHasher.HashPassword(null!));
	}

	[TestMethod]
	public void HashPassword_PBKDF2_ReturnsHashedPassword()
	{
		// Arrange
		var password = "TestPassword123";

		// Act
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.PBKDF2);

		// Assert
		Assert.IsNotNull(hashedPassword);
		Assert.AreNotEqual(password, hashedPassword);
	}

	[TestMethod]
	public void HashPassword_SHA256_ReturnsHashedPassword()
	{
		// Arrange
		var password = "TestPassword123";

		// Act
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA256);

		// Assert
		Assert.IsNotNull(hashedPassword);
		Assert.AreNotEqual(password, hashedPassword);
	}

	[TestMethod]
	public void HashPassword_SHA3_ReturnsHashedPassword()
	{
		// Arrange
		var password = "TestPassword123";

		// Act
		var hashedPassword256 = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3256);
		var hashedPassword384 = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3384);
		var hashedPassword512 = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3512);

		// Assert
		Assert.IsNotNull(hashedPassword256);
		Assert.IsNotNull(hashedPassword384);
		Assert.IsNotNull(hashedPassword512);
		Assert.AreNotEqual(password, hashedPassword256);
		Assert.AreNotEqual(password, hashedPassword384);
		Assert.AreNotEqual(password, hashedPassword512);
	}

	[TestMethod]
	public void HashPassword_SHAKE_ReturnsHashedPassword()
	{
		// Arrange
		var password = "TestPassword123";

		// Act
		var hashedPassword128 = PasswordHasher.HashPassword(password, HashAlgorithmType.Shake128);
		var hashedPassword256 = PasswordHasher.HashPassword(password, HashAlgorithmType.Shake256);

		// Assert
		Assert.IsNotNull(hashedPassword128);
		Assert.IsNotNull(hashedPassword256);
		Assert.AreNotEqual(password, hashedPassword128);
		Assert.AreNotEqual(password, hashedPassword256);
	}

	[TestMethod]
	public void HashPassword_UnsupportedAlgorithm_ThrowsNotSupportedException()
	{
		// Arrange
		var password = "TestPassword123";

		// Act & Assert
		Assert.ThrowsExactly<NotSupportedException>(() => PasswordHasher.HashPassword(password, (HashAlgorithmType)999));
	}

	[TestMethod]
	public void VerifyHashedPassword_Argon2_Failed()
	{
		// Arrange
		var password = "TestPassword123";
		var wrongPassword = "WrongPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.Argon2);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, wrongPassword, HashAlgorithmType.Argon2);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_Argon2_Success()
	{
		// Arrange
		var password = "TestPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.Argon2);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.Argon2);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_EmptyHashedPassword_ThrowsArgumentNullException()
	{
		// Arrange
		var password = "TestPassword123";

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => PasswordHasher.VerifyHashedPassword(string.Empty, password));
	}

	[TestMethod]
	public void VerifyHashedPassword_EmptyPassword_ThrowsArgumentNullException()
	{
		// Arrange
		var hashedPassword = PasswordHasher.HashPassword("TestPassword123");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => PasswordHasher.VerifyHashedPassword(hashedPassword, string.Empty));
	}

	[TestMethod]
	public void VerifyHashedPassword_NullHashedPassword_ThrowsArgumentNullException()
	{
		// Arrange
		var password = "TestPassword123";

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => PasswordHasher.VerifyHashedPassword(null!, password));
	}

	[TestMethod]
	public void VerifyHashedPassword_NullPassword_ThrowsArgumentNullException()
	{
		// Arrange
		var hashedPassword = PasswordHasher.HashPassword("TestPassword123");

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => PasswordHasher.VerifyHashedPassword(hashedPassword, null!));
	}

	[TestMethod]
	public void VerifyHashedPassword_PBKDF2_Failed()
	{
		// Arrange
		var password = "TestPassword123";
		var wrongPassword = "WrongPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.PBKDF2);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, wrongPassword, HashAlgorithmType.PBKDF2);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_PBKDF2_Success()
	{
		// Arrange
		var password = "TestPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.PBKDF2);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.PBKDF2);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_SHA256_Failed()
	{
		// Arrange
		var password = "TestPassword123";
		var wrongPassword = "WrongPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA256);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, wrongPassword, HashAlgorithmType.SHA256);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_SHA256_Success()
	{
		// Arrange
		var password = "TestPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA256);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.SHA256);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_SHA3256_Failed()
	{
		// Arrange
		var password = "TestPassword123";
		var wrongPassword = "WrongPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3256);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, wrongPassword, HashAlgorithmType.SHA3256);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_SHA3256_Success()
	{
		// Arrange
		var password = "TestPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3256);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.SHA3256);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_SHA3384_Failed()
	{
		// Arrange
		var password = "TestPassword123";
		var wrongPassword = "WrongPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3384);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, wrongPassword, HashAlgorithmType.SHA3384);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_SHA3384_Success()
	{
		// Arrange
		var password = "TestPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3384);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.SHA3384);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_SHA3512_Failed()
	{
		// Arrange
		var password = "TestPassword123";
		var wrongPassword = "WrongPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3512);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, wrongPassword, HashAlgorithmType.SHA3512);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_SHA3512_Success()
	{
		// Arrange
		var password = "TestPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA3512);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.SHA3512);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_Shake128_Failed()
	{
		// Arrange
		var password = "TestPassword123";
		var wrongPassword = "WrongPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.Shake128);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, wrongPassword, HashAlgorithmType.Shake128);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_Shake128_Success()
	{
		// Arrange
		var password = "TestPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.Shake128);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.Shake128);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_Shake256_Failed()
	{
		// Arrange
		var password = "TestPassword123";
		var wrongPassword = "WrongPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.Shake256);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, wrongPassword, HashAlgorithmType.Shake256);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_Shake256_Success()
	{
		// Arrange
		var password = "TestPassword123";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.Shake256);

		// Act
		var result = PasswordHasher.VerifyHashedPassword(hashedPassword, password, HashAlgorithmType.Shake256);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifyHashedPassword_UnsupportedAlgorithm_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var hashedPassword = "SomeHashedPassword";
		var password = "TestPassword123";

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => PasswordHasher.VerifyHashedPassword(hashedPassword, password, (HashAlgorithmType)999));
	}
}
