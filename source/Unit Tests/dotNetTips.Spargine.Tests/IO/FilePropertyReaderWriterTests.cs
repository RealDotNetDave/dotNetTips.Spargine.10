// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 12-17-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2025
// ***********************************************************************
// <copyright file="FilePropertyReaderWriterTests.cs" company="DotNetTips.Spargine.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class FilePropertyReaderWriterTests
{
	private const int FileLength = 1024;

	private FileInfo _testFile;

	/// <summary>
	/// Creates a minimal valid 1x1 pixel PNG file for testing.
	/// </summary>
	private static void CreateMinimalPngFile(string filePath)
	{
		// This is a valid 1x1 transparent PNG file
		byte[] pngBytes = new byte[]
		{
		0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, // PNG signature
		0x00, 0x00, 0x00, 0x0D, 0x49, 0x48, 0x44, 0x52, // IHDR chunk
		0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x01, // Width=1, Height=1
		0x08, 0x06, 0x00, 0x00, 0x00, 0x1F, 0x15, 0xC4,
		0x89, 0x00, 0x00, 0x00, 0x0A, 0x49, 0x44, 0x41, // IDAT chunk
		0x54, 0x78, 0x9C, 0x63, 0x00, 0x01, 0x00, 0x00,
		0x05, 0x00, 0x01, 0x0D, 0x0A, 0x2D, 0xB4, 0x00,
		0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, // IEND chunk
		0x42, 0x60, 0x82
		};

		File.WriteAllBytes(filePath, pngBytes);
	}

	[TestCleanup]
	public void Cleanup()
	{
		// Force immediate cleanup of COM objects before attempting to delete the file
		// This is necessary because .NET 10 uses automatic RCW management
		// and the COM object may not be released until GC runs
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();

		if (this._testFile?.Exists == true)
		{
			// Add a small retry loop in case the file is still locked
			var retryCount = 0;
			const int maxRetries = 5;

			while (retryCount < maxRetries)
			{
				try
				{
					FileHelper.RemoveReadOnlyAttribute(this._testFile);
					this._testFile.Delete();
					break; // Success - exit loop
				}
				catch (IOException) when (retryCount < maxRetries - 1)
				{
					// File still locked, wait and retry
					retryCount++;
					Thread.Sleep(100); // Wait 100ms before retry
					GC.Collect();
					GC.WaitForPendingFinalizers();
				}
			}
		}
	}

	[TestMethod]
	public void GetAuthors_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyReader.GetAuthors(null));
	}

	[TestMethod]
	public void GetComments_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyReader.GetComments(null));
	}

	[TestMethod]
	public void GetString_NullCanonicalPropertyName_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyReader.GetString(this._testFile.FullName, null));
	}

	[TestMethod]
	public void GetString_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyReader.GetString(null, "System.Title"));
	}

	[TestMethod]
	public void GetTags_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyReader.GetTags(null));
	}

	[TestMethod]
	public void GetTitle_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyReader.GetTitle(null));
	}

	[TestInitialize]
	public void Initialize()
	{
		// Use a PNG file - images support extended properties well
		var tempPath = Path.Combine(Path.GetTempPath(), $"TestFile_{Guid.NewGuid()}.png");

		// Create a minimal 1x1 pixel PNG file
		CreateMinimalPngFile(tempPath);

		this._testFile = new FileInfo(tempPath);
	}

	[TestMethod]
	public void SetAndGetAuthors_MultipleAuthors_Success()
	{
		// Arrange
		var authors = new[] { "John Doe", "Jane Smith", "Bob Johnson" };

		// Act
		FilePropertyWriter.SetAuthors(this._testFile.FullName, authors);

		var retrievedAuthors = FilePropertyReader.GetAuthors(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedAuthors);
		Assert.AreEqual(3, retrievedAuthors.Length);
		CollectionAssert.AreEqual(authors, retrievedAuthors);
	}

	[TestMethod]
	public void SetAndGetAuthors_NoAuthors_ReturnsEmptyArray()
	{
		// Act
		var retrievedAuthors = FilePropertyReader.GetAuthors(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedAuthors);
		Assert.AreEqual(0, retrievedAuthors.Length);
	}

	[TestMethod]
	public void SetAndGetAuthors_SingleAuthor_Success()
	{
		// Arrange
		var authors = new[] { "David McCarter" };

		// Act
		FilePropertyWriter.SetAuthors(this._testFile.FullName, authors);
		var retrievedAuthors = FilePropertyReader.GetAuthors(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedAuthors);
		Assert.AreEqual(1, retrievedAuthors.Length);
		Assert.AreEqual("David McCarter", retrievedAuthors[0]);
	}

	[TestMethod]
	public void SetAndGetComments_EmptyComment_Success()
	{
		// Act
		FilePropertyWriter.SetComments(this._testFile.FullName, string.Empty);
		var retrievedComments = FilePropertyReader.GetComments(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedComments);
		Assert.AreEqual(string.Empty, retrievedComments);
	}

	[TestMethod]
	public void SetAndGetComments_LongComment_Success()
	{
		// Arrange
		var comment = RandomData.GenerateWord(500);

		// Act
		FilePropertyWriter.SetComments(this._testFile.FullName, comment);
		var retrievedComment = FilePropertyReader.GetComments(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedComment);
		Assert.AreEqual(comment, retrievedComment);
	}

	[TestMethod]
	public void SetAndGetComments_Success()
	{
		// Arrange
		var comment = "This is a test comment for the file properties.";

		// Act
		FilePropertyWriter.SetComments(this._testFile.FullName, comment);
		var retrievedComment = FilePropertyReader.GetComments(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedComment);
		Assert.AreEqual(comment, retrievedComment);
	}

	[TestMethod]
	public void SetAndGetString_CustomProperty_Success()
	{
		// Arrange
		var subject = "Project Documentation";

		// Act
		FilePropertyWriter.SetString(this._testFile.FullName, "System.Subject", subject);
		var retrievedSubject = FilePropertyReader.GetString(this._testFile.FullName, "System.Subject");

		// Assert
		Assert.IsNotNull(retrievedSubject);
		Assert.AreEqual(subject, retrievedSubject);
	}

	[TestMethod]
	public void SetAndGetTags_MultipleTags_Success()
	{
		// Arrange
		var tags = new[] { "important", "project", "draft", "review" };

		// Act
		FilePropertyWriter.SetTags(this._testFile.FullName, tags);
		var retrievedTags = FilePropertyReader.GetTags(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedTags);
		Assert.AreEqual(4, retrievedTags.Length);
		CollectionAssert.AreEqual(tags, retrievedTags);
	}

	[TestMethod]
	public void SetAndGetTags_NoTags_ReturnsEmptyArray()
	{
		// Act
		var retrievedTags = FilePropertyReader.GetTags(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedTags);
		Assert.AreEqual(0, retrievedTags.Length);
	}

	[TestMethod]
	public void SetAndGetTags_SingleTag_Success()
	{
		// Arrange
		var tags = new[] { "important" };

		// Act
		FilePropertyWriter.SetTags(this._testFile.FullName, tags);
		var retrievedTags = FilePropertyReader.GetTags(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedTags);
		Assert.AreEqual(1, retrievedTags.Length);
		Assert.AreEqual("important", retrievedTags[0]);
	}

	[TestMethod]
	public void SetAndGetTitle_EmptyTitle_Success()
	{
		// Act
		FilePropertyWriter.SetTitle(this._testFile.FullName, string.Empty);
		var retrievedTitle = FilePropertyReader.GetTitle(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedTitle);
		Assert.AreEqual(string.Empty, retrievedTitle);
	}

	[TestMethod]
	public void SetAndGetTitle_Success()
	{
		// Arrange
		var title = "Annual Report 2025";

		// Act
		FilePropertyWriter.SetTitle(this._testFile.FullName, title);
		var retrievedTitle = FilePropertyReader.GetTitle(this._testFile.FullName);

		// Assert
		Assert.IsNotNull(retrievedTitle);
		Assert.AreEqual(title, retrievedTitle);
	}

	[TestMethod]
	public void SetAuthors_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyWriter.SetAuthors(null, "Author Name"));
	}

	[TestMethod]
	public void SetComments_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyWriter.SetComments(null, "Comment"));
	}

	[TestMethod]
	public void SetMultipleProperties_Success()
	{
		// Arrange
		var title = "Test Document";
		var authors = new[] { "Author One", "Author Two" };
		var comments = "Test comments";
		var tags = new[] { "tag1", "tag2" };

		// Act
		FilePropertyWriter.SetTitle(this._testFile.FullName, title);
		FilePropertyWriter.SetAuthors(this._testFile.FullName, authors);
		FilePropertyWriter.SetComments(this._testFile.FullName, comments);
		FilePropertyWriter.SetTags(this._testFile.FullName, tags);

		// Assert
		Assert.AreEqual(title, FilePropertyReader.GetTitle(this._testFile.FullName));
		CollectionAssert.AreEqual(authors, FilePropertyReader.GetAuthors(this._testFile.FullName));
		Assert.AreEqual(comments, FilePropertyReader.GetComments(this._testFile.FullName));
		CollectionAssert.AreEqual(tags, FilePropertyReader.GetTags(this._testFile.FullName));
	}

	[TestMethod]
	public void SetString_NullCanonicalPropertyName_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyWriter.SetString(this._testFile.FullName, null, "Value"));
	}

	[TestMethod]
	public void SetString_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyWriter.SetString(null, "System.Title", "Value"));
	}

	[TestMethod]
	public void SetTags_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyWriter.SetTags(null, "Tag"));
	}

	[TestMethod]
	public void SetTitle_NullFilePath_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			FilePropertyWriter.SetTitle(null, "Title"));
	}

	[TestMethod]
	public void UpdateExistingProperty_Success()
	{
		// Arrange
		var originalTitle = "Original Title";
		var updatedTitle = "Updated Title";

		// Act
		FilePropertyWriter.SetTitle(this._testFile.FullName, originalTitle);
		var firstRead = FilePropertyReader.GetTitle(this._testFile.FullName);

		FilePropertyWriter.SetTitle(this._testFile.FullName, updatedTitle);
		var secondRead = FilePropertyReader.GetTitle(this._testFile.FullName);

		// Assert
		Assert.AreEqual(originalTitle, firstRead);
		Assert.AreEqual(updatedTitle, secondRead);
	}
}
