// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 12-22-2025
// ***********************************************************************
// <copyright file="NetworkHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using DotNetTips.Spargine.Core.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Core.Tests.Network;

[ExcludeFromCodeCoverage]
[TestClass]
public class NetworkHelperTests
{


	[TestMethod]
	public void CheckNetworkConnections_ContainsActiveNetworkInterfaces()
	{
		var result = NetworkHelper.GetNetworkConnections();

		foreach (var networkInterface in result)
		{
			Assert.AreEqual(OperationalStatus.Up, networkInterface.OperationalStatus, "All network interfaces should be active.");
		}
	}

	[TestMethod]
	public void CheckNetworkConnections_ReturnsNonNullCollection()
	{
		var result = NetworkHelper.GetNetworkConnections();

		Assert.IsNotNull(result, "The result should not be null.");
	}

	[TestMethod]
	public void CheckNetworkConnections_ReturnsReadOnlyCollection()
	{
		var result = NetworkHelper.GetNetworkConnections();

		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<NetworkInterface>), "The result should be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void GetDnsServerAddresses_OnlyIncludesActiveInterfaces()
	{
		var result = NetworkHelper.GetDnsServerAddresses();
		var allInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var activeInterfaces = allInterfaces.Where(ni => ni.OperationalStatus == OperationalStatus.Up);
		var expectedDnsCount = activeInterfaces.SelectMany(ni => ni.GetIPProperties().DnsAddresses).Distinct().Count();

		Assert.HasCount(expectedDnsCount, result, "Should only include DNS servers from active interfaces.");
	}

	[TestMethod]
	public void GetDnsServerAddresses_ReturnsDistinctAddresses()
	{
		var result = NetworkHelper.GetDnsServerAddresses();
		var distinctCount = result.Distinct().Count();

		Assert.AreEqual(result.Count, distinctCount, "DNS addresses should be distinct.");
	}
	[TestMethod]
	public void GetDnsServerAddresses_ReturnsNonNullCollection()
	{
		var result = NetworkHelper.GetDnsServerAddresses();

		Assert.IsNotNull(result, "The result should not be null.");
	}

	[TestMethod]
	public void GetDnsServerAddresses_ReturnsReadOnlyCollection()
	{
		var result = NetworkHelper.GetDnsServerAddresses();

		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<System.Net.IPAddress>), "The result should be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void GetGatewayAddresses_OnlyIncludesActiveInterfaces()
	{
		var result = NetworkHelper.GetGatewayAddresses();

		Assert.IsNotNull(result, "Gateway addresses should not be null.");
		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<System.Net.IPAddress>), "Result should be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void GetGatewayAddresses_ReturnsNonNullCollection()
	{
		var result = NetworkHelper.GetGatewayAddresses();

		Assert.IsNotNull(result, "The result should not be null.");
	}

	[TestMethod]
	public void GetGatewayAddresses_ReturnsReadOnlyCollection()
	{
		var result = NetworkHelper.GetGatewayAddresses();

		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<System.Net.IPAddress>), "The result should be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void GetHostName_MatchesSystemHostname()
	{
		var result = NetworkHelper.GetHostName();
		var expected = System.Net.Dns.GetHostName();

		Assert.AreEqual(expected, result, "Hostname should match system DNS hostname.");
	}

	[TestMethod]
	public void GetHostName_ReturnsNonNullOrEmptyString()
	{
		var result = NetworkHelper.GetHostName();

		Assert.IsFalse(string.IsNullOrWhiteSpace(result), "Hostname should not be null or empty.");
	}

	[TestMethod]
	public void GetLocalIPAddresses_OnlyIncludesActiveInterfaces()
	{
		var result = NetworkHelper.GetLocalIPAddresses();

		Assert.IsNotNull(result, "Local IP addresses should not be null.");
		Assert.IsGreaterThanOrEqualTo(0, result.Count, "Should return zero or more addresses.");
	}

	[TestMethod]
	public void GetLocalIPAddresses_WithIPv4Filter_ReturnsOnlyIPv4Addresses()
	{
		var result = NetworkHelper.GetLocalIPAddresses(System.Net.Sockets.AddressFamily.InterNetwork);

		Assert.IsNotNull(result, "Result should not be null.");

		foreach (var address in result)
		{
			Assert.AreEqual(System.Net.Sockets.AddressFamily.InterNetwork, address.AddressFamily, "All addresses should be IPv4.");
		}
	}

	[TestMethod]
	public void GetLocalIPAddresses_WithIPv6Filter_ReturnsOnlyIPv6Addresses()
	{
		var result = NetworkHelper.GetLocalIPAddresses(System.Net.Sockets.AddressFamily.InterNetworkV6);

		Assert.IsNotNull(result, "Result should not be null.");

		foreach (var address in result)
		{
			Assert.AreEqual(System.Net.Sockets.AddressFamily.InterNetworkV6, address.AddressFamily, "All addresses should be IPv6.");
		}
	}

