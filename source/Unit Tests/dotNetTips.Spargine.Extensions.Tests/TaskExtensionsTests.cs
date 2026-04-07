// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-06-2026
// ***********************************************************************
// <copyright file="TaskExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class TaskExtensionsTests
{

	private string _fireResult = string.Empty;

	private async Task FireAsync(string input)
	{
		this._fireResult = input;

		Console.WriteLine(input);

		await Task.Delay(1).ConfigureAwait(false);
	}

	private static Task FaultingTask()
	{
		return Task.FromException(new InvalidOperationException("Test exception"));
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
	public void FireAndForgetNullTaskTest()
	{
		Task task = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => task.FireAndForget());
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

}
