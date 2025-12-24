// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="LoggingBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Logging;

[BenchmarkCategory(Categories.Logging)]
public class LoggingBenchmark : Benchmark
{

	private const string CriticalMessage = "CRITICAL ENTRY";
	private const string DebugMessage = "DEBUG ENTRY";
	private const string ErrorMessage = "ERROR ENTRY";
	private const string InformationMessage = "INFORMATION ENTRY";
	private const string StoredProcedure = "Stored Procedure";
	private const string TraceMessage = "TRACE ENTRY";
	private const string WarningMessage = "WARNING ENTRY";

	private ILogger<LoggingBenchmark> _logger;
	private readonly ArgumentInvalidException _testException = new("TEST EX MESSAGE");

	[Benchmark(Description = nameof(FastLoggerExtensions.LogCriticalMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogCriticalFastLoggerBenchmark()
	{
		this._logger.LogCriticalMessage(CriticalMessage, exception: this._testException);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogCriticalMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogCriticalFastLoggerExtensionsBenchmark()
	{
		this._logger.LogCriticalMessage(CriticalMessage, exception: this._testException);
	}

	[Benchmark(Description = "ILogger.LogCritical")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogCriticalILoggerBenchmark()
	{
		this._logger.LogCritical(100, this._testException, DebugMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogDebugMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogDebugFastLoggerBenchmark()
	{
		this._logger.LogDebugMessage(DebugMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogDebugMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogDebugFastLoggerExtensionsBenchmark()
	{
		this._logger.LogDebugMessage(DebugMessage);
	}

	[Benchmark(Description = "ILogger.LogDebug")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogDebugILoggerBenchmark()
	{
		this._logger.LogDebug(100, DebugMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogErrorMessage) + ": Error Message")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogErrorFastLoggerBenchmark()
	{
		this._logger.LogErrorMessage(ErrorMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogErrorMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogErrorFastLoggerExtensionsBenchmark()
	{
		this._logger.LogErrorMessage(ErrorMessage);
	}

	[Benchmark(Description = "ILogger.LogError")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogErrorILoggerBenchmark()
	{
		this._logger.LogError(exception: this._testException, message: ErrorMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogExceptionMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogExceptionFastLoggerBenchmark()
	{
		this._logger.LogExceptionMessage(ErrorMessage, this._testException);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogExceptionMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogExceptionFastLoggerExtensionsBenchmark()
	{
		this._logger.LogExceptionMessage(ErrorMessage, this._testException);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogInformationMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogInformationFastLoggerBenchmark()
	{
		this._logger.LogInformationMessage(ErrorMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogInformationMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogInformationFastLoggerExtensionsBenchmark()
	{
		this._logger.LogInformationMessage(ErrorMessage);
	}

	[Benchmark(Description = "ILogger.LogInformation")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogInformationILoggerBenchmark()
	{
		this._logger.LogInformation(100, this._testException, InformationMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogStoredProcedureError))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogStoredProcedureErrorFastLoggerExtensionsBenchmark()
	{
		this._logger.LogStoredProcedureError(StoredProcedure, this._testException);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogStoredProcedureNoRecordsFound))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogStoredProcedureNoRecordsFoundFastLoggerExtensionsBenchmark()
	{
		this._logger.LogStoredProcedureNoRecordsFound(StoredProcedure);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogTraceMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogTraceFastLoggerBenchmark()
	{
		this._logger.LogTraceMessage(TraceMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogTraceMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogTraceFastLoggerExtensionsBenchmark()
	{
		this._logger.LogTraceMessage(TraceMessage);
	}

	[Benchmark(Description = "ILogger.LogTrace")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogTraceILoggerBenchmark()
	{
		this._logger.LogTrace(100, this._testException, TraceMessage);
	}

	[Benchmark(Description = nameof(FastLoggerExtensions.LogWarningMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogWarningFastLoggerBenchmark()
	{
		this._logger.LogWarningMessage(WarningMessage);
	}


	[Benchmark(Description = nameof(FastLoggerExtensions.LogWarningMessage))]
	[BenchmarkCategory(Categories.Logging)]
	public void LogWarningFastLoggerExtensionsBenchmark()
	{
		this._logger.LogWarningMessage(WarningMessage);
	}

	[Benchmark(Description = "ILogger.LogWarning")]
	[BenchmarkCategory(Categories.Logging)]
	public void LogWarningILoggerBenchmark()
	{
		this._logger.LogWarning(100, this._testException, DebugMessage);
	}

	public override void Setup()
	{
		base.Setup();

		this._logger = new LoggerFactory().CreateLogger<LoggingBenchmark>();
	}

}
