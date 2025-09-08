using System.Diagnostics.CodeAnalysis;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Tester.Models.RefTypes;

/// <summary>
/// Class PersonComparer.
/// </summary>
public class PersonComparer : IEqualityComparer<Person>
{
	/// <summary>
	/// Determines whether the specified objects are equal.
	/// </summary>
	/// <param name="x">The first object of type to compare.</param>
	/// <param name="y">The second object of type to compare.</param>
	/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	public bool Equals([AllowNull] Person x, [AllowNull] Person y) => ReferenceEquals(x, y) ? true : x is null || y is null ? false : string.Equals(x.Id, y.Id, StringComparison.Ordinal);

	/// <summary>
	/// Returns a hash code for the specified object.
	/// </summary>
	/// <param name="obj">The object for which to get a hash code.</param>
	/// <returns>A hash code for the specified object.</returns>
	public int GetHashCode([DisallowNull] Person obj) => obj?.Id?.GetHashCode(StringComparison.Ordinal) ?? 0;

}
