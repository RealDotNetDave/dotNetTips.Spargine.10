// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="EnumerableExtensionsMutatingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark tests for EnumerableExtensions methods that mutate collections in-place,
// including FastProcessor (void and transform overloads) and a normal loop comparison.
// Uses [IterationSetup] to reset the working collections before each iteration.
// </summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class EnumerableExtensionsMutatingCollectionBenchmark.
/// Benchmark tests for <see cref="EnumerableExtensions"/> methods that mutate collections
/// in-place. Working collections are restored before each iteration via <see cref="Reset"/>.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
[TailCallDiagnoser]
public class EnumerableExtensionsMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private Person[] _personRefArray = default!;
	private IEnumerable<Person> _personRefEnumerable = default!;
	private List<Person> _personRefList = default!;

	[Benchmark(Description = nameof(EnumerableExtensions.FastProcessor) + ": Array")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ModifyCollectionFastProcessorArray()
	{
		var people = this._personRefArray;

		people.FastProcessor(person => person.Phone = "5555555555");

		this.Consume(people);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastProcessor) + ": IEnumerable")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ModifyCollectionFastProcessorEnumerable()
	{
		var people = this._personRefEnumerable;

		people.FastProcessor(person => person.Phone = "5555555555");

		this.Consume(people);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastProcessor) + ": List")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ModifyCollectionFastProcessorList()
	{
		var people = this._personRefList;

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

	/// <summary>
	/// Resets all working collections before each benchmark iteration so that in-place
	/// mutations from the previous invocation do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this._personRefArray = this.GetPersonRefArray();
		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefList = [.. this.GetPersonRefArray()];
	}

	/// <summary>
	/// Initializes all working collections. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefArray = this.GetPersonRefArray();
		this._personRefEnumerable = this.GetPersonRefArray().AsEnumerable();
		this._personRefList = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastProcessor) + ": Transform - Array")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TransformCollectionFastProcessorArray()
	{
		var result = this._personRefArray.FastProcessor(person =>
		{
			person.Phone = "5555555555";
			return person;
		});

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastProcessor) + ": Transform - IEnumerable")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TransformCollectionFastProcessorEnumerable()
	{
		var result = this._personRefEnumerable.FastProcessor(person =>
		{
			person.Phone = "5555555555";
			return person;
		});

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastProcessor) + ": Transform - List")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TransformCollectionFastProcessorList()
	{
		var result = this._personRefList.FastProcessor(person =>
		{
			person.Phone = "5555555555";
			return person;
		});

		this.Consume(result);
	}
}
