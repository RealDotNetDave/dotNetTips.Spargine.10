// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 11-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 11-25-2025
// ***********************************************************************
// <copyright file="UnitTesterTests.cs" company="DotNetTips.Spargine.Tests">
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

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

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
		var expectedFilePath = Path.Combine(tester.OutputDirectory, $"{methodName}.txt");

		try
		{
			// Act
			tester.SaveToFile(content, methodName);

			// Assert
			Assert.IsTrue(File.Exists(expectedFilePath));
			var fileContent = File.ReadAllText(expectedFilePath);
			Assert.AreEqual(content, fileContent);
		}
		finally
		{
			// Cleanup
			if (File.Exists(expectedFilePath))
			{
				File.Delete(expectedFilePath);
			}
		}
	}

	[TestMethod]
	public void SaveToFile_EmptyMethodName_CreatesFileWithRandomName()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestSaveUnitTester(tempDir);
		const string content = "Test content";

		try
		{
			// Act
			tester.SaveToFile(content, string.Empty);

			// Assert
			var files = Directory.GetFiles(tempDir, "*.txt");
			Assert.IsTrue(files.Length == 1, "One file should be created");
			var fileContent = File.ReadAllText(files[0]);
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
			tester.SaveToFile(string.Empty, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
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
			tester.SaveToFile(largeContent, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
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
			tester.SaveToFile(null!, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
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
	public void SaveToFile_OverwritesExistingFile()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestSaveUnitTester(tempDir);
		const string methodName = "TestMethod";
		const string initialContent = "Initial content";
		const string updatedContent = "Updated content";

		try
		{
			// Act
			tester.SaveToFile(initialContent, methodName);
			tester.SaveToFile(updatedContent, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			var fileContent = File.ReadAllText(expectedFilePath);
			Assert.AreEqual(updatedContent, fileContent, "File should be overwritten with new content");
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
			tester.SaveToFile(content, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
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
			tester.SaveToFile(content, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
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
	public async Task SaveToFileAsync_ConcurrentCalls_AllFilesCreated()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		var collections = Enumerable.Range(1, 10)
			.Select(i => new[] { new TestPerson { Id = i, Name = $"Person{i}" } })
			.ToArray();

		try
		{
			// Act
			var tasks = collections.Select((collection, index) =>
				tester.SaveToFileAsync(collection, p => true, $"ConcurrentTest{index}"));
			await Task.WhenAll(tasks);

			// Assert
			var files = Directory.GetFiles(tempDir, "ConcurrentTest*.txt");
			Assert.AreEqual(10, files.Length);
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
	public async Task SaveToFileAsync_EmptyCollection_CreatesEmptyFile()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		const string methodName = "AsyncEmptyCollectionTest";
		var collection = Array.Empty<TestPerson>();

		try
		{
			// Act
			await tester.SaveToFileAsync(collection, p => true, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
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
	public async Task SaveToFileAsync_EmptyMethodName_ThrowsArgumentException()
	{
		// Arrange
		var tester = new TestAsyncUnitTester();
		var collection = new[] { new TestPerson { Id = 1, Name = "Test" } };

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentException>(async () =>
			await tester.SaveToFileAsync(collection, p => true, string.Empty));
	}

	[TestMethod]
	public async Task SaveToFileAsync_LargeCollection_WritesAllItems()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		const string methodName = "AsyncLargeCollectionTest";
		const int itemCount = 1000;
		var collection = Enumerable.Range(1, itemCount)
			.Select(i => new TestPerson { Id = i, Name = $"Person{i}" })
			.ToArray();

		try
		{
			// Act
			await tester.SaveToFileAsync(collection, p => p.Name == "Id", methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			var lines = await File.ReadAllLinesAsync(expectedFilePath);
			Assert.AreEqual(itemCount, lines.Length);
			Assert.AreEqual("Id: 1", lines[0]);
			Assert.AreEqual($"Id: {itemCount}", lines[itemCount - 1]);
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
			await tester.SaveToFileAsync<TestPerson>(null!, p => true, methodName));
	}

	[TestMethod]
	public async Task SaveToFileAsync_NullMethodName_ThrowsArgumentException()
	{
		// Arrange
		var tester = new TestAsyncUnitTester();
		var collection = new[] { new TestPerson { Id = 1, Name = "Test" } };

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentException>(async () =>
			await tester.SaveToFileAsync(collection, p => true, null!));
	}

	[TestMethod]
	public async Task SaveToFileAsync_NullPropertySelector_ThrowsArgumentNullException()
	{
		// Arrange
		var tester = new TestAsyncUnitTester();
		var collection = new[] { new TestPerson { Id = 1, Name = "Test" } };
		const string methodName = "AsyncNullSelectorTest";

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await tester.SaveToFileAsync(collection, null!, methodName));
	}

	[TestMethod]
	public async Task SaveToFileAsync_OverwritesExistingFile()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		const string methodName = "AsyncOverwriteTest";
		var initialCollection = new[] { new TestPerson { Id = 1, Name = "Initial" } };
		var updatedCollection = new[] { new TestPerson { Id = 2, Name = "Updated" } };

		try
		{
			// Act
			await tester.SaveToFileAsync(initialCollection, p => true, methodName);
			await tester.SaveToFileAsync(updatedCollection, p => true, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			var lines = await File.ReadAllLinesAsync(expectedFilePath);
			Assert.AreEqual(1, lines.Length);
			Assert.IsTrue(lines[0].Contains("Id: 2"));
			Assert.IsTrue(lines[0].Contains("Name: Updated"));
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
	public async Task SaveToFileAsync_PropertiesWithNullValues_HandlesGracefully()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		const string methodName = "AsyncNullPropertyTest";
		var collection = new[] { new TestPerson { Id = 1, Name = null } };

		try
		{
			// Act
			await tester.SaveToFileAsync(collection, p => true, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			Assert.IsTrue(File.Exists(expectedFilePath));
			var lines = await File.ReadAllLinesAsync(expectedFilePath);
			Assert.AreEqual(1, lines.Length);
			Assert.IsTrue(lines[0].Contains("Id: 1"));
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
	public async Task SaveToFileAsync_SelectiveProperties_SavesOnlySelectedProperties()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		const string methodName = "AsyncSelectivePropsTest";
		var collection = new[]
		{
			new TestPerson { Id = 1, Name = "Alice" },
			new TestPerson { Id = 2, Name = "Bob" }
		};

		try
		{
			// Act - Only save Name property
			await tester.SaveToFileAsync(collection, p => p.Name == "Name", methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			var lines = await File.ReadAllLinesAsync(expectedFilePath);
			Assert.AreEqual(2, lines.Length);
			Assert.AreEqual("Name: Alice", lines[0]);
			Assert.AreEqual("Name: Bob", lines[1]);
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
	public async Task SaveToFileAsync_ValidCollection_CreatesFileWithMultipleLines()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestAsyncUnitTester(tempDir);
		const string methodName = "AsyncCollectionTest";
		var collection = new[]
		{
			new TestPerson { Id = 1, Name = "Alice" },
			new TestPerson { Id = 2, Name = "Bob" }
		};

		try
		{
			// Act
			await tester.SaveToFileAsync(collection, p => true, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			Assert.IsTrue(File.Exists(expectedFilePath));
			var lines = await File.ReadAllLinesAsync(expectedFilePath);
			Assert.AreEqual(2, lines.Length);
			Assert.IsTrue(lines[0].Contains("Id: 1"));
			Assert.IsTrue(lines[0].Contains("Name: Alice"));
			Assert.IsTrue(lines[1].Contains("Id: 2"));
			Assert.IsTrue(lines[1].Contains("Name: Bob"));
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
	public void SaveToFileCollection_EmptyCollection_CreatesEmptyFile()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestCollectionUnitTester(tempDir);
		const string methodName = "EmptyCollectionTest";
		var collection = Array.Empty<TestPerson>();

		try
		{
			// Act
			tester.SaveToFile(collection, p => true, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			Assert.IsTrue(File.Exists(expectedFilePath));
			var lines = File.ReadAllLines(expectedFilePath);
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
	public void SaveToFileCollection_EmptyMethodName_ThrowsArgumentException()
	{
		// Arrange
		var tester = new TestCollectionUnitTester();
		var collection = new[] { new TestPerson { Id = 1, Name = "Test" } };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() =>
			tester.SaveToFile(collection, p => true, string.Empty));
	}

	[TestMethod]
	public void SaveToFileCollection_LargeCollection_WritesAllItems()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestCollectionUnitTester(tempDir);
		const string methodName = "LargeCollectionTest";
		const int itemCount = 1000;
		var collection = Enumerable.Range(1, itemCount)
			.Select(i => new TestPerson { Id = i, Name = $"Person{i}" })
			.ToArray();

		try
		{
			// Act
			tester.SaveToFile(collection, p => p.Name == "Id", methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			var lines = File.ReadAllLines(expectedFilePath);
			Assert.AreEqual(itemCount, lines.Length);
			Assert.AreEqual("Id: 1", lines[0]);
			Assert.AreEqual($"Id: {itemCount}", lines[itemCount - 1]);
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
	public void SaveToFileCollection_NullMethodName_ThrowsArgumentException()
	{
		// Arrange
		var tester = new TestCollectionUnitTester();
		var collection = new[] { new TestPerson { Id = 1, Name = "Test" } };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentException>(() =>
			tester.SaveToFile(collection, p => true, null!));
	}


	[TestMethod]
	public void SaveToFileCollection_NullPropertySelector_ThrowsArgumentNullException()
	{
		// Arrange
		var tester = new TestCollectionUnitTester();
		var collection = new[] { new TestPerson { Id = 1, Name = "Test" } };
		const string methodName = "NullSelectorTest";

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			tester.SaveToFile(collection, null!, methodName));
	}

	[TestMethod]
	public void SaveToFileCollection_OverwritesExistingFile()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestCollectionUnitTester(tempDir);
		const string methodName = "OverwriteTest";
		var initialCollection = new[] { new TestPerson { Id = 1, Name = "Initial" } };
		var updatedCollection = new[] { new TestPerson { Id = 2, Name = "Updated" } };

		try
		{
			// Act
			tester.SaveToFile(initialCollection, p => true, methodName);
			tester.SaveToFile(updatedCollection, p => true, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			var lines = File.ReadAllLines(expectedFilePath);
			Assert.AreEqual(1, lines.Length);
			Assert.IsTrue(lines[0].Contains("Id: 2"));
			Assert.IsTrue(lines[0].Contains("Name: Updated"));
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
	public void SaveToFileCollection_PropertiesWithNullValues_HandlesGracefully()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestCollectionUnitTester(tempDir);
		const string methodName = "NullPropertyTest";
		var collection = new[] { new TestPerson { Id = 1, Name = null } };

		try
		{
			// Act
			tester.SaveToFile(collection, p => true, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			Assert.IsTrue(File.Exists(expectedFilePath));
			var lines = File.ReadAllLines(expectedFilePath);
			Assert.AreEqual(1, lines.Length);
			Assert.IsTrue(lines[0].Contains("Id: 1"));
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
	public void SaveToFileCollection_SelectiveProperties_SavesOnlySelectedProperties()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestCollectionUnitTester(tempDir);
		const string methodName = "SelectivePropsTest";
		var collection = new[]
		{
			new TestPerson { Id = 1, Name = "Alice" },
			new TestPerson { Id = 2, Name = "Bob" }
		};

		try
		{
			// Act - Only save Name property
			tester.SaveToFile(collection, p => p.Name == "Name", methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			var lines = File.ReadAllLines(expectedFilePath);
			Assert.AreEqual(2, lines.Length);
			Assert.AreEqual("Name: Alice", lines[0]);
			Assert.AreEqual("Name: Bob", lines[1]);
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
	public void SaveToFileCollection_ValidCollection_CreatesFileWithMultipleLines()
	{
		// Arrange
		var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		Directory.CreateDirectory(tempDir);
		var tester = new TestCollectionUnitTester(tempDir);
		const string methodName = "CollectionTest";
		var collection = new[]
		{
			new TestPerson { Id = 1, Name = "Alice" },
			new TestPerson { Id = 2, Name = "Bob" }
		};

		try
		{
			// Act
			tester.SaveToFile(collection, p => true, methodName);

			// Assert
			var expectedFilePath = Path.Combine(tempDir, $"{methodName}.txt");
			Assert.IsTrue(File.Exists(expectedFilePath));
			var lines = File.ReadAllLines(expectedFilePath);
			Assert.AreEqual(2, lines.Length);
			Assert.IsTrue(lines[0].Contains("Id: 1"));
			Assert.IsTrue(lines[0].Contains("Name: Alice"));
			Assert.IsTrue(lines[1].Contains("Id: 2"));
			Assert.IsTrue(lines[1].Contains("Name: Bob"));
		}
		finally
		{
			if (Directory.Exists(tempDir))
			{
				Directory.Delete(tempDir, true);
			}
		}
	}

	private class TestAsyncUnitTester : UnitTester
	{
		public TestAsyncUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}

	private class TestCollectionUnitTester : UnitTester
	{
		public TestCollectionUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}

	private class TestPerson
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	private class TestSaveUnitTester : UnitTester
	{
		public TestSaveUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}
}
