// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 12-17-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2025
// ***********************************************************************
// <copyright file="FilePropertyReader.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides methods for reading Windows Explorer file properties using canonical property names.</summary>
// ***********************************************************************

using System.ComponentModel;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides static methods for reading Windows Explorer file properties such as authors, comments, tags, and title.
/// Properties are retrieved using canonical property names (e.g., "System.Title") and the Windows Property System.
/// </summary>
/// <remarks>
/// This class provides a simple, type-safe interface to the Windows Property System for reading common file metadata properties.
/// The Windows Property System uses canonical names (such as "System.Title", "System.Author") to uniquely identify properties
/// that are stored with files and displayed in Windows Explorer's Details pane, file properties dialog, and search results.
/// <para>
/// Properties read through this class are retrieved from the file system and reflect metadata set by users or applications.
/// These properties are also indexed by Windows Search for fast querying and filtering.
/// </para>
/// <para>
/// <b>Supported Properties:</b>
/// <list type="bullet">
/// <item><description><see cref="GetTitle(string)"/> - Gets the file's title (System.Title)</description></item>
/// <item><description><see cref="GetAuthors(string)"/> - Gets the file's author(s) (System.Author)</description></item>
/// <item><description><see cref="GetComments(string)"/> - Gets the file's comments (System.Comment)</description></item>
/// <item><description><see cref="GetTags(string)"/> - Gets the file's keywords/tags (System.Keywords)</description></item>
/// <item><description><see cref="GetString(string, string)"/> - Gets any property by canonical name</description></item>
/// </list>
/// </para>
/// <para>
/// <b>Requirements:</b>
/// <list type="bullet">
/// <item><description>Files must exist on disk before properties can be read</description></item>
/// <item><description>The file system must support extended attributes (NTFS, ReFS)</description></item>
/// <item><description>The calling application must have read permissions to the file</description></item>
/// </list>
/// </para>
/// <para>
/// <b>Example Usage:</b>
/// <code>
/// // Read multiple properties from a Word document
/// var filePath = @"C:\Documents\Report.docx";
/// var title = FilePropertyReader.GetTitle(filePath);
/// var authors = FilePropertyReader.GetAuthors(filePath);
/// var comments = FilePropertyReader.GetComments(filePath);
/// var tags = FilePropertyReader.GetTags(filePath);
/// 
/// Console.WriteLine($"Title: {title}");
/// Console.WriteLine($"Authors: {string.Join(", ", authors)}");
/// Console.WriteLine($"Comments: {comments}");
/// Console.WriteLine($"Tags: {string.Join(", ", tags)}");
/// 
/// // Read a custom property using canonical name
/// var subject = FilePropertyReader.GetString(filePath, "System.Subject");
/// Console.WriteLine($"Subject: {subject}");
/// </code>
/// </para>
/// </remarks>
/// <seealso href="https://learn.microsoft.com/en-us/windows/win32/properties/props">Windows Properties</seealso>
/// <seealso href="https://learn.microsoft.com/en-us/windows/win32/properties/property-system-overview">Property System Overview</seealso>
[Information(Status = Status.New)]
public static class FilePropertyReader
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
	/// Gets a string property value from a file using its canonical property name.
	/// </summary>
	/// <param name="filePath">The path to the file.</param>
	/// <param name="canonicalName">The canonical property name (e.g., "System.Title").</param>
	/// <returns>The property value as a string, or an empty string if the property is not set or is empty.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> or <paramref name="canonicalName"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native call fails.</exception>
	private static string GetPropStringInternal(string filePath, string canonicalName)
	{
		filePath = filePath.ArgumentNotNullOrEmpty();
		canonicalName = canonicalName.ArgumentNotNullOrEmpty();

		var pkey = GetPropertyKeyFromCanonicalName(canonicalName);

		var store = OpenPropertyStore(filePath, GETPROPERTYSTOREFLAGS.GPS_DEFAULT);

		try
		{
			using (var pv = PropVariant.FromString(string.Empty))
			{
				var hr = store.GetValue(ref pkey, pv);
				ThrowIfFailed(hr, "IPropertyStore.GetValue");

				// Assuming PropVariant has a method or property to get the string value.
				// If not, you may need to implement a conversion.
				return pv.ToString() ?? string.Empty;
			}
		}
		finally
		{
			// In .NET 10+, simply let the RCW be garbage collected
			// The finalizer will release the COM object
			if (store != null && Marshal.IsComObject(store))
			{
				// Force immediate cleanup of the COM wrapper
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
		}
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
	/// Gets the "System.Author" property from a file. Multiple authors are typically stored as a semicolon-separated list in Explorer.
	/// </summary>
	/// <param name="filePath">The path to the file whose author property will be retrieved.</param>
	/// <returns>An array of author names. Returns an empty array if the property is not set.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when reading the property.</exception>
	/// <remarks>
	/// This method uses the Windows Property System to read the System.Author property, which appears in Windows Explorer's Details pane and file properties dialog.
	/// Multiple authors are stored as a semicolon-separated string and are split into individual names.
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// var authors = FilePropertyReader.GetAuthors(@"C:\Documents\MyFile.docx");
	/// Console.WriteLine($"Authors: {string.Join(", ", authors)}");
	/// // Output might be: Authors: John Doe, Jane Smith
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="GetComments(string)"/>
	/// <seealso cref="GetTags(string)"/>
	/// <seealso cref="GetTitle(string)"/>
	[Information(nameof(GetAuthors), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string[] GetAuthors(string filePath)
	{
		var authorsString = GetString(filePath, "System.Author");

		if (string.IsNullOrWhiteSpace(authorsString))
		{
			return [];
		}

		return authorsString.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
	}

	/// <summary>
	/// Gets the "System.Comment" property from a file.
	/// </summary>
	/// <param name="filePath">The path to the file whose comment property will be retrieved.</param>
	/// <returns>The comment text, or an empty string if the property is not set.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when reading the property.</exception>
	/// <remarks>
	/// This method uses the Windows Property System to read the System.Comment property, which appears in Windows Explorer's Details pane and file properties dialog.
	/// The comment typically contains descriptive information about the file's contents or purpose.
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// var comments = FilePropertyReader.GetComments(@"C:\Documents\MyFile.docx");
	/// Console.WriteLine($"Comments: {comments}");
	/// // Output might be: Comments: Draft version - requires review
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="GetAuthors(string)"/>
	/// <seealso cref="GetTags(string)"/>
	/// <seealso cref="GetTitle(string)"/>
	[Information(nameof(GetComments), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string GetComments(string filePath)
	{
		return GetString(filePath, "System.Comment");
	}

	/// <summary>
	/// Gets a Windows Explorer file property using its canonical name (e.g., "System.Title", "System.Author", "System.Keywords").
	/// </summary>
	/// <param name="filePath">The path to the file whose property will be retrieved.</param>
	/// <param name="canonicalPropertyName">The canonical property name as defined by the Windows Property System (e.g., "System.Title", "System.Comment", "System.Keywords").</param>
	/// <returns>The property value as a string, or an empty string if the property is not set.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> or <paramref name="canonicalPropertyName"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when reading the property.</exception>
	/// <remarks>
	/// This method provides a general-purpose way to read any Windows file property that stores string values using canonical property names.
	/// Use the specialized methods (<see cref="GetTitle"/>, <see cref="GetAuthors"/>, <see cref="GetComments"/>, <see cref="GetTags"/>) 
	/// when available for better type safety and convenience.
	/// <para>
	/// Common canonical property names include:
	/// <list type="bullet">
	/// <item><description>System.Title - The file title</description></item>
	/// <item><description>System.Author - The file author(s)</description></item>
	/// <item><description>System.Comment - File comments</description></item>
	/// <item><description>System.Keywords - File tags/keywords</description></item>
	/// <item><description>System.Subject - File subject</description></item>
	/// <item><description>System.Copyright - Copyright information</description></item>
	/// </list>
	/// </para>
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// var subject = FilePropertyReader.GetString(@"C:\Documents\MyFile.docx", "System.Subject");
	/// Console.WriteLine($"Subject: {subject}");
	/// // Output might be: Subject: Project Documentation
	/// 
	/// var copyright = FilePropertyReader.GetString(@"C:\Documents\MyFile.docx", "System.Copyright");
	/// Console.WriteLine($"Copyright: {copyright}");
	/// // Output might be: Copyright: © 2025 Acme Corp
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="GetTitle(string)"/>
	/// <seealso cref="GetAuthors(string)"/>
	/// <seealso cref="GetComments(string)"/>
	/// <seealso cref="GetTags(string)"/>
	[Information(nameof(GetString), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string GetString(string filePath, string canonicalPropertyName)
	{
		return GetPropStringInternal(filePath, canonicalPropertyName);
	}

	/// <summary>
	/// Gets the "System.Keywords" property from a file. Multiple tags/keywords are typically stored as a semicolon-separated list in Explorer.
	/// </summary>
	/// <param name="filePath">The path to the file whose keywords/tags property will be retrieved.</param>
	/// <returns>An array of keyword/tag strings. Returns an empty array if the property is not set.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when reading the property.</exception>
	/// <remarks>
	/// This method uses the Windows Property System to read the System.Keywords property, which appears in Windows Explorer's Details pane and file properties dialog.
	/// Keywords are used for searching and indexing files, making them easier to find through Windows Search.
	/// Multiple keywords are stored as a semicolon-separated string and are split into individual tags.
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// var tags = FilePropertyReader.GetTags(@"C:\Documents\MyFile.docx");
	/// Console.WriteLine($"Tags: {string.Join(", ", tags)}");
	/// // Output might be: Tags: important, project, draft
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="GetAuthors(string)"/>
	/// <seealso cref="GetComments(string)"/>
	/// <seealso cref="GetTitle(string)"/>
	[Information(nameof(GetTags), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string[] GetTags(string filePath)
	{
		var tagsString = GetString(filePath, "System.Keywords");

		if (string.IsNullOrWhiteSpace(tagsString))
		{
			return [];
		}

		return tagsString.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
	}

	/// <summary>
	/// Gets the "System.Title" property from a file.
	/// </summary>
	/// <param name="filePath">The path to the file whose title property will be retrieved.</param>
	/// <returns>The title text, or an empty string if the property is not set.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when reading the property.</exception>
	/// <remarks>
	/// This method uses the Windows Property System to read the System.Title property, which appears in Windows Explorer's Details pane and file properties dialog.
	/// The title property is commonly used to provide a descriptive name for the file that differs from the filename.
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// var title = FilePropertyReader.GetTitle(@"C:\Documents\MyFile.docx");
	/// Console.WriteLine($"Title: {title}");
	/// // Output might be: Title: Annual Report 2025
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="GetAuthors(string)"/>
	/// <seealso cref="GetComments(string)"/>
	/// <seealso cref="GetTags(string)"/>
	[Information(nameof(GetTitle), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static string GetTitle(string filePath)
	{
		return GetString(filePath, "System.Title");
	}
}
