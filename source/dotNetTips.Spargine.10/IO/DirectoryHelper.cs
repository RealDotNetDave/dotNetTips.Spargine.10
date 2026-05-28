// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-28-2026
// ***********************************************************************
// <copyright file="DirectoryHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for working with path directories.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Security.Principal;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;
using DotNetTips.Spargine.Win32;
using Microsoft.Win32;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides a collection of static methods for directory operations, enhancing functionality with additional utility methods.
/// </summary>
/// <remarks>
/// This class includes methods for performing operations such as copying, moving, deleting directories, checking permissions,
/// loading files asynchronously, managing OneDrive folders, and conducting safe directory and path searches. These methods
/// are designed to extend the capabilities of the <see cref="DirectoryInfo"/> class and simplify common path system operations.
/// </remarks>
[Information(Status = Status.Available, Documentation = "https://bit.ly/SpargineDirectoryHelper")]
public static class DirectoryHelper
{
	private const string LocalAppData = "LOCALAPPDATA";

	/// <summary>
	/// Cached <see cref="EnumerationOptions"/> for recursive file/directory enumeration.
	/// Shared across all search methods to avoid per-call allocation.
	/// </summary>
	private static readonly EnumerationOptions _enumerationOptionsRecursive = new()
	{
		IgnoreInaccessible = true,
		ReturnSpecialDirectories = true,
		RecurseSubdirectories = true,
		AttributesToSkip = FileAttributes.Hidden,
	};

	/// <summary>
	/// Cached <see cref="EnumerationOptions"/> for top-directory-only file/directory enumeration.
	/// Shared across all search methods to avoid per-call allocation.
	/// </summary>
	private static readonly EnumerationOptions _enumerationOptionsTopOnly = new()
	{
		IgnoreInaccessible = true,
		ReturnSpecialDirectories = true,
		RecurseSubdirectories = false,
		AttributesToSkip = FileAttributes.Hidden,
	};

	/// <summary>
	/// Cached <see cref="EnumerationOptions"/> for recursive file loading (used by <see cref="LoadFilesAsync"/>).
	/// Does not return special directories, matching the original behavior of that method.
	/// </summary>
	private static readonly EnumerationOptions _loadFilesOptionsRecursive = new()
	{
		IgnoreInaccessible = true,
		RecurseSubdirectories = true,
	};

	/// <summary>
	/// Cached <see cref="EnumerationOptions"/> for top-directory-only file loading (used by <see cref="LoadFilesAsync"/>).
	/// Does not return special directories, matching the original behavior of that method.
	/// </summary>
	private static readonly EnumerationOptions _loadFilesOptionsTopOnly = new()
	{
		IgnoreInaccessible = true,
		RecurseSubdirectories = false,
	};

	/// <summary>
	/// Cached <see cref="EnumerationOptions"/> for <see cref="SetFileAttributesToNormal"/>.
	/// Enumerates all file system entries recursively, ignoring inaccessible items.
	/// </summary>
	private static readonly EnumerationOptions _setAttributesOptions = new()
	{
		IgnoreInaccessible = true,
		RecurseSubdirectories = true,
	};

	/// <summary>
	/// Gets the application data folder path for the current user.
	/// </summary>
	/// <returns>The path to the application data folder.</returns>
	/// <exception cref="InvalidOperationException">Thrown when the user path environment variable is not set.</exception>
	[SupportedOSPlatform("macos")]
	[Information(nameof(AppDataFolder), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static string AppDataFolder()
	{
		var companyName = GetEntryAssemblyCompanyName();

		if (string.IsNullOrEmpty(companyName))
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AssemblyCompanyNameAttributeIsNotSet);
		}

		return Path.Combine(LocalAppData, companyName);
	}

