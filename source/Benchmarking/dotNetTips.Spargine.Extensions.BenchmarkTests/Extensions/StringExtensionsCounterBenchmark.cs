// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-30-2025
// ***********************************************************************
// <copyright file="StringExtensionsCounterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// StringExtensions CounterPerfTestRunner.
/// </summary>
[BenchmarkCategory(Categories.Strings)]
public class StringExtensionsCounterBenchmark : TinyCollectionBenchmark
{
	private static readonly char[] _charList = ['a', 'z'];
	private string _brotilString;
	private string _crlfCompareString;
	private string _crlfString;
	private string _gzipString;
	private string[] _wordCollection;

	[Benchmark(Description = nameof(StringExtensions.CalculateByteArraySize))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void CalculateByteArraySize()
	{
		var result = this.Base64String.CalculateByteArraySize();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.CalculateTotalLength))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void CalculateTotalLength()
	{
		var result = this._wordCollection.CalculateTotalLength();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ComputeHash) + ": SHA256")]
	[BenchmarkCategory(Categories.Strings)]
	public void ComputeHash()
	{
		var result = this._crlfString.ComputeHash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ContainsAny))]
	[BenchmarkCategory(Categories.Strings)]
	public void ContainsAny()
	{
		// Fix: Pass a ReadOnlyCollection<char> as required by the method signature.
		var charsToCheck = new ReadOnlyCollection<char>(
			_charList
		);

		var result = this._crlfString.ContainsAny(charsToCheck);

		this.Consume(result);
	}
	[Benchmark(Description = nameof(StringExtensions.DelimitedStringToArray))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void DelimitedStringToArray()
	{
		var result = this._crlfString.DelimitedStringToArray(ControlChars.Dot);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.EqualsIgnoreCase))]
	[BenchmarkCategory(Categories.Strings)]
	public void EqualsIgnoreCase()
	{
		var result = this._crlfString.EqualsIgnoreCase(this._crlfString);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.EqualsOrBothNullOrEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void EqualsOrBothNullOrEmpty()
	{
		var result = this._crlfString.EqualsOrBothNullOrEmpty(this._crlfString);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.FromBase64))]
	[BenchmarkCategory(Categories.Strings)]
	public void FromBase64()
	{
		var result = this.Base64String.FromBase64();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsEmpty))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsEmpty()
	{
		var result = this._crlfString.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsNotEmpty))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void IsNotEmpty()
	{
		var result = this._crlfString.IsNotEmpty();

		this.Consume(result);
	}

	//[Benchmark(Description = nameof(StringExtensions.FromBrotliStringAsync))]
	//[BenchmarkCategory(Categories.New, Categories.Strings, Categories.Async)]
	//public async Task FromBrotliAsync()
	//{
	//	var result = await this._brotilString.FromBrotliStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	//[Benchmark(Description = nameof(StringExtensions.FromGZipStringAsync))]
	//[BenchmarkCategory(Categories.New, Categories.Strings, Categories.Async)]
	//public async Task FromGZipAsync()
	//{
	//	var result = await this._gzipString.FromGZipStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	//[Benchmark(Description = nameof(StringExtensions.RemoveCRLF))]
	//[BenchmarkCategory(Categories.Strings)]
	//public void RemoveCRLF01()
	//{
	//	var testString = this._crlfString.FastClone();

	//	var result = testString.RemoveCRLF();

	//	this.Consume(result);
	//}

	public override void Setup()
	{
		base.Setup();

		//ToUniqueCollection lines of text.
		var sb = new StringBuilder(this.Count * 70);

		for (var lineCount = 0; lineCount < this.Count; lineCount++)
		{
			_ = sb.Append(RandomData.GenerateWord(10))
			  .Append(ControlChars.Space)
			  .Append(RandomData.GenerateWord(10)).Append(ControlChars.Space)
			  .Append(RandomData.GenerateWord(10)).Append(ControlChars.Space)
			  .Append(RandomData.GenerateWord(10)).Append(ControlChars.Space)
			  .Append(RandomData.GenerateWord(10))
			  .Append(ControlChars.Dot)
			  .AppendLine();
		}

		this._crlfString = sb.ToString().Trim();
		this._crlfCompareString = this._crlfString;
		this._brotilString = this._crlfString.ToBrotliStringAsync().Result;
		this._gzipString = this._crlfString.ToGZipStringAsync().GetAwaiter().GetResult();
		this._wordCollection = [.. RandomData.GenerateWords(this.Count)];
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": Char Separator + Count")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void SplitCharSeparator()
	{
		foreach (var line in this._crlfString.Split(StringSplitOptions.RemoveEmptyEntries, 2, ControlChars.Dot))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": Char Separator ")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void SplitCharSeparatorNoCount()
	{
		foreach (var line in this._crlfString.Split(StringSplitOptions.RemoveEmptyEntries, ControlChars.Dot))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = "Split")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void SplitComparison()
	{
		foreach (var line in this._crlfString.Split(ControlChars.CRLF))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.SplitLines) + ": LineSplitEntry")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitLines()
	{
		foreach (var line in this._crlfString.SplitLines())
		{
			this.Consume(line.Line.ToString());
		}
	}

	[Benchmark(Description = nameof(StringExtensions.SplitRemoveEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitRemoveEmpty()
	{
		foreach (var line in this._crlfString.SplitRemoveEmpty())
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": String Separator + Count")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void SplitStringSeparator()
	{
		foreach (var line in this._crlfString.Split(ControlChars.CRLF, 2, StringSplitOptions.RemoveEmptyEntries))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": RemoveEmptyEntries")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithRemoveEmptyEntries()
	{
		foreach (var line in this._crlfString.Split(StringSplitOptions.RemoveEmptyEntries, ControlChars.Dot))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": TrimEntries")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithTrimEntries()
	{
		foreach (var line in this._crlfString.Split(StringSplitOptions.TrimEntries, ControlChars.Dot))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": TrimEntries + Count")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithTrimEntriesCount()
	{
		foreach (var line in this._crlfString.Split(StringSplitOptions.TrimEntries, 10, ControlChars.Dot))
		{
			this.Consume(line);
		}
	}

	[Benchmark(Description = nameof(StringExtensions.ToBase64))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void ToBase64()
	{
		var result = this._crlfString.ToBase64();
		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(StringExtensions.ToBase64Bytes))]
	[BenchmarkCategory(Categories.Strings, Categories.New)]
	public void ToBase64ByteSpan()
	{
		var result = this.Base64String.ToBase64Bytes();
		this.Consume(result.Length);
	}

	[Benchmark(Description = nameof(StringExtensions.ToBrotliStringAsync))]
	[BenchmarkCategory(Categories.New, Categories.Strings)]
	public async Task ToBrotliAsync()
	{
		var result = await this._crlfString.ToBrotliStringAsync().ConfigureAwait(false);

		await this.ConsumeAsync(result).ConfigureAwait(false);
	}

	[Benchmark(Description = nameof(StringExtensions.ToGZipStringAsync))]
	[BenchmarkCategory(Categories.New, Categories.Strings)]
	public async Task ToGZipAsync()
	{
		var result = await this._crlfString.ToGZipStringAsync().ConfigureAwait(false);

		await this.ConsumeAsync(result).ConfigureAwait(false);
	}

}
