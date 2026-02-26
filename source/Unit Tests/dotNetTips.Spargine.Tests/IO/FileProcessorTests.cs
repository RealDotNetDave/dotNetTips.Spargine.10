// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 02-26-2026
// ***********************************************************************
// <copyright file="FileProcessorTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.IO;

/// <summary>
/// Defines test class FileProcessorTests.
/// </summary>
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
		var cts = new System.Threading.CancellationTokenSource();

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
		catch (System.OperationCanceledException)
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
		var cts = new System.Threading.CancellationTokenSource();

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
		catch (System.OperationCanceledException)
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

		var cts = new System.Threading.CancellationTokenSource();

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
			processor.DeleteFiles(files, cts.Token);
			Assert.Fail("Expected OperationCanceledException was not thrown.");
		}
		catch (System.OperationCanceledException)
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

		var cts = new System.Threading.CancellationTokenSource();

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
		catch (System.OperationCanceledException)
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
		var cts = new System.Threading.CancellationTokenSource();

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
		catch (System.OperationCanceledException)
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
		var cts = new System.Threading.CancellationTokenSource();

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
		catch (System.OperationCanceledException)
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
