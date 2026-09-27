// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 09-27-2026
// ***********************************************************************
// <copyright file="Benchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Abstract base class for all BenchmarkDotNet benchmarks, providing
// setup/cleanup lifecycle methods, consume helpers for preventing dead-code
// elimination, seeded fixture caches, safe buffer copies, test entity update
// methods, asynchronous lifecycle and stream consumption, tracked temporary
// directories, and default BenchmarkDotNet diagnostic attributes.
// </summary>
// ***********************************************************************

using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using DotNetTips.Spargine.Benchmarking.Properties;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.Common;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Provides an abstract base for benchmark tests, including setup and cleanup routines, 
/// methods for consuming objects, generating random data, and updating test entities. 
/// It also includes properties for accessing various test data and configurations.
/// Additional BenchmarkDotNet attributes can be added as needed.[AsciiDocExporter],
/// [Atlassian], [ConcurrencyVisualizerProfiler], [CsvMeasurementsExporter], [Full],
/// [GitHub], [HardwareCounters], [HtmlExporter], [KurtosisColumn], [LogicalGroupColumn],
/// [MemoryDiagnoser], [MValueColumn] [NamespaceColumn], [NativeMemoryProfiler],
/// [PlainExporter], [RankColumn], [SkewnessColumn], [StatisticalTestColumn], [StackOverflow],
/// [TailCallDiagnoser], [ThreadingDiagnoser]
/// Note: [MemoryDiagnoser] was removed from base class since it was causing issues with benchmark tests. 
/// </summary>
[AllStatisticsColumn]
[BaselineColumn]
[CategoriesColumn]
[ConfidenceIntervalErrorColumn]
[CsvExporter]
[DisassemblyDiagnoser(printSource: true, exportGithubMarkdown: true, exportCombinedDisassemblyReport: true, exportDiff: true, exportHtml: true)]
[EvaluateOverhead]
[ExceptionDiagnoser]
[GcServer(true)]
[InliningDiagnoser(logFailuresOnly: true, filterByNamespace: true)]
[IterationsColumn]
[JsonExporter(indentJson: true)]
[Orderer(SummaryOrderPolicy.Method, methodOrderPolicy: MethodOrderPolicy.Alphabetical)]
[StopOnFirstError(true)]
[Information(Documentation = "https://bit.ly/BenchmarkLikeDotNetDave", Status = Status.Available)]
public abstract class Benchmark
{

	/// <summary>
	/// A lowercase string for testing purposes.
	/// </summary>
	public const string LowerCaseString = "john doe";

	/// <summary>
	/// A proper case string for testing purposes.
	/// </summary>
	public const string ProperCaseString = "John Doe";

	/// <summary>
	/// A 10-character string for testing purposes.
	/// </summary>
	public const string String10Characters01 = "2ds9JiOtNF";

	/// <summary>
	/// A 10-character string for testing purposes.
	/// </summary>
	public const string String10Characters02 = "ndA5nJSHnU";

	/// <summary>
	/// A 15-character string for testing purposes.
	/// </summary>
	public const string String15Characters01 = "C8IIVjaUi0owZh6";

	/// <summary>
	/// A 15-character string for testing purposes.
	/// </summary>
	public const string String15Characters02 = "Q7sXguwS9vZpOo6";

	/// <summary>
	/// A test email address in lowercase.
	/// </summary>
	public const string TestEmailLowerCase = "fake@fakelive.com";

	/// <summary>
	/// A test email address in mixed case for testing purposes.
	/// </summary>
	public const string TestEmailMixedCase = "Fake@FakeLive.com";

	/// <summary>
	/// An uppercase string for testing purposes.
	/// </summary>
	public const string UpperCaseString = "JOHN DOE";

	/// <summary>
	/// Text indicating a failed operation or status.
	/// </summary>
	protected const string FailedText = "failed";

	/// <summary>
	/// Text indicating a successful operation or status.
	/// </summary>
	protected const string SuccessText = "success";

	/// <summary>
	/// Log message emitted by <see cref="Cleanup"/>.
	/// </summary>
	private const string CleanupLogMessage = $"Cleanup(): {nameof(Benchmark)}.";

	/// <summary>
	/// Resource key for the message emitted when launching the debugger.
	/// </summary>
	private const string LaunchingDebuggerLogMessage = nameof(LaunchingDebuggerLogMessage);

	/// <summary>
	/// Fake phone number.
	/// </summary>
	private const string PhoneNumberUpdate = "555-867-5309";

	/// <summary>
	/// Log message emitted by <see cref="Setup"/>.
	/// </summary>
	private const string SetupLogMessage = $"Setup(): {nameof(Benchmark)}.";

	/// <summary>
	/// Retains private byte fixtures and separate mutable arrays exposed to callers.
	/// </summary>
	private readonly ConcurrentDictionary<(int Count, int? Seed), (byte[] Source, byte[] Value)> _byteArrayCache = new();

	/// <summary>
	/// Retains private string fixtures and separate mutable arrays exposed to callers.
	/// </summary>
	private readonly ConcurrentDictionary<(int Count, int MinLength, int MaxLength, int? Seed), (string[] Source, string[] Value)> _stringArrayCache = new();

	/// <summary>
	/// Paths created by this instance, retained until successfully removed during global cleanup.
	/// </summary>
	private readonly List<string> _temporaryDirectories = [];

	/// <summary>
	/// The optional seed for byte and string fixtures.
	/// </summary>
	private int? _dataSeed;

	/// <summary>
	/// Initializes a new instance of the <see cref="Benchmark"/> class.
	/// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
	protected Benchmark()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
	{
	}

	/// <summary>
	/// Retrieve JSON from resources for a Person object.
	/// </summary>
	/// <value>The JSON test data for a item.</value>
	public static string JsonTestDataPerson => Resources.JsonTestDataPerson;

	/// <summary>
	/// Retrieve the JSON representation of a <see cref="PersonRecord" /> object from the resources.
	/// This property provides access to the JSON data used for testing and benchmarking purposes.
	/// </summary>
	/// <value>The JSON test data for a PersonRecord.</value>
	public static string JsonTestDataPersonRecord => Resources.JsonTestDataPersonRecord;

