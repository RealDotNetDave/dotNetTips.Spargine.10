// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-08-2026
// ***********************************************************************
// <copyright file="SocketExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <c>Socket</c> and <c>SocketsHttpConnectionContext</c> providing anonymous port
// binding (<c>BindToAnonymousPort</c>), buffer and keep-alive configuration (<c>ConfigureBufferSizes</c>,
// <c>ConfigureKeepAlive</c>, <c>ConfigureLinger</c>), TCP connection helpers (<c>ConnectTcpAsync</c>,
// <c>TryConnect</c>, <c>TryConnectAsync</c>), and non-blocking mode control (<c>ForceNonBlocking</c>).
// </summary>
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
/// Provides extension methods for <c>Socket</c> and <c>SocketsHttpConnectionContext</c> covering
/// anonymous port binding, buffer and keep-alive configuration, TCP connection helpers, and
/// non-blocking mode control.
/// </summary>
[Information(nameof(SocketExtensions), author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available, Documentation = "ADD URL")]
public static class SocketExtensions
{

	/// <summary>The maximum recommended buffer size in bytes for send and receive socket buffers (1 MB).</summary>
	public const int MaximumBufferSize = 1_048_576;

	/// <summary>The minimum allowed buffer size in bytes for send and receive socket buffers.</summary>
	public const int MinimumBufferSize = 4096;

	/// <summary>
	/// Binds the socket to the specified IP address using an operating-system-assigned port and returns the selected port number.
	/// </summary>
	/// <remarks>
	/// Especially useful for tests, development tools, temporary listeners, and other scenarios where manually selecting an available port would add unnecessary complexity.
	/// </remarks>
	/// <param name="socket">The socket to bind.</param>
	/// <param name="address">The IP address to bind to.</param>
	/// <returns>The port number assigned by the OS.</returns>
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
	/// Configures the socket's send and receive buffer sizes.
	/// </summary>
	/// <param name="socket">The <c>Socket</c> to configure. Must not be <c>null</c>.</param>
	/// <param name="sendBufferSize">
	/// The size, in bytes, of the send buffer. Must be between <see cref="MinimumBufferSize" /> (4 KB)
	/// and <see cref="MaximumBufferSize" /> (1 MB) inclusive. Values below 4 KB degrade throughput;
	/// values above 1 MB increase kernel memory pressure without measurable gain for most workloads.
	/// </param>
	/// <param name="receiveBufferSize">
	/// The size, in bytes, of the receive buffer. Must be between <see cref="MinimumBufferSize" /> (4 KB)
	/// and <see cref="MaximumBufferSize" /> (1 MB) inclusive. Values below 4 KB degrade throughput;
	/// values above 1 MB increase kernel memory pressure without measurable gain for most workloads.
	/// </param>
	/// <returns>The configured <c>Socket</c> for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown when <paramref name="sendBufferSize"/> or <paramref name="receiveBufferSize"/> is outside
	/// the range [<see cref="MinimumBufferSize"/>, <see cref="MaximumBufferSize"/>].
	/// </exception>
	/// <remarks>
	/// Explicit buffer configuration can be useful when tuning network behavior for workloads that transfer larger amounts of data or have specific throughput and memory requirements.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConfigureBufferSizes), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Socket ConfigureBufferSizes([DisallowNull] this Socket socket, int sendBufferSize, int receiveBufferSize)
	{
		socket = socket.ArgumentNotNull();
		sendBufferSize = sendBufferSize.ArgumentInRange(MinimumBufferSize, MaximumBufferSize);
		receiveBufferSize = receiveBufferSize.ArgumentInRange(MinimumBufferSize, MaximumBufferSize);

		socket.SendBufferSize = sendBufferSize;
		socket.ReceiveBufferSize = receiveBufferSize;

		return socket;
	}

