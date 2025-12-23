// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-26-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="StringType.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>String type for validating parameters/ values.</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)








namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines string validation types.
/// </summary>
public enum StringType
{
	/// <summary>
	/// Indicates that the string type is not set.
	/// </summary>
	NotSet,

	/// <summary>
	/// Validates that the string is an email address.
	/// </summary>
	Email,

	/// <summary>
	/// Validates that the string is a URL.
	/// </summary>
	Url
}
