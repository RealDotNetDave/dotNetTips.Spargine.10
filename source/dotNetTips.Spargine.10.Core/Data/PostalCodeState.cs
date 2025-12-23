// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 01-10-2025
//
// Last Modified By : David McCarter
// Last Modified On : 09-01-2025
// ***********************************************************************
// <copyright file="PostalCodeState.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)



namespace DotNetTips.Spargine.Core.Data;

/// <summary>
/// Represents the state of a postal code validation.
/// </summary>
public enum PostalCodeState
{
	/// <summary>
	/// The postal code is invalid.
	/// </summary>
	Invalid,

	/// <summary>
	/// The postal code state is unknown.
	/// </summary>
	Unknown,

	/// <summary>
	/// The postal code is valid.
	/// </summary>
	Valid,
}
