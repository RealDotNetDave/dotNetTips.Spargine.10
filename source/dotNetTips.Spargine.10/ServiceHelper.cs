// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="ServiceHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Convenient helper methods for seamless management of Windows requests, offering key features such as loading a service, checking its running status, starting and stopping requests, and more.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.ServiceProcess;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Core.Logging;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;
using Microsoft.Extensions.Logging;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

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
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineServiceHelper")]
public static class ServiceHelper
{
	private static readonly CompositeFormat _processHasBeenKilled = CompositeFormat.Parse(Resources.ProcessHasBeenKilled);
	private static readonly CompositeFormat _serviceHasBeenStarted = CompositeFormat.Parse(Resources.ServiceHasBeenStartedOn);
	private static readonly CompositeFormat _serviceHasBeenStopped = CompositeFormat.Parse(Resources.ServiceHasBeenStoppedOn);


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
	/// Starts all services that the specified service depends on, if they are not already running.
	/// </summary>
	/// <param name="services">
	/// The array of <see cref="ServiceController"/> objects representing the services to start.
	/// If <c>null</c>, no action is taken.
	/// </param>
	/// <param name="logger">
	/// Optional logger for logging when services are successfully started.
	/// If provided, logs a message for each started service.
	/// </param>
	/// <remarks>
	/// This method iterates through the provided array of service controllers.
	/// For each service that is not currently running, it attempts to start the service.
	/// If a logger is provided, a log entry is created for each service that is started.
	/// This method is used internally by <see cref="StartService"/> to handle dependent services.
	/// </remarks>
	/// <exception cref="InvalidOperationException">
	/// May be thrown if there's an issue starting a service, such as insufficient permissions or if the service is disabled.
	/// </exception>
	private static void StartDependentServices(in ServiceController[] services, in ILogger? logger = null)
	{
		foreach (var serviceDependsOn in services!)
		{
			if (serviceDependsOn.Status != ServiceControllerStatus.Running)
			{
				serviceDependsOn.Start();

				logger?.LogInformationMessage(string.Format(CultureInfo.CurrentCulture, _serviceHasBeenStarted, serviceDependsOn.ServiceName, Clock.UtcTime));
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
	/// <param name="logger">
	/// Optional logger for logging when services are successfully stopped.
	/// If provided, logs a message for each stopped service.
	/// </param>
	/// <remarks>
	/// This method iterates through the provided array of service controllers.
	/// For each service that is not currently stopped, it attempts to stop the service.
	/// If a logger is provided, a log entry is created for each service that is stopped.
	/// This method is used internally by <see cref="StopService"/> to handle dependent services.
	/// </remarks>
	/// <exception cref="InvalidOperationException">
	/// May be thrown if there's an issue stopping a service, such as insufficient permissions or if the service cannot be stopped.
	/// </exception>
	private static void StopDependentServices(ServiceController[] services, ILogger? logger = null)
	{
		foreach (var serviceDependsOn in services!)
		{
			if (serviceDependsOn.Status != ServiceControllerStatus.Stopped)
			{
				serviceDependsOn.Stop();


				logger?.LogInformationMessage(string.Format(CultureInfo.CurrentCulture, _serviceHasBeenStopped, serviceDependsOn.ServiceName, Clock.UtcTime));
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
	/// <param name="logger">Optional logger for logging successful process terminations. If provided, logs a message when a process is successfully killed.</param>
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
	public static void KillProcess([DisallowNull] string processName, int waitForExitMilliseconds = 6000, ILogger? logger = null)
	{
		var app = Process.GetProcessesByName(processName.ArgumentNotNullOrEmpty()).FirstOrDefault();

		if (app is not null)
		{
			app.Kill();
			_ = app.WaitForExit(milliseconds: waitForExitMilliseconds);

			logger?.LogInformationMessage(string.Format(CultureInfo.CurrentCulture, _processHasBeenKilled, processName, Clock.UtcTime));

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
	[Information(nameof(ServiceStatus), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.NeedsUpdate, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceControllerStatus ServiceStatus([DisallowNull] string serviceName)
	{
		var service = LoadService(serviceName.ArgumentNotNullOrEmpty());

		return service is not null ? service.Status : throw new InvalidOperationException(Resources.ServiceNotFound);
	}

	/// <summary>
	/// Starts the specified Windows service.
	/// </summary>
	/// <param name="serviceName">The name of the service to start. This must not be null or empty.</param>
	/// <param name="startServicesDependedOn">
	/// If <c>true</c>, starts all services that the specified service depends on before starting the service itself.
	/// </param>
	/// <param name="startDependingServices">
	/// If <c>true</c>, starts all services that depend on the specified service after starting the service.
	/// </param>
	/// <param name="logger">Optional logger for logging when a service is successfully started.</param>
	/// <returns>
	/// A <see cref="ServiceActionResult"/> indicating the result of the operation:
	/// <list type="bullet">
	/// <item><see cref="ServiceActionResult.Running"/> if the service was started successfully.</item>
	/// <item><see cref="ServiceActionResult.NotFound"/> if the service does not exist.</item>
	/// <item><see cref="ServiceActionResult.Error"/> if an error occurred or the service could not be started.</item>
	/// </list>
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="serviceName"/> is null or empty.</exception>
	/// <remarks>
	/// This method attempts to start a Windows service by name. If the service is already running, the method will return
	/// <see cref="ServiceActionResult.Error"/>. If the service doesn't exist, it returns <see cref="ServiceActionResult.NotFound"/>.
	/// If the operation is successful, the method returns <see cref="ServiceActionResult.Running"/>.
	/// </remarks>
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
	[Information(nameof(StartService), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.NeedsUpdate, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceActionResult StartService([DisallowNull] string serviceName, bool startServicesDependedOn = false, bool startDependingServices = false, ILogger? logger = null)
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

			logger?.LogInformationMessage(string.Format(CultureInfo.CurrentCulture, _serviceHasBeenStarted, serviceName, Clock.UtcTime));

			statusResult = ServiceActionResult.Running;

			// Start any services that depends on this service.
			if (startDependingServices)
			{
				StartDependentServices(service.DependentServices, logger);
			}
		}

		return statusResult;
	}

	/// <summary>
	/// Starts multiple Windows services by name in a batch operation.
	/// </summary>
	/// <param name="requests">
	/// A collection of service names to start. Each string should be the name of a service installed on the system.
	/// Must not be null.
	/// </param>
	/// <param name="logger">
	/// Optional logger for logging when services are successfully started. 
	/// If provided, logs a message for each started service.
	/// </param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="requests"/> is null.</exception>
	/// <remarks>
	/// <para>
	/// This method iterates through the provided collection of service names and attempts to start each service.
	/// For each service name, it calls <see cref="StartService"/> which handles the actual starting logic.
	/// If a service is not found or cannot be started, its result is not reported back to the caller.
	/// </para>
	/// <para>
	/// This batch operation is useful when you need to start multiple services at once, such as during 
	/// application startup or system initialization processes.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// // Starting multiple services at once
	/// var serviceNames = new[] { "MSSQLSERVER", "W32Time", "BITS" };
	/// ServiceHelper.StartServices(serviceNames);
	/// 
	/// // Starting services with logging
	/// var logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("ServiceManager");
	/// ServiceHelper.StartServices(serviceNames, logger);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StartServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StartServices([DisallowNull] in IEnumerable<string> requests, ILogger? logger = null)
	{
		requests.ToList().ForEach(request => StartService(request, logger: logger));
	}

	/// <summary>
	/// Starts or stops multiple Windows services based on the specified service action requests.
	/// </summary>
	/// <param name="requests">
	/// A collection of <see cref="ServiceAction"/> objects, each containing a service name and an action request
	/// (start or stop). Must not be null.
	/// </param>
	/// <param name="logger">
	/// Optional logger for logging when services are successfully started or stopped.
	/// If provided, logs messages for each service operation.
	/// </param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="requests"/> is null.</exception>
	/// <remarks>
	/// <para>
	/// This method processes a batch of service action requests, performing either start or stop operations
	/// based on each request's <see cref="ServiceActionRequest"/> value. The result of each operation is
	/// stored in the <see cref="ServiceAction.ServiceActionResult"/> property of the corresponding request.
	/// </para>
	/// <para>
	/// For each service in the collection:
	/// <list type="bullet">
	/// <item>If <see cref="ServiceActionRequest.Start"/> is specified, the service will be started.</item>
	/// <item>If <see cref="ServiceActionRequest.Stop"/> is specified, the service will be stopped.</item>
	/// <item>If <see cref="ServiceActionRequest.Unknown"/> is specified, no action is taken for that service.</item>
	/// </list>
	/// </para>
	/// <para>
	/// This batch operation is useful for managing multiple services at once, such as during application startup
	/// or shutdown sequences.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// var serviceActions = new List&lt;ServiceAction&gt;
	/// {
	///     new() { ServiceName = "W32Time", ServiceActionRequest = ServiceActionRequest.Start },
	///     new() { ServiceName = "BITS", ServiceActionRequest = ServiceActionRequest.Stop }
	/// };
	/// ServiceHelper.StartStopServices(serviceActions);
	/// 
	/// // Check results
	/// foreach (var action in serviceActions)
	/// {
	///     Console.WriteLine($"Service: {action.ServiceName}, Result: {action.ServiceActionResult}");
	/// }
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StartStopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StartStopServices([DisallowNull] in IEnumerable<ServiceAction> requests, ILogger? logger = null)
	{
		requests.ToList().ForEach(request =>
				{
					if (request.ServiceActionRequest == ServiceActionRequest.Start)
					{
						request.ServiceActionResult = StartService(request.ServiceName!, logger: logger);
					}
					else if (request.ServiceActionRequest == ServiceActionRequest.Stop)
					{
						request.ServiceActionResult = StopService(request.ServiceName!, logger: logger);
					}
				});
	}

	/// <summary>
	/// Stops the specified Windows service.
	/// </summary>
	/// <param name="serviceName">The name of the service to stop. This must not be null or empty.</param>
	/// <param name="stopServicesDependedOn">
	/// If <c>true</c>, stops all services that the specified service depends on before stopping the service itself.
	/// </param>
	/// <param name="stopDependingServices">
	/// If <c>true</c>, stops all services that depend on the specified service before stopping the service.
	/// </param>
	/// <param name="logger">Optional logger for logging when a service is successfully stopped.</param>
	/// <returns>
	/// A <see cref="ServiceActionResult"/> indicating the result of the operation:
	/// <list type="bullet">
	/// <item><see cref="ServiceActionResult.Stopped"/> if the service was stopped successfully.</item>
	/// <item><see cref="ServiceActionResult.NotFound"/> if the service does not exist.</item>
	/// <item><see cref="ServiceActionResult.Error"/> if an error occurred or the service could not be stopped.</item>
	/// </list>
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="serviceName"/> is null or empty.</exception>
	/// <remarks>
	/// This method attempts to stop a Windows service by name. If the service is already stopped, the method will return
	/// <see cref="ServiceActionResult.Error"/>. If the service doesn't exist, it returns <see cref="ServiceActionResult.NotFound"/>.
	/// If the operation is successful, the method returns <see cref="ServiceActionResult.Stopped"/>.
	/// 
	/// When <paramref name="stopDependingServices"/> is set to <c>true</c>, all services that depend on this service are stopped first.
	/// This helps prevent potential service disruptions that might occur when stopping a service that others rely on.
	/// </remarks>
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
	[Information(nameof(StopService), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.NeedsUpdate, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static ServiceActionResult StopService([DisallowNull] string serviceName, bool stopServicesDependedOn = false, bool stopDependingServices = false, ILogger? logger = null)
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
				StopDependentServices(service.ServicesDependedOn, logger);
			}

			// Stop any services that depends on this service.
			if (stopDependingServices)
			{
				StopDependentServices(service.DependentServices, logger);
			}

			service.Stop();

			logger?.LogInformationMessage(string.Format(CultureInfo.CurrentCulture, _serviceHasBeenStopped, serviceName, Clock.UtcTime));


			statusResult = ServiceActionResult.Stopped;
		}

		return statusResult;
	}

	/// <summary>
	/// Stops multiple Windows services by name in a batch operation.
	/// </summary>
	/// <param name="requests">
	/// A collection of service names to stop. Each string should be the name of a service installed on the system.
	/// Must not be null.
	/// </param>
	/// <param name="logger">
	/// Optional logger for logging when services are successfully stopped. 
	/// If provided, logs a message for each stopped service.
	/// </param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="requests"/> is null.</exception>
	/// <remarks>
	/// This method iterates through the provided collection of service names and attempts to stop each service.
	/// For each service name, it calls <see cref="StopService"/> which handles the actual stopping logic.
	/// If a service is not found or cannot be stopped, its result is not reported back to the caller.
	/// This batch operation is useful when you need to stop multiple services at once, such as during 
	/// application shutdown or maintenance operations.
	/// </remarks>
	/// <example>
	/// <code>
	/// var serviceNames = new[] { "MSSQLSERVER", "W32Time", "BITS" };
	/// ServiceHelper.StopServices(serviceNames, logger);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(StopServices), author: "David McCarter", createdOn: "1/1/2016", UnitTestStatus = UnitTestStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void StopServices([DisallowNull] IEnumerable<string> requests, ILogger? logger = null)
	{
		requests.ToList().ForEach(request => StopService(request, logger: logger));
	}

}
