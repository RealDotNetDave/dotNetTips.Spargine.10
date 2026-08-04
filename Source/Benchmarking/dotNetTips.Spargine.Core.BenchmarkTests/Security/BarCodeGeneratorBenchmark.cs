// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 08-03-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="BarCodeGeneratorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks for BarcodeGenerator BuildHmacBarcode and ValidateHmacBarcode methods.
// </summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Benchmarking.Configs;
using DotNetTips.Spargine.Core.Security;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

[MemoryDiagnoser]
[Config(typeof(ReturnValueColumnConfig))]
public class BarCodeGeneratorBenchmark : Benchmark
{
	private const string Issuer = "dotNetTips";
	private const string KeyId = "k1";
	private const string PerformanceId = "PERF-123456";
	private const string TicketId = "TICKET-123456";

	private string _barcode = string.Empty;
	private DateTimeOffset _expiresUtc;
	private byte[] _key = Array.Empty<byte>();
	private IReadOnlyDictionary<string, byte[]> _keysByKid = default!;

	[Benchmark(Description = nameof(BarcodeGenerator.BuildHmacBarcode))]
	public string BuildHmacBarcode()
	{
		return BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, this._expiresUtc, Issuer, this._key, KeyId);
	}

	public override void Setup()
	{
		base.Setup();

		this._key = "0123456789ABCDEF0123456789ABCDEF"u8.ToArray();
		this._keysByKid = new Dictionary<string, byte[]>(StringComparer.Ordinal)
		{
			[KeyId] = this._key
		};
		this._expiresUtc = DateTimeOffset.UtcNow.AddMinutes(30);
		this._barcode = BarcodeGenerator.BuildHmacBarcode(TicketId, PerformanceId, this._expiresUtc, Issuer, this._key, KeyId);
	}

	[Benchmark(Description = nameof(BarcodeGenerator.ValidateHmacBarcode))]
	public bool ValidateHmacBarcode()
	{
		var isValid = BarcodeGenerator.ValidateHmacBarcode(this._barcode, this._keysByKid, out var fields);
		this.Consume(fields);
		return isValid;
	}
}
