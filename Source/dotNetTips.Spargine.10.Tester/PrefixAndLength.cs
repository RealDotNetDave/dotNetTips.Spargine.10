// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Tester
// Author           : David McCarter
// Created          : 03-13-2023
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="PrefixAndLength.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Represents a credit card prefix and its associated digit length,
// used internally by RandomCreditCardNumberGenerator.
// </summary>
// ***********************************************************************

using System.Diagnostics;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester;

/// <summary>
/// Represents a prefix and its associated length.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="PrefixAndLength"/> struct.
/// </remarks>
/// <param name="prefix">The prefix.</param>
/// <param name="length">The length.</param>
[DebuggerDisplay("{Prefix,nq}")]
[Serializable]
internal struct PrefixAndLength(string prefix, int length) : IEquatable<PrefixAndLength>
{

	/// <summary>
	/// Gets or sets the length.
	/// </summary>
	/// <value>The length.</value>
	public int Length { get; set; } = length;

	/// <summary>
	/// Gets or sets the prefix.
	/// </summary>
	/// <value>The prefix.</value>
	public string Prefix { get; set; } = prefix;

	/// <summary>
	/// Implements the == operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator ==(PrefixAndLength left, PrefixAndLength right) => left.Equals(right);
	/// <summary>
	/// Implements the != operator.
	/// </summary>
	/// <param name="left">The left.</param>
	/// <param name="right">The right.</param>
	/// <returns>The result of the operator.</returns>
	public static bool operator !=(PrefixAndLength left, PrefixAndLength right) => !(left == right);

	/// <summary>
	/// Determines whether the specified object is equal to the current object.
	/// </summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
	public override readonly bool Equals(object? obj) => obj is PrefixAndLength other && this.Equals(other);

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
	public readonly bool Equals(PrefixAndLength other) => string.Equals(this.Prefix, other.Prefix, StringComparison.Ordinal) && this.Length == other.Length;

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
	public override readonly int GetHashCode() => HashCode.Combine(this.Prefix, this.Length);

	/// <summary>
	/// Returns a string that represents this instance.
	/// </summary>
	/// <returns>A string that represents this instance.</returns>
	public override readonly string ToString() => $"{this.Prefix}, {this.Length}";
}
