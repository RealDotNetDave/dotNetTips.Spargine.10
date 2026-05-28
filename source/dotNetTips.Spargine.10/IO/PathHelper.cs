// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-23-2026
// ***********************************************************************
// <copyright file="PathHelper.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Common methods for path manipulation, encompassing handling invalid filter characters, invalid path names, and path separators.</summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Provides utility methods for path manipulation and validation, including combining paths, ensuring trailing slashes, and checking for invalid characters.
/// </summary>
/// <remarks>
/// This class offers a variety of static methods to assist with common path manipulation tasks such as combining paths, ensuring paths end with a directory separator,
/// and validating paths for invalid characters. It is designed to simplify file system operations by abstracting complex checks and operations into straightforward method calls.
/// </remarks>
[Information(nameof(PathHelper), Documentation = "https://bit.ly/SparginePathHelper", Status = Status.Available)]
public static class PathHelper
{

	/// <summary>
	/// The invalid file name characters, excluding '*', '|', and '?'.
	/// </summary>
	/// <remarks>
	/// This array is derived from <see cref="FileHelper.InvalidFileNameChars"/> by filtering out specific characters.
	/// It is used to validate file names by checking against characters that are not allowed in file names according to the file system.
	/// </remarks>
	[SupportedOSPlatform("windows")]
	private static readonly char[] InvalidFileNameChars = [.. FileHelper.InvalidFileNameChars.Except(['*', '|', '?'])];

	/// <summary>
	/// The invalid path characters, excluding directory separator characters.
	/// </summary>
	/// <remarks>
	/// This array is derived from <see cref="Path.GetInvalidPathChars"/> by filtering out the directory separator characters
	/// <see cref="Path.DirectorySeparatorChar"/> and <see cref="Path.AltDirectorySeparatorChar"/>.
	/// It is used to validate paths by checking against characters that are not allowed in paths according to the file system.
	/// </remarks>
	private static readonly char[] InvalidPathChars = [.. Path.GetInvalidPathChars().Except([Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar])];

