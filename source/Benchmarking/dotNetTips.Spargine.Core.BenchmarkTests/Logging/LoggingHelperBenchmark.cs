// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 04-26-2022
//
// Last Modified By : David McCarter
// Last Modified On : 11-22-2024
// ***********************************************************************
// <copyright file="LoggingHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Logging;

[BenchmarkCategory(Categories.Logging)]
public class LoggingHelperBenchmark : Benchmark
{
	private const string MessageTest1 = "TEST EX1.";
	private const string MessageTest2 = "TEST EX2";

	private ILogger<LoggingHelperBenchmark> _logger;

	[Benchmark(Description = nameof(LoggingHelper.LogApplicationInformation))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogApplicationInformation()
	{
		LoggingHelper.LogApplicationInformation(this._logger);
	}

	[Benchmark(Description = nameof(LoggingHelper.LogComputerInformation))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogComputerInformation()
	{
		LoggingHelper.LogComputerInformation(this._logger);
	}

	[Benchmark(Description = nameof(LoggingHelper.RetrieveAllExceptionMessages))]
	[BenchmarkCategory(Categories.Logging)]
	public void RetrieveAllExceptionMessages()
	{
		var testException = new ArgumentNullException(MessageTest1, new ArithmeticException(MessageTest2));

		var result = LoggingHelper.RetrieveAllExceptionMessages(testException);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(LoggingHelper.RetrieveAllExceptions))]
	[BenchmarkCategory(Categories.Logging)]
	public void RetrieveAllExceptions()
	{
		var testException = new ArgumentNullException(MessageTest1, new ArithmeticException(MessageTest2));

		var result = LoggingHelper.RetrieveAllExceptions(testException);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._logger = new LoggerFactory().CreateLogger<LoggingHelperBenchmark>();
	}

}
