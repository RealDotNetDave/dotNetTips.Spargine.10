// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking.Tests
// Author           : Copilot Agent
// Created          : 09-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-27-2026
// ***********************************************************************
// <copyright file="BenchmarkTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for Benchmark public API members excluding methods marked with UnitTestStatus.NotRequired.
// </summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using ValuePerson = DotNetTips.Spargine.Tester.Models.ValueTypes.Person;

namespace DotNetTips.Spargine.Benchmarking.Tests;

[TestClass]
[ExcludeFromCodeCoverage]
public sealed class BenchmarkTests
{
	private const int FixtureLength = 64;
	private const int FixtureSeed = 42;

	[TestMethod]
	public async Task CleanupAsyncReturnsCompletedTask()
	{
		var task = new TestBenchmark().CleanupAsync();
		await task.ConfigureAwait(false);
		Assert.IsTrue(task.IsCompletedSuccessfully);
	}

	[TestMethod]
	public void ClearDataCachesExistingByteFixtureRecreatesArrayWithSameSeededContents()
	{
		var benchmark = new TestBenchmark { DataSeed = FixtureSeed };
		var previous = benchmark.GetByteArray(FixtureLength);
		benchmark.ClearDataCaches();
		var current = benchmark.GetByteArray(FixtureLength);
		Assert.AreEqual((false, true), (ReferenceEquals(previous, current), previous.SequenceEqual(current)));
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
	public void ConstantFieldsMatchExpectedValues()
	{
		Assert.AreEqual(("john doe", "John Doe", "JOHN DOE"), (Benchmark.LowerCaseString, Benchmark.ProperCaseString, Benchmark.UpperCaseString));
		Assert.AreEqual(("2ds9JiOtNF", "ndA5nJSHnU"), (Benchmark.String10Characters01, Benchmark.String10Characters02));
		Assert.AreEqual(("C8IIVjaUi0owZh6", "Q7sXguwS9vZpOo6"), (Benchmark.String15Characters01, Benchmark.String15Characters02));
		Assert.AreEqual(("fake@fakelive.com", "Fake@FakeLive.com"), (Benchmark.TestEmailLowerCase, Benchmark.TestEmailMixedCase));
		Assert.AreEqual(("failed", "success"), (TestBenchmark.ExposeFailedText(), TestBenchmark.ExposeSuccessText()));
	}

	[TestMethod]
	public void ConsumeAcceptsObject()
	{
		new TestBenchmark().Consume(new object());
	}

	[TestMethod]
	public async Task ConsumeAsyncEnumerableAsyncNullSourceThrowsArgumentNullException()
	{
		var benchmark = new TestBenchmark();
		var exception = await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => benchmark.ConsumeAsyncEnumerableAsync<int>(null!)).ConfigureAwait(false);
		Assert.AreEqual("source: ", exception.ParamName);
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
	[DataRow(0)]
	[DataRow(4)]
	public async Task ConsumeAsyncEnumerableAsyncSequenceEnumeratesAndDisposes(int count)
	{
		var source = new TrackedSequence(count);
		await new TestBenchmark().ConsumeAsyncEnumerableAsync(source.ReadAsync()).ConfigureAwait(false);
		Assert.AreEqual((count, true), (source.EnumeratedCount, source.Disposed));
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
	public async Task ConsumeAsyncEnumerableAsyncTokenIsForwardedToSource()
	{
		using var cancellation = new CancellationTokenSource();
		var source = new TrackedSequence(1);
		await new TestBenchmark().ConsumeAsyncEnumerableAsync(source.ReadAsync(), cancellation.Token).ConfigureAwait(false);
		Assert.AreEqual(cancellation.Token, source.ObservedToken);
	}

	[TestMethod]
	public async Task ConsumeAsyncReturnsCompletedTask()
	{
		var task = new TestBenchmark().ConsumeAsync(new object());
		await task.ConfigureAwait(false);
		Assert.IsTrue(task.IsCompletedSuccessfully);
	}

	[TestMethod]
	public void ConsumeCollectionAcceptsList()
	{
		new TestBenchmark().ConsumeCollection(new List<int> { 1, 2, 3 });
	}

	[TestMethod]
	public void ConsumeCollectionNullThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => new TestBenchmark().ConsumeCollection<string>(null!));
		Assert.AreEqual("collection: ", exception.ParamName);
	}

	[TestMethod]
	public void ConsumeDictionaryAcceptsDictionary()
	{
		new TestBenchmark().ConsumeDictionary(new Dictionary<int, string> { [1] = "a", [2] = "b" });
	}