	/// <summary>
	/// Gets the path separators used in file paths.
	/// </summary>
	/// <value>
	/// A read-only collection of characters used as path separators, specifically the
	/// <see cref="Path.DirectorySeparatorChar"/> and <see cref="Path.AltDirectorySeparatorChar"/>.
	/// </value>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<char> PathSeparators { get; } =
		new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar }.AsReadOnly();

	/// <summary>
	/// Combines the paths into a single path. If <paramref name="createIfNotExists"/> is true, the combined path will be created if it does not exist.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c>, the combined path will be created if it does not exist.</param>
	/// <param name="paths">The paths to combine.</param>
	/// <returns>A <see cref="DirectoryInfo"/> object for the combined path.</returns>
	/// <example>
	/// Here is how you can use the CombinePaths method:
	/// <code>
	/// var combinedPathInfo = PathHelper.CombinePaths(true, "C:\\path1", "path2", "path3");
	/// Console.WriteLine(combinedPathInfo.FullName);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [DisallowNull] params string[] paths)
	{
		paths = paths.ArgumentItemsExists(nameof(paths));

		var pathsCount = paths.LongLength;

		for (var paramCount = 0; paramCount < pathsCount; paramCount++)
		{
			paths[paramCount] = paths[paramCount].ToTrimmed()!;
		}

		return EnsureDirectoryCreated(new DirectoryInfo(Path.Combine(paths)), createIfNotExists);
	}

	/// <summary>
	/// Combines two specified path strings into a single path. If <paramref name="createIfNotExists"/> is set to <c>true</c>, the combined path will be created if it does not exist.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c>, the combined path will be created if it does not exist.</param>
	/// <param name="path1">The first path to combine.</param>
	/// <param name="path2">The second path to combine.</param>
	/// <returns>A <see cref="DirectoryInfo"/> object for the combined path.</returns>
	/// <example>
	/// Here is how you can use the CombinePaths method:
	/// <code>
	/// var combinedPathInfo = PathHelper.CombinePaths(true, "C:\\path1", "path2");
	/// Console.WriteLine(combinedPathInfo.FullName);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [DisallowNull] string path1, [DisallowNull] string path2)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();

		return CombinePaths(createIfNotExists, [path1, path2]);
	}

	/// <summary>
	/// Combines three specified path strings into a single path. If <paramref name="createIfNotExists"/> is set to <c>true</c>, the combined path will be created if it does not exist.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c>, the combined path will be created if it does not exist.</param>
	/// <param name="path1">The first path to combine.</param>
	/// <param name="path2">The second path to combine.</param>
	/// <param name="path3">The third path to combine.</param>
	/// <returns>A <see cref="DirectoryInfo"/> object for the combined path.</returns>
	/// <example>
	/// Here is how you can use the CombinePaths method:
	/// <code>
	/// var combinedPathInfo = PathHelper.CombinePaths(true, "C:\\path1", "path2", "path3");
	/// Console.WriteLine(combinedPathInfo.FullName);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [DisallowNull] string path1, [DisallowNull] string path2, [DisallowNull] string path3)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();
		path3 = path3.ArgumentNotNullOrEmpty();

		return CombinePaths(createIfNotExists, [path1, path2, path3]);
	}

	/// <summary>
	/// Combines four specified path strings into a single path. If <paramref name="createIfNotExists"/> is set to <c>true</c>, the combined path will be created if it does not exist.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c>, the combined path will be created if it does not exist.</param>
	/// <param name="path1">The first path to combine.</param>
	/// <param name="path2">The second path to combine.</param>
	/// <param name="path3">The third path to combine.</param>
	/// <param name="path4">The fourth path to combine.</param>
	/// <returns>A <see cref="DirectoryInfo"/> object for the combined path.</returns>
	/// <example>
	/// Here is how you can use the CombinePaths method:
	/// <code>
	/// var combinedPathInfo = PathHelper.CombinePaths(true, "C:\\path1", "path2", "path3", "path4");
	/// Console.WriteLine(combinedPathInfo.FullName);
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.Completed, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [DisallowNull] string path1, [DisallowNull] string path2, [DisallowNull] string path3, [DisallowNull] string path4)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();
		path3 = path3.ArgumentNotNullOrEmpty();
		path4 = path4.ArgumentNotNullOrEmpty();

		var paths = new string[] { path1, path2, path3, path4 };

		return CombinePaths(createIfNotExists, paths);
	}

	/// <summary>
	/// Ensures that the specified path ends with a directory separator character.
	/// </summary>
	/// <param name="path">The path to modify.</param>
	/// <returns>The modified path that ends with a directory separator character.</returns>
	/// <example>
	/// Here is how you can use the EnsureTrailingSlash method:
	/// <code>
	/// string path = "C:\\MyDirectory";
	/// string result = PathHelper.EnsureTrailingSlash(path);
	/// Console.WriteLine(result); // Output: C:\MyDirectory\
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string EnsureTrailingSlash([DisallowNull] string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		if (!path.EndsWith(Path.DirectorySeparatorChar))
		{
			path += Path.DirectorySeparatorChar;
		}

		return path;
	}

	/// <summary>
	/// Determines whether the specified filter contains any invalid characters.
	/// </summary>
	/// <param name="filter">The filter string to check.</param>
	/// <returns><c>true</c> if the specified filter contains invalid characters; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the HasInvalidFilterChars method:
	/// <code>
	/// string filter = "filename?.txt";
	/// bool result = PathHelper.HasInvalidFilterChars(filter);
	/// Console.WriteLine(result); // Output: True
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool HasInvalidFilterChars([DisallowNull] string filter)
	{
		filter = filter.ArgumentNotNullOrEmpty();

		return filter.IndexOfAny(InvalidFileNameChars) != -1;
	}

	/// <summary>
	/// Gets the invalid filter characters, excluding wildcards.
	/// </summary>
	/// <returns>A read-only collection of characters that are invalid in file names, excluding wildcard characters.</returns>
	/// <example>
	/// Here is how you can retrieve the invalid filter characters:
	/// <code>
	/// var invalidChars = PathHelper.InvalidFilterChars();
	/// foreach (var c in invalidChars)
	/// {
	///     Console.Write(c + ", ");
	/// }
	/// </code>
	/// </example>
	[SupportedOSPlatform("windows")]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<char> InvalidFilterChars()
	{
		return InvalidFileNameChars.AsReadOnly();
	}

	/// <summary>
	/// Gets the invalid path name characters, excluding directory separators.
	/// </summary>
	/// <returns>A read-only collection of characters that are invalid in path names, excluding directory separator characters.</returns>
	/// <example>
	/// Here is how you can retrieve the invalid path name characters:
	/// <code>
	/// var invalidChars = PathHelper.InvalidPathNameChars();
	/// foreach (var c in invalidChars)
	/// {
	///     Console.Write(c + ", ");
	/// }
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static ReadOnlyCollection<char> InvalidPathNameChars()
	{
		return InvalidPathChars.AsReadOnly();
	}

	/// <summary>
	/// Checks to see if the path contains any wildcards ('*' or '?').
	/// </summary>
	/// <param name="path">The path to check.</param>
	/// <returns><c>true</c> if the path contains wildcards; otherwise, <c>false</c>.</returns>
	/// <example>
	/// Here is how you can use the PathContainsWildcard method:
	/// <code>
	/// string path = "C:\\MyDirectory\\*.txt";
	/// bool containsWildcard = PathHelper.PathContainsWildcard(path);
	/// Console.WriteLine(containsWildcard); // Output: True
	/// </code>
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PathContainsWildcard), author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool PathContainsWildcard([DisallowNull] string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		return path.Contains('*', StringComparison.Ordinal) || path.Contains('?', StringComparison.Ordinal);
	}

	/// <summary>
	/// Determines if the path has invalid characters.
	/// </summary>
	/// <param name="path">The path to check for invalid characters.</param>
	/// <returns><c>true</c> if the path contains any characters that are invalid in file and directory paths; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// This method checks the path against a set of characters that are not allowed in file and directory paths, as defined by the operating system.
	/// The invalid characters are obtained from <see cref="InvalidPathNameChars"/>, which excludes directory separator characters.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static bool PathHasInvalidChars([DisallowNull] string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		return path.IndexOfAny(InvalidPathChars) != -1;
	}

	/// <summary>
	/// Creates the directory represented by <paramref name="di"/> if <paramref name="create"/> is <c>true</c> and the directory does not already exist.
	/// </summary>
	/// <param name="di">The <see cref="DirectoryInfo"/> representing the directory to potentially create.</param>
	/// <param name="create">If <c>true</c>, the directory will be created when it does not exist.</param>
	/// <returns>The <paramref name="di"/> instance, regardless of whether the directory was created.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureDirectoryCreated), author: "David McCarter", createdOn: "8/10/2020", UnitTestStatus = UnitTestStatus.NotRequired, BenchmarkStatus = BenchmarkStatus.NotRequired, Status = Status.Available)]
	private static DirectoryInfo EnsureDirectoryCreated(DirectoryInfo di, bool create)
	{
		if (create && di.CheckExists() is false)
		{
			di.Create();
		}

		return di;
	}
}
