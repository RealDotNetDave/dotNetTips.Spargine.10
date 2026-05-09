// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="TempFileManagerDeleteFilesBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for TempFileManager.DeleteAllFiles and DeleteFile using IterationSetup to isolate file creation from the measured delete operations.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark tests for <see cref="TempFileManager.DeleteAllFiles"/> and <see cref="TempFileManager.DeleteFile"/>.
/// Uses <see cref="IterationSetupAttribute"/> to create files before each iteration so that only the
/// delete operation itself is measured, not the file creation cost.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "TempFileManager is disposed in Cleanup(), which BenchmarkDotNet calls after all iterations.")]
public class TempFileManagerDeleteFilesBenchmark : Benchmark
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
	/// Benchmark for <see cref="TempFileManager.DeleteAllFiles"/>.
	/// Files are created in <see cref="IterationSetupAttribute"/>; only the delete is measured.
	/// </summary>
	[Benchmark(Description = nameof(TempFileManager.DeleteAllFiles))]
	[BenchmarkCategory(Categories.New)]
	public void DeleteAllFiles() => this._manager.DeleteAllFiles();

	/// <summary>
	/// Benchmark for <see cref="TempFileManager.DeleteFile"/>.
	/// The target file is created in <see cref="IterationSetupAttribute"/>; only the delete is measured.
	/// </summary>
	[Benchmark(Description = nameof(TempFileManager.DeleteFile))]
	[BenchmarkCategory(Categories.New)]
	public void DeleteFile() => this._manager.DeleteFile(this._singleFile);

	/// <summary>
	/// Seeds 10 files into the manager before each iteration of <see cref="DeleteAllFiles"/>
	/// and pre-creates one file for <see cref="DeleteFile"/>, so neither benchmark measures creation time.
	/// </summary>
	[IterationSetup]
	public void IterationSetup()
	{
		_ = this._manager.CreateFiles(256);
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
