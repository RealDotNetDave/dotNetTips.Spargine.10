// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="StopwatchScopeTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Tests for StopwatchScope.
// </summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Diagnostics;

namespace DotNetTips.Spargine.Core.Tests.Diagnostics;

[ExcludeFromCodeCoverage]
[TestClass]
public class StopwatchScopeTests
{

	[TestMethod]
	public void Constructor_WithCallback_Succeeds()
	{
		using var scope = new StopwatchScope(_ => { });
		Assert.IsNotNull(scope);
	}
	[TestMethod]
	public void Constructor_WithoutCallback_Succeeds()
	{
		using var scope = new StopwatchScope();
		Assert.IsNotNull(scope);
		Assert.IsTrue(scope.Elapsed >= TimeSpan.Zero);
	}

	[TestMethod]
	public void Dispose_InvokesCallbackWithElapsedTime()
	{
		TimeSpan elapsed = TimeSpan.Zero;

		using (var scope = StopwatchScope.Start(value => elapsed = value))
		{
			Thread.Sleep(20);
		}

		Assert.IsTrue(elapsed > TimeSpan.Zero);
	}

	[TestMethod]
	public void Dispose_WithNullCallback_DoesNotThrow()
	{
		using var scope = StopwatchScope.Start(null);
		// Should not throw when disposed with null callback
		Assert.IsNotNull(scope);
	}

	[TestMethod]
	public void Dispose_WithoutCallback_DoesNotThrow()
	{
		using var scope = StopwatchScope.Start();
		// Should not throw when disposed without callback
		Assert.IsNotNull(scope);
	}

	[TestMethod]
	public void Elapsed_IncreasesOverTime()
	{
		using var scope = StopwatchScope.Start();

		var initial = scope.Elapsed;
		Thread.Sleep(10);
		var later = scope.Elapsed;

		Assert.IsTrue(later >= initial);
	}

	[TestMethod]
	public void Elapsed_ReturnsPositiveValueAfterDelay()
	{
		using var scope = StopwatchScope.Start();

		Thread.Sleep(20);

		Assert.IsTrue(scope.Elapsed > TimeSpan.Zero);
	}

	[TestMethod]
	public void Start_CreatesStartedScope()
	{
		using var scope = StopwatchScope.Start();
		Assert.IsNotNull(scope);
		Assert.IsTrue(scope.Elapsed >= TimeSpan.Zero);
	}

	[TestMethod]
	public void Start_WithCallback_InvokesCallbackOnDispose()
	{
		var callbackInvoked = false;

		using (var scope = StopwatchScope.Start(_ => callbackInvoked = true))
		{
			Assert.IsFalse(callbackInvoked);
		}

		Assert.IsTrue(callbackInvoked);
	}
}
