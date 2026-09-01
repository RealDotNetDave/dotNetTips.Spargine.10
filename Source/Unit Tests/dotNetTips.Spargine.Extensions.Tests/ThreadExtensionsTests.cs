// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
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

	[TestMethod]
	public void TrySetPriority_DefaultPriority_ReturnsTrue()
	{
		// Arrange
		var thread = new Thread(() => { });

		// Act
		var result = thread.TrySetPriority();

		// Assert
		Assert.IsTrue(result, "The method should return true when using the default priority.");
		Assert.AreEqual(ThreadPriority.Normal, thread.Priority, "The thread priority should default to Normal.");
	}

	[TestMethod]
	public void TrySetPriority_LowestPriority_ReturnsTrue()
	{
		// Arrange
		var thread = new Thread(() => { });

		// Act
		var result = thread.TrySetPriority(ThreadPriority.Lowest);

		// Assert
		Assert.IsTrue(result, "The method should return true for Lowest priority.");
		Assert.AreEqual(ThreadPriority.Lowest, thread.Priority, "The thread priority should be set to Lowest.");
	}

	[TestMethod]
	public void TrySetPriority_BelowNormalPriority_ReturnsTrue()
	{
		// Arrange
		var thread = new Thread(() => { });

		// Act
		var result = thread.TrySetPriority(ThreadPriority.BelowNormal);

		// Assert
		Assert.IsTrue(result, "The method should return true for BelowNormal priority.");
		Assert.AreEqual(ThreadPriority.BelowNormal, thread.Priority, "The thread priority should be set to BelowNormal.");
	}

	[TestMethod]
	public void TrySetPriority_NormalPriority_ReturnsTrue()
	{
		// Arrange
		var thread = new Thread(() => { });

		// Act
		var result = thread.TrySetPriority(ThreadPriority.Normal);

		// Assert
		Assert.IsTrue(result, "The method should return true for Normal priority.");
		Assert.AreEqual(ThreadPriority.Normal, thread.Priority, "The thread priority should be set to Normal.");
	}

	[TestMethod]
	public void TrySetPriority_HighestPriority_ReturnsTrue()
	{
		// Arrange
		var thread = new Thread(() => { });

		// Act
		var result = thread.TrySetPriority(ThreadPriority.Highest);

		// Assert
		Assert.IsTrue(result, "The method should return true for Highest priority.");
		Assert.AreEqual(ThreadPriority.Highest, thread.Priority, "The thread priority should be set to Highest.");
	}

	[TestMethod]
	public void WaitUntil_NullThreadWithIterations_ThrowsArgumentNullException()
	{
		// Arrange
		Thread thread = null;
		var interval = TimeSpan.FromMilliseconds(100);
		var waitIterations = 10;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => thread.WaitUntil(interval, waitIterations));
	}

	[TestMethod]
	public void WaitUntil_ZeroInterval_CompletesImmediately()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.Zero;

		// Act
		var elapsed = this.MeasureAction(() => thread.WaitUntil(interval), printResult: false);

		// Assert
		Assert.IsTrue(elapsed.TotalSeconds < 1, "The method should complete nearly immediately with a zero interval.");
	}

	[TestMethod]
	public void WaitUntil_ZeroWaitIterations_CompletesSuccessfully()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.FromTicks(1000);
		var waitIterations = 0;

		// Act
		var elapsed = this.MeasureAction(() => thread.WaitUntil(interval, waitIterations), printResult: false);

		// Assert
		Assert.IsTrue(elapsed >= interval, $"The method should wait for at least the specified interval. Expected: {interval}, Actual: {elapsed}");
	}

	[TestMethod]
	public void WaitUntil_ZeroIntervalWithIterations_CompletesImmediately()
	{
		// Arrange
		var thread = Thread.CurrentThread;
		var interval = TimeSpan.Zero;
		var waitIterations = RandomData.GenerateInteger(min: 0, max: 1000);

		// Act
		var elapsed = this.MeasureAction(() => thread.WaitUntil(interval, waitIterations), printResult: false);

		// Assert
		Assert.IsTrue(elapsed.TotalSeconds < 1, "The method should complete nearly immediately with a zero interval.");
	}
}

