// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : Copilot Agent
// Created          : 05-13-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-13-2026
// ***********************************************************************
// <copyright file="ConfigTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Unit tests for the Config&lt;T&gt; class covering construction, property
// initialization, Load, and Save behaviors.
// </summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ConfigTests
{

	[TestMethod]
	public void Constructor_EmptyCompanyName_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new TestableConfig(string.Empty, RandomData.GenerateWord(10)));
	}

	[TestMethod]
	public void Constructor_EmptyProductName_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new TestableConfig(RandomData.GenerateWord(10), string.Empty));
	}

	[TestMethod]
	public void Constructor_NullCompanyName_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new TestableConfig(null!, RandomData.GenerateWord(10)));
	}

	[TestMethod]
	public void Constructor_NullProductName_ThrowsArgumentNullException()
	{
		_ = Assert.ThrowsExactly<ArgumentNullException>(() => new TestableConfig(RandomData.GenerateWord(10), null!));
	}

	[TestMethod]
	public void Constructor_ValidArguments_ConfigFileNameUnderConfigFolderName()
	{
		// Arrange
		var companyName = RandomData.GenerateWord(10);
		var productName = RandomData.GenerateWord(10);

		// Act
		var config = new TestableConfig(companyName, productName);

		// Assert
		StringAssert.StartsWith(config.ConfigFileName, config.ConfigFolderName);
	}

	[TestMethod]
	public void Constructor_ValidArguments_SetsConfigFileName()
	{
		// Arrange
		var companyName = RandomData.GenerateWord(10);
		var productName = RandomData.GenerateWord(10);

		// Act
		var config = new TestableConfig(companyName, productName);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(config.ConfigFileName));
		StringAssert.Contains(config.ConfigFileName, productName);
		StringAssert.EndsWith(config.ConfigFileName, ".config");
	}
	[TestMethod]
	public void Constructor_ValidArguments_SetsConfigFolderName()
	{
		// Arrange
		var companyName = RandomData.GenerateWord(10);
		var productName = RandomData.GenerateWord(10);

		// Act
		var config = new TestableConfig(companyName, productName);

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(config.ConfigFolderName));
		StringAssert.Contains(config.ConfigFolderName, companyName);
	}

	[TestMethod]
	public void Instance_ReturnsNonNull()
	{
		// Arrange
		var config = new TestableConfig(RandomData.GenerateWord(10), RandomData.GenerateWord(10));

		// Act
		var instance = config.Instance;

		// Assert
		Assert.IsNotNull(instance);
		Assert.IsInstanceOfType<TestConfigData>(instance);
	}

	[TestMethod]
	[RequiresUnreferencedCode("XML serialization uses reflection and may require members that are removed by trimming.")]
	public void Load_FileDoesNotExist_ReturnsFalse()
	{
		// Arrange
		var config = new TestableConfig(RandomData.GenerateWord(10), RandomData.GenerateWord(10));

		// Act
		var result = config.Load();

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	[RequiresUnreferencedCode("XML serialization uses reflection and may require members that are removed by trimming.")]
	public void Save_CreatesFileAndReturnsTrue()
	{
		// Arrange
		var config = new TestableConfig(RandomData.GenerateWord(10), RandomData.GenerateWord(10));
		config.Instance.Setting1 = RandomData.GenerateInteger(1, 1000);
		config.Instance.Setting2 = RandomData.GenerateWord(8);

		try
		{
			// Act
			var result = config.Save();

			// Assert
			Assert.IsTrue(result);
			Assert.IsTrue(File.Exists(config.ConfigFileName));
		}
		finally
		{
			if (File.Exists(config.ConfigFileName))
			{
				File.Delete(config.ConfigFileName);
			}

			if (Directory.Exists(config.ConfigFolderName))
			{
				Directory.Delete(config.ConfigFolderName, recursive: true);
			}
		}
	}

	[TestMethod]
	[RequiresUnreferencedCode("XML serialization uses reflection and may require members that are removed by trimming.")]
	public void Save_ExistingFile_OverwritesFile()
	{
		// Arrange
		var companyName = RandomData.GenerateWord(10);
		var productName = RandomData.GenerateWord(10);
		var config = new TestableConfig(companyName, productName);
		config.Instance.Setting1 = RandomData.GenerateInteger(1, 100);

		try
		{
			// Act — save once, modify, save again
			_ = config.Save();
			var firstWriteTime = File.GetLastWriteTimeUtc(config.ConfigFileName);

			Thread.Sleep(10);

			config.Instance.Setting1 = RandomData.GenerateInteger(101, 200);
			_ = config.Save();
			var secondWriteTime = File.GetLastWriteTimeUtc(config.ConfigFileName);

			// Assert
			Assert.IsTrue(File.Exists(config.ConfigFileName));
			Assert.IsTrue(secondWriteTime >= firstWriteTime);
		}
		finally
		{
			if (File.Exists(config.ConfigFileName))
			{
				File.Delete(config.ConfigFileName);
			}

			if (Directory.Exists(config.ConfigFolderName))
			{
				Directory.Delete(config.ConfigFolderName, recursive: true);
			}
		}
	}

	[TestMethod]
	[RequiresUnreferencedCode("XML serialization uses reflection and may require members that are removed by trimming.")]
	public void Save_ThenLoad_RoundTripsData()
	{
		// Arrange
		var companyName = RandomData.GenerateWord(10);
		var productName = RandomData.GenerateWord(10);
		var saveConfig = new TestableConfig(companyName, productName);
		var expectedSetting1 = RandomData.GenerateInteger(1, 9999);
		var expectedSetting2 = RandomData.GenerateWord(12);
		saveConfig.Instance.Setting1 = expectedSetting1;
		saveConfig.Instance.Setting2 = expectedSetting2;

		try
		{
			// Act
			_ = saveConfig.Save();

			var loadConfig = new TestableConfig(companyName, productName);
			var loaded = loadConfig.Load();

			// Assert
			Assert.IsTrue(loaded);
			Assert.AreEqual(expectedSetting1, loadConfig.Instance.Setting1);
			Assert.AreEqual(expectedSetting2, loadConfig.Instance.Setting2);
		}
		finally
		{
			if (File.Exists(saveConfig.ConfigFileName))
			{
				File.Delete(saveConfig.ConfigFileName);
			}

			if (Directory.Exists(saveConfig.ConfigFolderName))
			{
				Directory.Delete(saveConfig.ConfigFolderName, recursive: true);
			}
		}
	}
}

/// <summary>
/// A concrete subclass of Config&lt;T&gt; used exclusively for testing,
/// exposing the protected constructor with company/product parameters.
/// </summary>
[ExcludeFromCodeCoverage]
public sealed class TestableConfig : Config<TestConfigData>
{
	public TestableConfig(string companyName, string productName)
		: base(companyName, productName)
	{
	}
}

/// <summary>
/// Simple serializable data type used as the configuration payload in tests.
/// </summary>
[ExcludeFromCodeCoverage]
[Serializable]
public sealed class TestConfigData
{
	public int Setting1 { get; set; }
	public string Setting2 { get; set; } = string.Empty;
}
