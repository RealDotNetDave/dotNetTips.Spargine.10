// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-28-2026
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

	[TestMethod]
	public void AllServicesReturnsNonEmptyCollection()
	{
		var services = ServiceHelper.AllServices();

		Assert.IsNotNull(services);
		Assert.IsNotEmpty(services);
		Assert.Contains(ExistingServiceName, services);
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
	public void IsProcessRunningEmptyProcessNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.IsProcessRunning(string.Empty));
	}

	// ── KillProcess ───────────────────────────────────────────────────

	[TestMethod]
	public void KillProcessNullProcessNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.KillProcess(null!));
	}

	[TestMethod]
	public void KillProcessEmptyProcessNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.KillProcess(string.Empty));
	}

	[TestMethod]
	public void KillProcessNonExistingProcessDoesNotThrow()
	{
		ServiceHelper.KillProcess("FakeProcess123");
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
	public void ServiceExistsEmptyServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.ServiceExists(string.Empty));
	}

	// ── ServiceStatus ─────────────────────────────────────────────────

	[TestMethod]
	public void ServiceStatusExistingServiceReturnsValidStatus()
	{
		var status = ServiceHelper.ServiceStatus(ExistingServiceName);
		Assert.IsTrue(Enum.IsDefined(typeof(ServiceControllerStatus), status));
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
	public void ServiceStatusEmptyServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.ServiceStatus(string.Empty));
	}

	// ── StartService ──────────────────────────────────────────────────

	[TestMethod]
	public void StartServiceNonExistingServiceReturnsNotFound()
	{
		var result = ServiceHelper.StartService(NonExistingServiceName);
		Assert.AreEqual(ServiceActionResult.NotFound, result);
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

	[TestMethod]
	public void StartServiceNullServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StartService(null!));
	}

	[TestMethod]
	public void StartServiceEmptyServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StartService(string.Empty));
	}

	// ── StartServices ─────────────────────────────────────────────────

	[TestMethod]
	public void StartServicesNonExistingServicesDoesNotThrow()
	{
		var services = new List<string> { NonExistingServiceName, "AnotherFakeService456" };

		ServiceHelper.StartServices(services);
	}

	[TestMethod]
	public void StartServicesEmptyCollectionDoesNotThrow()
	{
		ServiceHelper.StartServices(new List<string>());
	}

	[TestMethod]
	public void StartServicesNullCollectionThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StartServices(null!));
	}

	// ── StartStopServices ─────────────────────────────────────────────

	[TestMethod]
	public void StartStopServicesEmptyCollectionDoesNotThrow()
	{
		ServiceHelper.StartStopServices(new List<ServiceAction>());
	}

	[TestMethod]
	public void StartStopServicesDefaultRequestDoesNotThrow()
	{
		// ServiceAction properties default to Unknown request; method should skip unknown requests.
		var requests = new List<ServiceAction> { new() };

		ServiceHelper.StartStopServices(requests);

		Assert.AreEqual(default(ServiceActionResult), requests[0].ServiceActionResult);
	}

	[TestMethod]
	public void StartStopServicesNullCollectionThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StartStopServices(null!));
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
	public void StopServiceEmptyServiceNameThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StopService(string.Empty));
	}

	// ── StopServices ──────────────────────────────────────────────────

	[TestMethod]
	public void StopServicesNonExistingServicesDoesNotThrow()
	{
		var services = new List<string> { NonExistingServiceName, "AnotherFakeService456" };

		ServiceHelper.StopServices(services);
	}

	[TestMethod]
	public void StopServicesEmptyCollectionDoesNotThrow()
	{
		ServiceHelper.StopServices(new List<string>());
	}

	[TestMethod]
	public void StopServicesNullCollectionThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => ServiceHelper.StopServices(null!));
	}
}
