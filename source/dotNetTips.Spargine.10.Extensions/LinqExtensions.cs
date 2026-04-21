// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 08-18-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-10-2026
// ***********************************************************************
// <copyright file="LinqExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for LINQ.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for LINQ to enhance its functionality and usability.
/// These methods include conditional transformations on <see cref="IQueryable{T}"/> and <see cref="IEnumerable{T}"/>,
/// allowing for more expressive and dynamic query composition.
/// </summary>
[Information(nameof(LinqExtensions), "David McCarter", "8/18/20", Status = Status.NeedsDocumentation)]
public static class LinqExtensions
{

	/// <summary>
	/// Conditionally applies a series of transformations to the input <see cref="IQueryable{T}"/> based on a boolean condition.
	/// This allows for dynamic query composition by including or excluding parts of the query based on the specified condition.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <see cref="IQueryable{T}"/>.</typeparam>
	/// <param name="input">The input query to transform.</param>
	/// <param name="should">A boolean value indicating whether the transformations should be applied.</param>
	/// <param name="transformsFunction">A params array of functions that represent the transformations to apply to the input query.</param>
	/// <returns>An <see cref="IQueryable{T}"/> that has been conditionally transformed based on the provided functions.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> or <paramref name="transformsFunction"/> is null.</exception>
	[Pure]
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine", "David McCarter", "8/18/20", ModifiedBy = "David McCarter", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IQueryable<T> If<T>(this IQueryable<T> input, bool should, params Func<IQueryable<T>, IQueryable<T>>[] transformsFunction)
	{
		input = input.ArgumentNotNull();
		transformsFunction = transformsFunction.ArgumentItemsExists();

		return should ? transformsFunction.Aggregate(input, (current, transform) => transform(current)) : input;
	}

	/// <summary>
	/// Conditionally applies a series of transformations to the input <see cref="IEnumerable{T}"/> based on a boolean condition.
	/// This allows for dynamic query composition by including or excluding parts of the query based on the specified condition.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <see cref="IEnumerable{T}"/>.</typeparam>
	/// <param name="input">The input sequence to transform.</param>
	/// <param name="should">A boolean value indicating whether the transformations should be applied.</param>
	/// <param name="transformsFunction">A params array of functions that represent the transformations to apply to the input sequence.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> that has been conditionally transformed based on the provided functions.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="input"/> or <paramref name="transformsFunction"/> is null.</exception>
	/// <remarks>
	/// <para>
	/// <b>Performance Optimization (.NET 10):</b> This method uses optimized paths for different transformation counts:
	/// </para>
	/// <list type="bullet">
	/// <item><description><b>Condition false:</b> Returns input immediately (zero overhead).</description></item>
	/// <item><description><b>Zero transforms:</b> Returns input immediately.</description></item>
	/// <item><description><b>One transform:</b> Direct invocation without loop overhead.</description></item>
	/// <item><description><b>Multiple transforms:</b> Uses simple for loop instead of Aggregate for better performance.</description></item>
	/// </list>
	/// <para>
	/// <b>Performance Characteristics:</b>
	/// </para>
	/// <list type="bullet">
	/// <item><description><b>Condition false:</b> O(1) - Returns original input.</description></item>
	/// <item><description><b>Condition true:</b> O(n) where n = number of transforms, with optimized fast paths.</description></item>
	/// </list>
	/// </remarks>
	[Pure]
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine", "David McCarter", "8/18/20", ModifiedBy = "David McCarter", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<T> If<T>([DisallowNull] this IEnumerable<T> input, bool should, [DisallowNull] params Func<IEnumerable<T>, IEnumerable<T>>[] transformsFunction)
	{
		input = input.ArgumentNotNull();
		transformsFunction = transformsFunction.ArgumentItemsExists();

		// Fast path: condition false - return immediately
		if (!should)
		{
			return input;
		}

		// Fast path: no transforms
		if (transformsFunction.Length == 0)
		{
			return input;
		}

		// Fast path: single transform
		if (transformsFunction.Length == 1)
		{
			return transformsFunction[0](input);
		}

		// Multiple transforms: use simple for loop (faster than Aggregate)
		var result = input;

		for (var transformIndex = 0; transformIndex < transformsFunction.Length; transformIndex++)
		{
			result = transformsFunction[transformIndex](result);
		}

		return result;
	}

}
