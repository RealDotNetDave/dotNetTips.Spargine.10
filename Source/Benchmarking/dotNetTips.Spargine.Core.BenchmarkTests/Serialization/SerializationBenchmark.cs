// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="SerializationBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.SerializerContexts;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Serialization;

/// <summary>
/// Class SerializationBenchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
[BenchmarkCategory(Categories.Serialization)]
[EventPipeProfiler(EventPipeProfile.CpuSampling)]
[MemoryDiagnoser]
[ThreadingDiagnoser]
public class SerializationBenchmark : Benchmark
{
	private const int Count = 100;

	private string _jsonPersonRecord = default!;
	private string _jsonPersonRef = default!;
	private string _jsonPersonRefList = default!;
	private FileInfo _jsonSerializeToFile = default!;
	private List<Person> _personRefList = default!;
	private string _xmlPersonRecord = default!;
	private string _xmlPersonRef = default!;
	private FileInfo _xmlSerializeToFile = default!;

	[Benchmark(Description = nameof(JsonSerialization.CreateDefaultOptions))]
	[BenchmarkCategory(Categories.JSON)]
	public void CreateDefaultOptions()
	{
		var result = JsonSerialization.CreateDefaultOptions();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.CreateDefaultOptions) + ": Indented + DateOnly Converters")]
	[BenchmarkCategory(Categories.JSON)]
	public void CreateDefaultOptionsIndentedWithConverters()
	{
		var result = JsonSerialization.CreateDefaultOptions(writeIndented: true, includeDateOnlyConverters: true);

		this.Consume(result);
	}

	[Benchmark(Description = "Deserialize JSON: JsonSerializer + Generator - Person")]
	[BenchmarkCategory(Categories.JSON, "JsonSerializer")]
	public void Deserialize_Json_JsonSerializer_Generator_Person()
	{
		var result = JsonSerializer.Deserialize(this._jsonPersonRef, typeof(Person), PersonRefJsonSerializerContext.Default) as Person;
		this.Consume(result);
	}

	[Benchmark(Description = "Deserialize JSON: JsonSerializer + Generator - List<Person>")]
	[BenchmarkCategory(Categories.JSON, "JsonSerializer")]
	public void Deserialize_Json_JsonSerializer_Generator_Person_List()
	{
		var result = JsonSerializer.Deserialize(this._jsonPersonRefList, typeof(List<Person>), PersonRefJsonSerializerContext.Default) as List<Person>;
		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": List<Person>")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize_Json_Person_List()
	{
		var result = JsonSerialization.Deserialize<List<Person>>(this._jsonPersonRefList);

		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize_Json_PersonRecord()
	{
		var result = JsonSerialization.Deserialize<PersonRecord>(this._jsonPersonRecord);

		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the XML record.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonRecord")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize_Xml_PersonRecord()
	{
		var result = XmlSerialization.Deserialize<PersonRecord>(this._xmlPersonRecord);

		this.Consume(result);
	}
	/// <summary>
	/// Deserializes the XML reference.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=Person")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize_Xml_Ref_Person()
	{
		var result = XmlSerialization.Deserialize<Person>(this._xmlPersonRef);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.JsonEqual))]
	[BenchmarkCategory(Categories.JSON)]
	public void JsonEqual()
	{
		var actual = "{\"Name\":\"Test\",\"Value\":1}";
		var expected = "{\"Name\":\"Test\",\"Value\":2}";

		// Act
		var result = JsonSerialization.JsonEqual(actual, expected);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.LoadCollectionFromJson) + ": JSON=People")]
	[BenchmarkCategory(Categories.JSON)]
	public void LoadCollectionFromJson_People()
	{
		var result = JsonSerialization.LoadCollectionFromJson<Person>(this._jsonPersonRefList, Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.LoadCollectionFromJson) + ": JSON=People, SerializerContext")]
	[BenchmarkCategory(Categories.JSON)]
	public void LoadCollectionFromJson_People_SerializerContext()
	{
		var result = JsonSerialization.LoadCollectionFromJson<Person>(this._jsonPersonRefList, Count, PersonRefJsonSerializerContext.Default.Person);

		this.Consume(result);
	}

	[Benchmark(Description = "Serialize JSON: JsonSerializer + Generator - Person")]
	[BenchmarkCategory(Categories.JSON, "JsonSerializer")]
	public void Serialize_Json_JsonSerializer_Generator_Person()
	{
		var result = JsonSerializer.Serialize(this.PersonRef01, typeof(Person), PersonRefJsonSerializerContext.Default);

		this.Consume(result);
	}

	[Benchmark(Description = "Serialize JSON: JsonSerializer + Generator - List<Person>")]
	[BenchmarkCategory(Categories.JSON, "JsonSerializer")]
	public void Serialize_Json_JsonSerializer_Generator_Person_List()
	{
		var result = JsonSerializer.Serialize(this._personRefList, typeof(List<Person>), PersonRefJsonSerializerContext.Default);
		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": List<Person>")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_Person_List()
	{
		var result = JsonSerialization.Serialize(this._personRefList);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_PersonRecord()
	{
		var result = JsonSerialization.Serialize(this.PersonRecord02);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json reference.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=Person")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_Ref_Person()
	{
		var result = JsonSerialization.Serialize(this.PersonRef01);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the XML reference.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Serialize) + ": XML=Person")]
	[BenchmarkCategory(Categories.XML)]
	public void Serialize_XML_Ref_Person()
	{
		var result = XmlSerialization.Serialize(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.SerializeToFile) + ": JSON=Person, TypeInfo")]
	[BenchmarkCategory(Categories.JSON)]
	public void SerializeToFile_Json_Ref_Person()
	{
		JsonSerialization.SerializeToFile(this.PersonRef01, this._jsonSerializeToFile, PersonRefJsonSerializerContext.Default.Person);

		this.Consume(this._jsonSerializeToFile.Exists);
	}

	/// <summary>
	/// Serializes the XML reference to a file.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.SerializeToFile) + ": XML=Person")]
	[BenchmarkCategory(Categories.XML)]
	public void SerializeToFile_Xml_Ref_Person()
	{
		XmlSerialization.SerializeToFile(this.PersonRef01, this._xmlSerializeToFile);

		this.Consume(this._xmlSerializeToFile.Exists);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._jsonPersonRef = JsonSerialization.Serialize(this.PersonRef01);
		this._jsonPersonRecord = JsonSerialization.Serialize(this.PersonRecord01);
		this._xmlPersonRef = XmlSerialization.Serialize(this.PersonRef01);
		this._xmlPersonRecord = XmlSerialization.Serialize(this.PersonRecord01);
		this._jsonPersonRefList = RandomData.GeneratePersonRefCollection(Count).ToJson();
		this._personRefList = [.. RandomData.GeneratePersonRefCollection(100)];
		this._jsonSerializeToFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.json"));
		this._xmlSerializeToFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xml"));
	}

}
