// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 12-21-2025
// ***********************************************************************
// <copyright file="FastLoggerExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for FastLogger.</summary>
// ***********************************************************************

using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Logging;

/// <summary>
/// Extension methods for <see cref="ILogger"/> to simplify logging with enriched messages including the calling method's name.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineFastLoggerExtensions")]
public static partial class FastLoggerExtensions
{
	/// <summary>
	/// Logs a single computer information item as a structured log entry using source-generated logging.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="key">The property name or key of the computer information item.</param>
	/// <param name="value">The value associated with the computer information key.</param>
	/// <param name="category">The category name for grouping related log entries. Defaults to <c>ComputerInfo</c>.</param>
	/// <remarks>
	/// This method uses compile-time source generation for optimal performance, avoiding runtime allocations
	/// and string interpolation overhead. It is designed for high-throughput logging scenarios where
	/// performance is critical.
	/// <para>
	/// The method follows Microsoft's recommended logging practices by using <see cref="LoggerMessageAttribute"/>
	/// for compile-time code generation, which provides:
	/// </para>
	/// <list type="bullet">
	/// <item><description>Zero allocation logging - no boxing or string interpolation at runtime</description></item>
	/// <item><description>Strongly-typed parameters with compile-time validation</description></item>
	/// <item><description>Structured logging support for log aggregation and searching</description></item>
	/// <item><description>3-6x performance improvement over traditional logging extension methods</description></item>
	/// </list>
	/// <para>
	/// This method is typically called from <see cref="LoggingHelper.LogComputerInformation"/> to log
	/// individual computer information properties such as OS version, architecture, memory usage, and other
	/// system details.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// ILogger logger = loggerFactory.CreateLogger&lt;MyClass&gt;();
	/// logger.LogComputerInfoItem("OSVersion", "Windows 11", "ComputerInfo");
	/// // Logs: ComputerInfo:OSVersion - Windows 11
	/// </code>
	/// </example>
	[LoggerMessage(EventId = 401, Level = LogLevel.Information, EventName = "ComputerInfo", Message = "{category}:{key} - {value}")]
	internal static partial void LogComputerInfoItem(this ILogger logger, string key, string value, string category = nameof(ComputerInfo));

	/// <summary>
	/// Logs a critical level message along with an exception using the specified <see cref="ILogger"/>.
	/// This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The critical message to log.</param>
	/// <param name="exception">The <see cref="Exception"/> related to the critical log entry.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogCriticalMessage), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 911, Level = LogLevel.Critical, EventName = "CRITICAL", Message = "{methodName}: {message}.")]
	public static partial void LogCriticalMessage(this ILogger logger, string message, Exception exception, [CallerMemberName] string methodName = ControlChars.EmptyString);

	/// <summary>
	/// Logs a debug level message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The debug message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogDebugMessage), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 200, Level = LogLevel.Debug, EventName = "DEBUG", Message = "{methodName}: {message}.")]
	public static partial void LogDebugMessage(this ILogger logger, string message, [CallerMemberName] string methodName = ControlChars.EmptyString);

	/// <summary>
	/// Logs an error message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The error message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogErrorMessage), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 300, Level = LogLevel.Error, EventName = "ERROR", Message = "{methodName}: {message}.")]
	public static partial void LogErrorMessage(this ILogger logger, string message, [CallerMemberName] string methodName = ControlChars.EmptyString);

	/// <summary>
	/// Logs an exception message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The exception message to log.</param>
	/// <param name="exception">The <see cref="Exception"/> that occurred.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogExceptionMessage), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 500, Level = LogLevel.Error, EventName = "EXCEPTION", Message = "{methodName}: {message}.")]
	public static partial void LogExceptionMessage(this ILogger logger, string message, Exception exception, [CallerMemberName] string methodName = ControlChars.EmptyString);

	/// <summary>
	/// Logs an information level message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The information message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogInformationMessage), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 400, Level = LogLevel.Information, EventName = "INFORMATION", Message = "{methodName}: {message}.")]
	public static partial void LogInformationMessage(this ILogger logger, string message, [CallerMemberName] string methodName = ControlChars.EmptyString);

	/// <summary>
	/// Logs a stored procedure error using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="storedProcedure">The name of the stored procedure that caused the error.</param>
	/// <param name="exception">The <see cref="Exception"/> that was thrown.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogStoredProcedureError), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 700, Level = LogLevel.Error, EventName = "SP ERROR", Message = "{methodName}: Stored procedure error for {storedProcedure}.")]
	public static partial void LogStoredProcedureError(this ILogger logger, string storedProcedure, Exception exception, [CallerMemberName] string methodName = ControlChars.EmptyString);

	/// <summary>
	/// Logs the stored procedure no records found using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="storedProcedure">The name of the stored procedure that returned no records.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogStoredProcedureNoRecordsFound), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 701, Level = LogLevel.Error, EventName = "SP NO RECORDS ERROR", Message = "{methodName}: No records found from stored procedure {storedProcedure}.")]
	public static partial void LogStoredProcedureNoRecordsFound(this ILogger logger, string storedProcedure, [CallerMemberName] string methodName = ControlChars.EmptyString);

	/// <summary>
	/// Logs a trace level message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The trace message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	/// <example>logger.LogTraceMessage($"Entering method {nameof(LogTraceMessage)}.");</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogTraceMessage), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 100, Level = LogLevel.Trace, EventName = "TRACE", Message = "{methodName}: {message}.")]
	public static partial void LogTraceMessage(this ILogger logger, string message, [CallerMemberName] string methodName = ControlChars.EmptyString);

	/// <summary>
	/// Logs a warning message using the specified <see cref="ILogger"/>. This method automatically includes the name of the calling method as part of the logged message.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance to use for logging.</param>
	/// <param name="message">The warning message to log.</param>
	/// <param name="methodName">The name of the method calling this logger, automatically populated by the runtime. Not required to be manually specified.</param>
	/// <example>logger.LogWarningMessage("Database connection pool count is low.");</example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LogWarningMessage), "David McCarter", "2/27/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	[LoggerMessage(EventId = 600, Level = LogLevel.Warning, EventName = "WARNING", Message = "{methodName}: {message}.")]
	public static partial void LogWarningMessage(this ILogger logger, string message, [CallerMemberName] string methodName = ControlChars.EmptyString);

}
