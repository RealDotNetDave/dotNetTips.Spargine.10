// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-10-2025
// ***********************************************************************
// <copyright file="EnumHelper.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Facilitates the usage of Enums by providing convenient methods such as
// AdjustCamelCase(), AdjustName(), GetNames(), and more.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides utility methods for working with enumerations, such as converting between names and values,
/// adjusting naming conventions, and extracting metadata. This class cannot be inherited.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class EnumHelper
{

	/// <summary>
	/// The description cache
	/// </summary>
	private static readonly ConcurrentDictionary<Enum, string> _descriptionCache = new();

	/// <summary>
	/// Regular expression used to identify camel case words within a string.
	/// This is used to adjust enum names to a more readable format by inserting spaces between camel case words.
	/// </summary>
	private static readonly Regex _titleCaseRegex = new(@"(\B[A-Z])", RegexOptions.Multiline | RegexOptions.Compiled);

	/// <summary>
	/// Adjusts camel case naming in the provided string by inserting a space before each capital letter that is not at the beginning.
	/// </summary>
	/// <param name="name">The string to adjust.</param>
	/// <returns>A string with spaces inserted before capital letters that are not at the beginning.</returns>
	private static string AdjustCamelCase(string name) => _titleCaseRegex.Replace(name, replacement: " $1");

	/// <summary>
	/// Adjusts the name of the enumeration value by replacing underscores with spaces and applying camel case adjustment.
	/// </summary>
	/// <param name="name">The original name of the enumeration value.</param>
	/// <returns>The adjusted name with underscores replaced by spaces and camel case naming applied.</returns>
	private static string AdjustName(string name)
	{
		return AdjustCamelCase(name.Replace(ControlChars.Underscore, ControlChars.Space))
					.Replace(ControlChars.Space, ControlChars.Space);
	}

	/// <summary>
	/// Retrieves a list of names for an enumeration type, with options to adjust for readability and to use XML attributes.
	/// </summary>
	/// <param name="type">The enumeration type.</param>
	/// <param name="fixNames">If set to <c>true</c>, adjusts the names for readability by adding spaces in camel case names and replacing underscores with spaces.</param>
	/// <returns>A list of enumeration names as strings.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="type"/> is null.</exception>
	private static List<string> GetNames([DisallowNull] Type type, bool fixNames = true)
	{
		// Set up result
		var result = new List<string>();

		// Load fields
		var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

		// Enum names (text) are defined as fields for the type
		foreach (var enumValue in fields.AsSpan())
		{
			// If XML is specified and found, use this name
			var attribute = Attribute.GetCustomAttribute(enumValue, typeof(XmlEnumAttribute)) as XmlEnumAttribute;

			if (attribute?.Name is not null)
			{
				result.Add(attribute.Name);
				continue;
			}

			// Attempt to use the Description attribute (if present)
			var description = Attribute.GetCustomAttribute(enumValue, typeof(DescriptionAttribute)) as DescriptionAttribute;

			if (description?.Description is not null)
			{
				// Use this value
				result.Add(description.Description);
			}
			else
			{
				// If not found, use the Enum name, with adjustment if requested
				result.Add(fixNames ? AdjustName(enumValue.Name) : enumValue.Name);
			}
		}

		return result;
	}

	/// <summary>
	/// Gets the description of the enum value by checking multiple attributes in this order:
	/// 1. <see cref="DescriptionAttribute"/>
	/// 2. <see cref="EnumMemberAttribute"/>
	/// 3. The enum's name as a fallback
	/// </summary>
	/// <param name="input">The enum value to get the description for.</param>
	/// <returns>The description of the enum value.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown if the provided input is not a valid enum value.</exception>
	[Information(nameof(GetDescription), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static string GetDescription(this Enum input)
	{
		input = input.ArgumentNotNull();

		return _descriptionCache.GetOrAdd(input, key =>
		{
			var type = key.GetType();

			// Verify this is actually an enum type
			if (!type.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", nameof(input));
			}

			var name = Enum.GetName(type, key);

			if (name == null)
			{
				return key.ToString();
			}

			// Get field and look for Description attribute first
			var field = type.GetField(name);

			if (field == null)
			{
				return name;
			}

			// First try DescriptionAttribute
			var descriptionAttr = field.GetCustomAttribute<DescriptionAttribute>(false);
			if (descriptionAttr != null && !string.IsNullOrEmpty(descriptionAttr.Description))
			{
				return descriptionAttr.Description;
			}

			// Then try EnumMemberAttribute
			var enumMemberAttr = field.GetCustomAttribute<EnumMemberAttribute>(false);
			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
			{
				return enumMemberAttr.Value;
			}

			// Fall back to the enum name
			return name;
		});
	}

	/// <summary>
	/// Gets the enumeration names and values for a specified enumeration type.
	/// </summary>
	/// <typeparam name="T">The type of the enumeration.</typeparam>
	/// <param name="fixNames">If set to <c>true</c>, adjusts the names for readability by adding spaces in camel case names and replacing underscores with spaces.</param>
	/// <returns>A read-only collection of <see cref="EnumValue"/>, each representing an enumeration name and its corresponding value.</returns>
	/// <example>
	/// Using this method with an enumeration type <c>RequestCacheLevel</c> will return a collection containing:
	/// <code>
	/// new EnumValue { Name = "Default", Value = 0 },
	/// new EnumValue { Name = "BypassCache", Value = 1 },
	/// and so on for each enumeration value.
	/// </code>
	/// </example>
	[return: NotNull]
	[Information(nameof(GetItems), author: "David McCarter", createdOn: "1/1/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Documentation = "https://bit.ly/SpargineEnumerationHandling", Status = Status.Available)]
	public static ReadOnlyCollection<EnumValue> GetItems<T>(bool fixNames = true)
		where T : Enum
	{
		var enumType = typeof(T);

		// SUGGESTION FROM COPILOT SLIGHTLY SLOWER.
		var allValues = ((int[])Enum.GetValues(enumType)).AsSpan();

		// Retrieves a list of names for an enumeration type, converts it to an immutable array, and returns it as a span.
		var enumNames = GetNames(enumType, fixNames).ToImmutableArray().AsSpan();

		// Get list of names
		// Add values to result
		var result = new List<EnumValue>(allValues.Length);
		var itemCount = allValues.Length;

		for (var valueCount = 0; valueCount < itemCount; valueCount++)
		{
			result.Add(new EnumValue(allValues[valueCount], enumNames[valueCount]));
		}

		return result.AsReadOnly();
	}

	/// <summary>
	/// Parses the specified string to an enum of type <typeparamref name="T" />.
	/// </summary>
	/// <typeparam name="T">The enum type to which the string will be parsed.</typeparam>
	/// <param name="name">The string representation of the enum value to parse.</param>
	/// <returns>An enum of type <typeparamref name="T" /> corresponding to the parsed string.</returns>
	/// <exception cref="ArgumentException">Thrown if <paramref name="name" /> is null or an empty string, or if it does not correspond to any value of <typeparamref name="T" />.</exception>
	[Information(nameof(Parse), UnitTestStatus = UnitTestStatus.Completed, Status = Status.New)]
	public static T Parse<T>([DisallowNull] string name)
		where T : Enum
	{
		name = name.ArgumentNotNullOrEmpty();

		return (T)Enum.Parse(typeof(T), name);
	}

}
