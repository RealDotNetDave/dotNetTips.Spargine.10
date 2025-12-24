// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : David McCarter
// Last Modified On : 02-23-2025
// ***********************************************************************
// <copyright file="TempFileManagerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
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
	public void AllServices_ReturnsNonEmptyCollection()
	{
		var services = ServiceHelper.AllServices();

		Assert.IsNotNull(services);
		Assert.IsTrue(services.Count > 0);
		Assert.IsTrue(services.Contains(ExistingServiceName));
	}

	[TestMethod]
	public void IsProcessRunning_ExistingProcess_ReturnsTrue()
	{
		var result = ServiceHelper.IsProcessRunning(RunningProcessName);

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsProcessRunning_NonExistingProcess_ReturnsFalse()
	{
		var result = ServiceHelper.IsProcessRunning("FakeProcess123");
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ServiceExists_ExistingService_ReturnsTrue()
	{
		var result = ServiceHelper.ServiceExists(ExistingServiceName);
		Assert.IsTrue(result);
	}

	[TestMethod]
	public void ServiceExists_NonExistingService_ReturnsFalse()
	{
		var result = ServiceHelper.ServiceExists(NonExistingServiceName);
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void ServiceStatus_ExistingService_ReturnsValidStatus()
	{
		var status = ServiceHelper.ServiceStatus(ExistingServiceName);
		Assert.IsTrue(Enum.IsDefined(typeof(ServiceControllerStatus), status));
	}

	[TestMethod]
	public void ServiceStatus_NonExistingService_ThrowsInvalidOperationException()
	{
		Assert.ThrowsExactly<InvalidOperationException>(() => ServiceHelper.ServiceStatus(NonExistingServiceName));
	}

	[TestMethod]
	public void StartService_NonExistingService_ReturnsNotFound()
	{
		var result = ServiceHelper.StartService(NonExistingServiceName);
		Assert.AreEqual(ServiceActionResult.NotFound, result);
	}

	[TestMethod]
	public void StopService_NonExistingService_ReturnsNotFound()
	{
		var result = ServiceHelper.StopService(NonExistingServiceName);
		Assert.AreEqual(ServiceActionResult.NotFound, result);
	}


	// KillProcess is not tested to avoid terminating system processes.
}
