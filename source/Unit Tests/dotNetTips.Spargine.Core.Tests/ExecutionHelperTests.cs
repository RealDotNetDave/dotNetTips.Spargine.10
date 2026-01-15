// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-28-2025
// ***********************************************************************
// <copyright file="ExecutionHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
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
	public async Task ProgressiveRetryAsyncTest()
	{
		try
		{
			var result = await ExecutionHelper.ProgressiveRetryAsync(() =>
			{

				var types = TypeHelper.BuiltInTypeNames();
				return Task.CompletedTask;

			}, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

			Assert.IsGreaterThan(0, result.Value);
		}
		catch (Exception ex)
		{
			Assert.Fail($"Progressive retry failed: {ex.Message}.");
		}
	}

	[TestMethod]
	public void ProgressiveRetryTest()
	{
		try
		{
			var result = ExecutionHelper.ProgressiveRetry(() =>
			  {
				  var types = TypeHelper.BuiltInTypeNames();
			  }, retryCount: RetryCount, retryWaitMilliseconds: RetryWait);

			Assert.IsGreaterThan(0, result.Value);
		}
		catch (Exception ex)
		{
			Assert.Fail($"Progressive retry failed: {ex.Message}.");
		}
	}

}
