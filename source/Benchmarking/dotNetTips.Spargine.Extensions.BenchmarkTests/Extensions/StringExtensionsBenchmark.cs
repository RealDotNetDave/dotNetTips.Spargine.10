// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 08-03-2022
//
// Last Modified By : Copilot Agent
// Last Modified On : 06-10-2026
// ***********************************************************************
// <copyright file="StringExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class StringExtensionsBenchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
[BenchmarkCategory(Categories.Strings)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class StringExtensionsBenchmark : Benchmark
{

	public const string MacAddress = "00:1A:C2:7B:00:47";
	private const string COMMA = ",";
	private readonly string _creditCardNumber = RandomData.GenerateNumber(12);
	private readonly string _currencyCode = "USD";
	private readonly string _delimitedString = RandomData.GenerateWords(100).ToDelimitedString();
	private readonly string _domainAddress = "www.dotnettips.com";
	private readonly string _emailAddress = RandomData.GenerateEmailAddress();
	private readonly DateTime _formatDateTime = new(2026, 2, 15, 14, 30, 45);
	private readonly string _formatString = "The time is {0:HH:mm:ss}";
	private readonly string _hashCode = RandomData.GenerateWord(100).ComputeHash();
	private readonly string _isbn = "0525505997";
	private readonly string _nullTestString = null!;
	private readonly string _oneToSevenAlpha = RandomData.GenerateWord(7);
	private readonly string _personName = "David McCarter";
	private readonly string _stringWithEllipsis = RandomData.GenerateWord(100) + "...";
	private readonly string _url = "https://api.example.com:8443/v1/users/123?include=profile,settings&format=json#section1";
	private string _compressedString = default!;
	private string _zlibString = default!;

	[Benchmark(Description = nameof(StringExtensions.CombineToString))]
	[BenchmarkCategory(Categories.Strings)]
	public void CombineToString()
	{
		var result = this.LongTestString.CombineToString(this.GetStringArray(10, 15, 15));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ComputeHash))]
	[BenchmarkCategory(Categories.Strings)]
	public void ComputeHash()
	{
		var testString = this.LongTestString;

		var result = testString.ComputeHash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.Concat))]
	[BenchmarkCategory(Categories.Strings)]
	public void Concat()
	{
		var testString = this.LongTestString;

		var result = StringExtensions.Concat(testString, COMMA, true, this.GetStringArray(10, 15, 15).AsReadOnly());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ContainsAny))]
	[BenchmarkCategory(Categories.Strings)]
	public void ContainsAny()
	{
		var testString = this.LongTestString;

		var result = testString.ContainsAny(StringComparison.InvariantCultureIgnoreCase, "d", "T");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNull))]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNull()
	{
		var result = String15Characters01.DefaultIfNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullOrEmpty()
	{
		var result = String15Characters01.DefaultIfNullOrEmpty("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty) + " + Default Value")]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullOrEmptyWithDefaultValue()
	{
		var result = String15Characters01.DefaultIfNullOrEmpty("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNullOrEmpty) + " + Default Value: Null Test")]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullOrEmptyWithDefaultValueFromNull()
	{
		var result = this._nullTestString.DefaultIfNullOrEmpty("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNull) + " + Default Value")]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullWithDefaultValue()
	{
		var result = String15Characters01.DefaultIfNull("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DefaultIfNull) + " + Default Value: Null Test")]
	[BenchmarkCategory(Categories.Strings)]
	public void DefaultIfNullWithDefaultValueFromNull()
	{
		var result = this._nullTestString.DefaultIfNull("David");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.DelimitedStringToArray))]
	[BenchmarkCategory(Categories.Strings)]
	public void DelimitedStringToArray()
	{
		var testString = this._delimitedString;

		var result = testString.DelimitedStringToArray();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.EqualsIgnoreCase))]
	[BenchmarkCategory(Categories.Strings)]
	public void EqualsIgnoreCase()
	{
		var result = String15Characters01.EqualsIgnoreCase(String15Characters02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.EqualsOrBothNullOrEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void EqualsOrBothNullOrEmpty()
	{
		var result = String15Characters01.EqualsOrBothNullOrEmpty(String15Characters02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.Extract))]
	[BenchmarkCategory(Categories.Strings)]
	public void Extract()
	{
		var result = this.LongTestString.Extract("and", "are");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.FastIsNullOrEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void FastIsNullOrEmpty()
	{
		var result = this.StringToTrim.FastIsNullOrEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.FastReplace))]
	[BenchmarkCategory(Categories.Strings)]
	public void FastReplace()
	{
		var input = "Hello World";
		var result = input.FastReplace("Hello", "Googbye");

		this.Consume(result);
	}

	[Benchmark(Description = "Format: string.Format()")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void FormatStringFormat_ForComparison()
	{
		this.Consume(string.Format(this._formatString, this._formatDateTime));
	}

	[Benchmark(Description = nameof(StringExtensions.FromBase64))]
	[BenchmarkCategory(Categories.Strings)]
	public void FromBase64()
	{
		var result = this.Base64String.FromBase64();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.FromDeflateStringAsync))]
	[BenchmarkCategory(Categories.Strings)]
	public async Task FromDeflateStringAsync()
	{
		var result = await this._compressedString.FromDeflateStringAsync().ConfigureAwait(false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.FromZLibStringAsync))]
	[BenchmarkCategory(Categories.Strings)]
	public async Task FromZLibStringAsync()
	{
		var result = await this._zlibString.FromZLibStringAsync().ConfigureAwait(false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasValue))]
	[BenchmarkCategory(Categories.Strings)]
	public void HasValue()
	{
		var result = this.LongTestString.HasValue();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasValue) + ": Length")]
	[BenchmarkCategory(Categories.Strings)]
	public void HasValueWithLength()
	{
		var result = this.LongTestString.HasValue(100);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasValue) + ": Min & Max Count")]
	[BenchmarkCategory(Categories.Strings)]
	public void HasValueWithMinMaxCount()
	{
		var result = this.LongTestString.HasValue(5, 100);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasValue) + ": String")]
	[BenchmarkCategory(Categories.Strings)]
	public void HasValueWithString()
	{
		var result = this.LongTestString.HasValue("A");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.HasWhitespace))]
	[BenchmarkCategory(Categories.Strings)]
	public void HasWhitespace()
	{
		var result = this.LongTestString.HasWhitespace();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.Indent))]
	[BenchmarkCategory(Categories.Strings)]
	public void Indent()
	{
		var result = this.LongTestString.Indent(10, '>');

		this.Consume(result);
	}


	[Benchmark(Description = nameof(StringExtensions.IsCreditCardNumber))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsCreditCardNumber()
	{
		var result = this._creditCardNumber.IsCreditCardNumber();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsCurrencyCode))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsCurrencyCode()
	{
		var result = this._currencyCode.IsCurrencyCode();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsDomainAddress))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsDomainAddress()
	{
		var result = this._domainAddress.IsDomainAddress();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsEmailAddress))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsEmailAddress()
	{
		var result = this._emailAddress.IsEmailAddress();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsEmpty()
	{
		var result = String15Characters01.IsEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsFirstLastName))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsFirstLastName()
	{
		var result = this._personName.IsFirstLastName();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsGuid))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsGuid()
	{
		var guid = this.TestGuid.ToString();
		var result = guid.IsGuid();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsISBN))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsISBN()
	{
		var result = this._isbn.IsISBN();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsMacAddress))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsMacAddress()
	{
		var result = MacAddress.IsMacAddress();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsNotEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsNotEmpty()
	{
		var result = String15Characters01.IsNotEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsOneToSevenAlpha))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsOneToSevenAlpha()
	{
		var result = this._oneToSevenAlpha.IsOneToSevenAlpha();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsScientific))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsScientific()
	{
		var result = "6.5 ✕ 10^8".IsScientific();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsStringSHA1Hash))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsStringSHA1Hash()
	{
		var result = this._hashCode.IsStringSHA1Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsUrl))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsUrl()
	{
		var result = this._domainAddress.IsUrl();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.IsValidString))]
	[BenchmarkCategory(Categories.Strings)]
	public void IsValidString()
	{
		var result = this.LongTestString.IsValidString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.FastParseUrl))]
	[BenchmarkCategory(Categories.Strings)]
	public void ParseUrlFastParseUrl()
	{
		var result = this._url.FastParseUrl();
		this.Consume(result);
	}

	[Benchmark(Description = "Parse Url: Uri")]
	[BenchmarkCategory(Categories.Strings, Categories.ForComparison)]
	public void ParseUrlUri_ForComparison()
	{
		var uri = new Uri(this._url);
		var result = (uri.Scheme, uri.Host, uri.Port, uri.AbsolutePath, uri.Query, uri.Fragment);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ReplaceEllipsisWithPeriod))]
	[BenchmarkCategory(Categories.Strings)]
	public void ReplaceEllipsisWithPeriod()
	{
		var result = this._stringWithEllipsis.ReplaceEllipsisWithPeriod();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._compressedString = this.LongTestString.ToDeflateStringAsync().Result;
		this._zlibString = this.LongTestString.ToZLibStringAsync().Result;
	}

	[Benchmark(Description = nameof(StringExtensions.Split))]
	[BenchmarkCategory(Categories.Strings)]
	public void Split()
	{
		var result = this.LongTestString.Split(StringSplitOptions.TrimEntries);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.SplitRemoveEmpty))]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitRemoveEmpty()
	{
		var result = this.LongTestString.SplitRemoveEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.Split) + ": With Count")]
	[BenchmarkCategory(Categories.Strings)]
	public void SplitWithCount()
	{
		var result = this.LongTestString.Split(StringSplitOptions.TrimEntries, 2, ControlChars.Comma);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinal))]
	[BenchmarkCategory(Categories.Strings)]
	public void StartsWithOrdinal()
	{
		var result = String10Characters01.StartsWithOrdinal(String15Characters01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.StartsWithOrdinalIgnoreCase))]
	public void StartsWithOrdinalIgnoreCase()
	{
		var result = String10Characters01.StartsWithOrdinalIgnoreCase(String15Characters01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.SubstringTrim))]
	public void SubstringTrim()
	{
		var result = this.StringToTrim.SubstringTrim(25, 25);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToBase64))]
	[BenchmarkCategory(Categories.Strings)]
	public void ToBase64()
	{
		var result = this.LongTestString.ToBase64();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToBase64Bytes))]
	[BenchmarkCategory(Categories.Strings)]
	public void ToBase64ToBase64ByteSpan()
	{
		var result = this.Base64String.ToBase64Bytes();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArrayFromBase64))]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArrayFromBase64()
	{
		var result = this.Base64String.ToByteArrayFromBase64();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": ASCII")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArrayStringASCII()
	{
		var result = this.LongTestString.ToByteArray(Encoding.ASCII);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": BigEndianUnicode")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArrayStringBigEndianUnicode()
	{
		var result = this.LongTestString.ToByteArray(Encoding.BigEndianUnicode);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": Default")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArrayStringDefault()
	{
		var result = this.LongTestString.ToByteArray(Encoding.Default);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": Latin1")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArrayStringLatin1()
	{
		var result = this.LongTestString.ToByteArray(Encoding.Latin1);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": Unicode")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArrayStringUnicode()
	{
		var result = this.LongTestString.ToByteArray(Encoding.Unicode);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": UTF32")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArrayStringUTF32()
	{
		var result = this.LongTestString.ToByteArray(Encoding.UTF32);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringExtensions.ToByteArray) + ": UTF8")]
	[BenchmarkCategory(Categories.Strings)]
	public void ToByteArrayStringUTF8()
	{
		var result = this.LongTestString.ToByteArray(Encoding.UTF8);

		this.Consume(result);
	}

	//[Benchmark(Description = nameof(StringExtensions.ToDeflateStringAsync))]
	//[BenchmarkCategory(Categories.Strings)]
	//public async Task ToDeflateStringAsync()
	//{
	//	var result = await this.LongTestString.ToDeflateStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

	[Benchmark(Description = nameof(StringExtensions.ToTitleCase))]
	public void ToTitleCase() => this.Consume(LowerCaseString.ToTitleCase());

	[Benchmark(Description = nameof(StringExtensions.ToTrimmed))]
	public void ToTrimmedString()
	{
		var result = this.StringToTrim.ToTrimmed();

		this.Consume(result);
	}

	//[Benchmark(Description = nameof(StringExtensions.ToZLibStringAsync))]
	//[BenchmarkCategory(Categories.Strings)]
	//public async Task ToZLibStringAsync()
	//{
	//	var result = await this.LongTestString.ToZLibStringAsync().ConfigureAwait(false);

	//	await this.ConsumeAsync(result).ConfigureAwait(false);
	//}

}
