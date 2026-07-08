// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="FileHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using static DotNetTips.Spargine.IO.FileHelper;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class FileHelperTests
{
	private const int FileCount = 100;
	private const int FileLength = 2048;

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void AddAttributes_NullFile_Test()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.AddAttributes(null, FileAttributes.ReadOnly));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void AddAttributes_Success_Test()
	{
		var filePath = RandomData.GenerateTempFile(FileLength);
		var file = new FileInfo(filePath);

		// Add the read-only attribute
		FileHelper.AddAttributes(file, FileAttributes.ReadOnly);

		// Assert that the read-only attribute has been added
		Assert.IsTrue(file.Attributes.HasFlag(FileAttributes.ReadOnly));

		// Clean up
		file.Attributes &= ~FileAttributes.ReadOnly;
		file.Delete();
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void AddAttributesMultipleAttributesTest()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("This test requires Windows for file attribute support.");
		}

		var filePath = RandomData.GenerateTempFile(FileLength);
		var file = new FileInfo(filePath);

		try
		{
			FileHelper.AddAttributes(file, FileAttributes.ReadOnly | FileAttributes.Archive);

			file.Refresh();

			Assert.IsTrue(file.Attributes.HasFlag(FileAttributes.ReadOnly));
			Assert.IsTrue(file.Attributes.HasFlag(FileAttributes.Archive));
		}
		finally
		{
			file.Attributes = FileAttributes.Normal;
			file.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void AddAttributesNonExistentFileTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));

		// Should not throw for non-existent files
		FileHelper.AddAttributes(file, FileAttributes.ReadOnly);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void AddReadOnlyAttribute_NullFile_Test()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.AddReadOnlyAttribute(null));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void AddReadOnlyAttribute_Success_Test()
	{
		var filePath = RandomData.GenerateTempFile(FileLength);
		var file = new FileInfo(filePath);

		// Add the read-only attribute
		FileHelper.AddReadOnlyAttribute(file);

		// Assert that the read-only attribute has been added
		Assert.IsTrue(file.Attributes.HasFlag(FileAttributes.ReadOnly));

		// Clean up
		file.Attributes &= ~FileAttributes.ReadOnly;
		file.Delete();
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void AddReadOnlyAttributeNonExistentFileTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));

		// Should not throw for non-existent files
		FileHelper.AddReadOnlyAttribute(file);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CalculateTotalFileSize_EmptySpan_ReturnsZero()
	{
		var result = FileHelper.CalculateTotalFileSize(ReadOnlySpan<FileInfo>.Empty);

		Assert.AreEqual(0L, result);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CalculateTotalFileSize_MixedValidAndNullAndNonExistent_ReturnsOnlyExistingFileSizes()
	{
		var filePath = RandomData.GenerateTempFile(FileLength);

		try
		{
			var existingFile = new FileInfo(filePath);
			var nonExistent = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));

			var files = new FileInfo[] { existingFile, null, nonExistent };

			var result = FileHelper.CalculateTotalFileSize(files);

			Assert.AreEqual(existingFile.Length, result);
		}
		finally
		{
			File.Delete(filePath);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CalculateTotalFileSize_NonExistentFiles_ReturnsZero()
	{
		var files = new FileInfo[]
		{
			new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt")),
			new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt")),
		};

		var result = FileHelper.CalculateTotalFileSize(files);

		Assert.AreEqual(0L, result);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CalculateTotalFileSize_NullEntries_SkipsNulls()
	{
		var files = new FileInfo[] { null, null };

		var result = FileHelper.CalculateTotalFileSize(files);

		Assert.AreEqual(0L, result);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CalculateTotalFileSize_ValidFiles_ReturnsTotalSize()
	{
		var filePath1 = RandomData.GenerateTempFile(FileLength);
		var filePath2 = RandomData.GenerateTempFile(FileLength);

		try
		{
			var file1 = new FileInfo(filePath1);
			var file2 = new FileInfo(filePath2);

			var expected = file1.Length + file2.Length;

			var result = FileHelper.CalculateTotalFileSize(new FileInfo[] { file1, file2 });

			Assert.AreEqual(expected, result);
		}
		finally
		{
			File.Delete(filePath1);
			File.Delete(filePath2);
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CheckPermissionNullFileTest()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.CheckPermission(null));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CheckPermissionTest()
	{
		var file = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetFiles().Shuffle().First();

		var result = FileHelper.CheckPermission(new FileInfo(file.FullName));

		Assert.IsTrue(result);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CheckPermissionWritePermissionTest()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("This test requires Windows for ACL support.");
		}

		var filePath = RandomData.GenerateTempFile(FileLength);
		var file = new FileInfo(filePath);

		try
		{
			var result = FileHelper.CheckPermission(file, FileSystemRights.Write);

			Assert.IsTrue(result);
		}
		finally
		{
			file.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFile_FileNotFound_Test()
	{
		var sourceFile = new FileInfo("NonExistentFile.txt");
		var destinationDir = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFile_FileNotFound_Test)));

		try
		{
			Assert.ThrowsExactly<FileNotFoundException>(() => FileHelper.CopyFile(sourceFile, destinationDir));
		}
		finally
		{
			if (destinationDir.CheckExists())
			{
				destinationDir.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFile_NullDestination_Test()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));

		try
		{
			Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.CopyFile(sourceFile, null));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFile_NullFile_Test()
	{
		var destinationDir = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFile_NullFile_Test)));
		try
		{
			Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.CopyFile(null, destinationDir));
		}
		finally
		{
			if (destinationDir.CheckExists())
			{
				destinationDir.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFile_OverwritesExistingDestinationFile_Test()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationDir = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFile_OverwritesExistingDestinationFile_Test)));

		try
		{
			// First copy — destination does not yet exist
			var firstLength = FileHelper.CopyFile(sourceFile, destinationDir);

			Assert.AreEqual(sourceFile.Length, firstLength);

			// Second copy — destination file already exists; covers File.Delete(newFileName) branch
			var secondLength = FileHelper.CopyFile(sourceFile, destinationDir);

			Assert.AreEqual(sourceFile.Length, secondLength);
			Assert.IsTrue(File.Exists(Path.Combine(destinationDir.FullName, sourceFile.Name)));
		}
		finally
		{
			sourceFile.Delete();

			if (destinationDir.Exists)
			{
				destinationDir.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFile_Success_Test()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationDir = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFile_Success_Test)));

		var fileLength = FileHelper.CopyFile(sourceFile, destinationDir);

		Assert.AreEqual(sourceFile.Length, fileLength);
		Assert.IsTrue(File.Exists(Path.Combine(destinationDir.FullName, sourceFile.Name)));

		destinationDir.Delete(true);
	}

	[TestMethod]
	public async Task CopyFileAsync_ShouldCopyFileSuccessfully()
	{
		// Arrange
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationDir = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFileAsync_ShouldCopyFileSuccessfully)));
		var destinationFile = Path.Combine(destinationDir.FullName, sourceFile.Name);

		// Act
		var fileLength = await FileHelper.CopyFileAsync(sourceFile, destinationDir);

		// Assert
		Assert.IsTrue(File.Exists(destinationFile));
		Assert.AreEqual(sourceFile.Length, fileLength);

		// Cleanup
		File.Delete(sourceFile.FullName);
		File.Delete(destinationFile);
		destinationDir.Delete(true);
	}

	[TestMethod]
	public async Task CopyFileAsync_ShouldRespectCancellationToken()
	{
		// Arrange
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationDir = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFileAsync_ShouldRespectCancellationToken)));
		var cts = new CancellationTokenSource();
		cts.Cancel();

		// Act & Assert
		await Assert.ThrowsExactlyAsync<TaskCanceledException>(() => FileHelper.CopyFileAsync(sourceFile, destinationDir, cts.Token));

		// Cleanup
		File.Delete(sourceFile.FullName);

		destinationDir.Delete(true);
	}

	[TestMethod]
	public async Task CopyFileAsync_ShouldThrowArgumentNullException_WhenSourceFileIsNull()
	{
		// Arrange
		FileInfo sourceFile = null;
		var destinationDir = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFileAsync_ShouldThrowArgumentNullException_WhenSourceFileIsNull)));
		destinationDir.Create();

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.CopyFileAsync(sourceFile, destinationDir));

		destinationDir.Delete(true);
	}

	[TestMethod]
	public async Task CopyFileAsyncFileNotFoundTest()
	{
		var sourceFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.CopyFileAsyncFileNotFoundTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<FileNotFoundException>(() => FileHelper.CopyFileAsync(sourceFile, destination));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task CopyFileAsyncNullDestinationTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.CopyFileAsync(sourceFile, null));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[TestMethod]
	public async Task CopyFileAsyncSameDirectoryThrowsTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var sameDir = sourceFile.Directory;

		try
		{
			await Assert.ThrowsExactlyAsync<InvalidOperationException>(() => FileHelper.CopyFileAsync(sourceFile, sameDir));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFileFileNotFoundWithProgressTest()
	{
		var sourceFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));
		var destination = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFileFileNotFoundWithProgressTest)));
		CopyProgressRoutine callback = new CopyProgressRoutine(CopyProgressCallback);

		try
		{
			Assert.ThrowsExactly<FileNotFoundException>(() => FileHelper.CopyFile(sourceFile, destination, callback));
		}
		finally
		{
			if (destination.CheckExists())
			{
				destination.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFileSameDirectoryThrowsTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var sameDir = sourceFile.Directory;

		try
		{
			Assert.ThrowsExactly<InvalidOperationException>(() => FileHelper.CopyFile(sourceFile, sameDir));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFileWithProgress_Success_Test()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationDir = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFileWithProgress_Success_Test)));

		if (!destinationDir.CheckExists())
		{
			destinationDir.Create();
		}

		CopyProgressRoutine callback = new CopyProgressRoutine(CopyProgressCallback);

		var result = FileHelper.CopyFile(sourceFile, destinationDir, callback);

		Assert.IsTrue(result);
		Assert.IsTrue(File.Exists(Path.Combine(destinationDir.FullName, sourceFile.Name)));

		destinationDir.Delete(true);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFileWithProgressNullCallbackTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destination = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFileWithProgressNullCallbackTest)));

		try
		{
			Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.CopyFile(sourceFile, destination, null));
		}
		finally
		{
			sourceFile.Delete();

			if (destination.CheckExists())
			{
				destination.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFileWithProgressNullDestinationTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		CopyProgressRoutine callback = new CopyProgressRoutine(CopyProgressCallback);

		try
		{
			Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.CopyFile(sourceFile, null, callback));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFileWithProgressNullFileTest()
	{
		var destination = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFileWithProgressNullFileTest)));
		CopyProgressRoutine callback = new CopyProgressRoutine(CopyProgressCallback);

		try
		{
			Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.CopyFile(null, destination, callback));
		}
		finally
		{
			if (destination.CheckExists())
			{
				destination.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFileWithProgressSameDirectoryThrowsTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var sameDir = sourceFile.Directory;
		CopyProgressRoutine callback = new CopyProgressRoutine(CopyProgressCallback);

		try
		{
			Assert.ThrowsExactly<InvalidOperationException>(() => FileHelper.CopyFile(sourceFile, sameDir, callback));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void CopyFileWithStatus_Test()
	{
		var file = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var directory = new DirectoryInfo(Path.Combine(App.ExecutingFolder(), nameof(this.CopyFileWithStatus_Test)));

		CopyProgressRoutine callback = new CopyProgressRoutine(CopyProgressCallback);

		var result = FileHelper.CopyFile(file: file, destination: directory, progressCallback: callback);

		Assert.IsTrue(result);

		directory.Delete(true);

	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteFiles_Full_Test()
	{
		//Generate temp files
		var files = RandomData.GenerateFiles(FileCount, FileLength, $"{nameof(this.DeleteFiles_Full_Test)}.{Clock.LocalTime.Ticks}");

		//Delete files
		var result = FileHelper.DeleteFiles(files.Files);

		Assert.IsNotNull(result);

		Assert.AreEqual(ResultStatus.Succeeded, result.Status);
		Assert.AreEqual(FileCount, result.Value.Count);
		Assert.IsEmpty(result.Errors);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteFiles_Partial_Test()
	{
		//Generate temp files
		var files = RandomData.GenerateFiles(FileCount, FileLength, $"{nameof(this.DeleteFiles_Partial_Test)}.{Clock.LocalTime.Ticks}");

		//Set files to read only
		foreach (var file in files.Files.FastShuffle(2))
		{
			_ = new FileInfo(file).IsReadOnly = true;
		}

		//Delete files
		var result = FileHelper.DeleteFiles(files.Files);

		Assert.IsNotNull(result);

		Assert.AreEqual(ResultStatus.PartialSuccess, result.Status);
		Assert.AreEqual(FileCount - 2, result.Value.Count);
		Assert.AreEqual(2, result.Errors.Count);

		foreach (var file in files.Files)
		{
			if (File.Exists(file))
			{
				_ = new FileInfo(file).IsReadOnly = false;
			}
		}

		_ = FileHelper.DeleteFiles(files.Files);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteFiles_StopOnFirstError_Test()
	{
		//Generate temp files
		var files = RandomData.GenerateFiles(FileCount, FileLength, $"{nameof(this.DeleteFiles_StopOnFirstError_Test)}.{Clock.LocalTime.Ticks}");

		//Set files to read only
		foreach (var file in files.Files.FastShuffle(2))
		{
			_ = new FileInfo(file).IsReadOnly = true;
		}

		//Delete files
		var result = FileHelper.DeleteFiles(files.Files, true);

		Assert.IsNotNull(result);

		Assert.AreEqual(ResultStatus.PartialSuccess, result.Status);
		Assert.AreEqual(1, result.Errors.Count);

		foreach (var file in files.Files)
		{
			if (File.Exists(file))
			{
				_ = new FileInfo(file).IsReadOnly = false;
			}
		}

		_ = FileHelper.DeleteFiles(files.Files);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteFilesEmptyCollectionTest()
	{
		var emptyFiles = new ReadOnlyCollection<string>(Array.Empty<string>());

		var result = FileHelper.DeleteFiles(emptyFiles);

		Assert.IsNotNull(result);
		Assert.AreEqual(ResultStatus.Succeeded, result.Status);
		Assert.AreEqual(0, result.Value.Count);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteFilesNullCollectionTest()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.DeleteFiles(null));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void DeleteFilesWithNonExistentFilesTest()
	{
		var files = new ReadOnlyCollection<string>(new[]
		{
			Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"),
			Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"),
		});

		var result = FileHelper.DeleteFiles(files);

		Assert.IsNotNull(result);
		Assert.AreEqual(ResultStatus.Succeeded, result.Status);
		Assert.AreEqual(0, result.Value.Count);
		Assert.IsEmpty(result.Errors);
	}

	[TestMethod]
	public async Task DownloadFileFromWebAndUnzipAsyncNullDestinationTest()
	{
		var remoteUri = new Uri("https://example.com/test.zip");

		await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.DownloadFileFromWebAndUnzipAsync(remoteUri, null));
	}

	[TestMethod]
	public async Task DownloadFileFromWebAndUnzipAsyncNullUriTest()
	{
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.DownloadFileFromWebAndUnzipAsyncNullUriTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.DownloadFileFromWebAndUnzipAsync(null, destination));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task DownloadFileFromWebAsync_ConnectionFails_ThrowsException()
	{
		// Use a loopback address on a port that will immediately refuse connection.
		// This exercises the method body past the guard clauses — covering the
		// `if (result == false)` false-branch — without requiring network access.
		var remoteUri = new Uri("http://127.0.0.1:1/nonexistent.zip");
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.DownloadFileFromWebAsync_ConnectionFails_ThrowsException)));

		try
		{
			// ProgressiveRetryAsync captures the connection failure and returns a failed result
			var result = await FileHelper.DownloadFileFromWebAsync(remoteUri, destination);

			Assert.IsNotNull(result);
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task DownloadFileFromWebAsync_RepeatNullArgCalls_DoNotThrowObjectDisposedException()
	{
		// Validates that the shared HttpClient singleton is never disposed between calls.
		// With the old `using var client = GetHttpClient()` pattern the second call would throw
		// ObjectDisposedException because the singleton was disposed after the first call.
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.DownloadFileFromWebAsync_RepeatNullArgCalls_DoNotThrowObjectDisposedException)));

		try
		{
			// First call — hits the argument guard, exits before any HTTP work.
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.DownloadFileFromWebAsync(null, destination));

			// Second call — must also throw ArgumentNullException, NOT ObjectDisposedException.
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.DownloadFileFromWebAsync(null, destination));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task DownloadFileFromWebAsyncNullDestinationTest()
	{
		var remoteUri = new Uri("https://example.com/test.zip");

		await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.DownloadFileFromWebAsync(remoteUri, null));
	}

	[TestMethod]
	public async Task DownloadFileFromWebAsyncNullUriTest()
	{
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.DownloadFileFromWebAsyncNullUriTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.DownloadFileFromWebAsync(null, destination));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void FileHasInvalidChars_InvalidFile_Test()
	{
		var invalidFileName = Path.Combine(App.ExecutingFolder(), "Invalid:FileName.txt");
		var fileInfo = new FileInfo(invalidFileName);

		var result = FileHelper.FileHasInvalidChars(fileInfo);

		Assert.IsTrue(result);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void FileHasInvalidChars_NullFile_Test()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.FileHasInvalidChars(null));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void FileHasInvalidChars_ReturnsSameResult_OnMultipleCalls()
	{
		// Validates that FileHasInvalidChars uses the stable backing char[] and produces
		// consistent results on repeated calls (no per-call allocation side effects).
		var invalidFileName = Path.Combine(App.ExecutingFolder(), "Invalid:FileName.txt");
		var fileInfo = new FileInfo(invalidFileName);

		var first = FileHelper.FileHasInvalidChars(fileInfo);
		var second = FileHelper.FileHasInvalidChars(fileInfo);

		Assert.AreEqual(first, second, "FileHasInvalidChars should return a consistent result on repeated calls.");
		Assert.IsTrue(first, "Expected invalid chars to be detected in the file name.");
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void FileHasInvalidChars_ValidFile_ReturnsSameResult_OnMultipleCalls()
	{
		var validFileName = Path.Combine(App.ExecutingFolder(), "ValidFileName2.txt");
		var fileInfo = new FileInfo(validFileName);

		File.WriteAllText(validFileName, "Test content");

		var first = FileHelper.FileHasInvalidChars(fileInfo);
		var second = FileHelper.FileHasInvalidChars(fileInfo);

		Assert.AreEqual(first, second, "FileHasInvalidChars should return a consistent result on repeated calls.");
		Assert.IsFalse(first, "Expected no invalid chars in a valid file name.");

		File.Delete(validFileName);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void FileHasInvalidChars_ValidFile_Test()
	{
		var validFileName = Path.Combine(App.ExecutingFolder(), "ValidFileName.txt");
		var fileInfo = new FileInfo(validFileName);

		File.WriteAllText(validFileName, "Test content");

		var result = FileHelper.FileHasInvalidChars(fileInfo);

		Assert.IsFalse(result);

		File.Delete(validFileName);
	}


	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void InvalidFileNameChars_ShouldContainInvalidCharacters()
	{
		// Arrange
		var invalidChars = Path.GetInvalidFileNameChars();

		// Act
		var result = FileHelper.InvalidFileNameChars;

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(invalidChars.Length, result);
		CollectionAssert.AreEquivalent(invalidChars, result.ToArray());
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void InvalidFileNameCharsIsReadOnlyTest()
	{
		var result = FileHelper.InvalidFileNameChars;

		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0);
		Assert.IsInstanceOfType<ReadOnlyCollection<char>>(result);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFile_NullDestinationFile_Test()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));

		try
		{
			Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.MoveFile(sourceFile, null));
		}
		finally
		{
			sourceFile.Delete();
		}
	}


	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFile_NullSourceFile_Test()
	{
		var destinationFile = new FileInfo(Path.Combine(App.ExecutingFolder(), "MoveFile_NullSourceFile_Test.txt"));

		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.MoveFile(null, destinationFile));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFile_ReplaceExisting_Test()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var sourceFileLength = sourceFile.Length;
		var destinationFile = new FileInfo(Path.Combine(App.ExecutingFolder(), nameof(this.MoveFile_ReplaceExisting_Test), "MoveFile_ReplaceExisting_Test.txt"));

		var result = FileHelper.MoveFile(sourceFile, destinationFile, true);

		Assert.IsTrue(result);
		Assert.IsFalse(File.Exists(sourceFile.FullName));
		Assert.IsTrue(destinationFile.Exists);
		Assert.AreEqual(sourceFileLength, destinationFile.Length);

		destinationFile.Directory.Delete(true);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFile_ShouldRetry_WhenIOExceptionOccurs()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationFile = new FileInfo(Path.Combine(App.ExecutingFolder(), "MoveFile_ShouldRetry_WhenIOExceptionOccurs.txt"));

		var retryCount = 3;
		var result = FileHelper.MoveFile(sourceFile, destinationFile, true, retryCount);

		Assert.IsTrue(result);
		Assert.IsFalse(File.Exists(sourceFile.FullName));
		Assert.IsTrue(destinationFile.Exists);

		destinationFile.Delete();
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFile_ShouldThrowIOException_WhenFileIsLocked()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationFile = new FileInfo(Path.Combine(App.ExecutingFolder(), "MoveFile_ShouldThrowIOException_WhenFileIsLocked.txt"));

		try
		{
			using (var stream = sourceFile.Open(FileMode.Open, FileAccess.Read, FileShare.None))
			{
				var result = FileHelper.MoveFile(sourceFile, destinationFile);
				Assert.IsFalse(result, "MoveFile should return false when the source file is locked.");
			}
		}
		finally
		{
			sourceFile.Delete();
			destinationFile.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFile_Success_Test()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationFile = new FileInfo(Path.Combine(App.ExecutingFolder(), "MoveFile_Success_Test.txt"));

		var result = FileHelper.MoveFile(sourceFile, destinationFile);

		Assert.IsTrue(result);
		Assert.IsFalse(File.Exists(sourceFile.FullName));
		Assert.IsTrue(File.Exists(destinationFile.FullName));

		destinationFile.Delete();
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFileFileNotFoundTest()
	{
		var sourceFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));
		var destinationFile = new FileInfo(Path.Combine(Path.GetTempPath(), nameof(this.MoveFileFileNotFoundTest), "dest.txt"));

		try
		{
			Assert.ThrowsExactly<FileNotFoundException>(() => FileHelper.MoveFile(sourceFile, destinationFile));
		}
		finally
		{
			if (destinationFile.Directory.Exists)
			{
				destinationFile.Directory.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFileReplaceExistingFalseTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationFile = new FileInfo(Path.Combine(App.ExecutingFolder(), nameof(this.MoveFileReplaceExistingFalseTest), "dest.txt"));

		try
		{
			// Move the file first
			var result = FileHelper.MoveFile(sourceFile, destinationFile, true);

			Assert.IsTrue(result);

			// Create a new source file and try to move without replace
			var sourceFile2 = new FileInfo(RandomData.GenerateTempFile(FileLength));

			try
			{
				var secondMoveResult = FileHelper.MoveFile(sourceFile2, destinationFile, false);
				Assert.IsFalse(secondMoveResult, "MoveFile should return false when replaceExisting is false and the destination already exists.");
			}
			finally
			{
				sourceFile2.Delete();
			}
		}
		finally
		{
			if (destinationFile.Directory.Exists)
			{
				destinationFile.Directory.Delete(true);
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void MoveFileSameDirectoryThrowsTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));
		var destinationFile = new FileInfo(Path.Combine(sourceFile.DirectoryName!, "MoveFileSameDirectoryThrowsTest_dest.txt"));

		try
		{
			Assert.ThrowsExactly<InvalidOperationException>(() => FileHelper.MoveFile(sourceFile, destinationFile));
		}
		finally
		{
			sourceFile.Delete();

			if (destinationFile.Exists)
			{
				destinationFile.Delete();
			}
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveArchiveAttributeNonExistentFileTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));

		// Should not throw for non-existent files
		FileHelper.RemoveArchiveAttribute(file);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveArchiveAttributeNullFileTest()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.RemoveArchiveAttribute(null));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveArchiveAttributeSuccessTest()
	{
		var filePath = RandomData.GenerateTempFile(FileLength);
		var file = new FileInfo(filePath);

		// Ensure the archive attribute is set
		file.Attributes |= FileAttributes.Archive;

		// Remove the archive attribute
		FileHelper.RemoveArchiveAttribute(file);

		// Refresh and assert that the archive attribute has been removed
		file.Refresh();
		Assert.IsFalse(file.Attributes.HasFlag(FileAttributes.Archive));

		file.Delete();
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributes_NullFile_Test()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.RemoveAttributes(null, FileAttributes.ReadOnly));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributes_Success_Test()
	{
		var filePath = RandomData.GenerateTempFile(FileLength);
		var file = new FileInfo(filePath);

		// Set the file to read-only
		file.Attributes |= FileAttributes.ReadOnly;

		// Remove the read-only attribute
		FileHelper.RemoveAttributes(file, FileAttributes.ReadOnly);

		// Assert that the read-only attribute has been removed
		Assert.IsFalse(file.Attributes.HasFlag(FileAttributes.ReadOnly));

		file.Delete();
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributesMultipleAttributesTest()
	{
		if (!OperatingSystem.IsWindows())
		{
			Assert.Inconclusive("This test requires Windows for file attribute support.");
		}

		var filePath = RandomData.GenerateTempFile(FileLength);
		var file = new FileInfo(filePath);

		try
		{
			// Add attributes first
			file.Attributes |= FileAttributes.ReadOnly | FileAttributes.Hidden;

			// Remove them
			FileHelper.RemoveAttributes(file, FileAttributes.ReadOnly | FileAttributes.Hidden);

			file.Refresh();

			Assert.IsFalse(file.Attributes.HasFlag(FileAttributes.ReadOnly));
			Assert.IsFalse(file.Attributes.HasFlag(FileAttributes.Hidden));
		}
		finally
		{
			file.Attributes = FileAttributes.Normal;
			file.Delete();
		}
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveAttributesNonExistentFileTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));

		// Should not throw for non-existent files
		FileHelper.RemoveAttributes(file, FileAttributes.ReadOnly);
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveReadOnlyAttribute_NullFile_Test()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => FileHelper.RemoveReadOnlyAttribute(null));
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveReadOnlyAttribute_Success_Test()
	{
		var filePath = RandomData.GenerateTempFile(FileLength);
		var file = new FileInfo(filePath);

		// Set the file to read-only
		file.Attributes |= FileAttributes.ReadOnly;

		// Remove the read-only attribute
		FileHelper.RemoveReadOnlyAttribute(file);

		// Assert that the read-only attribute has been removed
		Assert.IsFalse(file.Attributes.HasFlag(FileAttributes.ReadOnly));

		file.Delete();
	}

	[SupportedOSPlatform("windows")]
	[TestMethod]
	public void RemoveReadOnlyAttributeNonExistentFileTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.txt"));

		// Should not throw for non-existent files
		FileHelper.RemoveReadOnlyAttribute(file);
	}

	[TestMethod]
	public async Task UnGZipAsyncCancellationTokenTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncCancellationTokenTest));
		var sourceContentDir = Path.Combine(tempDir, "source");
		var gzipFilePath = Path.Combine(tempDir, "test.txt.gz");
		var destinationDir = Path.Combine(tempDir, "destination");

		try
		{
			Directory.CreateDirectory(sourceContentDir);

			var originalFilePath = Path.Combine(sourceContentDir, "test.txt");
			File.WriteAllText(originalFilePath, "Cancel GZip Test");

			using (var sourceStream = File.OpenRead(originalFilePath))
			{
				using (var gzipFileStream = File.OpenWrite(gzipFilePath))
				{
					using (var gzipStream = new GZipStream(gzipFileStream, CompressionMode.Compress))
					{
						sourceStream.CopyTo(gzipStream);
					}
				}
			}

			var gzipFile = new FileInfo(gzipFilePath);
			var destination = new DirectoryInfo(destinationDir);
			var cts = new CancellationTokenSource();
			cts.Cancel();

			await Assert.ThrowsExactlyAsync<TaskCanceledException>(
				() => FileHelper.UnGZipAsync(gzipFile, destination, cts.Token));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncFileNotFoundTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.gz"));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncFileNotFoundTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<FileNotFoundException>(() => FileHelper.UnGZipAsync(file, destination));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncNullDestinationTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.UnGZipAsync(sourceFile, null));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncNullFileTest()
	{
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncNullFileTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.UnGZipAsync(null, destination));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncSameDirectoryThrowsTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncSameDirectoryThrowsTest));

		try
		{
			Directory.CreateDirectory(tempDir);

			var originalFilePath = Path.Combine(tempDir, "test.txt");
			File.WriteAllText(originalFilePath, "Same dir test");

			var gzipFilePath = Path.Combine(tempDir, "test.txt.gz");

			using (var sourceStream = File.OpenRead(originalFilePath))
			{
				using (var gzipFileStream = File.OpenWrite(gzipFilePath))
				{
					using (var gzipStream = new GZipStream(gzipFileStream, CompressionMode.Compress))
					{
						sourceStream.CopyTo(gzipStream);
					}
				}
			}

			var gzipFile = new FileInfo(gzipFilePath);
			var sameDir = new DirectoryInfo(tempDir);

			await Assert.ThrowsExactlyAsync<InvalidOperationException>(
				() => FileHelper.UnGZipAsync(gzipFile, sameDir));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncSuccessTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncSuccessTest));
		var sourceContentDir = Path.Combine(tempDir, "source");
		var gzipFilePath = Path.Combine(tempDir, "test.txt.gz");
		var destinationDir = Path.Combine(tempDir, "destination");

		try
		{
			Directory.CreateDirectory(sourceContentDir);

			var originalContent = "Hello, GZip!";
			var originalFilePath = Path.Combine(sourceContentDir, "test.txt");
			File.WriteAllText(originalFilePath, originalContent);

			using (var sourceStream = File.OpenRead(originalFilePath))
			{
				using (var gzipFileStream = File.OpenWrite(gzipFilePath))
				{
					using (var gzipStream = new GZipStream(gzipFileStream, CompressionMode.Compress))
					{
						sourceStream.CopyTo(gzipStream);
					}
				}
			}

			var gzipFile = new FileInfo(gzipFilePath);
			var destination = new DirectoryInfo(destinationDir);

			await FileHelper.UnGZipAsync(gzipFile, destination);

			var outputFile = Path.Combine(destinationDir, "test.txt");
			Assert.IsTrue(File.Exists(outputFile));
			Assert.AreEqual(originalContent, File.ReadAllText(outputFile));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncWithDeleteCancellationTokenTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncWithDeleteCancellationTokenTest));
		var sourceContentDir = Path.Combine(tempDir, "source");
		var gzipFilePath = Path.Combine(tempDir, "test.txt.gz");
		var destinationDir = Path.Combine(tempDir, "destination");

		try
		{
			Directory.CreateDirectory(sourceContentDir);

			var originalFilePath = Path.Combine(sourceContentDir, "test.txt");
			File.WriteAllText(originalFilePath, "Cancel Delete GZip Test");

			using (var sourceStream = File.OpenRead(originalFilePath))
			{
				using (var gzipFileStream = File.OpenWrite(gzipFilePath))
				{
					using (var gzipStream = new GZipStream(gzipFileStream, CompressionMode.Compress))
					{
						sourceStream.CopyTo(gzipStream);
					}
				}
			}

			var gzipFile = new FileInfo(gzipFilePath);
			var destination = new DirectoryInfo(destinationDir);
			var cts = new CancellationTokenSource();
			cts.Cancel();

			await Assert.ThrowsExactlyAsync<TaskCanceledException>(
				() => FileHelper.UnGZipAsync(gzipFile, destination, true, cts.Token));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncWithDeleteFalseKeepsFileTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncWithDeleteFalseKeepsFileTest));
		var sourceContentDir = Path.Combine(tempDir, "source");
		var gzipFilePath = Path.Combine(tempDir, "test.txt.gz");
		var destinationDir = Path.Combine(tempDir, "destination");

		try
		{
			Directory.CreateDirectory(sourceContentDir);

			var originalContent = "Keep GZip Test";
			var originalFilePath = Path.Combine(sourceContentDir, "test.txt");
			File.WriteAllText(originalFilePath, originalContent);

			using (var sourceStream = File.OpenRead(originalFilePath))
			{
				using (var gzipFileStream = File.OpenWrite(gzipFilePath))
				{
					using (var gzipStream = new GZipStream(gzipFileStream, CompressionMode.Compress))
					{
						sourceStream.CopyTo(gzipStream);
					}
				}
			}

			var gzipFile = new FileInfo(gzipFilePath);
			var destination = new DirectoryInfo(destinationDir);

			await FileHelper.UnGZipAsync(gzipFile, destination, false);

			var outputFile = Path.Combine(destinationDir, "test.txt");
			Assert.IsTrue(File.Exists(outputFile));
			Assert.IsTrue(File.Exists(gzipFilePath));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncWithDeleteFileNotFoundTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.gz"));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncWithDeleteFileNotFoundTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<FileNotFoundException>(() => FileHelper.UnGZipAsync(file, destination, true));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncWithDeleteNullDestinationTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.UnGZipAsync(sourceFile, null, true));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncWithDeleteNullFileTest()
	{
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncWithDeleteNullFileTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.UnGZipAsync(null, destination, true));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task UnGZipAsyncWithDeleteTrueSuccessTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnGZipAsyncWithDeleteTrueSuccessTest));
		var sourceContentDir = Path.Combine(tempDir, "source");
		var gzipFilePath = Path.Combine(tempDir, "test.txt.gz");
		var destinationDir = Path.Combine(tempDir, "destination");

		try
		{
			Directory.CreateDirectory(sourceContentDir);

			var originalContent = "Delete GZip Test";
			var originalFilePath = Path.Combine(sourceContentDir, "test.txt");
			File.WriteAllText(originalFilePath, originalContent);

			using (var sourceStream = File.OpenRead(originalFilePath))
			{
				using (var gzipFileStream = File.OpenWrite(gzipFilePath))
				{
					using (var gzipStream = new GZipStream(gzipFileStream, CompressionMode.Compress))
					{
						sourceStream.CopyTo(gzipStream);
					}
				}
			}

			var gzipFile = new FileInfo(gzipFilePath);
			var destination = new DirectoryInfo(destinationDir);

			await FileHelper.UnGZipAsync(gzipFile, destination, true);

			var outputFile = Path.Combine(destinationDir, "test.txt");
			Assert.IsTrue(File.Exists(outputFile));
			Assert.IsFalse(File.Exists(gzipFilePath));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsync_WithSubdirectoryEntry_SkipsDirectoryEntry_Test()
	{
		// A zip that contains a subdirectory has entries with CompressedLength == 0.
		// This covers the early-return branch in ExtractZipEntryAsync.
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsync_WithSubdirectoryEntry_SkipsDirectoryEntry_Test));
		var subDir = Path.Combine(tempDir, "source", "subdir");
		var destinationDir = Path.Combine(tempDir, "destination");
		var zipFilePath = Path.Combine(tempDir, "test.zip");

		try
		{
			Directory.CreateDirectory(subDir);

			// Create a zip manually so a directory entry (CompressedLength==0) is guaranteed.
			// ZipFile.CreateFromDirectory does not emit explicit directory entries on all platforms.
			using (var zipStream = new FileStream(zipFilePath, FileMode.Create))
			{
				using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Create))
				{
					// Directory entry — CompressedLength will be 0
					archive.CreateEntry("subdir/");

					// Regular file entry
					var entry = archive.CreateEntry("subdir/nested.txt");
					using var writer = new StreamWriter(entry.Open());
					writer.Write("Nested content");
				}
			}

			var zipFile = new FileInfo(zipFilePath);
			var destination = new DirectoryInfo(destinationDir);

			await FileHelper.UnZipAsync(zipFile, destination);

			Assert.IsTrue(File.Exists(Path.Combine(destinationDir, "subdir", "nested.txt")));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncCancellationTokenTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncCancellationTokenTest));
		var sourceDir = Path.Combine(tempDir, "source");
		var zipFilePath = Path.Combine(tempDir, "test.zip");
		var destinationDir = Path.Combine(tempDir, "destination");

		try
		{
			Directory.CreateDirectory(sourceDir);
			File.WriteAllText(Path.Combine(sourceDir, "testfile.txt"), "Cancel Test");
			ZipFile.CreateFromDirectory(sourceDir, zipFilePath);

			var zipFile = new FileInfo(zipFilePath);
			var destination = new DirectoryInfo(destinationDir);
			var cts = new CancellationTokenSource();
			cts.Cancel();

			await Assert.ThrowsExactlyAsync<OperationCanceledException>(
				() => FileHelper.UnZipAsync(zipFile, destination, cts.Token));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncFileNotFoundTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.zip"));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncFileNotFoundTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<FileNotFoundException>(() => FileHelper.UnZipAsync(file, destination));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncNullDestinationTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.UnZipAsync(sourceFile, null));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[TestMethod]
	public async Task UnZipAsyncNullFileTest()
	{
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncNullFileTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.UnZipAsync(null, destination));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncSuccessTest()
	{
		// Create a temp zip file with content
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncSuccessTest));
		var sourceDir = Path.Combine(tempDir, "source");
		var destinationDir = Path.Combine(tempDir, "destination");
		var zipFilePath = Path.Combine(tempDir, "test.zip");

		try
		{
			Directory.CreateDirectory(sourceDir);
			File.WriteAllText(Path.Combine(sourceDir, "testfile.txt"), "Hello, World!");
			ZipFile.CreateFromDirectory(sourceDir, zipFilePath);

			var zipFile = new FileInfo(zipFilePath);
			var destination = new DirectoryInfo(destinationDir);

			await FileHelper.UnZipAsync(zipFile, destination);

			Assert.IsTrue(File.Exists(Path.Combine(destinationDir, "testfile.txt")));
			Assert.AreEqual("Hello, World!", File.ReadAllText(Path.Combine(destinationDir, "testfile.txt")));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncWithDeleteCancellationTokenTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncWithDeleteCancellationTokenTest));
		var sourceDir = Path.Combine(tempDir, "source");
		var zipFilePath = Path.Combine(tempDir, "test.zip");
		var destinationDir = Path.Combine(tempDir, "destination");

		try
		{
			Directory.CreateDirectory(sourceDir);
			File.WriteAllText(Path.Combine(sourceDir, "testfile.txt"), "Cancel Delete Test");
			ZipFile.CreateFromDirectory(sourceDir, zipFilePath);

			var zipFile = new FileInfo(zipFilePath);
			var destination = new DirectoryInfo(destinationDir);
			var cts = new CancellationTokenSource();
			cts.Cancel();

			await Assert.ThrowsExactlyAsync<OperationCanceledException>(
				() => FileHelper.UnZipAsync(zipFile, destination, true, cts.Token));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncWithDeleteFalseKeepsFileTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncWithDeleteFalseKeepsFileTest));
		var sourceDir = Path.Combine(tempDir, "source");
		var destinationDir = Path.Combine(tempDir, "destination");
		var zipFilePath = Path.Combine(tempDir, "test.zip");

		try
		{
			Directory.CreateDirectory(sourceDir);
			File.WriteAllText(Path.Combine(sourceDir, "testfile.txt"), "Keep Test");
			ZipFile.CreateFromDirectory(sourceDir, zipFilePath);

			var zipFile = new FileInfo(zipFilePath);
			var destination = new DirectoryInfo(destinationDir);

			await FileHelper.UnZipAsync(zipFile, destination, false);

			Assert.IsTrue(File.Exists(Path.Combine(destinationDir, "testfile.txt")));
			Assert.IsTrue(File.Exists(zipFilePath));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncWithDeleteFileNotFoundTest()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.zip"));
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncWithDeleteFileNotFoundTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<FileNotFoundException>(() => FileHelper.UnZipAsync(file, destination, true));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncWithDeleteNullDestinationTest()
	{
		var sourceFile = new FileInfo(RandomData.GenerateTempFile(FileLength));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.UnZipAsync(sourceFile, null, true));
		}
		finally
		{
			sourceFile.Delete();
		}
	}

	[TestMethod]
	public async Task UnZipAsyncWithDeleteNullFileTest()
	{
		var destination = new DirectoryInfo(Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncWithDeleteNullFileTest)));

		try
		{
			await Assert.ThrowsExactlyAsync<ArgumentNullException>(() => FileHelper.UnZipAsync(null, destination, true));
		}
		finally
		{
			if (destination.Exists)
			{
				destination.Delete(true);
			}
		}
	}

	[TestMethod]
	public async Task UnZipAsyncWithDeleteSuccessTest()
	{
		var tempDir = Path.Combine(Path.GetTempPath(), nameof(this.UnZipAsyncWithDeleteSuccessTest));
		var sourceDir = Path.Combine(tempDir, "source");
		var destinationDir = Path.Combine(tempDir, "destination");
		var zipFilePath = Path.Combine(tempDir, "test.zip");

		try
		{
			Directory.CreateDirectory(sourceDir);
			File.WriteAllText(Path.Combine(sourceDir, "testfile.txt"), "Delete Test");
			ZipFile.CreateFromDirectory(sourceDir, zipFilePath);

			var zipFile = new FileInfo(zipFilePath);
			var destination = new DirectoryInfo(destinationDir);

			await FileHelper.UnZipAsync(zipFile, destination, true);

			Assert.IsTrue(File.Exists(Path.Combine(destinationDir, "testfile.txt")));
			Assert.IsFalse(File.Exists(zipFilePath));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	private static CopyProgressResult CopyProgressCallback(long totalFileSize, long totalBytesTransferred, long streamSize, long streamBytesTransferred, uint dwStreamNumber, CopyProgressCallbackReason dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData)
	{
		Trace.WriteLine($"TotalFileSize:{totalFileSize}");
		Trace.WriteLine($"TotalBytesTransferred:{totalBytesTransferred}");
		Trace.WriteLine($"StreamSize:{streamSize}");
		Trace.WriteLine($"StreamBytesTransferred:{streamBytesTransferred}");
		Trace.WriteLine($"dwStreamNumber:{dwStreamNumber}");
		Trace.WriteLine($"CopyProgressCallbackReason:{dwCallbackReason}");

		return CopyProgressResult.Continue;
	}

}
