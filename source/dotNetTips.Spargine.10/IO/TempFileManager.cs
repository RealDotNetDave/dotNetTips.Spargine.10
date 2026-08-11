// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 08-11-2026
// ***********************************************************************
// <copyright file="TempFileManager.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>TempFileManager creates and maintains a list of temporary files.</summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.IO;

/// <summary>
/// TempFileManager creates and maintains a list of temporary files. Implements the <see cref="IDisposable" />.
/// </summary>
/// <seealso cref="IDisposable" />
/// <remarks>
/// Initializes a new instance of the <see cref="TempFileManager" /> class.
/// </remarks>
[SupportedOSPlatform("windows")]
[Information(nameof(TempFileManager), "David McCarter", "8/4/2024", Status = Status.Available, Documentation = "https://bit.ly/SpargineTempFileManager")]
public sealed class TempFileManager() : IDisposable, IAsyncDisposable
{

	/// <summary>
	/// Tracks temporary files managed by this instance.
	/// </summary>
	private readonly ConcurrentDictionary<string, byte> _files = new(StringComparer.OrdinalIgnoreCase);

	/// <summary>
	/// Indicates whether the object has been disposed.
	/// </summary>
	private bool _disposed;

	/// <summary>
	/// Finalizes an instance of the <see cref="TempFileManager"/> class.
	/// </summary>
	~TempFileManager()
	{
		this.Dispose(false);
	}

