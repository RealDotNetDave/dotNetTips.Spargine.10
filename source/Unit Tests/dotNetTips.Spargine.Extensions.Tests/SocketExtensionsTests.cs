// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 04-06-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-07-2026
// ***********************************************************************
// <copyright file="SocketExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class SocketExtensionsTests
{

	[TestMethod]
	public void BindToAnonymousPort_NullAddress_ThrowsArgumentNullException()
	{
		// Arrange
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => socket.BindToAnonymousPort(null));
	}

	[TestMethod]
	public void BindToAnonymousPort_NullSocket_ThrowsArgumentNullException()
	{
		// Arrange
		Socket socket = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => socket.BindToAnonymousPort(IPAddress.Loopback));
	}

	[TestMethod]
	public void BindToAnonymousPort_ValidIPv4Address_ReturnsValidPort()
	{
		// Arrange
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		// Act
		var port = socket.BindToAnonymousPort(IPAddress.Loopback);

		// Assert
		Assert.IsTrue(port > 0);
		Assert.IsTrue(port <= 65535);
	}

	[TestMethod]
	public void BindToAnonymousPort_ValidIPv6Address_ReturnsValidPort()
	{
		if (!Socket.OSSupportsIPv6)
		{
			Assert.Inconclusive("IPv6 is not supported on this platform.");
			return;
		}

		// Arrange
		using var socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);

		// Act
		var port = socket.BindToAnonymousPort(IPAddress.IPv6Loopback);

		// Assert
		Assert.IsTrue(port > 0);
		Assert.IsTrue(port <= 65535);
	}

	[TestMethod]
	public void BindToAnonymousPort_ValidSocket_ReturnsDifferentPorts()
	{
		// Arrange
		using var socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		using var socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		// Act
		var port1 = socket1.BindToAnonymousPort(IPAddress.Loopback);
		var port2 = socket2.BindToAnonymousPort(IPAddress.Loopback);

		// Assert
		Assert.AreNotEqual(port1, port2);
	}

	[TestMethod]
	public void ForceNonBlocking_ForceFalse_SetsBlockingToFalse()
	{
		// Arrange
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		// Act
		socket.ForceNonBlocking(false);

		// Assert
		Assert.IsFalse(socket.Blocking);
	}

	[TestMethod]
	public void ForceNonBlocking_ForceTrue_SetsBlockingToTrue()
	{
		// Arrange
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		// Act
		socket.ForceNonBlocking(true);

		// Assert
		Assert.IsTrue(socket.Blocking);
	}

	[TestMethod]
	public void ForceNonBlocking_NullSocket_ThrowsArgumentNullException()
	{
		// Arrange
		Socket socket = null;

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => socket.ForceNonBlocking(true));
	}

	[TestMethod]
	public void TryConnect_NonWindowsPlatform_ThrowsPlatformNotSupportedException()
	{
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			Assert.Inconclusive("This test is for non-Windows platforms only.");
			return;
		}

		// Arrange
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		var endpoint = new IPEndPoint(IPAddress.Loopback, 80);
		var timeout = RandomData.GenerateInteger(100, 5000);

		// Act & Assert
		_ = Assert.ThrowsExactly<PlatformNotSupportedException>(() => socket.TryConnect(endpoint, timeout));
	}

	[TestMethod]
	public void TryConnect_NullEndpoint_ThrowsArgumentNullException()
	{
		// Arrange
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		var timeout = RandomData.GenerateInteger(100, 5000);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => socket.TryConnect(null, timeout));
	}

	[TestMethod]
	public void TryConnect_NullSocket_ThrowsArgumentNullException()
	{
		// Arrange
		Socket socket = null;
		var endpoint = new IPEndPoint(IPAddress.Loopback, 80);
		var timeout = RandomData.GenerateInteger(100, 5000);

		// Act & Assert
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => socket.TryConnect(endpoint, timeout));
	}

	[TestMethod]
	public void TryConnect_WindowsPlatform_FailedConnection_ReturnsFalse()
	{
		if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			Assert.Inconclusive("This test requires Windows.");
			return;
		}

		// Arrange - Use a reserved test-network address so the connection attempt fails
		// deterministically without depending on a recently released local port.
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		var endpoint = new IPEndPoint(IPAddress.Parse("203.0.113.1"), 65535);

		// Act
		var result = socket.TryConnect(endpoint, 100);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void TryConnect_WindowsPlatform_PendingConnectionTimesOut_ReturnsFalse()
	{
		if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			Assert.Inconclusive("This test requires Windows.");
			return;
		}

		// Arrange
		// Use a documentation-only TEST-NET address so ConnectAsync does not complete
		// immediately with a local listener and instead exercises the timeout path.
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		var endpoint = new IPEndPoint(IPAddress.Parse("203.0.113.1"), 65000);
		const int timeout = 200;
		var started = Environment.TickCount64;

		// Act
		var result = socket.TryConnect(endpoint, timeout);
		var elapsed = Environment.TickCount64 - started;

		// Assert
		Assert.IsFalse(result);
		Assert.IsTrue(elapsed >= timeout - 25, $"Expected TryConnect to wait approximately {timeout}ms before timing out, but it returned after {elapsed}ms.");
	}

	[TestMethod]
	public void TryConnect_WindowsPlatform_SuccessfulConnection_ReturnsTrue()
	{
		if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			Assert.Inconclusive("This test requires Windows.");
			return;
		}

		// Arrange
		using var listener = new TcpListener(IPAddress.Loopback, 0);
		listener.Start();
		var port = ((IPEndPoint)listener.LocalEndpoint).Port;

		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		var endpoint = new IPEndPoint(IPAddress.Loopback, port);

		// Act
		var result = socket.TryConnect(endpoint, 5000);

		// Assert
		Assert.IsTrue(result);

		listener.Stop();
	}

	[TestMethod]
	public void TryConnect_WindowsPlatform_TimeoutLessThanOne_ClampedToMinimum_ReturnsFalse()
	{
		if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			Assert.Inconclusive("This test requires Windows.");
			return;
		}

		// Arrange - EnsureMinimum(1) clamps 0 to 1ms, so TryConnect proceeds without throwing
		using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		var endpoint = new IPEndPoint(IPAddress.Parse("203.0.113.1"), 65000);

		// Act
		var result = socket.TryConnect(endpoint, 0);

		// Assert - connection to non-routable address with 1ms timeout should fail
		Assert.IsFalse(result);
	}

}
