// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 11-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-29-2025
// ***********************************************************************
// <copyright file="UnitTesterTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class UnitTesterTests
{

	[TestMethod]
	public void SaveToFile_DefaultOutputDirectory_UsesExecutingFolder()
	{
		// Arrange
		var tester = new TestSaveUnitTester();
		const string content = "Test content";
		const string methodName = "DefaultDirTest";

		// Act
		var expectedFilePath = tester.SaveToFile(content, methodName);

		// Assert
		Assert.IsTrue(File.Exists(expectedFilePath));
		var fileContent = File.ReadAllText(expectedFilePath);
		Assert.AreEqual(content, fileContent);
	}

	[TestMethod]
	public void SaveToFile_EmptyString_DoesNotCreateFile()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestSaveUnitTester(tempDir);
		const string methodName = "TestMethod";

		try
		{
			// Act
			var expectedFilePath = tester.SaveToFile(string.Empty, methodName);

			// Assert
			Assert.IsFalse(File.Exists(expectedFilePath), "File should not be created for empty input");
		}
		finally
		{
			// Cleanup
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public void SaveToFile_LargeContent_WritesSuccessfully()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestSaveUnitTester(tempDir);
		const string methodName = "LargeContentTest";
		var largeContent = new string('A', 10000);

		try
		{
			// Act
			var expectedFilePath = tester.SaveToFile(largeContent, methodName);

			// Assert
			Assert.IsTrue(File.Exists(expectedFilePath));
			var fileContent = File.ReadAllText(expectedFilePath);
			Assert.AreEqual(largeContent, fileContent);
		}
		finally
		{
			// Cleanup
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public void SaveToFile_NullInput_DoesNotCreateFile()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestSaveUnitTester(tempDir);
		const string methodName = "TestMethod";

		try
		{
			// Act
			var expectedFilePath = tester.SaveToFile(null!, methodName);

			// Assert
			Assert.IsFalse(File.Exists(expectedFilePath), "File should not be created for null input");
		}
		finally
		{
			// Cleanup
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}


	[TestMethod]
	public void SaveToFile_SpecialCharacters_WritesCorrectly()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestSaveUnitTester(tempDir);
		const string methodName = "SpecialCharsTest";
		const string content = "Test with special chars: \r\n\t<>&\"'";

		try
		{
			// Act
			var expectedFilePath = tester.SaveToFile(content, methodName);

			// Assert
			var fileContent = File.ReadAllText(expectedFilePath);
			Assert.AreEqual(content, fileContent);
		}
		finally
		{
			// Cleanup
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}
	[TestMethod]
	public void SaveToFile_ValidInput_CreatesFileWithContent()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestSaveUnitTester(tempDir);
		const string content = "Test content for file";
		const string methodName = "TestMethod";

		try
		{
			// Act
			var expectedFilePath = tester.SaveToFile(content, methodName);

			// Assert
			Assert.IsTrue(File.Exists(expectedFilePath), "File should be created");
			var fileContent = File.ReadAllText(expectedFilePath);
			Assert.AreEqual(content, fileContent);
		}
		finally
		{
			// Cleanup
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	[TestMethod]
	public async Task SaveToFileAsync_EmptyCollection_CreatesEmptyFile()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		const string methodName = "AsyncEmptyCollectionTest";
		var collection = Array.Empty<string>();

		try
		{
			// Act
			var expectedFilePath = await tester.SaveToFileAsync(collection, p => true, methodName);

			// Assert
			Assert.IsTrue(File.Exists(expectedFilePath));
			var lines = await File.ReadAllLinesAsync(expectedFilePath);
			Assert.AreEqual(0, lines.Length);
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
	public async Task SaveToFileAsync_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		var tester = new TestAsyncUnitTester();
		const string methodName = "AsyncNullCollectionTest";

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await tester.SaveToFileAsync<PersonData>(null!, p => true, methodName));
	}

	[TestMethod]
	public async Task SaveToFileAsync_NullPropertySelector_ThrowsArgumentNullException()
	{
		// Arrange
		var tester = new TestAsyncUnitTester();
		var collection = RandomData.GeneratePersonRefCollection(100).ToArray();
		const string methodName = "AsyncNullSelectorTest";

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await tester.SaveToFileAsync(collection, null!, methodName));
	}

	[TestMethod]
	public async Task SaveToFileAsync_ValidCollection_CreatesFileWithMultipleLines()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		const string methodName = "AsyncCollectionTest";
		var collection = RandomData.GeneratePersonRefCollection(2).ToArray();

		try
		{
			// Act
			var expectedFilePath = await tester.SaveToFileAsync(collection, p => true, methodName);

			// Assert
			Assert.IsTrue(File.Exists(expectedFilePath));
			var lines = await File.ReadAllLinesAsync(expectedFilePath);
			Assert.AreEqual(2, lines.Length);
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
	public void SaveToFileCollection_NullPropertySelector_ThrowsArgumentNullException()
	{
		// Arrange
		var tester = new TestCollectionUnitTester();
		var collection = RandomData.GeneratePersonRefCollection(100).ToArray();
		const string methodName = "NullSelectorTest";

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			tester.SaveToFile(collection, null!, methodName));
	}

	[TestMethod]
	public void SaveToFileWithDirectory_EmptyInput_ReturnsEmptyString()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string methodName = "EmptyInputTest";

		try
		{
			// Act
			var result = tester.SaveToFile(string.Empty, tempDir, methodName);

			// Assert
			Assert.AreEqual(string.Empty, result, "Should return empty string for empty input");
			var expectedFilePath = Path.Combine(tempDir.FullName, $"{methodName}.txt");
			Assert.IsFalse(File.Exists(expectedFilePath), "File should not be created for empty input");
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_EmptyMethodName_CreatesFileWithRandomName()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string content = "Test content with empty method name";

		try
		{
			// Act
			var savedFilePath = tester.SaveToFile(content, tempDir, string.Empty);

			// Assert
			Assert.IsTrue(File.Exists(savedFilePath), "File should be created with random name");
			Assert.IsTrue(savedFilePath.EndsWith(".txt"), "File should have .txt extension");
			var fileContent = File.ReadAllText(savedFilePath);
			Assert.AreEqual(content, fileContent);
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_LargeContent_WritesSuccessfully()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string methodName = "LargeContentDirTest";
		var largeContent = new string('X', 50000);

		try
		{
			// Act
			var savedFilePath = tester.SaveToFile(largeContent, tempDir, methodName);

			// Assert
			Assert.IsTrue(File.Exists(savedFilePath));
			var fileContent = File.ReadAllText(savedFilePath);
			Assert.AreEqual(largeContent, fileContent);
			Assert.AreEqual(50000, fileContent.Length);
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_MultipleCalls_CreatesMultipleFiles()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();

		try
		{
			// Act
			var file1 = tester.SaveToFile("Content 1", tempDir, "Method1");
			var file2 = tester.SaveToFile("Content 2", tempDir, "Method2");
			var file3 = tester.SaveToFile("Content 3", tempDir, "Method3");

			// Assert
			Assert.IsTrue(File.Exists(file1));
			Assert.IsTrue(File.Exists(file2));
			Assert.IsTrue(File.Exists(file3));
			Assert.AreEqual("Content 1", File.ReadAllText(file1));
			Assert.AreEqual("Content 2", File.ReadAllText(file2));
			Assert.AreEqual("Content 3", File.ReadAllText(file3));
			Assert.AreEqual(3, tempDir.GetFiles("*.txt").Length);
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_NestedSubdirectory_CreatesFileCorrectly()
	{
		// Arrange
		var baseDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		baseDir.Create();
		var nestedDir = baseDir.CreateSubdirectory("Level1").CreateSubdirectory("Level2");
		var tester = new TestDirectoryUnitTester();
		const string content = "Nested directory content";
		const string methodName = "NestedDirTest";

		try
		{
			// Act
			var savedFilePath = tester.SaveToFile(content, nestedDir, methodName);

			// Assert
			Assert.IsTrue(File.Exists(savedFilePath));
			Assert.IsTrue(savedFilePath.Contains("Level1"));
			Assert.IsTrue(savedFilePath.Contains("Level2"));
			var fileContent = File.ReadAllText(savedFilePath);
			Assert.AreEqual(content, fileContent);
		}
		finally
		{
			if (baseDir.Exists)
			{
				baseDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_NonExistentDirectory_ThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		var tester = new TestDirectoryUnitTester();
		const string content = "Test content";
		const string methodName = "NonExistentDirTest";

		// Act & Assert
		Assert.ThrowsExactly<DirectoryNotFoundException>(() =>
			tester.SaveToFile(content, nonExistentDir, methodName));
	}

	[TestMethod]
	public void SaveToFileWithDirectory_NullDirectory_ThrowsArgumentNullException()
	{
		// Arrange
		var tester = new TestDirectoryUnitTester();
		const string content = "Test content";
		const string methodName = "NullDirTest";
		DirectoryInfo nullDir = null;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			tester.SaveToFile(content, nullDir, methodName));
	}

	[TestMethod]
	public void SaveToFileWithDirectory_NullInput_ReturnsEmptyString()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string methodName = "NullInputTest";

		try
		{
			// Act
			var result = tester.SaveToFile(null!, tempDir, methodName);

			// Assert
			Assert.AreEqual(string.Empty, result, "Should return empty string for null input");
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_OverwriteExistingFile_UpdatesContent()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string methodName = "OverwriteTest";
		const string originalContent = "Original content";
		const string newContent = "Updated content";

		try
		{
			// Act
			var file1 = tester.SaveToFile(originalContent, tempDir, methodName);
			var file2 = tester.SaveToFile(newContent, tempDir, methodName);

			// Assert
			Assert.AreEqual(file1, file2, "File paths should be the same");
			Assert.IsTrue(File.Exists(file2));
			var fileContent = File.ReadAllText(file2);
			Assert.AreEqual(newContent, fileContent, "Content should be overwritten");
			Assert.AreNotEqual(originalContent, fileContent);
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_ReturnsCorrectFilePath()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string content = "Test content";
		const string methodName = "PathVerificationTest";

		try
		{
			// Act
			var savedFilePath = tester.SaveToFile(content, tempDir, methodName);
			var expectedPath = Path.Combine(tempDir.FullName, $"{methodName}.txt");

			// Assert
			Assert.AreEqual(expectedPath, savedFilePath, "Returned path should match expected path");
			Assert.IsTrue(Path.IsPathFullyQualified(savedFilePath), "Path should be fully qualified");
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_SpecialCharactersInContent_WritesCorrectly()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string methodName = "SpecialCharsDirTest";
		const string content = "Special chars: \r\n\t<>&\"'@#$%^&*()";

		try
		{
			// Act
			var savedFilePath = tester.SaveToFile(content, tempDir, methodName);

			// Assert
			Assert.IsTrue(File.Exists(savedFilePath));
			var fileContent = File.ReadAllText(savedFilePath);
			Assert.AreEqual(content, fileContent);
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	[TestMethod]
	public void SaveToFileWithDirectory_UnicodeContent_WritesCorrectly()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string methodName = "UnicodeDirTest";
		const string content = "Unicode: 你好 مرحبا Привет 🚀🎉";

		try
		{
			// Act
			var savedFilePath = tester.SaveToFile(content, tempDir, methodName);

			// Assert
			Assert.IsTrue(File.Exists(savedFilePath));
			var fileContent = File.ReadAllText(savedFilePath);
			Assert.AreEqual(content, fileContent);
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}
	[TestMethod]
	public void SaveToFileWithDirectory_ValidInput_CreatesFileWithCorrectContent()
	{
		// Arrange
		var tempDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		tempDir.Create();
		var tester = new TestDirectoryUnitTester();
		const string content = "Test content for directory save";
		const string methodName = "ValidDirectoryTest";

		try
		{
			// Act
			var savedFilePath = tester.SaveToFile(content, tempDir, methodName);

			// Assert
			Assert.IsTrue(File.Exists(savedFilePath), "File should be created in specified directory");
			Assert.IsTrue(savedFilePath.Contains(tempDir.FullName), "File path should contain directory path");
			Assert.IsTrue(savedFilePath.EndsWith($"{methodName}.txt"), "File should have method name");
			var fileContent = File.ReadAllText(savedFilePath);
			Assert.AreEqual(content, fileContent);
		}
		finally
		{
			if (tempDir.Exists)
			{
				tempDir.Delete(true);
			}
		}
	}

	private class TestDirectoryUnitTester : UnitTester
	{
		public TestDirectoryUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}

	private class TestAsyncUnitTester : UnitTester
	{
		public TestAsyncUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}

	private class TestCollectionUnitTester : UnitTester
	{
		public TestCollectionUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}

	private class TestSaveUnitTester : UnitTester
	{
		public TestSaveUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}
}
