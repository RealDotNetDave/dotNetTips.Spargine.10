// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2025
// ***********************************************************************
// <copyright file="ServiceHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Convenient helper methods for seamless management of Windows requests, offering key features such as loading a service, checking its running status, starting and stopping requests, and more.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.ServiceProcess;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine;

/// <summary>
/// Provides a collection of methods for managing and interacting with Windows requests and processes.
/// This includes functionality to load, start, stop requests, check service existence, and process status.
/// </summary>
/// <remarks>
/// This class is designed to be used in Windows environments where service management is required. It offers a simplified interface
/// for common service operations such as starting, stopping, and checking the status of requests. Additionally, it provides methods
/// for process management, including checking if a process is running and killing processes. This class is part of the DotNetTips.Spargine
/// library, which provides a wide range of utilities and helper methods for .NET developers.
/// </remarks>
[SupportedOSPlatform("windows")]
[Information(Status = Status.UpdateDocumentation, Documentation = "ADD URL")]
public static class ServiceHelper
{
	/// <summary>
	/// Loads the service specified by the service name.
	/// </summary>
	/// <param name="serviceName">The name of the service to load.</param>
	/// <returns>A ServiceController object for the specified service.</returns>
	/// <example>
	/// Here is how you can use the LoadService method:
	/// <code>
	/// var serviceName = "YourServiceName";
	/// var serviceController = ServiceHelper.LoadService(serviceName);
	/// if(serviceController != null)
	/// {
	///     Console.WriteLine($"Service {serviceName} is loaded.");
	/// }
	/// else
	/// {
	///     Console.WriteLine($"Service {serviceName} could not be found.");
	/// }
	/// </code>
	/// </example>
	[Information(nameof(LoadService), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	private static ServiceController? LoadService([DisallowNull] string serviceName)
	{
		return Array.Find(ServiceController.GetServices(), p => string.Equals(p.ServiceName, serviceName, StringComparison.Ordinal));
	}

	/// <summary>
	/// Starts all services that the specified service depends on, if requested.
	/// </summary>
	/// <param name="services">
	/// The <see cref="ServiceController"/>s representing the service whose dependencies should be started.
	/// If <c>null</c>, no action is taken.
	/// </param>
	/// <remarks>
	/// This method iterates through the <see cref="ServiceController.ServicesDependedOn"/> collection of the specified service.
	/// For each dependent service that is not currently running, it attempts to start the service.
	/// </remarks>
	private static void StartDependentServices(ServiceController[] services)
	{
		foreach (var serviceDependsOn in services!)
		{
			if (serviceDependsOn.Status != ServiceControllerStatus.Running)
			{
				serviceDependsOn.Start();
			}
		}
	}

	/// <summary>
	/// Stops all services in the specified array if they are currently running.
	/// </summary>
	/// <param name="services">
	/// An array of <see cref="ServiceController"/> objects representing the services to stop.
	/// If <c>null</c> or empty, no action is taken.
	/// </param>
	/// <remarks>
	/// This method iterates through the provided <paramref name="services"/> array.
	/// For each service that is not currently stopped, it attempts to stop the service.
	/// </remarks>
	private static void StopDependentServices(ServiceController[] services)
	{
		foreach (var serviceDependsOn in services!)
		{
			if (serviceDependsOn.Status != ServiceControllerStatus.Stopped)
			{
				serviceDependsOn.Stop();
			}
		}
	}

	/// <summary>
	/// Retrieves the names of all requests installed on the system.
	/// </summary>
	/// <returns>A read-only collection of strings containing the names of all requests.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AllServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ReadOnlyCollection<string> AllServices()
	{
		return ServiceController.GetServices().Select(p => p.ServiceName).ToReadOnlyCollection();
	}

	/// <summary>
	/// Determines whether the specified process is already running.
	/// </summary>
	/// <param name="processName">Name of the process.</param>
	/// <returns><c>true</c> if the specified process is running; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the IsProcessRunning method:
	/// <code>
	/// var processName = "notepad";
	/// var isRunning = ServiceHelper.IsProcessRunning(processName);
	/// Console.WriteLine($"{processName} is running: {isRunning}");
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsProcessRunning([DisallowNull] string processName)
	{
		processName = processName.ArgumentNotNullOrEmpty();

		return Process.GetProcessesByName(processName).Length > 0;
	}

	/// <summary>
	/// Kills the specified process by name. If multiple processes with the same name exist, only the first found is killed.
	/// </summary>
	/// <param name="processName">The name of the process to kill. This must not be null or empty.</param>
	/// <param name="waitForExitMilliseconds">The number of milliseconds to wait for the process to exit after being killed. Default is 6000 ms.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="processName"/> is null or empty.</exception>
	/// <remarks>
	/// This method finds the first process with the specified name and attempts to kill it. 
	/// If the process is found, it is killed and the method waits for the process to exit for the specified time.
	/// If no process is found, the method does nothing.
	/// </remarks>
	/// <example>
	/// <code>
	/// var processName = "notepad";
	/// ServiceHelper.KillProcess(processName);
	/// Console.WriteLine($"{processName} has been killed.");
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static void KillProcess([DisallowNull] string processName, int waitForExitMilliseconds = 6000)
	{
		var app = Process.GetProcessesByName(processName.ArgumentNotNullOrEmpty()).FirstOrDefault();

		if (app is not null)
		{
			app.Kill();
			_ = app.WaitForExit(milliseconds: waitForExitMilliseconds);
		}
	}

	/// <summary>
	/// Checks if the specified service exists on the system.
	/// </summary>
	/// <param name="serviceName">The name of the service to check.</param>
	/// <returns><c>true</c> if the service exists; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the ServiceExists method:
	/// <code>
	/// var serviceName = "MSSQLSERVER";
	/// var exists = ServiceHelper.ServiceExists(serviceName);
	/// Console.WriteLine($"Service exists: {exists}");
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ServiceExists), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static bool ServiceExists([DisallowNull] string serviceName)
	{
		var service = LoadService(serviceName.ArgumentNotNullOrEmpty());

		return service is not null;
	}

	/// <summary>
	/// Gets the current status of the specified service.
	/// </summary>
	/// <param name="serviceName">The name of the service.</param>
	/// <returns>The current status of the service.</returns>
	/// <exception cref="InvalidOperationException">Thrown when the service is not found.</exception>
	/// <example>
	/// Here is how you can use the ServiceStatus method:
	/// <code>
	/// var serviceName = "MSSQLSERVER";
	/// var status = ServiceHelper.ServiceStatus(serviceName);
	/// Console.WriteLine($"Service status: {status}");
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ServiceStatus), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceControllerStatus ServiceStatus([DisallowNull] string serviceName)
	{
		var service = LoadService(serviceName.ArgumentNotNullOrEmpty());

		return service is not null ? service.Status : throw new InvalidOperationException(Resources.ServiceNotFound);
	}

