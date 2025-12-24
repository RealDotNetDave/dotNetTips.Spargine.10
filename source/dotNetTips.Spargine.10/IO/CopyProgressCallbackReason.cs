// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-22-2025
// ***********************************************************************
// <copyright file="CopyProgressCallbackReason.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for working with files.</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Specifies the reason the callback function was called during a file copy operation.
/// </summary>
/// <remarks>
/// This enum is used in conjunction with the CopyFileEx method to indicate the progress of the copy operation.
/// </remarks>
public enum CopyProgressCallbackReason : uint
{
	/// <summary>
	/// Indicates that a chunk of the file has been copied.
	/// </summary>
	ChunkFinished = 0x00000000,

	/// <summary>
	/// Indicates that the copy operation is switching to a new stream.
	/// </summary>
	/// <remarks>
	/// This is typically used when copying files that contain alternate data streams.
	/// </remarks>
	StreamSwitch = 0x00000001
}

