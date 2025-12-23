// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 10-27-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2025
// ***********************************************************************
// <copyright file="InvalidEnumTypeException.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Custom exception to be utilized when a value for an Enum is invalid.</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents an exception that is thrown when an invalid enumeration type is encountered.
/// </summary>
[Serializable]
[Information(nameof(InvalidEnumTypeException), OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
public class InvalidEnumTypeException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidEnumTypeException"/> class.
	/// </summary>
	public InvalidEnumTypeException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidEnumTypeException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public InvalidEnumTypeException([DisallowNull] string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="InvalidEnumTypeException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public InvalidEnumTypeException([DisallowNull] string message, Exception innerException) : base(message, innerException)
	{
	}
}