	/// <summary>
	/// Enables TCP keep-alive for the socket and configures both the idle time before keep-alive probes begin and the interval between probes.
	/// </summary>
	/// <remarks>
	/// Keep-alive settings can help detect dead or unreachable connections instead of allowing inactive connections to linger indefinitely.
	/// </remarks>
	/// <param name="socket">The <c>Socket</c> to configure. Must not be <c>null</c>.</param>
	/// <param name="keepAliveTimeSeconds">The idle time, in seconds, before the first keep-alive probe is sent. Must be at least 1.</param>
	/// <param name="keepAliveIntervalSeconds">The interval, in seconds, between keep-alive probes. Must be at least 1.</param>
	/// <returns>The configured <c>Socket</c> for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> is <c>null</c>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConfigureKeepAlive), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	/// Configures the socket's linger behavior.
	/// </summary>
	/// <remarks>
	/// The linger state controls what happens when <c>Close()</c> is called while unsent data remains in the socket's transmission buffer, giving greater control over connection shutdown behavior.
	/// </remarks>
	/// <param name="socket">The <c>Socket</c> to configure. Must not be <c>null</c>.</param>
	/// <param name="enable">If <c>true</c>, the socket lingers after close; if <c>false</c>, it closes immediately.</param>
	/// <param name="lingerTimeSeconds">The linger duration in seconds when <paramref name="enable"/> is <c>true</c>. Must be at least 0.</param>
	/// <returns>The configured <c>Socket</c> for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> is <c>null</c>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConfigureLinger), author: "David McCarter", createdOn: "4/13/2026", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static Socket ConfigureLinger([DisallowNull] this Socket socket, bool enable, int lingerTimeSeconds)
	{
		socket = socket.ArgumentNotNull();
		lingerTimeSeconds = lingerTimeSeconds.EnsureMinimum(0);

		socket.LingerState = new LingerOption(enable, lingerTimeSeconds);

		return socket;
	}

	/// <summary>
	/// Asynchronously establishes a TCP connection using the endpoint supplied by <see cref="SocketsHttpConnectionContext" />.
	/// </summary>
	/// <remarks>
	/// This method supports cancellation through <see cref="CancellationToken" />, making it easier to integrate socket creation into modern asynchronous .NET networking code.
	/// </remarks>
	/// <param name="context">The connection context containing the DNS endpoint to connect to.</param>
	/// <param name="cancellationToken">A token to cancel the operation.</param>
	/// <returns>A <c>ValueTask{Stream}</c> that resolves to a <c>Stream</c> connected to the TCP server.</returns>
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
	[Information(nameof(ConnectTcpAsync), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
	/// Forces the socket into non-blocking mode.
	/// </summary>
	/// <remarks>
	/// Platform consideration: on non-Windows operating systems, once non-blocking mode has been enabled, it remains enabled for the lifetime of the socket.
	/// </remarks>
	/// <param name="socket">The <c>Socket</c> to modify. Must not be <c>null</c>.</param>
	/// <param name="force">If <c>true</c>, forces the socket into non-blocking mode.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static void ForceNonBlocking([DisallowNull] this Socket socket, bool force)
	{
		socket = socket.ArgumentNotNull();

		socket.Blocking = force;
	}

	/// <summary>
	/// Attempts to connect the socket to the specified <paramref name="remoteEndpoint" /> within the supplied timeout period.
	/// </summary>
	/// <remarks>
	/// This method provides a straightforward way to perform timeout-controlled connection attempts but is supported only on Windows.
	/// </remarks>
	/// <param name="socket">The <c>Socket</c> to use for the connection attempt. Must not be <c>null</c>.</param>
	/// <param name="remoteEndpoint">The <c>EndPoint</c> to connect to. Must not be <c>null</c>.</param>
	/// <param name="millisecondsTimeout">The maximum time in milliseconds to wait for the connection. Must be at least 1.</param>
	/// <returns><c>true</c> if the connection succeeds within the timeout; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> or <paramref name="remoteEndpoint"/> is <c>null</c>.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="millisecondsTimeout"/> is less than 1.</exception>
	/// <exception cref="PlatformNotSupportedException">Thrown on non-Windows platforms.</exception>
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
	/// Asynchronously attempts to connect the socket to the specified <paramref name="remoteEndpoint" /> within the supplied timeout.
	/// </summary>
	/// <remarks>
	/// Unlike <see cref="TryConnect(Socket, EndPoint, int)" />, this implementation is cross-platform and combines timeout handling with <see cref="CancellationToken" /> support, making it a better fit for modern asynchronous and cross-platform .NET applications.
	/// </remarks>
	/// <param name="socket">The <c>Socket</c> to use for the connection attempt. Must not be <c>null</c>.</param>
	/// <param name="remoteEndpoint">The <c>EndPoint</c> to connect to. Must not be <c>null</c>.</param>
	/// <param name="millisecondsTimeout">The maximum time in milliseconds to wait for the connection. Must be at least 1.</param>
	/// <param name="cancellationToken">A token to cancel the operation.</param>
	/// <returns><c>true</c> if the connection succeeds within the timeout; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="socket"/> or <paramref name="remoteEndpoint"/> is <c>null</c>.</exception>
	[Information(nameof(TryConnectAsync), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
