// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-28-2022
//
// Last Modified By : David McCarter
// Last Modified On : 11-13-2025
// ***********************************************************************
// <copyright file="FileHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Devices;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
	public void CheckPermissionTest()
	{
		var file = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetFiles().Shuffle().First();

		var result = FileHelper.CheckPermission(new FileInfo(file.FullName));

		Assert.IsTrue(result);
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
				Assert.ThrowsExactly<IOException>(() => FileHelper.MoveFile(sourceFile, destinationFile));
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
