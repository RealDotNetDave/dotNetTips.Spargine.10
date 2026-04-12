// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 07-21-2025
//
// Last Modified By : David McCarter
// Last Modified On : 07-21-2025
// ***********************************************************************
// <copyright file="LinqExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

[BenchmarkCategory(Categories.Collections)]
public class LinqExtensionsBenchmark : LargeCollectionBenchmark
{

	private static readonly Func<IEnumerable<Person>, IEnumerable<Person>> _filterTransform =
		collection => collection.Where(person => person.Email.Length > 20);

	private static readonly Func<IEnumerable<Person>, IEnumerable<Person>> _orderTransform =
		collection => collection.OrderBy(person => person.Email);

	private Person[] _people;

	[Benchmark(Description = "If: should=false (passthrough)")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void IfShouldFalse()
	{
		var result = this._people.If(false, _filterTransform);

		this.Consume(result);
	}

	[Benchmark(Description = "If: should=true (transform applied)")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void IfShouldTrue()
	{
		var result = this._people.If(true, _filterTransform);

		this.Consume(result);
	}

	[Benchmark(Description = "If: should=true (multiple transforms)")]
	[BenchmarkCategory(Categories.Collections, Categories.New)]
	public void IfShouldTrueMultipleTransforms()
	{
		var result = this._people.If(true, _filterTransform, _orderTransform);

		this.Consume(result);
	}

	[IterationSetup(Targets = [nameof(IfShouldTrue), nameof(IfShouldFalse), nameof(IfShouldTrueMultipleTransforms)])]
	public void IterationSetup()
	{
		this._people = this.GetPersonRefArray();
	}

}
