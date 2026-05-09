// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : David McCarter
// Created          : 01-12-2023
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-09-2026
// ***********************************************************************
// <copyright file="PathHelperBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>Comprehensive benchmark tests for all public methods in PathHelper.</summary>
// ***********************************************************************

using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.IO;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.BenchmarkTests.IO;

[BenchmarkCategory(Categories.IO)]
public class PathHelperBenchmark : Benchmark
{
	private string _pathWithInvalidChars;
	private string _pathWithWildcard;
	private string _testPath;

	/// <summary>
	/// Benchmark for CombinePaths with four paths.
	/// </summary>
	[Benchmark(Description = "CombinePaths(bool, string, string, string, string)")]
	[BenchmarkCategory(Categories.New)]
	public void CombinePathsFour()
	{
		var result = PathHelper.CombinePaths(false, "C:\\", "folder1", "folder2", "folder3");

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for CombinePaths with params array (multiple paths).
	/// </summary>
	[Benchmark(Description = "CombinePaths(bool, params string[])")]
	[BenchmarkCategory(Categories.New)]
	public void CombinePathsParams()
	{
		var result = PathHelper.CombinePaths(false, "C:\\", "folder1", "folder2", "folder3");

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for CombinePaths with three paths.
	/// </summary>
	[Benchmark(Description = "CombinePaths(bool, string, string, string)")]
	[BenchmarkCategory(Categories.New)]
	public void CombinePathsThree()
	{
		var result = PathHelper.CombinePaths(false, "C:\\", "folder1", "folder2");

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for CombinePaths with two paths.
	/// </summary>
	[Benchmark(Description = "CombinePaths(bool, string, string)")]
	[BenchmarkCategory(Categories.New)]
	public void CombinePathsTwo()
	{
		var result = PathHelper.CombinePaths(false, "C:\\", "folder1");

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for EnsureTrailingSlash with a path that already has a trailing slash.
	/// </summary>
	[Benchmark(Description = "EnsureTrailingSlash(string)")]
	[BenchmarkCategory(Categories.New)]
	public void EnsureTrailingSlash()
	{
		var result = PathHelper.EnsureTrailingSlash(this._testPath);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for HasInvalidFilterChars with a path containing invalid characters.
	/// </summary>
	[Benchmark(Description = "HasInvalidFilterChars(string)")]
	[BenchmarkCategory(Categories.New)]
	public void HasInvalidFilterChars()
	{
		var result = PathHelper.HasInvalidFilterChars(string.Concat(this.LongTestString, Path.DirectorySeparatorChar));

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for HasInvalidFilterChars with a valid filter string.
	/// </summary>
	[Benchmark(Description = "HasInvalidFilterChars(string) - Valid")]
	[BenchmarkCategory(Categories.New)]
	public void HasInvalidFilterCharsValid()
	{
		var result = PathHelper.HasInvalidFilterChars("validfilename.txt");

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for InvalidFilterChars property method.
	/// </summary>
	[Benchmark(Description = "InvalidFilterChars()")]
	[BenchmarkCategory(Categories.New)]
	public void InvalidFilterChars()
	{
		var result = PathHelper.InvalidFilterChars();

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for InvalidPathNameChars property method.
	/// </summary>
	[Benchmark(Description = "InvalidPathNameChars()")]
	[BenchmarkCategory(Categories.New)]
	public void InvalidPathNameChars()
	{
		var result = PathHelper.InvalidPathNameChars();

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for PathContainsWildcard with a path containing a wildcard.
	/// </summary>
	[Benchmark(Description = "PathContainsWildcard(string)")]
	[BenchmarkCategory(Categories.New)]
	public void PathContainsWildcard()
	{
		var result = PathHelper.PathContainsWildcard(this._pathWithWildcard);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for PathContainsWildcard with a path that does not contain a wildcard.
	/// </summary>
	[Benchmark(Description = "PathContainsWildcard(string) - NoWildcard")]
	[BenchmarkCategory(Categories.New)]
	public void PathContainsWildcardNoWildcard()
	{
		var result = PathHelper.PathContainsWildcard(this._testPath);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for PathHasInvalidChars with a path containing invalid characters.
	/// </summary>
	[Benchmark(Description = "PathHasInvalidChars(string)")]
	[BenchmarkCategory(Categories.New)]
	public void PathHasInvalidChars()
	{
		var result = PathHelper.PathHasInvalidChars(this._pathWithInvalidChars);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for PathHasInvalidChars with a valid path.
	/// </summary>
	[Benchmark(Description = "PathHasInvalidChars(string) - Valid")]
	[BenchmarkCategory(Categories.New)]
	public void PathHasInvalidCharsValid()
	{
		var result = PathHelper.PathHasInvalidChars(this._testPath);

		this.Consume(result);
	}

	/// <summary>
	/// Benchmark for PathSeparators property access.
	/// </summary>
	[Benchmark(Description = "PathSeparators property")]
	[BenchmarkCategory(Categories.New)]
	public void PathSeparators()
	{
		var result = PathHelper.PathSeparators;

		this.Consume(result);
	}

	/// <summary>
	/// Initializes benchmark data by overriding the Setup method from the base Benchmark class.
	/// Calls base.Setup() to ensure base class initialization, then initializes PathHelper-specific test data.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._testPath = Environment.ProcessPath ?? "C:\\Windows\\System32";
		this._pathWithInvalidChars = string.Concat(this.LongTestString, Path.DirectorySeparatorChar, "\0");
		this._pathWithWildcard = string.Concat(this.LongTestString, "*");
	}
}
