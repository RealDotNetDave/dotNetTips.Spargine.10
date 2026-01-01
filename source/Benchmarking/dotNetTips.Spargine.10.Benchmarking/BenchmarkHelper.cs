// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 01-01-2026
//
// Last Modified By : David McCarter
// Last Modified On : 01-01-2026
// ***********************************************************************
// <copyright file="BenchmarkHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Benchmarking.Properties;
using DotNetTips.Spargine.Core;
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
	[Information(description: nameof(PlayErrorBeep), Status = Status.New)]
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
	[Information(description: nameof(PlaySuccessBeep), Status = Status.New)]
	public static void PlaySuccessBeep()
	{
		Console.Beep(frequency: 500, duration: 300);
		Console.Beep(frequency: 600, duration: 400);
		Console.Beep(frequency: 800, duration: 1000);
	}

	/// <summary>
	/// Runs all benchmark tests found in the calling assembly using the specified configuration.
	/// This method automatically discovers all benchmark classes in the assembly that called this method
	/// and executes them with the provided BenchmarkDotNet configuration.
	/// </summary>
	/// <param name="config">The BenchmarkDotNet configuration to use for running the benchmarks.
	/// This controls aspects such as exporters, diagnosers, job configurations, and other benchmark execution settings.
	/// Must not be null.</param>
	/// <remarks>
	/// <para>
	/// This method uses <see cref="Assembly.GetCallingAssembly"/> to automatically determine which
	/// assembly contains the benchmark classes to run. This allows the method to be called from
	/// different benchmark test projects without modification, making it highly reusable across
	/// multiple benchmark assemblies.
	/// </para>
	/// <para>
	/// The method leverages <see cref="BenchmarkDotNet.Running.BenchmarkSwitcher"/> to discover
	/// all types in the calling assembly that contain benchmark methods (marked with [Benchmark] attribute).
	/// It then executes all discovered benchmarks using the provided configuration.
	/// </para>
	/// <para>
	/// After all benchmarks complete, the method logs the title of each benchmark summary to the console
	/// using <see cref="ConsoleLogger"/>. This provides a quick overview of which benchmarks were executed
	/// and their summary information.
	/// </para>
	/// <para>
	/// <strong>Typical Usage Pattern:</strong>
	/// This method is designed to be called from a Program.cs file in benchmark test projects:
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// // In dotNetTips.Spargine.Core.BenchmarkTests/Program.cs
	/// using BenchmarkDotNet.Configs;
	/// using DotNetTips.Spargine.Benchmarking;
	/// 
	/// var config = DefaultConfig.Instance
	///     .WithOptions(ConfigOptions.DisableOptimizationsValidator);
	/// 
	/// Benchmark.RunBenchmarks(config);
	/// </code>
	/// <code>
	/// // In dotNetTips.Spargine.Extensions.BenchmarkTests/Program.cs
	/// using BenchmarkDotNet.Configs;
	/// using BenchmarkDotNet.Jobs;
	/// using DotNetTips.Spargine.Benchmarking;
	/// 
	/// var config = ManualConfig.Create(DefaultConfig.Instance)
	///     .AddJob(Job.Default.WithWarmupCount(2))
	///     .AddJob(Job.Default.WithIterationCount(5));
	/// 
	/// Benchmark.RunBenchmarks(config);
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="config"/> is null.</exception>
	/// <seealso cref="BenchmarkDotNet.Running.BenchmarkSwitcher"/>
	/// <seealso cref="BenchmarkDotNet.Running.BenchmarkSwitcher.FromAssembly(Assembly)"/>
	/// <seealso cref="Assembly.GetCallingAssembly"/>
	/// <seealso cref="IConfig"/>
	[Information(description: nameof(RunAllBenchmarks), Status = Status.New)]
	public static void RunAllBenchmarks([DisallowNull] IConfig config)
	{
		config = config.ArgumentNotNull();

		var callingAssembly = Assembly.GetCallingAssembly();
		var result = BenchmarkDotNet.Running.BenchmarkSwitcher.FromAssembly(callingAssembly).RunAll(config);

		foreach (var summary in result)
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, summary.Title);
		}
	}

	/// <summary>
	/// Runs specific benchmark tests using the specified configuration.
	/// This method executes only the benchmark types provided in the <paramref name="benchmarks"/> parameter,
	/// allowing for selective benchmark execution of any types containing methods marked with [Benchmark] attribute.
	/// </summary>
	/// <param name="config">The BenchmarkDotNet configuration to use for running the benchmarks.
	/// This controls aspects such as exporters, diagnosers, job configurations, and other benchmark execution settings.
	/// Must not be null.</param>
	/// <param name="benchmarks">A variable-length parameter array of <see cref="Type"/> objects representing
	/// the benchmark classes to execute. Each type must contain at least one method marked with the [Benchmark] attribute.
	/// Types do not need to inherit from <see cref="Benchmark"/>. Must not be null or empty.</param>
	/// <remarks>
	/// <para>
	/// This overload provides fine-grained control over which benchmarks are executed, making it ideal for:
	/// <list type="bullet">
	/// <item><description>Running a specific subset of benchmarks during development or debugging</description></item>
	/// <item><description>Executing only performance-critical benchmarks in CI/CD pipelines</description></item>
	/// <item><description>Selectively running benchmarks that have been modified or require validation</description></item>
	/// <item><description>Creating custom benchmark execution workflows based on command-line arguments or configuration</description></item>
	/// <item><description>Running benchmarks from any class that contains [Benchmark] methods, not just those inheriting from <see cref="Benchmark"/></description></item>
	/// </list>
	/// </para>
	/// <para>
	/// This method uses <see cref="BenchmarkDotNet.Running.BenchmarkSwitcher.FromTypes"/> to create a benchmark switcher
	/// for the specified types, then runs all of them with the provided configuration. This approach is more efficient than
	/// running each benchmark individually and provides consistent behavior with <see cref="RunAllBenchmarks(IConfig)"/>.
	/// </para>
	/// <para>
	/// After all benchmarks complete, the method logs the title of each benchmark summary to the console
	/// using <see cref="ConsoleLogger"/>, providing immediate feedback about the execution status and results.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// // Run specific benchmarks in Program.cs
	/// using BenchmarkDotNet.Configs;
	/// using DotNetTips.Spargine.Benchmarking;
	/// 
	/// var config = DefaultConfig.Instance
	///     .WithOptions(ConfigOptions.DisableOptimizationsValidator);
	/// 
	/// // Run any classes with [Benchmark] methods
	/// Benchmark.RunBenchmarks(
	///     config,
	///     typeof(StringExtensionsBenchmark),
	///     typeof(CollectionBenchmark),
	///     typeof(MyCustomBenchmark) // Doesn't need to inherit from Benchmark
	/// );
	/// </code>
	/// <code>
	/// // Conditional benchmark execution based on command-line arguments
	/// var config = DefaultConfig.Instance;
	/// var benchmarksToRun = new List&lt;Type&gt;();
	/// 
	/// if (args.Contains("--string-tests"))
	/// {
	///     benchmarksToRun.Add(typeof(StringExtensionsBenchmark));
	/// }
	/// 
	/// if (args.Contains("--collection-tests"))
	/// {
	///     benchmarksToRun.Add(typeof(CollectionBenchmark));
	/// }
	/// 
	/// if (benchmarksToRun.Count > 0)
	/// {
	///     Benchmark.RunBenchmarks(config, [.. benchmarksToRun]);
	/// }
	/// else
	/// {
	///     // Run all benchmarks if no specific ones are requested
	///     Benchmark.RunBenchmarks(config);
	/// }
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="config"/> or <paramref name="benchmarks"/> is null.</exception>
	/// <exception cref="ArgumentException">Thrown when <paramref name="benchmarks"/> is empty.</exception>
	/// <seealso cref="BenchmarkDotNet.Running.BenchmarkSwitcher"/>
	/// <seealso cref="BenchmarkDotNet.Running.BenchmarkSwitcher.FromTypes"/>
	/// <seealso cref="BenchmarkAttribute"/>
	/// <seealso cref="IConfig"/>
	[Information(description: nameof(RunAllBenchmarks), Status = Status.New)]
	public static void RunBenchmarks([DisallowNull] IConfig config, [DisallowNull] params Type[] benchmarks)
	{
		config = config.ArgumentNotNull();
		benchmarks = benchmarks.ArgumentNotNull();

		if (benchmarks.Length == 0)
		{
			ExceptionThrower.ThrowArgumentException(Resources.AtLeastOneBenchmarkTypeMustBeProvided, nameof(benchmarks));
		}

		// Use BenchmarkSwitcher.FromTypes for efficient multi-benchmark execution
		var result = BenchmarkDotNet.Running.BenchmarkSwitcher.FromTypes(benchmarks).RunAll(config);

		// Log results
		foreach (var summary in result)
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, summary.Title);
		}
	}
}
