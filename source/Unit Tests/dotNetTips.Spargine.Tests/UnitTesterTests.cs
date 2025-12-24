// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 11-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 12-18-2025
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
