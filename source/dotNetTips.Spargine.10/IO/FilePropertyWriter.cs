// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 08-25-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-28-2026
// ***********************************************************************
// <copyright file="FilePropertyWriter.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Provides methods for setting Windows Explorer file properties using canonical property names.</summary>
// ***********************************************************************

using System.ComponentModel;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides static methods for setting Windows Explorer file properties such as authors, comments, tags, and title.
/// Properties are set using canonical property names (e.g., "System.Title") and the Windows Property System.
/// </summary>
/// <remarks>
/// This class provides a simple, type-safe interface to the Windows Property System for setting common file metadata properties.
/// The Windows Property System uses canonical names (such as "System.Title", "System.Author") to uniquely identify properties
/// that are stored with files and displayed in Windows Explorer's Details pane, file properties dialog, and search results.
/// <para>
/// Properties set through this class are persisted in the file system and are compatible with Windows Search indexing,
/// allowing users to search and organize files based on these metadata values.
/// </para>
/// <para>
/// <b>Supported Properties:</b>
/// <list type="bullet">
/// <item><description><see cref="SetTitle(string, string)"/> - Sets the file's title (System.Title)</description></item>
/// <item><description><see cref="SetAuthors(string, string[])"/> - Sets the file's author(s) (System.Author)</description></item>
/// <item><description><see cref="SetComments(string, string)"/> - Sets the file's comments (System.Comment)</description></item>
/// <item><description><see cref="SetTags(string, string[])"/> - Sets the file's keywords/tags (System.Keywords)</description></item>
/// <item><description><see cref="SetString(string, string, string)"/> - Sets any property by canonical name</description></item>
/// </list>
/// </para>
/// <para>
/// <b>Requirements:</b>
/// <list type="bullet">
/// <item><description>Files must exist on disk before properties can be set</description></item>
/// <item><description>The file system must support extended attributes (NTFS, ReFS)</description></item>
/// <item><description>The calling application must have write permissions to the file</description></item>
/// </list>
/// </para>
/// <para>
/// <b>Example Usage:</b>
/// <code>
/// // Set multiple properties on a Word document
/// var filePath = @"C:\Documents\Report.docx";
/// FilePropertyWriter.SetTitle(filePath, "Annual Sales Report 2025");
/// FilePropertyWriter.SetAuthors(filePath, "John Doe", "Jane Smith");
/// FilePropertyWriter.SetComments(filePath, "Q4 financial analysis");
/// FilePropertyWriter.SetTags(filePath, "sales", "annual", "2025");
/// 
/// // Set a custom property using canonical name
/// FilePropertyWriter.SetString(filePath, "System.Subject", "Financial Reports");
/// </code>
/// </para>
/// </remarks>
/// <seealso href="https://learn.microsoft.com/en-us/windows/win32/properties/props">Windows Properties</seealso>
/// <seealso href="https://learn.microsoft.com/en-us/windows/win32/properties/property-system-overview">Property System Overview</seealso>
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

		var hr = store.SetValue(ref pkey, value ?? string.Empty);
		ThrowIfFailed(hr, "IPropertyStore.SetValue");

		hr = store.Commit();
		ThrowIfFailed(hr, "IPropertyStore.Commit");

		// Note: In .NET 10+, the COM object will be automatically released
		// when the Runtime Callable Wrapper (RCW) is garbage collected.
		// Explicit Marshal.ReleaseComObject is not supported with source-generated COM interop.
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
			var win32 = Marshal.GetLastPInvokeError();

			// Provide more context for common errors
			var additionalInfo = (hresult, win32) switch
			{
				(unchecked((int)0x80004005), 0x000036B7) => " The file type may not support extended properties, or the property handler is not installed.",
				_ => string.Empty
			};

			var msg = $"{api} failed. HRESULT=0x{hresult:X8}{(win32 != 0 ? $", Win32=0x{win32:X8}" : string.Empty)}{additionalInfo}";

			throw new Win32Exception(hresult, msg);
		}
	}

	/// <summary>
	/// Sets the "System.Author" property for a file. Multiple authors typically appear as a semicolon-separated list in Explorer.
	/// </summary>
	/// <param name="filePath">The path to the file whose author property will be set.</param>
	/// <param name="authors">An array of author names to set. If null or empty, the author property will be cleared. Multiple authors are joined with semicolon separators.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when setting the property.</exception>
	/// <remarks>
	/// This method uses the Windows Property System to set the System.Author property, which appears in Windows Explorer's Details pane and file properties dialog.
	/// The author names are combined into a single string separated by semicolons ("; ") before being stored.
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// FilePropertyWriter.SetAuthors(@"C:\Documents\MyFile.docx", "John Doe", "Jane Smith");
	/// // Results in "John Doe; Jane Smith" being set as the file's author property
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="SetComments(string, string)"/>
	/// <seealso cref="SetTags(string, ReadOnlySpan{string})"/>
	/// <seealso cref="SetTitle(string, string)"/>
	[Information(nameof(SetAuthors)
	public static void SetAuthors(string filePath, params ReadOnlySpan<string> authors)
	{
		SetString(filePath, "System.Author", string.Join("; ", authors));
	}

	/// <summary>
	/// Sets the "System.Comment" property for a file.
	/// </summary>
	/// <param name="filePath">The path to the file whose comment property will be set.</param>
	/// <param name="comments">The comment text to set. If null or empty, the comment property will be cleared.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when setting the property.</exception>
	/// <remarks>
	/// This method uses the Windows Property System to set the System.Comment property, which appears in Windows Explorer's Details pane and file properties dialog.
	/// The comment can contain descriptive information about the file's contents or purpose.
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// FilePropertyWriter.SetComments(@"C:\Documents\MyFile.docx", "Draft version - requires review");
	/// // Sets the file's comment property to the specified text
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="SetAuthors(string, string[])"/>
	/// <seealso cref="SetTags(string, string[])"/>
	/// <seealso cref="SetTitle(string, string)"/>
	[Information(nameof(SetComments), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SetComments(string filePath, string comments)
	{
		SetString(filePath, "System.Comment", comments);
	}

	/// <summary>
	/// Sets a Windows Explorer file property using its canonical name (e.g., "System.Title", "System.Author", "System.Keywords").
	/// </summary>
	/// <param name="filePath">The path to the file whose property will be set.</param>
	/// <param name="canonicalPropertyName">The canonical property name as defined by the Windows Property System (e.g., "System.Title", "System.Comment", "System.Keywords").</param>
	/// <param name="value">The string value to set for the property. If null or empty, the property will be cleared.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> or <paramref name="canonicalPropertyName"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when setting the property.</exception>
	/// <remarks>
	/// This method provides a general-purpose way to set any Windows file property that accepts string values using canonical property names.
	/// Use the specialized methods (<see cref="SetTitle"/>, <see cref="SetAuthors"/>, <see cref="SetComments"/>, <see cref="SetTags"/>) 
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
	/// FilePropertyWriter.SetString(@"C:\Documents\MyFile.docx", "System.Subject", "Project Documentation");
	/// // Sets the file's subject property to "Project Documentation"
	/// 
	/// FilePropertyWriter.SetString(@"C:\Documents\MyFile.docx", "System.Copyright", "© 2025 Acme Corp");
	/// // Sets the file's copyright property
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="SetTitle(string, string)"/>
	/// <seealso cref="SetAuthors(string, string[])"/>
	/// <seealso cref="SetComments(string, string)"/>
	/// <seealso cref="SetTags(string, string[])"/>
	[Information(nameof(SetString), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SetString(string filePath, string canonicalPropertyName, string value)
	{
		SetPropStringInternal(filePath, canonicalPropertyName, value);
	}

	/// <summary>
	/// Sets the "System.Keywords" property for a file. Multiple tags/keywords typically appear as a semicolon-separated list in Explorer.
	/// </summary>
	/// <param name="filePath">The path to the file whose keywords/tags property will be set.</param>
	/// <param name="tags">An array of keyword/tag strings to set. If null or empty, the keywords property will be cleared. Multiple tags are joined with semicolon separators.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when setting the property.</exception>
	/// <remarks>
	/// This method uses the Windows Property System to set the System.Keywords property, which appears in Windows Explorer's Details pane and file properties dialog.
	/// Keywords are used for searching and indexing files, making them easier to find through Windows Search.
	/// The keyword values are combined into a single string separated by semicolons ("; ") before being stored.
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// FilePropertyWriter.SetTags(@"C:\Documents\MyFile.docx", "important", "project", "draft");
	/// // Results in "important; project; draft" being set as the file's keywords property
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="SetAuthors(string, ReadOnlySpan{string})"/>
	/// <seealso cref="SetComments(string, string)"/>
	/// <seealso cref="SetTitle(string, string)"/>
	[Information(nameof(SetTags)
	public static void SetTags(string filePath, params ReadOnlySpan<string> tags)
	{
		SetString(filePath, "System.Keywords", string.Join("; ", tags));
	}

	/// <summary>
	/// Sets the "System.Title" property for a file.
	/// </summary>
	/// <param name="filePath">The path to the file whose title property will be set.</param>
	/// <param name="title">The title text to set. If null or empty, the title property will be cleared.</param>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="filePath"/> is null or empty.</exception>
	/// <exception cref="Win32Exception">Thrown if the native Windows API call fails when setting the property.</exception>
	/// <remarks>
	/// This method uses the Windows Property System to set the System.Title property, which appears in Windows Explorer's Details pane and file properties dialog.
	/// The title property is commonly used to provide a descriptive name for the file that differs from the filename.
	/// <para>
	/// <b>Example:</b>
	/// <code>
	/// FilePropertyWriter.SetTitle(@"C:\Documents\MyFile.docx", "Annual Report 2025");
	/// // Sets the file's title property to "Annual Report 2025"
	/// </code>
	/// </para>
	/// </remarks>
	/// <seealso cref="SetAuthors(string, string[])"/>
	/// <seealso cref="SetComments(string, string)"/>
	/// <seealso cref="SetTags(string, string[])"/>
	[Information(nameof(SetTitle), UnitTestStatus = UnitTestStatus.None, Status = Status.New)]
	public static void SetTitle(string filePath, string title)
	{
		SetString(filePath, "System.Title", title);
	}
}
