// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 10-03-2024
// ***********************************************************************
// <copyright file="UnhandledExceptionEventInformation.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// A custom exception designed for scenarios where an unhandled
// exception needs to be thrown.
// </summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Contains information about an unhandled exception event, including the exception and whether the application is terminating.
/// </summary>
[Information(nameof(UnhandledExceptionEventInformation), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed)]
public sealed class UnhandledExceptionEventInformation : IEventInformation
{
	/// <summary>
	/// Gets the exception that was unhandled and caused the event.
	/// </summary>
	/// <value>The exception that was not handled.</value>
	[NotNull]
	public Exception? Exception { get; internal set; }

	/// <summary>
	/// Gets a value indicating whether the application is terminating due to the unhandled exception.
	/// </summary>
	/// <value><c>true</c> if the application is terminating; otherwise, <c>false</c>.</value>
	public bool IsTerminating { get; internal set; }
}
