// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-24-2025
// ***********************************************************************
// <copyright file="CollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Base class for tests utilizing collections, with additional
// functionality to preload collections for enhanced benchmark test
// speed.
// </summary>
// ***********************************************************************

using DotNetTips.Spargine.Benchmarking.Properties;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.Serializers;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Represents the base class for benchmarks that involve collections, specifically optimized for handling PersonRecord objects.
/// This class provides methods to preload PersonRecord collections to improve benchmark test speed and efficiency.
/// </summary>
[Information(Documentation = "https://bit.ly/BenchmarkLikeDotNetDave", Status = Status.Available)]
public partial class CollectionBenchmark : Benchmark
{
	/// <summary>
	/// Half count
	/// </summary>
	private int _halfCount;

	/// <summary>
	/// The people record to insert.
	/// </summary>
	private PersonRecord[] _peopleRecordToInsert;

	/// <summary>
	/// The people to insert as reference types.
	/// </summary>
	private Person[] _peopleRefToInsert;

	/// <summary>
	/// The people to insert as value types.
	/// </summary>
	private Tester.Models.ValueTypes.Person[] _peopleValToInsert;

	/// <summary>
	/// Initializes a new instance of the <see cref="CollectionBenchmark"/> class.
	/// </summary>
	/// <param name="maxCount">The maximum count for the collections used in the benchmark.</param>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
	[Preserve("DO NOT MODIFY THIS CONSTRUCTOR!")]
	protected CollectionBenchmark(int maxCount)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
	{
		this.MaxCount = Math.Max(2, maxCount);
	}

	/// <summary>
	/// Loads collections of people objects for insertion into benchmarks.
	/// This method generates collections of reference type, value type, and record type people objects
	/// using the specified count and assigns them to the corresponding fields.
	/// </summary>
	private void LoadInsertCollections()
	{
		LogInfo($"Loading Insert Collections. Count={this.HalfCount}: {nameof(CollectionBenchmark)}.");

		// Load people objects
		this._peopleRefToInsert = [.. RandomData.GeneratePersonRefCollection(this.HalfCount)];

		this._peopleValToInsert = [.. RandomData.GeneratePersonValCollection(this.HalfCount)];

		this._peopleRecordToInsert = [.. RandomData.GeneratePersonRecordCollection(this.HalfCount)];
	}

	/// <summary>
	/// Gets a collection of <see cref="PersonRecord"/> objects for insertion into collections.
	/// </summary>
	/// <returns>An array of <see cref="PersonRecord"/>.</returns>
	protected virtual PersonRecord[] GetPersonRecordCollectionToInsert()
	{
		return this._peopleRecordToInsert;
	}

	/// <summary>
	/// Gets a collection of <see cref="Person"/> reference objects for insertion into collections.
	/// </summary>
	/// <returns>An array of <see cref="Person"/>.</returns>
	protected virtual Person[] GetPersonRefCollectionToInsert()
	{
		return this._peopleRefToInsert;
	}

	/// <summary>
	/// Gets a collection of <see cref="Tester.Models.ValueTypes.Person"/> value objects for insertion into collections.
	/// </summary>
	/// <returns>An array of <see cref="Tester.Models.ValueTypes.Person"/>.</returns>
	protected virtual Tester.Models.ValueTypes.Person[] GetPersonValCollectionToInsert()
	{
		return this._peopleValToInsert;
	}

	/// <summary>
	/// Loads a specified number of <see cref="PersonRecord"/> objects from embedded resources. 
	/// If count is greater than 10,000, the remainder of the objects are generated randomly.
	/// </summary>
	/// <param name="count">The number of <see cref="PersonRecord"/> objects to load. The value must be in the range of 1 to 10000.</param>
	/// <returns>An array of <see cref="PersonRecord"/> objects.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the count is not within the valid range.</exception>
	internal static List<PersonRecord> LoadPeopleRecordCollection(int count)
	{
		if (count <= MaxPeopleDataCount)
		{
			return [.. JsonSerialization.LoadCollectionFromJson<PersonRecord>(Resources.PeopleJson, count, PersonRecordJsonSerializerContext.Default.Person)];
		}
		else
		{
			var people = JsonSerialization.LoadCollectionFromJson<PersonRecord>(Resources.PeopleJson, MaxPeopleDataCount, PersonRecordJsonSerializerContext.Default.Person);
			var newPeople = RandomData.GeneratePersonRecordCollection(count - MaxPeopleDataCount);

			return [.. people, .. newPeople];
		}
	}

	/// <summary>
	/// Loads a specified number of <see cref="Person"/> reference objects from embedded resources. 
	/// If count is greater than 10,000, the remainder of the objects are generated randomly.
	/// </summary>
	/// <param name="count">The number of <see cref="Person"/> reference objects to load. The value must be in the range of 1 to 10000.</param>
	/// <returns>An array of <see cref="Person"/> reference objects.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the count is not within the valid range.</exception>
	internal static List<Person> LoadPeopleRefCollection(int count)
	{
		if (count <= MaxPeopleDataCount)
		{
			return [.. JsonSerialization.LoadCollectionFromJson<Person>(Resources.PeopleJson, count, PersonRefJsonSerializerContext.Default.Person)];
		}
		else
		{
			var people = JsonSerialization.LoadCollectionFromJson<Person>(Resources.PeopleJson, MaxPeopleDataCount, PersonRefJsonSerializerContext.Default.Person);
			var newPeople = RandomData.GeneratePersonRefCollection(count - MaxPeopleDataCount);

			return [.. people, .. newPeople];
		}
	}

