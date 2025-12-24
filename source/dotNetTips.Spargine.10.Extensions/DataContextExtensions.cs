// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2025
// ***********************************************************************
// <copyright file="DataContextExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the DataContext type.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Reflection;
using DotNetTips.Spargine.Core;
using LinqToDB;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extension methods for the <see cref="DataContext"/> type, enhancing its functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class provides methods to interact with a <see cref="DataContext"/> in ways that are not supported by default.
/// For example, it allows retrieving tracked objects within a DataContext, which can be useful for debugging or auditing changes.
/// Note: The use of reflection to access internal properties of DataContext may be subject to change in future versions of the framework.
/// </remarks>
[Information(Status = Status.Available)]
public static class DataContextExtensions
{
	/// <summary>
	/// Gets the tracked objects from a <see cref="DataContext" />.
	/// Validates that <paramref name="context" /> is not null
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="context">The context.</param>
	/// <returns>ReadOnlyCollection&lt;Tuple&lt;T, T&gt;&gt;.</returns>
	/// <exception cref="ArgumentNullException">context</exception>
	[Pure]
	[return: NotNull]
	[Information(nameof(GetTrackedObjects), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static ReadOnlyCollection<Tuple<T, T>> GetTrackedObjects<T>([DisallowNull] this DataContext context)
	{
		context = context.ArgumentNotNull();

		var result = new List<Tuple<T, T>>();
		var dcType = typeof(DataContext);

		// Use reflection to get to the underlying items being tracked in the DataContext
		const BindingFlags Bindings = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField;

		var services = dcType.GetField("services", Bindings)?.GetValue(context);
		var tracker = services!.GetType().GetField("tracker", Bindings)?.GetValue(services);
		var trackerItems = (IDictionary)tracker?.GetType().GetField("items", Bindings)?.GetValue(tracker)!;

		// iterate through each update in context, adding only those that are of type T to the method's result variable
		foreach (DictionaryEntry entry in trackerItems)
		{
			var originalField = entry.Value?.GetType().GetField("original", Bindings);

			if (originalField is null)
			{
				continue;
			}
			dynamic original = originalField.GetValue(entry.Value)!;

			if (entry.Key is T t && original is T)
			{
				result.Add(new Tuple<T, T>(original, t));
			}
		}

		return result.AsReadOnly();
	}

}
