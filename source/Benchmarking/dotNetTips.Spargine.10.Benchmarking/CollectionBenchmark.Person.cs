// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 08-21-2025
// ***********************************************************************
// <copyright file="CollectionBenchmark.Person.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Base class for tests that leverage collections, with added
// functionality for preloading Person collections to improve
// benchmark test speed.
// </summary>
// ***********************************************************************

using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.Serializers;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

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
	private const int MaxPeopleDataCount = 10000;

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
	/// Loads the person collections into memory, including arrays, lists, and dictionaries for PersonRecord, Person reference types, and Person value types.
	/// </summary>
	protected void LoadPersonCollections()
	{
		this._personRefList = LoadPeopleRefCollection(this.MaxCount);
		this._personValList = LoadPeopleValCollection(this.MaxCount);
		this._personRecordList = LoadPeopleRecordCollection(this.MaxCount);
	}

	/// <summary>
	/// Gets a clone of the PersonRecord array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the PersonRecord array.</returns>
	public PersonRecord[] GetPersonRecordArray()
	{
		return [.. this._personRecordList.FastClone<PersonRecord[]>()];
	}

	/// <summary>
	/// Gets a cloned dictionary for PersonRecord.
	/// </summary>
	/// <returns>A dictionary of PersonRecord indexed by string.</returns>
	public Dictionary<string, PersonRecord> GetPersonRecordDictionary()
	{
		return this._personRecordList.FastClone(typeInfo: PersonRecordJsonSerializerContext.Default.PersonList).ToDictionary(p => p.Id, StringComparer.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Gets clone of Person reference array.
	/// </summary>
	/// <returns>An array of Person reference types.</returns>
	public Person[] GetPersonRefArray()
	{
		return [.. this._personRefList.FastClone(typeInfo: PersonRefJsonSerializerContext.Default.PersonList)];
	}

	/// <summary>
	/// Gets clone of Person reference types as a dictionary.
	/// </summary>
	/// <returns>A dictionary of Person reference types indexed by string.</returns>
	public Dictionary<string, Person> GetPersonRefDictionary()
	{
		return this._personRefList
			.FastClone(typeInfo: PersonRefJsonSerializerContext.Default.PersonList)
			.ToDictionary(p => p.Id, StringComparer.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Gets clone of Person value types as an array.
	/// </summary>
	/// <returns>An array of Person value types.</returns>
	public Tester.Models.ValueTypes.Person[] GetPersonValArray()
	{
		return [.. this._personValList.FastClone(typeInfo: PersonValJsonSerializerContext.Default.PersonList)];
	}

	/// <summary>
	/// Gets clone of person value dictionary.
	/// </summary>
	public Dictionary<string, Tester.Models.ValueTypes.Person> GetPersonValDictionary()
	{
		return this._personValList
			.FastClone(typeInfo: PersonValJsonSerializerContext.Default.PersonList)
			.ToDictionary(p => p.Id, StringComparer.OrdinalIgnoreCase);
	}

}
