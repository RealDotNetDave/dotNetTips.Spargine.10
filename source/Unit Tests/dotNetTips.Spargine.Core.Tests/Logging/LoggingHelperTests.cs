// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-06-2024
// ***********************************************************************
// <copyright file="LoggingHelperTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests.Logging;

[ExcludeFromCodeCoverage]
[TestClass]
public class LoggingHelperTests
{

	private readonly ILogger _logger = new NullLogger<LoggingHelperTests>();

	[TestMethod]
	public void LogApplicationInformationTest()
	{
		LoggingHelper.LogApplicationInformation(this._logger);
	}

	[TestMethod]
	public void LogComputerInformationTest()
	{
		LoggingHelper.LogComputerInformation(this._logger);
	}

	[TestMethod]
	public void RetrieveAllExceptionMessagesTest()
	{
		var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

		var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

		Assert.IsTrue(result.Count == 2);
	}
	[TestMethod]
	public void RetrieveAllExceptionsTest()
	{
		var testException = new ArgumentNullException("TEST EX1.", new ArithmeticException("TEST EX2"));

		var result = LoggingHelper.RetrieveAllExceptions(testException);

		Assert.IsTrue(result.Count == 2);
	}

}
