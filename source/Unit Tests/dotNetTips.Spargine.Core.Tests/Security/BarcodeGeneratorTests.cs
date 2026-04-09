// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 04-01-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="BarcodeGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]
[TestClass]
public class BarcodeGeneratorTests
{
	private const string Kid = "2025-08a";
	private static readonly byte[] TestKey = Convert.FromBase64String("3LHykMQCAZPQTWGNVqwm+9UZQLk32hmnR0gVLC9Nhfw=");

	private static readonly IReadOnlyDictionary<string, byte[]> KeyRing = new Dictionary<string, byte[]>
	{
		[Kid] = TestKey,
	};

	private static string BuildValidBarcode(DateTimeOffset? expiresUtc = null, int macLenBytes = 10)
	{
		return BarcodeGenerator.BuildHmacBarcode(
			ticketId: "TID001",
			performanceId: "PID001",
			expiresUtc: expiresUtc ?? DateTimeOffset.UtcNow.AddHours(8),
			issuer: "CTIX",
			key: TestKey,
			kid: Kid,
			macLenBytes: macLenBytes);
	}

	// ───────────────────────────────────────────────────────────────
	//  BuildHmacBarcode – Happy paths
	// ───────────────────────────────────────────────────────────────

	[TestMethod]
	public void BuildHmacBarcode_ValidInputs_ReturnsBarcodeString()
	{
		// Act
		var barcode = BuildValidBarcode();

		// Assert
		Assert.IsNotNull(barcode);
		Assert.IsTrue(barcode.Contains("|sig=", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains("v=1", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains("tid=TID001", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains("pid=PID001", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains("iss=CTIX", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains("alg=H256", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains($"kid={Kid}", StringComparison.Ordinal));
	}

	[TestMethod]
	public void BuildHmacBarcode_RoundTrip_ValidatesSuccessfully()
	{
		// Arrange
		var barcode = BuildValidBarcode();

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual("TID001", fields["tid"]);
		Assert.AreEqual("PID001", fields["pid"]);
		Assert.AreEqual("CTIX", fields["iss"]);
	}

	[TestMethod]
	public void BuildHmacBarcode_MaxMacLen_RoundTrip()
	{
		// This exercises the ComputeHmacTruncated path where macLenBytes >= full.Length (32)
		var barcode = BuildValidBarcode(macLenBytes: 32);
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _, macLenBytes: 32);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void BuildHmacBarcode_MinMacLen_RoundTrip()
	{
		var barcode = BuildValidBarcode(macLenBytes: 1);
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _, macLenBytes: 1);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void BuildHmacBarcode_DifferentInputs_ProduceDifferentBarcodes()
	{
		var barcode1 = BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(8), "CTIX", TestKey, Kid);
		var barcode2 = BarcodeGenerator.BuildHmacBarcode("TID002", "PID001", DateTimeOffset.UtcNow.AddHours(8), "CTIX", TestKey, Kid);

		Assert.AreNotEqual(barcode1, barcode2);
	}

	// ───────────────────────────────────────────────────────────────
	//  BuildHmacBarcode – Invalid argument paths
	// ───────────────────────────────────────────────────────────────

	[TestMethod]
	public void BuildHmacBarcode_NullTicketId_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(null!, "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_EmptyTicketId_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(string.Empty, "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_NullPerformanceId_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", null!, DateTimeOffset.UtcNow.AddHours(1), "CTIX", TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_EmptyPerformanceId_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", string.Empty, DateTimeOffset.UtcNow.AddHours(1), "CTIX", TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_NullIssuer_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), null!, TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_EmptyIssuer_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), string.Empty, TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_NullKid_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", TestKey, null!));
	}

	[TestMethod]
	public void BuildHmacBarcode_EmptyKid_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", TestKey, string.Empty));
	}

	[TestMethod]
	public void BuildHmacBarcode_KeyTooShort_ThrowsArgumentOutOfRangeException()
	{
		var shortKey = new byte[15]; // less than min 16
		RandomNumberGenerator.Fill(shortKey);

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", shortKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_KeyTooLong_ThrowsArgumentOutOfRangeException()
	{
		var longKey = new byte[65]; // greater than max 64
		RandomNumberGenerator.Fill(longKey);

		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", longKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_MacLenBytesZero_ThrowsArgumentOutOfRangeException()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", TestKey, Kid, macLenBytes: 0));
	}

	[TestMethod]
	public void BuildHmacBarcode_MacLenBytesTooLarge_ThrowsArgumentOutOfRangeException()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", TestKey, Kid, macLenBytes: 33));
	}

