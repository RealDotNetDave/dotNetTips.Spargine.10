// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 06-10-2024
//
// Last Modified By : David McCarter
// Last Modified On : 04-17-2026
// ***********************************************************************
// <copyright file="HashSetExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
[TailCallDiagnoser]
public class HashSetExtensionsCollectionBenchmark : LargeCollectionBenchmark
{

	private HashSet<Person> _peopleRefToAdd = default!;
	private HashSet<Person> _personRefHashSet = default!;

	[Benchmark(Description = nameof(HashSetExtensions.AddIf))]
	public void AddIf()
	{
		this._personRefHashSet.AddIf(this.PersonRef01, true);

		this.Consume(this._personRefHashSet.Count);
	}

	[IterationSetup(Targets = new[] { nameof(AddIf), nameof(Upsert) })]
	public void IterationSetupRef()
	{
		this._personRefHashSet = this.GetPersonRefArray().ToHashSet();
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefHashSet = [.. this.GetPersonRefArray()];
		this._peopleRefToAdd = [.. this._personRefHashSet.Take(this.Count / 2)];

	}

	[Benchmark(Description = nameof(HashSetExtensions.ToConcurrent))]
	public void ToConcurrentHashSet()
	{
		var result = this._personRefHashSet.ToConcurrent();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(HashSetExtensions.ToImmutable))]
	public void ToImmutableHashSet()
	{
		var result = this._personRefHashSet.ToImmutable();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(HashSetExtensions.Upsert))]
	public void Upsert()
	{
		this._personRefHashSet.Upsert(base.PersonRef01);

		this.Consume(this._personRefHashSet.Count);
	}

}
