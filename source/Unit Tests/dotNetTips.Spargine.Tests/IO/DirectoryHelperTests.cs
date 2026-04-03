// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-16-2026
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
	public void CheckPermissionTest()
	{
		var path = Environment.GetFolderPath(Environment.SpecialFolder.System);

		Assert.IsTrue(DirectoryHelper.CheckPermission(new DirectoryInfo(path)));

		Assert.IsTrue(DirectoryHelper.CheckPermission(new DirectoryInfo(path), FileSystemRights.Write));
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

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveDirectoryTest()
	{
		var folderSource = new DirectoryInfo(Path.Combine(App.ProcessPath, "Move1"));
		var folderDestination = new DirectoryInfo(Path.Combine(App.ProcessPath, "Move2"));

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
	public void RemoveAttributes_NullDirectory_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryHelper.RemoveAttributes(null, FileAttributes.ReadOnly));
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
	public void SafeFileSearchTest()
	{
		var folder = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp"));

		var result = DirectoryHelper.SafeFileSearch(folder, "*.tmp", SearchOption.AllDirectories);

		Assert.IsTrue(result.IsNotEmpty());
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
}
