// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-05-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-29-2026
// ***********************************************************************
// <copyright file="PasswordHasher.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Text;
using Konscious.Security.Cryptography;
using Org.BouncyCastle.Crypto.Digests;

//`![](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Provides methods for hashing and verifying passwords using multiple algorithms.
/// </summary>
[Information(nameof(PasswordHasher), "David McCarter", "5/14/2025", Status = Status.Available, Documentation = "https://bit.ly/SparginePasswordHasher")]
public static class PasswordHasher

{
	private const int Iterations = 4;
	private const int MemorySize = 32768;

	private static readonly ArrayPool<byte> _byteArrayPool = ArrayPool<byte>.Shared;
	private static readonly int _degreeOfParallelism = App.MaxDegreeOfParallelism();

	/// <summary>
	/// The number of iterations for PBKDF2.
	/// </summary>
	private static int Pbkdf2IterCount { get; } = 100000;

	/// <summary>
	/// The length of the PBKDF2 subkey in bytes.
	/// </summary>
	private static int Pbkdf2SubkeyLength { get; } = 256 / 8; // 256 bits

	/// <summary>
	/// The size of the salt in bytes.
	/// </summary>
	private static int SaltSize { get; } = 256;

	/// <summary>
	/// The version of the password hashing algorithm.
	/// </summary>
	private static byte Version => 1;

	/// <summary>
	/// Hashes the specified password using the selected hashing algorithm.
	/// </summary>
	/// <param name="password">The non-null password to hash.</param>
	/// <param name="algorithmType">
	/// The hashing algorithm to use when generating the password hash. Defaults to <see cref="HashAlgorithmType.PBKDF2"/>.
	/// </param>
	/// <returns>
	/// A string containing the encoded hash representation of the password for the selected algorithm.
	/// </returns>
	[Pure]
	[Information(nameof(HashPassword), "David McCarter", "5/14/2025", Tags = new[] { "PBKDF2", "SHA256", "SHA3256", "SHA3384", "SHA3512", "Shake128", "Shake256", "Argon2" }, UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string HashPassword([DisallowNull] string password, HashAlgorithmType algorithmType = HashAlgorithmType.PBKDF2)
	{
		password = password.ArgumentNotNull();

		return algorithmType switch
		{
			HashAlgorithmType.PBKDF2 => HashPasswordPBKDF2(password),
			HashAlgorithmType.SHA256 or HashAlgorithmType.SHA3256 or HashAlgorithmType.SHA3384 or HashAlgorithmType.SHA3512 or HashAlgorithmType.Shake128 or HashAlgorithmType.Shake256 => HashPasswordSHAOrShake(password, algorithmType),
			HashAlgorithmType.Argon2 => HashPasswordArgon2(password),
			_ => throw new NotSupportedException($"The algorithm {algorithmType} is not supported.")
		};
	}

	/// <summary>
	/// Verifies that the provided plain-text password matches the specified hashed password
	/// using the selected hashing algorithm.
	/// </summary>
	/// <param name="hashedPassword">
	/// The previously generated, encoded password hash to verify against. This value must not be null or empty.
	/// </param>
	/// <param name="password">
	/// The plain-text password supplied for verification. This value must not be null or empty.
	/// </param>
	/// <param name="algorithmType">
	/// The hashing algorithm that was originally used to create <paramref name="hashedPassword"/>.
	/// Defaults to <see cref="HashAlgorithmType.PBKDF2"/>.
	/// </param>
	/// <returns>
	/// A <see cref="PasswordVerificationResult"/> indicating whether the supplied password matches
	/// the stored hash (<see cref="PasswordVerificationResult.Success"/>) or not
	/// (<see cref="PasswordVerificationResult.Failed"/>).
	/// </returns>
	[Pure]
	[Information(nameof(VerifyHashedPassword), "David McCarter", "5/14/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static PasswordVerificationResult VerifyHashedPassword([DisallowNull] string hashedPassword, [DisallowNull] string password, HashAlgorithmType algorithmType = HashAlgorithmType.PBKDF2)
	{
		hashedPassword = hashedPassword.ArgumentNotNullOrEmpty();
		password = password.ArgumentNotNullOrEmpty();
		algorithmType = algorithmType.ArgumentDefined();

		return algorithmType switch
		{
			HashAlgorithmType.PBKDF2 => VerifyHashedPasswordPBKDF2(hashedPassword, password),
			HashAlgorithmType.SHA256 or HashAlgorithmType.SHA3256 or HashAlgorithmType.SHA3384 or HashAlgorithmType.SHA3512 or HashAlgorithmType.Shake128 or HashAlgorithmType.Shake256 =>
				VerifyHashedPasswordSHA(hashedPassword, password, algorithmType),
			HashAlgorithmType.Argon2 => VerifyHashedPasswordArgon2(hashedPassword, password),
			_ => throw new NotSupportedException($"The algorithm {algorithmType} is not supported.")
		};
	}

	/// <summary>
	/// Hashes a password using Argon2.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <returns>A base64-encoded string representing the hashed password.</returns>
	private static string HashPasswordArgon2(string password)
	{
		var salt = RandomNumberGenerator.GetBytes(SaltSize);

		using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password)))
		{
			argon2.Salt = salt;
			argon2.DegreeOfParallelism = _degreeOfParallelism; // Number of threads to use
			argon2.MemorySize = MemorySize; // Memory size in KB
			argon2.Iterations = Iterations; // Number of iterations

			var hash = argon2.GetBytes(32); // Generate a 256-bit hash

			var passwordHashLength = 1 + SaltSize + hash.Length;
			var passwordHash = _byteArrayPool.Rent(passwordHashLength);

			try
			{
				passwordHash[0] = Version;

				Buffer.BlockCopy(salt, 0, passwordHash, 1, SaltSize);
				Buffer.BlockCopy(hash, 0, passwordHash, 1 + SaltSize, hash.Length);

				return Convert.ToBase64String(passwordHash, 0, passwordHashLength);
			}
			finally
			{
				_byteArrayPool.Return(passwordHash, clearArray: true);
			}
		}
	}

	/// <summary>
	/// Hashes a password using PBKDF2.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <returns>A base64-encoded string representing the hashed password.</returns>
	private static string HashPasswordPBKDF2(string password)
	{
		var salt = RandomNumberGenerator.GetBytes(SaltSize);
		var bytes = Rfc2898DeriveBytes.Pbkdf2(password, salt, Pbkdf2IterCount, HashAlgorithmName.SHA256, Pbkdf2SubkeyLength);

		var passwordHashLength = 1 + SaltSize + Pbkdf2SubkeyLength;
		var passwordHash = _byteArrayPool.Rent(passwordHashLength);

		try
		{
			passwordHash[0] = Version;

			Buffer.BlockCopy(salt, 0, passwordHash, 1, SaltSize);
			Buffer.BlockCopy(bytes, 0, passwordHash, 1 + SaltSize, Pbkdf2SubkeyLength);

			return Convert.ToBase64String(passwordHash, 0, passwordHashLength);
		}
		finally
		{
			_byteArrayPool.Return(passwordHash, clearArray: true);
		}
	}

	/// <summary>
	/// Hashes a password using the specified hashing algorithm.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <param name="algorithm">The hashing algorithm to use.</param>
	/// <returns>A base64-encoded string representing the hashed password.</returns>
	private static string HashPasswordSHA(string password, HashAlgorithm algorithm)
	{
		var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));

