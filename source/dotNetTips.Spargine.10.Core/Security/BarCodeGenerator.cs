// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 04-01-2026
//
// Last Modified By : David McCarter
// Last Modified On : 07-15-2026
// ***********************************************************************
// <copyright file="BarCodeGenerator.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Provides HMAC-based barcode generation and validation using HMAC-SHA256 signatures
// with Crockford Base32 encoding. Supports key rotation, expiry checking, and clock skew tolerance.
// </summary>
// ***********************************************************************
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Security;

/// <summary>
/// Provides HMAC-based barcode generation and validation using HMAC-SHA256 signatures
/// with Crockford Base32 encoding. Supports key rotation, expiry checking, and clock skew tolerance.
/// </summary>
[Information(nameof(BarcodeGenerator), "David McCarter", "03/01/2026", Status = Status.NeedsDocumentation)]
public static class BarcodeGenerator
{
	private const string ALG = "alg";
	private const string ALG_H256 = "H256";
	private const int DefaultMacLenBytes = 10; // compact & robust
	private const string EXP = "e";
	private const string ISS = "iss";
	private const string KID = "kid";
	private const string PID = "pid";
	private const string SIG = "sig";
	private const string TID = "tid";
	private const string V = "v";

	/// <summary>
	/// Builds an HMAC-signed barcode string containing the specified ticket and performance identifiers,
	/// expiry, issuer, and key identifier. The barcode includes a truncated HMAC-SHA256 signature
	/// encoded using Crockford Base32.
	/// </summary>
	/// <param name="ticketId">The unique ticket identifier.</param>
	/// <param name="performanceId">The unique performance identifier.</param>
	/// <param name="expiresUtc">The UTC expiration time for the barcode.</param>
	/// <param name="issuer">The barcode issuer.</param>
	/// <param name="key">The HMAC key (16–64 bytes).</param>
	/// <param name="kid">The key identifier.</param>
	/// <param name="macLenBytes">The truncated MAC length in bytes (1–32). Defaults to 10.</param>
	/// <returns>A pipe-delimited barcode string with an appended HMAC signature.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="ticketId"/>, <paramref name="performanceId"/>, <paramref name="issuer"/>, or <paramref name="kid"/> is null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="key"/> length or <paramref name="macLenBytes"/> is out of range.</exception>
	[Information(nameof(BuildHmacBarcode), "David McCarter", "04/01/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public static string BuildHmacBarcode(string ticketId, string performanceId, DateTimeOffset expiresUtc, string issuer, byte[] key, string kid, int macLenBytes = DefaultMacLenBytes)
	{
		ticketId = ticketId.ArgumentNotNullOrEmpty();
		performanceId = performanceId.ArgumentNotNullOrEmpty();
		issuer = issuer.ArgumentNotNullOrEmpty();
		kid = kid.ArgumentNotNullOrEmpty();
		key = [.. key.ArgumentCountInRange(min: 16, max: 64, paramName: nameof(key))];
		macLenBytes = macLenBytes.ArgumentInRange(min: 1, max: 32, paramName: nameof(macLenBytes));

		var payload =
			$"{V}=1|{TID}={ticketId}|{PID}={performanceId}|{EXP}={expiresUtc.ToUnixTimeSeconds()}|{ISS}={issuer}|{ALG}={ALG_H256}|{KID}={kid}";

		var sigBytes = ComputeHmacTruncated(payload, key, macLenBytes);
		var sigText = Crockford32.Encode(sigBytes); // uppercase, no padding
		return $"{payload}|{SIG}={sigText}";
	}


	/// <summary>
	/// Validates an HMAC-signed barcode by verifying its structure, algorithm, optional expiry,
	/// and cryptographic signature against the provided key ring.
	/// </summary>
	/// <param name="barcode">The barcode string to validate.</param>
	/// <param name="keysByKid">A dictionary mapping key identifiers to their HMAC keys.</param>
	/// <param name="fields">When this method returns, contains the parsed key-value pairs from the barcode payload.</param>
	/// <param name="macLenBytes">The expected truncated MAC length in bytes (1–32). Defaults to 10.</param>
	/// <param name="maxSkew">Optional maximum clock skew tolerance added to the current time.</param>
	/// <param name="pastExpiryGrace">Optional grace period added to the expiry time for recently-expired barcodes.</param>
	/// <returns><see langword="true"/> if the barcode is valid; otherwise, <see langword="false"/>.</returns>
	[Information(nameof(ValidateHmacBarcode), "David McCarter", "04/01/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.None, Status = Status.Available)]
	public static bool ValidateHmacBarcode(string barcode, IReadOnlyDictionary<string, byte[]> keysByKid, out Dictionary<string, string> fields, int macLenBytes = DefaultMacLenBytes, TimeSpan? maxSkew = null, TimeSpan? pastExpiryGrace = null)
	{
		fields = new(StringComparer.OrdinalIgnoreCase);

		if (!ValidateBarcodeInputs(barcode, keysByKid, macLenBytes))
		{
			return false;
		}

		if (!TrySplitBarcode(barcode, out var payload, out var sigPart))
		{
			return false;
		}

		ParseFields(payload, fields);

		if (!ValidateBarcodeFields(fields))
		{
			return false;
		}

		return !TryDecodeSignature(sigPart, out var providedSig)
			? false
			: !CheckExpiry(fields, maxSkew, pastExpiryGrace)
			? false
			: keysByKid is null ? false : VerifySignature(payload, providedSig, fields, keysByKid, macLenBytes);
	}

	/// <summary>
	/// Checks whether the barcode has not expired given the optional skew and grace parameters.
	/// Returns <see langword="true"/> if no expiry field is present or if the barcode is still valid.
	/// </summary>
	private static bool CheckExpiry(Dictionary<string, string> fields, TimeSpan? maxSkew, TimeSpan? pastExpiryGrace)
	{
		if (!fields.TryGetValue(EXP, out var eStr) || !long.TryParse(eStr, out var epoch))
		{
			return true;
		}

		var now = DateTimeOffset.UtcNow + (maxSkew ?? TimeSpan.Zero);
		var expires = DateTimeOffset.FromUnixTimeSeconds(epoch);
		return expires + (pastExpiryGrace ?? TimeSpan.Zero) >= now;
	}

	private static byte[] ComputeHmacTruncated(string payload, byte[] key, int macLenBytes)
	{
		using var hmac = new HMACSHA256(key);
		var full = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));

		if (macLenBytes >= full.Length)
		{
			return full;
		}

		var sig = new byte[macLenBytes];
		Buffer.BlockCopy(full, 0, sig, 0, macLenBytes);

		return sig;
	}

	/// <summary>
	/// Parses pipe-delimited <c>key=value</c> pairs from the payload into <paramref name="fields"/>.
	/// </summary>
	private static void ParseFields(string payload, Dictionary<string, string> fields)
	{
		foreach (var part in payload.Split('|'))
		{
			var kv = part.Split('=', 2);
			if (kv.Length == 2)
			{
				fields[kv[0]] = kv[1];
			}
		}
	}

	/// <summary>
	/// Attempts to Crockford-decode <paramref name="sigPart"/> into a byte array.
	/// Returns <see langword="false"/> if decoding fails or the length is invalid.
	/// </summary>
	private static bool TryDecodeSignature(string sigPart, out byte[] providedSig)
	{
		try
		{
			providedSig = Crockford32.Decode(sigPart);
		}
		catch (FormatException)
		{
			providedSig = [];
			return false;
		}

		return providedSig.Length is not 0 and <= 32;
	}

	/// <summary>
	/// Splits the barcode at the last <c>|sig=</c> separator into payload and signature parts.
	/// </summary>
	private static bool TrySplitBarcode(string barcode, out string payload, out string sigPart)
	{
		var sigIdx = barcode.LastIndexOf("|" + SIG + "=", StringComparison.Ordinal);

		if (sigIdx < 0)
		{
			payload = string.Empty;
			sigPart = string.Empty;
			return false;
		}

		payload = barcode[..sigIdx];
		sigPart = barcode[(sigIdx + SIG.Length + 2)..]; // skip "|sig="
		return true;
	}

	/// <summary>
	/// Validates that the required <c>v</c> and <c>alg</c> fields are present and correct.
	/// </summary>
	private static bool ValidateBarcodeFields(Dictionary<string, string> fields)
	{
		return !fields.TryGetValue(V, out var v) || !string.Equals(v, "1", StringComparison.Ordinal)
			? false
			: fields.TryGetValue(ALG, out var alg) && alg.Equals(ALG_H256, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Validates the top-level inputs to <see cref="ValidateHmacBarcode"/>.
	/// </summary>
	private static bool ValidateBarcodeInputs(string? barcode, IReadOnlyDictionary<string, byte[]>? keysByKid, int macLenBytes)
	{
		if (string.IsNullOrEmpty(barcode))
		{
			return false;
		}

		return keysByKid is null || keysByKid.Count == 0 ? false : macLenBytes.CheckIsInRange(1, 32);
	}

	/// <summary>
	/// Verifies the HMAC signature by trying matching keys from the key ring.
	/// </summary>
	private static bool VerifySignature(string payload, byte[] providedSig, Dictionary<string, string> fields, IReadOnlyDictionary<string, byte[]> keysByKid, int macLenBytes)
	{
		IEnumerable<byte[]> candidates;

		if (fields.TryGetValue(KID, out var kid) && keysByKid.TryGetValue(kid, out var key))
		{
			candidates = [key];
		}
		else
		{
			candidates = keysByKid.Values;
		}

		foreach (var k in candidates)
		{
			var expected = ComputeHmacTruncated(payload, k, macLenBytes);
			var n = Math.Min(expected.Length, providedSig.Length);
			if (n > 0 && CryptographicOperations.FixedTimeEquals(expected.AsSpan(0, n), providedSig.AsSpan(0, n)))
			{
				return true;
			}
		}

		return false;
	}
}

