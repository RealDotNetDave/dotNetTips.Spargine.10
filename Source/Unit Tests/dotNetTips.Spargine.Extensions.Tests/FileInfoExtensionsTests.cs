// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-08-2026
// ***********************************************************************
// <copyright file="FileInfoExtensionsTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Unit tests for FileInfoExtensions methods.</summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class FileInfoExtensionsTests
{
	[TestMethod]
	public void CreateTempFileThenMove_WithNullFile_ThrowsArgumentNullException()
	{
		FileInfo file = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => file.CreateTempFileThenMove("content"));
	}

	[TestMethod]
	public void ReadAllTextSafe_WhenFileMissing_ReturnsFallback()
	{
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName(), "missing.txt"));

		var result = file.ReadAllTextSafe("fallback");

		Assert.AreEqual("fallback", result);
	}

	[TestMethod]
	public void ReadAllTextSafe_WithNullFile_ThrowsArgumentNullException()
	{
		FileInfo file = null;

		_ = Assert.ThrowsExactly<ArgumentNullException>(() => file.ReadAllTextSafe());
	}

	[TestMethod]
	public void WriteAllTextAtomic_CreatesAndWritesFile()
	{
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var file = new FileInfo(Path.Combine(tempDirectory.FullName, "atomic.txt"));
		const string Expected = "atomic-content";

		try
		{
			file.WriteAllTextAtomic(Expected);

			Assert.IsTrue(file.Exists);
			Assert.AreEqual(Expected, File.ReadAllText(file.FullName));
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}

	[TestMethod]
	public void WriteAllTextAtomic_OverwritesExistingFileAtomically()
	{
		var tempDirectory = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
		var file = new FileInfo(Path.Combine(tempDirectory.FullName, "atomic.txt"));

		try
		{
			File.WriteAllText(file.FullName, "old");

			file.WriteAllTextAtomic("new");

			Assert.AreEqual("new", File.ReadAllText(file.FullName));
		}
		finally
		{
			tempDirectory.Delete(true);
		}
	}
}
