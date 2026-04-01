// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 04-01-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="BarcodeGeneratorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary>
// Unit tests for BarcodeGenerator covering BuildHmacBarcode and
// ValidateHmacBarcode with full code path coverage.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Security;

[ExcludeFromCodeCoverage]
[TestClass]
public class BarcodeGeneratorTests
{
	private const string Kid = "test-key-01";
	private const string Issuer = "TestIssuer";
	private const string TicketId = "01J9E8W3S1S9P8WQKD3B3CP9T7";
	private const string PerformanceId = "01J9E8W6D4SQFK6E9RWQ2Z6B2D";

	// 32-byte key for testing
	private static readonly byte[] TestKey = Convert.FromBase64String("3LHykMQCAZPQTWGNVqwm+9UZQLk32hmnR0gVLC9Nhfw=");

	private static readonly IReadOnlyDictionary<string, byte[]> KeyRing = new Dictionary<string, byte[]>
	{
		[Kid] = TestKey
	};

	// ─── BuildHmacBarcode ───────────────────────────────────────────

	[TestMethod]
	public void BuildHmacBarcode_ValidInputs_ReturnsBarcode()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Assert
		Assert.IsNotNull(barcode);
		Assert.IsTrue(barcode.Contains($"tid={TicketId}", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains($"pid={PerformanceId}", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains($"iss={Issuer}", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains($"kid={Kid}", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains("v=1", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains("alg=H256", StringComparison.Ordinal));
		Assert.IsTrue(barcode.Contains("sig=", StringComparison.Ordinal));
	}

	[TestMethod]
	public void BuildHmacBarcode_NullTicketId_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(null!, PerformanceId, expires, Issuer, TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_EmptyTicketId_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(string.Empty, PerformanceId, expires, Issuer, TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_NullPerformanceId_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, null!, expires, Issuer, TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_EmptyPerformanceId_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, string.Empty, expires, Issuer, TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_NullIssuer_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, null!, TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_EmptyIssuer_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, string.Empty, TestKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_NullKid_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, null!));
	}

	[TestMethod]
	public void BuildHmacBarcode_EmptyKid_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, string.Empty));
	}

