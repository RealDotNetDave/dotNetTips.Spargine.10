// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="StreamExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for StreamExtensions methods.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="StreamExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class StreamExtensionsBenchmark : Benchmark
{
	private static readonly byte[] _payload = CreatePayload(8192);

	[Benchmark(Description = nameof(StreamExtensions.CopyToAsyncPooled) + ": Custom Buffer")]
	public async Task CopyToAsyncPooledCustomBuffer()
	{
		using var source = new MemoryStream(_payload, writable: false);
		using var destination = new MemoryStream();

		var copied = await source.CopyToAsyncPooled(destination, 4096).ConfigureAwait(false);

		this.Consume(copied);
		this.Consume(destination.Length);
	}

	[Benchmark(Description = nameof(StreamExtensions.CopyToAsyncPooled) + ": Default Buffer")]
	public async Task CopyToAsyncPooledDefaultBuffer()
	{
		using var source = new MemoryStream(_payload, writable: false);
		using var destination = new MemoryStream();

		var copied = await source.CopyToAsyncPooled(destination).ConfigureAwait(false);

		this.Consume(copied);
		this.Consume(destination.Length);
	}

	[Benchmark(Description = nameof(StreamExtensions.ReadExactlyAsync))]
	public async Task ReadExactlyAsync()
	{
		using var source = new MemoryStream(_payload, writable: false);
		var buffer = new byte[_payload.Length];

		var read = await StreamExtensions.ReadExactlyAsync(source, buffer).ConfigureAwait(false);

		this.Consume(read);
		this.Consume(buffer[0]);
	}

	[Benchmark(Description = nameof(StreamExtensions.WriteAllAsync))]
	public async Task WriteAllAsync()
	{
		using var destination = new MemoryStream();

		var written = await destination.WriteAllAsync(_payload).ConfigureAwait(false);

		this.Consume(written);
		this.Consume(destination.Length);
	}

	private static byte[] CreatePayload(int length)
	{
		var data = new byte[length];
		for (var index = 0; index < data.Length; index++)
		{
			data[index] = (byte)(index % byte.MaxValue);
		}

		return data;
	}
}
