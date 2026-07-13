// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 06-18-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
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
using Microsoft.Extensions.ObjectPool;

namespace DotNetTips.Spargine.Core.Network;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

/// <summary>
/// Provides helper methods for network-related operations.
/// </summary>
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineNetworkHelper")]
public static class NetworkHelper
{

	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Gets the names of active network interfaces.
	/// </summary>
	/// <returns>A read-only collection containing the names of active network interfaces.</returns>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetActiveNetworkInterfaceNames), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<string> GetActiveNetworkInterfaceNames()
	{
		var connections = GetNetworkConnections();
		var names = new List<string>(connections.Count);

		foreach (var networkInterface in connections)
		{
			names.Add(networkInterface.Name);
		}

		return names.AsReadOnly();
	}

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

		return new ReadOnlyCollection<IPAddress>([.. dnsServers.Distinct()]);
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
	/// If <c>true</c>, includes the IP properties section for each connection.
	/// </param>
	/// <returns>A formatted report of active network interfaces.</returns>
	[Pure]
	[Information(nameof(GetNetworkConnectionsReport), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string GetNetworkConnectionsReport(bool includeIPProperties = false)
	{
		var connections = GetNetworkConnections();
		var sb = _stringBuilderPool.Get().Clear();

		try
		{
			foreach (var connection in connections.Where(static p => p.Speed > 0))
			{
				AppendNetworkInterfaceSummary(sb, connection);

				var ipStats = connection.GetIPStatistics();

				if (ipStats is not null)
				{
					AppendIPInterfaceStatistics(sb, "IP Statistics", ipStats);
				}

				if (connection.Supports(NetworkInterfaceComponent.IPv4))
				{
					var ipv4Stats = connection.GetIPv4Statistics();

					if (ipv4Stats is not null)
					{
						AppendIPv4InterfaceStatistics(sb, "IPv4 Statistics", ipv4Stats);
					}
				}

				if (includeIPProperties)
				{
					var ipProperties = connection.GetIPProperties();

					if (ipProperties is not null)
					{
						AppendIPProperties(sb, ipProperties);
					}
				}

				_ = sb.AppendLine();
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb.Clear());
		}
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
	[Information(nameof(GetPrimaryNetworkInterface), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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

	/// <summary>
	/// Appends formatted gateway address information to the provided <see cref="StringBuilder"/>.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append the formatted gateway addresses to.</param>
	/// <param name="addresses">A collection of <see cref="GatewayIPAddressInformation"/> objects to format and append.</param>
	private static void AppendGatewayAddresses(StringBuilder sb, IEnumerable<GatewayIPAddressInformation> addresses)
	{
		_ = sb.AppendLine("  Gateway Addresses:");

		foreach (var address in addresses)
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"    {address.Address}");
		}
	}

	/// <summary>
	/// Appends a formatted collection of IP addresses to the provided <see cref="StringBuilder"/> with a custom title.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append the formatted addresses to.</param>
	/// <param name="title">The title to display above the list of addresses.</param>
	/// <param name="addresses">A collection of <see cref="IPAddress"/> objects to format and append.</param>
	private static void AppendIPAddressCollection(StringBuilder sb, string title, IEnumerable<IPAddress> addresses)
	{
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  {title}:");

		foreach (var address in addresses)
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"    {address}");
		}
	}

	/// <summary>
	/// Appends a formatted collection of IP address information to the provided <see cref="StringBuilder"/> with a custom title.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append the formatted addresses to.</param>
	/// <param name="title">The title to display above the list of addresses.</param>
	/// <param name="addresses">A collection of <see cref="IPAddressInformation"/> objects to format and append.</param>
	private static void AppendIPAddressInformationCollection(StringBuilder sb, string title, IEnumerable<IPAddressInformation> addresses)
	{
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  {title}:");

		foreach (var address in addresses)
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"    {address.Address}");
		}
	}

	/// <summary>
	/// Appends detailed IP interface statistics to the provided <see cref="StringBuilder"/>.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append the formatted statistics to.</param>
	/// <param name="sectionTitle">The title to display for the statistics section.</param>
	/// <param name="statistics">The <see cref="IPInterfaceStatistics"/> object containing the statistics to format and append.</param>
	/// <remarks>
	/// This method formats and appends comprehensive network interface statistics including bytes sent/received,
	/// packet counts, error counts, and queue lengths.
	/// </remarks>
	private static void AppendIPInterfaceStatistics(StringBuilder sb, string sectionTitle, IPInterfaceStatistics statistics)
	{
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"{sectionTitle}:");

		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Bytes Received: {statistics.BytesReceived:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Bytes Sent: {statistics.BytesSent:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Incoming Packets Discarded: {statistics.IncomingPacketsDiscarded:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Incoming Packets With Errors: {statistics.IncomingPacketsWithErrors:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Incoming Unknown Protocol Packets: {statistics.IncomingUnknownProtocolPackets:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Non-Unicast Packets Received: {statistics.NonUnicastPacketsReceived:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Non-Unicast Packets Sent: {statistics.NonUnicastPacketsSent:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Outgoing Packets Discarded: {statistics.OutgoingPacketsDiscarded:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Outgoing Packets With Errors: {statistics.OutgoingPacketsWithErrors:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Output Queue Length: {statistics.OutputQueueLength:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Unicast Packets Received: {statistics.UnicastPacketsReceived:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Unicast Packets Sent: {statistics.UnicastPacketsSent:N0}");
		_ = sb.AppendLine();
	}

	/// <summary>
	/// Appends comprehensive IP properties information to the provided <see cref="StringBuilder"/>.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append the formatted properties to.</param>
	/// <param name="properties">The <see cref="IPInterfaceProperties"/> object containing the properties to format and append.</param>
	/// <remarks>
	/// This method appends detailed IP configuration including DNS settings, DHCP information, gateway addresses,
	/// and various address collections (unicast, anycast, multicast, WINS servers).
	/// </remarks>
	private static void AppendIPProperties(StringBuilder sb, IPInterfaceProperties properties)
	{
		_ = sb.AppendLine("IP Properties:");

		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  DNS Suffix: {properties.DnsSuffix}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  DNS Enabled: {properties.IsDnsEnabled}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Dynamic DNS Enabled: {properties.IsDynamicDnsEnabled}");

		AppendIPAddressCollection(sb, "DNS Addresses", properties.DnsAddresses);
		AppendIPAddressCollection(sb, "DHCP Server Addresses", properties.DhcpServerAddresses);
		AppendIPAddressCollection(sb, "WINS Server Addresses", properties.WinsServersAddresses);
		AppendGatewayAddresses(sb, properties.GatewayAddresses);
		AppendUnicastAddresses(sb, properties.UnicastAddresses);
		AppendIPAddressInformationCollection(sb, "Anycast Addresses", properties.AnycastAddresses);
		AppendIPAddressInformationCollection(sb, "Multicast Addresses", properties.MulticastAddresses);

		_ = sb.AppendLine();
	}

	/// <summary>
	/// Appends detailed IPv4 interface statistics to the provided <see cref="StringBuilder"/>.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append the formatted statistics to.</param>
	/// <param name="sectionTitle">The title to display for the statistics section.</param>
	/// <param name="statistics">The <see cref="IPv4InterfaceStatistics"/> object containing the statistics to format and append.</param>
	/// <remarks>
	/// This method formats and appends IPv4-specific network interface statistics including bytes sent/received,
	/// unicast and non-unicast packet counts, error counts, and queue lengths.
	/// </remarks>
	private static void AppendIPv4InterfaceStatistics(StringBuilder sb, string sectionTitle, IPv4InterfaceStatistics statistics)
	{
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"{sectionTitle}:");

		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Bytes Received: {statistics.BytesReceived:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Bytes Sent: {statistics.BytesSent:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Incoming Packets Discarded: {statistics.IncomingPacketsDiscarded:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Incoming Packets With Errors: {statistics.IncomingPacketsWithErrors:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Incoming Unknown Protocol Packets: {statistics.IncomingUnknownProtocolPackets:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Non-Unicast Packets Received: {statistics.NonUnicastPacketsReceived:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Non-Unicast Packets Sent: {statistics.NonUnicastPacketsSent:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Outgoing Packets Discarded: {statistics.OutgoingPacketsDiscarded:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Outgoing Packets With Errors: {statistics.OutgoingPacketsWithErrors:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Output Queue Length: {statistics.OutputQueueLength:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Unicast Packets Received: {statistics.UnicastPacketsReceived:N0}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Unicast Packets Sent: {statistics.UnicastPacketsSent:N0}");
		_ = sb.AppendLine();
	}

	/// <summary>
	/// Appends a summary of network interface information to the provided <see cref="StringBuilder"/>.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append the formatted summary to.</param>
	/// <param name="networkInterface">The <see cref="NetworkInterface"/> object containing the information to format and append.</param>
	/// <remarks>
	/// This method formats and appends key network interface details including name, description, type,
	/// operational status, speed, multicast support, and physical (MAC) address.
	/// </remarks>
	private static void AppendNetworkInterfaceSummary(StringBuilder sb, NetworkInterface networkInterface)
	{
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"Name: {networkInterface.Name}");
		_ = sb.AppendLine(new string(ControlChars.Equal, 40));

		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Description: {networkInterface.Description}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Type: {networkInterface.NetworkInterfaceType}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Status: {networkInterface.OperationalStatus}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Speed: {networkInterface.Speed:N0} bps");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Receive Only: {networkInterface.IsReceiveOnly}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Supports Multicast: {networkInterface.SupportsMulticast}");
		_ = sb.AppendLine(CultureInfo.CurrentCulture, $"  Physical Address: {networkInterface.GetPhysicalAddress()}");
		_ = sb.AppendLine();
	}

	/// <summary>
	/// Appends detailed unicast address information to the provided <see cref="StringBuilder"/>.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append the formatted addresses to.</param>
	/// <param name="addresses">A collection of <see cref="UnicastIPAddressInformation"/> objects to format and append.</param>
	/// <remarks>
	/// This method formats and appends comprehensive unicast address details including the address itself,
	/// IPv4 mask, prefix length, prefix/suffix origins, duplicate address detection state, DNS eligibility,
	/// and transient status.
	/// </remarks>
	private static void AppendUnicastAddresses(StringBuilder sb, IEnumerable<UnicastIPAddressInformation> addresses)
	{
		_ = sb.AppendLine("  Unicast Addresses:");

		foreach (var address in addresses)
		{
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"    Address: {address.Address}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"      IPv4 Mask: {address.IPv4Mask}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"      Prefix Length: {address.PrefixLength}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"      Prefix Origin: {address.PrefixOrigin}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"      Suffix Origin: {address.SuffixOrigin}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"      Duplicate Address Detection State: {address.DuplicateAddressDetectionState}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"      DNS Eligible: {address.IsDnsEligible}");
			_ = sb.AppendLine(CultureInfo.CurrentCulture, $"      Transient: {address.IsTransient}");
		}
	}
}
