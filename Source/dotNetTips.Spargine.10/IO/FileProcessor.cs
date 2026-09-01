// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-16-2026
// ***********************************************************************
// <copyright file="FileProcessor.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Facilitates file copying and deletion operations,
// incorporating event handling for files. Additionally, it offers the
// capability to delete folders.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Diagnostics;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Facilitates file copying, deletion, and folder deletion operations. It incorporates event handling to notify about the progress and status of file operations.
/// </summary>
/// <remarks>
/// <para>This class provides methods to copy and delete files and folders with the added capability of event-based notifications for each operation. This allows for real-time monitoring of the process, including success, failure, and progress updates.</para>
/// <para>Events:</para>
/// <list type="bullet">
/// <item>
/// <description><see cref="Processed"/>: Occurs when a file or folder has been processed, providing details such as the operation performed, the name of the file or folder, and the outcome.</description>
/// </item>
/// </list>
/// <para>Usage:</para>
/// <code>
/// var fileProcessor = new FileProcessor();
/// fileProcessor.Processed += (sender, e) => 
/// {
///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
/// };
/// 
/// var filesToCopy = new List&lt;FileInfo&gt; { new FileInfo("path/to/source/file.txt") };
/// var destinationDir = new DirectoryInfo("path/to/destination");
/// fileProcessor.CopyFilesWithOriginalPath(filesToCopy, destinationDir);
/// </code>
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineFileProcessor")]
public sealed class FileProcessor
{
	/// <summary>
	/// Occurs when a file or folder has been processed.
	/// </summary>
	/// <remarks>
	/// This event can be used to receive notifications about the progress and status of file and folder operations such as copying, deletion, etc.
	/// Each event provides data through <see cref="ProgressEventArgs"/> which includes details like the operation performed, the name of the file or folder, and the outcome.
	/// </remarks>
	public event EventHandler<ProgressEventArgs>? Processed;

