// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-20-2025
// ***********************************************************************
// <copyright file="AppTests.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Tests.Properties;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AppTests
{

	[TestMethod]
	public void AppConfigTest()
	{
		var config = new AppConfig();

		Assert.IsTrue(string.IsNullOrEmpty(config.ConfigFileName) == false);

		_ = config.TestValues.Count1 = 100;

		_ = config.Save();

		_ = config.Load();

		Assert.IsTrue(config.TestValues.Count1 == 100);

	}

	[TestMethod]
	public void AppInfoTest()
	{
		var info = App.AppInfo;

		Assert.IsTrue(info is not null);
	}

	[TestMethod]
	public void ChangeCulture_WithCultureInfo_ChangesCurrentCulture()
	{
		// Arrange
		var originalCulture = CultureInfo.CurrentCulture;
		var testCultureInfo = new CultureInfo("fr-FR");

		// Act
		App.ChangeCulture(testCultureInfo);

		// Assert
		Assert.AreEqual(testCultureInfo, CultureInfo.CurrentCulture, "The current culture should be changed to the one provided.");

		// Cleanup
		App.ChangeCulture(originalCulture);
	}

	[TestMethod]
	public void ChangeCulture_WithCultureInfoToSameCulture_DoesNotThrowException()
	{
		// Arrange
		var testCultureInfo = new CultureInfo(CultureInfo.CurrentCulture.Name);

		// Act & Assert
		App.ChangeCulture(testCultureInfo);

		// No exception means the test passed. Cleanup is not necessary as the culture was not changed.
	}

	[TestMethod]
	public void ChangeCultureTest()
	{
		App.ChangeCulture("aa");

		Assert.AreEqual("aa", App.CurrentCulture.Name);

		App.ChangeUICulture("af");

		Assert.AreEqual("af", App.CurrentUICulture.Name);

		App.ChangeCulture("en-US");
		App.ChangeUICulture("en-US");
	}

	[TestMethod]
	public void CurrentThreadIdTest()
	{
		var result = App.CurrentThreadId;

		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void ExecutingFolderTest()
	{
		var result = App.ExecutingFolder();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

	[TestMethod]
	public void FrameworkDescriptionTest()
	{
		var result = App.FrameworkDescription;

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}
	[TestMethod]
	public void GenerateDiagnosticReport_ReturnsExpectedContent()
	{
		// Act
		var report = App.GenerateDiagnosticReport();

		// Assert
		Assert.IsFalse(string.IsNullOrWhiteSpace(report), "Report should not be null or whitespace.");
		StringAssert.Contains(report, "Application:", "Report should contain 'Application:' label.");
		StringAssert.Contains(report, "OS:", "Report should contain 'OS:' label.");
		StringAssert.Contains(report, "Framework:", "Report should contain 'Framework:' label.");
		StringAssert.Contains(report, "Memory Usage:", "Report should contain 'Memory Usage:' label.");

		// Check that product and version are present
		if (!string.IsNullOrEmpty(App.AppInfo.Product))
		{
			StringAssert.Contains(report, App.AppInfo.Product, "Report should contain product name.");
		}
		if (!string.IsNullOrEmpty(App.AppInfo.Version))
		{
			StringAssert.Contains(report, App.AppInfo.Version, "Report should contain version.");
		}

		// Check that OSDescription and OSArchitecture are present
		StringAssert.Contains(report, App.OSDescription, "Report should contain OS description.");
		StringAssert.Contains(report, App.OSArchitecture.ToString(), "Report should contain OS architecture.");

		// Check that FrameworkDescription is present
		StringAssert.Contains(report, App.FrameworkDescription, "Report should contain framework description.");

		// Check that WorkingSet (in MB) is present
		var workingSetMb = App.WorkingSet / 1024 / 1024;
		StringAssert.Contains(report, $"{workingSetMb} MB", "Report should contain working set in MB.");
	}

	[TestMethod]
	public void GetAppState_ReturnsLatestValue_WhenKeyIsOverwritten()
	{
		const string key = "OverwriteKey";
		const string value1 = "Value1";
		const string value2 = "Value2";
		App.SetAppState(key, value1);
		App.SetAppState(key, value2);

		var result = App.GetAppState(key);

		Assert.AreEqual(value2, result, "Should return the latest value for the key.");
	}

	[TestMethod]
	public void GetAppState_ReturnsNull_WhenKeyDoesNotExist()
	{
		var result = App.GetAppState("NonExistentKey");
		Assert.IsNull(result, "Should return null for a key that does not exist.");
	}

	[TestMethod]
	public void GetAppState_ReturnsValue_WhenKeyExists()
	{
		const string key = "TestKey";
		const string value = "TestValue";
		App.SetAppState(key, value);

		var result = App.GetAppState(key);

		Assert.IsNotNull(result, "Should return a value for an existing key.");
		Assert.AreEqual(value, result, "Returned value should match the set value.");
	}

	[TestMethod]
	public void GetCommandLineArguments_EmptyArguments_ReturnsEmptyDictionary()
	{
		// Arrange
		var originalArgs = Environment.GetCommandLineArgs();
		var testArgs = new[] { originalArgs[0] };

		var field = typeof(Environment).GetField("s_commandLineArgs", BindingFlags.Static | BindingFlags.NonPublic);
		var originalValue = field?.GetValue(null);
		field?.SetValue(null, testArgs);

		try
		{
			// Act
			var result = App.GetCommandLineArguments();

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(0, result.Count);
		}
		finally
		{
			field?.SetValue(null, originalValue);
		}
	}

	[TestMethod]
	public void GetCommandLineArguments_ReturnsDictionary_WithExpectedKeysAndValues()
	{
		// Arrange
		// Simulate command line args: ["dotnet", "foo=bar", "baz", "qux=quux"]
		var originalArgs = Environment.GetCommandLineArgs();
		var testArgs = new[] { originalArgs[0], "foo=bar", "baz", "qux=quux" };

		// Use reflection to set the private _commandLineArgs field in Environment
		var field = typeof(Environment).GetField("s_commandLineArgs", BindingFlags.Static | BindingFlags.NonPublic);
		var originalValue = field?.GetValue(null);
		field?.SetValue(null, testArgs);

		try
		{
			// Act
			var result = App.GetCommandLineArguments();

			// Assert
			Assert.IsNotNull(result);
			Assert.IsTrue(result.ContainsKey("foo"));
			Assert.AreEqual("bar", result["foo"]);
			Assert.IsTrue(result.ContainsKey("baz"));
			Assert.AreEqual(string.Empty, result["baz"]);
			Assert.IsTrue(result.ContainsKey("qux"));
			Assert.AreEqual("quux", result["qux"]);
		}
		finally
		{
			// Restore original command line args
			field?.SetValue(null, originalValue);
		}
	}

	[TestMethod]
	public void GetCultureNames_ReturnsAllCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames();

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count > 0);
	}

	[TestMethod]
	public void GetCultureNames_ReturnsInstalledWin32Cultures()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.InstalledWin32Cultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count > 0);
		Assert.IsTrue(cultureNames.Contains("en-US"));
	}

	[TestMethod]
	public void GetCultureNames_ReturnsNeutralCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.NeutralCultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count > 0);
		Assert.IsTrue(cultureNames.Contains("en"));
	}

	[TestMethod]
	public void GetCultureNames_ReturnsSpecificCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.SpecificCultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count > 0);
		Assert.IsTrue(cultureNames.Contains("en-US"));
	}

	[TestMethod]
	public void GetCultureNames_ReturnsUserCustomCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.UserCustomCulture);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsTrue(cultureNames.Count >= 0); // User custom cultures might be empty
	}

	[TestMethod]
	public void GetCultureTest()
	{
		var result = App.CurrentCulture;

		Assert.IsNotNull(result);

		result = App.CurrentUICulture;

		Assert.IsNotNull(result);

		result = App.InstalledUICulture;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetEnvironmentVariablesTest()
	{
		var result = App.GetEnvironmentVariables();

		Assert.IsTrue(result.FastCount() > 0);

		foreach (var info in result)
		{
			Debug.WriteLine($"{info.Key}:{info.Value}");
		}
	}

	[TestMethod]
	public void GetLocalizedString_ReturnsEmptyString_WhenKeyDoesNotExist()
	{
		// Act
		var result = App.GetLocalizedString(Resources.ResourceManager, "NonExistentResourceKey", "en-US");

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(string.Empty, result, "Should return empty string for missing resource key.");
	}

	[TestMethod]
	public void GetLocalizedString_ReturnsLocalizedValue_WhenKeyAndCultureExist()
	{
		// Arrange
		// "WelcomeMessage" should exist in your .resx for this to pass, otherwise adjust the key and culture.
		var key = "WelcomeMessage";
		var culture = "en-US";
		var expected = Resources.ResourceManager.GetString(key, new CultureInfo(culture)) ?? string.Empty;

		// Act
		var result = App.GetLocalizedString(Resources.ResourceManager, key, culture);

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetLocalizedString_ThrowsArgumentException_WhenKeyIsEmpty()
	{
		// Act
		App.GetLocalizedString(Resources.ResourceManager, string.Empty, "en-US");
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentNullException))]
	public void GetLocalizedString_ThrowsArgumentNullException_WhenKeyIsNull()
	{
		// Act
		App.GetLocalizedString(Resources.ResourceManager, null, "en-US");
	}

	[TestMethod]
	public void GetLocalizedString_UsesCurrentUICulture_WhenCultureNameIsNullOrEmpty()
	{
		// Arrange
		// "WelcomeMessage" should exist in your .resx for this to pass, otherwise adjust the key.
		var key = "WelcomeMessage";
		var expected = Resources.ResourceManager.GetString(key, App.CurrentUICulture) ?? string.Empty;

		// Act
		var result = App.GetLocalizedString(Resources.ResourceManager, key, null);

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void GetProcessorInformationTest()
	{
		var result = App.GetProcessorInformation();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void InformationTest()
	{
		var result1 = App.StackTrace;

		Assert.IsTrue(string.IsNullOrEmpty(result1) is false);

		var result3 = App.OSArchitecture;

		Assert.IsTrue(result3 == Architecture.X64);

		var result4 = App.OSDescription;

		Assert.IsTrue(string.IsNullOrEmpty(result4) is false);

		var result5 = App.ProcessArchitecture;

		Assert.IsTrue(result5 == Architecture.X64);

		var result2 = App.WorkingSet;

		Assert.IsTrue(result2 > 0);
	}

	[TestMethod]
	public void IsRunningFromAspNet()
	{
		var result = App.IsRunningFromAspNet();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsRunningTest()
	{
		var result = App.IsRunning();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void IsUserAdministrator()
	{
		var result = App.IsUserAdministrator();

		Assert.IsFalse(result);
	}

	[TestMethod]
	public void MaxDegreeOfParallelism_ValidProcessorCount_ReturnsExpectedValue()
	{
		// Arrange
		var processorCount = Environment.ProcessorCount;
		var expectedValue = Convert.ToInt32(Math.Ceiling(processorCount * 0.75 * 2.0));

		// Act
		var result = App.MaxDegreeOfParallelism();

		// Assert
		Assert.AreEqual(expectedValue, result);
	}

	[TestMethod]
	public void ProcessIdTest()
	{
		var result = App.ProcessId;

		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void ProcessNameTest()
	{
		var result = App.ProcessName;

		Assert.IsFalse(string.IsNullOrEmpty(result), "Process name should not be null or empty.");
		Assert.AreEqual(Process.GetCurrentProcess().ProcessName, result, "Process name should match the current process name.");
	}

	[TestMethod]
	public void ProcessPathTest()
	{
		var result = App.ProcessPath;

		Assert.IsTrue(result.Length > 0);
	}

	[TestMethod]
	public void ReferencedAssembliesTest()
	{
		var result = App.ReferencedAssemblies();

		Assert.IsTrue(result.FastCount() > 0);
	}

	[TestMethod]
	public void SetAppState_AddsNewKeyAndValue()
	{
		// Arrange
		var key = "UnitTestKey";
		var value = Guid.NewGuid().ToString();

		// Act
		App.SetAppState(key, value);

		// Assert
		var result = App.GetAppState(key);
		Assert.IsNotNull(result, "Value should be set and retrievable.");
		Assert.AreEqual(value, result, "Stored value should match the set value.");
	}

	[TestMethod]
	public void SetAppState_OverwritesExistingKey()
	{
		// Arrange
		var key = "OverwriteTestKey";
		var value1 = "FirstValue";
		var value2 = "SecondValue";
		App.SetAppState(key, value1);

		// Act
		App.SetAppState(key, value2);

		// Assert
		var result = App.GetAppState(key);
		Assert.AreEqual(value2, result, "Value should be overwritten with the latest value.");
	}
}

[ExcludeFromCodeCoverage]
public class GlobalConfig
{

	public GlobalConfig()
	{
	}

}

[ExcludeFromCodeCoverage]
public class AppConfig : Config<GlobalConfig>
{

	public Values TestValues { get; set; } = new Values();

}

[ExcludeFromCodeCoverage]
public class Values
{
	public int Count1 { get; set; }
	public int Count2 { get; set; }

}
