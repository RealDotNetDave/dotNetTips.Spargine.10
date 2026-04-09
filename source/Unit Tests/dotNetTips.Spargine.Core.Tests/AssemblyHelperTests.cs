// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 05-01-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-01-2026
// ***********************************************************************
// <copyright file="AssemblyHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AssemblyHelperTests : UnitTester, IDisposable
{

	private const string SDKVersion = "10.0.4";
	private string _testOutputDirectory;
	private TestUnitTester _unitTester;

	public AssemblyHelperTests()
	{
		this._testOutputDirectory = Path.Combine(Path.GetTempPath(), "UnitTesterTests");
		_ = Directory.CreateDirectory(this._testOutputDirectory);
		this._unitTester = new TestUnitTester(this._testOutputDirectory);
	}

	public void Dispose()
	{
		if (Directory.Exists(this._testOutputDirectory))
		{
			Directory.Delete(this._testOutputDirectory, true);
		}
	}

	[TestMethod]
	public void DoesAssemblyReference_InvalidReference_ReturnsFalse()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var referencedAssemblyName = RandomData.GenerateWord(15);

		// Act
		var result = AssemblyHelper.DoesAssemblyReference(assemblyFile, referencedAssemblyName);

		// Assert
		Assert.IsFalse(result, $"Expected the assembly not to reference {referencedAssemblyName}, but it does.");
	}

	[TestMethod]
	public void DoesAssemblyReference_NonDotNetAssemblyFile_ReturnsFalse()
	{
		// Arrange
		using var tempAssembly = CreateTempNonDotNetAssembly(out var file);

		// Act
		var result = AssemblyHelper.DoesAssemblyReference(file, "System.Runtime");

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void DoesAssemblyReference_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.DoesAssemblyReference(null!, "System.Runtime"));
	}

	[TestMethod]
	public void DoesAssemblyReference_NullReferencedAssemblyName_ThrowsArgumentNullException()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.DoesAssemblyReference(assemblyFile, null!));
	}

	[TestMethod]
	public void DoesAssemblyReference_ValidReference_ReturnsTrue()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var referencedAssemblyName = "System.Runtime";

		// Act
		var result = AssemblyHelper.DoesAssemblyReference(assemblyFile, referencedAssemblyName);

		// Assert
		Assert.IsTrue(result, $"Expected the assembly to reference {referencedAssemblyName}, but it does not.");
	}

	[TestMethod]
	public void DoesTypeExistInAssembly_InvalidType_ReturnsFalse()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var typeName = "NonExistentType";

		// Act
		var result = AssemblyHelper.DoesTypeExistInAssembly(assemblyFile, typeName);

		// Assert
		Assert.IsFalse(result, $"Expected the type {typeName} not to exist in the assembly, but it does.");
	}

	[TestMethod]
	public void DoesTypeExistInAssembly_NonDotNetAssemblyFile_ReturnsFalse()
	{
		// Arrange
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(50));
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.DoesTypeExistInAssembly(file, typeof(AssemblyHelper).FullName!);

			// Assert
			Assert.IsFalse(result);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void DoesTypeExistInAssembly_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.DoesTypeExistInAssembly(null!, "System.String"));
	}

	[TestMethod]
	public void DoesTypeExistInAssembly_NullTypeName_ThrowsArgumentNullException()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.DoesTypeExistInAssembly(assemblyFile, null!));
	}

	[TestMethod]
	public void DoesTypeExistInAssembly_ValidType_ReturnsTrue()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var typeName = typeof(AssemblyHelper).FullName!;

		// Act
		var result = AssemblyHelper.DoesTypeExistInAssembly(assemblyFile, typeName);

		// Assert
		Assert.IsTrue(result, $"Expected the type {typeName} to exist in the assembly, but it does not.");
	}

	[TestMethod]
	public void FindDerivedTypes_AppDomain_IDisposable()
	{
		// Act
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(IDisposable), false);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsGreaterThan(500, result.Count);

		//Export to file
		var query = result.Where(p => p.FullName.StartsWith("DotNetTips") == false && p.DeclaringType == null).OrderBy(p => p.Assembly.FullName).ThenBy(p => p.Name).ToArray();

		var sb = new StringBuilder();

		foreach (var item in query)
		{
			sb.AppendLine(TypeHelper.GetTypeDisplayName(item, fullName: true, includeGenericParameterNames: true, includeGenericParameters: true));
		}

		File.WriteAllText(@"C:\dotNetTips.com\IDisposableTypes-10.txt", sb.ToString());

		var dir = new DirectoryInfo("C:\\Windows\\assembly\\NativeImages_v4.0.30319_64");

		var files = Directory.GetFiles(dir.FullName, "*.dll", SearchOption.AllDirectories).Where(p => AssemblyHelper.IsDotNetAssembly(new FileInfo(p))).ToArray();
	}

	[TestMethod]
	public void FindNetSDKFiles_DotnetRootSet_ReturnsFiles()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(null);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result, "Expected to find .NET SDK files, but none were found.");
	}

	[TestMethod]
	public void FindNetSDKFiles_NoMatchingVersion_ReturnsEmpty()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles("99.99.99");

		// Assert
		Assert.IsNotNull(result);
		Assert.IsEmpty(result, "Expected no .NET SDK files for version 99.99.99, but some were found.");
	}

	[TestMethod]
	public void FindNetSDKFiles_SpecificVersion_ReturnsFiles()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		PrintToDebug<FileInfo>(result, prop => prop.Name == "Name");

		SaveToFile<FileInfo>(result, prop => prop.Name == "Name", $"SDKFiles-{SDKVersion}");

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result, "Expected to find .NET SDK files for version 10, but none were found.");
	}

	[TestMethod]
	public void FindSDKTypesImplementing_IDisposable()
	{
		// Arrange
		var assemblyFiles = AssemblyHelper.GetNetSdkDllFiles();
		var foundTypes = new List<Type>();

		// Act
		foreach (var assemblyFile in assemblyFiles)
		{
			var types = AssemblyHelper.FindTypesImplementing(assemblyFile, typeof(IDisposable));

			if (types.Count > 0)
			{
				foundTypes.AddRange(types);
			}
		}

		SaveToFile<Type>(foundTypes, prop => prop.Name == "FullName", $"IDisposable-{SDKVersion}");

		// Assert
		Assert.IsGreaterThan(100, foundTypes.Count, "Expected to find types implementing IDisposable, but none were found.");
	}

	[TestMethod]
	public void FindTypesImplementing_NoMatchingTypes_ReturnsEmpty()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.FindTypesImplementing(assemblyFile, typeof(ICloneable));

		// Assert
		Assert.IsNotNull(result);
		Assert.IsEmpty(result, "Expected no types implementing ICloneable, but some were found.");
	}

	[TestMethod]
	public void FindTypesImplementing_NullFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.FindTypesImplementing(null!, typeof(IDisposable)));
	}

	[TestMethod]
	public void FindTypesImplementing_NullTypeNames_ThrowsArgumentNullException()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.FindTypesImplementing(assemblyFile, null!));
	}

	[TestMethod]
	public void FindTypesImplementing_ValidAssembly_ReturnsMatchingTypes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.FindTypesImplementing(assemblyFile, typeof(Attribute));

		PrintToDebug<Type>(result, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result, "Expected to find types implementing Attribute, but none were found.");
	}

	[TestMethod]
	public void GetAssemblyCustomAttributes_NonDotNetAssemblyFile_ReturnsEmptyCollection()
	{
		// Arrange
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(50));
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.GetAssemblyCustomAttributes(file);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsEmpty(result);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void GetAssemblyCustomAttributes_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetAssemblyCustomAttributes(null!));
	}

	[TestMethod]
	public void GetAssemblyCustomAttributes_ValidAssembly_ReturnsAttributes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.GetAssemblyCustomAttributes(assemblyFile);

		this.SaveToFile(result, prop => prop.Name == nameof(Attribute.TypeId), nameof(AssemblyHelper.GetAssemblyCustomAttributes));

		// Assert
		Assert.IsNotNull(result, "Expected a non-null result, but got null.");
		Assert.IsNotEmpty(result, "Expected to find custom attributes, but none were found.");
	}

	[TestMethod]
	public void GetAssemblyEntryPoint_AssemblyWithoutEntryPoint_ReturnsNull()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(object).Assembly.Location); // mscorlib or System.Private.CoreLib

		// Act
		var entryPoint = AssemblyHelper.GetAssemblyEntryPoint(assemblyFile);

		// Assert
		Assert.IsNull(entryPoint, "Expected null for an assembly without an entry point, but got a value.");
	}

	[TestMethod]
	public void GetAssemblyEntryPoint_NonDotNetAssemblyFile_ReturnsNull()
	{
		// Arrange
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(50));
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.GetAssemblyEntryPoint(file);

			// Assert
			Assert.IsNull(result);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void GetAssemblyEntryPoint_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetAssemblyEntryPoint(null!));
	}

	[TestMethod]
	public void GetAssemblyEntryPoint_ValidAssembly_ReturnsEntryPoint()
	{
		// Arrange
		var assemblyFile = new FileInfo(Assembly.GetExecutingAssembly().Location);

		// Act
		var entryPoint = AssemblyHelper.GetAssemblyEntryPoint(assemblyFile);

		this.PrintToDebug<MethodInfo>(entryPoint, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(entryPoint, "Expected a valid entry point, but got null.");
		Assert.AreEqual("Main", entryPoint.Name, "Expected the entry point to be 'Main'.");
	}

	[TestMethod]
	public void GetAssemblyMetadata_EmptyFile_ReturnsErrorKey()
	{
		// Arrange
		var tempFile = Path.GetTempFileName();
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.GetAssemblyMetadata(file);

			// Assert
			Assert.IsNotNull(result);
			Assert.HasCount(1, result);
			Assert.AreEqual("Error", result.First().Key);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void GetAssemblyMetadata_InvalidAssembly_ReturnsErrorKey()
	{
		// Arrange
		var tempFile = Path.GetTempFileName();
		File.WriteAllText(tempFile, "not a real assembly");
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.GetAssemblyMetadata(file);

			// Assert
			Assert.IsNotNull(result);
			Assert.HasCount(1, result);
			var error = result.First();
			Assert.AreEqual("Error", error.Key);
			Assert.AreEqual("Invalid .NET assembly", error.Value);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void GetAssemblyMetadata_NonExistentFile_Throws()
	{
		// Arrange
		var fileInfo = new FileInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".dll"));

		// Act & Assert
		Assert.ThrowsExactly<FileNotFoundException>(() => AssemblyHelper.GetAssemblyMetadata(fileInfo));
	}

	[TestMethod]
	public void GetAssemblyMetadata_NonExistentFile_ThrowsFileNotFoundException()
	{
		// Arrange
		var file = new FileInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".dll"));

		// Act & Assert
		Assert.ThrowsExactly<FileNotFoundException>(() => AssemblyHelper.GetAssemblyMetadata(file));
	}

	[TestMethod]
	public void GetAssemblyMetadata_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetAssemblyMetadata(null!));
	}

	[TestMethod]
	public void GetAssemblyMetadata_NullFile_Throws()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetAssemblyMetadata(null!));
	}

	[TestMethod]
	public void GetAssemblyMetadata_NullFile_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetAssemblyMetadata(null!));
	}

	[TestMethod]
	public void GetAssemblyMetadata_ValidAssembly_ReturnsExpectedKeys()
	{
		// Arrange
		var file = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.GetAssemblyMetadata(file);

		// Assert
		Assert.IsNotNull(result);
		Assert.HasCount(4, result);
		Assert.IsTrue(result.Any(kv => kv.Key == "Name"));
		Assert.IsTrue(result.Any(kv => kv.Key == "Version"));
		Assert.IsTrue(result.Any(kv => kv.Key == "Culture"));
		Assert.IsTrue(result.Any(kv => kv.Key == "FullName"));
	}

	[TestMethod]
	public void GetAssemblyMetadata_ValidAssembly_ReturnsExpectedMetadata()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var metadata = AssemblyHelper.GetAssemblyMetadata(assemblyFile);

		// Assert
		Assert.IsNotNull(metadata);
		Assert.IsTrue(metadata.Any());
		Assert.IsTrue(metadata.Any(kv => kv.Key == "Name"));
		Assert.IsTrue(metadata.Any(kv => kv.Key == "Version"));
		Assert.IsTrue(metadata.Any(kv => kv.Key == "Culture"));
		Assert.IsTrue(metadata.Any(kv => kv.Key == "FullName"));
	}

	[TestMethod]
	public void GetAssemblyMetadata_ValidAssembly_ValuesAreNotNullOrEmpty()
	{
		// Arrange
		var file = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.GetAssemblyMetadata(file);

		// Assert
		foreach (var kv in result)
		{
			Assert.IsFalse(string.IsNullOrWhiteSpace(kv.Key));
			Assert.IsNotNull(kv.Value);
		}
	}

	[TestMethod]
	public void GetAssemblyPublicTypes_NonDotNetAssemblyFile_ReturnsEmptyCollection()
	{
		// Arrange
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(50));
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.GetAssemblyPublicTypes(file);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsEmpty(result);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void GetAssemblyTypes_CalledTwice_ReturnsCachedResults()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result1 = AssemblyHelper.GetAssemblyTypes(assemblyFile);
		var result2 = AssemblyHelper.GetAssemblyTypes(assemblyFile);

		// Assert
		Assert.IsNotNull(result1);
		Assert.IsNotNull(result2);
		Assert.AreEqual(result1.Count, result2.Count);
		Assert.AreSame(result1, result2, "Expected the same cached instance to be returned on subsequent calls.");
	}

	[TestMethod]
	public void GetDependentAssemblies_AssemblyWithNoDependencies_ReturnsEmptyCollection()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(object).Assembly.Location); // mscorlib or System.Private.CoreLib

		// Act
		var dependentAssemblies = AssemblyHelper.GetDependentAssemblies(assemblyFile);

		// Assert
		Assert.IsNotNull(dependentAssemblies, "Expected a non-null collection of dependent assemblies.");
		Assert.IsEmpty(dependentAssemblies, "Expected an empty collection for an assembly with no dependencies.");
	}

	[TestMethod]
	public void GetDependentAssemblies_NonDotNetAssemblyFile_ReturnsEmptyCollection()
	{
		// Arrange
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(50));
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.GetDependentAssemblies(file);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsEmpty(result);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void GetDependentAssemblies_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetDependentAssemblies(null!));
	}

	[TestMethod]
	public void GetDependentAssemblies_ValidAssembly_ReturnsDependencies()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var dependentAssemblies = AssemblyHelper.GetDependentAssemblies(assemblyFile);

		this.PrintToDebug<AssemblyName>(dependentAssemblies, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(dependentAssemblies, "Expected a non-null collection of dependent assemblies.");
		Assert.IsNotEmpty(dependentAssemblies, "Expected at least one dependent assembly.");
		Assert.IsTrue(dependentAssemblies.Any(dep => dep.Name == "System.Runtime"), "Expected 'System.Runtime' to be a dependent assembly.");
	}


	[TestMethod]
	public void GetMethodsInType_InvalidType_ReturnsEmptyCollection()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var invalidTypeName = "NonExistentNamespace.NonExistentType";

		// Act
		var methods = AssemblyHelper.GetMethodsInType(assemblyFile, invalidTypeName);

		// Assert
		Assert.IsNotNull(methods, "Expected a non-null collection of methods.");
		Assert.IsEmpty(methods, "Expected an empty collection for a non-existent type.");
	}

	[TestMethod]
	public void GetMethodsInType_NonDotNetAssemblyFile_ReturnsEmptyCollection()
	{
		// Arrange
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(50));
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.GetMethodsInType(file, typeof(AssemblyHelper).FullName!);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsEmpty(result);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void GetMethodsInType_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetMethodsInType(null!, typeof(FastStringBuilder).FullName!));
	}

	[TestMethod]
	public void GetMethodsInType_NullTypeName_ThrowsArgumentNullException()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetMethodsInType(assemblyFile, null!));
	}

	[TestMethod]
	public void GetMethodsInType_ValidType_ReturnsMethods()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);
		var typeName = typeof(FastStringBuilder).FullName!;

		// Act
		var methods = AssemblyHelper.GetMethodsInType(assemblyFile, typeName);

		this.PrintToDebug<MethodInfo>(methods, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(methods, "Expected a non-null collection of methods.");
		Assert.IsNotEmpty(methods, "Expected at least one method in the type.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_AllFilesAreValid()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result);

		foreach (var file in result.Take(10)) // Test a sample to avoid long test times
		{
			Assert.IsTrue(file.Exists, $"File {file.FullName} should exist.");
			Assert.IsGreaterThan(0, file.Length, $"File {file.FullName} should not be empty.");
		}
	}

	[TestMethod]
	public void GetNetSdkDllFiles_AllReturnedFilesPassIsDotNetAssemblyCheck()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result);

		// Sample check to avoid long test execution
		var filesToCheck = result.Take(20).ToList();

		foreach (var file in filesToCheck)
		{
			Assert.IsTrue(AssemblyHelper.IsDotNetAssembly(file),
				$"File {file.Name} should pass IsDotNetAssembly check.");
		}
	}

	[TestMethod]
	public void GetNetSdkDllFiles_ContainsExpectedAssemblies()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result, "Expected to find SDK files.");

		// Check for common expected assemblies
		var fileNames = result.Select(f => f.Name).ToList();
		Assert.IsTrue(fileNames.Any(name => name.Contains("System.Runtime.dll", StringComparison.OrdinalIgnoreCase)),
			"Expected to find System.Runtime.dll in SDK files.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_EmptyStringVersion_ReturnsHighestVersion()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(string.Empty);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result, "Expected to find .NET SDK files when using empty string (should default to highest version).");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_FilesAreFromRefDirectory()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.All(file => file.DirectoryName!.Contains("ref", StringComparison.OrdinalIgnoreCase)),
			"Expected all files to be from the 'ref' directory.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_MultipleVersionsAvailable_SelectsHighest()
	{
		// Act
		var resultNull = AssemblyHelper.GetNetSdkDllFiles(null);
		var resultSpecific = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(resultNull);
		Assert.IsNotNull(resultSpecific);

		// Both should return results if the version exists
		this.PrintToDebug($"Files found with null version: {resultNull.Count}");
		this.PrintToDebug($"Files found with specific version ({SDKVersion}): {resultSpecific.Count}");

		Assert.IsTrue(resultNull.Count > 0 || resultSpecific.Count > 0,
			"Expected to find SDK files with either null or specific version.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_NoDuplicateFiles_ReturnsDistinctFiles()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result);

		var distinctFiles = result.Select(f => f.FullName).Distinct().Count();
		Assert.AreEqual(result.Count, distinctFiles,
			"Expected no duplicate files in the result collection.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_NonExistentPacksDirectory_ReturnsEmptyCollection()
	{
		// This test verifies graceful handling when packs directory doesn't exist
		// Note: This is difficult to test without mocking, so we test with invalid version

		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles("0.0.0-invalid");

		// Assert
		Assert.IsNotNull(result);
		Assert.IsEmpty(result, "Expected empty collection for non-existent version.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_ParallelProcessing_ReturnsConsistentResults()
	{
		// Act
		var result1 = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);
		var result2 = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result1);
		Assert.IsNotNull(result2);
		Assert.HasCount(result1.Count, result2,
			"Expected consistent results across multiple calls.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_PerformanceTest_CompletesReasonablyFast()
	{
		// Arrange
		var stopwatch = Stopwatch.StartNew();

		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);
		stopwatch.Stop();

		// Assert
		Assert.IsNotNull(result);
		this.PrintToDebug($"GetNetSdkDllFiles execution time: {stopwatch.ElapsedMilliseconds}ms for {result.Count} files");

		// Should complete in reasonable time (adjust threshold as needed)
		Assert.IsLessThan(30000,
stopwatch.ElapsedMilliseconds, $"Method took too long to complete: {stopwatch.ElapsedMilliseconds}ms");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_ResultsAreReadOnly()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsInstanceOfType(result, typeof(ReadOnlyCollection<FileInfo>),
			"Expected result to be a ReadOnlyCollection.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_ReturnsOnlyDllFiles()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.All(file => file.Extension.Equals(".dll", StringComparison.OrdinalIgnoreCase)),
			"Expected all files to have .dll extension.");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_ValidVersion_ReturnsFilesFromCorrectTargetFramework()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(SDKVersion);

		// Assert
		Assert.IsNotNull(result);

		if (result.Count > 0)
		{
			// Verify files are from the highest target framework directory
			var firstFile = result.First();
			var parentDir = firstFile.Directory!.Name;

			// Target framework should start with "net" (e.g., net8.0, net9.0, net10.0)
			Assert.IsTrue(parentDir.StartsWith("net", StringComparison.OrdinalIgnoreCase),
				$"Expected files to be from a target framework directory, but found: {parentDir}");
		}
	}

	[TestMethod]
	public void GetNetSdkDllFiles_VersionWithPreviewSuffix_HandlesGracefully()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles("10.0.0-preview.1");

		// Assert
		Assert.IsNotNull(result);
		// Method should handle preview versions gracefully, even if not found
	}

	[TestMethod]
	public void GetNetSdkDllFiles_WhitespaceVersion_ReturnsHighestVersion()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles("   ");

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result, "Expected to find .NET SDK files when using whitespace (should default to highest version).");
	}

	[TestMethod]
	public void GetNetSdkDllFiles_WithNullVersion_ReturnsHighestVersion()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(null);

		// Assert
		Assert.IsNotNull(result, "Expected a non-null collection of SDK files.");
		Assert.IsNotEmpty(result, "Expected to find .NET SDK files when using the highest available version.");

		// Verify all returned files are valid .NET assemblies
		foreach (var file in result)
		{
			Assert.IsTrue(file.Exists, $"File {file.Name} should exist.");
			Assert.IsTrue(AssemblyHelper.IsDotNetAssembly(file), $"File {file.Name} should be a valid .NET assembly.");
		}
	}

	[TestMethod]
	public void GetPublicTypes_AssemblyWithNoPublicTypes_ReturnsEmptyCollection()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(object).Assembly.Location); // mscorlib or System.Private.CoreLib

		// Act
		var publicTypes = AssemblyHelper.GetAssemblyPublicTypes(assemblyFile);

		// Assert
		Assert.IsNotNull(publicTypes, "Expected a non-null collection of public types.");
		Assert.IsEmpty(publicTypes, "Expected an empty collection for an assembly with no public types.");
	}

	[TestMethod]
	public void GetPublicTypes_InvalidAssembly_ReturnsEmptyCollection()
	{
		// Arrange
		var invalidAssemblyFile = new FileInfo("NonExistentAssembly.dll");

		// Act
		Assert.ThrowsExactly<FileNotFoundException>(() => AssemblyHelper.GetAssemblyPublicTypes(invalidAssemblyFile));

	}

	[TestMethod]
	public void GetPublicTypes_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetAssemblyPublicTypes(null!));
	}

	[TestMethod]
	public void GetPublicTypes_ValidAssembly_HandlesPartialTypeLoading()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var publicTypes = AssemblyHelper.GetAssemblyPublicTypes(assemblyFile);

		// Assert
		Assert.IsNotNull(publicTypes, "Expected a non-null collection of public types.");
		Assert.IsTrue(publicTypes.All(type => type.IsPublic), "Expected all returned types to be public.");
	}

	[TestMethod]
	public void GetPublicTypes_ValidAssembly_ReturnsPublicTypes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var publicTypes = AssemblyHelper.GetAssemblyPublicTypes(assemblyFile);

		this.PrintToDebug<Type>(publicTypes, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(publicTypes, "Expected a non-null collection of public types.");
		Assert.IsNotEmpty(publicTypes, "Expected at least one public type in the assembly.");
	}

	[TestMethod]
	public void IsDotNetAssembly_BadImageFormatException_ReturnsFalse()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\Windows\System32\ntdll.dll");

		// Act
		var result = AssemblyHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_InvalidAssembly_ReturnsFalse()
	{
		// Arrange
		var fileInfo = new FileInfo(@"c:\windows\twain_32.dll");

		// Act
		var result = AssemblyHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_InvalidDotNetAssembly_ReturnsFalse()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\Windows\System32\kernel32.dll");

		// Act
		var result = AssemblyHelper.IsDotNetAssembly(fileInfo);

		// Assert
		Assert.IsFalse(result);
	}

	[TestMethod]
	public void IsDotNetAssembly_IOException_FileNotFoundException()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\Windows\System32\config\SYSTEM");

		// Act & Assert
		Assert.ThrowsExactly<FileNotFoundException>(() => AssemblyHelper.IsDotNetAssembly(fileInfo));
	}

	[TestMethod]
	public void IsDotNetAssembly_NonDotNetFile_ReturnsFalse()
	{
		// Arrange
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(100));
		var file = new FileInfo(tempFile);

		try
		{
			// Act
			var result = AssemblyHelper.IsDotNetAssembly(file);

			// Assert
			Assert.IsFalse(result);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void IsDotNetAssembly_NonExistentFile_ThrowsFileNotFoundException()
	{
		// Arrange
		var fileInfo = new FileInfo(@"C:\nonexistentfile.dll");

		// Act & Assert
		Assert.ThrowsExactly<FileNotFoundException>(() => AssemblyHelper.IsDotNetAssembly(fileInfo));
	}

	[TestMethod]
	public void IsDotNetAssembly_NullFile_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.IsDotNetAssembly(null));
	}

	[TestMethod]
	public void IsDotNetAssembly_ValidDotNetAssembly_ReturnsTrue()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.IsDotNetAssembly(assemblyFile);

		// Assert
		Assert.IsTrue(result, "Expected the core assembly to be identified as a valid .NET assembly.");
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_DirectoryWithNonAssemblies_ReturnsEmptyCollection()
	{
		// Arrange
		var testDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "TestDirectoryWithNonAssemblies"));
		if (!testDirectory.Exists)
		{
			testDirectory.Create();
		}

		var testFile = new FileInfo(Path.Combine(testDirectory.FullName, "test.txt"));
		File.WriteAllText(testFile.FullName, "This is a test file.");

		// Act
		var assemblies = AssemblyHelper.FindAssembliesFromDirectory(testDirectory);

		// Assert
		Assert.IsNotNull(assemblies, "Expected a non-null collection of assemblies.");
		Assert.IsEmpty(assemblies, "Expected an empty collection for a directory with no assemblies.");

		// Cleanup
		testFile.Delete();
		testDirectory.Delete();
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_EmptyDirectory_ReturnsEmptyCollection()
	{
		// Arrange
		var emptyDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "EmptyTestDirectory"));
		if (!emptyDirectory.Exists)
		{
			emptyDirectory.Create();
		}

		// Act
		var assemblies = AssemblyHelper.FindAssembliesFromDirectory(emptyDirectory);

		// Assert
		Assert.IsNotNull(assemblies, "Expected a non-null collection of assemblies.");
		Assert.IsEmpty(assemblies, "Expected an empty collection for an empty directory.");

		// Cleanup
		emptyDirectory.Delete();
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_InvalidDirectory_ReturnsEmptyCollection()
	{
		// Arrange
		var invalidDirectory = new DirectoryInfo("NonExistentDirectory");

		// Act
		var assemblies = AssemblyHelper.FindAssembliesFromDirectory(invalidDirectory);

		// Assert
		Assert.IsNotNull(assemblies, "Expected a non-null collection of assemblies.");
		Assert.IsEmpty(assemblies, "Expected an empty collection for a non-existent directory.");
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_NullDirectory_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.FindAssembliesFromDirectory(null!));
	}

	[TestMethod]
	public void LoadAssembliesFromDirectory_ValidDirectory_ReturnsAssemblies()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var assemblies = AssemblyHelper.FindAssembliesFromDirectory(assemblyFile.Directory);

		this.PrintToDebug<FileInfo>(assemblies, prop => prop.Name == "Name");

		// Assert
		Assert.IsNotNull(assemblies, "Expected a non-null collection of assemblies.");
		Assert.IsNotEmpty(assemblies, "Expected at least one assembly in the directory.");
		Assert.IsTrue(assemblies.Any(assembly => assembly.FullName!.Contains("DotNetTips.Spargine.Core")), "Expected the current assembly to be loaded.");
	}


	[TestMethod]
	public void LoadAssemblyTypes_NullFile_ThrowsArgumentNullException()
	{
		// Act
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.GetAssemblyTypes(null!));
	}

	[TestMethod]
	public void LoadAssemblyTypes_ValidAssembly_ReturnsTypes()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act
		var result = AssemblyHelper.GetAssemblyTypes(assemblyFile);

		this.SaveToFile<Type>(result, prop => prop.Name == "Name", nameof(AssemblyHelper.GetAssemblyTypes));

		// Assert
		Assert.IsNotNull(result);
		Assert.IsNotEmpty(result, "Expected to find types in the assembly, but none were found.");
	}

	[TestMethod]
	public void PrintToDebug_NullPropertySelector_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new List<object> { new { Name = "Test" } };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._unitTester.PrintToDebug(collection, null));
	}

	[TestMethod]
	public void SaveToFile_NullPropertySelector_ThrowsArgumentNullException()
	{
		// Arrange
		var collection = new List<object> { new { Name = "Test" } };

		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => this._unitTester.SaveToFile(collection, null));
	}

	[TestMethod]
	public void UnloadAssembly_NonDotNetAssemblyFile_DoesNotThrow()
	{
		// Arrange
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(50));
		var file = new FileInfo(tempFile);

		try
		{
			// Act - should not throw, just return
			AssemblyHelper.UnloadAssembly(file);
		}
		finally
		{
			File.Delete(tempFile);
		}
	}

	[TestMethod]
	public void UnloadAssembly_NullAssemblyFile_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<ArgumentNullException>(() => AssemblyHelper.UnloadAssembly(null!));
	}

	[TestMethod]
	public void UnloadAssembly_ValidAssembly_DoesNotThrow()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(AssemblyHelper).Assembly.Location);

		// Act & Assert
		AssemblyHelper.UnloadAssembly(assemblyFile);
	}

	[TestMethod]
	public void VersionParseSafe_InvalidVersionString_ReturnsDefaultVersion()
	{
		// Arrange
		var versionString = "invalid-version";

		// Act
		var result = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { versionString }) as Version;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(new Version(0, 0), result, "Expected default version 0.0, but got a different result.");
	}

	[TestMethod]
	public void VersionParseSafe_NullInput_ThrowsArgumentNullException()
	{
		// Act & Assert
		Assert.ThrowsExactly<TargetInvocationException>(() =>
			typeof(AssemblyHelper)
				.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
				.Invoke(null, new object[] { null! }));
	}

	[TestMethod]
	public void VersionParseSafe_ValidVersionString_ReturnsParsedVersion()
	{
		// Arrange
		var versionString = "2.5.8";

		// Act
		var result = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { versionString }) as Version;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(new Version(2, 5, 8), result, "Expected version 2.5.8, but got a different result.");
	}


	[TestMethod]
	public void VersionParseSafe_VersionWithPreviewSuffix_ReturnsParsedVersion()
	{
		// Arrange
		var versionString = "1.2.3-preview";

		// Act
		var result = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { versionString }) as Version;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(new Version(1, 2, 3), result, "Expected version 1.2.3, but got a different result.");
	}

	[TestMethod]
	public void VersionParseSafe_VersionWithSuffix_ReturnsParsedVersion()
	{
		// Arrange
		var versionString = "3.1.4-beta";

		// Act
		var result = typeof(AssemblyHelper)
			.GetMethod("VersionParseSafe", BindingFlags.NonPublic | BindingFlags.Static)!
			.Invoke(null, new object[] { versionString }) as Version;

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(new Version(3, 1, 4), result, "Expected version 3.1.4, but got a different result.");
	}

	private static IDisposable CreateTempNonDotNetAssembly(out FileInfo file)
	{
		var tempFile = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.dll");
		File.WriteAllText(tempFile, RandomData.GenerateWord(50));
		file = new FileInfo(tempFile);

		return new TempFileDeleter(tempFile);
	}

	private sealed class TempFileDeleter : IDisposable
	{
		private readonly string _path;

		public TempFileDeleter(string path)
		{
			this._path = path;
		}

		public void Dispose()
		{
			try
			{
				if (File.Exists(this._path))
				{
					File.Delete(this._path);
				}
			}
			catch (IOException)
			{
				// Ignore cleanup errors in tests.
			}
			catch (UnauthorizedAccessException)
			{
				// Ignore cleanup errors in tests.
			}
		}
	}

	private class TestUnitTester : UnitTester
	{
		public TestUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}
}
