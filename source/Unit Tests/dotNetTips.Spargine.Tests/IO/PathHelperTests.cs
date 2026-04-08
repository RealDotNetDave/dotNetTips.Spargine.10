// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 06-24-2024
//
// Last Modified By : Copilot Agent
// Last Modified On : 04-08-2026
// ***********************************************************************
// <copyright file="PathHelperTests.cs" company="dotNetTips.com - McCarter Consulting">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)
namespace DotNetTips.Spargine.Tests.IO;

[ExcludeFromCodeCoverage]
[TestClass]
public class PathHelperTests : IDisposable
{

	private readonly string _testDirectory = Path.Combine(Path.GetTempPath(), "PathHelperTests");

	public PathHelperTests()
	{
		if (Directory.Exists(this._testDirectory))
		{
			Directory.Delete(this._testDirectory, true);
		}
	}

	[TestMethod]
	public void CombinePaths_FourStrings_CreateIfNotExistsTrue_DirectoryCreated()
	{
		var result = PathHelper.CombinePaths(true, this._testDirectory, "SubDirectory", "SubSubDirectory", "SubSubSubDirectory");
		Assert.IsTrue(result.CheckExists());
	}

	[TestMethod]
	public void CombinePaths_ParamsStringArray_CreateIfNotExistsFalse_DirectoryNotCreated()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, "SubDirectory1", "SubDirectory2");
		Assert.IsFalse(result.CheckExists());
	}

	[TestMethod]
	public void CombinePaths_ParamsStringArray_CreateIfNotExistsTrue_DirectoryCreated()
	{
		var result = PathHelper.CombinePaths(true, this._testDirectory, "SubDirectory1", "SubDirectory2");
		Assert.IsTrue(result.CheckExists());
	}

	[TestMethod]
	public void CombinePaths_ParamsStringArray_NullPaths_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, null));
	}

	[TestMethod]
	public void CombinePaths_ThreeStrings_CreateIfNotExistsTrue_DirectoryCreated()
	{
		var result = PathHelper.CombinePaths(true, this._testDirectory, "SubDirectory", "SubSubDirectory");
		Assert.IsTrue(result.CheckExists());
	}

	[TestMethod]
	public void CombinePaths_TwoStrings_CreateIfNotExistsTrue_DirectoryCreated()
	{
		var result = PathHelper.CombinePaths(true, this._testDirectory, "SubDirectory");
		Assert.IsTrue(result.CheckExists());
	}

	[TestMethod]
	public void CombinePathsFourStringsCreateIfNotExistsFalseDirectoryNotCreated()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, "SubA", "SubB", "SubC");
		Assert.IsFalse(result.CheckExists());
	}

	[TestMethod]
	public void CombinePathsFourStringsNullPath1ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, null, "b", "c", "d"));
	}

	[TestMethod]
	public void CombinePathsFourStringsNullPath2ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, "a", null, "c", "d"));
	}

	[TestMethod]
	public void CombinePathsFourStringsNullPath3ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, "a", "b", null, "d"));
	}

	[TestMethod]
	public void CombinePathsFourStringsNullPath4ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, "a", "b", "c", null));
	}

	[TestMethod]
	public void CombinePathsFourStringsEmptyPath1ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, string.Empty, "b", "c", "d"));
	}

	[TestMethod]
	public void CombinePathsFourStringsReturnsCorrectFullName()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, "A", "B", "C");
		var expected = Path.Combine(this._testDirectory, "A", "B", "C");
		Assert.AreEqual(expected, result.FullName);
	}

	[TestMethod]
	public void CombinePathsParamsEmptyArrayThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, Array.Empty<string>()));
	}

	[TestMethod]
	public void CombinePathsParamsReturnsCorrectFullName()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, "Dir1", "Dir2");
		var expected = Path.Combine(this._testDirectory, "Dir1", "Dir2");
		Assert.AreEqual(expected, result.FullName);
	}

	[TestMethod]
	public void CombinePathsParamsTrimsWhitespaceFromPaths()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, " SubDir ");
		var expected = Path.Combine(this._testDirectory, "SubDir");
		Assert.AreEqual(expected, result.FullName);
	}

	[TestMethod]
	public void CombinePathsThreeStringsCreateIfNotExistsFalseDirectoryNotCreated()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, "SubA", "SubB");
		Assert.IsFalse(result.CheckExists());
	}

	[TestMethod]
	public void CombinePathsThreeStringsEmptyPath1ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, string.Empty, "b", "c"));
	}

	[TestMethod]
	public void CombinePathsThreeStringsNullPath1ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, null, "b", "c"));
	}

	[TestMethod]
	public void CombinePathsThreeStringsNullPath2ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, "a", null, "c"));
	}

	[TestMethod]
	public void CombinePathsThreeStringsNullPath3ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, "a", "b", null));
	}

	[TestMethod]
	public void CombinePathsThreeStringsReturnsCorrectFullName()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, "X", "Y");
		var expected = Path.Combine(this._testDirectory, "X", "Y");
		Assert.AreEqual(expected, result.FullName);
	}

	[TestMethod]
	public void CombinePathsTwoStringsCreateIfNotExistsFalseDirectoryNotCreated()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, "SubA");
		Assert.IsFalse(result.CheckExists());
	}

	[TestMethod]
	public void CombinePathsTwoStringsEmptyPath1ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, string.Empty, "b"));
	}

	[TestMethod]
	public void CombinePathsTwoStringsEmptyPath2ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, "a", string.Empty));
	}

	[TestMethod]
	public void CombinePathsTwoStringsNullPath1ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, null, "b"));
	}

	[TestMethod]
	public void CombinePathsTwoStringsNullPath2ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.CombinePaths(true, "a", null));
	}

	[TestMethod]
	public void CombinePathsTwoStringsReturnsCorrectFullName()
	{
		var result = PathHelper.CombinePaths(false, this._testDirectory, "SubDir");
		var expected = Path.Combine(this._testDirectory, "SubDir");
		Assert.AreEqual(expected, result.FullName);
	}

	public void Dispose()
	{
		if (Directory.Exists(this._testDirectory))
		{
			Directory.Delete(this._testDirectory, true);
		}
	}

	[TestMethod]
	public void EnsureTrailingSlashAlreadyHasDirectorySeparatorReturnsSamePath()
	{
		var path = $"C:{Path.DirectorySeparatorChar}TestPath{Path.DirectorySeparatorChar}";
		var result = PathHelper.EnsureTrailingSlash(path);
		Assert.AreEqual(path, result);
	}

	[TestMethod]
	public void EnsureTrailingSlash_EmptyString_ThrowsArgumentException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.EnsureTrailingSlash(string.Empty));
	}

	[TestMethod]
	public void EnsureTrailingSlash_Null_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.EnsureTrailingSlash(null));
	}

	[TestMethod]
	public void EnsureTrailingSlash_WithAltDirectorySeparatorChar_ReturnsPathWithSlash()
	{
		var pathWithAltSlash = "C:/TestPath";
		var expected = "C:/TestPath\\";
		var result = PathHelper.EnsureTrailingSlash(pathWithAltSlash);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void EnsureTrailingSlash_WithForwardSlash_ReturnsPathWithCorrectTrailingSlash()
	{
		var pathWithForwardSlash = "C:/TestPath";
		// Dynamically determine the expected trailing character based on the current platform
		var expected = $"C:/TestPath{Path.DirectorySeparatorChar}";

		var result = PathHelper.EnsureTrailingSlash(pathWithForwardSlash);

		// This assertion now respects the system's directory separator character
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void EnsureTrailingSlash_WithoutTrailingSlash_ReturnsPathWithSlash()
	{
		var pathWithoutSlash = "C:\\TestPath";
		var expected = pathWithoutSlash + "\\";
		var result = PathHelper.EnsureTrailingSlash(pathWithoutSlash);
		Assert.AreEqual(expected, result);
	}

	[TestMethod]
	public void EnsureTrailingSlash_WithTrailingSlash_ReturnsSamePath()
	{
		var pathWithSlash = "C:\\TestPath\\";
		var result = PathHelper.EnsureTrailingSlash(pathWithSlash);
		Assert.AreEqual(pathWithSlash, result);
	}

	[TestMethod]
	public void HasInvalidFilterChars_NullFilter_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.HasInvalidFilterChars(null));
	}
	[TestMethod]
	public void HasInvalidFilterChars_WithInvalidChars_ReturnsTrue()
	{
		var filter = "filename<>.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsTrue(result, "Expected to find invalid characters in the filter.");
	}

	[TestMethod]
	public void HasInvalidFilterChars_WithInvalidPathChars_ReturnsTrue()
	{
		var filter = "filename<|>.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsTrue(result, "Expected to find invalid path characters in the filter.");
	}

	[TestMethod]
	public void HasInvalidFilterChars_WithValidChars_ReturnsFalse()
	{
		var filter = "filename.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsFalse(result, "Expected no invalid characters in the filter.");
	}

	[TestMethod]
	public void HasInvalidFilterChars_WithWildcardChars_ReturnsFalse()
	{
		var filter = "filename*.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsFalse(result, "Wildcards should not be considered as invalid characters.");
	}

	[TestMethod]
	public void HasInvalidFilterCharsEmptyFilterThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.HasInvalidFilterChars(string.Empty));
	}

	[TestMethod]
	public void HasInvalidFilterCharsQuestionMarkWildcardReturnsFalse()
	{
		var filter = "file?.txt";
		var result = PathHelper.HasInvalidFilterChars(filter);
		Assert.IsFalse(result, "Wildcard '?' should not be considered as an invalid filter character.");
	}

	[TestMethod]
	public void InvalidFilterChars_ExcludesWildcards()
	{
		var invalidChars = PathHelper.InvalidFilterChars();
		Assert.DoesNotContain('*', invalidChars, "The InvalidFilterChars method should not include the '*' wildcard character.");
		Assert.DoesNotContain('?', invalidChars, "The InvalidFilterChars method should not include the '?' wildcard character.");
	}

	[TestMethod]
	public void InvalidFilterCharsExcludesPipe()
	{
		var invalidChars = PathHelper.InvalidFilterChars();
		Assert.DoesNotContain('|', invalidChars, "The InvalidFilterChars method should not include the '|' pipe character.");
	}

	[TestMethod]
	public void InvalidFilterCharsReturnsNonEmptyCollection()
	{
		var invalidChars = PathHelper.InvalidFilterChars();
		Assert.IsTrue(invalidChars.Count > 0, "InvalidFilterChars should return a non-empty collection.");
	}

	[TestMethod]
	public void InvalidPathNameChars_ExcludesDirectorySeparators()
	{
		var invalidChars = PathHelper.InvalidPathNameChars();
		Assert.DoesNotContain(Path.DirectorySeparatorChar, invalidChars, "The InvalidPathNameChars method should not include the directory separator character.");
		Assert.DoesNotContain(Path.AltDirectorySeparatorChar, invalidChars, "The InvalidPathNameChars method should not include the alternate directory separator character.");
	}

	[TestMethod]
	public void InvalidPathNameChars_ReturnsExpectedCharacters()
	{
		var invalidChars = PathHelper.InvalidPathNameChars();
		var expectedChars = Path.GetInvalidPathChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();
		CollectionAssert.AreEquivalent(expectedChars, invalidChars.ToList(), "The InvalidPathNameChars method did not return the expected characters.");
	}

	[TestMethod]
	public void InvalidPathNameCharsReturnsNonEmptyCollection()
	{
		var invalidChars = PathHelper.InvalidPathNameChars();
		Assert.IsTrue(invalidChars.Count > 0, "InvalidPathNameChars should return a non-empty collection.");
	}

	[TestMethod]
	public void InvalidPathNameCharsReturnsSameResultsOnMultipleCalls()
	{
		var first = PathHelper.InvalidPathNameChars();
		var second = PathHelper.InvalidPathNameChars();
		CollectionAssert.AreEquivalent(first.ToList(), second.ToList(), "InvalidPathNameChars should return consistent results across calls.");
	}

	[TestMethod]
	public void PathContainsWildcard_NullPath_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.PathContainsWildcard(null));
	}

	[TestMethod]
	public void PathContainsWildcard_WithBothWildcards_ReturnsTrue()
	{
		var path = "C:\\MyDirectory\\*?.txt";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsTrue(result, "Expected to find both '*' and '?' wildcards in the path.");
	}

	[TestMethod]
	public void PathContainsWildcard_WithoutWildcard_ReturnsFalse()
	{
		var path = "C:\\MyDirectory\\file.txt";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsFalse(result, "Expected not to find any wildcards in the path.");
	}

	[TestMethod]
	public void PathContainsWildcard_WithPathSeparator_ReturnsFalse()
	{
		var path = "C:\\MyDirectory\\";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsFalse(result, "Path separator should not be considered as a wildcard.");
	}

	[TestMethod]
	public void PathContainsWildcard_WithWildcardQuestion_ReturnsTrue()
	{
		var path = "C:\\MyDirectory\\?.txt";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsTrue(result, "Expected to find a wildcard '?' in the path.");
	}

	[TestMethod]
	public void PathContainsWildcard_WithWildcardStar_ReturnsTrue()
	{
		var path = "C:\\MyDirectory\\*.txt";
		var result = PathHelper.PathContainsWildcard(path);
		Assert.IsTrue(result, "Expected to find a wildcard '*' in the path.");
	}

	[TestMethod]
	public void PathContainsWildcardEmptyPathThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.PathContainsWildcard(string.Empty));
	}

	[TestMethod]
	public void PathHasInvalidChars_NullPath_ThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.PathHasInvalidChars(null));
	}

	[TestMethod]
	public void PathHasInvalidChars_WithDirectorySeparatorsOnly_ReturnsFalse()
	{
		var path = "C:\\TestPath\\Valid\\Name\\";
		var result = PathHelper.PathHasInvalidChars(path);
		Assert.IsFalse(result, "Directory separators should not be considered as invalid characters.");
	}

	[TestMethod]
	public void PathHasInvalidChars_WithPathSeparator_ReturnsFalse()
	{
		var path = "C:\\MyDirectory\\";
		var result = PathHelper.PathHasInvalidChars(path);
		Assert.IsFalse(result, "Path separator should not be considered as an invalid character.");
	}

	[TestMethod]
	public void PathHasInvalidChars_WithValidChars_ReturnsFalse()
	{
		var path = "C:\\TestPath\\ValidName.txt";
		var result = PathHelper.PathHasInvalidChars(path);
		Assert.IsFalse(result, "Expected no invalid characters in the path.");
	}

	[TestMethod]
	public void PathHasInvalidCharsEmptyPathThrowsArgumentNullException()
	{
		Assert.ThrowsExactly<ArgumentNullException>(() => PathHelper.PathHasInvalidChars(string.Empty));
	}

	[TestMethod]
	public void PathHasInvalidCharsWithInvalidCharsReturnsTrue()
	{
		var invalidChars = PathHelper.InvalidPathNameChars();

		if (invalidChars.Count > 0)
		{
			var path = $"C:\\TestPath\\Invalid{invalidChars[0]}Name.txt";
			var result = PathHelper.PathHasInvalidChars(path);
			Assert.IsTrue(result, "Expected to find invalid characters in the path.");
		}
	}

	[TestMethod]
	public void PathSeparators_ReturnsExpectedSeparators()
	{
		var expectedSeparators = new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };
		var separators = PathHelper.PathSeparators;

		Assert.HasCount(expectedSeparators.Length, separators, "The count of path separators does not match the expected count.");

		foreach (var separator in expectedSeparators)
		{
			Assert.Contains(separator, separators, $"The expected separator '{separator}' was not found in the PathSeparators collection.");
		}
	}

	[TestMethod]
	public void PathSeparatorsContainsTwoElements()
	{
		var separators = PathHelper.PathSeparators;
		Assert.HasCount(2, separators, "PathSeparators should contain exactly two elements.");
	}

	[TestMethod]
	public void PathSeparatorsReturnsSameResultsOnMultipleCalls()
	{
		var first = PathHelper.PathSeparators;
		var second = PathHelper.PathSeparators;
		CollectionAssert.AreEquivalent(first.ToList(), second.ToList(), "PathSeparators should return consistent results across calls.");
	}
}
