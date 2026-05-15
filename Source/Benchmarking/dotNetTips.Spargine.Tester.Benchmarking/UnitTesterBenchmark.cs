// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Tester.BenchmarkTests
// Author           : Copilot Agent
// Created          : 06-10-2025
//
// Last Modified By : Copilot Agent
// Last Modified On : 06-10-2025
// ***********************************************************************
// <copyright file="UnitTesterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>
// Benchmarks for UnitTester high-priority methods:
// MeasureAction (debug separator), SaveAsJsonToFile (filename generation),
// and SaveToFile collection overloads (LINQ vs pre-allocated loop).
// </summary>
// ***********************************************************************
using System;
using System.IO;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VSDiagnostics;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Tester.BenchmarkTests;

/// <summary>
/// Benchmarks for the three high-priority UnitTester areas.
/// </summary>
[CPUUsageDiagnoser]
public class UnitTesterBenchmark : Benchmark
{
	private static readonly Func<PropertyInfo, bool> _allProps = _ => true;
	private string _outputDir;
	private Person[] _people;
	private BenchmarkUnitTester _tester;

	public override void Cleanup()
	{
		base.Cleanup();

		if (Directory.Exists(this._outputDir))
		{
			Directory.Delete(this._outputDir, true);
		}
	}

	[Benchmark(Description = "MeasureAction: printResult=false (no debug output)")]
	[BenchmarkCategory("MeasureAction")]
	public TimeSpan MeasureActionPrintFalse()
	{
		return this._tester.MeasureAction(() =>
		{
		}, printResult: false, "Bench");
	}

	// ── High Priority #1: MeasureAction – debug separator allocation ──────
	[Benchmark(Description = "MeasureAction: printResult=true (separator allocation)")]
	[BenchmarkCategory("MeasureAction")]
	public TimeSpan MeasureActionPrintTrue()
	{
		return this._tester.MeasureAction(() =>
		{
		}, printResult: true, "Bench");
	}

	// ── High Priority #2: SaveAsJsonToFile – filename generation ─────────
	[Benchmark(Description = "SaveAsJsonToFile: with method name")]
	[BenchmarkCategory("SaveAsJsonToFile")]
	public string SaveAsJsonToFile()
	{
		return this._tester.SaveAsJsonToFile(this._people[0], "BenchmarkMethod");
	}

	[Benchmark(Description = "SaveAsJsonToFile: empty method name (random key)")]
	[BenchmarkCategory("SaveAsJsonToFile")]
	public string SaveAsJsonToFileNoMethod()
	{
		return this._tester.SaveAsJsonToFile(this._people[0], string.Empty);
	}

	// ── High Priority #3: SaveToFile collection – LINQ vs loop ───────────
	[Benchmark(Description = "SaveToFile<T>(IEnumerable<T>): 100 items")]
	[BenchmarkCategory("SaveToFile")]
	public string SaveToFileCollection()
	{
		return this._tester.SaveToFile(this._people, _allProps, "BenchmarkMethod");
	}
	public override void Setup()
	{
		base.Setup();

		this._outputDir = Path.Combine(Path.GetTempPath(), "UnitTesterBenchmark_" + Guid.NewGuid().ToString("N"));
		_ = Directory.CreateDirectory(this._outputDir);
		this._tester = new BenchmarkUnitTester(this._outputDir);
		this._people = [.. RandomData.GeneratePersonRefCollection(100)];
	}
}
/// <summary>
/// A concrete UnitTester subclass used only for benchmarking.
/// </summary>
internal sealed class BenchmarkUnitTester(string outputDirectory) : UnitTester(outputDirectory);
