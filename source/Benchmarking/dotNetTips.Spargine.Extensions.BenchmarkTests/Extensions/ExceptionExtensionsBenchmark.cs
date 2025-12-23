// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-02-2024
// ***********************************************************************
// <copyright file="ExceptionExtensionsBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Security;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

public class ExceptionExtensionsBenchmark : Benchmark
{

	private readonly SecurityException _testException = new("Message from SecurityException");

	[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessages))]
	public void GetAllMessages()
	{
		this.Consume(this._testException.GetAllMessages());
	}

	[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessages) + ": Separator")]
	[BenchmarkCategory(Categories.New)]
	public void GetAllMessagesSeparator()
	{
		this.Consume(this._testException.GetAllMessages(ControlChars.Colon));
	}

	[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessagesWithStackTrace))]
	public void GetAllMessagesWithStackTrace()
	{
		this.Consume(this._testException.GetAllMessagesWithStackTrace());
	}

}
