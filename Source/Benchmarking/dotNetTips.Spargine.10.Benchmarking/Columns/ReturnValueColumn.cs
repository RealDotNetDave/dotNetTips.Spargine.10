// ***********************************************************************
// Assembly         : DotNetTips.Spargine.10.Benchmarking
// Author           : David McCarter
// Created          : 08-03-2026
//
// Last Modified By : David McCarter
// Last Modified On : 08-03-2026
// ***********************************************************************
// <copyright file="ReturnValueColumn.cs" company="dotNetTips.com - McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Custom BenchmarkDotNet output column that displays precomputed benchmark return values.</summary>
// ***********************************************************************

using System.Reflection;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using DotNetTips.Spargine.Core;

//'![](7050BB9CE02F97B17501B57A581147A7.png;https://bit.ly/Spargine ;;0.01188,0.01188)

namespace DotNetTips.Spargine.Benchmarking.Columns
{
	/// <summary>
	/// Represents a custom BenchmarkDotNet column that resolves and prints
	/// the return value of each benchmark workload.
	/// </summary>
	/// <remarks>
	/// The column attempts to instantiate the benchmark type, execute <c>Setup</c>,
	/// invoke the workload method, and then execute <c>Cleanup</c>. If a return value
	/// cannot be resolved safely, <c>N/A</c> is displayed.
	/// </remarks>
	[Information(nameof(ReturnValueColumn), Status = Status.New)]
	public sealed class ReturnValueColumn : IColumn
	{
		private const string NotAvailable = "N/A";

		/// <summary>
		/// Gets a value indicating whether this column should always be displayed.
		/// </summary>
		public bool AlwaysShow => true;

		/// <summary>
		/// Gets the BenchmarkDotNet category for this column.
		/// </summary>
		public ColumnCategory Category => ColumnCategory.Custom;

		/// <summary>
		/// Gets the column display name.
		/// </summary>
		public string ColumnName => "Return Value";

		/// <summary>
		/// Gets the unique identifier for this column.
		/// </summary>
		public string Id => nameof(ReturnValueColumn);

		/// <summary>
		/// Gets a value indicating whether the rendered values are numeric.
		/// </summary>
		public bool IsNumeric => false;

		/// <summary>
		/// Gets the legend text shown for this column in reports.
		/// </summary>
		public string Legend => "Precomputed benchmark return value";

		/// <summary>
		/// Gets the ordering priority within the column category.
		/// </summary>
		public int PriorityInCategory => 0;

		/// <summary>
		/// Gets the unit type used for this column.
		/// </summary>
		public UnitType UnitType => UnitType.Dimensionless;

		/// <summary>
		/// Returns the value to display for the specified benchmark case using the default summary style.
		/// </summary>
		/// <param name="summary">The benchmark summary containing report context.</param>
		/// <param name="benchmarkCase">The benchmark case whose return value should be rendered.</param>
		/// <returns>The formatted return value, or <c>N/A</c> if it cannot be resolved.</returns>
		public string GetValue(Summary summary, BenchmarkCase benchmarkCase)
		{
			return this.GetValue(summary, benchmarkCase, SummaryStyle.Default);
		}

		/// <summary>
		/// Returns the value to display for the specified benchmark case.
		/// </summary>
		/// <param name="summary">The benchmark summary containing report context.</param>
		/// <param name="benchmarkCase">The benchmark case whose return value should be rendered.</param>
		/// <param name="style">The summary style used for culture-aware formatting.</param>
		/// <returns>The formatted return value, or <c>N/A</c> if it cannot be resolved.</returns>
		/// <exception cref="ArgumentNullException">
		/// Thrown if <paramref name="summary"/>, <paramref name="benchmarkCase"/>, or <paramref name="style"/> is <c>null</c>.
		/// </exception>
		public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style)
		{
			ArgumentNullException.ThrowIfNull(summary);
			ArgumentNullException.ThrowIfNull(benchmarkCase);
			ArgumentNullException.ThrowIfNull(style);

			return ResolveReturnValue(benchmarkCase, style.CultureInfo);
		}

