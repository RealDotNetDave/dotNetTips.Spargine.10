// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-10-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="DirectoryHelperCopyDirectoryBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark test for DirectoryHelper.CopyDirectory using IterationCleanup to ensure each iteration measures a clean copy with no pre-existing destination files.</summary>
// ***********************************************************************

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
/// Benchmark test for <see cref="DirectoryHelper.CopyDirectory"/>.
/// Uses <see cref="IterationCleanupAttribute"/> to delete the destination directory contents after
/// each iteration so that every iteration measures a clean copy rather than an overwrite.
/// </summary>
[MemoryDiagnoser]
[TailCallDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class DirectoryHelperCopyDirectoryBenchmark : Benchmark
{
	private const int FileCount = 256;
	private const int FileLength = 1024;

	private DirectoryInfo _copyDestinationPath;
	private DirectoryInfo _sourcePath;

	/// <summary>
	/// Overrides Cleanup to remove test directories created during benchmarking.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		_ = DirectoryHelper.DeleteDirectory(this._sourcePath, retries: 5);
		_ = DirectoryHelper.DeleteDirectory(this._copyDestinationPath, retries: 5);
	}

	/// <summary>
	/// Benchmark for <see cref="DirectoryHelper.CopyDirectory"/>.
	/// Destination contents are removed after each iteration by <see cref="IterationCleanupAttribute"/>
	/// so only a clean copy is measured.
	/// </summary>
	[Benchmark(Description = nameof(DirectoryHelper.CopyDirectory))]
	[BenchmarkCategory(Categories.New)]
	public void CopyDirectory()
	{
		DirectoryHelper.CopyDirectory(this._sourcePath, this._copyDestinationPath, overwrite: true);
	}

	/// <summary>
	/// Overrides Setup to create the source directory, generate test files, and create an empty
	/// destination directory ready for the first copy.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._sourcePath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(DirectoryHelperCopyDirectoryBenchmark) + "_source_directoryhelper_" + RandomData.GenerateKey()));
		this._copyDestinationPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(DirectoryHelperCopyDirectoryBenchmark) + "_destination_directoryhelper_" + RandomData.GenerateKey()));

		_ = Directory.CreateDirectory(this._sourcePath.FullName);
		_ = Directory.CreateDirectory(this._copyDestinationPath.FullName);

		ConsoleLogger.Default.WriteLine($"Source Path={this._sourcePath}");
		ConsoleLogger.Default.WriteLine($"Destination Path={this._copyDestinationPath}");

		_ = RandomData.GenerateFiles(this._sourcePath.FullName, FileCount, FileLength);
	}
}
