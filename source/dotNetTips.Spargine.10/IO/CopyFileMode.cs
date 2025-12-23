// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 11-02-2023
//
// Last Modified By : David McCarter
// Last Modified On : 05-22-2025
// ***********************************************************************
// <copyright file="CopyFileMode.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Copy File Mode values for CopyFileEx</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)


namespace DotNetTips.Spargine.IO;

/// <summary>
/// Defines copy file modes for use with CopyFileEx method.
/// </summary>
[Flags]
public enum CopyFileMode : uint
{
	/// <summary>
	/// The operation fails if the target file already exists.
	/// </summary>
	FailIfExists = 0x00000001,

	/// <summary>
	/// The copy operation is restartable.
	/// </summary>
	Restartable = 0x00000002,

	/// <summary>
	/// Opens the source file with write permissions.
	/// </summary>
	OpenSourceForWrite = 0x00000004,

	/// <summary>
	/// Allows the destination file to be decrypted.
	/// </summary>
	AllowDecryptedDestination = 0x00000008,

	/// <summary>
	/// Copies the symbolic link itself rather than the target of the link.
	/// </summary>
	CopySymlink = 0x00000800,

	/// <summary>
	/// Copies data to the target file without using the Windows cache manager.
	/// </summary>
	NoBuffering = 0x00001000
}

