// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : David McCarter
// Last Modified On : 04-10-2026
// ***********************************************************************
// <copyright file="ChannelQueueCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Queues;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading;

/// <summary>
/// Collection type PerfTestRunner.
/// </summary>
[BenchmarkCategory(Categories.Async)]
public class ChannelQueueCollectionBenchmark : LargeCollectionBenchmark
{

	/// <summary>
	/// The person reference array
	/// </summary>
	private Person[] _personRefArray;

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefArray = this.GetPersonRefArray();
	}

	[Benchmark(Description = "TryPeek")]
	[BenchmarkCategory(Categories.New)]
	public void TryPeek()
	{
		var queue = new ChannelQueue<string>();
		_ = queue.TryWrite("hello");

		var found = queue.TryPeek(out var item);

		this.Consume(found);
		this.Consume(item);
	}

	[Benchmark(Description = "TryWriteOnce")]
	[BenchmarkCategory(Categories.Async)]
	public async Task TryWriteOnce()
	{
		var queue = new ChannelQueue<string>();
		var key = "k1";
		var written = queue.TryWriteOnce("hello", key);

		await this.ConsumeAsync(written).ConfigureAwait(false);
	}

	/// <summary>
	/// Write as an asynchronous operation.
	/// </summary>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[Benchmark(Description = "WriteAsync")]
	[BenchmarkCategory(Categories.Async)]
	public async Task WriteAsync()
	{
		var channel = new ChannelQueue<Person>();
		var people = this._personRefArray;

		for (var peopleCount = 0; peopleCount < people.Length; peopleCount++)
		{
			await channel.WriteAsync(people[peopleCount]).ConfigureAwait(false);
		}

		await this.ConsumeAsync(channel.Count).ConfigureAwait(false);
	}

	/// <summary>
	/// Write asynchronous i enumerable as an asynchronous operation.
	/// </summary>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[Benchmark(Description = "WriteAsync: IEnumerable")]
	[BenchmarkCategory(Categories.Async)]
	public async Task WriteAsyncIEnumerableAsync()
	{
		var channel = new ChannelQueue<Person>();
		var people = this._personRefArray;

		await channel.WriteAsync(people).ConfigureAwait(false);

		await this.ConsumeAsync(channel.Count).ConfigureAwait(false);
	}

	/// <summary>
	/// Writes the listen asynchronous test.
	/// </summary>
	[Benchmark(Description = "Write & Listen Async")]
	[BenchmarkCategory(Categories.Async)]
	public void WriteListenAsyncTest()
	{
		var channel = new ChannelQueue<Person>();
		var people = this._personRefArray;
		var token = CancellationToken.None;

		var tasks = new List<Task>
		{
			AddToQueueAsync(channel, people, token),
			ListenToQueueAsync(channel, token)
		};

		Task.WaitAll([.. tasks]);

		this.Consume(channel.Count);
	}

	/// <summary>
	/// Write read as an asynchronous operation.
	/// </summary>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[Benchmark(Description = "Write & Read Async")]
	[BenchmarkCategory(Categories.Async)]
	public async Task WriteReadAsync()
	{
		var channel = new ChannelQueue<Person>();
		var people = this._personRefArray;

		for (var personCount = 0; personCount < people.Length; personCount++)
		{
			await channel.WriteAsync(people[personCount]).ConfigureAwait(false);
		}

		while (channel.Count > 0)
		{
			await this.ConsumeAsync(await channel.ReadAsync().ConfigureAwait(false)).ConfigureAwait(false);
		}
	}

	[Benchmark(Description = "Write & Read Async: IEnumerable")]
	[BenchmarkCategory(Categories.Async)]
	public async Task WriteReadAsyncIEnumerableAsync()
	{
		var channel = new ChannelQueue<Person>();
		var people = this._personRefArray;

		await channel.WriteAsync(people).ConfigureAwait(false);

		while (channel.Count > 0)
		{
			await this.ConsumeAsync(await channel.ReadAsync().ConfigureAwait(false)).ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Add to queue as an asynchronous operation.
	/// </summary>
	/// <param name="channel">The channel.</param>
	/// <param name="people">The people.</param>
	/// <param name="token">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A Task representing the asynchronous operation.</returns>
	/// <remarks>
	/// <para>
	/// This method writes all items to the channel and then locks it to signal completion.
	/// If cancellation is requested during the write operations, the channel is NOT locked,
	/// allowing cleanup or retry logic to function correctly.
	/// </para>
	/// <para>
	/// <strong>Exception Handling:</strong> If an <see cref="OperationCanceledException"/> is thrown
	/// during the write loop, it will propagate to the caller without locking the channel.
	/// This ensures the channel remains in a consistent state that can be cleaned up or reused.
	/// </para>
	/// </remarks>
	private static async Task AddToQueueAsync(ChannelQueue<Person> channel, IList<Person> people, CancellationToken token)
	{
		// Write all items to the channel
		// If cancellation is requested, WriteAsync will throw OperationCanceledException
		foreach (var person in people)
		{
			await channel.WriteAsync(person, cancellationToken: token).ConfigureAwait(false);
		}

		// Check for cancellation one final time before locking
		// This prevents locking the channel if cancellation was requested
		// between the last WriteAsync and the Lock call
		token.ThrowIfCancellationRequested();

		// Lock the channel to signal that no more items will be written
		// This allows listeners (via ListenAsync) to complete their enumeration
		_ = channel.Lock();
	}

	/// <summary>
	/// Listen to queue as an asynchronous operation.
	/// </summary>
	/// <param name="channel">The channel.</param>
	/// <param name="token">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>A Task representing the asynchronous operation.</returns>
	/// <remarks>
	/// <para>
	/// This method asynchronously enumerates items from the channel using <see cref="ChannelQueue{T}.ListenAsync"/>.
	/// The enumeration continues until the channel is locked (completed) or cancellation is requested via the <paramref name="token"/>.
	/// </para>
	/// <para>
	/// <strong>Cancellation Handling:</strong> The cancellation token is passed to the async stream via <see cref="TaskAsyncEnumerableExtensions.WithCancellation{T}"/>.
	/// When cancellation is requested, the enumeration stops at the next cancellation check point (typically at the next await operation).
	/// </para>
	/// <para>
	/// <strong>ConfigureAwait:</strong> Using <c>.ConfigureAwait(false)</c> prevents capturing the synchronization context,
	/// which improves performance in non-UI scenarios by avoiding unnecessary context switches.
	/// </para>
	/// </remarks>
	private static async Task ListenToQueueAsync(ChannelQueue<Person> channel, CancellationToken token)
	{
		// Use WithCancellation to pass the cancellation token to the async stream
		// ConfigureAwait(false) controls how awaits are performed (without capturing context)
		await foreach (var item in channel.ListenAsync(token)
			.WithCancellation(token)
			.ConfigureAwait(false))
		{
			Trace.WriteLine(item.Email);
		}
	}

}
