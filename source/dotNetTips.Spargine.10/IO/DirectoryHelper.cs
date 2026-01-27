// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-27-2026
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
[Information(Status = Status.UpdateDocumentation, Documentation = "https://bit.ly/SpargineDirectoryHelper")]
public static class DirectoryHelper
{
	private const string LocalAppData = "LOCALAPPDATA";

	/// <summary>
	/// Gets the application data folder path for the current user.
	/// </summary>
	/// <returns>The path to the application data folder.</returns>
	/// <exception cref="InvalidOperationException">Thrown when the user path environment variable is not set.</exception>
	[SupportedOSPlatform("macos")]
	[Information(nameof(AppDataFolder), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static string AppDataFolder()
	{
		var userPath = LocalAppData;

		var companyName = Assembly.GetEntryAssembly()?.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault()?.Company?.Trim();

		if (string.IsNullOrEmpty(companyName))
		{
			ExceptionThrower.ThrowInvalidOperationException(Resources.AssemblyCompanyNameAttributeIsNotSet);
		}

		return Path.Combine(userPath, companyName);
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

			switch (rule.AccessControlType)
			{
				case AccessControlType.Allow:
					allow = true;
					break;
				case AccessControlType.Deny:
					deny = true;
					break;
				default:
					break;
			}
		}

		return allow && !deny;
	}

	/// <summary>
	/// Copies the specified source directory to the specified destination directory.
	/// </summary>
	/// <param name="source">The source directory to copy from.</param>
	/// <param name="destination">The destination directory to copy to.</param>
	/// <param name="overwrite">if set to <c>true</c>, the destination files will be overwritten if they already exist.</param>
	/// <example>
	/// This example shows how to use the <see cref="CopyDirectory" /> method.
	/// <code>
	/// var sourceDir = new DirectoryInfo(@"C:\SourceDirectory");
	/// var destDir = new DirectoryInfo(@"C:\DestinationDirectory");
	/// DirectoryHelper.CopyDirectory(sourceDir, destDir, true);
	/// </code></example>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="source"/> or <paramref name="destination"/> is null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CopyDirectory), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
	public static void CopyDirectory([DisallowNull] DirectoryInfo source, [NotNull] DirectoryInfo destination, bool overwrite = true)
	{
		source = source.ArgumentExists();
		destination = destination.ArgumentNotNull();

		if (destination.CheckExists(createDirectory: true) == false)
		{
			ExceptionThrower.ThrowDirectoryNotFoundException(Resources.CouldNotCreateDirectory, destination);
		}

		var files = source.GetFiles();
		var subdirs = source.GetDirectories();

		_ = Parallel.ForEach(files, file =>
		{
			var destFile = Path.Combine(destination.FullName, file.Name);
			_ = file.CopyTo(destFile, overwrite);
		});

		_ = Parallel.ForEach(subdirs, subdir =>
		{
			var destSubDir = destination.CreateSubdirectory(subdir.Name);
			CopyDirectory(subdir, destSubDir, overwrite);
		});
	}

	/// <summary>
	/// Deletes the directory with retry.
	/// </summary>
	/// <param name="path">The directory to delete.</param>
	/// <param name="retries">Number of retries in case of failure. Default is 5.</param>
	/// <param name="recursive">Specifies whether to delete directories, subdirectories, and files in <paramref name="path"/>.</param>
	/// <returns>A <see cref="SimpleResult{T}"/> indicating the result of the operation.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="path"/> is null.</exception>
	/// <exception cref="IOException">Thrown when the directory could not be deleted after the specified number of retries.</exception>
	/// <exception cref="UnauthorizedAccessException">Thrown when the directory could not be deleted due to unauthorized access after the specified number of retries.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DeleteDirectory), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Update, Status = Status.Updated)]
	public static SimpleResult<int> DeleteDirectory([DisallowNull] DirectoryInfo path, [ConstantExpected(Min = 1, Max = byte.MaxValue)] byte retries = 5, bool recursive = true)
	{
		path = path.ArgumentExists();
		retries = retries.ArgumentInRange(min: 1, max: byte.MaxValue, Resources.RetriesAreLimitedTo255);

		if (path.Exists == false)
		{
			return SimpleResult.FromException<int>(new Core.DirectoryNotFoundException());
		}

		// On some systems, directories/files created are created with attributes
		// that prevent them from being deleted. Set those attributes to be normal
		SetFileAttributesToNormal(path);

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
	[Information(nameof(LoadFilesAsync), author: "David McCarter", createdOn: "3/1/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static async IAsyncEnumerable<IEnumerable<FileInfo>> LoadFilesAsync([DisallowNull] IEnumerable<DirectoryInfo> directories, [DisallowNull] string searchPattern, SearchOption searchOption, [EnumeratorCancellation] CancellationToken cancellationToken = default)
	{
		directories = directories.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNull();

		if (searchOption.CheckIsDefined() is false)
		{
			searchOption = SearchOption.TopDirectoryOnly;
		}

		var options = new EnumerationOptions() { IgnoreInaccessible = true, RecurseSubdirectories = searchOption == SearchOption.AllDirectories };

		var tasks = directories.Where(directory => directory.CheckExists())
			.Select(directory => Task.Run(() => directory.GetFiles(searchPattern, options), cancellationToken))
			.ToList();

		foreach (var task in tasks)
		{
			yield return await task.ConfigureAwait(false);
		}
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
	[Information(nameof(LoadOneDriveFolders), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
	public static ReadOnlyCollection<OneDriveFolder> LoadOneDriveFolders()
	{
		const string DisplayNameKey = "DisplayName";
		const string UserFolderKey = "UserFolder";
		const string AccountsKey = "Accounts";
		const string EmailKey = "UserEmail";

		var folders = new List<OneDriveFolder>();

		using (var oneDriveKey = RegistryHelper.GetRegistryKey(RegistryHelper.KeyCurrentUserOneDrive, RegistryHive.CurrentUser))
		{
			if (oneDriveKey!.IsNotNull())
			{
				// Get Accounts
				using (var accountKey = oneDriveKey?.GetSubKey(AccountsKey))
				{
					if (accountKey!.IsNotNull() && accountKey?.SubKeyCount > 0)
					{
						var subkeyCount = accountKey.GetSubKeyNames().LongLength;

						for (var subKeyIndex = 0; subKeyIndex < subkeyCount; subKeyIndex++)
						{
							using var key = accountKey.OpenSubKey(accountKey.GetSubKeyNames()[subKeyIndex]);

							var folder = new OneDriveFolder();
							var directoryValue = key?.GetValue<string>(UserFolderKey);

							if (!string.IsNullOrEmpty(directoryValue) && directoryValue.HasValue())
							{
								folder.DirectoryInfo = new DirectoryInfo(directoryValue);

								var emailValue = key?.GetValue<string>(EmailKey);

								if (emailValue!.IsNotNull())
								{
									folder.UserEmail = emailValue!;
								}

								// Figure out account type
								var name = key?.GetValue<string>(DisplayNameKey);

								if (!string.IsNullOrEmpty(name) && name.HasValue())
								{
									folder.AccountType = OneDriveAccountType.Business;
									folder.AccountName = name;
								}
								else
								{
									folder.AccountName = OneDriveAccountType.Personal.ToString();
								}

								folders.Add(folder);
							}
						}
					}
				}
			}
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
	[Information(nameof(MoveDirectory), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Update, Status = Status.Updated)]
	public static SimpleResult<int> MoveDirectory([DisallowNull] DirectoryInfo source, [DisallowNull] DirectoryInfo destination, [ConstantExpected(Min = 1, Max = byte.MaxValue)] byte retries = 5)
	{
		source = source.ArgumentExists();
		destination = destination.ArgumentNotNull();

		retries = retries.ArgumentInRange(min: 1, max: byte.MaxValue, errorMessage: Resources.RetriesAreLimitedTo255);

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
	[Information(nameof(RemoveAttributes), OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
	public static void RemoveAttributes([DisallowNull] DirectoryInfo path, in FileAttributes attributesToRemove)
	{
		path = path.ArgumentExists();

		if (path.CheckExists() == false)
		{
			return;
		}

		path.Attributes &= ~attributesToRemove;
	}

	/// <summary>
	/// Performs a safe directory search by matching a specified search pattern and search option.
	/// </summary>
	/// <param name="path">The root directory to start the search from. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the directory names. Default is "*.*" which matches all directories.</param>
	/// <param name="searchOption">Specifies whether to search only the current directory, or all subdirectories. The default is <see cref="SearchOption.TopDirectoryOnly" />.</param>
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
	[Information(nameof(SafeDirectorySearch), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<DirectoryInfo> SafeDirectorySearch([DisallowNull] DirectoryInfo path, [DisallowNull] string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		//OPTIMIZATION FROM COPILOT BREAKS CODE
		path = path.ArgumentExists();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		var options = new EnumerationOptions { IgnoreInaccessible = true, ReturnSpecialDirectories = true, RecurseSubdirectories = false, AttributesToSkip = FileAttributes.Hidden };

		if (searchOption == SearchOption.AllDirectories)
		{
			options.RecurseSubdirectories = true;
		}

		var directories = path.GetFiles(searchPattern, searchOption).Select(file => file.Directory).FastDistinct().ToArray();

		var itemCount = directories.LongLength;

		for (var index = 0; index < itemCount; index++)
		{
			yield return directories[index]!;
		}
	}

	/// <summary>
	/// Performs a safe path search in the specified directory using the given search pattern and search option.
	/// Ignores errors accessing directories.
	/// </summary>
	/// <param name="path">The directory to search. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="path"/>.</param>
	/// <param name="searchOption">Specifies whether the search operation should include only the current directory or should include all subdirectories. Uses <see cref="SearchOption"/>.</param>
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
	[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<FileInfo> SafeFileSearch([DisallowNull] DirectoryInfo path, [DisallowNull] string searchPattern, SearchOption searchOption)
	{
		var directories = new List<DirectoryInfo>(1)
		{
			path
		};

		return SafeFileSearch(directories, searchPattern, searchOption).ToReadOnlyCollection();
	}

	/// <summary>
	/// Performs a safe path search in the specified directories using the given search pattern and search option.
	/// Ignores errors accessing directories.
	/// </summary>
	/// <param name="directories">The directories to search. Must not be null.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="directories"/>.</param>
	/// <param name="searchOption">Specifies whether the search operation should include only the current directory or should include all subdirectories. Uses <see cref="SearchOption"/>.</param>
	/// <returns>An <see cref="IEnumerable{FileInfo}"/> containing files that match the search pattern and option.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="directories"/> or <paramref name="searchPattern"/> is null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption"/> is not a valid <see cref="SearchOption"/>.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static IEnumerable<FileInfo> SafeFileSearch([DisallowNull] IEnumerable<DirectoryInfo> directories, [DisallowNull] string searchPattern, [DisallowNull] SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		directories = directories.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		var options = new EnumerationOptions { IgnoreInaccessible = true, ReturnSpecialDirectories = true, RecurseSubdirectories = false, AttributesToSkip = FileAttributes.Hidden };

		if (searchOption == SearchOption.AllDirectories)
		{
			options.RecurseSubdirectories = true;
		}

		foreach (var directory in directories)
		{
			if (directory.CheckExists())
			{
				var directoryFiles = directory.GetFiles(searchPattern, options);

				if (directoryFiles.IsNotEmpty())
				{
					foreach (var directoryFile in directoryFiles)
					{
						yield return directoryFile;
					}
				}
			}
		}
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
	/// This method utilizes <see cref="SafeDirectorySearch(DirectoryInfo, string, SearchOption)"/> to perform a robust and error-tolerant search.
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
	[Information(nameof(SafeDirectorySearch), "David McCarter", "6/14/2021", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, UnitTestStatus = UnitTestStatus.Completed, Status = Status.Updated)]
	public static bool SafeHasFoldersOrFiles([DisallowNull] DirectoryInfo path, SearchOption searchOption = SearchOption.TopDirectoryOnly, [DisallowNull] params ReadOnlyCollection<string> searchPatterns)
	{
		path = path.ArgumentExists();

		searchOption = searchOption.ArgumentDefined();
		searchPatterns = searchPatterns.ArgumentNotNull();

		//Search for directories
		var directoryFound = searchPatterns.Any(pattern => SafeDirectorySearch(path, pattern, searchOption).IsNotEmpty());

		if (directoryFound)
		{
			return true;
		}
		else
		{
			//Search for files
			return searchPatterns.Any(pattern => SafeFileSearch(path, pattern, searchOption).IsNotEmpty());
		}
	}

	/// <summary>
	/// Sets the attributes of all files in the specified directory, and its subdirectories, to normal.
	/// </summary>
	/// <param name="path">The directory whose path attributes will be set to normal. Must not be null.</param>
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
	[Information(nameof(SetFileAttributesToNormal), "David McCarter", "2/14/2018", OptimizationStatus = OptimizationStatus.Completed, BenchmarkStatus = BenchmarkStatus.Completed, UnitTestStatus = UnitTestStatus.Update, Status = Status.Available)]
	public static void SetFileAttributesToNormal([DisallowNull] DirectoryInfo path)
	{
		if (path.CheckExists() == false)
		{
			return;
		}

		// Set the directory attributes to normal
		RemoveAttributes(path, FileAttributes.ReadOnly);

		var dirs = SafeDirectorySearch(path, ControlChars.WildcardAllFiles, SearchOption.AllDirectories);

		foreach (var dir in dirs)
		{
			RemoveAttributes(dir, FileAttributes.ReadOnly);
		}

		var files = SafeFileSearch(path, ControlChars.WildcardAllFiles, SearchOption.AllDirectories);

		// Set the path attributes to normal
		foreach (var file in files)
		{
			if (file.Exists)
			{
				file.Attributes = FileAttributes.Normal;
			}
		}
	}
}