	/// <summary>
	/// Retrieve the XML representation of a <see cref="PersonRecord" /> object from the resources.
	/// This property provides access to the XML data used for testing and benchmarking purposes.
	/// </summary>
	/// <value>The item record XML.</value>
	public static string PersonRecordXml => Resources.XmlTestDataPersonRecord;

	/// <summary>
	/// Retrieve the XML representation of a IPerson object from the resources.
	/// This property provides access to the XML data used for testing and benchmarking purposes.
	/// </summary>
	/// <value>The item XML.</value>
	public static string PersonXml => Resources.XmlTestDataPerson;

	/// <summary>
	/// Gets or sets the Base64 encoded string. This property is used to store a Base64 encoded version of a test string for benchmarking purposes.
	/// </summary>
	/// <value>The Base64 encoded string.</value>
	public string Base64String { get; internal set; }

	/// <summary>
	/// Gets the first coordinate object generated during startup for use in testing.
	/// </summary>
	/// <value>The first coordinate object.</value>
	public Coordinate CoordinateRef01 { get; private set; }

	/// <summary>
	/// Gets the second coordinate object generated during startup for use in testing.
	/// </summary>
	/// <value>The second coordinate object.</value>
	public Coordinate CoordinateRef02 { get; private set; }

	/// <summary>
	/// Retrieves a random coordinate generated during startup for use in testing.
	/// </summary>
	/// <value>The first coordinate object.</value>
	public Tester.Models.ValueTypes.Coordinate CoordinateVal01 { get; private set; }

	/// <summary>
	/// Retrieves a random coordinate generated during startup.
	/// </summary>
	/// <value>The second coordinate object.</value>
	public Tester.Models.ValueTypes.Coordinate CoordinateVal02 { get; private set; }

