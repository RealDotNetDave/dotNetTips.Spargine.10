// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-14-2025
// ***********************************************************************
// <copyright file="FileProgressState.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>File progress state values for FileProcessor.cs</summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)


namespace DotNetTips.Spargine.IO;

/// <summary>
/// Enum FileProgressState
/// </summary>
/// <remarks>
/// Defines the possible states of a file or directory operation, such as copying, moving, or deleting.
/// </remarks>
public enum FileProgressState
{
	/// <summary>
	/// Indicates an error occurred during the operation.
	/// </summary>
	Error,

	/// <summary>
	/// Indicates the file was successfully deleted.
	/// </summary>
	FileDeleted,

	/// <summary>
	/// Indicates the directory was successfully deleted.
	/// </summary>
	DirectoryDeleted,

	/// <summary>
	/// Indicates the file was successfully moved.
	/// </summary>
	FileMoved,

	/// <summary>
	/// Indicates the directory was successfully moved.
	/// </summary>
	DirectoryMoved,

	/// <summary>
	/// Indicates the file was successfully copied.
	/// </summary>
	FileCopied,

	/// <summary>
	/// Indicates the directory was successfully copied.
	/// </summary>
	DirectoryCopied,
}
