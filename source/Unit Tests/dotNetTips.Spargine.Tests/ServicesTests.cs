// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-02-2026
// ***********************************************************************
// <copyright file="ServicesTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.ServiceProcess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ServicesTests
{
	private const string ExistingServiceName = "EventLog"; // Common Windows service
	private const string NonExistingServiceName = "FakeService123";
	private const string RunningProcessName = "explorer"; // Common Windows process

	// ── Dispose regression (suggestion 7 fix) ────────────────────────
	// These tests exercise the public APIs in a tight loop to verify that
	// ServiceController handles are properly disposed after each call.
	// If disposal were missing the OS handle table would exhaust, causing
	// an exception before the loop completes.

	[TestMethod]
	public void AllServices_RepeatedCalls_DoNotLeakHandles()
	{
		for (var iteration = 0; iteration < 10; iteration++)
		{
			var services = ServiceHelper.AllServices();
			Assert.IsTrue(services.Count > 0);
		}
	}

	[TestMethod]
	public void AllServicesReturnsNonEmptyCollection()
	{
		var services = ServiceHelper.AllServices();

		Assert.IsNotNull(services);
		Assert.IsNotEmpty(services);
		Assert.Contains(ExistingServiceName, services);
	}

	[TestMethod]
	public void IsProcessRunningEmptyProcessNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.IsProcessRunning(string.Empty));
	}

	// ── IsProcessRunning ──────────────────────────────────────────────

	[TestMethod]
	public void IsProcessRunningExistingProcessReturnsTrue()
	{
		var result = ServiceHelper.IsProcessRunning(RunningProcessName);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsProcessRunningNonExistingProcessReturnsFalse()
	{
		var result = ServiceHelper.IsProcessRunning("FakeProcess123");
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsProcessRunningNullProcessNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.IsProcessRunning(null!));
	}

	[TestMethod]
	public void KillProcessEmptyProcessNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.KillProcess(string.Empty));
	}

	[TestMethod]
	public void KillProcessNonExistingProcessDoesNotThrow()
	{
		const string processName = "FakeProcess123";

		Assert.IsFalse(ServiceHelper.IsProcessRunning(processName), "Precondition failed: fake process should not be running.");

		ServiceHelper.KillProcess(processName);

		Assert.IsFalse(ServiceHelper.IsProcessRunning(processName), "Killing a non-existing process should not change process state.");
	}

	// ── KillProcess ───────────────────────────────────────────────────

	[TestMethod]
	public void KillProcessNullProcessNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.KillProcess(null!));
	}

	[TestMethod]
	public void ServiceExists_RepeatedCallsExistingService_DoNotLeakHandles()
	{
		for (var iteration = 0; iteration < 10; iteration++)
		{
			Assert.IsTrue(ServiceHelper.ServiceExists(ExistingServiceName));
		}
	}

	[TestMethod]
	public void ServiceExists_RepeatedCallsNonExistingService_DoNotLeakHandles()
	{
		for (var iteration = 0; iteration < 10; iteration++)
		{
			Assert.IsFalse(ServiceHelper.ServiceExists(NonExistingServiceName));
		}
	}

	[TestMethod]
	public void ServiceExistsEmptyServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.ServiceExists(string.Empty));
	}

	// ── ServiceExists ─────────────────────────────────────────────────

	[TestMethod]
	public void ServiceExistsExistingServiceReturnsTrue()
	{
		var result = ServiceHelper.ServiceExists(ExistingServiceName);
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ServiceExistsNonExistingServiceReturnsFalse()
	{
		var result = ServiceHelper.ServiceExists(NonExistingServiceName);
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ServiceExistsNullServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.ServiceExists(null!));
	}

	[TestMethod]
	public void ServiceStatus_RepeatedCallsExistingService_DoNotLeakHandles()
	{
		for (var iteration = 0; iteration < 10; iteration++)
		{
			var status = ServiceHelper.ServiceStatus(ExistingServiceName);
			Assert.IsTrue(Enum.IsDefined(status));
		}
	}

	[TestMethod]
	public void ServiceStatusEmptyServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.ServiceStatus(string.Empty));
	}

	[TestMethod]
	public void ServiceStatusExistingRunningServiceReturnsRunning()
	{
		var runningSvc = ServiceController.GetServices()
			.FirstOrDefault(s => s.Status == ServiceControllerStatus.Running);

		if (runningSvc is null)
		{
			Assert.Inconclusive("No running services found on this machine.");
		}

		var status = ServiceHelper.ServiceStatus(runningSvc.ServiceName);
		Assert.AreEqual(ServiceControllerStatus.Running, status);
	}

	// ── ServiceStatus ─────────────────────────────────────────────────

	[TestMethod]
	public void ServiceStatusExistingServiceReturnsValidStatus()
	{
		var status = ServiceHelper.ServiceStatus(ExistingServiceName);
		Assert.IsTrue(Enum.IsDefined(typeof(ServiceControllerStatus), status));
	}

	[TestMethod]
	public void ServiceStatusNonExistingServiceThrowsInvalidOperationException()
	{
		Assert.ThrowsExactly<InvalidOperationException>(() => ServiceHelper.ServiceStatus(NonExistingServiceName));
	}

	[TestMethod]
	public void ServiceStatusNullServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.ServiceStatus(null!));
	}

	[TestMethod]
	public void StartService_RepeatedCallsNonExistingService_DoNotLeakHandles()
	{
		for (var iteration = 0; iteration < 10; iteration++)
		{
			var result = ServiceHelper.StartService(NonExistingServiceName);
			Assert.AreEqual(ServiceActionResult.NotFound, result);
		}
	}

	// ── Double-call regression (suggestion 6 fix) ─────────────────────
	// These tests verify that calling StartService/StopService twice in a row
	// with a non-existent service name returns NotFound both times, proving that
	// a single LoadService() call (rather than ServiceExists() + LoadService())
	// does not corrupt any state between calls.

	[TestMethod]
	public void StartService_RepeatedCallsNonExistingService_ReturnNotFoundBothTimes()
	{
		var resultFirst = ServiceHelper.StartService(NonExistingServiceName);
		var resultSecond = ServiceHelper.StartService(NonExistingServiceName);

		Assert.AreEqual(ServiceActionResult.NotFound, resultFirst, "First call must return NotFound.");
		Assert.AreEqual(ServiceActionResult.NotFound, resultSecond, "Second call must return NotFound — no state corruption between calls.");
	}

	[TestMethod]
	public void StartServiceEmptyServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StartService(string.Empty));
	}

	[TestMethod]
	public void StartServiceExistingRunningServiceReturnsError()
	{
		var runningSvc = ServiceController.GetServices()
			.FirstOrDefault(s => s.Status == ServiceControllerStatus.Running);

		if (runningSvc is null)
		{
			Assert.Inconclusive("No running services found on this machine.");
		}

		var result = ServiceHelper.StartService(runningSvc.ServiceName);
		Assert.AreEqual(ServiceActionResult.Error, result);
	}

	// ── StartService ──────────────────────────────────────────────────

	[TestMethod]
	public void StartServiceNonExistingServiceReturnsNotFound()
	{
		var result = ServiceHelper.StartService(NonExistingServiceName);
		Assert.AreEqual(ServiceActionResult.NotFound, result);
	}

	[TestMethod]
	public void StartServiceNullServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StartService(null!));
	}

	[TestMethod]
	public void StartServicesEmptyCollectionDoesNotThrow()
	{
		var services = new List<string>();

		ServiceHelper.StartServices(services);

		Assert.IsEmpty(services);
	}

	// ── StartServices ─────────────────────────────────────────────────

	[TestMethod]
	public void StartServicesNonExistingServicesDoesNotThrow()
	{
		var services = new List<string> { NonExistingServiceName, "AnotherFakeService456" };

		foreach (var service in services)
		{
			Assert.IsFalse(ServiceHelper.ServiceExists(service), $"Precondition failed: service '{service}' should not exist.");
		}

		ServiceHelper.StartServices(services);

		foreach (var service in services)
		{
			Assert.IsFalse(ServiceHelper.ServiceExists(service), $"Starting a non-existing service should not create service '{service}'.");
		}
	}

	[TestMethod]
	public void StartServicesNullCollectionThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StartServices(null!));
	}

	[TestMethod]
	public void StartStopServicesDefaultRequestDoesNotThrow()
	{
		// ServiceAction properties default to Unknown request; method should skip unknown requests.
		var requests = new List<ServiceAction> { new() };

		ServiceHelper.StartStopServices(requests);

		Assert.AreEqual(default(ServiceActionResult), requests[0].ServiceActionResult);
	}

	// ── StartStopServices ─────────────────────────────────────────────

	[TestMethod]
	public void StartStopServicesEmptyCollectionDoesNotThrow()
	{
		var requests = new List<ServiceAction>();

		ServiceHelper.StartStopServices(requests);

		Assert.IsEmpty(requests);
	}

	[TestMethod]
	public void StartStopServicesNullCollectionThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StartStopServices(null!));
	}

	[TestMethod]
	public void StopService_RepeatedCallsNonExistingService_DoNotLeakHandles()
	{
		for (var iteration = 0; iteration < 10; iteration++)
		{
			var result = ServiceHelper.StopService(NonExistingServiceName);
			Assert.AreEqual(ServiceActionResult.NotFound, result);
		}
	}

	[TestMethod]
	public void StopService_RepeatedCallsNonExistingService_ReturnNotFoundBothTimes()
	{
		var resultFirst = ServiceHelper.StopService(NonExistingServiceName);
		var resultSecond = ServiceHelper.StopService(NonExistingServiceName);

		Assert.AreEqual(ServiceActionResult.NotFound, resultFirst, "First call must return NotFound.");
		Assert.AreEqual(ServiceActionResult.NotFound, resultSecond, "Second call must return NotFound — no state corruption between calls.");
	}

	[TestMethod]
	public void StopServiceEmptyServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StopService(string.Empty));
	}

	// ── StopService ───────────────────────────────────────────────────

	[TestMethod]
	public void StopServiceNonExistingServiceReturnsNotFound()
	{
		var result = ServiceHelper.StopService(NonExistingServiceName);
		Assert.AreEqual(ServiceActionResult.NotFound, result);
	}

	[TestMethod]
	public void StopServiceNullServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StopService(null!));
	}

	[TestMethod]
	public void StopServicesEmptyCollectionDoesNotThrow()
	{
		var services = new List<string>();

		ServiceHelper.StopServices(services);

		Assert.IsEmpty(services);
	}

	// ── StopServices ──────────────────────────────────────────────────

	[TestMethod]
	public void StopServicesNonExistingServicesDoesNotThrow()
	{
		var services = new List<string> { NonExistingServiceName, "AnotherFakeService456" };

		foreach (var service in services)
		{
			Assert.IsFalse(ServiceHelper.ServiceExists(service), $"Precondition failed: service '{service}' should not exist.");
		}

		ServiceHelper.StopServices(services);

		foreach (var service in services)
		{
			Assert.IsFalse(ServiceHelper.ServiceExists(service), $"Stopping a non-existing service should not create service '{service}'.");
		}
	}

	[TestMethod]
	public void StopServicesNullCollectionThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StopServices(null!));
	}
}
