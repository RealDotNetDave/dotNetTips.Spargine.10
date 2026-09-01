// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 03-05-2023
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2025
// ***********************************************************************
// <copyright file="NetworkConnectionException.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Custom exception to be used when there is a network networkInterface error.</summary>
// ***********************************************************************

using System.Net.NetworkInformation;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents errors that occur during network interface operations.
/// </summary>
[Serializable]
[Information(nameof(NetworkConnectionException), OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
public sealed class NetworkConnectionException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a default error message.
	/// </summary>
	public NetworkConnectionException() : base(Resources.NetworkConnectionIssue)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public NetworkConnectionException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	public NetworkConnectionException(string message, Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a specified error message and the network networkInterface that caused this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="networkInterface">The network networkInterface that caused the exception.</param>
	public NetworkConnectionException(string message, NetworkInterface networkInterface) : base(message) => this.NetworkInterface = networkInterface;

	/// <summary>
	/// Initializes a new instance of the <see cref="NetworkConnectionException"/> class with a specified error message, a reference to the inner exception that is the cause of this exception, and the network interface that caused this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
	/// <param name="networkInterface">The network interface that caused the exception.</param>
	public NetworkConnectionException(string message, Exception innerException, NetworkInterface networkInterface) : base(message, innerException) => this.NetworkInterface = networkInterface;

	/// <summary>
	/// Gets the network interface that caused the exception.
	/// </summary>
	public NetworkInterface? NetworkInterface { get; private set; }
}
