// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 02-10-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-21-2025
// ***********************************************************************
// <copyright file="InternalMethods.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Internal;

/// <summary>
/// Class InternalMethods.
/// </summary>
internal static class InternalMethods
{

	/// <summary>
	/// The null string
	/// </summary>
	private const string NullString = "[null]";


	// OPTIMIZATION: Cache the built-in types dictionary to avoid repeated allocations
	// This prevents creating a new dictionary on every call to PropertiesToDictionary
	private static readonly IReadOnlyDictionary<Type, string> _builtInTypeNames = TypeHelper.BuiltInTypeNames();


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
	[Information(nameof(IsEnumerable), UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	internal static bool IsEnumerable([DisallowNull] Type type)
	{
		type = type.ArgumentNotNull();

		return type.GetInterfaces().Any(t => t == typeof(IEnumerable));
	}

	/// <summary>
	/// Converts object properties to a <see cref="IDictionary" />.
	/// </summary>
	/// <param name="obj">The object.</param>
	/// <param name="memberName">Name of the member.</param>
	/// <param name="ignoreNulls">if set to <c>true</c> [ignore nulls].</param>
	/// <returns>IDictionary&lt;System.String, System.String&gt;.</returns>
	internal static IDictionary<string, string> PropertiesToDictionary(object obj, string memberName = ControlChars.EmptyString, bool ignoreNulls = true)
	{
		var result = new Dictionary<string, string>();

		if (obj is null)
		{
			result.Add(memberName, NullString);
			return result;
		}

		var objectType = obj.GetType();

		//TODO: Review performance impact of this change

		// OPTIMIZATION: Use cached dictionary instead of calling TypeHelper.BuiltInTypeNames() repeatedly
		// This eliminates dictionary allocation on every check
		if (_builtInTypeNames.ContainsKey(objectType))
		{
			result.Add(memberName, obj.ToString()!);
			return result;
		}

		// Rest of the method remains the same...
		if (IsEnumerable(objectType))
		{
			var itemCount = 0;

			foreach (var item in (IEnumerable)obj)
			{
				var itemId = itemCount++;
				var itemInnerMember = string.Format(CultureInfo.CurrentCulture, "{0}[{1}]", memberName, itemId);
				result = result.Concat(PropertiesToDictionary(item, itemInnerMember)).ToDictionary(e => e.Key, e => e.Value);
			}
			return result;
		}

		var propertyCollection = objectType.GetProperties();
		var newMemberName = string.Empty;

		if (memberName.Length > 0)
		{
			newMemberName = $"{memberName}{ControlChars.Dot}";
		}

		var propertyCount = propertyCollection.LongLength;

		for (var index = 0; index < propertyCount; index++)
		{
			var property = propertyCollection[index];
			var innerObject = property.GetValue(obj, null);

			if (ignoreNulls && innerObject is null)
			{
				continue;
			}

			var innerMember = string.Format(CultureInfo.CurrentCulture, "{0}{1}", newMemberName, property.Name);
			result = result.Concat(PropertiesToDictionary(innerObject!, innerMember)).ToDictionary(e => e.Key, e => e.Value);
		}

		return result;
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

		var result = properties.Aggregate(header, (acc, pair) => string.Format(CultureInfo.CurrentCulture, "{0}{1}{2}{3}{4}", acc, sequenceSeparator, pair.Key, keyValueSeparator, pair.Value));

		return result.StartsWith(sequenceSeparator, StringComparison.CurrentCulture) ? result[sequenceSeparator.Length..] : result;
	}

}
