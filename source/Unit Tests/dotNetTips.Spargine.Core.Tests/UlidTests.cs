// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-06-2025
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="UlidTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[TestClass]
public class UlidTests
{

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
