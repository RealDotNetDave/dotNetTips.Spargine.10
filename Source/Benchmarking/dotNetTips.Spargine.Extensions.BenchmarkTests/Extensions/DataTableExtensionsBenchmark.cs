// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : Copilot Agent
// Created          : 07-09-2026
//
// Last Modified By : Copilot Agent
// Last Modified On : 07-09-2026
// ***********************************************************************
// <copyright file="DataTableExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Benchmark tests for DataTableExtensions methods.</summary>
// ***********************************************************************

using System.Data;
using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using DotNetTips.Spargine.Benchmarking;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Benchmarks for <see cref="DataTableExtensions"/>.
/// </summary>
[SuppressMessage("Reliability", "CA1001:Types that own disposable fields should be disposable", Justification = "Disposed in Cleanup() via BenchmarkDotNet lifecycle.")]
[BenchmarkCategory(Categories.IO)]
[MemoryDiagnoser]
[TailCallDiagnoser]
public class DataTableExtensionsBenchmark : Benchmark
{
	private DataTable _emptyTable = new();
	private DataTable _tableWithRows = new();

	/// <summary>
	/// Cleans up benchmark resources.
	/// </summary>
	public override void Cleanup()
	{
		this._tableWithRows.Dispose();
		this._emptyTable.Dispose();

		base.Cleanup();
	}

	[Benchmark(Description = nameof(DataTableExtensions.HasRows) + ": Empty table")]
	public void HasRowsEmptyTable()
	{
		var result = this._emptyTable.HasRows();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataTableExtensions.HasRows) + ": Null table")]
	public void HasRowsNullTable()
	{
		DataTable? table = null;
		var result = table.HasRows();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataTableExtensions.HasRows) + ": With rows")]
	public void HasRowsWithRows()
	{
		var result = this._tableWithRows.HasRows();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataTableExtensions.IsDBNull) + ": DBNull.Value")]
	public void IsDBNullDbNullValue()
	{
		object value = DBNull.Value;
		var result = value.IsDBNull();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(DataTableExtensions.IsDBNull) + ": Non DBNull value")]
	public void IsDBNullNonDbNullValue()
	{
		object value = "value";
		var result = value.IsDBNull();
		this.Consume(result);
	}

	/// <summary>
	/// Sets up benchmark data tables.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._tableWithRows.Dispose();
		this._emptyTable.Dispose();
		this._tableWithRows = CreateTableWithRows();
		this._emptyTable = CreateEmptyTable();
	}

	private static DataTable CreateEmptyTable()
	{
		var table = new DataTable();
		_ = table.Columns.Add("Id", typeof(int));

		return table;
	}

	private static DataTable CreateTableWithRows()
	{
		var table = new DataTable();
		_ = table.Columns.Add("Id", typeof(int));
		_ = table.Rows.Add(1);
		table.AcceptChanges();

		return table;
	}
}