	[TestMethod]
	public void ConsumeEnumerableAcceptsSequence()
	{
		new TestBenchmark().ConsumeEnumerable(Enumerable.Range(1, 5));
	}

	[TestMethod]
	public void ConsumeEnumerableNullThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => new TestBenchmark().ConsumeEnumerable<string>(null!));
		Assert.AreEqual("collection: ", exception.ParamName);
	}

	[TestMethod]
	public void ConsumeReadOnlySpanAcceptsSpan()
	{
		new TestBenchmark().ConsumeReadOnlySpan<int>([1, 2, 3]);
	}

	[TestMethod]
	public void ConsumeSpanAcceptsSpan()
	{
		Span<int> data = [1, 2, 3];
		new TestBenchmark().ConsumeSpan(data);
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
	public void CreateTemporaryDirectoryRepeatedCallsCreateDistinctExistingDirectories()
	{
		var benchmark = new TestBenchmark();
		var first = benchmark.CreateTemporaryDirectory();
		var second = benchmark.CreateTemporaryDirectory();
		var result = (first.Exists, second.Exists, first.FullName == second.FullName);
		benchmark.GlobalCleanup();
		Assert.AreEqual((true, true, false), result);
	}

	[TestMethod]
	public void DataSeedDefaultIsNull()
	{
		Assert.IsNull(new TestBenchmark().DataSeed);
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
	public void GetByteArrayByLengthNegativeCountThrowsArgumentOutOfRangeException()
	{
		var benchmark = new TestBenchmark();
		var exception = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => benchmark.GetByteArrayByLength(-1));
		Assert.AreEqual("byteCount", exception.ParamName);
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
	[DataRow(0)]
	[DataRow(-1)]
	public void GetByteArrayNonpositiveCountThrowsArgumentOutOfRangeException(int count)
	{
		var benchmark = new TestBenchmark();
		var exception = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => benchmark.GetByteArray(count));
		Assert.AreEqual("count", exception.ParamName);
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
	public void GetStringArrayUnrepresentableMinimumThrowsArgumentOutOfRangeException()
	{
		var benchmark = new TestBenchmark();
		var exception = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => benchmark.GetStringArray(1, int.MaxValue));
		Assert.AreEqual("wordMinLength", exception.ParamName);
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncAlreadyRemovedDirectoryIsRepeatable()
	{
		var benchmark = new TestBenchmark();
		var directory = benchmark.CreateTemporaryDirectory();
		directory.Delete();
		await benchmark.GlobalCleanupAsync().ConfigureAwait(false);
		await benchmark.GlobalCleanupAsync().ConfigureAwait(false);
		Assert.IsFalse(Directory.Exists(directory.FullName));
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncAnotherInstanceDoesNotDeleteUnownedDirectory()
	{
		var owner = new TestBenchmark();
		var directory = owner.CreateTemporaryDirectory();
		await new TestBenchmark().GlobalCleanupAsync().ConfigureAwait(false);
		var stillExists = Directory.Exists(directory.FullName);
		await owner.GlobalCleanupAsync().ConfigureAwait(false);
		Assert.IsTrue(stillExists);
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncFailingHookStillDeletesTrackedDirectories()
	{
		var failure = new InvalidOperationException();
		var benchmark = new LifecycleBenchmark { CleanupCompletion = Task.FromException(failure) };
		var directory = benchmark.CreateTemporaryDirectory();
		var actual = await Assert.ThrowsExactlyAsync<InvalidOperationException>(benchmark.GlobalCleanupAsync).ConfigureAwait(false);
		Assert.AreEqual((failure, false), (actual, Directory.Exists(directory.FullName)));
	}

	[TestMethod]
	public async Task GlobalCleanupAsyncTrackedDirectoryRemovesContentsRecursively()
	{
		var benchmark = new TestBenchmark();
		var directory = benchmark.CreateTemporaryDirectory();
		var child = Directory.CreateDirectory(Path.Combine(directory.FullName, RandomData.GenerateKey()));
		await File.WriteAllBytesAsync(Path.Combine(child.FullName, RandomData.GenerateKey()), RandomData.GenerateByteArray(8)).ConfigureAwait(false);
		await benchmark.GlobalCleanupAsync().ConfigureAwait(false);
		Assert.IsFalse(Directory.Exists(directory.FullName));
	}

	[TestMethod]
	public void GlobalCleanupFailingHookStillDeletesTrackedDirectories()
	{
		var failure = new InvalidOperationException();
		var benchmark = new LifecycleBenchmark { CleanupAction = () => throw failure };
		var directory = benchmark.CreateTemporaryDirectory();
		var actual = Assert.ThrowsExactly<InvalidOperationException>(benchmark.GlobalCleanup);
		Assert.AreEqual((failure, false), (actual, Directory.Exists(directory.FullName)));
	}

	[TestMethod]
	public void LaunchDebuggerPropertyRoundTrips()
	{
		var benchmark = new TestBenchmark();
		benchmark.LaunchDebugger = true;
		Assert.IsTrue(benchmark.LaunchDebugger);
	}

	[TestMethod]
	public void ProtectedLoggingHelpersCanBeInvoked()
	{
		var errorMessage = RandomData.GenerateWord(8);
		var infoMessage = RandomData.GenerateWord(8);
		var warningMessage = RandomData.GenerateWord(8);
		var message = RandomData.GenerateWord(8);
		TestBenchmark.ExposeLogError(errorMessage);
		TestBenchmark.ExposeLogInfo(infoMessage);
		TestBenchmark.ExposeLogWarning(warningMessage);
		TestBenchmark.ExposeLogMessage(LogKind.Info, message);
	}

	[TestMethod]
	public void LogErrorNullMessageThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => TestBenchmark.ExposeLogError(null!));
		Assert.AreEqual("message: ", exception.ParamName);
	}

	[TestMethod]
	public void LogInfoNullMessageThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => TestBenchmark.ExposeLogInfo(null!));
		Assert.AreEqual("message: ", exception.ParamName);
	}

	[TestMethod]
	public void LogMessageNullMessageThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => TestBenchmark.ExposeLogMessage(LogKind.Info, null!));
		Assert.AreEqual("message: ", exception.ParamName);
	}

	[TestMethod]
	public void LogWarningNullMessageThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => TestBenchmark.ExposeLogWarning(null!));
		Assert.AreEqual("message: ", exception.ParamName);
	}

	[TestMethod]
	public async Task SetupAsyncInitializesPublicDataProperties()
	{
		var benchmark = new TestBenchmark();
		await benchmark.SetupAsync().ConfigureAwait(false);
		Assert.AreNotEqual(Guid.Empty, benchmark.TestGuid);
	}

	[TestMethod]
	public void SetupInitializesPublicDataProperties()
	{
		var benchmark = new TestBenchmark();
		benchmark.Setup();

		Assert.IsTrue(benchmark.Base64String.Length > 0);
		Assert.IsNotNull(benchmark.CoordinateRef01);
		Assert.IsNotNull(benchmark.CoordinateRef02);
		Assert.AreNotEqual(default, benchmark.CoordinateVal01);
		Assert.AreNotEqual(default, benchmark.CoordinateVal02);
		Assert.IsNotNull(benchmark.PersonRecord01);
		Assert.IsNotNull(benchmark.PersonRecord02);
		Assert.IsNotNull(benchmark.PersonRef01);
		Assert.IsNotNull(benchmark.PersonRef02);
		Assert.AreNotEqual(default, benchmark.PersonVal01);
		Assert.AreNotEqual(default, benchmark.PersonVal02);
		Assert.AreNotEqual(Guid.Empty, benchmark.TestGuid);
		Assert.IsTrue(benchmark.StringToTrim.StartsWith(' '));
		Assert.IsTrue(benchmark.StringToTrim.EndsWith(' '));
		_ = benchmark.TestBoolean;
		Assert.IsTrue(benchmark.TestCompanyName.Length > 0);
		Assert.IsTrue(benchmark.TestCurrencyAmount >= decimal.Zero);
		Assert.IsTrue(benchmark.TestDateOnly >= new DateOnly(2000, 1, 1));
		Assert.IsTrue(benchmark.TestDateTimeOffset.Year >= 2000);
		Assert.IsTrue(Enum.IsDefined(benchmark.TestDayOfWeek));
		Assert.IsTrue(benchmark.TestHashString.Length > 0);
		Assert.IsTrue(benchmark.TestSentence.Length > 0);
		Assert.IsTrue(benchmark.LongTestString.Length > 0);
		Assert.IsTrue(benchmark.TestTimeOnly >= TimeOnly.MinValue);
		Assert.IsTrue(benchmark.TestTimeSpan >= TimeSpan.Zero);
		Assert.IsTrue(IPAddress.TryParse(benchmark.TestIPv4Address, out _));
		Assert.IsTrue(IPAddress.TryParse(benchmark.TestIPv6Address, out _));
	}

	[TestMethod]
	public async Task SimulateWorkAsyncPreCanceledTokenThrowsOperationCanceledException()
	{
		using var cancellation = new CancellationTokenSource();
		await cancellation.CancelAsync().ConfigureAwait(false);
		await Assert.ThrowsExactlyAsync<OperationCanceledException>(() => new TestBenchmark().SimulateWorkAsync(new object(), cancellation.Token)).ConfigureAwait(false);
	}

	[TestMethod]
	public async Task SimulateWorkAsyncReturnsCompletedTask()
	{
		var task = new TestBenchmark().SimulateWorkAsync(new object());
		await task.ConfigureAwait(false);
		Assert.IsTrue(task.IsCompletedSuccessfully);
	}

	[TestMethod]
	public void SimulateWorkReturnsRuntimeHashCode()
	{
		var item = new object();
		Assert.AreEqual(RuntimeHelpers.GetHashCode(item), Benchmark.SimulateWork(item));
	}

	[TestMethod]
	public void StaticDataPropertiesReturnContent()
	{
		Assert.IsTrue(Benchmark.JsonTestDataPerson.Length > 0);
		Assert.IsTrue(Benchmark.JsonTestDataPersonRecord.Length > 0);
		Assert.IsTrue(Benchmark.PersonXml.Length > 0);
		Assert.IsTrue(Benchmark.PersonRecordXml.Length > 0);
	}

	[TestMethod]
	public void UpdateCoordinateNullThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => new TestBenchmark().Update<Coordinate>(null!));
		Assert.AreEqual("coordinate: ", exception.ParamName);
	}

	[TestMethod]
	public void UpdateCoordinateSetsXToExpectedValue()
	{
		var coordinate = RandomData.GenerateCoordinate<Coordinate>();
		Assert.AreEqual(100, new TestBenchmark().Update(coordinate).X);
	}

	[TestMethod]
	public void UpdatePersonNullThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => new TestBenchmark().Update((Person)null!));
		Assert.AreEqual("person: ", exception.ParamName);
	}

	[TestMethod]
	public void UpdatePersonRecordNullThrowsArgumentNullException()
	{
		var exception = Assert.ThrowsExactly<ArgumentNullException>(() => new TestBenchmark().Update((PersonRecord)null!));
		Assert.AreEqual("person: ", exception.ParamName);
	}

	[TestMethod]
	public void UpdatePersonRecordReturnsNewRecordWithUpdatedPhone()
	{
		var person = RandomData.GeneratePerson<PersonRecord>();
		var updated = new TestBenchmark().Update(person);
		Assert.AreEqual((false, "555-867-5309"), (ReferenceEquals(person, updated), updated.CellPhone));
	}

	[TestMethod]
	public void UpdatePersonSetsPhoneNumber()
	{
		var person = RandomData.GeneratePerson<Person>();
		Assert.AreEqual("555-867-5309", new TestBenchmark().Update(person).CellPhone);
	}

	[TestMethod]
	public void UpdateValueTypePersonSetsPhoneNumber()
	{
		var person = RandomData.GeneratePerson<ValuePerson>();
		Assert.AreEqual("555-867-5309", new TestBenchmark().Update(person).CellPhone);
	}

	private sealed class LifecycleBenchmark : Benchmark
	{
		public Action CleanupAction { get; init; } = () => { };
		public Task CleanupCompletion { get; init; } = Task.CompletedTask;

		public override void Cleanup()
		{
			this.CleanupAction();
		}

		public override async Task CleanupAsync()
		{
			await base.CleanupAsync().ConfigureAwait(false);
			await this.CleanupCompletion.ConfigureAwait(false);
		}
	}

	private sealed class TestBenchmark : Benchmark
	{
		public static string ExposeFailedText() => FailedText;
		public static void ExposeLogError(string message) => LogError(message);
		public static void ExposeLogInfo(string message) => LogInfo(message);
		public static void ExposeLogMessage(LogKind logKind, string message) => LogMessage(logKind, message);
		public static void ExposeLogWarning(string message) => LogWarning(message);
		public static string ExposeSuccessText() => SuccessText;
	}

	private sealed class TrackedSequence(int count)
	{
		public Action BeforeYield { get; init; } = () => { };
		public bool Disposed { get; private set; }
		public int EnumeratedCount { get; private set; }
		public CancellationToken ObservedToken { get; private set; }
		public bool Started { get; private set; }

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
			}
		}
	}
}