	/// <summary>
	/// Asynchronously performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	/// <returns>A task that represents the asynchronous dispose operation.</returns>
	[Information(nameof(IAsyncDisposable.DisposeAsync), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	ValueTask IAsyncDisposable.DisposeAsync()
	{
		// File.Delete has no native async API; synchronous disposal avoids occupying a thread-pool thread via Task.Run.
		this.Dispose(true);
		GC.SuppressFinalize(this);
		return ValueTask.CompletedTask;
	}

	/// <summary>
	/// Creates a new temporary file.
	/// </summary>
	/// <returns>The path of the created temporary file.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CreateFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public string CreateFile()
	{
		var file = GenerateRandomFile();
		_ = this._files.TryAdd(file, default);

		return file;
	}

	/// <summary>
	/// Creates multiple temp files.
	/// </summary>
	/// <param name="count">The number of temporary files to create.</param>
	/// <returns>A read-only collection of the paths of the created temporary files.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CreateFiles), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public ReadOnlyCollection<string> CreateFiles(in int count)
	{
		var fileCount = count.ArgumentInRange(min: 1);

		return fileCount < App.MaxDegreeOfParallelism()
			? this.CreateFilesSequential(fileCount)
			: this.CreateFilesParallel(fileCount);
	}

	/// <summary>
	/// Deletes all temporary files.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DeleteAllFiles), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public void DeleteAllFiles()
	{
		var fileCount = this._files.Count;

		if (fileCount == 0)
		{
			return;
		}

		var filesSnapshot = GC.AllocateUninitializedArray<string>(fileCount);
		var fileIndex = 0;

		foreach (var file in this._files.Keys)
		{
			filesSnapshot[fileIndex++] = file;
		}

		if (fileIndex != filesSnapshot.Length)
		{
			Array.Resize(ref filesSnapshot, fileIndex);
			fileCount = fileIndex;
		}

		var filesDeletedResult = FileHelper.DeleteFiles(new ReadOnlyCollection<string>(filesSnapshot));

		if (filesDeletedResult.Value.Count == fileCount)
		{
			this._files.Clear();
			return;
		}

		this.DeleteFilesFromCache(filesDeletedResult.Value);
	}

	/// <summary>
	/// Deletes the specified file.
	/// </summary>
	/// <param name="fileName">The name of the file to delete. Must not be null or empty.</param>
	/// <remarks>
	/// This method deletes the specified file and removes it from the cache of managed files.
	/// If the file name is null or empty, the method returns without performing any action.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DeleteFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.CheckPerformance, Status = Status.Available)]
	public void DeleteFile(string fileName)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			return;
		}

		if (TryDeleteFile(fileName))
		{
			this.DeleteFileFromCache(fileName);
		}
	}

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	[Preserve(PreserveReason.MethodPartOfIDisposable, "2/12/2025", "David McCarter")]
	[Information(nameof(Dispose), UnitTestStatus = UnitTestStatus.NotRequired, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Gets the list of files currently being managed.
	/// </summary>
	/// <returns>A read-only collection of the paths of the managed temporary files.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(GetManagedFiles), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public ReadOnlyCollection<string> GetManagedFiles()
	{
		return this._files.Keys.ToReadOnlyCollection();
	}

	/// <summary>
	/// Generates a random temporary file.
	/// </summary>
	/// <returns>The path of the created temporary file.</returns>
	private static string GenerateRandomFile()
	{
		var tempFilePath = Path.Combine(Path.GetTempPath(), string.Concat(Ulid.NewUlid().ToString(), ".dntt"));

		try
		{
			// Create file and immediately release the handle.
			using (File.Create(tempFilePath))
			{ }

			// Set attributes directly — avoids allocating a FileInfo object.
			File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Temporary);
		}
#pragma warning disable CA1031
		catch (Exception ex) // Rethrow as IOException with context
#pragma warning restore CA1031
		{
			ExceptionThrower.ThrowIOException(Resources.FailedToCreateTemporaryFile, ex);
		}

		return tempFilePath;
	}

	/// <summary>
	/// Attempts to delete the specified file.
	/// </summary>
	/// <param name="fileName">The full path of the file to delete.</param>
	/// <returns><see langword="true"/> if the file was deleted; otherwise <see langword="false"/>.</returns>
	private static bool TryDeleteFile(string fileName)
	{
		try
		{
			if (!File.Exists(fileName))
			{
				return false;
			}

			File.Delete(fileName);
			return true;
		}
		catch (Exception ex) when (ex is ArgumentException or
			ArgumentNullException or
			System.IO.DirectoryNotFoundException or
			IOException or
			NotSupportedException or
			PathTooLongException or
			UnauthorizedAccessException)
		{
			return false;
		}
	}

	/// <summary>
	/// Creates multiple temporary files in parallel (for counts &gt; 2).
	/// </summary>
	/// <param name="count">The number of files to create.</param>
	/// <returns>A read-only collection of created file paths.</returns>
	private ReadOnlyCollection<string> CreateFilesParallel(int count)
	{
		var result = new string[count];

		_ = Parallel.For(0, count, index => result[index] = GenerateRandomFile());

		for (var fileIndex = 0; fileIndex < count; fileIndex++)
		{
			_ = this._files.TryAdd(result[fileIndex], default);
		}

		return new ReadOnlyCollection<string>(result);
	}

	/// <summary>
	/// Creates multiple temporary files sequentially (for small counts ≤ 2).
	/// </summary>
	/// <param name="count">The number of files to create.</param>
	/// <returns>A read-only collection of created file paths.</returns>
	private ReadOnlyCollection<string> CreateFilesSequential(int count)
	{
		var small = new string[count];

		for (var index = 0; index < count; index++)
		{
			var file = GenerateRandomFile();
			small[index] = file;
			_ = this._files.TryAdd(file, default);
		}

		return new ReadOnlyCollection<string>(small);
	}

	/// <summary>
	/// Removes the specified file from the cache.
	/// </summary>
	/// <param name="fileName">The file path to remove from the cache.</param>
	private void DeleteFileFromCache(string fileName)
	{
		if (string.IsNullOrEmpty(fileName) || this._files.IsEmpty)
		{
			return;
		}

		_ = this._files.TryRemove(fileName, out _);
	}

	/// <summary>
	/// Removes the specified files from the cache.
	/// </summary>
	/// <param name="files">A read-only collection of file paths to remove from the cache.</param>
	private void DeleteFilesFromCache(ReadOnlyCollection<string> files)
	{
		if (files.Count == 0 || this._files.IsEmpty)
		{
			return;
		}

		foreach (var file in files)
		{
			_ = this._files.TryRemove(file, out _);
		}
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	private void Dispose(bool disposing)
	{
		if (!this._disposed)
		{
			// If disposing equals true, dispose all managed and unmanaged resources.
			if (disposing)
			{
				// Dispose managed resources.
				this.DeleteAllFiles();
			}
		}

		this._disposed = true;
	}

}
