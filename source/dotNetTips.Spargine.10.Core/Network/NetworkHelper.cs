// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 06-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-29-2026
// ***********************************************************************
// <copyright file="NetworkHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides helper methods for network-related operations.</summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using DotNetTips.Spargine.Core.Internal;
using Microsoft.Extensions.ObjectPool;

namespace DotNetTips.Spargine.Core.Network;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

/// <summary>
/// Provides helper methods for network-related operations.
/// </summary>
[Information(Status = Status.Available, Documentation = "")]
public static class NetworkHelper
{

	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Gets the DNS server addresses configured for the active network interfaces.
	/// </summary>
	/// <returns>A read-only collection of DNS server IP addresses.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetDnsServerAddresses), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<IPAddress> GetDnsServerAddresses()
	{
		var dnsServers = new List<IPAddress>();
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				var properties = networkInterface.GetIPProperties();
				dnsServers.AddRange(properties.DnsAddresses);
			}
		}

		return dnsServers.Distinct().ToList().AsReadOnly();
	}

	/// <summary>
	/// Gets the gateway addresses configured for the active network interfaces.
	/// </summary>
	/// <returns>A read-only collection of gateway IP addresses.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetGatewayAddresses), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<IPAddress> GetGatewayAddresses()
	{
		var gateways = new List<IPAddress>();
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				var properties = networkInterface.GetIPProperties();
				var gatewayAddresses = properties.GatewayAddresses;

				foreach (var gateway in gatewayAddresses)
				{
					gateways.Add(gateway.Address);
				}
			}
		}

		return gateways.AsReadOnly();
	}

	/// <summary>
	/// Gets the hostname of the local computer.
	/// </summary>
	/// <returns>The hostname of the local computer.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetHostName), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetHostName()
	{
		return Dns.GetHostName();
	}

	/// <summary>
	/// Gets the local IP addresses for the computer.
	/// </summary>
	/// <param name="addressFamily">The address family to filter by (IPv4 or IPv6). If null, returns both.</param>
	/// <returns>A read-only collection of IP addresses assigned to the local computer.</returns>
	/// <exception cref="NetworkInformationException">A Windows system function call failed.</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetLocalIPAddresses), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<IPAddress> GetLocalIPAddresses(AddressFamily? addressFamily = null)
	{
		var addresses = new List<IPAddress>();
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus != OperationalStatus.Up)
			{
				continue;
			}

			var properties = networkInterface.GetIPProperties();
			var unicastAddresses = properties.UnicastAddresses;

			foreach (var unicastAddress in unicastAddresses)
			{
				if (addressFamily.HasValue)
				{
					if (unicastAddress.Address.AddressFamily == addressFamily.Value)
					{
						addresses.Add(unicastAddress.Address);
					}
				}
				else
				{
					addresses.Add(unicastAddress.Address);
				}
			}
		}

		return addresses.AsReadOnly();
	}

	/// <summary>
	/// Gets the MAC (physical) addresses of the active network interface.
	/// </summary>
	/// <returns>A read-only collection of physical addresses (MAC addresses) for active network interfaces.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetMacAddresses), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<PhysicalAddress> GetMacAddresses()
	{
		var macAddresses = new List<PhysicalAddress>();
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				var macAddress = networkInterface.GetPhysicalAddress();
				if (macAddress != null && macAddress != PhysicalAddress.None)
				{
					macAddresses.Add(macAddress);
				}
			}
		}

		return macAddresses.AsReadOnly();
	}

	/// <summary>
	/// Checks the network connections and returns a collection of active network interfaces.
	/// </summary>
	/// <returns>A read-only collection of <see cref="NetworkInterface"/> representing the active network connections.</returns>
	[Pure]
	[Information(nameof(GetNetworkConnections), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<NetworkInterface> GetNetworkConnections()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var connections = new List<NetworkInterface>(networkInterfaces.Length);

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				connections.Add(networkInterface);
			}
		}

		connections.TrimExcess();

		return connections.AsReadOnly();
	}

	/// <summary>
	/// Builds a detailed, human-readable report of active network connections.
	/// </summary>
	/// <param name="includeIPProperties">
	/// If <c>true</c>, includes the IP properties section for each connection (such as DNS, gateways, and IP configurations).
	/// If <c>false</c>, omits the IP properties section for a faster, lighter report.
	/// </param>
	/// <returns>
	/// A formatted <see cref="string"/> containing one section per active network interface, including:
	/// name, basic details (description, type, status, speed, receive-only flag, physical address),
	/// IP statistics, IPv4 statistics, and optionally IP properties.
	/// </returns>
	/// <remarks>
	/// - Interfaces are filtered to operational status <see cref="OperationalStatus.Up"/> and speed &gt; 0.
	/// - Uses a pooled <see cref="StringBuilder"/> to minimize allocations.
	/// - Relies on extension methods for formatting (e.g., <see cref="InternalMethods.PropertiesToDictionary(object, string, bool)"/>).
	/// - Each interface section is separated by a header line of '=' characters for readability.
	/// </remarks>
	[Pure]
	[Information(nameof(GetNetworkConnections), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetNetworkConnectionsReport(bool includeIPProperties = false)
	{
		var connections = GetNetworkConnections();

		var sb = _stringBuilderPool.Get().Clear();

		foreach (var connection in connections.Where(p => p.Speed > 0))
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"Name: {connection.Name}");
			sb.AppendRepeatedCharsLine(ControlChars.Equal, 40);

			//Basic info
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Description: {connection.Description}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Type: {connection.NetworkInterfaceType.GetDescription()}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Status: {connection.OperationalStatus.GetDescription()}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Speed: {connection.Speed}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Receive only: {connection.IsReceiveOnly}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Physical Address: {connection.GetPhysicalAddress().ToString()}");
			_ = sb.AppendLine();

			//Add IP Statistics
			var ipStats = connection.GetIPStatistics();

			if (ipStats is not null)
			{
				_ = sb.AppendLine(CultureInfo.CurrentCulture, $"IP Statistics:");

				var ipStatsInfo = ipStats.PropertiesToDictionary();

				foreach (var kvp in ipStatsInfo)
				{
					_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  {kvp.Key}: {kvp.Value}");
				}

				_ = sb.AppendLine();
			}

			//Add IPv4 Statistics
			var ipv4Stats = connection.GetIPv4Statistics();

			if (ipv4Stats is not null)
			{
				_ = sb.AppendLine(CultureInfo.CurrentCulture, $"IPv4 Statistics:");

				var ipv4StatsInfo = ipv4Stats.PropertiesToDictionary();

				foreach (var kvp in ipv4StatsInfo)
				{
					_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  {kvp.Key}: {kvp.Value}");
				}

				_ = sb.AppendLine();
			}

			if (includeIPProperties)
			{
				//Add IP Properties
				var ipProperties = connection.GetIPProperties();

				if (ipProperties is not null)
				{
					_ = sb.AppendLine(CultureInfo.CurrentCulture, $"IP Properties:");

					var ipPropertiesInfo = ipProperties.PropertiesToDictionary();

					foreach (var kvp in ipPropertiesInfo)
					{
						_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  {kvp.Key}: {kvp.Value}");
					}

					_ = sb.AppendLine();
				}
			}

			// Add ending blank line
			_ = sb.AppendLine();

		}

		return sb.ToString();
	}

	/// <summary>
	/// Gets the network speed (bandwidth) of active network interfaces in bits per second.
	/// </summary>
	/// <returns>A read-only collection of tuples containing interface name and speed in bps.</returns>
	/// <remarks>
	/// <para>
	/// This method enumerates all network interfaces on the system and returns the speed (bandwidth) 
	/// for each active interface. The speed is reported in bits per second (bps).
	/// </para>
	/// <para>
	/// Only interfaces with <see cref="OperationalStatus.Up"/> status and a speed greater than 0 
	/// are included in the results. Interfaces that are down, disconnected, or report a speed of 0 
	/// or less are excluded.
	/// </para>
	/// <para>
	/// Common speed values:
	/// <list type="bullet">
	/// <item><description>10,000,000 bps (10 Mbps) - Fast Ethernet</description></item>
	/// <item><description>100,000,000 bps (100 Mbps) - Fast Ethernet</description></item>
	/// <item><description>1,000,000,000 bps (1 Gbps) - Gigabit Ethernet</description></item>
	/// <item><description>10,000,000,000 bps (10 Gbps) - 10 Gigabit Ethernet</description></item>
	/// </list>
	/// </para>
	/// </remarks>
	/// <example>
	/// This example shows how to retrieve and display network speeds:
	/// <code>
	/// var speeds = NetworkHelper.GetNetworkSpeeds();
	/// 
	/// foreach (var (interfaceName, speedBps) in speeds)
	/// {
	///     var speedMbps = speedBps / 1_000_000.0;
	///     Console.WriteLine($"{interfaceName}: {speedMbps:F2} Mbps");
	/// }
	/// </code>
	/// </example>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetNetworkSpeeds), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<(string InterfaceName, long SpeedBps)> GetNetworkSpeeds()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var speeds = new List<(string, long)>(networkInterfaces.Length);

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.Speed > 0)
			{
				speeds.Add((networkInterface.Name, networkInterface.Speed));
			}
		}

		speeds.TrimExcess();

		return speeds.AsReadOnly();
	}

	/// <summary>
	/// Gets network statistics for the specified network interface type.
	/// </summary>
	/// <param name="interfaceType">The type of network interface to get statistics for.</param>
	/// <returns>A read-only collection of tuples containing interface name and its statistics.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetNetworkStatistics), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<(string InterfaceName, IPv4InterfaceStatistics Statistics)> GetNetworkStatistics(NetworkInterfaceType? interfaceType = null)
	{
		var statistics = new List<(string, IPv4InterfaceStatistics)>();
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				if (!interfaceType.HasValue || networkInterface.NetworkInterfaceType == interfaceType.Value)
				{
					if (networkInterface.Supports(NetworkInterfaceComponent.IPv4))
					{
						var stats = networkInterface.GetIPv4Statistics();
						statistics.Add((networkInterface.Name, stats));
					}
				}
			}
		}

		return statistics.AsReadOnly();
	}

	/// <summary>
	/// Gets detailed information about the primary network interface.
	/// </summary>
	/// <returns>Information about the primary active network interface, or null if none found.</returns>
	[Pure]
	[Information(nameof(GetPrimaryNetworkInterface), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
	public static NetworkInterface? GetPrimaryNetworkInterface()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		// Prioritize Ethernet, then Wi-Fi, then others
		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up &&
				networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
			{
				return networkInterface;
			}
		}

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up &&
				networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
			{
				return networkInterface;
			}
		}

		// Return first active interface if no Ethernet or Wi-Fi found
		return networkInterfaces.FirstOrDefault(ni => ni.OperationalStatus == OperationalStatus.Up);
	}

	/// <summary>
	/// Checks if the computer is connected to a Bluetooth network.
	/// </summary>
	/// <returns><c>true</c> if the computer is connected to a Bluetooth network; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(GetNetworkConnections), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
	public static bool IsConnectedToBluetooth()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up &&
				networkInterface.Description.Contains("Bluetooth", StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Checks if the computer is connected to an Ethernet network.
	/// </summary>
	/// <returns><c>true</c> if the computer is connected to an Ethernet network; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// <para>
	/// This method examines all network interfaces and checks if any active interface 
	/// is of type <see cref="NetworkInterfaceType.Ethernet"/>.
	/// </para>
	/// <para>
	/// Unlike checking the interface name (which can vary by system), this method uses
	/// the standardized <see cref="NetworkInterfaceType"/> enumeration for reliable detection
	/// across different operating systems and configurations.
	/// </para>
	/// </remarks>
	[Pure]
	[Information(nameof(IsConnectedToEthernet), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsConnectedToEthernet()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up &&
				networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Checks if the computer is connected to any network.
	/// </summary>
	/// <returns><c>true</c> if the computer is connected to any network; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method uses the built-in .NET NetworkInterface.GetIsNetworkAvailable() method
	/// to determine if any network connection is available on the system.
	/// </remarks>
	[Pure]
	[Information(nameof(GetNetworkConnections), OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsConnectedToNetwork()
	{
		return NetworkInterface.GetIsNetworkAvailable();
	}

	/// <summary>
	/// Checks if the computer is connected to a Wi-Fi network.
	/// </summary>
	/// <returns><c>true</c> if the computer is connected to a Wi-Fi network; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsConnectedToWiFi), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsConnectedToWiFi()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up &&
				networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
			{
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Checks if the specified network interface supports IPv6.
	/// </summary>
	/// <returns><c>true</c> if any active network interface supports IPv6; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsIPv6Supported), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool IsIPv6Supported()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up &&
				networkInterface.Supports(NetworkInterfaceComponent.IPv6))
			{
				return true;
			}
		}

		return false;
	}
}
