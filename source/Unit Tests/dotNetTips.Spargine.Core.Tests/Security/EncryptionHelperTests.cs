// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="EncryptionHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core.Security;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]
[TestClass]
public class EncryptionHelperTests
{

	private string _cipherText;
	private byte[] _iv;
	private byte[] _key;

	[TestMethod]
	public void AesDecrypt_NullCipherText_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => EncryptionHelper.AesDecrypt(null, this._key, this._iv));
	}

	[TestMethod]
	public void AesDecrypt_NullIv_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => EncryptionHelper.AesDecrypt(this._cipherText, this._key, null));
	}

	[TestMethod]
	public void AesDecrypt_NullKey_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => EncryptionHelper.AesDecrypt(this._cipherText, null, this._iv));
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
	public void AesGcmDecrypt_InvalidKeyLength_Throws()
	{
		var key = new byte[16]; // Invalid length
		var payload = EncryptionHelper.AesGcmEncrypt("test", EncryptionHelper.GenerateAesGcmKey());
		_ = Assert.ThrowsExactly<ArgumentException>(() =>
			EncryptionHelper.AesGcmDecrypt(payload, key));
	}

	[TestMethod]
	public void AesGcmEncrypt_And_Decrypt_RoundTrip_Succeeds()
	{
		var key = EncryptionHelper.GenerateAesGcmKey();

		var testString = RandomData.GenerateWord(15);

		var encrypted = EncryptionHelper.AesGcmEncrypt(testString, key, this._iv);

		Assert.IsFalse(string.IsNullOrWhiteSpace(encrypted));

		var decrypted = EncryptionHelper.AesGcmDecrypt(encrypted, key, this._iv);

		Assert.AreEqual(testString, decrypted);
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
		var testString = RandomData.GenerateWord(15);

		var result = testString.ComputeSHA256Hash();

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
		var testString = RandomData.GenerateWord(15);

		var key = EncryptionHelper.GenerateRandomKey();

		var cipherText = EncryptionHelper.SimpleSHA256Encrypt(testString, key);

		Assert.IsTrue(string.IsNullOrEmpty(cipherText) is false);

		var plainText = EncryptionHelper.SimpleSHA256Decrypt(cipherText, key);

		Assert.IsTrue(string.IsNullOrEmpty(plainText) is false);

		Assert.IsTrue(plainText.Equals(testString));
	}

	[TestInitialize]
	public void TestInitialize()
	{
		var aes = Aes.Create();

		this._key = aes.Key;
		this._iv = aes.IV;


		this._cipherText = EncryptionHelper.AesEncrypt("Test", this._key, this._iv);
	}

	[TestMethod]
	public void VerifySHA256HashedPassword_NullHashedPassword_ThrowsArgumentNullException()
	{
		// Act and Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => EncryptionHelper.VerifySHA256HashedPassword(null, "TestPassword"));
	}

}

