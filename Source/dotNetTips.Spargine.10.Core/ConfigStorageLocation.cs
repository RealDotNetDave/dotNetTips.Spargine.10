// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2024
// ***********************************************************************
// <copyright file="ConfigStorageLocation.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Enumeration utilized in Config.</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)


namespace DotNetTips.Spargine.Core;

/// <summary>
/// Defines the storage locations for configuration settings.
/// </summary>
public enum ConfigStorageLocation
{
	/// <summary>
	/// The configuration settings are stored in a location specific to the user, such as the user's profile folder.
	/// </summary>
	User,

	/// <summary>
	/// The configuration settings are stored in a location specific to the application, such as the application's installation directory.
	/// </summary>
	Application,
}
