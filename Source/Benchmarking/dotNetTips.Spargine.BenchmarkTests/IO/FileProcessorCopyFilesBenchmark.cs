// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-10-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="FileProcessorCopyFilesBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for FileProcessor.CopyFiles and CopyFilesWithOriginalPath using IterationCleanup to ensure each iteration measures a clean copy with no pre-existing destination files.</summary>
// ***********************************************************************

using System.Collections.Generic;
using System.IO;
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
/// Benchmark tests for <see cref="FileProcessor.CopyFiles"/> and <see cref="FileProcessor.CopyFilesWithOriginalPath"/>.
/// Uses <see cref="IterationCleanupAttribute"/> to delete destination contents after each iteration so that
/// every iteration measures a clean copy rather than an overwrite.
/// </summary>
[MemoryDiagnoser]
[TailCallDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileProcessorCopyFilesBenchmark : Benchmark
{
	private const int FileCount = 256;
	private const int FileLength = 4096;

	private DirectoryInfo _destinationPath;
	private FileProcessor _fileProcessor;
	private List<FileInfo> _sourceFiles;
	private DirectoryInfo _sourcePath;

	/// <summary>
	/// Overrides Cleanup to remove the source and destination directories.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		_ = DirectoryHelper.DeleteDirectory(this._sourcePath, retries: 5);
		_ = DirectoryHelper.DeleteDirectory(this._destinationPath, retries: 5);
	}

	/// <summary>
	/// Benchmark for <see cref="FileProcessor.CopyFiles"/>.
	/// Destination files are removed after each iteration by <see cref="IterationCleanupAttribute"/>
	/// so only a clean copy is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileProcessor.CopyFiles))]
	[BenchmarkCategory(Categories.New)]
	public void CopyFiles()
	{
		var result = this._fileProcessor.CopyFiles(this._sourceFiles, this._destinationPath, overwrite: true);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="FileProcessor.CopyFilesWithOriginalPath"/>.
	/// Destination files are removed after each iteration by <see cref="IterationCleanupAttribute"/>
	/// so only a clean copy is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileProcessor.CopyFilesWithOriginalPath))]
	[BenchmarkCategory(Categories.New)]
	public void CopyFilesWithOriginalPath()
	{
		var result = this._fileProcessor.CopyFilesWithOriginalPath(this._sourceFiles, this._destinationPath);

		this.Consume(result);
	}

	/// <summary>
	/// Deletes all files in the destination directory after each iteration so the next iteration
	/// always measures a clean copy with no pre-existing destination files.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		foreach (var file in this._destinationPath.GetFiles("*.*", SearchOption.AllDirectories))
		{
			file.Delete();
		}
	}

	/// <summary>
	/// Overrides Setup to create source/destination directories, generate test files, and initialize
	/// the <see cref="FileProcessor"/> instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileProcessorCopyFilesBenchmark) + "_source_fileprocessor_" + RandomData.GenerateKey()));
		this._destinationPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileProcessorCopyFilesBenchmark) + "_destination_fileprocessor_" + RandomData.GenerateKey()));

		_ = Directory.CreateDirectory(this._sourcePath.FullName);
		_ = Directory.CreateDirectory(this._destinationPath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");
		ConsoleLogger.Default.WriteLine($"Destination Path={this._destinationPath}");

		_ = RandomData.GenerateFiles(this._sourcePath.FullName, FileCount, FileLength);

		this._sourceFiles = [.. this._sourcePath.GetFiles("*.*", SearchOption.TopDirectoryOnly)];
		this._fileProcessor = new FileProcessor();
	}
}
