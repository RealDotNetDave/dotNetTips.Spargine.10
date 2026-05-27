// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 10-22-2023
//
// Last Modified By : David McCarter
// Last Modified On : 05-27-2026
// ***********************************************************************
// <copyright file="LibraryImport.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>API Calls</summary>
// ***********************************************************************

using System.Runtime.InteropServices;
using static DotNetTips.Spargine.IO.FileHelper;

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides P/Invoke method signatures for Windows API calls.
/// </summary>
/// <remarks>
/// This class contains methods that are used to invoke native system calls from the Windows Kernel32.dll, Shell32.dll, and Propsys.dll.
/// The methods within are used for file operations and property store access with advanced options not available through managed code.
/// </remarks>
internal static partial class LibraryImport
{
	/// <summary>
	/// Copies an existing file to a new file, notifying the application of its progress through a callback function.
	/// </summary>
	/// <param name="lpExistingFileName">The name of the existing file.</param>
	/// <param name="lpNewFileName">The name of the new file.</param>
	/// <param name="lpProgressRoutine">A callback function that is called each time another portion of the file has been copied. This function is of type <see cref="CopyProgressRoutine"/>.</param>
	/// <param name="lpData">An argument to be passed to the callback function. This is a pointer to the data used by the callback function.</param>
	/// <param name="pbCancel">A reference to an integer that, if set to TRUE during the copy operation, cancels the operation. Otherwise, the copy operation will continue to completion.</param>
	/// <param name="dwCopyFlags">Flags that specify how the file is to be copied. This parameter can be one or more of the values defined in the <see cref="CopyFileMode"/> enumeration.</param>
	/// <returns><c>true</c> if the file was successfully copied; otherwise, <c>false</c>.</returns>
	[LibraryImport("kernel32.dll", EntryPoint = "CopyFileExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static partial bool CopyFileEx(string lpExistingFileName, string lpNewFileName, [MarshalAs(UnmanagedType.FunctionPtr)] CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref int pbCancel, CopyFileMode dwCopyFlags);

	/// <summary>
	/// Retrieves a <see cref="PROPERTYKEY"/> structure from a canonical property name.
	/// </summary>
	/// <param name="pszName">The canonical name of the property.</param>
	/// <param name="pkey">When this method returns, contains the <see cref="PROPERTYKEY"/> that corresponds to the specified property name.</param>
	/// <returns>Returns HRESULT. S_OK if successful.</returns>
	[LibraryImport("propsys.dll", StringMarshalling = StringMarshalling.Utf16)]
	[DefaultDllImportSearchPaths(DllImportSearchPath.SafeDirectories)]
	internal static partial int PSGetPropertyKeyFromName(string pszName, out PROPERTYKEY pkey);
}
