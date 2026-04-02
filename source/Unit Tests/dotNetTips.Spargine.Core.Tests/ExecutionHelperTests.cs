// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-02-2026
// ***********************************************************************
// <copyright file="ExecutionHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ExecutionHelperTests
{

	private const int RetryCount = 3;
	private const int RetryWait = 10;

	[TestMethod]
	public void ProgressiveRetryTest()
	{
		var result = ExecutionHelper.ProgressiveRetry(() =>
		{
			var types = TypeHelper.BuiltInTypeNames();
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Value);
		Assert.IsFalse(result.HasErrors);
	}

	[TestMethod]
	public void ProgressiveRetry_NullOperation_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ExecutionHelper.ProgressiveRetry(null!));
	}

	[TestMethod]
	public void ProgressiveRetry_RetryCountZero_ThrowsArgumentOutOfRangeException()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			ExecutionHelper.ProgressiveRetry(() => { }, retryCount: 0, retryWaitMilliseconds: RetryWait));
	}

	[TestMethod]
	public void ProgressiveRetry_RetryWaitZero_ThrowsArgumentOutOfRangeException()
	{
		Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
			ExecutionHelper.ProgressiveRetry(() => { }, retryCount: RetryCount, retryWaitMilliseconds: 0));
	}

	[TestMethod]
	public void ProgressiveRetry_OperationAlwaysFails_RetriesAndReturnsErrors()
	{
		var callCount = 0;

		var result = ExecutionHelper.ProgressiveRetry(() =>
		{
			callCount++;
			throw new InvalidOperationException($"Failure {callCount}");
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

		Assert.IsNotNull(result);
		Assert.AreEqual(RetryCount, result.Value);
		Assert.IsTrue(result.HasErrors);
		Assert.AreEqual(RetryCount, result.Errors.Count);
	}

	[TestMethod]
	public void ProgressiveRetry_OperationSucceedsAfterRetry_ReturnsPartialErrors()
	{
		var callCount = 0;

		var result = ExecutionHelper.ProgressiveRetry(() =>
		{
			callCount++;

			if (callCount < RetryCount)
			{
				throw new InvalidOperationException($"Failure {callCount}");
			}
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

		Assert.IsNotNull(result);
		Assert.AreEqual(RetryCount, result.Value);
		Assert.IsTrue(result.HasErrors);
		Assert.AreEqual(RetryCount - 1, result.Errors.Count);
	}

	[TestMethod]
	public void ProgressiveRetry_WithNullLogger_DoesNotThrow()
	{
		var result = ExecutionHelper.ProgressiveRetry(() =>
		{
			throw new InvalidOperationException("Test failure");
		}, retryCount: 1, retryWaitMilliseconds: RetryWait, logger: null);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.HasErrors);
	}

	[TestMethod]
	public void ProgressiveRetry_WithLogger_LogsErrors()
	{
		var logger = new MockLogger();

		var result = ExecutionHelper.ProgressiveRetry(() =>
		{
			throw new InvalidOperationException("Test failure");
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait, logger: logger);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.HasErrors);
		Assert.AreEqual(RetryCount, logger.LoggedLevels.Count);

		foreach (var level in logger.LoggedLevels)
		{
			Assert.AreEqual(LogLevel.Error, level);
		}
	}

	[TestMethod]
	public async Task ProgressiveRetryAsyncTest()
	{
		var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
		{
			var types = TypeHelper.BuiltInTypeNames();
			return Task.CompletedTask;
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Value);
		Assert.IsFalse(result.HasErrors);
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_NullFunction_ThrowsArgumentNullException()
	{
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await ExecutionHelper.ProgressiveRetryAsync(null!));
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_RetryCountZero_ThrowsArgumentOutOfRangeException()
	{
		await Assert.ThrowsExactlyAsync<ArgumentOutOfRangeException>(async () =>
			await ExecutionHelper.ProgressiveRetryAsync(() => Task.CompletedTask, retryCount: 0, retryWaitMilliseconds: RetryWait));
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_RetryWaitZero_ThrowsArgumentOutOfRangeException()
	{
		await Assert.ThrowsExactlyAsync<ArgumentOutOfRangeException>(async () =>
			await ExecutionHelper.ProgressiveRetryAsync(() => Task.CompletedTask, retryCount: RetryCount, retryWaitMilliseconds: 0));
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_FunctionAlwaysFails_RetriesAndReturnsErrors()
	{
		var callCount = 0;

		var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
		{
			callCount++;
			throw new InvalidOperationException($"Failure {callCount}");
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

		Assert.IsNotNull(result);
		Assert.AreEqual(RetryCount, result.Value);
		Assert.IsTrue(result.HasErrors);
		Assert.AreEqual(RetryCount, result.Errors.Count);
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_FunctionSucceedsAfterRetry_ReturnsPartialErrors()
	{
		var callCount = 0;

		var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
		{
			callCount++;

			if (callCount < RetryCount)
			{
				throw new InvalidOperationException($"Failure {callCount}");
			}

			return Task.CompletedTask;
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

		Assert.IsNotNull(result);
		Assert.AreEqual(RetryCount, result.Value);
		Assert.IsTrue(result.HasErrors);
		Assert.AreEqual(RetryCount - 1, result.Errors.Count);
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_WithNullLogger_DoesNotThrow()
	{
		var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
		{
			throw new InvalidOperationException("Test failure");
		}, retryCount: 1, retryWaitMilliseconds: RetryWait, logger: null);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.HasErrors);
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_WithLogger_LogsErrors()
	{
		var logger = new MockLogger();

		var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
		{
			throw new InvalidOperationException("Test failure");
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait, logger: logger);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.HasErrors);
		Assert.AreEqual(RetryCount, logger.LoggedLevels.Count);

		foreach (var level in logger.LoggedLevels)
		{
			Assert.AreEqual(LogLevel.Error, level);
		}
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_WithCancellationToken_CancelsOnRequest()
	{
		using var cts = new CancellationTokenSource();
		var callCount = 0;

		var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
		{
			callCount++;

			if (callCount == 1)
			{
				cts.Cancel();
			}

			throw new InvalidOperationException("Test failure");
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait, cancellationToken: cts.Token);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.HasErrors);
		Assert.IsTrue(callCount < RetryCount);
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_WithAlreadyCancelledToken_ThrowsAndReturnsErrors()
	{
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
		{
			return Task.CompletedTask;
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait, cancellationToken: cts.Token);

		Assert.IsNotNull(result);
		Assert.IsTrue(result.HasErrors);
	}

	[TestMethod]
	public async Task ProgressiveRetryAsync_WithDefaultCancellationToken_Succeeds()
	{
		var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
		{
			return Task.CompletedTask;
		}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait, cancellationToken: default);

		Assert.IsNotNull(result);
		Assert.AreEqual(1, result.Value);
		Assert.IsFalse(result.HasErrors);
	}

	internal class MockLogger : ILogger
	{
		public List<LogLevel> LoggedLevels { get; } = [];
		public List<string> LoggedMessages { get; } = [];

		public IDisposable BeginScope<TState>(TState state) where TState : notnull => null!;

		public bool IsEnabled(LogLevel logLevel) => true;

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			this.LoggedLevels.Add(logLevel);
			this.LoggedMessages.Add(formatter(state, exception));
		}
	}

}
