// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="EncryptionHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]
[TestClass]
public class EncryptionHelperTests
{

	private string _cipherText;
	private byte[] _iv;
	private byte[] _key;
	private string _plainText = "Test";

	public EncryptionHelperTests()
	{
		using var aes = Aes.Create();

		this._key = aes.Key;
		this._iv = aes.IV;

		// Use cross-platform Aes.Create() for setup so tests run on all platforms.
		// EncryptionHelper.AesEncrypt uses AesCng which is Windows-only.
		using var encryptor = aes.CreateEncryptor(this._key, this._iv);
		using var ms = new MemoryStream();
		using var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
		using (var sw = new StreamWriter(cs))
		{
			sw.Write(this._plainText);
		}

		this._cipherText = Convert.ToBase64String(ms.ToArray());
		this._plainText = RandomData.GenerateWord(15);
	}

	[TestMethod]
	public void AesDecrypt_ValidInputs_ReturnsDecryptedString()
	{
		// Act
		var result = EncryptionHelper.AesDecrypt(this._cipherText, this._key, this._iv);

		// Assert
		Assert.AreEqual("Test", result);
	}

	[TestMethod]
	public void AesDecrypt_NullCipherText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesDecrypt(null, this._key, this._iv));
	}

	[TestMethod]
	public void AesDecrypt_EmptyCipherText_ThrowsArgumentException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesDecrypt(string.Empty, this._key, this._iv));
	}

	[TestMethod]
	public void AesDecrypt_NullKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesDecrypt(this._cipherText, null, this._iv));
	}

	[TestMethod]
	public void AesDecrypt_NullIv_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesDecrypt(this._cipherText, this._key, null));
	}

	[TestMethod]
	public void AesDecrypt_InvalidCipherText_ThrowsInvalidOperationException()
	{
		// Arrange - use invalid base64 that will cause decryption failure
		var invalidCipher = Convert.ToBase64String(new byte[32]);

		// Act and Assert
		_ = Assert.ThrowsExactly<InvalidOperationException>(() =>
			EncryptionHelper.AesDecrypt(invalidCipher, this._key, this._iv));
	}

	[TestMethod]
	public void AesEncrypt_ValidInputs_ReturnsEncryptedString()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("AesEncrypt uses AesCng which is only available on Windows.");
			return;
		}

		// Act
		var result = EncryptionHelper.AesEncrypt("Hello World", this._key, this._iv);

		// Assert
		Assert.IsFalse(string.IsNullOrWhiteSpace(result));
	}

	[TestMethod]
	public void AesEncrypt_NullPlainText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesEncrypt(null, this._key, this._iv));
	}

	[TestMethod]
	public void AesEncrypt_EmptyPlainText_ThrowsArgumentException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesEncrypt(string.Empty, this._key, this._iv));
	}

	[TestMethod]
	public void AesEncrypt_NullKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesEncrypt("test", null, this._iv));
	}

	[TestMethod]
	public void AesEncrypt_NullIv_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesEncrypt("test", this._key, null));
	}

	[TestMethod]
	public void AesEncryptDecrypt_RoundTrip_Succeeds()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("AesEncrypt uses AesCng which is only available on Windows.");
			return;
		}

		// Arrange
		var plainText = "Round trip test message";

		// Act
		var encrypted = EncryptionHelper.AesEncrypt(plainText, this._key, this._iv);
		var decrypted = EncryptionHelper.AesDecrypt(encrypted, this._key, this._iv);

		// Assert
		Assert.AreEqual(plainText, decrypted);
	}

	[TestMethod]
	public void AesGcmDecrypt_InvalidKeyLength_Throws()
	{
		var key = new byte[16]; // Invalid length
		var payload = EncryptionHelper.AesGcmEncrypt(this._plainText, EncryptionHelper.GenerateAesGcmKey());
		_ = Assert.ThrowsExactly<ArgumentException>(() =>
			EncryptionHelper.AesGcmDecrypt(payload, key));
	}

	[TestMethod]
	public void AesGcmDecrypt_InvalidPayloadLength_ThrowsCryptographicException()
	{
		// Arrange
		var key = EncryptionHelper.GenerateAesGcmKey();
		var shortPayload = Convert.ToBase64String(new byte[10]); // Too short

		// Act and Assert
		_ = Assert.ThrowsExactly<CryptographicException>(() =>
			EncryptionHelper.AesGcmDecrypt(shortPayload, key));
	}

	[TestMethod]
	public void AesGcmDecrypt_TamperedCiphertext_ThrowsCryptographicException()
	{
		// Arrange
		var key = EncryptionHelper.GenerateAesGcmKey();
		var encrypted = EncryptionHelper.AesGcmEncrypt(this._plainText, key);

		// Tamper with the encrypted payload
		var bytes = Convert.FromBase64String(encrypted);
		bytes[bytes.Length / 2] ^= 0xFF; // Flip bits in the middle
		var tamperedPayload = Convert.ToBase64String(bytes);

		// Act and Assert
		_ = Assert.ThrowsExactly<AuthenticationTagMismatchException>(() =>
			EncryptionHelper.AesGcmDecrypt(tamperedPayload, key));
	}

	[TestMethod]
	public void AesGcmDecrypt_UnsupportedVersion_ThrowsCryptographicException()
	{
		// Arrange
		var key = EncryptionHelper.GenerateAesGcmKey();
		var invalidVersionPayload = new byte[50];
		invalidVersionPayload[0] = 99; // Invalid version
		RandomNumberGenerator.Fill(invalidVersionPayload.AsSpan(1));
		var base64Payload = Convert.ToBase64String(invalidVersionPayload);

		// Act and Assert
		var ex = Assert.ThrowsExactly<CryptographicException>(() =>
			EncryptionHelper.AesGcmDecrypt(base64Payload, key));
		Assert.Contains("Unsupported payload version", ex.Message);
	}

	[TestMethod]
	public void AesGcmDecrypt_WithMismatchedAAD_ThrowsCryptographicException()
	{
		// Arrange
		var key = EncryptionHelper.GenerateAesGcmKey();
		var aad1 = Encoding.UTF8.GetBytes("AAD1");
		var aad2 = Encoding.UTF8.GetBytes("AAD2");
		var encrypted = EncryptionHelper.AesGcmEncrypt(this._plainText, key, aad1);

		// Act and Assert
		_ = Assert.ThrowsExactly<AuthenticationTagMismatchException>(() =>
			EncryptionHelper.AesGcmDecrypt(encrypted, key, aad2));
	}

	[TestMethod]
	public void AesGcmDecrypt_NullPayload_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesGcmDecrypt(null, EncryptionHelper.GenerateAesGcmKey()));
	}

	[TestMethod]
	public void AesGcmDecrypt_EmptyPayload_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesGcmDecrypt(string.Empty, EncryptionHelper.GenerateAesGcmKey()));
	}

	[TestMethod]
	public void AesGcmDecrypt_NullKey_ThrowsArgumentNullException()
	{
		// Arrange
		var payload = EncryptionHelper.AesGcmEncrypt("test", EncryptionHelper.GenerateAesGcmKey());

		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesGcmDecrypt(payload, null));
	}

	[TestMethod]
	public void AesGcmDecrypt_InvalidBase64_ThrowsCryptographicException()
	{
		// Arrange
		var key = EncryptionHelper.GenerateAesGcmKey();

		// Act and Assert
		_ = Assert.ThrowsExactly<CryptographicException>(() =>
			EncryptionHelper.AesGcmDecrypt("!!!not-valid-base64!!!", key));
	}

	[TestMethod]
	public void AesGcmEncrypt_And_Decrypt_RoundTrip_Succeeds()
	{
		var key = EncryptionHelper.GenerateAesGcmKey();

		var encrypted = EncryptionHelper.AesGcmEncrypt(this._plainText, key, this._iv);

		Assert.IsFalse(string.IsNullOrWhiteSpace(encrypted));

		var decrypted = EncryptionHelper.AesGcmDecrypt(encrypted, key, this._iv);

		Assert.AreEqual(this._plainText, decrypted);
	}

	[TestMethod]
	public void AesGcmEncrypt_And_Decrypt_WithoutAAD_RoundTrip_Succeeds()
	{
		// Arrange
		var key = EncryptionHelper.GenerateAesGcmKey();
		var plainText = "Test without AAD";

		// Act
		var encrypted = EncryptionHelper.AesGcmEncrypt(plainText, key);
		var decrypted = EncryptionHelper.AesGcmDecrypt(encrypted, key);

		// Assert
		Assert.AreEqual(plainText, decrypted);
	}

	[TestMethod]
	public void AesGcmEncrypt_InvalidKeyLength_Throws()
	{
		var key = new byte[16]; // Invalid length
		_ = Assert.ThrowsExactly<ArgumentException>(() =>
			EncryptionHelper.AesGcmEncrypt("test", key));
	}

	[TestMethod]
	public void AesGcmEncrypt_NullPlainText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesGcmEncrypt(null, EncryptionHelper.GenerateAesGcmKey()));
	}

	[TestMethod]
	public void AesGcmEncrypt_EmptyPlainText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesGcmEncrypt(string.Empty, EncryptionHelper.GenerateAesGcmKey()));
	}

	[TestMethod]
	public void AesGcmEncrypt_NullKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.AesGcmEncrypt("test", null));
	}

	[TestMethod]
	public void ComputeSha256HashTest()
	{
		var result = this._plainText.ComputeHash();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void ComputeSHA384HashTest()
	{
		var result = this._plainText.ComputeHash(HashType.SHA384);

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void ComputeSHA512HashTest()
	{
		var result = this._plainText.ComputeHash(HashType.SHA512);

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void GenerateAesGcmKey_Returns32Bytes()
	{
		var key = EncryptionHelper.GenerateAesGcmKey();
		Assert.IsNotNull(key);
		Assert.HasCount(32, key);
	}

	[TestMethod]
	public void GenerateAesGcmKey_ReturnsDifferentKeysOnEachCall()
	{
		// Act
		var key1 = EncryptionHelper.GenerateAesGcmKey();
		var key2 = EncryptionHelper.GenerateAesGcmKey();

		// Assert
		Assert.IsFalse(key1.AsSpan().SequenceEqual(key2));
	}

	[TestMethod]
	public void GenerateAesIVTest()
	{
		var result = EncryptionHelper.GenerateAesIV();

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void GenerateAesIV_Returns16Bytes()
	{
		// Act
		var result = EncryptionHelper.GenerateAesIV();

		// Assert
		Assert.HasCount(16, result);
	}

	[TestMethod]
	public void GenerateAesKeyTest()
	{
		var result = EncryptionHelper.GenerateAesKey();

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void GenerateAesKey_Returns32Bytes()
	{
		// Act
		var result = EncryptionHelper.GenerateAesKey();

		// Assert
		Assert.HasCount(32, result);
	}

	[TestMethod]
	public void GenerateRandomKey_ReturnsNonEmptyString()
	{
		// Act
		var result = EncryptionHelper.GenerateRandomKey();

		// Assert
		Assert.IsFalse(string.IsNullOrWhiteSpace(result));
	}

	[TestMethod]
	public void GenerateRandomKey_ReturnsDifferentKeysOnEachCall()
	{
		// Act
		var key1 = EncryptionHelper.GenerateRandomKey();
		var key2 = EncryptionHelper.GenerateRandomKey();

		// Assert
		Assert.AreNotEqual(key1, key2);
	}

	[TestMethod]
	public void SimpleSHA256EncryptDecryptStringTest()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("SimpleSHA256Encrypt uses AesCng which is only available on Windows.");
			return;
		}

		var key = EncryptionHelper.GenerateRandomKey();

		var cipherText = EncryptionHelper.SimpleSHA256Encrypt(this._plainText, key);

		Assert.IsTrue(string.IsNullOrEmpty(cipherText) is false);

		var plainText = EncryptionHelper.SimpleSHA256Decrypt(cipherText, key);

		Assert.IsTrue(string.IsNullOrEmpty(plainText) is false);

		Assert.IsTrue(plainText.Equals(this._plainText));
	}

	[TestMethod]
	public void SimpleSHA256Decrypt_NullCipherText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.SimpleSHA256Decrypt(null, "key"));
	}

	[TestMethod]
	public void SimpleSHA256Decrypt_EmptyCipherText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.SimpleSHA256Decrypt(string.Empty, "key"));
	}

	[TestMethod]
	public void SimpleSHA256Decrypt_NullKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.SimpleSHA256Decrypt("cipher", null));
	}

	[TestMethod]
	public void SimpleSHA256Decrypt_EmptyKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.SimpleSHA256Decrypt("cipher", string.Empty));
	}

	[TestMethod]
	public void SimpleSHA256Encrypt_NullPlainText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.SimpleSHA256Encrypt(null, "key"));
	}

	[TestMethod]
	public void SimpleSHA256Encrypt_EmptyPlainText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.SimpleSHA256Encrypt(string.Empty, "key"));
	}

	[TestMethod]
	public void SimpleSHA256Encrypt_NullKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.SimpleSHA256Encrypt("test", null));
	}

	[TestMethod]
	public void SimpleSHA256Encrypt_EmptyKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.SimpleSHA256Encrypt("test", string.Empty));
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_NullHashedPassword_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => EncryptionHelper.VerifySHA256HashedPassword(null, "TestPassword"));
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_NullPassword_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.VerifySHA256HashedPassword("hashedPassword", null));
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_EmptyHashedPassword_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.VerifySHA256HashedPassword(string.Empty, "TestPassword"));
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_EmptyPassword_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() =>
			EncryptionHelper.VerifySHA256HashedPassword("hashedPassword", string.Empty));
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_ValidPassword_ReturnsSuccess()
	{
		// Arrange
		var password = "TestPassword123!";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA256);

		// Act
		var result = EncryptionHelper.VerifySHA256HashedPassword(hashedPassword, password);

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Success, result);
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_InvalidPassword_ReturnsFailed()
	{
		// Arrange
		var password = "TestPassword123!";
		var hashedPassword = PasswordHasher.HashPassword(password, HashAlgorithmType.SHA256);

		// Act
		var result = EncryptionHelper.VerifySHA256HashedPassword(hashedPassword, "WrongPassword!");

		// Assert
		Assert.AreEqual(PasswordVerificationResult.Failed, result);
	}

}

