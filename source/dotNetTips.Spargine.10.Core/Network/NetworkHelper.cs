// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 06-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-23-2025
// ***********************************************************************
// <copyright file="NetworkHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides helper methods for network-related operations.</summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;

namespace DotNetTips.Spargine.Core.Network;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

/// <summary>
/// Provides helper methods for network-related operations.
/// </summary>
[Information(Status = Status.NeedsDocumentation, Documentation = "")]
public static class NetworkHelper
{
	//TODO: ADD MORE HELPER METHODS

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
}