	[TestMethod]
	public void BuildHmacBarcode_MinKeyLength_Succeeds()
	{
		var key = new byte[16];
		RandomNumberGenerator.Fill(key);

		var barcode = BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", key, Kid);

		Assert.IsNotNull(barcode);
	}

	[TestMethod]
	public void BuildHmacBarcode_MaxKeyLength_Succeeds()
	{
		var key = new byte[64];
		RandomNumberGenerator.Fill(key);

		var barcode = BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", DateTimeOffset.UtcNow.AddHours(1), "CTIX", key, Kid);

		Assert.IsNotNull(barcode);
	}

	// ───────────────────────────────────────────────────────────────
	//  ValidateHmacBarcode – Null / empty / missing inputs
	// ───────────────────────────────────────────────────────────────

	[TestMethod]
	public void ValidateHmacBarcode_NullBarcode_ReturnsFalse()
	{
		var result = BarcodeGenerator.ValidateHmacBarcode(null!, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_EmptyBarcode_ReturnsFalse()
	{
		var result = BarcodeGenerator.ValidateHmacBarcode(string.Empty, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_NullKeysByKid_ReturnsFalse()
	{
		var barcode = BuildValidBarcode();

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, null!, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_EmptyKeysByKid_ReturnsFalse()
	{
		var barcode = BuildValidBarcode();
		var emptyKeys = new Dictionary<string, byte[]>();

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, emptyKeys, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MacLenBytesZero_ReturnsFalse()
	{
		var barcode = BuildValidBarcode();

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _, macLenBytes: 0);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MacLenBytesTooLarge_ReturnsFalse()
	{
		var barcode = BuildValidBarcode();

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _, macLenBytes: 33);

		Assert.IsFalse(result);
	}

	// ───────────────────────────────────────────────────────────────
	//  ValidateHmacBarcode – Structural / format failures
	// ───────────────────────────────────────────────────────────────

	[TestMethod]
	public void ValidateHmacBarcode_NoSigSeparator_ReturnsFalse()
	{
		// Barcode that has no "|sig=" at all
		var result = BarcodeGenerator.ValidateHmacBarcode("v=1|tid=X|pid=Y|alg=H256", KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MissingVersion_ReturnsFalse()
	{
		// Build a barcode with no version field
		var barcode = "tid=X|pid=Y|alg=H256|kid=2025-08a|sig=ABCDEF";

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_WrongVersion_ReturnsFalse()
	{
		var barcode = "v=2|tid=X|pid=Y|alg=H256|kid=2025-08a|sig=ABCDEF";

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MissingAlgorithm_ReturnsFalse()
	{
		var barcode = "v=1|tid=X|pid=Y|kid=2025-08a|sig=ABCDEF";

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_WrongAlgorithm_ReturnsFalse()
	{
		var barcode = "v=1|tid=X|pid=Y|alg=S512|kid=2025-08a|sig=ABCDEF";

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_EmptySignature_ReturnsFalse()
	{
		// Crockford32.Decode("") returns empty array, which hits providedSig.Length is 0
		var barcode = "v=1|tid=X|pid=Y|alg=H256|kid=2025-08a|sig=";

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_TamperedPayload_ReturnsFalse()
	{
		var barcode = BuildValidBarcode();
		// Tamper with the ticketId
		var tampered = barcode.Replace("tid=TID001", "tid=TAMPERED");

		var result = BarcodeGenerator.ValidateHmacBarcode(tampered, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_TamperedSignature_ReturnsFalse()
	{
		var barcode = BuildValidBarcode();
		// Modify the last character of the signature
		var lastPipe = barcode.LastIndexOf("|sig=", StringComparison.Ordinal);
		var sigPart = barcode[(lastPipe + 5)..];

		// Flip a character in the signature
		var chars = sigPart.ToCharArray();
		chars[0] = chars[0] == 'A' ? 'B' : 'A';
		var tamperedSig = new string(chars);
		var tampered = barcode[..(lastPipe + 5)] + tamperedSig;

		var result = BarcodeGenerator.ValidateHmacBarcode(tampered, KeyRing, out _);

		Assert.IsFalse(result);
	}

	// ───────────────────────────────────────────────────────────────
	//  ValidateHmacBarcode – Expiry and clock skew
	// ───────────────────────────────────────────────────────────────

	[TestMethod]
	public void ValidateHmacBarcode_ExpiredBarcode_ReturnsFalse()
	{
		var expired = DateTimeOffset.UtcNow.AddHours(-2);
		var barcode = BuildValidBarcode(expiresUtc: expired);

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_ExpiredWithGrace_ReturnsTrue()
	{
		// Expired 10 minutes ago, but grace period is 30 minutes
		var expired = DateTimeOffset.UtcNow.AddMinutes(-10);
		var barcode = BuildValidBarcode(expiresUtc: expired);

		var result = BarcodeGenerator.ValidateHmacBarcode(
			barcode, KeyRing, out _, pastExpiryGrace: TimeSpan.FromMinutes(30));

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_ExpiredBeyondGrace_ReturnsFalse()
	{
		// Expired 60 minutes ago, grace is only 30 minutes
		var expired = DateTimeOffset.UtcNow.AddMinutes(-60);
		var barcode = BuildValidBarcode(expiresUtc: expired);

		var result = BarcodeGenerator.ValidateHmacBarcode(
			barcode, KeyRing, out _, pastExpiryGrace: TimeSpan.FromMinutes(30));

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_FutureExpiry_WithMaxSkew_ReturnsTrue()
	{
		var future = DateTimeOffset.UtcNow.AddHours(1);
		var barcode = BuildValidBarcode(expiresUtc: future);

		var result = BarcodeGenerator.ValidateHmacBarcode(
			barcode, KeyRing, out _, maxSkew: TimeSpan.FromMinutes(5));

		Assert.IsTrue(result);
	}

	// ───────────────────────────────────────────────────────────────
	//  ValidateHmacBarcode – Key selection
	// ───────────────────────────────────────────────────────────────

	[TestMethod]
	public void ValidateHmacBarcode_KidNotInKeyRing_TriesAllKeys_ReturnsTrue()
	{
		// Build barcode with kid="unknown-kid", but the key ring contains
		// the actual key under a different kid. The validator should fall
		// back to trying all keys.
		var unknownKid = "unknown-kid";
		var barcode = BarcodeGenerator.BuildHmacBarcode(
			"TID001", "PID001", DateTimeOffset.UtcNow.AddHours(8), "CTIX", TestKey, unknownKid);

		// Key ring has the same key but under a different kid
		var keyRing = new Dictionary<string, byte[]>
		{
			["other-kid"] = TestKey,
		};

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, keyRing, out _);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_NoMatchingKey_ReturnsFalse()
	{
		var barcode = BuildValidBarcode();

		// Key ring with a different key
		var differentKey = new byte[32];
		RandomNumberGenerator.Fill(differentKey);
		var wrongKeyRing = new Dictionary<string, byte[]>
		{
			[Kid] = differentKey,
		};

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, wrongKeyRing, out _);

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_KidMissing_TriesAllKeys_NoMatch_ReturnsFalse()
	{
		var barcode = BuildValidBarcode();

		// Key ring with only a wrong key under a different kid
		var differentKey = new byte[32];
		RandomNumberGenerator.Fill(differentKey);
		var wrongKeyRing = new Dictionary<string, byte[]>
		{
			["wrong-kid"] = differentKey,
		};

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, wrongKeyRing, out _);

		Assert.IsFalse(result);
	}

	// ───────────────────────────────────────────────────────────────
	//  ValidateHmacBarcode – Fields output
	// ───────────────────────────────────────────────────────────────

	[TestMethod]
	public void ValidateHmacBarcode_ParsesAllFields()
	{
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode("TID001", "PID001", expires, "CTIX", TestKey, Kid);

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		Assert.IsTrue(result);
		Assert.AreEqual("1", fields["v"]);
		Assert.AreEqual("TID001", fields["tid"]);
		Assert.AreEqual("PID001", fields["pid"]);
		Assert.AreEqual(expires.ToUnixTimeSeconds().ToString(), fields["e"]);
		Assert.AreEqual("CTIX", fields["iss"]);
		Assert.AreEqual("H256", fields["alg"]);
		Assert.AreEqual(Kid, fields["kid"]);
	}

	[TestMethod]
	public void ValidateHmacBarcode_FieldsAreCaseInsensitive()
	{
		var barcode = BuildValidBarcode();

		BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Fields dictionary should be case-insensitive
		Assert.AreEqual(fields["TID"], fields["tid"]);
		Assert.AreEqual(fields["PID"], fields["pid"]);
		Assert.AreEqual(fields["V"], fields["v"]);
	}

	// ───────────────────────────────────────────────────────────────
	//  ValidateHmacBarcode – Invalid base32 signature (catch path)
	// ───────────────────────────────────────────────────────────────

	[TestMethod]
	public void ValidateHmacBarcode_InvalidBase32InSignature_ReturnsFalse()
	{
		// Use an invalid base32 character (U is not in Crockford alphabet)
		var barcode = "v=1|tid=X|pid=Y|e=9999999999|alg=H256|kid=2025-08a|sig=!!INVALID!!";

		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out _);

		Assert.IsFalse(result);
	}
}
