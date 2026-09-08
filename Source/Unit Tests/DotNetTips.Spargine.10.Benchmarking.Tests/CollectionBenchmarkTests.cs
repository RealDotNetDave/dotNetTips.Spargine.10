// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking.Tests
// Author           : Copilot Agent
// Created          : 09-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-08-2026
// ***********************************************************************
// <copyright file="CollectionBenchmarkTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for the CollectionBenchmark public API, including the Coordinate and Person partial classes.
// </summary>
// ***********************************************************************
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using RefCoordinate = DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate;
using ValueCoordinate = DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate;
using ValuePerson = DotNetTips.Spargine.Tester.Models.ValueTypes.Person;

namespace DotNetTips.Spargine.Benchmarking.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public sealed class CollectionBenchmarkTests
{
	private const int MaxCount = 10;

	[TestMethod]
	public void ClearCollectionCachesEmptiesCoordinateCollections()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearCollectionCaches();

		Assert.AreEqual((0, 0), (benchmark.GetCoordinateRefArray().Length, benchmark.GetCoordinateValArray().Length));
	}

	[TestMethod]
	public void ClearCollectionCachesEmptiesPersonCollections()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearCollectionCaches();

		Assert.AreEqual((0, 0, 0), (benchmark.GetPersonRecordArray().Length, benchmark.GetPersonRefArray().Length, benchmark.GetPersonValArray().Length));
	}

	[TestMethod]
	public void ClearCollectionCachesResetsStringLookupValues()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearCollectionCaches();

		Assert.AreEqual((string.Empty, string.Empty, string.Empty), (benchmark.PersonEmailHalf, benchmark.PersonFirstNameHalf, benchmark.PersonLastNameHalf));
	}

	[TestMethod]
	public void ClearPersonCachesEmptiesPersonCollections()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearPersonCaches();

		Assert.AreEqual((0, 0, 0), (benchmark.GetPersonRecordArray().Length, benchmark.GetPersonRefArray().Length, benchmark.GetPersonValArray().Length));
	}

	[TestMethod]
	public void ClearPersonCachesLeavesCoordinateCollectionsLoaded()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearPersonCaches();

		Assert.AreEqual(MaxCount, benchmark.GetCoordinateValArray().Length);
	}

	[TestMethod]
	public void ConstructorNonpositiveCountUsesMinimumCount()
	{
		Assert.AreEqual(2, new TestCollectionBenchmark(0).MaxCount);
	}

	[TestMethod]
	public void CopyCoordinateRefToCopiesAllItems()
	{
		var benchmark = CreateBenchmark();
		var destination = new RefCoordinate[MaxCount];
		benchmark.CopyCoordinateRefTo(destination);

		Assert.IsTrue(destination.SequenceEqual(benchmark.GetCoordinateRefArray()));
	}

	[TestMethod]
	public void CopyCoordinateRefToSmallDestinationThrowsArgumentException()
	{
		var benchmark = CreateBenchmark();

		_ = Assert.ThrowsExactly<ArgumentException>(() => benchmark.CopyCoordinateRefTo(new RefCoordinate[MaxCount - 1]));
	}

	[TestMethod]
	public void CopyCoordinateValToCopiesAllItems()
	{
		var benchmark = CreateBenchmark();
		var destination = new ValueCoordinate[MaxCount];
		benchmark.CopyCoordinateValTo(destination);

		Assert.IsTrue(destination.SequenceEqual(benchmark.GetCoordinateValArray()));
	}

	[TestMethod]
	public void CopyCoordinateValToSmallDestinationThrowsArgumentException()
	{
		var benchmark = CreateBenchmark();

		_ = Assert.ThrowsExactly<ArgumentException>(() => benchmark.CopyCoordinateValTo(new ValueCoordinate[MaxCount - 1]));
	}

	[TestMethod]
	public void GetCoordinateRefArrayReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetCoordinateRefArray().Length);
	}

	[TestMethod]
	public void GetCoordinateRefArrayReturnsNewInstanceEachCall()
	{
		var benchmark = CreateBenchmark();

		Assert.AreNotSame(benchmark.GetCoordinateRefArray(), benchmark.GetCoordinateRefArray());
	}

	[TestMethod]
	public void GetCoordinateRefCollectionReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetCoordinateRefCollection().Count);
	}

	[TestMethod]
	public void GetCoordinateRefReadOnlySpanReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetCoordinateRefReadOnlySpan().Length);
	}

	[TestMethod]
	public void GetCoordinateValArrayReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetCoordinateValArray().Length);
	}

	[TestMethod]
	public void GetCoordinateValArrayReturnsNewInstanceEachCall()
	{
		var benchmark = CreateBenchmark();

		Assert.AreNotSame(benchmark.GetCoordinateValArray(), benchmark.GetCoordinateValArray());
	}

	[TestMethod]
	public void GetCoordinateValCollectionReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetCoordinateValCollection().Count);
	}

	[TestMethod]
	public void GetCoordinateValReadOnlySpanReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetCoordinateValReadOnlySpan().Length);
	}

	[TestMethod]
	public void GetPersonRecordArrayReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetPersonRecordArray().Length);
	}

	[TestMethod]
	public void GetPersonRecordArrayReturnsNewInstanceEachCall()
	{
		var benchmark = CreateBenchmark();

		Assert.AreNotSame(benchmark.GetPersonRecordArray(), benchmark.GetPersonRecordArray());
	}

	[TestMethod]
	public void GetPersonRecordCollectionToInsertReturnsHalfCountItems()
	{
		var benchmark = CreateBenchmark();

		Assert.AreEqual(benchmark.HalfCount, benchmark.ExposeGetPersonRecordCollectionToInsert().Length);
	}

	[TestMethod]
	public void GetPersonRecordDictionaryContainsLastLookupId()
	{
		var benchmark = CreateBenchmark();

		Assert.IsTrue(benchmark.GetPersonRecordDictionary().ContainsKey(benchmark.PersonRecordLookupLast.Id));
	}

	[TestMethod]
	public void GetPersonRecordReadOnlySpanReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetPersonRecordReadOnlySpan().Length);
	}

	[TestMethod]
	public void GetPersonRefArrayReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetPersonRefArray().Length);
	}

	[TestMethod]
	public void GetPersonRefCollectionToInsertReturnsHalfCountItems()
	{
		var benchmark = CreateBenchmark();

		Assert.AreEqual(benchmark.HalfCount, benchmark.ExposeGetPersonRefCollectionToInsert().Length);
	}

	[TestMethod]
	public void GetPersonRefDictionaryContainsLastLookupId()
	{
		var benchmark = CreateBenchmark();

		Assert.IsTrue(benchmark.GetPersonRefDictionary().ContainsKey(benchmark.PersonRefLookupLast.Id));
	}

	[TestMethod]
	public void GetPersonRefReadOnlySpanReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetPersonRefReadOnlySpan().Length);
	}

	[TestMethod]
	public void GetPersonValArrayReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetPersonValArray().Length);
	}

	[TestMethod]
	public void GetPersonValCollectionToInsertReturnsHalfCountItems()
	{
		var benchmark = CreateBenchmark();

		Assert.AreEqual(benchmark.HalfCount, benchmark.ExposeGetPersonValCollectionToInsert().Length);
	}

	[TestMethod]
	public void GetPersonValDictionaryContainsLastLookupId()
	{
		var benchmark = CreateBenchmark();

		Assert.IsTrue(benchmark.GetPersonValDictionary().ContainsKey(benchmark.PersonValLookupLast.Id));
	}

	[TestMethod]
	public void GetPersonValReadOnlySpanReturnsMaxCountItems()
	{
		Assert.AreEqual(MaxCount, CreateBenchmark().GetPersonValReadOnlySpan().Length);
	}

	[TestMethod]
	public void HalfCountIsHalfOfMaxCountAfterSetup()
	{
		Assert.AreEqual(MaxCount / 2, CreateBenchmark().HalfCount);
	}

	[TestMethod]
	public void MaxCountMatchesConstructorValue()
	{
		Assert.AreEqual(MaxCount, new TestCollectionBenchmark(MaxCount).MaxCount);
	}

	[TestMethod]
	public void ReloadCollectionsRefreshesLastPersonLookupValue()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearCollectionCaches();
		benchmark.ReloadCollections();

		Assert.AreEqual(benchmark.GetPersonRefArray()[^1].Email, benchmark.PersonEmailLast);
	}

	[TestMethod]
	public void ReloadCollectionsRepopulatesCoordinateCollections()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearCollectionCaches();
		benchmark.ReloadCollections();

		Assert.AreEqual((MaxCount, MaxCount), (benchmark.GetCoordinateRefArray().Length, benchmark.GetCoordinateValArray().Length));
	}

	[TestMethod]
	public void ReloadCollectionsRepopulatesPersonCollections()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearPersonCaches();
		benchmark.ReloadCollections();

		Assert.AreEqual((MaxCount, MaxCount, MaxCount), (benchmark.GetPersonRecordArray().Length, benchmark.GetPersonRefArray().Length, benchmark.GetPersonValArray().Length));
	}

	[TestMethod]
	public void SetupLoadsHalfPersonEmailLookupValue()
	{
		var benchmark = CreateBenchmark();

		Assert.AreEqual(benchmark.GetPersonRefArray()[benchmark.HalfCount].Email, benchmark.PersonEmailHalf);
	}

	[TestMethod]
	public void SetupLoadsLastPersonNameLookupValues()
	{
		var benchmark = CreateBenchmark();
		var last = benchmark.GetPersonRefArray()[^1];

		Assert.AreEqual((last.FirstName, last.LastName), (benchmark.PersonFirstNameLast, benchmark.PersonLastNameLast));
	}

	[TestMethod]
	public void TryFindPersonRefByIdExistingIdReturnsTrue()
	{
		var benchmark = CreateBenchmark();
		var found = benchmark.TryFindPersonRefById(benchmark.PersonRefLookupLast.Id, out var person);

		Assert.AreEqual((true, benchmark.PersonRefLookupLast.Id), (found, person.Id));
	}

	[TestMethod]
	public void TryFindPersonRefByIdMissingIdReturnsFalse()
	{
		var benchmark = CreateBenchmark();

		Assert.IsFalse(benchmark.TryFindPersonRefById(Guid.NewGuid().ToString(), out _));
	}

	[TestMethod]
	public void TryFindPersonRefByIdNullIdReturnsFalse()
	{
		var benchmark = CreateBenchmark();

		Assert.IsFalse(benchmark.TryFindPersonRefById(null!, out _));
	}

	private static TestCollectionBenchmark CreateBenchmark()
	{
		var benchmark = new TestCollectionBenchmark(MaxCount);
		benchmark.Setup();

		return benchmark;
	}

	private sealed class TestCollectionBenchmark(int maxCount) : CollectionBenchmark(maxCount)
	{
		public PersonRecord[] ExposeGetPersonRecordCollectionToInsert() => this.GetPersonRecordCollectionToInsert();

		public Person[] ExposeGetPersonRefCollectionToInsert() => this.GetPersonRefCollectionToInsert();

		public ValuePerson[] ExposeGetPersonValCollectionToInsert() => this.GetPersonValCollectionToInsert();
	}
}
