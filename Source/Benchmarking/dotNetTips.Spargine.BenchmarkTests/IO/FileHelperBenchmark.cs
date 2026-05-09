// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="FileHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for FileHelper: CalculateTotalFileSize, CheckPermission, FileHasInvalidChars, MoveFile. Copy benchmarks live in FileHelperCopyFileBenchmark.</summary>
// ***********************************************************************

using System;
using System.IO;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark tests for public methods in <see cref="FileHelper"/> that have <c>BenchmarkStatus.Benchmark</c>.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileHelperBenchmark : Benchmark
{
	private const int FileCount = 256;
	private const int FileLength = 4096;

	private DirectoryInfo _destinationPath;
	private FileInfo _singleFile;
	private DirectoryInfo _sourcePath;
	private FileInfo[] _testFiles;

	/// <summary>
	/// Benchmark for <see cref="FileHelper.CalculateTotalFileSize"/>.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.CalculateTotalFileSize))]
	[BenchmarkCategory(Categories.New)]
	public void CalculateTotalFileSize()
	{
		var result = FileHelper.CalculateTotalFileSize(new ReadOnlySpan<FileInfo>(this._testFiles));

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.CheckPermission"/>.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.CheckPermission))]
	[BenchmarkCategory(Categories.New)]
	public void CheckPermission()
	{
		var result = FileHelper.CheckPermission(this._singleFile);

		this.Consume(result);
	}

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
	/// Benchmark for <see cref="FileHelper.FileHasInvalidChars"/>.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.FileHasInvalidChars))]
	[BenchmarkCategory(Categories.New)]
	public void FileHasInvalidChars()
	{
		var result = FileHelper.FileHasInvalidChars(this._singleFile);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.MoveFile"/>.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.MoveFile))]
	[BenchmarkCategory(Categories.New)]
	public void MoveFile()
	{
		// Round-trip the file: source → dest → source so iterations stay valid
		var destFile = new FileInfo(Path.Combine(this._destinationPath.FullName, this._singleFile.Name));

		_ = FileHelper.MoveFile(this._singleFile, destFile, replaceExisting: true);
		_ = FileHelper.MoveFile(destFile, this._singleFile, replaceExisting: true);
	}

	/// <summary>
	/// Overrides Setup to initialize test directories and files for benchmarking.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperBenchmark) + "_src_" + RandomData.GenerateKey()));
		this._destinationPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperBenchmark) + "_dst_" + RandomData.GenerateKey()));

		_ = Directory.CreateDirectory(this._sourcePath.FullName);
		_ = Directory.CreateDirectory(this._destinationPath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");
		ConsoleLogger.Default.WriteLine($"Destination Path={this._destinationPath}");

		_ = RandomData.GenerateFiles(this._sourcePath.FullName, FileCount, FileLength);

		this._testFiles = this._sourcePath.GetFiles("*.*", SearchOption.TopDirectoryOnly);
		this._singleFile = this._testFiles[0];
	}

}
