// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-13-2026
// ***********************************************************************
// <copyright file="SocketExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for Socket.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Socket"/> class, enhancing its functionality
/// with additional utility methods. These methods include binding to an anonymous port, forcing
/// non-blocking mode, and attempting connections with a timeout.
/// </summary>
[Information(nameof(SocketExtensions), author: "David McCarter", createdOn: "7/15/2020", Status = Status.NeedsDocumentation)]
public static class SocketExtensions
{
	/// <summary>
	/// Binds to an IP address and OS-assigned port. Returns the chosen port.
	/// Validates that <paramref name="socket" /> and <paramref name="address" /> is not null.
	/// </summary>
	/// <param name="socket">The socket.</param>
	/// <param name="address">The address.</param>
	/// <returns>System.Int32.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(BindToAnonymousPort), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int BindToAnonymousPort([DisallowNull] this Socket socket, [DisallowNull] IPAddress address)
	{
		socket = socket.ArgumentNotNull();
		address = address.ArgumentNotNull();

		socket.Bind(new IPEndPoint(address.ArgumentNotNull(), 0));

		return ((IPEndPoint)socket.LocalEndPoint!).Port;
	}

	/// <summary>
	/// Configures the send and receive buffer sizes for the specified <see cref="Socket"/>.
	/// Validates that <paramref name="socket"/> is not null and that both buffer sizes are at least 1.
	/// </summary>
	/// <param name="socket">The <see cref="Socket"/> to configure.</param>
	/// <param name="sendBufferSize">The size, in bytes, of the send buffer. Must be at least 1.</param>
	/// <param name="receiveBufferSize">The size, in bytes, of the receive buffer. Must be at least 1.</param>
	/// <returns>The configured <see cref="Socket"/> for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConfigureBufferSizes), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static Socket ConfigureBufferSizes([DisallowNull] this Socket socket, int sendBufferSize, int receiveBufferSize)
	{
		socket = socket.ArgumentNotNull();
		sendBufferSize = sendBufferSize.EnsureMinimum(1);
		receiveBufferSize = receiveBufferSize.EnsureMinimum(1);

		socket.SendBufferSize = sendBufferSize;
		socket.ReceiveBufferSize = receiveBufferSize;

		return socket;
	}