	/// <summary>
	/// Gets or sets the optional seed used by byte and string fixture helpers.
	/// </summary>
	/// <value>A seed for reproducible, noncryptographic fixtures, or <c>null</c> for random fixtures.</value>
	/// <remarks>
	/// Changing the seed clears the fixture caches. Configure it during setup, not concurrently with
	/// fixture access. The same seed and arguments reproduce data on the same runtime independently
	/// of call order. Other fixtures, including people, are unaffected. Reproducibility across runtime
	/// versions is not guaranteed. Previously returned arrays are not changed.
	/// </remarks>
	[Information(nameof(DataSeed), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public int? DataSeed
	{
		get
		{
			return this._dataSeed;
		}
		set
		{
			if (this._dataSeed == value)
			{
				return;
			}

			this._dataSeed = value;
			this.ClearDataCaches();
		}
	}

	/// <summary>
	/// Gets or sets a value indicating whether the debugger should be launched at the start of the benchmarking session.
	/// This can be useful for debugging benchmark code. When set to <c>true</c>, the debugger is launched.
	/// </summary>
	/// <value><c>true</c> if the debugger should be launched; otherwise, <c>false</c>.</value>
	public bool LaunchDebugger { get; set; }

	/// <summary>
	/// Retrieves a long test string (969 characters) used for benchmarking parsing and formatting operations.
	/// This string is designed to simulate real-world text processing tasks, including parsing,
	/// manipulation, and output formatting. It reflects the performance improvements achieved
	/// through the transition of native code to managed code in .NET Core 2.1 and beyond.
	/// </summary>
	/// <value>A long test string.</value>
	public string LongTestString { get; } = "Parsing and formatting are the lifeblood of any modern web app or service: take data off the wire, parse it, manipulate it, format it back out. As such, in .NET Core 2.1 along with bringing up Span<T>, we invested in the formatting and parsing of primitives, from Int32 to DateTime. Many of those changes can be read about in my previous blog posts, but one of the key factors in enabling those performance improvements was in moving a lot of native code to managed. That may be counter-intuitive, in that it’s “common knowledge” that C code is faster than C# code. However, in addition to the gap between them narrowing, having (mostly) safe C# code has made the code base easier to experiment in, so whereas we may have been skittish about tweaking the native implementations, the community-at-large has dived head first into optimizing these implementations wherever possible. That effort continues in full force in .NET Core 3.0, with some very nice rewards reaped.";

	/// <summary>
	/// Retrieves a randomly generated <see cref="PersonRecord"/> during startup for testing purposes.
	/// This property provides access to a <see cref="PersonRecord"/> instance that can be used in benchmark tests to measure performance of operations involving item records.
	/// </summary>
	/// <value>The first <see cref="PersonRecord"/> object.</value>
	public PersonRecord PersonRecord01 { get; private set; }

	/// <summary>
	/// Retrieves a randomly generated <see cref="PersonRecord"/> during startup for testing purposes.
	/// This property provides access to a <see cref="PersonRecord"/> instance that can be used in benchmark tests to measure performance of operations involving item records.
	/// </summary>
	/// <value>The second <see cref="PersonRecord"/> object.</value>
	public PersonRecord PersonRecord02 { get; private set; }

	/// <summary>
	/// Retrieves a Person{Address} reference type object for testing generated during startup.
	/// This property provides access to a Person object instance that can be used in benchmark tests to measure performance of operations involving item objects.
	/// </summary>
	/// <value>The first Person{Address} object.</value>
	public Person PersonRef01 { get; private set; }

	/// <summary>
	/// Retrieves a Person{Address} reference type object for testing generated during startup.
	/// This property provides access to a Person object instance that can be used in benchmark tests to measure performance of operations involving item objects.
	/// </summary>
	/// <value>The second Person{Address} object.</value>
	public Person PersonRef02 { get; private set; }

	/// <summary>
	/// Retrieves a Person{Address} value type object for testing generated during startup.
	/// This property provides access to a Person value type instance that can be used in benchmark tests to measure performance of operations involving item value type objects.
	/// </summary>
	/// <value>The first Person{Address} object.</value>
	public Tester.Models.ValueTypes.Person PersonVal01 { get; private set; }

	/// <summary>
	/// Retrieves a Person{Address} value type object for testing generated during startup.
	/// This property provides access to a Person value type instance that can be used in benchmark tests to measure performance of operations involving item value type objects.
	/// </summary>
	/// <value>The second Person{Address} object.</value>
	public Tester.Models.ValueTypes.Person PersonVal02 { get; private set; }

	/// <summary>
	/// Retrieve a string with spaces on both sides for testing purposes.
	/// This property is initialized during the setup phase and is used in benchmarks that require a string manipulation operation, such as trimming.
	/// </summary>
	/// <value>The string to trim.</value>
	public virtual string StringToTrim { get; private set; }

	/// <summary>
	/// Gets a random boolean value generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated <see cref="bool"/> value.</value>
	public bool TestBoolean { get; private set; }

	/// <summary>
	/// Gets a random company name generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated company name string.</value>
	public string TestCompanyName { get; private set; }

	/// <summary>
	/// Gets a random currency amount generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated <see cref="decimal"/> currency amount with 2 decimal places.</value>
	public decimal TestCurrencyAmount { get; private set; }

	/// <summary>
	/// Gets a random <see cref="DateOnly"/> value generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated <see cref="DateOnly"/> between January 1, 2000 and December 31, 2099.</value>
	public DateOnly TestDateOnly { get; private set; }

	/// <summary>
	/// Gets a random <see cref="DateTimeOffset"/> value generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated <see cref="DateTimeOffset"/> between January 1, 2000 and December 31, 2099 UTC.</value>
	public DateTimeOffset TestDateTimeOffset { get; private set; }

	/// <summary>
	/// Gets a random <see cref="DayOfWeek"/> value generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly selected <see cref="DayOfWeek"/> enum value.</value>
	public DayOfWeek TestDayOfWeek { get; private set; }

	/// <summary>
	/// Retrieves a Guid generated at startup for testing purposes.
	/// This property is used in benchmarks that require a unique identifier for each test instance.
	/// </summary>
	/// <value>The test unique identifier.</value>
	public Guid TestGuid { get; internal set; }

	/// <summary>
	/// Gets a random hexadecimal hash string generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A 32-character randomly generated hexadecimal string.</value>
	public string TestHashString { get; private set; }

	/// <summary>
	/// Gets a random IPv4 address string generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated IPv4 address string (e.g., "192.168.1.100").</value>
	public string TestIPv4Address { get; private set; }

	/// <summary>
	/// Gets a random IPv6 address string generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated IPv6 address string.</value>
	public string TestIPv6Address { get; private set; }

	/// <summary>
	/// Gets a random sentence generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated sentence string with default word count.</value>
	public string TestSentence { get; private set; }

	/// <summary>
	/// Gets a random <see cref="TimeOnly"/> value generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated <see cref="TimeOnly"/> between midnight and 23:59:59.</value>
	public TimeOnly TestTimeOnly { get; private set; }

	/// <summary>
	/// Gets a random <see cref="TimeSpan"/> value generated during setup for use in benchmark tests.
	/// </summary>
	/// <value>A randomly generated <see cref="TimeSpan"/> between <see cref="TimeSpan.Zero"/> and 365 days.</value>
	public TimeSpan TestTimeSpan { get; private set; }

	/// <summary>
	/// Gets the consumer used for consuming objects in benchmark operations.
	/// </summary>
	/// <value>The consumer instance.</value>
	private Consumer Consumer { get; } = new();

	/// <summary>
	/// Simulates work by computing the hash code of the provided item object.
	/// This method is designed for benchmarking scenarios where a consistent, 
	/// non-optimizable operation is needed to prevent the JIT compiler from eliminating code.
	/// </summary>
	/// <param name="item">The object whose hash code will be computed. Must not be null.</param>
	/// <returns>An integer hash code of the provided object, as computed by <see cref="RuntimeHelpers.GetHashCode(object)"/>.</returns>
	/// <exception cref="NullReferenceException">Thrown when <paramref name="item"/> is null despite the DisallowNullAttribute.</exception>
	/// <remarks>
	/// This method uses <see cref="RuntimeHelpers.GetHashCode"/> which provides a stable hash code
	/// for an object during the lifetime of the process, making it suitable for benchmarking operations
	/// that need to perform real work without being eliminated by compiler optimizations.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SimulateWork), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static int SimulateWork([DisallowNull] object item)
	{
		return RuntimeHelpers.GetHashCode(item);
	}

	/// <summary>
	/// Performs cleanup operations. This method should be called at the end of benchmark runs.
	/// It logs the cleanup action to the console.
	/// </summary>
	[Information(nameof(Cleanup), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public virtual void Cleanup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, CleanupLogMessage);
	}

	/// <summary>
	/// Performs asynchronous cleanup operations after all benchmark methods have run.
	/// Override this method in derived classes to provide custom asynchronous cleanup logic
	/// required for your benchmarks, such as releasing resources or saving results.
	/// The default implementation calls <see cref="Cleanup"/> once and returns a completed task.
	/// </summary>
	/// <returns>A <see cref="Task"/> representing the asynchronous cleanup operation.</returns>
	/// <remarks>Call <c>base.CleanupAsync()</c> when overriding; do not also call <see cref="Cleanup"/>.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CleanupAsync), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public virtual Task CleanupAsync()
	{
		this.Cleanup();
		return Task.CompletedTask;
	}

	/// <summary>
	/// Releases all cached byte and string fixture references.
	/// </summary>
	/// <remarks>
	/// Use during setup or cleanup, not concurrently with fixture generation. Does not force garbage
	/// collection, reset the seed, or modify arrays already returned. Seeded data can be regenerated.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ClearDataCaches), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void ClearDataCaches()
	{
		this._byteArrayCache.Clear();
		this._stringArrayCache.Clear();
	}

	/// <summary>
	/// Consumes the specified object using the Benchmark.Consumer property to prevent the JIT compiler from optimizing away the code being benchmarked.
	/// </summary>
	/// <typeparam name="T">The type of the object to consume.</typeparam>
	/// <param name="obj">The object to consume.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Consume), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void Consume<T>(T obj)
	{
		this.Consumer.Consume(obj);
	}

	/// <summary>
	/// Consumes the specified object asynchronously using the Benchmark.Consumer property to prevent the JIT compiler from optimizing away the code being benchmarked.
	/// This method performs the consume operation synchronously and returns a completed <see cref="ValueTask"/>,
	/// avoiding <see cref="Task.Run(Action)"/> overhead (closure allocation, thread pool scheduling) that would
	/// pollute <see cref="MemoryDiagnoser"/> and <see cref="ThreadingDiagnoser"/> results.
	/// </summary>
	/// <typeparam name="T">The type of the object to consume.</typeparam>
	/// <param name="obj">The object to consume.</param>
	/// <returns>A <see cref="ValueTask"/> representing the completed operation.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConsumeAsync), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public ValueTask ConsumeAsync<T>(T obj)
	{
		this.Consumer.Consume(obj);
		return ValueTask.CompletedTask;
	}

	/// <summary>
	/// Enumerates and consumes every element of an asynchronous sequence.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	/// <param name="source">The asynchronous sequence to consume.</param>
	/// <param name="cancellationToken">The token passed to enumeration and checked between elements.</param>
	/// <returns>A task that completes after enumeration and asynchronous disposal finish.</returns>
	/// <exception cref="ArgumentNullException">The source is null.</exception>
	/// <exception cref="OperationCanceledException">Cancellation is requested.</exception>
	/// <remarks>
	/// Enumeration, consumption, and disposal are part of the measured workload when called from a
	/// benchmark. Source and disposal exceptions propagate. Cancellation during a pending move requires
	/// cooperation from the source; this method does not abandon enumeration in the background.
	/// </remarks>
	[Information(nameof(ConsumeAsyncEnumerableAsync), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public async Task ConsumeAsyncEnumerableAsync<T>([DisallowNull] IAsyncEnumerable<T> source, CancellationToken cancellationToken = default)
	{
		source = source.ArgumentNotNull(paramName: nameof(source));
		cancellationToken.ThrowIfCancellationRequested();
		await foreach (var item in source.WithCancellation(cancellationToken).ConfigureAwait(false))
		{
			cancellationToken.ThrowIfCancellationRequested();
			this.Consume(item);
		}
	}
	/// <summary>
	/// Consumes each item in the specified <see cref="IReadOnlyList{T}"/> by index,
	/// avoiding enumerator allocation.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The list to consume. Must not be <c>null</c>.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConsumeCollection), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void ConsumeCollection<T>([DisallowNull] IReadOnlyList<T> collection)
	{
		collection = collection.ArgumentNotNull();

		for (var index = 0; index < collection.Count; index++)
		{
			this.Consume(collection[index]);
		}
	}

	/// <summary>
	/// Iterates over the specified <see cref="IDictionary{TKey, TValue}"/> and consumes each value using <see cref="Consume{T}(T)"/>.
	/// This helper prevents the JIT compiler from optimizing away dictionary iteration in benchmark scenarios.
	/// </summary>
	/// <typeparam name="TKey">The type of keys in the dictionary. Keys must be non-null.</typeparam>
	/// <typeparam name="TValue">The type of values stored in the dictionary.</typeparam>
	/// <param name="collection">The dictionary whose values will be consumed. Must not be <c>null</c>.</param>
	/// <remarks>
	/// This method uses a <c>foreach</c> loop to traverse the dictionary and calls <see cref="Consume{T}(T)"/> for each value.
	/// It is designed to introduce deterministic work when benchmarking dictionary-based data structures without allocations.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConsumeDictionary), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void ConsumeDictionary<TKey, TValue>([DisallowNull] IDictionary<TKey, TValue> collection) where TKey : notnull
	{
		// Cast to the concrete Dictionary type first so the compiler can use its
		// struct enumerator directly, avoiding the IEnumerator<T> boxing that
		// occurs when iterating through the IDictionary<TKey,TValue> interface.
		if (collection is Dictionary<TKey, TValue> dict)
		{
			foreach (var kvp in dict)
			{
				this.Consume(kvp.Value);
			}
		}
		else
		{
			foreach (var kvp in collection)
			{
				this.Consume(kvp.Value);
			}
		}
	}

	/// <summary>
	/// Consumes each item in the specified <see cref="IEnumerable{T}"/> sequence using the <see cref="Consume{T}(T)"/> method.
	/// </summary>
	/// <typeparam name="T">The type of the elements contained in the <paramref name="collection"/>.</typeparam>
	/// <param name="collection">
	/// The sequence of items to consume. Each element is passed to <see cref="Consume{T}(T)"/> to prevent
	/// the JIT compiler from optimizing away the code being benchmarked.
	/// </param>
	/// <remarks>
	/// This method uses a <c>foreach</c> loop to traverse the sequence and calls <see cref="Consume{T}(T)"/> for each element.
	/// It is designed to introduce deterministic work when benchmarking enumerable data structures without allocations.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConsumeEnumerable), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void ConsumeEnumerable<T>([DisallowNull] IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		// IReadOnlyList<T> covers T[], List<T>, ReadOnlyCollection<T>, ImmutableArray<T>, etc.
		// An index-based loop on a concrete list type avoids the heap-allocated
		// IEnumerator<T> that a foreach on IEnumerable<T> always produces.
		if (collection is IReadOnlyList<T> list)
		{
			for (var index = 0; index < list.Count; index++)
			{
				this.Consume(list[index]);
			}
		}
		else
		{
			foreach (var item in collection)
			{
				this.Consume(item);
			}
		}
	}

	/// <summary>
	/// Consumes each item in the specified <see cref="ReadOnlySpan{T}"/> using the <see cref="Consume{T}(T)"/> method.
	/// </summary>
	/// <typeparam name="T">The type of the elements contained in the <paramref name="span"/>.</typeparam>
	/// <param name="span">The read-only span of items to consume.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConsumeReadOnlySpan), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void ConsumeReadOnlySpan<T>(ReadOnlySpan<T> span)
	{
		foreach (var item in span)
		{
			this.Consume(item);
		}
	}

	/// <summary>
	/// Consumes each item in the specified <see cref="Span{T}"/> using the <see cref="Consume{T}(T)"/> method.
	/// </summary>
	/// <typeparam name="T">The type of the elements contained in the <paramref name="span"/>.</typeparam>
	/// <param name="span">
	/// The span of items to consume. Each element is passed to <see cref="Consume{T}(T)"/> to prevent
	/// the JIT compiler from optimizing away the code being benchmarked while avoiding additional allocations.
	/// </param>
	/// <remarks>
	/// This method uses a <c>foreach</c> loop to traverse the span and calls <see cref="Consume{T}(T)"/> for each element.
	/// It is designed to introduce deterministic work when benchmarking span-based data structures without allocations.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConsumeSpan), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public void ConsumeSpan<T>(Span<T> span)
	{
		foreach (var item in span)
		{
			this.Consume(item);
		}
	}

	/// <summary>
	/// Restores the entire destination from a private byte fixture of the same length.
	/// </summary>
	/// <param name="destination">The working buffer to fill; an empty span is allowed.</param>
	/// <remarks>
	/// Use outside measured code unless copying is the workload. The first call creates cached arrays;
	/// subsequent copies reuse them. Mutations to arrays returned by getters do not affect this source.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CopyByteArrayTo), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public void CopyByteArrayTo(Span<byte> destination)
	{
		this.GetByteFixture(destination.Length).Source.AsSpan().CopyTo(destination);
	}

	/// <summary>
	/// Restores the entire destination from a private string fixture of the same count.
	/// </summary>
	/// <param name="destination">The working array span to fill; an empty span is allowed.</param>
	/// <param name="wordMinLength">The minimum length, adjusted to at least one.</param>
	/// <param name="wordMaxLength">The maximum length, adjusted to exceed the minimum.</param>
	/// <exception cref="ArgumentOutOfRangeException">The minimum length is <see cref="int.MaxValue"/>.</exception>
	/// <remarks>Use outside measured code. Copies references to immutable strings, not the strings themselves.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CopyStringArrayTo), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public void CopyStringArrayTo(Span<string> destination, int wordMinLength = 10, int wordMaxLength = 15)
	{
		wordMinLength = wordMinLength.EnsureMinimum(1).ArgumentInRange(max: int.MaxValue - 1, paramName: nameof(wordMinLength));

		if (destination.IsEmpty)
		{
			return;
		}

		this.GetStringFixture(destination.Length, wordMinLength, wordMaxLength).Source.AsSpan().CopyTo(destination);
	}

	/// <summary>
	/// Creates a unique temporary directory owned by this benchmark instance.
	/// </summary>
	/// <returns>The new directory, whose original path is tracked for recursive global cleanup.</returns>
	/// <exception cref="IOException">The directory cannot be created.</exception>
	/// <exception cref="UnauthorizedAccessException">Creation is not permitted.</exception>
	/// <remarks>
	/// Opt in by calling during setup, not concurrently with cleanup. Global cleanup recursively deletes
	/// the created paths and their contents; do not place data that must be preserved there or move these
	/// directories. Merely constructing a benchmark performs no filesystem operations.
	/// </remarks>
	[return: NotNull]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CreateTemporaryDirectory), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public DirectoryInfo CreateTemporaryDirectory()
	{
		var directory = Directory.CreateTempSubdirectory();
		this._temporaryDirectories.Add(directory.FullName);
		return directory;
	}

	/// <summary>
	/// Retrieves a cached mutable byte array of the specified length in bytes.
	/// </summary>
	/// <param name="count">The number of bytes to generate. Must be at least one.</param>
	/// <returns>The cached mutable array for the specified length and current seed.</returns>
	/// <exception cref="ArgumentOutOfRangeException">The count is less than one.</exception>
	/// <remarks>
	/// Uses <see cref="DataSeed"/> when set. Call during setup and store the returned array in a field.
	/// Use <see cref="CopyByteArrayTo"/> to restore a working buffer from an unmodified private fixture.
	/// A separate private array is retained for each cached length, doubling retained byte-array storage.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetByteArray), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public byte[] GetByteArray(int count = 1)
	{
		count = count.ArgumentInRange(1, paramName: nameof(count));
		return this.GetByteArrayByLength(count);
	}

	/// <summary>
	/// Retrieves a cached mutable byte array with an exact length, including zero.
	/// </summary>
	/// <param name="byteCount">The nonnegative length in bytes.</param>
	/// <returns>The cached array for the length and current seed.</returns>
	/// <exception cref="ArgumentOutOfRangeException">The byte count is negative.</exception>
	/// <remarks>Shares fixtures with <see cref="GetByteArray"/>. Generate fixtures outside measured code.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetByteArrayByLength), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public byte[] GetByteArrayByLength(int byteCount)
	{
		byteCount = byteCount.ArgumentInRange(min: 0, paramName: nameof(byteCount));
		return this.GetByteFixture(byteCount).Value;
	}

	/// <summary>
	/// Retrieves a cached mutable string array using the current optional seed.
	/// </summary>
	/// <param name="count">The number of strings, adjusted to at least one.</param>
	/// <param name="wordMinLength">The minimum word length, adjusted to at least one.</param>
	/// <param name="wordMaxLength">The maximum word length, adjusted to exceed the minimum.</param>
	/// <returns>The cached mutable array of lowercase words.</returns>
	/// <exception cref="ArgumentOutOfRangeException">The minimum length is <see cref="int.MaxValue"/>.</exception>
	/// <remarks>
	/// Call during setup. A private array snapshot preserves the original string references for
	/// <see cref="CopyStringArrayTo"/>; the immutable strings themselves are shared, not duplicated.
	/// Changing returned elements does not change this private snapshot.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetStringArray), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public string[] GetStringArray(int count, int wordMinLength = 10, int wordMaxLength = 15)
	{
		return this.GetStringFixture(count, wordMinLength, wordMaxLength).Value;
	}

	/// <summary>
	/// Performs synchronous cleanup for manual callers, followed by tracked directory cleanup.
	/// </summary>
	/// <remarks>
	/// Does not invoke asynchronous overrides. BenchmarkDotNet uses <see cref="GlobalCleanupAsync"/>.
	/// Tracked directory deletion is attempted even when the cleanup hook fails. Deletion failures
	/// propagate and unsuccessful paths remain tracked for a subsequent cleanup attempt.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GlobalCleanup), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public void GlobalCleanup()
	{
		try
		{
			this.Cleanup();
		}
		finally
		{
			this.CleanupTemporaryDirectories();
		}
	}

	/// <summary>
	/// Awaits the cleanup hook and then removes this instance's tracked temporary directories.
	/// </summary>
	/// <returns>A task representing all cleanup work.</returns>
	/// <remarks>
	/// BenchmarkDotNet invokes this entry point. Override <see cref="CleanupAsync"/> or
	/// <see cref="Cleanup"/> instead. Directory cleanup is attempted even if the hook fails.
	/// </remarks>
	[GlobalCleanup]
	[Information(nameof(GlobalCleanupAsync), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Benchmark, Status = Status.Available)]
	public async Task GlobalCleanupAsync()
	{
		try
		{
			await this.CleanupAsync().ConfigureAwait(false);
		}
		finally
		{
			this.CleanupTemporaryDirectories();
		}
	}

	/// <summary>
	/// Performs synchronous setup for manual callers, optionally launching the debugger.
	/// </summary>
	/// <remarks>Does not invoke asynchronous overrides. BenchmarkDotNet uses <see cref="GlobalSetupAsync"/>.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GlobalSetup), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public void GlobalSetup()
	{
		this.LaunchDebuggerIfRequested();
		this.Setup();
	}

	/// <summary>
	/// Optionally launches the debugger and dispatches asynchronous benchmark initialization.
	/// </summary>
	/// <returns>The setup task, which BenchmarkDotNet awaits before measuring the workload.</returns>
	/// <remarks>
	/// Override <see cref="SetupAsync"/> or <see cref="Setup"/>, not this entry point. The default
	/// asynchronous hook calls the synchronous hook once; no synchronous blocking is performed.
	/// </remarks>
	[GlobalSetup]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GlobalSetupAsync), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public Task GlobalSetupAsync()
	{
		this.LaunchDebuggerIfRequested();
		return this.SetupAsync();
	}

	/// <summary>
	/// Performs initial setup for benchmark tests. This method is intended to be overridden in derived classes to provide specific setup operations required by individual benchmarks.
	/// It is automatically called by BenchmarkDotNet at the beginning of the benchmarking session, prior to any benchmarks being executed.
	/// Implementations should ensure to call base.Setup() when overriding to preserve setup operations defined in the base class.
	/// </summary>
	public virtual void Setup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, SetupLogMessage);

