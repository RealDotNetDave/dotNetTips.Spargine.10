// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-23-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 06-10-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsDistinctCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class EnumerableExtensionsDistinctCollectionBenchmark : LargeCollectionBenchmark
{
	private IEnumerable<Person> _personRefEnumerable = default!;
	private IEnumerable<Spargine.Tester.Models.ValueTypes.Person> _personValEnumerable = default!;

	[Benchmark(Description = nameof(EnumerableExtensions.FastDistinct) + ": Comparer - Ref")]
	public void Distinct_FastDistinct_Comparer_Ref()
	{
		var people = this._personRefEnumerable.AddLast(this.PersonRef01);

		var result = people.FastDistinct(new PersonEqualityComparer());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastDistinct) + ": Comparer - Val")]
	public void Distinct_FastDistinct_Comparer_Val()
	{
		var people = this._personValEnumerable.AddLast(this.PersonVal01);

		var result = people.FastDistinct(new Spargine.Tester.Models.ValueTypes.Comparers.PersonEqualityComparer());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastDistinct) + ": IEnumerable<ref>")]
	public void Distinct_FastDistinct_IEnumerable_Ref()
	{
		var people = this._personRefEnumerable.AddLast(this.PersonRef01);

		var result = people.FastDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastDistinct) + ": IEnumerable<val>")]
	public void Distinct_FastDistinct_IEnumerable_Val()
	{
		var people = this._personValEnumerable.AddLast(this.PersonVal01);

		var result = people.FastDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastDistinct) + ": List<ref>")]
	public void Distinct_FastDistinct_List_Ref()
	{
		var people = this._personRefEnumerable.AddLast(this.PersonRef01).ToList();

		var result = people.FastDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastDistinct) + ": List<val>")]
	public void Distinct_FastDistinct_List_Val()
	{
		var people = this._personValEnumerable.AddLast(this.PersonVal01).ToList();

		var result = people.FastDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastDistinct) + ": ReadOnlyCollection<ref>")]
	public void Distinct_FastDistinct_ReadOnlyCollection_Ref()
	{
		var people = this._personRefEnumerable.AddLast(this.PersonRef01).ToReadOnlyCollection();

		var result = people.FastDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastDistinct) + ": ReadOnlyCollection<val>")]
	public void Distinct_FastDistinct_ReadOnlyCollection_Val()
	{
		var people = this._personValEnumerable.AddLast(this.PersonVal01).ToReadOnlyCollection();

		var result = people.FastDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = "Distinct: LINQ.Distinct with Comparer - Ref")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void Distinct_LINQ_Distinct_Comparer_Ref_ForComparison()
	{
		var people = this._personRefEnumerable.AddLast(this.PersonRef01);

		var result = people.Distinct(new PersonEqualityComparer());

		this.Consume(result);
	}

	[Benchmark(Description = "Distinct: LINQ.Distinct with Comparer - Val")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void Distinct_LINQ_Distinct_Comparer_Val_ForComparison()
	{
		var people = this._personValEnumerable.AddLast(this.PersonVal01);

		var result = people.Distinct(new Spargine.Tester.Models.ValueTypes.Comparers.PersonEqualityComparer());

		this.Consume(result);
	}

	[Benchmark(Description = "Distinct: LINQ.Distinct - IEnumerable<Ref>")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void Distinct_LINQ_Distinct_Ref_ForComparison()
	{
		var people = this._personRefEnumerable.AddLast(this.PersonRef01);

		var result = people.Distinct();

		this.Consume(result);
	}

	[Benchmark(Description = "Distinct: LINQ.Distinct - IEnumerable<Val>")]
	[BenchmarkCategory(Categories.LINQ, Categories.ForComparison)]
	public void Distinct_LINQ_Distinct_Val_ForComparison()
	{
		var people = this._personValEnumerable.AddLast(this.PersonVal01);

		var result = people.Distinct();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personValEnumerable = this.GetPersonValArray().AsEnumerable();
	}
}
