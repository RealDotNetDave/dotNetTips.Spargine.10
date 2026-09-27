// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 09-27-2026
// ***********************************************************************
// <copyright file="CollectionBenchmark.Person.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Partial class of CollectionBenchmark that provides preloaded Person
// collections, including PersonRecord, Person reference types, and
// Person value types in arrays, lists, and dictionaries.
// </summary>
// ***********************************************************************

using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts;
using DotNetTips.Spargine.Tester.Models.ValueTypes.SerializerContexts;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Partial class for Collections benchmark that includes functionality for preloading Person collections.
/// This includes PersonRecord, Person reference types, and Person value types in various collection types like arrays, lists, and dictionaries.
/// </summary>
public partial class CollectionBenchmark
{
	/// <summary>
	/// The maximum number of people data that can be loaded from resources.
	/// </summary>
	private const int MaxPeopleDataCount = 10_000;

	/// <summary>
	/// The person record list.
	/// </summary>
	private List<PersonRecord> _personRecordList;

	/// <summary>
	/// The person reference array.
	/// </summary>
	private List<Person> _personRefList;

	/// <summary>
	/// The person value array.
	/// </summary>
	private List<Tester.Models.ValueTypes.Person> _personValList;

	/// <summary>
	/// Clears the in-memory person collection caches and replaces them with empty lists.
	/// Useful for tests that need to reset state between runs.
	/// </summary>
	[Information(nameof(ClearPersonCaches), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void ClearPersonCaches()
	{
		this._personRefList = new List<Person>();
		this._personValList = new List<Tester.Models.ValueTypes.Person>();
		this._personRecordList = new List<PersonRecord>();
	}

	/// <summary>
	/// Gets a clone of the PersonRecord array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the PersonRecord array.</returns>
	[Information(nameof(GetPersonRecordArray), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public PersonRecord[] GetPersonRecordArray()
	{
		var cloned = this._personRecordList.FastClone(typeInfo: PersonRecordJsonSerializerContext.Default.PersonList);
		return CollectionsMarshal.AsSpan(cloned).ToArray();
	}

	/// <summary>
	/// Gets a cloned dictionary for PersonRecord.
	/// </summary>
	/// <returns>A dictionary of PersonRecord indexed by string.</returns>
	[Information(nameof(GetPersonRecordDictionary), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Dictionary<string, PersonRecord> GetPersonRecordDictionary()
	{
		var cloned = this._personRecordList.FastClone(typeInfo: PersonRecordJsonSerializerContext.Default.PersonList);
		var dictionary = new Dictionary<string, PersonRecord>(cloned.Count, StringComparer.OrdinalIgnoreCase);

		foreach (var person in CollectionsMarshal.AsSpan(cloned))
		{
			dictionary[person.Id] = person;
		}

		return dictionary;
	}

	/// <summary>
	/// Returns a read-only span over the internal PersonRecord list.
	/// This is allocation-free and intended for high-performance read-only access.
	/// The caller MUST NOT mutate the underlying list.
	/// </summary>
	[Information(nameof(GetPersonRecordReadOnlySpan), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public ReadOnlySpan<PersonRecord> GetPersonRecordReadOnlySpan()
	{
		return CollectionsMarshal.AsSpan(this._personRecordList);
	}

	/// <summary>
	/// Gets clone of Person reference array.
	/// </summary>
	/// <returns>An array of Person reference types.</returns>
	[Information(nameof(GetPersonRefArray), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Person[] GetPersonRefArray()
	{
		var cloned = this._personRefList.FastClone(typeInfo: PersonRefJsonSerializerContext.Default.PersonList);
		return CollectionsMarshal.AsSpan(cloned).ToArray();
	}

	/// <summary>
	/// Gets clone of Person reference types as a dictionary.
	/// </summary>
	/// <returns>A dictionary of Person reference types indexed by string.</returns>
	[Information(nameof(GetPersonRefDictionary), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Dictionary<string, Person> GetPersonRefDictionary()
	{
		var cloned = this._personRefList.FastClone(typeInfo: PersonRefJsonSerializerContext.Default.PersonList);
		var dictionary = new Dictionary<string, Person>(cloned.Count, StringComparer.OrdinalIgnoreCase);

		foreach (var person in CollectionsMarshal.AsSpan(cloned))
		{
			dictionary[person.Id] = person;
		}

		return dictionary;
	}

	/// <summary>
	/// Returns a read-only span over the internal Person reference-type list.
	/// This is allocation-free and intended for high-performance read-only access.
	/// The caller MUST NOT mutate the underlying list.
	/// </summary>
	[Information(nameof(GetPersonRefReadOnlySpan), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public ReadOnlySpan<Person> GetPersonRefReadOnlySpan()
	{
		return CollectionsMarshal.AsSpan(this._personRefList);
	}

	/// <summary>
	/// Gets clone of Person value types as an array.
	/// </summary>
	/// <returns>An array of Person value types.</returns>
	[Information(nameof(GetPersonValArray), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Tester.Models.ValueTypes.Person[] GetPersonValArray()
	{
		var cloned = this._personValList.FastClone(typeInfo: PersonValJsonSerializerContext.Default.PersonList);
		return CollectionsMarshal.AsSpan(cloned).ToArray();
	}

	/// <summary>
	/// Gets clone of person value dictionary.
	/// </summary>
	[Information(nameof(GetPersonValDictionary), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public Dictionary<string, Tester.Models.ValueTypes.Person> GetPersonValDictionary()
	{
		var cloned = this._personValList.FastClone(typeInfo: PersonValJsonSerializerContext.Default.PersonList);
		var dictionary = new Dictionary<string, Tester.Models.ValueTypes.Person>(cloned.Count, StringComparer.OrdinalIgnoreCase);

		foreach (var person in CollectionsMarshal.AsSpan(cloned))
		{
			dictionary[person.Id] = person;
		}

		return dictionary;
	}

	/// <summary>
	/// Returns a read-only span over the internal Person value-type list.
	/// This is allocation-free and intended for high-performance read-only access.
	/// The caller MUST NOT mutate the underlying list.
	/// </summary>
	[Information(nameof(GetPersonValReadOnlySpan), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public ReadOnlySpan<Tester.Models.ValueTypes.Person> GetPersonValReadOnlySpan()
	{
		return CollectionsMarshal.AsSpan(this._personValList);
	}

	/// <summary>
	/// Attempts to find a Person reference with the specified id in the internal list.
	/// This is a convenience O(n) lookup. For large collections prefer building a dictionary via GetPersonRefDictionary().
	/// </summary>
	[Information(nameof(TryFindPersonRefById), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public bool TryFindPersonRefById(string id, out Person person)
	{
		person = null!;
		if (string.IsNullOrWhiteSpace(id))
		{
			return false;
		}

		foreach (var p in this._personRefList)
		{
			if (string.Equals(p.Id, id, StringComparison.OrdinalIgnoreCase))
			{
				person = p;
				return true;
			}
		}

		return false;
	}

	/// <summary>
	/// Loads the person collections into memory, including arrays, lists, and dictionaries for PersonRecord, Person reference types, and Person value types.
	/// </summary>
	[Information(nameof(LoadPersonCollections), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	protected void LoadPersonCollections()

	{
		this._personRefList = LoadPeopleRefCollection(this.MaxCount);
		this._personValList = LoadPeopleValCollection(this.MaxCount);
		this._personRecordList = LoadPeopleRecordCollection(this.MaxCount);
	}

}
