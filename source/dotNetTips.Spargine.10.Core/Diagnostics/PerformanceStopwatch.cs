// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-17-2025
// ***********************************************************************
// <copyright file="PerformanceStopwatch.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Enhances Stopwatch with helpful methods: StartNew() and StopReset().
// Additionally, it possesses the ability to add messages that can be
// retrieved when the Stopwatch stops.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Logging;
using DotNetTips.Spargine.Core.Properties;
using Microsoft.ApplicationInsights;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// A thread-safe, high-precision stopwatch with enhanced diagnostics, lap support, telemetry, and logging capabilities.
/// </summary>
[DebuggerDisplay("Elapsed: {ElapsedMilliseconds}ms, Title: {Title}")]
[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", Status = Status.Available, Documentation = "https://bit.ly/SparginePerformanceStopwatch")]
public sealed class PerformanceStopwatch : Stopwatch
{
	/// <summary>
	/// A pool of <see cref="StringBuilder"/> objects to minimize memory allocations.
	/// </summary>
	private static readonly Lazy<ObjectPool<StringBuilder>> _stringBuilderPool =
		new(() => new DefaultObjectPoolProvider().CreateStringBuilderPool());

	/// <summary>
	/// A collection of diagnostic entries recorded during the stopwatch's operation.
	/// </summary>
	private readonly ConcurrentBag<DiagnosticEntry> _diagnostics = [];

	/// <summary>
	/// JSON serializer options for exporting stopwatch data.
	/// </summary>
	private readonly JsonSerializerOptions _jsonSerializerOptions = new()
	{
		WriteIndented = true,
	};

	/// <summary>
	/// A list of recorded lap times.
	/// </summary>
	private readonly ConcurrentBag<TimeSpan> _laps = [];

	/// <summary>
	/// The name of the operation being tracked.
	/// </summary>
	private string? _operationName;

	/// <summary>
	/// The telemetry client used for tracking events and metrics.
	/// </summary>
	private TelemetryClient? _telemetry;

	/// <summary>
	/// A custom message to include with telemetry events.
	/// </summary>
	private string? _telemetryMessage;

	/// <summary>
	/// Optional key/value properties to attach to telemetry events.
	/// </summary>
	private IDictionary<string, string>? _telemetryProperties;

	/// <summary>
	/// Initializes a new instance of the <see cref="PerformanceStopwatch"/> class with an empty _title.
	/// </summary>
	[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public PerformanceStopwatch() => this.Title = ControlChars.EmptyString;

	/// <summary>
	/// Initializes a new instance with a custom _title.
	/// </summary>
	/// <param name="title">The operation _title.</param>
	[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public PerformanceStopwatch([DisallowNull] string title) => this.Title = title;

	/// <summary>
	/// Occurs when the elapsed time exceeds the configured <see cref="AlertThreshold"/>.
	/// </summary>
	/// <remarks>
	/// This event is raised when the stopwatch's elapsed time surpasses the threshold value set via <see cref="AlertThreshold"/>.
	/// <para>
	/// <strong>When This Event Is Raised:</strong>
	/// <list type="bullet">
	/// <item><description>When <see cref="StopReset()"/> is called and <see cref="IsThresholdExceeded"/> is <c>true</c></description></item>
	/// <item><description>When <see cref="StopRestart()"/> is called and <see cref="IsThresholdExceeded"/> is <c>true</c></description></item>
	/// <item><description>When <see cref="StopIfThresholdExceeded"/> is called and the threshold is exceeded</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Event Data:</strong>
	/// The <see cref="ElapsedEventArgs"/> passed to subscribers contains the <see cref="ElapsedEventArgs.Elapsed"/> 
	/// time that exceeded the threshold, allowing handlers to inspect the actual duration.
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// Event handlers are invoked synchronously on the same thread that triggered the event.
	/// If multiple threads are stopping/resetting the stopwatch, subscribers should ensure their handlers are thread-safe.
	/// </para>
	/// <para>
	/// <strong>Best Practices:</strong>
	/// Use this event for performance monitoring and alerting scenarios where you need to be notified
	/// when operations exceed acceptable time limits. Common use cases include logging slow operations,
	/// triggering alerts, or collecting performance metrics.
	/// </para>
	/// </remarks>
	/// <example>
	/// Subscribing to and handling the threshold exceeded event:
	/// <code>
	/// // Create stopwatch with a 2-second threshold
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(2), 
	///     "DatabaseQuery"
	/// );
	/// 
	/// // Subscribe to the event
	/// stopwatch.ThresholdExceeded += (sender, e) =>
	/// {
	///     Console.WriteLine($"Warning: Operation exceeded threshold!");
	///     Console.WriteLine($"Elapsed time: {e.Elapsed.TotalSeconds:F2} seconds");
	///     
	///     // Log to monitoring system
	///     logger.LogWarning("Slow operation detected: {Elapsed}ms", e.Elapsed.TotalMilliseconds);
	/// };
	/// 
	/// // Perform operation
	/// await PerformLongRunningOperation();
	/// 
	/// // Stop and check threshold - event fires if exceeded
	/// var elapsed = stopwatch.StopReset();
	/// // If elapsed > 2 seconds, ThresholdExceeded event was raised
	/// 
	/// // Alternative: Stop only if threshold exceeded
	/// if (stopwatch.StopIfThresholdExceeded())
	/// {
	///     // Threshold was exceeded and event was raised
	///     Console.WriteLine("Operation stopped due to threshold violation");
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="AlertThreshold"/>
	/// <seealso cref="IsThresholdExceeded"/>
	/// <seealso cref="StopIfThresholdExceeded"/>
	/// <seealso cref="ElapsedEventArgs"/>
	/// <seealso cref="EventHandler{TEventArgs}"/>
	[Information(nameof(Reset), "David McCarter", "11/11/2025", Status = Status.New)]
	public event EventHandler<ElapsedEventArgs>? ResetCompleted;

	/// <summary>
	/// Occurs when the stopwatch is stopped.
	/// </summary>
	/// <remarks>
	/// This event is raised whenever the stopwatch transitions from running to stopped state.
	/// <para>
	/// <strong>When This Event Is Raised:</strong>
	/// <list type="bullet">
	/// <item><description>When <see cref="StopReset()"/> is called - raised before <see cref="ResetCompleted"/></description></item>
	/// <item><description>When <see cref="StopReset(ILogger, string)"/> is called - raised as part of the stop sequence</description></item>
	/// <item><description>When <see cref="StopRestart()"/> is called - raised before the restart occurs</description></item>
	/// <item><description>When <see cref="StopRestart(ILogger, string)"/> is called - raised before restart</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Event Data:</strong>
	/// The <see cref="ElapsedEventArgs"/> passed to subscribers contains the <see cref="ElapsedEventArgs.Elapsed"/> 
	/// time at the moment the stopwatch was stopped, providing accurate timing information to event handlers.
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// Event handlers are invoked synchronously on the same thread that stopped the stopwatch.
	/// If multiple threads are stopping the stopwatch, subscribers should ensure their handlers are thread-safe.
	/// </para>
	/// <para>
	/// <strong>Best Practices:</strong>
	/// Use this event for timing-related notifications, logging, or triggering cleanup operations
	/// that should occur whenever a measurement completes.
	/// </para>
	/// </remarks>
	/// <example>
	/// Subscribing to and handling the stopped event:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("APICall");
	/// 
	/// // Subscribe to stopped event
	/// stopwatch.StoppedCompleted += (sender, e) =>
	/// {
	///     Console.WriteLine($"Operation completed in {e.Elapsed.TotalMilliseconds:F2}ms");
	///     
	///     // Log performance metrics
	///     if (e.Elapsed.TotalSeconds > 1.0)
	///     {
	///         logger.LogWarning("Slow API call detected: {Duration}ms", e.Elapsed.TotalMilliseconds);
	///     }
	/// };
	/// 
	/// // Make API call
	/// await CallExternalApiAsync();
	/// 
	/// // Stop and reset - fires StoppedCompleted event
	/// var elapsed = stopwatch.StopReset();
	/// 
	/// // Or stop and restart - also fires StoppedCompleted
	/// var elapsed2 = stopwatch.StopRestart();
	/// </code>
	/// </example>
	/// <seealso cref="StopReset()"/>
	/// <seealso cref="StopRestart()"/>
	/// <seealso cref="ResetCompleted"/>
	/// <seealso cref="ElapsedEventArgs"/>
	/// <seealso cref="EventHandler{TEventArgs}"/>
	[Information(nameof(StoppedCompleted), "David McCarter", "11/11/2025", Status = Status.New)]
	public event EventHandler<ElapsedEventArgs>? StoppedCompleted;

	/// <summary>
	/// Occurs when the elapsed time exceeds the configured <see cref="AlertThreshold"/>.
	/// </summary>
	/// <remarks>
	/// This event is raised when the stopwatch's elapsed time surpasses the threshold value set via <see cref="AlertThreshold"/>.
	/// <para>
	/// <strong>When This Event Is Raised:</strong>
	/// <list type="bullet">
	/// <item><description>When <see cref="StopReset()"/> is called and <see cref="IsThresholdExceeded"/> is <c>true</c></description></item>
	/// <item><description>When <see cref="StopRestart()"/> is called and <see cref="IsThresholdExceeded"/> is <c>true</c></description></item>
	/// <item><description>When <see cref="StopIfThresholdExceeded"/> is called and the threshold is exceeded</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Event Data:</strong>
	/// The <see cref="ElapsedEventArgs"/> passed to subscribers contains the <see cref="ElapsedEventArgs.Elapsed"/> 
	/// time that exceeded the threshold, allowing handlers to inspect the actual duration.
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// Event handlers are invoked synchronously on the same thread that triggered the event.
	/// If multiple threads are stopping/resetting the stopwatch, subscribers should ensure their handlers are thread-safe.
	/// </para>
	/// <para>
	/// <strong>Best Practices:</strong>
	/// Use this event for performance monitoring and alerting scenarios where you need to be notified
	/// when operations exceed acceptable time limits. Common use cases include logging slow operations,
	/// triggering alerts, or collecting performance metrics.
	/// </para>
	/// </remarks>
	/// <example>
	/// Subscribing to and handling the threshold exceeded event:
	/// <code>
	/// // Create stopwatch with a 2-second threshold
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(2), 
	///     "DatabaseQuery"
	/// );
	/// 
	/// // Subscribe to the event
	/// stopwatch.ThresholdExceeded += (sender, e) =>
	/// {
	///     Console.WriteLine($"Warning: Operation exceeded threshold!");
	///     Console.WriteLine($"Elapsed time: {e.Elapsed.TotalSeconds:F2} seconds");
	///     
	///     // Log to monitoring system
	///     logger.LogWarning("Slow operation detected: {Elapsed}ms", e.Elapsed.TotalMilliseconds);
	/// };
	/// 
	/// // Perform operation
	/// await PerformLongRunningOperation();
	/// 
	/// // Stop and check threshold - event fires if exceeded
	/// var elapsed = stopwatch.StopReset();
	/// // If elapsed > 2 seconds, ThresholdExceeded event was raised
	/// 
	/// // Alternative: Stop only if threshold exceeded
	/// if (stopwatch.StopIfThresholdExceeded())
	/// {
	///     // Threshold was exceeded and event was raised
	///     Console.WriteLine("Operation stopped due to threshold violation");
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="AlertThreshold"/>
	/// <seealso cref="IsThresholdExceeded"/>
	/// <seealso cref="StopIfThresholdExceeded"/>
	/// <seealso cref="ElapsedEventArgs"/>
	/// <seealso cref="EventHandler{TEventArgs}"/>
	[Information(nameof(ThresholdExceeded), "David McCarter", "11/11/2025", Status = Status.New)]
	public event EventHandler<ElapsedEventArgs>? ThresholdExceeded;

	/// <summary>
	/// Creates a structured diagnostic entry.
	/// </summary>
	/// <param name="message">The message to record.</param>
	/// <param name="result">The elapsed time.</param>
	/// <returns>A new <see cref="DiagnosticEntry"/>.</returns>
	private DiagnosticEntry CreateEntry(string message, TimeSpan result)
	{
		var entry = new DiagnosticEntry(DateTimeOffset.UtcNow, $"{this.Title} {message}", result);

		this._diagnostics.Add(entry);

		return entry;
	}

	/// <summary>
	/// Adds a diagnostic entry with the specified message and the current elapsed time.
	/// </summary>
	/// <param name="message">The message to include in the diagnostic entry. Cannot be null or empty.</param>
	/// <exception cref="ArgumentNullException">Thrown when the <paramref name="message"/> is null or empty.</exception>
	[Information(nameof(AddDiagnosticEntry), "David McCarter", "5/9/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public void AddDiagnosticEntry([DisallowNull] string message)
	{
		message = message.ArgumentNotNullOrEmpty();

		var entry = new DiagnosticEntry(DateTimeOffset.UtcNow, $"{this.Title} {message}", this.Elapsed);
		this._diagnostics.Add(entry);
	}

	/// <summary>
	/// Clears all recorded diagnostic entries.
	/// </summary>
	/// <remarks>
	/// This method resets the internal diagnostics collection to an empty state.
	/// </remarks>
	[Information(nameof(ClearDiagnostics), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public void ClearDiagnostics() => this._diagnostics.Clear();

	/// <summary>
	/// Clears all recorded lap times from the stopwatch.
	/// </summary>
	/// <remarks>
	/// This method removes all lap time entries that were previously recorded via <see cref="RecordLap"/>.
	/// After calling this method, the <see cref="GetLaps"/> method will return an empty collection.
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Resetting lap data while keeping the stopwatch running</description></item>
	/// <item><description>Preparing the stopwatch for a new round of lap timing without creating a new instance</description></item>
	/// <item><description>Managing memory by clearing accumulated lap data in long-running scenarios</description></item>
	/// <item><description>Starting fresh lap tracking for a new phase of an operation</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe as it operates on a <see cref="ConcurrentBag{T}"/>.
	/// However, clearing laps while other threads are recording or reading laps may lead to 
	/// race conditions where some threads see laps that others don't.
	/// </para>
	/// <para>
	/// <strong>Important Notes:</strong>
	/// <list type="bullet">
	/// <item><description>This method does NOT affect the stopwatch's running state or elapsed time</description></item>
	/// <item><description>Diagnostic entries are NOT affected and remain intact</description></item>
	/// <item><description>The stopwatch can continue running or remain stopped</description></item>
	/// <item><description>New laps can be recorded immediately after clearing</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Clearing laps during stopwatch operation:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("MultiPhaseOperation");
	/// 
	/// // Phase 1: Record some laps
	/// ProcessTask1();
	/// stopwatch.RecordLap();
	/// ProcessTask2();
	/// stopwatch.RecordLap();
	/// 
	/// Console.WriteLine($"Phase 1 laps: {stopwatch.GetLaps().Count}"); // 2
	/// 
	/// // Clear laps before starting Phase 2
	/// stopwatch.ClearLaps();
	/// Console.WriteLine($"After clear: {stopwatch.GetLaps().Count}"); // 0
	/// 
	/// // Phase 2: Record new laps
	/// ProcessTask3();
	/// stopwatch.RecordLap();
	/// ProcessTask4();
	/// stopwatch.RecordLap();
	/// 
	/// Console.WriteLine($"Phase 2 laps: {stopwatch.GetLaps().Count}"); // 2
	/// 
	/// // Note: Stopwatch continues running throughout
	/// stopwatch.Stop();
	/// Console.WriteLine($"Total elapsed: {stopwatch.Elapsed}"); // Entire duration
	/// </code>
	/// </example>
	/// <seealso cref="RecordLap"/>
	/// <seealso cref="GetLaps"/>
	/// <seealso cref="ClearDiagnostics"/>
	[Information(nameof(ClearLaps), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public void ClearLaps() => this._laps.Clear();

	/// <summary>
	/// Exports the complete stopwatch state to a JSON string, including title, elapsed time, lap times, and diagnostic entries.
	/// </summary>
	/// <returns>
	/// A formatted JSON string containing the stopwatch's title, elapsed time in milliseconds, all recorded laps, 
	/// and diagnostic entries with their timestamps and messages.
	/// </returns>
	/// <remarks>
	/// This method serializes the current state of the stopwatch into a structured JSON format suitable for 
	/// logging, debugging, or integration with external monitoring systems. The JSON is formatted with indentation 
	/// for improved readability.
	/// <para>
	/// <strong>JSON Structure:</strong>
	/// The returned JSON contains the following properties:
	/// <list type="bullet">
	/// <item><description><c>Title</c> - The stopwatch's title/name</description></item>
	/// <item><description><c>ElapsedTimeMs</c> - Total elapsed time in milliseconds as a decimal value</description></item>
	/// <item><description><c>Laps</c> - Array of lap times (each lap as a TimeSpan object)</description></item>
	/// <item><description><c>Diagnostics</c> - Array of diagnostic entries with Timestamp, Message, and ElapsedMs properties</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Serialization Details:</strong>
	/// <list type="bullet">
	/// <item><description>Uses <see cref="JsonSerializer"/> with indented formatting (<see cref="JsonSerializerOptions.WriteIndented"/> = true)</description></item>
	/// <item><description>Lap times are ordered by <see cref="TimeSpan.TotalNanoseconds"/> before serialization</description></item>
	/// <item><description>Diagnostic entries are ordered by <see cref="DiagnosticEntry.Timestamp"/></description></item>
	/// <item><description>All elapsed times are converted to milliseconds for consistency</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Calling this method captures a snapshot of the current state; the stopwatch continues running if not stopped</description></item>
	/// <item><description>Large numbers of laps or diagnostic entries may result in substantial JSON output</description></item>
	/// <item><description>The method creates temporary arrays via <see cref="GetLaps"/> and <see cref="Diagnostics"/> properties</description></item>
	/// <item><description>Marked with <see cref="MethodImplOptions.AggressiveInlining"/> for optimal performance</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe for reading the current state. However, if laps or diagnostics are being 
	/// added concurrently by other threads, the snapshot may not reflect all entries depending on timing.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Exporting performance metrics to logging systems (e.g., Application Insights, ELK stack)</description></item>
	/// <item><description>Saving benchmark results to files for later analysis</description></item>
	/// <item><description>Integrating with monitoring dashboards and alerting systems</description></item>
	/// <item><description>Debugging performance issues with detailed timing breakdowns</description></item>
	/// <item><description>Creating performance reports for code reviews or documentation</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Exporting stopwatch data to JSON:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DatabaseOperations");
	/// 
	/// // Perform operations with laps
	/// await ExecuteQuery1();
	/// stopwatch.RecordLap();
	/// 
	/// await ExecuteQuery2();
	/// stopwatch.RecordLap();
	/// 
	/// // Add diagnostic entries
	/// stopwatch.AddDiagnosticEntry("Query 1 completed");
	/// stopwatch.AddDiagnosticEntry("Query 2 completed");
	/// 
	/// stopwatch.Stop();
	/// 
	/// // Export to JSON
	/// string json = stopwatch.ExportToJson();
	/// Console.WriteLine(json);
	/// 
	/// /* Output (formatted):
	/// {
	///   "Title": "DatabaseOperations:",
	///   "ElapsedTimeMs": 1523.4567,
	///   "Laps": [
	///     "00:00:00.7500000",
	///     "00:00:00.7734567"
	///   ],
	///   "Diagnostics": [
	///     {
	///       "Timestamp": "2025-12-17T10:30:45.1234567Z",
	///       "Message": "DatabaseOperations: Query 1 completed",
	///       "ElapsedMs": 750.0
	///     },
	///     {
	///       "Timestamp": "2025-12-17T10:30:45.8969134Z",
	///       "Message": "DatabaseOperations: Query 2 completed",
	///       "ElapsedMs": 1523.4567
	///     }
	///   ]
	/// }
	/// */
	/// </code>
	/// 
	/// Saving JSON to a file for later analysis:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("APIBenchmark");
	/// 
	/// for (int i = 0; i &lt; 10; i++)
	/// {
	///     await CallApiEndpoint();
	///     stopwatch.RecordLap();
	/// }
	/// 
	/// stopwatch.Stop();
	/// 
	/// // Export and save
	/// string json = stopwatch.ExportToJson();
	/// await File.WriteAllTextAsync("benchmark-results.json", json);
	/// 
	/// // Later, can deserialize and analyze
	/// string savedJson = await File.ReadAllTextAsync("benchmark-results.json");
	/// // Analyze results...
	/// </code>
	/// 
	/// Integrating with logging systems:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("BatchProcessing");
	/// 
	/// try
	/// {
	///     await ProcessBatch();
	///     stopwatch.AddDiagnosticEntry("Batch processing completed");
	/// }
	/// catch (Exception ex)
	/// {
	///     stopwatch.AddDiagnosticEntry($"Error: {ex.Message}");
	/// }
	/// finally
	/// {
	///     stopwatch.Stop();
	///     
	///     // Log the complete performance data
	///     string json = stopwatch.ExportToJson();
	///     logger.LogInformation("Performance data: {PerformanceJson}", json);
	///     
	///     // Or send to monitoring service
	///     await telemetryService.TrackPerformanceAsync(json);
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="GetSummaryReport"/>
	/// <seealso cref="GetLaps"/>
	/// <seealso cref="Diagnostics"/>
	/// <seealso cref="JsonSerializer"/>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ExportToJson), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public string ExportToJson()
	{
		return JsonSerializer.Serialize(
					new
					{
						this.Title,
						ElapsedTimeMs = this.Elapsed.TotalMilliseconds,
						Laps = this.GetLaps().ToArray(),
						Diagnostics = this.Diagnostics.Select(
							d => new
							{
								d.Timestamp,
								d.Message,
								ElapsedMs = d.Elapsed.TotalMilliseconds,
							})
							.ToArray()
					}, this._jsonSerializerOptions);
	}

	/// <summary>
	/// Retrieves all diagnostic messages recorded during the stopwatch's operation as formatted strings.
	/// </summary>
	/// <returns>
	/// A read-only collection of diagnostic messages as strings, where each message includes the timestamp, 
	/// message text, and elapsed time at the point the diagnostic entry was recorded.
	/// </returns>
	/// <remarks>
	/// This method converts all <see cref="DiagnosticEntry"/> objects stored in the <see cref="Diagnostics"/> 
	/// collection into their string representations by calling <see cref="DiagnosticEntry.ToString"/>.
	/// <para>
	/// <strong>String Format:</strong>
	/// Each diagnostic message string contains:
	/// <list type="bullet">
	/// <item><description>Timestamp - When the diagnostic entry was recorded (UTC)</description></item>
	/// <item><description>Message - The diagnostic message text (prefixed with the stopwatch's <see cref="Title"/>)</description></item>
	/// <item><description>Elapsed Time - The elapsed time in milliseconds when the entry was recorded</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Ordering:</strong>
	/// Messages are automatically ordered by timestamp (chronologically) as the underlying <see cref="Diagnostics"/> 
	/// property returns entries sorted by <see cref="DiagnosticEntry.Timestamp"/>.
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>This method creates a new collection on each call by materializing the LINQ query</description></item>
	/// <item><description>Each diagnostic entry's <see cref="DiagnosticEntry.ToString"/> method is invoked during enumeration</description></item>
	/// <item><description>The returned collection is immutable; changes to the underlying diagnostics won't affect it</description></item>
	/// <item><description>Marked with <see cref="MethodImplOptions.AggressiveInlining"/> for optimal performance</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe for reading the current diagnostic messages. However, if diagnostic entries 
	/// are being added concurrently by other threads via <see cref="AddDiagnosticEntry"/>, the returned collection 
	/// may not include all entries depending on timing.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Displaying diagnostic information in logs or console output</description></item>
	/// <item><description>Creating simple text-based performance reports</description></item>
	/// <item><description>Debugging timing issues without needing to parse structured data</description></item>
	/// <item><description>Quick inspection of operation checkpoints during development</description></item>
	/// <item><description>Generating human-readable audit trails for operations</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="GetDiagnosticMessages"/> - Returns formatted string messages (this method)</description></item>
	/// <item><description><see cref="Diagnostics"/> - Returns structured <see cref="DiagnosticEntry"/> objects with full details</description></item>
	/// <item><description><see cref="GetSummaryReport"/> - Returns complete report including laps and diagnostics</description></item>
	/// <item><description><see cref="ExportToJson"/> - Returns JSON with all stopwatch data including diagnostics</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Retrieving and displaying diagnostic messages:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DataProcessing");
	/// 
	/// // Perform operations with diagnostic tracking
	/// await LoadData();
	/// stopwatch.AddDiagnosticEntry("Data loaded from database");
	/// 
	/// await TransformData();
	/// stopwatch.AddDiagnosticEntry("Data transformation completed");
	/// 
	/// await SaveData();
	/// stopwatch.AddDiagnosticEntry("Data saved to storage");
	/// 
	/// stopwatch.Stop();
	/// 
	/// // Get all diagnostic messages
	/// var messages = stopwatch.GetDiagnosticMessages();
	/// 
	/// Console.WriteLine($"Total diagnostic entries: {messages.Count}");
	/// foreach (var message in messages)
	/// {
	///     Console.WriteLine(message);
	/// }
	/// 
	/// /* Output:
	/// Total diagnostic entries: 3
	/// 2025-12-17T10:30:45.1234567Z: DataProcessing: Data loaded from database - 523.45 ms
	/// 2025-12-17T10:30:46.7890123Z: DataProcessing: Data transformation completed - 2189.12 ms
	/// 2025-12-17T10:30:47.5678901Z: DataProcessing: Data saved to storage - 2967.34 ms
	/// */
	/// </code>
	/// 
	/// Logging diagnostic messages:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("APIRequest");
	/// 
	/// try
	/// {
	///     stopwatch.AddDiagnosticEntry("Request validation started");
	///     await ValidateRequest();
	///     
	///     stopwatch.AddDiagnosticEntry("Processing business logic");
	///     await ProcessBusinessLogic();
	///     
	///     stopwatch.AddDiagnosticEntry("Generating response");
	///     var response = await GenerateResponse();
	///     
	///     stopwatch.Stop();
	///     
	///     // Log all diagnostic messages for audit trail
	///     var messages = stopwatch.GetDiagnosticMessages();
	///     foreach (var message in messages)
	///     {
	///         logger.LogDebug(message);
	///     }
	/// }
	/// catch (Exception ex)
	/// {
	///     stopwatch.AddDiagnosticEntry($"Error occurred: {ex.Message}");
	///     
	///     var messages = stopwatch.GetDiagnosticMessages();
	///     logger.LogError("Operation failed with diagnostics: {Messages}", string.Join("; ", messages));
	/// }
	/// </code>
	/// 
	/// Comparing with structured diagnostic entries:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("BatchJob");
	/// 
	/// for (int i = 0; i &lt; 5; i++)
	/// {
	///     await ProcessBatchItem(i);
	///     stopwatch.AddDiagnosticEntry($"Batch item {i} processed");
	/// }
	/// 
	/// stopwatch.Stop();
	/// 
	/// // Option 1: Get simple string messages
	/// var messages = stopwatch.GetDiagnosticMessages();
	/// Console.WriteLine("Simple messages:");
	/// messages.ForEach(Console.WriteLine);
	/// 
	/// // Option 2: Get structured diagnostic entries for detailed analysis
	/// var diagnostics = stopwatch.Diagnostics;
	/// Console.WriteLine("\nDetailed diagnostics:");
	/// foreach (var entry in diagnostics)
	/// {
	///     Console.WriteLine($"Timestamp: {entry.Timestamp:O}");
	///     Console.WriteLine($"Message: {entry.Message}");
	///     Console.WriteLine($"Elapsed: {entry.Elapsed.TotalMilliseconds:F2}ms");
	///     Console.WriteLine();
	/// }
	/// </code>
	/// 
	/// Creating a simple performance report:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("ReportGeneration");
	/// 
	/// stopwatch.AddDiagnosticEntry("Started data collection");
	/// var data = await CollectData();
	/// 
	/// stopwatch.AddDiagnosticEntry("Started calculations");
	/// var results = await PerformCalculations(data);
	/// 
	/// stopwatch.AddDiagnosticEntry("Started report formatting");
	/// var report = await FormatReport(results);
	/// 
	/// stopwatch.Stop();
	/// 
	/// // Create simple text report
	/// var reportBuilder = new StringBuilder();
	/// reportBuilder.AppendLine("Performance Report");
	/// reportBuilder.AppendLine($"Total Time: {stopwatch.Elapsed.TotalSeconds:F2}s");
	/// reportBuilder.AppendLine("\nCheckpoints:");
	/// 
	/// var messages = stopwatch.GetDiagnosticMessages();
	/// foreach (var message in messages)
	/// {
	///     reportBuilder.AppendLine($"  - {message}");
	/// }
	/// 
	/// await File.WriteAllTextAsync("performance-report.txt", reportBuilder.ToString());
	/// </code>
	/// </example>
	/// <seealso cref="Diagnostics"/>
	/// <seealso cref="AddDiagnosticEntry"/>
	/// <seealso cref="DiagnosticEntry"/>
	/// <seealso cref="GetSummaryReport"/>
	/// <seealso cref="ExportToJson"/>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetDiagnosticMessages), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public ReadOnlyCollection<string> GetDiagnosticMessages()
	{
		return this.Diagnostics.Select(d => d.ToString()).ToList().AsReadOnly();
	}

	/// <summary>
	/// Gets the current elapsed time formatted as a human-readable string with milliseconds precision.
	/// </summary>
	/// <returns>
	/// A formatted string in the format "Elapsed Time: X.XX ms" where X.XX represents the elapsed time 
	/// in milliseconds formatted using the <see cref="TimeSpan.TotalMilliseconds"/> value.
	/// </returns>
	/// <remarks>
	/// This method provides a convenient way to display the current elapsed time in a consistent, 
	/// human-readable format suitable for logging, console output, and diagnostic reports.
	/// <para>
	/// <strong>Formatting Details:</strong>
	/// <list type="bullet">
	/// <item><description>Uses the <c>FormatTime()</c> extension method for consistent time formatting across the application</description></item>
	/// <item><description>Always includes the "Elapsed Time: " prefix for clarity in output</description></item>
	/// <item><description>Time is expressed in milliseconds as a decimal value</description></item>
	/// <item><description>The stopwatch does NOT need to be stopped to call this method - it returns the current elapsed time</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>This is a lightweight operation that creates a single string</description></item>
	/// <item><description>Marked with <see cref="MethodImplOptions.AggressiveInlining"/> for optimal performance</description></item>
	/// <item><description>Can be called repeatedly without performance concerns</description></item>
	/// <item><description>Returns a snapshot of the current elapsed time; the stopwatch continues running if not stopped</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe and can be called from multiple threads concurrently. Each call 
	/// returns an independent string representing the elapsed time at the moment of the call.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Quick console output of elapsed time during development and debugging</description></item>
	/// <item><description>Simple logging of operation duration</description></item>
	/// <item><description>Building performance reports using the <see cref="GetSummaryReport"/> method</description></item>
	/// <item><description>Displaying timing information in user interfaces</description></item>
	/// <item><description>Creating human-readable diagnostic messages</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="GetElapsedTimeString"/> - Returns simple formatted elapsed time (this method)</description></item>
	/// <item><description><see cref="GetSummaryReport"/> - Returns complete report including laps and diagnostics</description></item>
	/// <item><description><see cref="ExportToJson"/> - Returns structured JSON data</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic usage for console output:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DataProcessing");
	/// 
	/// await ProcessData();
	/// 
	/// // Get elapsed time while running
	/// Console.WriteLine(stopwatch.GetElapsedTimeString());
	/// // Output: Elapsed Time: 1234.56 ms
	/// 
	/// await ProcessMoreData();
	/// 
	/// stopwatch.Stop();
	/// Console.WriteLine(stopwatch.GetElapsedTimeString());
	/// // Output: Elapsed Time: 2456.78 ms
	/// </code>
	/// 
	/// Using in logging scenarios:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("APICall");
	/// 
	/// try
	/// {
	///     var response = await CallExternalApi();
	///     
	///     stopwatch.Stop();
	///     logger.LogInformation(stopwatch.GetElapsedTimeString());
	///     // Logs: "Elapsed Time: 523.45 ms"
	///     
	///     return response;
	/// }
	/// catch (Exception ex)
	/// {
	///     logger.LogError("API call failed. {ElapsedTime}", stopwatch.GetElapsedTimeString());
	///     throw;
	/// }
	/// </code>
	/// 
	/// Periodic progress reporting:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("BatchProcessing");
	/// 
	/// for (int i = 0; i &lt; items.Count; i++)
	/// {
	///     await ProcessItem(items[i]);
	///     
	///     // Report progress every 100 items
	///     if ((i + 1) % 100 == 0)
	///     {
	///         Console.WriteLine($"Processed {i + 1} items. {stopwatch.GetElapsedTimeString()}");
	///         // Output: Processed 100 items. Elapsed Time: 5234.12 ms
	///     }
	/// }
	/// 
	/// stopwatch.Stop();
	/// Console.WriteLine($"Batch complete. {stopwatch.GetElapsedTimeString()}");
	/// </code>
	/// 
	/// Building custom reports:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("ReportGeneration");
	/// 
	/// var data = await CollectData();
	/// stopwatch.RecordLap();
	/// 
	/// var processed = await ProcessData(data);
	/// stopwatch.RecordLap();
	/// 
	/// var report = await FormatReport(processed);
	/// stopwatch.Stop();
	/// 
	/// var summary = new StringBuilder();
	/// summary.AppendLine("Performance Summary");
	/// summary.AppendLine("===================");
	/// summary.AppendLine(stopwatch.GetElapsedTimeString());
	/// summary.AppendLine($"Total Laps: {stopwatch.GetLaps().Count}");
	/// 
	/// Console.WriteLine(summary.ToString());
	/// /* Output:
	/// Performance Summary
	/// ===================
	/// Elapsed Time: 3456.78 ms
	/// Total Laps: 2
	/// */
	/// </code>
	/// 
	/// Comparing multiple operations:
	/// <code>
	/// var stopwatch1 = PerformanceStopwatch.StartNew("Operation1");
	/// await PerformOperation1();
	/// stopwatch1.Stop();
	/// 
	/// var stopwatch2 = PerformanceStopwatch.StartNew("Operation2");
	/// await PerformOperation2();
	/// stopwatch2.Stop();
	/// 
	/// Console.WriteLine($"Operation 1: {stopwatch1.GetElapsedTimeString()}");
	/// Console.WriteLine($"Operation 2: {stopwatch2.GetElapsedTimeString()}");
	/// 
	/// if (stopwatch1.Elapsed > stopwatch2.Elapsed)
	/// {
	///     Console.WriteLine("Operation 2 was faster");
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="GetSummaryReport"/>
	/// <seealso cref="ToString"/>
	/// <seealso cref="TimeSpan.TotalMilliseconds"/>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetElapsedTimeString), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public string GetElapsedTimeString()
	{
		return $"Elapsed Time: {this.Elapsed.TotalMilliseconds.FormatTime()}";
	}

	/// <summary>
	/// Retrieves all recorded lap times as a read-only collection, sorted chronologically by duration.
	/// </summary>
	/// <returns>
	/// A read-only collection of <see cref="TimeSpan"/> objects representing each lap's elapsed time, 
	/// ordered from shortest to longest duration based on <see cref="TimeSpan.TotalNanoseconds"/>.
	/// </returns>
	/// <remarks>
	/// This method returns all lap times that were previously recorded using <see cref="RecordLap"/>.
	/// <para>
	/// <strong>Ordering:</strong>
	/// Lap times are automatically sorted by duration (shortest to longest) using <see cref="TimeSpan.TotalNanoseconds"/> 
	/// for high-precision ordering. This ordering is independent of the sequence in which laps were recorded.
	/// </para>
	/// <para>
	/// <strong>Collection Characteristics:</strong>
	/// <list type="bullet">
	/// <item><description>Returns a <see cref="ReadOnlyCollection{T}"/> - the collection is immutable</description></item>
	/// <item><description>Each call creates a new sorted array and wraps it in a read-only collection</description></item>
	/// <item><description>The returned collection is a snapshot; subsequent lap recordings won't affect it</description></item>
	/// <item><description>If no laps have been recorded, returns an empty collection (Count = 0)</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>This method performs sorting on each call - consider caching the result if called frequently</description></item>
	/// <item><description>Sorting uses LINQ's <see cref="Enumerable.OrderBy{TSource, TKey}(IEnumerable{TSource}, Func{TSource, TKey})"/> which is O(n log n)</description></item>
	/// <item><description>Creates a temporary array via <see cref="Enumerable.ToArray{TSource}(IEnumerable{TSource})"/></description></item>
	/// <item><description>Marked with <see cref="MethodImplOptions.AggressiveInlining"/> for optimal performance</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe for reading lap times. The underlying storage uses <see cref="ConcurrentBag{T}"/>.
	/// However, if laps are being recorded concurrently by other threads, the returned collection represents 
	/// a snapshot at the time of the call and may not include laps added immediately after.
	/// </para>
	/// <para>
	/// <strong>Lap Time Interpretation:</strong>
	/// Each <see cref="TimeSpan"/> in the collection represents the cumulative elapsed time from when the 
	/// stopwatch was started (or last reset) up to when that specific lap was recorded. To calculate the 
	/// duration between consecutive laps, subtract the previous lap time from the current lap time.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Analyzing performance of multiple iterations or steps in an operation</description></item>
	/// <item><description>Identifying the fastest/slowest checkpoints in a workflow</description></item>
	/// <item><description>Building performance reports with lap-by-lap breakdowns</description></item>
	/// <item><description>Comparing timing across different phases of execution</description></item>
	/// <item><description>Exporting timing data for visualization or further analysis</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="GetLaps"/> - Returns sorted lap times as <see cref="TimeSpan"/> collection (this method)</description></item>
	/// <item><description><see cref="RecordLap"/> - Records a new lap at the current elapsed time</description></item>
	/// <item><description><see cref="ClearLaps"/> - Removes all recorded laps</description></item>
	/// <item><description><see cref="ExportToJson"/> - Exports laps as part of complete JSON data</description></item>
	/// <item><description><see cref="GetSummaryReport"/> - Includes laps in formatted text report</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic lap timing and retrieval:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("IterativeProcessing");
	/// 
	/// for (int i = 0; i &lt; 5; i++)
	/// {
	///     await ProcessIteration(i);
	///     stopwatch.RecordLap();
	/// }
	/// 
	/// stopwatch.Stop();
	/// 
	/// var laps = stopwatch.GetLaps();
	/// Console.WriteLine($"Total laps recorded: {laps.Count}");
	/// 
	/// for (int i = 0; i &lt; laps.Count; i++)
	/// {
	///     Console.WriteLine($"Lap {i}: {laps[i].TotalMilliseconds:F2}ms");
	/// }
	/// 
	/// /* Output (sorted by duration):
	/// Total laps recorded: 5
	/// Lap 0: 234.56ms
	/// Lap 1: 456.78ms
	/// Lap 2: 567.89ms
	/// Lap 3: 678.90ms
	/// Lap 4: 789.01ms
	/// */
	/// </code>
	/// 
	/// Calculating time between laps:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DatabaseQueries");
	/// 
	/// await ExecuteQuery1();
	/// stopwatch.RecordLap();
	/// 
	/// await ExecuteQuery2();
	/// stopwatch.RecordLap();
	/// 
	/// await ExecuteQuery3();
	/// stopwatch.RecordLap();
	/// 
	/// stopwatch.Stop();
	/// 
	/// var laps = stopwatch.GetLaps();
	/// 
	/// Console.WriteLine($"Query 1 duration: {laps[0].TotalMilliseconds:F2}ms");
	/// 
	/// for (int i = 1; i &lt; laps.Count; i++)
	/// {
	///     var duration = laps[i] - laps[i - 1];
	///     Console.WriteLine($"Query {i + 1} duration: {duration.TotalMilliseconds:F2}ms");
	/// }
	/// 
	/// /* Output:
	/// Query 1 duration: 523.45ms
	/// Query 2 duration: 312.67ms  // lap[1] - lap[0]
	/// Query 3 duration: 445.23ms  // lap[2] - lap[1]
	/// */
	/// </code>
	/// 
	/// Finding fastest and slowest laps:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("APIRequests");
	/// 
	/// foreach (var endpoint in endpoints)
	/// {
	///     await CallEndpoint(endpoint);
	///     stopwatch.RecordLap();
	/// }
	/// 
	/// stopwatch.Stop();
	/// 
	/// var laps = stopwatch.GetLaps();
	/// 
	/// if (laps.Count > 0)
	/// {
	///     // Calculate individual lap durations
	///     var lapDurations = new List&lt;TimeSpan&gt; { laps[0] };
	///     for (int i = 1; i &lt; laps.Count; i++)
	///     {
	///         lapDurations.Add(laps[i] - laps[i - 1]);
	///     }
	///     
	///     var fastest = lapDurations.Min();
	///     var slowest = lapDurations.Max();
	///     var average = TimeSpan.FromMilliseconds(lapDurations.Average(d => d.TotalMilliseconds));
	///     
	///     Console.WriteLine($"Fastest lap: {fastest.TotalMilliseconds:F2}ms");
	///     Console.WriteLine($"Slowest lap: {slowest.TotalMilliseconds:F2}ms");
	///     Console.WriteLine($"Average lap: {average.TotalMilliseconds:F2}ms");
	/// }
	/// </code>
	/// 
	/// Exporting lap data for analysis:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("BatchProcessing");
	/// 
	/// foreach (var batch in batches)
	/// {
	///     await ProcessBatch(batch);
	///     stopwatch.RecordLap();
	/// }
	/// 
	/// stopwatch.Stop();
	/// 
	/// var laps = stopwatch.GetLaps();
	/// var report = new StringBuilder();
	/// 
	/// report.AppendLine("Lap Timing Report");
	/// report.AppendLine("=================");
	/// report.AppendLine($"Total batches: {laps.Count}");
	/// report.AppendLine($"Total time: {stopwatch.Elapsed.TotalSeconds:F2}s");
	/// report.AppendLine();
	/// report.AppendLine("Lap Details:");
	/// 
	/// for (int i = 0; i &lt; laps.Count; i++)
	/// {
	///     var duration = i == 0 ? laps[0] : laps[i] - laps[i - 1];
	///     report.AppendLine($"  Batch {i + 1}: {duration.TotalMilliseconds:F2}ms (cumulative: {laps[i].TotalMilliseconds:F2}ms)");
	/// }
	/// 
	/// await File.WriteAllTextAsync("lap-report.txt", report.ToString());
	/// </code>
	/// 
	/// Comparing laps across multiple runs:
	/// <code>
	/// var run1Laps = new List&lt;TimeSpan&gt;();
	/// var run2Laps = new List&lt;TimeSpan&gt;();
	/// 
	/// // First run
	/// var stopwatch1 = PerformanceStopwatch.StartNew("Run1");
	/// for (int i = 0; i &lt; 10; i++)
	/// {
	///     await PerformTask(i);
	///     stopwatch1.RecordLap();
	/// }
	/// stopwatch1.Stop();
	/// run1Laps.AddRange(stopwatch1.GetLaps());
	/// 
	/// // Second run
	/// var stopwatch2 = PerformanceStopwatch.StartNew("Run2");
	/// for (int i = 0; i &lt; 10; i++)
	/// {
	///     await PerformTask(i);
	///     stopwatch2.RecordLap();
	/// }
	/// stopwatch2.Stop();
	/// run2Laps.AddRange(stopwatch2.GetLaps());
	/// 
	/// // Compare
	/// Console.WriteLine($"Run 1 average: {run1Laps.Average(l => l.TotalMilliseconds):F2}ms");
	/// Console.WriteLine($"Run 2 average: {run2Laps.Average(l => l.TotalMilliseconds):F2}ms");
	/// </code>
	/// </example>
	/// <seealso cref="RecordLap"/>
	/// <seealso cref="ClearLaps"/>
	/// <seealso cref="TimeSpan"/>
	/// <seealso cref="ReadOnlyCollection{T}"/>
	/// <seealso cref="ExportToJson"/>
	/// <seealso cref="GetSummaryReport"/>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetLaps), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public ReadOnlyCollection<TimeSpan> GetLaps()
	{
		return this._laps.OrderBy(p => p.TotalNanoseconds).ToArray().AsReadOnly();
	}

	/// <summary>
	/// Returns a detailed summary report including laps and diagnostics.
	/// </summary>
	/// <returns>A human-readable summary string.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetSummaryReport), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string GetSummaryReport()
	{
		// Pre-calculate collections to avoid multiple property calls
		var laps = this.GetLaps();
		var diagnosticEntries = this.Diagnostics;

		// Estimate capacity to reduce reallocations (title + elapsed line + laps + diagnostics + some extra)
		var estimatedCapacity = 64 + (laps.Count * 32) + (diagnosticEntries.Count * 80);

		var sb = _stringBuilderPool.Value.Get();
		_ = sb.EnsureCapacity(estimatedCapacity);

		try
		{
			_ = sb.AppendLine($"Performance Report - {this.Title}").AppendLine(this.GetElapsedTimeString());

			var lapCount = 0;

			foreach (var lap in laps)
			{
				_ = sb.AppendLine($"Lap {lapCount++}: {lap.TotalMilliseconds.FormatTime()}");
			}

			foreach (var entry in diagnosticEntries)
			{
				_ = sb.AppendFormat(CultureInfo.InvariantCulture,
					"{0:u}: {1} - {2}\n",
					entry.Timestamp,
					entry.Message,
					entry.Elapsed.TotalMilliseconds.FormatTime());
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Value.Return(sb.Clear());
		}
	}

	/// <summary>
	/// Logs a custom message along with the current elapsed time and stopwatch metadata using structured logging.
	/// </summary>
	/// <param name="logger">The <see cref="ILogger"/> instance used for logging. Cannot be null.</param>
	/// <param name="message">The custom message to log. Cannot be null or empty.</param>
	/// <remarks>
	/// This method provides structured logging integration by creating a diagnostic entry and logging it 
	/// with contextual information using <see cref="ILogger.BeginScope"/>. The log entry includes the 
	/// stopwatch's title, current elapsed time, and the custom message.
	/// <para>
	/// <strong>Logging Behavior:</strong>
	/// <list type="bullet">
	/// <item><description>Creates a <see cref="DiagnosticEntry"/> with the current timestamp and elapsed time</description></item>
	/// <item><description>Adds the entry to the <see cref="Diagnostics"/> collection for later retrieval</description></item>
	/// <item><description>Uses <see cref="ILogger.BeginScope"/> to attach structured metadata (Title, ElapsedMs, Message)</description></item>
	/// <item><description>Logs at <see cref="LogLevel.Information"/> level if enabled</description></item>
	/// <item><description>The message is prefixed with the stopwatch's <see cref="Title"/> in the diagnostic entry</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Structured Logging Context:</strong>
	/// The logging scope includes the following properties that can be captured by structured logging providers:
	/// <list type="bullet">
	/// <item><description><c>Title</c> - The stopwatch's title/operation name</description></item>
	/// <item><description><c>ElapsedMs</c> - Current elapsed time in milliseconds</description></item>
	/// <item><description><c>Message</c> - The custom message provided</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Error Handling:</strong>
	/// If an exception occurs during logging, the method catches it and throws an <see cref="InvalidOperationException"/> 
	/// with a descriptive message and the original exception as the inner exception. This prevents logging failures 
	/// from disrupting the main application flow while still preserving error information.
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Checks if <see cref="LogLevel.Information"/> is enabled before logging to avoid unnecessary work</description></item>
	/// <item><description>Creates a diagnostic entry that is stored in the internal collection</description></item>
	/// <item><description>Uses structured logging scopes which may have performance implications in high-frequency scenarios</description></item>
	/// <item><description>The stopwatch does NOT need to be stopped to call this method - logs current state</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe for logging. The diagnostic entry is added to a <see cref="ConcurrentBag{T}"/>.
	/// However, the logging operation itself depends on the thread-safety of the provided <see cref="ILogger"/> implementation.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Logging intermediate checkpoints during long-running operations</description></item>
	/// <item><description>Recording operation milestones with timing information</description></item>
	/// <item><description>Integrating performance metrics with application logging infrastructure</description></item>
	/// <item><description>Creating audit trails with precise timing data</description></item>
	/// <item><description>Debugging performance issues by logging at key execution points</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="LogMessage"/> - Logs with structured context and adds to diagnostics (this method)</description></item>
	/// <item><description><see cref="AddDiagnosticEntry"/> - Only adds to diagnostics, no logging</description></item>
	/// <item><description><see cref="StopReset(ILogger, string)"/> - Stops, resets, and logs in one operation</description></item>
	/// <item><description><see cref="StopRestart(ILogger, string)"/> - Stops, restarts, and logs in one operation</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="logger"/> is null or when <paramref name="message"/> is null or empty.
	/// </exception>
	/// <exception cref="InvalidOperationException">
	/// Thrown when an error occurs during the logging operation. The original exception is wrapped as the inner exception.
	/// </exception>
	/// <example>
	/// Basic logging during operation execution:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DataProcessing");
	/// 
	/// await LoadConfiguration();
	/// stopwatch.LogMessage(logger, "Configuration loaded");
	/// 
	/// await ProcessData();
	/// stopwatch.LogMessage(logger, "Data processing completed");
	/// 
	/// await SaveResults();
	/// stopwatch.LogMessage(logger, "Results saved");
	/// 
	/// stopwatch.Stop();
	/// 
	/// // All logged messages are also available in diagnostics
	/// var diagnostics = stopwatch.Diagnostics;
	/// </code>
	/// 
	/// Logging with structured logging provider (e.g., Serilog):
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("APIRequest");
	/// 
	/// stopwatch.LogMessage(logger, "Request validation started");
	/// await ValidateRequest();
	/// 
	/// stopwatch.LogMessage(logger, "Processing business logic");
	/// await ProcessRequest();
	/// 
	/// stopwatch.Stop();
	/// 
	/// // With Serilog, the scope properties are captured:
	/// // {"Title": "APIRequest:", "ElapsedMs": 234.56, "Message": "Request validation started"}
	/// // {"Title": "APIRequest:", "ElapsedMs": 1456.78, "Message": "Processing business logic"}
	/// </code>
	/// 
	/// Error handling and logging:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("BatchProcessing");
	/// 
	/// try
	/// {
	///     stopwatch.LogMessage(logger, "Starting batch processing");
	///     
	///     foreach (var item in items)
	///     {
	///         await ProcessItem(item);
	///         stopwatch.LogMessage(logger, $"Processed item {item.Id}");
	///     }
	///     
	///     stopwatch.LogMessage(logger, "Batch processing completed successfully");
	/// }
	/// catch (Exception ex)
	/// {
	///     stopwatch.LogMessage(logger, $"Batch processing failed: {ex.Message}");
	///     throw;
	/// }
	/// finally
	/// {
	///     stopwatch.Stop();
	/// }
	/// </code>
	/// 
	/// Logging at specific milestones:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("ReportGeneration");
	/// 
	/// stopwatch.LogMessage(logger, "Phase 1: Data collection started");
	/// var data = await CollectData();
	/// stopwatch.LogMessage(logger, $"Phase 1 completed - {data.Count} records collected");
	/// 
	/// stopwatch.LogMessage(logger, "Phase 2: Calculations started");
	/// var results = await PerformCalculations(data);
	/// stopwatch.LogMessage(logger, $"Phase 2 completed - {results.Count} results calculated");
	/// 
	/// stopwatch.LogMessage(logger, "Phase 3: Report formatting started");
	/// var report = await FormatReport(results);
	/// stopwatch.LogMessage(logger, "Phase 3 completed - report generated");
	/// 
	/// stopwatch.Stop();
	/// 
	/// logger.LogInformation(
	///     "Report generation complete. Total time: {ElapsedMs}ms, Checkpoints: {CheckpointCount}", 
	///     stopwatch.Elapsed.TotalMilliseconds,
	///     stopwatch.Diagnostics.Count
	/// );
	/// </code>
	/// 
	/// Conditional logging based on elapsed time:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DatabaseQuery");
	/// 
	/// await ExecuteQuery();
	/// 
	/// if (stopwatch.Elapsed.TotalMilliseconds > 1000)
	/// {
	///     stopwatch.LogMessage(logger, "Query exceeded 1 second threshold");
	/// }
	/// else
	/// {
	///     stopwatch.LogMessage(logger, "Query completed within acceptable time");
	/// }
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Integration with dependency injection logging:
	/// <code>
	/// public class DataService
	/// {
	///     private readonly ILogger&lt;DataService&gt; _logger;
	///     
	///     public DataService(ILogger&lt;DataService&gt; logger)
	///     {
	///         _logger = logger;
	///     }
	///     
	///     public async Task ProcessDataAsync()
	///     {
	///         var stopwatch = PerformanceStopwatch.StartNew("ProcessData");
	///         
	///         stopwatch.LogMessage(_logger, "Starting data processing");
	///         
	///         await LoadDataAsync();
	///         stopwatch.LogMessage(_logger, "Data loaded");
	///         
	///         await TransformDataAsync();
	///         stopwatch.LogMessage(_logger, "Data transformed");
	///         
	///         await SaveDataAsync();
	///         stopwatch.LogMessage(_logger, "Data saved");
	///         
	///         stopwatch.Stop();
	///         
	///         _logger.LogInformation(
	///             "Data processing completed in {ElapsedMs}ms with {DiagnosticCount} checkpoints",
	///             stopwatch.Elapsed.TotalMilliseconds,
	///             stopwatch.Diagnostics.Count
	///         );
	///     }
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="AddDiagnosticEntry"/>
	/// <seealso cref="Diagnostics"/>
	/// <seealso cref="DiagnosticEntry"/>
	/// <seealso cref="StopReset(ILogger, string)"/>
	/// <seealso cref="StopRestart(ILogger, string)"/>
	/// <seealso cref="ILogger"/>
	/// <seealso cref="ILogger.BeginScope"/>
	/// <seealso cref="LogLevel"/>
	[Information(nameof(LogMessage), "David McCarter", "05/08/2025", BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public void LogMessage([DisallowNull] ILogger logger, [DisallowNull] string message)
	{
		logger = logger.ArgumentNotNull();
		message = message.ArgumentNotNullOrEmpty();

		try
		{
			var entry = this.CreateEntry(message, this.Elapsed);

			using (logger.BeginScope(new Dictionary<string, object>
			{
				["Title"] = this.Title,
				["ElapsedMs"] = this.Elapsed.TotalMilliseconds,
				["Message"] = message
			}))
			{
				if (logger.IsEnabled(LogLevel.Information))
				{
					logger.LogInformationMessage(entry.ToString());
				}
			}
		}
		catch (Exception ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileLoggingTheMessage, ex);
		}
	}

	/// <summary>
	/// Records a lap checkpoint by capturing the current elapsed time as a cumulative timestamp.
	/// </summary>
	/// <remarks>
	/// This method captures the stopwatch's current Elapsed time and stores it as a lap entry. 
	/// Each lap represents a cumulative time measurement from when the stopwatch was started (or last reset).
	/// <para>
	/// <strong>Lap Behavior:</strong>
	/// <list type="bullet">
	/// <item><description>Captures the current Elapsed time as a <see cref="TimeSpan"/></description></item>
	/// <item><description>Adds the captured time to the internal lap collection (<see cref="ConcurrentBag{T}"/>)</description></item>
	/// <item><description>The stopwatch does NOT need to be stopped to record a lap</description></item>
	/// <item><description>The stopwatch continues running after recording the lap</description></item>
	/// <item><description>Multiple laps can be recorded during a single timing session</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Cumulative vs. Individual Lap Times:</strong>
	/// Each recorded lap stores the <strong>cumulative</strong> elapsed time since the stopwatch started.
	/// To calculate the duration of an individual lap segment, subtract the previous lap time from the current lap time.
	/// <code>
	/// var laps = stopwatch.GetLaps();
	/// // First lap duration (from start to first checkpoint)
	/// var lap1Duration = laps[0];
	/// // Second lap duration (from first checkpoint to second checkpoint)
	/// var lap2Duration = laps[1] - laps[0];
	/// </code>
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Very lightweight operation - simply adds current elapsed time to collection</description></item>
	/// <item><description>Thread-safe using <see cref="ConcurrentBag{T}"/> for storage</description></item>
	/// <item><description>No sorting or processing occurs during recording - that happens in <see cref="GetLaps"/></description></item>
	/// <item><description>Can be called frequently without significant performance impact</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe and can be called from multiple threads concurrently. The underlying 
	/// <see cref="ConcurrentBag{T}"/> ensures safe concurrent access. However, the order of laps recorded 
	/// by different threads may not reflect the exact execution order due to thread scheduling.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Recording timing checkpoints during iterative processing (loops, batch operations)</description></item>
	/// <item><description>Measuring performance of multiple sequential steps in a workflow</description></item>
	/// <item><description>Benchmarking individual iterations of an algorithm</description></item>
	/// <item><description>Creating detailed timing breakdowns for performance analysis</description></item>
	/// <item><description>Tracking execution milestones in long-running operations</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="RecordLap"/> - Records a lap checkpoint (this method)</description></item>
	/// <item><description><see cref="GetLaps"/> - Retrieves all recorded laps sorted by duration</description></item>
	/// <item><description><see cref="ClearLaps"/> - Removes all recorded laps</description></item>
	/// <item><description><see cref="AddDiagnosticEntry"/> - Records a timestamped message with elapsed time</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Recording laps during iterative processing:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("BatchProcessing");
	/// 
	/// for (int i = 0; i &lt; items.Count; i++)
	/// {
	///     await ProcessItem(items[i]);
	///     stopwatch.RecordLap(); // Record time after each item
	/// }
	/// 
	/// stopwatch.Stop();
	/// 
	/// var laps = stopwatch.GetLaps();
	/// Console.WriteLine($"Processed {laps.Count} items");
	/// Console.WriteLine($"Fastest item: {laps[0].TotalMilliseconds:F2}ms");
	/// Console.WriteLine($"Slowest item: {laps[^1].TotalMilliseconds:F2}ms");
	/// </code>
	/// 
	/// Recording laps for workflow phases:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DataPipeline");
	/// 
	/// // Phase 1: Data extraction
	/// await ExtractData();
	/// stopwatch.RecordLap();
	/// 
	/// // Phase 2: Data transformation
	/// await TransformData();
	/// stopwatch.RecordLap();
	/// 
	/// // Phase 3: Data loading
	/// await LoadData();
	/// stopwatch.RecordLap();
	/// 
	/// stopwatch.Stop();
	/// 
	/// var laps = stopwatch.GetLaps();
	/// Console.WriteLine($"Extraction: {laps[0].TotalMilliseconds:F2}ms");
	/// Console.WriteLine($"Transformation: {(laps[1] - laps[0]).TotalMilliseconds:F2}ms");
	/// Console.WriteLine($"Loading: {(laps[2] - laps[1]).TotalMilliseconds:F2}ms");
	/// </code>
	/// 
	/// Benchmarking algorithm iterations:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("AlgorithmBenchmark");
	/// 
	/// foreach (var testCase in testCases)
	/// {
	///     RunAlgorithm(testCase);
	///     stopwatch.RecordLap();
	/// }
	/// 
	/// stopwatch.Stop();
	/// 
	/// var laps = stopwatch.GetLaps();
	/// var durations = new List&lt;TimeSpan&gt; { laps[0] };
	/// for (int i = 1; i &lt; laps.Count; i++)
	/// {
	///     durations.Add(laps[i] - laps[i - 1]);
	/// }
	/// 
	/// var average = TimeSpan.FromMilliseconds(durations.Average(d => d.TotalMilliseconds));
	/// Console.WriteLine($"Average iteration time: {average.TotalMilliseconds:F2}ms");
	/// </code>
	/// 
	/// Recording laps while stopwatch is running:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("ContinuousMonitoring");
	/// 
	/// // Record periodic checkpoints while running
	/// var timer = new Timer(_ => stopwatch.RecordLap(), null, 0, 1000);
	/// 
	/// // Do work...
	/// await PerformLongRunningTask();
	/// 
	/// timer.Dispose();
	/// stopwatch.Stop();
	/// 
	/// var laps = stopwatch.GetLaps();
	/// Console.WriteLine($"Recorded {laps.Count} checkpoints over {stopwatch.Elapsed.TotalSeconds:F2}s");
	/// </code>
	/// 
	/// Combining laps with diagnostic entries:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("ComplexOperation");
	/// 
	/// await Step1();
	/// stopwatch.RecordLap();
	/// stopwatch.AddDiagnosticEntry("Step 1 completed");
	/// 
	/// await Step2();
	/// stopwatch.RecordLap();
	/// stopwatch.AddDiagnosticEntry("Step 2 completed");
	/// 
	/// await Step3();
	/// stopwatch.RecordLap();
	/// stopwatch.AddDiagnosticEntry("Step 3 completed");
	/// 
	/// stopwatch.Stop();
	/// 
	/// // Both laps and diagnostics are available
	/// Console.WriteLine($"Laps: {stopwatch.GetLaps().Count}");
	/// Console.WriteLine($"Diagnostics: {stopwatch.Diagnostics.Count}");
	/// </code>
	/// </example>
	/// <seealso cref="GetLaps"/>
	/// <seealso cref="ClearLaps"/>
	/// <seealso cref="TimeSpan"/>
	/// <seealso cref="ConcurrentBag{T}"/>
	[Information(nameof(RecordLap), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public void RecordLap()
	{
		this._laps.Add(this.Elapsed);
	}

	/// <summary>
	/// Starts a new stopwatch instance with optional _title.
	/// </summary>
	/// <param name="title">Optional _title for diagnostics.</param>
	[Information(nameof(StartNew), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static PerformanceStopwatch StartNew(string title = ControlChars.EmptyString)
	{
		if (!string.IsNullOrEmpty(title))
		{
			title += ControlChars.Colon;
		}

		var sw = new PerformanceStopwatch(title);
		sw.Start();

		return sw;
	}

	/// <summary>
	/// Creates and starts a new <see cref="PerformanceStopwatch"/> instance with performance alert threshold monitoring.
	/// </summary>
	/// <param name="alertThreshold">
	/// The threshold <see cref="TimeSpan"/> for performance alerts. When the elapsed time exceeds this value,
	/// the <see cref="ThresholdExceeded"/> event is triggered. Pass <c>null</c> to disable threshold monitoring.
	/// </param>
	/// <param name="title">
	/// An optional descriptive title for the stopwatch operation. This title is used in diagnostic messages,
	/// log entries, and reports. Defaults to an empty string if not specified.
	/// </param>
	/// <returns>
	/// A new, running instance of <see cref="PerformanceStopwatch"/> configured with the specified alert threshold and title.
	/// </returns>
	/// <remarks>
	/// This factory method provides a convenient way to create and start a stopwatch with built-in performance
	/// threshold monitoring. The stopwatch is automatically started upon creation.
	/// <para>
	/// <strong>Alert Threshold Behavior:</strong>
	/// <list type="bullet">
	/// <item><description>If <paramref name="alertThreshold"/> is not null, the <see cref="AlertThreshold"/> property is set</description></item>
	/// <item><description>The <see cref="ThresholdExceeded"/> event fires when elapsed time exceeds the threshold during stop operations</description></item>
	/// <item><description>Use <see cref="IsThresholdExceeded"/> to check if the threshold has been exceeded at any time</description></item>
	/// <item><description>The stopwatch continues running even if the threshold is exceeded</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Title Formatting:</strong>
	/// If a non-empty title is provided, a colon (":") is automatically appended to it for consistent formatting
	/// in diagnostic outputs. This matches the behavior of <see cref="StartNew"/>.
	/// </para>
	/// <para>
	/// <strong>When Threshold Events Fire:</strong>
	/// The <see cref="ThresholdExceeded"/> event is raised in the following scenarios:
	/// <list type="bullet">
	/// <item><description>When <see cref="StopReset()"/> is called and the elapsed time exceeds the threshold</description></item>
	/// <item><description>When <see cref="StopRestart()"/> is called and the elapsed time exceeds the threshold</description></item>
	/// <item><description>When <see cref="StopIfThresholdExceeded"/> is called and the threshold is exceeded</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Monitoring operations with SLA requirements or time constraints</description></item>
	/// <item><description>Detecting slow database queries or API calls</description></item>
	/// <item><description>Triggering alerts when operations exceed acceptable durations</description></item>
	/// <item><description>Performance regression testing with automated threshold validation</description></item>
	/// <item><description>Collecting metrics for operations that violate performance budgets</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Setting a threshold does not impact performance during timing - checks only occur during stop operations</description></item>
	/// <item><description>The threshold comparison uses <see cref="TimeSpan"/> comparison which is very efficient</description></item>
	/// <item><description>Event handlers for <see cref="ThresholdExceeded"/> are invoked synchronously</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="StartNew"/> - Creates stopwatch without threshold monitoring</description></item>
	/// <item><description><see cref="StartNewWithAlertThreshold"/> - Creates stopwatch with threshold monitoring (this method)</description></item>
	/// <item><description><see cref="StartNewWithTelemetry"/> - Creates stopwatch with both threshold and telemetry</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic usage with threshold monitoring:
	/// <code>
	/// // Create stopwatch with 2-second threshold
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(2),
	///     "DatabaseQuery"
	/// );
	/// 
	/// // Subscribe to threshold exceeded event
	/// stopwatch.ThresholdExceeded += (sender, e) =>
	/// {
	///     logger.LogWarning("Query exceeded threshold: {Elapsed}ms", e.Elapsed.TotalMilliseconds);
	/// };
	/// 
	/// await ExecuteDatabaseQuery();
	/// 
	/// stopwatch.Stop();
	/// // If query took > 2 seconds, ThresholdExceeded event was raised
	/// </code>
	/// 
	/// Monitoring API response times:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromMilliseconds(500),
	///     "ExternalAPICall"
	/// );
	/// 
	/// stopwatch.ThresholdExceeded += (sender, e) =>
	/// {
	///     // Log slow API calls
	///     logger.LogWarning(
	///         "Slow API call detected. Elapsed: {Elapsed}ms, Threshold: {Threshold}ms",
	///         e.Elapsed.TotalMilliseconds,
	///         stopwatch.AlertThreshold?.TotalMilliseconds
	///     );
	///     
	///     // Optionally trigger alerts or increment metrics
	///     metrics.IncrementCounter("slow_api_calls");
	/// };
	/// 
	/// try
	/// {
	///     var response = await CallExternalApi();
	///     return response;
	/// }
	/// finally
	/// {
	///     stopwatch.Stop();
	/// }
	/// </code>
	/// 
	/// Conditional stopping based on threshold:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(5),
	///     "BatchProcessing"
	/// );
	/// 
	/// foreach (var item in items)
	/// {
	///     await ProcessItem(item);
	///     
	///     // Stop early if threshold exceeded
	///     if (stopwatch.StopIfThresholdExceeded())
	///     {
	///         logger.LogWarning("Processing stopped due to timeout after {Count} items", processedCount);
	///         break;
	///     }
	/// }
	/// </code>
	/// 
	/// Using without threshold (null value):
	/// <code>
	/// // No threshold monitoring - behaves like StartNew()
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     null,
	///     "FlexibleOperation"
	/// );
	/// 
	/// await PerformOperation();
	/// stopwatch.Stop();
	/// 
	/// // No threshold events will fire
	/// Console.WriteLine($"Completed in {stopwatch.Elapsed.TotalMilliseconds}ms");
	/// </code>
	/// 
	/// Performance testing with threshold validation:
	/// <code>
	/// var threshold = TimeSpan.FromMilliseconds(100);
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     threshold,
	///     "PerformanceTest"
	/// );
	/// 
	/// bool thresholdExceeded = false;
	/// stopwatch.ThresholdExceeded += (sender, e) =>
	/// {
	///     thresholdExceeded = true;
	/// };
	/// 
	/// RunAlgorithm();
	/// stopwatch.Stop();
	/// 
	/// Assert.IsFalse(thresholdExceeded, 
	///     $"Algorithm exceeded {threshold.TotalMilliseconds}ms threshold");
	/// </code>
	/// 
	/// Multiple operations with different thresholds:
	/// <code>
	/// // Fast operation - tight threshold
	/// var fastOp = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromMilliseconds(50),
	///     "FastOperation"
	/// );
	/// await PerformFastOperation();
	/// fastOp.Stop();
	/// 
	/// // Slow operation - relaxed threshold
	/// var slowOp = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(5),
	///     "SlowOperation"
	/// );
	/// await PerformSlowOperation();
	/// slowOp.Stop();
	/// </code>
	/// </example>
	/// <seealso cref="StartNew"/>
	/// <seealso cref="StartNewWithTelemetry"/>
	/// <seealso cref="AlertThreshold"/>
	/// <seealso cref="ThresholdExceeded"/>
	/// <seealso cref="IsThresholdExceeded"/>
	/// <seealso cref="StopIfThresholdExceeded"/>
	[Information(nameof(StartNewWithAlertThreshold), "David McCarter", "5/8/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static PerformanceStopwatch StartNewWithAlertThreshold(TimeSpan? alertThreshold, string title = ControlChars.EmptyString)
	{
		var sw = new PerformanceStopwatch(title) { AlertThreshold = alertThreshold };

		sw.Start();

		return sw;
	}

	/// <summary>
	/// Creates and starts a new <see cref="PerformanceStopwatch"/> instance with Application Insights telemetry tracking and optional performance alert threshold monitoring.
	/// </summary>
	/// <param name="telemetry">
	/// The <see cref="TelemetryClient"/> instance used to record events and metrics to Application Insights. Cannot be null.
	/// </param>
	/// <param name="operationName">
	/// The name of the operation being tracked. This name is used as the event name in Application Insights and as a prefix for metrics.
	/// </param>
	/// <param name="alertThreshold">
	/// An optional threshold <see cref="TimeSpan"/> for performance alerts. When the elapsed time exceeds this value,
	/// the <see cref="ThresholdExceeded"/> event is triggered. Pass <c>null</c> to disable threshold monitoring.
	/// </param>
	/// <param name="message">
	/// An optional custom message to include with telemetry events and as the stopwatch title. Defaults to an empty string if not specified.
	/// </param>
	/// <param name="properties">
	/// Optional key/value properties to attach to telemetry events. These properties are included with both the event and metric data sent to Application Insights.
	/// </param>
	/// <returns>
	/// A new, running instance of <see cref="PerformanceStopwatch"/> configured with telemetry tracking, optional alert threshold monitoring, and the specified title/message.
	/// </returns>
	/// <remarks>
	/// This factory method provides the most comprehensive way to create a stopwatch with both telemetry tracking and 
	/// performance threshold monitoring. The stopwatch is automatically started upon creation.
	/// <para>
	/// <strong>Telemetry Integration:</strong>
	/// <list type="bullet">
	/// <item><description>Automatically tracks events and metrics to Application Insights when the stopwatch stops</description></item>
	/// <item><description>Uses <see cref="WithTelemetry"/> internally to configure telemetry settings</description></item>
	/// <item><description>Telemetry is sent when <see cref="StopReset()"/> or <see cref="StopRestart()"/> is called</description></item>
	/// <item><description>Both an event (named <paramref name="operationName"/>) and a metric (named <paramref name="operationName"/>.Duration) are tracked</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Title and Message Handling:</strong>
	/// The <paramref name="message"/> parameter serves dual purposes:
	/// <list type="bullet">
	/// <item><description>Used as the stopwatch's <see cref="Title"/> for diagnostic messages and reports</description></item>
	/// <item><description>Included in telemetry properties under the "Message" key (if not empty)</description></item>
	/// <item><description>If non-empty, a colon (":") is automatically appended for consistent formatting</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Alert Threshold Behavior:</strong>
	/// <list type="bullet">
	/// <item><description>If <paramref name="alertThreshold"/> is not null, the <see cref="AlertThreshold"/> property is set</description></item>
	/// <item><description>The <see cref="ThresholdExceeded"/> event fires when elapsed time exceeds the threshold during stop operations</description></item>
	/// <item><description>Threshold monitoring is independent of telemetry tracking</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Telemetry Data Structure:</strong>
	/// When the stopwatch stops, the following data is sent to Application Insights:
	/// <list type="bullet">
	/// <item><description><strong>Event Properties:</strong> Title (stopwatch title), ElapsedMs (elapsed time in milliseconds), Message (if provided), plus any custom properties</description></item>
	/// <item><description><strong>Metric:</strong> A metric named "{operationName}.Duration" with the elapsed time in milliseconds</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Monitoring critical operations with automatic telemetry reporting to Application Insights</description></item>
	/// <item><description>Tracking performance of API calls, database queries, or external service interactions</description></item>
	/// <item><description>Combining SLA monitoring (threshold) with centralized logging (telemetry)</description></item>
	/// <item><description>Building performance dashboards in Application Insights based on operation metrics</description></item>
	/// <item><description>Correlating performance data with custom properties (user ID, request ID, etc.)</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Telemetry data is sent asynchronously to Application Insights - does not block stop operations</description></item>
	/// <item><description>The <see cref="TelemetryClient"/> should be reused across operations for optimal performance</description></item>
	/// <item><description>Custom properties are shallow-copied to avoid reference issues</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="StartNew"/> - Creates basic stopwatch without telemetry or threshold</description></item>
	/// <item><description><see cref="StartNewWithAlertThreshold"/> - Creates stopwatch with threshold but no telemetry</description></item>
	/// <item><description><see cref="StartNewWithTelemetry"/> - Creates stopwatch with both threshold and telemetry (this method)</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="telemetry"/> is null.
	/// </exception>
	/// <example>
	/// Basic usage with telemetry tracking:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithTelemetry(
	///     telemetryClient,
	///     "DatabaseQuery",
	///     alertThreshold: TimeSpan.FromSeconds(2),
	///     message: "GetUsers"
	/// );
	/// 
	/// await ExecuteDatabaseQuery();
	/// 
	/// stopwatch.Stop();
	/// // Telemetry event and metric automatically sent to Application Insights
	/// </code>
	/// 
	/// Including custom properties with telemetry:
	/// <code>
	/// var properties = new Dictionary&lt;string, string&gt;
	/// {
	///     ["UserId"] = currentUserId,
	///     ["QueryType"] = "SELECT",
	///     ["TableName"] = "Users"
	/// };
	/// 
	/// var stopwatch = PerformanceStopwatch.StartNewWithTelemetry(
	///     telemetryClient,
	///     "DatabaseQuery",
	///     message: "GetUsersByRegion",
	///     properties: properties
	/// );
	/// 
	/// var users = await GetUsersByRegion(regionId);
	/// 
	/// stopwatch.Stop();
	/// // Application Insights receives event with all custom properties plus performance data
	/// </code>
	/// 
	/// Combining telemetry with threshold monitoring:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithTelemetry(
	///     telemetryClient,
	///     "ExternalAPICall",
	///     alertThreshold: TimeSpan.FromMilliseconds(500),
	///     message: "PaymentGateway"
	/// );
	/// 
	/// // Subscribe to threshold exceeded event for immediate alerting
	/// stopwatch.ThresholdExceeded += (sender, e) =>
	/// {
	///     logger.LogWarning("API call exceeded SLA: {Elapsed}ms", e.Elapsed.TotalMilliseconds);
	///     alertingService.SendAlert("Slow API call detected");
	/// };
	/// 
	/// try
	/// {
	///     var response = await CallPaymentGatewayAsync();
	///     return response;
	/// }
	/// finally
	/// {
	///     stopwatch.Stop();
	///     // Both threshold event (if exceeded) and telemetry data are processed
	/// }
	/// </code>
	/// 
	/// Tracking operation with no threshold:
	/// <code>
	/// // Track telemetry without threshold monitoring
	/// var stopwatch = PerformanceStopwatch.StartNewWithTelemetry(
	///     telemetryClient,
	///     "BackgroundJob",
	///     alertThreshold: null,  // No threshold
	///     message: "EmailProcessor"
	/// );
	/// 
	/// await ProcessEmailQueue();
	/// 
	/// stopwatch.Stop();
	/// // Only telemetry is sent, no threshold checking occurs
	/// </code>
	/// 
	/// Building performance dashboards in Application Insights:
	/// <code>
	/// // Track different operations with consistent naming for dashboard queries
	/// var dbStopwatch = PerformanceStopwatch.StartNewWithTelemetry(
	///     telemetryClient,
	///     "Database.Query",
	///     message: "GetOrders"
	/// );
	/// await GetOrders();
	/// dbStopwatch.Stop();
	/// 
	/// var cacheStopwatch = PerformanceStopwatch.StartNewWithTelemetry(
	///     telemetryClient,
	///     "Cache.Read",
	///     message: "GetUserProfile"
	/// );
	/// await GetFromCache();
	/// cacheStopwatch.Stop();
	/// 
	/// // In Application Insights, query:
	/// // customEvents | where name startswith "Database."
	/// // customMetrics | where name endswith ".Duration"
	/// </code>
	/// 
	/// Reusing telemetry client across operations:
	/// <code>
	/// public class PerformanceMonitor
	/// {
	///     private readonly TelemetryClient _telemetryClient;
	///     
	///     public PerformanceMonitor(TelemetryClient telemetryClient)
	///     {
	///         _telemetryClient = telemetryClient;
	///     }
	///     
	///     public async Task&lt;T&gt; TrackOperationAsync&lt;T&gt;(
	///         string operationName, 
	///         Func&lt;Task&lt;T&gt;&gt; operation,
	///         TimeSpan? threshold = null)
	///     {
	///         var stopwatch = PerformanceStopwatch.StartNewWithTelemetry(
	///             _telemetryClient,
	///             operationName,
	///             alertThreshold: threshold
	///         );
	///         
	///         try
	///         {
	///             return await operation();
	///         }
	///         finally
	///         {
	///             stopwatch.Stop();
	///         }
	///     }
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="StartNew"/>
	/// <seealso cref="StartNewWithAlertThreshold"/>
	/// <seealso cref="WithTelemetry"/>
	/// <seealso cref="TrackTelemetry"/>
	/// <seealso cref="TelemetryClient"/>
	/// <seealso cref="AlertThreshold"/>
	/// <seealso cref="ThresholdExceeded"/>
	[Information(nameof(StartNewWithTelemetry), "David McCarter", "5/8/2025", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
	public static PerformanceStopwatch StartNewWithTelemetry(TelemetryClient telemetry, string operationName, TimeSpan? alertThreshold = null, string message = ControlChars.EmptyString, IDictionary<string, string>? properties = null)
	{
		return StartNewWithAlertThreshold(alertThreshold, message).WithTelemetry(telemetry, operationName, message, properties);
	}

	/// <summary>
	/// Conditionally stops the stopwatch if the current elapsed time has exceeded the configured alert threshold.
	/// </summary>
	/// <returns>
	/// <c>true</c> if the elapsed time exceeds the <see cref="AlertThreshold"/> and the stopwatch is stopped; 
	/// otherwise, <c>false</c> if the threshold is not exceeded or no threshold is configured.
	/// </returns>
	/// <remarks>
	/// This method provides conditional stopping behavior based on the configured <see cref="AlertThreshold"/>. 
	/// It checks the <see cref="IsThresholdExceeded"/> property and only stops the stopwatch if the threshold has been exceeded.
	/// <para>
	/// <strong>Method Behavior:</strong>
	/// <list type="bullet">
	/// <item><description>Checks if <see cref="IsThresholdExceeded"/> is <c>true</c></description></item>
	/// <item><description>If threshold exceeded: stops the stopwatch, raises the <see cref="ThresholdExceeded"/> event, and returns <c>true</c></description></item>
	/// <item><description>If threshold not exceeded: takes no action and returns <c>false</c></description></item>
	/// <item><description>If no threshold configured (<see cref="AlertThreshold"/> is <c>null</c>): always returns <c>false</c></description></item>
	/// <item><description>The stopwatch remains running if the threshold is not exceeded</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Event Notification:</strong>
	/// When the threshold is exceeded, the <see cref="ThresholdExceeded"/> event is raised with <see cref="ElapsedEventArgs"/> 
	/// containing the elapsed time at the moment of stopping. Event handlers are invoked synchronously before this method returns.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Implementing timeout logic for long-running operations</description></item>
	/// <item><description>Early termination of iterative processes when time limits are exceeded</description></item>
	/// <item><description>Circuit breaker patterns for operations with SLA constraints</description></item>
	/// <item><description>Conditional logic in loops or workflows based on elapsed time</description></item>
	/// <item><description>Preventing operations from exceeding maximum acceptable durations</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Very lightweight check - simply evaluates <see cref="IsThresholdExceeded"/> property</description></item>
	/// <item><description>Can be called frequently in loops without significant overhead</description></item>
	/// <item><description>Only performs stop operation and event invocation if threshold is actually exceeded</description></item>
	/// <item><description>Event handlers execute synchronously - consider handler performance if used in tight loops</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is safe to call from multiple threads, but be aware that the threshold check and stop operation 
	/// are not atomic. In multi-threaded scenarios, multiple threads might see the threshold as exceeded before 
	/// any of them calls Stop. Ensure event handlers are thread-safe if using in concurrent contexts.
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="StopIfThresholdExceeded"/> - Conditional stop based on threshold (this method)</description></item>
	/// <item><description>Stop - Unconditionally stops the stopwatch</description></item>
	/// <item><description><see cref="StopReset()"/> - Stops and resets, always raises events if threshold exceeded</description></item>
	/// <item><description><see cref="StopRestart()"/> - Stops and restarts, always raises events if threshold exceeded</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Using in a loop with timeout:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(30),
	///     "BatchProcessing"
	/// );
	/// 
	/// int processedCount = 0;
	/// 
	/// foreach (var item in items)
	/// {
	///     await ProcessItem(item);
	///     processedCount++;
	///     
	///     // Stop processing if we've exceeded the time limit
	///     if (stopwatch.StopIfThresholdExceeded())
	///     {
	///         logger.LogWarning("Processing stopped after {Count} items due to timeout", processedCount);
	///         break;
	///     }
	/// }
	/// 
	/// Console.WriteLine($"Processed {processedCount} items in {stopwatch.Elapsed.TotalSeconds:F2}s");
	/// </code>
	/// 
	/// Implementing retry logic with timeout:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(10),
	///     "RetryOperation"
	/// );
	/// 
	/// bool success = false;
	/// int attempts = 0;
	/// 
	/// while (!success)
	/// {
	///     attempts++;
	///     
	///     if (stopwatch.StopIfThresholdExceeded())
	///     {
	///         throw new TimeoutException($"Operation timed out after {attempts} attempts");
	///     }
	///     
	///     try
	///     {
	///         await PerformOperation();
	///         success = true;
	///     }
	///     catch (Exception ex)
	///     {
	///         logger.LogWarning("Attempt {Attempt} failed: {Error}", attempts, ex.Message);
	///         await Task.Delay(1000); // Wait before retry
	///     }
	/// }
	/// </code>
	/// 
	/// Conditional stopping with event handling:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromMilliseconds(5000),
	///     "DataProcessing"
	/// );
	/// 
	/// stopwatch.ThresholdExceeded += (sender, e) =>
	/// {
	///     logger.LogWarning("Threshold exceeded at {Elapsed}ms", e.Elapsed.TotalMilliseconds);
	///     metrics.IncrementCounter("processing_timeouts");
	/// };
	/// 
	/// foreach (var batch in batches)
	/// {
	///     await ProcessBatch(batch);
	///     
	///     if (stopwatch.StopIfThresholdExceeded())
	///     {
	///         // Event has already fired, can perform additional cleanup
	///         await SavePartialResults();
	///         return; // Exit early
	///     }
	/// }
	/// 
	/// // Normal completion - threshold not exceeded
	/// await FinalizeResults();
	/// </code>
	/// 
	/// Checking threshold without stopping (alternative pattern):
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(60),
	///     "LongOperation"
	/// );
	/// 
	/// while (HasMoreWork())
	/// {
	///     // Check if we should continue
	///     if (stopwatch.IsThresholdExceeded)
	///     {
	///         logger.LogWarning("Time limit approaching, wrapping up...");
	///         
	///         // Explicitly stop when ready
	///         if (stopwatch.StopIfThresholdExceeded())
	///         {
	///             // Threshold event fired
	///             break;
	///         }
	///     }
	///     
	///     await ProcessNextItem();
	/// }
	/// </code>
	/// 
	/// Using without threshold configuration:
	/// <code>
	/// // No threshold set - method always returns false
	/// var stopwatch = PerformanceStopwatch.StartNew("Operation");
	/// 
	/// await PerformWork();
	/// 
	/// if (stopwatch.StopIfThresholdExceeded())
	/// {
	///     // This block never executes because AlertThreshold is null
	///     Console.WriteLine("Threshold exceeded");
	/// }
	/// else
	/// {
	///     // Always executes when no threshold configured
	///     Console.WriteLine("No threshold to check");
	///     stopwatch.Stop(); // Must stop manually
	/// }
	/// </code>
	/// 
	/// Periodic threshold checks in background processing:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromMinutes(5),
	///     "BackgroundJob"
	/// );
	/// 
	/// var cancellationToken = new CancellationTokenSource();
	/// 
	/// // Periodic check in separate task
	/// _ = Task.Run(async () =>
	/// {
	///     while (!cancellationToken.Token.IsCancellationRequested)
	///     {
	///         await Task.Delay(1000);
	///         
	///         if (stopwatch.StopIfThresholdExceeded())
	///         {
	///             cancellationToken.Cancel();
	///             logger.LogWarning("Background job cancelled due to timeout");
	///         }
	///     }
	/// });
	/// 
	/// try
	/// {
	///     await ProcessBackgroundWork(cancellationToken.Token);
	/// }
	/// catch (OperationCanceledException)
	/// {
	///     logger.LogInformation("Job was cancelled");
	/// }
	/// finally
	/// {
	///     cancellationToken.Dispose();
	/// }
	/// </code>
	/// </example>
	/// <seealso cref="AlertThreshold"/>
	/// <seealso cref="IsThresholdExceeded"/>
	/// <seealso cref="ThresholdExceeded"/>
	/// <seealso cref="StopReset()"/>
	/// <seealso cref="StopRestart()"/>
	[Information(nameof(StopIfThresholdExceeded), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public bool StopIfThresholdExceeded()
	{
		if (this.IsThresholdExceeded)
		{
			this.Stop();
			this.ThresholdExceeded?.Invoke(this, new ElapsedEventArgs(this.Elapsed));
			return true;
		}

		return false;
	}

	/// <summary>
	/// Stops and resets the stopwatch, returning the elapsed time. Fires telemetry and threshold events if configured.
	/// </summary>
	/// <returns>The elapsed time before reset.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan StopReset()
	{
		this.Stop();
		var result = this.Elapsed;
		this.StoppedCompleted?.Invoke(this, new ElapsedEventArgs(result));
		this.ResetCompleted?.Invoke(this, new ElapsedEventArgs(result));
		this.Reset();

		if (this.IsThresholdExceeded)
		{
			this.ThresholdExceeded?.Invoke(this, new ElapsedEventArgs(result));
		}

		if (this._telemetry != null && !string.IsNullOrWhiteSpace(this._operationName))
		{
			this.TrackTelemetry(this._telemetry, this._operationName!, this._telemetryMessage ?? string.Empty, this._telemetryProperties);
		}

		return result;
	}

	/// <summary>
	/// Stops and resets the stopwatch, logs a message, and returns the elapsed time.
	/// </summary>
	/// <param name="logger">Logger used for logging.</param>
	/// <param name="message">Message to log.</param>
	/// <returns>The elapsed time before reset.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan StopReset(ILogger logger, [DisallowNull] string message)
	{
		var result = this.StopReset();

		if (logger.CheckIsNotNull() is false)
		{
			return result;
		}

		try
		{
			var entry = this.CreateEntry(message, result);

			using (logger.BeginScope(new Dictionary<string, object>
			{
				["Title"] = this.Title,
				["ElapsedMs"] = result.TotalMilliseconds
			}))
			{
				if (logger.IsEnabled(LogLevel.Information))
				{
					logger.LogInformationMessage(entry.ToString());
				}
			}
		}
		catch (Exception ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileLoggingTheMessage, ex);
		}

		return result;
	}

	/// <summary>
	/// Stops and restarts the stopwatch, triggering threshold alerts if applicable.
	/// </summary>
	/// <returns>The elapsed time before restart.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan StopRestart()
	{
		var result = this.Elapsed;
		this.StoppedCompleted?.Invoke(this, new ElapsedEventArgs(result));
		this.Restart();

		if (this.IsThresholdExceeded)
		{
			this.ThresholdExceeded?.Invoke(this, new ElapsedEventArgs(result));
		}

		if (this._telemetry != null && !string.IsNullOrWhiteSpace(this._operationName))
		{
			this.TrackTelemetry(this._telemetry, this._operationName!, this._telemetryMessage ?? string.Empty, this._telemetryProperties);
		}

		return result;
	}

	/// <summary>
	/// Stops and restarts the stopwatch, logs a message, and returns the elapsed time.
	/// </summary>
	/// <param name="logger">Logger used for logging.</param>
	/// <param name="message">Message to log.</param>
	/// <returns>The elapsed time before restart.</returns>
	[Information(nameof(StopReset), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan StopRestart(ILogger logger, [DisallowNull] string message)
	{
		var result = this.StopRestart();

		if (logger.CheckIsNotNull() is false)
		{
			return result;
		}

		try
		{
			var entry = this.CreateEntry(message, result);

			using (logger.BeginScope(new Dictionary<string, object>
			{
				["Title"] = this.Title,
				["ElapsedMs"] = result.TotalMilliseconds
			}))
			{
				if (logger.IsEnabled(LogLevel.Information))
				{
					logger.LogInformationMessage(entry.ToString());
				}
			}
		}
		catch (Exception ex)
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AnErrorOccurredWhileLoggingTheMessage, ex);
		}

		return result;
	}

	/// <summary>
	/// Returns a detailed summary report of the stopwatch, including laps and diagnostics, as a string.
	/// </summary>
	/// <returns>A string representation of the stopwatch's summary report.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToString), "David McCarter", "1/18/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public override string ToString() => this.GetSummaryReport();

	/// <summary>
	/// Sends performance telemetry data to Application Insights by recording an event and a metric for the current stopwatch operation.
	/// </summary>
	/// <param name="telemetry">
	/// The <see cref="TelemetryClient"/> instance used to send telemetry data to Application Insights. Cannot be null.
	/// </param>
	/// <param name="operationName">
	/// The name of the operation being tracked. This becomes the event name in Application Insights and is used as a prefix for the metric name.
	/// </param>
	/// <param name="message">
	/// An optional custom message to include with the telemetry event as a property. Defaults to an empty string if not provided.
	/// </param>
	/// <param name="properties">
	/// Optional key/value properties to attach to the telemetry event. If null, a new dictionary is created. 
	/// Standard properties (Title, ElapsedMs, and optionally Message) are automatically added to this collection.
	/// </param>
	/// <remarks>
	/// This method immediately sends telemetry data to Application Insights, recording both an event and a metric 
	/// with the stopwatch's current elapsed time and associated metadata.
	/// <para>
	/// <strong>Telemetry Data Sent:</strong>
	/// <list type="bullet">
	/// <item><description><strong>Event:</strong> Named <paramref name="operationName"/> with properties including Title, ElapsedMs, Message (if provided), and any custom properties</description></item>
	/// <item><description><strong>Metric:</strong> Named "{operationName}.Duration" with the elapsed time in milliseconds as the value</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Standard Properties:</strong>
	/// The following properties are automatically included with every telemetry event:
	/// <list type="bullet">
	/// <item><description><c>Title</c> - The stopwatch's <see cref="Title"/> property value</description></item>
	/// <item><description><c>ElapsedMs</c> - Current elapsed time in milliseconds, formatted with 2 decimal places</description></item>
	/// <item><description><c>Message</c> - The custom message (only if <paramref name="message"/> is not null or whitespace)</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>When to Call This Method:</strong>
	/// <list type="bullet">
	/// <item><description>Automatically called by <see cref="StopReset()"/> and <see cref="StopRestart()"/> if telemetry is configured via <see cref="WithTelemetry"/></description></item>
	/// <item><description>Can be called manually at any time to send intermediate telemetry data</description></item>
	/// <item><description>The stopwatch does NOT need to be stopped to call this method</description></item>
	/// <item><description>Can be called multiple times during a single timing session</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Application Insights Integration:</strong>
	/// The telemetry data can be queried in Application Insights using:
	/// <code>
	/// // Query events
	/// customEvents | where name == "{operationName}"
	/// 
	/// // Query metrics
	/// customMetrics | where name == "{operationName}.Duration"
	/// </code>
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Telemetry is sent asynchronously by the <see cref="TelemetryClient"/> - this method does not block</description></item>
	/// <item><description>The <see cref="TelemetryClient"/> should be reused across operations (singleton pattern recommended)</description></item>
	/// <item><description>Properties dictionary is modified (standard properties added) - a new dictionary is created if null</description></item>
	/// <item><description>Frequent calls may impact Application Insights quotas and costs</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This method is thread-safe and can be called from multiple threads. The <see cref="TelemetryClient"/> 
	/// is designed for concurrent use. However, if you pass a shared properties dictionary, ensure it's thread-safe.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Tracking operation performance metrics in production environments</description></item>
	/// <item><description>Building performance dashboards in Application Insights</description></item>
	/// <item><description>Correlating performance data with business metrics using custom properties</description></item>
	/// <item><description>Monitoring SLA compliance and performance degradation</description></item>
	/// <item><description>Sending intermediate progress updates for long-running operations</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Methods:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="TrackTelemetry"/> - Immediately sends telemetry (this method)</description></item>
	/// <item><description><see cref="WithTelemetry"/> - Configures telemetry to be sent automatically when stopwatch stops</description></item>
	/// <item><description><see cref="StartNewWithTelemetry"/> - Creates stopwatch with automatic telemetry tracking</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="telemetry"/> is null.
	/// </exception>
	/// <example>
	/// Basic manual telemetry tracking:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DataProcessing");
	/// 
	/// await ProcessData();
	/// 
	/// // Manually send telemetry
	/// stopwatch.TrackTelemetry(telemetryClient, "DataProcessing.Complete");
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Tracking with custom properties:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("DatabaseQuery");
	/// 
	/// var properties = new Dictionary&lt;string, string&gt;
	/// {
	///     ["DatabaseName"] = "ProductionDB",
	///     ["QueryType"] = "SELECT",
	///     ["TableName"] = "Users",
	///     ["RowCount"] = rowCount.ToString()
	/// };
	/// 
	/// await ExecuteQuery();
	/// 
	/// stopwatch.TrackTelemetry(
	///     telemetryClient,
	///     "Database.Query",
	///     message: "User query completed",
	///     properties: properties
	/// );
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Tracking intermediate progress:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("BatchProcessing");
	/// 
	/// for (int i = 0; i &lt; batches.Count; i++)
	/// {
	///     await ProcessBatch(batches[i]);
	///     
	///     // Send progress telemetry every 10 batches
	///     if ((i + 1) % 10 == 0)
	///     {
	///         var progressProps = new Dictionary&lt;string, string&gt;
	///         {
	///             ["BatchesProcessed"] = (i + 1).ToString(),
	///             ["TotalBatches"] = batches.Count.ToString(),
	///             ["ProgressPercent"] = ((i + 1) * 100 / batches.Count).ToString()
	///         };
	///         
	///         stopwatch.TrackTelemetry(
	///             telemetryClient,
	///             "Batch.Progress",
	///             $"Processed {i + 1} of {batches.Count} batches",
	///             progressProps
	///         );
	///     }
	/// }
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Automatic vs manual telemetry:
	/// <code>
	/// // Automatic telemetry (sent on stop)
	/// var autoStopwatch = PerformanceStopwatch.StartNewWithTelemetry(
	///     telemetryClient,
	///     "AutoOperation"
	/// );
	/// await PerformWork();
	/// autoStopwatch.Stop(); // Telemetry sent automatically
	/// 
	/// // Manual telemetry (full control)
	/// var manualStopwatch = PerformanceStopwatch.StartNew("ManualOperation");
	/// await PerformWork();
	/// 
	/// // Send custom telemetry at specific points
	/// manualStopwatch.TrackTelemetry(
	///     telemetryClient,
	///     "ManualOperation.Phase1",
	///     "Phase 1 complete"
	/// );
	/// 
	/// await PerformMoreWork();
	/// 
	/// manualStopwatch.TrackTelemetry(
	///     telemetryClient,
	///     "ManualOperation.Phase2",
	///     "Phase 2 complete"
	/// );
	/// 
	/// manualStopwatch.Stop();
	/// </code>
	/// 
	/// Tracking with user context:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNew("UserAction");
	/// 
	/// var userProperties = new Dictionary&lt;string, string&gt;
	/// {
	///     ["UserId"] = currentUser.Id,
	///     ["UserRole"] = currentUser.Role,
	///     ["SessionId"] = sessionId,
	///     ["ClientVersion"] = clientVersion
	/// };
	/// 
	/// await PerformUserAction();
	/// 
	/// stopwatch.TrackTelemetry(
	///     telemetryClient,
	///     "User.Action",
	///     $"Action completed for user {currentUser.Id}",
	///     userProperties
	/// );
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Building performance dashboard queries:
	/// <code>
	/// // Track different operation types
	/// var dbStopwatch = PerformanceStopwatch.StartNew("Database");
	/// await QueryDatabase();
	/// dbStopwatch.TrackTelemetry(telemetryClient, "Database.Query");
	/// 
	/// var cacheStopwatch = PerformanceStopwatch.StartNew("Cache");
	/// await ReadFromCache();
	/// cacheStopwatch.TrackTelemetry(telemetryClient, "Cache.Read");
	/// 
	/// var apiStopwatch = PerformanceStopwatch.StartNew("API");
	/// await CallExternalApi();
	/// apiStopwatch.TrackTelemetry(telemetryClient, "API.Call");
	/// 
	/// // In Application Insights, query:
	/// // customEvents 
	/// // | where name in ("Database.Query", "Cache.Read", "API.Call")
	/// // | extend elapsedMs = toreal(customDimensions.ElapsedMs)
	/// // | summarize avg(elapsedMs), max(elapsedMs), min(elapsedMs) by name
	/// </code>
	/// </example>
	/// <seealso cref="WithTelemetry"/>
	/// <seealso cref="StartNewWithTelemetry"/>
	/// <seealso cref="TelemetryClient"/>
	[Information(nameof(TrackTelemetry), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public void TrackTelemetry([DisallowNull] TelemetryClient telemetry, string operationName, string message = ControlChars.EmptyString, IDictionary<string, string>? properties = null)
	{
		telemetry = telemetry.ArgumentNotNull();

		properties ??= new Dictionary<string, string>();
		properties["Title"] = this.Title;
		properties["ElapsedMs"] = this.Elapsed.TotalMilliseconds.ToString("F2", CultureInfo.CurrentCulture);

		if (!string.IsNullOrWhiteSpace(message))
		{
			properties["Message"] = message;
		}

		telemetry.TrackEvent(operationName, properties);
		telemetry.TrackMetric($"{operationName}.Duration", this.Elapsed.TotalMilliseconds);
	}

	/// <summary>
	/// Configures telemetry tracking for this stopwatch instance using Application Insights.
	/// </summary>
	/// <param name="telemetry">The telemetry client to record events and metrics.</param>
	/// <param name="operationName">The name of the operation being tracked.</param>
	/// <param name="message">A custom message to include with the telemetry event.</param>
	/// <param name="properties">Optional key/value properties to attach to the telemetry.</param>
	/// <returns>The current instance for fluent configuration.</returns>
	[Information(nameof(WithTelemetry), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public PerformanceStopwatch WithTelemetry([DisallowNull] TelemetryClient telemetry, string operationName, string? message = null, IDictionary<string, string>? properties = null)
	{
		this._telemetry = telemetry.ArgumentNotNull();
		this._operationName = operationName;
		this._telemetryMessage = message;
		this._telemetryProperties = properties;

		return this;
	}

	/// <summary>
	/// Gets the threshold for performance alerts.
	/// </summary>
	[Information("AlertThreshold", "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan? AlertThreshold { get; private set; }

	/// <summary>
	/// The logged messages as a <see cref="ReadOnlyCollection{String}"/>.
	/// </summary>
	/// <example>
	/// Output:
	/// GetUsers():Load users from database. Time: 1013.02 ms
	/// GetUsers():Save users to database.Time: 1013.7925 ms
	/// </example>
	[Pure]
	[Information(nameof(StopRestart), "David McCarter", "1/18/2023", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public ReadOnlyCollection<DiagnosticEntry> Diagnostics
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return this._diagnostics.OrderBy(p => p.Timestamp).ToArray().AsReadOnly();
		}
	}

	/// <summary>
	/// Gets a value indicating whether the current elapsed time has exceeded the configured alert threshold.
	/// </summary>
	/// <value>
	/// <c>true</c> if <see cref="AlertThreshold"/> is configured (not null) and the current Elapsed
	/// time is greater than the threshold value; otherwise, <c>false</c>.
	/// </value>
	/// <remarks>
	/// This property provides a real-time check of whether the stopwatch's elapsed time has surpassed 
	/// the configured performance threshold without triggering any events or stopping the stopwatch.
	/// <para>
	/// <strong>Evaluation Logic:</strong>
	/// <list type="bullet">
	/// <item><description>Returns <c>false</c> if <see cref="AlertThreshold"/> is <c>null</c> (no threshold configured)</description></item>
	/// <item><description>Returns <c>true</c> if <see cref="AlertThreshold"/> has a value AND Elapsed is greater than that value</description></item>
	/// <item><description>The comparison uses <see cref="TimeSpan"/> greater-than operator for precise threshold checking</description></item>
	/// <item><description>Can be checked at any time - the stopwatch does NOT need to be stopped</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Relationship with Events:</strong>
	/// This property only evaluates the condition; it does NOT raise the <see cref="ThresholdExceeded"/> event.
	/// The event is raised by methods like <see cref="StopReset()"/>, <see cref="StopRestart()"/>, and 
	/// <see cref="StopIfThresholdExceeded"/> when they detect this property is <c>true</c>.
	/// </para>
	/// <para>
	/// <strong>Performance Considerations:</strong>
	/// <list type="bullet">
	/// <item><description>Very lightweight property - performs a simple null check and time comparison</description></item>
	/// <item><description>Marked with <see cref="MethodImplOptions.AggressiveInlining"/> for optimal performance</description></item>
	/// <item><description>Safe to call frequently in loops or monitoring scenarios</description></item>
	/// <item><description>Does not allocate memory or trigger any side effects</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Thread Safety:</strong>
	/// This property is thread-safe for reading. Multiple threads can check this property concurrently.
	/// However, the elapsed time may change between checks in multi-threaded scenarios.
	/// </para>
	/// <para>
	/// <strong>Use Cases:</strong>
	/// <list type="bullet">
	/// <item><description>Monitoring elapsed time in loops to implement timeout logic</description></item>
	/// <item><description>Conditional logic based on whether an operation is taking too long</description></item>
	/// <item><description>Warning users or logging when operations approach or exceed acceptable durations</description></item>
	/// <item><description>Building custom threshold handling logic without relying on events</description></item>
	/// <item><description>Displaying visual indicators (e.g., progress bars with warning states)</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <strong>Comparison with Related Members:</strong>
	/// <list type="bullet">
	/// <item><description><see cref="IsThresholdExceeded"/> - Checks if threshold exceeded (this property)</description></item>
	/// <item><description><see cref="AlertThreshold"/> - The configured threshold value</description></item>
	/// <item><description><see cref="ThresholdExceeded"/> - Event fired when threshold is exceeded during stop operations</description></item>
	/// <item><description><see cref="StopIfThresholdExceeded"/> - Conditionally stops if this property is <c>true</c></description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// Basic threshold checking in a loop:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(30),
	///     "BatchProcessing"
	/// );
	/// 
	/// foreach (var item in items)
	/// {
	///     await ProcessItem(item);
	///     
	///     // Check if we've exceeded the threshold
	///     if (stopwatch.IsThresholdExceeded)
	///     {
	///         logger.LogWarning("Processing time exceeded threshold");
	///         break; // Exit loop early
	///     }
	/// }
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Implementing warning logic:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(10),
	///     "DataProcessing"
	/// );
	/// 
	/// while (HasMoreWork())
	/// {
	///     await ProcessNextItem();
	///     
	///     // Warn when approaching threshold
	///     if (stopwatch.IsThresholdExceeded)
	///     {
	///         logger.LogWarning("Operation is taking longer than expected");
	///         // Could continue processing or take corrective action
	///     }
	/// }
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Conditional logic based on threshold:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromMilliseconds(5000),
	///     "APICall"
	/// );
	/// 
	/// var response = await CallExternalApi();
	/// 
	/// // Different handling based on whether threshold was exceeded
	/// if (stopwatch.IsThresholdExceeded)
	/// {
	///     // Slow response - log and potentially cache result
	///     logger.LogWarning("API call was slow: {Elapsed}ms", stopwatch.Elapsed.TotalMilliseconds);
	///     await CacheResult(response);
	/// }
	/// else
	/// {
	///     // Fast response - normal processing
	///     logger.LogDebug("API call completed within threshold");
	/// }
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Checking without a threshold configured:
	/// <code>
	/// // No threshold configured
	/// var stopwatch = PerformanceStopwatch.StartNew("Operation");
	/// 
	/// await PerformWork();
	/// 
	/// // Always returns false when AlertThreshold is null
	/// if (stopwatch.IsThresholdExceeded)
	/// {
	///     // This block never executes
	///     Console.WriteLine("Threshold exceeded");
	/// }
	/// else
	/// {
	///     // Always executes when no threshold is configured
	///     Console.WriteLine("No threshold configured");
	/// }
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// UI progress indicator with threshold warning:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromMinutes(5),
	///     "FileProcessing"
	/// );
	/// 
	/// // Update UI periodically
	/// var timer = new Timer(_ =>
	/// {
	///     var elapsed = stopwatch.Elapsed.TotalSeconds;
	///     progressBar.Value = (int)elapsed;
	///     
	///     // Change color if threshold exceeded
	///     if (stopwatch.IsThresholdExceeded)
	///     {
	///         progressBar.ForeColor = Color.Red;
	///         statusLabel.Text = "Processing taking longer than expected...";
	///     }
	///     else
	///     {
	///         progressBar.ForeColor = Color.Green;
	///         statusLabel.Text = $"Processing... {elapsed:F0}s";
	///     }
	/// }, null, 0, 1000);
	/// 
	/// await ProcessFiles();
	/// 
	/// timer.Dispose();
	/// stopwatch.Stop();
	/// </code>
	/// 
	/// Combining threshold check with conditional stopping:
	/// <code>
	/// var stopwatch = PerformanceStopwatch.StartNewWithAlertThreshold(
	///     TimeSpan.FromSeconds(60),
	///     "DataMigration"
	/// );
	/// 
	/// int recordsProcessed = 0;
	/// 
	/// foreach (var record in records)
	/// {
	///     await MigrateRecord(record);
	///     recordsProcessed++;
	///     
	///     // Check threshold but continue processing
	///     if (stopwatch.IsThresholdExceeded &amp;&amp; recordsProcessed % 100 == 0)
	///     {
	///         logger.LogWarning(
	///             "Migration exceeding time budget. Processed: {Count}, Elapsed: {Elapsed}s",
	///             recordsProcessed,
	///             stopwatch.Elapsed.TotalSeconds
	///         );
	///     }
	///     
	///     // Only stop if threshold significantly exceeded
	///     if (stopwatch.Elapsed > TimeSpan.FromSeconds(120))
	///     {
	///         logger.LogError("Migration timeout - stopping");
	///         break;
	///     }
	/// }
	/// 
	/// stopwatch.Stop();
	/// </code>
	/// </example>
	/// <seealso cref="AlertThreshold"/>
	/// <seealso cref="ThresholdExceeded"/>
	/// <seealso cref="StopIfThresholdExceeded"/>
	/// <seealso cref="TimeSpan"/>
	[Pure]
	[Information(nameof(IsThresholdExceeded), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public bool IsThresholdExceeded
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return this.AlertThreshold.HasValue && this.Elapsed > this.AlertThreshold.Value;
		}
	}

	/// <summary>
	/// Gets the _title for the stopwatch instance.
	/// </summary>
	[Pure]
	[Information(nameof(Title), "David McCarter", "11/11/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string Title
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
	}
}
