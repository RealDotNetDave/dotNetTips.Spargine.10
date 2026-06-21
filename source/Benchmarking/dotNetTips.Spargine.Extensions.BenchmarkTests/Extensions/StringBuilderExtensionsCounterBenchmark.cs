// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="StringBuilderExtensionsCounterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// StringBuilderExtensions CounterPerfTestRunner.
/// </summary>
[BenchmarkCategory(Categories.Strings)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class StringBuilderExtensionsCounterBenchmark : TinyCollectionBenchmark
{

	private byte[] _byteArray = default!;
	private string[] _stringArray = default!;
	private IEnumerable<string> _stringEnumerable = default!;

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendBytes) + ": 01*")]
	[BenchmarkCategory(Categories.Strings)]
	public void AppendBytes01()
	{
		var sb = new StringBuilder();

		sb.AppendBytes(this._byteArray);

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = "FastStringBuilder.BytesToString: 01**")]
	public void AppendBytes03()
	{
		var result = FastStringBuilder.BytesToString(ref this._byteArray);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendKeyValue) + ": Includes = true (default)")]
	public void AppendKeyValue1()
	{
		var sb = new StringBuilder();
		var stringArray = this._stringArray;

		for (var index = 0; index < stringArray.Length; index++)
		{
			var testString = stringArray[index];
			sb.AppendKeyValue(testString, testString);
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendKeyValue) + ": Includes = false")]
	public void AppendKeyValue2()
	{
		var sb = new StringBuilder();
		var stringArray = this._stringArray;

		for (var index = 0; index < stringArray.Length; index++)
		{
			var testString = stringArray[index];
			sb.AppendKeyValue(testString, testString, false, false);
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendValues) + ": String Array")]
	public void AppendValues01()
	{
		var sb = new StringBuilder();

		sb.AppendValues(ControlChars.DefaultSeparator, this._stringArray);

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendValues) + ": String Enumerable")]
	public void AppendValues02()
	{
		var sb = new StringBuilder();

		sb.AppendValues(ControlChars.DefaultSeparator, this._stringEnumerable);

		this.Consume(sb.ToString());
	}

	public override void Setup()
	{
		base.Setup();

		this._stringArray = this.GetStringArray(this.Count, 15, 15);
		this._stringEnumerable = this.GetStringArray(this.Count, 15, 15).AsEnumerable();
		this._byteArray = this.GetByteArray(1);
	}

}
