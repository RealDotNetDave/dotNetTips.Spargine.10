// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-12-2026
//
// Last Modified By : David McCarter
// Last Modified On : 05-12-2026
// ***********************************************************************
// <copyright file="FileProcessorDeleteFoldersBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark test for FileProcessor.DeleteFolders using IterationSetup to pre-create
// target directories so only the delete operation is measured.
// </summary>
// ***********************************************************************

using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

/// <summary>
/// Benchmark test for <see cref="FileProcessor.DeleteFolders"/>.
/// Uses <see cref="IterationSetupAttribute"/> to create the target directories before each iteration
/// so that only the delete operation itself is measured.
/// </summary>
[MemoryDiagnoser]
[BenchmarkCategory(Categories.IO)]
[SupportedOSPlatform("windows")]
public class FileProcessorDeleteFoldersBenchmark : Benchmark
{
	private const int FolderCount = 5;

	private FileProcessor _fileProcessor;
	private List<DirectoryInfo> _foldersToDelete;

	/// <summary>
	/// Benchmark for <see cref="FileProcessor.DeleteFolders"/>.
	/// Target directories are pre-created in <see cref="IterationSetupAttribute"/>; only the delete is measured.
	/// </summary>
	[Benchmark(Description = nameof(FileProcessor.DeleteFolders))]
	[BenchmarkCategory(Categories.New)]
	public void DeleteFolders()
	{
		var result = this._fileProcessor.DeleteFolders(this._foldersToDelete, recursive: true);

		this.Consume(result);
	}

	/// <summary>
	/// Creates <see cref="FolderCount"/> fresh temporary directories before each iteration
	/// so only the delete operation is timed.
	/// </summary>
	[IterationSetup]
	public void IterationSetup()
	{
		this._foldersToDelete = new List<DirectoryInfo>(FolderCount);

		for (var folderIndex = 0; folderIndex < FolderCount; folderIndex++)
		{
			var dir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(FileProcessorDeleteFoldersBenchmark) + "_temp_fileprocessor_" + RandomData.GenerateKey()));

			_ = Directory.CreateDirectory(dir.FullName);

			this._foldersToDelete.Add(dir);
		}
	}

	/// <summary>
	/// Overrides Setup to initialize the <see cref="FileProcessor"/> instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._fileProcessor = new FileProcessor();
	}
}
