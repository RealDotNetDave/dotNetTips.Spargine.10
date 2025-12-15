// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 08-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2025
// ***********************************************************************
// <copyright file="FilePropertyWriter.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides methods for setting Windows Explorer file properties using canonical property names.</summary>
// ***********************************************************************

using System.ComponentModel;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides static methods for setting Windows Explorer file properties such as authors, comments, tags, and title.
/// Properties are set using canonical property names (e.g., "System.Title") and the Windows Property System.
/// </summary>
[Information(Status = Status.New)]
public static class FilePropertyWriter
{
	/// <summary>
	/// Retrieves a <see cref="PROPERTYKEY"/> from a canonical property name.
	/// </summary>
	/// <param name="canonicalName">The canonical property name (e.g., "System.Title").</param>
	/// <returns>The <see cref="PROPERTYKEY"/> corresponding to the specified canonical name.</returns>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	private static PROPERTYKEY GetPropertyKeyFromCanonicalName(string canonicalName)
	{
		var hr = LibraryImport.PSGetPropertyKeyFromName(canonicalName, out var key);

		ThrowIfFailed(hr, $"PSGetPropertyKeyFromName('{canonicalName}')");

		return key;
	}

	/// <summary>
	/// Opens the property store for the specified file path with the given access flags.
	/// </summary>
	/// <param name="filePath">The path to the file.</param>
	/// <param name="flags">Flags that control how the property store is retrieved.</param>
	/// <returns>An <see cref="IPropertyStore"/> for the specified file.</returns>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	private static IPropertyStore OpenPropertyStore(string filePath, GETPROPERTYSTOREFLAGS flags)
	{
		var iid = typeof(IPropertyStore).GUID;
		var hr = LibraryImport.SHGetPropertyStoreFromParsingName(
			filePath,
			nint.Zero,
			flags,
			ref iid,
			out var store);

		ThrowIfFailed(hr, "SHGetPropertyStoreFromParsingName");

		return store;
	}

	/// <summary>
	/// Sets a string property value for a file using its canonical property name.
	/// </summary>
	/// <param name="filePath">The path to the file.</param>
	/// <param name="canonicalName">The canonical property name (e.g., "System.Title").</param>
	/// <param name="value">The string value to set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> or <paramref name="canonicalName"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	private static void SetPropStringInternal(string filePath, string canonicalName, string value)
	{
		filePath = filePath.ArgumentNotNullOrEmpty();
		canonicalName = canonicalName.ArgumentNotNullOrEmpty();

		var pkey = GetPropertyKeyFromCanonicalName(canonicalName);

		var store = OpenPropertyStore(filePath, GETPROPERTYSTOREFLAGS.GPS_READWRITE);

		// With this line:
		var hr = store.SetValue(ref pkey, value ?? string.Empty);

		ThrowIfFailed(hr, "IPropertyStore.SetValue");

		hr = store.Commit();
		ThrowIfFailed(hr, "IPropertyStore.Commit");

	}

	/// <summary>
	/// Throws a <see cref="Win32Exception"/> if the HRESULT indicates failure.
	/// </summary>
	/// <param name="hresult">The HRESULT value to check.</param>
	/// <param name="api">The name of the API call for error reporting.</param>
	/// <exception cref="Win32Exception">Thrown if <paramref name="hresult"/> is not S_OK (0).</exception>
	private static void ThrowIfFailed(in int hresult, string api)
	{
		if (hresult != 0)
		{
			// LibraryImport(SetLastError = true) allows retrieving a Win32 error if one was set.
			var win32 = Marshal.GetLastPInvokeError();
			var msg = $"{api} failed. HRESULT=0x{hresult:X8}{(win32 != 0 ? $", Win32=0x{win32:X8}" : string.Empty)}";

			throw new Win32Exception(hresult, msg);
		}
	}

	/// <summary>
	/// Sets the "System.Author" property for a file. Multiple authors typically appear as a semicolon-separated list in Explorer.
	/// </summary>
	/// <param name="filePath">The path to the file.</param>
	/// <param name="authors">The authors to set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	[Information(nameof(SetAuthors), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SetAuthors(string filePath, params string[] authors)
	{
		SetString(filePath, "System.Author", string.Join("; ", authors ?? []));
	}

	/// <summary>
	/// Sets the "System.Comment" property for a file.
	/// </summary>
	/// <param name="filePath">The path to the file.</param>
	/// <param name="comments">The comments to set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	[Information(nameof(SetComments), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SetComments(string filePath, string comments)
	{
		SetString(filePath, "System.Comment", comments);
	}

	/// <summary>
	/// Sets an Explorer property using its canonical name (e.g., "System.Title").
	/// </summary>
	/// <param name="filePath">The path to the file.</param>
	/// <param name="canonicalPropertyName">The canonical property name.</param>
	/// <param name="value">The string value to set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> or <paramref name="canonicalPropertyName"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	[Information(nameof(SetString), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SetString(string filePath, string canonicalPropertyName, string value)
	{
		SetPropStringInternal(filePath, canonicalPropertyName, value);
	}

	/// <summary>
	/// Sets the "System.Keywords" property for a file. Multiple tags/keywords typically appear as a semicolon-separated list in Explorer.
	/// </summary>
	/// <param name="filePath">The path to the file.</param>
	/// <param name="tags">The tags/keywords to set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	[Information(nameof(SetTags), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SetTags(string filePath, params string[] tags)
	{
		SetString(filePath, "System.Keywords", string.Join("; ", tags ?? []));
	}

	/// <summary>
	/// Sets the "System.Title" property for a file.
	/// </summary>
	/// <param name="filePath">The path to the file.</param>
	/// <param name="title">The title to set.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	[Information(nameof(SetTitle), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SetTitle(string filePath, string title)
	{
		SetString(filePath, "System.Title", title);
	}
}
