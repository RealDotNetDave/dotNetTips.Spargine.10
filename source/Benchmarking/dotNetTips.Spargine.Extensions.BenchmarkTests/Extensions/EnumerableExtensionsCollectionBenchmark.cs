// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-28-2025
// ***********************************************************************
// <copyright file="EnumerableExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// EnumerableExtensions PerfTestRunner.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[MemoryDiagnoser]
[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsCollectionBenchmark : LargeCollectionBenchmark
{
	//TODO: BREAK UP. TAKES OVER 4 HOURS TO RUN ALL TESTS!	

	private IEnumerable<Spargine.Tester.Models.ValueTypes.Coordinate> _coordinateValEnumerable;
	private List<PersonRecord> _personRecordList;
	private IEnumerable<Person> _personRefEnumerable;
	private IEnumerable<Person> _personRefEnumerableToAdd;
	private string _personRefId;
	private Person _personRefLast;
	private List<Person> _personRefList;
	private List<Person> _personRefListDups;
	private IEnumerable<Spargine.Tester.Models.ValueTypes.Person> _personValEnumerable;

	private static bool AnyWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate) => list.Any(predicate);


	[Benchmark(Description = nameof(EnumerableExtensions.AddDistinct))]
	public void AddDistinct()
	{
		var result = this._personRefEnumerable.AddDistinct(this._personRefEnumerableToAdd).ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddFirst))]
	public void AddFirst()
	{
		var result = this._personRefEnumerable.AddFirst(this.PersonRef01).ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddIf))]
	public void AddIf()
	{

		var result = this._personRefEnumerable.AddIf(this.PersonRef01, true).ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddLast))]
	public void AddLast()
	{

		var result = this._personRefEnumerable.AddLast(this.PersonRef01).ToList();

		this.Consume(result);
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

	[Benchmark(Description = "Chunk (compare to Page and Partition)")]
	[BenchmarkCategory(Categories.ForComparison, Categories.New)]
	public void Chunk()
	{
		foreach (var people in this._personRefEnumerable.Chunk(25))
		{
			foreach (var person in people)
			{
				this.Consume(person);
			}
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ContainsAny))]
	public void ContainsAny()
	{
		var people = this._personRefEnumerable;

		people = people.AddLast(people.FirstOrDefault());

		var result = people.ContainsAny(people.Take(10).ToArray().AsReadOnly());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ContainsAny) + ": as Reference")]
	[BenchmarkCategory(Categories.Collections, Categories.ReferenceType)]
	public void ContainsAnyRef()
	{
		var result = this._personRefEnumerable.ContainsAny(this.GetPersonRefArray().AsReadOnly());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ContainsAny) + ": as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void ContainsAnyVal()
	{
		var result = this._personValEnumerable.ContainsAny(this.GetPersonValArray().AsReadOnly());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Create))]
	public void Create()
	{
		var people = this._personRefEnumerable;

		people = people.Create(true);

		var result = people.ContainsAny(people.Take(10).ToArray().AsReadOnly());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsEmpty))]
	public void DoesNotHaveItemsIsEmpty()
	{
		var result = this._personRefEnumerable.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.EnsureUnique))]
	public void EnsureUnique()
	{
		var people = this._personRefEnumerable.AddLast(this.PersonRef01);

		var result = people.EnsureUnique().ToList();

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

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
	public void FirstOrNull()
	{
		var result = this._coordinateValEnumerable.FirstOrNull(p => p.X == this.CoordinateVal01.X);

		this.Consume(result);
	}


	[Benchmark(Description = nameof(EnumerableExtensions.HasDuplicates))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasDuplicates()
	{
		var result = this._personRefListDups.HasDuplicates();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
	public void IndexOf()
	{
		var people = this._personRefEnumerable;
		var result = people.IndexOf(this._personRefLast);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Comparer")]
	public void IndexOfComparer()
	{
		var people = this._personRefEnumerable;
		var comparer = new PersonComparer();
		var result = people.IndexOf(this._personRefLast, comparer);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Predicate")]
	[BenchmarkCategory(Categories.New)]

	public void IndexOfPredicate()
	{
		var people = this._personRefEnumerable;
		var result = people.IndexOf(p => p.Equals(this._personRefLast));

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

	[Benchmark(Description = "LINQ Sequence Equal")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void LINQSequenceEqual()
	{
		var people = this._personRefEnumerable;
		var result = people.SequenceEqual(this._personRefEnumerableToAdd);

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
		var result = new List<Person>(people.Count());

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
		var result = this._personRefEnumerable.OrderBy(p => p.Email).ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
	public void OrderByOrdinal()
	{
		var result = this._personRefEnumerable.OrderByOrdinal(p => p.Email).ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderBy) + ": With Sort Expression")]
	public void OrderBySortExpression()
	{
		var result = this._personRefEnumerable.OrderBy("Email desc").ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Page))]
	public void Page()
	{
		foreach (var people in this._personRefEnumerable.Page(25))
		{
			foreach (var person in people)
			{
				this.Consume(person);
			}
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Partition))]
	public void Partition()
	{
		foreach (var partition in this._personRefEnumerable.Partition(this.Count / 2))
		{
			foreach (var person in partition)
			{
				this.Consume(person);
			}
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
	public void PickRandom()
	{
		var result = this._personRefEnumerable.PickRandom();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.RemoveDuplicates))]
	[BenchmarkCategory(Categories.Collections)]
	public void RemoveDuplicates()
	{
		var result = this._personRefListDups.RemoveDuplicates().Value.ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.RemoveNulls))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void RemoveNulls()
	{
		var collection = this._personRefEnumerable.ToList();

		// Add a null to the collection
		collection.AddFirst(null);
		collection.AddLast(null);

		var result = collection.RemoveDuplicates().Value.ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ReplaceIf))]
	[BenchmarkCategory(Categories.New)]
	public void ReplaceIf()
	{
		var people = this._personRefEnumerable;
		var result = people.ReplaceIf((p, index) => string.Equals(p.Id, this._personRefId, StringComparison.Ordinal), this._personRefLast).ToList();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefList = [.. this.GetPersonRefArray()];
		this._personRecordList = [.. this.GetPersonRecordArray()];
		this._coordinateValEnumerable = this.GetCoordinateValArray().AsEnumerable();
		this._personValEnumerable = this.GetPersonValArray().AsEnumerable();

		this._personRefLast = this._personRefList.Last();
		this._personRefId = this._personRefList[this.Count / 2].Id;

		var peopleToAdd = this._personRefEnumerable.ToList();
		peopleToAdd.AddRange(this.GetPersonRefCollectionToInsert().Take(this.Count / 10));
		this._personRefEnumerableToAdd = peopleToAdd.AsEnumerable();

		// Create collection with duplicates
		var dups = this._personRefEnumerable.Shuffle().Take(this.Count / 10);
		this._personRefListDups = [.. this._personRefEnumerable];
		foreach (var person in dups)
		{
			_ = this._personRefListDups.Append(person);
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastShuffle))]
	public void ShuffleFastShuffle()
	{
		var result = this._personRefEnumerable.FastShuffle().ToList();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastShuffle) + "With Count")]
	public void ShuffleFastShuffleWithCount()
	{
		var result = this._personRefEnumerable.FastShuffle(this.Count / 2).ToList();
		this.Consume(result);
	}

	[Benchmark(Description = "Shuffle")]
	public void ShuffleShuffle()
	{
		var result = this._personRefEnumerable.Shuffle().ToList();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
	public void StartsWith()
	{
		var people = this._personRefEnumerable;
		var result = people.StartsWith(people.Take(10));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
	public void StructuralSequenceEqual()
	{
		var people = this._personRefEnumerable;
		var result = people.StructuralSequenceEqual(this._personRefEnumerableToAdd);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Upsert))]
	public void Upsert()
	{
		var people = this._personRefEnumerable;

		var result = people.Upsert(this.PersonRef01);

		this.Consume(result);
	}

}
