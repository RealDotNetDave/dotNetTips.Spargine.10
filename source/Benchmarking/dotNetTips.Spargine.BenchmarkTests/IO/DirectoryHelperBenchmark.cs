// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="DirectoryHelperBenchmark.cs" company="DotNetTips.Spargine.BenchmarkTests">
//     David McCarter
// </copyright>
// <summary>Comprehensive benchmark tests for all public methods in DirectoryHelper.</summary>
// ***********************************************************************
using System.Collections.Generic;
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
/// Benchmark tests for all public methods in <see cref="DirectoryHelper"/>.
/// </summary>
[MemoryDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class DirectoryHelperBenchmark : Benchmark
{
	private const int FileCount = 256;
	private const int FileLength = 1024;

	private DirectoryInfo _sourcePath;
	private DirectoryInfo _tempPath;

	/// <summary>
	/// Overrides Cleanup to remove test directories created during benchmarking.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		_ = DirectoryHelper.DeleteDirectory(this._sourcePath, retries: 5);
		_ = DirectoryHelper.DeleteDirectory(this._tempPath, retries: 5);
	}

	/// <summary>
	/// Benchmark for <see cref="DirectoryHelper.LoadFilesAsync"/> with <see cref="SearchOption.TopDirectoryOnly"/>.
	/// </summary>
	[Benchmark(Description = nameof(DirectoryHelper.LoadFilesAsync))]
	[BenchmarkCategory(Categories.New)]
	public async Task LoadFilesAsync()
	{
		var directories = new List<DirectoryInfo> { this._sourcePath };

		await foreach (var files in DirectoryHelper.LoadFilesAsync(directories, "*.*", SearchOption.TopDirectoryOnly).ConfigureAwait(false))
		{
			this.Consume(files);
		}
	}

	/// <summary>
	/// Benchmark for <see cref="DirectoryHelper.LoadOneDriveFolders"/> on Windows.
	/// </summary>
	[Benchmark(Description = nameof(DirectoryHelper.LoadOneDriveFolders))]
	[BenchmarkCategory(Categories.New)]
	public void LoadOneDriveFolders()
	{
		var result = DirectoryHelper.LoadOneDriveFolders();

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="DirectoryHelper.SafeDirectorySearch"/> with <see cref="SearchOption.TopDirectoryOnly"/>.
	/// </summary>
	[Benchmark(Description = nameof(DirectoryHelper.SafeDirectorySearch))]
	[BenchmarkCategory(Categories.New)]
	public void SafeDirectorySearch()
	{
		var result = DirectoryHelper.SafeDirectorySearch(this._sourcePath, "*.*", SearchOption.TopDirectoryOnly);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="DirectoryHelper.SafeFileSearch(DirectoryInfo, string, SearchOption)"/>.
	/// </summary>
	[Benchmark(Description = "SafeFileSearch(DirectoryInfo)")]
	[BenchmarkCategory(Categories.New)]
	public void SafeFileSearch()
	{
		var result = DirectoryHelper.SafeFileSearch(this._sourcePath, "*.*", SearchOption.TopDirectoryOnly);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="DirectoryHelper.SafeFileSearch(IEnumerable{DirectoryInfo}, string, SearchOption)"/>.
	/// </summary>
	[Benchmark(Description = "SafeFileSearch(IEnumerable<DirectoryInfo>)")]
	[BenchmarkCategory(Categories.New)]
	public void SafeFileSearchEnumerable()
	{
		var directories = new List<DirectoryInfo> { this._sourcePath };
		var result = DirectoryHelper.SafeFileSearch(directories, "*.*", SearchOption.TopDirectoryOnly);

		this.ConsumeEnumerable(result);
	}

	/// <summary>
	/// Benchmark for <see cref="DirectoryHelper.SetFileAttributesToNormal"/>.
	/// </summary>
	[Benchmark(Description = nameof(DirectoryHelper.SetFileAttributesToNormal))]
	[BenchmarkCategory(Categories.New)]
	public void SetFileAttributesToNormal()
	{
		DirectoryHelper.SetFileAttributesToNormal(this._sourcePath);
	}

	/// <summary>
	/// Overrides Setup to initialize test directories and generate files for benchmarking.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(DirectoryHelperBenchmark) + "_source_" + RandomData.GenerateKey()));
		this._tempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(DirectoryHelperBenchmark) + "_temp_" + RandomData.GenerateKey()));
		_ = Directory.CreateDirectory(this._sourcePath.FullName);
		_ = Directory.CreateDirectory(this._tempPath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");
		ConsoleLogger.Default.WriteLine($"Temp Path={this._tempPath}");

		_ = RandomData.GenerateFiles(this._sourcePath.FullName, FileCount, FileLength);
	}
}
