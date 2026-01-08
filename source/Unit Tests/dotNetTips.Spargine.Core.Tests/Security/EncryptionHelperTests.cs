// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-08-2026
// ***********************************************************************
// <copyright file="EncryptionHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
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

	[TestMethod]
	public void AesDecrypt_ValidInputs_ReturnsDecryptedString()
	{
		// Act
		var result = EncryptionHelper.AesDecrypt(this._cipherText, this._key, this._iv);

		// Assert
		Assert.AreEqual("Test", result);
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
		Assert.IsTrue(ex.Message.Contains("Unsupported payload version"));
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
	public void AesGcmEncrypt_And_Decrypt_RoundTrip_Succeeds()
	{
		var key = EncryptionHelper.GenerateAesGcmKey();

		var encrypted = EncryptionHelper.AesGcmEncrypt(this._plainText, key, this._iv);

		Assert.IsFalse(string.IsNullOrWhiteSpace(encrypted));

		var decrypted = EncryptionHelper.AesGcmDecrypt(encrypted, key, this._iv);

		Assert.AreEqual(this._plainText, decrypted);
	}

	[TestMethod]
	public void AesGcmEncrypt_InvalidKeyLength_Throws()
	{
		var key = new byte[16]; // Invalid length
		_ = Assert.ThrowsExactly<ArgumentException>(() =>
			EncryptionHelper.AesGcmEncrypt("test", key));
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
		Assert.AreEqual(32, key.Length);
	}

	[TestMethod]
	public void GenerateAesIVTest()
	{
		var result = EncryptionHelper.GenerateAesIV();

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void GenerateAesKeyTest()
	{
		var result = EncryptionHelper.GenerateAesKey();

		Assert.IsTrue(result.IsNotEmpty());
	}

	[TestMethod]
	public void SimpleSHA256EncryptDecryptStringTest()
	{
		var key = EncryptionHelper.GenerateRandomKey();

		var cipherText = EncryptionHelper.SimpleSHA256Encrypt(this._plainText, key);

		Assert.IsTrue(string.IsNullOrEmpty(cipherText) is false);

		var plainText = EncryptionHelper.SimpleSHA256Decrypt(cipherText, key);

		Assert.IsTrue(string.IsNullOrEmpty(plainText) is false);

		Assert.IsTrue(plainText.Equals(this._plainText));
	}

	[TestInitialize]
	public void TestInitialize()
	{
		var aes = Aes.Create();

		this._key = aes.Key;
		this._iv = aes.IV;


		this._cipherText = EncryptionHelper.AesEncrypt(this._plainText, this._key, this._iv);
		this._plainText = RandomData.GenerateWord(15);
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_NullHashedPassword_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => EncryptionHelper.VerifySHA256HashedPassword(null, "TestPassword"));
	}

}

