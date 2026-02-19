// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2026
//
// Last Modified By : David McCarter
// Last Modified On : 02-19-2026
// ***********************************************************************
// <copyright file="CharacterExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Strings)]
public class CharacterExtensionsBenchmark : Benchmark
{
	[Benchmark(Description = nameof(CharacterExtensions.GetDigitValue))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public int GetDigitValue()
	{
		return 'a'.GetDigitValue();
	}

	[Benchmark(Description = nameof(CharacterExtensions.get_IsAsciiControl))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public bool IsAsciiControl()
	{
		return '\t'.IsAsciiControl;
	}

	[Benchmark(Description = nameof(CharacterExtensions.get_IsAsciiPunctuation))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public bool IsAsciiPunctuation()
	{
		return '.'.IsAsciiPunctuation;
	}

	[Benchmark(Description = nameof(CharacterExtensions.get_IsAsciiUpper))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public bool IsAsciiUpper()
	{
		return 'A'.IsAsciiUpper;
	}

	[Benchmark(Description = nameof(CharacterExtensions.get_IsAsciiWhitespace))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public bool IsAsciiWhitespace()
	{
		return ' '.IsAsciiWhitespace;
	}

	[Benchmark(Description = nameof(CharacterExtensions.get_IsHexDigit))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public bool IsHexDigit()
	{
		return 'F'.IsHexDigit;
	}

	[Benchmark(Description = nameof(CharacterExtensions.get_IsNewLine))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public bool IsNewLine()
	{
		return '\n'.IsNewLine;
	}

	[Benchmark(Description = nameof(CharacterExtensions.get_IsUnicodeDigit))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public bool IsUnicodeDigit()
	{
		return '5'.IsUnicodeDigit;
	}

	public override void Setup()
	{
		base.Setup();

	}

	[Benchmark(Description = nameof(CharacterExtensions.ToAsciiLower))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public char ToAsciiLower()
	{
		return 'A'.ToAsciiLower();
	}

	[Benchmark(Description = nameof(CharacterExtensions.ToAsciiUpper))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public char ToAsciiUpper()
	{
		return 'a'.ToAsciiUpper();
	}
}
