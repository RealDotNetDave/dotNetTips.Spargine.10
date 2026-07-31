// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-14-2026
// ***********************************************************************
// <copyright file="Benchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Abstract base class for all BenchmarkDotNet benchmarks, providing
// setup/cleanup lifecycle methods, consume helpers for preventing dead-code
// elimination, random data generators, test entity update methods, and a
// comprehensive set of default BenchmarkDotNet diagnostic attributes.
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
	/// Log message emitted by <see cref="GlobalSetup"/> when launching the debugger.
	/// </summary>
	private const string LaunchingDebuggerLogMessage = $"Launching debugger: {nameof(Benchmark)}.";

	/// <summary>
	/// Fake phone number.
	/// </summary>
	private const string PhoneNumberUpdate = "555-867-5309";

	/// <summary>
	/// Log message emitted by <see cref="Setup"/>.
	/// </summary>
	private const string SetupLogMessage = $"Setup(): {nameof(Benchmark)}.";

	/// <summary>
	/// Caches byte arrays of various sizes to avoid regenerating them for each benchmark iteration.
	/// </summary>
	private readonly ConcurrentDictionary<int, byte[]> _byteArrayCache = new();

	/// <summary>
	/// Caches string arrays of various configurations to avoid regenerating them for each benchmark iteration.
	/// The key is a value tuple (count, minLength, maxLength) to avoid heap-allocating a string key on every call.
	/// </summary>
	private readonly ConcurrentDictionary<(int Count, int MinLength, int MaxLength), string[]> _stringArrayCache = new();

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
	public static int SimulateWork([DisallowNull] object item)
	{
		return RuntimeHelpers.GetHashCode(item);
	}

	/// <summary>
	/// Performs cleanup operations. This method should be called at the end of benchmark runs.
	/// It logs the cleanup action to the console.
	/// </summary>
	public virtual void Cleanup()
	{
		ConsoleLogger.Default.WriteLine(LogKind.Info, CleanupLogMessage);
	}

	/// <summary>
	/// Performs asynchronous cleanup operations after all benchmark methods have run.
	/// Override this method in derived classes to provide custom asynchronous cleanup logic
	/// required for your benchmarks, such as releasing resources or saving results.
	/// The default implementation does nothing and returns a completed task.
	/// </summary>
	/// <returns>A <see cref="Task"/> representing the asynchronous cleanup operation.</returns>
	public virtual Task CleanupAsync()
	{
		return Task.CompletedTask;
	}

	/// <summary>
	/// Consumes the specified object using the Benchmark.Consumer property to prevent the JIT compiler from optimizing away the code being benchmarked.
	/// </summary>
	/// <typeparam name="T">The type of the object to consume.</typeparam>
	/// <param name="obj">The object to consume.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
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
	public ValueTask ConsumeAsync<T>(T obj)
	{
		this.Consumer.Consume(obj);
		return ValueTask.CompletedTask;
	}
	/// <summary>
	/// Consumes each item in the specified <see cref="IReadOnlyList{T}"/> by index,
	/// avoiding enumerator allocation.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The list to consume. Must not be <c>null</c>.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ConsumeCollection), author: "David McCarter", createdOn: "4/17/2026", Status = Status.Available)]
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
	[Information(nameof(ConsumeDictionary), "David McCarter", "1/7/2026", Status = Status.Available)]
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
	[Information(nameof(ConsumeEnumerable), author: "David McCarter", createdOn: "1/8/2026", Status = Status.Available)]
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
	[Information(nameof(ConsumeReadOnlySpan), author: "David McCarter", createdOn: "4/17/2026", Status = Status.Available)]
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
	[Information(nameof(ConsumeSpan), author: "David McCarter", createdOn: "1/8/2026", Status = Status.Available)]
	public void ConsumeSpan<T>(Span<T> span)
	{
		foreach (var item in span)
		{
			this.Consume(item);
		}
	}

	/// <summary>
	/// Retrieves a random byte array of the specified size, caching the result for reuse across benchmark iterations.
	/// </summary>
	/// <param name="count">
	/// The size of the byte array to generate. Values less than <c>1</c> are adjusted to <c>1</c>.
	/// </param>
	/// <returns>
	/// A byte array of the requested size (in KB). If a buffer for the same size was previously generated,
	/// the cached instance is returned; otherwise, a new array is created and cached.
	/// </returns>
	/// <remarks>
	/// <para>
	/// This method uses an internal cache (<see cref="_byteArrayCache"/>) keyed by the requested kilobyte size to avoid
	/// regenerating identical arrays, reducing allocation noise and improving consistency in benchmarks.
	/// </para>
	/// <para>
	/// Byte arrays are generated by <see cref="RandomData.GenerateByteArray(int)"/> and stored for subsequent requests.
	/// The method is marked with <see cref="MethodImplOptions.AggressiveInlining"/> to minimize call overhead in tight loops.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// // Retrieve a 10KB buffer (cached after first call)
	/// var buffer = this.GetByteArray(10);
	/// this.Consume(buffer.Length);
	/// </code>
	/// </example>
	/// <seealso cref="_byteArrayCache"/>
	/// <seealso cref="RandomData.GenerateByteArray(int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public byte[] GetByteArray(int count = 1)
	{
		count = count.ArgumentInRange(1);
		return this._byteArrayCache.GetOrAdd(count, RandomData.GenerateByteArray);
	}

	/// <summary>
	/// Generates a random string array of a specified count, with each string's length bounded by the specified minimum and maximum lengths.
	/// The method caches the generated array to avoid regeneration on subsequent calls with the same parameters.
	/// </summary>
	/// <param name="count">The number of strings to generate in the array.</param>
	/// <param name="wordMinLength">The minimum length of each generated string. Defaults to 10.</param>
	/// <param name="wordMaxLength">The maximum length of each generated string. Defaults to 15.</param>
	/// <returns>An array of randomly generated strings of the specified count and length constraints.</returns>
	public string[] GetStringArray(int count, int wordMinLength = 10, int wordMaxLength = 15)
	{
		//Ensure maxLength is at least +1 of minLength.
		wordMinLength = wordMinLength.EnsureMinimum(1);
		wordMaxLength = wordMaxLength.EnsureMinimum(wordMinLength + 1);

		var key = (count, wordMinLength, wordMaxLength);

		return this._stringArrayCache.GetOrAdd(key, static k => [.. RandomData.GenerateWords(k.Count, k.MinLength, k.MaxLength)]);
	}

	/// <summary>
	/// Performs global cleanup operations after all benchmark methods have run.
	/// This method is automatically called by BenchmarkDotNet at the end of the benchmarking session.
	/// </summary>
	[GlobalCleanup]
	public void GlobalCleanup()
	{
		this.Cleanup();
	}

	/// <summary>
	/// Performs global setup operations before any benchmark methods are run.
	/// This method is automatically called by BenchmarkDotNet at the beginning of the benchmarking session.
	/// It checks if the debugger should be launched and performs initial setup by calling the Setup method.
	/// </summary>
	[GlobalSetup]
	public void GlobalSetup()
	{
		if (this.LaunchDebugger)
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, LaunchingDebuggerLogMessage);
			_ = Debugger.Launch();
		}

		this.Setup();
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
	/// The default implementation does nothing and returns a completed task.
	/// </summary>
	/// <returns>A <see cref="Task"/> representing the asynchronous setup operation.</returns>
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
	public virtual T Update<T>([NotNull] T coordinate) where T : ICoordinate
	{
		coordinate = coordinate.ArgumentNotNull();

		coordinate.X = 0x64;

		return coordinate;
	}

	/// <summary>
	/// Logs an error message.
	/// </summary>
	/// <param name="message">The message to log.</param>
	protected static void LogError(string message)
	{
		LogMessage(LogKind.Error, message);
	}

	/// <summary>
	/// Logs an informational message.
	/// </summary>
	/// <param name="message">The message to log.</param>
	protected static void LogInfo(string message)
	{
		LogMessage(LogKind.Info, message);
	}


	/// <summary>
	/// Logs a message to the BenchmarkDotNet console logger with the specified severity.
	/// </summary>
	/// <param name="logKind">The severity/category of the message to log.</param>
	/// <param name="message">The message text to write.</param>
	/// <remarks>
	/// This method centralizes logging within benchmarks by forwarding messages to <see cref="ConsoleLogger.Default"/>.
	/// Messages are written using <see cref="ConsoleLogger.WriteLine(LogKind, string)"/> and will
	/// appear in BenchmarkDotNet console output and artifacts, which is useful for setup/teardown diagnostics and
	/// informative traces during benchmark execution.
	/// </remarks>
	protected static void LogMessage(LogKind logKind, string message)
	{
		ConsoleLogger.Default.WriteLine(logKind, message);
	}

	/// <summary>
	/// Logs a warning message.
	/// </summary>
	/// <param name="message">The message to log.</param>
	protected static void LogWarning(string message)
	{
		LogMessage(LogKind.Warning, message);
	}

	/// <summary>
	/// Measures the elapsed time of the specified action and logs the result.
	/// Useful for quick ad-hoc timing during setup/cleanup — not a substitute for BenchmarkDotNet.
	/// </summary>
	/// <param name="action">The action to time. Must not be <c>null</c>.</param>
	/// <param name="description">A label for the log output.</param>
	/// <returns>The elapsed <see cref="TimeSpan"/>.</returns>
	[Information(nameof(MeasureAction), author: "David McCarter", createdOn: "4/17/2026", Status = Status.Available)]
	protected static TimeSpan MeasureAction([DisallowNull] Action action, string description = "Action")
	{
		action = action.ArgumentNotNull();

		var startTimestamp = Stopwatch.GetTimestamp();
		action();
		var elapsed = Stopwatch.GetElapsedTime(startTimestamp);

		LogInfo(string.Create(CultureInfo.InvariantCulture, $"{description} completed in {elapsed.TotalMilliseconds:F3}ms"));

		return elapsed;
	}

}
