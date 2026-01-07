// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2026
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
	private byte[] _byteArray;
	private int _halfCount;

	private PersonRecord[] _personRecordArray;
	private Person[] _personRefArray;
	private Person[] _personRefArrayHalf;
	private Spargine.Tester.Models.ValueTypes.Person[] _personValArray;
	private Spargine.Tester.Models.ValueTypes.Person[] _personValArrayHalf;

	[Benchmark(Description = nameof(ArrayExtensions.AddFirst) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AddFirst_Ref()
	{
		var people = this._personRefArray;

		var result = people.AddFirst(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddLast) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AddLast_Ref()
	{
		var people = this._personRefArray;

		var result = people.AddLast(this.PersonRef02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void AreEqual_Ref()
	{
		var people1 = this._personRefArray;
		var people2 = this._personRefArrayHalf;

		var result = people1.AreEqual(people2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void AreEqual_Val()
	{
		var people1 = this._personValArray;
		var people2 = this._personValArrayHalf;

		var result = people1.AreEqual(people2);

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
		var result = this._personRefArray;

		this.Consume(result.GetHashCode());
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

	[Benchmark(Description = nameof(ArrayExtensions.IsEmpty) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void DoesNotHaveItems_Ref()
	{
		var result = this._personRefArray.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsEmpty) + ": as Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void DoesNotHaveItems_Val()
	{
		var result = this._personValArray.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.GenerateHashCode) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void GenerateHashCode_Ref()
	{
		var people = this._personRefArray;

		var result = people.GenerateHashCode();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastHashData) + ": byte[]")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HashDataFastHashData()
	{
		var byteArray = this._byteArray;
		var result = byteArray.FastHashData();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": as Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void HasItems_Ref()
	{
		var people = this._personRefArray;
		var result = people.IsNotEmpty();

		this.Consume(result);
	}


	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HasItems_Val()
	{
		var people = this._personValArray;
		var result = people.IsNotEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": With Count - Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void HasItemsWithCount_Ref()
	{
		var people = this._personRefArray;
		var result = people.IsNotEmpty(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": With Count - Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HasItemsWithCount_Val()
	{
		var people = this._personValArray;
		var result = people.IsNotEmpty(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": With Predicate - Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void HasItemsWithPredicate_Ref()
	{
		var people = this._personRefArray;
		var result = people.IsNotEmpty(p => p.LastName.IsNotEmpty());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.IsNotEmpty) + ": With Predicate - Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void HasItemsWithPredicate_Val()
	{
		var people = this._personValArray;
		var result = people.IsNotEmpty(p => p.LastName.IsNotEmpty());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.IndexOf) + ": Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void IndexOfRefReference()
	{
		var people = this._personRefArray;
		var result = people.IndexOf(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.IndexOf) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void IndexOfRefValue()
	{
		var people = this._personValArray;
		var result = people.IndexOf(this.PersonVal01);

		this.Consume(result);
	}


	[Benchmark(Description = nameof(ArrayExtensions.LastIndexOf) + ": Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void LastIndexOfRefReference()
	{
		var people = this._personRefArray;
		var result = people.LastIndexOf(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.LastIndexOf) + ": Value")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType)]
	public void LastIndexOfValValue()
	{
		var people = this._personValArray;
		var result = people.LastIndexOf(this.PersonVal01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " : Record (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.RecordType, Categories.ForComparison)]
	public void PerformAction_Record_Comparison()
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
	public void PerformAction_Ref()
	{
		var people = this._personRefArray;
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append(CultureInfo.CurrentCulture, $"{person.GetHashCode()}-"));

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Ref (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType, Categories.ForComparison)]
	public void PerformAction_Ref_Comparison()
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
	public void PerformAction_Val()
	{
		var people = this._personValArray;
		var sb = new StringBuilder();

		people.PerformAction((person) => _ = sb.Append(CultureInfo.CurrentCulture, $"{person.GetHashCode()}-"));

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Val (Comparison)")]
	[BenchmarkCategory(Categories.Array, Categories.ValueType, Categories.ForComparison)]
	public void PerformAction_Val_Comparison()
	{
		var people = this._personValArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].GetHashCode()}-");
		}

		this.Consume(sb.ToString());
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
	public void RemoveFirst_Ref()
	{
		var people = this._personRefArray;

		var result = people.RemoveFirst();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveLast) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void RemoveLast_Ref()
	{
		var people = this._personRefArray;

		var result = people.RemoveLast();

		this.Consume(result);
	}

	[Benchmark(Description = "Select Items: ArraySegment")]
	[BenchmarkCategory(Categories.Collections, Categories.ForComparison)]
	public void SelectItemsArraySegment()
	{
		var result = new ArraySegment<Person>(this._personRefArray, 0, this._halfCount).ToArray();

		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastSelectItems))]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void SelectItemsFastSelectItems()
	{
		var result = this._personRefArray.FastSelectItems(0, this._halfCount);

		this.Consume(result.Length);
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

		this._halfCount = this._personRefArray.Length / 2;

		LogInfo($"PersonRecordArray: {this._personRecordArray.Length}");
		LogInfo($"PersonRefArray: {this._personRefArray.Length}");
		LogInfo($"PersonValArray: {this._personValArray.Length}");
	}

	[Benchmark(Description = nameof(ArrayExtensions.ToDistinct) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ToDistinct_Ref()
	{
		var result = this._personRefArray.ToDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ToFrozenSet) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void ToFrozenSet_Ref()
	{
		var result = this._personRefArray.ToFrozenSet();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + " : Reference")]
	[BenchmarkCategory(Categories.Array, Categories.ReferenceType)]
	public void Upsert_Ref()
	{
		var people = this._personRefArray;

		var result = people.Upsert(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + ": Record")]
	[BenchmarkCategory(Categories.Array, Categories.RecordType)]
	public void UpsertRecord_Record()
	{
		var people = this._personRecordArray;

		var result = people.Upsert(this.PersonRecord01);

		this.Consume(result);
	}

}