		return Convert.ToBase64String(hash);
	}

	/// <summary>
	/// Creates and disposes of a SHA256 hashing algorithm to hash the given password.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <returns>A base64-encoded string representing the hashed password.</returns>
	private static string HashPasswordSHA256(string password)
	{
		using (var sha256 = SHA256.Create())
		{
			return HashPasswordSHA(password, sha256);
		}
	}

	/// <summary>
	/// Hashes a password using SHA3 with the specified bit length.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <param name="bitLength">The bit length of the SHA3 algorithm (256, 384, or 512).</param>
	/// <returns>A base64-encoded string representing the hashed password.</returns>
	private static string HashPasswordSHA3(string password, int bitLength)
	{
		var digest = bitLength switch
		{
			256 => new Sha3Digest(256),
			384 => new Sha3Digest(384),
			512 => new Sha3Digest(512),
			_ => throw new ArgumentOutOfRangeException(nameof(bitLength), "Unsupported SHA3 bit length.")
		};

		var passwordBytes = Encoding.UTF8.GetBytes(password);
		digest.BlockUpdate(passwordBytes, 0, passwordBytes.Length);

		var resultSize = digest.GetDigestSize();
		var pool = _byteArrayPool.Rent(resultSize);

		try
		{
			_ = digest.DoFinal(pool, 0);
			return Convert.ToBase64String(pool, 0, resultSize);
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(pool, clearArray: true);
		}
	}

	/// <summary>
	/// Hashes a password using SHAKE with the specified bit length.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <param name="bitLength">The bit length of the SHAKE algorithm (128 or 256).</param>
	/// <returns>A base64-encoded string representing the hashed password.</returns>
	private static string HashPasswordShake(string password, int bitLength)
	{
		var digest = bitLength switch
		{
			128 => new ShakeDigest(128),
			256 => new ShakeDigest(256),
			_ => throw new ArgumentOutOfRangeException(nameof(bitLength), "Unsupported SHAKE bit length.")
		};

		var passwordBytes = Encoding.UTF8.GetBytes(password);
		digest.BlockUpdate(passwordBytes, 0, passwordBytes.Length);

		var resultSize = digest.GetDigestSize();
		var result = _byteArrayPool.Rent(resultSize);

		try
		{
			_ = digest.DoFinal(result, 0);
			return Convert.ToBase64String(result, 0, resultSize);
		}
		finally
		{
			_byteArrayPool.Return(result, clearArray: true);
		}
	}

	/// <summary>
	/// Dispatches password hashing to the appropriate SHA or SHAKE algorithm.
	/// </summary>
	/// <param name="password">The password to hash.</param>
	/// <param name="algorithmType">The SHA or SHAKE algorithm variant to use.</param>
	/// <returns>A base64-encoded string representing the hashed password.</returns>
	private static string HashPasswordSHAOrShake(string password, HashAlgorithmType algorithmType) =>
		algorithmType switch
		{
			HashAlgorithmType.SHA256 => HashPasswordSHA256(password),
			HashAlgorithmType.SHA3256 => HashPasswordSHA3(password, 256),
			HashAlgorithmType.SHA3384 => HashPasswordSHA3(password, 384),
			HashAlgorithmType.SHA3512 => HashPasswordSHA3(password, 512),
			HashAlgorithmType.Shake128 => HashPasswordShake(password, 128),
			HashAlgorithmType.Shake256 => HashPasswordShake(password, 256),
			_ => throw new NotSupportedException($"The algorithm {algorithmType} is not supported.")
		};

	/// <summary>
	/// Verifies a hashed password using Argon2.
	/// </summary>
	/// <param name="hashedPassword">The hashed password to verify.</param>
	/// <param name="password">The plain-text password to compare against the hashed password.</param>
	/// <returns>A <see cref="PasswordVerificationResult"/> indicating whether the verification succeeded or failed.</returns>
	private static PasswordVerificationResult VerifyHashedPasswordArgon2(string hashedPassword, string password)
	{
		var passwordBytes = hashedPassword.ToByteArrayFromBase64();
		var version = passwordBytes[0];

		if (version > Version)
		{
			return PasswordVerificationResult.Failed;
		}

		var salt = _byteArrayPool.Rent(SaltSize);
		var storedHashLength = passwordBytes.Length - 1 - SaltSize;
		var storedHash = _byteArrayPool.Rent(storedHashLength);

		try
		{
			Buffer.BlockCopy(passwordBytes, 1, salt, 0, SaltSize);
			Buffer.BlockCopy(passwordBytes, 1 + SaltSize, storedHash, 0, storedHashLength);

			using (var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password)))
			{
				argon2.Salt = salt.AsSpan(0, SaltSize).ToArray(); // Argon2id requires byte[], not span
				argon2.DegreeOfParallelism = _degreeOfParallelism;
				argon2.MemorySize = MemorySize;
				argon2.Iterations = Iterations;

				var computedHash = argon2.GetBytes(storedHashLength);

				return CryptographicOperations.FixedTimeEquals(
					storedHash.AsSpan(0, storedHashLength),
					computedHash.AsSpan())
					? PasswordVerificationResult.Success
					: PasswordVerificationResult.Failed;
			}
		}
		finally
		{
			_byteArrayPool.Return(salt, clearArray: true);
			_byteArrayPool.Return(storedHash, clearArray: true);
		}
	}

	/// <summary>
	/// Verifies a hashed password using PBKDF2.
	/// </summary>
	/// <param name="hashedPassword">The hashed password to verify.</param>
	/// <param name="password">The plain-text password to compare against the hashed password.</param>
	/// <returns>A <see cref="PasswordVerificationResult"/> indicating whether the verification succeeded or failed.</returns>
	private static PasswordVerificationResult VerifyHashedPasswordPBKDF2(string hashedPassword, string password)
	{
		var passwordBytes = hashedPassword.ToByteArrayFromBase64();
		var version = passwordBytes[0];

		if (version > Version)
		{
			return PasswordVerificationResult.Failed;
		}

		var salt = _byteArrayPool.Rent(SaltSize);
		var subKey = _byteArrayPool.Rent(Pbkdf2SubkeyLength);

		try
		{
			Buffer.BlockCopy(passwordBytes, 1, salt, 0, SaltSize);
			Buffer.BlockCopy(passwordBytes, 1 + SaltSize, subKey, 0, Pbkdf2SubkeyLength);

			var bytes = Rfc2898DeriveBytes.Pbkdf2(password, salt.AsSpan(0, SaltSize).ToArray(), Pbkdf2IterCount, HashAlgorithmName.SHA256, Pbkdf2SubkeyLength);

			return CryptographicOperations.FixedTimeEquals(
				subKey.AsSpan(0, Pbkdf2SubkeyLength),
				bytes.AsSpan())
				? PasswordVerificationResult.Success
				: PasswordVerificationResult.Failed;
		}
		finally
		{
			_byteArrayPool.Return(salt, clearArray: true);
			_byteArrayPool.Return(subKey, clearArray: true);
		}
	}

	/// <summary>
	/// Verifies a hashed password using the specified hashing algorithm.
	/// </summary>
	/// <param name="hashedPassword">The hashed password to verify.</param>
	/// <param name="password">The plain-text password to compare against the hashed password.</param>
	/// <param name="algorithmType">The hashing algorithm to use.</param>
	/// <returns>A <see cref="PasswordVerificationResult"/> indicating whether the verification succeeded or failed.</returns>
	private static PasswordVerificationResult VerifyHashedPasswordSHA(string hashedPassword, string password, HashAlgorithmType algorithmType)
	{
		var hash = HashPassword(password, algorithmType);
		return CryptographicOperations.FixedTimeEquals(Convert.FromBase64String(hashedPassword), Convert.FromBase64String(hash))
			? PasswordVerificationResult.Success
			: PasswordVerificationResult.Failed;
	}
}
