// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-29-2025
// ***********************************************************************
// <copyright file="ServiceAction.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Diagnostics.CodeAnalysis;

namespace DotNetTips.Spargine;

/// <summary>
/// Represents a service action, encapsulating both the request and the result of the service action, along with the service name.
/// </summary>
[ExcludeFromCodeCoverage]
public sealed class ServiceAction
{

	/// <summary>
	/// Gets or sets the service action request.
	/// </summary>
	/// <value>The service action request. See <see cref="ServiceActionRequest"/> for the request details.</value>
	public ServiceActionRequest ServiceActionRequest
	{
		get; internal set;
	}


	/// <summary>
	/// Gets or sets the service action result.
	/// </summary>
	/// <value>The service action result. See <see cref="ServiceActionResult"/> for the result details.</value>
	public ServiceActionResult ServiceActionResult
	{
		get; internal set;
	}

	/// <summary>
	/// Gets or sets the name of the service.
	/// </summary>
	/// <value>The name of the service.</value>
	public string? ServiceName
	{
		get; internal set;
	}

}
