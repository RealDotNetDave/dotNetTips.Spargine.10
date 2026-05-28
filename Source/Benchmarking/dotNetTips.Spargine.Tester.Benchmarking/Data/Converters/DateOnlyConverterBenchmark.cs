// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="DateOnlyConverterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Buffers;
using System.Text;
using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Data.Converters;
using Microsoft.VSDiagnostics;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

[CPUUsageDiagnoser]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class DateOnlyConverterBenchmark : Benchmark
{
	private DateOnlyConverter _converter;

	private byte[] _dateJsonBytes;

	private DateOnly _dateValue;

	private ArrayBufferWriter<byte> _writeBuffer;

	[Benchmark(Description = nameof(DateOnlyConverter.Read))]
	[BenchmarkCategory(Categories.JSON)]
	public void Read()
	{
		var reader = new Utf8JsonReader(this._dateJsonBytes);
		_ = reader.Read();

		var result = this._converter.Read(ref reader, typeof(DateOnly), JsonSerializerOptions.Default);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._converter = new DateOnlyConverter();

		this._dateValue = new DateOnly(2025, 7, 17);
		var jsonString = $"\"{this._dateValue:yyyy-MM-dd}\"";
		this._dateJsonBytes = Encoding.UTF8.GetBytes(jsonString);

		this._writeBuffer = new ArrayBufferWriter<byte>();
	}

	[Benchmark(Description = nameof(DateOnlyConverter.Write))]
	[BenchmarkCategory(Categories.JSON)]
	public void Write()
	{
		this._writeBuffer.ResetWrittenCount();

		using var jsonWriter = new Utf8JsonWriter(this._writeBuffer);

		this._converter.Write(jsonWriter, this._dateValue, JsonSerializerOptions.Default);

		jsonWriter.Flush();
	}

}
