// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-19-2026
// ***********************************************************************
// <copyright file="ArrayExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class ArrayExtensionsCollectionBenchmark.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class ArrayExtensionsCollectionBenchmark : LargeCollectionBenchmark
{

	private const int OperationsCount = 1024;
	private byte[] _byteArray;
	private PersonRecord[] _personRecordArray;
	private Person[] _personRefArray;
	private Person[] _personRefArrayHalf;
	private Person[] _personRefArrayWithDups;
	private Spargine.Tester.Models.ValueTypes.Person[] _personValArray;
	private Spargine.Tester.Models.ValueTypes.Person[] _personValArrayHalf;

	[Benchmark(Description = nameof(ArrayExtensions.AddFirst) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AddFirst_Ref()
	{
		var result = this._personRefArray.AddFirst(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddLast) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AddLast_Ref()
	{
		var result = this._personRefArray.AddLast(this.PersonRef02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AreEqual_Ref()
	{
		var result = this._personRefArray.AreEqual(this._personRefArrayHalf);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void AreEqual_Val()
	{
		var result = this._personValArray.AreEqual(this._personValArrayHalf);

		this.Consume(result);
	}

	[Benchmark(Description = "Array: Spargine IndexOf(ref)")]
	[BenchmarkCategory(Categories.GenericCollections)]
	public int Array_Search_IndexOf_LINQ_Ref()
	{
		return this._personRefArray.IndexOf(p => p.Equals(this.PersonRefLookupLast));
	}

	[Benchmark(Description = nameof(GetHashCode))]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ArrayHashCode_Ref()
	{
		this.Consume(this._personRefArray.GetHashCode());
	}

	[Benchmark(Description = nameof(ArrayExtensions.AsReadOnlySpan) + " : Reference")]
	[BenchmarkCategory(Categories.Span, Categories.ReferenceType)]
	public void AsReadOnlySpan_Ref()
	{
		var result = this._personRefArray.AsReadOnlySpan();

		this.Consume(result.ToArray());
	}

	[Benchmark(Description = nameof(Array.Clone) + ": Array as Record")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void CloneArrayClonePersonRecord()
	{
		var result = this._personRecordArray.Clone();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(Array.Clone) + ": Array as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void CloneArrayClonePersonRef()
	{
		var result = this._personRefArray.Clone();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(Array.Clone) + ": Array as Val")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void CloneArrayClonePersonVal()
	{
		var result = this._personValArray.Clone();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastClone) + ": Array - Record")]
	[BenchmarkCategory(Categories.Array, Categories.RecordType)]
	public void CloneFastClonePersonRecordRecord()
	{
		var result = this._personRecordArray.FastClone();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastClone) + ": Array - Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void CloneFastClonePersonRef()
	{
		var result = this._personRefArray.FastClone();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastClone) + ": Array - Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void CloneFastClonePersonVal()
	{
		var result = this._personValArray.FastClone();

		this.Consume(result);
	}

	[Benchmark(OperationsPerInvoke = OperationsCount, Description = nameof(ArrayExtensions.FastLongCount) + ": Ref")]
	[BenchmarkCategory(Categories.Array)]
	public void FastLongCountArrayRef()
	{
		this.Consume(this._personRefArray.FastLongCount());
	}

	[Benchmark(Description = nameof(ArrayExtensions.GenerateHashCode) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void GenerateHashCode_Ref()
	{
		this.Consume(this._personRefArray.GenerateHashCode());
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastHashData) + ": byte[]")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HashDataFastHashData()
	{
		this.Consume(this._byteArray.FastHashData());
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": With Predicate - Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HasItemsWithPredicateVal()
	{
		this.Consume(this._personValArray.IsNotEmpty(p => p.LastName.IsNotEmpty()));
	}

	[Benchmark(Description = nameof(ArrayExtensions.IndexOf) + ": Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void IndexOfRefReference()
	{
		this.Consume(this._personRefArray.IndexOf(this.PersonRef01));
	}

	[Benchmark(Description = nameof(ArrayExtensions.IndexOf) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void IndexOfRefValue()
	{
		this.Consume(this._personValArray.IndexOf(this.PersonVal01));
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void IsNotEmptyRef()
	{
		this.Consume(this._personRefArray.IsNotEmpty());
	}


	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void IsNotEmptyVal()
	{
		this.Consume(this._personValArray.IsNotEmpty());
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": With Count - Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void IsNotEmptyWithCountRef()
	{
		this.Consume(this._personRefArray.IsNotEmpty(this.Count));
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": With Count - Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void IsNotEmptyWithCountVal()
	{
		this.Consume(this._personValArray.IsNotEmpty(this.Count));
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": With Predicate - Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void IsNotEmptyWithPredicateRef()
	{
		this.Consume(this._personRefArray.IsNotEmpty(p => p.LastName.IsNotEmpty()));
	}

	[Benchmark(Description = nameof(ArrayExtensions.LastIndexOf) + ": Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void LastIndexOfRefReference()
	{
		this.Consume(this._personRefArray.LastIndexOf(this.PersonRef01));
	}

	[Benchmark(Description = nameof(ArrayExtensions.LastIndexOf) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void LastIndexOfVal()
	{
		this.Consume(this._personValArray.LastIndexOf(this.PersonVal01));
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Record")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void PerformActionRecord()
	{
		var byteArray = this._personRecordArray;
		var sb = new StringBuilder();

		byteArray.PerformAction((person) =>
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{person.PropertiesToString()}|");
		});

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " : Record (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.RecordType, Categories.ForComparison)]
	public void PerformActionRecordComparison()
	{
		var people = this._personRecordArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].GetHashCode()}-");
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Ref")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void PerformActionRef()
	{
		var sb = new StringBuilder();

		this._personRefArray.PerformAction((person) => _ = sb.Append(CultureInfo.CurrentCulture, $"{person.GetHashCode()}-"));

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Ref (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void PerformActionRefComparison()
	{
		var people = this._personRefArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].GetHashCode()}-");
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Val")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void PerformActionVal()
	{
		var people = this._personValArray;
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append(CultureInfo.CurrentCulture, $"{person.GetHashCode()}-"));

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Val (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType, Categories.ForComparison)]
	public void PerformActionValComparison()
	{
		var people = this._personValArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].GetHashCode()}-");
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = "Process Collection: FastProcessor()")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ProcessCollectionFastProcessorRef()
	{
		var people = this._personRefArray;

		people.FastProcessor(person => person.Phone = "5555555555");

		this.Consume(people);
	}

	[Benchmark(Description = "Process Collection: foreach()")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void ProcessCollectionNormalRef()
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

	[Benchmark(Description = nameof(ArrayExtensions.RemoveLast) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void RemoveLastRef()
	{
		var result = this._personRefArray.RemoveLast();

		this.Consume(result);
	}

	[Benchmark(Description = "Select Items: ArraySegment-HalfCount")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void SelectItemsArraySegment()
	{
		var result = new ArraySegment<Person>(this._personRefArray, 0, this.HalfCount).ToArray();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSelectItems) + ": Half Count")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void SelectItemsFastSelectItems()
	{
		var result = this._personRefArray.FastSelectItems(0, this.HalfCount);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRecordArray = this.GetPersonRecordArray();
		this._personRefArray = this.GetPersonRefArray();
		this._personRefArrayHalf = this.GetPersonRefArray().Take(this.HalfCount).ToArray();
		this._personValArray = this.GetPersonValArray();
		this._personValArrayHalf = this.GetPersonValArray().Take(this.HalfCount).ToArray();
		this._byteArray = this.GetByteArray(this.Count);

		this._personRefArrayWithDups = this.GetPersonRefArray();

		var personDups = this.GetPersonRefArray().ToList();
		_ = personDups.AddRange(this.GetPersonRefArray().Take(this.HalfCount), false);
		_ = this._personRefArrayWithDups = personDups.ToArray();

		LogInfo($"PersonRecordArray: {this._personRecordArray.Length}");
		LogInfo($"PersonRefArray: {this._personRefArray.Length}");
		LogInfo($"PersonValArray: {this._personValArray.Length}");
	}

	[Benchmark(Description = nameof(ArrayExtensions.ToDistinct) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ToDistinctRef()
	{
		this.Consume(this._personRefArrayWithDups.ToDistinct());
	}

	[Benchmark(Description = nameof(ArrayExtensions.ToFrozenSet) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ToFrozenSetRef()
	{
		this.Consume(this._personRefArray.ToFrozenSet());
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

}
