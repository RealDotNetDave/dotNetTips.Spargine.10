// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-10-2025
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for Enum.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Enum" /> type, enhancing enum functionality with additional utilities such as getting descriptions, parsing, and retrieving items.
/// </summary>
[Information(Documentation = "https://bit.ly/SpargineEnumExtensions", Status = Status.Available)]
public static class EnumExtensions
{
	/// <summary>
	/// Parses the specified string to an enum of type <typeparamref name="T" />.
	/// </summary>
	/// <typeparam name="T">The enum type to which the string will be parsed.</typeparam>
	/// <param name="name">The string representation of the enum value to parse.</param>
	/// <returns>An enum of type <typeparamref name="T" /> corresponding to the parsed string.</returns>
	/// <exception cref="ArgumentException">Thrown if <paramref name="name" /> is null or an empty string, or if it does not correspond to any value of <typeparamref name="T" />.</exception>
	[Information(nameof(Parse), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public static T Parse<T>(this string name)
		where T : Enum
	{
		return EnumHelper.Parse<T>(name);
	}

	/// <summary>
	/// Provides extension methods for an <see cref="Enum"/> instance.
	/// </summary>
	/// <param name="input">The enum value to extend.</param>
	extension([DisallowNull] Enum input)
	{
		/// <summary>
		/// Gets the description of the enum value using the <see cref="EnumMemberAttribute" /> if available; otherwise, it returns the enum's name.
		/// </summary>
		/// <returns>
		/// The description of the enum value, or its name if no description is available.
		/// </returns>
		[Information(nameof(GetDescription), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, Status = Status.Available)]
		public string? GetDescription()
		{
			return EnumHelper.GetDescription(input);
		}

		/// <summary>
		/// Gets the names and values of an <see cref="Enum" />.
		/// This method returns a read-only collection of tuples, where each tuple contains the name (description) and the numeric value of each enum member.
		/// The description is obtained from the enum member's name itself.
		/// </summary>
		/// <returns>A <see cref="ReadOnlyCollection{T}" /> where T is a tuple of string and int, representing the description and value of each enum member.</returns>
		[Information(nameof(GetItems), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<(string Description, int Value)> GetItems()
		{
			var enumType = input.GetType();
			var enumValues = Enum.GetValues(enumType);
			var enumNames = Enum.GetNames(enumType);

			var items = new List<(string Description, int Value)>(enumValues.Length);

			for (var index = 0; index < enumValues.Length; index++)
			{
				items.Add((Description: enumNames[index], Value: Convert.ToInt32(enumValues.GetValue(index), CultureInfo.InvariantCulture)));
			}

			return items.ToReadOnlyCollection();
		}
	}
}
