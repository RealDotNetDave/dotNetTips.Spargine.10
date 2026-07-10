// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Core
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="Validator.Argument.Extensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Additional argument validation extension helpers for common scenarios
// (strings, enumerables, numeric ranges). Methods return the input value
// to allow fluent chaining and follow the repository validation/exception
// patterns.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core.Properties;

namespace DotNetTips.Spargine.Core;

public static partial class Validator
{

	/// <summary>
	/// Ensures the sequence count is within the inclusive range. Returns the original sequence when valid.
	/// </summary>
	/// <typeparam name="T">Element type.</typeparam>
	/// <param name="source">The sequence to validate.</param>
	/// <param name="minInclusive">Minimum item count.</param>
	/// <param name="maxInclusive">Maximum item count.</param>
	/// <param name="errorMessage">Optional custom error message.</param>
	/// <param name="paramName">The parameter name (auto-filled by compiler).</param>
	/// <returns>The original sequence when valid.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureCountInRange), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static IEnumerable<T> EnsureCountInRange<T>([DisallowNull] this IEnumerable<T>? source, int minInclusive, int maxInclusive, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(source))] string paramName = ControlChars.EmptyString)
	{
		source = source.ArgumentNotNull();

		return source.ArgumentCountInRange(minInclusive, maxInclusive, errorMessage, paramName);
	}

	/// <summary>
	/// Ensures the integer value is within the inclusive range. Returns the original value when valid.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureInRange), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static int EnsureInRange(this int value, int minInclusive, int maxInclusive, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(value))] string paramName = ControlChars.EmptyString)
	{
		if (!value.CheckIsInRange(minInclusive, maxInclusive, true, errorMessage))
		{
			// CheckIsInRange throws when invalid; flow should never reach here.
		}

		_ = paramName;

		return value;
	}

	/// <summary>
	/// Ensures the long value is within the inclusive range. Returns the original value when valid.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureInRange), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static long EnsureInRange(this long value, long minInclusive, long maxInclusive, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(value))] string paramName = ControlChars.EmptyString)
	{
		if (!value.CheckIsInRange(minInclusive, maxInclusive, true, errorMessage))
		{
			// CheckIsInRange throws when invalid; flow should never reach here.
		}

		_ = paramName;

		return value;
	}

	/// <summary>
	/// Ensures the double value is within the inclusive range. Returns the original value when valid.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureInRange), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static double EnsureInRange(this double value, double minInclusive, double maxInclusive, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(value))] string paramName = ControlChars.EmptyString)
	{
		if (!value.CheckIsInRange(minInclusive, maxInclusive, true, errorMessage))
		{
			// CheckIsInRange throws when invalid; flow should never reach here.
		}

		_ = paramName;

		return value;
	}

	/// <summary>
	/// Ensures the sequence is not null and contains at least one element. Returns the original sequence when valid.
	/// </summary>
	/// <typeparam name="T">Element type.</typeparam>
	/// <param name="source">The sequence to validate.</param>
	/// <param name="errorMessage">Optional custom error message.</param>
	/// <param name="paramName">The parameter name (auto-filled by compiler).</param>
	/// <returns>The original sequence when valid.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureNotEmpty), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static IEnumerable<T> EnsureNotEmpty<T>([DisallowNull] this IEnumerable<T>? source, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(source))] string paramName = ControlChars.EmptyString)
	{
		source = source.ArgumentNotNull();

		// Fast-paths: TryGetNonEnumeratedCount, ICollection<T>, IReadOnlyCollection<T>
		if (source.TryGetNonEnumeratedCount(out var tmpCount))
		{
			if (tmpCount == 0)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), source);
			}
			_ = paramName;

			return source;
		}

		if (source is ICollection<T> coll)
		{
			if (coll.Count == 0)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), source);
			}

			_ = paramName;

			return source;
		}

		if (source is IReadOnlyCollection<T> roColl)
		{
			if (roColl.Count == 0)
			{
				ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), source);
			}

			_ = paramName;

			return source;
		}

		using var e = source.GetEnumerator();
		if (!e.MoveNext())
		{
			ExceptionThrower.ThrowInvalidValueException(CreateExceptionMessage(errorMessage, Resources.ErrorCollectionIsNullOrHasNoItems), source);
		}

		_ = paramName;

		return source;
	}
	/// <summary>
	/// Ensures the input string is not null or empty. Returns the original string when valid.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <param name="errorMessage">Optional custom error message.</param>
	/// <param name="paramName">The parameter name (auto-filled by compiler).</param>
	/// <returns>The original string when valid.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureNotNullOrEmpty), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static string EnsureNotNullOrEmpty([DisallowNull] this string? input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		if (input.Length == 0)
		{
			ExceptionThrower.ThrowArgumentException(CreateExceptionMessage(errorMessage, Resources.StringIsNullOrEmpty), paramName);
		}

		_ = paramName;

		return input;
	}

	/// <summary>
	/// Ensures the input string is not null or whitespace. Returns the original string when valid.
	/// </summary>
	/// <param name="input">The string to validate.</param>
	/// <param name="errorMessage">Optional custom error message.</param>
	/// <param name="paramName">The parameter name (auto-filled by compiler).</param>
	/// <returns>The original string when valid.</returns>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureNotNullOrWhiteSpace), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public static string EnsureNotNullOrWhiteSpace([DisallowNull] this string? input, string errorMessage = ControlChars.EmptyString, [CallerArgumentExpression(nameof(input))] string paramName = ControlChars.EmptyString)
	{
		input = input.ArgumentNotNull();

		if (string.IsNullOrWhiteSpace(input))
		{
			ExceptionThrower.ThrowArgumentInvalidException(CreateExceptionMessage(errorMessage, Resources.ErrorStringIsNotValid), paramName);
		}

		return input;
	}
}
