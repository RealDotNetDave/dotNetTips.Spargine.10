// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-16-2026
// ***********************************************************************
// <copyright file="CollectionBenchmark.Person.cs" company="dotNetTips.com - McCarter Consulting">
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
using DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts;

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
	/// Gets a clone of the PersonRecord array. This method ensures that benchmarks operate on a fresh copy of the data,
	/// preventing modifications from affecting subsequent benchmark runs.
	/// </summary>
	/// <returns>A clone of the PersonRecord array.</returns>
	public PersonRecord[] GetPersonRecordArray()
	{
		return System.Runtime.InteropServices.CollectionsMarshal.AsSpan(
			this._personRecordList.FastClone(typeInfo: PersonRecordJsonSerializerContext.Default.PersonList)).ToArray();
	}

	/// <summary>
	/// Gets a cloned dictionary for PersonRecord.
	/// </summary>
	/// <returns>A dictionary of PersonRecord indexed by string.</returns>
	public Dictionary<string, PersonRecord> GetPersonRecordDictionary()
	{
		var cloned = this._personRecordList.FastClone(typeInfo: PersonRecordJsonSerializerContext.Default.PersonList);
		var dictionary = new Dictionary<string, PersonRecord>(cloned.Count, StringComparer.OrdinalIgnoreCase);

		foreach (var person in System.Runtime.InteropServices.CollectionsMarshal.AsSpan(cloned))
		{
			dictionary[person.Id] = person;
		}

		return dictionary;
	}

	/// <summary>
	/// Gets clone of Person reference array.
	/// </summary>
	/// <returns>An array of Person reference types.</returns>
	public Person[] GetPersonRefArray()
	{
		return System.Runtime.InteropServices.CollectionsMarshal.AsSpan(
			this._personRefList.FastClone(typeInfo: PersonRefJsonSerializerContext.Default.PersonList)).ToArray();
	}

	/// <summary>
	/// Gets clone of Person reference types as a dictionary.
	/// </summary>
	/// <returns>A dictionary of Person reference types indexed by string.</returns>
	public Dictionary<string, Person> GetPersonRefDictionary()
	{
		var cloned = this._personRefList.FastClone(typeInfo: PersonRefJsonSerializerContext.Default.PersonList);
		var dictionary = new Dictionary<string, Person>(cloned.Count, StringComparer.OrdinalIgnoreCase);

		foreach (var person in System.Runtime.InteropServices.CollectionsMarshal.AsSpan(cloned))
		{
			dictionary[person.Id] = person;
		}

		return dictionary;
	}

	/// <summary>
	/// Gets clone of Person value types as an array.
	/// </summary>
	/// <returns>An array of Person value types.</returns>
	public Tester.Models.ValueTypes.Person[] GetPersonValArray()
	{
		return System.Runtime.InteropServices.CollectionsMarshal.AsSpan(
			this._personValList.FastClone(typeInfo: Tester.Models.ValueTypes.SerializerContexts.PersonValJsonSerializerContext.Default.PersonList)).ToArray();
	}

	/// <summary>
	/// Gets clone of person value dictionary.
	/// </summary>
	public Dictionary<string, Tester.Models.ValueTypes.Person> GetPersonValDictionary()
	{
		var cloned = this._personValList.FastClone(typeInfo: Tester.Models.ValueTypes.SerializerContexts.PersonValJsonSerializerContext.Default.PersonList);
		var dictionary = new Dictionary<string, Tester.Models.ValueTypes.Person>(cloned.Count, StringComparer.OrdinalIgnoreCase);

		foreach (var person in System.Runtime.InteropServices.CollectionsMarshal.AsSpan(cloned))
		{
			dictionary[person.Id] = person;
		}

		return dictionary;
	}

	/// <summary>
	/// Loads the person collections into memory, including arrays, lists, and dictionaries for PersonRecord, Person reference types, and Person value types.
	/// </summary>
	protected void LoadPersonCollections()
	{
		this._personRefList = LoadPeopleRefCollection(this.MaxCount);
		this._personValList = LoadPeopleValCollection(this.MaxCount);
		this._personRecordList = LoadPeopleRecordCollection(this.MaxCount);
	}

}
