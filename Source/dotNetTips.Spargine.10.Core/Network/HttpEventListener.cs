// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-18-2026
// ***********************************************************************
// <copyright file="HttpEventListener.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Listens and logs messages from HTTP events, capturing events such as request start and stop. This functionality facilitates comprehensive monitoring and logging of HTTP-related activities.
// Orginal code by:
// https:www.meziantou.net/observing-all-http-requests-in-a-dotnet-application.htm
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Logging;
using DotNetTips.Spargine.Core.Properties;
using Microsoft.Extensions.Logging;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Provides a mechanism to listen to and log HTTP events, facilitating comprehensive monitoring and logging of HTTP-related activities within an application.
/// This class captures events such as HTTP request start and stop, providing insights into the HTTP traffic that occurs during the application's runtime.
/// </summary>
/// <remarks>
/// This class is sealed to prevent inheritance, ensuring that the behavior defined here is consistent and not altered through subclassing.
/// The functionality is based on the <see cref="EventListener"/> class, leveraging event sources for HTTP activities.
/// </remarks>
/// <example>
/// Usage example:
/// <code>
/// using (var logger = new LoggerFactory().CreateLogger("HttpLogger"))
/// {
///     using var listener = new HttpEventListener(logger);
///     // Perform HTTP operations...
/// }
/// </code>
/// </example>
/// <seealso cref="EventListener"/>
[Information(nameof(HttpEventListener), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation ="ADD URL")]
public sealed class HttpEventListener(ILogger logger) : EventListener
{

	/// <summary>
	/// Logs a message to the configured logger and writes the message to the system diagnostic trace.
	/// This method is intended for internal use within the <see cref="HttpEventListener"/> class to log HTTP event information.
	/// </summary>
	/// <param name="message">The message to be logged. It should contain information about the HTTP event being processed.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void LogMessage(string message)
	{
		logger?.LogInformationMessage(message);

		Trace.WriteLine(message);
	}

	/// <summary>
	/// Called for all existing event sources when the event listener is created and when a new event source is attached to the listener.
	/// This method ensures that events from specific sources, particularly those related to HTTP activities, are captured and logged.
	/// </summary>
	/// <param name="eventSource">The event source to be processed. This parameter is validated to ensure it is not null.</param>
	protected override void OnEventSourceCreated([DisallowNull] EventSource eventSource)
	{
		eventSource = eventSource.ArgumentNotNull();

		const EventKeywords TasksFlowActivityIds = (EventKeywords)0x80;

		switch (eventSource.Name)
		{
			case "System.Net.Http":
				this.EnableEvents(eventSource, EventLevel.Informational, EventKeywords.All);
				break;

			// Enable EventWrittenEventArgs.ActivityId to correlate Start and Stop events
			case "System.Threading.Tasks.TplEventSource":

				this.EnableEvents(eventSource, EventLevel.LogAlways, TasksFlowActivityIds);
				break;
			default:
				break;
		}

		base.OnEventSourceCreated(eventSource);
	}

	/// <summary>
	/// Called whenever an event has been written by an event source for which the event listener has enabled events.
	/// This method processes HTTP request start and stop events and ignores all unrelated events.
	/// </summary>
	/// <param name="eventData">The event arguments that describe the event. This includes details such as the event ID and payload.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="eventData"/> is null, ensuring that event processing does not proceed with null event data.</exception>
	protected override void OnEventWritten([DisallowNull] EventWrittenEventArgs eventData)
	{
		eventData = eventData.ArgumentNotNull();

		if (eventData.EventSource.Name != "System.Net.Http")
		{
			return;
		}

		if (string.Equals(eventData.EventName, "RequestStart", StringComparison.Ordinal))
		{
			this.LogRequestStart(eventData);
			return;
		}

		if (IsHandledHttpEvent(eventData.EventName))
		{
			this.LogMessage($"HTTP {eventData.EventName}: {eventData.ActivityId}");
			return;
		}

		this.LogMessage($"HTTP Unhandled Event: ID={eventData.EventId}, Name={eventData.EventName ?? "(null)"}, Source={eventData.EventSource.Name}, PayloadCount={eventData.Payload?.Count ?? 0}");
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsHandledHttpEvent(string? eventName) => eventName switch
	{
		"RequestStop" => true,
		"RequestLeftQueue" => true,
		"RequestFailed" => true,
		"ConnectionEstablished" => true,
		"ConnectionClosed" => true,
		"RequestHeadersStart" => true,
		"RequestHeadersStop" => true,
		"ResponseHeadersStart" => true,
		"ResponseHeadersStop" => true,
		"RequestContentStart" => true,
		"RequestContentStop" => true,
		"ResponseContentStart" => true,
		"ResponseContentStop" => true,
		_ => false,
	};

	private void LogRequestStart(EventWrittenEventArgs eventData)
	{
		if (eventData.Payload is null || eventData.Payload.Count < 7)
		{
			this.LogMessage(Resources.EventDataPayloadIsNullOrDoesNotContainTheExpectedNumberOfElements);
			return;
		}

		var scheme = eventData.Payload[0] as string ?? string.Empty;
		var host = eventData.Payload[1] as string ?? string.Empty;
		var port = eventData.Payload[2] as int? ?? 0;
		var pathAndQuery = eventData.Payload[3] as string ?? string.Empty;
		var versionMajor = eventData.Payload[4] as byte? ?? 0;
		var versionMinor = eventData.Payload[5] as byte? ?? 0;
		var policy = eventData.Payload[6] as HttpVersionPolicy? ?? HttpVersionPolicy.RequestVersionOrHigher;

		this.LogMessage($"HTTP {eventData.EventName}: {eventData.ActivityId} {scheme}://{host}:{port}{pathAndQuery} HTTP/{versionMajor}.{versionMinor} POLICY: {policy}");
	}
}
