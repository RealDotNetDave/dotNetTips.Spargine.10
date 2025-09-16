// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 07-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 09-16-2025
// ***********************************************************************
// <copyright file="EncryptionHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides secure encryption and decryption for strings using both AES (Advanced Encryption Standard) in CBC and GCM (Galois/Counter Mode) modes,
// as well as utilities for key and IV generation, password hashing and verification, and SHA256-based helpers.
// Supports authenticated encryption with AES-GCM, ensuring confidentiality and integrity of sensitive data.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Provides a collection of methods for encrypting and decrypting data, generating keys and initialization vectors (IVs),
/// and verifying hashed passwords. It leverages AES (Advanced Encryption Standard) for encryption tasks and SHA256 for hashing,
/// ensuring a high level of security for sensitive data handling.
/// </summary>
[Information(Version = "1", Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineEncryptionHelper")]
public static class EncryptionHelper
{

	private const byte FormatVersion = 1;
	private const int NonceSize = 12; // 96-bit nonce per NIST recommendation
	private const int TagSize = 16;   // 128-bit auth tag (recommended)

	/// <summary>
	/// Generates AES key and initialization vector (IV) based on a SHA256 hash of the provided key.
	/// </summary>
	/// <param name="key">The input key from which to generate the AES key and IV.</param>
	/// <returns>A tuple containing the AES key and IV.</returns>
	/// <remarks>
	/// This method hashes the input key using SHA256 and then uses the hash to generate
	/// a 32-byte AES key and a 16-byte IV. It ensures that the key and IV are derived
	/// from the input key in a consistent and secure manner.
	/// </remarks>
	private static (byte[] key, byte[] iv) GetSHA256HashKeys([NotNull] string key)
	{
		var hash = SHA256.HashData(Encoding.ASCII.GetBytes(key));
		var aesKey = new byte[32];
		var aesIV = new byte[16];

		hash.AsSpan(0, aesKey.Length).CopyTo(aesKey);
		hash.AsSpan(0, aesIV.Length).CopyTo(aesIV);

		return (aesKey, aesIV);
	}

	/// <summary>
	/// Decrypts a string using AES security.
	/// </summary>
	/// <param name="cipherText">The cipher text to decrypt.</param>
	/// <param name="key">The secret key used for decryption. Must be 256 bits (32 bytes) long.</param>
	/// <param name="iv">The initialization vector used for decryption. Must be 128 bits (16 bytes) long.</param>
	/// <returns>The decrypted string.</returns>
	/// <example>
	/// Here is how you can use the <see cref="AesDecrypt"/> method:
	/// <code>
	/// var decryptedString = EncryptionHelper.AesDecrypt(cipherText, key, iv);
	/// Console.WriteLine(decryptedString);
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="cipherText"/>, <paramref name="key"/>, or <paramref name="iv"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown when decryption fails.</exception>
	[Pure]
	[Information(nameof(AesDecrypt), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string AesDecrypt([DisallowNull] string cipherText, [DisallowNull] byte[] key, [DisallowNull] byte[] iv)
	{
		cipherText = cipherText.ArgumentNotNullOrEmpty();
		key = key.ArgumentItemsExists();
		iv = iv.ArgumentItemsExists();

		try
		{

			// Create AesManaged.
			using (var aes = Aes.Create())
			{
				// Create a decryptor.
				using (var decryptor = aes.CreateDecryptor(key, iv))
				{
					// Create the streams used for decryption.
					using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
					{
						// Create crypto stream.
						using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
						{
							// Read crypto stream.
							using (var reader = new StreamReader(cs))
							{
								return reader.ReadToEnd();
							}
						}
					}
				}
			}
		}
		catch (CryptographicException ex)
		{
			throw new InvalidOperationException(Resources.AESDecryptionFailed, ex);
		}
	}

	/// <summary>
	/// Encrypts a string using AES security.
	/// </summary>
	/// <param name="plainText">The plain text to encrypt.</param>
	/// <param name="key">The secret key used for encryption. Must be 256 bits (32 bytes) long.</param>
	/// <param name="iv">The initialization vector used for encryption. Must be 128 bits (16 bytes) long.</param>
	/// <returns>The encrypted string, encoded in Base64.</returns>
	/// <example>
	/// Here is how you can use the <see cref="AesEncrypt"/> method:
	/// <code>
	/// var key = EncryptionHelper.GenerateAesKey();
	/// var iv = EncryptionHelper.GenerateAesIV();
	/// var encryptedString = EncryptionHelper.AesEncrypt("Hello World", key, iv);
	/// Console.WriteLine(encryptedString);
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="plainText"/>, <paramref name="key"/>, or <paramref name="iv"/> is null.</exception>
	/// <exception cref="InvalidOperationException">Thrown when encryption fails.</exception>
	[Pure]
	[SupportedOSPlatform("windows")]
	[Information(nameof(AesEncrypt), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string AesEncrypt([DisallowNull] string plainText, [DisallowNull] byte[] key, [DisallowNull] byte[] iv)
	{
		plainText = plainText.ArgumentNotNullOrEmpty();
		key = key.ArgumentItemsExists();
		iv = iv.ArgumentItemsExists();

		try
		{
			// Create MemoryStream
			using (var ms = new MemoryStream())
			{
				// Create encryptor
				using (var aesCng = new AesCng())
				{
					// Create crypto stream using the CryptoStream class. This class is the key to encryption
					// and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream
					// to encrypt
					using (var cs = new CryptoStream(ms, aesCng.CreateEncryptor(key, iv), CryptoStreamMode.Write))
					{
						// Create StreamWriter and write data to a stream
						using (var sw = new StreamWriter(cs))
						{
							sw.Write(plainText);
							sw.Flush();
						}
					}

					return Convert.ToBase64String(ms.ToArray());
				}
			}
		}
		catch (CryptographicException ex)
		{
			throw new InvalidOperationException(Resources.AESEncryptionFailed, ex);
		}
	}

	/// <summary>
	/// Decrypts a string using AES-GCM (Galois/Counter Mode) authenticated encryption.
	/// </summary>
	/// <param name="base64Payload">
	/// The encrypted payload as a Base64 string. The payload must be in the format: [version][nonce][ciphertext][tag].
	/// </param>
	/// <param name="key">
	/// The 256-bit (32 byte) key used for decryption.
	/// </param>
	/// <param name="aad">
	/// Optional additional authenticated data (AAD) that was used during encryption. Must match the AAD used for encryption, if any.
	/// </param>
	/// <returns>
	/// The decrypted plaintext string.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="base64Payload"/> or <paramref name="key"/> is null or empty.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown if <paramref name="key"/> is not 32 bytes in length.
	/// </exception>
	/// <exception cref="CryptographicException">
	/// Thrown if the payload is invalid, the version is unsupported, or decryption fails.
	/// </exception>
	[Pure]
	[Information(nameof(AesGcmDecrypt), "David McCarter", "8/14/2025", OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string AesGcmDecrypt([DisallowNull] string base64Payload, [DisallowNull] byte[] key, ReadOnlySpan<byte> aad = default)
	{
		base64Payload = base64Payload.ArgumentNotNullOrEmpty();
		key = key.ArgumentItemsExists();

		if (key.Length != 32)
		{
			ExceptionThrower.ThrowArgumentException("AES-GCM requires a 256-bit (32 byte) key.", nameof(key));
		}

		var input = Convert.FromBase64String(base64Payload);

		if (input.Length < 1 + NonceSize + TagSize)
		{
			throw new CryptographicException("Invalid payload length.");
		}

		var version = input[0];

		if (version != 1)
		{
			throw new CryptographicException($"Unsupported payload version: {version}");
		}

		ReadOnlySpan<byte> nonce = input.AsSpan(1, NonceSize);
		var cipherLen = input.Length - 1 - NonceSize - TagSize;
		ReadOnlySpan<byte> ciphertext = input.AsSpan(1 + NonceSize, cipherLen);
		ReadOnlySpan<byte> tag = input.AsSpan(1 + NonceSize + cipherLen, TagSize);

		var plaintext = new byte[cipherLen];

		// Match the same tag size used at encryption
		using (var aes = new AesGcm(key, TagSize))
		{
			aes.Decrypt(nonce, ciphertext, tag, plaintext, aad);
		}

		var result = Encoding.UTF8.GetString(plaintext);

		CryptographicOperations.ZeroMemory(plaintext);

		return result;
	}

	/// <summary>
	/// Encrypts a string using AES-GCM (Galois/Counter Mode) authenticated encryption.
	/// </summary>
	/// <param name="plainText">
	/// The plaintext string to encrypt.
	/// </param>
	/// <param name="key">
	/// The 256-bit (32 byte) key used for encryption.
	/// </param>
	/// <param name="aad">
	/// Optional additional authenticated data (AAD) to include in the authentication tag.
	/// </param>
	/// <returns>
	/// The encrypted payload as a Base64 string in the format: [version][nonce][ciphertext][tag].
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="plainText"/> or <paramref name="key"/> is null or empty.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown if <paramref name="key"/> is not 32 bytes in length.
	/// </exception>
	[Pure]
	[Information(nameof(AesGcmEncrypt), "David McCarter", "8/14/2025", OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static string AesGcmEncrypt([DisallowNull] string plainText, [DisallowNull] byte[] key, ReadOnlySpan<byte> aad = default)
	{
		plainText = plainText.ArgumentNotNullOrEmpty();
		key = key.ArgumentItemsExists();

		if (key.Length != 32)
		{
			ExceptionThrower.ThrowArgumentException("AES-GCM requires a 256-bit (32 byte) key.", nameof(key));
		}

		var nonce = new byte[NonceSize];

		RandomNumberGenerator.Fill(nonce);

		var plaintextBytes = Encoding.UTF8.GetBytes(plainText);
		var ciphertext = new byte[plaintextBytes.Length];
		var tag = new byte[TagSize];

		// Use ctor that specifies tag size to avoid SYSLIB0053
		using (var aes = new AesGcm(key, TagSize))
		{
			aes.Encrypt(nonce, plaintextBytes, ciphertext, tag, aad);
		}

		CryptographicOperations.ZeroMemory(plaintextBytes);

		// Build payload: [version][nonce][ciphertext][tag] -> Base64
		var output = new byte[1 + NonceSize + ciphertext.Length + TagSize];
		output[0] = FormatVersion;

		Buffer.BlockCopy(nonce, 0, output, 1, NonceSize);

		Buffer.BlockCopy(ciphertext, 0, output, 1 + NonceSize, ciphertext.Length);

		Buffer.BlockCopy(tag, 0, output, 1 + NonceSize + ciphertext.Length, TagSize);

		return Convert.ToBase64String(output);
	}

	/// <summary>
	/// Generates a new random 256-bit (32 byte) key for AES-GCM encryption.
	/// </summary>
	/// <returns>
	/// A randomly generated 32-byte key suitable for AES-GCM.
	/// </returns>
	[Pure]
	[Information(nameof(GenerateAesGcmKey), "David McCarter", "8/14/2025", OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
	public static byte[] GenerateAesGcmKey()
	{
		var key = new byte[32]; // 256-bit

		RandomNumberGenerator.Fill(key);

		return key;
	}

	/// <summary>
	/// Generates a new AES Initialization Vector (IV).
	/// </summary>
	/// <returns>A new 16-byte initialization vector.</returns>
	/// <remarks>
	/// The IV is used to prevent any patterns from being discernible in the ciphertext.
	/// It's crucial that the IV is random and not reused across encryptions for the same key.
	/// </remarks>
	[Pure]
	[Information(nameof(GenerateAesIV), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static byte[] GenerateAesIV()
	{
		using (var aes = Aes.Create())
		{
			aes.GenerateIV();
			return aes.IV;
		}
	}

	/// <summary>
	/// Generates a new AES Key.
	/// </summary>
	/// <returns>A new 32-byte key for AES encryption.</returns>
	/// <remarks>
	/// The key is used in conjunction with the IV for encrypting and decrypting data.
	/// It's crucial that the key is securely stored and not exposed to unauthorized entities.
	/// </remarks>
	[Pure]
	[Information(nameof(GenerateAesKey), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static byte[] GenerateAesKey()
	{
		using (var aes = Aes.Create())
		{
			aes.GenerateKey();
			return aes.Key;
		}
	}

	/// <summary>
	/// Generates a random key using a ULID.
	/// </summary>
	/// <returns>A string representation of the ULID, formatted without dashes.</returns>
	/// <example><b>Output:</b> f7f0af78003d4ab194b5a4024d02112a</example>
	[Pure]
	[Information(nameof(GenerateRandomKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string GenerateRandomKey() => Ulid.NewUlid().ToString();

	/// <summary>
	/// Decrypts a string using SHA256 and AES security.
	/// </summary>
	/// <param name="cipherText">The encrypted text to decrypt.</param>
	/// <param name="key">The key used for decryption.</param>
	/// <returns>The decrypted string.</returns>
	/// <example>
	/// Here is how you can use the <see cref="SimpleSHA256Decrypt"/> method:
	/// <code>
	/// var key = "your-encryption-key";
	/// var cipherText = "your-encrypted-text";
	/// var decryptedText = EncryptionHelper.SimpleSHA256Decrypt(cipherText, key);
	/// Console.WriteLine(decryptedText);
	/// </code>
	/// </example>
	[Pure]
	[Information(nameof(SimpleSHA256Decrypt), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string SimpleSHA256Decrypt([DisallowNull] string cipherText, [DisallowNull] string key)
	{
		cipherText = cipherText.ArgumentNotNullOrEmpty();
		key = key.ArgumentNotNullOrEmpty();

		var keys = GetSHA256HashKeys(key);

		return AesDecrypt(cipherText, keys.key, keys.iv);
	}

	/// <summary>
	/// Encrypts text using SHA256 and AES security.
	/// </summary>
	/// <param name="plainText">The plain text to encrypt.</param>
	/// <param name="key">The key used for encryption.</param>
	/// <returns>The encrypted string.</returns>
	/// <example>
	/// Here is how you can use the <see cref="SimpleSHA256Encrypt"/> method:
	/// <code>
	/// var key = "your-encryption-key";
	/// var plainText = "your-plain-text";
	/// var encryptedText = EncryptionHelper.SimpleSHA256Encrypt(plainText, key);
	/// Console.WriteLine(encryptedText);
	/// </code>
	/// </example>
	[Pure]
	[Information(nameof(SimpleSHA256Encrypt), "David McCarter", "7/19/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string SimpleSHA256Encrypt([DisallowNull] string plainText, [DisallowNull] string key)
	{
		plainText = plainText.ArgumentNotNullOrEmpty();
		key = key.ArgumentNotNullOrEmpty();

		var keys = GetSHA256HashKeys(key);

		return AesEncrypt(plainText, keys.key, keys.iv);
	}

	/// <summary>
	/// Verifies a hashed password with SHA256.
	/// </summary>
	/// <param name="hashedPassword">The hashed password.</param>
	/// <param name="password">The password to verify.</param>
	/// <returns>A <see cref="PasswordVerificationResult"/> indicating the result of the verification.</returns>
	/// <example>
	/// Here is how you can use the <see cref="VerifySHA256HashedPassword"/> method:
	/// <code>
	/// var hashedPassword = "your-hashed-password";
	/// var password = "your-password";
	/// var result = EncryptionHelper.VerifySHA256HashedPassword(hashedPassword, password);
	/// Console.WriteLine(result);
	/// </code>
	/// </example>
	[Pure]
	[Information(nameof(VerifySHA256HashedPassword), "David McCarter", "10/13/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, BenchmarkStatus = BenchmarkStatus.Completed)]
	public static PasswordVerificationResult VerifySHA256HashedPassword([DisallowNull] string hashedPassword, [DisallowNull] string password)
	{
		return PasswordHasher.VerifyHashedPassword(hashedPassword.ArgumentNotNullOrEmpty(), password.ArgumentNotNullOrEmpty(), HashAlgorithmType.SHA256);
	}

}
