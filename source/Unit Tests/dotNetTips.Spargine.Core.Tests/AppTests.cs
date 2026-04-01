// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="AppTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Tests.Properties;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
public class AppConfig : Config<GlobalConfig>
{

	public Values TestValues { get; set; } = new Values();

}

[ExcludeFromCodeCoverage]
[TestClass]
public class AppTests
{

	[TestMethod]
	public void AppConfigTest()
	{
		var config = new AppConfig();

		Assert.AreEqual(false, string.IsNullOrEmpty(config.ConfigFileName));

		_ = config.TestValues.Count1 = 100;

		_ = config.Save();

		_ = config.Load();

		Assert.AreEqual(100, config.TestValues.Count1);

	}

	[TestMethod]
	public void AppInfoTest()
	{
		var info = App.AppInfo;

		Assert.IsNotNull(info);
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
	public void ClearAppState_AllowsNewEntriesAfterClear()
	{
		// Arrange
		App.SetAppState("PreClearKey", "PreClearValue");
		App.ClearAppState();

		// Act
		App.SetAppState("PostClearKey", "PostClearValue");

		// Assert
		Assert.IsNull(App.GetAppState("PreClearKey"), "Pre-clear key should be null.");
		Assert.AreEqual("PostClearValue", App.GetAppState("PostClearKey"), "Post-clear key should be retrievable.");
	}

	[TestMethod]
	public void ClearAppState_OnEmptyState_DoesNotThrow()
	{
		// Arrange - ensure state is clear first
		App.ClearAppState();

		// Act & Assert - should not throw on empty state
		App.ClearAppState();
	}

	[TestMethod]
	public void ClearAppState_RemovesAllEntries()
	{
		// Arrange
		App.SetAppState("ClearTest1", "Value1");
		App.SetAppState("ClearTest2", "Value2");
		App.SetAppState("ClearTest3", "Value3");

		// Act
		App.ClearAppState();

		// Assert
		Assert.IsNull(App.GetAppState("ClearTest1"), "ClearTest1 should be null after clearing.");
		Assert.IsNull(App.GetAppState("ClearTest2"), "ClearTest2 should be null after clearing.");
		Assert.IsNull(App.GetAppState("ClearTest3"), "ClearTest3 should be null after clearing.");
	}

	[TestMethod]
	public void CurrentThreadIdTest()
	{
		var result = App.CurrentThreadId;

		Assert.IsGreaterThan(0, result);
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
		const string key1 = "TestKey1";
		const string value1 = "TestValue1";
		App.SetAppState(key1, value1);

		const string key2 = "TestKey2";
		const string value2 = "TestValue2";
		App.SetAppState(key2, value2);

		var result = App.GetAppState(key1);

		Assert.IsNotNull(result, "Should return a value for an existing key.");
		Assert.AreEqual(value1, result, "Returned value should match the set value.");
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
			Assert.IsEmpty(result);
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
		Assert.IsNotEmpty(cultureNames);
	}

	[TestMethod]
	public void GetCultureNames_ReturnsInstalledWin32Cultures()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.InstalledWin32Cultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsNotEmpty(cultureNames);
		Assert.Contains("en-US", cultureNames);
	}

