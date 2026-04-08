// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 08-04-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="TempFileManagerTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class TempFileManagerTests
{
	[TestMethod]
	public void CreateFile_ShouldAddFileToList()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act
			var filePath = manager.CreateFile();

			// Assert
			Assert.IsTrue(File.Exists(filePath));
			Assert.Contains(filePath, manager.GetManagedFiles());
		}
	}

	[TestMethod]
	public void CreateFiles_ShouldAddMultipleFilesToList()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			int fileCount = 50;

			// Act
			var files = manager.CreateFiles(fileCount);

			// Assert
			Assert.HasCount(fileCount, files);
			foreach (var file in files)
			{
				Assert.IsTrue(File.Exists(file));
				Assert.Contains(file, manager.GetManagedFiles());
			}
		}
	}

	[TestMethod]
	public void DeleteAllFiles_ShouldRemoveAllFilesFromList()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			manager.CreateFiles(50);

			// Act
			manager.DeleteAllFiles();

			// Assert
			Assert.IsEmpty(manager.GetManagedFiles());
		}
	}

	[TestMethod]
	public void DeleteFile_ShouldNotRemoveNonExistentFile()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			var filePath = manager.CreateFile();
			var nonExistentFilePath = filePath + "_nonexistent";

			// Act
			manager.DeleteFile(nonExistentFilePath);

			// Assert
			Assert.IsTrue(File.Exists(filePath));
			Assert.Contains(filePath, manager.GetManagedFiles());
		}
	}

	[TestMethod]
	public void DeleteFile_ShouldNotThrow_WhenFileNameIsNullOrEmpty()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act & Assert
			manager.DeleteFile(null);
			manager.DeleteFile(string.Empty);
		}
	}

	[TestMethod]
	public void DeleteFile_ShouldRemoveFileFromList()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			var filePath = manager.CreateFile();

			// Act
			manager.DeleteFile(filePath);

			// Assert
			Assert.IsFalse(File.Exists(filePath));
			Assert.DoesNotContain(filePath, manager.GetManagedFiles());
		}
	}

	[TestMethod]
	public void Dispose_ShouldReleaseResources()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			manager.CreateFiles(50);

			// Act
			manager.Dispose();

			// Assert
			Assert.IsEmpty(manager.GetManagedFiles());
		}
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldDeleteAllFiles()
	{
		// Arrange
		var manager = new TempFileManager();
		var files = manager.CreateFiles(50);

		// Act
		await (manager as IAsyncDisposable).DisposeAsync();

		// Assert
		foreach (var file in files)
		{
			Assert.IsFalse(File.Exists(file), $"File {file} should be deleted.");
		}
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldHandleEmptyFileList()
	{
		// Arrange
		var manager = new TempFileManager();

		// Act
		await (manager as IAsyncDisposable).DisposeAsync();

		// Assert
		Assert.IsEmpty(manager.GetManagedFiles());
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldNotThrowException_WhenCalledMultipleTimes()
	{
		// Arrange
		var manager = new TempFileManager();
		manager.CreateFiles(50);

		// Act & Assert
		await (manager as IAsyncDisposable).DisposeAsync();
		await (manager as IAsyncDisposable).DisposeAsync();
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldReleaseResources()
	{
		// Arrange
		var manager = new TempFileManager();
		manager.CreateFiles(50);

		// Act
		await (manager as IAsyncDisposable).DisposeAsync();

		// Assert
		Assert.IsEmpty(manager.GetManagedFiles());
	}

	[TestMethod]
	public async Task DisposeAsync_ShouldSuppressFinalize()
	{
		// Arrange
		var manager = new TempFileManager();
		var finalizeCalled = false;

		// Act
		await (manager as IAsyncDisposable).DisposeAsync();

		// Assert
		GC.ReRegisterForFinalize(manager);
		GC.Collect();
		GC.WaitForPendingFinalizers();

		Assert.IsFalse(finalizeCalled, "Finalize should not be called after DisposeAsync.");
	}

	[TestMethod]
	public void GetManagedFiles_ShouldReturnListOfManagedFiles()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			var files = manager.CreateFiles(50);

			// Act
			var managedFiles = manager.GetManagedFiles();

			// Assert
			CollectionAssert.AreEquivalent(files.ToList(), managedFiles.ToList());
		}
	}

	[TestMethod]
	public void CreateFilesShouldUseNonParallelPathForSmallCount()
	{
		// Arrange & Act
		using (var manager = new TempFileManager())
		{
			var filesOne = manager.CreateFiles(1);
			var filesTwo = manager.CreateFiles(2);

			// Assert
			Assert.HasCount(1, filesOne);
			Assert.HasCount(2, filesTwo);

			foreach (var file in filesOne)
			{
				Assert.IsTrue(File.Exists(file));
				Assert.Contains(file, manager.GetManagedFiles());
			}

			foreach (var file in filesTwo)
			{
				Assert.IsTrue(File.Exists(file));
				Assert.Contains(file, manager.GetManagedFiles());
			}
		}
	}

	[TestMethod]
	public void CreateFilesWithZeroCountShouldThrowArgumentOutOfRangeException()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act & Assert
			Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => manager.CreateFiles(0));
		}
	}

	[TestMethod]
	public void CreateFilesWithNegativeCountShouldThrowArgumentOutOfRangeException()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act & Assert
			Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => manager.CreateFiles(-1));
		}
	}

	[TestMethod]
	public void CreateFileShouldCreateFileWithDnttExtension()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act
			var filePath = manager.CreateFile();

			// Assert
			Assert.AreEqual(".dntt", Path.GetExtension(filePath));
		}
	}

	[TestMethod]
	public void CreateFileShouldCreateFileInTempDirectory()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act
			var filePath = manager.CreateFile();

			// Assert
			Assert.AreEqual(Path.GetTempPath(), Path.GetDirectoryName(filePath) + Path.DirectorySeparatorChar);
		}
	}

	[TestMethod]
	public void DeleteAllFilesShouldDeleteFilesFromDisk()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			var files = manager.CreateFiles(5);

			// Act
			manager.DeleteAllFiles();

			// Assert
			foreach (var file in files)
			{
				Assert.IsFalse(File.Exists(file), $"File {file} should have been deleted from disk.");
			}
		}
	}

	[TestMethod]
	public void DeleteAllFilesWithNoFilesShouldNotThrow()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act & Assert - should not throw
			manager.DeleteAllFiles();
			Assert.IsEmpty(manager.GetManagedFiles());
		}
	}

	[TestMethod]
	public void DisposeCalledMultipleTimesShouldNotThrow()
	{
		// Arrange
		var manager = new TempFileManager();
		manager.CreateFiles(5);

		// Act & Assert - should not throw
		manager.Dispose();
		manager.Dispose();
	}

	[TestMethod]
	public void DisposeShouldDeleteFilesFromDisk()
	{
		// Arrange
		var manager = new TempFileManager();
		var files = manager.CreateFiles(5);

		// Act
		manager.Dispose();

		// Assert
		foreach (var file in files)
		{
			Assert.IsFalse(File.Exists(file), $"File {file} should have been deleted from disk.");
		}
	}

	[TestMethod]
	public void GetManagedFilesWithNoFilesShouldReturnEmptyCollection()
	{
		// Arrange
		using (var manager = new TempFileManager())
		{
			// Act
			var managedFiles = manager.GetManagedFiles();

			// Assert
			Assert.IsEmpty(managedFiles);
		}
	}

}
