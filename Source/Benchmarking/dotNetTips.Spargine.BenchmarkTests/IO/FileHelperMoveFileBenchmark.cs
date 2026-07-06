// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-12-2026
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="FileHelperMoveFileBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark test for FileHelper.MoveFile using IterationCleanup to move the file back
// after each iteration so only a single forward move is measured.
// </summary>
// ***********************************************************************

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
/// Benchmark test for <see cref="FileHelper.MoveFile"/>.
/// Uses <see cref="IterationCleanupAttribute"/> to move the file back from the destination to the
/// source after each iteration so that only a single forward move is measured.
/// </summary>
[MemoryDiagnoser]
[TailCallDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileHelperMoveFileBenchmark : Benchmark
{
	private const int FileLength = 4096;

	private FileInfo _destFile;
	private DirectoryInfo _destinationPath;
	private FileInfo _sourceFile;
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
	/// Moves the file back from the destination to the source after each iteration so the next
	/// iteration always measures a clean forward move with no pre-existing destination file.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		if (this._destFile.Exists)
		{
			_ = FileHelper.MoveFile(this._destFile, this._sourceFile, replaceExisting: true);
		}
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.MoveFile"/>.
	/// The file is moved back to the source in <see cref="IterationCleanupAttribute"/>; only the
	/// forward move is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.MoveFile))]
	[BenchmarkCategory(Categories.IO)]
	public void MoveFile()
	{
		_ = FileHelper.MoveFile(this._sourceFile, this._destFile, replaceExisting: true);
	}

	/// <summary>
	/// Overrides Setup to create source and destination directories and generate a single test file.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperMoveFileBenchmark) + "_source_filehelper_" + RandomData.GenerateKey()));
		this._destinationPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperMoveFileBenchmark) + "_destination_filehelper_" + RandomData.GenerateKey()));

		_ = Directory.CreateDirectory(this._sourcePath.FullName);
		_ = Directory.CreateDirectory(this._destinationPath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");
		ConsoleLogger.Default.WriteLine($"Destination Path={this._destinationPath}");

		var files = RandomData.GenerateFiles(this._sourcePath.FullName, count: 1, fileLength: FileLength);
		this._sourceFile = new FileInfo(files[0]);
		this._destFile = new FileInfo(Path.Combine(this._destinationPath.FullName, this._sourceFile.Name));
	}
}