	[TestMethod]
	public void BuildHmacBarcode_KeyTooSmall_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var smallKey = new byte[8]; // less than 16

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, smallKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_KeyTooLarge_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var largeKey = new byte[128]; // more than 64

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, largeKey, Kid));
	}

	[TestMethod]
	public void BuildHmacBarcode_MacLenBytesZero_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid, macLenBytes: 0));
	}

	[TestMethod]
	public void BuildHmacBarcode_MacLenBytesTooLarge_ThrowsException()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid, macLenBytes: 33));
	}

	[TestMethod]
	public void BuildHmacBarcode_CustomMacLenBytes_ReturnsBarcode()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid, macLenBytes: 16);

		// Assert
		Assert.IsNotNull(barcode);
		Assert.IsTrue(barcode.Contains("sig=", StringComparison.Ordinal));
	}

	[TestMethod]
	public void BuildHmacBarcode_MaxMacLenBytes_ReturnsFullHmac()
	{
		// Arrange - macLenBytes = 32 means full SHA256 HMAC (no truncation)
		var expires = DateTimeOffset.UtcNow.AddHours(8);

		// Act
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid, macLenBytes: 32);

		// Assert
		Assert.IsNotNull(barcode);
		Assert.IsTrue(barcode.Contains("sig=", StringComparison.Ordinal));
	}

	[TestMethod]
	public void BuildHmacBarcode_MinKeySize_Succeeds()
	{
		// Arrange - exactly 16 bytes (minimum key size)
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var minKey = new byte[16];
		Array.Fill(minKey, (byte)0xAB);

		// Act
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, minKey, Kid);

		// Assert
		Assert.IsNotNull(barcode);
	}

	[TestMethod]
	public void BuildHmacBarcode_MaxKeySize_Succeeds()
	{
		// Arrange - exactly 64 bytes (maximum key size)
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var maxKey = new byte[64];
		Array.Fill(maxKey, (byte)0xCD);

		// Act
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, maxKey, Kid);

		// Assert
		Assert.IsNotNull(barcode);
	}

	// ─── ValidateHmacBarcode ────────────────────────────────────────

	[TestMethod]
	public void ValidateHmacBarcode_ValidBarcode_ReturnsTrue()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(TicketId, fields["tid"]);
		Assert.AreEqual(PerformanceId, fields["pid"]);
		Assert.AreEqual(Issuer, fields["iss"]);
		Assert.AreEqual(Kid, fields["kid"]);
		Assert.AreEqual("1", fields["v"]);
		Assert.AreEqual("H256", fields["alg"]);
	}

	[TestMethod]
	public void ValidateHmacBarcode_NullBarcode_ReturnsFalse()
	{
		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(null!, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_EmptyBarcode_ReturnsFalse()
	{
		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(string.Empty, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_NullKeysByKid_ReturnsFalse()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, null!, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_EmptyKeysByKid_ReturnsFalse()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);
		var emptyKeys = new Dictionary<string, byte[]>();

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, emptyKeys, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MacLenBytesOutOfRange_ReturnsFalse()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields, macLenBytes: 0);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MacLenBytesAboveRange_ReturnsFalse()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields, macLenBytes: 33);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_NoSignatureSegment_ReturnsFalse()
	{
		// Arrange - barcode without |sig= segment
		var barcode = "v=1|tid=abc|pid=def|e=9999999999|iss=Test|alg=H256|kid=test";

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MissingVersionField_ReturnsFalse()
	{
		// Arrange - barcode missing v=1
		var barcode = "tid=abc|pid=def|e=9999999999|iss=Test|alg=H256|kid=test|sig=ABCDEF";

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_WrongVersion_ReturnsFalse()
	{
		// Arrange - barcode with wrong version
		var barcode = "v=2|tid=abc|pid=def|e=9999999999|iss=Test|alg=H256|kid=test|sig=ABCDEF";

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MissingAlgField_ReturnsFalse()
	{
		// Arrange - barcode without alg field
		var barcode = "v=1|tid=abc|pid=def|e=9999999999|iss=Test|kid=test|sig=ABCDEF";

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_WrongAlg_ReturnsFalse()
	{
		// Arrange - barcode with wrong algorithm
		var barcode = "v=1|tid=abc|pid=def|e=9999999999|iss=Test|alg=SHA512|kid=test|sig=ABCDEF";

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_ExpiredBarcode_ReturnsFalse()
	{
		// Arrange - barcode already expired (1 hour ago)
		var expired = DateTimeOffset.UtcNow.AddHours(-1);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expired, Issuer, TestKey, Kid);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_ExpiredWithGrace_ReturnsTrue()
	{
		// Arrange - barcode expired 10 minutes ago, but grace period is 30 minutes
		var expired = DateTimeOffset.UtcNow.AddMinutes(-10);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expired, Issuer, TestKey, Kid);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields,
			pastExpiryGrace: TimeSpan.FromMinutes(30));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_ExpiredBeyondGrace_ReturnsFalse()
	{
		// Arrange - barcode expired 2 hours ago, grace period is only 30 minutes
		var expired = DateTimeOffset.UtcNow.AddHours(-2);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expired, Issuer, TestKey, Kid);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields,
			pastExpiryGrace: TimeSpan.FromMinutes(30));

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_WithMaxSkew_ReturnsTrue()
	{
		// Arrange - barcode not yet expired
		var expires = DateTimeOffset.UtcNow.AddHours(1);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields,
			maxSkew: TimeSpan.FromMinutes(5));

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_WrongKey_ReturnsFalse()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);
		var wrongKey = new byte[32];
		Array.Fill(wrongKey, (byte)0xFF);
		var wrongKeyRing = new Dictionary<string, byte[]> { [Kid] = wrongKey };

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, wrongKeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_KidNotInKeyRing_TriesAllKeys_ReturnsTrue()
	{
		// Arrange - build with one kid, validate with keyring that has the key under a different kid
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);
		var differentKidKeyRing = new Dictionary<string, byte[]> { ["different-kid"] = TestKey };

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, differentKidKeyRing, out var fields);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_KidNotInKeyRing_AllKeysWrong_ReturnsFalse()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);
		var wrongKey = new byte[32];
		Array.Fill(wrongKey, (byte)0xFF);
		var wrongKeyRing = new Dictionary<string, byte[]> { ["different-kid"] = wrongKey };

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, wrongKeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_TamperedBarcode_ReturnsFalse()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Tamper with the ticket ID in the payload
		var tampered = barcode.Replace(TicketId, "TAMPERED_TICKET_ID");

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(tampered, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_CustomMacLenBytes_RoundTrip()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var macLen = 16;
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid, macLenBytes: macLen);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields, macLenBytes: macLen);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_FullMacLenBytes_RoundTrip()
	{
		// Arrange - macLenBytes = 32 exercises the no-truncation path in ComputeHmacTruncated
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var macLen = 32;
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid, macLenBytes: macLen);

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields, macLenBytes: macLen);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_InvalidSignatureEncoding_ReturnsFalse()
	{
		// Arrange - create a barcode with invalid Crockford32 characters in sig
		var barcode = "v=1|tid=abc|pid=def|e=9999999999|iss=Test|alg=H256|kid=test-key-01|sig=!!!INVALID!!!";

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_FieldsPopulatedEvenOnFailure()
	{
		// Arrange - valid format but wrong signature
		var barcode = "v=1|tid=abc|pid=def|e=9999999999|iss=Test|alg=H256|kid=test-key-01|sig=ABCDEF01";

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsFalse(result);
		Assert.IsTrue(fields.ContainsKey("tid"));
		Assert.AreEqual("abc", fields["tid"]);
	}

	[TestMethod]
	public void BuildAndValidate_RoundTrip_Succeeds()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(4);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Act
		var isValid = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields);

		// Assert
		Assert.IsTrue(isValid);
		Assert.AreEqual("1", fields["v"]);
		Assert.AreEqual(TicketId, fields["tid"]);
		Assert.AreEqual(PerformanceId, fields["pid"]);
		Assert.AreEqual(Issuer, fields["iss"]);
		Assert.AreEqual("H256", fields["alg"]);
		Assert.AreEqual(Kid, fields["kid"]);
		Assert.IsTrue(fields.ContainsKey("e"));
	}

	[TestMethod]
	public void BuildHmacBarcode_ContainsExpiryAsUnixTimestamp()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(2);

		// Act
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		// Assert
		var expectedEpoch = expires.ToUnixTimeSeconds().ToString();
		Assert.IsTrue(barcode.Contains($"e={expectedEpoch}", StringComparison.Ordinal));
	}

	[TestMethod]
	public void ValidateHmacBarcode_MultipleKeysInKeyRing_MatchesCorrectKey()
	{
		// Arrange
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid);

		var otherKey = new byte[32];
		Array.Fill(otherKey, (byte)0xAA);
		var multiKeyRing = new Dictionary<string, byte[]>
		{
			["other-kid"] = otherKey,
			[Kid] = TestKey
		};

		// Act
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, multiKeyRing, out var fields);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ValidateHmacBarcode_MismatchedMacLenBytes_MayStillValidate()
	{
		// Arrange - build with macLen=10 but validate with macLen=16
		// The validation uses Math.Min of expected and provided sig lengths,
		// so when the built sig (10 bytes) is a prefix of the expected sig (16 bytes),
		// the comparison covers 10 bytes which will match. This is expected behavior.
		var expires = DateTimeOffset.UtcNow.AddHours(8);
		var barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, expires, Issuer, TestKey, Kid, macLenBytes: 10);

		// Act - validate with different macLenBytes
		var result = BarcodeGenerator.ValidateHmacBarcode(barcode, KeyRing, out var fields, macLenBytes: 16);

		// Assert - the first 10 bytes of both HMACs are identical since they use the same key/payload
		Assert.IsTrue(result);
	}
}
