// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-10-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-28-2026
// ***********************************************************************
// <copyright file="InternalMethods.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Internal;

/// <summary>
/// Class InternalMethods.
/// </summary>
internal static class InternalMethods
{
	[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
	private static readonly IReadOnlyDictionary<Type, string> _builtInTypeNames = TypeHelper.BuiltInTypeNames();
	private static readonly CompositeFormat _propertiesAggregateFormat = CompositeFormat.Parse("{0}{1}{2}{3}{4}");

	[Pure]
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[RequiresUnreferencedCode("Uses reflection to enumerate object properties and read property values. Properties may be removed in trimmed apps.")]
	[Information("Original code by: Diego De Vita", author: "David McCarter", createdOn: "11/19/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, Status = Status.Available)]
	public static ReadOnlyDictionary<string, string> PropertiesToDictionary(this object obj, string memberName = ControlChars.EmptyString,
	bool ignoreNulls = true)
	{
		memberName = memberName.ArgumentNotNull();

		// Return just member name if obj is null and ignoreNulls is false
		if (memberName.HasValue() && obj is null && ignoreNulls is false)
		{
			return new ReadOnlyDictionary<string, string>(new Dictionary<string, string> { { memberName, string.Empty } });
		}

		var objectType = obj.ArgumentNotNull().GetType();

		var result = new Dictionary<string, string>();

		if (_builtInTypeNames.ContainsKey(objectType))
		{
			result.Add(memberName, obj!.ToString()!);
			return result.AsReadOnly();
		}

		// If the type implements the IEnumerable interface.
		if (TypeHelper.IsEnumerable(objectType))
		{
			// Cast obj to IEnumerable before iterating
			if (obj is IEnumerable enumerable)
			{
				var itemCount = 0;

				foreach (var item in enumerable)
				{
					var itemId = itemCount++;

					var itemInnerMember = FastStringBuilder.Format($"{{0}}[{{1}}]", memberName, itemId.ToString(CultureInfo.CurrentCulture));

					result = result.Concat(item.PropertiesToDictionary(itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
				}

				return result.AsReadOnly();
			}
		}

		// Otherwise go deeper in the object tree.
		// And foreach object public property collect each value
		var propertyCollection = objectType.GetProperties();

		var newMemberName = string.Empty;

		if (memberName.Length > 0)
		{
			newMemberName = $"{memberName}{ControlChars.Dot}";
		}

		foreach (var property in propertyCollection)
		{
			var ignoreAttribute = property.GetCustomAttribute<JsonIgnoreAttribute>();

			if (ignoreAttribute == null)
			{
				try
				{
					var innerObject = property.GetValue(obj, null);

					if (ignoreNulls && innerObject is null)
					{
						continue;
					}

					var innerMember = FastStringBuilder.Format("{0}{1}", newMemberName, property.Name);

					result = result.Concat(innerObject!.PropertiesToDictionary(innerMember, ignoreNulls)).ToDictionary(e => e.Key, e => e.Value);
				}
				catch (Exception ex)
				{
					Trace.WriteLine(ex.Message);
				}
			}
		}

		return result.AsReadOnly();
	}

	/// <summary>
	/// Appends a character to the <see cref="StringBuilder"/> the specified number of times.
	/// </summary>
	/// <param name="sb">The <see cref="StringBuilder"/> to append to. Must not be <c>null</c>.</param>
	/// <param name="character">The character to repeat.</param>
	/// <param name="count">The number of times to append the character. Must be non-negative.</param>
	/// <returns>The same <see cref="StringBuilder"/> instance for fluent chaining.</returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="sb"/> is <c>null</c>.
	/// </exception>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown if <paramref name="count"/> is negative.
	/// </exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AppendRepeatedCharsLine), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	internal static void AppendRepeatedCharsLine([DisallowNull] this StringBuilder sb, char character, int count)
	{
		sb = sb.ArgumentNotNull();
		count = count.ArgumentInRange(min: 1);

		for (var charCount = 0; charCount < count; charCount++)
		{
			_ = sb.Append(character);
		}

		_ = sb.AppendLine();
	}

	/// <summary>
	/// Ensures the minimum.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="minValue">The minimum value.</param>
	/// <returns>System.Int32.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureMinimum), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	internal static int EnsureMinimum(this int value, int minValue) => value < minValue ? minValue : value;

	/// <summary>
	/// Determines whether the specified <see cref="Type"/> implements the <see cref="IEnumerable"/> interface.
	/// </summary>
	/// <param name="type">The <see cref="Type"/> to inspect. Must not be <c>null</c>.</param>
	/// <returns>
	/// <c>true</c> if the type implements <see cref="IEnumerable"/>; otherwise, <c>false</c>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown if <paramref name="type"/> is <c>null</c>.
	/// </exception>
	[Information(nameof(IsEnumerable), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	internal static bool IsEnumerable([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		return type != typeof(string) && typeof(IEnumerable).IsAssignableFrom(type);
	}

	/// <summary>
	/// Propertieses to string.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <param name="header">The header.</param>
	/// <param name="keyValueSeparator">The key value separator.</param>
	/// <param name="sequenceSeparator">The sequence separator.</param>
	/// <param name="ignoreNulls">if set to <c>true</c> [ignore nulls].</param>
	/// <param name="includeMemberName">if set to <c>true</c> [include member name].</param>
	/// <returns>System.String.</returns>
	[RequiresUnreferencedCode("Uses reflection to enumerate object properties. Properties may be removed in trimmed apps.")]
	internal static string PropertiesToString(this object obj, string header = ControlChars.EmptyString, char keyValueSeparator = ControlChars.Colon, string sequenceSeparator = ControlChars.DefaultSeparator, bool ignoreNulls = true, bool includeMemberName = true)
	{
		var typeName = obj.GetType().Name;

		if (string.Equals(typeName, typeof(List<>).Name, StringComparison.Ordinal))
		{
			typeName = "Item";
		}
		else if (includeMemberName is false)
		{
			typeName = string.Empty;
		}

		var properties = PropertiesToDictionary(obj, memberName: typeName, ignoreNulls: ignoreNulls);

		var result = properties.Aggregate(header, (acc, pair) => string.Format(CultureInfo.CurrentCulture, _propertiesAggregateFormat, acc, sequenceSeparator, pair.Key, keyValueSeparator, pair.Value));

		return result.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result[sequenceSeparator.Length..] : result;
	}

}
