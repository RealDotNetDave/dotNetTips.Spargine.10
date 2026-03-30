// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2026
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Extension methods designed for Enum.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="Enum" /> type, enhancing enum functionality with additional utilities such as getting descriptions, parsing, and retrieving items.
/// </summary>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineEnumHandling")]
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
		where T : struct, Enum
	{
		_ = EnumHelper.TryParse<T>(name, out var result);

		return result;
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
		/// <exception cref="ArgumentNullException">Thrown if input is null.</exception>
		/// <remarks>
		/// This method delegates to <see cref="EnumHelper.GetDescription(Enum)"/> and preserves any custom enum member descriptions.
		/// </remarks>
		[Information(nameof(GetDescription), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, Status = Status.Available)]
		public string? GetDescription()
		{
			return EnumHelper.GetDescription(input);
		}

		/// <summary>
		/// Gets the 32-bit integer value of the enum.
		/// </summary>
		/// <value>The integer representation of the enum value.</value>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToInt32), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
		public int ToInt32()
		{
			return Convert.ToInt32(input, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Gets the 64-bit integer value of the enum.
		/// </summary>
		/// <value>The long integer representation of the enum value.</value>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToInt64), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
		public long ToInt64()
		{
			return Convert.ToInt64(input, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Gets the custom attribute of type <typeparamref name="TAttribute"/> applied to the enum value.
		/// </summary>
		/// <typeparam name="TAttribute">The type of attribute to retrieve.</typeparam>
		/// <returns>The custom attribute if found; otherwise, null.</returns>
		[Information(nameof(GetAttribute), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
		public TAttribute? GetAttribute<TAttribute>() where TAttribute : Attribute
		{
			var memberInfo = input.GetType().GetMember(input.ToString());

			return memberInfo.Length > 0 ? memberInfo[0].GetCustomAttribute<TAttribute>() : null;
		}

		/// <summary>
		/// Gets the display name from the <see cref="DisplayAttribute"/> if present; otherwise returns the enum's name.
		/// </summary>
		/// <returns>The display name or enum name.</returns>
		[Information(nameof(GetDisplayName), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
		public string GetDisplayName()
		{
			var displayAttribute = input.GetAttribute<DisplayAttribute>();
			return displayAttribute?.GetName() ?? input.ToString();
		}

		/// <summary>
		/// Gets the individual flag values that are set in a flag enum.
		/// </summary>
		/// <returns>A collection of individual flag values that are set.</returns>
		/// <exception cref="ArgumentException">Thrown if the enum type is not decorated with <see cref="FlagsAttribute"/>.</exception>
		[Information(nameof(GetSetFlags), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
		public ReadOnlyCollection<Enum> GetSetFlags()
		{
			var enumType = input.GetType();

			if (!enumType.IsDefined(typeof(FlagsAttribute), false))
			{
				ExceptionThrower.ThrowArgumentException($"Enum type {enumType.Name} is not a flags enumeration.", nameof(input));
			}

			var flags = new List<Enum>();
			var values = Enum.GetValues(enumType);

			foreach (Enum value in values)
			{
				if (input.HasFlag(value) && Convert.ToInt64(value, CultureInfo.InvariantCulture) != 0)
				{
					flags.Add(value);
				}
			}

			return flags.ToReadOnlyCollection();
		}

		/// <summary>
		/// Gets the count of flags set in a flag enum.
		/// </summary>
		/// <value>The number of individual flags set.</value>
		[Information(nameof(get_FlagCount), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
		public int FlagCount
		{
			get
			{
				var enumType = input.GetType();

				if (!enumType.IsDefined(typeof(FlagsAttribute), false))
				{
					return 1;
				}

				var count = 0;
				var value = Convert.ToInt64(input, CultureInfo.InvariantCulture);

				while (value != 0)
				{
					count += (int)(value & 1);
					value >>= 1;
				}

				return count;
			}
		}

		/// <summary>
		/// Gets the next enum value in sequence, or the first value if at the end.
		/// </summary>
		/// <returns>The next enum value.</returns>
		[Information(nameof(Next), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
		public Enum Next()
		{
			var values = Enum.GetValues(input.GetType());
			var index = Array.IndexOf(values, input);

			return (index == -1 || index == values.Length - 1)
				? (Enum)values.GetValue(0)!
				: (Enum)values.GetValue(index + 1)!;
		}

		/// <summary>
		/// Gets the previous enum value in sequence, or the last value if at the beginning.
		/// </summary>
		/// <returns>The previous enum value.</returns>
		[Information(nameof(Previous), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
		public Enum Previous()
		{
			var values = Enum.GetValues(input.GetType());
			var index = Array.IndexOf(values, input);

			return (index <= 0)
				? (Enum)values.GetValue(values.Length - 1)!
				: (Enum)values.GetValue(index - 1)!;
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
