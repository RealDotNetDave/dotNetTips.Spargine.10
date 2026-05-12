// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : David McCarter
// Last Modified On : 05-12-2026
// ***********************************************************************
// <copyright file="FileHelperCopyFileBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for FileHelper.CopyFile and CopyFileAsync using IterationCleanup to ensure each iteration measures a clean copy with no pre-existing destination file.</summary>
// ***********************************************************************

using System.IO;
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
/// Benchmark tests for <see cref="FileHelper.CopyFile(FileInfo, DirectoryInfo)"/> and
/// <see cref="FileHelper.CopyFileAsync(FileInfo, DirectoryInfo, System.Threading.CancellationToken)"/>.
/// Uses <see cref="IterationCleanupAttribute"/> to delete the destination file after each iteration so that
/// every iteration measures a clean copy with no pre-existing destination — avoiding the hidden
/// <see cref="File.Delete"/> cost that the implementations perform when overwriting.
/// </summary>
[MemoryDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileHelperCopyFileBenchmark : Benchmark
{
	private const int FileLength = 4096;

	private DirectoryInfo _destinationPath;
	private FileInfo _singleFile;
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
	/// Benchmark for <see cref="FileHelper.CopyFile(FileInfo, DirectoryInfo)"/>.
	/// The destination file is removed after each iteration by <see cref="IterationCleanupAttribute"/>
	/// so only the copy itself is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.CopyFile))]
	[BenchmarkCategory(Categories.New)]
	public void CopyFile()
	{
		var result = FileHelper.CopyFile(this._singleFile, this._destinationPath);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.CopyFileAsync(FileInfo, DirectoryInfo, System.Threading.CancellationToken)"/>.
	/// The destination file is removed after each iteration by <see cref="IterationCleanupAttribute"/>
	/// so only the async copy itself is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.CopyFileAsync))]
	[BenchmarkCategory(Categories.New)]
	public async Task CopyFileAsync()
	{
		var result = await FileHelper.CopyFileAsync(this._singleFile, this._destinationPath).ConfigureAwait(false);

		this.Consume(result);
	}

	/// <summary>
	/// Deletes the copied file from the destination after each iteration so the next iteration
	/// always measures a fresh copy with no pre-existing destination file.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		var destFile = Path.Combine(this._destinationPath.FullName, this._singleFile.Name);

		if (File.Exists(destFile))
		{
			File.Delete(destFile);
		}
	}

	/// <summary>
	/// Overrides Setup to create source and destination directories and generate the file to copy.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperCopyFileBenchmark) + "_source_filehelper_" + RandomData.GenerateKey()));
		this._destinationPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperCopyFileBenchmark) + "_destination_filehelper_" + RandomData.GenerateKey()));

		_ = Directory.CreateDirectory(this._sourcePath.FullName);
		_ = Directory.CreateDirectory(this._destinationPath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");
		ConsoleLogger.Default.WriteLine($"Destination Path={this._destinationPath}");

		var files = RandomData.GenerateFiles(this._sourcePath.FullName, count: 1, fileLength: FileLength);
		this._singleFile = new FileInfo(files[0]);
	}
}
