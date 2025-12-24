// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 08-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 08-25-2025
// ***********************************************************************
// <copyright file="PropVariant.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Minimal PropVariant wrapper for VT_LPWSTR (strings). Dispose frees COM memory. Extend if you need more types (VT_FILETIME, vectors, etc.).</summary>
// ***********************************************************************

using System.Runtime.InteropServices;

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Minimal PropVariant wrapper for VT_LPWSTR (strings).
/// <para>Dispose frees COM memory. Extend if you need more types (VT_FILETIME, vectors, etc.).</para>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
internal sealed class PropVariant : IDisposable
{
	/// <summary>
	/// The variant type code (VT_*) for this PropVariant.
	/// </summary>
	[FieldOffset(0)] private ushort vt;

	/// <summary>
	/// Pointer to the string value if <c>vt</c> is <c>VT_LPWSTR</c>.
	/// </summary>
	[FieldOffset(8)] private nint pszVal;

	/// <summary>
	/// Variant type code for an empty value.
	/// </summary>
	private const ushort VT_EMPTY = 0;

	/// <summary>
	/// Variant type code for a Unicode string pointer.
	/// </summary>
	private const ushort VT_LPWSTR = 31;

	/// <summary>
	/// Initializes a new instance of the <see cref="PropVariant"/> class.
	/// Private to enforce factory usage.
	/// </summary>
	private PropVariant() { }

	/// <summary>
	/// Clears the value and frees any associated COM memory.
	/// </summary>
	private void Clear()
	{
		if (this.vt == VT_LPWSTR && this.pszVal != nint.Zero)
		{
			Marshal.FreeCoTaskMem(this.pszVal);
			this.pszVal = nint.Zero;
		}

		this.vt = VT_EMPTY;
	}

	/// <summary>
	/// Releases resources used by the <see cref="PropVariant"/> instance.
	/// </summary>
	public void Dispose()
	{
		this.Clear();
	}

	/// <summary>
	/// Creates a <see cref="PropVariant"/> instance from a string value.
	/// </summary>
	/// <param name="value">The string value to wrap. If <c>null</c>, an empty string is used.</param>
	/// <returns>A <see cref="PropVariant"/> containing the string value.</returns>
	public static PropVariant FromString(string value)
	{
		var pv = new PropVariant
		{
			vt = VT_LPWSTR,
			pszVal = Marshal.StringToCoTaskMemUni(value ?? string.Empty)
		};

		return pv;
	}
}
