// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="DirectoryInfoExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for DirectoryInfoExtensions methods.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="DirectoryInfoExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class DirectoryInfoExtensionsBenchmark : Benchmark
{
	private const string DestinationFileName = "destination.txt";
	private const string ReadFileName = "read.txt";
	private const string TestContent = "Benchmark content for DirectoryInfoExtensions methods.";
	private DirectoryInfo _directory = default!;

	/// <summary>
	/// Cleans up benchmark resources.
	/// </summary>
	public override void Cleanup()
	{
		if (this._directory.Exists)
		{
			this._directory.Delete(recursive: true);
		}

		base.Cleanup();
	}

	[Benchmark(Description = nameof(DirectoryInfoExtensions.CreateTempFileThenMove))]
	public void CreateTempFileThenMove()
	{
		var result = this._directory.CreateTempFileThenMove(DestinationFileName, TestContent);
		this.Consume(result);
	}

	/// <summary>
	/// Cleans files produced by benchmarks after each iteration.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		DeleteFileIfExists(new FileInfo(Path.Combine(this._directory.FullName, DestinationFileName)));
		DeleteFileIfExists(new FileInfo(Path.Combine(this._directory.FullName, ReadFileName)));
	}

	[Benchmark(Description = nameof(DirectoryInfoExtensions.ReadAllTextSafe))]
	public void ReadAllTextSafe()
	{
		var result = this._directory.ReadAllTextSafe(ReadFileName, fallback: string.Empty);
		this.Consume(result);
	}

	/// <summary>
	/// Creates the benchmark directory.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		var path = Path.Combine(Path.GetTempPath(), nameof(DirectoryInfoExtensionsBenchmark), Guid.NewGuid().ToString("N"));
		this._directory = new DirectoryInfo(path);
		this._directory.Create();
	}

	/// <summary>
	/// Prepares per-iteration state for <see cref="CreateTempFileThenMove"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(CreateTempFileThenMove))]
	public void SetupCreateTempFileThenMove()
	{
		DeleteFileIfExists(new FileInfo(Path.Combine(this._directory.FullName, DestinationFileName)));
	}

	/// <summary>
	/// Prepares per-iteration state for <see cref="ReadAllTextSafe"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(ReadAllTextSafe))]
	public void SetupReadAllTextSafe()
	{
		File.WriteAllText(Path.Combine(this._directory.FullName, ReadFileName), TestContent);
	}

	/// <summary>
	/// Prepares per-iteration state for <see cref="WriteAllTextAtomic"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(WriteAllTextAtomic))]
	public void SetupWriteAllTextAtomic()
	{
		DeleteFileIfExists(new FileInfo(Path.Combine(this._directory.FullName, DestinationFileName)));
	}

	[Benchmark(Description = nameof(DirectoryInfoExtensions.WriteAllTextAtomic))]
	public void WriteAllTextAtomic()
	{
		var result = this._directory.WriteAllTextAtomic(DestinationFileName, TestContent);
		this.Consume(result);
	}

	private static void DeleteFileIfExists(FileInfo file)
	{
		if (file.Exists)
		{
			file.Delete();
		}
	}
}
