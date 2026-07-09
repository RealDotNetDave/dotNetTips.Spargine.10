// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="MessagePackExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for MessagePackExtensions methods.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using MessagePack;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="MessagePackExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.Serialization)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class MessagePackExtensionsBenchmark : Benchmark
{
	private byte[] _payload = [];
	private TestMessagePackModel _value = default!;

	[Benchmark(Description = nameof(MessagePackExtensions.FromMessagePack))]
	public void FromMessagePack()
	{
		var result = this._payload.FromMessagePack<TestMessagePackModel>();
		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();
		this._value = new TestMessagePackModel(42, "benchmark");
		this._payload = this._value.ToMessagePackBytes();
	}

	[Benchmark(Description = nameof(MessagePackExtensions.ToMessagePackBytes))]
	public void ToMessagePackBytes()
	{
		var result = this._value.ToMessagePackBytes();
		this.Consume(result);
	}

	[MessagePackObject]
	private sealed record TestMessagePackModel([property: Key(0)] int Id, [property: Key(1)] string Name);
}
