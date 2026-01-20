// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-06-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-20-2026
// ***********************************************************************
// <copyright file="UlidTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[TestClass]
public class UlidTests
{

	[TestMethod]
	public void NewUlid_ContainsOnlyValidBase32Characters()
	{
		// Arrange
		var validChars = "0123456789ABCDEFGHJKMNPQRSTVWXYZ";

		// Act
		var ulid = Ulid.NewUlid();
		var ulidString = ulid.ToString();

		// Assert
		foreach (var c in ulidString)
		{
			Assert.IsTrue(validChars.Contains(c), $"Invalid character '{c}' found in ULID.");
		}
	}

	[TestMethod]
	public void NewUlid_GeneratedUlid_CanBeParsedBack()
	{
		// Arrange
		var originalUlid = Ulid.NewUlid();
		var ulidString = originalUlid.ToString();

		// Act
		var parsedUlid = Ulid.Parse(ulidString);

		// Assert
		Assert.AreEqual(originalUlid, parsedUlid);
	}

	[TestMethod]
	public void NewUlid_GeneratedUlid_HasValidTimestamp()
	{
		// Arrange
		var beforeGeneration = DateTimeOffset.UtcNow;

		// Act
		var ulid = Ulid.NewUlid();
		var afterGeneration = DateTimeOffset.UtcNow;

		var timestamp = ulid.GetTimeStamp();

		// Assert
		Assert.IsTrue(timestamp >= beforeGeneration.AddMilliseconds(-1), "Timestamp should be at or after generation start.");
		Assert.IsTrue(timestamp <= afterGeneration.AddMilliseconds(1), "Timestamp should be at or before generation end.");
	}

	[TestMethod]
	public void NewUlid_GeneratedUlid_TryParseSucceeds()
	{
		// Arrange
		var originalUlid = Ulid.NewUlid();
		var ulidString = originalUlid.ToString();

		// Act
		var result = Ulid.TryParse(ulidString, out var parsedUlid);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(originalUlid, parsedUlid);
	}

	[TestMethod]
	public void NewUlid_IsLexicographicallySortable()
	{
		// Arrange
		var ulids = new List<Ulid>();

		for (var i = 0; i < 10; i++)
		{
			ulids.Add(Ulid.NewUlid());
			Thread.Sleep(1);
		}

		// Act
		var sortedByString = ulids.OrderBy(u => u.ToString()).ToList();

		// Assert - Original order should match lexicographic sort order
		for (var i = 0; i < ulids.Count; i++)
		{
			Assert.AreEqual(ulids[i], sortedByString[i], $"ULID at index {i} should be in lexicographic order.");
		}
	}

	[TestMethod]
	public void NewUlid_LaterUlid_IsGreaterOrEqual()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();

		// Small delay to ensure timestamp difference
		Thread.Sleep(1);

		var ulid2 = Ulid.NewUlid();