	/// <summary>
	/// Configures TCP keep-alive on the specified <see cref="Socket"/>. Enables keep-alive and sets
	/// <see cref="SocketOptionName.TcpKeepAliveTime"/> and <see cref="SocketOptionName.TcpKeepAliveInterval"/>.
	/// Validates that <paramref name="socket"/> is not null and that time/interval values are at least 1.
	/// </summary>
	/// <param name="socket">The <see cref="Socket"/> to configure.</param>
	/// <param name="keepAliveTimeSeconds">The idle time, in seconds, before the first keep-alive probe is sent. Must be at least 1.</param>
	/// <param name="keepAliveIntervalSeconds">The interval, in seconds, between keep-alive probes. Must be at least 1.</param>
	/// <returns>The configured <see cref="Socket"/> for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConfigureKeepAlive), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static Socket ConfigureKeepAlive([DisallowNull] this Socket socket, int keepAliveTimeSeconds, int keepAliveIntervalSeconds)
	{
		socket = socket.ArgumentNotNull();
		keepAliveTimeSeconds = keepAliveTimeSeconds.EnsureMinimum(1);
		keepAliveIntervalSeconds = keepAliveIntervalSeconds.EnsureMinimum(1);

		socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
		socket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveTime, keepAliveTimeSeconds);
		socket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveInterval, keepAliveIntervalSeconds);

		return socket;
	}

	/// <summary>
	/// Configures the linger state for the specified <see cref="Socket"/>, controlling how the socket
	/// behaves when data remains to be sent after <see cref="Socket.Close()"/> is called.
	/// Validates that <paramref name="socket"/> is not null and that <paramref name="lingerTimeSeconds"/> is at least 0.
	/// </summary>
	/// <param name="socket">The <see cref="Socket"/> to configure.</param>
	/// <param name="enable">If <c>true</c>, the socket will linger after close; if <c>false</c>, it will close immediately.</param>
	/// <param name="lingerTimeSeconds">The time, in seconds, to remain open after close when <paramref name="enable"/> is <c>true</c>. Must be at least 0.</param>
	/// <returns>The configured <see cref="Socket"/> for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConfigureLinger), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static Socket ConfigureLinger([DisallowNull] this Socket socket, bool enable, int lingerTimeSeconds)
	{
		socket = socket.ArgumentNotNull();
		lingerTimeSeconds = lingerTimeSeconds.EnsureMinimum(0);

		socket.LingerState = new LingerOption(enable, lingerTimeSeconds);

		return socket;
	}

	/// <summary>
	/// Connect TCP as an asynchronous operation.
	/// </summary>
	/// <param name="context">The context.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A <see cref="ValueTask{Stream}"/> that represents the asynchronous operation, which upon completion returns a <see cref="Stream"/> connected to the TCP server.</returns>
	/// <example>
	/// Here is how you can use the ConnectTcpAsync method:
	/// <code>
	/// var context = new SocketsHttpConnectionContext(new DnsEndPoint("example.com", 80));
	/// var cancellationToken = new CancellationToken();
	/// var stream = await SocketsHelper.ConnectTcpAsync(context, cancellationToken);
	/// // Use the stream for network operations
	/// </code>
	/// </example>
	/// <remarks>Original code by: Máňa Píchová.</remarks>
	[Information(nameof(ConnectTcpAsync), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static async ValueTask<Stream> ConnectTcpAsync([DisallowNull] this SocketsHttpConnectionContext context, CancellationToken cancellationToken = default)
	{
		context = context.ArgumentNotNull();

		// The following socket constructor will create a dual-mode socket on systems where IPV6 is available.
#pragma warning disable CA2000, IDISP001 // Ownership transfers to NetworkStream via ownsSocket: true.
		var socket = new Socket(SocketType.Stream, ProtocolType.Tcp)
		{
			/* Turn off Nagle's algorithm since it degrades performance in most HttpClient scenarios.*/
			NoDelay = true,
			DualMode = true,
		};
#pragma warning restore CA2000, IDISP001

		try
		{
			await socket.ConnectAsync(context.DnsEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

			// The stream takes ownership of the underlying socket,
			// closing it when it's disposed.
			return new NetworkStream(socket, ownsSocket: true);
		}
		catch
		{
			socket.Dispose();
			throw;
		}
	}

	/// <summary>
	/// On non-Windows platforms, once non-blocking is turned on (either explicitly or by performing an async
	/// operation), always stay in non-blocking mode.
	/// Validates that <paramref name="socket" /> is not null.
	/// </summary>
	/// <param name="socket">The <see cref="Socket"/> to modify.</param>
	/// <param name="force">if set to <c>true</c>, the <paramref name="socket"/> is forced into non-blocking mode.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void ForceNonBlocking([DisallowNull] this Socket socket, bool force)
	{
		socket = socket.ArgumentNotNull();

		socket.Blocking = force;
	}

	/// <summary>
	/// Tries to connect within the provided timeout interval. Useful to speed up "cannot connect" assertions on
	/// Windows. Validates that <paramref name="socket" /> and <paramref name="remoteEndpoint" /> are not null.
	/// </summary>
	/// <param name="socket">The <see cref="Socket"/> to use for the connection attempt.</param>
	/// <param name="remoteEndpoint">The <see cref="EndPoint"/> to which you want to connect.</param>
	/// <param name="millisecondsTimeout">The timeout in milliseconds for the connection attempt.</param>
	/// <returns><c>true</c> if the connection is successful within the timeout period; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> or <paramref name="remoteEndpoint"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeout"/> is less than 1.</exception>
	/// <exception cref="PlatformNotSupportedException">Thrown when the operation is not supported on the current platform, specifically non-Windows platforms.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static bool TryConnect([DisallowNull] this Socket socket, [DisallowNull] EndPoint remoteEndpoint, int millisecondsTimeout)
	{
		socket = socket.ArgumentNotNull();
		remoteEndpoint = remoteEndpoint.ArgumentNotNull();
		millisecondsTimeout = millisecondsTimeout.EnsureMinimum(1);

		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
		{
			using (var mre = new ManualResetEventSlim(false))
			{
				using (var sea = new SocketAsyncEventArgs() { RemoteEndPoint = remoteEndpoint, UserToken = mre })
				{
					sea.Completed += (s, e) => ((ManualResetEventSlim)e.UserToken!).Set();

					var pending = socket.ConnectAsync(sea);

					if (!pending || mre.Wait(millisecondsTimeout))
					{
						return sea.SocketError == SocketError.Success;
					}

					Socket.CancelConnectAsync(sea); // this will close the socket!

					// In case of time-out, ManualResetEventSlim is left un-disposed to avoid race conditions,
					// letting SafeHandle's finalizer to do the cleanup.
					return false;
				}
			}
		}
		else
		{
			throw new PlatformNotSupportedException();
		}
	}

	/// <summary>
	/// Asynchronously attempts to connect within the provided timeout interval. Unlike <see cref="TryConnect"/>,
	/// this method works cross-platform and uses modern async APIs with <see cref="CancellationToken"/>-based timeouts.
	/// Validates that <paramref name="socket"/> and <paramref name="remoteEndpoint"/> are not null.
	/// </summary>
	/// <param name="socket">The <see cref="Socket"/> to use for the connection attempt.</param>
	/// <param name="remoteEndpoint">The <see cref="EndPoint"/> to which you want to connect.</param>
	/// <param name="millisecondsTimeout">The timeout in milliseconds for the connection attempt. Must be at least 1.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns><c>true</c> if the connection is successful within the timeout period; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> or <paramref name="remoteEndpoint"/> is null.</exception>
	[Information(nameof(TryConnectAsync), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static async ValueTask<bool> TryConnectAsync([DisallowNull] this Socket socket, [DisallowNull] EndPoint remoteEndpoint, int millisecondsTimeout, CancellationToken cancellationToken = default)
	{
		socket = socket.ArgumentNotNull();
		remoteEndpoint = remoteEndpoint.ArgumentNotNull();
		millisecondsTimeout = millisecondsTimeout.EnsureMinimum(1);

		using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		timeoutCts.CancelAfter(millisecondsTimeout);

		try
		{
			await socket.ConnectAsync(remoteEndpoint, timeoutCts.Token).ConfigureAwait(false);
			return true;
		}
		catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
		{
			// Timeout expired, not caller cancellation.
			return false;
		}
	}

}
