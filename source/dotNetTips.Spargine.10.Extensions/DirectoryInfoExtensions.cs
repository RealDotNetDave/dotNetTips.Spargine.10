// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-06-2026
// ***********************************************************************
// <copyright file="DirectoryInfoExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="System.IO.DirectoryInfo"/> that supplement its built-in API.
// Currently provides <c>GetSize</c>, which calculates the total byte size of files in a directory
// using a search pattern and <see cref="System.IO.SearchOption"/>.
// </summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Text;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="DirectoryInfo" /> that supplement its built-in API.
/// </summary>
/// <remarks>
/// Currently exposes <c>GetSize</c>, which enumerates files in a directory tree using a configurable
/// search pattern and <see cref="SearchOption" />, accumulating total file size in bytes while
/// safely skipping files that raise <see cref="IOException" />.
/// </remarks>
[Information(Status = Status.NeedsDocumentation)]
public static class DirectoryInfoExtensions
{
	/// <summary>
	/// Creates a temporary file in <paramref name="directory"/> and atomically moves it to <paramref name="destinationFileName"/>.
	/// </summary>
	/// <param name="directory">The directory where temp and destination files reside.</param>
	/// <param name="destinationFileName">The destination file name (not full path).</param>
	/// <param name="content">The content to write.</param>
	/// <param name="encoding">The text encoding to use. Defaults to UTF-8.</param>
	/// <returns>The destination <see cref="FileInfo"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directory"/>, <paramref name="destinationFileName"/>, or <paramref name="content"/> is null.</exception>
	[Information(nameof(CreateTempFileThenMove), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static FileInfo CreateTempFileThenMove([DisallowNull] this DirectoryInfo directory, [DisallowNull] string destinationFileName, [DisallowNull] string content, Encoding? encoding = null)
	{
		directory = directory.ArgumentNotNull();
		destinationFileName = destinationFileName.ArgumentNotNullOrEmpty();
		content = content.ArgumentNotNull();

		directory.Create();

		var destinationPath = Path.Combine(directory.FullName, destinationFileName);
		var destinationFile = new FileInfo(destinationPath);
		destinationFile.CreateTempFileThenMove(content, encoding);
		destinationFile.Refresh();

		return destinationFile;
	}

	/// <summary>
	/// Gets the total size of files in a <see cref="DirectoryInfo"/> based on a search pattern and search option.
	/// </summary>
	/// <param name="path">The directory information.</param>
	/// <param name="searchPattern">The search pattern to match file names in <paramref name="path"/>.</param>
	/// <param name="searchOption">Specifies whether to include subdirectories.</param>
	/// <returns>The total size of files in bytes.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path"/> is null.</exception>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="searchPattern"/> is null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption"/> is not a valid <see cref="SearchOption"/>.</exception>
	[Pure]
	[Information(nameof(GetSize), author: "David McCarter", createdOn: "10/8/2020", UnitTestStatus = UnitTestStatus.Completed, Status = Status.Available)]
	public static long GetSize([DisallowNull] this DirectoryInfo path, [DisallowNull] string searchPattern = ControlChars.WildcardAllFiles, SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		path = path.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		long totalSize = 0;
		var files = path.EnumerateFiles(searchPattern, searchOption);

		foreach (var file in files)
		{
			try
			{
				totalSize += file.Length;
			}
			catch (IOException ex)
			{
				Trace.WriteLine($"IOException accessing file '{file.FullName}': {ex.Message}");
			}
		}

		return totalSize;
	}

	/// <summary>
	/// Reads all text from the file in this directory and returns <paramref name="fallback"/> when the read fails.
	/// </summary>
	/// <param name="directory">The source directory.</param>
	/// <param name="fileName">The file name (not full path).</param>
	/// <param name="fallback">Fallback text returned when read fails.</param>
	/// <param name="encoding">The text encoding to use. Defaults to UTF-8.</param>
	/// <returns>The file contents, or <paramref name="fallback"/> when unavailable.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directory"/> or <paramref name="fileName"/> is null.</exception>
	[Pure]
	[Information(nameof(ReadAllTextSafe), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static string ReadAllTextSafe([DisallowNull] this DirectoryInfo directory, [DisallowNull] string fileName, string fallback = "", Encoding? encoding = null)
	{
		directory = directory.ArgumentNotNull();
		fileName = fileName.ArgumentNotNullOrEmpty();

		var file = new FileInfo(Path.Combine(directory.FullName, fileName));
		return file.ReadAllTextSafe(fallback, encoding);
	}

	/// <summary>
	/// Writes text atomically to a file within the directory.
	/// </summary>
	/// <param name="directory">The target directory.</param>
	/// <param name="fileName">The destination file name (not full path).</param>
	/// <param name="content">The content to write.</param>
	/// <param name="encoding">The text encoding to use. Defaults to UTF-8.</param>
	/// <returns>The destination <see cref="FileInfo"/>.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="directory"/>, <paramref name="fileName"/>, or <paramref name="content"/> is null.</exception>
	[Information(nameof(WriteAllTextAtomic), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.Available)]
	public static FileInfo WriteAllTextAtomic([DisallowNull] this DirectoryInfo directory, [DisallowNull] string fileName, [DisallowNull] string content, Encoding? encoding = null)
	{
		directory = directory.ArgumentNotNull();
		fileName = fileName.ArgumentNotNullOrEmpty();
		content = content.ArgumentNotNull();

		return directory.CreateTempFileThenMove(fileName, content, encoding);
	}
}
