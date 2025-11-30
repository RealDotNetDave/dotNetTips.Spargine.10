// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 06-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 11-30-2025
// ***********************************************************************
// <copyright file="NetworkHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides helper methods for network-related operations.</summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace DotNetTips.Spargine.Core.Network;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

/// <summary>
/// Provides helper methods for network-related operations.
/// </summary>
[Information(Status = Status.NeedsDocumentation, Documentation = "")]
public static class NetworkHelper
{

	/// <summary>
	/// Gets the DNS server addresses configured for the active network interfaces.
	/// </summary>
	/// <returns>A read-only collection of DNS server IP addresses.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetDnsServerAddresses), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
	[Information(nameof(GetGatewayAddresses), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
	[Information(nameof(GetHostName), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
	[Information(nameof(GetLocalIPAddresses), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
	/// Gets the MAC (physical) address of the active network interface.
	/// </summary>
	/// <returns>A read-only collection of physical addresses (MAC addresses) for active network interfaces.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetMacAddresses), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
	/// Checks the network connections and returns a read-only collection of active network interfaces.
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
	/// Gets the network speed (bandwidth) of active network interfaces in bits per second.
	/// </summary>
	/// <returns>A read-only collection of tuples containing interface name and speed in bps.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetNetworkSpeeds), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static ReadOnlyCollection<(string InterfaceName, long SpeedBps)> GetNetworkSpeeds()
	{
		var speeds = new List<(string, long)>();
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				speeds.Add((networkInterface.Name, networkInterface.Speed));
			}
		}

		return speeds.AsReadOnly();
	}

	/// <summary>
	/// Gets network statistics for the specified network interface type.
	/// </summary>
	/// <param name="interfaceType">The type of network interface to get statistics for.</param>
	/// <returns>A read-only collection of tuples containing interface name and its statistics.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetNetworkStatistics), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
	[Information(nameof(GetPrimaryNetworkInterface), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
	[Information(nameof(GetNetworkConnections), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	/// This method examines all network interfaces and checks if any active interface 
	/// has "Ethernet" in its description. It uses case-insensitive comparison.
	/// </remarks>
	[Pure]
	[Information(nameof(IsConnectedToEthernet), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool IsConnectedToEthernet()
	{
		var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

		foreach (var networkInterface in networkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up &&
				networkInterface.Name.Contains("Ethernet", StringComparison.OrdinalIgnoreCase))
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
	[Information(nameof(GetNetworkConnections), OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static bool IsConnectedToNetwork()
	{
		return NetworkInterface.GetIsNetworkAvailable();
	}

	/// <summary>
	/// Checks if the computer is connected to a Wi-Fi network.
	/// </summary>
	/// <returns><c>true</c> if the computer is connected to a Wi-Fi network; otherwise, <c>false</c>.</returns>
	[Pure]
	[Information(nameof(IsConnectedToWiFi), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
	[Information(nameof(IsIPv6Supported), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
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
