// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 07-11-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-18-2026
// ***********************************************************************
// <copyright file="HttpRequestsObserver.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Observes the HttpRequestMessage/HttpResponseMessage instances, offering a valuable method to retrieve information such as request headers or the response status code.
// Original code by:
// https:www.meziantou.net/observing-all-http-requests-in-a-dotnet-application.htm
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Network;

/// <summary>
/// Observes and subscribes to <see cref="DiagnosticListener"/> instances specifically for HTTP request and response diagnostic events.
/// This observer allows for monitoring and logging of HTTP traffic, providing insights into HttpRequestMessage and HttpResponseMessage activities.
/// </summary>
/// <remarks>
/// This class implements <see cref="IDisposable"/> and <see cref="IObserver{DiagnosticListener}"/>, subscribing to diagnostic events that match the "HttpHandlerDiagnosticListener".
/// When such an event is observed, it creates and subscribes an instance of <see cref="HttpHandlerDiagnosticListener"/> to further process these HTTP events.
/// </remarks>
/// <example>
/// Usage example:
/// <code>
/// var logger = new LoggerFactory().CreateLogger("HttpLogger");
/// using var observer = new HttpRequestsObserver(logger);
/// // Assuming a DiagnosticListener is published somewhere in the application that matches "HttpHandlerDiagnosticListener"
/// </code>
/// </example>
/// <param name="logger">The logger used for logging information about the HTTP requests and responses.</param>
[Information(nameof(HttpRequestsObserver), Status = Status.Available, Documentation = "ADD URL")]
public sealed class HttpRequestsObserver(ILogger logger) : IDisposable, IObserver<DiagnosticListener>
{

	/// <summary>
	/// Indicates whether the object has been disposed, preventing any further operations once disposed.
	/// </summary>
	private bool _disposed;

	/// <summary>
	/// Holds the subscription to the diagnostic listener. This field is used to manage the lifetime of the subscription,
	/// allowing the observer to unsubscribe when it is disposed.
	/// </summary>
	private IDisposable? _subscription;

	/// <summary>
	/// Finalizes an instance of the <see cref="HttpRequestsObserver" /> class.
	/// </summary>
	~HttpRequestsObserver() => this.Dispose(false);

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	[Preserve(PreserveReason.MethodPartOfIDisposable, "4/16/2023", "David McCarter")]
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	public void Dispose(bool disposing)
	{
		if (this._disposed)
		{
			return;
		}

		if (disposing)
		{
			this._subscription?.Dispose();
		}

		this._disposed = true;
	}

	/// <summary>
	/// Logs a message to the configured logger and writes the message to the system diagnostic trace.
	/// </summary>
	/// <param name="message">The message to log.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void LogMessage(string message)
	{
		logger?.LogInformationMessage(message);

		Debug.WriteLine("TEST:" + message);

		Trace.WriteLine(message);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void LogNotification(string? details = null, [CallerMemberName] string? memberName = null)
	{
		if (string.IsNullOrEmpty(details))
		{
			this.LogMessage(memberName ?? ControlChars.EmptyString);
			return;
		}

		this.LogMessage(string.Concat(memberName ?? ControlChars.EmptyString, details));
	}

	/// <summary>
	/// Notifies the observer that the provider has finished sending push-based notifications.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void OnCompleted() => this.LogNotification();

	/// <summary>
	/// Notifies the observer that the provider has experienced an error condition.
	/// </summary>
	/// <param name="error">An object that provides additional information about the error.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void OnError(Exception error)
	{
		error = error.ArgumentNotNull();

		this.LogNotification(error.Message);
	}

	/// <summary>
	/// Provides the observer with new data by subscribing to the specified <see cref="DiagnosticListener"/>.
	/// </summary>
	/// <param name="value">The <see cref="DiagnosticListener"/> instance to observe.</param>
	public void OnNext([DisallowNull] DiagnosticListener value)
	{
		value = value.ArgumentNotNull();

		switch (value.Name)
		{
			case nameof(HttpHandlerDiagnosticListener):
				Debug.Assert(this._subscription == null);

				this._subscription = value.Subscribe(new HttpHandlerDiagnosticListener(logger)!);
				this.LogMessage($"HTTP Diagnostic Listener: {value.Name} subscribed.");
				break;

			default:
				this.LogMessage($"HTTP Diagnostic Listener Unhandled: {value.Name}");
				break;
		}
	}
}
