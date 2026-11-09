// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-09-2026
// ***********************************************************************
// <copyright file="MathExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>
// Extension methods for numeric types providing mathematical utilities. Includes <c>Add</c>,
// <c>Subtract</c>, <c>Average</c>, <c>FindMax</c>, <c>FindMin</c>, <c>MinMax</c>, <c>Sum</c>, <c>CalculatePercent</c>
// <c>TimeSpan</c>), <c>IsPrime</c>, and multiple <c>Round</c> overloads for <c>double</c> and
// <c>decimal</c> with optional digit count and <c>MidpointRounding</c> mode.
// </summary>
// ***********************************************************************
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for numeric types that supplement the built-in <see cref="Math"/> class.
/// </summary>
/// <remarks>
/// Covers arithmetic helpers (<c>Add</c>, <c>Subtract</c>), percentage difference calculations
/// across <c>int</c>, <c>long</c>, <c>double</c>, and <c>TimeSpan</c>, primality testing
/// (<c>IsPrime</c>), and a family of <c>Round</c> overloads for <c>double</c> and <c>decimal</c>
/// that accept an optional digit count and/or a <c>MidpointRounding</c> mode.
/// </remarks>
[Information(Status = Status.Available, Documentation = "ADD URL")]
public static class MathExtensions
{

	/// <summary>
	/// Adds the specified number to the input value.
	/// </summary>
	/// <param name="input">The base value.</param>
	/// <param name="add">The number to add.</param>
	/// <returns>The sum of the input value and the specified number.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Add), author: "David McCarter", createdOn: "7/19/2022", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static double Add(this int input, int add) => input + add;

	/// <summary>
	/// Calculates the average of the values. Integer types use integer division.
	/// </summary>
	/// <typeparam name="T">The numeric type.</typeparam>
	/// <param name="values">The values.</param>
	/// <returns>The average of the values.</returns>
	/// <remarks>The sum is computed in <typeparamref name="T"/>, so narrow integer types can overflow.</remarks>
	/// <exception cref="ArgumentNullException">values is empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "11/09/2026", "11/09/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, Status = Status.New)]
	public static T Average<T>(this ReadOnlySpan<T> values) where T : INumber<T>
	{
		values = values.ArgumentNotEmpty();

		return values.Sum() / T.CreateChecked(values.Length);
	}

	/// <summary>
	/// Calculates the percentage difference between two <see cref="TimeSpan" /> values.
	/// </summary>
	/// <param name="first">The first <see cref="TimeSpan" /> value.</param>
	/// <param name="second">The second <see cref="TimeSpan" /> value, to compare with the first.</param>
	/// <returns>The percentage difference between the first and second <see cref="TimeSpan" /> values.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculatePercent), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static double CalculatePercent(this in TimeSpan first, in TimeSpan second)
	{
		return (second.TotalMilliseconds - first.TotalMilliseconds) / Math.Abs(first.TotalMilliseconds) * 100;
	}

	/// <summary>
	/// Calculates the percentage difference between two integers.
	/// </summary>
	/// <param name="first">The first integer value.</param>
	/// <param name="second">The second integer value, to compare with the first.</param>
	/// <returns>The percentage difference between the first and second integer values.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculatePercent), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static double CalculatePercent(this int first, int second)
	{
		return (second - first) / Math.Abs(first) * 100;
	}

	/// <summary>
	/// Calculates the percentage difference between two double values.
	/// </summary>
	/// <param name="first">The first double value.</param>
	/// <param name="second">The second double value, to compare with the first.</param>
	/// <returns>The percentage difference between the first and second double values.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculatePercent), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static double CalculatePercent(this in double first, in double second)
	{
		return (second - first) / Math.Abs(first) * 100;
	}

	/// <summary>
	/// Calculates the percentage difference between two long integer values.
	/// </summary>
	/// <param name="first">The first long integer value.</param>
	/// <param name="second">The second long integer value, to compare with the first.</param>
	/// <returns>The percentage difference between the first and second long integer values.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CalculatePercent), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static double CalculatePercent(this in long first, in long second)
	{
		return (second - first) / Math.Abs(first) * 100;
	}

