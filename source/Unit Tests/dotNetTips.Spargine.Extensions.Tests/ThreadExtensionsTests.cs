// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 03-26-2026
// ***********************************************************************
// <copyright file="ThreadExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ThreadExtensionsTests : UnitTester
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
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.FromTicks(1000);

		var elapsed = this.MeasureAction(() => thread.WaitUntil(interval), printResult: false);

		Assert.IsTrue(elapsed >= interval, $"The method should wait for at least the specified interval. Expected: {interval}, Actual: {elapsed}");
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
		Assert.IsGreaterThanOrEqualTo(interval.Ticks, endTime.Ticks - startTime.Ticks, "The method should wait for at least the specified interval.");
	}
}

