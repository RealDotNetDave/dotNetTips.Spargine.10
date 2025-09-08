// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-20-2025
// ***********************************************************************
// <copyright file="StreamExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for Stream.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Stream"/> to enhance and simplify its use.
/// These methods include functionalities such as flushing and closing streams, and asynchronous read and write operations.
/// </summary>
[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available)]
public static class StreamExtensions
{

	/// <summary>
	/// Flushes and closes the specified <see cref="Stream"/>.
	/// </summary>
	/// <param name="stream">The <see cref="Stream"/> to flush and close.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FlushClose), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void FlushClose([AllowNull] this Stream stream)
	{
		if (stream is not null)
		{
			stream.Flush();
			stream.Close();
		}
	}
}
