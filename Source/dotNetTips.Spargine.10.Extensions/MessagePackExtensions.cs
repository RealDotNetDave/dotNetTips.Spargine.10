// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="MessagePackExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for MessagePack serialization and deserialization wrappers.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using MessagePack;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides thin wrapper extension methods for MessagePack serialization and deserialization.
/// </summary>
[Information(Status = Status.New)]
public static class MessagePackExtensions
{
	/// <summary>
	/// Deserializes the specified MessagePack <paramref name="bytes"/> into an instance of <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The destination type to deserialize.</typeparam>
	/// <param name="bytes">The MessagePack payload bytes.</param>
	/// <returns>An instance of <typeparamref name="T"/> created from the MessagePack payload.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="bytes"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="bytes"/> is empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FromMessagePack), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static T FromMessagePack<T>([DisallowNull] this byte[] bytes)
	{
		bytes = bytes.ArgumentNotNull();

		if (bytes.Length == 0)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(bytes));
		}

		return MessagePackSerializer.Deserialize<T>(bytes);
	}

	/// <summary>
	/// Serializes the specified <paramref name="value"/> to MessagePack bytes.
	/// </summary>
	/// <typeparam name="T">The type of value to serialize.</typeparam>
	/// <param name="value">The source value to serialize.</param>
	/// <returns>A byte array containing the MessagePack payload for <paramref name="value"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToMessagePackBytes), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static byte[] ToMessagePackBytes<T>([DisallowNull] this T value)
	{
		value = value.ArgumentNotNull();

		return MessagePackSerializer.Serialize(value);
	}
}
