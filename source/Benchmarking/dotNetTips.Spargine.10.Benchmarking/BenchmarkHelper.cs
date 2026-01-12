// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 01-01-2026
//
// Last Modified By : David McCarter
// Last Modified On : 01-12-2026
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
	/// The method leverages <see cref="BenchmarkSwitcher"/> to discover
	/// all types in the calling assembly that contain benchmark methods (marked with [Benchmark] attribute).
	/// It then executes all discovered benchmarks using the provided configuration.
	/// </para>
	/// <para>
	/// <strong>Assembly Context:</strong> This method runs benchmarks in the calling assembly's context,
	/// which ensures proper operation with diagnosers like <see cref="MemoryDiagnoserAttribute"/>. 
	/// The use of <see cref="Assembly.GetCallingAssembly"/> guarantees that BenchmarkDotNet spawns 
	/// the benchmark process from the correct assembly context.
	/// </para>
	/// <para>
	/// After all benchmarks complete, the method logs completion status to the console
	/// using <see cref="ConsoleLogger"/>. This provides immediate feedback about the execution status and results.
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
	/// BenchmarkHelper.RunAllBenchmarks(config);
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
	/// BenchmarkHelper.RunAllBenchmarks(config);
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="config"/> is null.</exception>
	/// <seealso cref="BenchmarkSwitcher"/>
	/// <seealso cref="BenchmarkSwitcher.FromAssembly(Assembly)"/>
	/// <seealso cref="Assembly.GetCallingAssembly"/>
	/// <seealso cref="IConfig"/>
	[Information(description: nameof(RunAllBenchmarks), Status = Status.New)]
	public static void RunAllBenchmarks([DisallowNull] IConfig config)
	{
		config = config.ArgumentNotNull();

		try
		{
			var callingAssembly = Assembly.GetCallingAssembly();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Running all benchmarks from assembly: {callingAssembly.GetName().Name}");

			var summaries = BenchmarkSwitcher.FromAssembly(callingAssembly).RunAll(config);

			ConsoleLogger.Default.WriteLine(Resources.BenchmarkTestsAreCompleteRockOn);

			PlaySuccessBeep();
			_ = Console.ReadLine();
		}
		catch (Exception ex)
		{
			ConsoleLogger.Default.WriteLine(Resources.DangerThereHasBeenAnErrorRunningBenchmarkT);
			ConsoleLogger.Default.WriteLine(ex.Message);
			PlayErrorBeep();
			_ = Console.ReadLine();
		}
	}

	/// <summary>
	/// Runs the specified benchmark types using the provided BenchmarkDotNet configuration.
	/// Ensures all benchmark types originate from the calling assembly.
	/// </summary>
	/// <param name="config">
	/// The BenchmarkDotNet configuration used to run the benchmarks. Controls exporters, diagnosers,
	/// jobs, and other execution settings. Must not be <c>null</c>.
	/// </param>
	/// <param name="benchmarks">
	/// One or more benchmark types to execute. Each type must be defined in the calling assembly and
	/// contain methods marked with <see cref="BenchmarkAttribute"/>. Must not be <c>null</c>.
	/// </param>
	/// <remarks>
	/// <para>
	/// This method validates that all provided benchmark types are defined in the assembly returned by
	/// <see cref="Assembly.GetCallingAssembly()"/>. This guarantees the benchmarks execute in the
	/// correct context and that diagnosers run as expected.
	/// </para>
	/// </remarks>
	/// <example>
	/// <code>
	/// using BenchmarkDotNet.Configs;
	/// using DotNetTips.Spargine.Benchmarking;
	/// 
	/// var config = ManualConfig.Create(DefaultConfig.Instance);
	/// BenchmarkHelper.RunBenchmarks(
	///     config,
	///     typeof(StringExtensionsBenchmark),
	///     typeof(CollectionBenchmark));
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="config"/> or <paramref name="benchmarks"/> is <c>null</c>.
	/// </exception>
	/// <exception cref="ArgumentException">
	/// Thrown when no benchmark types are provided, or when any provided type is not from the calling assembly.
	/// </exception>
	/// <seealso cref="BenchmarkRunner"/>
	/// <seealso cref="IConfig"/>
	/// <seealso cref="Assembly.GetCallingAssembly()"/>
	[Information(description: nameof(RunBenchmarks), Status = Status.New)]
	public static void RunBenchmarks([DisallowNull] IConfig config, [DisallowNull] params Type[] benchmarks)
	{
		config = config.ArgumentNotNull();
		benchmarks = benchmarks.ArgumentNotNull();

		if (benchmarks.Length == 0)
		{
			ExceptionThrower.ThrowArgumentException(Resources.AtLeastOneBenchmarkTypeMustBeProvided, nameof(benchmarks));
		}

		try
		{
			// Get the calling assembly to ensure benchmarks run in the correct assembly context
			// This is critical for diagnosers like MemoryDiagnoser to work properly
			var callingAssembly = Assembly.GetCallingAssembly();

			// Verify all benchmark types are from the calling assembly
			var invalidTypes = benchmarks.Where(t => t.Assembly != callingAssembly).ToArray();

			if (invalidTypes.Length > 0)
			{
				var typeNamesCheck = string.Join(", ", invalidTypes.Select(t => t.FullName));
				ExceptionThrower.ThrowArgumentException(
					$"All benchmark types must be from the calling assembly. Invalid types: {typeNamesCheck}",
					nameof(benchmarks));
			}

			// Run each benchmark type individually using BenchmarkRunner.Run()
			// This ensures each benchmark runs in the calling assembly's context
			// which is required for diagnosers like MemoryDiagnoser to work properly
			foreach (var benchmarkType in benchmarks)
			{
				ConsoleLogger.Default.WriteLine(LogKind.Info, $"Running benchmark: {benchmarkType.Name}");
				_ = BenchmarkRunner.Run(benchmarkType, config);
			}

			ConsoleLogger.Default.WriteLine(Resources.BenchmarkTestsAreCompleteRockOn);

			PlaySuccessBeep();
			_ = Console.ReadLine();
		}
		catch (Exception ex)
		{
			ConsoleLogger.Default.WriteLine(Resources.DangerThereHasBeenAnErrorRunningBenchmarkT);
			ConsoleLogger.Default.WriteLine(ex.Message);
			PlayErrorBeep();
			_ = Console.ReadLine();
		}
	}
}
