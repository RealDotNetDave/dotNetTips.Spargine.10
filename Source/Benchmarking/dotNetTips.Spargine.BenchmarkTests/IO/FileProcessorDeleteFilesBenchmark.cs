// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="FileProcessorDeleteFilesBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark test for FileProcessor.DeleteFiles using IterationSetup to isolate file generation from the measured delete operation.</summary>
// ***********************************************************************

using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark test for <see cref="FileProcessor.DeleteFiles"/> using <see cref="IterationSetupAttribute"/> to isolate
/// file generation from the measured delete operation.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileProcessorDeleteFilesBenchmark : Benchmark
{
	private const int FileCount = 25;
	private const int FileLength = 4096;

	private FileProcessor _fileProcessor;
	private List<FileInfo> _filesToDelete;
	private DirectoryInfo _tempDir;

	/// <summary>
	/// Overrides Cleanup to remove the temporary directory if it still exists.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		_ = DirectoryHelper.DeleteDirectory(this._tempDir, retries: 5);
	}

	/// <summary>
	/// Benchmark for <see cref="FileProcessor.DeleteFiles"/>.
	/// File creation is isolated to <see cref="IterationSetupAttribute"/>; only the delete is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileProcessor.DeleteFiles))]
	[BenchmarkCategory(Categories.New)]
	public void DeleteFiles()
	{
		var result = this._fileProcessor.DeleteFiles(this._filesToDelete);

		this.Consume(result);
	}

	/// <summary>
	/// Removes the temporary directory after each iteration.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		_ = DirectoryHelper.DeleteDirectory(this._tempDir, retries: 5);
	}

	/// <summary>
	/// Creates a fresh temporary directory and generates files before each iteration
	/// so only the delete operation is measured.
	/// </summary>
	[IterationSetup]
	public void IterationSetup()
	{
		this._tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileProcessorDeleteFilesBenchmark) + "_" + RandomData.GenerateKey()));
		_ = Directory.CreateDirectory(this._tempDir.FullName);
		_ = RandomData.GenerateFiles(this._tempDir.FullName, FileCount, FileLength);

		this._filesToDelete = [.. this._tempDir.GetFiles("*.*", SearchOption.TopDirectoryOnly)];
	}

	/// <summary>
	/// Overrides Setup to initialize the <see cref="FileProcessor"/> instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._fileProcessor = new FileProcessor();
	}
}
