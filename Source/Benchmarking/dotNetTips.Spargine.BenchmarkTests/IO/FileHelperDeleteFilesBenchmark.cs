// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="FileHelperDeleteFilesBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark test for FileHelper.DeleteFiles using IterationSetup to isolate file generation from the measured delete operation.</summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark test for <see cref="FileHelper.DeleteFiles"/> using <see cref="IterationSetupAttribute"/> to isolate
/// file generation from the measured delete operation.
/// </summary>
[MemoryDiagnoser]
[TailCallDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileHelperDeleteFilesBenchmark : Benchmark
{
	private const int FileCount = 256;
	private const int FileLength = 4096;

	private ReadOnlyCollection<string> _filePaths;
	private DirectoryInfo _tempDir;

	/// <summary>
	/// Benchmark for <see cref="FileHelper.DeleteFiles"/>.
	/// File creation is isolated to <see cref="IterationSetupAttribute"/>; only the delete is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileHelper.DeleteFiles))]
	[BenchmarkCategory(Categories.IO)]
	public void DeleteFiles()
	{
		var result = this._filePaths.DeleteFiles();

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
	/// Creates fresh temporary files before each iteration so only the delete is timed.
	/// </summary>
	[IterationSetup]
	public void IterationSetup()
	{
		this._tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileHelperDeleteFilesBenchmark) + "_temp_filehelper_" + RandomData.GenerateKey()));
		_ = Directory.CreateDirectory(this._tempDir.FullName);
		_ = RandomData.GenerateFiles(this._tempDir.FullName, FileCount, FileLength);

		this._filePaths = new ReadOnlyCollection<string>([.. this._tempDir.GetFiles().Select(f => f.FullName)]);
	}
}