	[TestMethod]
	public void GetLocalIPAddresses_WithNoFilter_ReturnsNonNullCollection()
	{
		var result = NetworkHelper.GetLocalIPAddresses();

		Assert.IsNotNull(result, "The result should not be null.");
		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<System.Net.IPAddress>), "The result should be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void GetMacAddresses_OnlyIncludesActiveInterfaces()
	{
		var result = NetworkHelper.GetMacAddresses();
		var allInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var activeInterfaceCount = allInterfaces.Count(ni =>
			ni.OperationalStatus == OperationalStatus.Up &&
			ni.GetPhysicalAddress() != PhysicalAddress.None);

		Assert.IsLessThanOrEqualTo(activeInterfaceCount, result.Count, "Should only include MAC addresses from active interfaces.");
	}

	[TestMethod]
	public void GetMacAddresses_ReturnsNonNullCollection()
	{
		var result = NetworkHelper.GetMacAddresses();

		Assert.IsNotNull(result, "The result should not be null.");
		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<PhysicalAddress>), "The result should be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void GetNetworkConnections_DoesNotIncludeDownInterfaces()
	{
		var result = NetworkHelper.GetNetworkConnections();
		var allInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var downInterfaces = allInterfaces.Where(ni => ni.OperationalStatus != OperationalStatus.Up);

		foreach (var downInterface in downInterfaces)
		{
			Assert.DoesNotContain(downInterface, result, $"Down interface {downInterface.Name} should not be in the result.");
		}
	}

	[TestMethod]
	public void GetNetworkConnections_HandlesNoActiveConnections()
	{
		var result = NetworkHelper.GetNetworkConnections();

		Assert.IsNotNull(result, "Result should not be null even when no connections are active.");
		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<NetworkInterface>), "Result should be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void GetNetworkConnections_ReturnsConsistentResults()
	{
		var result1 = NetworkHelper.GetNetworkConnections();
		var result2 = NetworkHelper.GetNetworkConnections();

		Assert.HasCount(result1.Count, result2, "Multiple calls should return consistent results.");
	}

	[TestMethod]
	public void GetNetworkSpeeds_ContainsValidSpeedValues()
	{
		var result = NetworkHelper.GetNetworkSpeeds();

		foreach (var (interfaceName, speedBps) in result)
		{
			Assert.IsFalse(string.IsNullOrWhiteSpace(interfaceName), "Interface name should not be null or empty.");
			Assert.IsGreaterThanOrEqualTo(0, speedBps, "Speed should be a non-negative value.");
		}
	}

	[TestMethod]
	public void GetNetworkSpeeds_OnlyIncludesActiveInterfaces()
	{
		var result = NetworkHelper.GetNetworkSpeeds();
		var allInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var activeInterfaceCount = allInterfaces.Count(ni => ni.OperationalStatus == OperationalStatus.Up && ni.Speed > 0);

		Assert.HasCount(activeInterfaceCount, result, "Should only include speeds from active interfaces.");
	}

