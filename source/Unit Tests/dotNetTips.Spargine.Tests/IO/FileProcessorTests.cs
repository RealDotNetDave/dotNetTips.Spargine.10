// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-15-2026

// ***********************************************************************
// <copyright file="FileProcessorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class FileProcessorTests
{
	/// <summary>
	/// The directory count
	/// </summary>
	private const int DirectoryCount = 10;
	/// <summary>
	/// The file count
	/// </summary>
	private const int FileCount = 100;

	/// <summary>
	/// Defines the test method CopyFiles_BasicCopy_CopiesSuccessfully.
	/// </summary>
	[TestMethod]
	public void CopyFiles_BasicCopy_CopiesSuccessfully()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(FileCount, fileExtension: "processor.test");
		var files = new List<FileInfo>(generateFiles.Files.Count);

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyBasic"));

		// Act
		var copiedCount = processor.CopyFiles(files, destination);

		// Assert
		Assert.AreEqual(FileCount, copiedCount);
		Assert.IsTrue(destination.Exists);

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void CopyFiles_DuplicateFiles_CopiesDistinctOnly()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			var fi = new FileInfo(file);
			files.Add(fi);
			files.Add(fi); // Add duplicate
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyDuplicate"));

		// Act
		var copiedCount = processor.CopyFiles(files, destination);

		// Assert - should only copy distinct files
		Assert.AreEqual(5, copiedCount);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method CopyFiles_EmptyFilesList_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void CopyFiles_EmptyFilesList_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;
		var files = new List<FileInfo>();
		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyEmpty"));

		// Act
		var copiedCount = processor.CopyFiles(files, destination);

		// Assert
		Assert.AreEqual(0, copiedCount);
	}

	[TestMethod]
	public void CopyFiles_NullEntriesInList_NullsIgnored()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		files.Add(null);
		files.Add(null);

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyNullEntries"));

		// Act
		var copiedCount = processor.CopyFiles(files, destination);

		// Assert
		Assert.AreEqual(3, copiedCount);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method CopyFiles_NullFiles_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void CopyFiles_NullFiles_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;
		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyNull"));

		// Act
		var copiedCount = processor.CopyFiles(null, destination);

		// Assert
		Assert.AreEqual(0, copiedCount);
	}

	/// <summary>
	/// Defines the test method CopyFiles_WithCancellation_StopsOperation.
	/// </summary>
	[TestMethod]
	public void CopyFiles_WithCancellation_StopsOperation()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(50, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyCancelled"));
		var cts = new CancellationTokenSource();

		int processedCount = 0;
		processor.Processed += (sender, e) =>
		{
			processedCount++;
			if (processedCount >= 10)
			{
				cts.Cancel();
			}
		};

		// Act
		var exceptionThrown = false;
		try
		{
			processor.CopyFiles(files, destination, cancellationToken: cts.Token);
			Assert.Fail("Expected OperationCanceledException was not thrown.");
		}
		catch (OperationCanceledException)
		{
			exceptionThrown = true;
		}

		// Assert
		Assert.IsTrue(exceptionThrown);

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	/// <summary>
	/// Defines the test method CopyFiles_WithOverwriteFalse_ReportsErrors.
	/// </summary>
	[TestMethod]
	public void CopyFiles_WithOverwriteFalse_ReportsErrors()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyNoOverwrite"));

		// Copy once
		processor.CopyFiles(files, destination, overwrite: true);

		int errorCount = 0;
		processor.Processed += (sender, e) =>
		{
			if (e.ProgressState == FileProgressState.Error)
			{
				errorCount++;
			}
		};

		// Act - try to copy again without overwrite
		var copiedCount = processor.CopyFiles(files, destination, overwrite: false);

		// Assert
		Assert.AreEqual(0, copiedCount);
		Assert.IsTrue(errorCount > 0);

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void CopyFiles_WithOverwriteTrue_OverwritesExisting()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyOverwriteTrue"));

		// Copy once
		processor.CopyFiles(files, destination, overwrite: true);

		// Act - copy again with overwrite=true
		var copiedCount = processor.CopyFiles(files, destination, overwrite: true);

		// Assert
		Assert.AreEqual(5, copiedCount);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method CopyFilesNonExistentFilesThrowsFileNotFoundException.
	/// </summary>
	[TestMethod]
	public void CopyFilesNonExistentFilesThrowsFileNotFoundException()
	{
		// Arrange
		var processor = new FileProcessor();

		var files = new List<FileInfo>
		{
			new FileInfo(Path.Combine(App.ProcessPath, "nonexistent_copy1.txt")),
			new FileInfo(Path.Combine(App.ProcessPath, "nonexistent_copy2.txt"))
		};

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyNonExistent"));

		// Act & Assert - CopyFiles accesses FileInfo.Length on non-existent files which throws
		Assert.ThrowsExactly<FileNotFoundException>(() => processor.CopyFiles(files, destination));

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	/// <summary>
	/// Defines the test method CopyFilesNullDestinationThrowsArgumentNullException.
	/// </summary>
	[TestMethod]
	public void CopyFilesNullDestinationThrowsArgumentNullException()
	{
		// Arrange
		var processor = new FileProcessor();
		var files = new List<FileInfo> { new FileInfo("test.txt") };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => processor.CopyFiles(files, null));
	}



	/// <summary>
	/// Defines the test method CopyFilesTest.
	/// </summary>
	[TestMethod]
	public void CopyFilesTest()
	{
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(FileCount, fileExtension: "processor.test");
		var path = generateFiles.Path;
		var files = new List<FileInfo>(generateFiles.Files.Count);

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "Copy"));

		Assert.AreEqual(FileCount, processor.CopyFilesWithOriginalPath(files, destination));

		destination.Delete(true);

	}

	[TestMethod]
	public void CopyFilesWithOriginalPath_DuplicateFiles_CopiesDistinctOnly()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			var fi = new FileInfo(file);
			files.Add(fi);
			files.Add(fi); // Add duplicate
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyOriginalDuplicate"));

		// Act
		var copiedCount = processor.CopyFilesWithOriginalPath(files, destination);

		// Assert - should only copy distinct files
		Assert.AreEqual(5, copiedCount);

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void CopyFilesWithOriginalPath_EventArgs_ValidatesProperties()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "EventArgsCopyOriginalTest"));
		var eventArgsList = new List<ProgressEventArgs>();

		processor.Processed += (sender, e) =>
		{
			eventArgsList.Add(e);
		};

		// Act
		processor.CopyFilesWithOriginalPath(files, destination);

		// Assert
		Assert.AreEqual(3, eventArgsList.Count);
		foreach (var args in eventArgsList)
		{
			Assert.AreEqual(FileProgressState.FileCopied, args.ProgressState);
			Assert.IsFalse(string.IsNullOrEmpty(args.Name));
			Assert.IsFalse(string.IsNullOrEmpty(args.Message));
			Assert.IsTrue(args.Size > 0);
			Assert.IsTrue(args.SpeedInMilliseconds >= 0);
		}

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void CopyFilesWithOriginalPath_NullEntriesInList_NullsIgnored()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		files.Add(null);
		files.Add(null);

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyOriginalNullEntries"));

		// Act
		var copiedCount = processor.CopyFilesWithOriginalPath(files, destination);

		// Assert
		Assert.AreEqual(3, copiedCount);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method CopyFilesWithOriginalPath_WithCancellation_StopsOperation.
	/// </summary>
	[TestMethod]
	public void CopyFilesWithOriginalPath_WithCancellation_StopsOperation()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(50, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyOriginalCancelled"));
		var cts = new CancellationTokenSource();

		int processedCount = 0;
		processor.Processed += (sender, e) =>
		{
			processedCount++;
			if (processedCount >= 10)
			{
				cts.Cancel();
			}
		};

		// Act
		var exceptionThrown = false;
		try
		{
			processor.CopyFilesWithOriginalPath(files, destination, cts.Token);
			Assert.Fail("Expected OperationCanceledException was not thrown.");
		}
		catch (OperationCanceledException)
		{
			exceptionThrown = true;
		}

		// Assert
		Assert.IsTrue(exceptionThrown);

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	/// <summary>
	/// Defines the test method CopyFilesWithOriginalPathEmptyFilesReturnsZero.
	/// </summary>
	[TestMethod]
	public void CopyFilesWithOriginalPathEmptyFilesReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		var files = new List<FileInfo>();
		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyOriginalEmpty"));

		// Act
		var copiedCount = processor.CopyFilesWithOriginalPath(files, destination);

		// Assert
		Assert.AreEqual(0, copiedCount);
	}

	/// <summary>
	/// Defines the test method CopyFilesWithOriginalPathNonExistentFilesThrowsFileNotFoundException.
	/// </summary>
	[TestMethod]
	public void CopyFilesWithOriginalPathNonExistentFilesThrowsFileNotFoundException()
	{
		// Arrange
		var processor = new FileProcessor();

		var files = new List<FileInfo>
		{
			new FileInfo(Path.Combine(App.ProcessPath, "nonexistent_copyorig1.txt")),
			new FileInfo(Path.Combine(App.ProcessPath, "nonexistent_copyorig2.txt"))
		};

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyOriginalNonExistent"));

		// Act & Assert - CopyFilesWithOriginalPath accesses FileInfo.Length on non-existent files which throws
		Assert.ThrowsExactly<FileNotFoundException>(() => processor.CopyFilesWithOriginalPath(files, destination));

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	/// <summary>
	/// Defines the test method CopyFilesWithOriginalPathNullDestinationThrowsArgumentNullException.
	/// </summary>
	[TestMethod]
	public void CopyFilesWithOriginalPathNullDestinationThrowsArgumentNullException()
	{
		// Arrange
		var processor = new FileProcessor();
		var files = new List<FileInfo> { new FileInfo("test.txt") };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => processor.CopyFilesWithOriginalPath(files, null));
	}

	/// <summary>
	/// Defines the test method CopyFilesWithOriginalPathNullFilesReturnsZero.
	/// </summary>
	[TestMethod]
	public void CopyFilesWithOriginalPathNullFilesReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "CopyOriginalNull"));

		// Act
		var copiedCount = processor.CopyFilesWithOriginalPath(null, destination);

		// Assert
		Assert.AreEqual(0, copiedCount);
	}

	[TestMethod]
	public void DeleteFiles_DuplicateFiles_DeletesDistinctOnly()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			var fi = new FileInfo(file);
			files.Add(fi);
			files.Add(fi); // Add duplicate
		}

		// Act
		var deletedCount = processor.DeleteFiles(files);

		// Assert - should only delete distinct files
		Assert.AreEqual(5, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFiles_EmptyFilesList_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void DeleteFiles_EmptyFilesList_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;
		var files = new List<FileInfo>();

		// Act
		var deletedCount = processor.DeleteFiles(files);

		// Assert
		Assert.AreEqual(0, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFiles_NonExistentFiles_ReturnsZeroWithErrors.
	/// </summary>
	[TestMethod]
	public void DeleteFiles_NonExistentFiles_ReturnsZeroWithErrors()
	{
		// Arrange
		var processor = new FileProcessor();
		int errorCount = 0;
		processor.Processed += (sender, e) =>
		{
			if (e.ProgressState == FileProgressState.Error)
			{
				errorCount++;
			}
		};

		var files = new List<FileInfo>
	{
		new FileInfo(Path.Combine(App.ProcessPath, "nonexistent1.txt")),
		new FileInfo(Path.Combine(App.ProcessPath, "nonexistent2.txt"))
	};

		// Act
		var deletedCount = processor.DeleteFiles(files);

		// Assert
		Assert.AreEqual(0, deletedCount);
		Assert.AreEqual(files.Count, errorCount);
	}

	[TestMethod]
	public void DeleteFiles_NullEntriesInList_NullsIgnored()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		files.Add(null);
		files.Add(null);

		// Act
		var deletedCount = processor.DeleteFiles(files);

		// Assert
		Assert.AreEqual(3, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFiles_NullFiles_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void DeleteFiles_NullFiles_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		// Act
		var deletedCount = processor.DeleteFiles(null);

		// Assert
		Assert.AreEqual(0, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFiles_WithCancellation_StopsOperation.
	/// </summary>
	[TestMethod]
	public void DeleteFiles_WithCancellation_StopsOperation()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(50, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var cts = new CancellationTokenSource();

		int processedCount = 0;
		processor.Processed += (sender, e) =>
		{
			processedCount++;
			if (processedCount >= 10)
			{
				cts.Cancel();
			}
		};

		// Act
		var exceptionThrown = false;
		try
		{
			_ = processor.DeleteFiles(files, cts.Token);
			Assert.Fail("Expected OperationCanceledException was not thrown.");
		}
		catch (OperationCanceledException)
		{
			exceptionThrown = true;
		}

		// Assert
		Assert.IsTrue(exceptionThrown);
	}

	/// <summary>
	/// Defines the test method DeleteFilesTest.
	/// </summary>
	[TestMethod]
	public void DeleteFilesTest()
	{
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(FileCount, fileExtension: "processor.test");
		var path = generateFiles.Path;
		var files = new List<FileInfo>(generateFiles.Files.Count);

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		foreach (var file in files)
		{
			File.SetAttributes(file.FullName, FileAttributes.ReadOnly);
		}

		Assert.AreEqual(FileCount, processor.DeleteFiles(files));

	}

	[TestMethod]
	public void DeleteFolders_DuplicateFolders_DeletesDistinctOnly()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>();

		for (int index = 0; index < 3; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);
			folders.Add(newPath); // Add duplicate
		}

		// Act
		var deletedCount = processor.DeleteFolders(folders, recursive: true);

		// Assert - should only delete distinct folders
		Assert.AreEqual(3, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFolders_EmptyFoldersList_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_EmptyFoldersList_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>();

		// Act
		var deletedCount = processor.DeleteFolders(folders, true);

		// Assert
		Assert.AreEqual(0, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFolders_FoldersDoNotExist_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_FoldersDoNotExist_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>(DirectoryCount);

		for (int index = 0; index < DirectoryCount; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			folders.Add(newPath);
		}

		// Act
		var deletedCount = processor.DeleteFolders(folders, true);

		// Assert
		Assert.AreEqual(0, deletedCount);
	}

	[TestMethod]
	public void DeleteFolders_NonRecursiveWithFiles_ReportsErrors()
	{
		// Arrange
		var processor = new FileProcessor();
		int errorCount = 0;
		processor.Processed += (sender, e) =>
		{
			if (e.ProgressState == FileProgressState.Error)
			{
				errorCount++;
			}
		};

		var folders = new List<DirectoryInfo>(3);

		for (int index = 0; index < 3; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);

			// Create files in the folder so non-recursive delete will fail
			RandomData.GenerateFiles(newPath.FullName, 5);
		}

		// Act - non-recursive delete of folders with files should fail
		var deletedCount = processor.DeleteFolders(folders, recursive: false);

		// Assert
		Assert.AreEqual(0, deletedCount);
		Assert.AreEqual(3, errorCount);

		// Cleanup
		foreach (var folder in folders)
		{
			if (folder.Exists)
			{
				folder.Delete(true);
			}
		}
	}

	[TestMethod]
	public void DeleteFolders_NullEntriesInList_NullsIgnored()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>();

		for (int index = 0; index < 3; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);
		}

		folders.Add(null);
		folders.Add(null);

		// Act
		var deletedCount = processor.DeleteFolders(folders, recursive: true);

		// Assert
		Assert.AreEqual(3, deletedCount);
	}

	/// <summary>
	/// Defines the test method DeleteFolders_NullFolders_ThrowsArgumentNullException.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_NullFolders_ThrowsArgumentNullException()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		// Act & Assert
		Assert.AreEqual(0, processor.DeleteFolders(null, true));
	}

	/// <summary>
	/// Defines the test method DeleteFolders_ValidFolders_DeletesSuccessfully.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_ValidFolders_DeletesSuccessfully()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>(DirectoryCount);

		for (int index = 0; index < DirectoryCount; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);

			var testFiles = RandomData.GenerateFiles(newPath.FullName, FileCount);

			foreach (var file in testFiles)
			{
				File.SetAttributes(file, FileAttributes.ReadOnly);
			}
		}

		// Act
		var deletedCount = processor.DeleteFolders(folders, true);

		// Assert
		Assert.AreEqual(DirectoryCount, deletedCount);
		foreach (var folder in folders)
		{
			Assert.IsFalse(folder.Exists, $"Folder {folder.FullName} should be deleted.");
		}
	}

	/// <summary>
	/// Defines the test method DeleteFolders_WithCancellation_StopsOperation.
	/// </summary>
	[TestMethod]
	public void DeleteFolders_WithCancellation_StopsOperation()
	{
		// Arrange
		var processor = new FileProcessor();
		var folders = new List<DirectoryInfo>(20);

		for (int index = 0; index < 20; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);
		}

		var cts = new CancellationTokenSource();

		int processedCount = 0;
		processor.Processed += (sender, e) =>
		{
			processedCount++;
			if (processedCount >= 5)
			{
				cts.Cancel();
			}
		};

		// Act
		var exceptionThrown = false;
		try
		{
			processor.DeleteFolders(folders, recursive: true, cts.Token);
			Assert.Fail("Expected OperationCanceledException was not thrown.");
		}
		catch (OperationCanceledException)
		{
			exceptionThrown = true;
		}

		// Assert
		Assert.IsTrue(exceptionThrown);

		// Cleanup remaining folders
		foreach (var folder in folders)
		{
			if (folder.Exists)
			{
				folder.Delete(true);
			}
		}
	}

	/// <summary>
	/// Defines the test method DeleteFoldersNonRecursiveDeletesEmptyFolders.
	/// </summary>
	[TestMethod]
	public void DeleteFoldersNonRecursiveDeletesEmptyFolders()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>(5);

		for (int index = 0; index < 5; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);
		}

		// Act - delete empty folders non-recursively
		var deletedCount = processor.DeleteFolders(folders, recursive: false);

		// Assert
		Assert.AreEqual(5, deletedCount);
		foreach (var folder in folders)
		{
			Assert.IsFalse(folder.Exists, $"Folder {folder.FullName} should be deleted.");
		}
	}

	/// <summary>
	/// Defines the test method DeleteFoldersTest.
	/// </summary>
	[TestMethod]
	public void DeleteFoldersTest()
	{
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var folders = new List<DirectoryInfo>(DirectoryCount);

		for (int index = 0; index < DirectoryCount; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);

			var testFiles = RandomData.GenerateFiles(newPath.FullName, FileCount);

			foreach (var file in testFiles)
			{
				File.SetAttributes(file, FileAttributes.ReadOnly);
			}
		}

		Assert.AreEqual(DirectoryCount, processor.DeleteFolders(folders, true));

	}

	/// <summary>
	/// Defines the test method MoveFiles_BasicMove_MovesSuccessfully.
	/// </summary>
	[TestMethod]
	public void MoveFiles_BasicMove_MovesSuccessfully()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(FileCount, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveBasic"));

		// Act
		var movedCount = processor.MoveFiles(files, destination);

		// Assert
		Assert.AreEqual(FileCount, movedCount);
		Assert.IsTrue(destination.Exists);

		// Verify files no longer exist in source
		foreach (var file in generateFiles.Files)
		{
			Assert.IsFalse(File.Exists(file), $"Source file {file} should not exist after move.");
		}

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void MoveFiles_DuplicateFiles_MovesDistinctOnly()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			var fi = new FileInfo(file);
			files.Add(fi);
			files.Add(fi); // Add duplicate
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveDuplicate"));

		// Act
		var movedCount = processor.MoveFiles(files, destination);

		// Assert - should only move distinct files
		Assert.AreEqual(5, movedCount);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method MoveFiles_EmptyFilesList_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void MoveFiles_EmptyFilesList_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;
		var files = new List<FileInfo>();
		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveEmpty"));

		// Act
		var movedCount = processor.MoveFiles(files, destination);

		// Assert
		Assert.AreEqual(0, movedCount);
	}

	/// <summary>
	/// Defines the test method MoveFiles_NonExistentFiles_ReturnsZeroWithErrors.
	/// </summary>
	[TestMethod]
	public void MoveFiles_NonExistentFiles_ReturnsZeroWithErrors()
	{
		// Arrange
		var processor = new FileProcessor();
		int errorCount = 0;
		processor.Processed += (sender, e) =>
		{
			if (e.ProgressState == FileProgressState.Error)
			{
				errorCount++;
			}
		};

		var files = new List<FileInfo>
	{
		new FileInfo(Path.Combine(App.ProcessPath, "nonexistent1.txt")),
		new FileInfo(Path.Combine(App.ProcessPath, "nonexistent2.txt"))
	};

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveNonExistent"));

		// Act
		var movedCount = processor.MoveFiles(files, destination);

		// Assert
		Assert.AreEqual(0, movedCount);
		Assert.AreEqual(files.Count, errorCount);
	}

	[TestMethod]
	public void MoveFiles_NullEntriesInList_NullsIgnored()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		files.Add(null);
		files.Add(null);

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveNullEntries"));

		// Act
		var movedCount = processor.MoveFiles(files, destination);

		// Assert
		Assert.AreEqual(3, movedCount);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method MoveFiles_NullFiles_ReturnsZero.
	/// </summary>
	[TestMethod]
	public void MoveFiles_NullFiles_ReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;
		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveNull"));

		// Act
		var movedCount = processor.MoveFiles(null, destination);

		// Assert
		Assert.AreEqual(0, movedCount);
	}

	/// <summary>
	/// Defines the test method MoveFiles_WithCancellation_StopsOperation.
	/// </summary>
	[TestMethod]
	public void MoveFiles_WithCancellation_StopsOperation()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(50, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveCancelled"));
		var cts = new CancellationTokenSource();

		int processedCount = 0;
		processor.Processed += (sender, e) =>
		{
			processedCount++;
			if (processedCount >= 10)
			{
				cts.Cancel();
			}
		};

		// Act
		var exceptionThrown = false;
		try
		{
			processor.MoveFiles(files, destination, cancellationToken: cts.Token);
			Assert.Fail("Expected OperationCanceledException was not thrown.");
		}
		catch (OperationCanceledException)
		{
			exceptionThrown = true;
		}

		// Assert
		Assert.IsTrue(exceptionThrown);

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	[TestMethod]
	public void MoveFiles_WithOverwriteFalse_ReportsErrors()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveNoOverwrite"));

		// Copy files to destination first to create existing files
		destination.Create();
		foreach (var file in files)
		{
			File.Copy(file.FullName, Path.Combine(destination.FullName, file.Name));
		}

		int errorCount = 0;
		processor.Processed += (sender, e) =>
		{
			if (e.ProgressState == FileProgressState.Error)
			{
				errorCount++;
			}
		};

		// Act - try to move with overwrite=false (files already exist in destination)
		var movedCount = processor.MoveFiles(files, destination, overwrite: false);

		// Assert
		Assert.AreEqual(0, movedCount);
		Assert.IsTrue(errorCount > 0);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method MoveFiles_WithOverwriteTrue_OverwritesExisting.
	/// </summary>
	[TestMethod]
	public void MoveFiles_WithOverwriteTrue_OverwritesExisting()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles1 = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files1 = new List<FileInfo>();

		foreach (var file in generateFiles1.Files)
		{
			files1.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOverwrite"));

		// Create dummy files in destination with same names
		destination.Create();
		foreach (var file in files1)
		{
			File.WriteAllText(Path.Combine(destination.FullName, file.Name), "dummy content");
		}

		// Act
		var movedCount = processor.MoveFiles(files1, destination, overwrite: true);

		// Assert
		Assert.AreEqual(5, movedCount);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method MoveFilesNullDestinationThrowsArgumentNullException.
	/// </summary>
	[TestMethod]
	public void MoveFilesNullDestinationThrowsArgumentNullException()
	{
		// Arrange
		var processor = new FileProcessor();
		var files = new List<FileInfo> { new FileInfo("test.txt") };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => processor.MoveFiles(files, null));
	}

	/// <summary>
	/// Defines the test method MoveFilesWithOriginalPath_BasicMove_MovesSuccessfully.
	/// </summary>
	[TestMethod]
	public void MoveFilesWithOriginalPath_BasicMove_MovesSuccessfully()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(FileCount, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginal"));

		// Act
		var movedCount = processor.MoveFilesWithOriginalPath(files, destination);

		// Assert
		Assert.AreEqual(FileCount, movedCount);
		Assert.IsTrue(destination.Exists);

		// Verify files no longer exist in source
		foreach (var file in generateFiles.Files)
		{
			Assert.IsFalse(File.Exists(file), $"Source file {file} should not exist after move.");
		}

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void MoveFilesWithOriginalPath_DuplicateFiles_MovesDistinctOnly()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			var fi = new FileInfo(file);
			files.Add(fi);
			files.Add(fi); // Add duplicate
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginalDuplicate"));

		// Act
		var movedCount = processor.MoveFilesWithOriginalPath(files, destination);

		// Assert - should only move distinct files
		Assert.AreEqual(5, movedCount);

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void MoveFilesWithOriginalPath_EventArgs_ValidatesProperties()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "EventArgsMoveOriginalTest"));
		var eventArgsList = new List<ProgressEventArgs>();

		processor.Processed += (sender, e) =>
		{
			eventArgsList.Add(e);
		};

		// Act
		processor.MoveFilesWithOriginalPath(files, destination);

		// Assert
		Assert.AreEqual(3, eventArgsList.Count);
		foreach (var args in eventArgsList)
		{
			Assert.AreEqual(FileProgressState.FileMoved, args.ProgressState);
			Assert.IsFalse(string.IsNullOrEmpty(args.Name));
			Assert.IsFalse(string.IsNullOrEmpty(args.Message));
			Assert.IsTrue(args.Size > 0);
			Assert.IsTrue(args.SpeedInMilliseconds >= 0);
		}

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void MoveFilesWithOriginalPath_NullEntriesInList_NullsIgnored()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		files.Add(null);
		files.Add(null);

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginalNullEntries"));

		// Act
		var movedCount = processor.MoveFilesWithOriginalPath(files, destination);

		// Assert
		Assert.AreEqual(3, movedCount);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method MoveFilesWithOriginalPath_WithCancellation_StopsOperation.
	/// </summary>
	[TestMethod]
	public void MoveFilesWithOriginalPath_WithCancellation_StopsOperation()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(50, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginalCancelled"));
		var cts = new CancellationTokenSource();

		int processedCount = 0;
		processor.Processed += (sender, e) =>
		{
			processedCount++;
			if (processedCount >= 10)
			{
				cts.Cancel();
			}
		};

		// Act
		var exceptionThrown = false;
		try
		{
			processor.MoveFilesWithOriginalPath(files, destination, cancellationToken: cts.Token);
			Assert.Fail("Expected OperationCanceledException was not thrown.");
		}
		catch (OperationCanceledException)
		{
			exceptionThrown = true;
		}

		// Assert
		Assert.IsTrue(exceptionThrown);

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	[TestMethod]
	public void MoveFilesWithOriginalPath_WithOverwriteFalse_ReportsErrors()
	{
		// Arrange
		var processor = new FileProcessor();

		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginalNoOverwrite"));

		// Copy files to destination first to create existing files at the destination paths
		processor.CopyFilesWithOriginalPath(files, destination);

		int errorCount = 0;
		processor.Processed += (sender, e) =>
		{
			if (e.ProgressState == FileProgressState.Error)
			{
				errorCount++;
			}
		};

		// Act - try to move the same files again with overwrite=false
		var movedCount = processor.MoveFilesWithOriginalPath(files, destination, overwrite: false);

		// Assert
		Assert.AreEqual(0, movedCount);
		Assert.AreEqual(3, errorCount);

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	/// <summary>
	/// Defines the test method MoveFilesWithOriginalPathEmptyFilesReturnsZero.
	/// </summary>
	[TestMethod]
	public void MoveFilesWithOriginalPathEmptyFilesReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		var files = new List<FileInfo>();
		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginalEmpty"));

		// Act
		var movedCount = processor.MoveFilesWithOriginalPath(files, destination);

		// Assert
		Assert.AreEqual(0, movedCount);
	}

	/// <summary>
	/// Defines the test method MoveFilesWithOriginalPathNonExistentFilesReportsErrors.
	/// </summary>
	[TestMethod]
	public void MoveFilesWithOriginalPathNonExistentFilesReportsErrors()
	{
		// Arrange
		var processor = new FileProcessor();
		int errorCount = 0;
		processor.Processed += (sender, e) =>
		{
			if (e.ProgressState == FileProgressState.Error)
			{
				errorCount++;
			}
		};

		var files = new List<FileInfo>
		{
			new FileInfo(Path.Combine(App.ProcessPath, "nonexistent_moveorig1.txt")),
			new FileInfo(Path.Combine(App.ProcessPath, "nonexistent_moveorig2.txt"))
		};

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginalNonExistent"));

		// Act
		var movedCount = processor.MoveFilesWithOriginalPath(files, destination);

		// Assert
		Assert.AreEqual(0, movedCount);
		Assert.AreEqual(files.Count, errorCount);

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	/// <summary>
	/// Defines the test method MoveFilesWithOriginalPathNullDestinationThrowsArgumentNullException.
	/// </summary>
	[TestMethod]
	public void MoveFilesWithOriginalPathNullDestinationThrowsArgumentNullException()
	{
		// Arrange
		var processor = new FileProcessor();
		var files = new List<FileInfo> { new FileInfo("test.txt") };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => processor.MoveFilesWithOriginalPath(files, null));
	}

	/// <summary>
	/// Defines the test method MoveFilesWithOriginalPathNullFilesReturnsZero.
	/// </summary>
	[TestMethod]
	public void MoveFilesWithOriginalPathNullFilesReturnsZero()
	{
		// Arrange
		var processor = new FileProcessor();
		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginalNull"));

		// Act
		var movedCount = processor.MoveFilesWithOriginalPath(null, destination);

		// Assert
		Assert.AreEqual(0, movedCount);
	}

	/// <summary>
	/// Defines the test method MoveFilesWithOriginalPathOverwriteExistingMovesSuccessfully.
	/// </summary>
	[TestMethod]
	public void MoveFilesWithOriginalPathOverwriteExistingMovesSuccessfully()
	{
		// Arrange
		var processor = new FileProcessor();
		processor.Processed += this.Processor_Processed;

		var generateFiles = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "MoveOriginalOverwrite"));

		// First move
		var movedCount1 = processor.MoveFilesWithOriginalPath(files, destination, overwrite: true);
		Assert.AreEqual(5, movedCount1);

		// Generate new files with different content to the same source paths
		var generateFiles2 = RandomData.GenerateFiles(5, fileExtension: "processor.test");
		var files2 = new List<FileInfo>();

		foreach (var file in generateFiles2.Files)
		{
			files2.Add(new FileInfo(file));
		}

		// Act - move again with overwrite
		var movedCount2 = processor.MoveFilesWithOriginalPath(files2, destination, overwrite: true);

		// Assert
		Assert.AreEqual(5, movedCount2);

		// Cleanup
		if (destination.Exists)
		{
			destination.Delete(true);
		}
	}

	/// <summary>
	/// Defines the test method ProcessedEvent_FiresForEachFile.
	/// </summary>
	[TestMethod]
	public void ProcessedEvent_FiresForEachFile()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(10, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "EventTest"));
		int eventFireCount = 0;

		processor.Processed += (sender, e) =>
		{
			eventFireCount++;
			Assert.IsNotNull(e.Name);
			Assert.IsTrue(e.Size >= 0);
		};

		// Act
		processor.CopyFiles(files, destination);

		// Assert
		Assert.AreEqual(10, eventFireCount);

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void ProcessedEvent_NoHandlerAttached_DoesNotThrow()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "NoHandlerTest"));

		// Act & Assert - no handler attached, should not throw
		var copiedCount = processor.CopyFiles(files, destination);
		Assert.AreEqual(3, copiedCount);

		// Cleanup
		destination.Delete(true);
	}

	[TestMethod]
	public void ProcessedEvent_SenderIsProcessor()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "SenderTest"));
		object capturedSender = null;

		processor.Processed += (sender, e) =>
		{
			capturedSender = sender;
		};

		// Act
		processor.CopyFiles(files, destination);

		// Assert
		Assert.IsNotNull(capturedSender);
		Assert.AreSame(processor, capturedSender);

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method ProcessedEventArgsCopyFilesValidatesProperties.
	/// </summary>
	[TestMethod]
	public void ProcessedEventArgsCopyFilesValidatesProperties()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "EventArgsCopyTest"));
		var eventArgsList = new List<ProgressEventArgs>();

		processor.Processed += (sender, e) =>
		{
			eventArgsList.Add(e);
		};

		// Act
		processor.CopyFiles(files, destination);

		// Assert
		Assert.AreEqual(3, eventArgsList.Count);
		foreach (var args in eventArgsList)
		{
			Assert.AreEqual(FileProgressState.FileCopied, args.ProgressState);
			Assert.IsFalse(string.IsNullOrEmpty(args.Name));
			Assert.IsFalse(string.IsNullOrEmpty(args.Message));
			Assert.IsTrue(args.Size > 0);
			Assert.IsTrue(args.SpeedInMilliseconds >= 0);
		}

		// Cleanup
		destination.Delete(true);
	}

	/// <summary>
	/// Defines the test method ProcessedEventArgsDeleteFilesValidatesProperties.
	/// </summary>
	[TestMethod]
	public void ProcessedEventArgsDeleteFilesValidatesProperties()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var eventArgsList = new List<ProgressEventArgs>();

		processor.Processed += (sender, e) =>
		{
			eventArgsList.Add(e);
		};

		// Act
		processor.DeleteFiles(files);

		// Assert
		Assert.AreEqual(3, eventArgsList.Count);
		foreach (var args in eventArgsList)
		{
			Assert.AreEqual(FileProgressState.FileDeleted, args.ProgressState);
			Assert.IsFalse(string.IsNullOrEmpty(args.Name));
			Assert.IsFalse(string.IsNullOrEmpty(args.Message));
			Assert.IsTrue(args.Size > 0);
			Assert.IsTrue(args.SpeedInMilliseconds >= 0);
		}
	}

	/// <summary>
	/// Defines the test method ProcessedEventArgsDeleteFoldersValidatesProperties.
	/// </summary>
	[TestMethod]
	public void ProcessedEventArgsDeleteFoldersValidatesProperties()
	{
		// Arrange
		var processor = new FileProcessor();
		var folders = new List<DirectoryInfo>(3);

		for (int index = 0; index < 3; index++)
		{
			var newPath = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), RandomData.GenerateWord(15)));
			newPath.Create();
			folders.Add(newPath);
		}

		var eventArgsList = new List<ProgressEventArgs>();

		processor.Processed += (sender, e) =>
		{
			eventArgsList.Add(e);
		};

		// Act
		processor.DeleteFolders(folders, recursive: true);

		// Assert
		Assert.AreEqual(3, eventArgsList.Count);
		foreach (var args in eventArgsList)
		{
			Assert.AreEqual(FileProgressState.DirectoryDeleted, args.ProgressState);
			Assert.IsFalse(string.IsNullOrEmpty(args.Name));
			Assert.IsFalse(string.IsNullOrEmpty(args.Message));
		}
	}

	/// <summary>
	/// Defines the test method ProcessedEventArgsMoveFilesValidatesProperties.
	/// </summary>
	[TestMethod]
	public void ProcessedEventArgsMoveFilesValidatesProperties()
	{
		// Arrange
		var processor = new FileProcessor();
		var generateFiles = RandomData.GenerateFiles(3, fileExtension: "processor.test");
		var files = new List<FileInfo>();

		foreach (var file in generateFiles.Files)
		{
			files.Add(new FileInfo(file));
		}

		var destination = new DirectoryInfo(Path.Combine(App.ProcessPath, "EventArgsMoveTest"));
		var eventArgsList = new List<ProgressEventArgs>();

		processor.Processed += (sender, e) =>
		{
			eventArgsList.Add(e);
		};

		// Act
		processor.MoveFiles(files, destination);

		// Assert
		Assert.AreEqual(3, eventArgsList.Count);
		foreach (var args in eventArgsList)
		{
			Assert.AreEqual(FileProgressState.FileMoved, args.ProgressState);
			Assert.IsFalse(string.IsNullOrEmpty(args.Name));
			Assert.IsFalse(string.IsNullOrEmpty(args.Message));
			Assert.IsTrue(args.Size > 0);
			Assert.IsTrue(args.SpeedInMilliseconds >= 0);
		}

		// Cleanup
		destination.Delete(true);
	}

#nullable enable
	/// <summary>
	/// Handles the Processed event of the Processor control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
	private void Processor_Processed(object? sender, ProgressEventArgs e) => Trace.WriteLine(e.Name + ":" + e.Message + ":" + e.ProgressState + ":" + e.Size);

	//[TestMethod]
	//public void TEMPDeleteFoldersTest()
	//{
	//	var processor = new FileProcessor();
	//	processor.Processed += this.Processor_Processed;

	//	var folders = new List<DirectoryInfo>(DirectoryCount);

	//	var folder = new DirectoryInfo("C:\\Users\\david\\OneDrive - dotNetTips.com\\Backup\\DESKTOP-TU9NREL\\DAVID\\TURBO\\2025-02-22T15.21.58");

	//	folders.Add(folder);

	//	Assert.IsTrue(processor.DeleteFolders(folders, true) == folders.Count);

	//}

}
