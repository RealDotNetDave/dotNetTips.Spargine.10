// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 08-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 08-25-2025
// ***********************************************************************
// <copyright file="GETPROPERTYSTOREFLAGS.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Defines flags for retrieving property stores.</summary>
// ***********************************************************************


namespace DotNetTips.Spargine.IO;

/// <summary>
/// Flags that control how property stores are retrieved.
/// </summary>
[Flags]
internal enum GETPROPERTYSTOREFLAGS : uint
{
	/// <summary>
	/// Default behavior for retrieving a property store.
	/// </summary>
	GPS_DEFAULT = 0x00000000,

	/// <summary>
	/// Requests read/write access to the property store.
	/// </summary>
	GPS_READWRITE = 0x00000002,
}