		this.Base64String = this.LongTestString[..50].ToBase64();
		this.CoordinateVal01 = RandomData.GenerateCoordinate<Tester.Models.ValueTypes.Coordinate>();
		this.CoordinateVal02 = RandomData.GenerateCoordinate<Tester.Models.ValueTypes.Coordinate>();
		this.CoordinateRef01 = RandomData.GenerateCoordinate<Coordinate>();
		this.CoordinateRef02 = RandomData.GenerateCoordinate<Coordinate>();
		this.PersonRecord01 = RandomData.GeneratePerson<PersonRecord>();
		this.PersonRecord02 = RandomData.GeneratePerson<PersonRecord>();
		this.PersonRef01 = RandomData.GeneratePerson<Person>();
		this.PersonRef02 = RandomData.GeneratePerson<Person>();
		this.PersonVal01 = RandomData.GeneratePerson<Tester.Models.ValueTypes.Person>();
		this.PersonVal02 = RandomData.GeneratePerson<Tester.Models.ValueTypes.Person>();
		this.StringToTrim = $"          {this.LongTestString}          ";
		this.TestBoolean = RandomData.GenerateBoolean();
		this.TestCompanyName = RandomData.GenerateCompanyName();
		this.TestCurrencyAmount = RandomData.GenerateCurrencyAmount();
		this.TestDateOnly = RandomData.GenerateDateOnly();
		this.TestDateTimeOffset = RandomData.GenerateDateTimeOffset();
		this.TestDayOfWeek = RandomData.GenerateEnum<DayOfWeek>();
		this.TestGuid = RandomData.GenerateGuid();
		this.TestHashString = RandomData.GenerateHashString();
		this.TestIPv4Address = RandomData.GenerateIPv4Address();
		this.TestIPv6Address = RandomData.GenerateIPv6Address();
		this.TestSentence = RandomData.GenerateSentence();
		this.TestTimeOnly = RandomData.GenerateTimeOnly();
		this.TestTimeSpan = RandomData.GenerateTimeSpan();
	}

	/// <summary>
	/// Performs asynchronous setup operations before any benchmark methods are run.
	/// Override this method in derived classes to provide custom asynchronous initialization logic
	/// required for your benchmarks, such as loading data from external sources or initializing resources.
	/// The default implementation calls <see cref="Setup"/> once and returns a completed task.
	/// </summary>
	/// <returns>A <see cref="Task"/> representing the asynchronous setup operation.</returns>
	/// <remarks>Await <c>base.SetupAsync()</c> when overriding; do not also call <see cref="Setup"/>.</remarks>
	[Information(nameof(MeasureAction), UnitTestStatus = UnitTestStatus.NotRequired, Status = Status.Available)]
	public virtual Task SetupAsync()
	{
		this.Setup();
		return Task.CompletedTask;
	}

	/// <summary>
	/// Simulates work asynchronously by computing the hash code of the provided item object.
	/// This method is designed for benchmarking asynchronous operations where a consistent,
	/// non-optimizable operation is needed in an asynchronous context.
	/// </summary>
	/// <param name="item">The object whose hash code will be computed. Must not be null.</param>
	/// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
	/// <exception cref="NullReferenceException">Thrown when <paramref name="item"/> is null despite the DisallowNullAttribute.</exception>
	/// <exception cref="TaskCanceledException">Thrown when the operation is canceled through the <paramref name="cancellationToken"/>.</exception>
	/// <remarks>
	/// <para>
	/// This method creates a new task using <see cref="Task.Run(Action, CancellationToken)"/> that calls 
	/// <see cref="SimulateWork(object)"/> to compute the hash code of the provided object.
	/// </para>
	/// <para>
	/// The method is marked as virtual to allow derived classes to override the implementation,
	/// for example to simulate different workloads or introduce specific delays.
	/// </para>
	/// <para>
	/// Unlike its synchronous counterpart, this method supports cancellation through the 
	/// <paramref name="cancellationToken"/> parameter.
	/// </para>
	/// </remarks>
	/// <seealso cref="SimulateWork(object)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SimulateWorkAsync), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public virtual Task SimulateWorkAsync([DisallowNull] object item, CancellationToken cancellationToken = default)
	{
		cancellationToken.ThrowIfCancellationRequested();
		_ = SimulateWork(item);
		return Task.CompletedTask;
	}

	/// <summary>
	/// Updates the <see cref="Person.CellPhone"/> property with a predefined test phone number.
	/// </summary>
	/// <param name="person">The <see cref="Person"/> instance to update. Must not be <c>null</c>.</param>
	/// <returns>
	/// The same <see cref="Person"/> instance with the <see cref="Person.CellPhone"/> property set to a known test value.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="person"/> is <c>null</c>.</exception>
	/// <remarks>
	/// This helper is intended for benchmarking scenarios to apply a deterministic mutation to a <see cref="Person"/> instance.
	/// <see cref="Person.CellPhone"/> to the constant test value stored in <see cref="PhoneNumberUpdate"/>.
	/// </remarks>
	[Information(nameof(Update), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public virtual Person Update([DisallowNull] Person person)
	{
		person = person.ArgumentNotNull();

		person.CellPhone = PhoneNumberUpdate;

		return person;
	}

	/// <summary>
	/// Updates the <see cref="Tester.Models.ValueTypes.Person.CellPhone"/> field on the provided value type
	/// <see cref="Tester.Models.ValueTypes.Person"/> with a predefined test phone number.
	/// </summary>
	/// <param name="person">The value type <see cref="Tester.Models.ValueTypes.Person"/> to update.</param>
	/// <returns>
	/// The updated <see cref="Tester.Models.ValueTypes.Person"/> instance with <see cref="Tester.Models.ValueTypes.Person.CellPhone"/>
	/// set to the constant test value defined by <see cref="PhoneNumberUpdate"/>.
	/// </returns>
	/// <remarks>
	/// Since <see cref="Tester.Models.ValueTypes.Person"/> is a value type, the update is applied to a copy and the modified
	/// instance is returned. This helper is intended for benchmarking scenarios to apply a deterministic mutation without allocations.
	/// </remarks>
	[Information(nameof(Update), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public virtual Tester.Models.ValueTypes.Person Update(Tester.Models.ValueTypes.Person person)
	{
		person.CellPhone = PhoneNumberUpdate;

		return person;
	}

	/// <summary>
	/// Creates a new <see cref="PersonRecord"/> with the <see cref="PersonRecord.CellPhone"/> set to a predefined test value.
	/// </summary>
	/// <param name="person">The source <see cref="PersonRecord"/> to copy and update. Must not be <c>null</c>.</param>
	/// <returns>
	/// A new <see cref="PersonRecord"/> instance with the <see cref="PersonRecord.CellPhone"/> property updated to the test value.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="person"/> is <c>null</c>.</exception>
	/// <remarks>
	/// <para>
	/// Records are immutable; this method returns a copy using the C# <c>with</c> expression.
	/// </para>
	/// <para>
	/// Intended for benchmarking scenarios to apply a deterministic, allocation-minimal mutation pattern.
	/// </para>
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Update), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public virtual PersonRecord Update([DisallowNull] PersonRecord person)
	{
		person = person.ArgumentNotNull();

		return person with { CellPhone = PhoneNumberUpdate };
	}

	/// <summary>
	/// Updates the coordinates of an <see cref="ICoordinate"/> object to predefined values.
	/// </summary>
	/// <typeparam name="T">A concrete type implementing <see cref="ICoordinate"/>.</typeparam>
	/// <param name="coordinate">The coordinate object to update. Must not be <c>null</c>.</param>
	/// <returns>
	/// The same <typeparamref name="T"/> instance with <see cref="ICoordinate.X"/>, <see cref="ICoordinate.Y"/>, and <see cref="ICoordinate.Z"/> set to predefined values.
	/// </returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="coordinate"/> is <c>null</c>.</exception>
	/// <remarks>
	/// This helper applies a deterministic mutation for benchmarking scenarios and validates input.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Update), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public virtual T Update<T>([NotNull] T coordinate) where T : ICoordinate
	{
		coordinate = coordinate.ArgumentNotNull();

		coordinate.X = 0x64;

		return coordinate;
	}

	/// <summary>
	/// Logs an error-level message by forwarding it to the benchmark console logger.
	/// </summary>
	/// <param name="message">The message text to write. Must not be <c>null</c>.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="message"/> is <c>null</c>.</exception>
	/// <remarks>
	/// This helper standardizes error logging for benchmark setup, execution, and cleanup diagnostics.
	/// </remarks>
	[Information(nameof(LogError), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	protected static void LogError(string message)
	{
		LogMessage(LogKind.Error, message);
	}

	/// <summary>
	/// Logs an informational message by forwarding it to the benchmark console logger.
	/// </summary>
	/// <param name="message">The message text to write. Must not be <c>null</c>.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="message"/> is <c>null</c>.</exception>
	/// <remarks>
	/// Informational entries are useful for non-error execution traces and benchmark lifecycle progress messages.
	/// </remarks>
	[Information(nameof(LogInfo), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	protected static void LogInfo(string message)
	{
		LogMessage(LogKind.Info, message);
	}


	/// <summary>
	/// Logs a message to the BenchmarkDotNet console logger with the specified severity.
	/// </summary>
	/// <param name="logKind">The severity/category of the message to log.</param>
	/// <param name="message">The message text to write. Must not be <c>null</c>.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="message"/> is <c>null</c>.</exception>
	/// <remarks>
	/// This method centralizes logging within benchmarks by forwarding messages to <see cref="ConsoleLogger.Default"/>.
	/// Messages are written using <see cref="ConsoleLogger.WriteLine(LogKind, string)"/> and appear in BenchmarkDotNet
	/// console output and artifacts for setup, teardown, and execution diagnostics.
	/// </remarks>
	[Information(nameof(LogMessage), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	protected static void LogMessage(LogKind logKind, string message)
	{
		message = message.ArgumentNotNull();

		ConsoleLogger.Default.WriteLine(logKind, message);
	}

	/// <summary>
	/// Logs a warning-level message by forwarding it to the benchmark console logger.
	/// </summary>
	/// <param name="message">The message text to write. Must not be <c>null</c>.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="message"/> is <c>null</c>.</exception>
	/// <remarks>
	/// Warning entries are intended for noteworthy conditions that do not stop benchmark execution.
	/// </remarks>
	[Information(nameof(LogWarning), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	protected static void LogWarning(string message)
	{
		LogMessage(LogKind.Warning, message);
	}

	/// <summary>
	/// Measures the elapsed time of the specified action and logs the result.
	/// </summary>
	/// <param name="action">The action to time. Must not be <c>null</c>.</param>
	/// <param name="description">A label for the log output. Defaults to <c>Action</c> when omitted.</param>
	/// <returns>The elapsed <see cref="TimeSpan"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="action"/> is <c>null</c>.</exception>
	/// <remarks>
	/// This helper is intended for quick ad-hoc timing during setup or cleanup and is not a substitute for
	/// BenchmarkDotNet measurements. Exceptions thrown by <paramref name="action"/> are not intercepted and
	/// are propagated to the caller.
	/// </remarks>
	[Information(nameof(MeasureAction), UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	protected static TimeSpan MeasureAction([DisallowNull] Action action, string description = "Action")
	{
		action = action.ArgumentNotNull();

		var startTimestamp = Stopwatch.GetTimestamp();
		action();
		var elapsed = Stopwatch.GetElapsedTime(startTimestamp);

		LogInfo(string.Create(CultureInfo.InvariantCulture, $"{description} completed in {elapsed.TotalMilliseconds:F3}ms"));

		return elapsed;
	}

	/// <summary>
	/// Generates reproducible lowercase benchmark words using an isolated random sequence.
	/// </summary>
	/// <param name="count">The validated number of words.</param>
	/// <param name="minLength">The inclusive minimum length.</param>
	/// <param name="maxLength">The inclusive maximum length.</param>
	/// <param name="seed">The fixture seed.</param>
	/// <returns>The generated words.</returns>
	[SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "Predictable randomness is required for reproducible, nonsecurity benchmark fixtures.")]
	[Information(nameof(CreateSeededWords), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static string[] CreateSeededWords(int count, int minLength, int maxLength, int seed)
	{
		var random = new Random(seed);
		var words = new string[count];

		for (var wordIndex = 0; wordIndex < words.Length; wordIndex++)
		{
			var length = (int)random.NextInt64(minLength, (long)maxLength + 1);
			words[wordIndex] = string.Create(length, random, static (characters, generator) =>
			{
				for (var characterIndex = 0; characterIndex < characters.Length; characterIndex++)
				{
					characters[characterIndex] = (char)generator.Next(RandomData.DefaultMinCharacter, RandomData.DefaultMaxCharacter + 1);
				}
			});
		}

		return words;
	}

	/// <summary>
	/// Removes tracked directories in reverse creation order, retaining failed paths for retry.
	/// </summary>
	/// <exception cref="IOException">A tracked directory cannot be removed.</exception>
	/// <exception cref="UnauthorizedAccessException">Removal is not permitted.</exception>
	[Information(nameof(CleanupTemporaryDirectories), UnitTestStatus = UnitTestStatus.None, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private void CleanupTemporaryDirectories()
	{
		for (var directoryIndex = this._temporaryDirectories.Count - 1; directoryIndex >= 0; directoryIndex--)
		{
			try
			{
				Directory.Delete(this._temporaryDirectories[directoryIndex], recursive: true);
			}
			catch (System.IO.DirectoryNotFoundException)
			{
				// A workload that already removed its directory has fulfilled this cleanup obligation.
			}

			this._temporaryDirectories.RemoveAt(directoryIndex);
		}
	}

	/// <summary>
	/// Gets the private source and public working byte arrays for a validated length.
	/// </summary>
	/// <param name="count">The nonnegative byte length.</param>
	/// <returns>The private fixture and public working array.</returns>
	[SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "Seeded data is reproducible benchmark input, never cryptographic material.")]
	[Information(nameof(GetByteFixture), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private (byte[] Source, byte[] Value) GetByteFixture(int count)
	{
		return this._byteArrayCache.GetOrAdd((count, this.DataSeed), static key =>
		{
			if (key.Count == 0)
			{
				return (Array.Empty<byte>(), Array.Empty<byte>());
			}

			byte[] source;
			if (key.Seed is int seed)
			{
				source = new byte[key.Count];
				new Random(seed).NextBytes(source);
			}
			else
			{
				source = RandomData.GenerateByteArray(key.Count);
			}

			return (source, (byte[])source.Clone());
		});
	}

	/// <summary>
	/// Gets private and public string arrays after normalizing the requested bounds.
	/// </summary>
	/// <param name="count">The requested count, adjusted to at least one.</param>
	/// <param name="wordMinLength">The requested minimum length.</param>
	/// <param name="wordMaxLength">The requested maximum length.</param>
	/// <returns>The private fixture and public working array.</returns>
	[Information(nameof(GetStringFixture), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private (string[] Source, string[] Value) GetStringFixture(int count, int wordMinLength, int wordMaxLength)
	{
		count = count.EnsureMinimum(1);
		wordMinLength = wordMinLength.EnsureMinimum(1).ArgumentInRange(max: int.MaxValue - 1, paramName: nameof(wordMinLength));
		wordMaxLength = wordMaxLength.EnsureMinimum(wordMinLength + 1);

		return this._stringArrayCache.GetOrAdd((count, wordMinLength, wordMaxLength, this.DataSeed), static key =>
		{
			var source = key.Seed is int seed
				? CreateSeededWords(key.Count, key.MinLength, key.MaxLength, seed)
				: [.. RandomData.GenerateWords(key.Count, key.MinLength, key.MaxLength)];
			return (source, (string[])source.Clone());
		});
	}

	/// <summary>
	/// Launches the debugger only when explicitly requested.
	/// </summary>
	[Information(nameof(LaunchDebuggerIfRequested), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private void LaunchDebuggerIfRequested()
	{
		if (this.LaunchDebugger)
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, Resources.ResourceManager.GetString(LaunchingDebuggerLogMessage, CultureInfo.CurrentUICulture).ArgumentNotNull());
			_ = Debugger.Launch();
		}
	}

}
