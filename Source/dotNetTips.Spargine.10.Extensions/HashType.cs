// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 10-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-07-2023
// ***********************************************************************
// <copyright file="HashType.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enum used in ComputeHash methods.</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)



namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Enum for HashType
/// </summary>
public enum HashType
{
	/// <summary>
	/// SHA256 hash
	/// </summary>
	SHA256,

	/// <summary>
	/// SHA384 hash
	/// </summary>
	SHA384,

	/// <summary>
	/// SHA512 hash
	/// </summary>
	SHA512
}
