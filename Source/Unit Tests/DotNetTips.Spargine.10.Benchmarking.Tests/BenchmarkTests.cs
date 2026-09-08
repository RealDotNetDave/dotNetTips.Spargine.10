// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking.Tests
// Author           : Copilot Agent
// Created          : 09-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-08-2026
// ***********************************************************************
// <copyright file="BenchmarkTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Regression tests for benchmark fixtures, lifecycle, asynchronous streams,
// and ownership of temporary directories.
// </summary>
// ***********************************************************************
//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Tester;

namespace DotNetTips.Spargine.Benchmarking.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public sealed class BenchmarkTests
{
	private const int FixtureLength = 64;
	private const int FixtureSeed = 42;

	[TestMethod]
	public void DataSeedDefaultIsNull()
	{
		Assert.IsNull(new TestBenchmark().DataSeed);
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(1)]
	[DataRow(1023)]
	[DataRow(1024)]
	[DataRow(1025)]
	public void GetByteArrayByLengthValidCountReturnsExactLength(int byteCount)
	{
		var benchmark = new TestBenchmark();
		Assert.AreEqual(byteCount, benchmark.GetByteArrayByLength(byteCount).Length);
	}

	[TestMethod]
	public void GetByteArrayByLengthNegativeCountThrowsArgumentOutOfRangeException()
	{
		var benchmark = new TestBenchmark();
		var exception = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => benchmark.GetByteArrayByLength(-1));
		Assert.AreEqual("byteCount", exception.ParamName);
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(-1)]
	public void GetByteArrayNonpositiveCountThrowsArgumentOutOfRangeException(int count)
	{
		var benchmark = new TestBenchmark();
		var exception = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => benchmark.GetByteArray(count));
		Assert.AreEqual("count", exception.ParamName);
	}

	[TestMethod]
	public void GetByteArrayDefaultReturnsOneByte()
	{
		Assert.AreEqual(1, new TestBenchmark().GetByteArray().Length);
	}

	[TestMethod]
	public void GetByteArrayMatchingExactLengthSharesCachedArray()
	{
		var benchmark = new TestBenchmark();
		Assert.AreSame(benchmark.GetByteArray(FixtureLength), benchmark.GetByteArrayByLength(FixtureLength));
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(-42)]
	[DataRow(int.MinValue)]
	[DataRow(int.MaxValue)]
	public void GetByteArrayMatchingSeedReproducesData(int seed)
	{
		var first = new TestBenchmark { DataSeed = seed };
		var second = new TestBenchmark { DataSeed = seed };
		_ = second.GetByteArray(7);
		CollectionAssert.AreEqual(first.GetByteArray(FixtureLength), second.GetByteArray(FixtureLength));
	}

	[TestMethod]
	public void GetStringArrayMatchingSeedReproducesDataIndependentlyOfCallOrder()
	{
		var first = new TestBenchmark { DataSeed = FixtureSeed };
		var second = new TestBenchmark { DataSeed = FixtureSeed };
		_ = second.GetStringArray(3, 1, 2);
		_ = second.GetByteArray(7);
		CollectionAssert.AreEqual(first.GetStringArray(FixtureLength), second.GetStringArray(FixtureLength));
	}

	[TestMethod]
	public void DataSeedDifferentSeedChangesByteData()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetByteArray(FixtureLength);
		benchmark.DataSeed = FixtureSeed + 1;
		CollectionAssert.AreNotEqual(previous, benchmark.GetByteArray(FixtureLength));
	}

	[TestMethod]
	public void DataSeedDifferentSeedChangesStringData()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetStringArray(FixtureLength);
		benchmark.DataSeed = FixtureSeed + 1;
		CollectionAssert.AreNotEqual(previous, benchmark.GetStringArray(FixtureLength));
	}

	[TestMethod]
	public void DataSeedSameSeedPreservesByteCache()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetByteArray(FixtureLength);
		benchmark.DataSeed = FixtureSeed;
		Assert.AreSame(previous, benchmark.GetByteArray(FixtureLength));
	}

	[TestMethod]
	public void DataSeedSameSeedPreservesStringCache()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetStringArray(FixtureLength);
		benchmark.DataSeed = FixtureSeed;
		Assert.AreSame(previous, benchmark.GetStringArray(FixtureLength));
	}

	[TestMethod]
	public void DataSeedResetToNullInvalidatesByteCache()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetByteArray(FixtureLength);
		benchmark.DataSeed = null;
		Assert.AreNotSame(previous, benchmark.GetByteArray(FixtureLength));
	}

	[TestMethod]
	public void DataSeedResetToNullInvalidatesStringCache()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetStringArray(FixtureLength);
		benchmark.DataSeed = null;
		Assert.AreNotSame(previous, benchmark.GetStringArray(FixtureLength));
	}

	[TestMethod]
	public void DataSeedRestoredSeedReproducesOriginalData()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetByteArray(FixtureLength);
		benchmark.DataSeed = FixtureSeed + 1;
		_ = benchmark.GetByteArray(FixtureLength);
		benchmark.DataSeed = FixtureSeed;
		CollectionAssert.AreEqual(previous, benchmark.GetByteArray(FixtureLength));
	}

	[TestMethod]
	[DataRow(null)]
	[DataRow(FixtureSeed)]
	public void CopyByteArrayToMutatedGetterArrayRestoresPristineData(int? seed)
	{
		var benchmark = new TestBenchmark { DataSeed = seed };
		var exposed = benchmark.GetByteArray(FixtureLength);
		var expected = (byte[])exposed.Clone();
		exposed.AsSpan().Fill(byte.MaxValue);
		benchmark.CopyByteArrayTo(exposed);
		CollectionAssert.AreEqual(expected, exposed);
	}

	[TestMethod]
	[DataRow(null)]
	[DataRow(FixtureSeed)]
	public void CopyStringArrayToMutatedGetterArrayRestoresPristineData(int? seed)
	{
		var benchmark = new TestBenchmark { DataSeed = seed };
		var exposed = benchmark.GetStringArray(4, 2, 4);
		var expected = (string[])exposed.Clone();
		exposed[0] = RandomData.GenerateWord(20);
		benchmark.CopyStringArrayTo(exposed, 2, 4);
		CollectionAssert.AreEqual(expected, exposed);
	}

	[TestMethod]
	public void CopyByteArrayToColdCacheFillsOnlyDestinationSlice()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var destination = new byte[] { byte.MaxValue, 0, 0, byte.MaxValue };
		benchmark.CopyByteArrayTo(destination.AsSpan(1, 2));
		var fixture = new TestBenchmark { DataSeed = FixtureSeed }.GetByteArray(2);
		CollectionAssert.AreEqual(new byte[] { byte.MaxValue, fixture[0], fixture[1], byte.MaxValue }, destination);
	}

	[TestMethod]
	public void CopyStringArrayToColdCacheFillsOnlyDestinationSlice()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var sentinel = RandomData.GenerateWord(20);
		var destination = new[] { sentinel, sentinel, sentinel, sentinel };
		benchmark.CopyStringArrayTo(destination.AsSpan(1, 2));
		var fixture = new TestBenchmark { DataSeed = FixtureSeed }.GetStringArray(2);
		CollectionAssert.AreEqual(new[] { sentinel, fixture[0], fixture[1], sentinel }, destination);
	}

	[TestMethod]
	public void CopyByteArrayToEmptyDestinationLeavesCacheUsable()
	{
		var benchmark = new TestBenchmark();
		benchmark.CopyByteArrayTo(Span<byte>.Empty);
		Assert.AreEqual(0, benchmark.GetByteArrayByLength(0).Length);
	}

	[TestMethod]
	public void CopyStringArrayToEmptyDestinationDoesNotAffectExistingFixture()
	{
		var benchmark = new TestBenchmark();
		var fixture = benchmark.GetStringArray(1);
		benchmark.CopyStringArrayTo(Span<string>.Empty);
		Assert.AreSame(fixture, benchmark.GetStringArray(1));
	}

	[TestMethod]
	public void GetStringArrayUnrepresentableMinimumThrowsArgumentOutOfRangeException()
	{
		var benchmark = new TestBenchmark();
		var exception = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => benchmark.GetStringArray(1, int.MaxValue));
		Assert.AreEqual("wordMinLength", exception.ParamName);
	}

	[TestMethod]
	public void CopyStringArrayToEmptyDestinationWithInvalidMinimumThrowsArgumentOutOfRangeException()
	{
		var benchmark = new TestBenchmark();
		var exception = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => benchmark.CopyStringArrayTo(Span<string>.Empty, int.MaxValue));
		Assert.AreEqual("wordMinLength", exception.ParamName);
	}

	[TestMethod]
	[DataRow(null)]
	[DataRow(FixtureSeed)]
	public void GetStringArrayNonpositiveArgumentsNormalizesCountAndLengths(int? seed)
	{
		var benchmark = new TestBenchmark { DataSeed = seed };
		var fixture = benchmark.GetStringArray(0, 0, -1);
		Assert.AreEqual((1, true), (fixture.Length, fixture[0].Length is >= 1 and <= 2));
	}

	[TestMethod]
	[DataRow(null)]
	[DataRow(FixtureSeed)]
	public void GetStringArrayRepeatedArgumentsReturnsSameArray(int? seed)
	{
		var benchmark = new TestBenchmark { DataSeed = seed };
		Assert.AreSame(benchmark.GetStringArray(4), benchmark.GetStringArray(4));
	}

	[TestMethod]
	public void GetStringArraySeededWordsRespectLengthAndAlphabet()
	{
		var fixture = new TestBenchmark { DataSeed = FixtureSeed }.GetStringArray(FixtureLength, 2, 4);
		Assert.IsTrue(fixture.All(word => word.Length is >= 2 and <= 4 && word.All(character => character is >= 'a' and <= 'z')));
	}

	[TestMethod]
	public void ClearDataCachesExistingByteFixtureRecreatesArrayWithSameSeededContents()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetByteArray(FixtureLength);
		benchmark.ClearDataCaches();
		var current = benchmark.GetByteArray(FixtureLength);
		Assert.AreEqual((false, true, (int?)FixtureSeed), (ReferenceEquals(previous, current), previous.SequenceEqual(current), benchmark.DataSeed));
	}

	[TestMethod]
	public void ClearDataCachesExistingStringFixtureRecreatesArrayWithSameSeededContents()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetStringArray(4);
		benchmark.ClearDataCaches();
		var current = benchmark.GetStringArray(4);
		Assert.AreEqual((false, true), (ReferenceEquals(previous, current), previous.SequenceEqual(current)));
	}

	[TestMethod]
	public async Task ConsumeAsyncEnumerableAsyncNullSourceThrowsArgumentNullException()
	{
		var benchmark = new TestBenchmark();
		var exception = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => benchmark.ConsumeAsyncEnumerableAsync<int>(null!)).ConfigureAwait(false);
		Assert.AreEqual("source: ", exception.ParamName);
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(4)]
	public async Task ConsumeAsyncEnumerableAsyncSequenceEnumeratesAndDisposes(int count)
	{
		var source = new TrackedSequence(count);
		await new TestBenchmark().ConsumeAsyncEnumerableAsync(source.ReadAsync()).ConfigureAwait(false);
		Assert.AreEqual((count, true), (source.EnumeratedCount, source.Disposed));
	}

	[TestMethod]
	public async Task ConsumeAsyncEnumerableAsyncTokenIsForwardedToSource()
	{
		using var cancellation = new CancellationTokenSource();
		var source = new TrackedSequence(1);
		await new TestBenchmark().ConsumeAsyncEnumerableAsync(source.ReadAsync(), cancellation.Token).ConfigureAwait(false);
		Assert.AreEqual(cancellation.Token, source.ObservedToken);
	}

	[TestMethod]
	public async Task ConsumeAsyncEnumerableAsyncPreCanceledTokenDoesNotStartEnumeration()
	{
		using var cancellation = new CancellationTokenSource();
		await cancellation.CancelAsync().ConfigureAwait(false);
		var source = new TrackedSequence(1);
		await Assert.ThrowsExactlyAsync<OperationCanceledException>(() => new TestBenchmark().ConsumeAsyncEnumerableAsync(source.ReadAsync(), cancellation.Token)).ConfigureAwait(false);
		Assert.IsFalse(source.Started);
	}

	[TestMethod]
	public async Task ConsumeAsyncEnumerableAsyncSourceIgnoresCancellationStopsAndDisposes()
	{
		using var cancellation = new CancellationTokenSource();
		var source = new TrackedSequence(4) { BeforeYield = cancellation.Cancel };
		await Assert.ThrowsExactlyAsync<OperationCanceledException>(() => new TestBenchmark().ConsumeAsyncEnumerableAsync(source.ReadAsync(), cancellation.Token)).ConfigureAwait(false);
		Assert.AreEqual((1, true), (source.EnumeratedCount, source.Disposed));
	}

	[TestMethod]
	public async Task ConsumeAsyncEnumerableAsyncSourceFailurePropagatesAndDisposes()
	{
		var failure = new InvalidOperationException();
		var source = new TrackedSequence(1) { BeforeYield = () => throw failure };
		var actual = await Assert.ThrowsExactlyAsync<InvalidOperationException>(() => new TestBenchmark().ConsumeAsyncEnumerableAsync(source.ReadAsync())).ConfigureAwait(false);
		Assert.AreEqual((failure, true), (actual, source.Disposed));
	}

	[TestMethod]
	public async Task ConsumeAsyncEnumerableAsyncDisposalFailurePropagates()
	{
		var failure = new InvalidOperationException();
		var source = new TrackedSequence(0) { OnDispose = () => throw failure };
		var actual = await Assert.ThrowsExactlyAsync<InvalidOperationException>(() => new TestBenchmark().ConsumeAsyncEnumerableAsync(source.ReadAsync())).ConfigureAwait(false);
		Assert.AreSame(failure, actual);
	}

	[TestMethod]
	public async Task GlobalSetupAsyncDefaultHookInitializesBaseFixtures()
	{
		var benchmark = new TestBenchmark();
		await benchmark.GlobalSetupAsync().ConfigureAwait(false);
		Assert.IsNotNull(benchmark.PersonRef01);
	}

	[TestMethod]
	public async Task GlobalSetupAsyncAsyncOverrideRunsBothHooksOnceInOrder()
	{
		var benchmark = new LifecycleBenchmark();
		await benchmark.GlobalSetupAsync().ConfigureAwait(false);
		Assert.AreEqual("setup,setup-async", string.Join(',', benchmark.Events));
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncAsyncOverrideRunsBothHooksOnceInOrder()
	{
		var benchmark = new LifecycleBenchmark();
		await benchmark.GlobalCleanupAsync().ConfigureAwait(false);
		Assert.AreEqual("cleanup,cleanup-async", string.Join(',', benchmark.Events));
	}

	[TestMethod]
	public void GlobalSetupManualCallerRunsOnlySynchronousHook()
	{
		var benchmark = new LifecycleBenchmark();
		benchmark.GlobalSetup();
		Assert.AreEqual("setup", string.Join(',', benchmark.Events));
	}

	[TestMethod]
	public void GlobalCleanupManualCallerRunsOnlySynchronousHook()
	{
		var benchmark = new LifecycleBenchmark();
		benchmark.GlobalCleanup();
		Assert.AreEqual("cleanup", string.Join(',', benchmark.Events));
	}

	[TestMethod]
	public async Task GlobalSetupAsyncPendingOverrideDoesNotCompleteEarly()
	{
		var completion = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
		var benchmark = new LifecycleBenchmark { SetupCompletion = completion.Task };
		var setup = benchmark.GlobalSetupAsync();
		var completedEarly = setup.IsCompleted;
		completion.SetResult();
		await setup.ConfigureAwait(false);
		Assert.IsFalse(completedEarly);
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncPendingOverrideDoesNotCompleteEarly()
	{
		var completion = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
		var benchmark = new LifecycleBenchmark { CleanupCompletion = completion.Task };
		var cleanup = benchmark.GlobalCleanupAsync();
		var completedEarly = cleanup.IsCompleted;
		completion.SetResult();
		await cleanup.ConfigureAwait(false);
		Assert.IsFalse(completedEarly);
	}

	[TestMethod]
	public async Task GlobalSetupAsyncFailingOverridePropagatesException()
	{
		var failure = new InvalidOperationException();
		var benchmark = new LifecycleBenchmark { SetupCompletion = Task.FromException(failure) };
		var actual = await Assert.ThrowsExactlyAsync<InvalidOperationException>(benchmark.GlobalSetupAsync).ConfigureAwait(false);
		Assert.AreSame(failure, actual);
	}

	[TestMethod]
	public void GlobalSetupAttributeBaseClassUsesOnlyAsyncEntryPoint()
	{
		var methods = typeof(Benchmark).GetMethods().Where(method => method.IsDefined(typeof(GlobalSetupAttribute)));
		CollectionAssert.AreEqual(new[] { nameof(Benchmark.GlobalSetupAsync) }, methods.Select(method => method.Name).ToArray());
	}

	[TestMethod]
	public void GlobalCleanupAttributeBaseClassUsesOnlyAsyncEntryPoint()
	{
		var methods = typeof(Benchmark).GetMethods().Where(method => method.IsDefined(typeof(GlobalCleanupAttribute)));
		CollectionAssert.AreEqual(new[] { nameof(Benchmark.GlobalCleanupAsync) }, methods.Select(method => method.Name).ToArray());
	}

	[TestMethod]
	public void CreateTemporaryDirectoryRepeatedCallsCreateDistinctExistingDirectories()
	{
		var benchmark = new TestBenchmark();
		var first = benchmark.CreateTemporaryDirectory();
		var second = benchmark.CreateTemporaryDirectory();
		Console.WriteLine(first.FullName);
		Console.WriteLine(second.FullName);
		var result = (first.Exists, second.Exists, first.FullName == second.FullName);
		benchmark.GlobalCleanup();
		Assert.AreEqual((true, true, false), result);
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncTrackedDirectoryRemovesContentsRecursively()
	{
		var benchmark = new TestBenchmark();
		var directory = benchmark.CreateTemporaryDirectory();
		Console.WriteLine(directory.FullName);
		var child = Directory.CreateDirectory(Path.Combine(directory.FullName, RandomData.GenerateKey()));
		await File.WriteAllBytesAsync(Path.Combine(child.FullName, RandomData.GenerateKey()), RandomData.GenerateByteArray(8)).ConfigureAwait(false);
		await benchmark.GlobalCleanupAsync().ConfigureAwait(false);
		Assert.IsFalse(Directory.Exists(directory.FullName));
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncAnotherInstanceDoesNotDeleteUnownedDirectory()
	{
		var owner = new TestBenchmark();
		var directory = owner.CreateTemporaryDirectory();
		Console.WriteLine(directory.FullName);
		await new TestBenchmark().GlobalCleanupAsync().ConfigureAwait(false);
		var stillExists = Directory.Exists(directory.FullName);
		await owner.GlobalCleanupAsync().ConfigureAwait(false);
		Assert.IsTrue(stillExists);
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncAlreadyRemovedDirectoryIsRepeatable()
	{
		var benchmark = new TestBenchmark();
		var directory = benchmark.CreateTemporaryDirectory();
		Console.WriteLine(directory.FullName);
		directory.Delete();
		await benchmark.GlobalCleanupAsync().ConfigureAwait(false);
		await benchmark.GlobalCleanupAsync().ConfigureAwait(false);
		Assert.IsFalse(Directory.Exists(directory.FullName));
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncFailingHookStillDeletesTrackedDirectories()
	{
		var failure = new InvalidOperationException();
		var benchmark = new LifecycleBenchmark { CleanupCompletion = Task.FromException(failure) };
		var directory = benchmark.CreateTemporaryDirectory();
		Console.WriteLine(directory.FullName);
		var actual = await Assert.ThrowsExactlyAsync<InvalidOperationException>(benchmark.GlobalCleanupAsync).ConfigureAwait(false);
		Assert.AreEqual((failure, false), (actual, Directory.Exists(directory.FullName)));
	}

	[TestMethod]
	public void GlobalCleanupFailingHookStillDeletesTrackedDirectories()
	{
		var failure = new InvalidOperationException();
		var benchmark = new LifecycleBenchmark { CleanupAction = () => throw failure };
		var directory = benchmark.CreateTemporaryDirectory();
		Console.WriteLine(directory.FullName);
		var actual = Assert.ThrowsExactly<InvalidOperationException>(benchmark.GlobalCleanup);
		Assert.AreEqual((failure, false), (actual, Directory.Exists(directory.FullName)));
	}

	private sealed class TestBenchmark : Benchmark;

	private sealed class LifecycleBenchmark : Benchmark
	{
		public List<string> Events { get; } = [];
		public Task SetupCompletion { get; init; } = Task.CompletedTask;
		public Task CleanupCompletion { get; init; } = Task.CompletedTask;
		public Action CleanupAction { get; init; } = () => { };

		public override void Setup()
		{
			this.Events.Add("setup");
		}

		public override async Task SetupAsync()
		{
			await base.SetupAsync().ConfigureAwait(false);
			await this.SetupCompletion.ConfigureAwait(false);
			this.Events.Add("setup-async");
		}

		public override void Cleanup()
		{
			this.CleanupAction();
			this.Events.Add("cleanup");
		}

		public override async Task CleanupAsync()
		{
			await base.CleanupAsync().ConfigureAwait(false);
			await this.CleanupCompletion.ConfigureAwait(false);
			this.Events.Add("cleanup-async");
		}
	}

	private sealed class TrackedSequence(int count)
	{
		public int EnumeratedCount { get; private set; }
		public bool Disposed { get; private set; }
		public bool Started { get; private set; }
		public CancellationToken ObservedToken { get; private set; }
		public Action BeforeYield { get; init; } = () => { };
		public Action OnDispose { get; init; } = () => { };

		public async IAsyncEnumerable<int> ReadAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
		{
			this.Started = true;
			this.ObservedToken = cancellationToken;
			try
			{
				for (var itemIndex = 0; itemIndex < count; itemIndex++)
				{
					await Task.Yield();
					this.EnumeratedCount++;
					this.BeforeYield();
					yield return itemIndex;
				}
			}
			finally
			{
				this.Disposed = true;
				this.OnDispose();
			}
		}
	}
}
