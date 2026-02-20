// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 07-31-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2025
// ***********************************************************************
// <copyright file="DiagnosticEntryTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Core.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Diagnostics;

[TestClass]
public class DiagnosticEntryTests
{
	[TestMethod]
	public void Constructor_NullMessage_ThrowsArgumentNullException()
	{
		// Arrange
		var timestamp = DateTimeOffset.UtcNow;
		string message = null;
		var elapsed = TimeSpan.Zero;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => new DiagnosticEntry(timestamp, message, elapsed));
	}

	[TestMethod]
	public void Constructor_ValidParameters_PropertiesSetCorrectly()
	{
		var timestamp = DateTimeOffset.UtcNow;
		var message = "Test message";
		var elapsed = TimeSpan.FromMilliseconds(123);

		var entry = new DiagnosticEntry(timestamp, message, elapsed);

		Assert.AreEqual(timestamp, entry.Timestamp);
		Assert.AreEqual(message, entry.Message);
		Assert.AreEqual(elapsed, entry.Elapsed);
	}

	[TestMethod]
	public void Equals_DifferentValues_ReturnsFalse()
	{
		var entry1 = new DiagnosticEntry(DateTimeOffset.UtcNow, "A", TimeSpan.FromSeconds(1));
		var entry2 = new DiagnosticEntry(DateTimeOffset.UtcNow.AddSeconds(1), "B", TimeSpan.FromSeconds(2));

		Assert.IsFalse(entry1.Equals(entry2));
		Assert.IsFalse(entry1.Equals((object)entry2));
		Assert.IsFalse(entry1 == entry2);
		Assert.IsTrue(entry1 != entry2);
	}

	[TestMethod]
	public void Equals_SameValues_ReturnsTrue()
	{
		var timestamp = DateTimeOffset.UtcNow;
		var message = "Test";
		var elapsed = TimeSpan.FromSeconds(1);

		var entry1 = new DiagnosticEntry(timestamp, message, elapsed);
		var entry2 = new DiagnosticEntry(timestamp, message, elapsed);

		Assert.IsTrue(entry1.Equals(entry2));
		Assert.IsTrue(entry1.Equals((object)entry2));
		Assert.IsTrue(entry1 == entry2);
		Assert.IsFalse(entry1 != entry2);
	}

	[TestMethod]
	public void GetHashCode_DifferentValues_ReturnsDifferentHashCode()
	{
		var entry1 = new DiagnosticEntry(DateTimeOffset.UtcNow, "A", TimeSpan.FromMilliseconds(1));
		var entry2 = new DiagnosticEntry(DateTimeOffset.UtcNow.AddMinutes(1), "B", TimeSpan.FromMilliseconds(2));

		Assert.AreNotEqual(entry1.GetHashCode(), entry2.GetHashCode());
	}

	[TestMethod]
	public void GetHashCode_SameValues_ReturnsSameHashCode()
	{
		var timestamp = DateTimeOffset.UtcNow;
		var message = "HashTest";
		var elapsed = TimeSpan.FromMilliseconds(50);

		var entry1 = new DiagnosticEntry(timestamp, message, elapsed);
		var entry2 = new DiagnosticEntry(timestamp, message, elapsed);

		Assert.AreEqual(entry1.GetHashCode(), entry2.GetHashCode());
	}

	[TestMethod]
	public void ToString_ReturnsExpectedFormat()
	{
		var timestamp = new DateTimeOffset(2025, 7, 1, 12, 0, 0, TimeSpan.Zero);
		var message = "Hello World";
		var elapsed = TimeSpan.FromMilliseconds(250);

		var entry = new DiagnosticEntry(timestamp, message, elapsed);
		var result = entry.ToString();

		StringAssert.Contains(result, "2025-07-01 12:00:00Z");
		StringAssert.Contains(result, "Hello World");
		StringAssert.Contains(result, "250");
	}
}
