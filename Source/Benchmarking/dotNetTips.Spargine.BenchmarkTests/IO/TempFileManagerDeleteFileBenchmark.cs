// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-10-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-19-2026
// ***********************************************************************
// <copyright file="TempFileManagerDeleteFileBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark test for TempFileManager.DeleteFile using IterationSetup/IterationCleanup to isolate single-file creation and ensure no file accumulation across iterations.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark test for <see cref="TempFileManager.DeleteFile"/>.
/// Uses <see cref="IterationSetupAttribute"/> to create exactly one file before each iteration
/// and <see cref="IterationCleanupAttribute"/> to remove any leftover files, ensuring no
/// accumulation across iterations.
/// </summary>
[MemoryDiagnoser]
[TailCallDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "TempFileManager is disposed in Cleanup(), which BenchmarkDotNet calls after all iterations.")]
public class TempFileManagerDeleteFileBenchmark : Benchmark
{
	private TempFileManager _manager;
	private string _singleFile;

	/// <summary>
	/// Overrides Cleanup to dispose the <see cref="TempFileManager"/> and remove any remaining temporary files.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		this._manager.DeleteAllFiles();
		this._manager.Dispose();
	}

	/// <summary>
	/// Benchmark for <see cref="TempFileManager.DeleteFile"/>.
	/// Exactly one file is created in <see cref="IterationSetupAttribute"/>; only the delete is measured.
	/// </summary>
	[Benchmark(Description = nameof(TempFileManager.DeleteFile))]
	[BenchmarkCategory(Categories.IO)]
	public void DeleteFile()
	{
		this._manager.DeleteFile(this._singleFile);
	}

	/// <summary>
	/// Removes any file that was not deleted during the benchmark iteration (e.g., if the benchmark
	/// was skipped or errored) so files do not accumulate.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup()
	{
		this._manager.DeleteAllFiles();
	}

	/// <summary>
	/// Creates exactly one temporary file before each iteration so only the single-file delete is measured.
	/// </summary>
	[IterationSetup]
	public void IterationSetup()
	{
		this._singleFile = this._manager.CreateFile();
	}

	/// <summary>
	/// Overrides Setup to initialize a fresh <see cref="TempFileManager"/> instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._manager = new TempFileManager();
	}
}

