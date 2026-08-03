// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="ReadOnlyMemoryExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <c>ReadOnlyMemory{T}</c> providing presence checks (<c>IsNotEmpty</c>),
// zero-copy array extraction (<c>TryGetArraySegment</c>), conditional array materialization
// (<c>ToArrayIfNeeded</c>), and sequence equality comparison (<c>IsEqualTo</c>).
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ReadOnlyMemory{T}"/> to enhance its functionality.
/// </summary>
/// <remarks>
/// Methods are grouped by purpose: presence checks (<c>IsNotEmpty</c>), zero-copy array extraction
/// (<c>TryGetArraySegment</c>), conditional array materialization (<c>ToArrayIfNeeded</c>), and
/// low-allocation equality comparison (<c>IsEqualTo</c>) performed over the underlying <see cref="ReadOnlySpan{T}"/>.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class ReadOnlyMemoryExtensions
{
	/// <summary>
	/// Provides extension methods for <see cref="ReadOnlyMemory{T}"/> to enhance its functionality.
	/// </summary>
	/// <typeparam name="T">The type of elements in the memory block.</typeparam>
	/// <param name="memory">The <see cref="ReadOnlyMemory{T}"/> instance to extend.</param>
	extension<T>([DisallowNull] ReadOnlyMemory<T> memory)
	{
		/// <summary>
		/// Determines whether the <see cref="ReadOnlyMemory{T}"/> contains any elements.
		/// </summary>
		/// <returns><see langword="true"/> if <paramref name="memory"/> is not empty; otherwise, <see langword="false"/>.</returns>
		/// <example>
		/// <code>
		/// ReadOnlyMemory&lt;int&gt; memory = new[] { 1, 2, 3 };
		/// bool hasItems = memory.IsNotEmpty();
		/// Console.WriteLine(hasItems); // Output: True
		///
		/// ReadOnlyMemory&lt;int&gt; empty = ReadOnlyMemory&lt;int&gt;.Empty;
		/// bool isEmpty = empty.IsNotEmpty();
		/// Console.WriteLine(isEmpty); // Output: False
		/// </code>
		/// </example>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
		public bool IsNotEmpty()
		{
			return !memory.IsEmpty;
		}

		/// <summary>
		/// Attempts to retrieve the underlying <see cref="ArraySegment{T}"/> that backs this <see cref="ReadOnlyMemory{T}"/> without copying.
		/// </summary>
		/// <param name="segment">
		/// When this method returns, contains the <see cref="ArraySegment{T}"/> backing <paramref name="memory"/>
		/// if the operation succeeded; otherwise, the default <see cref="ArraySegment{T}"/>.
		/// </param>
		/// <returns><see langword="true"/> if the backing array segment was retrieved successfully; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// Delegates to <see cref="MemoryMarshal.TryGetArray{T}(ReadOnlyMemory{T}, out ArraySegment{T})"/>, which succeeds
		/// only when <paramref name="memory"/> is backed by a managed array (for example, it returns <see langword="false"/>
		/// for native or pinned memory).
		/// </remarks>
		/// <example>
		/// <code>
		/// ReadOnlyMemory&lt;int&gt; memory = new[] { 1, 2, 3 };
		/// bool success = memory.TryGetArraySegment(out var segment);
		/// Console.WriteLine(success); // Output: True
		/// </code>
		/// </example>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(TryGetArraySegment), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
		public bool TryGetArraySegment(out ArraySegment<T> segment)
		{
			return MemoryMarshal.TryGetArray(memory, out segment);
		}

		/// <summary>
		/// Returns the elements of this <see cref="ReadOnlyMemory{T}"/> as an array, avoiding a copy when possible.
		/// </summary>
		/// <returns>
		/// The underlying array instance when <paramref name="memory"/> exactly spans its backing array (zero-copy);
		/// otherwise, a new array containing a copy of the elements in <paramref name="memory"/>.
		/// </returns>
		/// <remarks>
		/// Uses <see cref="MemoryMarshal.TryGetArray{T}(ReadOnlyMemory{T}, out ArraySegment{T})"/> to detect the
		/// zero-copy case. When <paramref name="memory"/> is a slice of a larger array, or is not array-backed,
		/// this falls back to <see cref="ReadOnlyMemory{T}.ToArray"/>, which always allocates a new array.
		/// </remarks>
		/// <example>
		/// <code>
		/// int[] source = { 1, 2, 3 };
		/// ReadOnlyMemory&lt;int&gt; full = source;
		/// int[] result = full.ToArrayIfNeeded();
		/// Console.WriteLine(ReferenceEquals(source, result)); // Output: True
		///
		/// ReadOnlyMemory&lt;int&gt; slice = source.AsMemory(1, 2);
		/// int[] copy = slice.ToArrayIfNeeded();
		/// Console.WriteLine(ReferenceEquals(source, copy)); // Output: False
		/// </code>
		/// </example>
		[Pure]
		[return: NotNull]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(ToArrayIfNeeded), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
		public T[] ToArrayIfNeeded()
		{
			return MemoryMarshal.TryGetArray(memory, out var segment) &&
				segment.Offset == 0 &&
				segment.Count == segment.Array!.Length
				? segment.Array
				: memory.ToArray();
		}

		/// <summary>
		/// Determines whether the current <see cref="ReadOnlyMemory{T}"/> is equal to <paramref name="other"/> by comparing elements.
		/// </summary>
		/// <param name="other">The <see cref="ReadOnlyMemory{T}"/> instance to compare with the current memory.</param>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> used to compare elements. If <see langword="null"/>,
		/// <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// <see langword="true"/> if both memory blocks contain the same number of elements and each corresponding
		/// element is equal; otherwise, <see langword="false"/>.
		/// </returns>
		/// <remarks>
		/// For performance, this method compares the underlying <see cref="ReadOnlySpan{T}"/> views via
		/// <see cref="System.MemoryExtensions.SequenceEqual{T}(ReadOnlySpan{T}, ReadOnlySpan{T}, IEqualityComparer{T}?)"/>
		/// without additional allocations.
		/// </remarks>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsEqualTo), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
		public bool IsEqualTo(ReadOnlyMemory<T> other, [AllowNull] IEqualityComparer<T>? comparer = null)
		{
			return memory.Span.SequenceEqual(other.Span, comparer);
		}
	}
}
