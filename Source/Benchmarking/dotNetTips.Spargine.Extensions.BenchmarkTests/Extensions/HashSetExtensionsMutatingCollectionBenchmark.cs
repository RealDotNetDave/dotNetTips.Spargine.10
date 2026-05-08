// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 05-08-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 05-08-2026
// ***********************************************************************
// <copyright file="HashSetExtensionsMutatingCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary>
// Benchmark tests for HashSetExtensions methods that mutate the collection,
// including AddIf and Upsert.
// Uses [IterationSetup] to reset the working HashSet before each iteration.
// </summary>
// ***********************************************************************

using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class HashSetExtensionsMutatingCollectionBenchmark.
/// Benchmark tests for <see cref="HashSetExtensions"/> methods that mutate the HashSet.
/// The working set is restored before each iteration via <see cref="Reset"/>.
/// Implements the <see cref="LargeCollectionBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionBenchmark" />
[BenchmarkCategory(Categories.Collections)]
[TailCallDiagnoser]
public class HashSetExtensionsMutatingCollectionBenchmark : LargeCollectionBenchmark
{
	private HashSet<Person> _personRefHashSet = default!;

	[Benchmark(Description = nameof(HashSetExtensions.AddIf))]
	public void AddIf()
	{
		this._personRefHashSet.AddIf(this.PersonRef01, true);

		this.Consume(this._personRefHashSet);
	}

	/// <summary>
	/// Resets the working HashSet before each benchmark iteration so that mutations
	/// from the previous invocation do not affect subsequent results.
	/// </summary>
	[IterationSetup]
	public void Reset()
	{
		this._personRefHashSet = [.. this.GetPersonRefArray()];
	}

	/// <summary>
	/// Initializes the working HashSet. Called once per benchmark job by BenchmarkDotNet.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefHashSet = [.. this.GetPersonRefArray()];
	}

	[Benchmark(Description = nameof(HashSetExtensions.Upsert))]
	public void Upsert()
	{
		this._personRefHashSet.Upsert(this.PersonRef01);

		this.Consume(this._personRefHashSet);
	}
}
