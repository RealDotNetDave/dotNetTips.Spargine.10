// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-04-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2025
// ***********************************************************************
// <copyright file="ExceptionExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security;
using DotNetTips.Spargine.Core.Logging;
using DotNetTips.Spargine.Core.Serialization;
using Microsoft.Extensions.Logging;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides extension methods for working with exceptions.
/// </summary>
/// <remarks>
/// This class contains utility methods and properties to enhance exception handling.
/// </remarks>
[Information(nameof(ExceptionExtensions), Status = Status.New)]
public static class ExceptionExtensions
{
	/// <summary>
	/// Provides a thread-safe storage for metadata associated with exceptions.
	/// </summary>
	private static readonly ConditionalWeakTable<Exception, ExceptionMetadata> _exceptionMetadata = [];

	/// <summary>
	/// Provides a lock object for synchronizing access to shared resources.
	/// </summary>
	private static readonly Lock _threadLock = new();

	/// <summary>
	/// Clears the logged state of the exception.
	/// </summary>
	/// <param name="ex">The exception instance to clear.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="ex"/> is <c>null</c>.</exception>
	[Information(nameof(ClearIsLogged), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static void ClearIsLogged([DisallowNull] this Exception ex)
	{
		ex = ex.ArgumentNotNull();

		lock (_threadLock)
		{
			_ = _exceptionMetadata.Remove(ex);
		}
	}

	/// <summary>
	/// Gets or sets a value indicating whether the exception has been logged.
	/// </summary>
	/// <param name="ex">The exception instance to check or update.</param>
	/// <returns><c>true</c> if the exception has been logged; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="ex"/> is <c>null</c>.</exception>
	[Information(nameof(IsLogged), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool IsLogged([DisallowNull] this Exception ex)
	{
		ex = ex.ArgumentNotNull();

		lock (_threadLock)
		{
			return _exceptionMetadata.TryGetValue(ex, out var metadata) && metadata.IsLogged;
		}
	}

	/// <summary>
	/// Sets a value indicating whether the exception has been logged.
	/// </summary>
	/// <param name="ex">The exception instance to update.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="ex"/> is <c>null</c>.</exception>
	[Information(nameof(SetIsLogged), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static void SetIsLogged([DisallowNull] this Exception ex)
	{
		ex = ex.ArgumentNotNull();

		lock (_threadLock)
		{
			var metadata = _exceptionMetadata.GetOrCreateValue(ex);
			metadata.IsLogged = true;
		}
	}

	/// <summary>
	/// Represents metadata associated with an exception.
	/// </summary>
	/// <param name="IsLogged"> Gets or sets a value indicating whether the exception has been logged. </param>
	/// <remarks>
	/// This class is used internally to store additional information about exceptions, such as their logged state.
	/// </remarks>
	private sealed record ExceptionMetadata(bool IsLogged)
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExceptionMetadata"/> class.
		/// </summary>
		public ExceptionMetadata() : this(false)
		{
		}

		private string GetDebuggerDisplay() => this.ToString();

		/// <summary>
		/// Gets or sets a value indicating whether the exception has been logged.
		/// </summary>
		/// <value><c>true</c> if the exception has been logged; otherwise, <c>false</c>.</value>
		public bool IsLogged { get; internal set; } = IsLogged;
	}

	///<summary></summary>
	extension<TSource>([DisallowNull] TSource source) where TSource : Exception
	{
		/// <summary>
		/// Returns an enumerable collection representing the hierarchy of exceptions starting from the specified source exception.
		/// This method is useful for traversing nested exceptions (e.g., when dealing with aggregate exceptions).
		/// </summary>
		/// <param name="accumulatorFunction">A delegate that defines the method to retrieve the next exception in the hierarchy.</param>
		/// <returns>An <see cref="IEnumerable{TSource}"/> that represents the hierarchy of exceptions.</returns>
		[Information(nameof(FromHierarchy), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<TSource> FromHierarchy([DisallowNull] Func<TSource, TSource> accumulatorFunction)
		{
			source = source.ArgumentNotNull();
			accumulatorFunction = accumulatorFunction.ArgumentNotNull();

			return FromHierarchy(source, accumulatorFunction, s => s is not null);
		}

		/// <summary>
		/// Returns the hierarchy from the source, validating that source, <paramref name="nextItem"/>, and <paramref name="canContinuePredicate"/> are not null.
		/// This method allows traversing a hierarchy (e.g., of exceptions) by repeatedly applying <paramref name="nextItem"/> to get the next item in the hierarchy,
		/// until <paramref name="canContinuePredicate"/> returns false.
		/// </summary>
		/// <param name="nextItem">A function to get the next item in the hierarchy from the current item.</param>
		/// <param name="canContinuePredicate">A function that determines whether to continue traversing the hierarchy from the current item.</param>
		/// <returns>A sequence of items from the source up through the hierarchy as determined by <paramref name="nextItem"/> and <paramref name="canContinuePredicate"/>.</returns>
		[Information(nameof(FromHierarchy), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public IEnumerable<TSource> FromHierarchy([DisallowNull] Func<TSource, TSource> nextItem, [DisallowNull] Func<TSource, bool> canContinuePredicate)
		{
			source = source.ArgumentNotNull();
			nextItem = nextItem.ArgumentNotNull();
			canContinuePredicate = canContinuePredicate.ArgumentNotNull();

			while (source != null && canContinuePredicate(source))
			{
				yield return source;
				source = nextItem(source);
			}
		}
	}

	///<summary></summary>
	extension([DisallowNull] Exception exception)
	{
		/// <summary>
		/// Retrieves all inner exceptions from the specified exception as a flat list.
		/// </summary>
		/// <returns>A list of all inner exceptions.</returns>
		[Information(nameof(GetAllInnerExceptions), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public IReadOnlyList<Exception> GetAllInnerExceptions()
		{
			exception = exception.ArgumentNotNull();

			return exception.FromHierarchy(ex => ex.InnerException!).Skip(1).ToList();
		}

		/// <summary>
		/// Extracts all key-value pairs from the <see cref="Exception.Data"/> property.
		/// </summary>
		/// <returns>A dictionary containing all key-value pairs from the exception's data.</returns>
		[Information(nameof(ExtractData), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public IReadOnlyDictionary<object, object?> ExtractData()
		{
			exception = exception.ArgumentNotNull();

			return exception.Data.Cast<DictionaryEntry>()
				.ToDictionary(entry => entry.Key, entry => entry.Value);
		}

		/// <summary>
		/// Determines whether the exception or any of its inner exceptions is of the specified type.
		/// </summary>
		/// <typeparam name="T">The type of exception to check for.</typeparam>
		/// <returns><c>true</c> if the exception or any inner exception is of type <typeparamref name="T"/>; otherwise, <c>false</c>.</returns>
		[Information(nameof(ContainsExceptionOfType), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public bool ContainsExceptionOfType<T>() where T : Exception
		{
			ArgumentNullException.ThrowIfNull(exception);

			return exception.FromHierarchy(ex => ex.InnerException!).Any(ex => ex is T);
		}

		/// <summary>
		/// Extracts metadata associated with the exception.
		/// </summary>
		/// <returns>A dictionary containing metadata key-value pairs.</returns>
		[Information(nameof(GetMetadata), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public IReadOnlyDictionary<string, object> GetMetadata()
		{
			ArgumentNullException.ThrowIfNull(exception);

			lock (_threadLock)
			{
				if (_exceptionMetadata.TryGetValue(exception, out var metadata))
				{
					return new Dictionary<string, object>
		{
			{ "IsLogged", metadata.IsLogged }
		};
				}

				return new Dictionary<string, object>();
			}
		}

		/// <summary>
		/// Determines whether the exception or any of its inner exceptions is an <see cref="AggregateException"/>.
		/// </summary>
		/// <returns><c>true</c> if an <see cref="AggregateException"/> is found; otherwise, <c>false</c>.</returns>
		[Information(nameof(ContainsAggregateException), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public bool ContainsAggregateException()
		{
			exception = exception.ArgumentNotNull();

			return exception.FromHierarchy(ex => ex.InnerException!).Any(ex => ex is AggregateException);
		}

		/// <summary>
		/// Determines whether the exception or any of its inner exceptions contains the specified message.
		/// </summary>
		/// <param name="message">The message to search for.</param>
		/// <returns><c>true</c> if the message is found; otherwise, <c>false</c>.</returns>
		[Information(nameof(ContainsMessage), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public bool ContainsMessage([DisallowNull] string message)
		{
			exception = exception.ArgumentNotNull();
			message = message.ArgumentNotNullOrEmpty();

			return exception.FromHierarchy(ex => ex.InnerException!).Any(ex => ex.Message.Contains(message, StringComparison.OrdinalIgnoreCase));
		}

		/// <summary>
		/// Serializes the exception and its details into a JSON string.
		/// </summary>
		/// <returns>A JSON string representing the exception.</returns>
		[return: NotNull]
		[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public string ToJson()
		{
			if (exception is null)
			{
				return string.Empty;
			}

			var exceptionDetails = new
			{
				exception.Message,
				exception.StackTrace,
				InnerExceptions = exception.GetAllInnerExceptions()
				.Select(ex => new { ex.Message, ex.StackTrace })
			};

			return JsonSerialization.Serialize(exceptionDetails);
		}

		/// <summary>
		/// Logs the exception and its details using the provided logger and FastLoggerExtensions.
		/// </summary>
		/// <param name="logger">The logger to use for logging.</param>
		/// <param name="logLevel">The log level to use. Defaults to Error.</param>
		[Information(nameof(LogException), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public void LogException([DisallowNull] ILogger logger, LogLevel logLevel = LogLevel.Error)
		{
			logger = logger.ArgumentNotNull();

			if (logger.IsEnabled(logLevel) == false)
			{
				return;
			}

			exception = exception.ArgumentNotNull();

			// Log the main exception message based on the log level
			switch (logLevel)
			{
				case LogLevel.Critical:
					logger.LogCriticalMessage(exception.Message, exception);
					break;

				case LogLevel.Error:
					logger.LogExceptionMessage(exception.Message, exception);
					break;

				case LogLevel.Warning:
					logger.LogWarningMessage($"Warning: {exception.Message}");
					break;
				case LogLevel.Information:
					logger.LogInformationMessage($"Info: {exception.Message}");
					break;
				case LogLevel.Debug:
					logger.LogDebugMessage($"Debug: {exception.Message}");
					break;

				case LogLevel.Trace:
					logger.LogTraceMessage($"Trace: {exception.Message}");
					break;
				case LogLevel.None:
					break;
				default:
					logger.LogErrorMessage($"Unhandled log level: {logLevel}. Exception: {exception.Message}");
					break;
			}

			// Log inner exceptions, if any
			foreach (var ex in exception.FromHierarchy(ex => ex.InnerException!))
			{
				switch (logLevel)
				{
					case LogLevel.Critical:
						logger.LogCriticalMessage(ex.Message, ex);
						break;

					case LogLevel.Error:
						logger.LogExceptionMessage(ex.Message, ex);
						break;

					case LogLevel.Warning:
						logger.LogWarningMessage($"Inner Warning: {ex.Message}");
						break;
					case LogLevel.Information:
						logger.LogInformationMessage($"Inner Info: {ex.Message}");
						break;
					case LogLevel.Debug:
						logger.LogDebugMessage($"Inner Debug: {ex.Message}");
						break;

					case LogLevel.Trace:
						logger.LogTraceMessage($"Inner Trace: {ex.Message}");
						break;
					case LogLevel.None:
						break;
					default:
						logger.LogErrorMessage($"Unhandled log level for inner exception: {logLevel}. Exception: {ex.Message}");
						break;
				}
			}

			exception.SetIsLogged();
		}

		/// <summary>
		/// Formats the exception details into a human-readable string for display.
		/// </summary>
		/// <returns>
		/// A formatted string containing the exception type, message, and stack trace.
		/// If the exception is <c>null</c>, returns an empty string.
		/// </returns>
		/// <remarks>
		/// The formatted string includes:
		/// <list type="bullet">
		/// <item><description>The exception type name.</description></item>
		/// <item><description>The exception message.</description></item>
		/// <item><description>The exception stack trace, or "NONE" if not available.</description></item>
		/// </list>
		/// </remarks>
		[return: NotNull]
		[Information(nameof(FormatForDisplay), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
		public string FormatForDisplay()
		{
			if (exception is null)
			{
				return string.Empty;
			}

			return FastStringBuilder.Combine(true, $"Exception: {exception.GetType().Name}", $"Message: {exception.Message}", $"StackTrace: {exception.StackTrace ?? "NONE"}");
		}

		/// <summary>
		/// Gets all messages and their stack traces from an <see cref="Exception"/> and its inner exceptions, encapsulating them into a read-only collection.
		/// Each tuple in the collection contains the message and the stack trace of an exception.
		/// If the stack trace is null, "NONE" is used as a placeholder.
		/// </summary>
		/// <returns>A <see cref="ReadOnlyCollection{T}"/> where each item is a tuple containing the message and stack trace of an exception.</returns>
		[Information(nameof(GetAllMessagesWithStackTrace), author: "David McCarter", createdOn: "10/12/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
		public IReadOnlyList<(string message, string StackTrace)> GetAllMessagesWithStackTrace()
		{
			exception = exception.ArgumentNotNull();

			var result = new List<(string message, string StackTrace)>();

			foreach (var ex in exception.FromHierarchy(ex => ex.InnerException!))
			{
				result.Add((ex.Message, ex.StackTrace ?? "NONE"));
			}

			return result.AsReadOnly();
		}

		/// <summary>
		/// Gets all messages from an <see cref="Exception"/> and its inner exceptions, concatenated into a single string.
		/// </summary>
		/// <param name="delimiter">The character used to separate individual exception messages in the resulting string. Defaults to a comma.</param>
		/// <returns>A string containing all exception messages, separated by the specified delimiter.</returns>
		[return: NotNull]
		[Information(nameof(GetAllMessages), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2024")]
		public string GetAllMessages([ConstantExpected] char delimiter = ControlChars.Comma)
		{
			exception = exception.ArgumentNotNull();

			var messages = exception.FromHierarchy(ex => ex.InnerException!).Select(ex => ex.Message);

			return FastStringBuilder.Join(messages, delimiter);
		}

		/// <summary>
		/// Determines whether the specified <see cref="Exception"/> is considered critical. A critical exception is one of the following types:
		/// <see cref="NullReferenceException"/>, <see cref="StackOverflowException"/>, <see cref="OutOfMemoryException"/>, <see cref="ThreadAbortException"/>,
		/// <see cref="IndexOutOfRangeException"/>, or <see cref="AccessViolationException"/>.
		/// </summary>
		/// <returns><c>true</c> if the exception is critical; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsCritical()
		{
			return exception is null
							? false
							: exception is NullReferenceException or
						StackOverflowException or
						OutOfMemoryException or
						ThreadAbortException or
						IndexOutOfRangeException or
						AccessViolationException;
		}

		/// <summary>
		/// Determines whether the specified <see cref="Exception"/> is fatal. A fatal exception is one that is severe enough to justify terminating the application, such as <see cref="OutOfMemoryException"/>.
		/// </summary>
		/// <returns><c>true</c> if the exception is fatal; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsFatal()
		{
			return exception is null ? false : exception is OutOfMemoryException;
		}

		/// <summary>
		/// Determines whether the specified <see cref="Exception"/> is either a <see cref="SecurityException"/> or considered critical.
		/// A critical exception is one of the types identified by the <see cref="IsCritical"/> method.
		/// </summary>
		/// <returns><c>true</c> if the exception is a <see cref="SecurityException"/> or critical; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public bool IsSecurityOrCritical()
		{
			return exception is null ? false : (exception is SecurityException) || exception.IsCritical();
		}

		/// <summary>
		/// Traverses the exception hierarchy starting from the specified exception to find an exception of type <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type of exception to search for.</typeparam>
		/// <returns>An exception of type <typeparamref name="T"/> if found; otherwise, null.</returns>
		[Information(nameof(TraverseFor), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public T? TraverseFor<T>()
			where T : class
		{
			exception = exception.ArgumentNotNull();

			while (exception != null)
			{
				if (exception is T targetException)
				{
					return targetException;
				}

				exception = exception.InnerException!;
			}

			return null!;
		}
	}
}
