// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-05-2026
// ***********************************************************************
// <copyright file="DirectoryInfoExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class DirectoryInfoExtensionsTests
{

	[TestMethod]
	public void GetSize_AllDirectories_IncludesSubdirectories()
	{
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);
		var subDir = directory.CreateSubdirectory("child");

		try
		{
			_ = RandomData.GenerateFiles(subDir.FullName, count: 2, fileLength: 512);

			var topOnlySize = directory.GetSize(ControlChars.WildcardAllFiles, SearchOption.TopDirectoryOnly);
			var allDirsSize = directory.GetSize(ControlChars.WildcardAllFiles, SearchOption.AllDirectories);

			Assert.AreEqual(0, topOnlySize);
			Assert.IsTrue(allDirsSize > 0);
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[TestMethod]
	public void GetSize_DefaultParameters_ReturnsPositiveSize()
	{
		var generatedFiles = RandomData.GenerateFiles(count: 3, fileLength: 512);
		var directory = new DirectoryInfo(generatedFiles.Path);

		try
		{
			var result = directory.GetSize();

			Assert.IsTrue(result > 0);
		}
		finally
		{
			foreach (var file in generatedFiles.Files)
			{
				File.Delete(file);
			}
		}
	}

	[TestMethod]
	public void GetSize_EmptyDirectory_ReturnsZero()
	{
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);

		try
		{
			var result = directory.GetSize();

			Assert.AreEqual(0, result);
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[TestMethod]
	public void GetSize_EmptySearchPattern_ThrowsArgumentNullException()
	{
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);

		try
		{
			_ = Assert.ThrowsExactly<ArgumentNullException>(() => directory.GetSize(string.Empty));
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[TestMethod]
	public void GetSize_InvalidSearchOption_ThrowsArgumentOutOfRangeException()
	{
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);

		try
		{
			_ = Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => directory.GetSize(ControlChars.WildcardAllFiles, (SearchOption)100));
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[TestMethod]
	public void GetSize_NullPath_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => DirectoryInfoExtensions.GetSize(null));
	}

	[TestMethod]
	public void GetSize_NullSearchPattern_ThrowsArgumentNullException()
	{
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);

		try
		{
			_ = Assert.ThrowsExactly<ArgumentNullException>(() => directory.GetSize(null));
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[TestMethod]
	public void GetSize_SpecificFilePattern_ReturnsFilteredSize()
	{
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);

		try
		{
			var txtFile = Path.Combine(tempPath, "testfile.txt");
			File.WriteAllText(txtFile, RandomData.GenerateWord(100, 200));

			var logFile = Path.Combine(tempPath, "testfile.log");
			File.WriteAllText(logFile, RandomData.GenerateWord(100, 200));

			var txtSize = directory.GetSize("*.txt");
			var logSize = directory.GetSize("*.log");
			var allSize = directory.GetSize(ControlChars.WildcardAllFiles);

			Assert.IsTrue(txtSize > 0);
			Assert.IsTrue(logSize > 0);
			Assert.IsTrue(allSize >= txtSize + logSize);
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[TestMethod]
	public void GetSize_TopDirectoryOnly_ReturnsTopLevelSize()
	{
		var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
		var directory = Directory.CreateDirectory(tempPath);
		var subDir = directory.CreateSubdirectory("subdir");

		try
		{
			var topFiles = RandomData.GenerateFiles(tempPath, count: 2, fileLength: 256);
			var subFiles = RandomData.GenerateFiles(subDir.FullName, count: 2, fileLength: 256);

			var topOnlySize = directory.GetSize(ControlChars.WildcardAllFiles, SearchOption.TopDirectoryOnly);
			var allDirsSize = directory.GetSize(ControlChars.WildcardAllFiles, SearchOption.AllDirectories);

			Assert.IsTrue(topOnlySize > 0);
			Assert.IsTrue(allDirsSize > topOnlySize);
		}
		finally
		{
			directory.Delete(true);
		}
	}

	[TestMethod]
	public void GetSize_WithWildcardPattern_ReturnsPositiveSize()
	{
		var generatedFiles = RandomData.GenerateFiles(count: 3, fileLength: 512);
		var directory = new DirectoryInfo(generatedFiles.Path);

		try
		{
			var result = directory.GetSize(ControlChars.WildcardAllFiles);

			Assert.IsTrue(result > 0);
		}
		finally
		{
			foreach (var file in generatedFiles.Files)
			{
				File.Delete(file);
			}
		}
	}

}