		// Assert - ULIDs should be lexicographically sortable by time
		Assert.IsTrue(ulid2 >= ulid1, "Later ULID should be greater than or equal to earlier ULID.");
	}

	[TestMethod]
	public void NewUlid_MultipleRapidGenerations_AllUnique()
	{
		// Arrange
		const int count = 1000;
		var ulids = new HashSet<string>();

		// Act
		for (var i = 0; i < count; i++)
		{
			var ulid = Ulid.NewUlid();
			ulids.Add(ulid.ToString());
		}

		// Assert
		Assert.AreEqual(count, ulids.Count, "All generated ULIDs should be unique.");
	}

	[TestMethod]
	public void NewUlid_ParallelGeneration_AllUnique()
	{
		// Arrange
		const int count = 100;
		var ulids = new System.Collections.Concurrent.ConcurrentBag<string>();

		// Act
		Parallel.For(0, count, _ =>
		{
			var ulid = Ulid.NewUlid();
			ulids.Add(ulid.ToString());
		});

		// Assert
		var distinctCount = ulids.Distinct().Count();
		Assert.AreEqual(count, distinctCount, "All parallel-generated ULIDs should be unique.");
	}

	[TestMethod]
	public void NewUlid_RandomComponent_IsDifferent()
	{
		// Arrange & Act
		var ulid1 = Ulid.NewUlid();
		var ulid2 = Ulid.NewUlid();

		var random1 = ulid1.ToString()[10..];
		var random2 = ulid2.ToString()[10..];

		// Assert - Random portions should be different
		Assert.AreNotEqual(random1, random2, "Random components should differ between ULIDs.");
	}

	[TestMethod]
	public void NewUlid_ReturnsCorrectLength()
	{
		// Act
		var ulid = Ulid.NewUlid();

		// Assert
		Assert.AreEqual(26, ulid.ToString().Length);
	}
	[TestMethod]
	public void NewUlid_ReturnsNonNullUlid()
	{
		// Act
		var ulid = Ulid.NewUlid();

		// Assert
		Assert.IsNotNull(ulid.ToString());
	}

	[TestMethod]
	public void NewUlid_TimestampComponent_IsFirst10Characters()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();

		Thread.Sleep(10); // Wait to ensure different timestamp

		var ulid2 = Ulid.NewUlid();

		// Act
		var timestamp1 = ulid1.ToString()[..10];
		var timestamp2 = ulid2.ToString()[..10];

		// Assert - Timestamp portions should be different after delay
		Assert.AreNotEqual(timestamp1, timestamp2, "Timestamp components should differ after delay.");
	}

	[TestMethod]
	public void Ulid_CompareTo_DifferentValues_ReturnsNonZero()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = Ulid.NewUlid();

		// Act
		var result = ulid1.CompareTo(ulid2);

		// Assert
		Assert.AreNotEqual(0, result);
	}

	[TestMethod]
	public void Ulid_Constructor_EmptyValue_ThrowsArgumentException()
	{
		// Arrange
		var emptyValue = string.Empty;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => new Ulid(emptyValue));
	}

	[TestMethod]
	public void Ulid_Constructor_InvalidLength_ThrowsArgumentException()
	{
		// Arrange
		var invalidLengthUlid = "1234567890"; // Too short

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => new Ulid(invalidLengthUlid));
	}

	[TestMethod]
	public void Ulid_Constructor_NullValue_ThrowsArgumentException()
	{
		// Arrange
		string nullValue = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => new Ulid(nullValue));
	}

	[TestMethod]
	public void Ulid_Constructor_ValidUlid_CreatesInstance()
	{
		// Arrange
		var validUlid = "GDJYD3WV04FJ4SN35XMEC2G3S5";

		// Act
		var ulid = new Ulid(validUlid);

		// Assert
		Assert.AreEqual(validUlid, ulid.ToString());
	}

	[TestMethod]
	public void Ulid_Equals_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = Ulid.NewUlid();

		// Act
		var result = ulid1.Equals(ulid2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Ulid_Equals_SameValues_ReturnsTrue()
	{
		// Arrange
		var ulidUlid = Ulid.NewUlid().ToString();
		var ulid1 = new Ulid(ulidUlid);
		var ulid2 = new Ulid(ulidUlid);

		// Act
		var result = ulid1.Equals(ulid2);

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Ulid_EqualsObject_DifferentValues_ReturnsFalse()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		object ulid2 = Ulid.NewUlid();

		// Act
		var result = ulid1.Equals(ulid2);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Ulid_GetHashCode_DifferentValues_ReturnsDifferentHashCodes()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = Ulid.NewUlid();

		// Act
		var hashCode1 = ulid1.GetHashCode();
		var hashCode2 = ulid2.GetHashCode();

		// Assert
		Assert.AreNotEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Ulid_GetHashCode_SameValues_ReturnsSameHashCode()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = new Ulid(ulid1.ToString());

		// Act
		var hashCode1 = ulid1.GetHashCode();
		var hashCode2 = ulid2.GetHashCode();

		// Assert
		Assert.AreEqual(hashCode1, hashCode2);
	}

	[TestMethod]
	public void Ulid_GetTimeStamp_ConsistentForSameUlid()
	{
		// Arrange
		var ulidString = Ulid.NewUlid().ToString();
		var ulid1 = new Ulid(ulidString);
		var ulid2 = new Ulid(ulidString);

		// Act
		var ts1 = ulid1.GetTimeStamp();
		var ts2 = ulid2.GetTimeStamp();

		// Assert
		Assert.AreEqual(ts1, ts2);
	}

	[TestMethod]
	public void Ulid_GetTimeStamp_InvalidCharacter_ThrowsArgumentException()
	{
		// Arrange
		// Create a ULID string with an invalid character in the timestamp portion
		var validUlid = Ulid.NewUlid().ToString();
		var invalidUlid = "!" + validUlid.Substring(1); // Replace first char with invalid '!'

		var ulid = new Ulid(invalidUlid);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => ulid.GetTimeStamp());
	}

	[TestMethod]
	public void Ulid_GetTimeStamp_ReturnsReasonableDateTimeOffset()
	{
		// Arrange
		var ulid = Ulid.NewUlid();

		// Act
		var timestamp = ulid.GetTimeStamp();

		// Assert
		// Should be within a reasonable range of now (allowing for clock drift)
		var now = DateTimeOffset.UtcNow;
		Assert.IsTrue(timestamp <= now && timestamp > now.AddMinutes(-5));
	}

	[TestMethod]
	public void Ulid_NewUlid_GeneratesUniqueUlid()
	{
		// Act
		var ulid1 = Ulid.NewUlid();
		var ulid2 = Ulid.NewUlid();

		// Assert
		Assert.AreNotEqual(ulid1, ulid2);
		Assert.AreNotEqual(ulid1.ToString(), ulid2.ToString());
	}

	[TestMethod]
	public void Ulid_OperatorEquals_SameValues_ReturnsTrue()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = new Ulid(ulid1.ToString());

		// Act
		var result = ulid1 == ulid2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Ulid_OperatorGreaterThan_ReturnsTrue()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = Ulid.NewUlid();

		// Act
		var result = ulid2 > ulid1;

		// Assert
		Assert.AreEqual(ulid2.CompareTo(ulid1) > 0, result);
	}

	[TestMethod]
	public void Ulid_OperatorGreaterThanOrEqual_ReturnsTrue()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = new Ulid(ulid1.ToString());

		// Act
		var result = ulid1 >= ulid2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Ulid_OperatorLessThan_ReturnsTrue()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = Ulid.NewUlid();

		// Act
		var result = ulid1 < ulid2;

		// Assert
		Assert.AreEqual(ulid1.CompareTo(ulid2) < 0, result);
	}

	[TestMethod]
	public void Ulid_OperatorLessThanOrEqual_ReturnsTrue()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = new Ulid(ulid1.ToString());

		// Act
		var result = ulid1 <= ulid2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Ulid_OperatorNotEquals_DifferentValues_ReturnsTrue()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = Ulid.NewUlid();

		// Act
		var result = ulid1 != ulid2;

		// Assert
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void Ulid_OperatorNotEquals_SameValues_ReturnsFalse()
	{
		// Arrange
		var ulid1 = Ulid.NewUlid();
		var ulid2 = new Ulid(ulid1.ToString());

		// Act
		var result = ulid1 != ulid2;

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void Ulid_Parse_InvalidUlidString_ThrowsArgumentException()
	{
		// Arrange
		var invalidUlid = "INVALID_ULID_STRING";

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() => Ulid.Parse(invalidUlid));
	}

	[TestMethod]
	public void Ulid_Parse_ValidUlidString_ReturnsUlid()
	{
		// Arrange
		var ulid = Ulid.NewUlid();
		var ulidString = ulid.ToString();

		// Act
		var parsedUlid = Ulid.Parse(ulidString);

		// Assert
		Assert.AreEqual(ulid, parsedUlid);
	}

	[TestMethod]
	public void Ulid_TryParse_InvalidUlidString_ReturnsFalse()
	{
		// Arrange
		var invalidUlid = "INVALID_ULID_STRING";

		// Act
		var result = Ulid.TryParse(invalidUlid, out var parsedUlid);

		// Assert
		Assert.IsFalse(result);
		Assert.AreEqual(default, parsedUlid);
	}

	[TestMethod]
	public void Ulid_TryParse_ValidUlidString_ReturnsTrue()
	{
		// Arrange
		var ulid = Ulid.NewUlid();
		var ulidString = ulid.ToString();

		// Act
		var result = Ulid.TryParse(ulidString, out var parsedUlid);

		// Assert
		Assert.IsTrue(result);
		Assert.AreEqual(ulid, parsedUlid);
	}

	[TestClass]
	public class UlidEqualsObjectTests
	{

		[TestMethod]
		public void Ulid_EqualsObject_DifferentValues_ReturnsFalse()
		{
			// Arrange
			var ulid1 = Ulid.NewUlid();
			object ulid2 = Ulid.NewUlid();

			// Act
			var result = ulid1.Equals(ulid2);

			// Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Ulid_EqualsObject_NonUlidObject_ReturnsFalse()
		{
			// Arrange
			var ulid1 = Ulid.NewUlid();
			object nonUlidObject = "NotAULID";

			// Act
			var result = ulid1.Equals(nonUlidObject);

			// Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Ulid_EqualsObject_NullObject_ReturnsFalse()
		{
			// Arrange
			var ulid1 = Ulid.NewUlid();
			object ulid2 = null;

			// Act
			var result = ulid1.Equals(ulid2);

			// Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Ulid_EqualsObject_SameValues_ReturnsTrue()
		{
			// Arrange
			var ulid1 = Ulid.NewUlid();
			object ulid2 = new Ulid(ulid1.ToString());

			// Act
			var result = ulid1.Equals(ulid2);

			// Assert
			Assert.IsTrue(result);
		}
	}
}
