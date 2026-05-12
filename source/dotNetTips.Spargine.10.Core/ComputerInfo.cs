// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-12-2026
// ***********************************************************************
// <copyright file="ComputerInfo.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Used to retrieve common computer information.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core.Devices;
using static System.Environment;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides detailed information about the computer system.
/// </summary>
[Information(nameof(ComputerInfo), Status = Status.Available, Documentation = "https://bit.ly/SpargineComputerInfo")]
[DataContract(Namespace = "dotNetTips.com/Info")]
[Serializable]
public sealed class ComputerInfo
{

	private static readonly CompositeFormat _diskUsageFormat = CompositeFormat.Parse("{0:N0} bytes free of {1:N0} bytes");

	/// <summary>
	/// Initializes a new instance of the <see cref="ComputerInfo"/> class.
	/// </summary>
	public ComputerInfo()
	{
	}

	/// <summary>
	/// Gets the current CPU usage total time.
	/// </summary>
	/// <returns>The total CPU usage time as a <see cref="TimeSpan"/>.</returns>
	[DataMember]
	[Information(nameof(GetCpuUsageTotalTime), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TimeSpan GetCpuUsageTotalTime { get; private set; } = CpuUsage.TotalTime;

	/// <summary>
	/// Gets the CPU usage user time.
	/// </summary>
	/// <returns>The user CPU usage time as a <see cref="TimeSpan"/>.</returns>
	[DataMember]
	[Information(nameof(GetCpuUsageUserTime), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static TimeSpan GetCpuUsageUserTime { get; private set; } = CpuUsage.UserTime;

	/// <summary>
	/// Gets the computer culture in three-letter ISO language name format.
	/// </summary>
	[DataMember]
	[Information(nameof(ComputerCulture), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string ComputerCulture { get; private set; } = CultureInfo.CurrentCulture.ThreeLetterISOLanguageName;

	/// <summary>
	/// Gets the computer UI culture in three-letter ISO language name format.
	/// </summary>
	[DataMember]
	[Information(nameof(ComputerUICulture), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string ComputerUICulture { get; private set; } = CultureInfo.CurrentUICulture.ThreeLetterISOLanguageName;

	/// <summary>
	/// Gets the current managed thread identifier.
	/// </summary>
	[DataMember]
	[Information(nameof(CurrentManagedThreadId), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CurrentManagedThreadId { get => Thread.CurrentThread.ManagedThreadId; }

	/// <summary>
	/// Gets the current stack trace information.
	/// </summary>
	[DataMember]
	[Information(nameof(CurrentStackTrace), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CurrentStackTrace { get; private set; } = StackTrace;

	/// <summary>
	/// Gets the current system tick count.
	/// </summary>
	[DataMember]
	[Information(nameof(CurrentSystemTickCount), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int CurrentSystemTickCount { get; private set; } = Clock.TickCount;

	/// <summary>
	/// Shows the directory from which the current process is running.
	/// </summary>
	[DataMember]
	[Information(nameof(CurrentWorkingDirectory), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string CurrentWorkingDirectory { get; private set; } = CurrentDirectory;

	/// <summary>
	/// Gets the disk usage information for the computer.
	/// </summary>
	/// <remarks>
	/// This property calculates the total free space and total size of all ready drives on the computer.
	/// </remarks>
	/// <value>
	/// A string representing the total free space and total size of all ready drives.
	/// </value>
	[DataMember]
	[Information(nameof(DiskUsage), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string DiskUsage
	{
		get
		{
			var drives = DriveInfo.GetDrives().Where(d => d.IsReady).ToArray();
			var totalFreeSpace = drives.Sum(d => d.TotalFreeSpace);
			var totalSize = drives.Sum(d => d.TotalSize);

			return string.Format(CultureInfo.CurrentCulture, _diskUsageFormat, totalFreeSpace, totalSize);
		}
	}

	/// <summary>
	/// Displays a description of the .NET framework in use.
	/// </summary>
	[DataMember]
	[Information(nameof(FrameworkDescription), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string FrameworkDescription { get; private set; } = RuntimeInformation.FrameworkDescription;

	/// <summary>
	/// Gets the version of the .NET framework.
	/// </summary>
	[DataMember]
	[Information(nameof(FrameworkVersion), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Version FrameworkVersion { get; private set; } = Environment.Version;

	/// <summary>
	/// Gets the CPU usage privileged time.
	/// </summary>
	/// <remarks>
	/// CPU Privileged Time refers to the amount of time the CPU spends executing
	/// system-level operations or kernel-mode code. This includes tasks such as
	/// managing hardware, handling interrupts, and performing other low-level system
	/// functions.
	/// </remarks>
	/// <returns>The privileged CPU usage time as a <see cref="TimeSpan"/>.</returns>
	[DataMember]
	[Information(nameof(GetCpuUsagePrivilegedTime), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan GetCpuUsagePrivilegedTime { get; private set; } = CpuUsage.PrivilegedTime;

	/// <summary>
	/// Gets a value indicating whether the shutdown process has started.
	/// </summary>
	[DataMember]
	[Information(nameof(HasShutdownStarted), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool HasShutdownStarted { get; private set; } = Environment.HasShutdownStarted;

	/// <summary>
	/// Gets the IP addresses assigned to the computer.
	/// </summary>
	[DataMember]
	[Information(nameof(IPAddress), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string IPAddress { get; private set; } = Dns.GetHostAddresses(Dns.GetHostName()).Where(p => p.AddressFamily == AddressFamily.InterNetwork).ToDelimitedString();

	/// <summary>
	/// Gets a value indicating whether the operating system is 64-bit.
	/// </summary>
	[DataMember]
	[Information(nameof(Is64BitOperatingSystem), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool Is64BitOperatingSystem { get; private set; } = Environment.Is64BitOperatingSystem;

	/// <summary>
	/// Gets a value indicating whether the process is 64-bit.
	/// </summary>
	[DataMember]
	[Information(nameof(Is64BitProcess), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool Is64BitProcess { get; private set; } = Environment.Is64BitProcess;

	/// <summary>
	/// Determines whether the network is available.
	/// </summary>
	/// <returns><c>true</c> if the network is available; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks all network interfaces to determine if any are operational and not virtual or loopback interfaces.
	/// </remarks>
	[Information(nameof(IsNetworkAvailable), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool IsNetworkAvailable => NetworkInterface.GetAllNetworkInterfaces().Any(networkInterface =>
					networkInterface.OperationalStatus == OperationalStatus.Up &&
					!networkInterface.Description.Contains("VIRTUALBOX", StringComparison.OrdinalIgnoreCase) &&
					!networkInterface.Description.Contains("LOOPBACK", StringComparison.OrdinalIgnoreCase));

	/// <summary>
	/// Gets a value indicating whether the user interface is interactive.
	/// </summary>
	[DataMember]
	[Information(nameof(IsUserInteractive), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public bool IsUserInteractive { get; private set; } = UserInteractive;

	/// <summary>
	/// Gets the logical drives on the computer.
	/// </summary>
	[DataMember]
	[Information(nameof(LogicalDrives), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string LogicalDrives { get; private set; } = GetLogicalDrives().ToDelimitedString();

	/// <summary>
	/// Gets the computer’s machine name.
	/// </summary>
	[DataMember]
	[Information(nameof(MachineName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string MachineName { get; private set; } = Environment.MachineName;

	/// <summary>
	/// Gets the architecture (e.g., 64-bit or 32-bit) of the operating system.
	/// </summary>
	[DataMember()]
	[Information(nameof(OSArchitecture), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string OSArchitecture { get; private set; } = RuntimeInformation.OSArchitecture.ToString();

	/// <summary>
	/// Gets the description of the operating system.
	/// </summary>
	[DataMember]
	[Information(nameof(OSDescription), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string OSDescription { get; private set; } = RuntimeInformation.OSDescription;

	/// <summary>
	/// Gets the size of the operating system's memory page.
	/// </summary>
	[DataMember]
	[Information(nameof(OSMemoryPageSize), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int OSMemoryPageSize { get; private set; } = Environment.SystemPageSize;

	/// <summary>
	/// Gets the amount of physical memory in use.
	/// </summary>
	[DataMember]
	[Information(nameof(PhysicalMemoryInUse), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public long PhysicalMemoryInUse { get; private set; } = WorkingSet;

	/// <summary>
	/// Gets the architecture of the process.
	/// </summary>
	[DataMember]
	[Information(nameof(ProcessArchitecture), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public Architecture ProcessArchitecture { get; private set; } = RuntimeInformation.ProcessArchitecture;

	/// <summary>
	/// Gets the number of processors.
	/// </summary>
	[DataMember]
	[Information(nameof(ProcessorCount), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int ProcessorCount { get; private set; } = Environment.ProcessorCount;

	/// <summary>
	/// Gets the system directory path.
	/// </summary>
	[DataMember]
	[Information(nameof(SystemDirectory), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string SystemDirectory { get; private set; } = Environment.SystemDirectory;

	/// <summary>
	/// Gets the size of the system page.
	/// </summary>
	[DataMember]
	[Information(nameof(SystemPageSize), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int SystemPageSize { get; private set; } = Environment.SystemPageSize;

	/// <summary>
	/// Gets the system tick count.
	/// </summary>
	[DataMember]
	[Information(nameof(TickCount), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public int TickCount { get; private set; } = Clock.TickCount;

	/// <summary>
	/// Gets the system tick count as a 64-bit value.
	/// </summary>
	[DataMember]
	[Information(nameof(TickCount64), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public long TickCount64 { get; private set; } = Clock.TickCount64;

	/// <summary>
	/// Gets the uptime of the system.
	/// </summary>
	[DataMember]
	[Information(nameof(Uptime), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public TimeSpan Uptime => TimeSpan.FromMilliseconds(Environment.TickCount64);

	/// <summary>
	/// Gets the domain name associated with the current user.
	/// </summary>
	[DataMember]
	[Information(nameof(UserDomainName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string UserDomainName { get; private set; } = Environment.UserDomainName;

	/// <summary>
	/// Gets the name of the current user.
	/// </summary>
	[DataMember]
	[Information(nameof(UserName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string UserName { get; private set; } = Environment.UserName;

	/// <summary>
	/// Converts the current instance of <see cref="ComputerInfo"/> to a JSON string.
	/// </summary>
	/// <remarks>
	/// This method serializes the current object into a JSON format string using <see cref="JsonSerializer"/>.
	/// </remarks>
	/// <returns>
	/// A JSON string representation of the current <see cref="ComputerInfo"/> instance.
	/// </returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(ToJson), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public string ToJson()
	{
		return JsonSerializer.Serialize(this, ComputerInfoJsonContext.Default.ComputerInfo);
	}

	/// <summary>
	/// Returns a string representation of the current <see cref="ComputerInfo"/> instance.
	/// </summary>
	/// <returns>
	/// A formatted string containing the names and values of all public instance properties.
	/// </returns>
	/// <remarks>
	/// Uses an extension method to format properties into delimited name/value pairs suitable for diagnostics and logging.
	/// For structured output, prefer calling <see cref="ToJson"/>.
	/// </remarks>
	[Pure]
	[return: NotNull]
	public override string ToString()
	{
		return string.Create(
			CultureInfo.CurrentCulture,
			$"{nameof(this.ComputerCulture)}: {this.ComputerCulture}, " +
			$"{nameof(this.ComputerUICulture)}: {this.ComputerUICulture}, " +
			$"{nameof(this.CurrentManagedThreadId)}: {this.CurrentManagedThreadId}, " +
			$"{nameof(this.CurrentStackTrace)}: {this.CurrentStackTrace}, " +
			$"{nameof(this.CurrentSystemTickCount)}: {this.CurrentSystemTickCount}, " +
			$"{nameof(this.CurrentWorkingDirectory)}: {this.CurrentWorkingDirectory}, " +
			$"{nameof(this.FrameworkDescription)}: {this.FrameworkDescription}, " +
			$"{nameof(this.FrameworkVersion)}: {this.FrameworkVersion}, " +
			$"{nameof(this.HasShutdownStarted)}: {this.HasShutdownStarted}, " +
			$"{nameof(this.IPAddress)}: {this.IPAddress}, " +
			$"{nameof(this.Is64BitOperatingSystem)}: {this.Is64BitOperatingSystem}, " +
			$"{nameof(this.Is64BitProcess)}: {this.Is64BitProcess}, " +
			$"{nameof(this.IsNetworkAvailable)}: {this.IsNetworkAvailable}, " +
			$"{nameof(this.IsUserInteractive)}: {this.IsUserInteractive}, " +
			$"{nameof(this.MachineName)}: {this.MachineName}, " +
			$"{nameof(this.OSArchitecture)}: {this.OSArchitecture}, " +
			$"{nameof(this.OSDescription)}: {this.OSDescription}, " +
			$"{nameof(this.OSMemoryPageSize)}: {this.OSMemoryPageSize}, " +
			$"{nameof(this.PhysicalMemoryInUse)}: {this.PhysicalMemoryInUse}, " +
			$"{nameof(this.ProcessArchitecture)}: {this.ProcessArchitecture}, " +
			$"{nameof(this.ProcessorCount)}: {this.ProcessorCount}, " +
			$"{nameof(this.SystemDirectory)}: {this.SystemDirectory}, " +
			$"{nameof(this.SystemPageSize)}: {this.SystemPageSize}, " +
			$"{nameof(this.TickCount)}: {this.TickCount}, " +
			$"{nameof(this.TickCount64)}: {this.TickCount64}, " +
			$"{nameof(this.UserDomainName)}: {this.UserDomainName}, " +
			$"{nameof(this.UserName)}: {this.UserName}");
	}
}
