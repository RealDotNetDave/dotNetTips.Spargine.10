// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 08-02-2022
//
// Last Modified By : David McCarter
// Last Modified On : 11-10-2025
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

/// <summary>
/// Class RandomDataCollectionsBenchmark.
/// </summary>
public class RandomDataCollectionsBenchmark : LargeCollectionBenchmark
{
	private Collection<Models.ValueTypes.Coordinate> _coordinateCollection;
	private Collection<PersonRecord> _personRecordCollection;
	private Collection<Person> _personRefCollection;
	private readonly Country DefaultCountry = CountryRepository.GetCountry(CountryName.UnitedStates);

	[Benchmark(Description = nameof(RandomData.GenerateAddressCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateAddressCollectionRef()
	{
		var result = RandomData.GenerateAddressCollection<Address>(this.DefaultCountry);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateAddressCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateAddressRecordCollection()
	{
		var result = RandomData.GenerateAddressCollection<AddressRecord>(this.DefaultCountry, this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCoordinateCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCoordinateCollection()
	{
		var result = RandomData.GenerateCoordinateCollection<Coordinate>(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GenerateCreditCards))]
	[BenchmarkCategory(Categories.New)]
	public void GenerateCreditCards()
	{
		var result = RandomData.GenerateCreditCards(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonNames))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonNames()
	{
		var result = RandomData.GeneratePersonNames(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRecordCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonRecordCollection()
	{
		var result = RandomData.GeneratePersonRecordCollection(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonRefCollection) + ": Person")]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonRefCollection()
	{
		var result = RandomData.GeneratePersonRefCollection(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(RandomData.GeneratePersonValCollection))]
	[BenchmarkCategory(Categories.New)]
	public void GeneratePersonValCollection()
	{
		var result = RandomData.GeneratePersonValCollection(this.Count);

		this.Consume(result.Count);
	}

	[Benchmark(Description = "Person" + ":OrderBy()")]
	[BenchmarkCategory(Categories.New)]
	public void PersonOrderByBenchmark()
	{
		var result = this._personRefCollection.OrderBy(p => p.LastName);

		this.Consume(result.Count());
	}


	[Benchmark(Description = nameof(Coordinate) + ":OrderBy()")]
	[BenchmarkCategory(Categories.New, Categories.RecordType)]
	public void PersonRecordOrderByBenchmark()
	{
		var result = this._personRecordCollection.OrderBy(p => p.LastName);

		this.Consume(result.Count());
	}

	[Benchmark(Description = nameof(PersonRecord) + ":OrderBy()")]
	[BenchmarkCategory(Categories.New)]
	public void PersonValOrderByBenchmark()
	{
		var result = this._personRecordCollection.OrderBy(p => p.LastName);

		this.Consume(result.Count());
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
