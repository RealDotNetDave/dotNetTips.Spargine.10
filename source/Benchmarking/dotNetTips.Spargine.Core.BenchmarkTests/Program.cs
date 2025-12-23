// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2025
// ***********************************************************************
// <copyright file="Program.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Perfolizer.Horology;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Class Program.
/// </summary>
internal sealed class Program
{
	/// <summary>
	/// Defines the entry point of the application.
	/// </summary>
	private static void Main()
	{
		try
		{
			var config = DefaultConfig.Instance
				.AddJob(Job.Default.WithRuntime(CoreRuntime.Latest))
				.WithSummaryStyle(SummaryStyle.Default.WithTimeUnit(TimeUnit.Nanosecond));

			config = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true);

			_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

			//_ = BenchmarkRunner.Run<FastSortedListCreateAddBenchmark>(config);
			//_ = BenchmarkRunner.Run<EnumHelperBenchmark>(config);

			ConsoleLogger.Default.WriteLine("COMPLETE!");
			Console.Beep();
			Console.Beep(frequency: 500, duration: 1000);
			Console.Beep(frequency: 750, duration: 2000);
			Console.Beep(frequency: 800, duration: 3000);
			_ = Console.ReadLine();
		}
		catch (Exception ex)
		{
			ConsoleLogger.Default.WriteLine("ERROR!");
			ConsoleLogger.Default.WriteLine(ex.Message);
			Console.Beep(frequency: 5000, duration: 6000);
			_ = Console.ReadLine();
		}
	}
}
