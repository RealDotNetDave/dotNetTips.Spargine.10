// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="FileProcessorBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for FileProcessor: CopyFiles, CopyFilesWithOriginalPath, DeleteFolders, MoveFiles, MoveFilesWithOriginalPath. DeleteFiles benchmark lives in FileProcessorDeleteFilesBenchmark.</summary>
// ***********************************************************************

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark tests for all public methods in <see cref="FileProcessor"/> with <c>BenchmarkStatus.Benchmark</c>.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileProcessorBenchmark : Benchmark
{
	private const int FileCount = 25;
	private const int FileLength = 4096;

	private DirectoryInfo _destinationPath;
	private FileProcessor _fileProcessor;
	private List<DirectoryInfo> _foldersToDelete;
	private List<FileInfo> _sourceFiles;
	private DirectoryInfo _sourcePath;

	/// <summary>
	/// Overrides Cleanup to remove test directories created during benchmarking.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		_ = DirectoryHelper.DeleteDirectory(this._sourcePath, retries: 5);
		_ = DirectoryHelper.DeleteDirectory(this._destinationPath, retries: 5);
	}

	/// <summary>
	/// Benchmark for <see cref="FileProcessor.DeleteFolders"/>.
	/// Creates fresh directories each iteration so there are real targets to delete.
	/// </summary>
	[Benchmark(Description = nameof(FileProcessor.DeleteFolders))]
	[BenchmarkCategory(Categories.New)]
	public void DeleteFolders()
	{
		var folderCount = 5;
		var folders = new List<DirectoryInfo>(folderCount);

		for (var folderIndex = 0; folderIndex < folderCount; folderIndex++)
		{
			var dir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.DeleteFolders) + "_" + RandomData.GenerateKey()));
			_ = Directory.CreateDirectory(dir.FullName);
			folders.Add(dir);
		}

		var result = this._fileProcessor.DeleteFolders(folders, recursive: true);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="FileProcessor.MoveFiles"/>.
	/// Round-trips files between source and destination so iterations stay valid.
	/// </summary>
	[Benchmark(Description = nameof(FileProcessor.MoveFiles))]
	[BenchmarkCategory(Categories.New)]
	public void MoveFiles()
	{
		// Move source → destination
		var moved = this._fileProcessor.MoveFiles(this._sourceFiles, this._destinationPath, overwrite: true);
		this.Consume(moved);

		// Move back destination → source so the next iteration has files to move
		var destFiles = this._destinationPath.GetFiles("*.*", SearchOption.TopDirectoryOnly).ToList();
		var movedBack = this._fileProcessor.MoveFiles(destFiles, this._sourcePath, overwrite: true);
		this.Consume(movedBack);

		// Refresh the source file list for subsequent iterations
		this._sourceFiles = [.. this._sourcePath.GetFiles("*.*", SearchOption.TopDirectoryOnly)];
	}

	/// <summary>
	/// Benchmark for <see cref="FileProcessor.MoveFilesWithOriginalPath"/>.
	/// Round-trips files between source and destination using <see cref="FileProcessor.MoveFilesWithOriginalPath"/>
	/// in both directions so the source layout is faithfully restored each iteration.
	/// </summary>
	[Benchmark(Description = nameof(FileProcessor.MoveFilesWithOriginalPath))]
	[BenchmarkCategory(Categories.New)]
	public void MoveFilesWithOriginalPath()
	{
		// Move source → destination preserving relative structure (this is what is being measured)
		var moved = this._fileProcessor.MoveFilesWithOriginalPath(this._sourceFiles, this._destinationPath, overwrite: true);
		this.Consume(moved);

		// Move back destination → source using the same path-preserving semantics so the
		// source layout is identically restored for the next iteration
		var destFiles = this._destinationPath.GetFiles("*.*", SearchOption.AllDirectories).ToList();
		var movedBack = this._fileProcessor.MoveFilesWithOriginalPath(destFiles, this._sourcePath, overwrite: true);
		this.Consume(movedBack);

		// Refresh the source file list; use AllDirectories in case structure was restored in subdirectories
		this._sourceFiles = [.. this._sourcePath.GetFiles("*.*", SearchOption.AllDirectories)];
	}

	/// <summary>
	/// Overrides Setup to initialize test directories, files, and the <see cref="FileProcessor"/> instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileProcessorBenchmark) + "_src_" + RandomData.GenerateKey()));
		this._destinationPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileProcessorBenchmark) + "_dst_" + RandomData.GenerateKey()));

		_ = Directory.CreateDirectory(this._sourcePath.FullName);
		_ = Directory.CreateDirectory(this._destinationPath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");
		ConsoleLogger.Default.WriteLine($"Destination Path={this._destinationPath}");

		_ = RandomData.GenerateFiles(this._sourcePath.FullName, FileCount, FileLength);

		this._sourceFiles = [.. this._sourcePath.GetFiles("*.*", SearchOption.TopDirectoryOnly)];

		this._fileProcessor = new FileProcessor();

		// Pre-create a list of temp directories for DeleteFolders benchmark
		this._foldersToDelete = [];
	}
}
