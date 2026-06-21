// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tester.BenchmarkTests
// Author           : David McCarter
// Created          : 07-17-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="TimeOnlyConverterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

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
public class TimeOnlyConverterBenchmark : Benchmark
{

	private TimeOnlyConverter _converter;

	private byte[] _timeJsonBytes;

	private TimeOnly _timeValue;

	private ArrayBufferWriter<byte> _writeBuffer;

	[Benchmark(Description = nameof(TimeOnlyConverter.Read))]
	[BenchmarkCategory(Categories.JSON)]
	public void Read()
	{
		var reader = new Utf8JsonReader(this._timeJsonBytes);
		_ = reader.Read();

		var result = this._converter.Read(ref reader, typeof(TimeOnly), JsonSerializerOptions.Default);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._converter = new TimeOnlyConverter();

		this._timeValue = new TimeOnly(14, 30, 45, 123);
		var jsonString = $"\"{this._timeValue:HH:mm:ss.fff}\"";
		this._timeJsonBytes = Encoding.UTF8.GetBytes(jsonString);

		this._writeBuffer = new ArrayBufferWriter<byte>();
	}

	[Benchmark(Description = nameof(TimeOnlyConverter.Write))]
	[BenchmarkCategory(Categories.JSON)]
	public void Write()
	{
		this._writeBuffer.ResetWrittenCount();

		using var jsonWriter = new Utf8JsonWriter(this._writeBuffer);

		this._converter.Write(jsonWriter, this._timeValue, JsonSerializerOptions.Default);

		jsonWriter.Flush();
	}

}
