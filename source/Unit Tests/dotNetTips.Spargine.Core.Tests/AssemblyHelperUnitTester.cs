// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 04-09-2025
//
// Last Modified By : David McCarter
// Last Modified On : 11-13-2025
// ***********************************************************************
// <copyright file="AssemblyHelperUnitTester.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.IO;
using DotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://bit.ly/Spargine )

namespace DotNetTips.Spargine.Core.Tests;

[TestClass]
public class AssemblyHelperUnitTester : UnitTester
{
	//TODO: ADD MISSING TESTS

	const string SDKVersion = "10.0.100";

	private string _testOutputDirectory;
	private TestUnitTester _unitTester;

	[TestCleanup]
	public void Cleanup()
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
		var referencedAssemblyName = "NonExistentAssembly";

		// Act
		var result = AssemblyHelper.DoesAssemblyReference(assemblyFile, referencedAssemblyName);

		// Assert
		Assert.IsFalse(result, $"Expected the assembly not to reference {referencedAssemblyName}, but it does.");
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
		Assert.IsTrue(result.Count > 500);

		//Export to file
		var query = result.Where(p => p.FullName.StartsWith("DotNetTips") == false && p.DeclaringType == null).OrderBy(p => p.Assembly.FullName).ThenBy(p => p.Name).ToArray();

		var sb = new StringBuilder();

		foreach (var item in query)
		{
			sb.AppendLine(TypeHelper.GetTypeDisplayName(item, fullName: true, includeGenericParameterNames: true, includeGenericParameters: true));
		}

		File.WriteAllText(@"C:\dotNetTips.com\IDisposableTypes-10.txt", sb.ToString());

		var dir = new DirectoryInfo("C:\\Windows\\assembly\\NativeImages_v4.0.30319_64");

		var files = DirectoryHelper.SafeFileSearch(dir, "*.dll", SearchOption.AllDirectories).Where(p => AssemblyHelper.IsDotNetAssembly(p)).ToArray();

		//		var assembly = Assembly.LoadFile(Path.Combine(App.ProcessPath, "DotNetTips.Spargine.8.Benchmarking.dll"));
	}

	[TestMethod]
	public void FindNetSDKFiles_DotnetRootSet_ReturnsFiles()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles(null);

		// Assert
		Assert.IsNotNull(result);
		Assert.IsTrue(result.Count > 0, "Expected to find .NET SDK files, but none were found.");
	}

	[TestMethod]
	public void FindNetSDKFiles_NoMatchingVersion_ReturnsEmpty()
	{
		// Act
		var result = AssemblyHelper.GetNetSdkDllFiles("99.99.99");

		// Assert
		Assert.IsNotNull(result);
		Assert.AreEqual(0, result.Count, "Expected no .NET SDK files for version 99.99.99, but some were found.");
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
		Assert.IsTrue(result.Count > 0, "Expected to find .NET SDK files for version 10, but none were found.");
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
		Assert.IsTrue(foundTypes.Count > 100, "Expected to find types implementing IDisposable, but none were found.");
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
		Assert.AreEqual(0, result.Count, "Expected no types implementing ICloneable, but some were found.");
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
		Assert.IsTrue(result.Count > 0, "Expected to find types implementing Attribute, but none were found.");
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
		Assert.IsTrue(result.Count > 0, "Expected to find custom attributes, but none were found.");
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
			Assert.AreEqual(1, result.Count);
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
			Assert.AreEqual(1, result.Count);
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
		Assert.AreEqual(4, result.Count);
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
	public void GetDependentAssemblies_AssemblyWithNoDependencies_ReturnsEmptyCollection()
	{
		// Arrange
		var assemblyFile = new FileInfo(typeof(object).Assembly.Location); // mscorlib or System.Private.CoreLib

		// Act
		var dependentAssemblies = AssemblyHelper.GetDependentAssemblies(assemblyFile);

		// Assert
		Assert.IsNotNull(dependentAssemblies, "Expected a non-null collection of dependent assemblies.");
		Assert.AreEqual(0, dependentAssemblies.Count, "Expected an empty collection for an assembly with no dependencies.");
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
		Assert.IsTrue(dependentAssemblies.Count > 0, "Expected at least one dependent assembly.");
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
		Assert.AreEqual(0, methods.Count, "Expected an empty collection for a non-existent type.");
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
		Assert.IsTrue(methods.Count > 0, "Expected at least one method in the type.");
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
		Assert.AreEqual(0, publicTypes.Count, "Expected an empty collection for an assembly with no public types.");
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
		Assert.IsTrue(publicTypes.Count > 0, "Expected at least one public type in the assembly.");
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
		Assert.AreEqual(0, assemblies.Count, "Expected an empty collection for a directory with no assemblies.");

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
		Assert.AreEqual(0, assemblies.Count, "Expected an empty collection for an empty directory.");

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
		Assert.AreEqual(0, assemblies.Count, "Expected an empty collection for a non-existent directory.");
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
		Assert.IsTrue(assemblies.Count > 0, "Expected at least one assembly in the directory.");
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
		Assert.IsTrue(result.Count > 0, "Expected to find types in the assembly, but none were found.");
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

	[TestInitialize]
	public void Setup()
	{
		this._testOutputDirectory = Path.Combine(Path.GetTempPath(), "UnitTesterTests");
		Directory.CreateDirectory(this._testOutputDirectory);
		this._unitTester = new TestUnitTester(this._testOutputDirectory);
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

	private class TestUnitTester : UnitTester
	{
		public TestUnitTester(string outputDirectory = null) : base(outputDirectory) { }
	}
}
