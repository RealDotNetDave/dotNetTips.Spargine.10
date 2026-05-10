// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-10-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-10-2026
// ***********************************************************************
// <copyright file="TempFileManagerDeleteAllFilesBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Benchmark test for TempFileManager.DeleteAllFiles using IterationSetup to isolate file creation from the measured delete operation.</summary>
// ***********************************************************************

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark test for <see cref="TempFileManager.DeleteAllFiles"/>.
/// Uses <see cref="IterationSetupAttribute"/> to create files before each iteration so that only
/// the delete operation is measured, not file creation cost.
/// </summary>
[MemoryDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
[SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "TempFileManager is disposed in Cleanup(), which BenchmarkDotNet calls after all iterations.")]
public class TempFileManagerDeleteAllFilesBenchmark : Benchmark
{
	private TempFileManager _manager;

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
	/// Creates 256 temporary files before each iteration so only the delete is measured.
	/// </summary>
	[IterationSetup]
	public void IterationSetup() => _ = this._manager.CreateFiles(256);

	/// <summary>
	/// Overrides Setup to initialize a fresh <see cref="TempFileManager"/> instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._manager = new TempFileManager();
	}
}
