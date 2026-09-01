// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2025
// ***********************************************************************
// <copyright file="ArgumentReadOnlyException.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary>
// Custom exception type for read-only argument values, such as
// collections.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents an error when a read-only argument, such as a collection, is modified.
/// </summary>
[Serializable]
[Information(nameof(ArgumentReadOnlyException), OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
public sealed class ArgumentReadOnlyException : ArgumentException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException"/> class with a default error message.
	/// </summary>
	public ArgumentReadOnlyException() : base(Resources.ErrorReadOnlyCollection)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException"/> class with a specified parameter name.
	/// </summary>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	public ArgumentReadOnlyException([DisallowNull] string paramName) : base(Resources.ErrorReadOnlyCollection, paramName)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException"/> class with a specified error message and parameter name.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	public ArgumentReadOnlyException([DisallowNull] string message, [DisallowNull] string paramName) : base(message, paramName)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public ArgumentReadOnlyException([DisallowNull] string message, [DisallowNull] Exception innerException) : base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ArgumentReadOnlyException"/> class with a specified error message, parameter name, and a reference to the inner exception that is the cause of this exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="paramName">The name of the parameter that caused the current exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
	public ArgumentReadOnlyException([DisallowNull] string message, [DisallowNull] string paramName, [DisallowNull] Exception innerException) : base(message, paramName, innerException)
	{
	}
}
