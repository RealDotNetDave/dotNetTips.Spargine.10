// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="FileInfoExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for FileInfoExtensions methods.</summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="FileInfoExtensions"/> methods marked for benchmarking.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class FileInfoExtensionsBenchmark : Benchmark
{
	private const string ExistingFileName = "target.txt";
	private const string MissingFileName = "missing.txt";
	private const string TestContent = "Benchmark content for FileInfoExtensions.";

	private DirectoryInfo _directory = default!;
	private FileInfo _existingFile = default!;
	private FileInfo _missingFile = default!;

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

	[Benchmark(Description = nameof(FileInfoExtensions.CreateTempFileThenMove))]
	public void CreateTempFileThenMove()
	{
		this._existingFile.CreateTempFileThenMove(TestContent);
		this.Consume(this._existingFile.Length);
	}

	/// <summary>
	/// Resets file state between iterations.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		DeleteFileIfExists(this._existingFile);
		DeleteFileIfExists(this._missingFile);
	}

	[Benchmark(Description = nameof(FileInfoExtensions.ReadAllTextSafe) + ": Existing file")]
	public void ReadAllTextSafe()
	{
		var result = this._existingFile.ReadAllTextSafe(fallback: string.Empty);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(FileInfoExtensions.ReadAllTextSafe) + ": Missing file")]
	public void ReadAllTextSafeMissingFile()
	{
		var result = this._missingFile.ReadAllTextSafe(fallback: string.Empty);
		this.Consume(result);
	}

	/// <summary>
	/// Initializes benchmark files.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		var path = Path.Combine(Path.GetTempPath(), nameof(FileInfoExtensionsBenchmark), Guid.NewGuid().ToString("N"));
		this._directory = new DirectoryInfo(path);
		this._directory.Create();

		this._existingFile = new FileInfo(Path.Combine(this._directory.FullName, ExistingFileName));
		this._missingFile = new FileInfo(Path.Combine(this._directory.FullName, MissingFileName));
	}

	/// <summary>
	/// Prepares per-iteration state for <see cref="CreateTempFileThenMove"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(CreateTempFileThenMove))]
	public void SetupCreateTempFileThenMove()
	{
		DeleteFileIfExists(this._existingFile);
	}

	/// <summary>
	/// Prepares per-iteration state for <see cref="ReadAllTextSafe"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(ReadAllTextSafe))]
	public void SetupReadAllTextSafe()
	{
		File.WriteAllText(this._existingFile.FullName, TestContent);
	}

	/// <summary>
	/// Prepares per-iteration state for <see cref="WriteAllTextAtomic"/> benchmark.
	/// </summary>
	[IterationSetup(Target = nameof(WriteAllTextAtomic))]
	public void SetupWriteAllTextAtomic()
	{
		DeleteFileIfExists(this._existingFile);
	}

	[Benchmark(Description = nameof(FileInfoExtensions.WriteAllTextAtomic))]
	public void WriteAllTextAtomic()
	{
		this._existingFile.WriteAllTextAtomic(TestContent);
		this.Consume(this._existingFile.Length);
	}

	private static void DeleteFileIfExists(FileInfo file)
	{
		if (file.Exists)
		{
			file.Delete();
		}
	}
}