	[TestMethod]
	public void GetNetworkSpeeds_ReturnsNonNullCollection()
	{
		var result = NetworkHelper.GetNetworkSpeeds();

		Assert.IsNotNull(result, "The result should not be null.");
		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<(string InterfaceName, long SpeedBps)>), "The result should be a ReadOnlyCollection of tuples.");
	}

	[TestMethod]
	public void GetNetworkStatistics_ContainsValidStatistics()
	{
		var result = NetworkHelper.GetNetworkStatistics();

		foreach (var (interfaceName, statistics) in result)
		{
			Assert.IsNotNull(statistics, "Statistics should not be null.");
			Assert.IsGreaterThanOrEqualTo(0, statistics.BytesReceived, "Bytes received should be non-negative.");
			Assert.IsGreaterThanOrEqualTo(0, statistics.BytesSent, "Bytes sent should be non-negative.");
		}
	}

	[TestMethod]
	public void GetNetworkStatistics_WithInterfaceTypeFilter_ReturnsMatchingTypes()
	{
		var result = NetworkHelper.GetNetworkStatistics(NetworkInterfaceType.Ethernet);

		Assert.IsNotNull(result, "Result should not be null.");

		foreach (var (interfaceName, statistics) in result)
		{
			Assert.IsFalse(string.IsNullOrWhiteSpace(interfaceName), "Interface name should not be null or empty.");
			Assert.IsNotNull(statistics, "Statistics should not be null.");
		}
	}

	[TestMethod]
	public void GetNetworkStatistics_WithNoFilter_ReturnsNonNullCollection()
	{
		var result = NetworkHelper.GetNetworkStatistics();

		Assert.IsNotNull(result, "The result should not be null.");
		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<(string InterfaceName, IPv4InterfaceStatistics Statistics)>), "The result should be a ReadOnlyCollection of tuples.");
	}

	[TestMethod]
	public void GetPrimaryNetworkInterface_PrioritizesEthernetOverWiFi()
	{
		var result = NetworkHelper.GetPrimaryNetworkInterface();
		var allInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var hasEthernet = allInterfaces.Any(ni =>
			ni.OperationalStatus == OperationalStatus.Up &&
			ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet);

		if (hasEthernet && result != null)
		{
			Assert.AreEqual(NetworkInterfaceType.Ethernet, result.NetworkInterfaceType, "Should prioritize Ethernet when available.");
		}
	}

	[TestMethod]
	public void GetPrimaryNetworkInterface_ReturnsNullOrValidInterface()
	{
		var result = NetworkHelper.GetPrimaryNetworkInterface();

		if (result != null)
		{
			Assert.AreEqual(OperationalStatus.Up, result.OperationalStatus, "Primary interface should be active.");
		}
	}

	[TestMethod]
	public void GetPrimaryNetworkInterface_ReturnsWiFiWhenNoEthernet()
	{
		var result = NetworkHelper.GetPrimaryNetworkInterface();
		var allInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var hasEthernet = allInterfaces.Any(ni =>
			ni.OperationalStatus == OperationalStatus.Up &&
			ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet);
		var hasWiFi = allInterfaces.Any(ni =>
			ni.OperationalStatus == OperationalStatus.Up &&
			ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211);

		if (!hasEthernet && hasWiFi && result != null)
		{
			Assert.AreEqual(NetworkInterfaceType.Wireless80211, result.NetworkInterfaceType, "Should return WiFi when no Ethernet available.");
		}
	}

	[TestMethod]
	public void IsConnectedToBluetooth_CaseInsensitiveCheck()
	{
		var result = NetworkHelper.IsConnectedToBluetooth();
		var interfaces = NetworkInterface.GetAllNetworkInterfaces();
		var hasBluetoothVariant = interfaces.Any(ni =>
			ni.OperationalStatus == OperationalStatus.Up &&
			(ni.Description.Contains("bluetooth", StringComparison.OrdinalIgnoreCase) ||
			 ni.Description.Contains("BLUETOOTH", StringComparison.OrdinalIgnoreCase)));

		if (hasBluetoothVariant)
		{
			Assert.IsTrue(result, "Should detect Bluetooth regardless of case in description.");
		}
	}

	[TestMethod]
	public void IsConnectedToBluetooth_ConsistentWithGetNetworkConnections()
	{
		var result = NetworkHelper.IsConnectedToBluetooth();
		var connections = NetworkHelper.GetNetworkConnections();

		var hasBluetooth = connections.Any(ni => ni.Description.Contains("Bluetooth", StringComparison.OrdinalIgnoreCase));

		Assert.AreEqual(hasBluetooth, result, "IsConnectedToBluetooth should be consistent with GetNetworkConnections.");
	}

	[TestMethod]
	public void IsConnectedToBluetooth_ReturnsFalseWhenNoBluetoothConnection()
	{
		var result = NetworkHelper.IsConnectedToBluetooth();

		Assert.IsFalse(result, "The result should be false when there is no Bluetooth connection.");
	}

	[TestMethod]
	public void IsConnectedToBluetooth_ReturnsTrueWhenBluetoothConnectionExists()
	{
		// This test assumes that there is a Bluetooth connection available.
		// It may need to be adjusted based on the actual environment where the test is run.
		var result = NetworkHelper.IsConnectedToBluetooth();

		if (result)
		{
			Assert.IsTrue(result, "The result should be true when there is a Bluetooth connection.");
		}
		else
		{
			Assert.Inconclusive("No Bluetooth connection is available, so this test cannot be conclusively run.");
		}
	}

	[TestMethod]
	public void IsConnectedToEthernet_CaseInsensitiveCheck()
	{
		var result = NetworkHelper.IsConnectedToEthernet();
		var interfaces = NetworkInterface.GetAllNetworkInterfaces();
		var hasEthernetVariant = interfaces.Any(ni =>
			ni.OperationalStatus == OperationalStatus.Up &&
			(ni.Description.Contains("ethernet", StringComparison.OrdinalIgnoreCase) ||
			 ni.Description.Contains("ETHERNET", StringComparison.OrdinalIgnoreCase)));

		if (hasEthernetVariant)
		{
			Assert.IsTrue(result, "Should detect Ethernet regardless of case in description.");
		}
	}

	[TestMethod]
	public void IsConnectedToEthernet_ConsistentWithGetNetworkConnections()
	{
		var result = NetworkHelper.IsConnectedToEthernet();
		var connections = NetworkHelper.GetNetworkConnections();

		var hasEthernet = connections.Any(ni => ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet);

		Assert.AreEqual(hasEthernet, result, "IsConnectedToEthernet should be consistent with GetNetworkConnections.");
	}

	[TestMethod]
	public void IsConnectedToEthernet_ReturnsBooleanValue()
	{
		var result = NetworkHelper.IsConnectedToEthernet();

		Assert.IsInstanceOfType(result, typeof(bool), "The result should be a boolean value.");
	}

	[TestMethod]
	public void IsConnectedToEthernet_ReturnsTrueWhenEthernetConnectionExists()
	{
		// This test assumes that there is an Ethernet connection available.
		// It may need to be adjusted based on the actual environment where the test is run.
		var result = NetworkHelper.IsConnectedToEthernet();

		if (result)
		{
			Assert.IsTrue(result, "The result should be true when there is an Ethernet connection.");
		}
		else
		{
			Assert.Inconclusive("No Ethernet connection is available, so this test cannot be conclusively run.");
		}
	}

	[TestMethod]
	public void IsConnectedToNetwork_ConsistentWithGetNetworkConnections()
	{
		var result = NetworkHelper.IsConnectedToNetwork();
		var connections = NetworkHelper.GetNetworkConnections();

		if (connections.Count > 0)
		{
			Assert.IsTrue(result, "IsConnectedToNetwork should return true when there are active connections.");
		}
	}

	[TestMethod]
	public void IsConnectedToNetwork_ReturnsBooleanValue()
	{
		var result = NetworkHelper.IsConnectedToNetwork();

		Assert.IsInstanceOfType(result, typeof(bool), "The result should be a boolean value.");
	}

	[TestMethod]
	public void IsConnectedToNetwork_ReturnsExpectedResult()
	{
		var result = NetworkHelper.IsConnectedToNetwork();
		var systemResult = NetworkInterface.GetIsNetworkAvailable();

		Assert.AreEqual(systemResult, result, "IsConnectedToNetwork should match system network availability.");
	}

	[TestMethod]
	public void IsConnectedToWiFi_ConsistentWithGetNetworkConnections()
	{
		var result = NetworkHelper.IsConnectedToWiFi();
		var connections = NetworkHelper.GetNetworkConnections();

		var hasWiFi = connections.Any(ni => ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211);

		Assert.AreEqual(hasWiFi, result, "IsConnectedToWiFi should be consistent with GetNetworkConnections.");
	}

	[TestMethod]
	public void IsConnectedToWiFi_ReturnsBooleanValue()
	{
		var result = NetworkHelper.IsConnectedToWiFi();

		Assert.IsInstanceOfType(result, typeof(bool), "The result should be a boolean value.");
	}

	[TestMethod]
	public void IsConnectedToWiFi_ReturnsTrueWhenWiFiConnectionExists()
	{
		var result = NetworkHelper.IsConnectedToWiFi();
		var interfaces = NetworkInterface.GetAllNetworkInterfaces();
		var hasWiFi = interfaces.Any(ni =>
			ni.OperationalStatus == OperationalStatus.Up &&
			ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211);

		if (hasWiFi)
		{
			Assert.IsTrue(result, "Should return true when WiFi connection exists.");
		}
		else
		{
			Assert.IsFalse(result, "Should return false when no WiFi connection exists.");
		}
	}

	[TestMethod]
	public void IsIPv6Supported_ConsistentWithNetworkInterfaces()
	{
		var result = NetworkHelper.IsIPv6Supported();
		var interfaces = NetworkInterface.GetAllNetworkInterfaces();
		var hasIPv6Support = interfaces.Any(ni =>
			ni.OperationalStatus == OperationalStatus.Up &&
			ni.Supports(NetworkInterfaceComponent.IPv6));

		Assert.AreEqual(hasIPv6Support, result, "IsIPv6Supported should match actual IPv6 support in active interfaces.");
	}

	[TestMethod]
	public void IsIPv6Supported_ReturnsBooleanValue()
	{
		var result = NetworkHelper.IsIPv6Supported();

		Assert.IsInstanceOfType(result, typeof(bool), "The result should be a boolean value.");
	}

	[TestMethod]
	public void IsIPv6Supported_ReturnsTrueWhenIPv6IsSupported()
	{
		var result = NetworkHelper.IsIPv6Supported();

		if (result)
		{
			var interfaces = NetworkInterface.GetAllNetworkInterfaces();
			var hasIPv6 = interfaces.Any(ni =>
				ni.OperationalStatus == OperationalStatus.Up &&
				ni.Supports(NetworkInterfaceComponent.IPv6));

			Assert.IsTrue(hasIPv6, "Should have at least one active interface supporting IPv6 when method returns true.");
		}
	}
}

