// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="TempFileManagerBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for TempFileManager.DeleteAllFiles and DeleteFile. Create* benchmarks live in TempFileManagerCreateFilesBenchmark.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark tests for public methods in <see cref="TempFileManager"/> with <c>BenchmarkStatus.Benchmark</c>.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "TempFileManager is disposed in Cleanup(), which BenchmarkDotNet calls after all iterations.")]
public class TempFileManagerBenchmark : Benchmark
{
	private TempFileManager _manager;

	/// <summary>
	/// Overrides Cleanup to dispose the <see cref="TempFileManager"/> and remove all temporary files.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		this._manager.DeleteAllFiles();
		this._manager.Dispose();
	}

	/// <summary>
	/// Benchmark for <see cref="TempFileManager.DeleteAllFiles"/>.
	/// Creates files before each delete so the operation has real targets.
	/// </summary>
	[Benchmark(Description = nameof(TempFileManager.DeleteAllFiles))]
	[BenchmarkCategory(Categories.New)]
	public void DeleteAllFiles()
	{
		// Seed with fresh files each iteration
		_ = this._manager.CreateFiles(10);

		this._manager.DeleteAllFiles();
	}

	/// <summary>
	/// Benchmark for <see cref="TempFileManager.DeleteFile"/>.
	/// Creates a file before each delete so the operation has a real target.
	/// </summary>
	[Benchmark(Description = nameof(TempFileManager.DeleteFile))]
	[BenchmarkCategory(Categories.New)]
	public void DeleteFile()
	{
		var file = this._manager.CreateFile();

		this._manager.DeleteFile(file);
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
