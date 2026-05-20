// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-20-2026
// ***********************************************************************
// <copyright file="ObjectExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts;


namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[ExcludeFromCodeCoverage]
public class DisposableFields : IDisposable
{

	/// <summary>
	/// The data set
	/// </summary>
	private readonly DataSet _dataSet = new("TEST");

	/// <summary>
	/// The disposed value
	/// </summary>
	private bool _disposedValue;

	/// <summary>
	/// Disposes this instance.
	/// </summary>
	[Preserve("Part of IDisposable", "4/16/2023", "David McCarter")]
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		this.Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Disposes the specified disposing.
	/// </summary>
	/// <param name="disposing">The disposing.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!this._disposedValue)
		{
			if (disposing)
			{
				this._dataSet.Dispose();
			}

			this._disposedValue = true;
		}
	}

}

[BenchmarkCategory(Categories.ReferenceType)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class ObjectExtensionsBenchmark : Benchmark
{

	private string _peopleJson = default!;
	private Collection<Person> _personCollection = default!;
	private FileInfo _tempJsonFile = default!;

	public override void Cleanup()
	{
		// Clean up temp file after benchmark
		if (this._tempJsonFile?.Exists == true)
		{
			this._tempJsonFile.Delete();
		}

		base.Cleanup();
	}

	//[Benchmark(Description = nameof(ObjectExtensions.FastClone) + ": Person-ref")]
	//public void ClonePerson()
	//{
	//	var result = this.PersonRef01.FastClone();

	//	this.Consume(result);
	//}

	//[Benchmark(Description = nameof(ObjectExtensions.FastClone) + ": Person Array")]
	//public void ClonePersonArray()
	//{
	//	var result = this._personCollection.ToArray().FastClone();

	//	this.Consume(result);
	//}

	//[Benchmark(Description = nameof(ObjectExtensions.FastClone) + ": Person Collection")]
	//public void ClonePersonCollection()
	//{
	//	var result = this._personCollection.FastClone();

	//	this.Consume(result);
	//}

	[Benchmark(Description = "Clone: PersonRecord*")]
	public void ClonePersonRecord()
	{
		var result = this.PersonRecord01 with { };

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash) + ": Person-ref")]
	public void ComputeSha256Hash01()
	{
		var result = this.PersonRef01.ComputeSha256Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash) + ": PersonRecord")]
	public void ComputeSha256Hash02()
	{
		var result = this.PersonRecord01.ComputeSha256Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.DisposeFields) + ": DataTable")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void DisposeFields()
	{
		var disposableType = new DataTable("TEST");

		disposableType.DisposeFields();
	}

	[Benchmark(Description = "PersonRecord: Duplication with new ID")]
	public void Duplicate01()
	{
		var result = this.PersonRecord01 with { Id = "123456781234567812345678" };

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FastBinaryClone) + ": Collection<ref>")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void FastBinaryCloneCollectionPersonRef()
	{
		var result = this._personCollection.FastBinaryClone<Collection<Person>>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FastBinaryClone) + ": PersonRecord")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void FastBinaryClonePersonRecord()
	{
		var result = this.PersonRecord01.FastBinaryClone<PersonRecord>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FastBinaryClone) + ": Person - ref")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void FastBinaryClonePersonRef()
	{
		var result = this.PersonRef01.FastBinaryClone<Person>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FastBinaryClone) + ": Person - val")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void FastBinaryClonePersonVal()
	{
		var result = this.PersonVal01.FastBinaryClone<Spargine.Tester.Models.ValueTypes.Person>();

		this.Consume(result);
	}


	[Benchmark(Description = nameof(ObjectExtensions.FastClone) + ": Person")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void FastClone()
	{
		var result = this.PersonRef01.FastClone<Person>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FastClone) + ": Person + JsonSerializerOptions")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void FastCloneJsonSerializerOptions()
	{
		var options = new JsonSerializerOptions
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
			WriteIndented = true,
		};

		var result = this.PersonRef01.FastClone<Person>(options);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FieldsToDictionary))]
	public void FieldsToDictionary()
	{
		var result = this.PersonRef01.FieldsToDictionary("Person");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FieldsToString) + ": Person-ref-Ignore Nulls")]
	public void FieldsToString01()
	{
		var result = this.PersonRef01.FieldsToString(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FieldsToString) + ": Person-ref-With Nulls")]
	public void FieldsToString02()
	{
		var result = this.PersonRef01.FieldsToString(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FieldsToString) + ": PersonRecord-Ignore Nulls")]
	public void FieldsToString03()
	{
		var result = this.PersonRecord01.FieldsToString(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FieldsToString) + ": PersonRecord-With Nulls")]
	public void FieldsToString04()
	{
		var result = this.PersonRecord01.FieldsToString(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FromJson))]
	public void FromJson()
	{
		var result = this._peopleJson.FromJson<Person>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FromJson) + ": JsonTypeInfo")]
	public void FromJsonJsonTypeInfo()
	{
		var result = this._peopleJson.FromJson(PersonRefJsonSerializerContext.Default.Person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FastHashCode))]
	public void HashCodeFastGetHashCode()
	{
		this.Consume(this.LongTestString.FastHashCode());
	}

	[Benchmark(Description = "string.GetHashCode()")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void HashCodeGetHashCode()
	{
		this.Consume(this.LongTestString.GetHashCode());
	}

	[Benchmark(Description = nameof(ObjectExtensions.HasProperty) + ": Person-ref")]
	public void HasProperty01()
	{
		var result = this.PersonRef01.HasProperty("City");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.HasProperty) + ": PersonRecord")]
	public void HasProperty02()
	{
		var result = this.PersonRecord01.HasProperty("City");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.InitializeFields))]
	public void InitializeFields()
	{
		using var testObject = new DisposableFields();

		testObject.InitializeFields();

		this.Consume(testObject);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNotNull) + ": Person-ref")]
	public void IsNotNull01()
	{
		var result = this.PersonRef01.IsNotNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNotNull) + ": PersonRecord")]
	public void IsNotNull02()
	{
		var result = this.PersonRecord01.IsNotNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNull) + ": Person-ref")]
	public void IsNull01()
	{
		var result = this.PersonRef01.IsNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNull) + ": PersonRecord")]
	public void IsNull02()
	{
		var result = this.PersonRecord01.IsNull();

		this.Consume(result);
	}

	[Benchmark(Description = "PersonRecord: ToString()")]
	public void PersonRecordToString01()
	{
		var person = this.PersonRecord01;

		var result = person.ToString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": Person-ref-Ignore Nulls")]
	public void PropertiesToDictionary01()
	{
		var person = this.PersonRef01;

		var result = person.PropertiesToDictionary(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": Person-ref-With Nulls")]
	public void PropertiesToDictionary02()
	{
		var person = this.PersonRef01;

		var result = person.PropertiesToDictionary(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonRecord-With Nulls")]
	public void PropertiesToDictionary04()
	{
		var person = this.PersonRecord01;

		var result = person.PropertiesToDictionary(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonRecord-Ignore Nulls")]
	public void PropertiesToDictionary05()
	{
		var person = this.PersonRecord01;

		var result = person.PropertiesToDictionary(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": Person-ref-Ignore Nulls")]
	public void PropertiesToString01()
	{
		var person = this.PersonRef01;

		var result = person.PropertiesToString(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": Person-ref-With Nulls")]
	public void PropertiesToString02()
	{
		var person = this.PersonRef01;

		var result = person.PropertiesToString(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonRecord-Ignore Nulls")]
	public void PropertiesToString03()
	{
		var person = this.PersonRecord01;

		var result = person.PropertiesToString(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonRecord-With Nulls")]
	public void PropertiesToString04()
	{
		var person = this.PersonRecord01;

		var result = person.PropertiesToString(ignoreNulls: false);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._peopleJson = this.PersonRef01.ToJson();
		this._personCollection = RandomData.GeneratePersonRefCollection(1000).ToCollection();

		// Create temp file path for benchmark
		this._tempJsonFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"benchmark_{Guid.NewGuid()}.json"));

	}

	[Benchmark(Description = nameof(ObjectExtensions.StripNull) + ": Person")]
	public void StripNull()
	{
		var result = this.PersonRef01.StripNull();

		this.Consume(result);
	}

	[Benchmark(Description = "Testing Param for Null: != null")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TestingForNull01()
	{
		var input = new object();

		this.CheckForNullParamNormal(input);
	}

	[Benchmark(Description = "Testing Param for Null: Validate.TryValidateNull()")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TestingForNull02()
	{
		var input = new object();

		this.CheckForNullParamSpargine(input);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": Person")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJson01()
	{
		var result = this.PersonRef01.ToJson();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": PersonRecord")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJson02()
	{
		var result = this.PersonRecord01.ToJson();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": Person - JsonSerializerOptions")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJson03()
	{
		var result = this.PersonRef01.ToJson(JsonSerializerOptions.Default);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJsonFile))]
	[BenchmarkCategory(Categories.Serialization)]
	public void ToJsonFile()
	{
		var person = this.PersonRef01;

		person.ToJsonFile(this._tempJsonFile);

		// Verify file was created
		this.Consume(this._tempJsonFile.Exists);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJsonFile) + ": Complex Object")]
	[BenchmarkCategory(Categories.Serialization)]
	public void ToJsonFileComplex()
	{
		var people = this._personCollection;

		people.ToJsonFile(this._tempJsonFile);

		// Verify file was created
		this.Consume(this._tempJsonFile.Exists);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJsonFile) + ": JsonTypeInfo")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJsonFileJsonTypeInfo()
	{
		var person = this.PersonRef01;

		person.ToJsonFile(this._tempJsonFile, PersonRefJsonSerializerContext.Default.Person);

		this.Consume(this._tempJsonFile.Exists);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": Person + JsonTypeInfo")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJsonJsonTypeInfo()
	{
		var result = this.PersonRef01.ToJson(PersonRefJsonSerializerContext.Default.Person);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.TryDispose) + ": Person")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TryDispose()
	{
		var disposableType = new DataTable("TEST");

		disposableType.TryDispose();
	}

	private void CheckForNullParamNormal(object input)
	{
		input ??= "TEST";

		this.Consume(input);
	}

	private void CheckForNullParamSpargine(object input)
	{
		input ??= "SPARGINE";

		this.Consume(input);
	}

}
