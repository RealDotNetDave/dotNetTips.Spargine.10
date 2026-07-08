// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="TaskExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class TaskExtensionsTests
{

	private string _fireResult = string.Empty;

	[TestMethod]
	public void FireAndForgetNullTaskTest()
	{
		Task task = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => task.FireAndForget());
	}

	[TestMethod]
	public void FireAndForgetTest01()
	{
		var input = RandomData.GenerateWord(10);

		this.FireAsync(input).FireAndForget();

		Assert.AreEqual(input, this._fireResult);
	}

	[TestMethod]
	public void FireAndForgetTest02()
	{
		var input = RandomData.GenerateWord(10);
		Action<Exception> exceptionHandler = (Exception ex) => Debug.WriteLine(ex.Message);

		this.FireAsync(input).FireAndForget(exceptionHandler);

		Assert.AreEqual(input, this._fireResult);
	}

	[TestMethod]
	public async Task FireAndForgetWithActionFaultingTaskTest()
	{
		Exception caughtException = null;
		var tcs = new TaskCompletionSource<bool>();

		Action<Exception> exceptionHandler = (Exception ex) =>
		{
			caughtException = ex;
			tcs.TrySetResult(true);
		};

		FaultingTask().FireAndForget(exceptionHandler);

		await tcs.Task.WaitAsync(TimeSpan.FromSeconds(5)).ConfigureAwait(false);

		Assert.IsNotNull(caughtException);
		Assert.IsInstanceOfType<AggregateException>(caughtException);
	}

	[TestMethod]
	public void FireAndForgetWithActionNullTaskTest()
	{
		Task task = null;
		Action<Exception> exceptionHandler = (Exception ex) => Debug.WriteLine(ex.Message);

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => task.FireAndForget(exceptionHandler));
	}

	[TestMethod]
	public async Task FireAndForgetWithFaultingTaskTest()
	{
		FaultingTask().FireAndForget();

		// Allow time for continuation to process
		await Task.Delay(100).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task IgnoreCancellation_CanceledTask_DoesNotThrow()
	{
		using var cts = new CancellationTokenSource();
		cts.Cancel();

		await Task.FromCanceled(cts.Token).IgnoreCancellation().ConfigureAwait(false);
	}

	[TestMethod]
	public async Task IgnoreCancellation_NullTask_ThrowsArgumentNullException()
	{
		Task task = null;

		_ = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => task.IgnoreCancellation()).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task IgnoreCancellation_WithFaultedTask_PropagatesException()
	{
		var task = Task.FromException(new InvalidOperationException("boom"));

		_ = await Assert.ThrowsExactlyAsync<InvalidOperationException>(() => task.IgnoreCancellation()).ConfigureAwait(false);
	}

	[TestMethod]
	public void UnwrapAggregate_WithMultipleInner_ReturnsFlattenedAggregate()
	{
		var aggregate = new AggregateException(new InvalidOperationException("first"), new ArgumentException("second"));

		var result = aggregate.UnwrapAggregate();

		Assert.IsInstanceOfType<AggregateException>(result);
		Assert.AreEqual(2, ((AggregateException)result).InnerExceptions.Count);
	}

	[TestMethod]
	public void UnwrapAggregate_WithNonAggregate_ReturnsSameInstance()
	{
		var exception = new InvalidOperationException("no-wrap");

		var result = exception.UnwrapAggregate();

		Assert.AreSame(exception, result);
	}

	[TestMethod]
	public void UnwrapAggregate_WithNullException_ThrowsArgumentNullException()
	{
		Exception exception = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => exception.UnwrapAggregate());
	}

	[TestMethod]
	public void UnwrapAggregate_WithSingleInner_ReturnsInnerException()
	{
		var inner = new InvalidOperationException("inner");
		var aggregate = new AggregateException(inner);

		var result = aggregate.UnwrapAggregate();

		Assert.AreSame(inner, result);
	}

	[TestMethod]
	public async Task WithTimeoutAsync_GenericTask_CompletesAndReturnsResult()
	{
		var task = Task.FromResult(42);

		var result = await task.WithTimeoutAsync(TimeSpan.FromSeconds(1)).ConfigureAwait(false);

		Assert.AreEqual(42, result);
	}

	[TestMethod]
	public void WithTimeoutAsync_NullTask_ThrowsArgumentNullException()
	{
		Task task = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => task.WithTimeoutAsync(TimeSpan.FromSeconds(1)));
	}

	[TestMethod]
	public async Task WithTimeoutAsync_TaskCompletesWithinTimeout_DoesNotThrow()
	{
		await Task.Delay(10).WithTimeoutAsync(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task WithTimeoutAsync_TaskTimesOut_ThrowsTimeoutException()
	{
		var task = Task.Delay(TimeSpan.FromSeconds(2));

		_ = await Assert.ThrowsExactlyAsync<TimeoutException>(() => task.WithTimeoutAsync(TimeSpan.FromMilliseconds(50))).ConfigureAwait(false);
	}

	private static Task FaultingTask()
	{
		return Task.FromException(new InvalidOperationException("Test exception"));
	}

	private async Task FireAsync(string input)
	{
		this._fireResult = input;

		Console.WriteLine(input);

		await Task.Delay(1).ConfigureAwait(false);
	}

}
