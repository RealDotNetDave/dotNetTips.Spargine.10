// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="ExceptionExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Security;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Exceptions)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class ExceptionExtensionsBenchmark : Benchmark
{

	private readonly SecurityException _testException = new("Message from SecurityException");

	[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessages))]
	public void GetAllMessages()
	{
		this.Consume(this._testException.GetAllMessages());
	}

	[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessages) + ": Separator")]
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
