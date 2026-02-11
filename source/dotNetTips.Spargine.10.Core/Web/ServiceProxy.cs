// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-11-2026
// ***********************************************************************
// <copyright file="ServiceProxy.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Generates a service proxy for types that implement
// ICommunicationObject, enabling communication with such objects.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Description;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Web;

/// <summary>
/// Provides a base class for creating service proxies that manage communication channels for WCF services.
/// </summary>
/// <typeparam name="T">
/// The service contract interface that defines the operations available on the service.
/// Must implement <see cref="ICommunicationObject"/> to enable channel communication.
/// </typeparam>
/// <remarks>
/// This abstract class handles the lifecycle of WCF service channels, including creation, initialization,
/// and disposal. It uses lazy initialization to create channels only when needed and ensures thread-safe
/// operations through internal locking mechanisms.
/// <para>
/// Derived classes must implement the service contract specified by the generic type parameter <typeparamref name="T"/>.
/// The channel factory and communication channel are automatically managed, providing a simplified interface
/// for service communication.
/// </para>
/// <para>
/// This class implements <see cref="IDisposable"/> to ensure proper cleanup of WCF resources,
/// including the channel and channel factory. Always dispose of instances when finished to prevent resource leaks.
/// </para>
/// </remarks>
/// <example>
/// Example usage of creating a service proxy:
/// <code>
/// public class MyServiceProxy : ServiceProxy&lt;IMyService&gt;
/// {
///     public MyServiceProxy(ServiceEndpoint endpoint) : base(endpoint)
///     {
///     }
///     
///     public string GetData()
///     {
///         return Channel.GetData();
///     }
/// }
/// 
/// // Usage
/// using var proxy = new MyServiceProxy(serviceEndpoint);
/// var data = proxy.GetData();
/// </code>
/// </example>
public abstract class ServiceProxy<T> : IDisposable where T : ICommunicationObject
{
	private readonly Lock _lock = new();
	private readonly ServiceEndpoint _serviceEndpoint;
	private T? _channel;
	private ChannelFactory<T>? _channelFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="ServiceProxy{T}"/> class with the specified service endpoint.
	/// </summary>
	/// <param name="serviceEndpoint">
	/// The <see cref="ServiceEndpoint"/> that defines the address, binding, and contract information
	/// used to communicate with the service. Must not be <c>null</c>.
	/// </param>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="serviceEndpoint"/> is <c>null</c>.
	/// </exception>
	/// <remarks>
	/// The service endpoint is used to create the channel factory when the <see cref="Channel"/> property
	/// is first accessed. The channel factory and channel creation are deferred until needed,
	/// implementing a lazy initialization pattern.
	/// </remarks>
	protected ServiceProxy([NotNull] ServiceEndpoint serviceEndpoint)
	{
		this._serviceEndpoint = serviceEndpoint;
	}

	/// <summary>
	/// Gets the communication channel used to interact with the service. This property ensures the channel is initialized before use.
	/// </summary>
	/// <value>The communication channel.</value>
	/// <remarks>
	/// The channel is lazily initialized upon first access to ensure efficient use of resources. This design supports the efficient management of service connections.
	/// </remarks>
	protected T Channel
	{
		get
		{
			this.Initialize();
			return this._channel ?? throw new InvalidOperationException(Resources.ChannelIsNotInitialized);
		}

		private set
		{
			this._channel = value;
		}
	}

	/// <summary>
	/// Gets or sets a value indicating whether the <see cref="ServiceProxy{T}"/> is disposed.
	/// </summary>
	/// <value><c>true</c> if this instance is disposed; otherwise, <c>false</c>.</value>
	/// <remarks>
	/// This property is used internally to track the disposal state of the service proxy instance,
	/// ensuring that resources are not inadvertently released more than once.
	/// </remarks>
	protected bool Disposed { get; set; }

	/// <summary>
	/// Disposes of the resources (other than memory) used by the <see cref="ServiceProxy{T}"/>.
	/// </summary>
	/// <remarks>
	/// This method disposes the service proxy's resources by calling the protected virtual Dispose method with the disposing parameter set to true.
	/// It then calls GC.SuppressFinalize to take this object off the finalization queue and prevent finalization code for this object
	/// from executing a second time.
	/// </remarks>
	[Preserve(PreserveReason.MethodPartOfIDisposable, "4/16/2023", "David McCarter")]
	public void Dispose()
	{
		this.Dispose(true);

		// Unregister object for finalization.
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Closes the communication channel with the service, ensuring a graceful shutdown of the connection.
	/// </summary>
	/// <remarks>
	/// This method checks if the channel exists and is not already disposed before attempting to close it.
	/// It's designed to be called from within the class or by derived classes to ensure resources are properly released.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected void CloseChannel()
	{
		if (this.Channel is not null && this.Disposed is false)
		{
			this.Channel.Close();
		}
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	/// <remarks>
	/// If <paramref name="disposing"/> is <c>true</c>, the method disposes of managed resources (like the channel and channel factory).
	/// This method is called by the public Dispose method and the <see cref="GC.SuppressFinalize"/> method to release managed and unmanaged resources.
	/// </remarks>
	protected virtual void Dispose(bool disposing)
	{
		// Do nothing if the object has already been disposed of.
		if (this.Disposed)
		{
			return;
		}

		if (disposing)
		{
			lock (this._lock)
			{
				// Release disposable objects used by this instance here.
				(this._channel as IDisposable)?.Dispose();
				(this._channelFactory as IDisposable)?.Dispose();
			}
		}

		// Remember that the object has been disposed of.
		this.Disposed = true;
	}

	/// <summary>
	/// Initializes the service proxy by creating a channel factory and channel based on the provided service endpoint.
	/// Ensures that only one channel is created per instance, using a thread-safe initialization pattern.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void Initialize()
	{
		lock (this._lock)
		{
			if (this.Channel is not null)
			{
				return;
			}
			(this._channelFactory as IDisposable)?.Dispose();

			this._channelFactory = new ChannelFactory<T>(this._serviceEndpoint);

			this.Channel = this._channelFactory.CreateChannel(new EndpointAddress(this._serviceEndpoint.Address.Uri));
		}
	}

}
