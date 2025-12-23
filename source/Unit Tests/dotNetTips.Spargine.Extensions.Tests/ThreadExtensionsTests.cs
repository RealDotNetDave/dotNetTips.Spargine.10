// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 11-24-2024
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2025
// ***********************************************************************
// <copyright file="ThreadExtensionsTests.cs" company="DotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using DotNetTips.Spargine.Core.Devices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ThreadExtensionsTests
{

	[TestMethod]
	public void TrySetPriority_InvalidPriority_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var thread = new Thread(() => { });
		var invalidPriority = (ThreadPriority)int.MaxValue;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => thread.TrySetPriority(invalidPriority));
	}

	[TestMethod]
	public void TrySetPriority_NullThread_ThrowsArgumentNullException()
	{
		// Arrange
		Thread thread = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => thread.TrySetPriority(ThreadPriority.Normal));
	}

	[TestMethod]
	public void TrySetPriority_ValidPriority_ReturnsTrue()
	{
		// Arrange
		var thread = new Thread(() => { });
		var priority = ThreadPriority.AboveNormal;

		// Act
		var result = thread.TrySetPriority(priority);

		// Assert
		Assert.IsTrue(result, "The method should return true for a valid priority.");
		Assert.AreEqual(priority, thread.Priority, "The thread priority should be set to the specified value.");
	}

	[TestMethod]
	public void WaitUntil_NegativeWaitIterations_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.FromMilliseconds(100);
		var negativeWaitIterations = -1;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => thread.WaitUntil(interval, negativeWaitIterations));
	}

	[TestMethod]
	public void WaitUntil_NullThread_ThrowsArgumentNullException()
	{
		// Arrange
		Thread thread = null;
		var interval = TimeSpan.FromMilliseconds(100);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => thread.WaitUntil(interval));
	}

	[TestMethod]
	public void WaitUntil_ValidInterval_WaitsCorrectly()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.FromTicks(1000);

		// Act
		var startTime = TimeSpan.FromTicks(Clock.LocalTime.Ticks);
		thread.WaitUntil(interval);
		var endTime = TimeSpan.FromTicks(Clock.LocalTime.Ticks);

		// Assert
		Assert.IsTrue(endTime - startTime >= interval, "The method should wait for at least the specified interval.");
	}

	[TestMethod]
	public void WaitUntil_ValidIntervalAndIterations_WaitsCorrectly()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.FromSeconds(1);
		var waitIterations = 1000;

		// Act
		var startTime = Clock.LocalTime;
		thread.WaitUntil(interval, waitIterations);

		var endTime = Clock.LocalTime;

		// Assert
		Assert.IsTrue(endTime.Ticks - startTime.Ticks >= interval.Ticks, "The method should wait for at least the specified interval.");
	}
}

