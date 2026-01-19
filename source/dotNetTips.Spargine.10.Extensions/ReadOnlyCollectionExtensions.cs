// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 04-27-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-19-2026
// ***********************************************************************
// <copyright file="ReadOnlyCollectionExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods tailored for ReadOnlyCollection.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="ReadOnlyCollection{T}"/>.
/// These methods include checks for item presence, generating hash codes, and performing actions on items within the collection.
/// </summary>
[Information(Status = Status.NeedsDocumentation)]
public static class ReadOnlyCollectionExtensions
{
	/// <summary>
	/// Extension methods for <see cref="IReadOnlyCollection{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	/// <param name="collection">The collection to extend.</param>
	extension<T>([DisallowNull] IReadOnlyCollection<T> collection)
	{

		/// <summary>
		/// Determines whether the collection is null or contains no items.
		/// </summary>
		/// <returns>
		/// <c>true</c> if the collection is <c>null</c> or empty; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[Information(nameof(IsEmpty), author: "David McCarter", createdOn: "6/17/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsEmpty()
		{
			return collection is null ? true : collection.Count <= 0;
		}

		/// <summary>
		/// Generates a hash code for the <see cref="ReadOnlyCollection{T}"/> using the specified equality comparer.
		/// </summary>
		/// <param name="comparer">
		/// The <see cref="IEqualityComparer{T}"/> implementation to use when computing hash codes for elements.
		/// If <c>null</c>, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </param>
		/// <returns>
		/// A hash code for the collection, considering the hash codes of individual elements computed using the specified comparer.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Thrown if collection is <c>null</c>.
		/// </exception>
		/// <remarks>
		/// <para>
		/// This method computes the hash code by aggregating the hash codes of the elements in the collection using the specified comparer.
		/// If no comparer is provided, <see cref="EqualityComparer{T}.Default"/> is used.
		/// </para>
		/// <para>
		/// <b>Hash Code Algorithm:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description>Uses a prime number seed (6551) for initial hash value</description></item>
		/// <item><description>Applies bitwise XOR and left shift operations for mixing</description></item>
		/// <item><description>Skips null elements to avoid NullReferenceException</description></item>
		/// <item><description>Uses the comparer's GetHashCode method for each element</description></item>
		/// </list>
		/// <para>
		/// <b>When to Use Custom Comparers:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Case-insensitive string comparison:</b> Use <see cref="StringComparer.OrdinalIgnoreCase"/> to generate consistent hash codes regardless of casing.</description></item>
		/// <item><description><b>Custom object comparison:</b> When objects should be considered equal based on specific properties rather than default equality.</description></item>
		/// <item><description><b>Culture-specific comparison:</b> Use culture-aware comparers for internationalized applications.</description></item>
		/// <item><description><b>Reference equality:</b> Use <see cref="ReferenceEqualityComparer"/> to hash based on object identity rather than value equality.</description></item>
		/// </list>
		/// <para>
		/// <b>Performance Characteristics:</b>
		/// </para>
		/// <list type="bullet">
		/// <item><description><b>Time complexity:</b> O(n) where n is the number of elements in the collection.</description></item>
		/// <item><description><b>Space complexity:</b> O(1) - no additional memory allocation.</description></item>
		/// <item><description><b>Enumeration:</b> Single-pass enumeration of the collection.</description></item>
		/// </list>
		/// </remarks>
		/// <example>
		/// <code>
		/// var names = new ReadOnlyCollection&lt;string&gt;(new[] { "Alice", "BOB", "Charlie" });
		/// 
		/// // Default hash code (using default comparer)
		/// int hash1 = names.GenerateHashCode();
		/// 
		/// // Explicit default comparer (null)
		/// int hash2 = names.GenerateHashCode(null);
		/// 
		/// // Case-insensitive hash code
		/// int hash3 = names.GenerateHashCode(StringComparer.OrdinalIgnoreCase);
		/// 
		/// // Custom comparer for Person objects based on Id
		/// var people = new ReadOnlyCollection&lt;Person&gt;(new[] 
		/// { 
		///     new Person { Id = 1, Name = "John" },
		///     new Person { Id = 2, Name = "Jane" }
		/// });
		/// var personComparer = new PersonComparer();
		/// int hash4 = people.GenerateHashCode(personComparer);
		/// // Hash code computed based on Person.Id property only
		/// </code>
		/// </example>
		[Pure]
		[Information(nameof(GenerateHashCode), author: "David McCarter", createdOn: "1/8/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Updated)]
		public int GenerateHashCode([AllowNull] IEqualityComparer<T>? comparer = null)
		{
			collection = collection.ArgumentNotNull();

			var eq = comparer ?? EqualityComparer<T>.Default;
			var hash = 6551;

			foreach (var item in collection)
			{
				if (item is not null)
				{
					hash ^= (hash << 5) ^ eq.GetHashCode(item);
				}
			}

			return hash;
		}

		/// <summary>
		/// Determines whether the specified collection has any items that match the given predicate.
		/// </summary>
		/// <param name="actionPredicate">A predicate to test each element for a condition.</param>
		/// <returns>
		/// <c>true</c> if the collection is not <c>null</c> and any elements match the predicate; otherwise, <c>false</c>.
		/// </returns>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsNotEmpty), author: "David McCarter", createdOn: "6/15/2022", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
		public bool IsNotEmpty([DisallowNull] Func<T, bool> actionPredicate)
		{
			return collection is null || actionPredicate is null ? false : collection.Any(actionPredicate);
		}

	}
}