	/// <summary>
	/// Checks if the current user has the specified permission on the given directory.
	/// </summary>
	/// <param name="directory">The directory to check permissions on.</param>
	/// <param name="permission">The permission to check for. Default is <see cref="FileSystemRights.Read" />.</param>
	/// <returns><c>true</c> if the specified permission is allowed; otherwise, <c>false</c>.</returns>
	/// <example>
	/// This example shows how to call the <see cref="CheckPermission" /> method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo("C:\\MyDirectory");
	/// var hasReadPermission = DirectoryHelper.CheckPermission(directoryInfo, FileSystemRights.Read);
	/// Console.WriteLine($"Has read permission: {hasReadPermission}");
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directory"/> is null.</exception>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CheckPermission), author: "David McCarter", createdOn: "6/17/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool CheckPermission([DisallowNull] DirectoryInfo directory, FileSystemRights permission = FileSystemRights.Read)
	{
		//OPTIMIZATION FROM COPILOT BREAKS THIS CODE
		directory = directory.ArgumentExists();

		return EvaluatePermission(directory, permission);
	}

	/// <summary>
	/// Copies the specified source directory to the specified destination directory.
	/// </summary>
	/// <param name="source">The source directory to copy from.</param>
	/// <param name="destination">The destination directory to copy to.</param>
	/// <param name="overwrite">if set to <c>true</c>, the destination files will be overwritten if they already exist.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while copying.</param>
	/// <example>
	/// This example shows how to use the <see cref="CopyDirectory" /> method.
	/// <code>
	/// var sourceDir = new DirectoryInfo(@"C:\SourceDirectory");
	/// var destDir = new DirectoryInfo(@"C:\DestinationDirectory");
	/// DirectoryHelper.CopyDirectory(sourceDir, destDir, true);
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CopyDirectory), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void CopyDirectory([DisallowNull] DirectoryInfo source, [NotNull] DirectoryInfo destination, bool overwrite = true, CancellationToken cancellationToken = default)
	{
		source = source.ArgumentExists();
		destination = destination.ArgumentNotNull();

		if (destination.CheckExists(createDirectory: true) == false)
		{
			ExceptionThrower.ThrowDirectoryNotFoundException(Resources.CouldNotCreateDirectory, destination);
		}

		var files = source.EnumerateFiles();
		var subdirs = source.EnumerateDirectories();
		var parallelOptions = new ParallelOptions { CancellationToken = cancellationToken };

		_ = Parallel.ForEach(files, parallelOptions, file =>
		{
			var destFile = Path.Combine(destination.FullName, file.Name);
			_ = file.CopyTo(destFile, overwrite);
		});

		_ = Parallel.ForEach(subdirs, parallelOptions, subdir =>
		{
			var destSubDir = destination.CreateSubdirectory(subdir.Name);
			CopyDirectory(subdir, destSubDir, overwrite, cancellationToken);
		});
	}

	/// <summary>
	/// Deletes the directory with retry.
	/// </summary>
	/// <param name="path">The directory to delete.</param>
	/// <param name="retries">Number of retries in case of failure. Default is 5.</param>
	/// <param name="recursive">Specifies whether to delete directories, subdirectories, and files in <paramref name="path"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the operation to complete.</param>
	/// <returns>A <see cref="SimpleResult{T}"/> indicating the result of the operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> is null.</exception>
	/// <exception cref="IOException">Thrown when the directory could not be deleted after the specified number of retries.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when the directory could not be deleted due to unauthorized access after the specified number of retries.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DeleteDirectory), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static SimpleResult<int> DeleteDirectory([DisallowNull] DirectoryInfo path, [ConstantExpected(Min = 1, Max = byte.MaxValue)] byte retries = 5, bool recursive = true, CancellationToken cancellationToken = default)
	{
		path = path.ArgumentExists();
		retries = retries.ArgumentInRange(min: 1, max: byte.MaxValue, Resources.RetriesAreLimitedTo255);

		cancellationToken.ThrowIfCancellationRequested();

		if (path.Exists == false)
		{
			return SimpleResult.FromException<int>(new Core.DirectoryNotFoundException());
		}

		// On some systems, directories/files created are created with attributes
		// that prevent them from being deleted. Set those attributes to be normal
		SetFileAttributesToNormal(path, cancellationToken);

		var result = ExecutionHelper.ProgressiveRetry(() => path.Delete(recursive), retryCount: retries, retryWaitMilliseconds: 5);

		if (result.Status != ResultStatus.Succeeded)
		{
			result.AddException(new IOException($"Directory could not be deleted: {path.FullName}"));
		}

		return result;
	}

	/// <summary>
	/// Asynchronously loads files from the specified directories using the given search pattern and search option.
	/// </summary>
	/// <param name="directories">The directories from which files are to be loaded.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="directories" />.</param>
	/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
	/// <returns>An asynchronous stream (<see cref="IAsyncEnumerable{T}" />) of collections of <see cref="FileInfo" />, where each collection represents files found in a directory.</returns>
	/// <remarks>This method utilizes deferred execution to improve performance. Files are not loaded into memory until the asynchronous stream is iterated.</remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directories"/> or <paramref name="searchPattern"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LoadFilesAsync), author: "David McCarter", createdOn: "3/1/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IAsyncEnumerable<IEnumerable<FileInfo>> LoadFilesAsync([DisallowNull] IEnumerable<DirectoryInfo> directories, [DisallowNull] string searchPattern, SearchOption searchOption, CancellationToken cancellationToken = default)
	{
		directories = directories.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNull();

		if (searchOption.CheckIsDefined() is false)
		{
			searchOption = SearchOption.TopDirectoryOnly;
		}

		return LoadFilesAsyncCore(directories, searchPattern, searchOption, cancellationToken);
	}


	/// <summary>
	/// Loads the OneDrive folders for the current user.
	/// </summary>
	/// <returns>A read-only collection of <see cref="OneDriveFolder"/> objects representing the OneDrive folders.</returns>
	/// <remarks>
	/// This method retrieves the OneDrive folders by accessing the Windows Registry. It supports both personal and business accounts.
	/// Note: This method is only supported on Windows.
	/// </remarks>
	/// <exception cref="PlatformNotSupportedException">Thrown if the method is invoked on a non-Windows platform.</exception>
	/// <example>
	/// This example shows how to call the <see cref="LoadOneDriveFolders"/> method.
	/// <code>
	/// var oneDriveFolders = DirectoryHelper.LoadOneDriveFolders();
	/// foreach(var folder in oneDriveFolders)
	/// {
	///     Console.WriteLine($"OneDrive Folder: {folder.DirectoryInfo.FullName}");
	/// }
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LoadOneDriveFolders), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<OneDriveFolder> LoadOneDriveFolders()
	{
		var folders = new List<OneDriveFolder>();

		using var oneDriveKey = RegistryHelper.GetRegistryKey(RegistryHelper.KeyCurrentUserOneDrive, RegistryHive.CurrentUser);

		if (oneDriveKey is not null)
		{
			LoadOneDriveFoldersFromKey(oneDriveKey, folders);
		}

		return folders.AsReadOnly();
	}


	/// <summary>
	/// Moves a directory to a new location with retry support.
	/// </summary>
	/// <param name="source">The source directory to move. Must exist.</param>
	/// <param name="destination">The destination directory path. Must not be null.</param>
	/// <param name="retries">
	/// The maximum number of retry attempts if the move operation fails.
	/// Valid range is from 1 to 255. Default is 5.
	/// </param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the operation to complete.</param>
	/// <returns>
	/// A <see cref="SimpleResult{T}"/> containing the number of attempts performed.
	/// If the operation fails after all retries, the result will contain an exception.
	/// </returns>
	/// <remarks>
	/// This method uses ExecutionHelper.ProgressiveRetry() to perform the move operation
	/// with a progressive retry strategy, waiting 5 milliseconds between attempts.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="retries"/> is outside the valid range (1-255).</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MoveDirectory), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static SimpleResult<int> MoveDirectory([DisallowNull] DirectoryInfo source, [DisallowNull] DirectoryInfo destination, [ConstantExpected(Min = 1, Max = byte.MaxValue)] byte retries = 5, CancellationToken cancellationToken = default)
	{
		source = source.ArgumentExists();
		destination = destination.ArgumentNotNull();

		retries = retries.ArgumentInRange(min: 1, max: byte.MaxValue, errorMessage: Resources.RetriesAreLimitedTo255);

		cancellationToken.ThrowIfCancellationRequested();

		var result = ExecutionHelper.ProgressiveRetry(() => Directory.Move(source.FullName, destination.FullName), retryCount: 3, retryWaitMilliseconds: 5);

		if (result.Status != ResultStatus.Succeeded)
		{
			result.AddException(new IOException($"Directory could not be moved after {result.Value} tries: {source.FullName} to {destination.FullName}"));
		}

		return result;
	}

	/// <summary>
	/// Removes the specified attributes from the directory.
	/// </summary>
	/// <param name="path">The directory from which the attributes will be removed. Must not be null.</param>
	/// <param name="attributesToRemove">The attributes to remove from the directory.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RemoveAttributes), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static void RemoveAttributes([DisallowNull] DirectoryInfo path, in FileAttributes attributesToRemove)
	{
		path = path.ArgumentExists();

		path.Attributes &= ~attributesToRemove;
	}

	/// <summary>
	/// Performs a safe directory search by matching a specified search pattern and search option.
	/// Ignores errors accessing directories.
	/// </summary>
	/// <param name="path">The root directory to start the search from. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the directory names. Default is "*.*" which matches all directories.</param>
	/// <param name="searchOption">Specifies whether to search only the current directory, or all subdirectories. The default is <see cref="SearchOption.TopDirectoryOnly" />.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while iterating directories.</param>
	/// <returns>An <see cref="IEnumerable{DirectoryInfo}" /> containing directories that match the search pattern and option.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> or <paramref name="searchPattern"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption"/> is not a valid <see cref="SearchOption"/>.</exception>
	/// <example>
	/// This example shows how to call the SafeHasFoldersOrFiles method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// foreach (var dir in DirectoryHelper.SafeHasFoldersOrFiles(directoryInfo, "*.config", SearchOption.AllDirectories))
	/// {
	/// Console.WriteLine(dir.FullName);
	/// }
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> or <paramref name="searchPattern"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SafeDirectorySearch), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<DirectoryInfo> SafeDirectorySearch([DisallowNull] DirectoryInfo path, [DisallowNull] string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly, CancellationToken cancellationToken = default)
	{
		//OPTIMIZATION FROM COPILOT BREAKS CODE
		path = path.ArgumentExists();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		var options = searchOption == SearchOption.AllDirectories ? _enumerationOptionsRecursive : _enumerationOptionsTopOnly;

		foreach (var directory in path.EnumerateFiles(searchPattern, options).Select(file => file.Directory).FastDistinct())
		{
			cancellationToken.ThrowIfCancellationRequested();
			yield return directory!;
		}
	}

	/// <summary>
	/// Performs a safe path search in the specified directory using the given search pattern and search option.
	/// Ignores errors accessing directories.
	/// </summary>
	/// <param name="path">The directory to search. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="path"/>.</param>
	/// <param name="searchOption">Specifies whether the search operation should include only the current directory or should include all subdirectories. Uses <see cref="SearchOption"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while searching.</param>
	/// <returns>A read-only collection of <see cref="FileInfo"/> objects that match the search pattern and option.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> or <paramref name="searchPattern"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption"/> is not a valid <see cref="SearchOption"/>.</exception>
	/// <example>
	/// This example shows how to call the SafeFileSearch method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// var files = DirectoryHelper.SafeFileSearch(directoryInfo, "*.txt", SearchOption.AllDirectories);
	/// foreach(var path in files)
	/// {
	/// Console.WriteLine(path.FullName);
	/// }
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> or <paramref name="searchPattern"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<FileInfo> SafeFileSearch([DisallowNull] DirectoryInfo path, [DisallowNull] string searchPattern, SearchOption searchOption, CancellationToken cancellationToken = default)
	{
		var directories = new List<DirectoryInfo>(1)
		{
			path
		};

		return SafeFileSearch(directories, searchPattern, searchOption, cancellationToken).ToReadOnlyCollection();
	}

	/// <summary>
	/// Performs a safe path search in the specified directories using the given search pattern and search option.
	/// Ignores errors accessing directories.
	/// </summary>
	/// <param name="directories">The directories to search. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="directories"/>.</param>
	/// <param name="searchOption">Specifies whether the search operation should include only the current directory or should include all subdirectories. Uses <see cref="SearchOption"/>.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while searching.</param>
	/// <returns>An <see cref="IEnumerable{FileInfo}"/> containing files that match the search pattern and option.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="directories"/> or <paramref name="searchPattern"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption"/> is not a valid <see cref="SearchOption"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static IEnumerable<FileInfo> SafeFileSearch([DisallowNull] IEnumerable<DirectoryInfo> directories, [DisallowNull] string searchPattern, [DisallowNull] SearchOption searchOption = SearchOption.TopDirectoryOnly, CancellationToken cancellationToken = default)
	{
		directories = directories.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		return SafeFileSearchCore(directories, searchPattern, searchOption, cancellationToken);
	}

	/// <summary>
	/// Performs a safe directory search by matching specified search patterns and search option, ignoring errors accessing directories.
	/// </summary>
	/// <param name="path">
	/// The directory to search. Must not be null and must exist.
	/// </param>
	/// <param name="searchOption">
	/// Specifies whether the search operation should include only the current directory or should include all subdirectories.
	/// Defaults to <see cref="SearchOption.TopDirectoryOnly"/>.
	/// </param>
	/// <param name="searchPatterns">
	/// The search patterns to use for matching files. Must not be null or empty.
	/// </param>
	/// <returns>
	/// <c>true</c> if the directory contains any files or folders that match the search patterns; otherwise, <c>false</c>.
	/// </returns>
	/// <remarks>
	/// This method utilizes <see cref="SafeDirectorySearch(DirectoryInfo, string, SearchOption, CancellationToken)"/> to perform a robust and error-tolerant search.
	/// It ensures that inaccessible directories do not cause the operation to fail.
	/// </remarks>
	/// <example>
	/// This example shows how to call the <see cref="SafeHasFoldersOrFiles"/> method:
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// bool containsFiles = DirectoryHelper.SafeHasFoldersOrFiles(directoryInfo, SearchOption.TopDirectoryOnly, "*.txt", "*.docx");
	/// Console.WriteLine($"Directory contains matching files: {containsFiles}");
	/// </code>
	/// </example>
	/// <exception cref="ArgumentNullException">
	/// Thrown when <paramref name="path"/> or <paramref name="searchPatterns"/> is null.
	/// </exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SafeDirectorySearch), "David McCarter", "6/14/2021", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static bool SafeHasFoldersOrFiles([DisallowNull] DirectoryInfo path, SearchOption searchOption = SearchOption.TopDirectoryOnly, [DisallowNull] params ReadOnlyCollection<string> searchPatterns)
	{
		path = path.ArgumentExists();

		searchOption = searchOption.ArgumentDefined();
		searchPatterns = searchPatterns.ArgumentNotNull();

		// Search for directories first, then files
		return searchPatterns.Any(pattern => SafeDirectorySearch(path, pattern, searchOption).IsNotEmpty())
			|| searchPatterns.Any(pattern => SafeFileSearch(path, pattern, searchOption).IsNotEmpty());
	}

	/// <summary>
	/// Sets the attributes of all files in the specified directory, and its subdirectories, to normal.
	/// </summary>
	/// <param name="path">The directory whose path attributes will be set to normal. Must not be null.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while setting attributes.</param>
	/// <remarks>
	/// This method recursively traverses all files in the given directory and its subdirectories, setting their attributes to <see cref="FileAttributes.Normal"/>.
	/// It's useful for preparing files for deletion that might otherwise be read-only or have other attributes set.
	/// </remarks>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> is null.</exception>
	/// <example>
	/// This example shows how to call the <see cref="SetFileAttributesToNormal" /> method.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// DirectoryHelper.SetFileAttributesToNormal(directoryInfo);
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SetFileAttributesToNormal), "David McCarter", "2/14/2018", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static void SetFileAttributesToNormal([DisallowNull] DirectoryInfo path, CancellationToken cancellationToken = default)
	{
		if (path.CheckExists() == false)
		{
			return;
		}

		// Set the directory attributes to normal
		RemoveAttributes(path, FileAttributes.ReadOnly);

		// Single pass: handle both sub-directories and files
		foreach (var item in path.EnumerateFileSystemInfos(ControlChars.WildcardAllFiles, _setAttributesOptions))
		{
			cancellationToken.ThrowIfCancellationRequested();
			item.Attributes = FileAttributes.Normal;
		}
	}

	/// <summary>
	/// Builds the list of file-loading tasks for <see cref="LoadFilesAsync"/>, one per existing directory.
	/// </summary>
	/// <param name="directories">The directories to scan.</param>
	/// <param name="searchPattern">The search pattern to match files against.</param>
	/// <param name="options">The pre-resolved <see cref="EnumerationOptions"/> for the search.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to associate with each spawned task.</param>
	/// <returns>A list of tasks, each returning an array of <see cref="FileInfo"/> for one directory.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static List<Task<FileInfo[]>> BuildFileLoadTasks(IEnumerable<DirectoryInfo> directories, string searchPattern, EnumerationOptions options, CancellationToken cancellationToken)
		=> directories.Where(directory => directory.CheckExists())
			.Select(directory => Task.Run(() => directory.GetFiles(searchPattern, options), cancellationToken))
			.ToList();

	/// <summary>
	/// Evaluates the access rules on <paramref name="directory"/> and returns whether <paramref name="permission"/> is
	/// granted (allowed and not explicitly denied).
	/// </summary>
	/// <param name="directory">The existing directory whose ACL is read.</param>
	/// <param name="permission">The permission flag to test.</param>
	/// <returns><c>true</c> if the permission is in at least one Allow rule and in no Deny rules; otherwise <c>false</c>.</returns>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool EvaluatePermission(DirectoryInfo directory, FileSystemRights permission)
	{
		var accessControl = directory.GetAccessControl();
		var rules = accessControl.GetAccessRules(true, true, typeof(SecurityIdentifier));

		var allow = false;
		var deny = false;

		foreach (FileSystemAccessRule rule in rules)
		{
			if ((permission & rule.FileSystemRights) != permission)
			{
				continue;
			}

			allow |= rule.AccessControlType == AccessControlType.Allow;
			deny |= rule.AccessControlType == AccessControlType.Deny;
		}

		return allow && !deny;
	}

	/// <summary>
	/// Returns the company name from the entry assembly's <see cref="AssemblyCompanyAttribute"/>,
	/// or <see langword="null"/> when no entry assembly or company attribute is present.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static string? GetEntryAssemblyCompanyName()
		=> Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company?.Trim();

	private static async IAsyncEnumerable<IEnumerable<FileInfo>> LoadFilesAsyncCore(IEnumerable<DirectoryInfo> directories, string searchPattern, SearchOption searchOption, [EnumeratorCancellation] CancellationToken cancellationToken)
	{
		var options = searchOption == SearchOption.AllDirectories ? _loadFilesOptionsRecursive : _loadFilesOptionsTopOnly;

		foreach (var task in BuildFileLoadTasks(directories, searchPattern, options, cancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			yield return await task.ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Iterates each account sub-key under the OneDrive Accounts registry key and populates
	/// <paramref name="folders"/> with any valid <see cref="OneDriveFolder"/> entries found.
	/// </summary>
	/// <param name="accountKey">The open registry key for the OneDrive Accounts node.</param>
	/// <param name="folders">The list to which discovered folders are appended.</param>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LoadOneDriveAccounts), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void LoadOneDriveAccounts(RegistryKey accountKey, List<OneDriveFolder> folders)
	{
		var subKeyNames = accountKey.GetSubKeyNames();
		var subKeyCount = subKeyNames.LongLength;

		for (var subKeyIndex = 0; subKeyIndex < subKeyCount; subKeyIndex++)
		{
			using var key = accountKey.OpenSubKey(subKeyNames[subKeyIndex]);

			var folder = ParseOneDriveFolder(key);

			if (folder is not null)
			{
				folders.Add(folder);
			}
		}
	}

	/// <summary>
	/// Loads OneDrive folders from the given registry key into the supplied list.
	/// </summary>
	/// <param name="oneDriveKey">The open OneDrive registry key.</param>
	/// <param name="folders">The list to populate.</param>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(LoadOneDriveFoldersFromKey), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void LoadOneDriveFoldersFromKey(RegistryKey oneDriveKey, List<OneDriveFolder> folders)
	{
		const string AccountsKey = "Accounts";

		using var accountKey = oneDriveKey.GetSubKey(AccountsKey);

		if (accountKey is null)
		{
			return;
		}

		if (accountKey.SubKeyCount > 0)
		{
			LoadOneDriveAccounts(accountKey, folders);
		}
	}

	/// <summary>
	/// Reads a single OneDrive account registry key and returns a populated <see cref="OneDriveFolder"/>,
	/// or <see langword="null"/> when the key does not contain a valid user folder path.
	/// </summary>
	/// <param name="key">The open registry sub-key for a single OneDrive account. May be <see langword="null"/>.</param>
	/// <returns>A populated <see cref="OneDriveFolder"/>, or <see langword="null"/> if the key is invalid or has no user folder.</returns>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ParseOneDriveFolder), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static OneDriveFolder? ParseOneDriveFolder(RegistryKey? key)
	{
		if (key is null)
		{
			return null;
		}

		const string DisplayNameKey = "DisplayName";
		const string UserFolderKey = "UserFolder";
		const string EmailKey = "UserEmail";

		var directoryValue = key.GetValue<string>(UserFolderKey);

		if (string.IsNullOrEmpty(directoryValue))
		{
			return null;
		}

		var folder = new OneDriveFolder
		{
			DirectoryInfo = new DirectoryInfo(directoryValue)
		};

		SetOneDriveFolderEmail(key, folder, EmailKey);
		SetOneDriveFolderAccount(key, folder, DisplayNameKey);

		return folder;
	}

	/// <summary>
	/// Core query for <see cref="SafeFileSearch(IEnumerable{DirectoryInfo}, string, SearchOption, CancellationToken)"/>.
	/// Returns a lazy <see cref="IEnumerable{FileInfo}"/> of files found in each existing directory
	/// that match <paramref name="searchPattern"/>.
	/// </summary>
	/// <param name="directories">The already-validated list of directories to search.</param>
	/// <param name="searchPattern">The already-validated search pattern.</param>
	/// <param name="searchOption">The already-validated search scope.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while iterating directories.</param>
	/// <returns>All matching <see cref="FileInfo"/> instances found across the supplied directories.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static IEnumerable<FileInfo> SafeFileSearchCore(IEnumerable<DirectoryInfo> directories, string searchPattern, SearchOption searchOption, CancellationToken cancellationToken)
	{
		var options = searchOption == SearchOption.AllDirectories ? _enumerationOptionsRecursive : _enumerationOptionsTopOnly;

		foreach (var d in directories.Where(d => d.CheckExists()))
		{
			cancellationToken.ThrowIfCancellationRequested();

			foreach (var file in d.GetFiles(searchPattern, options))
			{
				yield return file;
			}
		}
	}

	/// <summary>
	/// Sets <see cref="OneDriveFolder.AccountName"/> and <see cref="OneDriveFolder.AccountType"/> based on
	/// whether a display name exists in the registry key.
	/// </summary>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SetOneDriveFolderAccount), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void SetOneDriveFolderAccount(RegistryKey key, OneDriveFolder folder, string displayNameKey)
	{
		var name = key.GetValue<string>(displayNameKey);

		if (string.IsNullOrEmpty(name))
		{
			folder.AccountName = OneDriveAccountType.Personal.ToString();
		}
		else
		{
			folder.AccountType = OneDriveAccountType.Business;
			folder.AccountName = name;
		}
	}

	/// <summary>
	/// Sets the <see cref="OneDriveFolder.UserEmail"/> if a non-null value exists in the registry key.
	/// </summary>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SetOneDriveFolderEmail), UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static void SetOneDriveFolderEmail(RegistryKey key, OneDriveFolder folder, string emailKey)
	{
		var emailValue = key.GetValue<string>(emailKey);

		if (emailValue is not null)
		{
			folder.UserEmail = emailValue;
		}
	}
}
