// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-27-2026
// ***********************************************************************
// <copyright file="DirectoryHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class DirectoryHelperTests
{
	private const int RetryCount = 5;

	[TestMethod]
	public void AppDataFolder_ReturnsPathWithCompanyName()
	{
		// Arrange
		var entryAssembly = Assembly.GetEntryAssembly();
		var companyName = entryAssembly?.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault()?.Company?.Trim();

		// Act
		var result = DirectoryHelper.AppDataFolder();

		// Assert
		Assert.IsNotNull(result);
		Assert.EndsWith(companyName, result, $"The path should end with the company name: {companyName}");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CheckPermissionNonExistentDirectoryThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		// Act & Assert
		Assert.ThrowsExactly<Core.DirectoryNotFoundException>(() =>
			DirectoryHelper.CheckPermission(nonExistentDir));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CheckPermissionNullDirectoryThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.CheckPermission(null));
	}


	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CheckPermissionTest()
	{
		var path = Environment.GetFolderPath(Environment.SpecialFolder.System);

		Assert.IsTrue(DirectoryHelper.CheckPermission(new DirectoryInfo(path)));

		Assert.IsTrue(DirectoryHelper.CheckPermission(new DirectoryInfo(path), FileSystemRights.Write));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyDirectory_OverwriteTrue_ReplacesExistingContent()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = Directory.CreateDirectory(destinationDirectoryPath);

		var sourceFile = Path.Combine(sourceDirectoryPath, "file.txt");
		var destFile = Path.Combine(destinationDirectoryPath, "file.txt");

		File.WriteAllText(sourceFile, "updated content");
		File.WriteAllText(destFile, "original content");

		try
		{
			// Act
			DirectoryHelper.CopyDirectory(sourceDirectory, destinationDirectory, overwrite: true);

			// Assert - content should be overwritten
			Assert.AreEqual("updated content", File.ReadAllText(destFile), "The file content should have been overwritten.");
		}
		finally
		{
			sourceDirectory.Delete(true);
			if (Directory.Exists(destinationDirectoryPath))
			{
				destinationDirectory.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyDirectory_ValidSourceAndDestination_CopiesAllContents()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = new DirectoryInfo(destinationDirectoryPath);

		// Create a file in the source directory to test the copy
		File.WriteAllText(Path.Combine(sourceDirectory.FullName, "testFile.txt"), "This is a test file.");

		// Act
		DirectoryHelper.CopyDirectory(sourceDirectory, destinationDirectory, true);

		// Assert
		var copiedFilePath = Path.Combine(destinationDirectory.FullName, "testFile.txt");
		Assert.IsTrue(File.Exists(copiedFilePath), "The file should have been copied to the destination directory.");

		// Cleanup
		sourceDirectory.Delete(true);
		destinationDirectory.Delete(true);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyDirectoryNonExistentSourceThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentSource = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		// Act & Assert
		Assert.ThrowsExactly<Core.DirectoryNotFoundException>(() =>
			DirectoryHelper.CopyDirectory(nonExistentSource, destination));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyDirectoryNullDestinationThrowsArgumentNullException()
	{
		// Arrange
		var sourceDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert
			Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.CopyDirectory(sourceDirectory, null));
		}
		finally
		{
			sourceDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyDirectoryNullSourceThrowsArgumentNullException()
	{
		// Arrange
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.CopyDirectory(null, destination));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyDirectoryOverwriteFalseDoesNotOverwriteExistingFiles()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = Directory.CreateDirectory(destinationDirectoryPath);

		var sourceFile = Path.Combine(sourceDirectoryPath, "file.txt");
		var destFile = Path.Combine(destinationDirectoryPath, "file.txt");

		File.WriteAllText(sourceFile, "source content");
		File.WriteAllText(destFile, "original content");

		try
		{
			// Act - overwrite=false with Parallel.ForEach wraps IOException in AggregateException
			Assert.ThrowsExactly<AggregateException>(() =>
				DirectoryHelper.CopyDirectory(sourceDirectory, destinationDirectory, overwrite: false));

			// Assert - original content should remain unchanged
			Assert.AreEqual("original content", File.ReadAllText(destFile));
		}
		finally
		{
			sourceDirectory.Delete(true);
			if (Directory.Exists(destinationDirectoryPath))
			{
				destinationDirectory.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyDirectoryWithSubdirectoriesCopiesRecursively()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = new DirectoryInfo(destinationDirectoryPath);

		// Create subdirectory with files
		var subDir = Directory.CreateDirectory(Path.Combine(sourceDirectoryPath, "SubFolder"));
		File.WriteAllText(Path.Combine(sourceDirectoryPath, "root.txt"), "root content");
		File.WriteAllText(Path.Combine(subDir.FullName, "sub.txt"), "sub content");

		try
		{
			// Act
			DirectoryHelper.CopyDirectory(sourceDirectory, destinationDirectory, true);

			// Assert
			Assert.IsTrue(File.Exists(Path.Combine(destinationDirectoryPath, "root.txt")), "Root file should be copied.");
			Assert.IsTrue(File.Exists(Path.Combine(destinationDirectoryPath, "SubFolder", "sub.txt")), "Subdirectory file should be copied.");
		}
		finally
		{
			sourceDirectory.Delete(true);
			if (Directory.Exists(destinationDirectoryPath))
			{
				new DirectoryInfo(destinationDirectoryPath).Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_CustomRetryCount_Succeeds()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);
		File.WriteAllText(Path.Combine(tempDirectoryPath, "test.txt"), "content");

		try
		{
			// Act
			var result = DirectoryHelper.DeleteDirectory(directory, retries: 10);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsFalse(Directory.Exists(tempDirectoryPath), "The directory should have been deleted with custom retry count.");
		}
		finally
		{
			if (Directory.Exists(tempDirectoryPath))
			{
				Directory.Delete(tempDirectoryPath, true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_LockedFile_ReturnsFailedResultWithException()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		_ = Directory.CreateDirectory(tempDirectoryPath);
		var lockedFilePath = Path.Combine(tempDirectoryPath, "locked.txt");

		// Hold an open file handle to prevent deletion
		using var fileStream = new FileStream(lockedFilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.None);

		var directory = new DirectoryInfo(tempDirectoryPath);

		try
		{
			// Act — with recursive=true and only 1 retry the deletion will fail because the file is locked
			var result = DirectoryHelper.DeleteDirectory(directory, retries: 1);

			// Assert — the failure branch should have appended an IOException to the result
			Assert.IsNotNull(result);
			Assert.AreNotEqual(ResultStatus.Succeeded, result.Status);
			Assert.IsTrue(result.HasErrors, "Result should contain at least one exception when deletion fails.");
		}
		finally
		{
			fileStream.Dispose();

			if (Directory.Exists(tempDirectoryPath))
			{
				Directory.Delete(tempDirectoryPath, true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_RecursiveFalse_DeletesEmptyDirectory()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);

		try
		{
			// Act
			var result = DirectoryHelper.DeleteDirectory(directory, retries: 5, recursive: false);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsFalse(Directory.Exists(tempDirectoryPath), "The empty directory should have been deleted with recursive=false.");
		}
		finally
		{
			if (Directory.Exists(tempDirectoryPath))
			{
				Directory.Delete(tempDirectoryPath, true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_ValidDirectory_DeletesSuccessfully()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), nameof(this.DeleteDirectory_ValidDirectory_DeletesSuccessfully));

		var directory = new DirectoryInfo(tempDirectoryPath);
		directory.Create();

		// Act
		_ = DirectoryHelper.DeleteDirectory(directory);

		// Assert
		Assert.IsFalse(Directory.Exists(tempDirectoryPath), "The directory should have been deleted.");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_WithRetries_DeletesSuccessfullyAfterRetries()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), nameof(this.DeleteDirectory_WithRetries_DeletesSuccessfullyAfterRetries));

		var directory = new DirectoryInfo(tempDirectoryPath);
		directory.Create();

		_ = RandomData.GenerateFiles(tempDirectoryPath, 100);

		// Simulate a condition that would initially prevent deletion, such as a temporary lock by another process
		// For testing purposes, this is simulated by a short delay within the test, as actual process locking is complex and flaky in automated tests

		Task.Delay(100).ContinueWith(_ =>
		{
			DirectoryHelper.DeleteDirectory(directory, RetryCount);
		});

		// Act
		Thread.Sleep(500); // Wait for the delayed deletion attempt

		// Assert
		Assert.IsFalse(Directory.Exists(tempDirectoryPath), "The directory should have been deleted after retries.");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectory_ZeroRetries_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var directory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert - retries=0 is below the min of 1
			Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
				DirectoryHelper.DeleteDirectory(directory, retries: 0));
		}
		finally
		{
			if (directory.Exists)
			{
				directory.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectoryNonExistentThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(RandomData.GenerateRandomFileName());

		// Act & Assert - ArgumentExists validates directory exists and throws if not
		Assert.ThrowsExactly<Core.DirectoryNotFoundException>(() =>
			DirectoryHelper.DeleteDirectory(nonExistentDir));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectoryNullPathThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.DeleteDirectory(null));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteDirectoryReturnsSuccessResult()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);
		File.WriteAllText(Path.Combine(tempDirectoryPath, "test.txt"), "content");

		// Act
		var result = DirectoryHelper.DeleteDirectory(directory);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsFalse(Directory.Exists(tempDirectoryPath), "The directory should have been deleted.");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void GetOneDriveFolderTest()
	{
		var result = DirectoryHelper.LoadOneDriveFolders();

		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result);
	}

	[TestMethod]
	public async Task LoadFilesAsync_EmptyDirectory_ReturnsNoFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		try
		{
			var searchPattern = "*.txt";
			var searchOption = SearchOption.TopDirectoryOnly;
			var directories = new List<DirectoryInfo> { new DirectoryInfo(tempDirectory.FullName) };

			// Act
			var files = new List<FileInfo>();
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, searchPattern, searchOption))
			{
				files.AddRange(fileSet);
			}

			// Assert
			Assert.IsEmpty(files);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[TestMethod]
	public async Task LoadFilesAsync_InvalidSearchOption_DefaultsToTopDirectoryOnly()
	{
		// Arrange
		var tempDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		tempDirectory.Create();

		var subDirectory = new DirectoryInfo(Path.Combine(tempDirectory.FullName, "sub"));
		subDirectory.Create();

		File.WriteAllText(Path.Combine(tempDirectory.FullName, "root.txt"), "root");
		File.WriteAllText(Path.Combine(subDirectory.FullName, "sub.txt"), "sub");

		var directories = new List<DirectoryInfo> { tempDirectory };
		var results = new List<FileInfo>();

		try
		{
			// Act - pass an out-of-range SearchOption value to trigger the default branch
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, "*.txt", (SearchOption)99))
			{
				results.AddRange(fileSet);
			}

			// Assert: only the root file is found (TopDirectoryOnly behavior)
			Assert.AreEqual(1, results.Count, "Expected only top-level files when SearchOption is invalid.");
			Assert.AreEqual("root.txt", results[0].Name);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[TestMethod]
	public async Task LoadFilesAsync_PatternDoesNotMatchFiles_ReturnsEmpty()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create files that don't match the search pattern
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "file1.jpg"), "content1");
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "file2.png"), "content2");

			var directories = new List<DirectoryInfo> { tempDirectory };

			// Act
			var files = new List<FileInfo>();
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, "*.txt", SearchOption.TopDirectoryOnly))
			{
				files.AddRange(fileSet);
			}

			// Assert
			Assert.IsEmpty(files);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[TestMethod]
	public async Task LoadFilesAsync_RepeatedCalls_ReturnConsistentResults()
	{
		// Validates that caching EnumerationOptions does not corrupt state between calls.
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);
		File.WriteAllText(Path.Combine(tempPath, "file1.txt"), "content");
		File.WriteAllText(Path.Combine(tempPath, "file2.txt"), "content");

		try
		{
			var directories = new List<DirectoryInfo> { directory };

			var resultFirst = new List<FileInfo>();
			await foreach (var batch in DirectoryHelper.LoadFilesAsync(directories, "*.txt", SearchOption.TopDirectoryOnly))
			{
				resultFirst.AddRange(batch);
			}

			var resultSecond = new List<FileInfo>();
			await foreach (var batch in DirectoryHelper.LoadFilesAsync(directories, "*.txt", SearchOption.TopDirectoryOnly))
			{
				resultSecond.AddRange(batch);
			}

			Assert.AreEqual(resultFirst.Count, resultSecond.Count, "Repeated calls must return the same count.");
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[TestMethod]
	public async Task LoadFilesAsync_ValidDirectory_ReturnsFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		try
		{
			var searchPattern = "*.txt";
			var searchOption = SearchOption.TopDirectoryOnly;
			var directories = new List<DirectoryInfo> { new DirectoryInfo(tempDirectory.FullName) };

			// Create dummy files for testing
			var expectedFiles = new List<string>
			{
				Path.Combine(tempDirectory.FullName, "file1.txt"),
				Path.Combine(tempDirectory.FullName, "file2.txt")
			};

			foreach (var filePath in expectedFiles)
			{
				File.WriteAllText(filePath, "Test content");
			}

			// Act
			var files = new List<FileInfo>();
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, searchPattern, searchOption))
			{
				files.AddRange(fileSet);
			}

			// Assert
			Assert.HasCount(expectedFiles.Count, files);
			foreach (var file in files)
			{
				Assert.Contains(file.FullName, expectedFiles);
			}
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[TestMethod]
	public async Task LoadFilesAsyncAllDirectoriesReturnsFilesFromSubdirectories()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			var subDir = Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "SubFolder"));
			File.WriteAllText(Path.Combine(subDir.FullName, "nested.txt"), "nested content");

			var directories = new List<DirectoryInfo> { tempDirectory };

			// Act
			var files = new List<FileInfo>();
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, "*.txt", SearchOption.AllDirectories))
			{
				files.AddRange(fileSet);
			}

			// Assert
			Assert.HasCount(1, files);
			Assert.EndsWith("nested.txt", files[0].Name);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[TestMethod]
	public async Task LoadFilesAsyncMultipleDirectoriesReturnsFilesFromAll()
	{
		// Arrange
		var tempDir1 = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var tempDir2 = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(tempDir1.FullName, "file1.txt"), "content1");
			File.WriteAllText(Path.Combine(tempDir2.FullName, "file2.txt"), "content2");

			var directories = new List<DirectoryInfo> { tempDir1, tempDir2 };

			// Act
			var files = new List<FileInfo>();
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, "*.txt", SearchOption.TopDirectoryOnly))
			{
				files.AddRange(fileSet);
			}

			// Assert
			Assert.HasCount(2, files);
		}
		finally
		{
			tempDir1.Delete(true);
			tempDir2.Delete(true);
		}
	}

	[TestMethod]
	public async Task LoadFilesAsyncNonExistentDirectoryIsSkipped()
	{
		// Arrange
		var existingDir = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var nonExistentDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(existingDir.FullName, "file.txt"), "content");

			var directories = new List<DirectoryInfo> { nonExistentDir, existingDir };

			// Act
			var files = new List<FileInfo>();
			await foreach (var fileSet in DirectoryHelper.LoadFilesAsync(directories, "*.txt", SearchOption.TopDirectoryOnly))
			{
				files.AddRange(fileSet);
			}

			// Assert - only files from the existing directory should be returned
			Assert.HasCount(1, files);
			Assert.EndsWith("file.txt", files[0].Name);
		}
		finally
		{
			existingDir.Delete(true);
		}
	}

	[TestMethod]
	public async Task LoadFilesAsyncNullDirectoriesThrowsArgumentNullException()
	{
		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await foreach (var _ in DirectoryHelper.LoadFilesAsync(null, "*.txt", SearchOption.TopDirectoryOnly))
			{
				// Iteration triggers the exception
			}
		});
	}

	[TestMethod]
	public async Task LoadFilesAsyncNullSearchPatternThrowsArgumentNullException()
	{
		// Arrange
		var directories = new List<DirectoryInfo> { new DirectoryInfo(Path.GetTempPath()) };

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
		{
			await foreach (var _ in DirectoryHelper.LoadFilesAsync(directories, null, SearchOption.TopDirectoryOnly))
			{
				// Iteration triggers the exception
			}
		});
	}

	[TestMethod]
	public async Task LoadFilesAsyncWithCancellationThrowsOperationCanceledException()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "file.txt"), "content");
			var directories = new List<DirectoryInfo> { tempDirectory };

			using var cts = new CancellationTokenSource();
			cts.Cancel();

			// Act & Assert
			await Assert.ThrowsExactlyAsync<OperationCanceledException>(async () =>
			{
				await foreach (var _ in DirectoryHelper.LoadFilesAsync(directories, "*.txt", SearchOption.TopDirectoryOnly, cts.Token))
				{
					// Should not reach here
				}
			});
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectory_DestinationAlreadyExists_ReturnsFailedResult()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = Directory.CreateDirectory(destinationDirectoryPath); // already exists

		File.WriteAllText(Path.Combine(sourceDirectoryPath, "test.txt"), "content");

		try
		{
			// Act - Directory.Move fails when destination already exists
			var result = DirectoryHelper.MoveDirectory(sourceDirectory, destinationDirectory);

			// Assert - should have failed since destination exists
			Assert.IsNotNull(result);
			Assert.AreNotEqual(ResultStatus.Succeeded, result.Status, "Moving to an existing destination should not fully succeed.");
			Assert.IsTrue(result.Errors.Count > 0, "Failed result should contain an exception.");
		}
		finally
		{
			if (Directory.Exists(sourceDirectoryPath))
			{
				Directory.Delete(sourceDirectoryPath, true);
			}

			if (Directory.Exists(destinationDirectoryPath))
			{
				Directory.Delete(destinationDirectoryPath, true);
			}
		}
	}

	[TestMethod]
	public void MoveDirectory_EmptySourceDirectory_Succeeds()
	{
		// Arrange
		var sourcePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var source = Directory.CreateDirectory(sourcePath);
		var destination = new DirectoryInfo(destinationPath);

		// Act - source is empty (no files)
		var result = DirectoryHelper.MoveDirectory(source, destination);

		// Assert
		Assert.AreEqual(ResultStatus.Succeeded, result.Status, "Move of an empty directory should succeed.");
		Assert.IsTrue(Directory.Exists(destinationPath), "Destination directory should exist after move.");
		Assert.IsFalse(Directory.Exists(sourcePath), "Source directory should no longer exist.");

		// Cleanup
		DirectoryHelper.DeleteDirectory(destination);
	}

	[TestMethod]
	public void MoveDirectory_FailedMove_ErrorsContainIOExceptionWithPathInfo()
	{
		// Arrange — pre-create the destination so Directory.Move will fail
		var sourcePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var source = Directory.CreateDirectory(sourcePath);
		var destination = Directory.CreateDirectory(destinationPath);

		try
		{
			// Act
			var result = DirectoryHelper.MoveDirectory(source, destination);

			// Assert
			Assert.AreNotEqual(ResultStatus.Succeeded, result.Status, "Move should fail when destination already exists.");
			Assert.IsTrue(result.Errors.Count > 0, "Errors collection should not be empty on failure.");
			Assert.IsTrue(result.Errors.Any(e => e is IOException && e.Message.Contains("Directory could not be moved")), "Errors should contain an IOException with the move failure message.");
		}
		finally
		{
			// Cleanup
			if (Directory.Exists(sourcePath))
			{
				DirectoryHelper.DeleteDirectory(source);
			}

			DirectoryHelper.DeleteDirectory(destination);
		}
	}

	[TestMethod]
	public void MoveDirectory_WithRetriesMaxByte_ValidMove_Succeeds()
	{
		// Arrange
		var sourcePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var source = Directory.CreateDirectory(sourcePath);
		var destination = new DirectoryInfo(destinationPath);

		File.WriteAllText(Path.Combine(sourcePath, "file.txt"), "data");

		// Act
		var result = DirectoryHelper.MoveDirectory(source, destination, retries: byte.MaxValue);

		// Assert
		Assert.AreEqual(ResultStatus.Succeeded, result.Status, "Move should succeed with retries=255.");
		Assert.IsTrue(Directory.Exists(destinationPath), "Destination directory should exist.");

		// Cleanup
		DirectoryHelper.DeleteDirectory(destination);
	}

	[TestMethod]
	public void MoveDirectory_WithRetriesOne_ValidMove_Succeeds()
	{
		// Arrange
		var sourcePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var source = Directory.CreateDirectory(sourcePath);
		var destination = new DirectoryInfo(destinationPath);

		File.WriteAllText(Path.Combine(sourcePath, "file.txt"), "data");

		// Act
		var result = DirectoryHelper.MoveDirectory(source, destination, retries: 1);

		// Assert
		Assert.AreEqual(ResultStatus.Succeeded, result.Status, "Move should succeed with retries=1.");
		Assert.IsTrue(Directory.Exists(destinationPath), "Destination directory should exist.");
		Assert.IsFalse(Directory.Exists(sourcePath), "Source directory should no longer exist.");

		// Cleanup
		DirectoryHelper.DeleteDirectory(destination);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectory_WithSubdirectories_MovesAll()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = new DirectoryInfo(destinationDirectoryPath);

		// Create subdirectory with files
		var subDir = Directory.CreateDirectory(Path.Combine(sourceDirectoryPath, "SubFolder"));
		File.WriteAllText(Path.Combine(sourceDirectoryPath, "root.txt"), "root content");
		File.WriteAllText(Path.Combine(subDir.FullName, "sub.txt"), "sub content");

		try
		{
			// Act
			var result = DirectoryHelper.MoveDirectory(sourceDirectory, destinationDirectory);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsFalse(Directory.Exists(sourceDirectoryPath), "Source directory should no longer exist after move.");
			Assert.IsTrue(File.Exists(Path.Combine(destinationDirectoryPath, "root.txt")), "Root file should exist in destination.");
			Assert.IsTrue(File.Exists(Path.Combine(destinationDirectoryPath, "SubFolder", "sub.txt")), "Subdirectory file should exist in destination.");
		}
		finally
		{
			if (Directory.Exists(sourceDirectoryPath))
			{
				Directory.Delete(sourceDirectoryPath, true);
			}

			if (Directory.Exists(destinationDirectoryPath))
			{
				Directory.Delete(destinationDirectoryPath, true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectory_ZeroRetries_ThrowsArgumentOutOfRangeException()
	{
		// Arrange
		var sourceDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert - retries=0 is below the min of 1
			Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
				DirectoryHelper.MoveDirectory(sourceDirectory, destination, retries: 0));
		}
		finally
		{
			if (sourceDirectory.Exists)
			{
				sourceDirectory.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectoryNonExistentSourceThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentSource = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		// Act & Assert
		Assert.ThrowsExactly<Core.DirectoryNotFoundException>(() =>
			DirectoryHelper.MoveDirectory(nonExistentSource, destination));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectoryNullDestinationThrowsArgumentNullException()
	{
		// Arrange
		var sourceDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert
			Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.MoveDirectory(sourceDirectory, null));
		}
		finally
		{
			if (sourceDirectory.Exists)
			{
				sourceDirectory.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectoryNullSourceThrowsArgumentNullException()
	{
		// Arrange
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.MoveDirectory(null, destination));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectoryReturnsSuccessResult()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = new DirectoryInfo(destinationDirectoryPath);

		File.WriteAllText(Path.Combine(sourceDirectoryPath, "data.txt"), "content");

		// Act
		var result = DirectoryHelper.MoveDirectory(sourceDirectory, destinationDirectory);

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(ResultStatus.Succeeded, result.Status, "MoveDirectory should return a success status.");

		// Cleanup
		DirectoryHelper.DeleteDirectory(destinationDirectory);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectoryTest()
	{
		var folderSource = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), "Move1"));
		var folderDestination = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), "Move2"));

		var files = RandomData.GenerateFiles(folderSource.FullName, 100);

		foreach (var file in files)
		{
			FileHelper.AddReadOnlyAttribute(new FileInfo(file));
		}

		DirectoryHelper.MoveDirectory(folderSource, folderDestination, 10);

		Assert.IsTrue(folderDestination.EnumerateFiles().IsNotEmpty());

		DirectoryHelper.DeleteDirectory(folderDestination);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectoryValidSourceAndDestinationMovesAllContents()
	{
		// Arrange
		var sourceDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var destinationDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var sourceDirectory = Directory.CreateDirectory(sourceDirectoryPath);
		var destinationDirectory = new DirectoryInfo(destinationDirectoryPath);

		File.WriteAllText(Path.Combine(sourceDirectoryPath, "test.txt"), "test content");

		// Act
		var result = DirectoryHelper.MoveDirectory(sourceDirectory, destinationDirectory);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsFalse(Directory.Exists(sourceDirectoryPath), "Source directory should no longer exist after move.");
		Assert.IsTrue(File.Exists(Path.Combine(destinationDirectoryPath, "test.txt")), "File should exist in destination.");

		// Cleanup
		DirectoryHelper.DeleteDirectory(destinationDirectory);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributes_DirectoryWithAttributes_RemovesSpecifiedAttributes()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), nameof(this.RemoveAttributes_DirectoryWithAttributes_RemovesSpecifiedAttributes));
		var directory = Directory.CreateDirectory(tempDirectoryPath);

		// Create a file in the directory and set its attributes to ReadOnly and Hidden
		File.SetAttributes(tempDirectoryPath, FileAttributes.ReadOnly);

		// Act
		DirectoryHelper.RemoveAttributes(directory, FileAttributes.ReadOnly);

		// Assert
		var attributes = File.GetAttributes(tempDirectoryPath);
		Assert.IsFalse(attributes.HasFlag(FileAttributes.ReadOnly), "The file attributes should no longer include ReadOnly.");

		// Cleanup
		directory.Delete(true);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributes_MultipleAttributes_RemovesOnlySpecified()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);

		// Set ReadOnly attribute on the directory
		File.SetAttributes(tempDirectoryPath, directory.Attributes | FileAttributes.ReadOnly);

		try
		{
			// Act - only remove ReadOnly, keeping Directory attribute
			DirectoryHelper.RemoveAttributes(directory, FileAttributes.ReadOnly);

			// Assert
			directory.Refresh();
			Assert.IsFalse(directory.Attributes.HasFlag(FileAttributes.ReadOnly), "ReadOnly should have been removed.");
			Assert.IsTrue(directory.Attributes.HasFlag(FileAttributes.Directory), "Directory attribute should still be present.");
		}
		finally
		{
			// Ensure we can clean up
			var attributes = File.GetAttributes(tempDirectoryPath);
			File.SetAttributes(tempDirectoryPath, attributes & ~FileAttributes.ReadOnly);
			directory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributes_NullDirectory_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.RemoveAttributes(null, FileAttributes.ReadOnly));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributesNonExistentDirectoryThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(RandomData.GenerateRandomFileName());

		// Act & Assert - ArgumentExists validates directory exists on disk
		Assert.ThrowsExactly<Core.DirectoryNotFoundException>(() =>
			DirectoryHelper.RemoveAttributes(nonExistentDir, FileAttributes.ReadOnly));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributesRemovingUnsetAttributeDoesNotFail()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);

		try
		{
			// Act - removing ReadOnly from a directory that isn't ReadOnly should not fail
			DirectoryHelper.RemoveAttributes(directory, FileAttributes.ReadOnly);

			// Assert - directory should still exist and be accessible
			Assert.IsTrue(directory.Exists);
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearch_EmptySearchPattern_ThrowsArgumentNullException()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert - ArgumentNotNullOrEmpty throws on empty string
			Assert.ThrowsExactly<ArgumentNullException>(() =>
				DirectoryHelper.SafeDirectorySearch(tempDirectory, string.Empty).ToList());
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearch_NonExistentDirectory_ThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		// Act & Assert - ArgumentExists validates directory exists
		Assert.ThrowsExactly<Core.DirectoryNotFoundException>(() =>
			DirectoryHelper.SafeDirectorySearch(nonExistentDir, "*.txt", SearchOption.TopDirectoryOnly).ToList());
	}

	[TestMethod]
	public void SafeDirectorySearch_RepeatedCalls_ReturnConsistentResults()
	{
		// Validates that caching EnumerationOptions does not corrupt state between calls.
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);
		File.WriteAllText(Path.Combine(tempPath, "file1.txt"), "content");

		try
		{
			var resultFirst = DirectoryHelper.SafeDirectorySearch(directory, "*.txt", SearchOption.TopDirectoryOnly).ToList();
			var resultSecond = DirectoryHelper.SafeDirectorySearch(directory, "*.txt", SearchOption.TopDirectoryOnly).ToList();

			Assert.AreEqual(resultFirst.Count, resultSecond.Count, "Repeated calls must return the same count.");
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearchAllDirectoriesReturnsSubdirectories()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			var subDir = Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "SubFolder"));
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "top.txt"), "top content");
			File.WriteAllText(Path.Combine(subDir.FullName, "sub.txt"), "sub content");

			// Act
			var result = DirectoryHelper.SafeDirectorySearch(tempDirectory, "*.txt", SearchOption.AllDirectories).ToList();

			// Assert
			Assert.IsTrue(result.Count >= 2, "AllDirectories should return both top-level and subdirectory.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearchEmptyDirectoryReturnsEmpty()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act
			var result = DirectoryHelper.SafeDirectorySearch(tempDirectory, "*.txt", SearchOption.TopDirectoryOnly).ToList();

			// Assert
			Assert.IsEmpty(result);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearchNullPathThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.SafeDirectorySearch(null).ToList());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearchNullSearchPatternThrowsArgumentException()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert
			Assert.ThrowsExactly<ArgumentNullException>(() =>
				DirectoryHelper.SafeDirectorySearch(tempDirectory, null).ToList());
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearchTest()
	{
		var folder = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp"));

		var result = DirectoryHelper.SafeDirectorySearch(folder, ControlChars.WildcardAllFiles, SearchOption.AllDirectories);

		Assert.IsTrue(result.IsNotEmpty());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeDirectorySearchTopDirectoryOnlyReturnsOnlyTopLevel()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create a file in the top directory and a subdirectory with a file
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "top.txt"), "top content");
			var subDir = Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "SubFolder"));
			File.WriteAllText(Path.Combine(subDir.FullName, "sub.txt"), "sub content");

			// Act
			var result = DirectoryHelper.SafeDirectorySearch(tempDirectory, "*.txt", SearchOption.TopDirectoryOnly).ToList();

			// Assert
			Assert.IsTrue(result.All(d => d.FullName == tempDirectory.FullName), "TopDirectoryOnly should only return the top-level directory.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearch_IEnumerable_AllDirectories_ReturnsSubdirectoryFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "top.txt"), "top content");
			var subDir = Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "SubFolder"));
			File.WriteAllText(Path.Combine(subDir.FullName, "sub.txt"), "sub content");

			var directories = new List<DirectoryInfo> { tempDirectory };

			// Act
			var result = DirectoryHelper.SafeFileSearch(directories, "*.txt", SearchOption.AllDirectories).ToList();

			// Assert
			Assert.HasCount(2, result);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearch_IEnumerable_EmptySearchPattern_ThrowsArgumentNullException()
	{
		// Arrange
		var directories = new List<DirectoryInfo> { new DirectoryInfo(Path.GetTempPath()) };

		// Act & Assert - ArgumentNotNullOrEmpty throws on empty string
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			DirectoryHelper.SafeFileSearch(directories, string.Empty, SearchOption.TopDirectoryOnly).ToList());
	}

	[TestMethod]
	public void SafeFileSearch_IEnumerable_RepeatedCalls_ReturnConsistentResults()
	{
		// Validates that caching EnumerationOptions does not corrupt state between calls.
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);
		File.WriteAllText(Path.Combine(tempPath, "file1.txt"), "content");
		File.WriteAllText(Path.Combine(tempPath, "file2.txt"), "content");

		try
		{
			var directories = new List<DirectoryInfo> { directory };

			var resultFirst = DirectoryHelper.SafeFileSearch(directories, "*.txt", SearchOption.TopDirectoryOnly).ToList();
			var resultSecond = DirectoryHelper.SafeFileSearch(directories, "*.txt", SearchOption.TopDirectoryOnly).ToList();

			Assert.AreEqual(resultFirst.Count, resultSecond.Count, "Repeated calls must return the same count.");
			Assert.AreEqual(2, resultFirst.Count, "Both txt files must be found.");
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchAllDirectoriesReturnsSubdirectoryFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "top.txt"), "top content");
			var subDir = Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "SubFolder"));
			File.WriteAllText(Path.Combine(subDir.FullName, "sub.txt"), "sub content");

			// Act
			var result = DirectoryHelper.SafeFileSearch(tempDirectory, "*.txt", SearchOption.AllDirectories);

			// Assert
			Assert.HasCount(2, result);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchEmptyDirectoryReturnsEmpty()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act
			var result = DirectoryHelper.SafeFileSearch(tempDirectory, "*.txt", SearchOption.TopDirectoryOnly);

			// Assert
			Assert.IsEmpty(result);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchIEnumerableMultipleDirectoriesReturnsCombinedResults()
	{
		// Arrange
		var tempDir1 = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var tempDir2 = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(tempDir1.FullName, "file1.txt"), "content1");
			File.WriteAllText(Path.Combine(tempDir2.FullName, "file2.txt"), "content2");

			var directories = new List<DirectoryInfo> { tempDir1, tempDir2 };

			// Act
			var result = DirectoryHelper.SafeFileSearch(directories, "*.txt", SearchOption.TopDirectoryOnly).ToList();

			// Assert
			Assert.HasCount(2, result);
		}
		finally
		{
			tempDir1.Delete(true);
			tempDir2.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchIEnumerableNonExistentDirectoryReturnsEmpty()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var directories = new List<DirectoryInfo> { nonExistentDir };

		// Act
		var result = DirectoryHelper.SafeFileSearch(directories, "*.txt", SearchOption.TopDirectoryOnly).ToList();

		// Assert
		Assert.IsEmpty(result);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchIEnumerableNullDirectoriesThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.SafeFileSearch((IEnumerable<DirectoryInfo>)null, "*.txt", SearchOption.TopDirectoryOnly).ToList());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchIEnumerableNullSearchPatternThrowsArgumentNullException()
	{
		// Arrange
		var directories = new List<DirectoryInfo> { new DirectoryInfo(Path.GetTempPath()) };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			DirectoryHelper.SafeFileSearch(directories, null, SearchOption.TopDirectoryOnly).ToList());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchIEnumerableTest()
	{
		var folders = new List<DirectoryInfo>();

		var folder = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp"));

		folders.Add(folder);

		var result = DirectoryHelper.SafeFileSearch(folders, "*.tmp", SearchOption.AllDirectories).ToArray();

		Assert.IsTrue(result.IsNotEmpty());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchNullPathThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.SafeFileSearch((DirectoryInfo)null, "*.txt", SearchOption.TopDirectoryOnly));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchNullSearchPatternThrowsArgumentNullException()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert
			Assert.ThrowsExactly<ArgumentNullException>(() =>
				DirectoryHelper.SafeFileSearch(tempDirectory, null, SearchOption.TopDirectoryOnly));
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchTest()
	{
		var folder = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp"));

		var result = DirectoryHelper.SafeFileSearch(folder, "*.tmp", SearchOption.AllDirectories);

		Assert.IsTrue(result.IsNotEmpty());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeFileSearchTopDirectoryOnlyDoesNotReturnSubdirectoryFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "top.txt"), "top content");
			var subDir = Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "SubFolder"));
			File.WriteAllText(Path.Combine(subDir.FullName, "sub.txt"), "sub content");

			// Act
			var result = DirectoryHelper.SafeFileSearch(tempDirectory, "*.txt", SearchOption.TopDirectoryOnly);

			// Assert
			Assert.HasCount(1, result);
			Assert.EndsWith("top.txt", result[0].Name);
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_AllDirectories_FindsSubdirectoryFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create subdirectory with matching file
			var subDir = Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "SubFolder"));
			File.WriteAllText(Path.Combine(subDir.FullName, "test.txt"), "content");

			var searchPatterns = new List<string> { "*.txt" }.AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.AllDirectories, searchPatterns);

			// Assert
			Assert.IsTrue(result, "AllDirectories should find files in subdirectories.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_EmptyDirectory_ReturnsFalse()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			var searchPatterns = new List<string> { "*.txt", "*.docx" }.AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, searchPatterns);

			// Assert
			Assert.IsFalse(result, "Empty directory should return false.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_EmptySearchPatterns_ReturnsFalse()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test.txt"), "content");

			var searchPatterns = new List<string>().AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, searchPatterns);

			// Assert
			Assert.IsFalse(result, "Empty search patterns should return false.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_MultiplePatterns_NoMatches_ReturnsFalse()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create file not matching any pattern
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test.jpg"), "content");

			var searchPatterns = new List<string> { "*.txt", "*.docx", "*.pdf" }.AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, searchPatterns);

			// Assert
			Assert.IsFalse(result, "Directory with no matching patterns should return false.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_MultiplePatterns_OneMatch_ReturnsTrue()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create file matching only one pattern
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test.txt"), "content");

			var searchPatterns = new List<string> { "*.txt", "*.docx", "*.pdf" }.AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, searchPatterns);

			// Assert
			Assert.IsTrue(result, "Directory with at least one matching pattern should return true.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_NonExistentDirectory_ThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var searchPatterns = new List<string> { "*.txt" }.AsReadOnly();

		// Act & Assert - ArgumentExists validates directory exists
		Assert.ThrowsExactly<Core.DirectoryNotFoundException>(() =>
			DirectoryHelper.SafeHasFoldersOrFiles(nonExistentDir, SearchOption.TopDirectoryOnly, searchPatterns));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_NullPath_ThrowsArgumentNullException()
	{
		// Arrange
		DirectoryInfo nullPath = null;
		var searchPatterns = new List<string> { "*.txt" }.AsReadOnly();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			DirectoryHelper.SafeHasFoldersOrFiles(nullPath, SearchOption.TopDirectoryOnly, searchPatterns));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_NullSearchPatterns_ThrowsArgumentNullException()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert
			Assert.ThrowsExactly<ArgumentNullException>(() =>
				DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, null));
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_TopDirectoryOnly_IgnoresSubdirectoryFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create subdirectory with matching file
			var subDir = Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "SubFolder"));
			File.WriteAllText(Path.Combine(subDir.FullName, "test.txt"), "content");

			var searchPatterns = new List<string> { "*.txt" }.AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, searchPatterns);

			// Assert
			Assert.IsFalse(result, "TopDirectoryOnly should not find files in subdirectories.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_WildcardPattern_MatchesAllFiles()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create various files
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test.txt"), "content");
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test.jpg"), "content");
			Directory.CreateDirectory(Path.Combine(tempDirectory.FullName, "folder"));

			var searchPatterns = new List<string> { "*.*" }.AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, searchPatterns);

			// Assert
			Assert.IsTrue(result, "Wildcard pattern should match files and folders.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_WithMatchingFiles_ReturnsTrue()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create test files
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test1.txt"), "content");
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test2.docx"), "content");

			var searchPatterns = new List<string> { "*.txt" }.AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, searchPatterns);

			// Assert
			Assert.IsTrue(result, "Directory with matching files should return true.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SafeHasFoldersOrFiles_WithNoMatchingFiles_ReturnsFalse()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Create test files that don't match pattern
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test1.jpg"), "content");
			File.WriteAllText(Path.Combine(tempDirectory.FullName, "test2.png"), "content");

			var searchPatterns = new List<string> { "*.txt", "*.docx" }.AsReadOnly();

			// Act
			var result = DirectoryHelper.SafeHasFoldersOrFiles(tempDirectory, SearchOption.TopDirectoryOnly, searchPatterns);

			// Assert
			Assert.IsFalse(result, "Directory with no matching files should return false.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SetFileAttributesToNormal_NullPath_ThrowsArgumentNullException()
	{
		// Act & Assert - SetFileAttributesToNormal calls path.CheckExists() which calls ArgumentNotNull() on null
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.SetFileAttributesToNormal(null));
	}

	[TestMethod]
	public void SetFileAttributesToNormal_RepeatedCalls_DoNotThrow()
	{
		// Validates that caching EnumerationOptions does not corrupt state between repeated calls.
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);
		var filePath = Path.Combine(tempPath, "file.txt");
		File.WriteAllText(filePath, "content");
		File.SetAttributes(filePath, FileAttributes.ReadOnly);
		var startingAttributes = File.GetAttributes(filePath);
		Assert.IsTrue(startingAttributes.HasFlag(FileAttributes.ReadOnly), "Precondition failed: file should start as read-only.");

		try
		{
			DirectoryHelper.SetFileAttributesToNormal(directory);
			DirectoryHelper.SetFileAttributesToNormal(directory);

			Assert.IsTrue(directory.Exists, "Directory should still exist after repeated calls.");
			Assert.IsTrue(File.Exists(filePath), "File should still exist after repeated calls.");
			var attributes = File.GetAttributes(filePath);
			Assert.IsFalse(attributes.HasFlag(FileAttributes.ReadOnly), "ReadOnly attribute should be removed after repeated calls.");
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SetFileAttributesToNormal_ValidDirectory_SetsAttributesSuccessfully()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);

		// Create a file in the directory and set its attributes to ReadOnly
		var testFilePath = Path.Combine(tempDirectoryPath, "testFile.txt");
		var testFile = File.Create(testFilePath);
		testFile.Close();
		File.SetAttributes(testFilePath, FileAttributes.ReadOnly);

		// Act
		DirectoryHelper.SetFileAttributesToNormal(directory);

		// Assert
		var attributes = File.GetAttributes(testFilePath);
		Assert.IsFalse(attributes.HasFlag(FileAttributes.ReadOnly), "The file attributes should no longer include ReadOnly.");

		// Cleanup
		directory.Delete(true);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SetFileAttributesToNormalEmptyDirectoryDoesNotThrow()
	{
		// Arrange
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			// Act & Assert - should complete without throwing on an empty directory
			DirectoryHelper.SetFileAttributesToNormal(tempDirectory);

			Assert.IsTrue(tempDirectory.Exists, "Directory should still exist.");
			Assert.AreEqual(0, tempDirectory.GetFileSystemInfos().Length, "Directory should remain empty.");
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SetFileAttributesToNormalMultipleFilesWithReadOnlySetsAllToNormal()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);

		var filePaths = new List<string>();
		for (var i = 0; i < 3; i++)
		{
			var filePath = Path.Combine(tempDirectoryPath, $"testFile{i}.txt");
			File.WriteAllText(filePath, $"content {i}");
			File.SetAttributes(filePath, FileAttributes.ReadOnly);
			filePaths.Add(filePath);
		}

		// Act
		DirectoryHelper.SetFileAttributesToNormal(directory);

		// Assert
		foreach (var filePath in filePaths)
		{
			var attributes = File.GetAttributes(filePath);
			Assert.IsFalse(attributes.HasFlag(FileAttributes.ReadOnly), $"File {filePath} should no longer be ReadOnly.");
		}

		// Cleanup
		directory.Delete(true);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SetFileAttributesToNormalNonExistentDirectoryDoesNotThrow()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var nonExistentPath = nonExistentDir.FullName;

		// Act & Assert - should return early without throwing
		DirectoryHelper.SetFileAttributesToNormal(nonExistentDir);

		Assert.IsFalse(Directory.Exists(nonExistentPath), "Non-existent directory should remain non-existent.");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void SetFileAttributesToNormalSubdirectoryFilesSetsAllToNormal()
	{
		// Arrange
		var tempDirectoryPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempDirectoryPath);
		var subDir = Directory.CreateDirectory(Path.Combine(tempDirectoryPath, "SubFolder"));

		var rootFile = Path.Combine(tempDirectoryPath, "root.txt");
		var subFile = Path.Combine(subDir.FullName, "sub.txt");

		File.WriteAllText(rootFile, "root content");
		File.WriteAllText(subFile, "sub content");
		File.SetAttributes(rootFile, FileAttributes.ReadOnly);
		File.SetAttributes(subFile, FileAttributes.ReadOnly);

		// Act
		DirectoryHelper.SetFileAttributesToNormal(directory);

		// Assert
		Assert.IsFalse(File.GetAttributes(rootFile).HasFlag(FileAttributes.ReadOnly), "Root file should no longer be ReadOnly.");
		Assert.IsFalse(File.GetAttributes(subFile).HasFlag(FileAttributes.ReadOnly), "Subdirectory file should no longer be ReadOnly.");

		// Cleanup
		directory.Delete(true);
	}

	[TestMethod]
	public void CopyDirectory_WithCancelledToken_ThrowsOperationCanceledException()
	{
		var source = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			using var cts = new CancellationTokenSource();
			cts.Cancel();

			_ = Assert.ThrowsExactly<OperationCanceledException>(() =>
			{
				DirectoryHelper.CopyDirectory(source, destination, cancellationToken: cts.Token);
			});
		}
		finally
		{
			if (source.Exists) { source.Delete(true); }
			if (destination.Exists) { destination.Delete(true); }
		}
	}

	[TestMethod]
	public void DeleteDirectory_WithCancelledToken_ThrowsOperationCanceledException()
	{
		var dir = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			using var cts = new CancellationTokenSource();
			cts.Cancel();

			_ = Assert.ThrowsExactly<OperationCanceledException>(() =>
			{
				DirectoryHelper.DeleteDirectory(dir, cancellationToken: cts.Token);
			});
		}
		finally
		{
			if (dir.Exists) { dir.Delete(true); }
		}
	}

	[TestMethod]
	public void MoveDirectory_WithCancelledToken_ThrowsOperationCanceledException()
	{
		var source = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			using var cts = new CancellationTokenSource();
			cts.Cancel();

			_ = Assert.ThrowsExactly<OperationCanceledException>(() =>
			{
				DirectoryHelper.MoveDirectory(source, destination, cancellationToken: cts.Token);
			});
		}
		finally
		{
			if (source.Exists) { source.Delete(true); }
			if (destination.Exists) { destination.Delete(true); }
		}
	}

	[TestMethod]
	public void SafeDirectorySearch_WithCancelledToken_ThrowsOperationCanceledException()
	{
		var dir = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(dir.FullName, "file.txt"), "content");
			using var cts = new CancellationTokenSource();
			cts.Cancel();

			_ = Assert.ThrowsExactly<OperationCanceledException>(() =>
			{
				foreach (var _ in DirectoryHelper.SafeDirectorySearch(dir, "*.*", SearchOption.TopDirectoryOnly, cts.Token))
				{
					// iteration triggers the check
				}
			});
		}
		finally
		{
			if (dir.Exists) { dir.Delete(true); }
		}
	}

	[TestMethod]
	public void SafeFileSearch_DirectoryInfo_WithCancelledToken_ThrowsOperationCanceledException()
	{
		var dir = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(dir.FullName, "file.txt"), "content");
			using var cts = new CancellationTokenSource();
			cts.Cancel();

			_ = Assert.ThrowsExactly<OperationCanceledException>(() =>
			{
				_ = DirectoryHelper.SafeFileSearch(dir, "*.txt", SearchOption.TopDirectoryOnly, cts.Token);
			});
		}
		finally
		{
			if (dir.Exists) { dir.Delete(true); }
		}
	}

	[TestMethod]
	public void SafeFileSearch_IEnumerable_WithCancelledToken_ThrowsOperationCanceledException()
	{
		var dir = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(dir.FullName, "file.txt"), "content");
			using var cts = new CancellationTokenSource();
			cts.Cancel();

			_ = Assert.ThrowsExactly<OperationCanceledException>(() =>
			{
				_ = DirectoryHelper.SafeFileSearch(new List<DirectoryInfo> { dir }, "*.txt", SearchOption.TopDirectoryOnly, cts.Token).ToList();
			});
		}
		finally
		{
			if (dir.Exists) { dir.Delete(true); }
		}
	}

	[TestMethod]
	public void SetFileAttributesToNormal_WithCancelledToken_ThrowsOperationCanceledException()
	{
		var dir = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

		try
		{
			File.WriteAllText(Path.Combine(dir.FullName, "file.txt"), "content");
			using var cts = new CancellationTokenSource();
			cts.Cancel();

			_ = Assert.ThrowsExactly<OperationCanceledException>(() =>
			{
				DirectoryHelper.SetFileAttributesToNormal(dir, cts.Token);
			});
		}
		finally
		{
			if (dir.Exists) { dir.Delete(true); }
		}
	}
}