	/// <summary>
	/// Starts the specified Windows service.
	/// </summary>
	/// <param name="serviceName">The name of the service to start.</param>
	/// <param name="startServicesDependedOn">
	/// If <c>true</c>, starts all services that the specified service depends on before starting the service itself.
	/// </param>
	/// <param name="startDependingServices">
	/// If <c>true</c>, starts all services that depend on the specified service after starting the service.
	/// </param>
	/// <returns>
	/// A <see cref="ServiceActionResult"/> indicating the result of the operation:
	/// <list type="bullet">
	/// <item><see cref="ServiceActionResult.Running"/> if the service was started successfully.</item>
	/// <item><see cref="ServiceActionResult.NotFound"/> if the service does not exist.</item>
	/// <item><see cref="ServiceActionResult.Error"/> if an error occurred or the service could not be started.</item>
	/// </list>
	/// </returns>
	/// <example>
	/// <code>
	/// var result = ServiceHelper.StartService("W32Time", true, false);
	/// if (result == ServiceActionResult.Running)
	/// {
	///     Console.WriteLine("Service started successfully.");
	/// }
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StartService), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceActionResult StartService([DisallowNull] string serviceName, bool startServicesDependedOn = false, bool startDependingServices = false)
	{
		serviceName = serviceName.ArgumentNotNullOrEmpty();

		var statusResult = ServiceActionResult.Error;

		if (ServiceExists(serviceName) is false)
		{
			return ServiceActionResult.NotFound;
		}

		var service = LoadService(serviceName);

		if (service is not null && service.Status == ServiceControllerStatus.Stopped)
		{
			// First start any services that this service depends on.
			if (startServicesDependedOn)
			{
				StartDependentServices(service.ServicesDependedOn);
			}

			service.Start();
			statusResult = ServiceActionResult.Running;

			// Start any services that depends on this service.
			if (startDependingServices)
			{
				StartDependentServices(service.DependentServices);
			}
		}

		return statusResult;
	}

	/// <summary>
	/// Starts the specified Windows services by name.
	/// </summary>
	/// <param name="requests">A collection of service names to start. Each string should be the name of a service installed on the system.</param>
	/// <remarks>
	/// This method iterates through the provided collection and attempts to start each service by name.
	/// If a service is not found or cannot be started, its result is not reported.
	/// </remarks>
	/// <example>
	/// <code>
	/// var serviceNames = new[] { "MSSQLSERVER", "W32Time" };
	/// ServiceHelper.StartServices(serviceNames);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StartServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StartServices([DisallowNull] in IEnumerable<string> requests)
	{
		requests.ToList().ForEach(request => StartService(request));
	}

	/// <summary>
	/// Starts or stops the specified requests based on the <see cref="ServiceAction"/>.
	/// </summary>
	/// <param name="requests">The collection of service action requests, indicating whether to start or stop each service.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StartStopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StartStopServices([DisallowNull] in IEnumerable<ServiceAction> requests) => requests.ToList().ForEach(request =>
		{
			if (request.ServiceActionRequest == ServiceActionRequest.Start)
			{
				request.ServiceActionResult = StartService(request.ServiceName!);
			}
			else if (request.ServiceActionRequest == ServiceActionRequest.Stop)
			{
				request.ServiceActionResult = StopService(request.ServiceName!);
			}
		});

	/// <summary>
	/// Stops the specified Windows service.
	/// </summary>
	/// <param name="serviceName">The name of the service to stop.</param>
	/// <param name="stopServicesDependedOn">
	/// If <c>true</c>, stops all services that the specified service depends on before stopping the service itself.
	/// </param>
	/// <param name="stopDependingServices">
	/// If <c>true</c>, stops all services that depend on the specified service before stopping the service.
	/// </param>
	/// <returns>
	/// A <see cref="ServiceActionResult"/> indicating the result of the operation:
	/// <list type="bullet">
	/// <item><see cref="ServiceActionResult.Stopped"/> if the service was stopped successfully.</item>
	/// <item><see cref="ServiceActionResult.NotFound"/> if the service does not exist.</item>
	/// <item><see cref="ServiceActionResult.Error"/> if an error occurred or the service could not be stopped.</item>
	/// </list>
	/// </returns>
	/// <example>
	/// <code>
	/// var result = ServiceHelper.StopService("W32Time", true, false);
	/// if (result == ServiceActionResult.Stopped)
	/// {
	///     Console.WriteLine("Service stopped successfully.");
	/// }
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StopService), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceActionResult StopService([DisallowNull] string serviceName, bool stopServicesDependedOn = false, bool stopDependingServices = false)
	{
		serviceName = serviceName.ArgumentNotNullOrEmpty();

		var statusResult = ServiceActionResult.NotFound;

		if (ServiceExists(serviceName) is false)
		{
			return statusResult;
		}

		var service = LoadService(serviceName);

		if (service is not null && service.Status == ServiceControllerStatus.Running)
		{
			// First stop any services that this service depends on.
			if (stopServicesDependedOn)
			{
				StopDependentServices(service.ServicesDependedOn);
			}

			// Stop any services that depends on this service.
			if (stopDependingServices)
			{
				StopDependentServices(service.DependentServices);
			}

			service.Stop();
			statusResult = ServiceActionResult.Stopped;
		}

		return statusResult;
	}

	/// <summary>
	/// Stops the specified Windows services by name.
	/// </summary>
	/// <param name="requests">A collection of service names to stop. Each string should be the name of a service installed on the system.</param>
	/// <remarks>
	/// This method iterates through the provided collection and attempts to stop each service by name.
	/// If a service is not found or cannot be stopped, its result is not reported.
	/// </remarks>
	/// <example>
	/// <code>
	/// var serviceNames = new[] { "MSSQLSERVER", "W32Time" };
	/// ServiceHelper.StopServices(serviceNames);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StopServices([DisallowNull] in IEnumerable<string> requests)
	{
		requests.ToList().ForEach(request => StopService(request));
	}

}