		/// <summary>
		/// Determines whether this column is available for the provided summary.
		/// </summary>
		/// <param name="summary">The benchmark summary.</param>
		/// <returns><see langword="true"/> for all summaries.</returns>
		/// <exception cref="ArgumentNullException">Thrown if <paramref name="summary"/> is <c>null</c>.</exception>
		public bool IsAvailable(Summary summary)
		{
			ArgumentNullException.ThrowIfNull(summary);

			return true;
		}

		/// <summary>
		/// Determines whether this column is considered a default column.
		/// </summary>
		/// <param name="summary">The benchmark summary.</param>
		/// <param name="benchmarkCase">The benchmark case being rendered.</param>
		/// <returns><see langword="true"/> for all benchmark cases.</returns>
		/// <exception cref="ArgumentNullException">
		/// Thrown if <paramref name="summary"/> or <paramref name="benchmarkCase"/> is <c>null</c>.
		/// </exception>
		public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase)
		{
			ArgumentNullException.ThrowIfNull(summary);
			ArgumentNullException.ThrowIfNull(benchmarkCase);

			return true;
		}

		/// <summary>
		/// Returns the display name of the column.
		/// </summary>
		/// <returns>The value of <see cref="ColumnName"/>.</returns>
		public override string ToString()
		{
			return this.ColumnName;
		}

		/// <summary>
		/// Formats the value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="formatProvider">The format provider.</param>
		/// <returns>System.String.</returns>
		private static string FormatValue(object? value, IFormatProvider formatProvider)
		{
			if (value is null)
			{
				return NotAvailable;
			}

			if (value is IFormattable formattable)
			{
				return formattable.ToString(format: null, formatProvider);
			}

			var compressionRatioProperty = value.GetType().GetProperty("CompressionRatio", BindingFlags.Instance | BindingFlags.Public);

			if (compressionRatioProperty?.GetValue(value) is IFormattable ratio)
			{
				return ratio.ToString(format: null, formatProvider);
			}

			return value.ToString() ?? NotAvailable;
		}

		/// <summary>
		/// Resolves the return value.
		/// </summary>
		/// <param name="benchmarkCase">The benchmark case.</param>
		/// <param name="formatProvider">The format provider.</param>
		/// <returns>System.String.</returns>
		private static string ResolveReturnValue(BenchmarkCase benchmarkCase, IFormatProvider formatProvider)
		{
			try
			{
				var benchmarkType = benchmarkCase.Descriptor.Type;
				var workloadMethod = benchmarkCase.Descriptor.WorkloadMethod;

				if (workloadMethod.GetParameters().Length > 0)
				{
					return NotAvailable;
				}

				var instance = Activator.CreateInstance(benchmarkType);
				if (instance is null)
				{
					return NotAvailable;
				}

				var setupMethod = benchmarkType.GetMethod("Setup", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				_ = setupMethod?.Invoke(instance, null);

				var returnValue = workloadMethod.Invoke(instance, null);

				if (returnValue is Task task)
				{
					task.GetAwaiter().GetResult();
					returnValue = task.GetType().GetProperty("Result", BindingFlags.Instance | BindingFlags.Public)?.GetValue(task);
				}

				var cleanupMethod = benchmarkType.GetMethod("Cleanup", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				_ = cleanupMethod?.Invoke(instance, null);

				return FormatValue(returnValue, formatProvider);
			}
			catch (ArgumentException)
			{
				return NotAvailable;
			}
			catch (InvalidOperationException)
			{
				return NotAvailable;
			}
			catch (MemberAccessException)
			{
				return NotAvailable;
			}
			catch (TargetInvocationException)
			{
				return NotAvailable;
			}
			catch (NotSupportedException)
			{
				return NotAvailable;
			}
		}
	}
}
