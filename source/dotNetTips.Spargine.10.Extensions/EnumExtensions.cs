// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
// ***********************************************************************
// <copyright file="EnumExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>
// Extension methods for <see cref="System.Enum"/> that enrich enum usage with description lookup,
// parsing, item enumeration, flag inspection, and navigation. Includes <c>GetAttribute</c>,
// <c>GetDescription</c>, <c>GetDisplayName</c>, <c>GetItems</c>, <c>GetSetFlags</c>,
// <c>FlagCount</c>, <c>Next</c>, <c>Parse</c>, <c>Previous</c>, <c>ToInt32</c>, and <c>ToInt64</c>.
// Both generic (trim-safe) and non-generic (<see cref="System.Enum"/>-based) overloads are provided.
// </summary>
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
/// Provides extension methods for the <see cref="Enum" /> type that enhance enum functionality
/// with description lookup, parsing, item enumeration, flag inspection, integer conversion, and
/// sequential navigation. Generic (trim-safe) overloads are provided alongside non-generic
/// <see cref="Enum" />-based overloads for scenarios where the concrete enum type is not known at
/// compile time.
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
	[Information(nameof(Parse), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static T Parse<T>(this string name)
		where T : struct, Enum
	{
		_ = EnumHelper.TryParse<T>(name, out var result);

		return result;
	}

	/// <summary>
	/// Provides trim-aware extension members for strongly typed enum values.
	/// </summary>
	/// <typeparam name="TEnum">The enum type.</typeparam>
	/// <param name="input">The enum value to extend.</param>
	extension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum>(TEnum input)
		where TEnum : struct, Enum
	{
		/// <summary>
		/// Gets the description of the enum value using enum metadata.
		/// </summary>
		/// <returns>The description of the enum value, or its name if no description is available.</returns>
		[Information(nameof(GetDescription), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, Status = Status.Available)]
		public string? GetDescription()
		{
			return EnumHelper.GetDescription(input);
		}

		/// <summary>
		/// Gets the names and values of the enum.
		/// </summary>
		/// <returns>A read-only collection of enum names and values.</returns>
		[Information(nameof(GetItems), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
		public ReadOnlyCollection<(string Description, int Value)> GetItems()
		{
			var enumValues = Enum.GetValues<TEnum>();
			var enumNames = Enum.GetNames<TEnum>();

			var items = new List<(string Description, int Value)>(enumValues.Length);

			for (var index = 0; index < enumValues.Length; index++)
			{
				items.Add((
					Description: enumNames[index],
					Value: Convert.ToInt32(enumValues[index], CultureInfo.InvariantCulture)));
			}

			return items.ToReadOnlyCollection();
		}
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
		[RequiresUnreferencedCode("Uses runtime enum metadata. Use a generic enum overload in trimmed apps.")]
		[Information(nameof(GetDescription), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, Status = Status.Available)]
		public string? GetDescription()
		{
			return EnumHelper.GetDescription(input);
		}

		/// <summary>
		/// Gets the 32-bit integer value of the enum.
		/// </summary>
		/// <value>The integer representation of the enum value.</value>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToInt32), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int ToInt32()
		{
			return Convert.ToInt32(input, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Gets the 64-bit integer value of the enum.
		/// </summary>
		/// <value>The long integer representation of the enum value.</value>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToInt64), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public long ToInt64()
		{
			return Convert.ToInt64(input, CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Gets the custom attribute of type <typeparamref name="TAttribute"/> applied to the enum value.
		/// </summary>
		/// <typeparam name="TAttribute">The type of attribute to retrieve.</typeparam>
		/// <returns>The custom attribute if found; otherwise, null.</returns>
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(GetAttribute), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public TAttribute? GetAttribute<TAttribute>() where TAttribute : Attribute
		{
#pragma warning disable IL2070 // input.GetType() returns Type without DynamicallyAccessedMembers — method marked RequiresUnreferencedCode
			var memberInfo = input.GetType().GetMember(input.ToString());
#pragma warning restore IL2070

			return memberInfo.Length > 0 ? memberInfo[0].GetCustomAttribute<TAttribute>() : null;
		}

		/// <summary>
		/// Gets the display name from the <see cref="DisplayAttribute"/> if present; otherwise returns the enum's name.
		/// </summary>
		/// <returns>The display name or enum name.</returns>
		[RequiresUnreferencedCode("This method uses reflection to discover types at runtime.")]
		[Information(nameof(GetDisplayName), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		[RequiresUnreferencedCode("Uses runtime enum metadata and attribute discovery. Use a generic enum overload in trimmed apps.")]
		[Information(nameof(GetSetFlags), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		[Information(nameof(get_FlagCount), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
		public int FlagCount
		{
			[RequiresUnreferencedCode("Uses runtime enum metadata and attribute discovery. Use a generic enum overload in trimmed apps.")]
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
		[RequiresUnreferencedCode("Uses runtime enum metadata. Use a generic enum overload in trimmed apps.")]
		[Information(nameof(Next), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		[RequiresUnreferencedCode("Uses runtime enum metadata. Use a generic enum overload in trimmed apps.")]
		[Information(nameof(Previous), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
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
		[RequiresUnreferencedCode("Uses runtime enum metadata. Use a generic enum overload in trimmed apps.")]
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
