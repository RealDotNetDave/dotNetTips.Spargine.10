// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 06-10-2026
// ***********************************************************************
// <copyright file="ArrayExtensionsMutatingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark tests for ArrayExtensions methods that mutate collections,
// including AddFirst*, AddLast*, Remove*, Upsert*, and in-place processing methods.
// Uses [IterationSetup] to reset collections before each iteration.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class ArrayExtensionsMutatingCollectionBenchmark.
/// Benchmark tests for ArrayExtensions methods that mutate or structurally modify collections.
/// Collections are reset before each iteration via <see cref="Reset"/>.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class ArrayExtensionsMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private PersonRecord[] _personRecordArray = default!;
	private Person[] _personRefArray = default!;
	private Spargine.Tester.Models.ValueTypes.Person[] _personValArray = default!;

	[Benchmark(Description = nameof(ArrayExtensions.AddFirst) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AddFirstRef()
	{
		var result = this._personRefArray.AddFirst(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddFirst) + " : Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void AddFirstVal()
	{
		var result = this._personValArray.AddFirst(this.PersonVal01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddLast) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AddLastRef()
	{
		var result = this._personRefArray.AddLast(this.PersonRef02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddLast) + " : Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void AddLastVal()
	{
		var result = this._personValArray.AddLast(this.PersonVal02);

		this.Consume(result);
	}

	[Benchmark(Description = "Process Collection: FastProcessor()")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ProcessCollection_FastProcessor()
	{
		var people = this._personRefArray;

		people.FastProcessor(person => person.Phone = "5555555555");

		this.Consume(people);
	}

	[Benchmark(Description = "Process Collection: foreach()")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void ProcessCollection_ForComparison()
	{
		var people = this._personRefArray;

		for (var index = 0; index < people.Length; index++)
		{
			people[index].Phone = "5555555555";
		}

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void RemoveFirstRef()
	{
		var result = this._personRefArray.RemoveFirst();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst) + " : Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void RemoveFirstVal()
	{
		var result = this._personValArray.RemoveFirst();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveLast) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void RemoveLastRef()
	{
		var result = this._personRefArray.RemoveLast();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveLast) + " : Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void RemoveLastVal()
	{
		var result = this._personValArray.RemoveLast();

		this.Consume(result);
	}

	/// <summary>
	/// Resets the collections before each benchmark iteration to ensure mutations from the
	/// previous iteration do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this._personRecordArray = this.GetPersonRecordArray();
		this._personRefArray = this.GetPersonRefArray();
		this._personValArray = this.GetPersonValArray();
	}

	/// <summary>
	/// Initializes all collection fields. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRecordArray = this.GetPersonRecordArray();
		this._personRefArray = this.GetPersonRefArray();
		this._personValArray = this.GetPersonValArray();
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + ": Record")]
	[BenchmarkCategory(Categories.Array, Categories.RecordType)]
	public void UpsertRecordRecord()
	{
		var result = this._personRecordArray.Upsert(this.PersonRecord01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void UpsertRef()
	{
		var result = this._personRefArray.Upsert(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + " : Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void UpsertVal()
	{
		var result = this._personValArray.Upsert(this.PersonVal01);

		this.Consume(result);
	}

}
