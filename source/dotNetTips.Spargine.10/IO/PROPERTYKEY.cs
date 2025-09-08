// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 08-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 08-25-2025
// ***********************************************************************
// <copyright file="PROPERTYKEY.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Defines the PROPERTYKEY struct used for property identification in Windows Shell.</summary>
// ***********************************************************************

using System.Runtime.InteropServices;

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Represents a unique key that identifies a property in the Windows Shell.
/// Consists of a format identifier (FMTID) and a property identifier (PID).
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
internal struct PROPERTYKEY
{
	/// <summary>
	/// Gets or sets the format identifier (FMTID), which is a GUID that identifies the property set.
	/// </summary>
	public Guid fmtid;

	/// <summary>
	/// Gets or sets the property identifier (PID), which is a unique integer within the property set.
	/// </summary>
	public uint pid;
}
