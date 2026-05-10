// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
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
	/// Indicates whether the object has been disposed.
	/// </summary>
	private bool _disposed;

	/// <summary>
	/// The list of temporary files managed by this instance.
	/// </summary>
	private ConcurrentBag<string> _files = [];

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
	[Information(nameof(CreateFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public string CreateFile()
	{
		var file = GenerateRandomFile();
		this._files.Add(file);

		return file;
	}

	/// <summary>
	/// Creates multiple temp files.
	/// </summary>
	/// <param name="count">The number of temporary files to create.</param>
	/// <returns>A read-only collection of the paths of the created temporary files.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CreateFiles), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public ReadOnlyCollection<string> CreateFiles(in int count)
	{
		_ = count.ArgumentInRange(min: 1);

		// Avoid parallel overhead for very small counts.
		return count <= 2
			? this.CreateFilesSequential(count)
			: this.CreateFilesParallel(count);
	}

	/// <summary>
	/// Deletes all temporary files.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DeleteAllFiles), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void DeleteAllFiles()
	{
		// Pass _files directly to avoid the ToReadOnlyCollection() intermediate allocation.
		var snapshot = this._files.Count;
		var filesDeletedResult = FileHelper.DeleteFiles(this._files.AsEnumerable().ToReadOnlyCollection());

		if (filesDeletedResult.Value.Count == snapshot)
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
	[Information(nameof(DeleteFile), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public void DeleteFile(string fileName)
	{
		if (string.IsNullOrEmpty(fileName))
		{
			return;
		}

		var filesDeletedResult = FileHelper.DeleteFiles(new ReadOnlyCollection<string>([fileName]));

		if (filesDeletedResult.Value.Count > 0)
		{
			this.DeleteFilesFromCache(filesDeletedResult.Value);
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
	public ReadOnlyCollection<string> GetManagedFiles() => this._files.ToReadOnlyCollection();

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
	/// Creates multiple temporary files in parallel (for counts &gt; 2).
	/// </summary>
	/// <param name="count">The number of files to create.</param>
	/// <returns>A read-only collection of created file paths.</returns>
	private ReadOnlyCollection<string> CreateFilesParallel(int count)
	{
		// Preallocate result buffer; populate in parallel then add to _files sequentially
		// to eliminate ConcurrentBag cross-thread contention inside the hot loop.
		var result = new string[count];

		_ = Parallel.For(0, count, index => result[index] = GenerateRandomFile());

		foreach (var file in result)
		{
			this._files.Add(file);
		}

		return result.AsReadOnly();
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
			this._files.Add(file);
		}

		return new ReadOnlyCollection<string>(small);
	}

	/// <summary>
	/// Removes the specified files from the cache.
	/// </summary>
	/// <param name="files">A read-only collection of file paths to remove from the cache.</param>
	private void DeleteFilesFromCache(ReadOnlyCollection<string> files)
	{
		var deletedSet = new HashSet<string>(files, StringComparer.OrdinalIgnoreCase);
		var tempBag = new ConcurrentBag<string>();

		// Parallel overhead is not worthwhile for small file counts.
		if (this._files.Count <= 50)
		{
			this.FilterFilesSequential(deletedSet, tempBag);
		}
		else
		{
			this.FilterFilesParallel(deletedSet, tempBag);
		}

		this._files = tempBag;
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

	/// <summary>
	/// Filters files in parallel, retaining those not in the deleted set.
	/// </summary>
	/// <param name="deletedSet">The set of deleted file paths.</param>
	/// <param name="tempBag">The bag to add retained files to.</param>
	private void FilterFilesParallel(HashSet<string> deletedSet, ConcurrentBag<string> tempBag) =>
		_ = Parallel.ForEach(this._files, file =>
		{
			if (!deletedSet.Contains(file))
			{
				tempBag.Add(file);
			}
		});

	/// <summary>
	/// Filters files sequentially, retaining those not in the deleted set.
	/// </summary>
	/// <param name="deletedSet">The set of deleted file paths.</param>
	/// <param name="tempBag">The bag to add retained files to.</param>
	private void FilterFilesSequential(HashSet<string> deletedSet, ConcurrentBag<string> tempBag)
	{
		foreach (var file in this._files)
		{
			if (!deletedSet.Contains(file))
			{
				tempBag.Add(file);
			}
		}
	}
}
