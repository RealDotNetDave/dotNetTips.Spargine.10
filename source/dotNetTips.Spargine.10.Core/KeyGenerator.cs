// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : David McCarter
// Created          : 05-30-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2025
// ***********************************************************************
// <copyright file="KeyGenerator.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Generates unique keys using a GUID without dashes.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Provides functionality to generate unique keys.
/// </summary>
[Information(Status = Status.UpdateDocumentation, Documentation = "ADD URL")]
public static class KeyGenerator
{

	/// <summary>
	/// Generates a timestamp representing the current UTC time in milliseconds since the Unix epoch.
	/// </summary>
	/// <returns>
	/// A byte array containing the timestamp as a 64-bit integer (milliseconds since Unix epoch).
	/// </returns>
	/// <remarks>
	/// Useful for generating time-based values for keys or tokens.
	/// </remarks>
	[Information(nameof(GenerateTimeStamp), Status = Status.Available)]
	private static byte[] GenerateTimeStamp()
	{
		return BitConverter.GetBytes(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
	}

	/// <summary>
	/// Generates a custom key by joining the provided items with a separator and optionally appending a unique key.
	/// </summary>
	/// <param name="separator">The character used to separate items in the key. Defaults to <see cref="ControlChars.Dash"/>.</param>
	/// <param name="addTimeStamp">If <c>true</c>, appends a unique key to the end of the items.</param>
	/// <param name="items">The string items to include in the key. Must not be null or empty.</param>
	/// <returns>
	/// A custom key string composed of the provided items, separated by <paramref name="separator"/>,
	/// and optionally suffixed with a unique key.
	/// </returns>
	/// <exception cref="ArgumentException">
	/// Thrown if <paramref name="items"/> is null or empty.
	/// </exception>
	/// <example>
	/// <code>
	/// var key = KeyGenerator.GenerateCustomKey('_', true, "User", "Admin");
	/// // Example output: "User_Admin_f7f0af78003d4ab194b5a4024d02112a"
	/// </code>
	/// </example>
	[return: NotNull]
	[Information(nameof(GenerateCustomKey), "David McCarter", "8/18/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static string GenerateCustomKey([ConstantExpected] char separator = ControlChars.Dash, bool addTimeStamp = true, params string[] items)
	{
		items = items.ArgumentItemsExists();

		var keyItems = items.ToList();

		if (addTimeStamp)
		{
			keyItems.Add(GenerateKey());
		}

		return FastStringBuilder.Join(keyItems, separator);
	}

	/// <summary>
	/// Creates a random key from a GUID without dashes.
	/// </summary>
	/// <returns>A unique key as a string.</returns>
	/// <example>Example: f7f0af78003d4ab194b5a4024d02112a</example>
	[return: NotNull]
	[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static string GenerateKey() => Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);

	/// <summary>
	/// Creates a random key from a GUID with a specified prefix.
	/// </summary>
	/// <param name="prefix">The prefix to prepend to the generated key.</param>
	/// <returns>A unique key as a string with the specified prefix.</returns>
	/// <example>Example: DataRecordf7f0af78003d4ab194b5a4024d02112a</example>
	[return: NotNull]
	[Information(nameof(GenerateKey), "David McCarter", "5/30/2021", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Documentation = "https://bit.ly/SpargineJun2021", Status = Status.Available)]
	public static string GenerateKey([DisallowNull] string prefix)
	{
		return $"{prefix.ArgumentNotNull()}{Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture)}";
	}

	/// <summary>
	/// Creates a sortable random key from a GUID using version 7 GUIDs.
	/// </summary>
	/// <returns>A sortable unique key as a string.</returns>
	/// <example>Example: 017f0af78003d4ab194b5a4024d02112a</example>
	[return: NotNull]
	[Information(nameof(GenerateSortableKey), "David McCarter", "5/7/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static string GenerateSortableKey()
	{
		return Guid.CreateVersion7().ToString("N", CultureInfo.InvariantCulture);
	}

	/// <summary>
	/// Creates a sortable random key from a GUID with a specified prefix using version 7 GUIDs.
	/// </summary>
	/// <param name="prefix">The prefix to prepend to the generated key.</param>
	/// <returns>A sortable unique key as a string with the specified prefix.</returns>
	/// <example>Example: DataRecord017f0af78003d4ab194b5a4024d02112a</example>
	[return: NotNull]
	[Information(nameof(GenerateSortableKey), "David McCarter", "5/7/2025", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.New)]
	public static string GenerateSortableKey([DisallowNull] string prefix)
	{
		return $"{prefix.ArgumentNotNull()}{Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture)}";
	}

}
