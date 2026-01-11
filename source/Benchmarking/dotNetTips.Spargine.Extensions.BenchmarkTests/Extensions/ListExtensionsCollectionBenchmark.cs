// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-11-2026
// ***********************************************************************
// <copyright file="ListExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ListExtensionsCollectionBenchmark : LargeCollectionBenchmark
{
	private List<PersonRecord> _peopleRecordList;
	private List<Person> _peopleRefList;
	private List<Person> _peopleRefSubSet;
	private List<Spargine.Tester.Models.ValueTypes.Person> _peopleValList;


	[Benchmark(Description = nameof(ListExtensions.AsReadOnlySpan))]
	public void AsReadOnlySpan()
	{
		var people = this._peopleRefList;

		var collection = people.AsReadOnlySpan();

		this.Consume(collection.Length);
	}

	[Benchmark(Description = nameof(ListExtensions.AsSpan))]
	public void AsSpan()
	{
		var people = this._peopleRefList;

		var collection = people.AsSpan();

		this.Consume(collection.Length);
	}

	[Benchmark(Description = nameof(ListExtensions.ClearNulls))]
	public void ClearNulls()
	{
		var people = this._peopleRefList;
		people.Add(null);

		var result = people.ClearNulls();

		this.Consume(result);
	}

	[Benchmark(Description = "Count")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void Count_Count()
	{
		var result = this._peopleRefList.Count;

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.FastCount))]
	[BenchmarkCategory(Categories.New)]
	public void Count_FastCount()
	{
		var result = this._peopleRefList.FastCount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IsEmpty))]
	[BenchmarkCategory(Categories.Collections)]
	public void DoesNotHaveItems()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsEmpty());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": record")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeRecord()
	{
		var people = this._peopleRecordList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": ref")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeRef()
	{
		var people = this._peopleRefList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.GenerateHashCode) + ": val")]
	[BenchmarkCategory(Categories.Collections)]
	public void GenerateHashCodeVal()
	{
		var people = this._peopleValList;

		this.Consume(people.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ListExtensions.IsNotEmpty))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItems()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsNotEmpty());
	}

	[Benchmark(Description = nameof(ListExtensions.IsNotEmpty) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithCount()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsNotEmpty(5));
	}

	[Benchmark(Description = nameof(ListExtensions.IsNotEmpty) + ": With Predicate")]
	public void HasItemsWithPredicate()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsNotEmpty(p => p.BornOn.Value.Date.Month > 0));
	}

	[Benchmark(Description = "Index []: Compare with IndexAtLooped")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void Index()
	{
		var result = this._peopleRefList[this.HalfCount];

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IndexAtLooped))]
	public void IndexAtLooped()
	{
		var result = this._peopleRefList.IndexAtLooped(this.HalfCount);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.IsEqualTo))]
	[BenchmarkCategory(Categories.Collections)]
	public void IsEqualTo()
	{
		var people = this._peopleRefList;

		this.Consume(people.IsEqualTo(this._peopleRefList));
	}

	[Benchmark(Description = nameof(ListExtensions.PerformAction) + " :Ref")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void PerformAction_Ref()
	{
		var people = this._peopleRefList;
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append(CultureInfo.CurrentCulture, $"{person.ToString()}|"));

		this.Consume(sb.ToString());
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleRecordList = [.. this.GetPersonRecordArray()];
		this._peopleRefList = [.. this.GetPersonRefArray()];
		this._peopleRefSubSet = [.. this.GetPersonRefArray().TakeLast(10)];
		this._peopleValList = [.. this.GetPersonValArray()];
	}

	[Benchmark(Description = nameof(ListExtensions.FastShuffle))]
	[BenchmarkCategory(Categories.Collections)]
	public void ShuffleFastShuffle()
	{
		this.ConsumeEnumerable(this._peopleRefList.FastShuffle());
	}

	[Benchmark(Description = nameof(ListExtensions.FastShuffleAsSpan))]
	[BenchmarkCategory(Categories.Collections)]
	public void ShuffleFastShuffleAsSpan()
	{
		this.ConsumeSpan(this._peopleRefList.FastShuffleAsSpan());
	}

	[Benchmark(Description = "Shuffle")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void ShuffleShuffle()
	{
		var result = this._peopleRefList.Shuffle().ToList();

		this.ConsumeEnumerable(result);
	}

	[Benchmark(Description = nameof(ListExtensions.Split))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void Split()
	{
		var result = this._peopleRefList.Split(this._peopleRefList.Count / 2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToFrozenSet))]
	public void ToFrozenSet()
	{
		var result = this._peopleRefList.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToImmutableArray))]
	public void ToImmutableArray()
	{
		var result = this._peopleRefList.ToImmutableArray();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToObservableCollection))]
	public void ToObservableCollection()
	{
		var result = this._peopleRefList.ToObservableCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyList))]
	public void ToReadOnlyList()
	{
		var result = this._peopleRefList.ToReadOnlyList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ListExtensions.ToReadOnlyObservableCollection))]
	public void ToReadOnlyObservableCollection()
	{
		var result = this._peopleRefList.ToReadOnlyObservableCollection();

		this.Consume(result);
	}

}
