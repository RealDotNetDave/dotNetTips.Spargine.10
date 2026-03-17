// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 01-01-2026
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2026
// ***********************************************************************
// <copyright file="BenchmarkHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>BenchmarkHelper provides utility methods to run BenchmarkDotNet benchmarks with minimal boilerplate.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using DotNetTips.Spargine.Benchmarking.Properties;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Diagnostics;
using DotNetTips.Spargine.Extensions;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking;

/// <summary>
/// Provides utility methods for running BenchmarkDotNet benchmark tests.
/// This class simplifies the execution of benchmarks by providing convenient methods
/// to run all benchmarks in an assembly or specific benchmark types with custom configurations.
/// </summary>
/// <remarks>
/// <para>
/// The <see cref="BenchmarkHelper"/> class is designed to be used in Program.cs files of benchmark test projects.
/// It wraps the BenchmarkDotNet API to provide a more convenient interface for common benchmarking scenarios.
/// </para>
/// <para>
/// <strong>Key Features:</strong>
/// <list type="bullet">
/// <item><description>Automatic discovery and execution of all benchmarks in an assembly</description></item>
/// <item><description>Selective execution of specific benchmark types</description></item>
/// <item><description>Audio feedback for benchmark completion (success/error beeps)</description></item>
/// <item><description>Consistent logging of benchmark results to console</description></item>
/// <item><description>Support for custom BenchmarkDotNet configurations</description></item>
/// </list>
/// </para>
/// <para>
/// <strong>Typical Usage Pattern:</strong>
/// This class is intended to be used from Program.cs files in benchmark test projects
/// to execute benchmarks with minimal boilerplate code.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Basic usage in Program.cs
/// using BenchmarkDotNet.Configs;
/// using DotNetTips.Spargine.Benchmarking;
/// 
/// var config = DefaultConfig.Instance
///     .WithOptions(ConfigOptions.DisableOptimizationsValidator);
/// 
/// // Run all benchmarks in the calling assembly
/// BenchmarkHelper.RunAllBenchmarks(config);
/// 
/// // Or run specific benchmarks
/// BenchmarkHelper.RunBenchmarks(
///     config,
///     typeof(StringExtensionsBenchmark),
///     typeof(CollectionBenchmark)
/// );
/// 
/// // Provide audio feedback
/// BenchmarkHelper.PlaySuccessBeep();
/// </code>
/// </example>
/// <seealso cref="Benchmark"/>
[Information(description: nameof(BenchmarkHelper), Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/BenchmarkLikeDotNetDave")]
public static class BenchmarkHelper
{
	/// <summary>
	/// Plays an error beep sequence using system beep tones.
	/// Produces two beeps to indicate an error, failure, or problematic benchmark result.
	/// The second beep uses a high frequency for an extended duration to create an attention-grabbing alert tone.
	/// </summary>
	/// <remarks>
	/// The high frequency and long duration make this beep sequence distinctly different from the success beep,
	/// making it immediately recognizable as an error notification.
	/// Note: This method blocks the calling thread during beep playback and may not work in all environments
	/// (e.g., containerized applications or headless systems without audio hardware).
	/// </remarks>
	/// <example>
	/// <code>
	/// // Play error beep when a benchmark fails validation
	/// [GlobalCleanup]
	/// public void Cleanup()
	/// {
	///     if (benchmarkFailed)
	///     {
	///         Benchmark.PlayErrorBeep();
	///     }
	/// }
	/// </code>
	/// </example>
	[Information(description: nameof(PlayErrorBeep), Status = Status.Available)]
	public static void PlayErrorBeep()
	{
		Console.Beep(frequency: 800, duration: 300);
		Console.Beep(frequency: 400, duration: 400);
		Console.Beep(frequency: 400, duration: 800);
	}

	/// <summary>
	/// Plays a success beep sequence using system beep tones.
	/// Produces four consecutive beeps with increasing frequency and duration
	/// to indicate successful completion of a benchmark or operation.
	/// </summary>
	/// <remarks>
	/// The total duration of the sequence is approximately 6 seconds plus the default beep duration.
	/// Note: This method blocks the calling thread during beep playback and may not work in all environments
	/// (e.g., containerized applications or headless systems without audio hardware).
	/// </remarks>
	/// <example>
	/// <code>
	/// // Play success beep after completing a benchmark
	/// [GlobalCleanup]
	/// public void Cleanup()
	/// {
	///     Benchmark.PlaySuccessBeep();
	/// }
	/// </code>
	/// </example>
	[Information(description: nameof(PlaySuccessBeep), Status = Status.Available)]
	public static void PlaySuccessBeep()
	{
		Console.Beep(frequency: 500, duration: 300);
		Console.Beep(frequency: 600, duration: 400);
		Console.Beep(frequency: 800, duration: 1000);
	}

	/// <summary>
	/// Runs all benchmark tests found in the calling assembly using the specified configuration.
	/// </summary>
	/// <param name="config">
	/// The BenchmarkDotNet <see cref="IConfig"/> instance used to run the benchmarks.
	/// This controls jobs, diagnosers, exporters, loggers, and other execution settings.
	/// Must not be <c>null</c>.
	/// </param>
	/// <remarks>
	/// <para>
	/// This method is intended to be called from a benchmark project’s <c>Program.cs</c> file to
	/// execute every benchmark that derives from <see cref="Benchmark"/> in the calling assembly.
	/// It uses <see cref="Assembly.GetCallingAssembly"/> to discover all non-abstract classes
	/// assignable to <see cref="Benchmark"/> and then delegates execution to the private
	/// <see cref="Run(IConfig,bool,Type[],Assembly)"/> helper, which handles validation, timing,
	/// logging, and optional result persistence.
	/// </para>
	/// <para>
	/// The discovered benchmark types are filtered using:
	/// </para>
	/// <list type="bullet">
	/// <item><description><see cref="Type.IsClass"/> is <c>true</c> (only classes are considered).</description></item>
	/// <item><description><see cref="Type.IsAbstract"/> is <c>false</c> (abstract base benchmarks are skipped).</description></item>
	/// <item><description><see cref="Type"/> is assignable to <see cref="Benchmark"/>.</description></item>
	/// </list>
	/// <para>
	/// This overload passes <c>true</c> for the <c>saveResults</c> parameter, which causes
	/// <see cref="Run(IConfig,bool,Type[],Assembly)"/> to write the aggregated timing summary
	/// to the BenchmarkDotNet artifacts directory via <see cref="SaveReportToFile(IConfig,string)"/>,
	/// in addition to logging it to the console.
	/// </para>
	/// </remarks>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="config"/> is <c>null</c>.
	/// </exception>
	[Information(description: nameof(RunAllBenchmarks), Status = Status.Updated)]
	public static void RunAllBenchmarks([DisallowNull] IConfig config)
	{
		config = config.ArgumentNotNull();

		var callingAssembly = Assembly.GetCallingAssembly();

		ConsoleLogger.Default.WriteLineInfo($"Discovering {nameof(Benchmark)}-derived classes in assembly: {callingAssembly.GetName().Name}");

		// Find all classes that inherit from Benchmark in the calling assembly
		var benchmarkTypes = callingAssembly.GetTypes()
			.Where(t => typeof(Benchmark).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
			.ToArray();

		if (benchmarkTypes.Length == 0)
		{
			ConsoleLogger.Default.WriteLineInfo(
				$"No {nameof(Benchmark)}-derived benchmark classes found in assembly: {callingAssembly.GetName().Name}");
			return;
		}

		Run(config, saveResults: true, benchmarkTypes, callingAssembly);
	}

	/// <summary>
	/// Runs the specified benchmark types using the provided BenchmarkDotNet configuration.
	/// Optionally saves a human-readable timing summary report to the BenchmarkDotNet artifacts directory.
	/// </summary>
	/// <param name="config">
	/// The BenchmarkDotNet <see cref="IConfig"/> instance used to run the benchmarks.
	/// This controls jobs, diagnosers, exporters, loggers, and other execution settings.
	/// Must not be <c>null</c>.
	/// </param>
	/// <param name="saveResults">
	/// When set to <c>true</c>, a consolidated timing summary produced by
	/// <see cref="PerformanceStopwatch.GetSummaryReport"/> is written to a file in the
	/// BenchmarkDotNet artifacts directory via <see cref="SaveReportToFile(IConfig, string)"/>.
	/// When <c>false</c>, the summary is only written to the console.
	/// </param>
	/// <param name="benchmarks">
	/// One or more benchmark <see cref="Type"/> objects to execute.
	/// Each type must:
	/// <list type="bullet">
	/// <item><description>Inherit from <see cref="Benchmark"/></description></item>
	/// <item><description>Be defined in the calling assembly</description></item>
	/// <item><description>Contain at least one method decorated with <see cref="BenchmarkAttribute"/></description></item>
	/// </list>
	/// Passing <c>null</c> or an empty array results in an <see cref="ArgumentException"/>.
	/// </param>
	/// <remarks>
	/// <para>
	/// This overload is intended for selectively running a subset of benchmarks from a given
	/// assembly. It should typically be called from a benchmark project’s <c>Program.cs</c>:
	/// </para>
	/// <code>
	/// using BenchmarkDotNet.Configs;
	/// using DotNetTips.Spargine.Benchmarking;
	/// 
	/// var config = DefaultConfig.Instance
	///     .WithOptions(ConfigOptions.DisableOptimizationsValidator);
	/// 
	/// BenchmarkHelper.RunBenchmarks(
	///     config,
	///     saveResults: true,
	///     typeof(StringExtensionsBenchmark),
	///     typeof(CollectionExtensionsCollectionBenchmark));
	/// </code>
	/// <para>
	/// The method:
	/// </para>
	/// <list type="number">
	/// <item><description>Validates input arguments and ensures at least one benchmark type is provided.</description></item>
	/// <item><description>Resolves the calling assembly using <see cref="Assembly.GetCallingAssembly"/> to ensure benchmarks run in the correct context for diagnosers (for example, <see cref="MemoryDiagnoserAttribute"/>).</description></item>
	/// <item><description>Delegates to a private <c>Run</c> helper that validates each type (inheritance and assembly), runs each benchmark type via BenchmarkRunner.Run(Type, IConfig), and aggregates timing information with <see cref="PerformanceStopwatch"/>.</description></item>
	/// </list>
	/// </remarks>
	/// <exception cref="ArgumentException">
	/// Thrown when:
	/// <list type="bullet">
	/// <item><description><paramref name="benchmarks"/> is <c>null</c> or empty.</description></item>
	/// <item><description>Any provided type does not inherit from <see cref="Benchmark"/> or is not defined in the calling assembly.</description></item>
	/// </list>
	/// </exception>
	[Information(description: nameof(RunBenchmarks), Status = Status.Updated)]
	public static void RunBenchmarks([DisallowNull] IConfig config, bool saveResults, [DisallowNull] params Type[] benchmarks)
	{
		config = config.ArgumentNotNull();
		benchmarks = benchmarks.ArgumentNotNull();

		if (benchmarks.Length == 0)
		{
			ExceptionThrower.ThrowArgumentException(Resources.AtLeastOneBenchmarkTypeMustBeProvided, nameof(benchmarks));
		}

		// Get the calling assembly to ensure benchmarks run in the correct assembly context
		// This is critical for diagnosers like MemoryDiagnoser to work properly
		var callingAssembly = Assembly.GetCallingAssembly();

		Run(config, saveResults, benchmarks, callingAssembly);
	}

	/// <summary>
	/// Executes the specified benchmark types using the provided configuration and assembly context.
	/// </summary>
	/// <param name="config">
	/// The BenchmarkDotNet <see cref="IConfig"/> instance that defines jobs, diagnosers, exporters,
	/// loggers, and other settings used when running the benchmarks. Must not be <c>null</c>.
	/// </param>
	/// <param name="saveResults">
	/// When set to <c>true</c>, a consolidated timing summary generated by
	/// <see cref="PerformanceStopwatch.GetSummaryReport"/> is persisted to the BenchmarkDotNet
	/// artifacts directory via <see cref="SaveReportToFile(IConfig, string)"/>. When <c>false</c>,
	/// the summary is only written to the console.
	/// </param>
	/// <param name="benchmarks">
	/// An array of benchmark <see cref="Type"/> instances to execute. Each type is expected to:
	/// <list type="bullet">
	/// <item><description>Inherit from <see cref="Benchmark"/>.</description></item>
	/// <item><description>Be defined in the <paramref name="callingAssembly"/>.</description></item>
	/// <item><description>Contain one or more methods decorated with <see cref="BenchmarkAttribute"/>.</description></item>
	/// </list>
	/// This method assumes <paramref name="benchmarks"/> has already been validated for null/empty
	/// by the public <see cref="RunBenchmarks(IConfig, bool, Type[])"/> overload.
	/// </param>
	/// <param name="callingAssembly">
	/// The assembly that is considered the owning context for the benchmark types. All entries in
	/// <paramref name="benchmarks"/> must be defined in this assembly; otherwise an
	/// <see cref="ArgumentException"/> is thrown. Using the correct assembly context is critical
	/// for diagnosers such as <see cref="MemoryDiagnoserAttribute"/> to function properly.
	/// </param>
	/// <remarks>
	/// <para>
	/// This private helper centralizes the core benchmark execution logic for
	/// <see cref="RunBenchmarks(IConfig, bool, Type[])"/>:
	/// </para>
	/// <list type="number">
	/// <item><description>Validates that each benchmark type inherits from <see cref="Benchmark"/> and is defined in <paramref name="callingAssembly"/>.</description></item>
	/// <item><description>Attaches <see cref="ConsoleLogger.Default"/> to the configuration for consistent console output.</description></item>
	/// <item><description>Uses <see cref="PerformanceStopwatch"/> to record per-type timing and build an aggregated summary.</description></item>
	/// <item><description>For each benchmark type, materializes benchmark cases via <see cref="BenchmarkConverter.TypeToBenchmarks(Type, IConfig)"/> and executes them using <see cref="BenchmarkRunner.Run(Type, IConfig)"/>.</description></item>
	/// </list>
	/// <para>
	/// On successful completion of all benchmarks, a success beep is played via <see cref="PlaySuccessBeep"/>,
	/// a timing summary is optionally saved to disk when <paramref name="saveResults"/> is <c>true</c>, and
	/// the method waits for user input using <see cref="Console.ReadLine"/> to keep the console open.
	/// </para>
	/// <para>
	/// If any exception is thrown during validation or execution, the error is logged to
	/// <see cref="ConsoleLogger.Default"/>, an error beep is played via <see cref="PlayErrorBeep"/>, and the
	/// method again waits for user input before returning.
	/// </para>
	/// </remarks>
	/// <exception cref="ArgumentException">
	/// Thrown when one or more types in <paramref name="benchmarks"/> do not inherit from
	/// <see cref="Benchmark"/> or are not defined in <paramref name="callingAssembly"/>.
	/// </exception>
	private static void Run(IConfig config, bool saveResults, Type[] benchmarks, Assembly callingAssembly)
	{
		try
		{
			// Verify all benchmark types are from the calling assembly
			var invalidTypes = benchmarks.Where(t => !typeof(Benchmark).IsAssignableFrom(t) || t.Assembly != callingAssembly).ToArray();

			if (invalidTypes.Length > 0)
			{
				var typeNamesCheck = string.Join(", ", invalidTypes.Select(t => t.FullName));

				ExceptionThrower.ThrowArgumentException(
					$"All benchmark types must inherit from {nameof(Benchmark)} and be from the calling assembly. Invalid types: {typeNamesCheck}", nameof(benchmarks));
			}


			config = config.AddLogger(ConsoleLogger.Default);

			var sw = PerformanceStopwatch.StartNew();

			sw.AddDiagnosticEntry($"Found {benchmarks.Length} benchmark classes to run.");

			// Run each benchmark type individually using BenchmarkRunner.Run()
			// This ensures each benchmark runs in the calling assembly's context
			// which is required for diagnosers like MemoryDiagnoser to work properly
			for (var benchmarkIndex = 0; benchmarkIndex < benchmarks.Length; benchmarkIndex++)
			{
				var benchmarkType = benchmarks[benchmarkIndex];

				ConsoleLogger.Default.WriteLineInfo($"Running benchmark {benchmarkIndex + 1} of {benchmarks.Length}: {benchmarkType.Name}");

				ConsoleLogger.Default.WriteLineInfo(string.Empty);

				using var runInfo = BenchmarkConverter.TypeToBenchmarks(benchmarkType, config);

				sw.AddDiagnosticEntry($"Starting benchmark: {benchmarkType.Name} - Test Count: {runInfo.BenchmarksCases.Length}");

				var startTime = sw.Elapsed;

				_ = BenchmarkRunner.Run(benchmarkType, config);

				var totalBenchmarkTime = sw.Elapsed.Subtract(startTime);

				sw.RecordLap();

				sw.AddDiagnosticEntry($"Benchmark completed: {benchmarkType.Name} - Runtime: {totalBenchmarkTime.MillisecondsToString()}");
			}

			ConsoleLogger.Default.WriteLineInfo(string.Empty);
			ConsoleLogger.Default.WriteLineInfo(Resources.BenchmarkTestsAreCompleteRockOn);
			ConsoleLogger.Default.WriteLineInfo(string.Empty);

			sw.Stop();

			var summary = sw.GetSummaryReport();
			ConsoleLogger.Default.WriteLineInfo($"{summary}");

			if (saveResults)
			{
				SaveReportToFile(config, summary);
			}

			PlaySuccessBeep();
		}
		catch (Exception ex)
		{
			ConsoleLogger.Default.WriteLineError(Resources.DangerThereHasBeenAnErrorRunningBenchmarkT);
			ConsoleLogger.Default.WriteLineError(ex.ToString());

			PlayErrorBeep();
		}
	}

	/// <summary>
	/// Saves the aggregated benchmark timing summary to a text file in the BenchmarkDotNet artifacts directory.
	/// </summary>
	/// <param name="config">
	/// The BenchmarkDotNet configuration used to resolve the artifacts directory via <see cref="IConfig.ArtifactsPath"/>.
	/// This determines where the timing summary file is written.
	/// </param>
	/// <param name="summary">
	/// The human-readable timing summary generated by <see cref="PerformanceStopwatch.GetSummaryReport"/>.
	/// This content is written directly to the output file.
	/// </param>
	/// <remarks>
	/// <para>
	/// The summary is saved as a UTF-8 encoded text file named using the pattern:
	/// <c>SpargineTimingSummary_{timestamp}.txt</c>.
	/// </para>
	/// <para>
	/// The file is created in the directory specified by <see cref="IConfig.ArtifactsPath"/>. If the directory
	/// does not already exist, it is created before writing the file.
	/// </para>
	/// <para>
	/// Any exceptions that occur while creating the directory or writing the file are caught and logged
	/// to <see cref="ConsoleLogger.Default"/> as a warning, ensuring that failures in report persistence do
	/// not terminate the benchmark run.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// using BenchmarkDotNet.Configs;
	/// using DotNetTips.Spargine.Benchmarking;
	/// 
	/// var config = DefaultConfig.Instance;
	/// var summary = "Benchmark timing summary...";
	/// 
	/// // Persist the summary to the BenchmarkDotNet artifacts directory
	/// BenchmarkHelper.SaveReportToFile(config, summary);
	/// </code>
	/// </example>
	/// <seealso cref="IConfig.ArtifactsPath"/>
	/// <seealso cref="ConsoleLogger"/>
	/// <seealso cref="PerformanceStopwatch.GetSummaryReport"/>
	private static void SaveReportToFile(IConfig config, string summary)
	{
		try
		{
			var timestamp = DateTime.Now;
			var resultsFileName = $"BenchmarkTimingSummary_{timestamp:yyyyMMdd_HHmmss}.txt";
			var resultsPath = Path.Combine(config.ArtifactsPath, resultsFileName);

			File.WriteAllText(resultsPath, summary);

			ConsoleLogger.Default.WriteLineInfo(string.Empty);
			ConsoleLogger.Default.WriteLineInfo($"Timing summary saved to: {resultsPath}");
		}
		catch (Exception saveEx)
		{
			ConsoleLogger.Default.WriteLineError($"Warning: Could not save timing summary: {saveEx.Message}");
		}
	}
}