	/// <summary>
	/// Copies files to a new location.
	/// </summary>
	/// <param name="files">The files to copy.</param>
	/// <param name="destination">The destination folder where files will be copied.</param>
	/// <param name="overwrite">If <see langword="true"/>, overwrites existing files at the destination; otherwise, throws an exception if a file already exists.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of files successfully copied.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if file copy succeeded or failed.
	/// </remarks>
	/// <exception cref="OperationCanceledException">The operation was canceled via the cancellation token.</exception>
	/// <example>
	/// Here is an example of using the <see cref="CopyFiles"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var filesToCopy = new List&lt;FileInfo&gt; { new FileInfo("path/to/source/file.txt") };
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// var cts = new CancellationTokenSource();
	/// fileProcessor.CopyFiles(filesToCopy, destinationDir, cancellationToken: cts.Token);
	/// </code>
	/// </example>
	[Information(nameof(CopyFiles), author: "David McCarter", createdOn: "1/20/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int CopyFiles(IEnumerable<FileInfo> files, [DisallowNull] DirectoryInfo destination, in bool overwrite = true, CancellationToken cancellationToken = default)
	{
		destination = destination.ArgumentNotNull();

		var list = PrepareList(files);

		if (list is null)
		{
			return 0;
		}

		_ = destination.CheckExists(createDirectory: true);

		var destinationPath = PathHelper.EnsureTrailingSlash(destination.FullName);
		var successCount = 0;
		var listCount = list.Count;
		var canBeCanceled = cancellationToken.CanBeCanceled;

		var psw = this.CreateStopwatch(nameof(this.CopyFiles));

		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
		{
			if (canBeCanceled)
			{
				cancellationToken.ThrowIfCancellationRequested();
			}

			successCount += this.CopyFileItem(list[fileIndex], destinationPath, overwrite, psw);
		}

		return successCount;
	}

	/// <summary>
	/// Copies files to a new location using the path (excluding root) of the original file in the destination path.
	/// </summary>
	/// <param name="files">The files to copy.</param>
	/// <param name="destination">The destination folder where files will be copied.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of files successfully copied.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if file copy succeeded or failed.
	/// </remarks>
	/// <exception cref="OperationCanceledException">The operation was canceled via the cancellation token.</exception>
	/// <example>
	/// Here is an example of using the <see cref="CopyFilesWithOriginalPath"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var filesToCopy = new List&lt;FileInfo&gt; { new FileInfo("path/to/source/file.txt") };
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// var cts = new CancellationTokenSource();
	/// fileProcessor.CopyFilesWithOriginalPath(filesToCopy, destinationDir, cts.Token);
	/// </code>
	/// </example>
	[Information(nameof(CopyFilesWithOriginalPath), author: "David McCarter", createdOn: "8/6/2017", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int CopyFilesWithOriginalPath(in IEnumerable<FileInfo> files, [DisallowNull] DirectoryInfo destination, CancellationToken cancellationToken = default)
	{
		destination = destination.ArgumentNotNull();

		var list = PrepareList(files);

		if (list is null)
		{
			return 0;
		}

		_ = destination.CheckExists(createDirectory: true);

		var destinationPath = PathHelper.EnsureTrailingSlash(destination.FullName);
		var successCount = 0;
		var psw = this.CreateStopwatch(nameof(this.CopyFilesWithOriginalPath));
		var listCount = list.Count;
		var canBeCanceled = cancellationToken.CanBeCanceled;

		// Track directories already created to avoid redundant filesystem stat calls.
		var createdDirs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
		{
			if (canBeCanceled)
			{
				cancellationToken.ThrowIfCancellationRequested();
			}

			successCount += this.CopyFileItemWithOriginalPath(list[fileIndex], destinationPath, createdDirs, psw);
		}

		return successCount;
	}

	//![](BF30B28B33B5AB5FD046DBD4833764B3_1.png)
	/// <summary>
	/// Deletes the specified files.
	/// </summary>
	/// <param name="files">The files to delete.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of files successfully deleted.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if file deletion succeeded or failed.
	/// </remarks>
	/// <exception cref="OperationCanceledException">The operation was canceled via the cancellation token.</exception>
	/// <example>
	/// Here is an example of using the <see cref="DeleteFiles"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var filesToDelete = new List&lt;FileInfo&gt; { new FileInfo("path/to/file/to/delete.txt") };
	/// var cts = new CancellationTokenSource();
	/// fileProcessor.DeleteFiles(filesToDelete, cts.Token);
	/// </code>
	/// </example>
	[Information(nameof(DeleteFiles), author: "David McCarter", createdOn: "8/6/2017", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int DeleteFiles(IEnumerable<FileInfo> files, CancellationToken cancellationToken = default)
	{
		var list = PrepareList(files);

		if (list is null)
		{
			return 0;
		}

		var successCount = 0;
		var psw = this.CreateStopwatch(nameof(this.DeleteFiles));
		var listCount = list.Count;
		var canBeCanceled = cancellationToken.CanBeCanceled;

		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
		{
			if (canBeCanceled)
			{
				cancellationToken.ThrowIfCancellationRequested();
			}

			successCount += this.DeleteFileItem(list[fileIndex], psw);
		}

		return successCount;
	}

	/// <summary>
	/// Deletes the specified folders and all their contents.
	/// </summary>
	/// <param name="folders">The folders to delete.</param>
	/// <param name="recursive">Specifies whether to delete directories, subdirectories, and files in <paramref name="folders"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of folders successfully deleted.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if folder deletion succeeded or failed.
	/// </remarks>
	/// <exception cref="OperationCanceledException">The operation was canceled via the cancellation token.</exception>
	/// <example>
	/// Here is an example of using the <see cref="DeleteFolders"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var foldersToDelete = new List&lt;DirectoryInfo&gt; { new DirectoryInfo("path/to/folder/to/delete") };
	/// var cts = new CancellationTokenSource();
	/// fileProcessor.DeleteFolders(foldersToDelete, recursive: true, cts.Token);
	/// </code>
	/// </example>
	[Information(nameof(DeleteFolders), author: "David McCarter", createdOn: "8/6/2017", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int DeleteFolders(IEnumerable<DirectoryInfo> folders, in bool recursive = true, CancellationToken cancellationToken = default)
	{
		var list = PrepareList(folders);

		if (list is null)
		{
			return 0;
		}

		var successCount = 0;

		foreach (var folder in list)
		{
			cancellationToken.ThrowIfCancellationRequested();
			successCount += this.DeleteFolderItem(folder, recursive);
		}

		return successCount;
	}

	/// <summary>
	/// Moves files to a new location.
	/// </summary>
	/// <param name="files">The files to move.</param>
	/// <param name="destination">The destination folder where files will be moved.</param>
	/// <param name="overwrite">If <see langword="true"/>, overwrites existing files at the destination; otherwise, throws an exception if a file already exists.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of files successfully moved.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if file move succeeded or failed.
	/// </remarks>
	/// <exception cref="OperationCanceledException">The operation was canceled via the cancellation token.</exception>
	/// <example>
	/// Here is an example of using the <see cref="MoveFiles"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var filesToMove = new List&lt;FileInfo&gt; { new FileInfo("path/to/source/file.txt") };
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// var cts = new CancellationTokenSource();
	/// fileProcessor.MoveFiles(filesToMove, destinationDir, cancellationToken: cts.Token);
	/// </code>
	/// </example>
	[Information(nameof(MoveFiles), author: "David McCarter", createdOn: "1/20/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int MoveFiles(IEnumerable<FileInfo> files, [DisallowNull] DirectoryInfo destination, in bool overwrite = true, CancellationToken cancellationToken = default)
	{
		destination = destination.ArgumentNotNull();

		var list = PrepareList(files);

		if (list is null)
		{
			return 0;
		}

		_ = destination.CheckExists(createDirectory: true);

		var destinationPath = PathHelper.EnsureTrailingSlash(destination.FullName);
		var successCount = 0;
		var listCount = list.Count;
		var canBeCanceled = cancellationToken.CanBeCanceled;

		var psw = this.CreateStopwatch(nameof(this.MoveFiles));

		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
		{
			if (canBeCanceled)
			{
				cancellationToken.ThrowIfCancellationRequested();
			}

			successCount += this.MoveFileItem(list[fileIndex], destinationPath, overwrite, psw);
		}

		return successCount;
	}

	/// <summary>
	/// Moves files to a new location using the path (excluding root) of the original file in the destination path.
	/// </summary>
	/// <param name="files">The files to move.</param>
	/// <param name="destination">The destination folder where files will be moved.</param>
	/// <param name="overwrite">If <see langword="true"/>, overwrites existing files at the destination; otherwise, throws an exception if a file already exists.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>The number of files successfully moved.</returns>
	/// <remarks>
	/// Use the <see cref="Processed"/> event to find out if file move succeeded or failed.
	/// </remarks>
	/// <exception cref="OperationCanceledException">The operation was canceled via the cancellation token.</exception>
	/// <example>
	/// Here is an example of using the <see cref="MoveFilesWithOriginalPath"/> method:
	/// <code>
	/// var fileProcessor = new FileProcessor();
	/// fileProcessor.Processed += (sender, e) => 
	/// {
	///     Console.WriteLine($"{e.ProgressState}: {e.Name}");
	/// };
	/// 
	/// var filesToMove = new List&lt;FileInfo&gt; { new FileInfo("path/to/source/file.txt") };
	/// var destinationDir = new DirectoryInfo("path/to/destination");
	/// var cts = new CancellationTokenSource();
	/// fileProcessor.MoveFilesWithOriginalPath(filesToMove, destinationDir, cancellationToken: cts.Token);
	/// </code>
	/// </example>
	[Information(nameof(MoveFilesWithOriginalPath), author: "David McCarter", createdOn: "1/20/2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public int MoveFilesWithOriginalPath(in IEnumerable<FileInfo> files, [DisallowNull] DirectoryInfo destination, in bool overwrite = true, CancellationToken cancellationToken = default)
	{
		destination = destination.ArgumentNotNull();

		var list = PrepareList(files);

		if (list is null)
		{
			return 0;
		}

		_ = destination.CheckExists(createDirectory: true);

		var destinationPath = PathHelper.EnsureTrailingSlash(destination.FullName);
		var successCount = 0;
		var psw = this.CreateStopwatch(nameof(this.MoveFilesWithOriginalPath));
		var listCount = list.Count;
		var canBeCanceled = cancellationToken.CanBeCanceled;

		// Track directories already created to avoid redundant filesystem stat calls.
		var createdDirs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		for (var fileIndex = 0; fileIndex < listCount; fileIndex++)
		{
			if (canBeCanceled)
			{
				cancellationToken.ThrowIfCancellationRequested();
			}

			successCount += this.MoveFileItemWithOriginalPath(list[fileIndex], destinationPath, overwrite, createdDirs, psw);
		}

		return successCount;
	}

	/// <summary>
	/// Computes the destination path for a file, preserving its original directory structure below the file-system root.
	/// </summary>
	/// <param name="fileFullName">The full path of the source file.</param>
	/// <param name="destinationPath">The root destination path (with trailing slash) that replaces the source root.</param>
	/// <returns>The new full path under <paramref name="destinationPath"/> with the original sub-root structure preserved.</returns>
	/// <exception cref="InvalidOperationException">Thrown when the source file has no file-system root.</exception>
	private static string ComputeOriginalDestPath(string fileFullName, string destinationPath)
	{
		var root = Path.GetPathRoot(fileFullName);

		if (root is null)
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.TheRootDirectoryOfTheFileIsNull);
		}

		// Use OrdinalIgnoreCase for Windows path replacement — InvariantCulture applies
		// unnecessary Unicode normalization and is semantically incorrect for file paths.
		return fileFullName.Replace(root, destinationPath, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Removes the read-only attribute from <paramref name="file"/>, starts the optional stopwatch, deletes the file, then returns the elapsed time.
	/// </summary>
	/// <param name="file">The file to delete.</param>
	/// <param name="psw">Optional stopwatch; <see langword="null"/> when no <see cref="Processed"/> subscribers exist.</param>
	/// <returns>The elapsed time of the delete operation, or <see cref="TimeSpan.Zero"/> when <paramref name="psw"/> is <see langword="null"/>.</returns>
	private static TimeSpan ExecuteDelete(FileInfo file, PerformanceStopwatch? psw)
	{
		FileHelper.RemoveReadOnlyAttribute(file);
		psw?.Start();

		file.Delete();

		return psw?.StopReset() ?? TimeSpan.Zero;
	}

	/// <summary>
	/// Removes the read-only attribute from <paramref name="file"/>, starts the optional stopwatch, moves the file, then returns the elapsed time.
	/// </summary>
	/// <param name="file">The source file to move.</param>
	/// <param name="newFilePath">The full destination path including the file name.</param>
	/// <param name="overwrite">Whether to overwrite an existing destination file.</param>
	/// <param name="psw">Optional stopwatch; <see langword="null"/> when no <see cref="Processed"/> subscribers exist.</param>
	/// <returns>The elapsed time of the move operation, or <see cref="TimeSpan.Zero"/> when <paramref name="psw"/> is <see langword="null"/>.</returns>
	private static TimeSpan ExecuteMove(FileInfo file, string newFilePath, bool overwrite, PerformanceStopwatch? psw)
	{
		FileHelper.RemoveReadOnlyAttribute(file);
		psw?.Start();

		file.MoveTo(newFilePath, overwrite);

		return psw?.StopReset() ?? TimeSpan.Zero;
	}

	/// <summary>
	/// Determines whether a copy operation should be blocked because the destination file already exists and overwriting is not permitted.
	/// </summary>
	/// <param name="newFilePath">The full path of the prospective destination file.</param>
	/// <param name="overwrite">Whether overwriting is allowed.</param>
	/// <returns><see langword="true"/> when <paramref name="overwrite"/> is <see langword="false"/> and the destination file exists; otherwise <see langword="false"/>.</returns>
	private static bool IsOverwriteConflict(string newFilePath, bool overwrite)
	{
		return !overwrite && File.Exists(newFilePath);
	}

	/// <summary>
	/// Materializes the source sequence, removing nulls and duplicates, into a <see cref="List{T}"/>.
	/// </summary>
	/// <typeparam name="T">A reference type.</typeparam>
	/// <param name="source">The source sequence; may be <see langword="null"/>.</param>
	/// <returns>A non-empty list, or <see langword="null"/> when <paramref name="source"/> is <see langword="null"/> or yields no elements.</returns>
	private static List<T>? PrepareList<T>(IEnumerable<T>? source) where T : class
	{
		if (source is null)
		{
			return null;
		}

		var list = source.RemoveNulls().FastDistinct().ToList();

		return list.Count == 0 ? null : list;
	}

	/// <summary>
	/// Starts the optional stopwatch, copies <paramref name="sourceFilePath"/> to <paramref name="newFilePath"/> using large-buffer sequential streams, then returns the elapsed time.
	/// </summary>
	/// <param name="sourceFilePath">The full source file path.</param>
	/// <param name="newFilePath">The full destination path including the file name.</param>
	/// <param name="psw">Optional stopwatch; <see langword="null"/> when no <see cref="Processed"/> subscribers exist.</param>
	/// <returns>The elapsed time of the copy operation, or <see cref="TimeSpan.Zero"/> when <paramref name="psw"/> is <see langword="null"/>.</returns>
	private static TimeSpan StreamCopyFile(string sourceFilePath, string newFilePath, PerformanceStopwatch? psw)
	{
		psw?.Start();

		// Use an explicit large buffer + SequentialScan for throughput (FileInfo.CopyTo uses 4096 bytes).
		using var src = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 81920, FileOptions.SequentialScan);
		using var dst = new FileStream(newFilePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 81920, FileOptions.SequentialScan);

		src.CopyTo(dst);

		return psw?.StopReset() ?? TimeSpan.Zero;
	}

	/// <summary>
	/// Copies a single <paramref name="file"/> to <paramref name="destinationPath"/>
	/// </summary>
	/// <param name="file">The source file to copy.</param>
	/// <param name="destinationPath">The destination directory path (with trailing slash).</param>
	/// <param name="overwrite">Whether to overwrite an existing destination file.</param>
	/// <param name="psw">Optional stopwatch for timing; <see langword="null"/> when no <see cref="Processed"/> subscribers exist.</param>
	/// <returns>1 if the file was copied successfully; otherwise 0.</returns>
	private int CopyFileItem(FileInfo file, string destinationPath, bool overwrite, PerformanceStopwatch? psw)
	{
		var fileFullName = file.FullName;
		long fileLength = 0;

		if (!file.Exists)
		{
			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileNotFound, Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
			return 0;
		}

		try
		{
			fileLength = file.Length;

			var newFilePath = Path.Combine(destinationPath, file.Name);

			if (IsOverwriteConflict(newFilePath, overwrite))
			{
				this.OnProcessed(new ProgressEventArgs { Message = Resources.FileAlreadyExists, Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
				return 0;
			}

			var perf = StreamCopyFile(fileFullName, newFilePath, psw);

			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenCopied, Name = fileFullName, ProgressState = FileProgressState.FileCopied, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
			return 1;
		}
#pragma warning disable CA1031
		catch (Exception ex) // Report all errors
#pragma warning restore CA1031
		{
			this.OnProcessed(new ProgressEventArgs { Message = ex.GetAllMessages(), Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
			return 0;
		}
	}

	/// <summary>
	/// Copies a single <paramref name="file"/> to a destination path that preserves the original relative directory structure,
	/// raising the <see cref="Processed"/> event on success or failure.
	/// </summary>
	/// <param name="file">The source file to copy.</param>
	/// <param name="destinationPath">The root destination path (with trailing slash).</param>
	/// <param name="createdDirs">Set of already-created destination directories to avoid redundant kernel calls.</param>
	/// <param name="psw">Optional stopwatch for timing; <see langword="null"/> when no <see cref="Processed"/> subscribers exist.</param>
	/// <returns>1 if the file was copied successfully; otherwise 0.</returns>
	private int CopyFileItemWithOriginalPath(FileInfo file, string destinationPath, HashSet<string> createdDirs, PerformanceStopwatch? psw)
	{
		var fileFullName = file.FullName;
		long fileLength = 0;

		if (!file.Exists)
		{
			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileNotFound, Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
			return 0;
		}

		try
		{
			fileLength = file.Length;

			var newFilePath = ComputeOriginalDestPath(fileFullName, destinationPath);
			var dirPath = Path.GetDirectoryName(newFilePath)!;

			if (createdDirs.Add(dirPath))
			{
				_ = Directory.CreateDirectory(dirPath);
			}

			var perf = StreamCopyFile(fileFullName, newFilePath, psw);

			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenCopied, Name = fileFullName, ProgressState = FileProgressState.FileCopied, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
			return 1;
		}
#pragma warning disable CA1031
		catch (Exception ex) // Report all errors
#pragma warning restore CA1031
		{
			this.OnProcessed(new ProgressEventArgs { Message = ex.GetAllMessages(), Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
			return 0;
		}
	}

	/// <summary>
	/// Allocates a <see cref="PerformanceStopwatch"/> only when the <see cref="Processed"/> event has subscribers.
	/// </summary>
	/// <param name="name">The label passed to the stopwatch constructor.</param>
	/// <returns>A new <see cref="PerformanceStopwatch"/>, or <see langword="null"/> when there are no event subscribers.</returns>
	private PerformanceStopwatch? CreateStopwatch(string name)
	{
		return this.Processed is not null ? new PerformanceStopwatch(name) : null;
	}

	/// <summary>
	/// Deletes a single <paramref name="file"/>
	/// </summary>
	/// <param name="file">The file to delete.</param>
	/// <param name="psw">Optional stopwatch for timing; <see langword="null"/> when no <see cref="Processed"/> subscribers exist.</param>
	/// <returns>1 if the file was deleted successfully; otherwise 0.</returns>
	private int DeleteFileItem(FileInfo file, PerformanceStopwatch? psw)
	{
		var fileFullName = file.FullName;

		if (!file.Exists)
		{
			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileNotFound, Name = fileFullName, ProgressState = FileProgressState.Error });
			return 0;
		}

		long fileLength = 0;

		try
		{
			fileLength = file.Length;
			var perf = ExecuteDelete(file, psw);
			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenDeleted, Name = fileFullName, ProgressState = FileProgressState.FileDeleted, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
			return 1;
		}
#pragma warning disable CA1031
		catch (Exception ex) // Report all errors
#pragma warning restore CA1031
		{
			this.OnProcessed(new ProgressEventArgs { Message = ex.GetAllMessages(), Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
			return 0;
		}
	}

	/// <summary>
	/// Deletes a single <paramref name="folder"/>
	/// </summary>
	/// <param name="folder">The directory to delete.</param>
	/// <param name="recursive">Whether to delete subdirectories and files recursively.</param>
	/// <returns>1 if the folder was deleted successfully; otherwise 0.</returns>
	private int DeleteFolderItem(DirectoryInfo folder, bool recursive)
	{
		if (!folder.CheckExists())
		{
			this.OnProcessed(new ProgressEventArgs { Message = Resources.FolderNotFound, Name = folder.FullName, ProgressState = FileProgressState.Error });
			return 0;
		}

		try
		{
			var result = DirectoryHelper.DeleteDirectory(folder, retries: 5, recursive);

			if (result.IsSuccess)
			{
				this.OnProcessed(new ProgressEventArgs { Message = Resources.DeletedFolder, Name = folder.FullName, ProgressState = FileProgressState.DirectoryDeleted });
				return 1;
			}

			this.OnProcessed(new ProgressEventArgs { Message = result.GetErrorMessages(), Name = folder.FullName, ProgressState = FileProgressState.Error });
			return 0;
		}
#pragma warning disable CA1031
		catch (Exception ex) // Report all errors
#pragma warning restore CA1031
		{
			this.OnProcessed(new ProgressEventArgs { Message = ex.GetAllMessages(), Name = folder.FullName, ProgressState = FileProgressState.Error });
			return 0;
		}
	}

	/// <summary>
	/// Moves a single <paramref name="file"/>
	/// </summary>
	/// <param name="file">The source file to move.</param>
	/// <param name="destinationPath">The destination directory path (with trailing slash).</param>
	/// <param name="overwrite">Whether to overwrite an existing destination file.</param>
	/// <param name="psw">Optional stopwatch for timing; <see langword="null"/> when no <see cref="Processed"/> subscribers exist.</param>
	/// <returns>1 if the file was moved successfully; otherwise 0.</returns>
	private int MoveFileItem(FileInfo file, string destinationPath, bool overwrite, PerformanceStopwatch? psw)
	{
		var fileFullName = file.FullName;

		if (!file.Exists)
		{
			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileNotFound, Name = fileFullName, ProgressState = FileProgressState.Error });
			return 0;
		}

		long fileLength = 0;

		try
		{
			fileLength = file.Length;
			var newFileName = Path.Combine(destinationPath, file.Name);
			var perf = ExecuteMove(file, newFileName, overwrite, psw);

			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenMoved, Name = fileFullName, ProgressState = FileProgressState.FileMoved, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
			return 1;
		}
#pragma warning disable CA1031
		catch (Exception ex) // Report all errors
#pragma warning restore CA1031
		{
			this.OnProcessed(new ProgressEventArgs { Message = ex.GetAllMessages(), Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
			return 0;
		}
	}

	/// <summary>
	/// Moves a single <paramref name="file"/> to a destination path that preserves the original relative directory structure,
	/// raising the <see cref="Processed"/> event on success or failure.
	/// </summary>
	/// <param name="file">The source file to move.</param>
	/// <param name="destinationPath">The root destination path (with trailing slash).</param>
	/// <param name="overwrite">Whether to overwrite an existing destination file.</param>
	/// <param name="createdDirs">Set of already-created destination directories to avoid redundant kernel calls.</param>
	/// <param name="psw">Optional stopwatch for timing; <see langword="null"/> when no <see cref="Processed"/> subscribers exist.</param>
	/// <returns>1 if the file was moved successfully; otherwise 0.</returns>
	private int MoveFileItemWithOriginalPath(FileInfo file, string destinationPath, bool overwrite, HashSet<string> createdDirs, PerformanceStopwatch? psw)
	{
		var fileFullName = file.FullName;

		if (!file.Exists)
		{
			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileNotFound, Name = fileFullName, ProgressState = FileProgressState.Error });
			return 0;
		}

		long fileLength = 0;

		try
		{
			fileLength = file.Length;
			var newFilePath = ComputeOriginalDestPath(fileFullName, destinationPath);
			var dirPath = Path.GetDirectoryName(newFilePath)!;

			if (createdDirs.Add(dirPath))
			{
				_ = Directory.CreateDirectory(dirPath);
			}

			var perf = ExecuteMove(file, newFilePath, overwrite, psw);

			this.OnProcessed(new ProgressEventArgs { Message = Resources.FileHasBeenMoved, Name = fileFullName, ProgressState = FileProgressState.FileMoved, Size = fileLength, SpeedInMilliseconds = perf.TotalMilliseconds });
			return 1;
		}
#pragma warning disable CA1031
		catch (Exception ex) // Report all errors
#pragma warning restore CA1031
		{
			this.OnProcessed(new ProgressEventArgs { Message = ex.GetAllMessages(), Name = fileFullName, ProgressState = FileProgressState.Error, Size = fileLength });
			return 0;
		}
	}

	/// <summary>
	/// Raises the <see cref="Processed"/> event.
	/// </summary>
	/// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
	private void OnProcessed(ProgressEventArgs e) => this.Processed?.Invoke(this, e);

}
