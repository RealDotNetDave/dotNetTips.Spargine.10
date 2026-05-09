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
// <summary>Comprehensive benchmark tests for public methods in FileHelper with BenchmarkStatus.Benchmark.</summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
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
	private const int FileCount = 10;
	private const int FileLength = 4096;

	private DirectoryInfo _destinationPath;
	private FileInfo _gzipFile;
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
	/// Benchmark for <see cref="FileHelper.CopyFile(FileInfo, DirectoryInfo)"/>.
	/// </summary>
	[Benchmark(Description = "CopyFile")]
	[BenchmarkCategory(Categories.New)]
	public void CopyFile()
	{
		var result = FileHelper.CopyFile(this._singleFile, this._destinationPath);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.CopyFileAsync"/>.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.CopyFileAsync))]
	[BenchmarkCategory(Categories.New)]
	public async Task CopyFileAsync()
	{
		var result = await FileHelper.CopyFileAsync(this._singleFile, this._destinationPath).ConfigureAwait(false);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.DeleteFiles"/>.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.DeleteFiles))]
	[BenchmarkCategory(Categories.New)]
	public void DeleteFiles()
	{
		// Generate fresh files each iteration so the delete has real targets
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.DeleteFiles) + RandomData.GenerateKey()));
		_ = Directory.CreateDirectory(tempDir.FullName);
		_ = RandomData.GenerateFiles(tempDir.FullName, FileCount, FileLength);

		var filePaths = new ReadOnlyCollection<string>([.. tempDir.GetFiles().Select(f => f.FullName)]);
		var result = filePaths.DeleteFiles();

		this.Consume(result);

		_ = DirectoryHelper.DeleteDirectory(tempDir, retries: 5);
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

		// Create a gzip file for UnGZipAsync benchmarks
		var gzipPath = Path.Combine(this._sourcePath.FullName, "test.gz");
		using (var sourceStream = this._singleFile.OpenRead())
		{
			using (var gzipStream = new FileStream(gzipPath, FileMode.Create, FileAccess.Write))
			{
				using (var compressor = new GZipStream(gzipStream, CompressionMode.Compress))
				{
					sourceStream.CopyTo(compressor);
				}
			}
		}

		this._gzipFile = new FileInfo(gzipPath);
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.UnGZipAsync(FileInfo, DirectoryInfo, CancellationToken)"/>.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.UnGZipAsync))]
	[BenchmarkCategory(Categories.New)]
	public async Task UnGZipAsync()
	{
		// Re-create the gzip on each iteration so the decompression target exists
		var gzipPath = Path.Combine(this._sourcePath.FullName, "bench_" + RandomData.GenerateKey() + ".gz");
		using (var sourceStream = this._singleFile.OpenRead())
		{
			using (var gzipStream = new FileStream(gzipPath, FileMode.Create, FileAccess.Write))
			{
				using (var compressor = new GZipStream(gzipStream, CompressionMode.Compress))
				{
					await sourceStream.CopyToAsync(compressor).ConfigureAwait(false);
				}
			}
		}

		var outDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsync) + RandomData.GenerateKey()));
		_ = Directory.CreateDirectory(outDir.FullName);

		await FileHelper.UnGZipAsync(new FileInfo(gzipPath), outDir).ConfigureAwait(false);

		_ = DirectoryHelper.DeleteDirectory(outDir, retries: 5);
	}
}
