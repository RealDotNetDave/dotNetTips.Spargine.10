// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 07-18-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-18-2026
// ***********************************************************************
// <copyright file="HttpHandlerDiagnosticListenerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for HttpHandlerDiagnosticListener.
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core.Network;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Core.Tests.Network;

[ExcludeFromCodeCoverage]
[TestClass]
public class HttpHandlerDiagnosticListenerTests
{
	private readonly ILogger _logger = new NullLogger<HttpHandlerDiagnosticListenerTests>();

	[TestMethod]
	public void OnCompleted_Always_ThrowsNotSupportedException()
	{
		using var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://dotnettips.com");
		var listener = new HttpHandlerDiagnosticListener(this._logger);

		_ = Assert.ThrowsExactly<NotSupportedException>(() => listener.OnCompleted());
	}

	[TestMethod]
	public void OnError_Always_ThrowsNotSupportedException()
	{
		using var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://dotnettips.com");
		var listener = new HttpHandlerDiagnosticListener(this._logger);

		_ = Assert.ThrowsExactly<NotSupportedException>(() => listener.OnError(new InvalidOperationException("Test exception.")));
	}

	[TestMethod]
	public void OnNext_WithRequestOutStartEvent_DoesNotThrow()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dotnettips.com");
		var listener = new HttpHandlerDiagnosticListener(this._logger);
		var payload = CreateRequestStartPayload(request);

		listener.OnNext(new KeyValuePair<string, object>("System.Net.Http.HttpRequestOut.Start", payload));
	}

	[TestMethod]
	public void OnNext_WithRequestOutStopEvent_DoesNotThrow()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dotnettips.com");
		using var response = new HttpResponseMessage(HttpStatusCode.OK) { RequestMessage = request };
		var listener = new HttpHandlerDiagnosticListener(this._logger);
		var payload = CreateRequestStopPayload(response, request);

		listener.OnNext(new KeyValuePair<string, object>("System.Net.Http.HttpRequestOut.Stop", payload));
	}

	[TestMethod]
	public void OnNext_WithUnhandledEvent_DoesNotThrow()
	{
		var listener = new HttpHandlerDiagnosticListener(this._logger);

		listener.OnNext(new KeyValuePair<string, object>("Unhandled.Http.Event", new object()));
	}

	private static object CreateRequestStartPayload(HttpRequestMessage request)
	{
		var payloadType = Type.GetType("System.Net.Http.DiagnosticsHandler+ActivityStartData, System.Net.Http", throwOnError: true);
		Assert.IsNotNull(payloadType);

		var constructor = payloadType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, [typeof(HttpRequestMessage)], null);
		Assert.IsNotNull(constructor);

		return constructor.Invoke([request]);
	}

	private static object CreateRequestStopPayload(HttpResponseMessage response, HttpRequestMessage request)
	{
		var payloadType = Type.GetType("System.Net.Http.DiagnosticsHandler+ActivityStopData, System.Net.Http", throwOnError: true);
		Assert.IsNotNull(payloadType);

		var constructor = payloadType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, [typeof(HttpResponseMessage), typeof(HttpRequestMessage), typeof(TaskStatus)], null);
		Assert.IsNotNull(constructor);

		return constructor.Invoke([response, request, TaskStatus.RanToCompletion]);
	}
}
