// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : David McCarter
// Last Modified On : 05-12-2026
// ***********************************************************************
// <copyright file="FileHelperUnGZipAsyncBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark test for FileHelper.UnGZipAsync using IterationSetup to isolate gzip creation from the measured decompression operation.</summary>
// ***********************************************************************

using System.IO;
using System.IO.Compression;
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
/// Benchmark test for <see cref="FileHelper.UnGZipAsync"/> using <see cref="IterationSetupAttribute"/> to isolate
/// gzip file creation from the measured decompression operation.
/// </summary>
[MemoryDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileHelperUnGZipAsyncBenchmark : Benchmark
{
	private const int FileLength = 4096;

	private FileInfo _gzipFile;
	private DirectoryInfo _outDir;
	private FileInfo _sourceFile;
	private DirectoryInfo _sourcePath;

	/// <summary>
	/// Overrides Cleanup to remove the source directory created during setup.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		_ = DirectoryHelper.DeleteDirectory(this._sourcePath, retries: 5);
	}

	/// <summary>
	/// Removes the decompression output directory after each iteration.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		_ = DirectoryHelper.DeleteDirectory(this._outDir, retries: 5);
	}

	/// <summary>
	/// Creates a fresh gzip file and output directory before each iteration so only decompression is timed.
	/// </summary>
	[IterationSetup]
	public void IterationSetup()
	{
		var gzipPath = Path.Combine(this._sourcePath.FullName, RandomData.GenerateKey() + ".gz");

		using (var sourceStream = this._sourceFile.OpenRead())
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
		this._outDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperUnGZipAsyncBenchmark) + "_out_filehelper_" + RandomData.GenerateKey()));
		_ = Directory.CreateDirectory(this._outDir.FullName);
	}

	/// <summary>
	/// Overrides Setup to create the source file that will be compressed each iteration.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperUnGZipAsyncBenchmark) + "_source_filehelper_" + RandomData.GenerateKey()));
		_ = Directory.CreateDirectory(this._sourcePath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");

		var files = RandomData.GenerateFiles(this._sourcePath.FullName, count: 1, fileLength: FileLength);
		this._sourceFile = new FileInfo(files[0]);
	}

	/// <summary>
	/// Benchmark for <see cref="FileHelper.UnGZipAsync(FileInfo, DirectoryInfo, System.Threading.CancellationToken)"/>.
	/// Gzip creation is isolated to <see cref="IterationSetupAttribute"/>; only decompression is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.UnGZipAsync))]
	[BenchmarkCategory(Categories.New)]
	public async Task UnGZipAsync()
	{
		await FileHelper.UnGZipAsync(this._gzipFile, this._outDir).ConfigureAwait(false);
	}
}
