// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-15-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="AutoDefaultDictionaryCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.RefTypes.Comparers;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic;

public class AutoDefaultDictionaryCollectionBenchmark : LargeCollectionBenchmark
{
	private AutoDefaultDictionary<string, Person> _personRefAutoDefaultDictionary = default!;

	[Benchmark(Description = "ContainsValue")]
	public void ContainsValue()
	{
		var result = this._personRefAutoDefaultDictionary.ContainsValue(this.PersonRef01);

		this.Consume(result);
	}

	[Benchmark(Description = "ContainsValue: Comparer")]
	public void ContainsValueComparer()
	{
		var result = this._personRefAutoDefaultDictionary.ContainsValue(this.PersonRef01, new PersonEqualityComparer());

		this.Consume(result);
	}

	[Benchmark(Description = "GetValueOrDefault")]
	public void GetValueOrDefault()
	{
		var result = this._personRefAutoDefaultDictionary.GetValueOrDefault(this.PersonRef01.Id);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefAutoDefaultDictionary = new AutoDefaultDictionary<string, Person>(this.GetPersonRefDictionary(), this.PersonRef01);
	}

	[Benchmark(Description = "ToImmutableDictionary")]
	public void ToImmutableDictionary()
	{
		var result = this._personRefAutoDefaultDictionary.ToImmutableDictionary();

		this.Consume(result);
	}

}
