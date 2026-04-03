// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-03-2026
// ***********************************************************************
// <copyright file="TaskHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class TaskHelperTests
{

	private string _fireResult = string.Empty;

	private async Task Fire(string input)
	{
		this._fireResult = input;

		Console.WriteLine(input);

		await Task.Delay(1).ConfigureAwait(false);
	}

	private async Task<string> FireWithReturn(string input)
	{
		this._fireResult = input;

		Console.WriteLine(input);

		await Task.Delay(1).ConfigureAwait(false);

		return input;
	}

	[TestMethod]
	public void RunSync10()
	{
		TaskHelper.RunSync(() => this.Fire(nameof(this.RunSync10)));

		Assert.AreEqual(nameof(this.RunSync10), this._fireResult);
	}

	[TestMethod]
	public void RunSync11()
	{
		var cancelToken = new CancellationTokenSource().Token;

		TaskHelper.RunSync(() => this.Fire(nameof(this.RunSync11)), cancellationToken: cancelToken);

		Assert.AreEqual(nameof(this.RunSync11), this._fireResult);
	}

	[TestMethod]
	public void RunSync12()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => TaskHelper.RunSync((Func<Task>)null));
	}

	[TestMethod]
	public void RunSync13()
	{
		var cancelToken = new CancellationTokenSource().Token;

		Assert.ThrowsExactly<ArgumentNullException>(() => TaskHelper.RunSync((Func<Task>)null, cancelToken));
	}

	[TestMethod]
	public void RunSync14()
	{
		var testInput = RandomData.GenerateWord(10);
		var cancelToken = new CancellationTokenSource().Token;

		TaskHelper.RunSync(() => this.Fire(testInput), cancelToken, TaskCreationOptions.PreferFairness, TaskContinuationOptions.None, TaskScheduler.Default);

		Assert.AreEqual(testInput, this._fireResult);
	}

	[TestMethod]
	public void RunSync20()
	{
		_ = TaskHelper.RunSync(() => this.FireWithReturn(nameof(this.RunSync20)));

		Assert.AreEqual(nameof(this.RunSync20), this._fireResult);
	}

	[TestMethod]
	public void RunSync21()
	{
		var cancelToken = new CancellationTokenSource().Token;

		_ = TaskHelper.RunSync(() => this.FireWithReturn(nameof(this.RunSync21)), cancellationToken: cancelToken);

		Assert.AreEqual(nameof(this.RunSync21), this._fireResult);
	}

	[TestMethod]
	public void RunSync22()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => TaskHelper.RunSync((Func<Task<string>>)null));
	}

	[TestMethod]
	public void RunSync23()
	{
		Assert.ThrowsExactly<InvalidOperationException>(() => TaskHelper.RunSync(() => Task.FromResult<string>(null)));
	}

	[TestMethod]
	public void RunSync24()
	{
		var cancelToken = new CancellationTokenSource().Token;

		Assert.ThrowsExactly<ArgumentNullException>(() => TaskHelper.RunSync((Func<Task<string>>)null, cancelToken));
	}

	[TestMethod]
	public void RunSync25()
	{
		var cancelToken = new CancellationTokenSource().Token;

		Assert.ThrowsExactly<InvalidOperationException>(() => TaskHelper.RunSync(() => Task.FromResult<string>(null), cancelToken));
	}

	[TestMethod]
	public void RunSync26()
	{
		var testInput = RandomData.GenerateWord(10);
		var cancelToken = new CancellationTokenSource().Token;

		var result = TaskHelper.RunSync(() => this.FireWithReturn(testInput), cancelToken, TaskCreationOptions.PreferFairness, TaskContinuationOptions.None, TaskScheduler.Default);

		Assert.AreEqual(testInput, result);
	}

}