	/// <summary>
	/// Finds the largest value.
	/// </summary>
	/// <typeparam name="T">The numeric type.</typeparam>
	/// <param name="values">The values.</param>
	/// <returns>The largest value.</returns>
	/// <remarks>For floating-point types, a NaN element yields NaN.</remarks>
	/// <exception cref="ArgumentNullException">values is empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FindMax), "David McCarter", "11/09/2026", "11/09/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, Status = Status.New)]
	public static T FindMax<T>(this ReadOnlySpan<T> values) where T : INumber<T>
	{
		values = values.ArgumentNotEmpty();

		var max = values[0];

		for (var index = 1; index < values.Length; index++)
		{
			max = T.Max(max, values[index]);
		}

		return max;
	}

	/// <summary>
	/// Finds the smallest value.
	/// </summary>
	/// <typeparam name="T">The numeric type.</typeparam>
	/// <param name="values">The values.</param>
	/// <returns>The smallest value.</returns>
	/// <remarks>For floating-point types, a NaN element yields NaN.</remarks>
	/// <exception cref="ArgumentNullException">values is empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(FindMin), "David McCarter", "11/09/2026", "11/09/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, Status = Status.New)]
	public static T FindMin<T>(this ReadOnlySpan<T> values) where T : INumber<T>
	{
		values = values.ArgumentNotEmpty();

		var min = values[0];

		for (var index = 1; index < values.Length; index++)
		{
			min = T.Min(min, values[index]);
		}

		return min;
	}

