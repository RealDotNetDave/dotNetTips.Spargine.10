// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-25-2025
//
// Last Modified By : David McCarter
// Last Modified On : 06-21-2026
// ***********************************************************************
// <copyright file="DataReaderExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Data;
using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="DataReaderExtensions"/>.
/// </summary>
[SuppressMessage("Reliability", "CA1001:Types that own disposable fields should be disposable", Justification = "Disposed in Cleanup() via BenchmarkDotNet lifecycle.")]
[BenchmarkCategory(Categories.IO)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class DataReaderExtensionsBenchmark : Benchmark
{

	private const int RowCount = 100;

	private DataTable _dataTable = default!;

	public override void Cleanup()
	{
		this._dataTable?.Dispose();

		base.Cleanup();
	}

	/// <summary>
	/// Setups the data table with mixed column types and rows.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._dataTable = new DataTable();
		_ = this._dataTable.Columns.Add("Id", typeof(int));
		_ = this._dataTable.Columns.Add("Name", typeof(string));
		_ = this._dataTable.Columns.Add("Email", typeof(string));
		_ = this._dataTable.Columns.Add("Score", typeof(double));
		_ = this._dataTable.Columns.Add("Created", typeof(DateTime));

		for (var rowIndex = 0; rowIndex < RowCount; rowIndex++)
		{
			_ = this._dataTable.Rows.Add(
				rowIndex,
				$"Person{rowIndex}",
				$"person{rowIndex}@example.com",
				rowIndex * 1.5,
				DateTime.UtcNow.AddDays(-rowIndex));
		}

		this._dataTable.AcceptChanges();
	}

	[Benchmark(Description = nameof(DataReaderExtensions.ToCsv) + ": With Header")]
	public void ToCsvWithHeader()
	{
		using var reader = this._dataTable.CreateDataReader();

		var result = reader.ToCsv(includeHeaderAsFirstRow: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataReaderExtensions.ToCsv) + ": Without Header")]
	public void ToCsvWithoutHeader()
	{
		using var reader = this._dataTable.CreateDataReader();

		var result = reader.ToCsv(includeHeaderAsFirstRow: false);

		this.Consume(result);
	}
}
