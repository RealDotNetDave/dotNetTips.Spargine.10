// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="TempFileManagerCreateFilesBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark tests for TempFileManager.CreateFile and CreateFiles using IterationCleanup to prevent unbounded file accumulation across iterations.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark tests for <see cref="TempFileManager.CreateFile"/> and <see cref="TempFileManager.CreateFiles"/>.
/// Uses <see cref="IterationCleanupAttribute"/> to delete created files after each iteration, preventing
/// unbounded state accumulation that would skew later iteration timings.
/// </summary>
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "TempFileManager is disposed in Cleanup(), which BenchmarkDotNet calls after all iterations.")]
public class TempFileManagerCreateFilesBenchmark : Benchmark
{
	private TempFileManager _manager;

	/// <summary>
	/// Overrides Cleanup to dispose the <see cref="TempFileManager"/> and remove all remaining temporary files.
	/// </summary>
	public override void Cleanup()
	{
		base.Cleanup();

		this._manager.DeleteAllFiles();
		this._manager.Dispose();
	}

	/// <summary>
	/// Benchmark for <see cref="TempFileManager.CreateFile"/>.
	/// Files are removed after each iteration by <see cref="IterationCleanupAttribute"/> to prevent accumulation.
	/// </summary>
	[Benchmark(Description = nameof(TempFileManager.CreateFile))]
	[BenchmarkCategory(Categories.New)]
	public void CreateFile()
	{
		var result = this._manager.CreateFile();

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="TempFileManager.CreateFiles"/> exercising the parallel path (count &gt; 2).
	/// Files are removed after each iteration by <see cref="IterationCleanupAttribute"/> to prevent accumulation.
	/// </summary>
	[Benchmark(Description = "CreateFiles-Parallel")]
	[BenchmarkCategory(Categories.New)]
	public void CreateFilesParallel()
	{
		var result = this._manager.CreateFiles(10);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for <see cref="TempFileManager.CreateFiles"/> exercising the sequential path (count &lt;= 2).
	/// Files are removed after each iteration by <see cref="IterationCleanupAttribute"/> to prevent accumulation.
	/// </summary>
	[Benchmark(Description = "CreateFiles-Sequential")]
	[BenchmarkCategory(Categories.New)]
	public void CreateFilesSequential()
	{
		var result = this._manager.CreateFiles(2);

		this.Consume(result);
	}

	/// <summary>
	/// Removes all managed files after each iteration so file count stays constant across iterations.
	/// </summary>
	[IterationCleanup]
	public void IterationCleanup() => this._manager.DeleteAllFiles();

	/// <summary>
	/// Overrides Setup to initialize a fresh <see cref="TempFileManager"/> instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._manager = new TempFileManager();
	}
}
