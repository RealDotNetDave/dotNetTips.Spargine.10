// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 08-02-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-25-2026
// ***********************************************************************
// <copyright file="RandomDataCollectionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Data;
using DotNetTips.Spargine.Tester.Data.Models;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

/// <summary>
/// Class RandomDataCollectionsBenchmark.
/// </summary>
public class RandomDataCollectionsBenchmark : LargeCollectionBenchmark
{
	private readonly Country DefaultCountry = CountryRepository.GetCountry(CountryName.UnitedStates);
	private Collection<Models.ValueTypes.Coordinate> _coordinateCollection;
	private Collection<PersonRecord> _personRecordCollection;
	private Collection<Person> _personRefCollection;

	[Benchmark(Description = nameof(RandomData.GenerateAddressCollection))]
	public void GenerateAddressCollectionRef()
	{
		var result = RandomData.GenerateAddressCollection<Address>(this.DefaultCountry);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateAddressCollection))]
	public void GenerateAddressRecordCollection()
	{
		var result = RandomData.GenerateAddressCollection<AddressRecord>(this.DefaultCountry, this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateByteArray))]
	public void GenerateByteArray()
	{
		var result = RandomData.GenerateByteArray(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCoordinateCollection))]
	public void GenerateCoordinateCollection()
	{
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCreditCards))]
	public void GenerateCreditCards()
	{
		var result = RandomData.GenerateCreditCards(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateNonZeroByteArray))]
	public void GenerateNonZeroByteArray()
	{
		var result = RandomData.GenerateNonZeroByteArray(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateNumber))]
	public void GenerateNumber()
	{
		var result = RandomData.GenerateNumber(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonNames))]
	public void GeneratePersonNames()
	{
		var result = RandomData.GeneratePersonNames(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePerson) + ": Record")]
	public void GeneratePersonRecord()
	{
		var result = RandomData.GeneratePerson<PersonRecord>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRecordCollection))]
	public void GeneratePersonRecordCollection()
	{
		var result = RandomData.GeneratePersonRecordCollection(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRefCollection) + ": Person")]
	public void GeneratePersonRefCollection()
	{
		var result = RandomData.GeneratePersonRefCollection(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonValCollection))]
	public void GeneratePersonValCollection()
	{
		var result = RandomData.GeneratePersonValCollection(this.Count);

		this.Consume(result.Count);
	}

	[Benchmark(Description = nameof(RandomData.GenerateTempFile))]
	[BenchmarkCategory(Categories.IO)]
	public void GenerateTempFile()
	{
		var fileName = RandomData.GenerateTempFile(this.Count);

		this.Consume(fileName);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWord))]
	public void GenerateWord()
	{
		var result = RandomData.GenerateWord(this.Count);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWord) + ": MIN AND MAX CHAR")]
	public void GenerateWordMinMaxChar()
	{
		var result = RandomData.GenerateWord(this.Count, char.MinValue, char.MaxValue);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWord) + ": MIN AND MAX LENGTH")]
	public void GenerateWordMinMaxLength()
	{
		var result = RandomData.GenerateWord(this.Count, 100);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWord) + ": MIN AND MAX LENGTH + CHAR")]
	public void GenerateWordMinMaxLengthChar()
	{
		var result = RandomData.GenerateWord(this.Count, 100, char.MinValue, char.MaxValue);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateWords))]
	public void GenerateWords()
	{
		var result = RandomData.GenerateWords(this.Count, 5, 10);

		this.Consume(result);
	}

	[Benchmark(Description = "OrderBy(): Ref")]
	public void PersonOrderByBenchmark()
	{
		var result = this._personRefCollection.OrderBy(p => p.LastName);

		this.Consume(result.Last());
	}

	[Benchmark(Description = "OrderBy(): Record")]
	[BenchmarkCategory(Categories.RecordType)]
	public void PersonRecordOrderBy()
	{
		var result = this._personRecordCollection.OrderBy(p => p.LastName);

		this.Consume(result.Last());
	}

	[Benchmark(Description = "OrderBy(): Val")]
	[BenchmarkCategory(Categories.ValueType)]
	public void PersonValOrderBy()
	{
		var result = this._personRecordCollection.OrderBy(p => p.LastName);

		this.Consume(result.Last());
	}

	public override void Setup()
	{
		base.Setup();

		this._coordinateCollection = this.GetCoordinateValArray().ToCollection();
		this._personRecordCollection = this.GetPersonRecordArray().ToCollection();
		this._personRefCollection = this.GetPersonRefArray().ToCollection();

		LogInfo($"PersonRefCollection: {this._personRefCollection.Count}");
		LogInfo($"PersonRecordCollection: {this._personRecordCollection.Count}");
		LogInfo($"FIRST PERSON: {this._personRefCollection.First().Email}");
		LogInfo($"LAST PERSON: {this._personRefCollection.Last().Email}");
	}

}
