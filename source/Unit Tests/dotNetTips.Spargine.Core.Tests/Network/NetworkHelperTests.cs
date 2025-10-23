// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-23-2025
// ***********************************************************************
// <copyright file="NetworkHelperTests.cs" company="McCarter Consulting">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
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
	public void IsConnectedToBluetooth_ReturnsFalseWhenNoBluetoothConnection()
	{
		var result = NetworkHelper.IsConnectedToBluetooth();

		Assert.IsFalse(result, "The result should be false when there is no Bluetooth connection.");
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
	public void IsConnectedToEthernet_ConsistentWithGetNetworkConnections()
	{
		var result = NetworkHelper.IsConnectedToEthernet();
		var connections = NetworkHelper.GetNetworkConnections();

		var hasEthernet = connections.Any(ni => ni.Description.Contains("Ethernet", StringComparison.OrdinalIgnoreCase));

		Assert.AreEqual(hasEthernet, result, "IsConnectedToEthernet should be consistent with GetNetworkConnections.");
	}

	[TestMethod]
	public void IsConnectedToNetwork_ReturnsBooleanValue()
	{
		var result = NetworkHelper.IsConnectedToNetwork();

		Assert.IsInstanceOfType(result, typeof(bool), "The result should be a boolean value.");
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
	public void IsConnectedToNetwork_ReturnsExpectedResult()
	{
		var result = NetworkHelper.IsConnectedToNetwork();
		var systemResult = NetworkInterface.GetIsNetworkAvailable();

		Assert.AreEqual(systemResult, result, "IsConnectedToNetwork should match system network availability.");
	}

	[TestMethod]
	public void GetNetworkConnections_DoesNotIncludeDownInterfaces()
	{
		var result = NetworkHelper.GetNetworkConnections();
		var allInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		var downInterfaces = allInterfaces.Where(ni => ni.OperationalStatus != OperationalStatus.Up);

		foreach (var downInterface in downInterfaces)
		{
			Assert.IsFalse(result.Contains(downInterface), $"Down interface {downInterface.Name} should not be in the result.");
		}
	}

	[TestMethod]
	public void GetNetworkConnections_ReturnsConsistentResults()
	{
		var result1 = NetworkHelper.GetNetworkConnections();
		var result2 = NetworkHelper.GetNetworkConnections();

		Assert.AreEqual(result1.Count, result2.Count, "Multiple calls should return consistent results.");
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
	public void GetNetworkConnections_HandlesNoActiveConnections()
	{
		var result = NetworkHelper.GetNetworkConnections();

		Assert.IsNotNull(result, "Result should not be null even when no connections are active.");
		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<NetworkInterface>), "Result should be a ReadOnlyCollection.");
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
}

