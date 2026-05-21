// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-21-2026
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
[Information(Status = Status.Available)]
public static class DirectoryInfoExtensions
{

	/// <summary>
	/// Gets the total size of files in a <see cref="DirectoryInfo" /> based on a search pattern and search option.
	/// </summary>
	/// <param name="path">The directory information.</param>
	/// <param name="searchPattern">The search pattern to match against the names of files in <paramref name="path" />. This parameter can contain a combination of valid literal and wildcard characters, but doesn't support regular expressions.</param>
	/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.</param>
	/// <returns>The total size of files in bytes.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="path" /> is null.</exception>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="searchPattern" /> is null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="searchOption" /> is not a valid <see cref="SearchOption" />.</exception>
	/// <example>
	/// This example shows how to use the <see cref="GetSize" /> method to calculate the total size of files in a directory and its subdirectories.
	/// <code>
	/// var directoryInfo = new DirectoryInfo(@"C:\MyDirectory");
	/// long totalSize = directoryInfo.GetSize("*.*", SearchOption.AllDirectories);
	/// Console.WriteLine($"Total size: {totalSize} bytes");
	/// </code></example>
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

}
