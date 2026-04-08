// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.Tests
// Author           : David McCarter
// Created          : 01-05-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="UnitTesterTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class UnitTesterTests : UnitTester
{

	public UnitTesterTests() : base(CreateTempDirectory()) { }

	[TestCleanup]
	public void Cleanup()
	{
		if (Directory.Exists(this.OutputDirectory))
		{
			Directory.Delete(this.OutputDirectory, true);
		}
	}

	// ──────────────────────────────────────────────
	// CleanupOutputDirectory
	// ──────────────────────────────────────────────

	[TestMethod]
	public void CleanupOutputDirectory_DirectoryDoesNotExist_ReturnsZero()
	{
		// Arrange
		var nonExistentDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		var tester = new TestUnitTester(nonExistentDir);

		// Act
		var result = tester.CleanupOutputDirectory();

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void CleanupOutputDirectory_EmptyDirectory_ReturnsZero()
	{
		// Act
		var result = this.CleanupOutputDirectory();

		// Assert
		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void CleanupOutputDirectory_WithCustomPattern_DeletesMatchingFiles()
	{
		// Arrange
		File.WriteAllText(Path.Combine(this.OutputDirectory, "test1.log"), "log1");
		File.WriteAllText(Path.Combine(this.OutputDirectory, "test2.log"), "log2");
		File.WriteAllText(Path.Combine(this.OutputDirectory, "test3.txt"), "txt");

		// Act
		var result = this.CleanupOutputDirectory("*.log");

		// Assert
		Assert.AreEqual(2, result);
		Assert.IsTrue(File.Exists(Path.Combine(this.OutputDirectory, "test3.txt")));
	}

	[TestMethod]
	public void CleanupOutputDirectory_WithFiles_DeletesMatchingFiles()
	{
		// Arrange
		File.WriteAllText(Path.Combine(this.OutputDirectory, "file1.txt"), "content1");
		File.WriteAllText(Path.Combine(this.OutputDirectory, "file2.txt"), "content2");

		// Act
		var result = this.CleanupOutputDirectory();

		// Assert
		Assert.AreEqual(2, result);
	}

	// ──────────────────────────────────────────────
	// MeasureAction
	// ──────────────────────────────────────────────

	[TestMethod]
	public void MeasureAction_NullAction_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this.MeasureAction(null!));
	}

	[TestMethod]
	public void MeasureAction_PrintResultFalse_ReturnsElapsedTime()
	{
		// Arrange & Act
		var elapsed = this.MeasureAction(() => Task.Delay(10).Wait(), printResult: false, "TestMethod");

		// Assert
		Assert.IsTrue(elapsed.TotalMilliseconds >= 0);
	}

	[TestMethod]
	public void MeasureAction_ValidAction_ReturnsElapsedTime()
	{
		// Arrange & Act
		var elapsed = this.MeasureAction(() => Task.Delay(10).Wait(), printResult: true, "TestMethod");

		// Assert
		Assert.IsTrue(elapsed.TotalMilliseconds >= 0);
	}

	// ──────────────────────────────────────────────
	// MeasureActionAsync
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task MeasureActionAsync_NullAction_ThrowsArgumentNullException()
	{
		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await this.MeasureActionAsync(null!));
	}

	[TestMethod]
	public async Task MeasureActionAsync_PrintResultFalse_ReturnsElapsedTime()
	{
		// Arrange & Act
		var elapsed = await this.MeasureActionAsync(async () => await Task.Delay(10), printResult: false, "TestMethod");

		// Assert
		Assert.IsTrue(elapsed.TotalMilliseconds >= 0);
	}

	[TestMethod]
	public async Task MeasureActionAsync_ValidAction_ReturnsElapsedTime()
	{
		// Arrange & Act
		var elapsed = await this.MeasureActionAsync(async () => await Task.Delay(10), printResult: true, "TestMethod");

		// Assert
		Assert.IsTrue(elapsed.TotalMilliseconds >= 0);
	}

	// ──────────────────────────────────────────────
	// OutputDirectory
	// ──────────────────────────────────────────────

	[TestMethod]
	public void OutputDirectory_CustomDirectory_ReturnsSpecifiedPath()
	{
		// Arrange
		var customDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		var tester = new TestUnitTester(customDir);

		// Act & Assert
		Assert.AreEqual(customDir, tester.OutputDirectory);
	}

	[TestMethod]
	public void OutputDirectory_DefaultConstructor_ReturnsExecutingFolder()
	{
		// Arrange
		var tester = new TestUnitTester();

		// Act & Assert
		Assert.AreEqual(DotNetTips.Spargine.Core.App.ExecutingFolder(), tester.OutputDirectory);
	}

	[TestMethod]
	public void OutputDirectory_InheritsFromUnitTester_ReturnsValidPath()
	{
		// Act & Assert
		Assert.IsFalse(string.IsNullOrEmpty(this.OutputDirectory));
		Assert.IsTrue(Directory.Exists(this.OutputDirectory));
	}

	// ──────────────────────────────────────────────
	// PrintToDebug (string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void PrintToDebug_EmptyInput_DoesNotThrow()
	{
		// Act — empty input returns without writing
		this.PrintToDebug(string.Empty, "TestMethod");
	}

	[TestMethod]
	public void PrintToDebug_NullInput_DoesNotThrow()
	{
		// Act — null input returns without writing
		this.PrintToDebug(null!, "TestMethod");
	}

	[TestMethod]
	public void PrintToDebug_ValidInput_DoesNotThrow()
	{
		// Arrange
		var content = RandomData.GenerateWord(20);

		// Act
		this.PrintToDebug(content, "TestMethod");
	}

	// ──────────────────────────────────────────────
	// PrintToDebug<T>(IEnumerable<T>, ...)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void PrintToDebugCollection_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> nullCollection = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.PrintToDebug(nullCollection, p => true, "TestMethod"));
	}

	[TestMethod]
	public void PrintToDebugCollection_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(2);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.PrintToDebug(collection, null!, "TestMethod"));
	}

	[TestMethod]
	public void PrintToDebugCollection_ValidInput_DoesNotThrow()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(3);

		// Act
		this.PrintToDebug(collection, p => true, "TestMethod");
	}

	// ──────────────────────────────────────────────
	// PrintToDebug<T>(T, ...)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void PrintToDebugObject_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		Models.RefTypes.Person nullPerson = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.PrintToDebug(nullPerson, p => true, "TestMethod"));
	}

	[TestMethod]
	public void PrintToDebugObject_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.PrintToDebug(person, null!, "TestMethod"));
	}

	[TestMethod]
	public void PrintToDebugObject_ValidInput_DoesNotThrow()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();

		// Act
		this.PrintToDebug(person, p => true, "TestMethod");
	}

	// ──────────────────────────────────────────────
	// PropertiesToString (extension method helper)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void PropertiesToString_AllProperties_ReturnsAllProperties()
	{
		// Arrange
		var sample = new Sample { Id = 1, Name = "Test" };

		// Act
		var result = sample.PropertiesToString(p => true);

		// Assert
		Assert.Contains("Id:1", result);
		Assert.Contains("Name:Test", result);
	}

	[TestMethod]
	public void PropertiesToString_NoProperties_ReturnsEmptyString()
	{
		// Arrange
		var obj = new NoProperties();

		// Act
		var result = obj.PropertiesToString(p => true);

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void PropertiesToString_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		Sample nullSample = null!;
		Func<PropertyInfo, bool> selector = p => true;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			nullSample.PropertiesToString(selector));
	}

	[TestMethod]
	public void PropertiesToString_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		var sample = new Sample();
		Func<PropertyInfo, bool> nullSelector = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			sample.PropertiesToString(nullSelector));
	}

	[TestMethod]
	public void PropertiesToString_SelectNameProperty_ReturnsNameOnly()
	{
		// Arrange
		var sample = new Sample { Id = 2, Name = "Sample" };

		// Act
		var result = sample.PropertiesToString(p => p.Name == "Name");

		// Assert
		Assert.AreEqual("Name:Sample", result);
	}

	// ──────────────────────────────────────────────
	// SaveAsJsonToFile
	// ──────────────────────────────────────────────

	[TestMethod]
	public void SaveAsJsonToFile_NullInput_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveAsJsonToFile<Sample>(null!, "TestMethod"));
	}

	[TestMethod]
	public void SaveAsJsonToFile_ValidInput_CreatesJsonFile()
	{
		// Arrange
		var sample = new Sample { Id = 42, Name = "JsonTest" };

		// Act
		var filePath = this.SaveAsJsonToFile(sample, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		Assert.EndsWith(".json", filePath);
		var content = File.ReadAllText(filePath);
		Assert.Contains("42", content);
		Assert.Contains("JsonTest", content);
	}

	[TestMethod]
	public void SaveAsJsonToFile_EmptyMethodName_CreatesFileWithRandomName()
	{
		// Arrange
		var sample = new Sample { Id = 99, Name = "EmptyMethod" };

		// Act
		var filePath = this.SaveAsJsonToFile(sample, string.Empty);

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		Assert.EndsWith(".json", filePath);
	}

	// ──────────────────────────────────────────────
	// SaveToFile (string, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void SaveToFile_EmptyInput_ReturnsEmptyString()
	{
		// Act
		var result = this.SaveToFile(string.Empty, "TestMethod");

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void SaveToFile_NullInput_ReturnsEmptyString()
	{
		// Act
		var result = this.SaveToFile(null!, "TestMethod");

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void SaveToFile_ValidInput_CreatesFile()
	{
		// Arrange
		var content = RandomData.GenerateWord(50);

		// Act
		var filePath = this.SaveToFile(content, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		Assert.AreEqual(content, File.ReadAllText(filePath));
	}

	// ──────────────────────────────────────────────
	// SaveToFile (string, DirectoryInfo, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void SaveToFileWithDirectory_EmptyInput_ReturnsEmptyString()
	{
		// Arrange
		var tempDir = new DirectoryInfo(this.OutputDirectory);

		// Act
		var result = this.SaveToFile(string.Empty, tempDir, "TestMethod");

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void SaveToFileWithDirectory_NonExistentDirectory_ThrowsDirectoryNotFoundException()
	{
		// Arrange
		var nonExistentDir = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
		const string content = "Test content";

		// Act & Assert
		Assert.ThrowsExactly<DirectoryNotFoundException>(() =>
			this.SaveToFile(content, nonExistentDir, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileWithDirectory_NullDirectory_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile("content", (DirectoryInfo)null!, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileWithDirectory_NullInput_ReturnsEmptyString()
	{
		// Arrange
		var tempDir = new DirectoryInfo(this.OutputDirectory);

		// Act
		var result = this.SaveToFile(null!, tempDir, "TestMethod");

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void SaveToFileWithDirectory_ValidInput_CreatesFileInSpecifiedDirectory()
	{
		// Arrange
		var tempDir = new DirectoryInfo(this.OutputDirectory);
		var content = RandomData.GenerateWord(30);

		// Act
		var savedFilePath = this.SaveToFile(content, tempDir, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(savedFilePath));
		Assert.StartsWith(tempDir.FullName, savedFilePath);
		Assert.AreEqual(content, File.ReadAllText(savedFilePath));
	}

	// ──────────────────────────────────────────────
	// SaveToFile<T>(IEnumerable<T>, selector, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void SaveToFileCollection_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> nullCollection = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(nullCollection, p => true, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileCollection_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(2);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(collection, null!, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileCollection_ValidInput_CreatesFile()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(3);

		// Act
		var filePath = this.SaveToFile(collection, p => true, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		var lines = File.ReadAllLines(filePath);
		Assert.HasCount(3, lines);
	}

	// ──────────────────────────────────────────────
	// SaveToFile<T>(T, selector, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void SaveToFileObject_EmptyContent_ReturnsEmptyString()
	{
		// Arrange
		var obj = new NoProperties();

		// Act
		var result = this.SaveToFile(obj, p => true, "TestMethod");

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public void SaveToFileObject_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		Sample nullSample = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(nullSample, p => true, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileObject_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		var sample = new Sample { Id = 1, Name = "Test" };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(sample, (Func<PropertyInfo, bool>)null!, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileObject_ValidInput_CreatesFile()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();

		// Act
		var filePath = this.SaveToFile(person, p => true, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		var content = File.ReadAllText(filePath);
		Assert.IsFalse(string.IsNullOrEmpty(content));
	}

	// ──────────────────────────────────────────────
	// SaveToFile<T>(T, selector, DirectoryInfo, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void SaveToFileObjectWithDirectory_NullDirectory_ThrowsArgumentNullException()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(person, p => true, (DirectoryInfo)null!, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileObjectWithDirectory_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		var tempDir = new DirectoryInfo(this.OutputDirectory);
		Sample nullSample = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(nullSample, p => true, tempDir, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileObjectWithDirectory_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();
		var tempDir = new DirectoryInfo(this.OutputDirectory);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(person, (Func<PropertyInfo, bool>)null!, tempDir, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileObjectWithDirectory_ValidInput_CreatesFile()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();
		var tempDir = new DirectoryInfo(this.OutputDirectory);

		// Act
		var filePath = this.SaveToFile(person, p => true, tempDir, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		Assert.StartsWith(tempDir.FullName, filePath);
	}

	// ──────────────────────────────────────────────
	// SaveToFile<T>(IEnumerable<T>, selector, DirectoryInfo, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public void SaveToFileCollectionWithDirectory_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		var tempDir = new DirectoryInfo(this.OutputDirectory);
		IEnumerable<Models.RefTypes.Person> nullCollection = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(nullCollection, p => true, tempDir, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileCollectionWithDirectory_NullDirectory_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(2);
		DirectoryInfo nullDir = null!;

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(collection, p => true, nullDir, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileCollectionWithDirectory_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(2);
		var tempDir = new DirectoryInfo(this.OutputDirectory);

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() =>
			this.SaveToFile(collection, null!, tempDir, "TestMethod"));
	}

	[TestMethod]
	public void SaveToFileCollectionWithDirectory_ValidInput_CreatesFile()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(3);
		var tempDir = new DirectoryInfo(this.OutputDirectory);

		// Act
		var filePath = this.SaveToFile(collection, p => true, tempDir, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		Assert.StartsWith(tempDir.FullName, filePath);
		var lines = File.ReadAllLines(filePath);
		Assert.HasCount(3, lines);
	}

	// ──────────────────────────────────────────────
	// SaveToFileAsync (string, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task SaveToFileAsync_EmptyInput_ReturnsEmptyString()
	{
		// Act
		var result = await this.SaveToFileAsync(string.Empty, "TestMethod");

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public async Task SaveToFileAsync_NullInput_ReturnsEmptyString()
	{
		// Act
		var result = await this.SaveToFileAsync(null!, "TestMethod");

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public async Task SaveToFileAsync_ValidInput_CreatesFile()
	{
		// Arrange
		var content = RandomData.GenerateWord(50);

		// Act
		var filePath = await this.SaveToFileAsync(content, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		Assert.AreEqual(content, await File.ReadAllTextAsync(filePath));
	}

	// ──────────────────────────────────────────────
	// SaveToFileAsync<T>(IEnumerable<T>, selector, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task SaveToFileAsyncCollection_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> nullCollection = null!;

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await this.SaveToFileAsync(nullCollection, p => true, "TestMethod"));
	}

	[TestMethod]
	public async Task SaveToFileAsyncCollection_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(2);

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await this.SaveToFileAsync(collection, null!, "TestMethod"));
	}

	[TestMethod]
	public async Task SaveToFileAsyncCollection_ValidInput_CreatesFile()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(3);

		// Act
		var filePath = await this.SaveToFileAsync(collection, p => true, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		var lines = await File.ReadAllLinesAsync(filePath);
		Assert.HasCount(3, lines);
	}

	// ──────────────────────────────────────────────
	// SaveToFileAsync<T>(T, selector, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task SaveToFileAsyncObject_EmptyContent_ReturnsEmptyString()
	{
		// Arrange
		var obj = new NoProperties();

		// Act
		var result = await this.SaveToFileAsync(obj, p => true, "TestMethod");

		// Assert
		Assert.AreEqual(string.Empty, result);
	}

	[TestMethod]
	public async Task SaveToFileAsyncObject_NullInput_ThrowsArgumentNullException()
	{
		// Arrange
		Sample nullSample = null!;

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await this.SaveToFileAsync(nullSample, p => true, "TestMethod"));
	}

	[TestMethod]
	public async Task SaveToFileAsyncObject_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await this.SaveToFileAsync(person, (Func<PropertyInfo, bool>)null!, "TestMethod"));
	}

	[TestMethod]
	public async Task SaveToFileAsyncObject_ValidInput_CreatesFile()
	{
		// Arrange
		var person = RandomData.GeneratePersonRefCollection(1).First();

		// Act
		var filePath = await this.SaveToFileAsync(person, p => true, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		var content = await File.ReadAllTextAsync(filePath);
		Assert.IsFalse(string.IsNullOrEmpty(content));
	}

	// ──────────────────────────────────────────────
	// SaveToFileAsync<T>(IEnumerable<T>, selector, DirectoryInfo, string)
	// ──────────────────────────────────────────────

	[TestMethod]
	public async Task SaveToFileAsyncCollectionWithDirectory_NullCollection_ThrowsArgumentNullException()
	{
		// Arrange
		var tempDir = new DirectoryInfo(this.OutputDirectory);
		IEnumerable<Models.RefTypes.Person> nullCollection = null!;

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await this.SaveToFileAsync(nullCollection, p => true, tempDir, "TestMethod"));
	}

	[TestMethod]
	public async Task SaveToFileAsyncCollectionWithDirectory_NullDirectory_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(2);
		DirectoryInfo nullDir = null!;

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await this.SaveToFileAsync(collection, p => true, nullDir, "TestMethod"));
	}

	[TestMethod]
	public async Task SaveToFileAsyncCollectionWithDirectory_NullSelector_ThrowsArgumentNullException()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(2);
		var tempDir = new DirectoryInfo(this.OutputDirectory);

		// Act & Assert
		await Assert.ThrowsExactlyAsync<ArgumentNullException>(async () =>
			await this.SaveToFileAsync(collection, null!, tempDir, "TestMethod"));
	}

	[TestMethod]
	public async Task SaveToFileAsyncCollectionWithDirectory_ValidInput_CreatesFile()
	{
		// Arrange
		IEnumerable<Models.RefTypes.Person> collection = RandomData.GeneratePersonRefCollection(3);
		var tempDir = new DirectoryInfo(this.OutputDirectory);

		// Act
		var filePath = await this.SaveToFileAsync(collection, p => true, tempDir, "TestMethod");

		// Assert
		Assert.IsTrue(File.Exists(filePath));
		Assert.StartsWith(tempDir.FullName, filePath);
		var lines = await File.ReadAllLinesAsync(filePath);
		Assert.HasCount(3, lines);
	}

	private static string CreateTempDirectory()
	{
		var dir = Path.Combine(Path.GetTempPath(), $"UnitTesterTests_{Guid.NewGuid()}");
		Directory.CreateDirectory(dir);
		return dir;
	}

	private class NoProperties { }

	private class Sample
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}

	private class TestUnitTester : UnitTester
	{
		public TestUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}
}