	/// <summary>
	/// Loads a specified number of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects from embedded resources. 
	/// If count is greater than 10,000, the remainder of the objects are generated randomly.
	/// </summary>
	/// <param name="count">The number of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects to load. The value must be in the range of 1 to 10000.</param>
	/// <returns>An array of Tester.Models.ValueTypes.Person{Tester.Models.ValueTypes.Address} value objects.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when the count is not within the valid range.</exception>
	internal static List<Tester.Models.ValueTypes.Person> LoadPeopleValCollection(int count)
	{
		if (count <= MaxPeopleDataCount)
		{
			return [.. JsonSerialization.LoadCollectionFromJson<Tester.Models.ValueTypes.Person>(Resources.PeopleJson, count, PersonValJsonSerializerContext.Default.Person)];
		}
		else
		{
			var people = JsonSerialization.LoadCollectionFromJson<Tester.Models.ValueTypes.Person>(Resources.PeopleJson, MaxPeopleDataCount, PersonValJsonSerializerContext.Default.Person);
			var newPeople = RandomData.GeneratePersonValCollection(count - MaxPeopleDataCount);

			return [.. people, .. newPeople];
		}
	}

	/// <summary>
	/// Setups the benchmark instance. This method is called before the benchmark runs and is responsible for initializing the collections and loading the data.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this.HalfCount = this.MaxCount / 2;

		// Load collections.
		// DO NOT ADD ANY COLLECTION GENERATION ABOVE THIS LINE
		this.LoadCoordinateCollections();
		this.LoadPersonCollections();

		// Cache arrays to avoid multiple enumerations and improve performance
		var personRefArray = this.GetPersonRefArray();
		var personRecordArray = this.GetPersonRecordArray();
		var personValArray = this.GetPersonValArray();

		// Load lookup values
		this.PersonEmailHalf = personRefArray[this.HalfCount].Email;
		this.PersonEmailLast = personRefArray.Last().Email;
		this.PersonFirstNameHalf = personRefArray[this.HalfCount].FirstName;
		this.PersonFirstNameLast = personRefArray.Last().FirstName;
		this.PersonLastNameHalf = personRefArray[this.HalfCount].LastName;
		this.PersonLastNameLast = personRefArray.Last().LastName;
		this.PersonRecordLookupHalf = personRecordArray[this.HalfCount];
		this.PersonRecordLookupLast = personRecordArray.Last();
		this.PersonRefLookupHalf = personRefArray[this.HalfCount];
		this.PersonRefLookupLast = personRefArray.Last();
		this.PersonValLookupHalf = personValArray[this.HalfCount];
		this.PersonValLookupLast = personValArray.Last();

		// Load insert collections
		this.LoadInsertCollections();

	}

	/// <summary>
	/// Gets or sets the half count.
	/// </summary>
	/// <value>The half count.</value>
	public int HalfCount { get => this._halfCount; set => this._halfCount = value; }

	/// <summary>
	/// Gets or sets the maximum count for the collections used in the benchmark.
	/// </summary>
	/// <value>The maximum count.</value>
	public int MaxCount { get; internal set; }

	/// <summary>
	/// Gets the email address of a person in the middle of the collection.
	/// </summary>
	public string PersonEmailHalf { get; private set; }

	/// <summary>
	/// Gets the email address of the last person in the collection.
	/// </summary>
	public string PersonEmailLast { get; private set; }

	/// <summary>
	/// Gets the first name of a person in the middle of the collection.
	/// </summary>
	public string PersonFirstNameHalf { get; private set; }

	/// <summary>
	/// Gets the first name of the last person in the collection.
	/// </summary>
	public string PersonFirstNameLast { get; private set; }

	/// <summary>
	/// Gets the last name of a person in the middle of the collection.
	/// </summary>
	public string PersonLastNameHalf { get; private set; }

	/// <summary>
	/// Gets the last name of the last person in the collection.
	/// </summary>
	public string PersonLastNameLast { get; private set; }

	/// <summary>
	/// Gets the person record for lookup from the middle of the collection.
	/// </summary>
	public PersonRecord PersonRecordLookupHalf { get; private set; }

	/// <summary>
	/// Gets the person record for lookup of the last item in the collection.
	/// </summary>
	public PersonRecord PersonRecordLookupLast { get; private set; }

	/// <summary>
	/// Gets the reference type person for lookup from the middle of the collection.
	/// </summary>
	public Person PersonRefLookupHalf { get; private set; }

	/// <summary>
	/// Gets the reference type person for lookup of the last item in the collection.
	/// </summary>
	public Person PersonRefLookupLast { get; private set; }

	/// <summary>
	/// Gets the value type person for lookup from the middle of the collection.
	/// </summary>
	public Tester.Models.ValueTypes.Person PersonValLookupHalf { get; private set; }

	/// <summary>
	/// Gets the value type person for lookup of the last item in the collection.
	/// </summary>
	public Tester.Models.ValueTypes.Person PersonValLookupLast { get; private set; }
}
