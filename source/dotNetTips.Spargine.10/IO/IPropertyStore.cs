// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 08-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2025
// ***********************************************************************
// <copyright file="IPropertyStore.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Defines the COM interface for accessing and manipulating property stores.</summary>
// ***********************************************************************

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace DotNetTips.Spargine.IO;

/// <summary>
/// COM interface for accessing and manipulating property stores.
/// Provides methods to enumerate, retrieve, set, and commit properties.
/// </summary>
[GeneratedComInterface]
[Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal partial interface IPropertyStore
{
	/// <summary>
	/// Gets the number of properties in the property store.
	/// </summary>
	/// <param name="cProps">When this method returns, contains the number of properties.</param>
	/// <returns>Returns HRESULT. S_OK if successful.</returns>
	[PreserveSig]
	public int GetCount(out uint cProps);

	/// <summary>
	/// Gets the <see cref="PROPERTYKEY"/> at the specified index.
	/// </summary>
	/// <param name="iProp">The index of the property.</param>
	/// <param name="pkey">When this method returns, contains the <see cref="PROPERTYKEY"/> at the specified index.</param>
	/// <returns>Returns HRESULT. S_OK if successful.</returns>
	[PreserveSig]
	public int GetAt(uint iProp, out PROPERTYKEY pkey);

	/// <summary>
	/// Gets the value of the property identified by the specified <see cref="PROPERTYKEY"/>.
	/// </summary>
	/// <param name="key">The <see cref="PROPERTYKEY"/> that identifies the property.</param>
	/// <param name="pv">When this method returns, contains the property value as a PropVariant.</param>
	/// <returns>Returns HRESULT. S_OK if successful.</returns>
	[PreserveSig]
	public int GetValue(ref PROPERTYKEY key, PropVariant pv);

	/// <summary>
	/// Sets the value of the property identified by the specified <see cref="PROPERTYKEY"/>.
	/// </summary>
	/// <param name="key">The <see cref="PROPERTYKEY"/> that identifies the property.</param>
	/// <param name="pv">The PropVariant containing the value to set.</param>
	/// <returns>Returns HRESULT. S_OK if successful.</returns>
	[PreserveSig]
	public int SetValue(ref PROPERTYKEY key, PropVariant pv);

	/// <summary>
	/// Commits changes to the property store.
	/// </summary>
	/// <returns>Returns HRESULT. S_OK if successful.</returns>
	[PreserveSig]
	public int Commit();
}
