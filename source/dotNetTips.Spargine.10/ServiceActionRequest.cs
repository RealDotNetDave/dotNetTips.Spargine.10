// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-22-2025
// ***********************************************************************
// <copyright file="ServiceActionRequest.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine;

/// <summary>
/// Defines the request types for a service action.
/// </summary>
public enum ServiceActionRequest
{
	/// <summary>
	/// Represents an unknown request. This is the default value.
	/// </summary>
	Unknown,

	/// <summary>
	/// Represents a request to start the service.
	/// </summary>
	Start,

	/// <summary>
	/// Represents a request to stop the service.
	/// </summary>
	Stop,
}
