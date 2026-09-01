// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-04-2026
//
// Last Modified By : David McCarter
// Last Modified On : 02-16-2026
// ***********************************************************************
// <copyright file="ExceptionMetadata.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Diagnostics;

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Represents metadata associated with an exception.
/// </summary>
/// <param name="IsLogged"> Gets or sets a value indicating whether the exception has been logged. </param>
/// <remarks>
/// This class is used internally to store additional information about exceptions, such as their logged state.
/// </remarks>
[Preserve("Used in ExceptionExtensions")]
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal sealed record ExceptionMetadata(bool IsLogged)
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ExceptionMetadata"/> class.
	/// </summary>
	public ExceptionMetadata() : this(false)
	{
	}

	/// <summary>
	/// Gets or sets a value indicating whether the exception has been logged.
	/// </summary>
	/// <value><c>true</c> if the exception has been logged; otherwise, <c>false</c>.</value>
	public bool IsLogged { get; internal set; } = IsLogged;

	private string GetDebuggerDisplay()
	{
		return this.ToString();
	}
}
