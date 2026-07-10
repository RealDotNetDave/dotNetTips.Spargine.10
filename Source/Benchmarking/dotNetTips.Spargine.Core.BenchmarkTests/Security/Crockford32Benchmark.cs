// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-10-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-10-2026
// ***********************************************************************
// <copyright file="Crockford32Benchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks for Crockford32 Encode/Decode methods.
// </summary>
// ***********************************************************************
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Security;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Security;

[MemoryDiagnoser]
public class Crockford32Benchmark : Benchmark
{
	private byte[] _data = Array.Empty<byte>();
	private string _encoded = string.Empty;

	[Benchmark(Description = nameof(Crockford32.Decode))]
	public byte[] Decode()
	{
		return Crockford32.Decode(this._encoded);
	}

	[Benchmark(Description = nameof(Crockford32.Encode))]
	public string Encode()
	{
		return Crockford32.Encode(this._data);
	}

	public override void Setup()
	{
		base.Setup();

		this._data = new byte[4_096];
		RandomNumberGenerator.Fill(this._data);

		this._encoded = Crockford32.Encode(this._data);
	}

}