	/// <summary>
	/// Determines whether the specified number is prime.
	/// </summary>
	/// <param name="number">The number to check for primality.</param>
	/// <returns><c>true</c> if the specified number is prime; otherwise, <c>false</c>.</returns>
	/// <remarks>A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.
	/// This method efficiently checks for primality by eliminating divisible numbers early.</remarks>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsPrime), author: "David McCarter", createdOn: "7/15/2022", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool IsPrime(this int number)
	{
		if (number < 2)
		{
			return false;
		}

		if (number is 2 or 3)
		{
			return true;
		}

		if (number % 2 == 0 || number % 3 == 0)
		{
			return false;
		}

		var sqrtN = (int)Math.Sqrt(number);

		for (var count = 5; count <= sqrtN; count += 6)
		{
			if (number % count == 0 || number % (count + 2) == 0)
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Finds the smallest and largest values in a single pass.
	/// </summary>
	/// <typeparam name="T">The numeric type.</typeparam>
	/// <param name="values">The values.</param>
	/// <returns>A tuple containing the minimum and maximum values.</returns>
	/// <remarks>For floating-point types, a NaN element yields NaN.</remarks>
	/// <exception cref="ArgumentNullException">values is empty.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MinMax), "David McCarter", "11/09/2026", "11/09/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, Status = Status.New)]
	public static (T Min, T Max) MinMax<T>(this ReadOnlySpan<T> values) where T : INumber<T>
	{
		values = values.ArgumentNotEmpty();

		var min = values[0];
		var max = values[0];

		for (var index = 1; index < values.Length; index++)
		{
			var value = values[index];
			min = T.Min(min, value);
			max = T.Max(max, value);
		}

		return (min, max);
	}

	/// <summary>
	/// Rounds the specified double value to the nearest integer.
	/// </summary>
	/// <param name="value">The double value to round.</param>
	/// <returns>The integer value that is closest to the specified double value.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Round(this in double value)
	{
		return Convert.ToInt32(Math.Round(value, MidpointRounding.ToPositiveInfinity));
	}

	/// <summary>
	/// Rounds the specified decimal value to the nearest integer.
	/// </summary>
	/// <param name="value">The decimal value to round.</param>
	/// <returns>The integer value that is closest to the specified decimal value.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Round(this in decimal value)
	{
		return Convert.ToInt32(Math.Round(value));
	}

	/// <summary>
	/// Rounds the specified double value to a specified number of fractional digits.
	/// </summary>
	/// <param name="value">The double value to round.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <returns>The integer value that is closest to the specified double value, rounded to the specified number of fractional digits.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Round(this in double value, int digits) => Convert.ToInt32(Math.Round(value, digits));

	/// <summary>
	/// Rounds the specified double value using the specified rounding convention.
	/// </summary>
	/// <param name="value">The double value to round.</param>
	/// <param name="mode">The rounding convention to use.</param>
	/// <returns>The integer value that is closest to the specified double value, rounded according to the specified rounding convention.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="mode" /> is not a valid <see cref="MidpointRounding" /> value.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Round(this in double value, MidpointRounding mode)
	{
		mode = mode.ArgumentDefined();

		return Convert.ToInt32(Math.Round(value, mode));
	}

	/// <summary>
	/// Rounds the specified decimal value to a specified number of fractional digits.
	/// </summary>
	/// <param name="value">The decimal value to round.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <returns>The integer value that is closest to the specified decimal value, rounded to the specified number of fractional digits.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Round(this in decimal value, int digits) => Convert.ToInt32(Math.Round(value, digits));

	/// <summary>
	/// Rounds the specified decimal value using the specified rounding convention.
	/// </summary>
	/// <param name="value">The decimal value to round.</param>
	/// <param name="mode">The rounding convention to use.</param>
	/// <returns>The integer value that is closest to the specified decimal value, rounded according to the specified rounding convention.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="mode" /> is not a valid <see cref="MidpointRounding" /> value.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Round(this in decimal value, MidpointRounding mode)
	{
		mode = mode.ArgumentDefined();

		return Convert.ToInt32(Math.Round(value, mode));
	}

	/// <summary>
	/// Rounds the specified double value to a specified number of fractional digits using the specified rounding convention.
	/// </summary>
	/// <param name="value">The double value to round.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <param name="mode">The rounding convention to use.</param>
	/// <returns>The integer value that is closest to the specified double value, rounded to the specified number of fractional digits and according to the specified rounding convention.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="mode" /> is not a valid <see cref="MidpointRounding" /> value.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Round(this in double value, int digits, MidpointRounding mode)
	{
		mode = mode.ArgumentDefined();

		return Convert.ToInt32(Math.Round(value, digits, mode));
	}

	/// <summary>
	/// Rounds the specified decimal value to a specified number of fractional digits using the specified rounding convention.
	/// </summary>
	/// <param name="value">The decimal value to round.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <param name="mode">The rounding convention to use.</param>
	/// <returns>The integer value that is closest to the specified decimal value, rounded to the specified number of fractional digits and according to the specified rounding convention.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="mode" /> is not a valid <see cref="MidpointRounding" /> value.</exception>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Round), UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static int Round(this in decimal value, int digits, MidpointRounding mode)
	{
		mode = mode.ArgumentDefined();

		return Convert.ToInt32(Math.Round(value, digits, mode));
	}

	/// <summary>
	/// Subtracts the specified number from the input value.
	/// </summary>
	/// <param name="input">The base value.</param>
	/// <param name="subtract">The number to subtract.</param>
	/// <returns>The difference between the input value and the specified number.</returns>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Subtract), author: "David McCarter", createdOn: "7/19/2022", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static double Subtract(this int input, int subtract) => input - subtract;

	/// <summary>
	/// Calculates the sum of the values.
	/// </summary>
	/// <typeparam name="T">The numeric type.</typeparam>
	/// <param name="values">The values.</param>
	/// <returns>The sum of the values, or the additive identity if empty.</returns>
	/// <remarks>The sum is computed in <typeparamref name="T"/>, so narrow integer types can overflow.</remarks>
	[Pure]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Sum), "David McCarter", "11/09/2026", "11/09/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, Status = Status.New)]
	public static T Sum<T>(this ReadOnlySpan<T> values) where T : IAdditionOperators<T, T, T>, IAdditiveIdentity<T, T>
	{
		var sum = T.AdditiveIdentity;

		for (var index = 0; index < values.Length; index++)
		{
			sum += values[index];
		}

		return sum;
	}

}
