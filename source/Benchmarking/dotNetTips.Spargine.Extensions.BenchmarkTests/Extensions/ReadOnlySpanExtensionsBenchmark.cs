// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 01-12-2026
// ***********************************************************************
// <copyright file="ReadOnlySpanExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class ReadOnlySpanExtensionsBenchmark : LargeCollectionBenchmark
{
	private byte[] _bytes;
	private PersonRecord[] _peopleRecordArray;
	private Spargine.Tester.Models.ValueTypes.Person[] _peopleValArray;
	private Person[] _personRefArray;

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.BytesToString))]
	public void BytesToString()
	{
		var collection = this._bytes.AsReadOnlySpan();

		var result = collection.BytesToString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.PickRandom) + ": record")]
	public void PickRandomRecord()
	{
		var collection = new ReadOnlySpan<PersonRecord>(this._peopleRecordArray);

		var result = collection.PickRandom();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.PickRandom) + ": ref")]
	public void PickRandomRef()
	{
		var collection = new ReadOnlySpan<Person>(this._personRefArray);

		var result = collection.PickRandom();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ReadOnlySpanExtensions.PickRandom) + ": val")]
	public void PickRandomVal()
	{
		var collection = new ReadOnlySpan<Spargine.Tester.Models.ValueTypes.Person>(this._peopleValArray);

		var result = collection.PickRandom();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._bytes = this.GetByteArray();
		this._personRefArray = this.GetPersonRefArray();
		this._peopleRecordArray = this.GetPersonRecordArray();
		this._peopleValArray = this.GetPersonValArray();
	}

}
