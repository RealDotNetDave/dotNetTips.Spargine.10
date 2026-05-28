// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-12-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="FileProcessorMoveFilesBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark test for FileProcessor.MoveFiles using IterationSetup to seed source files
// and IterationCleanup to restore state so only a single forward move is measured per iteration.
// </summary>
// ***********************************************************************

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark test for <see cref="FileProcessor.MoveFiles"/>.
/// Uses <see cref="IterationSetupAttribute"/> to snapshot the source file list immediately before
/// each timed run, and <see cref="IterationCleanupAttribute"/> to move files back from the destination
/// to the source so that only a single forward move is measured per iteration.
/// </summary>
[MemoryDiagnoser]
[TailCallDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileProcessorMoveFilesBenchmark : Benchmark
{
	private const int FileCount = 256;
	private const int FileLength = 4096;

	private DirectoryInfo _destinationPath;
	private FileProcessor _fileProcessor;
	private List<FileInfo> _sourceFiles;
	private DirectoryInfo _sourcePath;

	/// <summary>
	/// Overrides Cleanup to remove test directories created during setup.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		_ = DirectoryHelper.DeleteDirectory(this._sourcePath, retries: 5);
		_ = DirectoryHelper.DeleteDirectory(this._destinationPath, retries: 5);
	}

	/// <summary>
	/// Moves any files that landed in the destination back to the source directory after each iteration
	/// so the source directory is fully restored before the next run.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		var destFiles = this._destinationPath.GetFiles("*.*", SearchOption.TopDirectoryOnly).ToList();

		if (destFiles.Count > 0)
		{
			_ = this._fileProcessor.MoveFiles(destFiles, this._sourcePath, overwrite: true);
		}
	}

	/// <summary>
	/// Snapshots the source file list immediately before each timed run so the benchmark body
	/// always operates on the current, fully-restored set of source files.
	/// </summary>
	[IterationSetup]
	public void IterationSetup()
	{
		this._sourceFiles = [.. this._sourcePath.GetFiles("*.*", SearchOption.TopDirectoryOnly)];
	}

	/// <summary>
	/// Benchmark for <see cref="FileProcessor.MoveFiles"/>.
	/// Source files are snapshotted in <see cref="IterationSetupAttribute"/> and restored via
	/// <see cref="IterationCleanupAttribute"/>; only the forward move is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileProcessor.MoveFiles))]
	[BenchmarkCategory(Categories.New)]
	public void MoveFiles()
	{
		var result = this._fileProcessor.MoveFiles(this._sourceFiles, this._destinationPath, overwrite: true);

		this.Consume(result);
	}

	/// <summary>
	/// Overrides Setup to create source and destination directories, generate test files,
	/// and initialize the <see cref="FileProcessor"/> instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileProcessorMoveFilesBenchmark) + "_source_fileprocessor_" + RandomData.GenerateKey()));
		this._destinationPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileProcessorMoveFilesBenchmark) + "_destination_fileprocessor_" + RandomData.GenerateKey()));

		_ = Directory.CreateDirectory(this._sourcePath.FullName);
		_ = Directory.CreateDirectory(this._destinationPath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");
		ConsoleLogger.Default.WriteLine($"Destination Path={this._destinationPath}");

		_ = RandomData.GenerateFiles(this._sourcePath.FullName, FileCount, FileLength);

		this._fileProcessor = new FileProcessor();
	}
}
