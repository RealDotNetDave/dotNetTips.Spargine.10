// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-27-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// EnumerableExtensions PerfTestRunner.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsCollectionBenchmark : LargeCollectionBenchmark
{
	private Person[] _personRefArray;
	private ConcurrentStack<Person> _personRefConcurrentStack;
	private IEnumerable<Person> _personRefEnumerable;
	private List<Person> _personRefEnumerableEnd;
	private List<Person> _personRefEnumerableStart;
	private IEnumerable<Person> _personRefEnumerableToAdd;
	private HashSet<Person> _personRefHashSet;
	private ImmutableQueue<Person> _personRefImmutableQueue;
	private IEnumerable<Spargine.Tester.Models.ValueTypes.Person> _personValEnumerable;

	[Benchmark(Description = nameof(EnumerableExtensions.AddDistinct))]
	public void AddDistinct()
	{
		var result = this._personRefEnumerable.AddDistinct(this._personRefEnumerableToAdd);

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddFirst))]
	public void AddFirst()
	{
		var result = this._personRefEnumerable.AddFirst(this.PersonRef01);

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddIf))]
	public void AddIf()
	{

		var result = this._personRefEnumerable.AddIf(this.PersonRef01, true);

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddLast))]
	public void AddLast()
	{
		var result = this._personRefEnumerable.AddLast(this.PersonRef01);

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastAny) + ": With Predicate")]
	public void AnyFastAnyWithPredicate()
	{
		var result = this._personRefEnumerable.FastAny(p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = "Any: With Predicate")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void AnyWithPredicate()
	{
		var result = AnyWithPredicate(this._personRefEnumerable, p => p.LastName.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ContainsAny))]
	public void ContainsAny()
	{
		var people = this._personRefEnumerable;

		var result = people.ContainsAny(this._personRefEnumerableEnd.AsReadOnly());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsEmpty) + ": Array<ref>")]
	public void DoesNotHaveItemsIsEmptyArrayRef()
	{
		var result = this._personRefArray.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsEmpty) + ": ConcurrentStack<ref>")]
	public void DoesNotHaveItemsIsEmptyConcurrentStackRef()
	{
		var result = this._personRefConcurrentStack.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsEmpty) + ": EnumerableQueue<ref>")]
	public void DoesNotHaveItemsIsEmptyEnumerableQueueRef()
	{
		var result = this._personRefImmutableQueue.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsEmpty) + ": Enumerable<ref>")]
	public void DoesNotHaveItemsIsEmptyEnumerableRef()
	{
		var result = this._personRefEnumerable.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": With Alternate")]
	public void FirstOrDefaultAlternate()
	{
		var result = this._personRefEnumerable.FirstOrDefault(alternate: this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, With Alternate")]
	public void FirstOrDefaultPredicateAlternate()
	{
		var result = this._personRefEnumerable.FirstOrDefault(p => string.Equals(p.Id, this.PersonRef01.Id, StringComparison.Ordinal), this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull) + ": Array<ref>")]
	public void FirstOrNullArrayRef()
	{
		var result = this._personRefArray.FirstOrNull(p => p.Email == this.PersonRef01.Email);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull) + ": Enumerable<ref>")]
	public void FirstOrNullEnumerableRef()
	{
		var result = this._personRefEnumerable.FirstOrNull(p => p.Email == this.PersonRef01.Email);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull) + ": Enumerable<val>")]
	public void FirstOrNullEnumerableVal()
	{
		var result = this._personValEnumerable.FirstOrNull(p => p.Email == this.PersonVal01.Email);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull) + ": HashSet<ref>")]
	public void FirstOrNullHashSetRef()
	{
		var result = this._personRefHashSet.FirstOrNull(p => p.Email == this.PersonRef01.Email);

		this.Consume(result);
	}

	[Benchmark(Description = "HasDuplicates(): IEnumerable<Ref>")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void HasDuplicatesRef()
	{
		var people = this._personRefEnumerable.AddLast(this.PersonRef01);

		var result = people.HasDuplicates();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
	public void IndexOf()
	{
		var people = this._personRefEnumerable;

		var result = people.IndexOf(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Comparer")]
	public void IndexOfComparer()
	{
		var people = this._personRefEnumerable;
		var comparer = new PersonEqualityComparer();

		var result = people.IndexOf(this.PersonRef01, comparer);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Predicate")]
	[BenchmarkCategory(Categories.New)]

	public void IndexOfPredicate()
	{
		var people = this._personRefEnumerable;

		var result = people.IndexOf(p => p.Equals(this.PersonRef01));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsNotEmpty))]
	public void IsNotEmpty()
	{
		var result = this._personRefEnumerable.IsNotEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsNotEmpty) + ": with Count")]
	public void IsNotEmptyWithCount()
	{
		var result = this._personRefEnumerable.IsNotEmpty(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsNullOrEmpty))]
	public void IsNullOrEmpty()
	{
		var result = this._personRefEnumerable.IsNullOrEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = "IsNullOrEmpty: Comparison using ? and Any()")]
	[BenchmarkCategory(Categories.Collections, Categories.LINQ, Categories.ForComparison)]
	public void IsNullOrEmptyComparison()
	{
		var result = this._personRefEnumerable?.Any() != true;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Join))]
	public void Join()
	{
		var people = this._personRefEnumerable;

		var result = people.Join();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastProcessor))]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ModifyCollectionFastProcessor()
	{
		var people = this._personRefEnumerable;

		people.FastProcessor(person => person.Phone = "5555555555");

		this.Consume(people);
	}

	[Benchmark(Description = "Modify Collection: Normal Loop")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void ModifyCollectionLoop()
	{
		var people = this._personRefEnumerable;
		var result = new List<Person>();

		foreach (var person in people)
		{
			person.Phone = "5555555555";
			result.Add(person);
		}

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderBy))]
	public void OrderBy()
	{
		var result = this._personRefEnumerable.OrderBy(p => p.Email);

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
	public void OrderByOrdinal()
	{
		var result = this._personRefEnumerable.OrderByOrdinal(p => p.Email);

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderBy) + ": With Sort Expression")]
	public void OrderBySortExpression()
	{
		var result = this._personRefEnumerable.OrderBy("Email desc");

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Partition))]
	public void Partition()
	{
		foreach (var partition in this._personRefEnumerable.Partition(this.HalfCount))
		{
			this.ConsumeEnumerable(partition);
		}
	}

	[Benchmark(Description = "Chunk (compare to Partition)")]
	[BenchmarkCategory(Categories.ForComparison, Categories.New)]
	public void PartitionChunk()
	{
		foreach (var people in this._personRefEnumerable.Chunk(this.HalfCount))
		{
			this.ConsumeEnumerable(people);
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
	public void PickRandom()
	{
		var result = this._personRefEnumerable.PickRandom();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.RemoveNulls))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveNulls()
	{
		var collection = this._personRefEnumerable;

		// Add a null to the collection
		var people = collection.ToList();
		people.Add(null);
		people.Add(null);

		collection = people.AsEnumerable();

		var result = collection.RemoveNulls();

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ReplaceIf))]
	[BenchmarkCategory(Categories.New)]
	public void ReplaceIf()
	{
		var people = this._personRefEnumerable;
		var result = people.ReplaceIf((p, index) => string.Equals(p.Id, this.PersonRef01.Id, StringComparison.Ordinal), this.PersonRef01);

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = "LINQ: SequenceEqual()")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void SequenceEqualLINQ()
	{
		var people = this._personRefEnumerable;
		var people2 = this._personRefEnumerableToAdd;

		var result = people.SequenceEqual(people2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
	public void SequenceEqualStructuralSequenceEqual()
	{
		var people1 = this._personRefEnumerable;
		var people2 = this._personRefEnumerableToAdd;

		var result = people1.StructuralSequenceEqual(people2);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefArray = this.GetPersonRefArray();
		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefHashSet = this.GetPersonRefArray().ToHashSet();
		this._personValEnumerable = this.GetPersonValArray().AsEnumerable();
		this._personRefImmutableQueue = ImmutableQueue.Create(this.GetPersonRefArray());
		this._personRefConcurrentStack = new ConcurrentStack<Person>(this.GetPersonRefArray());


		var peopleToAdd = this._personRefEnumerable.ToList();
		peopleToAdd.AddRange(this.GetPersonRefCollectionToInsert().Take(this.HalfCount));
		this._personRefEnumerableToAdd = peopleToAdd.AsEnumerable();

		this._personRefEnumerableStart = this._personRefEnumerable.Take(this.HalfCount).ToList();
		this._personRefEnumerableEnd = this._personRefEnumerable.Skip(this.Count - this.HalfCount).Take(this.HalfCount).ToList();
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastShuffle))]
	public void ShuffleFastShuffle()
	{
		var result = this._personRefEnumerable.FastShuffle();

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastShuffle) + "With Count")]
	public void ShuffleFastShuffleWithCount()
	{
		var result = this._personRefEnumerable.FastShuffle(this.HalfCount);

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = "Shuffle")]
	public void ShuffleShuffle()
	{
		var result = this._personRefEnumerable.Shuffle();

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
	public void StartsWith()
	{
		var people = this._personRefEnumerable;
		var result = people.StartsWith(this._personRefEnumerableStart);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToUniqueCollection))]
	public void ToUniqueCollection()
	{
		var people = this._personRefEnumerable;

		people = people.ToUniqueCollection();

		var result = people.ContainsAny(this._personRefEnumerableStart.AsReadOnly());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Upsert))]
	public void Upsert()
	{
		var people = this._personRefEnumerable;

		var result = people.Upsert(this.PersonRef01);

		this.ConsumeEnumerable(result);
	}

	private static bool AnyWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate) => list.Any(predicate);

}
