// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : Copilot Agent
// Last Modified On : 06-10-2026
// ***********************************************************************
// <copyright file="StringExtensionsCounterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// StringExtensions CounterPerfTestRunner.
/// </summary>
[BenchmarkCategory(Categories.Strings)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class StringExtensionsCounterBenchmark : TinyCollectionBenchmark
{
	private static readonly char[] _charList = ['a', 'z'];
	private string _brotilString = default!;
	private string _crlfCompareString = default!;
	private string _crlfString = default!;
	private string _gzipString = default!;
	private string[] _wordCollection = default!;

	[Benchmark(Description = nameof(StringExtensions.CalculateByteArraySize))]
	[BenchmarkCategory(Categories.Strings)]
	public void CalculateByteArraySize()
	{
		var result = this.Base64String.CalculateByteArraySize();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.CalculateTotalLength))]
	[BenchmarkCategory(Categories.Strings)]
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
	[BenchmarkCategory(Categories.Strings)]
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
	[BenchmarkCategory(Categories.Strings)]
	public void IsEmpty()
	{
		var result = this._crlfString.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsNotEmpty))]
	[BenchmarkCategory(Categories.Strings)]
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
	public void SplitCharSeparator_ForComparison()
	{
		this.Consume(this._crlfString.Split(StringSplitOptions.RemoveEmptyEntries, 2, ControlChars.Dot));
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": Char Separator ")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void SplitCharSeparatorNoCount_ForComparison()
	{
		this.Consume(this._crlfString.Split(StringSplitOptions.RemoveEmptyEntries, ControlChars.Dot));
	}

	[Benchmark(Description = "Split")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void SplitComparison_ForComparison()
	{
		this.Consume(this._crlfString.Split(ControlChars.CRLF));
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
		this.Consume(this._crlfString.SplitRemoveEmpty());
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": String Separator + Count")]
	[BenchmarkCategory(Categories.ForComparison)]
	public void SplitStringSeparator_ForComparison()
	{
		this.Consume(this._crlfString.Split(ControlChars.CRLF, 2, StringSplitOptions.RemoveEmptyEntries));
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": RemoveEmptyEntries")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithRemoveEmptyEntries()
	{
		this.Consume(this._crlfString.Split(StringSplitOptions.RemoveEmptyEntries, ControlChars.Dot));
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": TrimEntries")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithTrimEntries()
	{
		this.Consume(this._crlfString.Split(StringSplitOptions.TrimEntries, ControlChars.Dot));
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": TrimEntries + Count")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithTrimEntriesCount()
	{
		this.Consume(this._crlfString.Split(StringSplitOptions.TrimEntries, 10, ControlChars.Dot));
	}

	[Benchmark(Description = nameof(StringExtensions.ToBase64))]
	[BenchmarkCategory(Categories.Strings)]
	public void ToBase64()
	{
		var result = this._crlfString.ToBase64();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToBase64Bytes))]
	[BenchmarkCategory(Categories.Strings)]
	public void ToBase64ByteSpan()
	{
		var result = this.Base64String.ToBase64Bytes();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToBrotliStringAsync))]
	[BenchmarkCategory(Categories.Strings)]
	public async Task ToBrotliAsync()
	{
		var result = await this._crlfString.ToBrotliStringAsync().ConfigureAwait(false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToGZipStringAsync))]
	[BenchmarkCategory(Categories.Strings)]
	public async Task ToGZipAsync()
	{
		var result = await this._crlfString.ToGZipStringAsync().ConfigureAwait(false);

		this.Consume(result);
	}

}
