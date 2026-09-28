// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking.Tests
// Author           : Copilot Agent
// Created          : 09-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-28-2026
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
	public void GetCoordinateRefCollectionContainsLoadedCoordinates()
	{
		var benchmark = CreateBenchmark();
		Assert.AreSame(benchmark.GetCoordinateRefReadOnlySpan()[0], benchmark.GetCoordinateRefCollection()[0]);
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
	public void GetCoordinateValCollectionContainsLoadedCoordinates()
	{
		var benchmark = CreateBenchmark();
		Assert.AreEqual(benchmark.GetCoordinateValReadOnlySpan()[0], benchmark.GetCoordinateValCollection()[0]);
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
	public void LoadCoordinateCollectionsAfterCacheClearRestoresCoordinates()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearCollectionCaches();
		benchmark.ExposeLoadCoordinateCollections();
		Assert.AreEqual((MaxCount, MaxCount), (benchmark.GetCoordinateRefReadOnlySpan().Length, benchmark.GetCoordinateValReadOnlySpan().Length));
	}

	[TestMethod]
	public void LoadPersonCollectionsAfterCacheClearRestoresPeople()
	{
		var benchmark = CreateBenchmark();
		benchmark.ClearPersonCaches();
		benchmark.ExposeLoadPersonCollections();
		Assert.AreEqual((MaxCount, MaxCount, MaxCount), (benchmark.GetPersonRecordReadOnlySpan().Length, benchmark.GetPersonRefReadOnlySpan().Length, benchmark.GetPersonValReadOnlySpan().Length));
	}

	[TestMethod]
	public void LoadPersonCollectionsAboveEmbeddedLimitGeneratesRemainder()
	{
		const int count = 10_001;
		var benchmark = new TestCollectionBenchmark(count);
		benchmark.ExposeLoadPersonCollections();
		Assert.AreEqual((count, count, count), (benchmark.GetPersonRecordReadOnlySpan().Length, benchmark.GetPersonRefReadOnlySpan().Length, benchmark.GetPersonValReadOnlySpan().Length));
	}

	[TestMethod]
	public void LoadPersonCollectionsAboveEmbeddedLimitPreservesFirstResourceRecord()
	{
		var resourceBenchmark = new TestCollectionBenchmark(10);
		resourceBenchmark.ExposeLoadPersonCollections();
		var benchmark = new TestCollectionBenchmark(10_001);
		benchmark.ExposeLoadPersonCollections();
		var expected = resourceBenchmark.GetPersonRecordReadOnlySpan()[0];
		var actual = benchmark.GetPersonRecordReadOnlySpan()[0];

		Assert.AreEqual((expected.Id, expected.Email, expected.FirstName, expected.LastName),
			(actual.Id, actual.Email, actual.FirstName, actual.LastName));
	}

	[TestMethod]
	public void LoadPersonCollectionsAboveEmbeddedLimitPreservesFirstResourceRefPerson()
	{
		var resourceBenchmark = new TestCollectionBenchmark(10);
		resourceBenchmark.ExposeLoadPersonCollections();
		var benchmark = new TestCollectionBenchmark(10_001);
		benchmark.ExposeLoadPersonCollections();
		var expected = resourceBenchmark.GetPersonRefReadOnlySpan()[0];
		var actual = benchmark.GetPersonRefReadOnlySpan()[0];

		Assert.AreEqual((expected.Id, expected.Email, expected.FirstName, expected.LastName),
			(actual.Id, actual.Email, actual.FirstName, actual.LastName));
	}

	[TestMethod]
	public void LoadPersonCollectionsAboveEmbeddedLimitPreservesFirstResourceValPerson()
	{
		var resourceBenchmark = new TestCollectionBenchmark(10);
		resourceBenchmark.ExposeLoadPersonCollections();
		var benchmark = new TestCollectionBenchmark(10_001);
		benchmark.ExposeLoadPersonCollections();
		var expected = resourceBenchmark.GetPersonValReadOnlySpan()[0];
		var actual = benchmark.GetPersonValReadOnlySpan()[0];

		Assert.AreEqual((expected.Id, expected.Email, expected.FirstName, expected.LastName),
			(actual.Id, actual.Email, actual.FirstName, actual.LastName));
	}

	[TestMethod]
	public void LoadPersonCollectionsAboveEmbeddedLimitGeneratesRecordWithId()
	{
		var benchmark = new TestCollectionBenchmark(10_001);
		benchmark.ExposeLoadPersonCollections();

		Assert.IsFalse(string.IsNullOrWhiteSpace(benchmark.GetPersonRecordReadOnlySpan()[^1].Id));
	}

	[TestMethod]
	public void LoadPersonCollectionsAboveEmbeddedLimitGeneratesRefPersonWithId()
	{
		var benchmark = new TestCollectionBenchmark(10_001);
		benchmark.ExposeLoadPersonCollections();

		Assert.IsFalse(string.IsNullOrWhiteSpace(benchmark.GetPersonRefReadOnlySpan()[^1].Id));
	}

	[TestMethod]
	public void LoadPersonCollectionsAboveEmbeddedLimitGeneratesValPersonWithId()
	{
		var benchmark = new TestCollectionBenchmark(10_001);
		benchmark.ExposeLoadPersonCollections();

		Assert.IsFalse(string.IsNullOrWhiteSpace(benchmark.GetPersonValReadOnlySpan()[^1].Id));
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

	[TestMethod]
	public void GetPersonRecordArrayClonesElementsAndPreservesContent()
	{
		var benchmark = CreateBenchmark();
		var source = benchmark.GetPersonRecordReadOnlySpan()[0];
		var copy = benchmark.GetPersonRecordArray()[0];

		Assert.AreEqual((source.Id, source.Email, false), (copy.Id, copy.Email, ReferenceEquals(source, copy)));
	}

	[TestMethod]
	public void GetPersonRefArrayClonesElementsAndIsolatesChanges()
	{
		var benchmark = CreateBenchmark();
		var source = benchmark.GetPersonRefReadOnlySpan()[0];
		var copy = benchmark.GetPersonRefArray();
		var cloned = copy[0];
		copy[0] = copy[1];

		Assert.AreEqual((false, source.Id, source.Email), (ReferenceEquals(source, cloned), benchmark.GetPersonRefReadOnlySpan()[0].Id, cloned.Email));
	}

	[TestMethod]
	public void GetPersonValArrayPreservesValuesAndIsolatesChanges()
	{
		var benchmark = CreateBenchmark();
		var source = benchmark.GetPersonValReadOnlySpan()[0];
		var copy = benchmark.GetPersonValArray();
		var cloned = copy[0];
		copy[0] = copy[1];

		Assert.AreEqual((source.Id, source.Email, source.Id, source.Email),
			(cloned.Id, cloned.Email, benchmark.GetPersonValReadOnlySpan()[0].Id, benchmark.GetPersonValReadOnlySpan()[0].Email));
	}

	[TestMethod]
	public void GetPersonRecordDictionaryContainsClonedItemsWithMatchingKeys()
	{
		var benchmark = CreateBenchmark();
		var source = benchmark.GetPersonRecordReadOnlySpan()[0];
		var dictionary = benchmark.GetPersonRecordDictionary();

		Assert.AreEqual((MaxCount, source.Id, source.Email, false),
			(dictionary.Count, dictionary[source.Id].Id, dictionary[source.Id].Email, ReferenceEquals(source, dictionary[source.Id])));
	}

	[TestMethod]
	public void GetPersonRefDictionaryContainsClonedItemsAndIsolatesChanges()
	{
		var benchmark = CreateBenchmark();
		var source = benchmark.GetPersonRefReadOnlySpan()[0];
		var dictionary = benchmark.GetPersonRefDictionary();
		var cloned = dictionary[source.Id];
		dictionary.Remove(source.Id);

		Assert.AreEqual((MaxCount - 1, source.Id, false, source.Email),
			(dictionary.Count, cloned.Id, ReferenceEquals(source, cloned), benchmark.GetPersonRefReadOnlySpan()[0].Email));
	}

	[TestMethod]
	public void GetPersonValDictionaryContainsMatchingKeysAndIsIndependent()
	{
		var benchmark = CreateBenchmark();
		var source = benchmark.GetPersonValReadOnlySpan()[0];
		var dictionary = benchmark.GetPersonValDictionary();
		var cloned = dictionary[source.Id];
		dictionary.Remove(source.Id);

		Assert.AreEqual((MaxCount - 1, source.Id, source.Email, source.Id),
			(dictionary.Count, cloned.Id, cloned.Email, benchmark.GetPersonValReadOnlySpan()[0].Id));
	}

	[TestMethod]
	public void GetPersonRecordReadOnlySpanReferencesLoadedItems()
	{
		var benchmark = CreateBenchmark();

		Assert.AreSame(benchmark.PersonRecordLookupHalf, benchmark.GetPersonRecordReadOnlySpan()[benchmark.HalfCount]);
	}

	[TestMethod]
	public void GetPersonRefReadOnlySpanReferencesLoadedItems()
	{
		var benchmark = CreateBenchmark();

		Assert.AreSame(benchmark.PersonRefLookupLast, benchmark.GetPersonRefReadOnlySpan()[^1]);
	}

	[TestMethod]
	public void GetPersonValReadOnlySpanReflectsLoadedLookup()
	{
		var benchmark = CreateBenchmark();

		Assert.AreEqual((benchmark.PersonValLookupHalf.Id, benchmark.PersonValLookupHalf.Email),
			(benchmark.GetPersonValReadOnlySpan()[benchmark.HalfCount].Id, benchmark.GetPersonValReadOnlySpan()[benchmark.HalfCount].Email));
	}

	[TestMethod]
	public void GetCoordinateRefArrayChangesDoNotAffectBackingSpan()
	{
		var benchmark = CreateBenchmark();
		var original = benchmark.GetCoordinateRefReadOnlySpan()[0];
		var copy = benchmark.GetCoordinateRefArray();
		copy[0] = copy[1];

		Assert.AreSame(original, benchmark.GetCoordinateRefReadOnlySpan()[0]);
	}

	[TestMethod]
	public void GetCoordinateValArrayChangesDoNotAffectBackingSpan()
	{
		var benchmark = CreateBenchmark();
		var original = benchmark.GetCoordinateValReadOnlySpan()[0];
		var copy = benchmark.GetCoordinateValArray();
		copy[0] = copy[1];

		Assert.AreEqual(original, benchmark.GetCoordinateValReadOnlySpan()[0]);
	}

	[TestMethod]
	public void GetCoordinateRefCollectionChangesDoNotAffectBackingSpan()
	{
		var benchmark = CreateBenchmark();
		var original = benchmark.GetCoordinateRefReadOnlySpan()[0];
		var collection = benchmark.GetCoordinateRefCollection();
		collection[0] = collection[1];

		Assert.AreSame(original, benchmark.GetCoordinateRefReadOnlySpan()[0]);
	}

	[TestMethod]
	public void GetCoordinateValCollectionChangesDoNotAffectBackingSpan()
	{
		var benchmark = CreateBenchmark();
		var original = benchmark.GetCoordinateValReadOnlySpan()[0];
		var collection = benchmark.GetCoordinateValCollection();
		collection[0] = collection[1];

		Assert.AreEqual(original, benchmark.GetCoordinateValReadOnlySpan()[0]);
	}

	[TestMethod]
	public void GetPersonRecordCollectionToInsertReturnsFreshArrayWithOriginalItems()
	{
		var benchmark = CreateBenchmark();
		var first = benchmark.ExposeGetPersonRecordCollectionToInsert();
		var second = benchmark.ExposeGetPersonRecordCollectionToInsert();
		first[0] = first[1];

		Assert.AreEqual((false, false, benchmark.HalfCount), (ReferenceEquals(first, second), ReferenceEquals(first[0], second[0]), second.Length));
	}

	[TestMethod]
	public void GetPersonRefCollectionToInsertReturnsFreshArrayWithOriginalItems()
	{
		var benchmark = CreateBenchmark();
		var first = benchmark.ExposeGetPersonRefCollectionToInsert();
		var second = benchmark.ExposeGetPersonRefCollectionToInsert();
		first[0] = first[1];

		Assert.AreEqual((false, false, benchmark.HalfCount), (ReferenceEquals(first, second), ReferenceEquals(first[0], second[0]), second.Length));
	}

	[TestMethod]
	public void GetPersonValCollectionToInsertReturnsFreshArrayWithOriginalItems()
	{
		var benchmark = CreateBenchmark();
		var first = benchmark.ExposeGetPersonValCollectionToInsert();
		var second = benchmark.ExposeGetPersonValCollectionToInsert();
		var original = second[0];
		first[0] = first[1];

		Assert.AreEqual((false, original.Id, benchmark.HalfCount), (ReferenceEquals(first, second), second[0].Id, second.Length));
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

		public void ExposeLoadCoordinateCollections() => this.LoadCoordinateCollections();

		public void ExposeLoadPersonCollections() => this.LoadPersonCollections();
	}
}
