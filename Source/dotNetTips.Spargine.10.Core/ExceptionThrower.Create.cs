// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 03-13-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="ExceptionThrower.Create.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core;

public static partial class ExceptionThrower
{
	/// <summary>
	/// Creates a <see cref="FileNotFoundException"/> with a specified file name.
	/// </summary>
	/// <param name="fileName">The name of the file that was not found.</param>
	/// <returns>A <see cref="FileNotFoundException"/> instance.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(CreateFileNotFoundException), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static FileNotFoundException CreateFileNotFoundException([DisallowNull] string fileName)
	{
		return new(Resources.ErrorFileNotFound, fileName);
	}

	/// <summary>
	/// Creates a <see cref="FileNotFoundException"/> with a specified message and file name.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="fileName">The name of the file that was not found.</param>
	/// <returns>A <see cref="FileNotFoundException"/> instance.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(CreateFileNotFoundException), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static FileNotFoundException CreateFileNotFoundException([AllowNull] string message, [DisallowNull] string fileName)
	{
		return new(message ?? Resources.ErrorFileNotFound, fileName);
	}

	/// <summary>
	/// Creates a <see cref="FileNotFoundException"/> with a specified message, file name, and inner exception.
	/// </summary>
	/// <param name="message">The error message that explains the reason for the exception. If null, a default error message is used.</param>
	/// <param name="fileName">The name of the file that was not found.</param>
	/// <param name="ex">The exception that is the cause of the current exception.</param>
	/// <returns>A <see cref="FileNotFoundException"/> instance.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(CreateFileNotFoundException), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static FileNotFoundException CreateFileNotFoundException([AllowNull] string message, [DisallowNull] string fileName, Exception ex)
	{
		return new(message ?? Resources.ErrorFileNotFound, fileName, ex);
	}

	/// <summary>
	/// Creates an <see cref="InvalidCastException"/> optionally including the parameter name.
	/// Centralizes creation so callers avoid duplicating message construction.
	/// </summary>
	/// <param name="message">Optional custom message.</param>
	/// <param name="paramName">Optional parameter name to include in the message.</param>
	/// <returns>An <see cref="InvalidCastException"/> instance.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromCodeCoverage(Justification = "Not needed for this pass-through method.")]
	[Information(nameof(CreateInvalidCastException), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static InvalidCastException CreateInvalidCastException([AllowNull] string message, [AllowNull] string paramName)
	{
		if (string.IsNullOrEmpty(paramName))
		{
			return new InvalidCastException(message ?? Resources.ErrorInvalidCast);
		}

		// Include param name in message for better diagnostics
		var finalMessage = (message ?? Resources.ErrorInvalidCast) + " ParamName: " + paramName;
		return new InvalidCastException(finalMessage);
	}
}