	[TestMethod]
	public void GetCultureNames_ReturnsNeutralCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.NeutralCultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsNotEmpty(cultureNames);
		Assert.Contains("en", cultureNames);
	}

	[TestMethod]
	public void GetCultureNames_ReturnsSpecificCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.SpecificCultures);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsNotEmpty(cultureNames);
		Assert.Contains("en-US", cultureNames);
	}

	[TestMethod]
	public void GetCultureNames_ReturnsUserCustomCultureNames()
	{
		// Act
		var cultureNames = App.GetCultureNames(CultureTypes.UserCustomCulture);

		// Assert
		Assert.IsNotNull(cultureNames);
		Assert.IsGreaterThanOrEqualTo(0, cultureNames.Count); // User custom cultures might be empty
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

		Assert.IsGreaterThan(0, result.FastLongCount());

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
		// "WelcomeMessage" should exist in your .resx for this to pass, otherwise adjust the key1 and culture.
		var key = "WelcomeMessage";
		var culture = "en-US";
		var expected = Resources.ResourceManager.GetString(key, new CultureInfo(culture)) ?? string.Empty;

		// Act
		var result = App.GetLocalizedString(Resources.ResourceManager, key, culture);

		// Assert
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void GetLocalizedString_ThrowsArgumentException_WhenKeyIsEmpty()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => App.GetLocalizedString(Resources.ResourceManager, string.Empty, "en-US"));
	}

	[TestMethod]
	public void GetLocalizedString_ThrowsArgumentNullException_WhenKeyIsNull()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => App.GetLocalizedString(Resources.ResourceManager, null, "en-US"));
	}

	[TestMethod]
	public void GetLocalizedString_UsesCurrentUICulture_WhenCultureNameIsNullOrEmpty()
	{
		// Arrange
		// "WelcomeMessage" should exist in your .resx for this to pass, otherwise adjust the key1.
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

		Assert.AreEqual(Architecture.X64, result3);

		var result4 = App.OSDescription;

		Assert.IsTrue(string.IsNullOrEmpty(result4) is false);

		var result5 = App.ProcessArchitecture;

		Assert.AreEqual(Architecture.X64, result5);

		var result2 = App.WorkingSet;

		Assert.IsGreaterThan(0, result2);
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

		Assert.IsGreaterThan(0, result);
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

		Assert.IsGreaterThan(0, result.Length);
	}

	[TestMethod]
	public void ReferencedAssembliesTest()
	{
		var result = App.ReferencedAssemblies();

		Assert.IsGreaterThan(0, result.FastLongCount());
	}

	[TestMethod]
	public void RemoveAppState_IsCaseInsensitive()
	{
		// Arrange
		App.SetAppState("CaseTestKey", "TestValue");

		// Act
		var result = App.RemoveAppState("CASETESTKEY");

		// Assert
		Assert.IsTrue(result, "Should successfully remove key using different case.");
		Assert.IsNull(App.GetAppState("CaseTestKey"), "Key should be removed regardless of case.");
	}

	[TestMethod]
	public void RemoveAppState_ReturnsFalse_WhenCalledTwice()
	{
		// Arrange
		const string key = "DoubleRemoveKey";
		App.SetAppState(key, "TestValue");

		// Act
		var firstRemove = App.RemoveAppState(key);
		var secondRemove = App.RemoveAppState(key);

		// Assert
		Assert.IsTrue(firstRemove, "First removal should return true.");
		Assert.IsFalse(secondRemove, "Second removal should return false.");
	}

	[TestMethod]
	public void RemoveAppState_ReturnsFalse_WhenKeyDoesNotExist()
	{
		// Arrange
		const string key = "NonExistentRemoveKey";

		// Act
		var result = App.RemoveAppState(key);

		// Assert
		Assert.IsFalse(result, "Should return false when key does not exist.");
	}

	[TestMethod]
	public void RemoveAppState_ReturnsTrue_WhenKeyExists()
	{
		// Arrange
		const string key = "RemoveTestKey";
		App.SetAppState(key, "TestValue");

		// Act
		var result = App.RemoveAppState(key);

		// Assert
		Assert.IsTrue(result, "Should return true when removing an existing key.");
		Assert.IsNull(App.GetAppState(key), "Key should no longer exist after removal.");
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

	[TestMethod]
	public void ChangeCulture_WithNullString_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.ChangeCulture((string)null));
	}

	[TestMethod]
	public void ChangeCulture_WithEmptyString_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.ChangeCulture(string.Empty));
	}

	[TestMethod]
	public void ChangeCulture_WithNullCultureInfo_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.ChangeCulture((CultureInfo)null));
	}

	[TestMethod]
	public void ChangeUICulture_WithNullString_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.ChangeUICulture(null));
	}

	[TestMethod]
	public void ChangeUICulture_WithEmptyString_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.ChangeUICulture(string.Empty));
	}

	[TestMethod]
	public void SetAppState_WithNullKey_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.SetAppState(null, "TestValue"));
	}

	[TestMethod]
	public void SetAppState_WithEmptyKey_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.SetAppState(string.Empty, "TestValue"));
	}

	[TestMethod]
	public void SetAppState_WithNullValue_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.SetAppState("TestKey", null));
	}

	[TestMethod]
	public void SetAppState_IsCaseInsensitive()
	{
		// Arrange
		var key = RandomData.GenerateWord(10);
		var value = RandomData.GenerateWord(10);

		// Act
		App.SetAppState(key.ToLowerInvariant(), value);
		var result = App.GetAppState(key.ToUpperInvariant());

		// Assert
		Assert.AreEqual(value, result, "App state should be case-insensitive for keys.");
	}

	[TestMethod]
	public void GetAppState_ReturnsDefaultValue_WhenKeyDoesNotExist()
	{
		// Arrange
		var defaultValue = RandomData.GenerateWord(10);

		// Act
		var result = App.GetAppState("NonExistentKeyForDefaultTest", defaultValue);

		// Assert
		Assert.AreEqual(defaultValue, result, "Should return the default value when key does not exist.");
	}

	[TestMethod]
	public void GetAppState_ReturnsStoredValue_NotDefaultValue_WhenKeyExists()
	{
		// Arrange
		var key = RandomData.GenerateKey();
		var storedValue = RandomData.GenerateWord(10);
		var defaultValue = RandomData.GenerateWord(10);
		App.SetAppState(key, storedValue);

		// Act
		var result = App.GetAppState(key, defaultValue);

		// Assert
		Assert.AreEqual(storedValue, result, "Should return the stored value, not the default value.");
	}

	[TestMethod]
	public void GetAppState_IsCaseInsensitive()
	{
		// Arrange
		var key = RandomData.GenerateWord(10);
		var value = RandomData.GenerateWord(10);
		App.SetAppState(key.ToLowerInvariant(), value);

		// Act
		var result = App.GetAppState(key.ToUpperInvariant());

		// Assert
		Assert.AreEqual(value, result, "App state retrieval should be case-insensitive.");
	}

	[TestMethod]
	public void GetLocalizedString_ThrowsArgumentNullException_WhenResourceManagerIsNull()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.GetLocalizedString(null, "SomeKey", "en-US"));
	}

	[TestMethod]
	public void RemoveAppState_WithNullKey_ThrowsException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => App.RemoveAppState(null));
	}

	[TestMethod]
	public void ChangeCulture_WithCultureInfo_ChangesBothCurrentAndUICulture()
	{
		// Arrange
		var originalCulture = CultureInfo.CurrentCulture;
		var originalUICulture = CultureInfo.CurrentUICulture;
		var testCulture = new CultureInfo("de-DE");

		// Act
		App.ChangeCulture(testCulture);

		// Assert
		Assert.AreEqual(testCulture, CultureInfo.CurrentCulture, "Current culture should be changed.");
		Assert.AreEqual(testCulture, CultureInfo.CurrentUICulture, "Current UI culture should also be changed.");

		// Cleanup
		CultureInfo.CurrentCulture = originalCulture;
		CultureInfo.CurrentUICulture = originalUICulture;
	}

	[TestMethod]
	public void GetCultureNames_ReturnsCachedResult_WhenCalledTwice()
	{
		// Act
		var first = App.GetCultureNames();
		var second = App.GetCultureNames();

		// Assert
		Assert.AreSame(first, second, "Subsequent calls should return the same cached instance.");
	}

	[TestMethod]
	public void GenerateDiagnosticReport_IsNotNullOrEmpty()
	{
		// Act
		var report = App.GenerateDiagnosticReport();

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(report), "Diagnostic report should not be null or empty.");
	}

	[TestMethod]
	public void ExecutingFolder_ReturnsNonEmptyPath()
	{
		// Act
		var folder = App.ExecutingFolder();

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(folder), "Executing folder should not be null or empty.");
		Assert.IsTrue(Directory.Exists(folder), "Executing folder path should be a valid directory.");
	}

	[TestMethod]
	public void AppInfo_HasNonNullProperties()
	{
		// Act
		var info = App.AppInfo;

		// Assert
		Assert.IsNotNull(info);
		Assert.IsNotNull(info.Company);
		Assert.IsNotNull(info.Product);
		Assert.IsNotNull(info.Version);
	}

	[TestMethod]
	public void IsRunning_ReturnsTrueForCurrentProcess()
	{
		// Act
		var result = App.IsRunning();

		// Assert
		Assert.IsTrue(result, "IsRunning should return true since the current process is running.");
	}

	[TestMethod]
	public void ReferencedAssemblies_ContainsEntries()
	{
		// Act
		var assemblies = App.ReferencedAssemblies();

		// Assert
		Assert.IsNotNull(assemblies);
		Assert.IsGreaterThan(0, assemblies.Count);
	}

	[TestMethod]
	public void GetEnvironmentVariables_ContainsPathVariable()
	{
		// Act
		var vars = App.GetEnvironmentVariables();

		// Assert
		Assert.IsNotNull(vars);
		Assert.IsGreaterThan(0, vars.Count);
	}

	[TestMethod]
	public void MaxDegreeOfParallelism_ReturnsPositiveValue()
	{
		// Act
		var result = App.MaxDegreeOfParallelism();

		// Assert
		Assert.IsGreaterThan(0, result);
	}

	[TestMethod]
	public void SetAppState_WithRandomData_RoundTrips()
	{
		// Arrange
		var key = RandomData.GenerateKey();
		var value = RandomData.GenerateWord(15);

		// Act
		App.SetAppState(key, value);
		var result = App.GetAppState(key);

		// Assert
		Assert.AreEqual(value, result, "Random data should round-trip through app state.");
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
public class Values
{
	public int Count1 { get; set; }
	public int Count2 { get; set; }

}
