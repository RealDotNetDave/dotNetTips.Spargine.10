// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Extensions
// Author           : Copilot Agent
// Created          : 07-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="FileInfoExtensions.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Extension methods for <see cref="System.IO.FileInfo"/> that provide atomic write and safe read helpers.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Text;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="FileInfo"/> that support atomic writes and resilient reads.
/// </summary>
[Information(Status = Status.New)]
public static class FileInfoExtensions
{
	/// <summary>
	/// Creates a temporary file in the same directory and atomically moves it to <paramref name="file"/>.
	/// </summary>
	/// <param name="file">The destination file.</param>
	/// <param name="content">The content to write.</param>
	/// <param name="encoding">The text encoding to use. Defaults to UTF-8.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="file"/> or <paramref name="content"/> is null.</exception>
	[Information(nameof(CreateTempFileThenMove), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static void CreateTempFileThenMove([DisallowNull] this FileInfo file, [DisallowNull] string content, Encoding? encoding = null)
	{
		file = file.ArgumentNotNull();
		content = content.ArgumentNotNull();

		var directory = file.Directory ?? throw new InvalidOperationException();

		directory.Create();

		var tempPath = Path.Combine(directory.FullName, $".{file.Name}.{Guid.NewGuid():N}.tmp");
		File.WriteAllText(tempPath, content, encoding ?? Encoding.UTF8);

		try
		{
			if (file.Exists)
			{
				File.Replace(tempPath, file.FullName, destinationBackupFileName: null, ignoreMetadataErrors: true);
			}
			else
			{
				File.Move(tempPath, file.FullName);
			}

			file.Refresh();
		}
		finally
		{
			if (File.Exists(tempPath))
			{
				File.Delete(tempPath);
			}
		}
	}

	/// <summary>
	/// Reads all text from the file and returns <paramref name="fallback"/> when file access fails.
	/// </summary>
	/// <param name="file">The source file.</param>
	/// <param name="fallback">Fallback text returned when the read fails.</param>
	/// <param name="encoding">The text encoding to use. Defaults to UTF-8.</param>
	/// <returns>The file contents, or <paramref name="fallback"/> when unavailable.</returns>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="file"/> is null.</exception>
	[Pure]
	[Information(nameof(ReadAllTextSafe), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static string ReadAllTextSafe([DisallowNull] this FileInfo file, string fallback = "", Encoding? encoding = null)
	{
		file = file.ArgumentNotNull();

		try
		{
			if (file.Exists is false)
			{
				return fallback;
			}

			return File.ReadAllText(file.FullName, encoding ?? Encoding.UTF8);
		}
		catch (IOException)
		{
			return fallback;
		}
		catch (UnauthorizedAccessException)
		{
			return fallback;
		}
	}

	/// <summary>
	/// Writes text atomically by writing to a temp file then moving/replacing the target file.
	/// </summary>
	/// <param name="file">The destination file.</param>
	/// <param name="content">The content to write.</param>
	/// <param name="encoding">The text encoding to use. Defaults to UTF-8.</param>
	/// <exception cref="ArgumentNullException">Thrown when <paramref name="file"/> or <paramref name="content"/> is null.</exception>
	[Information(nameof(WriteAllTextAtomic), "Copilot Agent", "07-08-2026", UnitTestStatus = UnitTestStatus.Completed, OptimizationStatus = OptimizationStatus.Optimize, BenchmarkStatus = BenchmarkStatus.Completed, Status = Status.New)]
	public static void WriteAllTextAtomic([DisallowNull] this FileInfo file, [DisallowNull] string content, Encoding? encoding = null)
	{
		file = file.ArgumentNotNull();
		content = content.ArgumentNotNull();

		file.CreateTempFileThenMove(content, encoding);
	}
}
