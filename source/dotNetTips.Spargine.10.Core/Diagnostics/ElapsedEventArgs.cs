// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 07-31-2025
// ***********************************************************************
// <copyright file="ElapsedEventArgs.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************






namespace DotNetTips.Spargine.Core.Diagnostics;

/// <summary>
/// Provides data for events that report elapsed time.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="ElapsedEventArgs"/> class.
/// </remarks>
/// <param name="elapsed">The elapsed time.</param>
[Information(nameof(ElapsedEventArgs), "David McCarter", "05/08/2025", Status = Status.New)]
public class ElapsedEventArgs(TimeSpan elapsed) : EventArgs
{
	/// <summary>
	/// Gets the elapsed time.
	/// </summary>
	/// <value>The time span representing the elapsed time.</value>
	[Information(nameof(Elapsed), "David McCarter", "05/08/2025", UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.New)]
	public TimeSpan Elapsed { get; } = elapsed;
}
